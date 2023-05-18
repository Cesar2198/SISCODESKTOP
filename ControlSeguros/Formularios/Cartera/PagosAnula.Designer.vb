<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosAnula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosAnula))
        Me.txtFechaAnula = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtDocumento = New STIControles.stiTextBox
        Me.txtCliente = New STIControles.stiTextBox
        Me.GridFacturas = New STIControles.stiGrid
        Me.VistaFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FACol1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.FACol12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtPoliza = New STIControles.stiTextBox
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtTotal = New STIControles.stiTextBox
        Me.txtTotalImpuestos = New STIControles.stiTextBox
        Me.txtTotalGastos = New STIControles.stiTextBox
        Me.txtTotalPrimaNeta = New STIControles.stiTextBox
        Me.txtFactura = New STIControles.stiTextBox
        Me.txtMotivo = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(311, 394)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(623, 76)
        Me.btnBuscar.Size = New System.Drawing.Size(112, 52)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(45, 425)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(212, 394)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "A&nular"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(409, 394)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(57, 425)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'LabelControl1
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(650, 74)
        Me.lblNombreFormulario.Text = "Anulación de Pagos de Primas de Seguros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(73, 425)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtFechaAnula
        '
        Me.txtFechaAnula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFechaAnula.CampoBusqueda = False
        Me.txtFechaAnula.CampoEsLlave = False
        Me.txtFechaAnula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAnula.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAnula.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAnula.FechaActual = True
        Me.txtFechaAnula.Formato = "Long Date"
        Me.txtFechaAnula.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtFechaAnula.LabelText = "Fecha Efectiva de Anulación de Pago"
        Me.txtFechaAnula.LabelWidth = 100
        Me.txtFechaAnula.Location = New System.Drawing.Point(214, 314)
        Me.txtFechaAnula.MaxLength = 0
        Me.txtFechaAnula.Name = "txtFechaAnula"
        Me.txtFechaAnula.NombreCampo = ""
        Me.txtFechaAnula.Obligatorio = True
        Me.txtFechaAnula.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAnula.Size = New System.Drawing.Size(283, 36)
        Me.txtFechaAnula.SoloLectura = False
        Me.txtFechaAnula.TabIndex = 7
        Me.txtFechaAnula.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAnula.Valor = Nothing
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 100
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(317, 81)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = False
        Me.cboProducto.Query = "select IdProducto,Descripcion from productos"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(300, 20)
        Me.cboProducto.SoloLectura = False
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 3
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'txtDocumento
        '
        Me.txtDocumento.CampoBusqueda = False
        Me.txtDocumento.CampoEsLlave = False
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDocumento.ControlBackColor = System.Drawing.Color.White
        Me.txtDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.txtDocumento.FechaActual = False
        Me.txtDocumento.Formato = ""
        Me.txtDocumento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDocumento.LabelText = "Documento Cliente"
        Me.txtDocumento.LabelWidth = 100
        Me.txtDocumento.Location = New System.Drawing.Point(317, 107)
        Me.txtDocumento.MaxLength = 0
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.NombreCampo = ""
        Me.txtDocumento.Obligatorio = False
        Me.txtDocumento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocumento.Size = New System.Drawing.Size(296, 20)
        Me.txtDocumento.SoloLectura = False
        Me.txtDocumento.TabIndex = 4
        Me.txtDocumento.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDocumento.Valor = ""
        '
        'txtCliente
        '
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCliente.LabelText = "Cliente"
        Me.txtCliente.LabelWidth = 50
        Me.txtCliente.Location = New System.Drawing.Point(12, 107)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(296, 20)
        Me.txtCliente.SoloLectura = False
        Me.txtCliente.TabIndex = 2
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.Location = New System.Drawing.Point(3, 139)
        Me.GridFacturas.MainView = Me.VistaFacturas
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.NombreTabla = ""
        Me.GridFacturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridFacturas.Size = New System.Drawing.Size(784, 169)
        Me.GridFacturas.TabIndex = 8
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaFacturas})
        '
        'VistaFacturas
        '
        Me.VistaFacturas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaFacturas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaFacturas.ColumnPanelRowHeight = 40
        Me.VistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FACol1, Me.FACol2, Me.FACol3, Me.FACol4, Me.FACol5, Me.FACol6, Me.FACol7, Me.FACol14, Me.FACol15, Me.FACol16, Me.FACol8, Me.FACol9, Me.FACol10, Me.FACol11, Me.FACol12, Me.FACol13, Me.FACol17, Me.FACol18, Me.FACol19})
        Me.VistaFacturas.GridControl = Me.GridFacturas
        Me.VistaFacturas.Name = "VistaFacturas"
        Me.VistaFacturas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaFacturas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaFacturas.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.VistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'FACol1
        '
        Me.FACol1.Caption = "No. Factura"
        Me.FACol1.FieldName = "NumFactura"
        Me.FACol1.Name = "FACol1"
        Me.FACol1.OptionsColumn.AllowEdit = False
        Me.FACol1.Visible = True
        Me.FACol1.VisibleIndex = 0
        Me.FACol1.Width = 44
        '
        'FACol2
        '
        Me.FACol2.Caption = "Producto"
        Me.FACol2.FieldName = "Producto"
        Me.FACol2.Name = "FACol2"
        Me.FACol2.OptionsColumn.AllowEdit = False
        Me.FACol2.Visible = True
        Me.FACol2.VisibleIndex = 1
        Me.FACol2.Width = 44
        '
        'FACol3
        '
        Me.FACol3.Caption = "Póliza"
        Me.FACol3.FieldName = "Polizas"
        Me.FACol3.Name = "FACol3"
        Me.FACol3.OptionsColumn.AllowEdit = False
        Me.FACol3.Visible = True
        Me.FACol3.VisibleIndex = 2
        Me.FACol3.Width = 44
        '
        'FACol4
        '
        Me.FACol4.Caption = "Asegurado"
        Me.FACol4.FieldName = "Asegurado"
        Me.FACol4.Name = "FACol4"
        Me.FACol4.OptionsColumn.AllowEdit = False
        Me.FACol4.Visible = True
        Me.FACol4.VisibleIndex = 3
        Me.FACol4.Width = 44
        '
        'FACol5
        '
        Me.FACol5.Caption = "Fecha Vencimiento"
        Me.FACol5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.FACol5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FACol5.FieldName = "FechaPago"
        Me.FACol5.Name = "FACol5"
        Me.FACol5.OptionsColumn.AllowEdit = False
        Me.FACol5.Visible = True
        Me.FACol5.VisibleIndex = 4
        Me.FACol5.Width = 53
        '
        'FACol6
        '
        Me.FACol6.Caption = "No. Cuota"
        Me.FACol6.FieldName = "NumCuota"
        Me.FACol6.Name = "FACol6"
        Me.FACol6.OptionsColumn.AllowEdit = False
        Me.FACol6.Visible = True
        Me.FACol6.VisibleIndex = 6
        Me.FACol6.Width = 43
        '
        'FACol7
        '
        Me.FACol7.Caption = "Prima"
        Me.FACol7.DisplayFormat.FormatString = "c"
        Me.FACol7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol7.FieldName = "Prima"
        Me.FACol7.Name = "FACol7"
        Me.FACol7.OptionsColumn.AllowEdit = False
        Me.FACol7.Visible = True
        Me.FACol7.VisibleIndex = 7
        Me.FACol7.Width = 43
        '
        'FACol14
        '
        Me.FACol14.Caption = "G. Emi."
        Me.FACol14.DisplayFormat.FormatString = "c"
        Me.FACol14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol14.FieldName = "GastosEmision"
        Me.FACol14.Name = "FACol14"
        Me.FACol14.Visible = True
        Me.FACol14.VisibleIndex = 8
        Me.FACol14.Width = 52
        '
        'FACol15
        '
        Me.FACol15.Caption = "G. Frac."
        Me.FACol15.DisplayFormat.FormatString = "c"
        Me.FACol15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol15.FieldName = "GastosFracciona"
        Me.FACol15.Name = "FACol15"
        Me.FACol15.Visible = True
        Me.FACol15.VisibleIndex = 9
        Me.FACol15.Width = 52
        '
        'FACol16
        '
        Me.FACol16.Caption = "G. Bomb."
        Me.FACol16.DisplayFormat.FormatString = "c"
        Me.FACol16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol16.FieldName = "GastosBomberos"
        Me.FACol16.Name = "FACol16"
        Me.FACol16.Visible = True
        Me.FACol16.VisibleIndex = 10
        Me.FACol16.Width = 52
        '
        'FACol8
        '
        Me.FACol8.Caption = "Otros Gastos"
        Me.FACol8.DisplayFormat.FormatString = "c"
        Me.FACol8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol8.FieldName = "Gastos"
        Me.FACol8.Name = "FACol8"
        Me.FACol8.OptionsColumn.AllowEdit = False
        Me.FACol8.Visible = True
        Me.FACol8.VisibleIndex = 11
        Me.FACol8.Width = 43
        '
        'FACol9
        '
        Me.FACol9.Caption = "IVA"
        Me.FACol9.DisplayFormat.FormatString = "c"
        Me.FACol9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol9.FieldName = "Iva"
        Me.FACol9.Name = "FACol9"
        Me.FACol9.OptionsColumn.AllowEdit = False
        Me.FACol9.Visible = True
        Me.FACol9.VisibleIndex = 12
        Me.FACol9.Width = 43
        '
        'FACol10
        '
        Me.FACol10.Caption = "Total"
        Me.FACol10.DisplayFormat.FormatString = "c"
        Me.FACol10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol10.FieldName = "Total"
        Me.FACol10.Name = "FACol10"
        Me.FACol10.OptionsColumn.AllowEdit = False
        Me.FACol10.Visible = True
        Me.FACol10.VisibleIndex = 14
        Me.FACol10.Width = 48
        '
        'FACol11
        '
        Me.FACol11.Caption = "Anular"
        Me.FACol11.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.FACol11.FieldName = "Anular"
        Me.FACol11.Name = "FACol11"
        Me.FACol11.Visible = True
        Me.FACol11.VisibleIndex = 15
        Me.FACol11.Width = 67
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'FACol12
        '
        Me.FACol12.Caption = "IdProducto"
        Me.FACol12.FieldName = "IdProducto"
        Me.FACol12.Name = "FACol12"
        '
        'FACol13
        '
        Me.FACol13.Caption = "Comisión"
        Me.FACol13.FieldName = "Comision"
        Me.FACol13.Name = "FACol13"
        '
        'FACol17
        '
        Me.FACol17.Caption = "IdRamo"
        Me.FACol17.FieldName = "IdRamo"
        Me.FACol17.Name = "FACol17"
        '
        'FACol18
        '
        Me.FACol18.Caption = "Fecha Pagado"
        Me.FACol18.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.FACol18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FACol18.FieldName = "FechaPagoFact"
        Me.FACol18.Name = "FACol18"
        Me.FACol18.Visible = True
        Me.FACol18.VisibleIndex = 5
        Me.FACol18.Width = 52
        '
        'FACol19
        '
        Me.FACol19.Caption = "Ret. Iva"
        Me.FACol19.DisplayFormat.FormatString = "c"
        Me.FACol19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol19.FieldName = "RetencionImpuestos"
        Me.FACol19.Name = "FACol19"
        Me.FACol19.Visible = True
        Me.FACol19.VisibleIndex = 13
        Me.FACol19.Width = 39
        '
        'txtPoliza
        '
        Me.txtPoliza.CampoBusqueda = False
        Me.txtPoliza.CampoEsLlave = False
        Me.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPoliza.FechaActual = False
        Me.txtPoliza.Formato = ""
        Me.txtPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPoliza.LabelText = "Póliza"
        Me.txtPoliza.LabelWidth = 50
        Me.txtPoliza.Location = New System.Drawing.Point(12, 81)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = False
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(154, 20)
        Me.txtPoliza.SoloLectura = False
        Me.txtPoliza.TabIndex = 0
        Me.txtPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPoliza.Valor = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.txtTotal)
        Me.GroupControl1.Controls.Add(Me.txtTotalImpuestos)
        Me.GroupControl1.Controls.Add(Me.txtTotalGastos)
        Me.GroupControl1.Controls.Add(Me.txtTotalPrimaNeta)
        Me.GroupControl1.Location = New System.Drawing.Point(523, 319)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(265, 111)
        Me.GroupControl1.TabIndex = 30
        Me.GroupControl1.Text = "Totales"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.CampoBusqueda = False
        Me.txtTotal.CampoEsLlave = False
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotal.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotal.FechaActual = False
        Me.txtTotal.Formato = "$#,###0.00"
        Me.txtTotal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotal.LabelText = "Total"
        Me.txtTotal.LabelWidth = 100
        Me.txtTotal.Location = New System.Drawing.Point(6, 88)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NombreCampo = ""
        Me.txtTotal.Obligatorio = False
        Me.txtTotal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.Size = New System.Drawing.Size(251, 20)
        Me.txtTotal.SoloLectura = True
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotal.Valor = 0
        '
        'txtTotalImpuestos
        '
        Me.txtTotalImpuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalImpuestos.CampoBusqueda = False
        Me.txtTotalImpuestos.CampoEsLlave = False
        Me.txtTotalImpuestos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalImpuestos.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotalImpuestos.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalImpuestos.FechaActual = False
        Me.txtTotalImpuestos.Formato = "$#,###0.00"
        Me.txtTotalImpuestos.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalImpuestos.LabelText = "Total Impuestos"
        Me.txtTotalImpuestos.LabelWidth = 100
        Me.txtTotalImpuestos.Location = New System.Drawing.Point(6, 66)
        Me.txtTotalImpuestos.MaxLength = 0
        Me.txtTotalImpuestos.Name = "txtTotalImpuestos"
        Me.txtTotalImpuestos.NombreCampo = ""
        Me.txtTotalImpuestos.Obligatorio = False
        Me.txtTotalImpuestos.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalImpuestos.Size = New System.Drawing.Size(251, 20)
        Me.txtTotalImpuestos.SoloLectura = True
        Me.txtTotalImpuestos.TabIndex = 2
        Me.txtTotalImpuestos.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalImpuestos.Valor = 0
        '
        'txtTotalGastos
        '
        Me.txtTotalGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGastos.CampoBusqueda = False
        Me.txtTotalGastos.CampoEsLlave = False
        Me.txtTotalGastos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalGastos.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotalGastos.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalGastos.FechaActual = False
        Me.txtTotalGastos.Formato = "$#,###0.00"
        Me.txtTotalGastos.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalGastos.LabelText = "Total Gastos"
        Me.txtTotalGastos.LabelWidth = 100
        Me.txtTotalGastos.Location = New System.Drawing.Point(6, 44)
        Me.txtTotalGastos.MaxLength = 0
        Me.txtTotalGastos.Name = "txtTotalGastos"
        Me.txtTotalGastos.NombreCampo = ""
        Me.txtTotalGastos.Obligatorio = False
        Me.txtTotalGastos.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalGastos.Size = New System.Drawing.Size(251, 20)
        Me.txtTotalGastos.SoloLectura = True
        Me.txtTotalGastos.TabIndex = 1
        Me.txtTotalGastos.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalGastos.Valor = 0
        '
        'txtTotalPrimaNeta
        '
        Me.txtTotalPrimaNeta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPrimaNeta.CampoBusqueda = False
        Me.txtTotalPrimaNeta.CampoEsLlave = False
        Me.txtTotalPrimaNeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalPrimaNeta.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotalPrimaNeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalPrimaNeta.FechaActual = False
        Me.txtTotalPrimaNeta.Formato = "$#,###0.00"
        Me.txtTotalPrimaNeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalPrimaNeta.LabelText = "Total Prima Neta"
        Me.txtTotalPrimaNeta.LabelWidth = 100
        Me.txtTotalPrimaNeta.Location = New System.Drawing.Point(6, 22)
        Me.txtTotalPrimaNeta.MaxLength = 0
        Me.txtTotalPrimaNeta.Name = "txtTotalPrimaNeta"
        Me.txtTotalPrimaNeta.NombreCampo = ""
        Me.txtTotalPrimaNeta.Obligatorio = False
        Me.txtTotalPrimaNeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPrimaNeta.Size = New System.Drawing.Size(251, 20)
        Me.txtTotalPrimaNeta.SoloLectura = True
        Me.txtTotalPrimaNeta.TabIndex = 0
        Me.txtTotalPrimaNeta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalPrimaNeta.Valor = 0
        '
        'txtFactura
        '
        Me.txtFactura.CampoBusqueda = False
        Me.txtFactura.CampoEsLlave = False
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFactura.ControlBackColor = System.Drawing.Color.White
        Me.txtFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtFactura.FechaActual = False
        Me.txtFactura.Formato = "####0"
        Me.txtFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFactura.LabelText = "No.Factura"
        Me.txtFactura.LabelWidth = 60
        Me.txtFactura.Location = New System.Drawing.Point(170, 81)
        Me.txtFactura.MaxLength = 0
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.NombreCampo = ""
        Me.txtFactura.Obligatorio = False
        Me.txtFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactura.Size = New System.Drawing.Size(138, 20)
        Me.txtFactura.SoloLectura = False
        Me.txtFactura.TabIndex = 1
        Me.txtFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtFactura.Valor = 0
        '
        'txtMotivo
        '
        Me.txtMotivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivo.CampoBusqueda = False
        Me.txtMotivo.CampoEsLlave = False
        Me.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivo.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivo.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivo.FechaActual = False
        Me.txtMotivo.Formato = ""
        Me.txtMotivo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtMotivo.LabelText = "Motivo Anulación"
        Me.txtMotivo.LabelWidth = 100
        Me.txtMotivo.Location = New System.Drawing.Point(214, 352)
        Me.txtMotivo.MaxLength = 50
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.NombreCampo = ""
        Me.txtMotivo.Obligatorio = True
        Me.txtMotivo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivo.Size = New System.Drawing.Size(283, 36)
        Me.txtMotivo.SoloLectura = False
        Me.txtMotivo.TabIndex = 39
        Me.txtMotivo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivo.Valor = ""
        '
        'PagosAnula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 304
        Me.ClientSize = New System.Drawing.Size(789, 435)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtFechaAnula)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.GridFacturas)
        Me.Controls.Add(Me.txtPoliza)
        Me.Name = "PagosAnula"
        Me.Text = "Anulacion de Pagos"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.GridFacturas, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.txtDocumento, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAnula, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.txtFactura, 0)
        Me.Controls.SetChildIndex(Me.txtMotivo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaAnula As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtDocumento As STIControles.stiTextBox
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents GridFacturas As STIControles.stiGrid
    Friend WithEvents VistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FACol1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents FACol12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTotal As STIControles.stiTextBox
    Friend WithEvents txtTotalImpuestos As STIControles.stiTextBox
    Friend WithEvents txtTotalGastos As STIControles.stiTextBox
    Friend WithEvents txtTotalPrimaNeta As STIControles.stiTextBox
    Friend WithEvents FACol13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFactura As STIControles.stiTextBox
    Friend WithEvents FACol17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMotivo As STIControles.stiTextBox

End Class
