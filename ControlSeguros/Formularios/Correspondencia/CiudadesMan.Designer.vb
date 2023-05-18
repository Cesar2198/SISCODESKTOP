<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CiudadesMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CiudadesMan))
        Me.txtIdCiudad = New STIControles.stiTextBox
        Me.txtNombreCiudad = New STIControles.stiTextBox
        Me.cboIdMunicipio = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 191)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(292, 191)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 191)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(107, 191)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 191)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 191)
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
        Me.lblNombreFormulario.Text = "Direcciones: Ciudades"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 191)
        '
        'txtIdCiudad
        '
        Me.txtIdCiudad.CampoBusqueda = True
        Me.txtIdCiudad.CampoEsLlave = True
        Me.txtIdCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCiudad.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCiudad.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCiudad.FechaActual = False
        Me.txtIdCiudad.Formato = ""
        Me.txtIdCiudad.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCiudad.LabelText = "Cod. Ciudad"
        Me.txtIdCiudad.LabelWidth = 120
        Me.txtIdCiudad.Location = New System.Drawing.Point(15, 93)
        Me.txtIdCiudad.MaxLength = 25
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.NombreCampo = "IdCiudad"
        Me.txtIdCiudad.Obligatorio = True
        Me.txtIdCiudad.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCiudad.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCiudad.SoloLectura = False
        Me.txtIdCiudad.TabIndex = 16
        Me.txtIdCiudad.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCiudad.Valor = ""
        '
        'txtNombreCiudad
        '
        Me.txtNombreCiudad.CampoBusqueda = True
        Me.txtNombreCiudad.CampoEsLlave = False
        Me.txtNombreCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCiudad.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCiudad.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCiudad.FechaActual = False
        Me.txtNombreCiudad.Formato = ""
        Me.txtNombreCiudad.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCiudad.LabelText = "Nombre de Ciudad"
        Me.txtNombreCiudad.LabelWidth = 120
        Me.txtNombreCiudad.Location = New System.Drawing.Point(15, 119)
        Me.txtNombreCiudad.MaxLength = 250
        Me.txtNombreCiudad.Name = "txtNombreCiudad"
        Me.txtNombreCiudad.NombreCampo = "NombreCiudad"
        Me.txtNombreCiudad.Obligatorio = True
        Me.txtNombreCiudad.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCiudad.Size = New System.Drawing.Size(635, 20)
        Me.txtNombreCiudad.SoloLectura = False
        Me.txtNombreCiudad.TabIndex = 17
        Me.txtNombreCiudad.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCiudad.Valor = ""
        '
        'cboIdMunicipio
        '
        Me.cboIdMunicipio.CampoAutoCompletar = 0
        Me.cboIdMunicipio.CampoBusqueda = False
        Me.cboIdMunicipio.CampoDisplay = 1
        Me.cboIdMunicipio.CampoEsLlave = False
        Me.cboIdMunicipio.CampoValor = 0
        Me.cboIdMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdMunicipio.ControlBackColor = System.Drawing.Color.White
        Me.cboIdMunicipio.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdMunicipio.FilasVisibles = 7
        Me.cboIdMunicipio.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdMunicipio.LabelText = "Municipio"
        Me.cboIdMunicipio.LabelWidth = 120
        Me.cboIdMunicipio.Lista = ""
        Me.cboIdMunicipio.Location = New System.Drawing.Point(15, 145)
        Me.cboIdMunicipio.Name = "cboIdMunicipio"
        Me.cboIdMunicipio.NombreCampo = "IdMunicipio"
        Me.cboIdMunicipio.Obligatorio = True
        Me.cboIdMunicipio.Query = resources.GetString("cboIdMunicipio.Query")
        Me.cboIdMunicipio.SelectIndex = -1
        Me.cboIdMunicipio.Size = New System.Drawing.Size(635, 20)
        Me.cboIdMunicipio.SoloLectura = False
        Me.cboIdMunicipio.StringConection = ""
        Me.cboIdMunicipio.TabIndex = 18
        Me.cboIdMunicipio.TextoNuevoItem = ""
        Me.cboIdMunicipio.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdMunicipio.Valor = ""
        '
        'CiudadesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 105
        Me.ClientSize = New System.Drawing.Size(662, 227)
        Me.Controls.Add(Me.txtIdCiudad)
        Me.Controls.Add(Me.cboIdMunicipio)
        Me.Controls.Add(Me.txtNombreCiudad)
        Me.Name = "CiudadesMan"
        Me.Text = "Ciudades"
        Me.Controls.SetChildIndex(Me.txtNombreCiudad, 0)
        Me.Controls.SetChildIndex(Me.cboIdMunicipio, 0)
        Me.Controls.SetChildIndex(Me.txtIdCiudad, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdCiudad As STIControles.stiTextBox
    Friend WithEvents txtNombreCiudad As STIControles.stiTextBox
    Friend WithEvents cboIdMunicipio As STIControles.stiComboBox

End Class
