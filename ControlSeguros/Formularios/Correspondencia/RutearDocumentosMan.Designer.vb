<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RutearDocumentosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RutearDocumentosMan))
        Me.txtIdFlujoDoc = New STIControles.stiTextBox
        Me.txtIdImpresion = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtFechaEnvio = New STIControles.stiTextBox
        Me.cboIdZona = New STIControles.stiComboBox
        Me.txtCourier = New STIControles.stiTextBox
        Me.cboIdUsuario = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(429, 268)
        Me.btnAyuda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(307, 282)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(-29, 282)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(335, 268)
        Me.btnGuardar.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(522, 268)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(298, 282)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.TabIndex = 11
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(477, 74)
        Me.lblNombreFormulario.TabIndex = 9
        Me.lblNombreFormulario.Text = "Ruteo de Documentación"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(282, 282)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 10
        Me.btnGuardarComo.Visible = False
        '
        'txtIdFlujoDoc
        '
        Me.txtIdFlujoDoc.CampoBusqueda = False
        Me.txtIdFlujoDoc.CampoEsLlave = True
        Me.txtIdFlujoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdFlujoDoc.ControlBackColor = System.Drawing.Color.White
        Me.txtIdFlujoDoc.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdFlujoDoc.FechaActual = False
        Me.txtIdFlujoDoc.Formato = ""
        Me.txtIdFlujoDoc.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdFlujoDoc.LabelText = "Flujo"
        Me.txtIdFlujoDoc.LabelWidth = 100
        Me.txtIdFlujoDoc.Location = New System.Drawing.Point(17, 81)
        Me.txtIdFlujoDoc.MaxLength = 25
        Me.txtIdFlujoDoc.Name = "txtIdFlujoDoc"
        Me.txtIdFlujoDoc.NombreCampo = "IdFlujoDoc"
        Me.txtIdFlujoDoc.Obligatorio = True
        Me.txtIdFlujoDoc.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdFlujoDoc.Size = New System.Drawing.Size(300, 20)
        Me.txtIdFlujoDoc.SoloLectura = False
        Me.txtIdFlujoDoc.TabIndex = 6
        Me.txtIdFlujoDoc.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdFlujoDoc.Valor = ""
        '
        'txtIdImpresion
        '
        Me.txtIdImpresion.CampoBusqueda = False
        Me.txtIdImpresion.CampoEsLlave = True
        Me.txtIdImpresion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdImpresion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdImpresion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdImpresion.FechaActual = False
        Me.txtIdImpresion.Formato = ""
        Me.txtIdImpresion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdImpresion.LabelText = "Documento"
        Me.txtIdImpresion.LabelWidth = 100
        Me.txtIdImpresion.Location = New System.Drawing.Point(17, 107)
        Me.txtIdImpresion.MaxLength = 25
        Me.txtIdImpresion.Name = "txtIdImpresion"
        Me.txtIdImpresion.NombreCampo = "IdImpresion"
        Me.txtIdImpresion.Obligatorio = True
        Me.txtIdImpresion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdImpresion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdImpresion.SoloLectura = False
        Me.txtIdImpresion.TabIndex = 7
        Me.txtIdImpresion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdImpresion.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = False
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(17, 133)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(587, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 8
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtFechaEnvio
        '
        Me.txtFechaEnvio.CampoBusqueda = False
        Me.txtFechaEnvio.CampoEsLlave = False
        Me.txtFechaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvio.FechaActual = True
        Me.txtFechaEnvio.Formato = ""
        Me.txtFechaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvio.LabelText = "Fecha de Envío"
        Me.txtFechaEnvio.LabelWidth = 100
        Me.txtFechaEnvio.Location = New System.Drawing.Point(17, 159)
        Me.txtFechaEnvio.MaxLength = 0
        Me.txtFechaEnvio.Name = "txtFechaEnvio"
        Me.txtFechaEnvio.NombreCampo = "FechaEnvio"
        Me.txtFechaEnvio.Obligatorio = True
        Me.txtFechaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaEnvio.SoloLectura = False
        Me.txtFechaEnvio.TabIndex = 0
        Me.txtFechaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvio.Valor = Nothing
        '
        'cboIdZona
        '
        Me.cboIdZona.CampoAutoCompletar = 0
        Me.cboIdZona.CampoBusqueda = False
        Me.cboIdZona.CampoDisplay = 1
        Me.cboIdZona.CampoEsLlave = False
        Me.cboIdZona.CampoValor = 0
        Me.cboIdZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdZona.ControlBackColor = System.Drawing.Color.White
        Me.cboIdZona.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdZona.FilasVisibles = 29
        Me.cboIdZona.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdZona.LabelText = "Zona / Ruta"
        Me.cboIdZona.LabelWidth = 100
        Me.cboIdZona.Lista = ""
        Me.cboIdZona.Location = New System.Drawing.Point(17, 185)
        Me.cboIdZona.MostrarBusquedaColumnas = False
        Me.cboIdZona.Name = "cboIdZona"
        Me.cboIdZona.NombreCampo = "IdZona"
        Me.cboIdZona.Obligatorio = False
        Me.cboIdZona.Query = "select IdZona as Id, DescripcionZona as Descripcion from Zonas"
        Me.cboIdZona.SelectIndex = 0
        Me.cboIdZona.Size = New System.Drawing.Size(587, 20)
        Me.cboIdZona.SoloLectura = False
        Me.cboIdZona.StringConection = ""
        Me.cboIdZona.TabIndex = 1
        Me.cboIdZona.TextoNuevoItem = ""
        Me.cboIdZona.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdZona.Valor = ""
        '
        'txtCourier
        '
        Me.txtCourier.CampoBusqueda = False
        Me.txtCourier.CampoEsLlave = False
        Me.txtCourier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCourier.ControlBackColor = System.Drawing.Color.White
        Me.txtCourier.ControlForeColor = System.Drawing.Color.Black
        Me.txtCourier.FechaActual = False
        Me.txtCourier.Formato = ""
        Me.txtCourier.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCourier.LabelText = "Courrier"
        Me.txtCourier.LabelWidth = 100
        Me.txtCourier.Location = New System.Drawing.Point(17, 236)
        Me.txtCourier.MaxLength = 150
        Me.txtCourier.Name = "txtCourier"
        Me.txtCourier.NombreCampo = "Courier"
        Me.txtCourier.Obligatorio = False
        Me.txtCourier.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourier.Size = New System.Drawing.Size(587, 20)
        Me.txtCourier.SoloLectura = False
        Me.txtCourier.TabIndex = 3
        Me.txtCourier.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCourier.Valor = ""
        '
        'cboIdUsuario
        '
        Me.cboIdUsuario.CampoAutoCompletar = 0
        Me.cboIdUsuario.CampoBusqueda = False
        Me.cboIdUsuario.CampoDisplay = 1
        Me.cboIdUsuario.CampoEsLlave = False
        Me.cboIdUsuario.CampoValor = 0
        Me.cboIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdUsuario.ControlBackColor = System.Drawing.Color.White
        Me.cboIdUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdUsuario.FilasVisibles = 29
        Me.cboIdUsuario.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdUsuario.LabelText = "Usuario Entrega"
        Me.cboIdUsuario.LabelWidth = 100
        Me.cboIdUsuario.Lista = ""
        Me.cboIdUsuario.Location = New System.Drawing.Point(17, 210)
        Me.cboIdUsuario.MostrarBusquedaColumnas = False
        Me.cboIdUsuario.Name = "cboIdUsuario"
        Me.cboIdUsuario.NombreCampo = "IdUsuarioEntrega"
        Me.cboIdUsuario.Obligatorio = False
        Me.cboIdUsuario.Query = "select idusuario as Id, nombreusuario as Usuario from usuarios"
        Me.cboIdUsuario.SelectIndex = 0
        Me.cboIdUsuario.Size = New System.Drawing.Size(587, 20)
        Me.cboIdUsuario.SoloLectura = False
        Me.cboIdUsuario.StringConection = ""
        Me.cboIdUsuario.TabIndex = 2
        Me.cboIdUsuario.TextoNuevoItem = ""
        Me.cboIdUsuario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdUsuario.Valor = ""
        '
        'RutearDocumentosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 917
        Me.ClientSize = New System.Drawing.Size(616, 304)
        Me.Controls.Add(Me.cboIdUsuario)
        Me.Controls.Add(Me.txtCourier)
        Me.Controls.Add(Me.cboIdZona)
        Me.Controls.Add(Me.txtFechaEnvio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdImpresion)
        Me.Controls.Add(Me.txtIdFlujoDoc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RutearDocumentosMan"
        Me.Text = "Correspondencia"
        Me.Controls.SetChildIndex(Me.txtIdFlujoDoc, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdImpresion, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnvio, 0)
        Me.Controls.SetChildIndex(Me.cboIdZona, 0)
        Me.Controls.SetChildIndex(Me.txtCourier, 0)
        Me.Controls.SetChildIndex(Me.cboIdUsuario, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdFlujoDoc As STIControles.stiTextBox
    Friend WithEvents txtIdImpresion As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvio As STIControles.stiTextBox
    Friend WithEvents cboIdZona As STIControles.stiComboBox
    Friend WithEvents txtCourier As STIControles.stiTextBox
    Friend WithEvents cboIdUsuario As STIControles.stiComboBox

End Class
