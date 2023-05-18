<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaRecibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaRecibos))
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtFecha = New DevExpress.XtraEditors.TextEdit
        Me.txtRecibo = New DevExpress.XtraEditors.TextEdit
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtIdCliente = New DevExpress.XtraEditors.TextEdit
        Me.GridRecibos = New DevExpress.XtraGrid.GridControl
        Me.VistaRecibos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Appearance.Options.UseForeColor = True
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Location = New System.Drawing.Point(4, 218)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(343, 19)
        Me.lblStatus.TabIndex = 25
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(450, 216)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 24
        Me.btnQutar.Text = "&Salir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(353, 216)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "&Seleccionar"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(464, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(76, 20)
        Me.txtTotal.TabIndex = 20
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(392, 3)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(70, 20)
        Me.txtFecha.TabIndex = 19
        '
        'txtRecibo
        '
        Me.txtRecibo.Location = New System.Drawing.Point(308, 3)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(82, 20)
        Me.txtRecibo.TabIndex = 18
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(113, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 20)
        Me.txtNombre.TabIndex = 17
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(21, 3)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(88, 20)
        Me.txtIdCliente.TabIndex = 21
        '
        'GridRecibos
        '
        Me.GridRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRecibos.Location = New System.Drawing.Point(4, 26)
        Me.GridRecibos.MainView = Me.VistaRecibos
        Me.GridRecibos.Name = "GridRecibos"
        Me.GridRecibos.Size = New System.Drawing.Size(553, 187)
        Me.GridRecibos.TabIndex = 22
        Me.GridRecibos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaRecibos})
        '
        'VistaRecibos
        '
        Me.VistaRecibos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.VistaRecibos.GridControl = Me.GridRecibos
        Me.VistaRecibos.Name = "VistaRecibos"
        Me.VistaRecibos.OptionsBehavior.Editable = False
        Me.VistaRecibos.OptionsCustomization.AllowColumnMoving = False
        Me.VistaRecibos.OptionsCustomization.AllowGroup = False
        Me.VistaRecibos.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaRecibos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nit Cliente"
        Me.GridColumn1.FieldName = "IdCliente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 88
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre Cliente"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 195
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Núm. Recibo"
        Me.GridColumn3.FieldName = "Recibo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 86
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha"
        Me.GridColumn4.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "Fecha"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 70
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Valor Recibo"
        Me.GridColumn5.DisplayFormat.FormatString = "c"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 93
        '
        'BusquedaRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 241)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtRecibo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.GridRecibos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BusquedaRecibos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Recibos"
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRecibo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridRecibos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaRecibos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
