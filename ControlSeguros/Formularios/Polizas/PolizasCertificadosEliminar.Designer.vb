<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolizasCertificadosEliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolizasCertificadosEliminar))
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtCliente = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtPoliza = New STIControles.stiTextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCertificado = New STIControles.stiTextBox
        Me.txtLista = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(297, 280)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(194, 280)
        Me.btnImprimir.Text = "&Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(400, 280)
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
        Me.LabelControl1.Text = "Eliminar Certificado de Pólizas"
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(322, 143)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(142, 27)
        Me.btnBuscarPoliza.TabIndex = 44
        Me.btnBuscarPoliza.Text = "Buscar Certificado"
        '
        'txtCliente
        '
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCliente.LabelText = "Cliente"
        Me.txtCliente.LabelWidth = 110
        Me.txtCliente.Location = New System.Drawing.Point(12, 225)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = True
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(486, 20)
        Me.txtCliente.SoloLectura = True
        Me.txtCliente.TabIndex = 43
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 110
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(12, 173)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = True
        Me.cboProducto.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(486, 20)
        Me.cboProducto.SoloLectura = True
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 42
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'txtPoliza
        '
        Me.txtPoliza.CampoBusqueda = False
        Me.txtPoliza.CampoEsLlave = False
        Me.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPoliza.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPoliza.FechaActual = False
        Me.txtPoliza.Formato = ""
        Me.txtPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPoliza.LabelText = "Número Póliza"
        Me.txtPoliza.LabelWidth = 110
        Me.txtPoliza.Location = New System.Drawing.Point(12, 147)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = True
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtPoliza.SoloLectura = True
        Me.txtPoliza.TabIndex = 41
        Me.txtPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPoliza.Valor = ""
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
        Me.LabelControl2.Location = New System.Drawing.Point(12, 89)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(486, 48)
        Me.LabelControl2.TabIndex = 40
        Me.LabelControl2.Text = "Este programa borrará permanentemente el Certificado especificado, utilizar este " & _
            "programa solo si el Certificado debe ser eliminada o fue creado como prueba."
        '
        'txtCertificado
        '
        Me.txtCertificado.CampoBusqueda = False
        Me.txtCertificado.CampoEsLlave = False
        Me.txtCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCertificado.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtCertificado.FechaActual = False
        Me.txtCertificado.Formato = ""
        Me.txtCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCertificado.LabelText = "Certificado"
        Me.txtCertificado.LabelWidth = 110
        Me.txtCertificado.Location = New System.Drawing.Point(12, 199)
        Me.txtCertificado.MaxLength = 0
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.NombreCampo = ""
        Me.txtCertificado.Obligatorio = True
        Me.txtCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCertificado.Size = New System.Drawing.Size(300, 20)
        Me.txtCertificado.SoloLectura = True
        Me.txtCertificado.TabIndex = 45
        Me.txtCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCertificado.Valor = ""
        '
        'txtLista
        '
        Me.txtLista.CampoBusqueda = False
        Me.txtLista.CampoEsLlave = False
        Me.txtLista.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLista.ControlBackColor = System.Drawing.Color.White
        Me.txtLista.ControlForeColor = System.Drawing.Color.Black
        Me.txtLista.FechaActual = False
        Me.txtLista.Formato = ""
        Me.txtLista.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLista.LabelText = "Lista Certificados"
        Me.txtLista.LabelWidth = 110
        Me.txtLista.Location = New System.Drawing.Point(12, 251)
        Me.txtLista.MaxLength = 0
        Me.txtLista.Name = "txtLista"
        Me.txtLista.NombreCampo = ""
        Me.txtLista.Obligatorio = True
        Me.txtLista.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLista.Size = New System.Drawing.Size(486, 20)
        Me.txtLista.SoloLectura = False
        Me.txtLista.TabIndex = 46
        Me.txtLista.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtLista.Valor = ""
        '
        'PolizasCertificadosEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 102
        Me.ClientSize = New System.Drawing.Size(503, 318)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.txtCertificado)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.LabelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PolizasCertificadosEliminar"
        Me.Text = "Eliminar Certificados"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtLista, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCertificado As STIControles.stiTextBox
    Friend WithEvents txtLista As STIControles.stiTextBox

End Class
