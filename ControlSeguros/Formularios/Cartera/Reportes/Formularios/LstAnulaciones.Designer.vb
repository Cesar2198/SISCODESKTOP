<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LstAnulaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LstAnulaciones))
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtPoliza = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(315, 252)
        Me.btnAyuda.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(212, 252)
        Me.btnImprimir.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(418, 252)
        Me.btnSalir.TabIndex = 4
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
        Me.LabelControl1.Size = New System.Drawing.Size(384, 74)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Reporte de Anulación de Facturas/Créditos"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = False
        Me.txtFechaHasta.Formato = "Long Date"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(35, 116)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(357, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = False
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(35, 90)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(357, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(359, 187)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarCliente.TabIndex = 31
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(138, 220)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(0, 13)
        Me.lblCliente.TabIndex = 30
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cliente"
        Me.txtIdCliente.LabelWidth = 100
        Me.txtIdCliente.Location = New System.Drawing.Point(34, 194)
        Me.txtIdCliente.MaxLength = 0
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = ""
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(305, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 29
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtPoliza
        '
        Me.txtPoliza.CampoBusqueda = False
        Me.txtPoliza.CampoEsLlave = False
        Me.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPoliza.FechaActual = False
        Me.txtPoliza.Formato = ""
        Me.txtPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPoliza.LabelText = "Póliza"
        Me.txtPoliza.LabelWidth = 100
        Me.txtPoliza.Location = New System.Drawing.Point(34, 168)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = False
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(305, 20)
        Me.txtPoliza.SoloLectura = False
        Me.txtPoliza.TabIndex = 28
        Me.txtPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPoliza.Valor = ""
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
        Me.cboProducto.Location = New System.Drawing.Point(34, 142)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = False
        Me.cboProducto.Query = "select IdProducto as ID, Descripcion as Producto from Productos"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(432, 20)
        Me.cboProducto.SoloLectura = False
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 27
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'LstAnulaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 312
        Me.ClientSize = New System.Drawing.Size(521, 290)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Name = "LstAnulaciones"
        Me.Text = "Anulaciones"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.lblCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox

End Class
