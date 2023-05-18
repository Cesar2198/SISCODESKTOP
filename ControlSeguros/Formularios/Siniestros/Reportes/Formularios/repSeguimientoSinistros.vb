Imports Utilerias.Genericas

Public Class repSeguimientoSinistros

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Try
            Dim sql As String = ""
            sql = " select "
            sql &= " IdSiniestro"
            sql &= " ,IdPoliza"
            sql &= " ,FechaGestion"
            sql &= " ,Comentarios"
            sql &= " from Gestiones"
            sql &= " where TipoGestion = 'S'"
            If txtIdPoliza.Text <> "" Then 
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            End If
            If txtIdSiniestro.Text <> "" Then
                sql &= " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)
            End If
            If cboIdProducto.Text <> "" Then
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            End If
            If txtFechaInicial.Text <> "" Then
                sql &= " and FechaGestion >= " & dbFec(txtFechaInicial.Valor)
            End If
            If Me.txtFechaFinal.Text <> "" Then
                sql &= " and FechaGestion <= " & dbFec(txtFechaFinal.Valor)
            End If
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = Gestiones.idpoliza and pol.idproducto = Gestiones.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If


            Dim dtDatos As DataTable
            dtDatos = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridSeguimientos.DataSource = dtDatos

            If dtDatos.Rows.Count = 0 Then
                MsgBox("No se encontraron seguimientos.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub repSeguimientoSinistros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Gestiones" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridSeguimientos.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Reporte de Seguimientos de Siniestros", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

End Class
