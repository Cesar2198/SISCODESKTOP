<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiBuscarRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stiBuscarRegistro))
        Me.GridBuscar = New DevExpress.XtraGrid.GridControl
        Me.VistaBuscar = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GridBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridBuscar
        '
        Me.GridBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBuscar.Location = New System.Drawing.Point(0, 0)
        Me.GridBuscar.MainView = Me.VistaBuscar
        Me.GridBuscar.Name = "GridBuscar"
        Me.GridBuscar.Size = New System.Drawing.Size(540, 297)
        Me.GridBuscar.TabIndex = 0
        Me.GridBuscar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBuscar, Me.GridView2})
        '
        'VistaBuscar
        '
        Me.VistaBuscar.GridControl = Me.GridBuscar
        Me.VistaBuscar.Name = "VistaBuscar"
        Me.VistaBuscar.OptionsBehavior.Editable = False
        Me.VistaBuscar.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaBuscar.OptionsView.ShowAutoFilterRow = True
        Me.VistaBuscar.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridBuscar
        Me.GridView2.Name = "GridView2"
        '
        'stiBuscarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 297)
        Me.Controls.Add(Me.GridBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "stiBuscarRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda de Registros"
        Me.TopMost = True
        CType(Me.GridBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridBuscar As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaBuscar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
