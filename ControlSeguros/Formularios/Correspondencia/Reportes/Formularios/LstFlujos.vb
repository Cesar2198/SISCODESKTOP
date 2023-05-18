Imports Utilerias.Genericas

Public Class LstFlujos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtFechaDesde.Text = "" Then
            MsgBox("Debe especificar la fecha de inicio de los flujos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar la fecha final de los flujos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim sql As String = ""

            sql = "  select"
            sql &= " d.IdFlujoDoc as IdFlujoDoc"
            sql &= ", f.Descripcion as Flujo"
            sql &= ", d.Comentario as Comentario"
            sql &= ", d.EstadoFlujo as EstadoFlujo"
            sql &= ", d.FechaInicia as FechaInicia"
            sql &= ", d.FechaFinaliza as FechaFinaliza"
            sql &= ", d.IdPoliza as IdPoliza"
            sql &= ", p.Descripcion as Producto"
            sql &= ", d.NumeroFactura as NumeroFactura"
            sql &= ", d.IdSiniestro as IdSiniestro"
            sql &= ", d.IdCliente as IdCliente"
            sql &= ", d.NombreCliente as NombreCliente"
            sql &= ", a.Nombre as Aseguradora"
            sql &= ", u.Descripcion as Ubicacion"
            sql &= ", d.IdAvisoCobro as IdAvisoCobro"
            sql &= ", r.NombreRamo as Ramo"
            sql &= ", d.IdUsuarioSolicita as IdUsuarioSolicita"
            sql &= ", d.IdUsuarioDestino as IdUsuarioDestino"
            sql &= ", d.Direccion as Direccion"
            sql &= ", c.NombreCiudad as Ciudad"
            sql &= ", z.DescripcionZona as Zona"
            sql &= ", (select pa.FechaPaso from FlujosDocumentosPasos as pa where pa.IdFlujoDoc = d.IdFlujoDoc and pa.Orden = (select min(Orden) from FlujosDocumentosPasos as pa1 where pa1.IdFlujoDoc = d.IdFlujoDoc)) as FechaPrimerPaso"
            sql &= ", (select pa.FechaPaso from FlujosDocumentosPasos as pa where pa.IdFlujoDoc = d.IdFlujoDoc and pa.Orden = (select max(Orden) from FlujosDocumentosPasos as pa1 where pa1.IdFlujoDoc = d.IdFlujoDoc)) as FechaUltimoPaso"
            sql &= ", f.CategoriaFlujo as CategoriaFlujo"
            sql &= ", f.TipoFlujo as TipoFlujo"
            sql &= ", 0.0 as HorasLaborales"
            sql &= ", 0.0 as HorasTranscurridas"
            sql &= ", 0.0 as DiasLaborales"
            sql &= ", 0.0 as DiasTranscurridos"
            sql &= ", case when d.EstadoFlujo = 'FINALIZADO' then 1 else 0 end as Completado"
            sql &= ", case when d.EstadoFlujo = 'PENDIENTE' then 1 else 0 end as Pendiente"
            sql &= ", (select top 1 DescripcionPaso from FlujosTrabajoPasos where FlujosTrabajoPasos.IdFlujo = d.IdFlujo and IdPaso = (select IdPaso from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = d.IdFlujoDoc and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = d.IdFlujoDoc))) as PasoActual"
            sql &= ", (select top 1 DescripcionPaso from FlujosTrabajoPasos where FlujosTrabajoPasos.IdFlujo = d.IdFlujo and IdPaso = (select IdSiguientePaso from  FlujosTrabajoPasos as ftp where ftp.IdFlujo = d.IdFlujo and ftp.IdPaso = (select IdPaso from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = d.IdFlujoDoc and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = d.IdFlujoDoc)))) as PasoPendiente"
            sql &= ", (select sum(isnull(ftp.TiempoEstimado,0)) from FlujosDocumentosPasos as fdp inner join FlujosTrabajoPasos as ftp on ftp.IdFlujo = fdp.IdFlujo and ftp.IdPaso = fdp.IdPaso where fdp.IdFlujoDoc = d.IdFlujoDoc) as HorasAtraso"
            sql &= ", (select us.NombreUsuario from Usuarios as us inner join clientes as cl on cl.EjecutivoCta = us.IdUsuario where cl.idcliente = d.idcliente ) as Ejecutivo"
            sql &= ", (select top 1 Usuarios from FlujosTrabajoPasos where FlujosTrabajoPasos.IdFlujo = d.IdFlujo and IdPaso = (select IdSiguientePaso from  FlujosTrabajoPasos as ftp where ftp.IdFlujo = d.IdFlujo and ftp.IdPaso = (select IdPaso from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = d.IdFlujoDoc and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = d.IdFlujoDoc)))) as Responsable"
            sql &= ", d.FechaAsignacion, d.FechaReAsignacion "
            sql &= " from FlujosDocumentos as d"
            sql &= " left join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo"
            sql &= " left join Productos as p on p.idproducto = d.idproducto"
            sql &= " left join aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join ubicaciones as u on u.idubicacion = d.idubicacion"
            sql &= " left join RamoSeguros as r on r.idramo = d.idramo"
            sql &= " left join Ciudades as c on c.idciudad = d.idciudad"
            sql &= " left join Zonas as z on z.idzona = d.idzona"

            If chkSoloPendiente.Checked = True Then
                sql &= " where d.FechaInicia <= " & dbFec(CDate(txtFechaHasta.Valor).ToShortDateString, "23:59:59") & " and d.EstadoFlujo = 'PENDIENTE'"
            Else
                sql &= " where d.FechaInicia between " & dbFec(CDate(txtFechaDesde.Valor).ToShortDateString) & " and " & dbFec(CDate(txtFechaHasta.Valor).ToShortDateString, "23:59:59")
            End If
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = d.idpoliza and pol.idproducto = d.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If


            Dim dtFlujos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtFlujos.Rows.Count > 0 Then
                ''calcularemos las horas del flujo
                Dim Fila As DataRow, Inicio As DateTime, Final As DateTime, Ahora As DateTime = Date.Now
                For Each Fila In dtFlujos.Rows
                    Try
                        Inicio = Fila("FechaPrimerPaso")
                        If dbData(Fila, "FechaAsignacion") <> "" Then
                            Inicio = Fila("FechaAsignacion")
                        End If

                        If dbData(Fila, "EstadoFlujo") = "PENDIENTE" Then
                            Final = Ahora
                        Else
                            Final = Fila("FechaUltimoPaso")
                        End If
                        Fila("HorasLaborales") = Math.Round(clSeguros.ObtenerHorasLaborales(Inicio, Final), 2)
                        Fila("HorasTranscurridas") = Math.Round(clSeguros.ObtenerHorasTrascurridas(Inicio, Final), 2)
                        Fila("DiasLaborales") = Math.Round(Fila("HorasLaborales") / 8, 0)
                        Fila("DiasTranscurridos") = Math.Round(Fila("HorasTranscurridas") / 24, 0)

                        'en base a las horas laborales transcurridas calcularemos el atraso, ojo solo si hay tiempos
                        If Fila("HorasAtraso") > 0 Then
                            Fila("HorasAtraso") = Fila("HorasLaborales") - Fila("HorasAtraso")
                            If Fila("HorasAtraso") < 0 Then Fila("HorasAtraso") = 0
                        End If

                        Fila.AcceptChanges()
                    Catch ex As Exception

                    End Try
                Next
            Else
                MsgBox("No se encontraron flujos para las fechas especificadas")
            End If

            Me.PivotFlujos.DataSource = dtFlujos
            Me.PivotFlujos.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LstFlujos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Flujos " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotFlujos.ExportToXls(Archivo, Opciones)
            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

End Class
