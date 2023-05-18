Imports Utilerias.Genericas

Public Class RepIngresosCaja

    Private Sub btnBuscaIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaIngresos.Click

        Try
            If txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Information, "AVISO..")
                Exit Sub
            End If

            If txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Information, "AVISO..")
                Exit Sub
            End If

            Dim sql As String = ""

            sql = "  select "
            sql &= " a.Nombre as Asegurador"
            sql &= " ,r.IdRecibo as IdRecibo"
            sql &= " ,r.FechaRecibo as FechaRecibo"
            sql &= " ,case IdTipoIngreso wheN 'E' then 'EFECTIVO' when 'C' then 'CHEQUE' when 'T' then 'TARJETA' when 'N' then 'NOTA DE CREDITO' when 'A' then 'DEPOSITO EN ASEGURADORA' else 'DEPOSITO' end as TipoIngresos"
            sql &= " , p.Total as ValorRecibo"
            sql &= " from Recibos as r"
            sql &= " inner join RecibosPagos as p on r.IdRecibo = p.IdRecibo"
            sql &= " inner join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " where r.FechaRecibo between " & dbFec(Me.txtFechaDesde.Valor) & " and " & dbFec(Me.txtFechaHasta.Valor)

            Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridCaja.DataSource = dtRecibos
            Me.GridCaja.Refresh()

            If dtRecibos.Rows.Count = 0 Then
                MsgBox("No se encontraron recibos.", MsgBoxStyle.Exclamation, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Ingresos " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridCaja.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Ingresos de Caja", "Ingresos entre el " & Me.txtFechaDesde.Text & " y el " & Me.txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub
End Class
