<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstAnalisisOfertas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstAnalisisOfertas))
        Me.pivotOfertas = New DevExpress.XtraPivotGrid.PivotGridControl
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
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pivotOfertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(565, 353)
        Me.btnAyuda.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(462, 353)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(668, 353)
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
        Me.LabelControl1.Size = New System.Drawing.Size(634, 74)
        Me.LabelControl1.Text = "Análisis de Ofertas"
        '
        'pivotOfertas
        '
        Me.pivotOfertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pivotOfertas.Cursor = System.Windows.Forms.Cursors.Default
        Me.pivotOfertas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17})
        Me.pivotOfertas.Location = New System.Drawing.Point(5, 106)
        Me.pivotOfertas.Name = "pivotOfertas"
        Me.pivotOfertas.Size = New System.Drawing.Size(761, 242)
        Me.pivotOfertas.TabIndex = 18
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Oferta"
        Me.PivotGridField1.FieldName = "IdOferta"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.Caption = "Estado"
        Me.PivotGridField2.FieldName = "Estado"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.Caption = "Fecha Grabación"
        Me.PivotGridField3.CellFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField3.FieldName = "FechaGraba"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField3.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField4.AreaIndex = 2
        Me.PivotGridField4.Caption = "Nombre Cliente"
        Me.PivotGridField4.FieldName = "NombreCliente"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField5.AreaIndex = 3
        Me.PivotGridField5.Caption = "Vig. Desde"
        Me.PivotGridField5.CellFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField5.FieldName = "VigenciaDesde"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField5.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField6.AreaIndex = 4
        Me.PivotGridField6.Caption = "Vig. Hasta"
        Me.PivotGridField6.CellFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField6.FieldName = "VigenciaHasta"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField7.AreaIndex = 5
        Me.PivotGridField7.Caption = "Motivo Rechazo"
        Me.PivotGridField7.CellFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField7.FieldName = "MotivoRechazo"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField7.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 6
        Me.PivotGridField8.Caption = "Fecha Rechazo"
        Me.PivotGridField8.CellFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField8.FieldName = "FechaRechazo"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField8.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField9.AreaIndex = 7
        Me.PivotGridField9.Caption = "Fecha Acepta"
        Me.PivotGridField9.CellFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField9.FieldName = "FechaAcepta"
        Me.PivotGridField9.Name = "PivotGridField9"
        Me.PivotGridField9.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.PivotGridField9.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 8
        Me.PivotGridField10.Caption = "Ejecutivo Cuenta"
        Me.PivotGridField10.FieldName = "EjecutivoCta"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField11.AreaIndex = 9
        Me.PivotGridField11.Caption = "Referido por"
        Me.PivotGridField11.FieldName = "ReferidoPor"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField12.AreaIndex = 10
        Me.PivotGridField12.Caption = "Usuario Graba"
        Me.PivotGridField12.FieldName = "UsuarioGrabacion"
        Me.PivotGridField12.Name = "PivotGridField12"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField13.AreaIndex = 11
        Me.PivotGridField13.Caption = "Usuario Modifica"
        Me.PivotGridField13.FieldName = "UsuarioModificacion"
        Me.PivotGridField13.Name = "PivotGridField13"
        '
        'PivotGridField14
        '
        Me.PivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField14.AreaIndex = 0
        Me.PivotGridField14.Caption = "Contador"
        Me.PivotGridField14.CellFormat.FormatString = "###0"
        Me.PivotGridField14.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField14.FieldName = "Contador"
        Me.PivotGridField14.GrandTotalCellFormat.FormatString = "###0"
        Me.PivotGridField14.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.TotalCellFormat.FormatString = "###0"
        Me.PivotGridField14.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField14.TotalValueFormat.FormatString = "###0"
        Me.PivotGridField14.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField14.UnboundFieldName = "PivotGridField14"
        Me.PivotGridField14.ValueFormat.FormatString = "###0"
        Me.PivotGridField14.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField15.AreaIndex = 12
        Me.PivotGridField15.Caption = "Negocio Por"
        Me.PivotGridField15.FieldName = "NegocioPor"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'PivotGridField16
        '
        Me.PivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField16.AreaIndex = 13
        Me.PivotGridField16.Caption = "Aseguradora"
        Me.PivotGridField16.FieldName = "Aseguradora"
        Me.PivotGridField16.Name = "PivotGridField16"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "dd/MMM/yyyy"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Desde"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(7, 80)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(293, 20)
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
        Me.txtFechaHasta.FechaActual = True
        Me.txtFechaHasta.Formato = "dd/MMM/yyyy"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Hasta"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(326, 80)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(293, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(631, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(106, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Búscar"
        '
        'PivotGridField17
        '
        Me.PivotGridField17.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField17.AreaIndex = 14
        Me.PivotGridField17.Caption = "Bienes a Asegurar"
        Me.PivotGridField17.FieldName = "Bienes"
        Me.PivotGridField17.Name = "PivotGridField17"
        '
        'LstAnalisisOfertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(771, 391)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.pivotOfertas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "LstAnalisisOfertas"
        Me.Text = "Análisis de Ofertas"
        Me.Controls.SetChildIndex(Me.pivotOfertas, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pivotOfertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pivotOfertas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField

End Class
