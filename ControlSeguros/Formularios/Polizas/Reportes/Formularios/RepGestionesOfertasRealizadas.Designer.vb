﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepGestionesOfertasRealizadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepGestionesOfertasRealizadas))
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaHasta = New STIControles.stiTextBox
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
        Me.colPolizas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaGrabacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboRamo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkUltimGes = New System.Windows.Forms.CheckBox
        Me.cboEstadoPoliza = New STIControles.stiComboBox
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(620, 374)
        Me.btnAyuda.TabIndex = 4
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(517, 374)
        Me.btnImprimir.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(723, 374)
        Me.btnSalir.TabIndex = 5
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
        Me.LabelControl1.Size = New System.Drawing.Size(689, 74)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Reporte de Gestiones de Ofertas"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(650, 75)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Búscar"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(12, 77)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(294, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = True
        Me.txtFechaHasta.Formato = "Long Date"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(329, 77)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(294, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'GridGestion
        '
        Me.GridGestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGestion.ColumnasAdicionales = ""
        Me.GridGestion.Location = New System.Drawing.Point(5, 123)
        Me.GridGestion.MainView = Me.VistaGestion
        Me.GridGestion.Name = "GridGestion"
        Me.GridGestion.NombreTabla = ""
        Me.GridGestion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboRamo})
        Me.GridGestion.Size = New System.Drawing.Size(818, 245)
        Me.GridGestion.TabIndex = 6
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
        Me.VistaGestion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFechaGestion, Me.colFechaProximaGestion, Me.colComentarios, Me.colGestionHecha, Me.colGestionARealizar, Me.colNombreCliente, Me.colTelefono, Me.colEMail, Me.colPolizas, Me.colUsuario, Me.colFechaGrabacion, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.VistaGestion.CustomizationFormBounds = New System.Drawing.Rectangle(661, 264, 216, 318)
        Me.VistaGestion.GridControl = Me.GridGestion
        Me.VistaGestion.GroupCount = 1
        Me.VistaGestion.Name = "VistaGestion"
        Me.VistaGestion.OptionsBehavior.AutoExpandAllGroups = True
        Me.VistaGestion.OptionsBehavior.Editable = False
        Me.VistaGestion.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUsuario, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFechaGestion, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        Me.colFechaProximaGestion.VisibleIndex = 2
        '
        'colComentarios
        '
        Me.colComentarios.Caption = "Comentarios"
        Me.colComentarios.FieldName = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.Visible = True
        Me.colComentarios.VisibleIndex = 3
        '
        'colGestionHecha
        '
        Me.colGestionHecha.Caption = "Gestión Hecha"
        Me.colGestionHecha.FieldName = "GestionHecha"
        Me.colGestionHecha.Name = "colGestionHecha"
        Me.colGestionHecha.Visible = True
        Me.colGestionHecha.VisibleIndex = 1
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
        'colPolizas
        '
        Me.colPolizas.Caption = "No. Oferta"
        Me.colPolizas.FieldName = "IdPoliza"
        Me.colPolizas.Name = "colPolizas"
        Me.colPolizas.Visible = True
        Me.colPolizas.VisibleIndex = 8
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Usuario Gestión"
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        '
        'colFechaGrabacion
        '
        Me.colFechaGrabacion.Caption = "Fecha Grabación"
        Me.colFechaGrabacion.DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
        Me.colFechaGrabacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaGrabacion.FieldName = "FechaGrabacion"
        Me.colFechaGrabacion.Name = "colFechaGrabacion"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod. Gestión"
        Me.GridColumn1.FieldName = "IdGestion"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Aseguradora"
        Me.GridColumn2.FieldName = "Aseguradora"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ramo"
        Me.GridColumn3.ColumnEdit = Me.cboRamo
        Me.GridColumn3.FieldName = "Ramo"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'cboRamo
        '
        Me.cboRamo.AutoHeight = False
        Me.cboRamo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NullText = ""
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha de Solicitud"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "FechaSolicitud"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Fecha de Envío"
        Me.GridColumn5.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn5.FieldName = "FechaEnvio"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Días Respuesta"
        Me.GridColumn6.DisplayFormat.FormatString = "n0"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "DiasRespuesta"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'chkUltimGes
        '
        Me.chkUltimGes.AutoSize = True
        Me.chkUltimGes.Location = New System.Drawing.Point(650, 104)
        Me.chkUltimGes.Name = "chkUltimGes"
        Me.chkUltimGes.Size = New System.Drawing.Size(165, 17)
        Me.chkUltimGes.TabIndex = 18
        Me.chkUltimGes.Text = "Mostrar solo la última gestión"
        Me.chkUltimGes.UseVisualStyleBackColor = True
        '
        'cboEstadoPoliza
        '
        Me.cboEstadoPoliza.CampoAutoCompletar = 0
        Me.cboEstadoPoliza.CampoBusqueda = False
        Me.cboEstadoPoliza.CampoDisplay = 1
        Me.cboEstadoPoliza.CampoEsLlave = False
        Me.cboEstadoPoliza.CampoValor = 0
        Me.cboEstadoPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoPoliza.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoPoliza.FilasVisibles = 0
        Me.cboEstadoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoPoliza.LabelText = "Estado Oferta"
        Me.cboEstadoPoliza.LabelWidth = 100
        Me.cboEstadoPoliza.Lista = "PENDIENTE Pendiente|ACEPTADA Aceptada|RECHAZADA Rechazada"
        Me.cboEstadoPoliza.Location = New System.Drawing.Point(329, 100)
        Me.cboEstadoPoliza.MostrarBusquedaColumnas = False
        Me.cboEstadoPoliza.Name = "cboEstadoPoliza"
        Me.cboEstadoPoliza.NombreCampo = "Estado"
        Me.cboEstadoPoliza.Obligatorio = False
        Me.cboEstadoPoliza.Query = ""
        Me.cboEstadoPoliza.SelectIndex = 0
        Me.cboEstadoPoliza.Size = New System.Drawing.Size(294, 20)
        Me.cboEstadoPoliza.SoloLectura = False
        Me.cboEstadoPoliza.StringConection = ""
        Me.cboEstadoPoliza.TabIndex = 19
        Me.cboEstadoPoliza.TextoNuevoItem = ""
        Me.cboEstadoPoliza.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoPoliza.Valor = ""
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Bienes a Asegurar"
        Me.GridColumn7.FieldName = "Bienes"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 10
        '
        'RepGestionesOfertasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 515
        Me.ClientSize = New System.Drawing.Size(826, 412)
        Me.Controls.Add(Me.cboEstadoPoliza)
        Me.Controls.Add(Me.chkUltimGes)
        Me.Controls.Add(Me.GridGestion)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepGestionesOfertasRealizadas"
        Me.Text = "Reporte de Gestiones de Ofertas"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.GridGestion, 0)
        Me.Controls.SetChildIndex(Me.chkUltimGes, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoPoliza, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents GridGestion As STIControles.stiGrid
    Friend WithEvents VistaGestion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFechaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProximaGestion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGestionHecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGestionARealizar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPolizas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaGrabacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboRamo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkUltimGes As System.Windows.Forms.CheckBox
    Friend WithEvents cboEstadoPoliza As STIControles.stiComboBox
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

End Class