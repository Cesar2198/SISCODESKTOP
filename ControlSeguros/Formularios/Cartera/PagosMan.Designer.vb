<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosMan))
        Me.txtNumeroFactura = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtIdAnexo = New STIControles.stiTextBox
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.cboTipoFactura = New STIControles.stiComboBox
        Me.txtFechaEmision = New STIControles.stiTextBox
        Me.txtFechaPago = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtNumCuota = New STIControles.stiTextBox
        Me.txtTotalCuotas = New STIControles.stiTextBox
        Me.GridMovimientos = New STIControles.stiGrid
        Me.MenuFact = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirCartaDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VistaMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdRamo = New STIControles.stiTextBox
        Me.txtPorceComision = New STIControles.stiTextBox
        Me.txtReferencia = New STIControles.stiTextBox
        Me.txtObservaciones = New STIControles.stiTextBox
        Me.txtDocumentoFiscal = New STIControles.stiTextBox
        Me.cboAplicarRetencionIva = New STIControles.stiComboBox
        Me.txtGestionEspecial = New STIControles.stiTextBox
        Me.txtVencimientoTardio = New STIControles.stiTextBox
        Me.txtIdAC = New STIControles.stiTextBox
        Me.lblIdAC = New System.Windows.Forms.LinkLabel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuFact.SuspendLayout()
        CType(Me.VistaMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(445, 501)
        Me.btnAyuda.TabIndex = 28
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(261, 501)
        Me.btnBuscar.TabIndex = 26
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(77, 501)
        Me.btnNuevo.TabIndex = 25
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(169, 501)
        Me.btnGuardar.TabIndex = 24
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(537, 501)
        Me.btnSalir.TabIndex = 29
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(353, 501)
        Me.btnEliminar.TabIndex = 27
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(492, 74)
        Me.lblNombreFormulario.TabIndex = 31
        Me.lblNombreFormulario.Text = "Registro Manual Pagos Primas de Seguros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(8, 529)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 30
        Me.btnGuardarComo.Visible = False
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.CampoBusqueda = True
        Me.txtNumeroFactura.CampoEsLlave = True
        Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroFactura.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroFactura.FechaActual = False
        Me.txtNumeroFactura.Formato = "###0"
        Me.txtNumeroFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroFactura.LabelText = "Número Factura"
        Me.txtNumeroFactura.LabelWidth = 100
        Me.txtNumeroFactura.Location = New System.Drawing.Point(12, 77)
        Me.txtNumeroFactura.MaxLength = 0
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.NombreCampo = "NumeroFactura"
        Me.txtNumeroFactura.Obligatorio = True
        Me.txtNumeroFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroFactura.Size = New System.Drawing.Size(234, 20)
        Me.txtNumeroFactura.SoloLectura = False
        Me.txtNumeroFactura.TabIndex = 0
        Me.txtNumeroFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumeroFactura.Valor = 0
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 100
        Me.txtIdPoliza.Location = New System.Drawing.Point(252, 77)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(366, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 1
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtIdAnexo
        '
        Me.txtIdAnexo.CampoBusqueda = False
        Me.txtIdAnexo.CampoEsLlave = False
        Me.txtIdAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAnexo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAnexo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAnexo.FechaActual = False
        Me.txtIdAnexo.Formato = ""
        Me.txtIdAnexo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAnexo.LabelText = "Tipo Anexo"
        Me.txtIdAnexo.LabelWidth = 100
        Me.txtIdAnexo.Location = New System.Drawing.Point(318, 142)
        Me.txtIdAnexo.MaxLength = 25
        Me.txtIdAnexo.Name = "txtIdAnexo"
        Me.txtIdAnexo.NombreCampo = "IdAnexo"
        Me.txtIdAnexo.Obligatorio = False
        Me.txtIdAnexo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAnexo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdAnexo.SoloLectura = False
        Me.txtIdAnexo.TabIndex = 6
        Me.txtIdAnexo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAnexo.Valor = ""
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(12, 164)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCliente.SoloLectura = False
        Me.txtIdCliente.TabIndex = 7
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 186)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(606, 20)
        Me.txtNombreCliente.SoloLectura = False
        Me.txtNombreCliente.TabIndex = 9
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 98)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto [Producto], Descripcion [Descripción] from Productos"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(606, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 2
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.CampoAutoCompletar = 0
        Me.cboTipoFactura.CampoBusqueda = False
        Me.cboTipoFactura.CampoDisplay = 1
        Me.cboTipoFactura.CampoEsLlave = False
        Me.cboTipoFactura.CampoValor = 0
        Me.cboTipoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoFactura.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoFactura.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoFactura.FilasVisibles = 7
        Me.cboTipoFactura.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoFactura.LabelText = "Tipo Documento"
        Me.cboTipoFactura.LabelWidth = 100
        Me.cboTipoFactura.Lista = "F Factura|C Crédito Fiscal"
        Me.cboTipoFactura.Location = New System.Drawing.Point(12, 142)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.NombreCampo = "TipoFactura"
        Me.cboTipoFactura.Obligatorio = False
        Me.cboTipoFactura.Query = ""
        Me.cboTipoFactura.SelectIndex = -1
        Me.cboTipoFactura.Size = New System.Drawing.Size(300, 20)
        Me.cboTipoFactura.SoloLectura = False
        Me.cboTipoFactura.StringConection = ""
        Me.cboTipoFactura.TabIndex = 5
        Me.cboTipoFactura.TextoNuevoItem = ""
        Me.cboTipoFactura.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoFactura.Valor = ""
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.CampoBusqueda = False
        Me.txtFechaEmision.CampoEsLlave = False
        Me.txtFechaEmision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEmision.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEmision.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEmision.FechaActual = True
        Me.txtFechaEmision.Formato = "dd/MMM/yyyy"
        Me.txtFechaEmision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEmision.LabelText = "Fecha Emisión"
        Me.txtFechaEmision.LabelWidth = 100
        Me.txtFechaEmision.Location = New System.Drawing.Point(12, 208)
        Me.txtFechaEmision.MaxLength = 0
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.NombreCampo = "FechaEmision"
        Me.txtFechaEmision.Obligatorio = True
        Me.txtFechaEmision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEmision.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaEmision.SoloLectura = False
        Me.txtFechaEmision.TabIndex = 10
        Me.txtFechaEmision.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEmision.Valor = Nothing
        '
        'txtFechaPago
        '
        Me.txtFechaPago.CampoBusqueda = False
        Me.txtFechaPago.CampoEsLlave = False
        Me.txtFechaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPago.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPago.FechaActual = True
        Me.txtFechaPago.Formato = "dd/MMM/yyyy"
        Me.txtFechaPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPago.LabelText = "Fecha Pago"
        Me.txtFechaPago.LabelWidth = 100
        Me.txtFechaPago.Location = New System.Drawing.Point(318, 208)
        Me.txtFechaPago.MaxLength = 0
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.NombreCampo = "FechaPago"
        Me.txtFechaPago.Obligatorio = True
        Me.txtFechaPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPago.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaPago.SoloLectura = False
        Me.txtFechaPago.TabIndex = 11
        Me.txtFechaPago.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPago.Valor = Nothing
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = False
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = True
        Me.txtVigenciaHasta.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigenica Hasta"
        Me.txtVigenciaHasta.LabelWidth = 100
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(318, 230)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = "VigenciaHasta"
        Me.txtVigenciaHasta.Obligatorio = False
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(300, 20)
        Me.txtVigenciaHasta.SoloLectura = False
        Me.txtVigenciaHasta.TabIndex = 13
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = False
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = True
        Me.txtVigenciaDesde.Formato = "dd/MMM/yyyy"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 100
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(12, 230)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = "VigenciaDesde"
        Me.txtVigenciaDesde.Obligatorio = False
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(300, 20)
        Me.txtVigenciaDesde.SoloLectura = False
        Me.txtVigenciaDesde.TabIndex = 12
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtNumCuota
        '
        Me.txtNumCuota.CampoBusqueda = False
        Me.txtNumCuota.CampoEsLlave = False
        Me.txtNumCuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumCuota.ControlBackColor = System.Drawing.Color.White
        Me.txtNumCuota.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumCuota.FechaActual = False
        Me.txtNumCuota.Formato = "###"
        Me.txtNumCuota.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumCuota.LabelText = "Número Cuota"
        Me.txtNumCuota.LabelWidth = 100
        Me.txtNumCuota.Location = New System.Drawing.Point(12, 120)
        Me.txtNumCuota.MaxLength = 0
        Me.txtNumCuota.Name = "txtNumCuota"
        Me.txtNumCuota.NombreCampo = "NumCuota"
        Me.txtNumCuota.Obligatorio = False
        Me.txtNumCuota.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCuota.Size = New System.Drawing.Size(300, 20)
        Me.txtNumCuota.SoloLectura = False
        Me.txtNumCuota.TabIndex = 3
        Me.txtNumCuota.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtNumCuota.Valor = 0
        '
        'txtTotalCuotas
        '
        Me.txtTotalCuotas.CampoBusqueda = False
        Me.txtTotalCuotas.CampoEsLlave = False
        Me.txtTotalCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalCuotas.ControlBackColor = System.Drawing.Color.White
        Me.txtTotalCuotas.ControlForeColor = System.Drawing.Color.Black
        Me.txtTotalCuotas.FechaActual = False
        Me.txtTotalCuotas.Formato = "###"
        Me.txtTotalCuotas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtTotalCuotas.LabelText = "Num. Total Cuotas"
        Me.txtTotalCuotas.LabelWidth = 100
        Me.txtTotalCuotas.Location = New System.Drawing.Point(318, 120)
        Me.txtTotalCuotas.MaxLength = 0
        Me.txtTotalCuotas.Name = "txtTotalCuotas"
        Me.txtTotalCuotas.NombreCampo = "TotalCuotas"
        Me.txtTotalCuotas.Obligatorio = False
        Me.txtTotalCuotas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalCuotas.Size = New System.Drawing.Size(300, 20)
        Me.txtTotalCuotas.SoloLectura = False
        Me.txtTotalCuotas.TabIndex = 4
        Me.txtTotalCuotas.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtTotalCuotas.Valor = 0
        '
        'GridMovimientos
        '
        Me.GridMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMovimientos.ContextMenuStrip = Me.MenuFact
        Me.GridMovimientos.Location = New System.Drawing.Point(11, 371)
        Me.GridMovimientos.MainView = Me.VistaMovimientos
        Me.GridMovimientos.Name = "GridMovimientos"
        Me.GridMovimientos.NombreTabla = "FacturasMovimientos"
        Me.GridMovimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit1})
        Me.GridMovimientos.Size = New System.Drawing.Size(608, 124)
        Me.GridMovimientos.TabIndex = 23
        Me.GridMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaMovimientos})
        '
        'MenuFact
        '
        Me.MenuFact.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirCartaDocumentoToolStripMenuItem})
        Me.MenuFact.Name = "MenuFact"
        Me.MenuFact.Size = New System.Drawing.Size(218, 26)
        '
        'ImprimirCartaDocumentoToolStripMenuItem
        '
        Me.ImprimirCartaDocumentoToolStripMenuItem.Name = "ImprimirCartaDocumentoToolStripMenuItem"
        Me.ImprimirCartaDocumentoToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ImprimirCartaDocumentoToolStripMenuItem.Text = "Imprimir Carta Documento"
        '
        'VistaMovimientos
        '
        Me.VistaMovimientos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VistaMovimientos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VistaMovimientos.ColumnPanelRowHeight = 40
        Me.VistaMovimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20})
        Me.VistaMovimientos.GridControl = Me.GridMovimientos
        Me.VistaMovimientos.Name = "VistaMovimientos"
        Me.VistaMovimientos.OptionsBehavior.Editable = False
        Me.VistaMovimientos.OptionsNavigation.AutoFocusNewRow = True
        Me.VistaMovimientos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaMovimientos.OptionsView.ShowFooter = True
        Me.VistaMovimientos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Número Factura"
        Me.GridColumn1.FieldName = "NumeroFactura"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Producto"
        Me.GridColumn2.FieldName = "IdProducto"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Póliza"
        Me.GridColumn3.FieldName = "IdPoliza"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Orden"
        Me.GridColumn4.FieldName = "IdMovimiento"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha Movimiento"
        Me.GridColumn5.FieldName = "FechaMovimiento"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tipo"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemComboBox1
        Me.GridColumn6.FieldName = "TipoMovimiento"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.DisplayFormat = "Saldo"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Prima Neta"
        Me.GridColumn7.DisplayFormat.FormatString = "c"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "PrimaNeta"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Gasto Emi."
        Me.GridColumn14.DisplayFormat.FormatString = "c"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "GastosEmision"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn14.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Gasto Frac."
        Me.GridColumn15.DisplayFormat.FormatString = "c"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "GastosFracciona"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn15.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 5
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Gasto Bomb."
        Me.GridColumn16.DisplayFormat.FormatString = "c"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "GastosBomberos"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn16.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Gastos Otros"
        Me.GridColumn8.DisplayFormat.FormatString = "c"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Gastos"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "IVA"
        Me.GridColumn9.DisplayFormat.FormatString = "c"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Impuestos"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Total"
        Me.GridColumn10.DisplayFormat.FormatString = "c"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Total"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Comisión"
        Me.GridColumn11.DisplayFormat.FormatString = "c"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Comision"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Fec. Cobro Comisión"
        Me.GridColumn12.FieldName = "FechaCobroComision"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 12
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Fec. Pago Comisión"
        Me.GridColumn13.FieldName = "FechaPagoComision"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "IdRamo"
        Me.GridColumn17.FieldName = "IdRamo"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Ret Iva"
        Me.GridColumn18.DisplayFormat.FormatString = "c"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "RetencionImpuestos"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.SummaryItem.DisplayFormat = "{0:c}"
        Me.GridColumn18.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 9
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Usuario"
        Me.GridColumn19.FieldName = "UsuarioGrabacion"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Forma Pago"
        Me.GridColumn20.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn20.FieldName = "IdFormaPago"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(506, 342)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(118, 23)
        Me.btnQuitar.TabIndex = 22
        Me.btnQuitar.Text = "Eliminar Movimiento"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(382, 342)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "Agregar Movimiento"
        '
        'txtIdRamo
        '
        Me.txtIdRamo.CampoBusqueda = True
        Me.txtIdRamo.CampoEsLlave = True
        Me.txtIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdRamo.FechaActual = False
        Me.txtIdRamo.Formato = ""
        Me.txtIdRamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdRamo.LabelText = "Ramo"
        Me.txtIdRamo.LabelWidth = 100
        Me.txtIdRamo.Location = New System.Drawing.Point(318, 164)
        Me.txtIdRamo.MaxLength = 25
        Me.txtIdRamo.Name = "txtIdRamo"
        Me.txtIdRamo.NombreCampo = "IdRamo"
        Me.txtIdRamo.Obligatorio = True
        Me.txtIdRamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdRamo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdRamo.SoloLectura = False
        Me.txtIdRamo.TabIndex = 8
        Me.txtIdRamo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdRamo.Valor = ""
        '
        'txtPorceComision
        '
        Me.txtPorceComision.CampoBusqueda = False
        Me.txtPorceComision.CampoEsLlave = False
        Me.txtPorceComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPorceComision.ControlBackColor = System.Drawing.Color.White
        Me.txtPorceComision.ControlForeColor = System.Drawing.Color.Black
        Me.txtPorceComision.FechaActual = False
        Me.txtPorceComision.Formato = "###0.0000"
        Me.txtPorceComision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPorceComision.LabelText = "Porce. Comisión"
        Me.txtPorceComision.LabelWidth = 100
        Me.txtPorceComision.Location = New System.Drawing.Point(12, 318)
        Me.txtPorceComision.MaxLength = 0
        Me.txtPorceComision.Name = "txtPorceComision"
        Me.txtPorceComision.NombreCampo = "PorceComision"
        Me.txtPorceComision.Obligatorio = False
        Me.txtPorceComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorceComision.Size = New System.Drawing.Size(300, 20)
        Me.txtPorceComision.SoloLectura = False
        Me.txtPorceComision.TabIndex = 20
        Me.txtPorceComision.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPorceComision.Valor = 0
        '
        'txtReferencia
        '
        Me.txtReferencia.CampoBusqueda = False
        Me.txtReferencia.CampoEsLlave = False
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtReferencia.ControlBackColor = System.Drawing.Color.White
        Me.txtReferencia.ControlForeColor = System.Drawing.Color.Black
        Me.txtReferencia.FechaActual = False
        Me.txtReferencia.Formato = ""
        Me.txtReferencia.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtReferencia.LabelText = "Referencia"
        Me.txtReferencia.LabelWidth = 100
        Me.txtReferencia.Location = New System.Drawing.Point(11, 252)
        Me.txtReferencia.MaxLength = 250
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.NombreCampo = "Referencia"
        Me.txtReferencia.Obligatorio = False
        Me.txtReferencia.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReferencia.Size = New System.Drawing.Size(300, 20)
        Me.txtReferencia.SoloLectura = False
        Me.txtReferencia.TabIndex = 14
        Me.txtReferencia.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtReferencia.Valor = ""
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CampoBusqueda = False
        Me.txtObservaciones.CampoEsLlave = False
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtObservaciones.ControlBackColor = System.Drawing.Color.White
        Me.txtObservaciones.ControlForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.FechaActual = False
        Me.txtObservaciones.Formato = ""
        Me.txtObservaciones.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtObservaciones.LabelText = "Observaciones"
        Me.txtObservaciones.LabelWidth = 100
        Me.txtObservaciones.Location = New System.Drawing.Point(318, 252)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.NombreCampo = "Observaciones"
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.Size = New System.Drawing.Size(300, 20)
        Me.txtObservaciones.SoloLectura = False
        Me.txtObservaciones.TabIndex = 15
        Me.txtObservaciones.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtObservaciones.Valor = ""
        '
        'txtDocumentoFiscal
        '
        Me.txtDocumentoFiscal.CampoBusqueda = True
        Me.txtDocumentoFiscal.CampoEsLlave = False
        Me.txtDocumentoFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDocumentoFiscal.ControlBackColor = System.Drawing.Color.White
        Me.txtDocumentoFiscal.ControlForeColor = System.Drawing.Color.Black
        Me.txtDocumentoFiscal.FechaActual = False
        Me.txtDocumentoFiscal.Formato = ""
        Me.txtDocumentoFiscal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDocumentoFiscal.LabelText = "Documento Fiscal"
        Me.txtDocumentoFiscal.LabelWidth = 100
        Me.txtDocumentoFiscal.Location = New System.Drawing.Point(12, 274)
        Me.txtDocumentoFiscal.MaxLength = 25
        Me.txtDocumentoFiscal.Name = "txtDocumentoFiscal"
        Me.txtDocumentoFiscal.NombreCampo = "DocumentoFiscal"
        Me.txtDocumentoFiscal.Obligatorio = False
        Me.txtDocumentoFiscal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocumentoFiscal.Size = New System.Drawing.Size(300, 20)
        Me.txtDocumentoFiscal.SoloLectura = False
        Me.txtDocumentoFiscal.TabIndex = 16
        Me.txtDocumentoFiscal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDocumentoFiscal.Valor = ""
        '
        'cboAplicarRetencionIva
        '
        Me.cboAplicarRetencionIva.CampoAutoCompletar = 0
        Me.cboAplicarRetencionIva.CampoBusqueda = False
        Me.cboAplicarRetencionIva.CampoDisplay = 1
        Me.cboAplicarRetencionIva.CampoEsLlave = False
        Me.cboAplicarRetencionIva.CampoValor = 0
        Me.cboAplicarRetencionIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAplicarRetencionIva.ControlBackColor = System.Drawing.Color.White
        Me.cboAplicarRetencionIva.ControlForeColor = System.Drawing.Color.Black
        Me.cboAplicarRetencionIva.FilasVisibles = 7
        Me.cboAplicarRetencionIva.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAplicarRetencionIva.LabelText = "Aplicar Ret. Iva"
        Me.cboAplicarRetencionIva.LabelWidth = 100
        Me.cboAplicarRetencionIva.Lista = "S Si|N No"
        Me.cboAplicarRetencionIva.Location = New System.Drawing.Point(318, 274)
        Me.cboAplicarRetencionIva.Name = "cboAplicarRetencionIva"
        Me.cboAplicarRetencionIva.NombreCampo = "AplicarRetencionIva"
        Me.cboAplicarRetencionIva.Obligatorio = False
        Me.cboAplicarRetencionIva.Query = ""
        Me.cboAplicarRetencionIva.SelectIndex = -1
        Me.cboAplicarRetencionIva.Size = New System.Drawing.Size(300, 20)
        Me.cboAplicarRetencionIva.SoloLectura = False
        Me.cboAplicarRetencionIva.StringConection = ""
        Me.cboAplicarRetencionIva.TabIndex = 17
        Me.cboAplicarRetencionIva.TextoNuevoItem = ""
        Me.cboAplicarRetencionIva.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAplicarRetencionIva.Valor = ""
        '
        'txtGestionEspecial
        '
        Me.txtGestionEspecial.CampoBusqueda = False
        Me.txtGestionEspecial.CampoEsLlave = False
        Me.txtGestionEspecial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGestionEspecial.ControlBackColor = System.Drawing.Color.White
        Me.txtGestionEspecial.ControlForeColor = System.Drawing.Color.Black
        Me.txtGestionEspecial.FechaActual = False
        Me.txtGestionEspecial.Formato = ""
        Me.txtGestionEspecial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGestionEspecial.LabelText = "Gestión Especial"
        Me.txtGestionEspecial.LabelWidth = 100
        Me.txtGestionEspecial.Location = New System.Drawing.Point(318, 296)
        Me.txtGestionEspecial.MaxLength = 25
        Me.txtGestionEspecial.Name = "txtGestionEspecial"
        Me.txtGestionEspecial.NombreCampo = "GestionEspecial"
        Me.txtGestionEspecial.Obligatorio = False
        Me.txtGestionEspecial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGestionEspecial.Size = New System.Drawing.Size(300, 20)
        Me.txtGestionEspecial.SoloLectura = False
        Me.txtGestionEspecial.TabIndex = 19
        Me.txtGestionEspecial.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtGestionEspecial.Valor = ""
        '
        'txtVencimientoTardio
        '
        Me.txtVencimientoTardio.CampoBusqueda = False
        Me.txtVencimientoTardio.CampoEsLlave = False
        Me.txtVencimientoTardio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVencimientoTardio.ControlBackColor = System.Drawing.Color.White
        Me.txtVencimientoTardio.ControlForeColor = System.Drawing.Color.Black
        Me.txtVencimientoTardio.FechaActual = True
        Me.txtVencimientoTardio.Formato = "dd/MMM/yyyy"
        Me.txtVencimientoTardio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVencimientoTardio.LabelText = "Vencimiento Tardío"
        Me.txtVencimientoTardio.LabelWidth = 100
        Me.txtVencimientoTardio.Location = New System.Drawing.Point(13, 296)
        Me.txtVencimientoTardio.MaxLength = 0
        Me.txtVencimientoTardio.Name = "txtVencimientoTardio"
        Me.txtVencimientoTardio.NombreCampo = "VencimientoTardio"
        Me.txtVencimientoTardio.Obligatorio = False
        Me.txtVencimientoTardio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVencimientoTardio.Size = New System.Drawing.Size(300, 20)
        Me.txtVencimientoTardio.SoloLectura = False
        Me.txtVencimientoTardio.TabIndex = 18
        Me.txtVencimientoTardio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVencimientoTardio.Valor = Nothing
        '
        'txtIdAC
        '
        Me.txtIdAC.CampoBusqueda = False
        Me.txtIdAC.CampoEsLlave = False
        Me.txtIdAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdAC.ControlBackColor = System.Drawing.Color.White
        Me.txtIdAC.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdAC.FechaActual = False
        Me.txtIdAC.Formato = ""
        Me.txtIdAC.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdAC.LabelText = ""
        Me.txtIdAC.LabelWidth = 0
        Me.txtIdAC.Location = New System.Drawing.Point(408, 318)
        Me.txtIdAC.MaxLength = 25
        Me.txtIdAC.Name = "txtIdAC"
        Me.txtIdAC.NombreCampo = ""
        Me.txtIdAC.Obligatorio = False
        Me.txtIdAC.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdAC.Size = New System.Drawing.Size(210, 20)
        Me.txtIdAC.SoloLectura = False
        Me.txtIdAC.TabIndex = 32
        Me.txtIdAC.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdAC.Valor = ""
        '
        'lblIdAC
        '
        Me.lblIdAC.AutoSize = True
        Me.lblIdAC.Location = New System.Drawing.Point(315, 320)
        Me.lblIdAC.Name = "lblIdAC"
        Me.lblIdAC.Size = New System.Drawing.Size(100, 13)
        Me.lblIdAC.TabIndex = 33
        Me.lblIdAC.TabStop = True
        Me.lblIdAC.Text = "No. Aviso de Cobro"
        '
        'PagosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 301
        Me.ClientSize = New System.Drawing.Size(631, 539)
        Me.Controls.Add(Me.lblIdAC)
        Me.Controls.Add(Me.txtIdAC)
        Me.Controls.Add(Me.txtVencimientoTardio)
        Me.Controls.Add(Me.txtGestionEspecial)
        Me.Controls.Add(Me.cboAplicarRetencionIva)
        Me.Controls.Add(Me.txtDocumentoFiscal)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.txtPorceComision)
        Me.Controls.Add(Me.txtIdRamo)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GridMovimientos)
        Me.Controls.Add(Me.txtTotalCuotas)
        Me.Controls.Add(Me.txtNumCuota)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.txtFechaPago)
        Me.Controls.Add(Me.txtFechaEmision)
        Me.Controls.Add(Me.cboTipoFactura)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdAnexo)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtNumeroFactura)
        Me.Name = "PagosMan"
        Me.SeguirAlGrabarActualizar = True
        Me.Text = "Administracion de Pagos"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroFactura, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdAnexo, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.cboTipoFactura, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEmision, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPago, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.txtNumCuota, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCuotas, 0)
        Me.Controls.SetChildIndex(Me.GridMovimientos, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.btnQuitar, 0)
        Me.Controls.SetChildIndex(Me.txtIdRamo, 0)
        Me.Controls.SetChildIndex(Me.txtPorceComision, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtDocumentoFiscal, 0)
        Me.Controls.SetChildIndex(Me.cboAplicarRetencionIva, 0)
        Me.Controls.SetChildIndex(Me.txtGestionEspecial, 0)
        Me.Controls.SetChildIndex(Me.txtVencimientoTardio, 0)
        Me.Controls.SetChildIndex(Me.txtIdAC, 0)
        Me.Controls.SetChildIndex(Me.lblIdAC, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuFact.ResumeLayout(False)
        CType(Me.VistaMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumeroFactura As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtIdAnexo As STIControles.stiTextBox
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents cboTipoFactura As STIControles.stiComboBox
    Friend WithEvents txtFechaEmision As STIControles.stiTextBox
    Friend WithEvents txtFechaPago As STIControles.stiTextBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents txtNumCuota As STIControles.stiTextBox
    Friend WithEvents txtTotalCuotas As STIControles.stiTextBox
    Friend WithEvents GridMovimientos As STIControles.stiGrid
    Friend WithEvents VistaMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIdRamo As STIControles.stiTextBox
    Friend WithEvents txtPorceComision As STIControles.stiTextBox
    Friend WithEvents txtReferencia As STIControles.stiTextBox
    Friend WithEvents txtObservaciones As STIControles.stiTextBox
    Friend WithEvents MenuFact As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImprimirCartaDocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDocumentoFiscal As STIControles.stiTextBox
    Friend WithEvents cboAplicarRetencionIva As STIControles.stiComboBox
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtGestionEspecial As STIControles.stiTextBox
    Friend WithEvents txtVencimientoTardio As STIControles.stiTextBox
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtIdAC As STIControles.stiTextBox
    Friend WithEvents lblIdAC As System.Windows.Forms.LinkLabel

End Class
