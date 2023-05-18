<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.StiTextBox1 = New STIControles.stiTextBox
        Me.StiTextBox2 = New STIControles.stiTextBox
        Me.StiTextBox3 = New STIControles.stiTextBox
        Me.StiTextBox4 = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(371, 216)
        Me.btnAyuda.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(187, 216)
        Me.btnBuscar.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(3, 216)
        Me.btnNuevo.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(95, 216)
        Me.btnGuardar.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(463, 216)
        Me.btnSalir.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(279, 216)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(418, 74)
        Me.lblNombreFormulario.Text = "Mantenimiento de Clientes"
        '
        'StiTextBox1
        '
        Me.StiTextBox1.CampoBusqueda = True
        Me.StiTextBox1.CampoEsLlave = True
        Me.StiTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox1.FechaActual = False
        Me.StiTextBox1.Formato = "###0"
        Me.StiTextBox1.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox1.LabelText = "Id"
        Me.StiTextBox1.LabelWidth = 100
        Me.StiTextBox1.Location = New System.Drawing.Point(71, 93)
        Me.StiTextBox1.Name = "StiTextBox1"
        Me.StiTextBox1.NombreCampo = "id"
        Me.StiTextBox1.Obligatorio = True
        Me.StiTextBox1.Size = New System.Drawing.Size(402, 20)
        Me.StiTextBox1.SoloLectura = False
        Me.StiTextBox1.TabIndex = 0
        Me.StiTextBox1.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.StiTextBox1.Valor = 0
        '
        'StiTextBox2
        '
        Me.StiTextBox2.CampoBusqueda = True
        Me.StiTextBox2.CampoEsLlave = False
        Me.StiTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox2.FechaActual = False
        Me.StiTextBox2.Formato = ""
        Me.StiTextBox2.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox2.LabelText = "Nombre Cliente"
        Me.StiTextBox2.LabelWidth = 100
        Me.StiTextBox2.Location = New System.Drawing.Point(71, 119)
        Me.StiTextBox2.Name = "StiTextBox2"
        Me.StiTextBox2.NombreCampo = "nombre"
        Me.StiTextBox2.Obligatorio = False
        Me.StiTextBox2.Size = New System.Drawing.Size(402, 20)
        Me.StiTextBox2.SoloLectura = False
        Me.StiTextBox2.TabIndex = 1
        Me.StiTextBox2.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox2.Valor = ""
        '
        'StiTextBox3
        '
        Me.StiTextBox3.CampoBusqueda = True
        Me.StiTextBox3.CampoEsLlave = False
        Me.StiTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox3.FechaActual = False
        Me.StiTextBox3.Formato = ""
        Me.StiTextBox3.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox3.LabelText = "Fecha"
        Me.StiTextBox3.LabelWidth = 100
        Me.StiTextBox3.Location = New System.Drawing.Point(71, 145)
        Me.StiTextBox3.Name = "StiTextBox3"
        Me.StiTextBox3.NombreCampo = "Fecha"
        Me.StiTextBox3.Obligatorio = False
        Me.StiTextBox3.Size = New System.Drawing.Size(402, 20)
        Me.StiTextBox3.SoloLectura = False
        Me.StiTextBox3.TabIndex = 2
        Me.StiTextBox3.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.StiTextBox3.Valor = Nothing
        '
        'StiTextBox4
        '
        Me.StiTextBox4.CampoBusqueda = True
        Me.StiTextBox4.CampoEsLlave = False
        Me.StiTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox4.FechaActual = False
        Me.StiTextBox4.Formato = "#,###0.00"
        Me.StiTextBox4.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox4.LabelText = "Valor"
        Me.StiTextBox4.LabelWidth = 100
        Me.StiTextBox4.Location = New System.Drawing.Point(71, 171)
        Me.StiTextBox4.Name = "StiTextBox4"
        Me.StiTextBox4.NombreCampo = "valor"
        Me.StiTextBox4.Obligatorio = False
        Me.StiTextBox4.Size = New System.Drawing.Size(402, 20)
        Me.StiTextBox4.SoloLectura = False
        Me.StiTextBox4.TabIndex = 3
        Me.StiTextBox4.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.StiTextBox4.Valor = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(557, 257)
        Me.Controls.Add(Me.StiTextBox4)
        Me.Controls.Add(Me.StiTextBox3)
        Me.Controls.Add(Me.StiTextBox2)
        Me.Controls.Add(Me.StiTextBox1)
        Me.Name = "Form2"
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox1, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox2, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox3, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox4, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StiTextBox1 As STIControles.stiTextBox
    Friend WithEvents StiTextBox2 As STIControles.stiTextBox
    Friend WithEvents StiTextBox3 As STIControles.stiTextBox
    Friend WithEvents StiTextBox4 As STIControles.stiTextBox

End Class
