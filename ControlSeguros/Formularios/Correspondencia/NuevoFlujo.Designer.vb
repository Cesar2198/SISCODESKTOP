<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoFlujo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoFlujo))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.cboUsuarioDestinatario = New STIControles.stiComboBox
        Me.cboIdFlujo = New STIControles.stiComboBox
        Me.cboIdUsuarioSolicita = New STIControles.stiComboBox
        Me.txtObservacion = New STIControles.stiMemo
        Me.cboUbicaciones = New STIControles.stiComboBox
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdAC = New STIControles.stiTextBox
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.btnBuscarSiniestro = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarAC = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.txtNumeroFactura = New STIControles.stiTextBox
        Me.btnBuscarFactura = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cboZona = New STIControles.stiComboBox
        Me.cboIdCiudad = New STIControles.stiComboBox
        Me.txtDireccion = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(475, 491)
        Me.btnAyuda.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(47, 504)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 11)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 504)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 11)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(376, 491)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(574, 491)
        Me.btnSalir.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(63, 504)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 11)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(529, 74)
        Me.lblNombreFormulario.Text = "Nuevo Flujo de Correspondencia"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(31, 504)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 11)
        Me.btnGuardarComo.Visible = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.cboUsuarioDestinatario)
        Me.GroupControl3.Controls.Add(Me.cboIdFlujo)
        Me.GroupControl3.Controls.Add(Me.cboIdUsuarioSolicita)
        Me.GroupControl3.Controls.Add(Me.txtObservacion)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 79)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(644, 129)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "PASO 1: Describa el documento y flujo a utilizarse"
        '
        'cboUsuarioDestinatario
        '
        Me.cboUsuarioDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUsuarioDestinatario.CampoAutoCompletar = 0
        Me.cboUsuarioDestinatario.CampoBusqueda = False
        Me.cboUsuarioDestinatario.CampoDisplay = 1
        Me.cboUsuarioDestinatario.CampoEsLlave = False
        Me.cboUsuarioDestinatario.CampoValor = 0
        Me.cboUsuarioDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUsuarioDestinatario.ControlBackColor = System.Drawing.Color.White
        Me.cboUsuarioDestinatario.ControlForeColor = System.Drawing.Color.Black
        Me.cboUsuarioDestinatario.FilasVisibles = 7
        Me.cboUsuarioDestinatario.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboUsuarioDestinatario.LabelText = "Usuario Destinatario"
        Me.cboUsuarioDestinatario.LabelWidth = 140
        Me.cboUsuarioDestinatario.Lista = ""
        Me.cboUsuarioDestinatario.Location = New System.Drawing.Point(9, 104)
        Me.cboUsuarioDestinatario.MostrarBusquedaColumnas = False
        Me.cboUsuarioDestinatario.Name = "cboUsuarioDestinatario"
        Me.cboUsuarioDestinatario.NombreCampo = ""
        Me.cboUsuarioDestinatario.Obligatorio = False
        Me.cboUsuarioDestinatario.Query = "select IdUsuario as ID, NombreUsuario as USUARIO from usuarios"
        Me.cboUsuarioDestinatario.SelectIndex = 0
        Me.cboUsuarioDestinatario.Size = New System.Drawing.Size(626, 20)
        Me.cboUsuarioDestinatario.SoloLectura = False
        Me.cboUsuarioDestinatario.StringConection = ""
        Me.cboUsuarioDestinatario.TabIndex = 3
        Me.cboUsuarioDestinatario.TextoNuevoItem = ""
        Me.cboUsuarioDestinatario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboUsuarioDestinatario.Valor = ""
        '
        'cboIdFlujo
        '
        Me.cboIdFlujo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdFlujo.CampoAutoCompletar = 1
        Me.cboIdFlujo.CampoBusqueda = False
        Me.cboIdFlujo.CampoDisplay = 1
        Me.cboIdFlujo.CampoEsLlave = False
        Me.cboIdFlujo.CampoValor = 0
        Me.cboIdFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdFlujo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdFlujo.FilasVisibles = 7
        Me.cboIdFlujo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdFlujo.LabelText = "Flujos Disponibles"
        Me.cboIdFlujo.LabelWidth = 140
        Me.cboIdFlujo.Lista = ""
        Me.cboIdFlujo.Location = New System.Drawing.Point(9, 59)
        Me.cboIdFlujo.MostrarBusquedaColumnas = True
        Me.cboIdFlujo.Name = "cboIdFlujo"
        Me.cboIdFlujo.NombreCampo = ""
        Me.cboIdFlujo.Obligatorio = True
        Me.cboIdFlujo.Query = "select IdFlujo as ID, Descripcion as FLUJO from FlujosTrabajo order by Descripcio" & _
            "n"
        Me.cboIdFlujo.SelectIndex = 0
        Me.cboIdFlujo.Size = New System.Drawing.Size(626, 20)
        Me.cboIdFlujo.SoloLectura = False
        Me.cboIdFlujo.StringConection = ""
        Me.cboIdFlujo.TabIndex = 1
        Me.cboIdFlujo.TextoNuevoItem = ""
        Me.cboIdFlujo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdFlujo.Valor = ""
        '
        'cboIdUsuarioSolicita
        '
        Me.cboIdUsuarioSolicita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdUsuarioSolicita.CampoAutoCompletar = 0
        Me.cboIdUsuarioSolicita.CampoBusqueda = False
        Me.cboIdUsuarioSolicita.CampoDisplay = 1
        Me.cboIdUsuarioSolicita.CampoEsLlave = False
        Me.cboIdUsuarioSolicita.CampoValor = 0
        Me.cboIdUsuarioSolicita.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdUsuarioSolicita.ControlBackColor = System.Drawing.Color.White
        Me.cboIdUsuarioSolicita.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdUsuarioSolicita.FilasVisibles = 7
        Me.cboIdUsuarioSolicita.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdUsuarioSolicita.LabelText = "Usuario Solicitante"
        Me.cboIdUsuarioSolicita.LabelWidth = 140
        Me.cboIdUsuarioSolicita.Lista = ""
        Me.cboIdUsuarioSolicita.Location = New System.Drawing.Point(9, 81)
        Me.cboIdUsuarioSolicita.MostrarBusquedaColumnas = False
        Me.cboIdUsuarioSolicita.Name = "cboIdUsuarioSolicita"
        Me.cboIdUsuarioSolicita.NombreCampo = ""
        Me.cboIdUsuarioSolicita.Obligatorio = True
        Me.cboIdUsuarioSolicita.Query = "select IdUsuario as ID, NombreUsuario as USUARIO from usuarios"
        Me.cboIdUsuarioSolicita.SelectIndex = 0
        Me.cboIdUsuarioSolicita.Size = New System.Drawing.Size(626, 20)
        Me.cboIdUsuarioSolicita.SoloLectura = False
        Me.cboIdUsuarioSolicita.StringConection = ""
        Me.cboIdUsuarioSolicita.TabIndex = 2
        Me.cboIdUsuarioSolicita.TextoNuevoItem = ""
        Me.cboIdUsuarioSolicita.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdUsuarioSolicita.Valor = ""
        '
        'txtObservacion
        '
        Me.txtObservacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacion.CampoBusqueda = False
        Me.txtObservacion.CampoEsLlave = False
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservacion.ControlBackColor = System.Drawing.Color.White
        Me.txtObservacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservacion.FechaActual = False
        Me.txtObservacion.Formato = ""
        Me.txtObservacion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtObservacion.LabelText = "Descripción Documento"
        Me.txtObservacion.LabelWidth = 140
        Me.txtObservacion.Location = New System.Drawing.Point(9, 25)
        Me.txtObservacion.MaxLength = 0
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.NombreCampo = ""
        Me.txtObservacion.Obligatorio = True
        Me.txtObservacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.Size = New System.Drawing.Size(627, 32)
        Me.txtObservacion.SoloLectura = False
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtObservacion.Valor = ""
        '
        'cboUbicaciones
        '
        Me.cboUbicaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUbicaciones.CampoAutoCompletar = 0
        Me.cboUbicaciones.CampoBusqueda = False
        Me.cboUbicaciones.CampoDisplay = 1
        Me.cboUbicaciones.CampoEsLlave = False
        Me.cboUbicaciones.CampoValor = 0
        Me.cboUbicaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUbicaciones.ControlBackColor = System.Drawing.Color.White
        Me.cboUbicaciones.ControlForeColor = System.Drawing.Color.Black
        Me.cboUbicaciones.FilasVisibles = 7
        Me.cboUbicaciones.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboUbicaciones.LabelText = "Ubicación"
        Me.cboUbicaciones.LabelWidth = 75
        Me.cboUbicaciones.Lista = ""
        Me.cboUbicaciones.Location = New System.Drawing.Point(11, 26)
        Me.cboUbicaciones.MostrarBusquedaColumnas = False
        Me.cboUbicaciones.Name = "cboUbicaciones"
        Me.cboUbicaciones.NombreCampo = ""
        Me.cboUbicaciones.Obligatorio = False
        Me.cboUbicaciones.Query = "select IdUbicacion as ID, Descripcion as Ubicación from Ubicaciones"
        Me.cboUbicaciones.SelectIndex = 0
        Me.cboUbicaciones.Size = New System.Drawing.Size(626, 20)
        Me.cboUbicaciones.SoloLectura = False
        Me.cboUbicaciones.StringConection = ""
        Me.cboUbicaciones.TabIndex = 0
        Me.cboUbicaciones.TextoNuevoItem = ""
        Me.cboUbicaciones.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboUbicaciones.Valor = ""
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txtIdSiniestro)
        Me.GroupControl2.Controls.Add(Me.txtIdAC)
        Me.GroupControl2.Controls.Add(Me.cboAseguradora)
        Me.GroupControl2.Controls.Add(Me.btnBuscarSiniestro)
        Me.GroupControl2.Controls.Add(Me.btnBuscarAC)
        Me.GroupControl2.Controls.Add(Me.cboIdRamo)
        Me.GroupControl2.Controls.Add(Me.txtNumeroFactura)
        Me.GroupControl2.Controls.Add(Me.btnBuscarFactura)
        Me.GroupControl2.Controls.Add(Me.btnBuscarPoliza)
        Me.GroupControl2.Controls.Add(Me.txtIdPoliza)
        Me.GroupControl2.Controls.Add(Me.cboIdProducto)
        Me.GroupControl2.Controls.Add(Me.btnBuscarCliente)
        Me.GroupControl2.Controls.Add(Me.txtIdCliente)
        Me.GroupControl2.Controls.Add(Me.txtNombreCliente)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 214)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(644, 171)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "PASO 2: Seleccione el documento que se adjuntará al flujo"
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = True
        Me.txtIdSiniestro.CampoEsLlave = True
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Núm. Siniestro"
        Me.txtIdSiniestro.LabelWidth = 90
        Me.txtIdSiniestro.Location = New System.Drawing.Point(243, 124)
        Me.txtIdSiniestro.MaxLength = 25
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = "IdPoliza"
        Me.txtIdSiniestro.Obligatorio = False
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(229, 20)
        Me.txtIdSiniestro.SoloLectura = False
        Me.txtIdSiniestro.TabIndex = 12
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtIdAC
        '
        Me.txtIdAC.CampoBusqueda = True
        Me.txtIdAC.CampoEsLlave = True
        Me.txtIdAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAC.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAC.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAC.FechaActual = False
        Me.txtIdAC.Formato = ""
        Me.txtIdAC.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAC.LabelText = "Aviso de Cobro"
        Me.txtIdAC.LabelWidth = 75
        Me.txtIdAC.Location = New System.Drawing.Point(11, 124)
        Me.txtIdAC.MaxLength = 25
        Me.txtIdAC.Name = "txtIdAC"
        Me.txtIdAC.NombreCampo = "IdPoliza"
        Me.txtIdAC.Obligatorio = False
        Me.txtIdAC.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAC.Size = New System.Drawing.Size(226, 20)
        Me.txtIdAC.SoloLectura = False
        Me.txtIdAC.TabIndex = 11
        Me.txtIdAC.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAC.Valor = ""
        '
        'cboAseguradora
        '
        Me.cboAseguradora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAseguradora.CampoAutoCompletar = 1
        Me.cboAseguradora.CampoBusqueda = True
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = True
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 7
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 75
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(10, 146)
        Me.cboAseguradora.MostrarBusquedaColumnas = False
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = ""
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select IdAseguradora as ID, Nombre as Aseguradora from Aseguradoras order by 2"
        Me.cboAseguradora.SelectIndex = 0
        Me.cboAseguradora.Size = New System.Drawing.Size(622, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 13
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'btnBuscarSiniestro
        '
        Me.btnBuscarSiniestro.Image = CType(resources.GetObject("btnBuscarSiniestro.Image"), System.Drawing.Image)
        Me.btnBuscarSiniestro.Location = New System.Drawing.Point(513, 25)
        Me.btnBuscarSiniestro.Name = "btnBuscarSiniestro"
        Me.btnBuscarSiniestro.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarSiniestro.TabIndex = 4
        Me.btnBuscarSiniestro.Text = "Buscar Siniestro"
        '
        'btnBuscarAC
        '
        Me.btnBuscarAC.Image = CType(resources.GetObject("btnBuscarAC.Image"), System.Drawing.Image)
        Me.btnBuscarAC.Location = New System.Drawing.Point(386, 25)
        Me.btnBuscarAC.Name = "btnBuscarAC"
        Me.btnBuscarAC.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarAC.TabIndex = 3
        Me.btnBuscarAC.Text = "Buscar AC"
        '
        'cboIdRamo
        '
        Me.cboIdRamo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdRamo.CampoAutoCompletar = 1
        Me.cboIdRamo.CampoBusqueda = True
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = True
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 7
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdRamo.LabelText = "Ramo"
        Me.cboIdRamo.LabelWidth = 90
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(243, 102)
        Me.cboIdRamo.MostrarBusquedaColumnas = False
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdProducto"
        Me.cboIdRamo.Obligatorio = False
        Me.cboIdRamo.Query = "select IdRamo as ID, NombreRamo as Ramo from RamoSeguros"
        Me.cboIdRamo.SelectIndex = 0
        Me.cboIdRamo.Size = New System.Drawing.Size(389, 20)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 10
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.CampoBusqueda = True
        Me.txtNumeroFactura.CampoEsLlave = True
        Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroFactura.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroFactura.FechaActual = False
        Me.txtNumeroFactura.Formato = ""
        Me.txtNumeroFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroFactura.LabelText = "No. Factura"
        Me.txtNumeroFactura.LabelWidth = 75
        Me.txtNumeroFactura.Location = New System.Drawing.Point(11, 102)
        Me.txtNumeroFactura.MaxLength = 25
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.NombreCampo = "IdPoliza"
        Me.txtNumeroFactura.Obligatorio = False
        Me.txtNumeroFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroFactura.Size = New System.Drawing.Size(226, 20)
        Me.txtNumeroFactura.SoloLectura = False
        Me.txtNumeroFactura.TabIndex = 9
        Me.txtNumeroFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroFactura.Valor = ""
        '
        'btnBuscarFactura
        '
        Me.btnBuscarFactura.Image = CType(resources.GetObject("btnBuscarFactura.Image"), System.Drawing.Image)
        Me.btnBuscarFactura.Location = New System.Drawing.Point(259, 25)
        Me.btnBuscarFactura.Name = "btnBuscarFactura"
        Me.btnBuscarFactura.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarFactura.TabIndex = 2
        Me.btnBuscarFactura.Text = "Buscar Factura"
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(132, 25)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarPoliza.TabIndex = 1
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 75
        Me.txtIdPoliza.Location = New System.Drawing.Point(11, 80)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(226, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 7
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdProducto.CampoAutoCompletar = 1
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 90
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(243, 80)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto [Producto], Descripcion [Descripción] from Productos order by D" & _
            "escripcion asc"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(389, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 8
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(5, 25)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarCliente.TabIndex = 0
        Me.btnBuscarCliente.Text = "Buscar Cliente"
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
        Me.txtIdCliente.LabelWidth = 75
        Me.txtIdCliente.Location = New System.Drawing.Point(10, 58)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(227, 20)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 5
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 90
        Me.txtNombreCliente.Location = New System.Drawing.Point(243, 58)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(389, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 6
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.cboZona)
        Me.GroupControl1.Controls.Add(Me.cboIdCiudad)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.cboUbicaciones)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 386)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(644, 99)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "PASO 3: Seleccione la dirección de la correspondencia"
        '
        'cboZona
        '
        Me.cboZona.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboZona.CampoAutoCompletar = 1
        Me.cboZona.CampoBusqueda = False
        Me.cboZona.CampoDisplay = 1
        Me.cboZona.CampoEsLlave = False
        Me.cboZona.CampoValor = 0
        Me.cboZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboZona.ControlBackColor = System.Drawing.Color.White
        Me.cboZona.ControlForeColor = System.Drawing.Color.Black
        Me.cboZona.FilasVisibles = 7
        Me.cboZona.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboZona.LabelText = "Zona"
        Me.cboZona.LabelWidth = 75
        Me.cboZona.Lista = ""
        Me.cboZona.Location = New System.Drawing.Point(326, 71)
        Me.cboZona.MostrarBusquedaColumnas = False
        Me.cboZona.Name = "cboZona"
        Me.cboZona.NombreCampo = "IdCiudad"
        Me.cboZona.Obligatorio = False
        Me.cboZona.Query = "select IdZona as ID, DescripcionZona as ZONA from zonas"
        Me.cboZona.SelectIndex = 0
        Me.cboZona.Size = New System.Drawing.Size(310, 20)
        Me.cboZona.SoloLectura = False
        Me.cboZona.StringConection = ""
        Me.cboZona.TabIndex = 3
        Me.cboZona.TextoNuevoItem = ""
        Me.cboZona.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboZona.Valor = ""
        '
        'cboIdCiudad
        '
        Me.cboIdCiudad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.cboIdCiudad.LabelWidth = 75
        Me.cboIdCiudad.Lista = ""
        Me.cboIdCiudad.Location = New System.Drawing.Point(11, 71)
        Me.cboIdCiudad.MostrarBusquedaColumnas = False
        Me.cboIdCiudad.Name = "cboIdCiudad"
        Me.cboIdCiudad.NombreCampo = "IdCiudad"
        Me.cboIdCiudad.Obligatorio = False
        Me.cboIdCiudad.Query = resources.GetString("cboIdCiudad.Query")
        Me.cboIdCiudad.SelectIndex = 0
        Me.cboIdCiudad.Size = New System.Drawing.Size(297, 20)
        Me.cboIdCiudad.SoloLectura = False
        Me.cboIdCiudad.StringConection = ""
        Me.cboIdCiudad.TabIndex = 2
        Me.cboIdCiudad.TextoNuevoItem = ""
        Me.cboIdCiudad.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdCiudad.Valor = ""
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.CampoBusqueda = True
        Me.txtDireccion.CampoEsLlave = True
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDireccion.ControlBackColor = System.Drawing.Color.White
        Me.txtDireccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDireccion.FechaActual = False
        Me.txtDireccion.Formato = ""
        Me.txtDireccion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDireccion.LabelText = "Dirección"
        Me.txtDireccion.LabelWidth = 75
        Me.txtDireccion.Location = New System.Drawing.Point(11, 48)
        Me.txtDireccion.MaxLength = 25
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NombreCampo = "Direccion"
        Me.txtDireccion.Obligatorio = False
        Me.txtDireccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.Size = New System.Drawing.Size(626, 20)
        Me.txtDireccion.SoloLectura = False
        Me.txtDireccion.TabIndex = 1
        Me.txtDireccion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDireccion.Valor = ""
        '
        'NuevoFlujo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 911
        Me.ClientSize = New System.Drawing.Size(668, 527)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "NuevoFlujo"
        Me.Text = "Nuevo Flujo de Trabajo y Correspondencia"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        Me.Controls.SetChildIndex(Me.GroupControl3, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboIdFlujo As STIControles.stiComboBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents txtNumeroFactura As STIControles.stiTextBox
    Friend WithEvents btnBuscarFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarAC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents btnBuscarSiniestro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdAC As STIControles.stiTextBox
    Friend WithEvents cboUbicaciones As STIControles.stiComboBox
    Friend WithEvents txtObservacion As STIControles.stiMemo
    Friend WithEvents cboIdUsuarioSolicita As STIControles.stiComboBox
    Friend WithEvents cboUsuarioDestinatario As STIControles.stiComboBox
    Friend WithEvents txtDireccion As STIControles.stiTextBox
    Friend WithEvents cboZona As STIControles.stiComboBox
    Friend WithEvents cboIdCiudad As STIControles.stiComboBox

End Class
