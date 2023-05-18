<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarNumFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarNumFacturas))
        Me.btnBuscarArchivo = New DevExpress.XtraEditors.SimpleButton
        Me.txtArchivo = New STIControles.stiTextBox
        Me.gridFacturas = New STIControles.stiGrid
        Me.vistaFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Barra = New System.Windows.Forms.ProgressBar
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(478, 343)
        Me.btnAyuda.Size = New System.Drawing.Size(88, 36)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(94, 369)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(382, 343)
        Me.btnNuevo.Text = "&Modelo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(174, 343)
        Me.btnGuardar.Size = New System.Drawing.Size(206, 36)
        Me.btnGuardar.Text = "A&ctualizar Num. Facturas"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 343)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(186, 369)
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
        Me.lblNombreFormulario.Text = "Actualizar Números de Facturas"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(2, 369)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'btnBuscarArchivo
        '
        Me.btnBuscarArchivo.Appearance.Options.UseTextOptions = True
        Me.btnBuscarArchivo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarArchivo.Image = CType(resources.GetObject("btnBuscarArchivo.Image"), System.Drawing.Image)
        Me.btnBuscarArchivo.Location = New System.Drawing.Point(12, 81)
        Me.btnBuscarArchivo.Name = "btnBuscarArchivo"
        Me.btnBuscarArchivo.Size = New System.Drawing.Size(78, 44)
        Me.btnBuscarArchivo.TabIndex = 39
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
        Me.txtArchivo.Location = New System.Drawing.Point(96, 81)
        Me.txtArchivo.MaxLength = 0
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.NombreCampo = "NombreCliente"
        Me.txtArchivo.Obligatorio = True
        Me.txtArchivo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArchivo.Size = New System.Drawing.Size(507, 20)
        Me.txtArchivo.SoloLectura = False
        Me.txtArchivo.TabIndex = 38
        Me.txtArchivo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtArchivo.Valor = ""
        '
        'gridFacturas
        '
        Me.gridFacturas.ColumnasAdicionales = ""
        Me.gridFacturas.Location = New System.Drawing.Point(12, 131)
        Me.gridFacturas.MainView = Me.vistaFacturas
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.NombreTabla = ""
        Me.gridFacturas.Size = New System.Drawing.Size(638, 206)
        Me.gridFacturas.TabIndex = 40
        Me.gridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vistaFacturas})
        '
        'vistaFacturas
        '
        Me.vistaFacturas.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vistaFacturas.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vistaFacturas.ColumnPanelRowHeight = 35
        Me.vistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.vistaFacturas.GridControl = Me.gridFacturas
        Me.vistaFacturas.Name = "vistaFacturas"
        Me.vistaFacturas.OptionsBehavior.Editable = False
        Me.vistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Barra
        '
        Me.Barra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Barra.Location = New System.Drawing.Point(13, 344)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(129, 23)
        Me.Barra.TabIndex = 41
        Me.Barra.Visible = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Póliza"
        Me.GridColumn1.FieldName = "Poliza"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 46
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Código"
        Me.GridColumn2.FieldName = "Codigo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 62
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Pagador"
        Me.GridColumn3.FieldName = "Pagador"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 62
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cuota"
        Me.GridColumn4.FieldName = "Cuota"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 62
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vencimiento"
        Me.GridColumn5.FieldName = "Vencimiento"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 62
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Prima"
        Me.GridColumn6.FieldName = "Prima"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 62
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Recibo"
        Me.GridColumn7.FieldName = "Recibo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 62
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Fec. Cobro"
        Me.GridColumn8.FieldName = "Fec_Cobro"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 62
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Aplicado"
        Me.GridColumn9.FieldName = "Aplicado"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 62
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Mensaje"
        Me.GridColumn10.FieldName = "Mensaje"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'ActualizarNumFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(662, 379)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.gridFacturas)
        Me.Controls.Add(Me.btnBuscarArchivo)
        Me.Controls.Add(Me.txtArchivo)
        Me.Name = "ActualizarNumFacturas"
        Me.Text = "Actualizar Facturas"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtArchivo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarArchivo, 0)
        Me.Controls.SetChildIndex(Me.gridFacturas, 0)
        Me.Controls.SetChildIndex(Me.Barra, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarArchivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtArchivo As STIControles.stiTextBox
    Friend WithEvents gridFacturas As STIControles.stiGrid
    Friend WithEvents vistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Barra As System.Windows.Forms.ProgressBar
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

End Class
