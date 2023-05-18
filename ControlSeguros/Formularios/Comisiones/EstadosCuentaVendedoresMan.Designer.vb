<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadosCuentaVendedoresMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadosCuentaVendedoresMan))
        Me.btnBuscarComi = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdEstadoCuenta = New STIControles.stiTextBox
        Me.cboEstatus = New STIControles.stiComboBox
        Me.cboVendedores = New STIControles.stiComboBox
        Me.txtFechaCorte = New STIControles.stiTextBox
        Me.GridComisiones = New STIControles.stiGrid
        Me.VistaComisiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumeroFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdMovimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIncluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ColIdRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColFechaVence = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPorceComi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColComision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorceVen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColComiVend = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnAplicarEstadoCuenta = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotal = New STIControles.stiTextBox
        Me.txtMotivoDescuento = New STIControles.stiTextBox
        Me.txtValorDescuento = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(639, 435)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(455, 435)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(268, 435)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(360, 435)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(731, 435)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(547, 435)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(686, 74)
        Me.lblNombreFormulario.Text = "Estados de Cuenta Comisiones Vendedores"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(230, 435)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscarComi
        '
        Me.btnBuscarComi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarComi.Appearance.Options.UseFont = True
        Me.btnBuscarComi.Appearance.Options.UseTextOptions = True
        Me.btnBuscarComi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnBuscarComi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarComi.Image = CType(resources.GetObject("btnBuscarComi.Image"), System.Drawing.Image)
        Me.btnBuscarComi.Location = New System.Drawing.Point(449, 106)
        Me.btnBuscarComi.Name = "btnBuscarComi"
        Me.btnBuscarComi.Size = New System.Drawing.Size(120, 43)
        Me.btnBuscarComi.TabIndex = 33
        Me.btnBuscarComi.Text = "Buscar Comisiones"
        '
        'txtIdEstadoCuenta
        '
        Me.txtIdEstadoCuenta.CampoBusqueda = True
        Me.txtIdEstadoCuenta.CampoEsLlave = True
        Me.txtIdEstadoCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdEstadoCuenta.ControlBackColor = System.Drawing.Color.White
        Me.txtIdEstadoCuenta.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdEstadoCuenta.FechaActual = False
        Me.txtIdEstadoCuenta.Formato = "###0"
        Me.txtIdEstadoCuenta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdEstadoCuenta.LabelText = "Cod. Estado Cuenta"
        Me.txtIdEstadoCuenta.LabelWidth = 115
        Me.txtIdEstadoCuenta.Location = New System.Drawing.Point(12, 81)
        Me.txtIdEstadoCuenta.MaxLength = 0
        Me.txtIdEstadoCuenta.Name = "txtIdEstadoCuenta"
        Me.txtIdEstadoCuenta.NombreCampo = "IdEstadoCuenta"
        Me.txtIdEstadoCuenta.Obligatorio = True
        Me.txtIdEstadoCuenta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdEstadoCuenta.Size = New System.Drawing.Size(300, 20)
        Me.txtIdEstadoCuenta.SoloLectura = False
        Me.txtIdEstadoCuenta.TabIndex = 32
        Me.txtIdEstadoCuenta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdEstadoCuenta.Valor = 0
        '
        'cboEstatus
        '
        Me.cboEstatus.CampoAutoCompletar = 0
        Me.cboEstatus.CampoBusqueda = True
        Me.cboEstatus.CampoDisplay = 1
        Me.cboEstatus.CampoEsLlave = False
        Me.cboEstatus.CampoValor = 0
        Me.cboEstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstatus.ControlBackColor = System.Drawing.Color.White
        Me.cboEstatus.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstatus.FilasVisibles = 46
        Me.cboEstatus.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstatus.LabelText = "Estatus"
        Me.cboEstatus.LabelWidth = 115
        Me.cboEstatus.Lista = "P Estado de Cuenta Pendiente|A Estado de Cuenta Aplicado"
        Me.cboEstatus.Location = New System.Drawing.Point(12, 130)
        Me.cboEstatus.MostrarBusquedaColumnas = False
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.NombreCampo = "Estatus"
        Me.cboEstatus.Obligatorio = False
        Me.cboEstatus.Query = ""
        Me.cboEstatus.SelectIndex = 0
        Me.cboEstatus.Size = New System.Drawing.Size(431, 20)
        Me.cboEstatus.SoloLectura = False
        Me.cboEstatus.StringConection = ""
        Me.cboEstatus.TabIndex = 31
        Me.cboEstatus.TextoNuevoItem = ""
        Me.cboEstatus.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstatus.Valor = ""
        '
        'cboVendedores
        '
        Me.cboVendedores.CampoAutoCompletar = 0
        Me.cboVendedores.CampoBusqueda = False
        Me.cboVendedores.CampoDisplay = 1
        Me.cboVendedores.CampoEsLlave = False
        Me.cboVendedores.CampoValor = 0
        Me.cboVendedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboVendedores.ControlBackColor = System.Drawing.Color.White
        Me.cboVendedores.ControlForeColor = System.Drawing.Color.Black
        Me.cboVendedores.FilasVisibles = 46
        Me.cboVendedores.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboVendedores.LabelText = "Vendedor"
        Me.cboVendedores.LabelWidth = 115
        Me.cboVendedores.Lista = ""
        Me.cboVendedores.Location = New System.Drawing.Point(318, 81)
        Me.cboVendedores.MostrarBusquedaColumnas = False
        Me.cboVendedores.Name = "cboVendedores"
        Me.cboVendedores.NombreCampo = "IdVendedor"
        Me.cboVendedores.Obligatorio = False
        Me.cboVendedores.Query = "select IdVendedor as Id, NombreVendedor as Vendedor from Vendedores order by Nomb" & _
            "reVendedor"
        Me.cboVendedores.SelectIndex = 0
        Me.cboVendedores.Size = New System.Drawing.Size(431, 20)
        Me.cboVendedores.SoloLectura = False
        Me.cboVendedores.StringConection = ""
        Me.cboVendedores.TabIndex = 29
        Me.cboVendedores.TextoNuevoItem = ""
        Me.cboVendedores.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboVendedores.Valor = ""
        '
        'txtFechaCorte
        '
        Me.txtFechaCorte.CampoBusqueda = True
        Me.txtFechaCorte.CampoEsLlave = False
        Me.txtFechaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCorte.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCorte.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCorte.FechaActual = False
        Me.txtFechaCorte.Formato = "Long Date"
        Me.txtFechaCorte.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCorte.LabelText = "Fecha de Corte"
        Me.txtFechaCorte.LabelWidth = 115
        Me.txtFechaCorte.Location = New System.Drawing.Point(12, 107)
        Me.txtFechaCorte.MaxLength = 0
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.NombreCampo = "FechaCorte"
        Me.txtFechaCorte.Obligatorio = False
        Me.txtFechaCorte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCorte.Size = New System.Drawing.Size(431, 20)
        Me.txtFechaCorte.SoloLectura = False
        Me.txtFechaCorte.TabIndex = 30
        Me.txtFechaCorte.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCorte.Valor = Nothing
        '
        'GridComisiones
        '
        Me.GridComisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridComisiones.ColumnasAdicionales = ""
        Me.GridComisiones.Location = New System.Drawing.Point(6, 156)
        Me.GridComisiones.MainView = Me.VistaComisiones
        Me.GridComisiones.Name = "GridComisiones"
        Me.GridComisiones.NombreTabla = ""
        Me.GridComisiones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridComisiones.Size = New System.Drawing.Size(811, 210)
        Me.GridComisiones.TabIndex = 34
        Me.GridComisiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaComisiones})
        '
        'VistaComisiones
        '
        Me.VistaComisiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumeroFactura, Me.colIdProducto, Me.colIdPoliza, Me.colIdMovimiento, Me.colCliente, Me.colFechaPago, Me.colIncluir, Me.ColIdRamo, Me.ColFechaVence, Me.ColPrima, Me.ColPorceComi, Me.ColComision, Me.colPorceVen, Me.ColComiVend, Me.GridColumn1})
        Me.VistaComisiones.GridControl = Me.GridComisiones
        Me.VistaComisiones.Name = "VistaComisiones"
        Me.VistaComisiones.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaComisiones.OptionsView.ShowGroupPanel = False
        Me.VistaComisiones.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFechaPago, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNumeroFactura
        '
        Me.colNumeroFactura.Caption = "Factura"
        Me.colNumeroFactura.FieldName = "NumeroFactura"
        Me.colNumeroFactura.Name = "colNumeroFactura"
        Me.colNumeroFactura.Visible = True
        Me.colNumeroFactura.VisibleIndex = 2
        Me.colNumeroFactura.Width = 68
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "Producto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = True
        Me.colIdProducto.VisibleIndex = 1
        Me.colIdProducto.Width = 69
        '
        'colIdPoliza
        '
        Me.colIdPoliza.Caption = "Póliza"
        Me.colIdPoliza.FieldName = "IdPoliza"
        Me.colIdPoliza.Name = "colIdPoliza"
        Me.colIdPoliza.Visible = True
        Me.colIdPoliza.VisibleIndex = 3
        Me.colIdPoliza.Width = 68
        '
        'colIdMovimiento
        '
        Me.colIdMovimiento.Caption = "Id"
        Me.colIdMovimiento.FieldName = "IdMovimiento"
        Me.colIdMovimiento.Name = "colIdMovimiento"
        Me.colIdMovimiento.Width = 35
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "NombreCliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 127
        '
        'colFechaPago
        '
        Me.colFechaPago.Caption = "Fecha Pago"
        Me.colFechaPago.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaPago.FieldName = "FechaPago"
        Me.colFechaPago.Name = "colFechaPago"
        Me.colFechaPago.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colFechaPago.Visible = True
        Me.colFechaPago.VisibleIndex = 6
        Me.colFechaPago.Width = 70
        '
        'colIncluir
        '
        Me.colIncluir.Caption = "Incluir"
        Me.colIncluir.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colIncluir.FieldName = "Incluir"
        Me.colIncluir.Name = "colIncluir"
        Me.colIncluir.Visible = True
        Me.colIncluir.VisibleIndex = 12
        Me.colIncluir.Width = 59
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ColIdRamo
        '
        Me.ColIdRamo.Caption = "Ramo"
        Me.ColIdRamo.FieldName = "IdRamo"
        Me.ColIdRamo.Name = "ColIdRamo"
        Me.ColIdRamo.Width = 61
        '
        'ColFechaVence
        '
        Me.ColFechaVence.Caption = "Fec. Vencimiento"
        Me.ColFechaVence.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaVence.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColFechaVence.FieldName = "FechaVence"
        Me.ColFechaVence.Name = "ColFechaVence"
        Me.ColFechaVence.Visible = True
        Me.ColFechaVence.VisibleIndex = 5
        Me.ColFechaVence.Width = 95
        '
        'ColPrima
        '
        Me.ColPrima.Caption = "Prima Neta"
        Me.ColPrima.DisplayFormat.FormatString = "c"
        Me.ColPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrima.FieldName = "PrimaNeta"
        Me.ColPrima.Name = "ColPrima"
        Me.ColPrima.Visible = True
        Me.ColPrima.VisibleIndex = 7
        Me.ColPrima.Width = 86
        '
        'ColPorceComi
        '
        Me.ColPorceComi.Caption = "%Comi."
        Me.ColPorceComi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPorceComi.FieldName = "PorceComi"
        Me.ColPorceComi.Name = "ColPorceComi"
        Me.ColPorceComi.Visible = True
        Me.ColPorceComi.VisibleIndex = 8
        Me.ColPorceComi.Width = 56
        '
        'ColComision
        '
        Me.ColComision.Caption = "Comisión"
        Me.ColComision.DisplayFormat.FormatString = "c"
        Me.ColComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColComision.FieldName = "Comision"
        Me.ColComision.Name = "ColComision"
        Me.ColComision.Visible = True
        Me.ColComision.VisibleIndex = 9
        Me.ColComision.Width = 87
        '
        'colPorceVen
        '
        Me.colPorceVen.Caption = "%Vend."
        Me.colPorceVen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorceVen.FieldName = "PorceVendedor"
        Me.colPorceVen.Name = "colPorceVen"
        Me.colPorceVen.Visible = True
        Me.colPorceVen.VisibleIndex = 10
        '
        'ColComiVend
        '
        Me.ColComiVend.Caption = "Comi. Vend."
        Me.ColComiVend.DisplayFormat.FormatString = "c"
        Me.ColComiVend.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColComiVend.FieldName = "ComiVendedor"
        Me.ColComiVend.Name = "ColComiVend"
        Me.ColComiVend.Visible = True
        Me.ColComiVend.VisibleIndex = 11
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Aseguradora"
        Me.GridColumn1.FieldName = "Aseguradora"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(6, 395)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(196, 36)
        Me.btnImprimir.TabIndex = 36
        Me.btnImprimir.Text = "&Imprimir Estado de Cuenta"
        '
        'btnAplicarEstadoCuenta
        '
        Me.btnAplicarEstadoCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicarEstadoCuenta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAplicarEstadoCuenta.Appearance.Options.UseFont = True
        Me.btnAplicarEstadoCuenta.Appearance.Options.UseTextOptions = True
        Me.btnAplicarEstadoCuenta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnAplicarEstadoCuenta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAplicarEstadoCuenta.Image = CType(resources.GetObject("btnAplicarEstadoCuenta.Image"), System.Drawing.Image)
        Me.btnAplicarEstadoCuenta.Location = New System.Drawing.Point(6, 434)
        Me.btnAplicarEstadoCuenta.Name = "btnAplicarEstadoCuenta"
        Me.btnAplicarEstadoCuenta.Size = New System.Drawing.Size(196, 34)
        Me.btnAplicarEstadoCuenta.TabIndex = 35
        Me.btnAplicarEstadoCuenta.Text = "A&plicar Estado de Cuenta"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.CampoBusqueda = False
        Me.txtTotal.CampoEsLlave = False
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotal.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotal.FechaActual = False
        Me.txtTotal.Formato = "$#,###0.00"
        Me.txtTotal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotal.LabelText = "Total Comisión"
        Me.txtTotal.LabelWidth = 100
        Me.txtTotal.Location = New System.Drawing.Point(594, 395)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NombreCampo = ""
        Me.txtTotal.Obligatorio = False
        Me.txtTotal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.Size = New System.Drawing.Size(219, 20)
        Me.txtTotal.SoloLectura = True
        Me.txtTotal.TabIndex = 37
        Me.txtTotal.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotal.Valor = 0
        '
        'txtMotivoDescuento
        '
        Me.txtMotivoDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMotivoDescuento.CampoBusqueda = False
        Me.txtMotivoDescuento.CampoEsLlave = False
        Me.txtMotivoDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoDescuento.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivoDescuento.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoDescuento.FechaActual = False
        Me.txtMotivoDescuento.Formato = ""
        Me.txtMotivoDescuento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMotivoDescuento.LabelText = "Motivo Descuento"
        Me.txtMotivoDescuento.LabelWidth = 100
        Me.txtMotivoDescuento.Location = New System.Drawing.Point(6, 369)
        Me.txtMotivoDescuento.MaxLength = 500
        Me.txtMotivoDescuento.Name = "txtMotivoDescuento"
        Me.txtMotivoDescuento.NombreCampo = "MotivoDescuento"
        Me.txtMotivoDescuento.Obligatorio = False
        Me.txtMotivoDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoDescuento.Size = New System.Drawing.Size(300, 20)
        Me.txtMotivoDescuento.SoloLectura = False
        Me.txtMotivoDescuento.TabIndex = 38
        Me.txtMotivoDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoDescuento.Valor = ""
        '
        'txtValorDescuento
        '
        Me.txtValorDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValorDescuento.CampoBusqueda = False
        Me.txtValorDescuento.CampoEsLlave = False
        Me.txtValorDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorDescuento.ControlBackColor = System.Drawing.Color.White
        Me.txtValorDescuento.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorDescuento.FechaActual = False
        Me.txtValorDescuento.Formato = "#,###0.00"
        Me.txtValorDescuento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorDescuento.LabelText = "Valor Descuento"
        Me.txtValorDescuento.LabelWidth = 100
        Me.txtValorDescuento.Location = New System.Drawing.Point(312, 369)
        Me.txtValorDescuento.MaxLength = 0
        Me.txtValorDescuento.Name = "txtValorDescuento"
        Me.txtValorDescuento.NombreCampo = "ValorDescuento"
        Me.txtValorDescuento.Obligatorio = False
        Me.txtValorDescuento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorDescuento.Size = New System.Drawing.Size(174, 20)
        Me.txtValorDescuento.SoloLectura = False
        Me.txtValorDescuento.TabIndex = 39
        Me.txtValorDescuento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorDescuento.Valor = 0
        '
        'EstadosCuentaVendedoresMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 604
        Me.ClientSize = New System.Drawing.Size(825, 471)
        Me.Controls.Add(Me.txtValorDescuento)
        Me.Controls.Add(Me.txtMotivoDescuento)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnAplicarEstadoCuenta)
        Me.Controls.Add(Me.GridComisiones)
        Me.Controls.Add(Me.btnBuscarComi)
        Me.Controls.Add(Me.txtIdEstadoCuenta)
        Me.Controls.Add(Me.cboEstatus)
        Me.Controls.Add(Me.cboVendedores)
        Me.Controls.Add(Me.txtFechaCorte)
        Me.Name = "EstadosCuentaVendedoresMan"
        Me.SeguirAlGrabarActualizar = True
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Estados de Cuenta"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCorte, 0)
        Me.Controls.SetChildIndex(Me.cboVendedores, 0)
        Me.Controls.SetChildIndex(Me.cboEstatus, 0)
        Me.Controls.SetChildIndex(Me.txtIdEstadoCuenta, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarComi, 0)
        Me.Controls.SetChildIndex(Me.GridComisiones, 0)
        Me.Controls.SetChildIndex(Me.btnAplicarEstadoCuenta, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.txtTotal, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoDescuento, 0)
        Me.Controls.SetChildIndex(Me.txtValorDescuento, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnBuscarComi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdEstadoCuenta As STIControles.stiTextBox
    Friend WithEvents cboEstatus As STIControles.stiComboBox
    Friend WithEvents cboVendedores As STIControles.stiComboBox
    Friend WithEvents txtFechaCorte As STIControles.stiTextBox
    Friend WithEvents GridComisiones As STIControles.stiGrid
    Friend WithEvents VistaComisiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumeroFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMovimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIncluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ColIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaVence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPorceComi As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAplicarEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotal As STIControles.stiTextBox
    Friend WithEvents colPorceVen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColComiVend As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMotivoDescuento As STIControles.stiTextBox
    Friend WithEvents txtValorDescuento As STIControles.stiTextBox

End Class
