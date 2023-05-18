<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionesCorrNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpresionesCorrNav))
        Me.txtFecha = New STIControles.stiTextBox
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(688, 26)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(209, 0)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(704, 26)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(106, 0)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(312, 0)
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Location = New System.Drawing.Point(3, 0)
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Size = New System.Drawing.Size(725, 15)
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = False
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.White
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = True
        Me.txtFecha.Formato = "dd/MMM/yyyy"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha Búsqueda"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(429, 12)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(269, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 9
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'ImpresionesCorrNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 903
        Me.ClientSize = New System.Drawing.Size(726, 361)
        Me.Controls.Add(Me.txtFecha)
        Me.FormularioEdicion = "ImpresionesCorrMan"
        Me.ListaAliasCampos = "Flujo, Impresión, Descripción, Fecha Impresión, Usuario Imprime, Fecha Anulación," & _
            " Destinatario, NombreCliente"
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.ListaCamposLlave = "IdFlujoDoc, IdImpresion"
        Me.ListaCamposOcultos = "Cliente, NombreDestinatario"
        Me.Name = "ImpresionesCorrNav"
        Me.OrdenRegistros = "FechaImpresion desc"
        Me.Tabla = "FlujosDocumentosImpresiones"
        Me.Text = "Impresiones de Flujos"
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox

End Class
