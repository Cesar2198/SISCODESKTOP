<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosMan
    Inherits stiFomularios.stiMantenimiento

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombreUsuario = New STIControles.stiTextBox
        Me.txtIdUsuario = New STIControles.stiTextBox
        Me.txtDepartamento = New STIControles.stiTextBox
        Me.txtCargo = New STIControles.stiTextBox
        Me.txtFechaCreacion = New STIControles.stiTextBox
        Me.txtUsuarioCreacion = New STIControles.stiTextBox
        Me.StiGrid1 = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.txtPassword = New STIControles.stiTextBox
        Me.txtTelefono = New STIControles.stiTextBox
        Me.txtEmail = New STIControles.stiTextBox
        Me.cboEsEjecutivo = New STIControles.stiComboBox
        Me.cboVisibilidad = New STIControles.stiComboBox
        Me.cboEstado = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(467, 415)
        Me.btnAyuda.TabIndex = 17
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(283, 415)
        Me.btnBuscar.TabIndex = 15
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(6, 415)
        Me.btnNuevo.TabIndex = 13
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(98, 415)
        Me.btnGuardar.TabIndex = 12
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(559, 415)
        Me.btnSalir.TabIndex = 18
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(375, 415)
        Me.btnEliminar.TabIndex = 16
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(514, 74)
        Me.lblNombreFormulario.TabIndex = 21
        Me.lblNombreFormulario.Text = "Registro de Usuarios del Sistema"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(190, 415)
        Me.btnGuardarComo.TabIndex = 14
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.CampoBusqueda = True
        Me.txtNombreUsuario.CampoEsLlave = False
        Me.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreUsuario.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreUsuario.FechaActual = False
        Me.txtNombreUsuario.Formato = ""
        Me.txtNombreUsuario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreUsuario.LabelText = "Nombre Usuario"
        Me.txtNombreUsuario.LabelWidth = 125
        Me.txtNombreUsuario.Location = New System.Drawing.Point(12, 102)
        Me.txtNombreUsuario.MaxLength = 100
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.NombreCampo = "NombreUsuario"
        Me.txtNombreUsuario.Obligatorio = True
        Me.txtNombreUsuario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreUsuario.Size = New System.Drawing.Size(626, 20)
        Me.txtNombreUsuario.SoloLectura = False
        Me.txtNombreUsuario.TabIndex = 2
        Me.txtNombreUsuario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreUsuario.Valor = ""
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.CampoBusqueda = True
        Me.txtIdUsuario.CampoEsLlave = True
        Me.txtIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdUsuario.ControlBackColor = System.Drawing.Color.White
        Me.txtIdUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdUsuario.FechaActual = False
        Me.txtIdUsuario.Formato = ""
        Me.txtIdUsuario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdUsuario.LabelText = "Cod. Usuario"
        Me.txtIdUsuario.LabelWidth = 125
        Me.txtIdUsuario.Location = New System.Drawing.Point(12, 79)
        Me.txtIdUsuario.MaxLength = 25
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.NombreCampo = "IdUsuario"
        Me.txtIdUsuario.Obligatorio = True
        Me.txtIdUsuario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdUsuario.Size = New System.Drawing.Size(300, 20)
        Me.txtIdUsuario.SoloLectura = False
        Me.txtIdUsuario.TabIndex = 0
        Me.txtIdUsuario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdUsuario.Valor = ""
        '
        'txtDepartamento
        '
        Me.txtDepartamento.CampoBusqueda = True
        Me.txtDepartamento.CampoEsLlave = False
        Me.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDepartamento.ControlBackColor = System.Drawing.Color.White
        Me.txtDepartamento.ControlForeColor = System.Drawing.Color.Black
        Me.txtDepartamento.FechaActual = False
        Me.txtDepartamento.Formato = ""
        Me.txtDepartamento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDepartamento.LabelText = "Departamento"
        Me.txtDepartamento.LabelWidth = 125
        Me.txtDepartamento.Location = New System.Drawing.Point(10, 125)
        Me.txtDepartamento.MaxLength = 50
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.NombreCampo = "Departamento"
        Me.txtDepartamento.Obligatorio = False
        Me.txtDepartamento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepartamento.Size = New System.Drawing.Size(300, 20)
        Me.txtDepartamento.SoloLectura = False
        Me.txtDepartamento.TabIndex = 3
        Me.txtDepartamento.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDepartamento.Valor = ""
        '
        'txtCargo
        '
        Me.txtCargo.CampoBusqueda = False
        Me.txtCargo.CampoEsLlave = False
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCargo.ControlBackColor = System.Drawing.Color.White
        Me.txtCargo.ControlForeColor = System.Drawing.Color.Black
        Me.txtCargo.FechaActual = False
        Me.txtCargo.Formato = ""
        Me.txtCargo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCargo.LabelText = "Cargo"
        Me.txtCargo.LabelWidth = 85
        Me.txtCargo.Location = New System.Drawing.Point(339, 125)
        Me.txtCargo.MaxLength = 100
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.NombreCampo = "Cargo"
        Me.txtCargo.Obligatorio = False
        Me.txtCargo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCargo.Size = New System.Drawing.Size(299, 20)
        Me.txtCargo.SoloLectura = False
        Me.txtCargo.TabIndex = 4
        Me.txtCargo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCargo.Valor = ""
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.CampoBusqueda = False
        Me.txtFechaCreacion.CampoEsLlave = False
        Me.txtFechaCreacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCreacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaCreacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCreacion.FechaActual = False
        Me.txtFechaCreacion.Formato = ""
        Me.txtFechaCreacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCreacion.LabelText = "Fecha Creación"
        Me.txtFechaCreacion.LabelWidth = 85
        Me.txtFechaCreacion.Location = New System.Drawing.Point(339, 215)
        Me.txtFechaCreacion.MaxLength = 100
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.NombreCampo = "FechaCreacion"
        Me.txtFechaCreacion.Obligatorio = False
        Me.txtFechaCreacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCreacion.Size = New System.Drawing.Size(302, 20)
        Me.txtFechaCreacion.SoloLectura = True
        Me.txtFechaCreacion.TabIndex = 10
        Me.txtFechaCreacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCreacion.Valor = Nothing
        '
        'txtUsuarioCreacion
        '
        Me.txtUsuarioCreacion.CampoBusqueda = False
        Me.txtUsuarioCreacion.CampoEsLlave = False
        Me.txtUsuarioCreacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioCreacion.ControlBackColor = System.Drawing.Color.White
        Me.txtUsuarioCreacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioCreacion.FechaActual = False
        Me.txtUsuarioCreacion.Formato = ""
        Me.txtUsuarioCreacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtUsuarioCreacion.LabelText = "Usuario Creación"
        Me.txtUsuarioCreacion.LabelWidth = 125
        Me.txtUsuarioCreacion.Location = New System.Drawing.Point(10, 238)
        Me.txtUsuarioCreacion.MaxLength = 25
        Me.txtUsuarioCreacion.Name = "txtUsuarioCreacion"
        Me.txtUsuarioCreacion.NombreCampo = "UsuarioCreacion"
        Me.txtUsuarioCreacion.Obligatorio = True
        Me.txtUsuarioCreacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioCreacion.Size = New System.Drawing.Size(300, 20)
        Me.txtUsuarioCreacion.SoloLectura = False
        Me.txtUsuarioCreacion.TabIndex = 11
        Me.txtUsuarioCreacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioCreacion.Valor = ""
        '
        'StiGrid1
        '
        Me.StiGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid1.ColumnasAdicionales = ""
        Me.StiGrid1.Location = New System.Drawing.Point(10, 266)
        Me.StiGrid1.MainView = Me.GridView1
        Me.StiGrid1.Name = "StiGrid1"
        Me.StiGrid1.NombreTabla = "UsuariosGrupos"
        Me.StiGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.StiGrid1.Size = New System.Drawing.Size(631, 143)
        Me.StiGrid1.TabIndex = 21
        Me.StiGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.StiGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdUsuario"
        Me.GridColumn1.FieldName = "IdUsuario"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Grupo al que Pertenece"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn2.FieldName = "IdGrupo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(449, 239)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(546, 239)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 20
        Me.btnQutar.Text = "Quitar"
        '
        'txtPassword
        '
        Me.txtPassword.CampoBusqueda = True
        Me.txtPassword.CampoEsLlave = False
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.ControlBackColor = System.Drawing.Color.White
        Me.txtPassword.ControlForeColor = System.Drawing.Color.Black
        Me.txtPassword.FechaActual = False
        Me.txtPassword.Formato = ""
        Me.txtPassword.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPassword.LabelText = "Password"
        Me.txtPassword.LabelWidth = 85
        Me.txtPassword.Location = New System.Drawing.Point(339, 79)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NombreCampo = ""
        Me.txtPassword.Obligatorio = False
        Me.txtPassword.PassWordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(299, 20)
        Me.txtPassword.SoloLectura = False
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPassword.Valor = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.CampoBusqueda = False
        Me.txtTelefono.CampoEsLlave = False
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTelefono.ControlBackColor = System.Drawing.Color.White
        Me.txtTelefono.ControlForeColor = System.Drawing.Color.Black
        Me.txtTelefono.FechaActual = False
        Me.txtTelefono.Formato = ""
        Me.txtTelefono.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTelefono.LabelText = "Teléfono"
        Me.txtTelefono.LabelWidth = 85
        Me.txtTelefono.Location = New System.Drawing.Point(339, 148)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NombreCampo = "Telefono"
        Me.txtTelefono.Obligatorio = False
        Me.txtTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(299, 20)
        Me.txtTelefono.SoloLectura = False
        Me.txtTelefono.TabIndex = 6
        Me.txtTelefono.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTelefono.Valor = ""
        '
        'txtEmail
        '
        Me.txtEmail.CampoBusqueda = False
        Me.txtEmail.CampoEsLlave = False
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEmail.ControlBackColor = System.Drawing.Color.White
        Me.txtEmail.ControlForeColor = System.Drawing.Color.Black
        Me.txtEmail.FechaActual = False
        Me.txtEmail.Formato = ""
        Me.txtEmail.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEmail.LabelText = "Correo Electrónico"
        Me.txtEmail.LabelWidth = 125
        Me.txtEmail.Location = New System.Drawing.Point(10, 148)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NombreCampo = "Email"
        Me.txtEmail.Obligatorio = False
        Me.txtEmail.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.Size = New System.Drawing.Size(300, 20)
        Me.txtEmail.SoloLectura = False
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEmail.Valor = ""
        '
        'cboEsEjecutivo
        '
        Me.cboEsEjecutivo.CampoAutoCompletar = 0
        Me.cboEsEjecutivo.CampoBusqueda = False
        Me.cboEsEjecutivo.CampoDisplay = 1
        Me.cboEsEjecutivo.CampoEsLlave = False
        Me.cboEsEjecutivo.CampoValor = 0
        Me.cboEsEjecutivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEsEjecutivo.ControlBackColor = System.Drawing.Color.White
        Me.cboEsEjecutivo.ControlForeColor = System.Drawing.Color.Black
        Me.cboEsEjecutivo.FilasVisibles = 11
        Me.cboEsEjecutivo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEsEjecutivo.LabelText = "Es Ejecutivo Cuenta"
        Me.cboEsEjecutivo.LabelWidth = 125
        Me.cboEsEjecutivo.Lista = "S Si es Ejecutivo de Cuenta|N No es Ejecutivo de Cuenta"
        Me.cboEsEjecutivo.Location = New System.Drawing.Point(10, 215)
        Me.cboEsEjecutivo.MostrarBusquedaColumnas = False
        Me.cboEsEjecutivo.Name = "cboEsEjecutivo"
        Me.cboEsEjecutivo.NombreCampo = "EsEjecutivo"
        Me.cboEsEjecutivo.Obligatorio = True
        Me.cboEsEjecutivo.Query = ""
        Me.cboEsEjecutivo.SelectIndex = 0
        Me.cboEsEjecutivo.Size = New System.Drawing.Size(300, 20)
        Me.cboEsEjecutivo.SoloLectura = False
        Me.cboEsEjecutivo.StringConection = ""
        Me.cboEsEjecutivo.TabIndex = 9
        Me.cboEsEjecutivo.TextoNuevoItem = ""
        Me.cboEsEjecutivo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEsEjecutivo.Valor = ""
        '
        'cboVisibilidad
        '
        Me.cboVisibilidad.CampoAutoCompletar = 0
        Me.cboVisibilidad.CampoBusqueda = False
        Me.cboVisibilidad.CampoDisplay = 1
        Me.cboVisibilidad.CampoEsLlave = False
        Me.cboVisibilidad.CampoValor = 0
        Me.cboVisibilidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVisibilidad.ControlBackColor = System.Drawing.Color.White
        Me.cboVisibilidad.ControlForeColor = System.Drawing.Color.Black
        Me.cboVisibilidad.FilasVisibles = 11
        Me.cboVisibilidad.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboVisibilidad.LabelText = "Filtro de Datos"
        Me.cboVisibilidad.LabelWidth = 125
        Me.cboVisibilidad.Lista = "T Todos los Datos|D Únicamente su Departamento|L Ver Todo y Editar su Departament" & _
            "o"
        Me.cboVisibilidad.Location = New System.Drawing.Point(10, 192)
        Me.cboVisibilidad.MostrarBusquedaColumnas = False
        Me.cboVisibilidad.Name = "cboVisibilidad"
        Me.cboVisibilidad.NombreCampo = "Visibilidad"
        Me.cboVisibilidad.Obligatorio = False
        Me.cboVisibilidad.Query = ""
        Me.cboVisibilidad.SelectIndex = 0
        Me.cboVisibilidad.Size = New System.Drawing.Size(417, 20)
        Me.cboVisibilidad.SoloLectura = False
        Me.cboVisibilidad.StringConection = ""
        Me.cboVisibilidad.TabIndex = 8
        Me.cboVisibilidad.TextoNuevoItem = ""
        Me.cboVisibilidad.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboVisibilidad.Valor = ""
        '
        'cboEstado
        '
        Me.cboEstado.CampoAutoCompletar = 0
        Me.cboEstado.CampoBusqueda = False
        Me.cboEstado.CampoDisplay = 1
        Me.cboEstado.CampoEsLlave = False
        Me.cboEstado.CampoValor = 0
        Me.cboEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstado.ControlBackColor = System.Drawing.Color.White
        Me.cboEstado.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstado.FilasVisibles = 18
        Me.cboEstado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstado.LabelText = "Estado de Usuario"
        Me.cboEstado.LabelWidth = 125
        Me.cboEstado.Lista = "A Activo|I Inactivo"
        Me.cboEstado.Location = New System.Drawing.Point(10, 170)
        Me.cboEstado.MostrarBusquedaColumnas = False
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.NombreCampo = "Estado"
        Me.cboEstado.Obligatorio = False
        Me.cboEstado.Query = ""
        Me.cboEstado.SelectIndex = 0
        Me.cboEstado.Size = New System.Drawing.Size(300, 20)
        Me.cboEstado.SoloLectura = False
        Me.cboEstado.StringConection = ""
        Me.cboEstado.TabIndex = 7
        Me.cboEstado.TextoNuevoItem = ""
        Me.cboEstado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstado.Valor = ""
        '
        'UsuariosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 119
        Me.ClientSize = New System.Drawing.Size(653, 451)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.cboVisibilidad)
        Me.Controls.Add(Me.cboEsEjecutivo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.StiGrid1)
        Me.Controls.Add(Me.txtUsuarioCreacion)
        Me.Controls.Add(Me.txtFechaCreacion)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtIdUsuario)
        Me.Name = "UsuariosMan"
        Me.Text = "Registro de Usuarios del Sistema"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtDepartamento, 0)
        Me.Controls.SetChildIndex(Me.txtCargo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCreacion, 0)
        Me.Controls.SetChildIndex(Me.txtUsuarioCreacion, 0)
        Me.Controls.SetChildIndex(Me.StiGrid1, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnQutar, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.cboEsEjecutivo, 0)
        Me.Controls.SetChildIndex(Me.cboVisibilidad, 0)
        Me.Controls.SetChildIndex(Me.cboEstado, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombreUsuario As STIControles.stiTextBox
    Friend WithEvents txtIdUsuario As STIControles.stiTextBox
    Friend WithEvents txtDepartamento As STIControles.stiTextBox
    Friend WithEvents txtCargo As STIControles.stiTextBox
    Friend WithEvents txtFechaCreacion As STIControles.stiTextBox
    Friend WithEvents txtUsuarioCreacion As STIControles.stiTextBox
    Friend WithEvents StiGrid1 As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPassword As STIControles.stiTextBox
    Friend WithEvents txtTelefono As STIControles.stiTextBox
    Friend WithEvents txtEmail As STIControles.stiTextBox
    Friend WithEvents cboEsEjecutivo As STIControles.stiComboBox
    Friend WithEvents cboVisibilidad As STIControles.stiComboBox
    Friend WithEvents cboEstado As STIControles.stiComboBox

End Class
