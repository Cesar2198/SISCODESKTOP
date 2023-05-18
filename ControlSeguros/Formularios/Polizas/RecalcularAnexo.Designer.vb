<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecalcularAnexo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecalcularAnexo))
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtNuevaHasta = New STIControles.stiTextBox
        Me.txtNuevaDesde = New STIControles.stiTextBox
        Me.txtHasta = New STIControles.stiTextBox
        Me.txtDesde = New STIControles.stiTextBox
        Me.txtCliente = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtPoliza = New STIControles.stiTextBox
        Me.cboFormaPago = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(403, 305)
        Me.btnAyuda.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(287, 305)
        Me.btnImprimir.Size = New System.Drawing.Size(116, 36)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "&Procesar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(506, 305)
        Me.btnSalir.TabIndex = 6
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
        Me.LabelControl1.Size = New System.Drawing.Size(472, 74)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Recalculo de Anexo a Pólizas"
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(329, 76)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarPoliza.TabIndex = 0
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
        '
        'txtNuevaHasta
        '
        Me.txtNuevaHasta.CampoBusqueda = False
        Me.txtNuevaHasta.CampoEsLlave = False
        Me.txtNuevaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNuevaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtNuevaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtNuevaHasta.FechaActual = False
        Me.txtNuevaHasta.Formato = "Long Date"
        Me.txtNuevaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNuevaHasta.LabelText = "Vigencia Hasta Anexo"
        Me.txtNuevaHasta.LabelWidth = 150
        Me.txtNuevaHasta.Location = New System.Drawing.Point(12, 262)
        Me.txtNuevaHasta.MaxLength = 0
        Me.txtNuevaHasta.Name = "txtNuevaHasta"
        Me.txtNuevaHasta.NombreCampo = ""
        Me.txtNuevaHasta.Obligatorio = True
        Me.txtNuevaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNuevaHasta.Size = New System.Drawing.Size(566, 20)
        Me.txtNuevaHasta.SoloLectura = False
        Me.txtNuevaHasta.TabIndex = 3
        Me.txtNuevaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtNuevaHasta.Valor = Nothing
        '
        'txtNuevaDesde
        '
        Me.txtNuevaDesde.CampoBusqueda = False
        Me.txtNuevaDesde.CampoEsLlave = False
        Me.txtNuevaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNuevaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtNuevaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtNuevaDesde.FechaActual = False
        Me.txtNuevaDesde.Formato = "Long Date"
        Me.txtNuevaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNuevaDesde.LabelText = "Vigencia Desde Anexo"
        Me.txtNuevaDesde.LabelWidth = 150
        Me.txtNuevaDesde.Location = New System.Drawing.Point(12, 236)
        Me.txtNuevaDesde.MaxLength = 0
        Me.txtNuevaDesde.Name = "txtNuevaDesde"
        Me.txtNuevaDesde.NombreCampo = ""
        Me.txtNuevaDesde.Obligatorio = True
        Me.txtNuevaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNuevaDesde.Size = New System.Drawing.Size(566, 20)
        Me.txtNuevaDesde.SoloLectura = False
        Me.txtNuevaDesde.TabIndex = 2
        Me.txtNuevaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtNuevaDesde.Valor = Nothing
        '
        'txtHasta
        '
        Me.txtHasta.CampoBusqueda = False
        Me.txtHasta.CampoEsLlave = False
        Me.txtHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHasta.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtHasta.FechaActual = False
        Me.txtHasta.Formato = "Long Date"
        Me.txtHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtHasta.LabelText = "Vigencia Hasta Actual"
        Me.txtHasta.LabelWidth = 150
        Me.txtHasta.Location = New System.Drawing.Point(12, 184)
        Me.txtHasta.MaxLength = 0
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreCampo = ""
        Me.txtHasta.Obligatorio = True
        Me.txtHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHasta.Size = New System.Drawing.Size(566, 20)
        Me.txtHasta.SoloLectura = True
        Me.txtHasta.TabIndex = 11
        Me.txtHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtHasta.Valor = Nothing
        '
        'txtDesde
        '
        Me.txtDesde.CampoBusqueda = False
        Me.txtDesde.CampoEsLlave = False
        Me.txtDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDesde.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtDesde.FechaActual = False
        Me.txtDesde.Formato = "Long Date"
        Me.txtDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDesde.LabelText = "Vigencia Desde Actual"
        Me.txtDesde.LabelWidth = 150
        Me.txtDesde.Location = New System.Drawing.Point(12, 158)
        Me.txtDesde.MaxLength = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreCampo = ""
        Me.txtDesde.Obligatorio = True
        Me.txtDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.Size = New System.Drawing.Size(566, 20)
        Me.txtDesde.SoloLectura = True
        Me.txtDesde.TabIndex = 10
        Me.txtDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtDesde.Valor = Nothing
        '
        'txtCliente
        '
        Me.txtCliente.CampoBusqueda = False
        Me.txtCliente.CampoEsLlave = False
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCliente.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtCliente.FechaActual = False
        Me.txtCliente.Formato = ""
        Me.txtCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCliente.LabelText = "Cliente"
        Me.txtCliente.LabelWidth = 150
        Me.txtCliente.Location = New System.Drawing.Point(12, 132)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = True
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(566, 20)
        Me.txtCliente.SoloLectura = True
        Me.txtCliente.TabIndex = 9
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 483
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 150
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(12, 106)
        Me.cboProducto.MostrarBusquedaColumnas = False
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = True
        Me.cboProducto.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = 0
        Me.cboProducto.Size = New System.Drawing.Size(566, 20)
        Me.cboProducto.SoloLectura = True
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 8
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'txtPoliza
        '
        Me.txtPoliza.CampoBusqueda = False
        Me.txtPoliza.CampoEsLlave = False
        Me.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPoliza.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtPoliza.FechaActual = False
        Me.txtPoliza.Formato = ""
        Me.txtPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPoliza.LabelText = "Número Póliza"
        Me.txtPoliza.LabelWidth = 150
        Me.txtPoliza.Location = New System.Drawing.Point(12, 80)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = True
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtPoliza.SoloLectura = True
        Me.txtPoliza.TabIndex = 7
        Me.txtPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtPoliza.Valor = ""
        '
        'cboFormaPago
        '
        Me.cboFormaPago.CampoAutoCompletar = 0
        Me.cboFormaPago.CampoBusqueda = False
        Me.cboFormaPago.CampoDisplay = 1
        Me.cboFormaPago.CampoEsLlave = False
        Me.cboFormaPago.CampoValor = 0
        Me.cboFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFormaPago.ControlBackColor = System.Drawing.Color.White
        Me.cboFormaPago.ControlForeColor = System.Drawing.Color.Black
        Me.cboFormaPago.FilasVisibles = 773
        Me.cboFormaPago.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboFormaPago.LabelText = "Forma de Pago"
        Me.cboFormaPago.LabelWidth = 150
        Me.cboFormaPago.Lista = ""
        Me.cboFormaPago.Location = New System.Drawing.Point(12, 210)
        Me.cboFormaPago.MostrarBusquedaColumnas = False
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.NombreCampo = ""
        Me.cboFormaPago.Obligatorio = True
        Me.cboFormaPago.Query = "select IdFormaPago as Id, Descripcion as FormaPago from FormasPago where idformap" & _
            "ago in ('13','14','15','1')"
        Me.cboFormaPago.SelectIndex = 0
        Me.cboFormaPago.Size = New System.Drawing.Size(566, 20)
        Me.cboFormaPago.SoloLectura = False
        Me.cboFormaPago.StringConection = ""
        Me.cboFormaPago.TabIndex = 1
        Me.cboFormaPago.TextoNuevoItem = ""
        Me.cboFormaPago.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboFormaPago.Valor = ""
        '
        'RecalcularAnexo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(609, 343)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.txtNuevaHasta)
        Me.Controls.Add(Me.txtNuevaDesde)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Name = "RecalcularAnexo"
        Me.Text = "Anexo de Cobro"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtDesde, 0)
        Me.Controls.SetChildIndex(Me.txtHasta, 0)
        Me.Controls.SetChildIndex(Me.txtNuevaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtNuevaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboFormaPago, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHasta As STIControles.stiTextBox
    Friend WithEvents txtDesde As STIControles.stiTextBox
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents txtNuevaHasta As STIControles.stiTextBox
    Friend WithEvents txtNuevaDesde As STIControles.stiTextBox
    Friend WithEvents cboFormaPago As STIControles.stiComboBox

End Class
