Imports Utilerias.Genericas

Public Class ClientesMan

    Dim PrimasPendientesCargadas As Boolean = False
    Dim AvisosCobroCargados As Boolean = False
    Dim EstadoCuentaCargado As Boolean = False
    Dim DepositosCargados As Boolean = False
    Dim DetalleFacturasCargados As Boolean = False
    Dim PolizasCargadas As Boolean = False
    Dim CertificadosCargados As Boolean = False
    Dim SiniestrosCargados As Boolean = False

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim Id As Integer = ObtenerIDcontacto()
            Me.AgregarFilaGrid(GridView1)
            'ademos agregaremos el Id de contacto
            Me.GridView1.SetRowCellValue(Me.GridView1.FocusedRowHandle, "IdContacto", Id)
            Me.GridView1.UpdateCurrentRow()

        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDcontacto() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView1.DataRowCount - 1
            Try
                If CInt(GridView1.GetRowCellValue(I, "IdContacto")) > Id Then
                    Id = CInt(GridView1.GetRowCellValue(I, "IdContacto"))
                End If
            Catch ex As Exception

            End Try
        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.GridView1.FocusedColumn.FieldName
            Case "Nombre", "Direccion", "EMail", "Funciones" : Me.RepositoryItemTextEdit1.MaxLength = 250
            Case "Ciudad", "Cargo" : Me.RepositoryItemTextEdit1.MaxLength = 50
            Case "Telefono" : Me.RepositoryItemTextEdit1.MaxLength = 100
        End Select
    End Sub

    Private Sub txtIdCliente_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdCliente.ValueChangeOnExit
        Call PrepararCampoPersonalizados()
        Call ActualizarLlavesGrid(Me, txtIdCliente.NombreCampo, txtIdCliente.Valor)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Dim sql As String = ""

        Select Case XtraTabControl1.TabPages(XtraTabControl1.SelectedTabPageIndex).Name
            Case "DPrimas" 'Primas Pendientes
                ''cargaremos las primas pendientes del cliente
                If PrimasPendientesCargadas = False And txtIdCliente.Text <> "" Then
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        sql = "  select f.NumeroFactura as NumeroFactura"
                        sql &= " , p.Descripcion as Producto"
                        sql &= " , r.NombreRamo as Ramo"
                        sql &= " , p.TipoProducto as TipoSeguro"
                        sql &= " , a.Nombre as Aseguradora"
                        sql &= " , f.IdPoliza as Poliza"
                        sql &= " , f.TipoFactura as TipoFactura"
                        sql &= " , f.NombreCliente as NombreCliente"
                        sql &= " , f.FechaPago as FechaPago"
                        sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
                        sql &= " , DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as Dias"
                        sql &= " , case "
                        sql &= " when DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") > 150 then '6) Más de 150'"
                        sql &= " when DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") <= 30 then '1) de 0 - 30 días'"
                        sql &= " when DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") > 30 and DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") <= 60 then '2) de 30 - 60 días'"
                        sql &= " when DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") > 60 and DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") <= 90 then '3) de 60 - 90 días'"
                        sql &= " when DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") > 90 and DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") <= 120 then '4) de 90 - 120 días'"
                        sql &= " when DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") > 120 and DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") <= 150 then '5) de 120 - 150 días'"
                        sql &= " end as RangoMora "
                        sql &= " , (select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as PrimaNeta"
                        sql &= " , (select sum(Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Gastos"
                        sql &= " , (select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Impuestos"
                        sql &= " , (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Total"
                        sql &= " from facturas as f "
                        sql &= " left join Productos as p on f.idproducto = p.idproducto"
                        sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
                        sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
                        sql &= " where "
                        'que la fecha de pago sea menor a la fecha de corte
                        sql &= " f.FechaPago <= " & dbFec(Date.Today)
                        'que tengan saldo positivo
                        sql &= " and f.IdCliente = " & dbStr(Me.txtIdCliente.Valor)
                        sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
                        If VisibilidadUsuario() = "D" Then
                            sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                        End If


                        Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
                        PivotFacturas.DataSource = dsDatos.Tables(0)
                        PivotFacturas.Refresh()

                        Me.Cursor = Cursors.Default
                        If dsDatos.Tables(0).Rows.Count = 0 Then
                            MsgBox("No se encontraron primas pendientes para la fecha de corte especificada.", MsgBoxStyle.Information, "AVISO..")
                        End If
                        PrimasPendientesCargadas = True

                    Catch ex As Exception

                    End Try
                End If

            Case "EAvisosCobro"  'AVISOS DE COBRO
                If AvisosCobroCargados = False And txtIdCliente.Text <> "" Then
                    Me.Cursor = Cursors.WaitCursor

                    sql = "  select "
                    sql &= " a.IdAvisoCobro"
                    sql &= " ,a.IdPoliza"
                    sql &= " ,a.IdProducto"
                    sql &= " ,a.VigenciaDesde"
                    sql &= " ,a.VigenciaHasta"
                    sql &= " ,a.IdAnexo"
                    sql &= " ,a.Referencia"
                    sql &= " from AvisosCobro as a"
                    sql &= " where a.IdCliente = " & dbStr(txtIdCliente.Valor)
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as p where p.idpoliza = a.idpoliza and p.idproducto = a.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0"
                    End If
                    sql &= " order by a.IdAvisoCobro desc"
                    Dim dtAC As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridAvisosCobro.DataSource = dtAC
                    GridAvisosCobro.Refresh()

                    VistaAvisosCobro.OptionsBehavior.Editable = False
                    Me.Cursor = Cursors.Default
                    AvisosCobroCargados = True
                End If

            Case "GEstadoCuenta" 'estado de cuenta
                If EstadoCuentaCargado = False And txtIdCliente.Text <> "" Then
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        sql = "  select f.NumeroFactura as NumeroFactura"
                        sql &= " , p.Descripcion as Producto"
                        sql &= " , r.NombreRamo as Ramo"
                        sql &= " , p.TipoProducto as TipoSeguro"
                        sql &= " , a.Nombre as Aseguradora"
                        sql &= " , f.IdPoliza as Poliza"
                        sql &= " , f.TipoFactura as TipoFactura"
                        sql &= " , f.NombreCliente as NombreCliente"
                        sql &= " , f.FechaPago as FechaPago"
                        sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
                        sql &= " , DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as Dias"
                        sql &= " , (select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as PrimaNeta"
                        sql &= " , (select sum(Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Gastos"
                        sql &= " , (select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Impuestos"
                        sql &= " , (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Total"
                        sql &= " , isnull((select top 1 ac.Referencia from AvisosCobro as ac inner join AvisosCobroFacturas as acf on acf.IdAvisoCobro = ac.IdAvisoCobro where acf.IdPoliza = f.IdPoliza and acf.IdProducto = f.IdProducto and acf.NumeroFactura = f.NumeroFactura and acf.IdRamo = f.IdRamo),'') as Referencia"
                        sql &= " from facturas as f "
                        sql &= " left join Productos as p on f.idproducto = p.idproducto"
                        sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
                        sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
                        sql &= " where "
                        'que la fecha de pago sea menor a la fecha de corte
                        sql &= " f.FechaPago <= " & dbFec(Date.Today.AddDays(30))
                        'que tengan saldo positivo
                        sql &= " and f.IdCliente = " & dbStr(Me.txtIdCliente.Valor)
                        sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
                        If VisibilidadUsuario() = "D" Then
                            sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                        End If

                        Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
                        PivotEstado.DataSource = dsDatos.Tables(0)
                        PivotEstado.Refresh()

                        Me.Cursor = Cursors.Default
                        If dsDatos.Tables(0).Rows.Count = 0 Then
                            MsgBox("No se encontraron Facturas/Créditos a la fecha para un estado de cuenta.", MsgBoxStyle.Information, "AVISO..")
                        End If

                        EstadoCuentaCargado = True

                    Catch ex As Exception

                    End Try
                End If

            Case "HDeposito"
                'Depósitos
                If DepositosCargados = False And txtIdCliente.Text <> "" Then
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        sql = "  select dm.IdAseguradora, sum(dm.ValorDeposito) as Saldo"
                        sql &= " from Depositos as d inner join DepositosMovimientos as dm on d.IdCliente = dm.IdCliente"
                        sql &= " where d.IdCliente = " & dbStr(txtIdCliente.Text)
                        sql &= " group by dm.IdAseguradora"
                        Dim DtDepositos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                        Me.GridDepositos.DataSource = DtDepositos
                        Me.VistaDepositos.OptionsBehavior.Editable = False
                        Me.GridDepositos.Refresh()
                        DepositosCargados = True
                        Me.Cursor = Cursors.Default
                    Catch ex As Exception

                    End Try
                End If

            Case "IFacturas"
                'Detalle de Facturas
                If DetalleFacturasCargados = False And Me.txtIdCliente.Text <> "" Then
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        sql = "  select convert(varchar, F.VigenciaDesde,103) + ' - ' + convert(varchar, F.VigenciaHasta,103)  as Vigencia"
                        sql &= " ,F.IdProducto"
                        sql &= " ,P.Descripcion as Producto"
                        sql &= " ,A.Nombre as Aseguradora"
                        sql &= " ,F.NumeroFactura as NumeroFactura"
                        sql &= " ,F.FechaPago as FechaVencimiento"
                        sql &= " ,F.IdPoliza as Poliza"
                        sql &= " ,F.IdRamo"
                        sql &= " ,isnull((select sum(Total) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo),0) as Saldo"
                        sql &= " ,isnull((select sum(Total) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo and M.TipoMovimiento in ('EMISION','ANULACION')),0) as Total"
                        sql &= " ,case "
                        sql &= " when (select sum(Total) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo) > 0 then 'PENDIENTE'"
                        sql &= " when (select sum(Total) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo) <= 0 and (select count(*) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo and M.TipoMovimiento = 'PAGO')  > 0 then 'PAGADA'"
                        sql &= " when (select sum(Total) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo) <= 0 and (select count(*) from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo and M.TipoMovimiento = 'ANULACION') > 0 then 'ANULADA'"
                        sql &= " end as Estado"
                        sql &= " ,F.Referencia as Referencia"
                        sql &= " ,(select top 1 fechamovimiento from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo and M.tipomovimiento = 'pago' order by M.fechamovimiento desc) as FechaPago"
                        sql &= " ,(select top 1 fechamovimiento from FacturasMovimientos as M where M.NumeroFactura = F.NumeroFactura and M.IdProducto = F.IdProducto and M.IdPoliza = F.IdPoliza and M.IdRamo = F.IdRamo and M.tipomovimiento = 'anulacion' order by M.fechamovimiento desc) as FechaAnula"
                        sql &= " from Facturas as F "
                        sql &= " inner join Productos as P on F.IdProducto = P.IdProducto "
                        sql &= " inner join Aseguradoras as A on A.IdAseguradora = P.IdAseguradora "
                        sql &= " where F.IdCliente = " & dbStr(txtIdCliente.Valor)
                        If VisibilidadUsuario() = "D" Then
                            sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                        End If
                        Dim DtDetFact As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                        Me.gridDetFacturas.DataSource = DtDetFact
                        Me.gridDetFacturas.Refresh()
                        Me.vistaDetFacturas.OptionsBehavior.Editable = False
                        DetalleFacturasCargados = True
                        Me.Cursor = Cursors.Default
                    Catch ex As Exception
                        msgError(ex)
                    End Try
                End If

            Case "CPolizas"
                If PolizasCargadas = False And txtIdCliente.Text <> "" Then
                    Me.Cursor = Cursors.WaitCursor

                    sql = "  select "
                    sql &= "  p.IdPoliza"
                    sql &= " ,p.IdProducto"
                    sql &= " ,o.Descripcion as Producto"
                    sql &= " ,p.VigenciaDesde"
                    sql &= " ,p.VigenciaHasta"
                    sql &= " ,p.FechaCancelacion as FechaCancela"
                    sql &= " ,p.MotivoCancelacion as MotivoCan"
                    sql &= " from polizas as p "
                    sql &= " inner join Productos as o on o.idproducto = p.idproducto"
                    sql &= " where p.IdCliente = " & dbStr(txtIdCliente.Valor)
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    sql &= " order by p.VigenciaDesde desc"
                    Dim dtPol As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridPolizas.DataSource = dtPol
                    GridPolizas.Refresh()

                    VistaPolizas.OptionsBehavior.Editable = False
                    Me.Cursor = Cursors.Default
                    PolizasCargadas = True
                End If

            Case "JCertificados"
                If CertificadosCargados = False And txtIdCliente.Text <> "" Then
                    Me.Cursor = Cursors.WaitCursor

                    sql = "  select "
                    sql &= " o.IdProducto"
                    sql &= " ,o.Descripcion as Producto"
                    sql &= " ,c.IdPoliza"
                    sql &= " ,c.IdCertificado"
                    sql &= " ,c.VigenciaDesde"
                    sql &= " ,c.VigenciaHasta"
                    sql &= " ,c.ValorAsegurado as Suma"
                    sql &= " ,c.PrimaNeta"
                    sql &= " ,isnull(c.GastosEmi,0) + isnull(c.GastosFrac,0) + isnull(c.GastosBomb,0) + isnull(c.GastosOtros,0) as Gastos"
                    sql &= " ,c.Iva"
                    sql &= " ,c.Total"
                    sql &= " ,c.EstadoCertificado as Estado"
                    sql &= " from PolizasCertificados as c"
                    sql &= " inner join Productos as o on o.idproducto = c.idproducto"
                    sql &= " where c.IdCliente = " & dbStr(txtIdCliente.Valor)
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as pol where pol.idpoliza = c.idpoliza and pol.idproducto = c.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                    End If

                    Dim dtCert As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridCertificados.DataSource = dtCert
                    GridCertificados.Refresh()

                    VistaCertificados.OptionsBehavior.Editable = False
                    Me.Cursor = Cursors.Default
                    CertificadosCargados = True
                End If

            Case "FSiniestros"
                If SiniestrosCargados = False And Me.txtIdCliente.Text <> "" Then
                    Me.Cursor = Cursors.WaitCursor

                    sql = "  select "
                    sql &= " s.IdProducto"
                    sql &= " ,o.Descripcion as Producto"
                    sql &= " ,s.IdPoliza"
                    sql &= " ,s.IdSiniestro"
                    sql &= " ,s.FechaOcurrido as FechaOcurre"
                    sql &= " ,s.EstadoSiniestro as Estado"
                    sql &= " ,s.IdCertificado"
                    sql &= " , isnull((select sum(d.ValorPresentado) from SiniestrosDetalle as d where d.idpoliza = s.idpoliza and d.idproducto = s.idproducto and d.idsiniestro = s.idsiniestro and d.idcertificado = s.idcertificado),0) as ValorPresenta"
                    sql &= " , isnull((select sum(d.ValorReembolso) from SiniestrosPagos as d where d.idpoliza = s.idpoliza and d.idproducto = s.idproducto and d.idsiniestro = s.idsiniestro and d.idcertificado = s.idcertificado),0) as ValorPagado"
                    sql &= " from Siniestros as s"
                    sql &= " inner join PolizasCertificados as c on c.idproducto = s.idproducto and c.idpoliza = s.idpoliza and c.idcertificado = s.idcertificado"
                    sql &= " inner join Productos as o on o.idproducto = c.idproducto"
                    sql &= " where c.IdCliente = " & dbStr(txtIdCliente.Valor)
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as pol where pol.idpoliza = c.idpoliza and pol.idproducto = c.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                    End If

                    Dim dtSin As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridSiniestros.DataSource = dtSin
                    GridSiniestros.Refresh()

                    VistaSiniestros.OptionsBehavior.Editable = False
                    Me.Cursor = Cursors.Default
                    SiniestrosCargados = True
                End If

        End Select
    End Sub

    Private Sub VistaAvisosCobro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaAvisosCobro.DoubleClick
        Try
            Dim FilAC As Integer = VistaAvisosCobro.FocusedRowHandle
            If FilAC >= 0 Then
                'consultaremos el aviso de cobro
                Dim FAC As New Facturacion
                FAC.Permiso = Me.Permiso
                FAC.STIConn = StiGlobalConn
                FAC.dbCondicion = "IdAvisoCobro = " & dbStr(Me.VistaAvisosCobro.GetRowCellValue(FilAC, "IdAvisoCobro"))
                FAC.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConsultarAvisoDeCobroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarAvisoDeCobroToolStripMenuItem.Click
        Try
            Call VistaAvisosCobro_DoubleClick(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClientesMan_AntesDeCargarFormulario() Handles Me.AntesDeCargarFormulario

        Dim EstadosCliente As String = clSeguros.ObtenerDBParametros("Clientes.Estados")
        Dim NumElementos As Integer = CuentaCar(EstadosCliente, ","), Elemento As String = ""
        Dim LstEstados As String = ""
        For NE As Integer = 0 To NumElementos
            Elemento = stiSplit(EstadosCliente, "G" & NE & ",1").Trim
            If LstEstados = "" Then
                LstEstados = Replace(Elemento, " ", "_") & " " & Elemento
            Else
                LstEstados &= "|" & Replace(Elemento, " ", "_") & " " & Elemento
            End If
        Next
        cboEstadoCliente.Lista = LstEstados
    End Sub

    Private Sub ClientesMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            'una validación para evitar en lo posible un nombre de cliente duplicado
            Dim NombreCliente As String = Me.txtNombreCliente.Valor
            Dim strWhere As String = ""
            Dim Palabra As String = ""
            Dim I As Integer = 0
            For I = 0 To CuentaCar(NombreCliente, " ")
                Palabra = stiSplit(NombreCliente, "G" & I & " 1").Trim
                If Palabra <> "" Then
                    If strWhere = "" Then
                        strWhere &= " where NombreCliente like " & dbStr("%" & Palabra & "%")
                    Else
                        strWhere &= " and NombreCliente like " & dbStr("%" & Palabra & "%")
                    End If
                End If
            Next
            If strWhere <> "" Then
                Dim dtClientes As DataTable = StiGlobalConn.ObtenerDataset("select idcliente, NombreCliente from clientes " & strWhere).Tables(0)
                If dtClientes.Rows.Count > 0 Then
                    NombreCliente = ""
                    For Each FilCli As DataRow In dtClientes.Rows
                        NombreCliente &= dbData(FilCli, "idcliente") & " - " & dbData(FilCli, "NombreCliente") & vbCrLf
                    Next
                    If MsgBox("Se han encontrado clientes registrados con nombres similares:" & vbCrLf & NombreCliente & "¿Desea ingresar el registro del cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                        Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ClientesMan_DespuesDeCargarRegistro() Handles Me.DespuesDeCargarRegistro
        If txtIdCliente.Valor <> "" Then Me.lblEstado.Text = "Estado del Cliente: " & funEstadoCliente(txtIdCliente.Valor)
    End Sub

    Private Sub ClientesMan_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        Try
            Dim opcCliente As String = clSeguros.ObtenerDBParametros("Clientes.ActEjecutivo")
            Dim sql As String = ""
            If opcCliente <> "" Then
                sql = "  update Polizas set EjecutivoCta = (isnull((select top 1 ce.IdEjecutivo from ClientesEjecutivos as ce inner join usuarios as u on u.idusuario = ce.IdEjecutivo where ce.idcliente = polizas.idcliente and ( IdRamo = (select top 1 idramo from productos where idproducto = polizas.idproducto ) or TipoProducto = (select top 1 TipoProducto from productos where idproducto = polizas.idproducto) or IdArea = 'POLIZAS')  order by orden), isnull((select c.EjecutivoCta from usuarios as u inner join clientes as c on c.EjecutivoCta =u.idusuario where c.idcliente = polizas.idcliente),''))) "
                sql &= " where Polizas.IdCliente = " & dbStr(txtIdCliente.Valor)
                StiGlobalConn.SQLExecute(sql)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClientesMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VistaDoc.OptionsBehavior.Editable = False

        Dim Permisos As New DataTable
        Permisos.Columns.Add("Id", System.Type.GetType("System.String"))
        Permisos.Columns.Add("Nombre", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = Permisos.NewRow : Fila("Id") = "S" : Fila("Nombre") = "Si" : Permisos.Rows.Add(Fila)
        Fila = Permisos.NewRow : Fila("Id") = "N" : Fila("Nombre") = "No" : Permisos.Rows.Add(Fila)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Nombre"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = Permisos
        RepositoryItemLookUpEdit1.PopulateColumns()


        Dim TA As DataTable
        TA = StiGlobalConn.ObtenerDataset("select IdAseguradora as Id, Nombre as [Descripción] from Aseguradoras").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = TA
        RepositoryItemLookUpEdit2.PopulateColumns()

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            txtFechaVinculacion.Valor = Date.Today
        End If

        'existen corredores que no manejan la figura de ejecutivos, si no hay ejecutivos no es obligatorio
        Dim NumEjecutivos As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Usuarios where EsEjecutivo = 'S'").Tables(0).Rows(0).Item(0)
        If NumEjecutivos = 0 Then
            Me.cboEjecutivoCta.Obligatorio = False
        End If

        Dim ClaveCliente As String = clSeguros.ObtenerDBParametros("Cliente.CmpEsp")
        If ClaveCliente.Trim.ToUpper = "CPCNCJ" Then
            Me.JCliNatural.PageVisible = True
            Me.KCliEmpresa.PageVisible = True
        End If



        Dim Ejecutivos As New DataTable
        Ejecutivos = StiGlobalConn.ObtenerDataset("select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo = 'S'").Tables(0)
        cboGridEjecutivo.ValueMember = "Id"
        cboGridEjecutivo.DisplayMember = "Nombre"
        cboGridEjecutivo.AutoSearchColumnIndex = 1
        cboGridEjecutivo.DataSource = Ejecutivos
        cboGridEjecutivo.PopulateColumns()
        cboGridEjecutivo.Columns("Id").Visible = False

        Dim Ramos As New DataTable
        Ramos = StiGlobalConn.ObtenerDataset("select IdRamo as Id, NombreRamo as Ramo from RamoSeguros order by NombreRamo").Tables(0)
        cboGridRamo.ValueMember = "Id"
        cboGridRamo.DisplayMember = "Ramo"
        cboGridRamo.AutoSearchColumnIndex = 1
        cboGridRamo.DataSource = Ramos
        cboGridRamo.PopulateColumns()
        cboGridRamo.Columns("Id").Visible = False


        Dim TipoProd As New DataTable
        TipoProd.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaT As DataRow
        FilaT = TipoProd.NewRow : FilaT("Tipo") = "DAÑOS" : TipoProd.Rows.Add(FilaT)
        FilaT = TipoProd.NewRow : FilaT("Tipo") = "VIDA" : TipoProd.Rows.Add(FilaT)

        cboGridTipoProducto.ValueMember = "Tipo"
        cboGridTipoProducto.DisplayMember = "Tipo"
        cboGridTipoProducto.AutoSearchColumnIndex = 1
        cboGridTipoProducto.DataSource = TipoProd
        cboGridTipoProducto.PopulateColumns()


        Dim TipoArea As New DataTable
        TipoArea.Columns.Add("Area", System.Type.GetType("System.String"))
        Dim FilaA As DataRow
        FilaA = TipoArea.NewRow : FilaA("Area") = "POLIZAS" : TipoArea.Rows.Add(FilaA)
        FilaA = TipoArea.NewRow : FilaA("Area") = "RECLAMOS" : TipoArea.Rows.Add(FilaA)

        cboGridArea.ValueMember = "Area"
        cboGridArea.DisplayMember = "Area"
        cboGridArea.AutoSearchColumnIndex = 1
        cboGridArea.DataSource = TipoArea
        cboGridArea.PopulateColumns()

        cboEstadoCliente.OcultarColumna(0)

        Call PrepararCampoPersonalizados()

    End Sub

    Private Sub PrepararCampoPersonalizados()
        Me.TabCliNatural.PageVisible = False
        Me.TabCliJuridica.PageVisible = False

        If Me.txtIdCliente.Text <> "" Then


            'campos persona Natural
            Dim Campo As String = "", Existe As Boolean = False
            Dim Campos As String = clSeguros.ObtenerDBParametros("Clientes.Natural.Campos")
            If Campos <> "" And (CStr(cboIdTipoCliente.Valor).Trim.ToUpper = "NA" Or cboIdTipoCliente.Text = "") Then
                For I As Integer = 0 To CuentaCar(Campos, ",")
                    Campo = Campos.Split(",")(I).Trim
                    If Campo <> "" Then
                        'verificamos si no existe
                        Existe = False
                        For J As Integer = 0 To Me.VistaDatosNat.DataRowCount - 1
                            If CStr(Me.VistaDatosNat.GetRowCellValue(J, "Nombre")).Trim.ToUpper = Campo.Trim.ToUpper Then
                                Existe = True : Exit For
                            End If
                        Next
                        If Existe = False Then
                            Dim Id As Integer = ObtenerIDCamposNat()
                            Me.AgregarFilaGrid(VistaDatosNat)
                            'ademos agregaremos el Id de contacto
                            Me.VistaDatosNat.SetRowCellValue(Me.VistaDatosNat.FocusedRowHandle, "IdCampo", Id)
                            Me.VistaDatosNat.SetRowCellValue(Me.VistaDatosNat.FocusedRowHandle, "Nombre", Campo)
                            Me.VistaDatosNat.UpdateCurrentRow()
                        End If
                    End If
                Next
                Me.TabCliNatural.PageVisible = True
            End If

            Campos = clSeguros.ObtenerDBParametros("Clientes.Juridico.Campos")
            If Campos <> "" And CStr(cboIdTipoCliente.Valor).Trim.ToUpper <> "NA" And cboIdTipoCliente.Text <> "" Then
                For I As Integer = 0 To CuentaCar(Campos, ",")
                    Campo = Campos.Split(",")(I).Trim
                    If Campo <> "" Then
                        'verificamos si no existe
                        Existe = False
                        For J As Integer = 0 To Me.VistaDatJuridica.DataRowCount - 1
                            If CStr(Me.VistaDatJuridica.GetRowCellValue(J, "Nombre")).Trim.ToUpper = Campo.Trim.ToUpper Then
                                Existe = True : Exit For
                            End If
                        Next
                        If Existe = False Then
                            Dim Id As Integer = ObtenerIDCamposJur()
                            Me.AgregarFilaGrid(VistaDatJuridica)
                            'ademos agregaremos el Id de contacto
                            Me.VistaDatJuridica.SetRowCellValue(Me.VistaDatJuridica.FocusedRowHandle, "IdCampo", Id)
                            Me.VistaDatJuridica.SetRowCellValue(Me.VistaDatJuridica.FocusedRowHandle, "Nombre", Campo)
                            Me.VistaDatJuridica.UpdateCurrentRow()
                        End If
                    End If
                Next
                Me.TabCliJuridica.PageVisible = True
            End If
        End If
    End Sub

    Private Function ObtenerIDCamposNat() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDatosNat.DataRowCount - 1
            Try
                If CInt(VistaDatosNat.GetRowCellValue(I, "IdCampo")) > Id Then
                    Id = CInt(VistaDatosNat.GetRowCellValue(I, "IdCampo"))
                End If
            Catch ex As Exception

            End Try
        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Function ObtenerIDCamposJur() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDatJuridica.DataRowCount - 1
            Try
                If CInt(VistaDatJuridica.GetRowCellValue(I, "IdCampo")) > Id Then
                    Id = CInt(VistaDatJuridica.GetRowCellValue(I, "IdCampo"))
                End If
            Catch ex As Exception

            End Try
        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            'Generaremos la impresion del estado de cuenta
            If Me.txtIdCliente.Text <> "" Then
                Try
                    Dim DtEstado As DataTable = Me.PivotEstado.DataSource
                    If DtEstado.Rows.Count = 0 Then
                        MsgBox("No hay Facturas pendientes para el estado de cuenta.", MsgBoxStyle.Information, "AVISO...")
                        Exit Sub
                    End If
                Catch ex As Exception

                End Try

                Dim TodasFact As String = ""
                If Me.chkTodasFactEstadoCuenta.Checked = True Then TodasFact = "S"
                Call ImprimirEstadoCuenta(txtIdCliente.Valor, "", txtLstFacturas.Text, "", "", Nothing, TodasFact, "", "", "", "")

            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        PrimasPendientesCargadas = False
        AvisosCobroCargados = False
        EstadoCuentaCargado = False
        DepositosCargados = False
        DetalleFacturasCargados = False
        PolizasCargadas = False
        txtFechaVinculacion.Valor = Date.Today
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        PrimasPendientesCargadas = False
        AvisosCobroCargados = False
        EstadoCuentaCargado = False
        DepositosCargados = False
        DetalleFacturasCargados = False
        PolizasCargadas = False
    End Sub

    Private Sub btnImpDetFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpDetFacturas.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\RepDetFacturas" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.gridDetFacturas.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte Detalle de Facturas", "Generación del Reporte: " & Me.STIConn.User & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "", clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub vistaDetFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles vistaDetFacturas.DoubleClick
        Try
            Dim FilaDF As Integer = vistaDetFacturas.FocusedRowHandle
            If FilaDF >= 0 Then
                'recopilamos los campos de la factura
                Dim NumeroFacturas As Integer = Me.vistaDetFacturas.GetRowCellValue(FilaDF, "NumeroFactura")
                Dim Poliza As String = Me.vistaDetFacturas.GetRowCellValue(FilaDF, "Poliza")
                Dim IdProducto As String = Me.vistaDetFacturas.GetRowCellValue(FilaDF, "IdProducto")
                Dim IdRamo As String = Me.vistaDetFacturas.GetRowCellValue(FilaDF, "IdRamo")

                Dim FAC As New PagosMan
                FAC.Permiso = Me.Permiso
                FAC.STIConn = StiGlobalConn
                FAC.dbTabla = "Facturas"
                FAC.dbCondicion = "NumeroFactura = " & dbInt(NumeroFacturas) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(Poliza) & " and IdRamo = " & dbStr(IdRamo)
                FAC.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaPolizas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPolizas.DoubleClick
        Try
            Dim FPol As Integer = VistaPolizas.FocusedRowHandle
            If FPol >= 0 Then
                Dim Poliza As String = Me.VistaPolizas.GetRowCellValue(FPol, "IdPoliza")
                Dim Producto As String = Me.VistaPolizas.GetRowCellValue(FPol, "IdProducto")

                Dim POL As New PolizasMan
                POL.Permiso = Me.Permiso
                POL.STIConn = StiGlobalConn
                POL.dbTabla = "Polizas"
                POL.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto)
                POL.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaCertificados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaCertificados.DoubleClick
        Try
            Dim FCert As Integer = VistaCertificados.FocusedRowHandle
            If FCert >= 0 Then
                Dim Poliza As String = Me.VistaCertificados.GetRowCellValue(FCert, "IdPoliza")
                Dim Producto As String = Me.VistaCertificados.GetRowCellValue(FCert, "IdProducto")
                Dim Certificado As String = Me.VistaCertificados.GetRowCellValue(FCert, "IdCertificado")

                Dim FCERTIF As New PolizasCertificadosMan
                FCERTIF.Permiso = Me.Permiso
                FCERTIF.STIConn = StiGlobalConn
                FCERTIF.dbTabla = "PolizasCertificados"
                FCERTIF.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto) & " and IdCertificado = " & dbStr(Certificado)
                FCERTIF.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaSiniestros_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaSiniestros.DoubleClick
        Try
            Dim Fsin As Integer = VistaSiniestros.FocusedRowHandle
            If Fsin >= 0 Then
                Dim Poliza As String = Me.VistaSiniestros.GetRowCellValue(Fsin, "IdPoliza")
                Dim Producto As String = Me.VistaSiniestros.GetRowCellValue(Fsin, "IdProducto")
                Dim Certificado As String = Me.VistaSiniestros.GetRowCellValue(Fsin, "IdCertificado")
                Dim Siniestro As String = Me.VistaSiniestros.GetRowCellValue(Fsin, "IdSiniestro")

                Dim FSiniestros As New SiniestrosMan
                FSiniestros.Permiso = Me.Permiso
                FSiniestros.STIConn = StiGlobalConn
                FSiniestros.dbTabla = "Siniestros"
                FSiniestros.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto) & " and IdCertificado = " & dbStr(Certificado) & " and IdSiniestro = " & dbStr(Siniestro)
                FSiniestros.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimirListaPolizas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirListaPolizas.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\RepPolizas" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridPolizas.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Lista de Pólizas de Clientes", "Pólizas del Cliente: " & Me.txtIdCliente.Valor & " / " & Me.txtNombreCliente.Valor, "Generación del Reporte: " & Me.STIConn.User & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnImprimirCertificados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirCertificados.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\RepCertificados" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridCertificados.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Lista de Certificados de Clientes", "Certificados del Cliente: " & Me.txtIdCliente.Valor & " / " & Me.txtNombreCliente.Valor, "Generación del Reporte: " & Me.STIConn.User & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnImprimirPrimasPend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPrimasPend.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\RepPrimasPendientes" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotFacturas.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte de Primas Pendientes Cliente", "Primas Pendientes del Cliente: " & Me.txtIdCliente.Valor & " / " & Me.txtNombreCliente.Valor, "Generación del Reporte: " & Me.STIConn.User & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub AgregarGestiónCarteraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarGestiónCarteraToolStripMenuItem.Click
        ''lo que haremos es ingresar una nueva gestión con la factura selecionada
        Try
            Dim fila As Integer = Me.vistaDetFacturas.FocusedRowHandle
            If fila >= 0 Then
                Dim frmGestion As New Gestiones
                frmGestion.TipoGestion = "C"

                frmGestion.IdCliente = ""
                frmGestion.IdPoliza = Me.vistaDetFacturas.GetRowCellValue(fila, "Poliza")
                frmGestion.IdProducto = Me.vistaDetFacturas.GetRowCellValue(fila, "IdProducto")
                frmGestion.IdSiniestro = ""
                frmGestion.NumeroFactura = Me.vistaDetFacturas.GetRowCellValue(fila, "NumeroFactura")

                frmGestion.dbTabla = "Gestiones"
                frmGestion.STIConn = StiGlobalConn
                frmGestion.Permiso = "T"

                frmGestion.ShowDialog()
            Else
                MsgBox("Debe seleccionar la factura a la que desea ingresarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConsultarGestiónDeCarteraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarGestiónDeCarteraToolStripMenuItem.Click
        Try
            Dim fila As Integer = Me.vistaDetFacturas.FocusedRowHandle
            If fila >= 0 Then
                Dim IdGestion As Integer = -1
                Try
                    IdGestion = StiGlobalConn.ObtenerDataset("select idgestion from gestiones where IdPoliza = " & dbStr(Me.vistaDetFacturas.GetRowCellValue(fila, "Poliza")) & " and IdProducto = " & dbStr(Me.vistaDetFacturas.GetRowCellValue(fila, "IdProducto")) & " and NumeroFactura = " & dbInt(Me.vistaDetFacturas.GetRowCellValue(fila, "NumeroFactura")) & " order by FechaProximaGestion desc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdGestion = -1
                End Try

                If IdGestion <> -1 Then
                    Dim frmGestion As New Gestiones
                    frmGestion.TipoGestion = "C"
                    frmGestion.IdCliente = ""
                    frmGestion.IdPoliza = Me.vistaDetFacturas.GetRowCellValue(fila, "Poliza")
                    frmGestion.IdProducto = Me.vistaDetFacturas.GetRowCellValue(fila, "IdProducto")
                    frmGestion.IdSiniestro = ""
                    frmGestion.NumeroFactura = Me.vistaDetFacturas.GetRowCellValue(fila, "NumeroFactura")
                    frmGestion.dbTabla = "Gestiones"
                    frmGestion.STIConn = StiGlobalConn
                    frmGestion.Permiso = "T"
                    frmGestion.dbCondicion = "IdGestion=" & dbInt(IdGestion)
                    frmGestion.ShowDialog()
                Else
                    MsgBox("La factura seleccionada no tiene gestión realizada.", MsgBoxStyle.Information, "AVISO...")
                End If
            Else
                MsgBox("Debe seleccionar la factura a la que desea consultarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimirNatural_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirNatural.Click
        Try
            Dim sql As String = ""

            If txtIdCliente.Text = "" Then
                MsgBox("Debe especificar el cliente.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim NomFiltro As String = ""

            sql = "  select * from Clientes"
            sql &= " where idcliente = " & dbStr(txtIdCliente.Valor)
            Dim dtCliente As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCliente.TableName = "ClientesEspecial"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtCliente.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repClienteNatural
            Reporte.SetDataSource(DsRep)
            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnImprimirJuridico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirJuridico.Click
        Try
            Dim sql As String = ""

            If txtIdCliente.Text = "" Then
                MsgBox("Debe especificar el cliente.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim NomFiltro As String = ""

            sql = "  select * from Clientes"
            sql &= " where idcliente = " & dbStr(txtIdCliente.Valor)
            Dim dtCliente As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCliente.TableName = "ClientesEspecial"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtCliente.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repClienteJuridico
            Reporte.SetDataSource(DsRep)
            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnAgregarEjecutivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEjecutivo.Click
        Try
            Dim Id As Integer = ObtenerIDEjecutivo()
            Me.AgregarFilaGrid(VistaEjecutivos)
            'ademos agregaremos el Id de contacto
            Me.VistaEjecutivos.SetRowCellValue(Me.VistaEjecutivos.FocusedRowHandle, "Orden", Id)
            Me.VistaEjecutivos.UpdateCurrentRow()

        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDEjecutivo() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaEjecutivos.DataRowCount - 1
            Try
                If CInt(VistaEjecutivos.GetRowCellValue(I, "Orden")) > Id Then
                    Id = CInt(VistaEjecutivos.GetRowCellValue(I, "Orden"))
                End If
            Catch ex As Exception

            End Try
        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnEliminarEjecutivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEjecutivo.Click
        Try
            Me.EliminarFilaGrid(VistaEjecutivos)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnDetalleFacturasEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleFacturasEstadoCuenta.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\RepDetEstado" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotEstado.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Listado de Facturas de Estado de Cuenta", "Estado de Cuenta del Cliente: " & Me.txtIdCliente.Valor & " / " & Me.txtNombreCliente.Valor, "Generación del Reporte: " & Me.STIConn.User & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.InitialDirectory = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                'si existe un parametro que indique la ruta global de los documentos validamos
                Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Clientes")
                Dim resRuta As String = ""
                If RutaBase <> "" And txtIdCliente.Text <> "" Then
                    RutaBase = RutaBase & "\" & txtIdCliente.Text & "\"
                    'creamos la carpeta si no existe
                    resRuta = CreaRuta(RutaBase)
                    If resRuta = "" Then
                        'movemos el archivo a la nueva carpeta
                        RutaBase &= System.IO.Path.GetFileName(Documento)
                        If System.IO.File.Exists(RutaBase) = False Then
                            System.IO.File.Copy(Documento, RutaBase)
                        Else
                            MsgBox("Ya existe un archivo con el mismo nombre en el repositorio de documentos de clientes.", MsgBoxStyle.Information, "AVISO...")
                            Exit Sub
                        End If
                        Documento = RutaBase
                    End If
                End If

                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Documento)
                Me.VistaDoc.SetRowCellValue(Fila, "Archivo", System.IO.Path.GetFileName(Documento))
                Me.VistaDoc.SetRowCellValue(Fila, "Directorio", Replace(System.IO.Path.GetDirectoryName(Documento), clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza"), ""))
                Me.VistaDoc.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDoc() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                If CInt(VistaDoc.GetRowCellValue(I, "IdDocumento")) > Id Then
                    Id = CInt(VistaDoc.GetRowCellValue(I, "IdDocumento"))
                End If
            Catch ex As Exception

            End Try

        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            FolderBrowserDialog1.SelectedPath = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            Dim Carpeta As String = ""
            FolderBrowserDialog1.ShowDialog()
            Carpeta = FolderBrowserDialog1.SelectedPath
            If Carpeta <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Carpeta)
                Me.VistaDoc.SetRowCellValue(Fila, "Archivo", System.IO.Path.GetFileName(Carpeta))
                Me.VistaDoc.SetRowCellValue(Fila, "Directorio", System.IO.Path.GetDirectoryName(Carpeta))
                Me.VistaDoc.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDoc.Click
        Try
            Me.EliminarFilaGrid(VistaDoc)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub CompletarNombreArchivos()
        Dim dtDoc As DataTable
        Me.blnCargandoRegistro = True
        ControlNotificacion.Caption = "Completando Nombres de Archivos" : Application.DoEvents()
        Try
            dtDoc = GridDoc.DataSource
            dtDoc.Columns.Add("Archivo", System.Type.GetType("System.String"))
            dtDoc.Columns.Add("Directorio", System.Type.GetType("System.String"))
            GridDoc.DataSource = dtDoc
        Catch ex As Exception

        End Try
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza")

        For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                Me.VistaDoc.SetRowCellValue(NA, "Archivo", System.IO.Path.GetFileName(VistaDoc.GetRowCellValue(NA, "Documento")))
                Me.VistaDoc.SetRowCellValue(NA, "Directorio", Replace(System.IO.Path.GetDirectoryName(VistaDoc.GetRowCellValue(NA, "Documento")), RutaBase, ""))
            Catch ex As Exception

            End Try
        Next
        Me.blnCargandoRegistro = False
        ControlNotificacion.Caption = "" : Application.DoEvents()
    End Sub

    Private Sub TabClientesInfo_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabClientesInfo.SelectedPageChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            If e.Page.Name.Trim.ToUpper = "TABCLIENTESDOCUMENTOS" Then
                If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
                    'cargamos documentos nuevos
                    Call IncluirDocumentosAutomaticos()
                End If
                Call CompletarNombreArchivos()
            End If
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub IncluirDocumentosAutomaticos()
        'rutina que incluye los documentos automaticos de una ruta.
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Clientes")
        Dim existe As Boolean
        If txtIdCliente.Text <> "" And RutaBase <> "" Then
            If System.IO.Directory.Exists(RutaBase & "\" & txtIdCliente.Text) = True Then
                ControlNotificacion.Caption = "Buscando Archivos Nuevos en Carpeta" : Application.DoEvents()
                Dim Archivos As DataTable = ObtenerArchivosCarpeta(RutaBase & "\" & txtIdCliente.Text)
                Dim FilArchivo As DataRow
                For Each FilArchivo In Archivos.Rows
                    'verificamos si ya existe
                    existe = False
                    For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If Trim(UCase(VistaDoc.GetRowCellValue(NA, "Documento"))) = Trim(UCase(dbData(FilArchivo, "Archivo"))) Then
                            existe = True
                        End If
                    Next
                    If existe = False Then
                        Dim Id As Integer = ObtenerIDDoc()
                        Me.AgregarFilaGrid(VistaDoc, True, False)
                        Dim Fila As Integer = VistaDoc.FocusedRowHandle
                        Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                        Me.VistaDoc.SetRowCellValue(Fila, "Documento", dbData(FilArchivo, "Archivo"))
                        Me.VistaDoc.SetRowCellValue(Fila, "Directorio", dbData(FilArchivo, "Carpeta"))
                        Me.VistaDoc.UpdateCurrentRow()
                    End If
                Next
            End If

            '17/01/2012
            'los documentos que ya no existen los removemos
            ControlNotificacion.Caption = "Borramos Archivos que ya no existen en Carpeta" : Application.DoEvents()
            Try
                Dim RutaArchivo As String = "", Atributos As System.IO.FileAttributes
INICIO_VALIDA:
                For NDO As Integer = 0 To VistaDoc.DataRowCount - 1
                    Try
                        RutaArchivo = VistaDoc.GetRowCellValue(NDO, "Documento")
                        If System.IO.Path.GetExtension(RutaArchivo) = "" Then
                            If System.IO.Directory.Exists(RutaArchivo) = False Then
                                VistaDoc.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            End If
                        Else
                            If System.IO.File.Exists(RutaArchivo) = False Then
                                VistaDoc.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            Else
                                ''verificamos que no sea un archivo oculto o del sistema
                                Atributos = System.IO.File.GetAttributes(RutaArchivo)
                                If (Atributos And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Or (Atributos And IO.FileAttributes.System) = IO.FileAttributes.System Then
                                    VistaDoc.DeleteRow(NDO)
                                    GoTo INICIO_VALIDA
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                Next

            Catch ex As Exception

            End Try
            ControlNotificacion.Caption = "" : Application.DoEvents()
        End If
    End Sub

    Private Sub VistaDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaDoc.DoubleClick
        Try
            Dim fila As Integer = VistaDoc.FocusedRowHandle
            If fila >= 0 Then
                Dim Doc As String = Me.VistaDoc.GetRowCellValue(fila, "Documento")
                If Doc <> "" Then
                    Dim esCarpeta As String = ""
                    Try
                        esCarpeta = System.IO.Path.GetExtension(Doc)
                    Catch ex As Exception
                        esCarpeta = ""
                    End Try
                    If esCarpeta = "" Then
                        System.Diagnostics.Process.Start(Doc)
                    Else
                        If System.IO.File.Exists(Doc) = True Then
                            ''Shell(Doc, AppWinStyle.NormalFocus)
                            System.Diagnostics.Process.Start(Doc)
                        Else
                            MsgBox("El documentos no se encuentra en la ruta especificada.", MsgBoxStyle.Information, "AVISO...")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cboIdTipoCliente_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdTipoCliente.ValueChangeOnExit
        Call PrepararCampoPersonalizados()
    End Sub

End Class
