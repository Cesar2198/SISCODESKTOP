<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepGestionesPolizas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepGestionesPolizas))
        Me.GridGestion = New STIControles.stiGrid
        Me.VistaGestion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFechaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaProximaGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComentarios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGestionHecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGestionARealizar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEMail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeriodoGestion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAseguradora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtFechaCorte = New STIControles.stiTextBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.colFechaGrabacion = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(540, 363)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(437, 363)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(643, 363)
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(292, 74)
        Me.LabelControl1.Text = "Reporte de Gestiones por Realizar"
        '
        'GridGestion
        '
        Me.GridGestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGestion.Location = New System.Drawing.Point(5, 76)
        Me.GridGestion.MainView = Me.VistaGestion
        Me.GridGestion.Name = "GridGestion"
        Me.GridGestion.NombreTabla = ""
        Me.GridGestion.Size = New System.Drawing.Size(736, 281)
        Me.GridGestion.TabIndex = 17
        Me.GridGestion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaGestion})
        '
        'VistaGestion
        '
        Me.VistaGestion.Appearance.GroupRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.VistaGestion.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.VistaGestion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.VistaGestion.Appearance.GroupRow.Options.UseBackColor = True
        Me.VistaGestion.Appearance.GroupRow.Options.UseFont = True
        Me.VistaGestion.Appearance.GroupRow.Options.UseForeColor = True
        Me.VistaGestion.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaGestion.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaGestion.ColumnPanelRowHeight = 40
        Me.VistaGestion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFechaGestion, Me.colFechaProximaGestion, Me.colComentarios, Me.colGestionHecha, Me.colGestionARealizar, Me.colNombreCliente, Me.colTelefono, Me.colEMail, Me.colNumeroPoliza, Me.colPeriodoGestion, Me.colUsuario, Me.colProducto, Me.colAseguradora, Me.colFechaGrabacion})
        Me.VistaGestion.GridControl = Me.GridGestion
        Me.VistaGestion.GroupCount = 1
        Me.VistaGestion.Name = "VistaGestion"
        Me.VistaGestion.OptionsBehavior.AutoExpandAllGroups = True
        Me.VistaGestion.OptionsBehavior.Editable = False
        Me.VistaGestion.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPeriodoGestion, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFechaProximaGestion, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colFechaGestion
        '
        Me.colFechaGestion.Caption = "Fecha Gestión"
        Me.colFechaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaGestion.FieldName = "FechaGestion"
        Me.colFechaGestion.Name = "colFechaGestion"
        Me.colFechaGestion.Visible = True
        Me.colFechaGestion.VisibleIndex = 0
        '
        'colFechaProximaGestion
        '
        Me.colFechaProximaGestion.Caption = "Fecha Prox. Gestión"
        Me.colFechaProximaGestion.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaProximaGestion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaProximaGestion.FieldName = "FechaProximaGestion"
        Me.colFechaProximaGestion.Name = "colFechaProximaGestion"
        Me.colFechaProximaGestion.Visible = True
        Me.colFechaProximaGestion.VisibleIndex = 1
        '
        'colComentarios
        '
        Me.colComentarios.Caption = "Comentarios"
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 2
        '
        'colGestionHecha
        '
        Me.colGestionHecha.Caption = "Gestión Hecha"
        Me.colGestionHecha.FieldName = "GestionHecha"
        Me.colGestionHecha.Name = "colGestionHecha"
        Me.colGestionHecha.Visible = True
        Me.colGestionHecha.VisibleIndex = 3
        '
        'colGestionARealizar
        '
        Me.colGestionARealizar.Caption = "Gestión a Realizar"
        Me.colGestionARealizar.FieldName = "GestionARealizar"
        Me.colGestionARealizar.Name = "colGestionARealizar"
        Me.colGestionARealizar.Visible = True
        Me.colGestionARealizar.VisibleIndex = 4
        '
        'colNombreCliente
        '
        Me.colNombreCliente.Caption = "Cliente"
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.Visible = True
        Me.colNombreCliente.VisibleIndex = 5
        '
        'colTelefono
        '
        Me.colTelefono.Caption = "Teléfono"
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 6
        '
        'colEMail
        '
        Me.colEMail.Caption = "EMail"
        Me.colEMail.FieldName = "EMail"
        Me.colEMail.Name = "colEMail"
        Me.colEMail.Visible = True
        Me.colEMail.VisibleIndex = 7
        '
        'colNumeroPoliza
        '
        Me.colNumeroPoliza.Caption = "Póliza"
        Me.colNumeroPoliza.FieldName = "IdPoliza"
        Me.colNumeroPoliza.Name = "colNumeroPoliza"
        Me.colNumeroPoliza.Visible = True
        Me.colNumeroPoliza.VisibleIndex = 8
        '
        'colPeriodoGestion
        '
        Me.colPeriodoGestion.Caption = "Período de Gestión"
        Me.colPeriodoGestion.FieldName = "PeriodoGestion"
        Me.colPeriodoGestion.Name = "colPeriodoGestion"
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Usuario Gestión"
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 9
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 10
        '
        'colAseguradora
        '
        Me.colAseguradora.Caption = "Aseguradora"
        Me.colAseguradora.FieldName = "Aseguradora"
        Me.colAseguradora.Name = "colAseguradora"
        Me.colAseguradora.Visible = True
        Me.colAseguradora.VisibleIndex = 11
        '
        'txtFechaCorte
        '
        Me.txtFechaCorte.CampoBusqueda = False
        Me.txtFechaCorte.CampoEsLlave = False
        Me.txtFechaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCorte.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCorte.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCorte.FechaActual = True
        Me.txtFechaCorte.Formato = "Long Date"
        Me.txtFechaCorte.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCorte.LabelText = "Fecha de Corte"
        Me.txtFechaCorte.LabelWidth = 100
        Me.txtFechaCorte.Location = New System.Drawing.Point(437, 8)
        Me.txtFechaCorte.MaxLength = 0
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.NombreCampo = ""
        Me.txtFechaCorte.Obligatorio = True
        Me.txtFechaCorte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCorte.Size = New System.Drawing.Size(294, 20)
        Me.txtFechaCorte.SoloLectura = False
        Me.txtFechaCorte.TabIndex = 18
        Me.txtFechaCorte.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCorte.Valor = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(646, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "&Búscar"
        '
        'colFechaGrabacion
        '
        Me.colFechaGrabacion.Caption = "Fecha Grabación"
        Me.colFechaGrabacion.DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
        Me.colFechaGrabacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaGrabacion.FieldName = "FechaGrabacion"
        Me.colFechaGrabacion.Name = "colFechaGrabacion"
        '
        'RepGestionesPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 516
        Me.ClientSize = New System.Drawing.Size(746, 401)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GridGestion)
        Me.Controls.Add(Me.txtFechaCorte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepGestionesPolizas"
        Me.Text = "Reporte de Gestiones"
        Me.Controls.SetChildIndex(Me.txtFechaCorte, 0)
        Me.Controls.SetChildIndex(Me.GridGestion, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridGestion As STIControles.stiGrid
    Friend WithEvents VistaGestion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFechaCorte As STIControles.stiTextBox
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colFechaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProximaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGestionHecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGestionARealizar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodoGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAseguradora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaGrabacion As DevExpress.XtraGrid.Columns.GridColumn

End Class
