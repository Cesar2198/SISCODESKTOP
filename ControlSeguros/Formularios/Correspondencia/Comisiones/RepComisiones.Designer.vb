<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepComisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepComisiones))
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.PivotFacturas = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.ColNumFactura = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColProducto = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColRamo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColTipoSeguro = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColAseguradora = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColPoliza = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColTipoFactura = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColCuota = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColComisionPotencial = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColComisionCausada = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ColMes = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(537, 406)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(434, 406)
        Me.btnImprimir.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(640, 406)
        Me.btnSalir.TabIndex = 6
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
        Me.LabelControl1.Size = New System.Drawing.Size(606, 74)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Reporte Detallado de Comisiones"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(658, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Búscar"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 90
        Me.txtFechaDesde.Location = New System.Drawing.Point(4, 80)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(322, 20)
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
        Me.txtFechaHasta.Formato = "Long Date"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 90
        Me.txtFechaHasta.Location = New System.Drawing.Point(329, 80)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(322, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'PivotFacturas
        '
        Me.PivotFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotFacturas.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.LightYellow
        Me.PivotFacturas.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.PivotFacturas.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PivotFacturas.Appearance.TotalCell.Options.UseBackColor = True
        Me.PivotFacturas.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotFacturas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.ColNumFactura, Me.ColProducto, Me.ColRamo, Me.ColTipoSeguro, Me.ColAseguradora, Me.ColPoliza, Me.ColTipoFactura, Me.ColCliente, Me.ColCuota, Me.ColComisionPotencial, Me.ColComisionCausada, Me.PivotGridField1, Me.ColMes})
        Me.PivotFacturas.Location = New System.Drawing.Point(4, 106)
        Me.PivotFacturas.Name = "PivotFacturas"
        Me.PivotFacturas.OptionsBehavior.HorizontalScrolling = DevExpress.XtraPivotGrid.PivotGridScrolling.Control
        Me.PivotFacturas.Size = New System.Drawing.Size(739, 294)
        Me.PivotFacturas.TabIndex = 3
        '
        'ColNumFactura
        '
        Me.ColNumFactura.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColNumFactura.AreaIndex = 0
        Me.ColNumFactura.Caption = "Número Factura"
        Me.ColNumFactura.FieldName = "NumeroFactura"
        Me.ColNumFactura.Name = "ColNumFactura"
        '
        'ColProducto
        '
        Me.ColProducto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColProducto.AreaIndex = 1
        Me.ColProducto.Caption = "Producto"
        Me.ColProducto.FieldName = "Producto"
        Me.ColProducto.Name = "ColProducto"
        '
        'ColRamo
        '
        Me.ColRamo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColRamo.AreaIndex = 1
        Me.ColRamo.Caption = "Ramo"
        Me.ColRamo.FieldName = "Ramo"
        Me.ColRamo.Name = "ColRamo"
        '
        'ColTipoSeguro
        '
        Me.ColTipoSeguro.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTipoSeguro.AreaIndex = 2
        Me.ColTipoSeguro.Caption = "Tipo Seguro"
        Me.ColTipoSeguro.FieldName = "TipoSeguro"
        Me.ColTipoSeguro.Name = "ColTipoSeguro"
        '
        'ColAseguradora
        '
        Me.ColAseguradora.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColAseguradora.AreaIndex = 0
        Me.ColAseguradora.Caption = "Aseguradora"
        Me.ColAseguradora.FieldName = "Aseguradora"
        Me.ColAseguradora.Name = "ColAseguradora"
        Me.ColAseguradora.Width = 150
        '
        'ColPoliza
        '
        Me.ColPoliza.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColPoliza.AreaIndex = 5
        Me.ColPoliza.Caption = "Póliza"
        Me.ColPoliza.FieldName = "Poliza"
        Me.ColPoliza.Name = "ColPoliza"
        Me.ColPoliza.Width = 75
        '
        'ColTipoFactura
        '
        Me.ColTipoFactura.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColTipoFactura.AreaIndex = 4
        Me.ColTipoFactura.Caption = "Tipo Factura"
        Me.ColTipoFactura.FieldName = "TipoFactura"
        Me.ColTipoFactura.Name = "ColTipoFactura"
        '
        'ColCliente
        '
        Me.ColCliente.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColCliente.AreaIndex = 6
        Me.ColCliente.Caption = "Cliente"
        Me.ColCliente.FieldName = "NombreCliente"
        Me.ColCliente.Name = "ColCliente"
        '
        'ColCuota
        '
        Me.ColCuota.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.ColCuota.AreaIndex = 3
        Me.ColCuota.Caption = "Cuota"
        Me.ColCuota.FieldName = "Cuota"
        Me.ColCuota.Name = "ColCuota"
        '
        'ColComisionPotencial
        '
        Me.ColComisionPotencial.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColComisionPotencial.AreaIndex = 0
        Me.ColComisionPotencial.Caption = "Comisión Potencial"
        Me.ColComisionPotencial.FieldName = "ComisionPotencial"
        Me.ColComisionPotencial.Name = "ColComisionPotencial"
        '
        'ColComisionCausada
        '
        Me.ColComisionCausada.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.ColComisionCausada.AreaIndex = 1
        Me.ColComisionCausada.Caption = "Comisión Causada"
        Me.ColComisionCausada.FieldName = "ComisionCausada"
        Me.ColComisionCausada.Name = "ColComisionCausada"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField1.AreaIndex = 2
        Me.PivotGridField1.Caption = "Comisión Pagada"
        Me.PivotGridField1.FieldName = "ComisionPagada"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'ColMes
        '
        Me.ColMes.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.ColMes.AreaIndex = 2
        Me.ColMes.Caption = "Mes"
        Me.ColMes.FieldName = "Mes"
        Me.ColMes.Name = "ColMes"
        Me.ColMes.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        '
        'RepComisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 609
        Me.ClientSize = New System.Drawing.Size(743, 444)
        Me.Controls.Add(Me.PivotFacturas)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepComisiones"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.PivotFacturas, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents PivotFacturas As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents ColNumFactura As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColProducto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColRamo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColTipoSeguro As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColAseguradora As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColPoliza As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColTipoFactura As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColCuota As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColComisionCausada As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColComisionPotencial As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ColMes As DevExpress.XtraPivotGrid.PivotGridField

End Class
