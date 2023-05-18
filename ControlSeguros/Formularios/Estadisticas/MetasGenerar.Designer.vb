<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetasGenerar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetasGenerar))
        Me.txtAnio = New STIControles.stiTextBox
        Me.GridRamos = New STIControles.stiGrid
        Me.VistaRamos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColMeta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIncluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colComi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridEjecutivos = New STIControles.stiGrid
        Me.VistaEjecutivos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Colnombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIncluirU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaRamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEjecutivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEjecutivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(456, 387)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(353, 387)
        Me.btnImprimir.Text = "&Generar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(559, 387)
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
        Me.LabelControl1.Size = New System.Drawing.Size(525, 74)
        Me.LabelControl1.Text = "Generador de Metas"
        '
        'txtAnio
        '
        Me.txtAnio.CampoBusqueda = False
        Me.txtAnio.CampoEsLlave = False
        Me.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAnio.ControlBackColor = System.Drawing.Color.White
        Me.txtAnio.ControlForeColor = System.Drawing.Color.Black
        Me.txtAnio.FechaActual = False
        Me.txtAnio.Formato = "####0"
        Me.txtAnio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAnio.LabelText = "Año"
        Me.txtAnio.LabelWidth = 100
        Me.txtAnio.Location = New System.Drawing.Point(12, 80)
        Me.txtAnio.MaxLength = 0
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.NombreCampo = ""
        Me.txtAnio.Obligatorio = True
        Me.txtAnio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAnio.Size = New System.Drawing.Size(300, 20)
        Me.txtAnio.SoloLectura = False
        Me.txtAnio.TabIndex = 17
        Me.txtAnio.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAnio.Valor = 0
        '
        'GridRamos
        '
        Me.GridRamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRamos.Location = New System.Drawing.Point(5, 106)
        Me.GridRamos.MainView = Me.VistaRamos
        Me.GridRamos.Name = "GridRamos"
        Me.GridRamos.NombreTabla = ""
        Me.GridRamos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridRamos.Size = New System.Drawing.Size(651, 143)
        Me.GridRamos.TabIndex = 18
        Me.GridRamos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaRamos})
        '
        'VistaRamos
        '
        Me.VistaRamos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdRamo, Me.colNombreRamo, Me.ColMeta, Me.colIncluir, Me.colComi})
        Me.VistaRamos.GridControl = Me.GridRamos
        Me.VistaRamos.Name = "VistaRamos"
        Me.VistaRamos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaRamos.OptionsView.ShowFooter = True
        Me.VistaRamos.OptionsView.ShowGroupPanel = False
        '
        'ColIdRamo
        '
        Me.ColIdRamo.Caption = "IdRamo"
        Me.ColIdRamo.FieldName = "IdRamo"
        Me.ColIdRamo.Name = "ColIdRamo"
        Me.ColIdRamo.Visible = True
        Me.ColIdRamo.VisibleIndex = 0
        Me.ColIdRamo.Width = 77
        '
        'colNombreRamo
        '
        Me.colNombreRamo.Caption = "Nombre Ramo"
        Me.colNombreRamo.FieldName = "NombreRamo"
        Me.colNombreRamo.Name = "colNombreRamo"
        Me.colNombreRamo.Visible = True
        Me.colNombreRamo.VisibleIndex = 1
        Me.colNombreRamo.Width = 190
        '
        'ColMeta
        '
        Me.ColMeta.Caption = "Meta Prima Anual"
        Me.ColMeta.DisplayFormat.FormatString = "c"
        Me.ColMeta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColMeta.FieldName = "Meta"
        Me.ColMeta.Name = "ColMeta"
        Me.ColMeta.SummaryItem.DisplayFormat = "{0:c}"
        Me.ColMeta.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.ColMeta.Visible = True
        Me.ColMeta.VisibleIndex = 2
        Me.ColMeta.Width = 107
        '
        'colIncluir
        '
        Me.colIncluir.Caption = "Incluir"
        Me.colIncluir.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colIncluir.FieldName = "Incluir"
        Me.colIncluir.Name = "colIncluir"
        Me.colIncluir.Visible = True
        Me.colIncluir.VisibleIndex = 4
        Me.colIncluir.Width = 136
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colComi
        '
        Me.colComi.Caption = "Meta Comisión Anual"
        Me.colComi.DisplayFormat.FormatString = "c"
        Me.colComi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComi.FieldName = "Comision"
        Me.colComi.Name = "colComi"
        Me.colComi.SummaryItem.DisplayFormat = "{0:c}"
        Me.colComi.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colComi.Visible = True
        Me.colComi.VisibleIndex = 3
        Me.colComi.Width = 120
        '
        'GridEjecutivos
        '
        Me.GridEjecutivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEjecutivos.Location = New System.Drawing.Point(5, 255)
        Me.GridEjecutivos.MainView = Me.VistaEjecutivos
        Me.GridEjecutivos.Name = "GridEjecutivos"
        Me.GridEjecutivos.NombreTabla = ""
        Me.GridEjecutivos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridEjecutivos.Size = New System.Drawing.Size(657, 126)
        Me.GridEjecutivos.TabIndex = 19
        Me.GridEjecutivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaEjecutivos})
        '
        'VistaEjecutivos
        '
        Me.VistaEjecutivos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUsuario, Me.Colnombre, Me.colIncluirU})
        Me.VistaEjecutivos.GridControl = Me.GridEjecutivos
        Me.VistaEjecutivos.Name = "VistaEjecutivos"
        Me.VistaEjecutivos.OptionsView.ShowGroupPanel = False
        '
        'ColUsuario
        '
        Me.ColUsuario.Caption = "Usuario"
        Me.ColUsuario.FieldName = "Usuario"
        Me.ColUsuario.Name = "ColUsuario"
        Me.ColUsuario.Visible = True
        Me.ColUsuario.VisibleIndex = 0
        Me.ColUsuario.Width = 161
        '
        'Colnombre
        '
        Me.Colnombre.Caption = "Nombre Ejecutivo de Cuenta"
        Me.Colnombre.FieldName = "Nombre"
        Me.Colnombre.Name = "Colnombre"
        Me.Colnombre.Visible = True
        Me.Colnombre.VisibleIndex = 1
        Me.Colnombre.Width = 335
        '
        'colIncluirU
        '
        Me.colIncluirU.Caption = "Incluir"
        Me.colIncluirU.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colIncluirU.FieldName = "Incluir"
        Me.colIncluirU.Name = "colIncluirU"
        Me.colIncluirU.Visible = True
        Me.colIncluirU.VisibleIndex = 2
        Me.colIncluirU.Width = 140
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'MetasGenerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 701
        Me.ClientSize = New System.Drawing.Size(662, 425)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.GridRamos)
        Me.Controls.Add(Me.GridEjecutivos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "MetasGenerar"
        Me.Text = "Metas..."
        Me.Controls.SetChildIndex(Me.GridEjecutivos, 0)
        Me.Controls.SetChildIndex(Me.GridRamos, 0)
        Me.Controls.SetChildIndex(Me.txtAnio, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaRamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEjecutivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEjecutivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAnio As STIControles.stiTextBox
    Friend WithEvents GridRamos As STIControles.stiGrid
    Friend WithEvents VistaRamos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColMeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIncluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridEjecutivos As STIControles.stiGrid
    Friend WithEvents VistaEjecutivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Colnombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIncluirU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colComi As DevExpress.XtraGrid.Columns.GridColumn

End Class
