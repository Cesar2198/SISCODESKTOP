<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CondicionesEspMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CondicionesEspMan))
        Me.txtIdCondicion = New STIControles.stiTextBox
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.txtDescripcion = New STIControles.stiMemo
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(463, 248)
        Me.btnAyuda.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(279, 248)
        Me.btnBuscar.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(2, 248)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(94, 248)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(555, 248)
        Me.btnSalir.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(371, 248)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(510, 74)
        Me.lblNombreFormulario.TabIndex = 10
        Me.lblNombreFormulario.Text = "Condiciones Especiales de Pólizas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(187, 248)
        Me.btnGuardarComo.TabIndex = 5
        '
        'txtIdCondicion
        '
        Me.txtIdCondicion.CampoBusqueda = True
        Me.txtIdCondicion.CampoEsLlave = True
        Me.txtIdCondicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCondicion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCondicion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCondicion.FechaActual = False
        Me.txtIdCondicion.Formato = ""
        Me.txtIdCondicion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCondicion.LabelText = "Cod. Condición"
        Me.txtIdCondicion.LabelWidth = 100
        Me.txtIdCondicion.Location = New System.Drawing.Point(37, 97)
        Me.txtIdCondicion.MaxLength = 25
        Me.txtIdCondicion.Name = "txtIdCondicion"
        Me.txtIdCondicion.NombreCampo = "IdCondicion"
        Me.txtIdCondicion.Obligatorio = True
        Me.txtIdCondicion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCondicion.Size = New System.Drawing.Size(319, 20)
        Me.txtIdCondicion.SoloLectura = False
        Me.txtIdCondicion.TabIndex = 0
        Me.txtIdCondicion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCondicion.Valor = ""
        '
        'cboIdRamo
        '
        Me.cboIdRamo.CampoAutoCompletar = 0
        Me.cboIdRamo.CampoBusqueda = True
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = False
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 7
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdRamo.LabelText = "Ramo"
        Me.cboIdRamo.LabelWidth = 100
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(37, 123)
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdRamo"
        Me.cboIdRamo.Obligatorio = True
        Me.cboIdRamo.Query = "select IdRamo as Id, NombreRamo as Ramo from  RamoSeguros order by NombreRamo"
        Me.cboIdRamo.SelectIndex = -1
        Me.cboIdRamo.Size = New System.Drawing.Size(593, 20)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 1
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CampoBusqueda = False
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(37, 149)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(593, 89)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'CondicionesEspMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 503
        Me.ClientSize = New System.Drawing.Size(649, 284)
        Me.Controls.Add(Me.txtIdCondicion)
        Me.Controls.Add(Me.cboIdRamo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "CondicionesEspMan"
        Me.Text = "Condiciones Especiales"
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboIdRamo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCondicion, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdCondicion As STIControles.stiTextBox
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents txtDescripcion As STIControles.stiMemo

End Class
