<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlujosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlujosMan))
        Me.cboCategoriaFlujo = New STIControles.stiComboBox
        Me.txtIdFlujo = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtFechaCreacion = New STIControles.stiTextBox
        Me.StiComboBox2 = New STIControles.stiComboBox
        Me.GridPasos = New STIControles.stiGrid
        Me.VistaPasos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPasos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPasos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(651, 411)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(467, 411)
        Me.btnBuscar.TabIndex = 9
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(190, 411)
        Me.btnNuevo.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(282, 411)
        Me.btnGuardar.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(743, 411)
        Me.btnSalir.TabIndex = 12
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(559, 411)
        Me.btnEliminar.TabIndex = 10
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(698, 74)
        Me.lblNombreFormulario.Text = "Flujos de Trabajo y Correspondencia"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(375, 411)
        Me.btnGuardarComo.TabIndex = 8
        '
        'cboCategoriaFlujo
        '
        Me.cboCategoriaFlujo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCategoriaFlujo.CampoAutoCompletar = 0
        Me.cboCategoriaFlujo.CampoBusqueda = False
        Me.cboCategoriaFlujo.CampoDisplay = 1
        Me.cboCategoriaFlujo.CampoEsLlave = False
        Me.cboCategoriaFlujo.CampoValor = 0
        Me.cboCategoriaFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCategoriaFlujo.ControlBackColor = System.Drawing.Color.White
        Me.cboCategoriaFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.cboCategoriaFlujo.FilasVisibles = 7
        Me.cboCategoriaFlujo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboCategoriaFlujo.LabelText = "Categoría"
        Me.cboCategoriaFlujo.LabelWidth = 100
        Me.cboCategoriaFlujo.Lista = ""
        Me.cboCategoriaFlujo.Location = New System.Drawing.Point(12, 127)
        Me.cboCategoriaFlujo.Name = "cboCategoriaFlujo"
        Me.cboCategoriaFlujo.NombreCampo = "CategoriaFlujo"
        Me.cboCategoriaFlujo.Obligatorio = True
        Me.cboCategoriaFlujo.Query = "select IdCategoria as Id, Descripcion as Categoria from FlujosCategorias"
        Me.cboCategoriaFlujo.SelectIndex = -1
        Me.cboCategoriaFlujo.Size = New System.Drawing.Size(503, 20)
        Me.cboCategoriaFlujo.SoloLectura = False
        Me.cboCategoriaFlujo.StringConection = ""
        Me.cboCategoriaFlujo.TabIndex = 2
        Me.cboCategoriaFlujo.TextoNuevoItem = ""
        Me.cboCategoriaFlujo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboCategoriaFlujo.Valor = ""
        '
        'txtIdFlujo
        '
        Me.txtIdFlujo.CampoBusqueda = True
        Me.txtIdFlujo.CampoEsLlave = True
        Me.txtIdFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdFlujo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdFlujo.FechaActual = False
        Me.txtIdFlujo.Formato = ""
        Me.txtIdFlujo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdFlujo.LabelText = "Cod. Flujo"
        Me.txtIdFlujo.LabelWidth = 100
        Me.txtIdFlujo.Location = New System.Drawing.Point(12, 81)
        Me.txtIdFlujo.MaxLength = 25
        Me.txtIdFlujo.Name = "txtIdFlujo"
        Me.txtIdFlujo.NombreCampo = "IdFlujo"
        Me.txtIdFlujo.Obligatorio = True
        Me.txtIdFlujo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdFlujo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdFlujo.SoloLectura = False
        Me.txtIdFlujo.TabIndex = 0
        Me.txtIdFlujo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdFlujo.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción Flujo"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 104)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(808, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaCreacion.CampoBusqueda = False
        Me.txtFechaCreacion.CampoEsLlave = False
        Me.txtFechaCreacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCreacion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaCreacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCreacion.FechaActual = False
        Me.txtFechaCreacion.Formato = "dd/MMM/yyyy"
        Me.txtFechaCreacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCreacion.LabelText = "Fecha Creación"
        Me.txtFechaCreacion.LabelWidth = 100
        Me.txtFechaCreacion.Location = New System.Drawing.Point(12, 150)
        Me.txtFechaCreacion.MaxLength = 0
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.NombreCampo = "FechaCreacion"
        Me.txtFechaCreacion.Obligatorio = False
        Me.txtFechaCreacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCreacion.Size = New System.Drawing.Size(504, 20)
        Me.txtFechaCreacion.SoloLectura = True
        Me.txtFechaCreacion.TabIndex = 4
        Me.txtFechaCreacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCreacion.Valor = Nothing
        '
        'StiComboBox2
        '
        Me.StiComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiComboBox2.CampoAutoCompletar = 0
        Me.StiComboBox2.CampoBusqueda = False
        Me.StiComboBox2.CampoDisplay = 1
        Me.StiComboBox2.CampoEsLlave = False
        Me.StiComboBox2.CampoValor = 0
        Me.StiComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiComboBox2.ControlBackColor = System.Drawing.Color.White
        Me.StiComboBox2.ControlForeColor = System.Drawing.Color.Black
        Me.StiComboBox2.FilasVisibles = 7
        Me.StiComboBox2.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.StiComboBox2.LabelText = "Tipo"
        Me.StiComboBox2.LabelWidth = 50
        Me.StiComboBox2.Lista = "ENTRADA Flujo de Entrada|SALIDA Flujo de Salida"
        Me.StiComboBox2.Location = New System.Drawing.Point(539, 127)
        Me.StiComboBox2.Name = "StiComboBox2"
        Me.StiComboBox2.NombreCampo = "TipoFlujo"
        Me.StiComboBox2.Obligatorio = True
        Me.StiComboBox2.Query = ""
        Me.StiComboBox2.SelectIndex = -1
        Me.StiComboBox2.Size = New System.Drawing.Size(281, 20)
        Me.StiComboBox2.SoloLectura = False
        Me.StiComboBox2.StringConection = ""
        Me.StiComboBox2.TabIndex = 3
        Me.StiComboBox2.TextoNuevoItem = ""
        Me.StiComboBox2.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.StiComboBox2.Valor = ""
        '
        'GridPasos
        '
        Me.GridPasos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPasos.Location = New System.Drawing.Point(12, 182)
        Me.GridPasos.MainView = Me.VistaPasos
        Me.GridPasos.Name = "GridPasos"
        Me.GridPasos.NombreTabla = "FlujosTrabajoPasos"
        Me.GridPasos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GridPasos.Size = New System.Drawing.Size(813, 223)
        Me.GridPasos.TabIndex = 5
        Me.GridPasos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPasos})
        '
        'VistaPasos
        '
        Me.VistaPasos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaPasos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaPasos.ColumnPanelRowHeight = 40
        Me.VistaPasos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.VistaPasos.GridControl = Me.GridPasos
        Me.VistaPasos.Name = "VistaPasos"
        Me.VistaPasos.OptionsView.ShowGroupPanel = False
        Me.VistaPasos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdFlujo"
        Me.GridColumn1.FieldName = "IdFlujo"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Paso"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "IdPaso"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 68
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Descripción"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn3.FieldName = "DescripcionPaso"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 232
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Siguiente Paso"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "IdSiguientePaso"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Paso Final"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn5.FieldName = "EsPasoFinal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 60
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Usuarios"
        Me.GridColumn6.FieldName = "Usuarios"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 139
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tiempo Estimado (Hr)"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "TiempoEstimado"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 103
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Uso Recepción"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn8.FieldName = "TipoControlCorrespondencia"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 68
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Requiere Asignación"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn9.FieldName = "RequiereAsignacion"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 4
        Me.GridColumn9.Width = 57
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(732, 153)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 26)
        Me.btnQutar.TabIndex = 23
        Me.btnQutar.Text = "Quitar Paso"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(536, 153)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 26)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar Paso"
        '
        'btnInsertar
        '
        Me.btnInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertar.Location = New System.Drawing.Point(634, 153)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(92, 26)
        Me.btnInsertar.TabIndex = 24
        Me.btnInsertar.Text = "Insertar Paso"
        '
        'FlujosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 107
        Me.ClientSize = New System.Drawing.Size(837, 447)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GridPasos)
        Me.Controls.Add(Me.StiComboBox2)
        Me.Controls.Add(Me.txtFechaCreacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cboCategoriaFlujo)
        Me.Controls.Add(Me.txtIdFlujo)
        Me.Name = "FlujosMan"
        Me.Text = "Flujos"
        Me.Controls.SetChildIndex(Me.txtIdFlujo, 0)
        Me.Controls.SetChildIndex(Me.cboCategoriaFlujo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCreacion, 0)
        Me.Controls.SetChildIndex(Me.StiComboBox2, 0)
        Me.Controls.SetChildIndex(Me.GridPasos, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnQutar, 0)
        Me.Controls.SetChildIndex(Me.btnInsertar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPasos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPasos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboCategoriaFlujo As STIControles.stiComboBox
    Friend WithEvents txtIdFlujo As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtFechaCreacion As STIControles.stiTextBox
    Friend WithEvents StiComboBox2 As STIControles.stiComboBox
    Friend WithEvents GridPasos As STIControles.stiGrid
    Friend WithEvents VistaPasos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnInsertar As DevExpress.XtraEditors.SimpleButton

End Class
