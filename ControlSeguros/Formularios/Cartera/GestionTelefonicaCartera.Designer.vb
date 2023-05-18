<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionTelefonicaCartera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionTelefonicaCartera))
        Me.txtFechaGestion = New STIControles.stiTextBox
        Me.cboIdTipoGestion = New STIControles.stiComboBox
        Me.txtComentario = New STIControles.stiMemo
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtNumeroFactura = New STIControles.stiTextBox
        Me.txtValorFactura = New STIControles.stiTextBox
        Me.txtNombreCliente = New STIControles.stiTextBox
        Me.txtFechaVence = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(324, 342)
        Me.btnAyuda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(106, 368)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(138, 342)
        Me.btnNuevo.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(231, 342)
        Me.btnGuardar.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(416, 342)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(122, 368)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(371, 74)
        Me.lblNombreFormulario.TabIndex = 14
        Me.lblNombreFormulario.Text = "Gestión Telefónica de Cartera"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(90, 368)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtFechaGestion
        '
        Me.txtFechaGestion.CampoBusqueda = False
        Me.txtFechaGestion.CampoEsLlave = False
        Me.txtFechaGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaGestion.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaGestion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaGestion.FechaActual = True
        Me.txtFechaGestion.Formato = "dd/MMM/yyyy"
        Me.txtFechaGestion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaGestion.LabelText = "Fecha Gestión"
        Me.txtFechaGestion.LabelWidth = 92
        Me.txtFechaGestion.Location = New System.Drawing.Point(12, 81)
        Me.txtFechaGestion.MaxLength = 0
        Me.txtFechaGestion.Name = "txtFechaGestion"
        Me.txtFechaGestion.NombreCampo = "FechaGestion"
        Me.txtFechaGestion.Obligatorio = True
        Me.txtFechaGestion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaGestion.Size = New System.Drawing.Size(274, 20)
        Me.txtFechaGestion.SoloLectura = False
        Me.txtFechaGestion.TabIndex = 0
        Me.txtFechaGestion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaGestion.Valor = Nothing
        '
        'cboIdTipoGestion
        '
        Me.cboIdTipoGestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdTipoGestion.CampoAutoCompletar = 0
        Me.cboIdTipoGestion.CampoBusqueda = False
        Me.cboIdTipoGestion.CampoDisplay = 1
        Me.cboIdTipoGestion.CampoEsLlave = False
        Me.cboIdTipoGestion.CampoValor = 0
        Me.cboIdTipoGestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdTipoGestion.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdTipoGestion.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdTipoGestion.FilasVisibles = 7
        Me.cboIdTipoGestion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdTipoGestion.LabelText = "Gestión"
        Me.cboIdTipoGestion.LabelWidth = 92
        Me.cboIdTipoGestion.Lista = ""
        Me.cboIdTipoGestion.Location = New System.Drawing.Point(12, 223)
        Me.cboIdTipoGestion.Name = "cboIdTipoGestion"
        Me.cboIdTipoGestion.NombreCampo = "IdTipoGestion"
        Me.cboIdTipoGestion.Obligatorio = True
        Me.cboIdTipoGestion.Query = "select IdTipoGestion as Id, NombreGestion as Concepto from TipoGestion where Cate" & _
            "goria = 'C'"
        Me.cboIdTipoGestion.SelectIndex = -1
        Me.cboIdTipoGestion.Size = New System.Drawing.Size(492, 20)
        Me.cboIdTipoGestion.SoloLectura = True
        Me.cboIdTipoGestion.StringConection = ""
        Me.cboIdTipoGestion.TabIndex = 13
        Me.cboIdTipoGestion.TextoNuevoItem = ""
        Me.cboIdTipoGestion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdTipoGestion.Valor = ""
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.CampoBusqueda = False
        Me.txtComentario.CampoEsLlave = False
        Me.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtComentario.ControlBackColor = System.Drawing.Color.White
        Me.txtComentario.ControlForeColor = System.Drawing.Color.Black
        Me.txtComentario.FechaActual = False
        Me.txtComentario.Formato = ""
        Me.txtComentario.LabelOrietation = STIControles.stiMemo.LOrientacion.Izquierda
        Me.txtComentario.LabelText = "Comentarios"
        Me.txtComentario.LabelWidth = 92
        Me.txtComentario.Location = New System.Drawing.Point(12, 247)
        Me.txtComentario.MaxLength = 2000
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.NombreCampo = ""
        Me.txtComentario.Obligatorio = False
        Me.txtComentario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentario.Size = New System.Drawing.Size(492, 89)
        Me.txtComentario.SoloLectura = False
        Me.txtComentario.TabIndex = 2
        Me.txtComentario.TipoDato = STIControles.stiMemo.TipoContenido.Texto
        Me.txtComentario.Valor = ""
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(378, 79)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(127, 43)
        Me.btnBuscaPoliza.TabIndex = 1
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 92
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 104)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(274, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 7
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 92
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 127)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto [Producto], Descripcion [Descripción] from Productos order by D" & _
            "escripcion asc"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(492, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 8
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.CampoBusqueda = True
        Me.txtNumeroFactura.CampoEsLlave = True
        Me.txtNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroFactura.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNumeroFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroFactura.FechaActual = False
        Me.txtNumeroFactura.Formato = ""
        Me.txtNumeroFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroFactura.LabelText = "Factura"
        Me.txtNumeroFactura.LabelWidth = 92
        Me.txtNumeroFactura.Location = New System.Drawing.Point(12, 175)
        Me.txtNumeroFactura.MaxLength = 25
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.NombreCampo = "Factura"
        Me.txtNumeroFactura.Obligatorio = True
        Me.txtNumeroFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroFactura.Size = New System.Drawing.Size(274, 20)
        Me.txtNumeroFactura.SoloLectura = True
        Me.txtNumeroFactura.TabIndex = 10
        Me.txtNumeroFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroFactura.Valor = ""
        '
        'txtValorFactura
        '
        Me.txtValorFactura.CampoBusqueda = True
        Me.txtValorFactura.CampoEsLlave = True
        Me.txtValorFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorFactura.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtValorFactura.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorFactura.FechaActual = False
        Me.txtValorFactura.Formato = "c"
        Me.txtValorFactura.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorFactura.LabelText = "Valor de Factura"
        Me.txtValorFactura.LabelWidth = 92
        Me.txtValorFactura.Location = New System.Drawing.Point(12, 199)
        Me.txtValorFactura.MaxLength = 25
        Me.txtValorFactura.Name = "txtValorFactura"
        Me.txtValorFactura.NombreCampo = ""
        Me.txtValorFactura.Obligatorio = False
        Me.txtValorFactura.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorFactura.Size = New System.Drawing.Size(274, 20)
        Me.txtValorFactura.SoloLectura = True
        Me.txtValorFactura.TabIndex = 11
        Me.txtValorFactura.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorFactura.Valor = 0
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = True
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 92
        Me.txtNombreCliente.Location = New System.Drawing.Point(12, 151)
        Me.txtNombreCliente.MaxLength = 25
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "Factura"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(492, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 9
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'txtFechaVence
        '
        Me.txtFechaVence.CampoBusqueda = False
        Me.txtFechaVence.CampoEsLlave = False
        Me.txtFechaVence.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaVence.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtFechaVence.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaVence.FechaActual = True
        Me.txtFechaVence.Formato = "dd/MMM/yyyy"
        Me.txtFechaVence.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaVence.LabelText = "Fecha Vence"
        Me.txtFechaVence.LabelWidth = 65
        Me.txtFechaVence.Location = New System.Drawing.Point(292, 201)
        Me.txtFechaVence.MaxLength = 0
        Me.txtFechaVence.Name = "txtFechaVence"
        Me.txtFechaVence.NombreCampo = ""
        Me.txtFechaVence.Obligatorio = False
        Me.txtFechaVence.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaVence.Size = New System.Drawing.Size(212, 20)
        Me.txtFechaVence.SoloLectura = True
        Me.txtFechaVence.TabIndex = 12
        Me.txtFechaVence.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaVence.Valor = Nothing
        '
        'GestionTelefonicaCartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(510, 378)
        Me.Controls.Add(Me.txtFechaVence)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtValorFactura)
        Me.Controls.Add(Me.txtNumeroFactura)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.cboIdTipoGestion)
        Me.Controls.Add(Me.txtFechaGestion)
        Me.Name = "GestionTelefonicaCartera"
        Me.Text = "Gestión Telefónica de Cartera"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaGestion, 0)
        Me.Controls.SetChildIndex(Me.cboIdTipoGestion, 0)
        Me.Controls.SetChildIndex(Me.txtComentario, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroFactura, 0)
        Me.Controls.SetChildIndex(Me.txtValorFactura, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.txtFechaVence, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaGestion As STIControles.stiTextBox
    Friend WithEvents cboIdTipoGestion As STIControles.stiComboBox
    Friend WithEvents txtComentario As STIControles.stiMemo
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtNumeroFactura As STIControles.stiTextBox
    Friend WithEvents txtValorFactura As STIControles.stiTextBox
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox
    Friend WithEvents txtFechaVence As STIControles.stiTextBox

End Class
