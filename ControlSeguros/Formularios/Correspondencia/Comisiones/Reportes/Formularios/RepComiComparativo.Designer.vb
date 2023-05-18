<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepComiComparativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepComiComparativo))
        Me.pivotComisiones = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.cboTipoProducto = New STIControles.stiComboBox
        Me.cboRamo = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pivotComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(457, 378)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(354, 378)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(560, 378)
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
        Me.LabelControl1.Size = New System.Drawing.Size(526, 74)
        Me.LabelControl1.Text = "Comparativo de Comisiones"
        '
        'pivotComisiones
        '
        Me.pivotComisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pivotComisiones.Cursor = System.Windows.Forms.Cursors.Default
        Me.pivotComisiones.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6})
        Me.pivotComisiones.Location = New System.Drawing.Point(5, 152)
        Me.pivotComisiones.Name = "pivotComisiones"
        Me.pivotComisiones.Size = New System.Drawing.Size(652, 220)
        Me.pivotComisiones.TabIndex = 18
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Aseguradora"
        Me.PivotGridField1.FieldName = "Aseguradora"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Tipo de Producto"
        Me.PivotGridField2.FieldName = "TipoProducto"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "Ramo"
        Me.PivotGridField3.FieldName = "Ramo"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField4.AreaIndex = 3
        Me.PivotGridField4.Caption = "Producto"
        Me.PivotGridField4.FieldName = "Producto"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Año"
        Me.PivotGridField5.FieldName = "Anio"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField6.AreaIndex = 0
        Me.PivotGridField6.Caption = "Porcentaje Comisión"
        Me.PivotGridField6.CellFormat.FormatString = "p"
        Me.PivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.FieldName = "Porcentaje"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        Me.PivotGridField6.TotalCellFormat.FormatString = "p"
        Me.PivotGridField6.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.TotalValueFormat.FormatString = "p"
        Me.PivotGridField6.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField6.ValueFormat.FormatString = "p"
        Me.PivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(531, 80)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(127, 66)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.Text = "Buscar Comisiones"
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = False
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = False
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 7
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 100
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(5, 78)
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = ""
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select idaseguradora as Id, nombre as Aseguradora from Aseguradoras"
        Me.cboAseguradora.SelectIndex = -1
        Me.cboAseguradora.Size = New System.Drawing.Size(510, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 20
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.CampoAutoCompletar = 0
        Me.cboTipoProducto.CampoBusqueda = False
        Me.cboTipoProducto.CampoDisplay = 1
        Me.cboTipoProducto.CampoEsLlave = False
        Me.cboTipoProducto.CampoValor = 0
        Me.cboTipoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoProducto.FilasVisibles = 7
        Me.cboTipoProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoProducto.LabelText = "Tipo Producto"
        Me.cboTipoProducto.LabelWidth = 100
        Me.cboTipoProducto.Lista = "VIDA Seguro de Vida y Gastos Médicos|DAÑOS Seguro de Daños"
        Me.cboTipoProducto.Location = New System.Drawing.Point(5, 101)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.NombreCampo = ""
        Me.cboTipoProducto.Obligatorio = False
        Me.cboTipoProducto.Query = ""
        Me.cboTipoProducto.SelectIndex = -1
        Me.cboTipoProducto.Size = New System.Drawing.Size(510, 20)
        Me.cboTipoProducto.SoloLectura = False
        Me.cboTipoProducto.StringConection = ""
        Me.cboTipoProducto.TabIndex = 21
        Me.cboTipoProducto.TextoNuevoItem = ""
        Me.cboTipoProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoProducto.Valor = ""
        '
        'cboRamo
        '
        Me.cboRamo.CampoAutoCompletar = 0
        Me.cboRamo.CampoBusqueda = False
        Me.cboRamo.CampoDisplay = 1
        Me.cboRamo.CampoEsLlave = False
        Me.cboRamo.CampoValor = 0
        Me.cboRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboRamo.FilasVisibles = 7
        Me.cboRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRamo.LabelText = "Ramo"
        Me.cboRamo.LabelWidth = 100
        Me.cboRamo.Lista = ""
        Me.cboRamo.Location = New System.Drawing.Point(5, 124)
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NombreCampo = ""
        Me.cboRamo.Obligatorio = False
        Me.cboRamo.Query = "select IdRamo, NombreRamo from RamoSeguros"
        Me.cboRamo.SelectIndex = -1
        Me.cboRamo.Size = New System.Drawing.Size(510, 20)
        Me.cboRamo.SoloLectura = False
        Me.cboRamo.StringConection = ""
        Me.cboRamo.TabIndex = 22
        Me.cboRamo.TextoNuevoItem = ""
        Me.cboRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRamo.Valor = ""
        '
        'RepComiComparativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(663, 416)
        Me.Controls.Add(Me.cboRamo)
        Me.Controls.Add(Me.cboTipoProducto)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.pivotComisiones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepComiComparativo"
        Me.Controls.SetChildIndex(Me.pivotComisiones, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.cboTipoProducto, 0)
        Me.Controls.SetChildIndex(Me.cboRamo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pivotComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pivotComisiones As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Friend WithEvents cboTipoProducto As STIControles.stiComboBox
    Friend WithEvents cboRamo As STIControles.stiComboBox

End Class
