<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosMan))
        Me.TabProductos = New DevExpress.XtraTab.XtraTabControl
        Me.AGeneral = New DevExpress.XtraTab.XtraTabPage
        Me.cboTipoBien = New STIControles.stiComboBox
        Me.cboRamo = New STIControles.stiComboBox
        Me.cboTipoProducto = New STIControles.stiComboBox
        Me.cboIdAseguradora = New STIControles.stiComboBox
        Me.txtCodigoCia = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtIdProducto = New STIControles.stiTextBox
        Me.BCoberturas = New DevExpress.XtraTab.XtraTabPage
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.StiGrid1 = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DGastos = New DevExpress.XtraTab.XtraTabPage
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.StiGrid4 = New STIControles.stiGrid
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CComisiones = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.StiGrid3 = New STIControles.stiGrid
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.StiGrid2 = New STIControles.stiGrid
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.EDatosTec = New DevExpress.XtraTab.XtraTabPage
        Me.cboBienesSumas = New STIControles.stiComboBox
        Me.btnQuitarBien = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarBien = New DevExpress.XtraEditors.SimpleButton
        Me.GridBienes = New STIControles.stiGrid
        Me.VistaBienes = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colbIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbNombreBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.FSiniestros = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.btnQuitarGasto = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGasto = New DevExpress.XtraEditors.SimpleButton
        Me.GridSinGastos = New STIControles.stiGrid
        Me.VistaSinGastos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnQuitarSinComp = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarSinComp = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarSinReq = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgreagrSinReq = New DevExpress.XtraEditors.SimpleButton
        Me.StiGrid6 = New STIControles.stiGrid
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StiGrid5 = New STIControles.stiGrid
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProductos.SuspendLayout()
        Me.AGeneral.SuspendLayout()
        Me.BCoberturas.SuspendLayout()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGastos.SuspendLayout()
        CType(Me.StiGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CComisiones.SuspendLayout()
        CType(Me.StiGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StiGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EDatosTec.SuspendLayout()
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FSiniestros.SuspendLayout()
        CType(Me.GridSinGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaSinGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StiGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StiGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(472, 421)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(288, 421)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(10, 421)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(102, 421)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(564, 421)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(380, 421)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(519, 89)
        Me.lblNombreFormulario.Text = "Productos de Seguros"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Size = New System.Drawing.Size(141, 89)
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(195, 421)
        '
        'TabProductos
        '
        Me.TabProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabProductos.Location = New System.Drawing.Point(1, 96)
        Me.TabProductos.Name = "TabProductos"
        Me.TabProductos.SelectedTabPage = Me.AGeneral
        Me.TabProductos.Size = New System.Drawing.Size(651, 323)
        Me.TabProductos.TabIndex = 32
        Me.TabProductos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.AGeneral, Me.BCoberturas, Me.DGastos, Me.CComisiones, Me.EDatosTec, Me.FSiniestros})
        '
        'AGeneral
        '
        Me.AGeneral.Controls.Add(Me.cboTipoBien)
        Me.AGeneral.Controls.Add(Me.cboRamo)
        Me.AGeneral.Controls.Add(Me.cboTipoProducto)
        Me.AGeneral.Controls.Add(Me.cboIdAseguradora)
        Me.AGeneral.Controls.Add(Me.txtCodigoCia)
        Me.AGeneral.Controls.Add(Me.txtDescripcion)
        Me.AGeneral.Controls.Add(Me.txtIdProducto)
        Me.AGeneral.Name = "AGeneral"
        Me.AGeneral.Size = New System.Drawing.Size(642, 292)
        Me.AGeneral.Text = "General"
        '
        'cboTipoBien
        '
        Me.cboTipoBien.CampoAutoCompletar = 0
        Me.cboTipoBien.CampoBusqueda = False
        Me.cboTipoBien.CampoDisplay = 1
        Me.cboTipoBien.CampoEsLlave = False
        Me.cboTipoBien.CampoValor = 0
        Me.cboTipoBien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoBien.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoBien.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoBien.FilasVisibles = 11
        Me.cboTipoBien.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoBien.LabelText = "Tipo de Bien"
        Me.cboTipoBien.LabelWidth = 100
        Me.cboTipoBien.Lista = ""
        Me.cboTipoBien.Location = New System.Drawing.Point(23, 148)
        Me.cboTipoBien.MostrarBusquedaColumnas = False
        Me.cboTipoBien.Name = "cboTipoBien"
        Me.cboTipoBien.NombreCampo = "TipoBien"
        Me.cboTipoBien.Obligatorio = False
        Me.cboTipoBien.Query = ""
        Me.cboTipoBien.SelectIndex = 0
        Me.cboTipoBien.Size = New System.Drawing.Size(417, 20)
        Me.cboTipoBien.SoloLectura = False
        Me.cboTipoBien.StringConection = ""
        Me.cboTipoBien.TabIndex = 5
        Me.cboTipoBien.TextoNuevoItem = ""
        Me.cboTipoBien.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoBien.Valor = ""
        '
        'cboRamo
        '
        Me.cboRamo.CampoAutoCompletar = 0
        Me.cboRamo.CampoBusqueda = False
        Me.cboRamo.CampoDisplay = 1
        Me.cboRamo.CampoEsLlave = False
        Me.cboRamo.CampoValor = 0
        Me.cboRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboRamo.FilasVisibles = 11
        Me.cboRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRamo.LabelText = "Ramo de Seguro"
        Me.cboRamo.LabelWidth = 100
        Me.cboRamo.Lista = ""
        Me.cboRamo.Location = New System.Drawing.Point(23, 122)
        Me.cboRamo.MostrarBusquedaColumnas = False
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NombreCampo = "IdRamo"
        Me.cboRamo.Obligatorio = True
        Me.cboRamo.Query = "select IdRamo, NombreRamo from RamoSeguros"
        Me.cboRamo.SelectIndex = 0
        Me.cboRamo.Size = New System.Drawing.Size(417, 20)
        Me.cboRamo.SoloLectura = False
        Me.cboRamo.StringConection = ""
        Me.cboRamo.TabIndex = 4
        Me.cboRamo.TextoNuevoItem = ""
        Me.cboRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRamo.Valor = ""
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.CampoAutoCompletar = 0
        Me.cboTipoProducto.CampoBusqueda = False
        Me.cboTipoProducto.CampoDisplay = 1
        Me.cboTipoProducto.CampoEsLlave = False
        Me.cboTipoProducto.CampoValor = 0
        Me.cboTipoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoProducto.FilasVisibles = 11
        Me.cboTipoProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoProducto.LabelText = "Tipo de Producto"
        Me.cboTipoProducto.LabelWidth = 100
        Me.cboTipoProducto.Lista = "VIDA Seguro de Vida y Gastos Médicos|DAÑOS Seguro de Daños"
        Me.cboTipoProducto.Location = New System.Drawing.Point(23, 96)
        Me.cboTipoProducto.MostrarBusquedaColumnas = False
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.NombreCampo = "TipoProducto"
        Me.cboTipoProducto.Obligatorio = True
        Me.cboTipoProducto.Query = ""
        Me.cboTipoProducto.SelectIndex = 0
        Me.cboTipoProducto.Size = New System.Drawing.Size(417, 20)
        Me.cboTipoProducto.SoloLectura = False
        Me.cboTipoProducto.StringConection = ""
        Me.cboTipoProducto.TabIndex = 3
        Me.cboTipoProducto.TextoNuevoItem = ""
        Me.cboTipoProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoProducto.Valor = ""
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.CampoAutoCompletar = 0
        Me.cboIdAseguradora.CampoBusqueda = False
        Me.cboIdAseguradora.CampoDisplay = 1
        Me.cboIdAseguradora.CampoEsLlave = False
        Me.cboIdAseguradora.CampoValor = 0
        Me.cboIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAseguradora.FilasVisibles = 11
        Me.cboIdAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAseguradora.LabelText = "Aseguradora"
        Me.cboIdAseguradora.LabelWidth = 100
        Me.cboIdAseguradora.Lista = ""
        Me.cboIdAseguradora.Location = New System.Drawing.Point(23, 70)
        Me.cboIdAseguradora.MostrarBusquedaColumnas = False
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NombreCampo = "IdAseguradora"
        Me.cboIdAseguradora.Obligatorio = True
        Me.cboIdAseguradora.Query = "select IdAseguradora, Nombre from Aseguradoras order by Nombre"
        Me.cboIdAseguradora.SelectIndex = 0
        Me.cboIdAseguradora.Size = New System.Drawing.Size(417, 20)
        Me.cboIdAseguradora.SoloLectura = False
        Me.cboIdAseguradora.StringConection = ""
        Me.cboIdAseguradora.TabIndex = 2
        Me.cboIdAseguradora.TextoNuevoItem = ""
        Me.cboIdAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAseguradora.Valor = ""
        '
        'txtCodigoCia
        '
        Me.txtCodigoCia.CampoBusqueda = False
        Me.txtCodigoCia.CampoEsLlave = False
        Me.txtCodigoCia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCodigoCia.ControlBackColor = System.Drawing.Color.White
        Me.txtCodigoCia.ControlForeColor = System.Drawing.Color.Black
        Me.txtCodigoCia.FechaActual = False
        Me.txtCodigoCia.Formato = ""
        Me.txtCodigoCia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtCodigoCia.LabelText = "Cod. Producto en Aseguradora"
        Me.txtCodigoCia.LabelWidth = 100
        Me.txtCodigoCia.Location = New System.Drawing.Point(23, 196)
        Me.txtCodigoCia.MaxLength = 0
        Me.txtCodigoCia.Name = "txtCodigoCia"
        Me.txtCodigoCia.NombreCampo = "CodigoCia"
        Me.txtCodigoCia.Obligatorio = False
        Me.txtCodigoCia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoCia.Size = New System.Drawing.Size(300, 36)
        Me.txtCodigoCia.SoloLectura = False
        Me.txtCodigoCia.TabIndex = 6
        Me.txtCodigoCia.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCodigoCia.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 44)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(572, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtIdProducto
        '
        Me.txtIdProducto.CampoBusqueda = True
        Me.txtIdProducto.CampoEsLlave = True
        Me.txtIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.txtIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdProducto.FechaActual = False
        Me.txtIdProducto.Formato = ""
        Me.txtIdProducto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdProducto.LabelText = "Cod. Producto"
        Me.txtIdProducto.LabelWidth = 100
        Me.txtIdProducto.Location = New System.Drawing.Point(23, 18)
        Me.txtIdProducto.MaxLength = 25
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.NombreCampo = "IdProducto"
        Me.txtIdProducto.Obligatorio = True
        Me.txtIdProducto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdProducto.Size = New System.Drawing.Size(300, 20)
        Me.txtIdProducto.SoloLectura = False
        Me.txtIdProducto.TabIndex = 0
        Me.txtIdProducto.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdProducto.Valor = ""
        '
        'BCoberturas
        '
        Me.BCoberturas.Controls.Add(Me.btnQutar)
        Me.BCoberturas.Controls.Add(Me.btnAgregar)
        Me.BCoberturas.Controls.Add(Me.StiGrid1)
        Me.BCoberturas.Name = "BCoberturas"
        Me.BCoberturas.Size = New System.Drawing.Size(642, 292)
        Me.BCoberturas.Text = "Coberturas"
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(538, 38)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 21
        Me.btnQutar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(538, 1)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        '
        'StiGrid1
        '
        Me.StiGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid1.ColumnasAdicionales = ""
        Me.StiGrid1.Location = New System.Drawing.Point(3, 3)
        Me.StiGrid1.MainView = Me.GridView1
        Me.StiGrid1.Name = "StiGrid1"
        Me.StiGrid1.NombreTabla = "ProductosCoberturas"
        Me.StiGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemLookUpEdit6})
        Me.StiGrid1.Size = New System.Drawing.Size(529, 288)
        Me.StiGrid1.TabIndex = 0
        Me.StiGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 35
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn31, Me.GridColumn32, Me.GridColumn40, Me.GridColumn41})
        Me.GridView1.GridControl = Me.StiGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdProducto"
        Me.GridColumn1.FieldName = "IdProducto"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cobertura"
        Me.GridColumn2.FieldName = "IdCobertura"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 41
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Nombre Cobertura"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn3.FieldName = "Descripcion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 168
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cód. Cob. en Aseg."
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn4.FieldName = "CodigoCia"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 125
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Tarificación"
        Me.GridColumn31.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.GridColumn31.FieldName = "Tarificacion"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 2
        Me.GridColumn31.Width = 71
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Descuento"
        Me.GridColumn32.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.GridColumn32.FieldName = "AplicarDescuento"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 3
        Me.GridColumn32.Width = 64
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "IVA"
        Me.GridColumn40.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.GridColumn40.FieldName = "AplicarIva"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 4
        Me.GridColumn40.Width = 39
        '
        'DGastos
        '
        Me.DGastos.Controls.Add(Me.SimpleButton5)
        Me.DGastos.Controls.Add(Me.SimpleButton6)
        Me.DGastos.Controls.Add(Me.StiGrid4)
        Me.DGastos.Name = "DGastos"
        Me.DGastos.Size = New System.Drawing.Size(642, 292)
        Me.DGastos.Text = "Gastos"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Location = New System.Drawing.Point(538, 40)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton5.TabIndex = 25
        Me.SimpleButton5.Text = "Quitar"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Location = New System.Drawing.Point(538, 3)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton6.TabIndex = 24
        Me.SimpleButton6.Text = "Agregar"
        '
        'StiGrid4
        '
        Me.StiGrid4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid4.ColumnasAdicionales = ""
        Me.StiGrid4.Location = New System.Drawing.Point(3, 3)
        Me.StiGrid4.MainView = Me.GridView4
        Me.StiGrid4.Name = "StiGrid4"
        Me.StiGrid4.NombreTabla = "ProductosGastos"
        Me.StiGrid4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4, Me.RepositoryItemTextEdit2, Me.RepositoryItemLookUpEdit7})
        Me.StiGrid4.Size = New System.Drawing.Size(529, 288)
        Me.StiGrid4.TabIndex = 4
        Me.StiGrid4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView4.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView4.ColumnPanelRowHeight = 35
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn33})
        Me.GridView4.GridControl = Me.StiGrid4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "IdProducto"
        Me.GridColumn18.FieldName = "IdProducto"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Cod. Gasto"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.GridColumn19.FieldName = "IdGasto"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 0
        Me.GridColumn19.Width = 113
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "%Gasto"
        Me.GridColumn20.FieldName = "PorceGasto"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 2
        Me.GridColumn20.Width = 55
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Valor Gasto"
        Me.GridColumn21.DisplayFormat.FormatString = "c"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "ValorGasto"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 3
        Me.GridColumn21.Width = 72
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Valor Mínimo"
        Me.GridColumn22.DisplayFormat.FormatString = "c"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "ValorMinimo"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 4
        Me.GridColumn22.Width = 72
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Valor Máximo"
        Me.GridColumn23.DisplayFormat.FormatString = "c"
        Me.GridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn23.FieldName = "ValorMaximo"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 5
        Me.GridColumn23.Width = 58
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Cod.Aseguradora"
        Me.GridColumn24.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn24.FieldName = "CodigoAseguradora"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 6
        Me.GridColumn24.Width = 70
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Tipo Cálculo"
        Me.GridColumn33.ColumnEdit = Me.RepositoryItemLookUpEdit7
        Me.GridColumn33.FieldName = "TipoCalculo"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 1
        Me.GridColumn33.Width = 68
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.NullText = ""
        '
        'CComisiones
        '
        Me.CComisiones.Controls.Add(Me.LabelControl5)
        Me.CComisiones.Controls.Add(Me.LabelControl4)
        Me.CComisiones.Controls.Add(Me.SimpleButton3)
        Me.CComisiones.Controls.Add(Me.SimpleButton4)
        Me.CComisiones.Controls.Add(Me.StiGrid3)
        Me.CComisiones.Controls.Add(Me.SimpleButton1)
        Me.CComisiones.Controls.Add(Me.SimpleButton2)
        Me.CComisiones.Controls.Add(Me.StiGrid2)
        Me.CComisiones.Name = "CComisiones"
        Me.CComisiones.Size = New System.Drawing.Size(642, 292)
        Me.CComisiones.Text = "Comisiones"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(8, 146)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(252, 13)
        Me.LabelControl5.TabIndex = 33
        Me.LabelControl5.Text = "COMISIONES OTROGADAS A LOS VENDEDORES"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(8, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(279, 13)
        Me.LabelControl4.TabIndex = 32
        Me.LabelControl4.Text = "COMISIONES RECIBIDAS POR LAS ASEGURADORAS"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(538, 202)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton3.TabIndex = 26
        Me.SimpleButton3.Text = "Quitar"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Location = New System.Drawing.Point(538, 165)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton4.TabIndex = 25
        Me.SimpleButton4.Text = "Agregar"
        '
        'StiGrid3
        '
        Me.StiGrid3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid3.ColumnasAdicionales = ""
        Me.StiGrid3.Location = New System.Drawing.Point(8, 165)
        Me.StiGrid3.MainView = Me.GridView3
        Me.StiGrid3.Name = "StiGrid3"
        Me.StiGrid3.NombreTabla = "ProductosComisionesInternas"
        Me.StiGrid3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.StiGrid3.Size = New System.Drawing.Size(524, 126)
        Me.StiGrid3.TabIndex = 24
        Me.StiGrid3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17})
        Me.GridView3.GridControl = Me.StiGrid3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "IdProducto"
        Me.GridColumn11.FieldName = "IdProducto"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "IdComision"
        Me.GridColumn12.FieldName = "IdComision"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 64
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Año"
        Me.GridColumn13.FieldName = "Anio"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 45
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Tipo Vendedor"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn14.FieldName = "IdTipoVendedor"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        Me.GridColumn14.Width = 94
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "%Comisión"
        Me.GridColumn15.FieldName = "PorceComi"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        Me.GridColumn15.Width = 78
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Valor Comisión"
        Me.GridColumn16.FieldName = "ValorComi"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        Me.GridColumn16.Width = 85
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Forma de Pago"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.GridColumn17.FieldName = "FormaPago"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        Me.GridColumn17.Width = 128
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(538, 59)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "Quitar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(538, 22)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton2.TabIndex = 22
        Me.SimpleButton2.Text = "Agregar"
        '
        'StiGrid2
        '
        Me.StiGrid2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid2.ColumnasAdicionales = ""
        Me.StiGrid2.Location = New System.Drawing.Point(8, 22)
        Me.StiGrid2.MainView = Me.GridView2
        Me.StiGrid2.Name = "StiGrid2"
        Me.StiGrid2.NombreTabla = "ProductosComisionesExternas"
        Me.StiGrid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.StiGrid2.Size = New System.Drawing.Size(524, 118)
        Me.StiGrid2.TabIndex = 0
        Me.StiGrid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView2.GridControl = Me.StiGrid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "IdProducto"
        Me.GridColumn5.FieldName = "IdProducto"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Año"
        Me.GridColumn6.FieldName = "IdComision"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 50
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "%Comisión"
        Me.GridColumn7.FieldName = "PorceComi"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 76
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Valor Fijo"
        Me.GridColumn8.FieldName = "MontoComi"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 74
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "%Gas.Admin."
        Me.GridColumn9.FieldName = "PorceAdmin"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.GridColumn9.Width = 89
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Forma de Pago"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn10.FieldName = "FormaPago"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 205
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'EDatosTec
        '
        Me.EDatosTec.Controls.Add(Me.cboBienesSumas)
        Me.EDatosTec.Controls.Add(Me.btnQuitarBien)
        Me.EDatosTec.Controls.Add(Me.btnAgregarBien)
        Me.EDatosTec.Controls.Add(Me.GridBienes)
        Me.EDatosTec.Name = "EDatosTec"
        Me.EDatosTec.Size = New System.Drawing.Size(642, 292)
        Me.EDatosTec.Text = "Datos Técnicos Producto"
        '
        'cboBienesSumas
        '
        Me.cboBienesSumas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBienesSumas.CampoAutoCompletar = 0
        Me.cboBienesSumas.CampoBusqueda = False
        Me.cboBienesSumas.CampoDisplay = 1
        Me.cboBienesSumas.CampoEsLlave = False
        Me.cboBienesSumas.CampoValor = 0
        Me.cboBienesSumas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboBienesSumas.ControlBackColor = System.Drawing.Color.White
        Me.cboBienesSumas.ControlForeColor = System.Drawing.Color.Black
        Me.cboBienesSumas.FilasVisibles = 11
        Me.cboBienesSumas.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboBienesSumas.LabelText = "Solicitar Sumas y Primas"
        Me.cboBienesSumas.LabelWidth = 100
        Me.cboBienesSumas.Lista = "S Si|N no"
        Me.cboBienesSumas.Location = New System.Drawing.Point(524, 69)
        Me.cboBienesSumas.MostrarBusquedaColumnas = False
        Me.cboBienesSumas.Name = "cboBienesSumas"
        Me.cboBienesSumas.NombreCampo = "BienesSumas"
        Me.cboBienesSumas.Obligatorio = False
        Me.cboBienesSumas.Query = ""
        Me.cboBienesSumas.SelectIndex = 0
        Me.cboBienesSumas.Size = New System.Drawing.Size(115, 38)
        Me.cboBienesSumas.SoloLectura = False
        Me.cboBienesSumas.StringConection = ""
        Me.cboBienesSumas.TabIndex = 26
        Me.cboBienesSumas.TextoNuevoItem = ""
        Me.cboBienesSumas.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboBienesSumas.Valor = ""
        '
        'btnQuitarBien
        '
        Me.btnQuitarBien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarBien.Location = New System.Drawing.Point(531, 40)
        Me.btnQuitarBien.Name = "btnQuitarBien"
        Me.btnQuitarBien.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarBien.TabIndex = 25
        Me.btnQuitarBien.Text = "Quitar"
        '
        'btnAgregarBien
        '
        Me.btnAgregarBien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarBien.Location = New System.Drawing.Point(531, 3)
        Me.btnAgregarBien.Name = "btnAgregarBien"
        Me.btnAgregarBien.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarBien.TabIndex = 24
        Me.btnAgregarBien.Text = "Agregar"
        '
        'GridBienes
        '
        Me.GridBienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBienes.ColumnasAdicionales = ""
        Me.GridBienes.Location = New System.Drawing.Point(3, 3)
        Me.GridBienes.MainView = Me.VistaBienes
        Me.GridBienes.Name = "GridBienes"
        Me.GridBienes.NombreTabla = "ProductosBienes"
        Me.GridBienes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3})
        Me.GridBienes.Size = New System.Drawing.Size(515, 286)
        Me.GridBienes.TabIndex = 0
        Me.GridBienes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBienes})
        '
        'VistaBienes
        '
        Me.VistaBienes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbIdProducto, Me.colIdBien, Me.colbNombreBien})
        Me.VistaBienes.GridControl = Me.GridBienes
        Me.VistaBienes.Name = "VistaBienes"
        Me.VistaBienes.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaBienes.OptionsView.ShowGroupPanel = False
        '
        'colbIdProducto
        '
        Me.colbIdProducto.Caption = "IdProducto"
        Me.colbIdProducto.FieldName = "IdProducto"
        Me.colbIdProducto.Name = "colbIdProducto"
        '
        'colIdBien
        '
        Me.colIdBien.Caption = "Código"
        Me.colIdBien.FieldName = "IdBien"
        Me.colIdBien.Name = "colIdBien"
        Me.colIdBien.Visible = True
        Me.colIdBien.VisibleIndex = 0
        Me.colIdBien.Width = 96
        '
        'colbNombreBien
        '
        Me.colbNombreBien.Caption = "Descripción de Bienes"
        Me.colbNombreBien.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colbNombreBien.FieldName = "NombreBien"
        Me.colbNombreBien.Name = "colbNombreBien"
        Me.colbNombreBien.Visible = True
        Me.colbNombreBien.VisibleIndex = 1
        Me.colbNombreBien.Width = 387
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'FSiniestros
        '
        Me.FSiniestros.Controls.Add(Me.LabelControl6)
        Me.FSiniestros.Controls.Add(Me.btnQuitarGasto)
        Me.FSiniestros.Controls.Add(Me.btnAgregarGasto)
        Me.FSiniestros.Controls.Add(Me.GridSinGastos)
        Me.FSiniestros.Controls.Add(Me.LabelControl3)
        Me.FSiniestros.Controls.Add(Me.LabelControl2)
        Me.FSiniestros.Controls.Add(Me.btnQuitarSinComp)
        Me.FSiniestros.Controls.Add(Me.btnAgregarSinComp)
        Me.FSiniestros.Controls.Add(Me.btnQuitarSinReq)
        Me.FSiniestros.Controls.Add(Me.btnAgreagrSinReq)
        Me.FSiniestros.Controls.Add(Me.StiGrid6)
        Me.FSiniestros.Controls.Add(Me.StiGrid5)
        Me.FSiniestros.Name = "FSiniestros"
        Me.FSiniestros.Size = New System.Drawing.Size(642, 292)
        Me.FSiniestros.Text = "Siniestros"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(8, 171)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(178, 13)
        Me.LabelControl6.TabIndex = 36
        Me.LabelControl6.Text = "TIPOS DE GASTOS EN RECLAMOS"
        '
        'btnQuitarGasto
        '
        Me.btnQuitarGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGasto.Location = New System.Drawing.Point(547, 219)
        Me.btnQuitarGasto.Name = "btnQuitarGasto"
        Me.btnQuitarGasto.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarGasto.TabIndex = 35
        Me.btnQuitarGasto.Text = "Quitar"
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGasto.Location = New System.Drawing.Point(547, 190)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarGasto.TabIndex = 34
        Me.btnAgregarGasto.Text = "Agregar"
        '
        'GridSinGastos
        '
        Me.GridSinGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSinGastos.ColumnasAdicionales = ""
        Me.GridSinGastos.Location = New System.Drawing.Point(9, 190)
        Me.GridSinGastos.MainView = Me.VistaSinGastos
        Me.GridSinGastos.Name = "GridSinGastos"
        Me.GridSinGastos.NombreTabla = "ProductosSinGastos"
        Me.GridSinGastos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit6})
        Me.GridSinGastos.Size = New System.Drawing.Size(532, 99)
        Me.GridSinGastos.TabIndex = 33
        Me.GridSinGastos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaSinGastos})
        '
        'VistaSinGastos
        '
        Me.VistaSinGastos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38})
        Me.VistaSinGastos.GridControl = Me.GridSinGastos
        Me.VistaSinGastos.Name = "VistaSinGastos"
        Me.VistaSinGastos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaSinGastos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "IdProducto"
        Me.GridColumn34.FieldName = "IdProducto"
        Me.GridColumn34.Name = "GridColumn34"
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Orden"
        Me.GridColumn35.FieldName = "IdGasto"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 0
        Me.GridColumn35.Width = 49
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Descripción"
        Me.GridColumn36.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GridColumn36.FieldName = "Descripcion"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 1
        Me.GridColumn36.Width = 298
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Cob.Afecta"
        Me.GridColumn37.FieldName = "CoberturaAfecta"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 2
        Me.GridColumn37.Width = 82
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Cod.Aseg."
        Me.GridColumn38.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GridColumn38.FieldName = "CodAseguradora"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(335, 1)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(295, 13)
        Me.LabelControl3.TabIndex = 32
        Me.LabelControl3.Text = "DATOS COMPLEMENTARIOS DECLARACION RECLAMOS"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(8, 1)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(233, 13)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "REQUISITOS PARA PRESENTAR RECLAMOS"
        '
        'btnQuitarSinComp
        '
        Me.btnQuitarSinComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarSinComp.Location = New System.Drawing.Point(547, 20)
        Me.btnQuitarSinComp.Name = "btnQuitarSinComp"
        Me.btnQuitarSinComp.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarSinComp.TabIndex = 30
        Me.btnQuitarSinComp.Text = "Quitar"
        '
        'btnAgregarSinComp
        '
        Me.btnAgregarSinComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarSinComp.Location = New System.Drawing.Point(449, 20)
        Me.btnAgregarSinComp.Name = "btnAgregarSinComp"
        Me.btnAgregarSinComp.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarSinComp.TabIndex = 29
        Me.btnAgregarSinComp.Text = "Agregar"
        '
        'btnQuitarSinReq
        '
        Me.btnQuitarSinReq.Location = New System.Drawing.Point(223, 20)
        Me.btnQuitarSinReq.Name = "btnQuitarSinReq"
        Me.btnQuitarSinReq.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarSinReq.TabIndex = 28
        Me.btnQuitarSinReq.Text = "Quitar"
        '
        'btnAgreagrSinReq
        '
        Me.btnAgreagrSinReq.Location = New System.Drawing.Point(125, 20)
        Me.btnAgreagrSinReq.Name = "btnAgreagrSinReq"
        Me.btnAgreagrSinReq.Size = New System.Drawing.Size(92, 23)
        Me.btnAgreagrSinReq.TabIndex = 27
        Me.btnAgreagrSinReq.Text = "Agregar"
        '
        'StiGrid6
        '
        Me.StiGrid6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid6.ColumnasAdicionales = ""
        Me.StiGrid6.Location = New System.Drawing.Point(323, 49)
        Me.StiGrid6.MainView = Me.GridView6
        Me.StiGrid6.Name = "StiGrid6"
        Me.StiGrid6.NombreTabla = "ProductosSinComplementos"
        Me.StiGrid6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit5})
        Me.StiGrid6.Size = New System.Drawing.Size(316, 116)
        Me.StiGrid6.TabIndex = 1
        Me.StiGrid6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn39})
        Me.GridView6.GridControl = Me.StiGrid6
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "IdProducto"
        Me.GridColumn28.FieldName = "IdProducto"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Orden"
        Me.GridColumn29.FieldName = "IdComplemento"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 0
        Me.GridColumn29.Width = 55
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Descripción Dato Complementario"
        Me.GridColumn30.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn30.FieldName = "DescripcionComplemento"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 1
        Me.GridColumn30.Width = 173
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Categoría"
        Me.GridColumn39.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn39.FieldName = "Categoria"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 2
        Me.GridColumn39.Width = 78
        '
        'StiGrid5
        '
        Me.StiGrid5.ColumnasAdicionales = ""
        Me.StiGrid5.Location = New System.Drawing.Point(8, 49)
        Me.StiGrid5.MainView = Me.GridView5
        Me.StiGrid5.Name = "StiGrid5"
        Me.StiGrid5.NombreTabla = "ProductosSinRequisitos"
        Me.StiGrid5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4})
        Me.StiGrid5.Size = New System.Drawing.Size(307, 116)
        Me.StiGrid5.TabIndex = 0
        Me.StiGrid5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn25, Me.GridColumn26, Me.GridColumn27})
        Me.GridView5.GridControl = Me.StiGrid5
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Producto"
        Me.GridColumn25.FieldName = "IdProducto"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Orden"
        Me.GridColumn26.FieldName = "IdRequisito"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 0
        Me.GridColumn26.Width = 57
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Descripción de Requisitos"
        Me.GridColumn27.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GridColumn27.FieldName = "DescripcionRequisito"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 1
        Me.GridColumn27.Width = 229
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Nom. Grupo Cobertura"
        Me.GridColumn41.FieldName = "NombreCorto"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 6
        '
        'ProductosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 206
        Me.ClientSize = New System.Drawing.Size(658, 457)
        Me.Controls.Add(Me.TabProductos)
        Me.Name = "ProductosMan"
        Me.Text = "Productos de Seguros"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.TabProductos, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProductos.ResumeLayout(False)
        Me.AGeneral.ResumeLayout(False)
        Me.BCoberturas.ResumeLayout(False)
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGastos.ResumeLayout(False)
        CType(Me.StiGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CComisiones.ResumeLayout(False)
        Me.CComisiones.PerformLayout()
        CType(Me.StiGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StiGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EDatosTec.ResumeLayout(False)
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FSiniestros.ResumeLayout(False)
        Me.FSiniestros.PerformLayout()
        CType(Me.GridSinGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaSinGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StiGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StiGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabProductos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents AGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BCoberturas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CComisiones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboTipoProducto As STIControles.stiComboBox
    Friend WithEvents cboIdAseguradora As STIControles.stiComboBox
    Friend WithEvents txtCodigoCia As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtIdProducto As STIControles.stiTextBox
    Friend WithEvents StiGrid1 As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StiGrid2 As STIControles.stiGrid
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents StiGrid3 As STIControles.stiGrid
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboRamo As STIControles.stiComboBox
    Friend WithEvents DGastos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents StiGrid4 As STIControles.stiGrid
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents EDatosTec As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridBienes As STIControles.stiGrid
    Friend WithEvents VistaBienes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbNombreBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarBien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarBien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FSiniestros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnQuitarSinComp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarSinComp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarSinReq As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgreagrSinReq As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StiGrid6 As STIControles.stiGrid
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StiGrid5 As STIControles.stiGrid
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnQuitarGasto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGasto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridSinGastos As STIControles.stiGrid
    Friend WithEvents VistaSinGastos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBienesSumas As STIControles.stiComboBox
    Friend WithEvents cboTipoBien As STIControles.stiComboBox
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn

End Class
