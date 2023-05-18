<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoGestionMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipoGestionMan))
        Me.txtIdTipoGestion = New STIControles.stiTextBox
        Me.cboCategoria = New STIControles.stiComboBox
        Me.txtNombreGestion = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(465, 207)
        Me.btnAyuda.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(279, 207)
        Me.btnBuscar.TabIndex = 5
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(0, 207)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(93, 207)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(558, 207)
        Me.btnSalir.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 207)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(616, 74)
        Me.lblNombreFormulario.TabIndex = 0
        Me.lblNombreFormulario.Text = "Registros de Tipos de Gestiones"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(186, 207)
        '
        'txtIdTipoGestion
        '
        Me.txtIdTipoGestion.CampoBusqueda = True
        Me.txtIdTipoGestion.CampoEsLlave = True
        Me.txtIdTipoGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdTipoGestion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdTipoGestion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdTipoGestion.FechaActual = False
        Me.txtIdTipoGestion.Formato = ""
        Me.txtIdTipoGestion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdTipoGestion.LabelText = "Código de Gestión"
        Me.txtIdTipoGestion.LabelWidth = 125
        Me.txtIdTipoGestion.Location = New System.Drawing.Point(22, 90)
        Me.txtIdTipoGestion.MaxLength = 25
        Me.txtIdTipoGestion.Name = "txtIdTipoGestion"
        Me.txtIdTipoGestion.NombreCampo = "IdTipoGestion"
        Me.txtIdTipoGestion.Obligatorio = True
        Me.txtIdTipoGestion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdTipoGestion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdTipoGestion.SoloLectura = False
        Me.txtIdTipoGestion.TabIndex = 0
        Me.txtIdTipoGestion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdTipoGestion.Valor = ""
        '
        'cboCategoria
        '
        Me.cboCategoria.CampoAutoCompletar = 0
        Me.cboCategoria.CampoBusqueda = False
        Me.cboCategoria.CampoDisplay = 1
        Me.cboCategoria.CampoEsLlave = False
        Me.cboCategoria.CampoValor = 0
        Me.cboCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCategoria.ControlBackColor = System.Drawing.Color.White
        Me.cboCategoria.ControlForeColor = System.Drawing.Color.Black
        Me.cboCategoria.FilasVisibles = 7
        Me.cboCategoria.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboCategoria.LabelText = "Categoría de Gestión"
        Me.cboCategoria.LabelWidth = 125
        Me.cboCategoria.Lista = "C Conceptos de Gestión|A Acción a Tomar"
        Me.cboCategoria.Location = New System.Drawing.Point(22, 150)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.NombreCampo = "Categoria"
        Me.cboCategoria.Obligatorio = True
        Me.cboCategoria.Query = ""
        Me.cboCategoria.SelectIndex = -1
        Me.cboCategoria.Size = New System.Drawing.Size(405, 20)
        Me.cboCategoria.SoloLectura = False
        Me.cboCategoria.StringConection = ""
        Me.cboCategoria.TabIndex = 2
        Me.cboCategoria.TextoNuevoItem = ""
        Me.cboCategoria.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboCategoria.Valor = ""
        '
        'txtNombreGestion
        '
        Me.txtNombreGestion.CampoBusqueda = True
        Me.txtNombreGestion.CampoEsLlave = False
        Me.txtNombreGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreGestion.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreGestion.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreGestion.FechaActual = False
        Me.txtNombreGestion.Formato = ""
        Me.txtNombreGestion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreGestion.LabelText = "Nombre de Gestión"
        Me.txtNombreGestion.LabelWidth = 125
        Me.txtNombreGestion.Location = New System.Drawing.Point(22, 120)
        Me.txtNombreGestion.MaxLength = 100
        Me.txtNombreGestion.Name = "txtNombreGestion"
        Me.txtNombreGestion.NombreCampo = "NombreGestion"
        Me.txtNombreGestion.Obligatorio = True
        Me.txtNombreGestion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreGestion.Size = New System.Drawing.Size(522, 20)
        Me.txtNombreGestion.SoloLectura = False
        Me.txtNombreGestion.TabIndex = 1
        Me.txtNombreGestion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreGestion.Valor = ""
        '
        'TipoGestionMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 210
        Me.ClientSize = New System.Drawing.Size(649, 243)
        Me.Controls.Add(Me.txtNombreGestion)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtIdTipoGestion)
        Me.Name = "TipoGestionMan"
        Me.Text = "Tipo de Gestion"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdTipoGestion, 0)
        Me.Controls.SetChildIndex(Me.cboCategoria, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreGestion, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdTipoGestion As STIControles.stiTextBox
    Friend WithEvents cboCategoria As STIControles.stiComboBox
    Friend WithEvents txtNombreGestion As STIControles.stiTextBox

End Class
