<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repOfertasPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repOfertasPendientes))
        Me.GridOfertas = New STIControles.stiGrid
        Me.VistaOfertas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnBuscarOfertas = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaFinal = New STIControles.stiTextBox
        Me.txtFechaInicial = New STIControles.stiTextBox
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOfertas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaOfertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(548, 348)
        Me.btnAyuda.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(445, 348)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(651, 348)
        Me.btnSalir.TabIndex = 5
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
        Me.LabelControl1.Size = New System.Drawing.Size(617, 74)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Reporte de Ofertas"
        '
        'GridOfertas
        '
        Me.GridOfertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOfertas.ColumnasAdicionales = ""
        Me.GridOfertas.Location = New System.Drawing.Point(4, 108)
        Me.GridOfertas.MainView = Me.VistaOfertas
        Me.GridOfertas.Name = "GridOfertas"
        Me.GridOfertas.NombreTabla = ""
        Me.GridOfertas.Size = New System.Drawing.Size(748, 234)
        Me.GridOfertas.TabIndex = 2
        Me.GridOfertas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaOfertas})
        '
        'VistaOfertas
        '
        Me.VistaOfertas.ColumnPanelRowHeight = 40
        Me.VistaOfertas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn8, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20})
        Me.VistaOfertas.GridControl = Me.GridOfertas
        Me.VistaOfertas.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumaAsegurada", Me.GridColumn11, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrimaAnual", Me.GridColumn12, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cliente", Me.GridColumn4, "SUB-TOTAL")})
        Me.VistaOfertas.Name = "VistaOfertas"
        Me.VistaOfertas.OptionsBehavior.Editable = False
        Me.VistaOfertas.OptionsView.ColumnAutoWidth = False
        Me.VistaOfertas.OptionsView.ShowFooter = True
        Me.VistaOfertas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.Caption = "Oferta"
        Me.GridColumn1.FieldName = "Oferta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 77
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.Caption = "Ramo"
        Me.GridColumn2.FieldName = "Ramo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 105
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn3.Caption = "Producto"
        Me.GridColumn3.FieldName = "Producto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 108
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn4.Caption = "Cliente"
        Me.GridColumn4.FieldName = "Cliente"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 172
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.Caption = "Fecha Solicitud"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "FechaOferta"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 117
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn6.Caption = "Ejecutivo de Cta."
        Me.GridColumn6.FieldName = "Ejecutivo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 139
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn7.Caption = "Producto"
        Me.GridColumn7.FieldName = "IdProducto"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn9.Caption = "Vendedor"
        Me.GridColumn9.FieldName = "Vendedor"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn10.Caption = "Cliente Nuevo"
        Me.GridColumn10.FieldName = "ClienteNuevo"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowShowHide = False
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn11.Caption = "Suma Asegurada"
        Me.GridColumn11.DisplayFormat.FormatString = "c"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "SumaAsegurada"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn12.Caption = "Prima Anual"
        Me.GridColumn12.DisplayFormat.FormatString = "c"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "PrimaAnual"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn12.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn13.Caption = "Aseguradora"
        Me.GridColumn13.FieldName = "Aseguradora"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn14.Caption = "Forma de Pago"
        Me.GridColumn14.FieldName = "FormaPago"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowShowHide = False
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn15.Caption = "Número Cuotas"
        Me.GridColumn15.FieldName = "NumeroCuotas"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowShowHide = False
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn16.Caption = "Fecha Envío Oferta"
        Me.GridColumn16.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn16.FieldName = "FechaEnvio"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowShowHide = False
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn17.Caption = "Estado Oferta"
        Me.GridColumn17.FieldName = "Estado"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn8.Caption = "Seguimiento Y Observaciones"
        Me.GridColumn8.FieldName = "Seguimiento"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowShowHide = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Ejecutivo Solicita Oferta"
        Me.GridColumn18.FieldName = "EjecutivoSolicita"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Observaciones"
        Me.GridColumn19.FieldName = "ObservacionesRenovacion"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'btnBuscarOfertas
        '
        Me.btnBuscarOfertas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarOfertas.Image = CType(resources.GetObject("btnBuscarOfertas.Image"), System.Drawing.Image)
        Me.btnBuscarOfertas.Location = New System.Drawing.Point(597, 77)
        Me.btnBuscarOfertas.Name = "btnBuscarOfertas"
        Me.btnBuscarOfertas.Size = New System.Drawing.Size(145, 28)
        Me.btnBuscarOfertas.TabIndex = 2
        Me.btnBuscarOfertas.Text = "Buscar Ofertas"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaFinal.CampoBusqueda = False
        Me.txtFechaFinal.CampoEsLlave = False
        Me.txtFechaFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaFinal.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaFinal.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaFinal.FechaActual = False
        Me.txtFechaFinal.Formato = "dd/MMM/yyyy"
        Me.txtFechaFinal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaFinal.LabelText = "Fecha Final"
        Me.txtFechaFinal.LabelWidth = 100
        Me.txtFechaFinal.Location = New System.Drawing.Point(342, 80)
        Me.txtFechaFinal.MaxLength = 0
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NombreCampo = ""
        Me.txtFechaFinal.Obligatorio = True
        Me.txtFechaFinal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaFinal.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaFinal.SoloLectura = False
        Me.txtFechaFinal.TabIndex = 1
        Me.txtFechaFinal.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaFinal.Valor = Nothing
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaInicial.CampoBusqueda = False
        Me.txtFechaInicial.CampoEsLlave = False
        Me.txtFechaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInicial.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaInicial.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInicial.FechaActual = False
        Me.txtFechaInicial.Formato = "dd/MMM/yyyy"
        Me.txtFechaInicial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaInicial.LabelText = "Fecha Inicial"
        Me.txtFechaInicial.LabelWidth = 100
        Me.txtFechaInicial.Location = New System.Drawing.Point(75, 80)
        Me.txtFechaInicial.MaxLength = 0
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NombreCampo = ""
        Me.txtFechaInicial.Obligatorio = True
        Me.txtFechaInicial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInicial.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaInicial.SoloLectura = False
        Me.txtFechaInicial.TabIndex = 0
        Me.txtFechaInicial.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInicial.Valor = Nothing
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Última Gestión Realizada"
        Me.GridColumn20.FieldName = "UltimaGestion"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'repOfertasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 517
        Me.ClientSize = New System.Drawing.Size(754, 386)
        Me.Controls.Add(Me.txtFechaInicial)
        Me.Controls.Add(Me.btnBuscarOfertas)
        Me.Controls.Add(Me.txtFechaFinal)
        Me.Controls.Add(Me.GridOfertas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "repOfertasPendientes"
        Me.Text = "Ofertas Pendientes"
        Me.Controls.SetChildIndex(Me.GridOfertas, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarOfertas, 0)
        Me.Controls.SetChildIndex(Me.txtFechaInicial, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOfertas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaOfertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridOfertas As STIControles.stiGrid
    Friend WithEvents VistaOfertas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscarOfertas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaFinal As STIControles.stiTextBox
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaInicial As STIControles.stiTextBox
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn

End Class
