Imports Utilerias.Genericas

Public Class LstRecibosNoAplicados

    Private Sub LstRecibosNoAplicados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaCorte.Valor = Date.Today
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.txtFechaCorte.Text = "" Then
            Exit Sub
            MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
        End If

        Try
            Dim sql As String = ""

            sql = "  select IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo, EstadoRecibo, '' as MontoLetras, '' as UsuarioEmite"
            sql &= "  from Recibos "
            sql &= " where FechaRecibo <= " & dbFec(txtFechaCorte.Valor)
            sql &= " and EstadoRecibo = 'P' "

            Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibos.TableName = "Recibos"

            If dtRecibos.Rows.Count = 0 Then
                MsgBox("No existen recibos pendientes de aplicar.", MsgBoxStyle.Information, "AVISO...")
            Else
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtRecibos.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes
                Dim Reporte As New repPendientesAplicar
                Reporte.SetDataSource(DsRep)
                ''Definiremos algunos datos del reporte
                SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
                SetRepFormulaString(Reporte, "Titulo1", "Reporte de Recibos pendientes de Aplicar")
                SetRepFormulaString(Reporte, "Titulo2", "Fecha de corte: " & Format(txtFechaCorte.Valor, "dd/MMM/yyyy"))
                SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
                SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

                rep.CRViewer.ReportSource = Reporte
                rep.MdiParent = Me.MdiParent
                rep.Show()
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
