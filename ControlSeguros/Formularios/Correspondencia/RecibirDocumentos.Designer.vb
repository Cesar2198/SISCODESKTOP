<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecibirDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecibirDocumentos))
        Me.cboFlujo = New STIControles.stiGridComboBox
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdCliente = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiMemo
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.txtFechaEnDocumento = New STIControles.stiTextBox
        Me.cboTipoDocumento = New STIControles.stiComboBox
        Me.txtCantidadDocumento = New STIControles.stiTextBox
        Me.chkDocSiniestro = New System.Windows.Forms.CheckBox
        Me.btnCheques = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(425, 350)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(322, 350)
        Me.btnImprimir.Text = "&Recibir"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(528, 350)
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
        Me.LabelControl1.Size = New System.Drawing.Size(500, 74)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Recepción de Documentos"
        '
        'cboFlujo
        '
        Me.cboFlujo.CampoAutoCompletar = 0
        Me.cboFlujo.CampoBusqueda = False
        Me.cboFlujo.CampoDisplay = 1
        Me.cboFlujo.CampoEsLlave = False
        Me.cboFlujo.CampoValor = 0
        Me.cboFlujo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboFlujo.ControlBackColor = System.Drawing.Color.White
        Me.cboFlujo.ControlForeColor = System.Drawing.Color.Black
        Me.cboFlujo.FilasVisibles = 29
        Me.cboFlujo.LabelOrietation = STIControles.stiGridComboBox.LOrientacion.Izquierda
        Me.cboFlujo.LabelText = "Flujo"
        Me.cboFlujo.LabelWidth = 140
        Me.cboFlujo.Lista = ""
        Me.cboFlujo.Location = New System.Drawing.Point(7, 219)
        Me.cboFlujo.Name = "cboFlujo"
        Me.cboFlujo.NombreCampo = ""
        Me.cboFlujo.Obligatorio = True
        Me.cboFlujo.Query = resources.GetString("cboFlujo.Query")
        Me.cboFlujo.SelectIndex = -2147483648
        Me.cboFlujo.Size = New System.Drawing.Size(621, 20)
        Me.cboFlujo.SoloLectura = False
        Me.cboFlujo.StringConection = ""
        Me.cboFlujo.TabIndex = 2
        Me.cboFlujo.TextoNuevoItem = "<Nuevo Flujo>"
        Me.cboFlujo.TipoDato = STIControles.stiGridComboBox.TipoContenido.Texto
        Me.cboFlujo.Valor = ""
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(355, 76)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarCliente.TabIndex = 0
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CampoBusqueda = False
        Me.txtIdCliente.CampoEsLlave = False
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCliente.FechaActual = False
        Me.txtIdCliente.Formato = ""
        Me.txtIdCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCliente.LabelText = "Cod. Cliente"
        Me.txtIdCliente.LabelWidth = 140
        Me.txtIdCliente.Location = New System.Drawing.Point(7, 80)
        Me.txtIdCliente.MaxLength = 25
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.NombreCampo = "IdCliente"
        Me.txtIdCliente.Obligatorio = False
        Me.txtIdCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.Size = New System.Drawing.Size(342, 20)
        Me.txtIdCliente.SoloLectura = True
        Me.txtIdCliente.TabIndex = 8
        Me.txtIdCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCliente.Valor = ""
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 140
        Me.txtNombreCliente.Location = New System.Drawing.Point(7, 106)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = False
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(623, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 9
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CampoBusqueda = False
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción del Documento"
        Me.txtDescripcion.LabelWidth = 140
        Me.txtDescripcion.Location = New System.Drawing.Point(7, 132)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = ""
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(623, 83)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'cboEjecutivoCta
        '
        Me.cboEjecutivoCta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEjecutivoCta.CampoAutoCompletar = 0
        Me.cboEjecutivoCta.CampoBusqueda = False
        Me.cboEjecutivoCta.CampoDisplay = 1
        Me.cboEjecutivoCta.CampoEsLlave = False
        Me.cboEjecutivoCta.CampoValor = 0
        Me.cboEjecutivoCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjecutivoCta.ControlBackColor = System.Drawing.Color.White
        Me.cboEjecutivoCta.ControlForeColor = System.Drawing.Color.Black
        Me.cboEjecutivoCta.FilasVisibles = 46
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Destinatario"
        Me.cboEjecutivoCta.LabelWidth = 140
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(7, 311)
        Me.cboEjecutivoCta.MostrarBusquedaColumnas = False
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = True
        Me.cboEjecutivoCta.Query = "select distinct cast(Departamento as varchar(50)) as Id, Departamento from Usuari" & _
            "os"
        Me.cboEjecutivoCta.SelectIndex = 0
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(621, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 6
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'txtFechaEnDocumento
        '
        Me.txtFechaEnDocumento.CampoBusqueda = True
        Me.txtFechaEnDocumento.CampoEsLlave = False
        Me.txtFechaEnDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaEnDocumento.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaEnDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaEnDocumento.FechaActual = True
        Me.txtFechaEnDocumento.Formato = "dd/MMM/yyyy"
        Me.txtFechaEnDocumento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaEnDocumento.LabelText = "Fecha en Documento"
        Me.txtFechaEnDocumento.LabelWidth = 140
        Me.txtFechaEnDocumento.Location = New System.Drawing.Point(7, 243)
        Me.txtFechaEnDocumento.MaxLength = 150
        Me.txtFechaEnDocumento.Name = "txtFechaEnDocumento"
        Me.txtFechaEnDocumento.NombreCampo = ""
        Me.txtFechaEnDocumento.Obligatorio = True
        Me.txtFechaEnDocumento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaEnDocumento.Size = New System.Drawing.Size(357, 20)
        Me.txtFechaEnDocumento.SoloLectura = False
        Me.txtFechaEnDocumento.TabIndex = 3
        Me.txtFechaEnDocumento.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaEnDocumento.Valor = Nothing
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumento.CampoAutoCompletar = 0
        Me.cboTipoDocumento.CampoBusqueda = False
        Me.cboTipoDocumento.CampoDisplay = 1
        Me.cboTipoDocumento.CampoEsLlave = False
        Me.cboTipoDocumento.CampoValor = 0
        Me.cboTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoDocumento.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.FilasVisibles = 46
        Me.cboTipoDocumento.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoDocumento.LabelText = "Tipo de Documento"
        Me.cboTipoDocumento.LabelWidth = 140
        Me.cboTipoDocumento.Lista = ""
        Me.cboTipoDocumento.Location = New System.Drawing.Point(7, 266)
        Me.cboTipoDocumento.MostrarBusquedaColumnas = True
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.NombreCampo = ""
        Me.cboTipoDocumento.Obligatorio = False
        Me.cboTipoDocumento.Query = ""
        Me.cboTipoDocumento.SelectIndex = 0
        Me.cboTipoDocumento.Size = New System.Drawing.Size(621, 20)
        Me.cboTipoDocumento.SoloLectura = False
        Me.cboTipoDocumento.StringConection = ""
        Me.cboTipoDocumento.TabIndex = 4
        Me.cboTipoDocumento.TextoNuevoItem = ""
        Me.cboTipoDocumento.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoDocumento.Valor = ""
        '
        'txtCantidadDocumento
        '
        Me.txtCantidadDocumento.CampoBusqueda = True
        Me.txtCantidadDocumento.CampoEsLlave = False
        Me.txtCantidadDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCantidadDocumento.ControlBackColor = System.Drawing.Color.White
        Me.txtCantidadDocumento.ControlForeColor = System.Drawing.Color.Black
        Me.txtCantidadDocumento.FechaActual = True
        Me.txtCantidadDocumento.Formato = "###"
        Me.txtCantidadDocumento.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCantidadDocumento.LabelText = "Número de Documentos"
        Me.txtCantidadDocumento.LabelWidth = 140
        Me.txtCantidadDocumento.Location = New System.Drawing.Point(7, 288)
        Me.txtCantidadDocumento.MaxLength = 150
        Me.txtCantidadDocumento.Name = "txtCantidadDocumento"
        Me.txtCantidadDocumento.NombreCampo = ""
        Me.txtCantidadDocumento.Obligatorio = False
        Me.txtCantidadDocumento.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidadDocumento.Size = New System.Drawing.Size(357, 20)
        Me.txtCantidadDocumento.SoloLectura = False
        Me.txtCantidadDocumento.TabIndex = 5
        Me.txtCantidadDocumento.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtCantidadDocumento.Valor = 0
        '
        'chkDocSiniestro
        '
        Me.chkDocSiniestro.AutoSize = True
        Me.chkDocSiniestro.Location = New System.Drawing.Point(492, 80)
        Me.chkDocSiniestro.Name = "chkDocSiniestro"
        Me.chkDocSiniestro.Size = New System.Drawing.Size(139, 17)
        Me.chkDocSiniestro.TabIndex = 34
        Me.chkDocSiniestro.Text = "Documento de Siniestro"
        Me.chkDocSiniestro.UseVisualStyleBackColor = True
        '
        'btnCheques
        '
        Me.btnCheques.Appearance.Options.UseTextOptions = True
        Me.btnCheques.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCheques.Image = CType(resources.GetObject("btnCheques.Image"), System.Drawing.Image)
        Me.btnCheques.Location = New System.Drawing.Point(7, 171)
        Me.btnCheques.Name = "btnCheques"
        Me.btnCheques.Size = New System.Drawing.Size(129, 42)
        Me.btnCheques.TabIndex = 35
        Me.btnCheques.Text = "Ingresar cheques de Liquidación"
        '
        'RecibirDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 913
        Me.ClientSize = New System.Drawing.Size(637, 391)
        Me.Controls.Add(Me.btnCheques)
        Me.Controls.Add(Me.chkDocSiniestro)
        Me.Controls.Add(Me.txtCantidadDocumento)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.txtFechaEnDocumento)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cboFlujo)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = True
        Me.Name = "RecibirDocumentos"
        Me.Text = "Documentos"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtIdCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.Controls.SetChildIndex(Me.cboFlujo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.txtFechaEnDocumento, 0)
        Me.Controls.SetChildIndex(Me.cboTipoDocumento, 0)
        Me.Controls.SetChildIndex(Me.txtCantidadDocumento, 0)
        Me.Controls.SetChildIndex(Me.chkDocSiniestro, 0)
        Me.Controls.SetChildIndex(Me.btnCheques, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboFlujo As STIControles.stiGridComboBox
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdCliente As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiMemo
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents txtFechaEnDocumento As STIControles.stiTextBox
    Friend WithEvents cboTipoDocumento As STIControles.stiComboBox
    Friend WithEvents txtCantidadDocumento As STIControles.stiTextBox
    Friend WithEvents chkDocSiniestro As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheques As DevExpress.XtraEditors.SimpleButton

End Class
