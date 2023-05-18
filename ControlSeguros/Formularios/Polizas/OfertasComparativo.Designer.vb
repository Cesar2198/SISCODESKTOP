<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfertasComparativo
    Inherits stiFomularios.stiMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfertasComparativo))
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.GridOferta = New STIControles.stiGrid
        Me.VistaOferta = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.bndGeneral = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.btnAddAseg = New DevExpress.XtraEditors.SimpleButton
        Me.btnRemAseg = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdComparativo = New STIControles.stiTextBox
        Me.txtFechaOferta = New STIControles.stiTextBox
        Me.btnAgregarRef = New DevExpress.XtraEditors.SimpleButton
        Me.btnEliminarRef = New DevExpress.XtraEditors.SimpleButton
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.cboEstadoOferta = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOferta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaOferta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(670, 457)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(28, 483)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(287, 457)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(380, 457)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(762, 457)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(576, 457)
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(717, 49)
        Me.lblNombreFormulario.Text = "Comparativo de Ofertas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(12, 483)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(730, 76)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 2
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(423, 106)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(414, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 3
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = True
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(423, 81)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 16
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = False
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = False
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 11
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 100
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(3, 152)
        Me.cboAseguradora.MostrarBusquedaColumnas = False
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = ""
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select IdAseguradora as Id,Nombre as Aseguradora from  Aseguradoras order by nomb" & _
            "re"
        Me.cboAseguradora.SelectIndex = 0
        Me.cboAseguradora.Size = New System.Drawing.Size(414, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 1
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'cboIdRamo
        '
        Me.cboIdRamo.CampoAutoCompletar = 0
        Me.cboIdRamo.CampoBusqueda = False
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = False
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 11
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdRamo.LabelText = "Ramo de Seguro"
        Me.cboIdRamo.LabelWidth = 100
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(3, 105)
        Me.cboIdRamo.MostrarBusquedaColumnas = False
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdRamo"
        Me.cboIdRamo.Obligatorio = True
        Me.cboIdRamo.Query = "select IdRamo as Id, NombreRamo as Ramo from RamoSeguros  order by NombreRamo"
        Me.cboIdRamo.SelectIndex = 0
        Me.cboIdRamo.Size = New System.Drawing.Size(414, 20)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 0
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'GridOferta
        '
        Me.GridOferta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOferta.ColumnasAdicionales = ""
        Me.GridOferta.Location = New System.Drawing.Point(3, 187)
        Me.GridOferta.MainView = Me.VistaOferta
        Me.GridOferta.Name = "GridOferta"
        Me.GridOferta.NombreTabla = ""
        Me.GridOferta.Size = New System.Drawing.Size(848, 266)
        Me.GridOferta.TabIndex = 21
        Me.GridOferta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaOferta})
        '
        'VistaOferta
        '
        Me.VistaOferta.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bndGeneral})
        Me.VistaOferta.GridControl = Me.GridOferta
        Me.VistaOferta.Name = "VistaOferta"
        Me.VistaOferta.OptionsCustomization.AllowRowSizing = True
        Me.VistaOferta.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaOferta.OptionsView.ShowFooter = True
        Me.VistaOferta.OptionsView.ShowGroupPanel = False
        '
        'bndGeneral
        '
        Me.bndGeneral.Caption = "COMPARATIVO DE OFERTAS"
        Me.bndGeneral.Name = "bndGeneral"
        Me.bndGeneral.Width = 207
        '
        'btnAddAseg
        '
        Me.btnAddAseg.Image = CType(resources.GetObject("btnAddAseg.Image"), System.Drawing.Image)
        Me.btnAddAseg.Location = New System.Drawing.Point(423, 149)
        Me.btnAddAseg.Name = "btnAddAseg"
        Me.btnAddAseg.Size = New System.Drawing.Size(26, 23)
        Me.btnAddAseg.TabIndex = 5
        '
        'btnRemAseg
        '
        Me.btnRemAseg.Image = CType(resources.GetObject("btnRemAseg.Image"), System.Drawing.Image)
        Me.btnRemAseg.Location = New System.Drawing.Point(455, 149)
        Me.btnRemAseg.Name = "btnRemAseg"
        Me.btnRemAseg.Size = New System.Drawing.Size(26, 23)
        Me.btnRemAseg.TabIndex = 6
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(473, 457)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "&Imprimir"
        '
        'txtIdComparativo
        '
        Me.txtIdComparativo.CampoBusqueda = True
        Me.txtIdComparativo.CampoEsLlave = True
        Me.txtIdComparativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdComparativo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdComparativo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdComparativo.FechaActual = False
        Me.txtIdComparativo.Formato = ""
        Me.txtIdComparativo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdComparativo.LabelText = "ID Comparativo"
        Me.txtIdComparativo.LabelWidth = 100
        Me.txtIdComparativo.Location = New System.Drawing.Point(143, 56)
        Me.txtIdComparativo.MaxLength = 25
        Me.txtIdComparativo.Name = "txtIdComparativo"
        Me.txtIdComparativo.NombreCampo = "IdComparativo"
        Me.txtIdComparativo.Obligatorio = True
        Me.txtIdComparativo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdComparativo.Size = New System.Drawing.Size(274, 20)
        Me.txtIdComparativo.SoloLectura = False
        Me.txtIdComparativo.TabIndex = 25
        Me.txtIdComparativo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdComparativo.Valor = ""
        '
        'txtFechaOferta
        '
        Me.txtFechaOferta.CampoBusqueda = True
        Me.txtFechaOferta.CampoEsLlave = False
        Me.txtFechaOferta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaOferta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaOferta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaOferta.FechaActual = False
        Me.txtFechaOferta.Formato = "dd/MMM/yyyy"
        Me.txtFechaOferta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaOferta.LabelText = "Fecha Oferta"
        Me.txtFechaOferta.LabelWidth = 100
        Me.txtFechaOferta.Location = New System.Drawing.Point(525, 129)
        Me.txtFechaOferta.MaxLength = 150
        Me.txtFechaOferta.Name = "txtFechaOferta"
        Me.txtFechaOferta.NombreCampo = "FechaOferta"
        Me.txtFechaOferta.Obligatorio = True
        Me.txtFechaOferta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaOferta.Size = New System.Drawing.Size(312, 20)
        Me.txtFechaOferta.SoloLectura = False
        Me.txtFechaOferta.TabIndex = 4
        Me.txtFechaOferta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaOferta.Valor = Nothing
        '
        'btnAgregarRef
        '
        Me.btnAgregarRef.Location = New System.Drawing.Point(621, 158)
        Me.btnAgregarRef.Name = "btnAgregarRef"
        Me.btnAgregarRef.Size = New System.Drawing.Size(112, 23)
        Me.btnAgregarRef.TabIndex = 26
        Me.btnAgregarRef.Text = "Agregar Referente"
        '
        'btnEliminarRef
        '
        Me.btnEliminarRef.Location = New System.Drawing.Point(739, 158)
        Me.btnEliminarRef.Name = "btnEliminarRef"
        Me.btnEliminarRef.Size = New System.Drawing.Size(112, 23)
        Me.btnEliminarRef.TabIndex = 27
        Me.btnEliminarRef.Text = "Eliminar Referente"
        '
        'cboEjecutivoCta
        '
        Me.cboEjecutivoCta.CampoAutoCompletar = 0
        Me.cboEjecutivoCta.CampoBusqueda = False
        Me.cboEjecutivoCta.CampoDisplay = 1
        Me.cboEjecutivoCta.CampoEsLlave = False
        Me.cboEjecutivoCta.CampoValor = 0
        Me.cboEjecutivoCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjecutivoCta.ControlBackColor = System.Drawing.Color.White
        Me.cboEjecutivoCta.ControlForeColor = System.Drawing.Color.Black
        Me.cboEjecutivoCta.FilasVisibles = 11
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cta."
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(3, 129)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = True
        Me.cboEjecutivoCta.Query = "select IdUsuario as Id, NombreUsuario as Nombre from Usuarios where EsEjecutivo =" & _
            " 'S'"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(414, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 28
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'cboEstadoOferta
        '
        Me.cboEstadoOferta.CampoAutoCompletar = 0
        Me.cboEstadoOferta.CampoBusqueda = False
        Me.cboEstadoOferta.CampoDisplay = 1
        Me.cboEstadoOferta.CampoEsLlave = False
        Me.cboEstadoOferta.CampoValor = 0
        Me.cboEstadoOferta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoOferta.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoOferta.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoOferta.FilasVisibles = 11
        Me.cboEstadoOferta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoOferta.LabelText = "Estado Oferta"
        Me.cboEstadoOferta.LabelWidth = 100
        Me.cboEstadoOferta.Lista = "PENDIENTE Oferta Pendiente|ACEPTADA Oferta Aceptada|RECHAZADA Oferta Rechazada|ES" & _
            "POLIZA Convertida a Póliza|ENTRAMITE En Trámite"
        Me.cboEstadoOferta.Location = New System.Drawing.Point(423, 56)
        Me.cboEstadoOferta.MostrarBusquedaColumnas = False
        Me.cboEstadoOferta.Name = "cboEstadoOferta"
        Me.cboEstadoOferta.NombreCampo = "EstadoOferta"
        Me.cboEstadoOferta.Obligatorio = True
        Me.cboEstadoOferta.Query = ""
        Me.cboEstadoOferta.SelectIndex = 0
        Me.cboEstadoOferta.Size = New System.Drawing.Size(300, 20)
        Me.cboEstadoOferta.SoloLectura = False
        Me.cboEstadoOferta.StringConection = ""
        Me.cboEstadoOferta.TabIndex = 29
        Me.cboEstadoOferta.TextoNuevoItem = ""
        Me.cboEstadoOferta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoOferta.Valor = ""
        '
        'OfertasComparativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 502
        Me.ClientSize = New System.Drawing.Size(856, 493)
        Me.Controls.Add(Me.cboEstadoOferta)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.btnEliminarRef)
        Me.Controls.Add(Me.btnAgregarRef)
        Me.Controls.Add(Me.txtFechaOferta)
        Me.Controls.Add(Me.txtIdComparativo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnRemAseg)
        Me.Controls.Add(Me.btnAddAseg)
        Me.Controls.Add(Me.GridOferta)
        Me.Controls.Add(Me.cboIdRamo)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Name = "OfertasComparativo"
        Me.SeguirAlGrabarActualizar = True
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Comparativo de Ofertas"
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.cboIdRamo, 0)
        Me.Controls.SetChildIndex(Me.GridOferta, 0)
        Me.Controls.SetChildIndex(Me.btnAddAseg, 0)
        Me.Controls.SetChildIndex(Me.btnRemAseg, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.txtIdComparativo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaOferta, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarRef, 0)
        Me.Controls.SetChildIndex(Me.btnEliminarRef, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoOferta, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOferta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaOferta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents GridOferta As STIControles.stiGrid
    Friend WithEvents btnAddAseg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemAseg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VistaOferta As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents bndGeneral As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdComparativo As STIControles.stiTextBox
    Friend WithEvents txtFechaOferta As STIControles.stiTextBox
    Friend WithEvents btnAgregarRef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarRef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents cboEstadoOferta As STIControles.stiComboBox

End Class
