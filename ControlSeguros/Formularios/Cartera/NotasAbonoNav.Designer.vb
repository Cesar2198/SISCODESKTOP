﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasAbonoNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotasAbonoNav))
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
        'NotasAbonoNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 315
        Me.ClientSize = New System.Drawing.Size(672, 361)
        Me.FormularioEdicion = "NotasAbonoMan"
        Me.ListaAliasCampos = resources.GetString("$this.ListaAliasCampos")
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.ListaCamposLlave = "IdNotaAbono, NumeroFactura, IdProducto, IdPoliza, IdRamo"
        Me.ListaCamposOcultos = "IdRamo, PrimaNetaNota, GastosEmiNota, GastosFinNota, GastosBombNota, GastosNota, " & _
            "ImpuestosNota, TotalNota, Observaciones, Cliente, Aseguradora, Ramo, Producto, V" & _
            "endedor, FechaAnula, Notas, IdFlujoDoc"
        Me.Name = "NotasAbonoNav"
        Me.OrdenRegistros = "FechaNotaAbono desc"
        Me.Tabla = "NotasAbono"
        Me.Text = "Administración de Notas de Abono"
        Me.ResumeLayout(False)

    End Sub

End Class
