﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosNav
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
        '
        'VistaNav
        '
        Me.VistaNav.OptionsBehavior.Editable = False
        Me.VistaNav.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaNav.OptionsView.EnableAppearanceOddRow = True
        Me.VistaNav.OptionsView.ShowAutoFilterRow = True
        Me.VistaNav.OptionsView.ShowGroupPanel = False
        '
        'UsuariosNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 119
        Me.ClientSize = New System.Drawing.Size(672, 361)
        Me.FormularioEdicion = "UsuariosMan"
        Me.ListaAliasCampos = "Código Usuario, Nombre Usuario, Departamento, Cargo, Fecha Creación, Usuario Crea" & _
            "ción, Teléfono, Email, Ejecutivo Cta."
        Me.ListaCampos = "IdUsuario, NombreUsuario, Departamento, Cargo, FechaCreacion, UsuarioCreacion, Te" & _
            "lefono, Email, EsEjecutivo"
        Me.ListaCamposLlave = "IdUsuario"
        Me.ListaCamposOcultos = "Cargo, FechaCreacion, UsuarioCreacion, Email"
        Me.Name = "UsuariosNav"
        Me.OrdenRegistros = "IdUsuario"
        Me.Tabla = "Usuarios"
        Me.Text = "Registro de Usuarios de Acceso al Sistema"
        CType(Me.VistaNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
