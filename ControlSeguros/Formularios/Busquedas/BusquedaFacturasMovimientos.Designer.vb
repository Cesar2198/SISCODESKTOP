<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaFacturasMovimientos
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaFacturasMovimientos))
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit
        Me.txtPoliza = New DevExpress.XtraEditors.TextEdit
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtIdCliente = New DevExpress.XtraEditors.TextEdit
        Me.GridFacturas = New DevExpress.XtraGrid.GridControl
        Me.VistaFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
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
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.txtFecha = New DevExpress.XtraEditors.TextEdit
        Me.txtTipoMov = New DevExpress.XtraEditors.TextEdit
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(630, 221)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 15
        Me.btnQutar.Text = "&Salir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(533, 221)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "&Seleccionar"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(399, 2)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(73, 20)
        Me.txtProducto.TabIndex = 11
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(322, 2)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(75, 20)
        Me.txtPoliza.TabIndex = 10
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(250, 2)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(69, 20)
        Me.txtFactura.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(99, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(21, 2)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(76, 20)
        Me.txtIdCliente.TabIndex = 12
        '
        'GridFacturas
        '
        Me.GridFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFacturas.Location = New System.Drawing.Point(4, 28)
        Me.GridFacturas.MainView = Me.VistaFacturas
        Me.GridFacturas.Name = "GridFacturas"
        Me.GridFacturas.Size = New System.Drawing.Size(718, 187)
        Me.GridFacturas.TabIndex = 13
        Me.GridFacturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaFacturas})
        '
        'VistaFacturas
        '
        Me.VistaFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.VistaFacturas.GridControl = Me.GridFacturas
        Me.VistaFacturas.Name = "VistaFacturas"
        Me.VistaFacturas.OptionsBehavior.Editable = False
        Me.VistaFacturas.OptionsCustomization.AllowColumnMoving = False
        Me.VistaFacturas.OptionsCustomization.AllowGroup = False
        Me.VistaFacturas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaFacturas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nit Cliente"
        Me.GridColumn1.FieldName = "IdCliente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre Cliente"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "N�m. Factura"
        Me.GridColumn3.FieldName = "Factura"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "P�liza"
        Me.GridColumn4.FieldName = "Poliza"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Producto"
        Me.GridColumn5.FieldName = "Producto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "IdRamo"
        Me.GridColumn6.FieldName = "IdRamo"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IdMovimiento"
        Me.GridColumn7.FieldName = "IdMovimiento"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Tipo Mov."
        Me.GridColumn8.FieldName = "TipoMov"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Valor"
        Me.GridColumn9.FieldName = "Valor"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 97
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Fecha"
        Me.GridColumn10.FieldName = "Fecha"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Appearance.Options.UseForeColor = True
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Location = New System.Drawing.Point(4, 223)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(436, 19)
        Me.lblStatus.TabIndex = 16
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(474, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(73, 20)
        Me.txtFecha.TabIndex = 17
        '
        'txtTipoMov
        '
        Me.txtTipoMov.Location = New System.Drawing.Point(549, 2)
        Me.txtTipoMov.Name = "txtTipoMov"
        Me.txtTipoMov.Size = New System.Drawing.Size(73, 20)
        Me.txtTipoMov.TabIndex = 18
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(624, 2)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(98, 20)
        Me.txtValor.TabIndex = 19
        '
        'BusquedaFacturasMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 251)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtTipoMov)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.GridFacturas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaFacturasMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B�squeda de Movimientos de Facturas"
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridFacturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTipoMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
End Class
