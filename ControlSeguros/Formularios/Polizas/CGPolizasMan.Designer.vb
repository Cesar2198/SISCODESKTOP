<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CGPolizasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CGPolizasMan))
        Me.TabPoliza = New DevExpress.XtraTab.XtraTabControl
        Me.pagCertificados = New DevExpress.XtraTab.XtraTabPage
        Me.btnEliminarCot = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarCot = New DevExpress.XtraEditors.SimpleButton
        Me.gridCotizaciones = New STIControles.stiGrid
        Me.vistaCotizaciones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboProducto2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboFormaPago2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboFormaEnvio2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboIdAseguradora = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cboProductos = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cboFormaPago = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cboFormaEnvio = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pagDocumentos = New DevExpress.XtraTab.XtraTabPage
        Me.btnAgregarCarpeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.GridDoc = New STIControles.stiGrid
        Me.VistaDoc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColArchivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagGestion = New DevExpress.XtraTab.XtraTabPage
        Me.btnGestionOutlook = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarGestion = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGestion = New DevExpress.XtraEditors.SimpleButton
        Me.GridGestiones = New STIControles.stiGrid
        Me.VistaGestiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGesIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesTipoGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesFechaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesComentarios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesFechaProximaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboEstadoPoliza = New STIControles.stiComboBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtFechaCancelacion = New STIControles.stiTextBox
        Me.txtMotivoCancelacion = New STIControles.stiTextBox
        Me.txtFechaAceptada = New STIControles.stiTextBox
        Me.cboDepartamento = New STIControles.stiComboBox
        Me.cboNegocioPor = New STIControles.stiComboBox
        Me.cboTipoDeducible = New STIControles.stiComboBox
        Me.cboUsuarioCreacion = New STIControles.stiComboBox
        Me.cboUsuarioModificacion = New STIControles.stiComboBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.cboFechaGraba = New STIControles.stiTextBox
        Me.txtReferidoPor = New STIControles.stiTextBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.txtFechaSolicitud = New STIControles.stiTextBox
        Me.txtBienes = New STIControles.stiMemo
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPoliza.SuspendLayout()
        Me.pagCertificados.SuspendLayout()
        CType(Me.gridCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vistaCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaPago2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaEnvio2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIdAseguradora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFormaEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDocumentos.SuspendLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGestion.SuspendLayout()
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(616, 573)
        Me.btnAyuda.TabIndex = 22
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(432, 573)
        Me.btnBuscar.TabIndex = 20
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(155, 573)
        Me.btnNuevo.TabIndex = 18
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(247, 573)
        Me.btnGuardar.TabIndex = 17
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(708, 573)
        Me.btnSalir.TabIndex = 23
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(524, 573)
        Me.btnEliminar.TabIndex = 21
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(663, 74)
        Me.lblNombreFormulario.TabIndex = 29
        Me.lblNombreFormulario.Text = "Ofertas de Seguros"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(340, 573)
        Me.btnGuardarComo.TabIndex = 19
        '
        'TabPoliza
        '
        Me.TabPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPoliza.Location = New System.Drawing.Point(5, 370)
        Me.TabPoliza.Name = "TabPoliza"
        Me.TabPoliza.SelectedTabPage = Me.pagCertificados
        Me.TabPoliza.Size = New System.Drawing.Size(792, 199)
        Me.TabPoliza.TabIndex = 28
        Me.TabPoliza.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pagCertificados, Me.pagDocumentos, Me.pagGestion})
        '
        'pagCertificados
        '
        Me.pagCertificados.Controls.Add(Me.btnEliminarCot)
        Me.pagCertificados.Controls.Add(Me.btnAgregarCot)
        Me.pagCertificados.Controls.Add(Me.gridCotizaciones)
        Me.pagCertificados.Name = "pagCertificados"
        Me.pagCertificados.Size = New System.Drawing.Size(783, 168)
        Me.pagCertificados.Text = "Cotizaciones"
        '
        'btnEliminarCot
        '
        Me.btnEliminarCot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCot.Location = New System.Drawing.Point(678, 32)
        Me.btnEliminarCot.Name = "btnEliminarCot"
        Me.btnEliminarCot.Size = New System.Drawing.Size(102, 22)
        Me.btnEliminarCot.TabIndex = 2
        Me.btnEliminarCot.Text = "Quitar"
        '
        'btnAgregarCot
        '
        Me.btnAgregarCot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCot.Location = New System.Drawing.Point(678, 4)
        Me.btnAgregarCot.Name = "btnAgregarCot"
        Me.btnAgregarCot.Size = New System.Drawing.Size(102, 22)
        Me.btnAgregarCot.TabIndex = 1
        Me.btnAgregarCot.Text = "Agregar"
        '
        'gridCotizaciones
        '
        Me.gridCotizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCotizaciones.ColumnasAdicionales = ""
        Me.gridCotizaciones.Location = New System.Drawing.Point(4, 4)
        Me.gridCotizaciones.MainView = Me.vistaCotizaciones
        Me.gridCotizaciones.Name = "gridCotizaciones"
        Me.gridCotizaciones.NombreTabla = "CGPolizasOfertas"
        Me.gridCotizaciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboProductos, Me.cboFormaPago, Me.cboFormaEnvio, Me.cboProducto2, Me.cboFormaPago2, Me.cboFormaEnvio2, Me.cboIdAseguradora})
        Me.gridCotizaciones.Size = New System.Drawing.Size(668, 159)
        Me.gridCotizaciones.TabIndex = 0
        Me.gridCotizaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vistaCotizaciones})
        '
        'vistaCotizaciones
        '
        Me.vistaCotizaciones.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vistaCotizaciones.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vistaCotizaciones.ColumnPanelRowHeight = 35
        Me.vistaCotizaciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.vistaCotizaciones.GridControl = Me.gridCotizaciones
        Me.vistaCotizaciones.Name = "vistaCotizaciones"
        Me.vistaCotizaciones.OptionsBehavior.Editable = False
        Me.vistaCotizaciones.OptionsNavigation.EnterMoveNextColumn = True
        Me.vistaCotizaciones.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Oferta"
        Me.GridColumn1.FieldName = "IdOferta"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "No. Cotización"
        Me.GridColumn2.FieldName = "IdCotizacion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Producto"
        Me.GridColumn3.ColumnEdit = Me.cboProducto2
        Me.GridColumn3.FieldName = "IdProducto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'cboProducto2
        '
        Me.cboProducto2.AutoHeight = False
        Me.cboProducto2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProducto2.Name = "cboProducto2"
        Me.cboProducto2.NullText = ""
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Plan"
        Me.GridColumn4.FieldName = "PlanCotizado"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Suma Asegurada"
        Me.GridColumn5.DisplayFormat.FormatString = "c2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "SumaAsegurada"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Prima Neta"
        Me.GridColumn6.DisplayFormat.FormatString = "c2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "PrimaNeta"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Total con Iva"
        Me.GridColumn7.DisplayFormat.FormatString = "c2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Total"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "No. Cuotas"
        Me.GridColumn8.DisplayFormat.FormatString = "n0"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "NumeroCuotas"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Forma de Pago"
        Me.GridColumn9.ColumnEdit = Me.cboFormaPago2
        Me.GridColumn9.FieldName = "IdFormaPago"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'cboFormaPago2
        '
        Me.cboFormaPago2.AutoHeight = False
        Me.cboFormaPago2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaPago2.Name = "cboFormaPago2"
        Me.cboFormaPago2.NullText = ""
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Forma de Envio"
        Me.GridColumn10.ColumnEdit = Me.cboFormaEnvio2
        Me.GridColumn10.FieldName = "FormaEnvio"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        '
        'cboFormaEnvio2
        '
        Me.cboFormaEnvio2.AutoHeight = False
        Me.cboFormaEnvio2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaEnvio2.Name = "cboFormaEnvio2"
        Me.cboFormaEnvio2.NullText = ""
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "No. Carta/Envío"
        Me.GridColumn11.FieldName = "NumeroCarta"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Fecha Envío"
        Me.GridColumn12.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn12.FieldName = "FechaEnvio"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Aseguradora"
        Me.GridColumn13.ColumnEdit = Me.cboIdAseguradora
        Me.GridColumn13.FieldName = "IdAseguradora"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.AutoHeight = False
        Me.cboIdAseguradora.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NullText = ""
        '
        'cboProductos
        '
        Me.cboProductos.AutoComplete = False
        Me.cboProductos.AutoHeight = False
        Me.cboProductos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.NullText = ""
        Me.cboProductos.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cboFormaPago
        '
        Me.cboFormaPago.AutoComplete = False
        Me.cboFormaPago.AutoHeight = False
        Me.cboFormaPago.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.NullText = ""
        Me.cboFormaPago.View = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cboFormaEnvio
        '
        Me.cboFormaEnvio.AutoComplete = False
        Me.cboFormaEnvio.AutoHeight = False
        Me.cboFormaEnvio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFormaEnvio.Name = "cboFormaEnvio"
        Me.cboFormaEnvio.NullText = ""
        Me.cboFormaEnvio.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'pagDocumentos
        '
        Me.pagDocumentos.Controls.Add(Me.btnAgregarCarpeta)
        Me.pagDocumentos.Controls.Add(Me.btnQuitarDoc)
        Me.pagDocumentos.Controls.Add(Me.btnAgregarDoc)
        Me.pagDocumentos.Controls.Add(Me.GridDoc)
        Me.pagDocumentos.Name = "pagDocumentos"
        Me.pagDocumentos.Size = New System.Drawing.Size(783, 155)
        Me.pagDocumentos.Text = "Documentos"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(678, 40)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarCarpeta.TabIndex = 23
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(678, 75)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDoc.TabIndex = 22
        Me.btnQuitarDoc.Text = "Quitar"
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(678, 3)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarDoc.TabIndex = 21
        Me.btnAgregarDoc.Text = "Agregar Archivo"
        '
        'GridDoc
        '
        Me.GridDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDoc.ColumnasAdicionales = ""
        Me.GridDoc.Location = New System.Drawing.Point(3, 3)
        Me.GridDoc.MainView = Me.VistaDoc
        Me.GridDoc.Name = "GridDoc"
        Me.GridDoc.NombreTabla = "CGPolizasDocumentos"
        Me.GridDoc.Size = New System.Drawing.Size(660, 192)
        Me.GridDoc.TabIndex = 0
        Me.GridDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDoc})
        '
        'VistaDoc
        '
        Me.VistaDoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPoliza, Me.ColDoc, Me.colDocumento, Me.ColArchivo})
        Me.VistaDoc.GridControl = Me.GridDoc
        Me.VistaDoc.Name = "VistaDoc"
        Me.VistaDoc.OptionsView.ShowGroupPanel = False
        '
        'ColPoliza
        '
        Me.ColPoliza.Caption = "Oferta"
        Me.ColPoliza.FieldName = "IdOferta"
        Me.ColPoliza.Name = "ColPoliza"
        '
        'ColDoc
        '
        Me.ColDoc.Caption = "No.Doc"
        Me.ColDoc.FieldName = "IdDocumento"
        Me.ColDoc.Name = "ColDoc"
        Me.ColDoc.Visible = True
        Me.ColDoc.VisibleIndex = 0
        Me.ColDoc.Width = 57
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Documento"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Width = 210
        '
        'ColArchivo
        '
        Me.ColArchivo.Caption = "Archivo"
        Me.ColArchivo.FieldName = "Archivo"
        Me.ColArchivo.Name = "ColArchivo"
        Me.ColArchivo.Tag = "NOSAVE"
        Me.ColArchivo.Visible = True
        Me.ColArchivo.VisibleIndex = 1
        Me.ColArchivo.Width = 248
        '
        'pagGestion
        '
        Me.pagGestion.Controls.Add(Me.btnGestionOutlook)
        Me.pagGestion.Controls.Add(Me.btnQuitarGestion)
        Me.pagGestion.Controls.Add(Me.btnAgregarGestion)
        Me.pagGestion.Controls.Add(Me.GridGestiones)
        Me.pagGestion.Name = "pagGestion"
        Me.pagGestion.Size = New System.Drawing.Size(783, 155)
        Me.pagGestion.Text = "Gestiones"
        '
        'btnGestionOutlook
        '
        Me.btnGestionOutlook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestionOutlook.Appearance.Options.UseTextOptions = True
        Me.btnGestionOutlook.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGestionOutlook.Location = New System.Drawing.Point(678, 51)
        Me.btnGestionOutlook.Name = "btnGestionOutlook"
        Me.btnGestionOutlook.Size = New System.Drawing.Size(102, 34)
        Me.btnGestionOutlook.TabIndex = 11
        Me.btnGestionOutlook.Text = "A Calendario Outlook"
        '
        'btnQuitarGestion
        '
        Me.btnQuitarGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGestion.Location = New System.Drawing.Point(678, 27)
        Me.btnQuitarGestion.Name = "btnQuitarGestion"
        Me.btnQuitarGestion.Size = New System.Drawing.Size(102, 22)
        Me.btnQuitarGestion.TabIndex = 10
        Me.btnQuitarGestion.Text = "Quitar"
        '
        'btnAgregarGestion
        '
        Me.btnAgregarGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGestion.Location = New System.Drawing.Point(678, 3)
        Me.btnAgregarGestion.Name = "btnAgregarGestion"
        Me.btnAgregarGestion.Size = New System.Drawing.Size(102, 22)
        Me.btnAgregarGestion.TabIndex = 9
        Me.btnAgregarGestion.Text = "Agregar"
        '
        'GridGestiones
        '
        Me.GridGestiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGestiones.ColumnasAdicionales = ""
        Me.GridGestiones.Location = New System.Drawing.Point(3, 3)
        Me.GridGestiones.MainView = Me.VistaGestiones
        Me.GridGestiones.Name = "GridGestiones"
        Me.GridGestiones.NombreTabla = "Gestiones"
        Me.GridGestiones.Size = New System.Drawing.Size(669, 192)
        Me.GridGestiones.TabIndex = 1
        Me.GridGestiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaGestiones})
        '
        'VistaGestiones
        '
        Me.VistaGestiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGesIdPoliza, Me.colGesTipoGestion, Me.colGesIdGestion, Me.colGesFechaGestion, Me.colGesComentarios, Me.colGesIdUsuario, Me.colGesFechaProximaGestion})
        Me.VistaGestiones.GridControl = Me.GridGestiones
        Me.VistaGestiones.Name = "VistaGestiones"
        Me.VistaGestiones.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaGestiones.OptionsView.ShowGroupPanel = False
        '
        'colGesIdPoliza
        '
        Me.colGesIdPoliza.Caption = "Póliza"
        Me.colGesIdPoliza.FieldName = "IdOferta"
        Me.colGesIdPoliza.Name = "colGesIdPoliza"
        Me.colGesIdPoliza.OptionsColumn.AllowEdit = False
        '
        'colGesTipoGestion
        '
        Me.colGesTipoGestion.Caption = "Tipo Gestión"
        Me.colGesTipoGestion.FieldName = "TipoGestion"
        Me.colGesTipoGestion.Name = "colGesTipoGestion"
        Me.colGesTipoGestion.OptionsColumn.AllowEdit = False
        '
        'colGesIdGestion
        '
        Me.colGesIdGestion.Caption = "CodGestion"
        Me.colGesIdGestion.FieldName = "IdGestion"
        Me.colGesIdGestion.Name = "colGesIdGestion"
        Me.colGesIdGestion.Visible = True
        Me.colGesIdGestion.VisibleIndex = 0
        Me.colGesIdGestion.Width = 64
        '
        'colGesFechaGestion
        '
        Me.colGesFechaGestion.Caption = "Fecha Gestión"
        Me.colGesFechaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colGesFechaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGesFechaGestion.FieldName = "FechaGestion"
        Me.colGesFechaGestion.Name = "colGesFechaGestion"
        Me.colGesFechaGestion.Visible = True
        Me.colGesFechaGestion.VisibleIndex = 1
        Me.colGesFechaGestion.Width = 81
        '
        'colGesComentarios
        '
        Me.colGesComentarios.Caption = "Comentarios"
        Me.colGesComentarios.FieldName = "Comentarios"
        Me.colGesComentarios.Name = "colGesComentarios"
        Me.colGesComentarios.Visible = True
        Me.colGesComentarios.VisibleIndex = 3
        Me.colGesComentarios.Width = 352
        '
        'colGesIdUsuario
        '
        Me.colGesIdUsuario.Caption = "Usuario"
        Me.colGesIdUsuario.FieldName = "IdUsuario"
        Me.colGesIdUsuario.Name = "colGesIdUsuario"
        Me.colGesIdUsuario.OptionsColumn.AllowEdit = False
        '
        'colGesFechaProximaGestion
        '
        Me.colGesFechaProximaGestion.Caption = "Próxima Gestión"
        Me.colGesFechaProximaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colGesFechaProximaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGesFechaProximaGestion.FieldName = "FechaProximaGestion"
        Me.colGesFechaProximaGestion.Name = "colGesFechaProximaGestion"
        Me.colGesFechaProximaGestion.Visible = True
        Me.colGesFechaProximaGestion.VisibleIndex = 2
        Me.colGesFechaProximaGestion.Width = 90
        '
        'cboEstadoPoliza
        '
        Me.cboEstadoPoliza.CampoAutoCompletar = 0
        Me.cboEstadoPoliza.CampoBusqueda = False
        Me.cboEstadoPoliza.CampoDisplay = 1
        Me.cboEstadoPoliza.CampoEsLlave = False
        Me.cboEstadoPoliza.CampoValor = 0
        Me.cboEstadoPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoPoliza.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoPoliza.FilasVisibles = 0
        Me.cboEstadoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoPoliza.LabelText = "Estado Oferta"
        Me.cboEstadoPoliza.LabelWidth = 120
        Me.cboEstadoPoliza.Lista = "PENDIENTE Pendiente|ACEPTADA Aceptada|RECHAZADA Rechazada"
        Me.cboEstadoPoliza.Location = New System.Drawing.Point(411, 81)
        Me.cboEstadoPoliza.MostrarBusquedaColumnas = False
        Me.cboEstadoPoliza.Name = "cboEstadoPoliza"
        Me.cboEstadoPoliza.NombreCampo = "Estado"
        Me.cboEstadoPoliza.Obligatorio = True
        Me.cboEstadoPoliza.Query = ""
        Me.cboEstadoPoliza.SelectIndex = 0
        Me.cboEstadoPoliza.Size = New System.Drawing.Size(383, 20)
        Me.cboEstadoPoliza.SoloLectura = False
        Me.cboEstadoPoliza.StringConection = ""
        Me.cboEstadoPoliza.TabIndex = 1
        Me.cboEstadoPoliza.TextoNuevoItem = ""
        Me.cboEstadoPoliza.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoPoliza.Valor = ""
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = True
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = False
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigencia Hasta"
        Me.txtVigenciaHasta.LabelWidth = 120
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(411, 153)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(383, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 6
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = True
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = True
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 120
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(8, 153)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(397, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 5
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(411, 100)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 2
        Me.btnBuscarCliente.Text = "Buscar Cliente"
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
        Me.txtNombreCliente.LabelWidth = 120
        Me.txtNombreCliente.Location = New System.Drawing.Point(8, 129)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(397, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 3
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
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 120
        Me.txtIdCliente.Location = New System.Drawing.Point(8, 105)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(397, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 24
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
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
        Me.txtIdPoliza.LabelText = "Número Oferta"
        Me.txtIdPoliza.LabelWidth = 120
        Me.txtIdPoliza.Location = New System.Drawing.Point(8, 81)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdOferta"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(397, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 0
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtFechaCancelacion
        '
        Me.txtFechaCancelacion.CampoBusqueda = False
        Me.txtFechaCancelacion.CampoEsLlave = False
        Me.txtFechaCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCancelacion.FechaActual = False
        Me.txtFechaCancelacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCancelacion.LabelText = "Fecha Rechazo"
        Me.txtFechaCancelacion.LabelWidth = 120
        Me.txtFechaCancelacion.Location = New System.Drawing.Point(411, 200)
        Me.txtFechaCancelacion.MaxLength = 0
        Me.txtFechaCancelacion.Name = "txtFechaCancelacion"
        Me.txtFechaCancelacion.NombreCampo = "FechaRechazo"
        Me.txtFechaCancelacion.Obligatorio = False
        Me.txtFechaCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCancelacion.Size = New System.Drawing.Size(383, 20)
        Me.txtFechaCancelacion.SoloLectura = False
        Me.txtFechaCancelacion.TabIndex = 9
        Me.txtFechaCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCancelacion.Valor = Nothing
        '
        'txtMotivoCancelacion
        '
        Me.txtMotivoCancelacion.CampoBusqueda = False
        Me.txtMotivoCancelacion.CampoEsLlave = False
        Me.txtMotivoCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivoCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoCancelacion.FechaActual = False
        Me.txtMotivoCancelacion.Formato = ""
        Me.txtMotivoCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMotivoCancelacion.LabelText = "Motivo Rechazo"
        Me.txtMotivoCancelacion.LabelWidth = 120
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(8, 200)
        Me.txtMotivoCancelacion.MaxLength = 250
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.NombreCampo = "MotivoRechazo"
        Me.txtMotivoCancelacion.Obligatorio = False
        Me.txtMotivoCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(397, 20)
        Me.txtMotivoCancelacion.SoloLectura = False
        Me.txtMotivoCancelacion.TabIndex = 8
        Me.txtMotivoCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoCancelacion.Valor = ""
        '
        'txtFechaAceptada
        '
        Me.txtFechaAceptada.CampoBusqueda = False
        Me.txtFechaAceptada.CampoEsLlave = False
        Me.txtFechaAceptada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAceptada.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAceptada.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAceptada.FechaActual = False
        Me.txtFechaAceptada.Formato = "dd/MMM/yyyy"
        Me.txtFechaAceptada.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAceptada.LabelText = "Fecha de Aceptación"
        Me.txtFechaAceptada.LabelWidth = 120
        Me.txtFechaAceptada.Location = New System.Drawing.Point(410, 224)
        Me.txtFechaAceptada.MaxLength = 0
        Me.txtFechaAceptada.Name = "txtFechaAceptada"
        Me.txtFechaAceptada.NombreCampo = "FechaAcepta"
        Me.txtFechaAceptada.Obligatorio = False
        Me.txtFechaAceptada.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAceptada.Size = New System.Drawing.Size(383, 20)
        Me.txtFechaAceptada.SoloLectura = False
        Me.txtFechaAceptada.TabIndex = 11
        Me.txtFechaAceptada.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAceptada.Valor = Nothing
        '
        'cboDepartamento
        '
        Me.cboDepartamento.CampoAutoCompletar = 0
        Me.cboDepartamento.CampoBusqueda = False
        Me.cboDepartamento.CampoDisplay = 1
        Me.cboDepartamento.CampoEsLlave = False
        Me.cboDepartamento.CampoValor = 0
        Me.cboDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDepartamento.ControlBackColor = System.Drawing.Color.White
        Me.cboDepartamento.ControlForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.FilasVisibles = 0
        Me.cboDepartamento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDepartamento.LabelText = "Departamento"
        Me.cboDepartamento.LabelWidth = 120
        Me.cboDepartamento.Lista = ""
        Me.cboDepartamento.Location = New System.Drawing.Point(411, 248)
        Me.cboDepartamento.MostrarBusquedaColumnas = False
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.NombreCampo = "Departamento"
        Me.cboDepartamento.Obligatorio = False
        Me.cboDepartamento.Query = "select distinct Departamento as Id, Departamento from usuarios"
        Me.cboDepartamento.SelectIndex = 0
        Me.cboDepartamento.Size = New System.Drawing.Size(383, 20)
        Me.cboDepartamento.SoloLectura = False
        Me.cboDepartamento.StringConection = ""
        Me.cboDepartamento.TabIndex = 13
        Me.cboDepartamento.TextoNuevoItem = ""
        Me.cboDepartamento.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboDepartamento.Valor = ""
        '
        'cboNegocioPor
        '
        Me.cboNegocioPor.CampoAutoCompletar = 0
        Me.cboNegocioPor.CampoBusqueda = False
        Me.cboNegocioPor.CampoDisplay = 1
        Me.cboNegocioPor.CampoEsLlave = False
        Me.cboNegocioPor.CampoValor = 0
        Me.cboNegocioPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNegocioPor.ControlBackColor = System.Drawing.Color.White
        Me.cboNegocioPor.ControlForeColor = System.Drawing.Color.Black
        Me.cboNegocioPor.FilasVisibles = 0
        Me.cboNegocioPor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboNegocioPor.LabelText = "Negocio Hecho Por"
        Me.cboNegocioPor.LabelWidth = 120
        Me.cboNegocioPor.Lista = ""
        Me.cboNegocioPor.Location = New System.Drawing.Point(8, 248)
        Me.cboNegocioPor.MostrarBusquedaColumnas = False
        Me.cboNegocioPor.Name = "cboNegocioPor"
        Me.cboNegocioPor.NombreCampo = "NegocioPor"
        Me.cboNegocioPor.Obligatorio = False
        Me.cboNegocioPor.Query = "select idVendedor as Id, NombreVendedor as Vendedor from vendedores where idestad" & _
            "o  = 'A'"
        Me.cboNegocioPor.SelectIndex = 0
        Me.cboNegocioPor.Size = New System.Drawing.Size(398, 20)
        Me.cboNegocioPor.SoloLectura = False
        Me.cboNegocioPor.StringConection = ""
        Me.cboNegocioPor.TabIndex = 12
        Me.cboNegocioPor.TextoNuevoItem = ""
        Me.cboNegocioPor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNegocioPor.Valor = ""
        '
        'cboTipoDeducible
        '
        Me.cboTipoDeducible.CampoAutoCompletar = 0
        Me.cboTipoDeducible.CampoBusqueda = False
        Me.cboTipoDeducible.CampoDisplay = 1
        Me.cboTipoDeducible.CampoEsLlave = False
        Me.cboTipoDeducible.CampoValor = 0
        Me.cboTipoDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoDeducible.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoDeducible.FilasVisibles = 0
        Me.cboTipoDeducible.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoDeducible.LabelText = "Tipo Deducible"
        Me.cboTipoDeducible.LabelWidth = 120
        Me.cboTipoDeducible.Lista = "V Deducible por Vigencia|A Deducible Año Calendario"
        Me.cboTipoDeducible.Location = New System.Drawing.Point(8, 224)
        Me.cboTipoDeducible.MostrarBusquedaColumnas = False
        Me.cboTipoDeducible.Name = "cboTipoDeducible"
        Me.cboTipoDeducible.NombreCampo = "TipoDeducible"
        Me.cboTipoDeducible.Obligatorio = False
        Me.cboTipoDeducible.Query = ""
        Me.cboTipoDeducible.SelectIndex = 0
        Me.cboTipoDeducible.Size = New System.Drawing.Size(398, 20)
        Me.cboTipoDeducible.SoloLectura = False
        Me.cboTipoDeducible.StringConection = ""
        Me.cboTipoDeducible.TabIndex = 10
        Me.cboTipoDeducible.TextoNuevoItem = ""
        Me.cboTipoDeducible.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoDeducible.Valor = ""
        '
        'cboUsuarioCreacion
        '
        Me.cboUsuarioCreacion.CampoAutoCompletar = 0
        Me.cboUsuarioCreacion.CampoBusqueda = False
        Me.cboUsuarioCreacion.CampoDisplay = 1
        Me.cboUsuarioCreacion.CampoEsLlave = False
        Me.cboUsuarioCreacion.CampoValor = 0
        Me.cboUsuarioCreacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUsuarioCreacion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboUsuarioCreacion.ControlForeColor = System.Drawing.Color.Black
        Me.cboUsuarioCreacion.FilasVisibles = 0
        Me.cboUsuarioCreacion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboUsuarioCreacion.LabelText = "Usuario Creación"
        Me.cboUsuarioCreacion.LabelWidth = 120
        Me.cboUsuarioCreacion.Lista = ""
        Me.cboUsuarioCreacion.Location = New System.Drawing.Point(8, 272)
        Me.cboUsuarioCreacion.MostrarBusquedaColumnas = False
        Me.cboUsuarioCreacion.Name = "cboUsuarioCreacion"
        Me.cboUsuarioCreacion.NombreCampo = "UsuarioGrabacion"
        Me.cboUsuarioCreacion.Obligatorio = False
        Me.cboUsuarioCreacion.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios"
        Me.cboUsuarioCreacion.SelectIndex = 0
        Me.cboUsuarioCreacion.Size = New System.Drawing.Size(398, 20)
        Me.cboUsuarioCreacion.SoloLectura = True
        Me.cboUsuarioCreacion.StringConection = ""
        Me.cboUsuarioCreacion.TabIndex = 26
        Me.cboUsuarioCreacion.TextoNuevoItem = ""
        Me.cboUsuarioCreacion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboUsuarioCreacion.Valor = ""
        '
        'cboUsuarioModificacion
        '
        Me.cboUsuarioModificacion.CampoAutoCompletar = 0
        Me.cboUsuarioModificacion.CampoBusqueda = False
        Me.cboUsuarioModificacion.CampoDisplay = 1
        Me.cboUsuarioModificacion.CampoEsLlave = False
        Me.cboUsuarioModificacion.CampoValor = 0
        Me.cboUsuarioModificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUsuarioModificacion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboUsuarioModificacion.ControlForeColor = System.Drawing.Color.Black
        Me.cboUsuarioModificacion.FilasVisibles = 0
        Me.cboUsuarioModificacion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboUsuarioModificacion.LabelText = "Usuario Modificacion"
        Me.cboUsuarioModificacion.LabelWidth = 120
        Me.cboUsuarioModificacion.Lista = ""
        Me.cboUsuarioModificacion.Location = New System.Drawing.Point(410, 272)
        Me.cboUsuarioModificacion.MostrarBusquedaColumnas = False
        Me.cboUsuarioModificacion.Name = "cboUsuarioModificacion"
        Me.cboUsuarioModificacion.NombreCampo = "UsuarioModificacion"
        Me.cboUsuarioModificacion.Obligatorio = False
        Me.cboUsuarioModificacion.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios"
        Me.cboUsuarioModificacion.SelectIndex = 0
        Me.cboUsuarioModificacion.Size = New System.Drawing.Size(384, 20)
        Me.cboUsuarioModificacion.SoloLectura = True
        Me.cboUsuarioModificacion.StringConection = ""
        Me.cboUsuarioModificacion.TabIndex = 27
        Me.cboUsuarioModificacion.TextoNuevoItem = ""
        Me.cboUsuarioModificacion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboUsuarioModificacion.Valor = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cboFechaGraba
        '
        Me.cboFechaGraba.CampoBusqueda = False
        Me.cboFechaGraba.CampoEsLlave = False
        Me.cboFechaGraba.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFechaGraba.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboFechaGraba.ControlForeColor = System.Drawing.Color.Black
        Me.cboFechaGraba.FechaActual = False
        Me.cboFechaGraba.Formato = "dd/MMM/yyyy hh:mm:ss"
        Me.cboFechaGraba.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.cboFechaGraba.LabelText = "Fecha Graba"
        Me.cboFechaGraba.LabelWidth = 70
        Me.cboFechaGraba.Location = New System.Drawing.Point(530, 107)
        Me.cboFechaGraba.MaxLength = 0
        Me.cboFechaGraba.Name = "cboFechaGraba"
        Me.cboFechaGraba.NombreCampo = "FechaGraba"
        Me.cboFechaGraba.Obligatorio = False
        Me.cboFechaGraba.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cboFechaGraba.Size = New System.Drawing.Size(263, 20)
        Me.cboFechaGraba.SoloLectura = True
        Me.cboFechaGraba.TabIndex = 25
        Me.cboFechaGraba.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.cboFechaGraba.Valor = Nothing
        '
        'txtReferidoPor
        '
        Me.txtReferidoPor.CampoBusqueda = False
        Me.txtReferidoPor.CampoEsLlave = False
        Me.txtReferidoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtReferidoPor.ControlBackColor = System.Drawing.Color.White
        Me.txtReferidoPor.ControlForeColor = System.Drawing.Color.Black
        Me.txtReferidoPor.FechaActual = False
        Me.txtReferidoPor.Formato = ""
        Me.txtReferidoPor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtReferidoPor.LabelText = "Referido Por"
        Me.txtReferidoPor.LabelWidth = 120
        Me.txtReferidoPor.Location = New System.Drawing.Point(8, 296)
        Me.txtReferidoPor.MaxLength = 150
        Me.txtReferidoPor.Name = "txtReferidoPor"
        Me.txtReferidoPor.NombreCampo = "ReferidoPor"
        Me.txtReferidoPor.Obligatorio = False
        Me.txtReferidoPor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReferidoPor.Size = New System.Drawing.Size(397, 20)
        Me.txtReferidoPor.SoloLectura = False
        Me.txtReferidoPor.TabIndex = 14
        Me.txtReferidoPor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtReferidoPor.Valor = ""
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
        Me.cboEjecutivoCta.FilasVisibles = 0
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo de Cuenta"
        Me.cboEjecutivoCta.LabelWidth = 120
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(410, 298)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios  where esejecutivo " & _
            "= 'S' and isnull(Estado,'') <> 'I'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(384, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 15
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'cboIdRamo
        '
        Me.cboIdRamo.CampoAutoCompletar = 0
        Me.cboIdRamo.CampoBusqueda = False
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = False
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 0
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdRamo.LabelText = "Ramo"
        Me.cboIdRamo.LabelWidth = 120
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(8, 176)
        Me.cboIdRamo.MostrarBusquedaColumnas = False
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdRamo"
        Me.cboIdRamo.Obligatorio = True
        Me.cboIdRamo.Query = "select IdRamo as Id, NombreRamo as Ramo from RamoSeguros"
        Me.cboIdRamo.SelectIndex = 0
        Me.cboIdRamo.Size = New System.Drawing.Size(398, 20)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 7
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.CampoBusqueda = True
        Me.txtFechaSolicitud.CampoEsLlave = False
        Me.txtFechaSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaSolicitud.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaSolicitud.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaSolicitud.FechaActual = False
        Me.txtFechaSolicitud.Formato = "dd/MMM/yyyy"
        Me.txtFechaSolicitud.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaSolicitud.LabelText = "Fec. Solicitud Cliente"
        Me.txtFechaSolicitud.LabelWidth = 120
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(411, 129)
        Me.txtFechaSolicitud.MaxLength = 0
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.NombreCampo = "FechaSolicitud"
        Me.txtFechaSolicitud.Obligatorio = True
        Me.txtFechaSolicitud.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(383, 20)
        Me.txtFechaSolicitud.SoloLectura = False
        Me.txtFechaSolicitud.TabIndex = 4
        Me.txtFechaSolicitud.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaSolicitud.Valor = Nothing
        '
        'txtBienes
        '
        Me.txtBienes.CampoBusqueda = False
        Me.txtBienes.CampoEsLlave = False
        Me.txtBienes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBienes.ControlBackColor = System.Drawing.Color.White
        Me.txtBienes.ControlForeColor = System.Drawing.Color.Black
        Me.txtBienes.FechaActual = False
        Me.txtBienes.Formato = ""
        Me.txtBienes.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtBienes.LabelText = "Descripción de bien a asegurar"
        Me.txtBienes.LabelWidth = 120
        Me.txtBienes.Location = New System.Drawing.Point(8, 322)
        Me.txtBienes.MaxLength = 0
        Me.txtBienes.Name = "txtBienes"
        Me.txtBienes.NombreCampo = "Bienes"
        Me.txtBienes.Obligatorio = False
        Me.txtBienes.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBienes.Size = New System.Drawing.Size(786, 42)
        Me.txtBienes.SoloLectura = False
        Me.txtBienes.TabIndex = 16
        Me.txtBienes.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtBienes.Valor = ""
        '
        'CGPolizasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(802, 609)
        Me.Controls.Add(Me.txtBienes)
        Me.Controls.Add(Me.txtFechaSolicitud)
        Me.Controls.Add(Me.cboIdRamo)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.txtReferidoPor)
        Me.Controls.Add(Me.cboFechaGraba)
        Me.Controls.Add(Me.cboUsuarioModificacion)
        Me.Controls.Add(Me.cboUsuarioCreacion)
        Me.Controls.Add(Me.cboNegocioPor)
        Me.Controls.Add(Me.cboTipoDeducible)
        Me.Controls.Add(Me.txtFechaAceptada)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.txtFechaCancelacion)
        Me.Controls.Add(Me.txtMotivoCancelacion)
        Me.Controls.Add(Me.cboEstadoPoliza)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.TabPoliza)
        Me.Name = "CGPolizasMan"
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Ofertas de Seguros"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.TabPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoCancelacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCancelacion, 0)
        Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAceptada, 0)
        Me.Controls.SetChildIndex(Me.cboTipoDeducible, 0)
        Me.Controls.SetChildIndex(Me.cboNegocioPor, 0)
        Me.Controls.SetChildIndex(Me.cboUsuarioCreacion, 0)
        Me.Controls.SetChildIndex(Me.cboUsuarioModificacion, 0)
        Me.Controls.SetChildIndex(Me.cboFechaGraba, 0)
        Me.Controls.SetChildIndex(Me.txtReferidoPor, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.cboIdRamo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaSolicitud, 0)
        Me.Controls.SetChildIndex(Me.txtBienes, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPoliza.ResumeLayout(False)
        Me.pagCertificados.ResumeLayout(False)
        CType(Me.gridCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vistaCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaPago2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaEnvio2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIdAseguradora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFormaEnvio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDocumentos.ResumeLayout(False)
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGestion.ResumeLayout(False)
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPoliza As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pagCertificados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pagDocumentos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAgregarCarpeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDoc As STIControles.stiGrid
    Friend WithEvents VistaDoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColArchivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pagGestion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnGestionOutlook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarGestion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGestion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridGestiones As STIControles.stiGrid
    Friend WithEvents VistaGestiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGesIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesTipoGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesFechaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesFechaProximaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboEstadoPoliza As STIControles.stiComboBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtFechaCancelacion As STIControles.stiTextBox
    Friend WithEvents txtMotivoCancelacion As STIControles.stiTextBox
    Friend WithEvents txtFechaAceptada As STIControles.stiTextBox
    Friend WithEvents cboDepartamento As STIControles.stiComboBox
    Friend WithEvents cboNegocioPor As STIControles.stiComboBox
    Friend WithEvents cboTipoDeducible As STIControles.stiComboBox
    Friend WithEvents cboUsuarioCreacion As STIControles.stiComboBox
    Friend WithEvents cboUsuarioModificacion As STIControles.stiComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cboFechaGraba As STIControles.stiTextBox
    Friend WithEvents btnEliminarCot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarCot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridCotizaciones As STIControles.stiGrid
    Friend WithEvents vistaCotizaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents cboProductos As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboFormaPago As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboFormaEnvio As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboProducto2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboFormaPago2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboFormaEnvio2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtReferidoPor As STIControles.stiTextBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboIdAseguradora As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents txtFechaSolicitud As STIControles.stiTextBox
    Friend WithEvents txtBienes As STIControles.stiMemo

End Class
