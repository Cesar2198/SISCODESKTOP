<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepIngresosCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepIngresosCaja))
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.GridCaja = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.btnBuscaIngresos = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(440, 354)
        Me.btnAyuda.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(337, 354)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(543, 354)
        Me.btnSalir.TabIndex = 5
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
        Me.LabelControl1.Size = New System.Drawing.Size(509, 74)
        Me.LabelControl1.Text = "Reporte de Ingresos de Caja"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = False
        Me.txtFechaDesde.Formato = "dd/MMM/yyyy"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 75
        Me.txtFechaDesde.Location = New System.Drawing.Point(12, 80)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = False
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(243, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = False
        Me.txtFechaHasta.Formato = "dd/MMM/yyyy"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 75
        Me.txtFechaHasta.Location = New System.Drawing.Point(261, 80)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = False
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(241, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'GridCaja
        '
        Me.GridCaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCaja.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridCaja.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5})
        Me.GridCaja.Location = New System.Drawing.Point(6, 106)
        Me.GridCaja.Name = "GridCaja"
        Me.GridCaja.Size = New System.Drawing.Size(634, 244)
        Me.GridCaja.TabIndex = 6
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Aseguradora"
        Me.PivotGridField1.FieldName = "Asegurador"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.Width = 300
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Tipo de Ingresos"
        Me.PivotGridField2.FieldName = "TipoIngresos"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Fecha Recibos"
        Me.PivotGridField3.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField3.FieldName = "FechaRecibo"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.Caption = "Valor Recibo"
        Me.PivotGridField4.CellFormat.FormatString = "c"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldName = "ValorRecibo"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField5.AreaIndex = 1
        Me.PivotGridField5.Caption = "Recibo"
        Me.PivotGridField5.FieldName = "IdRecibo"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'btnBuscaIngresos
        '
        Me.btnBuscaIngresos.Image = CType(resources.GetObject("btnBuscaIngresos.Image"), System.Drawing.Image)
        Me.btnBuscaIngresos.Location = New System.Drawing.Point(508, 77)
        Me.btnBuscaIngresos.Name = "btnBuscaIngresos"
        Me.btnBuscaIngresos.Size = New System.Drawing.Size(133, 27)
        Me.btnBuscaIngresos.TabIndex = 2
        Me.btnBuscaIngresos.Text = "Buscar Ingresos"
        '
        'RepIngresosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 401
        Me.ClientSize = New System.Drawing.Size(646, 392)
        Me.Controls.Add(Me.btnBuscaIngresos)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.GridCaja)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepIngresosCaja"
        Me.Text = "Reportes Ingresos"
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.GridCaja, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaIngresos, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents GridCaja As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents btnBuscaIngresos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField

End Class
