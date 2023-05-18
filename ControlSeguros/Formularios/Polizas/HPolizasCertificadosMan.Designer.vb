<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HPolizasCertificadosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HPolizasCertificadosMan))
        Me.TabCertificados = New DevExpress.XtraTab.XtraTabControl
        Me.pagCertificado = New DevExpress.XtraTab.XtraTabPage
        Me.txtPrimaExenta = New STIControles.stiTextBox
        Me.txtIdCertificadoAseguradora = New STIControles.stiTextBox
        Me.txtPorceDepreciacion = New STIControles.stiTextBox
        Me.txtPorceDescuento = New STIControles.stiTextBox
        Me.txtValorDescuento = New STIControles.stiTextBox
        Me.txtPrimaBruta = New STIControles.stiTextBox
        Me.txtIdHistorico = New STIControles.stiTextBox
        Me.txtParticipacion = New STIControles.stiTextBox
        Me.txtDeducible = New STIControles.stiTextBox
        Me.cboIdVendedor = New STIControles.stiComboBox
        Me.txtFechaModifica = New STIControles.stiTextBox
        Me.txtUsuarioModifica = New STIControles.stiTextBox
        Me.txtTotal = New STIControles.stiTextBox
        Me.txtIva = New STIControles.stiTextBox
        Me.txtGastosOtros = New STIControles.stiTextBox
        Me.txtGastosBomb = New STIControles.stiTextBox
        Me.txtGastosFrac = New STIControles.stiTextBox
        Me.txtGastosEmi = New STIControles.stiTextBox
        Me.txtPrimaNeta = New STIControles.stiTextBox
        Me.txtValorAsegurado = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtFechaExclusion = New STIControles.stiTextBox
        Me.txtFechaInclusion = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboEstadoCertificado = New STIControles.stiComboBox
        Me.txtRazonExclusion = New STIControles.stiTextBox
        Me.pagCobertura = New DevExpress.XtraTab.XtraTabPage
        Me.GridCoberturas = New STIControles.stiGrid
        Me.VistaCoberturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCobertura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTasa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDeducible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCobIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorceSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParticipacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCoberturaAdicional = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pagDatosTec = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarBien = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarBien = New DevExpress.XtraEditors.SimpleButton
        Me.GridBienes = New STIControles.stiGrid
        Me.VistaBienes = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colbiIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiIdBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiNombreBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbiDescripcionBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColbiIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBienSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBienPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagBeneficiarios = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarBenef = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarBenef = New DevExpress.XtraEditors.SimpleButton
        Me.GridBeneficiarios = New STIControles.stiGrid
        Me.VistaBeneficiarios = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIdBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbNombreBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colbParentesco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbFechaNacimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbPorcentaje = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagCesiones = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarCesion = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarCesion = New DevExpress.XtraEditors.SimpleButton
        Me.GridCesiones = New STIControles.stiGrid
        Me.VistaCesiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIdCesion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCFechaVigente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCFechaCancela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSumaCedida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCObservaciones = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPropietario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCertificados.SuspendLayout()
        Me.pagCertificado.SuspendLayout()
        Me.pagCobertura.SuspendLayout()
        CType(Me.GridCoberturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaCoberturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDatosTec.SuspendLayout()
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagBeneficiarios.SuspendLayout()
        CType(Me.GridBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCesiones.SuspendLayout()
        CType(Me.GridCesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaCesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(498, 533)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(242, 561)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(21, 561)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(113, 561)
        Me.btnGuardar.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(593, 533)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(6, 533)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(548, 74)
        Me.lblNombreFormulario.Text = "Certificados"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(206, 561)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'TabCertificados
        '
        Me.TabCertificados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabCertificados.Location = New System.Drawing.Point(3, 80)
        Me.TabCertificados.Name = "TabCertificados"
        Me.TabCertificados.SelectedTabPage = Me.pagCertificado
        Me.TabCertificados.Size = New System.Drawing.Size(683, 453)
        Me.TabCertificados.TabIndex = 0
        Me.TabCertificados.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pagCertificado, Me.pagCobertura, Me.pagDatosTec, Me.pagBeneficiarios, Me.pagCesiones})
        '
        'pagCertificado
        '
        Me.pagCertificado.Controls.Add(Me.txtPrimaExenta)
        Me.pagCertificado.Controls.Add(Me.txtIdCertificadoAseguradora)
        Me.pagCertificado.Controls.Add(Me.txtPorceDepreciacion)
        Me.pagCertificado.Controls.Add(Me.txtPorceDescuento)
        Me.pagCertificado.Controls.Add(Me.txtValorDescuento)
        Me.pagCertificado.Controls.Add(Me.txtPrimaBruta)
        Me.pagCertificado.Controls.Add(Me.txtIdHistorico)
        Me.pagCertificado.Controls.Add(Me.txtParticipacion)
        Me.pagCertificado.Controls.Add(Me.txtDeducible)
        Me.pagCertificado.Controls.Add(Me.cboIdVendedor)
        Me.pagCertificado.Controls.Add(Me.txtFechaModifica)
        Me.pagCertificado.Controls.Add(Me.txtUsuarioModifica)
        Me.pagCertificado.Controls.Add(Me.txtTotal)
        Me.pagCertificado.Controls.Add(Me.txtIva)
        Me.pagCertificado.Controls.Add(Me.txtGastosOtros)
        Me.pagCertificado.Controls.Add(Me.txtGastosBomb)
        Me.pagCertificado.Controls.Add(Me.txtGastosFrac)
        Me.pagCertificado.Controls.Add(Me.txtGastosEmi)
        Me.pagCertificado.Controls.Add(Me.txtPrimaNeta)
        Me.pagCertificado.Controls.Add(Me.txtValorAsegurado)
        Me.pagCertificado.Controls.Add(Me.txtVigenciaHasta)
        Me.pagCertificado.Controls.Add(Me.txtFechaExclusion)
        Me.pagCertificado.Controls.Add(Me.txtFechaInclusion)
        Me.pagCertificado.Controls.Add(Me.txtVigenciaDesde)
        Me.pagCertificado.Controls.Add(Me.btnBuscarCliente)
        Me.pagCertificado.Controls.Add(Me.txtNombreCliente)
        Me.pagCertificado.Controls.Add(Me.txtIdCliente)
        Me.pagCertificado.Controls.Add(Me.txtIdCertificado)
        Me.pagCertificado.Controls.Add(Me.cboIdProducto)
        Me.pagCertificado.Controls.Add(Me.txtIdPoliza)
        Me.pagCertificado.Controls.Add(Me.cboEstadoCertificado)
        Me.pagCertificado.Controls.Add(Me.txtRazonExclusion)
        Me.pagCertificado.Name = "pagCertificado"
        Me.pagCertificado.Size = New System.Drawing.Size(674, 422)
        Me.pagCertificado.Text = "Certificado"
        '
        'txtPrimaExenta
        '
        Me.txtPrimaExenta.CampoBusqueda = False
        Me.txtPrimaExenta.CampoEsLlave = False
        Me.txtPrimaExenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaExenta.ControlBackColor = System.Drawing.Color.White
        Me.txtPrimaExenta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaExenta.FechaActual = False
        Me.txtPrimaExenta.Formato = "#,###0.00"
        Me.txtPrimaExenta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaExenta.LabelText = "Prima Exenta"
        Me.txtPrimaExenta.LabelWidth = 150
        Me.txtPrimaExenta.Location = New System.Drawing.Point(343, 260)
        Me.txtPrimaExenta.MaxLength = 0
        Me.txtPrimaExenta.Name = "txtPrimaExenta"
        Me.txtPrimaExenta.NombreCampo = "PrimaExenta"
        Me.txtPrimaExenta.Obligatorio = True
        Me.txtPrimaExenta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaExenta.Size = New System.Drawing.Size(300, 20)
        Me.txtPrimaExenta.SoloLectura = False
        Me.txtPrimaExenta.TabIndex = 11
        Me.txtPrimaExenta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaExenta.Valor = 0
        '
        'txtIdCertificadoAseguradora
        '
        Me.txtIdCertificadoAseguradora.CampoBusqueda = False
        Me.txtIdCertificadoAseguradora.CampoEsLlave = False
        Me.txtIdCertificadoAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificadoAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCertificadoAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificadoAseguradora.FechaActual = False
        Me.txtIdCertificadoAseguradora.Formato = ""
        Me.txtIdCertificadoAseguradora.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificadoAseguradora.LabelText = "Cert.  Aseg."
        Me.txtIdCertificadoAseguradora.LabelWidth = 85
        Me.txtIdCertificadoAseguradora.Location = New System.Drawing.Point(471, 3)
        Me.txtIdCertificadoAseguradora.MaxLength = 0
        Me.txtIdCertificadoAseguradora.Name = "txtIdCertificadoAseguradora"
        Me.txtIdCertificadoAseguradora.NombreCampo = "IdCertificadoAseguradora"
        Me.txtIdCertificadoAseguradora.Obligatorio = False
        Me.txtIdCertificadoAseguradora.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificadoAseguradora.Size = New System.Drawing.Size(172, 20)
        Me.txtIdCertificadoAseguradora.SoloLectura = False
        Me.txtIdCertificadoAseguradora.TabIndex = 30
        Me.txtIdCertificadoAseguradora.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificadoAseguradora.Valor = ""
        '
        'txtPorceDepreciacion
        '
        Me.txtPorceDepreciacion.CampoBusqueda = False
        Me.txtPorceDepreciacion.CampoEsLlave = False
        Me.txtPorceDepreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceDepreciacion.ControlBackColor = System.Drawing.Color.White
        Me.txtPorceDepreciacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceDepreciacion.FechaActual = False
        Me.txtPorceDepreciacion.Formato = ""
        Me.txtPorceDepreciacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceDepreciacion.LabelText = "% Depreciación"
        Me.txtPorceDepreciacion.LabelWidth = 115
        Me.txtPorceDepreciacion.Location = New System.Drawing.Point(9, 214)
        Me.txtPorceDepreciacion.MaxLength = 50
        Me.txtPorceDepreciacion.Name = "txtPorceDepreciacion"
        Me.txtPorceDepreciacion.NombreCampo = "PorceDepreciacion"
        Me.txtPorceDepreciacion.Obligatorio = False
        Me.txtPorceDepreciacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceDepreciacion.Size = New System.Drawing.Size(300, 20)
        Me.txtPorceDepreciacion.SoloLectura = False
        Me.txtPorceDepreciacion.TabIndex = 29
        Me.txtPorceDepreciacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPorceDepreciacion.Valor = ""
        '
        'txtPorceDescuento
        '
        Me.txtPorceDescuento.CampoBusqueda = False
        Me.txtPorceDescuento.CampoEsLlave = False
        Me.txtPorceDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceDescuento.ControlBackColor = System.Drawing.Color.White
        Me.txtPorceDescuento.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceDescuento.FechaActual = False
        Me.txtPorceDescuento.Formato = "#,###0.00"
        Me.txtPorceDescuento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceDescuento.LabelText = "% Descuento"
        Me.txtPorceDescuento.LabelWidth = 150
        Me.txtPorceDescuento.Location = New System.Drawing.Point(343, 191)
        Me.txtPorceDescuento.MaxLength = 0
        Me.txtPorceDescuento.Name = "txtPorceDescuento"
        Me.txtPorceDescuento.NombreCampo = "PorceDescuento"
        Me.txtPorceDescuento.Obligatorio = True
        Me.txtPorceDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceDescuento.Size = New System.Drawing.Size(300, 20)
        Me.txtPorceDescuento.SoloLectura = False
        Me.txtPorceDescuento.TabIndex = 8
        Me.txtPorceDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceDescuento.Valor = 0
        '
        'txtValorDescuento
        '
        Me.txtValorDescuento.CampoBusqueda = False
        Me.txtValorDescuento.CampoEsLlave = False
        Me.txtValorDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorDescuento.ControlBackColor = System.Drawing.Color.White
        Me.txtValorDescuento.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorDescuento.FechaActual = False
        Me.txtValorDescuento.Formato = "#,###0.00"
        Me.txtValorDescuento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorDescuento.LabelText = "Valor Descuento"
        Me.txtValorDescuento.LabelWidth = 150
        Me.txtValorDescuento.Location = New System.Drawing.Point(343, 214)
        Me.txtValorDescuento.MaxLength = 0
        Me.txtValorDescuento.Name = "txtValorDescuento"
        Me.txtValorDescuento.NombreCampo = "ValorDescuento"
        Me.txtValorDescuento.Obligatorio = True
        Me.txtValorDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorDescuento.Size = New System.Drawing.Size(300, 20)
        Me.txtValorDescuento.SoloLectura = False
        Me.txtValorDescuento.TabIndex = 9
        Me.txtValorDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorDescuento.Valor = 0
        '
        'txtPrimaBruta
        '
        Me.txtPrimaBruta.CampoBusqueda = False
        Me.txtPrimaBruta.CampoEsLlave = False
        Me.txtPrimaBruta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaBruta.ControlBackColor = System.Drawing.Color.White
        Me.txtPrimaBruta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaBruta.FechaActual = False
        Me.txtPrimaBruta.Formato = "#,###0.00"
        Me.txtPrimaBruta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaBruta.LabelText = "Prima Total"
        Me.txtPrimaBruta.LabelWidth = 150
        Me.txtPrimaBruta.Location = New System.Drawing.Point(343, 168)
        Me.txtPrimaBruta.MaxLength = 0
        Me.txtPrimaBruta.Name = "txtPrimaBruta"
        Me.txtPrimaBruta.NombreCampo = "PrimaBruta"
        Me.txtPrimaBruta.Obligatorio = True
        Me.txtPrimaBruta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaBruta.Size = New System.Drawing.Size(300, 20)
        Me.txtPrimaBruta.SoloLectura = False
        Me.txtPrimaBruta.TabIndex = 7
        Me.txtPrimaBruta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaBruta.Valor = 0
        '
        'txtIdHistorico
        '
        Me.txtIdHistorico.CampoBusqueda = False
        Me.txtIdHistorico.CampoEsLlave = True
        Me.txtIdHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdHistorico.ControlBackColor = System.Drawing.Color.White
        Me.txtIdHistorico.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdHistorico.FechaActual = False
        Me.txtIdHistorico.Formato = "#0"
        Me.txtIdHistorico.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdHistorico.LabelText = "Núm. Historico"
        Me.txtIdHistorico.LabelWidth = 85
        Me.txtIdHistorico.Location = New System.Drawing.Point(471, 26)
        Me.txtIdHistorico.MaxLength = 50
        Me.txtIdHistorico.Name = "txtIdHistorico"
        Me.txtIdHistorico.NombreCampo = "IdHistorico"
        Me.txtIdHistorico.Obligatorio = True
        Me.txtIdHistorico.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdHistorico.Size = New System.Drawing.Size(172, 20)
        Me.txtIdHistorico.SoloLectura = False
        Me.txtIdHistorico.TabIndex = 25
        Me.txtIdHistorico.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdHistorico.Valor = 0
        '
        'txtParticipacion
        '
        Me.txtParticipacion.CampoBusqueda = False
        Me.txtParticipacion.CampoEsLlave = False
        Me.txtParticipacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtParticipacion.ControlBackColor = System.Drawing.Color.White
        Me.txtParticipacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtParticipacion.FechaActual = False
        Me.txtParticipacion.Formato = ""
        Me.txtParticipacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtParticipacion.LabelText = "Participación"
        Me.txtParticipacion.LabelWidth = 115
        Me.txtParticipacion.Location = New System.Drawing.Point(9, 191)
        Me.txtParticipacion.MaxLength = 50
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.NombreCampo = "Participacion"
        Me.txtParticipacion.Obligatorio = False
        Me.txtParticipacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParticipacion.Size = New System.Drawing.Size(300, 20)
        Me.txtParticipacion.SoloLectura = False
        Me.txtParticipacion.TabIndex = 17
        Me.txtParticipacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtParticipacion.Valor = ""
        '
        'txtDeducible
        '
        Me.txtDeducible.CampoBusqueda = False
        Me.txtDeducible.CampoEsLlave = False
        Me.txtDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDeducible.ControlBackColor = System.Drawing.Color.White
        Me.txtDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtDeducible.FechaActual = False
        Me.txtDeducible.Formato = ""
        Me.txtDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDeducible.LabelText = "Deducible"
        Me.txtDeducible.LabelWidth = 115
        Me.txtDeducible.Location = New System.Drawing.Point(9, 168)
        Me.txtDeducible.MaxLength = 50
        Me.txtDeducible.Name = "txtDeducible"
        Me.txtDeducible.NombreCampo = "Deducible"
        Me.txtDeducible.Obligatorio = False
        Me.txtDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeducible.Size = New System.Drawing.Size(300, 20)
        Me.txtDeducible.SoloLectura = False
        Me.txtDeducible.TabIndex = 16
        Me.txtDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDeducible.Valor = ""
        '
        'cboIdVendedor
        '
        Me.cboIdVendedor.CampoAutoCompletar = 0
        Me.cboIdVendedor.CampoBusqueda = False
        Me.cboIdVendedor.CampoDisplay = 1
        Me.cboIdVendedor.CampoEsLlave = False
        Me.cboIdVendedor.CampoValor = 0
        Me.cboIdVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdVendedor.ControlBackColor = System.Drawing.Color.White
        Me.cboIdVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdVendedor.FilasVisibles = 18
        Me.cboIdVendedor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdVendedor.LabelText = "Vendedor"
        Me.cboIdVendedor.LabelWidth = 115
        Me.cboIdVendedor.Lista = ""
        Me.cboIdVendedor.Location = New System.Drawing.Point(343, 122)
        Me.cboIdVendedor.MostrarBusquedaColumnas = False
        Me.cboIdVendedor.Name = "cboIdVendedor"
        Me.cboIdVendedor.NombreCampo = "IdVendedor"
        Me.cboIdVendedor.Obligatorio = False
        Me.cboIdVendedor.Query = "select idvendedor as Id, NombreVendedor as Vendedor from Vendedores order by Nomb" & _
            "reVendedor"
        Me.cboIdVendedor.SelectIndex = 0
        Me.cboIdVendedor.Size = New System.Drawing.Size(300, 20)
        Me.cboIdVendedor.SoloLectura = False
        Me.cboIdVendedor.StringConection = ""
        Me.cboIdVendedor.TabIndex = 5
        Me.cboIdVendedor.TextoNuevoItem = ""
        Me.cboIdVendedor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdVendedor.Valor = ""
        '
        'txtFechaModifica
        '
        Me.txtFechaModifica.CampoBusqueda = False
        Me.txtFechaModifica.CampoEsLlave = False
        Me.txtFechaModifica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaModifica.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaModifica.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaModifica.FechaActual = False
        Me.txtFechaModifica.Formato = "dd/MMM/yyyy"
        Me.txtFechaModifica.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaModifica.LabelText = "Fecha Modificación"
        Me.txtFechaModifica.LabelWidth = 115
        Me.txtFechaModifica.Location = New System.Drawing.Point(8, 307)
        Me.txtFechaModifica.MaxLength = 0
        Me.txtFechaModifica.Name = "txtFechaModifica"
        Me.txtFechaModifica.NombreCampo = "FechaModifica"
        Me.txtFechaModifica.Obligatorio = False
        Me.txtFechaModifica.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaModifica.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaModifica.SoloLectura = False
        Me.txtFechaModifica.TabIndex = 21
        Me.txtFechaModifica.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaModifica.Valor = Nothing
        '
        'txtUsuarioModifica
        '
        Me.txtUsuarioModifica.CampoBusqueda = False
        Me.txtUsuarioModifica.CampoEsLlave = False
        Me.txtUsuarioModifica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioModifica.ControlBackColor = System.Drawing.Color.White
        Me.txtUsuarioModifica.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioModifica.FechaActual = False
        Me.txtUsuarioModifica.Formato = ""
        Me.txtUsuarioModifica.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtUsuarioModifica.LabelText = "Usuario Modifica"
        Me.txtUsuarioModifica.LabelWidth = 115
        Me.txtUsuarioModifica.Location = New System.Drawing.Point(8, 284)
        Me.txtUsuarioModifica.MaxLength = 25
        Me.txtUsuarioModifica.Name = "txtUsuarioModifica"
        Me.txtUsuarioModifica.NombreCampo = "UsuarioModifica"
        Me.txtUsuarioModifica.Obligatorio = False
        Me.txtUsuarioModifica.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioModifica.Size = New System.Drawing.Size(300, 20)
        Me.txtUsuarioModifica.SoloLectura = False
        Me.txtUsuarioModifica.TabIndex = 20
        Me.txtUsuarioModifica.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioModifica.Valor = ""
        '
        'txtTotal
        '
        Me.txtTotal.CampoBusqueda = False
        Me.txtTotal.CampoEsLlave = False
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.ControlBackColor = System.Drawing.Color.White
        Me.txtTotal.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotal.FechaActual = False
        Me.txtTotal.Formato = "#,###0.00"
        Me.txtTotal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotal.LabelText = "Total Certificado"
        Me.txtTotal.LabelWidth = 150
        Me.txtTotal.Location = New System.Drawing.Point(343, 398)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NombreCampo = "Total"
        Me.txtTotal.Obligatorio = True
        Me.txtTotal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.Size = New System.Drawing.Size(300, 20)
        Me.txtTotal.SoloLectura = False
        Me.txtTotal.TabIndex = 17
        Me.txtTotal.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotal.Valor = 0
        '
        'txtIva
        '
        Me.txtIva.CampoBusqueda = False
        Me.txtIva.CampoEsLlave = False
        Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIva.ControlBackColor = System.Drawing.Color.White
        Me.txtIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtIva.FechaActual = False
        Me.txtIva.Formato = "#,###0.00"
        Me.txtIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIva.LabelText = "Impuestos"
        Me.txtIva.LabelWidth = 150
        Me.txtIva.Location = New System.Drawing.Point(343, 375)
        Me.txtIva.MaxLength = 0
        Me.txtIva.Name = "txtIva"
        Me.txtIva.NombreCampo = "Iva"
        Me.txtIva.Obligatorio = True
        Me.txtIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIva.Size = New System.Drawing.Size(300, 20)
        Me.txtIva.SoloLectura = False
        Me.txtIva.TabIndex = 16
        Me.txtIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIva.Valor = 0
        '
        'txtGastosOtros
        '
        Me.txtGastosOtros.CampoBusqueda = False
        Me.txtGastosOtros.CampoEsLlave = False
        Me.txtGastosOtros.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosOtros.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosOtros.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosOtros.FechaActual = False
        Me.txtGastosOtros.Formato = "#,###0.00"
        Me.txtGastosOtros.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosOtros.LabelText = "Otros Gastos"
        Me.txtGastosOtros.LabelWidth = 150
        Me.txtGastosOtros.Location = New System.Drawing.Point(343, 352)
        Me.txtGastosOtros.MaxLength = 0
        Me.txtGastosOtros.Name = "txtGastosOtros"
        Me.txtGastosOtros.NombreCampo = "GastosOtros"
        Me.txtGastosOtros.Obligatorio = True
        Me.txtGastosOtros.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosOtros.Size = New System.Drawing.Size(300, 20)
        Me.txtGastosOtros.SoloLectura = False
        Me.txtGastosOtros.TabIndex = 15
        Me.txtGastosOtros.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosOtros.Valor = 0
        '
        'txtGastosBomb
        '
        Me.txtGastosBomb.CampoBusqueda = False
        Me.txtGastosBomb.CampoEsLlave = False
        Me.txtGastosBomb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosBomb.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosBomb.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosBomb.FechaActual = False
        Me.txtGastosBomb.Formato = "#,###0.00"
        Me.txtGastosBomb.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosBomb.LabelText = "Gastos de Bomberos"
        Me.txtGastosBomb.LabelWidth = 150
        Me.txtGastosBomb.Location = New System.Drawing.Point(343, 329)
        Me.txtGastosBomb.MaxLength = 0
        Me.txtGastosBomb.Name = "txtGastosBomb"
        Me.txtGastosBomb.NombreCampo = "GastosBomb"
        Me.txtGastosBomb.Obligatorio = True
        Me.txtGastosBomb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosBomb.Size = New System.Drawing.Size(300, 20)
        Me.txtGastosBomb.SoloLectura = False
        Me.txtGastosBomb.TabIndex = 14
        Me.txtGastosBomb.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosBomb.Valor = 0
        '
        'txtGastosFrac
        '
        Me.txtGastosFrac.CampoBusqueda = False
        Me.txtGastosFrac.CampoEsLlave = False
        Me.txtGastosFrac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosFrac.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosFrac.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosFrac.FechaActual = False
        Me.txtGastosFrac.Formato = "#,###0.00"
        Me.txtGastosFrac.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosFrac.LabelText = "Gastos Fraccionamiento"
        Me.txtGastosFrac.LabelWidth = 150
        Me.txtGastosFrac.Location = New System.Drawing.Point(343, 306)
        Me.txtGastosFrac.MaxLength = 0
        Me.txtGastosFrac.Name = "txtGastosFrac"
        Me.txtGastosFrac.NombreCampo = "GastosFrac"
        Me.txtGastosFrac.Obligatorio = True
        Me.txtGastosFrac.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosFrac.Size = New System.Drawing.Size(300, 20)
        Me.txtGastosFrac.SoloLectura = False
        Me.txtGastosFrac.TabIndex = 13
        Me.txtGastosFrac.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosFrac.Valor = 0
        '
        'txtGastosEmi
        '
        Me.txtGastosEmi.CampoBusqueda = False
        Me.txtGastosEmi.CampoEsLlave = False
        Me.txtGastosEmi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosEmi.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosEmi.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosEmi.FechaActual = False
        Me.txtGastosEmi.Formato = "#,###0.00"
        Me.txtGastosEmi.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGastosEmi.LabelText = "Gastos Emisión"
        Me.txtGastosEmi.LabelWidth = 150
        Me.txtGastosEmi.Location = New System.Drawing.Point(343, 283)
        Me.txtGastosEmi.MaxLength = 0
        Me.txtGastosEmi.Name = "txtGastosEmi"
        Me.txtGastosEmi.NombreCampo = "GastosEmi"
        Me.txtGastosEmi.Obligatorio = True
        Me.txtGastosEmi.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosEmi.Size = New System.Drawing.Size(300, 20)
        Me.txtGastosEmi.SoloLectura = False
        Me.txtGastosEmi.TabIndex = 12
        Me.txtGastosEmi.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosEmi.Valor = 0
        '
        'txtPrimaNeta
        '
        Me.txtPrimaNeta.CampoBusqueda = False
        Me.txtPrimaNeta.CampoEsLlave = False
        Me.txtPrimaNeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaNeta.ControlBackColor = System.Drawing.Color.White
        Me.txtPrimaNeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaNeta.FechaActual = False
        Me.txtPrimaNeta.Formato = "#,###0.00"
        Me.txtPrimaNeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimaNeta.LabelText = "Prima Neta"
        Me.txtPrimaNeta.LabelWidth = 150
        Me.txtPrimaNeta.Location = New System.Drawing.Point(343, 237)
        Me.txtPrimaNeta.MaxLength = 0
        Me.txtPrimaNeta.Name = "txtPrimaNeta"
        Me.txtPrimaNeta.NombreCampo = "PrimaNeta"
        Me.txtPrimaNeta.Obligatorio = True
        Me.txtPrimaNeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaNeta.Size = New System.Drawing.Size(300, 20)
        Me.txtPrimaNeta.SoloLectura = False
        Me.txtPrimaNeta.TabIndex = 10
        Me.txtPrimaNeta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaNeta.Valor = 0
        '
        'txtValorAsegurado
        '
        Me.txtValorAsegurado.CampoBusqueda = True
        Me.txtValorAsegurado.CampoEsLlave = False
        Me.txtValorAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorAsegurado.ControlBackColor = System.Drawing.Color.White
        Me.txtValorAsegurado.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorAsegurado.FechaActual = False
        Me.txtValorAsegurado.Formato = "#,###0.00"
        Me.txtValorAsegurado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorAsegurado.LabelText = "Valor Asegurado"
        Me.txtValorAsegurado.LabelWidth = 150
        Me.txtValorAsegurado.Location = New System.Drawing.Point(343, 145)
        Me.txtValorAsegurado.MaxLength = 0
        Me.txtValorAsegurado.Name = "txtValorAsegurado"
        Me.txtValorAsegurado.NombreCampo = "ValorAsegurado"
        Me.txtValorAsegurado.Obligatorio = True
        Me.txtValorAsegurado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorAsegurado.Size = New System.Drawing.Size(300, 20)
        Me.txtValorAsegurado.SoloLectura = False
        Me.txtValorAsegurado.TabIndex = 6
        Me.txtValorAsegurado.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorAsegurado.Valor = 0
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = False
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = False
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigencia Hasta"
        Me.txtVigenciaHasta.LabelWidth = 115
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(343, 99)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(300, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 3
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtFechaExclusion
        '
        Me.txtFechaExclusion.CampoBusqueda = False
        Me.txtFechaExclusion.CampoEsLlave = False
        Me.txtFechaExclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaExclusion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaExclusion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaExclusion.FechaActual = False
        Me.txtFechaExclusion.Formato = "dd/MMM/yyyy"
        Me.txtFechaExclusion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaExclusion.LabelText = "Fecha Exclusión"
        Me.txtFechaExclusion.LabelWidth = 115
        Me.txtFechaExclusion.Location = New System.Drawing.Point(9, 261)
        Me.txtFechaExclusion.MaxLength = 0
        Me.txtFechaExclusion.Name = "txtFechaExclusion"
        Me.txtFechaExclusion.NombreCampo = "FechaExclusion"
        Me.txtFechaExclusion.Obligatorio = False
        Me.txtFechaExclusion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaExclusion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaExclusion.SoloLectura = False
        Me.txtFechaExclusion.TabIndex = 19
        Me.txtFechaExclusion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaExclusion.Valor = Nothing
        '
        'txtFechaInclusion
        '
        Me.txtFechaInclusion.CampoBusqueda = False
        Me.txtFechaInclusion.CampoEsLlave = False
        Me.txtFechaInclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInclusion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaInclusion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInclusion.FechaActual = True
        Me.txtFechaInclusion.Formato = "dd/MMM/yyyy"
        Me.txtFechaInclusion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaInclusion.LabelText = "Fecha Inclusión"
        Me.txtFechaInclusion.LabelWidth = 115
        Me.txtFechaInclusion.Location = New System.Drawing.Point(8, 122)
        Me.txtFechaInclusion.MaxLength = 0
        Me.txtFechaInclusion.Name = "txtFechaInclusion"
        Me.txtFechaInclusion.NombreCampo = "FechaInclusion"
        Me.txtFechaInclusion.Obligatorio = True
        Me.txtFechaInclusion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInclusion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaInclusion.SoloLectura = False
        Me.txtFechaInclusion.TabIndex = 4
        Me.txtFechaInclusion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInclusion.Valor = Nothing
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
        Me.txtVigenciaDesde.LabelWidth = 115
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(8, 99)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(300, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 2
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(315, 47)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 14
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.Visible = False
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
        Me.txtNombreCliente.LabelText = "Nombre Asegurado"
        Me.txtNombreCliente.LabelWidth = 115
        Me.txtNombreCliente.Location = New System.Drawing.Point(8, 76)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(635, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 1
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
        Me.txtIdCliente.Location = New System.Drawing.Point(8, 51)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 0
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
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
        Me.txtIdCertificado.Location = New System.Drawing.Point(216, 3)
        Me.txtIdCertificado.MaxLength = 0
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(244, 20)
        Me.txtIdCertificado.SoloLectura = False
        Me.txtIdCertificado.TabIndex = 22
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = False
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 18
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 115
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(8, 26)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(452, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 24
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
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
        Me.txtIdPoliza.LabelWidth = 60
        Me.txtIdPoliza.Location = New System.Drawing.Point(8, 3)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(202, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 23
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboEstadoCertificado
        '
        Me.cboEstadoCertificado.CampoAutoCompletar = 0
        Me.cboEstadoCertificado.CampoBusqueda = False
        Me.cboEstadoCertificado.CampoDisplay = 1
        Me.cboEstadoCertificado.CampoEsLlave = False
        Me.cboEstadoCertificado.CampoValor = 0
        Me.cboEstadoCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoCertificado.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoCertificado.FilasVisibles = 18
        Me.cboEstadoCertificado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoCertificado.LabelText = "Estado Certificado"
        Me.cboEstadoCertificado.LabelWidth = 115
        Me.cboEstadoCertificado.Lista = "VIGENTE Certificado Vigente|CANCELADO Certificado Cancelado"
        Me.cboEstadoCertificado.Location = New System.Drawing.Point(8, 145)
        Me.cboEstadoCertificado.MostrarBusquedaColumnas = False
        Me.cboEstadoCertificado.Name = "cboEstadoCertificado"
        Me.cboEstadoCertificado.NombreCampo = "EstadoCertificado"
        Me.cboEstadoCertificado.Obligatorio = True
        Me.cboEstadoCertificado.Query = ""
        Me.cboEstadoCertificado.SelectIndex = 0
        Me.cboEstadoCertificado.Size = New System.Drawing.Size(300, 20)
        Me.cboEstadoCertificado.SoloLectura = False
        Me.cboEstadoCertificado.StringConection = ""
        Me.cboEstadoCertificado.TabIndex = 15
        Me.cboEstadoCertificado.TextoNuevoItem = ""
        Me.cboEstadoCertificado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoCertificado.Valor = ""
        '
        'txtRazonExclusion
        '
        Me.txtRazonExclusion.CampoBusqueda = False
        Me.txtRazonExclusion.CampoEsLlave = False
        Me.txtRazonExclusion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRazonExclusion.ControlBackColor = System.Drawing.Color.White
        Me.txtRazonExclusion.ControlForeColor = System.Drawing.Color.Black
        Me.txtRazonExclusion.FechaActual = False
        Me.txtRazonExclusion.Formato = ""
        Me.txtRazonExclusion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtRazonExclusion.LabelText = "Motivo Exclusión"
        Me.txtRazonExclusion.LabelWidth = 115
        Me.txtRazonExclusion.Location = New System.Drawing.Point(9, 238)
        Me.txtRazonExclusion.MaxLength = 250
        Me.txtRazonExclusion.Name = "txtRazonExclusion"
        Me.txtRazonExclusion.NombreCampo = "RazonExclusion"
        Me.txtRazonExclusion.Obligatorio = False
        Me.txtRazonExclusion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazonExclusion.Size = New System.Drawing.Size(300, 20)
        Me.txtRazonExclusion.SoloLectura = False
        Me.txtRazonExclusion.TabIndex = 18
        Me.txtRazonExclusion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRazonExclusion.Valor = ""
        '
        'pagCobertura
        '
        Me.pagCobertura.Controls.Add(Me.GridCoberturas)
        Me.pagCobertura.Name = "pagCobertura"
        Me.pagCobertura.Size = New System.Drawing.Size(674, 422)
        Me.pagCobertura.Text = "Coberturas"
        '
        'GridCoberturas
        '
        Me.GridCoberturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCoberturas.ColumnasAdicionales = ""
        Me.GridCoberturas.Location = New System.Drawing.Point(3, 3)
        Me.GridCoberturas.MainView = Me.VistaCoberturas
        Me.GridCoberturas.Name = "GridCoberturas"
        Me.GridCoberturas.NombreTabla = "HPolizasCoberturas"
        Me.GridCoberturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridCoberturas.Size = New System.Drawing.Size(668, 395)
        Me.GridCoberturas.TabIndex = 0
        Me.GridCoberturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCoberturas})
        '
        'VistaCoberturas
        '
        Me.VistaCoberturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPoliza, Me.colProducto, Me.colCertificado, Me.colCobertura, Me.colDescripcion, Me.colSuma, Me.colTasa, Me.colDeducible, Me.ColCobIdHistorico, Me.colPorceSuma, Me.colPrima, Me.colParticipacion, Me.colCoberturaAdicional})
        Me.VistaCoberturas.GridControl = Me.GridCoberturas
        Me.VistaCoberturas.Name = "VistaCoberturas"
        Me.VistaCoberturas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaCoberturas.OptionsView.ShowGroupPanel = False
        '
        'colPoliza
        '
        Me.colPoliza.Caption = "Poliza"
        Me.colPoliza.FieldName = "IdPoliza"
        Me.colPoliza.Name = "colPoliza"
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "IdProducto"
        Me.colProducto.Name = "colProducto"
        '
        'colCertificado
        '
        Me.colCertificado.Caption = "Certificado"
        Me.colCertificado.FieldName = "IdCertificado"
        Me.colCertificado.Name = "colCertificado"
        '
        'colCobertura
        '
        Me.colCobertura.Caption = "No.Cob."
        Me.colCobertura.FieldName = "IdCobertura"
        Me.colCobertura.Name = "colCobertura"
        Me.colCobertura.Visible = True
        Me.colCobertura.VisibleIndex = 0
        Me.colCobertura.Width = 65
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Tag = "NOSAVE"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 183
        '
        'colSuma
        '
        Me.colSuma.Caption = "Suma Asegurada"
        Me.colSuma.DisplayFormat.FormatString = "c"
        Me.colSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSuma.FieldName = "SumaAsegurada"
        Me.colSuma.Name = "colSuma"
        Me.colSuma.Visible = True
        Me.colSuma.VisibleIndex = 2
        Me.colSuma.Width = 110
        '
        'colTasa
        '
        Me.colTasa.Caption = "Tasa"
        Me.colTasa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTasa.FieldName = "Tasa"
        Me.colTasa.Name = "colTasa"
        Me.colTasa.Visible = True
        Me.colTasa.VisibleIndex = 4
        Me.colTasa.Width = 57
        '
        'colDeducible
        '
        Me.colDeducible.Caption = "Deducible"
        Me.colDeducible.FieldName = "Deducible"
        Me.colDeducible.Name = "colDeducible"
        Me.colDeducible.Visible = True
        Me.colDeducible.VisibleIndex = 6
        Me.colDeducible.Width = 207
        '
        'ColCobIdHistorico
        '
        Me.ColCobIdHistorico.Caption = "IdHistorico"
        Me.ColCobIdHistorico.FieldName = "IdHistorico"
        Me.ColCobIdHistorico.Name = "ColCobIdHistorico"
        '
        'colPorceSuma
        '
        Me.colPorceSuma.Caption = "%Suma"
        Me.colPorceSuma.FieldName = "PorceSuma"
        Me.colPorceSuma.Name = "colPorceSuma"
        Me.colPorceSuma.Visible = True
        Me.colPorceSuma.VisibleIndex = 3
        '
        'colPrima
        '
        Me.colPrima.Caption = "Prima"
        Me.colPrima.DisplayFormat.FormatString = "c"
        Me.colPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrima.FieldName = "Prima"
        Me.colPrima.Name = "colPrima"
        Me.colPrima.Visible = True
        Me.colPrima.VisibleIndex = 5
        '
        'colParticipacion
        '
        Me.colParticipacion.Caption = "Participación"
        Me.colParticipacion.FieldName = "Participacion"
        Me.colParticipacion.Name = "colParticipacion"
        '
        'colCoberturaAdicional
        '
        Me.colCoberturaAdicional.Caption = "Incluir"
        Me.colCoberturaAdicional.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colCoberturaAdicional.FieldName = "CoberturaAdicional"
        Me.colCoberturaAdicional.Name = "colCoberturaAdicional"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'pagDatosTec
        '
        Me.pagDatosTec.Controls.Add(Me.btnQuitarBien)
        Me.pagDatosTec.Controls.Add(Me.btnAgregarBien)
        Me.pagDatosTec.Controls.Add(Me.GridBienes)
        Me.pagDatosTec.Name = "pagDatosTec"
        Me.pagDatosTec.Size = New System.Drawing.Size(674, 422)
        Me.pagDatosTec.Text = "Datos de Bienes"
        '
        'btnQuitarBien
        '
        Me.btnQuitarBien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarBien.Location = New System.Drawing.Point(659, 16)
        Me.btnQuitarBien.Name = "btnQuitarBien"
        Me.btnQuitarBien.Size = New System.Drawing.Size(10, 10)
        Me.btnQuitarBien.TabIndex = 26
        Me.btnQuitarBien.Text = "Quitar"
        Me.btnQuitarBien.Visible = False
        '
        'btnAgregarBien
        '
        Me.btnAgregarBien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarBien.Location = New System.Drawing.Point(659, 3)
        Me.btnAgregarBien.Name = "btnAgregarBien"
        Me.btnAgregarBien.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarBien.TabIndex = 25
        Me.btnAgregarBien.Text = "Agregar"
        Me.btnAgregarBien.Visible = False
        '
        'GridBienes
        '
        Me.GridBienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBienes.ColumnasAdicionales = ""
        Me.GridBienes.Location = New System.Drawing.Point(2, 3)
        Me.GridBienes.MainView = Me.VistaBienes
        Me.GridBienes.Name = "GridBienes"
        Me.GridBienes.NombreTabla = "HPolizasBienes"
        Me.GridBienes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridBienes.Size = New System.Drawing.Size(667, 360)
        Me.GridBienes.TabIndex = 0
        Me.GridBienes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBienes})
        '
        'VistaBienes
        '
        Me.VistaBienes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbiIdPoliza, Me.colbiIdProducto, Me.colbiIdCertificado, Me.colbiIdBien, Me.colbiNombreBien, Me.colbiDescripcionBien, Me.ColbiIdHistorico, Me.colBienSuma, Me.colBienPrima})
        Me.VistaBienes.GridControl = Me.GridBienes
        Me.VistaBienes.Name = "VistaBienes"
        Me.VistaBienes.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaBienes.OptionsView.ShowGroupPanel = False
        '
        'colbiIdPoliza
        '
        Me.colbiIdPoliza.Caption = "IdPoliza"
        Me.colbiIdPoliza.FieldName = "IdPoliza"
        Me.colbiIdPoliza.Name = "colbiIdPoliza"
        '
        'colbiIdProducto
        '
        Me.colbiIdProducto.Caption = "IdProducto"
        Me.colbiIdProducto.FieldName = "IdProducto"
        Me.colbiIdProducto.Name = "colbiIdProducto"
        '
        'colbiIdCertificado
        '
        Me.colbiIdCertificado.Caption = "IdCertificado"
        Me.colbiIdCertificado.FieldName = "IdCertificado"
        Me.colbiIdCertificado.Name = "colbiIdCertificado"
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
        Me.colbiNombreBien.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colbiNombreBien.FieldName = "NombreBien"
        Me.colbiNombreBien.Name = "colbiNombreBien"
        Me.colbiNombreBien.Visible = True
        Me.colbiNombreBien.VisibleIndex = 1
        Me.colbiNombreBien.Width = 121
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colbiDescripcionBien
        '
        Me.colbiDescripcionBien.Caption = "Descripción del Bien"
        Me.colbiDescripcionBien.FieldName = "DescripcionBien"
        Me.colbiDescripcionBien.Name = "colbiDescripcionBien"
        Me.colbiDescripcionBien.Visible = True
        Me.colbiDescripcionBien.VisibleIndex = 2
        Me.colbiDescripcionBien.Width = 375
        '
        'ColbiIdHistorico
        '
        Me.ColbiIdHistorico.Caption = "IdHistorico"
        Me.ColbiIdHistorico.FieldName = "IdHistorico"
        Me.ColbiIdHistorico.Name = "ColbiIdHistorico"
        '
        'colBienSuma
        '
        Me.colBienSuma.Caption = "Suma Asegurada"
        Me.colBienSuma.DisplayFormat.FormatString = "c2"
        Me.colBienSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBienSuma.FieldName = "SumaAsegurada"
        Me.colBienSuma.Name = "colBienSuma"
        '
        'colBienPrima
        '
        Me.colBienPrima.Caption = "Prima"
        Me.colBienPrima.DisplayFormat.FormatString = "c2"
        Me.colBienPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBienPrima.FieldName = "Prima"
        Me.colBienPrima.Name = "colBienPrima"
        '
        'pagBeneficiarios
        '
        Me.pagBeneficiarios.Controls.Add(Me.btnQuitarBenef)
        Me.pagBeneficiarios.Controls.Add(Me.btnAgregarBenef)
        Me.pagBeneficiarios.Controls.Add(Me.GridBeneficiarios)
        Me.pagBeneficiarios.Name = "pagBeneficiarios"
        Me.pagBeneficiarios.Size = New System.Drawing.Size(674, 422)
        Me.pagBeneficiarios.Text = "Beneficiarios"
        '
        'btnQuitarBenef
        '
        Me.btnQuitarBenef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarBenef.Location = New System.Drawing.Point(659, 16)
        Me.btnQuitarBenef.Name = "btnQuitarBenef"
        Me.btnQuitarBenef.Size = New System.Drawing.Size(10, 10)
        Me.btnQuitarBenef.TabIndex = 24
        Me.btnQuitarBenef.Text = "Quitar"
        Me.btnQuitarBenef.Visible = False
        '
        'btnAgregarBenef
        '
        Me.btnAgregarBenef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarBenef.Location = New System.Drawing.Point(659, 3)
        Me.btnAgregarBenef.Name = "btnAgregarBenef"
        Me.btnAgregarBenef.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarBenef.TabIndex = 23
        Me.btnAgregarBenef.Text = "Agregar"
        Me.btnAgregarBenef.Visible = False
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
        Me.GridBeneficiarios.NombreTabla = "HPolizasBeneficiarios"
        Me.GridBeneficiarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemTextEdit1})
        Me.GridBeneficiarios.Size = New System.Drawing.Size(668, 360)
        Me.GridBeneficiarios.TabIndex = 5
        Me.GridBeneficiarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBeneficiarios})
        '
        'VistaBeneficiarios
        '
        Me.VistaBeneficiarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBIdPoliza, Me.colBIdProducto, Me.colBIdCertificado, Me.colBIdBeneficiario, Me.colbNombreBeneficiario, Me.colbParentesco, Me.colbFechaNacimiento, Me.colbPorcentaje, Me.colBIdHistorico})
        Me.VistaBeneficiarios.GridControl = Me.GridBeneficiarios
        Me.VistaBeneficiarios.Name = "VistaBeneficiarios"
        Me.VistaBeneficiarios.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaBeneficiarios.OptionsView.ShowGroupPanel = False
        '
        'colBIdPoliza
        '
        Me.colBIdPoliza.Caption = "IdPoliza"
        Me.colBIdPoliza.FieldName = "IdPoliza"
        Me.colBIdPoliza.Name = "colBIdPoliza"
        '
        'colBIdProducto
        '
        Me.colBIdProducto.Caption = "IdProducto"
        Me.colBIdProducto.FieldName = "IdProducto"
        Me.colBIdProducto.Name = "colBIdProducto"
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
        'colBIdHistorico
        '
        Me.colBIdHistorico.Caption = "IdHistorico"
        Me.colBIdHistorico.FieldName = "IdHistorico"
        Me.colBIdHistorico.Name = "colBIdHistorico"
        '
        'pagCesiones
        '
        Me.pagCesiones.Controls.Add(Me.btnQuitarCesion)
        Me.pagCesiones.Controls.Add(Me.btnAgregarCesion)
        Me.pagCesiones.Controls.Add(Me.GridCesiones)
        Me.pagCesiones.Name = "pagCesiones"
        Me.pagCesiones.Size = New System.Drawing.Size(674, 422)
        Me.pagCesiones.Text = "Cesiones de Beneficios"
        '
        'btnQuitarCesion
        '
        Me.btnQuitarCesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarCesion.Location = New System.Drawing.Point(659, 16)
        Me.btnQuitarCesion.Name = "btnQuitarCesion"
        Me.btnQuitarCesion.Size = New System.Drawing.Size(10, 10)
        Me.btnQuitarCesion.TabIndex = 22
        Me.btnQuitarCesion.Text = "Quitar"
        Me.btnQuitarCesion.Visible = False
        '
        'btnAgregarCesion
        '
        Me.btnAgregarCesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCesion.Location = New System.Drawing.Point(659, 3)
        Me.btnAgregarCesion.Name = "btnAgregarCesion"
        Me.btnAgregarCesion.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarCesion.TabIndex = 21
        Me.btnAgregarCesion.Text = "Agregar"
        Me.btnAgregarCesion.Visible = False
        '
        'GridCesiones
        '
        Me.GridCesiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCesiones.ColumnasAdicionales = ""
        Me.GridCesiones.Location = New System.Drawing.Point(3, 3)
        Me.GridCesiones.MainView = Me.VistaCesiones
        Me.GridCesiones.Name = "GridCesiones"
        Me.GridCesiones.NombreTabla = "HPolizasCesiones"
        Me.GridCesiones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        Me.GridCesiones.Size = New System.Drawing.Size(666, 360)
        Me.GridCesiones.TabIndex = 0
        Me.GridCesiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCesiones})
        '
        'VistaCesiones
        '
        Me.VistaCesiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCIdPoliza, Me.colCIdProducto, Me.colCIdCertificado, Me.colCIdCesion, Me.colCBeneficiario, Me.colCFechaVigente, Me.colCFechaCancela, Me.colCSumaCedida, Me.colCObservaciones, Me.colCIdHistorico, Me.colPropietario})
        Me.VistaCesiones.GridControl = Me.GridCesiones
        Me.VistaCesiones.Name = "VistaCesiones"
        Me.VistaCesiones.OptionsView.ShowGroupPanel = False
        '
        'colCIdPoliza
        '
        Me.colCIdPoliza.Caption = "IdPoliza"
        Me.colCIdPoliza.FieldName = "IdPoliza"
        Me.colCIdPoliza.Name = "colCIdPoliza"
        '
        'colCIdProducto
        '
        Me.colCIdProducto.Caption = "IdProducto"
        Me.colCIdProducto.FieldName = "IdProducto"
        Me.colCIdProducto.Name = "colCIdProducto"
        '
        'colCIdCertificado
        '
        Me.colCIdCertificado.Caption = "IdCertificado"
        Me.colCIdCertificado.FieldName = "IdCertificado"
        Me.colCIdCertificado.Name = "colCIdCertificado"
        '
        'colCIdCesion
        '
        Me.colCIdCesion.Caption = "Cod. Cesión"
        Me.colCIdCesion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCIdCesion.FieldName = "IdCesion"
        Me.colCIdCesion.Name = "colCIdCesion"
        Me.colCIdCesion.Visible = True
        Me.colCIdCesion.VisibleIndex = 0
        Me.colCIdCesion.Width = 71
        '
        'colCBeneficiario
        '
        Me.colCBeneficiario.Caption = "Beneficiario"
        Me.colCBeneficiario.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colCBeneficiario.FieldName = "Beneficiario"
        Me.colCBeneficiario.Name = "colCBeneficiario"
        Me.colCBeneficiario.Visible = True
        Me.colCBeneficiario.VisibleIndex = 1
        Me.colCBeneficiario.Width = 194
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colCFechaVigente
        '
        Me.colCFechaVigente.Caption = "Fec. Vigencia"
        Me.colCFechaVigente.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colCFechaVigente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCFechaVigente.FieldName = "FechaVigente"
        Me.colCFechaVigente.Name = "colCFechaVigente"
        Me.colCFechaVigente.Visible = True
        Me.colCFechaVigente.VisibleIndex = 2
        Me.colCFechaVigente.Width = 87
        '
        'colCFechaCancela
        '
        Me.colCFechaCancela.Caption = "Fec. Cancelación"
        Me.colCFechaCancela.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colCFechaCancela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCFechaCancela.FieldName = "FechaCancela"
        Me.colCFechaCancela.Name = "colCFechaCancela"
        Me.colCFechaCancela.Visible = True
        Me.colCFechaCancela.VisibleIndex = 3
        Me.colCFechaCancela.Width = 96
        '
        'colCSumaCedida
        '
        Me.colCSumaCedida.Caption = "Suma Cedida"
        Me.colCSumaCedida.DisplayFormat.FormatString = "c"
        Me.colCSumaCedida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCSumaCedida.FieldName = "SumaCedida"
        Me.colCSumaCedida.Name = "colCSumaCedida"
        Me.colCSumaCedida.Visible = True
        Me.colCSumaCedida.VisibleIndex = 4
        Me.colCSumaCedida.Width = 77
        '
        'colCObservaciones
        '
        Me.colCObservaciones.Caption = "Observaciones"
        Me.colCObservaciones.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colCObservaciones.FieldName = "Observaciones"
        Me.colCObservaciones.Name = "colCObservaciones"
        Me.colCObservaciones.Visible = True
        Me.colCObservaciones.VisibleIndex = 5
        Me.colCObservaciones.Width = 98
        '
        'colCIdHistorico
        '
        Me.colCIdHistorico.Caption = "IdHistorico"
        Me.colCIdHistorico.FieldName = "IdHistorico"
        Me.colCIdHistorico.Name = "colCIdHistorico"
        '
        'colPropietario
        '
        Me.colPropietario.Caption = "Propietario"
        Me.colPropietario.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPropietario.FieldName = "Propietario"
        Me.colPropietario.Name = "colPropietario"
        Me.colPropietario.Visible = True
        Me.colPropietario.VisibleIndex = 6
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(386, 533)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(109, 36)
        Me.btnImprimir.TabIndex = 23
        Me.btnImprimir.Text = "&Imprimir Certificado"
        '
        'HPolizasCertificadosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 507
        Me.ClientSize = New System.Drawing.Size(687, 571)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.TabCertificados)
        Me.Name = "HPolizasCertificadosMan"
        Me.Text = "Certificados"
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.TabCertificados, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCertificados.ResumeLayout(False)
        Me.pagCertificado.ResumeLayout(False)
        Me.pagCobertura.ResumeLayout(False)
        CType(Me.GridCoberturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaCoberturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDatosTec.ResumeLayout(False)
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagBeneficiarios.ResumeLayout(False)
        CType(Me.GridBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCesiones.ResumeLayout(False)
        CType(Me.GridCesiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaCesiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabCertificados As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pagCertificado As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pagCobertura As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pagDatosTec As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtRazonExclusion As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboEstadoCertificado As STIControles.stiComboBox
    Friend WithEvents txtFechaModifica As STIControles.stiTextBox
    Friend WithEvents txtUsuarioModifica As STIControles.stiTextBox
    Friend WithEvents txtTotal As STIControles.stiTextBox
    Friend WithEvents txtIva As STIControles.stiTextBox
    Friend WithEvents txtGastosOtros As STIControles.stiTextBox
    Friend WithEvents txtGastosBomb As STIControles.stiTextBox
    Friend WithEvents txtGastosFrac As STIControles.stiTextBox
    Friend WithEvents txtGastosEmi As STIControles.stiTextBox
    Friend WithEvents txtPrimaNeta As STIControles.stiTextBox
    Friend WithEvents txtValorAsegurado As STIControles.stiTextBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtFechaExclusion As STIControles.stiTextBox
    Friend WithEvents txtFechaInclusion As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents cboIdVendedor As STIControles.stiComboBox
    Friend WithEvents GridCoberturas As STIControles.stiGrid
    Friend WithEvents VistaCoberturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCobertura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeducible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtParticipacion As STIControles.stiTextBox
    Friend WithEvents txtDeducible As STIControles.stiTextBox
    Friend WithEvents pagCesiones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCesiones As STIControles.stiGrid
    Friend WithEvents VistaCesiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIdCesion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFechaVigente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFechaCancela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSumaCedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarCesion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarCesion As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pagBeneficiarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridBeneficiarios As STIControles.stiGrid
    Friend WithEvents VistaBeneficiarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIdBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbNombreBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbParentesco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbFechaNacimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPorcentaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarBenef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarBenef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridBienes As STIControles.stiGrid
    Friend WithEvents VistaBienes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbiIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiIdBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiNombreBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiDescripcionBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarBien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarBien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtIdHistorico As STIControles.stiTextBox
    Friend WithEvents ColCobIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColbiIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPorceDescuento As STIControles.stiTextBox
    Friend WithEvents txtValorDescuento As STIControles.stiTextBox
    Friend WithEvents txtPrimaBruta As STIControles.stiTextBox
    Friend WithEvents colPorceSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPorceDepreciacion As STIControles.stiTextBox
    Friend WithEvents colBienSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBienPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIdCertificadoAseguradora As STIControles.stiTextBox
    Friend WithEvents colParticipacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoberturaAdicional As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colPropietario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPrimaExenta As STIControles.stiTextBox

End Class
