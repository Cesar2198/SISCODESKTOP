<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstGestionesPolizas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstGestionesPolizas))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.ColGestionPend = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesTramite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridPolizas = New STIControles.stiGrid
        Me.mnuGestion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarGestiónDePolizasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarGestiónDePolizasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VistaPolizas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.optPolizas = New System.Windows.Forms.RadioButton
        Me.optOfertas = New System.Windows.Forms.RadioButton
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.txtFecha = New STIControles.stiTextBox
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lblGesAtrasada = New DevExpress.XtraEditors.LabelControl
        Me.txtDesde = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuGestion.SuspendLayout()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(647, 394)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(544, 394)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(750, 394)
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
        Me.LabelControl1.Size = New System.Drawing.Size(271, 74)
        Me.LabelControl1.Text = "Gestiones para Póliza / Ofertas"
        '
        'ColGestionPend
        '
        Me.ColGestionPend.Caption = "Gestión Pendiente"
        Me.ColGestionPend.FieldName = "GestionPendiente"
        Me.ColGestionPend.Name = "ColGestionPend"
        '
        'colGesTramite
        '
        Me.colGesTramite.Caption = "Gestión en Trámite"
        Me.colGesTramite.FieldName = "GestionTramite"
        Me.colGesTramite.Name = "colGesTramite"
        '
        'GridPolizas
        '
        Me.GridPolizas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPolizas.ColumnasAdicionales = ""
        Me.GridPolizas.ContextMenuStrip = Me.mnuGestion
        Me.GridPolizas.Location = New System.Drawing.Point(4, 78)
        Me.GridPolizas.MainView = Me.VistaPolizas
        Me.GridPolizas.Name = "GridPolizas"
        Me.GridPolizas.NombreTabla = ""
        Me.GridPolizas.Size = New System.Drawing.Size(844, 312)
        Me.GridPolizas.TabIndex = 17
        Me.GridPolizas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPolizas})
        '
        'mnuGestion
        '
        Me.mnuGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarGestiónDePolizasToolStripMenuItem, Me.ConsultarGestiónDePolizasToolStripMenuItem})
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(219, 48)
        '
        'AgregarGestiónDePolizasToolStripMenuItem
        '
        Me.AgregarGestiónDePolizasToolStripMenuItem.Name = "AgregarGestiónDePolizasToolStripMenuItem"
        Me.AgregarGestiónDePolizasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AgregarGestiónDePolizasToolStripMenuItem.Text = "Agregar Gestión de Póliza"
        '
        'ConsultarGestiónDePolizasToolStripMenuItem
        '
        Me.ConsultarGestiónDePolizasToolStripMenuItem.Name = "ConsultarGestiónDePolizasToolStripMenuItem"
        Me.ConsultarGestiónDePolizasToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ConsultarGestiónDePolizasToolStripMenuItem.Text = "Consultar Gestión de Póliza"
        '
        'VistaPolizas
        '
        Me.VistaPolizas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaPolizas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaPolizas.ColumnPanelRowHeight = 35
        Me.VistaPolizas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPoliza, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.ColGestionPend, Me.colGesTramite, Me.GridColumn1, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.ColGestionPend
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Value1 = 1
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colGesTramite
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition2.Value1 = 1
        Me.VistaPolizas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.VistaPolizas.GridControl = Me.GridPolizas
        Me.VistaPolizas.GroupCount = 1
        Me.VistaPolizas.Name = "VistaPolizas"
        Me.VistaPolizas.OptionsBehavior.AutoExpandAllGroups = True
        Me.VistaPolizas.OptionsBehavior.Editable = False
        Me.VistaPolizas.OptionsView.ShowAutoFilterRow = True
        Me.VistaPolizas.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPoliza
        '
        Me.colPoliza.Caption = "Póliza"
        Me.colPoliza.FieldName = "IdPoliza"
        Me.colPoliza.Name = "colPoliza"
        Me.colPoliza.Visible = True
        Me.colPoliza.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Producto"
        Me.GridColumn2.FieldName = "Producto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Aseguradora"
        Me.GridColumn3.FieldName = "Aseguradora"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nombre Cliente"
        Me.GridColumn4.FieldName = "Cliente"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vigencia Desde"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "VigenciaDesde"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Vigencia Hasta"
        Me.GridColumn6.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "VigenciaHasta"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Suma Asegurada"
        Me.GridColumn7.DisplayFormat.FormatString = "c"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "SumaAsegurada"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Prima Neta"
        Me.GridColumn8.DisplayFormat.FormatString = "c"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "PrimaNeta"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "No.Vigencia"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "NumVigencia"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Estado"
        Me.GridColumn10.FieldName = "EstadoPoliza"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Vendedor"
        Me.GridColumn11.FieldName = "Vendedor"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "IdProducto"
        Me.GridColumn12.FieldName = "IdProducto"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "EMail"
        Me.GridColumn13.FieldName = "EMail"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 10
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Teléfono"
        Me.GridColumn14.FieldName = "Telefono"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 11
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Fax"
        Me.GridColumn15.FieldName = "Fax"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 12
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Dirección"
        Me.GridColumn16.FieldName = "Direccion"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 13
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Cliente"
        Me.GridColumn1.FieldName = "IdCliente"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Cod. Producto"
        Me.GridColumn17.FieldName = "IdProducto"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Ramo"
        Me.GridColumn18.FieldName = "IdRamo"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Plan"
        Me.GridColumn19.FieldName = "ResumenPlan"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Número Cuotas"
        Me.GridColumn20.FieldName = "Cuotas"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Última Gestión"
        Me.GridColumn21.FieldName = "UltimaGestion"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'optPolizas
        '
        Me.optPolizas.AutoSize = True
        Me.optPolizas.Checked = True
        Me.optPolizas.Location = New System.Drawing.Point(416, 55)
        Me.optPolizas.Name = "optPolizas"
        Me.optPolizas.Size = New System.Drawing.Size(57, 17)
        Me.optPolizas.TabIndex = 18
        Me.optPolizas.TabStop = True
        Me.optPolizas.Text = "Pólizas"
        Me.optPolizas.UseVisualStyleBackColor = True
        '
        'optOfertas
        '
        Me.optOfertas.AutoSize = True
        Me.optOfertas.Location = New System.Drawing.Point(479, 55)
        Me.optOfertas.Name = "optOfertas"
        Me.optOfertas.Size = New System.Drawing.Size(62, 17)
        Me.optOfertas.TabIndex = 19
        Me.optOfertas.Text = "Ofertas"
        Me.optOfertas.UseVisualStyleBackColor = True
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
        Me.cboEjecutivoCta.FilasVisibles = 189
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 85
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(414, 25)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(437, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 21
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(743, 47)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(106, 28)
        Me.btnBuscar.TabIndex = 22
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
        Me.txtFecha.Formato = "dd/MMM/yyyy"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha Hasta"
        Me.txtFecha.LabelWidth = 85
        Me.txtFecha.Location = New System.Drawing.Point(634, 3)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(217, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 20
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(4, 408)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Gestión en Trámite"
        '
        'lblGesAtrasada
        '
        Me.lblGesAtrasada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGesAtrasada.Appearance.BackColor = System.Drawing.Color.Red
        Me.lblGesAtrasada.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblGesAtrasada.Appearance.Options.UseBackColor = True
        Me.lblGesAtrasada.Appearance.Options.UseForeColor = True
        Me.lblGesAtrasada.Location = New System.Drawing.Point(4, 394)
        Me.lblGesAtrasada.Name = "lblGesAtrasada"
        Me.lblGesAtrasada.Size = New System.Drawing.Size(83, 13)
        Me.lblGesAtrasada.TabIndex = 23
        Me.lblGesAtrasada.Text = "Gestión Atrasada"
        '
        'txtDesde
        '
        Me.txtDesde.CampoBusqueda = False
        Me.txtDesde.CampoEsLlave = False
        Me.txtDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtDesde.FechaActual = True
        Me.txtDesde.Formato = "dd/MMM/yyyy"
        Me.txtDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDesde.LabelText = "Fecha Desde"
        Me.txtDesde.LabelWidth = 85
        Me.txtDesde.Location = New System.Drawing.Point(414, 3)
        Me.txtDesde.MaxLength = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreCampo = ""
        Me.txtDesde.Obligatorio = False
        Me.txtDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.Size = New System.Drawing.Size(217, 20)
        Me.txtDesde.SoloLectura = False
        Me.txtDesde.TabIndex = 25
        Me.txtDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtDesde.Valor = Nothing
        '
        'LstGestionesPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 528
        Me.ClientSize = New System.Drawing.Size(853, 432)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lblGesAtrasada)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.optOfertas)
        Me.Controls.Add(Me.GridPolizas)
        Me.Controls.Add(Me.optPolizas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "LstGestionesPolizas"
        Me.Text = "Gestiones..."
        Me.Controls.SetChildIndex(Me.optPolizas, 0)
        Me.Controls.SetChildIndex(Me.GridPolizas, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.optOfertas, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.lblGesAtrasada, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtDesde, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuGestion.ResumeLayout(False)
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridPolizas As STIControles.stiGrid
    Friend WithEvents VistaPolizas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents optPolizas As System.Windows.Forms.RadioButton
    Friend WithEvents optOfertas As System.Windows.Forms.RadioButton
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents colPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuGestion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarGestiónDePolizasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarGestiónDePolizasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGesAtrasada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColGestionPend As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesTramite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDesde As STIControles.stiTextBox

End Class
