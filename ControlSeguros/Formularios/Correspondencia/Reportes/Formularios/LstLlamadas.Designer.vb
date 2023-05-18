<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstLlamadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstLlamadas))
        Me.PivotLlamadas = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.txtDesde = New STIControles.stiTextBox
        Me.txtHasta = New STIControles.stiTextBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotLlamadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 380)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(373, 380)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(579, 380)
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
        Me.LabelControl1.Size = New System.Drawing.Size(545, 74)
        Me.LabelControl1.Text = "Reporte de Registro de Llamadas"
        '
        'PivotLlamadas
        '
        Me.PivotLlamadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotLlamadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotLlamadas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12})
        Me.PivotLlamadas.Location = New System.Drawing.Point(5, 107)
        Me.PivotLlamadas.Name = "PivotLlamadas"
        Me.PivotLlamadas.Size = New System.Drawing.Size(673, 267)
        Me.PivotLlamadas.TabIndex = 18
        '
        'txtDesde
        '
        Me.txtDesde.CampoBusqueda = False
        Me.txtDesde.CampoEsLlave = False
        Me.txtDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtDesde.FechaActual = False
        Me.txtDesde.Formato = "dd/MM/yyyy"
        Me.txtDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDesde.LabelText = "Llamadas Desde"
        Me.txtDesde.LabelWidth = 100
        Me.txtDesde.Location = New System.Drawing.Point(5, 80)
        Me.txtDesde.MaxLength = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreCampo = ""
        Me.txtDesde.Obligatorio = True
        Me.txtDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.Size = New System.Drawing.Size(233, 20)
        Me.txtDesde.SoloLectura = False
        Me.txtDesde.TabIndex = 19
        Me.txtDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtDesde.Valor = Nothing
        '
        'txtHasta
        '
        Me.txtHasta.CampoBusqueda = False
        Me.txtHasta.CampoEsLlave = False
        Me.txtHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtHasta.FechaActual = False
        Me.txtHasta.Formato = "dd/MM/yyyy"
        Me.txtHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtHasta.LabelText = "Llamadas Hasta"
        Me.txtHasta.LabelWidth = 100
        Me.txtHasta.Location = New System.Drawing.Point(259, 80)
        Me.txtHasta.MaxLength = 0
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreCampo = ""
        Me.txtHasta.Obligatorio = True
        Me.txtHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHasta.Size = New System.Drawing.Size(233, 20)
        Me.txtHasta.SoloLectura = False
        Me.txtHasta.TabIndex = 20
        Me.txtHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtHasta.Valor = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(531, 80)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 23)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar Llamadas"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Fecha"
        Me.PivotGridField1.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField1.FieldName = "Fecha"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.ValueFormat.FormatString = "dd/MMM/yyyy"
        Me.PivotGridField1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.CellFormat.FormatString = "hh:mm:ss tt"
        Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField2.FieldName = "Hora"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.ValueFormat.FormatString = "hh:mm:ss tt"
        Me.PivotGridField2.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Usuario Recibe Llamada"
        Me.PivotGridField3.FieldName = "UsuarioGraba"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "Llamada Para"
        Me.PivotGridField4.FieldName = "UsuarioPara"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField5.AreaIndex = 4
        Me.PivotGridField5.Caption = "Persona que Llama"
        Me.PivotGridField5.FieldName = "PersonaLlama"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField6.AreaIndex = 5
        Me.PivotGridField6.Caption = "Lugar de Donde Llama"
        Me.PivotGridField6.FieldName = "Lugar"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField7.AreaIndex = 6
        Me.PivotGridField7.Caption = "Teléfono"
        Me.PivotGridField7.FieldName = "Telefono"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField8.AreaIndex = 7
        Me.PivotGridField8.Caption = "EMail"
        Me.PivotGridField8.FieldName = "EMail"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField9.AreaIndex = 8
        Me.PivotGridField9.Caption = "Cliente"
        Me.PivotGridField9.FieldName = "Cliente"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField10.AreaIndex = 9
        Me.PivotGridField10.Caption = "Observaciones"
        Me.PivotGridField10.FieldName = "Observaciones"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField11.AreaIndex = 10
        Me.PivotGridField11.Caption = "Se Pasó la Llamada"
        Me.PivotGridField11.FieldName = "SePasoLlamada"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField12
        '
        Me.PivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField12.AreaIndex = 0
        Me.PivotGridField12.Caption = "#Llamadas"
        Me.PivotGridField12.CellFormat.FormatString = "n0"
        Me.PivotGridField12.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.FieldName = "NumLlamadas"
        Me.PivotGridField12.GrandTotalCellFormat.FormatString = "n0"
        Me.PivotGridField12.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.Name = "PivotGridField12"
        Me.PivotGridField12.TotalCellFormat.FormatString = "n0"
        Me.PivotGridField12.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.TotalValueFormat.FormatString = "n0"
        Me.PivotGridField12.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField12.ValueFormat.FormatString = "n0"
        Me.PivotGridField12.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'LstLlamadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(682, 418)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.PivotLlamadas)
        Me.Controls.Add(Me.txtDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "LstLlamadas"
        Me.Text = "Llamadas"
        Me.Controls.SetChildIndex(Me.txtDesde, 0)
        Me.Controls.SetChildIndex(Me.PivotLlamadas, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtHasta, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotLlamadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotLlamadas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents txtDesde As STIControles.stiTextBox
    Friend WithEvents txtHasta As STIControles.stiTextBox
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField

End Class
