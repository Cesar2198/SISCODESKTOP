Imports Utilerias.Genericas

Public Class LstGestionesPolizas

    Private Sub LstGestionesPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Valor = Date.Today
        Me.cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivoCta.Llenar_Combo()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Gestion Pólizas " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaPolizas.ExportToXls(Archivo, Opciones)

            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If optPolizas.Checked = True Then
            Call ObtenerPolizas()
        End If
        If optOfertas.Checked = True Then
            Call ObtenerOfertas()
        End If
    End Sub

    Private Sub ObtenerPolizas()
        Try
            colPoliza.Caption = "Póliza"
            Dim sql As String = ""
            sql = "  select "
            sql &= " p.idpoliza as IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.NombreCliente as Cliente"
            sql &= " ,p.VigenciaDesde as VigenciaDesde"
            sql &= " ,p.VigenciaHasta as VigenciaHasta"
            sql &= " ,isnull((select sum(c.ValorAsegurado) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.EstadoCertificado = 'VIGENTE'),0) as SumaAsegurada"
            sql &= " ,isnull((select sum(c.PrimaNeta) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.EstadoCertificado = 'VIGENTE'),0) as PrimaNeta"
            sql &= " ,p.NumVigencia as NumVigencia"
            sql &= " ,p.EstadoPoliza as EstadoPoliza"
            sql &= " ,(select isnull(v.NombreVendedor,'') from PolizasVendedores as pv inner join Vendedores as v on pv.IdVendedor = v.IdVendedor where pv.IdProducto = p.IdProducto and pv.IdPoliza = p.IdPoliza and pv.Orden = 1) as Vendedor"
            sql &= " ,p.Idproducto as IdProducto"
            sql &= ", isnull(c.Fax,'') as Fax"
            sql &= ", c.Email as EMail"
            sql &= ", (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Telefono"
            sql &= ", (select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Direccion"
            sql &= ", (select count(*) from gestiones as g where g.IdProducto = p.IdProducto and g.IdPoliza = p.IdPoliza and TipoGestion = 'P' and g.FechaProximaGestion <= " & dbFec(Date.Today) & ") as GestionPendiente"
            sql &= ", (select count(*) from gestiones as g where g.IdProducto = p.IdProducto and g.IdPoliza = p.IdPoliza and TipoGestion = 'P' and g.FechaProximaGestion > " & dbFec(Date.Today) & ") as GestionTramite"
            sql &= ", p.IdCliente, pr.IdProducto, s.NombreRamo as IdRamo,null as  ResumenPlan, null as Cuotas"
            sql &= ", isnull((select top 1 g.Comentarios from Gestiones as g where g.IdProducto = p.IdProducto and g.IdPoliza = p.IdPoliza and g.TipoGestion = 'P' order by g.FechaGestion desc),'') as UltimaGestion"

            sql &= " from Polizas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"
            sql &= " left join RamoSeguros as s on s.idRamo = pr.idRamo"
            sql &= " where p.VigenciaDesde <= " & dbFec(txtFecha.Valor)

            If txtDesde.Text <> "" Then
                sql &= " and p.VigenciaDesde >= " & dbFec(txtDesde.Valor)
            End If

            If cboEjecutivoCta.Text <> "" Then
                sql &= " and isnull(p.EjecutivoCta, isnull((select top 1 ce.IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = p.idcliente and ( IdRamo = (select top 1 d.idramo from productos as d where d.idproducto = p.idproducto ) or TipoProducto = (select top 1 d.TipoProducto from productos as d where d.idproducto = p.idproducto) or IdArea = 'POLIZAS')  order by orden) , isnull((select cl.EjecutivoCta from clientes as cl where cl.idcliente = p.idcliente),'')))  = " & dbStr(cboEjecutivoCta.Valor)
            End If

            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            Dim dtPol As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtPol.Rows.Count = 0 Then
                MsgBox("No se encontraron pólizas con las condiciones dadas.", MsgBoxStyle.Exclamation, "AVISO...")
                GridPolizas.DataSource = Nothing
                GridPolizas.Refresh()
                Exit Sub
            End If
            GridPolizas.DataSource = dtPol
            GridPolizas.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub ObtenerOfertas()
        Try
            colPoliza.Caption = "No.Oferta"
            Dim sql As String = ""
            sql = "  select "
            sql &= " p.idpoliza as IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.NombreCliente as Cliente"
            sql &= " ,p.VigenciaDesde as VigenciaDesde"
            sql &= " ,p.VigenciaHasta as VigenciaHasta"
            sql &= " ,isnull((select sum(c.ValorAsegurado) from CPolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto ),p.ResumenSumaAsegurada) as SumaAsegurada"
            sql &= " ,isnull((select sum(c.PrimaNeta) from CPolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto),p.ResumenPrimaAnual) as PrimaNeta"
            sql &= " ,p.NumVigencia as NumVigencia"
            sql &= " ,p.EstadoPoliza as EstadoPoliza"
            sql &= " ,v.NombreVendedor as Vendedor"
            sql &= " ,p.Idproducto as IdProducto"
            sql &= ", isnull(c.Fax,'') as Fax"
            sql &= ", c.Email as EMail"
            sql &= ", (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Telefono"
            sql &= ", (select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Direccion"
            sql &= ", (select count(*) from gestiones as g where g.IdProducto = p.IdProducto and g.IdPoliza = p.IdPoliza and g.TipoGestion = 'P' and g.FechaProximaGestion <= " & dbFec(Date.Today) & ") as GestionPendiente"
            sql &= ", (select count(*) from gestiones as g where g.IdProducto = p.IdProducto and g.IdPoliza = p.IdPoliza and g.TipoGestion = 'P' and g.FechaProximaGestion > " & dbFec(Date.Today) & ") as GestionTramite"
            sql &= ", p.IdCliente, pr.IdProducto, s.NombreRamo as IdRamo, p.ResumenPlan , p.ResumenNumeroCuotas as Cuotas"
            sql &= ", isnull((select top 1 g.Comentarios from Gestiones as g where g.IdProducto = p.IdProducto and g.IdPoliza = p.IdPoliza and g.TipoGestion = 'P' order by g.FechaGestion desc),'') as UltimaGestion"

            sql &= " from cPolizas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Vendedores as v on v.idvendedor = p.idvendedor"
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"
            sql &= " left join RamoSeguros as s on s.idRamo = pr.idRamo"
            sql &= " where p.VigenciaDesde <= " & dbFec(txtFecha.Valor)
            If txtDesde.Text <> "" Then
                sql &= " and p.VigenciaDesde >= " & dbFec(txtDesde.Valor)
            End If

            sql &= " and p.EstadoPoliza in ('ENTRAMITE','PENDIENTE','ACEPTADA') "
            If cboEjecutivoCta.Text <> "" Then
                sql &= " and isnull(p.EjecutivoCta, isnull((select top 1 ce.IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = p.idcliente and ( IdRamo = (select top 1 d.idramo from productos as d where d.idproducto = p.idproducto ) or TipoProducto = (select top 1 d.TipoProducto from productos as d where d.idproducto = p.idproducto) or IdArea = 'POLIZAS')  order by orden) , isnull((select cl.EjecutivoCta from clientes as cl where cl.idcliente = p.idcliente),'')))  = " & dbStr(cboEjecutivoCta.Valor)
            End If
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            sql &= "  union "

            sql &= "  select "
            sql &= " p.IdComparativo as IdPoliza"
            sql &= " ,'' as Producto"
            sql &= " ,'' as Aseguradora"
            sql &= " ,p.NombreCliente as Cliente"
            sql &= " ,p.FechaOferta as VigenciaDesde"
            sql &= " ,NULL as VigenciaHasta"
            sql &= " ,0 as SumaAsegurada"
            sql &= " ,0 as PrimaNeta"
            sql &= " ,1 as NumVigencia"
            sql &= " ,p.EstadoOferta as EstadoPoliza"
            sql &= " ,'' as Vendedor"
            sql &= " ,'' as IdProducto"
            sql &= ", isnull(c.Fax,'') as Fax"
            sql &= ", c.Email as EMail"
            sql &= ", (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Telefono"
            sql &= ", (select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc) as Direccion"
            sql &= ", 0 as GestionPendiente"
            sql &= ", 0 as GestionTramite"
            sql &= ", '' as IdCliente, '' as IdProducto, '' as IdRamo, '' as ResumenPlan, null as Cuotas"
            sql &= ", '' as UltimaGestion"

            sql &= " from OfertasComparativo as p"
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"
            sql &= " where p.FechaOferta <= " & dbFec(txtFecha.Valor)
            If txtDesde.Text <> "" Then
                sql &= " and p.FechaOferta >= " & dbFec(txtDesde.Valor)
            End If
            sql &= " and p.EstadoOferta in ('ENTRAMITE','PENDIENTE','ACEPTADA') "
            If cboEjecutivoCta.Text <> "" Then
                sql &= " and isnull(p.EjecutivoCta, isnull((select top 1 ce.IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = p.idcliente and ( ce.IdRamo = p.IdRamo or IdArea = 'POLIZAS')  order by orden) , isnull((select cl.EjecutivoCta from clientes as cl where cl.idcliente = p.idcliente),'')))  = " & dbStr(cboEjecutivoCta.Valor)
            End If

            Dim dtPol As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtPol.Rows.Count = 0 Then
                MsgBox("No se encontraron ofertas con las condiciones dadas.", MsgBoxStyle.Exclamation, "AVISO...")
                GridPolizas.DataSource = Nothing
                GridPolizas.Refresh()
                Exit Sub
            End If
            GridPolizas.DataSource = dtPol
            GridPolizas.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaPolizas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPolizas.DoubleClick
        Dim Fila As Integer = Me.VistaPolizas.FocusedRowHandle
        If Fila >= 0 Then
            Try
                Dim Poliza As String = Me.VistaPolizas.GetRowCellValue(Fila, "IdPoliza")
                Dim Producto As String = Me.VistaPolizas.GetRowCellValue(Fila, "IdProducto")

                If Me.optPolizas.Checked = True Then
                    Dim fpol As New PolizasMan
                    fpol.Permiso = Me.Permiso
                    fpol.dbTabla = "Polizas"
                    fpol.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto)
                    fpol.STIConn = StiGlobalConn
                    fpol.ShowDialog()
                Else
                    If Producto = "" Then
                        'comparativo
                        Dim fcomp As New OfertasComparativo
                        fcomp.dbCondicion = "IdComparativo = " & dbInt(Poliza)
                        fcomp.dbTabla = "OfertasComparativo"
                        fcomp.Permiso = Me.Permiso
                        fcomp.STIConn = StiGlobalConn
                        fcomp.Show()
                    Else
                        Dim fpol As New CPolizasMan
                        fpol.Permiso = Me.Permiso
                        fpol.dbTabla = "CPolizas"
                        fpol.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto)
                        fpol.STIConn = StiGlobalConn
                        fpol.ShowDialog()
                    End If
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub AgregarGestiónDePolizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarGestiónDePolizasToolStripMenuItem.Click
        ''lo que haremos es ingresar una nueva gestión con la factura selecionada
        Try
            Dim fila As Integer = Me.VistaPolizas.FocusedRowHandle
            If fila >= 0 Then
                Dim frmGestion As New Gestiones
                frmGestion.TipoGestion = "P"
                frmGestion.IdCliente = ""
                frmGestion.IdPoliza = Me.VistaPolizas.GetRowCellValue(fila, "IdPoliza")
                frmGestion.IdProducto = Me.VistaPolizas.GetRowCellValue(fila, "IdProducto")
                frmGestion.IdSiniestro = ""
                frmGestion.NumeroFactura = ""
                frmGestion.dbTabla = "Gestiones"
                frmGestion.STIConn = StiGlobalConn
                frmGestion.Permiso = "T"
                frmGestion.ShowDialog()

                'ahora lo que haremos es actualizar el estatus de gestion de la fila afectada (colores)
                Dim Pen As Integer = 0, Tra As Integer = 0
                Try
                    Pen = StiGlobalConn.ObtenerDataset("select count(*) from gestiones as g where g.IdProducto = " & dbStr(Me.VistaPolizas.GetRowCellValue(fila, "IdProducto")) & " and g.IdPoliza = " & dbStr(Me.VistaPolizas.GetRowCellValue(fila, "IdPoliza")) & " and g.tipogestion = 'P' and g.FechaProximaGestion <= " & dbFec(Date.Today)).Tables(0).Rows(0).Item(0)
                    Tra = StiGlobalConn.ObtenerDataset("select count(*) from gestiones as g where g.IdProducto = " & dbStr(Me.VistaPolizas.GetRowCellValue(fila, "IdProducto")) & " and g.IdPoliza = " & dbStr(Me.VistaPolizas.GetRowCellValue(fila, "IdPoliza")) & " and g.tipogestion = 'P' and g.FechaProximaGestion > " & dbFec(Date.Today)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Pen = 0
                    Tra = 0
                End Try
                Me.VistaPolizas.SetRowCellValue(fila, "GestionPendiente", Pen)
                Me.VistaPolizas.SetRowCellValue(fila, "GestionTramite", Tra)

            Else
                MsgBox("Debe seleccionar una póliza/Oferta a la que desea ingresarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ConsultarGestiónDePolizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarGestiónDePolizasToolStripMenuItem.Click
        Try
            Dim fila As Integer = Me.VistaPolizas.FocusedRowHandle
            If fila >= 0 Then
                Dim IdGestion As Integer = -1
                Try
                    IdGestion = StiGlobalConn.ObtenerDataset("select idgestion from gestiones where IdPoliza = " & dbStr(Me.VistaPolizas.GetRowCellValue(fila, "IdPoliza")) & " and IdProducto = " & dbStr(Me.VistaPolizas.GetRowCellValue(fila, "IdProducto")) & " order by FechaProximaGestion desc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdGestion = -1
                End Try

                If IdGestion <> -1 Then
                    Dim frmGestion As New Gestiones
                    frmGestion.TipoGestion = "P"
                    frmGestion.IdCliente = ""
                    frmGestion.IdPoliza = Me.VistaPolizas.GetRowCellValue(fila, "IdPoliza")
                    frmGestion.IdProducto = Me.VistaPolizas.GetRowCellValue(fila, "IdProducto")
                    frmGestion.IdSiniestro = ""
                    frmGestion.NumeroFactura = ""
                    frmGestion.dbTabla = "Gestiones"
                    frmGestion.STIConn = StiGlobalConn
                    frmGestion.Permiso = "T"
                    frmGestion.dbCondicion = "IdGestion=" & dbInt(IdGestion)
                    frmGestion.ShowDialog()
                Else
                    MsgBox("La Póliza seleccionada no tiene gestión realizada.", MsgBoxStyle.Information, "AVISO...")
                End If
            Else
                MsgBox("Debe seleccionar la Pólizas a la que desea consultarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
