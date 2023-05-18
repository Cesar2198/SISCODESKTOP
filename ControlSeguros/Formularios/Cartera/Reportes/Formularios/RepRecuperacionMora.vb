Imports Utilerias.Genericas

Public Class RepRecuperacionMora

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaIngresos.Click
        Try
            'buscaremos las primas pendientes a la fecha de corte especificada
            Dim sql As String = ""

            sql = "  select "
            sql &= " a.Nombre as Aseguradora"
            sql &= " , r.NombreRamo as Ramo"
            sql &= " , p.Descripcion as Producto"
            sql &= " , f.NumeroFactura as Factura"
            sql &= " , f.IdPoliza as Poliza"
            sql &= " , f.NombreCliente as Cliente"
            sql &= " , case "
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") > 150 then '6) Más de 150'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") <= 30 then '1) de 0 - 30 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") > 30 and DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") <= 60 then '2) de 30 - 60 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") > 60 and DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") <= 90 then '3) de 60 - 90 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") > 90 and DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") <= 120 then '4) de 90 - 120 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") > 120 and DateDiff(d,f.FechaPago," & dbFec(txtFechaPrima.Valor) & ") <= 150 then '5) de 120 - 150 días'"
            sql &= " end as RangoMora "
            sql &= " , isnull((select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFechaPrima.Valor) & "),0) as PrimaNeta"
            sql &= " , (select sum(isnull(GastosEmision,0) + isnull(GastosFracciona,0) + isnull(GastosBomberos,0) + isnull(Gastos,0)) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFechaPrima.Valor) & ") as Gastos"
            sql &= " , isnull((select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFechaPrima.Valor) & "),0) as IVA"
            sql &= " , isnull((select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFechaPrima.Valor) & "),0) as Total"
            sql &= " , case "
            sql &= "  when (select count(*) from Gestiones as g where g.TipoGestion = 'C' and g.NumeroFactura = f.NumeroFactura and g.IdProducto = f.IdProducto and g.IdPoliza = f.idpoliza) > 0 then 'SI' "
            sql &= " else 'NO' "
            sql &= " end as TieneGestion"
            sql &= " from facturas as f "
            sql &= " left join Productos as p on f.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " left join Clientes as c on c.idcliente = f.idcliente"
            sql &= " where "
            'que la fecha de pago sea menor a la fecha de corte
            sql &= " f.FechaPago <= " & dbFec(txtFechaPrima.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            'que tengan saldo positivo a la fecha de corte
            sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(txtFechaPrima.Valor) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
            'que ya estén pagadas a la fecha de corte de pagos
            sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(txtFechaPago.Valor) & ") = 0 "

            If chkGestiones.Checked = True Then
                sql &= " and (select count(*) from Gestiones as g where g.TipoGestion = 'C' and g.NumeroFactura = f.NumeroFactura and g.IdProducto = f.IdProducto and g.IdPoliza = f.idpoliza) > 0 "
            End If


            Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
            GridMora.DataSource = dsDatos.Tables(0)
            GridMora.Refresh()

            If dsDatos.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron primas pendientes para la fecha de corte especificada.", MsgBoxStyle.Information, "AVISO..")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Mora " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridMora.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Recuperación de Mora", "Reporte de Mora al " & Me.txtFechaPrima.Text & " y corte de Pagos al " & Me.txtFechaPago.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

End Class
