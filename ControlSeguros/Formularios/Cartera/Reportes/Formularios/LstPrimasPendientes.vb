Imports Utilerias.Genericas

Public Class LstPrimasPendientes

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            'buscaremos las primas pendientes a la fecha de corte especificada
            Dim sql As String = ""
            Me.Cursor = Cursors.WaitCursor

            sql = "  select f.NumeroFactura as NumeroFactura"
            sql &= " , p.IdProducto"
            sql &= " , p.Descripcion as Producto"
            sql &= " , r.NombreRamo as Ramo"
            sql &= " , p.TipoProducto as TipoSeguro"
            sql &= " , a.Nombre as Aseguradora"
            sql &= " , f.IdPoliza as Poliza"
            sql &= " , f.TipoFactura as TipoFactura"
            sql &= " , f.IdCliente"
            sql &= " , f.IdRamo"
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
            sql &= ", (select count(*) from gestiones as g where g.IdProducto = p.IdProducto and g.NumeroFactura = f.NumeroFactura and g.IdPoliza = f.IdPoliza and g.TipoGestion = 'C' and g.FechaProximaGestion <= " & dbFec(Date.Today) & ") as GestionPendiente"
            sql &= ", (select count(*) from gestiones as g where g.IdProducto = p.IdProducto and g.NumeroFactura = f.NumeroFactura and g.IdPoliza = f.IdPoliza and g.TipoGestion = 'C' and g.FechaProximaGestion > " & dbFec(Date.Today) & ") as GestionTramite"
            sql &= ", isnull(c.LugarTrabajo,'') as LugarTrabajo, isnull(c.Fax,'') as Fax, isnull(c.Email,'') as Email, isnull(f.Referencia,'') as Referencia, isnull(f.Observaciones,'') as Observaciones"
            sql &= ", (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Telefono"
            sql &= ", (select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Direccion"
            sql &= ", (select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Ciudad"
            sql &= ", isnull((select top 1 NombreUsuario from Usuarios where IdUsuario = c.EjecutivoCta),'') as Ejecutivo"
            sql &= ", isnull((select top 1 isnull(replicate('*',DATALENGTH(ac.NumeroTarjeta)-4),'') + isnull(right(ac.NumeroTarjeta,4),'') from AvisosCobro as ac inner join AvisosCobroFacturas as acf on acf.IdAvisoCobro = ac.IdAvisoCobro where acf.IdPoliza = f.idpoliza and acf.IdProducto = f.IdProducto and acf.NumeroFactura = f.NumeroFactura and acf.IdRamo = f.IdRamo),'') as Tarjeta"
            sql &= ", isnull((select top 1 isnull(ac.VencimientoTarjeta,'') from AvisosCobro as ac inner join AvisosCobroFacturas as acf on acf.IdAvisoCobro = ac.IdAvisoCobro where acf.IdPoliza = f.idpoliza and acf.IdProducto = f.IdProducto and acf.NumeroFactura = f.NumeroFactura and acf.IdRamo = f.IdRamo),'') as VenceTarjeta"
            sql &= ", VencimientoTardio "
            'verificaremos si hay flujo de cobro para la factura
            sql &= ", case  when (select count(*) from FlujosDocumentos as fl where fl.IdFlujo = " & dbStr(clSeguros.ObtenerDBParametros("Flujo.Cartera.Cobro")) & " and fl.IdPoliza = f.IdPoliza and fl.IdProducto = f.IdProducto and fl.NumeroFactura = f.NumeroFactura and fl.IdRamo = f.IdRamo) > 0 then 'SI: ' + isnull(f.DocumentoFiscal,'') else '' end as DocFiscalEnv"
            sql &= ", isnull(c.GrupoCliente,'') as GrupoCliente"
            sql &= ", isnull((select top 1 isnull(v.NombreVendedor,'') from PolizasVendedores as pv inner join Vendedores as v on pv.IdVendedor = v.IdVendedor where pv.IdProducto = f.IdProducto and pv.IdPoliza = f.IdPoliza and pv.Orden = 1),'') as Vendedor"

            sql &= " from facturas as f "
            sql &= " left join Productos as p on f.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
            sql &= " left join Clientes as c on c.idcliente = f.idcliente"
            sql &= " where "
            'que la fecha de pago sea menor a la fecha de corte
            sql &= " f.FechaPago <= " & dbFec(txtFecha.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            'que tengan saldo positivo
            sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(txtFecha.Valor) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
            If cboEjecutivoCta.Text <> "" Then
                sql &= " and c.EjecutivoCta = " & dbStr(Me.cboEjecutivoCta.Valor)
            End If

            '28/01/11 no incluiremos cobros que no se les hace gestion
            If chkGestionEspecial.Checked = False Then
                sql &= " and f.GestionEspecial is null "
            End If

            Dim dsDatos As DataSet = StiGlobalConn.ObtenerDataset(sql)
            GridPrimas.DataSource = dsDatos.Tables(0)
            GridPrimas.Refresh()

            If dsDatos.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron primas pendientes para la fecha de corte especificada.", MsgBoxStyle.Information, "AVISO..")
                lblLog.Text = ""
            Else
                lblLog.Text = "Núm. Facturas: " & Format(dsDatos.Tables(0).Rows.Count, "#,###0")
            End If

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub LstPrimasPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                colComision.Visible = False
                colComision.OptionsColumn.AllowShowHide = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub AgregarGestiónDeCarteraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarGestiónDeCarteraToolStripMenuItem.Click
        ''lo que haremos es ingresar una nueva gestión con la factura selecionada
        Try
            Dim fila As Integer = Me.GridView1.FocusedRowHandle
            If fila >= 0 Then
                Dim frmGestion As New Gestiones
                frmGestion.TipoGestion = "C"

                frmGestion.IdCliente = ""
                frmGestion.IdPoliza = Me.GridView1.GetRowCellValue(fila, "Poliza")
                frmGestion.IdProducto = Me.GridView1.GetRowCellValue(fila, "IdProducto")
                frmGestion.IdSiniestro = ""
                frmGestion.NumeroFactura = Me.GridView1.GetRowCellValue(fila, "NumeroFactura")

                frmGestion.dbTabla = "Gestiones"
                frmGestion.STIConn = StiGlobalConn
                frmGestion.Permiso = "T"

                frmGestion.ShowDialog()

                'ahora lo que haremos es actualizar el estatus de gestion de la fila afectada (colores)
                Dim Pen As Integer = 0, Tra As Integer = 0
                Try
                    Pen = StiGlobalConn.ObtenerDataset("select count(*) from gestiones as g where g.IdProducto = " & dbStr(Me.GridView1.GetRowCellValue(fila, "IdProducto")) & " and g.NumeroFactura = " & dbNum(Me.GridView1.GetRowCellValue(fila, "NumeroFactura")) & " and g.IdPoliza = " & dbStr(Me.GridView1.GetRowCellValue(fila, "Poliza")) & " and g.tipogestion = 'C' and g.FechaProximaGestion <= " & dbFec(Date.Today)).Tables(0).Rows(0).Item(0)
                    Tra = StiGlobalConn.ObtenerDataset("select count(*) from gestiones as g where g.IdProducto = " & dbStr(Me.GridView1.GetRowCellValue(fila, "IdProducto")) & " and g.NumeroFactura = " & dbNum(Me.GridView1.GetRowCellValue(fila, "NumeroFactura")) & " and g.IdPoliza = " & dbStr(Me.GridView1.GetRowCellValue(fila, "Poliza")) & " and g.tipogestion = 'C' and g.FechaProximaGestion > " & dbFec(Date.Today)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Pen = 0
                    Tra = 0
                End Try
                Me.GridView1.SetRowCellValue(fila, "GestionPendiente", Pen)
                Me.GridView1.SetRowCellValue(fila, "GestionTramite", Tra)

            Else
                MsgBox("Debe seleccionar la factura a la que desea ingresarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConsultarGestiónDeCarteraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarGestiónDeCarteraToolStripMenuItem.Click
        Try
            Dim fila As Integer = Me.GridView1.FocusedRowHandle
            If fila >= 0 Then


                Dim IdGestion As Integer = -1
                Try
                    IdGestion = StiGlobalConn.ObtenerDataset("select idgestion from gestiones where IdPoliza = " & dbStr(Me.GridView1.GetRowCellValue(fila, "Poliza")) & " and IdProducto = " & dbStr(Me.GridView1.GetRowCellValue(fila, "IdProducto")) & " and NumeroFactura = " & dbInt(Me.GridView1.GetRowCellValue(fila, "NumeroFactura")) & " order by FechaProximaGestion desc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdGestion = -1
                End Try

                If IdGestion <> -1 Then
                    Dim frmGestion As New Gestiones
                    frmGestion.TipoGestion = "C"
                    frmGestion.IdCliente = ""
                    frmGestion.IdPoliza = Me.GridView1.GetRowCellValue(fila, "Poliza")
                    frmGestion.IdProducto = Me.GridView1.GetRowCellValue(fila, "IdProducto")
                    frmGestion.IdSiniestro = ""
                    frmGestion.NumeroFactura = Me.GridView1.GetRowCellValue(fila, "NumeroFactura")
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

    Private Sub EnviarEstadoDeCuentaPorCorreoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarEstadoDeCuentaPorCorreoToolStripMenuItem.Click
        Try
            Dim fila As Integer = Me.GridView1.FocusedRowHandle
            If fila >= 0 Then
                Dim Email As String = Me.GridView1.GetRowCellValue(fila, "Email")
                Dim IdCliente As String = Me.GridView1.GetRowCellValue(fila, "IdCliente")
                If IdCliente <> "" Then
                    Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\EstadoCuenta.pdf"
                    Try
                        System.IO.File.Delete(Archivo)
                    Catch ex As Exception

                    End Try
                    Call ImprimirEstadoCuenta(IdCliente, "", "", "", Archivo, CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "", "", "", "", "")

                    'Preparamos el correo
                    PrepararCorreoOutlook(Email, "Estado de Cuenta de Seguros", "", Archivo)
                End If
            Else
                MsgBox("Debe seleccionar la factura para determinar el cliente al que se le preparará el estado de cuenta.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Gestion PP " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridView1.ExportToXls(Archivo, Opciones)

            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        Try
            Dim fila As Integer = Me.GridView1.FocusedRowHandle
            If fila >= 0 Then
                'lo que haremos es lanzar el formulario de edición de facturas en modo consulta
                Dim FrmFact As New PagosMan
                FrmFact.dbTabla = "Facturas"
                FrmFact.STIConn = StiGlobalConn
                FrmFact.Permiso = "L"
                FrmFact.dbCondicion = "NumeroFactura = " & dbInt(Me.GridView1.GetRowCellValue(fila, "NumeroFactura")) & " and IdProducto = " & dbStr(Me.GridView1.GetRowCellValue(fila, "IdProducto")) & " and IdPoliza = " & dbStr(Me.GridView1.GetRowCellValue(fila, "Poliza")) & " and IdRamo = " & dbStr(Me.GridView1.GetRowCellValue(fila, "IdRamo"))
                FrmFact.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class
