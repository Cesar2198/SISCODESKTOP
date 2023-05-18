<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioComision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioComision))
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtPoliza = New STIControles.stiTextBox
        Me.GridFacturas = New STIControles.stiGrid
        Me.VistaFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FACol1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACCol17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FACol11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.txtNuevaComi = New STIControles.stiTextBox
        Me.lblLog = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(544, 382)
        Me.btnAyuda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(568, 78)
        Me.btnBuscar.Size = New System.Drawing.Size(150, 36)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Búscar Facturas"
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Appearance.Options.UseTextOptions = True
        Me.btnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(5, 378)
        Me.btnNuevo.Size = New System.Drawing.Size(132, 52)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Actualizar Comisiones Pendientes"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(386, 382)
        Me.btnGuardar.Size = New System.Drawing.Size(155, 36)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Cambiar Comision"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(636, 382)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(391, 424)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(591, 74)
        Me.lblNombreFormulario.TabIndex = 7
        Me.lblNombreFormulario.Text = "Proceso de Cambio de Comisiones Producto / Póliza"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(407, 424)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 11
        Me.btnGuardarComo.Visible = False
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 60
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(8, 81)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = True
        Me.cboProducto.Query = "select IdProducto,Descripcion from productos"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(393, 20)
        Me.cboProducto.SoloLectura = False
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 0
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'txtPoliza
        '
        Me.txtPoliza.CampoBusqueda = False
        Me.txtPoliza.CampoEsLlave = False
        Me.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPoliza.FechaActual = False
        Me.txtPoliza.Formato = ""
        Me.txtPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPoliza.LabelText = "Póliza"
        Me.txtPoliza.LabelWidth = 50
        Me.txtPoliza.Location = New System.Drawing.Point(407, 81)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = False
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(155, 20)
        Me.txtPoliza.SoloLectura = False
        Me.txtPoliza.TabIndex = 1
        Me.txtPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPoliza.Valor = ""
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.Location = New System.Drawing.Point(5, 118)
        Me.GridFacturas.MainView = Me.VistaFacturas
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.NombreTabla = ""
        Me.GridFacturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridFacturas.Size = New System.Drawing.Size(713, 254)
        Me.GridFacturas.TabIndex = 8
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaFacturas})
        '
        'VistaFacturas
        '
        Me.VistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FACol1, Me.FACol12, Me.FACol2, Me.FACol3, Me.FACCol17, Me.FACol4, Me.FACol5, Me.FACol6, Me.FACol7, Me.FACol13, Me.FACol11})
        Me.VistaFacturas.GridControl = Me.GridFacturas
        Me.VistaFacturas.Name = "VistaFacturas"
        Me.VistaFacturas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaFacturas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.VistaFacturas.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.VistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'FACol1
        '
        Me.FACol1.Caption = "No.Factura"
        Me.FACol1.FieldName = "NumFactura"
        Me.FACol1.Name = "FACol1"
        Me.FACol1.OptionsColumn.AllowEdit = False
        Me.FACol1.Visible = True
        Me.FACol1.VisibleIndex = 0
        Me.FACol1.Width = 64
        '
        'FACol12
        '
        Me.FACol12.Caption = "IdProducto"
        Me.FACol12.FieldName = "IdProducto"
        Me.FACol12.Name = "FACol12"
        '
        'FACol2
        '
        Me.FACol2.Caption = "Producto"
        Me.FACol2.FieldName = "Producto"
        Me.FACol2.Name = "FACol2"
        Me.FACol2.OptionsColumn.AllowEdit = False
        Me.FACol2.Visible = True
        Me.FACol2.VisibleIndex = 1
        Me.FACol2.Width = 64
        '
        'FACol3
        '
        Me.FACol3.Caption = "Póliza"
        Me.FACol3.FieldName = "Polizas"
        Me.FACol3.Name = "FACol3"
        Me.FACol3.OptionsColumn.AllowEdit = False
        Me.FACol3.Visible = True
        Me.FACol3.VisibleIndex = 2
        Me.FACol3.Width = 64
        '
        'FACCol17
        '
        Me.FACCol17.Caption = "IdRamo"
        Me.FACCol17.FieldName = "IdRamo"
        Me.FACCol17.Name = "FACCol17"
        '
        'FACol4
        '
        Me.FACol4.Caption = "Asegurado"
        Me.FACol4.FieldName = "Asegurado"
        Me.FACol4.Name = "FACol4"
        Me.FACol4.OptionsColumn.AllowEdit = False
        Me.FACol4.Visible = True
        Me.FACol4.VisibleIndex = 3
        Me.FACol4.Width = 64
        '
        'FACol5
        '
        Me.FACol5.Caption = "Fecha Vencimiento"
        Me.FACol5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.FACol5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FACol5.FieldName = "FechaPago"
        Me.FACol5.Name = "FACol5"
        Me.FACol5.OptionsColumn.AllowEdit = False
        Me.FACol5.Visible = True
        Me.FACol5.VisibleIndex = 4
        Me.FACol5.Width = 76
        '
        'FACol6
        '
        Me.FACol6.Caption = "No.Cuota"
        Me.FACol6.FieldName = "NumCuota"
        Me.FACol6.Name = "FACol6"
        Me.FACol6.OptionsColumn.AllowEdit = False
        Me.FACol6.Visible = True
        Me.FACol6.VisibleIndex = 5
        Me.FACol6.Width = 62
        '
        'FACol7
        '
        Me.FACol7.Caption = "Prima"
        Me.FACol7.DisplayFormat.FormatString = "c"
        Me.FACol7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FACol7.FieldName = "Prima"
        Me.FACol7.Name = "FACol7"
        Me.FACol7.OptionsColumn.AllowEdit = False
        Me.FACol7.Visible = True
        Me.FACol7.VisibleIndex = 6
        Me.FACol7.Width = 62
        '
        'FACol13
        '
        Me.FACol13.Caption = "Comisión"
        Me.FACol13.FieldName = "Comision"
        Me.FACol13.Name = "FACol13"
        Me.FACol13.Visible = True
        Me.FACol13.VisibleIndex = 7
        '
        'FACol11
        '
        Me.FACol11.Caption = "Incluir"
        Me.FACol11.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.FACol11.FieldName = "Incluir"
        Me.FACol11.Name = "FACol11"
        Me.FACol11.Visible = True
        Me.FACol11.VisibleIndex = 8
        Me.FACol11.Width = 70
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'txtNuevaComi
        '
        Me.txtNuevaComi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNuevaComi.CampoBusqueda = False
        Me.txtNuevaComi.CampoEsLlave = False
        Me.txtNuevaComi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNuevaComi.ControlBackColor = System.Drawing.Color.White
        Me.txtNuevaComi.ControlForeColor = System.Drawing.Color.Black
        Me.txtNuevaComi.FechaActual = False
        Me.txtNuevaComi.Formato = "###0.0000"
        Me.txtNuevaComi.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNuevaComi.LabelText = "Nuevo %  Comision"
        Me.txtNuevaComi.LabelWidth = 120
        Me.txtNuevaComi.Location = New System.Drawing.Point(154, 398)
        Me.txtNuevaComi.MaxLength = 0
        Me.txtNuevaComi.Name = "txtNuevaComi"
        Me.txtNuevaComi.NombreCampo = ""
        Me.txtNuevaComi.Obligatorio = True
        Me.txtNuevaComi.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNuevaComi.Size = New System.Drawing.Size(226, 20)
        Me.txtNuevaComi.SoloLectura = False
        Me.txtNuevaComi.TabIndex = 3
        Me.txtNuevaComi.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNuevaComi.Valor = 0
        '
        'lblLog
        '
        Me.lblLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLog.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLog.Appearance.Options.UseFont = True
        Me.lblLog.Location = New System.Drawing.Point(154, 378)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(0, 13)
        Me.lblLog.TabIndex = 15
        '
        'CambioComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 601
        Me.ClientSize = New System.Drawing.Size(730, 430)
        Me.Controls.Add(Me.GridFacturas)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.txtNuevaComi)
        Me.Name = "CambioComision"
        Me.Text = "Cambio de Comisiones"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.txtNuevaComi, 0)
        Me.Controls.SetChildIndex(Me.lblLog, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.GridFacturas, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents GridFacturas As STIControles.stiGrid
    Friend WithEvents VistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FACol1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACCol17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FACol11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtNuevaComi As STIControles.stiTextBox
    Friend WithEvents lblLog As DevExpress.XtraEditors.LabelControl

End Class
