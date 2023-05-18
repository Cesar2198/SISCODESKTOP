
Imports Utilerias.Genericas

Public Class CambioFactura

    Private Sub btnBuscarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim fbus As New BusquedaFacturas
        busCodigo = ""
        fbus.dbFiltro = ""
        fbus.ShowDialog()
        If busCodigo <> "" Then
            txtNumeroFactura.Valor = stiSplit(busCodigo, "G0|1")
            cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            txtIdPoliza.Valor = stiSplit(busCodigo, "G2|1")
            cboIdRamo.Valor = stiSplit(busCodigo, "G3|1")

            Try
                Dim filCliente As DataRow = StiGlobalConn.ObtenerDataset("select IdCliente, NombreCliente from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0)
                Me.txtIdCliente.Valor = dbData(filCliente, "IdCliente")
                Me.txtNombreCliente.Valor = dbData(filCliente, "NombreCliente")
            Catch ex As Exception

            End Try
            Me.txtNuevaFactura.Focus()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CambioFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdRamo.Llenar_Combo()

        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()

        Me.txtNumeroFactura.SoloLectura = True
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdPoliza.SoloLectura = True
        Me.txtNombreCliente.SoloLectura = True
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdRamo.SoloLectura = True
        Me.txtNumeroFactura.Valor = ""
        Me.txtNuevaFactura.Valor = ""


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'validamos que esté cargada una factura
        If Me.txtNumeroFactura.Text = "" Then
            MsgBox("Debe especificar la factura que desea cambiar.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If
        If txtNuevaFactura.Text = "" Then
            MsgBox("Debe especificar el nuevo número de factura.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        'si la nueva factura existe avisamos, pues sino duplicaría la factura
        Dim Existe As Integer = 0
        Dim sql As String = ""

        sql = "  select count(*) "
        sql &= " from Facturas"
        sql &= " where NumeroFactura = " & dbInt(txtNuevaFactura.Valor)
        sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
        sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
        sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
        Existe = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        If Existe > 0 Then
            MsgBox("El nuevo número de factura especificado ya existe para la póliza. El cambio no puede ser realizado.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        Try
            'como el id de la factura es una llave no podemos cambiarla, has que hacer una copia y luego cambiarla
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            '1) creamos una copia de la factura y sus movimientos
            sql = "  insert into Facturas"
            sql &= " (NumeroFactura, IdProducto, IdPoliza, IdRamo, TipoFactura "
            sql &= " ,IdAnexo, IdCliente, NombreCliente, FechaEmision, FechaPago, VigenciaDesde, VigenciaHasta, NumCuota "
            sql &= " ,TotalCuotas, Referencia, Observaciones, PorceComision, DocumentoFiscal, AplicarRetencionIva, GestionEspecial, VencimientoTardio) "

            sql &= " select " & dbInt(Me.txtNuevaFactura.Valor) & ", IdProducto, IdPoliza, IdRamo, TipoFactura "
            sql &= " ,IdAnexo, IdCliente, NombreCliente, FechaEmision, FechaPago, VigenciaDesde, VigenciaHasta, NumCuota "
            sql &= " ,TotalCuotas, Referencia, Observaciones, PorceComision, DocumentoFiscal, AplicarRetencionIva, GestionEspecial, VencimientoTardio"
            sql &= " from Facturas"
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into FacturasMovimientos"
            sql &= " (NumeroFactura, IdProducto, IdPoliza, IdRamo, IdMovimiento, FechaMovimiento "
            sql &= " ,TipoMovimiento, PrimaNeta, GastosEmision, GastosFracciona, GastosBomberos"
            sql &= " ,Gastos, Impuestos, Total, Comision, FechaCobroComision, FechaPagoComision, MotivoAnulacion, RetencionImpuestos, UsuarioGrabacion)"

            sql &= " select " & dbInt(Me.txtNuevaFactura.Valor) & ", IdProducto, IdPoliza, IdRamo, IdMovimiento, FechaMovimiento "
            sql &= " ,TipoMovimiento, PrimaNeta, GastosEmision, GastosFracciona, GastosBomberos"
            sql &= " ,Gastos, Impuestos, Total, Comision, FechaCobroComision, FechaPagoComision, MotivoAnulacion, RetencionImpuestos, UsuarioGrabacion"
            sql &= " from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            '2) actualizamos las tablas que tengan almacenadas la factura anterior

            sql = " update AvisosCobroFacturas set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update RecibosFacturas set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update EstadosCuentaComisionesFacturas set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update EstadosCuentaVendedoresFacturas set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update Gestiones set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            ''sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update NotasAbono set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update NotasCredito set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = " update FlujosDocumentos set NumeroFactura = " & dbInt(Me.txtNuevaFactura.Valor)
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)


            '3) Borramos la factura anterior
            sql = "  delete from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            sql = "  delete from Facturas"
            sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            Me.LimpiarCampos(Me)

            MsgBox("La operación ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")

            btnBuscarFactura.Focus()

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try

    End Sub

End Class
