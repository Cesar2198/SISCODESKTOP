<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiniestroActClase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiniestroActClase))
        Me.gridReclamos = New STIControles.stiGrid
        Me.vistaReclamos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboClaseSiniestro = New STIControles.stiComboBox
        Me.optTodos = New System.Windows.Forms.RadioButton
        Me.optAnioAnt = New System.Windows.Forms.RadioButton
        Me.optAnioAct = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vistaReclamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(645, 367)
        Me.btnAyuda.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(384, 393)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(188, 393)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(518, 367)
        Me.btnGuardar.Size = New System.Drawing.Size(125, 36)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Actua&lizar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(741, 367)
        Me.btnSalir.TabIndex = 4
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(400, 393)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(580, 74)
        Me.lblNombreFormulario.TabIndex = 8
        Me.lblNombreFormulario.Text = "Actualizar Clase de Siniestro"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(373, 393)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 10
        Me.btnGuardarComo.Visible = False
        '
        'gridReclamos
        '
        Me.gridReclamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridReclamos.ColumnasAdicionales = ""
        Me.gridReclamos.Location = New System.Drawing.Point(7, 81)
        Me.gridReclamos.MainView = Me.vistaReclamos
        Me.gridReclamos.Name = "gridReclamos"
        Me.gridReclamos.NombreTabla = ""
        Me.gridReclamos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gridReclamos.Size = New System.Drawing.Size(822, 280)
        Me.gridReclamos.TabIndex = 0
        Me.gridReclamos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vistaReclamos})
        '
        'vistaReclamos
        '
        Me.vistaReclamos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vistaReclamos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vistaReclamos.ColumnPanelRowHeight = 35
        Me.vistaReclamos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18})
        Me.vistaReclamos.GridControl = Me.gridReclamos
        Me.vistaReclamos.Name = "vistaReclamos"
        Me.vistaReclamos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.vistaReclamos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.vistaReclamos.OptionsView.ShowAutoFilterRow = True
        Me.vistaReclamos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ramo"
        Me.GridColumn1.FieldName = "Ramo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Aseguradora"
        Me.GridColumn2.FieldName = "Aseguradora"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Contratante"
        Me.GridColumn3.FieldName = "Contratante"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Asegurado"
        Me.GridColumn4.FieldName = "Asegurado"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Certificado"
        Me.GridColumn5.FieldName = "Certificado"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Titular Certificado"
        Me.GridColumn6.FieldName = "TitularCertificado"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Póliza"
        Me.GridColumn7.FieldName = "IdPoliza"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 4
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "No. Siniestro"
        Me.GridColumn8.FieldName = "IdSiniestro"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "No. Siniestro Aseguradora"
        Me.GridColumn9.FieldName = "IdSiniestroAseguradora"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Fecha Presentado"
        Me.GridColumn10.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn10.FieldName = "FechaPresenta"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Fecha Ocurrido"
        Me.GridColumn11.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn11.FieldName = "FechaOcurre"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 8
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Estado Siniestro"
        Me.GridColumn12.FieldName = "Estado"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 9
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Estado Interno"
        Me.GridColumn13.FieldName = "EstadoInterno"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 10
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "No. Oficio / Carta Referencia"
        Me.GridColumn14.FieldName = "Referencia"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Descripción Siniestro"
        Me.GridColumn15.FieldName = "Descripcion"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Clase Siniestro"
        Me.GridColumn16.FieldName = "IdClaseSiniestro"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 11
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Marcar"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn17.FieldName = "Incluir"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 12
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Producto"
        Me.GridColumn18.FieldName = "IdProducto"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowFocus = False
        '
        'cboClaseSiniestro
        '
        Me.cboClaseSiniestro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClaseSiniestro.CampoAutoCompletar = 0
        Me.cboClaseSiniestro.CampoBusqueda = True
        Me.cboClaseSiniestro.CampoDisplay = 1
        Me.cboClaseSiniestro.CampoEsLlave = False
        Me.cboClaseSiniestro.CampoValor = 0
        Me.cboClaseSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboClaseSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboClaseSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboClaseSiniestro.FilasVisibles = 0
        Me.cboClaseSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboClaseSiniestro.LabelText = "Clase Siniestro"
        Me.cboClaseSiniestro.LabelWidth = 100
        Me.cboClaseSiniestro.Lista = ""
        Me.cboClaseSiniestro.Location = New System.Drawing.Point(7, 367)
        Me.cboClaseSiniestro.MostrarBusquedaColumnas = False
        Me.cboClaseSiniestro.Name = "cboClaseSiniestro"
        Me.cboClaseSiniestro.NombreCampo = "ClaseSiniestro"
        Me.cboClaseSiniestro.Obligatorio = False
        Me.cboClaseSiniestro.Query = ""
        Me.cboClaseSiniestro.SelectIndex = 0
        Me.cboClaseSiniestro.Size = New System.Drawing.Size(480, 20)
        Me.cboClaseSiniestro.SoloLectura = False
        Me.cboClaseSiniestro.StringConection = ""
        Me.cboClaseSiniestro.TabIndex = 1
        Me.cboClaseSiniestro.TextoNuevoItem = ""
        Me.cboClaseSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboClaseSiniestro.Valor = ""
        '
        'optTodos
        '
        Me.optTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optTodos.AutoSize = True
        Me.optTodos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optTodos.Location = New System.Drawing.Point(737, 58)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.Size = New System.Drawing.Size(59, 17)
        Me.optTodos.TabIndex = 7
        Me.optTodos.Text = "Todos"
        Me.optTodos.UseVisualStyleBackColor = True
        '
        'optAnioAnt
        '
        Me.optAnioAnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAnioAnt.AutoSize = True
        Me.optAnioAnt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optAnioAnt.Location = New System.Drawing.Point(737, 35)
        Me.optAnioAnt.Name = "optAnioAnt"
        Me.optAnioAnt.Size = New System.Drawing.Size(97, 17)
        Me.optAnioAnt.TabIndex = 6
        Me.optAnioAnt.Text = "Año Anterior"
        Me.optAnioAnt.UseVisualStyleBackColor = True
        '
        'optAnioAct
        '
        Me.optAnioAct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optAnioAct.AutoSize = True
        Me.optAnioAct.Checked = True
        Me.optAnioAct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.optAnioAct.Location = New System.Drawing.Point(737, 12)
        Me.optAnioAct.Name = "optAnioAct"
        Me.optAnioAct.Size = New System.Drawing.Size(86, 17)
        Me.optAnioAct.TabIndex = 5
        Me.optAnioAct.TabStop = True
        Me.optAnioAct.Text = "Año Actual"
        Me.optAnioAct.UseVisualStyleBackColor = True
        '
        'SiniestroActClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(835, 403)
        Me.Controls.Add(Me.optTodos)
        Me.Controls.Add(Me.optAnioAnt)
        Me.Controls.Add(Me.optAnioAct)
        Me.Controls.Add(Me.cboClaseSiniestro)
        Me.Controls.Add(Me.gridReclamos)
        Me.Name = "SiniestroActClase"
        Me.Text = "Actualizar Clase"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.gridReclamos, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.cboClaseSiniestro, 0)
        Me.Controls.SetChildIndex(Me.optAnioAct, 0)
        Me.Controls.SetChildIndex(Me.optAnioAnt, 0)
        Me.Controls.SetChildIndex(Me.optTodos, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vistaReclamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridReclamos As STIControles.stiGrid
    Friend WithEvents vistaReclamos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cboClaseSiniestro As STIControles.stiComboBox
    Friend WithEvents optTodos As System.Windows.Forms.RadioButton
    Friend WithEvents optAnioAnt As System.Windows.Forms.RadioButton
    Friend WithEvents optAnioAct As System.Windows.Forms.RadioButton
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn

End Class
