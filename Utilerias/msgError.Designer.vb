<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msgError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msgError))
        Me.btnDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.txtMensaje = New DevExpress.XtraEditors.MemoEdit
        Me.txtDetalle = New DevExpress.XtraEditors.MemoEdit
        CType(Me.txtMensaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetalle
        '
        Me.btnDetalle.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDetalle.Appearance.Options.UseFont = True
        Me.btnDetalle.Image = CType(resources.GetObject("btnDetalle.Image"), System.Drawing.Image)
        Me.btnDetalle.Location = New System.Drawing.Point(323, 67)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(112, 36)
        Me.btnDetalle.TabIndex = 19
        Me.btnDetalle.Text = "&Detalle >>"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(441, 67)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 36)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "&Salir"
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.Location = New System.Drawing.Point(-1, 0)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMensaje.Properties.Appearance.Options.UseFont = True
        Me.txtMensaje.Properties.ReadOnly = True
        Me.txtMensaje.Size = New System.Drawing.Size(555, 65)
        Me.txtMensaje.TabIndex = 17
        '
        'txtDetalle
        '
        Me.txtDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetalle.Location = New System.Drawing.Point(-1, 113)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Properties.ReadOnly = True
        Me.txtDetalle.Size = New System.Drawing.Size(555, 150)
        Me.txtDetalle.TabIndex = 16
        '
        'msgError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 265)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "msgError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    Mensaje de Error..."
        CType(Me.txtMensaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnDetalle As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMensaje As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDetalle As DevExpress.XtraEditors.MemoEdit
End Class
