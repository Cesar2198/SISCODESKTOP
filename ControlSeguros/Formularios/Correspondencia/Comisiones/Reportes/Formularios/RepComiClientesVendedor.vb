Imports Utilerias.Genericas

Public Class RepComiClientesVendedor

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Comisiones " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotComi.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Clientes por Productor", "Reporte de producción entre el " & Me.txtFechaDesde.Text & " y" & Me.txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try
            If Me.txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If Me.txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim strsql As String = ""
            strsql = "  select "
            strsql &= " isnull(cl.NombreCliente, f.NombreCliente) as Cliente"
            strsql &= " , r.NombreRamo as Ramo"
            strsql &= " , f.IdPoliza as IdPoliza"
            strsql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
            strsql &= " , v.NombreVendedor as Vendedor"
            strsql &= " , f.VigenciaDesde as VigenciaDesde"
            strsql &= " , f.VigenciaHasta as VigenciaHasta"
            strsql &= " , isnull((select top 1 IdAvisoCobro from AvisosCobroFacturas as a where a.IdPoliza = f.IdPoliza and a.IdProducto = f.IdProducto and a.NumeroFactura = f.NumeroFactura and a.IdRamo = f.IdRamo),'') as NoAC"
            strsql &= " , (select sum(c.ValorAsegurado) from PolizasCertificados as c where c.idpoliza = f.idpoliza and c.idproducto = f.idproducto and c.FechaExclusion is null and c.RazonExclusion is null) as Suma"
            strsql &= " , isnull((select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo and m.TipoMovimiento in ('EMISION','ANULACION')),0) as PrimaNeta"
            strsql &= " , f.PorceComision as PorceComision"
            strsql &= " , (select sum(m.Comision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo and m.TipoMovimiento in ('EMISION','ANULACION')) as Comision"
            strsql &= " , 0.0 as PorceComiVend"
            strsql &= " , 0.0 as ComiVendedor"
            strsql &= " , pv.IdVendedor"
            strsql &= " , f.IdProducto"
            strsql &= " , f.NumCuota, f.TotalCuotas, p.EstadoPoliza"
            strsql &= " from Facturas as f"
            strsql &= " inner join RamoSeguros as r on f.IdRamo = r.IdRamo"
            strsql &= " inner join PolizasVendedores as pv on pv.IdPoliza = f.idpoliza and pv.IdProducto = f.IdProducto"
            strsql &= " inner join Vendedores as v on pv.IdVendedor = v.IdVendedor"
            strsql &= " left join Polizas as p on p.idpoliza = f.idpoliza and p.idproducto = f.idproducto"
            strsql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            strsql &= " where FechaPago between " & dbFec(Me.txtFechaDesde.Valor) & " and " & dbFec(Me.txtFechaHasta.Valor)

            If cboEstado.Valor = "V" Then
                strsql &= " and p.estadopoliza = 'VIGENTE' and p.FechaCancelacion is null "
            End If

            If cboEstado.Valor = "C" Then
                strsql &= " and (p.estadopoliza <> 'VIGENTE' or p.FechaCancelacion is not null )"
            End If

            If VisibilidadUsuario() = "D" Then
                strsql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset(strsql).Tables(0)
            Dim filFactura As DataRow, ComiAge As ComisionVendedor
            For Each filFactura In dtFacturas.Rows
                'calcularemos el porcentaje y comision del vendedor
                ComiAge = ObtenerComisionVendedor(dbData(filFactura, "IdVendedor"), dbData(filFactura, "IdProducto"), dbData(filFactura, "IdPoliza"))
                filFactura("PorceComiVend") = ComiAge.Porce
                Select Case ComiAge.FormaPago
                    Case "PERIODICA"
                        filFactura("ComiVendedor") = (Val(filFactura("Comision")) * (Val(ComiAge.Porce) / 100)) + Val(ComiAge.Valor)
                    Case "ANTICIPADA"
                        'En la comision anticipada la comision se paga únicamente en la cuota 1
                        'y se paga en su totalidad por las demás cuotas aunque no estén pagadas
                        If Val(filFactura("NumCuota")) = 1 Then
                            filFactura("ComiVendedor") = (Val(filFactura("Comision")) * (Val(filFactura("TotalCuotas"))) * (Val(ComiAge.Porce) / 100)) + Val(ComiAge.Valor)
                        End If
                End Select
            Next

            If dtFacturas.Rows.Count = 0 Then
                MsgBox("No se encontraron facturas.", MsgBoxStyle.Information, "AVISO...")
            End If
            PivotComi.DataSource = dtFacturas : PivotComi.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub RepComiClientesVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboEstado.Llenar_Combo()
    End Sub
End Class
