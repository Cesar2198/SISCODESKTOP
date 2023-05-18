<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticasPolizas
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
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField1, Me.PivotGridField6, Me.PivotGridField8, Me.PivotGridField12, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField5, Me.PivotGridField7, Me.PivotGridField9, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17})
        Me.PivotGridControl1.Location = New System.Drawing.Point(2, 41)
        Me.PivotGridControl1.LookAndFeel.SkinName = "The Asphalt World"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(757, 313)
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
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Mes"
        Me.PivotGridField3.FieldName = "Mes"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.Caption = "Ramo"
        Me.PivotGridField4.FieldName = "Ramo"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Width = 200
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField1.AreaIndex = 3
        Me.PivotGridField1.Caption = "Aseguradora"
        Me.PivotGridField1.FieldName = "Cia"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField6.AreaIndex = 2
        Me.PivotGridField6.Caption = "Cliente"
        Me.PivotGridField6.FieldName = "Cliente"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.Width = 150
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 6
        Me.PivotGridField8.Caption = "Ejecutivo de Cuenta"
        Me.PivotGridField8.FieldName = "Director"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.Width = 150
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField12.AreaIndex = 5
        Me.PivotGridField12.Caption = "Vendedor"
        Me.PivotGridField12.FieldName = "Vendedor"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 1
        Me.PivotGridField10.Caption = "Producto"
        Me.PivotGridField10.FieldName = "Grupo"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField11.AreaIndex = 4
        Me.PivotGridField11.Caption = "Tipo Cliente"
        Me.PivotGridField11.FieldName = "TipoCliente"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Núm. Pólizas"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.FieldName = "NumPolizas"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 1
        Me.PivotGridField7.Caption = "Num. Siniestros"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.FieldName = "NumSiniestros"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField9.AreaIndex = 7
        Me.PivotGridField9.Caption = "Estado Póliza"
        Me.PivotGridField9.FieldName = "Estado"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField13.AreaIndex = 8
        Me.PivotGridField13.Caption = "%Participación Pólizas"
        Me.PivotGridField13.CellFormat.FormatString = "p"
        Me.PivotGridField13.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField13.FieldName = "ParticipaPol"
        Me.PivotGridField13.Name = "PivotGridField13"
        Me.PivotGridField13.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'PivotGridField14
        '
        Me.PivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField14.AreaIndex = 9
        Me.PivotGridField14.Caption = "%Participación Siniestros"
        Me.PivotGridField14.CellFormat.FormatString = "p"
        Me.PivotGridField14.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField14.FieldName = "ParticipaSin"
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'lblFiltro
        '
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFiltro.Location = New System.Drawing.Point(0, 19)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(760, 19)
        Me.lblFiltro.TabIndex = 5
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
        Me.lblNombre.Size = New System.Drawing.Size(760, 19)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "ESTADISTICAS DE NUMERO DE POLIZAS Y SINIESTROS"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField15.AreaIndex = 10
        Me.PivotGridField15.Caption = "Primas"
        Me.PivotGridField15.CellFormat.FormatString = "c"
        Me.PivotGridField15.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField15.FieldName = "Primas"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField16.AreaIndex = 11
        Me.PivotGridField16.Caption = "Siniestros"
        Me.PivotGridField16.CellFormat.FormatString = "c"
        Me.PivotGridField16.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField16.FieldName = "Siniestros"
        Me.PivotGridField16.Name = "PivotGridField16"
        '
        'PivotGridField17
        '
        Me.PivotGridField17.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField17.AreaIndex = 12
        Me.PivotGridField17.Caption = "Póliza"
        Me.PivotGridField17.FieldName = "IdPoliza"
        Me.PivotGridField17.Name = "PivotGridField17"
        '
        'EstadisticasPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 354)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "EstadisticasPolizas"
        Me.Text = "Estadísticas de Pólizas y Siniestros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
End Class
