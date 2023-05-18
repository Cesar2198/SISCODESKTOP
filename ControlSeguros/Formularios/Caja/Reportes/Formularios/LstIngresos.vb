Imports Utilerias.Genericas

Public Class LstIngresos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            If txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha desde.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha hasta.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            sql = "  select IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo, EstadoRecibo, '' as MontoLetras, '' as UsuarioEmite, FechaAnulacion, UsuarioAnulacion, MotivoAnulacion"
            sql &= "  from Recibos "
            sql &= " where FechaRecibo between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibos.TableName = "Recibos"


            sql = "  select r.IdRecibo, p.IdPago, p.IdTipoIngreso, p.IdBanco, p.Documento, p.NumConfirmacion, p.Total "
            sql &= "  from Recibos as r inner join RecibosPagos as p on r.IdRecibo = p.IdRecibo "
            sql &= " where r.FechaRecibo between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)

            Dim dtRecibosPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibosPagos.TableName = "RecibosPagos"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtRecibos.Copy)
            DsRep.Tables.Add(dtRecibosPagos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repIngresos
            Reporte.SetDataSource(DsRep)
            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Reporte de Ingresos de Pagos de Seguros")
            SetRepFormulaString(Reporte, "Titulo2", "Ingresos entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
            SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LstIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today
    End Sub

End Class
