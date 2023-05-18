Imports Utilerias.Genericas

Public Class ADRAnalisisDocRecibidos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.txtFecha.Text = "" Or Me.txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar las fechas.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            sql &= " select a.IdFlujoDoc , a.IdImpresion , a.Descripcion, a.FechaImpresion, a.UsuarioImprime, a.doc_impreso, a.NumCorrIngreso"
            sql &= " , isnull(a.IdOrigen, b.NombreCliente) as Asegurado"
            sql &= " , a.FechaEnvio, a.RecibeCorrespondencia, a.IdUsuarioEntrega, a.DireccionDocumento"
            sql &= " , isnull(a.NombreDestinatario, b.NombreCliente ) as Destinatario"
            sql &= " , (select min(r.FechaRuteo) from FlujosDocumentosImpresionesRuteos as r where r.IdFlujoDoc = a.IdFlujoDoc and r.IdImpresion = a.IdImpresion ) as PrimerRuteo"
            sql &= " , (select max(r.FechaRuteo) from FlujosDocumentosImpresionesRuteos as r where r.IdFlujoDoc = a.IdFlujoDoc and r.IdImpresion = a.IdImpresion ) as UltimoRuteo"
            sql &= " , (select count(*) from FlujosDocumentosImpresionesRuteos as r where r.IdFlujoDoc = a.IdFlujoDoc and r.IdImpresion = a.IdImpresion  and r.FechaRuteo is not null) as NumRuteos"
            sql &= " , isnull( b.IdImpresionFinal,'') as IdImpresionFinal, b.EstadoFlujo, b.FechaFinaliza"
            sql &= " , (select FechaEnvio from FlujosDocumentosImpresiones as e where e.IdFlujoDoc = b.IdFlujoDoc and e.IdImpresion = b.IdImpresionFinal) as FechaEnvioDocFinal "
            sql &= " from FlujosDocumentosImpresiones as a inner join FlujosDocumentos as b on a.IdFlujoDoc = b.IdFlujoDoc"
            sql &= " where a.TipoFlujo = 'ENTRADA' and cast(convert(char(8),a.FechaImpresion,112) as datetime) between " & dbFec(Me.txtFecha.Valor) & " and " & dbFec(Me.txtFechaHasta.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where  pol.idpoliza = b.idpoliza and pol.idproducto = b.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If


            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            gridDoc.DataSource = dtDatos
            gridDoc.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Flujos " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.gridDoc.ExportToXls(Archivo, Opciones)
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub ADRAnalisisDocRecibidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Valor = Date.Today
        Me.txtFechaHasta.Valor = Date.Today
    End Sub

End Class
