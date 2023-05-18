Imports Utilerias.Genericas

Public Class SiniestralidadClientes
    Dim dtPolizas As DataTable

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        Dim sql As String = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                sql = "  select c.NombreCliente "
                sql &= " from Clientes as c"
                sql &= " where idcliente = " & dbStr(busCodigo)
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")

            Catch ex As Exception

            End Try

            Call ObtenerSiniestralidadCliente(Me.txtIdCliente.Valor)
        End If
    End Sub

    Private Sub ObtenerSiniestralidadCliente(ByVal IdCliente As String)
        Try
            'obtendesmos las póliza con primas y reclamos del cliente
            Dim sql As String = ""

            sql = "  select "
            sql &= " a.Nombre as Aseguradora"
            sql &= ", po.IdPoliza"
            sql &= ", po.IdProducto"
            sql &= ", pr.Descripcion as Producto"
            sql &= ", po.VigenciaDesde "
            sql &= ", po.VigenciaHasta"
            'primas emitidas en el periodo
            sql &= ", isnull(( select sum(m.PrimaNeta) from Facturas as fa inner join FacturasMovimientos as m on fa.NumeroFactura = m.NumeroFactura and fa.IdProducto = m.IdProducto and fa.IdPoliza = m.IdPoliza and fa.IdRamo = m.IdRamo  where po.idpoliza = fa.idpoliza and po.idproducto = fa.idproducto and m.tipomovimiento in ('EMISION','ANULACION') and fa.FechaPago >= po.VigenciaDesde and fa.FechaPago < po.VigenciaHasta),0.0) as PrimaNeta"
            sql &= ", isnull(( select sum(m.PrimaNeta) from Facturas as fa inner join FacturasMovimientos as m on fa.NumeroFactura = m.NumeroFactura and fa.IdProducto = m.IdProducto and fa.IdPoliza = m.IdPoliza and fa.IdRamo = m.IdRamo  where po.idpoliza = fa.idpoliza and po.idproducto = fa.idproducto and m.tipomovimiento in ('EMISION','ANULACION') and fa.FechaPago >= po.VigenciaDesde and fa.FechaPago < po.VigenciaHasta),0.0) * (  (datediff(dd, po.VigenciaDesde, case when getdate() > po.VigenciaHasta then po.VigenciaHasta when po.VigenciaDesde > getdate() then po.VigenciaDesde  else getdate() end)  ) / cast( (datediff(dd,po.VigenciaDesde,po.VigenciaHasta)  ) as numeric(10,2))  ) as PrimaDevengada"
            sql &= ", datediff(dd, po.VigenciaDesde, case when getdate() > po.VigenciaHasta then po.VigenciaHasta when po.VigenciaDesde > getdate() then po.VigenciaDesde  else getdate() end) as DiasDev"
            sql &= ", isnull(( select sum(pa.ValorGasto) from Siniestros as si inner join SiniestrosPagos as pa on si.IdPoliza = pa.IdPoliza and si.IdProducto = pa.IdProducto and si.IdCertificado = pa.IdCertificado and si.IdSiniestro = pa.IdSiniestro where si.idpoliza = po.idpoliza and si.idproducto = po.idproducto and si.FechaOcurrido >= po.VigenciaDesde and si.FechaOcurrido < po.VigenciaHasta ),0.0) as ReclamosPagados"
            sql &= ", isnull(( select sum(pa.ValorReserva) from Siniestros as si inner join SiniestrosReservas as pa on si.IdPoliza = pa.IdPoliza and si.IdProducto = pa.IdProducto and si.IdCertificado = pa.IdCertificado and si.IdSiniestro = pa.IdSiniestro where si.idpoliza = po.idpoliza and si.idproducto = po.idproducto and si.FechaOcurrido >= po.VigenciaDesde and si.FechaOcurrido < po.VigenciaHasta ),0.0) as ReclamosReserva"
            sql &= ", 0.0 as PorceSiniestralidad"
            sql &= " from Polizas as po "
            sql &= " inner join Productos as pr on pr.idproducto = po.idproducto"
            sql &= " inner join Aseguradoras as a on pr.idaseguradora = a.idaseguradora"
            sql &= " where po.idcliente = " & dbStr(IdCliente)
            sql &= " and po.MotivoCancelacion is null and po.FechaCancelacion is null"
            If VisibilidadUsuario() = "D" Then
                sql &= " and po.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            dtPolizas = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPolizas.TableName = "Polizas"

            'vamos a calcular el porcentaje de siniestralidad
            Dim Prima As Double = 0, Siniestros As Double = 0, Porce As Double = 0
            For NF As Integer = 0 To dtPolizas.Rows.Count - 1
                Prima = dtPolizas.Rows(NF).Item("PrimaDevengada")
                Siniestros = dtPolizas.Rows(NF).Item("ReclamosPagados") + dtPolizas.Rows(NF).Item("ReclamosReserva")
                If Prima = 0 Then
                    Porce = 1
                Else
                    Porce = Siniestros / Prima
                End If
                If Prima + Siniestros = 0 Then Porce = 0
                dtPolizas.Rows(NF).Item("PorceSiniestralidad") = Porce
            Next
            dtPolizas.AcceptChanges()


            sql = " select f.IdPoliza, f.IdProducto, f.FechaPago, f.NumeroFactura "
            sql &= ", isnull(( select sum(m.PrimaNeta) from FacturasMovimientos as m where f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo and m.tipomovimiento in ('EMISION','ANULACION') and f.FechaPago >= p.VigenciaDesde and f.FechaPago < p.VigenciaHasta),0.0) as PrimaNeta"
            sql &= " from Facturas as f "
            sql &= " inner join Polizas as p on p.idpoliza = f.idpoliza and p.idproducto = f.idproducto"
            sql &= " where p.idcliente = " & dbStr(IdCliente)
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFacturas.TableName = "Facturas"

            sql = " select s.IdPoliza, s.IdProducto, s.FechaOcurrido, s.IdSiniestro "
            sql &= ", isnull(( select sum(pa.ValorGasto) from SiniestrosPagos as pa where s.IdPoliza = pa.IdPoliza and s.IdProducto = pa.IdProducto and s.IdCertificado = pa.IdCertificado and s.IdSiniestro = pa.IdSiniestro and s.FechaOcurrido >= p.VigenciaDesde and s.FechaOcurrido < p.VigenciaHasta ),0.0) as Pagado"
            sql &= ", isnull(( select sum(pa.ValorReserva) from SiniestrosReservas as pa where s.IdPoliza = pa.IdPoliza and s.IdProducto = pa.IdProducto and s.IdCertificado = pa.IdCertificado and s.IdSiniestro = pa.IdSiniestro and s.FechaOcurrido >= p.VigenciaDesde and s.FechaOcurrido < p.VigenciaHasta ),0.0) as Reserva"
            sql &= " from Siniestros as s "
            sql &= " inner join Polizas as p on p.idpoliza = s.idpoliza and p.idproducto = s.idproducto"
            sql &= " where p.idcliente = " & dbStr(IdCliente)
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"




            Dim dsSini As New DataSet
            dsSini.Tables.Add(dtPolizas.Copy)
            dsSini.Tables.Add(dtFacturas.Copy)
            dsSini.Tables.Add(dtSiniestros.Copy)

            Dim ColPadre(1) As DataColumn
            ColPadre(0) = dsSini.Tables("Polizas").Columns("IdPoliza")
            ColPadre(1) = dsSini.Tables("Polizas").Columns("IdProducto")
            Dim ColHija(1) As DataColumn
            ColHija(0) = dsSini.Tables("Facturas").Columns("IdPoliza")
            ColHija(1) = dsSini.Tables("Facturas").Columns("IdProducto")

            Dim Relacion As DataRelation
            Relacion = New DataRelation("Polizas_Facturas", ColPadre, ColHija, False)
            dsSini.Relations.Add(Relacion)


            Dim ColHijaS(1) As DataColumn
            ColHijaS(0) = dsSini.Tables("Siniestros").Columns("IdPoliza")
            ColHijaS(1) = dsSini.Tables("Siniestros").Columns("IdProducto")

            Dim RelacionS As DataRelation
            RelacionS = New DataRelation("Polizas_Siniestros", ColPadre, ColHijaS, False)
            dsSini.Relations.Add(RelacionS)


            Me.GridSiniestralidad.DataSource = dsSini
            Me.GridSiniestralidad.DataMember = "Polizas"

            VistaSiniestralidad.OptionsDetail.ShowDetailTabs = True
            VistaSiniestralidad.OptionsDetail.AllowZoomDetail = True
            Me.GridSiniestralidad.Refresh()

            If dtPolizas.Rows.Count = 0 Then
                MsgBox("No se encontraron pólizas del cliente especificado.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaSiniestralidad_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles VistaSiniestralidad.CustomSummaryCalculate
        Try
            If e.IsTotalSummary = True Then
                Dim Prima As Double = dtPolizas.Compute("SUM(PrimaNeta)", "")
                Dim Siniestros As Double = dtPolizas.Compute("SUM(ReclamosPagados)", "")
                Dim Reserva As Double = dtPolizas.Compute("SUM(ReclamosReserva)", "")
                Dim Porce As Double = 0
                If Prima = 0 Then
                    Porce = 1
                Else
                    Porce = (Siniestros + Reserva) / Prima
                End If
                If Siniestros + Reserva + Prima = 0 Then Porce = 0
                e.TotalValue = Porce
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Siniestralidad " & Me.txtNombreCliente.Valor & " " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaSiniestralidad.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, Me.txtNombreCliente.Valor, "PRIMAS NETAS ANUALES VRS SINIESTROS PAGADOS", "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"), clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub
End Class
