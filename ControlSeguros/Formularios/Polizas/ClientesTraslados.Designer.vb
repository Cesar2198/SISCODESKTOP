<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesTraslados
    Inherits stiFomularios.stiReportes

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesTraslados))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreClienteDestino = New STIControles.stiTextBox
        Me.txtIdClienteDestino = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(264, 325)
        Me.btnAyuda.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(96, 325)
        Me.btnImprimir.Size = New System.Drawing.Size(168, 36)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "&Trasladar Cartera"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(367, 325)
        Me.btnSalir.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(333, 74)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Traslados de Cartera de Clientes"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LabelControl2.Location = New System.Drawing.Point(12, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(446, 48)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = resources.GetString("LabelControl2.Text")
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(209, 152)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(181, 27)
        Me.btnBuscarCliente.TabIndex = 0
        Me.btnBuscarCliente.Text = "Buscar Cliente Origen"
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
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 125
        Me.txtNombreCliente.Location = New System.Drawing.Point(36, 185)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(397, 36)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 6
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 125
        Me.txtIdCliente.Location = New System.Drawing.Point(36, 143)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(167, 36)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 5
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(209, 241)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(181, 27)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Buscar Cliente Destino"
        '
        'txtNombreClienteDestino
        '
        Me.txtNombreClienteDestino.CampoBusqueda = True
        Me.txtNombreClienteDestino.CampoEsLlave = False
        Me.txtNombreClienteDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreClienteDestino.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNombreClienteDestino.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreClienteDestino.FechaActual = False
        Me.txtNombreClienteDestino.Formato = ""
        Me.txtNombreClienteDestino.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNombreClienteDestino.LabelText = "Nombre Cliente Facturas"
        Me.txtNombreClienteDestino.LabelWidth = 125
        Me.txtNombreClienteDestino.Location = New System.Drawing.Point(36, 274)
        Me.txtNombreClienteDestino.MaxLength = 150
        Me.txtNombreClienteDestino.Name = "txtNombreClienteDestino"
        Me.txtNombreClienteDestino.NombreCampo = "NombreCliente"
        Me.txtNombreClienteDestino.Obligatorio = True
        Me.txtNombreClienteDestino.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreClienteDestino.Size = New System.Drawing.Size(397, 36)
        Me.txtNombreClienteDestino.SoloLectura = True
        Me.txtNombreClienteDestino.TabIndex = 8
        Me.txtNombreClienteDestino.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreClienteDestino.Valor = ""
        '
        'txtIdClienteDestino
        '
        Me.txtIdClienteDestino.CampoBusqueda = False
        Me.txtIdClienteDestino.CampoEsLlave = False
        Me.txtIdClienteDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdClienteDestino.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdClienteDestino.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdClienteDestino.FechaActual = False
        Me.txtIdClienteDestino.Formato = ""
        Me.txtIdClienteDestino.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtIdClienteDestino.LabelText = "Cod. Cliente"
        Me.txtIdClienteDestino.LabelWidth = 125
        Me.txtIdClienteDestino.Location = New System.Drawing.Point(36, 232)
        Me.txtIdClienteDestino.MaxLength = 25
        Me.txtIdClienteDestino.Name = "txtIdClienteDestino"
        Me.txtIdClienteDestino.NombreCampo = "IdCliente"
        Me.txtIdClienteDestino.Obligatorio = True
        Me.txtIdClienteDestino.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdClienteDestino.Size = New System.Drawing.Size(167, 36)
        Me.txtIdClienteDestino.SoloLectura = True
        Me.txtIdClienteDestino.TabIndex = 7
        Me.txtIdClienteDestino.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdClienteDestino.Valor = ""
        '
        'ClientesTraslados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 116
        Me.ClientSize = New System.Drawing.Size(470, 363)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtNombreClienteDestino)
        Me.Controls.Add(Me.txtIdClienteDestino)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "ClientesTraslados"
        Me.Text = "Traslados de Cartera"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtIdClienteDestino, 0)
        Me.Controls.SetChildIndex(Me.txtNombreClienteDestino, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreClienteDestino As STIControles.stiTextBox
    Friend WithEvents txtIdClienteDestino As STIControles.stiTextBox

End Class
