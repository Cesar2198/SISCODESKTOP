Imports Utilerias.Genericas

Public Class RepLog

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If txtFechaCorte.Text = "" Then
                MsgBox("Debe especificar la Fecha desde donde se quieren los registros.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim dtLog As DataTable

            dtLog = StiGlobalConn.ObtenerDataset("select * from Log where fecha >= " & dbFec(Me.txtFechaCorte.Valor)).Tables(0)
            Me.GridLog.DataSource = dtLog
            Me.GridLog.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Log " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridLog.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte Actividades del Sistema", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "Actividades desde: " & Me.txtFechaCorte.Text, clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub
End Class
