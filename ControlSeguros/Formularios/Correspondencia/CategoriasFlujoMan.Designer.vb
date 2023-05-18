<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriasFlujoMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriasFlujoMan))
        Me.txtIdCategoria = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtCoordinadores = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(464, 187)
        Me.btnAyuda.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(280, 187)
        Me.btnBuscar.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(3, 187)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(95, 187)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(556, 187)
        Me.btnSalir.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 187)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(511, 74)
        Me.lblNombreFormulario.TabIndex = 10
        Me.lblNombreFormulario.Text = "Categorías de Flujos de Trabajo"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(188, 187)
        Me.btnGuardarComo.TabIndex = 5
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.CampoBusqueda = True
        Me.txtIdCategoria.CampoEsLlave = True
        Me.txtIdCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCategoria.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCategoria.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCategoria.FechaActual = False
        Me.txtIdCategoria.Formato = ""
        Me.txtIdCategoria.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCategoria.LabelText = "Código Categoría"
        Me.txtIdCategoria.LabelWidth = 150
        Me.txtIdCategoria.Location = New System.Drawing.Point(25, 91)
        Me.txtIdCategoria.MaxLength = 25
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.NombreCampo = "IdCategoria"
        Me.txtIdCategoria.Obligatorio = True
        Me.txtIdCategoria.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCategoria.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCategoria.SoloLectura = False
        Me.txtIdCategoria.TabIndex = 0
        Me.txtIdCategoria.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCategoria.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 150
        Me.txtDescripcion.Location = New System.Drawing.Point(25, 117)
        Me.txtDescripcion.MaxLength = 75
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(589, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtCoordinadores
        '
        Me.txtCoordinadores.CampoBusqueda = False
        Me.txtCoordinadores.CampoEsLlave = False
        Me.txtCoordinadores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCoordinadores.ControlBackColor = System.Drawing.Color.White
        Me.txtCoordinadores.ControlForeColor = System.Drawing.Color.Black
        Me.txtCoordinadores.FechaActual = False
        Me.txtCoordinadores.Formato = ""
        Me.txtCoordinadores.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCoordinadores.LabelText = "Lista Usuarios Coordinadores"
        Me.txtCoordinadores.LabelWidth = 150
        Me.txtCoordinadores.Location = New System.Drawing.Point(25, 143)
        Me.txtCoordinadores.MaxLength = 150
        Me.txtCoordinadores.Name = "txtCoordinadores"
        Me.txtCoordinadores.NombreCampo = "Coordinadores"
        Me.txtCoordinadores.Obligatorio = False
        Me.txtCoordinadores.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCoordinadores.Size = New System.Drawing.Size(589, 20)
        Me.txtCoordinadores.SoloLectura = False
        Me.txtCoordinadores.TabIndex = 2
        Me.txtCoordinadores.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCoordinadores.Valor = ""
        '
        'CategoriasFlujoMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 104
        Me.ClientSize = New System.Drawing.Size(650, 223)
        Me.Controls.Add(Me.txtCoordinadores)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdCategoria)
        Me.Name = "CategoriasFlujoMan"
        Me.Text = "Categorías"
        Me.Controls.SetChildIndex(Me.txtIdCategoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCoordinadores, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdCategoria As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtCoordinadores As STIControles.stiTextBox

End Class
