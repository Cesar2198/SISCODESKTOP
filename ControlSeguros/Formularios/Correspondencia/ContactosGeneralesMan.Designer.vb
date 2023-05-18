<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactosGeneralesMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactosGeneralesMan))
        Me.txtIdContacto = New STIControles.stiTextBox
        Me.txtNombre = New STIControles.stiTextBox
        Me.txtDireccion = New STIControles.stiTextBox
        Me.txtTelefono = New STIControles.stiTextBox
        Me.txtFax = New STIControles.stiTextBox
        Me.txtPaginaWeb = New STIControles.stiTextBox
        Me.txtNit = New STIControles.stiTextBox
        Me.txtRegistroFiscal = New STIControles.stiTextBox
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tbContactos = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.GridContactos = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdContacto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdSubContacto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCargo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboIdContactoCategoria = New STIControles.stiComboBox
        Me.cboEstadoContacto = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tbContactos.SuspendLayout()
        CType(Me.GridContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(477, 500)
        Me.btnAyuda.TabIndex = 15
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(291, 500)
        Me.btnBuscar.TabIndex = 13
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(12, 500)
        Me.btnNuevo.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(105, 500)
        Me.btnGuardar.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(570, 500)
        Me.btnSalir.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 500)
        Me.btnEliminar.TabIndex = 14
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(522, 74)
        Me.lblNombreFormulario.TabIndex = 20
        Me.lblNombreFormulario.Text = "Registros de Contactos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(198, 500)
        Me.btnGuardarComo.TabIndex = 12
        '
        'txtIdContacto
        '
        Me.txtIdContacto.CampoBusqueda = True
        Me.txtIdContacto.CampoEsLlave = True
        Me.txtIdContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdContacto.ControlBackColor = System.Drawing.Color.White
        Me.txtIdContacto.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdContacto.FechaActual = False
        Me.txtIdContacto.Formato = ""
        Me.txtIdContacto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdContacto.LabelText = "Código Contacto"
        Me.txtIdContacto.LabelWidth = 125
        Me.txtIdContacto.Location = New System.Drawing.Point(13, 81)
        Me.txtIdContacto.MaxLength = 25
        Me.txtIdContacto.Name = "txtIdContacto"
        Me.txtIdContacto.NombreCampo = "IdContacto"
        Me.txtIdContacto.Obligatorio = True
        Me.txtIdContacto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdContacto.Size = New System.Drawing.Size(291, 20)
        Me.txtIdContacto.SoloLectura = False
        Me.txtIdContacto.TabIndex = 0
        Me.txtIdContacto.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdContacto.Valor = ""
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.CampoBusqueda = True
        Me.txtNombre.CampoEsLlave = False
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombre.ControlBackColor = System.Drawing.Color.White
        Me.txtNombre.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombre.FechaActual = False
        Me.txtNombre.Formato = ""
        Me.txtNombre.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombre.LabelText = "Nombre"
        Me.txtNombre.LabelWidth = 125
        Me.txtNombre.Location = New System.Drawing.Point(13, 105)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreCampo = "Nombre"
        Me.txtNombre.Obligatorio = True
        Me.txtNombre.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(637, 20)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombre.Valor = ""
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.CampoBusqueda = False
        Me.txtDireccion.CampoEsLlave = False
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDireccion.ControlBackColor = System.Drawing.Color.White
        Me.txtDireccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDireccion.FechaActual = False
        Me.txtDireccion.Formato = ""
        Me.txtDireccion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDireccion.LabelText = "Dirección"
        Me.txtDireccion.LabelWidth = 125
        Me.txtDireccion.Location = New System.Drawing.Point(13, 153)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NombreCampo = "Direccion"
        Me.txtDireccion.Obligatorio = False
        Me.txtDireccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.Size = New System.Drawing.Size(637, 20)
        Me.txtDireccion.SoloLectura = False
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDireccion.Valor = ""
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
        Me.txtTelefono.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTelefono.LabelText = "Teléfono"
        Me.txtTelefono.LabelWidth = 125
        Me.txtTelefono.Location = New System.Drawing.Point(13, 202)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NombreCampo = "Telefono"
        Me.txtTelefono.Obligatorio = False
        Me.txtTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(291, 36)
        Me.txtTelefono.SoloLectura = False
        Me.txtTelefono.TabIndex = 6
        Me.txtTelefono.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTelefono.Valor = ""
        '
        'txtFax
        '
        Me.txtFax.CampoBusqueda = False
        Me.txtFax.CampoEsLlave = False
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFax.ControlBackColor = System.Drawing.Color.White
        Me.txtFax.ControlForeColor = System.Drawing.Color.Black
        Me.txtFax.FechaActual = False
        Me.txtFax.Formato = ""
        Me.txtFax.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtFax.LabelText = "Fax"
        Me.txtFax.LabelWidth = 125
        Me.txtFax.Location = New System.Drawing.Point(353, 206)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.NombreCampo = "Fax"
        Me.txtFax.Obligatorio = False
        Me.txtFax.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.Size = New System.Drawing.Size(294, 36)
        Me.txtFax.SoloLectura = False
        Me.txtFax.TabIndex = 7
        Me.txtFax.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtFax.Valor = ""
        '
        'txtPaginaWeb
        '
        Me.txtPaginaWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaginaWeb.CampoBusqueda = False
        Me.txtPaginaWeb.CampoEsLlave = False
        Me.txtPaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPaginaWeb.ControlBackColor = System.Drawing.Color.White
        Me.txtPaginaWeb.ControlForeColor = System.Drawing.Color.Black
        Me.txtPaginaWeb.FechaActual = False
        Me.txtPaginaWeb.Formato = ""
        Me.txtPaginaWeb.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPaginaWeb.LabelText = "Página Web"
        Me.txtPaginaWeb.LabelWidth = 125
        Me.txtPaginaWeb.Location = New System.Drawing.Point(13, 177)
        Me.txtPaginaWeb.MaxLength = 250
        Me.txtPaginaWeb.Name = "txtPaginaWeb"
        Me.txtPaginaWeb.NombreCampo = "PaginaWeb"
        Me.txtPaginaWeb.Obligatorio = False
        Me.txtPaginaWeb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaginaWeb.Size = New System.Drawing.Size(637, 20)
        Me.txtPaginaWeb.SoloLectura = False
        Me.txtPaginaWeb.TabIndex = 5
        Me.txtPaginaWeb.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPaginaWeb.Valor = ""
        '
        'txtNit
        '
        Me.txtNit.CampoBusqueda = False
        Me.txtNit.CampoEsLlave = False
        Me.txtNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNit.ControlBackColor = System.Drawing.Color.White
        Me.txtNit.ControlForeColor = System.Drawing.Color.Black
        Me.txtNit.FechaActual = False
        Me.txtNit.Formato = ""
        Me.txtNit.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNit.LabelText = "NIT"
        Me.txtNit.LabelWidth = 125
        Me.txtNit.Location = New System.Drawing.Point(13, 240)
        Me.txtNit.MaxLength = 25
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NombreCampo = "Nit"
        Me.txtNit.Obligatorio = False
        Me.txtNit.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNit.Size = New System.Drawing.Size(291, 36)
        Me.txtNit.SoloLectura = False
        Me.txtNit.TabIndex = 8
        Me.txtNit.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNit.Valor = ""
        '
        'txtRegistroFiscal
        '
        Me.txtRegistroFiscal.CampoBusqueda = False
        Me.txtRegistroFiscal.CampoEsLlave = False
        Me.txtRegistroFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRegistroFiscal.ControlBackColor = System.Drawing.Color.White
        Me.txtRegistroFiscal.ControlForeColor = System.Drawing.Color.Black
        Me.txtRegistroFiscal.FechaActual = False
        Me.txtRegistroFiscal.Formato = ""
        Me.txtRegistroFiscal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtRegistroFiscal.LabelText = "Registro Fiscal"
        Me.txtRegistroFiscal.LabelWidth = 125
        Me.txtRegistroFiscal.Location = New System.Drawing.Point(351, 244)
        Me.txtRegistroFiscal.MaxLength = 25
        Me.txtRegistroFiscal.Name = "txtRegistroFiscal"
        Me.txtRegistroFiscal.NombreCampo = "RegistroFiscal"
        Me.txtRegistroFiscal.Obligatorio = False
        Me.txtRegistroFiscal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegistroFiscal.Size = New System.Drawing.Size(294, 36)
        Me.txtRegistroFiscal.SoloLectura = False
        Me.txtRegistroFiscal.TabIndex = 9
        Me.txtRegistroFiscal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRegistroFiscal.Valor = ""
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 290)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tbContactos
        Me.XtraTabControl1.Size = New System.Drawing.Size(642, 204)
        Me.XtraTabControl1.TabIndex = 17
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tbContactos})
        '
        'tbContactos
        '
        Me.tbContactos.Controls.Add(Me.btnQuitar)
        Me.tbContactos.Controls.Add(Me.btnAgregar)
        Me.tbContactos.Controls.Add(Me.GridContactos)
        Me.tbContactos.Name = "tbContactos"
        Me.tbContactos.Size = New System.Drawing.Size(633, 173)
        Me.tbContactos.Text = "CONTACTOS"
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Location = New System.Drawing.Point(537, 3)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitar.TabIndex = 21
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(439, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        '
        'GridContactos
        '
        Me.GridContactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridContactos.Location = New System.Drawing.Point(3, 30)
        Me.GridContactos.MainView = Me.GridView1
        Me.GridContactos.Name = "GridContactos"
        Me.GridContactos.NombreTabla = "ContactosGeneralesSubContactos"
        Me.GridContactos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridContactos.Size = New System.Drawing.Size(626, 140)
        Me.GridContactos.TabIndex = 18
        Me.GridContactos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdContacto, Me.colIdSubContacto, Me.colNombre, Me.colCargo, Me.colTelefono, Me.colEMail, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridContactos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColIdContacto
        '
        Me.ColIdContacto.Caption = "IdContacto"
        Me.ColIdContacto.FieldName = "IdContacto"
        Me.ColIdContacto.Name = "ColIdContacto"
        Me.ColIdContacto.OptionsColumn.ReadOnly = True
        '
        'colIdSubContacto
        '
        Me.colIdSubContacto.Caption = "IdContacto"
        Me.colIdSubContacto.FieldName = "IdSubContacto"
        Me.colIdSubContacto.Name = "colIdSubContacto"
        Me.colIdSubContacto.OptionsColumn.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre Contacto"
        Me.colNombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 155
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colCargo
        '
        Me.colCargo.Caption = "Cargo Contacto"
        Me.colCargo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCargo.FieldName = "Cargo"
        Me.colCargo.Name = "colCargo"
        Me.colCargo.Visible = True
        Me.colCargo.VisibleIndex = 1
        Me.colCargo.Width = 102
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "Teléfono Contacto"
        Me.colTelefono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 2
        Me.colTelefono.Width = 110
        '
        'colEMail
        '
        Me.colEMail.Caption = "Correo"
        Me.colEMail.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colEMail.FieldName = "EMail"
        Me.colEMail.Name = "colEMail"
        Me.colEMail.Visible = True
        Me.colEMail.VisibleIndex = 3
        Me.colEMail.Width = 95
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Funciones"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "Funciones"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 143
        '
        'cboIdContactoCategoria
        '
        Me.cboIdContactoCategoria.CampoAutoCompletar = 0
        Me.cboIdContactoCategoria.CampoBusqueda = False
        Me.cboIdContactoCategoria.CampoDisplay = 1
        Me.cboIdContactoCategoria.CampoEsLlave = False
        Me.cboIdContactoCategoria.CampoValor = 0
        Me.cboIdContactoCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdContactoCategoria.ControlBackColor = System.Drawing.Color.White
        Me.cboIdContactoCategoria.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdContactoCategoria.FilasVisibles = 7
        Me.cboIdContactoCategoria.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdContactoCategoria.LabelText = "Categoría de Contacto"
        Me.cboIdContactoCategoria.LabelWidth = 125
        Me.cboIdContactoCategoria.Lista = ""
        Me.cboIdContactoCategoria.Location = New System.Drawing.Point(13, 129)
        Me.cboIdContactoCategoria.Name = "cboIdContactoCategoria"
        Me.cboIdContactoCategoria.NombreCampo = "IdContactoCategoria"
        Me.cboIdContactoCategoria.Obligatorio = False
        Me.cboIdContactoCategoria.Query = "select IdContactoCategoria as Id, Descripcion as Categoria from ContactosCategori" & _
            "as"
        Me.cboIdContactoCategoria.SelectIndex = -1
        Me.cboIdContactoCategoria.Size = New System.Drawing.Size(432, 20)
        Me.cboIdContactoCategoria.SoloLectura = False
        Me.cboIdContactoCategoria.StringConection = ""
        Me.cboIdContactoCategoria.TabIndex = 3
        Me.cboIdContactoCategoria.TextoNuevoItem = ""
        Me.cboIdContactoCategoria.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdContactoCategoria.Valor = ""
        '
        'cboEstadoContacto
        '
        Me.cboEstadoContacto.CampoAutoCompletar = 0
        Me.cboEstadoContacto.CampoBusqueda = False
        Me.cboEstadoContacto.CampoDisplay = 1
        Me.cboEstadoContacto.CampoEsLlave = False
        Me.cboEstadoContacto.CampoValor = 0
        Me.cboEstadoContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoContacto.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoContacto.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoContacto.FilasVisibles = 7
        Me.cboEstadoContacto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoContacto.LabelText = "Estado del Contacto"
        Me.cboEstadoContacto.LabelWidth = 125
        Me.cboEstadoContacto.Lista = "ACTIVO ACTIVO|INACTIVO INACTIVO"
        Me.cboEstadoContacto.Location = New System.Drawing.Point(310, 81)
        Me.cboEstadoContacto.Name = "cboEstadoContacto"
        Me.cboEstadoContacto.NombreCampo = "Estado"
        Me.cboEstadoContacto.Obligatorio = False
        Me.cboEstadoContacto.Query = ""
        Me.cboEstadoContacto.SelectIndex = -1
        Me.cboEstadoContacto.Size = New System.Drawing.Size(339, 20)
        Me.cboEstadoContacto.SoloLectura = False
        Me.cboEstadoContacto.StringConection = ""
        Me.cboEstadoContacto.TabIndex = 1
        Me.cboEstadoContacto.TextoNuevoItem = ""
        Me.cboEstadoContacto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoContacto.Valor = ""
        '
        'ContactosGeneralesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 201
        Me.ClientSize = New System.Drawing.Size(661, 536)
        Me.Controls.Add(Me.cboEstadoContacto)
        Me.Controls.Add(Me.cboIdContactoCategoria)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtRegistroFiscal)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtPaginaWeb)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdContacto)
        Me.Name = "ContactosGeneralesMan"
        Me.Text = "Registro de Contactos"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdContacto, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.txtDireccion, 0)
        Me.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.Controls.SetChildIndex(Me.txtFax, 0)
        Me.Controls.SetChildIndex(Me.txtPaginaWeb, 0)
        Me.Controls.SetChildIndex(Me.txtNit, 0)
        Me.Controls.SetChildIndex(Me.txtRegistroFiscal, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.cboIdContactoCategoria, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoContacto, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tbContactos.ResumeLayout(False)
        CType(Me.GridContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdContacto As STIControles.stiTextBox
    Friend WithEvents txtNombre As STIControles.stiTextBox
    Friend WithEvents txtDireccion As STIControles.stiTextBox
    Friend WithEvents txtTelefono As STIControles.stiTextBox
    Friend WithEvents txtFax As STIControles.stiTextBox
    Friend WithEvents txtPaginaWeb As STIControles.stiTextBox
    Friend WithEvents txtNit As STIControles.stiTextBox
    Friend WithEvents txtRegistroFiscal As STIControles.stiTextBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tbContactos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridContactos As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSubContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboIdContactoCategoria As STIControles.stiComboBox
    Friend WithEvents cboEstadoContacto As STIControles.stiComboBox

End Class
