<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoDeudores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoDeudores))
        Me.btnBuscaSiniestro = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtValorPago = New STIControles.stiTextBox
        Me.txtDescripcionPago = New STIControles.stiTextBox
        Me.txtFechaPago = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(433, 232)
        Me.btnAyuda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(287, 258)
        Me.btnBuscar.Size = New System.Drawing.Size(11, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(255, 258)
        Me.btnNuevo.Size = New System.Drawing.Size(11, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(338, 232)
        Me.btnGuardar.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(525, 232)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(288, 258)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(480, 74)
        Me.lblNombreFormulario.Text = "Pago Deudores Varios"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(271, 258)
        Me.btnGuardarComo.Size = New System.Drawing.Size(11, 10)
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscaSiniestro
        '
        Me.btnBuscaSiniestro.Image = CType(resources.GetObject("btnBuscaSiniestro.Image"), System.Drawing.Image)
        Me.btnBuscaSiniestro.Location = New System.Drawing.Point(310, 77)
        Me.btnBuscaSiniestro.Name = "btnBuscaSiniestro"
        Me.btnBuscaSiniestro.Size = New System.Drawing.Size(126, 27)
        Me.btnBuscaSiniestro.TabIndex = 0
        Me.btnBuscaSiniestro.Text = "Buscar Siniestro"
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
        Me.cboIdProducto.Location = New System.Drawing.Point(4, 133)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = ""
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(606, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 9
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
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
        Me.txtIdSiniestro.Location = New System.Drawing.Point(4, 81)
        Me.txtIdSiniestro.MaxLength = 0
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = ""
        Me.txtIdSiniestro.Obligatorio = True
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(300, 20)
        Me.txtIdSiniestro.SoloLectura = True
        Me.txtIdSiniestro.TabIndex = 7
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
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
        Me.txtIdCertificado.Location = New System.Drawing.Point(335, 107)
        Me.txtIdCertificado.MaxLength = 0
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = ""
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(275, 20)
        Me.txtIdCertificado.SoloLectura = True
        Me.txtIdCertificado.TabIndex = 10
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
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
        Me.txtIdPoliza.Location = New System.Drawing.Point(4, 107)
        Me.txtIdPoliza.MaxLength = 0
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = ""
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 8
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtValorPago
        '
        Me.txtValorPago.CampoBusqueda = False
        Me.txtValorPago.CampoEsLlave = False
        Me.txtValorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorPago.ControlBackColor = System.Drawing.Color.White
        Me.txtValorPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorPago.FechaActual = False
        Me.txtValorPago.Formato = "#,###0.00"
        Me.txtValorPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorPago.LabelText = "Valor Pago"
        Me.txtValorPago.LabelWidth = 120
        Me.txtValorPago.Location = New System.Drawing.Point(4, 211)
        Me.txtValorPago.MaxLength = 0
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.NombreCampo = ""
        Me.txtValorPago.Obligatorio = True
        Me.txtValorPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorPago.Size = New System.Drawing.Size(300, 20)
        Me.txtValorPago.SoloLectura = False
        Me.txtValorPago.TabIndex = 3
        Me.txtValorPago.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorPago.Valor = 0
        '
        'txtDescripcionPago
        '
        Me.txtDescripcionPago.CampoBusqueda = False
        Me.txtDescripcionPago.CampoEsLlave = False
        Me.txtDescripcionPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionPago.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionPago.FechaActual = False
        Me.txtDescripcionPago.Formato = "#,###0.00"
        Me.txtDescripcionPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionPago.LabelText = "Descripción Pago"
        Me.txtDescripcionPago.LabelWidth = 120
        Me.txtDescripcionPago.Location = New System.Drawing.Point(4, 159)
        Me.txtDescripcionPago.MaxLength = 150
        Me.txtDescripcionPago.Name = "txtDescripcionPago"
        Me.txtDescripcionPago.NombreCampo = ""
        Me.txtDescripcionPago.Obligatorio = True
        Me.txtDescripcionPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionPago.Size = New System.Drawing.Size(606, 20)
        Me.txtDescripcionPago.SoloLectura = False
        Me.txtDescripcionPago.TabIndex = 1
        Me.txtDescripcionPago.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionPago.Valor = ""
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
        Me.txtFechaPago.Location = New System.Drawing.Point(4, 185)
        Me.txtFechaPago.MaxLength = 0
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.NombreCampo = ""
        Me.txtFechaPago.Obligatorio = True
        Me.txtFechaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPago.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaPago.SoloLectura = False
        Me.txtFechaPago.TabIndex = 2
        Me.txtFechaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPago.Valor = Nothing
        '
        'PagoDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 808
        Me.ClientSize = New System.Drawing.Size(619, 268)
        Me.Controls.Add(Me.txtValorPago)
        Me.Controls.Add(Me.txtDescripcionPago)
        Me.Controls.Add(Me.txtFechaPago)
        Me.Controls.Add(Me.btnBuscaSiniestro)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdSiniestro)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "PagoDeudores"
        Me.Text = "Deudores Varios"
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
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPago, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionPago, 0)
        Me.Controls.SetChildIndex(Me.txtValorPago, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscaSiniestro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtValorPago As STIControles.stiTextBox
    Friend WithEvents txtDescripcionPago As STIControles.stiTextBox
    Friend WithEvents txtFechaPago As STIControles.stiTextBox

End Class
