<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.txtCliente = New STIControles.stiTextBox
        Me.txtProductId = New STIControles.stiTextBox
        Me.txtSerial = New STIControles.stiTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtCliente.LabelText = "Nombre del Cliente"
        Me.txtCliente.LabelWidth = 100
        Me.txtCliente.Location = New System.Drawing.Point(12, 122)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(416, 36)
        Me.txtCliente.SoloLectura = False
        Me.txtCliente.TabIndex = 0
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'txtProductId
        '
        Me.txtProductId.CampoBusqueda = False
        Me.txtProductId.CampoEsLlave = False
        Me.txtProductId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtProductId.FechaActual = False
        Me.txtProductId.Formato = ""
        Me.txtProductId.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtProductId.LabelText = "Product ID"
        Me.txtProductId.LabelWidth = 100
        Me.txtProductId.Location = New System.Drawing.Point(12, 80)
        Me.txtProductId.MaxLength = 0
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.NombreCampo = ""
        Me.txtProductId.Obligatorio = False
        Me.txtProductId.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductId.Size = New System.Drawing.Size(416, 36)
        Me.txtProductId.SoloLectura = True
        Me.txtProductId.TabIndex = 1
        Me.txtProductId.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtProductId.Valor = ""
        '
        'txtSerial
        '
        Me.txtSerial.CampoBusqueda = False
        Me.txtSerial.CampoEsLlave = False
        Me.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSerial.FechaActual = False
        Me.txtSerial.Formato = ""
        Me.txtSerial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtSerial.LabelText = "Número de Serie"
        Me.txtSerial.LabelWidth = 100
        Me.txtSerial.Location = New System.Drawing.Point(12, 164)
        Me.txtSerial.MaxLength = 0
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.NombreCampo = ""
        Me.txtSerial.Obligatorio = False
        Me.txtSerial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerial.Size = New System.Drawing.Size(416, 36)
        Me.txtSerial.SoloLectura = False
        Me.txtSerial.TabIndex = 2
        Me.txtSerial.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtSerial.Valor = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LabelControl1.Location = New System.Drawing.Point(138, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(303, 74)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Licencia SISCO - Sistema Integrado de Seguros para Corredores"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 209)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(142, 36)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Continuar Demo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(236, 209)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(93, 36)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Activar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(335, 209)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 36)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.txtCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents txtProductId As STIControles.stiTextBox
    Friend WithEvents txtSerial As STIControles.stiTextBox
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton

End Class
