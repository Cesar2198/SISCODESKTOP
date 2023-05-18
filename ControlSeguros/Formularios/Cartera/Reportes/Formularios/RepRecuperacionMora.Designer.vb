<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepRecuperacionMora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepRecuperacionMora))
        Me.btnBuscaIngresos = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaPrima = New STIControles.stiTextBox
        Me.txtFechaPago = New STIControles.stiTextBox
        Me.GridMora = New DevExpress.XtraPivotGrid.PivotGridControl
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
        Me.chkGestiones = New DevExpress.XtraEditors.CheckEdit
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGestiones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(468, 296)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(365, 296)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(571, 296)
        Me.btnSalir.TabIndex = 6
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
        Me.LabelControl1.Size = New System.Drawing.Size(537, 74)
        Me.LabelControl1.Text = "Reporte Recuperación Mora"
        '
        'btnBuscaIngresos
        '
        Me.btnBuscaIngresos.Image = CType(resources.GetObject("btnBuscaIngresos.Image"), System.Drawing.Image)
        Me.btnBuscaIngresos.Location = New System.Drawing.Point(510, 77)
        Me.btnBuscaIngresos.Name = "btnBuscaIngresos"
        Me.btnBuscaIngresos.Size = New System.Drawing.Size(133, 27)
        Me.btnBuscaIngresos.TabIndex = 2
        Me.btnBuscaIngresos.Text = "Buscar Ingresos"
        '
        'txtFechaPrima
        '
        Me.txtFechaPrima.CampoBusqueda = False
        Me.txtFechaPrima.CampoEsLlave = False
        Me.txtFechaPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPrima.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaPrima.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPrima.FechaActual = False
        Me.txtFechaPrima.Formato = "dd/MMM/yyyy"
        Me.txtFechaPrima.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPrima.LabelText = "Corte de Mora"
        Me.txtFechaPrima.LabelWidth = 85
        Me.txtFechaPrima.Location = New System.Drawing.Point(14, 80)
        Me.txtFechaPrima.MaxLength = 0
        Me.txtFechaPrima.Name = "txtFechaPrima"
        Me.txtFechaPrima.NombreCampo = ""
        Me.txtFechaPrima.Obligatorio = False
        Me.txtFechaPrima.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPrima.Size = New System.Drawing.Size(243, 20)
        Me.txtFechaPrima.SoloLectura = False
        Me.txtFechaPrima.TabIndex = 0
        Me.txtFechaPrima.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPrima.Valor = Nothing
        '
        'txtFechaPago
        '
        Me.txtFechaPago.CampoBusqueda = False
        Me.txtFechaPago.CampoEsLlave = False
        Me.txtFechaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPago.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPago.FechaActual = False
        Me.txtFechaPago.Formato = "dd/MMM/yyyy"
        Me.txtFechaPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPago.LabelText = "Corte de Pagos"
        Me.txtFechaPago.LabelWidth = 85
        Me.txtFechaPago.Location = New System.Drawing.Point(263, 80)
        Me.txtFechaPago.MaxLength = 0
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.NombreCampo = ""
        Me.txtFechaPago.Obligatorio = False
        Me.txtFechaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPago.Size = New System.Drawing.Size(241, 20)
        Me.txtFechaPago.SoloLectura = False
        Me.txtFechaPago.TabIndex = 1
        Me.txtFechaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPago.Valor = Nothing
        '
        'GridMora
        '
        Me.GridMora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMora.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridMora.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12})
        Me.GridMora.Location = New System.Drawing.Point(6, 129)
        Me.GridMora.Name = "GridMora"
        Me.GridMora.Size = New System.Drawing.Size(662, 162)
        Me.GridMora.TabIndex = 4
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Aseguradora"
        Me.PivotGridField1.FieldName = "Aseguradora"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Ramo"
        Me.PivotGridField2.FieldName = "Ramo"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "Producto"
        Me.PivotGridField3.FieldName = "Prodcuto"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.Caption = "Rango Mora"
        Me.PivotGridField4.FieldName = "RangoMora"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Width = 200
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField5.AreaIndex = 4
        Me.PivotGridField5.Caption = "Póliza"
        Me.PivotGridField5.FieldName = "Poliza"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField6.AreaIndex = 3
        Me.PivotGridField6.Caption = "Factura"
        Me.PivotGridField6.FieldName = "Factura"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 0
        Me.PivotGridField7.Caption = "Prima Neta"
        Me.PivotGridField7.FieldName = "PrimaNeta"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 5
        Me.PivotGridField8.Caption = "Gastos"
        Me.PivotGridField8.FieldName = "Gastos"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField9.AreaIndex = 6
        Me.PivotGridField9.Caption = "IVA"
        Me.PivotGridField9.FieldName = "IVA"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 7
        Me.PivotGridField10.Caption = "Total"
        Me.PivotGridField10.FieldName = "Total"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField11.AreaIndex = 8
        Me.PivotGridField11.Caption = "Cliente"
        Me.PivotGridField11.FieldName = "Cliente"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'chkGestiones
        '
        Me.chkGestiones.Location = New System.Drawing.Point(12, 104)
        Me.chkGestiones.Name = "chkGestiones"
        Me.chkGestiones.Properties.Caption = "Únicamente Facturas con Gestiones"
        Me.chkGestiones.Size = New System.Drawing.Size(275, 19)
        Me.chkGestiones.TabIndex = 18
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField12.AreaIndex = 9
        Me.PivotGridField12.Caption = "Tiene Gestión"
        Me.PivotGridField12.FieldName = "TieneGestion"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'RepRecuperacionMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 302
        Me.ClientSize = New System.Drawing.Size(674, 334)
        Me.Controls.Add(Me.chkGestiones)
        Me.Controls.Add(Me.GridMora)
        Me.Controls.Add(Me.btnBuscaIngresos)
        Me.Controls.Add(Me.txtFechaPrima)
        Me.Controls.Add(Me.txtFechaPago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepRecuperacionMora"
        Me.Text = "Reporte Mora..."
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPago, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPrima, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaIngresos, 0)
        Me.Controls.SetChildIndex(Me.GridMora, 0)
        Me.Controls.SetChildIndex(Me.chkGestiones, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGestiones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscaIngresos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaPrima As STIControles.stiTextBox
    Friend WithEvents txtFechaPago As STIControles.stiTextBox
    Friend WithEvents GridMora As DevExpress.XtraPivotGrid.PivotGridControl
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
    Friend WithEvents chkGestiones As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField

End Class
