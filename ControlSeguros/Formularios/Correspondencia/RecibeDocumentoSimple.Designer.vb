<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibeDocumentoSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibeDocumentoSimple))
        Me.txtFecha = New STIControles.stiTextBox
        Me.txtRemitente = New STIControles.stiMemo
        Me.txtDetalle = New STIControles.stiMemo
        Me.txtDestinatario = New STIControles.stiTextBox
        Me.cboUsuarios = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(307, 307)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(204, 307)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "&Recibir"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(410, 307)
        Me.btnSalir.TabIndex = 6
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
        Me.LabelControl1.Size = New System.Drawing.Size(376, 74)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Recepción de Mensajería Simplificada"
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = False
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.White
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = True
        Me.txtFecha.Formato = "dd/MMM/yyyy"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha Recepción"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(12, 80)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(300, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'txtRemitente
        '
        Me.txtRemitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemitente.CampoBusqueda = False
        Me.txtRemitente.CampoEsLlave = False
        Me.txtRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRemitente.ControlBackColor = System.Drawing.Color.White
        Me.txtRemitente.ControlForeColor = System.Drawing.Color.Black
        Me.txtRemitente.FechaActual = False
        Me.txtRemitente.Formato = ""
        Me.txtRemitente.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtRemitente.LabelText = "Remitente"
        Me.txtRemitente.LabelWidth = 100
        Me.txtRemitente.Location = New System.Drawing.Point(12, 106)
        Me.txtRemitente.MaxLength = 50
        Me.txtRemitente.Name = "txtRemitente"
        Me.txtRemitente.NombreCampo = ""
        Me.txtRemitente.Obligatorio = True
        Me.txtRemitente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemitente.Size = New System.Drawing.Size(489, 72)
        Me.txtRemitente.SoloLectura = False
        Me.txtRemitente.TabIndex = 1
        Me.txtRemitente.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtRemitente.Valor = ""
        '
        'txtDetalle
        '
        Me.txtDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetalle.CampoBusqueda = False
        Me.txtDetalle.CampoEsLlave = False
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDetalle.ControlBackColor = System.Drawing.Color.White
        Me.txtDetalle.ControlForeColor = System.Drawing.Color.Black
        Me.txtDetalle.FechaActual = False
        Me.txtDetalle.Formato = ""
        Me.txtDetalle.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtDetalle.LabelText = "Detalle"
        Me.txtDetalle.LabelWidth = 100
        Me.txtDetalle.Location = New System.Drawing.Point(12, 184)
        Me.txtDetalle.MaxLength = 0
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.NombreCampo = ""
        Me.txtDetalle.Obligatorio = True
        Me.txtDetalle.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetalle.Size = New System.Drawing.Size(489, 91)
        Me.txtDetalle.SoloLectura = False
        Me.txtDetalle.TabIndex = 2
        Me.txtDetalle.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtDetalle.Valor = ""
        '
        'txtDestinatario
        '
        Me.txtDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinatario.CampoBusqueda = False
        Me.txtDestinatario.CampoEsLlave = False
        Me.txtDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDestinatario.ControlBackColor = System.Drawing.Color.White
        Me.txtDestinatario.ControlForeColor = System.Drawing.Color.Black
        Me.txtDestinatario.FechaActual = False
        Me.txtDestinatario.Formato = ""
        Me.txtDestinatario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDestinatario.LabelText = "Destinatario"
        Me.txtDestinatario.LabelWidth = 100
        Me.txtDestinatario.Location = New System.Drawing.Point(12, 281)
        Me.txtDestinatario.MaxLength = 50
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.NombreCampo = ""
        Me.txtDestinatario.Obligatorio = True
        Me.txtDestinatario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDestinatario.Size = New System.Drawing.Size(470, 20)
        Me.txtDestinatario.SoloLectura = False
        Me.txtDestinatario.TabIndex = 3
        Me.txtDestinatario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDestinatario.Valor = ""
        '
        'cboUsuarios
        '
        Me.cboUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUsuarios.CampoAutoCompletar = 0
        Me.cboUsuarios.CampoBusqueda = False
        Me.cboUsuarios.CampoDisplay = 1
        Me.cboUsuarios.CampoEsLlave = False
        Me.cboUsuarios.CampoValor = 0
        Me.cboUsuarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUsuarios.ControlBackColor = System.Drawing.Color.White
        Me.cboUsuarios.ControlForeColor = System.Drawing.Color.Black
        Me.cboUsuarios.FilasVisibles = 0
        Me.cboUsuarios.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboUsuarios.LabelText = ""
        Me.cboUsuarios.LabelWidth = 0
        Me.cboUsuarios.Lista = ""
        Me.cboUsuarios.Location = New System.Drawing.Point(102, 281)
        Me.cboUsuarios.MostrarBusquedaColumnas = False
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.NombreCampo = ""
        Me.cboUsuarios.Obligatorio = False
        Me.cboUsuarios.Query = resources.GetString("cboUsuarios.Query")
        Me.cboUsuarios.SelectIndex = 0
        Me.cboUsuarios.Size = New System.Drawing.Size(399, 20)
        Me.cboUsuarios.SoloLectura = False
        Me.cboUsuarios.StringConection = ""
        Me.cboUsuarios.TabIndex = 18
        Me.cboUsuarios.TextoNuevoItem = ""
        Me.cboUsuarios.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboUsuarios.Valor = ""
        '
        'RecibeDocumentoSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 914
        Me.ClientSize = New System.Drawing.Size(513, 345)
        Me.Controls.Add(Me.txtDestinatario)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtRemitente)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.cboUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = True
        Me.Name = "RecibeDocumentoSimple"
        Me.Text = "Recepción de Mensajería"
        Me.Controls.SetChildIndex(Me.cboUsuarios, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtDetalle, 0)
        Me.Controls.SetChildIndex(Me.txtRemitente, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.txtDestinatario, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents txtRemitente As STIControles.stiMemo
    Friend WithEvents txtDetalle As STIControles.stiMemo
    Friend WithEvents txtDestinatario As STIControles.stiTextBox
    Friend WithEvents cboUsuarios As STIControles.stiComboBox

End Class
