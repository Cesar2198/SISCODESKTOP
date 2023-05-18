<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesRutearDocumentoNav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesRutearDocumentoNav))
        Me.txtFecha = New STIControles.stiTextBox
        Me.cboIdUsuario = New STIControles.stiComboBox
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
        Me.btnAyuda.Location = New System.Drawing.Point(233, 2)
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Appearance.Options.UseTextOptions = True
        Me.btnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnNuevo.Location = New System.Drawing.Point(635, 355)
        Me.btnNuevo.Size = New System.Drawing.Size(139, 38)
        Me.btnNuevo.Text = "&Reasignar Usuario Entrega"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(130, 2)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(336, 2)
        '
        'btnModificar
        '
        Me.btnModificar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Appearance.Options.UseFont = True
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(3, 2)
        Me.btnModificar.Size = New System.Drawing.Size(127, 36)
        Me.btnModificar.Text = "&DesRutear"
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Location = New System.Drawing.Point(1, 336)
        Me.lblStatus.Size = New System.Drawing.Size(773, 15)
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
        Me.txtFecha.Location = New System.Drawing.Point(462, 14)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = ""
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(269, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 8
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'cboIdUsuario
        '
        Me.cboIdUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdUsuario.CampoAutoCompletar = 0
        Me.cboIdUsuario.CampoBusqueda = False
        Me.cboIdUsuario.CampoDisplay = 1
        Me.cboIdUsuario.CampoEsLlave = False
        Me.cboIdUsuario.CampoValor = 0
        Me.cboIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdUsuario.ControlBackColor = System.Drawing.Color.White
        Me.cboIdUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdUsuario.FilasVisibles = 7
        Me.cboIdUsuario.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdUsuario.LabelText = "Usuario Entrega"
        Me.cboIdUsuario.LabelWidth = 85
        Me.cboIdUsuario.Lista = ""
        Me.cboIdUsuario.Location = New System.Drawing.Point(244, 367)
        Me.cboIdUsuario.Name = "cboIdUsuario"
        Me.cboIdUsuario.NombreCampo = "IdUsuarioEntrega"
        Me.cboIdUsuario.Obligatorio = False
        Me.cboIdUsuario.Query = "select idusuario as Id, nombreusuario as Usuario from usuarios"
        Me.cboIdUsuario.SelectIndex = -1
        Me.cboIdUsuario.Size = New System.Drawing.Size(385, 20)
        Me.cboIdUsuario.SoloLectura = False
        Me.cboIdUsuario.StringConection = ""
        Me.cboIdUsuario.TabIndex = 23
        Me.cboIdUsuario.TextoNuevoItem = ""
        Me.cboIdUsuario.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdUsuario.Valor = ""
        '
        'DesRutearDocumentoNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 909
        Me.ClientSize = New System.Drawing.Size(774, 394)
        Me.Controls.Add(Me.cboIdUsuario)
        Me.Controls.Add(Me.txtFecha)
        Me.Filtro = "TipoFlujo = 'SALIDA' and FechaEnvio is not null and FechaAnulacion is null"
        Me.ListaAliasCampos = resources.GetString("$this.ListaAliasCampos")
        Me.ListaCampos = resources.GetString("$this.ListaCampos")
        Me.ListaCamposLlave = "IdFlujoDoc, IdImpresion, IdUsuarioEntrega"
        Me.ListaCamposOcultos = "PrimerRuteo,UltimoRuteo,NumRuteos,DiasTranRuteo"
        Me.Name = "DesRutearDocumentoNav"
        Me.OrdenRegistros = "FechaImpresion asc"
        Me.Tabla = "FlujosDocumentosImpresiones"
        Me.Text = "DesRutear Documentos no Entregados"
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.cboIdUsuario, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents cboIdUsuario As STIControles.stiComboBox

End Class
