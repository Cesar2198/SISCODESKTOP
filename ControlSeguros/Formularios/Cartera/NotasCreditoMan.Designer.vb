<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasCreditoMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotasCreditoMan))
        Me.txtIdNotaCredito = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtNumeroFactura = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtPrimaNetaNota = New STIControles.stiTextBox
        Me.txtGastosEmiNota = New STIControles.stiTextBox
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.txtGastosFinNota = New STIControles.stiTextBox
        Me.txtGastosBombNota = New STIControles.stiTextBox
        Me.txtImpuestosNota = New STIControles.stiTextBox
        Me.txtTotalNota = New STIControles.stiTextBox
        Me.txtGastosNota = New STIControles.stiTextBox
        Me.txtFechaNotaCredito = New STIControles.stiTextBox
        Me.txtObservaciones = New STIControles.stiTextBox
        Me.btnBuscarFactura = New DevExpress.XtraEditors.SimpleButton
        Me.txtComisionNota = New STIControles.stiTextBox
        Me.txtPorcentajeComiFact = New STIControles.stiTextBox
        Me.cboIdTipoIngreso = New STIControles.stiComboBox
        Me.txtDescripcionReintegro = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnAnulacionExiste = New DevExpress.XtraEditors.SimpleButton
        Me.txtRetIva = New STIControles.stiTextBox
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaAnula = New STIControles.stiTextBox
        Me.cboFlujo = New STIControles.stiComboBox
        Me.cboAtencionA = New STIControles.stiGridComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(569, 410)
        Me.btnAyuda.TabIndex = 20
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(288, 410)
        Me.btnBuscar.TabIndex = 18
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(5, 410)
        Me.btnNuevo.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(97, 410)
        Me.btnGuardar.TabIndex = 15
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(661, 410)
        Me.btnSalir.TabIndex = 21
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(477, 410)
        Me.btnEliminar.TabIndex = 19
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(616, 74)
        Me.lblNombreFormulario.TabIndex = 25
        Me.lblNombreFormulario.Text = "Ingreso de Notas de Crédito"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(93, 436)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 30
        Me.btnGuardarComo.Visible = False
        '
        'txtIdNotaCredito
        '
        Me.txtIdNotaCredito.CampoBusqueda = True
        Me.txtIdNotaCredito.CampoEsLlave = True
        Me.txtIdNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdNotaCredito.ControlBackColor = System.Drawing.Color.White
        Me.txtIdNotaCredito.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdNotaCredito.FechaActual = False
        Me.txtIdNotaCredito.Formato = ""
        Me.txtIdNotaCredito.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdNotaCredito.LabelText = "Núm. Nota Crédito"
        Me.txtIdNotaCredito.LabelWidth = 125
        Me.txtIdNotaCredito.Location = New System.Drawing.Point(7, 81)
        Me.txtIdNotaCredito.MaxLength = 25
        Me.txtIdNotaCredito.Name = "txtIdNotaCredito"
        Me.txtIdNotaCredito.NombreCampo = "IdNotaCredito"
        Me.txtIdNotaCredito.Obligatorio = True
        Me.txtIdNotaCredito.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdNotaCredito.Size = New System.Drawing.Size(130, 36)
        Me.txtIdNotaCredito.SoloLectura = False
        Me.txtIdNotaCredito.TabIndex = 0
        Me.txtIdNotaCredito.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdNotaCredito.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = False
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 1237
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 125
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(496, 118)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(159, 38)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 25
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.CampoBusqueda = True
        Me.txtNumeroFactura.CampoEsLlave = True
        Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroFactura.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroFactura.FechaActual = False
        Me.txtNumeroFactura.Formato = "#####0"
        Me.txtNumeroFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNumeroFactura.LabelText = "Número Factura"
        Me.txtNumeroFactura.LabelWidth = 125
        Me.txtNumeroFactura.Location = New System.Drawing.Point(7, 120)
        Me.txtNumeroFactura.MaxLength = 0
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.NombreCampo = "NumeroFactura"
        Me.txtNumeroFactura.Obligatorio = True
        Me.txtNumeroFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroFactura.Size = New System.Drawing.Size(159, 36)
        Me.txtNumeroFactura.SoloLectura = False
        Me.txtNumeroFactura.TabIndex = 22
        Me.txtNumeroFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumeroFactura.Valor = 0
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = False
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 125
        Me.txtIdPoliza.Location = New System.Drawing.Point(169, 120)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(159, 36)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 23
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtPrimaNetaNota
        '
        Me.txtPrimaNetaNota.CampoBusqueda = False
        Me.txtPrimaNetaNota.CampoEsLlave = False
        Me.txtPrimaNetaNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimaNetaNota.ControlBackColor = System.Drawing.Color.White
        Me.txtPrimaNetaNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimaNetaNota.FechaActual = False
        Me.txtPrimaNetaNota.Formato = "#,###0.00"
        Me.txtPrimaNetaNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtPrimaNetaNota.LabelText = "Prima Neta"
        Me.txtPrimaNetaNota.LabelWidth = 125
        Me.txtPrimaNetaNota.Location = New System.Drawing.Point(8, 254)
        Me.txtPrimaNetaNota.MaxLength = 0
        Me.txtPrimaNetaNota.Name = "txtPrimaNetaNota"
        Me.txtPrimaNetaNota.NombreCampo = "PrimaNetaNota"
        Me.txtPrimaNetaNota.Obligatorio = False
        Me.txtPrimaNetaNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaNetaNota.Size = New System.Drawing.Size(87, 36)
        Me.txtPrimaNetaNota.SoloLectura = False
        Me.txtPrimaNetaNota.TabIndex = 3
        Me.txtPrimaNetaNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimaNetaNota.Valor = 0
        '
        'txtGastosEmiNota
        '
        Me.txtGastosEmiNota.CampoBusqueda = False
        Me.txtGastosEmiNota.CampoEsLlave = False
        Me.txtGastosEmiNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosEmiNota.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosEmiNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosEmiNota.FechaActual = False
        Me.txtGastosEmiNota.Formato = "#,###0.00"
        Me.txtGastosEmiNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtGastosEmiNota.LabelText = "Gastos Emisión"
        Me.txtGastosEmiNota.LabelWidth = 125
        Me.txtGastosEmiNota.Location = New System.Drawing.Point(101, 254)
        Me.txtGastosEmiNota.MaxLength = 0
        Me.txtGastosEmiNota.Name = "txtGastosEmiNota"
        Me.txtGastosEmiNota.NombreCampo = "GastosEmiNota"
        Me.txtGastosEmiNota.Obligatorio = False
        Me.txtGastosEmiNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosEmiNota.Size = New System.Drawing.Size(87, 36)
        Me.txtGastosEmiNota.SoloLectura = False
        Me.txtGastosEmiNota.TabIndex = 4
        Me.txtGastosEmiNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosEmiNota.Valor = 0
        '
        'cboIdRamo
        '
        Me.cboIdRamo.CampoAutoCompletar = 0
        Me.cboIdRamo.CampoBusqueda = True
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = False
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 1237
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboIdRamo.LabelText = "Ramo"
        Me.cboIdRamo.LabelWidth = 125
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(332, 118)
        Me.cboIdRamo.MostrarBusquedaColumnas = False
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdRamo"
        Me.cboIdRamo.Obligatorio = True
        Me.cboIdRamo.Query = "select IdRamo, NombreRamo from RamoSeguros"
        Me.cboIdRamo.SelectIndex = 0
        Me.cboIdRamo.Size = New System.Drawing.Size(159, 38)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 24
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'txtGastosFinNota
        '
        Me.txtGastosFinNota.CampoBusqueda = False
        Me.txtGastosFinNota.CampoEsLlave = False
        Me.txtGastosFinNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosFinNota.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosFinNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosFinNota.FechaActual = False
        Me.txtGastosFinNota.Formato = "#,###0.00"
        Me.txtGastosFinNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtGastosFinNota.LabelText = "Gastos Fracciona."
        Me.txtGastosFinNota.LabelWidth = 125
        Me.txtGastosFinNota.Location = New System.Drawing.Point(194, 254)
        Me.txtGastosFinNota.MaxLength = 0
        Me.txtGastosFinNota.Name = "txtGastosFinNota"
        Me.txtGastosFinNota.NombreCampo = "GastosFinNota"
        Me.txtGastosFinNota.Obligatorio = False
        Me.txtGastosFinNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosFinNota.Size = New System.Drawing.Size(87, 36)
        Me.txtGastosFinNota.SoloLectura = False
        Me.txtGastosFinNota.TabIndex = 5
        Me.txtGastosFinNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosFinNota.Valor = 0
        '
        'txtGastosBombNota
        '
        Me.txtGastosBombNota.CampoBusqueda = False
        Me.txtGastosBombNota.CampoEsLlave = False
        Me.txtGastosBombNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosBombNota.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosBombNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosBombNota.FechaActual = False
        Me.txtGastosBombNota.Formato = "#,###0.00"
        Me.txtGastosBombNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtGastosBombNota.LabelText = "Gastos Bomberos"
        Me.txtGastosBombNota.LabelWidth = 125
        Me.txtGastosBombNota.Location = New System.Drawing.Point(287, 254)
        Me.txtGastosBombNota.MaxLength = 0
        Me.txtGastosBombNota.Name = "txtGastosBombNota"
        Me.txtGastosBombNota.NombreCampo = "GastosBombNota"
        Me.txtGastosBombNota.Obligatorio = False
        Me.txtGastosBombNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosBombNota.Size = New System.Drawing.Size(87, 36)
        Me.txtGastosBombNota.SoloLectura = False
        Me.txtGastosBombNota.TabIndex = 6
        Me.txtGastosBombNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosBombNota.Valor = 0
        '
        'txtImpuestosNota
        '
        Me.txtImpuestosNota.CampoBusqueda = False
        Me.txtImpuestosNota.CampoEsLlave = False
        Me.txtImpuestosNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtImpuestosNota.ControlBackColor = System.Drawing.Color.White
        Me.txtImpuestosNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtImpuestosNota.FechaActual = False
        Me.txtImpuestosNota.Formato = "#,###0.00"
        Me.txtImpuestosNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtImpuestosNota.LabelText = "Iva"
        Me.txtImpuestosNota.LabelWidth = 125
        Me.txtImpuestosNota.Location = New System.Drawing.Point(473, 254)
        Me.txtImpuestosNota.MaxLength = 0
        Me.txtImpuestosNota.Name = "txtImpuestosNota"
        Me.txtImpuestosNota.NombreCampo = "ImpuestosNota"
        Me.txtImpuestosNota.Obligatorio = False
        Me.txtImpuestosNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtImpuestosNota.Size = New System.Drawing.Size(87, 36)
        Me.txtImpuestosNota.SoloLectura = False
        Me.txtImpuestosNota.TabIndex = 8
        Me.txtImpuestosNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtImpuestosNota.Valor = 0
        '
        'txtTotalNota
        '
        Me.txtTotalNota.CampoBusqueda = False
        Me.txtTotalNota.CampoEsLlave = False
        Me.txtTotalNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalNota.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalNota.FechaActual = False
        Me.txtTotalNota.Formato = "#,###0.00"
        Me.txtTotalNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTotalNota.LabelText = "Total Nota Crédito"
        Me.txtTotalNota.LabelWidth = 125
        Me.txtTotalNota.Location = New System.Drawing.Point(659, 254)
        Me.txtTotalNota.MaxLength = 0
        Me.txtTotalNota.Name = "txtTotalNota"
        Me.txtTotalNota.NombreCampo = "TotalNota"
        Me.txtTotalNota.Obligatorio = False
        Me.txtTotalNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalNota.Size = New System.Drawing.Size(87, 36)
        Me.txtTotalNota.SoloLectura = False
        Me.txtTotalNota.TabIndex = 10
        Me.txtTotalNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalNota.Valor = 0
        '
        'txtGastosNota
        '
        Me.txtGastosNota.CampoBusqueda = False
        Me.txtGastosNota.CampoEsLlave = False
        Me.txtGastosNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGastosNota.ControlBackColor = System.Drawing.Color.White
        Me.txtGastosNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtGastosNota.FechaActual = False
        Me.txtGastosNota.Formato = "#,###0.00"
        Me.txtGastosNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtGastosNota.LabelText = "Otros Gastos"
        Me.txtGastosNota.LabelWidth = 125
        Me.txtGastosNota.Location = New System.Drawing.Point(380, 254)
        Me.txtGastosNota.MaxLength = 0
        Me.txtGastosNota.Name = "txtGastosNota"
        Me.txtGastosNota.NombreCampo = "GastosNota"
        Me.txtGastosNota.Obligatorio = False
        Me.txtGastosNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGastosNota.Size = New System.Drawing.Size(87, 36)
        Me.txtGastosNota.SoloLectura = False
        Me.txtGastosNota.TabIndex = 7
        Me.txtGastosNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtGastosNota.Valor = 0
        '
        'txtFechaNotaCredito
        '
        Me.txtFechaNotaCredito.CampoBusqueda = True
        Me.txtFechaNotaCredito.CampoEsLlave = False
        Me.txtFechaNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaNotaCredito.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaNotaCredito.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaNotaCredito.FechaActual = False
        Me.txtFechaNotaCredito.Formato = ""
        Me.txtFechaNotaCredito.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaNotaCredito.LabelText = "Fecha Nota Crédito"
        Me.txtFechaNotaCredito.LabelWidth = 161
        Me.txtFechaNotaCredito.Location = New System.Drawing.Point(7, 228)
        Me.txtFechaNotaCredito.MaxLength = 0
        Me.txtFechaNotaCredito.Name = "txtFechaNotaCredito"
        Me.txtFechaNotaCredito.NombreCampo = "FechaNotaCredito"
        Me.txtFechaNotaCredito.Obligatorio = True
        Me.txtFechaNotaCredito.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaNotaCredito.Size = New System.Drawing.Size(484, 20)
        Me.txtFechaNotaCredito.SoloLectura = False
        Me.txtFechaNotaCredito.TabIndex = 2
        Me.txtFechaNotaCredito.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaNotaCredito.Valor = Nothing
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.CampoBusqueda = False
        Me.txtObservaciones.CampoEsLlave = False
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservaciones.ControlBackColor = System.Drawing.Color.White
        Me.txtObservaciones.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.FechaActual = False
        Me.txtObservaciones.Formato = ""
        Me.txtObservaciones.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtObservaciones.LabelText = "Observaciones"
        Me.txtObservaciones.LabelWidth = 92
        Me.txtObservaciones.Location = New System.Drawing.Point(194, 295)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = "Observaciones"
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(550, 36)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'btnBuscarFactura
        '
        Me.btnBuscarFactura.Image = CType(resources.GetObject("btnBuscarFactura.Image"), System.Drawing.Image)
        Me.btnBuscarFactura.Location = New System.Drawing.Point(169, 87)
        Me.btnBuscarFactura.Name = "btnBuscarFactura"
        Me.btnBuscarFactura.Size = New System.Drawing.Size(123, 27)
        Me.btnBuscarFactura.TabIndex = 1
        Me.btnBuscarFactura.Text = "Buscar Factura"
        '
        'txtComisionNota
        '
        Me.txtComisionNota.CampoBusqueda = False
        Me.txtComisionNota.CampoEsLlave = False
        Me.txtComisionNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtComisionNota.ControlBackColor = System.Drawing.Color.White
        Me.txtComisionNota.ControlForeColor = System.Drawing.Color.Black
        Me.txtComisionNota.FechaActual = False
        Me.txtComisionNota.Formato = "#,###0.00"
        Me.txtComisionNota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtComisionNota.LabelText = "Comisón Nota Crédito"
        Me.txtComisionNota.LabelWidth = 125
        Me.txtComisionNota.Location = New System.Drawing.Point(8, 295)
        Me.txtComisionNota.MaxLength = 0
        Me.txtComisionNota.Name = "txtComisionNota"
        Me.txtComisionNota.NombreCampo = "ComisionNota"
        Me.txtComisionNota.Obligatorio = False
        Me.txtComisionNota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComisionNota.Size = New System.Drawing.Size(180, 36)
        Me.txtComisionNota.SoloLectura = False
        Me.txtComisionNota.TabIndex = 11
        Me.txtComisionNota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtComisionNota.Valor = 0
        '
        'txtPorcentajeComiFact
        '
        Me.txtPorcentajeComiFact.CampoBusqueda = False
        Me.txtPorcentajeComiFact.CampoEsLlave = False
        Me.txtPorcentajeComiFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorcentajeComiFact.ControlBackColor = System.Drawing.Color.White
        Me.txtPorcentajeComiFact.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorcentajeComiFact.FechaActual = False
        Me.txtPorcentajeComiFact.Formato = "#,###0.0000"
        Me.txtPorcentajeComiFact.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtPorcentajeComiFact.LabelText = "Porcentaje Comisión Factura"
        Me.txtPorcentajeComiFact.LabelWidth = 125
        Me.txtPorcentajeComiFact.Location = New System.Drawing.Point(496, 81)
        Me.txtPorcentajeComiFact.MaxLength = 0
        Me.txtPorcentajeComiFact.Name = "txtPorcentajeComiFact"
        Me.txtPorcentajeComiFact.NombreCampo = "PorcentajeComiFact"
        Me.txtPorcentajeComiFact.Obligatorio = False
        Me.txtPorcentajeComiFact.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorcentajeComiFact.Size = New System.Drawing.Size(159, 36)
        Me.txtPorcentajeComiFact.SoloLectura = False
        Me.txtPorcentajeComiFact.TabIndex = 26
        Me.txtPorcentajeComiFact.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorcentajeComiFact.Valor = 0
        '
        'cboIdTipoIngreso
        '
        Me.cboIdTipoIngreso.CampoAutoCompletar = 0
        Me.cboIdTipoIngreso.CampoBusqueda = False
        Me.cboIdTipoIngreso.CampoDisplay = 1
        Me.cboIdTipoIngreso.CampoEsLlave = False
        Me.cboIdTipoIngreso.CampoValor = 0
        Me.cboIdTipoIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdTipoIngreso.ControlBackColor = System.Drawing.Color.White
        Me.cboIdTipoIngreso.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdTipoIngreso.FilasVisibles = 1237
        Me.cboIdTipoIngreso.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboIdTipoIngreso.LabelText = "Tipo Reintegro"
        Me.cboIdTipoIngreso.LabelWidth = 125
        Me.cboIdTipoIngreso.Lista = "E Efectivo|C Cheque|D Depósito Bancario|A Depósito en Aseguradora|V Valores Póliz" & _
            "a"
        Me.cboIdTipoIngreso.Location = New System.Drawing.Point(8, 337)
        Me.cboIdTipoIngreso.MostrarBusquedaColumnas = False
        Me.cboIdTipoIngreso.Name = "cboIdTipoIngreso"
        Me.cboIdTipoIngreso.NombreCampo = "IdTipoIngreso"
        Me.cboIdTipoIngreso.Obligatorio = True
        Me.cboIdTipoIngreso.Query = ""
        Me.cboIdTipoIngreso.SelectIndex = 0
        Me.cboIdTipoIngreso.Size = New System.Drawing.Size(180, 38)
        Me.cboIdTipoIngreso.SoloLectura = False
        Me.cboIdTipoIngreso.StringConection = ""
        Me.cboIdTipoIngreso.TabIndex = 13
        Me.cboIdTipoIngreso.TextoNuevoItem = ""
        Me.cboIdTipoIngreso.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdTipoIngreso.Valor = ""
        '
        'txtDescripcionReintegro
        '
        Me.txtDescripcionReintegro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionReintegro.CampoBusqueda = False
        Me.txtDescripcionReintegro.CampoEsLlave = False
        Me.txtDescripcionReintegro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionReintegro.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionReintegro.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionReintegro.FechaActual = False
        Me.txtDescripcionReintegro.Formato = ""
        Me.txtDescripcionReintegro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDescripcionReintegro.LabelText = "Descripción de Reintegro"
        Me.txtDescripcionReintegro.LabelWidth = 92
        Me.txtDescripcionReintegro.Location = New System.Drawing.Point(194, 339)
        Me.txtDescripcionReintegro.MaxLength = 500
        Me.txtDescripcionReintegro.Name = "txtDescripcionReintegro"
        Me.txtDescripcionReintegro.NombreCampo = "DescripcionReintegro"
        Me.txtDescripcionReintegro.Obligatorio = False
        Me.txtDescripcionReintegro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionReintegro.Size = New System.Drawing.Size(550, 36)
        Me.txtDescripcionReintegro.SoloLectura = False
        Me.txtDescripcionReintegro.TabIndex = 14
        Me.txtDescripcionReintegro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionReintegro.Valor = ""
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
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 125
        Me.txtIdCliente.Location = New System.Drawing.Point(8, 187)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = ""
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(159, 36)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 28
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
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
        Me.txtNombreCliente.LabelText = "Nombre de Cliente"
        Me.txtNombreCliente.LabelWidth = 125
        Me.txtNombreCliente.Location = New System.Drawing.Point(169, 186)
        Me.txtNombreCliente.MaxLength = 25
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = ""
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(485, 36)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 29
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(190, 410)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(98, 36)
        Me.btnImprimir.TabIndex = 17
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btnAnulacionExiste
        '
        Me.btnAnulacionExiste.Image = CType(resources.GetObject("btnAnulacionExiste.Image"), System.Drawing.Image)
        Me.btnAnulacionExiste.Location = New System.Drawing.Point(298, 87)
        Me.btnAnulacionExiste.Name = "btnAnulacionExiste"
        Me.btnAnulacionExiste.Size = New System.Drawing.Size(193, 27)
        Me.btnAnulacionExiste.TabIndex = 27
        Me.btnAnulacionExiste.Text = "Anulación Factura Existente"
        '
        'txtRetIva
        '
        Me.txtRetIva.CampoBusqueda = False
        Me.txtRetIva.CampoEsLlave = False
        Me.txtRetIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRetIva.ControlBackColor = System.Drawing.Color.White
        Me.txtRetIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtRetIva.FechaActual = False
        Me.txtRetIva.Formato = "#,###0.00"
        Me.txtRetIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtRetIva.LabelText = "Retención Iva"
        Me.txtRetIva.LabelWidth = 125
        Me.txtRetIva.Location = New System.Drawing.Point(566, 254)
        Me.txtRetIva.MaxLength = 0
        Me.txtRetIva.Name = "txtRetIva"
        Me.txtRetIva.NombreCampo = "RetImpuestosNota"
        Me.txtRetIva.Obligatorio = False
        Me.txtRetIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRetIva.Size = New System.Drawing.Size(87, 36)
        Me.txtRetIva.SoloLectura = False
        Me.txtRetIva.TabIndex = 9
        Me.txtRetIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtRetIva.Valor = 0
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAnular.Appearance.Options.UseFont = True
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(383, 409)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(93, 36)
        Me.btnAnular.TabIndex = 31
        Me.btnAnular.Text = "Anu&lar"
        '
        'txtFechaAnula
        '
        Me.txtFechaAnula.CampoBusqueda = True
        Me.txtFechaAnula.CampoEsLlave = False
        Me.txtFechaAnula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAnula.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAnula.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAnula.FechaActual = False
        Me.txtFechaAnula.Formato = ""
        Me.txtFechaAnula.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAnula.LabelText = "Fecha Anula Nota Crédito"
        Me.txtFechaAnula.LabelWidth = 161
        Me.txtFechaAnula.Location = New System.Drawing.Point(8, 381)
        Me.txtFechaAnula.MaxLength = 0
        Me.txtFechaAnula.Name = "txtFechaAnula"
        Me.txtFechaAnula.NombreCampo = "FechaAnula"
        Me.txtFechaAnula.Obligatorio = False
        Me.txtFechaAnula.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAnula.Size = New System.Drawing.Size(484, 20)
        Me.txtFechaAnula.SoloLectura = False
        Me.txtFechaAnula.TabIndex = 32
        Me.txtFechaAnula.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAnula.Valor = Nothing
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
        Me.cboFlujo.FilasVisibles = 1979
        Me.cboFlujo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboFlujo.LabelText = "Flujo de Correspondencia"
        Me.cboFlujo.LabelWidth = 160
        Me.cboFlujo.Lista = ""
        Me.cboFlujo.Location = New System.Drawing.Point(8, 162)
        Me.cboFlujo.MostrarBusquedaColumnas = True
        Me.cboFlujo.Name = "cboFlujo"
        Me.cboFlujo.NombreCampo = "IdFlujoDoc"
        Me.cboFlujo.Obligatorio = False
        Me.cboFlujo.Query = resources.GetString("cboFlujo.Query")
        Me.cboFlujo.SelectIndex = 0
        Me.cboFlujo.Size = New System.Drawing.Size(459, 20)
        Me.cboFlujo.SoloLectura = False
        Me.cboFlujo.StringConection = ""
        Me.cboFlujo.TabIndex = 37
        Me.cboFlujo.TextoNuevoItem = "<Nuevo Flujo>"
        Me.cboFlujo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboFlujo.Valor = ""
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
        Me.cboAtencionA.Location = New System.Drawing.Point(473, 162)
        Me.cboAtencionA.Name = "cboAtencionA"
        Me.cboAtencionA.NombreCampo = "IdContacto"
        Me.cboAtencionA.Obligatorio = False
        Me.cboAtencionA.Query = "select idcontacto, nombre, cargo from ClientesContactos where idcliente = ''"
        Me.cboAtencionA.SelectIndex = -2147483648
        Me.cboAtencionA.Size = New System.Drawing.Size(277, 20)
        Me.cboAtencionA.SoloLectura = False
        Me.cboAtencionA.StringConection = ""
        Me.cboAtencionA.TabIndex = 38
        Me.cboAtencionA.TextoNuevoItem = ""
        Me.cboAtencionA.TipoDato = STIControles.stiGridComboBox.TipoContenido.Texto
        Me.cboAtencionA.Valor = ""
        '
        'NotasCreditoMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 316
        Me.ClientSize = New System.Drawing.Size(755, 446)
        Me.Controls.Add(Me.cboAtencionA)
        Me.Controls.Add(Me.cboFlujo)
        Me.Controls.Add(Me.txtFechaAnula)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.txtRetIva)
        Me.Controls.Add(Me.btnAnulacionExiste)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtDescripcionReintegro)
        Me.Controls.Add(Me.cboIdTipoIngreso)
        Me.Controls.Add(Me.txtPorcentajeComiFact)
        Me.Controls.Add(Me.txtComisionNota)
        Me.Controls.Add(Me.btnBuscarFactura)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtFechaNotaCredito)
        Me.Controls.Add(Me.txtGastosNota)
        Me.Controls.Add(Me.txtTotalNota)
        Me.Controls.Add(Me.txtImpuestosNota)
        Me.Controls.Add(Me.txtGastosBombNota)
        Me.Controls.Add(Me.txtGastosFinNota)
        Me.Controls.Add(Me.cboIdRamo)
        Me.Controls.Add(Me.txtGastosEmiNota)
        Me.Controls.Add(Me.txtPrimaNetaNota)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtNumeroFactura)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdNotaCredito)
        Me.Name = "NotasCreditoMan"
        Me.Text = "Notas de Crédito"
        Me.Controls.SetChildIndex(Me.txtIdNotaCredito, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroFactura, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtPrimaNetaNota, 0)
        Me.Controls.SetChildIndex(Me.txtGastosEmiNota, 0)
        Me.Controls.SetChildIndex(Me.cboIdRamo, 0)
        Me.Controls.SetChildIndex(Me.txtGastosFinNota, 0)
        Me.Controls.SetChildIndex(Me.txtGastosBombNota, 0)
        Me.Controls.SetChildIndex(Me.txtImpuestosNota, 0)
        Me.Controls.SetChildIndex(Me.txtTotalNota, 0)
        Me.Controls.SetChildIndex(Me.txtGastosNota, 0)
        Me.Controls.SetChildIndex(Me.txtFechaNotaCredito, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarFactura, 0)
        Me.Controls.SetChildIndex(Me.txtComisionNota, 0)
        Me.Controls.SetChildIndex(Me.txtPorcentajeComiFact, 0)
        Me.Controls.SetChildIndex(Me.cboIdTipoIngreso, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionReintegro, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAnulacionExiste, 0)
        Me.Controls.SetChildIndex(Me.txtRetIva, 0)
        Me.Controls.SetChildIndex(Me.btnAnular, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAnula, 0)
        Me.Controls.SetChildIndex(Me.cboFlujo, 0)
        Me.Controls.SetChildIndex(Me.cboAtencionA, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdNotaCredito As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtNumeroFactura As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtPrimaNetaNota As STIControles.stiTextBox
    Friend WithEvents txtGastosEmiNota As STIControles.stiTextBox
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents txtGastosFinNota As STIControles.stiTextBox
    Friend WithEvents txtGastosBombNota As STIControles.stiTextBox
    Friend WithEvents txtImpuestosNota As STIControles.stiTextBox
    Friend WithEvents txtTotalNota As STIControles.stiTextBox
    Friend WithEvents txtGastosNota As STIControles.stiTextBox
    Friend WithEvents txtFechaNotaCredito As STIControles.stiTextBox
    Friend WithEvents txtObservaciones As STIControles.stiTextBox
    Friend WithEvents btnBuscarFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtComisionNota As STIControles.stiTextBox
    Friend WithEvents txtPorcentajeComiFact As STIControles.stiTextBox
    Friend WithEvents cboIdTipoIngreso As STIControles.stiComboBox
    Friend WithEvents txtDescripcionReintegro As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnulacionExiste As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRetIva As STIControles.stiTextBox
    Public WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaAnula As STIControles.stiTextBox
    Friend WithEvents cboFlujo As STIControles.stiComboBox
    Friend WithEvents cboAtencionA As STIControles.stiGridComboBox

End Class
