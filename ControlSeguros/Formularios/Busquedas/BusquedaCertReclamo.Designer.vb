<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCertReclamo
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
        Me.txtBeneficiario = New DevExpress.XtraEditors.TextEdit
        Me.txtAsegurado = New DevExpress.XtraEditors.TextEdit
        Me.txtContratante = New DevExpress.XtraEditors.TextEdit
        Me.GridPolizas = New DevExpress.XtraGrid.GridControl
        Me.VistaPolizas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCertificado = New DevExpress.XtraEditors.TextEdit
        Me.cboPlan = New STIControles.stiComboBox
        Me.txtIdBien = New DevExpress.XtraEditors.TextEdit
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBeneficiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsegurado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContratante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCertificado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdBien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Appearance.Options.UseForeColor = True
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Location = New System.Drawing.Point(3, 291)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(353, 19)
        Me.lblStatus.TabIndex = 11
        '
        'btnQutar
        '
        Me.btnQutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQutar.Location = New System.Drawing.Point(657, 290)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 10
        Me.btnQutar.Text = "&Salir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(560, 290)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "&Seleccionar"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(91, 27)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(72, 20)
        Me.txtProducto.TabIndex = 2
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(19, 27)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(70, 20)
        Me.txtPoliza.TabIndex = 1
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Location = New System.Drawing.Point(536, 27)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(128, 20)
        Me.txtBeneficiario.TabIndex = 7
        '
        'txtAsegurado
        '
        Me.txtAsegurado.Location = New System.Drawing.Point(416, 27)
        Me.txtAsegurado.Name = "txtAsegurado"
        Me.txtAsegurado.Size = New System.Drawing.Size(117, 20)
        Me.txtAsegurado.TabIndex = 6
        '
        'txtContratante
        '
        Me.txtContratante.Location = New System.Drawing.Point(286, 27)
        Me.txtContratante.Name = "txtContratante"
        Me.txtContratante.Size = New System.Drawing.Size(127, 20)
        Me.txtContratante.TabIndex = 5
        '
        'GridPolizas
        '
        Me.GridPolizas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPolizas.Location = New System.Drawing.Point(3, 53)
        Me.GridPolizas.MainView = Me.VistaPolizas
        Me.GridPolizas.Name = "GridPolizas"
        Me.GridPolizas.Size = New System.Drawing.Size(754, 230)
        Me.GridPolizas.TabIndex = 8
        Me.GridPolizas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaPolizas})
        '
        'VistaPolizas
        '
        Me.VistaPolizas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn3, Me.GridColumn6, Me.GridColumn1, Me.GridColumn2, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
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
        Me.GridColumn4.Caption = "Póliza"
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
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Certificado"
        Me.GridColumn3.FieldName = "Certificado"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 68
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Bien"
        Me.GridColumn6.FieldName = "IdBien"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 50
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nit Cliente"
        Me.GridColumn1.FieldName = "IdCliente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 90
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Contratante"
        Me.GridColumn2.FieldName = "Contratante"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 151
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Asegurado"
        Me.GridColumn7.FieldName = "Asegurado"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 151
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Beneficiario"
        Me.GridColumn8.FieldName = "Beneficiario"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 168
        '
        'txtCertificado
        '
        Me.txtCertificado.Location = New System.Drawing.Point(165, 27)
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.Size = New System.Drawing.Size(68, 20)
        Me.txtCertificado.TabIndex = 3
        '
        'cboPlan
        '
        Me.cboPlan.CampoAutoCompletar = 0
        Me.cboPlan.CampoBusqueda = False
        Me.cboPlan.CampoDisplay = 1
        Me.cboPlan.CampoEsLlave = False
        Me.cboPlan.CampoValor = 0
        Me.cboPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPlan.ControlBackColor = System.Drawing.Color.White
        Me.cboPlan.ControlForeColor = System.Drawing.Color.Black
        Me.cboPlan.FilasVisibles = 11
        Me.cboPlan.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboPlan.LabelText = "Plan Reclamos"
        Me.cboPlan.LabelWidth = 100
        Me.cboPlan.Lista = ""
        Me.cboPlan.Location = New System.Drawing.Point(19, 4)
        Me.cboPlan.MostrarBusquedaColumnas = False
        Me.cboPlan.Name = "cboPlan"
        Me.cboPlan.NombreCampo = ""
        Me.cboPlan.Obligatorio = False
        Me.cboPlan.Query = "select IdPlan as Id,  Descripcion  from SiniestroPlanes order by Descripcion"
        Me.cboPlan.SelectIndex = 0
        Me.cboPlan.Size = New System.Drawing.Size(562, 20)
        Me.cboPlan.SoloLectura = False
        Me.cboPlan.StringConection = ""
        Me.cboPlan.TabIndex = 0
        Me.cboPlan.TextoNuevoItem = ""
        Me.cboPlan.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboPlan.Valor = ""
        '
        'txtIdBien
        '
        Me.txtIdBien.Location = New System.Drawing.Point(235, 27)
        Me.txtIdBien.Name = "txtIdBien"
        Me.txtIdBien.Size = New System.Drawing.Size(49, 20)
        Me.txtIdBien.TabIndex = 4
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(666, 27)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(87, 20)
        Me.txtPlaca.TabIndex = 12
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Placa"
        Me.GridColumn9.FieldName = "Placa"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'BusquedaCertReclamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 324)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.txtIdBien)
        Me.Controls.Add(Me.cboPlan)
        Me.Controls.Add(Me.txtCertificado)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.txtAsegurado)
        Me.Controls.Add(Me.txtContratante)
        Me.Controls.Add(Me.GridPolizas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaCertReclamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Certificado y Asegurados"
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBeneficiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsegurado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContratante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCertificado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdBien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBeneficiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAsegurado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContratante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridPolizas As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaPolizas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCertificado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboPlan As STIControles.stiComboBox
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIdBien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
End Class
