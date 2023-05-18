<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulariosNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormulariosNav))
        Me.btnVerFormulario = New DevExpress.XtraEditors.SimpleButton
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(310, 0)
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(516, 0)
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
        Me.btnImprimir.Location = New System.Drawing.Point(413, 0)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(619, 0)
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Location = New System.Drawing.Point(207, 0)
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Size = New System.Drawing.Size(724, 15)
        '
        'VistaNav
        '
        Me.VistaNav.OptionsBehavior.Editable = False
        Me.VistaNav.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaNav.OptionsView.EnableAppearanceOddRow = True
        Me.VistaNav.OptionsView.ShowAutoFilterRow = True
        Me.VistaNav.OptionsView.ShowGroupPanel = False
        '
        'GridNav
        '
        Me.GridNav.Size = New System.Drawing.Size(724, 303)
        '
        'btnVerFormulario
        '
        Me.btnVerFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnVerFormulario.Appearance.Options.UseFont = True
        Me.btnVerFormulario.Appearance.Options.UseTextOptions = True
        Me.btnVerFormulario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnVerFormulario.Image = CType(resources.GetObject("btnVerFormulario.Image"), System.Drawing.Image)
        Me.btnVerFormulario.Location = New System.Drawing.Point(105, 0)
        Me.btnVerFormulario.Name = "btnVerFormulario"
        Me.btnVerFormulario.Size = New System.Drawing.Size(103, 36)
        Me.btnVerFormulario.TabIndex = 8
        Me.btnVerFormulario.Text = "&Ver Formulario"
        '
        'FormulariosNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 820
        Me.ClientSize = New System.Drawing.Size(725, 361)
        Me.Controls.Add(Me.btnVerFormulario)
        Me.FormularioEdicion = "FormulariosMan"
        Me.ListaAliasCampos = " Cod. Formulario, IdAseguradora, Aseguradora, Tipo Formulario, Descripción, RutaF" & _
            "ormulario"
        Me.ListaCampos = " IdFormulario, IdAseguradora, (select Nombre from Aseguradoras where Aseguradoras" & _
            ".IdAseguradora = FormulariosAseguradoras.IdAseguradora ) as Aseguradora,TipoForm" & _
            "ulario, Descripcion, RutaFormulario"
        Me.ListaCamposLlave = " IdFormulario"
        Me.ListaCamposOcultos = "IdAseguradora, RutaFormulario"
        Me.Name = "FormulariosNav"
        Me.OrdenRegistros = "IdAseguradora, IdFormulario"
        Me.Tabla = "FormulariosAseguradoras"
        Me.Text = "Formularios"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.GridNav, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.btnVerFormulario, 0)
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnVerFormulario As DevExpress.XtraEditors.SimpleButton

End Class
