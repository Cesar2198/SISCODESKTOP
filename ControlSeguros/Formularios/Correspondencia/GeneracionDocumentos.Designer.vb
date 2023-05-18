<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneracionDocumentos
    Inherits stiFomularios.stiReportes

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeneracionDocumentos))
        Me.cboTipoDocumento = New STIControles.stiComboBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.GridDoc = New STIControles.stiGrid
        Me.VistaDoc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.txtFechaEnDocumento = New STIControles.stiTextBox
        Me.txtNombreAtt = New STIControles.stiTextBox
        Me.txtCargoAtt = New STIControles.stiTextBox
        Me.lblAtt = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCargoFirma = New STIControles.stiTextBox
        Me.txtNombreFirma = New STIControles.stiTextBox
        Me.txtDestinatario = New STIControles.stiTextBox
        Me.cboFlujo = New STIControles.stiGridComboBox
        Me.txtNotasDocumento = New STIControles.stiTextBox
        Me.txtDireccion = New STIControles.stiTextBox
        Me.txtInicio = New STIControles.stiTextBox
        Me.txtFin = New STIControles.stiTextBox
        Me.chkDocSiniestro = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(496, 475)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(393, 475)
        Me.btnImprimir.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(599, 475)
        Me.btnSalir.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(576, 74)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Documentación de Correspondencia de Seguros"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.CampoAutoCompletar = 0
        Me.cboTipoDocumento.CampoBusqueda = False
        Me.cboTipoDocumento.CampoDisplay = 1
        Me.cboTipoDocumento.CampoEsLlave = False
        Me.cboTipoDocumento.CampoValor = 0
        Me.cboTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoDocumento.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.FilasVisibles = 589
        Me.cboTipoDocumento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoDocumento.LabelText = "Documento"
        Me.cboTipoDocumento.LabelWidth = 120
        Me.cboTipoDocumento.Lista = ""
        Me.cboTipoDocumento.Location = New System.Drawing.Point(12, 80)
        Me.cboTipoDocumento.MostrarBusquedaColumnas = False
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.NombreCampo = ""
        Me.cboTipoDocumento.Obligatorio = True
        Me.cboTipoDocumento.Query = ""
        Me.cboTipoDocumento.SelectIndex = 0
        Me.cboTipoDocumento.Size = New System.Drawing.Size(551, 20)
        Me.cboTipoDocumento.SoloLectura = False
        Me.cboTipoDocumento.StringConection = ""
        Me.cboTipoDocumento.TabIndex = 0
        Me.cboTipoDocumento.TextoNuevoItem = ""
        Me.cboTipoDocumento.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoDocumento.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(375, 101)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarCliente.TabIndex = 1
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 120
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 104)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(357, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 8
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 120
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 128)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(489, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 9
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'GridDoc
        '
        Me.GridDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDoc.ColumnasAdicionales = ""
        Me.GridDoc.Location = New System.Drawing.Point(12, 246)
        Me.GridDoc.MainView = Me.VistaDoc
        Me.GridDoc.Name = "GridDoc"
        Me.GridDoc.NombreTabla = ""
        Me.GridDoc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GridDoc.Size = New System.Drawing.Size(687, 158)
        Me.GridDoc.TabIndex = 3
        Me.GridDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaDoc})
        '
        'VistaDoc
        '
        Me.VistaDoc.GridControl = Me.GridDoc
        Me.VistaDoc.Name = "VistaDoc"
        Me.VistaDoc.OptionsCustomization.AllowRowSizing = True
        Me.VistaDoc.OptionsView.AutoCalcPreviewLineCount = True
        Me.VistaDoc.OptionsView.ShowAutoFilterRow = True
        Me.VistaDoc.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'txtFechaEnDocumento
        '
        Me.txtFechaEnDocumento.CampoBusqueda = True
        Me.txtFechaEnDocumento.CampoEsLlave = False
        Me.txtFechaEnDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnDocumento.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnDocumento.FechaActual = True
        Me.txtFechaEnDocumento.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnDocumento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnDocumento.LabelText = "Fecha en Documento"
        Me.txtFechaEnDocumento.LabelWidth = 120
        Me.txtFechaEnDocumento.Location = New System.Drawing.Point(12, 174)
        Me.txtFechaEnDocumento.MaxLength = 150
        Me.txtFechaEnDocumento.Name = "txtFechaEnDocumento"
        Me.txtFechaEnDocumento.NombreCampo = ""
        Me.txtFechaEnDocumento.Obligatorio = True
        Me.txtFechaEnDocumento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnDocumento.Size = New System.Drawing.Size(357, 20)
        Me.txtFechaEnDocumento.SoloLectura = False
        Me.txtFechaEnDocumento.TabIndex = 17
        Me.txtFechaEnDocumento.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnDocumento.Valor = Nothing
        '
        'txtNombreAtt
        '
        Me.txtNombreAtt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombreAtt.CampoBusqueda = False
        Me.txtNombreAtt.CampoEsLlave = False
        Me.txtNombreAtt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreAtt.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreAtt.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreAtt.FechaActual = False
        Me.txtNombreAtt.Formato = ""
        Me.txtNombreAtt.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreAtt.LabelText = "Nombre"
        Me.txtNombreAtt.LabelWidth = 50
        Me.txtNombreAtt.Location = New System.Drawing.Point(12, 427)
        Me.txtNombreAtt.MaxLength = 0
        Me.txtNombreAtt.Name = "txtNombreAtt"
        Me.txtNombreAtt.NombreCampo = ""
        Me.txtNombreAtt.Obligatorio = False
        Me.txtNombreAtt.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreAtt.Size = New System.Drawing.Size(330, 20)
        Me.txtNombreAtt.SoloLectura = False
        Me.txtNombreAtt.TabIndex = 22
        Me.txtNombreAtt.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreAtt.Valor = ""
        '
        'txtCargoAtt
        '
        Me.txtCargoAtt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCargoAtt.CampoBusqueda = False
        Me.txtCargoAtt.CampoEsLlave = False
        Me.txtCargoAtt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCargoAtt.ControlBackColor = System.Drawing.Color.White
        Me.txtCargoAtt.ControlForeColor = System.Drawing.Color.Black
        Me.txtCargoAtt.FechaActual = False
        Me.txtCargoAtt.Formato = ""
        Me.txtCargoAtt.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCargoAtt.LabelText = "Cargo"
        Me.txtCargoAtt.LabelWidth = 50
        Me.txtCargoAtt.Location = New System.Drawing.Point(12, 450)
        Me.txtCargoAtt.MaxLength = 0
        Me.txtCargoAtt.Name = "txtCargoAtt"
        Me.txtCargoAtt.NombreCampo = ""
        Me.txtCargoAtt.Obligatorio = False
        Me.txtCargoAtt.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCargoAtt.Size = New System.Drawing.Size(330, 20)
        Me.txtCargoAtt.SoloLectura = False
        Me.txtCargoAtt.TabIndex = 23
        Me.txtCargoAtt.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCargoAtt.Valor = ""
        '
        'lblAtt
        '
        Me.lblAtt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAtt.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAtt.Appearance.Options.UseFont = True
        Me.lblAtt.Location = New System.Drawing.Point(13, 409)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(125, 13)
        Me.lblAtt.TabIndex = 24
        Me.lblAtt.Text = "Documento Dirigido A:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(360, 409)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(139, 13)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "Documento Firmado Por:"
        '
        'txtCargoFirma
        '
        Me.txtCargoFirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCargoFirma.CampoBusqueda = False
        Me.txtCargoFirma.CampoEsLlave = False
        Me.txtCargoFirma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCargoFirma.ControlBackColor = System.Drawing.Color.White
        Me.txtCargoFirma.ControlForeColor = System.Drawing.Color.Black
        Me.txtCargoFirma.FechaActual = False
        Me.txtCargoFirma.Formato = ""
        Me.txtCargoFirma.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCargoFirma.LabelText = "Cargo"
        Me.txtCargoFirma.LabelWidth = 50
        Me.txtCargoFirma.Location = New System.Drawing.Point(360, 450)
        Me.txtCargoFirma.MaxLength = 0
        Me.txtCargoFirma.Name = "txtCargoFirma"
        Me.txtCargoFirma.NombreCampo = ""
        Me.txtCargoFirma.Obligatorio = False
        Me.txtCargoFirma.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCargoFirma.Size = New System.Drawing.Size(330, 20)
        Me.txtCargoFirma.SoloLectura = False
        Me.txtCargoFirma.TabIndex = 27
        Me.txtCargoFirma.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCargoFirma.Valor = ""
        '
        'txtNombreFirma
        '
        Me.txtNombreFirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombreFirma.CampoBusqueda = False
        Me.txtNombreFirma.CampoEsLlave = False
        Me.txtNombreFirma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreFirma.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreFirma.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreFirma.FechaActual = False
        Me.txtNombreFirma.Formato = ""
        Me.txtNombreFirma.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreFirma.LabelText = "Nombre"
        Me.txtNombreFirma.LabelWidth = 50
        Me.txtNombreFirma.Location = New System.Drawing.Point(360, 427)
        Me.txtNombreFirma.MaxLength = 0
        Me.txtNombreFirma.Name = "txtNombreFirma"
        Me.txtNombreFirma.NombreCampo = ""
        Me.txtNombreFirma.Obligatorio = False
        Me.txtNombreFirma.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreFirma.Size = New System.Drawing.Size(330, 20)
        Me.txtNombreFirma.SoloLectura = False
        Me.txtNombreFirma.TabIndex = 26
        Me.txtNombreFirma.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreFirma.Valor = ""
        '
        'txtDestinatario
        '
        Me.txtDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinatario.CampoBusqueda = False
        Me.txtDestinatario.CampoEsLlave = False
        Me.txtDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDestinatario.ControlBackColor = System.Drawing.Color.White
        Me.txtDestinatario.ControlForeColor = System.Drawing.Color.Black
        Me.txtDestinatario.FechaActual = False
        Me.txtDestinatario.Formato = ""
        Me.txtDestinatario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDestinatario.LabelText = "Destinatario"
        Me.txtDestinatario.LabelWidth = 65
        Me.txtDestinatario.Location = New System.Drawing.Point(373, 174)
        Me.txtDestinatario.MaxLength = 0
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.NombreCampo = ""
        Me.txtDestinatario.Obligatorio = False
        Me.txtDestinatario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDestinatario.Size = New System.Drawing.Size(329, 20)
        Me.txtDestinatario.SoloLectura = False
        Me.txtDestinatario.TabIndex = 28
        Me.txtDestinatario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDestinatario.Valor = ""
        '
        'cboFlujo
        '
        Me.cboFlujo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFlujo.CampoAutoCompletar = 0
        Me.cboFlujo.CampoBusqueda = False
        Me.cboFlujo.CampoDisplay = 1
        Me.cboFlujo.CampoEsLlave = False
        Me.cboFlujo.CampoValor = 0
        Me.cboFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFlujo.ControlBackColor = System.Drawing.Color.White
        Me.cboFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.cboFlujo.FilasVisibles = 0
        Me.cboFlujo.LabelOrietation = STIControles.stiGridComboBox.LOrientacion.Izquierda
        Me.cboFlujo.LabelText = "Flujo"
        Me.cboFlujo.LabelWidth = 120
        Me.cboFlujo.Lista = ""
        Me.cboFlujo.Location = New System.Drawing.Point(12, 151)
        Me.cboFlujo.Name = "cboFlujo"
        Me.cboFlujo.NombreCampo = ""
        Me.cboFlujo.Obligatorio = True
        Me.cboFlujo.Query = "select IdFlujoDoc as Flujo, Comentario, FechaInicia as Fecha, IdPoliza as [Póliza" & _
            "], NombreCliente as Cliente from FlujosDocumentos where estadoflujo = 'PENDIENTE" & _
            "'"
        Me.cboFlujo.SelectIndex = -2147483648
        Me.cboFlujo.Size = New System.Drawing.Size(690, 20)
        Me.cboFlujo.SoloLectura = False
        Me.cboFlujo.StringConection = ""
        Me.cboFlujo.TabIndex = 2
        Me.cboFlujo.TextoNuevoItem = "<Nuevo Flujo>"
        Me.cboFlujo.TipoDato = STIControles.stiGridComboBox.TipoContenido.Texto
        Me.cboFlujo.Valor = ""
        '
        'txtNotasDocumento
        '
        Me.txtNotasDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotasDocumento.CampoBusqueda = True
        Me.txtNotasDocumento.CampoEsLlave = False
        Me.txtNotasDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNotasDocumento.ControlBackColor = System.Drawing.Color.White
        Me.txtNotasDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.txtNotasDocumento.FechaActual = False
        Me.txtNotasDocumento.Formato = ""
        Me.txtNotasDocumento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNotasDocumento.LabelText = "Observaciones"
        Me.txtNotasDocumento.LabelWidth = 120
        Me.txtNotasDocumento.Location = New System.Drawing.Point(12, 221)
        Me.txtNotasDocumento.MaxLength = 150
        Me.txtNotasDocumento.Name = "txtNotasDocumento"
        Me.txtNotasDocumento.NombreCampo = ""
        Me.txtNotasDocumento.Obligatorio = False
        Me.txtNotasDocumento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotasDocumento.Size = New System.Drawing.Size(689, 20)
        Me.txtNotasDocumento.SoloLectura = False
        Me.txtNotasDocumento.TabIndex = 29
        Me.txtNotasDocumento.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNotasDocumento.Valor = ""
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.CampoBusqueda = True
        Me.txtDireccion.CampoEsLlave = False
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDireccion.ControlBackColor = System.Drawing.Color.White
        Me.txtDireccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDireccion.FechaActual = False
        Me.txtDireccion.Formato = ""
        Me.txtDireccion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDireccion.LabelText = "Dirección de Envío"
        Me.txtDireccion.LabelWidth = 120
        Me.txtDireccion.Location = New System.Drawing.Point(12, 197)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NombreCampo = ""
        Me.txtDireccion.Obligatorio = False
        Me.txtDireccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.Size = New System.Drawing.Size(689, 20)
        Me.txtDireccion.SoloLectura = False
        Me.txtDireccion.TabIndex = 30
        Me.txtDireccion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDireccion.Valor = ""
        '
        'txtInicio
        '
        Me.txtInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInicio.CampoBusqueda = True
        Me.txtInicio.CampoEsLlave = False
        Me.txtInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtInicio.ControlBackColor = System.Drawing.Color.White
        Me.txtInicio.ControlForeColor = System.Drawing.Color.Black
        Me.txtInicio.FechaActual = True
        Me.txtInicio.Formato = "dd/MMM/yyyy"
        Me.txtInicio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtInicio.LabelText = "Inicio Doc."
        Me.txtInicio.LabelWidth = 60
        Me.txtInicio.Location = New System.Drawing.Point(508, 102)
        Me.txtInicio.MaxLength = 150
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.NombreCampo = ""
        Me.txtInicio.Obligatorio = False
        Me.txtInicio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInicio.Size = New System.Drawing.Size(195, 20)
        Me.txtInicio.SoloLectura = False
        Me.txtInicio.TabIndex = 31
        Me.txtInicio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtInicio.Valor = Nothing
        '
        'txtFin
        '
        Me.txtFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFin.CampoBusqueda = True
        Me.txtFin.CampoEsLlave = False
        Me.txtFin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFin.ControlBackColor = System.Drawing.Color.White
        Me.txtFin.ControlForeColor = System.Drawing.Color.Black
        Me.txtFin.FechaActual = True
        Me.txtFin.Formato = "dd/MMM/yyyy"
        Me.txtFin.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFin.LabelText = "Fin Doc."
        Me.txtFin.LabelWidth = 60
        Me.txtFin.Location = New System.Drawing.Point(508, 125)
        Me.txtFin.MaxLength = 150
        Me.txtFin.Name = "txtFin"
        Me.txtFin.NombreCampo = ""
        Me.txtFin.Obligatorio = False
        Me.txtFin.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFin.Size = New System.Drawing.Size(195, 20)
        Me.txtFin.SoloLectura = False
        Me.txtFin.TabIndex = 32
        Me.txtFin.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFin.Valor = Nothing
        '
        'chkDocSiniestro
        '
        Me.chkDocSiniestro.AutoSize = True
        Me.chkDocSiniestro.Location = New System.Drawing.Point(572, 82)
        Me.chkDocSiniestro.Name = "chkDocSiniestro"
        Me.chkDocSiniestro.Size = New System.Drawing.Size(139, 17)
        Me.chkDocSiniestro.TabIndex = 33
        Me.chkDocSiniestro.Text = "Documento de Siniestro"
        Me.chkDocSiniestro.UseVisualStyleBackColor = True
        '
        'GeneracionDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 910
        Me.ClientSize = New System.Drawing.Size(713, 513)
        Me.Controls.Add(Me.chkDocSiniestro)
        Me.Controls.Add(Me.txtFin)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNotasDocumento)
        Me.Controls.Add(Me.cboFlujo)
        Me.Controls.Add(Me.txtDestinatario)
        Me.Controls.Add(Me.txtCargoFirma)
        Me.Controls.Add(Me.txtNombreFirma)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblAtt)
        Me.Controls.Add(Me.txtCargoAtt)
        Me.Controls.Add(Me.txtNombreAtt)
        Me.Controls.Add(Me.txtFechaEnDocumento)
        Me.Controls.Add(Me.GridDoc)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "GeneracionDocumentos"
        Me.Text = "Documentos Correspondencia"
        Me.Controls.SetChildIndex(Me.cboTipoDocumento, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.GridDoc, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnDocumento, 0)
        Me.Controls.SetChildIndex(Me.txtNombreAtt, 0)
        Me.Controls.SetChildIndex(Me.txtCargoAtt, 0)
        Me.Controls.SetChildIndex(Me.lblAtt, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtNombreFirma, 0)
        Me.Controls.SetChildIndex(Me.txtCargoFirma, 0)
        Me.Controls.SetChildIndex(Me.txtDestinatario, 0)
        Me.Controls.SetChildIndex(Me.cboFlujo, 0)
        Me.Controls.SetChildIndex(Me.txtNotasDocumento, 0)
        Me.Controls.SetChildIndex(Me.txtDireccion, 0)
        Me.Controls.SetChildIndex(Me.txtInicio, 0)
        Me.Controls.SetChildIndex(Me.txtFin, 0)
        Me.Controls.SetChildIndex(Me.chkDocSiniestro, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoDocumento As STIControles.stiComboBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents GridDoc As STIControles.stiGrid
    Friend WithEvents VistaDoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents txtFechaEnDocumento As STIControles.stiTextBox
    Friend WithEvents txtNombreAtt As STIControles.stiTextBox
    Friend WithEvents txtCargoAtt As STIControles.stiTextBox
    Friend WithEvents lblAtt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCargoFirma As STIControles.stiTextBox
    Friend WithEvents txtNombreFirma As STIControles.stiTextBox
    Friend WithEvents txtDestinatario As STIControles.stiTextBox
    Friend WithEvents cboFlujo As STIControles.stiGridComboBox
    Friend WithEvents txtNotasDocumento As STIControles.stiTextBox
    Friend WithEvents txtDireccion As STIControles.stiTextBox
    Friend WithEvents txtInicio As STIControles.stiTextBox
    Friend WithEvents txtFin As STIControles.stiTextBox
    Friend WithEvents chkDocSiniestro As System.Windows.Forms.CheckBox

End Class
