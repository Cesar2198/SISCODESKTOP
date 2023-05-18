<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroLlamadas
    Inherits stiFomularios.stiReportes

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroLlamadas))
        Me.txtFecha = New STIControles.stiTextBox
        Me.cboUsuario = New STIControles.stiComboBox
        Me.txtHora = New DevExpress.XtraEditors.TimeEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cboLlamadaPara = New STIControles.stiComboBox
        Me.txtPersonaLlama = New STIControles.stiTextBox
        Me.txtLugar = New STIControles.stiTextBox
        Me.txtTelefono = New STIControles.stiTextBox
        Me.txtEmail = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtObservaciones = New STIControles.stiMemo
        Me.optSi = New System.Windows.Forms.RadioButton
        Me.optNo = New System.Windows.Forms.RadioButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(415, 355)
        Me.btnAyuda.TabIndex = 11
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(174, 355)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "&Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(518, 355)
        Me.btnSalir.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(484, 74)
        Me.LabelControl1.Text = "Registro de Llamadas Teléfonicas"
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = False
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = False
        Me.txtFecha.Formato = ""
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(8, 80)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(300, 20)
        Me.txtFecha.SoloLectura = True
        Me.txtFecha.TabIndex = 15
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtFecha.Valor = ""
        '
        'cboUsuario
        '
        Me.cboUsuario.CampoAutoCompletar = 0
        Me.cboUsuario.CampoBusqueda = False
        Me.cboUsuario.CampoDisplay = 1
        Me.cboUsuario.CampoEsLlave = False
        Me.cboUsuario.CampoValor = 0
        Me.cboUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUsuario.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.cboUsuario.FilasVisibles = 0
        Me.cboUsuario.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboUsuario.LabelText = "Usuario"
        Me.cboUsuario.LabelWidth = 100
        Me.cboUsuario.Lista = ""
        Me.cboUsuario.Location = New System.Drawing.Point(314, 80)
        Me.cboUsuario.MostrarBusquedaColumnas = False
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.NombreCampo = ""
        Me.cboUsuario.Obligatorio = True
        Me.cboUsuario.Query = "select idusuario as id, NombreUsuario as Usuario from Usuarios where estado is nu" & _
            "ll or estado = 'A'"
        Me.cboUsuario.SelectIndex = 0
        Me.cboUsuario.Size = New System.Drawing.Size(300, 20)
        Me.cboUsuario.SoloLectura = True
        Me.cboUsuario.StringConection = ""
        Me.cboUsuario.TabIndex = 16
        Me.cboUsuario.TextoNuevoItem = ""
        Me.cboUsuario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboUsuario.Valor = ""
        '
        'txtHora
        '
        Me.txtHora.EditValue = New Date(2016, 4, 3, 0, 0, 0, 0)
        Me.txtHora.EnterMoveNextControl = True
        Me.txtHora.Location = New System.Drawing.Point(137, 106)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtHora.Size = New System.Drawing.Size(170, 20)
        Me.txtHora.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(8, 109)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Hora de la Llamada"
        '
        'cboLlamadaPara
        '
        Me.cboLlamadaPara.CampoAutoCompletar = 0
        Me.cboLlamadaPara.CampoBusqueda = False
        Me.cboLlamadaPara.CampoDisplay = 1
        Me.cboLlamadaPara.CampoEsLlave = False
        Me.cboLlamadaPara.CampoValor = 0
        Me.cboLlamadaPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboLlamadaPara.ControlBackColor = System.Drawing.Color.White
        Me.cboLlamadaPara.ControlForeColor = System.Drawing.Color.Black
        Me.cboLlamadaPara.FilasVisibles = 0
        Me.cboLlamadaPara.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboLlamadaPara.LabelText = "Llamada para"
        Me.cboLlamadaPara.LabelWidth = 100
        Me.cboLlamadaPara.Lista = ""
        Me.cboLlamadaPara.Location = New System.Drawing.Point(314, 106)
        Me.cboLlamadaPara.MostrarBusquedaColumnas = False
        Me.cboLlamadaPara.Name = "cboLlamadaPara"
        Me.cboLlamadaPara.NombreCampo = ""
        Me.cboLlamadaPara.Obligatorio = True
        Me.cboLlamadaPara.Query = "select idusuario as id, NombreUsuario as Usuario from Usuarios where estado is nu" & _
            "ll or estado = 'A'"
        Me.cboLlamadaPara.SelectIndex = 0
        Me.cboLlamadaPara.Size = New System.Drawing.Size(300, 20)
        Me.cboLlamadaPara.SoloLectura = False
        Me.cboLlamadaPara.StringConection = ""
        Me.cboLlamadaPara.TabIndex = 1
        Me.cboLlamadaPara.TextoNuevoItem = ""
        Me.cboLlamadaPara.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboLlamadaPara.Valor = ""
        '
        'txtPersonaLlama
        '
        Me.txtPersonaLlama.CampoBusqueda = False
        Me.txtPersonaLlama.CampoEsLlave = False
        Me.txtPersonaLlama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPersonaLlama.ControlBackColor = System.Drawing.Color.White
        Me.txtPersonaLlama.ControlForeColor = System.Drawing.Color.Black
        Me.txtPersonaLlama.FechaActual = False
        Me.txtPersonaLlama.Formato = ""
        Me.txtPersonaLlama.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPersonaLlama.LabelText = "Persona que Llama"
        Me.txtPersonaLlama.LabelWidth = 130
        Me.txtPersonaLlama.Location = New System.Drawing.Point(8, 132)
        Me.txtPersonaLlama.MaxLength = 500
        Me.txtPersonaLlama.Name = "txtPersonaLlama"
        Me.txtPersonaLlama.NombreCampo = ""
        Me.txtPersonaLlama.Obligatorio = True
        Me.txtPersonaLlama.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPersonaLlama.Size = New System.Drawing.Size(606, 20)
        Me.txtPersonaLlama.SoloLectura = False
        Me.txtPersonaLlama.TabIndex = 2
        Me.txtPersonaLlama.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPersonaLlama.Valor = ""
        '
        'txtLugar
        '
        Me.txtLugar.CampoBusqueda = False
        Me.txtLugar.CampoEsLlave = False
        Me.txtLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLugar.ControlBackColor = System.Drawing.Color.White
        Me.txtLugar.ControlForeColor = System.Drawing.Color.Black
        Me.txtLugar.FechaActual = False
        Me.txtLugar.Formato = ""
        Me.txtLugar.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLugar.LabelText = "Lugar de Donde Llama"
        Me.txtLugar.LabelWidth = 130
        Me.txtLugar.Location = New System.Drawing.Point(8, 158)
        Me.txtLugar.MaxLength = 500
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.NombreCampo = ""
        Me.txtLugar.Obligatorio = True
        Me.txtLugar.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLugar.Size = New System.Drawing.Size(606, 20)
        Me.txtLugar.SoloLectura = False
        Me.txtLugar.TabIndex = 3
        Me.txtLugar.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtLugar.Valor = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.CampoBusqueda = False
        Me.txtTelefono.CampoEsLlave = False
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTelefono.ControlBackColor = System.Drawing.Color.White
        Me.txtTelefono.ControlForeColor = System.Drawing.Color.Black
        Me.txtTelefono.FechaActual = False
        Me.txtTelefono.Formato = ""
        Me.txtTelefono.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTelefono.LabelText = "No. de Teléfono"
        Me.txtTelefono.LabelWidth = 100
        Me.txtTelefono.Location = New System.Drawing.Point(8, 184)
        Me.txtTelefono.MaxLength = 25
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NombreCampo = ""
        Me.txtTelefono.Obligatorio = True
        Me.txtTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(300, 20)
        Me.txtTelefono.SoloLectura = False
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTelefono.Valor = ""
        '
        'txtEmail
        '
        Me.txtEmail.CampoBusqueda = False
        Me.txtEmail.CampoEsLlave = False
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEmail.ControlBackColor = System.Drawing.Color.White
        Me.txtEmail.ControlForeColor = System.Drawing.Color.Black
        Me.txtEmail.FechaActual = False
        Me.txtEmail.Formato = ""
        Me.txtEmail.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEmail.LabelText = "EMail"
        Me.txtEmail.LabelWidth = 100
        Me.txtEmail.Location = New System.Drawing.Point(314, 184)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NombreCampo = ""
        Me.txtEmail.Obligatorio = True
        Me.txtEmail.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.Size = New System.Drawing.Size(300, 20)
        Me.txtEmail.SoloLectura = False
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEmail.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(314, 210)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 6
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = True
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(7, 212)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 29
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(8, 238)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(606, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 31
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.txtObservaciones.LabelWidth = 100
        Me.txtObservaciones.Location = New System.Drawing.Point(7, 264)
        Me.txtObservaciones.MaxLength = 0
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = ""
        Me.txtObservaciones.Obligatorio = True
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(607, 57)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 7
        Me.txtObservaciones.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'optSi
        '
        Me.optSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optSi.AutoSize = True
        Me.optSi.Checked = True
        Me.optSi.Location = New System.Drawing.Point(109, 328)
        Me.optSi.Name = "optSi"
        Me.optSi.Size = New System.Drawing.Size(35, 17)
        Me.optSi.TabIndex = 13
        Me.optSi.TabStop = True
        Me.optSi.Text = "SI"
        Me.optSi.UseVisualStyleBackColor = True
        '
        'optNo
        '
        Me.optNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optNo.AutoSize = True
        Me.optNo.Location = New System.Drawing.Point(251, 328)
        Me.optNo.Name = "optNo"
        Me.optNo.Size = New System.Drawing.Size(40, 17)
        Me.optNo.TabIndex = 14
        Me.optNo.Text = "NO"
        Me.optNo.UseVisualStyleBackColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(7, 330)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Se pasó Llamada"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(280, 355)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(132, 36)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "&Enviar Recado"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(75, 355)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(93, 36)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        '
        'RegistroLlamadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 393)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.optNo)
        Me.Controls.Add(Me.optSi)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtPersonaLlama)
        Me.Controls.Add(Me.cboLlamadaPara)
        Me.Name = "RegistroLlamadas"
        Me.Text = "Llamadas Teléfonicas"
        Me.Controls.SetChildIndex(Me.cboLlamadaPara, 0)
        Me.Controls.SetChildIndex(Me.txtPersonaLlama, 0)
        Me.Controls.SetChildIndex(Me.txtLugar, 0)
        Me.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtHora, 0)
        Me.Controls.SetChildIndex(Me.cboUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.optSi, 0)
        Me.Controls.SetChildIndex(Me.optNo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents cboUsuario As STIControles.stiComboBox
    Friend WithEvents txtHora As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLlamadaPara As STIControles.stiComboBox
    Friend WithEvents txtPersonaLlama As STIControles.stiTextBox
    Friend WithEvents txtLugar As STIControles.stiTextBox
    Friend WithEvents txtTelefono As STIControles.stiTextBox
    Friend WithEvents txtEmail As STIControles.stiTextBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtObservaciones As STIControles.stiMemo
    Friend WithEvents optSi As System.Windows.Forms.RadioButton
    Friend WithEvents optNo As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton

End Class
