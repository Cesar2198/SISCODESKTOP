<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancosMan))
        Me.txtIdBanco = New STIControles.stiTextBox
        Me.txtNombreBanco = New STIControles.stiTextBox
        Me.txtTelefono = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(465, 197)
        Me.btnAyuda.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(281, 197)
        Me.btnBuscar.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(4, 197)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(96, 197)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(557, 197)
        Me.btnSalir.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(373, 197)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(512, 74)
        Me.lblNombreFormulario.TabIndex = 10
        Me.lblNombreFormulario.Text = "Administración de Bancos"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(189, 197)
        Me.btnGuardarComo.TabIndex = 5
        '
        'txtIdBanco
        '
        Me.txtIdBanco.CampoBusqueda = True
        Me.txtIdBanco.CampoEsLlave = True
        Me.txtIdBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdBanco.ControlBackColor = System.Drawing.Color.White
        Me.txtIdBanco.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdBanco.FechaActual = False
        Me.txtIdBanco.Formato = ""
        Me.txtIdBanco.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdBanco.LabelText = "Cod. Banco"
        Me.txtIdBanco.LabelWidth = 100
        Me.txtIdBanco.Location = New System.Drawing.Point(37, 93)
        Me.txtIdBanco.MaxLength = 25
        Me.txtIdBanco.Name = "txtIdBanco"
        Me.txtIdBanco.NombreCampo = "IdBanco"
        Me.txtIdBanco.Obligatorio = True
        Me.txtIdBanco.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdBanco.Size = New System.Drawing.Size(300, 20)
        Me.txtIdBanco.SoloLectura = False
        Me.txtIdBanco.TabIndex = 0
        Me.txtIdBanco.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdBanco.Valor = ""
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.CampoBusqueda = True
        Me.txtNombreBanco.CampoEsLlave = False
        Me.txtNombreBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreBanco.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreBanco.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreBanco.FechaActual = False
        Me.txtNombreBanco.Formato = ""
        Me.txtNombreBanco.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreBanco.LabelText = "Nombre Banco"
        Me.txtNombreBanco.LabelWidth = 100
        Me.txtNombreBanco.Location = New System.Drawing.Point(37, 119)
        Me.txtNombreBanco.MaxLength = 150
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.NombreCampo = "NombreBanco"
        Me.txtNombreBanco.Obligatorio = True
        Me.txtNombreBanco.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreBanco.Size = New System.Drawing.Size(589, 20)
        Me.txtNombreBanco.SoloLectura = False
        Me.txtNombreBanco.TabIndex = 1
        Me.txtNombreBanco.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreBanco.Valor = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.CampoBusqueda = True
        Me.txtTelefono.CampoEsLlave = False
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTelefono.ControlBackColor = System.Drawing.Color.White
        Me.txtTelefono.ControlForeColor = System.Drawing.Color.Black
        Me.txtTelefono.FechaActual = False
        Me.txtTelefono.Formato = ""
        Me.txtTelefono.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTelefono.LabelText = "Teléfono"
        Me.txtTelefono.LabelWidth = 100
        Me.txtTelefono.Location = New System.Drawing.Point(37, 145)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NombreCampo = "Telefono"
        Me.txtTelefono.Obligatorio = False
        Me.txtTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(300, 20)
        Me.txtTelefono.SoloLectura = False
        Me.txtTelefono.TabIndex = 2
        Me.txtTelefono.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTelefono.Valor = ""
        '
        'BancosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 202
        Me.ClientSize = New System.Drawing.Size(651, 233)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombreBanco)
        Me.Controls.Add(Me.txtIdBanco)
        Me.Name = "BancosMan"
        Me.Text = "Bancos"
        Me.Controls.SetChildIndex(Me.txtIdBanco, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreBanco, 0)
        Me.Controls.SetChildIndex(Me.txtTelefono, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdBanco As STIControles.stiTextBox
    Friend WithEvents txtNombreBanco As STIControles.stiTextBox
    Friend WithEvents txtTelefono As STIControles.stiTextBox

End Class
