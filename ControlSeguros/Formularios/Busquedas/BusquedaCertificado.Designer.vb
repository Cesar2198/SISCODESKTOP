<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCertificados
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
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit
        Me.txtPoliza = New DevExpress.XtraEditors.TextEdit
        Me.txtCertificado = New DevExpress.XtraEditors.TextEdit
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtIdCliente = New DevExpress.XtraEditors.TextEdit
        Me.GridPolizas = New DevExpress.XtraGrid.GridControl
        Me.VistaPolizas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtBienes = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCertificado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBienes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Appearance.Options.UseForeColor = True
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Location = New System.Drawing.Point(3, 258)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(353, 19)
        Me.lblStatus.TabIndex = 25
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(657, 257)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 7
        Me.btnQutar.Text = "&Salir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(560, 257)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "&Seleccionar"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(91, 5)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(91, 20)
        Me.txtProducto.TabIndex = 1
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(19, 5)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(70, 20)
        Me.txtPoliza.TabIndex = 0
        '
        'txtCertificado
        '
        Me.txtCertificado.Location = New System.Drawing.Point(470, 5)
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.Size = New System.Drawing.Size(72, 20)
        Me.txtCertificado.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(276, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(185, 5)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(88, 20)
        Me.txtIdCliente.TabIndex = 2
        '
        'GridPolizas
        '
        Me.GridPolizas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPolizas.Location = New System.Drawing.Point(3, 31)
        Me.GridPolizas.MainView = Me.VistaPolizas
        Me.GridPolizas.Name = "GridPolizas"
        Me.GridPolizas.Size = New System.Drawing.Size(754, 219)
        Me.GridPolizas.TabIndex = 5
        Me.GridPolizas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPolizas})
        '
        'VistaPolizas
        '
        Me.VistaPolizas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6})
        Me.VistaPolizas.GridControl = Me.GridPolizas
        Me.VistaPolizas.Name = "VistaPolizas"
        Me.VistaPolizas.OptionsBehavior.Editable = False
        Me.VistaPolizas.OptionsCustomization.AllowColumnMoving = False
        Me.VistaPolizas.OptionsCustomization.AllowGroup = False
        Me.VistaPolizas.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaPolizas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "P�liza"
        Me.GridColumn4.FieldName = "Poliza"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 70
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Producto"
        Me.GridColumn5.FieldName = "Producto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 90
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nit Cliente"
        Me.GridColumn1.FieldName = "IdCliente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 90
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre Cliente"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 200
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Certificado"
        Me.GridColumn3.FieldName = "Certificado"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 70
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Bienes"
        Me.GridColumn6.FieldName = "Bienes"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 213
        '
        'txtBienes
        '
        Me.txtBienes.Location = New System.Drawing.Point(544, 5)
        Me.txtBienes.Name = "txtBienes"
        Me.txtBienes.Size = New System.Drawing.Size(212, 20)
        Me.txtBienes.TabIndex = 26
        '
        'BusquedaCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 291)
        Me.Controls.Add(Me.txtBienes)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.txtCertificado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.GridPolizas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaCertificados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B�squeda de Certificado y Bienes"
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCertificado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBienes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCertificado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridPolizas As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaPolizas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBienes As DevExpress.XtraEditors.TextEdit
End Class
