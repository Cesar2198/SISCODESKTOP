<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HPolizasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HPolizasMan))
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
        Me.ColClaIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaCategoria = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colClaCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colClaDeducible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colClaPArticipacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pagVendedores = New DevExpress.XtraTab.XtraTabPage
        Me.gridVendedores = New STIControles.stiGrid
        Me.VistaVendedores = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colVenIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVenIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.ColIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.txtIdHistorico = New STIControles.stiTextBox
        Me.cboOrigen = New STIControles.stiComboBox
        Me.txtFechaVinculacion = New STIControles.stiTextBox
        Me.cboDepartamento = New STIControles.stiComboBox
        Me.cboIdCancelacion = New STIControles.stiComboBox
        Me.txtFechaEnvioAnexo = New STIControles.stiTextBox
        Me.txtIdPolizaSustituida = New STIControles.stiTextBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.cboTipoDeducible = New STIControles.stiComboBox
        Me.cboNegocioPor = New STIControles.stiComboBox
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
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAyuda.Location = New System.Drawing.Point(499, 551)
        Me.btnAyuda.TabIndex = 15
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(228, 577)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(27, 577)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(119, 577)
        Me.btnGuardar.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(594, 551)
        Me.btnSalir.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(52, 545)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.TabIndex = 13
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(549, 74)
        Me.lblNombreFormulario.TabIndex = 17
        Me.lblNombreFormulario.Text = "Histórico Pólizas de Seguro"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(212, 577)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 13
        Me.btnGuardarComo.Visible = False
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
        Me.txtIdPoliza.Location = New System.Drawing.Point(11, 78)
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
        Me.cboIdProducto.FilasVisibles = 118
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(11, 100)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(414, 20)
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
        Me.btnBuscarCliente.Location = New System.Drawing.Point(319, 120)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 3
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.Visible = False
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
        Me.txtNombreCliente.Location = New System.Drawing.Point(11, 149)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(606, 20)
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
        Me.txtIdCliente.Location = New System.Drawing.Point(11, 123)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
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
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(11, 172)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(300, 20)
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
        Me.txtVigenciaHasta.LabelWidth = 100
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(319, 172)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(300, 20)
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
        Me.cboEstadoPoliza.FilasVisibles = 118
        Me.cboEstadoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoPoliza.LabelText = "Estado Póliza"
        Me.cboEstadoPoliza.LabelWidth = 100
        Me.cboEstadoPoliza.Lista = "VIGENTE Póliza Vigente|CANCELADA Póliza Cancelada"
        Me.cboEstadoPoliza.Location = New System.Drawing.Point(319, 78)
        Me.cboEstadoPoliza.MostrarBusquedaColumnas = False
        Me.cboEstadoPoliza.Name = "cboEstadoPoliza"
        Me.cboEstadoPoliza.NombreCampo = "EstadoPoliza"
        Me.cboEstadoPoliza.Obligatorio = False
        Me.cboEstadoPoliza.Query = ""
        Me.cboEstadoPoliza.SelectIndex = 0
        Me.cboEstadoPoliza.Size = New System.Drawing.Size(300, 20)
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
        Me.txtMotivoCancelacion.LabelText = "Motivo Cancelación"
        Me.txtMotivoCancelacion.LabelWidth = 100
        Me.txtMotivoCancelacion.Location = New System.Drawing.Point(11, 194)
        Me.txtMotivoCancelacion.MaxLength = 250
        Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
        Me.txtMotivoCancelacion.NombreCampo = "MotivoCancelacion"
        Me.txtMotivoCancelacion.Obligatorio = False
        Me.txtMotivoCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoCancelacion.Size = New System.Drawing.Size(300, 20)
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
        Me.txtFechaCancelacion.LabelText = "Fecha Cancelación"
        Me.txtFechaCancelacion.LabelWidth = 100
        Me.txtFechaCancelacion.Location = New System.Drawing.Point(319, 194)
        Me.txtFechaCancelacion.MaxLength = 0
        Me.txtFechaCancelacion.Name = "txtFechaCancelacion"
        Me.txtFechaCancelacion.NombreCampo = "FechaCancelacion"
        Me.txtFechaCancelacion.Obligatorio = False
        Me.txtFechaCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCancelacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaCancelacion.SoloLectura = False
        Me.txtFechaCancelacion.TabIndex = 9
        Me.txtFechaCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCancelacion.Valor = Nothing
        '
        'TabPoliza
        '
        Me.TabPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPoliza.Location = New System.Drawing.Point(7, 369)
        Me.TabPoliza.Name = "TabPoliza"
        Me.TabPoliza.SelectedTabPage = Me.pagCertificados
        Me.TabPoliza.Size = New System.Drawing.Size(678, 176)
        Me.TabPoliza.TabIndex = 20
        Me.TabPoliza.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pagCertificados, Me.pagClausulas, Me.pagVendedores, Me.pagDocumentos, Me.pagOpcPago})
        '
        'pagCertificados
        '
        Me.pagCertificados.Controls.Add(Me.btnAgregarCert)
        Me.pagCertificados.Controls.Add(Me.GridCertificados)
        Me.pagCertificados.Name = "pagCertificados"
        Me.pagCertificados.Size = New System.Drawing.Size(669, 145)
        Me.pagCertificados.Text = "Certificados"
        '
        'btnAgregarCert
        '
        Me.btnAgregarCert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCert.Location = New System.Drawing.Point(647, 3)
        Me.btnAgregarCert.Name = "btnAgregarCert"
        Me.btnAgregarCert.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarCert.TabIndex = 22
        Me.btnAgregarCert.Text = "Agregar"
        Me.btnAgregarCert.Visible = False
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
        Me.GridCertificados.Size = New System.Drawing.Size(651, 139)
        Me.GridCertificados.TabIndex = 20
        Me.GridCertificados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCertificados, Me.GridView2})
        '
        'VistaCertificados
        '
        Me.VistaCertificados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCertificado, Me.colNombreCliente, Me.colVigenciaDesde, Me.colVigenciaHasta, Me.colPrima, Me.colGastos, Me.colIva, Me.colTotal, Me.colEstado, Me.colValorAsegurado, Me.ColCertAseg})
        Me.VistaCertificados.GridControl = Me.GridCertificados
        Me.VistaCertificados.Name = "VistaCertificados"
        Me.VistaCertificados.OptionsView.ShowAutoFilterRow = True
        Me.VistaCertificados.OptionsView.ShowFooter = True
        Me.VistaCertificados.OptionsView.ShowGroupPanel = False
        '
        'colIdCertificado
        '
        Me.colIdCertificado.Caption = "Cert."
        Me.colIdCertificado.FieldName = "IdCertificado"
        Me.colIdCertificado.Name = "colIdCertificado"
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
        Me.pagClausulas.Size = New System.Drawing.Size(669, 138)
        Me.pagClausulas.Text = "Condiciones Especiales de la Póliza"
        '
        'btnQuitarClausula
        '
        Me.btnQuitarClausula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarClausula.Location = New System.Drawing.Point(644, 19)
        Me.btnQuitarClausula.Name = "btnQuitarClausula"
        Me.btnQuitarClausula.Size = New System.Drawing.Size(10, 10)
        Me.btnQuitarClausula.TabIndex = 24
        Me.btnQuitarClausula.Text = "Quitar"
        Me.btnQuitarClausula.Visible = False
        '
        'btnAgregarClausula
        '
        Me.btnAgregarClausula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarClausula.Location = New System.Drawing.Point(644, 3)
        Me.btnAgregarClausula.Name = "btnAgregarClausula"
        Me.btnAgregarClausula.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarClausula.TabIndex = 23
        Me.btnAgregarClausula.Text = "Agregar"
        Me.btnAgregarClausula.Visible = False
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
        Me.GridClausulas.NombreTabla = "HPolizasClausulas"
        Me.GridClausulas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemMemoEdit1})
        Me.GridClausulas.Size = New System.Drawing.Size(651, 165)
        Me.GridClausulas.TabIndex = 0
        Me.GridClausulas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaClausulas})
        '
        'VistaClausulas
        '
        Me.VistaClausulas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClaIdPoliza, Me.colClaIdProducto, Me.colClaIdClausula, Me.colclaClausula, Me.ColClaIdHistorico, Me.colClaCategoria, Me.colClaCodigoInterno, Me.colClaSuma, Me.colClaDeducible, Me.colClaPArticipacion})
        Me.VistaClausulas.GridControl = Me.GridClausulas
        Me.VistaClausulas.Name = "VistaClausulas"
        Me.VistaClausulas.OptionsView.ShowGroupPanel = False
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
        Me.colClaIdClausula.Visible = True
        Me.colClaIdClausula.VisibleIndex = 0
        Me.colClaIdClausula.Width = 79
        '
        'colclaClausula
        '
        Me.colclaClausula.Caption = "Descripción Condición Especial"
        Me.colclaClausula.FieldName = "Clausula"
        Me.colclaClausula.Name = "colclaClausula"
        Me.colclaClausula.Visible = True
        Me.colclaClausula.VisibleIndex = 2
        Me.colclaClausula.Width = 429
        '
        'ColClaIdHistorico
        '
        Me.ColClaIdHistorico.Caption = "IdHistorico"
        Me.ColClaIdHistorico.FieldName = "IdHistorico"
        Me.ColClaIdHistorico.Name = "ColClaIdHistorico"
        '
        'colClaCategoria
        '
        Me.colClaCategoria.Caption = "Categoría"
        Me.colClaCategoria.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colClaCategoria.FieldName = "Categoria"
        Me.colClaCategoria.Name = "colClaCategoria"
        Me.colClaCategoria.Visible = True
        Me.colClaCategoria.VisibleIndex = 3
        Me.colClaCategoria.Width = 108
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
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colClaPArticipacion
        '
        Me.colClaPArticipacion.Caption = "Participación"
        Me.colClaPArticipacion.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colClaPArticipacion.FieldName = "Participacion"
        Me.colClaPArticipacion.Name = "colClaPArticipacion"
        '
        'pagVendedores
        '
        Me.pagVendedores.Controls.Add(Me.gridVendedores)
        Me.pagVendedores.Name = "pagVendedores"
        Me.pagVendedores.Size = New System.Drawing.Size(669, 138)
        Me.pagVendedores.Text = "Vendedores"
        '
        'gridVendedores
        '
        Me.gridVendedores.ColumnasAdicionales = ""
        Me.gridVendedores.Location = New System.Drawing.Point(5, 0)
        Me.gridVendedores.MainView = Me.VistaVendedores
        Me.gridVendedores.Name = "gridVendedores"
        Me.gridVendedores.NombreTabla = "HPolizasVendedores"
        Me.gridVendedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.gridVendedores.Size = New System.Drawing.Size(649, 165)
        Me.gridVendedores.TabIndex = 1
        Me.gridVendedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaVendedores})
        '
        'VistaVendedores
        '
        Me.VistaVendedores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVenIdPoliza, Me.colVenIdProducto, Me.GridColumn2, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
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
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Id"
        Me.GridColumn2.FieldName = "Orden"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdHistorico"
        Me.GridColumn1.FieldName = "IdHistorico"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Vendedor"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn3.FieldName = "IdVendedor"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 348
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
        Me.GridColumn4.Width = 182
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Efectiva"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "FechaEfectiva"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'pagDocumentos
        '
        Me.pagDocumentos.Controls.Add(Me.btnAgregarCarpeta)
        Me.pagDocumentos.Controls.Add(Me.btnQuitarDoc)
        Me.pagDocumentos.Controls.Add(Me.btnAgregarDoc)
        Me.pagDocumentos.Controls.Add(Me.GridDoc)
        Me.pagDocumentos.Name = "pagDocumentos"
        Me.pagDocumentos.Size = New System.Drawing.Size(669, 138)
        Me.pagDocumentos.Text = "Documentos"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(656, 19)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarCarpeta.TabIndex = 23
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        Me.btnAgregarCarpeta.Visible = False
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(656, 35)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(10, 10)
        Me.btnQuitarDoc.TabIndex = 22
        Me.btnQuitarDoc.Text = "Quitar"
        Me.btnQuitarDoc.Visible = False
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(656, 3)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(10, 10)
        Me.btnAgregarDoc.TabIndex = 21
        Me.btnAgregarDoc.Text = "Agregar Archivo"
        Me.btnAgregarDoc.Visible = False
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
        Me.GridDoc.NombreTabla = "HPolizasDocumentos"
        Me.GridDoc.Size = New System.Drawing.Size(663, 173)
        Me.GridDoc.TabIndex = 0
        Me.GridDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDoc})
        '
        'VistaDoc
        '
        Me.VistaDoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPoliza, Me.ColProducto, Me.ColDoc, Me.colDocumento, Me.ColIdHistorico})
        Me.VistaDoc.GridControl = Me.GridDoc
        Me.VistaDoc.Name = "VistaDoc"
        Me.VistaDoc.OptionsView.ShowGroupPanel = False
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
        Me.ColDoc.Width = 63
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Documento"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 1
        Me.colDocumento.Width = 429
        '
        'ColIdHistorico
        '
        Me.ColIdHistorico.Caption = "IdHistorico"
        Me.ColIdHistorico.FieldName = "IdHistorico"
        Me.ColIdHistorico.Name = "ColIdHistorico"
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
        Me.pagOpcPago.Size = New System.Drawing.Size(669, 138)
        Me.pagOpcPago.Text = "Opciones de Pago"
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
        Me.txtNombreCuentaHabiente.Location = New System.Drawing.Point(309, 70)
        Me.txtNombreCuentaHabiente.MaxLength = 100
        Me.txtNombreCuentaHabiente.Name = "txtNombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.NombreCampo = "NombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.Obligatorio = False
        Me.txtNombreCuentaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCuentaHabiente.Size = New System.Drawing.Size(355, 20)
        Me.txtNombreCuentaHabiente.SoloLectura = False
        Me.txtNombreCuentaHabiente.TabIndex = 47
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
        Me.cboIdBanco.Location = New System.Drawing.Point(309, 48)
        Me.cboIdBanco.MostrarBusquedaColumnas = False
        Me.cboIdBanco.Name = "cboIdBanco"
        Me.cboIdBanco.NombreCampo = "IdBanco"
        Me.cboIdBanco.Obligatorio = False
        Me.cboIdBanco.Query = "select IdBanco as Id, NombreBanco as Banco from Bancos"
        Me.cboIdBanco.SelectIndex = 0
        Me.cboIdBanco.Size = New System.Drawing.Size(355, 20)
        Me.cboIdBanco.SoloLectura = False
        Me.cboIdBanco.StringConection = ""
        Me.cboIdBanco.TabIndex = 46
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
        Me.cboIdTipoPago.LabelText = "Forma de Pago"
        Me.cboIdTipoPago.LabelWidth = 125
        Me.cboIdTipoPago.Lista = ""
        Me.cboIdTipoPago.Location = New System.Drawing.Point(309, 4)
        Me.cboIdTipoPago.MostrarBusquedaColumnas = False
        Me.cboIdTipoPago.Name = "cboIdTipoPago"
        Me.cboIdTipoPago.NombreCampo = "IdTipoPago"
        Me.cboIdTipoPago.Obligatorio = False
        Me.cboIdTipoPago.Query = "select IdTipoPago as Id, Descripcion as [Forma Pago] from FormasPagoTipo"
        Me.cboIdTipoPago.SelectIndex = 0
        Me.cboIdTipoPago.Size = New System.Drawing.Size(355, 20)
        Me.cboIdTipoPago.SoloLectura = False
        Me.cboIdTipoPago.StringConection = ""
        Me.cboIdTipoPago.TabIndex = 44
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
        Me.txtEnvioFactura.Location = New System.Drawing.Point(309, 26)
        Me.txtEnvioFactura.MaxLength = 150
        Me.txtEnvioFactura.Name = "txtEnvioFactura"
        Me.txtEnvioFactura.NombreCampo = "EnvioFactura"
        Me.txtEnvioFactura.Obligatorio = False
        Me.txtEnvioFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnvioFactura.Size = New System.Drawing.Size(355, 20)
        Me.txtEnvioFactura.SoloLectura = False
        Me.txtEnvioFactura.TabIndex = 45
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
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(309, 93)
        Me.txtCuentaBancaria.MaxLength = 50
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.NombreCampo = "CuentaBancaria"
        Me.txtCuentaBancaria.Obligatorio = False
        Me.txtCuentaBancaria.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(355, 20)
        Me.txtCuentaBancaria.SoloLectura = False
        Me.txtCuentaBancaria.TabIndex = 43
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
        Me.txtEmisorTarjeta.Location = New System.Drawing.Point(3, 71)
        Me.txtEmisorTarjeta.MaxLength = 50
        Me.txtEmisorTarjeta.Name = "txtEmisorTarjeta"
        Me.txtEmisorTarjeta.NombreCampo = "EmisorTarjeta"
        Me.txtEmisorTarjeta.Obligatorio = False
        Me.txtEmisorTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmisorTarjeta.Size = New System.Drawing.Size(299, 20)
        Me.txtEmisorTarjeta.SoloLectura = False
        Me.txtEmisorTarjeta.TabIndex = 42
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
        Me.txtVencimientoTarjeta.Location = New System.Drawing.Point(3, 48)
        Me.txtVencimientoTarjeta.MaxLength = 50
        Me.txtVencimientoTarjeta.Name = "txtVencimientoTarjeta"
        Me.txtVencimientoTarjeta.NombreCampo = "VencimientoTarjeta"
        Me.txtVencimientoTarjeta.Obligatorio = False
        Me.txtVencimientoTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVencimientoTarjeta.Size = New System.Drawing.Size(299, 20)
        Me.txtVencimientoTarjeta.SoloLectura = False
        Me.txtVencimientoTarjeta.TabIndex = 41
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
        Me.txtTarjetaHabiente.Location = New System.Drawing.Point(3, 4)
        Me.txtTarjetaHabiente.MaxLength = 150
        Me.txtTarjetaHabiente.Name = "txtTarjetaHabiente"
        Me.txtTarjetaHabiente.NombreCampo = "TarjetaHabiente"
        Me.txtTarjetaHabiente.Obligatorio = False
        Me.txtTarjetaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarjetaHabiente.Size = New System.Drawing.Size(299, 20)
        Me.txtTarjetaHabiente.SoloLectura = False
        Me.txtTarjetaHabiente.TabIndex = 39
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
        Me.txtNumeroTarjeta.Location = New System.Drawing.Point(3, 26)
        Me.txtNumeroTarjeta.MaxLength = 25
        Me.txtNumeroTarjeta.Name = "txtNumeroTarjeta"
        Me.txtNumeroTarjeta.NombreCampo = "NumeroTarjeta"
        Me.txtNumeroTarjeta.Obligatorio = False
        Me.txtNumeroTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroTarjeta.Size = New System.Drawing.Size(299, 20)
        Me.txtNumeroTarjeta.SoloLectura = False
        Me.txtNumeroTarjeta.TabIndex = 40
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
        Me.txtPorceComision.Location = New System.Drawing.Point(446, 123)
        Me.txtPorceComision.MaxLength = 50
        Me.txtPorceComision.Name = "txtPorceComision"
        Me.txtPorceComision.NombreCampo = "PorceComision"
        Me.txtPorceComision.Obligatorio = False
        Me.txtPorceComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceComision.Size = New System.Drawing.Size(172, 20)
        Me.txtPorceComision.SoloLectura = False
        Me.txtPorceComision.TabIndex = 4
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
        Me.txtNumVigencia.LabelWidth = 100
        Me.txtNumVigencia.Location = New System.Drawing.Point(11, 333)
        Me.txtNumVigencia.MaxLength = 50
        Me.txtNumVigencia.Name = "txtNumVigencia"
        Me.txtNumVigencia.NombreCampo = "NumVigencia"
        Me.txtNumVigencia.Obligatorio = False
        Me.txtNumVigencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumVigencia.Size = New System.Drawing.Size(172, 20)
        Me.txtNumVigencia.SoloLectura = False
        Me.txtNumVigencia.TabIndex = 15
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
        Me.btnImprimir.Location = New System.Drawing.Point(393, 551)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "&Imprimir Póliza"
        '
        'txtIdHistorico
        '
        Me.txtIdHistorico.CampoBusqueda = False
        Me.txtIdHistorico.CampoEsLlave = True
        Me.txtIdHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdHistorico.ControlBackColor = System.Drawing.Color.White
        Me.txtIdHistorico.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdHistorico.FechaActual = False
        Me.txtIdHistorico.Formato = "#0"
        Me.txtIdHistorico.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdHistorico.LabelText = "Núm. Historico"
        Me.txtIdHistorico.LabelWidth = 85
        Me.txtIdHistorico.Location = New System.Drawing.Point(447, 100)
        Me.txtIdHistorico.MaxLength = 50
        Me.txtIdHistorico.Name = "txtIdHistorico"
        Me.txtIdHistorico.NombreCampo = "IdHistorico"
        Me.txtIdHistorico.Obligatorio = True
        Me.txtIdHistorico.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdHistorico.Size = New System.Drawing.Size(172, 20)
        Me.txtIdHistorico.SoloLectura = False
        Me.txtIdHistorico.TabIndex = 23
        Me.txtIdHistorico.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdHistorico.Valor = 0
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
        Me.cboOrigen.FilasVisibles = 118
        Me.cboOrigen.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboOrigen.LabelText = "Origen Póliza"
        Me.cboOrigen.LabelWidth = 100
        Me.cboOrigen.Lista = "NUEVO Cliente Nuevo|TRASLADO Traslado de Aseguradora"
        Me.cboOrigen.Location = New System.Drawing.Point(11, 240)
        Me.cboOrigen.MostrarBusquedaColumnas = False
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.NombreCampo = "Origen"
        Me.cboOrigen.Obligatorio = False
        Me.cboOrigen.Query = ""
        Me.cboOrigen.SelectIndex = 0
        Me.cboOrigen.Size = New System.Drawing.Size(300, 20)
        Me.cboOrigen.SoloLectura = False
        Me.cboOrigen.StringConection = ""
        Me.cboOrigen.TabIndex = 12
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
        Me.txtFechaVinculacion.LabelWidth = 100
        Me.txtFechaVinculacion.Location = New System.Drawing.Point(319, 240)
        Me.txtFechaVinculacion.MaxLength = 0
        Me.txtFechaVinculacion.Name = "txtFechaVinculacion"
        Me.txtFechaVinculacion.NombreCampo = "FechaVinculacion"
        Me.txtFechaVinculacion.Obligatorio = False
        Me.txtFechaVinculacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaVinculacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaVinculacion.SoloLectura = False
        Me.txtFechaVinculacion.TabIndex = 13
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
        Me.cboDepartamento.FilasVisibles = 118
        Me.cboDepartamento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDepartamento.LabelText = "Departamento"
        Me.cboDepartamento.LabelWidth = 100
        Me.cboDepartamento.Lista = ""
        Me.cboDepartamento.Location = New System.Drawing.Point(11, 263)
        Me.cboDepartamento.MostrarBusquedaColumnas = False
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.NombreCampo = "Departamento"
        Me.cboDepartamento.Obligatorio = False
        Me.cboDepartamento.Query = "select distinct Departamento as Id, Departamento from usuarios"
        Me.cboDepartamento.SelectIndex = 0
        Me.cboDepartamento.Size = New System.Drawing.Size(299, 20)
        Me.cboDepartamento.SoloLectura = False
        Me.cboDepartamento.StringConection = ""
        Me.cboDepartamento.TabIndex = 14
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
        Me.cboIdCancelacion.FilasVisibles = 118
        Me.cboIdCancelacion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdCancelacion.LabelText = "Cod. Cancelación"
        Me.cboIdCancelacion.LabelWidth = 100
        Me.cboIdCancelacion.Lista = ""
        Me.cboIdCancelacion.Location = New System.Drawing.Point(11, 217)
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
        Me.cboIdCancelacion.TabIndex = 10
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
        Me.txtFechaEnvioAnexo.LabelWidth = 100
        Me.txtFechaEnvioAnexo.Location = New System.Drawing.Point(319, 217)
        Me.txtFechaEnvioAnexo.MaxLength = 0
        Me.txtFechaEnvioAnexo.Name = "txtFechaEnvioAnexo"
        Me.txtFechaEnvioAnexo.NombreCampo = "FechaEnvioAnexo"
        Me.txtFechaEnvioAnexo.Obligatorio = False
        Me.txtFechaEnvioAnexo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvioAnexo.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaEnvioAnexo.SoloLectura = False
        Me.txtFechaEnvioAnexo.TabIndex = 11
        Me.txtFechaEnvioAnexo.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvioAnexo.Valor = Nothing
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
        Me.txtIdPolizaSustituida.Location = New System.Drawing.Point(11, 286)
        Me.txtIdPolizaSustituida.MaxLength = 25
        Me.txtIdPolizaSustituida.Name = "txtIdPolizaSustituida"
        Me.txtIdPolizaSustituida.NombreCampo = "IdPolizaSustituida"
        Me.txtIdPolizaSustituida.Obligatorio = False
        Me.txtIdPolizaSustituida.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPolizaSustituida.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPolizaSustituida.SoloLectura = False
        Me.txtIdPolizaSustituida.TabIndex = 16
        Me.txtIdPolizaSustituida.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPolizaSustituida.Valor = ""
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
        Me.cboEjecutivoCta.FilasVisibles = 118
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(11, 309)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(301, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 17
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
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
        Me.cboTipoDeducible.FilasVisibles = 118
        Me.cboTipoDeducible.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoDeducible.LabelText = "Tipo Deducible"
        Me.cboTipoDeducible.LabelWidth = 100
        Me.cboTipoDeducible.Lista = "V Deducible por Vigencia|A Deducible Año Calendario"
        Me.cboTipoDeducible.Location = New System.Drawing.Point(319, 286)
        Me.cboTipoDeducible.MostrarBusquedaColumnas = False
        Me.cboTipoDeducible.Name = "cboTipoDeducible"
        Me.cboTipoDeducible.NombreCampo = "TipoDeducible"
        Me.cboTipoDeducible.Obligatorio = False
        Me.cboTipoDeducible.Query = ""
        Me.cboTipoDeducible.SelectIndex = 0
        Me.cboTipoDeducible.Size = New System.Drawing.Size(300, 20)
        Me.cboTipoDeducible.SoloLectura = False
        Me.cboTipoDeducible.StringConection = ""
        Me.cboTipoDeducible.TabIndex = 32
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
        Me.cboNegocioPor.FilasVisibles = 483
        Me.cboNegocioPor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboNegocioPor.LabelText = "Negocio Hecho Por"
        Me.cboNegocioPor.LabelWidth = 100
        Me.cboNegocioPor.Lista = ""
        Me.cboNegocioPor.Location = New System.Drawing.Point(319, 309)
        Me.cboNegocioPor.MostrarBusquedaColumnas = False
        Me.cboNegocioPor.Name = "cboNegocioPor"
        Me.cboNegocioPor.NombreCampo = "NegocioPor"
        Me.cboNegocioPor.Obligatorio = False
        Me.cboNegocioPor.Query = "select idVendedor as Id, NombreVendedor as Vendedor from vendedores"
        Me.cboNegocioPor.SelectIndex = 0
        Me.cboNegocioPor.Size = New System.Drawing.Size(300, 20)
        Me.cboNegocioPor.SoloLectura = False
        Me.cboNegocioPor.StringConection = ""
        Me.cboNegocioPor.TabIndex = 35
        Me.cboNegocioPor.TextoNuevoItem = ""
        Me.cboNegocioPor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNegocioPor.Valor = ""
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
        Me.txtFechaRecepcion.LabelWidth = 100
        Me.txtFechaRecepcion.Location = New System.Drawing.Point(319, 263)
        Me.txtFechaRecepcion.MaxLength = 0
        Me.txtFechaRecepcion.Name = "txtFechaRecepcion"
        Me.txtFechaRecepcion.NombreCampo = "FechaRecepcion"
        Me.txtFechaRecepcion.Obligatorio = False
        Me.txtFechaRecepcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecepcion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaRecepcion.SoloLectura = False
        Me.txtFechaRecepcion.TabIndex = 36
        Me.txtFechaRecepcion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecepcion.Valor = Nothing
        '
        'HPolizasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 507
        Me.ClientSize = New System.Drawing.Size(688, 587)
        Me.Controls.Add(Me.txtFechaRecepcion)
        Me.Controls.Add(Me.cboNegocioPor)
        Me.Controls.Add(Me.cboTipoDeducible)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.txtIdPolizaSustituida)
        Me.Controls.Add(Me.txtFechaEnvioAnexo)
        Me.Controls.Add(Me.cboIdCancelacion)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.txtFechaVinculacion)
        Me.Controls.Add(Me.cboOrigen)
        Me.Controls.Add(Me.txtIdHistorico)
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
        Me.Name = "HPolizasMan"
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Pólizas"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
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
        Me.Controls.SetChildIndex(Me.txtIdHistorico, 0)
        Me.Controls.SetChildIndex(Me.cboOrigen, 0)
        Me.Controls.SetChildIndex(Me.txtFechaVinculacion, 0)
        Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
        Me.Controls.SetChildIndex(Me.cboIdCancelacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnvioAnexo, 0)
        Me.Controls.SetChildIndex(Me.txtIdPolizaSustituida, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.cboTipoDeducible, 0)
        Me.Controls.SetChildIndex(Me.cboNegocioPor, 0)
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
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtIdHistorico As STIControles.stiTextBox
    Friend WithEvents ColClaIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboOrigen As STIControles.stiComboBox
    Friend WithEvents txtFechaVinculacion As STIControles.stiTextBox
    Friend WithEvents colClaCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboDepartamento As STIControles.stiComboBox
    Friend WithEvents pagVendedores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridVendedores As STIControles.stiGrid
    Friend WithEvents VistaVendedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVenIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVenIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboIdCancelacion As STIControles.stiComboBox
    Friend WithEvents txtFechaEnvioAnexo As STIControles.stiTextBox
    Friend WithEvents colClaCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCertAseg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIdPolizaSustituida As STIControles.stiTextBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents colClaSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaDeducible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClaPArticipacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents cboTipoDeducible As STIControles.stiComboBox
    Friend WithEvents cboNegocioPor As STIControles.stiComboBox
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pagOpcPago As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNombreCuentaHabiente As STIControles.stiTextBox
    Friend WithEvents cboIdBanco As STIControles.stiComboBox
    Friend WithEvents cboIdTipoPago As STIControles.stiComboBox
    Friend WithEvents txtEnvioFactura As STIControles.stiTextBox
    Friend WithEvents txtCuentaBancaria As STIControles.stiTextBox
    Friend WithEvents txtEmisorTarjeta As STIControles.stiTextBox
    Friend WithEvents txtVencimientoTarjeta As STIControles.stiTextBox
    Friend WithEvents txtTarjetaHabiente As STIControles.stiTextBox
    Friend WithEvents txtNumeroTarjeta As STIControles.stiTextBox
    Friend WithEvents txtFechaRecepcion As STIControles.stiTextBox

End Class
