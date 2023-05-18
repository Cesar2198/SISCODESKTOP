<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CGPolizasCotizacion
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
        Me.txtIdOferta = New STIControles.stiTextBox
        Me.txtIdCotizacion = New STIControles.stiTextBox
        Me.txtResumenPlan = New STIControles.stiTextBox
        Me.txtResumenSumaAsegurada = New STIControles.stiTextBox
        Me.txtResumenPrimaIva = New STIControles.stiTextBox
        Me.txtResumenPrimaAnual = New STIControles.stiTextBox
        Me.txtResumenNumeroCuotas = New STIControles.stiTextBox
        Me.cboResumenFormaPago = New STIControles.stiComboBox
        Me.txtResumenNumeroCartaEnvio = New STIControles.stiTextBox
        Me.txtResumenFechaEnvio = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.cboResumenFormaEnvio = New STIControles.stiComboBox
        Me.cboIdAseguradora = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(437, 317)
        Me.btnAyuda.TabIndex = 16
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(253, 317)
        Me.btnBuscar.TabIndex = 14
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(68, 317)
        Me.btnNuevo.TabIndex = 13
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(160, 317)
        Me.btnGuardar.TabIndex = 12
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(529, 317)
        Me.btnSalir.TabIndex = 17
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(345, 317)
        Me.btnEliminar.TabIndex = 15
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(484, 74)
        Me.lblNombreFormulario.TabIndex = 18
        Me.lblNombreFormulario.Text = "Registro de Cotizaciones"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(161, 343)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtIdOferta
        '
        Me.txtIdOferta.CampoBusqueda = True
        Me.txtIdOferta.CampoEsLlave = True
        Me.txtIdOferta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdOferta.ControlBackColor = System.Drawing.Color.White
        Me.txtIdOferta.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdOferta.FechaActual = False
        Me.txtIdOferta.Formato = ""
        Me.txtIdOferta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdOferta.LabelText = "Número Oferta"
        Me.txtIdOferta.LabelWidth = 150
        Me.txtIdOferta.Location = New System.Drawing.Point(10, 81)
        Me.txtIdOferta.MaxLength = 0
        Me.txtIdOferta.Name = "txtIdOferta"
        Me.txtIdOferta.NombreCampo = "IdOferta"
        Me.txtIdOferta.Obligatorio = True
        Me.txtIdOferta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdOferta.Size = New System.Drawing.Size(300, 20)
        Me.txtIdOferta.SoloLectura = False
        Me.txtIdOferta.TabIndex = 0
        Me.txtIdOferta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdOferta.Valor = ""
        '
        'txtIdCotizacion
        '
        Me.txtIdCotizacion.CampoBusqueda = True
        Me.txtIdCotizacion.CampoEsLlave = True
        Me.txtIdCotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCotizacion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCotizacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCotizacion.FechaActual = False
        Me.txtIdCotizacion.Formato = ""
        Me.txtIdCotizacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCotizacion.LabelText = "Número Cotización"
        Me.txtIdCotizacion.LabelWidth = 150
        Me.txtIdCotizacion.Location = New System.Drawing.Point(316, 81)
        Me.txtIdCotizacion.MaxLength = 0
        Me.txtIdCotizacion.Name = "txtIdCotizacion"
        Me.txtIdCotizacion.NombreCampo = "IdCotizacion"
        Me.txtIdCotizacion.Obligatorio = True
        Me.txtIdCotizacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCotizacion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCotizacion.SoloLectura = False
        Me.txtIdCotizacion.TabIndex = 1
        Me.txtIdCotizacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCotizacion.Valor = ""
        '
        'txtResumenPlan
        '
        Me.txtResumenPlan.CampoBusqueda = True
        Me.txtResumenPlan.CampoEsLlave = False
        Me.txtResumenPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenPlan.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenPlan.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenPlan.FechaActual = False
        Me.txtResumenPlan.Formato = ""
        Me.txtResumenPlan.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenPlan.LabelText = "Plan Ofertado"
        Me.txtResumenPlan.LabelWidth = 150
        Me.txtResumenPlan.Location = New System.Drawing.Point(10, 152)
        Me.txtResumenPlan.MaxLength = 600
        Me.txtResumenPlan.Name = "txtResumenPlan"
        Me.txtResumenPlan.NombreCampo = "PlanCotizado"
        Me.txtResumenPlan.Obligatorio = False
        Me.txtResumenPlan.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenPlan.Size = New System.Drawing.Size(606, 20)
        Me.txtResumenPlan.SoloLectura = False
        Me.txtResumenPlan.TabIndex = 3
        Me.txtResumenPlan.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtResumenPlan.Valor = ""
        '
        'txtResumenSumaAsegurada
        '
        Me.txtResumenSumaAsegurada.CampoBusqueda = True
        Me.txtResumenSumaAsegurada.CampoEsLlave = False
        Me.txtResumenSumaAsegurada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenSumaAsegurada.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenSumaAsegurada.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenSumaAsegurada.FechaActual = False
        Me.txtResumenSumaAsegurada.Formato = "#,###0.00"
        Me.txtResumenSumaAsegurada.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenSumaAsegurada.LabelText = "Suma Asegurada"
        Me.txtResumenSumaAsegurada.LabelWidth = 150
        Me.txtResumenSumaAsegurada.Location = New System.Drawing.Point(10, 175)
        Me.txtResumenSumaAsegurada.MaxLength = 0
        Me.txtResumenSumaAsegurada.Name = "txtResumenSumaAsegurada"
        Me.txtResumenSumaAsegurada.NombreCampo = "SumaAsegurada"
        Me.txtResumenSumaAsegurada.Obligatorio = False
        Me.txtResumenSumaAsegurada.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenSumaAsegurada.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenSumaAsegurada.SoloLectura = False
        Me.txtResumenSumaAsegurada.TabIndex = 4
        Me.txtResumenSumaAsegurada.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenSumaAsegurada.Valor = 0
        '
        'txtResumenPrimaIva
        '
        Me.txtResumenPrimaIva.CampoBusqueda = True
        Me.txtResumenPrimaIva.CampoEsLlave = False
        Me.txtResumenPrimaIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenPrimaIva.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenPrimaIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenPrimaIva.FechaActual = False
        Me.txtResumenPrimaIva.Formato = "#,###0.00"
        Me.txtResumenPrimaIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenPrimaIva.LabelText = "Prima con IVA"
        Me.txtResumenPrimaIva.LabelWidth = 150
        Me.txtResumenPrimaIva.Location = New System.Drawing.Point(316, 198)
        Me.txtResumenPrimaIva.MaxLength = 0
        Me.txtResumenPrimaIva.Name = "txtResumenPrimaIva"
        Me.txtResumenPrimaIva.NombreCampo = "Total"
        Me.txtResumenPrimaIva.Obligatorio = False
        Me.txtResumenPrimaIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenPrimaIva.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenPrimaIva.SoloLectura = False
        Me.txtResumenPrimaIva.TabIndex = 6
        Me.txtResumenPrimaIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenPrimaIva.Valor = 0
        '
        'txtResumenPrimaAnual
        '
        Me.txtResumenPrimaAnual.CampoBusqueda = True
        Me.txtResumenPrimaAnual.CampoEsLlave = False
        Me.txtResumenPrimaAnual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenPrimaAnual.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenPrimaAnual.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenPrimaAnual.FechaActual = False
        Me.txtResumenPrimaAnual.Formato = "#,###0.00"
        Me.txtResumenPrimaAnual.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenPrimaAnual.LabelText = "Prima Neta"
        Me.txtResumenPrimaAnual.LabelWidth = 150
        Me.txtResumenPrimaAnual.Location = New System.Drawing.Point(10, 198)
        Me.txtResumenPrimaAnual.MaxLength = 0
        Me.txtResumenPrimaAnual.Name = "txtResumenPrimaAnual"
        Me.txtResumenPrimaAnual.NombreCampo = "PrimaNeta"
        Me.txtResumenPrimaAnual.Obligatorio = False
        Me.txtResumenPrimaAnual.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenPrimaAnual.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenPrimaAnual.SoloLectura = False
        Me.txtResumenPrimaAnual.TabIndex = 5
        Me.txtResumenPrimaAnual.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenPrimaAnual.Valor = 0
        '
        'txtResumenNumeroCuotas
        '
        Me.txtResumenNumeroCuotas.CampoBusqueda = True
        Me.txtResumenNumeroCuotas.CampoEsLlave = False
        Me.txtResumenNumeroCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenNumeroCuotas.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenNumeroCuotas.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenNumeroCuotas.FechaActual = False
        Me.txtResumenNumeroCuotas.Formato = "###0"
        Me.txtResumenNumeroCuotas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenNumeroCuotas.LabelText = "Número de Cuotas"
        Me.txtResumenNumeroCuotas.LabelWidth = 150
        Me.txtResumenNumeroCuotas.Location = New System.Drawing.Point(11, 221)
        Me.txtResumenNumeroCuotas.MaxLength = 0
        Me.txtResumenNumeroCuotas.Name = "txtResumenNumeroCuotas"
        Me.txtResumenNumeroCuotas.NombreCampo = "NumeroCuotas"
        Me.txtResumenNumeroCuotas.Obligatorio = False
        Me.txtResumenNumeroCuotas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenNumeroCuotas.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenNumeroCuotas.SoloLectura = False
        Me.txtResumenNumeroCuotas.TabIndex = 7
        Me.txtResumenNumeroCuotas.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenNumeroCuotas.Valor = 0
        '
        'cboResumenFormaPago
        '
        Me.cboResumenFormaPago.CampoAutoCompletar = 0
        Me.cboResumenFormaPago.CampoBusqueda = False
        Me.cboResumenFormaPago.CampoDisplay = 1
        Me.cboResumenFormaPago.CampoEsLlave = False
        Me.cboResumenFormaPago.CampoValor = 0
        Me.cboResumenFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboResumenFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.cboResumenFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboResumenFormaPago.FilasVisibles = 20752
        Me.cboResumenFormaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboResumenFormaPago.LabelText = "Forma de Pago"
        Me.cboResumenFormaPago.LabelWidth = 150
        Me.cboResumenFormaPago.Lista = "MENSUAL Mensual|ANUAL Anual|TRIMESTRAL Trimestral|SEMESTRAL Semestral"
        Me.cboResumenFormaPago.Location = New System.Drawing.Point(316, 221)
        Me.cboResumenFormaPago.MostrarBusquedaColumnas = False
        Me.cboResumenFormaPago.Name = "cboResumenFormaPago"
        Me.cboResumenFormaPago.NombreCampo = "IdFormaPago"
        Me.cboResumenFormaPago.Obligatorio = False
        Me.cboResumenFormaPago.Query = ""
        Me.cboResumenFormaPago.SelectIndex = 0
        Me.cboResumenFormaPago.Size = New System.Drawing.Size(300, 20)
        Me.cboResumenFormaPago.SoloLectura = False
        Me.cboResumenFormaPago.StringConection = ""
        Me.cboResumenFormaPago.TabIndex = 8
        Me.cboResumenFormaPago.TextoNuevoItem = ""
        Me.cboResumenFormaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboResumenFormaPago.Valor = ""
        '
        'txtResumenNumeroCartaEnvio
        '
        Me.txtResumenNumeroCartaEnvio.CampoBusqueda = True
        Me.txtResumenNumeroCartaEnvio.CampoEsLlave = False
        Me.txtResumenNumeroCartaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenNumeroCartaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenNumeroCartaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenNumeroCartaEnvio.FechaActual = False
        Me.txtResumenNumeroCartaEnvio.Formato = ""
        Me.txtResumenNumeroCartaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenNumeroCartaEnvio.LabelText = "Número de Carta Envío"
        Me.txtResumenNumeroCartaEnvio.LabelWidth = 150
        Me.txtResumenNumeroCartaEnvio.Location = New System.Drawing.Point(316, 244)
        Me.txtResumenNumeroCartaEnvio.MaxLength = 25
        Me.txtResumenNumeroCartaEnvio.Name = "txtResumenNumeroCartaEnvio"
        Me.txtResumenNumeroCartaEnvio.NombreCampo = "NumeroCarta"
        Me.txtResumenNumeroCartaEnvio.Obligatorio = False
        Me.txtResumenNumeroCartaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenNumeroCartaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenNumeroCartaEnvio.SoloLectura = False
        Me.txtResumenNumeroCartaEnvio.TabIndex = 10
        Me.txtResumenNumeroCartaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtResumenNumeroCartaEnvio.Valor = ""
        '
        'txtResumenFechaEnvio
        '
        Me.txtResumenFechaEnvio.CampoBusqueda = True
        Me.txtResumenFechaEnvio.CampoEsLlave = False
        Me.txtResumenFechaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenFechaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenFechaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenFechaEnvio.FechaActual = False
        Me.txtResumenFechaEnvio.Formato = "dd/MMM/yyyy"
        Me.txtResumenFechaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenFechaEnvio.LabelText = "Fecha de Envío"
        Me.txtResumenFechaEnvio.LabelWidth = 150
        Me.txtResumenFechaEnvio.Location = New System.Drawing.Point(10, 268)
        Me.txtResumenFechaEnvio.MaxLength = 0
        Me.txtResumenFechaEnvio.Name = "txtResumenFechaEnvio"
        Me.txtResumenFechaEnvio.NombreCampo = "FechaEnvio"
        Me.txtResumenFechaEnvio.Obligatorio = False
        Me.txtResumenFechaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenFechaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenFechaEnvio.SoloLectura = False
        Me.txtResumenFechaEnvio.TabIndex = 11
        Me.txtResumenFechaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtResumenFechaEnvio.Valor = Nothing
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
        Me.cboIdProducto.FilasVisibles = 20752
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 150
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(10, 104)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(606, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 2
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'cboResumenFormaEnvio
        '
        Me.cboResumenFormaEnvio.CampoAutoCompletar = 0
        Me.cboResumenFormaEnvio.CampoBusqueda = False
        Me.cboResumenFormaEnvio.CampoDisplay = 1
        Me.cboResumenFormaEnvio.CampoEsLlave = False
        Me.cboResumenFormaEnvio.CampoValor = 0
        Me.cboResumenFormaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboResumenFormaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.cboResumenFormaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.cboResumenFormaEnvio.FilasVisibles = 20752
        Me.cboResumenFormaEnvio.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboResumenFormaEnvio.LabelText = "Forma de Envío de Oferta"
        Me.cboResumenFormaEnvio.LabelWidth = 150
        Me.cboResumenFormaEnvio.Lista = "M Por E-mail|C Por Carta"
        Me.cboResumenFormaEnvio.Location = New System.Drawing.Point(10, 244)
        Me.cboResumenFormaEnvio.MostrarBusquedaColumnas = False
        Me.cboResumenFormaEnvio.Name = "cboResumenFormaEnvio"
        Me.cboResumenFormaEnvio.NombreCampo = "FormaEnvio"
        Me.cboResumenFormaEnvio.Obligatorio = False
        Me.cboResumenFormaEnvio.Query = ""
        Me.cboResumenFormaEnvio.SelectIndex = 0
        Me.cboResumenFormaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.cboResumenFormaEnvio.SoloLectura = False
        Me.cboResumenFormaEnvio.StringConection = ""
        Me.cboResumenFormaEnvio.TabIndex = 9
        Me.cboResumenFormaEnvio.TextoNuevoItem = ""
        Me.cboResumenFormaEnvio.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboResumenFormaEnvio.Valor = ""
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.CampoAutoCompletar = 0
        Me.cboIdAseguradora.CampoBusqueda = True
        Me.cboIdAseguradora.CampoDisplay = 1
        Me.cboIdAseguradora.CampoEsLlave = False
        Me.cboIdAseguradora.CampoValor = 0
        Me.cboIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAseguradora.FilasVisibles = 33203
        Me.cboIdAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAseguradora.LabelText = "Aseguradora"
        Me.cboIdAseguradora.LabelWidth = 150
        Me.cboIdAseguradora.Lista = ""
        Me.cboIdAseguradora.Location = New System.Drawing.Point(10, 128)
        Me.cboIdAseguradora.MostrarBusquedaColumnas = False
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NombreCampo = "IdAseguradora"
        Me.cboIdAseguradora.Obligatorio = False
        Me.cboIdAseguradora.Query = "select IdAseguradora as Id, Nombre as Aseguradora from Aseguradoras"
        Me.cboIdAseguradora.SelectIndex = 0
        Me.cboIdAseguradora.Size = New System.Drawing.Size(606, 20)
        Me.cboIdAseguradora.SoloLectura = False
        Me.cboIdAseguradora.StringConection = ""
        Me.cboIdAseguradora.TabIndex = 19
        Me.cboIdAseguradora.TextoNuevoItem = ""
        Me.cboIdAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAseguradora.Valor = ""
        '
        'CGPolizasCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(623, 353)
        Me.Controls.Add(Me.cboIdAseguradora)
        Me.Controls.Add(Me.cboResumenFormaEnvio)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtResumenNumeroCartaEnvio)
        Me.Controls.Add(Me.txtResumenFechaEnvio)
        Me.Controls.Add(Me.txtResumenNumeroCuotas)
        Me.Controls.Add(Me.cboResumenFormaPago)
        Me.Controls.Add(Me.txtResumenPrimaIva)
        Me.Controls.Add(Me.txtResumenPrimaAnual)
        Me.Controls.Add(Me.txtResumenSumaAsegurada)
        Me.Controls.Add(Me.txtResumenPlan)
        Me.Controls.Add(Me.txtIdCotizacion)
        Me.Controls.Add(Me.txtIdOferta)
        Me.Name = "CGPolizasCotizacion"
        Me.Text = "Cotizaciones"
        Me.Controls.SetChildIndex(Me.txtIdOferta, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCotizacion, 0)
        Me.Controls.SetChildIndex(Me.txtResumenPlan, 0)
        Me.Controls.SetChildIndex(Me.txtResumenSumaAsegurada, 0)
        Me.Controls.SetChildIndex(Me.txtResumenPrimaAnual, 0)
        Me.Controls.SetChildIndex(Me.txtResumenPrimaIva, 0)
        Me.Controls.SetChildIndex(Me.cboResumenFormaPago, 0)
        Me.Controls.SetChildIndex(Me.txtResumenNumeroCuotas, 0)
        Me.Controls.SetChildIndex(Me.txtResumenFechaEnvio, 0)
        Me.Controls.SetChildIndex(Me.txtResumenNumeroCartaEnvio, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.cboResumenFormaEnvio, 0)
        Me.Controls.SetChildIndex(Me.cboIdAseguradora, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdOferta As STIControles.stiTextBox
    Friend WithEvents txtIdCotizacion As STIControles.stiTextBox
    Friend WithEvents txtResumenPlan As STIControles.stiTextBox
    Friend WithEvents txtResumenSumaAsegurada As STIControles.stiTextBox
    Friend WithEvents txtResumenPrimaIva As STIControles.stiTextBox
    Friend WithEvents txtResumenPrimaAnual As STIControles.stiTextBox
    Friend WithEvents txtResumenNumeroCuotas As STIControles.stiTextBox
    Friend WithEvents cboResumenFormaPago As STIControles.stiComboBox
    Friend WithEvents txtResumenNumeroCartaEnvio As STIControles.stiTextBox
    Friend WithEvents txtResumenFechaEnvio As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboResumenFormaEnvio As STIControles.stiComboBox
    Friend WithEvents cboIdAseguradora As STIControles.stiComboBox

End Class
