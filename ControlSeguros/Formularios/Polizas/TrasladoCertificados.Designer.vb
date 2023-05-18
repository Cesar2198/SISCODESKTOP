<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrasladoCertificados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrasladoCertificados))
        Me.btnBuscarPolizaOrigen = New DevExpress.XtraEditors.SimpleButton
        Me.txtClienteOrigen = New STIControles.stiTextBox
        Me.cboProductoOrigen = New STIControles.stiComboBox
        Me.txtPolizaOrigen = New STIControles.stiTextBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnBuscarPolizaDestino = New DevExpress.XtraEditors.SimpleButton
        Me.txtClienteDestino = New STIControles.stiTextBox
        Me.cboProductoDestino = New STIControles.stiComboBox
        Me.txtPolizaDestino = New STIControles.stiTextBox
        Me.GridCertificados = New DevExpress.XtraGrid.GridControl
        Me.VistaCertificados = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(423, 501)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(165, 527)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(-35, 527)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(289, 501)
        Me.btnGuardar.Size = New System.Drawing.Size(131, 36)
        Me.btnGuardar.Text = "&Trasladar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(518, 501)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(181, 527)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(473, 74)
        Me.lblNombreFormulario.Text = "Traslado de Certificados"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(150, 527)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscarPolizaOrigen
        '
        Me.btnBuscarPolizaOrigen.Image = CType(resources.GetObject("btnBuscarPolizaOrigen.Image"), System.Drawing.Image)
        Me.btnBuscarPolizaOrigen.Location = New System.Drawing.Point(352, 140)
        Me.btnBuscarPolizaOrigen.Name = "btnBuscarPolizaOrigen"
        Me.btnBuscarPolizaOrigen.Size = New System.Drawing.Size(134, 27)
        Me.btnBuscarPolizaOrigen.TabIndex = 34
        Me.btnBuscarPolizaOrigen.Text = "Buscar Póliza Origen"
        '
        'txtClienteOrigen
        '
        Me.txtClienteOrigen.CampoBusqueda = False
        Me.txtClienteOrigen.CampoEsLlave = False
        Me.txtClienteOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtClienteOrigen.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtClienteOrigen.ControlForeColor = System.Drawing.Color.Black
        Me.txtClienteOrigen.FechaActual = False
        Me.txtClienteOrigen.Formato = ""
        Me.txtClienteOrigen.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtClienteOrigen.LabelText = "Cliente"
        Me.txtClienteOrigen.LabelWidth = 150
        Me.txtClienteOrigen.Location = New System.Drawing.Point(35, 195)
        Me.txtClienteOrigen.MaxLength = 0
        Me.txtClienteOrigen.Name = "txtClienteOrigen"
        Me.txtClienteOrigen.NombreCampo = ""
        Me.txtClienteOrigen.Obligatorio = True
        Me.txtClienteOrigen.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClienteOrigen.Size = New System.Drawing.Size(566, 20)
        Me.txtClienteOrigen.SoloLectura = True
        Me.txtClienteOrigen.TabIndex = 38
        Me.txtClienteOrigen.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtClienteOrigen.Valor = ""
        '
        'cboProductoOrigen
        '
        Me.cboProductoOrigen.CampoAutoCompletar = 0
        Me.cboProductoOrigen.CampoBusqueda = False
        Me.cboProductoOrigen.CampoDisplay = 1
        Me.cboProductoOrigen.CampoEsLlave = False
        Me.cboProductoOrigen.CampoValor = 0
        Me.cboProductoOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProductoOrigen.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboProductoOrigen.ControlForeColor = System.Drawing.Color.Black
        Me.cboProductoOrigen.FilasVisibles = 74
        Me.cboProductoOrigen.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProductoOrigen.LabelText = "Producto"
        Me.cboProductoOrigen.LabelWidth = 150
        Me.cboProductoOrigen.Lista = ""
        Me.cboProductoOrigen.Location = New System.Drawing.Point(35, 171)
        Me.cboProductoOrigen.MostrarBusquedaColumnas = False
        Me.cboProductoOrigen.Name = "cboProductoOrigen"
        Me.cboProductoOrigen.NombreCampo = ""
        Me.cboProductoOrigen.Obligatorio = True
        Me.cboProductoOrigen.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProductoOrigen.SelectIndex = 0
        Me.cboProductoOrigen.Size = New System.Drawing.Size(566, 20)
        Me.cboProductoOrigen.SoloLectura = True
        Me.cboProductoOrigen.StringConection = ""
        Me.cboProductoOrigen.TabIndex = 37
        Me.cboProductoOrigen.TextoNuevoItem = ""
        Me.cboProductoOrigen.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProductoOrigen.Valor = ""
        '
        'txtPolizaOrigen
        '
        Me.txtPolizaOrigen.CampoBusqueda = False
        Me.txtPolizaOrigen.CampoEsLlave = False
        Me.txtPolizaOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPolizaOrigen.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtPolizaOrigen.ControlForeColor = System.Drawing.Color.Black
        Me.txtPolizaOrigen.FechaActual = False
        Me.txtPolizaOrigen.Formato = ""
        Me.txtPolizaOrigen.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPolizaOrigen.LabelText = "Número Póliza Origen"
        Me.txtPolizaOrigen.LabelWidth = 150
        Me.txtPolizaOrigen.Location = New System.Drawing.Point(35, 148)
        Me.txtPolizaOrigen.MaxLength = 0
        Me.txtPolizaOrigen.Name = "txtPolizaOrigen"
        Me.txtPolizaOrigen.NombreCampo = ""
        Me.txtPolizaOrigen.Obligatorio = True
        Me.txtPolizaOrigen.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPolizaOrigen.Size = New System.Drawing.Size(300, 20)
        Me.txtPolizaOrigen.SoloLectura = True
        Me.txtPolizaOrigen.TabIndex = 36
        Me.txtPolizaOrigen.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPolizaOrigen.Valor = ""
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LabelControl2.Location = New System.Drawing.Point(60, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(530, 48)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "Este programa permite copiar certificados de una póliza a otra, es importante que" & _
            " los número de certificados no existan en la póliza destino o el proceso no será" & _
            " completado."
        '
        'btnBuscarPolizaDestino
        '
        Me.btnBuscarPolizaDestino.Image = CType(resources.GetObject("btnBuscarPolizaDestino.Image"), System.Drawing.Image)
        Me.btnBuscarPolizaDestino.Location = New System.Drawing.Point(353, 223)
        Me.btnBuscarPolizaDestino.Name = "btnBuscarPolizaDestino"
        Me.btnBuscarPolizaDestino.Size = New System.Drawing.Size(134, 27)
        Me.btnBuscarPolizaDestino.TabIndex = 39
        Me.btnBuscarPolizaDestino.Text = "Buscar Póliza Destino"
        '
        'txtClienteDestino
        '
        Me.txtClienteDestino.CampoBusqueda = False
        Me.txtClienteDestino.CampoEsLlave = False
        Me.txtClienteDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtClienteDestino.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtClienteDestino.ControlForeColor = System.Drawing.Color.Black
        Me.txtClienteDestino.FechaActual = False
        Me.txtClienteDestino.Formato = ""
        Me.txtClienteDestino.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtClienteDestino.LabelText = "Cliente"
        Me.txtClienteDestino.LabelWidth = 150
        Me.txtClienteDestino.Location = New System.Drawing.Point(36, 278)
        Me.txtClienteDestino.MaxLength = 0
        Me.txtClienteDestino.Name = "txtClienteDestino"
        Me.txtClienteDestino.NombreCampo = ""
        Me.txtClienteDestino.Obligatorio = True
        Me.txtClienteDestino.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClienteDestino.Size = New System.Drawing.Size(566, 20)
        Me.txtClienteDestino.SoloLectura = True
        Me.txtClienteDestino.TabIndex = 42
        Me.txtClienteDestino.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtClienteDestino.Valor = ""
        '
        'cboProductoDestino
        '
        Me.cboProductoDestino.CampoAutoCompletar = 0
        Me.cboProductoDestino.CampoBusqueda = False
        Me.cboProductoDestino.CampoDisplay = 1
        Me.cboProductoDestino.CampoEsLlave = False
        Me.cboProductoDestino.CampoValor = 0
        Me.cboProductoDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProductoDestino.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboProductoDestino.ControlForeColor = System.Drawing.Color.Black
        Me.cboProductoDestino.FilasVisibles = 118
        Me.cboProductoDestino.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProductoDestino.LabelText = "Producto"
        Me.cboProductoDestino.LabelWidth = 150
        Me.cboProductoDestino.Lista = ""
        Me.cboProductoDestino.Location = New System.Drawing.Point(36, 254)
        Me.cboProductoDestino.MostrarBusquedaColumnas = False
        Me.cboProductoDestino.Name = "cboProductoDestino"
        Me.cboProductoDestino.NombreCampo = ""
        Me.cboProductoDestino.Obligatorio = True
        Me.cboProductoDestino.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProductoDestino.SelectIndex = 0
        Me.cboProductoDestino.Size = New System.Drawing.Size(566, 20)
        Me.cboProductoDestino.SoloLectura = True
        Me.cboProductoDestino.StringConection = ""
        Me.cboProductoDestino.TabIndex = 41
        Me.cboProductoDestino.TextoNuevoItem = ""
        Me.cboProductoDestino.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProductoDestino.Valor = ""
        '
        'txtPolizaDestino
        '
        Me.txtPolizaDestino.CampoBusqueda = False
        Me.txtPolizaDestino.CampoEsLlave = False
        Me.txtPolizaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPolizaDestino.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtPolizaDestino.ControlForeColor = System.Drawing.Color.Black
        Me.txtPolizaDestino.FechaActual = False
        Me.txtPolizaDestino.Formato = ""
        Me.txtPolizaDestino.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPolizaDestino.LabelText = "Número Póliza Destino"
        Me.txtPolizaDestino.LabelWidth = 150
        Me.txtPolizaDestino.Location = New System.Drawing.Point(36, 231)
        Me.txtPolizaDestino.MaxLength = 0
        Me.txtPolizaDestino.Name = "txtPolizaDestino"
        Me.txtPolizaDestino.NombreCampo = ""
        Me.txtPolizaDestino.Obligatorio = True
        Me.txtPolizaDestino.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPolizaDestino.Size = New System.Drawing.Size(300, 20)
        Me.txtPolizaDestino.SoloLectura = True
        Me.txtPolizaDestino.TabIndex = 40
        Me.txtPolizaDestino.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPolizaDestino.Valor = ""
        '
        'GridCertificados
        '
        Me.GridCertificados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCertificados.Location = New System.Drawing.Point(35, 304)
        Me.GridCertificados.MainView = Me.VistaCertificados
        Me.GridCertificados.Name = "GridCertificados"
        Me.GridCertificados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridCertificados.Size = New System.Drawing.Size(565, 191)
        Me.GridCertificados.TabIndex = 43
        Me.GridCertificados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaCertificados, Me.GridView2})
        '
        'VistaCertificados
        '
        Me.VistaCertificados.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaCertificados.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaCertificados.ColumnPanelRowHeight = 35
        Me.VistaCertificados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.VistaCertificados.GridControl = Me.GridCertificados
        Me.VistaCertificados.Name = "VistaCertificados"
        Me.VistaCertificados.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Certificado"
        Me.GridColumn1.FieldName = "IdCertificado"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 67
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Certificado Aseguradora"
        Me.GridColumn2.FieldName = "IdCertificadoAseguradora"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 77
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Vigencia Desde"
        Me.GridColumn3.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "VigenciaDesde"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 84
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Exclusíon"
        Me.GridColumn4.FieldName = "FechaExclusion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 89
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Asegurado"
        Me.GridColumn5.FieldName = "NombreCliente"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 181
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Incluir"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn6.FieldName = "Incluir"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 48
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridCertificados
        Me.GridView2.Name = "GridView2"
        '
        'TrasladoCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(612, 537)
        Me.Controls.Add(Me.GridCertificados)
        Me.Controls.Add(Me.btnBuscarPolizaDestino)
        Me.Controls.Add(Me.txtClienteDestino)
        Me.Controls.Add(Me.cboProductoDestino)
        Me.Controls.Add(Me.txtPolizaDestino)
        Me.Controls.Add(Me.btnBuscarPolizaOrigen)
        Me.Controls.Add(Me.txtClienteOrigen)
        Me.Controls.Add(Me.cboProductoOrigen)
        Me.Controls.Add(Me.txtPolizaOrigen)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "TrasladoCertificados"
        Me.Text = "Traslado de Certificados"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtPolizaOrigen, 0)
        Me.Controls.SetChildIndex(Me.cboProductoOrigen, 0)
        Me.Controls.SetChildIndex(Me.txtClienteOrigen, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPolizaOrigen, 0)
        Me.Controls.SetChildIndex(Me.txtPolizaDestino, 0)
        Me.Controls.SetChildIndex(Me.cboProductoDestino, 0)
        Me.Controls.SetChildIndex(Me.txtClienteDestino, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPolizaDestino, 0)
        Me.Controls.SetChildIndex(Me.GridCertificados, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarPolizaOrigen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClienteOrigen As STIControles.stiTextBox
    Friend WithEvents cboProductoOrigen As STIControles.stiComboBox
    Friend WithEvents txtPolizaOrigen As STIControles.stiTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscarPolizaDestino As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClienteDestino As STIControles.stiTextBox
    Friend WithEvents cboProductoDestino As STIControles.stiComboBox
    Friend WithEvents txtPolizaDestino As STIControles.stiTextBox
    Friend WithEvents GridCertificados As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaCertificados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

End Class
