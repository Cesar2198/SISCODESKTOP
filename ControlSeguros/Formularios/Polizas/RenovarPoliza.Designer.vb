<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenovarPoliza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenovarPoliza))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtPoliza = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtCliente = New STIControles.stiTextBox
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtDesde = New STIControles.stiTextBox
        Me.txtHasta = New STIControles.stiTextBox
        Me.txtNuevaHasta = New STIControles.stiTextBox
        Me.txtNuevaDesde = New STIControles.stiTextBox
        Me.cboTipoPoliza = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(433, 403)
        Me.btnAyuda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(157, 429)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(-28, 429)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(289, 403)
        Me.btnGuardar.Size = New System.Drawing.Size(144, 36)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Renovar Póliza"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(525, 403)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(173, 429)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.Visible = False
        '
        'lblNombreFormulario
        '
        Me.lblNombreFormulario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreFormulario.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreFormulario.Appearance.Options.UseFont = True
        Me.lblNombreFormulario.Appearance.Options.UseForeColor = True
        Me.lblNombreFormulario.Appearance.Options.UseTextOptions = True
        Me.lblNombreFormulario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNombreFormulario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNombreFormulario.Size = New System.Drawing.Size(480, 74)
        Me.lblNombreFormulario.Text = "Proceso Renovación de Pólizas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(65, 429)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LabelControl2.Location = New System.Drawing.Point(39, 90)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(530, 48)
        Me.LabelControl2.TabIndex = 30
        Me.LabelControl2.Text = "Este programa permite renovar una póliza por un período más, con los certificados" & _
            " que se encuentren vigentes. NOTA: se deben revisar las primas de acuerdo a los " & _
            "documentos enviado por la Aseguradora."
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
        Me.txtPoliza.Location = New System.Drawing.Point(14, 157)
        Me.txtPoliza.MaxLength = 0
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.NombreCampo = ""
        Me.txtPoliza.Obligatorio = True
        Me.txtPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtPoliza.SoloLectura = True
        Me.txtPoliza.TabIndex = 31
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
        Me.cboProducto.FilasVisibles = 11
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 150
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(14, 183)
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
        Me.cboProducto.TabIndex = 32
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
        Me.txtCliente.LabelWidth = 150
        Me.txtCliente.Location = New System.Drawing.Point(14, 209)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.NombreCampo = ""
        Me.txtCliente.Obligatorio = True
        Me.txtCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.Size = New System.Drawing.Size(566, 20)
        Me.txtCliente.SoloLectura = True
        Me.txtCliente.TabIndex = 33
        Me.txtCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCliente.Valor = ""
        '
        'btnBuscarPoliza
        '
        Me.btnBuscarPoliza.Image = CType(resources.GetObject("btnBuscarPoliza.Image"), System.Drawing.Image)
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(331, 153)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarPoliza.TabIndex = 0
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
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
        Me.txtDesde.Location = New System.Drawing.Point(14, 235)
        Me.txtDesde.MaxLength = 0
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.NombreCampo = ""
        Me.txtDesde.Obligatorio = True
        Me.txtDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.Size = New System.Drawing.Size(566, 20)
        Me.txtDesde.SoloLectura = True
        Me.txtDesde.TabIndex = 35
        Me.txtDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtDesde.Valor = Nothing
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
        Me.txtHasta.Location = New System.Drawing.Point(14, 261)
        Me.txtHasta.MaxLength = 0
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.NombreCampo = ""
        Me.txtHasta.Obligatorio = True
        Me.txtHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHasta.Size = New System.Drawing.Size(566, 20)
        Me.txtHasta.SoloLectura = True
        Me.txtHasta.TabIndex = 36
        Me.txtHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtHasta.Valor = Nothing
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
        Me.txtNuevaHasta.LabelText = "Nueva Vigencia Hasta"
        Me.txtNuevaHasta.LabelWidth = 150
        Me.txtNuevaHasta.Location = New System.Drawing.Point(14, 328)
        Me.txtNuevaHasta.MaxLength = 0
        Me.txtNuevaHasta.Name = "txtNuevaHasta"
        Me.txtNuevaHasta.NombreCampo = ""
        Me.txtNuevaHasta.Obligatorio = True
        Me.txtNuevaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNuevaHasta.Size = New System.Drawing.Size(566, 20)
        Me.txtNuevaHasta.SoloLectura = False
        Me.txtNuevaHasta.TabIndex = 2
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
        Me.txtNuevaDesde.LabelText = "Nueva Vigencia Desde"
        Me.txtNuevaDesde.LabelWidth = 150
        Me.txtNuevaDesde.Location = New System.Drawing.Point(14, 302)
        Me.txtNuevaDesde.MaxLength = 0
        Me.txtNuevaDesde.Name = "txtNuevaDesde"
        Me.txtNuevaDesde.NombreCampo = ""
        Me.txtNuevaDesde.Obligatorio = True
        Me.txtNuevaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNuevaDesde.Size = New System.Drawing.Size(566, 20)
        Me.txtNuevaDesde.SoloLectura = False
        Me.txtNuevaDesde.TabIndex = 1
        Me.txtNuevaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtNuevaDesde.Valor = Nothing
        '
        'cboTipoPoliza
        '
        Me.cboTipoPoliza.CampoAutoCompletar = 0
        Me.cboTipoPoliza.CampoBusqueda = False
        Me.cboTipoPoliza.CampoDisplay = 1
        Me.cboTipoPoliza.CampoEsLlave = False
        Me.cboTipoPoliza.CampoValor = 0
        Me.cboTipoPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoPoliza.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoPoliza.FilasVisibles = 483
        Me.cboTipoPoliza.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoPoliza.LabelText = "Tipo de Póliza"
        Me.cboTipoPoliza.LabelWidth = 150
        Me.cboTipoPoliza.Lista = ""
        Me.cboTipoPoliza.Location = New System.Drawing.Point(14, 354)
        Me.cboTipoPoliza.MostrarBusquedaColumnas = False
        Me.cboTipoPoliza.Name = "cboTipoPoliza"
        Me.cboTipoPoliza.NombreCampo = "TipoPoliza"
        Me.cboTipoPoliza.Obligatorio = False
        Me.cboTipoPoliza.Query = ""
        Me.cboTipoPoliza.SelectIndex = 0
        Me.cboTipoPoliza.Size = New System.Drawing.Size(566, 20)
        Me.cboTipoPoliza.SoloLectura = False
        Me.cboTipoPoliza.StringConection = ""
        Me.cboTipoPoliza.TabIndex = 3
        Me.cboTipoPoliza.TextoNuevoItem = ""
        Me.cboTipoPoliza.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoPoliza.Valor = ""
        '
        'RenovarPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 535
        Me.ClientSize = New System.Drawing.Size(619, 439)
        Me.Controls.Add(Me.cboTipoPoliza)
        Me.Controls.Add(Me.txtNuevaHasta)
        Me.Controls.Add(Me.txtNuevaDesde)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "RenovarPoliza"
        Me.Text = "Renovación"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtDesde, 0)
        Me.Controls.SetChildIndex(Me.txtHasta, 0)
        Me.Controls.SetChildIndex(Me.txtNuevaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtNuevaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboTipoPoliza, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDesde As STIControles.stiTextBox
    Friend WithEvents txtHasta As STIControles.stiTextBox
    Friend WithEvents txtNuevaHasta As STIControles.stiTextBox
    Friend WithEvents txtNuevaDesde As STIControles.stiTextBox
    Friend WithEvents cboTipoPoliza As STIControles.stiComboBox

End Class
