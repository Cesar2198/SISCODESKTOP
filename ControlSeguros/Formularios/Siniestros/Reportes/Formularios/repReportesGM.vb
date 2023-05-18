Imports Utilerias.Genericas

Public Class repReportesGM

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

            If Me.optDiagnostico.Checked = True Then
                sql = "  select "
                sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
                sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
                sql &= " , p.Descripcion as Producto"
                sql &= " ,a.Nombre as Aseguradora"
                sql &= " from Siniestros as s"
                sql &= " inner join Productos as p on s.idproducto = p.idproducto"
                sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                sql &= " where s.idsiniestro is not null"
            End If

            If Me.optGasto.Checked = True Then
                sql = "  select "
                sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros "
                sql &= " ,isnull((select Descripcion from ProductosSinGastos as c where c.IdProducto = s.IdProducto and c.IdGasto = d.IdGasto),isnull(d.DescripcionGastos,'')) as DescripcionSiniestro"
                sql &= " ,s.DescripcionReserva, isnull(d.ValorPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
                sql &= " , p.Descripcion as Producto"
                sql &= " ,a.Nombre as Aseguradora"
                sql &= " from Siniestros as s"
                sql &= " inner join SiniestrosDetalle as d on s.IdPoliza = d.IdPoliza and s.IdProducto = d.IdProducto and s.IdCertificado = d.IdCertificado and s.IdSiniestro = d.IdSiniestro"
                sql &= " inner join Productos as p on s.idproducto = p.idproducto"
                sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                sql &= " where s.idsiniestro is not null"
            End If

            'filtraremos productos solo de GM o Colectivo
            '12/07/2013 ya no filtraremos por estos códigos debido a que los corredores tienden a hacer los propios ramos, que no son los ya pre-cargados.
            'sql &= " and p.idramo in ('103', '301')"

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
            End If

            If cboIdProducto.Valor <> "" Then
                sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            End If


            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            If dtSiniestros.Rows.Count = 0 Then
                MsgBox("No se encontraron siniestros con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
            Else
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtSiniestros.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes

                Dim Reporte As Object
                Reporte = New repSiniestros
                If Me.optDiagnostico.Checked = True Then
                    Reporte = New repCRDiagnosticosGM
                End If
                If Me.optGasto.Checked = True Then
                    Reporte = New repCRConceptosGM
                End If

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

            End If
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub repReportesGM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
            Me.txtFechaHasta.Valor = Date.Today
        Catch ex As Exception

        End Try

        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
