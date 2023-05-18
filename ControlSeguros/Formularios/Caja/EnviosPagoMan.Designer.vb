<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnviosPagoMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnviosPagoMan))
        Me.txtIdEnvio = New STIControles.stiTextBox
        Me.txtFechaCorte = New STIControles.stiTextBox
        Me.txtFechaEnvio = New STIControles.stiTextBox
        Me.txtIdUsuario = New STIControles.stiTextBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton
        Me.txtMotivoAnulacion = New STIControles.stiTextBox
        Me.txtFechaAnulacion = New STIControles.stiTextBox
        Me.GridRecibos = New STIControles.stiGrid
        Me.VistaRecibos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdRecibo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboIdAseguradora = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(440, 374)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(127, 404)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(171, 404)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(175, 404)
        Me.btnGuardar.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(532, 374)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(143, 404)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Text = "Eliminar"
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(487, 74)
        Me.lblNombreFormulario.Text = "Envíos de Pago a las Aseguradoras"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(159, 402)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 12)
        Me.btnGuardarComo.Visible = False
        '
        'txtIdEnvio
        '
        Me.txtIdEnvio.CampoBusqueda = True
        Me.txtIdEnvio.CampoEsLlave = True
        Me.txtIdEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtIdEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdEnvio.FechaActual = False
        Me.txtIdEnvio.Formato = ""
        Me.txtIdEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdEnvio.LabelText = "Cod. Envío"
        Me.txtIdEnvio.LabelWidth = 100
        Me.txtIdEnvio.Location = New System.Drawing.Point(12, 106)
        Me.txtIdEnvio.MaxLength = 0
        Me.txtIdEnvio.Name = "txtIdEnvio"
        Me.txtIdEnvio.NombreCampo = "IdEnvio"
        Me.txtIdEnvio.Obligatorio = True
        Me.txtIdEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtIdEnvio.SoloLectura = False
        Me.txtIdEnvio.TabIndex = 1
        Me.txtIdEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdEnvio.Valor = "0"
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
        Me.txtFechaCorte.LabelWidth = 100
        Me.txtFechaCorte.Location = New System.Drawing.Point(318, 106)
        Me.txtFechaCorte.MaxLength = 0
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.NombreCampo = "FechaCorte"
        Me.txtFechaCorte.Obligatorio = True
        Me.txtFechaCorte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCorte.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaCorte.SoloLectura = False
        Me.txtFechaCorte.TabIndex = 2
        Me.txtFechaCorte.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCorte.Valor = Nothing
        '
        'txtFechaEnvio
        '
        Me.txtFechaEnvio.CampoBusqueda = True
        Me.txtFechaEnvio.CampoEsLlave = False
        Me.txtFechaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnvio.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnvio.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnvio.FechaActual = False
        Me.txtFechaEnvio.Formato = "Long Date"
        Me.txtFechaEnvio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnvio.LabelText = "Fecha de Envío"
        Me.txtFechaEnvio.LabelWidth = 100
        Me.txtFechaEnvio.Location = New System.Drawing.Point(12, 132)
        Me.txtFechaEnvio.MaxLength = 0
        Me.txtFechaEnvio.Name = "txtFechaEnvio"
        Me.txtFechaEnvio.NombreCampo = "FechaEnvio"
        Me.txtFechaEnvio.Obligatorio = True
        Me.txtFechaEnvio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnvio.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaEnvio.SoloLectura = False
        Me.txtFechaEnvio.TabIndex = 3
        Me.txtFechaEnvio.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnvio.Valor = Nothing
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.CampoBusqueda = True
        Me.txtIdUsuario.CampoEsLlave = False
        Me.txtIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdUsuario.ControlBackColor = System.Drawing.Color.White
        Me.txtIdUsuario.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdUsuario.FechaActual = False
        Me.txtIdUsuario.Formato = ""
        Me.txtIdUsuario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdUsuario.LabelText = "Usuario Envío"
        Me.txtIdUsuario.LabelWidth = 100
        Me.txtIdUsuario.Location = New System.Drawing.Point(318, 132)
        Me.txtIdUsuario.MaxLength = 25
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.NombreCampo = "IdUsuario"
        Me.txtIdUsuario.Obligatorio = False
        Me.txtIdUsuario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdUsuario.Size = New System.Drawing.Size(300, 20)
        Me.txtIdUsuario.SoloLectura = False
        Me.txtIdUsuario.TabIndex = 4
        Me.txtIdUsuario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdUsuario.Valor = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(191, 376)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(159, 36)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "&Re-Imprimir Envío"
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAnular.Appearance.Options.UseFont = True
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(349, 374)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(92, 36)
        Me.btnAnular.TabIndex = 9
        Me.btnAnular.Text = "A&nular"
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.CampoBusqueda = False
        Me.txtMotivoAnulacion.CampoEsLlave = False
        Me.txtMotivoAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMotivoAnulacion.ControlBackColor = System.Drawing.Color.White
        Me.txtMotivoAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtMotivoAnulacion.FechaActual = False
        Me.txtMotivoAnulacion.Formato = ""
        Me.txtMotivoAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtMotivoAnulacion.LabelText = "Motivo Anulación"
        Me.txtMotivoAnulacion.LabelWidth = 100
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(13, 158)
        Me.txtMotivoAnulacion.MaxLength = 250
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.NombreCampo = "MotivoAnulacion"
        Me.txtMotivoAnulacion.Obligatorio = False
        Me.txtMotivoAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(299, 20)
        Me.txtMotivoAnulacion.SoloLectura = False
        Me.txtMotivoAnulacion.TabIndex = 5
        Me.txtMotivoAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtMotivoAnulacion.Valor = ""
        '
        'txtFechaAnulacion
        '
        Me.txtFechaAnulacion.CampoBusqueda = False
        Me.txtFechaAnulacion.CampoEsLlave = False
        Me.txtFechaAnulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAnulacion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAnulacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAnulacion.FechaActual = False
        Me.txtFechaAnulacion.Formato = "Long Date"
        Me.txtFechaAnulacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAnulacion.LabelText = "Fecha Anulacion"
        Me.txtFechaAnulacion.LabelWidth = 100
        Me.txtFechaAnulacion.Location = New System.Drawing.Point(318, 158)
        Me.txtFechaAnulacion.MaxLength = 0
        Me.txtFechaAnulacion.Name = "txtFechaAnulacion"
        Me.txtFechaAnulacion.NombreCampo = "FechaAnulacion"
        Me.txtFechaAnulacion.Obligatorio = False
        Me.txtFechaAnulacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAnulacion.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaAnulacion.SoloLectura = False
        Me.txtFechaAnulacion.TabIndex = 6
        Me.txtFechaAnulacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAnulacion.Valor = Nothing
        '
        'GridRecibos
        '
        Me.GridRecibos.ColumnasAdicionales = ""
        Me.GridRecibos.Location = New System.Drawing.Point(12, 184)
        Me.GridRecibos.MainView = Me.VistaRecibos
        Me.GridRecibos.Name = "GridRecibos"
        Me.GridRecibos.NombreTabla = ""
        Me.GridRecibos.Size = New System.Drawing.Size(606, 186)
        Me.GridRecibos.TabIndex = 8
        Me.GridRecibos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaRecibos})
        '
        'VistaRecibos
        '
        Me.VistaRecibos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdRecibo, Me.ColNombre, Me.colTotal})
        Me.VistaRecibos.GridControl = Me.GridRecibos
        Me.VistaRecibos.Name = "VistaRecibos"
        Me.VistaRecibos.OptionsView.ShowFooter = True
        Me.VistaRecibos.OptionsView.ShowGroupPanel = False
        '
        'colIdRecibo
        '
        Me.colIdRecibo.Caption = "Recibo"
        Me.colIdRecibo.FieldName = "IdRecibo"
        Me.colIdRecibo.Name = "colIdRecibo"
        Me.colIdRecibo.Visible = True
        Me.colIdRecibo.VisibleIndex = 0
        Me.colIdRecibo.Width = 144
        '
        'ColNombre
        '
        Me.ColNombre.Caption = "Cliente"
        Me.ColNombre.FieldName = "Nombre"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Visible = True
        Me.ColNombre.VisibleIndex = 1
        Me.ColNombre.Width = 220
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total Recibo"
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 2
        Me.colTotal.Width = 221
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.CampoAutoCompletar = 0
        Me.cboIdAseguradora.CampoBusqueda = False
        Me.cboIdAseguradora.CampoDisplay = 1
        Me.cboIdAseguradora.CampoEsLlave = False
        Me.cboIdAseguradora.CampoValor = 0
        Me.cboIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAseguradora.FilasVisibles = 11
        Me.cboIdAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAseguradora.LabelText = "Aseguradora"
        Me.cboIdAseguradora.LabelWidth = 100
        Me.cboIdAseguradora.Lista = ""
        Me.cboIdAseguradora.Location = New System.Drawing.Point(13, 81)
        Me.cboIdAseguradora.MostrarBusquedaColumnas = False
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NombreCampo = "IdAseguradora"
        Me.cboIdAseguradora.Obligatorio = False
        Me.cboIdAseguradora.Query = "select IdAseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nomb" & _
            "re"
        Me.cboIdAseguradora.SelectIndex = 0
        Me.cboIdAseguradora.Size = New System.Drawing.Size(605, 20)
        Me.cboIdAseguradora.SoloLectura = False
        Me.cboIdAseguradora.StringConection = ""
        Me.cboIdAseguradora.TabIndex = 0
        Me.cboIdAseguradora.TextoNuevoItem = ""
        Me.cboIdAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAseguradora.Valor = ""
        '
        'EnviosPagoMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 405
        Me.ClientSize = New System.Drawing.Size(626, 414)
        Me.Controls.Add(Me.cboIdAseguradora)
        Me.Controls.Add(Me.GridRecibos)
        Me.Controls.Add(Me.txtFechaAnulacion)
        Me.Controls.Add(Me.txtMotivoAnulacion)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtIdUsuario)
        Me.Controls.Add(Me.txtFechaEnvio)
        Me.Controls.Add(Me.txtFechaCorte)
        Me.Controls.Add(Me.txtIdEnvio)
        Me.Name = "EnviosPagoMan"
        Me.Text = "Envíos"
        Me.Controls.SetChildIndex(Me.txtIdEnvio, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCorte, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnvio, 0)
        Me.Controls.SetChildIndex(Me.txtIdUsuario, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAnular, 0)
        Me.Controls.SetChildIndex(Me.txtMotivoAnulacion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAnulacion, 0)
        Me.Controls.SetChildIndex(Me.GridRecibos, 0)
        Me.Controls.SetChildIndex(Me.cboIdAseguradora, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdEnvio As STIControles.stiTextBox
    Friend WithEvents txtFechaCorte As STIControles.stiTextBox
    Friend WithEvents txtFechaEnvio As STIControles.stiTextBox
    Friend WithEvents txtIdUsuario As STIControles.stiTextBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMotivoAnulacion As STIControles.stiTextBox
    Friend WithEvents txtFechaAnulacion As STIControles.stiTextBox
    Friend WithEvents GridRecibos As STIControles.stiGrid
    Friend WithEvents VistaRecibos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboIdAseguradora As STIControles.stiComboBox

End Class
