Imports Utilerias.Genericas

Public Class CGPolizasMan

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
            Me.txtNombreCliente.Focus()
        End If
    End Sub

    Private Sub btnAgregarGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGestion.Click
        Try
            Dim Id As Integer = clSeguros.ObtenerID("Gestion.Id")
            Me.AgregarFilaGrid(VistaGestiones)
            Dim Fila As Integer = VistaGestiones.FocusedRowHandle
            Me.VistaGestiones.SetRowCellValue(Fila, "IdGestion", Id)
            Me.VistaGestiones.SetRowCellValue(Fila, "TipoGestion", "P")
            Me.VistaGestiones.SetRowCellValue(Fila, "FechaGestion", Date.Today)
            Me.VistaGestiones.SetRowCellValue(Fila, "IdUsuario", StiGlobalConn.User)
            Me.VistaGestiones.SetRowCellValue(Fila, "FechaGrabacion", Date.Now)

            Me.VistaGestiones.UpdateCurrentRow()

            RegistrarLogOferta(Me.txtIdPoliza.Text, "", Id, "Creación de una Gestión de Seguimiento", txtNombreCliente.Valor, "")


        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGestion.Click
        Try
            Me.EliminarFilaGrid(VistaGestiones)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnGestionOutlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionOutlook.Click
        Try
            Dim FilaGes As Integer = VistaGestiones.FocusedRowHandle
            If FilaGes >= 0 Then

                Dim FechaGes As String
                Try
                    FechaGes = CDate(VistaGestiones.GetRowCellValue(FilaGes, "FechaProximaGestion")).ToShortDateString
                Catch ex As Exception
                    FechaGes = ""
                End Try
                If FechaGes = "" Then
                    MsgBox("Debe especificar la fecha de próxima gestión.", MsgBoxStyle.Information, "AVISO...")
                Else

                    Dim Fecha As DateTime = CDate(FechaGes)
                    Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)
                    If Fecha <= Date.Today Then
                        MsgBox("La fecha de próxima gestión es menor a la fecha actual. La cita no puede ser almacenada", MsgBoxStyle.Information, "AVISO...")
                        Exit Sub
                    End If

                    'buscaremos nombre, telefono del cliente 
                    Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                    Dim Aseguradora As String = "", TelAse As String = "", ReclamoAseg As String = "", Poliza As String = "", Reclamo As String = "", FechaOcurrido As String = "", FechaPresentado As String = ""
                    Try
                        sql = "  select "
                        sql &= " (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                        sql &= " ,c.EMail"
                        sql &= " ,cp.IdPoliza "
                        sql &= " from cGPolizas as cp"
                        sql &= " left join Clientes as c on c.idcliente = cp.idcliente"
                        sql &= " where cp.IdOferta = " & dbStr(txtIdPoliza.Valor)
                        Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                        Cliente = txtNombreCliente.Valor
                        Telefono = dbData(fila, "Telefono")
                        Correo = dbData(fila, "EMail")
                        TelAse = dbData(fila, "TelefonoAseg")
                        Poliza = dbData(fila, "IdPoliza")
                    Catch ex As Exception

                    End Try

                    Dim res As String = AgregarCitaOutlook("Gestión - Oferta ", "", VistaGestiones.GetRowCellValue(FilaGes, "Comentarios") & vbCrLf _
                                                           & "#Oferta: " & Poliza & vbCrLf _
                                                           & "Cliente :" & Cliente & vbCrLf & Telefono & vbCrLf _
                                                           & Correo, Inicio, Inicio.AddHours(1))
                    If res <> "" Then
                        MsgBox("No es posible agregar al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                    Else
                        MsgBox("la cita ha sido agregada al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                    End If
                End If
            Else
                MsgBox("Debe Seleccionar la gestión a calendarizar.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.InitialDirectory = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Documento)
                Me.VistaDoc.SetRowCellValue(Fila, "Archivo", System.IO.Path.GetFileName(Documento))
                Me.VistaDoc.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            FolderBrowserDialog1.SelectedPath = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            Dim Carpeta As String = ""
            FolderBrowserDialog1.ShowDialog()
            Carpeta = FolderBrowserDialog1.SelectedPath
            If Carpeta <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Carpeta)
                Me.VistaDoc.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDoc() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                If CInt(VistaDoc.GetRowCellValue(I, "IdDocumento")) > Id Then
                    Id = CInt(VistaDoc.GetRowCellValue(I, "IdDocumento"))
                End If
            Catch ex As Exception

            End Try

        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDoc.Click
        Try
            Me.EliminarFilaGrid(VistaDoc)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub VistaDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaDoc.DoubleClick
        Try
            Dim fila As Integer = VistaDoc.FocusedRowHandle
            If fila >= 0 Then
                Dim Doc As String = Me.VistaDoc.GetRowCellValue(fila, "Documento")
                If Doc <> "" Then
                    Dim esCarpeta As String = ""
                    Try
                        esCarpeta = System.IO.Path.GetExtension(Doc)
                    Catch ex As Exception
                        esCarpeta = ""
                    End Try
                    If esCarpeta = "" Then
                        System.Diagnostics.Process.Start(Doc)
                    Else
                        If System.IO.File.Exists(Doc) = True Then
                            ''Shell(Doc, AppWinStyle.NormalFocus)
                            System.Diagnostics.Process.Start(Doc)
                        Else
                            MsgBox("El documentos no se encuentra en la ruta especificada.", MsgBoxStyle.Information, "AVISO...")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub IncluirDocumentosAutomaticos()
        'rutina que incluye los documentos automaticos de una ruta.
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Ofertas")
        Dim existe As Boolean
        If txtIdPoliza.Text <> "" And RutaBase <> "" Then
            If System.IO.Directory.Exists(RutaBase & "\" & txtIdPoliza.Text) = True Then
                ControlNotificacion.Caption = "Buscando Archivos Nuevos en Carpeta" : Application.DoEvents()
                Dim Archivos As DataTable = ObtenerArchivosCarpeta(RutaBase & "\" & txtIdPoliza.Text)
                Dim FilArchivo As DataRow
                For Each FilArchivo In Archivos.Rows
                    'verificamos si ya existe
                    existe = False
                    For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If Trim(UCase(VistaDoc.GetRowCellValue(NA, "Documento"))) = Trim(UCase(dbData(FilArchivo, "Archivo"))) Then
                            existe = True
                        End If
                    Next
                    If existe = False Then
                        Dim Id As Integer = ObtenerIDDoc()
                        Me.AgregarFilaGrid(VistaDoc, True, False)
                        Dim Fila As Integer = VistaDoc.FocusedRowHandle
                        Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                        Me.VistaDoc.SetRowCellValue(Fila, "Documento", dbData(FilArchivo, "Archivo"))
                        Me.VistaDoc.SetRowCellValue(Fila, "Directorio", dbData(FilArchivo, "Carpeta"))
                        Me.VistaDoc.UpdateCurrentRow()
                    End If
                Next
            End If

            '17/01/2012
            'los documentos que ya no existen los removemos
            ControlNotificacion.Caption = "Borramos Archivos que ya no existen en Carpeta" : Application.DoEvents()
            Try
                Dim RutaArchivo As String = "", Atributos As System.IO.FileAttributes
INICIO_VALIDA:
                For NDO As Integer = 0 To VistaDoc.DataRowCount - 1
                    Try
                        RutaArchivo = VistaDoc.GetRowCellValue(NDO, "Documento")
                        If System.IO.Path.GetExtension(RutaArchivo) = "" Then
                            If System.IO.Directory.Exists(RutaArchivo) = False Then
                                VistaDoc.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            End If
                        Else
                            If System.IO.File.Exists(RutaArchivo) = False Then
                                VistaDoc.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            Else
                                ''verificamos que no sea un archivo oculto o del sistema
                                Atributos = System.IO.File.GetAttributes(RutaArchivo)
                                If (Atributos And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Or (Atributos And IO.FileAttributes.System) = IO.FileAttributes.System Then
                                    VistaDoc.DeleteRow(NDO)
                                    GoTo INICIO_VALIDA
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                Next

            Catch ex As Exception

            End Try
            ControlNotificacion.Caption = "" : Application.DoEvents()
        End If
    End Sub

    Private Sub TabPoliza_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabPoliza.SelectedPageChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            If e.Page.Name.Trim.ToUpper = "PAGDOCUMENTOS" Then
                If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
                    'cargamos documentos nuevos
                    Call IncluirDocumentosAutomaticos()
                End If
                Call CompletarNombreArchivos()
            End If
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CompletarNombreArchivos()
        Dim dtDoc As DataTable
        Me.blnCargandoRegistro = True
        ControlNotificacion.Caption = "Completando Nombres de Archivos" : Application.DoEvents()
        Try
            dtDoc = GridDoc.DataSource
            dtDoc.Columns.Add("Archivo", System.Type.GetType("System.String"))
            dtDoc.Columns.Add("Directorio", System.Type.GetType("System.String"))
            GridDoc.DataSource = dtDoc
        Catch ex As Exception

        End Try
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Ofertas")

        For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                Me.VistaDoc.SetRowCellValue(NA, "Archivo", System.IO.Path.GetFileName(VistaDoc.GetRowCellValue(NA, "Documento")))
                Me.VistaDoc.SetRowCellValue(NA, "Directorio", Replace(System.IO.Path.GetDirectoryName(VistaDoc.GetRowCellValue(NA, "Documento")), RutaBase, ""))
            Catch ex As Exception

            End Try
        Next
        Me.blnCargandoRegistro = False
        ControlNotificacion.Caption = "" : Application.DoEvents()
    End Sub

    Private Sub CGPolizasMan_AntesDeEliminar(ByRef Cancel As Boolean) Handles Me.AntesDeEliminar
        Try
            'eliminaremos los registros relacionados de certificados
            StiGlobalConn.SQLExecute("delete from CGPolizasDocumentos where IdOferta = " & dbStr(txtIdPoliza.Valor))
            StiGlobalConn.SQLExecute("delete from CGPolizasOfertas where IdOferta = " & dbStr(txtIdPoliza.Valor))
            RegistrarLogOferta(txtIdPoliza.Text, "", "", "Eliminación de Oferta", txtNombreCliente.Valor, "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CGPolizasMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar

        'verificamos obligatorios antes de asignar
        Try
            'primero validamos si no hay campos obligatorios vacios
            Dim ErrObligatorios As String = ValidarCamposObligatorios(Me)
            If ErrObligatorios <> "" Then
                If MostrarMensajes Then
                    Cancel = True
                    MsgBox("Existen campos obligatorios que deben ser completados: " & ErrObligatorios, MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try

        Dim TipoIdOferta As String = clSeguros.ObtenerDBParametros("Oferta.IdAutomatico")
        If TipoIdOferta.Trim.ToUpper = "S" And txtIdPoliza.Valor.ToString.Trim = "" Then
            Me.txtIdPoliza.Valor = clSeguros.ObtenerIDTabla("CPolizas", "cast(IdPoliza as int)")
        End If

        If TipoIdOferta.Trim.ToUpper = "A" And txtIdPoliza.Valor.ToString.Trim = "" Then
            'formato especial de adrisa
            Dim NumOferta As String = clSeguros.ObtenerID("Oferta.Id." & Date.Today.Year.ToString.Trim)
            NumOferta = NumOferta & "-" & Date.Today.Year.ToString.Trim
            Me.txtIdPoliza.Valor = NumOferta
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Modificando And Me.VistaGestiones.RowCount = 0 And GlobalCodCliente = "2120000" Then
            Cancel = True
            MsgBox("Debe registrar al menos una Gestión para la oferta...", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

    End Sub

    Private Sub CGPolizasMan_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And GlobalCodCliente = "2120000" Then
            'sol. enviar un correo 

            Dim Destinatarios As String = clSeguros.ObtenerDBParametros("Oferta.Correo.Notifica")
            If Destinatarios <> "" Then
                clSeguros.EnviarCorreoNotificaciones(Destinatarios, "", "", "OFERTA " & Me.txtIdPoliza.Text & " " & Me.cboIdRamo.Descripcion & " " & Me.txtNombreCliente.Text, "Se generó correlativo de oferta según y se guardó la información básica del cliente, tal como se detalla a continuación: " & vbCrLf & vbCrLf & vbCrLf & "FECHA Y HORA DE CREACIÓN: " & Me.cboFechaGraba.Text & vbCrLf & vbCrLf & "CORRELATIVO DE OFERTA: " & Me.txtIdPoliza.Text & vbCrLf & vbCrLf & "NOMBRE DEL CLIENTE: " & Me.txtNombreCliente.Text & vbCrLf & vbCrLf & "RAMO: " & Me.cboIdRamo.Descripcion & vbCrLf & vbCrLf & "DESCRIPCION DE BIEN A ASEGURAR:" & Me.txtBienes.Text & vbCrLf & vbCrLf & "NOMBRE DEL VENDEDOR: " & Me.cboNegocioPor.Descripcion & vbCrLf & vbCrLf & "REFERIDO POR: " & Me.txtReferidoPor.Text & vbCrLf & vbCrLf & "USUARIO: " & cboUsuarioCreacion.Descripcion, False)
            End If

            'ademos si hay un parameto iniciamos un flujo de oferta
            Dim NuevoFlujo As String = ""
            clFlujos.IniciarFlujoCotizaciones(Me.txtIdPoliza.Text, NuevoFlujo)

        End If

        Me.TabPoliza.Enabled = True

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                RegistrarLogOferta(Me.txtIdPoliza.Text, "", "", "Nueva Oferta", txtNombreCliente.Valor, "")
            Case enEstadoRegistro.Modificando
                RegistrarLogOferta(Me.txtIdPoliza.Text, "", "", "Modificación de Oferta", txtNombreCliente.Valor, "")
        End Select

    End Sub

    Private Sub CGPolizasMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VistaDoc.OptionsBehavior.Editable = False
        Me.cboDepartamento.OcultarColumna(1)
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.cboUsuarioCreacion.Valor = StiGlobalConn.User
                Me.cboEstadoPoliza.Valor = "PENDIENTE"
                Me.cboTipoDeducible.Valor = "V"
                Me.TabPoliza.Enabled = False

                Dim TipoIdOferta As String = clSeguros.ObtenerDBParametros("Oferta.IdAutomatico")
                If TipoIdOferta.Trim.ToUpper <> "" Then
                    Me.txtIdPoliza.SoloLectura = True
                End If
                cboFechaGraba.Valor = Date.Now

            Case enEstadoRegistro.Modificando
                Me.cboUsuarioModificacion.Valor = StiGlobalConn.User
        End Select
        Call CompletarNombreArchivos()


        Dim IdCliente As String = clSeguros.ObtenerIdCliente()
        Select Case GlobalCodCliente
            Case "2120000"
                cboNegocioPor.Visible = True
                cboNegocioPor.Obligatorio = True

            Case Else
                cboNegocioPor.Visible = False
                cboNegocioPor.Obligatorio = False
        End Select

        'completamos combos del grid
        Dim dtProductos As DataTable = StiGlobalConn.ObtenerDataset("select IdProducto as Id, Descripcion as Producto from Productos").Tables(0)
        cboProducto2.ValueMember = "Id"
        cboProducto2.DisplayMember = "Producto"
        cboProducto2.AutoSearchColumnIndex = 1
        cboProducto2.DataSource = dtProductos
        cboProducto2.PopulateColumns()
        cboProducto2.Columns(0).Visible = False

        Dim dtFP As New DataTable, FilFP As DataRow
        dtFP.Columns.Add("Id", System.Type.GetType("System.String"))
        dtFP.Columns.Add("FormaPago", System.Type.GetType("System.String"))
        FilFP = dtFP.NewRow : FilFP("Id") = "MENSUAL" : FilFP("FormaPago") = "Mensual" : dtFP.Rows.Add(FilFP)
        FilFP = dtFP.NewRow : FilFP("Id") = "ANUAL" : FilFP("FormaPago") = "Anual" : dtFP.Rows.Add(FilFP)
        FilFP = dtFP.NewRow : FilFP("Id") = "TRIMESTRAL" : FilFP("FormaPago") = "Trimestral" : dtFP.Rows.Add(FilFP)
        FilFP = dtFP.NewRow : FilFP("Id") = "SEMESTRAL" : FilFP("FormaPago") = "Semestral" : dtFP.Rows.Add(FilFP)

        cboFormaPago2.ValueMember = "Id"
        cboFormaPago2.DisplayMember = "FormaPago"
        cboFormaPago2.AutoSearchColumnIndex = 1
        cboFormaPago2.DataSource = dtFP
        cboFormaPago2.PopulateColumns()
        cboFormaPago2.Columns(0).Visible = False

        Dim dtFE As New DataTable, FilFE As DataRow
        dtFE.Columns.Add("Id", System.Type.GetType("System.String"))
        dtFE.Columns.Add("FormaEnvio", System.Type.GetType("System.String"))
        FilFE = dtFE.NewRow : FilFE("Id") = "M" : FilFE("FormaEnvio") = "Por E-mail" : dtFE.Rows.Add(FilFE)
        FilFE = dtFE.NewRow : FilFE("Id") = "C" : FilFE("FormaEnvio") = "Por Carta" : dtFE.Rows.Add(FilFE)

        cboFormaEnvio2.ValueMember = "Id"
        cboFormaEnvio2.DisplayMember = "FormaEnvio"
        cboFormaEnvio2.AutoSearchColumnIndex = 1
        cboFormaEnvio2.DataSource = dtFE
        cboFormaEnvio2.PopulateColumns()
        cboFormaEnvio2.Columns(0).Visible = False

        Me.cboUsuarioCreacion.SoloLectura = True
        Me.cboUsuarioModificacion.SoloLectura = True
        Me.cboFechaGraba.SoloLectura = True
        Me.vistaCotizaciones.OptionsBehavior.Editable = False


        dim dtAseg as dataTable = stiglobalconn.ObtenerDataSet("Select IdAseguradora as Id, Nombre as Aseguradora from Aseguradoras").tables(0)
        cboIdAseguradora.ValueMember = "Id"
        cboIdAseguradora.DisplayMember = "Aseguradora"
        cboIdAseguradora.AutoSearchColumnIndex = 1
        cboIdAseguradora.DataSource = dtAseg
        cboIdAseguradora.PopulateColumns()
        cboIdAseguradora.Columns(0).Visible = False


        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Dim FechaCaja As DateTime = clSeguros.ObtenerDBParametros("Fecha.Ofertas")
            Dim AjusteFinSemana As Integer = 0
            If CDate(clSeguros.ObtenerFechaServidor().ToShortDateString).DayOfWeek = DayOfWeek.Monday Then AjusteFinSemana = 1

            Dim dtRecibosCon As Integer = StiGlobalConn.ObtenerDataset("select count(*) from DiasOfertas where FechaOfertas <= " & dbFec(DateAdd(DateInterval.Day, -1, CDate(clSeguros.ObtenerFechaServidor().ToShortDateString))) & " and FechaCierra is null").Tables(0).Rows(0).Item(0)
            'If dtRecibosCon > 0 Then
            '    'no permitir si ya cortes de más de dos días
            '    MsgBox("Existen cierres de ofertas pendientes de más de dos días.", MsgBoxStyle.Information, "AVISO...")
            '    btnGuardar.Enabled = False : btnNuevo.Enabled = False
            'Else
            If dtRecibosCon = 0 Then
                If FechaCaja <> Date.Today And FechaCaja.Year > 2000 Then
                    'si el día siguiente de caja no está abierto, lo abrimos.
                    FechaCaja = FechaCaja.AddDays(1)
                    While FechaCaja.DayOfWeek = DayOfWeek.Saturday Or FechaCaja.DayOfWeek = DayOfWeek.Sunday
                        FechaCaja = FechaCaja.AddDays(1)
                    End While
                    RegistrarAperturaOfertas(FechaCaja)
                    Dim ResFecha As String = clSeguros.ActualizarDBParametros("Fecha.Ofertas", FechaCaja)
                End If
            End If
            
            Dim dtRecibosPen As DataTable = StiGlobalConn.ObtenerDataset("select top 1 FechaOfertas from DiasOfertas where FechaOfertas <= " & dbFec(DateAdd(DateInterval.Day, -1, CDate(clSeguros.ObtenerFechaServidor().ToShortDateString))) & " and FechaCierra is null order by FechaOfertas desc").Tables(0)
            If dtRecibosPen.Rows.Count > 0 And Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                MsgBox("Existen cierres de Ofertas pendientes, debe cerrar antes el día: " & CDate(dtRecibosPen.Rows(0).Item("FechaOfertas")).ToShortDateString(), MsgBoxStyle.Information, "AVISO...")
                btnGuardar.Enabled = False
                btnNuevo.Enabled = False
            Else
                FechaCaja = clSeguros.ObtenerFechaServidor()
                RegistrarAperturaOfertas(FechaCaja)
                Dim ResFecha As String = clSeguros.ActualizarDBParametros("Fecha.Ofertas", FechaCaja)
            End If
            'End If
        End If

    End Sub

    Private Sub btnAgregarCot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCot.Click
        Dim frmCot As New CGPolizasCotizacion
        frmCot.dbTabla = "CGPolizasOfertas"
        frmCot.Permiso = Me.Permiso
        frmCot.ClavesNuevo = Me.txtIdPoliza.Valor
        frmCot.EstadoRegistro = enEstadoRegistro.Adicionando
        frmCot.STIConn = StiGlobalConn
        frmCot.NombreCliente = txtNombreCliente.Valor
        If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
            frmCot.MdiParent = Me.MdiParent
            frmCot.Show()
        Else
            frmCot.ShowDialog(Me)
            Call CargarCotizaciones()
        End If


        'Try
        '    Me.AgregarFilaGrid(vistaCotizaciones)
        'Catch ex As Exception
        '    MsgBox("Error al agregar el registro." & vbCrLf & ex.Message)
        'End Try
    End Sub

    Private Sub CargarCotizaciones()
        gridCotizaciones.DataSource = Nothing
        gridCotizaciones.Refresh()
        Dim sql As String = ""
        Try
            sql = "  select IdOferta,IdCotizacion,IdProducto,PlanCotizado,SumaAsegurada,PrimaNeta,Total,NumeroCuotas,IdFormaPago,FormaEnvio,NumeroCarta,FechaEnvio,IdAseguradora"
            sql &= " from CGPolizasOfertas"
            sql &= " where IdOferta = " & dbStr(txtIdPoliza.Valor)
            Dim dtCotizaciones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtCotizaciones.Rows.Count > 0 Then
                gridCotizaciones.DataSource = dtCotizaciones
                gridCotizaciones.Refresh()
            End If
            Me.vistaCotizaciones.OptionsBehavior.Editable = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarCot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCot.Click
        Try
            Dim Fila As Integer = vistaCotizaciones.FocusedRowHandle
            If Fila >= 0 Then
                If MsgBox("¿Desea Eliminar la cotización seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                    RegistrarLogOferta(txtIdPoliza.Text, vistaCotizaciones.GetRowCellValue(Fila, "IdCotizacion"), "", "Eliminación de Cotización", txtNombreCliente.Valor, "")
                    StiGlobalConn.SQLExecute("delete from CGPolizasOfertas where IdOferta = " & dbStr(vistaCotizaciones.GetRowCellValue(Fila, "IdOferta")) & " and IdCotizacion = " & dbStr(vistaCotizaciones.GetRowCellValue(Fila, "IdCotizacion")))
                End If

                Call CargarCotizaciones()
            End If
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        Try
            Me.txtVigenciaHasta.Valor = CDate(Me.txtVigenciaDesde.Valor).AddYears(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ValidaRechazo()
        If Me.txtMotivoCancelacion.Text <> "" Or Me.txtFechaCancelacion.Text <> "" Then
            txtMotivoCancelacion.Obligatorio = True
            txtFechaCancelacion.Obligatorio = True
        Else
            txtMotivoCancelacion.Obligatorio = False
            txtFechaCancelacion.Obligatorio = False
        End If
    End Sub

    Private Sub txtMotivoCancelacion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtMotivoCancelacion.ValueChangeOnExit
        Call ValidaRechazo()
    End Sub

    Private Sub txtFechaCancelacion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaCancelacion.ValueChangeOnExit
        Call ValidaRechazo()
    End Sub

    Private Sub vistaCotizaciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles vistaCotizaciones.DoubleClick
        Try
            Dim fila As Integer
            fila = vistaCotizaciones.FocusedRowHandle
            If fila >= 0 Then
                Dim frmCot As New CGPolizasCotizacion
                frmCot.dbTabla = "CGPolizasOfertas"
                frmCot.STIConn = StiGlobalConn
                frmCot.Permiso = Me.Permiso
                frmCot.dbCondicion = "IdOferta = " & dbStr(txtIdPoliza.Valor) & " and IdCotizacion = " & dbStr(vistaCotizaciones.GetRowCellValue(fila, "IdCotizacion"))
                frmCot.ClavesNuevo = Me.txtIdPoliza.Valor
                If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
                    frmCot.MdiParent = Me.MdiParent
                    frmCot.Show()
                Else
                    frmCot.ShowDialog(Me)
                    Call CargarCotizaciones()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboEstadoPoliza_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboEstadoPoliza.ValueChangeOnExit
        Select Case cboEstadoPoliza.Valor.ToString
            Case "ACEPTADA"
                txtFechaAceptada.Obligatorio = True

            Case "RECHAZADA"
                txtFechaCancelacion.Obligatorio = True
                txtMotivoCancelacion.Obligatorio = True

            Case Else
                txtFechaCancelacion.Obligatorio = False
                txtMotivoCancelacion.Obligatorio = False
                txtFechaAceptada.Obligatorio = False

        End Select
    End Sub

End Class
