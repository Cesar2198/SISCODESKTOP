<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolBuscarBienes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolBuscarBienes))
        Me.GridBienes = New STIControles.stiGrid
        Me.VistaBienes = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColPoliza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCertificado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDatoTec1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDatoTec2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDatoTec3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDatoTec4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColDatoTec5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboRamo = New STIControles.stiComboBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.cboDatosTec = New STIControles.stiComboBox
        Me.txtBusqueda = New STIControles.stiTextBox
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(596, 400)
        Me.btnAyuda.TabIndex = 6
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(493, 400)
        Me.btnImprimir.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(699, 400)
        Me.btnSalir.TabIndex = 7
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
        Me.LabelControl1.Size = New System.Drawing.Size(665, 74)
        Me.LabelControl1.Text = "Busqueda de Bienes Asegurados"
        '
        'GridBienes
        '
        Me.GridBienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridBienes.Location = New System.Drawing.Point(6, 152)
        Me.GridBienes.MainView = Me.VistaBienes
        Me.GridBienes.Name = "GridBienes"
        Me.GridBienes.NombreTabla = ""
        Me.GridBienes.Size = New System.Drawing.Size(791, 242)
        Me.GridBienes.TabIndex = 8
        Me.GridBienes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBienes})
        '
        'VistaBienes
        '
        Me.VistaBienes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColPoliza, Me.ColCertificado, Me.ColProducto, Me.ColCliente, Me.ColDatoTec1, Me.ColDatoTec2, Me.ColDatoTec3, Me.ColDatoTec4, Me.ColDatoTec5, Me.colIdProducto})
        Me.VistaBienes.GridControl = Me.GridBienes
        Me.VistaBienes.Name = "VistaBienes"
        Me.VistaBienes.OptionsBehavior.Editable = False
        Me.VistaBienes.OptionsView.ShowGroupPanel = False
        '
        'ColPoliza
        '
        Me.ColPoliza.Caption = "Póliza"
        Me.ColPoliza.FieldName = "Poliza"
        Me.ColPoliza.Name = "ColPoliza"
        Me.ColPoliza.Visible = True
        Me.ColPoliza.VisibleIndex = 0
        '
        'ColCertificado
        '
        Me.ColCertificado.Caption = "Certificado"
        Me.ColCertificado.FieldName = "Certificado"
        Me.ColCertificado.Name = "ColCertificado"
        Me.ColCertificado.Visible = True
        Me.ColCertificado.VisibleIndex = 1
        '
        'ColProducto
        '
        Me.ColProducto.Caption = "Producto"
        Me.ColProducto.FieldName = "Producto"
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.Visible = True
        Me.ColProducto.VisibleIndex = 3
        '
        'ColCliente
        '
        Me.ColCliente.Caption = "Asegurado"
        Me.ColCliente.FieldName = "Asegurado"
        Me.ColCliente.Name = "ColCliente"
        Me.ColCliente.Visible = True
        Me.ColCliente.VisibleIndex = 2
        '
        'ColDatoTec1
        '
        Me.ColDatoTec1.Caption = "Dato Técnico 1"
        Me.ColDatoTec1.FieldName = "DatoTec1"
        Me.ColDatoTec1.Name = "ColDatoTec1"
        Me.ColDatoTec1.Visible = True
        Me.ColDatoTec1.VisibleIndex = 4
        '
        'ColDatoTec2
        '
        Me.ColDatoTec2.Caption = "Dato Técnico 2"
        Me.ColDatoTec2.FieldName = "DatoTec2"
        Me.ColDatoTec2.Name = "ColDatoTec2"
        Me.ColDatoTec2.Visible = True
        Me.ColDatoTec2.VisibleIndex = 5
        '
        'ColDatoTec3
        '
        Me.ColDatoTec3.Caption = "Dato Técnico 3"
        Me.ColDatoTec3.FieldName = "DatoTec3"
        Me.ColDatoTec3.Name = "ColDatoTec3"
        Me.ColDatoTec3.Visible = True
        Me.ColDatoTec3.VisibleIndex = 6
        '
        'ColDatoTec4
        '
        Me.ColDatoTec4.Caption = "Dato Técnico 4"
        Me.ColDatoTec4.FieldName = "DatoTec4"
        Me.ColDatoTec4.Name = "ColDatoTec4"
        Me.ColDatoTec4.Visible = True
        Me.ColDatoTec4.VisibleIndex = 7
        '
        'ColDatoTec5
        '
        Me.ColDatoTec5.Caption = "Dato Técnico 5"
        Me.ColDatoTec5.FieldName = "DatoTec5"
        Me.ColDatoTec5.Name = "ColDatoTec5"
        Me.ColDatoTec5.Visible = True
        Me.ColDatoTec5.VisibleIndex = 8
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "IdProducto"
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        '
        'cboRamo
        '
        Me.cboRamo.CampoAutoCompletar = 0
        Me.cboRamo.CampoBusqueda = False
        Me.cboRamo.CampoDisplay = 1
        Me.cboRamo.CampoEsLlave = False
        Me.cboRamo.CampoValor = 0
        Me.cboRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboRamo.FilasVisibles = 7
        Me.cboRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRamo.LabelText = "Ramo"
        Me.cboRamo.LabelWidth = 100
        Me.cboRamo.Lista = ""
        Me.cboRamo.Location = New System.Drawing.Point(9, 80)
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NombreCampo = ""
        Me.cboRamo.Obligatorio = False
        Me.cboRamo.Query = "select IdRamo as Id, NombreRamo as Ramo  from RamoSeguros order by NombreRamo"
        Me.cboRamo.SelectIndex = -1
        Me.cboRamo.Size = New System.Drawing.Size(411, 20)
        Me.cboRamo.SoloLectura = False
        Me.cboRamo.StringConection = ""
        Me.cboRamo.TabIndex = 0
        Me.cboRamo.TextoNuevoItem = ""
        Me.cboRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRamo.Valor = ""
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 100
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(9, 103)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = False
        Me.cboProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(411, 20)
        Me.cboProducto.SoloLectura = False
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 1
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'cboDatosTec
        '
        Me.cboDatosTec.CampoAutoCompletar = 0
        Me.cboDatosTec.CampoBusqueda = False
        Me.cboDatosTec.CampoDisplay = 1
        Me.cboDatosTec.CampoEsLlave = False
        Me.cboDatosTec.CampoValor = 0
        Me.cboDatosTec.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDatosTec.ControlBackColor = System.Drawing.Color.White
        Me.cboDatosTec.ControlForeColor = System.Drawing.Color.Black
        Me.cboDatosTec.FilasVisibles = 7
        Me.cboDatosTec.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboDatosTec.LabelText = "Dato Busqueda"
        Me.cboDatosTec.LabelWidth = 100
        Me.cboDatosTec.Lista = ""
        Me.cboDatosTec.Location = New System.Drawing.Point(9, 126)
        Me.cboDatosTec.Name = "cboDatosTec"
        Me.cboDatosTec.NombreCampo = ""
        Me.cboDatosTec.Obligatorio = False
        Me.cboDatosTec.Query = ""
        Me.cboDatosTec.SelectIndex = -1
        Me.cboDatosTec.Size = New System.Drawing.Size(411, 20)
        Me.cboDatosTec.SoloLectura = False
        Me.cboDatosTec.StringConection = ""
        Me.cboDatosTec.TabIndex = 2
        Me.cboDatosTec.TextoNuevoItem = ""
        Me.cboDatosTec.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboDatosTec.Valor = ""
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CampoBusqueda = False
        Me.txtBusqueda.CampoEsLlave = False
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusqueda.ControlBackColor = System.Drawing.Color.White
        Me.txtBusqueda.ControlForeColor = System.Drawing.Color.Black
        Me.txtBusqueda.FechaActual = False
        Me.txtBusqueda.Formato = ""
        Me.txtBusqueda.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtBusqueda.LabelText = "Busqueda"
        Me.txtBusqueda.LabelWidth = 100
        Me.txtBusqueda.Location = New System.Drawing.Point(430, 80)
        Me.txtBusqueda.MaxLength = 0
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.NombreCampo = ""
        Me.txtBusqueda.Obligatorio = True
        Me.txtBusqueda.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusqueda.Size = New System.Drawing.Size(367, 20)
        Me.txtBusqueda.SoloLectura = False
        Me.txtBusqueda.TabIndex = 3
        Me.txtBusqueda.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtBusqueda.Valor = ""
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(681, 106)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(116, 40)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "&Buscar"
        '
        'PolBuscarBienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 500
        Me.ClientSize = New System.Drawing.Size(802, 438)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GridBienes)
        Me.Controls.Add(Me.cboRamo)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.cboDatosTec)
        Me.Controls.Add(Me.txtBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "PolBuscarBienes"
        Me.Text = "Busqueda..."
        Me.Controls.SetChildIndex(Me.txtBusqueda, 0)
        Me.Controls.SetChildIndex(Me.cboDatosTec, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.cboRamo, 0)
        Me.Controls.SetChildIndex(Me.GridBienes, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBienes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridBienes As STIControles.stiGrid
    Friend WithEvents VistaBienes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColPoliza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatoTec1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatoTec2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatoTec3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatoTec4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColDatoTec5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboRamo As STIControles.stiComboBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents cboDatosTec As STIControles.stiComboBox
    Friend WithEvents txtBusqueda As STIControles.stiTextBox
    Public WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn

End Class
