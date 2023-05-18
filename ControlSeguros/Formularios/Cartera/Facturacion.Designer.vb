<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.cboTipoFactura = New STIControles.stiComboBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtIdAnexo = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboFormaPago = New STIControles.stiComboBox
        Me.txtNumFacturaInicial = New STIControles.stiTextBox
        Me.GridFacturas = New STIControles.stiGrid
        Me.VistaFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FACol1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtPorceComision = New STIControles.stiTextBox
        Me.txtPrima = New STIControles.stiTextBox
        Me.GridGastos = New STIControles.stiGrid
        Me.VistaGastos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtNumTarjeta = New STIControles.stiTextBox
        Me.txtNombreTarjeta = New STIControles.stiTextBox
        Me.txtVenceTarjeta = New STIControles.stiTextBox
        Me.txtReferencia = New STIControles.stiTextBox
        Me.txtObservaciones = New STIControles.stiTextBox
        Me.txtIdAvisoCobro = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.txtMotivoAnulacion = New STIControles.stiTextBox
        Me.cboAvisoInterno = New STIControles.stiComboBox
        Me.txtFechaInicialPago = New STIControles.stiTextBox
        Me.cboAplicarRetencionIva = New STIControles.stiComboBox
        Me.txtFechaNotificacion = New STIControles.stiTextBox
        Me.txtUsuarioGrabacion = New STIControles.stiTextBox
        Me.chkImpPP = New DevExpress.XtraEditors.CheckEdit
        Me.btnReactivar = New DevExpress.XtraEditors.SimpleButton
        Me.txtPrimaExenta = New STIControles.stiTextBox
        Me.cboAtencionA = New STIControles.stiGridComboBox
        Me.txtCuentaBancaria = New STIControles.stiTextBox
        Me.txtNombreCuentaHabiente = New STIControles.stiTextBox
        Me.cboIdBanco = New STIControles.stiComboBox
        Me.cboFlujo = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpPP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(539, 587)
        Me.btnAyuda.TabIndex = 30
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(20, 613)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(206, 587)
        Me.btnNuevo.TabIndex = 27
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(417, 587)
        Me.btnGuardar.Size = New System.Drawing.Size(122, 36)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "&Generar Aviso Cobro"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(631, 587)
        Me.btnSalir.TabIndex = 31
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Appearance.Options.UseTextOptions = True
        Me.btnEliminar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEliminar.Location = New System.Drawing.Point(4, 587)
        Me.btnEliminar.Size = New System.Drawing.Size(95, 36)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "An&ular AC"
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
        Me.lblNombreFormulario.Location = New System.Drawing.Point(137, 1)
        Me.lblNombreFormulario.Size = New System.Drawing.Size(587, 38)
        Me.lblNombreFormulario.TabIndex = 29
        Me.lblNombreFormulario.Text = "Generación de Avisos de Cobro"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(36, 613)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 32
        Me.btnGuardarComo.Visible = False
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = False
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = True
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtVigenciaHasta.LabelText = "Vigenica Hasta"
        Me.txtVigenciaHasta.LabelWidth = 125
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(184, 182)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(166, 36)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 6
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = False
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = True
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 125
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(12, 182)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(166, 36)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 5
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.CampoAutoCompletar = 0
        Me.cboTipoFactura.CampoBusqueda = False
        Me.cboTipoFactura.CampoDisplay = 1
        Me.cboTipoFactura.CampoEsLlave = False
        Me.cboTipoFactura.CampoValor = 0
        Me.cboTipoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoFactura.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoFactura.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoFactura.FilasVisibles = 53125
        Me.cboTipoFactura.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboTipoFactura.LabelText = "Tipo Documento"
        Me.cboTipoFactura.LabelWidth = 125
        Me.cboTipoFactura.Lista = "F Factura|C Crédito Fiscal|E Factura Exportación"
        Me.cboTipoFactura.Location = New System.Drawing.Point(356, 180)
        Me.cboTipoFactura.MostrarBusquedaColumnas = False
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.NombreCampo = "TipoFactura"
        Me.cboTipoFactura.Obligatorio = True
        Me.cboTipoFactura.Query = ""
        Me.cboTipoFactura.SelectIndex = 0
        Me.cboTipoFactura.Size = New System.Drawing.Size(166, 38)
        Me.cboTipoFactura.SoloLectura = False
        Me.cboTipoFactura.StringConection = ""
        Me.cboTipoFactura.TabIndex = 7
        Me.cboTipoFactura.TextoNuevoItem = ""
        Me.cboTipoFactura.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoFactura.Valor = ""
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
        Me.cboIdProducto.FilasVisibles = 53125
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 125
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(297, 76)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto [Producto], Descripcion [Descripción] from Productos order by D" & _
            "escripcion asc"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(397, 38)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 1
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
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
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNombreCliente.LabelText = "Nombre Cliente Facturas"
        Me.txtNombreCliente.LabelWidth = 125
        Me.txtNombreCliente.Location = New System.Drawing.Point(297, 117)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(397, 36)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 25
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 125
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 117)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(167, 36)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 24
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtIdAnexo
        '
        Me.txtIdAnexo.CampoBusqueda = False
        Me.txtIdAnexo.CampoEsLlave = False
        Me.txtIdAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAnexo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAnexo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAnexo.FechaActual = False
        Me.txtIdAnexo.Formato = ""
        Me.txtIdAnexo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdAnexo.LabelText = "Tipo Anexo"
        Me.txtIdAnexo.LabelWidth = 125
        Me.txtIdAnexo.Location = New System.Drawing.Point(184, 220)
        Me.txtIdAnexo.MaxLength = 25
        Me.txtIdAnexo.Name = "txtIdAnexo"
        Me.txtIdAnexo.NombreCampo = "IdAnexo"
        Me.txtIdAnexo.Obligatorio = True
        Me.txtIdAnexo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAnexo.Size = New System.Drawing.Size(166, 36)
        Me.txtIdAnexo.SoloLectura = False
        Me.txtIdAnexo.TabIndex = 10
        Me.txtIdAnexo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAnexo.Valor = ""
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
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 125
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 78)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(166, 36)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 0
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboFormaPago
        '
        Me.cboFormaPago.CampoAutoCompletar = 0
        Me.cboFormaPago.CampoBusqueda = False
        Me.cboFormaPago.CampoDisplay = 1
        Me.cboFormaPago.CampoEsLlave = False
        Me.cboFormaPago.CampoValor = 0
        Me.cboFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.cboFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboFormaPago.FilasVisibles = 53125
        Me.cboFormaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboFormaPago.LabelText = "Forma de Pago"
        Me.cboFormaPago.LabelWidth = 125
        Me.cboFormaPago.Lista = ""
        Me.cboFormaPago.Location = New System.Drawing.Point(528, 180)
        Me.cboFormaPago.MostrarBusquedaColumnas = False
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.NombreCampo = "TipoFactura"
        Me.cboFormaPago.Obligatorio = True
        Me.cboFormaPago.Query = "select IdFormaPago as FormaPago, Descripcion as [Descripción] from FormasPago"
        Me.cboFormaPago.SelectIndex = 0
        Me.cboFormaPago.Size = New System.Drawing.Size(166, 38)
        Me.cboFormaPago.SoloLectura = False
        Me.cboFormaPago.StringConection = ""
        Me.cboFormaPago.TabIndex = 8
        Me.cboFormaPago.TextoNuevoItem = ""
        Me.cboFormaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboFormaPago.Valor = ""
        '
        'txtNumFacturaInicial
        '
        Me.txtNumFacturaInicial.CampoBusqueda = False
        Me.txtNumFacturaInicial.CampoEsLlave = False
        Me.txtNumFacturaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumFacturaInicial.ControlBackColor = System.Drawing.Color.White
        Me.txtNumFacturaInicial.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumFacturaInicial.FechaActual = False
        Me.txtNumFacturaInicial.Formato = ""
        Me.txtNumFacturaInicial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNumFacturaInicial.LabelText = "#Factura Inicial"
        Me.txtNumFacturaInicial.LabelWidth = 125
        Me.txtNumFacturaInicial.Location = New System.Drawing.Point(12, 220)
        Me.txtNumFacturaInicial.MaxLength = 25
        Me.txtNumFacturaInicial.Name = "txtNumFacturaInicial"
        Me.txtNumFacturaInicial.NombreCampo = "IdCliente"
        Me.txtNumFacturaInicial.Obligatorio = True
        Me.txtNumFacturaInicial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumFacturaInicial.Size = New System.Drawing.Size(170, 36)
        Me.txtNumFacturaInicial.SoloLectura = False
        Me.txtNumFacturaInicial.TabIndex = 9
        Me.txtNumFacturaInicial.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumFacturaInicial.Valor = ""
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.ColumnasAdicionales = ""
        Me.GridFacturas.Location = New System.Drawing.Point(4, 452)
        Me.GridFacturas.MainView = Me.VistaFacturas
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.NombreTabla = ""
        Me.GridFacturas.Size = New System.Drawing.Size(716, 111)
        Me.GridFacturas.TabIndex = 25
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaFacturas})
        '
        'VistaFacturas
        '
        Me.VistaFacturas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaFacturas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaFacturas.ColumnPanelRowHeight = 40
        Me.VistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FACol1, Me.FACol2, Me.FACol3, Me.FACol8, Me.FACol9, Me.FACol10, Me.FACol4, Me.FACol5, Me.FACol11, Me.FACol6, Me.FACol7, Me.GridColumn4, Me.GridColumn5})
        Me.VistaFacturas.GridControl = Me.GridFacturas
        Me.VistaFacturas.Name = "VistaFacturas"
        Me.VistaFacturas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaFacturas.OptionsView.ShowFooter = True
        Me.VistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'FACol1
        '
        Me.FACol1.Caption = "#Factura"
        Me.FACol1.FieldName = "NumFactura"
        Me.FACol1.Name = "FACol1"
        Me.FACol1.Visible = True
        Me.FACol1.VisibleIndex = 0
        Me.FACol1.Width = 59
        '
        'FACol2
        '
        Me.FACol2.Caption = "Fecha Pago"
        Me.FACol2.FieldName = "FechaPago"
        Me.FACol2.Name = "FACol2"
        Me.FACol2.Visible = True
        Me.FACol2.VisibleIndex = 1
        Me.FACol2.Width = 86
        '
        'FACol3
        '
        Me.FACol3.Caption = "Prima"
        Me.FACol3.DisplayFormat.FormatString = "c"
        Me.FACol3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol3.FieldName = "Prima"
        Me.FACol3.Name = "FACol3"
        Me.FACol3.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol3.Visible = True
        Me.FACol3.VisibleIndex = 3
        Me.FACol3.Width = 86
        '
        'FACol8
        '
        Me.FACol8.Caption = "G. Emisión"
        Me.FACol8.DisplayFormat.FormatString = "c"
        Me.FACol8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol8.FieldName = "GastosEmision"
        Me.FACol8.Name = "FACol8"
        Me.FACol8.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol8.Visible = True
        Me.FACol8.VisibleIndex = 5
        '
        'FACol9
        '
        Me.FACol9.Caption = "G. Frac."
        Me.FACol9.DisplayFormat.FormatString = "c"
        Me.FACol9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol9.FieldName = "GastosFracciona"
        Me.FACol9.Name = "FACol9"
        Me.FACol9.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol9.Visible = True
        Me.FACol9.VisibleIndex = 6
        '
        'FACol10
        '
        Me.FACol10.Caption = "G. Bomb."
        Me.FACol10.DisplayFormat.FormatString = "c"
        Me.FACol10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol10.FieldName = "GastosBomberos"
        Me.FACol10.Name = "FACol10"
        Me.FACol10.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol10.Visible = True
        Me.FACol10.VisibleIndex = 7
        '
        'FACol4
        '
        Me.FACol4.Caption = "Otros Gastos"
        Me.FACol4.DisplayFormat.FormatString = "c"
        Me.FACol4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol4.FieldName = "Gastos"
        Me.FACol4.Name = "FACol4"
        Me.FACol4.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol4.Visible = True
        Me.FACol4.VisibleIndex = 8
        Me.FACol4.Width = 86
        '
        'FACol5
        '
        Me.FACol5.Caption = "Impuestos"
        Me.FACol5.DisplayFormat.FormatString = "c"
        Me.FACol5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol5.FieldName = "Impuestos"
        Me.FACol5.Name = "FACol5"
        Me.FACol5.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol5.Visible = True
        Me.FACol5.VisibleIndex = 9
        Me.FACol5.Width = 86
        '
        'FACol11
        '
        Me.FACol11.Caption = "Ret. Iva"
        Me.FACol11.DisplayFormat.FormatString = "c"
        Me.FACol11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol11.FieldName = "RetencionImpuestos"
        Me.FACol11.Name = "FACol11"
        Me.FACol11.Visible = True
        Me.FACol11.VisibleIndex = 10
        '
        'FACol6
        '
        Me.FACol6.Caption = "Total Factura"
        Me.FACol6.DisplayFormat.FormatString = "c"
        Me.FACol6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol6.FieldName = "Total"
        Me.FACol6.Name = "FACol6"
        Me.FACol6.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol6.Visible = True
        Me.FACol6.VisibleIndex = 11
        Me.FACol6.Width = 86
        '
        'FACol7
        '
        Me.FACol7.Caption = "Comisión"
        Me.FACol7.DisplayFormat.FormatString = "c"
        Me.FACol7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol7.FieldName = "Comision"
        Me.FACol7.Name = "FACol7"
        Me.FACol7.SummaryItem.DisplayFormat = "{0:c}"
        Me.FACol7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.FACol7.Visible = True
        Me.FACol7.VisibleIndex = 12
        Me.FACol7.Width = 96
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Venc. Tardio"
        Me.GridColumn4.FieldName = "VencimientoTardio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Prima Exenta"
        Me.GridColumn5.DisplayFormat.FormatString = "c"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "PrimaExenta"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'txtPorceComision
        '
        Me.txtPorceComision.CampoBusqueda = False
        Me.txtPorceComision.CampoEsLlave = False
        Me.txtPorceComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceComision.ControlBackColor = System.Drawing.Color.White
        Me.txtPorceComision.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceComision.FechaActual = False
        Me.txtPorceComision.Formato = "###0.0000"
        Me.txtPorceComision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtPorceComision.LabelText = "% Comisión"
        Me.txtPorceComision.LabelWidth = 100
        Me.txtPorceComision.Location = New System.Drawing.Point(12, 410)
        Me.txtPorceComision.MaxLength = 25
        Me.txtPorceComision.Name = "txtPorceComision"
        Me.txtPorceComision.NombreCampo = ""
        Me.txtPorceComision.Obligatorio = True
        Me.txtPorceComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceComision.Size = New System.Drawing.Size(169, 36)
        Me.txtPorceComision.SoloLectura = False
        Me.txtPorceComision.TabIndex = 24
        Me.txtPorceComision.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceComision.Valor = 0
        '
        'txtPrima
        '
        Me.txtPrima.CampoBusqueda = False
        Me.txtPrima.CampoEsLlave = False
        Me.txtPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrima.ControlBackColor = System.Drawing.Color.White
        Me.txtPrima.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrima.FechaActual = False
        Me.txtPrima.Formato = "$#,###0.00"
        Me.txtPrima.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtPrima.LabelText = "Prima Póliza"
        Me.txtPrima.LabelWidth = 100
        Me.txtPrima.Location = New System.Drawing.Point(12, 372)
        Me.txtPrima.MaxLength = 25
        Me.txtPrima.Name = "txtPrima"
        Me.txtPrima.NombreCampo = ""
        Me.txtPrima.Obligatorio = True
        Me.txtPrima.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrima.Size = New System.Drawing.Size(78, 36)
        Me.txtPrima.SoloLectura = False
        Me.txtPrima.TabIndex = 22
        Me.txtPrima.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrima.Valor = 0
        '
        'GridGastos
        '
        Me.GridGastos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGastos.ColumnasAdicionales = ""
        Me.GridGastos.Location = New System.Drawing.Point(184, 376)
        Me.GridGastos.MainView = Me.VistaGastos
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.NombreTabla = ""
        Me.GridGastos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemTextEdit1})
        Me.GridGastos.Size = New System.Drawing.Size(510, 70)
        Me.GridGastos.TabIndex = 18
        Me.GridGastos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaGastos})
        '
        'VistaGastos
        '
        Me.VistaGastos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.VistaGastos.GridControl = Me.GridGastos
        Me.VistaGastos.Name = "VistaGastos"
        Me.VistaGastos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaGastos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Gasto"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "IdGasto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 204
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Valor Gasto"
        Me.GridColumn2.DisplayFormat.FormatString = "c"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Valor"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 124
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Forma Pago"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn3.FieldName = "FormaPago"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 125
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(184, 126)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 2
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(184, 87)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscaPoliza.TabIndex = 28
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'txtNumTarjeta
        '
        Me.txtNumTarjeta.CampoBusqueda = False
        Me.txtNumTarjeta.CampoEsLlave = False
        Me.txtNumTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumTarjeta.ControlBackColor = System.Drawing.Color.White
        Me.txtNumTarjeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumTarjeta.FechaActual = False
        Me.txtNumTarjeta.Formato = ""
        Me.txtNumTarjeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNumTarjeta.LabelText = "Número Tarjeta Crédito"
        Me.txtNumTarjeta.LabelWidth = 125
        Me.txtNumTarjeta.Location = New System.Drawing.Point(12, 258)
        Me.txtNumTarjeta.MaxLength = 25
        Me.txtNumTarjeta.Name = "txtNumTarjeta"
        Me.txtNumTarjeta.NombreCampo = "IdAnexo"
        Me.txtNumTarjeta.Obligatorio = False
        Me.txtNumTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumTarjeta.Size = New System.Drawing.Size(170, 36)
        Me.txtNumTarjeta.SoloLectura = False
        Me.txtNumTarjeta.TabIndex = 13
        Me.txtNumTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumTarjeta.Valor = ""
        '
        'txtNombreTarjeta
        '
        Me.txtNombreTarjeta.CampoBusqueda = False
        Me.txtNombreTarjeta.CampoEsLlave = False
        Me.txtNombreTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreTarjeta.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreTarjeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreTarjeta.FechaActual = False
        Me.txtNombreTarjeta.Formato = ""
        Me.txtNombreTarjeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNombreTarjeta.LabelText = "Nombre Tarjeta Crédito"
        Me.txtNombreTarjeta.LabelWidth = 125
        Me.txtNombreTarjeta.Location = New System.Drawing.Point(184, 258)
        Me.txtNombreTarjeta.MaxLength = 150
        Me.txtNombreTarjeta.Name = "txtNombreTarjeta"
        Me.txtNombreTarjeta.NombreCampo = "IdAnexo"
        Me.txtNombreTarjeta.Obligatorio = False
        Me.txtNombreTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreTarjeta.Size = New System.Drawing.Size(338, 36)
        Me.txtNombreTarjeta.SoloLectura = False
        Me.txtNombreTarjeta.TabIndex = 14
        Me.txtNombreTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreTarjeta.Valor = ""
        '
        'txtVenceTarjeta
        '
        Me.txtVenceTarjeta.CampoBusqueda = False
        Me.txtVenceTarjeta.CampoEsLlave = False
        Me.txtVenceTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVenceTarjeta.ControlBackColor = System.Drawing.Color.White
        Me.txtVenceTarjeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVenceTarjeta.FechaActual = False
        Me.txtVenceTarjeta.Formato = ""
        Me.txtVenceTarjeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtVenceTarjeta.LabelText = "Vencimiento Tarjeta Crédito"
        Me.txtVenceTarjeta.LabelWidth = 125
        Me.txtVenceTarjeta.Location = New System.Drawing.Point(528, 258)
        Me.txtVenceTarjeta.MaxLength = 25
        Me.txtVenceTarjeta.Name = "txtVenceTarjeta"
        Me.txtVenceTarjeta.NombreCampo = "IdAnexo"
        Me.txtVenceTarjeta.Obligatorio = False
        Me.txtVenceTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVenceTarjeta.Size = New System.Drawing.Size(166, 36)
        Me.txtVenceTarjeta.SoloLectura = False
        Me.txtVenceTarjeta.TabIndex = 15
        Me.txtVenceTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtVenceTarjeta.Valor = ""
        '
        'txtReferencia
        '
        Me.txtReferencia.CampoBusqueda = False
        Me.txtReferencia.CampoEsLlave = False
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtReferencia.ControlBackColor = System.Drawing.Color.White
        Me.txtReferencia.ControlForeColor = System.Drawing.Color.Black
        Me.txtReferencia.FechaActual = False
        Me.txtReferencia.Formato = ""
        Me.txtReferencia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtReferencia.LabelText = "Referencia"
        Me.txtReferencia.LabelWidth = 125
        Me.txtReferencia.Location = New System.Drawing.Point(356, 220)
        Me.txtReferencia.MaxLength = 500
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.NombreCampo = "IdAnexo"
        Me.txtReferencia.Obligatorio = True
        Me.txtReferencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReferencia.Size = New System.Drawing.Size(166, 36)
        Me.txtReferencia.SoloLectura = False
        Me.txtReferencia.TabIndex = 11
        Me.txtReferencia.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtReferencia.Valor = ""
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CampoBusqueda = False
        Me.txtObservaciones.CampoEsLlave = False
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservaciones.ControlBackColor = System.Drawing.Color.White
        Me.txtObservaciones.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.FechaActual = False
        Me.txtObservaciones.Formato = ""
        Me.txtObservaciones.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtObservaciones.LabelText = "Observaciones"
        Me.txtObservaciones.LabelWidth = 125
        Me.txtObservaciones.Location = New System.Drawing.Point(528, 220)
        Me.txtObservaciones.MaxLength = 1000
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = "IdAnexo"
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(166, 36)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'txtIdAvisoCobro
        '
        Me.txtIdAvisoCobro.CampoBusqueda = True
        Me.txtIdAvisoCobro.CampoEsLlave = True
        Me.txtIdAvisoCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAvisoCobro.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAvisoCobro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAvisoCobro.FechaActual = False
        Me.txtIdAvisoCobro.Formato = ""
        Me.txtIdAvisoCobro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdAvisoCobro.LabelText = "NUMERO AVISO DE COBRO"
        Me.txtIdAvisoCobro.LabelWidth = 125
        Me.txtIdAvisoCobro.Location = New System.Drawing.Point(141, 41)
        Me.txtIdAvisoCobro.MaxLength = 25
        Me.txtIdAvisoCobro.Name = "txtIdAvisoCobro"
        Me.txtIdAvisoCobro.NombreCampo = "IdPoliza"
        Me.txtIdAvisoCobro.Obligatorio = False
        Me.txtIdAvisoCobro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAvisoCobro.Size = New System.Drawing.Size(132, 36)
        Me.txtIdAvisoCobro.SoloLectura = False
        Me.txtIdAvisoCobro.TabIndex = 27
        Me.txtIdAvisoCobro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAvisoCobro.Valor = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(299, 587)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(117, 36)
        Me.btnImprimir.TabIndex = 28
        Me.btnImprimir.Text = "&Imprimir Aviso Cobro"
        '
        'cboIdRamo
        '
        Me.cboIdRamo.CampoAutoCompletar = 0
        Me.cboIdRamo.CampoBusqueda = True
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = True
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 53125
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboIdRamo.LabelText = "Ramo"
        Me.cboIdRamo.LabelWidth = 125
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(275, 37)
        Me.cboIdRamo.MostrarBusquedaColumnas = False
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdRamo"
        Me.cboIdRamo.Obligatorio = True
        Me.cboIdRamo.Query = "select IdRamo, NombreRamo from RamoSeguros order by NombreRamo"
        Me.cboIdRamo.SelectIndex = 0
        Me.cboIdRamo.Size = New System.Drawing.Size(192, 38)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 26
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.CampoBusqueda = False
        Me.txtMotivoAnulacion.CampoEsLlave = False
        Me.txtMotivoAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoAnulacion.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivoAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoAnulacion.FechaActual = False
        Me.txtMotivoAnulacion.Formato = ""
        Me.txtMotivoAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtMotivoAnulacion.LabelText = "Motivo Anulación"
        Me.txtMotivoAnulacion.LabelWidth = 125
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(546, 41)
        Me.txtMotivoAnulacion.MaxLength = 250
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.NombreCampo = "MotivoAnulacion"
        Me.txtMotivoAnulacion.Obligatorio = False
        Me.txtMotivoAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(148, 36)
        Me.txtMotivoAnulacion.SoloLectura = False
        Me.txtMotivoAnulacion.TabIndex = 33
        Me.txtMotivoAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoAnulacion.Valor = ""
        '
        'cboAvisoInterno
        '
        Me.cboAvisoInterno.CampoAutoCompletar = 0
        Me.cboAvisoInterno.CampoBusqueda = False
        Me.cboAvisoInterno.CampoDisplay = 1
        Me.cboAvisoInterno.CampoEsLlave = False
        Me.cboAvisoInterno.CampoValor = 0
        Me.cboAvisoInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAvisoInterno.ControlBackColor = System.Drawing.Color.White
        Me.cboAvisoInterno.ControlForeColor = System.Drawing.Color.Black
        Me.cboAvisoInterno.FilasVisibles = 53125
        Me.cboAvisoInterno.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboAvisoInterno.LabelText = "Aviso Interno"
        Me.cboAvisoInterno.LabelWidth = 125
        Me.cboAvisoInterno.Lista = "S Si|N No"
        Me.cboAvisoInterno.Location = New System.Drawing.Point(472, 39)
        Me.cboAvisoInterno.MostrarBusquedaColumnas = False
        Me.cboAvisoInterno.Name = "cboAvisoInterno"
        Me.cboAvisoInterno.NombreCampo = "AvisoInterno"
        Me.cboAvisoInterno.Obligatorio = False
        Me.cboAvisoInterno.Query = ""
        Me.cboAvisoInterno.SelectIndex = 0
        Me.cboAvisoInterno.Size = New System.Drawing.Size(70, 38)
        Me.cboAvisoInterno.SoloLectura = False
        Me.cboAvisoInterno.StringConection = ""
        Me.cboAvisoInterno.TabIndex = 34
        Me.cboAvisoInterno.TextoNuevoItem = ""
        Me.cboAvisoInterno.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAvisoInterno.Valor = ""
        '
        'txtFechaInicialPago
        '
        Me.txtFechaInicialPago.CampoBusqueda = False
        Me.txtFechaInicialPago.CampoEsLlave = False
        Me.txtFechaInicialPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInicialPago.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaInicialPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInicialPago.FechaActual = True
        Me.txtFechaInicialPago.Formato = "dd/MMM/yyyy"
        Me.txtFechaInicialPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtFechaInicialPago.LabelText = "Fecha Inicial de Pago"
        Me.txtFechaInicialPago.LabelWidth = 125
        Me.txtFechaInicialPago.Location = New System.Drawing.Point(12, 334)
        Me.txtFechaInicialPago.MaxLength = 0
        Me.txtFechaInicialPago.Name = "txtFechaInicialPago"
        Me.txtFechaInicialPago.NombreCampo = "FechaInicialPago"
        Me.txtFechaInicialPago.Obligatorio = True
        Me.txtFechaInicialPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInicialPago.Size = New System.Drawing.Size(166, 36)
        Me.txtFechaInicialPago.SoloLectura = False
        Me.txtFechaInicialPago.TabIndex = 19
        Me.txtFechaInicialPago.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInicialPago.Valor = Nothing
        '
        'cboAplicarRetencionIva
        '
        Me.cboAplicarRetencionIva.CampoAutoCompletar = 0
        Me.cboAplicarRetencionIva.CampoBusqueda = False
        Me.cboAplicarRetencionIva.CampoDisplay = 1
        Me.cboAplicarRetencionIva.CampoEsLlave = False
        Me.cboAplicarRetencionIva.CampoValor = 0
        Me.cboAplicarRetencionIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAplicarRetencionIva.ControlBackColor = System.Drawing.Color.White
        Me.cboAplicarRetencionIva.ControlForeColor = System.Drawing.Color.Black
        Me.cboAplicarRetencionIva.FilasVisibles = 53125
        Me.cboAplicarRetencionIva.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboAplicarRetencionIva.LabelText = "Aplicar Retención IVA"
        Me.cboAplicarRetencionIva.LabelWidth = 125
        Me.cboAplicarRetencionIva.Lista = "S Si|N No"
        Me.cboAplicarRetencionIva.Location = New System.Drawing.Point(184, 332)
        Me.cboAplicarRetencionIva.MostrarBusquedaColumnas = False
        Me.cboAplicarRetencionIva.Name = "cboAplicarRetencionIva"
        Me.cboAplicarRetencionIva.NombreCampo = "AplicarRetencionIva"
        Me.cboAplicarRetencionIva.Obligatorio = False
        Me.cboAplicarRetencionIva.Query = ""
        Me.cboAplicarRetencionIva.SelectIndex = 0
        Me.cboAplicarRetencionIva.Size = New System.Drawing.Size(166, 38)
        Me.cboAplicarRetencionIva.SoloLectura = False
        Me.cboAplicarRetencionIva.StringConection = ""
        Me.cboAplicarRetencionIva.TabIndex = 20
        Me.cboAplicarRetencionIva.TextoNuevoItem = ""
        Me.cboAplicarRetencionIva.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAplicarRetencionIva.Valor = ""
        '
        'txtFechaNotificacion
        '
        Me.txtFechaNotificacion.CampoBusqueda = False
        Me.txtFechaNotificacion.CampoEsLlave = False
        Me.txtFechaNotificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaNotificacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaNotificacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaNotificacion.FechaActual = True
        Me.txtFechaNotificacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaNotificacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtFechaNotificacion.LabelText = "Fecha Notificación Aseguradora"
        Me.txtFechaNotificacion.LabelWidth = 125
        Me.txtFechaNotificacion.Location = New System.Drawing.Point(356, 334)
        Me.txtFechaNotificacion.MaxLength = 0
        Me.txtFechaNotificacion.Name = "txtFechaNotificacion"
        Me.txtFechaNotificacion.NombreCampo = "FechaNotificacion"
        Me.txtFechaNotificacion.Obligatorio = False
        Me.txtFechaNotificacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaNotificacion.Size = New System.Drawing.Size(166, 36)
        Me.txtFechaNotificacion.SoloLectura = False
        Me.txtFechaNotificacion.TabIndex = 21
        Me.txtFechaNotificacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaNotificacion.Valor = Nothing
        '
        'txtUsuarioGrabacion
        '
        Me.txtUsuarioGrabacion.CampoBusqueda = False
        Me.txtUsuarioGrabacion.CampoEsLlave = False
        Me.txtUsuarioGrabacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioGrabacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUsuarioGrabacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioGrabacion.FechaActual = False
        Me.txtUsuarioGrabacion.Formato = ""
        Me.txtUsuarioGrabacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtUsuarioGrabacion.LabelText = "Usuario Grabación"
        Me.txtUsuarioGrabacion.LabelWidth = 125
        Me.txtUsuarioGrabacion.Location = New System.Drawing.Point(528, 334)
        Me.txtUsuarioGrabacion.MaxLength = 25
        Me.txtUsuarioGrabacion.Name = "txtUsuarioGrabacion"
        Me.txtUsuarioGrabacion.NombreCampo = "UsuarioGrabacion"
        Me.txtUsuarioGrabacion.Obligatorio = False
        Me.txtUsuarioGrabacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioGrabacion.Size = New System.Drawing.Size(166, 36)
        Me.txtUsuarioGrabacion.SoloLectura = True
        Me.txtUsuarioGrabacion.TabIndex = 37
        Me.txtUsuarioGrabacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioGrabacion.Valor = ""
        '
        'chkImpPP
        '
        Me.chkImpPP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImpPP.Location = New System.Drawing.Point(299, 565)
        Me.chkImpPP.Name = "chkImpPP"
        Me.chkImpPP.Properties.Appearance.Options.UseTextOptions = True
        Me.chkImpPP.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkImpPP.Properties.Caption = "Imprimir Sólo Pend."
        Me.chkImpPP.Size = New System.Drawing.Size(116, 19)
        Me.chkImpPP.TabIndex = 38
        '
        'btnReactivar
        '
        Me.btnReactivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReactivar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnReactivar.Appearance.Options.UseFont = True
        Me.btnReactivar.Appearance.Options.UseTextOptions = True
        Me.btnReactivar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnReactivar.Image = CType(resources.GetObject("btnReactivar.Image"), System.Drawing.Image)
        Me.btnReactivar.Location = New System.Drawing.Point(98, 587)
        Me.btnReactivar.Name = "btnReactivar"
        Me.btnReactivar.Size = New System.Drawing.Size(107, 36)
        Me.btnReactivar.TabIndex = 39
        Me.btnReactivar.Text = "&Reactivar AC"
        '
        'txtPrimaExenta
        '
        Me.txtPrimaExenta.CampoBusqueda = False
        Me.txtPrimaExenta.CampoEsLlave = False
        Me.txtPrimaExenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaExenta.ControlBackColor = System.Drawing.Color.White
        Me.txtPrimaExenta.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaExenta.FechaActual = False
        Me.txtPrimaExenta.Formato = "$#,###0.00"
        Me.txtPrimaExenta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtPrimaExenta.LabelText = "Prima Exenta"
        Me.txtPrimaExenta.LabelWidth = 100
        Me.txtPrimaExenta.Location = New System.Drawing.Point(97, 372)
        Me.txtPrimaExenta.MaxLength = 25
        Me.txtPrimaExenta.Name = "txtPrimaExenta"
        Me.txtPrimaExenta.NombreCampo = ""
        Me.txtPrimaExenta.Obligatorio = True
        Me.txtPrimaExenta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaExenta.Size = New System.Drawing.Size(78, 36)
        Me.txtPrimaExenta.SoloLectura = False
        Me.txtPrimaExenta.TabIndex = 23
        Me.txtPrimaExenta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaExenta.Valor = 0
        '
        'cboAtencionA
        '
        Me.cboAtencionA.CampoAutoCompletar = 0
        Me.cboAtencionA.CampoBusqueda = False
        Me.cboAtencionA.CampoDisplay = 1
        Me.cboAtencionA.CampoEsLlave = False
        Me.cboAtencionA.CampoValor = 0
        Me.cboAtencionA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAtencionA.ControlBackColor = System.Drawing.Color.White
        Me.cboAtencionA.ControlForeColor = System.Drawing.Color.Black
        Me.cboAtencionA.FilasVisibles = 0
        Me.cboAtencionA.LabelOrietation = STIControles.stiGridComboBox.LOrientacion.Izquierda
        Me.cboAtencionA.LabelText = "Atención a:"
        Me.cboAtencionA.LabelWidth = 75
        Me.cboAtencionA.Lista = ""
        Me.cboAtencionA.Location = New System.Drawing.Point(408, 156)
        Me.cboAtencionA.Name = "cboAtencionA"
        Me.cboAtencionA.NombreCampo = "IdContacto"
        Me.cboAtencionA.Obligatorio = False
        Me.cboAtencionA.Query = "select idcontacto, nombre, cargo from ClientesContactos where idcliente = ''"
        Me.cboAtencionA.SelectIndex = -2147483648
        Me.cboAtencionA.Size = New System.Drawing.Size(291, 20)
        Me.cboAtencionA.SoloLectura = False
        Me.cboAtencionA.StringConection = ""
        Me.cboAtencionA.TabIndex = 3
        Me.cboAtencionA.TextoNuevoItem = ""
        Me.cboAtencionA.TipoDato = STIControles.stiGridComboBox.TipoContenido.Texto
        Me.cboAtencionA.Valor = ""
        '
        'txtCuentaBancaria
        '
        Me.txtCuentaBancaria.CampoBusqueda = False
        Me.txtCuentaBancaria.CampoEsLlave = False
        Me.txtCuentaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCuentaBancaria.ControlBackColor = System.Drawing.Color.White
        Me.txtCuentaBancaria.ControlForeColor = System.Drawing.Color.Black
        Me.txtCuentaBancaria.FechaActual = False
        Me.txtCuentaBancaria.Formato = ""
        Me.txtCuentaBancaria.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtCuentaBancaria.LabelText = "Cuenta Bancaria"
        Me.txtCuentaBancaria.LabelWidth = 125
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(12, 296)
        Me.txtCuentaBancaria.MaxLength = 25
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.NombreCampo = "CuentaBancaria"
        Me.txtCuentaBancaria.Obligatorio = False
        Me.txtCuentaBancaria.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(170, 36)
        Me.txtCuentaBancaria.SoloLectura = False
        Me.txtCuentaBancaria.TabIndex = 16
        Me.txtCuentaBancaria.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCuentaBancaria.Valor = ""
        '
        'txtNombreCuentaHabiente
        '
        Me.txtNombreCuentaHabiente.CampoBusqueda = False
        Me.txtNombreCuentaHabiente.CampoEsLlave = False
        Me.txtNombreCuentaHabiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCuentaHabiente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCuentaHabiente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCuentaHabiente.FechaActual = False
        Me.txtNombreCuentaHabiente.Formato = ""
        Me.txtNombreCuentaHabiente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNombreCuentaHabiente.LabelText = "Nombre CuentaHabiente"
        Me.txtNombreCuentaHabiente.LabelWidth = 125
        Me.txtNombreCuentaHabiente.Location = New System.Drawing.Point(186, 296)
        Me.txtNombreCuentaHabiente.MaxLength = 100
        Me.txtNombreCuentaHabiente.Name = "txtNombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.NombreCampo = "IdAnexo"
        Me.txtNombreCuentaHabiente.Obligatorio = False
        Me.txtNombreCuentaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCuentaHabiente.Size = New System.Drawing.Size(338, 36)
        Me.txtNombreCuentaHabiente.SoloLectura = False
        Me.txtNombreCuentaHabiente.TabIndex = 17
        Me.txtNombreCuentaHabiente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCuentaHabiente.Valor = ""
        '
        'cboIdBanco
        '
        Me.cboIdBanco.CampoAutoCompletar = 0
        Me.cboIdBanco.CampoBusqueda = False
        Me.cboIdBanco.CampoDisplay = 1
        Me.cboIdBanco.CampoEsLlave = False
        Me.cboIdBanco.CampoValor = 0
        Me.cboIdBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdBanco.ControlBackColor = System.Drawing.Color.White
        Me.cboIdBanco.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdBanco.FilasVisibles = 136000
        Me.cboIdBanco.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboIdBanco.LabelText = "Banco"
        Me.cboIdBanco.LabelWidth = 125
        Me.cboIdBanco.Lista = ""
        Me.cboIdBanco.Location = New System.Drawing.Point(528, 296)
        Me.cboIdBanco.MostrarBusquedaColumnas = False
        Me.cboIdBanco.Name = "cboIdBanco"
        Me.cboIdBanco.NombreCampo = "IdBanco"
        Me.cboIdBanco.Obligatorio = False
        Me.cboIdBanco.Query = "select IdBanco as Id, NombreBanco as Banco from Bancos"
        Me.cboIdBanco.SelectIndex = 0
        Me.cboIdBanco.Size = New System.Drawing.Size(166, 38)
        Me.cboIdBanco.SoloLectura = False
        Me.cboIdBanco.StringConection = ""
        Me.cboIdBanco.TabIndex = 18
        Me.cboIdBanco.TextoNuevoItem = ""
        Me.cboIdBanco.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdBanco.Valor = ""
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
        Me.cboFlujo.FilasVisibles = 3166
        Me.cboFlujo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboFlujo.LabelText = "Flujo Correspondencia"
        Me.cboFlujo.LabelWidth = 120
        Me.cboFlujo.Lista = ""
        Me.cboFlujo.Location = New System.Drawing.Point(12, 156)
        Me.cboFlujo.MostrarBusquedaColumnas = True
        Me.cboFlujo.Name = "cboFlujo"
        Me.cboFlujo.NombreCampo = "IdFlujoDoc"
        Me.cboFlujo.Obligatorio = False
        Me.cboFlujo.Query = resources.GetString("cboFlujo.Query")
        Me.cboFlujo.SelectIndex = 0
        Me.cboFlujo.Size = New System.Drawing.Size(393, 20)
        Me.cboFlujo.SoloLectura = False
        Me.cboFlujo.StringConection = ""
        Me.cboFlujo.TabIndex = 4
        Me.cboFlujo.TextoNuevoItem = "<Nuevo Flujo>"
        Me.cboFlujo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboFlujo.Valor = ""
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 305
        Me.ClientSize = New System.Drawing.Size(725, 623)
        Me.Controls.Add(Me.cboFlujo)
        Me.Controls.Add(Me.cboIdBanco)
        Me.Controls.Add(Me.txtNombreCuentaHabiente)
        Me.Controls.Add(Me.txtCuentaBancaria)
        Me.Controls.Add(Me.cboAtencionA)
        Me.Controls.Add(Me.txtPrimaExenta)
        Me.Controls.Add(Me.btnReactivar)
        Me.Controls.Add(Me.chkImpPP)
        Me.Controls.Add(Me.txtUsuarioGrabacion)
        Me.Controls.Add(Me.txtFechaNotificacion)
        Me.Controls.Add(Me.txtFechaInicialPago)
        Me.Controls.Add(Me.txtMotivoAnulacion)
        Me.Controls.Add(Me.txtIdAvisoCobro)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.txtVenceTarjeta)
        Me.Controls.Add(Me.txtNombreTarjeta)
        Me.Controls.Add(Me.txtNumTarjeta)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.GridGastos)
        Me.Controls.Add(Me.txtPrima)
        Me.Controls.Add(Me.txtPorceComision)
        Me.Controls.Add(Me.GridFacturas)
        Me.Controls.Add(Me.txtNumFacturaInicial)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.cboTipoFactura)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdAnexo)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.cboAvisoInterno)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.cboAplicarRetencionIva)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.cboIdRamo)
        Me.Name = "Facturacion"
        Me.Text = "Facturación Automática de Primas de Seguros"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.cboIdRamo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.cboAplicarRetencionIva, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.cboAvisoInterno, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdAnexo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.cboTipoFactura, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboFormaPago, 0)
        Me.Controls.SetChildIndex(Me.txtNumFacturaInicial, 0)
        Me.Controls.SetChildIndex(Me.GridFacturas, 0)
        Me.Controls.SetChildIndex(Me.txtPorceComision, 0)
        Me.Controls.SetChildIndex(Me.txtPrima, 0)
        Me.Controls.SetChildIndex(Me.GridGastos, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtNumTarjeta, 0)
        Me.Controls.SetChildIndex(Me.txtNombreTarjeta, 0)
        Me.Controls.SetChildIndex(Me.txtVenceTarjeta, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtIdAvisoCobro, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoAnulacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaInicialPago, 0)
        Me.Controls.SetChildIndex(Me.txtFechaNotificacion, 0)
        Me.Controls.SetChildIndex(Me.txtUsuarioGrabacion, 0)
        Me.Controls.SetChildIndex(Me.chkImpPP, 0)
        Me.Controls.SetChildIndex(Me.btnReactivar, 0)
        Me.Controls.SetChildIndex(Me.txtPrimaExenta, 0)
        Me.Controls.SetChildIndex(Me.cboAtencionA, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaBancaria, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCuentaHabiente, 0)
        Me.Controls.SetChildIndex(Me.cboIdBanco, 0)
        Me.Controls.SetChildIndex(Me.cboFlujo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpPP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents cboTipoFactura As STIControles.stiComboBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtIdAnexo As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboFormaPago As STIControles.stiComboBox
    Friend WithEvents txtNumFacturaInicial As STIControles.stiTextBox
    Friend WithEvents GridFacturas As STIControles.stiGrid
    Friend WithEvents VistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FACol1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPorceComision As STIControles.stiTextBox
    Friend WithEvents txtPrima As STIControles.stiTextBox
    Friend WithEvents GridGastos As STIControles.stiGrid
    Friend WithEvents VistaGastos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumTarjeta As STIControles.stiTextBox
    Friend WithEvents txtNombreTarjeta As STIControles.stiTextBox
    Friend WithEvents txtVenceTarjeta As STIControles.stiTextBox
    Friend WithEvents txtReferencia As STIControles.stiTextBox
    Friend WithEvents txtObservaciones As STIControles.stiTextBox
    Friend WithEvents txtIdAvisoCobro As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FACol8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents txtMotivoAnulacion As STIControles.stiTextBox
    Friend WithEvents cboAvisoInterno As STIControles.stiComboBox
    Friend WithEvents txtFechaInicialPago As STIControles.stiTextBox
    Friend WithEvents cboAplicarRetencionIva As STIControles.stiComboBox
    Friend WithEvents FACol11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaNotificacion As STIControles.stiTextBox
    Friend WithEvents txtUsuarioGrabacion As STIControles.stiTextBox
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkImpPP As DevExpress.XtraEditors.CheckEdit
    Public WithEvents btnReactivar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPrimaExenta As STIControles.stiTextBox
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAtencionA As STIControles.stiGridComboBox
    Friend WithEvents txtCuentaBancaria As STIControles.stiTextBox
    Friend WithEvents txtNombreCuentaHabiente As STIControles.stiTextBox
    Friend WithEvents cboIdBanco As STIControles.stiComboBox
    Friend WithEvents cboFlujo As STIControles.stiComboBox

End Class
