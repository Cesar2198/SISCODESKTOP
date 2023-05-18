<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarFacturas))
        Me.btnBuscarArchivo = New DevExpress.XtraEditors.SimpleButton
        Me.txtArchivo = New STIControles.stiTextBox
        Me.Barra = New System.Windows.Forms.ProgressBar
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GridImportar = New STIControles.stiGrid
        Me.VistaImportar = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblMensaje = New DevExpress.XtraEditors.LabelControl
        Me.GridAnalizar = New STIControles.stiGrid
        Me.VistaAnalizar = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAnalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaAnalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(433, 448)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.Options.UseTextOptions = True
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscar.Location = New System.Drawing.Point(514, 296)
        Me.btnBuscar.Size = New System.Drawing.Size(93, 35)
        Me.btnBuscar.Text = "A&nalizar Archivo"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(341, 448)
        Me.btnNuevo.Text = "&Modelo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(172, 448)
        Me.btnGuardar.Size = New System.Drawing.Size(168, 36)
        Me.btnGuardar.Text = "Importar &Facturas"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(525, 448)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(514, 337)
        Me.btnEliminar.Size = New System.Drawing.Size(93, 34)
        Me.btnEliminar.Text = "&Imprimir"
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(480, 74)
        Me.lblNombreFormulario.Text = "Importar Facturas Desde Excel"
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
        Me.btnGuardarComo.Image = CType(resources.GetObject("btnGuardarComo.Image"), System.Drawing.Image)
        Me.btnGuardarComo.Location = New System.Drawing.Point(516, 377)
        Me.btnGuardarComo.Size = New System.Drawing.Size(91, 36)
        Me.btnGuardarComo.Text = "Detener Análisis"
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscarArchivo
        '
        Me.btnBuscarArchivo.Appearance.Options.UseTextOptions = True
        Me.btnBuscarArchivo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarArchivo.Image = CType(resources.GetObject("btnBuscarArchivo.Image"), System.Drawing.Image)
        Me.btnBuscarArchivo.Location = New System.Drawing.Point(11, 81)
        Me.btnBuscarArchivo.Name = "btnBuscarArchivo"
        Me.btnBuscarArchivo.Size = New System.Drawing.Size(78, 44)
        Me.btnBuscarArchivo.TabIndex = 37
        Me.btnBuscarArchivo.Text = "Buscar Archivo"
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
        Me.txtArchivo.Location = New System.Drawing.Point(95, 81)
        Me.txtArchivo.MaxLength = 0
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.NombreCampo = "NombreCliente"
        Me.txtArchivo.Obligatorio = True
        Me.txtArchivo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArchivo.Size = New System.Drawing.Size(507, 20)
        Me.txtArchivo.SoloLectura = False
        Me.txtArchivo.TabIndex = 36
        Me.txtArchivo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtArchivo.Valor = ""
        '
        'Barra
        '
        Me.Barra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Barra.Location = New System.Drawing.Point(3, 457)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(129, 23)
        Me.Barra.TabIndex = 38
        Me.Barra.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GridImportar
        '
        Me.GridImportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridImportar.Location = New System.Drawing.Point(12, 131)
        Me.GridImportar.MainView = Me.VistaImportar
        Me.GridImportar.Name = "GridImportar"
        Me.GridImportar.NombreTabla = ""
        Me.GridImportar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridImportar.Size = New System.Drawing.Size(595, 159)
        Me.GridImportar.TabIndex = 39
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
        'lblMensaje
        '
        Me.lblMensaje.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.Appearance.Options.UseFont = True
        Me.lblMensaje.Location = New System.Drawing.Point(173, 107)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(57, 13)
        Me.lblMensaje.TabIndex = 40
        Me.lblMensaje.Text = "                   "
        '
        'GridAnalizar
        '
        Me.GridAnalizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridAnalizar.Location = New System.Drawing.Point(11, 296)
        Me.GridAnalizar.MainView = Me.VistaAnalizar
        Me.GridAnalizar.Name = "GridAnalizar"
        Me.GridAnalizar.NombreTabla = ""
        Me.GridAnalizar.Size = New System.Drawing.Size(497, 146)
        Me.GridAnalizar.TabIndex = 41
        Me.GridAnalizar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaAnalizar, Me.GridView2})
        '
        'VistaAnalizar
        '
        Me.VistaAnalizar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.VistaAnalizar.GridControl = Me.GridAnalizar
        Me.VistaAnalizar.Name = "VistaAnalizar"
        Me.VistaAnalizar.OptionsView.ShowFooter = True
        Me.VistaAnalizar.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fila"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Fila"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.DisplayFormat = "{0}"
        Me.GridColumn6.SummaryItem.FieldName = "Numero"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 53
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Mensaje"
        Me.GridColumn7.FieldName = "Mensaje"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 537
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Fallo"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Fallo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 63
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridAnalizar
        Me.GridView2.Name = "GridView2"
        '
        'ImportarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 110
        Me.ClientSize = New System.Drawing.Size(619, 484)
        Me.Controls.Add(Me.GridAnalizar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.GridImportar)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.btnBuscarArchivo)
        Me.Controls.Add(Me.txtArchivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImportarFacturas"
        Me.Text = "Importar Facturas"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarArchivo, 0)
        Me.Controls.SetChildIndex(Me.Barra, 0)
        Me.Controls.SetChildIndex(Me.GridImportar, 0)
        Me.Controls.SetChildIndex(Me.lblMensaje, 0)
        Me.Controls.SetChildIndex(Me.GridAnalizar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAnalizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaAnalizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarArchivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtArchivo As STIControles.stiTextBox
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GridImportar As STIControles.stiGrid
    Friend WithEvents VistaImportar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblMensaje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridAnalizar As STIControles.stiGrid
    Friend WithEvents VistaAnalizar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView

End Class
