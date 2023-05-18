<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.lstImgSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.lstImgBig = New System.Windows.Forms.ImageList(Me.components)
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationIcon = Global.stiFomularios.My.Resources.Resources.sti2
        Me.RibbonControl.Images = Me.lstImgSmall
        Me.RibbonControl.LargeImages = Me.lstImgBig
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(785, 48)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'lstImgSmall
        '
        Me.lstImgSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.lstImgSmall.ImageSize = New System.Drawing.Size(16, 16)
        Me.lstImgSmall.TransparentColor = System.Drawing.Color.Transparent
        '
        'lstImgBig
        '
        Me.lstImgBig.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.lstImgBig.ImageSize = New System.Drawing.Size(32, 32)
        Me.lstImgBig.TransparentColor = System.Drawing.Color.Transparent
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 406)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(785, 25)
        '
        'stiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 431)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "stiPrincipal"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Public WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Public WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Public WithEvents lstImgSmall As System.Windows.Forms.ImageList
    Public WithEvents lstImgBig As System.Windows.Forms.ImageList


End Class
