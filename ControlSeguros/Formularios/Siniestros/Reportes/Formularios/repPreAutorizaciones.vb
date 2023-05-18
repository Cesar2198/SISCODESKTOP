
Imports Utilerias.Genericas

Public Class repPreAutorizaciones

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub repPreAutorizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte PreCertificaciones " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaPreAutorizaciones.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Pre-Certificaciones", "Pre-Autorizaciones entre el " & Me.txtFechaDesde.Text & " y el " & Me.txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Exclamation, "AVISO...")
                Exit Sub
            End If

            If Me.txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Exclamation, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            sql = "  select "
            sql &= " u.IdAutorizacion as IdAutorizacion"
            sql &= " ,u.Estado as Estado"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.Descripcion as Producto"
            sql &= " ,u.IdPoliza as Poliza"
            sql &= " ,u.NombreAsegurado as Asegurado"
            sql &= " ,u.FechaRecibida as FechaRecibida"
            sql &= " ,u.FechaEnvio as FechaEnvio"
            sql &= " ,u.FechaRespuesta as FechaRespuesta"
            sql &= " ,u.Proveedor as Proveedor"
            sql &= " ,u.ValorReclamo as ValorReclamo"
            sql &= " ,u.ValorCubierto as ValorCubierto"
            sql &= " ,u.NombrePaciente"
            sql &= " ,u.GestionSolicitada"

            sql &= " from PreAutorizaciones as u"
            sql &= " left join Productos as p on p.idproducto = u.idproducto"
            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where FechaRecibida between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = u.idpoliza and pol.idproducto = u.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim dtCert As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridPreAutorizaciones.DataSource = dtCert
            GridPreAutorizaciones.Refresh()

            If dtCert.Rows.Count = 0 Then
                MsgBox("No se han encontrado pre-certificaciones para las fechas especificadas.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaPreAutorizaciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPreAutorizaciones.DoubleClick
        Dim Fila As Integer = Me.VistaPreAutorizaciones.FocusedRowHandle
        If Fila >= 0 Then
            Dim FPC As New PreCertificacionesMan
            FPC.Permiso = Me.Permiso
            FPC.dbTabla = "PreAutorizaciones"
            FPC.dbCondicion = " IdAutorizacion = " & dbStr(Me.VistaPreAutorizaciones.GetRowCellValue(Fila, "IdAutorizacion"))
            FPC.STIConn = StiGlobalConn
            FPC.MdiParent = Me.MdiParent
            FPC.Show()

        End If
    End Sub
End Class
