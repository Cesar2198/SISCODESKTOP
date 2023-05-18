<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepLog))
        Me.txtFechaCorte = New STIControles.stiTextBox
        Me.GridLog = New STIControles.stiGrid
        Me.VistaLog = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(433, 390)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(330, 390)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(536, 390)
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
        Me.LabelControl1.Size = New System.Drawing.Size(502, 74)
        Me.LabelControl1.Text = "Reporte Registro de Actividades"
        '
        'txtFechaCorte
        '
        Me.txtFechaCorte.CampoBusqueda = False
        Me.txtFechaCorte.CampoEsLlave = False
        Me.txtFechaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCorte.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCorte.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCorte.FechaActual = True
        Me.txtFechaCorte.Formato = "dd/MMM/yyyy"
        Me.txtFechaCorte.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCorte.LabelText = "Actividades Desde"
        Me.txtFechaCorte.LabelWidth = 120
        Me.txtFechaCorte.Location = New System.Drawing.Point(3, 80)
        Me.txtFechaCorte.MaxLength = 0
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.NombreCampo = ""
        Me.txtFechaCorte.Obligatorio = True
        Me.txtFechaCorte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCorte.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaCorte.SoloLectura = False
        Me.txtFechaCorte.TabIndex = 17
        Me.txtFechaCorte.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCorte.Valor = Nothing
        '
        'GridLog
        '
        Me.GridLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLog.Location = New System.Drawing.Point(3, 111)
        Me.GridLog.MainView = Me.VistaLog
        Me.GridLog.Name = "GridLog"
        Me.GridLog.NombreTabla = ""
        Me.GridLog.Size = New System.Drawing.Size(632, 273)
        Me.GridLog.TabIndex = 18
        Me.GridLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaLog})
        '
        'VistaLog
        '
        Me.VistaLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.VistaLog.GridControl = Me.GridLog
        Me.VistaLog.Name = "VistaLog"
        Me.VistaLog.OptionsBehavior.Editable = False
        Me.VistaLog.OptionsView.ShowAutoFilterRow = True
        Me.VistaLog.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdLog"
        Me.GridColumn1.FieldName = "IdLog"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Usuario"
        Me.GridColumn2.FieldName = "Usuario"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "Fecha"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Accion"
        Me.GridColumn4.FieldName = "Accion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tabla"
        Me.GridColumn5.FieldName = "Tabla"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Claves"
        Me.GridColumn6.FieldName = "Claves"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(309, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 29)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "&Búscar"
        '
        'RepLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 101
        Me.ClientSize = New System.Drawing.Size(639, 428)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GridLog)
        Me.Controls.Add(Me.txtFechaCorte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepLog"
        Me.Text = "Log de Actividades"
        Me.Controls.SetChildIndex(Me.txtFechaCorte, 0)
        Me.Controls.SetChildIndex(Me.GridLog, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaCorte As STIControles.stiTextBox
    Friend WithEvents GridLog As STIControles.stiGrid
    Friend WithEvents VistaLog As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

End Class
