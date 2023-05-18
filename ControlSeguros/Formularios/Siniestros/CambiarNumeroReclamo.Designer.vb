<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarNumeroReclamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarNumeroReclamo))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.btnBuscaReclamo = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdProductoNuevo = New STIControles.stiComboBox
        Me.txtIdSiniestroNuevo = New STIControles.stiTextBox
        Me.txtIdCertificadoNuevo = New STIControles.stiTextBox
        Me.txtIdPolizaNuevo = New STIControles.stiTextBox
        Me.btnBuscaCertificado = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(455, 302)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(352, 302)
        Me.btnImprimir.Text = "&Cambiar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(558, 302)
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
        Me.LabelControl1.Size = New System.Drawing.Size(524, 74)
        Me.LabelControl1.Text = "Cambios de Número de Reclamo y Póliza"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnBuscaReclamo)
        Me.GroupControl1.Controls.Add(Me.cboIdProducto)
        Me.GroupControl1.Controls.Add(Me.txtIdSiniestro)
        Me.GroupControl1.Controls.Add(Me.txtIdCertificado)
        Me.GroupControl1.Controls.Add(Me.txtIdPoliza)
        Me.GroupControl1.Location = New System.Drawing.Point(7, 80)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(642, 106)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Reclamo Actual"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.btnBuscaCertificado)
        Me.GroupControl2.Controls.Add(Me.cboIdProductoNuevo)
        Me.GroupControl2.Controls.Add(Me.txtIdSiniestroNuevo)
        Me.GroupControl2.Controls.Add(Me.txtIdCertificadoNuevo)
        Me.GroupControl2.Controls.Add(Me.txtIdPolizaNuevo)
        Me.GroupControl2.Location = New System.Drawing.Point(7, 192)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(642, 104)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "Nuevo Reclamo"
        '
        'cboIdProducto
        '
        Me.cboIdProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 120
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(16, 76)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(621, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 9
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = True
        Me.txtIdSiniestro.CampoEsLlave = True
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Núm. Reclamo"
        Me.txtIdSiniestro.LabelWidth = 120
        Me.txtIdSiniestro.Location = New System.Drawing.Point(16, 26)
        Me.txtIdSiniestro.MaxLength = 25
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = "IdSiniestro"
        Me.txtIdSiniestro.Obligatorio = True
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(262, 20)
        Me.txtIdSiniestro.SoloLectura = True
        Me.txtIdSiniestro.TabIndex = 6
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdCertificado.CampoBusqueda = True
        Me.txtIdCertificado.CampoEsLlave = True
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 110
        Me.txtIdCertificado.Location = New System.Drawing.Point(284, 52)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(353, 20)
        Me.txtIdCertificado.SoloLectura = True
        Me.txtIdCertificado.TabIndex = 8
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 120
        Me.txtIdPoliza.Location = New System.Drawing.Point(16, 52)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(262, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 7
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'btnBuscaReclamo
        '
        Me.btnBuscaReclamo.Image = CType(resources.GetObject("btnBuscaReclamo.Image"), System.Drawing.Image)
        Me.btnBuscaReclamo.Location = New System.Drawing.Point(290, 23)
        Me.btnBuscaReclamo.Name = "btnBuscaReclamo"
        Me.btnBuscaReclamo.Size = New System.Drawing.Size(158, 27)
        Me.btnBuscaReclamo.TabIndex = 30
        Me.btnBuscaReclamo.Text = "Buscar Siniestro"
        '
        'cboIdProductoNuevo
        '
        Me.cboIdProductoNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdProductoNuevo.CampoAutoCompletar = 0
        Me.cboIdProductoNuevo.CampoBusqueda = True
        Me.cboIdProductoNuevo.CampoDisplay = 1
        Me.cboIdProductoNuevo.CampoEsLlave = True
        Me.cboIdProductoNuevo.CampoValor = 0
        Me.cboIdProductoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProductoNuevo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProductoNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProductoNuevo.FilasVisibles = 7
        Me.cboIdProductoNuevo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProductoNuevo.LabelText = "Producto"
        Me.cboIdProductoNuevo.LabelWidth = 120
        Me.cboIdProductoNuevo.Lista = ""
        Me.cboIdProductoNuevo.Location = New System.Drawing.Point(16, 73)
        Me.cboIdProductoNuevo.Name = "cboIdProductoNuevo"
        Me.cboIdProductoNuevo.NombreCampo = "IdProducto"
        Me.cboIdProductoNuevo.Obligatorio = True
        Me.cboIdProductoNuevo.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProductoNuevo.SelectIndex = -1
        Me.cboIdProductoNuevo.Size = New System.Drawing.Size(621, 20)
        Me.cboIdProductoNuevo.SoloLectura = False
        Me.cboIdProductoNuevo.StringConection = ""
        Me.cboIdProductoNuevo.TabIndex = 13
        Me.cboIdProductoNuevo.TextoNuevoItem = ""
        Me.cboIdProductoNuevo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProductoNuevo.Valor = ""
        '
        'txtIdSiniestroNuevo
        '
        Me.txtIdSiniestroNuevo.CampoBusqueda = True
        Me.txtIdSiniestroNuevo.CampoEsLlave = True
        Me.txtIdSiniestroNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestroNuevo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdSiniestroNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestroNuevo.FechaActual = False
        Me.txtIdSiniestroNuevo.Formato = ""
        Me.txtIdSiniestroNuevo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestroNuevo.LabelText = "Núm. Reclamo"
        Me.txtIdSiniestroNuevo.LabelWidth = 120
        Me.txtIdSiniestroNuevo.Location = New System.Drawing.Point(16, 23)
        Me.txtIdSiniestroNuevo.MaxLength = 25
        Me.txtIdSiniestroNuevo.Name = "txtIdSiniestroNuevo"
        Me.txtIdSiniestroNuevo.NombreCampo = "IdSiniestro"
        Me.txtIdSiniestroNuevo.Obligatorio = True
        Me.txtIdSiniestroNuevo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestroNuevo.Size = New System.Drawing.Size(262, 20)
        Me.txtIdSiniestroNuevo.SoloLectura = False
        Me.txtIdSiniestroNuevo.TabIndex = 10
        Me.txtIdSiniestroNuevo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestroNuevo.Valor = ""
        '
        'txtIdCertificadoNuevo
        '
        Me.txtIdCertificadoNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdCertificadoNuevo.CampoBusqueda = True
        Me.txtIdCertificadoNuevo.CampoEsLlave = True
        Me.txtIdCertificadoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificadoNuevo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCertificadoNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificadoNuevo.FechaActual = False
        Me.txtIdCertificadoNuevo.Formato = ""
        Me.txtIdCertificadoNuevo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificadoNuevo.LabelText = "Certificado"
        Me.txtIdCertificadoNuevo.LabelWidth = 110
        Me.txtIdCertificadoNuevo.Location = New System.Drawing.Point(284, 49)
        Me.txtIdCertificadoNuevo.MaxLength = 25
        Me.txtIdCertificadoNuevo.Name = "txtIdCertificadoNuevo"
        Me.txtIdCertificadoNuevo.NombreCampo = "IdCertificado"
        Me.txtIdCertificadoNuevo.Obligatorio = True
        Me.txtIdCertificadoNuevo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificadoNuevo.Size = New System.Drawing.Size(353, 20)
        Me.txtIdCertificadoNuevo.SoloLectura = False
        Me.txtIdCertificadoNuevo.TabIndex = 12
        Me.txtIdCertificadoNuevo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificadoNuevo.Valor = ""
        '
        'txtIdPolizaNuevo
        '
        Me.txtIdPolizaNuevo.CampoBusqueda = True
        Me.txtIdPolizaNuevo.CampoEsLlave = True
        Me.txtIdPolizaNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPolizaNuevo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPolizaNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPolizaNuevo.FechaActual = False
        Me.txtIdPolizaNuevo.Formato = ""
        Me.txtIdPolizaNuevo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPolizaNuevo.LabelText = "Póliza"
        Me.txtIdPolizaNuevo.LabelWidth = 120
        Me.txtIdPolizaNuevo.Location = New System.Drawing.Point(16, 49)
        Me.txtIdPolizaNuevo.MaxLength = 25
        Me.txtIdPolizaNuevo.Name = "txtIdPolizaNuevo"
        Me.txtIdPolizaNuevo.NombreCampo = "IdPoliza"
        Me.txtIdPolizaNuevo.Obligatorio = True
        Me.txtIdPolizaNuevo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPolizaNuevo.Size = New System.Drawing.Size(262, 20)
        Me.txtIdPolizaNuevo.SoloLectura = False
        Me.txtIdPolizaNuevo.TabIndex = 11
        Me.txtIdPolizaNuevo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPolizaNuevo.Valor = ""
        '
        'btnBuscaCertificado
        '
        Me.btnBuscaCertificado.Image = CType(resources.GetObject("btnBuscaCertificado.Image"), System.Drawing.Image)
        Me.btnBuscaCertificado.Location = New System.Drawing.Point(290, 21)
        Me.btnBuscaCertificado.Name = "btnBuscaCertificado"
        Me.btnBuscaCertificado.Size = New System.Drawing.Size(158, 27)
        Me.btnBuscaCertificado.TabIndex = 26
        Me.btnBuscaCertificado.Text = "Buscar Certificado"
        '
        'CambiarNumeroReclamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(661, 340)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "CambiarNumeroReclamo"
        Me.Text = "Cambios Reclamos"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents btnBuscaReclamo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdProductoNuevo As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestroNuevo As STIControles.stiTextBox
    Friend WithEvents txtIdCertificadoNuevo As STIControles.stiTextBox
    Friend WithEvents txtIdPolizaNuevo As STIControles.stiTextBox
    Friend WithEvents btnBuscaCertificado As DevExpress.XtraEditors.SimpleButton

End Class
