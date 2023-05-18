<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepClientesAnalisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepClientesAnalisis))
        Me.GridClientes = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.colIdCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNombreCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDui = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRegistroFiscal = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colGiro = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFechaNacimiento = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colEmail = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFax = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colIdTipoCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colEjecutivoCta = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colLugarTrabajo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colTelefono = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colDireccion = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colCiudad = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colCargo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colIdPoliza = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colAseguradora = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colProducto = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colRamo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFechaVinculacion = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colNombreRepLegal = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colFnacRepLegal = New DevExpress.XtraPivotGrid.PivotGridField
        Me.colGrupoCliente = New DevExpress.XtraPivotGrid.PivotGridField
        Me.chkVigentes = New DevExpress.XtraEditors.CheckEdit
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVigentes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(534, 382)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(431, 382)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(637, 382)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
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
        Me.LabelControl1.Size = New System.Drawing.Size(603, 74)
        Me.LabelControl1.Text = "Análisis de Clientes y Pólizas Vigentes"
        '
        'GridClientes
        '
        Me.GridClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridClientes.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colIdCliente, Me.colNombreCliente, Me.colDui, Me.colRegistroFiscal, Me.colGiro, Me.colFechaNacimiento, Me.colEmail, Me.colFax, Me.colIdTipoCliente, Me.colEjecutivoCta, Me.colLugarTrabajo, Me.colTelefono, Me.colDireccion, Me.colCiudad, Me.colCargo, Me.colIdPoliza, Me.colAseguradora, Me.colProducto, Me.colRamo, Me.colFechaVinculacion, Me.colNombreRepLegal, Me.colFnacRepLegal, Me.colGrupoCliente, Me.PivotGridField1, Me.PivotGridField2})
        Me.GridClientes.Location = New System.Drawing.Point(-3, 81)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(741, 298)
        Me.GridClientes.TabIndex = 17
        '
        'colIdCliente
        '
        Me.colIdCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colIdCliente.AreaIndex = 0
        Me.colIdCliente.Caption = "Cod. Cliente"
        Me.colIdCliente.FieldName = "IdCliente"
        Me.colIdCliente.Name = "colIdCliente"
        '
        'colNombreCliente
        '
        Me.colNombreCliente.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNombreCliente.AreaIndex = 1
        Me.colNombreCliente.Caption = "Nombre Cliente"
        Me.colNombreCliente.FieldName = "NombreCliente"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.Width = 200
        '
        'colDui
        '
        Me.colDui.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colDui.AreaIndex = 4
        Me.colDui.Caption = "DUI"
        Me.colDui.FieldName = "Dui"
        Me.colDui.Name = "colDui"
        '
        'colRegistroFiscal
        '
        Me.colRegistroFiscal.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colRegistroFiscal.AreaIndex = 6
        Me.colRegistroFiscal.Caption = "Registro Fiscal"
        Me.colRegistroFiscal.FieldName = "RegistroFiscal"
        Me.colRegistroFiscal.Name = "colRegistroFiscal"
        '
        'colGiro
        '
        Me.colGiro.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colGiro.AreaIndex = 3
        Me.colGiro.Caption = "Giro"
        Me.colGiro.FieldName = "Giro"
        Me.colGiro.Name = "colGiro"
        '
        'colFechaNacimiento
        '
        Me.colFechaNacimiento.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colFechaNacimiento.AreaIndex = 5
        Me.colFechaNacimiento.Caption = "Fecha Nacimiento"
        Me.colFechaNacimiento.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaNacimiento.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaNacimiento.FieldName = "FechaNacimiento"
        Me.colFechaNacimiento.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaNacimiento.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaNacimiento.Name = "colFechaNacimiento"
        Me.colFechaNacimiento.TotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaNacimiento.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaNacimiento.TotalValueFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaNacimiento.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaNacimiento.ValueFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaNacimiento.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'colEmail
        '
        Me.colEmail.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colEmail.AreaIndex = 3
        Me.colEmail.Caption = "Email"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        '
        'colFax
        '
        Me.colFax.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colFax.AreaIndex = 2
        Me.colFax.Caption = "Fax"
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        '
        'colIdTipoCliente
        '
        Me.colIdTipoCliente.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colIdTipoCliente.AreaIndex = 1
        Me.colIdTipoCliente.Caption = "Tipo Cliente"
        Me.colIdTipoCliente.FieldName = "IdTipoCliente"
        Me.colIdTipoCliente.Name = "colIdTipoCliente"
        '
        'colEjecutivoCta
        '
        Me.colEjecutivoCta.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colEjecutivoCta.AreaIndex = 0
        Me.colEjecutivoCta.Caption = "Ejecutivo de Cuenta"
        Me.colEjecutivoCta.FieldName = "EjecutivoCta"
        Me.colEjecutivoCta.Name = "colEjecutivoCta"
        '
        'colLugarTrabajo
        '
        Me.colLugarTrabajo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colLugarTrabajo.AreaIndex = 7
        Me.colLugarTrabajo.Caption = "Lugar de Trabajo"
        Me.colLugarTrabajo.FieldName = "LugarTrabajo"
        Me.colLugarTrabajo.Name = "colLugarTrabajo"
        '
        'colTelefono
        '
        Me.colTelefono.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colTelefono.AreaIndex = 4
        Me.colTelefono.Caption = "Teléfono"
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        '
        'colDireccion
        '
        Me.colDireccion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colDireccion.AreaIndex = 2
        Me.colDireccion.Caption = "Dirección"
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        '
        'colCiudad
        '
        Me.colCiudad.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colCiudad.AreaIndex = 8
        Me.colCiudad.Caption = "Ciudad"
        Me.colCiudad.FieldName = "Ciudad"
        Me.colCiudad.Name = "colCiudad"
        '
        'colCargo
        '
        Me.colCargo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colCargo.AreaIndex = 9
        Me.colCargo.Caption = "Cargo"
        Me.colCargo.FieldName = "Cargo"
        Me.colCargo.Name = "colCargo"
        '
        'colIdPoliza
        '
        Me.colIdPoliza.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colIdPoliza.AreaIndex = 0
        Me.colIdPoliza.Caption = "Póliza"
        Me.colIdPoliza.FieldName = "IdPoliza"
        Me.colIdPoliza.Name = "colIdPoliza"
        Me.colIdPoliza.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'colAseguradora
        '
        Me.colAseguradora.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.colAseguradora.AreaIndex = 0
        Me.colAseguradora.Caption = "Aseguradora"
        Me.colAseguradora.FieldName = "Aseguradora"
        Me.colAseguradora.Name = "colAseguradora"
        '
        'colProducto
        '
        Me.colProducto.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colProducto.AreaIndex = 10
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        '
        'colRamo
        '
        Me.colRamo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colRamo.AreaIndex = 11
        Me.colRamo.Caption = "Ramo"
        Me.colRamo.FieldName = "Ramo"
        Me.colRamo.Name = "colRamo"
        '
        'colFechaVinculacion
        '
        Me.colFechaVinculacion.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colFechaVinculacion.AreaIndex = 12
        Me.colFechaVinculacion.Caption = "Fecha Vinculación"
        Me.colFechaVinculacion.CellFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaVinculacion.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaVinculacion.FieldName = "FechaVinculacion"
        Me.colFechaVinculacion.GrandTotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaVinculacion.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaVinculacion.Name = "colFechaVinculacion"
        Me.colFechaVinculacion.TotalCellFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaVinculacion.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaVinculacion.TotalValueFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaVinculacion.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaVinculacion.ValueFormat.FormatString = "dd/MMM/yyyy"
        Me.colFechaVinculacion.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'colNombreRepLegal
        '
        Me.colNombreRepLegal.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colNombreRepLegal.AreaIndex = 13
        Me.colNombreRepLegal.Caption = "Representante Legal"
        Me.colNombreRepLegal.FieldName = "NombreRepLegal"
        Me.colNombreRepLegal.Name = "colNombreRepLegal"
        '
        'colFnacRepLegal
        '
        Me.colFnacRepLegal.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colFnacRepLegal.AreaIndex = 14
        Me.colFnacRepLegal.Caption = "Fecha Nac. Representante Legal"
        Me.colFnacRepLegal.FieldName = "FnacRepLegal"
        Me.colFnacRepLegal.Name = "colFnacRepLegal"
        '
        'colGrupoCliente
        '
        Me.colGrupoCliente.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.colGrupoCliente.AreaIndex = 15
        Me.colGrupoCliente.Caption = "Grupo Cliente"
        Me.colGrupoCliente.FieldName = "GrupoCliente"
        Me.colGrupoCliente.Name = "colGrupoCliente"
        '
        'chkVigentes
        '
        Me.chkVigentes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkVigentes.EditValue = True
        Me.chkVigentes.Location = New System.Drawing.Point(1, 385)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkVigentes.Properties.Appearance.Options.UseFont = True
        Me.chkVigentes.Properties.Caption = "Incluir únicamente pólizas vigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(239, 19)
        Me.chkVigentes.TabIndex = 18
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField1.AreaIndex = 16
        Me.PivotGridField1.Caption = "Prima Neta Póliza"
        Me.PivotGridField1.CellFormat.FormatString = "c"
        Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.FieldName = "PrimaNeta"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Me.PivotGridField2.AreaIndex = 17
        Me.PivotGridField2.Caption = "Vendedor"
        Me.PivotGridField2.FieldName = "Vendedor"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'RepClientesAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 504
        Me.ClientSize = New System.Drawing.Size(740, 420)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.chkVigentes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "RepClientesAnalisis"
        Me.Text = "Clientes"
        Me.Controls.SetChildIndex(Me.chkVigentes, 0)
        Me.Controls.SetChildIndex(Me.GridClientes, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVigentes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridClientes As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents colIdCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNombreCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDui As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRegistroFiscal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGiro As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFechaNacimiento As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEmail As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFax As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colIdTipoCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEjecutivoCta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colLugarTrabajo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colTelefono As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colDireccion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCiudad As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCargo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colIdPoliza As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAseguradora As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colProducto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRamo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFechaVinculacion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents chkVigentes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colNombreRepLegal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFnacRepLegal As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGrupoCliente As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField

End Class
