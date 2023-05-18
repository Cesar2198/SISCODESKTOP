Imports Utilerias.Genericas

Public Class EnviosSiniestrosMan

    Private Sub EnviosSiniestrosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If Me.txtIdEnvio.Text = "" Then
            'generamos el número de envio
            txtIdEnvio.Text = clSeguros.ObtenerID("Envios.Siniestros." & Date.Today.Year) & "-" & Date.Today.Year
            Call txtIdEnvio_ValueChangeOnExit(Nothing, Nothing, "")
        End If
    End Sub

    Private Sub EnviosSiniestrosMan_DespuesDeEliminar() Handles Me.DespuesDeEliminar
        Try
            Dim sql As String = ""
            sql = " update siniestros "
            sql &= " set IdEnvio = null "
            sql &= " where IdEnvio = " & dbStr(txtIdEnvio.Valor)
            StiGlobalConn.SQLExecute(sql)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EnviosSiniestrosMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        'marcaremos los reclamos enviados
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Dim sql As String = ""
            sql = " update siniestros "
            sql &= " set IdEnvio = " & dbStr(txtIdEnvio.Valor)
            sql &= " from siniestros"
            sql &= " inner join EnviosSiniestrosDetalle "
            sql &= " on siniestros.IdPoliza = EnviosSiniestrosDetalle.IdPoliza and siniestros.IdProducto = EnviosSiniestrosDetalle.IdProducto and siniestros.IdCertificado = EnviosSiniestrosDetalle.IdCertificado and siniestros.IdSiniestro = EnviosSiniestrosDetalle.IdSiniestro"
            sql &= " where EnviosSiniestrosDetalle.IdEnvio = " & dbStr(txtIdEnvio.Valor)
            StiGlobalConn.SQLExecute(sql)
        End If
    End Sub

    Private Sub EnviosSiniestrosMan_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        'finalmente generamos el envio
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            'generamos el archivo de envio
            Call GenerarEnvio(txtIdEnvio.Valor, txtRutaArchivo.Valor)

            'generamos el reporte
            Call btnImprimir_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub EnviosSiniestrosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TP As DataTable
        TP = StiGlobalConn.ObtenerDataset("select IdProducto as Id, Descripcion from Productos order by Descripcion").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TP
        RepositoryItemLookUpEdit1.PopulateColumns()

        Me.txtRutaArchivo.Valor = clSeguros.ObtenerDBParametros("Ruta.Envios")

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFechaDesde.Valor = Date.Today
            Me.txtFechaHasta.Valor = Date.Today
            txtFechaEnvio.Valor = Date.Today
        Else
            Me.EstadoEntradas(False, Me)
            Me.VistaReclamos.OptionsBehavior.Editable = True


            Me.btnBuscarReclamos.Enabled = False
        End If
        Me.txtRutaArchivo.SoloLectura = False
    End Sub

    Private Sub btnRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuta.Click
        Try
            'Me.FolderBrowserDialog1.RootFolder = Me.txtRutaArchivo.Valor
            Me.FolderBrowserDialog1.ShowDialog()
            Me.txtRutaArchivo.Valor = Me.FolderBrowserDialog1.SelectedPath
            ' If txtRutaArchivo.Text <> "" Then
            ' clSeguros.ActualizarDBParametros("Ruta.Envios", Me.txtRutaArchivo.Valor)
            ' End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarReclamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarReclamos.Click
        If txtFechaDesde.Text = "" Then
            MsgBox("Debe especificar la fecha de inicio", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar la fecha final", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If cboPlan.Valor = "" And Me.cboAseguradora.Valor = "" Then
            MsgBox("Debe especificar el plan o Aseguradora.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Try

            Dim sql As String = ""
            Dim dtReclamos As DataTable

            sql = " select "
            sql &= " '' as IdEnvio"
            sql &= " ,s.IdPoliza"
            sql &= " ,s.IdProducto"
            sql &= " ,s.IdCertificado"
            sql &= " ,s.IdSiniestro"
            sql &= " ,s.IdSiniestroAseguradora"
            sql &= " , cast(0 as bit) as Marcar"
            sql &= " , NombrePresentaReclamo as Asegurado "
            sql &= " , (select nombrecliente from polizascertificados where polizascertificados.idpoliza = s.idpoliza and polizascertificados.idproducto = s.idproducto and polizascertificados.idcertificado = s.idcertificado) as Titular"

            sql &= " from Siniestros as s"
            sql &= " left join Productos as p on s.idproducto = p.idproducto"
            sql &= " where s.fechapresentado between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            sql &= " and s.IdEnvio is null"
            sql &= " and s.EstadoSiniestro not in ('RECHAZADO', 'RETIRADO') "

            If cboPlan.Valor <> "" Then
                Dim filPlan As DataRow = StiGlobalConn.ObtenerDataset("select IdPoliza, IdProducto from SiniestroPlanes where IdPlan = " & dbStr(cboPlan.Valor)).Tables(0).Rows(0)
                sql &= " and s.IdPoliza = " & dbStr(dbData(filPlan, "IdPoliza"))
                sql &= " and s.IdProducto = " & dbStr(dbData(filPlan, "IdProducto"))
            End If

            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
            End If

            If txtNumSiniestro.Valor <> "" Then
                sql &= " and s.IdSiniestro = " & dbStr(txtNumSiniestro.Valor)
            End If

            If cboIdProducto.Valor <> "" Then
                sql &= " and s.Idproducto = " & dbStr(cboIdProducto.Valor)
            End If

            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            sql &= " order by IdSiniestro"

            dtReclamos = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridReclamos.DataSource = dtReclamos
            GridReclamos.Refresh()

            If dtReclamos.Rows.Count = 0 Then
                MsgBox("No se encontraron reclamos para el día y plan seleccionado.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub txtIdEnvio_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdEnvio.ValueChangeOnExit
        Me.ActualizarLlavesGrid(Me, txtIdEnvio.NombreCampo, txtIdEnvio.Valor)
    End Sub

    Private Sub GenerarEnvio(ByVal IdEnvio As String, ByVal RutaArchivo As String)
        If IdEnvio.Trim = "" Then Exit Sub
        If RutaArchivo.Trim = "" Then Exit Sub
        'estos envíos solo son utilizado por ACSA, Para otras aseguradoras pueden mandar el reporte impreso.
        Dim IdAseguradora As String = ""
        Try
            IdAseguradora = StiGlobalConn.ObtenerDataset("select distinct p.idaseguradora from EnviosSiniestrosDetalle as e inner join Productos as p on p.idproducto = e.idproducto and e.IdEnvio = " & dbStr(IdEnvio)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            IdAseguradora = ""
        End Try
        If IdAseguradora <> "1" Then Exit Sub

        If System.IO.Directory.Exists(RutaArchivo) = False And RutaArchivo <> "" Then
            MsgBox("La ruta destino para el archivo de envío es inválida.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim Archivo As System.IO.FileStream
            Dim Linea As String = "", num As Integer = 0
            If RutaArchivo = "" Then RutaArchivo = "C:"
            Dim Ruta As String = RutaArchivo & "\" & Format(Date.Now, "ddMMyyyyhhmmss") & ".txt"
            Dim Tipo As String = "", Tipo3 As String = ""
            Archivo = System.IO.File.Create(Ruta)
            Dim dtReclamos As DataTable
            Dim fila As DataRow
            Dim sql As String = "", NumReclamos As Integer = 0, CodTipoReclamo As String = "", Gasto As String = ""
            sql = "  select s.IdSiniestroAseguradora, s.IdSiniestro "
            sql &= " , s.IdProducto"
            sql &= " , e.IdCertificado"
            sql &= " , s.IdBien"
            sql &= " , s.FechaPresentado"
            sql &= " , s.FechaOcurrido"
            sql &= " ,s.DescripcionSiniestro"
            sql &= " ,(select sum(ValorPresentado) from SiniestrosDetalle as d where d.IdPoliza = e.IdPoliza and d.IdProducto = e.IdProducto and d.IdCertificado = e.IdCertificado and d.IdSiniestro = e.IdSiniestro ) as Valor"
            sql &= " ,isnull((select top 1 descripciongastos from SiniestrosDetalle as d where d.IdPoliza = e.IdPoliza and d.IdProducto = e.IdProducto and d.IdCertificado = e.IdCertificado and d.IdSiniestro = e.IdSiniestro order by d.iddetalle),'') as TipoGasto"
            sql &= " , s.AmbitoSiniestro"
            sql &= " , isnull((select top 1 cast(DescripcionBien as varchar(200)) from PolizasBienes as b where b.IdPoliza = s.IdPoliza and b.IdProducto = s.IdProducto and b.IdCertificado = s.IdCertificado and b.NombreBien = 'CARNET'),e.IdCertificado) as Carnet"

            sql &= " ,s.IdPoliza"
            sql &= " ,p.NombreCliente as Contratante"
            sql &= " ,c.NombreCliente as Asegurado"
            sql &= " ,s.NombrePresentaReclamo as Dependiente"
            sql &= " ,isnull(s.TotalCoaseguro,0.0) as TotalCoaseguro"
            sql &= " , (select top 1 d.Dato from (select row_number() OVER(PARTITION BY b1.idproducto, b1.idpoliza, b1.idcertificado order BY b1.idproducto, b1.idpoliza, b1.idcertificado, b1.IdBien) as IdBien , b1.DescripcionBien as Dato from polizasbienes as b1 where b1.idpoliza = s.idpoliza and b1.idproducto = s.idproducto and b1.idcertificado = s.idcertificado and b1.nombrebien = 'FECHA NAC.') as d where d.idbien = s.idbien) as FechaNac"
            sql &= ", (select top 1 pg.descripcion from SiniestrosDetalle as sd inner join ProductosSinGastos as pg on pg.idgasto = sd.iddetalle and pg.idproducto = sd.idproducto where sd.IdPoliza = s.IdPoliza and sd.IdProducto = s.IdProducto and sd.IdCertificado = s.IdCertificado and sd.IdSiniestro = s.IdSiniestro and pg.descripcion is not null) as TipoGasto "
            sql &= " from EnviosSiniestrosDetalle as e "
            sql &= " inner join Siniestros as s on s.IdPoliza = e.IdPoliza and s.IdProducto = e.IdProducto and s.IdCertificado = e.IdCertificado and s.IdSiniestro = e.IdSiniestro"
            sql &= " inner join Polizas as p on p.idpoliza = s.idpoliza and p.idproducto = s.idproducto"
            sql &= " inner join PolizasCertificados as c on c.idpoliza = s.idpoliza and c.idproducto = s.idproducto and c.idcertificado = s.idcertificado"
            sql &= " where e.IdEnvio = " & dbStr(IdEnvio)
            dtReclamos = StiGlobalConn.ObtenerDataset(sql).Tables(0)

            For Each fila In dtReclamos.Rows
                If dbData(fila, "IdProducto") = "VCMH-ACSA" Or dbData(fila, "IdProducto") = "PSM-ACSA" Then
                    NumReclamos += 1
                    CodTipoReclamo = "CU" 'por defecto 
                    Gasto = dbData(fila, "TipoGasto").Trim.ToUpper
                    If Gasto Like "*LABORATORIO*" Then CodTipoReclamo = "DG"
                    If Gasto Like "*RAYOS*" Then CodTipoReclamo = "DG"
                    If Gasto Like "*HOSPITAL*" Then CodTipoReclamo = "SH"
                    If Gasto Like "*HONORARIOS MEDICOS EN HOSPITAL*" Then CodTipoReclamo = "SP"
                    If Gasto Like "*MEDICINA*" Then CodTipoReclamo = "ME"
                    
                    Tipo = "0" 'por defecto GM
                    Tipo3 = "GM"
                    If dbData(fila, "AmbitoSiniestro") = "D" Or dbData(fila, "IdSiniestro").Trim.ToUpper Like "*DENTAL*" Or dbData(fila, "IdSiniestro").Trim.ToUpper Like "*ORTODONCIA*" Or dbData(fila, "IdSiniestro").Trim.ToUpper Like "*ENDODONCIA*" Or dbData(fila, "IdSiniestro").Trim.ToUpper Like "*PROFILAXIS*" Or dbData(fila, "IdSiniestro").Trim.ToUpper Like "*EXTRACCIONES*" Then
                        Tipo = "1"
                        Tipo3 = "DE"
                    End If

                    '1) modelo 1 cargas desde el prog. de fox
                    ''Linea = PE(dbData(fila, "IdSiniestro"), 15, , TipoRelleno.RellenarDerecha) & " " & PE(dbData(fila, "Carnet"), 8, , TipoRelleno.RellenarDerecha) & " " & PE(dbData(fila, "IdBien"), 1, , TipoRelleno.RellenarDerecha) & " " & PE(Format(CDate(dbData(fila, "FechaPresentado")), "Short Date"), 10, , TipoRelleno.RellenarDerecha) & " " & PE(Format(CDate(dbData(fila, "FechaOcurrido")), "Short Date"), 10, , TipoRelleno.RellenarDerecha) & " " & PE(dbData(fila, "DescripcionSiniestro"), 100, , TipoRelleno.RellenarDerecha) & " " & PE(dbData(fila, "Valor"), 10, , TipoRelleno.RellenarIzquierda) & " " & PE(Tipo, 1, , TipoRelleno.RellenarDerecha) & vbCrLf

                    '2) modelo 2 cargas de rpn
                    ''Linea = ""
                    ''Linea &= "|" & dbData(fila, "Carnet")
                    ''Linea &= "|" & dbData(fila, "IdBien") 'clave
                    ''Linea &= "|" & IdEnvio
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & dbData(fila, "Contratante")
                    ''Linea &= "|" & dbData(fila, "IdPoliza")
                    ''Linea &= "|" & dbData(fila, "Asegurado")
                    ''Linea &= "|" & dbData(fila, "Dependiente")
                    ''Linea &= "|" & CodTipoReclamo 'tiporeclamo (todo como consulta externa CU/ ME:Medicamentos)
                    ''Linea &= "|" & GlobalCodCliente & "_" & dbData(fila, "IdSiniestro").Trim
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & dbData(fila, "Asegurado") 'proveedor/siempre se le pagará al titular
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & dbData(fila, "TotalCoaseguro") 'coaseguro
                    ''Linea &= "|" & dbData(fila, "Valor")
                    ''Linea &= "|" & "" 'iddiagnostico ???
                    ''Linea &= "|" & dbData(fila, "DescripcionSiniestro")
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & CDate(dbData(fila, "FechaOcurrido")).ToString("dd/MM/yyyy")
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & CDate(dbData(fila, "FechaNac")).ToString("dd/MM/yyyy")
                    ''Linea &= "|" & dbData(fila, "Valor")
                    ''Linea &= "|" & dbData(fila, "Valor")
                    ''Linea &= "|" & "0.00"
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea &= "|" & ""
                    ''Linea = """" & Linea & """"

                    '3) modelo 3 cargas desde la web genericos
                    Linea = dbData(fila, "IdPoliza")
                    Linea &= ";" & dbData(fila, "Carnet")
                    Linea &= ";" & CDate(dbData(fila, "FechaNac")).ToString("dd/MM/yyyy")
                    Linea &= ";" & CDate(dbData(fila, "FechaOcurrido")).ToString("dd/MM/yyyy")
                    Linea &= ";" & "0.00"
                    Linea &= ";" & dbData(fila, "Valor")
                    Linea &= ";" & Replace(dbData(fila, "DescripcionSiniestro"), ";", " ")
                    Linea &= ";" & Tipo3
                    Linea &= ";" & dbData(fila, "IdSiniestro") & vbCrLf

                    Archivo.Write(System.Text.ASCIIEncoding.ASCII.GetBytes(Linea), 0, System.Text.ASCIIEncoding.ASCII.GetByteCount(Linea))
                End If
            Next
            Archivo.Close()
            If NumReclamos = 0 Then
                Try
                    System.IO.File.Delete(Ruta)
                Catch ex As Exception

                End Try
            Else
                MsgBox("Se ha generado el archivo de envía a ACSA: " & Ruta, MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            MsgBox("Error al crear el archivo de envio: " & ex.ToString, MsgBoxStyle.Information, "AVISO...")
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If txtIdEnvio.Text <> "" Then
                Me.Cursor = Cursors.WaitCursor
                Call ImprimirEnvioSiniestro(txtIdEnvio.Valor)
            Else
                MsgBox("Primero debe guardar el envío.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnGenerarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarArchivo.Click
        If Me.txtIdEnvio.Text.Trim = "" Then
            MsgBox("El envío debe ser almacenado previamente.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Call GenerarEnvio(txtIdEnvio.Valor, txtRutaArchivo.Valor)
    End Sub

    Private Sub btnRetiraReclamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiraReclamo.Click

        If MsgBox("¿Está Seguro de Remover los reclamos marcados del envío.?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If
iniciar_borrado:
        For Fila As Integer = 0 To Me.VistaReclamos.RowCount - 1
            If Fila >= 0 And Me.VistaReclamos.GetRowCellValue(Fila, "Marcar") = True Then
                Try
                    Dim IdPoliza As String = VistaReclamos.GetRowCellValue(Fila, "IdPoliza")
                    Dim IdProducto As String = VistaReclamos.GetRowCellValue(Fila, "IdProducto")
                    Dim IdCertificado As String = VistaReclamos.GetRowCellValue(Fila, "IdCertificado")
                    Dim IdSiniestro As String = VistaReclamos.GetRowCellValue(Fila, "IdSiniestro")


                    'desmarcamos el reclamo
                    Dim sql As String = ""
                    sql = " update siniestros "
                    sql &= " set IdEnvio = NULL "
                    sql &= " from siniestros"
                    sql &= " where IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and IdCertificado = " & dbStr(IdCertificado) & " and IdSiniestro = " & dbStr(IdSiniestro)
                    StiGlobalConn.SQLExecute(sql)

                    'retiramos la fila
                    VistaReclamos.DeleteRow(Fila)
                    VistaReclamos.RefreshData()
                    Me.GridReclamos.Refresh()
                    GoTo iniciar_borrado

                Catch ex As Exception
                    msgError(ex)
                End Try
            End If
        Next
        VistaReclamos.Focus()

    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Me.VistaReclamos.PostEditor()
    End Sub

    Private Sub VistaReclamos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaReclamos.Click
        Try
            Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = VistaReclamos.CalcHitInfo(VistaReclamos.GridControl.PointToClient(MousePosition))
            If info.Column.FieldName = "Marcar" Then
                Me.Cursor = Cursors.WaitCursor
                Dim Valor1 As Boolean = VistaReclamos.GetRowCellValue(0, "Marcar")
                Valor1 = Not Valor1
                For NF As Integer = 0 To Me.VistaReclamos.RowCount - 1
                    If NF Mod 25 = 0 Then Application.DoEvents()
                    VistaReclamos.SetRowCellValue(NF, "Marcar", Valor1)
                Next
            End If
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class
