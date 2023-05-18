Imports Utilerias.Genericas

Public Class repFrmSiniestros

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub repFrmSiniestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
            Me.txtFechaHasta.Valor = Date.Today
        Catch ex As Exception

        End Try

        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Me.cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboAseguradora.Llenar_Combo()

        Me.cboRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboRamo.Llenar_Combo()

        Me.cboTipoSeguro.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboTipoSeguro.Llenar_Combo()

        Me.cboEjecutivo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivo.Llenar_Combo()

        Select Case GlobalCodCliente
            Case "2120000"
                chkResGrid.Visible = True
            Case Else
                chkResGrid.Visible = False
        End Select

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

            Me.Cursor = Cursors.WaitCursor
            Dim NomFiltro As String = ""

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros"
            sql &= " ,isnull((select top 1 'TALLER:' + cast(bi.Detalle as varchar(250)) + ', '  from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'TALLER REPARACION'),'') + isnull((select top 1 'AJUSTADOR: ' + isnull((select '#:' + cast(bi.Detalle as varchar(250)) from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'RECLAMO AJUSTADOR'),'') + ' ' + cast(bi.Detalle as varchar(250)) + ', ' from SiniestrosInformacion as bi where bi.idpoliza = s.idpoliza and bi.IdProducto = s.IdProducto and bi.idcertificado = s.idcertificado and bi.IdSiniestro = s.IdSiniestro and bi.Descripcion = 'NOMBRE AJUSTADOR'),'') + isnull(cast(s.DescripcionSiniestro as varchar(max)),'') as DescripcionSiniestro"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " ,p.Descripcion as Producto"
            sql &= " ,s.IdSiniestroAseguradora"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,p.TipoProducto"
            sql &= " , isnull((select top 1 Comentarios from Gestiones as e where e.IdProducto = s.IdProducto and e.IdPoliza = s.IdPoliza and e.IdCertificado = s.IdCertificado and e.IdSiniestro = s.IdSiniestro order by e.FechaGestion desc ),'') as UltimaGestion"
            sql &= " ,isnull((select top 1 NombreUsuario from Usuarios where Usuarios.idusuario = s.EjecutivoCta),'') as EjecutivoCta"
            sql &= " ,s.EstadoSiniestroInterno, s.VigenciaDesde, s.VigenciaHasta, s.DescripcionSiniestro, s.FechaEnvioDocAseg, s.FechaCienteEntregaDocs, replace(s.NombreTaller,'_',' ') as NombreTaller, s.NombreConductor, replace(s.NombreCobAfecta,'_',' ') as NombreCobAfecta, s.FechaAvisoAseguradora "
            sql &= " , isnull((select top 1 DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and bi.NombreBien = 'PLACA'),'') as Placa"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
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

            If cboTipoSeguro.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoSeguro.Valor)
                NomFiltro &= ", Tipo Producto:" & cboTipoSeguro.Descripcion
            End If

            If cboEjecutivo.Valor <> "" Then
                sql &= " and s.EjecutivoCta = " & dbStr(cboEjecutivo.Valor)
                NomFiltro &= ", Ejecutivo:" & cboEjecutivo.Descripcion
            End If

            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            sql = "  select s.IdPoliza "
            sql &= " , s.IdCertificado"
            sql &= " , s.IdSiniestro"
            sql &= " , s.IdProducto"
            sql &= ",  s.Descripcion"
            sql &= ", case "
            sql &= "  when s.FechaPresentado is not null then 'DOCUMENTOS PRESENTADOS'"
            sql &= "  else 'DOCUMENTOS PENDIENTES'"
            sql &= " end as Estado"
            sql &= " , isnull((select top 1 DescripcionBien from PolizasBienes as b where b.IdPoliza = s.IdPoliza and b.IdProducto = s.IdProducto and b.IdCertificado = s.IdCertificado and b.NombreBien = 'Placa'  ),'') as Referencia "
            sql &= " , s.FechaPresentado"
            sql &= " from SiniestrosRequisitos as s "
            sql &= " where s.IdSiniestro in ("

            sql &= "  select "
            sql &= " s.IdSiniestro"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            If optFecIncurre.Checked = True Then
                sql &= " and s.FechaOcurrido between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                'NomFiltro &= ", Por Fecha de Ocurrencia"
            End If
            If optFecPresenta.Checked = True Then
                sql &= " and s.FechaPresentado between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                'NomFiltro &= ", Por Fecha de Presentado"
            End If
            If optPendientes.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
                'NomFiltro &= ", Siniestros Pendientes"
            End If
            If optPagados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('PAGADO')"
                'NomFiltro &= ", Siniestros Pagados"
            End If
            If optAnulados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('RECHAZADO','RETIRADO')"
                'NomFiltro &= ", Siniestros Anulados"
            End If
            If Me.optSinTodos.Checked = True Then
                'NomFiltro &= ", Todos los Siniestros"
            End If
            If txtIdPoliza.Text <> "" Then
                sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            End If
            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            End If
            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
            End If
            If cboRamo.Valor <> "" Then
                sql &= " and p.IdRamo = " & dbStr(cboRamo.Valor)
            End If
            If Me.cboTipoSeguro.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoSeguro.Valor)
            End If

            sql &= ") "
            'sql &= " and s.FechaPresentado is not null"
            Dim dtReq As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtReq.TableName = "Requisitos"


            sql = "  select s.IdPoliza "
            sql &= " , s.IdCertificado"
            sql &= " , s.IdSiniestro"
            sql &= " , s.IdProducto"
            sql &= " , s.FechaPago as Fecha"
            sql &= " , s.NumeroCheque"
            sql &= " , s.NombreCheque"
            sql &= " , s.ValorReembolso"
            sql &= " from SiniestrosPagos as s "
            sql &= " where s.IdSiniestro in ("
            sql &= "  select "
            sql &= " s.IdSiniestro"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            If optFecIncurre.Checked = True Then
                sql &= " and s.FechaOcurrido between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                'NomFiltro &= ", Por Fecha de Ocurrencia"
            End If
            If optFecPresenta.Checked = True Then
                sql &= " and s.FechaPresentado between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
                'NomFiltro &= ", Por Fecha de Presentado"
            End If
            If optPendientes.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
                'NomFiltro &= ", Siniestros Pendientes"
            End If
            If optPagados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('PAGADO')"
                'NomFiltro &= ", Siniestros Pagados"
            End If
            If optAnulados.Checked = True Then
                sql &= " and s.EstadoSiniestro in ('RECHAZADO','RETIRADO')"
                'NomFiltro &= ", Siniestros Anulados"
            End If
            If Me.optSinTodos.Checked = True Then
                'NomFiltro &= ", Todos los Siniestros"
            End If
            If txtIdPoliza.Text <> "" Then
                sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            End If
            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            End If
            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
            End If
            If cboRamo.Valor <> "" Then
                sql &= " and p.IdRamo = " & dbStr(cboRamo.Valor)
            End If
            If Me.cboTipoSeguro.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoSeguro.Valor)
            End If
            sql &= ") "
            'sql &= " and s.FechaPresentado is not null"
            Dim dtPago As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPago.TableName = "Pagos"


            If dtSiniestros.Rows.Count = 0 Then
                MsgBox("No se encontraron siniestros con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
            Else
                If Me.chkResGrid.Checked = False Then
                    Dim DsRep As New DataSet
                    DsRep.Tables.Add(dtSiniestros.Copy)
                    DsRep.Tables.Add(dtReq.Copy)
                    DsRep.Tables.Add(dtPago.Copy)
                    DsRep.Tables.Add(tblLogo.Copy)


                    Dim rep As New frmReportes
                    Dim Reporte As Object
                    Reporte = New repSiniestros
                    Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Siniestros")
                    If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

                    Reporte.SetDataSource(DsRep)

                    ''Definiremos algunos datos del reporte
                    SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
                    SetRepFormulaString(Reporte, "Titulo1", "Reporte de Siniestros")
                    SetRepFormulaString(Reporte, "Titulo2", "Siniestros entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
                    SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date") & " " & NomFiltro)
                    SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

                    rep.CRViewer.ReportSource = Reporte
                    rep.MdiParent = Me.MdiParent
                    rep.Show()
                Else
                    Dim lstDetalle As New LstSiniestrosDet
                    lstDetalle.dtDatos = dtSiniestros.Copy
                    lstDetalle.MdiParent = Me.MdiParent
                    lstDetalle.Show()
                End If
            End If
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
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

End Class
