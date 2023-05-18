<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiNavegador
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
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GridNav = New STIControles.stiGrid
        Me.VistaNav = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Image = Global.stiFomularios.My.Resources.Resources.Modificar
        Me.btnModificar.Location = New System.Drawing.Point(104, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(103, 36)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "&Modificar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Image = Global.stiFomularios.My.Resources.Resources.Eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(207, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(103, 36)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Image = Global.stiFomularios.My.Resources.Resources.Ayuda
        Me.btnAyuda.Location = New System.Drawing.Point(413, 0)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(103, 36)
        Me.btnAyuda.TabIndex = 5
        Me.btnAyuda.Text = "&Ayuda"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = Global.stiFomularios.My.Resources.Resources.Agregar
        Me.btnNuevo.Location = New System.Drawing.Point(1, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(103, 36)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = Global.stiFomularios.My.Resources.Resources.Imprimir
        Me.btnImprimir.Location = New System.Drawing.Point(310, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "&Imprimir"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.stiFomularios.My.Resources.Resources.Salir1
        Me.btnSalir.Location = New System.Drawing.Point(516, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 36)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        '
        'GridNav
        '
        Me.GridNav.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridNav.Location = New System.Drawing.Point(1, 42)
        Me.GridNav.MainView = Me.VistaNav
        Me.GridNav.Name = "GridNav"
        Me.GridNav.NombreTabla = ""
        Me.GridNav.Size = New System.Drawing.Size(671, 303)
        Me.GridNav.TabIndex = 0
        Me.GridNav.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaNav})
        '
        'VistaNav
        '
        Me.VistaNav.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaNav.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaNav.ColumnPanelRowHeight = 35
        Me.VistaNav.GridControl = Me.GridNav
        Me.VistaNav.Name = "VistaNav"
        Me.VistaNav.OptionsBehavior.Editable = False
        Me.VistaNav.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaNav.OptionsView.EnableAppearanceOddRow = True
        Me.VistaNav.OptionsView.ShowAutoFilterRow = True
        Me.VistaNav.OptionsView.ShowGroupPanel = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Location = New System.Drawing.Point(1, 345)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(671, 15)
        Me.lblStatus.TabIndex = 7
        '
        'stiNavegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(672, 361)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.GridNav)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "stiNavegador"
        Me.Text = "stiNavegador"
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAyuda As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnModificar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Public WithEvents VistaNav As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GridNav As STIControles.stiGrid
End Class
