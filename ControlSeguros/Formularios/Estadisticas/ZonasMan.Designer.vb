<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZonasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZonasMan))
        Me.txtIdZona = New STIControles.stiTextBox
        Me.txtDescripcionZona = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 149)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(292, 149)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 149)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(107, 149)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 149)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 149)
        Me.btnEliminar.TabIndex = 6
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
        Me.lblNombreFormulario.TabIndex = 9
        Me.lblNombreFormulario.Text = "Direcciones: Zonas / Rutas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 149)
        Me.btnGuardarComo.TabIndex = 4
        '
        'txtIdZona
        '
        Me.txtIdZona.CampoBusqueda = True
        Me.txtIdZona.CampoEsLlave = True
        Me.txtIdZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdZona.ControlBackColor = System.Drawing.Color.White
        Me.txtIdZona.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdZona.FechaActual = False
        Me.txtIdZona.Formato = ""
        Me.txtIdZona.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdZona.LabelText = "Cod. Zona"
        Me.txtIdZona.LabelWidth = 100
        Me.txtIdZona.Location = New System.Drawing.Point(35, 89)
        Me.txtIdZona.MaxLength = 25
        Me.txtIdZona.Name = "txtIdZona"
        Me.txtIdZona.NombreCampo = "IdZona"
        Me.txtIdZona.Obligatorio = True
        Me.txtIdZona.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdZona.Size = New System.Drawing.Size(300, 20)
        Me.txtIdZona.SoloLectura = False
        Me.txtIdZona.TabIndex = 0
        Me.txtIdZona.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdZona.Valor = ""
        '
        'txtDescripcionZona
        '
        Me.txtDescripcionZona.CampoBusqueda = True
        Me.txtDescripcionZona.CampoEsLlave = False
        Me.txtDescripcionZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionZona.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionZona.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionZona.FechaActual = False
        Me.txtDescripcionZona.Formato = ""
        Me.txtDescripcionZona.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionZona.LabelText = "Descripción"
        Me.txtDescripcionZona.LabelWidth = 100
        Me.txtDescripcionZona.Location = New System.Drawing.Point(35, 115)
        Me.txtDescripcionZona.MaxLength = 250
        Me.txtDescripcionZona.Name = "txtDescripcionZona"
        Me.txtDescripcionZona.NombreCampo = "DescripcionZona"
        Me.txtDescripcionZona.Obligatorio = True
        Me.txtDescripcionZona.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionZona.Size = New System.Drawing.Size(615, 20)
        Me.txtDescripcionZona.SoloLectura = False
        Me.txtDescripcionZona.TabIndex = 1
        Me.txtDescripcionZona.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionZona.Valor = ""
        '
        'ZonasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 120
        Me.ClientSize = New System.Drawing.Size(662, 185)
        Me.Controls.Add(Me.txtDescripcionZona)
        Me.Controls.Add(Me.txtIdZona)
        Me.Name = "ZonasMan"
        Me.Text = "Administración de Zonas / Rutas"
        Me.Controls.SetChildIndex(Me.txtIdZona, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionZona, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdZona As STIControles.stiTextBox
    Friend WithEvents txtDescripcionZona As STIControles.stiTextBox

End Class
