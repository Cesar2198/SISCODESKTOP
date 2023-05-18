<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolizasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolizasMan))
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
        Me.TabPoliza = New DevExpress.XtraTab.XtraTabControl
        Me.pagCertificados = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirAutosExcluidos = New DevExpress.XtraEditors.SimpleButton
        Me.btnImpresionDanos = New DevExpress.XtraEditors.SimpleButton
        Me.btnResumenCertificados = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimirAutos = New DevExpress.XtraEditors.SimpleButton
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
        Me.ColCertAseg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.colclaCategoria = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colClaCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaDeducible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaParticipacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagVendedores = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarVendedor = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarVendedor = New DevExpress.XtraEditors.SimpleButton
        Me.gridVendedores = New STIControles.stiGrid
        Me.VistaVendedores = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colVenIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVenIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.ColDirectorio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagOpcPago = New DevExpress.XtraTab.XtraTabPage
        Me.txtNombreCuentaHabiente = New STIControles.stiTextBox
        Me.cboIdBanco = New STIControles.stiComboBox
        Me.cboIdTipoPago = New STIControles.stiComboBox
        Me.txtEnvioFactura = New STIControles.stiTextBox
        Me.txtCuentaBancaria = New STIControles.stiTextBox
        Me.txtEmisorTarjeta = New STIControles.stiTextBox
        Me.txtVencimientoTarjeta = New STIControles.stiTextBox
        Me.txtTarjetaHabiente = New STIControles.stiTextBox
        Me.txtNumeroTarjeta = New STIControles.stiTextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtPorceComision = New STIControles.stiTextBox
        Me.txtNumVigencia = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtObservacionesRenovacion = New STIControles.stiTextBox
        Me.txtFechaSolicitudRenovacion = New STIControles.stiTextBox
        Me.cboOrigen = New STIControles.stiComboBox
        Me.txtFechaVinculacion = New STIControles.stiTextBox
        Me.cboDepartamento = New STIControles.stiComboBox
        Me.cboIdCancelacion = New STIControles.stiComboBox
        Me.txtFechaEnvioAnexo = New STIControles.stiTextBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.txtDiasCob = New STIControles.stiTextBox
        Me.txtIdPolizaSustituida = New STIControles.stiTextBox
        Me.txtObservacionSiniestro = New STIControles.stiTextBox
        Me.txtGrupoCliente = New STIControles.stiTextBox
        Me.cboTipoDeducible = New STIControles.stiComboBox
        Me.cboNegocioPor = New STIControles.stiComboBox
        Me.cboTipoPoliza = New STIControles.stiComboBox
        Me.cboFormaPago = New STIControles.stiComboBox
        Me.txtIdOferta = New STIControles.stiTextBox
        Me.txtFechaRecepcion = New STIControles.stiTextBox
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
        Me.pagVendedores.SuspendLayout()
        CType(Me.gridVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDocumentos.SuspendLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagOpcPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(500, 622)
        Me.btnAyuda.TabIndex = 30
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(407, 622)
        Me.btnBuscar.TabIndex = 29
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(25, 622)
        Me.btnNuevo.TabIndex = 26
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(117, 622)
        Me.btnGuardar.TabIndex = 25
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(592, 622)
        Me.btnSalir.TabIndex = 31
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(50, 616)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.TabIndex = 25
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(547, 23)
        Me.lblNombreFormulario.TabIndex = 25
        Me.lblNombreFormulario.Text = "Pólizas de Seguro"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(210, 622)
        Me.btnGuardarComo.TabIndex = 27
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
        Me.txtIdPoliza.LabelText = "Número Póliza"
        Me.txtIdPoliza.LabelWidth = 100
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 78)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(300, 20)
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
        Me.cboIdProducto.FilasVisibles = 33203
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 100)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(662, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 2
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(319, 120)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 4
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
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 145)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(606, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 6
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
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 122)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 3
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
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(12, 168)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(300, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 7
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
        Me.txtVigenciaHasta.LabelWidth = 110
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(319, 168)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(300, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 8
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
        Me.cboEstadoPoliza.FilasVisibles = 33203
        Me.cboEstadoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoPoliza.LabelText = "Estado Póliza"
        Me.cboEstadoPoliza.LabelWidth = 110
        Me.cboEstadoPoliza.Lista = "VIGENTE Póliza Vigente|CANCELADA Póliza Cancelada"
        Me.cboEstadoPoliza.Location = New System.Drawing.Point(319, 78)
        Me.cboEstadoPoliza.MostrarBusquedaColumnas = False
        Me.cboEstadoPoliza.Name = "cboEstadoPoliza"
        Me.cboEstadoPoliza.NombreCampo = "EstadoPoliza"
        Me.cboEstadoPoliza.Obligatorio = False
        Me.cboEstadoPoliza.Query = ""
        Me.cboEstadoPoliza.SelectIndex = 0
        Me.cboEstadoPoliza.Size = New System.Drawing.Size(355, 20)
        Me.cboEstadoPoliza.SoloLectura = False
        Me.cboEstadoPoliza.StringConection = ""
        Me.cboEstadoPoliza.TabIndex = 1
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
        Me.txtMotivoCancelacion.LabelText = "Motivo Cancelación"
        Me.txtMotivoCancelacion.LabelWidth = 100
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(12, 191)
        Me.txtMotivoCancelacion.MaxLength = 250
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.NombreCampo = "MotivoCancelacion"
        Me.txtMotivoCancelacion.Obligatorio = False
        Me.txtMotivoCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(300, 20)
        Me.txtMotivoCancelacion.SoloLectura = False
        Me.txtMotivoCancelacion.TabIndex = 9
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
        Me.txtFechaCancelacion.LabelText = "Fecha Cancelación"
        Me.txtFechaCancelacion.LabelWidth = 110
        Me.txtFechaCancelacion.Location = New System.Drawing.Point(319, 191)
        Me.txtFechaCancelacion.MaxLength = 0
        Me.txtFechaCancelacion.Name = "txtFechaCancelacion"
        Me.txtFechaCancelacion.NombreCampo = "FechaCancelacion"
        Me.txtFechaCancelacion.Obligatorio = False
        Me.txtFechaCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCancelacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaCancelacion.SoloLectura = False
        Me.txtFechaCancelacion.TabIndex = 10
        Me.txtFechaCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCancelacion.Valor = Nothing
        '
        'TabPoliza
        '
        Me.TabPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPoliza.Location = New System.Drawing.Point(7, 374)
        Me.TabPoliza.Name = "TabPoliza"
        Me.TabPoliza.SelectedTabPage = Me.pagCertificados
        Me.TabPoliza.Size = New System.Drawing.Size(676, 242)
        Me.TabPoliza.TabIndex = 29
        Me.TabPoliza.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pagCertificados, Me.pagClausulas, Me.pagVendedores, Me.pagDocumentos, Me.pagOpcPago})
        '
        'pagCertificados
        '
        Me.pagCertificados.Controls.Add(Me.btnImprimirAutosExcluidos)
        Me.pagCertificados.Controls.Add(Me.btnImpresionDanos)
        Me.pagCertificados.Controls.Add(Me.btnResumenCertificados)
        Me.pagCertificados.Controls.Add(Me.btnImprimirAutos)
        Me.pagCertificados.Controls.Add(Me.btnImprimirCertificados)
        Me.pagCertificados.Controls.Add(Me.btnAgregarCert)
        Me.pagCertificados.Controls.Add(Me.GridCertificados)
        Me.pagCertificados.Name = "pagCertificados"
        Me.pagCertificados.Size = New System.Drawing.Size(667, 211)
        Me.pagCertificados.Text = "Certificados"
        '
        'btnImprimirAutosExcluidos
        '
        Me.btnImprimirAutosExcluidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirAutosExcluidos.Appearance.Options.UseTextOptions = True
        Me.btnImprimirAutosExcluidos.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImprimirAutosExcluidos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimirAutosExcluidos.Image = CType(resources.GetObject("btnImprimirAutosExcluidos.Image"), System.Drawing.Image)
        Me.btnImprimirAutosExcluidos.Location = New System.Drawing.Point(558, 176)
        Me.btnImprimirAutosExcluidos.Name = "btnImprimirAutosExcluidos"
        Me.btnImprimirAutosExcluidos.Size = New System.Drawing.Size(108, 34)
        Me.btnImprimirAutosExcluidos.TabIndex = 27
        Me.btnImprimirAutosExcluidos.Text = "Imp. Autos Excluídos"
        Me.btnImprimirAutosExcluidos.Visible = False
        '
        'btnImpresionDanos
        '
        Me.btnImpresionDanos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImpresionDanos.Appearance.Options.UseTextOptions = True
        Me.btnImpresionDanos.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImpresionDanos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImpresionDanos.Image = CType(resources.GetObject("btnImpresionDanos.Image"), System.Drawing.Image)
        Me.btnImpresionDanos.Location = New System.Drawing.Point(558, 107)
        Me.btnImpresionDanos.Name = "btnImpresionDanos"
        Me.btnImpresionDanos.Size = New System.Drawing.Size(108, 34)
        Me.btnImpresionDanos.TabIndex = 26
        Me.btnImpresionDanos.Text = "Imprimir Póliza Daños"
        '
        'btnResumenCertificados
        '
        Me.btnResumenCertificados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResumenCertificados.Appearance.Options.UseTextOptions = True
        Me.btnResumenCertificados.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnResumenCertificados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnResumenCertificados.Image = CType(resources.GetObject("btnResumenCertificados.Image"), System.Drawing.Image)
        Me.btnResumenCertificados.Location = New System.Drawing.Point(558, 73)
        Me.btnResumenCertificados.Name = "btnResumenCertificados"
        Me.btnResumenCertificados.Size = New System.Drawing.Size(108, 34)
        Me.btnResumenCertificados.TabIndex = 25
        Me.btnResumenCertificados.Text = "Resumen Certificados"
        '
        'btnImprimirAutos
        '
        Me.btnImprimirAutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirAutos.Appearance.Options.UseTextOptions = True
        Me.btnImprimirAutos.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImprimirAutos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimirAutos.Image = CType(resources.GetObject("btnImprimirAutos.Image"), System.Drawing.Image)
        Me.btnImprimirAutos.Location = New System.Drawing.Point(558, 142)
        Me.btnImprimirAutos.Name = "btnImprimirAutos"
        Me.btnImprimirAutos.Size = New System.Drawing.Size(108, 34)
        Me.btnImprimirAutos.TabIndex = 24
        Me.btnImprimirAutos.Text = "Imp. Autos e Inclusiones"
        Me.btnImprimirAutos.Visible = False
        '
        'btnImprimirCertificados
        '
        Me.btnImprimirCertificados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirCertificados.Appearance.Options.UseTextOptions = True
        Me.btnImprimirCertificados.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnImprimirCertificados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimirCertificados.Image = CType(resources.GetObject("btnImprimirCertificados.Image"), System.Drawing.Image)
        Me.btnImprimirCertificados.Location = New System.Drawing.Point(558, 38)
        Me.btnImprimirCertificados.Name = "btnImprimirCertificados"
        Me.btnImprimirCertificados.Size = New System.Drawing.Size(108, 34)
        Me.btnImprimirCertificados.TabIndex = 23
        Me.btnImprimirCertificados.Text = "Detalle Certificados"
        '
        'btnAgregarCert
        '
        Me.btnAgregarCert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCert.Appearance.Options.UseTextOptions = True
        Me.btnAgregarCert.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregarCert.Image = CType(resources.GetObject("btnAgregarCert.Image"), System.Drawing.Image)
        Me.btnAgregarCert.Location = New System.Drawing.Point(558, 3)
        Me.btnAgregarCert.Name = "btnAgregarCert"
        Me.btnAgregarCert.Size = New System.Drawing.Size(108, 34)
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
        Me.GridCertificados.Size = New System.Drawing.Size(552, 203)
        Me.GridCertificados.TabIndex = 20
        Me.GridCertificados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCertificados, Me.GridView2})
        '
        'VistaCertificados
        '
        Me.VistaCertificados.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VistaCertificados.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.VistaCertificados.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.VistaCertificados.Appearance.GroupRow.Options.UseBackColor = True
        Me.VistaCertificados.Appearance.GroupRow.Options.UseFont = True
        Me.VistaCertificados.Appearance.GroupRow.Options.UseForeColor = True
        Me.VistaCertificados.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaCertificados.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaCertificados.ColumnPanelRowHeight = 35
        Me.VistaCertificados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCertificado, Me.colNombreCliente, Me.colVigenciaDesde, Me.colVigenciaHasta, Me.colPrima, Me.colGastos, Me.colIva, Me.colTotal, Me.colEstado, Me.colValorAsegurado, Me.ColCertAseg, Me.colPlaca})
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
        'ColCertAseg
        '
        Me.ColCertAseg.Caption = "Cert. Aseg."
        Me.ColCertAseg.FieldName = "IdCertificadoAseguradora"
        Me.ColCertAseg.Name = "ColCertAseg"
        '
        'colPlaca
        '
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
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
        Me.pagClausulas.Size = New System.Drawing.Size(667, 211)
        Me.pagClausulas.Text = "Condiciones Especiales de la Póliza"
        '
        'btnQuitarClausula
        '
        Me.btnQuitarClausula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarClausula.Location = New System.Drawing.Point(562, 40)
        Me.btnQuitarClausula.Name = "btnQuitarClausula"
        Me.btnQuitarClausula.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarClausula.TabIndex = 24
        Me.btnQuitarClausula.Text = "Quitar"
        '
        'btnAgregarClausula
        '
        Me.btnAgregarClausula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarClausula.Location = New System.Drawing.Point(562, 3)
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
        Me.GridClausulas.NombreTabla = "PolizasClausulas"
        Me.GridClausulas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemLookUpEdit1})
        Me.GridClausulas.Size = New System.Drawing.Size(553, 180)
        Me.GridClausulas.TabIndex = 0
        Me.GridClausulas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaClausulas})
        '
        'VistaClausulas
        '
        Me.VistaClausulas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaClausulas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaClausulas.ColumnPanelRowHeight = 35
        Me.VistaClausulas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClaIdPoliza, Me.colClaIdProducto, Me.colClaIdClausula, Me.colclaClausula, Me.colclaCategoria, Me.colClaCodigoInterno, Me.colClaSuma, Me.colClaDeducible, Me.colClaParticipacion})
        Me.VistaClausulas.GridControl = Me.GridClausulas
        Me.VistaClausulas.Name = "VistaClausulas"
        Me.VistaClausulas.OptionsCustomization.AllowRowSizing = True
        Me.VistaClausulas.OptionsView.ShowGroupPanel = False
        Me.VistaClausulas.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colClaIdClausula, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colClaIdPoliza
        '
        Me.colClaIdPoliza.Caption = "Poliza"
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
        Me.colClaIdClausula.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
        Me.colClaIdClausula.Visible = True
        Me.colClaIdClausula.VisibleIndex = 0
        Me.colClaIdClausula.Width = 72
        '
        'colclaClausula
        '
        Me.colclaClausula.Caption = "Descripción Condición Especial"
        Me.colclaClausula.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colclaClausula.FieldName = "Clausula"
        Me.colclaClausula.Name = "colclaClausula"
        Me.colclaClausula.Visible = True
        Me.colclaClausula.VisibleIndex = 2
        Me.colclaClausula.Width = 341
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colclaCategoria
        '
        Me.colclaCategoria.Caption = "Categoría"
        Me.colclaCategoria.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colclaCategoria.FieldName = "Categoria"
        Me.colclaCategoria.Name = "colclaCategoria"
        Me.colclaCategoria.Visible = True
        Me.colclaCategoria.VisibleIndex = 3
        Me.colclaCategoria.Width = 119
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colClaCodigoInterno
        '
        Me.colClaCodigoInterno.Caption = "Código"
        Me.colClaCodigoInterno.FieldName = "CodigoInterno"
        Me.colClaCodigoInterno.Name = "colClaCodigoInterno"
        Me.colClaCodigoInterno.Visible = True
        Me.colClaCodigoInterno.VisibleIndex = 1
        '
        'colClaSuma
        '
        Me.colClaSuma.Caption = "Suma Asegurada"
        Me.colClaSuma.DisplayFormat.FormatString = "c"
        Me.colClaSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colClaSuma.FieldName = "SumaAsegurada"
        Me.colClaSuma.Name = "colClaSuma"
        '
        'colClaDeducible
        '
        Me.colClaDeducible.Caption = "Deducible"
        Me.colClaDeducible.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colClaDeducible.FieldName = "Deducible"
        Me.colClaDeducible.Name = "colClaDeducible"
        '
        'colClaParticipacion
        '
        Me.colClaParticipacion.Caption = "Participación"
        Me.colClaParticipacion.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colClaParticipacion.FieldName = "Participacion"
        Me.colClaParticipacion.Name = "colClaParticipacion"
        '
        'pagVendedores
        '
        Me.pagVendedores.Controls.Add(Me.btnQuitarVendedor)
        Me.pagVendedores.Controls.Add(Me.btnAgregarVendedor)
        Me.pagVendedores.Controls.Add(Me.gridVendedores)
        Me.pagVendedores.Name = "pagVendedores"
        Me.pagVendedores.Size = New System.Drawing.Size(667, 211)
        Me.pagVendedores.Text = "Vendedores"
        '
        'btnQuitarVendedor
        '
        Me.btnQuitarVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarVendedor.Location = New System.Drawing.Point(562, 40)
        Me.btnQuitarVendedor.Name = "btnQuitarVendedor"
        Me.btnQuitarVendedor.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitarVendedor.TabIndex = 26
        Me.btnQuitarVendedor.Text = "Quitar"
        '
        'btnAgregarVendedor
        '
        Me.btnAgregarVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarVendedor.Location = New System.Drawing.Point(562, 3)
        Me.btnAgregarVendedor.Name = "btnAgregarVendedor"
        Me.btnAgregarVendedor.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarVendedor.TabIndex = 25
        Me.btnAgregarVendedor.Text = "Agregar"
        '
        'gridVendedores
        '
        Me.gridVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridVendedores.ColumnasAdicionales = ""
        Me.gridVendedores.Location = New System.Drawing.Point(5, 3)
        Me.gridVendedores.MainView = Me.VistaVendedores
        Me.gridVendedores.Name = "gridVendedores"
        Me.gridVendedores.NombreTabla = "PolizasVendedores"
        Me.gridVendedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.gridVendedores.Size = New System.Drawing.Size(551, 180)
        Me.gridVendedores.TabIndex = 0
        Me.gridVendedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaVendedores})
        '
        'VistaVendedores
        '
        Me.VistaVendedores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVenIdPoliza, Me.colVenIdProducto, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn2})
        Me.VistaVendedores.GridControl = Me.gridVendedores
        Me.VistaVendedores.Name = "VistaVendedores"
        Me.VistaVendedores.OptionsView.ShowGroupPanel = False
        '
        'colVenIdPoliza
        '
        Me.colVenIdPoliza.Caption = "IdPoliza"
        Me.colVenIdPoliza.FieldName = "IdPoliza"
        Me.colVenIdPoliza.Name = "colVenIdPoliza"
        '
        'colVenIdProducto
        '
        Me.colVenIdProducto.Caption = "IdProducto"
        Me.colVenIdProducto.FieldName = "IdProducto"
        Me.colVenIdProducto.Name = "colVenIdProducto"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id"
        Me.GridColumn1.FieldName = "Orden"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 49
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Vendedor"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn3.FieldName = "IdVendedor"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 246
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Tipo Comisión"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.GridColumn4.FieldName = "IdTipoVendedor"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 139
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha Efectiva"
        Me.GridColumn2.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "FechaEfectiva"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 96
        '
        'pagDocumentos
        '
        Me.pagDocumentos.Controls.Add(Me.btnAgregarCarpeta)
        Me.pagDocumentos.Controls.Add(Me.btnQuitarDoc)
        Me.pagDocumentos.Controls.Add(Me.btnAgregarDoc)
        Me.pagDocumentos.Controls.Add(Me.GridDoc)
        Me.pagDocumentos.Name = "pagDocumentos"
        Me.pagDocumentos.Size = New System.Drawing.Size(667, 211)
        Me.pagDocumentos.Text = "Documentos"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(552, 40)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarCarpeta.TabIndex = 23
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(552, 75)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDoc.TabIndex = 22
        Me.btnQuitarDoc.Text = "Quitar"
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(552, 3)
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
        Me.GridDoc.NombreTabla = "PolizasDocumentos"
        Me.GridDoc.Size = New System.Drawing.Size(536, 180)
        Me.GridDoc.TabIndex = 0
        Me.GridDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDoc})
        '
        'VistaDoc
        '
        Me.VistaDoc.Appearance.GroupButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.VistaDoc.Appearance.GroupButton.Options.UseFont = True
        Me.VistaDoc.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VistaDoc.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.VistaDoc.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.VistaDoc.Appearance.GroupRow.Options.UseBackColor = True
        Me.VistaDoc.Appearance.GroupRow.Options.UseFont = True
        Me.VistaDoc.Appearance.GroupRow.Options.UseForeColor = True
        Me.VistaDoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPoliza, Me.ColProducto, Me.ColDoc, Me.colDocumento, Me.ColArchivo, Me.ColDirectorio})
        Me.VistaDoc.GridControl = Me.GridDoc
        Me.VistaDoc.Name = "VistaDoc"
        Me.VistaDoc.OptionsBehavior.AutoExpandAllGroups = True
        '
        'ColPoliza
        '
        Me.ColPoliza.Caption = "Poliza"
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
        Me.ColArchivo.VisibleIndex = 2
        Me.ColArchivo.Width = 248
        '
        'ColDirectorio
        '
        Me.ColDirectorio.Caption = "Directorio"
        Me.ColDirectorio.FieldName = "Directorio"
        Me.ColDirectorio.Name = "ColDirectorio"
        Me.ColDirectorio.Tag = "NOSAVE"
        Me.ColDirectorio.Visible = True
        Me.ColDirectorio.VisibleIndex = 1
        '
        'pagOpcPago
        '
        Me.pagOpcPago.Controls.Add(Me.txtNombreCuentaHabiente)
        Me.pagOpcPago.Controls.Add(Me.cboIdBanco)
        Me.pagOpcPago.Controls.Add(Me.cboIdTipoPago)
        Me.pagOpcPago.Controls.Add(Me.txtEnvioFactura)
        Me.pagOpcPago.Controls.Add(Me.txtCuentaBancaria)
        Me.pagOpcPago.Controls.Add(Me.txtEmisorTarjeta)
        Me.pagOpcPago.Controls.Add(Me.txtVencimientoTarjeta)
        Me.pagOpcPago.Controls.Add(Me.txtTarjetaHabiente)
        Me.pagOpcPago.Controls.Add(Me.txtNumeroTarjeta)
        Me.pagOpcPago.Name = "pagOpcPago"
        Me.pagOpcPago.Size = New System.Drawing.Size(667, 211)
        Me.pagOpcPago.Text = "Opciones Pago"
        '
        'txtNombreCuentaHabiente
        '
        Me.txtNombreCuentaHabiente.CampoBusqueda = False
        Me.txtNombreCuentaHabiente.CampoEsLlave = False
        Me.txtNombreCuentaHabiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCuentaHabiente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCuentaHabiente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCuentaHabiente.FechaActual = False
        Me.txtNombreCuentaHabiente.Formato = ""
        Me.txtNombreCuentaHabiente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCuentaHabiente.LabelText = "Nombre CuentaHabiente"
        Me.txtNombreCuentaHabiente.LabelWidth = 125
        Me.txtNombreCuentaHabiente.Location = New System.Drawing.Point(309, 77)
        Me.txtNombreCuentaHabiente.MaxLength = 100
        Me.txtNombreCuentaHabiente.Name = "txtNombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.NombreCampo = "NombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.Obligatorio = False
        Me.txtNombreCuentaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCuentaHabiente.Size = New System.Drawing.Size(355, 20)
        Me.txtNombreCuentaHabiente.SoloLectura = False
        Me.txtNombreCuentaHabiente.TabIndex = 38
        Me.txtNombreCuentaHabiente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCuentaHabiente.Valor = ""
        '
        'cboIdBanco
        '
        Me.cboIdBanco.CampoAutoCompletar = 0
        Me.cboIdBanco.CampoBusqueda = False
        Me.cboIdBanco.CampoDisplay = 1
        Me.cboIdBanco.CampoEsLlave = False
        Me.cboIdBanco.CampoValor = 0
        Me.cboIdBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdBanco.ControlBackColor = System.Drawing.Color.White
        Me.cboIdBanco.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdBanco.FilasVisibles = 1237
        Me.cboIdBanco.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdBanco.LabelText = "Banco Cliente"
        Me.cboIdBanco.LabelWidth = 125
        Me.cboIdBanco.Lista = ""
        Me.cboIdBanco.Location = New System.Drawing.Point(309, 55)
        Me.cboIdBanco.MostrarBusquedaColumnas = False
        Me.cboIdBanco.Name = "cboIdBanco"
        Me.cboIdBanco.NombreCampo = "IdBanco"
        Me.cboIdBanco.Obligatorio = False
        Me.cboIdBanco.Query = "select IdBanco as Id, NombreBanco as Banco from Bancos"
        Me.cboIdBanco.SelectIndex = 0
        Me.cboIdBanco.Size = New System.Drawing.Size(355, 20)
        Me.cboIdBanco.SoloLectura = False
        Me.cboIdBanco.StringConection = ""
        Me.cboIdBanco.TabIndex = 37
        Me.cboIdBanco.TextoNuevoItem = ""
        Me.cboIdBanco.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdBanco.Valor = ""
        '
        'cboIdTipoPago
        '
        Me.cboIdTipoPago.CampoAutoCompletar = 0
        Me.cboIdTipoPago.CampoBusqueda = False
        Me.cboIdTipoPago.CampoDisplay = 1
        Me.cboIdTipoPago.CampoEsLlave = False
        Me.cboIdTipoPago.CampoValor = 0
        Me.cboIdTipoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdTipoPago.ControlBackColor = System.Drawing.Color.White
        Me.cboIdTipoPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdTipoPago.FilasVisibles = 1237
        Me.cboIdTipoPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdTipoPago.LabelText = "Tipo de Pago"
        Me.cboIdTipoPago.LabelWidth = 125
        Me.cboIdTipoPago.Lista = ""
        Me.cboIdTipoPago.Location = New System.Drawing.Point(309, 11)
        Me.cboIdTipoPago.MostrarBusquedaColumnas = False
        Me.cboIdTipoPago.Name = "cboIdTipoPago"
        Me.cboIdTipoPago.NombreCampo = "IdTipoPago"
        Me.cboIdTipoPago.Obligatorio = False
        Me.cboIdTipoPago.Query = "select IdTipoPago as Id, Descripcion as [Forma Pago] from FormasPagoTipo"
        Me.cboIdTipoPago.SelectIndex = 0
        Me.cboIdTipoPago.Size = New System.Drawing.Size(355, 20)
        Me.cboIdTipoPago.SoloLectura = False
        Me.cboIdTipoPago.StringConection = ""
        Me.cboIdTipoPago.TabIndex = 34
        Me.cboIdTipoPago.TextoNuevoItem = ""
        Me.cboIdTipoPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdTipoPago.Valor = ""
        '
        'txtEnvioFactura
        '
        Me.txtEnvioFactura.CampoBusqueda = False
        Me.txtEnvioFactura.CampoEsLlave = False
        Me.txtEnvioFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEnvioFactura.ControlBackColor = System.Drawing.Color.White
        Me.txtEnvioFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtEnvioFactura.FechaActual = False
        Me.txtEnvioFactura.Formato = ""
        Me.txtEnvioFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEnvioFactura.LabelText = "Envío de Factura"
        Me.txtEnvioFactura.LabelWidth = 125
        Me.txtEnvioFactura.Location = New System.Drawing.Point(309, 33)
        Me.txtEnvioFactura.MaxLength = 150
        Me.txtEnvioFactura.Name = "txtEnvioFactura"
        Me.txtEnvioFactura.NombreCampo = "EnvioFactura"
        Me.txtEnvioFactura.Obligatorio = False
        Me.txtEnvioFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnvioFactura.Size = New System.Drawing.Size(355, 20)
        Me.txtEnvioFactura.SoloLectura = False
        Me.txtEnvioFactura.TabIndex = 35
        Me.txtEnvioFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEnvioFactura.Valor = ""
        '
        'txtCuentaBancaria
        '
        Me.txtCuentaBancaria.CampoBusqueda = False
        Me.txtCuentaBancaria.CampoEsLlave = False
        Me.txtCuentaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCuentaBancaria.ControlBackColor = System.Drawing.Color.White
        Me.txtCuentaBancaria.ControlForeColor = System.Drawing.Color.Black
        Me.txtCuentaBancaria.FechaActual = False
        Me.txtCuentaBancaria.Formato = ""
        Me.txtCuentaBancaria.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCuentaBancaria.LabelText = "Cuenta Bancaria"
        Me.txtCuentaBancaria.LabelWidth = 125
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(309, 100)
        Me.txtCuentaBancaria.MaxLength = 50
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.NombreCampo = "CuentaBancaria"
        Me.txtCuentaBancaria.Obligatorio = False
        Me.txtCuentaBancaria.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(355, 20)
        Me.txtCuentaBancaria.SoloLectura = False
        Me.txtCuentaBancaria.TabIndex = 33
        Me.txtCuentaBancaria.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCuentaBancaria.Valor = ""
        '
        'txtEmisorTarjeta
        '
        Me.txtEmisorTarjeta.CampoBusqueda = False
        Me.txtEmisorTarjeta.CampoEsLlave = False
        Me.txtEmisorTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEmisorTarjeta.ControlBackColor = System.Drawing.Color.White
        Me.txtEmisorTarjeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtEmisorTarjeta.FechaActual = False
        Me.txtEmisorTarjeta.Formato = ""
        Me.txtEmisorTarjeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEmisorTarjeta.LabelText = "Emisor Tarjeta"
        Me.txtEmisorTarjeta.LabelWidth = 100
        Me.txtEmisorTarjeta.Location = New System.Drawing.Point(3, 78)
        Me.txtEmisorTarjeta.MaxLength = 50
        Me.txtEmisorTarjeta.Name = "txtEmisorTarjeta"
        Me.txtEmisorTarjeta.NombreCampo = "EmisorTarjeta"
        Me.txtEmisorTarjeta.Obligatorio = False
        Me.txtEmisorTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmisorTarjeta.Size = New System.Drawing.Size(299, 20)
        Me.txtEmisorTarjeta.SoloLectura = False
        Me.txtEmisorTarjeta.TabIndex = 32
        Me.txtEmisorTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEmisorTarjeta.Valor = ""
        '
        'txtVencimientoTarjeta
        '
        Me.txtVencimientoTarjeta.CampoBusqueda = False
        Me.txtVencimientoTarjeta.CampoEsLlave = False
        Me.txtVencimientoTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVencimientoTarjeta.ControlBackColor = System.Drawing.Color.White
        Me.txtVencimientoTarjeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVencimientoTarjeta.FechaActual = False
        Me.txtVencimientoTarjeta.Formato = ""
        Me.txtVencimientoTarjeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVencimientoTarjeta.LabelText = "Vencimiento Tarjeta"
        Me.txtVencimientoTarjeta.LabelWidth = 100
        Me.txtVencimientoTarjeta.Location = New System.Drawing.Point(3, 55)
        Me.txtVencimientoTarjeta.MaxLength = 50
        Me.txtVencimientoTarjeta.Name = "txtVencimientoTarjeta"
        Me.txtVencimientoTarjeta.NombreCampo = "VencimientoTarjeta"
        Me.txtVencimientoTarjeta.Obligatorio = False
        Me.txtVencimientoTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVencimientoTarjeta.Size = New System.Drawing.Size(299, 20)
        Me.txtVencimientoTarjeta.SoloLectura = False
        Me.txtVencimientoTarjeta.TabIndex = 31
        Me.txtVencimientoTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtVencimientoTarjeta.Valor = ""
        '
        'txtTarjetaHabiente
        '
        Me.txtTarjetaHabiente.CampoBusqueda = False
        Me.txtTarjetaHabiente.CampoEsLlave = False
        Me.txtTarjetaHabiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTarjetaHabiente.ControlBackColor = System.Drawing.Color.White
        Me.txtTarjetaHabiente.ControlForeColor = System.Drawing.Color.Black
        Me.txtTarjetaHabiente.FechaActual = False
        Me.txtTarjetaHabiente.Formato = ""
        Me.txtTarjetaHabiente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTarjetaHabiente.LabelText = "Nombre en Tarjeta"
        Me.txtTarjetaHabiente.LabelWidth = 100
        Me.txtTarjetaHabiente.Location = New System.Drawing.Point(3, 11)
        Me.txtTarjetaHabiente.MaxLength = 150
        Me.txtTarjetaHabiente.Name = "txtTarjetaHabiente"
        Me.txtTarjetaHabiente.NombreCampo = "TarjetaHabiente"
        Me.txtTarjetaHabiente.Obligatorio = False
        Me.txtTarjetaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarjetaHabiente.Size = New System.Drawing.Size(299, 20)
        Me.txtTarjetaHabiente.SoloLectura = False
        Me.txtTarjetaHabiente.TabIndex = 29
        Me.txtTarjetaHabiente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTarjetaHabiente.Valor = ""
        '
        'txtNumeroTarjeta
        '
        Me.txtNumeroTarjeta.CampoBusqueda = False
        Me.txtNumeroTarjeta.CampoEsLlave = False
        Me.txtNumeroTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroTarjeta.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroTarjeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroTarjeta.FechaActual = False
        Me.txtNumeroTarjeta.Formato = ""
        Me.txtNumeroTarjeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroTarjeta.LabelText = "Tarjeta Crédito"
        Me.txtNumeroTarjeta.LabelWidth = 100
        Me.txtNumeroTarjeta.Location = New System.Drawing.Point(3, 33)
        Me.txtNumeroTarjeta.MaxLength = 25
        Me.txtNumeroTarjeta.Name = "txtNumeroTarjeta"
        Me.txtNumeroTarjeta.NombreCampo = "NumeroTarjeta"
        Me.txtNumeroTarjeta.Obligatorio = False
        Me.txtNumeroTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroTarjeta.Size = New System.Drawing.Size(299, 20)
        Me.txtNumeroTarjeta.SoloLectura = False
        Me.txtNumeroTarjeta.TabIndex = 30
        Me.txtNumeroTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroTarjeta.Valor = ""
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
        Me.txtPorceComision.Location = New System.Drawing.Point(446, 122)
        Me.txtPorceComision.MaxLength = 50
        Me.txtPorceComision.Name = "txtPorceComision"
        Me.txtPorceComision.NombreCampo = "PorceComision"
        Me.txtPorceComision.Obligatorio = False
        Me.txtPorceComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceComision.Size = New System.Drawing.Size(228, 20)
        Me.txtPorceComision.SoloLectura = False
        Me.txtPorceComision.TabIndex = 5
        Me.txtPorceComision.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceComision.Valor = 0
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
        Me.txtNumVigencia.Location = New System.Drawing.Point(442, 54)
        Me.txtNumVigencia.MaxLength = 50
        Me.txtNumVigencia.Name = "txtNumVigencia"
        Me.txtNumVigencia.NombreCampo = "NumVigencia"
        Me.txtNumVigencia.Obligatorio = False
        Me.txtNumVigencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumVigencia.Size = New System.Drawing.Size(230, 20)
        Me.txtNumVigencia.SoloLectura = False
        Me.txtNumVigencia.TabIndex = 18
        Me.txtNumVigencia.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumVigencia.Valor = 0
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
        Me.btnImprimir.Location = New System.Drawing.Point(304, 622)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 28
        Me.btnImprimir.Text = "&Imprimir Póliza"
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
        Me.txtObservacionesRenovacion.LabelText = "Observación Ren."
        Me.txtObservacionesRenovacion.LabelWidth = 100
        Me.txtObservacionesRenovacion.Location = New System.Drawing.Point(12, 236)
        Me.txtObservacionesRenovacion.MaxLength = 250
        Me.txtObservacionesRenovacion.Name = "txtObservacionesRenovacion"
        Me.txtObservacionesRenovacion.NombreCampo = "ObservacionesRenovacion"
        Me.txtObservacionesRenovacion.Obligatorio = False
        Me.txtObservacionesRenovacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacionesRenovacion.Size = New System.Drawing.Size(300, 20)
        Me.txtObservacionesRenovacion.SoloLectura = False
        Me.txtObservacionesRenovacion.TabIndex = 13
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
        Me.txtFechaSolicitudRenovacion.LabelWidth = 110
        Me.txtFechaSolicitudRenovacion.Location = New System.Drawing.Point(319, 236)
        Me.txtFechaSolicitudRenovacion.MaxLength = 0
        Me.txtFechaSolicitudRenovacion.Name = "txtFechaSolicitudRenovacion"
        Me.txtFechaSolicitudRenovacion.NombreCampo = "FechaSolicitudRenovacion"
        Me.txtFechaSolicitudRenovacion.Obligatorio = False
        Me.txtFechaSolicitudRenovacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaSolicitudRenovacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaSolicitudRenovacion.SoloLectura = False
        Me.txtFechaSolicitudRenovacion.TabIndex = 14
        Me.txtFechaSolicitudRenovacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaSolicitudRenovacion.Valor = Nothing
        '
        'cboOrigen
        '
        Me.cboOrigen.CampoAutoCompletar = 0
        Me.cboOrigen.CampoBusqueda = False
        Me.cboOrigen.CampoDisplay = 1
        Me.cboOrigen.CampoEsLlave = False
        Me.cboOrigen.CampoValor = 0
        Me.cboOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboOrigen.ControlBackColor = System.Drawing.Color.White
        Me.cboOrigen.ControlForeColor = System.Drawing.Color.Black
        Me.cboOrigen.FilasVisibles = 33203
        Me.cboOrigen.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboOrigen.LabelText = "Origen Póliza"
        Me.cboOrigen.LabelWidth = 100
        Me.cboOrigen.Lista = "NUEVO Cliente Nuevo|TRASLADO Traslado de Aseguradora"
        Me.cboOrigen.Location = New System.Drawing.Point(12, 258)
        Me.cboOrigen.MostrarBusquedaColumnas = False
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.NombreCampo = "Origen"
        Me.cboOrigen.Obligatorio = False
        Me.cboOrigen.Query = ""
        Me.cboOrigen.SelectIndex = 0
        Me.cboOrigen.Size = New System.Drawing.Size(300, 20)
        Me.cboOrigen.SoloLectura = False
        Me.cboOrigen.StringConection = ""
        Me.cboOrigen.TabIndex = 15
        Me.cboOrigen.TextoNuevoItem = ""
        Me.cboOrigen.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboOrigen.Valor = ""
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
        Me.txtFechaVinculacion.LabelWidth = 110
        Me.txtFechaVinculacion.Location = New System.Drawing.Point(319, 258)
        Me.txtFechaVinculacion.MaxLength = 0
        Me.txtFechaVinculacion.Name = "txtFechaVinculacion"
        Me.txtFechaVinculacion.NombreCampo = "FechaVinculacion"
        Me.txtFechaVinculacion.Obligatorio = False
        Me.txtFechaVinculacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaVinculacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaVinculacion.SoloLectura = False
        Me.txtFechaVinculacion.TabIndex = 16
        Me.txtFechaVinculacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaVinculacion.Valor = Nothing
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
        Me.cboDepartamento.FilasVisibles = 33203
        Me.cboDepartamento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDepartamento.LabelText = "Departamento"
        Me.cboDepartamento.LabelWidth = 100
        Me.cboDepartamento.Lista = ""
        Me.cboDepartamento.Location = New System.Drawing.Point(12, 280)
        Me.cboDepartamento.MostrarBusquedaColumnas = False
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.NombreCampo = "Departamento"
        Me.cboDepartamento.Obligatorio = False
        Me.cboDepartamento.Query = "select distinct Departamento as Id, Departamento from usuarios"
        Me.cboDepartamento.SelectIndex = 0
        Me.cboDepartamento.Size = New System.Drawing.Size(300, 20)
        Me.cboDepartamento.SoloLectura = False
        Me.cboDepartamento.StringConection = ""
        Me.cboDepartamento.TabIndex = 17
        Me.cboDepartamento.TextoNuevoItem = ""
        Me.cboDepartamento.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboDepartamento.Valor = ""
        '
        'cboIdCancelacion
        '
        Me.cboIdCancelacion.CampoAutoCompletar = 0
        Me.cboIdCancelacion.CampoBusqueda = False
        Me.cboIdCancelacion.CampoDisplay = 1
        Me.cboIdCancelacion.CampoEsLlave = False
        Me.cboIdCancelacion.CampoValor = 0
        Me.cboIdCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.cboIdCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdCancelacion.FilasVisibles = 33203
        Me.cboIdCancelacion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdCancelacion.LabelText = "Cod. Cancelación"
        Me.cboIdCancelacion.LabelWidth = 100
        Me.cboIdCancelacion.Lista = ""
        Me.cboIdCancelacion.Location = New System.Drawing.Point(12, 213)
        Me.cboIdCancelacion.MostrarBusquedaColumnas = False
        Me.cboIdCancelacion.Name = "cboIdCancelacion"
        Me.cboIdCancelacion.NombreCampo = "IdCancelacion"
        Me.cboIdCancelacion.Obligatorio = False
        Me.cboIdCancelacion.Query = "select IdCancelacion as Id, NombreCancelacion as Descripcion from TipoCancelacion" & _
            " order by IdCancelacion"
        Me.cboIdCancelacion.SelectIndex = 0
        Me.cboIdCancelacion.Size = New System.Drawing.Size(300, 20)
        Me.cboIdCancelacion.SoloLectura = False
        Me.cboIdCancelacion.StringConection = ""
        Me.cboIdCancelacion.TabIndex = 11
        Me.cboIdCancelacion.TextoNuevoItem = ""
        Me.cboIdCancelacion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdCancelacion.Valor = ""
        '
        'txtFechaEnvioAnexo
        '
        Me.txtFechaEnvioAnexo.CampoBusqueda = True
        Me.txtFechaEnvioAnexo.CampoEsLlave = False
        Me.txtFechaEnvioAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvioAnexo.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvioAnexo.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvioAnexo.FechaActual = False
        Me.txtFechaEnvioAnexo.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvioAnexo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvioAnexo.LabelText = "Fec. Env. Anexo"
        Me.txtFechaEnvioAnexo.LabelWidth = 110
        Me.txtFechaEnvioAnexo.Location = New System.Drawing.Point(319, 213)
        Me.txtFechaEnvioAnexo.MaxLength = 0
        Me.txtFechaEnvioAnexo.Name = "txtFechaEnvioAnexo"
        Me.txtFechaEnvioAnexo.NombreCampo = "FechaEnvioAnexo"
        Me.txtFechaEnvioAnexo.Obligatorio = False
        Me.txtFechaEnvioAnexo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvioAnexo.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaEnvioAnexo.SoloLectura = False
        Me.txtFechaEnvioAnexo.TabIndex = 12
        Me.txtFechaEnvioAnexo.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvioAnexo.Valor = Nothing
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
        Me.cboEjecutivoCta.FilasVisibles = 33203
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(12, 325)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(300, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 21
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'txtDiasCob
        '
        Me.txtDiasCob.CampoBusqueda = False
        Me.txtDiasCob.CampoEsLlave = False
        Me.txtDiasCob.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDiasCob.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDiasCob.ControlForeColor = System.Drawing.Color.Black
        Me.txtDiasCob.FechaActual = False
        Me.txtDiasCob.Formato = "#,###0"
        Me.txtDiasCob.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDiasCob.LabelText = "Días"
        Me.txtDiasCob.LabelWidth = 100
        Me.txtDiasCob.Location = New System.Drawing.Point(624, 151)
        Me.txtDiasCob.MaxLength = 0
        Me.txtDiasCob.Name = "txtDiasCob"
        Me.txtDiasCob.NombreCampo = ""
        Me.txtDiasCob.Obligatorio = False
        Me.txtDiasCob.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiasCob.Size = New System.Drawing.Size(57, 36)
        Me.txtDiasCob.SoloLectura = True
        Me.txtDiasCob.TabIndex = 28
        Me.txtDiasCob.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtDiasCob.Valor = 0
        '
        'txtIdPolizaSustituida
        '
        Me.txtIdPolizaSustituida.CampoBusqueda = False
        Me.txtIdPolizaSustituida.CampoEsLlave = False
        Me.txtIdPolizaSustituida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPolizaSustituida.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPolizaSustituida.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPolizaSustituida.FechaActual = False
        Me.txtIdPolizaSustituida.Formato = ""
        Me.txtIdPolizaSustituida.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPolizaSustituida.LabelText = "Sustituida por Póliza"
        Me.txtIdPolizaSustituida.LabelWidth = 100
        Me.txtIdPolizaSustituida.Location = New System.Drawing.Point(12, 302)
        Me.txtIdPolizaSustituida.MaxLength = 25
        Me.txtIdPolizaSustituida.Name = "txtIdPolizaSustituida"
        Me.txtIdPolizaSustituida.NombreCampo = "IdPolizaSustituida"
        Me.txtIdPolizaSustituida.Obligatorio = False
        Me.txtIdPolizaSustituida.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPolizaSustituida.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPolizaSustituida.SoloLectura = False
        Me.txtIdPolizaSustituida.TabIndex = 19
        Me.txtIdPolizaSustituida.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPolizaSustituida.Valor = ""
        '
        'txtObservacionSiniestro
        '
        Me.txtObservacionSiniestro.CampoBusqueda = False
        Me.txtObservacionSiniestro.CampoEsLlave = False
        Me.txtObservacionSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservacionSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtObservacionSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservacionSiniestro.FechaActual = False
        Me.txtObservacionSiniestro.Formato = ""
        Me.txtObservacionSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtObservacionSiniestro.LabelText = "Observación Sin."
        Me.txtObservacionSiniestro.LabelWidth = 110
        Me.txtObservacionSiniestro.Location = New System.Drawing.Point(319, 303)
        Me.txtObservacionSiniestro.MaxLength = 250
        Me.txtObservacionSiniestro.Name = "txtObservacionSiniestro"
        Me.txtObservacionSiniestro.NombreCampo = "ObservacionSiniestro"
        Me.txtObservacionSiniestro.Obligatorio = False
        Me.txtObservacionSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacionSiniestro.Size = New System.Drawing.Size(300, 20)
        Me.txtObservacionSiniestro.SoloLectura = False
        Me.txtObservacionSiniestro.TabIndex = 20
        Me.txtObservacionSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtObservacionSiniestro.Valor = ""
        '
        'txtGrupoCliente
        '
        Me.txtGrupoCliente.CampoBusqueda = True
        Me.txtGrupoCliente.CampoEsLlave = False
        Me.txtGrupoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGrupoCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtGrupoCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtGrupoCliente.FechaActual = False
        Me.txtGrupoCliente.Formato = ""
        Me.txtGrupoCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGrupoCliente.LabelText = "Grupo Cliente"
        Me.txtGrupoCliente.LabelWidth = 110
        Me.txtGrupoCliente.Location = New System.Drawing.Point(319, 325)
        Me.txtGrupoCliente.MaxLength = 25
        Me.txtGrupoCliente.Name = "txtGrupoCliente"
        Me.txtGrupoCliente.NombreCampo = ""
        Me.txtGrupoCliente.Obligatorio = False
        Me.txtGrupoCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrupoCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtGrupoCliente.SoloLectura = True
        Me.txtGrupoCliente.TabIndex = 22
        Me.txtGrupoCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtGrupoCliente.Valor = ""
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
        Me.cboTipoDeducible.FilasVisibles = 33203
        Me.cboTipoDeducible.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoDeducible.LabelText = "Tipo Deducible"
        Me.cboTipoDeducible.LabelWidth = 100
        Me.cboTipoDeducible.Lista = "V Deducible por Vigencia|A Deducible Año Calendario"
        Me.cboTipoDeducible.Location = New System.Drawing.Point(11, 348)
        Me.cboTipoDeducible.MostrarBusquedaColumnas = False
        Me.cboTipoDeducible.Name = "cboTipoDeducible"
        Me.cboTipoDeducible.NombreCampo = "TipoDeducible"
        Me.cboTipoDeducible.Obligatorio = False
        Me.cboTipoDeducible.Query = ""
        Me.cboTipoDeducible.SelectIndex = 0
        Me.cboTipoDeducible.Size = New System.Drawing.Size(300, 20)
        Me.cboTipoDeducible.SoloLectura = False
        Me.cboTipoDeducible.StringConection = ""
        Me.cboTipoDeducible.TabIndex = 23
        Me.cboTipoDeducible.TextoNuevoItem = ""
        Me.cboTipoDeducible.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoDeducible.Valor = ""
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
        Me.cboNegocioPor.FilasVisibles = 53125
        Me.cboNegocioPor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboNegocioPor.LabelText = "Negocio Hecho Por"
        Me.cboNegocioPor.LabelWidth = 110
        Me.cboNegocioPor.Lista = ""
        Me.cboNegocioPor.Location = New System.Drawing.Point(319, 348)
        Me.cboNegocioPor.MostrarBusquedaColumnas = False
        Me.cboNegocioPor.Name = "cboNegocioPor"
        Me.cboNegocioPor.NombreCampo = "NegocioPor"
        Me.cboNegocioPor.Obligatorio = False
        Me.cboNegocioPor.Query = "select idVendedor as Id, NombreVendedor as Vendedor from vendedores"
        Me.cboNegocioPor.SelectIndex = 0
        Me.cboNegocioPor.Size = New System.Drawing.Size(300, 20)
        Me.cboNegocioPor.SoloLectura = False
        Me.cboNegocioPor.StringConection = ""
        Me.cboNegocioPor.TabIndex = 24
        Me.cboNegocioPor.TextoNuevoItem = ""
        Me.cboNegocioPor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNegocioPor.Valor = ""
        '
        'cboTipoPoliza
        '
        Me.cboTipoPoliza.CampoAutoCompletar = 0
        Me.cboTipoPoliza.CampoBusqueda = False
        Me.cboTipoPoliza.CampoDisplay = 1
        Me.cboTipoPoliza.CampoEsLlave = False
        Me.cboTipoPoliza.CampoValor = 0
        Me.cboTipoPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoPoliza.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoPoliza.FilasVisibles = 85000
        Me.cboTipoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoPoliza.LabelText = "Tipo de Póliza"
        Me.cboTipoPoliza.LabelWidth = 95
        Me.cboTipoPoliza.Lista = ""
        Me.cboTipoPoliza.Location = New System.Drawing.Point(156, 30)
        Me.cboTipoPoliza.MostrarBusquedaColumnas = False
        Me.cboTipoPoliza.Name = "cboTipoPoliza"
        Me.cboTipoPoliza.NombreCampo = "TipoPoliza"
        Me.cboTipoPoliza.Obligatorio = False
        Me.cboTipoPoliza.Query = ""
        Me.cboTipoPoliza.SelectIndex = 0
        Me.cboTipoPoliza.Size = New System.Drawing.Size(280, 20)
        Me.cboTipoPoliza.SoloLectura = False
        Me.cboTipoPoliza.StringConection = ""
        Me.cboTipoPoliza.TabIndex = 33
        Me.cboTipoPoliza.TextoNuevoItem = ""
        Me.cboTipoPoliza.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoPoliza.Valor = ""
        '
        'cboFormaPago
        '
        Me.cboFormaPago.CampoAutoCompletar = 0
        Me.cboFormaPago.CampoBusqueda = False
        Me.cboFormaPago.CampoDisplay = 1
        Me.cboFormaPago.CampoEsLlave = False
        Me.cboFormaPago.CampoValor = 0
        Me.cboFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.cboFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboFormaPago.FilasVisibles = 20752
        Me.cboFormaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboFormaPago.LabelText = "Forma de Pago"
        Me.cboFormaPago.LabelWidth = 95
        Me.cboFormaPago.Lista = ""
        Me.cboFormaPago.Location = New System.Drawing.Point(156, 54)
        Me.cboFormaPago.MostrarBusquedaColumnas = False
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.NombreCampo = "IdFormaPago"
        Me.cboFormaPago.Obligatorio = False
        Me.cboFormaPago.Query = "select IdFormaPago as Id, Descripcion as FormaPago from FormasPago"
        Me.cboFormaPago.SelectIndex = 0
        Me.cboFormaPago.Size = New System.Drawing.Size(280, 20)
        Me.cboFormaPago.SoloLectura = False
        Me.cboFormaPago.StringConection = ""
        Me.cboFormaPago.TabIndex = 34
        Me.cboFormaPago.TextoNuevoItem = ""
        Me.cboFormaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboFormaPago.Valor = ""
        '
        'txtIdOferta
        '
        Me.txtIdOferta.CampoBusqueda = False
        Me.txtIdOferta.CampoEsLlave = False
        Me.txtIdOferta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdOferta.ControlBackColor = System.Drawing.Color.White
        Me.txtIdOferta.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdOferta.FechaActual = False
        Me.txtIdOferta.Formato = ""
        Me.txtIdOferta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdOferta.LabelText = "# Oferta"
        Me.txtIdOferta.LabelWidth = 85
        Me.txtIdOferta.Location = New System.Drawing.Point(442, 30)
        Me.txtIdOferta.MaxLength = 25
        Me.txtIdOferta.Name = "txtIdOferta"
        Me.txtIdOferta.NombreCampo = "IdOferta"
        Me.txtIdOferta.Obligatorio = False
        Me.txtIdOferta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdOferta.Size = New System.Drawing.Size(230, 20)
        Me.txtIdOferta.SoloLectura = False
        Me.txtIdOferta.TabIndex = 35
        Me.txtIdOferta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdOferta.Valor = ""
        '
        'txtFechaRecepcion
        '
        Me.txtFechaRecepcion.CampoBusqueda = True
        Me.txtFechaRecepcion.CampoEsLlave = False
        Me.txtFechaRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaRecepcion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaRecepcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaRecepcion.FechaActual = True
        Me.txtFechaRecepcion.Formato = "dd/MMM/yyyy"
        Me.txtFechaRecepcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaRecepcion.LabelText = "Fecha Recepción"
        Me.txtFechaRecepcion.LabelWidth = 110
        Me.txtFechaRecepcion.Location = New System.Drawing.Point(319, 280)
        Me.txtFechaRecepcion.MaxLength = 0
        Me.txtFechaRecepcion.Name = "txtFechaRecepcion"
        Me.txtFechaRecepcion.NombreCampo = "FechaRecepcion"
        Me.txtFechaRecepcion.Obligatorio = False
        Me.txtFechaRecepcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecepcion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaRecepcion.SoloLectura = False
        Me.txtFechaRecepcion.TabIndex = 18
        Me.txtFechaRecepcion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecepcion.Valor = Nothing
        '
        'PolizasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 532
        Me.ClientSize = New System.Drawing.Size(686, 658)
        Me.Controls.Add(Me.txtFechaRecepcion)
        Me.Controls.Add(Me.txtIdOferta)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.cboTipoPoliza)
        Me.Controls.Add(Me.cboNegocioPor)
        Me.Controls.Add(Me.cboTipoDeducible)
        Me.Controls.Add(Me.txtGrupoCliente)
        Me.Controls.Add(Me.txtObservacionSiniestro)
        Me.Controls.Add(Me.txtIdPolizaSustituida)
        Me.Controls.Add(Me.txtDiasCob)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.txtFechaEnvioAnexo)
        Me.Controls.Add(Me.cboIdCancelacion)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.txtFechaVinculacion)
        Me.Controls.Add(Me.cboOrigen)
        Me.Controls.Add(Me.txtFechaSolicitudRenovacion)
        Me.Controls.Add(Me.txtObservacionesRenovacion)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtNumVigencia)
        Me.Controls.Add(Me.txtPorceComision)
        Me.Controls.Add(Me.TabPoliza)
        Me.Controls.Add(Me.txtFechaCancelacion)
        Me.Controls.Add(Me.txtMotivoCancelacion)
        Me.Controls.Add(Me.cboEstadoPoliza)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "PolizasMan"
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Pólizas"
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoCancelacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCancelacion, 0)
        Me.Controls.SetChildIndex(Me.TabPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtPorceComision, 0)
        Me.Controls.SetChildIndex(Me.txtNumVigencia, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.txtObservacionesRenovacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaSolicitudRenovacion, 0)
        Me.Controls.SetChildIndex(Me.cboOrigen, 0)
        Me.Controls.SetChildIndex(Me.txtFechaVinculacion, 0)
        Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
        Me.Controls.SetChildIndex(Me.cboIdCancelacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnvioAnexo, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.txtDiasCob, 0)
        Me.Controls.SetChildIndex(Me.txtIdPolizaSustituida, 0)
        Me.Controls.SetChildIndex(Me.txtObservacionSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtGrupoCliente, 0)
        Me.Controls.SetChildIndex(Me.cboTipoDeducible, 0)
        Me.Controls.SetChildIndex(Me.cboNegocioPor, 0)
        Me.Controls.SetChildIndex(Me.cboTipoPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboFormaPago, 0)
        Me.Controls.SetChildIndex(Me.txtIdOferta, 0)
        Me.Controls.SetChildIndex(Me.txtFechaRecepcion, 0)
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
        Me.pagVendedores.ResumeLayout(False)
        CType(Me.gridVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDocumentos.ResumeLayout(False)
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagOpcPago.ResumeLayout(False)
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
    Friend WithEvents txtNumVigencia As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarCarpeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public WithEvents btnImprimirCertificados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtObservacionesRenovacion As STIControles.stiTextBox
    Friend WithEvents txtFechaSolicitudRenovacion As STIControles.stiTextBox
    Friend WithEvents ColArchivo As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnImprimirAutos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboOrigen As STIControles.stiComboBox
    Friend WithEvents txtFechaVinculacion As STIControles.stiTextBox
    Friend WithEvents colclaCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Public WithEvents btnResumenCertificados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColDirectorio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDepartamento As STIControles.stiComboBox
    Friend WithEvents pagVendedores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnQuitarVendedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarVendedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridVendedores As STIControles.stiGrid
    Friend WithEvents VistaVendedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVenIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboIdCancelacion As STIControles.stiComboBox
    Friend WithEvents txtFechaEnvioAnexo As STIControles.stiTextBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents txtDiasCob As STIControles.stiTextBox
    Public WithEvents btnImpresionDanos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colClaCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCertAseg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIdPolizaSustituida As STIControles.stiTextBox
    Friend WithEvents colClaSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaDeducible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaParticipacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtObservacionSiniestro As STIControles.stiTextBox
    Friend WithEvents txtGrupoCliente As STIControles.stiTextBox
    Friend WithEvents cboTipoDeducible As STIControles.stiComboBox
    Friend WithEvents cboNegocioPor As STIControles.stiComboBox
    Friend WithEvents cboTipoPoliza As STIControles.stiComboBox
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnImprimirAutosExcluidos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboFormaPago As STIControles.stiComboBox
    Friend WithEvents txtIdOferta As STIControles.stiTextBox
    Friend WithEvents pagOpcPago As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCuentaBancaria As STIControles.stiTextBox
    Friend WithEvents txtEmisorTarjeta As STIControles.stiTextBox
    Friend WithEvents txtVencimientoTarjeta As STIControles.stiTextBox
    Friend WithEvents txtTarjetaHabiente As STIControles.stiTextBox
    Friend WithEvents txtNumeroTarjeta As STIControles.stiTextBox
    Friend WithEvents txtNombreCuentaHabiente As STIControles.stiTextBox
    Friend WithEvents cboIdBanco As STIControles.stiComboBox
    Friend WithEvents cboIdTipoPago As STIControles.stiComboBox
    Friend WithEvents txtEnvioFactura As STIControles.stiTextBox
    Friend WithEvents txtFechaRecepcion As STIControles.stiTextBox

End Class
