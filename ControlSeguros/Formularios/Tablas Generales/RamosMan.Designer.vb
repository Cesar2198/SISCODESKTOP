<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RamosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RamosMan))
        Me.txtIdRamo = New STIControles.stiTextBox
        Me.txtNombreRamo = New STIControles.stiTextBox
        Me.cboIdGrupoRamo = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(462, 193)
        Me.btnAyuda.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(278, 193)
        Me.btnBuscar.TabIndex = 4
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(0, 193)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(92, 193)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(554, 193)
        Me.btnSalir.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(370, 193)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(615, 74)
        Me.lblNombreFormulario.TabIndex = 8
        Me.lblNombreFormulario.Text = "Ramos de Seguros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(185, 193)
        '
        'txtIdRamo
        '
        Me.txtIdRamo.CampoBusqueda = True
        Me.txtIdRamo.CampoEsLlave = True
        Me.txtIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdRamo.FechaActual = False
        Me.txtIdRamo.Formato = ""
        Me.txtIdRamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdRamo.LabelText = "Cod. Ramo"
        Me.txtIdRamo.LabelWidth = 100
        Me.txtIdRamo.Location = New System.Drawing.Point(26, 96)
        Me.txtIdRamo.MaxLength = 25
        Me.txtIdRamo.Name = "txtIdRamo"
        Me.txtIdRamo.NombreCampo = "IdRamo"
        Me.txtIdRamo.Obligatorio = True
        Me.txtIdRamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdRamo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdRamo.SoloLectura = False
        Me.txtIdRamo.TabIndex = 0
        Me.txtIdRamo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdRamo.Valor = ""
        '
        'txtNombreRamo
        '
        Me.txtNombreRamo.CampoBusqueda = True
        Me.txtNombreRamo.CampoEsLlave = False
        Me.txtNombreRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreRamo.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreRamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreRamo.FechaActual = False
        Me.txtNombreRamo.Formato = ""
        Me.txtNombreRamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreRamo.LabelText = "Nombre Ramo"
        Me.txtNombreRamo.LabelWidth = 100
        Me.txtNombreRamo.Location = New System.Drawing.Point(26, 122)
        Me.txtNombreRamo.MaxLength = 100
        Me.txtNombreRamo.Name = "txtNombreRamo"
        Me.txtNombreRamo.NombreCampo = "NombreRamo"
        Me.txtNombreRamo.Obligatorio = True
        Me.txtNombreRamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreRamo.Size = New System.Drawing.Size(518, 20)
        Me.txtNombreRamo.SoloLectura = False
        Me.txtNombreRamo.TabIndex = 1
        Me.txtNombreRamo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreRamo.Valor = ""
        '
        'cboIdGrupoRamo
        '
        Me.cboIdGrupoRamo.CampoAutoCompletar = 0
        Me.cboIdGrupoRamo.CampoBusqueda = True
        Me.cboIdGrupoRamo.CampoDisplay = 1
        Me.cboIdGrupoRamo.CampoEsLlave = False
        Me.cboIdGrupoRamo.CampoValor = 0
        Me.cboIdGrupoRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdGrupoRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdGrupoRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdGrupoRamo.FilasVisibles = 7
        Me.cboIdGrupoRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdGrupoRamo.LabelText = "Grupo Ramo"
        Me.cboIdGrupoRamo.LabelWidth = 100
        Me.cboIdGrupoRamo.Lista = ""
        Me.cboIdGrupoRamo.Location = New System.Drawing.Point(26, 148)
        Me.cboIdGrupoRamo.Name = "cboIdGrupoRamo"
        Me.cboIdGrupoRamo.NombreCampo = "IdGrupoRamo"
        Me.cboIdGrupoRamo.Obligatorio = True
        Me.cboIdGrupoRamo.Query = "select IdGrupoRamo as Id, Descripcion as Grupos from RamosGrupos order by Descrip" & _
            "cion"
        Me.cboIdGrupoRamo.SelectIndex = -1
        Me.cboIdGrupoRamo.Size = New System.Drawing.Size(381, 20)
        Me.cboIdGrupoRamo.SoloLectura = False
        Me.cboIdGrupoRamo.StringConection = ""
        Me.cboIdGrupoRamo.TabIndex = 16
        Me.cboIdGrupoRamo.TextoNuevoItem = ""
        Me.cboIdGrupoRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdGrupoRamo.Valor = ""
        '
        'RamosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 207
        Me.ClientSize = New System.Drawing.Size(648, 229)
        Me.Controls.Add(Me.cboIdGrupoRamo)
        Me.Controls.Add(Me.txtNombreRamo)
        Me.Controls.Add(Me.txtIdRamo)
        Me.Name = "RamosMan"
        Me.Text = "Registro  de Ramo de Seguro"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdRamo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreRamo, 0)
        Me.Controls.SetChildIndex(Me.cboIdGrupoRamo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdRamo As STIControles.stiTextBox
    Friend WithEvents txtNombreRamo As STIControles.stiTextBox
    Friend WithEvents cboIdGrupoRamo As STIControles.stiComboBox

End Class
