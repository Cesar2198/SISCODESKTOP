<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolizasHistorico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolizasHistorico))
        Me.GridPoliza = New STIControles.stiGrid
        Me.VistaPoliza = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdHistorico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColVigenciaDesde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaHasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColTotalAsegurado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(436, 308)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(333, 308)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(539, 308)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
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
        Me.LabelControl1.Size = New System.Drawing.Size(505, 74)
        Me.LabelControl1.Text = "Historico de Pólizas"
        '
        'GridPoliza
        '
        Me.GridPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPoliza.Location = New System.Drawing.Point(0, 113)
        Me.GridPoliza.MainView = Me.VistaPoliza
        Me.GridPoliza.Name = "GridPoliza"
        Me.GridPoliza.NombreTabla = ""
        Me.GridPoliza.Size = New System.Drawing.Size(638, 189)
        Me.GridPoliza.TabIndex = 17
        Me.GridPoliza.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPoliza})
        '
        'VistaPoliza
        '
        Me.VistaPoliza.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdHistorico, Me.ColIdPoliza, Me.ColIdProducto, Me.ColCliente, Me.ColVigenciaDesde, Me.colVigenciaHasta, Me.ColTotalAsegurado, Me.colProducto})
        Me.VistaPoliza.GridControl = Me.GridPoliza
        Me.VistaPoliza.Name = "VistaPoliza"
        Me.VistaPoliza.OptionsBehavior.Editable = False
        Me.VistaPoliza.OptionsView.ShowGroupPanel = False
        Me.VistaPoliza.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.ColIdHistorico, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'ColIdHistorico
        '
        Me.ColIdHistorico.Caption = "IdHistorico"
        Me.ColIdHistorico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColIdHistorico.FieldName = "IdHistorico"
        Me.ColIdHistorico.Name = "ColIdHistorico"
        '
        'ColIdPoliza
        '
        Me.ColIdPoliza.Caption = "Póliza"
        Me.ColIdPoliza.FieldName = "IdPoliza"
        Me.ColIdPoliza.Name = "ColIdPoliza"
        Me.ColIdPoliza.Visible = True
        Me.ColIdPoliza.VisibleIndex = 0
        Me.ColIdPoliza.Width = 66
        '
        'ColIdProducto
        '
        Me.ColIdProducto.Caption = "IdProducto"
        Me.ColIdProducto.FieldName = "IdProducto"
        Me.ColIdProducto.Name = "ColIdProducto"
        '
        'ColCliente
        '
        Me.ColCliente.Caption = "Nombre Cliente"
        Me.ColCliente.FieldName = "Cliente"
        Me.ColCliente.Name = "ColCliente"
        Me.ColCliente.Visible = True
        Me.ColCliente.VisibleIndex = 2
        Me.ColCliente.Width = 179
        '
        'ColVigenciaDesde
        '
        Me.ColVigenciaDesde.Caption = "Vigencia Desde"
        Me.ColVigenciaDesde.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.ColVigenciaDesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColVigenciaDesde.FieldName = "VigenciaDesde"
        Me.ColVigenciaDesde.Name = "ColVigenciaDesde"
        Me.ColVigenciaDesde.Visible = True
        Me.ColVigenciaDesde.VisibleIndex = 3
        Me.ColVigenciaDesde.Width = 92
        '
        'colVigenciaHasta
        '
        Me.colVigenciaHasta.Caption = "Vigencia Hasta"
        Me.colVigenciaHasta.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colVigenciaHasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVigenciaHasta.FieldName = "VigenciaHasta"
        Me.colVigenciaHasta.Name = "colVigenciaHasta"
        Me.colVigenciaHasta.Visible = True
        Me.colVigenciaHasta.VisibleIndex = 4
        Me.colVigenciaHasta.Width = 92
        '
        'ColTotalAsegurado
        '
        Me.ColTotalAsegurado.Caption = "Suma Asegurada"
        Me.ColTotalAsegurado.DisplayFormat.FormatString = "c"
        Me.ColTotalAsegurado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColTotalAsegurado.FieldName = "SumaAsegurada"
        Me.ColTotalAsegurado.Name = "ColTotalAsegurado"
        Me.ColTotalAsegurado.Visible = True
        Me.ColTotalAsegurado.VisibleIndex = 5
        Me.ColTotalAsegurado.Width = 102
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 86
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(12, 80)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(111, 27)
        Me.btnBuscaPoliza.TabIndex = 28
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'PolizasHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 529
        Me.ClientSize = New System.Drawing.Size(642, 346)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.GridPoliza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "PolizasHistorico"
        Me.Text = "Pólizas"
        Me.Controls.SetChildIndex(Me.GridPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridPoliza As STIControles.stiGrid
    Friend WithEvents VistaPoliza As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdHistorico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColVigenciaDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalAsegurado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn

End Class
