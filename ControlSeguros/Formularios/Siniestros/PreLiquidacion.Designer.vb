<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreLiquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreLiquidacion))
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtAsegurado = New STIControles.stiTextBox
        Me.txtNombreContratante = New STIControles.stiTextBox
        Me.gridLiquidacion = New STIControles.stiGrid
        Me.VistaLiquidacion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.btnQuitarGastos = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregarGasto = New DevExpress.XtraEditors.SimpleButton
        Me.btnCertificado = New DevExpress.XtraEditors.SimpleButton
        Me.txtDeducible = New STIControles.stiTextBox
        Me.txtParticipacion = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtFechaSiniestro = New STIControles.stiTextBox
        Me.cboTipoReclamo = New STIControles.stiComboBox
        Me.txtDepreciacion = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(444, 472)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(341, 472)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(547, 472)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Size = New System.Drawing.Size(513, 74)
        Me.LabelControl1.Text = "Cálculo de Pre-Liquidación de Reclamos"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Appearance.Options.UseTextOptions = True
        Me.btnBuscarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(524, 79)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(114, 42)
        Me.btnBuscarCliente.TabIndex = 20
        Me.btnBuscarCliente.Text = "&Buscar Pólizas / Asegurados"
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 110
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(8, 80)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(504, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 21
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = True
        Me.txtIdCertificado.CampoEsLlave = True
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 75
        Me.txtIdCertificado.Location = New System.Drawing.Point(263, 103)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = True
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(175, 20)
        Me.txtIdCertificado.SoloLectura = True
        Me.txtIdCertificado.TabIndex = 23
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 110
        Me.txtIdPoliza.Location = New System.Drawing.Point(9, 103)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(249, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 22
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtAsegurado
        '
        Me.txtAsegurado.CampoBusqueda = True
        Me.txtAsegurado.CampoEsLlave = False
        Me.txtAsegurado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAsegurado.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtAsegurado.ControlForeColor = System.Drawing.Color.Black
        Me.txtAsegurado.FechaActual = False
        Me.txtAsegurado.Formato = ""
        Me.txtAsegurado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAsegurado.LabelText = "Asegurado"
        Me.txtAsegurado.LabelWidth = 110
        Me.txtAsegurado.Location = New System.Drawing.Point(8, 150)
        Me.txtAsegurado.MaxLength = 150
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.NombreCampo = ""
        Me.txtAsegurado.Obligatorio = True
        Me.txtAsegurado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAsegurado.Size = New System.Drawing.Size(504, 20)
        Me.txtAsegurado.SoloLectura = True
        Me.txtAsegurado.TabIndex = 25
        Me.txtAsegurado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtAsegurado.Valor = ""
        '
        'txtNombreContratante
        '
        Me.txtNombreContratante.CampoBusqueda = True
        Me.txtNombreContratante.CampoEsLlave = False
        Me.txtNombreContratante.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreContratante.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreContratante.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreContratante.FechaActual = False
        Me.txtNombreContratante.Formato = ""
        Me.txtNombreContratante.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreContratante.LabelText = "Contratante"
        Me.txtNombreContratante.LabelWidth = 110
        Me.txtNombreContratante.Location = New System.Drawing.Point(8, 127)
        Me.txtNombreContratante.MaxLength = 150
        Me.txtNombreContratante.Name = "txtNombreContratante"
        Me.txtNombreContratante.NombreCampo = ""
        Me.txtNombreContratante.Obligatorio = True
        Me.txtNombreContratante.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreContratante.Size = New System.Drawing.Size(504, 20)
        Me.txtNombreContratante.SoloLectura = True
        Me.txtNombreContratante.TabIndex = 24
        Me.txtNombreContratante.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreContratante.Valor = ""
        '
        'gridLiquidacion
        '
        Me.gridLiquidacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridLiquidacion.Location = New System.Drawing.Point(8, 268)
        Me.gridLiquidacion.MainView = Me.VistaLiquidacion
        Me.gridLiquidacion.Name = "gridLiquidacion"
        Me.gridLiquidacion.NombreTabla = ""
        Me.gridLiquidacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1})
        Me.gridLiquidacion.Size = New System.Drawing.Size(506, 198)
        Me.gridLiquidacion.TabIndex = 26
        Me.gridLiquidacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaLiquidacion})
        '
        'VistaLiquidacion
        '
        Me.VistaLiquidacion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.VistaLiquidacion.GridControl = Me.gridLiquidacion
        Me.VistaLiquidacion.Name = "VistaLiquidacion"
        Me.VistaLiquidacion.OptionsNavigation.AutoFocusNewRow = True
        Me.VistaLiquidacion.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaLiquidacion.OptionsView.ShowGroupPanel = False
        Me.VistaLiquidacion.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Orden"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Orden"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 63
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo"
        Me.GridColumn2.FieldName = "Tipo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 67
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Descripción"
        Me.GridColumn3.FieldName = "Descripcion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 216
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Valor"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn4.DisplayFormat.FormatString = "c"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Valor"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 137
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'btnQuitarGastos
        '
        Me.btnQuitarGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarGastos.Location = New System.Drawing.Point(524, 303)
        Me.btnQuitarGastos.Name = "btnQuitarGastos"
        Me.btnQuitarGastos.Size = New System.Drawing.Size(114, 29)
        Me.btnQuitarGastos.TabIndex = 28
        Me.btnQuitarGastos.Text = "Quitar Gasto"
        '
        'btnAgregarGasto
        '
        Me.btnAgregarGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGasto.Location = New System.Drawing.Point(524, 268)
        Me.btnAgregarGasto.Name = "btnAgregarGasto"
        Me.btnAgregarGasto.Size = New System.Drawing.Size(114, 29)
        Me.btnAgregarGasto.TabIndex = 27
        Me.btnAgregarGasto.Text = "Agregar Gasto"
        '
        'btnCertificado
        '
        Me.btnCertificado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCertificado.Appearance.Options.UseTextOptions = True
        Me.btnCertificado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCertificado.Image = CType(resources.GetObject("btnCertificado.Image"), System.Drawing.Image)
        Me.btnCertificado.Location = New System.Drawing.Point(526, 424)
        Me.btnCertificado.Name = "btnCertificado"
        Me.btnCertificado.Size = New System.Drawing.Size(114, 42)
        Me.btnCertificado.TabIndex = 29
        Me.btnCertificado.Text = "&Ver Certificado"
        '
        'txtDeducible
        '
        Me.txtDeducible.CampoBusqueda = True
        Me.txtDeducible.CampoEsLlave = False
        Me.txtDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDeducible.ControlBackColor = System.Drawing.Color.White
        Me.txtDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtDeducible.FechaActual = False
        Me.txtDeducible.Formato = ""
        Me.txtDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDeducible.LabelText = "Deducible"
        Me.txtDeducible.LabelWidth = 110
        Me.txtDeducible.Location = New System.Drawing.Point(8, 173)
        Me.txtDeducible.MaxLength = 150
        Me.txtDeducible.Name = "txtDeducible"
        Me.txtDeducible.NombreCampo = ""
        Me.txtDeducible.Obligatorio = False
        Me.txtDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeducible.Size = New System.Drawing.Size(249, 20)
        Me.txtDeducible.SoloLectura = False
        Me.txtDeducible.TabIndex = 30
        Me.txtDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDeducible.Valor = ""
        '
        'txtParticipacion
        '
        Me.txtParticipacion.CampoBusqueda = True
        Me.txtParticipacion.CampoEsLlave = False
        Me.txtParticipacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtParticipacion.ControlBackColor = System.Drawing.Color.White
        Me.txtParticipacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtParticipacion.FechaActual = False
        Me.txtParticipacion.Formato = ""
        Me.txtParticipacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtParticipacion.LabelText = "Participación"
        Me.txtParticipacion.LabelWidth = 110
        Me.txtParticipacion.Location = New System.Drawing.Point(8, 196)
        Me.txtParticipacion.MaxLength = 150
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.NombreCampo = ""
        Me.txtParticipacion.Obligatorio = False
        Me.txtParticipacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParticipacion.Size = New System.Drawing.Size(249, 20)
        Me.txtParticipacion.SoloLectura = False
        Me.txtParticipacion.TabIndex = 31
        Me.txtParticipacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtParticipacion.Valor = ""
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = True
        Me.txtVigenciaDesde.CampoEsLlave = True
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = False
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 110
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(8, 219)
        Me.txtVigenciaDesde.MaxLength = 25
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(249, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 32
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = True
        Me.txtVigenciaHasta.CampoEsLlave = True
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = False
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigencia Hasta"
        Me.txtVigenciaHasta.LabelWidth = 100
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(263, 219)
        Me.txtVigenciaHasta.MaxLength = 25
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(249, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 33
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtFechaSiniestro
        '
        Me.txtFechaSiniestro.CampoBusqueda = True
        Me.txtFechaSiniestro.CampoEsLlave = True
        Me.txtFechaSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaSiniestro.FechaActual = False
        Me.txtFechaSiniestro.Formato = "dd/MMM/yyyy"
        Me.txtFechaSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaSiniestro.LabelText = "Fecha Siniestro"
        Me.txtFechaSiniestro.LabelWidth = 110
        Me.txtFechaSiniestro.Location = New System.Drawing.Point(8, 242)
        Me.txtFechaSiniestro.MaxLength = 25
        Me.txtFechaSiniestro.Name = "txtFechaSiniestro"
        Me.txtFechaSiniestro.NombreCampo = "FechaSiniestro"
        Me.txtFechaSiniestro.Obligatorio = True
        Me.txtFechaSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaSiniestro.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaSiniestro.SoloLectura = False
        Me.txtFechaSiniestro.TabIndex = 34
        Me.txtFechaSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaSiniestro.Valor = Nothing
        '
        'cboTipoReclamo
        '
        Me.cboTipoReclamo.CampoAutoCompletar = 0
        Me.cboTipoReclamo.CampoBusqueda = False
        Me.cboTipoReclamo.CampoDisplay = 1
        Me.cboTipoReclamo.CampoEsLlave = False
        Me.cboTipoReclamo.CampoValor = 0
        Me.cboTipoReclamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoReclamo.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoReclamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoReclamo.FilasVisibles = 7
        Me.cboTipoReclamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoReclamo.LabelText = "Tipo Siniestro"
        Me.cboTipoReclamo.LabelWidth = 100
        Me.cboTipoReclamo.Lista = "P Pérdida Total|R Robo Total"
        Me.cboTipoReclamo.Location = New System.Drawing.Point(263, 242)
        Me.cboTipoReclamo.Name = "cboTipoReclamo"
        Me.cboTipoReclamo.NombreCampo = ""
        Me.cboTipoReclamo.Obligatorio = False
        Me.cboTipoReclamo.Query = ""
        Me.cboTipoReclamo.SelectIndex = -1
        Me.cboTipoReclamo.Size = New System.Drawing.Size(251, 20)
        Me.cboTipoReclamo.SoloLectura = False
        Me.cboTipoReclamo.StringConection = ""
        Me.cboTipoReclamo.TabIndex = 35
        Me.cboTipoReclamo.TextoNuevoItem = ""
        Me.cboTipoReclamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoReclamo.Valor = ""
        '
        'txtDepreciacion
        '
        Me.txtDepreciacion.CampoBusqueda = True
        Me.txtDepreciacion.CampoEsLlave = False
        Me.txtDepreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDepreciacion.ControlBackColor = System.Drawing.Color.White
        Me.txtDepreciacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDepreciacion.FechaActual = False
        Me.txtDepreciacion.Formato = ""
        Me.txtDepreciacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDepreciacion.LabelText = "%Depreciación"
        Me.txtDepreciacion.LabelWidth = 100
        Me.txtDepreciacion.Location = New System.Drawing.Point(263, 174)
        Me.txtDepreciacion.MaxLength = 150
        Me.txtDepreciacion.Name = "txtDepreciacion"
        Me.txtDepreciacion.NombreCampo = ""
        Me.txtDepreciacion.Obligatorio = False
        Me.txtDepreciacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepreciacion.Size = New System.Drawing.Size(249, 20)
        Me.txtDepreciacion.SoloLectura = False
        Me.txtDepreciacion.TabIndex = 36
        Me.txtDepreciacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDepreciacion.Valor = ""
        '
        'PreLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 802
        Me.ClientSize = New System.Drawing.Size(650, 510)
        Me.Controls.Add(Me.txtDepreciacion)
        Me.Controls.Add(Me.cboTipoReclamo)
        Me.Controls.Add(Me.txtFechaSiniestro)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.txtParticipacion)
        Me.Controls.Add(Me.txtDeducible)
        Me.Controls.Add(Me.btnCertificado)
        Me.Controls.Add(Me.btnQuitarGastos)
        Me.Controls.Add(Me.btnAgregarGasto)
        Me.Controls.Add(Me.gridLiquidacion)
        Me.Controls.Add(Me.txtAsegurado)
        Me.Controls.Add(Me.txtNombreContratante)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "PreLiquidacion"
        Me.Text = "Pre-Liquidación"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreContratante, 0)
        Me.Controls.SetChildIndex(Me.txtAsegurado, 0)
        Me.Controls.SetChildIndex(Me.gridLiquidacion, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarGasto, 0)
        Me.Controls.SetChildIndex(Me.btnQuitarGastos, 0)
        Me.Controls.SetChildIndex(Me.btnCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtParticipacion, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.txtFechaSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboTipoReclamo, 0)
        Me.Controls.SetChildIndex(Me.txtDepreciacion, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtAsegurado As STIControles.stiTextBox
    Friend WithEvents txtNombreContratante As STIControles.stiTextBox
    Friend WithEvents gridLiquidacion As STIControles.stiGrid
    Friend WithEvents VistaLiquidacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnQuitarGastos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarGasto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCertificado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDeducible As STIControles.stiTextBox
    Friend WithEvents txtParticipacion As STIControles.stiTextBox
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtFechaSiniestro As STIControles.stiTextBox
    Friend WithEvents cboTipoReclamo As STIControles.stiComboBox
    Friend WithEvents txtDepreciacion As STIControles.stiTextBox

End Class
