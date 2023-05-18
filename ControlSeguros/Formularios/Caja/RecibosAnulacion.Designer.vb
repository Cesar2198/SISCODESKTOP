<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibosAnulacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibosAnulacion))
        Me.txtTotalRecibo = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtNumRecibo = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtFechaRecibo = New STIControles.stiTextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMotivoAnulacion = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(337, 269)
        Me.btnAyuda.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(374, 81)
        Me.btnBuscar.Size = New System.Drawing.Size(137, 36)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "&Buscar Recibo"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(117, 269)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(-207, 289)
        Me.btnGuardar.Size = New System.Drawing.Size(10, 16)
        Me.btnGuardar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(429, 269)
        Me.btnSalir.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(210, 269)
        Me.btnEliminar.Size = New System.Drawing.Size(128, 36)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "A&nular Recibo"
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(384, 74)
        Me.lblNombreFormulario.TabIndex = 12
        Me.lblNombreFormulario.Text = "Anulación de Recibos de Ingreso"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(-191, 289)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 16)
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
        Me.txtTotalRecibo.LabelWidth = 110
        Me.txtTotalRecibo.Location = New System.Drawing.Point(12, 185)
        Me.txtTotalRecibo.MaxLength = 0
        Me.txtTotalRecibo.Name = "txtTotalRecibo"
        Me.txtTotalRecibo.NombreCampo = "TotalRecibo"
        Me.txtTotalRecibo.Obligatorio = True
        Me.txtTotalRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalRecibo.Size = New System.Drawing.Size(218, 20)
        Me.txtTotalRecibo.SoloLectura = True
        Me.txtTotalRecibo.TabIndex = 10
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
        Me.txtNombreCliente.LabelWidth = 110
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 159)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(401, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 9
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
        Me.txtNumRecibo.LabelWidth = 110
        Me.txtNumRecibo.Location = New System.Drawing.Point(12, 81)
        Me.txtNumRecibo.MaxLength = 0
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.NombreCampo = "IdRecibo"
        Me.txtNumRecibo.Obligatorio = True
        Me.txtNumRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumRecibo.Size = New System.Drawing.Size(218, 20)
        Me.txtNumRecibo.SoloLectura = True
        Me.txtNumRecibo.TabIndex = 6
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
        Me.txtIdCliente.LabelWidth = 110
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 133)
        Me.txtIdCliente.MaxLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(331, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 8
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
        Me.txtFechaRecibo.LabelWidth = 110
        Me.txtFechaRecibo.Location = New System.Drawing.Point(12, 107)
        Me.txtFechaRecibo.MaxLength = 0
        Me.txtFechaRecibo.Name = "txtFechaRecibo"
        Me.txtFechaRecibo.NombreCampo = "FechaRecibo"
        Me.txtFechaRecibo.Obligatorio = True
        Me.txtFechaRecibo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecibo.Size = New System.Drawing.Size(331, 20)
        Me.txtFechaRecibo.SoloLectura = True
        Me.txtFechaRecibo.TabIndex = 7
        Me.txtFechaRecibo.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecibo.Valor = Nothing
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(10, 240)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(403, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "* Nota: solo es posible anular recibos emitidos el mismo día y que no estén Aplic" & _
            "ados"
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.CampoBusqueda = True
        Me.txtMotivoAnulacion.CampoEsLlave = False
        Me.txtMotivoAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoAnulacion.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivoAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoAnulacion.FechaActual = False
        Me.txtMotivoAnulacion.Formato = ""
        Me.txtMotivoAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMotivoAnulacion.LabelText = "Motivo Anulación"
        Me.txtMotivoAnulacion.LabelWidth = 110
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(12, 211)
        Me.txtMotivoAnulacion.MaxLength = 500
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.NombreCampo = "MotivoAnulacion"
        Me.txtMotivoAnulacion.Obligatorio = True
        Me.txtMotivoAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(499, 20)
        Me.txtMotivoAnulacion.SoloLectura = False
        Me.txtMotivoAnulacion.TabIndex = 1
        Me.txtMotivoAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoAnulacion.Valor = ""
        '
        'RecibosAnulacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 402
        Me.ClientSize = New System.Drawing.Size(523, 305)
        Me.Controls.Add(Me.txtMotivoAnulacion)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTotalRecibo)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtNumRecibo)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtFechaRecibo)
        Me.Name = "RecibosAnulacion"
        Me.Text = "Anulación de Recibos"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNumRecibo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtTotalRecibo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoAnulacion, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalRecibo As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtNumRecibo As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtFechaRecibo As STIControles.stiTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMotivoAnulacion As STIControles.stiTextBox

End Class
