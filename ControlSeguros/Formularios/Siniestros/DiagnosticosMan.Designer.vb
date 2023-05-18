<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiagnosticosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiagnosticosMan))
        Me.txtIdDiagnostico = New STIControles.stiTextBox
        Me.txtNombreDiagnostico = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 177)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(292, 177)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 177)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(107, 177)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 177)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 177)
        Me.btnEliminar.TabIndex = 6
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Text = "Mantenimiento de Diagnosticos Médicos"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 177)
        Me.btnGuardarComo.TabIndex = 4
        '
        'txtIdDiagnostico
        '
        Me.txtIdDiagnostico.CampoBusqueda = False
        Me.txtIdDiagnostico.CampoEsLlave = True
        Me.txtIdDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdDiagnostico.ControlBackColor = System.Drawing.Color.White
        Me.txtIdDiagnostico.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdDiagnostico.FechaActual = False
        Me.txtIdDiagnostico.Formato = ""
        Me.txtIdDiagnostico.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdDiagnostico.LabelText = "Código Diagnostico"
        Me.txtIdDiagnostico.LabelWidth = 120
        Me.txtIdDiagnostico.Location = New System.Drawing.Point(15, 96)
        Me.txtIdDiagnostico.MaxLength = 25
        Me.txtIdDiagnostico.Name = "txtIdDiagnostico"
        Me.txtIdDiagnostico.NombreCampo = "IdDiagnostico"
        Me.txtIdDiagnostico.Obligatorio = True
        Me.txtIdDiagnostico.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdDiagnostico.Size = New System.Drawing.Size(300, 20)
        Me.txtIdDiagnostico.SoloLectura = False
        Me.txtIdDiagnostico.TabIndex = 0
        Me.txtIdDiagnostico.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdDiagnostico.Valor = ""
        '
        'txtNombreDiagnostico
        '
        Me.txtNombreDiagnostico.CampoBusqueda = False
        Me.txtNombreDiagnostico.CampoEsLlave = False
        Me.txtNombreDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreDiagnostico.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreDiagnostico.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreDiagnostico.FechaActual = False
        Me.txtNombreDiagnostico.Formato = ""
        Me.txtNombreDiagnostico.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreDiagnostico.LabelText = "Nombre Diagnostico"
        Me.txtNombreDiagnostico.LabelWidth = 120
        Me.txtNombreDiagnostico.Location = New System.Drawing.Point(15, 122)
        Me.txtNombreDiagnostico.MaxLength = 500
        Me.txtNombreDiagnostico.Name = "txtNombreDiagnostico"
        Me.txtNombreDiagnostico.NombreCampo = "NombreDiagnostico"
        Me.txtNombreDiagnostico.Obligatorio = True
        Me.txtNombreDiagnostico.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreDiagnostico.Size = New System.Drawing.Size(635, 20)
        Me.txtNombreDiagnostico.SoloLectura = False
        Me.txtNombreDiagnostico.TabIndex = 1
        Me.txtNombreDiagnostico.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreDiagnostico.Valor = ""
        '
        'DiagnosticosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(662, 213)
        Me.Controls.Add(Me.txtNombreDiagnostico)
        Me.Controls.Add(Me.txtIdDiagnostico)
        Me.Name = "DiagnosticosMan"
        Me.Text = "Diagnosticos"
        Me.Controls.SetChildIndex(Me.txtIdDiagnostico, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreDiagnostico, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdDiagnostico As STIControles.stiTextBox
    Friend WithEvents txtNombreDiagnostico As STIControles.stiTextBox

End Class
