<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormasPagoMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormasPagoMan))
        Me.txtIdFormaPago = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtNumeroCuotas = New STIControles.stiTextBox
        Me.txtFrecuenciaPago = New STIControles.stiTextBox
        Me.StiGrid1 = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtDiasFacturacion = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(474, 339)
        Me.btnAyuda.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(290, 339)
        Me.btnBuscar.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(12, 339)
        Me.btnNuevo.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(104, 339)
        Me.btnGuardar.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(566, 339)
        Me.btnSalir.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(382, 339)
        Me.btnEliminar.TabIndex = 8
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(521, 74)
        Me.lblNombreFormulario.TabIndex = 11
        Me.lblNombreFormulario.Text = "Registro de Formas de Pago"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(197, 339)
        '
        'txtIdFormaPago
        '
        Me.txtIdFormaPago.CampoBusqueda = True
        Me.txtIdFormaPago.CampoEsLlave = True
        Me.txtIdFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.txtIdFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdFormaPago.FechaActual = False
        Me.txtIdFormaPago.Formato = ""
        Me.txtIdFormaPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdFormaPago.LabelText = "Cod. Forma Pago"
        Me.txtIdFormaPago.LabelWidth = 125
        Me.txtIdFormaPago.Location = New System.Drawing.Point(12, 81)
        Me.txtIdFormaPago.MaxLength = 25
        Me.txtIdFormaPago.Name = "txtIdFormaPago"
        Me.txtIdFormaPago.NombreCampo = "IdFormaPago"
        Me.txtIdFormaPago.Obligatorio = True
        Me.txtIdFormaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdFormaPago.Size = New System.Drawing.Size(300, 20)
        Me.txtIdFormaPago.SoloLectura = False
        Me.txtIdFormaPago.TabIndex = 0
        Me.txtIdFormaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdFormaPago.Valor = ""
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
        Me.txtDescripcion.LabelWidth = 125
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 107)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(639, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtNumeroCuotas
        '
        Me.txtNumeroCuotas.CampoBusqueda = False
        Me.txtNumeroCuotas.CampoEsLlave = False
        Me.txtNumeroCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroCuotas.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroCuotas.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroCuotas.FechaActual = False
        Me.txtNumeroCuotas.Formato = "###0"
        Me.txtNumeroCuotas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroCuotas.LabelText = "Número de Cuotas"
        Me.txtNumeroCuotas.LabelWidth = 125
        Me.txtNumeroCuotas.Location = New System.Drawing.Point(12, 133)
        Me.txtNumeroCuotas.MaxLength = 0
        Me.txtNumeroCuotas.Name = "txtNumeroCuotas"
        Me.txtNumeroCuotas.NombreCampo = "NumeroCuotas"
        Me.txtNumeroCuotas.Obligatorio = True
        Me.txtNumeroCuotas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroCuotas.Size = New System.Drawing.Size(300, 20)
        Me.txtNumeroCuotas.SoloLectura = False
        Me.txtNumeroCuotas.TabIndex = 2
        Me.txtNumeroCuotas.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumeroCuotas.Valor = 0
        '
        'txtFrecuenciaPago
        '
        Me.txtFrecuenciaPago.CampoBusqueda = False
        Me.txtFrecuenciaPago.CampoEsLlave = False
        Me.txtFrecuenciaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFrecuenciaPago.ControlBackColor = System.Drawing.Color.White
        Me.txtFrecuenciaPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtFrecuenciaPago.FechaActual = False
        Me.txtFrecuenciaPago.Formato = "###0"
        Me.txtFrecuenciaPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFrecuenciaPago.LabelText = "Frecuencia de Pago"
        Me.txtFrecuenciaPago.LabelWidth = 125
        Me.txtFrecuenciaPago.Location = New System.Drawing.Point(351, 133)
        Me.txtFrecuenciaPago.MaxLength = 0
        Me.txtFrecuenciaPago.Name = "txtFrecuenciaPago"
        Me.txtFrecuenciaPago.NombreCampo = "FrecuenciaPago"
        Me.txtFrecuenciaPago.Obligatorio = True
        Me.txtFrecuenciaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFrecuenciaPago.Size = New System.Drawing.Size(300, 20)
        Me.txtFrecuenciaPago.SoloLectura = False
        Me.txtFrecuenciaPago.TabIndex = 3
        Me.txtFrecuenciaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtFrecuenciaPago.Valor = 0
        '
        'StiGrid1
        '
        Me.StiGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StiGrid1.ColumnasAdicionales = ""
        Me.StiGrid1.Location = New System.Drawing.Point(4, 187)
        Me.StiGrid1.MainView = Me.GridView1
        Me.StiGrid1.Name = "StiGrid1"
        Me.StiGrid1.NombreTabla = "FormasPagoAseguradoras"
        Me.StiGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTextEdit1})
        Me.StiGrid1.Size = New System.Drawing.Size(647, 146)
        Me.StiGrid1.TabIndex = 4
        Me.StiGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.GridControl = Me.StiGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdFormaPago"
        Me.GridColumn1.FieldName = "IdFormaPago"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Aseguradora"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn2.FieldName = "IdAseguradora"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 171
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cod.Aseguradora"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn3.FieldName = "CodCia"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 101
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 25
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "%Recargo"
        Me.GridColumn4.FieldName = "PorceRecargo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 66
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Valor Recargo"
        Me.GridColumn5.FieldName = "ValorRecargo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 81
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Recargo Mínimo"
        Me.GridColumn6.FieldName = "MinimoRecargo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 100
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Recargo Máximo"
        Me.GridColumn7.FieldName = "MaximoRecargo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 107
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(559, 158)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(92, 23)
        Me.btnQuitar.TabIndex = 21
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(462, 158)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        '
        'txtDiasFacturacion
        '
        Me.txtDiasFacturacion.CampoBusqueda = False
        Me.txtDiasFacturacion.CampoEsLlave = False
        Me.txtDiasFacturacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDiasFacturacion.ControlBackColor = System.Drawing.Color.White
        Me.txtDiasFacturacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDiasFacturacion.FechaActual = False
        Me.txtDiasFacturacion.Formato = "###0"
        Me.txtDiasFacturacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDiasFacturacion.LabelText = "Días a Facturar"
        Me.txtDiasFacturacion.LabelWidth = 125
        Me.txtDiasFacturacion.Location = New System.Drawing.Point(12, 158)
        Me.txtDiasFacturacion.MaxLength = 0
        Me.txtDiasFacturacion.Name = "txtDiasFacturacion"
        Me.txtDiasFacturacion.NombreCampo = "DiasFacturacion"
        Me.txtDiasFacturacion.Obligatorio = False
        Me.txtDiasFacturacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiasFacturacion.Size = New System.Drawing.Size(300, 20)
        Me.txtDiasFacturacion.SoloLectura = False
        Me.txtDiasFacturacion.TabIndex = 22
        Me.txtDiasFacturacion.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtDiasFacturacion.Valor = 0
        '
        'FormasPagoMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 204
        Me.ClientSize = New System.Drawing.Size(660, 375)
        Me.Controls.Add(Me.txtDiasFacturacion)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.StiGrid1)
        Me.Controls.Add(Me.txtFrecuenciaPago)
        Me.Controls.Add(Me.txtNumeroCuotas)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdFormaPago)
        Me.Name = "FormasPagoMan"
        Me.Text = "Formas de Pago"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdFormaPago, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroCuotas, 0)
        Me.Controls.SetChildIndex(Me.txtFrecuenciaPago, 0)
        Me.Controls.SetChildIndex(Me.StiGrid1, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnQuitar, 0)
        Me.Controls.SetChildIndex(Me.txtDiasFacturacion, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdFormaPago As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtNumeroCuotas As STIControles.stiTextBox
    Friend WithEvents txtFrecuenciaPago As STIControles.stiTextBox
    Friend WithEvents StiGrid1 As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDiasFacturacion As STIControles.stiTextBox

End Class
