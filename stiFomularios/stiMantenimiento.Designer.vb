<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stiMantenimiento
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
        Me.lblNombreFormulario = New DevExpress.XtraEditors.LabelControl
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardarComo = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.mnuCampos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PersonalizarNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VolverANombreOriginalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNombreFormulario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblNombreFormulario.Location = New System.Drawing.Point(138, 1)
        Me.lblNombreFormulario.Name = "lblNombreFormulario"
        Me.lblNombreFormulario.Size = New System.Drawing.Size(523, 74)
        Me.lblNombreFormulario.TabIndex = 13
        Me.lblNombreFormulario.Text = "Mantenimiento de"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.stiFomularios.My.Resources.Resources.Salir1
        Me.btnSalir.Location = New System.Drawing.Point(568, 241)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 36)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Image = Global.stiFomularios.My.Resources.Resources.GUARDA_1
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 241)
        Me.btnGuardarComo.Name = "btnGuardarComo"
        Me.btnGuardarComo.Size = New System.Drawing.Size(93, 36)
        Me.btnGuardarComo.TabIndex = 15
        Me.btnGuardarComo.Text = "Guardar &Como"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.stiFomularios.My.Resources.Resources.junta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Image = Global.stiFomularios.My.Resources.Resources.Eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(384, 241)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(93, 36)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "&Eliminar"
        '
        'btnAyuda
        '
        Me.btnAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Image = Global.stiFomularios.My.Resources.Resources.Ayuda
        Me.btnAyuda.Location = New System.Drawing.Point(476, 241)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(93, 36)
        Me.btnAyuda.TabIndex = 11
        Me.btnAyuda.Text = "&Ayuda"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = Global.stiFomularios.My.Resources.Resources.Consultar
        Me.btnBuscar.Location = New System.Drawing.Point(292, 241)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 36)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "&Búscar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = Global.stiFomularios.My.Resources.Resources.Agregar
        Me.btnNuevo.Location = New System.Drawing.Point(15, 241)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(93, 36)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = Global.stiFomularios.My.Resources.Resources.Guardar
        Me.btnGuardar.Location = New System.Drawing.Point(107, 241)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(93, 36)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Guardar"
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
        'stiMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(662, 277)
        Me.Controls.Add(Me.btnGuardarComo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNombreFormulario)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "stiMantenimiento"
        Me.Text = "stiMantenimiento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCampos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnAyuda As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lblNombreFormulario As DevExpress.XtraEditors.LabelControl
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents btnGuardarComo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents mnuCampos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PersonalizarNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverANombreOriginalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
