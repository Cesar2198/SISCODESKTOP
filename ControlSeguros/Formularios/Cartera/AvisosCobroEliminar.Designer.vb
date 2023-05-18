<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvisosCobroEliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvisosCobroEliminar))
        Me.btnBuscarAC = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdAC = New STIControles.stiTextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(297, 264)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(194, 264)
        Me.btnImprimir.Text = "&Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(400, 264)
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
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.Text = "Módulo de Administración.                                   Eliminación de Avisos" & _
            " de Cobro/Facturas"
        '
        'btnBuscarAC
        '
        Me.btnBuscarAC.Image = CType(resources.GetObject("btnBuscarAC.Image"), System.Drawing.Image)
        Me.btnBuscarAC.Location = New System.Drawing.Point(389, 130)
        Me.btnBuscarAC.Name = "btnBuscarAC"
        Me.btnBuscarAC.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarAC.TabIndex = 39
        Me.btnBuscarAC.Text = "Buscar AC"
        '
        'txtIdAC
        '
        Me.txtIdAC.CampoBusqueda = False
        Me.txtIdAC.CampoEsLlave = False
        Me.txtIdAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAC.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdAC.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAC.FechaActual = False
        Me.txtIdAC.Formato = ""
        Me.txtIdAC.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAC.LabelText = "Borrar el número de AC:"
        Me.txtIdAC.LabelWidth = 185
        Me.txtIdAC.Location = New System.Drawing.Point(10, 134)
        Me.txtIdAC.MaxLength = 0
        Me.txtIdAC.Name = "txtIdAC"
        Me.txtIdAC.NombreCampo = ""
        Me.txtIdAC.Obligatorio = True
        Me.txtIdAC.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAC.Size = New System.Drawing.Size(356, 20)
        Me.txtIdAC.SoloLectura = True
        Me.txtIdAC.TabIndex = 36
        Me.txtIdAC.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAC.Valor = ""
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LabelControl2.Location = New System.Drawing.Point(10, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(486, 48)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "Este programa borrará permanentemente los avisos de cobro y las facturas incluida" & _
            "s en el aviso, utilizar este programa solo si el AC debe ser eliminado o fue cre" & _
            "ada como prueba."
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
        Me.txtIdPoliza.LabelText = "Borrar todos los AC de la póliza:"
        Me.txtIdPoliza.LabelWidth = 185
        Me.txtIdPoliza.Location = New System.Drawing.Point(10, 170)
        Me.txtIdPoliza.MaxLength = 0
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = ""
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(356, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 40
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
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
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Borrar todos los AC del cliente:"
        Me.txtIdCliente.LabelWidth = 185
        Me.txtIdCliente.Location = New System.Drawing.Point(10, 208)
        Me.txtIdCliente.MaxLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = ""
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(356, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 41
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(389, 166)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarPoliza.TabIndex = 42
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(389, 204)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 43
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'AvisosCobroEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 103
        Me.ClientSize = New System.Drawing.Size(503, 302)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.btnBuscarAC)
        Me.Controls.Add(Me.txtIdAC)
        Me.Controls.Add(Me.LabelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AvisosCobroEliminar"
        Me.Text = "Eliminación de Avisos de Cobro"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtIdAC, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarAC, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarAC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdAC As STIControles.stiTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton

End Class
