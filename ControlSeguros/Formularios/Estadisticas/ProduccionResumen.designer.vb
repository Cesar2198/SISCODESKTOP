<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProduccionResumen
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRamo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField2, Me.PivotGridField3, Me.fieldRamo, Me.PivotGridField5, Me.PivotGridField1, Me.PivotGridField6, Me.PivotGridField4, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9})
        Me.PivotGridControl1.Location = New System.Drawing.Point(-1, 41)
        Me.PivotGridControl1.LookAndFeel.SkinName = "The Asphalt World"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotGridControl1.Size = New System.Drawing.Size(788, 279)
        Me.PivotGridControl1.TabIndex = 1
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
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.Caption = "Mes"
        Me.PivotGridField3.FieldName = "Mes"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        Me.PivotGridField3.UnboundFieldName = "PivotGridField3"
        '
        'fieldRamo
        '
        Me.fieldRamo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRamo.AreaIndex = 1
        Me.fieldRamo.Caption = "Ramo"
        Me.fieldRamo.FieldName = "Ramo"
        Me.fieldRamo.GrandTotalText = "DIFERENCIA"
        Me.fieldRamo.Name = "fieldRamo"
        Me.fieldRamo.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
        Me.fieldRamo.Width = 200
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Prima"
        Me.PivotGridField5.CellFormat.FormatString = "c"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.FieldName = "Prima"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Aseguradora"
        Me.PivotGridField1.FieldName = "Cia"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField6.AreaIndex = 0
        Me.PivotGridField6.Caption = "Producto"
        Me.PivotGridField6.FieldName = "Grupo"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField4.AreaIndex = 2
        Me.PivotGridField4.Caption = "Comisión Potencial"
        Me.PivotGridField4.CellFormat.FormatString = "c"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldName = "Comision"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 1
        Me.PivotGridField7.Caption = "Siniestros"
        Me.PivotGridField7.CellFormat.FormatString = "c"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.FieldName = "Siniestros"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 3
        Me.PivotGridField8.Caption = "%Variación Prima"
        Me.PivotGridField8.CellFormat.FormatString = "p"
        Me.PivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField8.FieldName = "Variacion"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'lblNombre
        '
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(0, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(785, 19)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "ESTADISTICAS PRIMAS ACUMULADAS POR AÑO"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFiltro
        '
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFiltro.Location = New System.Drawing.Point(0, 19)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(785, 19)
        Me.lblFiltro.TabIndex = 3
        Me.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField9.AreaIndex = 2
        Me.PivotGridField9.Caption = "% Siniestralidad"
        Me.PivotGridField9.CellFormat.FormatString = "p"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.FieldName = "Siniestralidad"
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'ProduccionResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 319)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "ProduccionResumen"
        Me.Text = "Estadísticas Generales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRamo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
End Class
