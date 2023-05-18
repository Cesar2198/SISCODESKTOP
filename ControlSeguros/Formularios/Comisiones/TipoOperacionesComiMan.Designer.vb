<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoOperacionesComiMan
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
        Me.txtIdOperacion = New STIControles.stiTextBox
        Me.txtNombre = New STIControles.stiTextBox
        Me.cboTipo = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(371, 177)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(187, 177)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(2, 177)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(94, 177)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(463, 177)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(279, 177)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(418, 74)
        Me.lblNombreFormulario.TabIndex = 9
        Me.lblNombreFormulario.Text = "Operaciones de Comisiones"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(-14, 203)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 10
        Me.btnGuardarComo.Visible = False
        '
        'txtIdOperacion
        '
        Me.txtIdOperacion.CampoBusqueda = True
        Me.txtIdOperacion.CampoEsLlave = True
        Me.txtIdOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdOperacion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdOperacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdOperacion.FechaActual = False
        Me.txtIdOperacion.Formato = ""
        Me.txtIdOperacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdOperacion.LabelText = "Cod. Operación"
        Me.txtIdOperacion.LabelWidth = 100
        Me.txtIdOperacion.Location = New System.Drawing.Point(12, 90)
        Me.txtIdOperacion.MaxLength = 25
        Me.txtIdOperacion.Name = "txtIdOperacion"
        Me.txtIdOperacion.NombreCampo = "IdOperacion"
        Me.txtIdOperacion.Obligatorio = True
        Me.txtIdOperacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdOperacion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdOperacion.SoloLectura = False
        Me.txtIdOperacion.TabIndex = 0
        Me.txtIdOperacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdOperacion.Valor = ""
        '
        'txtNombre
        '
        Me.txtNombre.CampoBusqueda = True
        Me.txtNombre.CampoEsLlave = False
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombre.ControlBackColor = System.Drawing.Color.White
        Me.txtNombre.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombre.FechaActual = False
        Me.txtNombre.Formato = ""
        Me.txtNombre.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombre.LabelText = "Descripción"
        Me.txtNombre.LabelWidth = 100
        Me.txtNombre.Location = New System.Drawing.Point(12, 116)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreCampo = "Nombre"
        Me.txtNombre.Obligatorio = True
        Me.txtNombre.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(533, 20)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombre.Valor = ""
        '
        'cboTipo
        '
        Me.cboTipo.CampoAutoCompletar = 0
        Me.cboTipo.CampoBusqueda = False
        Me.cboTipo.CampoDisplay = 1
        Me.cboTipo.CampoEsLlave = False
        Me.cboTipo.CampoValor = 0
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipo.ControlBackColor = System.Drawing.Color.White
        Me.cboTipo.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipo.FilasVisibles = 7
        Me.cboTipo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipo.LabelText = "Tipo"
        Me.cboTipo.LabelWidth = 100
        Me.cboTipo.Lista = "A Abono|D Descuento"
        Me.cboTipo.Location = New System.Drawing.Point(12, 142)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.NombreCampo = "Tipo"
        Me.cboTipo.Obligatorio = True
        Me.cboTipo.Query = ""
        Me.cboTipo.SelectIndex = -1
        Me.cboTipo.Size = New System.Drawing.Size(300, 20)
        Me.cboTipo.SoloLectura = False
        Me.cboTipo.StringConection = ""
        Me.cboTipo.TabIndex = 2
        Me.cboTipo.TextoNuevoItem = ""
        Me.cboTipo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipo.Valor = ""
        '
        'TipoOperacionesComiMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 607
        Me.ClientSize = New System.Drawing.Size(557, 213)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdOperacion)
        Me.Name = "TipoOperacionesComiMan"
        Me.Text = "Operaciones de Comisiones"
        Me.Controls.SetChildIndex(Me.txtIdOperacion, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.cboTipo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdOperacion As STIControles.stiTextBox
    Friend WithEvents txtNombre As STIControles.stiTextBox
    Friend WithEvents cboTipo As STIControles.stiComboBox

End Class
