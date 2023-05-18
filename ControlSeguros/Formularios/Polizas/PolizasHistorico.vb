
Imports Utilerias.Genericas

Public Class PolizasHistorico

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Try
            Dim Fbus As New BusquedaPolizas
            Fbus.Text = "Búsqueda de Pólizas"
            Fbus.dbFiltro = ""
            busCodigo = ""
            Fbus.ShowDialog()
            If busCodigo <> "" Then
                Dim sql As String = ""
                sql = "  select HPolizas.IdHistorico, HPolizas.IdPoliza, HPolizas.IdProducto, Productos.Descripcion as Producto,HPolizas.NombreCliente as Cliente, HPolizas.VigenciaDesde, HPolizas.VigenciaHasta"
                sql &= " ,(select sum(ValorAsegurado) from HPolizasCertificados where HPolizasCertificados.IdPoliza = HPolizas.IdPoliza and HPolizasCertificados.IdProducto = HPolizas.IdProducto and HPolizasCertificados.IdHistorico = HPolizas.IdHistorico and HPolizasCertificados.RazonExclusion is null) as SumaAsegurada"
                sql &= " from HPolizas "
                sql &= " inner join Productos on Productos.IdProducto = HPolizas.IdProducto "
                sql &= " where HPolizas.IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and HPolizas.IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))
                sql &= " order by HPolizas.IdHistorico desc"
                Dim HPol As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)

                If HPol.Rows.Count = 0 Then
                    MsgBox("No se han encontrado registros historico para la póliza seleccionada.", MsgBoxStyle.Information, "AVISO...")
                End If

                Me.GridPoliza.DataSource = HPol
                Me.GridPoliza.Refresh()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaPoliza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPoliza.DoubleClick
        Try
            Dim Fila As Integer = Me.VistaPoliza.FocusedRowHandle
            If Fila >= 0 Then
                Dim FpolH As New HPolizasMan
                FpolH.dbTabla = "HPolizas"
                FpolH.STIConn = StiGlobalConn
                FpolH.Permiso = "L"  'toda consulta historica es solo lectura
                FpolH.dbCondicion = "IdPoliza = " & dbStr(Me.VistaPoliza.GetRowCellValue(Fila, "IdPoliza")) & " and IdProducto = " & dbStr(Me.VistaPoliza.GetRowCellValue(Fila, "IdProducto")) & " and IdHistorico = " & dbInt(Me.VistaPoliza.GetRowCellValue(Fila, "IdHistorico"))
                FpolH.ClavesNuevo = ""
                FpolH.ShowDialog(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generaremos una resumen del historico.
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\ReporteHistoricoPolizas" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaPoliza.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte Historico de Póliza", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "", clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

End Class
