<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbicacionesMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UbicacionesMan))
        Me.cboIdCiudad = New STIControles.stiComboBox
        Me.txtIdUbicacion = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.StiTextBox1 = New STIControles.stiTextBox
        Me.cboIdZona = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 280)
        Me.btnAyuda.TabIndex = 12
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(292, 280)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 280)
        Me.btnNuevo.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(107, 280)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 280)
        Me.btnSalir.TabIndex = 13
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 280)
        Me.btnEliminar.TabIndex = 11
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
        Me.lblNombreFormulario.TabIndex = 15
        Me.lblNombreFormulario.Text = "Ubicacones de Entrega de Correspondencia"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 280)
        Me.btnGuardarComo.TabIndex = 9
        '
        'cboIdCiudad
        '
        Me.cboIdCiudad.CampoAutoCompletar = 1
        Me.cboIdCiudad.CampoBusqueda = False
        Me.cboIdCiudad.CampoDisplay = 1
        Me.cboIdCiudad.CampoEsLlave = False
        Me.cboIdCiudad.CampoValor = 0
        Me.cboIdCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdCiudad.ControlBackColor = System.Drawing.Color.White
        Me.cboIdCiudad.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdCiudad.FilasVisibles = 7
        Me.cboIdCiudad.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdCiudad.LabelText = "Ciudad"
        Me.cboIdCiudad.LabelWidth = 100
        Me.cboIdCiudad.Lista = ""
        Me.cboIdCiudad.Location = New System.Drawing.Point(37, 220)
        Me.cboIdCiudad.Name = "cboIdCiudad"
        Me.cboIdCiudad.NombreCampo = "IdCiudad"
        Me.cboIdCiudad.Obligatorio = True
        Me.cboIdCiudad.Query = resources.GetString("cboIdCiudad.Query")
        Me.cboIdCiudad.SelectIndex = -1
        Me.cboIdCiudad.Size = New System.Drawing.Size(613, 20)
        Me.cboIdCiudad.SoloLectura = False
        Me.cboIdCiudad.StringConection = ""
        Me.cboIdCiudad.TabIndex = 5
        Me.cboIdCiudad.TextoNuevoItem = ""
        Me.cboIdCiudad.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdCiudad.Valor = ""
        '
        'txtIdUbicacion
        '
        Me.txtIdUbicacion.CampoBusqueda = True
        Me.txtIdUbicacion.CampoEsLlave = True
        Me.txtIdUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdUbicacion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdUbicacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdUbicacion.FechaActual = False
        Me.txtIdUbicacion.Formato = ""
        Me.txtIdUbicacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdUbicacion.LabelText = "Cod. Ubicación"
        Me.txtIdUbicacion.LabelWidth = 100
        Me.txtIdUbicacion.Location = New System.Drawing.Point(37, 90)
        Me.txtIdUbicacion.MaxLength = 25
        Me.txtIdUbicacion.Name = "txtIdUbicacion"
        Me.txtIdUbicacion.NombreCampo = "IdUbicacion"
        Me.txtIdUbicacion.Obligatorio = True
        Me.txtIdUbicacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdUbicacion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdUbicacion.SoloLectura = False
        Me.txtIdUbicacion.TabIndex = 0
        Me.txtIdUbicacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdUbicacion.Valor = ""
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
        Me.txtDescripcion.Location = New System.Drawing.Point(37, 116)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(613, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(37, 142)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 2
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = False
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(37, 168)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(613, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 3
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(348, 139)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarCliente.TabIndex = 14
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'StiTextBox1
        '
        Me.StiTextBox1.CampoBusqueda = False
        Me.StiTextBox1.CampoEsLlave = False
        Me.StiTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox1.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox1.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox1.FechaActual = False
        Me.StiTextBox1.Formato = ""
        Me.StiTextBox1.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox1.LabelText = "Dirección"
        Me.StiTextBox1.LabelWidth = 100
        Me.StiTextBox1.Location = New System.Drawing.Point(37, 194)
        Me.StiTextBox1.MaxLength = 250
        Me.StiTextBox1.Name = "StiTextBox1"
        Me.StiTextBox1.NombreCampo = "Direccion"
        Me.StiTextBox1.Obligatorio = True
        Me.StiTextBox1.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox1.Size = New System.Drawing.Size(613, 20)
        Me.StiTextBox1.SoloLectura = False
        Me.StiTextBox1.TabIndex = 4
        Me.StiTextBox1.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox1.Valor = ""
        '
        'cboIdZona
        '
        Me.cboIdZona.CampoAutoCompletar = 1
        Me.cboIdZona.CampoBusqueda = False
        Me.cboIdZona.CampoDisplay = 1
        Me.cboIdZona.CampoEsLlave = False
        Me.cboIdZona.CampoValor = 0
        Me.cboIdZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdZona.ControlBackColor = System.Drawing.Color.White
        Me.cboIdZona.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdZona.FilasVisibles = 7
        Me.cboIdZona.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdZona.LabelText = "Zona"
        Me.cboIdZona.LabelWidth = 100
        Me.cboIdZona.Lista = ""
        Me.cboIdZona.Location = New System.Drawing.Point(37, 246)
        Me.cboIdZona.Name = "cboIdZona"
        Me.cboIdZona.NombreCampo = "IdZona"
        Me.cboIdZona.Obligatorio = False
        Me.cboIdZona.Query = "select IdZona as ID, DescripcionZona as ZONA from zonas"
        Me.cboIdZona.SelectIndex = -1
        Me.cboIdZona.Size = New System.Drawing.Size(613, 20)
        Me.cboIdZona.SoloLectura = False
        Me.cboIdZona.StringConection = ""
        Me.cboIdZona.TabIndex = 6
        Me.cboIdZona.TextoNuevoItem = ""
        Me.cboIdZona.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdZona.Valor = ""
        '
        'UbicacionesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 117
        Me.ClientSize = New System.Drawing.Size(662, 316)
        Me.Controls.Add(Me.cboIdZona)
        Me.Controls.Add(Me.StiTextBox1)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdUbicacion)
        Me.Controls.Add(Me.cboIdCiudad)
        Me.Name = "UbicacionesMan"
        Me.Text = "Ubicaciones de Correspondencia"
        Me.Controls.SetChildIndex(Me.cboIdCiudad, 0)
        Me.Controls.SetChildIndex(Me.txtIdUbicacion, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox1, 0)
        Me.Controls.SetChildIndex(Me.cboIdZona, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIdCiudad As STIControles.stiComboBox
    Friend WithEvents txtIdUbicacion As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StiTextBox1 As STIControles.stiTextBox
    Friend WithEvents cboIdZona As STIControles.stiComboBox

End Class
