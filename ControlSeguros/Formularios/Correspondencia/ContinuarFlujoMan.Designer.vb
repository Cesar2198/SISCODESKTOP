<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContinuarFlujoMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContinuarFlujoMan))
        Me.txtIdFlujoDoc = New STIControles.stiTextBox
        Me.cboSiguientePaso = New STIControles.stiComboBox
        Me.txtObservaciones = New STIControles.stiMemo
        Me.cboPendientePor = New STIControles.stiComboBox
        Me.cboDocFinal = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(429, 250)
        Me.btnAyuda.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(-45, 276)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(-29, 276)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(314, 250)
        Me.btnGuardar.Size = New System.Drawing.Size(112, 36)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "A&ctualizar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(524, 250)
        Me.btnSalir.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(47, 276)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(479, 74)
        Me.lblNombreFormulario.Text = "Continuación de Flujos de Correspondencia"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(149, 276)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtIdFlujoDoc
        '
        Me.txtIdFlujoDoc.CampoBusqueda = True
        Me.txtIdFlujoDoc.CampoEsLlave = True
        Me.txtIdFlujoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdFlujoDoc.ControlBackColor = System.Drawing.Color.White
        Me.txtIdFlujoDoc.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdFlujoDoc.FechaActual = False
        Me.txtIdFlujoDoc.Formato = ""
        Me.txtIdFlujoDoc.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdFlujoDoc.LabelText = "Cod.Correspondencia"
        Me.txtIdFlujoDoc.LabelWidth = 150
        Me.txtIdFlujoDoc.Location = New System.Drawing.Point(7, 81)
        Me.txtIdFlujoDoc.MaxLength = 25
        Me.txtIdFlujoDoc.Name = "txtIdFlujoDoc"
        Me.txtIdFlujoDoc.NombreCampo = "IdFlujoDoc"
        Me.txtIdFlujoDoc.Obligatorio = True
        Me.txtIdFlujoDoc.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdFlujoDoc.Size = New System.Drawing.Size(300, 20)
        Me.txtIdFlujoDoc.SoloLectura = False
        Me.txtIdFlujoDoc.TabIndex = 0
        Me.txtIdFlujoDoc.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdFlujoDoc.Valor = ""
        '
        'cboSiguientePaso
        '
        Me.cboSiguientePaso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSiguientePaso.CampoAutoCompletar = 0
        Me.cboSiguientePaso.CampoBusqueda = False
        Me.cboSiguientePaso.CampoDisplay = 1
        Me.cboSiguientePaso.CampoEsLlave = False
        Me.cboSiguientePaso.CampoValor = 0
        Me.cboSiguientePaso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSiguientePaso.ControlBackColor = System.Drawing.Color.White
        Me.cboSiguientePaso.ControlForeColor = System.Drawing.Color.Black
        Me.cboSiguientePaso.FilasVisibles = 29
        Me.cboSiguientePaso.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboSiguientePaso.LabelText = "Siguiente Paso"
        Me.cboSiguientePaso.LabelWidth = 150
        Me.cboSiguientePaso.Lista = ""
        Me.cboSiguientePaso.Location = New System.Drawing.Point(7, 107)
        Me.cboSiguientePaso.MostrarBusquedaColumnas = False
        Me.cboSiguientePaso.Name = "cboSiguientePaso"
        Me.cboSiguientePaso.NombreCampo = ""
        Me.cboSiguientePaso.Obligatorio = True
        Me.cboSiguientePaso.Query = ""
        Me.cboSiguientePaso.SelectIndex = 0
        Me.cboSiguientePaso.Size = New System.Drawing.Size(599, 20)
        Me.cboSiguientePaso.SoloLectura = False
        Me.cboSiguientePaso.StringConection = ""
        Me.cboSiguientePaso.TabIndex = 1
        Me.cboSiguientePaso.TextoNuevoItem = ""
        Me.cboSiguientePaso.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboSiguientePaso.Valor = ""
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.CampoBusqueda = False
        Me.txtObservaciones.CampoEsLlave = False
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservaciones.ControlBackColor = System.Drawing.Color.White
        Me.txtObservaciones.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.FechaActual = False
        Me.txtObservaciones.Formato = ""
        Me.txtObservaciones.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtObservaciones.LabelText = "Observaciones"
        Me.txtObservaciones.LabelWidth = 150
        Me.txtObservaciones.Location = New System.Drawing.Point(7, 133)
        Me.txtObservaciones.MaxLength = 0
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = ""
        Me.txtObservaciones.Obligatorio = True
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(599, 57)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'cboPendientePor
        '
        Me.cboPendientePor.CampoAutoCompletar = 0
        Me.cboPendientePor.CampoBusqueda = False
        Me.cboPendientePor.CampoDisplay = 1
        Me.cboPendientePor.CampoEsLlave = False
        Me.cboPendientePor.CampoValor = 0
        Me.cboPendientePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPendientePor.ControlBackColor = System.Drawing.Color.White
        Me.cboPendientePor.ControlForeColor = System.Drawing.Color.Black
        Me.cboPendientePor.FilasVisibles = 0
        Me.cboPendientePor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboPendientePor.LabelText = "Pendiente Por"
        Me.cboPendientePor.LabelWidth = 150
        Me.cboPendientePor.Lista = ""
        Me.cboPendientePor.Location = New System.Drawing.Point(7, 196)
        Me.cboPendientePor.MostrarBusquedaColumnas = False
        Me.cboPendientePor.Name = "cboPendientePor"
        Me.cboPendientePor.NombreCampo = "PendientePor"
        Me.cboPendientePor.Obligatorio = False
        Me.cboPendientePor.Query = ""
        Me.cboPendientePor.SelectIndex = 0
        Me.cboPendientePor.Size = New System.Drawing.Size(463, 20)
        Me.cboPendientePor.SoloLectura = False
        Me.cboPendientePor.StringConection = ""
        Me.cboPendientePor.TabIndex = 6
        Me.cboPendientePor.TextoNuevoItem = ""
        Me.cboPendientePor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboPendientePor.Valor = ""
        '
        'cboDocFinal
        '
        Me.cboDocFinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDocFinal.CampoAutoCompletar = 0
        Me.cboDocFinal.CampoBusqueda = False
        Me.cboDocFinal.CampoDisplay = 1
        Me.cboDocFinal.CampoEsLlave = False
        Me.cboDocFinal.CampoValor = 0
        Me.cboDocFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDocFinal.ControlBackColor = System.Drawing.Color.White
        Me.cboDocFinal.ControlForeColor = System.Drawing.Color.Black
        Me.cboDocFinal.FilasVisibles = 46
        Me.cboDocFinal.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDocFinal.LabelText = "Doc. con que finaliza flujo"
        Me.cboDocFinal.LabelWidth = 150
        Me.cboDocFinal.Lista = ""
        Me.cboDocFinal.Location = New System.Drawing.Point(7, 220)
        Me.cboDocFinal.MostrarBusquedaColumnas = False
        Me.cboDocFinal.Name = "cboDocFinal"
        Me.cboDocFinal.NombreCampo = ""
        Me.cboDocFinal.Obligatorio = False
        Me.cboDocFinal.Query = ""
        Me.cboDocFinal.SelectIndex = 0
        Me.cboDocFinal.Size = New System.Drawing.Size(599, 20)
        Me.cboDocFinal.SoloLectura = False
        Me.cboDocFinal.StringConection = ""
        Me.cboDocFinal.TabIndex = 17
        Me.cboDocFinal.TextoNuevoItem = ""
        Me.cboDocFinal.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboDocFinal.Valor = ""
        '
        'ContinuarFlujoMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 905
        Me.ClientSize = New System.Drawing.Size(618, 286)
        Me.Controls.Add(Me.cboDocFinal)
        Me.Controls.Add(Me.cboPendientePor)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cboSiguientePaso)
        Me.Controls.Add(Me.txtIdFlujoDoc)
        Me.Name = "ContinuarFlujoMan"
        Me.Text = "Flujos de Trabajo y Correspondencia"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdFlujoDoc, 0)
        Me.Controls.SetChildIndex(Me.cboSiguientePaso, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboPendientePor, 0)
        Me.Controls.SetChildIndex(Me.cboDocFinal, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdFlujoDoc As STIControles.stiTextBox
    Friend WithEvents cboSiguientePaso As STIControles.stiComboBox
    Friend WithEvents txtObservaciones As STIControles.stiMemo
    Friend WithEvents cboPendientePor As STIControles.stiComboBox
    Friend WithEvents cboDocFinal As STIControles.stiComboBox

End Class
