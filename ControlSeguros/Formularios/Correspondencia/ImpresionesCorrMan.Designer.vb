<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionesCorrMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpresionesCorrMan))
        Me.cboIdFlujoDoc = New STIControles.stiComboBox
        Me.txtIdImpresion = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtFechaImpresion = New STIControles.stiTextBox
        Me.txtUsuarioImprime = New STIControles.stiTextBox
        Me.txtUsuarioAnula = New STIControles.stiTextBox
        Me.txtFechaAnulacion = New STIControles.stiTextBox
        Me.StiTextBox1 = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(454, 296)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(361, 296)
        Me.btnBuscar.TabIndex = 9
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(58, 322)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(268, 296)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(546, 296)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(252, 322)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Visible = False
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(501, 74)
        Me.lblNombreFormulario.TabIndex = 12
        Me.lblNombreFormulario.Text = "Anulación de Impresiones"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(153, 322)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 14
        Me.btnGuardarComo.Visible = False
        '
        'cboIdFlujoDoc
        '
        Me.cboIdFlujoDoc.CampoAutoCompletar = 0
        Me.cboIdFlujoDoc.CampoBusqueda = False
        Me.cboIdFlujoDoc.CampoDisplay = 1
        Me.cboIdFlujoDoc.CampoEsLlave = True
        Me.cboIdFlujoDoc.CampoValor = 0
        Me.cboIdFlujoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdFlujoDoc.ControlBackColor = System.Drawing.Color.White
        Me.cboIdFlujoDoc.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdFlujoDoc.FilasVisibles = 7
        Me.cboIdFlujoDoc.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdFlujoDoc.LabelText = "Flujo"
        Me.cboIdFlujoDoc.LabelWidth = 100
        Me.cboIdFlujoDoc.Lista = ""
        Me.cboIdFlujoDoc.Location = New System.Drawing.Point(12, 107)
        Me.cboIdFlujoDoc.Name = "cboIdFlujoDoc"
        Me.cboIdFlujoDoc.NombreCampo = "IdFlujoDoc"
        Me.cboIdFlujoDoc.Obligatorio = True
        Me.cboIdFlujoDoc.Query = "select IdFlujoDoc as Flujo, Comentario as Descripcion from FlujosDocumentos"
        Me.cboIdFlujoDoc.SelectIndex = -1
        Me.cboIdFlujoDoc.Size = New System.Drawing.Size(620, 20)
        Me.cboIdFlujoDoc.SoloLectura = False
        Me.cboIdFlujoDoc.StringConection = ""
        Me.cboIdFlujoDoc.TabIndex = 4
        Me.cboIdFlujoDoc.TextoNuevoItem = ""
        Me.cboIdFlujoDoc.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdFlujoDoc.Valor = ""
        '
        'txtIdImpresion
        '
        Me.txtIdImpresion.CampoBusqueda = True
        Me.txtIdImpresion.CampoEsLlave = True
        Me.txtIdImpresion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdImpresion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdImpresion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdImpresion.FechaActual = False
        Me.txtIdImpresion.Formato = ""
        Me.txtIdImpresion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdImpresion.LabelText = "Cod. Impresión"
        Me.txtIdImpresion.LabelWidth = 100
        Me.txtIdImpresion.Location = New System.Drawing.Point(12, 81)
        Me.txtIdImpresion.MaxLength = 25
        Me.txtIdImpresion.Name = "txtIdImpresion"
        Me.txtIdImpresion.NombreCampo = "IdImpresion"
        Me.txtIdImpresion.Obligatorio = True
        Me.txtIdImpresion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdImpresion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdImpresion.SoloLectura = False
        Me.txtIdImpresion.TabIndex = 3
        Me.txtIdImpresion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdImpresion.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción "
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 133)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(620, 20)
        Me.txtDescripcion.SoloLectura = True
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtFechaImpresion
        '
        Me.txtFechaImpresion.CampoBusqueda = True
        Me.txtFechaImpresion.CampoEsLlave = False
        Me.txtFechaImpresion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaImpresion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaImpresion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaImpresion.FechaActual = False
        Me.txtFechaImpresion.Formato = "dd/MMM/yyyy hh:mm:ss"
        Me.txtFechaImpresion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaImpresion.LabelText = "Fecha Impresión"
        Me.txtFechaImpresion.LabelWidth = 100
        Me.txtFechaImpresion.Location = New System.Drawing.Point(12, 159)
        Me.txtFechaImpresion.MaxLength = 0
        Me.txtFechaImpresion.Name = "txtFechaImpresion"
        Me.txtFechaImpresion.NombreCampo = "FechaImpresion"
        Me.txtFechaImpresion.Obligatorio = False
        Me.txtFechaImpresion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaImpresion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaImpresion.SoloLectura = True
        Me.txtFechaImpresion.TabIndex = 6
        Me.txtFechaImpresion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaImpresion.Valor = Nothing
        '
        'txtUsuarioImprime
        '
        Me.txtUsuarioImprime.CampoBusqueda = False
        Me.txtUsuarioImprime.CampoEsLlave = False
        Me.txtUsuarioImprime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioImprime.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtUsuarioImprime.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioImprime.FechaActual = False
        Me.txtUsuarioImprime.Formato = ""
        Me.txtUsuarioImprime.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtUsuarioImprime.LabelText = "Usuario Imprime"
        Me.txtUsuarioImprime.LabelWidth = 100
        Me.txtUsuarioImprime.Location = New System.Drawing.Point(12, 185)
        Me.txtUsuarioImprime.MaxLength = 25
        Me.txtUsuarioImprime.Name = "txtUsuarioImprime"
        Me.txtUsuarioImprime.NombreCampo = "UsuarioImprime"
        Me.txtUsuarioImprime.Obligatorio = False
        Me.txtUsuarioImprime.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioImprime.Size = New System.Drawing.Size(300, 20)
        Me.txtUsuarioImprime.SoloLectura = True
        Me.txtUsuarioImprime.TabIndex = 8
        Me.txtUsuarioImprime.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioImprime.Valor = ""
        '
        'txtUsuarioAnula
        '
        Me.txtUsuarioAnula.CampoBusqueda = False
        Me.txtUsuarioAnula.CampoEsLlave = False
        Me.txtUsuarioAnula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsuarioAnula.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtUsuarioAnula.ControlForeColor = System.Drawing.Color.Black
        Me.txtUsuarioAnula.FechaActual = False
        Me.txtUsuarioAnula.Formato = ""
        Me.txtUsuarioAnula.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtUsuarioAnula.LabelText = "Usuario Anula"
        Me.txtUsuarioAnula.LabelWidth = 100
        Me.txtUsuarioAnula.Location = New System.Drawing.Point(332, 159)
        Me.txtUsuarioAnula.MaxLength = 25
        Me.txtUsuarioAnula.Name = "txtUsuarioAnula"
        Me.txtUsuarioAnula.NombreCampo = "UsuarioAnula"
        Me.txtUsuarioAnula.Obligatorio = False
        Me.txtUsuarioAnula.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuarioAnula.Size = New System.Drawing.Size(300, 20)
        Me.txtUsuarioAnula.SoloLectura = True
        Me.txtUsuarioAnula.TabIndex = 7
        Me.txtUsuarioAnula.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUsuarioAnula.Valor = ""
        '
        'txtFechaAnulacion
        '
        Me.txtFechaAnulacion.CampoBusqueda = True
        Me.txtFechaAnulacion.CampoEsLlave = False
        Me.txtFechaAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAnulacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAnulacion.FechaActual = False
        Me.txtFechaAnulacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAnulacion.LabelText = "Fecha Anulación"
        Me.txtFechaAnulacion.LabelWidth = 100
        Me.txtFechaAnulacion.Location = New System.Drawing.Point(12, 211)
        Me.txtFechaAnulacion.MaxLength = 0
        Me.txtFechaAnulacion.Name = "txtFechaAnulacion"
        Me.txtFechaAnulacion.NombreCampo = "FechaAnulacion"
        Me.txtFechaAnulacion.Obligatorio = True
        Me.txtFechaAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAnulacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaAnulacion.SoloLectura = False
        Me.txtFechaAnulacion.TabIndex = 0
        Me.txtFechaAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAnulacion.Valor = Nothing
        '
        'StiTextBox1
        '
        Me.StiTextBox1.CampoBusqueda = True
        Me.StiTextBox1.CampoEsLlave = False
        Me.StiTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox1.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox1.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox1.FechaActual = False
        Me.StiTextBox1.Formato = ""
        Me.StiTextBox1.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox1.LabelText = "Motivo Anulación"
        Me.StiTextBox1.LabelWidth = 100
        Me.StiTextBox1.Location = New System.Drawing.Point(12, 237)
        Me.StiTextBox1.MaxLength = 100
        Me.StiTextBox1.Name = "StiTextBox1"
        Me.StiTextBox1.NombreCampo = "MotivoAnulacion"
        Me.StiTextBox1.Obligatorio = True
        Me.StiTextBox1.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox1.Size = New System.Drawing.Size(620, 20)
        Me.StiTextBox1.SoloLectura = False
        Me.StiTextBox1.TabIndex = 1
        Me.StiTextBox1.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox1.Valor = ""
        '
        'ImpresionesCorrMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 903
        Me.ClientSize = New System.Drawing.Size(640, 332)
        Me.Controls.Add(Me.StiTextBox1)
        Me.Controls.Add(Me.txtUsuarioAnula)
        Me.Controls.Add(Me.txtFechaAnulacion)
        Me.Controls.Add(Me.txtUsuarioImprime)
        Me.Controls.Add(Me.txtFechaImpresion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cboIdFlujoDoc)
        Me.Controls.Add(Me.txtIdImpresion)
        Me.Name = "ImpresionesCorrMan"
        Me.Text = "Anulación"
        Me.Controls.SetChildIndex(Me.txtIdImpresion, 0)
        Me.Controls.SetChildIndex(Me.cboIdFlujoDoc, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaImpresion, 0)
        Me.Controls.SetChildIndex(Me.txtUsuarioImprime, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAnulacion, 0)
        Me.Controls.SetChildIndex(Me.txtUsuarioAnula, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIdFlujoDoc As STIControles.stiComboBox
    Friend WithEvents txtIdImpresion As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtFechaImpresion As STIControles.stiTextBox
    Friend WithEvents txtUsuarioImprime As STIControles.stiTextBox
    Friend WithEvents txtUsuarioAnula As STIControles.stiTextBox
    Friend WithEvents txtFechaAnulacion As STIControles.stiTextBox
    Friend WithEvents StiTextBox1 As STIControles.stiTextBox

End Class
