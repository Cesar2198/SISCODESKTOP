<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiniestrosAnulacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiniestrosAnulacion))
        Me.txtDescripcionSiniestro = New STIControles.stiTextBox
        Me.txtFechaPresentado = New STIControles.stiTextBox
        Me.txtFechaOcurrido = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdSiniestro = New STIControles.stiTextBox
        Me.txtIdCertificado = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.btnBuscaReclamo = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescripcionReserva = New STIControles.stiTextBox
        Me.cboEstadoSiniestro = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(329, 257)
        Me.btnAyuda.TabIndex = 9
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(226, 257)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "A&nular"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(432, 257)
        Me.btnSalir.TabIndex = 10
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
        Me.LabelControl1.Size = New System.Drawing.Size(398, 74)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Anulación de Siniestros"
        '
        'txtDescripcionSiniestro
        '
        Me.txtDescripcionSiniestro.CampoBusqueda = False
        Me.txtDescripcionSiniestro.CampoEsLlave = False
        Me.txtDescripcionSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionSiniestro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDescripcionSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionSiniestro.FechaActual = False
        Me.txtDescripcionSiniestro.Formato = ""
        Me.txtDescripcionSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionSiniestro.LabelText = "Descripción Siniestro"
        Me.txtDescripcionSiniestro.LabelWidth = 110
        Me.txtDescripcionSiniestro.Location = New System.Drawing.Point(12, 173)
        Me.txtDescripcionSiniestro.MaxLength = 0
        Me.txtDescripcionSiniestro.Name = "txtDescripcionSiniestro"
        Me.txtDescripcionSiniestro.NombreCampo = "DescripcionSiniestro"
        Me.txtDescripcionSiniestro.Obligatorio = False
        Me.txtDescripcionSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionSiniestro.Size = New System.Drawing.Size(504, 20)
        Me.txtDescripcionSiniestro.SoloLectura = True
        Me.txtDescripcionSiniestro.TabIndex = 8
        Me.txtDescripcionSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionSiniestro.Valor = ""
        '
        'txtFechaPresentado
        '
        Me.txtFechaPresentado.CampoBusqueda = True
        Me.txtFechaPresentado.CampoEsLlave = False
        Me.txtFechaPresentado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaPresentado.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaPresentado.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaPresentado.FechaActual = False
        Me.txtFechaPresentado.Formato = "dd/MMM/yyyy"
        Me.txtFechaPresentado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaPresentado.LabelText = "Fecha Presentado"
        Me.txtFechaPresentado.LabelWidth = 110
        Me.txtFechaPresentado.Location = New System.Drawing.Point(267, 150)
        Me.txtFechaPresentado.MaxLength = 0
        Me.txtFechaPresentado.Name = "txtFechaPresentado"
        Me.txtFechaPresentado.NombreCampo = "FechaPresentado"
        Me.txtFechaPresentado.Obligatorio = False
        Me.txtFechaPresentado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaPresentado.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaPresentado.SoloLectura = True
        Me.txtFechaPresentado.TabIndex = 7
        Me.txtFechaPresentado.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaPresentado.Valor = Nothing
        '
        'txtFechaOcurrido
        '
        Me.txtFechaOcurrido.CampoBusqueda = True
        Me.txtFechaOcurrido.CampoEsLlave = False
        Me.txtFechaOcurrido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaOcurrido.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaOcurrido.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaOcurrido.FechaActual = False
        Me.txtFechaOcurrido.Formato = "dd/MMM/yyyy"
        Me.txtFechaOcurrido.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaOcurrido.LabelText = "Fecha Ocurrido"
        Me.txtFechaOcurrido.LabelWidth = 110
        Me.txtFechaOcurrido.Location = New System.Drawing.Point(12, 150)
        Me.txtFechaOcurrido.MaxLength = 0
        Me.txtFechaOcurrido.Name = "txtFechaOcurrido"
        Me.txtFechaOcurrido.NombreCampo = "FechaOcurrido"
        Me.txtFechaOcurrido.Obligatorio = False
        Me.txtFechaOcurrido.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaOcurrido.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaOcurrido.SoloLectura = True
        Me.txtFechaOcurrido.TabIndex = 6
        Me.txtFechaOcurrido.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaOcurrido.Valor = Nothing
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 11
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 110
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 127)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(504, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 5
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdSiniestro
        '
        Me.txtIdSiniestro.CampoBusqueda = True
        Me.txtIdSiniestro.CampoEsLlave = True
        Me.txtIdSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdSiniestro.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdSiniestro.FechaActual = False
        Me.txtIdSiniestro.Formato = ""
        Me.txtIdSiniestro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdSiniestro.LabelText = "Núm. Reclamo"
        Me.txtIdSiniestro.LabelWidth = 110
        Me.txtIdSiniestro.Location = New System.Drawing.Point(12, 80)
        Me.txtIdSiniestro.MaxLength = 25
        Me.txtIdSiniestro.Name = "txtIdSiniestro"
        Me.txtIdSiniestro.NombreCampo = "IdSiniestro"
        Me.txtIdSiniestro.Obligatorio = False
        Me.txtIdSiniestro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdSiniestro.Size = New System.Drawing.Size(249, 20)
        Me.txtIdSiniestro.SoloLectura = True
        Me.txtIdSiniestro.TabIndex = 2
        Me.txtIdSiniestro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdSiniestro.Valor = ""
        '
        'txtIdCertificado
        '
        Me.txtIdCertificado.CampoBusqueda = True
        Me.txtIdCertificado.CampoEsLlave = True
        Me.txtIdCertificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCertificado.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCertificado.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCertificado.FechaActual = False
        Me.txtIdCertificado.Formato = ""
        Me.txtIdCertificado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCertificado.LabelText = "Certificado"
        Me.txtIdCertificado.LabelWidth = 110
        Me.txtIdCertificado.Location = New System.Drawing.Point(267, 103)
        Me.txtIdCertificado.MaxLength = 25
        Me.txtIdCertificado.Name = "txtIdCertificado"
        Me.txtIdCertificado.NombreCampo = "IdCertificado"
        Me.txtIdCertificado.Obligatorio = False
        Me.txtIdCertificado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCertificado.Size = New System.Drawing.Size(249, 20)
        Me.txtIdCertificado.SoloLectura = True
        Me.txtIdCertificado.TabIndex = 4
        Me.txtIdCertificado.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCertificado.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 110
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 103)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(249, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 3
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'btnBuscaReclamo
        '
        Me.btnBuscaReclamo.Image = CType(resources.GetObject("btnBuscaReclamo.Image"), System.Drawing.Image)
        Me.btnBuscaReclamo.Location = New System.Drawing.Point(267, 77)
        Me.btnBuscaReclamo.Name = "btnBuscaReclamo"
        Me.btnBuscaReclamo.Size = New System.Drawing.Size(126, 24)
        Me.btnBuscaReclamo.TabIndex = 0
        Me.btnBuscaReclamo.Text = "Buscar Reclamo"
        '
        'txtDescripcionReserva
        '
        Me.txtDescripcionReserva.CampoBusqueda = False
        Me.txtDescripcionReserva.CampoEsLlave = False
        Me.txtDescripcionReserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcionReserva.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcionReserva.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcionReserva.FechaActual = False
        Me.txtDescripcionReserva.Formato = ""
        Me.txtDescripcionReserva.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcionReserva.LabelText = "Motivo Anulación"
        Me.txtDescripcionReserva.LabelWidth = 110
        Me.txtDescripcionReserva.Location = New System.Drawing.Point(12, 199)
        Me.txtDescripcionReserva.MaxLength = 0
        Me.txtDescripcionReserva.Name = "txtDescripcionReserva"
        Me.txtDescripcionReserva.NombreCampo = "DescripcionReserva"
        Me.txtDescripcionReserva.Obligatorio = True
        Me.txtDescripcionReserva.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcionReserva.Size = New System.Drawing.Size(504, 20)
        Me.txtDescripcionReserva.SoloLectura = False
        Me.txtDescripcionReserva.TabIndex = 17
        Me.txtDescripcionReserva.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcionReserva.Valor = ""
        '
        'cboEstadoSiniestro
        '
        Me.cboEstadoSiniestro.CampoAutoCompletar = 0
        Me.cboEstadoSiniestro.CampoBusqueda = True
        Me.cboEstadoSiniestro.CampoDisplay = 1
        Me.cboEstadoSiniestro.CampoEsLlave = False
        Me.cboEstadoSiniestro.CampoValor = 0
        Me.cboEstadoSiniestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEstadoSiniestro.ControlBackColor = System.Drawing.Color.White
        Me.cboEstadoSiniestro.ControlForeColor = System.Drawing.Color.Black
        Me.cboEstadoSiniestro.FilasVisibles = 2281702
        Me.cboEstadoSiniestro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEstadoSiniestro.LabelText = "Estado Reclamo"
        Me.cboEstadoSiniestro.LabelWidth = 110
        Me.cboEstadoSiniestro.Lista = "RETIRADO Retiro del Reclamo|ANULADO Anulación del Reclamo"
        Me.cboEstadoSiniestro.Location = New System.Drawing.Point(12, 225)
        Me.cboEstadoSiniestro.MostrarBusquedaColumnas = False
        Me.cboEstadoSiniestro.Name = "cboEstadoSiniestro"
        Me.cboEstadoSiniestro.NombreCampo = "EstadoSiniestro"
        Me.cboEstadoSiniestro.Obligatorio = True
        Me.cboEstadoSiniestro.Query = ""
        Me.cboEstadoSiniestro.SelectIndex = 0
        Me.cboEstadoSiniestro.Size = New System.Drawing.Size(366, 20)
        Me.cboEstadoSiniestro.SoloLectura = False
        Me.cboEstadoSiniestro.StringConection = ""
        Me.cboEstadoSiniestro.TabIndex = 18
        Me.cboEstadoSiniestro.TextoNuevoItem = ""
        Me.cboEstadoSiniestro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEstadoSiniestro.Valor = ""
        '
        'SiniestrosAnulacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 801
        Me.ClientSize = New System.Drawing.Size(535, 295)
        Me.Controls.Add(Me.cboEstadoSiniestro)
        Me.Controls.Add(Me.txtDescripcionReserva)
        Me.Controls.Add(Me.btnBuscaReclamo)
        Me.Controls.Add(Me.txtDescripcionSiniestro)
        Me.Controls.Add(Me.txtFechaPresentado)
        Me.Controls.Add(Me.txtFechaOcurrido)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdSiniestro)
        Me.Controls.Add(Me.txtIdCertificado)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SiniestrosAnulacion"
        Me.Text = "Anulación de Siniestros"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtIdCertificado, 0)
        Me.Controls.SetChildIndex(Me.txtIdSiniestro, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtFechaOcurrido, 0)
        Me.Controls.SetChildIndex(Me.txtFechaPresentado, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionSiniestro, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaReclamo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcionReserva, 0)
        Me.Controls.SetChildIndex(Me.cboEstadoSiniestro, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescripcionSiniestro As STIControles.stiTextBox
    Friend WithEvents txtFechaPresentado As STIControles.stiTextBox
    Friend WithEvents txtFechaOcurrido As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdSiniestro As STIControles.stiTextBox
    Friend WithEvents txtIdCertificado As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents btnBuscaReclamo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcionReserva As STIControles.stiTextBox
    Friend WithEvents cboEstadoSiniestro As STIControles.stiComboBox

End Class
