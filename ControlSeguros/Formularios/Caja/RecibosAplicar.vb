Imports Utilerias.Genericas

Public Class RecibosAplicar

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.LimpiarCampos(Me)
        Me.chkRecCambio.Checked = False
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim fbus As New BusquedaRecibos
        fbus.dbFiltro = " and r.EstadoRecibo = 'P' "
        busCodigo = ""
        fbus.ShowDialog()

        If busCodigo <> "" Then
            Dim Fila As DataRow = StiGlobalConn.ObtenerDataset("select * from Recibos where idrecibo = " & dbStr(busCodigo)).Tables(0).Rows(0)
            Me.txtFechaRecibo.Valor = dbData(Fila, "FechaRecibo")
            Me.txtIdCliente.Valor = dbData(Fila, "IdCliente")
            Me.txtNombreCliente.Valor = dbData(Fila, "NombreCliente")
            Me.txtNumRecibo.Valor = dbData(Fila, "IdRecibo")
            Me.txtTotalRecibo.Valor = dbData(Fila, "TotalRecibo")

            Dim FilE As DataRow = StiGlobalConn.ObtenerDataset("select isnull(sum(Total),0) as Efectivo, isnull(sum(Cambio),0) as Cambio from RecibosPagos where idrecibo = " & dbStr(busCodigo) & " and IdTipoIngreso = 'E' ").Tables(0).Rows(0)
            txtTotalEfectivo.Valor = dbData(FilE, "Efectivo")
            txtTotalCambio.Valor = dbData(FilE, "Cambio")

            'ahora las facturas
            Dim dtFact As DataTable = StiGlobalConn.ObtenerDataset("select NumeroFactura, IdProducto, IdPoliza, IdRamo, NombreCliente, Total, IdRecibo, cast(0 as bit) as Deposito, '' as DocFiscal from RecibosFacturas where IdRecibo = " & dbStr(busCodigo)).Tables(0)
            Me.GridFacturas.DataSource = dtFact
            Me.GridFacturas.Refresh()

            'ahora los otros ingresos
            Dim dtOT As DataTable = StiGlobalConn.ObtenerDataset("select IdAseguradora, Descripcion, Total, IdRecibo, IdOtroIngreso from RecibosOtrosIngresos where  IdRecibo = " & dbStr(busCodigo)).Tables(0)
            Me.gridOtros.DataSource = dtOT
            Me.gridOtros.Refresh()

            'ahora los pagos
            Dim dtPago As DataTable = StiGlobalConn.ObtenerDataset("select IdTipoIngreso,IdBanco, Documento, NumConfirmacion, Total, IdRecibo, IdAseguradora, IdPago, Cambio from RecibosPagos where idrecibo = " & dbStr(busCodigo) & " order by IdPago").Tables(0)
            Me.GridPago.DataSource = dtPago
            Me.GridPago.Refresh()

        End If
    End Sub

    Private Sub RecibosAplicar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TP As DataTable
        TP = StiGlobalConn.ObtenerDataset("select IdProducto as Id, Descripcion as [Descripción] from Productos").Tables(0)
        RepositoryItemLookUpEdit3.ValueMember = "Id"
        RepositoryItemLookUpEdit3.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit3.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit3.DataSource = TP
        RepositoryItemLookUpEdit3.PopulateColumns()

        Dim TR As DataTable
        TR = StiGlobalConn.ObtenerDataset("select IdRamo as Id, NombreRamo as [Descripción] from RamoSeguros").Tables(0)
        RepositoryItemLookUpEdit4.ValueMember = "Id"
        RepositoryItemLookUpEdit4.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit4.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit4.DataSource = TR
        RepositoryItemLookUpEdit4.PopulateColumns()

        Dim TA As DataTable
        TA = StiGlobalConn.ObtenerDataset("select IdAseguradora as Id, Nombre as [Descripción] from Aseguradoras").Tables(0)
        RepositoryItemLookUpEdit5.ValueMember = "Id"
        RepositoryItemLookUpEdit5.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit5.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit5.DataSource = TA
        RepositoryItemLookUpEdit5.PopulateColumns()

        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "E" : Fila("Descripcion") = "Efectivo" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "C" : Fila("Descripcion") = "Cheque" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "D" : Fila("Descripcion") = "Depósito Bancario" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "T" : Fila("Descripcion") = "Tarjeta" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "N" : Fila("Descripcion") = "Nota Crédito" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "A" : Fila("Descripcion") = "Depósito en Aseguradora" : FP.Rows.Add(Fila)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = FP
        RepositoryItemLookUpEdit1.PopulateColumns()

        Dim TB As DataTable
        TB = StiGlobalConn.ObtenerDataset("select IdBanco as Id, NombreBanco as [Descripción] from Bancos").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = TB
        RepositoryItemLookUpEdit2.PopulateColumns()

        RepositoryItemLookUpEdit6.ValueMember = "Id"
        RepositoryItemLookUpEdit6.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit6.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit6.DataSource = TA
        RepositoryItemLookUpEdit6.PopulateColumns()

        Me.LimpiarCampos(Me)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtNumRecibo.Text = "" Then
            MsgBox("Debe especificar el recibo que se aplicará a Facturas y Depósitos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Val(txtTotalCambio.Valor) > 0 And Me.chkRecCambio.Checked = False Then
            MsgBox("El recibo presenta cambio en efectivo, debe marcar de haber recibido el cambio, de lo contrario no se aplicará el recibo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim Res As String = "", sql As String = ""

        'aplicaremos las facturas
        Dim Factura As Integer = 0, Producto As String = "", Poliza As String = "", Ramo As String = "", IdAseguradora As String = ""
        Dim FechaPago As DateTime = Me.txtFechaRecibo.Valor
        Dim Prima As Double = 0, GastosE As Double = 0, GastosF As Double = 0, GastosB As Double = 0, GastosO As Double = 0, Iva As Double = 0, RetIva As Double = 0, Total As Double = 0, Comision As Double = 0
        Dim TotalEnRecibo As Double = 0

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            For NF As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                'Lo que haremos es dar por pagada la factura que se indicó en el recibo con la fecha del recibo.
                Factura = Me.VistaFacturas.GetRowCellValue(NF, "NumeroFactura")
                Producto = Me.VistaFacturas.GetRowCellValue(NF, "IdProducto")
                Poliza = Me.VistaFacturas.GetRowCellValue(NF, "IdPoliza")
                Ramo = Me.VistaFacturas.GetRowCellValue(NF, "IdRamo")
                TotalEnRecibo = Val(Me.VistaFacturas.GetRowCellValue(NF, "Total"))
                Try
                    IdAseguradora = StiGlobalConn.ObtenerDataset("select idaseguradora from productos where idproducto = " & dbStr(Producto)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdAseguradora = ""
                End Try

                'actualizamos el documento fiscal de la factura.
                sql = " update facturas set DocumentoFiscal = " & dbStr(VistaFacturas.GetRowCellValue(NF, "DocFiscal"), 25)
                sql &= " where NumeroFactura = " & dbInt(Factura) & " and IdProducto = " & dbStr(Producto) & " and IdPoliza = " & dbStr(Poliza) & " and idramo = " & dbStr(Ramo)
                StiGlobalConn.SQLExecute(sql)

                'obtendremos el saldo de la factura

                sql = "  select "
                sql &= " isnull(sum(m.PrimaNeta),0) as PrimaNeta"
                sql &= ",isnull(sum(m.GastosEmision),0) as GastosEmision"
                sql &= ",isnull(sum(m.GastosFracciona),0) as GastosFracciona"
                sql &= ",isnull(sum(m.GastosBomberos),0) GastosBomberos"
                sql &= ",isnull(sum(m.Gastos),0) as Gastos"
                sql &= ",isnull(sum(m.Impuestos),0) as Impuestos"
                sql &= ",isnull(sum(m.RetencionImpuestos),0) as RetencionImpuestos"
                sql &= ",isnull(sum(m.Total),0) as Total"
                sql &= ",isnull(sum(m.Comision),0) as Comision"
                sql &= " from facturas as f "
                sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo"
                sql &= " where f.NumeroFactura = " & dbInt(Factura) & " and f.IdProducto = " & dbStr(Producto) & " and f.IdPoliza = " & dbStr(Poliza) & " and f.idramo = " & dbStr(Ramo)
                Dim FilaFact As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                Prima = Val(dbData(FilaFact, "PrimaNeta"))
                GastosE = Val(dbData(FilaFact, "GastosEmision"))
                GastosF = Val(dbData(FilaFact, "GastosFracciona"))
                GastosB = Val(dbData(FilaFact, "GastosBomberos"))
                GastosO = Val(dbData(FilaFact, "Gastos"))
                Iva = Val(dbData(FilaFact, "Impuestos"))
                RetIva = Val(dbData(FilaFact, "RetencionImpuestos"))
                Total = Val(dbData(FilaFact, "Total"))
                Comision = Val(dbData(FilaFact, "Comision"))

                If Me.VistaFacturas.GetRowCellValue(NF, "Deposito") = True Then
                    Res = Cartera_AgregarDeposito(txtIdCliente.Valor, txtNombreCliente.Valor, "", txtFechaRecibo.Valor, TotalEnRecibo, "Aplicación depósito por factura: " & Factura & ", Producto:" & Producto & ", Póliza:" & Poliza, IdAseguradora)
                    If Res <> "" Then
                        MsgBox("Error al aplicar el depósito de la factura:" & Factura & vbCrLf & Res, MsgBoxStyle.Exclamation, "AVISO...")
                    End If

                    StiGlobalConn.SQLExecute("update RecibosFacturas set EnDeposito = 'S' where IdRecibo = " & dbStr(txtNumRecibo.Text) & " and NumeroFactura = " & dbInt(Factura) & " and IdProducto = " & dbStr(Producto) & " and IdPoliza = " & dbStr(Poliza) & " and IdRamo = " & dbStr(Ramo))

                Else
                    'verificaremos que el monto del recibo sea el mismo que el de la factura
                    If (Prima + GastosE + GastosF + GastosB + GastosO + Iva + Total) > 0 Then
                        If Math.Round(Total) <> Math.Round(TotalEnRecibo) Then
                            MsgBox("El Valor de la factura:" & Total & " difiere del valor en el recibo:" & TotalEnRecibo & ". Se aplicará el pago por el valor de la factura.")
                        End If
                        Dim IdFormaPago As String = ""
                        Try
                            IdFormaPago = StiGlobalConn.ObtenerDataset("select top 1 IdTipoIngreso from RecibosPagos where IdRecibo = " & dbStr(txtNumRecibo.Valor) & " order by IdPago asc").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            IdFormaPago = ""
                        End Try

                        Res = Cartera_AgregarPago(Factura, Poliza, Producto, FechaPago, Prima, GastosE, GastosF, GastosB, GastosO, Iva, Total, Comision, Ramo, RetIva, IdFormaPago)
                        If Res <> "" Then
                            MsgBox("Error al pagar la factura: " & Factura & ":" & vbCrLf & Res, MsgBoxStyle.Critical, "AVISO...")
                        End If
                    End If
                End If
            Next

            'ahora procesaremos los depositos confirmados
            Dim ResDep As String = ""
            For ND As Integer = 0 To Me.VistaOtros.DataRowCount - 1
                'agregaremos a deposito
                ResDep = Cartera_AgregarDeposito(txtIdCliente.Valor, txtNombreCliente.Valor, "", txtFechaRecibo.Valor, Val(Me.VistaOtros.GetRowCellValue(ND, "Total")), Me.VistaOtros.GetRowCellValue(ND, "Descripcion"), Me.VistaOtros.GetRowCellValue(ND, "IdAseguradora"))
                If ResDep <> "" Then
                    MsgBox("Error al aplicar el depósito: " & Me.VistaOtros.GetRowCellValue(ND, "Descripcion") & vbCrLf & ResDep, MsgBoxStyle.Exclamation, "AVISO...")
                End If
            Next

            'ahora si hay pagos con deposito de aseguradora, los aplicamos.
            For NP As Integer = 0 To Me.VistaPago.DataRowCount - 1
                If Me.VistaPago.GetRowCellValue(NP, "IdTipoIngreso") = "A" Then
                    ResDep = Cartera_DescontarDeposito(Me.txtIdCliente.Valor, Me.txtFechaRecibo.Valor, Me.VistaPago.GetRowCellValue(NP, "Total"), "Descuento dépósito por Recibo No." & txtNumRecibo.Valor, Me.VistaPago.GetRowCellValue(NP, "IdAseguradora"))
                End If
            Next
            'como paso final actualizamos el recibo
            Dim EstadoCambio As String = ""
            If Val(txtTotalCambio.Valor) > 0 And Me.chkRecCambio.Checked = True Then
                EstadoCambio = ", CambioRecibio = 'S' "
            End If


            StiGlobalConn.SQLExecute("update Recibos set EstadoRecibo = 'A' " & EstadoCambio & " where IdRecibo = " & dbStr(txtNumRecibo.Valor))
            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            Me.LimpiarCampos(Me)
            MsgBox("El recibo ha sido aplicado.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Ocurrio un error al aplicar el recibo, la operación se canceló." & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Try
            'Me.VistaFacturas.RefreshRow(Me.VistaFacturas.FocusedRowHandle)
            Me.VistaFacturas.PostEditor()
        Catch ex As Exception

        End Try
    End Sub

  
End Class
