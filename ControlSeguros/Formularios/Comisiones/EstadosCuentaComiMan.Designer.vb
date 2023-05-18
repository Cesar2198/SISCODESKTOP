<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadosCuentaComiMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadosCuentaComiMan))
        Me.cboEstatus = New STIControles.stiComboBox
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.txtFechaCorte = New STIControles.stiTextBox
        Me.txtIdEstadoCuenta = New STIControles.stiTextBox
        Me.GridComisiones = New STIControles.stiGrid
        Me.VistaComisiones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumeroFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdMovimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColComision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIncluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.ColIdRamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColFechaVence = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPrima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColPorceComi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnAplicarEstadoCuenta = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscarComi = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotal = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(630, 422)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(446, 422)
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(262, 422)
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(354, 422)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(722, 422)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(538, 422)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(677, 74)
        Me.lblNombreFormulario.Text = "Estados de Cuenta Comisiones"
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(246, 406)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'cboEstatus
        '
        Me.cboEstatus.CampoAutoCompletar = 0
        Me.cboEstatus.CampoBusqueda = True
        Me.cboEstatus.CampoDisplay = 1
        Me.cboEstatus.CampoEsLlave = False
        Me.cboEstatus.CampoValor = 0
        Me.cboEstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstatus.ControlBackColor = System.Drawing.Color.White
        Me.cboEstatus.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstatus.FilasVisibles = 7
        Me.cboEstatus.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstatus.LabelText = "Estatus"
        Me.cboEstatus.LabelWidth = 115
        Me.cboEstatus.Lista = "P Estado de Cuenta Pendiente|A Estado de Cuenta Aplicado"
        Me.cboEstatus.Location = New System.Drawing.Point(12, 131)
        Me.cboEstatus.Name = "cboEstatus"
        Me.cboEstatus.NombreCampo = "Estatus"
        Me.cboEstatus.Obligatorio = False
        Me.cboEstatus.Query = ""
        Me.cboEstatus.SelectIndex = -1
        Me.cboEstatus.Size = New System.Drawing.Size(431, 20)
        Me.cboEstatus.SoloLectura = False
        Me.cboEstatus.StringConection = ""
        Me.cboEstatus.TabIndex = 24
        Me.cboEstatus.TextoNuevoItem = ""
        Me.cboEstatus.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstatus.Valor = ""
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = False
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = False
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 7
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 115
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(318, 82)
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = "IdAseguradora"
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select IdAseguradora as Id, Nombre from Aseguradoras order by Nombre"
        Me.cboAseguradora.SelectIndex = -1
        Me.cboAseguradora.Size = New System.Drawing.Size(431, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 22
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'txtFechaCorte
        '
        Me.txtFechaCorte.CampoBusqueda = True
        Me.txtFechaCorte.CampoEsLlave = False
        Me.txtFechaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCorte.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCorte.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCorte.FechaActual = False
        Me.txtFechaCorte.Formato = "Long Date"
        Me.txtFechaCorte.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCorte.LabelText = "Fecha de Corte"
        Me.txtFechaCorte.LabelWidth = 115
        Me.txtFechaCorte.Location = New System.Drawing.Point(12, 108)
        Me.txtFechaCorte.MaxLength = 0
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.NombreCampo = "FechaCorte"
        Me.txtFechaCorte.Obligatorio = False
        Me.txtFechaCorte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCorte.Size = New System.Drawing.Size(431, 20)
        Me.txtFechaCorte.SoloLectura = False
        Me.txtFechaCorte.TabIndex = 23
        Me.txtFechaCorte.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCorte.Valor = Nothing
        '
        'txtIdEstadoCuenta
        '
        Me.txtIdEstadoCuenta.CampoBusqueda = True
        Me.txtIdEstadoCuenta.CampoEsLlave = True
        Me.txtIdEstadoCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdEstadoCuenta.ControlBackColor = System.Drawing.Color.White
        Me.txtIdEstadoCuenta.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdEstadoCuenta.FechaActual = False
        Me.txtIdEstadoCuenta.Formato = "###0"
        Me.txtIdEstadoCuenta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdEstadoCuenta.LabelText = "Cod. Estado Cuenta"
        Me.txtIdEstadoCuenta.LabelWidth = 115
        Me.txtIdEstadoCuenta.Location = New System.Drawing.Point(12, 82)
        Me.txtIdEstadoCuenta.MaxLength = 0
        Me.txtIdEstadoCuenta.Name = "txtIdEstadoCuenta"
        Me.txtIdEstadoCuenta.NombreCampo = "IdEstadoCuenta"
        Me.txtIdEstadoCuenta.Obligatorio = True
        Me.txtIdEstadoCuenta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdEstadoCuenta.Size = New System.Drawing.Size(300, 20)
        Me.txtIdEstadoCuenta.SoloLectura = False
        Me.txtIdEstadoCuenta.TabIndex = 25
        Me.txtIdEstadoCuenta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdEstadoCuenta.Valor = 0
        '
        'GridComisiones
        '
        Me.GridComisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridComisiones.Location = New System.Drawing.Point(5, 154)
        Me.GridComisiones.MainView = Me.VistaComisiones
        Me.GridComisiones.Name = "GridComisiones"
        Me.GridComisiones.NombreTabla = ""
        Me.GridComisiones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridComisiones.Size = New System.Drawing.Size(806, 228)
        Me.GridComisiones.TabIndex = 26
        Me.GridComisiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaComisiones})
        '
        'VistaComisiones
        '
        Me.VistaComisiones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumeroFactura, Me.colIdProducto, Me.colIdPoliza, Me.colIdMovimiento, Me.colCliente, Me.colFechaPago, Me.ColComision, Me.colIncluir, Me.ColIdRamo, Me.ColFechaVence, Me.ColPrima, Me.ColPorceComi, Me.colTipo})
        Me.VistaComisiones.GridControl = Me.GridComisiones
        Me.VistaComisiones.Name = "VistaComisiones"
        Me.VistaComisiones.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaComisiones.OptionsView.ShowGroupPanel = False
        Me.VistaComisiones.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFechaPago, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNumeroFactura
        '
        Me.colNumeroFactura.Caption = "Factura"
        Me.colNumeroFactura.FieldName = "NumeroFactura"
        Me.colNumeroFactura.Name = "colNumeroFactura"
        Me.colNumeroFactura.Visible = True
        Me.colNumeroFactura.VisibleIndex = 0
        Me.colNumeroFactura.Width = 68
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "Producto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = True
        Me.colIdProducto.VisibleIndex = 1
        Me.colIdProducto.Width = 69
        '
        'colIdPoliza
        '
        Me.colIdPoliza.Caption = "Póliza"
        Me.colIdPoliza.FieldName = "IdPoliza"
        Me.colIdPoliza.Name = "colIdPoliza"
        Me.colIdPoliza.Visible = True
        Me.colIdPoliza.VisibleIndex = 2
        Me.colIdPoliza.Width = 68
        '
        'colIdMovimiento
        '
        Me.colIdMovimiento.Caption = "Id"
        Me.colIdMovimiento.FieldName = "IdMovimiento"
        Me.colIdMovimiento.Name = "colIdMovimiento"
        Me.colIdMovimiento.Width = 35
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "NombreCliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 127
        '
        'colFechaPago
        '
        Me.colFechaPago.Caption = "Fecha Pago"
        Me.colFechaPago.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaPago.FieldName = "FechaPago"
        Me.colFechaPago.Name = "colFechaPago"
        Me.colFechaPago.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colFechaPago.Visible = True
        Me.colFechaPago.VisibleIndex = 5
        Me.colFechaPago.Width = 70
        '
        'ColComision
        '
        Me.ColComision.Caption = "Comisión"
        Me.ColComision.DisplayFormat.FormatString = "c"
        Me.ColComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColComision.FieldName = "Comision"
        Me.ColComision.Name = "ColComision"
        Me.ColComision.Visible = True
        Me.ColComision.VisibleIndex = 8
        Me.ColComision.Width = 87
        '
        'colIncluir
        '
        Me.colIncluir.Caption = "Incluir"
        Me.colIncluir.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colIncluir.FieldName = "Incluir"
        Me.colIncluir.Name = "colIncluir"
        Me.colIncluir.Visible = True
        Me.colIncluir.VisibleIndex = 9
        Me.colIncluir.Width = 59
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'ColIdRamo
        '
        Me.ColIdRamo.Caption = "Ramo"
        Me.ColIdRamo.FieldName = "IdRamo"
        Me.ColIdRamo.Name = "ColIdRamo"
        Me.ColIdRamo.Width = 61
        '
        'ColFechaVence
        '
        Me.ColFechaVence.Caption = "Fec. Vencimiento"
        Me.ColFechaVence.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.ColFechaVence.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ColFechaVence.FieldName = "FechaVence"
        Me.ColFechaVence.Name = "ColFechaVence"
        Me.ColFechaVence.Visible = True
        Me.ColFechaVence.VisibleIndex = 4
        Me.ColFechaVence.Width = 95
        '
        'ColPrima
        '
        Me.ColPrima.Caption = "Prima Neta"
        Me.ColPrima.DisplayFormat.FormatString = "c"
        Me.ColPrima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPrima.FieldName = "PrimaNeta"
        Me.ColPrima.Name = "ColPrima"
        Me.ColPrima.Visible = True
        Me.ColPrima.VisibleIndex = 6
        Me.ColPrima.Width = 86
        '
        'ColPorceComi
        '
        Me.ColPorceComi.Caption = "%Comi."
        Me.ColPorceComi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColPorceComi.FieldName = "PorceComi"
        Me.ColPorceComi.Name = "ColPorceComi"
        Me.ColPorceComi.Visible = True
        Me.ColPorceComi.VisibleIndex = 7
        Me.ColPorceComi.Width = 56
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        '
        'btnAplicarEstadoCuenta
        '
        Me.btnAplicarEstadoCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAplicarEstadoCuenta.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAplicarEstadoCuenta.Appearance.Options.UseFont = True
        Me.btnAplicarEstadoCuenta.Appearance.Options.UseTextOptions = True
        Me.btnAplicarEstadoCuenta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnAplicarEstadoCuenta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAplicarEstadoCuenta.Image = CType(resources.GetObject("btnAplicarEstadoCuenta.Image"), System.Drawing.Image)
        Me.btnAplicarEstadoCuenta.Location = New System.Drawing.Point(0, 425)
        Me.btnAplicarEstadoCuenta.Name = "btnAplicarEstadoCuenta"
        Me.btnAplicarEstadoCuenta.Size = New System.Drawing.Size(196, 34)
        Me.btnAplicarEstadoCuenta.TabIndex = 27
        Me.btnAplicarEstadoCuenta.Text = "A&plicar Estado de Cuenta"
        '
        'btnBuscarComi
        '
        Me.btnBuscarComi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarComi.Appearance.Options.UseFont = True
        Me.btnBuscarComi.Appearance.Options.UseTextOptions = True
        Me.btnBuscarComi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnBuscarComi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarComi.Image = CType(resources.GetObject("btnBuscarComi.Image"), System.Drawing.Image)
        Me.btnBuscarComi.Location = New System.Drawing.Point(449, 107)
        Me.btnBuscarComi.Name = "btnBuscarComi"
        Me.btnBuscarComi.Size = New System.Drawing.Size(120, 43)
        Me.btnBuscarComi.TabIndex = 28
        Me.btnBuscarComi.Text = "Buscar Comisiones"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.CampoBusqueda = False
        Me.txtTotal.CampoEsLlave = False
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTotal.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotal.FechaActual = False
        Me.txtTotal.Formato = "$#,###0.00"
        Me.txtTotal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotal.LabelText = "Total Comisión"
        Me.txtTotal.LabelWidth = 100
        Me.txtTotal.Location = New System.Drawing.Point(592, 388)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NombreCampo = ""
        Me.txtTotal.Obligatorio = False
        Me.txtTotal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.Size = New System.Drawing.Size(219, 20)
        Me.txtTotal.SoloLectura = True
        Me.txtTotal.TabIndex = 29
        Me.txtTotal.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotal.Valor = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(0, 386)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(196, 36)
        Me.btnImprimir.TabIndex = 30
        Me.btnImprimir.Text = "&Imprimir Estado de Cuenta"
        '
        'EstadosCuentaComiMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 603
        Me.ClientSize = New System.Drawing.Size(816, 458)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnBuscarComi)
        Me.Controls.Add(Me.btnAplicarEstadoCuenta)
        Me.Controls.Add(Me.GridComisiones)
        Me.Controls.Add(Me.txtIdEstadoCuenta)
        Me.Controls.Add(Me.cboEstatus)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Controls.Add(Me.txtFechaCorte)
        Me.Name = "EstadosCuentaComiMan"
        Me.SeguirAlGrabarActualizar = True
        Me.SeguirAlGrabarNuevo = True
        Me.Text = "Estados de Cuenta"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCorte, 0)
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.cboEstatus, 0)
        Me.Controls.SetChildIndex(Me.txtIdEstadoCuenta, 0)
        Me.Controls.SetChildIndex(Me.GridComisiones, 0)
        Me.Controls.SetChildIndex(Me.btnAplicarEstadoCuenta, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarComi, 0)
        Me.Controls.SetChildIndex(Me.txtTotal, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboEstatus As STIControles.stiComboBox
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Friend WithEvents txtFechaCorte As STIControles.stiTextBox
    Friend WithEvents txtIdEstadoCuenta As STIControles.stiTextBox
    Friend WithEvents GridComisiones As STIControles.stiGrid
    Friend WithEvents VistaComisiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumeroFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMovimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColComision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIncluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents btnAplicarEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnBuscarComi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotal As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColIdRamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaVence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPrima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColPorceComi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn

End Class
