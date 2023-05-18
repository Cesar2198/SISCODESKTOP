<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnviosSiniestrosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnviosSiniestrosMan))
        Me.GridReclamos = New STIControles.stiGrid
        Me.VistaReclamos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboPlan = New STIControles.stiComboBox
        Me.txtIdEnvio = New STIControles.stiTextBox
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaEnvio = New STIControles.stiTextBox
        Me.btnBuscarReclamos = New DevExpress.XtraEditors.SimpleButton
        Me.txtRutaArchivo = New STIControles.stiTextBox
        Me.btnRuta = New DevExpress.XtraEditors.SimpleButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.btnGenerarArchivo = New DevExpress.XtraEditors.SimpleButton
        Me.btnRetiraReclamo = New DevExpress.XtraEditors.SimpleButton
        Me.txtNumSiniestro = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(556, 540)
        Me.btnAyuda.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(372, 540)
        Me.btnBuscar.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(188, 540)
        Me.btnNuevo.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(280, 540)
        Me.btnGuardar.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(648, 540)
        Me.btnSalir.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(464, 540)
        Me.btnEliminar.TabIndex = 8
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(603, 74)
        Me.lblNombreFormulario.Text = "Envíos de Reclamos"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(172, 565)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 11)
        Me.btnGuardarComo.Visible = False
        '
        'GridReclamos
        '
        Me.GridReclamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridReclamos.ColumnasAdicionales = resources.GetString("GridReclamos.ColumnasAdicionales")
        Me.GridReclamos.Location = New System.Drawing.Point(5, 225)
        Me.GridReclamos.MainView = Me.VistaReclamos
        Me.GridReclamos.Name = "GridReclamos"
        Me.GridReclamos.NombreTabla = "EnviosSiniestrosDetalle"
        Me.GridReclamos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCheckEdit1})
        Me.GridReclamos.Size = New System.Drawing.Size(637, 273)
        Me.GridReclamos.TabIndex = 16
        Me.GridReclamos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaReclamos})
        '
        'VistaReclamos
        '
        Me.VistaReclamos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaReclamos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaReclamos.ColumnPanelRowHeight = 40
        Me.VistaReclamos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.VistaReclamos.GridControl = Me.GridReclamos
        Me.VistaReclamos.Name = "VistaReclamos"
        Me.VistaReclamos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "IdEnvio"
        Me.GridColumn5.FieldName = "IdEnvio"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Póliza"
        Me.GridColumn1.FieldName = "IdPoliza"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 57
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Producto"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn2.FieldName = "IdProducto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 80
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Certificado"
        Me.GridColumn3.FieldName = "IdCertificado"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 68
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Núm. Siniestro"
        Me.GridColumn4.FieldName = "IdSiniestro"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 77
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Siniestro Aseguradora"
        Me.GridColumn6.FieldName = "IdSiniestroAseguradora"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Tag = "NOSAVE"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 79
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Marcar Eliminar"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn7.FieldName = "Marcar"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn7.Tag = "NOSAVE"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 56
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Titular"
        Me.GridColumn8.FieldName = "Titular"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Tag = "NOSAVE"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 103
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Asegurado"
        Me.GridColumn9.FieldName = "Asegurado"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Tag = "NOSAVE"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 96
        '
        'cboPlan
        '
        Me.cboPlan.CampoAutoCompletar = 0
        Me.cboPlan.CampoBusqueda = False
        Me.cboPlan.CampoDisplay = 1
        Me.cboPlan.CampoEsLlave = False
        Me.cboPlan.CampoValor = 0
        Me.cboPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPlan.ControlBackColor = System.Drawing.Color.White
        Me.cboPlan.ControlForeColor = System.Drawing.Color.Black
        Me.cboPlan.FilasVisibles = 1237
        Me.cboPlan.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboPlan.LabelText = "Plan Reclamos"
        Me.cboPlan.LabelWidth = 85
        Me.cboPlan.Lista = ""
        Me.cboPlan.Location = New System.Drawing.Point(13, 150)
        Me.cboPlan.MostrarBusquedaColumnas = False
        Me.cboPlan.Name = "cboPlan"
        Me.cboPlan.NombreCampo = "IdPlanReclamo"
        Me.cboPlan.Obligatorio = False
        Me.cboPlan.Query = "select IdPlan as Id, Descripcion as PlanReclamos from SiniestroPlanes order by De" & _
            "scripcion"
        Me.cboPlan.SelectIndex = 0
        Me.cboPlan.Size = New System.Drawing.Size(568, 20)
        Me.cboPlan.SoloLectura = False
        Me.cboPlan.StringConection = ""
        Me.cboPlan.TabIndex = 3
        Me.cboPlan.TextoNuevoItem = ""
        Me.cboPlan.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboPlan.Valor = ""
        '
        'txtIdEnvio
        '
        Me.txtIdEnvio.CampoBusqueda = True
        Me.txtIdEnvio.CampoEsLlave = True
        Me.txtIdEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtIdEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdEnvio.FechaActual = False
        Me.txtIdEnvio.Formato = ""
        Me.txtIdEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdEnvio.LabelText = "Cod. Envio"
        Me.txtIdEnvio.LabelWidth = 85
        Me.txtIdEnvio.Location = New System.Drawing.Point(12, 81)
        Me.txtIdEnvio.MaxLength = 25
        Me.txtIdEnvio.Name = "txtIdEnvio"
        Me.txtIdEnvio.NombreCampo = "IdEnvio"
        Me.txtIdEnvio.Obligatorio = True
        Me.txtIdEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdEnvio.Size = New System.Drawing.Size(281, 20)
        Me.txtIdEnvio.SoloLectura = False
        Me.txtIdEnvio.TabIndex = 11
        Me.txtIdEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdEnvio.Valor = ""
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = True
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "dd/MMM/yyyy"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 85
        Me.txtFechaDesde.Location = New System.Drawing.Point(12, 104)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = "FechaDesde"
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(281, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'txtFechaEnvio
        '
        Me.txtFechaEnvio.CampoBusqueda = True
        Me.txtFechaEnvio.CampoEsLlave = False
        Me.txtFechaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvio.FechaActual = True
        Me.txtFechaEnvio.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvio.LabelText = "Fecha Envío"
        Me.txtFechaEnvio.LabelWidth = 85
        Me.txtFechaEnvio.Location = New System.Drawing.Point(13, 127)
        Me.txtFechaEnvio.MaxLength = 0
        Me.txtFechaEnvio.Name = "txtFechaEnvio"
        Me.txtFechaEnvio.NombreCampo = "FechaEnvio"
        Me.txtFechaEnvio.Obligatorio = True
        Me.txtFechaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvio.Size = New System.Drawing.Size(281, 20)
        Me.txtFechaEnvio.SoloLectura = False
        Me.txtFechaEnvio.TabIndex = 2
        Me.txtFechaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvio.Valor = Nothing
        '
        'btnBuscarReclamos
        '
        Me.btnBuscarReclamos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarReclamos.Appearance.Options.UseTextOptions = True
        Me.btnBuscarReclamos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarReclamos.Image = CType(resources.GetObject("btnBuscarReclamos.Image"), System.Drawing.Image)
        Me.btnBuscarReclamos.Location = New System.Drawing.Point(654, 225)
        Me.btnBuscarReclamos.Name = "btnBuscarReclamos"
        Me.btnBuscarReclamos.Size = New System.Drawing.Size(86, 42)
        Me.btnBuscarReclamos.TabIndex = 4
        Me.btnBuscarReclamos.Text = "&Buscar Reclamos"
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaArchivo.CampoBusqueda = True
        Me.txtRutaArchivo.CampoEsLlave = True
        Me.txtRutaArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRutaArchivo.ControlBackColor = System.Drawing.Color.White
        Me.txtRutaArchivo.ControlForeColor = System.Drawing.Color.Black
        Me.txtRutaArchivo.FechaActual = False
        Me.txtRutaArchivo.Formato = ""
        Me.txtRutaArchivo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtRutaArchivo.LabelText = "Ruta Archivo"
        Me.txtRutaArchivo.LabelWidth = 85
        Me.txtRutaArchivo.Location = New System.Drawing.Point(5, 504)
        Me.txtRutaArchivo.MaxLength = 0
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.NombreCampo = ""
        Me.txtRutaArchivo.Obligatorio = False
        Me.txtRutaArchivo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRutaArchivo.Size = New System.Drawing.Size(637, 20)
        Me.txtRutaArchivo.SoloLectura = False
        Me.txtRutaArchivo.TabIndex = 17
        Me.txtRutaArchivo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRutaArchivo.Valor = ""
        '
        'btnRuta
        '
        Me.btnRuta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRuta.Appearance.Options.UseTextOptions = True
        Me.btnRuta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnRuta.Image = CType(resources.GetObject("btnRuta.Image"), System.Drawing.Image)
        Me.btnRuta.Location = New System.Drawing.Point(654, 500)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(86, 28)
        Me.btnRuta.TabIndex = 18
        Me.btnRuta.Text = "Buscar"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = True
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = True
        Me.txtFechaHasta.Formato = "dd/MMM/yyyy"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 85
        Me.txtFechaHasta.Location = New System.Drawing.Point(299, 104)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = "FechaHasta"
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(281, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(654, 273)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 42)
        Me.btnImprimir.TabIndex = 19
        Me.btnImprimir.Text = "&Imprimir Envio"
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = False
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = False
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 1237
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 85
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(13, 173)
        Me.cboAseguradora.MostrarBusquedaColumnas = False
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = "IdAseguradora"
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select IdAseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nomb" & _
            "re"
        Me.cboAseguradora.SelectIndex = 0
        Me.cboAseguradora.Size = New System.Drawing.Size(568, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 20
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'btnGenerarArchivo
        '
        Me.btnGenerarArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarArchivo.Appearance.Options.UseTextOptions = True
        Me.btnGenerarArchivo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGenerarArchivo.Image = CType(resources.GetObject("btnGenerarArchivo.Image"), System.Drawing.Image)
        Me.btnGenerarArchivo.Location = New System.Drawing.Point(654, 321)
        Me.btnGenerarArchivo.Name = "btnGenerarArchivo"
        Me.btnGenerarArchivo.Size = New System.Drawing.Size(86, 42)
        Me.btnGenerarArchivo.TabIndex = 21
        Me.btnGenerarArchivo.Text = "Generar Archivo"
        '
        'btnRetiraReclamo
        '
        Me.btnRetiraReclamo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetiraReclamo.Appearance.Options.UseTextOptions = True
        Me.btnRetiraReclamo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnRetiraReclamo.Image = CType(resources.GetObject("btnRetiraReclamo.Image"), System.Drawing.Image)
        Me.btnRetiraReclamo.Location = New System.Drawing.Point(654, 452)
        Me.btnRetiraReclamo.Name = "btnRetiraReclamo"
        Me.btnRetiraReclamo.Size = New System.Drawing.Size(86, 42)
        Me.btnRetiraReclamo.TabIndex = 22
        Me.btnRetiraReclamo.Text = "Retirar Reclamo"
        '
        'txtNumSiniestro
        '
        Me.txtNumSiniestro.CampoBusqueda = True
        Me.txtNumSiniestro.CampoEsLlave = False
        Me.txtNumSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtNumSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumSiniestro.FechaActual = True
        Me.txtNumSiniestro.Formato = ""
        Me.txtNumSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumSiniestro.LabelText = "Num. Siniestro"
        Me.txtNumSiniestro.LabelWidth = 85
        Me.txtNumSiniestro.Location = New System.Drawing.Point(299, 127)
        Me.txtNumSiniestro.MaxLength = 0
        Me.txtNumSiniestro.Name = "txtNumSiniestro"
        Me.txtNumSiniestro.NombreCampo = ""
        Me.txtNumSiniestro.Obligatorio = False
        Me.txtNumSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumSiniestro.Size = New System.Drawing.Size(281, 20)
        Me.txtNumSiniestro.SoloLectura = False
        Me.txtNumSiniestro.TabIndex = 23
        Me.txtNumSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumSiniestro.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 3166
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 85
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 196)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = ""
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(568, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 24
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'EnviosSiniestrosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 806
        Me.ClientSize = New System.Drawing.Size(742, 576)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtNumSiniestro)
        Me.Controls.Add(Me.btnRetiraReclamo)
        Me.Controls.Add(Me.btnGenerarArchivo)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.btnRuta)
        Me.Controls.Add(Me.txtRutaArchivo)
        Me.Controls.Add(Me.btnBuscarReclamos)
        Me.Controls.Add(Me.txtFechaEnvio)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.txtIdEnvio)
        Me.Controls.Add(Me.GridReclamos)
        Me.Controls.Add(Me.cboPlan)
        Me.Name = "EnviosSiniestrosMan"
        Me.SeguirAlGrabarActualizar = True
        Me.Text = "Envíos de Reclamos"
        Me.Controls.SetChildIndex(Me.cboPlan, 0)
        Me.Controls.SetChildIndex(Me.GridReclamos, 0)
        Me.Controls.SetChildIndex(Me.txtIdEnvio, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnvio, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarReclamos, 0)
        Me.Controls.SetChildIndex(Me.txtRutaArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnRuta, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnRetiraReclamo, 0)
        Me.Controls.SetChildIndex(Me.txtNumSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridReclamos As STIControles.stiGrid
    Friend WithEvents VistaReclamos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboPlan As STIControles.stiComboBox
    Friend WithEvents txtIdEnvio As STIControles.stiTextBox
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvio As STIControles.stiTextBox
    Friend WithEvents btnBuscarReclamos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRutaArchivo As STIControles.stiTextBox
    Friend WithEvents btnRuta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Public WithEvents btnGenerarArchivo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnRetiraReclamo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumSiniestro As STIControles.stiTextBox
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn

End Class
