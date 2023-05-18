<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstEntregaSinMensajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstEntregaSinMensajero))
        Me.btnImprimirDocMarcados = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(224, 350)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(113, 2)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(18, 350)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(18, 345)
        Me.btnImprimir.Size = New System.Drawing.Size(10, 10)
        Me.btnImprimir.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(224, 2)
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Location = New System.Drawing.Point(511, 309)
        Me.btnModificar.Size = New System.Drawing.Size(161, 36)
        Me.btnModificar.Text = "&Marcar e Imprimir"
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        '
        'btnImprimirDocMarcados
        '
        Me.btnImprimirDocMarcados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirDocMarcados.Appearance.Options.UseFont = True
        Me.btnImprimirDocMarcados.Image = CType(resources.GetObject("btnImprimirDocMarcados.Image"), System.Drawing.Image)
        Me.btnImprimirDocMarcados.Location = New System.Drawing.Point(4, 2)
        Me.btnImprimirDocMarcados.Name = "btnImprimirDocMarcados"
        Me.btnImprimirDocMarcados.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimirDocMarcados.TabIndex = 8
        Me.btnImprimirDocMarcados.Text = "&Imprimir"
        '
        'LstEntregaSinMensajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(672, 361)
        Me.Controls.Add(Me.btnImprimirDocMarcados)
        Me.ListaAliasCampos = "Correlativo, Cod. Flujo, Documento, Fecha en Documento, Fecha, Asunto, Origen, De" & _
            "stinatario, No. Reclamo, Fecha Ocurrido, Descripción Siniestro, Placa, Marcar"
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.Name = "LstEntregaSinMensajero"
        Me.OrdenRegistros = "i.FechaImpresion"
        Me.Tabla = resources.GetString("$this.Tabla")
        Me.Text = "Comprobante de Entrega de Siniestros a Mensajero"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.btnImprimirDocMarcados, 0)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnImprimirDocMarcados As DevExpress.XtraEditors.SimpleButton

End Class
