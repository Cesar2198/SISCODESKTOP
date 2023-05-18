<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarCertificados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarCertificados))
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtArchivo = New STIControles.stiTextBox
        Me.btnBuscarArchivo = New DevExpress.XtraEditors.SimpleButton
        Me.GridImportar = New STIControles.stiGrid
        Me.VistaImportar = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Barra = New System.Windows.Forms.ProgressBar
        Me.lblMensaje = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(417, 410)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(323, 410)
        Me.btnBuscar.Text = "&Modelo"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(-44, 436)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(140, 410)
        Me.btnGuardar.Size = New System.Drawing.Size(182, 36)
        Me.btnGuardar.Text = "&Importar Certificados"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(509, 410)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(-4, 436)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'LabelControl1
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(464, 74)
        Me.lblNombreFormulario.Text = "Importar Certificados desde Excel"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(-24, 436)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Appearance.Options.UseTextOptions = True
        Me.btnBuscaPoliza.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(8, 81)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(78, 43)
        Me.btnBuscaPoliza.TabIndex = 33
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Appearance.Options.UseTextOptions = True
        Me.btnBuscarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(8, 130)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(78, 44)
        Me.btnBuscarCliente.TabIndex = 30
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 75
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(92, 103)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto [Producto], Descripcion [Descripción] from Productos order by D" & _
            "escripcion asc"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(507, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 29
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
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
        Me.txtNombreCliente.LabelText = "Nombre"
        Me.txtNombreCliente.LabelWidth = 75
        Me.txtNombreCliente.Location = New System.Drawing.Point(92, 154)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(507, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 32
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 75
        Me.txtIdCliente.Location = New System.Drawing.Point(92, 130)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(279, 20)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 31
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 75
        Me.txtIdPoliza.Location = New System.Drawing.Point(92, 81)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(279, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 28
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtArchivo
        '
        Me.txtArchivo.CampoBusqueda = True
        Me.txtArchivo.CampoEsLlave = False
        Me.txtArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtArchivo.ControlBackColor = System.Drawing.Color.White
        Me.txtArchivo.ControlForeColor = System.Drawing.Color.Black
        Me.txtArchivo.FechaActual = False
        Me.txtArchivo.Formato = ""
        Me.txtArchivo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtArchivo.LabelText = "Archivo"
        Me.txtArchivo.LabelWidth = 75
        Me.txtArchivo.Location = New System.Drawing.Point(92, 180)
        Me.txtArchivo.MaxLength = 0
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.NombreCampo = "NombreCliente"
        Me.txtArchivo.Obligatorio = True
        Me.txtArchivo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArchivo.Size = New System.Drawing.Size(507, 20)
        Me.txtArchivo.SoloLectura = False
        Me.txtArchivo.TabIndex = 34
        Me.txtArchivo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtArchivo.Valor = ""
        '
        'btnBuscarArchivo
        '
        Me.btnBuscarArchivo.Appearance.Options.UseTextOptions = True
        Me.btnBuscarArchivo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarArchivo.Image = CType(resources.GetObject("btnBuscarArchivo.Image"), System.Drawing.Image)
        Me.btnBuscarArchivo.Location = New System.Drawing.Point(8, 180)
        Me.btnBuscarArchivo.Name = "btnBuscarArchivo"
        Me.btnBuscarArchivo.Size = New System.Drawing.Size(78, 44)
        Me.btnBuscarArchivo.TabIndex = 35
        Me.btnBuscarArchivo.Text = "Buscar Archivo"
        '
        'GridImportar
        '
        Me.GridImportar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridImportar.Location = New System.Drawing.Point(12, 230)
        Me.GridImportar.MainView = Me.VistaImportar
        Me.GridImportar.Name = "GridImportar"
        Me.GridImportar.NombreTabla = ""
        Me.GridImportar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridImportar.Size = New System.Drawing.Size(587, 174)
        Me.GridImportar.TabIndex = 36
        Me.GridImportar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaImportar})
        '
        'VistaImportar
        '
        Me.VistaImportar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.VistaImportar.GridControl = Me.GridImportar
        Me.VistaImportar.Name = "VistaImportar"
        Me.VistaImportar.OptionsBehavior.Editable = False
        Me.VistaImportar.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "#"
        Me.GridColumn1.FieldName = "Columna"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 42
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Columna en Archivo"
        Me.GridColumn2.FieldName = "Colarchivo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 158
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tipo"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn3.FieldName = "Tipo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 139
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Observación"
        Me.GridColumn4.FieldName = "Observacion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 227
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Campo"
        Me.GridColumn5.FieldName = "Campo"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Barra
        '
        Me.Barra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Barra.Location = New System.Drawing.Point(12, 414)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(111, 23)
        Me.Barra.TabIndex = 37
        Me.Barra.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.Appearance.Options.UseFont = True
        Me.lblMensaje.Location = New System.Drawing.Point(173, 206)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(57, 13)
        Me.lblMensaje.TabIndex = 38
        Me.lblMensaje.Text = "                   "
        '
        'ImportarCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 109
        Me.ClientSize = New System.Drawing.Size(603, 446)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.GridImportar)
        Me.Controls.Add(Me.btnBuscarArchivo)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "ImportarCertificados"
        Me.Text = "Importar Certificados"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarArchivo, 0)
        Me.Controls.SetChildIndex(Me.GridImportar, 0)
        Me.Controls.SetChildIndex(Me.Barra, 0)
        Me.Controls.SetChildIndex(Me.lblMensaje, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtArchivo As STIControles.stiTextBox
    Friend WithEvents btnBuscarArchivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridImportar As STIControles.stiGrid
    Friend WithEvents VistaImportar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents lblMensaje As DevExpress.XtraEditors.LabelControl

End Class
