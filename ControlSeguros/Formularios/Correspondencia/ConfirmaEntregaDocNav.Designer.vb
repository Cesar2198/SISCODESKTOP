<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmaEntregaDocNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmaEntregaDocNav))
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.chkDocEntregados = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(753, 3)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(107, 2)
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Appearance.Options.UseTextOptions = True
        Me.btnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnNuevo.Location = New System.Drawing.Point(604, 355)
        Me.btnNuevo.Size = New System.Drawing.Size(170, 38)
        Me.btnNuevo.Text = "&Confimar Entrega de Documentos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(4, 2)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(210, 2)
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(3, 28)
        Me.btnModificar.Size = New System.Drawing.Size(10, 10)
        Me.btnModificar.Text = "&DesRutear"
        Me.btnModificar.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Location = New System.Drawing.Point(1, 336)
        Me.lblStatus.Size = New System.Drawing.Size(773, 15)
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = True
        Me.txtFechaHasta.Formato = "dd/MMM/yyyy"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 80
        Me.txtFechaHasta.Location = New System.Drawing.Point(324, 22)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(220, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 8
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "dd/MMM/yyyy"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 80
        Me.txtFechaDesde.Location = New System.Drawing.Point(324, 1)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(220, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 24
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(550, 1)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 23)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "&Búscar"
        '
        'chkDocEntregados
        '
        Me.chkDocEntregados.AutoSize = True
        Me.chkDocEntregados.Location = New System.Drawing.Point(550, 25)
        Me.chkDocEntregados.Name = "chkDocEntregados"
        Me.chkDocEntregados.Size = New System.Drawing.Size(179, 17)
        Me.chkDocEntregados.TabIndex = 26
        Me.chkDocEntregados.Text = "Cargar Documentos Entregados"
        Me.chkDocEntregados.UseVisualStyleBackColor = True
        '
        'ConfirmaEntregaDocNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 909
        Me.CargarRegistrosAlAbrir = False
        Me.ClientSize = New System.Drawing.Size(774, 394)
        Me.Controls.Add(Me.chkDocEntregados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Filtro = "TipoFlujo = 'SALIDA' and FechaEnvio is not null and FechaAnulacion is null"
        Me.ListaAliasCampos = resources.GetString("$this.ListaAliasCampos")
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.ListaCamposLlave = "IdFlujoDoc, IdImpresion, IdUsuarioEntrega"
        Me.ListaCamposOcultos = "PrimerRuteo,UltimoRuteo,NumRuteos,DiasTranRuteo"
        Me.Name = "ConfirmaEntregaDocNav"
        Me.OrdenRegistros = "FechaImpresion asc"
        Me.Tabla = "FlujosDocumentosImpresiones"
        Me.Text = "Confirmar Documentos Entregados"
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.chkDocEntregados, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkEntregados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDocEntregados As System.Windows.Forms.CheckBox

End Class
