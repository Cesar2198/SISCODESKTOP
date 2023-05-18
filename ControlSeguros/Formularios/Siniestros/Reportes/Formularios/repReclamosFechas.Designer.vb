<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repReclamosFechas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repReclamosFechas))
        Me.PivotReclamos = New DevExpress.XtraPivotGrid.PivotGridControl
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
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField21 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField22 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField23 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField24 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField25 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField26 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField27 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.txtDesde = New STIControles.stiTextBox
        Me.txtHasta = New STIControles.stiTextBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.cboRamo = New STIControles.stiComboBox
        Me.PivotGridField28 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(612, 514)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(509, 514)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(715, 514)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(681, 74)
        Me.LabelControl1.Text = "Análisis Fechas Reclamos"
        '
        'PivotReclamos
        '
        Me.PivotReclamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotReclamos.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotReclamos.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20, Me.PivotGridField21, Me.PivotGridField22, Me.PivotGridField23, Me.PivotGridField24, Me.PivotGridField25, Me.PivotGridField26, Me.PivotGridField27, Me.PivotGridField28})
        Me.PivotReclamos.Location = New System.Drawing.Point(5, 181)
        Me.PivotReclamos.Name = "PivotReclamos"
        Me.PivotReclamos.Size = New System.Drawing.Size(806, 327)
        Me.PivotReclamos.TabIndex = 18
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "No.Siniestro Aseguradora"
        Me.PivotGridField1.FieldName = "IdSiniestroAseguradora"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "No.Siniestro ADRISA"
        Me.PivotGridField2.FieldName = "IdSiniestro"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.Caption = "Aseguradora"
        Me.PivotGridField3.FieldName = "Aseguradora"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField4.AreaIndex = 2
        Me.PivotGridField4.Caption = "Cod.Cliente"
        Me.PivotGridField4.FieldName = "IdCliente"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField5.AreaIndex = 1
        Me.PivotGridField5.Caption = "NombreCliente"
        Me.PivotGridField5.FieldName = "NombreCliente"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField6.AreaIndex = 3
        Me.PivotGridField6.Caption = "Estado Reclamo"
        Me.PivotGridField6.FieldName = "EstadoSiniestro"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 0
        Me.PivotGridField7.Caption = "1. Fecha aviso del reclamo del cliente"
        Me.PivotGridField7.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField7.FieldName = "FechaAvisoCliente"
        Me.PivotGridField7.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField7.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 4
        Me.PivotGridField8.Caption = "2. Fecha ADRISA avisa a aseguradora"
        Me.PivotGridField8.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField8.FieldName = "FechaAvisoAseguradora"
        Me.PivotGridField8.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField8.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField9.AreaIndex = 5
        Me.PivotGridField9.Caption = "3. Fecha en que se solicita inspección"
        Me.PivotGridField9.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.FieldName = "FechaSolicitaInspeccion"
        Me.PivotGridField9.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField9.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 6
        Me.PivotGridField10.Caption = "4. Fecha de la inspección"
        Me.PivotGridField10.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField10.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField10.FieldName = "FechaInspeccion"
        Me.PivotGridField10.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField10.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField10.Name = "PivotGridField10"
        Me.PivotGridField10.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField11.AreaIndex = 7
        Me.PivotGridField11.Caption = "5. Fecha ajustador requiere docs."
        Me.PivotGridField11.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField11.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField11.FieldName = "FechaAjustadorReqDocs"
        Me.PivotGridField11.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField11.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField11.Name = "PivotGridField11"
        Me.PivotGridField11.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField12.AreaIndex = 8
        Me.PivotGridField12.Caption = "6. Fecha cliente entrega a ADRISA docs."
        Me.PivotGridField12.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField12.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField12.FieldName = "FechaCienteEntregaDocs"
        Me.PivotGridField12.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField12.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField12.Name = "PivotGridField12"
        Me.PivotGridField12.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField13.AreaIndex = 9
        Me.PivotGridField13.Caption = "7. Fecha ADRISA envía docs. a aseguradora"
        Me.PivotGridField13.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField13.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField13.FieldName = "FechaEnvioDocAseg"
        Me.PivotGridField13.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField13.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField13.Name = "PivotGridField13"
        Me.PivotGridField13.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField14
        '
        Me.PivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField14.AreaIndex = 10
        Me.PivotGridField14.Caption = "8. Fecha recibimos convenio ajuste"
        Me.PivotGridField14.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField14.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField14.FieldName = "FechaRecibeConvAjuste"
        Me.PivotGridField14.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField14.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField15.AreaIndex = 11
        Me.PivotGridField15.Caption = "9. Fecha ADRISA manda a cliente conv. ajuste"
        Me.PivotGridField15.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField15.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField15.FieldName = "FechaEnvioClientreConvAju"
        Me.PivotGridField15.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField15.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField15.Name = "PivotGridField15"
        Me.PivotGridField15.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField16.AreaIndex = 12
        Me.PivotGridField16.Caption = "10. Fecha cliente firma y entrega conv. aceptado "
        Me.PivotGridField16.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField16.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField16.FieldName = "FechaFirmaConvAjuste"
        Me.PivotGridField16.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField16.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField16.Name = "PivotGridField16"
        Me.PivotGridField16.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField17
        '
        Me.PivotGridField17.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField17.AreaIndex = 13
        Me.PivotGridField17.Caption = "11. Fecha ADRISA manda aceptado conv. a aseg."
        Me.PivotGridField17.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField17.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField17.FieldName = "FechaEnvioConvAseg"
        Me.PivotGridField17.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField17.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField17.Name = "PivotGridField17"
        Me.PivotGridField17.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField18
        '
        Me.PivotGridField18.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField18.AreaIndex = 14
        Me.PivotGridField18.Caption = "12. Fecha aseguradora entrega cheque de pago"
        Me.PivotGridField18.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField18.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField18.FieldName = "FechaAsegEntregaCheque"
        Me.PivotGridField18.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField18.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField18.Name = "PivotGridField18"
        Me.PivotGridField18.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField19
        '
        Me.PivotGridField19.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField19.AreaIndex = 15
        Me.PivotGridField19.Caption = "13. Fecha ADRISA entrega a cliente cheque"
        Me.PivotGridField19.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField19.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField19.FieldName = "FechaEntregaCheque"
        Me.PivotGridField19.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField19.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField19.Name = "PivotGridField19"
        Me.PivotGridField19.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField20
        '
        Me.PivotGridField20.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField20.AreaIndex = 16
        Me.PivotGridField20.Caption = "14. Fecha cliente entrega finiquito aceptado"
        Me.PivotGridField20.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField20.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField20.FieldName = "FechaEntregaFiniquito"
        Me.PivotGridField20.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField20.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField20.Name = "PivotGridField20"
        Me.PivotGridField20.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField21
        '
        Me.PivotGridField21.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField21.AreaIndex = 17
        Me.PivotGridField21.Caption = "15. Fecha finiquito ADRISA manda a Aseguradora"
        Me.PivotGridField21.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField21.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField21.FieldName = "FechaEnvioFiniquitoAseg"
        Me.PivotGridField21.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField21.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField21.Name = "PivotGridField21"
        Me.PivotGridField21.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField22
        '
        Me.PivotGridField22.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField22.AreaIndex = 1
        Me.PivotGridField22.Caption = "16. Final reclamo"
        Me.PivotGridField22.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField22.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField22.FieldName = "FechaFinalReclamo"
        Me.PivotGridField22.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField22.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField22.Name = "PivotGridField22"
        Me.PivotGridField22.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        '
        'PivotGridField23
        '
        Me.PivotGridField23.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField23.AreaIndex = 2
        Me.PivotGridField23.Caption = "Total Días"
        Me.PivotGridField23.CellFormat.FormatString = "n0"
        Me.PivotGridField23.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField23.FieldName = "Total1"
        Me.PivotGridField23.Name = "PivotGridField23"
        Me.PivotGridField23.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField24
        '
        Me.PivotGridField24.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField24.AreaIndex = 18
        Me.PivotGridField24.Caption = "Total Días"
        Me.PivotGridField24.CellFormat.FormatString = "n0"
        Me.PivotGridField24.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField24.FieldName = "Total2"
        Me.PivotGridField24.Name = "PivotGridField24"
        Me.PivotGridField24.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField25
        '
        Me.PivotGridField25.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField25.AreaIndex = 19
        Me.PivotGridField25.Caption = "Total Días"
        Me.PivotGridField25.CellFormat.FormatString = "n0"
        Me.PivotGridField25.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField25.FieldName = "Total3"
        Me.PivotGridField25.Name = "PivotGridField25"
        Me.PivotGridField25.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField26
        '
        Me.PivotGridField26.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField26.AreaIndex = 20
        Me.PivotGridField26.Caption = "Total Días"
        Me.PivotGridField26.CellFormat.FormatString = "n0"
        Me.PivotGridField26.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField26.FieldName = "Total4"
        Me.PivotGridField26.Name = "PivotGridField26"
        Me.PivotGridField26.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField27
        '
        Me.PivotGridField27.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField27.AreaIndex = 21
        Me.PivotGridField27.Caption = "Ramo"
        Me.PivotGridField27.FieldName = "Ramo"
        Me.PivotGridField27.Name = "PivotGridField27"
        '
        'txtDesde
        '
        Me.txtDesde.CampoBusqueda = False
        Me.txtDesde.CampoEsLlave = False
        Me.txtDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtDesde.FechaActual = False
        Me.txtDesde.Formato = "dd/MMM/yyyy"
        Me.txtDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDesde.LabelText = "Siniestros Incurridos Desde"
        Me.txtDesde.LabelWidth = 175
        Me.txtDesde.Location = New System.Drawing.Point(5, 81)
        Me.txtDesde.MaxLength = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreCampo = ""
        Me.txtDesde.Obligatorio = True
        Me.txtDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.Size = New System.Drawing.Size(327, 20)
        Me.txtDesde.SoloLectura = False
        Me.txtDesde.TabIndex = 19
        Me.txtDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtDesde.Valor = Nothing
        '
        'txtHasta
        '
        Me.txtHasta.CampoBusqueda = False
        Me.txtHasta.CampoEsLlave = False
        Me.txtHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtHasta.FechaActual = False
        Me.txtHasta.Formato = "dd/MMM/yyyy"
        Me.txtHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtHasta.LabelText = "Hasta"
        Me.txtHasta.LabelWidth = 50
        Me.txtHasta.Location = New System.Drawing.Point(338, 81)
        Me.txtHasta.MaxLength = 0
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreCampo = ""
        Me.txtHasta.Obligatorio = True
        Me.txtHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHasta.Size = New System.Drawing.Size(202, 20)
        Me.txtHasta.SoloLectura = False
        Me.txtHasta.TabIndex = 20
        Me.txtHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtHasta.Valor = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(569, 81)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 23)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar Reclamos"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(312, 105)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 25)
        Me.btnBuscarCliente.TabIndex = 23
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(425, 105)
        Me.txtNombreCliente.MaxLength = 500
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(381, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 24
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
        Me.txtIdCliente.LabelWidth = 75
        Me.txtIdCliente.Location = New System.Drawing.Point(5, 105)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(264, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 22
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(312, 129)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(107, 25)
        Me.btnBuscaPoliza.TabIndex = 31
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
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
        Me.txtIdPoliza.Location = New System.Drawing.Point(5, 129)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(264, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 29
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
        Me.cboIdProducto.LabelWidth = 60
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(425, 129)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto [Producto], Descripcion [Descripción] from Productos order by D" & _
            "escripcion asc"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(381, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 30
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'cboRamo
        '
        Me.cboRamo.CampoAutoCompletar = 0
        Me.cboRamo.CampoBusqueda = False
        Me.cboRamo.CampoDisplay = 1
        Me.cboRamo.CampoEsLlave = False
        Me.cboRamo.CampoValor = 0
        Me.cboRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboRamo.FilasVisibles = 29
        Me.cboRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRamo.LabelText = "Ramo"
        Me.cboRamo.LabelWidth = 75
        Me.cboRamo.Lista = ""
        Me.cboRamo.Location = New System.Drawing.Point(5, 155)
        Me.cboRamo.MostrarBusquedaColumnas = False
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NombreCampo = "IdRamo"
        Me.cboRamo.Obligatorio = False
        Me.cboRamo.Query = "select IdRamo, NombreRamo from RamoSeguros"
        Me.cboRamo.SelectIndex = 0
        Me.cboRamo.Size = New System.Drawing.Size(417, 20)
        Me.cboRamo.SoloLectura = False
        Me.cboRamo.StringConection = ""
        Me.cboRamo.TabIndex = 32
        Me.cboRamo.TextoNuevoItem = ""
        Me.cboRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRamo.Valor = ""
        '
        'PivotGridField28
        '
        Me.PivotGridField28.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField28.AreaIndex = 22
        Me.PivotGridField28.Caption = "Clase Siniestro"
        Me.PivotGridField28.FieldName = "ClaseSiniestro"
        Me.PivotGridField28.Name = "PivotGridField28"
        '
        'repReclamosFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(818, 552)
        Me.Controls.Add(Me.cboRamo)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.PivotReclamos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "repReclamosFechas"
        Me.Text = "Reporte de Reclamos"
        Me.Controls.SetChildIndex(Me.PivotReclamos, 0)
        Me.Controls.SetChildIndex(Me.txtDesde, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtHasta, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboRamo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotReclamos As DevExpress.XtraPivotGrid.PivotGridControl
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
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField21 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField22 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField23 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField24 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField25 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField26 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtDesde As STIControles.stiTextBox
    Friend WithEvents txtHasta As STIControles.stiTextBox
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PivotGridField27 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboRamo As STIControles.stiComboBox
    Friend WithEvents PivotGridField28 As DevExpress.XtraPivotGrid.PivotGridField

End Class
