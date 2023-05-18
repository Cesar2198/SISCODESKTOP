<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repMovimientosPolizas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repMovimientosPolizas))
        Me.gridPolizas = New STIControles.stiGrid
        Me.VistaPolizas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtFechaInicial = New STIControles.stiTextBox
        Me.btnBuscarOfertas = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaFinal = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(582, 405)
        Me.btnAyuda.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(479, 405)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(685, 405)
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
        Me.LabelControl1.Size = New System.Drawing.Size(651, 74)
        Me.LabelControl1.Text = "Reporte de Movimientos a Pólizas"
        '
        'gridPolizas
        '
        Me.gridPolizas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPolizas.Location = New System.Drawing.Point(5, 111)
        Me.gridPolizas.MainView = Me.VistaPolizas
        Me.gridPolizas.Name = "gridPolizas"
        Me.gridPolizas.NombreTabla = ""
        Me.gridPolizas.Size = New System.Drawing.Size(777, 289)
        Me.gridPolizas.TabIndex = 6
        Me.gridPolizas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPolizas})
        '
        'VistaPolizas
        '
        Me.VistaPolizas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaPolizas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaPolizas.ColumnPanelRowHeight = 40
        Me.VistaPolizas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.VistaPolizas.GridControl = Me.gridPolizas
        Me.VistaPolizas.Name = "VistaPolizas"
        Me.VistaPolizas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No."
        Me.GridColumn1.FieldName = "Num"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Aseguradora"
        Me.GridColumn2.FieldName = "Aseguradora"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 78
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha Ingreso de Solicitud de Movimiento"
        Me.GridColumn3.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "FechaFlujo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 78
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cliente"
        Me.GridColumn4.FieldName = "Cliente"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Póliza"
        Me.GridColumn5.FieldName = "IdPoliza"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripción de la Modificación"
        Me.GridColumn6.FieldName = "Descripcion"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 78
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Prima Neta"
        Me.GridColumn7.DisplayFormat.FormatString = "c2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "PrimaNeta"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 78
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Estado"
        Me.GridColumn8.FieldName = "Estado"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Observaciones"
        Me.GridColumn9.FieldName = "Observaciones"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 78
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Fecha de Envío Anexo a Cliente"
        Me.GridColumn10.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn10.FieldName = "FechaEnvio"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 91
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "IdProducto"
        Me.GridColumn11.FieldName = "IdProducto"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
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
        Me.txtFechaInicial.Location = New System.Drawing.Point(122, 80)
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
        'btnBuscarOfertas
        '
        Me.btnBuscarOfertas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarOfertas.Image = CType(resources.GetObject("btnBuscarOfertas.Image"), System.Drawing.Image)
        Me.btnBuscarOfertas.Location = New System.Drawing.Point(635, 77)
        Me.btnBuscarOfertas.Name = "btnBuscarOfertas"
        Me.btnBuscarOfertas.Size = New System.Drawing.Size(145, 28)
        Me.btnBuscarOfertas.TabIndex = 2
        Me.btnBuscarOfertas.Text = "Buscar Movimientos"
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
        Me.txtFechaFinal.Location = New System.Drawing.Point(379, 80)
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
        'repMovimientosPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(788, 443)
        Me.Controls.Add(Me.txtFechaInicial)
        Me.Controls.Add(Me.btnBuscarOfertas)
        Me.Controls.Add(Me.txtFechaFinal)
        Me.Controls.Add(Me.gridPolizas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "repMovimientosPolizas"
        Me.Text = "Movimientos Pólizas"
        Me.Controls.SetChildIndex(Me.gridPolizas, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarOfertas, 0)
        Me.Controls.SetChildIndex(Me.txtFechaInicial, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridPolizas As STIControles.stiGrid
    Friend WithEvents VistaPolizas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaInicial As STIControles.stiTextBox
    Friend WithEvents btnBuscarOfertas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaFinal As STIControles.stiTextBox
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn

End Class
