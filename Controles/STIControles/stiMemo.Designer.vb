﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiMemo
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SplitControl = New System.Windows.Forms.SplitContainer
        Me.lblControl = New DevExpress.XtraEditors.LabelControl
        Me.txtControl = New DevExpress.XtraEditors.MemoEdit
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitControl.Panel1.SuspendLayout()
        Me.SplitControl.Panel2.SuspendLayout()
        Me.SplitControl.SuspendLayout()
        CType(Me.txtControl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitControl
        '
        Me.SplitControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitControl.IsSplitterFixed = True
        Me.SplitControl.Location = New System.Drawing.Point(0, 0)
        Me.SplitControl.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitControl.Name = "SplitControl"
        '
        'SplitControl.Panel1
        '
        Me.SplitControl.Panel1.Controls.Add(Me.lblControl)
        Me.SplitControl.Panel1MinSize = 10
        '
        'SplitControl.Panel2
        '
        Me.SplitControl.Panel2.Controls.Add(Me.txtControl)
        Me.SplitControl.Panel2MinSize = 10
        Me.SplitControl.Size = New System.Drawing.Size(300, 21)
        Me.SplitControl.SplitterDistance = 83
        Me.SplitControl.SplitterWidth = 1
        Me.SplitControl.TabIndex = 3
        Me.SplitControl.TabStop = False
        '
        'lblControl
        '
        Me.lblControl.Appearance.Options.UseTextOptions = True
        Me.lblControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblControl.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblControl.Location = New System.Drawing.Point(0, 0)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(83, 21)
        Me.lblControl.TabIndex = 0
        Me.lblControl.Text = "Etiqueta"
        '
        'txtControl
        '
        Me.txtControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtControl.EnterMoveNextControl = True
        Me.txtControl.Location = New System.Drawing.Point(0, 0)
        Me.txtControl.Name = "txtControl"
        Me.txtControl.Size = New System.Drawing.Size(216, 21)
        Me.txtControl.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'stiMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitControl)
        Me.Name = "stiMemo"
        Me.Size = New System.Drawing.Size(300, 21)
        Me.SplitControl.Panel1.ResumeLayout(False)
        Me.SplitControl.Panel2.ResumeLayout(False)
        Me.SplitControl.ResumeLayout(False)
        CType(Me.txtControl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitControl As System.Windows.Forms.SplitContainer
    Friend WithEvents lblControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtControl As DevExpress.XtraEditors.MemoEdit

End Class
