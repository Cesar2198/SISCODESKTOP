Imports Utilerias.Genericas

Public Class repMovimientosPolizas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\ReporteMovimientos" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaPolizas.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte Movimientos a Pólizas", "Movimientos entre el " & txtFechaInicial.Text & " y el " & Me.txtFechaFinal.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscarOfertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOfertas.Click
        If txtFechaInicial.Text = "" Or txtFechaInicial.Text = "" Then
            MsgBox("Debe especificar las fechas para el reporte.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " ROW_NUMBER() OVER (ORDER BY f.FechaInicia) as Num"
            sql &= " , a.Nombre as Aseguradora"
            sql &= " , f.FechaInicia as FechaFlujo"
            sql &= " , p.NombreCliente as Cliente"
            sql &= " , p.idpoliza as IdPoliza"
            sql &= " , p.IdProducto as IdProducto"
            sql &= " , f.Comentario as Descripcion"
            sql &= " , p.ResumenPrimaAnual as PrimaNeta"
            sql &= " , f.EstadoFlujo as Estado"
            sql &= " , p.ObservacionesAnexos as Observaciones"
            sql &= " , P.FechaEnvioAnexo as FechaEnvio"
            sql &= " from FlujosDocumentos as f "
            sql &= " inner join Polizas as p on f.idpoliza = p.idpoliza and f.idproducto = p.idproducto"
            sql &= " inner join Productos as r on r.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = r.idaseguradora"
            sql &= " where f.idpoliza is not null and f.idproducto is not null and f.NumeroFactura is null and f.IdSiniestro is null and f.IdAvisoCobro is null"
            sql &= " and f.FechaInicia between " & dbFec(txtFechaInicial.Text) & " and " & dbFec(txtFechaFinal.Text)
            sql &= " order by f.FechaInicia"

            Dim dtPolizas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            gridPolizas.DataSource = dtPolizas
            gridPolizas.Refresh()

            If dtPolizas.Rows.Count = 0 Then MsgBox("No se encontraron movimientos de pólizas.", MsgBoxStyle.Information, "AVISO..")

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaPolizas_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaPolizas.CellValueChanged
        Me.VistaPolizas.PostEditor()
        Me.VistaPolizas.UpdateCurrentRow()

        If e.Column.FieldName = "FechaEnvio" Or e.Column.FieldName = "Observaciones" Or e.Column.FieldName = "PrimaNeta" Then
            ''actualizamos la póliza
            Try
                Dim sql As String = ""
                sql = " update Polizas "
                sql &= " set ObservacionesAnexos = " & dbStr(Me.VistaPolizas.GetRowCellValue(e.RowHandle, "Observaciones"))
                sql &= " , ResumenPrimaAnual = " & dbNum(Me.VistaPolizas.GetRowCellValue(e.RowHandle, "PrimaNeta"))
                sql &= " , FechaEnvioAnexo = " & dbFec(Me.VistaPolizas.GetRowCellValue(e.RowHandle, "FechaEnvio"))
                sql &= " where IdPoliza = " & dbStr(Me.VistaPolizas.GetRowCellValue(e.RowHandle, "IdPoliza"), 25)
                sql &= " and IdProducto = " & dbStr(Me.VistaPolizas.GetRowCellValue(e.RowHandle, "IdProducto"), 25)
                StiGlobalConn.SQLExecute(sql)

            Catch ex As Exception

            End Try
        End If
    End Sub

End Class

