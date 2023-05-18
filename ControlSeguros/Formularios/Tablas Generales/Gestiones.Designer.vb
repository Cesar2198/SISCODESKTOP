<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestiones))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GridRegistro = New STIControles.stiGrid
        Me.VistaRegistro = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridGestiones = New STIControles.stiGrid
        Me.VistaGestiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaProximaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdTipoGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaGraba = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtFechaInicia = New STIControles.stiTextBox
        Me.txtHora = New DevExpress.XtraEditors.TimeEdit
        Me.txtFechaGrabacion = New STIControles.stiTextBox
        Me.chkCorreo = New DevExpress.XtraEditors.CheckEdit
        Me.txtIdUsuario = New STIControles.stiTextBox
        Me.chkCita = New DevExpress.XtraEditors.CheckEdit
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtIdProducto = New STIControles.stiTextBox
        Me.txtNumeroFactura = New STIControles.stiTextBox
        Me.cboIdAccionTomar = New STIControles.stiComboBox
        Me.cboIdTipoGestion = New STIControles.stiComboBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.cboTipoGestion = New STIControles.stiComboBox
        Me.txtComentarios = New STIControles.stiTextBox
        Me.txtFechaProximaGestion = New STIControles.stiTextBox
        Me.txtFechaGestion = New STIControles.stiTextBox
        Me.txtIdGestion = New STIControles.stiTextBox
        Me.btnIncluirCliente = New DevExpress.XtraEditors.CheckButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(600, 537)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(273, 560)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(241, 563)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(416, 537)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(692, 537)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(508, 537)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(647, 74)
        Me.lblNombreFormulario.Text = "Gestiones"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(257, 560)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 78)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridRegistro)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(783, 456)
        Me.SplitContainerControl1.SplitterPosition = 115
        Me.SplitContainerControl1.TabIndex = 15
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridRegistro
        '
        Me.GridRegistro.ColumnasAdicionales = ""
        Me.GridRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRegistro.Location = New System.Drawing.Point(0, 0)
        Me.GridRegistro.MainView = Me.VistaRegistro
        Me.GridRegistro.Name = "GridRegistro"
        Me.GridRegistro.NombreTabla = ""
        Me.GridRegistro.Size = New System.Drawing.Size(783, 115)
        Me.GridRegistro.TabIndex = 0
        Me.GridRegistro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaRegistro})
        '
        'VistaRegistro
        '
        Me.VistaRegistro.GridControl = Me.GridRegistro
        Me.VistaRegistro.Name = "VistaRegistro"
        Me.VistaRegistro.OptionsBehavior.Editable = False
        Me.VistaRegistro.OptionsView.ShowFooter = True
        Me.VistaRegistro.OptionsView.ShowGroupPanel = False
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(783, 335)
        Me.SplitContainerControl2.SplitterPosition = 317
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GridGestiones)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(460, 335)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "   Historial de Gestiones Relacionadas"
        '
        'GridGestiones
        '
        Me.GridGestiones.ColumnasAdicionales = ""
        Me.GridGestiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGestiones.Location = New System.Drawing.Point(2, 20)
        Me.GridGestiones.MainView = Me.VistaGestiones
        Me.GridGestiones.Name = "GridGestiones"
        Me.GridGestiones.NombreTabla = ""
        Me.GridGestiones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridGestiones.Size = New System.Drawing.Size(456, 313)
        Me.GridGestiones.TabIndex = 1
        Me.GridGestiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaGestiones})
        '
        'VistaGestiones
        '
        Me.VistaGestiones.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaGestiones.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaGestiones.ColumnPanelRowHeight = 40
        Me.VistaGestiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdGestion, Me.colFechaGestion, Me.colFechaProximaGestion, Me.colIdTipoGestion, Me.colComentarios, Me.colFechaGraba})
        Me.VistaGestiones.GridControl = Me.GridGestiones
        Me.VistaGestiones.Name = "VistaGestiones"
        Me.VistaGestiones.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.VistaGestiones.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.VistaGestiones.OptionsBehavior.Editable = False
        Me.VistaGestiones.OptionsView.ShowGroupPanel = False
        '
        'colIdGestion
        '
        Me.colIdGestion.Caption = "Cod.Gestión"
        Me.colIdGestion.FieldName = "IdGestion"
        Me.colIdGestion.Name = "colIdGestion"
        Me.colIdGestion.OptionsColumn.AllowEdit = False
        Me.colIdGestion.Visible = True
        Me.colIdGestion.VisibleIndex = 0
        Me.colIdGestion.Width = 76
        '
        'colFechaGestion
        '
        Me.colFechaGestion.Caption = "Fecha Gestión"
        Me.colFechaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaGestion.FieldName = "FechaGestion"
        Me.colFechaGestion.Name = "colFechaGestion"
        Me.colFechaGestion.OptionsColumn.AllowEdit = False
        Me.colFechaGestion.Visible = True
        Me.colFechaGestion.VisibleIndex = 1
        Me.colFechaGestion.Width = 81
        '
        'colFechaProximaGestion
        '
        Me.colFechaProximaGestion.Caption = "Próxima Gestión"
        Me.colFechaProximaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaProximaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaProximaGestion.FieldName = "FechaProximaGestion"
        Me.colFechaProximaGestion.Name = "colFechaProximaGestion"
        Me.colFechaProximaGestion.OptionsColumn.AllowEdit = False
        Me.colFechaProximaGestion.Visible = True
        Me.colFechaProximaGestion.VisibleIndex = 2
        Me.colFechaProximaGestion.Width = 89
        '
        'colIdTipoGestion
        '
        Me.colIdTipoGestion.Caption = "Gestión"
        Me.colIdTipoGestion.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIdTipoGestion.FieldName = "IdTipoGestion"
        Me.colIdTipoGestion.Name = "colIdTipoGestion"
        Me.colIdTipoGestion.OptionsColumn.AllowEdit = False
        Me.colIdTipoGestion.Visible = True
        Me.colIdTipoGestion.VisibleIndex = 3
        Me.colIdTipoGestion.Width = 97
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colComentarios
        '
        Me.colComentarios.Caption = "Comentarios"
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.OptionsColumn.AllowEdit = False
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 4
        Me.colComentarios.Width = 105
        '
        'colFechaGraba
        '
        Me.colFechaGraba.Caption = "Fecha Grabación"
        Me.colFechaGraba.DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
        Me.colFechaGraba.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaGraba.FieldName = "FechaGrabacion"
        Me.colFechaGraba.Name = "colFechaGraba"
        Me.colFechaGraba.OptionsColumn.AllowEdit = False
        Me.colFechaGraba.Visible = True
        Me.colFechaGraba.VisibleIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtFechaInicia)
        Me.GroupControl1.Controls.Add(Me.txtHora)
        Me.GroupControl1.Controls.Add(Me.txtFechaGrabacion)
        Me.GroupControl1.Controls.Add(Me.chkCorreo)
        Me.GroupControl1.Controls.Add(Me.txtIdUsuario)
        Me.GroupControl1.Controls.Add(Me.chkCita)
        Me.GroupControl1.Controls.Add(Me.txtIdSiniestro)
        Me.GroupControl1.Controls.Add(Me.txtIdPoliza)
        Me.GroupControl1.Controls.Add(Me.txtIdProducto)
        Me.GroupControl1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupControl1.Controls.Add(Me.cboIdAccionTomar)
        Me.GroupControl1.Controls.Add(Me.cboIdTipoGestion)
        Me.GroupControl1.Controls.Add(Me.txtIdCertificado)
        Me.GroupControl1.Controls.Add(Me.cboTipoGestion)
        Me.GroupControl1.Controls.Add(Me.txtComentarios)
        Me.GroupControl1.Controls.Add(Me.txtFechaProximaGestion)
        Me.GroupControl1.Controls.Add(Me.txtFechaGestion)
        Me.GroupControl1.Controls.Add(Me.txtIdGestion)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(317, 335)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "   Detalle de Gestión"
        '
        'txtFechaInicia
        '
        Me.txtFechaInicia.CampoBusqueda = False
        Me.txtFechaInicia.CampoEsLlave = False
        Me.txtFechaInicia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInicia.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaInicia.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInicia.FechaActual = False
        Me.txtFechaInicia.Formato = "dd/MMM/yyyy"
        Me.txtFechaInicia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaInicia.LabelText = "Fecha Inicia Gestión"
        Me.txtFechaInicia.LabelWidth = 120
        Me.txtFechaInicia.Location = New System.Drawing.Point(5, 177)
        Me.txtFechaInicia.MaxLength = 0
        Me.txtFechaInicia.Name = "txtFechaInicia"
        Me.txtFechaInicia.NombreCampo = "FechaInicia"
        Me.txtFechaInicia.Obligatorio = False
        Me.txtFechaInicia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInicia.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaInicia.SoloLectura = False
        Me.txtFechaInicia.TabIndex = 5
        Me.txtFechaInicia.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInicia.Valor = Nothing
        '
        'txtHora
        '
        Me.txtHora.EditValue = New Date(2015, 1, 15, 0, 0, 0, 0)
        Me.txtHora.Location = New System.Drawing.Point(204, 205)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 18
        '
        'txtFechaGrabacion
        '
        Me.txtFechaGrabacion.CampoBusqueda = False
        Me.txtFechaGrabacion.CampoEsLlave = False
        Me.txtFechaGrabacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaGrabacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaGrabacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaGrabacion.FechaActual = False
        Me.txtFechaGrabacion.Formato = ""
        Me.txtFechaGrabacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaGrabacion.LabelText = "Graba"
        Me.txtFechaGrabacion.LabelWidth = 35
        Me.txtFechaGrabacion.Location = New System.Drawing.Point(233, 296)
        Me.txtFechaGrabacion.MaxLength = 50
        Me.txtFechaGrabacion.Name = "txtFechaGrabacion"
        Me.txtFechaGrabacion.NombreCampo = "FechaGrabacion"
        Me.txtFechaGrabacion.Obligatorio = False
        Me.txtFechaGrabacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaGrabacion.Size = New System.Drawing.Size(54, 20)
        Me.txtFechaGrabacion.SoloLectura = True
        Me.txtFechaGrabacion.TabIndex = 17
        Me.txtFechaGrabacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtFechaGrabacion.Valor = ""
        Me.txtFechaGrabacion.Visible = False
        '
        'chkCorreo
        '
        Me.chkCorreo.Location = New System.Drawing.Point(17, 225)
        Me.chkCorreo.Name = "chkCorreo"
        Me.chkCorreo.Properties.Caption = "Preparar correo con gestión"
        Me.chkCorreo.Size = New System.Drawing.Size(180, 19)
        Me.chkCorreo.TabIndex = 13
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.CampoBusqueda = False
        Me.txtIdUsuario.CampoEsLlave = False
        Me.txtIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdUsuario.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdUsuario.FechaActual = False
        Me.txtIdUsuario.Formato = ""
        Me.txtIdUsuario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdUsuario.LabelText = "Usuario"
        Me.txtIdUsuario.LabelWidth = 35
        Me.txtIdUsuario.Location = New System.Drawing.Point(173, 296)
        Me.txtIdUsuario.MaxLength = 25
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.NombreCampo = "IdUsuario"
        Me.txtIdUsuario.Obligatorio = False
        Me.txtIdUsuario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdUsuario.Size = New System.Drawing.Size(54, 20)
        Me.txtIdUsuario.SoloLectura = True
        Me.txtIdUsuario.TabIndex = 12
        Me.txtIdUsuario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdUsuario.Valor = ""
        Me.txtIdUsuario.Visible = False
        '
        'chkCita
        '
        Me.chkCita.Location = New System.Drawing.Point(17, 205)
        Me.chkCita.Name = "chkCita"
        Me.chkCita.Properties.Caption = "Agregar a Calendario Outlook"
        Me.chkCita.Size = New System.Drawing.Size(180, 19)
        Me.chkCita.TabIndex = 11
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = False
        Me.txtIdSiniestro.CampoEsLlave = False
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Siniestro"
        Me.txtIdSiniestro.LabelWidth = 60
        Me.txtIdSiniestro.Location = New System.Drawing.Point(164, 270)
        Me.txtIdSiniestro.MaxLength = 25
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = "IdSiniestro"
        Me.txtIdSiniestro.Obligatorio = False
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(141, 20)
        Me.txtIdSiniestro.SoloLectura = True
        Me.txtIdSiniestro.TabIndex = 10
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = False
        Me.txtIdPoliza.CampoEsLlave = False
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 60
        Me.txtIdPoliza.Location = New System.Drawing.Point(5, 247)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(153, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 9
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtIdProducto
        '
        Me.txtIdProducto.CampoBusqueda = False
        Me.txtIdProducto.CampoEsLlave = False
        Me.txtIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdProducto.FechaActual = False
        Me.txtIdProducto.Formato = ""
        Me.txtIdProducto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdProducto.LabelText = "Producto"
        Me.txtIdProducto.LabelWidth = 60
        Me.txtIdProducto.Location = New System.Drawing.Point(5, 270)
        Me.txtIdProducto.MaxLength = 25
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.NombreCampo = "IdProducto"
        Me.txtIdProducto.Obligatorio = False
        Me.txtIdProducto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdProducto.Size = New System.Drawing.Size(153, 20)
        Me.txtIdProducto.SoloLectura = True
        Me.txtIdProducto.TabIndex = 8
        Me.txtIdProducto.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdProducto.Valor = ""
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.CampoBusqueda = False
        Me.txtNumeroFactura.CampoEsLlave = False
        Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroFactura.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNumeroFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroFactura.FechaActual = False
        Me.txtNumeroFactura.Formato = "###0"
        Me.txtNumeroFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroFactura.LabelText = "Factura"
        Me.txtNumeroFactura.LabelWidth = 60
        Me.txtNumeroFactura.Location = New System.Drawing.Point(164, 247)
        Me.txtNumeroFactura.MaxLength = 0
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.NombreCampo = "NumeroFactura"
        Me.txtNumeroFactura.Obligatorio = False
        Me.txtNumeroFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroFactura.Size = New System.Drawing.Size(141, 20)
        Me.txtNumeroFactura.SoloLectura = True
        Me.txtNumeroFactura.TabIndex = 7
        Me.txtNumeroFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumeroFactura.Valor = 0
        '
        'cboIdAccionTomar
        '
        Me.cboIdAccionTomar.CampoAutoCompletar = 0
        Me.cboIdAccionTomar.CampoBusqueda = False
        Me.cboIdAccionTomar.CampoDisplay = 1
        Me.cboIdAccionTomar.CampoEsLlave = False
        Me.cboIdAccionTomar.CampoValor = 0
        Me.cboIdAccionTomar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAccionTomar.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAccionTomar.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAccionTomar.FilasVisibles = 74
        Me.cboIdAccionTomar.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAccionTomar.LabelText = "Acción a Tomar"
        Me.cboIdAccionTomar.LabelWidth = 120
        Me.cboIdAccionTomar.Lista = ""
        Me.cboIdAccionTomar.Location = New System.Drawing.Point(5, 133)
        Me.cboIdAccionTomar.MostrarBusquedaColumnas = False
        Me.cboIdAccionTomar.Name = "cboIdAccionTomar"
        Me.cboIdAccionTomar.NombreCampo = "IdAccionTomar"
        Me.cboIdAccionTomar.Obligatorio = False
        Me.cboIdAccionTomar.Query = "select IdTipoGestion as Id, NombreGestion as Concepto from TipoGestion where Cate" & _
            "goria = 'A'"
        Me.cboIdAccionTomar.SelectIndex = 0
        Me.cboIdAccionTomar.Size = New System.Drawing.Size(300, 20)
        Me.cboIdAccionTomar.SoloLectura = False
        Me.cboIdAccionTomar.StringConection = ""
        Me.cboIdAccionTomar.TabIndex = 3
        Me.cboIdAccionTomar.TextoNuevoItem = ""
        Me.cboIdAccionTomar.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAccionTomar.Valor = ""
        '
        'cboIdTipoGestion
        '
        Me.cboIdTipoGestion.CampoAutoCompletar = 0
        Me.cboIdTipoGestion.CampoBusqueda = False
        Me.cboIdTipoGestion.CampoDisplay = 1
        Me.cboIdTipoGestion.CampoEsLlave = False
        Me.cboIdTipoGestion.CampoValor = 0
        Me.cboIdTipoGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdTipoGestion.ControlBackColor = System.Drawing.Color.White
        Me.cboIdTipoGestion.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdTipoGestion.FilasVisibles = 74
        Me.cboIdTipoGestion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdTipoGestion.LabelText = "Gestión"
        Me.cboIdTipoGestion.LabelWidth = 120
        Me.cboIdTipoGestion.Lista = ""
        Me.cboIdTipoGestion.Location = New System.Drawing.Point(5, 89)
        Me.cboIdTipoGestion.MostrarBusquedaColumnas = False
        Me.cboIdTipoGestion.Name = "cboIdTipoGestion"
        Me.cboIdTipoGestion.NombreCampo = "IdTipoGestion"
        Me.cboIdTipoGestion.Obligatorio = False
        Me.cboIdTipoGestion.Query = "select IdTipoGestion as Id, NombreGestion as Concepto from TipoGestion where Cate" & _
            "goria = 'C'"
        Me.cboIdTipoGestion.SelectIndex = 0
        Me.cboIdTipoGestion.Size = New System.Drawing.Size(300, 20)
        Me.cboIdTipoGestion.SoloLectura = False
        Me.cboIdTipoGestion.StringConection = ""
        Me.cboIdTipoGestion.TabIndex = 1
        Me.cboIdTipoGestion.TextoNuevoItem = ""
        Me.cboIdTipoGestion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdTipoGestion.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = False
        Me.txtIdCertificado.CampoEsLlave = False
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 60
        Me.txtIdCertificado.Location = New System.Drawing.Point(5, 296)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = False
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(153, 20)
        Me.txtIdCertificado.SoloLectura = True
        Me.txtIdCertificado.TabIndex = 14
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        Me.txtIdCertificado.Visible = False
        '
        'cboTipoGestion
        '
        Me.cboTipoGestion.CampoAutoCompletar = 0
        Me.cboTipoGestion.CampoBusqueda = False
        Me.cboTipoGestion.CampoDisplay = 1
        Me.cboTipoGestion.CampoEsLlave = False
        Me.cboTipoGestion.CampoValor = 0
        Me.cboTipoGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoGestion.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoGestion.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoGestion.FilasVisibles = 74
        Me.cboTipoGestion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoGestion.LabelText = "Tipo Gestión"
        Me.cboTipoGestion.LabelWidth = 120
        Me.cboTipoGestion.Lista = "C Gestión de Cartera|P Gestión de Pólizas|S Gestión de Siniestros|L Gestión de Cl" & _
            "ientes"
        Me.cboTipoGestion.Location = New System.Drawing.Point(5, 155)
        Me.cboTipoGestion.MostrarBusquedaColumnas = False
        Me.cboTipoGestion.Name = "cboTipoGestion"
        Me.cboTipoGestion.NombreCampo = "TipoGestion"
        Me.cboTipoGestion.Obligatorio = False
        Me.cboTipoGestion.Query = ""
        Me.cboTipoGestion.SelectIndex = 0
        Me.cboTipoGestion.Size = New System.Drawing.Size(300, 20)
        Me.cboTipoGestion.SoloLectura = False
        Me.cboTipoGestion.StringConection = ""
        Me.cboTipoGestion.TabIndex = 4
        Me.cboTipoGestion.TextoNuevoItem = ""
        Me.cboTipoGestion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoGestion.Valor = ""
        '
        'txtComentarios
        '
        Me.txtComentarios.CampoBusqueda = False
        Me.txtComentarios.CampoEsLlave = False
        Me.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtComentarios.ControlBackColor = System.Drawing.Color.White
        Me.txtComentarios.ControlForeColor = System.Drawing.Color.Black
        Me.txtComentarios.FechaActual = False
        Me.txtComentarios.Formato = ""
        Me.txtComentarios.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtComentarios.LabelText = "Comentarios"
        Me.txtComentarios.LabelWidth = 120
        Me.txtComentarios.Location = New System.Drawing.Point(5, 67)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.NombreCampo = "Comentarios"
        Me.txtComentarios.Obligatorio = False
        Me.txtComentarios.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentarios.Size = New System.Drawing.Size(300, 20)
        Me.txtComentarios.SoloLectura = False
        Me.txtComentarios.TabIndex = 0
        Me.txtComentarios.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtComentarios.Valor = ""
        '
        'txtFechaProximaGestion
        '
        Me.txtFechaProximaGestion.CampoBusqueda = False
        Me.txtFechaProximaGestion.CampoEsLlave = False
        Me.txtFechaProximaGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaProximaGestion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaProximaGestion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaProximaGestion.FechaActual = False
        Me.txtFechaProximaGestion.Formato = "dd/MMM/yyyy"
        Me.txtFechaProximaGestion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaProximaGestion.LabelText = "Fecha Próx. Gestión"
        Me.txtFechaProximaGestion.LabelWidth = 120
        Me.txtFechaProximaGestion.Location = New System.Drawing.Point(5, 111)
        Me.txtFechaProximaGestion.MaxLength = 0
        Me.txtFechaProximaGestion.Name = "txtFechaProximaGestion"
        Me.txtFechaProximaGestion.NombreCampo = "FechaProximaGestion"
        Me.txtFechaProximaGestion.Obligatorio = False
        Me.txtFechaProximaGestion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaProximaGestion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaProximaGestion.SoloLectura = False
        Me.txtFechaProximaGestion.TabIndex = 2
        Me.txtFechaProximaGestion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaProximaGestion.Valor = Nothing
        '
        'txtFechaGestion
        '
        Me.txtFechaGestion.CampoBusqueda = False
        Me.txtFechaGestion.CampoEsLlave = False
        Me.txtFechaGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaGestion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaGestion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaGestion.FechaActual = True
        Me.txtFechaGestion.Formato = "dd/MMM/yyyy"
        Me.txtFechaGestion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaGestion.LabelText = "Fecha Gestión"
        Me.txtFechaGestion.LabelWidth = 120
        Me.txtFechaGestion.Location = New System.Drawing.Point(5, 45)
        Me.txtFechaGestion.MaxLength = 0
        Me.txtFechaGestion.Name = "txtFechaGestion"
        Me.txtFechaGestion.NombreCampo = "FechaGestion"
        Me.txtFechaGestion.Obligatorio = True
        Me.txtFechaGestion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaGestion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaGestion.SoloLectura = False
        Me.txtFechaGestion.TabIndex = 7
        Me.txtFechaGestion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaGestion.Valor = Nothing
        '
        'txtIdGestion
        '
        Me.txtIdGestion.CampoBusqueda = False
        Me.txtIdGestion.CampoEsLlave = True
        Me.txtIdGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdGestion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdGestion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdGestion.FechaActual = False
        Me.txtIdGestion.Formato = "###0"
        Me.txtIdGestion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdGestion.LabelText = "Cod. Gestión"
        Me.txtIdGestion.LabelWidth = 120
        Me.txtIdGestion.Location = New System.Drawing.Point(5, 23)
        Me.txtIdGestion.MaxLength = 0
        Me.txtIdGestion.Name = "txtIdGestion"
        Me.txtIdGestion.NombreCampo = "IdGestion"
        Me.txtIdGestion.Obligatorio = True
        Me.txtIdGestion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdGestion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdGestion.SoloLectura = False
        Me.txtIdGestion.TabIndex = 6
        Me.txtIdGestion.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdGestion.Valor = 0
        '
        'btnIncluirCliente
        '
        Me.btnIncluirCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIncluirCliente.Appearance.Options.UseTextOptions = True
        Me.btnIncluirCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnIncluirCliente.Image = CType(resources.GetObject("btnIncluirCliente.Image"), System.Drawing.Image)
        Me.btnIncluirCliente.Location = New System.Drawing.Point(2, 537)
        Me.btnIncluirCliente.Name = "btnIncluirCliente"
        Me.btnIncluirCliente.Size = New System.Drawing.Size(135, 33)
        Me.btnIncluirCliente.TabIndex = 16
        Me.btnIncluirCliente.Text = "Facturas Cliente"
        '
        'Gestiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(786, 573)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.btnIncluirCliente)
        Me.Name = "Gestiones"
        Me.Text = "Gestiones"
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnIncluirCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridRegistro As STIControles.stiGrid
    Friend WithEvents VistaRegistro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboTipoGestion As STIControles.stiComboBox
    Friend WithEvents txtComentarios As STIControles.stiTextBox
    Friend WithEvents txtFechaProximaGestion As STIControles.stiTextBox
    Friend WithEvents txtFechaGestion As STIControles.stiTextBox
    Friend WithEvents txtIdGestion As STIControles.stiTextBox
    Friend WithEvents cboIdTipoGestion As STIControles.stiComboBox
    Friend WithEvents cboIdAccionTomar As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtIdProducto As STIControles.stiTextBox
    Friend WithEvents txtNumeroFactura As STIControles.stiTextBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridGestiones As STIControles.stiGrid
    Friend WithEvents VistaGestiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProximaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdTipoGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkCita As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtIdUsuario As STIControles.stiTextBox
    Friend WithEvents chkCorreo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnIncluirCliente As DevExpress.XtraEditors.CheckButton
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtFechaGrabacion As STIControles.stiTextBox
    Friend WithEvents colFechaGraba As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtHora As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtFechaInicia As STIControles.stiTextBox

End Class
