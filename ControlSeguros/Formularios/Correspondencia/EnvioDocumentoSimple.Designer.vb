<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnvioDocumentoSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnvioDocumentoSimple))
        Me.txtFecha = New STIControles.stiTextBox
        Me.txtLugar = New STIControles.stiMemo
        Me.txtDetalle = New STIControles.stiMemo
        Me.txtConfirmacion = New STIControles.stiTextBox
        Me.cboRuta = New STIControles.stiComboBox
        Me.cboIdUsuario = New STIControles.stiComboBox
        Me.txtCliente = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(283, 420)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(176, 420)
        Me.btnImprimir.Size = New System.Drawing.Size(107, 36)
        Me.btnImprimir.Text = "&Enviar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(386, 420)
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
        Me.LabelControl1.Size = New System.Drawing.Size(352, 74)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Envío de Mensajería Simplificada"
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
        Me.txtFecha.LabelText = "Fecha Envío"
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
        'txtLugar
        '
        Me.txtLugar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLugar.CampoBusqueda = False
        Me.txtLugar.CampoEsLlave = False
        Me.txtLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLugar.ControlBackColor = System.Drawing.Color.White
        Me.txtLugar.ControlForeColor = System.Drawing.Color.Black
        Me.txtLugar.FechaActual = False
        Me.txtLugar.Formato = ""
        Me.txtLugar.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtLugar.LabelText = "Lugar"
        Me.txtLugar.LabelWidth = 100
        Me.txtLugar.Location = New System.Drawing.Point(12, 154)
        Me.txtLugar.MaxLength = 250
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.NombreCampo = ""
        Me.txtLugar.Obligatorio = True
        Me.txtLugar.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLugar.Size = New System.Drawing.Size(465, 72)
        Me.txtLugar.SoloLectura = False
        Me.txtLugar.TabIndex = 3
        Me.txtLugar.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtLugar.Valor = ""
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
        Me.txtDetalle.Location = New System.Drawing.Point(12, 232)
        Me.txtDetalle.MaxLength = 0
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.NombreCampo = ""
        Me.txtDetalle.Obligatorio = True
        Me.txtDetalle.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetalle.Size = New System.Drawing.Size(465, 132)
        Me.txtDetalle.SoloLectura = False
        Me.txtDetalle.TabIndex = 4
        Me.txtDetalle.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtDetalle.Valor = ""
        '
        'txtConfirmacion
        '
        Me.txtConfirmacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirmacion.CampoBusqueda = False
        Me.txtConfirmacion.CampoEsLlave = False
        Me.txtConfirmacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtConfirmacion.ControlBackColor = System.Drawing.Color.White
        Me.txtConfirmacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtConfirmacion.FechaActual = False
        Me.txtConfirmacion.Formato = ""
        Me.txtConfirmacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtConfirmacion.LabelText = "Confirmación"
        Me.txtConfirmacion.LabelWidth = 100
        Me.txtConfirmacion.Location = New System.Drawing.Point(12, 395)
        Me.txtConfirmacion.MaxLength = 0
        Me.txtConfirmacion.Name = "txtConfirmacion"
        Me.txtConfirmacion.NombreCampo = ""
        Me.txtConfirmacion.Obligatorio = False
        Me.txtConfirmacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmacion.Size = New System.Drawing.Size(465, 20)
        Me.txtConfirmacion.SoloLectura = False
        Me.txtConfirmacion.TabIndex = 6
        Me.txtConfirmacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtConfirmacion.Valor = ""
        '
        'cboRuta
        '
        Me.cboRuta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRuta.CampoAutoCompletar = 0
        Me.cboRuta.CampoBusqueda = False
        Me.cboRuta.CampoDisplay = 1
        Me.cboRuta.CampoEsLlave = False
        Me.cboRuta.CampoValor = 0
        Me.cboRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRuta.ControlBackColor = System.Drawing.Color.White
        Me.cboRuta.ControlForeColor = System.Drawing.Color.Black
        Me.cboRuta.FilasVisibles = 7
        Me.cboRuta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRuta.LabelText = "Zona / Ruta"
        Me.cboRuta.LabelWidth = 100
        Me.cboRuta.Lista = ""
        Me.cboRuta.Location = New System.Drawing.Point(12, 106)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.NombreCampo = ""
        Me.cboRuta.Obligatorio = True
        Me.cboRuta.Query = "select IdZona as Id, DescripcionZona as Descripcion from Zonas"
        Me.cboRuta.SelectIndex = -1
        Me.cboRuta.Size = New System.Drawing.Size(465, 20)
        Me.cboRuta.SoloLectura = False
        Me.cboRuta.StringConection = ""
        Me.cboRuta.TabIndex = 1
        Me.cboRuta.TextoNuevoItem = ""
        Me.cboRuta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRuta.Valor = ""
        '
        'cboIdUsuario
        '
        Me.cboIdUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdUsuario.CampoAutoCompletar = 0
        Me.cboIdUsuario.CampoBusqueda = False
        Me.cboIdUsuario.CampoDisplay = 1
        Me.cboIdUsuario.CampoEsLlave = False
        Me.cboIdUsuario.CampoValor = 0
        Me.cboIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdUsuario.ControlBackColor = System.Drawing.Color.White
        Me.cboIdUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdUsuario.FilasVisibles = 7
        Me.cboIdUsuario.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdUsuario.LabelText = "Usuario Entrega"
        Me.cboIdUsuario.LabelWidth = 100
        Me.cboIdUsuario.Lista = ""
        Me.cboIdUsuario.Location = New System.Drawing.Point(12, 370)
        Me.cboIdUsuario.Name = "cboIdUsuario"
        Me.cboIdUsuario.NombreCampo = "IdUsuarioEntrega"
        Me.cboIdUsuario.Obligatorio = False
        Me.cboIdUsuario.Query = "select idusuario as Id, nombreusuario as Usuario from usuarios"
        Me.cboIdUsuario.SelectIndex = -1
        Me.cboIdUsuario.Size = New System.Drawing.Size(465, 20)
        Me.cboIdUsuario.SoloLectura = False
        Me.cboIdUsuario.StringConection = ""
        Me.cboIdUsuario.TabIndex = 5
        Me.cboIdUsuario.TextoNuevoItem = ""
        Me.cboIdUsuario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdUsuario.Valor = ""
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCliente.LabelText = "Cliente"
        Me.txtCliente.LabelWidth = 100
        Me.txtCliente.Location = New System.Drawing.Point(12, 130)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(465, 20)
        Me.txtCliente.SoloLectura = False
        Me.txtCliente.TabIndex = 2
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'EnvioDocumentoSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 907
        Me.ClientSize = New System.Drawing.Size(489, 458)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cboIdUsuario)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.cboRuta)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.txtConfirmacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = True
        Me.Name = "EnvioDocumentoSimple"
        Me.Controls.SetChildIndex(Me.txtConfirmacion, 0)
        Me.Controls.SetChildIndex(Me.txtDetalle, 0)
        Me.Controls.SetChildIndex(Me.txtLugar, 0)
        Me.Controls.SetChildIndex(Me.cboRuta, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.cboIdUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents txtLugar As STIControles.stiMemo
    Friend WithEvents txtDetalle As STIControles.stiMemo
    Friend WithEvents txtConfirmacion As STIControles.stiTextBox
    Friend WithEvents cboRuta As STIControles.stiComboBox
    Friend WithEvents cboIdUsuario As STIControles.stiComboBox
    Friend WithEvents txtCliente As STIControles.stiTextBox

End Class
