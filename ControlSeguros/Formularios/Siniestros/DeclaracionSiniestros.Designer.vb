<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeclaracionSiniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeclaracionSiniestros))
        Me.txtDescripcionSiniestro = New STIControles.stiTextBox
        Me.btnQuitarGastos = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGasto = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetalle = New STIControles.stiGrid
        Me.VistaDetalles = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDetIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetDescripcionGastos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDetValorPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetValorNoCubierto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetValorCubierto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtFechaPresentado = New STIControles.stiTextBox
        Me.txtFechaOcurrido = New STIControles.stiTextBox
        Me.txtNombreContratante = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtAsegurado = New STIControles.stiTextBox
        Me.txtBeneficiario = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdBien = New STIControles.stiTextBox
        Me.txtIdSiniestroAseguradora = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtTotalDeudores = New STIControles.stiTextBox
        Me.txtTotalCoaseguro = New STIControles.stiTextBox
        Me.txtTotalDeducible = New STIControles.stiTextBox
        Me.txtLimiteDeducible = New STIControles.stiTextBox
        Me.txtLimiteCoaseguro = New STIControles.stiTextBox
        Me.txtAcumuladoCoaseguro = New STIControles.stiTextBox
        Me.txtAcumuladoDeducible = New STIControles.stiTextBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.cboFlujo = New STIControles.stiGridComboBox
        Me.cboAmbitoSiniestro = New STIControles.stiComboBox
        Me.txtAcumuladoDeducibleMundial = New STIControles.stiTextBox
        Me.txtAcumuladoDeducibleDental = New STIControles.stiTextBox
        Me.txtNoFolioReferencia = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(462, 503)
        Me.btnAyuda.TabIndex = 14
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(23, 519)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(183, 503)
        Me.btnNuevo.TabIndex = 12
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(275, 503)
        Me.btnGuardar.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(554, 503)
        Me.btnSalir.TabIndex = 15
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(370, 503)
        Me.btnEliminar.TabIndex = 13
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(511, 74)
        Me.lblNombreFormulario.TabIndex = 21
        Me.lblNombreFormulario.Text = "Declaración de Reclamos de Seguros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(10, 519)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 22
        Me.btnGuardarComo.Visible = False
        '
        'txtDescripcionSiniestro
        '
        Me.txtDescripcionSiniestro.CampoBusqueda = False
        Me.txtDescripcionSiniestro.CampoEsLlave = False
        Me.txtDescripcionSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionSiniestro.FechaActual = False
        Me.txtDescripcionSiniestro.Formato = ""
        Me.txtDescripcionSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionSiniestro.LabelText = "Descripción Siniestro"
        Me.txtDescripcionSiniestro.LabelWidth = 110
        Me.txtDescripcionSiniestro.Location = New System.Drawing.Point(11, 258)
        Me.txtDescripcionSiniestro.MaxLength = 0
        Me.txtDescripcionSiniestro.Name = "txtDescripcionSiniestro"
        Me.txtDescripcionSiniestro.NombreCampo = "DescripcionSiniestro"
        Me.txtDescripcionSiniestro.Obligatorio = False
        Me.txtDescripcionSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionSiniestro.Size = New System.Drawing.Size(504, 20)
        Me.txtDescripcionSiniestro.SoloLectura = False
        Me.txtDescripcionSiniestro.TabIndex = 4
        Me.txtDescripcionSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionSiniestro.Valor = ""
        '
        'btnQuitarGastos
        '
        Me.btnQuitarGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGastos.Location = New System.Drawing.Point(528, 417)
        Me.btnQuitarGastos.Name = "btnQuitarGastos"
        Me.btnQuitarGastos.Size = New System.Drawing.Size(112, 29)
        Me.btnQuitarGastos.TabIndex = 12
        Me.btnQuitarGastos.Text = "&Quitar"
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGasto.Location = New System.Drawing.Point(529, 382)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(112, 29)
        Me.btnAgregarGasto.TabIndex = 9
        Me.btnAgregarGasto.Text = "Ag&regar"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.ColumnasAdicionales = ""
        Me.GridDetalle.Location = New System.Drawing.Point(11, 382)
        Me.GridDetalle.MainView = Me.VistaDetalles
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.NombreTabla = "SiniestrosDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemLookUpEdit1})
        Me.GridDetalle.Size = New System.Drawing.Size(507, 114)
        Me.GridDetalle.TabIndex = 11
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDetalles})
        '
        'VistaDetalles
        '
        Me.VistaDetalles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetIdPoliza, Me.colDetIdProducto, Me.colDetIdCertificado, Me.colDetIdSiniestro, Me.colDetIdDetalle, Me.colDetDescripcionGastos, Me.colDetValorPresentado, Me.colDetValorNoCubierto, Me.colDetValorCubierto, Me.GridColumn1})
        Me.VistaDetalles.GridControl = Me.GridDetalle
        Me.VistaDetalles.Name = "VistaDetalles"
        Me.VistaDetalles.OptionsBehavior.FocusLeaveOnTab = True
        Me.VistaDetalles.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaDetalles.OptionsView.ShowFooter = True
        Me.VistaDetalles.OptionsView.ShowGroupPanel = False
        '
        'colDetIdPoliza
        '
        Me.colDetIdPoliza.Caption = "Poliza"
        Me.colDetIdPoliza.FieldName = "IdPoliza"
        Me.colDetIdPoliza.Name = "colDetIdPoliza"
        '
        'colDetIdProducto
        '
        Me.colDetIdProducto.Caption = "Producto"
        Me.colDetIdProducto.FieldName = "IdProducto"
        Me.colDetIdProducto.Name = "colDetIdProducto"
        '
        'colDetIdCertificado
        '
        Me.colDetIdCertificado.Caption = "Certificado"
        Me.colDetIdCertificado.FieldName = "IdCertificado"
        Me.colDetIdCertificado.Name = "colDetIdCertificado"
        '
        'colDetIdSiniestro
        '
        Me.colDetIdSiniestro.Caption = "Siniestro"
        Me.colDetIdSiniestro.FieldName = "IdSiniestro"
        Me.colDetIdSiniestro.Name = "colDetIdSiniestro"
        '
        'colDetIdDetalle
        '
        Me.colDetIdDetalle.Caption = "Orden"
        Me.colDetIdDetalle.FieldName = "IdDetalle"
        Me.colDetIdDetalle.Name = "colDetIdDetalle"
        Me.colDetIdDetalle.Visible = True
        Me.colDetIdDetalle.VisibleIndex = 0
        Me.colDetIdDetalle.Width = 62
        '
        'colDetDescripcionGastos
        '
        Me.colDetDescripcionGastos.Caption = "Descripción Gastos"
        Me.colDetDescripcionGastos.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colDetDescripcionGastos.FieldName = "IdGasto"
        Me.colDetDescripcionGastos.Name = "colDetDescripcionGastos"
        Me.colDetDescripcionGastos.Visible = True
        Me.colDetDescripcionGastos.VisibleIndex = 2
        Me.colDetDescripcionGastos.Width = 199
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colDetValorPresentado
        '
        Me.colDetValorPresentado.Caption = "Valor Presentado"
        Me.colDetValorPresentado.DisplayFormat.FormatString = "c"
        Me.colDetValorPresentado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDetValorPresentado.FieldName = "ValorPresentado"
        Me.colDetValorPresentado.Name = "colDetValorPresentado"
        Me.colDetValorPresentado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDetValorPresentado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDetValorPresentado.Visible = True
        Me.colDetValorPresentado.VisibleIndex = 3
        Me.colDetValorPresentado.Width = 129
        '
        'colDetValorNoCubierto
        '
        Me.colDetValorNoCubierto.Caption = "No Cubierto"
        Me.colDetValorNoCubierto.FieldName = "ValorNoCubierto"
        Me.colDetValorNoCubierto.Name = "colDetValorNoCubierto"
        '
        'colDetValorCubierto
        '
        Me.colDetValorCubierto.Caption = "Cubierto"
        Me.colDetValorCubierto.FieldName = "ValorCubierto"
        Me.colDetValorCubierto.Name = "colDetValorCubierto"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Núm. Factura/Doc."
        Me.GridColumn1.FieldName = "NumDocumento"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 94
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'txtFechaPresentado
        '
        Me.txtFechaPresentado.CampoBusqueda = True
        Me.txtFechaPresentado.CampoEsLlave = False
        Me.txtFechaPresentado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPresentado.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaPresentado.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPresentado.FechaActual = False
        Me.txtFechaPresentado.Formato = "dd/MMM/yyyy"
        Me.txtFechaPresentado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPresentado.LabelText = "Fecha Presentado"
        Me.txtFechaPresentado.LabelWidth = 110
        Me.txtFechaPresentado.Location = New System.Drawing.Point(266, 236)
        Me.txtFechaPresentado.MaxLength = 0
        Me.txtFechaPresentado.Name = "txtFechaPresentado"
        Me.txtFechaPresentado.NombreCampo = "FechaPresentado"
        Me.txtFechaPresentado.Obligatorio = True
        Me.txtFechaPresentado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPresentado.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaPresentado.SoloLectura = False
        Me.txtFechaPresentado.TabIndex = 3
        Me.txtFechaPresentado.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPresentado.Valor = Nothing
        '
        'txtFechaOcurrido
        '
        Me.txtFechaOcurrido.CampoBusqueda = True
        Me.txtFechaOcurrido.CampoEsLlave = False
        Me.txtFechaOcurrido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaOcurrido.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaOcurrido.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaOcurrido.FechaActual = False
        Me.txtFechaOcurrido.Formato = "dd/MMM/yyyy"
        Me.txtFechaOcurrido.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaOcurrido.LabelText = "Fecha Ocurrido"
        Me.txtFechaOcurrido.LabelWidth = 110
        Me.txtFechaOcurrido.Location = New System.Drawing.Point(11, 236)
        Me.txtFechaOcurrido.MaxLength = 0
        Me.txtFechaOcurrido.Name = "txtFechaOcurrido"
        Me.txtFechaOcurrido.NombreCampo = "FechaOcurrido"
        Me.txtFechaOcurrido.Obligatorio = True
        Me.txtFechaOcurrido.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaOcurrido.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaOcurrido.SoloLectura = False
        Me.txtFechaOcurrido.TabIndex = 2
        Me.txtFechaOcurrido.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaOcurrido.Valor = Nothing
        '
        'txtNombreContratante
        '
        Me.txtNombreContratante.CampoBusqueda = True
        Me.txtNombreContratante.CampoEsLlave = False
        Me.txtNombreContratante.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreContratante.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreContratante.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreContratante.FechaActual = False
        Me.txtNombreContratante.Formato = ""
        Me.txtNombreContratante.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreContratante.LabelText = "Contratante"
        Me.txtNombreContratante.LabelWidth = 110
        Me.txtNombreContratante.Location = New System.Drawing.Point(11, 147)
        Me.txtNombreContratante.MaxLength = 500
        Me.txtNombreContratante.Name = "txtNombreContratante"
        Me.txtNombreContratante.NombreCampo = ""
        Me.txtNombreContratante.Obligatorio = True
        Me.txtNombreContratante.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreContratante.Size = New System.Drawing.Size(504, 20)
        Me.txtNombreContratante.SoloLectura = False
        Me.txtNombreContratante.TabIndex = 21
        Me.txtNombreContratante.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreContratante.Valor = ""
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
        Me.cboIdProducto.FilasVisibles = 189
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 110
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(11, 103)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(504, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 17
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = True
        Me.txtIdSiniestro.CampoEsLlave = True
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Núm. Reclamo"
        Me.txtIdSiniestro.LabelWidth = 110
        Me.txtIdSiniestro.Location = New System.Drawing.Point(11, 81)
        Me.txtIdSiniestro.MaxLength = 25
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = "IdSiniestro"
        Me.txtIdSiniestro.Obligatorio = True
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(249, 20)
        Me.txtIdSiniestro.SoloLectura = False
        Me.txtIdSiniestro.TabIndex = 15
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = True
        Me.txtIdCertificado.CampoEsLlave = True
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 75
        Me.txtIdCertificado.Location = New System.Drawing.Point(266, 125)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(175, 20)
        Me.txtIdCertificado.SoloLectura = False
        Me.txtIdCertificado.TabIndex = 19
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 110
        Me.txtIdPoliza.Location = New System.Drawing.Point(11, 125)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(249, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 18
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtAsegurado
        '
        Me.txtAsegurado.CampoBusqueda = True
        Me.txtAsegurado.CampoEsLlave = False
        Me.txtAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAsegurado.ControlBackColor = System.Drawing.Color.White
        Me.txtAsegurado.ControlForeColor = System.Drawing.Color.Black
        Me.txtAsegurado.FechaActual = False
        Me.txtAsegurado.Formato = ""
        Me.txtAsegurado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAsegurado.LabelText = "Asegurado"
        Me.txtAsegurado.LabelWidth = 110
        Me.txtAsegurado.Location = New System.Drawing.Point(11, 169)
        Me.txtAsegurado.MaxLength = 500
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.NombreCampo = ""
        Me.txtAsegurado.Obligatorio = True
        Me.txtAsegurado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAsegurado.Size = New System.Drawing.Size(504, 20)
        Me.txtAsegurado.SoloLectura = False
        Me.txtAsegurado.TabIndex = 22
        Me.txtAsegurado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtAsegurado.Valor = ""
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.CampoBusqueda = True
        Me.txtBeneficiario.CampoEsLlave = False
        Me.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBeneficiario.ControlBackColor = System.Drawing.Color.White
        Me.txtBeneficiario.ControlForeColor = System.Drawing.Color.Black
        Me.txtBeneficiario.FechaActual = False
        Me.txtBeneficiario.Formato = ""
        Me.txtBeneficiario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtBeneficiario.LabelText = "Beneficiario / Dep."
        Me.txtBeneficiario.LabelWidth = 110
        Me.txtBeneficiario.Location = New System.Drawing.Point(11, 214)
        Me.txtBeneficiario.MaxLength = 500
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.NombreCampo = "NombrePresentaReclamo"
        Me.txtBeneficiario.Obligatorio = True
        Me.txtBeneficiario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBeneficiario.Size = New System.Drawing.Size(504, 20)
        Me.txtBeneficiario.SoloLectura = False
        Me.txtBeneficiario.TabIndex = 1
        Me.txtBeneficiario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtBeneficiario.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Appearance.Options.UseTextOptions = True
        Me.btnBuscarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(527, 81)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(114, 42)
        Me.btnBuscarCliente.TabIndex = 0
        Me.btnBuscarCliente.Text = "&Buscar Pólizas / Asegurados"
        '
        'txtIdBien
        '
        Me.txtIdBien.CampoBusqueda = True
        Me.txtIdBien.CampoEsLlave = False
        Me.txtIdBien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdBien.ControlBackColor = System.Drawing.Color.White
        Me.txtIdBien.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdBien.FechaActual = False
        Me.txtIdBien.Formato = "###0"
        Me.txtIdBien.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdBien.LabelText = "Bien"
        Me.txtIdBien.LabelWidth = 30
        Me.txtIdBien.Location = New System.Drawing.Point(447, 125)
        Me.txtIdBien.MaxLength = 25
        Me.txtIdBien.Name = "txtIdBien"
        Me.txtIdBien.NombreCampo = "IdBien"
        Me.txtIdBien.Obligatorio = True
        Me.txtIdBien.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdBien.Size = New System.Drawing.Size(68, 20)
        Me.txtIdBien.SoloLectura = False
        Me.txtIdBien.TabIndex = 20
        Me.txtIdBien.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdBien.Valor = 0
        '
        'txtIdSiniestroAseguradora
        '
        Me.txtIdSiniestroAseguradora.CampoBusqueda = True
        Me.txtIdSiniestroAseguradora.CampoEsLlave = False
        Me.txtIdSiniestroAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestroAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.txtIdSiniestroAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestroAseguradora.FechaActual = False
        Me.txtIdSiniestroAseguradora.Formato = ""
        Me.txtIdSiniestroAseguradora.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestroAseguradora.LabelText = "Reclamo Aseguradora"
        Me.txtIdSiniestroAseguradora.LabelWidth = 110
        Me.txtIdSiniestroAseguradora.Location = New System.Drawing.Point(266, 81)
        Me.txtIdSiniestroAseguradora.MaxLength = 25
        Me.txtIdSiniestroAseguradora.Name = "txtIdSiniestroAseguradora"
        Me.txtIdSiniestroAseguradora.NombreCampo = "IdSiniestroAseguradora"
        Me.txtIdSiniestroAseguradora.Obligatorio = False
        Me.txtIdSiniestroAseguradora.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestroAseguradora.Size = New System.Drawing.Size(249, 20)
        Me.txtIdSiniestroAseguradora.SoloLectura = False
        Me.txtIdSiniestroAseguradora.TabIndex = 16
        Me.txtIdSiniestroAseguradora.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestroAseguradora.Valor = ""
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
        Me.txtVigenciaHasta.LabelWidth = 110
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(267, 192)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(249, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 24
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
        Me.txtVigenciaDesde.FechaActual = False
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 110
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(11, 192)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(249, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 23
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtTotalDeudores
        '
        Me.txtTotalDeudores.CampoBusqueda = False
        Me.txtTotalDeudores.CampoEsLlave = False
        Me.txtTotalDeudores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalDeudores.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalDeudores.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalDeudores.FechaActual = False
        Me.txtTotalDeudores.Formato = "#,###0.00"
        Me.txtTotalDeudores.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTotalDeudores.LabelText = "Valor Deudores"
        Me.txtTotalDeudores.LabelWidth = 110
        Me.txtTotalDeudores.Location = New System.Drawing.Point(364, 343)
        Me.txtTotalDeudores.MaxLength = 0
        Me.txtTotalDeudores.Name = "txtTotalDeudores"
        Me.txtTotalDeudores.NombreCampo = "TotalDeudores"
        Me.txtTotalDeudores.Obligatorio = False
        Me.txtTotalDeudores.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDeudores.Size = New System.Drawing.Size(151, 36)
        Me.txtTotalDeudores.SoloLectura = False
        Me.txtTotalDeudores.TabIndex = 8
        Me.txtTotalDeudores.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalDeudores.Valor = 0
        '
        'txtTotalCoaseguro
        '
        Me.txtTotalCoaseguro.CampoBusqueda = False
        Me.txtTotalCoaseguro.CampoEsLlave = False
        Me.txtTotalCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalCoaseguro.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalCoaseguro.FechaActual = False
        Me.txtTotalCoaseguro.Formato = "#,###0.00"
        Me.txtTotalCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTotalCoaseguro.LabelText = "Valor Coaseguro"
        Me.txtTotalCoaseguro.LabelWidth = 110
        Me.txtTotalCoaseguro.Location = New System.Drawing.Point(187, 343)
        Me.txtTotalCoaseguro.MaxLength = 0
        Me.txtTotalCoaseguro.Name = "txtTotalCoaseguro"
        Me.txtTotalCoaseguro.NombreCampo = "TotalCoaseguro"
        Me.txtTotalCoaseguro.Obligatorio = False
        Me.txtTotalCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalCoaseguro.Size = New System.Drawing.Size(151, 36)
        Me.txtTotalCoaseguro.SoloLectura = False
        Me.txtTotalCoaseguro.TabIndex = 7
        Me.txtTotalCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalCoaseguro.Valor = 0
        '
        'txtTotalDeducible
        '
        Me.txtTotalDeducible.CampoBusqueda = False
        Me.txtTotalDeducible.CampoEsLlave = False
        Me.txtTotalDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalDeducible.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalDeducible.FechaActual = False
        Me.txtTotalDeducible.Formato = "#,###0.00"
        Me.txtTotalDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTotalDeducible.LabelText = "Valor Deducible"
        Me.txtTotalDeducible.LabelWidth = 110
        Me.txtTotalDeducible.Location = New System.Drawing.Point(12, 343)
        Me.txtTotalDeducible.MaxLength = 0
        Me.txtTotalDeducible.Name = "txtTotalDeducible"
        Me.txtTotalDeducible.NombreCampo = "TotalDeducible"
        Me.txtTotalDeducible.Obligatorio = False
        Me.txtTotalDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDeducible.Size = New System.Drawing.Size(151, 36)
        Me.txtTotalDeducible.SoloLectura = False
        Me.txtTotalDeducible.TabIndex = 6
        Me.txtTotalDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalDeducible.Valor = 0
        '
        'txtLimiteDeducible
        '
        Me.txtLimiteDeducible.CampoBusqueda = False
        Me.txtLimiteDeducible.CampoEsLlave = False
        Me.txtLimiteDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLimiteDeducible.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimiteDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtLimiteDeducible.FechaActual = False
        Me.txtLimiteDeducible.Formato = "#,###0.00"
        Me.txtLimiteDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtLimiteDeducible.LabelText = "Límite Deducible"
        Me.txtLimiteDeducible.LabelWidth = 110
        Me.txtLimiteDeducible.Location = New System.Drawing.Point(524, 133)
        Me.txtLimiteDeducible.MaxLength = 0
        Me.txtLimiteDeducible.Name = "txtLimiteDeducible"
        Me.txtLimiteDeducible.NombreCampo = "DeducibleLimite"
        Me.txtLimiteDeducible.Obligatorio = False
        Me.txtLimiteDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLimiteDeducible.Size = New System.Drawing.Size(118, 36)
        Me.txtLimiteDeducible.SoloLectura = True
        Me.txtLimiteDeducible.TabIndex = 25
        Me.txtLimiteDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtLimiteDeducible.Valor = 0
        '
        'txtLimiteCoaseguro
        '
        Me.txtLimiteCoaseguro.CampoBusqueda = False
        Me.txtLimiteCoaseguro.CampoEsLlave = False
        Me.txtLimiteCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLimiteCoaseguro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimiteCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtLimiteCoaseguro.FechaActual = False
        Me.txtLimiteCoaseguro.Formato = "#,###0.00"
        Me.txtLimiteCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtLimiteCoaseguro.LabelText = "Límite Coaseguro"
        Me.txtLimiteCoaseguro.LabelWidth = 110
        Me.txtLimiteCoaseguro.Location = New System.Drawing.Point(524, 301)
        Me.txtLimiteCoaseguro.MaxLength = 0
        Me.txtLimiteCoaseguro.Name = "txtLimiteCoaseguro"
        Me.txtLimiteCoaseguro.NombreCampo = "CoaseguroLimite"
        Me.txtLimiteCoaseguro.Obligatorio = False
        Me.txtLimiteCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLimiteCoaseguro.Size = New System.Drawing.Size(118, 36)
        Me.txtLimiteCoaseguro.SoloLectura = True
        Me.txtLimiteCoaseguro.TabIndex = 26
        Me.txtLimiteCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtLimiteCoaseguro.Valor = 0
        '
        'txtAcumuladoCoaseguro
        '
        Me.txtAcumuladoCoaseguro.CampoBusqueda = False
        Me.txtAcumuladoCoaseguro.CampoEsLlave = False
        Me.txtAcumuladoCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAcumuladoCoaseguro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcumuladoCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtAcumuladoCoaseguro.FechaActual = False
        Me.txtAcumuladoCoaseguro.Formato = "#,###0.00"
        Me.txtAcumuladoCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtAcumuladoCoaseguro.LabelText = "Coaseguro Acumulado"
        Me.txtAcumuladoCoaseguro.LabelWidth = 110
        Me.txtAcumuladoCoaseguro.Location = New System.Drawing.Point(524, 340)
        Me.txtAcumuladoCoaseguro.MaxLength = 0
        Me.txtAcumuladoCoaseguro.Name = "txtAcumuladoCoaseguro"
        Me.txtAcumuladoCoaseguro.NombreCampo = "CoaseguroAcumulado"
        Me.txtAcumuladoCoaseguro.Obligatorio = False
        Me.txtAcumuladoCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcumuladoCoaseguro.Size = New System.Drawing.Size(118, 36)
        Me.txtAcumuladoCoaseguro.SoloLectura = True
        Me.txtAcumuladoCoaseguro.TabIndex = 28
        Me.txtAcumuladoCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAcumuladoCoaseguro.Valor = 0
        '
        'txtAcumuladoDeducible
        '
        Me.txtAcumuladoDeducible.CampoBusqueda = False
        Me.txtAcumuladoDeducible.CampoEsLlave = False
        Me.txtAcumuladoDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAcumuladoDeducible.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcumuladoDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtAcumuladoDeducible.FechaActual = False
        Me.txtAcumuladoDeducible.Formato = "#,###0.00"
        Me.txtAcumuladoDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtAcumuladoDeducible.LabelText = "Ded. Acumulado Local"
        Me.txtAcumuladoDeducible.LabelWidth = 110
        Me.txtAcumuladoDeducible.Location = New System.Drawing.Point(524, 172)
        Me.txtAcumuladoDeducible.MaxLength = 0
        Me.txtAcumuladoDeducible.Name = "txtAcumuladoDeducible"
        Me.txtAcumuladoDeducible.NombreCampo = "DeducibleAcumulado"
        Me.txtAcumuladoDeducible.Obligatorio = False
        Me.txtAcumuladoDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcumuladoDeducible.Size = New System.Drawing.Size(118, 36)
        Me.txtAcumuladoDeducible.SoloLectura = True
        Me.txtAcumuladoDeducible.TabIndex = 27
        Me.txtAcumuladoDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAcumuladoDeducible.Valor = 0
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
        Me.cboEjecutivoCta.LabelWidth = 110
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(11, 279)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(315, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 5
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'cboFlujo
        '
        Me.cboFlujo.CampoAutoCompletar = 0
        Me.cboFlujo.CampoBusqueda = False
        Me.cboFlujo.CampoDisplay = 1
        Me.cboFlujo.CampoEsLlave = False
        Me.cboFlujo.CampoValor = 0
        Me.cboFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFlujo.ControlBackColor = System.Drawing.Color.White
        Me.cboFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.cboFlujo.FilasVisibles = 0
        Me.cboFlujo.LabelOrietation = STIControles.stiGridComboBox.LOrientacion.Izquierda
        Me.cboFlujo.LabelText = "Flujo Existente"
        Me.cboFlujo.LabelWidth = 110
        Me.cboFlujo.Lista = ""
        Me.cboFlujo.Location = New System.Drawing.Point(11, 323)
        Me.cboFlujo.Name = "cboFlujo"
        Me.cboFlujo.NombreCampo = ""
        Me.cboFlujo.Obligatorio = False
        Me.cboFlujo.Query = "select IdFlujoDoc as Flujo, Comentario, FechaInicia as Fecha, IdPoliza as [Póliza" & _
            "], NombreCliente as Cliente from FlujosDocumentos where estadoflujo = 'PENDIENTE" & _
            "'"
        Me.cboFlujo.SelectIndex = -2147483648
        Me.cboFlujo.Size = New System.Drawing.Size(504, 20)
        Me.cboFlujo.SoloLectura = False
        Me.cboFlujo.StringConection = ""
        Me.cboFlujo.TabIndex = 29
        Me.cboFlujo.TextoNuevoItem = "<Nuevo Flujo>"
        Me.cboFlujo.TipoDato = STIControles.stiGridComboBox.TipoContenido.Texto
        Me.cboFlujo.Valor = ""
        '
        'cboAmbitoSiniestro
        '
        Me.cboAmbitoSiniestro.CampoAutoCompletar = 0
        Me.cboAmbitoSiniestro.CampoBusqueda = True
        Me.cboAmbitoSiniestro.CampoDisplay = 1
        Me.cboAmbitoSiniestro.CampoEsLlave = False
        Me.cboAmbitoSiniestro.CampoValor = 0
        Me.cboAmbitoSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAmbitoSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboAmbitoSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboAmbitoSiniestro.FilasVisibles = 189
        Me.cboAmbitoSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAmbitoSiniestro.LabelText = "Ambito Siniestro"
        Me.cboAmbitoSiniestro.LabelWidth = 110
        Me.cboAmbitoSiniestro.Lista = ""
        Me.cboAmbitoSiniestro.Location = New System.Drawing.Point(11, 301)
        Me.cboAmbitoSiniestro.MostrarBusquedaColumnas = False
        Me.cboAmbitoSiniestro.Name = "cboAmbitoSiniestro"
        Me.cboAmbitoSiniestro.NombreCampo = "AmbitoSiniestro"
        Me.cboAmbitoSiniestro.Obligatorio = False
        Me.cboAmbitoSiniestro.Query = ""
        Me.cboAmbitoSiniestro.SelectIndex = 0
        Me.cboAmbitoSiniestro.Size = New System.Drawing.Size(370, 20)
        Me.cboAmbitoSiniestro.SoloLectura = False
        Me.cboAmbitoSiniestro.StringConection = ""
        Me.cboAmbitoSiniestro.TabIndex = 43
        Me.cboAmbitoSiniestro.TextoNuevoItem = ""
        Me.cboAmbitoSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAmbitoSiniestro.Valor = ""
        '
        'txtAcumuladoDeducibleMundial
        '
        Me.txtAcumuladoDeducibleMundial.CampoBusqueda = False
        Me.txtAcumuladoDeducibleMundial.CampoEsLlave = False
        Me.txtAcumuladoDeducibleMundial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAcumuladoDeducibleMundial.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcumuladoDeducibleMundial.ControlForeColor = System.Drawing.Color.Black
        Me.txtAcumuladoDeducibleMundial.FechaActual = False
        Me.txtAcumuladoDeducibleMundial.Formato = "#,###0.00"
        Me.txtAcumuladoDeducibleMundial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtAcumuladoDeducibleMundial.LabelText = "Ded. Acumulado Mundial"
        Me.txtAcumuladoDeducibleMundial.LabelWidth = 110
        Me.txtAcumuladoDeducibleMundial.Location = New System.Drawing.Point(524, 214)
        Me.txtAcumuladoDeducibleMundial.MaxLength = 0
        Me.txtAcumuladoDeducibleMundial.Name = "txtAcumuladoDeducibleMundial"
        Me.txtAcumuladoDeducibleMundial.NombreCampo = ""
        Me.txtAcumuladoDeducibleMundial.Obligatorio = False
        Me.txtAcumuladoDeducibleMundial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcumuladoDeducibleMundial.Size = New System.Drawing.Size(118, 36)
        Me.txtAcumuladoDeducibleMundial.SoloLectura = True
        Me.txtAcumuladoDeducibleMundial.TabIndex = 44
        Me.txtAcumuladoDeducibleMundial.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAcumuladoDeducibleMundial.Valor = 0
        Me.txtAcumuladoDeducibleMundial.Visible = False
        '
        'txtAcumuladoDeducibleDental
        '
        Me.txtAcumuladoDeducibleDental.CampoBusqueda = False
        Me.txtAcumuladoDeducibleDental.CampoEsLlave = False
        Me.txtAcumuladoDeducibleDental.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAcumuladoDeducibleDental.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcumuladoDeducibleDental.ControlForeColor = System.Drawing.Color.Black
        Me.txtAcumuladoDeducibleDental.FechaActual = False
        Me.txtAcumuladoDeducibleDental.Formato = "#,###0.00"
        Me.txtAcumuladoDeducibleDental.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtAcumuladoDeducibleDental.LabelText = "Ded. Acumulado Dental"
        Me.txtAcumuladoDeducibleDental.LabelWidth = 110
        Me.txtAcumuladoDeducibleDental.Location = New System.Drawing.Point(524, 256)
        Me.txtAcumuladoDeducibleDental.MaxLength = 0
        Me.txtAcumuladoDeducibleDental.Name = "txtAcumuladoDeducibleDental"
        Me.txtAcumuladoDeducibleDental.NombreCampo = ""
        Me.txtAcumuladoDeducibleDental.Obligatorio = False
        Me.txtAcumuladoDeducibleDental.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcumuladoDeducibleDental.Size = New System.Drawing.Size(118, 36)
        Me.txtAcumuladoDeducibleDental.SoloLectura = True
        Me.txtAcumuladoDeducibleDental.TabIndex = 45
        Me.txtAcumuladoDeducibleDental.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAcumuladoDeducibleDental.Valor = 0
        Me.txtAcumuladoDeducibleDental.Visible = False
        '
        'txtNoFolioReferencia
        '
        Me.txtNoFolioReferencia.CampoBusqueda = True
        Me.txtNoFolioReferencia.CampoEsLlave = False
        Me.txtNoFolioReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNoFolioReferencia.ControlBackColor = System.Drawing.Color.White
        Me.txtNoFolioReferencia.ControlForeColor = System.Drawing.Color.Black
        Me.txtNoFolioReferencia.FechaActual = False
        Me.txtNoFolioReferencia.Formato = ""
        Me.txtNoFolioReferencia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNoFolioReferencia.LabelText = "No.Oficio/Carta Ref."
        Me.txtNoFolioReferencia.LabelWidth = 110
        Me.txtNoFolioReferencia.Location = New System.Drawing.Point(332, 279)
        Me.txtNoFolioReferencia.MaxLength = 50
        Me.txtNoFolioReferencia.Name = "txtNoFolioReferencia"
        Me.txtNoFolioReferencia.NombreCampo = "NoFolioReferencia"
        Me.txtNoFolioReferencia.Obligatorio = False
        Me.txtNoFolioReferencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoFolioReferencia.Size = New System.Drawing.Size(183, 20)
        Me.txtNoFolioReferencia.SoloLectura = False
        Me.txtNoFolioReferencia.TabIndex = 46
        Me.txtNoFolioReferencia.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNoFolioReferencia.Valor = ""
        '
        'DeclaracionSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 804
        Me.ClientSize = New System.Drawing.Size(650, 541)
        Me.Controls.Add(Me.txtNoFolioReferencia)
        Me.Controls.Add(Me.txtAcumuladoDeducibleDental)
        Me.Controls.Add(Me.txtAcumuladoDeducibleMundial)
        Me.Controls.Add(Me.cboAmbitoSiniestro)
        Me.Controls.Add(Me.cboFlujo)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.txtAcumuladoCoaseguro)
        Me.Controls.Add(Me.txtAcumuladoDeducible)
        Me.Controls.Add(Me.txtLimiteCoaseguro)
        Me.Controls.Add(Me.txtLimiteDeducible)
        Me.Controls.Add(Me.txtTotalDeudores)
        Me.Controls.Add(Me.txtTotalCoaseguro)
        Me.Controls.Add(Me.txtTotalDeducible)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.txtIdSiniestroAseguradora)
        Me.Controls.Add(Me.txtIdBien)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.txtAsegurado)
        Me.Controls.Add(Me.txtNombreContratante)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdSiniestro)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtFechaPresentado)
        Me.Controls.Add(Me.txtFechaOcurrido)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.btnQuitarGastos)
        Me.Controls.Add(Me.btnAgregarGasto)
        Me.Controls.Add(Me.txtDescripcionSiniestro)
        Me.FocusPrimerControl = False
        Me.Name = "DeclaracionSiniestros"
        Me.Text = "Declaración Siniestros"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionSiniestro, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarGasto, 0)
        Me.Controls.SetChildIndex(Me.btnQuitarGastos, 0)
        Me.Controls.SetChildIndex(Me.GridDetalle, 0)
        Me.Controls.SetChildIndex(Me.txtFechaOcurrido, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPresentado, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtNombreContratante, 0)
        Me.Controls.SetChildIndex(Me.txtAsegurado, 0)
        Me.Controls.SetChildIndex(Me.txtBeneficiario, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtIdBien, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestroAseguradora, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.txtTotalDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCoaseguro, 0)
        Me.Controls.SetChildIndex(Me.txtTotalDeudores, 0)
        Me.Controls.SetChildIndex(Me.txtLimiteDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtLimiteCoaseguro, 0)
        Me.Controls.SetChildIndex(Me.txtAcumuladoDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtAcumuladoCoaseguro, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.cboFlujo, 0)
        Me.Controls.SetChildIndex(Me.cboAmbitoSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtAcumuladoDeducibleMundial, 0)
        Me.Controls.SetChildIndex(Me.txtAcumuladoDeducibleDental, 0)
        Me.Controls.SetChildIndex(Me.txtNoFolioReferencia, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescripcionSiniestro As STIControles.stiTextBox
    Friend WithEvents btnQuitarGastos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGasto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As STIControles.stiGrid
    Friend WithEvents VistaDetalles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetDescripcionGastos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDetValorPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaPresentado As STIControles.stiTextBox
    Friend WithEvents txtFechaOcurrido As STIControles.stiTextBox
    Friend WithEvents txtNombreContratante As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtAsegurado As STIControles.stiTextBox
    Friend WithEvents txtBeneficiario As STIControles.stiTextBox
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdBien As STIControles.stiTextBox
    Friend WithEvents txtIdSiniestroAseguradora As STIControles.stiTextBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents colDetValorNoCubierto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetValorCubierto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalDeudores As STIControles.stiTextBox
    Friend WithEvents txtTotalCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtTotalDeducible As STIControles.stiTextBox
    Friend WithEvents txtLimiteDeducible As STIControles.stiTextBox
    Friend WithEvents txtLimiteCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtAcumuladoCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtAcumuladoDeducible As STIControles.stiTextBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents cboFlujo As STIControles.stiGridComboBox
    Friend WithEvents cboAmbitoSiniestro As STIControles.stiComboBox
    Friend WithEvents txtAcumuladoDeducibleMundial As STIControles.stiTextBox
    Friend WithEvents txtAcumuladoDeducibleDental As STIControles.stiTextBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNoFolioReferencia As STIControles.stiTextBox

End Class
