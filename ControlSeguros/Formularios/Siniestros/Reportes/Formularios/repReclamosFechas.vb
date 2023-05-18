Imports Utilerias.Genericas

Public Class repReclamosFechas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim strSQL As String = ""
        If Me.txtDesde.Text = "" Or Me.txtHasta.Text = "" Then
            MsgBox("Debe especificar las fechas para buscar siniestros.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtIdCliente.Text = "" And Me.cboIdProducto.Text = "" And Me.cboRamo.Text = "" And Me.txtIdPoliza.Text = "" Then
            MsgBox("Debe especificar al menos un filtro de búsqueda.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor : Application.DoEvents()
            strSQL = "   select s.IdSiniestroAseguradora"
            strSQL &= "  ,s.IdSiniestro"
            strSQL &= "  , a.Nombre  as Aseguradora"
            strSQL &= "  , c.IdCliente"
            strSQL &= "  , c.NombreCliente"
            strSQL &= "  , s.EstadoSiniestro"
            strSQL &= "  , FechaAvisoCliente, FechaAvisoAseguradora, FechaSolicitaInspeccion, FechaInspeccion"
            strSQL &= "  , FechaAjustadorReqDocs, FechaCienteEntregaDocs, FechaEnvioDocAseg, FechaRecibeConvAjuste"
            strSQL &= "  , FechaEnvioClientreConvAju, FechaFirmaConvAjuste, FechaEnvioConvAseg, FechaAsegEntregaCheque"
            strSQL &= "  , FechaEntregaCheque, FechaEntregaFiniquito, FechaEnvioFiniquitoAseg, FechaFinalReclamo, r.NombreRamo as Ramo"
            strSQL &= "  , 0 as Total1, 0 as Total2, 0 as Total3, 0 as Total4, s.ClaseSiniestro"
            strSQL &= "  from siniestros as s with (nolock) "
            strSQL &= "  inner join productos as p  with (nolock)  on p.idproducto = s.idproducto"
            strSQL &= "  inner join RamoSeguros as r  with (nolock)  on r.IdRamo = p.IdRamo"
            strSQL &= "  inner join aseguradoras as a  with (nolock)  on a.idaseguradora = p.idaseguradora"
            strSQL &= "  inner join Polizas as o with (nolock) on o.IdPoliza = s.IdPoliza and o.IdProducto = s.IdProducto "
            strSQL &= "  inner join PolizasCertificados as c  with (nolock)  on c.IdPoliza = s.IdPoliza and c.IdProducto = s.IdProducto and c.IdCertificado = s.IdCertificado"
            strSQL &= "  where "
            strSQL &= "  s.FechaOcurrido between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor)
            If txtIdCliente.Text <> "" Then
                strSQL &= "  and (o.idcliente = " & dbStr(txtIdCliente.Valor) & " or c.idcliente = " & dbStr(txtIdCliente.Valor) & ") "
            End If
            If cboRamo.Text <> "" Then
                strSQL &= "  and r.IdRamo = " & dbStr(cboRamo.Valor)
            End If
            If cboIdProducto.Text <> "" And txtIdPoliza.Text = "" Then
                strSQL &= "  and s.idproducto = " & dbStr(cboIdProducto.Valor)
            End If
            If cboIdProducto.Text <> "" And txtIdPoliza.Text <> "" Then
                strSQL &= "  and s.idproducto = " & dbStr(cboIdProducto.Valor) & " and s.idpoliza = " & dbStr(txtIdPoliza.Valor)
            End If

            'strSQL &= "  and p.tipoproducto = 'DAÑOS' "
            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(strSQL).Tables(0)
            PivotReclamos.DataSource = dtDatos
            PivotReclamos.Refresh()

            If dtDatos.Rows.Count = 0 Then
                MsgBox("No se encontraron siniestros entre las fechas especificadas.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub repReclamosFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtHasta.Valor = Date.Today
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
        Me.cboRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboRamo.Llenar_Combo()
    End Sub

    Private Function GetFieldName(ByVal Area As DevExpress.XtraPivotGrid.PivotArea, ByVal AreaIndex As Integer) As String
        Dim res As String = ""
        Try
            For Each col As DevExpress.XtraPivotGrid.PivotGridField In PivotReclamos.Fields
                If col.Area = Area And col.AreaIndex = AreaIndex Then Return col.FieldName
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Private Sub PivotReclamos_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotReclamos.CustomSummary
        Try
            If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
                Dim strNomFecha1 As String = GetFieldName(e.DataField.Area, e.DataField.AreaIndex - 2)
                Dim strNomFecha2 As String = GetFieldName(e.DataField.Area, e.DataField.AreaIndex - 1)


                If strNomFecha1 <> "" And strNomFecha2 <> "" Then
                    Dim Fec1 As DateTime, Fec2 As DateTime

                    Dim list As IList = e.CreateDrillDownDataSource()
                    For i As Integer = 0 To list.Count - 1
                        Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)
                        Fec1 = row(strNomFecha1)
                        Fec2 = row(strNomFecha2)
                    Next
                    e.CustomValue = Math.Round(clSeguros.ObtenerHorasLaborales(Fec1, Fec2) / 8, 0)

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Fechas Reclamos " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotReclamos.ExportToXls(Archivo, Opciones)
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas "
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
End Class
