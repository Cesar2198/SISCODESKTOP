<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactosGeneralesNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactosGeneralesNav))
        Me.optSoloContactos = New System.Windows.Forms.RadioButton
        Me.optTodos = New System.Windows.Forms.RadioButton
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
        Me.lblStatus.Size = New System.Drawing.Size(844, 15)
        '
        'optSoloContactos
        '
        Me.optSoloContactos.AutoSize = True
        Me.optSoloContactos.Checked = True
        Me.optSoloContactos.Location = New System.Drawing.Point(634, 0)
        Me.optSoloContactos.Name = "optSoloContactos"
        Me.optSoloContactos.Size = New System.Drawing.Size(196, 17)
        Me.optSoloContactos.TabIndex = 8
        Me.optSoloContactos.TabStop = True
        Me.optSoloContactos.Text = "Sólo Contactos de Correspondencia"
        Me.optSoloContactos.UseVisualStyleBackColor = True
        '
        'optTodos
        '
        Me.optTodos.AutoSize = True
        Me.optTodos.Location = New System.Drawing.Point(634, 19)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.Size = New System.Drawing.Size(120, 17)
        Me.optTodos.TabIndex = 9
        Me.optTodos.Text = "Todos los contactos"
        Me.optTodos.UseVisualStyleBackColor = True
        '
        'ContactosGeneralesNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(845, 361)
        Me.Controls.Add(Me.optTodos)
        Me.Controls.Add(Me.optSoloContactos)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormularioEdicion = "ContactosGeneralesMan"
        Me.ListaAliasCampos = resources.GetString("$this.ListaAliasCampos")
        Me.ListaCamposLlave = "IdContacto"
        Me.ListaCamposOcultos = "Tipo, Fax, Email, PaginaWeb, Nit, RegistroFiscal,FechaNacimiento, NombreRepLegal," & _
            " FnacRepLegal, TipoCliente "
        Me.Name = "ContactosGeneralesNav"
        Me.OrdenRegistros = ""
        Me.Tabla = "ContactosGenerales"
        Me.Text = "Registro de Contactos"
        Me.Controls.SetChildIndex(Me.optSoloContactos, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.optTodos, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optSoloContactos As System.Windows.Forms.RadioButton
    Friend WithEvents optTodos As System.Windows.Forms.RadioButton

End Class
