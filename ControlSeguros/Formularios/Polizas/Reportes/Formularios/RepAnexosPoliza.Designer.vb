<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepAnexosPoliza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepAnexosPoliza))
        Me.txtHasta = New STIControles.stiTextBox
        Me.txtDesde = New STIControles.stiTextBox
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtCliente = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtPoliza = New STIControles.stiTextBox
        Me.GridAnexos = New STIControles.stiGrid
        Me.VistaAnexos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoAnexo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaAnexo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaDesde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVigenciaHasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaExclusion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSumaAseguradaNueva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimaAnexo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAsegurado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnBuscarAnexos = New DevExpress.XtraEditors.SimpleButton
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaAnexos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(525, 459)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(422, 459)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(628, 459)
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
        Me.LabelControl1.Size = New System.Drawing.Size(594, 74)
        Me.LabelControl1.Text = "Reporte de Anexos de una Póliza"
        '
        'txtHasta
        '
        Me.txtHasta.CampoBusqueda = False
        Me.txtHasta.CampoEsLlave = False
        Me.txtHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtHasta.FechaActual = False
        Me.txtHasta.Formato = "Long Date"
        Me.txtHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtHasta.LabelText = "Vigencia Hasta Actual"
        Me.txtHasta.LabelWidth = 150
        Me.txtHasta.Location = New System.Drawing.Point(313, 162)
        Me.txtHasta.MaxLength = 0
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreCampo = ""
        Me.txtHasta.Obligatorio = True
        Me.txtHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHasta.Size = New System.Drawing.Size(283, 36)
        Me.txtHasta.SoloLectura = False
        Me.txtHasta.TabIndex = 48
        Me.txtHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtHasta.Valor = Nothing
        '
        'txtDesde
        '
        Me.txtDesde.CampoBusqueda = False
        Me.txtDesde.CampoEsLlave = False
        Me.txtDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtDesde.FechaActual = False
        Me.txtDesde.Formato = "Long Date"
        Me.txtDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDesde.LabelText = "Vigencia Desde Actual"
        Me.txtDesde.LabelWidth = 150
        Me.txtDesde.Location = New System.Drawing.Point(5, 162)
        Me.txtDesde.MaxLength = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreCampo = ""
        Me.txtDesde.Obligatorio = True
        Me.txtDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.Size = New System.Drawing.Size(283, 36)
        Me.txtDesde.SoloLectura = False
        Me.txtDesde.TabIndex = 47
        Me.txtDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtDesde.Valor = Nothing
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(322, 80)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarPoliza.TabIndex = 46
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
        '
        'txtCliente
        '
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCliente.LabelText = "Cliente"
        Me.txtCliente.LabelWidth = 150
        Me.txtCliente.Location = New System.Drawing.Point(5, 136)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = True
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(591, 20)
        Me.txtCliente.SoloLectura = True
        Me.txtCliente.TabIndex = 45
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 20752
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 150
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(5, 110)
        Me.cboProducto.MostrarBusquedaColumnas = False
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = True
        Me.cboProducto.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = 0
        Me.cboProducto.Size = New System.Drawing.Size(591, 20)
        Me.cboProducto.SoloLectura = True
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 44
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'txtPoliza
        '
        Me.txtPoliza.CampoBusqueda = False
        Me.txtPoliza.CampoEsLlave = False
        Me.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPoliza.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPoliza.FechaActual = False
        Me.txtPoliza.Formato = ""
        Me.txtPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPoliza.LabelText = "Número Póliza"
        Me.txtPoliza.LabelWidth = 150
        Me.txtPoliza.Location = New System.Drawing.Point(5, 84)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = True
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtPoliza.SoloLectura = True
        Me.txtPoliza.TabIndex = 43
        Me.txtPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPoliza.Valor = ""
        '
        'GridAnexos
        '
        Me.GridAnexos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAnexos.ColumnasAdicionales = ""
        Me.GridAnexos.Location = New System.Drawing.Point(7, 204)
        Me.GridAnexos.MainView = Me.VistaAnexos
        Me.GridAnexos.Name = "GridAnexos"
        Me.GridAnexos.NombreTabla = ""
        Me.GridAnexos.Size = New System.Drawing.Size(717, 250)
        Me.GridAnexos.TabIndex = 49
        Me.GridAnexos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaAnexos})
        '
        'VistaAnexos
        '
        Me.VistaAnexos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaAnexos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaAnexos.ColumnPanelRowHeight = 35
        Me.VistaAnexos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoAnexo, Me.colIdCertificado, Me.colFechaAnexo, Me.colVigenciaDesde, Me.colVigenciaHasta, Me.colFechaIngreso, Me.colFechaExclusion, Me.colSumaAseguradaNueva, Me.colPrimaAnexo, Me.colAsegurado, Me.GridColumn1})
        Me.VistaAnexos.GridControl = Me.GridAnexos
        Me.VistaAnexos.Name = "VistaAnexos"
        Me.VistaAnexos.OptionsBehavior.Editable = False
        Me.VistaAnexos.OptionsView.ShowFooter = True
        Me.VistaAnexos.OptionsView.ShowGroupPanel = False
        '
        'colTipoAnexo
        '
        Me.colTipoAnexo.Caption = "Tipo Anexo"
        Me.colTipoAnexo.FieldName = "TipoAnexo"
        Me.colTipoAnexo.Name = "colTipoAnexo"
        Me.colTipoAnexo.Visible = True
        Me.colTipoAnexo.VisibleIndex = 0
        Me.colTipoAnexo.Width = 69
        '
        'colIdCertificado
        '
        Me.colIdCertificado.Caption = "Certificado"
        Me.colIdCertificado.FieldName = "IdCertificado"
        Me.colIdCertificado.Name = "colIdCertificado"
        Me.colIdCertificado.Visible = True
        Me.colIdCertificado.VisibleIndex = 1
        Me.colIdCertificado.Width = 69
        '
        'colFechaAnexo
        '
        Me.colFechaAnexo.Caption = "Fecha Anexo"
        Me.colFechaAnexo.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaAnexo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaAnexo.FieldName = "FechaAnexo"
        Me.colFechaAnexo.Name = "colFechaAnexo"
        Me.colFechaAnexo.Visible = True
        Me.colFechaAnexo.VisibleIndex = 6
        Me.colFechaAnexo.Width = 64
        '
        'colVigenciaDesde
        '
        Me.colVigenciaDesde.Caption = "Inicio Anexo"
        Me.colVigenciaDesde.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colVigenciaDesde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVigenciaDesde.FieldName = "VigenciaDesde"
        Me.colVigenciaDesde.Name = "colVigenciaDesde"
        Me.colVigenciaDesde.Visible = True
        Me.colVigenciaDesde.VisibleIndex = 4
        Me.colVigenciaDesde.Width = 64
        '
        'colVigenciaHasta
        '
        Me.colVigenciaHasta.Caption = "Fin Anexo"
        Me.colVigenciaHasta.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colVigenciaHasta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVigenciaHasta.FieldName = "VigenciaHasta"
        Me.colVigenciaHasta.Name = "colVigenciaHasta"
        Me.colVigenciaHasta.Visible = True
        Me.colVigenciaHasta.VisibleIndex = 5
        Me.colVigenciaHasta.Width = 64
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Caption = "Fecha Inclusión"
        Me.colFechaIngreso.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaIngreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaIngreso.FieldName = "FechaIngreso"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 7
        Me.colFechaIngreso.Width = 64
        '
        'colFechaExclusion
        '
        Me.colFechaExclusion.Caption = "Fecha de Exclusión"
        Me.colFechaExclusion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaExclusion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaExclusion.FieldName = "FechaExclusion"
        Me.colFechaExclusion.Name = "colFechaExclusion"
        Me.colFechaExclusion.Visible = True
        Me.colFechaExclusion.VisibleIndex = 8
        Me.colFechaExclusion.Width = 64
        '
        'colSumaAseguradaNueva
        '
        Me.colSumaAseguradaNueva.Caption = "Suma Asegurada Anexo"
        Me.colSumaAseguradaNueva.DisplayFormat.FormatString = "c2"
        Me.colSumaAseguradaNueva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSumaAseguradaNueva.FieldName = "SumaAseguradaNueva"
        Me.colSumaAseguradaNueva.Name = "colSumaAseguradaNueva"
        Me.colSumaAseguradaNueva.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSumaAseguradaNueva.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSumaAseguradaNueva.Visible = True
        Me.colSumaAseguradaNueva.VisibleIndex = 9
        Me.colSumaAseguradaNueva.Width = 64
        '
        'colPrimaAnexo
        '
        Me.colPrimaAnexo.Caption = "Prima Anexo"
        Me.colPrimaAnexo.DisplayFormat.FormatString = "c2"
        Me.colPrimaAnexo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimaAnexo.FieldName = "PrimaAnexo"
        Me.colPrimaAnexo.Name = "colPrimaAnexo"
        Me.colPrimaAnexo.SummaryItem.DisplayFormat = "{0:c}"
        Me.colPrimaAnexo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPrimaAnexo.Visible = True
        Me.colPrimaAnexo.VisibleIndex = 10
        Me.colPrimaAnexo.Width = 72
        '
        'colAsegurado
        '
        Me.colAsegurado.Caption = "Asegurado"
        Me.colAsegurado.FieldName = "Asegurado"
        Me.colAsegurado.Name = "colAsegurado"
        Me.colAsegurado.Visible = True
        Me.colAsegurado.VisibleIndex = 3
        Me.colAsegurado.Width = 102
        '
        'btnBuscarAnexos
        '
        Me.btnBuscarAnexos.Image = CType(resources.GetObject("btnBuscarAnexos.Image"), System.Drawing.Image)
        Me.btnBuscarAnexos.Location = New System.Drawing.Point(612, 136)
        Me.btnBuscarAnexos.Name = "btnBuscarAnexos"
        Me.btnBuscarAnexos.Size = New System.Drawing.Size(107, 62)
        Me.btnBuscarAnexos.TabIndex = 50
        Me.btnBuscarAnexos.Text = "Buscar Anexos"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cert. Aseguradora"
        Me.GridColumn1.FieldName = "IdCertificadoAseguradora"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'RepAnexosPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(731, 497)
        Me.Controls.Add(Me.btnBuscarAnexos)
        Me.Controls.Add(Me.GridAnexos)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepAnexosPoliza"
        Me.Text = "Reporte de Anexos"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtDesde, 0)
        Me.Controls.SetChildIndex(Me.txtHasta, 0)
        Me.Controls.SetChildIndex(Me.GridAnexos, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarAnexos, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaAnexos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHasta As STIControles.stiTextBox
    Friend WithEvents txtDesde As STIControles.stiTextBox
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents GridAnexos As STIControles.stiGrid
    Friend WithEvents VistaAnexos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTipoAnexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAnexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVigenciaHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaExclusion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSumaAseguradaNueva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimaAnexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscarAnexos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colAsegurado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

End Class
