<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContinuarFlujoNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContinuarFlujoNav))
        Me.lblGesAtrasada = New DevExpress.XtraEditors.LabelControl
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(462, 26)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(222, 3)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(446, 26)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(113, 3)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(331, 3)
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Location = New System.Drawing.Point(4, 3)
        Me.btnModificar.Text = "A&ctualizar"
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Size = New System.Drawing.Size(920, 15)
        '
        'lblGesAtrasada
        '
        Me.lblGesAtrasada.Appearance.BackColor = System.Drawing.Color.Red
        Me.lblGesAtrasada.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblGesAtrasada.Appearance.Options.UseBackColor = True
        Me.lblGesAtrasada.Appearance.Options.UseForeColor = True
        Me.lblGesAtrasada.Location = New System.Drawing.Point(503, 5)
        Me.lblGesAtrasada.Name = "lblGesAtrasada"
        Me.lblGesAtrasada.Size = New System.Drawing.Size(125, 13)
        Me.lblGesAtrasada.TabIndex = 21
        Me.lblGesAtrasada.Text = "Flujo de Trabajo Atrasado"
        '
        'ContinuarFlujoNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 905
        Me.ClientSize = New System.Drawing.Size(921, 361)
        Me.Controls.Add(Me.lblGesAtrasada)
        Me.Filtro = "EstadoFlujo = 'PENDIENTE'"
        Me.FormularioEdicion = "ContinuarFlujoMan"
        Me.ListaAliasCampos = resources.GetString("$this.ListaAliasCampos")
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.ListaCamposLlave = "IdFlujoDoc"
        Me.ListaCamposOcultos = "FechaFinaliza, Horas,DescripcionSiniestro, UsuarioAsignacion, UsuarioReAsignacion" & _
            ", FechaAsignacion, FechaReAsignacion,Identificador"
        Me.Name = "ContinuarFlujoNav"
        Me.OrdenRegistros = "FechaInicia desc"
        Me.Tabla = "FlujosDocumentos"
        Me.Text = "Flujos Pendientes"
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.lblGesAtrasada, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGesAtrasada As DevExpress.XtraEditors.LabelControl

End Class
