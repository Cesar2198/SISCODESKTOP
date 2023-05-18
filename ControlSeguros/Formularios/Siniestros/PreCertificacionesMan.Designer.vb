<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreCertificacionesMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreCertificacionesMan))
        Me.txtIdAutorizacion = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdBien = New STIControles.stiTextBox
        Me.txtFechaRecibida = New STIControles.stiTextBox
        Me.txtFechaEnvio = New STIControles.stiTextBox
        Me.txtNombreAsegurado = New STIControles.stiTextBox
        Me.txtNombrePaciente = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.cboEstado = New STIControles.stiComboBox
        Me.txtDiagnostico = New STIControles.stiMemo
        Me.txtGestionSolicitada = New STIControles.stiMemo
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.tabPReCertificaciones = New DevExpress.XtraTab.XtraTabControl
        Me.pageDatos = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtFechaRespuesta = New STIControles.stiTextBox
        Me.txtPersonaAutoriza = New STIControles.stiTextBox
        Me.txtHonorarios = New STIControles.stiTextBox
        Me.txtValorCubierto = New STIControles.stiTextBox
        Me.txtDeducible = New STIControles.stiTextBox
        Me.txtValorCoaseguro = New STIControles.stiTextBox
        Me.txtPorceParticipacion = New STIControles.stiTextBox
        Me.txtObservaciones = New STIControles.stiMemo
        Me.txtValorReclamo = New STIControles.stiTextBox
        Me.txtProveedor = New STIControles.stiTextBox
        Me.pageDoc = New DevExpress.XtraTab.XtraTabPage
        Me.btnAgregarCarpeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.GridArchivos = New STIControles.stiGrid
        Me.VistaArchivos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colArcIdAutorizacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcIdDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPReCertificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPReCertificaciones.SuspendLayout()
        Me.pageDatos.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.pageDoc.SuspendLayout()
        CType(Me.GridArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(454, 534)
        Me.btnAyuda.TabIndex = 17
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(270, 534)
        Me.btnBuscar.TabIndex = 15
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(85, 534)
        Me.btnNuevo.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(177, 534)
        Me.btnGuardar.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(546, 534)
        Me.btnSalir.TabIndex = 18
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(362, 534)
        Me.btnEliminar.TabIndex = 16
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
        Me.lblNombreFormulario.TabIndex = 20
        Me.lblNombreFormulario.Text = "Administración de Pre-Certificaciones Médicas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(-22, 560)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 21
        Me.btnGuardarComo.Visible = False
        '
        'txtIdAutorizacion
        '
        Me.txtIdAutorizacion.CampoBusqueda = True
        Me.txtIdAutorizacion.CampoEsLlave = True
        Me.txtIdAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAutorizacion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAutorizacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAutorizacion.FechaActual = False
        Me.txtIdAutorizacion.Formato = ""
        Me.txtIdAutorizacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAutorizacion.LabelText = "Num. Certificación"
        Me.txtIdAutorizacion.LabelWidth = 115
        Me.txtIdAutorizacion.Location = New System.Drawing.Point(12, 78)
        Me.txtIdAutorizacion.MaxLength = 25
        Me.txtIdAutorizacion.Name = "txtIdAutorizacion"
        Me.txtIdAutorizacion.NombreCampo = "IdAutorizacion"
        Me.txtIdAutorizacion.Obligatorio = True
        Me.txtIdAutorizacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAutorizacion.Size = New System.Drawing.Size(259, 20)
        Me.txtIdAutorizacion.SoloLectura = False
        Me.txtIdAutorizacion.TabIndex = 0
        Me.txtIdAutorizacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAutorizacion.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = False
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 115
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 101)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(259, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 2
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = True
        Me.txtIdCertificado.CampoEsLlave = False
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 75
        Me.txtIdCertificado.Location = New System.Drawing.Point(277, 101)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(141, 20)
        Me.txtIdCertificado.SoloLectura = False
        Me.txtIdCertificado.TabIndex = 3
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'txtIdBien
        '
        Me.txtIdBien.CampoBusqueda = False
        Me.txtIdBien.CampoEsLlave = False
        Me.txtIdBien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdBien.ControlBackColor = System.Drawing.Color.White
        Me.txtIdBien.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdBien.FechaActual = False
        Me.txtIdBien.Formato = "###0"
        Me.txtIdBien.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdBien.LabelText = "Bien"
        Me.txtIdBien.LabelWidth = 35
        Me.txtIdBien.Location = New System.Drawing.Point(424, 101)
        Me.txtIdBien.MaxLength = 0
        Me.txtIdBien.Name = "txtIdBien"
        Me.txtIdBien.NombreCampo = "IdBien"
        Me.txtIdBien.Obligatorio = False
        Me.txtIdBien.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdBien.Size = New System.Drawing.Size(103, 20)
        Me.txtIdBien.SoloLectura = False
        Me.txtIdBien.TabIndex = 4
        Me.txtIdBien.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdBien.Valor = 0
        '
        'txtFechaRecibida
        '
        Me.txtFechaRecibida.CampoBusqueda = True
        Me.txtFechaRecibida.CampoEsLlave = False
        Me.txtFechaRecibida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaRecibida.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaRecibida.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaRecibida.FechaActual = True
        Me.txtFechaRecibida.Formato = "dd/MMM/yyyy"
        Me.txtFechaRecibida.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaRecibida.LabelText = "Fecha Recepción"
        Me.txtFechaRecibida.LabelWidth = 115
        Me.txtFechaRecibida.Location = New System.Drawing.Point(12, 193)
        Me.txtFechaRecibida.MaxLength = 0
        Me.txtFechaRecibida.Name = "txtFechaRecibida"
        Me.txtFechaRecibida.NombreCampo = "FechaRecibida"
        Me.txtFechaRecibida.Obligatorio = True
        Me.txtFechaRecibida.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecibida.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaRecibida.SoloLectura = False
        Me.txtFechaRecibida.TabIndex = 8
        Me.txtFechaRecibida.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecibida.Valor = Nothing
        '
        'txtFechaEnvio
        '
        Me.txtFechaEnvio.CampoBusqueda = False
        Me.txtFechaEnvio.CampoEsLlave = False
        Me.txtFechaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvio.FechaActual = False
        Me.txtFechaEnvio.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvio.LabelText = "Fecha Envío"
        Me.txtFechaEnvio.LabelWidth = 115
        Me.txtFechaEnvio.Location = New System.Drawing.Point(331, 193)
        Me.txtFechaEnvio.MaxLength = 0
        Me.txtFechaEnvio.Name = "txtFechaEnvio"
        Me.txtFechaEnvio.NombreCampo = "FechaEnvio"
        Me.txtFechaEnvio.Obligatorio = False
        Me.txtFechaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaEnvio.SoloLectura = False
        Me.txtFechaEnvio.TabIndex = 9
        Me.txtFechaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvio.Valor = Nothing
        '
        'txtNombreAsegurado
        '
        Me.txtNombreAsegurado.CampoBusqueda = True
        Me.txtNombreAsegurado.CampoEsLlave = False
        Me.txtNombreAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreAsegurado.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreAsegurado.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreAsegurado.FechaActual = False
        Me.txtNombreAsegurado.Formato = ""
        Me.txtNombreAsegurado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreAsegurado.LabelText = "Nombre Asegurado"
        Me.txtNombreAsegurado.LabelWidth = 115
        Me.txtNombreAsegurado.Location = New System.Drawing.Point(12, 147)
        Me.txtNombreAsegurado.MaxLength = 150
        Me.txtNombreAsegurado.Name = "txtNombreAsegurado"
        Me.txtNombreAsegurado.NombreCampo = "NombreAsegurado"
        Me.txtNombreAsegurado.Obligatorio = True
        Me.txtNombreAsegurado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreAsegurado.Size = New System.Drawing.Size(619, 20)
        Me.txtNombreAsegurado.SoloLectura = False
        Me.txtNombreAsegurado.TabIndex = 6
        Me.txtNombreAsegurado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreAsegurado.Valor = ""
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.CampoBusqueda = False
        Me.txtNombrePaciente.CampoEsLlave = False
        Me.txtNombrePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombrePaciente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombrePaciente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombrePaciente.FechaActual = False
        Me.txtNombrePaciente.Formato = ""
        Me.txtNombrePaciente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombrePaciente.LabelText = "Nombre Paciente"
        Me.txtNombrePaciente.LabelWidth = 115
        Me.txtNombrePaciente.Location = New System.Drawing.Point(12, 170)
        Me.txtNombrePaciente.MaxLength = 150
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.NombreCampo = "NombrePaciente"
        Me.txtNombrePaciente.Obligatorio = True
        Me.txtNombrePaciente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombrePaciente.Size = New System.Drawing.Size(619, 20)
        Me.txtNombrePaciente.SoloLectura = False
        Me.txtNombrePaciente.TabIndex = 7
        Me.txtNombrePaciente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombrePaciente.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = False
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = False
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 115
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 124)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(619, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 5
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'cboEstado
        '
        Me.cboEstado.CampoAutoCompletar = 0
        Me.cboEstado.CampoBusqueda = True
        Me.cboEstado.CampoDisplay = 1
        Me.cboEstado.CampoEsLlave = False
        Me.cboEstado.CampoValor = 0
        Me.cboEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstado.ControlBackColor = System.Drawing.Color.White
        Me.cboEstado.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstado.FilasVisibles = 7
        Me.cboEstado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstado.LabelText = "Estado"
        Me.cboEstado.LabelWidth = 75
        Me.cboEstado.Lista = "PENDIENTE Pendiente|AUTORIZADO Autorizado|RECHAZADO Rechazado"
        Me.cboEstado.Location = New System.Drawing.Point(277, 78)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.NombreCampo = "Estado"
        Me.cboEstado.Obligatorio = True
        Me.cboEstado.Query = ""
        Me.cboEstado.SelectIndex = -1
        Me.cboEstado.Size = New System.Drawing.Size(250, 20)
        Me.cboEstado.SoloLectura = False
        Me.cboEstado.StringConection = ""
        Me.cboEstado.TabIndex = 1
        Me.cboEstado.TextoNuevoItem = ""
        Me.cboEstado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstado.Valor = ""
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiagnostico.CampoBusqueda = False
        Me.txtDiagnostico.CampoEsLlave = False
        Me.txtDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDiagnostico.ControlBackColor = System.Drawing.Color.White
        Me.txtDiagnostico.ControlForeColor = System.Drawing.Color.Black
        Me.txtDiagnostico.FechaActual = False
        Me.txtDiagnostico.Formato = ""
        Me.txtDiagnostico.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtDiagnostico.LabelText = "Diagnostico"
        Me.txtDiagnostico.LabelWidth = 115
        Me.txtDiagnostico.Location = New System.Drawing.Point(12, 217)
        Me.txtDiagnostico.MaxLength = 0
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.NombreCampo = "Diagnostico"
        Me.txtDiagnostico.Obligatorio = False
        Me.txtDiagnostico.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiagnostico.Size = New System.Drawing.Size(618, 35)
        Me.txtDiagnostico.SoloLectura = False
        Me.txtDiagnostico.TabIndex = 10
        Me.txtDiagnostico.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtDiagnostico.Valor = ""
        '
        'txtGestionSolicitada
        '
        Me.txtGestionSolicitada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGestionSolicitada.CampoBusqueda = False
        Me.txtGestionSolicitada.CampoEsLlave = False
        Me.txtGestionSolicitada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGestionSolicitada.ControlBackColor = System.Drawing.Color.White
        Me.txtGestionSolicitada.ControlForeColor = System.Drawing.Color.Black
        Me.txtGestionSolicitada.FechaActual = False
        Me.txtGestionSolicitada.Formato = ""
        Me.txtGestionSolicitada.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtGestionSolicitada.LabelText = "Gestión Solicitada"
        Me.txtGestionSolicitada.LabelWidth = 115
        Me.txtGestionSolicitada.Location = New System.Drawing.Point(12, 256)
        Me.txtGestionSolicitada.MaxLength = 0
        Me.txtGestionSolicitada.Name = "txtGestionSolicitada"
        Me.txtGestionSolicitada.NombreCampo = "GestionSolicitada"
        Me.txtGestionSolicitada.Obligatorio = False
        Me.txtGestionSolicitada.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGestionSolicitada.Size = New System.Drawing.Size(618, 35)
        Me.txtGestionSolicitada.SoloLectura = False
        Me.txtGestionSolicitada.TabIndex = 11
        Me.txtGestionSolicitada.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtGestionSolicitada.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Appearance.Options.UseTextOptions = True
        Me.btnBuscarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(534, 78)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(102, 42)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.Text = "&Buscar Pólizas / Asegurados"
        '
        'tabPReCertificaciones
        '
        Me.tabPReCertificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPReCertificaciones.Location = New System.Drawing.Point(12, 297)
        Me.tabPReCertificaciones.Name = "tabPReCertificaciones"
        Me.tabPReCertificaciones.SelectedTabPage = Me.pageDatos
        Me.tabPReCertificaciones.Size = New System.Drawing.Size(624, 234)
        Me.tabPReCertificaciones.TabIndex = 12
        Me.tabPReCertificaciones.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pageDatos, Me.pageDoc})
        '
        'pageDatos
        '
        Me.pageDatos.Controls.Add(Me.GroupControl1)
        Me.pageDatos.Controls.Add(Me.txtObservaciones)
        Me.pageDatos.Controls.Add(Me.txtValorReclamo)
        Me.pageDatos.Controls.Add(Me.txtProveedor)
        Me.pageDatos.Name = "pageDatos"
        Me.pageDatos.Size = New System.Drawing.Size(615, 203)
        Me.pageDatos.Text = "Datos Precertificación"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.txtFechaRespuesta)
        Me.GroupControl1.Controls.Add(Me.txtPersonaAutoriza)
        Me.GroupControl1.Controls.Add(Me.txtHonorarios)
        Me.GroupControl1.Controls.Add(Me.txtValorCubierto)
        Me.GroupControl1.Controls.Add(Me.txtDeducible)
        Me.GroupControl1.Controls.Add(Me.txtValorCoaseguro)
        Me.GroupControl1.Controls.Add(Me.txtPorceParticipacion)
        Me.GroupControl1.Location = New System.Drawing.Point(327, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(288, 195)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Resolución Aseguradora"
        '
        'txtFechaRespuesta
        '
        Me.txtFechaRespuesta.CampoBusqueda = False
        Me.txtFechaRespuesta.CampoEsLlave = False
        Me.txtFechaRespuesta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaRespuesta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaRespuesta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaRespuesta.FechaActual = False
        Me.txtFechaRespuesta.Formato = "dd/MMM/yyyy"
        Me.txtFechaRespuesta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaRespuesta.LabelText = "Fecha Respuesta"
        Me.txtFechaRespuesta.LabelWidth = 115
        Me.txtFechaRespuesta.Location = New System.Drawing.Point(16, 23)
        Me.txtFechaRespuesta.MaxLength = 0
        Me.txtFechaRespuesta.Name = "txtFechaRespuesta"
        Me.txtFechaRespuesta.NombreCampo = "FechaRespuesta"
        Me.txtFechaRespuesta.Obligatorio = False
        Me.txtFechaRespuesta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRespuesta.Size = New System.Drawing.Size(250, 20)
        Me.txtFechaRespuesta.SoloLectura = False
        Me.txtFechaRespuesta.TabIndex = 0
        Me.txtFechaRespuesta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRespuesta.Valor = Nothing
        '
        'txtPersonaAutoriza
        '
        Me.txtPersonaAutoriza.CampoBusqueda = False
        Me.txtPersonaAutoriza.CampoEsLlave = False
        Me.txtPersonaAutoriza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPersonaAutoriza.ControlBackColor = System.Drawing.Color.White
        Me.txtPersonaAutoriza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPersonaAutoriza.FechaActual = False
        Me.txtPersonaAutoriza.Formato = ""
        Me.txtPersonaAutoriza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPersonaAutoriza.LabelText = "Autorizado Por"
        Me.txtPersonaAutoriza.LabelWidth = 115
        Me.txtPersonaAutoriza.Location = New System.Drawing.Point(16, 47)
        Me.txtPersonaAutoriza.MaxLength = 150
        Me.txtPersonaAutoriza.Name = "txtPersonaAutoriza"
        Me.txtPersonaAutoriza.NombreCampo = "PersonaAutoriza"
        Me.txtPersonaAutoriza.Obligatorio = False
        Me.txtPersonaAutoriza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPersonaAutoriza.Size = New System.Drawing.Size(250, 20)
        Me.txtPersonaAutoriza.SoloLectura = False
        Me.txtPersonaAutoriza.TabIndex = 1
        Me.txtPersonaAutoriza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPersonaAutoriza.Valor = ""
        '
        'txtHonorarios
        '
        Me.txtHonorarios.CampoBusqueda = False
        Me.txtHonorarios.CampoEsLlave = False
        Me.txtHonorarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHonorarios.ControlBackColor = System.Drawing.Color.White
        Me.txtHonorarios.ControlForeColor = System.Drawing.Color.Black
        Me.txtHonorarios.FechaActual = False
        Me.txtHonorarios.Formato = "#,###0.00"
        Me.txtHonorarios.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtHonorarios.LabelText = "Honorarios Medicos"
        Me.txtHonorarios.LabelWidth = 115
        Me.txtHonorarios.Location = New System.Drawing.Point(16, 71)
        Me.txtHonorarios.MaxLength = 0
        Me.txtHonorarios.Name = "txtHonorarios"
        Me.txtHonorarios.NombreCampo = "Honorarios"
        Me.txtHonorarios.Obligatorio = False
        Me.txtHonorarios.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHonorarios.Size = New System.Drawing.Size(250, 20)
        Me.txtHonorarios.SoloLectura = False
        Me.txtHonorarios.TabIndex = 2
        Me.txtHonorarios.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtHonorarios.Valor = 0
        '
        'txtValorCubierto
        '
        Me.txtValorCubierto.CampoBusqueda = False
        Me.txtValorCubierto.CampoEsLlave = False
        Me.txtValorCubierto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorCubierto.ControlBackColor = System.Drawing.Color.White
        Me.txtValorCubierto.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorCubierto.FechaActual = False
        Me.txtValorCubierto.Formato = "#,###0.00"
        Me.txtValorCubierto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorCubierto.LabelText = "Valor Cubierto"
        Me.txtValorCubierto.LabelWidth = 115
        Me.txtValorCubierto.Location = New System.Drawing.Point(16, 164)
        Me.txtValorCubierto.MaxLength = 0
        Me.txtValorCubierto.Name = "txtValorCubierto"
        Me.txtValorCubierto.NombreCampo = "ValorCubierto"
        Me.txtValorCubierto.Obligatorio = False
        Me.txtValorCubierto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorCubierto.Size = New System.Drawing.Size(250, 20)
        Me.txtValorCubierto.SoloLectura = False
        Me.txtValorCubierto.TabIndex = 6
        Me.txtValorCubierto.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorCubierto.Valor = 0
        '
        'txtDeducible
        '
        Me.txtDeducible.CampoBusqueda = False
        Me.txtDeducible.CampoEsLlave = False
        Me.txtDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDeducible.ControlBackColor = System.Drawing.Color.White
        Me.txtDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtDeducible.FechaActual = False
        Me.txtDeducible.Formato = "#,###0.00"
        Me.txtDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDeducible.LabelText = "Deducible"
        Me.txtDeducible.LabelWidth = 115
        Me.txtDeducible.Location = New System.Drawing.Point(16, 95)
        Me.txtDeducible.MaxLength = 0
        Me.txtDeducible.Name = "txtDeducible"
        Me.txtDeducible.NombreCampo = "Deducible"
        Me.txtDeducible.Obligatorio = False
        Me.txtDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeducible.Size = New System.Drawing.Size(250, 20)
        Me.txtDeducible.SoloLectura = False
        Me.txtDeducible.TabIndex = 3
        Me.txtDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtDeducible.Valor = 0
        '
        'txtValorCoaseguro
        '
        Me.txtValorCoaseguro.CampoBusqueda = False
        Me.txtValorCoaseguro.CampoEsLlave = False
        Me.txtValorCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorCoaseguro.ControlBackColor = System.Drawing.Color.White
        Me.txtValorCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorCoaseguro.FechaActual = False
        Me.txtValorCoaseguro.Formato = "#,###0.00"
        Me.txtValorCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorCoaseguro.LabelText = "Valor Coaseguro"
        Me.txtValorCoaseguro.LabelWidth = 115
        Me.txtValorCoaseguro.Location = New System.Drawing.Point(16, 141)
        Me.txtValorCoaseguro.MaxLength = 0
        Me.txtValorCoaseguro.Name = "txtValorCoaseguro"
        Me.txtValorCoaseguro.NombreCampo = "ValorCoaseguro"
        Me.txtValorCoaseguro.Obligatorio = False
        Me.txtValorCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorCoaseguro.Size = New System.Drawing.Size(250, 20)
        Me.txtValorCoaseguro.SoloLectura = False
        Me.txtValorCoaseguro.TabIndex = 5
        Me.txtValorCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorCoaseguro.Valor = 0
        '
        'txtPorceParticipacion
        '
        Me.txtPorceParticipacion.CampoBusqueda = False
        Me.txtPorceParticipacion.CampoEsLlave = False
        Me.txtPorceParticipacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceParticipacion.ControlBackColor = System.Drawing.Color.White
        Me.txtPorceParticipacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceParticipacion.FechaActual = False
        Me.txtPorceParticipacion.Formato = "###0.00"
        Me.txtPorceParticipacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceParticipacion.LabelText = "% Participación"
        Me.txtPorceParticipacion.LabelWidth = 115
        Me.txtPorceParticipacion.Location = New System.Drawing.Point(16, 118)
        Me.txtPorceParticipacion.MaxLength = 0
        Me.txtPorceParticipacion.Name = "txtPorceParticipacion"
        Me.txtPorceParticipacion.NombreCampo = "PorceParticipacion"
        Me.txtPorceParticipacion.Obligatorio = False
        Me.txtPorceParticipacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceParticipacion.Size = New System.Drawing.Size(250, 20)
        Me.txtPorceParticipacion.SoloLectura = False
        Me.txtPorceParticipacion.TabIndex = 4
        Me.txtPorceParticipacion.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceParticipacion.Valor = 0
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
        Me.txtObservaciones.LabelWidth = 115
        Me.txtObservaciones.Location = New System.Drawing.Point(5, 51)
        Me.txtObservaciones.MaxLength = 0
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = "Observaciones"
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(316, 149)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'txtValorReclamo
        '
        Me.txtValorReclamo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorReclamo.CampoBusqueda = False
        Me.txtValorReclamo.CampoEsLlave = False
        Me.txtValorReclamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorReclamo.ControlBackColor = System.Drawing.Color.White
        Me.txtValorReclamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorReclamo.FechaActual = False
        Me.txtValorReclamo.Formato = "#,###0.00"
        Me.txtValorReclamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorReclamo.LabelText = "Valor del Reclamo"
        Me.txtValorReclamo.LabelWidth = 115
        Me.txtValorReclamo.Location = New System.Drawing.Point(5, 3)
        Me.txtValorReclamo.MaxLength = 0
        Me.txtValorReclamo.Name = "txtValorReclamo"
        Me.txtValorReclamo.NombreCampo = "ValorReclamo"
        Me.txtValorReclamo.Obligatorio = True
        Me.txtValorReclamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorReclamo.Size = New System.Drawing.Size(316, 20)
        Me.txtValorReclamo.SoloLectura = False
        Me.txtValorReclamo.TabIndex = 0
        Me.txtValorReclamo.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorReclamo.Valor = 0
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProveedor.CampoBusqueda = False
        Me.txtProveedor.CampoEsLlave = False
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtProveedor.ControlBackColor = System.Drawing.Color.White
        Me.txtProveedor.ControlForeColor = System.Drawing.Color.Black
        Me.txtProveedor.FechaActual = False
        Me.txtProveedor.Formato = ""
        Me.txtProveedor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtProveedor.LabelText = "Proveedor"
        Me.txtProveedor.LabelWidth = 115
        Me.txtProveedor.Location = New System.Drawing.Point(5, 27)
        Me.txtProveedor.MaxLength = 250
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.NombreCampo = "Proveedor"
        Me.txtProveedor.Obligatorio = False
        Me.txtProveedor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProveedor.Size = New System.Drawing.Size(316, 20)
        Me.txtProveedor.SoloLectura = False
        Me.txtProveedor.TabIndex = 1
        Me.txtProveedor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtProveedor.Valor = ""
        '
        'pageDoc
        '
        Me.pageDoc.Controls.Add(Me.btnAgregarCarpeta)
        Me.pageDoc.Controls.Add(Me.btnQuitarDoc)
        Me.pageDoc.Controls.Add(Me.btnAgregarDoc)
        Me.pageDoc.Controls.Add(Me.GridArchivos)
        Me.pageDoc.Name = "pageDoc"
        Me.pageDoc.Size = New System.Drawing.Size(615, 203)
        Me.pageDoc.Text = "Documentos"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(511, 40)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarCarpeta.TabIndex = 5
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(511, 75)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDoc.TabIndex = 6
        Me.btnQuitarDoc.Text = "Quitar"
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(511, 3)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarDoc.TabIndex = 4
        Me.btnAgregarDoc.Text = "Agregar Archivo"
        '
        'GridArchivos
        '
        Me.GridArchivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridArchivos.Location = New System.Drawing.Point(3, 3)
        Me.GridArchivos.MainView = Me.VistaArchivos
        Me.GridArchivos.Name = "GridArchivos"
        Me.GridArchivos.NombreTabla = "PreAutorizacionesDocumentos"
        Me.GridArchivos.Size = New System.Drawing.Size(502, 197)
        Me.GridArchivos.TabIndex = 2
        Me.GridArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaArchivos})
        '
        'VistaArchivos
        '
        Me.VistaArchivos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArcIdAutorizacion, Me.colArcIdDocumento, Me.colArcDocumento})
        Me.VistaArchivos.GridControl = Me.GridArchivos
        Me.VistaArchivos.Name = "VistaArchivos"
        Me.VistaArchivos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaArchivos.OptionsView.ShowGroupPanel = False
        '
        'colArcIdAutorizacion
        '
        Me.colArcIdAutorizacion.Caption = "IdAutorizacion"
        Me.colArcIdAutorizacion.FieldName = "IdAutorizacion"
        Me.colArcIdAutorizacion.Name = "colArcIdAutorizacion"
        '
        'colArcIdDocumento
        '
        Me.colArcIdDocumento.Caption = "Orden"
        Me.colArcIdDocumento.FieldName = "IdDocumento"
        Me.colArcIdDocumento.Name = "colArcIdDocumento"
        Me.colArcIdDocumento.Visible = True
        Me.colArcIdDocumento.VisibleIndex = 0
        Me.colArcIdDocumento.Width = 59
        '
        'colArcDocumento
        '
        Me.colArcDocumento.Caption = "Archivo"
        Me.colArcDocumento.FieldName = "Documento"
        Me.colArcDocumento.Name = "colArcDocumento"
        Me.colArcDocumento.OptionsColumn.AllowEdit = False
        Me.colArcDocumento.Visible = True
        Me.colArcDocumento.VisibleIndex = 1
        Me.colArcDocumento.Width = 405
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PreCertificacionesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 8111
        Me.ClientSize = New System.Drawing.Size(640, 570)
        Me.Controls.Add(Me.tabPReCertificaciones)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtGestionSolicitada)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtNombrePaciente)
        Me.Controls.Add(Me.txtNombreAsegurado)
        Me.Controls.Add(Me.txtFechaEnvio)
        Me.Controls.Add(Me.txtFechaRecibida)
        Me.Controls.Add(Me.txtIdBien)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtIdAutorizacion)
        Me.Name = "PreCertificacionesMan"
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Pre-Certificaciones"
        Me.Controls.SetChildIndex(Me.txtIdAutorizacion, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdBien, 0)
        Me.Controls.SetChildIndex(Me.txtFechaRecibida, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnvio, 0)
        Me.Controls.SetChildIndex(Me.txtNombreAsegurado, 0)
        Me.Controls.SetChildIndex(Me.txtNombrePaciente, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.cboEstado, 0)
        Me.Controls.SetChildIndex(Me.txtDiagnostico, 0)
        Me.Controls.SetChildIndex(Me.txtGestionSolicitada, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.tabPReCertificaciones, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPReCertificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPReCertificaciones.ResumeLayout(False)
        Me.pageDatos.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.pageDoc.ResumeLayout(False)
        CType(Me.GridArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdAutorizacion As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdBien As STIControles.stiTextBox
    Friend WithEvents txtFechaRecibida As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvio As STIControles.stiTextBox
    Friend WithEvents txtNombreAsegurado As STIControles.stiTextBox
    Friend WithEvents txtNombrePaciente As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboEstado As STIControles.stiComboBox
    Friend WithEvents txtDiagnostico As STIControles.stiMemo
    Friend WithEvents txtGestionSolicitada As STIControles.stiMemo
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabPReCertificaciones As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pageDatos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFechaRespuesta As STIControles.stiTextBox
    Friend WithEvents txtPersonaAutoriza As STIControles.stiTextBox
    Friend WithEvents txtHonorarios As STIControles.stiTextBox
    Friend WithEvents txtValorCubierto As STIControles.stiTextBox
    Friend WithEvents txtDeducible As STIControles.stiTextBox
    Friend WithEvents txtValorCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtPorceParticipacion As STIControles.stiTextBox
    Friend WithEvents txtObservaciones As STIControles.stiMemo
    Friend WithEvents txtValorReclamo As STIControles.stiTextBox
    Friend WithEvents txtProveedor As STIControles.stiTextBox
    Friend WithEvents pageDoc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridArchivos As STIControles.stiGrid
    Friend WithEvents VistaArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colArcIdAutorizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcIdDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarCarpeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
