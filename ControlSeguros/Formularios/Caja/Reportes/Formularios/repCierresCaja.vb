Imports Utilerias.Genericas

Public Class repCierresCaja

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub repCierresCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If txtFechaDesde.Text = "" Then
            MsgBox("Debe espeificar la fecha inicial.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If txtFechaHasta.Text = "" Then
            MsgBox("Debe espeificar la fecha final.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.chkDetalle.Checked = False Then
            Call ReporteResumen()
        Else
            Call ReporteDetallado()
        End If

    End Sub

    Private Sub ReporteResumen()
        Try
            Me.Cursor = Cursors.WaitCursor
            btnImprimir.Enabled = False

            Dim dtCaja As New DataTable
            dtCaja.Columns.Add("DiaCaja", System.Type.GetType("System.DateTime"))
            dtCaja.Columns.Add("FechaApertura", System.Type.GetType("System.DateTime"))
            dtCaja.Columns.Add("FechaCierre", System.Type.GetType("System.DateTime"))
            dtCaja.Columns.Add("MontoCierre", System.Type.GetType("System.Double"))
            dtCaja.Columns.Add("UsuarioApertura", System.Type.GetType("System.String"))
            dtCaja.Columns.Add("UsuarioCierre", System.Type.GetType("System.String"))
            dtCaja.Columns.Add("Observaciones", System.Type.GetType("System.String"))
            dtCaja.TableName = "CierresCaja"
            Dim FilDia As DataRow, FilCierre As DataRow, MontoDia As Double = 0
            Dim Fecha As DateTime = Me.txtFechaDesde.Valor
            Dim sql As String = ""

            While Fecha <= CDate(txtFechaHasta.Valor)
                FilDia = dtCaja.NewRow
                Try
                    sql = "  select UsuarioApertura, FechaApertura, UsuarioCierre, FechaCierre "
                    sql &= " from DiasCaja where FechaCaja = " & dbFec(Fecha)
                    FilCierre = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                Catch ex As Exception
                    FilCierre = Nothing
                End Try

                FilDia("DiaCaja") = Fecha
                FilDia("Observaciones") = ""
                If Not FilCierre Is Nothing Then
                    FilDia("FechaApertura") = FilCierre("FechaApertura")
                    FilDia("FechaCierre") = FilCierre("FechaCierre")
                    FilDia("UsuarioApertura") = FilCierre("UsuarioApertura")
                    FilDia("UsuarioCierre") = FilCierre("UsuarioCierre")
                End If

                Try
                    sql = "  select isnull(sum(TotalRecibo),-1) "
                    sql &= " from Recibos where FechaRecibo = " & dbFec(Fecha) & " and EstadoRecibo <> 'N'"
                    MontoDia = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    MontoDia = -1
                End Try

                If MontoDia = -1 Then
                    FilDia("MontoCierre") = 0.0
                    FilDia("Observaciones") = "No hay movimientos de Caja."
                Else
                    FilDia("MontoCierre") = MontoDia
                End If

                dtCaja.Rows.Add(FilDia)
                Fecha = Fecha.AddDays(1)
            End While
            dtCaja.AcceptChanges()

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtCaja.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repCRCierresCaja
            Reporte.SetDataSource(DsRep)
            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Reporte de Cierres de Caja")
            SetRepFormulaString(Reporte, "Titulo2", "Cierres entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
            SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
            btnImprimir.Enabled = True
        End Try
    End Sub

    Private Sub ReporteDetallado()
        Try
            Dim ImpCierre As String = ImprimirCierreCaja(txtFechaDesde.Valor, txtFechaHasta.Valor)
            If ImpCierre <> "" Then
                MsgBox("Error al imprimir el reporte detallado: " & ImpCierre, MsgBoxStyle.Exclamation, "ERROR...")
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class

