<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibosMan))
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnQuitarFac = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarFac = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.gridOtros = New STIControles.stiGrid
        Me.VistaOtros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTotalIng = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdReciboIng = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdOtroIngreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnQuitarOT = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarOT = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GridPago = New STIControles.stiGrid
        Me.VistaPago = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdTipoIngreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNumConfirmacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdReciboPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdAseguradoraPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCambio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnQuitarPago = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarPago = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtFechaRecibo = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNumRecibo = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtTotalRecibo = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.cboEstadoRecibo = New STIControles.stiComboBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cboEnviadoAseguradoras = New STIControles.stiComboBox
        Me.txtDeposito = New STIControles.stiTextBox
        Me.txtMotivoAnulacion = New STIControles.stiTextBox
        Me.txtFechaAnulacion = New STIControles.stiTextBox
        Me.txtUsuarioGrabacion = New STIControles.stiTextBox
        Me.txtUsuarioAnulacion = New STIControles.stiTextBox
        Me.txtObservaciones = New STIControles.stiTextBox
        Me.chkPagoDirecto = New DevExpress.XtraEditors.CheckEdit
        Me.chkEnviarRuteo = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPagoDirecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEnviarRuteo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(600, 533)
        Me.btnAyuda.TabIndex = 16
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(366, 533)
        Me.btnBuscar.TabIndex = 15
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(181, 533)
        Me.btnNuevo.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(273, 533)
        Me.btnGuardar.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(692, 533)
        Me.btnSalir.TabIndex = 17
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(39, 559)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.TabIndex = 26
        Me.btnEliminar.Visible = False
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(199, 74)
        Me.lblNombreFormulario.TabIndex = 24
        Me.lblNombreFormulario.Text = "Recibos de Ingresos"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(30, 559)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 25
        Me.btnGuardarComo.Visible = False
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.ColumnasAdicionales = ""
        Me.GridFacturas.Location = New System.Drawing.Point(6, 169)
        Me.GridFacturas.MainView = Me.VistaFacturas
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.NombreTabla = "RecibosFacturas"
        Me.GridFacturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.GridFacturas.Size = New System.Drawing.Size(680, 103)
        Me.GridFacturas.TabIndex = 10
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaFacturas, Me.GridView2})
        '
        'VistaFacturas
        '
        Me.VistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumeroFactura, Me.colIdProducto, Me.colIdPoliza, Me.colIdRamo, Me.colNombreCliente, Me.colTotal, Me.colIdRecibo})
        Me.VistaFacturas.GridControl = Me.GridFacturas
        Me.VistaFacturas.Name = "VistaFacturas"
        Me.VistaFacturas.OptionsBehavior.Editable = False
        Me.VistaFacturas.OptionsView.ShowFooter = True
        Me.VistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'colNumeroFactura
        '
        Me.colNumeroFactura.Caption = "Factura"
        Me.colNumeroFactura.FieldName = "NumeroFactura"
        Me.colNumeroFactura.Name = "colNumeroFactura"
        Me.colNumeroFactura.Visible = True
        Me.colNumeroFactura.VisibleIndex = 0
        Me.colNumeroFactura.Width = 71
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "Producto"
        Me.colIdProducto.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = True
        Me.colIdProducto.VisibleIndex = 1
        Me.colIdProducto.Width = 71
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
        Me.colIdPoliza.Visible = True
        Me.colIdPoliza.VisibleIndex = 2
        Me.colIdPoliza.Width = 67
        '
        'colIdRamo
        '
        Me.colIdRamo.Caption = "Ramo"
        Me.colIdRamo.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colIdRamo.FieldName = "IdRamo"
        Me.colIdRamo.Name = "colIdRamo"
        Me.colIdRamo.Visible = True
        Me.colIdRamo.VisibleIndex = 3
        Me.colIdRamo.Width = 62
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
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 4
        Me.colNombreCliente.Width = 217
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total Factura"
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        Me.colTotal.Width = 141
        '
        'colIdRecibo
        '
        Me.colIdRecibo.Caption = "Recibo"
        Me.colIdRecibo.FieldName = "IdRecibo"
        Me.colIdRecibo.Name = "colIdRecibo"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridFacturas
        Me.GridView2.Name = "GridView2"
        '
        'btnQuitarFac
        '
        Me.btnQuitarFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarFac.Location = New System.Drawing.Point(692, 198)
        Me.btnQuitarFac.Name = "btnQuitarFac"
        Me.btnQuitarFac.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarFac.TabIndex = 5
        Me.btnQuitarFac.Text = "Quitar"
        '
        'btnAgregarFac
        '
        Me.btnAgregarFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarFac.Location = New System.Drawing.Point(692, 169)
        Me.btnAgregarFac.Name = "btnAgregarFac"
        Me.btnAgregarFac.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarFac.TabIndex = 4
        Me.btnAgregarFac.Text = "Agregar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(9, 151)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(168, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Facturas/Créditos de Seguros"
        '
        'gridOtros
        '
        Me.gridOtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOtros.ColumnasAdicionales = ""
        Me.gridOtros.Location = New System.Drawing.Point(6, 291)
        Me.gridOtros.MainView = Me.VistaOtros
        Me.gridOtros.Name = "gridOtros"
        Me.gridOtros.NombreTabla = "RecibosOtrosIngresos"
        Me.gridOtros.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5, Me.RepositoryItemTextEdit2})
        Me.gridOtros.Size = New System.Drawing.Size(680, 86)
        Me.gridOtros.TabIndex = 11
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
        Me.colDescripcion.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 297
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
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
        'btnQuitarOT
        '
        Me.btnQuitarOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarOT.Location = New System.Drawing.Point(693, 320)
        Me.btnQuitarOT.Name = "btnQuitarOT"
        Me.btnQuitarOT.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarOT.TabIndex = 7
        Me.btnQuitarOT.Text = "Quitar"
        '
        'btnAgregarOT
        '
        Me.btnAgregarOT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarOT.Location = New System.Drawing.Point(693, 291)
        Me.btnAgregarOT.Name = "btnAgregarOT"
        Me.btnAgregarOT.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarOT.TabIndex = 6
        Me.btnAgregarOT.Text = "Agregar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(9, 274)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Otros Ingresos"
        '
        'GridPago
        '
        Me.GridPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPago.ColumnasAdicionales = ""
        Me.GridPago.Location = New System.Drawing.Point(6, 400)
        Me.GridPago.MainView = Me.VistaPago
        Me.GridPago.Name = "GridPago"
        Me.GridPago.NombreTabla = "RecibosPagos"
        Me.GridPago.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemTextEdit1})
        Me.GridPago.Size = New System.Drawing.Size(680, 103)
        Me.GridPago.TabIndex = 12
        Me.GridPago.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPago})
        '
        'VistaPago
        '
        Me.VistaPago.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdTipoIngreso, Me.colIdBanco, Me.colDocumento, Me.colNumConfirmacion, Me.colTotalPag, Me.colIdReciboPag, Me.colIdAseguradoraPag, Me.colIdPago, Me.colCambio})
        Me.VistaPago.GridControl = Me.GridPago
        Me.VistaPago.Name = "VistaPago"
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
        Me.colDocumento.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 2
        Me.colDocumento.Width = 69
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
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
        Me.colTotalPag.DisplayFormat.FormatString = "c2"
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
        'colCambio
        '
        Me.colCambio.Caption = "Cambio"
        Me.colCambio.DisplayFormat.FormatString = "c2"
        Me.colCambio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCambio.FieldName = "Cambio"
        Me.colCambio.Name = "colCambio"
        Me.colCambio.OptionsColumn.AllowEdit = False
        Me.colCambio.Visible = True
        Me.colCambio.VisibleIndex = 6
        '
        'btnQuitarPago
        '
        Me.btnQuitarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarPago.Location = New System.Drawing.Point(692, 429)
        Me.btnQuitarPago.Name = "btnQuitarPago"
        Me.btnQuitarPago.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarPago.TabIndex = 9
        Me.btnQuitarPago.Text = "Quitar"
        '
        'btnAgregarPago
        '
        Me.btnAgregarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarPago.Location = New System.Drawing.Point(692, 400)
        Me.btnAgregarPago.Name = "btnAgregarPago"
        Me.btnAgregarPago.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarPago.TabIndex = 8
        Me.btnAgregarPago.Text = "Agregar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(9, 385)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Conceptos de Pago"
        '
        'txtFechaRecibo
        '
        Me.txtFechaRecibo.CampoBusqueda = True
        Me.txtFechaRecibo.CampoEsLlave = False
        Me.txtFechaRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaRecibo.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaRecibo.FechaActual = False
        Me.txtFechaRecibo.Formato = "Long Date"
        Me.txtFechaRecibo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaRecibo.LabelText = "Fecha de Recibo"
        Me.txtFechaRecibo.LabelWidth = 100
        Me.txtFechaRecibo.Location = New System.Drawing.Point(6, 122)
        Me.txtFechaRecibo.MaxLength = 0
        Me.txtFechaRecibo.Name = "txtFechaRecibo"
        Me.txtFechaRecibo.NombreCampo = "FechaRecibo"
        Me.txtFechaRecibo.Obligatorio = True
        Me.txtFechaRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecibo.Size = New System.Drawing.Size(331, 20)
        Me.txtFechaRecibo.SoloLectura = False
        Me.txtFechaRecibo.TabIndex = 0
        Me.txtFechaRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecibo.Valor = Nothing
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = True
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "NIT Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(343, 122)
        Me.txtIdCliente.MaxLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(288, 20)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 2
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNumRecibo
        '
        Me.txtNumRecibo.CampoBusqueda = True
        Me.txtNumRecibo.CampoEsLlave = True
        Me.txtNumRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumRecibo.ControlBackColor = System.Drawing.Color.White
        Me.txtNumRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumRecibo.FechaActual = False
        Me.txtNumRecibo.Formato = ""
        Me.txtNumRecibo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNumRecibo.LabelText = "Número Recibo"
        Me.txtNumRecibo.LabelWidth = 100
        Me.txtNumRecibo.Location = New System.Drawing.Point(343, 1)
        Me.txtNumRecibo.MaxLength = 0
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.NombreCampo = "IdRecibo"
        Me.txtNumRecibo.Obligatorio = True
        Me.txtNumRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumRecibo.Size = New System.Drawing.Size(145, 36)
        Me.txtNumRecibo.SoloLectura = False
        Me.txtNumRecibo.TabIndex = 18
        Me.txtNumRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumRecibo.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(343, 145)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(401, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 3
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtTotalRecibo
        '
        Me.txtTotalRecibo.CampoBusqueda = True
        Me.txtTotalRecibo.CampoEsLlave = False
        Me.txtTotalRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalRecibo.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalRecibo.FechaActual = False
        Me.txtTotalRecibo.Formato = "#,###0.00"
        Me.txtTotalRecibo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTotalRecibo.LabelText = "Total Recibo"
        Me.txtTotalRecibo.LabelWidth = 100
        Me.txtTotalRecibo.Location = New System.Drawing.Point(494, 1)
        Me.txtTotalRecibo.MaxLength = 0
        Me.txtTotalRecibo.Name = "txtTotalRecibo"
        Me.txtTotalRecibo.NombreCampo = "TotalRecibo"
        Me.txtTotalRecibo.Obligatorio = True
        Me.txtTotalRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalRecibo.Size = New System.Drawing.Size(145, 36)
        Me.txtTotalRecibo.SoloLectura = False
        Me.txtTotalRecibo.TabIndex = 19
        Me.txtTotalRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalRecibo.Valor = 0
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(637, 118)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 1
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'cboEstadoRecibo
        '
        Me.cboEstadoRecibo.CampoAutoCompletar = 0
        Me.cboEstadoRecibo.CampoBusqueda = False
        Me.cboEstadoRecibo.CampoDisplay = 1
        Me.cboEstadoRecibo.CampoEsLlave = False
        Me.cboEstadoRecibo.CampoValor = 0
        Me.cboEstadoRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoRecibo.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoRecibo.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoRecibo.FilasVisibles = 74
        Me.cboEstadoRecibo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboEstadoRecibo.LabelText = "Estado Recibo"
        Me.cboEstadoRecibo.LabelWidth = 100
        Me.cboEstadoRecibo.Lista = "P Pendiente|A Aplicado|N Anulado"
        Me.cboEstadoRecibo.Location = New System.Drawing.Point(494, 35)
        Me.cboEstadoRecibo.MostrarBusquedaColumnas = False
        Me.cboEstadoRecibo.Name = "cboEstadoRecibo"
        Me.cboEstadoRecibo.NombreCampo = "EstadoRecibo"
        Me.cboEstadoRecibo.Obligatorio = False
        Me.cboEstadoRecibo.Query = ""
        Me.cboEstadoRecibo.SelectIndex = 0
        Me.cboEstadoRecibo.Size = New System.Drawing.Size(145, 38)
        Me.cboEstadoRecibo.SoloLectura = False
        Me.cboEstadoRecibo.StringConection = ""
        Me.cboEstadoRecibo.TabIndex = 20
        Me.cboEstadoRecibo.TextoNuevoItem = ""
        Me.cboEstadoRecibo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoRecibo.Valor = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(459, 533)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(141, 36)
        Me.btnImprimir.TabIndex = 27
        Me.btnImprimir.Text = "&Imprimir Recibo"
        '
        'cboEnviadoAseguradoras
        '
        Me.cboEnviadoAseguradoras.CampoAutoCompletar = 0
        Me.cboEnviadoAseguradoras.CampoBusqueda = False
        Me.cboEnviadoAseguradoras.CampoDisplay = 1
        Me.cboEnviadoAseguradoras.CampoEsLlave = False
        Me.cboEnviadoAseguradoras.CampoValor = 0
        Me.cboEnviadoAseguradoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEnviadoAseguradoras.ControlBackColor = System.Drawing.Color.White
        Me.cboEnviadoAseguradoras.ControlForeColor = System.Drawing.Color.Black
        Me.cboEnviadoAseguradoras.FilasVisibles = 74
        Me.cboEnviadoAseguradoras.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboEnviadoAseguradoras.LabelText = "Enviado a las Aseguradoras"
        Me.cboEnviadoAseguradoras.LabelWidth = 100
        Me.cboEnviadoAseguradoras.Lista = "E Enviado|P Pendiente"
        Me.cboEnviadoAseguradoras.Location = New System.Drawing.Point(343, 35)
        Me.cboEnviadoAseguradoras.MostrarBusquedaColumnas = False
        Me.cboEnviadoAseguradoras.Name = "cboEnviadoAseguradoras"
        Me.cboEnviadoAseguradoras.NombreCampo = "EnviadoAseguradoras"
        Me.cboEnviadoAseguradoras.Obligatorio = False
        Me.cboEnviadoAseguradoras.Query = ""
        Me.cboEnviadoAseguradoras.SelectIndex = 0
        Me.cboEnviadoAseguradoras.Size = New System.Drawing.Size(145, 38)
        Me.cboEnviadoAseguradoras.SoloLectura = False
        Me.cboEnviadoAseguradoras.StringConection = ""
        Me.cboEnviadoAseguradoras.TabIndex = 28
        Me.cboEnviadoAseguradoras.TextoNuevoItem = ""
        Me.cboEnviadoAseguradoras.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEnviadoAseguradoras.Valor = ""
        '
        'txtDeposito
        '
        Me.txtDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeposito.CampoBusqueda = True
        Me.txtDeposito.CampoEsLlave = False
        Me.txtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDeposito.ControlBackColor = System.Drawing.Color.White
        Me.txtDeposito.ControlForeColor = System.Drawing.Color.Black
        Me.txtDeposito.FechaActual = False
        Me.txtDeposito.Formato = "$#,###0.00"
        Me.txtDeposito.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDeposito.LabelText = "Total Cliente Depósito"
        Me.txtDeposito.LabelWidth = 140
        Me.txtDeposito.Location = New System.Drawing.Point(446, 379)
        Me.txtDeposito.MaxLength = 0
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.NombreCampo = ""
        Me.txtDeposito.Obligatorio = False
        Me.txtDeposito.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeposito.Size = New System.Drawing.Size(238, 20)
        Me.txtDeposito.SoloLectura = False
        Me.txtDeposito.TabIndex = 29
        Me.txtDeposito.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtDeposito.Valor = 0
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.CampoBusqueda = True
        Me.txtMotivoAnulacion.CampoEsLlave = False
        Me.txtMotivoAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoAnulacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtMotivoAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoAnulacion.FechaActual = False
        Me.txtMotivoAnulacion.Formato = ""
        Me.txtMotivoAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMotivoAnulacion.LabelText = "Motivo Anula"
        Me.txtMotivoAnulacion.LabelWidth = 100
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(6, 77)
        Me.txtMotivoAnulacion.MaxLength = 500
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.NombreCampo = "MotivoAnulacion"
        Me.txtMotivoAnulacion.Obligatorio = False
        Me.txtMotivoAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(332, 20)
        Me.txtMotivoAnulacion.SoloLectura = True
        Me.txtMotivoAnulacion.TabIndex = 30
        Me.txtMotivoAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoAnulacion.Valor = ""
        '
        'txtFechaAnulacion
        '
        Me.txtFechaAnulacion.CampoBusqueda = True
        Me.txtFechaAnulacion.CampoEsLlave = False
        Me.txtFechaAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAnulacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAnulacion.FechaActual = False
        Me.txtFechaAnulacion.Formato = "Long Date"
        Me.txtFechaAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAnulacion.LabelText = "Fecha Anulación"
        Me.txtFechaAnulacion.LabelWidth = 100
        Me.txtFechaAnulacion.Location = New System.Drawing.Point(6, 99)
        Me.txtFechaAnulacion.MaxLength = 0
        Me.txtFechaAnulacion.Name = "txtFechaAnulacion"
        Me.txtFechaAnulacion.NombreCampo = "FechaAnulacion"
        Me.txtFechaAnulacion.Obligatorio = False
        Me.txtFechaAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAnulacion.Size = New System.Drawing.Size(331, 20)
        Me.txtFechaAnulacion.SoloLectura = True
        Me.txtFechaAnulacion.TabIndex = 31
        Me.txtFechaAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAnulacion.Valor = Nothing
        '
        'txtUsuarioGrabacion
        '
        Me.txtUsuarioGrabacion.CampoBusqueda = True
        Me.txtUsuarioGrabacion.CampoEsLlave = False
        Me.txtUsuarioGrabacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioGrabacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUsuarioGrabacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioGrabacion.FechaActual = False
        Me.txtUsuarioGrabacion.Formato = ""
        Me.txtUsuarioGrabacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtUsuarioGrabacion.LabelText = "Usuario Graba"
        Me.txtUsuarioGrabacion.LabelWidth = 100
        Me.txtUsuarioGrabacion.Location = New System.Drawing.Point(343, 78)
        Me.txtUsuarioGrabacion.MaxLength = 25
        Me.txtUsuarioGrabacion.Name = "txtUsuarioGrabacion"
        Me.txtUsuarioGrabacion.NombreCampo = "UsuarioGrabacion"
        Me.txtUsuarioGrabacion.Obligatorio = False
        Me.txtUsuarioGrabacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioGrabacion.Size = New System.Drawing.Size(145, 36)
        Me.txtUsuarioGrabacion.SoloLectura = True
        Me.txtUsuarioGrabacion.TabIndex = 32
        Me.txtUsuarioGrabacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioGrabacion.Valor = ""
        '
        'txtUsuarioAnulacion
        '
        Me.txtUsuarioAnulacion.CampoBusqueda = True
        Me.txtUsuarioAnulacion.CampoEsLlave = False
        Me.txtUsuarioAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioAnulacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUsuarioAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioAnulacion.FechaActual = False
        Me.txtUsuarioAnulacion.Formato = ""
        Me.txtUsuarioAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtUsuarioAnulacion.LabelText = "Usuario Anula"
        Me.txtUsuarioAnulacion.LabelWidth = 100
        Me.txtUsuarioAnulacion.Location = New System.Drawing.Point(494, 78)
        Me.txtUsuarioAnulacion.MaxLength = 25
        Me.txtUsuarioAnulacion.Name = "txtUsuarioAnulacion"
        Me.txtUsuarioAnulacion.NombreCampo = "UsuarioAnulacion"
        Me.txtUsuarioAnulacion.Obligatorio = False
        Me.txtUsuarioAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioAnulacion.Size = New System.Drawing.Size(145, 36)
        Me.txtUsuarioAnulacion.SoloLectura = True
        Me.txtUsuarioAnulacion.TabIndex = 33
        Me.txtUsuarioAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioAnulacion.Valor = ""
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.CampoBusqueda = True
        Me.txtObservaciones.CampoEsLlave = False
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservaciones.ControlBackColor = System.Drawing.Color.White
        Me.txtObservaciones.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.FechaActual = False
        Me.txtObservaciones.Formato = ""
        Me.txtObservaciones.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtObservaciones.LabelText = "Observaciones"
        Me.txtObservaciones.LabelWidth = 100
        Me.txtObservaciones.Location = New System.Drawing.Point(6, 508)
        Me.txtObservaciones.MaxLength = 0
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = "Observaciones"
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(680, 20)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 34
        Me.txtObservaciones.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'chkPagoDirecto
        '
        Me.chkPagoDirecto.Location = New System.Drawing.Point(645, 18)
        Me.chkPagoDirecto.Name = "chkPagoDirecto"
        Me.chkPagoDirecto.Properties.Caption = "Pago Directo en ADRISA"
        Me.chkPagoDirecto.Size = New System.Drawing.Size(141, 19)
        Me.chkPagoDirecto.TabIndex = 35
        Me.chkPagoDirecto.Visible = False
        '
        'chkEnviarRuteo
        '
        Me.chkEnviarRuteo.Location = New System.Drawing.Point(645, 56)
        Me.chkEnviarRuteo.Name = "chkEnviarRuteo"
        Me.chkEnviarRuteo.Properties.Caption = "Enviar a ruta para cobro"
        Me.chkEnviarRuteo.Size = New System.Drawing.Size(141, 19)
        Me.chkEnviarRuteo.TabIndex = 36
        Me.chkEnviarRuteo.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(138, 381)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(203, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "FAVOR NO RECIBA PAGOS INCOMPLETOS"
        '
        'RecibosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 409
        Me.ClientSize = New System.Drawing.Size(786, 569)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.chkEnviarRuteo)
        Me.Controls.Add(Me.chkPagoDirecto)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtUsuarioAnulacion)
        Me.Controls.Add(Me.txtUsuarioGrabacion)
        Me.Controls.Add(Me.txtFechaAnulacion)
        Me.Controls.Add(Me.txtMotivoAnulacion)
        Me.Controls.Add(Me.txtTotalRecibo)
        Me.Controls.Add(Me.cboEstadoRecibo)
        Me.Controls.Add(Me.txtNumRecibo)
        Me.Controls.Add(Me.txtDeposito)
        Me.Controls.Add(Me.cboEnviadoAseguradoras)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtFechaRecibo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btnQuitarPago)
        Me.Controls.Add(Me.btnAgregarPago)
        Me.Controls.Add(Me.GridPago)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btnQuitarOT)
        Me.Controls.Add(Me.btnAgregarOT)
        Me.Controls.Add(Me.gridOtros)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnQuitarFac)
        Me.Controls.Add(Me.btnAgregarFac)
        Me.Controls.Add(Me.GridFacturas)
        Me.Name = "RecibosMan"
        Me.SalirAlGrabar = True
        Me.Text = "Recibos de Ingresos"
        Me.Controls.SetChildIndex(Me.GridFacturas, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarFac, 0)
        Me.Controls.SetChildIndex(Me.btnQuitarFac, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.gridOtros, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarOT, 0)
        Me.Controls.SetChildIndex(Me.btnQuitarOT, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.GridPago, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarPago, 0)
        Me.Controls.SetChildIndex(Me.btnQuitarPago, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.txtFechaRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.cboEnviadoAseguradoras, 0)
        Me.Controls.SetChildIndex(Me.txtDeposito, 0)
        Me.Controls.SetChildIndex(Me.txtNumRecibo, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtTotalRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoAnulacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAnulacion, 0)
        Me.Controls.SetChildIndex(Me.txtUsuarioGrabacion, 0)
        Me.Controls.SetChildIndex(Me.txtUsuarioAnulacion, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.chkPagoDirecto, 0)
        Me.Controls.SetChildIndex(Me.chkEnviarRuteo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPagoDirecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEnviarRuteo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridFacturas As STIControles.stiGrid
    Friend WithEvents VistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQuitarFac As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarFac As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNumeroFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridOtros As STIControles.stiGrid
    Friend WithEvents VistaOtros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQuitarOT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarOT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdAseguradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalIng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridPago As STIControles.stiGrid
    Friend WithEvents VistaPago As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdTipoIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIdBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumConfirmacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaRecibo As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNumRecibo As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtTotalRecibo As STIControles.stiTextBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdReciboIng As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdReciboPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdOtroIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboEstadoRecibo As STIControles.stiComboBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboEnviadoAseguradoras As STIControles.stiComboBox
    Friend WithEvents colIdAseguradoraPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtDeposito As STIControles.stiTextBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMotivoAnulacion As STIControles.stiTextBox
    Friend WithEvents txtFechaAnulacion As STIControles.stiTextBox
    Friend WithEvents txtUsuarioGrabacion As STIControles.stiTextBox
    Friend WithEvents txtUsuarioAnulacion As STIControles.stiTextBox
    Friend WithEvents txtObservaciones As STIControles.stiTextBox
    Friend WithEvents chkPagoDirecto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEnviarRuteo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colCambio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
