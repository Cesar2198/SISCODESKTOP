<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartamentosMan))
        Me.txtIdDepartamento = New STIControles.stiTextBox
        Me.txtNombreDepartamento = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(464, 174)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(280, 174)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(3, 174)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(95, 174)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(556, 174)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 174)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(511, 74)
        Me.lblNombreFormulario.TabIndex = 9
        Me.lblNombreFormulario.Text = "Direcciones: Departamentos"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(188, 174)
        Me.btnGuardarComo.TabIndex = 4
        '
        'txtIdDepartamento
        '
        Me.txtIdDepartamento.CampoBusqueda = True
        Me.txtIdDepartamento.CampoEsLlave = True
        Me.txtIdDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdDepartamento.ControlBackColor = System.Drawing.Color.White
        Me.txtIdDepartamento.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdDepartamento.FechaActual = False
        Me.txtIdDepartamento.Formato = ""
        Me.txtIdDepartamento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdDepartamento.LabelText = "Cod. Departamento"
        Me.txtIdDepartamento.LabelWidth = 140
        Me.txtIdDepartamento.Location = New System.Drawing.Point(36, 98)
        Me.txtIdDepartamento.MaxLength = 25
        Me.txtIdDepartamento.Name = "txtIdDepartamento"
        Me.txtIdDepartamento.NombreCampo = "IdDepartamento"
        Me.txtIdDepartamento.Obligatorio = True
        Me.txtIdDepartamento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdDepartamento.Size = New System.Drawing.Size(300, 20)
        Me.txtIdDepartamento.SoloLectura = False
        Me.txtIdDepartamento.TabIndex = 0
        Me.txtIdDepartamento.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdDepartamento.Valor = ""
        '
        'txtNombreDepartamento
        '
        Me.txtNombreDepartamento.CampoBusqueda = True
        Me.txtNombreDepartamento.CampoEsLlave = False
        Me.txtNombreDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreDepartamento.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreDepartamento.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreDepartamento.FechaActual = False
        Me.txtNombreDepartamento.Formato = ""
        Me.txtNombreDepartamento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreDepartamento.LabelText = "Nombre Departamento"
        Me.txtNombreDepartamento.LabelWidth = 140
        Me.txtNombreDepartamento.Location = New System.Drawing.Point(36, 124)
        Me.txtNombreDepartamento.MaxLength = 250
        Me.txtNombreDepartamento.Name = "txtNombreDepartamento"
        Me.txtNombreDepartamento.NombreCampo = "NombreDepartamento"
        Me.txtNombreDepartamento.Obligatorio = True
        Me.txtNombreDepartamento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreDepartamento.Size = New System.Drawing.Size(602, 20)
        Me.txtNombreDepartamento.SoloLectura = False
        Me.txtNombreDepartamento.TabIndex = 1
        Me.txtNombreDepartamento.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreDepartamento.Valor = ""
        '
        'DepartamentosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 106
        Me.ClientSize = New System.Drawing.Size(650, 210)
        Me.Controls.Add(Me.txtNombreDepartamento)
        Me.Controls.Add(Me.txtIdDepartamento)
        Me.Name = "DepartamentosMan"
        Me.Text = "Departamentos"
        Me.Controls.SetChildIndex(Me.txtIdDepartamento, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreDepartamento, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdDepartamento As STIControles.stiTextBox
    Friend WithEvents txtNombreDepartamento As STIControles.stiTextBox

End Class
