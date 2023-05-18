Imports Utilerias.Genericas

Public Class LstAgendaTrabajo

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LstAgendaTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = Date.Today

        'llenamos la lista de los items de estado siniestro interno.
        Dim EstadosSin As String = CStr(clSeguros.ObtenerDBParametros("Cod.Estado.Siniestro")).Trim
        If EstadosSin <> "" Then
            Dim dtCombo As New DataTable, Fila As DataRow
            dtCombo.Columns.Add("ID", System.Type.GetType("System.String"))
            dtCombo.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))
            Dim NumItems As Integer = CuentaCar(EstadosSin, "|"), Item As String, Id As String = "", Descripcion As String = ""
            For i As Integer = 0 To NumItems
                Item = stiSplit(EstadosSin, "G" & i & "|1")
                Id = stiSplit(Item, "G0 1")
                Descripcion = stiSplit(Item, "G1 99")
                Fila = dtCombo.NewRow
                Fila("ID") = Id
                Fila("DESCRIPCION") = Descripcion
                dtCombo.Rows.Add(Fila)
            Next
            RepositoryItemLookUpEdit1.ValueMember = "ID"
            RepositoryItemLookUpEdit1.DisplayMember = "DESCRIPCION"
            RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
            RepositoryItemLookUpEdit1.DataSource = dtCombo
            RepositoryItemLookUpEdit1.PopulateColumns()
            RepositoryItemLookUpEdit1.Columns(0).Visible = False
        End If


        If clSeguros.ObtenerIdCliente() = "2120000" Then
            Me.VistaAgenda.Columns("IdSiniestro").Caption = "Num. Reclamo ADRISA"
        End If

    End Sub

    Private Sub ObtenerAgendas()
        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " isnull((select NombreUsuario from Usuarios as u where u.IdUsuario = fd.IdUsuarioDestino),'') as Ejecutivo"
            sql &= " , fd.IdFlujoDoc as Caso"
            sql &= " , fd.NombreCliente as Asegurado"
            sql &= " , fd.IdPoliza"
            sql &= " , fd.FechaInicia as FechaInicio"
            sql &= " , fd.EstadoFlujo as Estado"
            sql &= " , isnull(a.Nombre,(select a1.Nombre from Aseguradoras as a1 inner join Productos as pr on pr.idaseguradora = a1.idaseguradora where pr.idproducto = fd.idproducto)) as Aseguradora"
            sql &= " , cast(fd.Comentario as varchar(max)) as Referencia"
            sql &= " , (select top 1 DescripcionPaso from FlujosTrabajoPasos where FlujosTrabajoPasos.IdFlujo = fd.IdFlujo and IdPaso = (select IdPaso from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = fd.IdFlujoDoc and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = fd.IdFlujoDoc))) as Gestion"
            sql &= ",  fd.FechaActualizacion as FechaEnvio"
            sql &= ", cast(fd.EstadoUsuario as varchar(max)) as Estatus"
            sql &= ", (select NombreUsuario from usuarios where idusuario = fd.UsuarioAsignacion) as UsuarioAsignacion, (select NombreUsuario from usuarios where idusuario = fd.UsuarioReAsignacion) as UsuarioReAsignacion, fd.FechaAsignacion, fd.FechaReAsignacion"

            'Datos de Siniestros
            sql &= ", isnull((select top 1 s.IdSiniestro from Siniestros as s where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro),'') as IdSiniestro"
            sql &= ", isnull((select top 1 s.IdSiniestroAseguradora from Siniestros as s where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro),'') as IdSiniestroAseguradora"
            sql &= ", isnull((select top 1 cast(s.DescripcionSiniestro as varchar(max)) from Siniestros as s where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro),'') as DescripcionSiniestro"
            sql &= ", (select top 1 s.FechaOcurrido from Siniestros as s where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro) as FechaOcurrido"
            sql &= ", isnull((select top 1 g.Comentarios from Gestiones as g where g.TipoGestion = 'S' and g.IdPoliza = fd.IdPoliza and g.IdProducto = fd.IdProducto and g.IdSiniestro = fd.IdSiniestro order by g.FechaGestion desc, g.IdGestion desc),'') as GestionSiniestro"
            sql &= ", isnull((select top 1 cast(b.DescripcionBien as varchar(max)) from Siniestros as s inner join PolizasBienes as b on b.IdPoliza = s.IdPoliza and b.IdProducto = s.IdProducto and b.IdCertificado = s.IdCertificado and b.NombreBien = 'placa' where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro ),'') as Placa"
            sql &= ", isnull((select top 1 s.IdCertificado from Siniestros as s where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro),'') as IdCertificado"
            sql &= ", isnull((select pr.Descripcion from productos as pr where pr.idproducto = fd.idproducto),'') as Producto"
            sql &= ", isnull((select top 1 s.EstadoSiniestroInterno from Siniestros as s where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro),'') as EstadoSiniestroInterno"
            sql &= ", case when (fd.idflujo = 'FL.CORR' and fd.idusuariodestino is not null) or fd.flujoautomatico = 'S' then 1 else 0 end  as Identificador"
            sql &= ", isnull(fd.PendientePor,'') as PendientePor"
            sql &= ", isnull((select top 1 ce.nombrecliente from Siniestros as s inner join PolizasCertificados as ce on ce.IdPoliza = s.IdPoliza and ce.IdProducto = s.IdProducto and ce.IdCertificado = s.IdCertificado where s.IdPoliza = fd.IdPoliza and s.IdProducto = fd.idproducto and s.IdSiniestro = fd.IdSiniestro  ), '') as TitularCertificado"


            sql &= " from FlujosDocumentos as fd"
            sql &= " left join Aseguradoras as a on fd.idaseguradora = a.idaseguradora"
            sql &= " where fd.FechaInicia between " & dbFec(CDate(txtFechaDesde.Valor).ToShortDateString) & " and " & dbFec(CDate(txtFechaHasta.Valor).ToShortDateString, "23:59:59")
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = fd.idpoliza and pol.idproducto = fd.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            'opcional si quieren los siniestros abiertos y que no estén en flujos.

            Dim IncluirSiniestros As String = clSeguros.ObtenerDBParametros("Siniestros.EnAgenda")

            If IncluirSiniestros.Trim.ToUpper = "S" Then
                sql &= " union "

                sql &= " select "
                sql &= " isnull((select NombreUsuario from Usuarios as u where u.idusuario = s.EjecutivoCta),'') as Ejecutivo"
                sql &= " , null as Caso"
                sql &= " , s.NombrePresentaReclamo as Asegurado"
                sql &= " , s.IdPoliza"
                sql &= " , s.FechaOcurrido as FechaInicio"
                sql &= " , 'PENDIENTE' as Estado"
                sql &= " , isnull((select a.Nombre from Aseguradoras as a inner join productos as pr on pr.idaseguradora = a.idaseguradora where pr.idproducto = p.idproducto ),'') as Aseguradora"
                sql &= " , '' as Referencia"
                sql &= " , '' as Gestion"
                sql &= " , s.FechaActualizacion as FechaEnvio"
                sql &= " , cast(s.EstadoUsuario as varchar(max)) as Estatus"
                sql &= ", null as UsuarioAsignacion, null as UsuarioReAsignacion, null as FechaAsignacion, null as FechaReAsignacion"
                sql &= " ,s.IdSiniestro"
                sql &= " ,s.IdSiniestroAseguradora"
                sql &= " , cast(s.DescripcionSiniestro as varchar(max)) as DescripcionSiniestro"
                sql &= " ,s.FechaOcurrido"
                sql &= ", isnull((select top 1 g.Comentarios from Gestiones as g where g.TipoGestion = 'S' and g.IdPoliza = s.IdPoliza and g.IdProducto = s.IdProducto and g.IdSiniestro = s.IdSiniestro order by g.FechaGestion desc, g.IdGestion desc),'') as GestionSiniestro"
                sql &= ", isnull((select cast(DescripcionBien as varchar(max)) from PolizasBienes as b where b.IdPoliza = s.IdPoliza and b.IdProducto = s.IdProducto and b.IdCertificado = s.IdCertificado and b.NombreBien = 'placa'),'') as Placa"
                sql &= ", s.IdCertificado"
                sql &= ", isnull((select pr.Descripcion from productos as pr where pr.idproducto = s.idproducto),'') as Producto"
                sql &= ", s.EstadoSiniestroInterno as EstadoSiniestroInterno"
                sql &= ", 0 as Identificador"
                sql &= ", isnull(s.PendientePor,'') as PendientePor"
                sql &= ", isnull(c.nombrecliente, '') as TitularCertificado"

                sql &= " from siniestros as s"
                sql &= " inner join polizas as p on p.idpoliza = s.idpoliza and p.idproducto = s.idproducto"
                sql &= " inner join PolizasCertificados as c on c.idpoliza = s.idpoliza and c.idproducto = s.idproducto and c.idcertificado = s.idcertificado"
                sql &= " where s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"

                'si ya existe un flujo pendiente del siniestro no los reportamos sino saldría dos veces
                sql &= " and (select count(*) from FlujosDocumentos as fd where fd.idpoliza = s.idpoliza and fd.idproducto = s.idproducto and fd.idsiniestro = s.idsiniestro and fd.EstadoFlujo = 'PENDIENTE') = 0 "

                If VisibilidadUsuario() = "D" Then
                    sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                End If

            End If
            sql &= " order by 16"

            Dim dtFlujos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridAgenda.DataSource = dtFlujos
            Me.GridAgenda.Refresh()

            'si hay un nombre especial de Estado interno
            Dim NombreEstado As String = ""
            Try
                NombreEstado = StiGlobalConn.ObtenerDataset("select Nombre from VistasCampos where forma = 'SiniestrosMan' and campo = 'cboEstadoSiniestroInterno'").Tables(0).Rows(0).Item(0)
                If NombreEstado <> "" Then Me.VistaAgenda.Columns("EstadoSiniestroInterno").Caption = NombreEstado
            Catch ex As Exception

            End Try

            'ocultamos columnas
            Try
                VistaAgenda.Columns("Identificador").Visible = False : VistaAgenda.Columns("Identificador").OptionsColumn.AllowShowHide = False
            Catch ex As Exception

            End Try

            If dtFlujos.Rows.Count = 0 Then
                MsgBox("No se han encontrado flujos para completar la agenda.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call ObtenerAgendas()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Agenda " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaAgenda.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "AGENDA DEL " & Me.txtFechaDesde.Text.Trim.ToUpper & " AL " & Me.txtFechaHasta.Text.Trim.ToUpper, "", "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"), clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub VistaAgenda_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaAgenda.CellValueChanged
        Me.VistaAgenda.PostEditor()
        Me.VistaAgenda.UpdateCurrentRow()

        Dim IdFlujoDoc As String = ""
        Try
            IdFlujoDoc = VistaAgenda.GetRowCellValue(e.RowHandle, "Caso")
        Catch ex As Exception
            IdFlujoDoc = ""
        End Try

        Dim IdSiniestro As String = "", IdPoliza As String = ""
        Try
            IdSiniestro = VistaAgenda.GetRowCellValue(e.RowHandle, "IdSiniestro")
        Catch ex As Exception
            IdSiniestro = ""
        End Try
        Try
            IdPoliza = VistaAgenda.GetRowCellValue(e.RowHandle, "IdPoliza")
        Catch ex As Exception
            IdPoliza = ""
        End Try

        If IdFlujoDoc <> "" Then
            If e.Column.FieldName = "FechaEnvio" Then
                ''actualizamos el flujo
                Try
                    Dim sql As String = ""
                    sql = " update FlujosDocumentos "
                    sql &= " set FechaActualizacion = " & dbFec(VistaAgenda.GetRowCellValue(e.RowHandle, "FechaEnvio"))
                    sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)
                    StiGlobalConn.SQLExecute(sql)
                Catch ex As Exception

                End Try
            End If

            If e.Column.FieldName = "Estatus" Then
                ''actualizamos el flujo
                Try
                    Dim sql As String = ""
                    sql = " update FlujosDocumentos "
                    sql &= " set EstadoUsuario = " & dbStr(VistaAgenda.GetRowCellValue(e.RowHandle, "Estatus"))
                    sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)
                    StiGlobalConn.SQLExecute(sql)
                Catch ex As Exception

                End Try
            End If
        End If

        'la gestion de agenda puede ser de reclamos.
        If IdSiniestro <> "" And IdPoliza <> "" Then
            If e.Column.FieldName = "FechaEnvio" Then
                ''actualizamos el flujo
                Try
                    Dim sql As String = ""
                    sql = " update Siniestros "
                    sql &= " set FechaActualizacion = " & dbFec(VistaAgenda.GetRowCellValue(e.RowHandle, "FechaEnvio"))
                    sql &= " where IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza)
                    StiGlobalConn.SQLExecute(sql)
                Catch ex As Exception

                End Try
            End If

            If e.Column.FieldName = "Estatus" Then
                ''actualizamos el flujo
                Try
                    Dim sql As String = ""
                    sql = " update siniestros "
                    sql &= " set EstadoUsuario = " & dbStr(VistaAgenda.GetRowCellValue(e.RowHandle, "Estatus"))
                    sql &= " where IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza)
                    StiGlobalConn.SQLExecute(sql)
                Catch ex As Exception

                End Try
            End If

            If e.Column.FieldName = "EstadoSiniestroInterno" Then
                Try
                    Dim sql As String = ""
                    sql = " update siniestros "
                    sql &= " set EstadoSiniestroInterno = " & dbStr(VistaAgenda.GetRowCellValue(e.RowHandle, "EstadoSiniestroInterno"))
                    sql &= " where IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza)
                    StiGlobalConn.SQLExecute(sql)
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub VistaAgenda_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles VistaAgenda.CustomColumnDisplayText
        Select Case GlobalCodCliente
            Case "2120000"
                If Me.VistaAgenda.GetRowCellValue(e.RowHandle, "Identificador") = 0 Then
                    Select Case e.Column.FieldName
                        Case "UsuarioAsignacion", "UsuarioReAsignacion", "FechaAsignacion", "FechaReAsignacion"
                            e.DisplayText = ""
                    End Select
                End If

        End Select
    End Sub

End Class
