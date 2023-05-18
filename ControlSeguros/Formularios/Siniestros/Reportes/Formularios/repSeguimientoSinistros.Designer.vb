<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repSeguimientoSinistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repSeguimientoSinistros))
        Me.txtFechaInicial = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaFinal = New STIControles.stiTextBox
        Me.GridSeguimientos = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSeguimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(458, 426)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(355, 426)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(561, 426)
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
        Me.LabelControl1.Size = New System.Drawing.Size(527, 74)
        Me.LabelControl1.Text = "Reporte de Seguimientos de Siniestros"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.CampoBusqueda = False
        Me.txtFechaInicial.CampoEsLlave = False
        Me.txtFechaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaInicial.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaInicial.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaInicial.FechaActual = True
        Me.txtFechaInicial.Formato = "dd/MMM/yyyy"
        Me.txtFechaInicial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaInicial.LabelText = "Fecha Inicial"
        Me.txtFechaInicial.LabelWidth = 100
        Me.txtFechaInicial.Location = New System.Drawing.Point(9, 126)
        Me.txtFechaInicial.MaxLength = 0
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NombreCampo = ""
        Me.txtFechaInicial.Obligatorio = False
        Me.txtFechaInicial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaInicial.Size = New System.Drawing.Size(259, 20)
        Me.txtFechaInicial.SoloLectura = False
        Me.txtFechaInicial.TabIndex = 28
        Me.txtFechaInicial.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaInicial.Valor = Nothing
        '
        'cboIdProducto
        '
        Me.cboIdProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = False
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = False
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(9, 103)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = ""
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(524, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 27
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = False
        Me.txtIdSiniestro.CampoEsLlave = False
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Núm. Siniestro"
        Me.txtIdSiniestro.LabelWidth = 100
        Me.txtIdSiniestro.Location = New System.Drawing.Point(9, 80)
        Me.txtIdSiniestro.MaxLength = 0
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = ""
        Me.txtIdSiniestro.Obligatorio = False
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(259, 20)
        Me.txtIdSiniestro.SoloLectura = False
        Me.txtIdSiniestro.TabIndex = 25
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = False
        Me.txtIdPoliza.CampoEsLlave = False
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Poliza"
        Me.txtIdPoliza.LabelWidth = 50
        Me.txtIdPoliza.Location = New System.Drawing.Point(274, 80)
        Me.txtIdPoliza.MaxLength = 0
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = ""
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(259, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 26
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Appearance.Options.UseTextOptions = True
        Me.btnBuscaPoliza.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnBuscaPoliza.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(542, 80)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(110, 43)
        Me.btnBuscaPoliza.TabIndex = 32
        Me.btnBuscaPoliza.Text = "Buscar Seguimientos"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.CampoBusqueda = False
        Me.txtFechaFinal.CampoEsLlave = False
        Me.txtFechaFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaFinal.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaFinal.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaFinal.FechaActual = True
        Me.txtFechaFinal.Formato = "dd/MMM/yyyy"
        Me.txtFechaFinal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaFinal.LabelText = "Fecha Inicial"
        Me.txtFechaFinal.LabelWidth = 100
        Me.txtFechaFinal.Location = New System.Drawing.Point(274, 126)
        Me.txtFechaFinal.MaxLength = 0
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NombreCampo = ""
        Me.txtFechaFinal.Obligatorio = False
        Me.txtFechaFinal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaFinal.Size = New System.Drawing.Size(259, 20)
        Me.txtFechaFinal.SoloLectura = False
        Me.txtFechaFinal.TabIndex = 33
        Me.txtFechaFinal.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaFinal.Valor = Nothing
        '
        'GridSeguimientos
        '
        Me.GridSeguimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSeguimientos.Location = New System.Drawing.Point(9, 152)
        Me.GridSeguimientos.MainView = Me.GridView1
        Me.GridSeguimientos.Name = "GridSeguimientos"
        Me.GridSeguimientos.NombreTabla = ""
        Me.GridSeguimientos.Size = New System.Drawing.Size(649, 268)
        Me.GridSeguimientos.TabIndex = 34
        Me.GridSeguimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridSeguimientos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Siniestro"
        Me.GridColumn1.FieldName = "IdSiniestro"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 87
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Póliza"
        Me.GridColumn2.FieldName = "IdPoliza"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 83
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "FechaGestion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 105
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Observaciones"
        Me.GridColumn4.FieldName = "Comentarios"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 353
        '
        'repSeguimientoSinistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 817
        Me.ClientSize = New System.Drawing.Size(664, 464)
        Me.Controls.Add(Me.GridSeguimientos)
        Me.Controls.Add(Me.txtFechaFinal)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.txtFechaInicial)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdSiniestro)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "repSeguimientoSinistros"
        Me.Text = "Reportes Seguimientos"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtFechaInicial, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.GridSeguimientos, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSeguimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaInicial As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaFinal As STIControles.stiTextBox
    Friend WithEvents GridSeguimientos As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

End Class
