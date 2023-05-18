Imports Utilerias.Genericas

Public Class EstadosCuentaComiMan

    Private Sub btnBuscarComi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarComi.Click

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            If cboAseguradora.Valor = "" Then
                MsgBox("Debe especificar la Aseguradora", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If txtFechaCorte.Text = "" Then
                MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            Try
                Dim sql As String = ""

                'Estas son las comisiones producto de pagos de facturas de seguros

                sql = "  select 'PAGO' as Tipo, f.NumeroFactura, f.IdProducto, f.IdPoliza, f.IdRamo, m.IdMovimiento, f.NombreCliente"
                sql &= " , m.FechaMovimiento as FechaPago, m.Comision * -1 as Comision, cast(1 as bit) as Incluir"
                sql &= ", f.fechapago as FechaVence, m.PrimaNeta * -1 as PrimaNeta, f.PorceComision as PorceComi"
                sql &= " from facturas as f"
                sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo"
                sql &= " inner join Productos as p on f.idproducto = p.idproducto"
                sql &= " where m.FechaMovimiento <= " & dbFec(txtFechaCorte.Valor)
                sql &= " and m.TipoMovimiento = 'PAGO' "
                sql &= " and m.FechaCobroComision is null"
                sql &= " and p.IdAseguradora = " & dbStr(cboAseguradora.Valor)
                If VisibilidadUsuario() = "D" Then
                    sql &= " and (select count(*) from polizas as pol where pol.idpoliza = m.idpoliza and pol.idproducto = m.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                End If

                'le adicionaremos los movimientos manuales de comisiones
                sql &= "  UNION "

                sql &= "  select 'MANUAL' as Tipo, m.IdMovimientoComi as NumeroFactura, 'N/A' as IdProducto, 'N/A' as IdPoliza, 'N/A' as IdRamo, 1 as IdMovimiento, m.Descripcion"
                sql &= " ,m.FechaComision as FechaPago"
                sql &= " ,case t.Tipo"
                sql &= " when 'A' then m.ValorComision"
                sql &= " else m.ValorComision * -1"
                sql &= " end as Comision"
                sql &= " ,cast(1 as bit) as Incluir, m.FechaComision as FechaVence, 0.0 as PrimaNeta, 0.0 as PorceComi"
                sql &= " from MovimientosComision as m"
                sql &= " inner join TipoOperacionesComi as t on m.IdOperacion = t.IdOperacion"
                sql &= " where m.FechaComision <= " & dbFec(txtFechaCorte.Valor)
                sql &= " and m.FechaCobroComision is null"
                sql &= " and m.IdAseguradora = " & dbStr(cboAseguradora.Valor)


                Dim dsComi As DataSet = StiGlobalConn.ObtenerDataset(sql)
                GridComisiones.DataSource = dsComi.Tables(0)
                GridComisiones.Refresh()
                Call ActualizarTotal()

                If dsComi.Tables(0).Rows.Count = 0 Then
                    MsgBox("No se encontraron comisiones pendientes de tramitar en la aseguradora.", MsgBoxStyle.Information, "AVISO...")
                End If
            Catch ex As Exception
                msgError(ex)
            End Try
        Else
            MsgBox("Las facturas del estado de cuenta ya estan cargadas, solo se pueden obtener si está creando un nuevo estado de cuenta ", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub EstadosCuentaComiMan_AntesDeEliminar(ByRef Cancel As Boolean) Handles Me.AntesDeEliminar
        'eliminaremos la tabla relacionada no conectada
        StiGlobalConn.SQLExecute("delete from EstadosCuentaComisionesFacturas where IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor))
    End Sub

    Private Sub EstadosCuentaComiMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        'especificamos el número del estado de cuenta
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And txtIdEstadoCuenta.Text = "" Then
            Dim IdEstadoCuenta As Integer = clSeguros.ObtenerID("Num.Estado.Cuenta.Comi")
            txtIdEstadoCuenta.Valor = IdEstadoCuenta
        End If
    End Sub

    Private Sub EstadosCuentaComiMan_DespuesDeCargarRegistro() Handles Me.DespuesDeCargarRegistro
        try
            'cargaremos informacion del grid
            Dim sql As String = ""
            sql = "  select f.TipoComision as Tipo, f.NumeroFactura, f.IdProducto, f.IdPoliza, f.IdMovimiento, fa.NombreCliente, f.IdRamo "
            sql &= " ,m.FechaMovimiento as FechaPago, m.Comision * -1 as Comision, cast(1 as bit) as Incluir"
            sql &= " ,fa.fechapago as FechaVence, m.PrimaNeta * -1 as PrimaNeta, fa.PorceComision as PorceComi"
            sql &= " from EstadosCuentaComisionesFacturas as f"
            sql &= " inner join Facturas as fa on fa.NumeroFactura = f.NumeroFactura and fa.IdProducto = f.IdProducto and fa.IdPoliza = f.IdPoliza and fa.idramo = f.idramo"
            sql &= " inner join FacturasMovimientos as m on m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.IdMovimiento = f.IdMovimiento"
            sql &= " where f.IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor)
            sql &= " and f.TipoComision = 'PAGO' "

            sql &= " UNION "

            sql &= " select f.TipoComision as Tipo, m.IdMovimientoComi as NumeroFactura, 'N/A' as IdProducto, 'N/A' as IdPoliza, 1 as IdMovimiento, m.Descripcion, 'N/A' as IdRamo"
            sql &= " ,m.FechaComision as FechaPago"
            sql &= " ,case t.Tipo"
            sql &= " when 'A' then m.ValorComision"
            sql &= " else m.ValorComision * -1"
            sql &= " end as Comision"
            sql &= " ,cast(1 as bit) as Incluir, m.FechaComision as FechaVence, 0.0 as PrimaNeta, 0.0 as PorceComi"
            sql &= " from EstadosCuentaComisionesFacturas as f"
            sql &= " inner join MovimientosComision as m on f.NumeroFactura = m.IdMovimientoComi "
            sql &= " inner join TipoOperacionesComi as t on m.IdOperacion = t.IdOperacion"
            sql &= " where f.IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor)
            sql &= " and f.TipoComision = 'MANUAL' "

            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridComisiones.DataSource = dtDatos
            GridComisiones.Refresh()

            Call ActualizarTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EstadosCuentaComiMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Try
            'ahora las facturas
            Dim sql As String = ""
            StiGlobalConn.SQLExecute("delete from EstadosCuentaComisionesFacturas where IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor))
            For NF As Integer = 0 To VistaComisiones.DataRowCount - 1
                If VistaComisiones.GetRowCellValue(NF, "Incluir") = True Then
                    sql = "  insert into EstadosCuentaComisionesFacturas "
                    sql &= " (IdEstadoCuenta, NumeroFactura, IdProducto, IdPoliza, IdRamo"
                    sql &= " ,IdMovimiento, FechaPago, Comision, TipoComision) values("
                    sql &= dbInt(txtIdEstadoCuenta.Valor) & C & dbInt(VistaComisiones.GetRowCellValue(NF, "NumeroFactura")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "IdProducto")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "IdPoliza")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "IdRamo")) & C
                    sql &= dbInt(VistaComisiones.GetRowCellValue(NF, "IdMovimiento")) & C & dbFec(VistaComisiones.GetRowCellValue(NF, "FechaPago")) & C & dbNum(VistaComisiones.GetRowCellValue(NF, "Comision")) & C & dbStr(VistaComisiones.GetRowCellValue(NF, "Tipo")) & ")"
                    StiGlobalConn.SQLExecute(sql)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarTotal()
        Try
            Dim Total As Double = 0, VComi As Double = 0
            For NF As Integer = 0 To VistaComisiones.DataRowCount - 1
                If VistaComisiones.GetRowCellValue(NF, "Incluir") = True Then
                    Try
                        VComi = VistaComisiones.GetRowCellValue(NF, "Comision")
                    Catch ex As Exception
                        VComi = 0
                    End Try
                    Total += VComi
                End If
            Next
            txtTotal.Valor = Total
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Me.VistaComisiones.PostEditor()
        Call ActualizarTotal()
    End Sub

    Private Sub btnAplicarEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarEstadoCuenta.Click
        'vamos a aplicar le pago de las comisiones como aceptadas
        If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
            Try
                If cboAseguradora.Valor = "" Then
                    MsgBox("Debe especificar la aseguradora.", MsgBoxStyle.Information, "AVISO...")
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

                If MsgBox("¿Esta seguro que desea aplica el estado de cuenta a las facturas.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
                    Exit Sub
                End If

                Dim sql As String
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
                For NF As Integer = 0 To VistaComisiones.DataRowCount - 1
                    If VistaComisiones.GetRowCellValue(NF, "Incluir") = True Then
                        If CStr(VistaComisiones.GetRowCellValue(NF, "Tipo")).Trim.ToUpper = "PAGO" Then
                            sql = "  update FacturasMovimientos set FechaCobroComision = " & dbFec(Date.Today)
                            sql &= " where NumeroFactura = " & dbInt(VistaComisiones.GetRowCellValue(NF, "NumeroFactura"))
                            sql &= " and IdProducto = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdProducto"))
                            sql &= " and IdPoliza = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdPoliza"))
                            sql &= " and IdRamo = " & dbStr(VistaComisiones.GetRowCellValue(NF, "IdRamo"))
                            sql &= " and IdMovimiento = " & dbInt(VistaComisiones.GetRowCellValue(NF, "IdMovimiento"))
                            StiGlobalConn.SQLExecute(sql)
                        Else
                            'es un movimiento manual
                            sql = "  update MovimientosComision set FechaCobroComision = " & dbFec(Date.Today)
                            sql &= " where IdMovimientoComi = " & dbInt(VistaComisiones.GetRowCellValue(NF, "NumeroFactura"))
                            StiGlobalConn.SQLExecute(sql)
                        End If
                    End If
                Next

                ''actualizamos el estado de cuenta
                StiGlobalConn.SQLExecute("update EstadosCuentaComisiones set Estatus = 'A' where IdEstadoCuenta = " & dbInt(txtIdEstadoCuenta.Valor))
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtFechaCorte.Valor = Date.Today
        Me.cboEstatus.Valor = "P"
        btnAplicarEstadoCuenta.Enabled = True
        btnBuscarComi.Enabled = True
        Me.txtFechaCorte.SoloLectura = False
        Me.cboAseguradora.SoloLectura = False
        Me.txtIdEstadoCuenta.SoloLectura = True
        Me.cboAseguradora.Focus()
        Me.cboEstatus.SoloLectura = True
    End Sub

    Private Sub EstadosCuentaComiMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.cboAseguradora.SoloLectura = True
        End If

        cboEstatus.SoloLectura = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Estado Cuenta.xls"
        'GridComisiones.ExportToXls(Archivo)
        'PrepararArchivoExcel(Archivo, "Reporte de Estado de cuenta Comisiones", "Aseguradora: " & cboAseguradora.Text & ", Fecha de Corte:" & txtFechaCorte.Text, "Reporte al:" & Format(Date.Today, "Long Date"))

        'Generamos el reporte final en formato de estado de cuenta

        Try
            Dim sql As String = ""

            'primero el estado de cuenta
            sql = "  select e.IdEstadoCuenta as IdEstadoCuenta, a.Nombre as Aseguradora, e.FechaCorte as FechaCorte, getdate() as FechaImpresion, a.Direccion as DireAseguradora "
            sql &= " from EstadosCuentaComisiones as e "
            sql &= " inner join Aseguradoras as a on e.IdAseguradora = a.IdAseguradora"
            sql &= " where e.IdEstadoCuenta = " & dbInt(Me.txtIdEstadoCuenta.Valor)
            Dim dtEstados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtEstados.TableName = "EstadoCuenta"

            'ahora los movimientos del estado de cuenta
            sql = "  select e.IdEstadoCuenta as IdEstadoCuenta, e.IdPoliza as Poliza, e.NumeroFactura as Factura"
            sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota, e.FechaPago, f.NombreCliente as Cliente, r.NombreRamo as Ramo, f.PorceComision as PorceComi"
            sql &= " , m.PrimaNeta * -1 as Prima "
            sql &= " , case when e.Comision < 0 then e.Comision * -1 else 0.0 end as Cargo"
            sql &= " , case when e.Comision >= 0 then e.Comision else 0.0 end as Abono"
            sql &= " from EstadosCuentaComisionesFacturas as e"
            sql &= " left join Facturas as f on f.NumeroFactura = e.NumeroFactura and f.IdProducto = e.IdProducto and f.IdPoliza = e.IdPoliza and f.IdRamo = e.IdRamo "
            sql &= " left join FacturasMovimientos as m on m.NumeroFactura = e.NumeroFactura and m.IdProducto = e.IdProducto and m.IdPoliza = e.IdPoliza and m.IdRamo = e.IdRamo and m.IdMovimiento = e.IdMovimiento"
            sql &= " left join RamoSeguros as r on r.idramo = e.idramo"
            sql &= " where e.IdEstadoCuenta = " & dbInt(Me.txtIdEstadoCuenta.Valor)
            sql &= " and e.TipoComision = 'PAGO'"

            sql &= " UNION "

            sql &= "  select e.IdEstadoCuenta as IdEstadoCuenta, 'N/A' as Poliza, e.NumeroFactura as Factura"
            sql &= " , 'N/A' as Cuota, e.FechaPago, m.Descripcion as Cliente, 'N/A' as Ramo, 0.0 as PorceComi"
            sql &= " , 0.0 Prima "
            sql &= " , case when e.Comision < 0 then e.Comision * -1 else 0.0 end as Cargo"
            sql &= " , case when e.Comision >= 0 then e.Comision else 0.0 end as Abono"
            sql &= " from EstadosCuentaComisionesFacturas as e"
            sql &= " inner join MovimientosComision as m on e.NumeroFactura = m.IdMovimientoComi "
            sql &= " inner join TipoOperacionesComi as t on m.IdOperacion = t.IdOperacion"
            
            sql &= " where e.IdEstadoCuenta = " & dbInt(Me.txtIdEstadoCuenta.Valor)
            sql &= " and e.TipoComision = 'MANUAL'"

            Dim dtEstadosMov As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtEstadosMov.TableName = "EstadoCuentaMov"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtEstados.Copy)
            DsRep.Tables.Add(dtEstadosMov.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New RepEstadoCuentaComi
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            'SetRepFormulaString(Reporte,"NombreEmpresa",ObtenerParametro("Cliente"))
            'SetRepFormulaString(Reporte,"Titulo1","Reporte de Comisiones por Producto")
            'SetRepFormulaString(Reporte,"Titulo2","Reporte al " & Format(Date.Today, "Long Date"))
            'SetRepFormulaString(Reporte,"Titulo3","")
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

End Class
