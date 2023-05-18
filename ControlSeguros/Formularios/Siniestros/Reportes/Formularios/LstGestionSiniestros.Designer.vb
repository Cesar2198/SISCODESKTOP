<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstGestionSiniestros
    Inherits stiFomularios.stiReportes

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstGestionSiniestros))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colDias = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGestionPendiente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGestionTramite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.txtFecha = New STIControles.stiTextBox
        Me.GridSiniestros = New STIControles.stiGrid
        Me.mnuGestion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarGestiónDeSiniestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CosultarGestionesClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VistaSiniestros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaIncurrido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRango = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalPendiente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalPagado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColAsegurado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuariograba = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdSiniestroAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lblGesAtrasada = New DevExpress.XtraEditors.LabelControl
        Me.lblLog = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuGestion.SuspendLayout()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(621, 338)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(518, 338)
        Me.btnImprimir.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(724, 338)
        Me.btnSalir.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(275, 74)
        Me.LabelControl1.Text = "Gestiones de Siniestros"
        '
        'colDias
        '
        Me.colDias.Caption = "Días"
        Me.colDias.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDias.FieldName = "Dias"
        Me.colDias.Name = "colDias"
        Me.colDias.Visible = True
        Me.colDias.VisibleIndex = 8
        Me.colDias.Width = 49
        '
        'colGestionPendiente
        '
        Me.colGestionPendiente.Caption = "GestionPendiente"
        Me.colGestionPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGestionPendiente.FieldName = "GestionPendiente"
        Me.colGestionPendiente.Name = "colGestionPendiente"
        '
        'colGestionTramite
        '
        Me.colGestionTramite.Caption = "GestionTramite"
        Me.colGestionTramite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGestionTramite.FieldName = "GestionTramite"
        Me.colGestionTramite.Name = "colGestionTramite"
        '
        'cboEjecutivoCta
        '
        Me.cboEjecutivoCta.CampoAutoCompletar = 0
        Me.cboEjecutivoCta.CampoBusqueda = False
        Me.cboEjecutivoCta.CampoDisplay = 1
        Me.cboEjecutivoCta.CampoEsLlave = False
        Me.cboEjecutivoCta.CampoValor = 0
        Me.cboEjecutivoCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjecutivoCta.ControlBackColor = System.Drawing.Color.White
        Me.cboEjecutivoCta.ControlForeColor = System.Drawing.Color.Black
        Me.cboEjecutivoCta.FilasVisibles = 118
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(418, 28)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(335, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 1
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(670, 48)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Búscar"
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = False
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.White
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = True
        Me.txtFecha.Formato = "Long Date"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha de Corte"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(418, 5)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(337, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'GridSiniestros
        '
        Me.GridSiniestros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSiniestros.ColumnasAdicionales = ""
        Me.GridSiniestros.ContextMenuStrip = Me.mnuGestion
        Me.GridSiniestros.Location = New System.Drawing.Point(4, 76)
        Me.GridSiniestros.MainView = Me.VistaSiniestros
        Me.GridSiniestros.Name = "GridSiniestros"
        Me.GridSiniestros.NombreTabla = ""
        Me.GridSiniestros.Size = New System.Drawing.Size(818, 252)
        Me.GridSiniestros.TabIndex = 3
        Me.GridSiniestros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaSiniestros})
        '
        'mnuGestion
        '
        Me.mnuGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarGestiónDeSiniestrosToolStripMenuItem, Me.CosultarGestionesClienteToolStripMenuItem})
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(240, 48)
        '
        'AgregarGestiónDeSiniestrosToolStripMenuItem
        '
        Me.AgregarGestiónDeSiniestrosToolStripMenuItem.Name = "AgregarGestiónDeSiniestrosToolStripMenuItem"
        Me.AgregarGestiónDeSiniestrosToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AgregarGestiónDeSiniestrosToolStripMenuItem.Text = "Agregar Gestión de Siniestros"
        '
        'CosultarGestionesClienteToolStripMenuItem
        '
        Me.CosultarGestionesClienteToolStripMenuItem.Name = "CosultarGestionesClienteToolStripMenuItem"
        Me.CosultarGestionesClienteToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CosultarGestionesClienteToolStripMenuItem.Text = "Cosultar Gestiones del Siniestro"
        '
        'VistaSiniestros
        '
        Me.VistaSiniestros.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaSiniestros.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaSiniestros.ColumnPanelRowHeight = 35
        Me.VistaSiniestros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAseguradora, Me.colIdPoliza, Me.colProducto, Me.colIdCertificado, Me.colIdSiniestro, Me.colFechaIncurrido, Me.colFechaPresentado, Me.colRango, Me.colDias, Me.colTotalPresentado, Me.colTotalPendiente, Me.colTotalPagado, Me.colGestionPendiente, Me.colGestionTramite, Me.colIdProducto, Me.ColAsegurado, Me.colGrupoCliente, Me.colUsuariograba, Me.colIdSiniestroAseguradora})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colDias
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Value1 = 60
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colGestionPendiente
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition2.Value1 = 1
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colGestionTramite
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition3.Value1 = 1
        Me.VistaSiniestros.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.VistaSiniestros.GridControl = Me.GridSiniestros
        Me.VistaSiniestros.GroupCount = 1
        Me.VistaSiniestros.Name = "VistaSiniestros"
        Me.VistaSiniestros.OptionsBehavior.AutoExpandAllGroups = True
        Me.VistaSiniestros.OptionsBehavior.Editable = False
        Me.VistaSiniestros.OptionsView.ShowAutoFilterRow = True
        Me.VistaSiniestros.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAseguradora, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colAseguradora
        '
        Me.colAseguradora.Caption = "Aseguradora"
        Me.colAseguradora.FieldName = "Aseguradora"
        Me.colAseguradora.Name = "colAseguradora"
        Me.colAseguradora.Width = 87
        '
        'colIdPoliza
        '
        Me.colIdPoliza.Caption = "Póliza"
        Me.colIdPoliza.FieldName = "IdPoliza"
        Me.colIdPoliza.Name = "colIdPoliza"
        Me.colIdPoliza.Visible = True
        Me.colIdPoliza.VisibleIndex = 0
        Me.colIdPoliza.Width = 53
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 59
        '
        'colIdCertificado
        '
        Me.colIdCertificado.Caption = "Certificado"
        Me.colIdCertificado.FieldName = "IdCertificado"
        Me.colIdCertificado.Name = "colIdCertificado"
        Me.colIdCertificado.Visible = True
        Me.colIdCertificado.VisibleIndex = 2
        Me.colIdCertificado.Width = 64
        '
        'colIdSiniestro
        '
        Me.colIdSiniestro.Caption = "No. Reclamo"
        Me.colIdSiniestro.FieldName = "IdSiniestro"
        Me.colIdSiniestro.Name = "colIdSiniestro"
        Me.colIdSiniestro.Visible = True
        Me.colIdSiniestro.VisibleIndex = 3
        Me.colIdSiniestro.Width = 64
        '
        'colFechaIncurrido
        '
        Me.colFechaIncurrido.Caption = "Fecha Ocurrido"
        Me.colFechaIncurrido.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaIncurrido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaIncurrido.FieldName = "FechaIncurrido"
        Me.colFechaIncurrido.Name = "colFechaIncurrido"
        Me.colFechaIncurrido.Visible = True
        Me.colFechaIncurrido.VisibleIndex = 5
        '
        'colFechaPresentado
        '
        Me.colFechaPresentado.Caption = "Fecha Presentado"
        Me.colFechaPresentado.FieldName = "FechaPresentado"
        Me.colFechaPresentado.Name = "colFechaPresentado"
        Me.colFechaPresentado.Visible = True
        Me.colFechaPresentado.VisibleIndex = 6
        Me.colFechaPresentado.Width = 87
        '
        'colRango
        '
        Me.colRango.Caption = "Rango Atraso"
        Me.colRango.FieldName = "Rango"
        Me.colRango.Name = "colRango"
        Me.colRango.Visible = True
        Me.colRango.VisibleIndex = 7
        Me.colRango.Width = 68
        '
        'colTotalPresentado
        '
        Me.colTotalPresentado.Caption = "Total Presentado"
        Me.colTotalPresentado.DisplayFormat.FormatString = "c"
        Me.colTotalPresentado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPresentado.FieldName = "TotalPresentado"
        Me.colTotalPresentado.Name = "colTotalPresentado"
        Me.colTotalPresentado.Visible = True
        Me.colTotalPresentado.VisibleIndex = 9
        '
        'colTotalPendiente
        '
        Me.colTotalPendiente.Caption = "Total Pendiente"
        Me.colTotalPendiente.DisplayFormat.FormatString = "c"
        Me.colTotalPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPendiente.FieldName = "TotalPendiente"
        Me.colTotalPendiente.Name = "colTotalPendiente"
        Me.colTotalPendiente.Visible = True
        Me.colTotalPendiente.VisibleIndex = 10
        Me.colTotalPendiente.Width = 73
        '
        'colTotalPagado
        '
        Me.colTotalPagado.Caption = "Total Pagado"
        Me.colTotalPagado.DisplayFormat.FormatString = "c"
        Me.colTotalPagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPagado.FieldName = "TotalReembolso"
        Me.colTotalPagado.Name = "colTotalPagado"
        Me.colTotalPagado.Visible = True
        Me.colTotalPagado.VisibleIndex = 11
        Me.colTotalPagado.Width = 71
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "IdProducto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        '
        'ColAsegurado
        '
        Me.ColAsegurado.Caption = "Asegurado / Beneficiario"
        Me.ColAsegurado.FieldName = "Asegurado"
        Me.ColAsegurado.Name = "ColAsegurado"
        Me.ColAsegurado.Visible = True
        Me.ColAsegurado.VisibleIndex = 4
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.Caption = "Grupo Cliente"
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        '
        'colUsuariograba
        '
        Me.colUsuariograba.Caption = "Usuario Grabación"
        Me.colUsuariograba.FieldName = "UsuarioGraba"
        Me.colUsuariograba.Name = "colUsuariograba"
        '
        'colIdSiniestroAseguradora
        '
        Me.colIdSiniestroAseguradora.Caption = "No. Siniestro Aseguradora"
        Me.colIdSiniestroAseguradora.FieldName = "IdSiniestroAseguradora"
        Me.colIdSiniestroAseguradora.Name = "colIdSiniestroAseguradora"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(4, 345)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Gestión en Trámite"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(4, 359)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(191, 13)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "Siniestros de más de 30 días pendientes"
        '
        'lblGesAtrasada
        '
        Me.lblGesAtrasada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGesAtrasada.Appearance.BackColor = System.Drawing.Color.Red
        Me.lblGesAtrasada.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblGesAtrasada.Appearance.Options.UseBackColor = True
        Me.lblGesAtrasada.Appearance.Options.UseForeColor = True
        Me.lblGesAtrasada.Location = New System.Drawing.Point(4, 331)
        Me.lblGesAtrasada.Name = "lblGesAtrasada"
        Me.lblGesAtrasada.Size = New System.Drawing.Size(83, 13)
        Me.lblGesAtrasada.TabIndex = 23
        Me.lblGesAtrasada.Text = "Gestión Atrasada"
        '
        'lblLog
        '
        Me.lblLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLog.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLog.Appearance.Options.UseFont = True
        Me.lblLog.Location = New System.Drawing.Point(205, 334)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(0, 13)
        Me.lblLog.TabIndex = 27
        '
        'LstGestionSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 807
        Me.ClientSize = New System.Drawing.Size(827, 376)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblGesAtrasada)
        Me.Controls.Add(Me.GridSiniestros)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "LstGestionSiniestros"
        Me.Text = "Gestiones"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.GridSiniestros, 0)
        Me.Controls.SetChildIndex(Me.lblGesAtrasada, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.lblLog, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuGestion.ResumeLayout(False)
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents GridSiniestros As STIControles.stiGrid
    Friend WithEvents VistaSiniestros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAseguradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIncurrido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRango As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPagado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGesAtrasada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGestionPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGestionTramite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuGestion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarGestiónDeSiniestrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CosultarGestionesClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblLog As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColAsegurado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuariograba As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSiniestroAseguradora As DevExpress.XtraGrid.Columns.GridColumn

End Class
