<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GruposMan
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
        Me.components = New System.ComponentModel.Container
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtIdGrupo = New STIControles.stiTextBox
        Me.StiGrid1 = New STIControles.stiGrid
        Me.MenuPermisos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarTodosLosPermisosALecturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarTodosLosPermisosAEscrituraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarTodosLosPermisosAControlTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColOpcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colPermiso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.ColOrden = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPermisos.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(464, 384)
        Me.btnAyuda.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(280, 384)
        Me.btnBuscar.TabIndex = 4
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(2, 384)
        Me.btnNuevo.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(94, 384)
        Me.btnGuardar.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(556, 384)
        Me.btnSalir.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 384)
        Me.btnEliminar.TabIndex = 5
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(617, 74)
        Me.lblNombreFormulario.TabIndex = 8
        Me.lblNombreFormulario.Text = "Registro de Grupos de Usuarios"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(187, 384)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 119)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(626, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.CampoBusqueda = True
        Me.txtIdGrupo.CampoEsLlave = True
        Me.txtIdGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdGrupo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdGrupo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdGrupo.FechaActual = False
        Me.txtIdGrupo.Formato = ""
        Me.txtIdGrupo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdGrupo.LabelText = "Cod. Grupo"
        Me.txtIdGrupo.LabelWidth = 100
        Me.txtIdGrupo.Location = New System.Drawing.Point(12, 93)
        Me.txtIdGrupo.MaxLength = 25
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.NombreCampo = "IdGrupo"
        Me.txtIdGrupo.Obligatorio = True
        Me.txtIdGrupo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdGrupo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdGrupo.SoloLectura = False
        Me.txtIdGrupo.TabIndex = 0
        Me.txtIdGrupo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdGrupo.Valor = ""
        '
        'StiGrid1
        '
        Me.StiGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid1.ContextMenuStrip = Me.MenuPermisos
        Me.StiGrid1.Location = New System.Drawing.Point(2, 174)
        Me.StiGrid1.MainView = Me.GridView1
        Me.StiGrid1.Name = "StiGrid1"
        Me.StiGrid1.NombreTabla = "GruposPermisos"
        Me.StiGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemTextEdit1})
        Me.StiGrid1.Size = New System.Drawing.Size(647, 204)
        Me.StiGrid1.TabIndex = 15
        Me.StiGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MenuPermisos
        '
        Me.MenuPermisos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem, Me.CambiarTodosLosPermisosALecturaToolStripMenuItem, Me.CambiarTodosLosPermisosAEscrituraToolStripMenuItem, Me.CambiarTodosLosPermisosAControlTotalToolStripMenuItem})
        Me.MenuPermisos.Name = "MenuPermisos"
        Me.MenuPermisos.Size = New System.Drawing.Size(351, 92)
        '
        'CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem
        '
        Me.CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem.Name = "CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem"
        Me.CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem.Text = "Cambiar Todos los Permisos a Lectura Sin Impresión"
        '
        'CambiarTodosLosPermisosALecturaToolStripMenuItem
        '
        Me.CambiarTodosLosPermisosALecturaToolStripMenuItem.Name = "CambiarTodosLosPermisosALecturaToolStripMenuItem"
        Me.CambiarTodosLosPermisosALecturaToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.CambiarTodosLosPermisosALecturaToolStripMenuItem.Text = "Cambiar Todos los Permisos a Lectura"
        '
        'CambiarTodosLosPermisosAEscrituraToolStripMenuItem
        '
        Me.CambiarTodosLosPermisosAEscrituraToolStripMenuItem.Name = "CambiarTodosLosPermisosAEscrituraToolStripMenuItem"
        Me.CambiarTodosLosPermisosAEscrituraToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.CambiarTodosLosPermisosAEscrituraToolStripMenuItem.Text = "Cambiar Todos los Permisos a Escritura"
        '
        'CambiarTodosLosPermisosAControlTotalToolStripMenuItem
        '
        Me.CambiarTodosLosPermisosAControlTotalToolStripMenuItem.Name = "CambiarTodosLosPermisosAControlTotalToolStripMenuItem"
        Me.CambiarTodosLosPermisosAControlTotalToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.CambiarTodosLosPermisosAControlTotalToolStripMenuItem.Text = "Cambiar Todos los Permisos a Control Total"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.ColOpcion, Me.colPermiso, Me.ColNombre, Me.ColOrden})
        Me.GridView1.GridControl = Me.StiGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdGrupo"
        Me.GridColumn1.FieldName = "IdGrupo"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'ColOpcion
        '
        Me.ColOpcion.Caption = "Opción Menú"
        Me.ColOpcion.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.ColOpcion.FieldName = "IdMenu"
        Me.ColOpcion.Name = "ColOpcion"
        Me.ColOpcion.Visible = True
        Me.ColOpcion.VisibleIndex = 0
        Me.ColOpcion.Width = 281
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'colPermiso
        '
        Me.colPermiso.Caption = "Permiso"
        Me.colPermiso.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colPermiso.FieldName = "IdPermiso"
        Me.colPermiso.Name = "colPermiso"
        Me.colPermiso.Visible = True
        Me.colPermiso.VisibleIndex = 1
        Me.colPermiso.Width = 169
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        '
        'ColNombre
        '
        Me.ColNombre.Caption = "Personalizar Nombre"
        Me.ColNombre.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.ColNombre.FieldName = "NombreOpcion"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Visible = True
        Me.ColNombre.VisibleIndex = 2
        Me.ColNombre.Width = 176
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 250
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'btnQutar
        '
        Me.btnQutar.Location = New System.Drawing.Point(556, 145)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 19
        Me.btnQutar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(459, 145)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        '
        'ColOrden
        '
        Me.ColOrden.Caption = "Orden Menú"
        Me.ColOrden.FieldName = "Orden"
        Me.ColOrden.Name = "ColOrden"
        Me.ColOrden.Visible = True
        Me.ColOrden.VisibleIndex = 3
        '
        'GruposMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 108
        Me.ClientSize = New System.Drawing.Size(650, 420)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.StiGrid1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdGrupo)
        Me.Name = "GruposMan"
        Me.Text = "Registro de Grupos de Usuarios"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdGrupo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.StiGrid1, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnQutar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPermisos.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtIdGrupo As STIControles.stiTextBox
    Friend WithEvents StiGrid1 As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColOpcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPermiso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuPermisos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarTodosLosPermisosALecturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarTodosLosPermisosAEscrituraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarTodosLosPermisosAControlTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ColOrden As DevExpress.XtraGrid.Columns.GridColumn

End Class
