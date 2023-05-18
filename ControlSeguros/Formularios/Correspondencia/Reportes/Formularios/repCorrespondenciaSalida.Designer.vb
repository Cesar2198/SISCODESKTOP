<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repCorrespondenciaSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repCorrespondenciaSalida))
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.optControl = New System.Windows.Forms.RadioButton
        Me.optMensajero = New System.Windows.Forms.RadioButton
        Me.OptControlEntrada = New System.Windows.Forms.RadioButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cboIdUsuario = New STIControles.stiComboBox
        Me.cboDepto = New STIControles.stiComboBox
        Me.cboRuta = New STIControles.stiComboBox
        Me.txtHoras = New STIControles.stiTextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.optEspecialSalida1 = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(252, 418)
        Me.btnAyuda.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(149, 418)
        Me.btnImprimir.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(355, 418)
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
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.Size = New System.Drawing.Size(321, 74)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Reporte de Correspondencia de Entrada y Salida"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = False
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(32, 89)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(416, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = False
        Me.txtFechaHasta.Formato = "Long Date"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(32, 120)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(414, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'optControl
        '
        Me.optControl.AutoSize = True
        Me.optControl.Checked = True
        Me.optControl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optControl.Location = New System.Drawing.Point(5, 110)
        Me.optControl.Name = "optControl"
        Me.optControl.Size = New System.Drawing.Size(216, 17)
        Me.optControl.TabIndex = 17
        Me.optControl.TabStop = True
        Me.optControl.Text = "Mensajería a Despachar (SALIDA)"
        Me.optControl.UseVisualStyleBackColor = True
        '
        'optMensajero
        '
        Me.optMensajero.AutoSize = True
        Me.optMensajero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optMensajero.Location = New System.Drawing.Point(5, 130)
        Me.optMensajero.Name = "optMensajero"
        Me.optMensajero.Size = New System.Drawing.Size(175, 17)
        Me.optMensajero.TabIndex = 18
        Me.optMensajero.Text = "Hoja de control mensajero"
        Me.optMensajero.UseVisualStyleBackColor = True
        '
        'OptControlEntrada
        '
        Me.OptControlEntrada.AutoSize = True
        Me.OptControlEntrada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.OptControlEntrada.Location = New System.Drawing.Point(5, 26)
        Me.OptControlEntrada.Name = "OptControlEntrada"
        Me.OptControlEntrada.Size = New System.Drawing.Size(204, 17)
        Me.OptControlEntrada.TabIndex = 19
        Me.OptControlEntrada.Text = "Mensajería Recibida (ENTRADA)"
        Me.OptControlEntrada.UseVisualStyleBackColor = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Location = New System.Drawing.Point(0, 84)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(309, 20)
        Me.GroupControl1.TabIndex = 20
        Me.GroupControl1.Text = "CORRESPONDENCIA DE SALIDA"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.optEspecialSalida1)
        Me.GroupControl2.Controls.Add(Me.cboIdUsuario)
        Me.GroupControl2.Controls.Add(Me.cboDepto)
        Me.GroupControl2.Controls.Add(Me.cboRuta)
        Me.GroupControl2.Controls.Add(Me.GroupControl1)
        Me.GroupControl2.Controls.Add(Me.OptControlEntrada)
        Me.GroupControl2.Controls.Add(Me.optControl)
        Me.GroupControl2.Controls.Add(Me.optMensajero)
        Me.GroupControl2.Location = New System.Drawing.Point(137, 174)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(309, 238)
        Me.GroupControl2.TabIndex = 21
        Me.GroupControl2.Text = "CORRESPONDENCIA DE INGRESO"
        '
        'cboIdUsuario
        '
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
        Me.cboIdUsuario.LabelWidth = 85
        Me.cboIdUsuario.Lista = ""
        Me.cboIdUsuario.Location = New System.Drawing.Point(5, 202)
        Me.cboIdUsuario.Name = "cboIdUsuario"
        Me.cboIdUsuario.NombreCampo = "IdUsuarioEntrega"
        Me.cboIdUsuario.Obligatorio = False
        Me.cboIdUsuario.Query = "select idusuario as Id, nombreusuario as Usuario from usuarios"
        Me.cboIdUsuario.SelectIndex = -1
        Me.cboIdUsuario.Size = New System.Drawing.Size(299, 20)
        Me.cboIdUsuario.SoloLectura = False
        Me.cboIdUsuario.StringConection = ""
        Me.cboIdUsuario.TabIndex = 22
        Me.cboIdUsuario.TextoNuevoItem = ""
        Me.cboIdUsuario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdUsuario.Valor = ""
        '
        'cboDepto
        '
        Me.cboDepto.CampoAutoCompletar = 0
        Me.cboDepto.CampoBusqueda = False
        Me.cboDepto.CampoDisplay = 1
        Me.cboDepto.CampoEsLlave = False
        Me.cboDepto.CampoValor = 0
        Me.cboDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDepto.ControlBackColor = System.Drawing.Color.White
        Me.cboDepto.ControlForeColor = System.Drawing.Color.Black
        Me.cboDepto.FilasVisibles = 7
        Me.cboDepto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDepto.LabelText = "Destinatario"
        Me.cboDepto.LabelWidth = 63
        Me.cboDepto.Lista = ""
        Me.cboDepto.Location = New System.Drawing.Point(5, 49)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.NombreCampo = ""
        Me.cboDepto.Obligatorio = False
        Me.cboDepto.Query = "select distinct cast(Departamento as varchar(50)) as Id, Departamento from Usuari" & _
            "os"
        Me.cboDepto.SelectIndex = -1
        Me.cboDepto.Size = New System.Drawing.Size(296, 20)
        Me.cboDepto.SoloLectura = False
        Me.cboDepto.StringConection = ""
        Me.cboDepto.TabIndex = 21
        Me.cboDepto.TextoNuevoItem = ""
        Me.cboDepto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboDepto.Valor = ""
        '
        'cboRuta
        '
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
        Me.cboRuta.LabelWidth = 63
        Me.cboRuta.Lista = ""
        Me.cboRuta.Location = New System.Drawing.Point(8, 176)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.NombreCampo = ""
        Me.cboRuta.Obligatorio = False
        Me.cboRuta.Query = "select IdZona as Id, DescripcionZona as Descripcion from Zonas"
        Me.cboRuta.SelectIndex = -1
        Me.cboRuta.Size = New System.Drawing.Size(296, 20)
        Me.cboRuta.SoloLectura = False
        Me.cboRuta.StringConection = ""
        Me.cboRuta.TabIndex = 19
        Me.cboRuta.TextoNuevoItem = ""
        Me.cboRuta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRuta.Valor = ""
        '
        'txtHoras
        '
        Me.txtHoras.CampoBusqueda = False
        Me.txtHoras.CampoEsLlave = False
        Me.txtHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHoras.ControlBackColor = System.Drawing.Color.White
        Me.txtHoras.ControlForeColor = System.Drawing.Color.Black
        Me.txtHoras.FechaActual = False
        Me.txtHoras.Formato = ""
        Me.txtHoras.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtHoras.LabelText = "Correspondencia de "
        Me.txtHoras.LabelWidth = 100
        Me.txtHoras.Location = New System.Drawing.Point(137, 147)
        Me.txtHoras.MaxLength = 0
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.NombreCampo = ""
        Me.txtHoras.Obligatorio = False
        Me.txtHoras.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHoras.Size = New System.Drawing.Size(155, 20)
        Me.txtHoras.SoloLectura = False
        Me.txtHoras.TabIndex = 22
        Me.txtHoras.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtHoras.Valor = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(299, 150)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "minutos atrás"
        '
        'optEspecialSalida1
        '
        Me.optEspecialSalida1.AutoSize = True
        Me.optEspecialSalida1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optEspecialSalida1.Location = New System.Drawing.Point(5, 153)
        Me.optEspecialSalida1.Name = "optEspecialSalida1"
        Me.optEspecialSalida1.Size = New System.Drawing.Size(175, 17)
        Me.optEspecialSalida1.TabIndex = 23
        Me.optEspecialSalida1.Text = "Hoja de control mensajero"
        Me.optEspecialSalida1.UseVisualStyleBackColor = True
        '
        'repCorrespondenciaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 915
        Me.ClientSize = New System.Drawing.Size(458, 456)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Name = "repCorrespondenciaSalida"
        Me.Text = "Correspondencia"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        Me.Controls.SetChildIndex(Me.txtHoras, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents optControl As System.Windows.Forms.RadioButton
    Friend WithEvents optMensajero As System.Windows.Forms.RadioButton
    Friend WithEvents OptControlEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboRuta As STIControles.stiComboBox
    Friend WithEvents cboDepto As STIControles.stiComboBox
    Friend WithEvents txtHoras As STIControles.stiTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIdUsuario As STIControles.stiComboBox
    Friend WithEvents optEspecialSalida1 As System.Windows.Forms.RadioButton

End Class
