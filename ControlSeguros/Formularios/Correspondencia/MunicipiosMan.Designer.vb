<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MunicipiosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MunicipiosMan))
        Me.cboIdDepartamento = New STIControles.stiComboBox
        Me.txtIdMunicipio = New STIControles.stiTextBox
        Me.txtNombreMunicipio = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(466, 185)
        Me.btnAyuda.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(282, 185)
        Me.btnBuscar.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(5, 185)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(97, 185)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(558, 185)
        Me.btnSalir.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(374, 185)
        Me.btnEliminar.TabIndex = 7
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(513, 74)
        Me.lblNombreFormulario.TabIndex = 10
        Me.lblNombreFormulario.Text = "Direcciones: Municipios"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(190, 185)
        Me.btnGuardarComo.TabIndex = 5
        '
        'cboIdDepartamento
        '
        Me.cboIdDepartamento.CampoAutoCompletar = 0
        Me.cboIdDepartamento.CampoBusqueda = False
        Me.cboIdDepartamento.CampoDisplay = 1
        Me.cboIdDepartamento.CampoEsLlave = False
        Me.cboIdDepartamento.CampoValor = 0
        Me.cboIdDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdDepartamento.ControlBackColor = System.Drawing.Color.White
        Me.cboIdDepartamento.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdDepartamento.FilasVisibles = 7
        Me.cboIdDepartamento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdDepartamento.LabelText = "Departamento"
        Me.cboIdDepartamento.LabelWidth = 140
        Me.cboIdDepartamento.Lista = ""
        Me.cboIdDepartamento.Location = New System.Drawing.Point(35, 144)
        Me.cboIdDepartamento.Name = "cboIdDepartamento"
        Me.cboIdDepartamento.NombreCampo = "IdDepartamento"
        Me.cboIdDepartamento.Obligatorio = True
        Me.cboIdDepartamento.Query = "select IdDepartamento as ID, NombreDepartamento as DEPARTAMENTO from Departamento" & _
            "s"
        Me.cboIdDepartamento.SelectIndex = -1
        Me.cboIdDepartamento.Size = New System.Drawing.Size(603, 20)
        Me.cboIdDepartamento.SoloLectura = False
        Me.cboIdDepartamento.StringConection = ""
        Me.cboIdDepartamento.TabIndex = 2
        Me.cboIdDepartamento.TextoNuevoItem = ""
        Me.cboIdDepartamento.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdDepartamento.Valor = ""
        '
        'txtIdMunicipio
        '
        Me.txtIdMunicipio.CampoBusqueda = True
        Me.txtIdMunicipio.CampoEsLlave = True
        Me.txtIdMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdMunicipio.ControlBackColor = System.Drawing.Color.White
        Me.txtIdMunicipio.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdMunicipio.FechaActual = False
        Me.txtIdMunicipio.Formato = ""
        Me.txtIdMunicipio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdMunicipio.LabelText = "Cod. Municipio"
        Me.txtIdMunicipio.LabelWidth = 140
        Me.txtIdMunicipio.Location = New System.Drawing.Point(35, 92)
        Me.txtIdMunicipio.MaxLength = 25
        Me.txtIdMunicipio.Name = "txtIdMunicipio"
        Me.txtIdMunicipio.NombreCampo = "IdMunicipio"
        Me.txtIdMunicipio.Obligatorio = True
        Me.txtIdMunicipio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdMunicipio.Size = New System.Drawing.Size(300, 20)
        Me.txtIdMunicipio.SoloLectura = False
        Me.txtIdMunicipio.TabIndex = 0
        Me.txtIdMunicipio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdMunicipio.Valor = ""
        '
        'txtNombreMunicipio
        '
        Me.txtNombreMunicipio.CampoBusqueda = True
        Me.txtNombreMunicipio.CampoEsLlave = False
        Me.txtNombreMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreMunicipio.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreMunicipio.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreMunicipio.FechaActual = False
        Me.txtNombreMunicipio.Formato = ""
        Me.txtNombreMunicipio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreMunicipio.LabelText = "Nombre de Municipio"
        Me.txtNombreMunicipio.LabelWidth = 140
        Me.txtNombreMunicipio.Location = New System.Drawing.Point(35, 118)
        Me.txtNombreMunicipio.MaxLength = 250
        Me.txtNombreMunicipio.Name = "txtNombreMunicipio"
        Me.txtNombreMunicipio.NombreCampo = ""
        Me.txtNombreMunicipio.Obligatorio = True
        Me.txtNombreMunicipio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreMunicipio.Size = New System.Drawing.Size(603, 20)
        Me.txtNombreMunicipio.SoloLectura = False
        Me.txtNombreMunicipio.TabIndex = 1
        Me.txtNombreMunicipio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreMunicipio.Valor = ""
        '
        'MunicipiosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 113
        Me.ClientSize = New System.Drawing.Size(652, 221)
        Me.Controls.Add(Me.txtNombreMunicipio)
        Me.Controls.Add(Me.cboIdDepartamento)
        Me.Controls.Add(Me.txtIdMunicipio)
        Me.Name = "MunicipiosMan"
        Me.Text = "Municipios"
        Me.Controls.SetChildIndex(Me.txtIdMunicipio, 0)
        Me.Controls.SetChildIndex(Me.cboIdDepartamento, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreMunicipio, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIdDepartamento As STIControles.stiComboBox
    Friend WithEvents txtIdMunicipio As STIControles.stiTextBox
    Friend WithEvents txtNombreMunicipio As STIControles.stiTextBox

End Class
