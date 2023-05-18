
Imports Utilerias.Genericas

Public Class conReclamos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub conReclamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " s.IdSiniestro as Reclamo"
            sql &= " , s.IdPoliza"
            sql &= " , s.IdProducto"
            sql &= " , s.IdCertificado"
            sql &= " , s.FechaPresentado as FechaPresentado"
            sql &= " , s.FechaOcurrido as FechaIncurrido"
            sql &= " , s.DescripcionSiniestro as Diagnostico"
            sql &= " , isnull((select sum(ValorPresentado) from SiniestrosDetalle as d where d.IdPoliza = s.IdPoliza and d.IdProducto = s.IdProducto and d.IdCertificado = s.IdCertificado and d.IdSiniestro = s.IdSiniestro),0) as ValorReclamo"
            sql &= " , isnull((select top 1 NumeroCheque from SiniestrosPagos as p where p.IdPoliza = s.IdPoliza and p.IdProducto = s.IdProducto and p.IdCertificado = s.IdCertificado and p.IdSiniestro = s.IdSiniestro),'') as Cheque"
            sql &= " , (select top 1 FechaPago from SiniestrosPagos as p where p.IdPoliza = s.IdPoliza and p.IdProducto = s.IdProducto and p.IdCertificado = s.IdCertificado and p.IdSiniestro = s.IdSiniestro) as FechaPago"
            sql &= " , isnull((select sum(ValorCubierto) from SiniestrosDetalle as d where d.IdPoliza = s.IdPoliza and d.IdProducto = s.IdProducto and d.IdCertificado = s.IdCertificado and d.IdSiniestro = s.IdSiniestro),0) as Cubierto"
            sql &= " , s.TotalDeducible as Deducible"
            sql &= " , s.TotalCoaseguro as Coaseguro"
            sql &= " , s.TotalDeudores as Deudores"
            sql &= " , s.TotalReembolso as NetoPagar"
            sql &= " ,s.DescripcionReserva as Observacion"
            sql &= " ,s.EstadoSiniestro as Estado"
            sql &= " from Siniestros as s"
            sql &= " where s.IdSiniestro is not null"
            If txtIdPoliza.Text <> "" Then
                sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            End If
            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            End If
            If txtIdCertificado.Text <> "" Then
                sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Text)
            End If

            If txtAsegurado.Text.Trim <> "" Then
                Dim NumPalabras As Integer = CuentaCar(txtAsegurado.Text.Trim, " "), Palabra As String
                For NP As Integer = 0 To NumPalabras
                    Palabra = stiSplit(txtAsegurado.Text.Trim, "G" & NP & " 1").Trim
                    If Palabra <> "" Then
                        sql &= " and s.NombrePresentaReclamo like " & dbStr("%" & Palabra & "%")
                    End If
                Next
            End If

            Dim dtReclamos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridReclamos.DataSource = dtReclamos
            Me.GridReclamos.Refresh()

            If dtReclamos.Rows.Count = 0 Then
                MsgBox("No se encontraron reclamos.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Reclamos" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaReclamos.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte Reclamos", "", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscarAsegurado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAsegurado.Click
        Try
            Dim fbus As New BusquedaCertReclamo
            fbus.dbFiltro = ""
            fbus.ShowDialog()

            If busCodigo <> "" Then
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
                Call btnBuscarCliente_Click(Nothing, Nothing)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaReclamos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaReclamos.DoubleClick
        Try
            Dim FRec As Integer = VistaReclamos.FocusedRowHandle
            If FRec >= 0 Then
                Dim Poliza As String = Me.VistaReclamos.GetRowCellValue(FRec, "IdPoliza")
                Dim Producto As String = Me.VistaReclamos.GetRowCellValue(FRec, "IdProducto")
                Dim Certificado As String = Me.VistaReclamos.GetRowCellValue(FRec, "IdCertificado")
                Dim Reclamo As String = Me.VistaReclamos.GetRowCellValue(FRec, "Reclamo")


                Dim POL As New SiniestrosMan
                POL.Permiso = Me.Permiso
                POL.STIConn = StiGlobalConn
                POL.dbTabla = "Siniestros"
                POL.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto) & " and IdCertificado = " & dbStr(Certificado) & " and IdSiniestro = " & dbStr(Reclamo)
                POL.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
