Imports Utilerias.Genericas

Public Class LstResumenCorrespondencia

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Resumen Correspondencia " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaDoc.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Resumen de Correspondencia entre el " & Me.txtFechaDesde.Text.Trim.ToUpper & " al " & Me.txtFechaHasta.Text.Trim.ToUpper, "", "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"), clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtFechaDesde.Text = "" Then
            MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " TipoFlujo"
            sql &= ", isnull((select top 1 DescripcionZona from zonas where zonas.idzona = FlujosDocumentosImpresiones.idzona),'') as Zona"
            sql &= ", IdImpresion"
            sql &= ", FechaImpresion"
            sql &= ", Descripcion"
            sql &= ", FechaEnvio"
            sql &= ", FechaEnDocumento "

            sql &= ", Claves as Documento"
            sql &= ", IdOrigen as Origen"
            sql &= ", isnull(IdDestinatario,'') + ' ' + isnull(NombreDestinatario,'') as Destinatario"
            sql &= ", Courier"
            sql &= ", TipoDocumento"
            sql &= ", CantidadDocumentos"

            sql &= " from FlujosDocumentosImpresiones "
            sql &= " where FechaImpresion between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(CDate(txtFechaHasta.Valor).ToShortDateString, "23:59:59")
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol inner join FlujosDocumentos as f on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto where f.IdFlujoDoc = FlujosDocumentosImpresiones.IdFlujoDoc and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim dtDoc As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)

            Me.GridDoc.DataSource = dtDoc
            Me.GridDoc.Refresh()

            If dtDoc.Rows.Count = 0 Then
                MsgBox("No se encontró correspondencia para las fecha especificadas.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LstResumenCorrespondencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = Date.Today
        Me.txtFechaHasta.Valor = Date.Today
    End Sub

End Class
