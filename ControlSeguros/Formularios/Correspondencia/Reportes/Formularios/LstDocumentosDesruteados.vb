Imports Utilerias.Genericas

Public Class LstDocumentosDesruteados

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Documentos " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaAgenda.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "DOCUMENTOS DESRUTEADOS ENTRE " & Me.txtFechaDesde.Text.Trim.ToUpper & " AL " & Me.txtFechaHasta.Text.Trim.ToUpper, "", "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"), clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim sql As String = ""
            sql = "  select "
            sql &= " d.IdFlujoDoc"
            sql &= ", d.IdImpresion"
            sql &= ", d.FechaDesruteo"
            sql &= ", d.Motivo"
            sql &= ", (select FechaEnvio from FlujosDocumentosImpresiones as i where i.IdFlujoDoc = d.IdFlujoDoc and i.IdImpresion = d.IdImpresion) as FechaEnvio"
            sql &= " from FlujosDocumentosImpresionesDes as d"
            sql &= " where d.FechaDesruteo between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(CDate(txtFechaHasta.Valor).ToShortDateString, "23:59:59")
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol inner join FlujosDocumentos as f on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto where f.IdFlujoDoc = d.IdFlujoDoc and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If


            Dim Datos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridAgenda.DataSource = Datos
            Me.GridAgenda.Refresh()
            If Datos.Rows.Count = 0 Then
                MsgBox("No se encontraron documentos desruteados.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LstDocumentosDesruteados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today
    End Sub
End Class
