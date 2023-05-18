<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiReportes
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stiReportes))
        Me.btnAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.mnuCampos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PersonalizarNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VolverANombreOriginalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Image = Global.stiFomularios.My.Resources.Resources.Ayuda
        Me.btnAyuda.Location = New System.Drawing.Point(297, 232)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(103, 36)
        Me.btnAyuda.TabIndex = 8
        Me.btnAyuda.Text = "&Ayuda"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = Global.stiFomularios.My.Resources.Resources.Imprimir
        Me.btnImprimir.Location = New System.Drawing.Point(194, 232)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.stiFomularios.My.Resources.Resources.Salir1
        Me.btnSalir.Location = New System.Drawing.Point(400, 232)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 36)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "&Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.LabelControl1.Location = New System.Drawing.Point(137, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(366, 74)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Reporte de"
        '
        'mnuCampos
        '
        Me.mnuCampos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarNombreToolStripMenuItem, Me.VolverANombreOriginalToolStripMenuItem})
        Me.mnuCampos.Name = "mnuCampos"
        Me.mnuCampos.Size = New System.Drawing.Size(245, 48)
        '
        'PersonalizarNombreToolStripMenuItem
        '
        Me.PersonalizarNombreToolStripMenuItem.Name = "PersonalizarNombreToolStripMenuItem"
        Me.PersonalizarNombreToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.PersonalizarNombreToolStripMenuItem.Text = "Personalizar Campo"
        '
        'VolverANombreOriginalToolStripMenuItem
        '
        Me.VolverANombreOriginalToolStripMenuItem.Name = "VolverANombreOriginalToolStripMenuItem"
        Me.VolverANombreOriginalToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.VolverANombreOriginalToolStripMenuItem.Text = "Volver Campo al Estado Original"
        '
        'stiReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 270)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "stiReportes"
        Me.Text = "Reportes..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCampos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnAyuda As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents mnuCampos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PersonalizarNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverANombreOriginalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
