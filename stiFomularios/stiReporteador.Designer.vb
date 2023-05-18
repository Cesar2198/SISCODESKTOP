<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiReporteador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stiReporteador))
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton
        Me.btnPDF = New DevExpress.XtraEditors.SimpleButton
        Me.btnWord = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.SelectionFormula = ""
        Me.CRViewer.ShowCloseButton = False
        Me.CRViewer.ShowExportButton = False
        Me.CRViewer.ShowRefreshButton = False
        Me.CRViewer.Size = New System.Drawing.Size(695, 472)
        Me.CRViewer.TabIndex = 0
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(587, 0)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(108, 26)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Exportar a Excel"
        '
        'btnPDF
        '
        Me.btnPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.Location = New System.Drawing.Point(479, 0)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(108, 26)
        Me.btnPDF.TabIndex = 2
        Me.btnPDF.Text = "Exportar a PDF"
        '
        'btnWord
        '
        Me.btnWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWord.Image = CType(resources.GetObject("btnWord.Image"), System.Drawing.Image)
        Me.btnWord.Location = New System.Drawing.Point(367, 0)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(111, 26)
        Me.btnWord.TabIndex = 3
        Me.btnWord.Text = "Exportar a Word"
        '
        'stiReporteador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 472)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.CRViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stiReporteador"
        Me.Text = "Reporte..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Public WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnWord As DevExpress.XtraEditors.SimpleButton
End Class
