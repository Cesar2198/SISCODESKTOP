<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AseguradorasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AseguradorasMan))
        Me.txtIdAseguradora = New STIControles.stiTextBox
        Me.txtNombre = New STIControles.stiTextBox
        Me.txtDireccion = New STIControles.stiTextBox
        Me.txtTelefono = New STIControles.stiTextBox
        Me.txtFax = New STIControles.stiTextBox
        Me.txtPaginaWeb = New STIControles.stiTextBox
        Me.txtNit = New STIControles.stiTextBox
        Me.txtRegistroFiscal = New STIControles.stiTextBox
        Me.txtCodAgente = New STIControles.stiTextBox
        Me.txtSiglas = New STIControles.stiTextBox
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tbContactos = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.GridContactos = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdContacto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCargo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tbFormasPago = New DevExpress.XtraTab.XtraTabPage
        Me.txtFormasPago = New STIControles.stiMemo
        Me.txtCostoTraspaso = New STIControles.stiTextBox
        Me.btnCrearProductos = New DevExpress.XtraEditors.SimpleButton
        Me.lblEstado = New DevExpress.XtraEditors.LabelControl
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tbContactos.SuspendLayout()
        CType(Me.GridContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbFormasPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(477, 474)
        Me.btnAyuda.TabIndex = 15
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(291, 474)
        Me.btnBuscar.TabIndex = 13
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(12, 474)
        Me.btnNuevo.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(105, 474)
        Me.btnGuardar.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(570, 474)
        Me.btnSalir.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 474)
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
        Me.lblNombreFormulario.Text = "Registros de Aseguradoras"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(198, 474)
        Me.btnGuardarComo.TabIndex = 12
        '
        'txtIdAseguradora
        '
        Me.txtIdAseguradora.CampoBusqueda = True
        Me.txtIdAseguradora.CampoEsLlave = True
        Me.txtIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAseguradora.FechaActual = False
        Me.txtIdAseguradora.Formato = ""
        Me.txtIdAseguradora.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAseguradora.LabelText = "Cod. Aseguradora"
        Me.txtIdAseguradora.LabelWidth = 125
        Me.txtIdAseguradora.Location = New System.Drawing.Point(12, 81)
        Me.txtIdAseguradora.MaxLength = 25
        Me.txtIdAseguradora.Name = "txtIdAseguradora"
        Me.txtIdAseguradora.NombreCampo = "IdAseguradora"
        Me.txtIdAseguradora.Obligatorio = True
        Me.txtIdAseguradora.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAseguradora.Size = New System.Drawing.Size(291, 20)
        Me.txtIdAseguradora.SoloLectura = False
        Me.txtIdAseguradora.TabIndex = 0
        Me.txtIdAseguradora.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAseguradora.Valor = ""
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
        Me.txtNombre.Location = New System.Drawing.Point(12, 107)
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
        Me.txtDireccion.Location = New System.Drawing.Point(12, 133)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NombreCampo = "Direccion"
        Me.txtDireccion.Obligatorio = False
        Me.txtDireccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.Size = New System.Drawing.Size(637, 20)
        Me.txtDireccion.SoloLectura = False
        Me.txtDireccion.TabIndex = 3
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
        Me.txtTelefono.Location = New System.Drawing.Point(12, 181)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NombreCampo = "Telefono"
        Me.txtTelefono.Obligatorio = False
        Me.txtTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(291, 36)
        Me.txtTelefono.SoloLectura = False
        Me.txtTelefono.TabIndex = 5
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
        Me.txtFax.Location = New System.Drawing.Point(353, 185)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.NombreCampo = "Fax"
        Me.txtFax.Obligatorio = False
        Me.txtFax.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.Size = New System.Drawing.Size(294, 36)
        Me.txtFax.SoloLectura = False
        Me.txtFax.TabIndex = 6
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
        Me.txtPaginaWeb.Location = New System.Drawing.Point(12, 159)
        Me.txtPaginaWeb.MaxLength = 250
        Me.txtPaginaWeb.Name = "txtPaginaWeb"
        Me.txtPaginaWeb.NombreCampo = "PaginaWeb"
        Me.txtPaginaWeb.Obligatorio = False
        Me.txtPaginaWeb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaginaWeb.Size = New System.Drawing.Size(637, 20)
        Me.txtPaginaWeb.SoloLectura = False
        Me.txtPaginaWeb.TabIndex = 4
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
        Me.txtNit.Location = New System.Drawing.Point(12, 219)
        Me.txtNit.MaxLength = 25
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NombreCampo = "Nit"
        Me.txtNit.Obligatorio = False
        Me.txtNit.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNit.Size = New System.Drawing.Size(291, 36)
        Me.txtNit.SoloLectura = False
        Me.txtNit.TabIndex = 7
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
        Me.txtRegistroFiscal.Location = New System.Drawing.Point(351, 223)
        Me.txtRegistroFiscal.MaxLength = 25
        Me.txtRegistroFiscal.Name = "txtRegistroFiscal"
        Me.txtRegistroFiscal.NombreCampo = "RegistroFiscal"
        Me.txtRegistroFiscal.Obligatorio = False
        Me.txtRegistroFiscal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegistroFiscal.Size = New System.Drawing.Size(294, 36)
        Me.txtRegistroFiscal.SoloLectura = False
        Me.txtRegistroFiscal.TabIndex = 8
        Me.txtRegistroFiscal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRegistroFiscal.Valor = ""
        '
        'txtCodAgente
        '
        Me.txtCodAgente.CampoBusqueda = False
        Me.txtCodAgente.CampoEsLlave = False
        Me.txtCodAgente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCodAgente.ControlBackColor = System.Drawing.Color.White
        Me.txtCodAgente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCodAgente.FechaActual = False
        Me.txtCodAgente.Formato = ""
        Me.txtCodAgente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtCodAgente.LabelText = "Cod. Agente Seguros"
        Me.txtCodAgente.LabelWidth = 125
        Me.txtCodAgente.Location = New System.Drawing.Point(12, 258)
        Me.txtCodAgente.MaxLength = 25
        Me.txtCodAgente.Name = "txtCodAgente"
        Me.txtCodAgente.NombreCampo = "CodAgente"
        Me.txtCodAgente.Obligatorio = True
        Me.txtCodAgente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodAgente.Size = New System.Drawing.Size(291, 36)
        Me.txtCodAgente.SoloLectura = False
        Me.txtCodAgente.TabIndex = 9
        Me.txtCodAgente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCodAgente.Valor = ""
        '
        'txtSiglas
        '
        Me.txtSiglas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSiglas.CampoBusqueda = True
        Me.txtSiglas.CampoEsLlave = False
        Me.txtSiglas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSiglas.ControlBackColor = System.Drawing.Color.White
        Me.txtSiglas.ControlForeColor = System.Drawing.Color.Black
        Me.txtSiglas.FechaActual = False
        Me.txtSiglas.Formato = ""
        Me.txtSiglas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtSiglas.LabelText = "Abreviatura "
        Me.txtSiglas.LabelWidth = 100
        Me.txtSiglas.Location = New System.Drawing.Point(353, 81)
        Me.txtSiglas.MaxLength = 15
        Me.txtSiglas.Name = "txtSiglas"
        Me.txtSiglas.NombreCampo = "Siglas"
        Me.txtSiglas.Obligatorio = True
        Me.txtSiglas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSiglas.Size = New System.Drawing.Size(296, 20)
        Me.txtSiglas.SoloLectura = False
        Me.txtSiglas.TabIndex = 1
        Me.txtSiglas.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtSiglas.Valor = ""
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 301)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tbContactos
        Me.XtraTabControl1.Size = New System.Drawing.Size(642, 167)
        Me.XtraTabControl1.TabIndex = 21
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tbContactos, Me.tbFormasPago})
        '
        'tbContactos
        '
        Me.tbContactos.Controls.Add(Me.btnQuitar)
        Me.tbContactos.Controls.Add(Me.btnAgregar)
        Me.tbContactos.Controls.Add(Me.GridContactos)
        Me.tbContactos.Name = "tbContactos"
        Me.tbContactos.Size = New System.Drawing.Size(633, 136)
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
        Me.GridContactos.ColumnasAdicionales = ""
        Me.GridContactos.Location = New System.Drawing.Point(3, 30)
        Me.GridContactos.MainView = Me.GridView1
        Me.GridContactos.Name = "GridContactos"
        Me.GridContactos.NombreTabla = "AseguradorasContactos"
        Me.GridContactos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridContactos.Size = New System.Drawing.Size(626, 103)
        Me.GridContactos.TabIndex = 18
        Me.GridContactos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdAseguradora, Me.colIdContacto, Me.colNombre, Me.colCargo, Me.colTelefono, Me.colEMail, Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridContactos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColIdAseguradora
        '
        Me.ColIdAseguradora.Caption = "IdAseguradora"
        Me.ColIdAseguradora.FieldName = "IdAseguradora"
        Me.ColIdAseguradora.Name = "ColIdAseguradora"
        Me.ColIdAseguradora.OptionsColumn.ReadOnly = True
        '
        'colIdContacto
        '
        Me.colIdContacto.Caption = "IdContacto"
        Me.colIdContacto.FieldName = "IdContacto"
        Me.colIdContacto.Name = "colIdContacto"
        Me.colIdContacto.OptionsColumn.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre Contacto"
        Me.colNombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 137
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
        Me.colCargo.Width = 90
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "Teléfono Contacto"
        Me.colTelefono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 2
        Me.colTelefono.Width = 97
        '
        'colEMail
        '
        Me.colEMail.Caption = "Correo"
        Me.colEMail.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colEMail.FieldName = "EMail"
        Me.colEMail.Name = "colEMail"
        Me.colEMail.Visible = True
        Me.colEMail.VisibleIndex = 3
        Me.colEMail.Width = 84
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Funciones"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "Funciones"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 99
        '
        'tbFormasPago
        '
        Me.tbFormasPago.Controls.Add(Me.txtFormasPago)
        Me.tbFormasPago.Name = "tbFormasPago"
        Me.tbFormasPago.Size = New System.Drawing.Size(633, 136)
        Me.tbFormasPago.Text = "FORMAS DE PAGO"
        '
        'txtFormasPago
        '
        Me.txtFormasPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormasPago.CampoBusqueda = False
        Me.txtFormasPago.CampoEsLlave = False
        Me.txtFormasPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFormasPago.ControlBackColor = System.Drawing.Color.White
        Me.txtFormasPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtFormasPago.FechaActual = False
        Me.txtFormasPago.Formato = ""
        Me.txtFormasPago.LabelOrietation = STIControles.stiMemo.LOrientacion.Superior
        Me.txtFormasPago.LabelText = "Formas de Pago en Aseguradora"
        Me.txtFormasPago.LabelWidth = 100
        Me.txtFormasPago.Location = New System.Drawing.Point(3, 3)
        Me.txtFormasPago.MaxLength = 0
        Me.txtFormasPago.Name = "txtFormasPago"
        Me.txtFormasPago.NombreCampo = "FormasPago"
        Me.txtFormasPago.Obligatorio = False
        Me.txtFormasPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFormasPago.Size = New System.Drawing.Size(626, 93)
        Me.txtFormasPago.SoloLectura = False
        Me.txtFormasPago.TabIndex = 0
        Me.txtFormasPago.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtFormasPago.Valor = ""
        '
        'txtCostoTraspaso
        '
        Me.txtCostoTraspaso.CampoBusqueda = False
        Me.txtCostoTraspaso.CampoEsLlave = False
        Me.txtCostoTraspaso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCostoTraspaso.ControlBackColor = System.Drawing.Color.White
        Me.txtCostoTraspaso.ControlForeColor = System.Drawing.Color.Black
        Me.txtCostoTraspaso.FechaActual = False
        Me.txtCostoTraspaso.Formato = "#,###0.00"
        Me.txtCostoTraspaso.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtCostoTraspaso.LabelText = "Costos de Traspaso (Reclamos Automotores)"
        Me.txtCostoTraspaso.LabelWidth = 125
        Me.txtCostoTraspaso.Location = New System.Drawing.Point(351, 262)
        Me.txtCostoTraspaso.MaxLength = 25
        Me.txtCostoTraspaso.Name = "txtCostoTraspaso"
        Me.txtCostoTraspaso.NombreCampo = "CostoTraspaso"
        Me.txtCostoTraspaso.Obligatorio = False
        Me.txtCostoTraspaso.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCostoTraspaso.Size = New System.Drawing.Size(294, 36)
        Me.txtCostoTraspaso.SoloLectura = False
        Me.txtCostoTraspaso.TabIndex = 22
        Me.txtCostoTraspaso.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtCostoTraspaso.Valor = 0
        '
        'btnCrearProductos
        '
        Me.btnCrearProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearProductos.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCrearProductos.Appearance.Options.UseFont = True
        Me.btnCrearProductos.Location = New System.Drawing.Point(536, 6)
        Me.btnCrearProductos.Name = "btnCrearProductos"
        Me.btnCrearProductos.Size = New System.Drawing.Size(118, 36)
        Me.btnCrearProductos.TabIndex = 23
        Me.btnCrearProductos.Text = "&Crear Productos"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.Appearance.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblEstado.Appearance.Options.UseFont = True
        Me.lblEstado.Appearance.Options.UseForeColor = True
        Me.lblEstado.Appearance.Options.UseTextOptions = True
        Me.lblEstado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEstado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblEstado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblEstado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEstado.Location = New System.Drawing.Point(144, 53)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(511, 17)
        Me.lblEstado.TabIndex = 24
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Nacimiento"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "FechaNacimiento"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 98
        '
        'AseguradorasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 201
        Me.ClientSize = New System.Drawing.Size(661, 510)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.btnCrearProductos)
        Me.Controls.Add(Me.txtCostoTraspaso)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.txtSiglas)
        Me.Controls.Add(Me.txtCodAgente)
        Me.Controls.Add(Me.txtRegistroFiscal)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtPaginaWeb)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdAseguradora)
        Me.Name = "AseguradorasMan"
        Me.Text = "Registro de Aseguradoras"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdAseguradora, 0)
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
        Me.Controls.SetChildIndex(Me.txtCodAgente, 0)
        Me.Controls.SetChildIndex(Me.txtSiglas, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.txtCostoTraspaso, 0)
        Me.Controls.SetChildIndex(Me.btnCrearProductos, 0)
        Me.Controls.SetChildIndex(Me.lblEstado, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tbContactos.ResumeLayout(False)
        CType(Me.GridContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbFormasPago.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdAseguradora As STIControles.stiTextBox
    Friend WithEvents txtNombre As STIControles.stiTextBox
    Friend WithEvents txtDireccion As STIControles.stiTextBox
    Friend WithEvents txtTelefono As STIControles.stiTextBox
    Friend WithEvents txtFax As STIControles.stiTextBox
    Friend WithEvents txtPaginaWeb As STIControles.stiTextBox
    Friend WithEvents txtNit As STIControles.stiTextBox
    Friend WithEvents txtRegistroFiscal As STIControles.stiTextBox
    Friend WithEvents txtCodAgente As STIControles.stiTextBox
    Friend WithEvents txtSiglas As STIControles.stiTextBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tbContactos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridContactos As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdAseguradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbFormasPago As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFormasPago As STIControles.stiMemo
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCostoTraspaso As STIControles.stiTextBox
    Public WithEvents btnCrearProductos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEstado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
