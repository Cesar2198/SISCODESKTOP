<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiPersonalizaCampo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New STIControles.stiTextBox
        Me.cboObligatorio = New STIControles.stiComboBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.CampoBusqueda = False
        Me.txtNombre.CampoEsLlave = False
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombre.ControlBackColor = System.Drawing.Color.White
        Me.txtNombre.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombre.FechaActual = False
        Me.txtNombre.Formato = ""
        Me.txtNombre.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombre.LabelText = "Nombre de Campo"
        Me.txtNombre.LabelWidth = 100
        Me.txtNombre.Location = New System.Drawing.Point(12, 12)
        Me.txtNombre.MaxLength = 0
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NombreCampo = ""
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(300, 20)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombre.Valor = ""
        '
        'cboObligatorio
        '
        Me.cboObligatorio.CampoAutoCompletar = 0
        Me.cboObligatorio.CampoBusqueda = False
        Me.cboObligatorio.CampoDisplay = 1
        Me.cboObligatorio.CampoEsLlave = False
        Me.cboObligatorio.CampoValor = 0
        Me.cboObligatorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboObligatorio.ControlBackColor = System.Drawing.Color.White
        Me.cboObligatorio.ControlForeColor = System.Drawing.Color.Black
        Me.cboObligatorio.FilasVisibles = 7
        Me.cboObligatorio.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboObligatorio.LabelText = "Obligatorio"
        Me.cboObligatorio.LabelWidth = 100
        Me.cboObligatorio.Lista = "1 SI|0 NO"
        Me.cboObligatorio.Location = New System.Drawing.Point(12, 38)
        Me.cboObligatorio.Name = "cboObligatorio"
        Me.cboObligatorio.NombreCampo = ""
        Me.cboObligatorio.Obligatorio = False
        Me.cboObligatorio.Query = ""
        Me.cboObligatorio.SelectIndex = -1
        Me.cboObligatorio.Size = New System.Drawing.Size(300, 20)
        Me.cboObligatorio.SoloLectura = False
        Me.cboObligatorio.StringConection = ""
        Me.cboObligatorio.TabIndex = 1
        Me.cboObligatorio.TextoNuevoItem = ""
        Me.cboObligatorio.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboObligatorio.Valor = ""
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(237, 75)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(156, 75)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'stiPersonalizaCampo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 117)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cboObligatorio)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "stiPersonalizaCampo"
        Me.Text = "Personalización de Campos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As STIControles.stiTextBox
    Friend WithEvents cboObligatorio As STIControles.stiComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
