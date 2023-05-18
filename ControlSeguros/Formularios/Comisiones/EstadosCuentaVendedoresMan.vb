
Imports Utilerias.Genericas

Public Class EstadosCuentaVendedoresMan

    Private Sub EstadosCuentaVendedoresMan_AntesDeEliminar(ByRef Cancel As Boolean) Handles Me.AntesDeEliminar
        'eliminaremos la tabla relacionada no conectada
        StiGlobalConn.SQLExecute("delete from EstadosCuentaVendedoresFacturas where IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor))
    End Sub

    Private Sub EstadosCuentaVendedoresMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If Me.txtMotivoDescuento.Text <> "" And Val(txtValorDescuento.Valor) <= 0 Then
            MsgBox("Si especifica motivo de descuento debe especificar el monto.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True : Exit Sub
        End If
        If Me.txtMotivoDescuento.Text.Trim = "" And Val(txtValorDescuento.Valor) > 0 Then
            MsgBox("Si especifica monto de descuento debe especificar el motivo.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True : Exit Sub
        End If

        'especificamos el número del estado de cuenta
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And txtIdEstadoCuenta.Text = "" Then
            Dim IdEstadoCuenta As Integer = clSeguros.ObtenerID("Num.Estado.Cuenta.Vend")
            txtIdEstadoCuenta.Valor = IdEstadoCuenta
        End If
    End Sub

    Private Sub EstadosCuentaVendedoresMan_DespuesDeCargarRegistro() Handles Me.DespuesDeCargarRegistro
        Try
            'cargaremos informacion del grid
            Dim sql As String = ""
            sql = "  select f.NumeroFactura, f.IdProducto, f.IdPoliza, f.IdMovimiento, fa.NombreCliente, f.IdRamo "
            sql &= " ,m.FechaMovimiento as FechaPago, m.Comision * -1 as Comision, cast(1 as bit) as Incluir"
            sql &= " ,fa.fechapago as FechaVence, m.PrimaNeta * -1 as PrimaNeta, fa.PorceComision as PorceComi"
            sql &= ", f.PorceVendedor, f.ComiVendedor, fa.NumCuota, fa.TotalCuotas, a.Nombre as Aseguradora"
            sql &= " from EstadosCuentaVendedoresFacturas as f"
            sql &= " inner join Facturas as fa on fa.NumeroFactura = f.NumeroFactura and fa.IdProducto = f.IdProducto and fa.IdPoliza = f.IdPoliza and fa.idramo = f.idramo"
            sql &= " inner join FacturasMovimientos as m on m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.IdMovimiento = f.IdMovimiento"
            sql &= " inner join Productos as p on p.IdProducto = fa.IdProducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora
            sql &= " where f.IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor)

            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridComisiones.DataSource = dtDatos
            GridComisiones.Refresh()

            Call ActualizarTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EstadosCuentaVendedoresMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Try
            'ahora las facturas
            Dim sql As String = ""
            StiGlobalConn.SQLExecute("delete from EstadosCuentaVendedoresFacturas where IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor))
            For NF As Integer = 0 To VistaComisiones.DataRowCount - 1
                If VistaComisiones.GetRowCellValue(NF, "Incluir") = True Then
                    sql = "  insert into EstadosCuentaVendedoresFacturas "
                    sql &= " (IdEstadoCuenta, NumeroFactura, IdProducto, IdPoliza, IdRamo"
                    sql &= " ,IdMovimiento, FechaPago, PorceComision, Comision, PorceVendedor, ComiVendedor) values("
                    sql &= dbInt(txtIdEstadoCuenta.Valor) & C & dbInt(VistaComisiones.GetRowCellValue(NF, "NumeroFactura")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "IdProducto")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "IdPoliza")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "IdRamo")) & C
                    sql &= dbInt(VistaComisiones.GetRowCellValue(NF, "IdMovimiento")) & C & dbFec(VistaComisiones.GetRowCellValue(NF, "FechaPago")) & C & dbNum(VistaComisiones.GetRowCellValue(NF, "PorceComi")) & C & dbNum(VistaComisiones.GetRowCellValue(NF, "Comision")) & C & dbNum(VistaComisiones.GetRowCellValue(NF, "PorceVendedor")) & C & dbNum(VistaComisiones.GetRowCellValue(NF, "ComiVendedor")) & ")"
                    StiGlobalConn.SQLExecute(sql)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EstadosCuentaVendedoresMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtIdEstadoCuenta.SoloLectura = True
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFechaCorte.Valor = Date.Today
            Me.cboEstatus.Valor = "P"
        End If

        If cboEstatus.Valor = "A" Then
            btnAplicarEstadoCuenta.Enabled = False
            btnBuscarComi.Enabled = False
            btnEliminar.Enabled = False
            btnGuardar.Enabled = False
            Me.txtFechaCorte.SoloLectura = True
            Me.cboVendedores.SoloLectura = True
            Me.txtMotivoDescuento.SoloLectura = True
            Me.txtValorDescuento.SoloLectura = True
        End If

        cboEstatus.SoloLectura = True
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtFechaCorte.Valor = Date.Today
        Me.cboEstatus.Valor = "P"
        btnAplicarEstadoCuenta.Enabled = True
        btnBuscarComi.Enabled = True
        Me.txtFechaCorte.SoloLectura = False
        Me.cboVendedores.SoloLectura = False
        Me.txtIdEstadoCuenta.SoloLectura = True
        Me.cboVendedores.Focus()
        Me.cboEstatus.SoloLectura = True
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Me.VistaComisiones.PostEditor()
        Call ActualizarTotal()
    End Sub

    Private Sub ActualizarTotal()
        Try
            Dim Total As Double = 0, VComi As Double = 0
            For NF As Integer = 0 To VistaComisiones.DataRowCount - 1
                If VistaComisiones.GetRowCellValue(NF, "Incluir") = True Then
                    Try
                        VComi = VistaComisiones.GetRowCellValue(NF, "ComiVendedor")
                    Catch ex As Exception
                        VComi = 0
                    End Try
                    Total += VComi
                End If
            Next
            txtTotal.Valor = Total
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnBuscarComi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarComi.Click

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            If cboVendedores.Valor = "" Then
                MsgBox("Debe especificar el Vendedor", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If txtFechaCorte.Text = "" Then
                MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            Try
                Dim sql As String = ""
                'Dim IdTipoVendedor As String = ""
                'Try
                '    IdTipoVendedor = StiGlobalConn.ObtenerDataset("select IdTipoVendedor from Vendedores where idvendedor = " & dbStr(cboVendedores.Valor)).Tables(0).Rows(0).Item(0)
                'Catch ex As Exception
                '    IdTipoVendedor = ""
                'End Try

                'If IdTipoVendedor = "" Then
                '    MsgBox("No se ha podido determinar el tipo de vendedor para obtener su comisión, Verifique la ficha del vendedor.", MsgBoxStyle.Information, "AVISO...")
                '    Exit Sub
                'End If

                Me.Cursor = Cursors.WaitCursor

                'Estas son las comisiones producto de pagos de facturas de seguros

                sql = "  select f.NumeroFactura"
                sql &= " , f.IdProducto"
                sql &= " , f.IdPoliza"
                sql &= " , f.IdRamo"
                sql &= " , m.IdMovimiento"
                sql &= " , f.NombreCliente"
                sql &= " , m.FechaMovimiento as FechaPago"
                sql &= " , isnull(m.Comision,0) * -1 as Comision"
                sql &= " , cast(1 as bit) as Incluir"
                sql &= " , f.fechapago as FechaVence"
                sql &= " , isnull(m.PrimaNeta,0) * -1 as PrimaNeta"
                sql &= " , isnull(f.PorceComision,0) as PorceComi"
                sql &= " , 0.0 as PorceVendedor"
                sql &= " , 0.0 as ComiVendedor"
                sql &= " , f.NumCuota"
                sql &= " , f.TotalCuotas"
                sql &= " , a.Nombre as Aseguradora"
                sql &= " from facturas as f"
                sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo"
                sql &= " inner join Productos as p on f.idproducto = p.idproducto"
                sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora "
                sql &= " where m.FechaMovimiento <= " & dbFec(txtFechaCorte.Valor)
                sql &= " and m.TipoMovimiento = 'PAGO' "
                sql &= " and m.FechaPagoComision is null"
                'que la factura sea del vendedor.
                sql &= " and ("
                sql &= " (select count(*) from Polizas as p inner join polizasCertificados as c on p.idpoliza = c.idpoliza and p.idproducto = c.idproducto inner join PolizasVendedores as v on v.idpoliza = p.idpoliza and p.idproducto = v.idproducto where p.IdPoliza = m.IdPoliza and p.IdProducto = m.Idproducto and v.idvendedor = " & dbStr(cboVendedores.Valor) & " and (v.FechaEfectiva is null or v.FechaEfectiva <= f.FechaPago )   ) > 0"
                sql &= " or (select top 1 c.idvendedor from polizasCertificados as c where c.IdPoliza = m.IdPoliza and c.IdProducto = m.Idproducto and c.IdCliente = f.IdCliente and c.idvendedor is not null and (select count(*) from PolizasVendedores as v where v.idpoliza = c.idpoliza and v.idproducto = c.idproducto ) = 0  ) = " & dbStr(cboVendedores.Valor)
                sql &= " ) "
                ''no debe existir para el vendedor y movimiento un registro previo.
                sql &= " and (select count(*) from EstadosCuentaVendedores as ev inner join EstadosCuentaVendedoresFacturas as ef on ev.IdEstadoCuenta = ef.IdEstadoCuenta where ev.IdVendedor = " & dbStr(cboVendedores.Valor) & " and ef.NumeroFactura = m.NumeroFactura and ef.IdProducto = m.IdProducto and ef.IdPoliza = m.IdPoliza and ef.IdRamo = m.IdRamo and ef.IdMovimiento = m.IdMovimiento ) = 0"

                If VisibilidadUsuario() = "D" Then
                    sql &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                End If
                
                Dim dsComi As DataSet = StiGlobalConn.ObtenerDataset(sql)

                'realizamos los calculos de la comisión del vendedor
                Dim ComiAge As New ComisionVendedor
                Dim FilComi As DataRow
                For Each FilComi In dsComi.Tables(0).Rows
                    ComiAge = ObtenerComisionVendedor(Me.cboVendedores.Valor, dbData(FilComi, "IdProducto"), dbData(FilComi, "IdPoliza"))
                    FilComi("PorceVendedor") = ComiAge.Porce
                    Select Case ComiAge.FormaPago
                        Case "PERIODICA"
                            FilComi("ComiVendedor") = (Val(FilComi("Comision")) * (Val(ComiAge.Porce) / 100)) + Val(ComiAge.Valor)
                        Case "PERIODICAT"
                            FilComi("ComiVendedor") = (Val(FilComi("PrimaNeta")) * (Val(ComiAge.Porce) / 100)) + Val(ComiAge.Valor)

                        Case "ANTICIPADA"
                            'En la comision anticipada la comision se paga únicamente en la cuota 1
                            'y se paga en su totalidad por las demás cuotas aunque no estén pagadas
                            If Val(FilComi("NumCuota")) = 1 Then
                                FilComi("ComiVendedor") = (Val(FilComi("Comision")) * (Val(FilComi("TotalCuotas"))) * (Val(ComiAge.Porce) / 100)) + Val(ComiAge.Valor)
                            End If
                    End Select
                Next

                GridComisiones.DataSource = dsComi.Tables(0)
                GridComisiones.Refresh()
                Call ActualizarTotal()

                Me.Cursor = Cursors.Default

                If dsComi.Tables(0).Rows.Count = 0 Then
                    MsgBox("No se encontraron comisiones pendientes de pagar al vendedor especificado.", MsgBoxStyle.Information, "AVISO...")
                End If
            Catch ex As Exception
                msgError(ex)
            End Try
        Else
            MsgBox("Las facturas del estado de cuenta ya estan cargadas, solo se pueden obtener si está creando un nuevo estado de cuenta ", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub btnAplicarEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarEstadoCuenta.Click
        'vamos a aplicar le pago de las comisiones como aceptadas
        If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
            Try
                If Me.cboVendedores.Valor = "" Then
                    MsgBox("Debe especificar el vendedor.", MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
                If txtFechaCorte.Text = "" Then
                    MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
                If Me.VistaComisiones.RowCount = 0 Then
                    MsgBox("No se han especificado comisiones para aplicarse.", MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If

                If MsgBox("¿Esta seguro que desea aplica el estado de cuenta de vendedores a las facturas.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
                    Exit Sub
                End If

                Dim sql As String
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
                For NF As Integer = 0 To VistaComisiones.DataRowCount - 1
                    If VistaComisiones.GetRowCellValue(NF, "Incluir") = True Then
                        ''marcamos la factura hasta que todos los vendedores de la poliza tengan un estado de cuenta
                        Dim NumVendedores As Integer = 0, NumVenEstadosCuenta As Integer = 0
                        NumVendedores = StiGlobalConn.ObtenerDataset("select count(*) from PolizasVendedores where idpoliza = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdPoliza")) & " and idproducto = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdProducto"))).Tables(0).Rows(0).Item(0)
                        NumVenEstadosCuenta = StiGlobalConn.ObtenerDataset("select count(distinct IdEstadoCuenta) from EstadosCuentaVendedoresFacturas where NumeroFactura = " & dbInt(VistaComisiones.GetRowCellValue(NF, "NumeroFactura")) & " and IdProducto = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdProducto")) & " and IdPoliza = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdPoliza")) & " and IdRamo = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdRamo")) & " and IdMovimiento = " & dbInt(VistaComisiones.GetRowCellValue(NF, "IdMovimiento"))).Tables(0).Rows(0).Item(0)

                        If NumVendedores = NumVenEstadosCuenta Then
                            sql = "  update FacturasMovimientos set FechaPagoComision = " & dbFec(Date.Today)
                            sql &= " where NumeroFactura = " & dbInt(VistaComisiones.GetRowCellValue(NF, "NumeroFactura"))
                            sql &= " and IdProducto = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdProducto"))
                            sql &= " and IdPoliza = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdPoliza"))
                            sql &= " and IdRamo = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdRamo"))
                            sql &= " and IdMovimiento = " & dbInt(VistaComisiones.GetRowCellValue(NF, "IdMovimiento"))
                            StiGlobalConn.SQLExecute(sql)
                        End If
                    End If
                Next

                ''actualizamos el estado de cuenta
                StiGlobalConn.SQLExecute("update EstadosCuentaVendedores set Estatus = 'A' where IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor))
                StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                MsgBox("La operación ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")
                Me.Close()
            Catch ex As Exception
                StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                MsgBox("Error al aplicar el estado de cuenta, la operación ha sido cancelada.", MsgBoxStyle.Exclamation, "AVISO...")
                msgError(ex)
            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            'primero el estado de cuenta
            sql = "  select e.IdEstadoCuenta as IdEstadoCuenta, a.NombreVendedor as Aseguradora, e.FechaCorte as FechaCorte "
            sql &= " , getdate() as FechaImpresion, a.Direccion as DireAseguradora"
            sql &= ", case when a.RegistroFiscal is null then 0 else 1 end as TieneCF"
            sql &= " from EstadosCuentaVendedores as e "
            sql &= " inner join Vendedores as a on e.IdVendedor = a.IdVendedor"
            sql &= " where e.IdEstadoCuenta = " & dbInt(Me.txtIdEstadoCuenta.Valor)
            Dim dtEstados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtEstados.TableName = "EstadoCuenta"

            'ahora los movimientos del estado de cuenta
            sql = "  select e.IdEstadoCuenta as IdEstadoCuenta, e.IdPoliza as Poliza, e.NumeroFactura as Factura"
            sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota, e.FechaPago, f.NombreCliente as Cliente, r.NombreRamo as Ramo, e.PorceVendedor as PorceComi"
            sql &= " , m.PrimaNeta * -1 as Prima "
            sql &= " , case when e.ComiVendedor < 0 then e.ComiVendedor * -1 else 0.0 end as Cargo"
            sql &= " , case when e.ComiVendedor >= 0 then e.ComiVendedor else 0.0 end as Abono"
            sql &= " , e.ComiVendedor as ValComi"
            sql &= " , isnull(a.Siglas,a.Nombre) as AseguradoraFact"
            sql &= " , e.Comision as ComiFactura"
            sql &= " from EstadosCuentaVendedoresFacturas as e"
            sql &= " left join Facturas as f on f.NumeroFactura = e.NumeroFactura and f.IdProducto = e.IdProducto and f.IdPoliza = e.IdPoliza and f.IdRamo = e.IdRamo "
            sql &= " left join FacturasMovimientos as m on m.NumeroFactura = e.NumeroFactura and m.IdProducto = e.IdProducto and m.IdPoliza = e.IdPoliza and m.IdRamo = e.IdRamo and m.IdMovimiento = e.IdMovimiento"
            sql &= " left join RamoSeguros as r on r.idramo = e.idramo"
            sql &= " left join Productos as p on p.idproducto = f.idproducto"
            sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " where e.IdEstadoCuenta = " & dbInt(Me.txtIdEstadoCuenta.Valor)

            If txtMotivoDescuento.Text <> "" And Val(txtValorDescuento.Valor) > 0 Then
                sql &= " union "
                sql &= " select " & dbStr(txtIdEstadoCuenta.Valor) & " as IdEstadoCuenta, null as Poliza, null as Factura"
                sql &= " ,null as Cuota, null as FechaPago, null as Cliente, null as Ramo, null as PorceComi"
                sql &= " , 0.00 as Prima, " & dbNum(txtValorDescuento.Valor) & " as Cargo, 0.0 as Abono"
                sql &= " , " & dbNum(txtValorDescuento.Valor * -1) & " as ValComi"
                sql &= " , " & dbStr(txtMotivoDescuento.Valor) & " as AseguradoraFact, 0.00 as ComiFactura "
            End If


            Dim dtEstadosMov As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtEstadosMov.TableName = "EstadoCuentaMov"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtEstados.Copy)
            DsRep.Tables.Add(dtEstadosMov.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As Object
            Reporte = New RepEstadoCuentaComiVend
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.EstComi.Vend")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Reporte.SetDataSource(DsRep)
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

End Class
