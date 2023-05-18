<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendedoresMan
    Inherits stiFomularios.stiMantenimiento

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendedoresMan))
        Me.txtNombreVendedor = New STIControles.stiTextBox
        Me.txtIdVendedor = New STIControles.stiTextBox
        Me.txtDireccion = New STIControles.stiTextBox
        Me.txtTelefono = New STIControles.stiTextBox
        Me.txtFax = New STIControles.stiTextBox
        Me.txtEMail = New STIControles.stiTextBox
        Me.txtNit = New STIControles.stiTextBox
        Me.txtRegistroFiscal = New STIControles.stiTextBox
        Me.txtGiro = New STIControles.stiTextBox
        Me.txtCredencialSSF = New STIControles.stiTextBox
        Me.cboIdTipoVendedor = New STIControles.stiComboBox
        Me.cboIdEstado = New STIControles.stiComboBox
        Me.txtDUI = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(463, 412)
        Me.btnAyuda.TabIndex = 18
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(279, 412)
        Me.btnBuscar.TabIndex = 16
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(1, 412)
        Me.btnNuevo.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(93, 412)
        Me.btnGuardar.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(555, 412)
        Me.btnSalir.TabIndex = 19
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(371, 412)
        Me.btnEliminar.TabIndex = 17
        '
        'LabelControl1
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(510, 74)
        Me.lblNombreFormulario.TabIndex = 20
        Me.lblNombreFormulario.Text = "Registro de Vendedores de Seguros"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        '
        'btnGuardarComo
        '
        Me.btnGuardarComo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardarComo.Appearance.Options.UseFont = True
        Me.btnGuardarComo.Appearance.Options.UseTextOptions = True
        Me.btnGuardarComo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btnGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardarComo.Location = New System.Drawing.Point(186, 412)
        '
        'txtNombreVendedor
        '
        Me.txtNombreVendedor.CampoBusqueda = True
        Me.txtNombreVendedor.CampoEsLlave = False
        Me.txtNombreVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreVendedor.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreVendedor.FechaActual = False
        Me.txtNombreVendedor.Formato = ""
        Me.txtNombreVendedor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreVendedor.LabelText = "Nombre Vendedor"
        Me.txtNombreVendedor.LabelWidth = 125
        Me.txtNombreVendedor.Location = New System.Drawing.Point(12, 107)
        Me.txtNombreVendedor.MaxLength = 150
        Me.txtNombreVendedor.Name = "txtNombreVendedor"
        Me.txtNombreVendedor.NombreCampo = "NombreVendedor"
        Me.txtNombreVendedor.Obligatorio = True
        Me.txtNombreVendedor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreVendedor.Size = New System.Drawing.Size(625, 20)
        Me.txtNombreVendedor.SoloLectura = False
        Me.txtNombreVendedor.TabIndex = 1
        Me.txtNombreVendedor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreVendedor.Valor = ""
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.CampoBusqueda = True
        Me.txtIdVendedor.CampoEsLlave = True
        Me.txtIdVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdVendedor.ControlBackColor = System.Drawing.Color.White
        Me.txtIdVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdVendedor.FechaActual = False
        Me.txtIdVendedor.Formato = ""
        Me.txtIdVendedor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdVendedor.LabelText = "Cod. Vendedor"
        Me.txtIdVendedor.LabelWidth = 125
        Me.txtIdVendedor.Location = New System.Drawing.Point(12, 81)
        Me.txtIdVendedor.MaxLength = 25
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.NombreCampo = "IdVendedor"
        Me.txtIdVendedor.Obligatorio = True
        Me.txtIdVendedor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdVendedor.Size = New System.Drawing.Size(300, 20)
        Me.txtIdVendedor.SoloLectura = False
        Me.txtIdVendedor.TabIndex = 0
        Me.txtIdVendedor.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdVendedor.Valor = ""
        '
        'txtDireccion
        '
        Me.txtDireccion.CampoBusqueda = False
        Me.txtDireccion.CampoEsLlave = False
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDireccion.ControlBackColor = System.Drawing.Color.White
        Me.txtDireccion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDireccion.FechaActual = False
        Me.txtDireccion.Formato = ""
        Me.txtDireccion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDireccion.LabelText = "Dirección"
        Me.txtDireccion.LabelWidth = 125
        Me.txtDireccion.Location = New System.Drawing.Point(12, 159)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NombreCampo = "Direccion"
        Me.txtDireccion.Obligatorio = False
        Me.txtDireccion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.Size = New System.Drawing.Size(625, 20)
        Me.txtDireccion.SoloLectura = False
        Me.txtDireccion.TabIndex = 3
        Me.txtDireccion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDireccion.Valor = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.CampoBusqueda = False
        Me.txtTelefono.CampoEsLlave = False
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTelefono.ControlBackColor = System.Drawing.Color.White
        Me.txtTelefono.ControlForeColor = System.Drawing.Color.Black
        Me.txtTelefono.FechaActual = False
        Me.txtTelefono.Formato = ""
        Me.txtTelefono.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtTelefono.LabelText = "Teléfono"
        Me.txtTelefono.LabelWidth = 125
        Me.txtTelefono.Location = New System.Drawing.Point(12, 369)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NombreCampo = "Telefono"
        Me.txtTelefono.Obligatorio = False
        Me.txtTelefono.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(286, 36)
        Me.txtTelefono.SoloLectura = False
        Me.txtTelefono.TabIndex = 11
        Me.txtTelefono.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtTelefono.Valor = ""
        '
        'txtFax
        '
        Me.txtFax.CampoBusqueda = False
        Me.txtFax.CampoEsLlave = False
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFax.ControlBackColor = System.Drawing.Color.White
        Me.txtFax.ControlForeColor = System.Drawing.Color.Black
        Me.txtFax.FechaActual = False
        Me.txtFax.Formato = ""
        Me.txtFax.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtFax.LabelText = "Fax"
        Me.txtFax.LabelWidth = 125
        Me.txtFax.Location = New System.Drawing.Point(348, 368)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.NombreCampo = "Fax"
        Me.txtFax.Obligatorio = False
        Me.txtFax.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.Size = New System.Drawing.Size(286, 36)
        Me.txtFax.SoloLectura = False
        Me.txtFax.TabIndex = 12
        Me.txtFax.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtFax.Valor = ""
        '
        'txtEMail
        '
        Me.txtEMail.CampoBusqueda = False
        Me.txtEMail.CampoEsLlave = False
        Me.txtEMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEMail.ControlBackColor = System.Drawing.Color.White
        Me.txtEMail.ControlForeColor = System.Drawing.Color.Black
        Me.txtEMail.FechaActual = False
        Me.txtEMail.Formato = ""
        Me.txtEMail.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEMail.LabelText = "Correo Electrónico"
        Me.txtEMail.LabelWidth = 125
        Me.txtEMail.Location = New System.Drawing.Point(12, 185)
        Me.txtEMail.MaxLength = 50
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.NombreCampo = "EMail"
        Me.txtEMail.Obligatorio = False
        Me.txtEMail.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEMail.Size = New System.Drawing.Size(625, 20)
        Me.txtEMail.SoloLectura = False
        Me.txtEMail.TabIndex = 4
        Me.txtEMail.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtEMail.Valor = ""
        '
        'txtNit
        '
        Me.txtNit.CampoBusqueda = False
        Me.txtNit.CampoEsLlave = False
        Me.txtNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNit.ControlBackColor = System.Drawing.Color.White
        Me.txtNit.ControlForeColor = System.Drawing.Color.Black
        Me.txtNit.FechaActual = False
        Me.txtNit.Formato = ""
        Me.txtNit.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtNit.LabelText = "NIT"
        Me.txtNit.LabelWidth = 125
        Me.txtNit.Location = New System.Drawing.Point(12, 287)
        Me.txtNit.MaxLength = 25
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NombreCampo = "Nit"
        Me.txtNit.Obligatorio = False
        Me.txtNit.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNit.Size = New System.Drawing.Size(286, 36)
        Me.txtNit.SoloLectura = False
        Me.txtNit.TabIndex = 8
        Me.txtNit.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNit.Valor = ""
        '
        'txtRegistroFiscal
        '
        Me.txtRegistroFiscal.CampoBusqueda = False
        Me.txtRegistroFiscal.CampoEsLlave = False
        Me.txtRegistroFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRegistroFiscal.ControlBackColor = System.Drawing.Color.White
        Me.txtRegistroFiscal.ControlForeColor = System.Drawing.Color.Black
        Me.txtRegistroFiscal.FechaActual = False
        Me.txtRegistroFiscal.Formato = ""
        Me.txtRegistroFiscal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtRegistroFiscal.LabelText = "Registro Fiscal"
        Me.txtRegistroFiscal.LabelWidth = 125
        Me.txtRegistroFiscal.Location = New System.Drawing.Point(348, 287)
        Me.txtRegistroFiscal.MaxLength = 25
        Me.txtRegistroFiscal.Name = "txtRegistroFiscal"
        Me.txtRegistroFiscal.NombreCampo = "RegistroFiscal"
        Me.txtRegistroFiscal.Obligatorio = False
        Me.txtRegistroFiscal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegistroFiscal.Size = New System.Drawing.Size(286, 36)
        Me.txtRegistroFiscal.SoloLectura = False
        Me.txtRegistroFiscal.TabIndex = 9
        Me.txtRegistroFiscal.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRegistroFiscal.Valor = ""
        '
        'txtGiro
        '
        Me.txtGiro.CampoBusqueda = False
        Me.txtGiro.CampoEsLlave = False
        Me.txtGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGiro.ControlBackColor = System.Drawing.Color.White
        Me.txtGiro.ControlForeColor = System.Drawing.Color.Black
        Me.txtGiro.FechaActual = False
        Me.txtGiro.Formato = ""
        Me.txtGiro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtGiro.LabelText = "Giro"
        Me.txtGiro.LabelWidth = 125
        Me.txtGiro.Location = New System.Drawing.Point(12, 211)
        Me.txtGiro.MaxLength = 150
        Me.txtGiro.Name = "txtGiro"
        Me.txtGiro.NombreCampo = "Giro"
        Me.txtGiro.Obligatorio = False
        Me.txtGiro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGiro.Size = New System.Drawing.Size(625, 20)
        Me.txtGiro.SoloLectura = False
        Me.txtGiro.TabIndex = 5
        Me.txtGiro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtGiro.Valor = ""
        '
        'txtCredencialSSF
        '
        Me.txtCredencialSSF.CampoBusqueda = True
        Me.txtCredencialSSF.CampoEsLlave = False
        Me.txtCredencialSSF.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCredencialSSF.ControlBackColor = System.Drawing.Color.White
        Me.txtCredencialSSF.ControlForeColor = System.Drawing.Color.Black
        Me.txtCredencialSSF.FechaActual = False
        Me.txtCredencialSSF.Formato = ""
        Me.txtCredencialSSF.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCredencialSSF.LabelText = "Credencial SSF"
        Me.txtCredencialSSF.LabelWidth = 125
        Me.txtCredencialSSF.Location = New System.Drawing.Point(12, 133)
        Me.txtCredencialSSF.MaxLength = 25
        Me.txtCredencialSSF.Name = "txtCredencialSSF"
        Me.txtCredencialSSF.NombreCampo = "CredencialSSF"
        Me.txtCredencialSSF.Obligatorio = False
        Me.txtCredencialSSF.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCredencialSSF.Size = New System.Drawing.Size(625, 20)
        Me.txtCredencialSSF.SoloLectura = False
        Me.txtCredencialSSF.TabIndex = 2
        Me.txtCredencialSSF.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCredencialSSF.Valor = ""
        '
        'cboIdTipoVendedor
        '
        Me.cboIdTipoVendedor.CampoAutoCompletar = 1
        Me.cboIdTipoVendedor.CampoBusqueda = False
        Me.cboIdTipoVendedor.CampoDisplay = 1
        Me.cboIdTipoVendedor.CampoEsLlave = False
        Me.cboIdTipoVendedor.CampoValor = 0
        Me.cboIdTipoVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdTipoVendedor.ControlBackColor = System.Drawing.Color.White
        Me.cboIdTipoVendedor.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdTipoVendedor.FilasVisibles = 7
        Me.cboIdTipoVendedor.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdTipoVendedor.LabelText = "Tipo Vendedor"
        Me.cboIdTipoVendedor.LabelWidth = 125
        Me.cboIdTipoVendedor.Lista = ""
        Me.cboIdTipoVendedor.Location = New System.Drawing.Point(12, 237)
        Me.cboIdTipoVendedor.Name = "cboIdTipoVendedor"
        Me.cboIdTipoVendedor.NombreCampo = "IdTipoVendedor"
        Me.cboIdTipoVendedor.Obligatorio = True
        Me.cboIdTipoVendedor.Query = "select IdTipoVendedor, NombreTipoVendedor from TipoVendedor order by IdTipoVended" & _
            "or"
        Me.cboIdTipoVendedor.SelectIndex = -1
        Me.cboIdTipoVendedor.Size = New System.Drawing.Size(625, 20)
        Me.cboIdTipoVendedor.SoloLectura = False
        Me.cboIdTipoVendedor.StringConection = ""
        Me.cboIdTipoVendedor.TabIndex = 6
        Me.cboIdTipoVendedor.TextoNuevoItem = "<< Nuevo Tipo >>"
        Me.cboIdTipoVendedor.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdTipoVendedor.Valor = ""
        '
        'cboIdEstado
        '
        Me.cboIdEstado.CampoAutoCompletar = 1
        Me.cboIdEstado.CampoBusqueda = False
        Me.cboIdEstado.CampoDisplay = 1
        Me.cboIdEstado.CampoEsLlave = False
        Me.cboIdEstado.CampoValor = 0
        Me.cboIdEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdEstado.ControlBackColor = System.Drawing.Color.White
        Me.cboIdEstado.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdEstado.FilasVisibles = 7
        Me.cboIdEstado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdEstado.LabelText = "Estado Vendedor"
        Me.cboIdEstado.LabelWidth = 125
        Me.cboIdEstado.Lista = ""
        Me.cboIdEstado.Location = New System.Drawing.Point(12, 263)
        Me.cboIdEstado.Name = "cboIdEstado"
        Me.cboIdEstado.NombreCampo = "IdEstado"
        Me.cboIdEstado.Obligatorio = True
        Me.cboIdEstado.Query = "select IdEstado, Descripcion from EstadosPersonas order by IdEstado"
        Me.cboIdEstado.SelectIndex = -1
        Me.cboIdEstado.Size = New System.Drawing.Size(625, 20)
        Me.cboIdEstado.SoloLectura = False
        Me.cboIdEstado.StringConection = ""
        Me.cboIdEstado.TabIndex = 7
        Me.cboIdEstado.TextoNuevoItem = "<< Nuevo Estado >>"
        Me.cboIdEstado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdEstado.Valor = ""
        '
        'txtDUI
        '
        Me.txtDUI.CampoBusqueda = False
        Me.txtDUI.CampoEsLlave = False
        Me.txtDUI.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDUI.ControlBackColor = System.Drawing.Color.White
        Me.txtDUI.ControlForeColor = System.Drawing.Color.Black
        Me.txtDUI.FechaActual = False
        Me.txtDUI.Formato = ""
        Me.txtDUI.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.txtDUI.LabelText = "DUI"
        Me.txtDUI.LabelWidth = 125
        Me.txtDUI.Location = New System.Drawing.Point(12, 327)
        Me.txtDUI.MaxLength = 25
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.NombreCampo = "DUI"
        Me.txtDUI.Obligatorio = False
        Me.txtDUI.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDUI.Size = New System.Drawing.Size(286, 36)
        Me.txtDUI.SoloLectura = False
        Me.txtDUI.TabIndex = 10
        Me.txtDUI.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDUI.Valor = ""
        '
        'VendedoresMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 211
        Me.ClientSize = New System.Drawing.Size(649, 448)
        Me.Controls.Add(Me.txtDUI)
        Me.Controls.Add(Me.cboIdEstado)
        Me.Controls.Add(Me.cboIdTipoVendedor)
        Me.Controls.Add(Me.txtCredencialSSF)
        Me.Controls.Add(Me.txtGiro)
        Me.Controls.Add(Me.txtRegistroFiscal)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombreVendedor)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Name = "VendedoresMan"
        Me.Text = "Vendedores de Seguros"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdVendedor, 0)
        Me.Controls.SetChildIndex(Me.txtNombreVendedor, 0)
        Me.Controls.SetChildIndex(Me.txtDireccion, 0)
        Me.Controls.SetChildIndex(Me.txtTelefono, 0)
        Me.Controls.SetChildIndex(Me.txtFax, 0)
        Me.Controls.SetChildIndex(Me.txtEMail, 0)
        Me.Controls.SetChildIndex(Me.txtNit, 0)
        Me.Controls.SetChildIndex(Me.txtRegistroFiscal, 0)
        Me.Controls.SetChildIndex(Me.txtGiro, 0)
        Me.Controls.SetChildIndex(Me.txtCredencialSSF, 0)
        Me.Controls.SetChildIndex(Me.cboIdTipoVendedor, 0)
        Me.Controls.SetChildIndex(Me.cboIdEstado, 0)
        Me.Controls.SetChildIndex(Me.txtDUI, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombreVendedor As STIControles.stiTextBox
    Friend WithEvents txtIdVendedor As STIControles.stiTextBox
    Friend WithEvents txtDireccion As STIControles.stiTextBox
    Friend WithEvents txtTelefono As STIControles.stiTextBox
    Friend WithEvents txtFax As STIControles.stiTextBox
    Friend WithEvents txtEMail As STIControles.stiTextBox
    Friend WithEvents txtNit As STIControles.stiTextBox
    Friend WithEvents txtRegistroFiscal As STIControles.stiTextBox
    Friend WithEvents txtGiro As STIControles.stiTextBox
    Friend WithEvents txtCredencialSSF As STIControles.stiTextBox
    Friend WithEvents cboIdTipoVendedor As STIControles.stiComboBox
    Friend WithEvents cboIdEstado As STIControles.stiComboBox
    Friend WithEvents txtDUI As STIControles.stiTextBox

End Class
