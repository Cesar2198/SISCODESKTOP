<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibosAplicar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibosAplicar))
        Me.txtTotalRecibo = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtNumRecibo = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtFechaRecibo = New STIControles.stiTextBox
        Me.GridFacturas = New STIControles.stiGrid
        Me.VistaFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumeroFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdRecibo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDocFiscal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDeposito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gridOtros = New STIControles.stiGrid
        Me.VistaOtros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalIng = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdReciboIng = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdOtroIngreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridPago = New STIControles.stiGrid
        Me.VistaPago = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdTipoIngreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumConfirmacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdReciboPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdAseguradoraPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtTotalEfectivo = New STIControles.stiTextBox
        Me.txtTotalCambio = New STIControles.stiTextBox
        Me.chkRecCambio = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(475, 506)
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(455, 81)
        Me.btnBuscar.Size = New System.Drawing.Size(145, 36)
        Me.btnBuscar.Text = "&Buscar Recibo"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(244, 506)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(338, 506)
        Me.btnGuardar.Size = New System.Drawing.Size(137, 36)
        Me.btnGuardar.Text = "A&plicar Recibo"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(567, 506)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(-1, 539)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
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
        Me.lblNombreFormulario.Text = "Pago de Facturas  y Depósitos en Recibo"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(0, 523)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtTotalRecibo
        '
        Me.txtTotalRecibo.CampoBusqueda = True
        Me.txtTotalRecibo.CampoEsLlave = False
        Me.txtTotalRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalRecibo.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotalRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalRecibo.FechaActual = False
        Me.txtTotalRecibo.Formato = "#,###0.00"
        Me.txtTotalRecibo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalRecibo.LabelText = "Total Recibo"
        Me.txtTotalRecibo.LabelWidth = 100
        Me.txtTotalRecibo.Location = New System.Drawing.Point(12, 185)
        Me.txtTotalRecibo.MaxLength = 0
        Me.txtTotalRecibo.Name = "txtTotalRecibo"
        Me.txtTotalRecibo.NombreCampo = "TotalRecibo"
        Me.txtTotalRecibo.Obligatorio = True
        Me.txtTotalRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalRecibo.Size = New System.Drawing.Size(218, 20)
        Me.txtTotalRecibo.SoloLectura = True
        Me.txtTotalRecibo.TabIndex = 29
        Me.txtTotalRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalRecibo.Valor = 0
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 159)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(638, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 27
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtNumRecibo
        '
        Me.txtNumRecibo.CampoBusqueda = True
        Me.txtNumRecibo.CampoEsLlave = True
        Me.txtNumRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumRecibo.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNumRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumRecibo.FechaActual = False
        Me.txtNumRecibo.Formato = ""
        Me.txtNumRecibo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumRecibo.LabelText = "Número Recibo"
        Me.txtNumRecibo.LabelWidth = 100
        Me.txtNumRecibo.Location = New System.Drawing.Point(12, 81)
        Me.txtNumRecibo.MaxLength = 0
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.NombreCampo = "IdRecibo"
        Me.txtNumRecibo.Obligatorio = True
        Me.txtNumRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumRecibo.Size = New System.Drawing.Size(218, 20)
        Me.txtNumRecibo.SoloLectura = True
        Me.txtNumRecibo.TabIndex = 28
        Me.txtNumRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumRecibo.Valor = "0"
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
        Me.txtIdCliente.LabelText = "NIT Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 133)
        Me.txtIdCliente.MaxLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(331, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 26
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtFechaRecibo
        '
        Me.txtFechaRecibo.CampoBusqueda = True
        Me.txtFechaRecibo.CampoEsLlave = False
        Me.txtFechaRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaRecibo.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaRecibo.FechaActual = True
        Me.txtFechaRecibo.Formato = "Long Date"
        Me.txtFechaRecibo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaRecibo.LabelText = "Fecha de Recibo"
        Me.txtFechaRecibo.LabelWidth = 100
        Me.txtFechaRecibo.Location = New System.Drawing.Point(12, 107)
        Me.txtFechaRecibo.MaxLength = 0
        Me.txtFechaRecibo.Name = "txtFechaRecibo"
        Me.txtFechaRecibo.NombreCampo = "FechaRecibo"
        Me.txtFechaRecibo.Obligatorio = True
        Me.txtFechaRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecibo.Size = New System.Drawing.Size(331, 20)
        Me.txtFechaRecibo.SoloLectura = True
        Me.txtFechaRecibo.TabIndex = 25
        Me.txtFechaRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecibo.Valor = Nothing
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.ColumnasAdicionales = ""
        Me.GridFacturas.Location = New System.Drawing.Point(6, 210)
        Me.GridFacturas.MainView = Me.VistaFacturas
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.NombreTabla = "RecibosFacturas"
        Me.GridFacturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemCheckEdit1})
        Me.GridFacturas.Size = New System.Drawing.Size(650, 101)
        Me.GridFacturas.TabIndex = 30
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaFacturas, Me.GridView2})
        '
        'VistaFacturas
        '
        Me.VistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumeroFactura, Me.colIdProducto, Me.colIdPoliza, Me.colIdRamo, Me.colNombreCliente, Me.colTotal, Me.colIdRecibo, Me.ColDocFiscal, Me.ColDeposito})
        Me.VistaFacturas.GridControl = Me.GridFacturas
        Me.VistaFacturas.Name = "VistaFacturas"
        Me.VistaFacturas.OptionsView.ShowFooter = True
        Me.VistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'colNumeroFactura
        '
        Me.colNumeroFactura.Caption = "Factura"
        Me.colNumeroFactura.FieldName = "NumeroFactura"
        Me.colNumeroFactura.Name = "colNumeroFactura"
        Me.colNumeroFactura.OptionsColumn.AllowEdit = False
        Me.colNumeroFactura.Visible = True
        Me.colNumeroFactura.VisibleIndex = 0
        Me.colNumeroFactura.Width = 57
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "Producto"
        Me.colIdProducto.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.OptionsColumn.AllowEdit = False
        Me.colIdProducto.Visible = True
        Me.colIdProducto.VisibleIndex = 1
        Me.colIdProducto.Width = 57
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'colIdPoliza
        '
        Me.colIdPoliza.Caption = "Póliza"
        Me.colIdPoliza.FieldName = "IdPoliza"
        Me.colIdPoliza.Name = "colIdPoliza"
        Me.colIdPoliza.OptionsColumn.AllowEdit = False
        Me.colIdPoliza.Visible = True
        Me.colIdPoliza.VisibleIndex = 2
        Me.colIdPoliza.Width = 54
        '
        'colIdRamo
        '
        Me.colIdRamo.Caption = "Ramo"
        Me.colIdRamo.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colIdRamo.FieldName = "IdRamo"
        Me.colIdRamo.Name = "colIdRamo"
        Me.colIdRamo.OptionsColumn.AllowEdit = False
        Me.colIdRamo.Visible = True
        Me.colIdRamo.VisibleIndex = 3
        Me.colIdRamo.Width = 50
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        '
        'colNombreCliente
        '
        Me.colNombreCliente.Caption = "Cliente"
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.OptionsColumn.AllowEdit = False
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 4
        Me.colNombreCliente.Width = 175
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total Factura"
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        Me.colTotal.Width = 94
        '
        'colIdRecibo
        '
        Me.colIdRecibo.Caption = "Recibo"
        Me.colIdRecibo.FieldName = "IdRecibo"
        Me.colIdRecibo.Name = "colIdRecibo"
        Me.colIdRecibo.OptionsColumn.AllowEdit = False
        '
        'ColDocFiscal
        '
        Me.ColDocFiscal.Caption = "Doc. Fiscal"
        Me.ColDocFiscal.FieldName = "DocFiscal"
        Me.ColDocFiscal.Name = "ColDocFiscal"
        Me.ColDocFiscal.Visible = True
        Me.ColDocFiscal.VisibleIndex = 6
        Me.ColDocFiscal.Width = 69
        '
        'ColDeposito
        '
        Me.ColDeposito.Caption = "A Depósito"
        Me.ColDeposito.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.ColDeposito.FieldName = "Deposito"
        Me.ColDeposito.Name = "ColDeposito"
        Me.ColDeposito.Visible = True
        Me.ColDeposito.VisibleIndex = 7
        Me.ColDeposito.Width = 73
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridFacturas
        Me.GridView2.Name = "GridView2"
        '
        'gridOtros
        '
        Me.gridOtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOtros.ColumnasAdicionales = ""
        Me.gridOtros.Location = New System.Drawing.Point(6, 314)
        Me.gridOtros.MainView = Me.VistaOtros
        Me.gridOtros.Name = "gridOtros"
        Me.gridOtros.NombreTabla = "RecibosOtrosIngresos"
        Me.gridOtros.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
        Me.gridOtros.Size = New System.Drawing.Size(650, 94)
        Me.gridOtros.TabIndex = 31
        Me.gridOtros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaOtros})
        '
        'VistaOtros
        '
        Me.VistaOtros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdAseguradora, Me.colDescripcion, Me.colTotalIng, Me.colIdReciboIng, Me.colIdOtroIngreso})
        Me.VistaOtros.GridControl = Me.gridOtros
        Me.VistaOtros.Name = "VistaOtros"
        Me.VistaOtros.OptionsBehavior.Editable = False
        Me.VistaOtros.OptionsView.ShowFooter = True
        Me.VistaOtros.OptionsView.ShowGroupPanel = False
        '
        'colIdAseguradora
        '
        Me.colIdAseguradora.Caption = "Aseguradora"
        Me.colIdAseguradora.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colIdAseguradora.FieldName = "IdAseguradora"
        Me.colIdAseguradora.Name = "colIdAseguradora"
        Me.colIdAseguradora.Visible = True
        Me.colIdAseguradora.VisibleIndex = 0
        Me.colIdAseguradora.Width = 193
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 297
        '
        'colTotalIng
        '
        Me.colTotalIng.Caption = "Valor"
        Me.colTotalIng.DisplayFormat.FormatString = "c"
        Me.colTotalIng.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalIng.FieldName = "Total"
        Me.colTotalIng.Name = "colTotalIng"
        Me.colTotalIng.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotalIng.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalIng.Visible = True
        Me.colTotalIng.VisibleIndex = 2
        Me.colTotalIng.Width = 139
        '
        'colIdReciboIng
        '
        Me.colIdReciboIng.Caption = "Recibo"
        Me.colIdReciboIng.FieldName = "IdRecibo"
        Me.colIdReciboIng.Name = "colIdReciboIng"
        '
        'colIdOtroIngreso
        '
        Me.colIdOtroIngreso.Caption = "IdIngreso"
        Me.colIdOtroIngreso.FieldName = "IdOtroIngreso"
        Me.colIdOtroIngreso.Name = "colIdOtroIngreso"
        '
        'GridPago
        '
        Me.GridPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPago.ColumnasAdicionales = ""
        Me.GridPago.Location = New System.Drawing.Point(6, 411)
        Me.GridPago.MainView = Me.VistaPago
        Me.GridPago.Name = "GridPago"
        Me.GridPago.NombreTabla = "RecibosPagos"
        Me.GridPago.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit6})
        Me.GridPago.Size = New System.Drawing.Size(650, 91)
        Me.GridPago.TabIndex = 32
        Me.GridPago.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPago})
        '
        'VistaPago
        '
        Me.VistaPago.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdTipoIngreso, Me.colIdBanco, Me.colDocumento, Me.colNumConfirmacion, Me.colTotalPag, Me.colIdReciboPag, Me.colIdAseguradoraPag, Me.colIdPago, Me.GridColumn1})
        Me.VistaPago.GridControl = Me.GridPago
        Me.VistaPago.Name = "VistaPago"
        Me.VistaPago.OptionsBehavior.Editable = False
        Me.VistaPago.OptionsView.ShowFooter = True
        Me.VistaPago.OptionsView.ShowGroupPanel = False
        '
        'colIdTipoIngreso
        '
        Me.colIdTipoIngreso.Caption = "Tipo de Ingreso"
        Me.colIdTipoIngreso.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIdTipoIngreso.FieldName = "IdTipoIngreso"
        Me.colIdTipoIngreso.Name = "colIdTipoIngreso"
        Me.colIdTipoIngreso.Visible = True
        Me.colIdTipoIngreso.VisibleIndex = 0
        Me.colIdTipoIngreso.Width = 99
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colIdBanco
        '
        Me.colIdBanco.Caption = "Banco"
        Me.colIdBanco.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colIdBanco.FieldName = "IdBanco"
        Me.colIdBanco.Name = "colIdBanco"
        Me.colIdBanco.Visible = True
        Me.colIdBanco.VisibleIndex = 1
        Me.colIdBanco.Width = 81
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Documento"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 2
        Me.colDocumento.Width = 69
        '
        'colNumConfirmacion
        '
        Me.colNumConfirmacion.Caption = "No. Confirmación"
        Me.colNumConfirmacion.FieldName = "NumConfirmacion"
        Me.colNumConfirmacion.Name = "colNumConfirmacion"
        Me.colNumConfirmacion.Visible = True
        Me.colNumConfirmacion.VisibleIndex = 3
        Me.colNumConfirmacion.Width = 94
        '
        'colTotalPag
        '
        Me.colTotalPag.Caption = "Monto"
        Me.colTotalPag.DisplayFormat.FormatString = "c"
        Me.colTotalPag.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalPag.FieldName = "Total"
        Me.colTotalPag.Name = "colTotalPag"
        Me.colTotalPag.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotalPag.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalPag.Visible = True
        Me.colTotalPag.VisibleIndex = 5
        Me.colTotalPag.Width = 142
        '
        'colIdReciboPag
        '
        Me.colIdReciboPag.Caption = "Recibo"
        Me.colIdReciboPag.FieldName = "IdRecibo"
        Me.colIdReciboPag.Name = "colIdReciboPag"
        '
        'colIdAseguradoraPag
        '
        Me.colIdAseguradoraPag.Caption = "Aseguradora"
        Me.colIdAseguradoraPag.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.colIdAseguradoraPag.FieldName = "IdAseguradora"
        Me.colIdAseguradoraPag.Name = "colIdAseguradoraPag"
        Me.colIdAseguradoraPag.Visible = True
        Me.colIdAseguradoraPag.VisibleIndex = 4
        Me.colIdAseguradoraPag.Width = 144
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        '
        'colIdPago
        '
        Me.colIdPago.Caption = "IdPago"
        Me.colIdPago.FieldName = "IdPago"
        Me.colIdPago.Name = "colIdPago"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cambio"
        Me.GridColumn1.DisplayFormat.FormatString = "c2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Cambio"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        '
        'txtTotalEfectivo
        '
        Me.txtTotalEfectivo.CampoBusqueda = True
        Me.txtTotalEfectivo.CampoEsLlave = False
        Me.txtTotalEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalEfectivo.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotalEfectivo.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalEfectivo.FechaActual = False
        Me.txtTotalEfectivo.Formato = "#,###0.00"
        Me.txtTotalEfectivo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalEfectivo.LabelText = "Total Efectivo"
        Me.txtTotalEfectivo.LabelWidth = 100
        Me.txtTotalEfectivo.Location = New System.Drawing.Point(236, 185)
        Me.txtTotalEfectivo.MaxLength = 0
        Me.txtTotalEfectivo.Name = "txtTotalEfectivo"
        Me.txtTotalEfectivo.NombreCampo = "TotalRecibo"
        Me.txtTotalEfectivo.Obligatorio = True
        Me.txtTotalEfectivo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalEfectivo.Size = New System.Drawing.Size(218, 20)
        Me.txtTotalEfectivo.SoloLectura = True
        Me.txtTotalEfectivo.TabIndex = 33
        Me.txtTotalEfectivo.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalEfectivo.Valor = 0
        '
        'txtTotalCambio
        '
        Me.txtTotalCambio.CampoBusqueda = True
        Me.txtTotalCambio.CampoEsLlave = False
        Me.txtTotalCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalCambio.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotalCambio.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalCambio.FechaActual = False
        Me.txtTotalCambio.Formato = "#,###0.00"
        Me.txtTotalCambio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalCambio.LabelText = "Total Cambio"
        Me.txtTotalCambio.LabelWidth = 100
        Me.txtTotalCambio.Location = New System.Drawing.Point(466, 185)
        Me.txtTotalCambio.MaxLength = 0
        Me.txtTotalCambio.Name = "txtTotalCambio"
        Me.txtTotalCambio.NombreCampo = "TotalRecibo"
        Me.txtTotalCambio.Obligatorio = True
        Me.txtTotalCambio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalCambio.Size = New System.Drawing.Size(184, 20)
        Me.txtTotalCambio.SoloLectura = True
        Me.txtTotalCambio.TabIndex = 34
        Me.txtTotalCambio.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalCambio.Valor = 0
        '
        'chkRecCambio
        '
        Me.chkRecCambio.AutoSize = True
        Me.chkRecCambio.Location = New System.Drawing.Point(24, 508)
        Me.chkRecCambio.Name = "chkRecCambio"
        Me.chkRecCambio.Size = New System.Drawing.Size(167, 17)
        Me.chkRecCambio.TabIndex = 35
        Me.chkRecCambio.Text = "Se recibió Cambio en Efectivo"
        Me.chkRecCambio.UseVisualStyleBackColor = True
        '
        'RecibosAplicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 403
        Me.ClientSize = New System.Drawing.Size(662, 549)
        Me.Controls.Add(Me.chkRecCambio)
        Me.Controls.Add(Me.txtTotalCambio)
        Me.Controls.Add(Me.txtTotalEfectivo)
        Me.Controls.Add(Me.GridPago)
        Me.Controls.Add(Me.gridOtros)
        Me.Controls.Add(Me.GridFacturas)
        Me.Controls.Add(Me.txtTotalRecibo)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtNumRecibo)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtFechaRecibo)
        Me.Name = "RecibosAplicar"
        Me.Text = "Aplicación de Recibos"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNumRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtTotalRecibo, 0)
        Me.Controls.SetChildIndex(Me.GridFacturas, 0)
        Me.Controls.SetChildIndex(Me.gridOtros, 0)
        Me.Controls.SetChildIndex(Me.GridPago, 0)
        Me.Controls.SetChildIndex(Me.txtTotalEfectivo, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCambio, 0)
        Me.Controls.SetChildIndex(Me.chkRecCambio, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalRecibo As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtNumRecibo As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtFechaRecibo As STIControles.stiTextBox
    Friend WithEvents GridFacturas As STIControles.stiGrid
    Friend WithEvents VistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumeroFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridOtros As STIControles.stiGrid
    Friend WithEvents VistaOtros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdAseguradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalIng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdReciboIng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdOtroIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDeposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridPago As STIControles.stiGrid
    Friend WithEvents VistaPago As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdTipoIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumConfirmacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdReciboPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdAseguradoraPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDocFiscal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalEfectivo As STIControles.stiTextBox
    Friend WithEvents txtTotalCambio As STIControles.stiTextBox
    Friend WithEvents chkRecCambio As System.Windows.Forms.CheckBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

End Class
