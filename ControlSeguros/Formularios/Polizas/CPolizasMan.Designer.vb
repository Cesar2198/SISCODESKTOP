<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPolizasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CPolizasMan))
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.cboEstadoPoliza = New STIControles.stiComboBox
        Me.txtMotivoCancelacion = New STIControles.stiTextBox
        Me.txtFechaCancelacion = New STIControles.stiTextBox
        Me.cboVendedor = New STIControles.stiComboBox
        Me.TabPoliza = New DevExpress.XtraTab.XtraTabControl
        Me.pagCertificados = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirCertificados = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarCert = New DevExpress.XtraEditors.SimpleButton
        Me.GridCertificados = New STIControles.stiGrid
        Me.VistaCertificados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaDesde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaHasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGastos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAsegurado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.pagClausulas = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarClausula = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarClausula = New DevExpress.XtraEditors.SimpleButton
        Me.GridClausulas = New STIControles.stiGrid
        Me.VistaClausulas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colClaIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaIdClausula = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colclaClausula = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colClaCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagDocumentos = New DevExpress.XtraTab.XtraTabPage
        Me.btnAgregarCarpeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.GridDoc = New STIControles.stiGrid
        Me.VistaDoc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColArchivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pag21200000 = New DevExpress.XtraTab.XtraTabPage
        Me.txtResumenPlan = New STIControles.stiTextBox
        Me.txtResumenFechaSolicita = New STIControles.stiTextBox
        Me.txtResumenPrimaIva = New STIControles.stiTextBox
        Me.txtResumenNumeroCartaEnvio = New STIControles.stiTextBox
        Me.cboResumenFormaEnvio = New STIControles.stiComboBox
        Me.txtResumenSeguimiento = New STIControles.stiMemo
        Me.txtResumenFechaEnvio = New STIControles.stiTextBox
        Me.txtResumenNumeroCuotas = New STIControles.stiTextBox
        Me.cboResumenFormaPago = New STIControles.stiComboBox
        Me.txtResumenPrimaAnual = New STIControles.stiTextBox
        Me.txtResumenSumaAsegurada = New STIControles.stiTextBox
        Me.pagGestion = New DevExpress.XtraTab.XtraTabPage
        Me.btnGestionOutlook = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarGestion = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGestion = New DevExpress.XtraEditors.SimpleButton
        Me.GridGestiones = New STIControles.stiGrid
        Me.VistaGestiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGesIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesTipoGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesFechaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesComentarios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesFechaProximaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtPorceComision = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtObservacionesRenovacion = New STIControles.stiTextBox
        Me.txtFechaSolicitudRenovacion = New STIControles.stiTextBox
        Me.txtNumVigencia = New STIControles.stiTextBox
        Me.txtFechaVinculacion = New STIControles.stiTextBox
        Me.btnAceptarOferta = New DevExpress.XtraEditors.SimpleButton
        Me.cboDepartamento = New STIControles.stiComboBox
        Me.txtFechaGrabacion = New STIControles.stiTextBox
        Me.txtFechaCambioEstado = New STIControles.stiTextBox
        Me.txtFechaAceptada = New STIControles.stiTextBox
        Me.cboTipoDeducible = New STIControles.stiComboBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.cboNegocioPor = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPoliza.SuspendLayout()
        Me.pagCertificados.SuspendLayout()
        CType(Me.GridCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagClausulas.SuspendLayout()
        CType(Me.GridClausulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaClausulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDocumentos.SuspendLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pag21200000.SuspendLayout()
        Me.pagGestion.SuspendLayout()
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(654, 597)
        Me.btnAyuda.Size = New System.Drawing.Size(82, 36)
        Me.btnAyuda.TabIndex = 20
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(569, 597)
        Me.btnBuscar.Size = New System.Drawing.Size(84, 36)
        Me.btnBuscar.TabIndex = 19
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(4, 597)
        Me.btnNuevo.Size = New System.Drawing.Size(83, 36)
        Me.btnNuevo.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(88, 597)
        Me.btnGuardar.Size = New System.Drawing.Size(92, 36)
        Me.btnGuardar.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(737, 597)
        Me.btnSalir.Size = New System.Drawing.Size(79, 36)
        Me.btnSalir.TabIndex = 21
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(275, 597)
        Me.btnEliminar.TabIndex = 16
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(687, 74)
        Me.lblNombreFormulario.TabIndex = 17
        Me.lblNombreFormulario.Text = "Ofertas de Seguro"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(181, 597)
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
        Me.txtIdPoliza.LabelText = "Número Oferta"
        Me.txtIdPoliza.LabelWidth = 100
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 78)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(397, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 0
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 1979
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 101)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(784, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 1
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(415, 122)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 3
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 149)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(785, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 5
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
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
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 124)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(397, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 2
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = True
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = True
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 100
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(12, 173)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(397, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 6
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = True
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = False
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigencia Hasta"
        Me.txtVigenciaHasta.LabelWidth = 120
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(415, 173)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(383, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 7
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'cboEstadoPoliza
        '
        Me.cboEstadoPoliza.CampoAutoCompletar = 0
        Me.cboEstadoPoliza.CampoBusqueda = False
        Me.cboEstadoPoliza.CampoDisplay = 1
        Me.cboEstadoPoliza.CampoEsLlave = False
        Me.cboEstadoPoliza.CampoValor = 0
        Me.cboEstadoPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoPoliza.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoPoliza.FilasVisibles = 1979
        Me.cboEstadoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoPoliza.LabelText = "Estado Oferta"
        Me.cboEstadoPoliza.LabelWidth = 120
        Me.cboEstadoPoliza.Lista = "PENDIENTE Pendiente|ACEPTADA Aceptada|RECHAZADA Rechazada|ESPOLIZA Convertida a P" & _
            "óliza|ENTRAMITE En Trámite"
        Me.cboEstadoPoliza.Location = New System.Drawing.Point(415, 78)
        Me.cboEstadoPoliza.MostrarBusquedaColumnas = False
        Me.cboEstadoPoliza.Name = "cboEstadoPoliza"
        Me.cboEstadoPoliza.NombreCampo = "EstadoPoliza"
        Me.cboEstadoPoliza.Obligatorio = True
        Me.cboEstadoPoliza.Query = ""
        Me.cboEstadoPoliza.SelectIndex = 0
        Me.cboEstadoPoliza.Size = New System.Drawing.Size(383, 20)
        Me.cboEstadoPoliza.SoloLectura = False
        Me.cboEstadoPoliza.StringConection = ""
        Me.cboEstadoPoliza.TabIndex = 17
        Me.cboEstadoPoliza.TextoNuevoItem = ""
        Me.cboEstadoPoliza.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoPoliza.Valor = ""
        '
        'txtMotivoCancelacion
        '
        Me.txtMotivoCancelacion.CampoBusqueda = False
        Me.txtMotivoCancelacion.CampoEsLlave = False
        Me.txtMotivoCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivoCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoCancelacion.FechaActual = False
        Me.txtMotivoCancelacion.Formato = ""
        Me.txtMotivoCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMotivoCancelacion.LabelText = "Motivo Rechazo"
        Me.txtMotivoCancelacion.LabelWidth = 100
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(12, 197)
        Me.txtMotivoCancelacion.MaxLength = 250
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.NombreCampo = "MotivoCancelacion"
        Me.txtMotivoCancelacion.Obligatorio = False
        Me.txtMotivoCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(397, 20)
        Me.txtMotivoCancelacion.SoloLectura = False
        Me.txtMotivoCancelacion.TabIndex = 8
        Me.txtMotivoCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoCancelacion.Valor = ""
        '
        'txtFechaCancelacion
        '
        Me.txtFechaCancelacion.CampoBusqueda = False
        Me.txtFechaCancelacion.CampoEsLlave = False
        Me.txtFechaCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCancelacion.FechaActual = False
        Me.txtFechaCancelacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCancelacion.LabelText = "Fecha Rechazo"
        Me.txtFechaCancelacion.LabelWidth = 120
        Me.txtFechaCancelacion.Location = New System.Drawing.Point(415, 197)
        Me.txtFechaCancelacion.MaxLength = 0
        Me.txtFechaCancelacion.Name = "txtFechaCancelacion"
        Me.txtFechaCancelacion.NombreCampo = "FechaCancelacion"
        Me.txtFechaCancelacion.Obligatorio = False
        Me.txtFechaCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCancelacion.Size = New System.Drawing.Size(383, 20)
        Me.txtFechaCancelacion.SoloLectura = False
        Me.txtFechaCancelacion.TabIndex = 9
        Me.txtFechaCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCancelacion.Valor = Nothing
        '
        'cboVendedor
        '
        Me.cboVendedor.CampoAutoCompletar = 0
        Me.cboVendedor.CampoBusqueda = False
        Me.cboVendedor.CampoDisplay = 1
        Me.cboVendedor.CampoEsLlave = False
        Me.cboVendedor.CampoValor = 0
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVendedor.ControlBackColor = System.Drawing.Color.White
        Me.cboVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.cboVendedor.FilasVisibles = 1979
        Me.cboVendedor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboVendedor.LabelText = "Vendedor"
        Me.cboVendedor.LabelWidth = 100
        Me.cboVendedor.Lista = ""
        Me.cboVendedor.Location = New System.Drawing.Point(12, 221)
        Me.cboVendedor.MostrarBusquedaColumnas = False
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.NombreCampo = "IdVendedor"
        Me.cboVendedor.Obligatorio = False
        Me.cboVendedor.Query = "select IdVendedor as Id, NombreVendedor as Vendedor from Vendedores order by Nomb" & _
            "reVendedor"
        Me.cboVendedor.SelectIndex = 0
        Me.cboVendedor.Size = New System.Drawing.Size(398, 20)
        Me.cboVendedor.SoloLectura = False
        Me.cboVendedor.StringConection = ""
        Me.cboVendedor.TabIndex = 10
        Me.cboVendedor.TextoNuevoItem = ""
        Me.cboVendedor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboVendedor.Valor = ""
        '
        'TabPoliza
        '
        Me.TabPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPoliza.Location = New System.Drawing.Point(7, 340)
        Me.TabPoliza.Name = "TabPoliza"
        Me.TabPoliza.SelectedTabPage = Me.pagCertificados
        Me.TabPoliza.Size = New System.Drawing.Size(816, 251)
        Me.TabPoliza.TabIndex = 20
        Me.TabPoliza.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pagCertificados, Me.pagClausulas, Me.pagDocumentos, Me.pag21200000, Me.pagGestion})
        '
        'pagCertificados
        '
        Me.pagCertificados.Controls.Add(Me.btnImprimirCertificados)
        Me.pagCertificados.Controls.Add(Me.btnAgregarCert)
        Me.pagCertificados.Controls.Add(Me.GridCertificados)
        Me.pagCertificados.Name = "pagCertificados"
        Me.pagCertificados.Size = New System.Drawing.Size(807, 220)
        Me.pagCertificados.Text = "Certificados"
        '
        'btnImprimirCertificados
        '
        Me.btnImprimirCertificados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirCertificados.Appearance.Options.UseTextOptions = True
        Me.btnImprimirCertificados.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImprimirCertificados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimirCertificados.Image = CType(resources.GetObject("btnImprimirCertificados.Image"), System.Drawing.Image)
        Me.btnImprimirCertificados.Location = New System.Drawing.Point(704, 47)
        Me.btnImprimirCertificados.Name = "btnImprimirCertificados"
        Me.btnImprimirCertificados.Size = New System.Drawing.Size(103, 38)
        Me.btnImprimirCertificados.TabIndex = 23
        Me.btnImprimirCertificados.Text = "Imprimir Certificados"
        '
        'btnAgregarCert
        '
        Me.btnAgregarCert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCert.Appearance.Options.UseTextOptions = True
        Me.btnAgregarCert.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregarCert.Image = CType(resources.GetObject("btnAgregarCert.Image"), System.Drawing.Image)
        Me.btnAgregarCert.Location = New System.Drawing.Point(704, 3)
        Me.btnAgregarCert.Name = "btnAgregarCert"
        Me.btnAgregarCert.Size = New System.Drawing.Size(103, 38)
        Me.btnAgregarCert.TabIndex = 22
        Me.btnAgregarCert.Text = "Agregar Certificados"
        '
        'GridCertificados
        '
        Me.GridCertificados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCertificados.ColumnasAdicionales = ""
        Me.GridCertificados.Location = New System.Drawing.Point(3, 3)
        Me.GridCertificados.MainView = Me.VistaCertificados
        Me.GridCertificados.Name = "GridCertificados"
        Me.GridCertificados.NombreTabla = ""
        Me.GridCertificados.Size = New System.Drawing.Size(697, 214)
        Me.GridCertificados.TabIndex = 20
        Me.GridCertificados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCertificados, Me.GridView2})
        '
        'VistaCertificados
        '
        Me.VistaCertificados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCertificado, Me.colNombreCliente, Me.colVigenciaDesde, Me.colVigenciaHasta, Me.colPrima, Me.colGastos, Me.colIva, Me.colTotal, Me.colEstado, Me.colValorAsegurado})
        Me.VistaCertificados.GridControl = Me.GridCertificados
        Me.VistaCertificados.Name = "VistaCertificados"
        Me.VistaCertificados.OptionsBehavior.Editable = False
        Me.VistaCertificados.OptionsView.ShowAutoFilterRow = True
        Me.VistaCertificados.OptionsView.ShowFooter = True
        Me.VistaCertificados.OptionsView.ShowGroupPanel = False
        Me.VistaCertificados.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIdCertificado, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colIdCertificado
        '
        Me.colIdCertificado.Caption = "Cert."
        Me.colIdCertificado.FieldName = "IdCertificado"
        Me.colIdCertificado.Name = "colIdCertificado"
        Me.colIdCertificado.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
        Me.colIdCertificado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colIdCertificado.Visible = True
        Me.colIdCertificado.VisibleIndex = 0
        Me.colIdCertificado.Width = 39
        '
        'colNombreCliente
        '
        Me.colNombreCliente.Caption = "Asegurado"
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.SummaryItem.DisplayFormat = "TOTALES"
        Me.colNombreCliente.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 1
        '
        'colVigenciaDesde
        '
        Me.colVigenciaDesde.Caption = "Vigencia Desde"
        Me.colVigenciaDesde.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colVigenciaDesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVigenciaDesde.FieldName = "VigenciaDesde"
        Me.colVigenciaDesde.Name = "colVigenciaDesde"
        Me.colVigenciaDesde.Visible = True
        Me.colVigenciaDesde.VisibleIndex = 2
        '
        'colVigenciaHasta
        '
        Me.colVigenciaHasta.Caption = "Vigencia Hasta"
        Me.colVigenciaHasta.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colVigenciaHasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVigenciaHasta.FieldName = "VigenciaHasta"
        Me.colVigenciaHasta.Name = "colVigenciaHasta"
        Me.colVigenciaHasta.Visible = True
        Me.colVigenciaHasta.VisibleIndex = 3
        '
        'colPrima
        '
        Me.colPrima.Caption = "Prima Neta"
        Me.colPrima.DisplayFormat.FormatString = "c"
        Me.colPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrima.FieldName = "Prima"
        Me.colPrima.Name = "colPrima"
        Me.colPrima.SummaryItem.DisplayFormat = "{0:c}"
        Me.colPrima.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPrima.Visible = True
        Me.colPrima.VisibleIndex = 5
        '
        'colGastos
        '
        Me.colGastos.Caption = "Gastos"
        Me.colGastos.DisplayFormat.FormatString = "c"
        Me.colGastos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGastos.FieldName = "Gastos"
        Me.colGastos.Name = "colGastos"
        Me.colGastos.SummaryItem.DisplayFormat = "{0:c}"
        Me.colGastos.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colIva
        '
        Me.colIva.Caption = "Impuestos"
        Me.colIva.DisplayFormat.FormatString = "c"
        Me.colIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIva.FieldName = "Iva"
        Me.colIva.Name = "colIva"
        Me.colIva.SummaryItem.DisplayFormat = "{0:c}"
        Me.colIva.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 6
        '
        'colValorAsegurado
        '
        Me.colValorAsegurado.Caption = "Valor Asegurado"
        Me.colValorAsegurado.DisplayFormat.FormatString = "c"
        Me.colValorAsegurado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorAsegurado.FieldName = "ValorAsegurado"
        Me.colValorAsegurado.Name = "colValorAsegurado"
        Me.colValorAsegurado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorAsegurado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorAsegurado.Visible = True
        Me.colValorAsegurado.VisibleIndex = 4
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridCertificados
        Me.GridView2.Name = "GridView2"
        '
        'pagClausulas
        '
        Me.pagClausulas.Controls.Add(Me.btnQuitarClausula)
        Me.pagClausulas.Controls.Add(Me.btnAgregarClausula)
        Me.pagClausulas.Controls.Add(Me.GridClausulas)
        Me.pagClausulas.Name = "pagClausulas"
        Me.pagClausulas.Size = New System.Drawing.Size(807, 220)
        Me.pagClausulas.Text = "Condiciones Especiales"
        '
        'btnQuitarClausula
        '
        Me.btnQuitarClausula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarClausula.Location = New System.Drawing.Point(658, 40)
        Me.btnQuitarClausula.Name = "btnQuitarClausula"
        Me.btnQuitarClausula.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarClausula.TabIndex = 24
        Me.btnQuitarClausula.Text = "Quitar"
        '
        'btnAgregarClausula
        '
        Me.btnAgregarClausula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarClausula.Location = New System.Drawing.Point(658, 3)
        Me.btnAgregarClausula.Name = "btnAgregarClausula"
        Me.btnAgregarClausula.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarClausula.TabIndex = 23
        Me.btnAgregarClausula.Text = "Agregar"
        '
        'GridClausulas
        '
        Me.GridClausulas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridClausulas.ColumnasAdicionales = ""
        Me.GridClausulas.Location = New System.Drawing.Point(3, 3)
        Me.GridClausulas.MainView = Me.VistaClausulas
        Me.GridClausulas.Name = "GridClausulas"
        Me.GridClausulas.NombreTabla = "CPolizasClausulas"
        Me.GridClausulas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemLookUpEdit1})
        Me.GridClausulas.Size = New System.Drawing.Size(649, 135)
        Me.GridClausulas.TabIndex = 0
        Me.GridClausulas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaClausulas})
        '
        'VistaClausulas
        '
        Me.VistaClausulas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClaIdPoliza, Me.colClaIdProducto, Me.colClaIdClausula, Me.colclaClausula, Me.GridColumn1, Me.colClaCodigoInterno})
        Me.VistaClausulas.GridControl = Me.GridClausulas
        Me.VistaClausulas.Name = "VistaClausulas"
        Me.VistaClausulas.OptionsCustomization.AllowRowSizing = True
        Me.VistaClausulas.OptionsView.ShowGroupPanel = False
        '
        'colClaIdPoliza
        '
        Me.colClaIdPoliza.Caption = "Oferta"
        Me.colClaIdPoliza.FieldName = "IdPoliza"
        Me.colClaIdPoliza.Name = "colClaIdPoliza"
        '
        'colClaIdProducto
        '
        Me.colClaIdProducto.Caption = "Producto"
        Me.colClaIdProducto.FieldName = "IdProducto"
        Me.colClaIdProducto.Name = "colClaIdProducto"
        '
        'colClaIdClausula
        '
        Me.colClaIdClausula.Caption = "Cod.Clausula"
        Me.colClaIdClausula.FieldName = "IdClausula"
        Me.colClaIdClausula.Name = "colClaIdClausula"
        Me.colClaIdClausula.Visible = True
        Me.colClaIdClausula.VisibleIndex = 0
        Me.colClaIdClausula.Width = 79
        '
        'colclaClausula
        '
        Me.colclaClausula.Caption = "Descripción Condición Especial"
        Me.colclaClausula.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colclaClausula.FieldName = "Clausula"
        Me.colclaClausula.Name = "colclaClausula"
        Me.colclaClausula.Visible = True
        Me.colclaClausula.VisibleIndex = 2
        Me.colclaClausula.Width = 439
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Categoría"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "Categoria"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 104
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'colClaCodigoInterno
        '
        Me.colClaCodigoInterno.Caption = "Código"
        Me.colClaCodigoInterno.FieldName = "CodigoInterno"
        Me.colClaCodigoInterno.Name = "colClaCodigoInterno"
        Me.colClaCodigoInterno.Visible = True
        Me.colClaCodigoInterno.VisibleIndex = 1
        '
        'pagDocumentos
        '
        Me.pagDocumentos.Controls.Add(Me.btnAgregarCarpeta)
        Me.pagDocumentos.Controls.Add(Me.btnQuitarDoc)
        Me.pagDocumentos.Controls.Add(Me.btnAgregarDoc)
        Me.pagDocumentos.Controls.Add(Me.GridDoc)
        Me.pagDocumentos.Name = "pagDocumentos"
        Me.pagDocumentos.Size = New System.Drawing.Size(807, 220)
        Me.pagDocumentos.Text = "Documentos"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(648, 40)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarCarpeta.TabIndex = 23
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(648, 75)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDoc.TabIndex = 22
        Me.btnQuitarDoc.Text = "Quitar"
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(648, 3)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarDoc.TabIndex = 21
        Me.btnAgregarDoc.Text = "Agregar Archivo"
        '
        'GridDoc
        '
        Me.GridDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDoc.ColumnasAdicionales = ""
        Me.GridDoc.Location = New System.Drawing.Point(3, 3)
        Me.GridDoc.MainView = Me.VistaDoc
        Me.GridDoc.Name = "GridDoc"
        Me.GridDoc.NombreTabla = "CPolizasDocumentos"
        Me.GridDoc.Size = New System.Drawing.Size(632, 214)
        Me.GridDoc.TabIndex = 0
        Me.GridDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDoc})
        '
        'VistaDoc
        '
        Me.VistaDoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPoliza, Me.ColProducto, Me.ColDoc, Me.colDocumento, Me.ColArchivo})
        Me.VistaDoc.GridControl = Me.GridDoc
        Me.VistaDoc.Name = "VistaDoc"
        Me.VistaDoc.OptionsView.ShowGroupPanel = False
        '
        'ColPoliza
        '
        Me.ColPoliza.Caption = "Oferta"
        Me.ColPoliza.FieldName = "IdPoliza"
        Me.ColPoliza.Name = "ColPoliza"
        '
        'ColProducto
        '
        Me.ColProducto.Caption = "Producto"
        Me.ColProducto.FieldName = "IdProducto"
        Me.ColProducto.Name = "ColProducto"
        '
        'ColDoc
        '
        Me.ColDoc.Caption = "No.Doc"
        Me.ColDoc.FieldName = "IdDocumento"
        Me.ColDoc.Name = "ColDoc"
        Me.ColDoc.Visible = True
        Me.ColDoc.VisibleIndex = 0
        Me.ColDoc.Width = 57
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Documento"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Width = 210
        '
        'ColArchivo
        '
        Me.ColArchivo.Caption = "Archivo"
        Me.ColArchivo.FieldName = "Archivo"
        Me.ColArchivo.Name = "ColArchivo"
        Me.ColArchivo.Tag = "NOSAVE"
        Me.ColArchivo.Visible = True
        Me.ColArchivo.VisibleIndex = 1
        Me.ColArchivo.Width = 248
        '
        'pag21200000
        '
        Me.pag21200000.Controls.Add(Me.txtResumenPlan)
        Me.pag21200000.Controls.Add(Me.txtResumenFechaSolicita)
        Me.pag21200000.Controls.Add(Me.txtResumenPrimaIva)
        Me.pag21200000.Controls.Add(Me.txtResumenNumeroCartaEnvio)
        Me.pag21200000.Controls.Add(Me.cboResumenFormaEnvio)
        Me.pag21200000.Controls.Add(Me.txtResumenSeguimiento)
        Me.pag21200000.Controls.Add(Me.txtResumenFechaEnvio)
        Me.pag21200000.Controls.Add(Me.txtResumenNumeroCuotas)
        Me.pag21200000.Controls.Add(Me.cboResumenFormaPago)
        Me.pag21200000.Controls.Add(Me.txtResumenPrimaAnual)
        Me.pag21200000.Controls.Add(Me.txtResumenSumaAsegurada)
        Me.pag21200000.Name = "pag21200000"
        Me.pag21200000.PageVisible = False
        Me.pag21200000.Size = New System.Drawing.Size(807, 220)
        Me.pag21200000.Text = "Resumen Oferta"
        '
        'txtResumenPlan
        '
        Me.txtResumenPlan.CampoBusqueda = True
        Me.txtResumenPlan.CampoEsLlave = False
        Me.txtResumenPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenPlan.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenPlan.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenPlan.FechaActual = False
        Me.txtResumenPlan.Formato = ""
        Me.txtResumenPlan.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenPlan.LabelText = "Plan Ofertado"
        Me.txtResumenPlan.LabelWidth = 150
        Me.txtResumenPlan.Location = New System.Drawing.Point(12, 134)
        Me.txtResumenPlan.MaxLength = 600
        Me.txtResumenPlan.Name = "txtResumenPlan"
        Me.txtResumenPlan.NombreCampo = "ResumenPlan"
        Me.txtResumenPlan.Obligatorio = False
        Me.txtResumenPlan.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenPlan.Size = New System.Drawing.Size(626, 20)
        Me.txtResumenPlan.SoloLectura = False
        Me.txtResumenPlan.TabIndex = 9
        Me.txtResumenPlan.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtResumenPlan.Valor = ""
        '
        'txtResumenFechaSolicita
        '
        Me.txtResumenFechaSolicita.CampoBusqueda = True
        Me.txtResumenFechaSolicita.CampoEsLlave = False
        Me.txtResumenFechaSolicita.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenFechaSolicita.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenFechaSolicita.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenFechaSolicita.FechaActual = False
        Me.txtResumenFechaSolicita.Formato = "dd/MMM/yyyy"
        Me.txtResumenFechaSolicita.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenFechaSolicita.LabelText = "Fecha Cliente Solicita Oferta"
        Me.txtResumenFechaSolicita.LabelWidth = 150
        Me.txtResumenFechaSolicita.Location = New System.Drawing.Point(12, 29)
        Me.txtResumenFechaSolicita.MaxLength = 0
        Me.txtResumenFechaSolicita.Name = "txtResumenFechaSolicita"
        Me.txtResumenFechaSolicita.NombreCampo = "ResumenFechaSolicita"
        Me.txtResumenFechaSolicita.Obligatorio = False
        Me.txtResumenFechaSolicita.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenFechaSolicita.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenFechaSolicita.SoloLectura = False
        Me.txtResumenFechaSolicita.TabIndex = 2
        Me.txtResumenFechaSolicita.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtResumenFechaSolicita.Valor = Nothing
        '
        'txtResumenPrimaIva
        '
        Me.txtResumenPrimaIva.CampoBusqueda = True
        Me.txtResumenPrimaIva.CampoEsLlave = False
        Me.txtResumenPrimaIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenPrimaIva.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenPrimaIva.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenPrimaIva.FechaActual = False
        Me.txtResumenPrimaIva.Formato = "#,###0.00"
        Me.txtResumenPrimaIva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenPrimaIva.LabelText = "Prima con IVA"
        Me.txtResumenPrimaIva.LabelWidth = 150
        Me.txtResumenPrimaIva.Location = New System.Drawing.Point(338, 29)
        Me.txtResumenPrimaIva.MaxLength = 0
        Me.txtResumenPrimaIva.Name = "txtResumenPrimaIva"
        Me.txtResumenPrimaIva.NombreCampo = "ResumenPrimaIva"
        Me.txtResumenPrimaIva.Obligatorio = False
        Me.txtResumenPrimaIva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenPrimaIva.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenPrimaIva.SoloLectura = False
        Me.txtResumenPrimaIva.TabIndex = 3
        Me.txtResumenPrimaIva.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenPrimaIva.Valor = 0
        '
        'txtResumenNumeroCartaEnvio
        '
        Me.txtResumenNumeroCartaEnvio.CampoBusqueda = True
        Me.txtResumenNumeroCartaEnvio.CampoEsLlave = False
        Me.txtResumenNumeroCartaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenNumeroCartaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenNumeroCartaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenNumeroCartaEnvio.FechaActual = False
        Me.txtResumenNumeroCartaEnvio.Formato = ""
        Me.txtResumenNumeroCartaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenNumeroCartaEnvio.LabelText = "Número de Carta Envío"
        Me.txtResumenNumeroCartaEnvio.LabelWidth = 150
        Me.txtResumenNumeroCartaEnvio.Location = New System.Drawing.Point(12, 108)
        Me.txtResumenNumeroCartaEnvio.MaxLength = 25
        Me.txtResumenNumeroCartaEnvio.Name = "txtResumenNumeroCartaEnvio"
        Me.txtResumenNumeroCartaEnvio.NombreCampo = "ResumenNumeroCartaEnvio"
        Me.txtResumenNumeroCartaEnvio.Obligatorio = False
        Me.txtResumenNumeroCartaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenNumeroCartaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenNumeroCartaEnvio.SoloLectura = False
        Me.txtResumenNumeroCartaEnvio.TabIndex = 8
        Me.txtResumenNumeroCartaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtResumenNumeroCartaEnvio.Valor = ""
        '
        'cboResumenFormaEnvio
        '
        Me.cboResumenFormaEnvio.CampoAutoCompletar = 0
        Me.cboResumenFormaEnvio.CampoBusqueda = False
        Me.cboResumenFormaEnvio.CampoDisplay = 1
        Me.cboResumenFormaEnvio.CampoEsLlave = False
        Me.cboResumenFormaEnvio.CampoValor = 0
        Me.cboResumenFormaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboResumenFormaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.cboResumenFormaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.cboResumenFormaEnvio.FilasVisibles = 1979
        Me.cboResumenFormaEnvio.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboResumenFormaEnvio.LabelText = "Forma de Envío de Oferta"
        Me.cboResumenFormaEnvio.LabelWidth = 150
        Me.cboResumenFormaEnvio.Lista = "M Por E-mail|C Por Carta"
        Me.cboResumenFormaEnvio.Location = New System.Drawing.Point(12, 83)
        Me.cboResumenFormaEnvio.MostrarBusquedaColumnas = False
        Me.cboResumenFormaEnvio.Name = "cboResumenFormaEnvio"
        Me.cboResumenFormaEnvio.NombreCampo = "ResumenFormaEnvio"
        Me.cboResumenFormaEnvio.Obligatorio = False
        Me.cboResumenFormaEnvio.Query = ""
        Me.cboResumenFormaEnvio.SelectIndex = 0
        Me.cboResumenFormaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.cboResumenFormaEnvio.SoloLectura = False
        Me.cboResumenFormaEnvio.StringConection = ""
        Me.cboResumenFormaEnvio.TabIndex = 6
        Me.cboResumenFormaEnvio.TextoNuevoItem = ""
        Me.cboResumenFormaEnvio.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboResumenFormaEnvio.Valor = ""
        '
        'txtResumenSeguimiento
        '
        Me.txtResumenSeguimiento.CampoBusqueda = False
        Me.txtResumenSeguimiento.CampoEsLlave = False
        Me.txtResumenSeguimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenSeguimiento.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenSeguimiento.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenSeguimiento.FechaActual = False
        Me.txtResumenSeguimiento.Formato = ""
        Me.txtResumenSeguimiento.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtResumenSeguimiento.LabelText = "Seguimiento y Observación"
        Me.txtResumenSeguimiento.LabelWidth = 150
        Me.txtResumenSeguimiento.Location = New System.Drawing.Point(12, 160)
        Me.txtResumenSeguimiento.MaxLength = 0
        Me.txtResumenSeguimiento.Name = "txtResumenSeguimiento"
        Me.txtResumenSeguimiento.NombreCampo = "ResumenSeguimiento"
        Me.txtResumenSeguimiento.Obligatorio = False
        Me.txtResumenSeguimiento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenSeguimiento.Size = New System.Drawing.Size(626, 55)
        Me.txtResumenSeguimiento.SoloLectura = False
        Me.txtResumenSeguimiento.TabIndex = 10
        Me.txtResumenSeguimiento.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtResumenSeguimiento.Valor = ""
        '
        'txtResumenFechaEnvio
        '
        Me.txtResumenFechaEnvio.CampoBusqueda = True
        Me.txtResumenFechaEnvio.CampoEsLlave = False
        Me.txtResumenFechaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenFechaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenFechaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenFechaEnvio.FechaActual = False
        Me.txtResumenFechaEnvio.Formato = "dd/MMM/yyyy"
        Me.txtResumenFechaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenFechaEnvio.LabelText = "Fecha de Envío"
        Me.txtResumenFechaEnvio.LabelWidth = 150
        Me.txtResumenFechaEnvio.Location = New System.Drawing.Point(338, 83)
        Me.txtResumenFechaEnvio.MaxLength = 0
        Me.txtResumenFechaEnvio.Name = "txtResumenFechaEnvio"
        Me.txtResumenFechaEnvio.NombreCampo = "ResumenFechaEnvio"
        Me.txtResumenFechaEnvio.Obligatorio = False
        Me.txtResumenFechaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenFechaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenFechaEnvio.SoloLectura = False
        Me.txtResumenFechaEnvio.TabIndex = 7
        Me.txtResumenFechaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtResumenFechaEnvio.Valor = Nothing
        '
        'txtResumenNumeroCuotas
        '
        Me.txtResumenNumeroCuotas.CampoBusqueda = True
        Me.txtResumenNumeroCuotas.CampoEsLlave = False
        Me.txtResumenNumeroCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenNumeroCuotas.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenNumeroCuotas.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenNumeroCuotas.FechaActual = False
        Me.txtResumenNumeroCuotas.Formato = "###0"
        Me.txtResumenNumeroCuotas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenNumeroCuotas.LabelText = "Número de Cuotas"
        Me.txtResumenNumeroCuotas.LabelWidth = 150
        Me.txtResumenNumeroCuotas.Location = New System.Drawing.Point(338, 57)
        Me.txtResumenNumeroCuotas.MaxLength = 0
        Me.txtResumenNumeroCuotas.Name = "txtResumenNumeroCuotas"
        Me.txtResumenNumeroCuotas.NombreCampo = "ResumenNumeroCuotas"
        Me.txtResumenNumeroCuotas.Obligatorio = False
        Me.txtResumenNumeroCuotas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenNumeroCuotas.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenNumeroCuotas.SoloLectura = False
        Me.txtResumenNumeroCuotas.TabIndex = 5
        Me.txtResumenNumeroCuotas.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenNumeroCuotas.Valor = 0
        '
        'cboResumenFormaPago
        '
        Me.cboResumenFormaPago.CampoAutoCompletar = 0
        Me.cboResumenFormaPago.CampoBusqueda = False
        Me.cboResumenFormaPago.CampoDisplay = 1
        Me.cboResumenFormaPago.CampoEsLlave = False
        Me.cboResumenFormaPago.CampoValor = 0
        Me.cboResumenFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboResumenFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.cboResumenFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboResumenFormaPago.FilasVisibles = 1979
        Me.cboResumenFormaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboResumenFormaPago.LabelText = "Forma de Pago"
        Me.cboResumenFormaPago.LabelWidth = 150
        Me.cboResumenFormaPago.Lista = "MENSUAL Mensual|ANUAL Anual|TRIMESTRAL Trimestral|SEMESTRAL Semestral"
        Me.cboResumenFormaPago.Location = New System.Drawing.Point(12, 57)
        Me.cboResumenFormaPago.MostrarBusquedaColumnas = False
        Me.cboResumenFormaPago.Name = "cboResumenFormaPago"
        Me.cboResumenFormaPago.NombreCampo = "ResumenFormaPago"
        Me.cboResumenFormaPago.Obligatorio = False
        Me.cboResumenFormaPago.Query = ""
        Me.cboResumenFormaPago.SelectIndex = 0
        Me.cboResumenFormaPago.Size = New System.Drawing.Size(300, 20)
        Me.cboResumenFormaPago.SoloLectura = False
        Me.cboResumenFormaPago.StringConection = ""
        Me.cboResumenFormaPago.TabIndex = 4
        Me.cboResumenFormaPago.TextoNuevoItem = ""
        Me.cboResumenFormaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboResumenFormaPago.Valor = ""
        '
        'txtResumenPrimaAnual
        '
        Me.txtResumenPrimaAnual.CampoBusqueda = True
        Me.txtResumenPrimaAnual.CampoEsLlave = False
        Me.txtResumenPrimaAnual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenPrimaAnual.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenPrimaAnual.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenPrimaAnual.FechaActual = False
        Me.txtResumenPrimaAnual.Formato = "#,###0.00"
        Me.txtResumenPrimaAnual.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenPrimaAnual.LabelText = "Prima Neta"
        Me.txtResumenPrimaAnual.LabelWidth = 150
        Me.txtResumenPrimaAnual.Location = New System.Drawing.Point(338, 3)
        Me.txtResumenPrimaAnual.MaxLength = 0
        Me.txtResumenPrimaAnual.Name = "txtResumenPrimaAnual"
        Me.txtResumenPrimaAnual.NombreCampo = "ResumenPrimaAnual"
        Me.txtResumenPrimaAnual.Obligatorio = False
        Me.txtResumenPrimaAnual.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenPrimaAnual.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenPrimaAnual.SoloLectura = False
        Me.txtResumenPrimaAnual.TabIndex = 1
        Me.txtResumenPrimaAnual.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenPrimaAnual.Valor = 0
        '
        'txtResumenSumaAsegurada
        '
        Me.txtResumenSumaAsegurada.CampoBusqueda = True
        Me.txtResumenSumaAsegurada.CampoEsLlave = False
        Me.txtResumenSumaAsegurada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResumenSumaAsegurada.ControlBackColor = System.Drawing.Color.White
        Me.txtResumenSumaAsegurada.ControlForeColor = System.Drawing.Color.Black
        Me.txtResumenSumaAsegurada.FechaActual = False
        Me.txtResumenSumaAsegurada.Formato = "#,###0.00"
        Me.txtResumenSumaAsegurada.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtResumenSumaAsegurada.LabelText = "Suma Asegurada"
        Me.txtResumenSumaAsegurada.LabelWidth = 150
        Me.txtResumenSumaAsegurada.Location = New System.Drawing.Point(12, 3)
        Me.txtResumenSumaAsegurada.MaxLength = 0
        Me.txtResumenSumaAsegurada.Name = "txtResumenSumaAsegurada"
        Me.txtResumenSumaAsegurada.NombreCampo = "ResumenSumaAsegurada"
        Me.txtResumenSumaAsegurada.Obligatorio = False
        Me.txtResumenSumaAsegurada.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResumenSumaAsegurada.Size = New System.Drawing.Size(300, 20)
        Me.txtResumenSumaAsegurada.SoloLectura = False
        Me.txtResumenSumaAsegurada.TabIndex = 0
        Me.txtResumenSumaAsegurada.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtResumenSumaAsegurada.Valor = 0
        '
        'pagGestion
        '
        Me.pagGestion.Controls.Add(Me.btnGestionOutlook)
        Me.pagGestion.Controls.Add(Me.btnQuitarGestion)
        Me.pagGestion.Controls.Add(Me.btnAgregarGestion)
        Me.pagGestion.Controls.Add(Me.GridGestiones)
        Me.pagGestion.Name = "pagGestion"
        Me.pagGestion.Size = New System.Drawing.Size(807, 220)
        Me.pagGestion.Text = "Gestiones"
        '
        'btnGestionOutlook
        '
        Me.btnGestionOutlook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestionOutlook.Appearance.Options.UseTextOptions = True
        Me.btnGestionOutlook.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGestionOutlook.Location = New System.Drawing.Point(702, 51)
        Me.btnGestionOutlook.Name = "btnGestionOutlook"
        Me.btnGestionOutlook.Size = New System.Drawing.Size(102, 34)
        Me.btnGestionOutlook.TabIndex = 11
        Me.btnGestionOutlook.Text = "A Calendario Outlook"
        '
        'btnQuitarGestion
        '
        Me.btnQuitarGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGestion.Location = New System.Drawing.Point(702, 27)
        Me.btnQuitarGestion.Name = "btnQuitarGestion"
        Me.btnQuitarGestion.Size = New System.Drawing.Size(102, 22)
        Me.btnQuitarGestion.TabIndex = 10
        Me.btnQuitarGestion.Text = "Quitar"
        '
        'btnAgregarGestion
        '
        Me.btnAgregarGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGestion.Location = New System.Drawing.Point(702, 3)
        Me.btnAgregarGestion.Name = "btnAgregarGestion"
        Me.btnAgregarGestion.Size = New System.Drawing.Size(102, 22)
        Me.btnAgregarGestion.TabIndex = 9
        Me.btnAgregarGestion.Text = "Agregar"
        '
        'GridGestiones
        '
        Me.GridGestiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGestiones.ColumnasAdicionales = ""
        Me.GridGestiones.Location = New System.Drawing.Point(3, 3)
        Me.GridGestiones.MainView = Me.VistaGestiones
        Me.GridGestiones.Name = "GridGestiones"
        Me.GridGestiones.NombreTabla = "Gestiones"
        Me.GridGestiones.Size = New System.Drawing.Size(693, 214)
        Me.GridGestiones.TabIndex = 1
        Me.GridGestiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaGestiones})
        '
        'VistaGestiones
        '
        Me.VistaGestiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGesIdPoliza, Me.colGesIdProducto, Me.colGesTipoGestion, Me.colGesIdGestion, Me.colGesFechaGestion, Me.colGesComentarios, Me.colGesIdUsuario, Me.colGesFechaProximaGestion})
        Me.VistaGestiones.GridControl = Me.GridGestiones
        Me.VistaGestiones.Name = "VistaGestiones"
        Me.VistaGestiones.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaGestiones.OptionsView.ShowGroupPanel = False
        '
        'colGesIdPoliza
        '
        Me.colGesIdPoliza.Caption = "Póliza"
        Me.colGesIdPoliza.FieldName = "IdPoliza"
        Me.colGesIdPoliza.Name = "colGesIdPoliza"
        Me.colGesIdPoliza.OptionsColumn.AllowEdit = False
        '
        'colGesIdProducto
        '
        Me.colGesIdProducto.Caption = "Producto"
        Me.colGesIdProducto.FieldName = "IdProducto"
        Me.colGesIdProducto.Name = "colGesIdProducto"
        Me.colGesIdProducto.OptionsColumn.AllowEdit = False
        '
        'colGesTipoGestion
        '
        Me.colGesTipoGestion.Caption = "Tipo Gestión"
        Me.colGesTipoGestion.FieldName = "TipoGestion"
        Me.colGesTipoGestion.Name = "colGesTipoGestion"
        Me.colGesTipoGestion.OptionsColumn.AllowEdit = False
        '
        'colGesIdGestion
        '
        Me.colGesIdGestion.Caption = "CodGestion"
        Me.colGesIdGestion.FieldName = "IdGestion"
        Me.colGesIdGestion.Name = "colGesIdGestion"
        Me.colGesIdGestion.Visible = True
        Me.colGesIdGestion.VisibleIndex = 0
        Me.colGesIdGestion.Width = 64
        '
        'colGesFechaGestion
        '
        Me.colGesFechaGestion.Caption = "Fecha Gestión"
        Me.colGesFechaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colGesFechaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGesFechaGestion.FieldName = "FechaGestion"
        Me.colGesFechaGestion.Name = "colGesFechaGestion"
        Me.colGesFechaGestion.Visible = True
        Me.colGesFechaGestion.VisibleIndex = 1
        Me.colGesFechaGestion.Width = 81
        '
        'colGesComentarios
        '
        Me.colGesComentarios.Caption = "Comentarios"
        Me.colGesComentarios.FieldName = "Comentarios"
        Me.colGesComentarios.Name = "colGesComentarios"
        Me.colGesComentarios.Visible = True
        Me.colGesComentarios.VisibleIndex = 3
        Me.colGesComentarios.Width = 352
        '
        'colGesIdUsuario
        '
        Me.colGesIdUsuario.Caption = "Usuario"
        Me.colGesIdUsuario.FieldName = "IdUsuario"
        Me.colGesIdUsuario.Name = "colGesIdUsuario"
        Me.colGesIdUsuario.OptionsColumn.AllowEdit = False
        '
        'colGesFechaProximaGestion
        '
        Me.colGesFechaProximaGestion.Caption = "Próxima Gestión"
        Me.colGesFechaProximaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colGesFechaProximaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGesFechaProximaGestion.FieldName = "FechaProximaGestion"
        Me.colGesFechaProximaGestion.Name = "colGesFechaProximaGestion"
        Me.colGesFechaProximaGestion.Visible = True
        Me.colGesFechaProximaGestion.VisibleIndex = 2
        Me.colGesFechaProximaGestion.Width = 90
        '
        'txtPorceComision
        '
        Me.txtPorceComision.CampoBusqueda = False
        Me.txtPorceComision.CampoEsLlave = False
        Me.txtPorceComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceComision.ControlBackColor = System.Drawing.Color.White
        Me.txtPorceComision.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceComision.FechaActual = False
        Me.txtPorceComision.Formato = "#0.0000"
        Me.txtPorceComision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceComision.LabelText = "% Comisión"
        Me.txtPorceComision.LabelWidth = 75
        Me.txtPorceComision.Location = New System.Drawing.Point(542, 124)
        Me.txtPorceComision.MaxLength = 50
        Me.txtPorceComision.Name = "txtPorceComision"
        Me.txtPorceComision.NombreCampo = "PorceComision"
        Me.txtPorceComision.Obligatorio = False
        Me.txtPorceComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceComision.Size = New System.Drawing.Size(255, 20)
        Me.txtPorceComision.SoloLectura = False
        Me.txtPorceComision.TabIndex = 4
        Me.txtPorceComision.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceComision.Valor = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(470, 597)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(98, 36)
        Me.btnImprimir.TabIndex = 18
        Me.btnImprimir.Text = "&Imprimir Oferta"
        '
        'txtObservacionesRenovacion
        '
        Me.txtObservacionesRenovacion.CampoBusqueda = False
        Me.txtObservacionesRenovacion.CampoEsLlave = False
        Me.txtObservacionesRenovacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservacionesRenovacion.ControlBackColor = System.Drawing.Color.White
        Me.txtObservacionesRenovacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservacionesRenovacion.FechaActual = False
        Me.txtObservacionesRenovacion.Formato = ""
        Me.txtObservacionesRenovacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtObservacionesRenovacion.LabelText = "Observaciones"
        Me.txtObservacionesRenovacion.LabelWidth = 100
        Me.txtObservacionesRenovacion.Location = New System.Drawing.Point(12, 244)
        Me.txtObservacionesRenovacion.MaxLength = 250
        Me.txtObservacionesRenovacion.Name = "txtObservacionesRenovacion"
        Me.txtObservacionesRenovacion.NombreCampo = "ObservacionesRenovacion"
        Me.txtObservacionesRenovacion.Obligatorio = False
        Me.txtObservacionesRenovacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacionesRenovacion.Size = New System.Drawing.Size(785, 20)
        Me.txtObservacionesRenovacion.SoloLectura = False
        Me.txtObservacionesRenovacion.TabIndex = 12
        Me.txtObservacionesRenovacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtObservacionesRenovacion.Valor = ""
        '
        'txtFechaSolicitudRenovacion
        '
        Me.txtFechaSolicitudRenovacion.CampoBusqueda = True
        Me.txtFechaSolicitudRenovacion.CampoEsLlave = False
        Me.txtFechaSolicitudRenovacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaSolicitudRenovacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaSolicitudRenovacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaSolicitudRenovacion.FechaActual = False
        Me.txtFechaSolicitudRenovacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaSolicitudRenovacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaSolicitudRenovacion.LabelText = "Sol. Renovación"
        Me.txtFechaSolicitudRenovacion.LabelWidth = 100
        Me.txtFechaSolicitudRenovacion.Location = New System.Drawing.Point(0, 466)
        Me.txtFechaSolicitudRenovacion.MaxLength = 0
        Me.txtFechaSolicitudRenovacion.Name = "txtFechaSolicitudRenovacion"
        Me.txtFechaSolicitudRenovacion.NombreCampo = "FechaSolicitudRenovacion"
        Me.txtFechaSolicitudRenovacion.Obligatorio = False
        Me.txtFechaSolicitudRenovacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaSolicitudRenovacion.Size = New System.Drawing.Size(110, 20)
        Me.txtFechaSolicitudRenovacion.SoloLectura = False
        Me.txtFechaSolicitudRenovacion.TabIndex = 12
        Me.txtFechaSolicitudRenovacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaSolicitudRenovacion.Valor = Nothing
        Me.txtFechaSolicitudRenovacion.Visible = False
        '
        'txtNumVigencia
        '
        Me.txtNumVigencia.CampoBusqueda = False
        Me.txtNumVigencia.CampoEsLlave = False
        Me.txtNumVigencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumVigencia.ControlBackColor = System.Drawing.Color.White
        Me.txtNumVigencia.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumVigencia.FechaActual = False
        Me.txtNumVigencia.Formato = "#0"
        Me.txtNumVigencia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumVigencia.LabelText = "Núm. Vigencia"
        Me.txtNumVigencia.LabelWidth = 85
        Me.txtNumVigencia.Location = New System.Drawing.Point(0, 463)
        Me.txtNumVigencia.MaxLength = 50
        Me.txtNumVigencia.Name = "txtNumVigencia"
        Me.txtNumVigencia.NombreCampo = "NumVigencia"
        Me.txtNumVigencia.Obligatorio = False
        Me.txtNumVigencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumVigencia.Size = New System.Drawing.Size(95, 20)
        Me.txtNumVigencia.SoloLectura = False
        Me.txtNumVigencia.TabIndex = 21
        Me.txtNumVigencia.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumVigencia.Valor = 0
        Me.txtNumVigencia.Visible = False
        '
        'txtFechaVinculacion
        '
        Me.txtFechaVinculacion.CampoBusqueda = True
        Me.txtFechaVinculacion.CampoEsLlave = False
        Me.txtFechaVinculacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaVinculacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaVinculacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaVinculacion.FechaActual = True
        Me.txtFechaVinculacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaVinculacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaVinculacion.LabelText = "Fecha Vinculación"
        Me.txtFechaVinculacion.LabelWidth = 100
        Me.txtFechaVinculacion.Location = New System.Drawing.Point(13, 268)
        Me.txtFechaVinculacion.MaxLength = 0
        Me.txtFechaVinculacion.Name = "txtFechaVinculacion"
        Me.txtFechaVinculacion.NombreCampo = "FechaVinculacion"
        Me.txtFechaVinculacion.Obligatorio = False
        Me.txtFechaVinculacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaVinculacion.Size = New System.Drawing.Size(397, 20)
        Me.txtFechaVinculacion.SoloLectura = False
        Me.txtFechaVinculacion.TabIndex = 27
        Me.txtFechaVinculacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaVinculacion.Valor = Nothing
        '
        'btnAceptarOferta
        '
        Me.btnAceptarOferta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptarOferta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAceptarOferta.Appearance.Options.UseFont = True
        Me.btnAceptarOferta.Appearance.Options.UseTextOptions = True
        Me.btnAceptarOferta.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnAceptarOferta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAceptarOferta.Image = CType(resources.GetObject("btnAceptarOferta.Image"), System.Drawing.Image)
        Me.btnAceptarOferta.Location = New System.Drawing.Point(369, 597)
        Me.btnAceptarOferta.Name = "btnAceptarOferta"
        Me.btnAceptarOferta.Size = New System.Drawing.Size(100, 36)
        Me.btnAceptarOferta.TabIndex = 17
        Me.btnAceptarOferta.Text = "Ace&ptar Oferta"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.CampoAutoCompletar = 0
        Me.cboDepartamento.CampoBusqueda = False
        Me.cboDepartamento.CampoDisplay = 1
        Me.cboDepartamento.CampoEsLlave = False
        Me.cboDepartamento.CampoValor = 0
        Me.cboDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDepartamento.ControlBackColor = System.Drawing.Color.White
        Me.cboDepartamento.ControlForeColor = System.Drawing.Color.Black
        Me.cboDepartamento.FilasVisibles = 1979
        Me.cboDepartamento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDepartamento.LabelText = "Departamento"
        Me.cboDepartamento.LabelWidth = 120
        Me.cboDepartamento.Lista = ""
        Me.cboDepartamento.Location = New System.Drawing.Point(415, 268)
        Me.cboDepartamento.MostrarBusquedaColumnas = False
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.NombreCampo = "Departamento"
        Me.cboDepartamento.Obligatorio = False
        Me.cboDepartamento.Query = "select distinct Departamento as Id, Departamento from usuarios"
        Me.cboDepartamento.SelectIndex = 0
        Me.cboDepartamento.Size = New System.Drawing.Size(383, 20)
        Me.cboDepartamento.SoloLectura = False
        Me.cboDepartamento.StringConection = ""
        Me.cboDepartamento.TabIndex = 29
        Me.cboDepartamento.TextoNuevoItem = ""
        Me.cboDepartamento.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboDepartamento.Valor = ""
        '
        'txtFechaGrabacion
        '
        Me.txtFechaGrabacion.CampoBusqueda = True
        Me.txtFechaGrabacion.CampoEsLlave = False
        Me.txtFechaGrabacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaGrabacion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaGrabacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaGrabacion.FechaActual = True
        Me.txtFechaGrabacion.Formato = "dd/MM/yyyy hh:mm:ss"
        Me.txtFechaGrabacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaGrabacion.LabelText = "Fecha Graba"
        Me.txtFechaGrabacion.LabelWidth = 75
        Me.txtFechaGrabacion.Location = New System.Drawing.Point(764, 317)
        Me.txtFechaGrabacion.MaxLength = 0
        Me.txtFechaGrabacion.Name = "txtFechaGrabacion"
        Me.txtFechaGrabacion.NombreCampo = "FechaGrabacion"
        Me.txtFechaGrabacion.Obligatorio = False
        Me.txtFechaGrabacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaGrabacion.Size = New System.Drawing.Size(115, 20)
        Me.txtFechaGrabacion.SoloLectura = True
        Me.txtFechaGrabacion.TabIndex = 30
        Me.txtFechaGrabacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaGrabacion.Valor = Nothing
        Me.txtFechaGrabacion.Visible = False
        '
        'txtFechaCambioEstado
        '
        Me.txtFechaCambioEstado.CampoBusqueda = True
        Me.txtFechaCambioEstado.CampoEsLlave = False
        Me.txtFechaCambioEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCambioEstado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaCambioEstado.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCambioEstado.FechaActual = True
        Me.txtFechaCambioEstado.Formato = "dd/MM/yyyy hh:mm:ss"
        Me.txtFechaCambioEstado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCambioEstado.LabelText = "Fecha Cambio Estado"
        Me.txtFechaCambioEstado.LabelWidth = 75
        Me.txtFechaCambioEstado.Location = New System.Drawing.Point(764, 291)
        Me.txtFechaCambioEstado.MaxLength = 0
        Me.txtFechaCambioEstado.Name = "txtFechaCambioEstado"
        Me.txtFechaCambioEstado.NombreCampo = "FechaCambioEstado"
        Me.txtFechaCambioEstado.Obligatorio = False
        Me.txtFechaCambioEstado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCambioEstado.Size = New System.Drawing.Size(115, 20)
        Me.txtFechaCambioEstado.SoloLectura = True
        Me.txtFechaCambioEstado.TabIndex = 31
        Me.txtFechaCambioEstado.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCambioEstado.Valor = Nothing
        Me.txtFechaCambioEstado.Visible = False
        '
        'txtFechaAceptada
        '
        Me.txtFechaAceptada.CampoBusqueda = False
        Me.txtFechaAceptada.CampoEsLlave = False
        Me.txtFechaAceptada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAceptada.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAceptada.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAceptada.FechaActual = False
        Me.txtFechaAceptada.Formato = "dd/MMM/yyyy"
        Me.txtFechaAceptada.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAceptada.LabelText = "Fecha de Aceptación"
        Me.txtFechaAceptada.LabelWidth = 120
        Me.txtFechaAceptada.Location = New System.Drawing.Point(415, 221)
        Me.txtFechaAceptada.MaxLength = 0
        Me.txtFechaAceptada.Name = "txtFechaAceptada"
        Me.txtFechaAceptada.NombreCampo = "FechaAceptada"
        Me.txtFechaAceptada.Obligatorio = False
        Me.txtFechaAceptada.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAceptada.Size = New System.Drawing.Size(383, 20)
        Me.txtFechaAceptada.SoloLectura = False
        Me.txtFechaAceptada.TabIndex = 11
        Me.txtFechaAceptada.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAceptada.Valor = Nothing
        '
        'cboTipoDeducible
        '
        Me.cboTipoDeducible.CampoAutoCompletar = 0
        Me.cboTipoDeducible.CampoBusqueda = False
        Me.cboTipoDeducible.CampoDisplay = 1
        Me.cboTipoDeducible.CampoEsLlave = False
        Me.cboTipoDeducible.CampoValor = 0
        Me.cboTipoDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoDeducible.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoDeducible.FilasVisibles = 1979
        Me.cboTipoDeducible.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoDeducible.LabelText = "Tipo Deducible"
        Me.cboTipoDeducible.LabelWidth = 100
        Me.cboTipoDeducible.Lista = "V Deducible por Vigencia|A Deducible Año Calendario"
        Me.cboTipoDeducible.Location = New System.Drawing.Point(12, 291)
        Me.cboTipoDeducible.MostrarBusquedaColumnas = False
        Me.cboTipoDeducible.Name = "cboTipoDeducible"
        Me.cboTipoDeducible.NombreCampo = "TipoDeducible"
        Me.cboTipoDeducible.Obligatorio = False
        Me.cboTipoDeducible.Query = ""
        Me.cboTipoDeducible.SelectIndex = 0
        Me.cboTipoDeducible.Size = New System.Drawing.Size(398, 20)
        Me.cboTipoDeducible.SoloLectura = False
        Me.cboTipoDeducible.StringConection = ""
        Me.cboTipoDeducible.TabIndex = 32
        Me.cboTipoDeducible.TextoNuevoItem = ""
        Me.cboTipoDeducible.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoDeducible.Valor = ""
        '
        'cboEjecutivoCta
        '
        Me.cboEjecutivoCta.CampoAutoCompletar = 0
        Me.cboEjecutivoCta.CampoBusqueda = False
        Me.cboEjecutivoCta.CampoDisplay = 1
        Me.cboEjecutivoCta.CampoEsLlave = False
        Me.cboEjecutivoCta.CampoValor = 0
        Me.cboEjecutivoCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjecutivoCta.ControlBackColor = System.Drawing.Color.White
        Me.cboEjecutivoCta.ControlForeColor = System.Drawing.Color.Black
        Me.cboEjecutivoCta.FilasVisibles = 1979
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Solicita"
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(415, 291)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(383, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 33
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'cboNegocioPor
        '
        Me.cboNegocioPor.CampoAutoCompletar = 0
        Me.cboNegocioPor.CampoBusqueda = False
        Me.cboNegocioPor.CampoDisplay = 1
        Me.cboNegocioPor.CampoEsLlave = False
        Me.cboNegocioPor.CampoValor = 0
        Me.cboNegocioPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNegocioPor.ControlBackColor = System.Drawing.Color.White
        Me.cboNegocioPor.ControlForeColor = System.Drawing.Color.Black
        Me.cboNegocioPor.FilasVisibles = 5066
        Me.cboNegocioPor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboNegocioPor.LabelText = "Negocio Hecho Por"
        Me.cboNegocioPor.LabelWidth = 100
        Me.cboNegocioPor.Lista = ""
        Me.cboNegocioPor.Location = New System.Drawing.Point(12, 314)
        Me.cboNegocioPor.MostrarBusquedaColumnas = False
        Me.cboNegocioPor.Name = "cboNegocioPor"
        Me.cboNegocioPor.NombreCampo = "NegocioPor"
        Me.cboNegocioPor.Obligatorio = False
        Me.cboNegocioPor.Query = "select idVendedor as Id, NombreVendedor as Vendedor from vendedores"
        Me.cboNegocioPor.SelectIndex = 0
        Me.cboNegocioPor.Size = New System.Drawing.Size(398, 20)
        Me.cboNegocioPor.SoloLectura = False
        Me.cboNegocioPor.StringConection = ""
        Me.cboNegocioPor.TabIndex = 34
        Me.cboNegocioPor.TextoNuevoItem = ""
        Me.cboNegocioPor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNegocioPor.Valor = ""
        '
        'CPolizasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 530
        Me.ClientSize = New System.Drawing.Size(826, 633)
        Me.Controls.Add(Me.cboNegocioPor)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.cboTipoDeducible)
        Me.Controls.Add(Me.txtFechaAceptada)
        Me.Controls.Add(Me.txtObservacionesRenovacion)
        Me.Controls.Add(Me.txtFechaCambioEstado)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.txtFechaGrabacion)
        Me.Controls.Add(Me.btnAceptarOferta)
        Me.Controls.Add(Me.txtFechaVinculacion)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtPorceComision)
        Me.Controls.Add(Me.TabPoliza)
        Me.Controls.Add(Me.cboVendedor)
        Me.Controls.Add(Me.txtFechaCancelacion)
        Me.Controls.Add(Me.txtMotivoCancelacion)
        Me.Controls.Add(Me.cboEstadoPoliza)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtFechaSolicitudRenovacion)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNumVigencia)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "CPolizasMan"
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Ofertas"
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNumVigencia, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtFechaSolicitudRenovacion, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoCancelacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCancelacion, 0)
        Me.Controls.SetChildIndex(Me.cboVendedor, 0)
        Me.Controls.SetChildIndex(Me.TabPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtPorceComision, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaVinculacion, 0)
        Me.Controls.SetChildIndex(Me.btnAceptarOferta, 0)
        Me.Controls.SetChildIndex(Me.txtFechaGrabacion, 0)
        Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCambioEstado, 0)
        Me.Controls.SetChildIndex(Me.txtObservacionesRenovacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAceptada, 0)
        Me.Controls.SetChildIndex(Me.cboTipoDeducible, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.cboNegocioPor, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPoliza.ResumeLayout(False)
        Me.pagCertificados.ResumeLayout(False)
        CType(Me.GridCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagClausulas.ResumeLayout(False)
        CType(Me.GridClausulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaClausulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDocumentos.ResumeLayout(False)
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pag21200000.ResumeLayout(False)
        Me.pagGestion.ResumeLayout(False)
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents cboEstadoPoliza As STIControles.stiComboBox
    Friend WithEvents txtMotivoCancelacion As STIControles.stiTextBox
    Friend WithEvents txtFechaCancelacion As STIControles.stiTextBox
    Friend WithEvents cboVendedor As STIControles.stiComboBox
    Friend WithEvents TabPoliza As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pagCertificados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCertificados As STIControles.stiGrid
    Friend WithEvents VistaCertificados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pagDocumentos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridDoc As STIControles.stiGrid
    Friend WithEvents VistaDoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pagClausulas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAgregarCert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGastos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAsegurado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarClausula As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridClausulas As STIControles.stiGrid
    Friend WithEvents VistaClausulas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colClaIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaIdClausula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colclaClausula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarClausula As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPorceComision As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarCarpeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public WithEvents btnImprimirCertificados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtObservacionesRenovacion As STIControles.stiTextBox
    Friend WithEvents txtFechaSolicitudRenovacion As STIControles.stiTextBox
    Friend WithEvents ColArchivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumVigencia As STIControles.stiTextBox
    Friend WithEvents txtFechaVinculacion As STIControles.stiTextBox
    Public WithEvents btnAceptarOferta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboDepartamento As STIControles.stiComboBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pag21200000 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtResumenPrimaAnual As STIControles.stiTextBox
    Friend WithEvents txtResumenSumaAsegurada As STIControles.stiTextBox
    Friend WithEvents cboResumenFormaPago As STIControles.stiComboBox
    Friend WithEvents txtResumenNumeroCuotas As STIControles.stiTextBox
    Friend WithEvents txtResumenSeguimiento As STIControles.stiMemo
    Friend WithEvents txtResumenFechaEnvio As STIControles.stiTextBox
    Friend WithEvents colClaCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaGrabacion As STIControles.stiTextBox
    Friend WithEvents txtFechaCambioEstado As STIControles.stiTextBox
    Friend WithEvents txtFechaAceptada As STIControles.stiTextBox
    Friend WithEvents cboTipoDeducible As STIControles.stiComboBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents cboResumenFormaEnvio As STIControles.stiComboBox
    Friend WithEvents txtResumenNumeroCartaEnvio As STIControles.stiTextBox
    Friend WithEvents txtResumenPrimaIva As STIControles.stiTextBox
    Friend WithEvents cboNegocioPor As STIControles.stiComboBox
    Friend WithEvents txtResumenFechaSolicita As STIControles.stiTextBox
    Friend WithEvents txtResumenPlan As STIControles.stiTextBox
    Friend WithEvents pagGestion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridGestiones As STIControles.stiGrid
    Friend WithEvents VistaGestiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGesIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesTipoGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesFechaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesFechaProximaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGestionOutlook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarGestion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGestion As DevExpress.XtraEditors.SimpleButton

End Class
