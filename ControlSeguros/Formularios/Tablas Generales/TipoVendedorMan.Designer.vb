<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoVendedorMan
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
        Me.txtNombreTipoVendedor = New STIControles.stiTextBox
        Me.txtIdAseguradora = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(464, 162)
        Me.btnAyuda.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(280, 162)
        Me.btnBuscar.TabIndex = 4
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(2, 162)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(94, 162)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(556, 162)
        Me.btnSalir.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 162)
        Me.btnEliminar.TabIndex = 5
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(617, 74)
        Me.lblNombreFormulario.TabIndex = 8
        Me.lblNombreFormulario.Text = "Registro Tipo de Vendedores"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(187, 162)
        '
        'txtNombreTipoVendedor
        '
        Me.txtNombreTipoVendedor.CampoBusqueda = True
        Me.txtNombreTipoVendedor.CampoEsLlave = False
        Me.txtNombreTipoVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreTipoVendedor.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreTipoVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreTipoVendedor.FechaActual = False
        Me.txtNombreTipoVendedor.Formato = ""
        Me.txtNombreTipoVendedor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreTipoVendedor.LabelText = "Descripción"
        Me.txtNombreTipoVendedor.LabelWidth = 125
        Me.txtNombreTipoVendedor.Location = New System.Drawing.Point(12, 118)
        Me.txtNombreTipoVendedor.MaxLength = 50
        Me.txtNombreTipoVendedor.Name = "txtNombreTipoVendedor"
        Me.txtNombreTipoVendedor.NombreCampo = "NombreTipoVendedor"
        Me.txtNombreTipoVendedor.Obligatorio = True
        Me.txtNombreTipoVendedor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreTipoVendedor.Size = New System.Drawing.Size(532, 20)
        Me.txtNombreTipoVendedor.SoloLectura = False
        Me.txtNombreTipoVendedor.TabIndex = 1
        Me.txtNombreTipoVendedor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreTipoVendedor.Valor = ""
        '
        'txtIdAseguradora
        '
        Me.txtIdAseguradora.CampoBusqueda = True
        Me.txtIdAseguradora.CampoEsLlave = True
        Me.txtIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAseguradora.FechaActual = False
        Me.txtIdAseguradora.Formato = ""
        Me.txtIdAseguradora.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAseguradora.LabelText = "Cod. Tipo Vendedor"
        Me.txtIdAseguradora.LabelWidth = 125
        Me.txtIdAseguradora.Location = New System.Drawing.Point(12, 92)
        Me.txtIdAseguradora.MaxLength = 25
        Me.txtIdAseguradora.Name = "txtIdAseguradora"
        Me.txtIdAseguradora.NombreCampo = "IdTipoVendedor"
        Me.txtIdAseguradora.Obligatorio = True
        Me.txtIdAseguradora.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAseguradora.Size = New System.Drawing.Size(300, 20)
        Me.txtIdAseguradora.SoloLectura = False
        Me.txtIdAseguradora.TabIndex = 0
        Me.txtIdAseguradora.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAseguradora.Valor = ""
        '
        'TipoVendedorMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 208
        Me.ClientSize = New System.Drawing.Size(650, 198)
        Me.Controls.Add(Me.txtNombreTipoVendedor)
        Me.Controls.Add(Me.txtIdAseguradora)
        Me.Name = "TipoVendedorMan"
        Me.Text = "Tipo de Vendedores"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdAseguradora, 0)
        Me.Controls.SetChildIndex(Me.txtNombreTipoVendedor, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombreTipoVendedor As STIControles.stiTextBox
    Friend WithEvents txtIdAseguradora As STIControles.stiTextBox

End Class
