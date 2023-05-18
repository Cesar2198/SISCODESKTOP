<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarDeducibles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarDeducibles))
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtPoliza = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtCliente = New STIControles.stiTextBox
        Me.txtVigenciaDesde = New STIControles.stiTextBox
        Me.txtVigenciaHasta = New STIControles.stiTextBox
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.txtEstado = New STIControles.stiTextBox
        Me.txtCertificados = New STIControles.stiTextBox
        Me.txtDeducible = New STIControles.stiTextBox
        Me.txtParticipacion = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(377, 305)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(221, 305)
        Me.btnImprimir.Size = New System.Drawing.Size(156, 36)
        Me.btnImprimir.Text = "&Actualizar Datos"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(480, 305)
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
        Me.LabelControl1.Size = New System.Drawing.Size(446, 74)
        Me.LabelControl1.Text = "Actualizar Deducibles de la Póliza"
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(319, 78)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarPoliza.TabIndex = 18
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
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
        Me.txtPoliza.LabelWidth = 125
        Me.txtPoliza.Location = New System.Drawing.Point(4, 84)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = True
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtPoliza.SoloLectura = True
        Me.txtPoliza.TabIndex = 19
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
        Me.cboProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 125
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(4, 107)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = True
        Me.cboProducto.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(566, 20)
        Me.cboProducto.SoloLectura = True
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 20
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
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
        Me.txtCliente.LabelWidth = 125
        Me.txtCliente.Location = New System.Drawing.Point(4, 153)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = True
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(566, 20)
        Me.txtCliente.SoloLectura = True
        Me.txtCliente.TabIndex = 21
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'txtVigenciaDesde
        '
        Me.txtVigenciaDesde.CampoBusqueda = False
        Me.txtVigenciaDesde.CampoEsLlave = False
        Me.txtVigenciaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaDesde.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtVigenciaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaDesde.FechaActual = False
        Me.txtVigenciaDesde.Formato = "Long Date"
        Me.txtVigenciaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaDesde.LabelText = "Vigencia Desde"
        Me.txtVigenciaDesde.LabelWidth = 125
        Me.txtVigenciaDesde.Location = New System.Drawing.Point(4, 176)
        Me.txtVigenciaDesde.MaxLength = 0
        Me.txtVigenciaDesde.Name = "txtVigenciaDesde"
        Me.txtVigenciaDesde.NombreCampo = ""
        Me.txtVigenciaDesde.Obligatorio = True
        Me.txtVigenciaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaDesde.Size = New System.Drawing.Size(422, 20)
        Me.txtVigenciaDesde.SoloLectura = True
        Me.txtVigenciaDesde.TabIndex = 22
        Me.txtVigenciaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaDesde.Valor = Nothing
        '
        'txtVigenciaHasta
        '
        Me.txtVigenciaHasta.CampoBusqueda = False
        Me.txtVigenciaHasta.CampoEsLlave = False
        Me.txtVigenciaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVigenciaHasta.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtVigenciaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtVigenciaHasta.FechaActual = False
        Me.txtVigenciaHasta.Formato = "Long Date"
        Me.txtVigenciaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtVigenciaHasta.LabelText = "Vigencia Hasta"
        Me.txtVigenciaHasta.LabelWidth = 125
        Me.txtVigenciaHasta.Location = New System.Drawing.Point(4, 199)
        Me.txtVigenciaHasta.MaxLength = 0
        Me.txtVigenciaHasta.Name = "txtVigenciaHasta"
        Me.txtVigenciaHasta.NombreCampo = ""
        Me.txtVigenciaHasta.Obligatorio = True
        Me.txtVigenciaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVigenciaHasta.Size = New System.Drawing.Size(422, 20)
        Me.txtVigenciaHasta.SoloLectura = True
        Me.txtVigenciaHasta.TabIndex = 23
        Me.txtVigenciaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtVigenciaHasta.Valor = Nothing
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = False
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = False
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 7
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 125
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(4, 130)
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = ""
        Me.cboAseguradora.Obligatorio = True
        Me.cboAseguradora.Query = "select idaseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nomb" & _
            "re"
        Me.cboAseguradora.SelectIndex = -1
        Me.cboAseguradora.Size = New System.Drawing.Size(566, 20)
        Me.cboAseguradora.SoloLectura = True
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 24
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'txtEstado
        '
        Me.txtEstado.CampoBusqueda = False
        Me.txtEstado.CampoEsLlave = False
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEstado.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtEstado.ControlForeColor = System.Drawing.Color.Black
        Me.txtEstado.FechaActual = False
        Me.txtEstado.Formato = ""
        Me.txtEstado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEstado.LabelText = "Estado"
        Me.txtEstado.LabelWidth = 125
        Me.txtEstado.Location = New System.Drawing.Point(4, 223)
        Me.txtEstado.MaxLength = 0
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.NombreCampo = ""
        Me.txtEstado.Obligatorio = True
        Me.txtEstado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstado.Size = New System.Drawing.Size(300, 20)
        Me.txtEstado.SoloLectura = True
        Me.txtEstado.TabIndex = 25
        Me.txtEstado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEstado.Valor = ""
        '
        'txtCertificados
        '
        Me.txtCertificados.CampoBusqueda = False
        Me.txtCertificados.CampoEsLlave = False
        Me.txtCertificados.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCertificados.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCertificados.ControlForeColor = System.Drawing.Color.Black
        Me.txtCertificados.FechaActual = False
        Me.txtCertificados.Formato = "#0"
        Me.txtCertificados.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCertificados.LabelText = "# Certificados"
        Me.txtCertificados.LabelWidth = 100
        Me.txtCertificados.Location = New System.Drawing.Point(320, 223)
        Me.txtCertificados.MaxLength = 0
        Me.txtCertificados.Name = "txtCertificados"
        Me.txtCertificados.NombreCampo = ""
        Me.txtCertificados.Obligatorio = True
        Me.txtCertificados.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCertificados.Size = New System.Drawing.Size(250, 20)
        Me.txtCertificados.SoloLectura = True
        Me.txtCertificados.TabIndex = 26
        Me.txtCertificados.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtCertificados.Valor = 0
        '
        'txtDeducible
        '
        Me.txtDeducible.CampoBusqueda = False
        Me.txtDeducible.CampoEsLlave = False
        Me.txtDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDeducible.ControlBackColor = System.Drawing.Color.White
        Me.txtDeducible.ControlForeColor = System.Drawing.Color.Black
        Me.txtDeducible.FechaActual = False
        Me.txtDeducible.Formato = ""
        Me.txtDeducible.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDeducible.LabelText = "Deducible"
        Me.txtDeducible.LabelWidth = 125
        Me.txtDeducible.Location = New System.Drawing.Point(4, 247)
        Me.txtDeducible.MaxLength = 0
        Me.txtDeducible.Name = "txtDeducible"
        Me.txtDeducible.NombreCampo = ""
        Me.txtDeducible.Obligatorio = True
        Me.txtDeducible.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeducible.Size = New System.Drawing.Size(422, 20)
        Me.txtDeducible.SoloLectura = False
        Me.txtDeducible.TabIndex = 27
        Me.txtDeducible.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDeducible.Valor = ""
        '
        'txtParticipacion
        '
        Me.txtParticipacion.CampoBusqueda = False
        Me.txtParticipacion.CampoEsLlave = False
        Me.txtParticipacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtParticipacion.ControlBackColor = System.Drawing.Color.White
        Me.txtParticipacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtParticipacion.FechaActual = False
        Me.txtParticipacion.Formato = ""
        Me.txtParticipacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtParticipacion.LabelText = "Participación"
        Me.txtParticipacion.LabelWidth = 125
        Me.txtParticipacion.Location = New System.Drawing.Point(4, 271)
        Me.txtParticipacion.MaxLength = 0
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.NombreCampo = ""
        Me.txtParticipacion.Obligatorio = True
        Me.txtParticipacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParticipacion.Size = New System.Drawing.Size(422, 20)
        Me.txtParticipacion.SoloLectura = False
        Me.txtParticipacion.TabIndex = 28
        Me.txtParticipacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtParticipacion.Valor = ""
        '
        'ActualizarDeducibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(583, 343)
        Me.Controls.Add(Me.txtParticipacion)
        Me.Controls.Add(Me.txtDeducible)
        Me.Controls.Add(Me.txtCertificados)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Controls.Add(Me.txtVigenciaHasta)
        Me.Controls.Add(Me.txtVigenciaDesde)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ActualizarDeducibles"
        Me.Text = "Actualizar Deducibles"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtVigenciaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.txtEstado, 0)
        Me.Controls.SetChildIndex(Me.txtCertificados, 0)
        Me.Controls.SetChildIndex(Me.txtDeducible, 0)
        Me.Controls.SetChildIndex(Me.txtParticipacion, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents txtVigenciaDesde As STIControles.stiTextBox
    Friend WithEvents txtVigenciaHasta As STIControles.stiTextBox
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Friend WithEvents txtEstado As STIControles.stiTextBox
    Friend WithEvents txtCertificados As STIControles.stiTextBox
    Friend WithEvents txtDeducible As STIControles.stiTextBox
    Friend WithEvents txtParticipacion As STIControles.stiTextBox

End Class
