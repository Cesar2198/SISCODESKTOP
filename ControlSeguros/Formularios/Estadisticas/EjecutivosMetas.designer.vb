<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EjecutivosMetas
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
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 2
        Me.PivotGridField7.Caption = "Cumplimiento"
        Me.PivotGridField7.CellFormat.FormatString = "p2"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.PivotGridField7.FieldName = "Cumplimiento"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField9.AreaIndex = 3
        Me.PivotGridField9.Caption = "Diferencia"
        Me.PivotGridField9.CellFormat.FormatString = "c"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.FieldName = "Diferencia"
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.PivotGridField9.Width = 86
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.AccessibleName = ""
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField8, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11})
        PivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        PivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Maroon
        PivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition1.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        PivotGridStyleFormatCondition1.Field = Me.PivotGridField7
        PivotGridStyleFormatCondition1.FieldName = "PivotGridField7"
        PivotGridStyleFormatCondition1.Value1 = 1
        PivotGridStyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition2.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition2.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        PivotGridStyleFormatCondition2.Field = Me.PivotGridField7
        PivotGridStyleFormatCondition2.FieldName = "PivotGridField7"
        PivotGridStyleFormatCondition2.Value1 = 1
        PivotGridStyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        PivotGridStyleFormatCondition3.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition3.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        PivotGridStyleFormatCondition3.Field = Me.PivotGridField9
        PivotGridStyleFormatCondition3.FieldName = "PivotGridField9"
        PivotGridStyleFormatCondition3.Value1 = "0"
        PivotGridStyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PivotGridStyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PivotGridStyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Green
        PivotGridStyleFormatCondition4.Appearance.Options.UseBackColor = True
        PivotGridStyleFormatCondition4.Appearance.Options.UseFont = True
        PivotGridStyleFormatCondition4.Appearance.Options.UseForeColor = True
        PivotGridStyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        PivotGridStyleFormatCondition4.Field = Me.PivotGridField9
        PivotGridStyleFormatCondition4.FieldName = "PivotGridField9"
        PivotGridStyleFormatCondition4.Value1 = "0"
        Me.PivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {PivotGridStyleFormatCondition1, PivotGridStyleFormatCondition2, PivotGridStyleFormatCondition3, PivotGridStyleFormatCondition4})
        Me.PivotGridControl1.Location = New System.Drawing.Point(1, 41)
        Me.PivotGridControl1.LookAndFeel.SkinName = "The Asphalt World"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(897, 388)
        Me.PivotGridControl1.TabIndex = 2
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Año"
        Me.PivotGridField2.FieldName = "Anio"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Mes"
        Me.PivotGridField3.FieldName = "Mes"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField4.AreaIndex = 2
        Me.PivotGridField4.Caption = "Ramo"
        Me.PivotGridField4.FieldName = "Ramo"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Width = 150
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Prima"
        Me.PivotGridField5.FieldName = "Prima"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.Width = 96
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField8.AreaIndex = 1
        Me.PivotGridField8.Caption = "Ejecutivo Cuenta"
        Me.PivotGridField8.FieldName = "Director"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.Width = 150
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField6.AreaIndex = 1
        Me.PivotGridField6.Caption = "Meta"
        Me.PivotGridField6.FieldName = "Meta"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.Width = 89
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 0
        Me.PivotGridField10.Caption = "Tipo Producto"
        Me.PivotGridField10.FieldName = "Cia"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField11.AreaIndex = 1
        Me.PivotGridField11.Caption = "Producto"
        Me.PivotGridField11.FieldName = "Grupo"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'lblFiltro
        '
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFiltro.Location = New System.Drawing.Point(0, 19)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(899, 19)
        Me.lblFiltro.TabIndex = 7
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
        Me.lblNombre.Size = New System.Drawing.Size(899, 19)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "ESTADISTICAS PRESUPUESTOS Y METAS DE PRIMAS"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EjecutivosMetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 430)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "EjecutivosMetas"
        Me.Text = "Estadísticas Metas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
End Class
