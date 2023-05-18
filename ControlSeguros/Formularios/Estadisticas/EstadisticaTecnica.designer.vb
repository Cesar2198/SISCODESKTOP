<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticaTecnica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition2 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition3 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition4 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition5 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition6 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition7 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Dim PivotGridStyleFormatCondition8 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField21 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 7
        Me.PivotGridField7.Caption = "% ALCANZADO"
        Me.PivotGridField7.CellFormat.FormatString = "p2"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.PivotGridField7.FieldName = "Cumplimiento"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField7.Width = 84
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField9.AreaIndex = 9
        Me.PivotGridField9.Caption = "POR CUMPLIR"
        Me.PivotGridField9.CellFormat.FormatString = "c"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.FieldName = "Diferencia"
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField9.UnboundFieldName = "Diferencia"
        Me.PivotGridField9.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField9.Width = 95
        '
        'PivotGridField19
        '
        Me.PivotGridField19.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField19.AreaIndex = 10
        Me.PivotGridField19.Caption = "EXCEDENTE"
        Me.PivotGridField19.CellFormat.FormatString = "c"
        Me.PivotGridField19.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField19.FieldName = "Excedente"
        Me.PivotGridField19.Name = "PivotGridField19"
        Me.PivotGridField19.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField19.UnboundFieldName = "Excedente"
        Me.PivotGridField19.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField19.Width = 68
        '
        'PivotGridField20
        '
        Me.PivotGridField20.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField20.AreaIndex = 11
        Me.PivotGridField20.Caption = "NETO"
        Me.PivotGridField20.CellFormat.FormatString = "c"
        Me.PivotGridField20.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField20.FieldName = "Neto"
        Me.PivotGridField20.Name = "PivotGridField20"
        Me.PivotGridField20.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField20.Width = 74
        '
        'PivotGridField18
        '
        Me.PivotGridField18.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField18.AreaIndex = 8
        Me.PivotGridField18.Caption = "PARTICIPACION"
        Me.PivotGridField18.CellFormat.FormatString = "p2"
        Me.PivotGridField18.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.PivotGridField18.FieldName = "Participa"
        Me.PivotGridField18.Name = "PivotGridField18"
        Me.PivotGridField18.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField18.UnboundFieldName = "Participa"
        Me.PivotGridField18.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField18.Width = 92
        '
        'PivotGridField17
        '
        Me.PivotGridField17.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField17.AreaIndex = 4
        Me.PivotGridField17.Caption = "TOTAL"
        Me.PivotGridField17.FieldName = "Total"
        Me.PivotGridField17.Name = "PivotGridField17"
        Me.PivotGridField17.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField17.UnboundFieldName = "Total"
        Me.PivotGridField17.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField17.Width = 70
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField16.AreaIndex = 1
        Me.PivotGridField16.Caption = "PERSONAS"
        Me.PivotGridField16.FieldName = "Personas"
        Me.PivotGridField16.Name = "PivotGridField16"
        Me.PivotGridField16.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField16.Width = 70
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField15.AreaIndex = 2
        Me.PivotGridField15.Caption = "DAÑOS"
        Me.PivotGridField15.FieldName = "Danos"
        Me.PivotGridField15.Name = "PivotGridField15"
        Me.PivotGridField15.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField15.Width = 70
        '
        'PivotGridField14
        '
        Me.PivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField14.AreaIndex = 3
        Me.PivotGridField14.Caption = "FIANZAS"
        Me.PivotGridField14.FieldName = "Fianzas"
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField14.Width = 70
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField13.AreaIndex = 0
        Me.PivotGridField13.Caption = "AUTOS"
        Me.PivotGridField13.FieldName = "Autos"
        Me.PivotGridField13.Name = "PivotGridField13"
        Me.PivotGridField13.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField13.Width = 70
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField12.AreaIndex = 2
        Me.PivotGridField12.Caption = "Grupo"
        Me.PivotGridField12.FieldName = "Grupo2"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField6.AreaIndex = 6
        Me.PivotGridField6.Caption = "PRESUPUESTO"
        Me.PivotGridField6.FieldName = "Meta"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField6.Width = 85
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField8.AreaIndex = 1
        Me.PivotGridField8.Caption = "Director"
        Me.PivotGridField8.FieldName = "Director"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.Width = 150
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField5.AreaIndex = 6
        Me.PivotGridField5.Caption = "Prima"
        Me.PivotGridField5.FieldName = "Prima"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.Visible = False
        Me.PivotGridField5.Width = 96
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "Ramo"
        Me.PivotGridField4.FieldName = "Ramo"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Mes"
        Me.PivotGridField3.FieldName = "Mes"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Año"
        Me.PivotGridField2.FieldName = "Anio"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.Width = 60
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.Cell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.CustomTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PivotGridControl1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.CustomTotalCell.ForeColor = System.Drawing.Color.Blue
        Me.PivotGridControl1.Appearance.CustomTotalCell.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.CustomTotalCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.CustomTotalCell.Options.UseForeColor = True
        Me.PivotGridControl1.Appearance.DataHeaderArea.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.Empty.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.Empty.Options.UseFont = True
        Me.PivotGridControl1.Appearance.ExpandButton.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.ExpandButton.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FieldHeader.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FieldValue.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FieldValueGrandTotal.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FieldValueTotal.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FilterHeaderArea.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FilterHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FilterSeparator.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FilterSeparator.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FocusedCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.GrandTotalCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderArea.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.HeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderFilterButton.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.HeaderFilterButton.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderFilterButtonActive.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.HeaderFilterButtonActive.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseFont = True
        Me.PivotGridControl1.Appearance.Lines.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.Lines.Options.UseFont = True
        Me.PivotGridControl1.Appearance.PrefilterPanel.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.PrefilterPanel.Options.UseFont = True
        Me.PivotGridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.RowHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.SelectedCell.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.SelectedCell.Options.UseFont = True
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField8, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField9, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField21, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Maroon
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        PivotGridStyleFormatCondition1.Field = Me.PivotGridField7
        PivotGridStyleFormatCondition1.FieldName = "PivotGridField7"
        PivotGridStyleFormatCondition1.Value1 = 1
        PivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition2.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        PivotGridStyleFormatCondition2.Field = Me.PivotGridField7
        PivotGridStyleFormatCondition2.FieldName = "PivotGridField7"
        PivotGridStyleFormatCondition2.Value1 = 1
        PivotGridStyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        PivotGridStyleFormatCondition3.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition3.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition3.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        PivotGridStyleFormatCondition3.Field = Me.PivotGridField9
        PivotGridStyleFormatCondition3.FieldName = "PivotGridField9"
        PivotGridStyleFormatCondition3.Value1 = "0"
        PivotGridStyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition4.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition4.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition4.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition4.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        PivotGridStyleFormatCondition4.Field = Me.PivotGridField9
        PivotGridStyleFormatCondition4.FieldName = "PivotGridField9"
        PivotGridStyleFormatCondition4.Value1 = "0"
        PivotGridStyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition5.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition5.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition5.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        PivotGridStyleFormatCondition5.Field = Me.PivotGridField19
        PivotGridStyleFormatCondition5.FieldName = "PivotGridField19"
        PivotGridStyleFormatCondition5.Value1 = "0"
        PivotGridStyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        PivotGridStyleFormatCondition6.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition6.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition6.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        PivotGridStyleFormatCondition6.Field = Me.PivotGridField19
        PivotGridStyleFormatCondition6.FieldName = "PivotGridField19"
        PivotGridStyleFormatCondition6.Value1 = "0"
        PivotGridStyleFormatCondition7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition7.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition7.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition7.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        PivotGridStyleFormatCondition7.Field = Me.PivotGridField20
        PivotGridStyleFormatCondition7.FieldName = "PivotGridField20"
        PivotGridStyleFormatCondition7.Value1 = "0"
        PivotGridStyleFormatCondition8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        PivotGridStyleFormatCondition8.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition8.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition8.ApplyToCustomTotalCell = False
        PivotGridStyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        PivotGridStyleFormatCondition8.Field = Me.PivotGridField20
        PivotGridStyleFormatCondition8.FieldName = "PivotGridField20"
        PivotGridStyleFormatCondition8.Value1 = "0"
        Me.PivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1, PivotGridStyleFormatCondition2, PivotGridStyleFormatCondition3, PivotGridStyleFormatCondition4, PivotGridStyleFormatCondition5, PivotGridStyleFormatCondition6, PivotGridStyleFormatCondition7, PivotGridStyleFormatCondition8})
        Me.PivotGridControl1.Location = New System.Drawing.Point(3, 60)
        Me.PivotGridControl1.LookAndFeel.SkinName = "The Asphalt World"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotGridControl1.OptionsCustomization.AllowDrag = False
        Me.PivotGridControl1.OptionsCustomization.AllowEdit = False
        Me.PivotGridControl1.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl1.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1})
        Me.PivotGridControl1.Size = New System.Drawing.Size(1023, 442)
        Me.PivotGridControl1.TabIndex = 6
        '
        'PivotGridField21
        '
        Me.PivotGridField21.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField21.AreaIndex = 5
        Me.PivotGridField21.Caption = "AÑO ANT."
        Me.PivotGridField21.FieldName = "AnioAnt"
        Me.PivotGridField21.Name = "PivotGridField21"
        Me.PivotGridField21.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField21.UnboundFieldName = "AnioAnt"
        Me.PivotGridField21.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField21.Width = 75
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%"
        Me.RepositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'lblFiltro
        '
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFiltro.Location = New System.Drawing.Point(0, 19)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(1028, 19)
        Me.lblFiltro.TabIndex = 12
        Me.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(0, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(1028, 19)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "ESTADISTICAS PRESUPUESTOS Y METAS DE PRIMAS"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1028, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "* El Presente informe no puede ser personalizado, unicamente puede ser ordenado o" & _
            " filtrado."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstadisticaTecnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 505)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "EstadisticaTecnica"
        Me.Text = "Estadísticas Metas Técnicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PivotGridField21 As DevExpress.XtraPivotGrid.PivotGridField
End Class
