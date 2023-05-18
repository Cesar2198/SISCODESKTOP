<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosNav
    Inherits stiFomularios.stiNavegador

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosNav))
        Me.optTodos = New System.Windows.Forms.RadioButton
        Me.optAnioAnt = New System.Windows.Forms.RadioButton
        Me.optAnioAct = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Size = New System.Drawing.Size(777, 15)
        '
        'optTodos
        '
        Me.optTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optTodos.AutoSize = True
        Me.optTodos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optTodos.Location = New System.Drawing.Point(680, 88)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.Size = New System.Drawing.Size(59, 17)
        Me.optTodos.TabIndex = 16
        Me.optTodos.Text = "Todos"
        Me.optTodos.UseVisualStyleBackColor = True
        '
        'optAnioAnt
        '
        Me.optAnioAnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAnioAnt.AutoSize = True
        Me.optAnioAnt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optAnioAnt.Location = New System.Drawing.Point(680, 65)
        Me.optAnioAnt.Name = "optAnioAnt"
        Me.optAnioAnt.Size = New System.Drawing.Size(97, 17)
        Me.optAnioAnt.TabIndex = 15
        Me.optAnioAnt.Text = "Año Anterior"
        Me.optAnioAnt.UseVisualStyleBackColor = True
        '
        'optAnioAct
        '
        Me.optAnioAct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAnioAct.AutoSize = True
        Me.optAnioAct.Checked = True
        Me.optAnioAct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optAnioAct.Location = New System.Drawing.Point(680, 42)
        Me.optAnioAct.Name = "optAnioAct"
        Me.optAnioAct.Size = New System.Drawing.Size(86, 17)
        Me.optAnioAct.TabIndex = 14
        Me.optAnioAct.TabStop = True
        Me.optAnioAct.Text = "Año Actual"
        Me.optAnioAct.UseVisualStyleBackColor = True
        '
        'PagosNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 301
        Me.ClientSize = New System.Drawing.Size(778, 361)
        Me.Controls.Add(Me.optTodos)
        Me.Controls.Add(Me.optAnioAnt)
        Me.Controls.Add(Me.optAnioAct)
        Me.FormularioEdicion = "PagosMan"
        Me.ListaAliasCampos = resources.GetString("$this.ListaAliasCampos")
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.ListaCamposLlave = "NumeroFactura, IdProducto, IdPoliza, IdRamo"
        Me.ListaCamposOcultos = resources.GetString("$this.ListaCamposOcultos")
        Me.Name = "PagosNav"
        Me.OrdenRegistros = "NombreCliente,NumeroFactura"
        Me.Tabla = "Facturas"
        Me.Text = "Registro de Pagos de Primas"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.optAnioAct, 0)
        Me.Controls.SetChildIndex(Me.optAnioAnt, 0)
        Me.Controls.SetChildIndex(Me.optTodos, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optTodos As System.Windows.Forms.RadioButton
    Friend WithEvents optAnioAnt As System.Windows.Forms.RadioButton
    Friend WithEvents optAnioAct As System.Windows.Forms.RadioButton

End Class
