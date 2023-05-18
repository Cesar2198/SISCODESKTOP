Imports System.Windows.Forms
Imports System.Drawing
Imports Utilerias.Genericas
Imports System.ComponentModel

Public Class stiMantenimiento

    Public STIConn As Conectividad.Funciones
    Public dbTabla As String = ""
    Public dbCondicion As String = ""
    Private NombrePrimerControl As String = ""
    Private ColumnasBusqueda As String = ""
    Private AliasColumnasBusqueda As String = ""
    Public AbrirEnEstadoEliminacion As Boolean = False
    Public ModoGuardarComo As Boolean = False
    Public ClavesNuevo As String = ""
    Private Cancel As Boolean
    Public Event DespuesDeGuardar()
    Public Event DespuesDeGuardarSinTransaccion()
    Public Event DespuesDeGuardarFinal()
    Public Event DespuesDeEliminar()
    Public Event AntesDeGuardar(ByRef Cancel As Boolean)
    Public Event AntesDeEliminar(ByRef Cancel As Boolean)
    Public Event AntesDeCargarFormulario()
    Public Event DespuesDeCargarRegistro()
    Public Event DespuesDeCargarCombos()
    Public blnCargandoRegistro As Boolean = False
    Public blnRegistroModificado As Boolean = False
    Public blnCambiosRealizados As Boolean = False
    Public MostrarMensajes as Boolean = True


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Public Sub New(ByVal FiltroRegistro As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.dbCondicion = FiltroRegistro
    End Sub

    Public Enum enEstadoRegistro
        Nada = 0
        Adicionando = 1
        Modificando = 2
        Eliminando = 3
    End Enum

    Public EstadoRegistro As enEstadoRegistro = enEstadoRegistro.Adicionando

    Private AyudaIdL As Integer = 0
    <Category("Administración Formularios"), Description("Determina el número de ID de la ayuda en el archivo de ayuda.")> _
    Public Property AyudaId() As Integer
        Get
            Return AyudaIdL
        End Get
        Set(ByVal value As Integer)
            AyudaIdL = value
        End Set
    End Property

    Private UsarCodigoHeredadoL As Boolean = True
    <Category("Administración Formularios"), Description("Determina si se utilizará el código heredado para administrar registros")> _
    Public Property UsarCodigoHeredado() As Boolean
        Get
            Return UsarCodigoHeredadoL
        End Get
        Set(ByVal value As Boolean)
            UsarCodigoHeredadoL = value
        End Set
    End Property

    Private PermisoL As String = ""
    <Category("Administración Formularios"), Description("Determina el nivel de permiso para aditar registros Lectura, Escritura, Control Total")> _
    Public Property Permiso() As String
        Get
            Return PermisoL
        End Get
        Set(ByVal value As String)
            PermisoL = value
        End Set
    End Property

    Private ErrorGuardarL As Boolean = False
    <Category("Administración Formularios"), Description("Determina si se ha producido un error al editar registros")> _
    Public ReadOnly Property ErrorGuardar() As Boolean
        Get
            Return ErrorGuardarL
        End Get
    End Property

    Private SalirAlGrabarL As Boolean = False
    <Category("Administración Formularios"), Description("Determina si se cerrará el formulario al guardar un registro")> _
    Public Property SalirAlGrabar() As Boolean
        Get
            Return SalirAlGrabarL
        End Get
        Set(ByVal value As Boolean)
            SalirAlGrabarL = value
        End Set
    End Property

    Dim SeguirAlGrabarNuevoL As Boolean = False
    <Category("Administración Formularios"), Description("Determina si se cerrará el formulario al grabar nuevo registro")> _
    Public Property SeguirAlGrabarNuevo() As Boolean
        Get
            Return SeguirAlGrabarNuevoL
        End Get
        Set(ByVal value As Boolean)
            SeguirAlGrabarNuevoL = value
        End Set
    End Property

    Dim SeguirAlGrabarActualizarL As Boolean = False
    <Category("Administración Formularios"), Description("Determina si se saldrá solo al actualizar un registro")> _
    Public Property SeguirAlGrabarActualizar() As Boolean
        Get
            Return SeguirAlGrabarActualizarL
        End Get
        Set(ByVal value As Boolean)
            SeguirAlGrabarActualizarL = value
        End Set
    End Property

    Dim FocusPrimerControlL As Boolean = True
    <Category("Administración Formularios"), Description("Determina si se propondrá el focus en el primer control del formulario.")> _
    Public Property FocusPrimerControl() As Boolean
        Get
            Return FocusPrimerControlL
        End Get
        Set(ByVal value As Boolean)
            FocusPrimerControlL = value
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If UsarCodigoHeredadoL = True Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click
        Call funLanzarAyuda(Me, AyudaId)
    End Sub

    'Private Sub LanzarAyuda()
    '    'lanzaremos la ayuda del formulario
    '    Try
    '        Dim RHC As New Utilerias.RoboHelpAPI.RoboHelp_CSH
    '        Dim Prog As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly
    '        RHC.RH_ShowLocalHelp(Me, System.IO.Path.GetDirectoryName(Prog.Location) & "\" & System.IO.Path.GetFileNameWithoutExtension(Prog.Location) & ".chm", 1, 556)
    '    Catch ex As Exception
    '        MsgBox("Error al lanzar la ayuda." & ex.ToString, MsgBoxStyle.Information, "AVISO...")
    '    End Try
    'End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If UsarCodigoHeredadoL = True Then
            Cancel = False
            RaiseEvent AntesDeGuardar(Cancel)
            If Cancel = False Then
                GuardarRegistros()
            End If
        End If
    End Sub

    Private Sub GuardarRegistros()

        ErrorGuardarL = True
        Try
            'primero validamos si no hay campos obligatorios vacios
            Dim ErrObligatorios As String = ValidarCamposObligatorios(Me)
            If ErrObligatorios <> "" Then
                if MostrarMensajes then 
                    MsgBox("Existen campos obligatorios que deben ser completados: " & ErrObligatorios, MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try

        ''verificaremos si el registro ya existe en el sistema
        Try
            If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                Dim existe As Integer = STIConn.ObtenerDataset("select count(*) from " & dbTabla & " where " & ObtenerCondicionWhere(Me)).Tables(0).Rows(0).Item(0)
                If existe > 0 Then
                    MsgBox("El registro que intenta ingresar ya existe en el sistema.", MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try

        Try

            Dim sql As String = ""
            ''comenzamos la transaccion
            STIConn.SQLExecute("BEGIN TRANSACTION")
            Select Case Me.EstadoRegistro
                Case enEstadoRegistro.Adicionando
                    sql = ObtenerInsertStatement(Me)
                    Call RegistrarLog("A")
                Case enEstadoRegistro.Modificando
                    sql = ObtenerUpdateStatement(Me)
                    Call RegistrarLog("M")
            End Select

            STIConn.SQLExecute(sql)

            If Me.blnRegistroModificado = True Then blnCambiosRealizados = True

            ''ahora que se ha grabado la tabla principal veremos si hay tablas hijas, esto esta en los grids
            Call GuardarTablasRelacionadas(Me)

            RaiseEvent DespuesDeGuardar()

            Me.blnRegistroModificado = False

            ''cerramos la transaccion
            STIConn.SQLExecute("COMMIT TRANSACTION")
            ErrorGuardarL = False

        Catch ex As Exception
            ''cualquier error cancela la transaccion
            STIConn.SQLExecute("ROLLBACK TRANSACTION")
            ErrorGuardarL = True
            if MostrarMensajes then MsgBox("Error al actualizar los registros." & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "ERROR...")
            Exit Sub
        End Try

        RaiseEvent DespuesDeGuardarSinTransaccion()

        If SalirAlGrabarL = True Then
            'notificamos el proceso de exito
            Select Case Me.EstadoRegistro
                Case enEstadoRegistro.Adicionando
                    if MostrarMensajes then MsgBox("Se ha ingresado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
                Case enEstadoRegistro.Modificando
                    if MostrarMensajes then MsgBox("Se ha actualizado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
                Case enEstadoRegistro.Eliminando
                    if MostrarMensajes then MsgBox("Se ha eliminado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
            End Select


            Me.Close()
            Exit Sub
        End If

        'si todo esta bien ingresamos otro registro
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                If SeguirAlGrabarNuevoL = False Then
                    Call btnNuevo_Click(btnNuevo, New System.EventArgs)
                    if MostrarMensajes then MsgBox("Se ha ingresado el registro con éxito, ahora puede ingresar el siguiente.", MsgBoxStyle.Information, "AVISO...")
                Else
                    'nos quedamos con el registro en modo actulizar
                    Me.EstadoRegistro = enEstadoRegistro.Modificando
                    'bloqueamos campos llaves
                    Call BloquearCamposLLave(Me)
                    'notificamos
                    if MostrarMensajes then MsgBox("Se ha ingresado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
                End If
            Case enEstadoRegistro.Modificando
                If Me.SeguirAlGrabarActualizarL = False Then
                    Me.EstadoRegistro = enEstadoRegistro.Nada
                    Call Me.LimpiarCampos(Me)
                    Call Me.EstadoEntradas(False, Me)
                    Call Me.EstadoBotones()
                    if MostrarMensajes then MsgBox("Se ha modificado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
                    Me.Close()
                Else
                    'nos quedamos con el registro en modo actulizar
                    Me.EstadoRegistro = enEstadoRegistro.Modificando
                    if MostrarMensajes then MsgBox("Se ha modificado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
                End If
        End Select
        RaiseEvent DespuesDeGuardarFinal()

    End Sub

    Private Sub GuardarTablasRelacionadas(ByRef Control As System.Windows.Forms.Control)
        For Each ctlForm In Control.Controls
            If TypeOf ctlForm Is STIControles.stiGrid Then
                If ctlForm.NombreTabla <> "" Then
                    ''mandamos a ingresar los datos del grid
                    GuardarRegistrosTablaRelacionada(ctlForm)
                End If
            Else
                If ctlForm.Controls.count > 0 Then
                    GuardarTablasRelacionadas(ctlForm)
                End If
            End If
        Next
    End Sub

    Private Sub GuardarRegistrosTablaRelacionada(ByRef ctrlGrid As STIControles.stiGrid)
        Try
            ''1) primero eliminamos los registros de la tabla hija por completo las llaves del padre las tiene la tabla hija
            STIConn.SQLExecute("delete from " & ctrlGrid.NombreTabla & " where " & ObtenerCondicionWhere(Me))

            ''2) ahora ingresamos los registros
            Dim OPT As String = ""
            Dim sql As String = "", campos As String = "", valores As String = ""
            Dim VistaGrid As DevExpress.XtraGrid.Views.Grid.GridView = ctrlGrid.Views(0)

            'el filtro hace que no se almacenen las filas removemos el filtro temporalmente
            Dim FiltroGrid As String = VistaGrid.ActiveFilterString
            VistaGrid.ActiveFilterString = ""
            For NF As Integer = 0 To VistaGrid.DataRowCount - 1
                sql = "" : campos = "" : valores = ""
                For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaGrid.Columns
                    Try
                        OPT = Col.Tag
                    Catch ex As Exception
                        OPT = ""
                    End Try
                    If OPT <> "NOSAVE" Then
                        campos &= ", " & Col.FieldName
                        Dim Tipo As String = Col.ColumnType.Name.ToLower
                        If Tipo Like "*int*" Or Tipo Like "*long*" Then
                            valores &= ", " & dbInt(VistaGrid.GetRowCellValue(NF, Col.FieldName))
                        ElseIf Tipo Like "*string*" Or Tipo Like "*char*" Or Tipo Like "*text*" Or Tipo Like "*memo*" Then
                            valores &= ", " & dbStr(VistaGrid.GetRowCellValue(NF, Col.FieldName))
                        ElseIf Tipo Like "*nume*" Or Tipo Like "*deci*" Or Tipo Like "*float*" Or Tipo Like "*curre*" Or Tipo Like "*money*" Then
                            valores &= ", " & dbNum(VistaGrid.GetRowCellValue(NF, Col.FieldName))
                        ElseIf Tipo Like "*bit*" Or Tipo Like "*bool*" Or Tipo Like "*object*" Then
                            valores &= ", " & dbBool(VistaGrid.GetRowCellValue(NF, Col.FieldName))
                        ElseIf Tipo Like "*date*" Then
                            If VistaGrid.GetRowCellValue(NF, Col.FieldName) Is System.DBNull.Value Then
                                valores &= ", " & dbFec(VistaGrid.GetRowCellValue(NF, Col.FieldName))
                            Else
                                Dim FechaHora As DateTime = VistaGrid.GetRowCellValue(NF, Col.FieldName)
                                If FechaHora.Hour + FechaHora.Minute + FechaHora.Second > 0 Then
                                    valores &= ", " & dbFec(FechaHora, "1")
                                Else
                                    valores &= ", " & dbFec(FechaHora)
                                End If
                            End If

                        End If
                    End If
                Next
                If campos <> "" Then
                    sql = "insert into " & ctrlGrid.NombreTabla & "(" & campos.Substring(2) & ") values(" & valores.Substring(2) & ")"
                    STIConn.SQLExecute(sql)
                End If
            Next
            VistaGrid.ActiveFilterString = FiltroGrid
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerCondicionWhere(ByRef Control As System.Windows.Forms.Control, Optional ByRef res As String = "", Optional ByVal Recursivo As Boolean = False) As String
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.NombreCampo <> "" Then
                    If ControlL.CampoEsLlave = True Then
                        res &= " and " & ControlL.NombreCampo & " = "
                        Select Case ControlL.TipoDato
                            Case STIControles.stiTextBox.TipoContenido.Texto
                                res &= dbStr(ControlL.Valor)
                            Case STIControles.stiTextBox.TipoContenido.Numero
                                res &= dbNum(ControlL.Valor)
                            Case STIControles.stiTextBox.TipoContenido.Fecha
                                res &= dbFec(ControlL.Valor)
                        End Select
                    End If
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ObtenerCondicionWhere(ControlL, res, True)
                End If
            End If
        Next
        If res <> "" And Recursivo = False Then
            'quitamos la primera and
            res = res.Substring(5)
        End If
        Return res
    End Function

    Private Function ObtenerInsertStatement(ByRef Control As System.Windows.Forms.Control, Optional ByRef Campos As String = "", Optional ByRef Valores As String = "", Optional ByVal Recursivo As Boolean = False) As String
        Dim res As String = ""
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                'Nombre de campo en blanco son para calculos, y con NOSAVE es por los autonumericos.-
                If ControlL.NombreCampo <> "" And ControlL.Tag <> "NOSAVE" Then ' And ControlL.Visible = True Then
                    Campos &= ", " & ControlL.NombreCampo
                    Select Case ControlL.TipoDato
                        Case STIControles.stiTextBox.TipoContenido.Texto
                            Valores &= ", " & dbStr(ControlL.Valor)
                        Case STIControles.stiTextBox.TipoContenido.Numero
                            Valores &= ", " & dbNum(ControlL.Valor)
                        Case STIControles.stiTextBox.TipoContenido.Fecha
                            Dim FechaHora As DateTime = ControlL.Valor
                            If FechaHora.Hour + FechaHora.Minute + FechaHora.Second > 0 Then
                                Valores &= ", " & dbFec(FechaHora, "1")
                            Else
                                Valores &= ", " & dbFec(ControlL.Valor)
                            End If
                    End Select
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ObtenerInsertStatement(ControlL, Campos, Valores, True)
                End If
            End If
        Next
        If Campos <> "" And Recursivo = False Then
            'quitamos la primera coma
            Campos = Campos.Substring(2) : Valores = Valores.Substring(2)
            res = "insert into " & Me.dbTabla & " (" & Campos & ") values (" & Valores & ")"
        End If
        Return res
    End Function

    Private Function ObtenerUpdateStatement(ByRef Control As System.Windows.Forms.Control, Optional ByRef Campos As String = "", Optional ByRef Condicion As String = "", Optional ByVal Recursivo As Boolean = False) As String
        Dim res As String = ""
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.NombreCampo <> "" And ControlL.Tag <> "NOSAVE" Then 'And ControlL.Visible = True Then
                    If ControlL.CampoEsLlave = True Then
                        Condicion &= " and " & ControlL.NombreCampo & " = "
                    Else
                        Campos &= ", " & ControlL.NombreCampo & " = "
                    End If
                    Select Case ControlL.TipoDato
                        Case STIControles.stiTextBox.TipoContenido.Texto
                            If ControlL.CampoEsLlave = True Then
                                Condicion &= dbStr(ControlL.Valor)
                            Else
                                Campos &= dbStr(ControlL.Valor)
                            End If
                        Case STIControles.stiTextBox.TipoContenido.Numero
                            If ControlL.CampoEsLlave = True Then
                                Condicion &= dbNum(ControlL.Valor)
                            Else
                                Campos &= dbNum(ControlL.Valor)
                            End If
                        Case STIControles.stiTextBox.TipoContenido.Fecha
                            Dim FechaHora As DateTime = ControlL.Valor
                            If FechaHora.Hour + FechaHora.Minute + FechaHora.Second > 0 Then
                                If ControlL.CampoEsLlave = True Then
                                    Condicion &= dbFec(ControlL.Valor, "1")
                                Else
                                    Campos &= dbFec(ControlL.Valor, "1")
                                End If
                            Else
                                If ControlL.CampoEsLlave = True Then
                                    Condicion &= dbFec(ControlL.Valor)
                                Else
                                    Campos &= dbFec(ControlL.Valor)
                                End If
                            End If
                    End Select
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ObtenerUpdateStatement(ControlL, Campos, Condicion, True)
                End If
            End If
        Next

        If Campos <> "" And Recursivo = False Then
            'quitamos la primera coma
            Campos = Campos.Substring(2) : Condicion = Condicion.Substring(5)
            res = "update " & Me.dbTabla & " set " & Campos & " where " & Condicion
        End If
        Return res
    End Function

    Public Function ValidarCamposObligatorios(ByRef Control As System.Windows.Forms.Control) As String
        Dim res As String = ""
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.Obligatorio = True And ControlL.Text = "" And ControlL.Visible = True Then
                    res &= ControlL.LabelText & "; "
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    res &= ValidarCamposObligatorios(ControlL)
                End If
            End If
        Next
        Return res
    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim res As String = ""
        If UsarCodigoHeredadoL = True Then
            If Me.EstadoRegistro = enEstadoRegistro.Modificando Or Me.EstadoRegistro = enEstadoRegistro.Eliminando Then
                If MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "PREGUNTA...") = MsgBoxResult.No Then
                    Exit Sub
                End If
                Dim resEvento As Boolean = False
                RaiseEvent AntesDeEliminar(resEvento)
                If resEvento = True Then
                    Exit Sub
                End If
                res = EliminarRegistros()
                If res = "" Then
                    'no hay error
                    Me.Close()
                    'If Me.EstadoRegistro = enEstadoRegistro.Eliminando Or SalirAlGrabarL = True Then
                    '    Me.Close()
                    'Else
                    '    LimpiarCampos(Me)
                    '    Me.EstadoRegistro = enEstadoRegistro.Nada
                    '    Call EstadoBotones()
                    '    Call EstadoEntradas(False, Me)
                    'End If
                End If

            Else
                MsgBox("Debe seleccionar un registro existente.", MsgBoxStyle.Information, "AVISO...")
            End If
        End If
    End Sub

    Private Function EliminarRegistros() As String
        Dim res As String = ""
        Try
            Dim sql As String = ""
            ''comenzamos una transaacion

            STIConn.SQLExecute("BEGIN TRANSACTION")

            ''primero tenemos que eliminar las tablas relacionadas
            Dim CondicionWhere As String = ObtenerCondicionWhere(Me)
            Call EliminarTablasRelacionadas(Me, CondicionWhere)

            sql = ObtenerDeleteStatement(Me)
            STIConn.SQLExecute(sql)

            Me.blnCambiosRealizados = True

            Call RegistrarLog("E")


            ''confirmamos la transaccion si no hay errores
            STIConn.SQLExecute("COMMIT TRANSACTION")

            RaiseEvent DespuesDeEliminar()

            MsgBox("Se ha eliminado el registro con éxito.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            ''si hay error anulamos la transaccion
            STIConn.SQLExecute("ROLLBACK TRANSACTION")
            res = ex.Message
            MsgBox("Error al eliminar el registro." & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "ERROR...")
        End Try
        Return res
    End Function

    Private Sub EliminarTablasRelacionadas(ByRef Control As System.Windows.Forms.Control, ByRef CondicionWhere As String)
        For Each ctlForm In Control.Controls
            If TypeOf ctlForm Is STIControles.stiGrid Then
                If ctlForm.NombreTabla <> "" Then
                    ''mandamos borramos todos los datos relacionados 
                    STIConn.SQLExecute("delete from " & ctlForm.NombreTabla & " where " & CondicionWhere)
                End If
            Else
                If ctlForm.Controls.Count > 0 Then
                    EliminarTablasRelacionadas(ctlForm, CondicionWhere)
                End If
            End If
        Next
    End Sub

    Private Function ObtenerDeleteStatement(ByVal Control As System.Windows.Forms.Control, Optional ByRef Condicion As String = "", Optional ByVal Recursivo As Boolean = False) As String
        Dim res As String = ""
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.NombreCampo <> "" And ControlL.Tag <> "NOSAVE" Then
                    If ControlL.CampoEsLlave = True Then
                        Select Case ControlL.TipoDato
                            Case STIControles.stiTextBox.TipoContenido.Texto
                                Condicion &= " and " & ControlL.NombreCampo & " = " & dbStr(ControlL.Valor)
                            Case STIControles.stiTextBox.TipoContenido.Numero
                                Condicion &= " and " & ControlL.NombreCampo & " = " & dbNum(ControlL.Valor)
                            Case STIControles.stiTextBox.TipoContenido.Fecha
                                Condicion &= " and " & ControlL.NombreCampo & " = " & dbFec(ControlL.Valor)
                        End Select
                    End If
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ObtenerDeleteStatement(ControlL, Condicion, True)
                End If
            End If
        Next
        If Condicion <> "" And Recursivo = False Then
            'quitamos el primer and
            Condicion = Condicion.Substring(5)
            res = "delete from " & Me.dbTabla & " where " & Condicion
        End If
        Return res
    End Function

    Public Sub SeleccionarRegistro(ByVal Condicion As String)
        Try
            EstadoEventos(Me, False)
            If Condicion.Trim <> "" Then
                blnCargandoRegistro = True
                Call LimpiarCampos(Me)
                Dim sql As String = ""
                sql = "select * from " & Me.dbTabla & " where " & Condicion
                Dim filData As DataRow = STIConn.ObtenerDataset(sql).Tables(0).Rows(0)
                Call LlenarCampos(Me, filData)

                ''ahora cargamos la informacion de los grid's

                Dim CondicionWhere As String = ObtenerCondicionWhere(Me)
                LlenarTablasRelacionadas(Me, CondicionWhere)

                RaiseEvent DespuesDeCargarRegistro()

                Me.EstadoRegistro = enEstadoRegistro.Modificando
                Call EstadoBotones()
                blnCargandoRegistro = False
            End If
            EstadoEventos(Me, True)
        Catch ex1 As System.IndexOutOfRangeException
            MsgBox("El registro especificado no existe.", MsgBoxStyle.Critical, "ERROR...")
            Call LimpiarCampos(Me)
            Me.EstadoRegistro = enEstadoRegistro.Nada
            Call EstadoBotones()
            Me.EstadoEntradas(False, Me)

        Catch ex As Exception
            MsgBox("Error al obtener los registros." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
            Call LimpiarCampos(Me)
            Me.EstadoRegistro = enEstadoRegistro.Nada
            Call EstadoBotones()
            Me.EstadoEntradas(False, Me)
        End Try
    End Sub

    Private Sub LlenarTablasRelacionadas(ByRef Control As System.Windows.Forms.Control, ByRef CondicionWhere As String)
        For Each ctlForm In Control.Controls
            If TypeOf ctlForm Is STIControles.stiGrid Then
                If ctlForm.NombreTabla <> "" Then
                    Dim ColAdicional As String = ""
                    Try
                        ColAdicional = ctlForm.ColumnasAdicionales
                    Catch ex As Exception
                        ColAdicional = ""
                    End Try

                    Dim dsTbl As DataSet = STIConn.ObtenerDataset("select * " & ColAdicional & " from " & ctlForm.NombreTabla & " where " & CondicionWhere)
                    ctlForm.DataSource = dsTbl.Tables(0)
                    ctlForm.Refresh()
                End If
            Else
                If ctlForm.Controls.Count > 0 Then
                    LlenarTablasRelacionadas(ctlForm, CondicionWhere)
                End If
            End If
        Next
    End Sub

    Private Sub LlenarCampos(ByRef Control As System.Windows.Forms.Control, ByRef Fila As DataRow)
        'recibimos la fila con los datos que se desean cargar
        For Each ControlL In Control.Controls
            Try
                If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                    ControlL.Valor = dbData(Fila, ControlL.NombreCampo)
                    If ControlL.CampoEsLlave = True Then
                        ControlL.SoloLectura = True
                    End If
                Else
                    If ControlL.Controls.Count > 0 Then
                        LlenarCampos(ControlL, Fila)
                    End If
                End If
            Catch ex As Exception
                'no produciremos error
            End Try
        Next
    End Sub

    Public Sub BloquearCamposLLave(ByRef Control As System.Windows.Forms.Control)
        For Each ControlL In Control.Controls
            Try
                If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                    If ControlL.CampoEsLlave = True Then
                        ControlL.SoloLectura = True
                    End If
                Else
                    If ControlL.Controls.Count > 0 Then
                        BloquearCamposLLave(ControlL)
                    End If
                End If
            Catch ex As Exception
                'no produciremos error
            End Try
        Next
    End Sub

    Public Sub LimpiarCampos(ByRef Control As System.Windows.Forms.Control)
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                ControlL.Valor = ""
            ElseIf TypeOf ControlL Is STIControles.stiGrid Then
                ControlL.DataSource = Nothing : ControlL.Refresh()
            ElseIf ControlL.Controls.Count > 0 Then
                LimpiarCampos(ControlL)
            End If
        Next
    End Sub

    Public Sub EstadoEventos(ByRef Control As System.Windows.Forms.Control, ByVal Habilitar As Boolean)
        For Each ControlL In Control.Controls
            Try
                If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                    ControlL.HabilitarEvento = Habilitar
                ElseIf ControlL.Controls.Count > 0 Then
                    EstadoEventos(ControlL, Habilitar)
                End If
            Catch ex As Exception

            End Try
            
        Next
    End Sub

    Private Sub EstadoBotones()
        Me.btnNuevo.Enabled = True : Me.btnGuardar.Enabled = True
        Me.btnAyuda.Enabled = True
        Me.btnEliminar.Enabled = True : Me.btnBuscar.Enabled = True
        Me.btnSalir.Enabled = True
        Me.btnGuardarComo.Enabled = True

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.btnEliminar.Enabled = False
                Me.btnGuardarComo.Enabled = False
            Case enEstadoRegistro.Nada
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.btnGuardarComo.Enabled = False
            Case enEstadoRegistro.Eliminando
                Me.btnNuevo.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnBuscar.Enabled = False
                Me.btnGuardarComo.Enabled = False
                EstadoEntradas(False, Me)
        End Select

        Select Case Me.PermisoL
            Case "L", "I"
                'permisos de lectura
                Me.btnNuevo.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnGuardarComo.Enabled = False
                Call DeshabilitarBotonesExtra(Me)
            Case "W"
                'un permiso especial de modificación que no permite eliminar
                Me.btnEliminar.Enabled = False
        End Select
    End Sub

    Public Sub EstadoEntradas(ByVal Habilitadas As Boolean, ByRef Control As System.Windows.Forms.Control)
        If Me.PermisoL = "L" Or Me.PermisoL = "I" Then
            ''solo lectura no habilita las entradas
            Habilitadas = False
        End If
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                ControlL.SoloLectura = Not Habilitadas
            ElseIf TypeOf ControlL Is STIControles.stiGrid Then
                Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
                Vista = ControlL.Views(0)
                Vista.OptionsBehavior.Editable = True
                For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.Columns
                    ColVista.OptionsColumn.ReadOnly = Not Habilitadas
                Next


            ElseIf ControlL.Controls.Count > 0 Then
                EstadoEntradas(Habilitadas, ControlL)
            End If
        Next
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If Me.UsarCodigoHeredadoL = True Then
            Call LimpiarCampos(Me)
            Call EstadoEntradas(True, Me)
            Me.EstadoRegistro = enEstadoRegistro.Adicionando
            Call PrepararGridNuevo(Me)
            Call EstadoBotones()
            Me.blnRegistroModificado = False
            If FocusPrimerControlL = True Then Call FocoEnPrimerControl()
        End If
    End Sub

    Private Sub stiMantenimiento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If FocusPrimerControlL = True Then Call FocoEnPrimerControl()
    End Sub

    Private Sub stiMantenimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.blnRegistroModificado = True And (Me.EstadoRegistro = enEstadoRegistro.Adicionando Or Me.EstadoRegistro = enEstadoRegistro.Modificando) And Me.dbTabla <> "" Then
            If MsgBox("El registro no ha sido guardado, perdería los cambios realizados." & vbCrLf & "¿Desea Salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If

        Try
            Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
            If RecordarVista.Trim.ToUpper = "S" Then
                AlmacenarVistas(Me)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub stiMantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.EsModoDisenio = False Then
            If Me.UsarCodigoHeredadoL = True Then
                RaiseEvent AntesDeCargarFormulario()

                Dim strParModalidadGrabar As String = ObtenerDBParametros("Modalidad.Grabar").ToString.Trim.ToUpper
                Select Case strParModalidadGrabar
                    Case "1" 'salirse al grabar
                        Me.SalirAlGrabar = True
                        Me.SeguirAlGrabarNuevo = False
                        Me.SeguirAlGrabarActualizar = False

                    Case "2" 'continuar con el registro
                        Me.SalirAlGrabar = False
                        Me.SeguirAlGrabarNuevo = True
                        Me.SeguirAlGrabarActualizar = True

                    Case "3"  'guardar y seguir con uno nuevo
                        Me.SalirAlGrabar = False
                        Me.SeguirAlGrabarNuevo = False
                        Me.SeguirAlGrabarActualizar = False

                End Select

                Call PrepararPersonalizacion(Me)
                Call PersonalizarCampo()
                Call PersonalizarVistas(Me)
                Call ObtenerPrimerControl(Me)
                Call ObtenerColumnasBusqueda(Me)
                Call PrepararCombos(Me)
                If dbCondicion <> "" Then
                    Call SeleccionarRegistro(dbCondicion)
                    Call ValidaPermisoDepartamento()
                    Me.EstadoEntradas(True, Me)
                    Me.BloquearCamposLLave(Me)
                    If AbrirEnEstadoEliminacion = True Then
                        Me.EstadoRegistro = enEstadoRegistro.Eliminando
                        Call EstadoBotones()
                    End If
                    If ModoGuardarComo = True Then
                        Call PrepararRegistroGuardarComo()
                    End If
                Else
                    'consideramos estado nuevo por defecto
                    Call btnNuevo_Click(sender, New System.EventArgs)
                End If

                'varificaremos si las vistas de grid están almacenadas.
                Try
                    Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
                    If RecordarVista.Trim.ToUpper = "S" Then
                        PrepararVistas(Me)
                    End If
                Catch ex As Exception

                End Try
            Else
                'solo se validarán los permisos de lectura
                Call EstadoBotones()
                Call PrepararPersonalizacion(Me)
                Call PersonalizarCampo()
                'varificaremos si las vistas de grid están almacenadas.
                Try
                    Dim RecordarVista As String = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
                    If RecordarVista.Trim.ToUpper = "S" Then
                        PrepararVistas(Me)
                    End If
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub ValidaPermisoDepartamento()
        Try
            'verificamos si el usuario tiene permisos de escritura solo de su departamento
            Dim filCliente As DataRow = STIConn.ObtenerDataset("select visibilidad, Departamento from usuarios where idusuario = " & dbStr(STIConn.User)).Tables(0).Rows(0)
            If dbData(filCliente, "visibilidad") = "L" Then
                'intentamos ubicar el campo txtIdPoliza
                Dim IdPoliza As String = ""
                For Each control As Object In Me.Controls.Find("txtidpoliza", True)
                    IdPoliza = CType(control, STIControles.stiTextBox).Valor
                Next
                Dim IdProducto As String = ""
                For Each control As Object In Me.Controls.Find("cboidproducto", True)
                    IdProducto = CType(control, STIControles.stiComboBox).Valor
                Next
                If IdPoliza <> "" And IdProducto <> "" Then
                    Dim Departamento As String = STIConn.ObtenerDataset("select isnull(Departamento,'') from polizas where idpoliza = " & dbStr(IdPoliza) & "and idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
                    If Departamento <> "" And dbData(filCliente, "Departamento") <> "" Then
                        If Departamento <> dbData(filCliente, "Departamento") Then
                            Me.Permiso = "L"
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrepararRegistroGuardarComo()
        'preparamos el registro para la modalidad guardare como, habilitamos las llaves y las dejamos en blanco
        Me.EstadoRegistro = enEstadoRegistro.Adicionando
        Call LimpiarLlaves(Me)
    End Sub

    Private Sub LimpiarLlaves(ByRef Control As System.Windows.Forms.Control)
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.NombreCampo <> "" Then
                    If ControlL.CampoEsLlave = True Then
                        ControlL.Valor = ""
                        ControlL.SoloLectura = False
                    End If
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    LimpiarLlaves(ControlL)
                End If
            End If
        Next
    End Sub

    Private Sub PrepararGridNuevo(ByRef Control As System.Windows.Forms.Control)
        ''Los grid deben ser cargados con un datatable aun cuando No tengan registros, mandamos una condicion falsa para retornar tabla En blanco
        Dim dsTbl As New DataSet
        For Each ctlForm In Control.Controls
            If TypeOf ctlForm Is STIControles.stiGrid Then
                If ctlForm.NombreTabla <> "" Then
                    dsTbl = STIConn.ObtenerDataset("select * from " & ctlForm.NombreTabla & " where 1=2")
                    ctlForm.DataSource = dsTbl.Tables(0)
                    ctlForm.Refresh()
                End If
            Else
                If ctlForm.Controls.Count > 0 And Not (TypeOf ctlForm Is STIControles.stiTextBox Or TypeOf ctlForm Is STIControles.stiMemo Or TypeOf ctlForm Is STIControles.stiComboBox Or TypeOf ctlForm Is STIControles.stiGridComboBox) Then
                    PrepararGridNuevo(ctlForm)
                End If
            End If
        Next
    End Sub

    Private Sub ObtenerPrimerControl(ByRef Control As System.Windows.Forms.Control, Optional ByRef Menor As Integer = 9999)
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If Menor > ControlL.TabIndex Then
                    Menor = ControlL.TabIndex
                    NombrePrimerControl = ControlL.Name
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ObtenerPrimerControl(ControlL, Menor)
                End If
            End If
        Next
    End Sub

    Public Sub FocoEnPrimerControl()
        Try
            'intentamos poner el foco en el primer control.
            Me.Controls(NombrePrimerControl).Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ObtenerColumnasBusqueda(ByRef Control As System.Windows.Forms.Control)
        Dim llaves As String = "", normales As String = ""
        Dim allaves As String = "", anormales As String = ""
        'obtenemos las columnas
        ObtenerColumnasBusquedaR(Control, llaves, normales, allaves, anormales)

        ColumnasBusqueda = llaves & normales
        'quitamos la primera coma
        If ColumnasBusqueda <> "" Then
            ColumnasBusqueda = ColumnasBusqueda.Substring(2)
        End If
        AliasColumnasBusqueda = allaves & anormales
        'quitamos la primera coma
        If AliasColumnasBusqueda <> "" Then
            AliasColumnasBusqueda = AliasColumnasBusqueda.Substring(2)
        End If

    End Sub

    Private Sub ObtenerColumnasBusquedaR(ByRef Control As System.Windows.Forms.Control, ByRef llaves As String, ByRef normales As String, ByRef allaves As String, ByRef anormales As String)
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.CampoBusqueda = True Then
                    If ControlL.CampoEsLlave = True Then
                        llaves &= ", " & ControlL.NombreCampo
                        allaves &= ", " & ControlL.LabelText
                    Else
                        normales &= ", " & ControlL.NombreCampo
                        anormales &= ", " & ControlL.LabelText
                    End If
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ObtenerColumnasBusquedaR(ControlL, llaves, normales, allaves, anormales)
                End If
            End If
        Next
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If UsarCodigoHeredadoL = True Then
            Dim Cols As String = ColumnasBusqueda
            If Cols = "" Then
                MsgBox("No se han definido campos para búsqueda.", MsgBoxStyle.Exclamation, "AVISO...")
            Else
                Dim Fbus As New stiBuscarRegistro
                Fbus.Tabla = Me.dbTabla
                Fbus.STIConn = Me.STIConn
                Fbus.Columnas = Cols
                Fbus.ColAlias = AliasColumnasBusqueda
                Fbus.Filtro = ""
                Fbus.ShowDialog()
                Dim res As String = CStr(Fbus.Tag)
                Fbus.Dispose()
                If res <> "" Then
                    Me.SeleccionarRegistro(res)
                End If
            End If
        End If
    End Sub

    Private Sub PrepararCombos(ByRef Control As System.Windows.Forms.Control)
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiComboBox Then
                Try
                    ControlL.StringConection = Me.STIConn.ObtenerOledbConnectionString()
                    ControlL.Llenar_Combo()
                Catch ex As Exception

                End Try
            Else
                If ControlL.Controls.Count > 0 Then
                    PrepararCombos(ControlL)
                End If
            End If
        Next
        RaiseEvent DespuesDeCargarCombos()
    End Sub

    Private Function EsModoDisenio() As Boolean
        Dim Res As Boolean
        Try
            If Not Me.Site Is Nothing And Me.Site.DesignMode = True Then
                Res = True
            Else
                Res = False
            End If
        Catch ex As Exception
            Res = False
        End Try
        Return Res
    End Function

    Private Function ValidarCamposLlavesObligatorios(ByRef Control As System.Windows.Forms.Control, Optional ByRef res As String = "") As String
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.CampoEsLlave = True And ControlL.Text = "" Then
                    res &= ControlL.LabelText & ", "
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    ValidarCamposLlavesObligatorios(ControlL, res)
                End If
            End If
        Next
        Return res
    End Function

    Public Sub AgregarFilaGrid(ByRef VistaGrid As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal PasarPermiso As Boolean = False, Optional ByVal RegistraModificacion As Boolean = True)
        Try
            If Me.PermisoL = "L" And PasarPermiso = False Then Exit Sub
            Dim ValidaLlaves As String = ValidarCamposLlavesObligatorios(Me)

            If ValidaLlaves <> "" Then
                Throw New Exception("Debe especificar los campos claves antes de adicionar registros: " & ValidaLlaves)
                'MsgBox("Debe especificar los campos claves antes de adicionar registros: " & ValidaLlaves, MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            VistaGrid.AddNewRow()
            CompletarLlavesNuevaFila(Me, VistaGrid)
            If RegistraModificacion = True Then Me.blnRegistroModificado = True
            VistaGrid.UpdateCurrentRow()
            VistaGrid.GridControl.Focus()

        Catch ex As Exception
            Throw ex
            'MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub CompletarLlavesNuevaFila(ByRef Control As System.Windows.Forms.Control, ByRef VistaGrid As DevExpress.XtraGrid.Views.Grid.GridView)
        ''completamos los campos llaves en el grid
        For Each ControlL In Control.Controls
            If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Then
                If ControlL.CampoEsLlave = True Then
                    Try
                        VistaGrid.SetRowCellValue(VistaGrid.FocusedRowHandle, ControlL.NombreCampo, ControlL.Valor)
                    Catch ex As Exception
                        'no controlamos este error
                    End Try
                End If
            Else
                If ControlL.Controls.Count > 0 Then
                    CompletarLlavesNuevaFila(ControlL, VistaGrid)
                End If
            End If
        Next
    End Sub

    Public Sub EliminarFilaGrid(ByRef VistaGrid As DevExpress.XtraGrid.Views.Grid.GridView)
        If Me.PermisoL = "L" Or Me.PermisoL = "W" Then Exit Sub
        Dim Fila As Integer = VistaGrid.FocusedRowHandle
        If Fila >= 0 Then
            If MsgBox("¿Desea Eliminar el Registro Seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                Try
                    VistaGrid.DeleteRow(Fila)
                    Me.blnRegistroModificado = True
                    VistaGrid.GridControl.Focus()
                Catch ex As Exception
                    MsgBox("Error al borrar el registro." & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnGuardarComo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarComo.Click
        If UsarCodigoHeredadoL = True Then
            'lo que haremos es lanzar el formulario actual con los mismo campos almacenados y
            'borraremos las llaves
            If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
                Try
                    Dim tempAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly
                    Dim frm1 As Object = CType(tempAssembly.CreateInstance(stiSplit(tempAssembly.FullName, "G0,1").Trim & "." & Me.Name), System.Windows.Forms.Form)
                    frm1.dbTabla = Me.dbTabla
                    frm1.STIConn = Me.STIConn
                    frm1.Permiso = Me.PermisoL
                    frm1.dbCondicion = ObtenerCondicionWhere(Me)
                    frm1.ModoGuardarComo = True
                    Try
                        frm1.ClavesNuevo = Me.ClavesNuevo
                        frm1.blnRegistroModificado = True
                    Catch ex As Exception

                    End Try
                    frm1.ShowDialog()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Public Sub ActualizarLlavesGrid(ByRef Control As System.Windows.Forms.Control, ByVal Campo As String, ByVal Valor As Object)
        For Each ctlForm In Control.Controls
            If TypeOf ctlForm Is STIControles.stiGrid Then
                If ctlForm.NombreTabla <> "" And Campo.Trim <> "" Then
                    ''Actualizaremos las claves
                    Try
                        Dim VistaReg As DevExpress.XtraGrid.Views.Grid.GridView = CType(ctlForm, DevExpress.XtraGrid.GridControl).Views(0)
                        For I As Integer = 0 To VistaReg.DataRowCount - 1
                            VistaReg.SetRowCellValue(I, Campo, Valor)
                        Next
                    Catch ex As Exception

                    End Try
                End If
            Else
                If ctlForm.Controls.Count > 0 Then
                    ActualizarLlavesGrid(ctlForm, Campo, Valor)
                End If
            End If
        Next
    End Sub

    Private Sub RegistrarLog(ByVal Accion As String)
        Try
            Dim sql As String = ""
            sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
            sql &= dbStr(STIConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr(Accion, 1) & C & dbStr(Me.dbTabla, 25) & C & dbStr(ObtenerCondicionWhere(Me), 150) & ")"
            STIConn.SQLExecute(sql)
        Catch ex As Exception
            'no controlaremos este error
        End Try
    End Sub

    Private Function ObtenerDBParametros(ByVal IdParametro As String) As Object
        Dim Res As Object = Nothing
        Try
            Dim FilPar As DataRow = Me.STIConn.ObtenerDataset("select * from Parametros where idparametro = " & dbStr(IdParametro)).Tables(0).Rows(0)
            Select Case dbData(FilPar, "Tipo").Trim.ToUpper
                Case "N"
                    Res = CDbl(dbData(FilPar, "Valor"))
                Case "T"
                    Res = CStr(dbData(FilPar, "Cadena"))
                Case "E"
                    Res = CInt(dbData(FilPar, "Entero"))
                Case "F"
                    Res = CDate(dbData(FilPar, "Fecha"))
            End Select
        Catch ex As Exception
            Res = Nothing
        End Try
        Return Res
    End Function

    Public Sub DeshabilitarBotonesExtra(ByRef Control As System.Windows.Forms.Control)
        'existen formularios que puede tener botones extra, en modo lectura estos deben estas deshabilitados
        Try
            For Each ControlL In Control.Controls
                If TypeOf ControlL Is DevExpress.XtraEditors.SimpleButton Or TypeOf ControlL Is System.Windows.Forms.Button Then
                    Select Case ControlL.Name.Trim
                        Case "btnNuevo", "btnGuardar", "btnGuardarComo", "btnBuscar", "btnEliminar", "btnAyuda", "btnSalir"
                            'los botones locales no los tocamos
                        Case Else
                            ControlL.Enabled = False
                    End Select
                Else
                    If ControlL.Controls.Count > 0 And Not (TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiGrid Or TypeOf ControlL Is STIControles.stiGridComboBox) Then
                        DeshabilitarBotonesExtra(ControlL)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub HabilitarBotonesExtra(ByRef Control As System.Windows.Forms.Control)
        'existen formularios que puede tener botones extra, en modo lectura estos deben estas deshabilitados
        Try
            For Each ControlL In Control.Controls
                If TypeOf ControlL Is DevExpress.XtraEditors.SimpleButton Or TypeOf ControlL Is System.Windows.Forms.Button Then
                    Select Case ControlL.Name.Trim
                        Case "btnNuevo", "btnGuardar", "btnGuardarComo", "btnBuscar", "btnEliminar", "btnAyuda", "btnSalir"
                            'los botones locales no los tocamos
                        Case Else
                            ControlL.Enabled = True
                    End Select
                Else
                    If ControlL.Controls.Count > 0 And Not (TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiGrid Or TypeOf ControlL Is STIControles.stiGridComboBox) Then
                        HabilitarBotonesExtra(ControlL)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PrepararVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Then
                    Dim VistaAlmacenada As String = "", FiltroAlmacenado As String = ""
                    Try
                        VistaAlmacenada = STIConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        VistaAlmacenada = ""
                    End Try
                    Dim RecordarFiltro As String = ""
                    Try
                        RecordarFiltro = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Filtros'").Tables(0).Rows(0).Item(0)
                    Catch ex As Exception

                    End Try

                    If RecordarFiltro.Trim.ToUpper = "S" Then
                        Try
                            FiltroAlmacenado = STIConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro")).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            FiltroAlmacenado = ""
                        End Try
                    End If
                    If VistaAlmacenada <> "" Then
                        Call PrepararGrid(ControlL1.Views(0), VistaAlmacenada, FiltroAlmacenado)
                    End If
                End If
            Catch ex As Exception

            End Try

            Try
                If TypeOf ControlL1 Is DevExpress.XtraPivotGrid.PivotGridControl Then
                    Dim VistaAlmacenada As String = STIConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                    If VistaAlmacenada <> "" Then
                        Call PrepararPivot(ControlL1, VistaAlmacenada)
                    End If
                End If
            Catch ex As Exception

            End Try

            If ControlL1.Controls.Count > 0 Then
                PrepararVistas(ControlL1)
            End If
        Next
    End Sub

    Public Sub PrepararGrid(ByRef Vista As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Columnas As String, ByVal FiltroVista As String)
        'lo que se hará es mostrar las columna solicitadas y en el orden solicitado
        Try
            'primero las ocultamos
            If Columnas.Trim.Length = 0 Then Exit Sub
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In Vista.Columns
                If InStr(Columnas, Col.FieldName) > 0 Then
                    Col.Visible = True
                Else
                    Col.Visible = False
                End If
            Next
            'ahora las ordenamos
            Vista.BeginSort()
            Vista.ClearGrouping()
            Dim NumCampos As Integer = CuentaCar(Columnas, ",")
            Dim busColumna As String = "", AnchoCol As Double = 0, OrdenCol As DevExpress.Data.ColumnSortOrder = DevExpress.Data.ColumnSortOrder.None, GroupIndexCol As Integer = 0
            For I As Integer = 0 To NumCampos
                busColumna = stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G0|1").Trim
                AnchoCol = Val(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G1|1").Trim)
                OrdenCol = ObtenerColumnSortOrder(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G2|1").Trim)
                GroupIndexCol = CInt(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G3|1").Trim)

                Try
                    Vista.Columns(busColumna).VisibleIndex = I
                    Vista.Columns(busColumna).Width = AnchoCol
                    Vista.Columns(busColumna).SortOrder = OrdenCol
                    If GroupIndexCol >= 0 Then
                        Vista.Columns(busColumna).GroupIndex = GroupIndexCol
                    End If

                Catch ex As Exception

                End Try
            Next
            Vista.EndSort()
            Vista.ActiveFilterString = FiltroVista
            'autoajustamos las columans
            'Vista.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub

    Public Function ObtenerColumnSortOrder(ByVal Orden As String) As DevExpress.Data.ColumnSortOrder
        Dim res As DevExpress.Data.ColumnSortOrder
        Select Case Orden.Trim.ToUpper
            Case "A"
                res = DevExpress.Data.ColumnSortOrder.Ascending
            Case "D"
                res = DevExpress.Data.ColumnSortOrder.Descending
            Case Else
                res = DevExpress.Data.ColumnSortOrder.None
        End Select
        Return res
    End Function

    Public Sub AlmacenarVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Then
                    Dim VistaAlmacenada As String = ObtenerVista(ControlL1.Views(0))
                    If VistaAlmacenada <> "" Then
                        Dim Existe As Integer = STIConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                        If Existe > 0 Then
                            STIConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(VistaAlmacenada) & " where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name))
                        Else
                            STIConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(STIConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name) & C & dbStr(VistaAlmacenada) & ")")
                        End If
                        Dim RecordarFiltro As String = ""
                        Try
                            RecordarFiltro = STIConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Filtros'").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception

                        End Try

                        If RecordarFiltro.Trim.ToUpper = "S" Then
                            'guaradmos el filtro
                            Existe = STIConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro")).Tables(0).Rows(0).Item(0)
                            If Existe > 0 Then
                                STIConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(ControlL1.Views(0).ActiveFilterString) & " where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro"))
                            Else
                                STIConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(STIConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro") & C & dbStr(ControlL1.Views(0).ActiveFilterString) & ")")
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
            Try
                If TypeOf ControlL1 Is DevExpress.XtraPivotGrid.PivotGridControl Then
                    Dim VistaAlmacenada As String = ObtenerVistaPivot(ControlL1)
                    If VistaAlmacenada <> "" Then
                        Dim Existe As Integer = STIConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                        If Existe > 0 Then
                            STIConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(VistaAlmacenada) & " where IdUsuario = " & dbStr(STIConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name))
                        Else
                            STIConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(STIConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name) & C & dbStr(VistaAlmacenada) & ")")
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try

            If ControlL1.Controls.Count > 0 Then
                AlmacenarVistas(ControlL1)
            End If
        Next
    End Sub

    Public Function ObtenerVista(ByRef Vista As DevExpress.XtraGrid.Views.Grid.GridView) As String
        Dim res As String = ""
        Try
            For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.VisibleColumns
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                End If
            Next


            'unicamente si hay columnas visibles almacenamos las agrupadas
            If res <> "" Then
                'las agrupadas
                For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.GroupedColumns
                    If res = "" Then
                        res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                    Else
                        res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                    End If
                Next
            End If
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenerVistaPivot(ByRef Pivot As DevExpress.XtraPivotGrid.PivotGridControl) As String
        Dim res As String = ""
        Try
            For Each ColVista As DevExpress.XtraPivotGrid.PivotGridField In Pivot.Fields
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenPivot(ColVista.SortOrder) & "|" & ObtenetAreaPivot(ColVista.Area) & "|" & ColVista.AreaIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenPivot(ColVista.SortOrder) & "|" & ObtenetAreaPivot(ColVista.Area) & "|" & ColVista.AreaIndex
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenetOrdenGrid(ByVal Orden As DevExpress.Data.ColumnSortOrder) As String
        Dim res As String = ""
        Select Case Orden
            Case DevExpress.Data.ColumnSortOrder.None
                res = ""
            Case DevExpress.Data.ColumnSortOrder.Ascending
                res = "A"
            Case DevExpress.Data.ColumnSortOrder.Descending
                res = "D"
        End Select
        Return res
    End Function

    Public Function ObtenetOrdenPivot(ByVal Orden As DevExpress.XtraPivotGrid.PivotSortOrder) As String
        Dim res As String = ""
        Select Case Orden
            Case DevExpress.XtraPivotGrid.PivotSortOrder.Ascending
                res = "A"
            Case DevExpress.XtraPivotGrid.PivotSortOrder.Descending
                res = "D"
        End Select
        Return res
    End Function

    Public Function ObtenetAreaPivot(ByVal Area As DevExpress.XtraPivotGrid.PivotArea) As String
        Dim res As String = ""
        Select Case Area
            Case DevExpress.XtraPivotGrid.PivotArea.ColumnArea
                res = "C"
            Case DevExpress.XtraPivotGrid.PivotArea.DataArea
                res = "D"
            Case DevExpress.XtraPivotGrid.PivotArea.FilterArea
                res = "F"
            Case DevExpress.XtraPivotGrid.PivotArea.RowArea
                res = "R"
        End Select
        Return res
    End Function

    Public Sub PrepararPivot(ByRef Pivot As DevExpress.XtraPivotGrid.PivotGridControl, ByVal Columnas As String)
        'lo que se hará es mostrar las columna solicitadas y en el orden solicitado
        Try
            Dim NumCampos As Integer = CuentaCar(Columnas, ",")
            Dim busColumna As String = "", AnchoCol As Double = 0, OrdenCol As DevExpress.XtraPivotGrid.PivotSortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending, AreaCol As DevExpress.XtraPivotGrid.PivotArea, AreaIndex As Integer = 0
            For I As Integer = 0 To NumCampos
                busColumna = stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G0|1").Trim
                AnchoCol = Val(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G1|1").Trim)
                OrdenCol = ObtenetOrdenPivotGrid(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G2|1").Trim)
                AreaCol = ObtenerAreaPivotGrid(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G3|1").Trim)
                AreaIndex = CInt(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G4|1").Trim)
                Try
                    Pivot.Fields(busColumna).Area = AreaCol
                    Pivot.Fields(busColumna).Width = AnchoCol
                    Pivot.Fields(busColumna).SortOrder = OrdenCol
                    Pivot.Fields(busColumna).AreaIndex = AreaIndex
                    Pivot.Fields(busColumna).FilterValues.Clear()
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Function ObtenetOrdenPivotGrid(ByVal Orden As String) As DevExpress.XtraPivotGrid.PivotSortOrder
        Dim res As DevExpress.XtraPivotGrid.PivotSortOrder
        Select Case Orden
            Case "A"
                res = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending
            Case "D"
                res = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        End Select
        Return res
    End Function

    Public Function ObtenerAreaPivotGrid(ByVal Area As String) As DevExpress.XtraPivotGrid.PivotArea
        Dim res As DevExpress.Data.ColumnSortOrder
        Select Case Area.Trim.ToUpper
            Case "C"
                res = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Case "D"
                res = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Case "F"
                res = DevExpress.XtraPivotGrid.PivotArea.FilterArea
            Case "R"
                res = DevExpress.XtraPivotGrid.PivotArea.RowArea
        End Select
        Return res
    End Function
    
#Region "Personalizar Nombre de  Campos"

    Private Sub PersonalizarNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalizarNombreToolStripMenuItem.Click
        Try
            Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
            Dim Control As Object = cms.SourceControl
            Dim Forma As String = Me.Name
            Dim Campo As String = Control.Name
            Dim Nombre As String = ""
            If TypeOf Control Is STIControles.stiTextBox Or TypeOf Control Is STIControles.stiMemo Or TypeOf Control Is STIControles.stiComboBox Or TypeOf Control Is STIControles.stiGridComboBox Then
                Nombre = Control.LabelText
            End If
            If TypeOf Control Is DevExpress.XtraEditors.LabelControl Or TypeOf Control Is Label Then
                Nombre = Control.Text
            End If

            Dim FrmPerCampo As New stiPersonalizaCampo
            FrmPerCampo.Forma = Forma
            FrmPerCampo.Campo = Campo
            FrmPerCampo.Nombre = Nombre
            FrmPerCampo.STIConn = Me.STIConn
            Try
                FrmPerCampo.Obligatorio = "0"
                If Control.Obligatorio = True Then
                    FrmPerCampo.Obligatorio = "1"
                End If
            Catch ex As Exception
                FrmPerCampo.Obligatorio = ""
            End Try
            FrmPerCampo.ShowDialog()
            Call PersonalizarCampo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VolverANombreOriginalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverANombreOriginalToolStripMenuItem.Click
        Try
            Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)
            Dim Control As Object = cms.SourceControl
            Dim Forma As String = Me.Name
            Dim Campo As String = Control.Name
            Dim Nombre As String = ""
            STIConn.SQLExecute("delete from VistasCampos where forma = " & dbStr(Forma) & " and campo = " & dbStr(Campo))
            MsgBox("El cambio ha sido registrado con éxito, tendrá efecto al volver a abrir el formulario.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrepararPersonalizacion(ByRef Control As System.Windows.Forms.Control)
        Try
            'ojo solo administradores podrán hacer estos cambios
            If STIConn.UsuarioPerteneceAGrupo(STIConn.User, "ADMINISTRADORES") = False Then Exit Sub

            For Each ControlL In Control.Controls
                If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Or TypeOf ControlL Is STIControles.stiGridComboBox Or TypeOf ControlL Is Label Or TypeOf ControlL Is DevExpress.XtraEditors.LabelControl Then
                    ControlL.ContextMenuStrip = mnuCampos
                ElseIf TypeOf ControlL Is STIControles.stiGrid Then
                    AddHandler CType(ControlL.Views(0), DevExpress.XtraGrid.Views.Grid.GridView).ShowGridMenu, AddressOf Vista_ShowGridMenu
                Else
                    If ControlL.Controls.Count > 0 Then
                        PrepararPersonalizacion(ControlL)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PersonalizarCampo()
        Try
            Dim dtCampo As DataTable = STIConn.ObtenerDataset("select * from VistasCampos where forma = " & dbStr(Me.Name)).Tables(0)
            Dim Control As Object
            For Each FilCampo As DataRow In dtCampo.Rows
                Try
                    Control = Me.Controls.Find(dbData(FilCampo, "campo"), True)(0)
                    If TypeOf Control Is STIControles.stiTextBox Or TypeOf Control Is STIControles.stiMemo Or TypeOf Control Is STIControles.stiComboBox Or TypeOf Control Is STIControles.stiGridComboBox Then
                        Control.LabelText = dbData(FilCampo, "Nombre")
                        If dbData(FilCampo, "Obligatorio") = "1" Then Control.Obligatorio = True
                        If dbData(FilCampo, "Obligatorio") = "0" Then Control.Obligatorio = False
                    End If
                    If TypeOf Control Is DevExpress.XtraEditors.LabelControl Or TypeOf Control Is Label Then
                        Control.Text = dbData(FilCampo, "Nombre")
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PersonalizarVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Then
                    'ahora si han personalizado nombre de columnas
                    Dim dtPersonalizaCol As DataTable = Me.STIConn.ObtenerDataset("select campo, nombre from VistasCampos where forma = " & dbStr(Me.Name) & " and campo like " & dbStr(ControlL1.Views(0).Name & ".%")).Tables(0)
                    For Each FilCol As DataRow In dtPersonalizaCol.Rows
                        ControlL1.Views(0).Columns(stiSplit(dbData(FilCol, "campo"), "G1.1")).Caption = dbData(FilCol, "nombre")
                    Next
                End If
            Catch ex As Exception

            End Try

            If ControlL1.Controls.Count > 0 Then
                PersonalizarVistas(ControlL1)
            End If
        Next
    End Sub

    Private Sub Vista_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs)
        If STIConn.UsuarioPerteneceAGrupo(STIConn.User, "ADMINISTRADORES") = True Then
            If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = CType(e.Menu, DevExpress.XtraGrid.Menu.GridViewColumnMenu)
                If Not menu.Column Is Nothing Then
                    ColumnaMenu = menu.Column

                    menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Personalizar Columna", New EventHandler(AddressOf PersonalizarColumnaGrid), Nothing))
                End If
            End If
        End If
    End Sub

    Dim ColumnaMenu As DevExpress.XtraGrid.Columns.GridColumn

    Private Sub PersonalizarColumnaGrid()
        Dim FrmPerCampo As New stiPersonalizaCampo
        FrmPerCampo.Forma = Me.Name
        FrmPerCampo.Campo = ColumnaMenu.View.Name & "." & ColumnaMenu.FieldName
        FrmPerCampo.Nombre = ColumnaMenu.Caption
        FrmPerCampo.STIConn = Me.STIConn
        FrmPerCampo.cboObligatorio.Visible = False
        FrmPerCampo.ShowDialog()
        Call PersonalizarVistas(Me)
    End Sub


#End Region

End Class
