<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaSiniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaSiniestros))
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit
        Me.txtPoliza = New DevExpress.XtraEditors.TextEdit
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtIdCliente = New DevExpress.XtraEditors.TextEdit
        Me.GridSiniestros = New DevExpress.XtraGrid.GridControl
        Me.VistaSiniestros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSiniestro = New DevExpress.XtraEditors.TextEdit
        Me.txtFechaOcurrido = New DevExpress.XtraEditors.TextEdit
        Me.txtPagado = New DevExpress.XtraEditors.TextEdit
        Me.txtSiniestroAseg = New DevExpress.XtraEditors.TextEdit
        Me.txtAsegurado = New DevExpress.XtraEditors.TextEdit
        Me.txtBeneficiario = New DevExpress.XtraEditors.TextEdit
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiniestro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaOcurrido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPagado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiniestroAseg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsegurado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBeneficiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblStatus.Size = New System.Drawing.Size(539, 19)
        Me.lblStatus.TabIndex = 14
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(766, 257)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 13
        Me.btnQutar.Text = "&Salir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(669, 257)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "&Seleccionar"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(240, 4)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(43, 20)
        Me.txtProducto.TabIndex = 3
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(174, 4)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(46, 20)
        Me.txtPoliza.TabIndex = 2
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(669, 4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(32, 20)
        Me.txtEstado.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(378, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(99, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(302, 4)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(54, 20)
        Me.txtIdCliente.TabIndex = 4
        '
        'GridSiniestros
        '
        Me.GridSiniestros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSiniestros.Location = New System.Drawing.Point(3, 30)
        Me.GridSiniestros.MainView = Me.VistaSiniestros
        Me.GridSiniestros.Name = "GridSiniestros"
        Me.GridSiniestros.Size = New System.Drawing.Size(863, 220)
        Me.GridSiniestros.TabIndex = 11
        Me.GridSiniestros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaSiniestros})
        '
        'VistaSiniestros
        '
        Me.VistaSiniestros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.VistaSiniestros.GridControl = Me.GridSiniestros
        Me.VistaSiniestros.Name = "VistaSiniestros"
        Me.VistaSiniestros.OptionsBehavior.Editable = False
        Me.VistaSiniestros.OptionsCustomization.AllowColumnMoving = False
        Me.VistaSiniestros.OptionsCustomization.AllowGroup = False
        Me.VistaSiniestros.OptionsNavigation.EnterMoveNextColumn = True
        Me.VistaSiniestros.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Póliza"
        Me.GridColumn4.FieldName = "Poliza"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 64
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Producto"
        Me.GridColumn5.FieldName = "Producto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 64
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cod.Cliente"
        Me.GridColumn1.FieldName = "IdCliente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 83
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Contratante"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 106
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Estado"
        Me.GridColumn3.FieldName = "Estado"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 63
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Reclamo"
        Me.GridColumn6.FieldName = "Siniestro"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 64
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fec. Ocurre"
        Me.GridColumn7.DisplayFormat.FormatString = "dd/MMM/yyyy"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.FieldName = "FechaOcurrido"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        Me.GridColumn7.Width = 68
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "V.Pagado"
        Me.GridColumn8.DisplayFormat.FormatString = "c"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Pagado"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 10
        Me.GridColumn8.Width = 84
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Certificado"
        Me.GridColumn9.FieldName = "Certificado"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Reclamo Aseg."
        Me.GridColumn10.FieldName = "SiniestroAseg"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 78
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Asegurado"
        Me.GridColumn11.FieldName = "Asegurado"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 6
        Me.GridColumn11.Width = 100
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Beneficiario"
        Me.GridColumn12.FieldName = "Beneficiario"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 7
        Me.GridColumn12.Width = 68
        '
        'txtSiniestro
        '
        Me.txtSiniestro.Location = New System.Drawing.Point(18, 4)
        Me.txtSiniestro.Name = "txtSiniestro"
        Me.txtSiniestro.Size = New System.Drawing.Size(71, 20)
        Me.txtSiniestro.TabIndex = 0
        '
        'txtFechaOcurrido
        '
        Me.txtFechaOcurrido.Location = New System.Drawing.Point(739, 4)
        Me.txtFechaOcurrido.Name = "txtFechaOcurrido"
        Me.txtFechaOcurrido.Size = New System.Drawing.Size(17, 20)
        Me.txtFechaOcurrido.TabIndex = 9
        '
        'txtPagado
        '
        Me.txtPagado.Location = New System.Drawing.Point(808, 4)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.Size = New System.Drawing.Size(37, 20)
        Me.txtPagado.TabIndex = 10
        '
        'txtSiniestroAseg
        '
        Me.txtSiniestroAseg.Location = New System.Drawing.Point(91, 4)
        Me.txtSiniestroAseg.Name = "txtSiniestroAseg"
        Me.txtSiniestroAseg.Size = New System.Drawing.Size(63, 20)
        Me.txtSiniestroAseg.TabIndex = 1
        '
        'txtAsegurado
        '
        Me.txtAsegurado.Location = New System.Drawing.Point(492, 4)
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.Size = New System.Drawing.Size(32, 20)
        Me.txtAsegurado.TabIndex = 6
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Location = New System.Drawing.Point(595, 4)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(32, 20)
        Me.txtBeneficiario.TabIndex = 7
        '
        'BusquedaSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 291)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.txtAsegurado)
        Me.Controls.Add(Me.txtSiniestroAseg)
        Me.Controls.Add(Me.txtPagado)
        Me.Controls.Add(Me.txtFechaOcurrido)
        Me.Controls.Add(Me.txtSiniestro)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.GridSiniestros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaSiniestros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Siniestros"
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaSiniestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiniestro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaOcurrido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPagado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiniestroAseg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsegurado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBeneficiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEstado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridSiniestros As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaSiniestros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSiniestro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaOcurrido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPagado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSiniestroAseg As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAsegurado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBeneficiario As DevExpress.XtraEditors.TextEdit
End Class
