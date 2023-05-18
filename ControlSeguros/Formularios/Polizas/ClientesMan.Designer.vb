<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesMan
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesMan))
        Dim PivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition2 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Me.ColDiasMora = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.AGeneral = New DevExpress.XtraTab.XtraTabPage
        Me.cboReferidoPor = New STIControles.stiComboBox
        Me.txtNombreCuentaHabiente = New STIControles.stiTextBox
        Me.txtCuentaBancaria = New STIControles.stiTextBox
        Me.txtConocidoPor = New STIControles.stiTextBox
        Me.txtEmisorTarjeta = New STIControles.stiTextBox
        Me.cboEstadoCliente = New STIControles.stiComboBox
        Me.cboIdBanco = New STIControles.stiComboBox
        Me.txtFnacRepLegal = New STIControles.stiTextBox
        Me.TabClientesInfo = New DevExpress.XtraTab.XtraTabControl
        Me.TabClientesContactos = New DevExpress.XtraTab.XtraTabPage
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton
        Me.StiGrid1 = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdContacto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCiudad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCargo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsoCorrespondencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFechaNacimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabClientesEjectivos = New DevExpress.XtraTab.XtraTabPage
        Me.GridEjecutivos = New STIControles.stiGrid
        Me.VistaEjecutivos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdCliente2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdEjecutivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGridEjecutivo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGridRamo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colTipoProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGridTipoProducto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colIdArea = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGridArea = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnAgregarEjecutivo = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminarEjecutivo = New DevExpress.XtraEditors.SimpleButton
        Me.TabClientesDocumentos = New DevExpress.XtraTab.XtraTabPage
        Me.btnAgregarCarpeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.GridDoc = New STIControles.stiGrid
        Me.VistaDoc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColArchivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDirectorio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabCliNatural = New DevExpress.XtraTab.XtraTabPage
        Me.gridDatosNat = New STIControles.stiGrid
        Me.VistaDatosNat = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDNIdCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDNIdCampo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDNNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDNDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabCliJuridica = New DevExpress.XtraTab.XtraTabPage
        Me.gridDatJuridica = New STIControles.stiGrid
        Me.VistaDatJuridica = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDJIdCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdCampo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDJNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDJDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StiTextBox10 = New STIControles.stiTextBox
        Me.cboIdTipoPago = New STIControles.stiComboBox
        Me.txtEnvioFactura = New STIControles.stiTextBox
        Me.txtVencimientoTarjeta = New STIControles.stiTextBox
        Me.txtTarjetaHabiente = New STIControles.stiTextBox
        Me.txtNumeroTarjeta = New STIControles.stiTextBox
        Me.txtInicialesFlujo = New STIControles.stiTextBox
        Me.txtFechaVinculacion = New STIControles.stiTextBox
        Me.txtTelRepLegal = New STIControles.stiTextBox
        Me.txtNitRepLegal = New STIControles.stiTextBox
        Me.txtNombreRepLegal = New STIControles.stiTextBox
        Me.txtLugarTrabajo = New STIControles.stiTextBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.txtFax = New STIControles.stiTextBox
        Me.cboIdTipoCliente = New STIControles.stiComboBox
        Me.txtEmail = New STIControles.stiTextBox
        Me.txtFechaNacimiento = New STIControles.stiTextBox
        Me.stiGiro = New STIControles.stiTextBox
        Me.txtRegistroFiscal = New STIControles.stiTextBox
        Me.txtDui = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.JCliNatural = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirNatural = New DevExpress.XtraEditors.SimpleButton
        Me.txtnat_Comentarios = New STIControles.stiMemo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtnat_FechaFormulario = New STIControles.stiTextBox
        Me.txtnat_CompletaFormulario = New STIControles.stiTextBox
        Me.txtnat_Cesion = New STIControles.stiMemo
        Me.txtnat_Bebida = New STIControles.stiTextBox
        Me.txtnat_Musica = New STIControles.stiTextBox
        Me.txtnat_Comida = New STIControles.stiTextBox
        Me.txtnat_Religion = New STIControles.stiTextBox
        Me.txtnat_Hobbie = New STIControles.stiTextBox
        Me.txtnat_Deporte = New STIControles.stiTextBox
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.cbonat_ClienteExistente = New STIControles.stiComboBox
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.cbonat_PreferenciaPago = New STIControles.stiComboBox
        Me.cbonat_PreferenciaCobro = New STIControles.stiComboBox
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtnat_EmailTrabajo = New STIControles.stiTextBox
        Me.txtnat_PaginaWeb = New STIControles.stiTextBox
        Me.txtnat_ContactoCobro = New STIControles.stiTextBox
        Me.txtnat_ReferidoPor = New STIControles.stiTextBox
        Me.txtnat_MedioInformacion = New STIControles.stiTextBox
        Me.txtnat_DireccionTrabajo = New STIControles.stiMemo
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cbonat_TieneHijos = New STIControles.stiComboBox
        Me.txtnat_DireccionCasa = New STIControles.stiMemo
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtnat_Profesion = New STIControles.stiTextBox
        Me.txtnat_twitter = New STIControles.stiTextBox
        Me.txtnat_Facebook = New STIControles.stiTextBox
        Me.txtnat_NumHijos = New STIControles.stiTextBox
        Me.txtnat_PinBB = New STIControles.stiTextBox
        Me.txtnat_FaxTrabajo = New STIControles.stiTextBox
        Me.txtnat_TelTrabajo = New STIControles.stiTextBox
        Me.txtnat_Cargo = New STIControles.stiTextBox
        Me.txtnat_LugarTrabajo = New STIControles.stiTextBox
        Me.txtnat_EmailCasa = New STIControles.stiTextBox
        Me.txtnat_EstadoCivil = New STIControles.stiTextBox
        Me.txtnat_TelMovil = New STIControles.stiTextBox
        Me.txtnat_TelCasa = New STIControles.stiTextBox
        Me.txtnat_NombreCliente = New STIControles.stiTextBox
        Me.KCliEmpresa = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirJuridico = New DevExpress.XtraEditors.SimpleButton
        Me.txtjur_Comentario = New STIControles.stiMemo
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtjur_ActPaginaWeb = New STIControles.stiTextBox
        Me.txtjur_ActEmail = New STIControles.stiTextBox
        Me.txtjur_ActFax = New STIControles.stiTextBox
        Me.txtjur_ActTelefonos = New STIControles.stiTextBox
        Me.txtjur_ActDireccion = New STIControles.stiMemo
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtjur_Cesion = New STIControles.stiMemo
        Me.txtjur_Pagador = New STIControles.stiTextBox
        Me.txtjur_FormaPago = New STIControles.stiTextBox
        Me.txtjur_ClienteExiste = New STIControles.stiComboBox
        Me.txtjur_ReferidoPor = New STIControles.stiTextBox
        Me.txtjur_CobroEmail = New STIControles.stiTextBox
        Me.txtjur_CobroFax = New STIControles.stiTextBox
        Me.txtjur_CobroTelefono = New STIControles.stiTextBox
        Me.txtjur_ContactoCobro = New STIControles.stiTextBox
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtjur_Twitter = New STIControles.stiTextBox
        Me.txtjur_Facebook = New STIControles.stiTextBox
        Me.txtjur_PaginaWeb = New STIControles.stiTextBox
        Me.txtjur_PolPinBB = New STIControles.stiTextBox
        Me.txtjur_Email = New STIControles.stiTextBox
        Me.txtjur_FaxOficina = New STIControles.stiTextBox
        Me.txtjur_TelOficina = New STIControles.stiTextBox
        Me.jur_DireccionOficina = New STIControles.stiMemo
        Me.txtjur_EncargadoPoliza = New STIControles.stiTextBox
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtjur_Profesion = New STIControles.stiTextBox
        Me.txtjur_TelMovil = New STIControles.stiTextBox
        Me.txtjur_PinBB = New STIControles.stiTextBox
        Me.txtjur_RepresentanteLegal = New STIControles.stiTextBox
        Me.txtjur_Giro = New STIControles.stiTextBox
        Me.txtjur_NombreEmpresa = New STIControles.stiTextBox
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.CPolizas = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirListaPolizas = New DevExpress.XtraEditors.SimpleButton
        Me.GridPolizas = New STIControles.stiGrid
        Me.VistaPolizas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColPPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpNProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPVigDesde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpVigHasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpFechaCan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpMotivoCan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JCertificados = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirCertificados = New DevExpress.XtraEditors.SimpleButton
        Me.GridCertificados = New STIControles.stiGrid
        Me.VistaCertificados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCertIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertVigDesde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertHasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertPrimaNeta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertGastos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertIva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DPrimas = New DevExpress.XtraTab.XtraTabPage
        Me.btnImprimirPrimasPend = New DevExpress.XtraEditors.SimpleButton
        Me.PivotFacturas = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.ColNumFactura = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColProducto = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColRamo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColTipoSeguro = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColAseguradora = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColPoliza = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColTipoFactura = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColFechaPago = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColCuota = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColRangoMora = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColPrima = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColGastos = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColImpuestos = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColTotal = New DevExpress.XtraPivotGrid.PivotGridField
        Me.EAvisosCobro = New DevExpress.XtraTab.XtraTabPage
        Me.GridAvisosCobro = New STIControles.stiGrid
        Me.mnuAvisoCobro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConsultarAvisoDeCobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VistaAvisosCobro = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdAvisoCobro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaDesde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaHasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdAnexo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FSiniestros = New DevExpress.XtraTab.XtraTabPage
        Me.GridSiniestros = New STIControles.stiGrid
        Me.VistaSiniestros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSinProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinReclamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinFecOcurre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinValorPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinValorPagado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSinIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GEstadoCuenta = New DevExpress.XtraTab.XtraTabPage
        Me.btnDetalleFacturasEstadoCuenta = New DevExpress.XtraEditors.SimpleButton
        Me.chkTodasFactEstadoCuenta = New DevExpress.XtraEditors.CheckEdit
        Me.txtLstFacturas = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.PivotEstado = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.HDeposito = New DevExpress.XtraTab.XtraTabPage
        Me.GridDepositos = New STIControles.stiGrid
        Me.VistaDepositos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdAseguradoraDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColSaldoDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.IFacturas = New DevExpress.XtraTab.XtraTabPage
        Me.btnImpDetFacturas = New DevExpress.XtraEditors.SimpleButton
        Me.gridDetFacturas = New STIControles.stiGrid
        Me.mnuGestion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarGestiónCarteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarGestiónDeCarteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.vistaDetFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colVigenciaDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColProductoDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColAseguradoraDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroFacturaDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaVencimientoDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPolizaDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColTotalDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColEstadoDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferenciaDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProductoDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColIdRamoDF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColSaldoFact = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDFFechaPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDFFechaAnula = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StiTextBox1 = New STIControles.stiTextBox
        Me.StiMemo2 = New STIControles.stiMemo
        Me.StiTextBox2 = New STIControles.stiTextBox
        Me.StiMemo3 = New STIControles.stiMemo
        Me.StiTextBox3 = New STIControles.stiTextBox
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.StiTextBox4 = New STIControles.stiTextBox
        Me.StiTextBox5 = New STIControles.stiTextBox
        Me.StiTextBox6 = New STIControles.stiTextBox
        Me.StiTextBox7 = New STIControles.stiTextBox
        Me.StiTextBox8 = New STIControles.stiTextBox
        Me.StiTextBox9 = New STIControles.stiTextBox
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.lblEstado = New DevExpress.XtraEditors.LabelControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.AGeneral.SuspendLayout()
        CType(Me.TabClientesInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabClientesInfo.SuspendLayout()
        Me.TabClientesContactos.SuspendLayout()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabClientesEjectivos.SuspendLayout()
        CType(Me.GridEjecutivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEjecutivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGridEjecutivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGridRamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGridTipoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabClientesDocumentos.SuspendLayout()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCliNatural.SuspendLayout()
        CType(Me.gridDatosNat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDatosNat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCliJuridica.SuspendLayout()
        CType(Me.gridDatJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDatJuridica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JCliNatural.SuspendLayout()
        Me.KCliEmpresa.SuspendLayout()
        Me.CPolizas.SuspendLayout()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JCertificados.SuspendLayout()
        CType(Me.GridCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DPrimas.SuspendLayout()
        CType(Me.PivotFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EAvisosCobro.SuspendLayout()
        CType(Me.GridAvisosCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAvisoCobro.SuspendLayout()
        CType(Me.VistaAvisosCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FSiniestros.SuspendLayout()
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GEstadoCuenta.SuspendLayout()
        CType(Me.chkTodasFactEstadoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HDeposito.SuspendLayout()
        CType(Me.GridDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IFacturas.SuspendLayout()
        CType(Me.gridDetFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuGestion.SuspendLayout()
        CType(Me.vistaDetFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(601, 620)
        Me.btnAyuda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(417, 620)
        Me.btnBuscar.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(139, 620)
        Me.btnNuevo.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(231, 620)
        Me.btnGuardar.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(693, 620)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(509, 620)
        Me.btnEliminar.TabIndex = 4
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
        Me.lblNombreFormulario.Location = New System.Drawing.Point(124, 1)
        Me.lblNombreFormulario.Size = New System.Drawing.Size(664, 74)
        Me.lblNombreFormulario.TabIndex = 7
        Me.lblNombreFormulario.Text = "Registro de Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Size = New System.Drawing.Size(123, 74)
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(324, 620)
        '
        'ColDiasMora
        '
        Me.ColDiasMora.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColDiasMora.AreaIndex = 5
        Me.ColDiasMora.Caption = "Días Mora"
        Me.ColDiasMora.FieldName = "Dias"
        Me.ColDiasMora.Name = "ColDiasMora"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField11.AreaIndex = 4
        Me.PivotGridField11.Caption = "Días Mora"
        Me.PivotGridField11.FieldName = "Dias"
        Me.PivotGridField11.Name = "PivotGridField11"
        Me.PivotGridField11.Width = 90
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 81)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.AGeneral
        Me.XtraTabControl1.Size = New System.Drawing.Size(786, 537)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.AGeneral, Me.JCliNatural, Me.KCliEmpresa, Me.CPolizas, Me.JCertificados, Me.DPrimas, Me.EAvisosCobro, Me.FSiniestros, Me.GEstadoCuenta, Me.HDeposito, Me.IFacturas})
        '
        'AGeneral
        '
        Me.AGeneral.Controls.Add(Me.cboReferidoPor)
        Me.AGeneral.Controls.Add(Me.txtNombreCuentaHabiente)
        Me.AGeneral.Controls.Add(Me.txtCuentaBancaria)
        Me.AGeneral.Controls.Add(Me.txtConocidoPor)
        Me.AGeneral.Controls.Add(Me.txtEmisorTarjeta)
        Me.AGeneral.Controls.Add(Me.cboEstadoCliente)
        Me.AGeneral.Controls.Add(Me.cboIdBanco)
        Me.AGeneral.Controls.Add(Me.txtFnacRepLegal)
        Me.AGeneral.Controls.Add(Me.TabClientesInfo)
        Me.AGeneral.Controls.Add(Me.StiTextBox10)
        Me.AGeneral.Controls.Add(Me.cboIdTipoPago)
        Me.AGeneral.Controls.Add(Me.txtEnvioFactura)
        Me.AGeneral.Controls.Add(Me.txtVencimientoTarjeta)
        Me.AGeneral.Controls.Add(Me.txtTarjetaHabiente)
        Me.AGeneral.Controls.Add(Me.txtNumeroTarjeta)
        Me.AGeneral.Controls.Add(Me.txtInicialesFlujo)
        Me.AGeneral.Controls.Add(Me.txtFechaVinculacion)
        Me.AGeneral.Controls.Add(Me.txtTelRepLegal)
        Me.AGeneral.Controls.Add(Me.txtNitRepLegal)
        Me.AGeneral.Controls.Add(Me.txtNombreRepLegal)
        Me.AGeneral.Controls.Add(Me.txtLugarTrabajo)
        Me.AGeneral.Controls.Add(Me.cboEjecutivoCta)
        Me.AGeneral.Controls.Add(Me.txtFax)
        Me.AGeneral.Controls.Add(Me.cboIdTipoCliente)
        Me.AGeneral.Controls.Add(Me.txtEmail)
        Me.AGeneral.Controls.Add(Me.txtFechaNacimiento)
        Me.AGeneral.Controls.Add(Me.stiGiro)
        Me.AGeneral.Controls.Add(Me.txtRegistroFiscal)
        Me.AGeneral.Controls.Add(Me.txtDui)
        Me.AGeneral.Controls.Add(Me.txtNombreCliente)
        Me.AGeneral.Controls.Add(Me.txtIdCliente)
        Me.AGeneral.Name = "AGeneral"
        Me.AGeneral.Size = New System.Drawing.Size(777, 506)
        Me.AGeneral.Text = "Datos Generales"
        '
        'cboReferidoPor
        '
        Me.cboReferidoPor.CampoAutoCompletar = 0
        Me.cboReferidoPor.CampoBusqueda = False
        Me.cboReferidoPor.CampoDisplay = 1
        Me.cboReferidoPor.CampoEsLlave = False
        Me.cboReferidoPor.CampoValor = 0
        Me.cboReferidoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboReferidoPor.ControlBackColor = System.Drawing.Color.White
        Me.cboReferidoPor.ControlForeColor = System.Drawing.Color.Black
        Me.cboReferidoPor.FilasVisibles = 483
        Me.cboReferidoPor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboReferidoPor.LabelText = "Referido Por"
        Me.cboReferidoPor.LabelWidth = 125
        Me.cboReferidoPor.Lista = ""
        Me.cboReferidoPor.Location = New System.Drawing.Point(392, 334)
        Me.cboReferidoPor.MostrarBusquedaColumnas = False
        Me.cboReferidoPor.Name = "cboReferidoPor"
        Me.cboReferidoPor.NombreCampo = "ReferidoPor"
        Me.cboReferidoPor.Obligatorio = False
        Me.cboReferidoPor.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboReferidoPor.SelectIndex = 0
        Me.cboReferidoPor.Size = New System.Drawing.Size(379, 20)
        Me.cboReferidoPor.SoloLectura = False
        Me.cboReferidoPor.StringConection = ""
        Me.cboReferidoPor.TabIndex = 30
        Me.cboReferidoPor.TextoNuevoItem = ""
        Me.cboReferidoPor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboReferidoPor.Valor = ""
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
        Me.txtNombreCuentaHabiente.Location = New System.Drawing.Point(392, 311)
        Me.txtNombreCuentaHabiente.MaxLength = 100
        Me.txtNombreCuentaHabiente.Name = "txtNombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.NombreCampo = "NombreCuentaHabiente"
        Me.txtNombreCuentaHabiente.Obligatorio = False
        Me.txtNombreCuentaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCuentaHabiente.Size = New System.Drawing.Size(379, 20)
        Me.txtNombreCuentaHabiente.SoloLectura = False
        Me.txtNombreCuentaHabiente.TabIndex = 29
        Me.txtNombreCuentaHabiente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCuentaHabiente.Valor = ""
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
        Me.txtCuentaBancaria.LabelWidth = 100
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(7, 312)
        Me.txtCuentaBancaria.MaxLength = 50
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.NombreCampo = "CuentaBancaria"
        Me.txtCuentaBancaria.Obligatorio = False
        Me.txtCuentaBancaria.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(379, 20)
        Me.txtCuentaBancaria.SoloLectura = False
        Me.txtCuentaBancaria.TabIndex = 28
        Me.txtCuentaBancaria.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCuentaBancaria.Valor = ""
        '
        'txtConocidoPor
        '
        Me.txtConocidoPor.CampoBusqueda = False
        Me.txtConocidoPor.CampoEsLlave = False
        Me.txtConocidoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtConocidoPor.ControlBackColor = System.Drawing.Color.White
        Me.txtConocidoPor.ControlForeColor = System.Drawing.Color.Black
        Me.txtConocidoPor.FechaActual = False
        Me.txtConocidoPor.Formato = ""
        Me.txtConocidoPor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtConocidoPor.LabelText = "Conocido Por"
        Me.txtConocidoPor.LabelWidth = 100
        Me.txtConocidoPor.Location = New System.Drawing.Point(7, 47)
        Me.txtConocidoPor.MaxLength = 100
        Me.txtConocidoPor.Name = "txtConocidoPor"
        Me.txtConocidoPor.NombreCampo = "ConocidoPor"
        Me.txtConocidoPor.Obligatorio = False
        Me.txtConocidoPor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConocidoPor.Size = New System.Drawing.Size(379, 20)
        Me.txtConocidoPor.SoloLectura = False
        Me.txtConocidoPor.TabIndex = 4
        Me.txtConocidoPor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtConocidoPor.Valor = ""
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
        Me.txtEmisorTarjeta.Location = New System.Drawing.Point(7, 290)
        Me.txtEmisorTarjeta.MaxLength = 50
        Me.txtEmisorTarjeta.Name = "txtEmisorTarjeta"
        Me.txtEmisorTarjeta.NombreCampo = "EmisorTarjeta"
        Me.txtEmisorTarjeta.Obligatorio = False
        Me.txtEmisorTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmisorTarjeta.Size = New System.Drawing.Size(379, 20)
        Me.txtEmisorTarjeta.SoloLectura = False
        Me.txtEmisorTarjeta.TabIndex = 24
        Me.txtEmisorTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEmisorTarjeta.Valor = ""
        '
        'cboEstadoCliente
        '
        Me.cboEstadoCliente.CampoAutoCompletar = 0
        Me.cboEstadoCliente.CampoBusqueda = False
        Me.cboEstadoCliente.CampoDisplay = 1
        Me.cboEstadoCliente.CampoEsLlave = False
        Me.cboEstadoCliente.CampoValor = 0
        Me.cboEstadoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoCliente.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoCliente.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoCliente.FilasVisibles = 302
        Me.cboEstadoCliente.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoCliente.LabelText = "Estado Cliente"
        Me.cboEstadoCliente.LabelWidth = 85
        Me.cboEstadoCliente.Lista = ""
        Me.cboEstadoCliente.Location = New System.Drawing.Point(527, 3)
        Me.cboEstadoCliente.MostrarBusquedaColumnas = False
        Me.cboEstadoCliente.Name = "cboEstadoCliente"
        Me.cboEstadoCliente.NombreCampo = "EstadoCliente"
        Me.cboEstadoCliente.Obligatorio = False
        Me.cboEstadoCliente.Query = ""
        Me.cboEstadoCliente.SelectIndex = 0
        Me.cboEstadoCliente.Size = New System.Drawing.Size(244, 20)
        Me.cboEstadoCliente.SoloLectura = False
        Me.cboEstadoCliente.StringConection = ""
        Me.cboEstadoCliente.TabIndex = 2
        Me.cboEstadoCliente.TextoNuevoItem = ""
        Me.cboEstadoCliente.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoCliente.Valor = ""
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
        Me.cboIdBanco.FilasVisibles = 302
        Me.cboIdBanco.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdBanco.LabelText = "Banco Cliente"
        Me.cboIdBanco.LabelWidth = 125
        Me.cboIdBanco.Lista = ""
        Me.cboIdBanco.Location = New System.Drawing.Point(392, 289)
        Me.cboIdBanco.MostrarBusquedaColumnas = False
        Me.cboIdBanco.Name = "cboIdBanco"
        Me.cboIdBanco.NombreCampo = "IdBanco"
        Me.cboIdBanco.Obligatorio = False
        Me.cboIdBanco.Query = "select IdBanco as Id, NombreBanco as Banco from Bancos"
        Me.cboIdBanco.SelectIndex = 0
        Me.cboIdBanco.Size = New System.Drawing.Size(379, 20)
        Me.cboIdBanco.SoloLectura = False
        Me.cboIdBanco.StringConection = ""
        Me.cboIdBanco.TabIndex = 25
        Me.cboIdBanco.TextoNuevoItem = ""
        Me.cboIdBanco.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdBanco.Valor = ""
        '
        'txtFnacRepLegal
        '
        Me.txtFnacRepLegal.CampoBusqueda = False
        Me.txtFnacRepLegal.CampoEsLlave = False
        Me.txtFnacRepLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFnacRepLegal.ControlBackColor = System.Drawing.Color.White
        Me.txtFnacRepLegal.ControlForeColor = System.Drawing.Color.Black
        Me.txtFnacRepLegal.FechaActual = False
        Me.txtFnacRepLegal.Formato = "dd/MMM/yyyy"
        Me.txtFnacRepLegal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFnacRepLegal.LabelText = "F. Nac. Rep. Legal"
        Me.txtFnacRepLegal.LabelWidth = 125
        Me.txtFnacRepLegal.Location = New System.Drawing.Point(393, 179)
        Me.txtFnacRepLegal.MaxLength = 0
        Me.txtFnacRepLegal.Name = "txtFnacRepLegal"
        Me.txtFnacRepLegal.NombreCampo = "FnacRepLegal"
        Me.txtFnacRepLegal.Obligatorio = False
        Me.txtFnacRepLegal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFnacRepLegal.Size = New System.Drawing.Size(379, 20)
        Me.txtFnacRepLegal.SoloLectura = False
        Me.txtFnacRepLegal.TabIndex = 15
        Me.txtFnacRepLegal.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFnacRepLegal.Valor = Nothing
        '
        'TabClientesInfo
        '
        Me.TabClientesInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabClientesInfo.Location = New System.Drawing.Point(7, 356)
        Me.TabClientesInfo.Name = "TabClientesInfo"
        Me.TabClientesInfo.SelectedTabPage = Me.TabClientesContactos
        Me.TabClientesInfo.Size = New System.Drawing.Size(766, 147)
        Me.TabClientesInfo.TabIndex = 27
        Me.TabClientesInfo.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabClientesContactos, Me.TabClientesEjectivos, Me.TabClientesDocumentos, Me.TabCliNatural, Me.TabCliJuridica})
        '
        'TabClientesContactos
        '
        Me.TabClientesContactos.Controls.Add(Me.btnAgregar)
        Me.TabClientesContactos.Controls.Add(Me.btnQuitar)
        Me.TabClientesContactos.Controls.Add(Me.StiGrid1)
        Me.TabClientesContactos.Name = "TabClientesContactos"
        Me.TabClientesContactos.Size = New System.Drawing.Size(757, 116)
        Me.TabClientesContactos.Text = "Contactos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(567, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Location = New System.Drawing.Point(665, 3)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitar.TabIndex = 21
        Me.btnQuitar.Text = "Quitar"
        '
        'StiGrid1
        '
        Me.StiGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid1.ColumnasAdicionales = ""
        Me.StiGrid1.Location = New System.Drawing.Point(3, 32)
        Me.StiGrid1.MainView = Me.GridView1
        Me.StiGrid1.Name = "StiGrid1"
        Me.StiGrid1.NombreTabla = "ClientesContactos"
        Me.StiGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1})
        Me.StiGrid1.Size = New System.Drawing.Size(751, 84)
        Me.StiGrid1.TabIndex = 22
        Me.StiGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCliente, Me.colIdContacto, Me.colNombre, Me.colTelefono, Me.colDireccion, Me.colCiudad, Me.colCargo, Me.colUsoCorrespondencia, Me.colFechaNacimiento, Me.colEMail, Me.GridColumn1})
        Me.GridView1.GridControl = Me.StiGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIdCliente
        '
        Me.colIdCliente.Caption = "IdCliente"
        Me.colIdCliente.FieldName = "IdCliente"
        Me.colIdCliente.Name = "colIdCliente"
        '
        'colIdContacto
        '
        Me.colIdContacto.Caption = "IdContacto"
        Me.colIdContacto.FieldName = "IdContacto"
        Me.colIdContacto.Name = "colIdContacto"
        '
        'colNombre
        '
        Me.colNombre.Caption = "Contacto"
        Me.colNombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 137
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "Teléfono"
        Me.colTelefono.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 3
        Me.colTelefono.Width = 64
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "Dirección"
        Me.colDireccion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 5
        Me.colDireccion.Width = 143
        '
        'colCiudad
        '
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        Me.colCiudad.Visible = True
        Me.colCiudad.VisibleIndex = 6
        Me.colCiudad.Width = 88
        '
        'colCargo
        '
        Me.colCargo.Caption = "Cargo"
        Me.colCargo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCargo.FieldName = "Cargo"
        Me.colCargo.Name = "colCargo"
        Me.colCargo.Visible = True
        Me.colCargo.VisibleIndex = 2
        Me.colCargo.Width = 101
        '
        'colUsoCorrespondencia
        '
        Me.colUsoCorrespondencia.Caption = "Uso Correspondencia"
        Me.colUsoCorrespondencia.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colUsoCorrespondencia.FieldName = "UsoCorrespondencia"
        Me.colUsoCorrespondencia.Name = "colUsoCorrespondencia"
        Me.colUsoCorrespondencia.Visible = True
        Me.colUsoCorrespondencia.VisibleIndex = 0
        Me.colUsoCorrespondencia.Width = 60
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colFechaNacimiento
        '
        Me.colFechaNacimiento.Caption = "Fecha Nacimiento"
        Me.colFechaNacimiento.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaNacimiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaNacimiento.FieldName = "FechaNacimiento"
        Me.colFechaNacimiento.Name = "colFechaNacimiento"
        Me.colFechaNacimiento.Visible = True
        Me.colFechaNacimiento.VisibleIndex = 7
        '
        'colEMail
        '
        Me.colEMail.Caption = "Correo Electrónico"
        Me.colEMail.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colEMail.FieldName = "EMail"
        Me.colEMail.Name = "colEMail"
        Me.colEMail.Visible = True
        Me.colEMail.VisibleIndex = 4
        Me.colEMail.Width = 70
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Funciones"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "Funciones"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 8
        '
        'TabClientesEjectivos
        '
        Me.TabClientesEjectivos.Controls.Add(Me.GridEjecutivos)
        Me.TabClientesEjectivos.Controls.Add(Me.btnAgregarEjecutivo)
        Me.TabClientesEjectivos.Controls.Add(Me.btnEliminarEjecutivo)
        Me.TabClientesEjectivos.Name = "TabClientesEjectivos"
        Me.TabClientesEjectivos.Size = New System.Drawing.Size(757, 116)
        Me.TabClientesEjectivos.Text = "Ejecutivos de Cuenta"
        '
        'GridEjecutivos
        '
        Me.GridEjecutivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEjecutivos.ColumnasAdicionales = ""
        Me.GridEjecutivos.Location = New System.Drawing.Point(3, 32)
        Me.GridEjecutivos.MainView = Me.VistaEjecutivos
        Me.GridEjecutivos.Name = "GridEjecutivos"
        Me.GridEjecutivos.NombreTabla = "ClientesEjecutivos"
        Me.GridEjecutivos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGridEjecutivo, Me.cboGridRamo, Me.cboGridTipoProducto, Me.cboGridArea})
        Me.GridEjecutivos.Size = New System.Drawing.Size(756, 82)
        Me.GridEjecutivos.TabIndex = 24
        Me.GridEjecutivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaEjecutivos})
        '
        'VistaEjecutivos
        '
        Me.VistaEjecutivos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCliente2, Me.colOrden, Me.colIdEjecutivo, Me.colIdRamo, Me.colTipoProducto, Me.colIdArea})
        Me.VistaEjecutivos.GridControl = Me.GridEjecutivos
        Me.VistaEjecutivos.Name = "VistaEjecutivos"
        Me.VistaEjecutivos.OptionsView.ShowGroupPanel = False
        '
        'colIdCliente2
        '
        Me.colIdCliente2.Caption = "IdCliente"
        Me.colIdCliente2.FieldName = "IdCliente"
        Me.colIdCliente2.Name = "colIdCliente2"
        '
        'colOrden
        '
        Me.colOrden.Caption = "Orden"
        Me.colOrden.FieldName = "Orden"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 0
        Me.colOrden.Width = 46
        '
        'colIdEjecutivo
        '
        Me.colIdEjecutivo.Caption = "Nombre del Ejecutivo"
        Me.colIdEjecutivo.ColumnEdit = Me.cboGridEjecutivo
        Me.colIdEjecutivo.FieldName = "IdEjecutivo"
        Me.colIdEjecutivo.Name = "colIdEjecutivo"
        Me.colIdEjecutivo.Visible = True
        Me.colIdEjecutivo.VisibleIndex = 1
        Me.colIdEjecutivo.Width = 241
        '
        'cboGridEjecutivo
        '
        Me.cboGridEjecutivo.AutoHeight = False
        Me.cboGridEjecutivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridEjecutivo.Name = "cboGridEjecutivo"
        Me.cboGridEjecutivo.NullText = ""
        '
        'colIdRamo
        '
        Me.colIdRamo.Caption = "Ramo que Administra"
        Me.colIdRamo.ColumnEdit = Me.cboGridRamo
        Me.colIdRamo.FieldName = "IdRamo"
        Me.colIdRamo.Name = "colIdRamo"
        Me.colIdRamo.Visible = True
        Me.colIdRamo.VisibleIndex = 2
        Me.colIdRamo.Width = 149
        '
        'cboGridRamo
        '
        Me.cboGridRamo.AutoHeight = False
        Me.cboGridRamo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridRamo.Name = "cboGridRamo"
        Me.cboGridRamo.NullText = ""
        '
        'colTipoProducto
        '
        Me.colTipoProducto.Caption = "Tipo Producto Administra"
        Me.colTipoProducto.ColumnEdit = Me.cboGridTipoProducto
        Me.colTipoProducto.FieldName = "TipoProducto"
        Me.colTipoProducto.Name = "colTipoProducto"
        Me.colTipoProducto.Visible = True
        Me.colTipoProducto.VisibleIndex = 3
        Me.colTipoProducto.Width = 149
        '
        'cboGridTipoProducto
        '
        Me.cboGridTipoProducto.AutoHeight = False
        Me.cboGridTipoProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridTipoProducto.Name = "cboGridTipoProducto"
        Me.cboGridTipoProducto.NullText = ""
        '
        'colIdArea
        '
        Me.colIdArea.Caption = "Área Administra"
        Me.colIdArea.ColumnEdit = Me.cboGridArea
        Me.colIdArea.FieldName = "IdArea"
        Me.colIdArea.Name = "colIdArea"
        Me.colIdArea.Visible = True
        Me.colIdArea.VisibleIndex = 4
        Me.colIdArea.Width = 150
        '
        'cboGridArea
        '
        Me.cboGridArea.AutoHeight = False
        Me.cboGridArea.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGridArea.Name = "cboGridArea"
        Me.cboGridArea.NullText = ""
        '
        'btnAgregarEjecutivo
        '
        Me.btnAgregarEjecutivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarEjecutivo.Location = New System.Drawing.Point(569, 3)
        Me.btnAgregarEjecutivo.Name = "btnAgregarEjecutivo"
        Me.btnAgregarEjecutivo.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregarEjecutivo.TabIndex = 22
        Me.btnAgregarEjecutivo.Text = "Agregar"
        '
        'btnEliminarEjecutivo
        '
        Me.btnEliminarEjecutivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarEjecutivo.Location = New System.Drawing.Point(667, 3)
        Me.btnEliminarEjecutivo.Name = "btnEliminarEjecutivo"
        Me.btnEliminarEjecutivo.Size = New System.Drawing.Size(92, 23)
        Me.btnEliminarEjecutivo.TabIndex = 23
        Me.btnEliminarEjecutivo.Text = "Quitar"
        '
        'TabClientesDocumentos
        '
        Me.TabClientesDocumentos.Controls.Add(Me.btnAgregarCarpeta)
        Me.TabClientesDocumentos.Controls.Add(Me.btnQuitarDoc)
        Me.TabClientesDocumentos.Controls.Add(Me.btnAgregarDoc)
        Me.TabClientesDocumentos.Controls.Add(Me.GridDoc)
        Me.TabClientesDocumentos.Name = "TabClientesDocumentos"
        Me.TabClientesDocumentos.Size = New System.Drawing.Size(757, 116)
        Me.TabClientesDocumentos.Text = "Documentos"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(652, 41)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarCarpeta.TabIndex = 26
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(652, 76)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDoc.TabIndex = 25
        Me.btnQuitarDoc.Text = "Quitar"
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(652, 4)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarDoc.TabIndex = 24
        Me.btnAgregarDoc.Text = "Agregar Archivo"
        '
        'GridDoc
        '
        Me.GridDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDoc.ColumnasAdicionales = ""
        Me.GridDoc.Location = New System.Drawing.Point(3, 4)
        Me.GridDoc.MainView = Me.VistaDoc
        Me.GridDoc.Name = "GridDoc"
        Me.GridDoc.NombreTabla = "ClientesDocumentos"
        Me.GridDoc.Size = New System.Drawing.Size(627, 107)
        Me.GridDoc.TabIndex = 1
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
        Me.VistaDoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.ColDoc, Me.colDocumento, Me.ColArchivo, Me.ColDirectorio})
        Me.VistaDoc.GridControl = Me.GridDoc
        Me.VistaDoc.Name = "VistaDoc"
        Me.VistaDoc.OptionsBehavior.AutoExpandAllGroups = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Cliente"
        Me.GridColumn2.FieldName = "IdCliente"
        Me.GridColumn2.Name = "GridColumn2"
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
        'TabCliNatural
        '
        Me.TabCliNatural.Controls.Add(Me.gridDatosNat)
        Me.TabCliNatural.Name = "TabCliNatural"
        Me.TabCliNatural.Size = New System.Drawing.Size(757, 116)
        Me.TabCliNatural.Text = "Datos Persona Natural"
        '
        'gridDatosNat
        '
        Me.gridDatosNat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatosNat.ColumnasAdicionales = ""
        Me.gridDatosNat.Location = New System.Drawing.Point(3, 3)
        Me.gridDatosNat.MainView = Me.VistaDatosNat
        Me.gridDatosNat.Name = "gridDatosNat"
        Me.gridDatosNat.NombreTabla = "ClientesCamposNatural"
        Me.gridDatosNat.Size = New System.Drawing.Size(751, 108)
        Me.gridDatosNat.TabIndex = 0
        Me.gridDatosNat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDatosNat})
        '
        'VistaDatosNat
        '
        Me.VistaDatosNat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDNIdCliente, Me.colDNIdCampo, Me.colDNNombre, Me.colDNDescripcion})
        Me.VistaDatosNat.GridControl = Me.gridDatosNat
        Me.VistaDatosNat.Name = "VistaDatosNat"
        Me.VistaDatosNat.OptionsView.ShowGroupPanel = False
        '
        'colDNIdCliente
        '
        Me.colDNIdCliente.Caption = "IdCliente"
        Me.colDNIdCliente.FieldName = "IdCliente"
        Me.colDNIdCliente.Name = "colDNIdCliente"
        Me.colDNIdCliente.OptionsColumn.AllowEdit = False
        '
        'colDNIdCampo
        '
        Me.colDNIdCampo.Caption = "IdCampo"
        Me.colDNIdCampo.FieldName = "IdCampo"
        Me.colDNIdCampo.Name = "colDNIdCampo"
        Me.colDNIdCampo.OptionsColumn.AllowEdit = False
        '
        'colDNNombre
        '
        Me.colDNNombre.Caption = "Campo Personalizado"
        Me.colDNNombre.FieldName = "Nombre"
        Me.colDNNombre.Name = "colDNNombre"
        Me.colDNNombre.OptionsColumn.AllowEdit = False
        Me.colDNNombre.Visible = True
        Me.colDNNombre.VisibleIndex = 0
        Me.colDNNombre.Width = 165
        '
        'colDNDescripcion
        '
        Me.colDNDescripcion.Caption = "Descripción"
        Me.colDNDescripcion.FieldName = "Descripcion"
        Me.colDNDescripcion.Name = "colDNDescripcion"
        Me.colDNDescripcion.Visible = True
        Me.colDNDescripcion.VisibleIndex = 1
        Me.colDNDescripcion.Width = 565
        '
        'TabCliJuridica
        '
        Me.TabCliJuridica.Controls.Add(Me.gridDatJuridica)
        Me.TabCliJuridica.Name = "TabCliJuridica"
        Me.TabCliJuridica.Size = New System.Drawing.Size(757, 116)
        Me.TabCliJuridica.Text = "Datos Persona Jurídica"
        '
        'gridDatJuridica
        '
        Me.gridDatJuridica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatJuridica.ColumnasAdicionales = ""
        Me.gridDatJuridica.Location = New System.Drawing.Point(3, 3)
        Me.gridDatJuridica.MainView = Me.VistaDatJuridica
        Me.gridDatJuridica.Name = "gridDatJuridica"
        Me.gridDatJuridica.NombreTabla = "ClientesCamposJuridica"
        Me.gridDatJuridica.Size = New System.Drawing.Size(751, 108)
        Me.gridDatJuridica.TabIndex = 0
        Me.gridDatJuridica.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDatJuridica})
        '
        'VistaDatJuridica
        '
        Me.VistaDatJuridica.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDJIdCliente, Me.colIdCampo, Me.colDJNombre, Me.colDJDescripcion})
        Me.VistaDatJuridica.GridControl = Me.gridDatJuridica
        Me.VistaDatJuridica.Name = "VistaDatJuridica"
        Me.VistaDatJuridica.OptionsView.ShowGroupPanel = False
        '
        'colDJIdCliente
        '
        Me.colDJIdCliente.Caption = "IdCliente"
        Me.colDJIdCliente.FieldName = "IdCliente"
        Me.colDJIdCliente.Name = "colDJIdCliente"
        Me.colDJIdCliente.OptionsColumn.AllowEdit = False
        '
        'colIdCampo
        '
        Me.colIdCampo.Caption = "IdCampo"
        Me.colIdCampo.FieldName = "IdCampo"
        Me.colIdCampo.Name = "colIdCampo"
        Me.colIdCampo.OptionsColumn.AllowEdit = False
        '
        'colDJNombre
        '
        Me.colDJNombre.Caption = "Campo Personalizado"
        Me.colDJNombre.FieldName = "Nombre"
        Me.colDJNombre.Name = "colDJNombre"
        Me.colDJNombre.OptionsColumn.AllowEdit = False
        Me.colDJNombre.Visible = True
        Me.colDJNombre.VisibleIndex = 0
        Me.colDJNombre.Width = 164
        '
        'colDJDescripcion
        '
        Me.colDJDescripcion.Caption = "Descripción"
        Me.colDJDescripcion.FieldName = "Descripcion"
        Me.colDJDescripcion.Name = "colDJDescripcion"
        Me.colDJDescripcion.Visible = True
        Me.colDJDescripcion.VisibleIndex = 1
        Me.colDJDescripcion.Width = 566
        '
        'StiTextBox10
        '
        Me.StiTextBox10.CampoBusqueda = False
        Me.StiTextBox10.CampoEsLlave = False
        Me.StiTextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox10.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox10.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox10.FechaActual = False
        Me.StiTextBox10.Formato = ""
        Me.StiTextBox10.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox10.LabelText = "Grupo del Cliente"
        Me.StiTextBox10.LabelWidth = 125
        Me.StiTextBox10.Location = New System.Drawing.Point(392, 267)
        Me.StiTextBox10.MaxLength = 100
        Me.StiTextBox10.Name = "StiTextBox10"
        Me.StiTextBox10.NombreCampo = "GrupoCliente"
        Me.StiTextBox10.Obligatorio = False
        Me.StiTextBox10.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox10.Size = New System.Drawing.Size(379, 20)
        Me.StiTextBox10.SoloLectura = False
        Me.StiTextBox10.TabIndex = 23
        Me.StiTextBox10.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox10.Valor = ""
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
        Me.cboIdTipoPago.FilasVisibles = 302
        Me.cboIdTipoPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdTipoPago.LabelText = "Forma de Pago"
        Me.cboIdTipoPago.LabelWidth = 125
        Me.cboIdTipoPago.Lista = ""
        Me.cboIdTipoPago.Location = New System.Drawing.Point(392, 223)
        Me.cboIdTipoPago.MostrarBusquedaColumnas = False
        Me.cboIdTipoPago.Name = "cboIdTipoPago"
        Me.cboIdTipoPago.NombreCampo = "IdTipoPago"
        Me.cboIdTipoPago.Obligatorio = False
        Me.cboIdTipoPago.Query = "select IdTipoPago as Id, Descripcion as [Forma Pago] from FormasPagoTipo"
        Me.cboIdTipoPago.SelectIndex = 0
        Me.cboIdTipoPago.Size = New System.Drawing.Size(379, 20)
        Me.cboIdTipoPago.SoloLectura = False
        Me.cboIdTipoPago.StringConection = ""
        Me.cboIdTipoPago.TabIndex = 19
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
        Me.txtEnvioFactura.Location = New System.Drawing.Point(392, 245)
        Me.txtEnvioFactura.MaxLength = 150
        Me.txtEnvioFactura.Name = "txtEnvioFactura"
        Me.txtEnvioFactura.NombreCampo = "EnvioFactura"
        Me.txtEnvioFactura.Obligatorio = False
        Me.txtEnvioFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnvioFactura.Size = New System.Drawing.Size(379, 20)
        Me.txtEnvioFactura.SoloLectura = False
        Me.txtEnvioFactura.TabIndex = 21
        Me.txtEnvioFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEnvioFactura.Valor = ""
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
        Me.txtVencimientoTarjeta.Location = New System.Drawing.Point(7, 267)
        Me.txtVencimientoTarjeta.MaxLength = 50
        Me.txtVencimientoTarjeta.Name = "txtVencimientoTarjeta"
        Me.txtVencimientoTarjeta.NombreCampo = "VencimientoTarjeta"
        Me.txtVencimientoTarjeta.Obligatorio = False
        Me.txtVencimientoTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVencimientoTarjeta.Size = New System.Drawing.Size(379, 20)
        Me.txtVencimientoTarjeta.SoloLectura = False
        Me.txtVencimientoTarjeta.TabIndex = 22
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
        Me.txtTarjetaHabiente.Location = New System.Drawing.Point(7, 223)
        Me.txtTarjetaHabiente.MaxLength = 150
        Me.txtTarjetaHabiente.Name = "txtTarjetaHabiente"
        Me.txtTarjetaHabiente.NombreCampo = "TarjetaHabiente"
        Me.txtTarjetaHabiente.Obligatorio = False
        Me.txtTarjetaHabiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarjetaHabiente.Size = New System.Drawing.Size(379, 20)
        Me.txtTarjetaHabiente.SoloLectura = False
        Me.txtTarjetaHabiente.TabIndex = 18
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
        Me.txtNumeroTarjeta.Location = New System.Drawing.Point(7, 245)
        Me.txtNumeroTarjeta.MaxLength = 25
        Me.txtNumeroTarjeta.Name = "txtNumeroTarjeta"
        Me.txtNumeroTarjeta.NombreCampo = "NumeroTarjeta"
        Me.txtNumeroTarjeta.Obligatorio = False
        Me.txtNumeroTarjeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroTarjeta.Size = New System.Drawing.Size(379, 20)
        Me.txtNumeroTarjeta.SoloLectura = False
        Me.txtNumeroTarjeta.TabIndex = 20
        Me.txtNumeroTarjeta.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroTarjeta.Valor = ""
        '
        'txtInicialesFlujo
        '
        Me.txtInicialesFlujo.CampoBusqueda = False
        Me.txtInicialesFlujo.CampoEsLlave = False
        Me.txtInicialesFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtInicialesFlujo.ControlBackColor = System.Drawing.Color.White
        Me.txtInicialesFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.txtInicialesFlujo.FechaActual = False
        Me.txtInicialesFlujo.Formato = ""
        Me.txtInicialesFlujo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtInicialesFlujo.LabelText = "Iniciales Flujo Corresp."
        Me.txtInicialesFlujo.LabelWidth = 125
        Me.txtInicialesFlujo.Location = New System.Drawing.Point(392, 201)
        Me.txtInicialesFlujo.MaxLength = 10
        Me.txtInicialesFlujo.Name = "txtInicialesFlujo"
        Me.txtInicialesFlujo.NombreCampo = "InicialesFlujo"
        Me.txtInicialesFlujo.Obligatorio = False
        Me.txtInicialesFlujo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInicialesFlujo.Size = New System.Drawing.Size(379, 20)
        Me.txtInicialesFlujo.SoloLectura = False
        Me.txtInicialesFlujo.TabIndex = 17
        Me.txtInicialesFlujo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtInicialesFlujo.Valor = ""
        '
        'txtFechaVinculacion
        '
        Me.txtFechaVinculacion.CampoBusqueda = False
        Me.txtFechaVinculacion.CampoEsLlave = False
        Me.txtFechaVinculacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaVinculacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaVinculacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaVinculacion.FechaActual = False
        Me.txtFechaVinculacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaVinculacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaVinculacion.LabelText = "Fecha Vinculación"
        Me.txtFechaVinculacion.LabelWidth = 100
        Me.txtFechaVinculacion.Location = New System.Drawing.Point(7, 201)
        Me.txtFechaVinculacion.MaxLength = 0
        Me.txtFechaVinculacion.Name = "txtFechaVinculacion"
        Me.txtFechaVinculacion.NombreCampo = "FechaVinculacion"
        Me.txtFechaVinculacion.Obligatorio = False
        Me.txtFechaVinculacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaVinculacion.Size = New System.Drawing.Size(379, 20)
        Me.txtFechaVinculacion.SoloLectura = False
        Me.txtFechaVinculacion.TabIndex = 16
        Me.txtFechaVinculacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaVinculacion.Valor = Nothing
        '
        'txtTelRepLegal
        '
        Me.txtTelRepLegal.CampoBusqueda = False
        Me.txtTelRepLegal.CampoEsLlave = False
        Me.txtTelRepLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTelRepLegal.ControlBackColor = System.Drawing.Color.White
        Me.txtTelRepLegal.ControlForeColor = System.Drawing.Color.Black
        Me.txtTelRepLegal.FechaActual = False
        Me.txtTelRepLegal.Formato = ""
        Me.txtTelRepLegal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTelRepLegal.LabelText = "Telefono Rep. Legal"
        Me.txtTelRepLegal.LabelWidth = 100
        Me.txtTelRepLegal.Location = New System.Drawing.Point(7, 179)
        Me.txtTelRepLegal.MaxLength = 25
        Me.txtTelRepLegal.Name = "txtTelRepLegal"
        Me.txtTelRepLegal.NombreCampo = "TelRepLegal"
        Me.txtTelRepLegal.Obligatorio = False
        Me.txtTelRepLegal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelRepLegal.Size = New System.Drawing.Size(379, 20)
        Me.txtTelRepLegal.SoloLectura = False
        Me.txtTelRepLegal.TabIndex = 14
        Me.txtTelRepLegal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTelRepLegal.Valor = ""
        '
        'txtNitRepLegal
        '
        Me.txtNitRepLegal.CampoBusqueda = False
        Me.txtNitRepLegal.CampoEsLlave = False
        Me.txtNitRepLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNitRepLegal.ControlBackColor = System.Drawing.Color.White
        Me.txtNitRepLegal.ControlForeColor = System.Drawing.Color.Black
        Me.txtNitRepLegal.FechaActual = False
        Me.txtNitRepLegal.Formato = ""
        Me.txtNitRepLegal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNitRepLegal.LabelText = "N.I.T. Rep. Legal"
        Me.txtNitRepLegal.LabelWidth = 100
        Me.txtNitRepLegal.Location = New System.Drawing.Point(7, 157)
        Me.txtNitRepLegal.MaxLength = 25
        Me.txtNitRepLegal.Name = "txtNitRepLegal"
        Me.txtNitRepLegal.NombreCampo = "NitRepLegal"
        Me.txtNitRepLegal.Obligatorio = False
        Me.txtNitRepLegal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNitRepLegal.Size = New System.Drawing.Size(379, 20)
        Me.txtNitRepLegal.SoloLectura = False
        Me.txtNitRepLegal.TabIndex = 12
        Me.txtNitRepLegal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNitRepLegal.Valor = ""
        '
        'txtNombreRepLegal
        '
        Me.txtNombreRepLegal.CampoBusqueda = False
        Me.txtNombreRepLegal.CampoEsLlave = False
        Me.txtNombreRepLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreRepLegal.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreRepLegal.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreRepLegal.FechaActual = False
        Me.txtNombreRepLegal.Formato = ""
        Me.txtNombreRepLegal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreRepLegal.LabelText = "Representante Legal"
        Me.txtNombreRepLegal.LabelWidth = 125
        Me.txtNombreRepLegal.Location = New System.Drawing.Point(393, 157)
        Me.txtNombreRepLegal.MaxLength = 150
        Me.txtNombreRepLegal.Name = "txtNombreRepLegal"
        Me.txtNombreRepLegal.NombreCampo = "NombreRepLegal"
        Me.txtNombreRepLegal.Obligatorio = False
        Me.txtNombreRepLegal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreRepLegal.Size = New System.Drawing.Size(379, 20)
        Me.txtNombreRepLegal.SoloLectura = False
        Me.txtNombreRepLegal.TabIndex = 13
        Me.txtNombreRepLegal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreRepLegal.Valor = ""
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.CampoBusqueda = False
        Me.txtLugarTrabajo.CampoEsLlave = False
        Me.txtLugarTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLugarTrabajo.ControlBackColor = System.Drawing.Color.White
        Me.txtLugarTrabajo.ControlForeColor = System.Drawing.Color.Black
        Me.txtLugarTrabajo.FechaActual = False
        Me.txtLugarTrabajo.Formato = ""
        Me.txtLugarTrabajo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLugarTrabajo.LabelText = "Lugar Trabajo"
        Me.txtLugarTrabajo.LabelWidth = 100
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(7, 135)
        Me.txtLugarTrabajo.MaxLength = 50
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.NombreCampo = "LugarTrabajo"
        Me.txtLugarTrabajo.Obligatorio = False
        Me.txtLugarTrabajo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(764, 20)
        Me.txtLugarTrabajo.SoloLectura = False
        Me.txtLugarTrabajo.TabIndex = 11
        Me.txtLugarTrabajo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtLugarTrabajo.Valor = ""
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
        Me.cboEjecutivoCta.FilasVisibles = 483
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(7, 334)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = True
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(379, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 26
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'txtFax
        '
        Me.txtFax.CampoBusqueda = False
        Me.txtFax.CampoEsLlave = False
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFax.ControlBackColor = System.Drawing.Color.White
        Me.txtFax.ControlForeColor = System.Drawing.Color.Black
        Me.txtFax.FechaActual = False
        Me.txtFax.Formato = ""
        Me.txtFax.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFax.LabelText = "FAX"
        Me.txtFax.LabelWidth = 125
        Me.txtFax.Location = New System.Drawing.Point(392, 69)
        Me.txtFax.MaxLength = 25
        Me.txtFax.Name = "txtFax"
        Me.txtFax.NombreCampo = "Fax"
        Me.txtFax.Obligatorio = False
        Me.txtFax.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.Size = New System.Drawing.Size(379, 20)
        Me.txtFax.SoloLectura = False
        Me.txtFax.TabIndex = 6
        Me.txtFax.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtFax.Valor = ""
        '
        'cboIdTipoCliente
        '
        Me.cboIdTipoCliente.CampoAutoCompletar = 0
        Me.cboIdTipoCliente.CampoBusqueda = False
        Me.cboIdTipoCliente.CampoDisplay = 1
        Me.cboIdTipoCliente.CampoEsLlave = False
        Me.cboIdTipoCliente.CampoValor = 0
        Me.cboIdTipoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdTipoCliente.ControlBackColor = System.Drawing.Color.White
        Me.cboIdTipoCliente.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdTipoCliente.FilasVisibles = 302
        Me.cboIdTipoCliente.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdTipoCliente.LabelText = "Tipo Cliente"
        Me.cboIdTipoCliente.LabelWidth = 75
        Me.cboIdTipoCliente.Lista = "NA Natural|JU Persona Jurídica|GU Gubernamental|GA Gubernamental Autónoma|JE Pers" & _
            "ona Jurídica Exenta"
        Me.cboIdTipoCliente.Location = New System.Drawing.Point(273, 3)
        Me.cboIdTipoCliente.MostrarBusquedaColumnas = False
        Me.cboIdTipoCliente.Name = "cboIdTipoCliente"
        Me.cboIdTipoCliente.NombreCampo = "IdTipoCliente"
        Me.cboIdTipoCliente.Obligatorio = True
        Me.cboIdTipoCliente.Query = ""
        Me.cboIdTipoCliente.SelectIndex = 0
        Me.cboIdTipoCliente.Size = New System.Drawing.Size(244, 20)
        Me.cboIdTipoCliente.SoloLectura = False
        Me.cboIdTipoCliente.StringConection = ""
        Me.cboIdTipoCliente.TabIndex = 1
        Me.cboIdTipoCliente.TextoNuevoItem = ""
        Me.cboIdTipoCliente.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdTipoCliente.Valor = ""
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
        Me.txtEmail.LabelText = "Correo Electrónico"
        Me.txtEmail.LabelWidth = 125
        Me.txtEmail.Location = New System.Drawing.Point(392, 91)
        Me.txtEmail.MaxLength = 250
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.NombreCampo = "Email"
        Me.txtEmail.Obligatorio = False
        Me.txtEmail.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.Size = New System.Drawing.Size(379, 20)
        Me.txtEmail.SoloLectura = False
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEmail.Valor = ""
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.CampoBusqueda = False
        Me.txtFechaNacimiento.CampoEsLlave = False
        Me.txtFechaNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaNacimiento.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaNacimiento.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaNacimiento.FechaActual = False
        Me.txtFechaNacimiento.Formato = "dd/MMM/yyyy"
        Me.txtFechaNacimiento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaNacimiento.LabelText = "Fecha Nacimiento"
        Me.txtFechaNacimiento.LabelWidth = 100
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(7, 91)
        Me.txtFechaNacimiento.MaxLength = 0
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.NombreCampo = "FechaNacimiento"
        Me.txtFechaNacimiento.Obligatorio = False
        Me.txtFechaNacimiento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(379, 20)
        Me.txtFechaNacimiento.SoloLectura = False
        Me.txtFechaNacimiento.TabIndex = 7
        Me.txtFechaNacimiento.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaNacimiento.Valor = Nothing
        '
        'stiGiro
        '
        Me.stiGiro.CampoBusqueda = False
        Me.stiGiro.CampoEsLlave = False
        Me.stiGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.stiGiro.ControlBackColor = System.Drawing.Color.White
        Me.stiGiro.ControlForeColor = System.Drawing.Color.Black
        Me.stiGiro.FechaActual = False
        Me.stiGiro.Formato = ""
        Me.stiGiro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.stiGiro.LabelText = "Giro"
        Me.stiGiro.LabelWidth = 125
        Me.stiGiro.Location = New System.Drawing.Point(392, 113)
        Me.stiGiro.MaxLength = 150
        Me.stiGiro.Name = "stiGiro"
        Me.stiGiro.NombreCampo = "Giro"
        Me.stiGiro.Obligatorio = False
        Me.stiGiro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stiGiro.Size = New System.Drawing.Size(379, 20)
        Me.stiGiro.SoloLectura = False
        Me.stiGiro.TabIndex = 10
        Me.stiGiro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.stiGiro.Valor = ""
        '
        'txtRegistroFiscal
        '
        Me.txtRegistroFiscal.CampoBusqueda = False
        Me.txtRegistroFiscal.CampoEsLlave = False
        Me.txtRegistroFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRegistroFiscal.ControlBackColor = System.Drawing.Color.White
        Me.txtRegistroFiscal.ControlForeColor = System.Drawing.Color.Black
        Me.txtRegistroFiscal.FechaActual = False
        Me.txtRegistroFiscal.Formato = ""
        Me.txtRegistroFiscal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtRegistroFiscal.LabelText = "Registro Fiscal"
        Me.txtRegistroFiscal.LabelWidth = 100
        Me.txtRegistroFiscal.Location = New System.Drawing.Point(7, 113)
        Me.txtRegistroFiscal.MaxLength = 25
        Me.txtRegistroFiscal.Name = "txtRegistroFiscal"
        Me.txtRegistroFiscal.NombreCampo = "RegistroFiscal"
        Me.txtRegistroFiscal.Obligatorio = False
        Me.txtRegistroFiscal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegistroFiscal.Size = New System.Drawing.Size(379, 20)
        Me.txtRegistroFiscal.SoloLectura = False
        Me.txtRegistroFiscal.TabIndex = 9
        Me.txtRegistroFiscal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRegistroFiscal.Valor = ""
        '
        'txtDui
        '
        Me.txtDui.CampoBusqueda = False
        Me.txtDui.CampoEsLlave = False
        Me.txtDui.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDui.ControlBackColor = System.Drawing.Color.White
        Me.txtDui.ControlForeColor = System.Drawing.Color.Black
        Me.txtDui.FechaActual = False
        Me.txtDui.Formato = ""
        Me.txtDui.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDui.LabelText = "D.U.I."
        Me.txtDui.LabelWidth = 100
        Me.txtDui.Location = New System.Drawing.Point(7, 69)
        Me.txtDui.MaxLength = 25
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NombreCampo = "Dui"
        Me.txtDui.Obligatorio = False
        Me.txtDui.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDui.Size = New System.Drawing.Size(379, 20)
        Me.txtDui.SoloLectura = False
        Me.txtDui.TabIndex = 5
        Me.txtDui.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDui.Valor = ""
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
        Me.txtNombreCliente.Location = New System.Drawing.Point(7, 25)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(764, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 3
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = True
        Me.txtIdCliente.CampoEsLlave = True
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "N.I.T."
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(7, 3)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(260, 20)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 0
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'JCliNatural
        '
        Me.JCliNatural.Appearance.Header.Options.UseTextOptions = True
        Me.JCliNatural.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.JCliNatural.AutoScroll = True
        Me.JCliNatural.Controls.Add(Me.btnImprimirNatural)
        Me.JCliNatural.Controls.Add(Me.txtnat_Comentarios)
        Me.JCliNatural.Controls.Add(Me.LabelControl9)
        Me.JCliNatural.Controls.Add(Me.txtnat_FechaFormulario)
        Me.JCliNatural.Controls.Add(Me.txtnat_CompletaFormulario)
        Me.JCliNatural.Controls.Add(Me.txtnat_Cesion)
        Me.JCliNatural.Controls.Add(Me.txtnat_Bebida)
        Me.JCliNatural.Controls.Add(Me.txtnat_Musica)
        Me.JCliNatural.Controls.Add(Me.txtnat_Comida)
        Me.JCliNatural.Controls.Add(Me.txtnat_Religion)
        Me.JCliNatural.Controls.Add(Me.txtnat_Hobbie)
        Me.JCliNatural.Controls.Add(Me.txtnat_Deporte)
        Me.JCliNatural.Controls.Add(Me.LabelControl8)
        Me.JCliNatural.Controls.Add(Me.cbonat_ClienteExistente)
        Me.JCliNatural.Controls.Add(Me.LabelControl7)
        Me.JCliNatural.Controls.Add(Me.cbonat_PreferenciaPago)
        Me.JCliNatural.Controls.Add(Me.cbonat_PreferenciaCobro)
        Me.JCliNatural.Controls.Add(Me.LabelControl6)
        Me.JCliNatural.Controls.Add(Me.txtnat_EmailTrabajo)
        Me.JCliNatural.Controls.Add(Me.txtnat_PaginaWeb)
        Me.JCliNatural.Controls.Add(Me.txtnat_ContactoCobro)
        Me.JCliNatural.Controls.Add(Me.txtnat_ReferidoPor)
        Me.JCliNatural.Controls.Add(Me.txtnat_MedioInformacion)
        Me.JCliNatural.Controls.Add(Me.txtnat_DireccionTrabajo)
        Me.JCliNatural.Controls.Add(Me.LabelControl5)
        Me.JCliNatural.Controls.Add(Me.LabelControl4)
        Me.JCliNatural.Controls.Add(Me.cbonat_TieneHijos)
        Me.JCliNatural.Controls.Add(Me.txtnat_DireccionCasa)
        Me.JCliNatural.Controls.Add(Me.LabelControl3)
        Me.JCliNatural.Controls.Add(Me.LabelControl2)
        Me.JCliNatural.Controls.Add(Me.txtnat_Profesion)
        Me.JCliNatural.Controls.Add(Me.txtnat_twitter)
        Me.JCliNatural.Controls.Add(Me.txtnat_Facebook)
        Me.JCliNatural.Controls.Add(Me.txtnat_NumHijos)
        Me.JCliNatural.Controls.Add(Me.txtnat_PinBB)
        Me.JCliNatural.Controls.Add(Me.txtnat_FaxTrabajo)
        Me.JCliNatural.Controls.Add(Me.txtnat_TelTrabajo)
        Me.JCliNatural.Controls.Add(Me.txtnat_Cargo)
        Me.JCliNatural.Controls.Add(Me.txtnat_LugarTrabajo)
        Me.JCliNatural.Controls.Add(Me.txtnat_EmailCasa)
        Me.JCliNatural.Controls.Add(Me.txtnat_EstadoCivil)
        Me.JCliNatural.Controls.Add(Me.txtnat_TelMovil)
        Me.JCliNatural.Controls.Add(Me.txtnat_TelCasa)
        Me.JCliNatural.Controls.Add(Me.txtnat_NombreCliente)
        Me.JCliNatural.Name = "JCliNatural"
        Me.JCliNatural.PageVisible = False
        Me.JCliNatural.Size = New System.Drawing.Size(777, 506)
        Me.JCliNatural.Text = "Conoce a tu Cliente"
        '
        'btnImprimirNatural
        '
        Me.btnImprimirNatural.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirNatural.Appearance.Options.UseFont = True
        Me.btnImprimirNatural.Image = CType(resources.GetObject("btnImprimirNatural.Image"), System.Drawing.Image)
        Me.btnImprimirNatural.Location = New System.Drawing.Point(604, 926)
        Me.btnImprimirNatural.Name = "btnImprimirNatural"
        Me.btnImprimirNatural.Size = New System.Drawing.Size(154, 36)
        Me.btnImprimirNatural.TabIndex = 42
        Me.btnImprimirNatural.Text = "&Imprimir Ficha"
        '
        'txtnat_Comentarios
        '
        Me.txtnat_Comentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Comentarios.CampoBusqueda = False
        Me.txtnat_Comentarios.CampoEsLlave = False
        Me.txtnat_Comentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Comentarios.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Comentarios.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Comentarios.FechaActual = False
        Me.txtnat_Comentarios.Formato = ""
        Me.txtnat_Comentarios.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtnat_Comentarios.LabelText = ""
        Me.txtnat_Comentarios.LabelWidth = 0
        Me.txtnat_Comentarios.Location = New System.Drawing.Point(-6, 865)
        Me.txtnat_Comentarios.MaxLength = 0
        Me.txtnat_Comentarios.Name = "txtnat_Comentarios"
        Me.txtnat_Comentarios.NombreCampo = "nat_Comentarios"
        Me.txtnat_Comentarios.Obligatorio = False
        Me.txtnat_Comentarios.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Comentarios.Size = New System.Drawing.Size(674, 58)
        Me.txtnat_Comentarios.SoloLectura = False
        Me.txtnat_Comentarios.TabIndex = 34
        Me.txtnat_Comentarios.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtnat_Comentarios.Valor = ""
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseBackColor = True
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl9.Location = New System.Drawing.Point(5, 834)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(754, 28)
        Me.LabelControl9.TabIndex = 41
        Me.LabelControl9.Text = "COMENTARIO"
        '
        'txtnat_FechaFormulario
        '
        Me.txtnat_FechaFormulario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_FechaFormulario.CampoBusqueda = False
        Me.txtnat_FechaFormulario.CampoEsLlave = False
        Me.txtnat_FechaFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_FechaFormulario.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_FechaFormulario.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_FechaFormulario.FechaActual = False
        Me.txtnat_FechaFormulario.Formato = "dd/MMM/yyyy"
        Me.txtnat_FechaFormulario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_FechaFormulario.LabelText = "FECHA:"
        Me.txtnat_FechaFormulario.LabelWidth = 120
        Me.txtnat_FechaFormulario.Location = New System.Drawing.Point(388, 808)
        Me.txtnat_FechaFormulario.MaxLength = 0
        Me.txtnat_FechaFormulario.Name = "txtnat_FechaFormulario"
        Me.txtnat_FechaFormulario.NombreCampo = "nat_FechaFormulario"
        Me.txtnat_FechaFormulario.Obligatorio = False
        Me.txtnat_FechaFormulario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_FechaFormulario.Size = New System.Drawing.Size(281, 20)
        Me.txtnat_FechaFormulario.SoloLectura = False
        Me.txtnat_FechaFormulario.TabIndex = 33
        Me.txtnat_FechaFormulario.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtnat_FechaFormulario.Valor = Nothing
        '
        'txtnat_CompletaFormulario
        '
        Me.txtnat_CompletaFormulario.CampoBusqueda = False
        Me.txtnat_CompletaFormulario.CampoEsLlave = False
        Me.txtnat_CompletaFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_CompletaFormulario.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_CompletaFormulario.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_CompletaFormulario.FechaActual = False
        Me.txtnat_CompletaFormulario.Formato = ""
        Me.txtnat_CompletaFormulario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_CompletaFormulario.LabelText = "FORMULARIO COMPLETADO POR:"
        Me.txtnat_CompletaFormulario.LabelWidth = 175
        Me.txtnat_CompletaFormulario.Location = New System.Drawing.Point(5, 808)
        Me.txtnat_CompletaFormulario.MaxLength = 250
        Me.txtnat_CompletaFormulario.Name = "txtnat_CompletaFormulario"
        Me.txtnat_CompletaFormulario.NombreCampo = "nat_CompletaFormulario"
        Me.txtnat_CompletaFormulario.Obligatorio = False
        Me.txtnat_CompletaFormulario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_CompletaFormulario.Size = New System.Drawing.Size(371, 20)
        Me.txtnat_CompletaFormulario.SoloLectura = False
        Me.txtnat_CompletaFormulario.TabIndex = 32
        Me.txtnat_CompletaFormulario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_CompletaFormulario.Valor = ""
        '
        'txtnat_Cesion
        '
        Me.txtnat_Cesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Cesion.CampoBusqueda = False
        Me.txtnat_Cesion.CampoEsLlave = False
        Me.txtnat_Cesion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Cesion.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Cesion.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Cesion.FechaActual = False
        Me.txtnat_Cesion.Formato = ""
        Me.txtnat_Cesion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtnat_Cesion.LabelText = "SU PÓLIZA ESTÁ CEDIDA            (Indicar Banco y Ejecutivo)"
        Me.txtnat_Cesion.LabelWidth = 175
        Me.txtnat_Cesion.Location = New System.Drawing.Point(5, 769)
        Me.txtnat_Cesion.MaxLength = 0
        Me.txtnat_Cesion.Name = "txtnat_Cesion"
        Me.txtnat_Cesion.NombreCampo = "nat_Cesion"
        Me.txtnat_Cesion.Obligatorio = False
        Me.txtnat_Cesion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Cesion.Size = New System.Drawing.Size(664, 36)
        Me.txtnat_Cesion.SoloLectura = False
        Me.txtnat_Cesion.TabIndex = 31
        Me.txtnat_Cesion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtnat_Cesion.Valor = ""
        '
        'txtnat_Bebida
        '
        Me.txtnat_Bebida.CampoBusqueda = False
        Me.txtnat_Bebida.CampoEsLlave = False
        Me.txtnat_Bebida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Bebida.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Bebida.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Bebida.FechaActual = False
        Me.txtnat_Bebida.Formato = ""
        Me.txtnat_Bebida.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Bebida.LabelText = "BEBIDA FAVORITA:"
        Me.txtnat_Bebida.LabelWidth = 120
        Me.txtnat_Bebida.Location = New System.Drawing.Point(5, 719)
        Me.txtnat_Bebida.MaxLength = 250
        Me.txtnat_Bebida.Name = "txtnat_Bebida"
        Me.txtnat_Bebida.NombreCampo = "nat_Bebida"
        Me.txtnat_Bebida.Obligatorio = False
        Me.txtnat_Bebida.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Bebida.Size = New System.Drawing.Size(371, 20)
        Me.txtnat_Bebida.SoloLectura = False
        Me.txtnat_Bebida.TabIndex = 29
        Me.txtnat_Bebida.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Bebida.Valor = ""
        '
        'txtnat_Musica
        '
        Me.txtnat_Musica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Musica.CampoBusqueda = False
        Me.txtnat_Musica.CampoEsLlave = False
        Me.txtnat_Musica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Musica.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Musica.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Musica.FechaActual = False
        Me.txtnat_Musica.Formato = ""
        Me.txtnat_Musica.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Musica.LabelText = "GENERO MUSICAL:"
        Me.txtnat_Musica.LabelWidth = 120
        Me.txtnat_Musica.Location = New System.Drawing.Point(388, 696)
        Me.txtnat_Musica.MaxLength = 250
        Me.txtnat_Musica.Name = "txtnat_Musica"
        Me.txtnat_Musica.NombreCampo = "nat_Musica"
        Me.txtnat_Musica.Obligatorio = False
        Me.txtnat_Musica.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Musica.Size = New System.Drawing.Size(281, 20)
        Me.txtnat_Musica.SoloLectura = False
        Me.txtnat_Musica.TabIndex = 28
        Me.txtnat_Musica.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Musica.Valor = ""
        '
        'txtnat_Comida
        '
        Me.txtnat_Comida.CampoBusqueda = False
        Me.txtnat_Comida.CampoEsLlave = False
        Me.txtnat_Comida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Comida.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Comida.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Comida.FechaActual = False
        Me.txtnat_Comida.Formato = ""
        Me.txtnat_Comida.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Comida.LabelText = "COMIDA FAVORITA:"
        Me.txtnat_Comida.LabelWidth = 120
        Me.txtnat_Comida.Location = New System.Drawing.Point(5, 696)
        Me.txtnat_Comida.MaxLength = 250
        Me.txtnat_Comida.Name = "txtnat_Comida"
        Me.txtnat_Comida.NombreCampo = "nat_Comida"
        Me.txtnat_Comida.Obligatorio = False
        Me.txtnat_Comida.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Comida.Size = New System.Drawing.Size(371, 20)
        Me.txtnat_Comida.SoloLectura = False
        Me.txtnat_Comida.TabIndex = 27
        Me.txtnat_Comida.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Comida.Valor = ""
        '
        'txtnat_Religion
        '
        Me.txtnat_Religion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Religion.CampoBusqueda = False
        Me.txtnat_Religion.CampoEsLlave = False
        Me.txtnat_Religion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Religion.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Religion.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Religion.FechaActual = False
        Me.txtnat_Religion.Formato = ""
        Me.txtnat_Religion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Religion.LabelText = "RELIGION:"
        Me.txtnat_Religion.LabelWidth = 120
        Me.txtnat_Religion.Location = New System.Drawing.Point(388, 673)
        Me.txtnat_Religion.MaxLength = 250
        Me.txtnat_Religion.Name = "txtnat_Religion"
        Me.txtnat_Religion.NombreCampo = "nat_Religion"
        Me.txtnat_Religion.Obligatorio = False
        Me.txtnat_Religion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Religion.Size = New System.Drawing.Size(281, 20)
        Me.txtnat_Religion.SoloLectura = False
        Me.txtnat_Religion.TabIndex = 26
        Me.txtnat_Religion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Religion.Valor = ""
        '
        'txtnat_Hobbie
        '
        Me.txtnat_Hobbie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Hobbie.CampoBusqueda = False
        Me.txtnat_Hobbie.CampoEsLlave = False
        Me.txtnat_Hobbie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Hobbie.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Hobbie.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Hobbie.FechaActual = False
        Me.txtnat_Hobbie.Formato = ""
        Me.txtnat_Hobbie.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Hobbie.LabelText = "HOBBIE:"
        Me.txtnat_Hobbie.LabelWidth = 120
        Me.txtnat_Hobbie.Location = New System.Drawing.Point(5, 650)
        Me.txtnat_Hobbie.MaxLength = 250
        Me.txtnat_Hobbie.Name = "txtnat_Hobbie"
        Me.txtnat_Hobbie.NombreCampo = "nat_Hobbie"
        Me.txtnat_Hobbie.Obligatorio = False
        Me.txtnat_Hobbie.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Hobbie.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_Hobbie.SoloLectura = False
        Me.txtnat_Hobbie.TabIndex = 24
        Me.txtnat_Hobbie.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Hobbie.Valor = ""
        '
        'txtnat_Deporte
        '
        Me.txtnat_Deporte.CampoBusqueda = False
        Me.txtnat_Deporte.CampoEsLlave = False
        Me.txtnat_Deporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Deporte.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Deporte.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Deporte.FechaActual = False
        Me.txtnat_Deporte.Formato = ""
        Me.txtnat_Deporte.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Deporte.LabelText = "DEPORTE FAVORITO:"
        Me.txtnat_Deporte.LabelWidth = 120
        Me.txtnat_Deporte.Location = New System.Drawing.Point(5, 673)
        Me.txtnat_Deporte.MaxLength = 250
        Me.txtnat_Deporte.Name = "txtnat_Deporte"
        Me.txtnat_Deporte.NombreCampo = "nat_Deporte"
        Me.txtnat_Deporte.Obligatorio = False
        Me.txtnat_Deporte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Deporte.Size = New System.Drawing.Size(371, 20)
        Me.txtnat_Deporte.SoloLectura = False
        Me.txtnat_Deporte.TabIndex = 25
        Me.txtnat_Deporte.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Deporte.Valor = ""
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.Options.UseBackColor = True
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl8.Location = New System.Drawing.Point(5, 616)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(754, 28)
        Me.LabelControl8.TabIndex = 30
        Me.LabelControl8.Text = "OTROS DATOS IMPORTANTES"
        '
        'cbonat_ClienteExistente
        '
        Me.cbonat_ClienteExistente.CampoAutoCompletar = 0
        Me.cbonat_ClienteExistente.CampoBusqueda = False
        Me.cbonat_ClienteExistente.CampoDisplay = 1
        Me.cbonat_ClienteExistente.CampoEsLlave = False
        Me.cbonat_ClienteExistente.CampoValor = 0
        Me.cbonat_ClienteExistente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbonat_ClienteExistente.ControlBackColor = System.Drawing.Color.White
        Me.cbonat_ClienteExistente.ControlForeColor = System.Drawing.Color.Black
        Me.cbonat_ClienteExistente.FilasVisibles = 302
        Me.cbonat_ClienteExistente.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cbonat_ClienteExistente.LabelText = "CLIENTE EXISTENTE:"
        Me.cbonat_ClienteExistente.LabelWidth = 125
        Me.cbonat_ClienteExistente.Lista = "SI SI|NO NO"
        Me.cbonat_ClienteExistente.Location = New System.Drawing.Point(5, 566)
        Me.cbonat_ClienteExistente.MostrarBusquedaColumnas = False
        Me.cbonat_ClienteExistente.Name = "cbonat_ClienteExistente"
        Me.cbonat_ClienteExistente.NombreCampo = "nat_ClienteExistente"
        Me.cbonat_ClienteExistente.Obligatorio = False
        Me.cbonat_ClienteExistente.Query = ""
        Me.cbonat_ClienteExistente.SelectIndex = 0
        Me.cbonat_ClienteExistente.Size = New System.Drawing.Size(361, 20)
        Me.cbonat_ClienteExistente.SoloLectura = False
        Me.cbonat_ClienteExistente.StringConection = ""
        Me.cbonat_ClienteExistente.TabIndex = 22
        Me.cbonat_ClienteExistente.TextoNuevoItem = ""
        Me.cbonat_ClienteExistente.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cbonat_ClienteExistente.Valor = ""
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseBackColor = True
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl7.Location = New System.Drawing.Point(5, 533)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl7.TabIndex = 28
        Me.LabelControl7.Text = "REFERENCIA DE CLIENTE"
        '
        'cbonat_PreferenciaPago
        '
        Me.cbonat_PreferenciaPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbonat_PreferenciaPago.CampoAutoCompletar = 0
        Me.cbonat_PreferenciaPago.CampoBusqueda = False
        Me.cbonat_PreferenciaPago.CampoDisplay = 1
        Me.cbonat_PreferenciaPago.CampoEsLlave = False
        Me.cbonat_PreferenciaPago.CampoValor = 0
        Me.cbonat_PreferenciaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbonat_PreferenciaPago.ControlBackColor = System.Drawing.Color.White
        Me.cbonat_PreferenciaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cbonat_PreferenciaPago.FilasVisibles = 302
        Me.cbonat_PreferenciaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cbonat_PreferenciaPago.LabelText = "FORMA DE PAGO:"
        Me.cbonat_PreferenciaPago.LabelWidth = 120
        Me.cbonat_PreferenciaPago.Lista = "TARJETA TARJETA|CHEQUE CHEQUE|EFECTIVO EFECTIVO"
        Me.cbonat_PreferenciaPago.Location = New System.Drawing.Point(398, 481)
        Me.cbonat_PreferenciaPago.MostrarBusquedaColumnas = False
        Me.cbonat_PreferenciaPago.Name = "cbonat_PreferenciaPago"
        Me.cbonat_PreferenciaPago.NombreCampo = "nat_PreferenciaPago"
        Me.cbonat_PreferenciaPago.Obligatorio = False
        Me.cbonat_PreferenciaPago.Query = ""
        Me.cbonat_PreferenciaPago.SelectIndex = 0
        Me.cbonat_PreferenciaPago.Size = New System.Drawing.Size(271, 20)
        Me.cbonat_PreferenciaPago.SoloLectura = False
        Me.cbonat_PreferenciaPago.StringConection = ""
        Me.cbonat_PreferenciaPago.TabIndex = 20
        Me.cbonat_PreferenciaPago.TextoNuevoItem = ""
        Me.cbonat_PreferenciaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cbonat_PreferenciaPago.Valor = ""
        '
        'cbonat_PreferenciaCobro
        '
        Me.cbonat_PreferenciaCobro.CampoAutoCompletar = 0
        Me.cbonat_PreferenciaCobro.CampoBusqueda = False
        Me.cbonat_PreferenciaCobro.CampoDisplay = 1
        Me.cbonat_PreferenciaCobro.CampoEsLlave = False
        Me.cbonat_PreferenciaCobro.CampoValor = 0
        Me.cbonat_PreferenciaCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbonat_PreferenciaCobro.ControlBackColor = System.Drawing.Color.White
        Me.cbonat_PreferenciaCobro.ControlForeColor = System.Drawing.Color.Black
        Me.cbonat_PreferenciaCobro.FilasVisibles = 302
        Me.cbonat_PreferenciaCobro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cbonat_PreferenciaCobro.LabelText = "DIRECCIÓN DE COBRO:"
        Me.cbonat_PreferenciaCobro.LabelWidth = 120
        Me.cbonat_PreferenciaCobro.Lista = "CASA CASA|OFICINA OFICINA"
        Me.cbonat_PreferenciaCobro.Location = New System.Drawing.Point(5, 481)
        Me.cbonat_PreferenciaCobro.MostrarBusquedaColumnas = False
        Me.cbonat_PreferenciaCobro.Name = "cbonat_PreferenciaCobro"
        Me.cbonat_PreferenciaCobro.NombreCampo = "nat_PreferenciaCobro"
        Me.cbonat_PreferenciaCobro.Obligatorio = False
        Me.cbonat_PreferenciaCobro.Query = ""
        Me.cbonat_PreferenciaCobro.SelectIndex = 0
        Me.cbonat_PreferenciaCobro.Size = New System.Drawing.Size(361, 20)
        Me.cbonat_PreferenciaCobro.SoloLectura = False
        Me.cbonat_PreferenciaCobro.StringConection = ""
        Me.cbonat_PreferenciaCobro.TabIndex = 19
        Me.cbonat_PreferenciaCobro.TextoNuevoItem = ""
        Me.cbonat_PreferenciaCobro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cbonat_PreferenciaCobro.Valor = ""
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl6.Location = New System.Drawing.Point(5, 448)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl6.TabIndex = 25
        Me.LabelControl6.Text = "INFORMACIÓN DE COBRO"
        '
        'txtnat_EmailTrabajo
        '
        Me.txtnat_EmailTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_EmailTrabajo.CampoBusqueda = False
        Me.txtnat_EmailTrabajo.CampoEsLlave = False
        Me.txtnat_EmailTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_EmailTrabajo.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_EmailTrabajo.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_EmailTrabajo.FechaActual = False
        Me.txtnat_EmailTrabajo.Formato = ""
        Me.txtnat_EmailTrabajo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_EmailTrabajo.LabelText = "CORREO ELECTRÓNICO:"
        Me.txtnat_EmailTrabajo.LabelWidth = 120
        Me.txtnat_EmailTrabajo.Location = New System.Drawing.Point(5, 399)
        Me.txtnat_EmailTrabajo.MaxLength = 250
        Me.txtnat_EmailTrabajo.Name = "txtnat_EmailTrabajo"
        Me.txtnat_EmailTrabajo.NombreCampo = "nat_EmailTrabajo"
        Me.txtnat_EmailTrabajo.Obligatorio = False
        Me.txtnat_EmailTrabajo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_EmailTrabajo.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_EmailTrabajo.SoloLectura = False
        Me.txtnat_EmailTrabajo.TabIndex = 17
        Me.txtnat_EmailTrabajo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_EmailTrabajo.Valor = ""
        '
        'txtnat_PaginaWeb
        '
        Me.txtnat_PaginaWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_PaginaWeb.CampoBusqueda = False
        Me.txtnat_PaginaWeb.CampoEsLlave = False
        Me.txtnat_PaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_PaginaWeb.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_PaginaWeb.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_PaginaWeb.FechaActual = False
        Me.txtnat_PaginaWeb.Formato = ""
        Me.txtnat_PaginaWeb.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_PaginaWeb.LabelText = "PÁGINA WEB:"
        Me.txtnat_PaginaWeb.LabelWidth = 120
        Me.txtnat_PaginaWeb.Location = New System.Drawing.Point(5, 422)
        Me.txtnat_PaginaWeb.MaxLength = 250
        Me.txtnat_PaginaWeb.Name = "txtnat_PaginaWeb"
        Me.txtnat_PaginaWeb.NombreCampo = "nat_PaginaWeb"
        Me.txtnat_PaginaWeb.Obligatorio = False
        Me.txtnat_PaginaWeb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_PaginaWeb.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_PaginaWeb.SoloLectura = False
        Me.txtnat_PaginaWeb.TabIndex = 18
        Me.txtnat_PaginaWeb.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_PaginaWeb.Valor = ""
        '
        'txtnat_ContactoCobro
        '
        Me.txtnat_ContactoCobro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_ContactoCobro.CampoBusqueda = False
        Me.txtnat_ContactoCobro.CampoEsLlave = False
        Me.txtnat_ContactoCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_ContactoCobro.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_ContactoCobro.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_ContactoCobro.FechaActual = False
        Me.txtnat_ContactoCobro.Formato = ""
        Me.txtnat_ContactoCobro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_ContactoCobro.LabelText = "CONTACTO DE COBRO:"
        Me.txtnat_ContactoCobro.LabelWidth = 120
        Me.txtnat_ContactoCobro.Location = New System.Drawing.Point(5, 507)
        Me.txtnat_ContactoCobro.MaxLength = 250
        Me.txtnat_ContactoCobro.Name = "txtnat_ContactoCobro"
        Me.txtnat_ContactoCobro.NombreCampo = "nat_ContactoCobro"
        Me.txtnat_ContactoCobro.Obligatorio = False
        Me.txtnat_ContactoCobro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_ContactoCobro.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_ContactoCobro.SoloLectura = False
        Me.txtnat_ContactoCobro.TabIndex = 21
        Me.txtnat_ContactoCobro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_ContactoCobro.Valor = ""
        '
        'txtnat_ReferidoPor
        '
        Me.txtnat_ReferidoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_ReferidoPor.CampoBusqueda = False
        Me.txtnat_ReferidoPor.CampoEsLlave = False
        Me.txtnat_ReferidoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_ReferidoPor.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_ReferidoPor.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_ReferidoPor.FechaActual = False
        Me.txtnat_ReferidoPor.Formato = ""
        Me.txtnat_ReferidoPor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_ReferidoPor.LabelText = "CLIENTE REFERIDO POR:"
        Me.txtnat_ReferidoPor.LabelWidth = 125
        Me.txtnat_ReferidoPor.Location = New System.Drawing.Point(5, 590)
        Me.txtnat_ReferidoPor.MaxLength = 250
        Me.txtnat_ReferidoPor.Name = "txtnat_ReferidoPor"
        Me.txtnat_ReferidoPor.NombreCampo = "nat_ReferidoPor"
        Me.txtnat_ReferidoPor.Obligatorio = False
        Me.txtnat_ReferidoPor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_ReferidoPor.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_ReferidoPor.SoloLectura = False
        Me.txtnat_ReferidoPor.TabIndex = 23
        Me.txtnat_ReferidoPor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_ReferidoPor.Valor = ""
        '
        'txtnat_MedioInformacion
        '
        Me.txtnat_MedioInformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_MedioInformacion.CampoBusqueda = False
        Me.txtnat_MedioInformacion.CampoEsLlave = False
        Me.txtnat_MedioInformacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_MedioInformacion.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_MedioInformacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_MedioInformacion.FechaActual = False
        Me.txtnat_MedioInformacion.Formato = ""
        Me.txtnat_MedioInformacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_MedioInformacion.LabelText = "MEDIO POR EL CUAL SE INFORMA:"
        Me.txtnat_MedioInformacion.LabelWidth = 175
        Me.txtnat_MedioInformacion.Location = New System.Drawing.Point(5, 745)
        Me.txtnat_MedioInformacion.MaxLength = 250
        Me.txtnat_MedioInformacion.Name = "txtnat_MedioInformacion"
        Me.txtnat_MedioInformacion.NombreCampo = "nat_MedioInformacion"
        Me.txtnat_MedioInformacion.Obligatorio = False
        Me.txtnat_MedioInformacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_MedioInformacion.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_MedioInformacion.SoloLectura = False
        Me.txtnat_MedioInformacion.TabIndex = 30
        Me.txtnat_MedioInformacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_MedioInformacion.Valor = ""
        '
        'txtnat_DireccionTrabajo
        '
        Me.txtnat_DireccionTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_DireccionTrabajo.CampoBusqueda = False
        Me.txtnat_DireccionTrabajo.CampoEsLlave = False
        Me.txtnat_DireccionTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_DireccionTrabajo.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_DireccionTrabajo.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_DireccionTrabajo.FechaActual = False
        Me.txtnat_DireccionTrabajo.Formato = ""
        Me.txtnat_DireccionTrabajo.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtnat_DireccionTrabajo.LabelText = "DIRECCIÓN TRABAJO:"
        Me.txtnat_DireccionTrabajo.LabelWidth = 120
        Me.txtnat_DireccionTrabajo.Location = New System.Drawing.Point(5, 333)
        Me.txtnat_DireccionTrabajo.MaxLength = 0
        Me.txtnat_DireccionTrabajo.Name = "txtnat_DireccionTrabajo"
        Me.txtnat_DireccionTrabajo.NombreCampo = "nat_DireccionTrabajo"
        Me.txtnat_DireccionTrabajo.Obligatorio = False
        Me.txtnat_DireccionTrabajo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_DireccionTrabajo.Size = New System.Drawing.Size(664, 40)
        Me.txtnat_DireccionTrabajo.SoloLectura = False
        Me.txtnat_DireccionTrabajo.TabIndex = 14
        Me.txtnat_DireccionTrabajo.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtnat_DireccionTrabajo.Valor = ""
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Location = New System.Drawing.Point(427, 266)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(152, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "(Lic, Ing, Dr. Sr. Sra, Arq, otro)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl4.Location = New System.Drawing.Point(5, 233)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "INFORMACIÓN DE TRABAJO"
        '
        'cbonat_TieneHijos
        '
        Me.cbonat_TieneHijos.CampoAutoCompletar = 0
        Me.cbonat_TieneHijos.CampoBusqueda = False
        Me.cbonat_TieneHijos.CampoDisplay = 1
        Me.cbonat_TieneHijos.CampoEsLlave = False
        Me.cbonat_TieneHijos.CampoValor = 0
        Me.cbonat_TieneHijos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbonat_TieneHijos.ControlBackColor = System.Drawing.Color.White
        Me.cbonat_TieneHijos.ControlForeColor = System.Drawing.Color.Black
        Me.cbonat_TieneHijos.FilasVisibles = 302
        Me.cbonat_TieneHijos.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cbonat_TieneHijos.LabelText = "HIJOS:"
        Me.cbonat_TieneHijos.LabelWidth = 100
        Me.cbonat_TieneHijos.Lista = "SI SI TIENE|NO NO TIENE"
        Me.cbonat_TieneHijos.Location = New System.Drawing.Point(5, 161)
        Me.cbonat_TieneHijos.MostrarBusquedaColumnas = False
        Me.cbonat_TieneHijos.Name = "cbonat_TieneHijos"
        Me.cbonat_TieneHijos.NombreCampo = "nat_TieneHijos"
        Me.cbonat_TieneHijos.Obligatorio = False
        Me.cbonat_TieneHijos.Query = ""
        Me.cbonat_TieneHijos.SelectIndex = 0
        Me.cbonat_TieneHijos.Size = New System.Drawing.Size(242, 20)
        Me.cbonat_TieneHijos.SoloLectura = False
        Me.cbonat_TieneHijos.StringConection = ""
        Me.cbonat_TieneHijos.TabIndex = 5
        Me.cbonat_TieneHijos.TextoNuevoItem = ""
        Me.cbonat_TieneHijos.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cbonat_TieneHijos.Valor = ""
        '
        'txtnat_DireccionCasa
        '
        Me.txtnat_DireccionCasa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_DireccionCasa.CampoBusqueda = False
        Me.txtnat_DireccionCasa.CampoEsLlave = False
        Me.txtnat_DireccionCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_DireccionCasa.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_DireccionCasa.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_DireccionCasa.FechaActual = False
        Me.txtnat_DireccionCasa.Formato = ""
        Me.txtnat_DireccionCasa.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtnat_DireccionCasa.LabelText = "DIRECCIÓN CASA"
        Me.txtnat_DireccionCasa.LabelWidth = 100
        Me.txtnat_DireccionCasa.Location = New System.Drawing.Point(5, 94)
        Me.txtnat_DireccionCasa.MaxLength = 0
        Me.txtnat_DireccionCasa.Name = "txtnat_DireccionCasa"
        Me.txtnat_DireccionCasa.NombreCampo = "nat_DireccionCasa"
        Me.txtnat_DireccionCasa.Obligatorio = False
        Me.txtnat_DireccionCasa.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_DireccionCasa.Size = New System.Drawing.Size(666, 41)
        Me.txtnat_DireccionCasa.SoloLectura = False
        Me.txtnat_DireccionCasa.TabIndex = 1
        Me.txtnat_DireccionCasa.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtnat_DireccionCasa.Valor = ""
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl3.Location = New System.Drawing.Point(3, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "INFORMACIÓN PERSONAL"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl2.Location = New System.Drawing.Point(7, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(752, 28)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "FICHA DE DATOS CLIENTE NUEVO PERSONA NATURAL"
        '
        'txtnat_Profesion
        '
        Me.txtnat_Profesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Profesion.CampoBusqueda = False
        Me.txtnat_Profesion.CampoEsLlave = False
        Me.txtnat_Profesion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Profesion.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Profesion.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Profesion.FechaActual = False
        Me.txtnat_Profesion.Formato = ""
        Me.txtnat_Profesion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Profesion.LabelText = "PROFESIÓN:"
        Me.txtnat_Profesion.LabelWidth = 120
        Me.txtnat_Profesion.Location = New System.Drawing.Point(5, 264)
        Me.txtnat_Profesion.MaxLength = 250
        Me.txtnat_Profesion.Name = "txtnat_Profesion"
        Me.txtnat_Profesion.NombreCampo = "nat_Profesion"
        Me.txtnat_Profesion.Obligatorio = False
        Me.txtnat_Profesion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Profesion.Size = New System.Drawing.Size(409, 20)
        Me.txtnat_Profesion.SoloLectura = False
        Me.txtnat_Profesion.TabIndex = 11
        Me.txtnat_Profesion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Profesion.Valor = ""
        '
        'txtnat_twitter
        '
        Me.txtnat_twitter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_twitter.CampoBusqueda = False
        Me.txtnat_twitter.CampoEsLlave = False
        Me.txtnat_twitter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_twitter.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_twitter.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_twitter.FechaActual = False
        Me.txtnat_twitter.Formato = ""
        Me.txtnat_twitter.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_twitter.LabelText = "TWITTER:"
        Me.txtnat_twitter.LabelWidth = 100
        Me.txtnat_twitter.Location = New System.Drawing.Point(517, 207)
        Me.txtnat_twitter.MaxLength = 250
        Me.txtnat_twitter.Name = "txtnat_twitter"
        Me.txtnat_twitter.NombreCampo = "nat_twitter"
        Me.txtnat_twitter.Obligatorio = False
        Me.txtnat_twitter.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_twitter.Size = New System.Drawing.Size(152, 20)
        Me.txtnat_twitter.SoloLectura = False
        Me.txtnat_twitter.TabIndex = 10
        Me.txtnat_twitter.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_twitter.Valor = ""
        '
        'txtnat_Facebook
        '
        Me.txtnat_Facebook.CampoBusqueda = False
        Me.txtnat_Facebook.CampoEsLlave = False
        Me.txtnat_Facebook.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Facebook.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Facebook.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Facebook.FechaActual = False
        Me.txtnat_Facebook.Formato = ""
        Me.txtnat_Facebook.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Facebook.LabelText = "FACEBOOK:"
        Me.txtnat_Facebook.LabelWidth = 100
        Me.txtnat_Facebook.Location = New System.Drawing.Point(262, 207)
        Me.txtnat_Facebook.MaxLength = 250
        Me.txtnat_Facebook.Name = "txtnat_Facebook"
        Me.txtnat_Facebook.NombreCampo = "nat_Facebook"
        Me.txtnat_Facebook.Obligatorio = False
        Me.txtnat_Facebook.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Facebook.Size = New System.Drawing.Size(242, 20)
        Me.txtnat_Facebook.SoloLectura = False
        Me.txtnat_Facebook.TabIndex = 9
        Me.txtnat_Facebook.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Facebook.Valor = ""
        '
        'txtnat_NumHijos
        '
        Me.txtnat_NumHijos.CampoBusqueda = False
        Me.txtnat_NumHijos.CampoEsLlave = False
        Me.txtnat_NumHijos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_NumHijos.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_NumHijos.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_NumHijos.FechaActual = False
        Me.txtnat_NumHijos.Formato = "###0"
        Me.txtnat_NumHijos.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_NumHijos.LabelText = "NO. DE HIJOS:"
        Me.txtnat_NumHijos.LabelWidth = 100
        Me.txtnat_NumHijos.Location = New System.Drawing.Point(262, 161)
        Me.txtnat_NumHijos.MaxLength = 0
        Me.txtnat_NumHijos.Name = "txtnat_NumHijos"
        Me.txtnat_NumHijos.NombreCampo = "nat_NumHijos"
        Me.txtnat_NumHijos.Obligatorio = False
        Me.txtnat_NumHijos.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_NumHijos.Size = New System.Drawing.Size(242, 20)
        Me.txtnat_NumHijos.SoloLectura = False
        Me.txtnat_NumHijos.TabIndex = 6
        Me.txtnat_NumHijos.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtnat_NumHijos.Valor = 0
        '
        'txtnat_PinBB
        '
        Me.txtnat_PinBB.CampoBusqueda = False
        Me.txtnat_PinBB.CampoEsLlave = False
        Me.txtnat_PinBB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_PinBB.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_PinBB.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_PinBB.FechaActual = False
        Me.txtnat_PinBB.Formato = ""
        Me.txtnat_PinBB.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_PinBB.LabelText = "PIN BB:"
        Me.txtnat_PinBB.LabelWidth = 100
        Me.txtnat_PinBB.Location = New System.Drawing.Point(5, 207)
        Me.txtnat_PinBB.MaxLength = 250
        Me.txtnat_PinBB.Name = "txtnat_PinBB"
        Me.txtnat_PinBB.NombreCampo = "nat_PinBB"
        Me.txtnat_PinBB.Obligatorio = False
        Me.txtnat_PinBB.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_PinBB.Size = New System.Drawing.Size(242, 20)
        Me.txtnat_PinBB.SoloLectura = False
        Me.txtnat_PinBB.TabIndex = 8
        Me.txtnat_PinBB.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_PinBB.Valor = ""
        '
        'txtnat_FaxTrabajo
        '
        Me.txtnat_FaxTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_FaxTrabajo.CampoBusqueda = False
        Me.txtnat_FaxTrabajo.CampoEsLlave = False
        Me.txtnat_FaxTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_FaxTrabajo.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_FaxTrabajo.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_FaxTrabajo.FechaActual = False
        Me.txtnat_FaxTrabajo.Formato = ""
        Me.txtnat_FaxTrabajo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_FaxTrabajo.LabelText = "FAX:"
        Me.txtnat_FaxTrabajo.LabelWidth = 120
        Me.txtnat_FaxTrabajo.Location = New System.Drawing.Point(400, 376)
        Me.txtnat_FaxTrabajo.MaxLength = 250
        Me.txtnat_FaxTrabajo.Name = "txtnat_FaxTrabajo"
        Me.txtnat_FaxTrabajo.NombreCampo = "nat_FaxTrabajo"
        Me.txtnat_FaxTrabajo.Obligatorio = False
        Me.txtnat_FaxTrabajo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_FaxTrabajo.Size = New System.Drawing.Size(269, 20)
        Me.txtnat_FaxTrabajo.SoloLectura = False
        Me.txtnat_FaxTrabajo.TabIndex = 16
        Me.txtnat_FaxTrabajo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_FaxTrabajo.Valor = ""
        '
        'txtnat_TelTrabajo
        '
        Me.txtnat_TelTrabajo.CampoBusqueda = False
        Me.txtnat_TelTrabajo.CampoEsLlave = False
        Me.txtnat_TelTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_TelTrabajo.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_TelTrabajo.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_TelTrabajo.FechaActual = False
        Me.txtnat_TelTrabajo.Formato = ""
        Me.txtnat_TelTrabajo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_TelTrabajo.LabelText = "TELÉFONO TRABAJO:"
        Me.txtnat_TelTrabajo.LabelWidth = 120
        Me.txtnat_TelTrabajo.Location = New System.Drawing.Point(5, 376)
        Me.txtnat_TelTrabajo.MaxLength = 250
        Me.txtnat_TelTrabajo.Name = "txtnat_TelTrabajo"
        Me.txtnat_TelTrabajo.NombreCampo = "nat_TelTrabajo"
        Me.txtnat_TelTrabajo.Obligatorio = False
        Me.txtnat_TelTrabajo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_TelTrabajo.Size = New System.Drawing.Size(361, 20)
        Me.txtnat_TelTrabajo.SoloLectura = False
        Me.txtnat_TelTrabajo.TabIndex = 15
        Me.txtnat_TelTrabajo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_TelTrabajo.Valor = ""
        '
        'txtnat_Cargo
        '
        Me.txtnat_Cargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_Cargo.CampoBusqueda = False
        Me.txtnat_Cargo.CampoEsLlave = False
        Me.txtnat_Cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_Cargo.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_Cargo.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_Cargo.FechaActual = False
        Me.txtnat_Cargo.Formato = ""
        Me.txtnat_Cargo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_Cargo.LabelText = "CARGO DESEMPEÑADO:"
        Me.txtnat_Cargo.LabelWidth = 120
        Me.txtnat_Cargo.Location = New System.Drawing.Point(5, 310)
        Me.txtnat_Cargo.MaxLength = 250
        Me.txtnat_Cargo.Name = "txtnat_Cargo"
        Me.txtnat_Cargo.NombreCampo = "nat_Cargo"
        Me.txtnat_Cargo.Obligatorio = False
        Me.txtnat_Cargo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_Cargo.Size = New System.Drawing.Size(409, 20)
        Me.txtnat_Cargo.SoloLectura = False
        Me.txtnat_Cargo.TabIndex = 13
        Me.txtnat_Cargo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_Cargo.Valor = ""
        '
        'txtnat_LugarTrabajo
        '
        Me.txtnat_LugarTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_LugarTrabajo.CampoBusqueda = False
        Me.txtnat_LugarTrabajo.CampoEsLlave = False
        Me.txtnat_LugarTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_LugarTrabajo.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_LugarTrabajo.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_LugarTrabajo.FechaActual = False
        Me.txtnat_LugarTrabajo.Formato = ""
        Me.txtnat_LugarTrabajo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_LugarTrabajo.LabelText = "LUGAR DE TRABAJO:"
        Me.txtnat_LugarTrabajo.LabelWidth = 120
        Me.txtnat_LugarTrabajo.Location = New System.Drawing.Point(5, 287)
        Me.txtnat_LugarTrabajo.MaxLength = 250
        Me.txtnat_LugarTrabajo.Name = "txtnat_LugarTrabajo"
        Me.txtnat_LugarTrabajo.NombreCampo = "nat_LugarTrabajo"
        Me.txtnat_LugarTrabajo.Obligatorio = False
        Me.txtnat_LugarTrabajo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_LugarTrabajo.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_LugarTrabajo.SoloLectura = False
        Me.txtnat_LugarTrabajo.TabIndex = 12
        Me.txtnat_LugarTrabajo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_LugarTrabajo.Valor = ""
        '
        'txtnat_EmailCasa
        '
        Me.txtnat_EmailCasa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_EmailCasa.CampoBusqueda = False
        Me.txtnat_EmailCasa.CampoEsLlave = False
        Me.txtnat_EmailCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_EmailCasa.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_EmailCasa.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_EmailCasa.FechaActual = False
        Me.txtnat_EmailCasa.Formato = ""
        Me.txtnat_EmailCasa.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_EmailCasa.LabelText = "CORREO ELECTRÓNICO:"
        Me.txtnat_EmailCasa.LabelWidth = 130
        Me.txtnat_EmailCasa.Location = New System.Drawing.Point(5, 184)
        Me.txtnat_EmailCasa.MaxLength = 250
        Me.txtnat_EmailCasa.Name = "txtnat_EmailCasa"
        Me.txtnat_EmailCasa.NombreCampo = "nat_EmailCasa"
        Me.txtnat_EmailCasa.Obligatorio = False
        Me.txtnat_EmailCasa.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_EmailCasa.Size = New System.Drawing.Size(664, 20)
        Me.txtnat_EmailCasa.SoloLectura = False
        Me.txtnat_EmailCasa.TabIndex = 7
        Me.txtnat_EmailCasa.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_EmailCasa.Valor = ""
        '
        'txtnat_EstadoCivil
        '
        Me.txtnat_EstadoCivil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_EstadoCivil.CampoBusqueda = False
        Me.txtnat_EstadoCivil.CampoEsLlave = False
        Me.txtnat_EstadoCivil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_EstadoCivil.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_EstadoCivil.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_EstadoCivil.FechaActual = False
        Me.txtnat_EstadoCivil.Formato = ""
        Me.txtnat_EstadoCivil.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_EstadoCivil.LabelText = "ESTADO CIVIL:"
        Me.txtnat_EstadoCivil.LabelWidth = 100
        Me.txtnat_EstadoCivil.Location = New System.Drawing.Point(517, 138)
        Me.txtnat_EstadoCivil.MaxLength = 50
        Me.txtnat_EstadoCivil.Name = "txtnat_EstadoCivil"
        Me.txtnat_EstadoCivil.NombreCampo = "nat_EstadoCivil"
        Me.txtnat_EstadoCivil.Obligatorio = False
        Me.txtnat_EstadoCivil.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_EstadoCivil.Size = New System.Drawing.Size(152, 20)
        Me.txtnat_EstadoCivil.SoloLectura = False
        Me.txtnat_EstadoCivil.TabIndex = 4
        Me.txtnat_EstadoCivil.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_EstadoCivil.Valor = ""
        '
        'txtnat_TelMovil
        '
        Me.txtnat_TelMovil.CampoBusqueda = False
        Me.txtnat_TelMovil.CampoEsLlave = False
        Me.txtnat_TelMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_TelMovil.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_TelMovil.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_TelMovil.FechaActual = False
        Me.txtnat_TelMovil.Formato = ""
        Me.txtnat_TelMovil.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_TelMovil.LabelText = "CELULAR:"
        Me.txtnat_TelMovil.LabelWidth = 100
        Me.txtnat_TelMovil.Location = New System.Drawing.Point(262, 138)
        Me.txtnat_TelMovil.MaxLength = 50
        Me.txtnat_TelMovil.Name = "txtnat_TelMovil"
        Me.txtnat_TelMovil.NombreCampo = "nat_TelMovil"
        Me.txtnat_TelMovil.Obligatorio = False
        Me.txtnat_TelMovil.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_TelMovil.Size = New System.Drawing.Size(242, 20)
        Me.txtnat_TelMovil.SoloLectura = False
        Me.txtnat_TelMovil.TabIndex = 3
        Me.txtnat_TelMovil.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_TelMovil.Valor = ""
        '
        'txtnat_TelCasa
        '
        Me.txtnat_TelCasa.CampoBusqueda = False
        Me.txtnat_TelCasa.CampoEsLlave = False
        Me.txtnat_TelCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_TelCasa.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_TelCasa.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_TelCasa.FechaActual = False
        Me.txtnat_TelCasa.Formato = ""
        Me.txtnat_TelCasa.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_TelCasa.LabelText = "TELÉFONO CASA:"
        Me.txtnat_TelCasa.LabelWidth = 100
        Me.txtnat_TelCasa.Location = New System.Drawing.Point(5, 138)
        Me.txtnat_TelCasa.MaxLength = 50
        Me.txtnat_TelCasa.Name = "txtnat_TelCasa"
        Me.txtnat_TelCasa.NombreCampo = "nat_TelCasa"
        Me.txtnat_TelCasa.Obligatorio = False
        Me.txtnat_TelCasa.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_TelCasa.Size = New System.Drawing.Size(242, 20)
        Me.txtnat_TelCasa.SoloLectura = False
        Me.txtnat_TelCasa.TabIndex = 2
        Me.txtnat_TelCasa.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_TelCasa.Valor = ""
        '
        'txtnat_NombreCliente
        '
        Me.txtnat_NombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnat_NombreCliente.CampoBusqueda = False
        Me.txtnat_NombreCliente.CampoEsLlave = False
        Me.txtnat_NombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtnat_NombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtnat_NombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtnat_NombreCliente.FechaActual = False
        Me.txtnat_NombreCliente.Formato = ""
        Me.txtnat_NombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtnat_NombreCliente.LabelText = "NOMBRE:"
        Me.txtnat_NombreCliente.LabelWidth = 100
        Me.txtnat_NombreCliente.Location = New System.Drawing.Point(5, 71)
        Me.txtnat_NombreCliente.MaxLength = 250
        Me.txtnat_NombreCliente.Name = "txtnat_NombreCliente"
        Me.txtnat_NombreCliente.NombreCampo = "nat_NombreCliente"
        Me.txtnat_NombreCliente.Obligatorio = False
        Me.txtnat_NombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnat_NombreCliente.Size = New System.Drawing.Size(666, 20)
        Me.txtnat_NombreCliente.SoloLectura = False
        Me.txtnat_NombreCliente.TabIndex = 0
        Me.txtnat_NombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtnat_NombreCliente.Valor = ""
        '
        'KCliEmpresa
        '
        Me.KCliEmpresa.AutoScroll = True
        Me.KCliEmpresa.Controls.Add(Me.btnImprimirJuridico)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Comentario)
        Me.KCliEmpresa.Controls.Add(Me.LabelControl18)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ActPaginaWeb)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ActEmail)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ActFax)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ActTelefonos)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ActDireccion)
        Me.KCliEmpresa.Controls.Add(Me.LabelControl17)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Cesion)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Pagador)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_FormaPago)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ClienteExiste)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ReferidoPor)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_CobroEmail)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_CobroFax)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_CobroTelefono)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_ContactoCobro)
        Me.KCliEmpresa.Controls.Add(Me.LabelControl16)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Twitter)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Facebook)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_PaginaWeb)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_PolPinBB)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Email)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_FaxOficina)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_TelOficina)
        Me.KCliEmpresa.Controls.Add(Me.jur_DireccionOficina)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_EncargadoPoliza)
        Me.KCliEmpresa.Controls.Add(Me.LabelControl12)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Profesion)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_TelMovil)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_PinBB)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_RepresentanteLegal)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_Giro)
        Me.KCliEmpresa.Controls.Add(Me.txtjur_NombreEmpresa)
        Me.KCliEmpresa.Controls.Add(Me.LabelControl11)
        Me.KCliEmpresa.Controls.Add(Me.LabelControl10)
        Me.KCliEmpresa.Name = "KCliEmpresa"
        Me.KCliEmpresa.PageVisible = False
        Me.KCliEmpresa.Size = New System.Drawing.Size(777, 506)
        Me.KCliEmpresa.Text = "Conoce a tu Empresa"
        '
        'btnImprimirJuridico
        '
        Me.btnImprimirJuridico.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirJuridico.Appearance.Options.UseFont = True
        Me.btnImprimirJuridico.Image = CType(resources.GetObject("btnImprimirJuridico.Image"), System.Drawing.Image)
        Me.btnImprimirJuridico.Location = New System.Drawing.Point(601, 810)
        Me.btnImprimirJuridico.Name = "btnImprimirJuridico"
        Me.btnImprimirJuridico.Size = New System.Drawing.Size(154, 36)
        Me.btnImprimirJuridico.TabIndex = 53
        Me.btnImprimirJuridico.Text = "&Imprimir Ficha"
        '
        'txtjur_Comentario
        '
        Me.txtjur_Comentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_Comentario.CampoBusqueda = False
        Me.txtjur_Comentario.CampoEsLlave = False
        Me.txtjur_Comentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Comentario.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Comentario.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Comentario.FechaActual = False
        Me.txtjur_Comentario.Formato = ""
        Me.txtjur_Comentario.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtjur_Comentario.LabelText = ""
        Me.txtjur_Comentario.LabelWidth = 0
        Me.txtjur_Comentario.Location = New System.Drawing.Point(-8, 746)
        Me.txtjur_Comentario.MaxLength = 0
        Me.txtjur_Comentario.Name = "txtjur_Comentario"
        Me.txtjur_Comentario.NombreCampo = "jur_Comentario"
        Me.txtjur_Comentario.Obligatorio = False
        Me.txtjur_Comentario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Comentario.Size = New System.Drawing.Size(679, 58)
        Me.txtjur_Comentario.SoloLectura = False
        Me.txtjur_Comentario.TabIndex = 29
        Me.txtjur_Comentario.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtjur_Comentario.Valor = ""
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl18.Appearance.Options.UseBackColor = True
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseTextOptions = True
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl18.Location = New System.Drawing.Point(3, 715)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(754, 28)
        Me.LabelControl18.TabIndex = 52
        Me.LabelControl18.Text = "COMENTARIO"
        '
        'txtjur_ActPaginaWeb
        '
        Me.txtjur_ActPaginaWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_ActPaginaWeb.CampoBusqueda = False
        Me.txtjur_ActPaginaWeb.CampoEsLlave = False
        Me.txtjur_ActPaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ActPaginaWeb.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ActPaginaWeb.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ActPaginaWeb.FechaActual = False
        Me.txtjur_ActPaginaWeb.Formato = ""
        Me.txtjur_ActPaginaWeb.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_ActPaginaWeb.LabelText = "PÁGINA WEB:"
        Me.txtjur_ActPaginaWeb.LabelWidth = 150
        Me.txtjur_ActPaginaWeb.Location = New System.Drawing.Point(3, 689)
        Me.txtjur_ActPaginaWeb.MaxLength = 250
        Me.txtjur_ActPaginaWeb.Name = "txtjur_ActPaginaWeb"
        Me.txtjur_ActPaginaWeb.NombreCampo = "jur_ActPaginaWeb"
        Me.txtjur_ActPaginaWeb.Obligatorio = False
        Me.txtjur_ActPaginaWeb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ActPaginaWeb.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_ActPaginaWeb.SoloLectura = False
        Me.txtjur_ActPaginaWeb.TabIndex = 28
        Me.txtjur_ActPaginaWeb.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_ActPaginaWeb.Valor = ""
        '
        'txtjur_ActEmail
        '
        Me.txtjur_ActEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_ActEmail.CampoBusqueda = False
        Me.txtjur_ActEmail.CampoEsLlave = False
        Me.txtjur_ActEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ActEmail.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ActEmail.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ActEmail.FechaActual = False
        Me.txtjur_ActEmail.Formato = ""
        Me.txtjur_ActEmail.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_ActEmail.LabelText = "CORREO ELECTRÓNICO:"
        Me.txtjur_ActEmail.LabelWidth = 150
        Me.txtjur_ActEmail.Location = New System.Drawing.Point(3, 666)
        Me.txtjur_ActEmail.MaxLength = 250
        Me.txtjur_ActEmail.Name = "txtjur_ActEmail"
        Me.txtjur_ActEmail.NombreCampo = "jur_ActEmail"
        Me.txtjur_ActEmail.Obligatorio = False
        Me.txtjur_ActEmail.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ActEmail.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_ActEmail.SoloLectura = False
        Me.txtjur_ActEmail.TabIndex = 27
        Me.txtjur_ActEmail.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_ActEmail.Valor = ""
        '
        'txtjur_ActFax
        '
        Me.txtjur_ActFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_ActFax.CampoBusqueda = False
        Me.txtjur_ActFax.CampoEsLlave = False
        Me.txtjur_ActFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ActFax.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ActFax.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ActFax.FechaActual = False
        Me.txtjur_ActFax.Formato = ""
        Me.txtjur_ActFax.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_ActFax.LabelText = "FAX:"
        Me.txtjur_ActFax.LabelWidth = 150
        Me.txtjur_ActFax.Location = New System.Drawing.Point(384, 643)
        Me.txtjur_ActFax.MaxLength = 250
        Me.txtjur_ActFax.Name = "txtjur_ActFax"
        Me.txtjur_ActFax.NombreCampo = "jur_ActFax"
        Me.txtjur_ActFax.Obligatorio = False
        Me.txtjur_ActFax.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ActFax.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_ActFax.SoloLectura = False
        Me.txtjur_ActFax.TabIndex = 26
        Me.txtjur_ActFax.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_ActFax.Valor = ""
        '
        'txtjur_ActTelefonos
        '
        Me.txtjur_ActTelefonos.CampoBusqueda = False
        Me.txtjur_ActTelefonos.CampoEsLlave = False
        Me.txtjur_ActTelefonos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ActTelefonos.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ActTelefonos.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ActTelefonos.FechaActual = False
        Me.txtjur_ActTelefonos.Formato = ""
        Me.txtjur_ActTelefonos.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_ActTelefonos.LabelText = "TELÉFONOS DE OFICINA:"
        Me.txtjur_ActTelefonos.LabelWidth = 150
        Me.txtjur_ActTelefonos.Location = New System.Drawing.Point(3, 643)
        Me.txtjur_ActTelefonos.MaxLength = 250
        Me.txtjur_ActTelefonos.Name = "txtjur_ActTelefonos"
        Me.txtjur_ActTelefonos.NombreCampo = "jur_ActTelefonos"
        Me.txtjur_ActTelefonos.Obligatorio = False
        Me.txtjur_ActTelefonos.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ActTelefonos.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_ActTelefonos.SoloLectura = False
        Me.txtjur_ActTelefonos.TabIndex = 25
        Me.txtjur_ActTelefonos.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_ActTelefonos.Valor = ""
        '
        'txtjur_ActDireccion
        '
        Me.txtjur_ActDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_ActDireccion.CampoBusqueda = False
        Me.txtjur_ActDireccion.CampoEsLlave = False
        Me.txtjur_ActDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ActDireccion.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ActDireccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ActDireccion.FechaActual = False
        Me.txtjur_ActDireccion.Formato = ""
        Me.txtjur_ActDireccion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtjur_ActDireccion.LabelText = "DIRECCIÓN OFICINA:"
        Me.txtjur_ActDireccion.LabelWidth = 150
        Me.txtjur_ActDireccion.Location = New System.Drawing.Point(3, 605)
        Me.txtjur_ActDireccion.MaxLength = 0
        Me.txtjur_ActDireccion.Name = "txtjur_ActDireccion"
        Me.txtjur_ActDireccion.NombreCampo = "jur_ActDireccion"
        Me.txtjur_ActDireccion.Obligatorio = False
        Me.txtjur_ActDireccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ActDireccion.Size = New System.Drawing.Size(667, 35)
        Me.txtjur_ActDireccion.SoloLectura = False
        Me.txtjur_ActDireccion.TabIndex = 24
        Me.txtjur_ActDireccion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtjur_ActDireccion.Valor = ""
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl17.Appearance.Options.UseBackColor = True
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseTextOptions = True
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl17.Location = New System.Drawing.Point(3, 571)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(754, 28)
        Me.LabelControl17.TabIndex = 45
        Me.LabelControl17.Text = "ACTUALIZACIÓN DE DATOS"
        '
        'txtjur_Cesion
        '
        Me.txtjur_Cesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_Cesion.CampoBusqueda = False
        Me.txtjur_Cesion.CampoEsLlave = False
        Me.txtjur_Cesion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Cesion.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Cesion.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Cesion.FechaActual = False
        Me.txtjur_Cesion.Formato = ""
        Me.txtjur_Cesion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtjur_Cesion.LabelText = "SU PÓLIZA ESTÁ CEDIDA            (Indicar Banco y Ejecutivo)"
        Me.txtjur_Cesion.LabelWidth = 150
        Me.txtjur_Cesion.Location = New System.Drawing.Point(3, 526)
        Me.txtjur_Cesion.MaxLength = 0
        Me.txtjur_Cesion.Name = "txtjur_Cesion"
        Me.txtjur_Cesion.NombreCampo = "jur_Cesion"
        Me.txtjur_Cesion.Obligatorio = False
        Me.txtjur_Cesion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Cesion.Size = New System.Drawing.Size(667, 36)
        Me.txtjur_Cesion.SoloLectura = False
        Me.txtjur_Cesion.TabIndex = 23
        Me.txtjur_Cesion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtjur_Cesion.Valor = ""
        '
        'txtjur_Pagador
        '
        Me.txtjur_Pagador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_Pagador.CampoBusqueda = False
        Me.txtjur_Pagador.CampoEsLlave = False
        Me.txtjur_Pagador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Pagador.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Pagador.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Pagador.FechaActual = False
        Me.txtjur_Pagador.Formato = ""
        Me.txtjur_Pagador.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_Pagador.LabelText = "PAGADOR:"
        Me.txtjur_Pagador.LabelWidth = 150
        Me.txtjur_Pagador.Location = New System.Drawing.Point(384, 502)
        Me.txtjur_Pagador.MaxLength = 250
        Me.txtjur_Pagador.Name = "txtjur_Pagador"
        Me.txtjur_Pagador.NombreCampo = "jur_Pagador"
        Me.txtjur_Pagador.Obligatorio = False
        Me.txtjur_Pagador.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Pagador.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_Pagador.SoloLectura = False
        Me.txtjur_Pagador.TabIndex = 22
        Me.txtjur_Pagador.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_Pagador.Valor = ""
        '
        'txtjur_FormaPago
        '
        Me.txtjur_FormaPago.CampoBusqueda = False
        Me.txtjur_FormaPago.CampoEsLlave = False
        Me.txtjur_FormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_FormaPago.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_FormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_FormaPago.FechaActual = False
        Me.txtjur_FormaPago.Formato = ""
        Me.txtjur_FormaPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_FormaPago.LabelText = "FORMA DE PAGO:"
        Me.txtjur_FormaPago.LabelWidth = 150
        Me.txtjur_FormaPago.Location = New System.Drawing.Point(3, 499)
        Me.txtjur_FormaPago.MaxLength = 250
        Me.txtjur_FormaPago.Name = "txtjur_FormaPago"
        Me.txtjur_FormaPago.NombreCampo = "jur_FormaPago"
        Me.txtjur_FormaPago.Obligatorio = False
        Me.txtjur_FormaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_FormaPago.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_FormaPago.SoloLectura = False
        Me.txtjur_FormaPago.TabIndex = 21
        Me.txtjur_FormaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_FormaPago.Valor = ""
        '
        'txtjur_ClienteExiste
        '
        Me.txtjur_ClienteExiste.CampoAutoCompletar = 0
        Me.txtjur_ClienteExiste.CampoBusqueda = False
        Me.txtjur_ClienteExiste.CampoDisplay = 1
        Me.txtjur_ClienteExiste.CampoEsLlave = False
        Me.txtjur_ClienteExiste.CampoValor = 0
        Me.txtjur_ClienteExiste.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ClienteExiste.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ClienteExiste.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ClienteExiste.FilasVisibles = 302
        Me.txtjur_ClienteExiste.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.txtjur_ClienteExiste.LabelText = "CLIENTE EXISTENTE:"
        Me.txtjur_ClienteExiste.LabelWidth = 150
        Me.txtjur_ClienteExiste.Lista = "SI SI|NO NO"
        Me.txtjur_ClienteExiste.Location = New System.Drawing.Point(3, 452)
        Me.txtjur_ClienteExiste.MostrarBusquedaColumnas = False
        Me.txtjur_ClienteExiste.Name = "txtjur_ClienteExiste"
        Me.txtjur_ClienteExiste.NombreCampo = "jur_ClienteExiste"
        Me.txtjur_ClienteExiste.Obligatorio = False
        Me.txtjur_ClienteExiste.Query = ""
        Me.txtjur_ClienteExiste.SelectIndex = 0
        Me.txtjur_ClienteExiste.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_ClienteExiste.SoloLectura = False
        Me.txtjur_ClienteExiste.StringConection = ""
        Me.txtjur_ClienteExiste.TabIndex = 19
        Me.txtjur_ClienteExiste.TextoNuevoItem = ""
        Me.txtjur_ClienteExiste.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.txtjur_ClienteExiste.Valor = ""
        '
        'txtjur_ReferidoPor
        '
        Me.txtjur_ReferidoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_ReferidoPor.CampoBusqueda = False
        Me.txtjur_ReferidoPor.CampoEsLlave = False
        Me.txtjur_ReferidoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ReferidoPor.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ReferidoPor.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ReferidoPor.FechaActual = False
        Me.txtjur_ReferidoPor.Formato = ""
        Me.txtjur_ReferidoPor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_ReferidoPor.LabelText = "CLIENTE REFERIDO POR:"
        Me.txtjur_ReferidoPor.LabelWidth = 150
        Me.txtjur_ReferidoPor.Location = New System.Drawing.Point(3, 476)
        Me.txtjur_ReferidoPor.MaxLength = 250
        Me.txtjur_ReferidoPor.Name = "txtjur_ReferidoPor"
        Me.txtjur_ReferidoPor.NombreCampo = "jur_ReferidoPor"
        Me.txtjur_ReferidoPor.Obligatorio = False
        Me.txtjur_ReferidoPor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ReferidoPor.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_ReferidoPor.SoloLectura = False
        Me.txtjur_ReferidoPor.TabIndex = 20
        Me.txtjur_ReferidoPor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_ReferidoPor.Valor = ""
        '
        'txtjur_CobroEmail
        '
        Me.txtjur_CobroEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_CobroEmail.CampoBusqueda = False
        Me.txtjur_CobroEmail.CampoEsLlave = False
        Me.txtjur_CobroEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_CobroEmail.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_CobroEmail.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_CobroEmail.FechaActual = False
        Me.txtjur_CobroEmail.Formato = ""
        Me.txtjur_CobroEmail.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_CobroEmail.LabelText = "CORREO ELECTRÓNICO:"
        Me.txtjur_CobroEmail.LabelWidth = 150
        Me.txtjur_CobroEmail.Location = New System.Drawing.Point(3, 428)
        Me.txtjur_CobroEmail.MaxLength = 250
        Me.txtjur_CobroEmail.Name = "txtjur_CobroEmail"
        Me.txtjur_CobroEmail.NombreCampo = "jur_CobroEmail"
        Me.txtjur_CobroEmail.Obligatorio = False
        Me.txtjur_CobroEmail.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_CobroEmail.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_CobroEmail.SoloLectura = False
        Me.txtjur_CobroEmail.TabIndex = 18
        Me.txtjur_CobroEmail.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_CobroEmail.Valor = ""
        '
        'txtjur_CobroFax
        '
        Me.txtjur_CobroFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_CobroFax.CampoBusqueda = False
        Me.txtjur_CobroFax.CampoEsLlave = False
        Me.txtjur_CobroFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_CobroFax.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_CobroFax.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_CobroFax.FechaActual = False
        Me.txtjur_CobroFax.Formato = ""
        Me.txtjur_CobroFax.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_CobroFax.LabelText = "FAX:"
        Me.txtjur_CobroFax.LabelWidth = 150
        Me.txtjur_CobroFax.Location = New System.Drawing.Point(384, 405)
        Me.txtjur_CobroFax.MaxLength = 250
        Me.txtjur_CobroFax.Name = "txtjur_CobroFax"
        Me.txtjur_CobroFax.NombreCampo = "jur_CobroFax"
        Me.txtjur_CobroFax.Obligatorio = False
        Me.txtjur_CobroFax.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_CobroFax.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_CobroFax.SoloLectura = False
        Me.txtjur_CobroFax.TabIndex = 17
        Me.txtjur_CobroFax.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_CobroFax.Valor = ""
        '
        'txtjur_CobroTelefono
        '
        Me.txtjur_CobroTelefono.CampoBusqueda = False
        Me.txtjur_CobroTelefono.CampoEsLlave = False
        Me.txtjur_CobroTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_CobroTelefono.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_CobroTelefono.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_CobroTelefono.FechaActual = False
        Me.txtjur_CobroTelefono.Formato = ""
        Me.txtjur_CobroTelefono.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_CobroTelefono.LabelText = "TELÉFONOS DE OFICINA:"
        Me.txtjur_CobroTelefono.LabelWidth = 150
        Me.txtjur_CobroTelefono.Location = New System.Drawing.Point(3, 405)
        Me.txtjur_CobroTelefono.MaxLength = 250
        Me.txtjur_CobroTelefono.Name = "txtjur_CobroTelefono"
        Me.txtjur_CobroTelefono.NombreCampo = "jur_CobroTelefono"
        Me.txtjur_CobroTelefono.Obligatorio = False
        Me.txtjur_CobroTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_CobroTelefono.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_CobroTelefono.SoloLectura = False
        Me.txtjur_CobroTelefono.TabIndex = 16
        Me.txtjur_CobroTelefono.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_CobroTelefono.Valor = ""
        '
        'txtjur_ContactoCobro
        '
        Me.txtjur_ContactoCobro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_ContactoCobro.CampoBusqueda = False
        Me.txtjur_ContactoCobro.CampoEsLlave = False
        Me.txtjur_ContactoCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_ContactoCobro.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_ContactoCobro.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_ContactoCobro.FechaActual = False
        Me.txtjur_ContactoCobro.Formato = ""
        Me.txtjur_ContactoCobro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_ContactoCobro.LabelText = "CONTACTO DE COBRO:"
        Me.txtjur_ContactoCobro.LabelWidth = 150
        Me.txtjur_ContactoCobro.Location = New System.Drawing.Point(3, 382)
        Me.txtjur_ContactoCobro.MaxLength = 250
        Me.txtjur_ContactoCobro.Name = "txtjur_ContactoCobro"
        Me.txtjur_ContactoCobro.NombreCampo = "jur_ContactoCobro"
        Me.txtjur_ContactoCobro.Obligatorio = False
        Me.txtjur_ContactoCobro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_ContactoCobro.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_ContactoCobro.SoloLectura = False
        Me.txtjur_ContactoCobro.TabIndex = 15
        Me.txtjur_ContactoCobro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_ContactoCobro.Valor = ""
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl16.Appearance.Options.UseBackColor = True
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseTextOptions = True
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl16.Location = New System.Drawing.Point(3, 348)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl16.TabIndex = 35
        Me.LabelControl16.Text = "INFORMACIÓN DE COBRO"
        '
        'txtjur_Twitter
        '
        Me.txtjur_Twitter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_Twitter.CampoBusqueda = False
        Me.txtjur_Twitter.CampoEsLlave = False
        Me.txtjur_Twitter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Twitter.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Twitter.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Twitter.FechaActual = False
        Me.txtjur_Twitter.Formato = ""
        Me.txtjur_Twitter.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_Twitter.LabelText = "TWITTER:"
        Me.txtjur_Twitter.LabelWidth = 150
        Me.txtjur_Twitter.Location = New System.Drawing.Point(384, 320)
        Me.txtjur_Twitter.MaxLength = 150
        Me.txtjur_Twitter.Name = "txtjur_Twitter"
        Me.txtjur_Twitter.NombreCampo = "jur_Twitter"
        Me.txtjur_Twitter.Obligatorio = False
        Me.txtjur_Twitter.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Twitter.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_Twitter.SoloLectura = False
        Me.txtjur_Twitter.TabIndex = 14
        Me.txtjur_Twitter.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_Twitter.Valor = ""
        '
        'txtjur_Facebook
        '
        Me.txtjur_Facebook.CampoBusqueda = False
        Me.txtjur_Facebook.CampoEsLlave = False
        Me.txtjur_Facebook.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Facebook.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Facebook.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Facebook.FechaActual = False
        Me.txtjur_Facebook.Formato = ""
        Me.txtjur_Facebook.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_Facebook.LabelText = "FACEBOOK:"
        Me.txtjur_Facebook.LabelWidth = 150
        Me.txtjur_Facebook.Location = New System.Drawing.Point(3, 320)
        Me.txtjur_Facebook.MaxLength = 150
        Me.txtjur_Facebook.Name = "txtjur_Facebook"
        Me.txtjur_Facebook.NombreCampo = "jur_Facebook"
        Me.txtjur_Facebook.Obligatorio = False
        Me.txtjur_Facebook.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Facebook.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_Facebook.SoloLectura = False
        Me.txtjur_Facebook.TabIndex = 13
        Me.txtjur_Facebook.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_Facebook.Valor = ""
        '
        'txtjur_PaginaWeb
        '
        Me.txtjur_PaginaWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_PaginaWeb.CampoBusqueda = False
        Me.txtjur_PaginaWeb.CampoEsLlave = False
        Me.txtjur_PaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_PaginaWeb.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_PaginaWeb.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_PaginaWeb.FechaActual = False
        Me.txtjur_PaginaWeb.Formato = ""
        Me.txtjur_PaginaWeb.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_PaginaWeb.LabelText = "PÁGINA WEB:"
        Me.txtjur_PaginaWeb.LabelWidth = 150
        Me.txtjur_PaginaWeb.Location = New System.Drawing.Point(3, 297)
        Me.txtjur_PaginaWeb.MaxLength = 250
        Me.txtjur_PaginaWeb.Name = "txtjur_PaginaWeb"
        Me.txtjur_PaginaWeb.NombreCampo = "jur_PaginaWeb"
        Me.txtjur_PaginaWeb.Obligatorio = False
        Me.txtjur_PaginaWeb.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_PaginaWeb.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_PaginaWeb.SoloLectura = False
        Me.txtjur_PaginaWeb.TabIndex = 12
        Me.txtjur_PaginaWeb.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_PaginaWeb.Valor = ""
        '
        'txtjur_PolPinBB
        '
        Me.txtjur_PolPinBB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_PolPinBB.CampoBusqueda = False
        Me.txtjur_PolPinBB.CampoEsLlave = False
        Me.txtjur_PolPinBB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_PolPinBB.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_PolPinBB.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_PolPinBB.FechaActual = False
        Me.txtjur_PolPinBB.Formato = ""
        Me.txtjur_PolPinBB.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_PolPinBB.LabelText = "PIN BB:"
        Me.txtjur_PolPinBB.LabelWidth = 150
        Me.txtjur_PolPinBB.Location = New System.Drawing.Point(384, 274)
        Me.txtjur_PolPinBB.MaxLength = 50
        Me.txtjur_PolPinBB.Name = "txtjur_PolPinBB"
        Me.txtjur_PolPinBB.NombreCampo = "jur_PolPinBB"
        Me.txtjur_PolPinBB.Obligatorio = False
        Me.txtjur_PolPinBB.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_PolPinBB.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_PolPinBB.SoloLectura = False
        Me.txtjur_PolPinBB.TabIndex = 11
        Me.txtjur_PolPinBB.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_PolPinBB.Valor = ""
        '
        'txtjur_Email
        '
        Me.txtjur_Email.CampoBusqueda = False
        Me.txtjur_Email.CampoEsLlave = False
        Me.txtjur_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Email.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Email.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Email.FechaActual = False
        Me.txtjur_Email.Formato = ""
        Me.txtjur_Email.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_Email.LabelText = "CORREO ELECTRÓNICO:"
        Me.txtjur_Email.LabelWidth = 150
        Me.txtjur_Email.Location = New System.Drawing.Point(3, 274)
        Me.txtjur_Email.MaxLength = 150
        Me.txtjur_Email.Name = "txtjur_Email"
        Me.txtjur_Email.NombreCampo = "jur_Email"
        Me.txtjur_Email.Obligatorio = False
        Me.txtjur_Email.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Email.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_Email.SoloLectura = False
        Me.txtjur_Email.TabIndex = 10
        Me.txtjur_Email.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_Email.Valor = ""
        '
        'txtjur_FaxOficina
        '
        Me.txtjur_FaxOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_FaxOficina.CampoBusqueda = False
        Me.txtjur_FaxOficina.CampoEsLlave = False
        Me.txtjur_FaxOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_FaxOficina.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_FaxOficina.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_FaxOficina.FechaActual = False
        Me.txtjur_FaxOficina.Formato = ""
        Me.txtjur_FaxOficina.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_FaxOficina.LabelText = "FAX:"
        Me.txtjur_FaxOficina.LabelWidth = 150
        Me.txtjur_FaxOficina.Location = New System.Drawing.Point(384, 251)
        Me.txtjur_FaxOficina.MaxLength = 150
        Me.txtjur_FaxOficina.Name = "txtjur_FaxOficina"
        Me.txtjur_FaxOficina.NombreCampo = "jur_FaxOficina"
        Me.txtjur_FaxOficina.Obligatorio = False
        Me.txtjur_FaxOficina.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_FaxOficina.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_FaxOficina.SoloLectura = False
        Me.txtjur_FaxOficina.TabIndex = 9
        Me.txtjur_FaxOficina.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_FaxOficina.Valor = ""
        '
        'txtjur_TelOficina
        '
        Me.txtjur_TelOficina.CampoBusqueda = False
        Me.txtjur_TelOficina.CampoEsLlave = False
        Me.txtjur_TelOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_TelOficina.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_TelOficina.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_TelOficina.FechaActual = False
        Me.txtjur_TelOficina.Formato = ""
        Me.txtjur_TelOficina.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_TelOficina.LabelText = "TELÉFONO DE OFICINA:"
        Me.txtjur_TelOficina.LabelWidth = 150
        Me.txtjur_TelOficina.Location = New System.Drawing.Point(3, 251)
        Me.txtjur_TelOficina.MaxLength = 150
        Me.txtjur_TelOficina.Name = "txtjur_TelOficina"
        Me.txtjur_TelOficina.NombreCampo = "jur_TelOficina"
        Me.txtjur_TelOficina.Obligatorio = False
        Me.txtjur_TelOficina.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_TelOficina.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_TelOficina.SoloLectura = False
        Me.txtjur_TelOficina.TabIndex = 8
        Me.txtjur_TelOficina.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_TelOficina.Valor = ""
        '
        'jur_DireccionOficina
        '
        Me.jur_DireccionOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jur_DireccionOficina.CampoBusqueda = False
        Me.jur_DireccionOficina.CampoEsLlave = False
        Me.jur_DireccionOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.jur_DireccionOficina.ControlBackColor = System.Drawing.Color.White
        Me.jur_DireccionOficina.ControlForeColor = System.Drawing.Color.Black
        Me.jur_DireccionOficina.FechaActual = False
        Me.jur_DireccionOficina.Formato = ""
        Me.jur_DireccionOficina.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.jur_DireccionOficina.LabelText = "DIRECCIÓN OFICINA:"
        Me.jur_DireccionOficina.LabelWidth = 150
        Me.jur_DireccionOficina.Location = New System.Drawing.Point(3, 209)
        Me.jur_DireccionOficina.MaxLength = 0
        Me.jur_DireccionOficina.Name = "jur_DireccionOficina"
        Me.jur_DireccionOficina.NombreCampo = "jur_DireccionOficina"
        Me.jur_DireccionOficina.Obligatorio = False
        Me.jur_DireccionOficina.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.jur_DireccionOficina.Size = New System.Drawing.Size(667, 39)
        Me.jur_DireccionOficina.SoloLectura = False
        Me.jur_DireccionOficina.TabIndex = 7
        Me.jur_DireccionOficina.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.jur_DireccionOficina.Valor = ""
        '
        'txtjur_EncargadoPoliza
        '
        Me.txtjur_EncargadoPoliza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_EncargadoPoliza.CampoBusqueda = False
        Me.txtjur_EncargadoPoliza.CampoEsLlave = False
        Me.txtjur_EncargadoPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_EncargadoPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_EncargadoPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_EncargadoPoliza.FechaActual = False
        Me.txtjur_EncargadoPoliza.Formato = ""
        Me.txtjur_EncargadoPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_EncargadoPoliza.LabelText = "ENCARGADO DE PÓLIZA:"
        Me.txtjur_EncargadoPoliza.LabelWidth = 150
        Me.txtjur_EncargadoPoliza.Location = New System.Drawing.Point(3, 186)
        Me.txtjur_EncargadoPoliza.MaxLength = 250
        Me.txtjur_EncargadoPoliza.Name = "txtjur_EncargadoPoliza"
        Me.txtjur_EncargadoPoliza.NombreCampo = "jur_EncargadoPoliza"
        Me.txtjur_EncargadoPoliza.Obligatorio = False
        Me.txtjur_EncargadoPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_EncargadoPoliza.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_EncargadoPoliza.SoloLectura = False
        Me.txtjur_EncargadoPoliza.TabIndex = 6
        Me.txtjur_EncargadoPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_EncargadoPoliza.Valor = ""
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Location = New System.Drawing.Point(473, 166)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(152, 13)
        Me.LabelControl12.TabIndex = 24
        Me.LabelControl12.Text = "(Lic, Ing, Dr. Sr. Sra, Arq, otro)"
        '
        'txtjur_Profesion
        '
        Me.txtjur_Profesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_Profesion.CampoBusqueda = False
        Me.txtjur_Profesion.CampoEsLlave = False
        Me.txtjur_Profesion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Profesion.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Profesion.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Profesion.FechaActual = False
        Me.txtjur_Profesion.Formato = ""
        Me.txtjur_Profesion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_Profesion.LabelText = "PROFESIÓN:"
        Me.txtjur_Profesion.LabelWidth = 150
        Me.txtjur_Profesion.Location = New System.Drawing.Point(3, 163)
        Me.txtjur_Profesion.MaxLength = 250
        Me.txtjur_Profesion.Name = "txtjur_Profesion"
        Me.txtjur_Profesion.NombreCampo = "jur_Profesion"
        Me.txtjur_Profesion.Obligatorio = False
        Me.txtjur_Profesion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Profesion.Size = New System.Drawing.Size(448, 20)
        Me.txtjur_Profesion.SoloLectura = False
        Me.txtjur_Profesion.TabIndex = 5
        Me.txtjur_Profesion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_Profesion.Valor = ""
        '
        'txtjur_TelMovil
        '
        Me.txtjur_TelMovil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_TelMovil.CampoBusqueda = False
        Me.txtjur_TelMovil.CampoEsLlave = False
        Me.txtjur_TelMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_TelMovil.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_TelMovil.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_TelMovil.FechaActual = False
        Me.txtjur_TelMovil.Formato = ""
        Me.txtjur_TelMovil.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_TelMovil.LabelText = "CELULAR:"
        Me.txtjur_TelMovil.LabelWidth = 150
        Me.txtjur_TelMovil.Location = New System.Drawing.Point(3, 140)
        Me.txtjur_TelMovil.MaxLength = 50
        Me.txtjur_TelMovil.Name = "txtjur_TelMovil"
        Me.txtjur_TelMovil.NombreCampo = "jur_TelMovil"
        Me.txtjur_TelMovil.Obligatorio = False
        Me.txtjur_TelMovil.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_TelMovil.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_TelMovil.SoloLectura = False
        Me.txtjur_TelMovil.TabIndex = 4
        Me.txtjur_TelMovil.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_TelMovil.Valor = ""
        '
        'txtjur_PinBB
        '
        Me.txtjur_PinBB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_PinBB.CampoBusqueda = False
        Me.txtjur_PinBB.CampoEsLlave = False
        Me.txtjur_PinBB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_PinBB.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_PinBB.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_PinBB.FechaActual = False
        Me.txtjur_PinBB.Formato = ""
        Me.txtjur_PinBB.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_PinBB.LabelText = "PIN BB:"
        Me.txtjur_PinBB.LabelWidth = 150
        Me.txtjur_PinBB.Location = New System.Drawing.Point(384, 117)
        Me.txtjur_PinBB.MaxLength = 50
        Me.txtjur_PinBB.Name = "txtjur_PinBB"
        Me.txtjur_PinBB.NombreCampo = "jur_PinBB"
        Me.txtjur_PinBB.Obligatorio = False
        Me.txtjur_PinBB.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_PinBB.Size = New System.Drawing.Size(286, 20)
        Me.txtjur_PinBB.SoloLectura = False
        Me.txtjur_PinBB.TabIndex = 3
        Me.txtjur_PinBB.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_PinBB.Valor = ""
        '
        'txtjur_RepresentanteLegal
        '
        Me.txtjur_RepresentanteLegal.CampoBusqueda = False
        Me.txtjur_RepresentanteLegal.CampoEsLlave = False
        Me.txtjur_RepresentanteLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_RepresentanteLegal.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_RepresentanteLegal.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_RepresentanteLegal.FechaActual = False
        Me.txtjur_RepresentanteLegal.Formato = ""
        Me.txtjur_RepresentanteLegal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_RepresentanteLegal.LabelText = "NOMBRE DE REP. LEGAL:"
        Me.txtjur_RepresentanteLegal.LabelWidth = 150
        Me.txtjur_RepresentanteLegal.Location = New System.Drawing.Point(3, 117)
        Me.txtjur_RepresentanteLegal.MaxLength = 250
        Me.txtjur_RepresentanteLegal.Name = "txtjur_RepresentanteLegal"
        Me.txtjur_RepresentanteLegal.NombreCampo = "jur_RepresentanteLegal"
        Me.txtjur_RepresentanteLegal.Obligatorio = False
        Me.txtjur_RepresentanteLegal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_RepresentanteLegal.Size = New System.Drawing.Size(375, 20)
        Me.txtjur_RepresentanteLegal.SoloLectura = False
        Me.txtjur_RepresentanteLegal.TabIndex = 2
        Me.txtjur_RepresentanteLegal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_RepresentanteLegal.Valor = ""
        '
        'txtjur_Giro
        '
        Me.txtjur_Giro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_Giro.CampoBusqueda = False
        Me.txtjur_Giro.CampoEsLlave = False
        Me.txtjur_Giro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_Giro.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_Giro.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_Giro.FechaActual = False
        Me.txtjur_Giro.Formato = ""
        Me.txtjur_Giro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_Giro.LabelText = "GIRO DEL NEGOCIO:"
        Me.txtjur_Giro.LabelWidth = 150
        Me.txtjur_Giro.Location = New System.Drawing.Point(3, 94)
        Me.txtjur_Giro.MaxLength = 250
        Me.txtjur_Giro.Name = "txtjur_Giro"
        Me.txtjur_Giro.NombreCampo = "jur_Giro"
        Me.txtjur_Giro.Obligatorio = False
        Me.txtjur_Giro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_Giro.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_Giro.SoloLectura = False
        Me.txtjur_Giro.TabIndex = 1
        Me.txtjur_Giro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_Giro.Valor = ""
        '
        'txtjur_NombreEmpresa
        '
        Me.txtjur_NombreEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjur_NombreEmpresa.CampoBusqueda = False
        Me.txtjur_NombreEmpresa.CampoEsLlave = False
        Me.txtjur_NombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjur_NombreEmpresa.ControlBackColor = System.Drawing.Color.White
        Me.txtjur_NombreEmpresa.ControlForeColor = System.Drawing.Color.Black
        Me.txtjur_NombreEmpresa.FechaActual = False
        Me.txtjur_NombreEmpresa.Formato = ""
        Me.txtjur_NombreEmpresa.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtjur_NombreEmpresa.LabelText = "NOMBRE DE LA EMPRESA:"
        Me.txtjur_NombreEmpresa.LabelWidth = 150
        Me.txtjur_NombreEmpresa.Location = New System.Drawing.Point(3, 71)
        Me.txtjur_NombreEmpresa.MaxLength = 250
        Me.txtjur_NombreEmpresa.Name = "txtjur_NombreEmpresa"
        Me.txtjur_NombreEmpresa.NombreCampo = "jur_NombreEmpresa"
        Me.txtjur_NombreEmpresa.Obligatorio = False
        Me.txtjur_NombreEmpresa.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjur_NombreEmpresa.Size = New System.Drawing.Size(667, 20)
        Me.txtjur_NombreEmpresa.SoloLectura = False
        Me.txtjur_NombreEmpresa.TabIndex = 0
        Me.txtjur_NombreEmpresa.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtjur_NombreEmpresa.Valor = ""
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseBackColor = True
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl11.Location = New System.Drawing.Point(3, 37)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl11.TabIndex = 17
        Me.LabelControl11.Text = "INFORMACIÓN GENERAL"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.Options.UseBackColor = True
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl10.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(752, 28)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "FICHA DE DATOS CLIENTE NUEVO PERSONA EMPRESA"
        '
        'CPolizas
        '
        Me.CPolizas.Controls.Add(Me.btnImprimirListaPolizas)
        Me.CPolizas.Controls.Add(Me.GridPolizas)
        Me.CPolizas.Name = "CPolizas"
        Me.CPolizas.Size = New System.Drawing.Size(777, 506)
        Me.CPolizas.Text = "Pólizas"
        '
        'btnImprimirListaPolizas
        '
        Me.btnImprimirListaPolizas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirListaPolizas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirListaPolizas.Appearance.Options.UseFont = True
        Me.btnImprimirListaPolizas.Image = CType(resources.GetObject("btnImprimirListaPolizas.Image"), System.Drawing.Image)
        Me.btnImprimirListaPolizas.Location = New System.Drawing.Point(578, 448)
        Me.btnImprimirListaPolizas.Name = "btnImprimirListaPolizas"
        Me.btnImprimirListaPolizas.Size = New System.Drawing.Size(200, 36)
        Me.btnImprimirListaPolizas.TabIndex = 6
        Me.btnImprimirListaPolizas.Text = "&Imprimir Lista de Pólizas"
        '
        'GridPolizas
        '
        Me.GridPolizas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPolizas.ColumnasAdicionales = ""
        Me.GridPolizas.Location = New System.Drawing.Point(3, 3)
        Me.GridPolizas.MainView = Me.VistaPolizas
        Me.GridPolizas.Name = "GridPolizas"
        Me.GridPolizas.NombreTabla = ""
        Me.GridPolizas.Size = New System.Drawing.Size(775, 442)
        Me.GridPolizas.TabIndex = 0
        Me.GridPolizas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPolizas})
        '
        'VistaPolizas
        '
        Me.VistaPolizas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPPoliza, Me.colpProducto, Me.colpNProducto, Me.colPVigDesde, Me.colpVigHasta, Me.colpFechaCan, Me.colpMotivoCan})
        Me.VistaPolizas.GridControl = Me.GridPolizas
        Me.VistaPolizas.Name = "VistaPolizas"
        Me.VistaPolizas.OptionsView.ShowGroupPanel = False
        '
        'ColPPoliza
        '
        Me.ColPPoliza.Caption = "Póliza"
        Me.ColPPoliza.FieldName = "IdPoliza"
        Me.ColPPoliza.Name = "ColPPoliza"
        Me.ColPPoliza.Visible = True
        Me.ColPPoliza.VisibleIndex = 0
        '
        'colpProducto
        '
        Me.colpProducto.Caption = "IdProducto"
        Me.colpProducto.FieldName = "IdProducto"
        Me.colpProducto.Name = "colpProducto"
        '
        'colpNProducto
        '
        Me.colpNProducto.Caption = "Producto"
        Me.colpNProducto.FieldName = "Producto"
        Me.colpNProducto.Name = "colpNProducto"
        Me.colpNProducto.Visible = True
        Me.colpNProducto.VisibleIndex = 1
        '
        'colPVigDesde
        '
        Me.colPVigDesde.Caption = "Vigencia Desde"
        Me.colPVigDesde.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colPVigDesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPVigDesde.FieldName = "VigenciaDesde"
        Me.colPVigDesde.Name = "colPVigDesde"
        Me.colPVigDesde.Visible = True
        Me.colPVigDesde.VisibleIndex = 2
        '
        'colpVigHasta
        '
        Me.colpVigHasta.Caption = "Vigencia Hasta"
        Me.colpVigHasta.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colpVigHasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colpVigHasta.FieldName = "VigenciaHasta"
        Me.colpVigHasta.Name = "colpVigHasta"
        Me.colpVigHasta.Visible = True
        Me.colpVigHasta.VisibleIndex = 3
        '
        'colpFechaCan
        '
        Me.colpFechaCan.Caption = "Fecha Cancelación"
        Me.colpFechaCan.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colpFechaCan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colpFechaCan.FieldName = "FechaCancela"
        Me.colpFechaCan.Name = "colpFechaCan"
        Me.colpFechaCan.Visible = True
        Me.colpFechaCan.VisibleIndex = 4
        '
        'colpMotivoCan
        '
        Me.colpMotivoCan.Caption = "Motivo Cancelación"
        Me.colpMotivoCan.FieldName = "MotivoCan"
        Me.colpMotivoCan.Name = "colpMotivoCan"
        Me.colpMotivoCan.Visible = True
        Me.colpMotivoCan.VisibleIndex = 5
        '
        'JCertificados
        '
        Me.JCertificados.Controls.Add(Me.btnImprimirCertificados)
        Me.JCertificados.Controls.Add(Me.GridCertificados)
        Me.JCertificados.Name = "JCertificados"
        Me.JCertificados.Size = New System.Drawing.Size(777, 506)
        Me.JCertificados.Text = "Certificados"
        '
        'btnImprimirCertificados
        '
        Me.btnImprimirCertificados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirCertificados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirCertificados.Appearance.Options.UseFont = True
        Me.btnImprimirCertificados.Image = CType(resources.GetObject("btnImprimirCertificados.Image"), System.Drawing.Image)
        Me.btnImprimirCertificados.Location = New System.Drawing.Point(547, 450)
        Me.btnImprimirCertificados.Name = "btnImprimirCertificados"
        Me.btnImprimirCertificados.Size = New System.Drawing.Size(231, 36)
        Me.btnImprimirCertificados.TabIndex = 7
        Me.btnImprimirCertificados.Text = "&Imprimir Lista de Certificados"
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
        Me.GridCertificados.Size = New System.Drawing.Size(775, 441)
        Me.GridCertificados.TabIndex = 0
        Me.GridCertificados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCertificados})
        '
        'VistaCertificados
        '
        Me.VistaCertificados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCertIdProducto, Me.colCertProducto, Me.colCertPoliza, Me.colCertCertificado, Me.colCertVigDesde, Me.colCertHasta, Me.colCertSuma, Me.colCertPrimaNeta, Me.colCertGastos, Me.colCertIva, Me.colCertTotal, Me.colCertEstado})
        Me.VistaCertificados.GridControl = Me.GridCertificados
        Me.VistaCertificados.Name = "VistaCertificados"
        Me.VistaCertificados.OptionsView.ShowFooter = True
        Me.VistaCertificados.OptionsView.ShowGroupPanel = False
        '
        'colCertIdProducto
        '
        Me.colCertIdProducto.Caption = "IdProducto"
        Me.colCertIdProducto.FieldName = "IdProducto"
        Me.colCertIdProducto.Name = "colCertIdProducto"
        '
        'colCertProducto
        '
        Me.colCertProducto.Caption = "Producto"
        Me.colCertProducto.FieldName = "Producto"
        Me.colCertProducto.Name = "colCertProducto"
        Me.colCertProducto.Visible = True
        Me.colCertProducto.VisibleIndex = 0
        '
        'colCertPoliza
        '
        Me.colCertPoliza.Caption = "Póliza"
        Me.colCertPoliza.FieldName = "IdPoliza"
        Me.colCertPoliza.Name = "colCertPoliza"
        Me.colCertPoliza.Visible = True
        Me.colCertPoliza.VisibleIndex = 1
        '
        'colCertCertificado
        '
        Me.colCertCertificado.Caption = "Certificado"
        Me.colCertCertificado.FieldName = "IdCertificado"
        Me.colCertCertificado.Name = "colCertCertificado"
        Me.colCertCertificado.Visible = True
        Me.colCertCertificado.VisibleIndex = 2
        '
        'colCertVigDesde
        '
        Me.colCertVigDesde.Caption = "Vig.Desde"
        Me.colCertVigDesde.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colCertVigDesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCertVigDesde.FieldName = "VigenciaDesde"
        Me.colCertVigDesde.Name = "colCertVigDesde"
        Me.colCertVigDesde.Visible = True
        Me.colCertVigDesde.VisibleIndex = 3
        '
        'colCertHasta
        '
        Me.colCertHasta.Caption = "Vig. Hasta"
        Me.colCertHasta.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colCertHasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCertHasta.FieldName = "VigenciaHasta"
        Me.colCertHasta.Name = "colCertHasta"
        Me.colCertHasta.Visible = True
        Me.colCertHasta.VisibleIndex = 4
        '
        'colCertSuma
        '
        Me.colCertSuma.Caption = "Suma Asegurada"
        Me.colCertSuma.DisplayFormat.FormatString = "c"
        Me.colCertSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCertSuma.FieldName = "Suma"
        Me.colCertSuma.Name = "colCertSuma"
        Me.colCertSuma.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCertSuma.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCertSuma.Visible = True
        Me.colCertSuma.VisibleIndex = 5
        '
        'colCertPrimaNeta
        '
        Me.colCertPrimaNeta.Caption = "Prima Neta"
        Me.colCertPrimaNeta.DisplayFormat.FormatString = "c"
        Me.colCertPrimaNeta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCertPrimaNeta.FieldName = "PrimaNeta"
        Me.colCertPrimaNeta.Name = "colCertPrimaNeta"
        Me.colCertPrimaNeta.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCertPrimaNeta.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCertPrimaNeta.Visible = True
        Me.colCertPrimaNeta.VisibleIndex = 6
        '
        'colCertGastos
        '
        Me.colCertGastos.Caption = "Gastos"
        Me.colCertGastos.DisplayFormat.FormatString = "c"
        Me.colCertGastos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCertGastos.FieldName = "Gastos"
        Me.colCertGastos.Name = "colCertGastos"
        Me.colCertGastos.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCertGastos.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCertGastos.Visible = True
        Me.colCertGastos.VisibleIndex = 7
        '
        'colCertIva
        '
        Me.colCertIva.Caption = "IVA"
        Me.colCertIva.DisplayFormat.FormatString = "c"
        Me.colCertIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCertIva.FieldName = "Iva"
        Me.colCertIva.Name = "colCertIva"
        Me.colCertIva.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCertIva.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCertIva.Visible = True
        Me.colCertIva.VisibleIndex = 8
        '
        'colCertTotal
        '
        Me.colCertTotal.Caption = "Total"
        Me.colCertTotal.DisplayFormat.FormatString = "c"
        Me.colCertTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCertTotal.FieldName = "Total"
        Me.colCertTotal.Name = "colCertTotal"
        Me.colCertTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCertTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCertTotal.Visible = True
        Me.colCertTotal.VisibleIndex = 9
        '
        'colCertEstado
        '
        Me.colCertEstado.Caption = "Estado"
        Me.colCertEstado.FieldName = "Estado"
        Me.colCertEstado.Name = "colCertEstado"
        Me.colCertEstado.Visible = True
        Me.colCertEstado.VisibleIndex = 10
        '
        'DPrimas
        '
        Me.DPrimas.Controls.Add(Me.btnImprimirPrimasPend)
        Me.DPrimas.Controls.Add(Me.PivotFacturas)
        Me.DPrimas.Name = "DPrimas"
        Me.DPrimas.Size = New System.Drawing.Size(777, 506)
        Me.DPrimas.Text = "Primas Pendientes"
        '
        'btnImprimirPrimasPend
        '
        Me.btnImprimirPrimasPend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirPrimasPend.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirPrimasPend.Appearance.Options.UseFont = True
        Me.btnImprimirPrimasPend.Image = CType(resources.GetObject("btnImprimirPrimasPend.Image"), System.Drawing.Image)
        Me.btnImprimirPrimasPend.Location = New System.Drawing.Point(560, 450)
        Me.btnImprimirPrimasPend.Name = "btnImprimirPrimasPend"
        Me.btnImprimirPrimasPend.Size = New System.Drawing.Size(218, 36)
        Me.btnImprimirPrimasPend.TabIndex = 8
        Me.btnImprimirPrimasPend.Text = "&Imprimir Primas Pendientes"
        '
        'PivotFacturas
        '
        Me.PivotFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotFacturas.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.LightYellow
        Me.PivotFacturas.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.PivotFacturas.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PivotFacturas.Appearance.TotalCell.Options.UseBackColor = True
        Me.PivotFacturas.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotFacturas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.ColNumFactura, Me.ColProducto, Me.ColRamo, Me.ColTipoSeguro, Me.ColAseguradora, Me.ColPoliza, Me.ColTipoFactura, Me.ColCliente, Me.ColFechaPago, Me.ColCuota, Me.ColDiasMora, Me.ColRangoMora, Me.ColPrima, Me.ColGastos, Me.ColImpuestos, Me.ColTotal})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        PivotGridStyleFormatCondition1.Field = Me.ColDiasMora
        PivotGridStyleFormatCondition1.FieldName = "ColDiasMora"
        PivotGridStyleFormatCondition1.Value1 = 150
        Me.PivotFacturas.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1})
        Me.PivotFacturas.Location = New System.Drawing.Point(1, 3)
        Me.PivotFacturas.Name = "PivotFacturas"
        Me.PivotFacturas.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotFacturas.Size = New System.Drawing.Size(781, 441)
        Me.PivotFacturas.TabIndex = 3
        '
        'ColNumFactura
        '
        Me.ColNumFactura.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColNumFactura.AreaIndex = 0
        Me.ColNumFactura.Caption = "Número Factura"
        Me.ColNumFactura.FieldName = "NumeroFactura"
        Me.ColNumFactura.Name = "ColNumFactura"
        '
        'ColProducto
        '
        Me.ColProducto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColProducto.AreaIndex = 1
        Me.ColProducto.Caption = "Producto"
        Me.ColProducto.FieldName = "Producto"
        Me.ColProducto.Name = "ColProducto"
        '
        'ColRamo
        '
        Me.ColRamo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColRamo.AreaIndex = 2
        Me.ColRamo.Caption = "Ramo"
        Me.ColRamo.FieldName = "Ramo"
        Me.ColRamo.Name = "ColRamo"
        '
        'ColTipoSeguro
        '
        Me.ColTipoSeguro.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTipoSeguro.AreaIndex = 3
        Me.ColTipoSeguro.Caption = "Tipo Seguro"
        Me.ColTipoSeguro.FieldName = "TipoSeguro"
        Me.ColTipoSeguro.Name = "ColTipoSeguro"
        '
        'ColAseguradora
        '
        Me.ColAseguradora.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColAseguradora.AreaIndex = 7
        Me.ColAseguradora.Caption = "Aseguradora"
        Me.ColAseguradora.FieldName = "Aseguradora"
        Me.ColAseguradora.Name = "ColAseguradora"
        '
        'ColPoliza
        '
        Me.ColPoliza.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColPoliza.AreaIndex = 1
        Me.ColPoliza.Caption = "Póliza"
        Me.ColPoliza.FieldName = "Poliza"
        Me.ColPoliza.Name = "ColPoliza"
        Me.ColPoliza.Width = 75
        '
        'ColTipoFactura
        '
        Me.ColTipoFactura.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTipoFactura.AreaIndex = 6
        Me.ColTipoFactura.Caption = "Tipo Factura"
        Me.ColTipoFactura.FieldName = "TipoFactura"
        Me.ColTipoFactura.Name = "ColTipoFactura"
        '
        'ColCliente
        '
        Me.ColCliente.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColCliente.AreaIndex = 8
        Me.ColCliente.Caption = "Cliente"
        Me.ColCliente.FieldName = "NombreCliente"
        Me.ColCliente.Name = "ColCliente"
        '
        'ColFechaPago
        '
        Me.ColFechaPago.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColFechaPago.AreaIndex = 2
        Me.ColFechaPago.Caption = "Fecha de Pago"
        Me.ColFechaPago.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaPago.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColFechaPago.FieldName = "FechaPago"
        Me.ColFechaPago.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaPago.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColFechaPago.Name = "ColFechaPago"
        Me.ColFechaPago.TotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaPago.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColFechaPago.TotalValueFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaPago.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColFechaPago.ValueFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaPago.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'ColCuota
        '
        Me.ColCuota.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColCuota.AreaIndex = 4
        Me.ColCuota.Caption = "Cuota"
        Me.ColCuota.FieldName = "Cuota"
        Me.ColCuota.Name = "ColCuota"
        '
        'ColRangoMora
        '
        Me.ColRangoMora.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColRangoMora.AreaIndex = 0
        Me.ColRangoMora.Caption = "Rango de Mora"
        Me.ColRangoMora.FieldName = "RangoMora"
        Me.ColRangoMora.Name = "ColRangoMora"
        '
        'ColPrima
        '
        Me.ColPrima.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColPrima.AreaIndex = 0
        Me.ColPrima.Caption = "Prima"
        Me.ColPrima.FieldName = "PrimaNeta"
        Me.ColPrima.Name = "ColPrima"
        Me.ColPrima.Width = 75
        '
        'ColGastos
        '
        Me.ColGastos.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColGastos.AreaIndex = 1
        Me.ColGastos.Caption = "Gastos"
        Me.ColGastos.FieldName = "Gastos"
        Me.ColGastos.Name = "ColGastos"
        Me.ColGastos.Width = 75
        '
        'ColImpuestos
        '
        Me.ColImpuestos.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColImpuestos.AreaIndex = 2
        Me.ColImpuestos.Caption = "Impuestos"
        Me.ColImpuestos.FieldName = "Impuestos"
        Me.ColImpuestos.Name = "ColImpuestos"
        Me.ColImpuestos.Width = 75
        '
        'ColTotal
        '
        Me.ColTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColTotal.AreaIndex = 3
        Me.ColTotal.Caption = "Total"
        Me.ColTotal.FieldName = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.Width = 75
        '
        'EAvisosCobro
        '
        Me.EAvisosCobro.Controls.Add(Me.GridAvisosCobro)
        Me.EAvisosCobro.Name = "EAvisosCobro"
        Me.EAvisosCobro.Size = New System.Drawing.Size(777, 506)
        Me.EAvisosCobro.Text = "Avisos de Cobro"
        '
        'GridAvisosCobro
        '
        Me.GridAvisosCobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAvisosCobro.ColumnasAdicionales = ""
        Me.GridAvisosCobro.ContextMenuStrip = Me.mnuAvisoCobro
        Me.GridAvisosCobro.Location = New System.Drawing.Point(3, 3)
        Me.GridAvisosCobro.MainView = Me.VistaAvisosCobro
        Me.GridAvisosCobro.Name = "GridAvisosCobro"
        Me.GridAvisosCobro.NombreTabla = ""
        Me.GridAvisosCobro.Size = New System.Drawing.Size(775, 481)
        Me.GridAvisosCobro.TabIndex = 0
        Me.GridAvisosCobro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaAvisosCobro})
        '
        'mnuAvisoCobro
        '
        Me.mnuAvisoCobro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarAvisoDeCobroToolStripMenuItem})
        Me.mnuAvisoCobro.Name = "mnuAvisoCobro"
        Me.mnuAvisoCobro.Size = New System.Drawing.Size(210, 26)
        '
        'ConsultarAvisoDeCobroToolStripMenuItem
        '
        Me.ConsultarAvisoDeCobroToolStripMenuItem.Name = "ConsultarAvisoDeCobroToolStripMenuItem"
        Me.ConsultarAvisoDeCobroToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ConsultarAvisoDeCobroToolStripMenuItem.Text = "Consultar Aviso de Cobro"
        '
        'VistaAvisosCobro
        '
        Me.VistaAvisosCobro.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdAvisoCobro, Me.colIdPoliza, Me.colIdProducto, Me.colVigenciaDesde, Me.colVigenciaHasta, Me.colIdAnexo, Me.colReferencia})
        Me.VistaAvisosCobro.GridControl = Me.GridAvisosCobro
        Me.VistaAvisosCobro.Name = "VistaAvisosCobro"
        Me.VistaAvisosCobro.OptionsBehavior.Editable = False
        Me.VistaAvisosCobro.OptionsView.ShowGroupPanel = False
        '
        'colIdAvisoCobro
        '
        Me.colIdAvisoCobro.Caption = "Núm. Aviso Cobro"
        Me.colIdAvisoCobro.FieldName = "IdAvisoCobro"
        Me.colIdAvisoCobro.Name = "colIdAvisoCobro"
        Me.colIdAvisoCobro.Visible = True
        Me.colIdAvisoCobro.VisibleIndex = 0
        Me.colIdAvisoCobro.Width = 110
        '
        'colIdPoliza
        '
        Me.colIdPoliza.Caption = "Poliza"
        Me.colIdPoliza.FieldName = "IdPoliza"
        Me.colIdPoliza.Name = "colIdPoliza"
        Me.colIdPoliza.Visible = True
        Me.colIdPoliza.VisibleIndex = 1
        Me.colIdPoliza.Width = 92
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "Producto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = True
        Me.colIdProducto.VisibleIndex = 2
        Me.colIdProducto.Width = 92
        '
        'colVigenciaDesde
        '
        Me.colVigenciaDesde.Caption = "Vigencia Desde"
        Me.colVigenciaDesde.FieldName = "VigenciaDesde"
        Me.colVigenciaDesde.Name = "colVigenciaDesde"
        Me.colVigenciaDesde.Visible = True
        Me.colVigenciaDesde.VisibleIndex = 3
        Me.colVigenciaDesde.Width = 92
        '
        'colVigenciaHasta
        '
        Me.colVigenciaHasta.Caption = "Vigencia Hasta"
        Me.colVigenciaHasta.FieldName = "VigenciaHasta"
        Me.colVigenciaHasta.Name = "colVigenciaHasta"
        Me.colVigenciaHasta.Visible = True
        Me.colVigenciaHasta.VisibleIndex = 4
        Me.colVigenciaHasta.Width = 92
        '
        'colIdAnexo
        '
        Me.colIdAnexo.Caption = "Anexo"
        Me.colIdAnexo.FieldName = "IdAnexo"
        Me.colIdAnexo.Name = "colIdAnexo"
        Me.colIdAnexo.Visible = True
        Me.colIdAnexo.VisibleIndex = 5
        Me.colIdAnexo.Width = 92
        '
        'colReferencia
        '
        Me.colReferencia.Caption = "Referencia"
        Me.colReferencia.FieldName = "Referencia"
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.Visible = True
        Me.colReferencia.VisibleIndex = 6
        Me.colReferencia.Width = 98
        '
        'FSiniestros
        '
        Me.FSiniestros.Controls.Add(Me.GridSiniestros)
        Me.FSiniestros.Name = "FSiniestros"
        Me.FSiniestros.Size = New System.Drawing.Size(777, 506)
        Me.FSiniestros.Text = "Siniestros"
        '
        'GridSiniestros
        '
        Me.GridSiniestros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSiniestros.ColumnasAdicionales = ""
        Me.GridSiniestros.Location = New System.Drawing.Point(0, 0)
        Me.GridSiniestros.MainView = Me.VistaSiniestros
        Me.GridSiniestros.Name = "GridSiniestros"
        Me.GridSiniestros.NombreTabla = ""
        Me.GridSiniestros.Size = New System.Drawing.Size(777, 484)
        Me.GridSiniestros.TabIndex = 0
        Me.GridSiniestros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaSiniestros})
        '
        'VistaSiniestros
        '
        Me.VistaSiniestros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSinProducto, Me.colSinPoliza, Me.colSinReclamo, Me.colSinFecOcurre, Me.colSinValorPresentado, Me.colSinValorPagado, Me.colSinEstado, Me.colSinIdProducto, Me.colSinIdCertificado})
        Me.VistaSiniestros.GridControl = Me.GridSiniestros
        Me.VistaSiniestros.Name = "VistaSiniestros"
        Me.VistaSiniestros.OptionsBehavior.Editable = False
        Me.VistaSiniestros.OptionsView.ShowFooter = True
        Me.VistaSiniestros.OptionsView.ShowGroupPanel = False
        '
        'colSinProducto
        '
        Me.colSinProducto.Caption = "Producto"
        Me.colSinProducto.FieldName = "Producto"
        Me.colSinProducto.Name = "colSinProducto"
        Me.colSinProducto.Visible = True
        Me.colSinProducto.VisibleIndex = 0
        '
        'colSinPoliza
        '
        Me.colSinPoliza.Caption = "Póliza"
        Me.colSinPoliza.FieldName = "IdPoliza"
        Me.colSinPoliza.Name = "colSinPoliza"
        Me.colSinPoliza.Visible = True
        Me.colSinPoliza.VisibleIndex = 1
        '
        'colSinReclamo
        '
        Me.colSinReclamo.Caption = "Núm. Reclamo"
        Me.colSinReclamo.FieldName = "IdSiniestro"
        Me.colSinReclamo.Name = "colSinReclamo"
        Me.colSinReclamo.Visible = True
        Me.colSinReclamo.VisibleIndex = 2
        '
        'colSinFecOcurre
        '
        Me.colSinFecOcurre.Caption = "Fecha Ocurrencia"
        Me.colSinFecOcurre.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colSinFecOcurre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSinFecOcurre.FieldName = "FechaOcurre"
        Me.colSinFecOcurre.Name = "colSinFecOcurre"
        Me.colSinFecOcurre.Visible = True
        Me.colSinFecOcurre.VisibleIndex = 3
        '
        'colSinValorPresentado
        '
        Me.colSinValorPresentado.Caption = "Valor Presentado"
        Me.colSinValorPresentado.DisplayFormat.FormatString = "c"
        Me.colSinValorPresentado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSinValorPresentado.FieldName = "ValorPresenta"
        Me.colSinValorPresentado.Name = "colSinValorPresentado"
        Me.colSinValorPresentado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSinValorPresentado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSinValorPresentado.Visible = True
        Me.colSinValorPresentado.VisibleIndex = 4
        '
        'colSinValorPagado
        '
        Me.colSinValorPagado.Caption = "Valor Pagado"
        Me.colSinValorPagado.DisplayFormat.FormatString = "c"
        Me.colSinValorPagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSinValorPagado.FieldName = "ValorPagado"
        Me.colSinValorPagado.Name = "colSinValorPagado"
        Me.colSinValorPagado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSinValorPagado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSinValorPagado.Visible = True
        Me.colSinValorPagado.VisibleIndex = 5
        '
        'colSinEstado
        '
        Me.colSinEstado.Caption = "Estado del Reclamo"
        Me.colSinEstado.FieldName = "Estado"
        Me.colSinEstado.Name = "colSinEstado"
        Me.colSinEstado.Visible = True
        Me.colSinEstado.VisibleIndex = 6
        '
        'colSinIdProducto
        '
        Me.colSinIdProducto.Caption = "IdProducto"
        Me.colSinIdProducto.FieldName = "IdProducto"
        Me.colSinIdProducto.Name = "colSinIdProducto"
        '
        'colSinIdCertificado
        '
        Me.colSinIdCertificado.Caption = "IdCertificado"
        Me.colSinIdCertificado.FieldName = "IdCertificado"
        Me.colSinIdCertificado.Name = "colSinIdCertificado"
        '
        'GEstadoCuenta
        '
        Me.GEstadoCuenta.Controls.Add(Me.btnDetalleFacturasEstadoCuenta)
        Me.GEstadoCuenta.Controls.Add(Me.chkTodasFactEstadoCuenta)
        Me.GEstadoCuenta.Controls.Add(Me.txtLstFacturas)
        Me.GEstadoCuenta.Controls.Add(Me.btnImprimir)
        Me.GEstadoCuenta.Controls.Add(Me.PivotEstado)
        Me.GEstadoCuenta.Name = "GEstadoCuenta"
        Me.GEstadoCuenta.Size = New System.Drawing.Size(777, 506)
        Me.GEstadoCuenta.Text = "Estado de Cuenta"
        '
        'btnDetalleFacturasEstadoCuenta
        '
        Me.btnDetalleFacturasEstadoCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetalleFacturasEstadoCuenta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDetalleFacturasEstadoCuenta.Appearance.Options.UseFont = True
        Me.btnDetalleFacturasEstadoCuenta.Appearance.Options.UseTextOptions = True
        Me.btnDetalleFacturasEstadoCuenta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnDetalleFacturasEstadoCuenta.Image = CType(resources.GetObject("btnDetalleFacturasEstadoCuenta.Image"), System.Drawing.Image)
        Me.btnDetalleFacturasEstadoCuenta.Location = New System.Drawing.Point(499, 444)
        Me.btnDetalleFacturasEstadoCuenta.Name = "btnDetalleFacturasEstadoCuenta"
        Me.btnDetalleFacturasEstadoCuenta.Size = New System.Drawing.Size(138, 38)
        Me.btnDetalleFacturasEstadoCuenta.TabIndex = 8
        Me.btnDetalleFacturasEstadoCuenta.Text = "Imprimir Detalle de Facturas"
        '
        'chkTodasFactEstadoCuenta
        '
        Me.chkTodasFactEstadoCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTodasFactEstadoCuenta.Location = New System.Drawing.Point(290, 442)
        Me.chkTodasFactEstadoCuenta.Name = "chkTodasFactEstadoCuenta"
        Me.chkTodasFactEstadoCuenta.Properties.Caption = "Incluir Todas las Facturas Pendientes"
        Me.chkTodasFactEstadoCuenta.Size = New System.Drawing.Size(200, 19)
        Me.chkTodasFactEstadoCuenta.TabIndex = 7
        '
        'txtLstFacturas
        '
        Me.txtLstFacturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLstFacturas.CampoBusqueda = False
        Me.txtLstFacturas.CampoEsLlave = False
        Me.txtLstFacturas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLstFacturas.ControlBackColor = System.Drawing.Color.White
        Me.txtLstFacturas.ControlForeColor = System.Drawing.Color.Black
        Me.txtLstFacturas.FechaActual = False
        Me.txtLstFacturas.Formato = ""
        Me.txtLstFacturas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLstFacturas.LabelText = "Lista de Facturas"
        Me.txtLstFacturas.LabelWidth = 100
        Me.txtLstFacturas.Location = New System.Drawing.Point(20, 465)
        Me.txtLstFacturas.MaxLength = 0
        Me.txtLstFacturas.Name = "txtLstFacturas"
        Me.txtLstFacturas.NombreCampo = ""
        Me.txtLstFacturas.Obligatorio = False
        Me.txtLstFacturas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLstFacturas.Size = New System.Drawing.Size(470, 20)
        Me.txtLstFacturas.SoloLectura = False
        Me.txtLstFacturas.TabIndex = 6
        Me.txtLstFacturas.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtLstFacturas.Valor = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(640, 444)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(138, 38)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "&Imprimir Estado de Cuenta"
        '
        'PivotEstado
        '
        Me.PivotEstado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotEstado.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.LightYellow
        Me.PivotEstado.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.PivotEstado.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PivotEstado.Appearance.TotalCell.Options.UseBackColor = True
        Me.PivotEstado.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotEstado.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField12})
        PivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        PivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Black
        PivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        PivotGridStyleFormatCondition2.Field = Me.PivotGridField11
        PivotGridStyleFormatCondition2.FieldName = "PivotGridField11"
        PivotGridStyleFormatCondition2.Value1 = 150
        Me.PivotEstado.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition2})
        Me.PivotEstado.Location = New System.Drawing.Point(4, 2)
        Me.PivotEstado.Name = "PivotEstado"
        Me.PivotEstado.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotEstado.Size = New System.Drawing.Size(770, 425)
        Me.PivotEstado.TabIndex = 4
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 2
        Me.PivotGridField1.Caption = "#Factura"
        Me.PivotGridField1.FieldName = "NumeroFactura"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.Width = 85
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Producto"
        Me.PivotGridField2.FieldName = "Producto"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.Caption = "Ramo"
        Me.PivotGridField3.FieldName = "Ramo"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField4.AreaIndex = 2
        Me.PivotGridField4.Caption = "Tipo Seguro"
        Me.PivotGridField4.FieldName = "TipoSeguro"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Aseguradora"
        Me.PivotGridField5.FieldName = "Aseguradora"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 1
        Me.PivotGridField6.Caption = "Póliza"
        Me.PivotGridField6.FieldName = "Poliza"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.Width = 75
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField7.AreaIndex = 4
        Me.PivotGridField7.Caption = "Tipo Factura"
        Me.PivotGridField7.FieldName = "TipoFactura"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 5
        Me.PivotGridField8.Caption = "Cliente"
        Me.PivotGridField8.FieldName = "NombreCliente"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField9.AreaIndex = 3
        Me.PivotGridField9.Caption = "Fecha Pago"
        Me.PivotGridField9.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.FieldName = "FechaPago"
        Me.PivotGridField9.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.TotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.TotalValueFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.ValueFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 3
        Me.PivotGridField10.Caption = "Cuota"
        Me.PivotGridField10.FieldName = "Cuota"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField13.AreaIndex = 0
        Me.PivotGridField13.Caption = "Prima"
        Me.PivotGridField13.FieldName = "PrimaNeta"
        Me.PivotGridField13.Name = "PivotGridField13"
        Me.PivotGridField13.Width = 75
        '
        'PivotGridField14
        '
        Me.PivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField14.AreaIndex = 1
        Me.PivotGridField14.Caption = "Gastos"
        Me.PivotGridField14.FieldName = "Gastos"
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.Width = 75
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField15.AreaIndex = 2
        Me.PivotGridField15.Caption = "Impuestos"
        Me.PivotGridField15.FieldName = "Impuestos"
        Me.PivotGridField15.Name = "PivotGridField15"
        Me.PivotGridField15.Width = 75
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField16.AreaIndex = 3
        Me.PivotGridField16.Caption = "Total"
        Me.PivotGridField16.FieldName = "Total"
        Me.PivotGridField16.Name = "PivotGridField16"
        Me.PivotGridField16.Width = 75
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField12.AreaIndex = 6
        Me.PivotGridField12.Caption = "Referencia"
        Me.PivotGridField12.FieldName = "Referencia"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'HDeposito
        '
        Me.HDeposito.Controls.Add(Me.GridDepositos)
        Me.HDeposito.Name = "HDeposito"
        Me.HDeposito.Size = New System.Drawing.Size(777, 506)
        Me.HDeposito.Text = "Depósitos"
        '
        'GridDepositos
        '
        Me.GridDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDepositos.ColumnasAdicionales = ""
        Me.GridDepositos.Location = New System.Drawing.Point(2, 3)
        Me.GridDepositos.MainView = Me.VistaDepositos
        Me.GridDepositos.Name = "GridDepositos"
        Me.GridDepositos.NombreTabla = ""
        Me.GridDepositos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.GridDepositos.Size = New System.Drawing.Size(771, 478)
        Me.GridDepositos.TabIndex = 7
        Me.GridDepositos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDepositos})
        '
        'VistaDepositos
        '
        Me.VistaDepositos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdAseguradoraDep, Me.ColSaldoDep})
        Me.VistaDepositos.GridControl = Me.GridDepositos
        Me.VistaDepositos.Name = "VistaDepositos"
        Me.VistaDepositos.OptionsBehavior.Editable = False
        Me.VistaDepositos.OptionsView.ShowGroupPanel = False
        '
        'ColIdAseguradoraDep
        '
        Me.ColIdAseguradoraDep.Caption = "Aseguradora"
        Me.ColIdAseguradoraDep.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.ColIdAseguradoraDep.FieldName = "IdAseguradora"
        Me.ColIdAseguradoraDep.Name = "ColIdAseguradoraDep"
        Me.ColIdAseguradoraDep.Visible = True
        Me.ColIdAseguradoraDep.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'ColSaldoDep
        '
        Me.ColSaldoDep.Caption = "Saldo Depósito"
        Me.ColSaldoDep.DisplayFormat.FormatString = "c"
        Me.ColSaldoDep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSaldoDep.FieldName = "Saldo"
        Me.ColSaldoDep.Name = "ColSaldoDep"
        Me.ColSaldoDep.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColSaldoDep.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColSaldoDep.Visible = True
        Me.ColSaldoDep.VisibleIndex = 1
        '
        'IFacturas
        '
        Me.IFacturas.Controls.Add(Me.btnImpDetFacturas)
        Me.IFacturas.Controls.Add(Me.gridDetFacturas)
        Me.IFacturas.Name = "IFacturas"
        Me.IFacturas.Size = New System.Drawing.Size(777, 506)
        Me.IFacturas.Text = "Detalle Facturas"
        '
        'btnImpDetFacturas
        '
        Me.btnImpDetFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImpDetFacturas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImpDetFacturas.Appearance.Options.UseFont = True
        Me.btnImpDetFacturas.Image = CType(resources.GetObject("btnImpDetFacturas.Image"), System.Drawing.Image)
        Me.btnImpDetFacturas.Location = New System.Drawing.Point(576, 447)
        Me.btnImpDetFacturas.Name = "btnImpDetFacturas"
        Me.btnImpDetFacturas.Size = New System.Drawing.Size(200, 36)
        Me.btnImpDetFacturas.TabIndex = 6
        Me.btnImpDetFacturas.Text = "&Imprimir Detalle Facturas"
        '
        'gridDetFacturas
        '
        Me.gridDetFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDetFacturas.ColumnasAdicionales = ""
        Me.gridDetFacturas.ContextMenuStrip = Me.mnuGestion
        Me.gridDetFacturas.Location = New System.Drawing.Point(3, 3)
        Me.gridDetFacturas.MainView = Me.vistaDetFacturas
        Me.gridDetFacturas.Name = "gridDetFacturas"
        Me.gridDetFacturas.NombreTabla = ""
        Me.gridDetFacturas.Size = New System.Drawing.Size(768, 438)
        Me.gridDetFacturas.TabIndex = 0
        Me.gridDetFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vistaDetFacturas})
        '
        'mnuGestion
        '
        Me.mnuGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarGestiónCarteraToolStripMenuItem, Me.ConsultarGestiónDeCarteraToolStripMenuItem})
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(226, 48)
        '
        'AgregarGestiónCarteraToolStripMenuItem
        '
        Me.AgregarGestiónCarteraToolStripMenuItem.Name = "AgregarGestiónCarteraToolStripMenuItem"
        Me.AgregarGestiónCarteraToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.AgregarGestiónCarteraToolStripMenuItem.Text = "Agregar Gestión de Cartera"
        '
        'ConsultarGestiónDeCarteraToolStripMenuItem
        '
        Me.ConsultarGestiónDeCarteraToolStripMenuItem.Name = "ConsultarGestiónDeCarteraToolStripMenuItem"
        Me.ConsultarGestiónDeCarteraToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ConsultarGestiónDeCarteraToolStripMenuItem.Text = "Consultar Gestión de Cartera"
        '
        'vistaDetFacturas
        '
        Me.vistaDetFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVigenciaDF, Me.ColProductoDF, Me.ColAseguradoraDF, Me.colNumeroFacturaDF, Me.colFechaVencimientoDF, Me.colPolizaDF, Me.ColTotalDF, Me.ColEstadoDF, Me.colReferenciaDF, Me.colIdProductoDF, Me.ColIdRamoDF, Me.ColSaldoFact, Me.colDFFechaPago, Me.colDFFechaAnula})
        Me.vistaDetFacturas.GridControl = Me.gridDetFacturas
        Me.vistaDetFacturas.GroupCount = 4
        Me.vistaDetFacturas.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.ColTotalDF, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.colFechaVencimientoDF, "TOTAL")})
        Me.vistaDetFacturas.Name = "vistaDetFacturas"
        Me.vistaDetFacturas.OptionsBehavior.AutoExpandAllGroups = True
        Me.vistaDetFacturas.OptionsBehavior.Editable = False
        Me.vistaDetFacturas.OptionsView.ShowFooter = True
        Me.vistaDetFacturas.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColAseguradoraDF, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColProductoDF, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPolizaDF, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVigenciaDF, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNumeroFacturaDF, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colVigenciaDF
        '
        Me.colVigenciaDF.Caption = "Vigencia"
        Me.colVigenciaDF.FieldName = "Vigencia"
        Me.colVigenciaDF.Name = "colVigenciaDF"
        '
        'ColProductoDF
        '
        Me.ColProductoDF.Caption = "Producto"
        Me.ColProductoDF.FieldName = "Producto"
        Me.ColProductoDF.Name = "ColProductoDF"
        '
        'ColAseguradoraDF
        '
        Me.ColAseguradoraDF.Caption = "Aseguradora"
        Me.ColAseguradoraDF.FieldName = "Aseguradora"
        Me.ColAseguradoraDF.Name = "ColAseguradoraDF"
        '
        'colNumeroFacturaDF
        '
        Me.colNumeroFacturaDF.Caption = "NumeroFactura"
        Me.colNumeroFacturaDF.FieldName = "NumeroFactura"
        Me.colNumeroFacturaDF.Name = "colNumeroFacturaDF"
        Me.colNumeroFacturaDF.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colNumeroFacturaDF.Visible = True
        Me.colNumeroFacturaDF.VisibleIndex = 0
        Me.colNumeroFacturaDF.Width = 114
        '
        'colFechaVencimientoDF
        '
        Me.colFechaVencimientoDF.Caption = "Fecha Vencimiento"
        Me.colFechaVencimientoDF.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaVencimientoDF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaVencimientoDF.FieldName = "FechaVencimiento"
        Me.colFechaVencimientoDF.Name = "colFechaVencimientoDF"
        Me.colFechaVencimientoDF.Visible = True
        Me.colFechaVencimientoDF.VisibleIndex = 1
        Me.colFechaVencimientoDF.Width = 139
        '
        'colPolizaDF
        '
        Me.colPolizaDF.Caption = "Póliza"
        Me.colPolizaDF.FieldName = "Poliza"
        Me.colPolizaDF.Name = "colPolizaDF"
        '
        'ColTotalDF
        '
        Me.ColTotalDF.Caption = "Total Factura"
        Me.ColTotalDF.DisplayFormat.FormatString = "c"
        Me.ColTotalDF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalDF.FieldName = "Total"
        Me.ColTotalDF.Name = "ColTotalDF"
        Me.ColTotalDF.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColTotalDF.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColTotalDF.Visible = True
        Me.ColTotalDF.VisibleIndex = 2
        Me.ColTotalDF.Width = 111
        '
        'ColEstadoDF
        '
        Me.ColEstadoDF.Caption = "Estado"
        Me.ColEstadoDF.FieldName = "Estado"
        Me.ColEstadoDF.Name = "ColEstadoDF"
        Me.ColEstadoDF.Visible = True
        Me.ColEstadoDF.VisibleIndex = 4
        Me.ColEstadoDF.Width = 89
        '
        'colReferenciaDF
        '
        Me.colReferenciaDF.Caption = "Referencia"
        Me.colReferenciaDF.FieldName = "Referencia"
        Me.colReferenciaDF.Name = "colReferenciaDF"
        Me.colReferenciaDF.Visible = True
        Me.colReferenciaDF.VisibleIndex = 5
        Me.colReferenciaDF.Width = 198
        '
        'colIdProductoDF
        '
        Me.colIdProductoDF.Caption = "IdProducto"
        Me.colIdProductoDF.FieldName = "IdProducto"
        Me.colIdProductoDF.Name = "colIdProductoDF"
        '
        'ColIdRamoDF
        '
        Me.ColIdRamoDF.Caption = "IdRamo"
        Me.ColIdRamoDF.FieldName = "IdRamo"
        Me.ColIdRamoDF.Name = "ColIdRamoDF"
        '
        'ColSaldoFact
        '
        Me.ColSaldoFact.Caption = "Saldo Factura"
        Me.ColSaldoFact.DisplayFormat.FormatString = "c"
        Me.ColSaldoFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSaldoFact.FieldName = "Saldo"
        Me.ColSaldoFact.Name = "ColSaldoFact"
        Me.ColSaldoFact.Visible = True
        Me.ColSaldoFact.VisibleIndex = 3
        Me.ColSaldoFact.Width = 96
        '
        'colDFFechaPago
        '
        Me.colDFFechaPago.Caption = "Fecha de Pago"
        Me.colDFFechaPago.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colDFFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDFFechaPago.FieldName = "FechaPago"
        Me.colDFFechaPago.Name = "colDFFechaPago"
        '
        'colDFFechaAnula
        '
        Me.colDFFechaAnula.Caption = "Fecha Anulación"
        Me.colDFFechaAnula.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colDFFechaAnula.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDFFechaAnula.FieldName = "FechaAnula"
        Me.colDFFechaAnula.Name = "colDFFechaAnula"
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
        Me.StiTextBox1.LabelText = "TELÉFONO DE OFICINA:"
        Me.StiTextBox1.LabelWidth = 150
        Me.StiTextBox1.Location = New System.Drawing.Point(3, 251)
        Me.StiTextBox1.MaxLength = 150
        Me.StiTextBox1.Name = "StiTextBox1"
        Me.StiTextBox1.NombreCampo = "jur_TelOficina"
        Me.StiTextBox1.Obligatorio = False
        Me.StiTextBox1.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox1.Size = New System.Drawing.Size(375, 20)
        Me.StiTextBox1.SoloLectura = False
        Me.StiTextBox1.TabIndex = 27
        Me.StiTextBox1.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox1.Valor = ""
        '
        'StiMemo2
        '
        Me.StiMemo2.CampoBusqueda = False
        Me.StiMemo2.CampoEsLlave = False
        Me.StiMemo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiMemo2.ControlBackColor = System.Drawing.Color.White
        Me.StiMemo2.ControlForeColor = System.Drawing.Color.Black
        Me.StiMemo2.FechaActual = False
        Me.StiMemo2.Formato = ""
        Me.StiMemo2.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.StiMemo2.LabelText = "Etiqueta"
        Me.StiMemo2.LabelWidth = 100
        Me.StiMemo2.Location = New System.Drawing.Point(429, 680)
        Me.StiMemo2.MaxLength = 0
        Me.StiMemo2.Name = "StiMemo2"
        Me.StiMemo2.NombreCampo = ""
        Me.StiMemo2.Obligatorio = False
        Me.StiMemo2.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiMemo2.Size = New System.Drawing.Size(300, 16)
        Me.StiMemo2.SoloLectura = False
        Me.StiMemo2.TabIndex = 29
        Me.StiMemo2.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.StiMemo2.Valor = ""
        '
        'StiTextBox2
        '
        Me.StiTextBox2.CampoBusqueda = False
        Me.StiTextBox2.CampoEsLlave = False
        Me.StiTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox2.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox2.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox2.FechaActual = False
        Me.StiTextBox2.Formato = ""
        Me.StiTextBox2.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox2.LabelText = "FAX:"
        Me.StiTextBox2.LabelWidth = 150
        Me.StiTextBox2.Location = New System.Drawing.Point(384, 251)
        Me.StiTextBox2.MaxLength = 150
        Me.StiTextBox2.Name = "StiTextBox2"
        Me.StiTextBox2.NombreCampo = "jur_FaxOficina"
        Me.StiTextBox2.Obligatorio = False
        Me.StiTextBox2.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox2.Size = New System.Drawing.Size(358, 20)
        Me.StiTextBox2.SoloLectura = False
        Me.StiTextBox2.TabIndex = 28
        Me.StiTextBox2.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox2.Valor = ""
        '
        'StiMemo3
        '
        Me.StiMemo3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiMemo3.CampoBusqueda = False
        Me.StiMemo3.CampoEsLlave = False
        Me.StiMemo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiMemo3.ControlBackColor = System.Drawing.Color.White
        Me.StiMemo3.ControlForeColor = System.Drawing.Color.Black
        Me.StiMemo3.FechaActual = False
        Me.StiMemo3.Formato = ""
        Me.StiMemo3.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.StiMemo3.LabelText = "DIRECCIÓN OFICINA:"
        Me.StiMemo3.LabelWidth = 150
        Me.StiMemo3.Location = New System.Drawing.Point(3, 209)
        Me.StiMemo3.MaxLength = 0
        Me.StiMemo3.Name = "StiMemo3"
        Me.StiMemo3.NombreCampo = "jur_DireccionOficina"
        Me.StiMemo3.Obligatorio = False
        Me.StiMemo3.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiMemo3.Size = New System.Drawing.Size(739, 39)
        Me.StiMemo3.SoloLectura = False
        Me.StiMemo3.TabIndex = 26
        Me.StiMemo3.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.StiMemo3.Valor = ""
        '
        'StiTextBox3
        '
        Me.StiTextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiTextBox3.CampoBusqueda = False
        Me.StiTextBox3.CampoEsLlave = False
        Me.StiTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox3.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox3.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox3.FechaActual = False
        Me.StiTextBox3.Formato = ""
        Me.StiTextBox3.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox3.LabelText = "ENCARGADO DE PÓLIZA:"
        Me.StiTextBox3.LabelWidth = 150
        Me.StiTextBox3.Location = New System.Drawing.Point(3, 186)
        Me.StiTextBox3.MaxLength = 250
        Me.StiTextBox3.Name = "StiTextBox3"
        Me.StiTextBox3.NombreCampo = "jur_EncargadoPoliza"
        Me.StiTextBox3.Obligatorio = False
        Me.StiTextBox3.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox3.Size = New System.Drawing.Size(739, 20)
        Me.StiTextBox3.SoloLectura = False
        Me.StiTextBox3.TabIndex = 25
        Me.StiTextBox3.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox3.Valor = ""
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Location = New System.Drawing.Point(525, 166)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(152, 13)
        Me.LabelControl13.TabIndex = 24
        Me.LabelControl13.Text = "(Lic, Ing, Dr. Sr. Sra, Arq, otro)"
        '
        'StiTextBox4
        '
        Me.StiTextBox4.CampoBusqueda = False
        Me.StiTextBox4.CampoEsLlave = False
        Me.StiTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox4.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox4.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox4.FechaActual = False
        Me.StiTextBox4.Formato = ""
        Me.StiTextBox4.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox4.LabelText = "PROFESIÓN:"
        Me.StiTextBox4.LabelWidth = 150
        Me.StiTextBox4.Location = New System.Drawing.Point(3, 163)
        Me.StiTextBox4.MaxLength = 250
        Me.StiTextBox4.Name = "StiTextBox4"
        Me.StiTextBox4.NombreCampo = "jur_Profesion"
        Me.StiTextBox4.Obligatorio = False
        Me.StiTextBox4.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox4.Size = New System.Drawing.Size(533, 20)
        Me.StiTextBox4.SoloLectura = False
        Me.StiTextBox4.TabIndex = 23
        Me.StiTextBox4.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox4.Valor = ""
        '
        'StiTextBox5
        '
        Me.StiTextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiTextBox5.CampoBusqueda = False
        Me.StiTextBox5.CampoEsLlave = False
        Me.StiTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox5.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox5.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox5.FechaActual = False
        Me.StiTextBox5.Formato = ""
        Me.StiTextBox5.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox5.LabelText = "CELULAR:"
        Me.StiTextBox5.LabelWidth = 150
        Me.StiTextBox5.Location = New System.Drawing.Point(3, 140)
        Me.StiTextBox5.MaxLength = 50
        Me.StiTextBox5.Name = "StiTextBox5"
        Me.StiTextBox5.NombreCampo = "jur_TelMovil"
        Me.StiTextBox5.Obligatorio = False
        Me.StiTextBox5.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox5.Size = New System.Drawing.Size(739, 20)
        Me.StiTextBox5.SoloLectura = False
        Me.StiTextBox5.TabIndex = 22
        Me.StiTextBox5.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox5.Valor = ""
        '
        'StiTextBox6
        '
        Me.StiTextBox6.CampoBusqueda = False
        Me.StiTextBox6.CampoEsLlave = False
        Me.StiTextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox6.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox6.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox6.FechaActual = False
        Me.StiTextBox6.Formato = ""
        Me.StiTextBox6.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox6.LabelText = "PIN BB:"
        Me.StiTextBox6.LabelWidth = 150
        Me.StiTextBox6.Location = New System.Drawing.Point(384, 117)
        Me.StiTextBox6.MaxLength = 50
        Me.StiTextBox6.Name = "StiTextBox6"
        Me.StiTextBox6.NombreCampo = "jur_PinBB"
        Me.StiTextBox6.Obligatorio = False
        Me.StiTextBox6.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox6.Size = New System.Drawing.Size(358, 20)
        Me.StiTextBox6.SoloLectura = False
        Me.StiTextBox6.TabIndex = 21
        Me.StiTextBox6.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox6.Valor = ""
        '
        'StiTextBox7
        '
        Me.StiTextBox7.CampoBusqueda = False
        Me.StiTextBox7.CampoEsLlave = False
        Me.StiTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox7.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox7.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox7.FechaActual = False
        Me.StiTextBox7.Formato = ""
        Me.StiTextBox7.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox7.LabelText = "NOMBRE DE REP. LEGAL:"
        Me.StiTextBox7.LabelWidth = 150
        Me.StiTextBox7.Location = New System.Drawing.Point(3, 117)
        Me.StiTextBox7.MaxLength = 250
        Me.StiTextBox7.Name = "StiTextBox7"
        Me.StiTextBox7.NombreCampo = "jur_RepresentanteLegal"
        Me.StiTextBox7.Obligatorio = False
        Me.StiTextBox7.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox7.Size = New System.Drawing.Size(375, 20)
        Me.StiTextBox7.SoloLectura = False
        Me.StiTextBox7.TabIndex = 20
        Me.StiTextBox7.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox7.Valor = ""
        '
        'StiTextBox8
        '
        Me.StiTextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiTextBox8.CampoBusqueda = False
        Me.StiTextBox8.CampoEsLlave = False
        Me.StiTextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox8.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox8.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox8.FechaActual = False
        Me.StiTextBox8.Formato = ""
        Me.StiTextBox8.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox8.LabelText = "GIRO DEL NEGOCIO:"
        Me.StiTextBox8.LabelWidth = 150
        Me.StiTextBox8.Location = New System.Drawing.Point(3, 94)
        Me.StiTextBox8.MaxLength = 250
        Me.StiTextBox8.Name = "StiTextBox8"
        Me.StiTextBox8.NombreCampo = "jur_Giro"
        Me.StiTextBox8.Obligatorio = False
        Me.StiTextBox8.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox8.Size = New System.Drawing.Size(739, 20)
        Me.StiTextBox8.SoloLectura = False
        Me.StiTextBox8.TabIndex = 19
        Me.StiTextBox8.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox8.Valor = ""
        '
        'StiTextBox9
        '
        Me.StiTextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiTextBox9.CampoBusqueda = False
        Me.StiTextBox9.CampoEsLlave = False
        Me.StiTextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiTextBox9.ControlBackColor = System.Drawing.Color.White
        Me.StiTextBox9.ControlForeColor = System.Drawing.Color.Black
        Me.StiTextBox9.FechaActual = False
        Me.StiTextBox9.Formato = ""
        Me.StiTextBox9.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.StiTextBox9.LabelText = "NOMBRE DE LA EMPRESA:"
        Me.StiTextBox9.LabelWidth = 150
        Me.StiTextBox9.Location = New System.Drawing.Point(3, 71)
        Me.StiTextBox9.MaxLength = 250
        Me.StiTextBox9.Name = "StiTextBox9"
        Me.StiTextBox9.NombreCampo = "jur_NombreEmpresa"
        Me.StiTextBox9.Obligatorio = False
        Me.StiTextBox9.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox9.Size = New System.Drawing.Size(739, 20)
        Me.StiTextBox9.SoloLectura = False
        Me.StiTextBox9.TabIndex = 18
        Me.StiTextBox9.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.StiTextBox9.Valor = ""
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl14.Appearance.Options.UseBackColor = True
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseTextOptions = True
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl14.Location = New System.Drawing.Point(3, 37)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(288, 28)
        Me.LabelControl14.TabIndex = 17
        Me.LabelControl14.Text = "INFORMACIÓN GENERAL"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Appearance.Options.UseBackColor = True
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseTextOptions = True
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LabelControl15.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(752, 28)
        Me.LabelControl15.TabIndex = 16
        Me.LabelControl15.Text = "FICHA DE DATOS CLIENTE NUEVO PERSONA EMPRESA"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.Appearance.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblEstado.Appearance.Options.UseFont = True
        Me.lblEstado.Appearance.Options.UseForeColor = True
        Me.lblEstado.Appearance.Options.UseTextOptions = True
        Me.lblEstado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEstado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblEstado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblEstado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEstado.Location = New System.Drawing.Point(131, 53)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(650, 17)
        Me.lblEstado.TabIndex = 19
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ClientesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 512
        Me.ClientSize = New System.Drawing.Size(790, 660)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "ClientesMan"
        Me.Text = "Registro de Clientes"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        Me.Controls.SetChildIndex(Me.lblEstado, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.AGeneral.ResumeLayout(False)
        CType(Me.TabClientesInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabClientesInfo.ResumeLayout(False)
        Me.TabClientesContactos.ResumeLayout(False)
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabClientesEjectivos.ResumeLayout(False)
        CType(Me.GridEjecutivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEjecutivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGridEjecutivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGridRamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGridTipoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGridArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabClientesDocumentos.ResumeLayout(False)
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCliNatural.ResumeLayout(False)
        CType(Me.gridDatosNat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDatosNat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCliJuridica.ResumeLayout(False)
        CType(Me.gridDatJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDatJuridica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JCliNatural.ResumeLayout(False)
        Me.JCliNatural.PerformLayout()
        Me.KCliEmpresa.ResumeLayout(False)
        Me.KCliEmpresa.PerformLayout()
        Me.CPolizas.ResumeLayout(False)
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JCertificados.ResumeLayout(False)
        CType(Me.GridCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DPrimas.ResumeLayout(False)
        CType(Me.PivotFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EAvisosCobro.ResumeLayout(False)
        CType(Me.GridAvisosCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAvisoCobro.ResumeLayout(False)
        CType(Me.VistaAvisosCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FSiniestros.ResumeLayout(False)
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GEstadoCuenta.ResumeLayout(False)
        CType(Me.chkTodasFactEstadoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HDeposito.ResumeLayout(False)
        CType(Me.GridDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IFacturas.ResumeLayout(False)
        CType(Me.gridDetFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuGestion.ResumeLayout(False)
        CType(Me.vistaDetFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents AGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtFechaNacimiento As STIControles.stiTextBox
    Friend WithEvents stiGiro As STIControles.stiTextBox
    Friend WithEvents txtRegistroFiscal As STIControles.stiTextBox
    Friend WithEvents txtDui As STIControles.stiTextBox
    Friend WithEvents CPolizas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DPrimas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtEmail As STIControles.stiTextBox
    Friend WithEvents cboIdTipoCliente As STIControles.stiComboBox
    Friend WithEvents txtFax As STIControles.stiTextBox
    Friend WithEvents StiGrid1 As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdContacto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PivotFacturas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ColNumFactura As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColProducto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColRamo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColTipoSeguro As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColAseguradora As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColPoliza As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColTipoFactura As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColFechaPago As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColCuota As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColDiasMora As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColRangoMora As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColPrima As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColGastos As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColImpuestos As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColTotal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents EAvisosCobro As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FSiniestros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GEstadoCuenta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridAvisosCobro As STIControles.stiGrid
    Friend WithEvents VistaAvisosCobro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdAvisoCobro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdAnexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuAvisoCobro As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConsultarAvisoDeCobroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents txtLugarTrabajo As STIControles.stiTextBox
    Friend WithEvents colCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsoCorrespondencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtTelRepLegal As STIControles.stiTextBox
    Friend WithEvents txtNitRepLegal As STIControles.stiTextBox
    Friend WithEvents txtNombreRepLegal As STIControles.stiTextBox
    Friend WithEvents PivotEstado As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents HDeposito As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridDepositos As STIControles.stiGrid
    Friend WithEvents VistaDepositos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdAseguradoraDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColSaldoDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IFacturas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridDetFacturas As STIControles.stiGrid
    Friend WithEvents vistaDetFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnImpDetFacturas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colVigenciaDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProductoDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAseguradoraDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroFacturaDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVencimientoDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPolizaDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEstadoDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferenciaDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProductoDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdRamoDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridPolizas As STIControles.stiGrid
    Friend WithEvents VistaPolizas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColPPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpNProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPVigDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpVigHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpFechaCan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpMotivoCan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JCertificados As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCertificados As STIControles.stiGrid
    Friend WithEvents VistaCertificados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCertIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertVigDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertPrimaNeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertGastos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridSiniestros As STIControles.stiGrid
    Friend WithEvents VistaSiniestros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSinProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinReclamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinFecOcurre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinValorPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinValorPagado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaVinculacion As STIControles.stiTextBox
    Friend WithEvents colFechaNacimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMail As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnImprimirListaPolizas As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnImprimirCertificados As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnImprimirPrimasPend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLstFacturas As STIControles.stiTextBox
    Friend WithEvents mnuGestion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarGestiónCarteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarGestiónDeCarteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtInicialesFlujo As STIControles.stiTextBox
    Friend WithEvents txtVencimientoTarjeta As STIControles.stiTextBox
    Friend WithEvents txtTarjetaHabiente As STIControles.stiTextBox
    Friend WithEvents txtNumeroTarjeta As STIControles.stiTextBox
    Friend WithEvents JCliNatural As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnat_Profesion As STIControles.stiTextBox
    Friend WithEvents txtnat_twitter As STIControles.stiTextBox
    Friend WithEvents txtnat_Facebook As STIControles.stiTextBox
    Friend WithEvents txtnat_NumHijos As STIControles.stiTextBox
    Friend WithEvents txtnat_PinBB As STIControles.stiTextBox
    Friend WithEvents txtnat_FaxTrabajo As STIControles.stiTextBox
    Friend WithEvents txtnat_TelTrabajo As STIControles.stiTextBox
    Friend WithEvents txtnat_Cargo As STIControles.stiTextBox
    Friend WithEvents txtnat_LugarTrabajo As STIControles.stiTextBox
    Friend WithEvents txtnat_EmailCasa As STIControles.stiTextBox
    Friend WithEvents txtnat_EstadoCivil As STIControles.stiTextBox
    Friend WithEvents txtnat_TelMovil As STIControles.stiTextBox
    Friend WithEvents txtnat_TelCasa As STIControles.stiTextBox
    Friend WithEvents txtnat_NombreCliente As STIControles.stiTextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnat_DireccionCasa As STIControles.stiMemo
    Friend WithEvents cbonat_TieneHijos As STIControles.stiComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnat_DireccionTrabajo As STIControles.stiMemo
    Friend WithEvents txtnat_EmailTrabajo As STIControles.stiTextBox
    Friend WithEvents txtnat_PaginaWeb As STIControles.stiTextBox
    Friend WithEvents txtnat_ContactoCobro As STIControles.stiTextBox
    Friend WithEvents txtnat_ReferidoPor As STIControles.stiTextBox
    Friend WithEvents txtnat_MedioInformacion As STIControles.stiTextBox
    Friend WithEvents cbonat_PreferenciaCobro As STIControles.stiComboBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbonat_PreferenciaPago As STIControles.stiComboBox
    Friend WithEvents cbonat_ClienteExistente As STIControles.stiComboBox
    Friend WithEvents txtnat_Hobbie As STIControles.stiTextBox
    Friend WithEvents txtnat_Deporte As STIControles.stiTextBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnat_Religion As STIControles.stiTextBox
    Friend WithEvents txtnat_Bebida As STIControles.stiTextBox
    Friend WithEvents txtnat_Musica As STIControles.stiTextBox
    Friend WithEvents txtnat_Comida As STIControles.stiTextBox
    Friend WithEvents txtnat_Cesion As STIControles.stiMemo
    Friend WithEvents txtnat_Comentarios As STIControles.stiMemo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnat_FechaFormulario As STIControles.stiTextBox
    Friend WithEvents txtnat_CompletaFormulario As STIControles.stiTextBox
    Friend WithEvents KCliEmpresa As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtjur_PinBB As STIControles.stiTextBox
    Friend WithEvents txtjur_RepresentanteLegal As STIControles.stiTextBox
    Friend WithEvents txtjur_Giro As STIControles.stiTextBox
    Friend WithEvents txtjur_NombreEmpresa As STIControles.stiTextBox
    Friend WithEvents jur_DireccionOficina As STIControles.stiMemo
    Friend WithEvents txtjur_EncargadoPoliza As STIControles.stiTextBox
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtjur_Profesion As STIControles.stiTextBox
    Friend WithEvents txtjur_TelMovil As STIControles.stiTextBox
    Friend WithEvents txtjur_FaxOficina As STIControles.stiTextBox
    Friend WithEvents txtjur_TelOficina As STIControles.stiTextBox
    Friend WithEvents txtjur_Email As STIControles.stiTextBox
    Friend WithEvents StiTextBox1 As STIControles.stiTextBox
    Friend WithEvents StiMemo2 As STIControles.stiMemo
    Friend WithEvents StiTextBox2 As STIControles.stiTextBox
    Friend WithEvents StiMemo3 As STIControles.stiMemo
    Friend WithEvents StiTextBox3 As STIControles.stiTextBox
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StiTextBox4 As STIControles.stiTextBox
    Friend WithEvents StiTextBox5 As STIControles.stiTextBox
    Friend WithEvents StiTextBox6 As STIControles.stiTextBox
    Friend WithEvents StiTextBox7 As STIControles.stiTextBox
    Friend WithEvents StiTextBox8 As STIControles.stiTextBox
    Friend WithEvents StiTextBox9 As STIControles.stiTextBox
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtjur_PolPinBB As STIControles.stiTextBox
    Friend WithEvents txtjur_Twitter As STIControles.stiTextBox
    Friend WithEvents txtjur_Facebook As STIControles.stiTextBox
    Friend WithEvents txtjur_PaginaWeb As STIControles.stiTextBox
    Friend WithEvents txtjur_ClienteExiste As STIControles.stiComboBox
    Friend WithEvents txtjur_ReferidoPor As STIControles.stiTextBox
    Friend WithEvents txtjur_CobroEmail As STIControles.stiTextBox
    Friend WithEvents txtjur_CobroFax As STIControles.stiTextBox
    Friend WithEvents txtjur_CobroTelefono As STIControles.stiTextBox
    Friend WithEvents txtjur_ContactoCobro As STIControles.stiTextBox
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtjur_Cesion As STIControles.stiMemo
    Friend WithEvents txtjur_Pagador As STIControles.stiTextBox
    Friend WithEvents txtjur_FormaPago As STIControles.stiTextBox
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtjur_ActPaginaWeb As STIControles.stiTextBox
    Friend WithEvents txtjur_ActEmail As STIControles.stiTextBox
    Friend WithEvents txtjur_ActFax As STIControles.stiTextBox
    Friend WithEvents txtjur_ActTelefonos As STIControles.stiTextBox
    Friend WithEvents txtjur_ActDireccion As STIControles.stiMemo
    Friend WithEvents txtjur_Comentario As STIControles.stiMemo
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnImprimirNatural As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnImprimirJuridico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEnvioFactura As STIControles.stiTextBox
    Friend WithEvents cboIdTipoPago As STIControles.stiComboBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StiTextBox10 As STIControles.stiTextBox
    Friend WithEvents TabClientesInfo As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabClientesContactos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabClientesEjectivos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridEjecutivos As STIControles.stiGrid
    Friend WithEvents VistaEjecutivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAgregarEjecutivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarEjecutivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdCliente2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdEjecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboGridEjecutivo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboGridRamo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboGridTipoProducto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboGridArea As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkTodasFactEstadoCuenta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFnacRepLegal As STIControles.stiTextBox
    Friend WithEvents cboIdBanco As STIControles.stiComboBox
    Friend WithEvents cboEstadoCliente As STIControles.stiComboBox
    Friend WithEvents txtEmisorTarjeta As STIControles.stiTextBox
    Friend WithEvents txtConocidoPor As STIControles.stiTextBox
    Public WithEvents btnDetalleFacturasEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEstado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents TabClientesDocumentos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridDoc As STIControles.stiGrid
    Friend WithEvents VistaDoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColArchivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDirectorio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarCarpeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ColSaldoFact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFFechaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFFechaAnula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabCliNatural As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabCliJuridica As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridDatosNat As STIControles.stiGrid
    Friend WithEvents VistaDatosNat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridDatJuridica As STIControles.stiGrid
    Friend WithEvents VistaDatJuridica As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDNIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNIdCampo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDJIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCampo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDJNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDJDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNombreCuentaHabiente As STIControles.stiTextBox
    Friend WithEvents txtCuentaBancaria As STIControles.stiTextBox
    Friend WithEvents cboReferidoPor As STIControles.stiComboBox

End Class
