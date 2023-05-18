Imports Utilerias.Genericas

Public Class repCorrespondenciaSalida

    Private ParRepEspecialSalida1 As String = ""


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub repCorrespondenciaSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaDesde.Valor = Date.Today
        txtFechaHasta.Valor = Date.Today
        Me.cboRuta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboRuta.Llenar_Combo()
        Me.cboRuta.OcultarColumna(0)

        Me.cboDepto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboDepto.Llenar_Combo()
        Me.cboDepto.OcultarColumna(0)

        Me.cboIdUsuario.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdUsuario.Llenar_Combo()
        Me.cboIdUsuario.OcultarColumna(0)

        Select Case GlobalCodCliente
            Case "6300000"
                Me.optEspecialSalida1.Visible = True
                Me.optEspecialSalida1.Text = "Hoja de Requerimientos"
                ParRepEspecialSalida1 = "Reporte.Corr.HojaReqCON"
            Case "2120000"
                Me.OptControlEntrada.Enabled = False
                Me.cboDepto.Enabled = False
                optEspecialSalida1.Text = "Hoja Resumen por Mensajero"
                ParRepEspecialSalida1 = "Reporte.Corr.ResMensajero"

            Case Else
                Me.optEspecialSalida1.Visible = False
                ParRepEspecialSalida1 = ""
        End Select
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.txtFechaDesde.Text = "" Then
            MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim Horas As Double = 0
        Try
            If Me.txtHoras.Text <> "" Then
                Horas = Me.txtHoras.Valor
            End If
        Catch ex As Exception
            Horas = 0
        End Try

        If Me.optControl.Checked = True Then Call GenerarReporteControl("SALIDA", txtFechaDesde.Valor, txtFechaHasta.Valor, cboRuta.Valor, Horas, cboIdUsuario.Valor, "")
        If Me.OptControlEntrada.Checked = True Then Call GenerarReporteControl("ENTRADA", txtFechaDesde.Valor, txtFechaHasta.Valor, cboDepto.Valor, Horas, cboIdUsuario.Valor, "")
        If Me.optEspecialSalida1.Checked = True Then Call GenerarReporteControl("SALIDA", txtFechaDesde.Valor, txtFechaHasta.Valor, cboRuta.Valor, Horas, cboIdUsuario.Valor, ParRepEspecialSalida1)
        If Me.optMensajero.Checked = True Then Call GenerarReporteMensajero()

    End Sub

    Private Sub GenerarReporteMensajero()
        Dim sql As String = ""

        Try
            sql = "  select "
            sql &= " d.IdFlujoDoc"
            sql &= ", f.Descripcion as Flujo"
            sql &= ", i.Descripcion as Comentario "
            sql &= ", d.EstadoFlujo"
            sql &= ", d.FechaInicia"
            sql &= ", d.FechaFinaliza"
            sql &= ", isnull(i.IdOrigen, isnull(d.NombreCliente,'') + ' ' + isnull((select nombre from aseguradoras as a where a.idaseguradora = d.idaseguradora),'')) as NombreCliente"
            sql &= ", d.IdUsuarioSolicita"
            sql &= ", d.IdUsuarioDestino"
            sql &= ", isnull(i.DireccionDocumento, d.Direccion) as Direccion"
            sql &= ", isnull(c.NombreCiudad,'') as Ciudad"
            sql &= ", isnull(z.DescripcionZona,'') as Zona"
            sql &= ", f.CategoriaFlujo"
            sql &= ", f.TipoFlujo, i.FechaMovimiento"
            sql &= ", i.IdImpresion, i.FechaImpresion, i.FechaEnvio, isnull(i.Courier,'') as Courier, isnull(i.Descripcion,'') as DescripcionImpresion"
            sql &= ",(select top 1 p.DescripcionPaso from FlujosTrabajoPasos as p where p.IdFlujo = d.IdFlujo and p.IdPaso = (select p1.IdPaso from FlujosDocumentosPasos p1 where p1.IdFlujoDoc = d.IdFlujoDoc and p1.Orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc))) as PasoActual"
            sql &= ",(select top 1 p.DescripcionPaso from FlujosTrabajoPasos as p where p.IdFlujo = d.IdFlujo and p.IdPaso = (select ftp.IdSiguientePaso from  FlujosTrabajoPasos as ftp where ftp.IdFlujo = d.IdFlujo and ftp.IdPaso = (select p1.IdPaso from FlujosDocumentosPasos p1 where p1.IdFlujoDoc = d.IdFlujoDoc and p1.Orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc)))) as SiguientePaso"
            sql &= ",(select top 1 p.FechaPaso from FlujosDocumentosPasos as p where p.IdFlujoDoc = d.IdFlujoDoc and p.orden = 1) as FechaPrimerPaso"
            sql &= ", (select p.FechaPaso from FlujosDocumentosPasos as p where p.IdFlujoDoc = d.IdFlujoDoc and p.orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc)) as FechaUltimoPaso"
            sql &= ", isnull((select u.NombreUsuario from usuarios as u where u.idusuario = i.IdUsuarioEntrega),'') as IdUsuarioEntrega"
            sql &= ", isnull((select a.Nombre from aseguradoras as a where a.idaseguradora = d.idaseguradora),isnull((select a.nombre from aseguradoras as a inner join productos as p on p.idaseguradora = a.idaseguradora where p.idproducto = d.idproducto),'')) as Aseguradora"
            sql &= ", isnull(i.NombreDestinatario,d.NombreCliente) as NombreDestinatario"
            sql &= ", isnull(i.NombreAttDoc,'') as NombreAttDoc"
            sql &= ", (select min(r.FechaRuteo) from FlujosDocumentosImpresionesRuteos as r where r.IdFlujoDoc = i.IdFlujoDoc and r.IdImpresion = i.IdImpresion ) as FechaPrimerRuteo"
            sql &= " from FlujosDocumentos as d"
            sql &= " inner join FlujosDocumentosImpresiones as i on d.IdFlujoDoc = i.IdFlujoDoc"
            sql &= " inner join FlujosTrabajo as f on f.idflujo = d.idflujo"
            sql &= " left join ciudades as c on c.idciudad = d.idciudad"
            sql &= " left join zonas as z on z.idzona = i.idzona"
            'fecha de sespacho asignada
            sql &= " where cast(convert(char(8),i.fechaenvio,112) as datetime) between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            'que no sea asignado a un courier
            'sql &= " and i.Courier is null"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = d.idpoliza and pol.idproducto = d.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            'sql &= " where cast(convert(char(8), (select p.FechaPaso from FlujosDocumentosPasos as p inner join FlujosTrabajoPasos as t on p.IdFlujo = t.IdFlujo and p.IdPaso = t.IdPaso where p.IdFlujoDoc = d.IdFlujoDoc and t.TipoControlCorrespondencia = 'SALIDA' and p.orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc)),112) as datetime) between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)

            If txtHoras.Valor > 0 Then
                sql &= " and i.FechaMovimiento >= " & dbFec(Date.Now.AddMinutes(txtHoras.Valor * -1), "1")
            End If


            If cboRuta.Valor <> "" Then
                sql &= " and i.IdZona = " & dbStr(cboRuta.Valor)
            End If

            If cboIdUsuario.Valor <> "" Then
                sql &= " and i.IdUsuarioEntrega = " & dbStr(cboIdUsuario.Valor)
            End If


            Dim dtFlujos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFlujos.TableName = "Correspondencia"

            If dtFlujos.Rows.Count = 0 Then
                MsgBox("No se encontró mensajería pendiente.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtFlujos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As Object
            Reporte = New repCRCorrespondenciaMensajero
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.CorrMensajero")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Reporte.SetDataSource(DsRep)

            ' ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            Dim strLFecha As String = ""
            If Me.txtFechaDesde.Valor = Me.txtFechaHasta.Valor Then
                strLFecha = "PARA EL " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy").ToUpper
            Else
                strLFecha = "ENTRE EL " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy").ToUpper & " Y " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy").ToUpper
            End If

            SetRepFormulaString(Reporte, "Titulo1", "ENVIO DE DOCUMENTACION " & strLFecha)
            'SetRepFormulaString(Reporte,"Titulo2","Ingresos entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
            'SetRepFormulaString(Reporte,"Titulo3","Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "NombreMensajero", cboIdUsuario.Descripcion.ToString.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()
        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

End Class
