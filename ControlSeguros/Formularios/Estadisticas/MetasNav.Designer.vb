<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetasNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetasNav))
        Me.btnGenMeta = New DevExpress.XtraEditors.SimpleButton
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAyuda.Location = New System.Drawing.Point(517, 0)
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
        Me.btnSalir.Location = New System.Drawing.Point(620, 0)
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
        Me.lblStatus.Size = New System.Drawing.Size(770, 15)
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
        Me.GridNav.Size = New System.Drawing.Size(758, 297)
        '
        'btnGenMeta
        '
        Me.btnGenMeta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGenMeta.Appearance.Options.UseFont = True
        Me.btnGenMeta.Appearance.Options.UseTextOptions = True
        Me.btnGenMeta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGenMeta.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGenMeta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGenMeta.Image = CType(resources.GetObject("btnGenMeta.Image"), System.Drawing.Image)
        Me.btnGenMeta.Location = New System.Drawing.Point(414, 0)
        Me.btnGenMeta.Name = "btnGenMeta"
        Me.btnGenMeta.Size = New System.Drawing.Size(103, 36)
        Me.btnGenMeta.TabIndex = 16
        Me.btnGenMeta.Text = "Generar Me&ta"
        '
        'MetasNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 701
        Me.ClientSize = New System.Drawing.Size(771, 361)
        Me.Controls.Add(Me.btnGenMeta)
        Me.FormularioEdicion = "MetasMan"
        Me.ListaAliasCampos = "Id, Año, Mes, Ramo, Ejecutivo, Primas, Comisiones"
        Me.ListaCampos = "IdMeta, Anio, Mes, (select NombreRamo from RamoSeguros where RamoSeguros.idramo=M" & _
            "etas.IdRamo ), EjecutivoCta, Primas, Comisiones"
        Me.ListaCamposLlave = "IdMeta"
        Me.Name = "MetasNav"
        Me.OrdenRegistros = "Anio desc , Mes asc"
        Me.Tabla = "Metas"
        Me.Text = "Metas Corporativas"
        Me.Controls.SetChildIndex(Me.GridNav, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.btnGenMeta, 0)
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnGenMeta As DevExpress.XtraEditors.SimpleButton

End Class
