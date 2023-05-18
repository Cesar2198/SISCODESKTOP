<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibosNav
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
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(662, 0)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(310, 0)
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
        Me.btnImprimir.Location = New System.Drawing.Point(207, 0)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(413, 0)
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
        '
        'VistaNav
        '
        Me.VistaNav.OptionsBehavior.Editable = False
        Me.VistaNav.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaNav.OptionsView.EnableAppearanceOddRow = True
        Me.VistaNav.OptionsView.ShowAutoFilterRow = True
        Me.VistaNav.OptionsView.ShowGroupPanel = False
        '
        'RecibosNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 409
        Me.ClientSize = New System.Drawing.Size(672, 361)
        Me.FormularioEdicion = "RecibosMan"
        Me.ListaAliasCampos = " Num. Recibo, Fecha Recibo, Cod. Cliente, Nombre Cliente, Total Recibo, Estado"
        Me.ListaCampos = " IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo, case EstadoRecibo " & _
            "when 'N' then 'Anulado' when 'P' then 'Pendiente' when 'A' then 'Aplicado' else " & _
            "'' end  as Estado"
        Me.ListaCamposLlave = " IdRecibo"
        Me.Name = "RecibosNav"
        Me.OrdenRegistros = "FechaRecibo desc, IdRecibo desc"
        Me.Tabla = "Recibos"
        Me.Text = "Recibos de Ingreso"
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
