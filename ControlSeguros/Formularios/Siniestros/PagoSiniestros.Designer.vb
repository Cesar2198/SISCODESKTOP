<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoSiniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoSiniestros))
        Me.txtFechaPago = New STIControles.stiTextBox
        Me.txtNombreCheque = New STIControles.stiTextBox
        Me.txtNumeroCheque = New STIControles.stiTextBox
        Me.txtValorRenta = New STIControles.stiTextBox
        Me.txtValorDescuento = New STIControles.stiTextBox
        Me.txtValorGasto = New STIControles.stiTextBox
        Me.txtValorIva = New STIControles.stiTextBox
        Me.txtValorReembolso = New STIControles.stiTextBox
        Me.txtValorRetencionIva = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.cboEstado = New STIControles.stiComboBox
        Me.btnBuscaSiniestro = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescripcionReserva = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(440, 355)
        Me.btnAyuda.TabIndex = 16
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(331, 381)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(283, 381)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(347, 355)
        Me.btnGuardar.TabIndex = 15
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(532, 355)
        Me.btnSalir.TabIndex = 17
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(315, 381)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(487, 74)
        Me.lblNombreFormulario.TabIndex = 18
        Me.lblNombreFormulario.Text = "Ingreso de Pagos de Siniestros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(299, 381)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtFechaPago
        '
        Me.txtFechaPago.CampoBusqueda = False
        Me.txtFechaPago.CampoEsLlave = False
        Me.txtFechaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPago.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPago.FechaActual = False
        Me.txtFechaPago.Formato = "dd/MMM/yyyy"
        Me.txtFechaPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPago.LabelText = "Fecha de Pago"
        Me.txtFechaPago.LabelWidth = 120
        Me.txtFechaPago.Location = New System.Drawing.Point(12, 225)
        Me.txtFechaPago.MaxLength = 0
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.NombreCampo = ""
        Me.txtFechaPago.Obligatorio = True
        Me.txtFechaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPago.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaPago.SoloLectura = False
        Me.txtFechaPago.TabIndex = 7
        Me.txtFechaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPago.Valor = Nothing
        '
        'txtNombreCheque
        '
        Me.txtNombreCheque.CampoBusqueda = False
        Me.txtNombreCheque.CampoEsLlave = False
        Me.txtNombreCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCheque.FechaActual = False
        Me.txtNombreCheque.Formato = "#,###0.00"
        Me.txtNombreCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCheque.LabelText = "Beneficiario Cheque"
        Me.txtNombreCheque.LabelWidth = 120
        Me.txtNombreCheque.Location = New System.Drawing.Point(12, 176)
        Me.txtNombreCheque.MaxLength = 150
        Me.txtNombreCheque.Name = "txtNombreCheque"
        Me.txtNombreCheque.NombreCampo = ""
        Me.txtNombreCheque.Obligatorio = True
        Me.txtNombreCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCheque.Size = New System.Drawing.Size(606, 20)
        Me.txtNombreCheque.SoloLectura = False
        Me.txtNombreCheque.TabIndex = 5
        Me.txtNombreCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCheque.Valor = ""
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.CampoBusqueda = False
        Me.txtNumeroCheque.CampoEsLlave = False
        Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroCheque.FechaActual = False
        Me.txtNumeroCheque.Formato = ""
        Me.txtNumeroCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroCheque.LabelText = "Número Cheque"
        Me.txtNumeroCheque.LabelWidth = 120
        Me.txtNumeroCheque.Location = New System.Drawing.Point(12, 199)
        Me.txtNumeroCheque.MaxLength = 25
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.NombreCampo = ""
        Me.txtNumeroCheque.Obligatorio = True
        Me.txtNumeroCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroCheque.Size = New System.Drawing.Size(300, 20)
        Me.txtNumeroCheque.SoloLectura = False
        Me.txtNumeroCheque.TabIndex = 6
        Me.txtNumeroCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroCheque.Valor = ""
        '
        'txtValorRenta
        '
        Me.txtValorRenta.CampoBusqueda = False
        Me.txtValorRenta.CampoEsLlave = False
        Me.txtValorRenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorRenta.ControlBackColor = System.Drawing.Color.White
        Me.txtValorRenta.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorRenta.FechaActual = False
        Me.txtValorRenta.Formato = "#,###0.00"
        Me.txtValorRenta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorRenta.LabelText = "Valor Renta"
        Me.txtValorRenta.LabelWidth = 120
        Me.txtValorRenta.Location = New System.Drawing.Point(343, 251)
        Me.txtValorRenta.MaxLength = 0
        Me.txtValorRenta.Name = "txtValorRenta"
        Me.txtValorRenta.NombreCampo = ""
        Me.txtValorRenta.Obligatorio = True
        Me.txtValorRenta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorRenta.Size = New System.Drawing.Size(275, 20)
        Me.txtValorRenta.SoloLectura = False
        Me.txtValorRenta.TabIndex = 11
        Me.txtValorRenta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorRenta.Valor = 0
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
        Me.txtValorDescuento.LabelWidth = 120
        Me.txtValorDescuento.Location = New System.Drawing.Point(343, 225)
        Me.txtValorDescuento.MaxLength = 0
        Me.txtValorDescuento.Name = "txtValorDescuento"
        Me.txtValorDescuento.NombreCampo = ""
        Me.txtValorDescuento.Obligatorio = True
        Me.txtValorDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorDescuento.Size = New System.Drawing.Size(275, 20)
        Me.txtValorDescuento.SoloLectura = False
        Me.txtValorDescuento.TabIndex = 10
        Me.txtValorDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorDescuento.Valor = 0
        '
        'txtValorGasto
        '
        Me.txtValorGasto.CampoBusqueda = False
        Me.txtValorGasto.CampoEsLlave = False
        Me.txtValorGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorGasto.ControlBackColor = System.Drawing.Color.White
        Me.txtValorGasto.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorGasto.FechaActual = False
        Me.txtValorGasto.Formato = "#,###0.00"
        Me.txtValorGasto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorGasto.LabelText = "Valor Gasto"
        Me.txtValorGasto.LabelWidth = 120
        Me.txtValorGasto.Location = New System.Drawing.Point(343, 199)
        Me.txtValorGasto.MaxLength = 0
        Me.txtValorGasto.Name = "txtValorGasto"
        Me.txtValorGasto.NombreCampo = ""
        Me.txtValorGasto.Obligatorio = True
        Me.txtValorGasto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorGasto.Size = New System.Drawing.Size(275, 20)
        Me.txtValorGasto.SoloLectura = False
        Me.txtValorGasto.TabIndex = 9
        Me.txtValorGasto.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorGasto.Valor = 0
        '
        'txtValorIva
        '
        Me.txtValorIva.CampoBusqueda = False
        Me.txtValorIva.CampoEsLlave = False
        Me.txtValorIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorIva.ControlBackColor = System.Drawing.Color.White
        Me.txtValorIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorIva.FechaActual = False
        Me.txtValorIva.Formato = "#,###0.00"
        Me.txtValorIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorIva.LabelText = "Valor IVA"
        Me.txtValorIva.LabelWidth = 120
        Me.txtValorIva.Location = New System.Drawing.Point(343, 277)
        Me.txtValorIva.MaxLength = 0
        Me.txtValorIva.Name = "txtValorIva"
        Me.txtValorIva.NombreCampo = ""
        Me.txtValorIva.Obligatorio = True
        Me.txtValorIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorIva.Size = New System.Drawing.Size(275, 20)
        Me.txtValorIva.SoloLectura = False
        Me.txtValorIva.TabIndex = 12
        Me.txtValorIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorIva.Valor = 0
        '
        'txtValorReembolso
        '
        Me.txtValorReembolso.CampoBusqueda = False
        Me.txtValorReembolso.CampoEsLlave = False
        Me.txtValorReembolso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorReembolso.ControlBackColor = System.Drawing.Color.White
        Me.txtValorReembolso.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorReembolso.FechaActual = False
        Me.txtValorReembolso.Formato = "#,###0.00"
        Me.txtValorReembolso.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorReembolso.LabelText = "Valor Reembolso"
        Me.txtValorReembolso.LabelWidth = 120
        Me.txtValorReembolso.Location = New System.Drawing.Point(343, 329)
        Me.txtValorReembolso.MaxLength = 0
        Me.txtValorReembolso.Name = "txtValorReembolso"
        Me.txtValorReembolso.NombreCampo = ""
        Me.txtValorReembolso.Obligatorio = True
        Me.txtValorReembolso.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorReembolso.Size = New System.Drawing.Size(275, 20)
        Me.txtValorReembolso.SoloLectura = False
        Me.txtValorReembolso.TabIndex = 14
        Me.txtValorReembolso.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorReembolso.Valor = 0
        '
        'txtValorRetencionIva
        '
        Me.txtValorRetencionIva.CampoBusqueda = False
        Me.txtValorRetencionIva.CampoEsLlave = False
        Me.txtValorRetencionIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorRetencionIva.ControlBackColor = System.Drawing.Color.White
        Me.txtValorRetencionIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorRetencionIva.FechaActual = False
        Me.txtValorRetencionIva.Formato = "#,###0.00"
        Me.txtValorRetencionIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorRetencionIva.LabelText = "Valor Retención IVA"
        Me.txtValorRetencionIva.LabelWidth = 120
        Me.txtValorRetencionIva.Location = New System.Drawing.Point(343, 303)
        Me.txtValorRetencionIva.MaxLength = 0
        Me.txtValorRetencionIva.Name = "txtValorRetencionIva"
        Me.txtValorRetencionIva.NombreCampo = ""
        Me.txtValorRetencionIva.Obligatorio = True
        Me.txtValorRetencionIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorRetencionIva.Size = New System.Drawing.Size(275, 20)
        Me.txtValorRetencionIva.SoloLectura = False
        Me.txtValorRetencionIva.TabIndex = 13
        Me.txtValorRetencionIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorRetencionIva.Valor = 0
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = False
        Me.txtIdPoliza.CampoEsLlave = False
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Poliza"
        Me.txtIdPoliza.LabelWidth = 120
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 105)
        Me.txtIdPoliza.MaxLength = 0
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = ""
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 2
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = False
        Me.txtIdCertificado.CampoEsLlave = False
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 120
        Me.txtIdCertificado.Location = New System.Drawing.Point(343, 105)
        Me.txtIdCertificado.MaxLength = 0
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = ""
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(275, 20)
        Me.txtIdCertificado.SoloLectura = True
        Me.txtIdCertificado.TabIndex = 3
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = False
        Me.txtIdSiniestro.CampoEsLlave = False
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Núm. Siniestro"
        Me.txtIdSiniestro.LabelWidth = 120
        Me.txtIdSiniestro.Location = New System.Drawing.Point(12, 81)
        Me.txtIdSiniestro.MaxLength = 0
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = ""
        Me.txtIdSiniestro.Obligatorio = True
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(300, 20)
        Me.txtIdSiniestro.SoloLectura = True
        Me.txtIdSiniestro.TabIndex = 1
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = False
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = False
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 120
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 129)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = ""
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(606, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 4
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'cboEstado
        '
        Me.cboEstado.CampoAutoCompletar = 0
        Me.cboEstado.CampoBusqueda = False
        Me.cboEstado.CampoDisplay = 1
        Me.cboEstado.CampoEsLlave = False
        Me.cboEstado.CampoValor = 0
        Me.cboEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstado.ControlBackColor = System.Drawing.Color.White
        Me.cboEstado.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstado.FilasVisibles = 7
        Me.cboEstado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstado.LabelText = "Estado Reclamo"
        Me.cboEstado.LabelWidth = 120
        Me.cboEstado.Lista = "PENDIENTE Pendiente|PAGADO Pagado"
        Me.cboEstado.Location = New System.Drawing.Point(12, 251)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.NombreCampo = ""
        Me.cboEstado.Obligatorio = True
        Me.cboEstado.Query = ""
        Me.cboEstado.SelectIndex = -1
        Me.cboEstado.Size = New System.Drawing.Size(300, 20)
        Me.cboEstado.SoloLectura = False
        Me.cboEstado.StringConection = ""
        Me.cboEstado.TabIndex = 8
        Me.cboEstado.TextoNuevoItem = ""
        Me.cboEstado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstado.Valor = ""
        '
        'btnBuscaSiniestro
        '
        Me.btnBuscaSiniestro.Image = CType(resources.GetObject("btnBuscaSiniestro.Image"), System.Drawing.Image)
        Me.btnBuscaSiniestro.Location = New System.Drawing.Point(318, 77)
        Me.btnBuscaSiniestro.Name = "btnBuscaSiniestro"
        Me.btnBuscaSiniestro.Size = New System.Drawing.Size(126, 27)
        Me.btnBuscaSiniestro.TabIndex = 0
        Me.btnBuscaSiniestro.Text = "Buscar Siniestro"
        '
        'txtDescripcionReserva
        '
        Me.txtDescripcionReserva.CampoBusqueda = False
        Me.txtDescripcionReserva.CampoEsLlave = False
        Me.txtDescripcionReserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionReserva.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionReserva.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionReserva.FechaActual = False
        Me.txtDescripcionReserva.Formato = ""
        Me.txtDescripcionReserva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionReserva.LabelText = "Comentario Reserva"
        Me.txtDescripcionReserva.LabelWidth = 120
        Me.txtDescripcionReserva.Location = New System.Drawing.Point(12, 152)
        Me.txtDescripcionReserva.MaxLength = 0
        Me.txtDescripcionReserva.Name = "txtDescripcionReserva"
        Me.txtDescripcionReserva.NombreCampo = "DescripcionReserva"
        Me.txtDescripcionReserva.Obligatorio = True
        Me.txtDescripcionReserva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionReserva.Size = New System.Drawing.Size(605, 20)
        Me.txtDescripcionReserva.SoloLectura = False
        Me.txtDescripcionReserva.TabIndex = 19
        Me.txtDescripcionReserva.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionReserva.Valor = ""
        '
        'PagoSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 809
        Me.ClientSize = New System.Drawing.Size(626, 391)
        Me.Controls.Add(Me.txtDescripcionReserva)
        Me.Controls.Add(Me.btnBuscaSiniestro)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdSiniestro)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtValorReembolso)
        Me.Controls.Add(Me.txtValorRetencionIva)
        Me.Controls.Add(Me.txtValorIva)
        Me.Controls.Add(Me.txtValorRenta)
        Me.Controls.Add(Me.txtValorDescuento)
        Me.Controls.Add(Me.txtValorGasto)
        Me.Controls.Add(Me.txtNumeroCheque)
        Me.Controls.Add(Me.txtNombreCheque)
        Me.Controls.Add(Me.txtFechaPago)
        Me.Name = "PagoSiniestros"
        Me.Text = "Pago de Siniestros"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.txtFechaPago, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCheque, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroCheque, 0)
        Me.Controls.SetChildIndex(Me.txtValorGasto, 0)
        Me.Controls.SetChildIndex(Me.txtValorDescuento, 0)
        Me.Controls.SetChildIndex(Me.txtValorRenta, 0)
        Me.Controls.SetChildIndex(Me.txtValorIva, 0)
        Me.Controls.SetChildIndex(Me.txtValorRetencionIva, 0)
        Me.Controls.SetChildIndex(Me.txtValorReembolso, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.cboEstado, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionReserva, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaPago As STIControles.stiTextBox
    Friend WithEvents txtNombreCheque As STIControles.stiTextBox
    Friend WithEvents txtNumeroCheque As STIControles.stiTextBox
    Friend WithEvents txtValorRenta As STIControles.stiTextBox
    Friend WithEvents txtValorDescuento As STIControles.stiTextBox
    Friend WithEvents txtValorGasto As STIControles.stiTextBox
    Friend WithEvents txtValorIva As STIControles.stiTextBox
    Friend WithEvents txtValorReembolso As STIControles.stiTextBox
    Friend WithEvents txtValorRetencionIva As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboEstado As STIControles.stiComboBox
    Friend WithEvents btnBuscaSiniestro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcionReserva As STIControles.stiTextBox

End Class
