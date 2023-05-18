Imports Utilerias.Genericas

Public Class RepPrimasPendientesClientes

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepPrimasPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Valor = Date.Today
        Me.cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivoCta.Llenar_Combo()
        Call ProcesarPermisosComision()

    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                ColComision.Visible = False
                ColComision.AllowedAreas = 0
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Primas Pendientes" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotFacturas.ExportToXls(Archivo, Opciones)

            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

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
            sql &= " , f.FechaPago as FechaPago"
            sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
            sql &= " , DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") as Dias"
            sql &= " , case "
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") > 150 then '6) Más de 150'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") <= 30 then '1) de 0 - 30 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") > 30 and DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") <= 60 then '2) de 30 - 60 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") > 60 and DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") <= 90 then '3) de 60 - 90 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") > 90 and DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") <= 120 then '4) de 90 - 120 días'"
            sql &= " when DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") > 120 and DateDiff(d,f.FechaPago," & dbFec(txtFecha.Valor) & ") <= 150 then '5) de 120 - 150 días'"
            sql &= " end as RangoMora "
            sql &= " , isnull((select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFecha.Valor) & "),0) as PrimaNeta"
            sql &= " , (select sum(isnull(GastosEmision,0) + isnull(GastosFracciona,0) + isnull(GastosBomberos,0) + isnull(Gastos,0)) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFecha.Valor) & ") as Gastos"
            sql &= " , isnull((select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFecha.Valor) & "),0) as Impuestos"
            sql &= " , isnull((select sum(RetencionImpuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFecha.Valor) & "),0) as RetencionImpuestos"
            sql &= " , isnull((select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFecha.Valor) & "),0) as Total"
            sql &= " , isnull((select sum(Comision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(txtFecha.Valor) & "),0) as Comision"
            sql &= ", c.LugarTrabajo, c.Fax, c.Email, f.Referencia, f.Observaciones"
            sql &= ", (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
            sql &= ", (select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Direccion"
            sql &= ", (select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Ciudad"
            sql &= ", case "
            sql &= " when (select count(*) from Gestiones as g where g.TipoGestion = 'C' and g.NumeroFactura = f.NumeroFactura and g.IdProducto = f.IdProducto and g.IdPoliza = f.IdPoliza) > 0 then 'SI'"
            sql &= " else 'NO'"
            sql &= " end as Gestion"
            sql &= ", isnull((select top 1 ac.NumeroTarjeta from AvisosCobro as ac inner join AvisosCobroFacturas as af on ac.IdAvisoCobro = af.IdAvisoCobro where af.IdPoliza = f.IdPoliza and af.IdProducto = f.IdProducto and af.NumeroFactura = f.NumeroFactura and af.IdRamo = f.IdRamo order by ac.VigenciaDesde desc ),'') as TarjetaCredito"
            sql &= ", p.IdProducto"
            sql &= ", case c.idtipocliente when 'NA' then 'Individuales' when 'JU' then 'Empresas' when 'GU' then 'Instituciones' when 'GA' then 'Instituciones' when 'JE' then 'Empresas' else '' end as TipoCliente"
            sql &= ", isnull((select top 1 g.Comentarios from Gestiones as g where g.NumeroFactura = f.NumeroFactura and g.IdProducto = f.IdProducto and g.IdPoliza = f.IdPoliza and g.TipoGestion = 'C' order by g.FechaGestion desc),'') as UltimaGestion"
            sql &= ", isnull((select top 1 ac.IdAvisoCobro from AvisosCobroFacturas as ac where ac.IdPoliza = f.IdPoliza and ac.IdProducto = f.IdProducto and ac.NumeroFactura = f.NumeroFactura and ac.IdRamo = f.IdRamo),'') as IdAC"
            sql &= ", isnull((select top 1 v.NombreVendedor from PolizasVendedores as pv inner join Vendedores as v on pv.IdVendedor = v.IdVendedor where pv.IdPoliza = f.IdPoliza and pv.IdProducto = f.IdProducto order by Orden asc),'') as Vendedor"
            sql &= ", isnull(c.GrupoCliente,'') as GrupoCliente"
            sql &= ", isnull((select top 1 fp.Descripcion from FormasPago as fp where fp.IdFormaPago = t.IdFormaPago ),'')  as FormaPago"
            sql &= ", isnull((select top 1 Descripcion from FormasPagoTipo as tp where tp.IdTipoPago = isnull(t.IdTipoPago, c.IdTipoPago)),'') as TipoPago"
            sql &= " from facturas as f "
            sql &= " left join Productos as p on f.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " left join Clientes as c on c.idcliente = f.idcliente"
            sql &= " left join Polizas as t on t.idpoliza = f.idpoliza and t.idproducto = f.idproducto"
            sql &= " where "
            'que la fecha de pago sea menor a la fecha de corte
            sql &= " f.FechaPago <= " & dbFec(txtFecha.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            'que tengan saldo positivo
            sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(txtFecha.Valor) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))

            If Me.cboEjecutivoCta.Text <> "" Then
                sql &= " and c.EjecutivoCta = " & dbStr(cboEjecutivoCta.Valor)
            End If

            '28/01/11 no incluiremos cobros que no se les hace gestion
            If Me.chkGestionEspecial.Checked = False Then
                sql &= " and f.GestionEspecial is null "
            End If

            If txtCliente.Text.Trim <> "" Then
                Dim NumPalabras As Integer = CuentaCar(txtCliente.Text.Trim, " "), Palabra As String
                For NP As Integer = 0 To NumPalabras
                    Palabra = stiSplit(txtCliente.Text.Trim, "G" & NP & " 1").Trim
                    If Palabra <> "" Then
                        sql &= " and  f.NombreCliente like " & dbStr("%" & Palabra & "%")
                    End If
                Next
            End If


            Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
            PivotFacturas.DataSource = dsDatos.Tables(0)
            PivotFacturas.Refresh()

            If dsDatos.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron primas pendientes para la fecha de corte especificada.", MsgBoxStyle.Information, "AVISO..")
            End If
            lblLog.Text = "Número de Registros: " & dsDatos.Tables(0).Rows.Count

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Dim PosX As Integer, PosY As Integer

    Private Sub PivotFacturas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PivotFacturas.MouseMove
        PosX = e.X : PosY = e.Y
    End Sub

    Private Sub PivotFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PivotFacturas.DoubleClick
        'lo que haremos es lanzar las gestiones
        Try
            Dim IdPoliza As String = "", IdProducto As String = "", Factura As String = "", Gestion As String = ""
            Dim info As DevExpress.XtraPivotGrid.PivotGridHitInfo = PivotFacturas.CalcHitInfo(New Point(PosX, PosY))
            If Not info Is Nothing Then
                'primero intentamos como un campo data
                Try
                    Select Case info.CellInfo.DataField.FieldName
                        Case "Gestion"
                            Gestion = info.CellInfo.GetFieldValue(colGestion)
                            IdPoliza = info.CellInfo.GetFieldValue(ColPoliza)
                            IdProducto = info.CellInfo.GetFieldValue(colIdProducto)
                            Factura = info.CellInfo.GetFieldValue(ColNumFactura)
                            
                    End Select
                Catch ex As Exception
                    Gestion = ""
                End Try

                'sino intentamo como campo agrupado
                If Gestion = "" Then
                    Try
                        Select Case info.ValueInfo.Field.FieldName
                            Case "Gestion"
                                Gestion = CStr(info.ValueInfo.Value).Trim
                                Dim Datos As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = info.ValueInfo.CreateDrillDownDataSource

                                IdPoliza = Datos(0).Item("Poliza")
                                IdProducto = Datos(0).Item("IdProducto")
                                Factura = Datos(0).Item("NumeroFactura")
                        End Select
                    Catch ex As Exception
                        Gestion = ""
                    End Try
                End If

                If Gestion.Trim.ToUpper = "SI" Then
                    If IdPoliza <> "" And IdProducto <> "" And Factura <> "" Then
                        Call ConsultarGestiones(IdPoliza, IdProducto, Factura)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConsultarGestiones(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal Factura As String)
        Try

            Dim IdGestion As Integer = -1
            Try
                IdGestion = StiGlobalConn.ObtenerDataset("select idgestion from gestiones where IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and NumeroFactura = " & dbInt(Factura) & " order by FechaProximaGestion desc").Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                IdGestion = -1
            End Try

            If IdGestion <> -1 Then
                Dim frmGestion As New Gestiones
                frmGestion.TipoGestion = "C"
                frmGestion.IdCliente = ""
                frmGestion.IdPoliza = IdPoliza
                frmGestion.IdProducto = IdProducto
                frmGestion.IdSiniestro = ""
                frmGestion.NumeroFactura = Factura
                frmGestion.dbTabla = "Gestiones"
                frmGestion.STIConn = StiGlobalConn
                frmGestion.Permiso = "T"
                frmGestion.dbCondicion = "IdGestion=" & dbInt(IdGestion)
                frmGestion.ShowDialog()
            Else
                MsgBox("La factura seleccionada no tiene gestión realizada.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub


    End Class
