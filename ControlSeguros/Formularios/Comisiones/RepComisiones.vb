Imports Utilerias.Genericas

Public Class RepComisiones

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'buscaremos las primas pendientes a la fecha de corte especificada
            Dim sql As String = ""

            sql = "  select f.NumeroFactura as NumeroFactura"
            sql &= " , p.Descripcion as Producto"
            sql &= " , r.NombreRamo as Ramo"
            sql &= " , p.TipoProducto as TipoSeguro"
            sql &= " , a.Nombre as Aseguradora"
            sql &= " , f.IdPoliza as Poliza"
            sql &= " , f.TipoFactura as TipoFactura"
            sql &= " , f.NombreCliente as NombreCliente"
            sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
            sql &= " , (select NombreMes from Meses where idmes = month(f.fechapago)) as Mes"
            sql &= " , (select sum(m.comision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.TipoMovimiento in ('EMISION','ANULACION')) as ComisionPotencial"
            sql &= " , (select sum(isnull(m.comision,0)) * -1 from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.TipoMovimiento in ('PAGO')) as ComisionCausada"
            sql &= " , (select sum(isnull(m.comision,0)) * -1 from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.TipoMovimiento in ('PAGO') and FechaCobroComision is not null) as ComisionPagada"
            sql &= " from facturas as f "
            sql &= " left join Productos as p on f.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " where "
            'que la fecha de pago sea menor a la fecha de corte
            sql &= " f.FechaPago between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            'que tengan saldo positivo
            ''sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(txtFecha.Valor) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
            PivotFacturas.DataSource = dsDatos.Tables(0)
            PivotFacturas.Refresh()

            If dsDatos.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron comisiones para las fechas especificadas.", MsgBoxStyle.Information, "AVISO..")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Comisiones " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotFacturas.ExportToXls(Archivo, Opciones)

            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub RepComisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaDesde.Valor = DateSerial(Date.Today.Year, 1, 1)
        txtFechaHasta.Valor = Date.Today
    End Sub

    Private Sub PivotFacturas_CustomFieldSort(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs) Handles PivotFacturas.CustomFieldSort
        Try
            If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
                Return
            End If
            e.Handled = True

            Dim s1 As Integer = 0, S2 As Integer = 0
            If e.Field.FieldName = "Mes" Then
                s1 = OrdenarMes(e.Value1.ToString())
                S2 = OrdenarMes(e.Value2.ToString())
            End If

            If s1 > S2 Then
                e.Result = 1
            Else
                If s1 = S2 Then
                    e.Result = Comparer(Of Int32).Default.Compare(s1, S2)
                Else
                    e.Result = -1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
