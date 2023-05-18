<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiniestralidadClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiniestralidadClientes))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode5 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridSiniestralidad = New STIControles.stiGrid
        Me.DsSiniestralidadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSiniestralidad = New Sisco.dsSiniestralidad
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.VistaSiniestralidad = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PolizasFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PolizasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PolizasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.DsSiniestralidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSiniestralidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSiniestralidadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSiniestralidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaSiniestralidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolizasFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolizasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolizasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSiniestralidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(495, 404)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(392, 404)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(598, 404)
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
        Me.LabelControl1.Size = New System.Drawing.Size(564, 74)
        Me.LabelControl1.Text = "Análisis de Siniestralidad de Clientes"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13})
        Me.GridView2.GridControl = Me.GridSiniestralidad
        Me.GridView2.Name = "GridView2"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "IdProducto"
        Me.GridColumn13.FieldName = "IdProducto"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'GridSiniestralidad
        '
        Me.GridSiniestralidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSiniestralidad.ColumnasAdicionales = ""
        Me.GridSiniestralidad.DataSource = Me.DsSiniestralidadBindingSource1
        GridLevelNode2.LevelTemplate = Me.GridView2
        GridLevelNode2.RelationName = "Polizas_Facturas"
        GridLevelNode3.RelationName = "Polizas_Siniestros"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2, GridLevelNode3})
        GridLevelNode1.RelationName = "Polizas"
        GridLevelNode4.LevelTemplate = Me.GridView1
        GridLevelNode4.RelationName = "Facturas"
        GridLevelNode5.RelationName = "Siniestros"
        Me.GridSiniestralidad.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode4, GridLevelNode5})
        Me.GridSiniestralidad.Location = New System.Drawing.Point(5, 136)
        Me.GridSiniestralidad.MainView = Me.VistaSiniestralidad
        Me.GridSiniestralidad.Name = "GridSiniestralidad"
        Me.GridSiniestralidad.NombreTabla = ""
        Me.GridSiniestralidad.Size = New System.Drawing.Size(685, 262)
        Me.GridSiniestralidad.TabIndex = 20
        Me.GridSiniestralidad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.VistaSiniestralidad, Me.GridView2})
        '
        'DsSiniestralidadBindingSource1
        '
        Me.DsSiniestralidadBindingSource1.DataSource = Me.DsSiniestralidad
        Me.DsSiniestralidadBindingSource1.Position = 0
        '
        'DsSiniestralidad
        '
        Me.DsSiniestralidad.DataSetName = "dsSiniestralidad"
        Me.DsSiniestralidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView1.GridControl = Me.GridSiniestralidad
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "IdProducto"
        Me.GridColumn10.FieldName = "IdProducto"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "IdPoliza"
        Me.GridColumn11.FieldName = "IdPoliza"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Factura"
        Me.GridColumn12.FieldName = "NumeroFactura"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'VistaSiniestralidad
        '
        Me.VistaSiniestralidad.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaSiniestralidad.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaSiniestralidad.ColumnPanelRowHeight = 40
        Me.VistaSiniestralidad.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn14, Me.GridColumn15})
        Me.VistaSiniestralidad.GridControl = Me.GridSiniestralidad
        Me.VistaSiniestralidad.GroupCount = 1
        Me.VistaSiniestralidad.Name = "VistaSiniestralidad"
        Me.VistaSiniestralidad.OptionsBehavior.AutoExpandAllGroups = True
        Me.VistaSiniestralidad.OptionsBehavior.Editable = False
        Me.VistaSiniestralidad.OptionsView.ShowFooter = True
        Me.VistaSiniestralidad.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Aseguradora"
        Me.GridColumn1.FieldName = "Aseguradora"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Póliza"
        Me.GridColumn2.FieldName = "IdPoliza"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Producto"
        Me.GridColumn3.FieldName = "Producto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Vigencia Desde"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "VigenciaDesde"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vigencia Hasta"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "VigenciaHasta"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Prima Neta"
        Me.GridColumn6.DisplayFormat.FormatString = "c"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "PrimaNeta"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Reclamos Pagados"
        Me.GridColumn7.DisplayFormat.FormatString = "c"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "ReclamosPagados"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Porcentaje Siniestralidad"
        Me.GridColumn8.DisplayFormat.FormatString = "p"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "PorceSiniestralidad"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.SummaryItem.DisplayFormat = "{0:p}"
        Me.GridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Siniestros Reserva"
        Me.GridColumn9.DisplayFormat.FormatString = "c"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "ReclamosReserva"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Prima Devengada"
        Me.GridColumn14.DisplayFormat.FormatString = "c"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "PrimaDevengada"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn14.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 8
        '
        'PolizasFacturasBindingSource
        '
        Me.PolizasFacturasBindingSource.DataMember = "Polizas_Facturas"
        Me.PolizasFacturasBindingSource.DataSource = Me.PolizasBindingSource1
        '
        'PolizasBindingSource1
        '
        Me.PolizasBindingSource1.DataMember = "Polizas"
        Me.PolizasBindingSource1.DataSource = Me.DsSiniestralidad
        '
        'PolizasBindingSource
        '
        Me.PolizasBindingSource.DataMember = "Polizas"
        Me.PolizasBindingSource.DataSource = Me.DsSiniestralidad
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(368, 80)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarCliente.TabIndex = 17
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(5, 84)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = True
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(357, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 18
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txtNombreCliente.Location = New System.Drawing.Point(5, 110)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(685, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 19
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'DsSiniestralidadBindingSource
        '
        Me.DsSiniestralidadBindingSource.DataSource = Me.DsSiniestralidad
        Me.DsSiniestralidadBindingSource.Position = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Días Devengados"
        Me.GridColumn15.DisplayFormat.FormatString = "n0"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "DiasDev"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 9
        '
        'SiniestralidadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 709
        Me.ClientSize = New System.Drawing.Size(701, 442)
        Me.Controls.Add(Me.GridSiniestralidad)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "SiniestralidadClientes"
        Me.Text = "Siniestralidad"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.GridSiniestralidad, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSiniestralidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSiniestralidadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSiniestralidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaSiniestralidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolizasFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolizasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolizasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSiniestralidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents GridSiniestralidad As STIControles.stiGrid
    Friend WithEvents VistaSiniestralidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PolizasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSiniestralidad As Sisco.dsSiniestralidad
    Friend WithEvents DsSiniestralidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PolizasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PolizasFacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSiniestralidadBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn

End Class
