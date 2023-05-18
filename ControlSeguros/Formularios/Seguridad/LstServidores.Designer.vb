<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstServidores
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
        Me.GridServidores = New STIControles.stiGrid
        Me.VistaServidores = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnQutar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.txtUpdate = New STIControles.stiTextBox
        CType(Me.GridServidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaServidores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridServidores
        '
        Me.GridServidores.Location = New System.Drawing.Point(6, 4)
        Me.GridServidores.MainView = Me.VistaServidores
        Me.GridServidores.Name = "GridServidores"
        Me.GridServidores.NombreTabla = ""
        Me.GridServidores.Size = New System.Drawing.Size(322, 109)
        Me.GridServidores.TabIndex = 0
        Me.GridServidores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaServidores})
        '
        'VistaServidores
        '
        Me.VistaServidores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.VistaServidores.GridControl = Me.GridServidores
        Me.VistaServidores.Name = "VistaServidores"
        Me.VistaServidores.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre de Servidor"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'btnQutar
        '
        Me.btnQutar.Location = New System.Drawing.Point(330, 32)
        Me.btnQutar.Name = "btnQutar"
        Me.btnQutar.Size = New System.Drawing.Size(92, 23)
        Me.btnQutar.TabIndex = 21
        Me.btnQutar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(330, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 23)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(330, 61)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(330, 90)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(92, 23)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        '
        'txtUpdate
        '
        Me.txtUpdate.CampoBusqueda = False
        Me.txtUpdate.CampoEsLlave = False
        Me.txtUpdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUpdate.FechaActual = False
        Me.txtUpdate.Formato = ""
        Me.txtUpdate.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtUpdate.LabelText = "Ruta de Actualización"
        Me.txtUpdate.LabelWidth = 100
        Me.txtUpdate.Location = New System.Drawing.Point(8, 115)
        Me.txtUpdate.MaxLength = 0
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.NombreCampo = ""
        Me.txtUpdate.Obligatorio = False
        Me.txtUpdate.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUpdate.Size = New System.Drawing.Size(316, 36)
        Me.txtUpdate.SoloLectura = False
        Me.txtUpdate.TabIndex = 24
        Me.txtUpdate.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtUpdate.Valor = ""
        '
        'LstServidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 160)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnQutar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GridServidores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LstServidores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Servidores"
        CType(Me.GridServidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaServidores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridServidores As STIControles.stiGrid
    Friend WithEvents VistaServidores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnQutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUpdate As STIControles.stiTextBox
End Class
