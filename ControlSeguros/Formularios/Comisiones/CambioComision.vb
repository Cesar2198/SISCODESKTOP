
Imports Utilerias.Genericas

Public Class CambioComision

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If cboProducto.Text = "" Then
                MsgBox("Debe especificar el producto de seguros.", MsgBoxStyle.Exclamation, "AVISO...")
                Exit Sub
            End If

            Dim sql As String
            sql = "  select f.NumeroFactura as NumFactura, p.Descripcion as Producto, f.IdPoliza as Polizas, cast(1 as bit) as Incluir, f.IdProducto, f.IdRamo"
            sql &= " , f.NombreCliente as Asegurado, f.FechaPago as FechaPago, cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumCuota"
            sql &= " , isnull((select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.TipoMovimiento = 'EMISION' ),0) as Prima"
            sql &= " , f.PorceComision as Comision"
            sql &= " from facturas as f"
            sql &= " left join Clientes as c on c.IdCliente = f.IdCliente"
            sql &= " left join Productos as p on p.IdProducto = f.IdProducto"
            sql &= " where NumeroFactura is not null "
            'listaremos las facturas que estén pendientes y las que estén pendientes de cobrar comision
            sql &= " and ( (select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ) > 0 "
            sql &= "  or (select count(*) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.TipoMovimiento = 'PAGO' and m.FechaCobroComision is null ) > 0 )"

            If cboProducto.Text <> "" Then
                sql &= " and f.idproducto = " & dbStr(cboProducto.Valor)
            End If
            If txtPoliza.Text.Trim <> "" Then
                sql &= " and f.idpoliza like " & dbStr("%" & txtPoliza.Text.Trim & "%")
            End If
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If


            Dim Facturas As DataSet = StiGlobalConn.ObtenerDataset(sql)
            Me.GridFacturas.DataSource = Facturas.Tables(0)
            Me.GridFacturas.Refresh()
            If Facturas.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron facturas.", MsgBoxStyle.Information, "AVISO...")
                Me.lblLog.Text = ""
            Else
                Me.lblLog.Text = "No.Facturas: " & Facturas.Tables(0).Rows.Count
            End If
        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub CambioComision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtNuevaComi.Text = "" Then
            MsgBox("Debe especificar la nueva comisión.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If
        If Val(Me.txtNuevaComi.Valor) < 0 Then
            MsgBox("Valor equivocado de comisión.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If
        If Val(Me.txtNuevaComi.Valor) = 0 Then
            If MsgBox("¿Está seguro de dejar a cero la comisión de las facturas?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        btnGuardar.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Try
            'recorremos las comisiones marcadas y cambiamos los valores de comisiones
            'ojo dejamos un log del cambio
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
            For I As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                If Me.VistaFacturas.GetRowCellValue(I, "Incluir") = True Then
                    'primero cambiamos el valor de la comision almacenada
                    StiGlobalConn.SQLExecute("update Facturas set PorceComision = " & dbNum(txtNuevaComi.Valor) & " where NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and IdRamo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")))
                    'cambiamos todos los movimientos de comision 
                    StiGlobalConn.SQLExecute("update FacturasMovimientos set Comision = Round((PrimaNeta * " & dbNum(txtNuevaComi.Valor) & ") / 100,2) where NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and IdRamo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")))

                    'actualizamos el % de comision del AC desde donde se genero la factura
                    StiGlobalConn.SQLExecute("update AvisosCobro set PorceComision = " & dbNum(txtNuevaComi.Valor) & " where IdAvisoCobro = (select top 1 IdAvisoCobro from AvisosCobroFacturas where IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and IdRamo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")) & ")")

                    'registramos el cambio en el log
                    RegistrarLog("M", "Facturas", "PorceComision = " & dbNum(txtNuevaComi.Valor) & " and NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and IdRamo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")))
                End If
            Next

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            Me.LimpiarCampos(Me)
            Me.GridFacturas.DataSource = Nothing
            Me.GridFacturas.Refresh()

            MsgBox("Las comisiones de las facturas marcadas han sido cambiadas con éxito.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try

        btnGuardar.Enabled = True
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = ""
        Try
            'ojo dejamos un log del cambio
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'Obtenermos los movimientos de Comisión que no están procesados y actualizamos su comisión
            Dim DtComi As DataTable, FilComi As DataRow
            DtComi = StiGlobalConn.ObtenerDataset("select NumeroFactura, IdProducto, IdPoliza, IdRamo from FacturasMovimientos where tipomovimiento = 'PAGO' and fechacobrocomision is null").Tables(0)
            For Each FilComi In DtComi.Rows
                'cambiamos todos los movimientos de comision 
                sql = "  update FacturasMovimientos set Comision = Round((PrimaNeta * Facturas.PorceComision) / 100,2)"
                sql &= " from Facturas inner join FacturasMovimientos on Facturas.NumeroFactura = FacturasMovimientos.NumeroFactura and Facturas.IdProducto = FacturasMovimientos.IdProducto and Facturas.IdPoliza = FacturasMovimientos.IdPoliza and Facturas.IdRamo = FacturasMovimientos.IdRamo"
                sql &= " where Facturas.NumeroFactura = " & dbInt(dbData(FilComi, "NumeroFactura"))
                sql &= " and Facturas.IdProducto = " & dbStr(dbData(FilComi, "IdProducto"))
                sql &= " and Facturas.IdPoliza = " & dbStr(dbData(FilComi, "IdPoliza"))
                sql &= " and Facturas.IdRamo = " & dbStr(dbData(FilComi, "IdRamo"))
                StiGlobalConn.SQLExecute(sql)
                'registramos el cambio en el log
                RegistrarLog("M", "Facturas", "ACT_COMI: NumeroFactura = " & dbInt(dbData(FilComi, "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(FilComi, "IdProducto")) & " and IdPoliza = " & dbStr(dbData(FilComi, "IdPoliza")) & " and IdRamo = " & dbStr(dbData(FilComi, "IdRamo")))
            Next
            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            Me.LimpiarCampos(Me)
            Me.GridFacturas.DataSource = Nothing
            Me.GridFacturas.Refresh()

            MsgBox("Las comisiones de las facturas pendientes han sido actualizadas con éxito.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try

        btnNuevo.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

End Class
