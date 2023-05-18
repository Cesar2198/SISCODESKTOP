<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulariosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormulariosMan))
        Me.cboIdAseguradora = New STIControles.stiComboBox
        Me.txtIdFormulario = New STIControles.stiTextBox
        Me.txtRutaFormulario = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.cboTipoFormulario = New STIControles.stiComboBox
        Me.btnAgregarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 230)
        Me.btnAyuda.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(292, 230)
        Me.btnBuscar.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 230)
        Me.btnNuevo.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(107, 230)
        Me.btnGuardar.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 230)
        Me.btnSalir.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 230)
        Me.btnEliminar.TabIndex = 8
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
        Me.lblNombreFormulario.Text = "Formularios de Aseguradoras"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 230)
        Me.btnGuardarComo.TabIndex = 6
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.CampoAutoCompletar = 0
        Me.cboIdAseguradora.CampoBusqueda = True
        Me.cboIdAseguradora.CampoDisplay = 1
        Me.cboIdAseguradora.CampoEsLlave = False
        Me.cboIdAseguradora.CampoValor = 0
        Me.cboIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAseguradora.FilasVisibles = 7
        Me.cboIdAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAseguradora.LabelText = "Aseguradora"
        Me.cboIdAseguradora.LabelWidth = 100
        Me.cboIdAseguradora.Lista = ""
        Me.cboIdAseguradora.Location = New System.Drawing.Point(38, 135)
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NombreCampo = "IdAseguradora"
        Me.cboIdAseguradora.Obligatorio = False
        Me.cboIdAseguradora.Query = "select idaseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nomb" & _
            "re"
        Me.cboIdAseguradora.SelectIndex = -1
        Me.cboIdAseguradora.Size = New System.Drawing.Size(569, 20)
        Me.cboIdAseguradora.SoloLectura = False
        Me.cboIdAseguradora.StringConection = ""
        Me.cboIdAseguradora.TabIndex = 1
        Me.cboIdAseguradora.TextoNuevoItem = ""
        Me.cboIdAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAseguradora.Valor = ""
        '
        'txtIdFormulario
        '
        Me.txtIdFormulario.CampoBusqueda = True
        Me.txtIdFormulario.CampoEsLlave = True
        Me.txtIdFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdFormulario.ControlBackColor = System.Drawing.Color.White
        Me.txtIdFormulario.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdFormulario.FechaActual = False
        Me.txtIdFormulario.Formato = "###"
        Me.txtIdFormulario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdFormulario.LabelText = "Cod. Formulario"
        Me.txtIdFormulario.LabelWidth = 100
        Me.txtIdFormulario.Location = New System.Drawing.Point(38, 81)
        Me.txtIdFormulario.MaxLength = 0
        Me.txtIdFormulario.Name = "txtIdFormulario"
        Me.txtIdFormulario.NombreCampo = "IdFormulario"
        Me.txtIdFormulario.Obligatorio = True
        Me.txtIdFormulario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdFormulario.Size = New System.Drawing.Size(255, 20)
        Me.txtIdFormulario.SoloLectura = False
        Me.txtIdFormulario.TabIndex = 11
        Me.txtIdFormulario.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdFormulario.Valor = 0
        '
        'txtRutaFormulario
        '
        Me.txtRutaFormulario.CampoBusqueda = False
        Me.txtRutaFormulario.CampoEsLlave = False
        Me.txtRutaFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRutaFormulario.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtRutaFormulario.ControlForeColor = System.Drawing.Color.Black
        Me.txtRutaFormulario.FechaActual = False
        Me.txtRutaFormulario.Formato = ""
        Me.txtRutaFormulario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtRutaFormulario.LabelText = "Ruta Formulario"
        Me.txtRutaFormulario.LabelWidth = 100
        Me.txtRutaFormulario.Location = New System.Drawing.Point(38, 194)
        Me.txtRutaFormulario.MaxLength = 250
        Me.txtRutaFormulario.Name = "txtRutaFormulario"
        Me.txtRutaFormulario.NombreCampo = "RutaFormulario"
        Me.txtRutaFormulario.Obligatorio = False
        Me.txtRutaFormulario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRutaFormulario.Size = New System.Drawing.Size(569, 20)
        Me.txtRutaFormulario.SoloLectura = True
        Me.txtRutaFormulario.TabIndex = 12
        Me.txtRutaFormulario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRutaFormulario.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(38, 107)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(569, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'cboTipoFormulario
        '
        Me.cboTipoFormulario.CampoAutoCompletar = 0
        Me.cboTipoFormulario.CampoBusqueda = False
        Me.cboTipoFormulario.CampoDisplay = 1
        Me.cboTipoFormulario.CampoEsLlave = False
        Me.cboTipoFormulario.CampoValor = 0
        Me.cboTipoFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoFormulario.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoFormulario.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoFormulario.FilasVisibles = 7
        Me.cboTipoFormulario.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoFormulario.LabelText = "Tipo Formulario"
        Me.cboTipoFormulario.LabelWidth = 100
        Me.cboTipoFormulario.Lista = "POLIZAS FORMULARIO DE PÓLIZAS|RECLAMOS FORMULARIOS DE RECLAMOS|CARTERA FORMULARIO" & _
            "S DE CARTERA"
        Me.cboTipoFormulario.Location = New System.Drawing.Point(38, 163)
        Me.cboTipoFormulario.Name = "cboTipoFormulario"
        Me.cboTipoFormulario.NombreCampo = "TipoFormulario"
        Me.cboTipoFormulario.Obligatorio = False
        Me.cboTipoFormulario.Query = ""
        Me.cboTipoFormulario.SelectIndex = -1
        Me.cboTipoFormulario.Size = New System.Drawing.Size(389, 20)
        Me.cboTipoFormulario.SoloLectura = False
        Me.cboTipoFormulario.StringConection = ""
        Me.cboTipoFormulario.TabIndex = 2
        Me.cboTipoFormulario.TextoNuevoItem = ""
        Me.cboTipoFormulario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoFormulario.Valor = ""
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Image = CType(resources.GetObject("btnAgregarDoc.Image"), System.Drawing.Image)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(468, 159)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(139, 29)
        Me.btnAgregarDoc.TabIndex = 3
        Me.btnAgregarDoc.Text = "Buscar Archivo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormulariosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 820
        Me.ClientSize = New System.Drawing.Size(662, 266)
        Me.Controls.Add(Me.btnAgregarDoc)
        Me.Controls.Add(Me.cboTipoFormulario)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtRutaFormulario)
        Me.Controls.Add(Me.cboIdAseguradora)
        Me.Controls.Add(Me.txtIdFormulario)
        Me.Name = "FormulariosMan"
        Me.Text = "Formularios"
        Me.Controls.SetChildIndex(Me.txtIdFormulario, 0)
        Me.Controls.SetChildIndex(Me.cboIdAseguradora, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtRutaFormulario, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboTipoFormulario, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarDoc, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIdAseguradora As STIControles.stiComboBox
    Friend WithEvents txtIdFormulario As STIControles.stiTextBox
    Friend WithEvents txtRutaFormulario As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents cboTipoFormulario As STIControles.stiComboBox
    Friend WithEvents btnAgregarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
