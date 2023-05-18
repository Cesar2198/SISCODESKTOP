<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GastosMan
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
        Me.txtIdGasto = New STIControles.stiTextBox
        Me.txtNombreGasto = New STIControles.stiTextBox
        Me.cboFormaPago = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(461, 181)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(277, 181)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(1, 181)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(93, 181)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(553, 181)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(369, 181)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(614, 74)
        Me.lblNombreFormulario.TabIndex = 9
        Me.lblNombreFormulario.Text = "Registro de Gastos"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(185, 181)
        '
        'txtIdGasto
        '
        Me.txtIdGasto.CampoBusqueda = True
        Me.txtIdGasto.CampoEsLlave = True
        Me.txtIdGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdGasto.ControlBackColor = System.Drawing.Color.White
        Me.txtIdGasto.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdGasto.FechaActual = False
        Me.txtIdGasto.Formato = ""
        Me.txtIdGasto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdGasto.LabelText = "Cod. Gasto"
        Me.txtIdGasto.LabelWidth = 100
        Me.txtIdGasto.Location = New System.Drawing.Point(12, 92)
        Me.txtIdGasto.MaxLength = 25
        Me.txtIdGasto.Name = "txtIdGasto"
        Me.txtIdGasto.NombreCampo = "IdGasto"
        Me.txtIdGasto.Obligatorio = True
        Me.txtIdGasto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdGasto.Size = New System.Drawing.Size(300, 20)
        Me.txtIdGasto.SoloLectura = False
        Me.txtIdGasto.TabIndex = 0
        Me.txtIdGasto.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdGasto.Valor = ""
        '
        'txtNombreGasto
        '
        Me.txtNombreGasto.CampoBusqueda = True
        Me.txtNombreGasto.CampoEsLlave = False
        Me.txtNombreGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreGasto.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreGasto.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreGasto.FechaActual = False
        Me.txtNombreGasto.Formato = ""
        Me.txtNombreGasto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreGasto.LabelText = "Nombre Gasto"
        Me.txtNombreGasto.LabelWidth = 100
        Me.txtNombreGasto.Location = New System.Drawing.Point(12, 118)
        Me.txtNombreGasto.MaxLength = 50
        Me.txtNombreGasto.Name = "txtNombreGasto"
        Me.txtNombreGasto.NombreCampo = "NombreGasto"
        Me.txtNombreGasto.Obligatorio = True
        Me.txtNombreGasto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreGasto.Size = New System.Drawing.Size(522, 20)
        Me.txtNombreGasto.SoloLectura = False
        Me.txtNombreGasto.TabIndex = 1
        Me.txtNombreGasto.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreGasto.Valor = ""
        '
        'cboFormaPago
        '
        Me.cboFormaPago.CampoAutoCompletar = 0
        Me.cboFormaPago.CampoBusqueda = False
        Me.cboFormaPago.CampoDisplay = 1
        Me.cboFormaPago.CampoEsLlave = False
        Me.cboFormaPago.CampoValor = 0
        Me.cboFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.cboFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboFormaPago.FilasVisibles = 7
        Me.cboFormaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboFormaPago.LabelText = "Forma Pago"
        Me.cboFormaPago.LabelWidth = 100
        Me.cboFormaPago.Lista = "P Primera Cuota|F Fraccionado "
        Me.cboFormaPago.Location = New System.Drawing.Point(12, 144)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.NombreCampo = "FormaPago"
        Me.cboFormaPago.Obligatorio = True
        Me.cboFormaPago.Query = ""
        Me.cboFormaPago.SelectIndex = -1
        Me.cboFormaPago.Size = New System.Drawing.Size(300, 20)
        Me.cboFormaPago.SoloLectura = False
        Me.cboFormaPago.StringConection = ""
        Me.cboFormaPago.TabIndex = 2
        Me.cboFormaPago.TextoNuevoItem = ""
        Me.cboFormaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboFormaPago.Valor = ""
        '
        'GastosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 209
        Me.ClientSize = New System.Drawing.Size(647, 217)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.txtNombreGasto)
        Me.Controls.Add(Me.txtIdGasto)
        Me.Name = "GastosMan"
        Me.Text = "Registro de  Gastos"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdGasto, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreGasto, 0)
        Me.Controls.SetChildIndex(Me.cboFormaPago, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdGasto As STIControles.stiTextBox
    Friend WithEvents txtNombreGasto As STIControles.stiTextBox
    Friend WithEvents cboFormaPago As STIControles.stiComboBox

End Class
