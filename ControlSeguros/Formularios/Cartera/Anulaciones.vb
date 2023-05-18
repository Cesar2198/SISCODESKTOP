Imports Utilerias.Genericas

Public Class Anulaciones

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'determinaremos las facturas que desean pagarse
        Try
            If txtCliente.Text = "" And Me.txtPoliza.Text = "" And Me.cboProducto.Text = "" And Me.txtDocumento.Text = "" And Me.txtFactura.Text = "" Then
                MsgBox("Debe definir al menos un parámetro de búsqueda.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String
            sql = "  select f.NumeroFactura as NumFactura, p.Descripcion as Producto, f.IdPoliza as Polizas, cast(0 as bit) as Anular, f.IdProducto, f.IdRamo"
            sql &= " , f.NombreCliente as Asegurado, f.FechaPago as FechaPago, cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumCuota"
            sql &= " , isnull((select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo  ),0) as Prima"
            sql &= " , isnull((select sum(m.GastosEmision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as GastosEmision"
            sql &= " , isnull((select sum(m.GastosFracciona) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as GastosFracciona"
            sql &= " , isnull((select sum(m.GastosBomberos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as GastosBomberos"
            sql &= " , isnull((select sum(m.Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Gastos"
            sql &= " , isnull((select sum(m.Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Iva"
            sql &= " , isnull((select sum(m.RetencionImpuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as RetencionImpuestos"
            sql &= " , isnull((select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Total"
            sql &= " , isnull((select sum(m.Comision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Comision"
            sql &= " from facturas as f"
            sql &= " left join Clientes as c on c.IdCliente = f.IdCliente"
            sql &= " left join Productos as p on p.IdProducto = f.IdProducto"
            sql &= " where f.NumeroFactura is not null "
            sql &= "  and (select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ) > 0 "
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If txtCliente.Text.Trim <> "" Then
                Dim numNombres As Integer = CuentaCar(txtCliente.Text.Trim, " "), Nombre As String = ""
                For NM As Integer = 0 To numNombres
                    Nombre = stiSplit(txtCliente.Text.Trim, "G" & NM & " 1").Trim
                    If Nombre <> "" Then
                        sql &= " and f.NombreCliente like " & dbStr("%" & Nombre & "%")
                    End If
                Next
            End If
            If txtPoliza.Text.Trim <> "" Then
                sql &= " and f.idpoliza like " & dbStr("%" & txtPoliza.Text.Trim & "%")
            End If
            If cboProducto.Text <> "" Then
                sql &= " and f.idproducto = " & dbStr(cboProducto.Valor)
            End If
            If txtDocumento.Text.Trim <> "" Then
                sql &= " and (c.Nit = " & dbStr(txtDocumento.Text.Trim) & " or c.Dui = " & dbStr(txtDocumento.Text.Trim) & " or c.RegistroFiscal = " & dbStr(txtDocumento.Text.Trim) & ")"
            End If
            If Me.txtFactura.Text <> "" Then
                sql &= " and f.NumeroFactura = " & dbInt(txtFactura.Valor)
            End If

            Dim Facturas As DataSet = StiGlobalConn.ObtenerDataset(sql)
            Me.GridFacturas.DataSource = Facturas.Tables(0)
            Me.GridFacturas.Refresh()
            If Facturas.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron facturas pendientes para anular con las condiciones dadas.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub PagosAnula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString()
        Me.cboProducto.Llenar_Combo()
        Me.txtFechaAnula.Valor = Date.Today
        Me.txtFactura.Valor = ""
        Call ProcesarPermisosComision()
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                FACol13.Visible = False
                FACol13.OptionsColumn.AllowShowHide = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ActualizarTotales()
        Try
            Dim Prima As Double = 0, Gastos As Double = 0, Iva As Double = 0, Total As Double = 0
            For I As Integer = 0 To VistaFacturas.DataRowCount - 1
                If Me.VistaFacturas.GetRowCellValue(I, "Anular") = True Then
                    Prima += Val(VistaFacturas.GetRowCellValue(I, "Prima"))
                    Gastos += (Val(VistaFacturas.GetRowCellValue(I, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(I, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(I, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(I, "Gastos")))
                    Iva += Val(VistaFacturas.GetRowCellValue(I, "Iva"))
                    Total += Val(VistaFacturas.GetRowCellValue(I, "Total"))
                End If
            Next
            Me.txtTotalPrimaNeta.Valor = Prima
            Me.txtTotalGastos.Valor = Gastos
            Me.txtTotalImpuestos.Valor = Iva
            Me.txtTotal.Valor = Total

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Me.VistaFacturas.PostEditor()
        Call ActualizarTotales()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'vamos a recorrer el los pagos marcados y a ingresar el pago.
        If Me.txtFechaAnula.Text = "" Then
            MsgBox("Debe especificar la fecha efectiva de Anulación.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        If Me.txtMotivo.Text = "" Then
            MsgBox("Debe especificar el motivo de la anulación.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim Res As String = ""
            For I As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                If VistaFacturas.GetRowCellValue(I, "Anular") = True Then
                    Res = Cartera_AnularFactura(VistaFacturas.GetRowCellValue(I, "NumFactura"), VistaFacturas.GetRowCellValue(I, "Polizas"), VistaFacturas.GetRowCellValue(I, "IdProducto"), txtFechaAnula.Valor, VistaFacturas.GetRowCellValue(I, "Prima"), VistaFacturas.GetRowCellValue(I, "GastosEmision"), VistaFacturas.GetRowCellValue(I, "GastosFracciona"), VistaFacturas.GetRowCellValue(I, "GastosBomberos"), VistaFacturas.GetRowCellValue(I, "Gastos"), VistaFacturas.GetRowCellValue(I, "Iva"), VistaFacturas.GetRowCellValue(I, "Total"), VistaFacturas.GetRowCellValue(I, "Comision"), VistaFacturas.GetRowCellValue(I, "IdRamo"), txtMotivo.Valor, VistaFacturas.GetRowCellValue(I, "RetencionImpuestos"))
                    If Res <> "" Then
                        MsgBox("No es posible realizar la anulación de la factura: " & VistaFacturas.GetRowCellValue(I, "NumFactura") & vbCrLf & Res, MsgBoxStyle.Exclamation, "AVISO...")
                    End If
                End If
            Next
            Call LimpiarEntradas()
            MsgBox("La operación ha finalizado.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LimpiarEntradas()
        Me.txtCliente.Valor = ""
        Me.txtDocumento.Valor = ""
        Me.txtPoliza.Valor = ""
        Me.cboProducto.Valor = ""
        Me.txtTotal.Valor = 0
        Me.txtTotalGastos.Valor = 0
        Me.txtTotalImpuestos.Valor = 0
        Me.txtTotalPrimaNeta.Valor = 0
        Me.GridFacturas.DataSource = Nothing
        Me.GridFacturas.Refresh()
    End Sub

End Class
