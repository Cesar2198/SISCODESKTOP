<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertificadosCambiarNumero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertificadosCambiarNumero))
        Me.txtbusPoliza = New STIControles.stiTextBox
        Me.txtBusCliente = New STIControles.stiTextBox
        Me.btnBuscarCertificado = New DevExpress.XtraEditors.SimpleButton
        Me.gridCertificados = New STIControles.stiGrid
        Me.vistaCertificados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabCertificados = New DevExpress.XtraTab.XtraTabControl
        Me.pageDatosGenerales = New DevExpress.XtraTab.XtraTabPage
        Me.layControl = New DevExpress.XtraLayout.LayoutControl
        Me.txtTotal = New STIControles.stiTextBox
        Me.txtIva = New STIControles.stiTextBox
        Me.cboIdVendedor = New STIControles.stiComboBox
        Me.txtGastosOtros = New STIControles.stiTextBox
        Me.txtFechaModifica = New STIControles.stiTextBox
        Me.txtGastosBomb = New STIControles.stiTextBox
        Me.txtUsuarioModifica = New STIControles.stiTextBox
        Me.txtGastosFrac = New STIControles.stiTextBox
        Me.txtFechaExclusion = New STIControles.stiTextBox
        Me.txtGastosEmi = New STIControles.stiTextBox
        Me.txtRazonExclusion = New STIControles.stiTextBox
        Me.txtPrimaExenta = New STIControles.stiTextBox
        Me.txtPrimaMinima = New STIControles.stiTextBox
        Me.txtPrimaNeta = New STIControles.stiTextBox
        Me.txtPorceDepreciacion = New STIControles.stiTextBox
        Me.txtValorDescuento = New STIControles.stiTextBox
        Me.txtParticipacion = New STIControles.stiTextBox
        Me.txtPorceDescuento = New STIControles.stiTextBox
        Me.txtDeducible = New STIControles.stiTextBox
        Me.txtPrimaBruta = New STIControles.stiTextBox
        Me.cboEstadoCertificado = New STIControles.stiComboBox
        Me.txtValorAsegurado = New STIControles.stiTextBox
        Me.txtFechaInclusion = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem
        Me.pageBienes = New DevExpress.XtraTab.XtraTabPage
        Me.GridBienes = New STIControles.stiGrid
        Me.VistaBienes = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colbiIdBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiNombreBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiDescripcionBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colBienSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColBienPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.pageBeneficiarios = New DevExpress.XtraTab.XtraTabPage
        Me.GridBeneficiarios = New STIControles.stiGrid
        Me.VistaBeneficiarios = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIdBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbNombreBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colbParentesco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbFechaNacimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbPorcentaje = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pageReclamos = New DevExpress.XtraTab.XtraTabPage
        Me.GridSiniestros = New STIControles.stiGrid
        Me.VistaSiniestros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSinProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinReclamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinFecOcurre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinValorPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinValorPagado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pageCambio = New DevExpress.XtraTab.XtraTabPage
        Me.txtIdCertificadoActual = New STIControles.stiTextBox
        Me.txtIdCertificadoNuevo = New STIControles.stiTextBox
        Me.btnCambiarCert = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vistaCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCertificados.SuspendLayout()
        Me.pageDatosGenerales.SuspendLayout()
        CType(Me.layControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layControl.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageBienes.SuspendLayout()
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageBeneficiarios.SuspendLayout()
        CType(Me.GridBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageReclamos.SuspendLayout()
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageCambio.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(507, 453)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(404, 479)
        Me.btnImprimir.Size = New System.Drawing.Size(10, 10)
        Me.btnImprimir.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(610, 453)
        Me.btnSalir.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(576, 74)
        Me.LabelControl1.Text = "Cambio de Número de Certificado"
        '
        'txtbusPoliza
        '
        Me.txtbusPoliza.CampoBusqueda = False
        Me.txtbusPoliza.CampoEsLlave = False
        Me.txtbusPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtbusPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtbusPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtbusPoliza.FechaActual = False
        Me.txtbusPoliza.Formato = ""
        Me.txtbusPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtbusPoliza.LabelText = "Póliza"
        Me.txtbusPoliza.LabelWidth = 50
        Me.txtbusPoliza.Location = New System.Drawing.Point(12, 80)
        Me.txtbusPoliza.MaxLength = 0
        Me.txtbusPoliza.Name = "txtbusPoliza"
        Me.txtbusPoliza.NombreCampo = ""
        Me.txtbusPoliza.Obligatorio = False
        Me.txtbusPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbusPoliza.Size = New System.Drawing.Size(145, 20)
        Me.txtbusPoliza.SoloLectura = False
        Me.txtbusPoliza.TabIndex = 0
        Me.txtbusPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtbusPoliza.Valor = ""
        '
        'txtBusCliente
        '
        Me.txtBusCliente.CampoBusqueda = False
        Me.txtBusCliente.CampoEsLlave = False
        Me.txtBusCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtBusCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtBusCliente.FechaActual = False
        Me.txtBusCliente.Formato = ""
        Me.txtBusCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtBusCliente.LabelText = "Nombre del Cliente"
        Me.txtBusCliente.LabelWidth = 100
        Me.txtBusCliente.Location = New System.Drawing.Point(163, 80)
        Me.txtBusCliente.MaxLength = 0
        Me.txtBusCliente.Name = "txtBusCliente"
        Me.txtBusCliente.NombreCampo = ""
        Me.txtBusCliente.Obligatorio = False
        Me.txtBusCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusCliente.Size = New System.Drawing.Size(402, 20)
        Me.txtBusCliente.SoloLectura = False
        Me.txtBusCliente.TabIndex = 1
        Me.txtBusCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtBusCliente.Valor = ""
        '
        'btnBuscarCertificado
        '
        Me.btnBuscarCertificado.Location = New System.Drawing.Point(571, 76)
        Me.btnBuscarCertificado.Name = "btnBuscarCertificado"
        Me.btnBuscarCertificado.Size = New System.Drawing.Size(132, 26)
        Me.btnBuscarCertificado.TabIndex = 2
        Me.btnBuscarCertificado.Text = "Buscar Certificados"
        '
        'gridCertificados
        '
        Me.gridCertificados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCertificados.ColumnasAdicionales = ""
        Me.gridCertificados.Location = New System.Drawing.Point(12, 106)
        Me.gridCertificados.MainView = Me.vistaCertificados
        Me.gridCertificados.Name = "gridCertificados"
        Me.gridCertificados.NombreTabla = ""
        Me.gridCertificados.Size = New System.Drawing.Size(695, 153)
        Me.gridCertificados.TabIndex = 3
        Me.gridCertificados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vistaCertificados})
        '
        'vistaCertificados
        '
        Me.vistaCertificados.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vistaCertificados.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vistaCertificados.ColumnPanelRowHeight = 35
        Me.vistaCertificados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.vistaCertificados.GridControl = Me.gridCertificados
        Me.vistaCertificados.Name = "vistaCertificados"
        Me.vistaCertificados.OptionsBehavior.Editable = False
        Me.vistaCertificados.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Aseguradora"
        Me.GridColumn1.FieldName = "Aseguradora"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
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
        Me.GridColumn3.Caption = "Póliza"
        Me.GridColumn3.FieldName = "IdPoliza"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Certificado"
        Me.GridColumn4.FieldName = "IdCertificado"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vig. Desde"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "FechaVigenciaDesde"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Vig. Hasta"
        Me.GridColumn6.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "FechaVigenciaHasta"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fecha Exclusión"
        Me.GridColumn7.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.FieldName = "FechaExclusion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Contratante"
        Me.GridColumn8.FieldName = "Contratante"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Asegurado"
        Me.GridColumn9.FieldName = "Asegurado"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "IdProducto"
        Me.GridColumn10.FieldName = "IdProducto"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'tabCertificados
        '
        Me.tabCertificados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCertificados.Location = New System.Drawing.Point(6, 265)
        Me.tabCertificados.Name = "tabCertificados"
        Me.tabCertificados.SelectedTabPage = Me.pageDatosGenerales
        Me.tabCertificados.Size = New System.Drawing.Size(695, 182)
        Me.tabCertificados.TabIndex = 4
        Me.tabCertificados.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pageDatosGenerales, Me.pageBienes, Me.pageBeneficiarios, Me.pageReclamos, Me.pageCambio})
        '
        'pageDatosGenerales
        '
        Me.pageDatosGenerales.Controls.Add(Me.layControl)
        Me.pageDatosGenerales.Name = "pageDatosGenerales"
        Me.pageDatosGenerales.Size = New System.Drawing.Size(686, 151)
        Me.pageDatosGenerales.Text = "Datos Generales"
        '
        'layControl
        '
        Me.layControl.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
        Me.layControl.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
        Me.layControl.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.layControl.Appearance.DisabledLayoutItem.Options.UseForeColor = True
        Me.layControl.Controls.Add(Me.txtTotal)
        Me.layControl.Controls.Add(Me.txtIva)
        Me.layControl.Controls.Add(Me.cboIdVendedor)
        Me.layControl.Controls.Add(Me.txtGastosOtros)
        Me.layControl.Controls.Add(Me.txtFechaModifica)
        Me.layControl.Controls.Add(Me.txtGastosBomb)
        Me.layControl.Controls.Add(Me.txtUsuarioModifica)
        Me.layControl.Controls.Add(Me.txtGastosFrac)
        Me.layControl.Controls.Add(Me.txtFechaExclusion)
        Me.layControl.Controls.Add(Me.txtGastosEmi)
        Me.layControl.Controls.Add(Me.txtRazonExclusion)
        Me.layControl.Controls.Add(Me.txtPrimaExenta)
        Me.layControl.Controls.Add(Me.txtPrimaMinima)
        Me.layControl.Controls.Add(Me.txtPrimaNeta)
        Me.layControl.Controls.Add(Me.txtPorceDepreciacion)
        Me.layControl.Controls.Add(Me.txtValorDescuento)
        Me.layControl.Controls.Add(Me.txtParticipacion)
        Me.layControl.Controls.Add(Me.txtPorceDescuento)
        Me.layControl.Controls.Add(Me.txtDeducible)
        Me.layControl.Controls.Add(Me.txtPrimaBruta)
        Me.layControl.Controls.Add(Me.cboEstadoCertificado)
        Me.layControl.Controls.Add(Me.txtValorAsegurado)
        Me.layControl.Controls.Add(Me.txtFechaInclusion)
        Me.layControl.Controls.Add(Me.txtVigenciaHasta)
        Me.layControl.Controls.Add(Me.txtVigenciaDesde)
        Me.layControl.Controls.Add(Me.txtNombreCliente)
        Me.layControl.Controls.Add(Me.txtIdCliente)
        Me.layControl.Location = New System.Drawing.Point(2, 3)
        Me.layControl.Name = "layControl"
        Me.layControl.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.CustomSize
        Me.layControl.Root = Me.LayoutControlGroup1
        Me.layControl.Size = New System.Drawing.Size(681, 145)
        Me.layControl.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.CampoBusqueda = False
        Me.txtTotal.CampoEsLlave = False
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtTotal.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotal.FechaActual = False
        Me.txtTotal.Formato = "#,###0.00"
        Me.txtTotal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotal.LabelText = "Total Certificado"
        Me.txtTotal.LabelWidth = 150
        Me.txtTotal.Location = New System.Drawing.Point(348, 441)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NombreCampo = "Total"
        Me.txtTotal.Obligatorio = True
        Me.txtTotal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.Size = New System.Drawing.Size(310, 20)
        Me.txtTotal.SoloLectura = True
        Me.txtTotal.TabIndex = 20
        Me.txtTotal.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotal.Valor = 0
        '
        'txtIva
        '
        Me.txtIva.CampoBusqueda = False
        Me.txtIva.CampoEsLlave = False
        Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIva.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtIva.FechaActual = False
        Me.txtIva.Formato = "#,###0.00"
        Me.txtIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIva.LabelText = "Impuestos"
        Me.txtIva.LabelWidth = 150
        Me.txtIva.Location = New System.Drawing.Point(348, 410)
        Me.txtIva.MaxLength = 0
        Me.txtIva.Name = "txtIva"
        Me.txtIva.NombreCampo = "Iva"
        Me.txtIva.Obligatorio = True
        Me.txtIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIva.Size = New System.Drawing.Size(310, 20)
        Me.txtIva.SoloLectura = True
        Me.txtIva.TabIndex = 19
        Me.txtIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIva.Valor = 0
        '
        'cboIdVendedor
        '
        Me.cboIdVendedor.CampoAutoCompletar = 0
        Me.cboIdVendedor.CampoBusqueda = False
        Me.cboIdVendedor.CampoDisplay = 1
        Me.cboIdVendedor.CampoEsLlave = False
        Me.cboIdVendedor.CampoValor = 0
        Me.cboIdVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdVendedor.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdVendedor.FilasVisibles = 12970
        Me.cboIdVendedor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdVendedor.LabelText = "Vendedor"
        Me.cboIdVendedor.LabelWidth = 115
        Me.cboIdVendedor.Lista = ""
        Me.cboIdVendedor.Location = New System.Drawing.Point(7, 410)
        Me.cboIdVendedor.MostrarBusquedaColumnas = False
        Me.cboIdVendedor.Name = "cboIdVendedor"
        Me.cboIdVendedor.NombreCampo = "IdVendedor"
        Me.cboIdVendedor.Obligatorio = False
        Me.cboIdVendedor.Query = "select idvendedor as Id, NombreVendedor as Vendedor from Vendedores order by Nomb" & _
            "reVendedor"
        Me.cboIdVendedor.SelectIndex = 0
        Me.cboIdVendedor.Size = New System.Drawing.Size(330, 20)
        Me.cboIdVendedor.SoloLectura = True
        Me.cboIdVendedor.StringConection = ""
        Me.cboIdVendedor.TabIndex = 25
        Me.cboIdVendedor.TextoNuevoItem = ""
        Me.cboIdVendedor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdVendedor.Valor = ""
        '
        'txtGastosOtros
        '
        Me.txtGastosOtros.CampoBusqueda = False
        Me.txtGastosOtros.CampoEsLlave = False
        Me.txtGastosOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosOtros.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtGastosOtros.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosOtros.FechaActual = False
        Me.txtGastosOtros.Formato = "#,###0.00"
        Me.txtGastosOtros.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosOtros.LabelText = "Otros Gastos"
        Me.txtGastosOtros.LabelWidth = 150
        Me.txtGastosOtros.Location = New System.Drawing.Point(348, 379)
        Me.txtGastosOtros.MaxLength = 0
        Me.txtGastosOtros.Name = "txtGastosOtros"
        Me.txtGastosOtros.NombreCampo = "GastosOtros"
        Me.txtGastosOtros.Obligatorio = True
        Me.txtGastosOtros.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosOtros.Size = New System.Drawing.Size(310, 20)
        Me.txtGastosOtros.SoloLectura = True
        Me.txtGastosOtros.TabIndex = 18
        Me.txtGastosOtros.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosOtros.Valor = 0
        '
        'txtFechaModifica
        '
        Me.txtFechaModifica.CampoBusqueda = False
        Me.txtFechaModifica.CampoEsLlave = False
        Me.txtFechaModifica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaModifica.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaModifica.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaModifica.FechaActual = False
        Me.txtFechaModifica.Formato = "dd/MMM/yyyy"
        Me.txtFechaModifica.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaModifica.LabelText = "Fecha Modificación"
        Me.txtFechaModifica.LabelWidth = 115
        Me.txtFechaModifica.Location = New System.Drawing.Point(7, 379)
        Me.txtFechaModifica.MaxLength = 0
        Me.txtFechaModifica.Name = "txtFechaModifica"
        Me.txtFechaModifica.NombreCampo = "FechaModifica"
        Me.txtFechaModifica.Obligatorio = False
        Me.txtFechaModifica.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaModifica.Size = New System.Drawing.Size(330, 20)
        Me.txtFechaModifica.SoloLectura = True
        Me.txtFechaModifica.TabIndex = 24
        Me.txtFechaModifica.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaModifica.Valor = Nothing
        '
        'txtGastosBomb
        '
        Me.txtGastosBomb.CampoBusqueda = False
        Me.txtGastosBomb.CampoEsLlave = False
        Me.txtGastosBomb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosBomb.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtGastosBomb.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosBomb.FechaActual = False
        Me.txtGastosBomb.Formato = "#,###0.00"
        Me.txtGastosBomb.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosBomb.LabelText = "Gastos de Bomberos"
        Me.txtGastosBomb.LabelWidth = 150
        Me.txtGastosBomb.Location = New System.Drawing.Point(348, 348)
        Me.txtGastosBomb.MaxLength = 0
        Me.txtGastosBomb.Name = "txtGastosBomb"
        Me.txtGastosBomb.NombreCampo = "GastosBomb"
        Me.txtGastosBomb.Obligatorio = True
        Me.txtGastosBomb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosBomb.Size = New System.Drawing.Size(310, 20)
        Me.txtGastosBomb.SoloLectura = True
        Me.txtGastosBomb.TabIndex = 18
        Me.txtGastosBomb.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosBomb.Valor = 0
        '
        'txtUsuarioModifica
        '
        Me.txtUsuarioModifica.CampoBusqueda = False
        Me.txtUsuarioModifica.CampoEsLlave = False
        Me.txtUsuarioModifica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioModifica.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtUsuarioModifica.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioModifica.FechaActual = False
        Me.txtUsuarioModifica.Formato = ""
        Me.txtUsuarioModifica.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtUsuarioModifica.LabelText = "Usuario Modifica"
        Me.txtUsuarioModifica.LabelWidth = 115
        Me.txtUsuarioModifica.Location = New System.Drawing.Point(7, 348)
        Me.txtUsuarioModifica.MaxLength = 25
        Me.txtUsuarioModifica.Name = "txtUsuarioModifica"
        Me.txtUsuarioModifica.NombreCampo = "UsuarioModifica"
        Me.txtUsuarioModifica.Obligatorio = False
        Me.txtUsuarioModifica.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioModifica.Size = New System.Drawing.Size(330, 20)
        Me.txtUsuarioModifica.SoloLectura = True
        Me.txtUsuarioModifica.TabIndex = 23
        Me.txtUsuarioModifica.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioModifica.Valor = ""
        '
        'txtGastosFrac
        '
        Me.txtGastosFrac.CampoBusqueda = False
        Me.txtGastosFrac.CampoEsLlave = False
        Me.txtGastosFrac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosFrac.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtGastosFrac.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosFrac.FechaActual = False
        Me.txtGastosFrac.Formato = "#,###0.00"
        Me.txtGastosFrac.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosFrac.LabelText = "Gastos Fraccionamiento"
        Me.txtGastosFrac.LabelWidth = 150
        Me.txtGastosFrac.Location = New System.Drawing.Point(348, 317)
        Me.txtGastosFrac.MaxLength = 0
        Me.txtGastosFrac.Name = "txtGastosFrac"
        Me.txtGastosFrac.NombreCampo = "GastosFrac"
        Me.txtGastosFrac.Obligatorio = True
        Me.txtGastosFrac.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosFrac.Size = New System.Drawing.Size(310, 20)
        Me.txtGastosFrac.SoloLectura = True
        Me.txtGastosFrac.TabIndex = 18
        Me.txtGastosFrac.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosFrac.Valor = 0
        '
        'txtFechaExclusion
        '
        Me.txtFechaExclusion.CampoBusqueda = False
        Me.txtFechaExclusion.CampoEsLlave = False
        Me.txtFechaExclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaExclusion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaExclusion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaExclusion.FechaActual = False
        Me.txtFechaExclusion.Formato = "dd/MMM/yyyy"
        Me.txtFechaExclusion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaExclusion.LabelText = "Fecha Exclusión"
        Me.txtFechaExclusion.LabelWidth = 115
        Me.txtFechaExclusion.Location = New System.Drawing.Point(7, 317)
        Me.txtFechaExclusion.MaxLength = 0
        Me.txtFechaExclusion.Name = "txtFechaExclusion"
        Me.txtFechaExclusion.NombreCampo = "FechaExclusion"
        Me.txtFechaExclusion.Obligatorio = False
        Me.txtFechaExclusion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaExclusion.Size = New System.Drawing.Size(330, 20)
        Me.txtFechaExclusion.SoloLectura = True
        Me.txtFechaExclusion.TabIndex = 22
        Me.txtFechaExclusion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaExclusion.Valor = Nothing
        '
        'txtGastosEmi
        '
        Me.txtGastosEmi.CampoBusqueda = False
        Me.txtGastosEmi.CampoEsLlave = False
        Me.txtGastosEmi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosEmi.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtGastosEmi.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosEmi.FechaActual = False
        Me.txtGastosEmi.Formato = "#,###0.00"
        Me.txtGastosEmi.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosEmi.LabelText = "Gastos Emisión"
        Me.txtGastosEmi.LabelWidth = 150
        Me.txtGastosEmi.Location = New System.Drawing.Point(348, 286)
        Me.txtGastosEmi.MaxLength = 0
        Me.txtGastosEmi.Name = "txtGastosEmi"
        Me.txtGastosEmi.NombreCampo = "GastosEmi"
        Me.txtGastosEmi.Obligatorio = True
        Me.txtGastosEmi.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosEmi.Size = New System.Drawing.Size(310, 20)
        Me.txtGastosEmi.SoloLectura = True
        Me.txtGastosEmi.TabIndex = 18
        Me.txtGastosEmi.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosEmi.Valor = 0
        '
        'txtRazonExclusion
        '
        Me.txtRazonExclusion.CampoBusqueda = False
        Me.txtRazonExclusion.CampoEsLlave = False
        Me.txtRazonExclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRazonExclusion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtRazonExclusion.ControlForeColor = System.Drawing.Color.Black
        Me.txtRazonExclusion.FechaActual = False
        Me.txtRazonExclusion.Formato = ""
        Me.txtRazonExclusion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtRazonExclusion.LabelText = "Motivo Exclusión"
        Me.txtRazonExclusion.LabelWidth = 115
        Me.txtRazonExclusion.Location = New System.Drawing.Point(7, 286)
        Me.txtRazonExclusion.MaxLength = 250
        Me.txtRazonExclusion.Name = "txtRazonExclusion"
        Me.txtRazonExclusion.NombreCampo = "RazonExclusion"
        Me.txtRazonExclusion.Obligatorio = False
        Me.txtRazonExclusion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazonExclusion.Size = New System.Drawing.Size(330, 20)
        Me.txtRazonExclusion.SoloLectura = True
        Me.txtRazonExclusion.TabIndex = 21
        Me.txtRazonExclusion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRazonExclusion.Valor = ""
        '
        'txtPrimaExenta
        '
        Me.txtPrimaExenta.CampoBusqueda = False
        Me.txtPrimaExenta.CampoEsLlave = False
        Me.txtPrimaExenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaExenta.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtPrimaExenta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaExenta.FechaActual = False
        Me.txtPrimaExenta.Formato = "#,###0.00"
        Me.txtPrimaExenta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaExenta.LabelText = "Prima Exenta"
        Me.txtPrimaExenta.LabelWidth = 150
        Me.txtPrimaExenta.Location = New System.Drawing.Point(348, 255)
        Me.txtPrimaExenta.MaxLength = 0
        Me.txtPrimaExenta.Name = "txtPrimaExenta"
        Me.txtPrimaExenta.NombreCampo = "PrimaExenta"
        Me.txtPrimaExenta.Obligatorio = True
        Me.txtPrimaExenta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaExenta.Size = New System.Drawing.Size(310, 20)
        Me.txtPrimaExenta.SoloLectura = True
        Me.txtPrimaExenta.TabIndex = 18
        Me.txtPrimaExenta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaExenta.Valor = 0
        '
        'txtPrimaMinima
        '
        Me.txtPrimaMinima.CampoBusqueda = False
        Me.txtPrimaMinima.CampoEsLlave = False
        Me.txtPrimaMinima.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaMinima.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtPrimaMinima.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaMinima.FechaActual = False
        Me.txtPrimaMinima.Formato = "#,###0.00"
        Me.txtPrimaMinima.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaMinima.LabelText = "Prima Mínima"
        Me.txtPrimaMinima.LabelWidth = 115
        Me.txtPrimaMinima.Location = New System.Drawing.Point(7, 255)
        Me.txtPrimaMinima.MaxLength = 0
        Me.txtPrimaMinima.Name = "txtPrimaMinima"
        Me.txtPrimaMinima.NombreCampo = "PrimaMinima"
        Me.txtPrimaMinima.Obligatorio = False
        Me.txtPrimaMinima.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaMinima.Size = New System.Drawing.Size(330, 20)
        Me.txtPrimaMinima.SoloLectura = True
        Me.txtPrimaMinima.TabIndex = 32
        Me.txtPrimaMinima.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaMinima.Valor = 0
        '
        'txtPrimaNeta
        '
        Me.txtPrimaNeta.CampoBusqueda = False
        Me.txtPrimaNeta.CampoEsLlave = False
        Me.txtPrimaNeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaNeta.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtPrimaNeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaNeta.FechaActual = False
        Me.txtPrimaNeta.Formato = "#,###0.00"
        Me.txtPrimaNeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaNeta.LabelText = "Prima Neta"
        Me.txtPrimaNeta.LabelWidth = 150
        Me.txtPrimaNeta.Location = New System.Drawing.Point(348, 224)
        Me.txtPrimaNeta.MaxLength = 0
        Me.txtPrimaNeta.Name = "txtPrimaNeta"
        Me.txtPrimaNeta.NombreCampo = "PrimaNeta"
        Me.txtPrimaNeta.Obligatorio = True
        Me.txtPrimaNeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaNeta.Size = New System.Drawing.Size(310, 20)
        Me.txtPrimaNeta.SoloLectura = True
        Me.txtPrimaNeta.TabIndex = 18
        Me.txtPrimaNeta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaNeta.Valor = 0
        '
        'txtPorceDepreciacion
        '
        Me.txtPorceDepreciacion.CampoBusqueda = False
        Me.txtPorceDepreciacion.CampoEsLlave = False
        Me.txtPorceDepreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceDepreciacion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtPorceDepreciacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceDepreciacion.FechaActual = False
        Me.txtPorceDepreciacion.Formato = ""
        Me.txtPorceDepreciacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceDepreciacion.LabelText = "% Depreciación"
        Me.txtPorceDepreciacion.LabelWidth = 115
        Me.txtPorceDepreciacion.Location = New System.Drawing.Point(7, 224)
        Me.txtPorceDepreciacion.MaxLength = 50
        Me.txtPorceDepreciacion.Name = "txtPorceDepreciacion"
        Me.txtPorceDepreciacion.NombreCampo = "PorceDepreciacion"
        Me.txtPorceDepreciacion.Obligatorio = False
        Me.txtPorceDepreciacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceDepreciacion.Size = New System.Drawing.Size(330, 20)
        Me.txtPorceDepreciacion.SoloLectura = True
        Me.txtPorceDepreciacion.TabIndex = 20
        Me.txtPorceDepreciacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPorceDepreciacion.Valor = ""
        '
        'txtValorDescuento
        '
        Me.txtValorDescuento.CampoBusqueda = False
        Me.txtValorDescuento.CampoEsLlave = False
        Me.txtValorDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorDescuento.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtValorDescuento.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorDescuento.FechaActual = False
        Me.txtValorDescuento.Formato = "#,###0.00"
        Me.txtValorDescuento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorDescuento.LabelText = "Valor Descuento"
        Me.txtValorDescuento.LabelWidth = 150
        Me.txtValorDescuento.Location = New System.Drawing.Point(348, 193)
        Me.txtValorDescuento.MaxLength = 0
        Me.txtValorDescuento.Name = "txtValorDescuento"
        Me.txtValorDescuento.NombreCampo = "ValorDescuento"
        Me.txtValorDescuento.Obligatorio = True
        Me.txtValorDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorDescuento.Size = New System.Drawing.Size(310, 20)
        Me.txtValorDescuento.SoloLectura = True
        Me.txtValorDescuento.TabIndex = 18
        Me.txtValorDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorDescuento.Valor = 0
        '
        'txtParticipacion
        '
        Me.txtParticipacion.CampoBusqueda = False
        Me.txtParticipacion.CampoEsLlave = False
        Me.txtParticipacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtParticipacion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtParticipacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtParticipacion.FechaActual = False
        Me.txtParticipacion.Formato = ""
        Me.txtParticipacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtParticipacion.LabelText = "Participación"
        Me.txtParticipacion.LabelWidth = 115
        Me.txtParticipacion.Location = New System.Drawing.Point(7, 193)
        Me.txtParticipacion.MaxLength = 50
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.NombreCampo = "Participacion"
        Me.txtParticipacion.Obligatorio = False
        Me.txtParticipacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParticipacion.Size = New System.Drawing.Size(330, 20)
        Me.txtParticipacion.SoloLectura = True
        Me.txtParticipacion.TabIndex = 18
        Me.txtParticipacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtParticipacion.Valor = ""
        '
        'txtPorceDescuento
        '
        Me.txtPorceDescuento.CampoBusqueda = False
        Me.txtPorceDescuento.CampoEsLlave = False
        Me.txtPorceDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceDescuento.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtPorceDescuento.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceDescuento.FechaActual = False
        Me.txtPorceDescuento.Formato = "#,###0.00"
        Me.txtPorceDescuento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceDescuento.LabelText = "% Descuento"
        Me.txtPorceDescuento.LabelWidth = 150
        Me.txtPorceDescuento.Location = New System.Drawing.Point(348, 162)
        Me.txtPorceDescuento.MaxLength = 0
        Me.txtPorceDescuento.Name = "txtPorceDescuento"
        Me.txtPorceDescuento.NombreCampo = "PorceDescuento"
        Me.txtPorceDescuento.Obligatorio = True
        Me.txtPorceDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceDescuento.Size = New System.Drawing.Size(310, 20)
        Me.txtPorceDescuento.SoloLectura = True
        Me.txtPorceDescuento.TabIndex = 18
        Me.txtPorceDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceDescuento.Valor = 0
        '
        'txtDeducible
        '
        Me.txtDeducible.CampoBusqueda = False
        Me.txtDeducible.CampoEsLlave = False
        Me.txtDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDeducible.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtDeducible.FechaActual = False
        Me.txtDeducible.Formato = ""
        Me.txtDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDeducible.LabelText = "Deducible"
        Me.txtDeducible.LabelWidth = 115
        Me.txtDeducible.Location = New System.Drawing.Point(7, 162)
        Me.txtDeducible.MaxLength = 50
        Me.txtDeducible.Name = "txtDeducible"
        Me.txtDeducible.NombreCampo = "Deducible"
        Me.txtDeducible.Obligatorio = False
        Me.txtDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeducible.Size = New System.Drawing.Size(330, 20)
        Me.txtDeducible.SoloLectura = True
        Me.txtDeducible.TabIndex = 18
        Me.txtDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDeducible.Valor = ""
        '
        'txtPrimaBruta
        '
        Me.txtPrimaBruta.CampoBusqueda = False
        Me.txtPrimaBruta.CampoEsLlave = False
        Me.txtPrimaBruta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaBruta.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtPrimaBruta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaBruta.FechaActual = False
        Me.txtPrimaBruta.Formato = "#,###0.00"
        Me.txtPrimaBruta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaBruta.LabelText = "Prima Total"
        Me.txtPrimaBruta.LabelWidth = 150
        Me.txtPrimaBruta.Location = New System.Drawing.Point(348, 131)
        Me.txtPrimaBruta.MaxLength = 0
        Me.txtPrimaBruta.Name = "txtPrimaBruta"
        Me.txtPrimaBruta.NombreCampo = "PrimaBruta"
        Me.txtPrimaBruta.Obligatorio = True
        Me.txtPrimaBruta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaBruta.Size = New System.Drawing.Size(310, 20)
        Me.txtPrimaBruta.SoloLectura = True
        Me.txtPrimaBruta.TabIndex = 18
        Me.txtPrimaBruta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaBruta.Valor = 0
        '
        'cboEstadoCertificado
        '
        Me.cboEstadoCertificado.CampoAutoCompletar = 0
        Me.cboEstadoCertificado.CampoBusqueda = False
        Me.cboEstadoCertificado.CampoDisplay = 1
        Me.cboEstadoCertificado.CampoEsLlave = False
        Me.cboEstadoCertificado.CampoValor = 0
        Me.cboEstadoCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoCertificado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboEstadoCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoCertificado.FilasVisibles = 12970
        Me.cboEstadoCertificado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoCertificado.LabelText = "Estado Certificado"
        Me.cboEstadoCertificado.LabelWidth = 115
        Me.cboEstadoCertificado.Lista = "VIGENTE Certificado Vigente|CANCELADO Certificado Cancelado"
        Me.cboEstadoCertificado.Location = New System.Drawing.Point(7, 131)
        Me.cboEstadoCertificado.MostrarBusquedaColumnas = False
        Me.cboEstadoCertificado.Name = "cboEstadoCertificado"
        Me.cboEstadoCertificado.NombreCampo = "EstadoCertificado"
        Me.cboEstadoCertificado.Obligatorio = True
        Me.cboEstadoCertificado.Query = ""
        Me.cboEstadoCertificado.SelectIndex = 0
        Me.cboEstadoCertificado.Size = New System.Drawing.Size(330, 20)
        Me.cboEstadoCertificado.SoloLectura = True
        Me.cboEstadoCertificado.StringConection = ""
        Me.cboEstadoCertificado.TabIndex = 18
        Me.cboEstadoCertificado.TextoNuevoItem = ""
        Me.cboEstadoCertificado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoCertificado.Valor = ""
        '
        'txtValorAsegurado
        '
        Me.txtValorAsegurado.CampoBusqueda = True
        Me.txtValorAsegurado.CampoEsLlave = False
        Me.txtValorAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorAsegurado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtValorAsegurado.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorAsegurado.FechaActual = False
        Me.txtValorAsegurado.Formato = "#,###0.00"
        Me.txtValorAsegurado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorAsegurado.LabelText = "Valor Asegurado"
        Me.txtValorAsegurado.LabelWidth = 150
        Me.txtValorAsegurado.Location = New System.Drawing.Point(348, 100)
        Me.txtValorAsegurado.MaxLength = 0
        Me.txtValorAsegurado.Name = "txtValorAsegurado"
        Me.txtValorAsegurado.NombreCampo = "ValorAsegurado"
        Me.txtValorAsegurado.Obligatorio = True
        Me.txtValorAsegurado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorAsegurado.Size = New System.Drawing.Size(310, 20)
        Me.txtValorAsegurado.SoloLectura = True
        Me.txtValorAsegurado.TabIndex = 18
        Me.txtValorAsegurado.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorAsegurado.Valor = 0
        '
        'txtFechaInclusion
        '
        Me.txtFechaInclusion.CampoBusqueda = False
        Me.txtFechaInclusion.CampoEsLlave = False
        Me.txtFechaInclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInclusion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaInclusion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInclusion.FechaActual = True
        Me.txtFechaInclusion.Formato = "dd/MMM/yyyy"
        Me.txtFechaInclusion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaInclusion.LabelText = "Fecha Inclusión"
        Me.txtFechaInclusion.LabelWidth = 115
        Me.txtFechaInclusion.Location = New System.Drawing.Point(7, 100)
        Me.txtFechaInclusion.MaxLength = 0
        Me.txtFechaInclusion.Name = "txtFechaInclusion"
        Me.txtFechaInclusion.NombreCampo = "FechaInclusion"
        Me.txtFechaInclusion.Obligatorio = True
        Me.txtFechaInclusion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInclusion.Size = New System.Drawing.Size(330, 20)
        Me.txtFechaInclusion.SoloLectura = True
        Me.txtFechaInclusion.TabIndex = 18
        Me.txtFechaInclusion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInclusion.Valor = Nothing
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = False
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = False
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigencia Hasta"
        Me.txtVigenciaHasta.LabelWidth = 115
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(348, 69)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(310, 20)
        Me.txtVigenciaHasta.SoloLectura = True
        Me.txtVigenciaHasta.TabIndex = 18
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = True
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = False
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 115
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(7, 69)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(330, 20)
        Me.txtVigenciaDesde.SoloLectura = True
        Me.txtVigenciaDesde.TabIndex = 18
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Asegurado"
        Me.txtNombreCliente.LabelWidth = 115
        Me.txtNombreCliente.Location = New System.Drawing.Point(7, 38)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(651, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 18
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = True
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Asegurado"
        Me.txtIdCliente.LabelWidth = 115
        Me.txtIdCliente.Location = New System.Drawing.Point(7, 7)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(651, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 4
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.AlignControlsWithHiddenText = True
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 0
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(664, 467)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtIdCliente
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(662, 31)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombreCliente
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(662, 31)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtVigenciaDesde
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtVigenciaHasta
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(341, 62)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtFechaInclusion
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtValorAsegurado
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(341, 93)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cboEstadoCertificado
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtPrimaBruta
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(341, 124)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtDeducible
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtPorceDescuento
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(341, 155)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtParticipacion
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtValorDescuento
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(341, 186)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem12.Text = "LayoutControlItem12"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtPorceDepreciacion
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem13.Text = "LayoutControlItem13"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextToControlDistance = 0
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtPrimaNeta
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(341, 217)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem14.Text = "LayoutControlItem14"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextToControlDistance = 0
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtPrimaMinima
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 248)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem15.Text = "LayoutControlItem15"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextToControlDistance = 0
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtPrimaExenta
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(341, 248)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem16.Text = "LayoutControlItem16"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtRazonExclusion
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 279)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem17.Text = "LayoutControlItem17"
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextToControlDistance = 0
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtGastosEmi
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(341, 279)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem18.Text = "LayoutControlItem18"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextToControlDistance = 0
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtFechaExclusion
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 310)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem19.Text = "LayoutControlItem19"
        Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextToControlDistance = 0
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtGastosFrac
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(341, 310)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem20.Text = "LayoutControlItem20"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextToControlDistance = 0
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtUsuarioModifica
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 341)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem21.Text = "LayoutControlItem21"
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextToControlDistance = 0
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtGastosBomb
        Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(341, 341)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem22.Text = "LayoutControlItem22"
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextToControlDistance = 0
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtFechaModifica
        Me.LayoutControlItem23.CustomizationFormText = "LayoutControlItem23"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 372)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(341, 31)
        Me.LayoutControlItem23.Text = "LayoutControlItem23"
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextToControlDistance = 0
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtGastosOtros
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(341, 372)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem24.Text = "LayoutControlItem24"
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextToControlDistance = 0
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cboIdVendedor
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 403)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(341, 62)
        Me.LayoutControlItem25.Text = "LayoutControlItem25"
        Me.LayoutControlItem25.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextToControlDistance = 0
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtIva
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(341, 403)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem26.Text = "LayoutControlItem26"
        Me.LayoutControlItem26.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextToControlDistance = 0
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtTotal
        Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem27"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(341, 434)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(321, 31)
        Me.LayoutControlItem27.Text = "LayoutControlItem27"
        Me.LayoutControlItem27.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextToControlDistance = 0
        Me.LayoutControlItem27.TextVisible = False
        '
        'pageBienes
        '
        Me.pageBienes.Controls.Add(Me.GridBienes)
        Me.pageBienes.Name = "pageBienes"
        Me.pageBienes.Size = New System.Drawing.Size(686, 151)
        Me.pageBienes.Text = "Bienes"
        '
        'GridBienes
        '
        Me.GridBienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBienes.ColumnasAdicionales = ""
        Me.GridBienes.Location = New System.Drawing.Point(2, 2)
        Me.GridBienes.MainView = Me.VistaBienes
        Me.GridBienes.Name = "GridBienes"
        Me.GridBienes.NombreTabla = "PolizasBienes"
        Me.GridBienes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemMemoEdit1})
        Me.GridBienes.Size = New System.Drawing.Size(680, 146)
        Me.GridBienes.TabIndex = 1
        Me.GridBienes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBienes})
        '
        'VistaBienes
        '
        Me.VistaBienes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbiIdBien, Me.colbiNombreBien, Me.colbiDescripcionBien, Me.colBienSuma, Me.ColBienPrima})
        Me.VistaBienes.GridControl = Me.GridBienes
        Me.VistaBienes.Name = "VistaBienes"
        Me.VistaBienes.OptionsCustomization.AllowRowSizing = True
        Me.VistaBienes.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaBienes.OptionsView.ShowGroupPanel = False
        '
        'colbiIdBien
        '
        Me.colbiIdBien.Caption = "Orden"
        Me.colbiIdBien.FieldName = "IdBien"
        Me.colbiIdBien.Name = "colbiIdBien"
        Me.colbiIdBien.Visible = True
        Me.colbiIdBien.VisibleIndex = 0
        Me.colbiIdBien.Width = 52
        '
        'colbiNombreBien
        '
        Me.colbiNombreBien.Caption = "Tipo Bien"
        Me.colbiNombreBien.FieldName = "NombreBien"
        Me.colbiNombreBien.Name = "colbiNombreBien"
        Me.colbiNombreBien.Visible = True
        Me.colbiNombreBien.VisibleIndex = 1
        Me.colbiNombreBien.Width = 121
        '
        'colbiDescripcionBien
        '
        Me.colbiDescripcionBien.Caption = "Descripción del Bien"
        Me.colbiDescripcionBien.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colbiDescripcionBien.FieldName = "DescripcionBien"
        Me.colbiDescripcionBien.Name = "colbiDescripcionBien"
        Me.colbiDescripcionBien.Visible = True
        Me.colbiDescripcionBien.VisibleIndex = 2
        Me.colbiDescripcionBien.Width = 375
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colBienSuma
        '
        Me.colBienSuma.Caption = "Suma Asegurada"
        Me.colBienSuma.DisplayFormat.FormatString = "c2"
        Me.colBienSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBienSuma.FieldName = "SumaAsegurada"
        Me.colBienSuma.Name = "colBienSuma"
        '
        'ColBienPrima
        '
        Me.ColBienPrima.Caption = "Prima"
        Me.ColBienPrima.DisplayFormat.FormatString = "c2"
        Me.ColBienPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColBienPrima.FieldName = "Prima"
        Me.ColBienPrima.Name = "ColBienPrima"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'pageBeneficiarios
        '
        Me.pageBeneficiarios.Controls.Add(Me.GridBeneficiarios)
        Me.pageBeneficiarios.Name = "pageBeneficiarios"
        Me.pageBeneficiarios.Size = New System.Drawing.Size(686, 151)
        Me.pageBeneficiarios.Text = "Beneficiarios"
        '
        'GridBeneficiarios
        '
        Me.GridBeneficiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBeneficiarios.ColumnasAdicionales = ""
        Me.GridBeneficiarios.Location = New System.Drawing.Point(3, 3)
        Me.GridBeneficiarios.MainView = Me.VistaBeneficiarios
        Me.GridBeneficiarios.Name = "GridBeneficiarios"
        Me.GridBeneficiarios.NombreTabla = "PolizasBeneficiarios"
        Me.GridBeneficiarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemTextEdit1})
        Me.GridBeneficiarios.Size = New System.Drawing.Size(680, 145)
        Me.GridBeneficiarios.TabIndex = 6
        Me.GridBeneficiarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBeneficiarios})
        '
        'VistaBeneficiarios
        '
        Me.VistaBeneficiarios.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaBeneficiarios.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaBeneficiarios.ColumnPanelRowHeight = 35
        Me.VistaBeneficiarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBIdCertificado, Me.colBIdBeneficiario, Me.colbNombreBeneficiario, Me.colbParentesco, Me.colbFechaNacimiento, Me.colbPorcentaje})
        Me.VistaBeneficiarios.GridControl = Me.GridBeneficiarios
        Me.VistaBeneficiarios.Name = "VistaBeneficiarios"
        Me.VistaBeneficiarios.OptionsCustomization.AllowRowSizing = True
        Me.VistaBeneficiarios.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaBeneficiarios.OptionsView.ShowGroupPanel = False
        '
        'colBIdCertificado
        '
        Me.colBIdCertificado.Caption = "IdCertificado"
        Me.colBIdCertificado.FieldName = "IdCertificado"
        Me.colBIdCertificado.Name = "colBIdCertificado"
        '
        'colBIdBeneficiario
        '
        Me.colBIdBeneficiario.Caption = "Id"
        Me.colBIdBeneficiario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIdBeneficiario.FieldName = "IdBeneficiario"
        Me.colBIdBeneficiario.Name = "colBIdBeneficiario"
        Me.colBIdBeneficiario.Visible = True
        Me.colBIdBeneficiario.VisibleIndex = 0
        Me.colBIdBeneficiario.Width = 41
        '
        'colbNombreBeneficiario
        '
        Me.colbNombreBeneficiario.Caption = "Nombre Beneficiario"
        Me.colbNombreBeneficiario.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colbNombreBeneficiario.FieldName = "NombreBeneficiario"
        Me.colbNombreBeneficiario.Name = "colbNombreBeneficiario"
        Me.colbNombreBeneficiario.Visible = True
        Me.colbNombreBeneficiario.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colbParentesco
        '
        Me.colbParentesco.Caption = "Parentesco"
        Me.colbParentesco.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colbParentesco.FieldName = "Parentesco"
        Me.colbParentesco.Name = "colbParentesco"
        Me.colbParentesco.Visible = True
        Me.colbParentesco.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'colbFechaNacimiento
        '
        Me.colbFechaNacimiento.Caption = "Fecha Nacimiento"
        Me.colbFechaNacimiento.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colbFechaNacimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colbFechaNacimiento.FieldName = "FechaNacimiento"
        Me.colbFechaNacimiento.Name = "colbFechaNacimiento"
        Me.colbFechaNacimiento.Visible = True
        Me.colbFechaNacimiento.VisibleIndex = 3
        '
        'colbPorcentaje
        '
        Me.colbPorcentaje.Caption = "Porcentaje"
        Me.colbPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbPorcentaje.FieldName = "Porcentaje"
        Me.colbPorcentaje.Name = "colbPorcentaje"
        Me.colbPorcentaje.Visible = True
        Me.colbPorcentaje.VisibleIndex = 4
        '
        'pageReclamos
        '
        Me.pageReclamos.Controls.Add(Me.GridSiniestros)
        Me.pageReclamos.Name = "pageReclamos"
        Me.pageReclamos.Size = New System.Drawing.Size(686, 151)
        Me.pageReclamos.Text = "Reclamos"
        '
        'GridSiniestros
        '
        Me.GridSiniestros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSiniestros.ColumnasAdicionales = ""
        Me.GridSiniestros.Location = New System.Drawing.Point(3, 3)
        Me.GridSiniestros.MainView = Me.VistaSiniestros
        Me.GridSiniestros.Name = "GridSiniestros"
        Me.GridSiniestros.NombreTabla = ""
        Me.GridSiniestros.Size = New System.Drawing.Size(680, 145)
        Me.GridSiniestros.TabIndex = 1
        Me.GridSiniestros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaSiniestros})
        '
        'VistaSiniestros
        '
        Me.VistaSiniestros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSinProducto, Me.colSinPoliza, Me.colSinReclamo, Me.colSinFecOcurre, Me.colSinValorPresentado, Me.colSinValorPagado, Me.colSinEstado, Me.colSinIdProducto, Me.colSinIdCertificado})
        Me.VistaSiniestros.GridControl = Me.GridSiniestros
        Me.VistaSiniestros.Name = "VistaSiniestros"
        Me.VistaSiniestros.OptionsBehavior.Editable = False
        Me.VistaSiniestros.OptionsView.ShowFooter = True
        Me.VistaSiniestros.OptionsView.ShowGroupPanel = False
        '
        'colSinProducto
        '
        Me.colSinProducto.Caption = "Producto"
        Me.colSinProducto.FieldName = "Producto"
        Me.colSinProducto.Name = "colSinProducto"
        Me.colSinProducto.Visible = True
        Me.colSinProducto.VisibleIndex = 0
        '
        'colSinPoliza
        '
        Me.colSinPoliza.Caption = "Póliza"
        Me.colSinPoliza.FieldName = "IdPoliza"
        Me.colSinPoliza.Name = "colSinPoliza"
        Me.colSinPoliza.Visible = True
        Me.colSinPoliza.VisibleIndex = 1
        '
        'colSinReclamo
        '
        Me.colSinReclamo.Caption = "Núm. Reclamo"
        Me.colSinReclamo.FieldName = "IdSiniestro"
        Me.colSinReclamo.Name = "colSinReclamo"
        Me.colSinReclamo.Visible = True
        Me.colSinReclamo.VisibleIndex = 2
        '
        'colSinFecOcurre
        '
        Me.colSinFecOcurre.Caption = "Fecha Ocurrencia"
        Me.colSinFecOcurre.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colSinFecOcurre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSinFecOcurre.FieldName = "FechaOcurre"
        Me.colSinFecOcurre.Name = "colSinFecOcurre"
        Me.colSinFecOcurre.Visible = True
        Me.colSinFecOcurre.VisibleIndex = 3
        '
        'colSinValorPresentado
        '
        Me.colSinValorPresentado.Caption = "Valor Presentado"
        Me.colSinValorPresentado.DisplayFormat.FormatString = "c"
        Me.colSinValorPresentado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSinValorPresentado.FieldName = "ValorPresenta"
        Me.colSinValorPresentado.Name = "colSinValorPresentado"
        Me.colSinValorPresentado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSinValorPresentado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSinValorPresentado.Visible = True
        Me.colSinValorPresentado.VisibleIndex = 4
        '
        'colSinValorPagado
        '
        Me.colSinValorPagado.Caption = "Valor Pagado"
        Me.colSinValorPagado.DisplayFormat.FormatString = "c"
        Me.colSinValorPagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSinValorPagado.FieldName = "ValorPagado"
        Me.colSinValorPagado.Name = "colSinValorPagado"
        Me.colSinValorPagado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSinValorPagado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSinValorPagado.Visible = True
        Me.colSinValorPagado.VisibleIndex = 5
        '
        'colSinEstado
        '
        Me.colSinEstado.Caption = "Estado del Reclamo"
        Me.colSinEstado.FieldName = "Estado"
        Me.colSinEstado.Name = "colSinEstado"
        Me.colSinEstado.Visible = True
        Me.colSinEstado.VisibleIndex = 6
        '
        'colSinIdProducto
        '
        Me.colSinIdProducto.Caption = "IdProducto"
        Me.colSinIdProducto.FieldName = "IdProducto"
        Me.colSinIdProducto.Name = "colSinIdProducto"
        '
        'colSinIdCertificado
        '
        Me.colSinIdCertificado.Caption = "IdCertificado"
        Me.colSinIdCertificado.FieldName = "IdCertificado"
        Me.colSinIdCertificado.Name = "colSinIdCertificado"
        '
        'pageCambio
        '
        Me.pageCambio.Controls.Add(Me.cboIdProducto)
        Me.pageCambio.Controls.Add(Me.txtIdPoliza)
        Me.pageCambio.Controls.Add(Me.btnCambiarCert)
        Me.pageCambio.Controls.Add(Me.txtIdCertificadoNuevo)
        Me.pageCambio.Controls.Add(Me.txtIdCertificadoActual)
        Me.pageCambio.Name = "pageCambio"
        Me.pageCambio.Size = New System.Drawing.Size(686, 151)
        Me.pageCambio.Text = "Cambiar Número de Certificado"
        '
        'txtIdCertificadoActual
        '
        Me.txtIdCertificadoActual.CampoBusqueda = False
        Me.txtIdCertificadoActual.CampoEsLlave = False
        Me.txtIdCertificadoActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificadoActual.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCertificadoActual.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificadoActual.FechaActual = False
        Me.txtIdCertificadoActual.Formato = ""
        Me.txtIdCertificadoActual.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificadoActual.LabelText = "Certificado Actual"
        Me.txtIdCertificadoActual.LabelWidth = 100
        Me.txtIdCertificadoActual.Location = New System.Drawing.Point(13, 55)
        Me.txtIdCertificadoActual.MaxLength = 0
        Me.txtIdCertificadoActual.Name = "txtIdCertificadoActual"
        Me.txtIdCertificadoActual.NombreCampo = ""
        Me.txtIdCertificadoActual.Obligatorio = False
        Me.txtIdCertificadoActual.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificadoActual.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCertificadoActual.SoloLectura = True
        Me.txtIdCertificadoActual.TabIndex = 0
        Me.txtIdCertificadoActual.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificadoActual.Valor = ""
        '
        'txtIdCertificadoNuevo
        '
        Me.txtIdCertificadoNuevo.CampoBusqueda = False
        Me.txtIdCertificadoNuevo.CampoEsLlave = False
        Me.txtIdCertificadoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificadoNuevo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCertificadoNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificadoNuevo.FechaActual = False
        Me.txtIdCertificadoNuevo.Formato = ""
        Me.txtIdCertificadoNuevo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificadoNuevo.LabelText = "Nuevo Certificado"
        Me.txtIdCertificadoNuevo.LabelWidth = 100
        Me.txtIdCertificadoNuevo.Location = New System.Drawing.Point(13, 81)
        Me.txtIdCertificadoNuevo.MaxLength = 0
        Me.txtIdCertificadoNuevo.Name = "txtIdCertificadoNuevo"
        Me.txtIdCertificadoNuevo.NombreCampo = ""
        Me.txtIdCertificadoNuevo.Obligatorio = False
        Me.txtIdCertificadoNuevo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificadoNuevo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCertificadoNuevo.SoloLectura = False
        Me.txtIdCertificadoNuevo.TabIndex = 1
        Me.txtIdCertificadoNuevo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificadoNuevo.Valor = ""
        '
        'btnCambiarCert
        '
        Me.btnCambiarCert.Location = New System.Drawing.Point(330, 55)
        Me.btnCambiarCert.Name = "btnCambiarCert"
        Me.btnCambiarCert.Size = New System.Drawing.Size(183, 46)
        Me.btnCambiarCert.TabIndex = 2
        Me.btnCambiarCert.Text = "Cambiar Certificado"
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 100
        Me.txtIdPoliza.Location = New System.Drawing.Point(13, 3)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 26
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = False
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 8106
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(13, 29)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(635, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 31
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'CertificadosCambiarNumero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(713, 491)
        Me.Controls.Add(Me.txtbusPoliza)
        Me.Controls.Add(Me.btnBuscarCertificado)
        Me.Controls.Add(Me.tabCertificados)
        Me.Controls.Add(Me.txtBusCliente)
        Me.Controls.Add(Me.gridCertificados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "CertificadosCambiarNumero"
        Me.Text = "Certificados"
        Me.Controls.SetChildIndex(Me.gridCertificados, 0)
        Me.Controls.SetChildIndex(Me.txtBusCliente, 0)
        Me.Controls.SetChildIndex(Me.tabCertificados, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtbusPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vistaCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCertificados.ResumeLayout(False)
        Me.pageDatosGenerales.ResumeLayout(False)
        CType(Me.layControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layControl.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageBienes.ResumeLayout(False)
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageBeneficiarios.ResumeLayout(False)
        CType(Me.GridBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageReclamos.ResumeLayout(False)
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageCambio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtbusPoliza As STIControles.stiTextBox
    Friend WithEvents txtBusCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscarCertificado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridCertificados As STIControles.stiGrid
    Friend WithEvents vistaCertificados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabCertificados As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pageDatosGenerales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pageBienes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pageBeneficiarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pageReclamos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pageCambio As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridSiniestros As STIControles.stiGrid
    Friend WithEvents VistaSiniestros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSinProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinReclamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinFecOcurre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinValorPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinValorPagado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBeneficiarios As STIControles.stiGrid
    Friend WithEvents VistaBeneficiarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIdBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbNombreBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colbParentesco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colbFechaNacimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPorcentaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBienes As STIControles.stiGrid
    Friend WithEvents VistaBienes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbiIdBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiNombreBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colbiDescripcionBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colBienSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColBienPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents layControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFechaInclusion As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtValorAsegurado As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboEstadoCertificado As STIControles.stiComboBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPrimaBruta As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDeducible As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPorceDescuento As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtParticipacion As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtValorDescuento As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPorceDepreciacion As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPrimaNeta As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPrimaMinima As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPrimaExenta As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRazonExclusion As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGastosEmi As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFechaExclusion As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGastosFrac As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtUsuarioModifica As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGastosBomb As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFechaModifica As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGastosOtros As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboIdVendedor As STIControles.stiComboBox
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtIva As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotal As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnCambiarCert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdCertificadoNuevo As STIControles.stiTextBox
    Friend WithEvents txtIdCertificadoActual As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox

End Class
