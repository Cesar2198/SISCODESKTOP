Imports Utilerias.Genericas

Public Class LstSiniestrosPresentados

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Siniestros " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotReclamos.ExportToXls(Archivo, Opciones)

            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscarReclamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarReclamos.Click
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

            Me.Cursor = Cursors.WaitCursor
            Dim NomFiltro As String = ""

            sql = "  select 'Siniestro' as Tipo"
            sql &= " ,s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, c.nombrecliente as Cliente "
            sql &= " ,isnull((select 'TALLER:' + cast(bi.Detalle as varchar(250)) + ', '  from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'TALLER REPARACION'),'') + isnull((select 'AJUSTADOR: ' + isnull((select '#:' + cast(bi.Detalle as varchar(250)) from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'RECLAMO AJUSTADOR'),'') + ' ' + cast(bi.Detalle as varchar(250)) + ', ' from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'NOMBRE AJUSTADOR'),'') + isnull(cast(s.DescripcionSiniestro as varchar(max)),'') as DescripcionSiniestro"
            sql &= " , isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " ,p.Descripcion as Producto"
            sql &= " ,s.IdSiniestroAseguradora"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.TipoProducto"
            sql &= " , isnull((select top 1 Comentarios from Gestiones as e where e.IdProducto = s.IdProducto and e.IdPoliza = s.IdPoliza and e.IdCertificado = s.IdCertificado and e.IdSiniestro = s.IdSiniestro order by e.FechaGestion desc ),'') as UltimaGestion"
            sql &= " ,isnull((select NombreUsuario from Usuarios where Usuarios.idusuario = s.EjecutivoCta),'') as EjecutivoCta"
            sql &= " ,'' as DocPendientes "
            sql &= " ,'' as DocPresentados"
            sql &= " ,'' as PagosRealizados "
            sql &= ", s.ClaseSiniestro"
            sql &= ", s.EstadoSiniestroInterno"
            sql &= ", 1 as CuentaSin"

            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join PolizasCertificados as c on c.IdPoliza = s.IdPoliza and c.IdProducto = s.IdProducto and c.IdCertificado = s.IdCertificado"

            sql &= " where s.idsiniestro is not null"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If optFecIncurre.Checked = True Then
                sql &= " and s.FechaOcurrido between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                NomFiltro &= ", Por Fecha de Ocurrencia"
            End If
            If optFecPresenta.Checked = True Then
                sql &= " and s.FechaPresentado between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                NomFiltro &= ", Por Fecha de Presentado"
            End If
            If optPendientes.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
                NomFiltro &= ", Siniestros Pendientes"
            End If
            If optPagados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('PAGADO')"
                NomFiltro &= ", Siniestros Pagados"
            End If
            If optAnulados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('RECHAZADO','RETIRADO')"
                NomFiltro &= ", Siniestros Anulados"
            End If
            If Me.optSinTodos.Checked = True Then
                NomFiltro &= ", Todos los Siniestros"
            End If

            If txtIdPoliza.Text <> "" Then
                sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
                NomFiltro &= ", Póliza: " & txtIdPoliza.Valor
            End If

            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
                NomFiltro &= ", Producto: " & cboIdProducto.Descripcion
            End If

            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
                NomFiltro &= ", Aseguradora:" & cboAseguradora.Descripcion
            End If

            If cboRamo.Valor <> "" Then
                sql &= " and p.IdRamo = " & dbStr(cboRamo.Valor)
                NomFiltro &= ", Ramo:" & cboRamo.Descripcion
            End If

            If Me.cboTipoSeguro.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoSeguro.Valor)
                NomFiltro &= ", Tipo Producto:" & cboTipoSeguro.Descripcion
            End If


            sql &= " union select 'Documentos' as Tipo"
            sql &= " ,s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, c.nombrecliente as Cliente"
            sql &= " ,isnull((select 'TALLER:' + cast(bi.Detalle as varchar(250)) + ', '  from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'TALLER REPARACION'),'') + isnull((select 'AJUSTADOR: ' + isnull((select '#:' + cast(bi.Detalle as varchar(250)) from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'RECLAMO AJUSTADOR'),'') + ' ' + cast(bi.Detalle as varchar(250)) + ', ' from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'NOMBRE AJUSTADOR'),'') + isnull(cast(s.DescripcionSiniestro as varchar(max)),'') as DescripcionSiniestro"
            sql &= " , null TotalPresentado, null as TotalNoCubierto, null as TotalCubierto, null as TotalDeducible, null as TotalCoaseguro, null as TotalDeudores, null as TotalReembolso, null as TotalPendiente"
            sql &= " ,p.Descripcion as Producto"
            sql &= " ,s.IdSiniestroAseguradora"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.TipoProducto"
            sql &= " , isnull((select top 1 Comentarios from Gestiones as e where e.IdProducto = s.IdProducto and e.IdPoliza = s.IdPoliza and e.IdCertificado = s.IdCertificado and e.IdSiniestro = s.IdSiniestro order by e.FechaGestion desc ),'') as UltimaGestion"
            sql &= " ,isnull((select NombreUsuario from Usuarios where Usuarios.idusuario = s.EjecutivoCta),'') as EjecutivoCta"
            sql &= " ,case when r.FechaPresentado is null then r.Descripcion else null end as DocPendientes "
            sql &= " ,case when r.FechaPresentado is null then null else convert(varchar, r.FechaPresentado,103) + ': ' +  r.descripcion  end as DocPresentados"
            sql &= " ,'' PagosRealizados "
            sql &= ", s.ClaseSiniestro"
            sql &= ", s.EstadoSiniestroInterno"
            sql &= ", 0 as CuentaSin"

            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join SiniestrosRequisitos as r on r.IdPoliza = s.IdPoliza and r.IdProducto = s.IdProducto and r.IdCertificado = s.IdCertificado and r.IdSiniestro = s.IdSiniestro "
            sql &= " left join PolizasCertificados as c on c.IdPoliza = s.IdPoliza and c.IdProducto = s.IdProducto and c.IdCertificado = s.IdCertificado"

            sql &= " where s.idsiniestro is not null"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If optFecIncurre.Checked = True Then
                sql &= " and s.FechaOcurrido between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                NomFiltro &= ", Por Fecha de Ocurrencia"
            End If
            If optFecPresenta.Checked = True Then
                sql &= " and s.FechaPresentado between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                NomFiltro &= ", Por Fecha de Presentado"
            End If
            If optPendientes.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
                NomFiltro &= ", Siniestros Pendientes"
            End If
            If optPagados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('PAGADO')"
                NomFiltro &= ", Siniestros Pagados"
            End If
            If optAnulados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('RECHAZADO','RETIRADO')"
                NomFiltro &= ", Siniestros Anulados"
            End If
            If Me.optSinTodos.Checked = True Then
                NomFiltro &= ", Todos los Siniestros"
            End If

            If txtIdPoliza.Text <> "" Then
                sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
                NomFiltro &= ", Póliza: " & txtIdPoliza.Valor
            End If

            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
                NomFiltro &= ", Producto: " & cboIdProducto.Descripcion
            End If

            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
                NomFiltro &= ", Aseguradora:" & cboAseguradora.Descripcion
            End If

            If cboRamo.Valor <> "" Then
                sql &= " and p.IdRamo = " & dbStr(cboRamo.Valor)
                NomFiltro &= ", Ramo:" & cboRamo.Descripcion
            End If

            If Me.cboTipoSeguro.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoSeguro.Valor)
                NomFiltro &= ", Tipo Producto:" & cboTipoSeguro.Descripcion
            End If

            sql &= " union select 'Pagos' as Tipo"
            sql &= " ,s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, c.nombrecliente as Cliente"
            sql &= " ,isnull((select 'TALLER:' + cast(bi.Detalle as varchar(250)) + ', '  from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'TALLER REPARACION'),'') + isnull((select 'AJUSTADOR: ' + isnull((select '#:' + cast(bi.Detalle as varchar(250)) from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'RECLAMO AJUSTADOR'),'') + ' ' + cast(bi.Detalle as varchar(250)) + ', ' from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'NOMBRE AJUSTADOR'),'') + isnull(cast(s.DescripcionSiniestro as varchar(max)),'') as DescripcionSiniestro"
            sql &= " , null as TotalPresentado, null as TotalNoCubierto, null as TotalCubierto, null as TotalDeducible, null as TotalCoaseguro, null as TotalDeudores, null as TotalReembolso, null as TotalPendiente"
            sql &= " ,p.Descripcion as Producto"
            sql &= " ,s.IdSiniestroAseguradora"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.TipoProducto"
            sql &= " , isnull((select top 1 Comentarios from Gestiones as e where e.IdProducto = s.IdProducto and e.IdPoliza = s.IdPoliza and e.IdCertificado = s.IdCertificado and e.IdSiniestro = s.IdSiniestro order by e.FechaGestion desc ),'') as UltimaGestion"
            sql &= " ,isnull((select NombreUsuario from Usuarios where Usuarios.idusuario = s.EjecutivoCta),'') as EjecutivoCta"
            sql &= " ,'' as DocPendientes "
            sql &= " ,'' as DocPresentados"
            sql &= " ,case when g.FechaPago is not null then g.NumeroCheque + ': ' + convert(varchar,g.FechaPago,103) + ' ' + convert(varchar,g.ValorReembolso) else null end as PagosRealizados "
            sql &= ", s.ClaseSiniestro"
            sql &= ", s.EstadoSiniestroInterno"
            sql &= ", 0 as CuentaSin"

            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join SiniestrosPagos as g on g.IdPoliza = s.IdPoliza and g.IdProducto = s.IdProducto and g.IdCertificado = s.IdCertificado and g.IdSiniestro = s.IdSiniestro"
            sql &= " left join PolizasCertificados as c on c.IdPoliza = s.IdPoliza and c.IdProducto = s.IdProducto and c.IdCertificado = s.IdCertificado"

            sql &= " where s.idsiniestro is not null"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If optFecIncurre.Checked = True Then
                sql &= " and s.FechaOcurrido between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                NomFiltro &= ", Por Fecha de Ocurrencia"
            End If
            If optFecPresenta.Checked = True Then
                sql &= " and s.FechaPresentado between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                NomFiltro &= ", Por Fecha de Presentado"
            End If
            If optPendientes.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
                NomFiltro &= ", Siniestros Pendientes"
            End If
            If optPagados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('PAGADO')"
                NomFiltro &= ", Siniestros Pagados"
            End If
            If optAnulados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('RECHAZADO','RETIRADO')"
                NomFiltro &= ", Siniestros Anulados"
            End If
            If Me.optSinTodos.Checked = True Then
                NomFiltro &= ", Todos los Siniestros"
            End If

            If txtIdPoliza.Text <> "" Then
                sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
                NomFiltro &= ", Póliza: " & txtIdPoliza.Valor
            End If

            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
                NomFiltro &= ", Producto: " & cboIdProducto.Descripcion
            End If

            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
                NomFiltro &= ", Aseguradora:" & cboAseguradora.Descripcion
            End If

            If cboRamo.Valor <> "" Then
                sql &= " and p.IdRamo = " & dbStr(cboRamo.Valor)
                NomFiltro &= ", Ramo:" & cboRamo.Descripcion
            End If

            If Me.cboTipoSeguro.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoSeguro.Valor)
                NomFiltro &= ", Tipo Producto:" & cboTipoSeguro.Descripcion
            End If

            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"



            If dtSiniestros.Rows.Count = 0 Then
                MsgBox("No se encontraron siniestros con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
            Else
                PivotReclamos.DataSource = dtSiniestros
                PivotReclamos.Refresh()
            End If

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LstSiniestrosPresentados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today
    End Sub
End Class
