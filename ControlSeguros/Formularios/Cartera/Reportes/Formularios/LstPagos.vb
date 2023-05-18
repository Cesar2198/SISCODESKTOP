Imports Utilerias.Genericas

Public Class LstPagos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LstPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
            txtFechaHasta.Valor = Date.Today
        Catch ex As Exception

        End Try
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()

        Me.cboVendedor.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboVendedor.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            If txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha desde.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha hasta.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            sql = "  select "
            sql &= "f.NumeroFactura as NumeroFactura"
            sql &= ",p.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",p.TipoProducto as TipoSeguro"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.TipoFactura as TipoFactura"
            sql &= ",f.NombreCliente as NombreCliente"
            sql &= ",m.FechaMovimiento as FechaPago"
            sql &= ",replace(convert(varchar,m.FechaGrabacion,106),' ','/') + ' ' + convert(varchar,m.FechaGrabacion,114) as FechaAplicaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ", 0 as Dias"
            sql &= ",m.PrimaNeta * -1 as PrimaNeta"
            sql &= ",(isnull(m.GastosEmision,0) + isnull(m.GastosFracciona,0) + isnull(m.GastosBomberos,0) + isnull(m.Gastos,0)) * -1 as Gastos"
            sql &= ",m.Impuestos * -1 as Impuestos"
            sql &= ",m.Total * -1 as Total"
            sql &= ",m.Comision * -1 as Comision"
            sql &= ",isnull(m.UsuarioGrabacion,'') as Usuario"
            sql &= ",isnull(m.MotivoAnulacion,'PAGO') as Motivo"
            sql &= ",(select top 1 isnull(cc.Direccion,'') + ' ' + isnull(cc.ciudad,'')  from ClientesContactos as cc where cc.IdCliente = f.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Direccion"
            sql &= ", cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
            sql &= ", f.DocumentoFiscal "
            sql &= ", isnull((select top 1 rf.IdRecibo from RecibosFacturas as rf where rf.NumeroFactura = f.NumeroFactura and rf.IdProducto = f.IdProducto and rf.IdPoliza = f.IdPoliza and rf.IdRamo = f.IdRamo) ,'') as ReciboCaja"
            sql &= ", isnull((select top 1 convert(varchar, g.FechaGestion,103) + ':' + tg.NombreGestion + ' = ' + g.Comentarios from Gestiones as g left join TipoGestion as tg on tg.IdTipoGestion = g.IdTipoGestion where g.NumeroFactura = f.NumeroFactura and g.IdProducto = f.IdProducto and g.IdPoliza = f.idpoliza order by FechaGestion desc ),'') as Gestion"
            sql &= ", isnull((select NombreVendedor + ', '  from PolizasVendedores as ven inner join Vendedores as ve on ve.idvendedor = ven.idvendedor  where ven.IdPoliza = f.IdPoliza and ven.IdProducto = f.IdProducto for xml path('') ),'')  as Vendedor"

            sql &= " from Facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo"
            sql &= " left join Productos as p on p.idproducto = f.idproducto"
            sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " where f.NumeroFactura is not null"
            sql &= " and m.TipoMovimiento = 'PAGO'"
            sql &= " and m.FechaMovimiento between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            If txtPoliza.Text <> "" Then
                sql &= " and f.IdPoliza like " & dbStr("%" & txtPoliza.Valor & "%")
            End If
            If cboProducto.Text <> "" Then
                sql &= " and f.IdProducto =" & dbStr(cboProducto.Valor)
            End If
            If txtIdCliente.Text <> "" Then
                sql &= " and f.IdCliente =" & dbStr(txtIdCliente.Valor)
            End If

            If chkConGestion.Checked = True Then
                sql &= " and (select count(*) from Gestiones as g where g.NumeroFactura = f.NumeroFactura and g.IdProducto = f.IdProducto and g.IdPoliza = f.idpoliza ) > 0 "
            End If

            If cboVendedor.Valor <> "" Then
                sql &= " and (select count(*) from PolizasVendedores as ven where ven.IdPoliza = f.IdPoliza and ven.IdProducto = f.IdProducto and ven.Orden = 1 and ven.IdVendedor = " & dbStr(cboVendedor.Valor) & ") > 0 "
            End If


            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Primas"

            If dtPagos.Rows.Count = 0 Then
                MsgBox("No se han encontrado pagos con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As Object
            Reporte = New repMovimientosFacturas
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Pagos.Emitidos")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Reporte de Pagos Registrados")
            SetRepFormulaString(Reporte, "Titulo2", "Pagos entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
            SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.lblCliente.Text = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
        Else
            Me.txtIdCliente.Valor = ""
            Me.lblCliente.Text = ""
        End If
    End Sub

End Class
