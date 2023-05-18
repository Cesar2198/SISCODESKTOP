<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificacionesMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotificacionesMan))
        Me.txtIdNotificacion = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtCorreoDestinatarios = New STIControles.stiMemo
        Me.cboEstado = New STIControles.stiComboBox
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cboNotificarDomingo = New STIControles.stiComboBox
        Me.txtFrecuenciaNotificacion = New STIControles.stiTextBox
        Me.cboNotificarSabado = New STIControles.stiComboBox
        Me.cboNotificarLunes = New STIControles.stiComboBox
        Me.cboNotificarViernes = New STIControles.stiComboBox
        Me.cboNotificarMartes = New STIControles.stiComboBox
        Me.cboNotificarJueves = New STIControles.stiComboBox
        Me.cboNotificarMiercoles = New STIControles.stiComboBox
        Me.txtFormulaNotificacion = New STIControles.stiMemo
        Me.txtMaxCorreos = New STIControles.stiTextBox
        Me.StiTextBox2 = New STIControles.stiTextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(480, 469)
        Me.btnAyuda.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(296, 469)
        Me.btnBuscar.TabIndex = 11
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(19, 469)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(111, 469)
        Me.btnGuardar.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(572, 469)
        Me.btnSalir.TabIndex = 14
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(388, 469)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(527, 74)
        Me.lblNombreFormulario.Text = "Notificaciones Automáticas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(204, 469)
        Me.btnGuardarComo.TabIndex = 10
        '
        'txtIdNotificacion
        '
        Me.txtIdNotificacion.CampoBusqueda = False
        Me.txtIdNotificacion.CampoEsLlave = True
        Me.txtIdNotificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdNotificacion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdNotificacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdNotificacion.FechaActual = False
        Me.txtIdNotificacion.Formato = ""
        Me.txtIdNotificacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdNotificacion.LabelText = "Cod. Notificación"
        Me.txtIdNotificacion.LabelWidth = 100
        Me.txtIdNotificacion.Location = New System.Drawing.Point(12, 81)
        Me.txtIdNotificacion.MaxLength = 25
        Me.txtIdNotificacion.Name = "txtIdNotificacion"
        Me.txtIdNotificacion.NombreCampo = "IdNotificacion"
        Me.txtIdNotificacion.Obligatorio = True
        Me.txtIdNotificacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdNotificacion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdNotificacion.SoloLectura = False
        Me.txtIdNotificacion.TabIndex = 0
        Me.txtIdNotificacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdNotificacion.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 104)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(642, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtCorreoDestinatarios
        '
        Me.txtCorreoDestinatarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoDestinatarios.CampoBusqueda = False
        Me.txtCorreoDestinatarios.CampoEsLlave = False
        Me.txtCorreoDestinatarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCorreoDestinatarios.ControlBackColor = System.Drawing.Color.White
        Me.txtCorreoDestinatarios.ControlForeColor = System.Drawing.Color.Black
        Me.txtCorreoDestinatarios.FechaActual = False
        Me.txtCorreoDestinatarios.Formato = ""
        Me.txtCorreoDestinatarios.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtCorreoDestinatarios.LabelText = "Correos Destino"
        Me.txtCorreoDestinatarios.LabelWidth = 100
        Me.txtCorreoDestinatarios.Location = New System.Drawing.Point(12, 127)
        Me.txtCorreoDestinatarios.MaxLength = 0
        Me.txtCorreoDestinatarios.Name = "txtCorreoDestinatarios"
        Me.txtCorreoDestinatarios.NombreCampo = "CorreoDestinatarios"
        Me.txtCorreoDestinatarios.Obligatorio = False
        Me.txtCorreoDestinatarios.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreoDestinatarios.Size = New System.Drawing.Size(642, 42)
        Me.txtCorreoDestinatarios.SoloLectura = False
        Me.txtCorreoDestinatarios.TabIndex = 3
        Me.txtCorreoDestinatarios.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtCorreoDestinatarios.Valor = ""
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEstado.CampoAutoCompletar = 0
        Me.cboEstado.CampoBusqueda = False
        Me.cboEstado.CampoDisplay = 1
        Me.cboEstado.CampoEsLlave = False
        Me.cboEstado.CampoValor = 0
        Me.cboEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstado.ControlBackColor = System.Drawing.Color.White
        Me.cboEstado.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstado.FilasVisibles = 18
        Me.cboEstado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstado.LabelText = "Estado"
        Me.cboEstado.LabelWidth = 100
        Me.cboEstado.Lista = "A Notificación Activa|S Notificación Suspendida"
        Me.cboEstado.Location = New System.Drawing.Point(350, 81)
        Me.cboEstado.MostrarBusquedaColumnas = False
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.NombreCampo = "Estado"
        Me.cboEstado.Obligatorio = True
        Me.cboEstado.Query = ""
        Me.cboEstado.SelectIndex = 0
        Me.cboEstado.Size = New System.Drawing.Size(304, 20)
        Me.cboEstado.SoloLectura = False
        Me.cboEstado.StringConection = ""
        Me.cboEstado.TabIndex = 1
        Me.cboEstado.TextoNuevoItem = ""
        Me.cboEstado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstado.Valor = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.cboNotificarDomingo)
        Me.GroupControl1.Controls.Add(Me.txtFrecuenciaNotificacion)
        Me.GroupControl1.Controls.Add(Me.cboNotificarSabado)
        Me.GroupControl1.Controls.Add(Me.cboNotificarLunes)
        Me.GroupControl1.Controls.Add(Me.cboNotificarViernes)
        Me.GroupControl1.Controls.Add(Me.cboNotificarMartes)
        Me.GroupControl1.Controls.Add(Me.cboNotificarJueves)
        Me.GroupControl1.Controls.Add(Me.cboNotificarMiercoles)
        Me.GroupControl1.Location = New System.Drawing.Point(112, 173)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(542, 94)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "PROGRAMACIÓN"
        '
        'cboNotificarDomingo
        '
        Me.cboNotificarDomingo.CampoAutoCompletar = 0
        Me.cboNotificarDomingo.CampoBusqueda = False
        Me.cboNotificarDomingo.CampoDisplay = 1
        Me.cboNotificarDomingo.CampoEsLlave = False
        Me.cboNotificarDomingo.CampoValor = 0
        Me.cboNotificarDomingo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarDomingo.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarDomingo.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarDomingo.FilasVisibles = 18
        Me.cboNotificarDomingo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarDomingo.LabelText = "Domingo"
        Me.cboNotificarDomingo.LabelWidth = 100
        Me.cboNotificarDomingo.Lista = "S Si|N NO"
        Me.cboNotificarDomingo.Location = New System.Drawing.Point(461, 46)
        Me.cboNotificarDomingo.MostrarBusquedaColumnas = False
        Me.cboNotificarDomingo.Name = "cboNotificarDomingo"
        Me.cboNotificarDomingo.NombreCampo = "NotificarDomingo"
        Me.cboNotificarDomingo.Obligatorio = False
        Me.cboNotificarDomingo.Query = ""
        Me.cboNotificarDomingo.SelectIndex = 0
        Me.cboNotificarDomingo.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarDomingo.SoloLectura = False
        Me.cboNotificarDomingo.StringConection = ""
        Me.cboNotificarDomingo.TabIndex = 7
        Me.cboNotificarDomingo.TextoNuevoItem = ""
        Me.cboNotificarDomingo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarDomingo.Valor = ""
        '
        'txtFrecuenciaNotificacion
        '
        Me.txtFrecuenciaNotificacion.CampoBusqueda = False
        Me.txtFrecuenciaNotificacion.CampoEsLlave = False
        Me.txtFrecuenciaNotificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFrecuenciaNotificacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFrecuenciaNotificacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFrecuenciaNotificacion.FechaActual = False
        Me.txtFrecuenciaNotificacion.Formato = "###0"
        Me.txtFrecuenciaNotificacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFrecuenciaNotificacion.LabelText = "Frecuencia (Días)"
        Me.txtFrecuenciaNotificacion.LabelWidth = 100
        Me.txtFrecuenciaNotificacion.Location = New System.Drawing.Point(5, 23)
        Me.txtFrecuenciaNotificacion.MaxLength = 0
        Me.txtFrecuenciaNotificacion.Name = "txtFrecuenciaNotificacion"
        Me.txtFrecuenciaNotificacion.NombreCampo = "FrecuenciaNotificacion"
        Me.txtFrecuenciaNotificacion.Obligatorio = True
        Me.txtFrecuenciaNotificacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFrecuenciaNotificacion.Size = New System.Drawing.Size(176, 20)
        Me.txtFrecuenciaNotificacion.SoloLectura = False
        Me.txtFrecuenciaNotificacion.TabIndex = 0
        Me.txtFrecuenciaNotificacion.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtFrecuenciaNotificacion.Valor = 0
        '
        'cboNotificarSabado
        '
        Me.cboNotificarSabado.CampoAutoCompletar = 0
        Me.cboNotificarSabado.CampoBusqueda = False
        Me.cboNotificarSabado.CampoDisplay = 1
        Me.cboNotificarSabado.CampoEsLlave = False
        Me.cboNotificarSabado.CampoValor = 0
        Me.cboNotificarSabado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarSabado.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarSabado.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarSabado.FilasVisibles = 18
        Me.cboNotificarSabado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarSabado.LabelText = "Sábado"
        Me.cboNotificarSabado.LabelWidth = 100
        Me.cboNotificarSabado.Lista = "S Si|N NO"
        Me.cboNotificarSabado.Location = New System.Drawing.Point(385, 45)
        Me.cboNotificarSabado.MostrarBusquedaColumnas = False
        Me.cboNotificarSabado.Name = "cboNotificarSabado"
        Me.cboNotificarSabado.NombreCampo = "NotificarSabado"
        Me.cboNotificarSabado.Obligatorio = False
        Me.cboNotificarSabado.Query = ""
        Me.cboNotificarSabado.SelectIndex = 0
        Me.cboNotificarSabado.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarSabado.SoloLectura = False
        Me.cboNotificarSabado.StringConection = ""
        Me.cboNotificarSabado.TabIndex = 6
        Me.cboNotificarSabado.TextoNuevoItem = ""
        Me.cboNotificarSabado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarSabado.Valor = ""
        '
        'cboNotificarLunes
        '
        Me.cboNotificarLunes.CampoAutoCompletar = 0
        Me.cboNotificarLunes.CampoBusqueda = False
        Me.cboNotificarLunes.CampoDisplay = 1
        Me.cboNotificarLunes.CampoEsLlave = False
        Me.cboNotificarLunes.CampoValor = 0
        Me.cboNotificarLunes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarLunes.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarLunes.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarLunes.FilasVisibles = 18
        Me.cboNotificarLunes.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarLunes.LabelText = "Lunes"
        Me.cboNotificarLunes.LabelWidth = 100
        Me.cboNotificarLunes.Lista = "S Si|N NO"
        Me.cboNotificarLunes.Location = New System.Drawing.Point(5, 47)
        Me.cboNotificarLunes.MostrarBusquedaColumnas = False
        Me.cboNotificarLunes.Name = "cboNotificarLunes"
        Me.cboNotificarLunes.NombreCampo = "NotificarLunes"
        Me.cboNotificarLunes.Obligatorio = False
        Me.cboNotificarLunes.Query = ""
        Me.cboNotificarLunes.SelectIndex = 0
        Me.cboNotificarLunes.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarLunes.SoloLectura = False
        Me.cboNotificarLunes.StringConection = ""
        Me.cboNotificarLunes.TabIndex = 1
        Me.cboNotificarLunes.TextoNuevoItem = ""
        Me.cboNotificarLunes.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarLunes.Valor = ""
        '
        'cboNotificarViernes
        '
        Me.cboNotificarViernes.CampoAutoCompletar = 0
        Me.cboNotificarViernes.CampoBusqueda = False
        Me.cboNotificarViernes.CampoDisplay = 1
        Me.cboNotificarViernes.CampoEsLlave = False
        Me.cboNotificarViernes.CampoValor = 0
        Me.cboNotificarViernes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarViernes.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarViernes.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarViernes.FilasVisibles = 18
        Me.cboNotificarViernes.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarViernes.LabelText = "Viernes"
        Me.cboNotificarViernes.LabelWidth = 100
        Me.cboNotificarViernes.Lista = "S Si|N NO"
        Me.cboNotificarViernes.Location = New System.Drawing.Point(309, 45)
        Me.cboNotificarViernes.MostrarBusquedaColumnas = False
        Me.cboNotificarViernes.Name = "cboNotificarViernes"
        Me.cboNotificarViernes.NombreCampo = "NotificarViernes"
        Me.cboNotificarViernes.Obligatorio = False
        Me.cboNotificarViernes.Query = ""
        Me.cboNotificarViernes.SelectIndex = 0
        Me.cboNotificarViernes.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarViernes.SoloLectura = False
        Me.cboNotificarViernes.StringConection = ""
        Me.cboNotificarViernes.TabIndex = 5
        Me.cboNotificarViernes.TextoNuevoItem = ""
        Me.cboNotificarViernes.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarViernes.Valor = ""
        '
        'cboNotificarMartes
        '
        Me.cboNotificarMartes.CampoAutoCompletar = 0
        Me.cboNotificarMartes.CampoBusqueda = False
        Me.cboNotificarMartes.CampoDisplay = 1
        Me.cboNotificarMartes.CampoEsLlave = False
        Me.cboNotificarMartes.CampoValor = 0
        Me.cboNotificarMartes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarMartes.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarMartes.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarMartes.FilasVisibles = 18
        Me.cboNotificarMartes.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarMartes.LabelText = "Martes"
        Me.cboNotificarMartes.LabelWidth = 100
        Me.cboNotificarMartes.Lista = "S Si|N NO"
        Me.cboNotificarMartes.Location = New System.Drawing.Point(81, 46)
        Me.cboNotificarMartes.MostrarBusquedaColumnas = False
        Me.cboNotificarMartes.Name = "cboNotificarMartes"
        Me.cboNotificarMartes.NombreCampo = "NotificarMartes"
        Me.cboNotificarMartes.Obligatorio = False
        Me.cboNotificarMartes.Query = ""
        Me.cboNotificarMartes.SelectIndex = 0
        Me.cboNotificarMartes.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarMartes.SoloLectura = False
        Me.cboNotificarMartes.StringConection = ""
        Me.cboNotificarMartes.TabIndex = 2
        Me.cboNotificarMartes.TextoNuevoItem = ""
        Me.cboNotificarMartes.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarMartes.Valor = ""
        '
        'cboNotificarJueves
        '
        Me.cboNotificarJueves.CampoAutoCompletar = 0
        Me.cboNotificarJueves.CampoBusqueda = False
        Me.cboNotificarJueves.CampoDisplay = 1
        Me.cboNotificarJueves.CampoEsLlave = False
        Me.cboNotificarJueves.CampoValor = 0
        Me.cboNotificarJueves.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarJueves.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarJueves.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarJueves.FilasVisibles = 18
        Me.cboNotificarJueves.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarJueves.LabelText = "Jueves"
        Me.cboNotificarJueves.LabelWidth = 100
        Me.cboNotificarJueves.Lista = "S Si|N NO"
        Me.cboNotificarJueves.Location = New System.Drawing.Point(233, 45)
        Me.cboNotificarJueves.MostrarBusquedaColumnas = False
        Me.cboNotificarJueves.Name = "cboNotificarJueves"
        Me.cboNotificarJueves.NombreCampo = "NotificarJueves"
        Me.cboNotificarJueves.Obligatorio = False
        Me.cboNotificarJueves.Query = ""
        Me.cboNotificarJueves.SelectIndex = 0
        Me.cboNotificarJueves.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarJueves.SoloLectura = False
        Me.cboNotificarJueves.StringConection = ""
        Me.cboNotificarJueves.TabIndex = 4
        Me.cboNotificarJueves.TextoNuevoItem = ""
        Me.cboNotificarJueves.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarJueves.Valor = ""
        '
        'cboNotificarMiercoles
        '
        Me.cboNotificarMiercoles.CampoAutoCompletar = 0
        Me.cboNotificarMiercoles.CampoBusqueda = False
        Me.cboNotificarMiercoles.CampoDisplay = 1
        Me.cboNotificarMiercoles.CampoEsLlave = False
        Me.cboNotificarMiercoles.CampoValor = 0
        Me.cboNotificarMiercoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNotificarMiercoles.ControlBackColor = System.Drawing.Color.White
        Me.cboNotificarMiercoles.ControlForeColor = System.Drawing.Color.Black
        Me.cboNotificarMiercoles.FilasVisibles = 18
        Me.cboNotificarMiercoles.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboNotificarMiercoles.LabelText = "Miércoles"
        Me.cboNotificarMiercoles.LabelWidth = 100
        Me.cboNotificarMiercoles.Lista = "S Si|N NO"
        Me.cboNotificarMiercoles.Location = New System.Drawing.Point(157, 45)
        Me.cboNotificarMiercoles.MostrarBusquedaColumnas = False
        Me.cboNotificarMiercoles.Name = "cboNotificarMiercoles"
        Me.cboNotificarMiercoles.NombreCampo = "NotificarMiercoles"
        Me.cboNotificarMiercoles.Obligatorio = False
        Me.cboNotificarMiercoles.Query = ""
        Me.cboNotificarMiercoles.SelectIndex = 0
        Me.cboNotificarMiercoles.Size = New System.Drawing.Size(65, 38)
        Me.cboNotificarMiercoles.SoloLectura = False
        Me.cboNotificarMiercoles.StringConection = ""
        Me.cboNotificarMiercoles.TabIndex = 3
        Me.cboNotificarMiercoles.TextoNuevoItem = ""
        Me.cboNotificarMiercoles.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNotificarMiercoles.Valor = ""
        '
        'txtFormulaNotificacion
        '
        Me.txtFormulaNotificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormulaNotificacion.CampoBusqueda = False
        Me.txtFormulaNotificacion.CampoEsLlave = False
        Me.txtFormulaNotificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFormulaNotificacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFormulaNotificacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFormulaNotificacion.FechaActual = False
        Me.txtFormulaNotificacion.Formato = ""
        Me.txtFormulaNotificacion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtFormulaNotificacion.LabelText = "Formula de Notificación"
        Me.txtFormulaNotificacion.LabelWidth = 100
        Me.txtFormulaNotificacion.Location = New System.Drawing.Point(12, 296)
        Me.txtFormulaNotificacion.MaxLength = 0
        Me.txtFormulaNotificacion.Name = "txtFormulaNotificacion"
        Me.txtFormulaNotificacion.NombreCampo = "FormulaNotificacion"
        Me.txtFormulaNotificacion.Obligatorio = True
        Me.txtFormulaNotificacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFormulaNotificacion.Size = New System.Drawing.Size(642, 167)
        Me.txtFormulaNotificacion.SoloLectura = False
        Me.txtFormulaNotificacion.TabIndex = 7
        Me.txtFormulaNotificacion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtFormulaNotificacion.Valor = ""
        '
        'txtMaxCorreos
        '
        Me.txtMaxCorreos.CampoBusqueda = False
        Me.txtMaxCorreos.CampoEsLlave = False
        Me.txtMaxCorreos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMaxCorreos.ControlBackColor = System.Drawing.Color.White
        Me.txtMaxCorreos.ControlForeColor = System.Drawing.Color.Black
        Me.txtMaxCorreos.FechaActual = False
        Me.txtMaxCorreos.Formato = "###"
        Me.txtMaxCorreos.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMaxCorreos.LabelText = "# Max Correos"
        Me.txtMaxCorreos.LabelWidth = 100
        Me.txtMaxCorreos.Location = New System.Drawing.Point(112, 270)
        Me.txtMaxCorreos.MaxLength = 0
        Me.txtMaxCorreos.Name = "txtMaxCorreos"
        Me.txtMaxCorreos.NombreCampo = "MaxCorreos"
        Me.txtMaxCorreos.Obligatorio = False
        Me.txtMaxCorreos.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaxCorreos.Size = New System.Drawing.Size(176, 20)
        Me.txtMaxCorreos.SoloLectura = False
        Me.txtMaxCorreos.TabIndex = 5
        Me.txtMaxCorreos.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtMaxCorreos.Valor = 0
        '
        'StiTextBox2
        '
        Me.StiTextBox2.CampoBusqueda = False
        Me.StiTextBox2.CampoEsLlave = False
        Me.StiTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox2.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox2.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox2.FechaActual = False
        Me.StiTextBox2.Formato = "###"
        Me.StiTextBox2.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox2.LabelText = "En"
        Me.StiTextBox2.LabelWidth = 25
        Me.StiTextBox2.Location = New System.Drawing.Point(296, 270)
        Me.StiTextBox2.MaxLength = 0
        Me.StiTextBox2.Name = "StiTextBox2"
        Me.StiTextBox2.NombreCampo = "MaxHoras"
        Me.StiTextBox2.Obligatorio = False
        Me.StiTextBox2.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox2.Size = New System.Drawing.Size(93, 20)
        Me.StiTextBox2.SoloLectura = False
        Me.StiTextBox2.TabIndex = 6
        Me.StiTextBox2.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.StiTextBox2.Valor = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(397, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Horas"
        '
        'NotificacionesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 212
        Me.ClientSize = New System.Drawing.Size(666, 505)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StiTextBox2)
        Me.Controls.Add(Me.txtMaxCorreos)
        Me.Controls.Add(Me.txtFormulaNotificacion)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.txtCorreoDestinatarios)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdNotificacion)
        Me.Name = "NotificacionesMan"
        Me.Text = "Notificaciones Automáticas"
        Me.Controls.SetChildIndex(Me.txtIdNotificacion, 0)
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
        Me.Controls.SetChildIndex(Me.txtCorreoDestinatarios, 0)
        Me.Controls.SetChildIndex(Me.cboEstado, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.txtFormulaNotificacion, 0)
        Me.Controls.SetChildIndex(Me.txtMaxCorreos, 0)
        Me.Controls.SetChildIndex(Me.StiTextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdNotificacion As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtCorreoDestinatarios As STIControles.stiMemo
    Friend WithEvents cboEstado As STIControles.stiComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFrecuenciaNotificacion As STIControles.stiTextBox
    Friend WithEvents cboNotificarLunes As STIControles.stiComboBox
    Friend WithEvents cboNotificarMartes As STIControles.stiComboBox
    Friend WithEvents cboNotificarMiercoles As STIControles.stiComboBox
    Friend WithEvents cboNotificarJueves As STIControles.stiComboBox
    Friend WithEvents cboNotificarViernes As STIControles.stiComboBox
    Friend WithEvents cboNotificarSabado As STIControles.stiComboBox
    Friend WithEvents cboNotificarDomingo As STIControles.stiComboBox
    Friend WithEvents txtFormulaNotificacion As STIControles.stiMemo
    Friend WithEvents txtMaxCorreos As STIControles.stiTextBox
    Friend WithEvents StiTextBox2 As STIControles.stiTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
