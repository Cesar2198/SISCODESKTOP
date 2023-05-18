<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPrimasPendientesClientes
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
        Dim PivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepPrimasPendientesClientes))
        Me.ColDiasMora = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colGestion = New DevExpress.XtraPivotGrid.PivotGridField
        Me.txtFecha = New STIControles.stiTextBox
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
        Me.ColComision = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colLugarTrabajo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFax = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colEmail = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colTelefono = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDireccion = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colCiudad = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colReferencia = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colObservaciones = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColRetIva = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colVencimientoTardio = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColTarjeta = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colIdProducto = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colTipoCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colGrupoCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.lblLog = New DevExpress.XtraEditors.LabelControl
        Me.txtCliente = New STIControles.stiTextBox
        Me.chkGestionEspecial = New DevExpress.XtraEditors.CheckEdit
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGestionEspecial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(741, 375)
        Me.btnAyuda.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(638, 375)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(844, 375)
        Me.btnSalir.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Size = New System.Drawing.Size(137, 85)
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
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.Size = New System.Drawing.Size(298, 85)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Reporte de Primas Pendientes por Tipo de Clientes"
        '
        'ColDiasMora
        '
        Me.ColDiasMora.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColDiasMora.AreaIndex = 8
        Me.ColDiasMora.Caption = "Días Mora"
        Me.ColDiasMora.FieldName = "Dias"
        Me.ColDiasMora.Name = "ColDiasMora"
        Me.ColDiasMora.Width = 90
        '
        'colGestion
        '
        Me.colGestion.Appearance.Value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colGestion.Appearance.Value.ForeColor = System.Drawing.Color.Blue
        Me.colGestion.Appearance.Value.Options.UseFont = True
        Me.colGestion.Appearance.Value.Options.UseForeColor = True
        Me.colGestion.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colGestion.AreaIndex = 14
        Me.colGestion.Caption = "Gestión"
        Me.colGestion.FieldName = "Gestion"
        Me.colGestion.Name = "colGestion"
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
        Me.txtFecha.Location = New System.Drawing.Point(441, 2)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(339, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'PivotFacturas
        '
        Me.PivotFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotFacturas.Appearance.Cell.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.Cell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.ColumnHeaderArea.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.ColumnHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.CustomTotalCell.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.CustomTotalCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.DataHeaderArea.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.DataHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.Empty.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.ExpandButton.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.ExpandButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FieldHeader.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FieldHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FieldValue.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FieldValue.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FieldValueGrandTotal.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FieldValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FieldValueTotal.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FieldValueTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FilterHeaderArea.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FilterHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FilterSeparator.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FilterSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.LightYellow
        Me.PivotFacturas.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.PivotFacturas.Appearance.GrandTotalCell.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.GrandTotalCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.HeaderArea.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.HeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.HeaderFilterButton.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.HeaderFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.HeaderFilterButtonActive.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.HeaderFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.HeaderGroupLine.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.HeaderGroupLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.Lines.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.RowHeaderArea.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.RowHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.SelectedCell.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.SelectedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PivotFacturas.Appearance.TotalCell.Options.UseBackColor = True
        Me.PivotFacturas.Appearance.TotalCell.Options.UseTextOptions = True
        Me.PivotFacturas.Appearance.TotalCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PivotFacturas.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotFacturas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.ColNumFactura, Me.ColProducto, Me.ColRamo, Me.ColTipoSeguro, Me.ColAseguradora, Me.ColPoliza, Me.ColTipoFactura, Me.ColCliente, Me.ColFechaPago, Me.ColCuota, Me.ColDiasMora, Me.ColRangoMora, Me.ColPrima, Me.ColGastos, Me.ColImpuestos, Me.ColTotal, Me.ColComision, Me.colLugarTrabajo, Me.colFax, Me.colEmail, Me.colTelefono, Me.colDireccion, Me.colCiudad, Me.colReferencia, Me.colObservaciones, Me.ColRetIva, Me.colVencimientoTardio, Me.colGestion, Me.ColTarjeta, Me.colIdProducto, Me.colTipoCliente, Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.colGrupoCliente, Me.PivotGridField4, Me.PivotGridField5})
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
        Me.PivotFacturas.Location = New System.Drawing.Point(2, 88)
        Me.PivotFacturas.Name = "PivotFacturas"
        Me.PivotFacturas.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotFacturas.Size = New System.Drawing.Size(941, 284)
        Me.PivotFacturas.TabIndex = 2
        '
        'ColNumFactura
        '
        Me.ColNumFactura.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColNumFactura.AreaIndex = 7
        Me.ColNumFactura.Caption = "Número Factura"
        Me.ColNumFactura.FieldName = "NumeroFactura"
        Me.ColNumFactura.Name = "ColNumFactura"
        '
        'ColProducto
        '
        Me.ColProducto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColProducto.AreaIndex = 0
        Me.ColProducto.Caption = "Producto"
        Me.ColProducto.FieldName = "Producto"
        Me.ColProducto.Name = "ColProducto"
        '
        'ColRamo
        '
        Me.ColRamo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColRamo.AreaIndex = 4
        Me.ColRamo.Caption = "Ramo"
        Me.ColRamo.FieldName = "Ramo"
        Me.ColRamo.Name = "ColRamo"
        '
        'ColTipoSeguro
        '
        Me.ColTipoSeguro.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTipoSeguro.AreaIndex = 1
        Me.ColTipoSeguro.Caption = "Tipo Seguro"
        Me.ColTipoSeguro.FieldName = "TipoSeguro"
        Me.ColTipoSeguro.Name = "ColTipoSeguro"
        '
        'ColAseguradora
        '
        Me.ColAseguradora.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColAseguradora.AreaIndex = 2
        Me.ColAseguradora.Caption = "Aseguradora"
        Me.ColAseguradora.FieldName = "Aseguradora"
        Me.ColAseguradora.Name = "ColAseguradora"
        '
        'ColPoliza
        '
        Me.ColPoliza.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColPoliza.AreaIndex = 5
        Me.ColPoliza.Caption = "Póliza"
        Me.ColPoliza.FieldName = "Poliza"
        Me.ColPoliza.Name = "ColPoliza"
        Me.ColPoliza.Width = 75
        '
        'ColTipoFactura
        '
        Me.ColTipoFactura.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTipoFactura.AreaIndex = 2
        Me.ColTipoFactura.Caption = "Tipo Factura"
        Me.ColTipoFactura.FieldName = "TipoFactura"
        Me.ColTipoFactura.Name = "ColTipoFactura"
        '
        'ColCliente
        '
        Me.ColCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColCliente.AreaIndex = 3
        Me.ColCliente.Caption = "Cliente"
        Me.ColCliente.FieldName = "NombreCliente"
        Me.ColCliente.Name = "ColCliente"
        '
        'ColFechaPago
        '
        Me.ColFechaPago.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColFechaPago.AreaIndex = 8
        Me.ColFechaPago.Caption = "Fecha Pago"
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
        Me.ColCuota.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColCuota.AreaIndex = 6
        Me.ColCuota.Caption = "Cuota"
        Me.ColCuota.FieldName = "Cuota"
        Me.ColCuota.Name = "ColCuota"
        Me.ColCuota.Width = 70
        '
        'ColRangoMora
        '
        Me.ColRangoMora.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColRangoMora.AreaIndex = 1
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
        'ColComision
        '
        Me.ColComision.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColComision.AreaIndex = 4
        Me.ColComision.Caption = "Comisión"
        Me.ColComision.FieldName = "Comision"
        Me.ColComision.Name = "ColComision"
        Me.ColComision.Width = 75
        '
        'colLugarTrabajo
        '
        Me.colLugarTrabajo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colLugarTrabajo.AreaIndex = 3
        Me.colLugarTrabajo.Caption = "Lugar de Trabajo"
        Me.colLugarTrabajo.FieldName = "LugarTrabajo"
        Me.colLugarTrabajo.Name = "colLugarTrabajo"
        '
        'colFax
        '
        Me.colFax.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colFax.AreaIndex = 5
        Me.colFax.Caption = "Fax"
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        '
        'colEmail
        '
        Me.colEmail.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colEmail.AreaIndex = 6
        Me.colEmail.Caption = "Email"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        '
        'colTelefono
        '
        Me.colTelefono.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colTelefono.AreaIndex = 7
        Me.colTelefono.Caption = "Teléfono"
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        '
        'colDireccion
        '
        Me.colDireccion.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDireccion.AreaIndex = 9
        Me.colDireccion.Caption = "Dirección"
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        '
        'colCiudad
        '
        Me.colCiudad.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colCiudad.AreaIndex = 10
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        '
        'colReferencia
        '
        Me.colReferencia.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colReferencia.AreaIndex = 12
        Me.colReferencia.Caption = "Referencia"
        Me.colReferencia.FieldName = "Referencia"
        Me.colReferencia.Name = "colReferencia"
        '
        'colObservaciones
        '
        Me.colObservaciones.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colObservaciones.AreaIndex = 11
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'ColRetIva
        '
        Me.ColRetIva.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColRetIva.AreaIndex = 4
        Me.ColRetIva.Caption = "Ret. Iva"
        Me.ColRetIva.FieldName = "RetencionImpuestos"
        Me.ColRetIva.Name = "ColRetIva"
        '
        'colVencimientoTardio
        '
        Me.colVencimientoTardio.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colVencimientoTardio.AreaIndex = 13
        Me.colVencimientoTardio.Caption = "Venc. Tardío"
        Me.colVencimientoTardio.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.colVencimientoTardio.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVencimientoTardio.FieldName = "VencimientoTardio"
        Me.colVencimientoTardio.Name = "colVencimientoTardio"
        '
        'ColTarjeta
        '
        Me.ColTarjeta.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTarjeta.AreaIndex = 15
        Me.ColTarjeta.Caption = "Tarjeta Crédito"
        Me.ColTarjeta.FieldName = "TarjetaCredito"
        Me.ColTarjeta.Name = "ColTarjeta"
        '
        'colIdProducto
        '
        Me.colIdProducto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colIdProducto.AreaIndex = 18
        Me.colIdProducto.Caption = "IdProducto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = False
        '
        'colTipoCliente
        '
        Me.colTipoCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colTipoCliente.AreaIndex = 0
        Me.colTipoCliente.Caption = "Tipo Cliente"
        Me.colTipoCliente.FieldName = "TipoCliente"
        Me.colTipoCliente.Name = "colTipoCliente"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField1.AreaIndex = 16
        Me.PivotGridField1.Caption = "Última Gestión"
        Me.PivotGridField1.FieldName = "UltimaGestion"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField2.AreaIndex = 17
        Me.PivotGridField2.Caption = "No. AC"
        Me.PivotGridField2.FieldName = "IdAC"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 18
        Me.PivotGridField3.Caption = "Vendedor"
        Me.PivotGridField3.FieldName = "Vendedor"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colGrupoCliente.AreaIndex = 19
        Me.colGrupoCliente.Caption = "Grupo Cliente"
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(781, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "&Búscar"
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
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(441, 23)
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
        Me.cboEjecutivoCta.TabIndex = 24
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'lblLog
        '
        Me.lblLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLog.Location = New System.Drawing.Point(12, 376)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(0, 13)
        Me.lblLog.TabIndex = 25
        '
        'txtCliente
        '
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCliente.LabelText = "Cliente"
        Me.txtCliente.LabelWidth = 100
        Me.txtCliente.Location = New System.Drawing.Point(441, 44)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(335, 20)
        Me.txtCliente.SoloLectura = False
        Me.txtCliente.TabIndex = 26
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'chkGestionEspecial
        '
        Me.chkGestionEspecial.Location = New System.Drawing.Point(439, 66)
        Me.chkGestionEspecial.Name = "chkGestionEspecial"
        Me.chkGestionEspecial.Properties.Caption = "Incluir Facturas Con Gestión Especial"
        Me.chkGestionEspecial.Size = New System.Drawing.Size(216, 19)
        Me.chkGestionEspecial.TabIndex = 27
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField4.AreaIndex = 20
        Me.PivotGridField4.Caption = "Forma de Pago"
        Me.PivotGridField4.FieldName = "FormaPago"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField5.AreaIndex = 21
        Me.PivotGridField5.Caption = "Tipo de Pago"
        Me.PivotGridField5.FieldName = "TipoPago"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'RepPrimasPendientesClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 322
        Me.ClientSize = New System.Drawing.Size(947, 413)
        Me.Controls.Add(Me.chkGestionEspecial)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.PivotFacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepPrimasPendientesClientes"
        Me.Controls.SetChildIndex(Me.PivotFacturas, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.lblLog, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.chkGestionEspecial, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGestionEspecial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents PivotFacturas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ColNumFactura As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColProducto As DevExpress.XtraPivotGrid.PivotGridField
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
    Friend WithEvents ColComision As DevExpress.XtraPivotGrid.PivotGridField
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColRamo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents colLugarTrabajo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFax As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEmail As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colTelefono As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDireccion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCiudad As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colReferencia As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colObservaciones As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents lblLog As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents ColRetIva As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colVencimientoTardio As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGestion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents chkGestionEspecial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ColTarjeta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colIdProducto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colTipoCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGrupoCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField

End Class
