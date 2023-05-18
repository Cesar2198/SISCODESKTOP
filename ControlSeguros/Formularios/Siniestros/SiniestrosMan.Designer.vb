<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiniestrosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiniestrosMan))
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtDescripcionReserva = New STIControles.stiTextBox
        Me.txtTotalDeducible = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.cboEstadoSiniestro = New STIControles.stiComboBox
        Me.txtLugarSiniestros = New STIControles.stiTextBox
        Me.txtNombrePresentaReclamo = New STIControles.stiTextBox
        Me.txtFechaPresentado = New STIControles.stiTextBox
        Me.txtFechaOcurrido = New STIControles.stiTextBox
        Me.txtDescripcionSiniestro = New STIControles.stiTextBox
        Me.txtTotalDeudores = New STIControles.stiTextBox
        Me.txtTotalCoaseguro = New STIControles.stiTextBox
        Me.txtTotalCubierto = New STIControles.stiTextBox
        Me.txtTotalNoCubierto = New STIControles.stiTextBox
        Me.txtTotalPresentado = New STIControles.stiTextBox
        Me.txtTotalReembolso = New STIControles.stiTextBox
        Me.TabSiniestros = New DevExpress.XtraTab.XtraTabControl
        Me.Detalle = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarGastos = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGasto = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetalle = New STIControles.stiGrid
        Me.VistaDetalles = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDetIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetDescripcionGastos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDetValorPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetValorNoCubierto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetValorCubierto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtVistaDetalleComentarios = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDetIdEnvio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetFechaEnvio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Informacion = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarInfo = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarInfo = New DevExpress.XtraEditors.SimpleButton
        Me.GridInfo = New STIControles.stiGrid
        Me.VistaInfo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colInfoIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInfoIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInfoIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInfoIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInfoIdInformacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInfoDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colInfoDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Reserva = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarReserva = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarReserva = New DevExpress.XtraEditors.SimpleButton
        Me.GridReserva = New STIControles.stiGrid
        Me.VistaReserva = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colResIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResIdCobertura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResFechaReserva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResValorAsegurado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colResValorReserva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGrupoCobertura = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Pagos = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarPago = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarPago = New DevExpress.XtraEditors.SimpleButton
        Me.GridPagos = New STIControles.stiGrid
        Me.VistaPagos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPagIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPagIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPagIdPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagFechaPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagNombreCheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPagNumeroCheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPagValorGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPagValorDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColArcValorRenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPagValorIva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagValorRetencionIva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagValorReembolso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGrupoCobPago = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Deudores = New DevExpress.XtraTab.XtraTabPage
        Me.btnQuitarDeudor = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarDeudor = New DevExpress.XtraEditors.SimpleButton
        Me.GridDeudores = New STIControles.stiGrid
        Me.VistaDeudores = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDedIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDedIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldedIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDedIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDedIdDeudor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDedFechaDeudor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDedDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDedValorDeudor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Requisitos = New DevExpress.XtraTab.XtraTabPage
        Me.btnCargarRequisitos = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarRequisito = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarRequisito = New DevExpress.XtraEditors.SimpleButton
        Me.GridRequisitos = New STIControles.stiGrid
        Me.VistaRequisitos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colReqIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqIdRequisito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqFechaPresentado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReqComentarios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Archivos = New DevExpress.XtraTab.XtraTabPage
        Me.btnAgregarCarpeta = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarDoc = New DevExpress.XtraEditors.SimpleButton
        Me.GridArchivos = New STIControles.stiGrid
        Me.VistaArchivos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colArcIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcIdDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colArcDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Bienes = New DevExpress.XtraTab.XtraTabPage
        Me.btnEditarCertificado = New DevExpress.XtraEditors.SimpleButton
        Me.GridBienes = New STIControles.stiGrid
        Me.VistaBienes = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colbiIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiIdBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbiNombreBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colbiDescripcionBien = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.Coberturas = New DevExpress.XtraTab.XtraTabPage
        Me.GridCoberturas = New STIControles.stiGrid
        Me.VistaCoberturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCobertura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorceSuma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTasa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDeducible = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Gestiones = New DevExpress.XtraTab.XtraTabPage
        Me.cboPendientePor = New STIControles.stiComboBox
        Me.btnGestionOutlook = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuitarGestion = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGestion = New DevExpress.XtraEditors.SimpleButton
        Me.GridGestiones = New STIControles.stiGrid
        Me.VistaGestiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGesIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdSiniestro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesTipoGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesFechaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesComentarios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesIdUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGesFechaProximaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Fechas = New DevExpress.XtraTab.XtraTabPage
        Me.lytFechas = New DevExpress.XtraLayout.LayoutControl
        Me.txtFechaFinalReclamo = New STIControles.stiTextBox
        Me.txtFechaEnvioFiniquitoAseg = New STIControles.stiTextBox
        Me.txtFechaEntregaFiniquito = New STIControles.stiTextBox
        Me.txtFechaEntregaCheque = New STIControles.stiTextBox
        Me.txtFechaAsegEntregaCheque = New STIControles.stiTextBox
        Me.txtFechaFirmaConvAjuste = New STIControles.stiTextBox
        Me.txtFechaRecibeConvAjuste = New STIControles.stiTextBox
        Me.txtFechaCienteEntregaDocs = New STIControles.stiTextBox
        Me.txtFechaInspeccion = New STIControles.stiTextBox
        Me.txtFechaAvisoAseguradora = New STIControles.stiTextBox
        Me.txtFechaAjustadorReqDocs = New STIControles.stiTextBox
        Me.txtFechaEnvioClientreConvAju = New STIControles.stiTextBox
        Me.txtFechaEnvioConvAseg = New STIControles.stiTextBox
        Me.txtFechaEnvioDocAseg = New STIControles.stiTextBox
        Me.txtFechaSolicitaInspeccion = New STIControles.stiTextBox
        Me.txtFechaAvisoCliente = New STIControles.stiTextBox
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtTotalPendiente = New STIControles.stiTextBox
        Me.btnBuscaCertificado = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdBien = New STIControles.stiTextBox
        Me.txtIdEnvio = New STIControles.stiTextBox
        Me.txtIdSiniestroAseguradora = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtAcumuladoCoaseguro = New STIControles.stiTextBox
        Me.txtAcumuladoDeducible = New STIControles.stiTextBox
        Me.txtLimiteCoaseguro = New STIControles.stiTextBox
        Me.txtLimiteDeducible = New STIControles.stiTextBox
        Me.txtFechaActualizacion = New STIControles.stiTextBox
        Me.txtEstadoUsuario = New STIControles.stiTextBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.cboEstadoSiniestroInterno = New STIControles.stiComboBox
        Me.txtFlujo = New STIControles.stiTextBox
        Me.cboTipoSiniestro = New STIControles.stiComboBox
        Me.cboAmbitoSiniestro = New STIControles.stiComboBox
        Me.txtDescripcionLiquidacion = New STIControles.stiTextBox
        Me.txtTitularCertificado = New STIControles.stiTextBox
        Me.btnGenerarEnvio = New DevExpress.XtraEditors.SimpleButton
        Me.txtDiagnostico = New STIControles.stiTextBox
        Me.btnBuscarDiagnostico = New DevExpress.XtraEditors.SimpleButton
        Me.cboNombreTaller = New STIControles.stiComboBox
        Me.cboNombreCobAfecta = New STIControles.stiComboBox
        Me.txtNombreConductor = New STIControles.stiTextBox
        Me.txtNoFolioReferencia = New STIControles.stiTextBox
        Me.cboClaseSiniestro = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSiniestros.SuspendLayout()
        Me.Detalle.SuspendLayout()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVistaDetalleComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Informacion.SuspendLayout()
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reserva.SuspendLayout()
        CType(Me.GridReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoCobertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pagos.SuspendLayout()
        CType(Me.GridPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoCobPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Deudores.SuspendLayout()
        CType(Me.GridDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Requisitos.SuspendLayout()
        CType(Me.GridRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Archivos.SuspendLayout()
        CType(Me.GridArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bienes.SuspendLayout()
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Coberturas.SuspendLayout()
        CType(Me.GridCoberturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaCoberturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gestiones.SuspendLayout()
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fechas.SuspendLayout()
        CType(Me.lytFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lytFechas.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(607, 631)
        Me.btnAyuda.Size = New System.Drawing.Size(87, 36)
        Me.btnAyuda.TabIndex = 25
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(421, 631)
        Me.btnBuscar.TabIndex = 23
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(36, 631)
        Me.btnNuevo.TabIndex = 21
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(129, 631)
        Me.btnGuardar.TabIndex = 20
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(694, 631)
        Me.btnSalir.Size = New System.Drawing.Size(83, 36)
        Me.btnSalir.TabIndex = 26
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(514, 631)
        Me.btnEliminar.TabIndex = 24
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(637, 74)
        Me.lblNombreFormulario.TabIndex = 38
        Me.lblNombreFormulario.Text = "Administración de Reclamos de Seguros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(45, 657)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 37
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
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 120
        Me.txtIdPoliza.Location = New System.Drawing.Point(8, 122)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(262, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 3
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = True
        Me.txtIdCertificado.CampoEsLlave = True
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 110
        Me.txtIdCertificado.Location = New System.Drawing.Point(276, 122)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(249, 20)
        Me.txtIdCertificado.SoloLectura = False
        Me.txtIdCertificado.TabIndex = 4
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
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
        Me.txtIdSiniestro.LabelText = "Núm. Reclamo"
        Me.txtIdSiniestro.LabelWidth = 120
        Me.txtIdSiniestro.Location = New System.Drawing.Point(8, 77)
        Me.txtIdSiniestro.MaxLength = 25
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = "IdSiniestro"
        Me.txtIdSiniestro.Obligatorio = True
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(262, 20)
        Me.txtIdSiniestro.SoloLectura = False
        Me.txtIdSiniestro.TabIndex = 0
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtDescripcionReserva
        '
        Me.txtDescripcionReserva.CampoBusqueda = False
        Me.txtDescripcionReserva.CampoEsLlave = False
        Me.txtDescripcionReserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionReserva.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionReserva.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionReserva.FechaActual = False
        Me.txtDescripcionReserva.Formato = ""
        Me.txtDescripcionReserva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDescripcionReserva.LabelText = "Comentario Reserva"
        Me.txtDescripcionReserva.LabelWidth = 120
        Me.txtDescripcionReserva.Location = New System.Drawing.Point(8, 293)
        Me.txtDescripcionReserva.MaxLength = 0
        Me.txtDescripcionReserva.Name = "txtDescripcionReserva"
        Me.txtDescripcionReserva.NombreCampo = "DescripcionReserva"
        Me.txtDescripcionReserva.Obligatorio = True
        Me.txtDescripcionReserva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionReserva.Size = New System.Drawing.Size(262, 36)
        Me.txtDescripcionReserva.SoloLectura = False
        Me.txtDescripcionReserva.TabIndex = 13
        Me.txtDescripcionReserva.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionReserva.Valor = ""
        '
        'txtTotalDeducible
        '
        Me.txtTotalDeducible.CampoBusqueda = False
        Me.txtTotalDeducible.CampoEsLlave = False
        Me.txtTotalDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalDeducible.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalDeducible.FechaActual = False
        Me.txtTotalDeducible.Formato = "#,###0.00"
        Me.txtTotalDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalDeducible.LabelText = "Valor Deducible"
        Me.txtTotalDeducible.LabelWidth = 120
        Me.txtTotalDeducible.Location = New System.Drawing.Point(8, 331)
        Me.txtTotalDeducible.MaxLength = 0
        Me.txtTotalDeducible.Name = "txtTotalDeducible"
        Me.txtTotalDeducible.NombreCampo = "TotalDeducible"
        Me.txtTotalDeducible.Obligatorio = False
        Me.txtTotalDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDeducible.Size = New System.Drawing.Size(262, 20)
        Me.txtTotalDeducible.SoloLectura = False
        Me.txtTotalDeducible.TabIndex = 15
        Me.txtTotalDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalDeducible.Valor = 0
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
        Me.cboIdProducto.FilasVisibles = 23925379
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 120
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(8, 144)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(517, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 5
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'cboEstadoSiniestro
        '
        Me.cboEstadoSiniestro.CampoAutoCompletar = 0
        Me.cboEstadoSiniestro.CampoBusqueda = True
        Me.cboEstadoSiniestro.CampoDisplay = 1
        Me.cboEstadoSiniestro.CampoEsLlave = False
        Me.cboEstadoSiniestro.CampoValor = 0
        Me.cboEstadoSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoSiniestro.FilasVisibles = 23925379
        Me.cboEstadoSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoSiniestro.LabelText = "Estado Reclamo"
        Me.cboEstadoSiniestro.LabelWidth = 110
        Me.cboEstadoSiniestro.Lista = resources.GetString("cboEstadoSiniestro.Lista")
        Me.cboEstadoSiniestro.Location = New System.Drawing.Point(276, 77)
        Me.cboEstadoSiniestro.MostrarBusquedaColumnas = False
        Me.cboEstadoSiniestro.Name = "cboEstadoSiniestro"
        Me.cboEstadoSiniestro.NombreCampo = "EstadoSiniestro"
        Me.cboEstadoSiniestro.Obligatorio = True
        Me.cboEstadoSiniestro.Query = ""
        Me.cboEstadoSiniestro.SelectIndex = 0
        Me.cboEstadoSiniestro.Size = New System.Drawing.Size(249, 20)
        Me.cboEstadoSiniestro.SoloLectura = False
        Me.cboEstadoSiniestro.StringConection = ""
        Me.cboEstadoSiniestro.TabIndex = 1
        Me.cboEstadoSiniestro.TextoNuevoItem = ""
        Me.cboEstadoSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoSiniestro.Valor = ""
        '
        'txtLugarSiniestros
        '
        Me.txtLugarSiniestros.CampoBusqueda = False
        Me.txtLugarSiniestros.CampoEsLlave = False
        Me.txtLugarSiniestros.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLugarSiniestros.ControlBackColor = System.Drawing.Color.White
        Me.txtLugarSiniestros.ControlForeColor = System.Drawing.Color.Black
        Me.txtLugarSiniestros.FechaActual = False
        Me.txtLugarSiniestros.Formato = ""
        Me.txtLugarSiniestros.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLugarSiniestros.LabelText = "Lugar del Siniestro"
        Me.txtLugarSiniestros.LabelWidth = 120
        Me.txtLugarSiniestros.Location = New System.Drawing.Point(8, 273)
        Me.txtLugarSiniestros.MaxLength = 0
        Me.txtLugarSiniestros.Name = "txtLugarSiniestros"
        Me.txtLugarSiniestros.NombreCampo = "LugarSiniestros"
        Me.txtLugarSiniestros.Obligatorio = False
        Me.txtLugarSiniestros.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLugarSiniestros.Size = New System.Drawing.Size(517, 20)
        Me.txtLugarSiniestros.SoloLectura = False
        Me.txtLugarSiniestros.TabIndex = 12
        Me.txtLugarSiniestros.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtLugarSiniestros.Valor = ""
        '
        'txtNombrePresentaReclamo
        '
        Me.txtNombrePresentaReclamo.CampoBusqueda = True
        Me.txtNombrePresentaReclamo.CampoEsLlave = False
        Me.txtNombrePresentaReclamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombrePresentaReclamo.ControlBackColor = System.Drawing.Color.White
        Me.txtNombrePresentaReclamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombrePresentaReclamo.FechaActual = False
        Me.txtNombrePresentaReclamo.Formato = ""
        Me.txtNombrePresentaReclamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombrePresentaReclamo.LabelText = "Nombre Asegurado"
        Me.txtNombrePresentaReclamo.LabelWidth = 120
        Me.txtNombrePresentaReclamo.Location = New System.Drawing.Point(8, 208)
        Me.txtNombrePresentaReclamo.MaxLength = 500
        Me.txtNombrePresentaReclamo.Name = "txtNombrePresentaReclamo"
        Me.txtNombrePresentaReclamo.NombreCampo = "NombrePresentaReclamo"
        Me.txtNombrePresentaReclamo.Obligatorio = True
        Me.txtNombrePresentaReclamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombrePresentaReclamo.Size = New System.Drawing.Size(517, 20)
        Me.txtNombrePresentaReclamo.SoloLectura = False
        Me.txtNombrePresentaReclamo.TabIndex = 8
        Me.txtNombrePresentaReclamo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombrePresentaReclamo.Valor = ""
        '
        'txtFechaPresentado
        '
        Me.txtFechaPresentado.CampoBusqueda = True
        Me.txtFechaPresentado.CampoEsLlave = False
        Me.txtFechaPresentado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPresentado.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaPresentado.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPresentado.FechaActual = False
        Me.txtFechaPresentado.Formato = "dd/MMM/yyyy"
        Me.txtFechaPresentado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPresentado.LabelText = "Fecha Presentado"
        Me.txtFechaPresentado.LabelWidth = 110
        Me.txtFechaPresentado.Location = New System.Drawing.Point(276, 230)
        Me.txtFechaPresentado.MaxLength = 0
        Me.txtFechaPresentado.Name = "txtFechaPresentado"
        Me.txtFechaPresentado.NombreCampo = "FechaPresentado"
        Me.txtFechaPresentado.Obligatorio = True
        Me.txtFechaPresentado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPresentado.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaPresentado.SoloLectura = False
        Me.txtFechaPresentado.TabIndex = 10
        Me.txtFechaPresentado.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPresentado.Valor = Nothing
        '
        'txtFechaOcurrido
        '
        Me.txtFechaOcurrido.CampoBusqueda = True
        Me.txtFechaOcurrido.CampoEsLlave = False
        Me.txtFechaOcurrido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaOcurrido.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaOcurrido.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaOcurrido.FechaActual = False
        Me.txtFechaOcurrido.Formato = "dd/MMM/yyyy"
        Me.txtFechaOcurrido.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaOcurrido.LabelText = "Fecha Ocurrido"
        Me.txtFechaOcurrido.LabelWidth = 120
        Me.txtFechaOcurrido.Location = New System.Drawing.Point(8, 230)
        Me.txtFechaOcurrido.MaxLength = 0
        Me.txtFechaOcurrido.Name = "txtFechaOcurrido"
        Me.txtFechaOcurrido.NombreCampo = "FechaOcurrido"
        Me.txtFechaOcurrido.Obligatorio = True
        Me.txtFechaOcurrido.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaOcurrido.Size = New System.Drawing.Size(262, 20)
        Me.txtFechaOcurrido.SoloLectura = False
        Me.txtFechaOcurrido.TabIndex = 9
        Me.txtFechaOcurrido.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaOcurrido.Valor = Nothing
        '
        'txtDescripcionSiniestro
        '
        Me.txtDescripcionSiniestro.CampoBusqueda = False
        Me.txtDescripcionSiniestro.CampoEsLlave = False
        Me.txtDescripcionSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionSiniestro.FechaActual = False
        Me.txtDescripcionSiniestro.Formato = ""
        Me.txtDescripcionSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionSiniestro.LabelText = "Descripción Siniestro"
        Me.txtDescripcionSiniestro.LabelWidth = 120
        Me.txtDescripcionSiniestro.Location = New System.Drawing.Point(8, 251)
        Me.txtDescripcionSiniestro.MaxLength = 0
        Me.txtDescripcionSiniestro.Name = "txtDescripcionSiniestro"
        Me.txtDescripcionSiniestro.NombreCampo = "DescripcionSiniestro"
        Me.txtDescripcionSiniestro.Obligatorio = False
        Me.txtDescripcionSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionSiniestro.Size = New System.Drawing.Size(517, 20)
        Me.txtDescripcionSiniestro.SoloLectura = False
        Me.txtDescripcionSiniestro.TabIndex = 11
        Me.txtDescripcionSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionSiniestro.Valor = ""
        '
        'txtTotalDeudores
        '
        Me.txtTotalDeudores.CampoBusqueda = False
        Me.txtTotalDeudores.CampoEsLlave = False
        Me.txtTotalDeudores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalDeudores.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalDeudores.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalDeudores.FechaActual = False
        Me.txtTotalDeudores.Formato = "#,###0.00"
        Me.txtTotalDeudores.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalDeudores.LabelText = "Valor Deudores"
        Me.txtTotalDeudores.LabelWidth = 110
        Me.txtTotalDeudores.Location = New System.Drawing.Point(533, 331)
        Me.txtTotalDeudores.MaxLength = 0
        Me.txtTotalDeudores.Name = "txtTotalDeudores"
        Me.txtTotalDeudores.NombreCampo = "TotalDeudores"
        Me.txtTotalDeudores.Obligatorio = False
        Me.txtTotalDeudores.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDeudores.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalDeudores.SoloLectura = False
        Me.txtTotalDeudores.TabIndex = 17
        Me.txtTotalDeudores.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalDeudores.Valor = 0
        '
        'txtTotalCoaseguro
        '
        Me.txtTotalCoaseguro.CampoBusqueda = False
        Me.txtTotalCoaseguro.CampoEsLlave = False
        Me.txtTotalCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalCoaseguro.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalCoaseguro.FechaActual = False
        Me.txtTotalCoaseguro.Formato = "#,###0.00"
        Me.txtTotalCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalCoaseguro.LabelText = "Valor Coaseguro"
        Me.txtTotalCoaseguro.LabelWidth = 110
        Me.txtTotalCoaseguro.Location = New System.Drawing.Point(276, 331)
        Me.txtTotalCoaseguro.MaxLength = 0
        Me.txtTotalCoaseguro.Name = "txtTotalCoaseguro"
        Me.txtTotalCoaseguro.NombreCampo = "TotalCoaseguro"
        Me.txtTotalCoaseguro.Obligatorio = False
        Me.txtTotalCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalCoaseguro.Size = New System.Drawing.Size(248, 20)
        Me.txtTotalCoaseguro.SoloLectura = False
        Me.txtTotalCoaseguro.TabIndex = 16
        Me.txtTotalCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalCoaseguro.Valor = 0
        '
        'txtTotalCubierto
        '
        Me.txtTotalCubierto.CampoBusqueda = False
        Me.txtTotalCubierto.CampoEsLlave = False
        Me.txtTotalCubierto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalCubierto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalCubierto.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalCubierto.FechaActual = False
        Me.txtTotalCubierto.Formato = "#,###0.00"
        Me.txtTotalCubierto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalCubierto.LabelText = "Total Cubierto"
        Me.txtTotalCubierto.LabelWidth = 110
        Me.txtTotalCubierto.Location = New System.Drawing.Point(533, 122)
        Me.txtTotalCubierto.MaxLength = 0
        Me.txtTotalCubierto.Name = "txtTotalCubierto"
        Me.txtTotalCubierto.NombreCampo = "TotalCubierto"
        Me.txtTotalCubierto.Obligatorio = False
        Me.txtTotalCubierto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalCubierto.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalCubierto.SoloLectura = True
        Me.txtTotalCubierto.TabIndex = 29
        Me.txtTotalCubierto.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalCubierto.Valor = 0
        '
        'txtTotalNoCubierto
        '
        Me.txtTotalNoCubierto.CampoBusqueda = False
        Me.txtTotalNoCubierto.CampoEsLlave = False
        Me.txtTotalNoCubierto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalNoCubierto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalNoCubierto.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalNoCubierto.FechaActual = False
        Me.txtTotalNoCubierto.Formato = "#,###0.00"
        Me.txtTotalNoCubierto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalNoCubierto.LabelText = "Valor No Cubierto"
        Me.txtTotalNoCubierto.LabelWidth = 110
        Me.txtTotalNoCubierto.Location = New System.Drawing.Point(533, 100)
        Me.txtTotalNoCubierto.MaxLength = 0
        Me.txtTotalNoCubierto.Name = "txtTotalNoCubierto"
        Me.txtTotalNoCubierto.NombreCampo = "TotalNoCubierto"
        Me.txtTotalNoCubierto.Obligatorio = False
        Me.txtTotalNoCubierto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalNoCubierto.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalNoCubierto.SoloLectura = True
        Me.txtTotalNoCubierto.TabIndex = 28
        Me.txtTotalNoCubierto.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalNoCubierto.Valor = 0
        '
        'txtTotalPresentado
        '
        Me.txtTotalPresentado.CampoBusqueda = False
        Me.txtTotalPresentado.CampoEsLlave = False
        Me.txtTotalPresentado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalPresentado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalPresentado.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalPresentado.FechaActual = False
        Me.txtTotalPresentado.Formato = "#,###0.00"
        Me.txtTotalPresentado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalPresentado.LabelText = "Total Presentado"
        Me.txtTotalPresentado.LabelWidth = 110
        Me.txtTotalPresentado.Location = New System.Drawing.Point(533, 77)
        Me.txtTotalPresentado.MaxLength = 0
        Me.txtTotalPresentado.Name = "txtTotalPresentado"
        Me.txtTotalPresentado.NombreCampo = "TotalPresentado"
        Me.txtTotalPresentado.Obligatorio = False
        Me.txtTotalPresentado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPresentado.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalPresentado.SoloLectura = True
        Me.txtTotalPresentado.TabIndex = 27
        Me.txtTotalPresentado.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalPresentado.Valor = 0
        '
        'txtTotalReembolso
        '
        Me.txtTotalReembolso.CampoBusqueda = False
        Me.txtTotalReembolso.CampoEsLlave = False
        Me.txtTotalReembolso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalReembolso.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalReembolso.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalReembolso.FechaActual = False
        Me.txtTotalReembolso.Formato = "#,###0.00"
        Me.txtTotalReembolso.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalReembolso.LabelText = "Valor Reembolso"
        Me.txtTotalReembolso.LabelWidth = 110
        Me.txtTotalReembolso.Location = New System.Drawing.Point(533, 165)
        Me.txtTotalReembolso.MaxLength = 0
        Me.txtTotalReembolso.Name = "txtTotalReembolso"
        Me.txtTotalReembolso.NombreCampo = "TotalReembolso"
        Me.txtTotalReembolso.Obligatorio = False
        Me.txtTotalReembolso.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalReembolso.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalReembolso.SoloLectura = True
        Me.txtTotalReembolso.TabIndex = 31
        Me.txtTotalReembolso.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalReembolso.Valor = 0
        '
        'TabSiniestros
        '
        Me.TabSiniestros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabSiniestros.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TabSiniestros.Location = New System.Drawing.Point(8, 443)
        Me.TabSiniestros.MultiLine = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabSiniestros.Name = "TabSiniestros"
        Me.TabSiniestros.SelectedTabPage = Me.Detalle
        Me.TabSiniestros.Size = New System.Drawing.Size(767, 185)
        Me.TabSiniestros.TabIndex = 25
        Me.TabSiniestros.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Detalle, Me.Informacion, Me.Reserva, Me.Pagos, Me.Deudores, Me.Requisitos, Me.Archivos, Me.Bienes, Me.Coberturas, Me.Gestiones, Me.Fechas})
        '
        'Detalle
        '
        Me.Detalle.Controls.Add(Me.btnQuitarGastos)
        Me.Detalle.Controls.Add(Me.btnAgregarGasto)
        Me.Detalle.Controls.Add(Me.GridDetalle)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(758, 132)
        Me.Detalle.Text = "Gastos del Reclamo"
        '
        'btnQuitarGastos
        '
        Me.btnQuitarGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGastos.Location = New System.Drawing.Point(612, 38)
        Me.btnQuitarGastos.Name = "btnQuitarGastos"
        Me.btnQuitarGastos.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarGastos.TabIndex = 2
        Me.btnQuitarGastos.Text = "Quitar"
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGasto.Location = New System.Drawing.Point(613, 3)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarGasto.TabIndex = 0
        Me.btnAgregarGasto.Text = "Agregar Gasto"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.ColumnasAdicionales = ""
        Me.GridDetalle.Location = New System.Drawing.Point(3, 3)
        Me.GridDetalle.MainView = Me.VistaDetalles
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.NombreTabla = "SiniestrosDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.RepositoryItemLookUpEdit1, Me.txtVistaDetalleComentarios})
        Me.GridDetalle.Size = New System.Drawing.Size(604, 112)
        Me.GridDetalle.TabIndex = 1
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDetalles})
        '
        'VistaDetalles
        '
        Me.VistaDetalles.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetIdPoliza, Me.colDetIdProducto, Me.colDetIdCertificado, Me.colDetIdSiniestro, Me.colDetIdDetalle, Me.colDetDescripcionGastos, Me.colDetValorPresentado, Me.colDetValorNoCubierto, Me.colDetValorCubierto, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.ColDetIdEnvio, Me.colDetFechaEnvio})
        Me.VistaDetalles.GridControl = Me.GridDetalle
        Me.VistaDetalles.Name = "VistaDetalles"
        Me.VistaDetalles.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaDetalles.OptionsView.ShowFooter = True
        Me.VistaDetalles.OptionsView.ShowGroupPanel = False
        '
        'colDetIdPoliza
        '
        Me.colDetIdPoliza.Caption = "Poliza"
        Me.colDetIdPoliza.FieldName = "IdPoliza"
        Me.colDetIdPoliza.Name = "colDetIdPoliza"
        '
        'colDetIdProducto
        '
        Me.colDetIdProducto.Caption = "Producto"
        Me.colDetIdProducto.FieldName = "IdProducto"
        Me.colDetIdProducto.Name = "colDetIdProducto"
        '
        'colDetIdCertificado
        '
        Me.colDetIdCertificado.Caption = "Certificado"
        Me.colDetIdCertificado.FieldName = "IdCertificado"
        Me.colDetIdCertificado.Name = "colDetIdCertificado"
        '
        'colDetIdSiniestro
        '
        Me.colDetIdSiniestro.Caption = "Siniestro"
        Me.colDetIdSiniestro.FieldName = "IdSiniestro"
        Me.colDetIdSiniestro.Name = "colDetIdSiniestro"
        '
        'colDetIdDetalle
        '
        Me.colDetIdDetalle.Caption = "Orden"
        Me.colDetIdDetalle.FieldName = "IdDetalle"
        Me.colDetIdDetalle.Name = "colDetIdDetalle"
        Me.colDetIdDetalle.Visible = True
        Me.colDetIdDetalle.VisibleIndex = 0
        Me.colDetIdDetalle.Width = 40
        '
        'colDetDescripcionGastos
        '
        Me.colDetDescripcionGastos.Caption = "Descripción Gastos"
        Me.colDetDescripcionGastos.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colDetDescripcionGastos.FieldName = "IdGasto"
        Me.colDetDescripcionGastos.Name = "colDetDescripcionGastos"
        Me.colDetDescripcionGastos.Visible = True
        Me.colDetDescripcionGastos.VisibleIndex = 2
        Me.colDetDescripcionGastos.Width = 115
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colDetValorPresentado
        '
        Me.colDetValorPresentado.Caption = "Valor Presentado"
        Me.colDetValorPresentado.DisplayFormat.FormatString = "c"
        Me.colDetValorPresentado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDetValorPresentado.FieldName = "ValorPresentado"
        Me.colDetValorPresentado.Name = "colDetValorPresentado"
        Me.colDetValorPresentado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDetValorPresentado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDetValorPresentado.Visible = True
        Me.colDetValorPresentado.VisibleIndex = 3
        Me.colDetValorPresentado.Width = 115
        '
        'colDetValorNoCubierto
        '
        Me.colDetValorNoCubierto.Caption = "Gastos No Cubiertos"
        Me.colDetValorNoCubierto.DisplayFormat.FormatString = "c"
        Me.colDetValorNoCubierto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDetValorNoCubierto.FieldName = "ValorNoCubierto"
        Me.colDetValorNoCubierto.Name = "colDetValorNoCubierto"
        Me.colDetValorNoCubierto.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDetValorNoCubierto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDetValorNoCubierto.Visible = True
        Me.colDetValorNoCubierto.VisibleIndex = 4
        Me.colDetValorNoCubierto.Width = 115
        '
        'colDetValorCubierto
        '
        Me.colDetValorCubierto.Caption = "Gastos Cubiertos"
        Me.colDetValorCubierto.DisplayFormat.FormatString = "c"
        Me.colDetValorCubierto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDetValorCubierto.FieldName = "ValorCubierto"
        Me.colDetValorCubierto.Name = "colDetValorCubierto"
        Me.colDetValorCubierto.OptionsColumn.AllowEdit = False
        Me.colDetValorCubierto.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDetValorCubierto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDetValorCubierto.Visible = True
        Me.colDetValorCubierto.VisibleIndex = 5
        Me.colDetValorCubierto.Width = 124
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Comentarios"
        Me.GridColumn4.ColumnEdit = Me.txtVistaDetalleComentarios
        Me.GridColumn4.FieldName = "Observaciones"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'txtVistaDetalleComentarios
        '
        Me.txtVistaDetalleComentarios.AutoHeight = False
        Me.txtVistaDetalleComentarios.MaxLength = 500
        Me.txtVistaDetalleComentarios.Name = "txtVistaDetalleComentarios"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Presentado"
        Me.GridColumn5.FieldName = "FechaPresentado"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Núm. Factura/Doc."
        Me.GridColumn6.FieldName = "NumDocumento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 74
        '
        'ColDetIdEnvio
        '
        Me.ColDetIdEnvio.Caption = "IdEnvio"
        Me.ColDetIdEnvio.FieldName = "IdEnvio"
        Me.ColDetIdEnvio.Name = "ColDetIdEnvio"
        Me.ColDetIdEnvio.OptionsColumn.AllowEdit = False
        '
        'colDetFechaEnvio
        '
        Me.colDetFechaEnvio.Caption = "Fecha de Envio"
        Me.colDetFechaEnvio.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colDetFechaEnvio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDetFechaEnvio.FieldName = "FechaEnvio"
        Me.colDetFechaEnvio.Name = "colDetFechaEnvio"
        Me.colDetFechaEnvio.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'Informacion
        '
        Me.Informacion.Controls.Add(Me.btnQuitarInfo)
        Me.Informacion.Controls.Add(Me.btnAgregarInfo)
        Me.Informacion.Controls.Add(Me.GridInfo)
        Me.Informacion.Name = "Informacion"
        Me.Informacion.Size = New System.Drawing.Size(758, 132)
        Me.Informacion.Text = "Información Adicional Técnica"
        '
        'btnQuitarInfo
        '
        Me.btnQuitarInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarInfo.Location = New System.Drawing.Point(618, 38)
        Me.btnQuitarInfo.Name = "btnQuitarInfo"
        Me.btnQuitarInfo.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarInfo.TabIndex = 3
        Me.btnQuitarInfo.Text = "Quitar"
        '
        'btnAgregarInfo
        '
        Me.btnAgregarInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarInfo.Location = New System.Drawing.Point(619, 3)
        Me.btnAgregarInfo.Name = "btnAgregarInfo"
        Me.btnAgregarInfo.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarInfo.TabIndex = 2
        Me.btnAgregarInfo.Text = "Agregar Info."
        '
        'GridInfo
        '
        Me.GridInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridInfo.ColumnasAdicionales = ""
        Me.GridInfo.Location = New System.Drawing.Point(3, 3)
        Me.GridInfo.MainView = Me.VistaInfo
        Me.GridInfo.Name = "GridInfo"
        Me.GridInfo.NombreTabla = "SiniestrosInformacion"
        Me.GridInfo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemMemoEdit1})
        Me.GridInfo.Size = New System.Drawing.Size(609, 150)
        Me.GridInfo.TabIndex = 1
        Me.GridInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaInfo})
        '
        'VistaInfo
        '
        Me.VistaInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInfoIdPoliza, Me.colInfoIdProducto, Me.colInfoIdCertificado, Me.colInfoIdSiniestro, Me.colInfoIdInformacion, Me.colInfoDescripcion, Me.colInfoDetalle})
        Me.VistaInfo.GridControl = Me.GridInfo
        Me.VistaInfo.Name = "VistaInfo"
        Me.VistaInfo.OptionsCustomization.AllowRowSizing = True
        Me.VistaInfo.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaInfo.OptionsView.ShowGroupPanel = False
        '
        'colInfoIdPoliza
        '
        Me.colInfoIdPoliza.Caption = "IdPoliza"
        Me.colInfoIdPoliza.FieldName = "IdPoliza"
        Me.colInfoIdPoliza.Name = "colInfoIdPoliza"
        '
        'colInfoIdProducto
        '
        Me.colInfoIdProducto.Caption = "IdProducto"
        Me.colInfoIdProducto.FieldName = "IdProducto"
        Me.colInfoIdProducto.Name = "colInfoIdProducto"
        '
        'colInfoIdCertificado
        '
        Me.colInfoIdCertificado.Caption = "IdCertificado"
        Me.colInfoIdCertificado.FieldName = "IdCertificado"
        Me.colInfoIdCertificado.Name = "colInfoIdCertificado"
        '
        'colInfoIdSiniestro
        '
        Me.colInfoIdSiniestro.Caption = "IdSiniestro"
        Me.colInfoIdSiniestro.FieldName = "IdSiniestro"
        Me.colInfoIdSiniestro.Name = "colInfoIdSiniestro"
        '
        'colInfoIdInformacion
        '
        Me.colInfoIdInformacion.Caption = "Orden"
        Me.colInfoIdInformacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInfoIdInformacion.FieldName = "IdInformacion"
        Me.colInfoIdInformacion.Name = "colInfoIdInformacion"
        Me.colInfoIdInformacion.Visible = True
        Me.colInfoIdInformacion.VisibleIndex = 0
        '
        'colInfoDescripcion
        '
        Me.colInfoDescripcion.Caption = "Descripción"
        Me.colInfoDescripcion.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colInfoDescripcion.FieldName = "Descripcion"
        Me.colInfoDescripcion.Name = "colInfoDescripcion"
        Me.colInfoDescripcion.Visible = True
        Me.colInfoDescripcion.VisibleIndex = 1
        Me.colInfoDescripcion.Width = 165
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colInfoDetalle
        '
        Me.colInfoDetalle.Caption = "Detalle"
        Me.colInfoDetalle.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colInfoDetalle.FieldName = "Detalle"
        Me.colInfoDetalle.Name = "colInfoDetalle"
        Me.colInfoDetalle.Visible = True
        Me.colInfoDetalle.VisibleIndex = 2
        Me.colInfoDetalle.Width = 357
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'Reserva
        '
        Me.Reserva.Controls.Add(Me.btnQuitarReserva)
        Me.Reserva.Controls.Add(Me.btnAgregarReserva)
        Me.Reserva.Controls.Add(Me.GridReserva)
        Me.Reserva.Name = "Reserva"
        Me.Reserva.Size = New System.Drawing.Size(758, 132)
        Me.Reserva.Text = "Reservas"
        '
        'btnQuitarReserva
        '
        Me.btnQuitarReserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarReserva.Location = New System.Drawing.Point(615, 38)
        Me.btnQuitarReserva.Name = "btnQuitarReserva"
        Me.btnQuitarReserva.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarReserva.TabIndex = 1
        Me.btnQuitarReserva.Text = "Quitar"
        '
        'btnAgregarReserva
        '
        Me.btnAgregarReserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarReserva.Location = New System.Drawing.Point(616, 3)
        Me.btnAgregarReserva.Name = "btnAgregarReserva"
        Me.btnAgregarReserva.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarReserva.TabIndex = 0
        Me.btnAgregarReserva.Text = "Agregar Reserva"
        '
        'GridReserva
        '
        Me.GridReserva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridReserva.ColumnasAdicionales = ""
        Me.GridReserva.Location = New System.Drawing.Point(3, 3)
        Me.GridReserva.MainView = Me.VistaReserva
        Me.GridReserva.Name = "GridReserva"
        Me.GridReserva.NombreTabla = "SiniestrosReservas"
        Me.GridReserva.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGrupoCobertura})
        Me.GridReserva.Size = New System.Drawing.Size(607, 150)
        Me.GridReserva.TabIndex = 2
        Me.GridReserva.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaReserva})
        '
        'VistaReserva
        '
        Me.VistaReserva.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colResIdPoliza, Me.colResIdProducto, Me.colResIdCertificado, Me.colResIdSiniestro, Me.colResIdCobertura, Me.colResFechaReserva, Me.colResValorAsegurado, Me.colResValorReserva, Me.GridColumn7})
        Me.VistaReserva.GridControl = Me.GridReserva
        Me.VistaReserva.Name = "VistaReserva"
        Me.VistaReserva.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaReserva.OptionsView.ShowFooter = True
        Me.VistaReserva.OptionsView.ShowGroupPanel = False
        '
        'colResIdPoliza
        '
        Me.colResIdPoliza.Caption = "Poliza"
        Me.colResIdPoliza.FieldName = "IdPoliza"
        Me.colResIdPoliza.Name = "colResIdPoliza"
        '
        'colResIdProducto
        '
        Me.colResIdProducto.Caption = "Producto"
        Me.colResIdProducto.FieldName = "IdProducto"
        Me.colResIdProducto.Name = "colResIdProducto"
        '
        'colResIdCertificado
        '
        Me.colResIdCertificado.Caption = "Certificado"
        Me.colResIdCertificado.FieldName = "IdCertificado"
        Me.colResIdCertificado.Name = "colResIdCertificado"
        '
        'colResIdSiniestro
        '
        Me.colResIdSiniestro.Caption = "Siniestro"
        Me.colResIdSiniestro.FieldName = "IdSiniestro"
        Me.colResIdSiniestro.Name = "colResIdSiniestro"
        '
        'colResIdCobertura
        '
        Me.colResIdCobertura.Caption = "Orden"
        Me.colResIdCobertura.FieldName = "IdReserva"
        Me.colResIdCobertura.Name = "colResIdCobertura"
        Me.colResIdCobertura.Visible = True
        Me.colResIdCobertura.VisibleIndex = 0
        Me.colResIdCobertura.Width = 66
        '
        'colResFechaReserva
        '
        Me.colResFechaReserva.Caption = "Fecha Reserva"
        Me.colResFechaReserva.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colResFechaReserva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colResFechaReserva.FieldName = "FechaReserva"
        Me.colResFechaReserva.Name = "colResFechaReserva"
        Me.colResFechaReserva.Visible = True
        Me.colResFechaReserva.VisibleIndex = 1
        Me.colResFechaReserva.Width = 101
        '
        'colResValorAsegurado
        '
        Me.colResValorAsegurado.Caption = "Valor Asegurado"
        Me.colResValorAsegurado.DisplayFormat.FormatString = "c"
        Me.colResValorAsegurado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colResValorAsegurado.FieldName = "ValorAsegurado"
        Me.colResValorAsegurado.Name = "colResValorAsegurado"
        Me.colResValorAsegurado.SummaryItem.DisplayFormat = "{0:c}"
        Me.colResValorAsegurado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colResValorAsegurado.Visible = True
        Me.colResValorAsegurado.VisibleIndex = 2
        Me.colResValorAsegurado.Width = 202
        '
        'colResValorReserva
        '
        Me.colResValorReserva.Caption = "Valor Reserva"
        Me.colResValorReserva.DisplayFormat.FormatString = "c"
        Me.colResValorReserva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colResValorReserva.FieldName = "ValorReserva"
        Me.colResValorReserva.Name = "colResValorReserva"
        Me.colResValorReserva.SummaryItem.DisplayFormat = "{0:c}"
        Me.colResValorReserva.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colResValorReserva.Visible = True
        Me.colResValorReserva.VisibleIndex = 3
        Me.colResValorReserva.Width = 209
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Cobertura"
        Me.GridColumn7.ColumnEdit = Me.cboGrupoCobertura
        Me.GridColumn7.FieldName = "NomCobertura"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'cboGrupoCobertura
        '
        Me.cboGrupoCobertura.AutoHeight = False
        Me.cboGrupoCobertura.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupoCobertura.Name = "cboGrupoCobertura"
        Me.cboGrupoCobertura.NullText = ""
        '
        'Pagos
        '
        Me.Pagos.Controls.Add(Me.btnQuitarPago)
        Me.Pagos.Controls.Add(Me.btnAgregarPago)
        Me.Pagos.Controls.Add(Me.GridPagos)
        Me.Pagos.Name = "Pagos"
        Me.Pagos.Size = New System.Drawing.Size(758, 132)
        Me.Pagos.Text = "Pagos Realizados"
        '
        'btnQuitarPago
        '
        Me.btnQuitarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarPago.Location = New System.Drawing.Point(615, 38)
        Me.btnQuitarPago.Name = "btnQuitarPago"
        Me.btnQuitarPago.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarPago.TabIndex = 2
        Me.btnQuitarPago.Text = "Quitar"
        '
        'btnAgregarPago
        '
        Me.btnAgregarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarPago.Location = New System.Drawing.Point(616, 3)
        Me.btnAgregarPago.Name = "btnAgregarPago"
        Me.btnAgregarPago.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarPago.TabIndex = 0
        Me.btnAgregarPago.Text = "Agregar Pago"
        '
        'GridPagos
        '
        Me.GridPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPagos.ColumnasAdicionales = ""
        Me.GridPagos.Location = New System.Drawing.Point(3, 3)
        Me.GridPagos.MainView = Me.VistaPagos
        Me.GridPagos.Name = "GridPagos"
        Me.GridPagos.NombreTabla = "SiniestrosPagos"
        Me.GridPagos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.cboGrupoCobPago})
        Me.GridPagos.Size = New System.Drawing.Size(607, 150)
        Me.GridPagos.TabIndex = 1
        Me.GridPagos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPagos})
        '
        'VistaPagos
        '
        Me.VistaPagos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPagIdPoliza, Me.colPagIdProducto, Me.colPagIdCertificado, Me.ColPagIdSiniestro, Me.ColPagIdPago, Me.colPagFechaPago, Me.colPagNombreCheque, Me.colPagNumeroCheque, Me.ColPagValorGasto, Me.ColPagValorDescuento, Me.ColArcValorRenta, Me.ColPagValorIva, Me.colPagValorRetencionIva, Me.colPagValorReembolso, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn8})
        Me.VistaPagos.GridControl = Me.GridPagos
        Me.VistaPagos.Name = "VistaPagos"
        Me.VistaPagos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaPagos.OptionsView.ShowFooter = True
        Me.VistaPagos.OptionsView.ShowGroupPanel = False
        '
        'colPagIdPoliza
        '
        Me.colPagIdPoliza.Caption = "Poliza"
        Me.colPagIdPoliza.FieldName = "IdPoliza"
        Me.colPagIdPoliza.Name = "colPagIdPoliza"
        '
        'colPagIdProducto
        '
        Me.colPagIdProducto.Caption = "Producto"
        Me.colPagIdProducto.FieldName = "IdProducto"
        Me.colPagIdProducto.Name = "colPagIdProducto"
        '
        'colPagIdCertificado
        '
        Me.colPagIdCertificado.Caption = "Certificado"
        Me.colPagIdCertificado.FieldName = "IdCertificado"
        Me.colPagIdCertificado.Name = "colPagIdCertificado"
        '
        'ColPagIdSiniestro
        '
        Me.ColPagIdSiniestro.Caption = "Siniestro"
        Me.ColPagIdSiniestro.FieldName = "IdSiniestro"
        Me.ColPagIdSiniestro.Name = "ColPagIdSiniestro"
        '
        'ColPagIdPago
        '
        Me.ColPagIdPago.Caption = "Núm."
        Me.ColPagIdPago.FieldName = "IdPago"
        Me.ColPagIdPago.Name = "ColPagIdPago"
        Me.ColPagIdPago.Visible = True
        Me.ColPagIdPago.VisibleIndex = 0
        '
        'colPagFechaPago
        '
        Me.colPagFechaPago.Caption = "Fecha Pago"
        Me.colPagFechaPago.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colPagFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPagFechaPago.FieldName = "FechaPago"
        Me.colPagFechaPago.Name = "colPagFechaPago"
        Me.colPagFechaPago.Visible = True
        Me.colPagFechaPago.VisibleIndex = 1
        '
        'colPagNombreCheque
        '
        Me.colPagNombreCheque.Caption = "Nombre en Cheque"
        Me.colPagNombreCheque.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colPagNombreCheque.FieldName = "NombreCheque"
        Me.colPagNombreCheque.Name = "colPagNombreCheque"
        Me.colPagNombreCheque.Visible = True
        Me.colPagNombreCheque.VisibleIndex = 2
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colPagNumeroCheque
        '
        Me.colPagNumeroCheque.Caption = "Número Cheque"
        Me.colPagNumeroCheque.FieldName = "NumeroCheque"
        Me.colPagNumeroCheque.Name = "colPagNumeroCheque"
        Me.colPagNumeroCheque.Visible = True
        Me.colPagNumeroCheque.VisibleIndex = 3
        '
        'ColPagValorGasto
        '
        Me.ColPagValorGasto.Caption = "Valor Reclamado"
        Me.ColPagValorGasto.DisplayFormat.FormatString = "c"
        Me.ColPagValorGasto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPagValorGasto.FieldName = "ValorGasto"
        Me.ColPagValorGasto.Name = "ColPagValorGasto"
        Me.ColPagValorGasto.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColPagValorGasto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColPagValorGasto.Visible = True
        Me.ColPagValorGasto.VisibleIndex = 4
        '
        'ColPagValorDescuento
        '
        Me.ColPagValorDescuento.Caption = "Descuento"
        Me.ColPagValorDescuento.DisplayFormat.FormatString = "c"
        Me.ColPagValorDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPagValorDescuento.FieldName = "ValorDescuento"
        Me.ColPagValorDescuento.Name = "ColPagValorDescuento"
        Me.ColPagValorDescuento.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColPagValorDescuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColPagValorDescuento.Visible = True
        Me.ColPagValorDescuento.VisibleIndex = 8
        '
        'ColArcValorRenta
        '
        Me.ColArcValorRenta.Caption = "Valor Renta"
        Me.ColArcValorRenta.DisplayFormat.FormatString = "c"
        Me.ColArcValorRenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColArcValorRenta.FieldName = "ValorRenta"
        Me.ColArcValorRenta.Name = "ColArcValorRenta"
        Me.ColArcValorRenta.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColArcValorRenta.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColArcValorRenta.Visible = True
        Me.ColArcValorRenta.VisibleIndex = 9
        '
        'ColPagValorIva
        '
        Me.ColPagValorIva.Caption = "IVA"
        Me.ColPagValorIva.DisplayFormat.FormatString = "c"
        Me.ColPagValorIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPagValorIva.FieldName = "ValorIva"
        Me.ColPagValorIva.Name = "ColPagValorIva"
        Me.ColPagValorIva.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColPagValorIva.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColPagValorIva.Visible = True
        Me.ColPagValorIva.VisibleIndex = 10
        '
        'colPagValorRetencionIva
        '
        Me.colPagValorRetencionIva.Caption = "Ret. Iva"
        Me.colPagValorRetencionIva.DisplayFormat.FormatString = "c"
        Me.colPagValorRetencionIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPagValorRetencionIva.FieldName = "ValorRetencionIva"
        Me.colPagValorRetencionIva.Name = "colPagValorRetencionIva"
        Me.colPagValorRetencionIva.SummaryItem.DisplayFormat = "{0:c}"
        Me.colPagValorRetencionIva.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPagValorRetencionIva.Visible = True
        Me.colPagValorRetencionIva.VisibleIndex = 11
        '
        'colPagValorReembolso
        '
        Me.colPagValorReembolso.Caption = "Valor Reembolso"
        Me.colPagValorReembolso.DisplayFormat.FormatString = "c"
        Me.colPagValorReembolso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPagValorReembolso.FieldName = "ValorReembolso"
        Me.colPagValorReembolso.Name = "colPagValorReembolso"
        Me.colPagValorReembolso.SummaryItem.DisplayFormat = "{0:c}"
        Me.colPagValorReembolso.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPagValorReembolso.Visible = True
        Me.colPagValorReembolso.VisibleIndex = 12
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Deducible"
        Me.GridColumn1.DisplayFormat.FormatString = "c"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Deducible"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Coaseguro"
        Me.GridColumn2.DisplayFormat.FormatString = "c"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Coaseguro"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Saldo Deudor"
        Me.GridColumn3.DisplayFormat.FormatString = "c"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "SaldoDeudor"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Cobertura"
        Me.GridColumn8.ColumnEdit = Me.cboGrupoCobPago
        Me.GridColumn8.FieldName = "NomCobertura"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 13
        '
        'cboGrupoCobPago
        '
        Me.cboGrupoCobPago.AutoHeight = False
        Me.cboGrupoCobPago.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupoCobPago.Name = "cboGrupoCobPago"
        Me.cboGrupoCobPago.NullText = ""
        '
        'Deudores
        '
        Me.Deudores.Controls.Add(Me.btnQuitarDeudor)
        Me.Deudores.Controls.Add(Me.btnAgregarDeudor)
        Me.Deudores.Controls.Add(Me.GridDeudores)
        Me.Deudores.Name = "Deudores"
        Me.Deudores.Size = New System.Drawing.Size(758, 132)
        Me.Deudores.Text = "Deudores"
        '
        'btnQuitarDeudor
        '
        Me.btnQuitarDeudor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDeudor.Location = New System.Drawing.Point(618, 38)
        Me.btnQuitarDeudor.Name = "btnQuitarDeudor"
        Me.btnQuitarDeudor.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDeudor.TabIndex = 5
        Me.btnQuitarDeudor.Text = "Quitar"
        '
        'btnAgregarDeudor
        '
        Me.btnAgregarDeudor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDeudor.Location = New System.Drawing.Point(619, 3)
        Me.btnAgregarDeudor.Name = "btnAgregarDeudor"
        Me.btnAgregarDeudor.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarDeudor.TabIndex = 4
        Me.btnAgregarDeudor.Text = "Agregar"
        '
        'GridDeudores
        '
        Me.GridDeudores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDeudores.ColumnasAdicionales = ""
        Me.GridDeudores.Location = New System.Drawing.Point(3, 3)
        Me.GridDeudores.MainView = Me.VistaDeudores
        Me.GridDeudores.Name = "GridDeudores"
        Me.GridDeudores.NombreTabla = "SiniestrosDeudores"
        Me.GridDeudores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4})
        Me.GridDeudores.Size = New System.Drawing.Size(609, 150)
        Me.GridDeudores.TabIndex = 0
        Me.GridDeudores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDeudores})
        '
        'VistaDeudores
        '
        Me.VistaDeudores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDedIdPoliza, Me.colDedIdProducto, Me.coldedIdCertificado, Me.colDedIdSiniestro, Me.ColDedIdDeudor, Me.colDedFechaDeudor, Me.colDedDescripcion, Me.colDedValorDeudor})
        Me.VistaDeudores.GridControl = Me.GridDeudores
        Me.VistaDeudores.Name = "VistaDeudores"
        Me.VistaDeudores.OptionsView.ShowFooter = True
        Me.VistaDeudores.OptionsView.ShowGroupPanel = False
        '
        'colDedIdPoliza
        '
        Me.colDedIdPoliza.Caption = "IdPoliza"
        Me.colDedIdPoliza.FieldName = "IdPoliza"
        Me.colDedIdPoliza.Name = "colDedIdPoliza"
        '
        'colDedIdProducto
        '
        Me.colDedIdProducto.Caption = "IdProducto"
        Me.colDedIdProducto.FieldName = "IdProducto"
        Me.colDedIdProducto.Name = "colDedIdProducto"
        '
        'coldedIdCertificado
        '
        Me.coldedIdCertificado.Caption = "IdCertificado"
        Me.coldedIdCertificado.FieldName = "IdCertificado"
        Me.coldedIdCertificado.Name = "coldedIdCertificado"
        '
        'colDedIdSiniestro
        '
        Me.colDedIdSiniestro.Caption = "IdSiniestro"
        Me.colDedIdSiniestro.FieldName = "IdSiniestro"
        Me.colDedIdSiniestro.Name = "colDedIdSiniestro"
        '
        'ColDedIdDeudor
        '
        Me.ColDedIdDeudor.Caption = "Orden"
        Me.ColDedIdDeudor.FieldName = "IdDeudor"
        Me.ColDedIdDeudor.Name = "ColDedIdDeudor"
        Me.ColDedIdDeudor.Visible = True
        Me.ColDedIdDeudor.VisibleIndex = 0
        '
        'colDedFechaDeudor
        '
        Me.colDedFechaDeudor.Caption = "Fecha Aplicación"
        Me.colDedFechaDeudor.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colDedFechaDeudor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDedFechaDeudor.FieldName = "FechaDeudor"
        Me.colDedFechaDeudor.Name = "colDedFechaDeudor"
        Me.colDedFechaDeudor.Visible = True
        Me.colDedFechaDeudor.VisibleIndex = 1
        '
        'colDedDescripcion
        '
        Me.colDedDescripcion.Caption = "Descripción"
        Me.colDedDescripcion.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.colDedDescripcion.FieldName = "Descripcion"
        Me.colDedDescripcion.Name = "colDedDescripcion"
        Me.colDedDescripcion.SummaryItem.DisplayFormat = "SALDO DEUDORES:"
        Me.colDedDescripcion.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colDedDescripcion.Visible = True
        Me.colDedDescripcion.VisibleIndex = 2
        Me.colDedDescripcion.Width = 266
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'colDedValorDeudor
        '
        Me.colDedValorDeudor.Caption = "Valor"
        Me.colDedValorDeudor.DisplayFormat.FormatString = "c"
        Me.colDedValorDeudor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDedValorDeudor.FieldName = "ValorDeudor"
        Me.colDedValorDeudor.Name = "colDedValorDeudor"
        Me.colDedValorDeudor.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDedValorDeudor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDedValorDeudor.Visible = True
        Me.colDedValorDeudor.VisibleIndex = 3
        '
        'Requisitos
        '
        Me.Requisitos.Controls.Add(Me.btnCargarRequisitos)
        Me.Requisitos.Controls.Add(Me.btnQuitarRequisito)
        Me.Requisitos.Controls.Add(Me.btnAgregarRequisito)
        Me.Requisitos.Controls.Add(Me.GridRequisitos)
        Me.Requisitos.Name = "Requisitos"
        Me.Requisitos.Size = New System.Drawing.Size(758, 132)
        Me.Requisitos.Text = "Requisitos del Reclamo"
        '
        'btnCargarRequisitos
        '
        Me.btnCargarRequisitos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargarRequisitos.Location = New System.Drawing.Point(619, 94)
        Me.btnCargarRequisitos.Name = "btnCargarRequisitos"
        Me.btnCargarRequisitos.Size = New System.Drawing.Size(102, 29)
        Me.btnCargarRequisitos.TabIndex = 3
        Me.btnCargarRequisitos.Text = "Cargar Requisitos"
        '
        'btnQuitarRequisito
        '
        Me.btnQuitarRequisito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarRequisito.Location = New System.Drawing.Point(619, 38)
        Me.btnQuitarRequisito.Name = "btnQuitarRequisito"
        Me.btnQuitarRequisito.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarRequisito.TabIndex = 2
        Me.btnQuitarRequisito.Text = "Quitar"
        '
        'btnAgregarRequisito
        '
        Me.btnAgregarRequisito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarRequisito.Location = New System.Drawing.Point(620, 3)
        Me.btnAgregarRequisito.Name = "btnAgregarRequisito"
        Me.btnAgregarRequisito.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarRequisito.TabIndex = 0
        Me.btnAgregarRequisito.Text = "Agregar Requisito"
        '
        'GridRequisitos
        '
        Me.GridRequisitos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRequisitos.ColumnasAdicionales = ""
        Me.GridRequisitos.Location = New System.Drawing.Point(3, 3)
        Me.GridRequisitos.MainView = Me.VistaRequisitos
        Me.GridRequisitos.Name = "GridRequisitos"
        Me.GridRequisitos.NombreTabla = "SiniestrosRequisitos"
        Me.GridRequisitos.Size = New System.Drawing.Size(611, 150)
        Me.GridRequisitos.TabIndex = 1
        Me.GridRequisitos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaRequisitos})
        '
        'VistaRequisitos
        '
        Me.VistaRequisitos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReqIdPoliza, Me.colReqIdProducto, Me.colReqIdCertificado, Me.colReqIdSiniestro, Me.colReqIdRequisito, Me.colReqDescripcion, Me.colReqFechaPresentado, Me.colReqComentarios})
        Me.VistaRequisitos.GridControl = Me.GridRequisitos
        Me.VistaRequisitos.Name = "VistaRequisitos"
        Me.VistaRequisitos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaRequisitos.OptionsView.ShowGroupPanel = False
        '
        'colReqIdPoliza
        '
        Me.colReqIdPoliza.Caption = "Poliza"
        Me.colReqIdPoliza.FieldName = "IdPoliza"
        Me.colReqIdPoliza.Name = "colReqIdPoliza"
        '
        'colReqIdProducto
        '
        Me.colReqIdProducto.Caption = "Producto"
        Me.colReqIdProducto.FieldName = "IdProducto"
        Me.colReqIdProducto.Name = "colReqIdProducto"
        '
        'colReqIdCertificado
        '
        Me.colReqIdCertificado.Caption = "Certificado"
        Me.colReqIdCertificado.FieldName = "IdCertificado"
        Me.colReqIdCertificado.Name = "colReqIdCertificado"
        '
        'colReqIdSiniestro
        '
        Me.colReqIdSiniestro.Caption = "Siniestro"
        Me.colReqIdSiniestro.FieldName = "IdSiniestro"
        Me.colReqIdSiniestro.Name = "colReqIdSiniestro"
        '
        'colReqIdRequisito
        '
        Me.colReqIdRequisito.Caption = "Orden"
        Me.colReqIdRequisito.FieldName = "IdRequisito"
        Me.colReqIdRequisito.Name = "colReqIdRequisito"
        Me.colReqIdRequisito.Visible = True
        Me.colReqIdRequisito.VisibleIndex = 0
        Me.colReqIdRequisito.Width = 50
        '
        'colReqDescripcion
        '
        Me.colReqDescripcion.Caption = "Requisito"
        Me.colReqDescripcion.FieldName = "Descripcion"
        Me.colReqDescripcion.Name = "colReqDescripcion"
        Me.colReqDescripcion.Visible = True
        Me.colReqDescripcion.VisibleIndex = 1
        Me.colReqDescripcion.Width = 175
        '
        'colReqFechaPresentado
        '
        Me.colReqFechaPresentado.Caption = "Fecha Presentado"
        Me.colReqFechaPresentado.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colReqFechaPresentado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReqFechaPresentado.FieldName = "FechaPresentado"
        Me.colReqFechaPresentado.Name = "colReqFechaPresentado"
        Me.colReqFechaPresentado.Visible = True
        Me.colReqFechaPresentado.VisibleIndex = 2
        Me.colReqFechaPresentado.Width = 175
        '
        'colReqComentarios
        '
        Me.colReqComentarios.Caption = "Comentarios"
        Me.colReqComentarios.FieldName = "Comentarios"
        Me.colReqComentarios.Name = "colReqComentarios"
        Me.colReqComentarios.Visible = True
        Me.colReqComentarios.VisibleIndex = 3
        Me.colReqComentarios.Width = 178
        '
        'Archivos
        '
        Me.Archivos.Controls.Add(Me.btnAgregarCarpeta)
        Me.Archivos.Controls.Add(Me.btnQuitarDoc)
        Me.Archivos.Controls.Add(Me.btnAgregarDoc)
        Me.Archivos.Controls.Add(Me.GridArchivos)
        Me.Archivos.Name = "Archivos"
        Me.Archivos.Size = New System.Drawing.Size(758, 132)
        Me.Archivos.Text = "Archivos Relacionados"
        '
        'btnAgregarCarpeta
        '
        Me.btnAgregarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarpeta.Location = New System.Drawing.Point(616, 40)
        Me.btnAgregarCarpeta.Name = "btnAgregarCarpeta"
        Me.btnAgregarCarpeta.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarCarpeta.TabIndex = 2
        Me.btnAgregarCarpeta.Text = "Agregar Carpeta"
        '
        'btnQuitarDoc
        '
        Me.btnQuitarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarDoc.Location = New System.Drawing.Point(616, 75)
        Me.btnQuitarDoc.Name = "btnQuitarDoc"
        Me.btnQuitarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnQuitarDoc.TabIndex = 3
        Me.btnQuitarDoc.Text = "Quitar"
        '
        'btnAgregarDoc
        '
        Me.btnAgregarDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarDoc.Location = New System.Drawing.Point(616, 3)
        Me.btnAgregarDoc.Name = "btnAgregarDoc"
        Me.btnAgregarDoc.Size = New System.Drawing.Size(102, 29)
        Me.btnAgregarDoc.TabIndex = 0
        Me.btnAgregarDoc.Text = "Agregar Archivo"
        '
        'GridArchivos
        '
        Me.GridArchivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridArchivos.ColumnasAdicionales = ""
        Me.GridArchivos.Location = New System.Drawing.Point(1, 3)
        Me.GridArchivos.MainView = Me.VistaArchivos
        Me.GridArchivos.Name = "GridArchivos"
        Me.GridArchivos.NombreTabla = "SiniestrosDocumentos"
        Me.GridArchivos.Size = New System.Drawing.Size(609, 125)
        Me.GridArchivos.TabIndex = 1
        Me.GridArchivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaArchivos})
        '
        'VistaArchivos
        '
        Me.VistaArchivos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArcIdPoliza, Me.colArcIdProducto, Me.colArcIdCertificado, Me.colArcIdSiniestro, Me.colArcIdDocumento, Me.colArcDocumento})
        Me.VistaArchivos.GridControl = Me.GridArchivos
        Me.VistaArchivos.Name = "VistaArchivos"
        Me.VistaArchivos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaArchivos.OptionsView.ShowGroupPanel = False
        '
        'colArcIdPoliza
        '
        Me.colArcIdPoliza.Caption = "Poliza"
        Me.colArcIdPoliza.FieldName = "IdPoliza"
        Me.colArcIdPoliza.Name = "colArcIdPoliza"
        '
        'colArcIdProducto
        '
        Me.colArcIdProducto.Caption = "Producto"
        Me.colArcIdProducto.FieldName = "IdProducto"
        Me.colArcIdProducto.Name = "colArcIdProducto"
        '
        'colArcIdCertificado
        '
        Me.colArcIdCertificado.Caption = "Certificado"
        Me.colArcIdCertificado.FieldName = "IdCertificado"
        Me.colArcIdCertificado.Name = "colArcIdCertificado"
        '
        'colArcIdSiniestro
        '
        Me.colArcIdSiniestro.Caption = "Siniestro"
        Me.colArcIdSiniestro.FieldName = "IdSiniestro"
        Me.colArcIdSiniestro.Name = "colArcIdSiniestro"
        '
        'colArcIdDocumento
        '
        Me.colArcIdDocumento.Caption = "Orden"
        Me.colArcIdDocumento.FieldName = "IdDocumento"
        Me.colArcIdDocumento.Name = "colArcIdDocumento"
        Me.colArcIdDocumento.Visible = True
        Me.colArcIdDocumento.VisibleIndex = 0
        Me.colArcIdDocumento.Width = 47
        '
        'colArcDocumento
        '
        Me.colArcDocumento.Caption = "Archivo"
        Me.colArcDocumento.FieldName = "Documento"
        Me.colArcDocumento.Name = "colArcDocumento"
        Me.colArcDocumento.OptionsColumn.AllowEdit = False
        Me.colArcDocumento.Visible = True
        Me.colArcDocumento.VisibleIndex = 1
        Me.colArcDocumento.Width = 531
        '
        'Bienes
        '
        Me.Bienes.Controls.Add(Me.btnEditarCertificado)
        Me.Bienes.Controls.Add(Me.GridBienes)
        Me.Bienes.Name = "Bienes"
        Me.Bienes.Size = New System.Drawing.Size(758, 132)
        Me.Bienes.Text = "Bienes Asegurados"
        '
        'btnEditarCertificado
        '
        Me.btnEditarCertificado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarCertificado.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEditarCertificado.Appearance.Options.UseFont = True
        Me.btnEditarCertificado.Appearance.Options.UseTextOptions = True
        Me.btnEditarCertificado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnEditarCertificado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEditarCertificado.Image = CType(resources.GetObject("btnEditarCertificado.Image"), System.Drawing.Image)
        Me.btnEditarCertificado.Location = New System.Drawing.Point(550, 132)
        Me.btnEditarCertificado.Name = "btnEditarCertificado"
        Me.btnEditarCertificado.Size = New System.Drawing.Size(171, 31)
        Me.btnEditarCertificado.TabIndex = 21
        Me.btnEditarCertificado.Text = "Editar Certificado"
        '
        'GridBienes
        '
        Me.GridBienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBienes.ColumnasAdicionales = ""
        Me.GridBienes.Location = New System.Drawing.Point(2, 3)
        Me.GridBienes.MainView = Me.VistaBienes
        Me.GridBienes.Name = "GridBienes"
        Me.GridBienes.NombreTabla = ""
        Me.GridBienes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemMemoEdit2})
        Me.GridBienes.Size = New System.Drawing.Size(718, 128)
        Me.GridBienes.TabIndex = 1
        Me.GridBienes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBienes})
        '
        'VistaBienes
        '
        Me.VistaBienes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbiIdPoliza, Me.colbiIdProducto, Me.colbiIdCertificado, Me.colbiIdBien, Me.colbiNombreBien, Me.colbiDescripcionBien})
        Me.VistaBienes.GridControl = Me.GridBienes
        Me.VistaBienes.Name = "VistaBienes"
        Me.VistaBienes.OptionsCustomization.AllowRowSizing = True
        Me.VistaBienes.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaBienes.OptionsView.ShowGroupPanel = False
        '
        'colbiIdPoliza
        '
        Me.colbiIdPoliza.Caption = "IdPoliza"
        Me.colbiIdPoliza.FieldName = "IdPoliza"
        Me.colbiIdPoliza.Name = "colbiIdPoliza"
        '
        'colbiIdProducto
        '
        Me.colbiIdProducto.Caption = "IdProducto"
        Me.colbiIdProducto.FieldName = "IdProducto"
        Me.colbiIdProducto.Name = "colbiIdProducto"
        '
        'colbiIdCertificado
        '
        Me.colbiIdCertificado.Caption = "IdCertificado"
        Me.colbiIdCertificado.FieldName = "IdCertificado"
        Me.colbiIdCertificado.Name = "colbiIdCertificado"
        '
        'colbiIdBien
        '
        Me.colbiIdBien.Caption = "Orden"
        Me.colbiIdBien.FieldName = "IdBien"
        Me.colbiIdBien.Name = "colbiIdBien"
        Me.colbiIdBien.Visible = True
        Me.colbiIdBien.VisibleIndex = 0
        Me.colbiIdBien.Width = 52
        '
        'colbiNombreBien
        '
        Me.colbiNombreBien.Caption = "Tipo Bien"
        Me.colbiNombreBien.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colbiNombreBien.FieldName = "NombreBien"
        Me.colbiNombreBien.Name = "colbiNombreBien"
        Me.colbiNombreBien.Visible = True
        Me.colbiNombreBien.VisibleIndex = 1
        Me.colbiNombreBien.Width = 121
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'colbiDescripcionBien
        '
        Me.colbiDescripcionBien.Caption = "Descripción del Bien"
        Me.colbiDescripcionBien.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colbiDescripcionBien.FieldName = "DescripcionBien"
        Me.colbiDescripcionBien.Name = "colbiDescripcionBien"
        Me.colbiDescripcionBien.Visible = True
        Me.colbiDescripcionBien.VisibleIndex = 2
        Me.colbiDescripcionBien.Width = 375
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'Coberturas
        '
        Me.Coberturas.Controls.Add(Me.GridCoberturas)
        Me.Coberturas.Name = "Coberturas"
        Me.Coberturas.Size = New System.Drawing.Size(758, 132)
        Me.Coberturas.Text = "Coberturas"
        '
        'GridCoberturas
        '
        Me.GridCoberturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCoberturas.ColumnasAdicionales = ""
        Me.GridCoberturas.Location = New System.Drawing.Point(3, 3)
        Me.GridCoberturas.MainView = Me.VistaCoberturas
        Me.GridCoberturas.Name = "GridCoberturas"
        Me.GridCoberturas.NombreTabla = ""
        Me.GridCoberturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemMemoEdit3})
        Me.GridCoberturas.Size = New System.Drawing.Size(717, 148)
        Me.GridCoberturas.TabIndex = 1
        Me.GridCoberturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCoberturas})
        '
        'VistaCoberturas
        '
        Me.VistaCoberturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPoliza, Me.colProducto, Me.colCertificado, Me.colCobertura, Me.colDescripcion, Me.colSuma, Me.colPorceSuma, Me.colTasa, Me.colPrima, Me.colDeducible, Me.colDescuento})
        Me.VistaCoberturas.GridControl = Me.GridCoberturas
        Me.VistaCoberturas.Name = "VistaCoberturas"
        Me.VistaCoberturas.OptionsCustomization.AllowRowSizing = True
        Me.VistaCoberturas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaCoberturas.OptionsView.ShowGroupPanel = False
        '
        'colPoliza
        '
        Me.colPoliza.Caption = "Poliza"
        Me.colPoliza.FieldName = "IdPoliza"
        Me.colPoliza.Name = "colPoliza"
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "IdProducto"
        Me.colProducto.Name = "colProducto"
        '
        'colCertificado
        '
        Me.colCertificado.Caption = "Certificado"
        Me.colCertificado.FieldName = "IdCertificado"
        Me.colCertificado.Name = "colCertificado"
        '
        'colCobertura
        '
        Me.colCobertura.Caption = "No.Cob."
        Me.colCobertura.FieldName = "IdCobertura"
        Me.colCobertura.Name = "colCobertura"
        Me.colCobertura.Visible = True
        Me.colCobertura.VisibleIndex = 0
        Me.colCobertura.Width = 65
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceCell.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Tag = "NOSAVE"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 183
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'colSuma
        '
        Me.colSuma.Caption = "Suma Asegurada"
        Me.colSuma.DisplayFormat.FormatString = "c"
        Me.colSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSuma.FieldName = "SumaAsegurada"
        Me.colSuma.Name = "colSuma"
        Me.colSuma.Visible = True
        Me.colSuma.VisibleIndex = 2
        Me.colSuma.Width = 110
        '
        'colPorceSuma
        '
        Me.colPorceSuma.Caption = "%Suma"
        Me.colPorceSuma.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorceSuma.FieldName = "PorceSuma"
        Me.colPorceSuma.Name = "colPorceSuma"
        Me.colPorceSuma.Visible = True
        Me.colPorceSuma.VisibleIndex = 3
        '
        'colTasa
        '
        Me.colTasa.Caption = "Tasa"
        Me.colTasa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTasa.FieldName = "Tasa"
        Me.colTasa.Name = "colTasa"
        Me.colTasa.Visible = True
        Me.colTasa.VisibleIndex = 4
        Me.colTasa.Width = 57
        '
        'colPrima
        '
        Me.colPrima.Caption = "Prima"
        Me.colPrima.DisplayFormat.FormatString = "c"
        Me.colPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrima.FieldName = "Prima"
        Me.colPrima.Name = "colPrima"
        Me.colPrima.Visible = True
        Me.colPrima.VisibleIndex = 5
        '
        'colDeducible
        '
        Me.colDeducible.AppearanceCell.Options.UseTextOptions = True
        Me.colDeducible.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDeducible.Caption = "Deducible"
        Me.colDeducible.ColumnEdit = Me.RepositoryItemMemoEdit3
        Me.colDeducible.FieldName = "Deducible"
        Me.colDeducible.Name = "colDeducible"
        Me.colDeducible.Visible = True
        Me.colDeducible.VisibleIndex = 6
        Me.colDeducible.Width = 207
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Descuento"
        Me.colDescuento.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colDescuento.FieldName = "AplicarDescuento"
        Me.colDescuento.Name = "colDescuento"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        '
        'Gestiones
        '
        Me.Gestiones.Controls.Add(Me.cboPendientePor)
        Me.Gestiones.Controls.Add(Me.btnGestionOutlook)
        Me.Gestiones.Controls.Add(Me.btnQuitarGestion)
        Me.Gestiones.Controls.Add(Me.btnAgregarGestion)
        Me.Gestiones.Controls.Add(Me.GridGestiones)
        Me.Gestiones.Name = "Gestiones"
        Me.Gestiones.Size = New System.Drawing.Size(758, 132)
        Me.Gestiones.Text = "Gestiones"
        '
        'cboPendientePor
        '
        Me.cboPendientePor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPendientePor.CampoAutoCompletar = 0
        Me.cboPendientePor.CampoBusqueda = False
        Me.cboPendientePor.CampoDisplay = 1
        Me.cboPendientePor.CampoEsLlave = False
        Me.cboPendientePor.CampoValor = 0
        Me.cboPendientePor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPendientePor.ControlBackColor = System.Drawing.Color.White
        Me.cboPendientePor.ControlForeColor = System.Drawing.Color.Black
        Me.cboPendientePor.FilasVisibles = 0
        Me.cboPendientePor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboPendientePor.LabelText = "Pendiente Por"
        Me.cboPendientePor.LabelWidth = 100
        Me.cboPendientePor.Lista = ""
        Me.cboPendientePor.Location = New System.Drawing.Point(649, 89)
        Me.cboPendientePor.MostrarBusquedaColumnas = False
        Me.cboPendientePor.Name = "cboPendientePor"
        Me.cboPendientePor.NombreCampo = "PendientePor"
        Me.cboPendientePor.Obligatorio = False
        Me.cboPendientePor.Query = ""
        Me.cboPendientePor.SelectIndex = 0
        Me.cboPendientePor.Size = New System.Drawing.Size(107, 38)
        Me.cboPendientePor.SoloLectura = False
        Me.cboPendientePor.StringConection = ""
        Me.cboPendientePor.TabIndex = 9
        Me.cboPendientePor.TextoNuevoItem = ""
        Me.cboPendientePor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboPendientePor.Valor = ""
        '
        'btnGestionOutlook
        '
        Me.btnGestionOutlook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestionOutlook.Appearance.Options.UseTextOptions = True
        Me.btnGestionOutlook.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGestionOutlook.Location = New System.Drawing.Point(652, 51)
        Me.btnGestionOutlook.Name = "btnGestionOutlook"
        Me.btnGestionOutlook.Size = New System.Drawing.Size(102, 34)
        Me.btnGestionOutlook.TabIndex = 8
        Me.btnGestionOutlook.Text = "A Calendario Outlook"
        '
        'btnQuitarGestion
        '
        Me.btnQuitarGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGestion.Location = New System.Drawing.Point(652, 27)
        Me.btnQuitarGestion.Name = "btnQuitarGestion"
        Me.btnQuitarGestion.Size = New System.Drawing.Size(102, 22)
        Me.btnQuitarGestion.TabIndex = 7
        Me.btnQuitarGestion.Text = "Quitar"
        '
        'btnAgregarGestion
        '
        Me.btnAgregarGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGestion.Location = New System.Drawing.Point(652, 3)
        Me.btnAgregarGestion.Name = "btnAgregarGestion"
        Me.btnAgregarGestion.Size = New System.Drawing.Size(102, 22)
        Me.btnAgregarGestion.TabIndex = 6
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
        Me.GridGestiones.Size = New System.Drawing.Size(643, 164)
        Me.GridGestiones.TabIndex = 0
        Me.GridGestiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaGestiones})
        '
        'VistaGestiones
        '
        Me.VistaGestiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGesIdPoliza, Me.colGesIdProducto, Me.colGesIdCertificado, Me.colGesIdSiniestro, Me.colGesTipoGestion, Me.colGesIdGestion, Me.colGesFechaGestion, Me.colGesComentarios, Me.colGesIdUsuario, Me.colGesFechaProximaGestion})
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
        'colGesIdCertificado
        '
        Me.colGesIdCertificado.Caption = "Certificado"
        Me.colGesIdCertificado.FieldName = "IdCertificado"
        Me.colGesIdCertificado.Name = "colGesIdCertificado"
        Me.colGesIdCertificado.OptionsColumn.AllowEdit = False
        '
        'colGesIdSiniestro
        '
        Me.colGesIdSiniestro.Caption = "Siniestro"
        Me.colGesIdSiniestro.FieldName = "IdSiniestro"
        Me.colGesIdSiniestro.Name = "colGesIdSiniestro"
        Me.colGesIdSiniestro.OptionsColumn.AllowEdit = False
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
        'Fechas
        '
        Me.Fechas.Controls.Add(Me.lytFechas)
        Me.Fechas.Name = "Fechas"
        Me.Fechas.Size = New System.Drawing.Size(758, 132)
        Me.Fechas.Text = "Fechas Reclamo"
        '
        'lytFechas
        '
        Me.lytFechas.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lytFechas.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
        Me.lytFechas.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lytFechas.Appearance.DisabledLayoutItem.Options.UseForeColor = True
        Me.lytFechas.Controls.Add(Me.txtFechaFinalReclamo)
        Me.lytFechas.Controls.Add(Me.txtFechaEnvioFiniquitoAseg)
        Me.lytFechas.Controls.Add(Me.txtFechaEntregaFiniquito)
        Me.lytFechas.Controls.Add(Me.txtFechaEntregaCheque)
        Me.lytFechas.Controls.Add(Me.txtFechaAsegEntregaCheque)
        Me.lytFechas.Controls.Add(Me.txtFechaFirmaConvAjuste)
        Me.lytFechas.Controls.Add(Me.txtFechaRecibeConvAjuste)
        Me.lytFechas.Controls.Add(Me.txtFechaCienteEntregaDocs)
        Me.lytFechas.Controls.Add(Me.txtFechaInspeccion)
        Me.lytFechas.Controls.Add(Me.txtFechaAvisoAseguradora)
        Me.lytFechas.Controls.Add(Me.txtFechaAjustadorReqDocs)
        Me.lytFechas.Controls.Add(Me.txtFechaEnvioClientreConvAju)
        Me.lytFechas.Controls.Add(Me.txtFechaEnvioConvAseg)
        Me.lytFechas.Controls.Add(Me.txtFechaEnvioDocAseg)
        Me.lytFechas.Controls.Add(Me.txtFechaSolicitaInspeccion)
        Me.lytFechas.Controls.Add(Me.txtFechaAvisoCliente)
        Me.lytFechas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lytFechas.Location = New System.Drawing.Point(0, 0)
        Me.lytFechas.Name = "lytFechas"
        Me.lytFechas.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.CustomSize
        Me.lytFechas.Root = Me.LayoutControlGroup1
        Me.lytFechas.Size = New System.Drawing.Size(758, 132)
        Me.lytFechas.TabIndex = 0
        Me.lytFechas.Text = "LayoutControl1"
        '
        'txtFechaFinalReclamo
        '
        Me.txtFechaFinalReclamo.CampoBusqueda = False
        Me.txtFechaFinalReclamo.CampoEsLlave = False
        Me.txtFechaFinalReclamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaFinalReclamo.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaFinalReclamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaFinalReclamo.FechaActual = False
        Me.txtFechaFinalReclamo.Formato = "dd/MMM/yyyy"
        Me.txtFechaFinalReclamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaFinalReclamo.LabelText = "16. Final reclamo"
        Me.txtFechaFinalReclamo.LabelWidth = 225
        Me.txtFechaFinalReclamo.Location = New System.Drawing.Point(393, 224)
        Me.txtFechaFinalReclamo.MaxLength = 0
        Me.txtFechaFinalReclamo.Name = "txtFechaFinalReclamo"
        Me.txtFechaFinalReclamo.NombreCampo = "FechaFinalReclamo"
        Me.txtFechaFinalReclamo.Obligatorio = False
        Me.txtFechaFinalReclamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaFinalReclamo.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaFinalReclamo.SoloLectura = False
        Me.txtFechaFinalReclamo.TabIndex = 20
        Me.txtFechaFinalReclamo.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaFinalReclamo.Valor = Nothing
        '
        'txtFechaEnvioFiniquitoAseg
        '
        Me.txtFechaEnvioFiniquitoAseg.CampoBusqueda = False
        Me.txtFechaEnvioFiniquitoAseg.CampoEsLlave = False
        Me.txtFechaEnvioFiniquitoAseg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvioFiniquitoAseg.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvioFiniquitoAseg.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvioFiniquitoAseg.FechaActual = False
        Me.txtFechaEnvioFiniquitoAseg.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvioFiniquitoAseg.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvioFiniquitoAseg.LabelText = "15. Fecha finiquito ADRISA manda a Aseg."
        Me.txtFechaEnvioFiniquitoAseg.LabelWidth = 225
        Me.txtFechaEnvioFiniquitoAseg.Location = New System.Drawing.Point(7, 224)
        Me.txtFechaEnvioFiniquitoAseg.MaxLength = 0
        Me.txtFechaEnvioFiniquitoAseg.Name = "txtFechaEnvioFiniquitoAseg"
        Me.txtFechaEnvioFiniquitoAseg.NombreCampo = "FechaEnvioFiniquitoAseg"
        Me.txtFechaEnvioFiniquitoAseg.Obligatorio = False
        Me.txtFechaEnvioFiniquitoAseg.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvioFiniquitoAseg.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaEnvioFiniquitoAseg.SoloLectura = False
        Me.txtFechaEnvioFiniquitoAseg.TabIndex = 19
        Me.txtFechaEnvioFiniquitoAseg.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvioFiniquitoAseg.Valor = Nothing
        '
        'txtFechaEntregaFiniquito
        '
        Me.txtFechaEntregaFiniquito.CampoBusqueda = False
        Me.txtFechaEntregaFiniquito.CampoEsLlave = False
        Me.txtFechaEntregaFiniquito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEntregaFiniquito.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEntregaFiniquito.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEntregaFiniquito.FechaActual = False
        Me.txtFechaEntregaFiniquito.Formato = "dd/MMM/yyyy"
        Me.txtFechaEntregaFiniquito.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEntregaFiniquito.LabelText = "14. Fecha cliente entrega finiquito aceptado"
        Me.txtFechaEntregaFiniquito.LabelWidth = 225
        Me.txtFechaEntregaFiniquito.Location = New System.Drawing.Point(393, 193)
        Me.txtFechaEntregaFiniquito.MaxLength = 0
        Me.txtFechaEntregaFiniquito.Name = "txtFechaEntregaFiniquito"
        Me.txtFechaEntregaFiniquito.NombreCampo = "FechaEntregaFiniquito"
        Me.txtFechaEntregaFiniquito.Obligatorio = False
        Me.txtFechaEntregaFiniquito.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEntregaFiniquito.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaEntregaFiniquito.SoloLectura = False
        Me.txtFechaEntregaFiniquito.TabIndex = 18
        Me.txtFechaEntregaFiniquito.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEntregaFiniquito.Valor = Nothing
        '
        'txtFechaEntregaCheque
        '
        Me.txtFechaEntregaCheque.CampoBusqueda = False
        Me.txtFechaEntregaCheque.CampoEsLlave = False
        Me.txtFechaEntregaCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEntregaCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEntregaCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEntregaCheque.FechaActual = False
        Me.txtFechaEntregaCheque.Formato = "dd/MMM/yyyy"
        Me.txtFechaEntregaCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEntregaCheque.LabelText = "13. Fecha ADRISA entrega a cliente cheque"
        Me.txtFechaEntregaCheque.LabelWidth = 225
        Me.txtFechaEntregaCheque.Location = New System.Drawing.Point(7, 193)
        Me.txtFechaEntregaCheque.MaxLength = 0
        Me.txtFechaEntregaCheque.Name = "txtFechaEntregaCheque"
        Me.txtFechaEntregaCheque.NombreCampo = "FechaEntregaCheque"
        Me.txtFechaEntregaCheque.Obligatorio = False
        Me.txtFechaEntregaCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEntregaCheque.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaEntregaCheque.SoloLectura = False
        Me.txtFechaEntregaCheque.TabIndex = 17
        Me.txtFechaEntregaCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEntregaCheque.Valor = Nothing
        '
        'txtFechaAsegEntregaCheque
        '
        Me.txtFechaAsegEntregaCheque.CampoBusqueda = False
        Me.txtFechaAsegEntregaCheque.CampoEsLlave = False
        Me.txtFechaAsegEntregaCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAsegEntregaCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAsegEntregaCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAsegEntregaCheque.FechaActual = False
        Me.txtFechaAsegEntregaCheque.Formato = "dd/MMM/yyyy"
        Me.txtFechaAsegEntregaCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAsegEntregaCheque.LabelText = "12. Fecha Aseg. entrega cheque de pago"
        Me.txtFechaAsegEntregaCheque.LabelWidth = 225
        Me.txtFechaAsegEntregaCheque.Location = New System.Drawing.Point(393, 162)
        Me.txtFechaAsegEntregaCheque.MaxLength = 0
        Me.txtFechaAsegEntregaCheque.Name = "txtFechaAsegEntregaCheque"
        Me.txtFechaAsegEntregaCheque.NombreCampo = "FechaAsegEntregaCheque"
        Me.txtFechaAsegEntregaCheque.Obligatorio = False
        Me.txtFechaAsegEntregaCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAsegEntregaCheque.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaAsegEntregaCheque.SoloLectura = False
        Me.txtFechaAsegEntregaCheque.TabIndex = 16
        Me.txtFechaAsegEntregaCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAsegEntregaCheque.Valor = Nothing
        '
        'txtFechaFirmaConvAjuste
        '
        Me.txtFechaFirmaConvAjuste.CampoBusqueda = False
        Me.txtFechaFirmaConvAjuste.CampoEsLlave = False
        Me.txtFechaFirmaConvAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaFirmaConvAjuste.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaFirmaConvAjuste.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaFirmaConvAjuste.FechaActual = False
        Me.txtFechaFirmaConvAjuste.Formato = "dd/MMM/yyyy"
        Me.txtFechaFirmaConvAjuste.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaFirmaConvAjuste.LabelText = "10. Fecha cliente firma y entrega conv. aceptado "
        Me.txtFechaFirmaConvAjuste.LabelWidth = 225
        Me.txtFechaFirmaConvAjuste.Location = New System.Drawing.Point(393, 131)
        Me.txtFechaFirmaConvAjuste.MaxLength = 0
        Me.txtFechaFirmaConvAjuste.Name = "txtFechaFirmaConvAjuste"
        Me.txtFechaFirmaConvAjuste.NombreCampo = "FechaFirmaConvAjuste"
        Me.txtFechaFirmaConvAjuste.Obligatorio = False
        Me.txtFechaFirmaConvAjuste.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaFirmaConvAjuste.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaFirmaConvAjuste.SoloLectura = False
        Me.txtFechaFirmaConvAjuste.TabIndex = 15
        Me.txtFechaFirmaConvAjuste.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaFirmaConvAjuste.Valor = Nothing
        '
        'txtFechaRecibeConvAjuste
        '
        Me.txtFechaRecibeConvAjuste.CampoBusqueda = False
        Me.txtFechaRecibeConvAjuste.CampoEsLlave = False
        Me.txtFechaRecibeConvAjuste.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaRecibeConvAjuste.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaRecibeConvAjuste.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaRecibeConvAjuste.FechaActual = False
        Me.txtFechaRecibeConvAjuste.Formato = "dd/MMM/yyyy"
        Me.txtFechaRecibeConvAjuste.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaRecibeConvAjuste.LabelText = "8. Fecha recibimos convenio ajuste"
        Me.txtFechaRecibeConvAjuste.LabelWidth = 225
        Me.txtFechaRecibeConvAjuste.Location = New System.Drawing.Point(393, 100)
        Me.txtFechaRecibeConvAjuste.MaxLength = 0
        Me.txtFechaRecibeConvAjuste.Name = "txtFechaRecibeConvAjuste"
        Me.txtFechaRecibeConvAjuste.NombreCampo = "FechaRecibeConvAjuste"
        Me.txtFechaRecibeConvAjuste.Obligatorio = False
        Me.txtFechaRecibeConvAjuste.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaRecibeConvAjuste.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaRecibeConvAjuste.SoloLectura = False
        Me.txtFechaRecibeConvAjuste.TabIndex = 14
        Me.txtFechaRecibeConvAjuste.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaRecibeConvAjuste.Valor = Nothing
        '
        'txtFechaCienteEntregaDocs
        '
        Me.txtFechaCienteEntregaDocs.CampoBusqueda = False
        Me.txtFechaCienteEntregaDocs.CampoEsLlave = False
        Me.txtFechaCienteEntregaDocs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCienteEntregaDocs.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCienteEntregaDocs.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCienteEntregaDocs.FechaActual = False
        Me.txtFechaCienteEntregaDocs.Formato = "dd/MMM/yyyy"
        Me.txtFechaCienteEntregaDocs.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCienteEntregaDocs.LabelText = "6. Fecha cliente entrega a ADRISA docs."
        Me.txtFechaCienteEntregaDocs.LabelWidth = 225
        Me.txtFechaCienteEntregaDocs.Location = New System.Drawing.Point(393, 69)
        Me.txtFechaCienteEntregaDocs.MaxLength = 0
        Me.txtFechaCienteEntregaDocs.Name = "txtFechaCienteEntregaDocs"
        Me.txtFechaCienteEntregaDocs.NombreCampo = "FechaCienteEntregaDocs"
        Me.txtFechaCienteEntregaDocs.Obligatorio = False
        Me.txtFechaCienteEntregaDocs.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCienteEntregaDocs.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaCienteEntregaDocs.SoloLectura = False
        Me.txtFechaCienteEntregaDocs.TabIndex = 13
        Me.txtFechaCienteEntregaDocs.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCienteEntregaDocs.Valor = Nothing
        '
        'txtFechaInspeccion
        '
        Me.txtFechaInspeccion.CampoBusqueda = False
        Me.txtFechaInspeccion.CampoEsLlave = False
        Me.txtFechaInspeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInspeccion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaInspeccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInspeccion.FechaActual = False
        Me.txtFechaInspeccion.Formato = "dd/MMM/yyyy"
        Me.txtFechaInspeccion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaInspeccion.LabelText = "4. Fecha de la inspección"
        Me.txtFechaInspeccion.LabelWidth = 225
        Me.txtFechaInspeccion.Location = New System.Drawing.Point(393, 38)
        Me.txtFechaInspeccion.MaxLength = 0
        Me.txtFechaInspeccion.Name = "txtFechaInspeccion"
        Me.txtFechaInspeccion.NombreCampo = "FechaInspeccion"
        Me.txtFechaInspeccion.Obligatorio = False
        Me.txtFechaInspeccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInspeccion.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaInspeccion.SoloLectura = False
        Me.txtFechaInspeccion.TabIndex = 12
        Me.txtFechaInspeccion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInspeccion.Valor = Nothing
        '
        'txtFechaAvisoAseguradora
        '
        Me.txtFechaAvisoAseguradora.CampoBusqueda = False
        Me.txtFechaAvisoAseguradora.CampoEsLlave = False
        Me.txtFechaAvisoAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAvisoAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAvisoAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAvisoAseguradora.FechaActual = False
        Me.txtFechaAvisoAseguradora.Formato = "dd/MMM/yyyy"
        Me.txtFechaAvisoAseguradora.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAvisoAseguradora.LabelText = "2. Fecha ADRISA avisa a aseguradora"
        Me.txtFechaAvisoAseguradora.LabelWidth = 225
        Me.txtFechaAvisoAseguradora.Location = New System.Drawing.Point(393, 7)
        Me.txtFechaAvisoAseguradora.MaxLength = 0
        Me.txtFechaAvisoAseguradora.Name = "txtFechaAvisoAseguradora"
        Me.txtFechaAvisoAseguradora.NombreCampo = "FechaAvisoAseguradora"
        Me.txtFechaAvisoAseguradora.Obligatorio = False
        Me.txtFechaAvisoAseguradora.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAvisoAseguradora.Size = New System.Drawing.Size(359, 20)
        Me.txtFechaAvisoAseguradora.SoloLectura = False
        Me.txtFechaAvisoAseguradora.TabIndex = 11
        Me.txtFechaAvisoAseguradora.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAvisoAseguradora.Valor = Nothing
        '
        'txtFechaAjustadorReqDocs
        '
        Me.txtFechaAjustadorReqDocs.CampoBusqueda = False
        Me.txtFechaAjustadorReqDocs.CampoEsLlave = False
        Me.txtFechaAjustadorReqDocs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAjustadorReqDocs.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAjustadorReqDocs.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAjustadorReqDocs.FechaActual = False
        Me.txtFechaAjustadorReqDocs.Formato = "dd/MMM/yyyy"
        Me.txtFechaAjustadorReqDocs.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAjustadorReqDocs.LabelText = "5. Fecha ajustador requiere docs."
        Me.txtFechaAjustadorReqDocs.LabelWidth = 225
        Me.txtFechaAjustadorReqDocs.Location = New System.Drawing.Point(7, 69)
        Me.txtFechaAjustadorReqDocs.MaxLength = 0
        Me.txtFechaAjustadorReqDocs.Name = "txtFechaAjustadorReqDocs"
        Me.txtFechaAjustadorReqDocs.NombreCampo = "FechaAjustadorReqDocs"
        Me.txtFechaAjustadorReqDocs.Obligatorio = False
        Me.txtFechaAjustadorReqDocs.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAjustadorReqDocs.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaAjustadorReqDocs.SoloLectura = False
        Me.txtFechaAjustadorReqDocs.TabIndex = 10
        Me.txtFechaAjustadorReqDocs.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAjustadorReqDocs.Valor = Nothing
        '
        'txtFechaEnvioClientreConvAju
        '
        Me.txtFechaEnvioClientreConvAju.CampoBusqueda = False
        Me.txtFechaEnvioClientreConvAju.CampoEsLlave = False
        Me.txtFechaEnvioClientreConvAju.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvioClientreConvAju.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvioClientreConvAju.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvioClientreConvAju.FechaActual = False
        Me.txtFechaEnvioClientreConvAju.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvioClientreConvAju.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvioClientreConvAju.LabelText = "9. Fecha ADRISA manda a cliente conv. ajuste"
        Me.txtFechaEnvioClientreConvAju.LabelWidth = 225
        Me.txtFechaEnvioClientreConvAju.Location = New System.Drawing.Point(7, 131)
        Me.txtFechaEnvioClientreConvAju.MaxLength = 0
        Me.txtFechaEnvioClientreConvAju.Name = "txtFechaEnvioClientreConvAju"
        Me.txtFechaEnvioClientreConvAju.NombreCampo = "FechaEnvioClientreConvAju"
        Me.txtFechaEnvioClientreConvAju.Obligatorio = False
        Me.txtFechaEnvioClientreConvAju.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvioClientreConvAju.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaEnvioClientreConvAju.SoloLectura = False
        Me.txtFechaEnvioClientreConvAju.TabIndex = 9
        Me.txtFechaEnvioClientreConvAju.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvioClientreConvAju.Valor = Nothing
        '
        'txtFechaEnvioConvAseg
        '
        Me.txtFechaEnvioConvAseg.CampoBusqueda = False
        Me.txtFechaEnvioConvAseg.CampoEsLlave = False
        Me.txtFechaEnvioConvAseg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvioConvAseg.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvioConvAseg.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvioConvAseg.FechaActual = False
        Me.txtFechaEnvioConvAseg.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvioConvAseg.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvioConvAseg.LabelText = "11. Fecha ADRISA manda acept. conv. a aseg."
        Me.txtFechaEnvioConvAseg.LabelWidth = 225
        Me.txtFechaEnvioConvAseg.Location = New System.Drawing.Point(7, 162)
        Me.txtFechaEnvioConvAseg.MaxLength = 0
        Me.txtFechaEnvioConvAseg.Name = "txtFechaEnvioConvAseg"
        Me.txtFechaEnvioConvAseg.NombreCampo = "FechaEnvioConvAseg"
        Me.txtFechaEnvioConvAseg.Obligatorio = False
        Me.txtFechaEnvioConvAseg.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvioConvAseg.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaEnvioConvAseg.SoloLectura = False
        Me.txtFechaEnvioConvAseg.TabIndex = 8
        Me.txtFechaEnvioConvAseg.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvioConvAseg.Valor = Nothing
        '
        'txtFechaEnvioDocAseg
        '
        Me.txtFechaEnvioDocAseg.CampoBusqueda = False
        Me.txtFechaEnvioDocAseg.CampoEsLlave = False
        Me.txtFechaEnvioDocAseg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvioDocAseg.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvioDocAseg.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvioDocAseg.FechaActual = False
        Me.txtFechaEnvioDocAseg.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnvioDocAseg.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvioDocAseg.LabelText = "7. Fecha ADRISA envía docs. a aseguradora"
        Me.txtFechaEnvioDocAseg.LabelWidth = 225
        Me.txtFechaEnvioDocAseg.Location = New System.Drawing.Point(7, 100)
        Me.txtFechaEnvioDocAseg.MaxLength = 0
        Me.txtFechaEnvioDocAseg.Name = "txtFechaEnvioDocAseg"
        Me.txtFechaEnvioDocAseg.NombreCampo = "FechaEnvioDocAseg"
        Me.txtFechaEnvioDocAseg.Obligatorio = False
        Me.txtFechaEnvioDocAseg.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvioDocAseg.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaEnvioDocAseg.SoloLectura = False
        Me.txtFechaEnvioDocAseg.TabIndex = 7
        Me.txtFechaEnvioDocAseg.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvioDocAseg.Valor = Nothing
        '
        'txtFechaSolicitaInspeccion
        '
        Me.txtFechaSolicitaInspeccion.CampoBusqueda = False
        Me.txtFechaSolicitaInspeccion.CampoEsLlave = False
        Me.txtFechaSolicitaInspeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaSolicitaInspeccion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaSolicitaInspeccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaSolicitaInspeccion.FechaActual = False
        Me.txtFechaSolicitaInspeccion.Formato = "dd/MMM/yyyy"
        Me.txtFechaSolicitaInspeccion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaSolicitaInspeccion.LabelText = "3. Fecha en que se solicita inspección"
        Me.txtFechaSolicitaInspeccion.LabelWidth = 225
        Me.txtFechaSolicitaInspeccion.Location = New System.Drawing.Point(7, 38)
        Me.txtFechaSolicitaInspeccion.MaxLength = 0
        Me.txtFechaSolicitaInspeccion.Name = "txtFechaSolicitaInspeccion"
        Me.txtFechaSolicitaInspeccion.NombreCampo = "FechaSolicitaInspeccion"
        Me.txtFechaSolicitaInspeccion.Obligatorio = False
        Me.txtFechaSolicitaInspeccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaSolicitaInspeccion.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaSolicitaInspeccion.SoloLectura = False
        Me.txtFechaSolicitaInspeccion.TabIndex = 6
        Me.txtFechaSolicitaInspeccion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaSolicitaInspeccion.Valor = Nothing
        '
        'txtFechaAvisoCliente
        '
        Me.txtFechaAvisoCliente.CampoBusqueda = False
        Me.txtFechaAvisoCliente.CampoEsLlave = False
        Me.txtFechaAvisoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAvisoCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAvisoCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAvisoCliente.FechaActual = False
        Me.txtFechaAvisoCliente.Formato = "dd/MMM/yyyy"
        Me.txtFechaAvisoCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAvisoCliente.LabelText = "1. Fecha aviso del reclamo del cliente"
        Me.txtFechaAvisoCliente.LabelWidth = 225
        Me.txtFechaAvisoCliente.Location = New System.Drawing.Point(7, 7)
        Me.txtFechaAvisoCliente.MaxLength = 0
        Me.txtFechaAvisoCliente.Name = "txtFechaAvisoCliente"
        Me.txtFechaAvisoCliente.NombreCampo = "FechaAvisoCliente"
        Me.txtFechaAvisoCliente.Obligatorio = False
        Me.txtFechaAvisoCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAvisoCliente.Size = New System.Drawing.Size(375, 20)
        Me.txtFechaAvisoCliente.SoloLectura = False
        Me.txtFechaAvisoCliente.TabIndex = 4
        Me.txtFechaAvisoCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAvisoCliente.Valor = Nothing
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.AlignControlsWithHiddenText = True
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 0
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(758, 250)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtFechaAvisoCliente
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFechaSolicitaInspeccion
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtFechaEnvioDocAseg
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtFechaEnvioConvAseg
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtFechaEnvioClientreConvAju
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtFechaAjustadorReqDocs
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtFechaAvisoAseguradora
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(386, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtFechaInspeccion
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(386, 31)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtFechaCienteEntregaDocs
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(386, 62)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtFechaRecibeConvAjuste
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(386, 93)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtFechaFirmaConvAjuste
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(386, 124)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtFechaAsegEntregaCheque
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(386, 155)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem12.Text = "LayoutControlItem12"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtFechaEntregaCheque
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem13.Text = "LayoutControlItem13"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextToControlDistance = 0
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtFechaEntregaFiniquito
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(386, 186)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem14.Text = "LayoutControlItem14"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextToControlDistance = 0
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtFechaEnvioFiniquitoAseg
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(386, 31)
        Me.LayoutControlItem15.Text = "LayoutControlItem15"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextToControlDistance = 0
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtFechaFinalReclamo
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(386, 217)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(370, 31)
        Me.LayoutControlItem16.Text = "LayoutControlItem16"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtTotalPendiente
        '
        Me.txtTotalPendiente.CampoBusqueda = False
        Me.txtTotalPendiente.CampoEsLlave = False
        Me.txtTotalPendiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalPendiente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalPendiente.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalPendiente.FechaActual = False
        Me.txtTotalPendiente.Formato = "#,###0.00"
        Me.txtTotalPendiente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalPendiente.LabelText = "Valor Pendiente"
        Me.txtTotalPendiente.LabelWidth = 110
        Me.txtTotalPendiente.Location = New System.Drawing.Point(533, 144)
        Me.txtTotalPendiente.MaxLength = 0
        Me.txtTotalPendiente.Name = "txtTotalPendiente"
        Me.txtTotalPendiente.NombreCampo = "TotalPendiente"
        Me.txtTotalPendiente.Obligatorio = False
        Me.txtTotalPendiente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPendiente.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalPendiente.SoloLectura = True
        Me.txtTotalPendiente.TabIndex = 30
        Me.txtTotalPendiente.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalPendiente.Valor = 0
        '
        'btnBuscaCertificado
        '
        Me.btnBuscaCertificado.Image = CType(resources.GetObject("btnBuscaCertificado.Image"), System.Drawing.Image)
        Me.btnBuscaCertificado.Location = New System.Drawing.Point(276, 98)
        Me.btnBuscaCertificado.Name = "btnBuscaCertificado"
        Me.btnBuscaCertificado.Size = New System.Drawing.Size(126, 24)
        Me.btnBuscaCertificado.TabIndex = 25
        Me.btnBuscaCertificado.Text = "Buscar Certificado"
        '
        'txtIdBien
        '
        Me.txtIdBien.CampoBusqueda = True
        Me.txtIdBien.CampoEsLlave = False
        Me.txtIdBien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdBien.ControlBackColor = System.Drawing.Color.White
        Me.txtIdBien.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdBien.FechaActual = False
        Me.txtIdBien.Formato = "###0"
        Me.txtIdBien.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdBien.LabelText = "Cod. Bien"
        Me.txtIdBien.LabelWidth = 60
        Me.txtIdBien.Location = New System.Drawing.Point(434, 100)
        Me.txtIdBien.MaxLength = 25
        Me.txtIdBien.Name = "txtIdBien"
        Me.txtIdBien.NombreCampo = "IdBien"
        Me.txtIdBien.Obligatorio = False
        Me.txtIdBien.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdBien.Size = New System.Drawing.Size(91, 20)
        Me.txtIdBien.SoloLectura = False
        Me.txtIdBien.TabIndex = 26
        Me.txtIdBien.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdBien.Valor = 0
        '
        'txtIdEnvio
        '
        Me.txtIdEnvio.CampoBusqueda = False
        Me.txtIdEnvio.CampoEsLlave = False
        Me.txtIdEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdEnvio.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdEnvio.FechaActual = False
        Me.txtIdEnvio.Formato = ""
        Me.txtIdEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdEnvio.LabelText = "Num. Envio"
        Me.txtIdEnvio.LabelWidth = 110
        Me.txtIdEnvio.Location = New System.Drawing.Point(533, 186)
        Me.txtIdEnvio.MaxLength = 25
        Me.txtIdEnvio.Name = "txtIdEnvio"
        Me.txtIdEnvio.NombreCampo = "IdEnvio"
        Me.txtIdEnvio.Obligatorio = False
        Me.txtIdEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdEnvio.Size = New System.Drawing.Size(202, 20)
        Me.txtIdEnvio.SoloLectura = True
        Me.txtIdEnvio.TabIndex = 32
        Me.txtIdEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdEnvio.Valor = ""
        '
        'txtIdSiniestroAseguradora
        '
        Me.txtIdSiniestroAseguradora.CampoBusqueda = True
        Me.txtIdSiniestroAseguradora.CampoEsLlave = False
        Me.txtIdSiniestroAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestroAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.txtIdSiniestroAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestroAseguradora.FechaActual = False
        Me.txtIdSiniestroAseguradora.Formato = ""
        Me.txtIdSiniestroAseguradora.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestroAseguradora.LabelText = "Reclamo Aseguradora"
        Me.txtIdSiniestroAseguradora.LabelWidth = 120
        Me.txtIdSiniestroAseguradora.Location = New System.Drawing.Point(8, 99)
        Me.txtIdSiniestroAseguradora.MaxLength = 25
        Me.txtIdSiniestroAseguradora.Name = "txtIdSiniestroAseguradora"
        Me.txtIdSiniestroAseguradora.NombreCampo = "IdSiniestroAseguradora"
        Me.txtIdSiniestroAseguradora.Obligatorio = False
        Me.txtIdSiniestroAseguradora.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestroAseguradora.Size = New System.Drawing.Size(262, 20)
        Me.txtIdSiniestroAseguradora.SoloLectura = False
        Me.txtIdSiniestroAseguradora.TabIndex = 2
        Me.txtIdSiniestroAseguradora.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestroAseguradora.Valor = ""
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
        Me.btnImprimir.Location = New System.Drawing.Point(222, 631)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "&Imprimir Reclamo"
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
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(276, 165)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(249, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 7
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = True
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = False
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 120
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(8, 165)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(262, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 6
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtAcumuladoCoaseguro
        '
        Me.txtAcumuladoCoaseguro.CampoBusqueda = False
        Me.txtAcumuladoCoaseguro.CampoEsLlave = False
        Me.txtAcumuladoCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAcumuladoCoaseguro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcumuladoCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtAcumuladoCoaseguro.FechaActual = False
        Me.txtAcumuladoCoaseguro.Formato = "#,###0.00"
        Me.txtAcumuladoCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAcumuladoCoaseguro.LabelText = "Coaseguro Acumulado"
        Me.txtAcumuladoCoaseguro.LabelWidth = 110
        Me.txtAcumuladoCoaseguro.Location = New System.Drawing.Point(533, 271)
        Me.txtAcumuladoCoaseguro.MaxLength = 0
        Me.txtAcumuladoCoaseguro.Name = "txtAcumuladoCoaseguro"
        Me.txtAcumuladoCoaseguro.NombreCampo = "CoaseguroAcumulado"
        Me.txtAcumuladoCoaseguro.Obligatorio = False
        Me.txtAcumuladoCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcumuladoCoaseguro.Size = New System.Drawing.Size(202, 20)
        Me.txtAcumuladoCoaseguro.SoloLectura = True
        Me.txtAcumuladoCoaseguro.TabIndex = 36
        Me.txtAcumuladoCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAcumuladoCoaseguro.Valor = 0
        '
        'txtAcumuladoDeducible
        '
        Me.txtAcumuladoDeducible.CampoBusqueda = False
        Me.txtAcumuladoDeducible.CampoEsLlave = False
        Me.txtAcumuladoDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAcumuladoDeducible.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAcumuladoDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtAcumuladoDeducible.FechaActual = False
        Me.txtAcumuladoDeducible.Formato = "#,###0.00"
        Me.txtAcumuladoDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAcumuladoDeducible.LabelText = "Deducible Acumulado"
        Me.txtAcumuladoDeducible.LabelWidth = 110
        Me.txtAcumuladoDeducible.Location = New System.Drawing.Point(533, 229)
        Me.txtAcumuladoDeducible.MaxLength = 0
        Me.txtAcumuladoDeducible.Name = "txtAcumuladoDeducible"
        Me.txtAcumuladoDeducible.NombreCampo = "DeducibleAcumulado"
        Me.txtAcumuladoDeducible.Obligatorio = False
        Me.txtAcumuladoDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcumuladoDeducible.Size = New System.Drawing.Size(202, 20)
        Me.txtAcumuladoDeducible.SoloLectura = True
        Me.txtAcumuladoDeducible.TabIndex = 34
        Me.txtAcumuladoDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAcumuladoDeducible.Valor = 0
        '
        'txtLimiteCoaseguro
        '
        Me.txtLimiteCoaseguro.CampoBusqueda = False
        Me.txtLimiteCoaseguro.CampoEsLlave = False
        Me.txtLimiteCoaseguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLimiteCoaseguro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimiteCoaseguro.ControlForeColor = System.Drawing.Color.Black
        Me.txtLimiteCoaseguro.FechaActual = False
        Me.txtLimiteCoaseguro.Formato = "#,###0.00"
        Me.txtLimiteCoaseguro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLimiteCoaseguro.LabelText = "Límite Coaseguro"
        Me.txtLimiteCoaseguro.LabelWidth = 110
        Me.txtLimiteCoaseguro.Location = New System.Drawing.Point(533, 250)
        Me.txtLimiteCoaseguro.MaxLength = 0
        Me.txtLimiteCoaseguro.Name = "txtLimiteCoaseguro"
        Me.txtLimiteCoaseguro.NombreCampo = "CoaseguroLimite"
        Me.txtLimiteCoaseguro.Obligatorio = False
        Me.txtLimiteCoaseguro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLimiteCoaseguro.Size = New System.Drawing.Size(202, 20)
        Me.txtLimiteCoaseguro.SoloLectura = True
        Me.txtLimiteCoaseguro.TabIndex = 35
        Me.txtLimiteCoaseguro.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtLimiteCoaseguro.Valor = 0
        '
        'txtLimiteDeducible
        '
        Me.txtLimiteDeducible.CampoBusqueda = False
        Me.txtLimiteDeducible.CampoEsLlave = False
        Me.txtLimiteDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLimiteDeducible.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimiteDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtLimiteDeducible.FechaActual = False
        Me.txtLimiteDeducible.Formato = "#,###0.00"
        Me.txtLimiteDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtLimiteDeducible.LabelText = "Límite Deducible"
        Me.txtLimiteDeducible.LabelWidth = 110
        Me.txtLimiteDeducible.Location = New System.Drawing.Point(533, 208)
        Me.txtLimiteDeducible.MaxLength = 0
        Me.txtLimiteDeducible.Name = "txtLimiteDeducible"
        Me.txtLimiteDeducible.NombreCampo = "DeducibleLimite"
        Me.txtLimiteDeducible.Obligatorio = False
        Me.txtLimiteDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLimiteDeducible.Size = New System.Drawing.Size(202, 20)
        Me.txtLimiteDeducible.SoloLectura = True
        Me.txtLimiteDeducible.TabIndex = 33
        Me.txtLimiteDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtLimiteDeducible.Valor = 0
        '
        'txtFechaActualizacion
        '
        Me.txtFechaActualizacion.CampoBusqueda = False
        Me.txtFechaActualizacion.CampoEsLlave = False
        Me.txtFechaActualizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaActualizacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaActualizacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaActualizacion.FechaActual = False
        Me.txtFechaActualizacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaActualizacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaActualizacion.LabelText = "Fecha Recepción CL/AS"
        Me.txtFechaActualizacion.LabelWidth = 120
        Me.txtFechaActualizacion.Location = New System.Drawing.Point(8, 353)
        Me.txtFechaActualizacion.MaxLength = 0
        Me.txtFechaActualizacion.Name = "txtFechaActualizacion"
        Me.txtFechaActualizacion.NombreCampo = "FechaActualizacion"
        Me.txtFechaActualizacion.Obligatorio = False
        Me.txtFechaActualizacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaActualizacion.Size = New System.Drawing.Size(264, 20)
        Me.txtFechaActualizacion.SoloLectura = False
        Me.txtFechaActualizacion.TabIndex = 18
        Me.txtFechaActualizacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaActualizacion.Valor = Nothing
        '
        'txtEstadoUsuario
        '
        Me.txtEstadoUsuario.CampoBusqueda = False
        Me.txtEstadoUsuario.CampoEsLlave = False
        Me.txtEstadoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEstadoUsuario.ControlBackColor = System.Drawing.Color.White
        Me.txtEstadoUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.txtEstadoUsuario.FechaActual = False
        Me.txtEstadoUsuario.Formato = ""
        Me.txtEstadoUsuario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEstadoUsuario.LabelText = "Comentario Estado"
        Me.txtEstadoUsuario.LabelWidth = 110
        Me.txtEstadoUsuario.Location = New System.Drawing.Point(276, 353)
        Me.txtEstadoUsuario.MaxLength = 0
        Me.txtEstadoUsuario.Name = "txtEstadoUsuario"
        Me.txtEstadoUsuario.NombreCampo = "EstadoUsuario"
        Me.txtEstadoUsuario.Obligatorio = False
        Me.txtEstadoUsuario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstadoUsuario.Size = New System.Drawing.Size(247, 20)
        Me.txtEstadoUsuario.SoloLectura = False
        Me.txtEstadoUsuario.TabIndex = 19
        Me.txtEstadoUsuario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEstadoUsuario.Valor = ""
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
        Me.cboEjecutivoCta.FilasVisibles = 23925379
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 120
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(7, 374)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(265, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 20
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'cboEstadoSiniestroInterno
        '
        Me.cboEstadoSiniestroInterno.CampoAutoCompletar = 0
        Me.cboEstadoSiniestroInterno.CampoBusqueda = True
        Me.cboEstadoSiniestroInterno.CampoDisplay = 1
        Me.cboEstadoSiniestroInterno.CampoEsLlave = False
        Me.cboEstadoSiniestroInterno.CampoValor = 0
        Me.cboEstadoSiniestroInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoSiniestroInterno.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoSiniestroInterno.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoSiniestroInterno.FilasVisibles = 23925379
        Me.cboEstadoSiniestroInterno.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoSiniestroInterno.LabelText = "Estado Reclamo Interno"
        Me.cboEstadoSiniestroInterno.LabelWidth = 120
        Me.cboEstadoSiniestroInterno.Lista = "DECLARADO Declarado|PENDIENTE Pendiente|RECHAZADO Rechazado|RETIRADO Retirado|PAG" & _
            "ADO Pagado|ABDEDU Abonado a Deducible|BAJDED Bajo Deducible|RECONSIDERACION Reco" & _
            "nsideración"
        Me.cboEstadoSiniestroInterno.Location = New System.Drawing.Point(7, 397)
        Me.cboEstadoSiniestroInterno.MostrarBusquedaColumnas = False
        Me.cboEstadoSiniestroInterno.Name = "cboEstadoSiniestroInterno"
        Me.cboEstadoSiniestroInterno.NombreCampo = "EstadoSiniestroInterno"
        Me.cboEstadoSiniestroInterno.Obligatorio = False
        Me.cboEstadoSiniestroInterno.Query = ""
        Me.cboEstadoSiniestroInterno.SelectIndex = 0
        Me.cboEstadoSiniestroInterno.Size = New System.Drawing.Size(265, 20)
        Me.cboEstadoSiniestroInterno.SoloLectura = False
        Me.cboEstadoSiniestroInterno.StringConection = ""
        Me.cboEstadoSiniestroInterno.TabIndex = 22
        Me.cboEstadoSiniestroInterno.TextoNuevoItem = ""
        Me.cboEstadoSiniestroInterno.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoSiniestroInterno.Valor = ""
        '
        'txtFlujo
        '
        Me.txtFlujo.CampoBusqueda = False
        Me.txtFlujo.CampoEsLlave = False
        Me.txtFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFlujo.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.txtFlujo.FechaActual = False
        Me.txtFlujo.Formato = ""
        Me.txtFlujo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFlujo.LabelText = "Flujo Asociado"
        Me.txtFlujo.LabelWidth = 110
        Me.txtFlujo.Location = New System.Drawing.Point(533, 353)
        Me.txtFlujo.MaxLength = 25
        Me.txtFlujo.Name = "txtFlujo"
        Me.txtFlujo.NombreCampo = ""
        Me.txtFlujo.Obligatorio = False
        Me.txtFlujo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFlujo.Size = New System.Drawing.Size(202, 20)
        Me.txtFlujo.SoloLectura = True
        Me.txtFlujo.TabIndex = 21
        Me.txtFlujo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtFlujo.Valor = ""
        '
        'cboTipoSiniestro
        '
        Me.cboTipoSiniestro.CampoAutoCompletar = 0
        Me.cboTipoSiniestro.CampoBusqueda = True
        Me.cboTipoSiniestro.CampoDisplay = 1
        Me.cboTipoSiniestro.CampoEsLlave = False
        Me.cboTipoSiniestro.CampoValor = 0
        Me.cboTipoSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoSiniestro.FilasVisibles = 23925379
        Me.cboTipoSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoSiniestro.LabelText = "Tipo Siniestro"
        Me.cboTipoSiniestro.LabelWidth = 70
        Me.cboTipoSiniestro.Lista = ""
        Me.cboTipoSiniestro.Location = New System.Drawing.Point(533, 377)
        Me.cboTipoSiniestro.MostrarBusquedaColumnas = False
        Me.cboTipoSiniestro.Name = "cboTipoSiniestro"
        Me.cboTipoSiniestro.NombreCampo = "TipoSiniestro"
        Me.cboTipoSiniestro.Obligatorio = False
        Me.cboTipoSiniestro.Query = ""
        Me.cboTipoSiniestro.SelectIndex = 0
        Me.cboTipoSiniestro.Size = New System.Drawing.Size(202, 20)
        Me.cboTipoSiniestro.SoloLectura = False
        Me.cboTipoSiniestro.StringConection = ""
        Me.cboTipoSiniestro.TabIndex = 24
        Me.cboTipoSiniestro.TextoNuevoItem = ""
        Me.cboTipoSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoSiniestro.Valor = ""
        '
        'cboAmbitoSiniestro
        '
        Me.cboAmbitoSiniestro.CampoAutoCompletar = 0
        Me.cboAmbitoSiniestro.CampoBusqueda = True
        Me.cboAmbitoSiniestro.CampoDisplay = 1
        Me.cboAmbitoSiniestro.CampoEsLlave = False
        Me.cboAmbitoSiniestro.CampoValor = 0
        Me.cboAmbitoSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAmbitoSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboAmbitoSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboAmbitoSiniestro.FilasVisibles = 23925379
        Me.cboAmbitoSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAmbitoSiniestro.LabelText = "Ambito Siniestro"
        Me.cboAmbitoSiniestro.LabelWidth = 80
        Me.cboAmbitoSiniestro.Lista = ""
        Me.cboAmbitoSiniestro.Location = New System.Drawing.Point(278, 397)
        Me.cboAmbitoSiniestro.MostrarBusquedaColumnas = False
        Me.cboAmbitoSiniestro.Name = "cboAmbitoSiniestro"
        Me.cboAmbitoSiniestro.NombreCampo = "AmbitoSiniestro"
        Me.cboAmbitoSiniestro.Obligatorio = False
        Me.cboAmbitoSiniestro.Query = ""
        Me.cboAmbitoSiniestro.SelectIndex = 0
        Me.cboAmbitoSiniestro.Size = New System.Drawing.Size(245, 20)
        Me.cboAmbitoSiniestro.SoloLectura = False
        Me.cboAmbitoSiniestro.StringConection = ""
        Me.cboAmbitoSiniestro.TabIndex = 23
        Me.cboAmbitoSiniestro.TextoNuevoItem = ""
        Me.cboAmbitoSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAmbitoSiniestro.Valor = ""
        '
        'txtDescripcionLiquidacion
        '
        Me.txtDescripcionLiquidacion.CampoBusqueda = False
        Me.txtDescripcionLiquidacion.CampoEsLlave = False
        Me.txtDescripcionLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionLiquidacion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionLiquidacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionLiquidacion.FechaActual = False
        Me.txtDescripcionLiquidacion.Formato = ""
        Me.txtDescripcionLiquidacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDescripcionLiquidacion.LabelText = "Observacion Liquidación"
        Me.txtDescripcionLiquidacion.LabelWidth = 120
        Me.txtDescripcionLiquidacion.Location = New System.Drawing.Point(276, 293)
        Me.txtDescripcionLiquidacion.MaxLength = 0
        Me.txtDescripcionLiquidacion.Name = "txtDescripcionLiquidacion"
        Me.txtDescripcionLiquidacion.NombreCampo = "DescripcionLiquidacion"
        Me.txtDescripcionLiquidacion.Obligatorio = False
        Me.txtDescripcionLiquidacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionLiquidacion.Size = New System.Drawing.Size(249, 36)
        Me.txtDescripcionLiquidacion.SoloLectura = False
        Me.txtDescripcionLiquidacion.TabIndex = 14
        Me.txtDescripcionLiquidacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionLiquidacion.Valor = ""
        '
        'txtTitularCertificado
        '
        Me.txtTitularCertificado.CampoBusqueda = True
        Me.txtTitularCertificado.CampoEsLlave = False
        Me.txtTitularCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTitularCertificado.ControlBackColor = System.Drawing.Color.White
        Me.txtTitularCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtTitularCertificado.FechaActual = False
        Me.txtTitularCertificado.Formato = ""
        Me.txtTitularCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTitularCertificado.LabelText = "Titular Certificado"
        Me.txtTitularCertificado.LabelWidth = 120
        Me.txtTitularCertificado.Location = New System.Drawing.Point(8, 186)
        Me.txtTitularCertificado.MaxLength = 150
        Me.txtTitularCertificado.Name = "txtTitularCertificado"
        Me.txtTitularCertificado.NombreCampo = ""
        Me.txtTitularCertificado.Obligatorio = True
        Me.txtTitularCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitularCertificado.Size = New System.Drawing.Size(519, 20)
        Me.txtTitularCertificado.SoloLectura = False
        Me.txtTitularCertificado.TabIndex = 7
        Me.txtTitularCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTitularCertificado.Valor = ""
        '
        'btnGenerarEnvio
        '
        Me.btnGenerarEnvio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarEnvio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGenerarEnvio.Appearance.Options.UseFont = True
        Me.btnGenerarEnvio.Appearance.Options.UseTextOptions = True
        Me.btnGenerarEnvio.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.btnGenerarEnvio.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGenerarEnvio.Image = CType(resources.GetObject("btnGenerarEnvio.Image"), System.Drawing.Image)
        Me.btnGenerarEnvio.Location = New System.Drawing.Point(325, 631)
        Me.btnGenerarEnvio.Name = "btnGenerarEnvio"
        Me.btnGenerarEnvio.Size = New System.Drawing.Size(96, 36)
        Me.btnGenerarEnvio.TabIndex = 39
        Me.btnGenerarEnvio.Text = "&Generar Envío"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.CampoBusqueda = False
        Me.txtDiagnostico.CampoEsLlave = False
        Me.txtDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDiagnostico.ControlBackColor = System.Drawing.Color.White
        Me.txtDiagnostico.ControlForeColor = System.Drawing.Color.Black
        Me.txtDiagnostico.FechaActual = False
        Me.txtDiagnostico.Formato = ""
        Me.txtDiagnostico.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDiagnostico.LabelText = "Diagnostico"
        Me.txtDiagnostico.LabelWidth = 120
        Me.txtDiagnostico.Location = New System.Drawing.Point(533, 293)
        Me.txtDiagnostico.MaxLength = 500
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.NombreCampo = "Diagnostico"
        Me.txtDiagnostico.Obligatorio = False
        Me.txtDiagnostico.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiagnostico.Size = New System.Drawing.Size(203, 36)
        Me.txtDiagnostico.SoloLectura = False
        Me.txtDiagnostico.TabIndex = 40
        Me.txtDiagnostico.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDiagnostico.Valor = ""
        '
        'btnBuscarDiagnostico
        '
        Me.btnBuscarDiagnostico.Location = New System.Drawing.Point(676, 291)
        Me.btnBuscarDiagnostico.Name = "btnBuscarDiagnostico"
        Me.btnBuscarDiagnostico.Size = New System.Drawing.Size(60, 18)
        Me.btnBuscarDiagnostico.TabIndex = 3
        Me.btnBuscarDiagnostico.Text = "Buscar"
        '
        'cboNombreTaller
        '
        Me.cboNombreTaller.CampoAutoCompletar = 0
        Me.cboNombreTaller.CampoBusqueda = True
        Me.cboNombreTaller.CampoDisplay = 1
        Me.cboNombreTaller.CampoEsLlave = False
        Me.cboNombreTaller.CampoValor = 0
        Me.cboNombreTaller.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNombreTaller.ControlBackColor = System.Drawing.Color.White
        Me.cboNombreTaller.ControlForeColor = System.Drawing.Color.Black
        Me.cboNombreTaller.FilasVisibles = 38280606
        Me.cboNombreTaller.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboNombreTaller.LabelText = "Taller"
        Me.cboNombreTaller.LabelWidth = 35
        Me.cboNombreTaller.Lista = ""
        Me.cboNombreTaller.Location = New System.Drawing.Point(7, 421)
        Me.cboNombreTaller.MostrarBusquedaColumnas = False
        Me.cboNombreTaller.Name = "cboNombreTaller"
        Me.cboNombreTaller.NombreCampo = "NombreTaller"
        Me.cboNombreTaller.Obligatorio = False
        Me.cboNombreTaller.Query = ""
        Me.cboNombreTaller.SelectIndex = 0
        Me.cboNombreTaller.Size = New System.Drawing.Size(204, 20)
        Me.cboNombreTaller.SoloLectura = False
        Me.cboNombreTaller.StringConection = ""
        Me.cboNombreTaller.TabIndex = 41
        Me.cboNombreTaller.TextoNuevoItem = ""
        Me.cboNombreTaller.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNombreTaller.Valor = ""
        '
        'cboNombreCobAfecta
        '
        Me.cboNombreCobAfecta.CampoAutoCompletar = 0
        Me.cboNombreCobAfecta.CampoBusqueda = True
        Me.cboNombreCobAfecta.CampoDisplay = 1
        Me.cboNombreCobAfecta.CampoEsLlave = False
        Me.cboNombreCobAfecta.CampoValor = 0
        Me.cboNombreCobAfecta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboNombreCobAfecta.ControlBackColor = System.Drawing.Color.White
        Me.cboNombreCobAfecta.ControlForeColor = System.Drawing.Color.Black
        Me.cboNombreCobAfecta.FilasVisibles = 38280606
        Me.cboNombreCobAfecta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboNombreCobAfecta.LabelText = "Cobertura Afectada"
        Me.cboNombreCobAfecta.LabelWidth = 105
        Me.cboNombreCobAfecta.Lista = ""
        Me.cboNombreCobAfecta.Location = New System.Drawing.Point(392, 423)
        Me.cboNombreCobAfecta.MostrarBusquedaColumnas = False
        Me.cboNombreCobAfecta.Name = "cboNombreCobAfecta"
        Me.cboNombreCobAfecta.NombreCampo = "NombreCobAfecta"
        Me.cboNombreCobAfecta.Obligatorio = False
        Me.cboNombreCobAfecta.Query = "select replace(cast(Descripcion as varchar(max)),' ','_') as Id, Descripcion from" & _
            " ProductosCoberturas where IdProducto = 'A-ACSA'"
        Me.cboNombreCobAfecta.SelectIndex = 0
        Me.cboNombreCobAfecta.Size = New System.Drawing.Size(342, 20)
        Me.cboNombreCobAfecta.SoloLectura = False
        Me.cboNombreCobAfecta.StringConection = ""
        Me.cboNombreCobAfecta.TabIndex = 42
        Me.cboNombreCobAfecta.TextoNuevoItem = ""
        Me.cboNombreCobAfecta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboNombreCobAfecta.Valor = ""
        '
        'txtNombreConductor
        '
        Me.txtNombreConductor.CampoBusqueda = False
        Me.txtNombreConductor.CampoEsLlave = False
        Me.txtNombreConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreConductor.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreConductor.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreConductor.FechaActual = False
        Me.txtNombreConductor.Formato = ""
        Me.txtNombreConductor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreConductor.LabelText = "Conductor"
        Me.txtNombreConductor.LabelWidth = 55
        Me.txtNombreConductor.Location = New System.Drawing.Point(217, 421)
        Me.txtNombreConductor.MaxLength = 250
        Me.txtNombreConductor.Name = "txtNombreConductor"
        Me.txtNombreConductor.NombreCampo = "NombreConductor"
        Me.txtNombreConductor.Obligatorio = False
        Me.txtNombreConductor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreConductor.Size = New System.Drawing.Size(169, 20)
        Me.txtNombreConductor.SoloLectura = False
        Me.txtNombreConductor.TabIndex = 43
        Me.txtNombreConductor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreConductor.Valor = ""
        '
        'txtNoFolioReferencia
        '
        Me.txtNoFolioReferencia.CampoBusqueda = True
        Me.txtNoFolioReferencia.CampoEsLlave = False
        Me.txtNoFolioReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNoFolioReferencia.ControlBackColor = System.Drawing.Color.White
        Me.txtNoFolioReferencia.ControlForeColor = System.Drawing.Color.Black
        Me.txtNoFolioReferencia.FechaActual = False
        Me.txtNoFolioReferencia.Formato = ""
        Me.txtNoFolioReferencia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNoFolioReferencia.LabelText = "No.Oficio/Carta Ref."
        Me.txtNoFolioReferencia.LabelWidth = 110
        Me.txtNoFolioReferencia.Location = New System.Drawing.Point(276, 375)
        Me.txtNoFolioReferencia.MaxLength = 50
        Me.txtNoFolioReferencia.Name = "txtNoFolioReferencia"
        Me.txtNoFolioReferencia.NombreCampo = "NoFolioReferencia"
        Me.txtNoFolioReferencia.Obligatorio = False
        Me.txtNoFolioReferencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoFolioReferencia.Size = New System.Drawing.Size(247, 20)
        Me.txtNoFolioReferencia.SoloLectura = False
        Me.txtNoFolioReferencia.TabIndex = 47
        Me.txtNoFolioReferencia.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNoFolioReferencia.Valor = ""
        '
        'cboClaseSiniestro
        '
        Me.cboClaseSiniestro.CampoAutoCompletar = 0
        Me.cboClaseSiniestro.CampoBusqueda = True
        Me.cboClaseSiniestro.CampoDisplay = 1
        Me.cboClaseSiniestro.CampoEsLlave = False
        Me.cboClaseSiniestro.CampoValor = 0
        Me.cboClaseSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboClaseSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboClaseSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboClaseSiniestro.FilasVisibles = 38280606
        Me.cboClaseSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboClaseSiniestro.LabelText = "Clase Siniestro"
        Me.cboClaseSiniestro.LabelWidth = 70
        Me.cboClaseSiniestro.Lista = ""
        Me.cboClaseSiniestro.Location = New System.Drawing.Point(533, 400)
        Me.cboClaseSiniestro.MostrarBusquedaColumnas = False
        Me.cboClaseSiniestro.Name = "cboClaseSiniestro"
        Me.cboClaseSiniestro.NombreCampo = "ClaseSiniestro"
        Me.cboClaseSiniestro.Obligatorio = False
        Me.cboClaseSiniestro.Query = ""
        Me.cboClaseSiniestro.SelectIndex = 0
        Me.cboClaseSiniestro.Size = New System.Drawing.Size(202, 20)
        Me.cboClaseSiniestro.SoloLectura = False
        Me.cboClaseSiniestro.StringConection = ""
        Me.cboClaseSiniestro.TabIndex = 48
        Me.cboClaseSiniestro.TextoNuevoItem = ""
        Me.cboClaseSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboClaseSiniestro.Valor = ""
        '
        'SiniestrosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 805
        Me.ClientSize = New System.Drawing.Size(777, 667)
        Me.Controls.Add(Me.cboClaseSiniestro)
        Me.Controls.Add(Me.txtNoFolioReferencia)
        Me.Controls.Add(Me.txtNombreConductor)
        Me.Controls.Add(Me.cboNombreCobAfecta)
        Me.Controls.Add(Me.cboNombreTaller)
        Me.Controls.Add(Me.btnBuscarDiagnostico)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.btnGenerarEnvio)
        Me.Controls.Add(Me.txtTitularCertificado)
        Me.Controls.Add(Me.txtDescripcionLiquidacion)
        Me.Controls.Add(Me.cboAmbitoSiniestro)
        Me.Controls.Add(Me.cboTipoSiniestro)
        Me.Controls.Add(Me.txtFlujo)
        Me.Controls.Add(Me.cboEstadoSiniestroInterno)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.txtEstadoUsuario)
        Me.Controls.Add(Me.txtFechaActualizacion)
        Me.Controls.Add(Me.txtAcumuladoCoaseguro)
        Me.Controls.Add(Me.txtAcumuladoDeducible)
        Me.Controls.Add(Me.txtLimiteCoaseguro)
        Me.Controls.Add(Me.txtLimiteDeducible)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtIdSiniestroAseguradora)
        Me.Controls.Add(Me.txtIdEnvio)
        Me.Controls.Add(Me.txtIdBien)
        Me.Controls.Add(Me.btnBuscaCertificado)
        Me.Controls.Add(Me.txtTotalPendiente)
        Me.Controls.Add(Me.TabSiniestros)
        Me.Controls.Add(Me.txtTotalReembolso)
        Me.Controls.Add(Me.txtTotalCubierto)
        Me.Controls.Add(Me.txtTotalNoCubierto)
        Me.Controls.Add(Me.txtTotalPresentado)
        Me.Controls.Add(Me.txtDescripcionSiniestro)
        Me.Controls.Add(Me.txtTotalDeudores)
        Me.Controls.Add(Me.txtTotalCoaseguro)
        Me.Controls.Add(Me.txtFechaPresentado)
        Me.Controls.Add(Me.txtFechaOcurrido)
        Me.Controls.Add(Me.txtLugarSiniestros)
        Me.Controls.Add(Me.txtNombrePresentaReclamo)
        Me.Controls.Add(Me.cboEstadoSiniestro)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtTotalDeducible)
        Me.Controls.Add(Me.txtDescripcionReserva)
        Me.Controls.Add(Me.txtIdSiniestro)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "SiniestrosMan"
        Me.SeguirAlGrabarActualizar = True
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Siniestros"
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionReserva, 0)
        Me.Controls.SetChildIndex(Me.txtTotalDeducible, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtNombrePresentaReclamo, 0)
        Me.Controls.SetChildIndex(Me.txtLugarSiniestros, 0)
        Me.Controls.SetChildIndex(Me.txtFechaOcurrido, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPresentado, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCoaseguro, 0)
        Me.Controls.SetChildIndex(Me.txtTotalDeudores, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtTotalPresentado, 0)
        Me.Controls.SetChildIndex(Me.txtTotalNoCubierto, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCubierto, 0)
        Me.Controls.SetChildIndex(Me.txtTotalReembolso, 0)
        Me.Controls.SetChildIndex(Me.TabSiniestros, 0)
        Me.Controls.SetChildIndex(Me.txtTotalPendiente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdBien, 0)
        Me.Controls.SetChildIndex(Me.txtIdEnvio, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestroAseguradora, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.txtLimiteDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtLimiteCoaseguro, 0)
        Me.Controls.SetChildIndex(Me.txtAcumuladoDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtAcumuladoCoaseguro, 0)
        Me.Controls.SetChildIndex(Me.txtFechaActualizacion, 0)
        Me.Controls.SetChildIndex(Me.txtEstadoUsuario, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoSiniestroInterno, 0)
        Me.Controls.SetChildIndex(Me.txtFlujo, 0)
        Me.Controls.SetChildIndex(Me.cboTipoSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboAmbitoSiniestro, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionLiquidacion, 0)
        Me.Controls.SetChildIndex(Me.txtTitularCertificado, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarEnvio, 0)
        Me.Controls.SetChildIndex(Me.txtDiagnostico, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarDiagnostico, 0)
        Me.Controls.SetChildIndex(Me.cboNombreTaller, 0)
        Me.Controls.SetChildIndex(Me.cboNombreCobAfecta, 0)
        Me.Controls.SetChildIndex(Me.txtNombreConductor, 0)
        Me.Controls.SetChildIndex(Me.txtNoFolioReferencia, 0)
        Me.Controls.SetChildIndex(Me.cboClaseSiniestro, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSiniestros.ResumeLayout(False)
        Me.Detalle.ResumeLayout(False)
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVistaDetalleComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Informacion.ResumeLayout(False)
        CType(Me.GridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reserva.ResumeLayout(False)
        CType(Me.GridReserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaReserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoCobertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pagos.ResumeLayout(False)
        CType(Me.GridPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoCobPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Deudores.ResumeLayout(False)
        CType(Me.GridDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Requisitos.ResumeLayout(False)
        CType(Me.GridRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Archivos.ResumeLayout(False)
        CType(Me.GridArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bienes.ResumeLayout(False)
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Coberturas.ResumeLayout(False)
        CType(Me.GridCoberturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaCoberturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gestiones.ResumeLayout(False)
        CType(Me.GridGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fechas.ResumeLayout(False)
        CType(Me.lytFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lytFechas.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtDescripcionReserva As STIControles.stiTextBox
    Friend WithEvents txtTotalDeducible As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboEstadoSiniestro As STIControles.stiComboBox
    Friend WithEvents txtLugarSiniestros As STIControles.stiTextBox
    Friend WithEvents txtNombrePresentaReclamo As STIControles.stiTextBox
    Friend WithEvents txtFechaPresentado As STIControles.stiTextBox
    Friend WithEvents txtFechaOcurrido As STIControles.stiTextBox
    Friend WithEvents txtDescripcionSiniestro As STIControles.stiTextBox
    Friend WithEvents txtTotalDeudores As STIControles.stiTextBox
    Friend WithEvents txtTotalCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtTotalCubierto As STIControles.stiTextBox
    Friend WithEvents txtTotalNoCubierto As STIControles.stiTextBox
    Friend WithEvents txtTotalPresentado As STIControles.stiTextBox
    Friend WithEvents txtTotalReembolso As STIControles.stiTextBox
    Friend WithEvents TabSiniestros As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Requisitos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Reserva As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Pagos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Detalle As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Informacion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Archivos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridRequisitos As STIControles.stiGrid
    Friend WithEvents VistaRequisitos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridReserva As STIControles.stiGrid
    Friend WithEvents VistaReserva As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridInfo As STIControles.stiGrid
    Friend WithEvents VistaInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridArchivos As STIControles.stiGrid
    Friend WithEvents VistaArchivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colArcIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcIdDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArcDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResIdCobertura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResFechaReserva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResValorAsegurado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResValorReserva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridPagos As STIControles.stiGrid
    Friend WithEvents VistaPagos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridDetalle As STIControles.stiGrid
    Friend WithEvents VistaDetalles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetDescripcionGastos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetValorPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetValorNoCubierto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetValorCubierto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPagIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPagIdPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagFechaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagNombreCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagNumeroCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPagValorGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPagValorDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColArcValorRenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPagValorIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagValorRetencionIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagValorReembolso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqIdRequisito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqFechaPresentado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregarCarpeta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarDoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnQuitarRequisito As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarRequisito As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarReserva As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarReserva As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitarGastos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGasto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalPendiente As STIControles.stiTextBox
    Friend WithEvents btnBuscaCertificado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnQuitarInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colInfoIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfoIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfoIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfoIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfoIdInformacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfoDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfoDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtIdBien As STIControles.stiTextBox
    Friend WithEvents txtIdEnvio As STIControles.stiTextBox
    Friend WithEvents txtIdSiniestroAseguradora As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents Bienes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridBienes As STIControles.stiGrid
    Friend WithEvents VistaBienes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbiIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiIdBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbiNombreBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colbiDescripcionBien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Coberturas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCoberturas As STIControles.stiGrid
    Friend WithEvents VistaCoberturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCobertura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorceSuma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeducible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Deudores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnQuitarDeudor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarDeudor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDeudores As STIControles.stiGrid
    Friend WithEvents VistaDeudores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDedIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDedIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldedIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDedIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDedIdDeudor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDedFechaDeudor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDedDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDedValorDeudor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtAcumuladoCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtAcumuladoDeducible As STIControles.stiTextBox
    Friend WithEvents txtLimiteCoaseguro As STIControles.stiTextBox
    Friend WithEvents txtLimiteDeducible As STIControles.stiTextBox
    Friend WithEvents btnCargarRequisitos As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnEditarCertificado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Gestiones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridGestiones As STIControles.stiGrid
    Friend WithEvents VistaGestiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGesIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdSiniestro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesIdGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesTipoGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesFechaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarGestion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGestion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colGesIdUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGesFechaProximaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGestionOutlook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaActualizacion As STIControles.stiTextBox
    Friend WithEvents txtEstadoUsuario As STIControles.stiTextBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents cboEstadoSiniestroInterno As STIControles.stiComboBox
    Friend WithEvents txtFlujo As STIControles.stiTextBox
    Friend WithEvents cboTipoSiniestro As STIControles.stiComboBox
    Friend WithEvents cboAmbitoSiniestro As STIControles.stiComboBox
    Friend WithEvents txtDescripcionLiquidacion As STIControles.stiTextBox
    Friend WithEvents txtTitularCertificado As STIControles.stiTextBox
    Public WithEvents btnGenerarEnvio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDiagnostico As STIControles.stiTextBox
    Friend WithEvents btnBuscarDiagnostico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtVistaDetalleComentarios As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fechas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lytFechas As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtFechaAvisoCliente As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFechaAsegEntregaCheque As STIControles.stiTextBox
    Friend WithEvents txtFechaFirmaConvAjuste As STIControles.stiTextBox
    Friend WithEvents txtFechaRecibeConvAjuste As STIControles.stiTextBox
    Friend WithEvents txtFechaCienteEntregaDocs As STIControles.stiTextBox
    Friend WithEvents txtFechaInspeccion As STIControles.stiTextBox
    Friend WithEvents txtFechaAvisoAseguradora As STIControles.stiTextBox
    Friend WithEvents txtFechaAjustadorReqDocs As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvioClientreConvAju As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvioConvAseg As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvioDocAseg As STIControles.stiTextBox
    Friend WithEvents txtFechaSolicitaInspeccion As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFechaFinalReclamo As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvioFiniquitoAseg As STIControles.stiTextBox
    Friend WithEvents txtFechaEntregaFiniquito As STIControles.stiTextBox
    Friend WithEvents txtFechaEntregaCheque As STIControles.stiTextBox
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboNombreTaller As STIControles.stiComboBox
    Friend WithEvents cboNombreCobAfecta As STIControles.stiComboBox
    Friend WithEvents txtNombreConductor As STIControles.stiTextBox
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboPendientePor As STIControles.stiComboBox
    Friend WithEvents ColDetIdEnvio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetFechaEnvio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNoFolioReferencia As STIControles.stiTextBox
    Friend WithEvents cboClaseSiniestro As STIControles.stiComboBox
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboGrupoCobertura As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboGrupoCobPago As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

End Class
