<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstPrimasPendientes
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
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstPrimasPendientes))
        Me.colDias = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColGestionPendiente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGestionTramite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridPrimas = New STIControles.stiGrid
        Me.mnuGestion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarGestiónDeCarteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarGestiónDeCarteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnviarEstadoDeCuentaPorCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumeroFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoSeguro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimaNeta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGastos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImpuestos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLugarTrabajo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCiudad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColEjecutivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColIdCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColRango = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColIdRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTarjeta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIvaRet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimientoTardio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColVenceTarjeta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupoCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.txtFecha = New STIControles.stiTextBox
        Me.lblGesAtrasada = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.lblLog = New DevExpress.XtraEditors.LabelControl
        Me.chkGestionEspecial = New DevExpress.XtraEditors.CheckEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPrimas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuGestion.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGestionEspecial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(720, 408)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(617, 408)
        Me.btnImprimir.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(823, 408)
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(270, 74)
        Me.LabelControl1.Text = "Gestión de Primas Pendientes"
        '
        'colDias
        '
        Me.colDias.Caption = "Días Mora"
        Me.colDias.FieldName = "Dias"
        Me.colDias.Name = "colDias"
        Me.colDias.Visible = True
        Me.colDias.VisibleIndex = 12
        '
        'ColGestionPendiente
        '
        Me.ColGestionPendiente.Caption = "Gestión Pendiente"
        Me.ColGestionPendiente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColGestionPendiente.FieldName = "GestionPendiente"
        Me.ColGestionPendiente.Name = "ColGestionPendiente"
        '
        'colGestionTramite
        '
        Me.colGestionTramite.Caption = "Gestión en Trámite"
        Me.colGestionTramite.FieldName = "GestionTramite"
        Me.colGestionTramite.Name = "colGestionTramite"
        '
        'GridPrimas
        '
        Me.GridPrimas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPrimas.ColumnasAdicionales = ""
        Me.GridPrimas.ContextMenuStrip = Me.mnuGestion
        Me.GridPrimas.Location = New System.Drawing.Point(1, 76)
        Me.GridPrimas.MainView = Me.GridView1
        Me.GridPrimas.Name = "GridPrimas"
        Me.GridPrimas.NombreTabla = ""
        Me.GridPrimas.Size = New System.Drawing.Size(924, 328)
        Me.GridPrimas.TabIndex = 4
        Me.GridPrimas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'mnuGestion
        '
        Me.mnuGestion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarGestiónDeCarteraToolStripMenuItem, Me.ConsultarGestiónDeCarteraToolStripMenuItem, Me.EnviarEstadoDeCuentaPorCorreoToolStripMenuItem})
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(262, 70)
        '
        'AgregarGestiónDeCarteraToolStripMenuItem
        '
        Me.AgregarGestiónDeCarteraToolStripMenuItem.Name = "AgregarGestiónDeCarteraToolStripMenuItem"
        Me.AgregarGestiónDeCarteraToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.AgregarGestiónDeCarteraToolStripMenuItem.Text = "Agregar Gestión de Cartera"
        '
        'ConsultarGestiónDeCarteraToolStripMenuItem
        '
        Me.ConsultarGestiónDeCarteraToolStripMenuItem.Name = "ConsultarGestiónDeCarteraToolStripMenuItem"
        Me.ConsultarGestiónDeCarteraToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.ConsultarGestiónDeCarteraToolStripMenuItem.Text = "Consultar Gestión de Cartera"
        '
        'EnviarEstadoDeCuentaPorCorreoToolStripMenuItem
        '
        Me.EnviarEstadoDeCuentaPorCorreoToolStripMenuItem.Name = "EnviarEstadoDeCuentaPorCorreoToolStripMenuItem"
        Me.EnviarEstadoDeCuentaPorCorreoToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.EnviarEstadoDeCuentaPorCorreoToolStripMenuItem.Text = "Enviar Estado de Cuenta por Correo"
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumeroFactura, Me.colProducto, Me.colRamo, Me.colTipoSeguro, Me.colAseguradora, Me.colPoliza, Me.colTipoFactura, Me.colNombreCliente, Me.colFechaPago, Me.colCuota, Me.colDias, Me.colPrimaNeta, Me.colGastos, Me.colImpuestos, Me.colTotal, Me.colComision, Me.ColGestionPendiente, Me.colIdProducto, Me.colGestionTramite, Me.colLugarTrabajo, Me.colFax, Me.colEmail, Me.colTelefono, Me.colDireccion, Me.colCiudad, Me.colReferencia, Me.colObservaciones, Me.ColEjecutivo, Me.ColIdCliente, Me.ColRango, Me.ColIdRamo, Me.colTarjeta, Me.colIvaRet, Me.colVencimientoTardio, Me.ColVenceTarjeta, Me.GridColumn1, Me.colGrupoCliente, Me.GridColumn2})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colDias
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Value1 = 60
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.ColGestionPendiente
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition2.Value1 = 1
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colGestionTramite
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition3.Value1 = 1
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridPrimas
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAseguradora, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDias, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colNumeroFactura
        '
        Me.colNumeroFactura.Caption = "Número Factura"
        Me.colNumeroFactura.FieldName = "NumeroFactura"
        Me.colNumeroFactura.Name = "colNumeroFactura"
        Me.colNumeroFactura.Visible = True
        Me.colNumeroFactura.VisibleIndex = 0
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        '
        'colRamo
        '
        Me.colRamo.Caption = "Ramo"
        Me.colRamo.FieldName = "Ramo"
        Me.colRamo.Name = "colRamo"
        Me.colRamo.Visible = True
        Me.colRamo.VisibleIndex = 3
        '
        'colTipoSeguro
        '
        Me.colTipoSeguro.Caption = "Tipo Seguro"
        Me.colTipoSeguro.FieldName = "TipoSeguro"
        Me.colTipoSeguro.Name = "colTipoSeguro"
        Me.colTipoSeguro.Visible = True
        Me.colTipoSeguro.VisibleIndex = 2
        '
        'colAseguradora
        '
        Me.colAseguradora.Caption = "Aseguradora"
        Me.colAseguradora.FieldName = "Aseguradora"
        Me.colAseguradora.Name = "colAseguradora"
        '
        'colPoliza
        '
        Me.colPoliza.Caption = "Póliza"
        Me.colPoliza.FieldName = "Poliza"
        Me.colPoliza.Name = "colPoliza"
        Me.colPoliza.Visible = True
        Me.colPoliza.VisibleIndex = 4
        '
        'colTipoFactura
        '
        Me.colTipoFactura.Caption = "Tipo Factura"
        Me.colTipoFactura.FieldName = "TipoFactura"
        Me.colTipoFactura.Name = "colTipoFactura"
        Me.colTipoFactura.Visible = True
        Me.colTipoFactura.VisibleIndex = 5
        '
        'colNombreCliente
        '
        Me.colNombreCliente.Caption = "Cliente"
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 7
        '
        'colFechaPago
        '
        Me.colFechaPago.Caption = "Fecha Pago"
        Me.colFechaPago.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaPago.FieldName = "FechaPago"
        Me.colFechaPago.Name = "colFechaPago"
        Me.colFechaPago.Visible = True
        Me.colFechaPago.VisibleIndex = 8
        '
        'colCuota
        '
        Me.colCuota.Caption = "Cuota"
        Me.colCuota.FieldName = "Cuota"
        Me.colCuota.Name = "colCuota"
        Me.colCuota.Visible = True
        Me.colCuota.VisibleIndex = 10
        '
        'colPrimaNeta
        '
        Me.colPrimaNeta.Caption = "Prima Neta"
        Me.colPrimaNeta.DisplayFormat.FormatString = "c"
        Me.colPrimaNeta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimaNeta.FieldName = "PrimaNeta"
        Me.colPrimaNeta.Name = "colPrimaNeta"
        '
        'colGastos
        '
        Me.colGastos.Caption = "Gastos"
        Me.colGastos.DisplayFormat.FormatString = "c"
        Me.colGastos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGastos.FieldName = "Gastos"
        Me.colGastos.Name = "colGastos"
        '
        'colImpuestos
        '
        Me.colImpuestos.Caption = "Impuestos"
        Me.colImpuestos.DisplayFormat.FormatString = "c"
        Me.colImpuestos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImpuestos.FieldName = "Impuestos"
        Me.colImpuestos.Name = "colImpuestos"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 13
        '
        'colComision
        '
        Me.colComision.Caption = "Comisión"
        Me.colComision.DisplayFormat.FormatString = "c"
        Me.colComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComision.FieldName = "Comision"
        Me.colComision.Name = "colComision"
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "IdProducto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        '
        'colLugarTrabajo
        '
        Me.colLugarTrabajo.Caption = "Lugar Trabajo"
        Me.colLugarTrabajo.FieldName = "LugarTrabajo"
        Me.colLugarTrabajo.Name = "colLugarTrabajo"
        '
        'colFax
        '
        Me.colFax.Caption = "Fax"
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        '
        'colEmail
        '
        Me.colEmail.Caption = "EMail"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 16
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "Teléfono"
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 17
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "Dirección"
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 18
        '
        'colCiudad
        '
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        Me.colCiudad.Visible = True
        Me.colCiudad.VisibleIndex = 19
        '
        'colReferencia
        '
        Me.colReferencia.Caption = "Referencia"
        Me.colReferencia.FieldName = "Referencia"
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.Visible = True
        Me.colReferencia.VisibleIndex = 20
        '
        'colObservaciones
        '
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'ColEjecutivo
        '
        Me.ColEjecutivo.Caption = "Ejecutivo"
        Me.ColEjecutivo.FieldName = "Ejecutivo"
        Me.ColEjecutivo.Name = "ColEjecutivo"
        Me.ColEjecutivo.Visible = True
        Me.ColEjecutivo.VisibleIndex = 6
        '
        'ColIdCliente
        '
        Me.ColIdCliente.Caption = "Cod. Cliente"
        Me.ColIdCliente.FieldName = "IdCliente"
        Me.ColIdCliente.Name = "ColIdCliente"
        '
        'ColRango
        '
        Me.ColRango.Caption = "Rango Días"
        Me.ColRango.FieldName = "RangoMora"
        Me.ColRango.Name = "ColRango"
        Me.ColRango.Visible = True
        Me.ColRango.VisibleIndex = 11
        '
        'ColIdRamo
        '
        Me.ColIdRamo.Caption = "IdRamo"
        Me.ColIdRamo.FieldName = "IdRamo"
        Me.ColIdRamo.Name = "ColIdRamo"
        '
        'colTarjeta
        '
        Me.colTarjeta.Caption = "Tarjeta"
        Me.colTarjeta.FieldName = "Tarjeta"
        Me.colTarjeta.Name = "colTarjeta"
        Me.colTarjeta.Visible = True
        Me.colTarjeta.VisibleIndex = 14
        '
        'colIvaRet
        '
        Me.colIvaRet.Caption = "Ret. Iva"
        Me.colIvaRet.DisplayFormat.FormatString = "c"
        Me.colIvaRet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIvaRet.FieldName = "RetencionImpuestos"
        Me.colIvaRet.Name = "colIvaRet"
        '
        'colVencimientoTardio
        '
        Me.colVencimientoTardio.Caption = "Venc. Tardío"
        Me.colVencimientoTardio.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colVencimientoTardio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVencimientoTardio.FieldName = "VencimientoTardio"
        Me.colVencimientoTardio.Name = "colVencimientoTardio"
        Me.colVencimientoTardio.Visible = True
        Me.colVencimientoTardio.VisibleIndex = 9
        '
        'ColVenceTarjeta
        '
        Me.ColVenceTarjeta.Caption = "Venc. Tarjeta"
        Me.ColVenceTarjeta.FieldName = "VenceTarjeta"
        Me.ColVenceTarjeta.Name = "ColVenceTarjeta"
        Me.ColVenceTarjeta.Visible = True
        Me.ColVenceTarjeta.VisibleIndex = 15
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Doc. Fiscal Env."
        Me.GridColumn1.FieldName = "DocFiscalEnv"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 21
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.Caption = "Grupo Cliente"
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(664, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Búscar"
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = False
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.White
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = True
        Me.txtFecha.Formato = "Long Date"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha de Corte"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(412, 3)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(337, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'lblGesAtrasada
        '
        Me.lblGesAtrasada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGesAtrasada.Appearance.BackColor = System.Drawing.Color.Red
        Me.lblGesAtrasada.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblGesAtrasada.Appearance.Options.UseBackColor = True
        Me.lblGesAtrasada.Appearance.Options.UseForeColor = True
        Me.lblGesAtrasada.Location = New System.Drawing.Point(6, 405)
        Me.lblGesAtrasada.Name = "lblGesAtrasada"
        Me.lblGesAtrasada.Size = New System.Drawing.Size(83, 13)
        Me.lblGesAtrasada.TabIndex = 20
        Me.lblGesAtrasada.Text = "Gestión Atrasada"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(6, 433)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(147, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Primas de más de 60 días mora"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(6, 419)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Gestión en Trámite"
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
        Me.cboEjecutivoCta.FilasVisibles = 11
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(412, 26)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(335, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 1
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'lblLog
        '
        Me.lblLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLog.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLog.Appearance.Options.UseFont = True
        Me.lblLog.Location = New System.Drawing.Point(202, 411)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(0, 13)
        Me.lblLog.TabIndex = 24
        '
        'chkGestionEspecial
        '
        Me.chkGestionEspecial.Location = New System.Drawing.Point(414, 53)
        Me.chkGestionEspecial.Name = "chkGestionEspecial"
        Me.chkGestionEspecial.Properties.Caption = "Incluir Facturas Con Gestión Especial"
        Me.chkGestionEspecial.Size = New System.Drawing.Size(216, 19)
        Me.chkGestionEspecial.TabIndex = 25
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Vendedor"
        Me.GridColumn2.FieldName = "Vendedor"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'LstPrimasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 311
        Me.ClientSize = New System.Drawing.Size(926, 446)
        Me.Controls.Add(Me.chkGestionEspecial)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblGesAtrasada)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.GridPrimas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "LstPrimasPendientes"
        Me.Text = "Primas Pendientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.GridPrimas, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.lblGesAtrasada, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.lblLog, 0)
        Me.Controls.SetChildIndex(Me.chkGestionEspecial, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPrimas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuGestion.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGestionEspecial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridPrimas As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumeroFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoSeguro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAseguradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimaNeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGastos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImpuestos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComision As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents ColGestionPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mnuGestion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarGestiónDeCarteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblGesAtrasada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGestionTramite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConsultarGestiónDeCarteraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents colLugarTrabajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEjecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EnviarEstadoDeCuentaPorCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColRango As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblLog As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarjeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIvaRet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimientoTardio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVenceTarjeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkGestionEspecial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
