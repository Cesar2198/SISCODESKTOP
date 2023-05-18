<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientosComiMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientosComiMan))
        Me.txtFechaComision = New STIControles.stiTextBox
        Me.cboIdAseguradora = New STIControles.stiComboBox
        Me.txtIdMovimientoComi = New STIControles.stiTextBox
        Me.cboIdOperacion = New STIControles.stiComboBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtFechaCobroComision = New STIControles.stiTextBox
        Me.txtValorComision = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(374, 280)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(190, 280)
        Me.btnBuscar.TabIndex = 8
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(6, 280)
        Me.btnNuevo.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(98, 280)
        Me.btnGuardar.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(466, 280)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(282, 280)
        Me.btnEliminar.TabIndex = 9
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(421, 74)
        Me.lblNombreFormulario.TabIndex = 12
        Me.lblNombreFormulario.Text = "Movimientos de Comisiones"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(-11, 306)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 13
        Me.btnGuardarComo.Visible = False
        '
        'txtFechaComision
        '
        Me.txtFechaComision.CampoBusqueda = True
        Me.txtFechaComision.CampoEsLlave = False
        Me.txtFechaComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaComision.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaComision.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaComision.FechaActual = False
        Me.txtFechaComision.Formato = "dd/MMM/yyyy"
        Me.txtFechaComision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaComision.LabelText = "Fecha Comisión"
        Me.txtFechaComision.LabelWidth = 125
        Me.txtFechaComision.Location = New System.Drawing.Point(26, 222)
        Me.txtFechaComision.MaxLength = 0
        Me.txtFechaComision.Name = "txtFechaComision"
        Me.txtFechaComision.NombreCampo = "FechaComision"
        Me.txtFechaComision.Obligatorio = True
        Me.txtFechaComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaComision.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaComision.SoloLectura = False
        Me.txtFechaComision.TabIndex = 4
        Me.txtFechaComision.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaComision.Valor = Nothing
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.CampoAutoCompletar = 0
        Me.cboIdAseguradora.CampoBusqueda = True
        Me.cboIdAseguradora.CampoDisplay = 1
        Me.cboIdAseguradora.CampoEsLlave = False
        Me.cboIdAseguradora.CampoValor = 0
        Me.cboIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAseguradora.FilasVisibles = 7
        Me.cboIdAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAseguradora.LabelText = "Aseguradora"
        Me.cboIdAseguradora.LabelWidth = 125
        Me.cboIdAseguradora.Lista = ""
        Me.cboIdAseguradora.Location = New System.Drawing.Point(26, 144)
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NombreCampo = "IdAseguradora"
        Me.cboIdAseguradora.Obligatorio = True
        Me.cboIdAseguradora.Query = "select idaseguradora as Id, Nombre as Aseguradora from Aseguradoras order by nomb" & _
            "re"
        Me.cboIdAseguradora.SelectIndex = -1
        Me.cboIdAseguradora.Size = New System.Drawing.Size(522, 20)
        Me.cboIdAseguradora.SoloLectura = False
        Me.cboIdAseguradora.StringConection = ""
        Me.cboIdAseguradora.TabIndex = 1
        Me.cboIdAseguradora.TextoNuevoItem = ""
        Me.cboIdAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAseguradora.Valor = ""
        '
        'txtIdMovimientoComi
        '
        Me.txtIdMovimientoComi.CampoBusqueda = True
        Me.txtIdMovimientoComi.CampoEsLlave = True
        Me.txtIdMovimientoComi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdMovimientoComi.ControlBackColor = System.Drawing.Color.White
        Me.txtIdMovimientoComi.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdMovimientoComi.FechaActual = False
        Me.txtIdMovimientoComi.Formato = "###0"
        Me.txtIdMovimientoComi.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdMovimientoComi.LabelText = "Cod. Movimiento"
        Me.txtIdMovimientoComi.LabelWidth = 125
        Me.txtIdMovimientoComi.Location = New System.Drawing.Point(26, 92)
        Me.txtIdMovimientoComi.MaxLength = 0
        Me.txtIdMovimientoComi.Name = "txtIdMovimientoComi"
        Me.txtIdMovimientoComi.NombreCampo = "IdMovimientoComi"
        Me.txtIdMovimientoComi.Obligatorio = True
        Me.txtIdMovimientoComi.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdMovimientoComi.Size = New System.Drawing.Size(219, 20)
        Me.txtIdMovimientoComi.SoloLectura = False
        Me.txtIdMovimientoComi.TabIndex = 14
        Me.txtIdMovimientoComi.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdMovimientoComi.Valor = 0
        '
        'cboIdOperacion
        '
        Me.cboIdOperacion.CampoAutoCompletar = 0
        Me.cboIdOperacion.CampoBusqueda = True
        Me.cboIdOperacion.CampoDisplay = 1
        Me.cboIdOperacion.CampoEsLlave = False
        Me.cboIdOperacion.CampoValor = 0
        Me.cboIdOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdOperacion.ControlBackColor = System.Drawing.Color.White
        Me.cboIdOperacion.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdOperacion.FilasVisibles = 7
        Me.cboIdOperacion.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdOperacion.LabelText = "Operación"
        Me.cboIdOperacion.LabelWidth = 125
        Me.cboIdOperacion.Lista = ""
        Me.cboIdOperacion.Location = New System.Drawing.Point(26, 118)
        Me.cboIdOperacion.Name = "cboIdOperacion"
        Me.cboIdOperacion.NombreCampo = "IdOperacion"
        Me.cboIdOperacion.Obligatorio = True
        Me.cboIdOperacion.Query = "select IdOperacion as Id, Nombre as Operación from TipoOperacionesComi order by N" & _
            "ombre"
        Me.cboIdOperacion.SelectIndex = -1
        Me.cboIdOperacion.Size = New System.Drawing.Size(522, 20)
        Me.cboIdOperacion.SoloLectura = False
        Me.cboIdOperacion.StringConection = ""
        Me.cboIdOperacion.TabIndex = 0
        Me.cboIdOperacion.TextoNuevoItem = ""
        Me.cboIdOperacion.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdOperacion.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 125
        Me.txtDescripcion.Location = New System.Drawing.Point(26, 170)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(522, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtFechaCobroComision
        '
        Me.txtFechaCobroComision.CampoBusqueda = False
        Me.txtFechaCobroComision.CampoEsLlave = False
        Me.txtFechaCobroComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCobroComision.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCobroComision.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCobroComision.FechaActual = False
        Me.txtFechaCobroComision.Formato = "dd/MMM/yyyy"
        Me.txtFechaCobroComision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCobroComision.LabelText = "Fecha Estado Cuenta"
        Me.txtFechaCobroComision.LabelWidth = 125
        Me.txtFechaCobroComision.Location = New System.Drawing.Point(26, 248)
        Me.txtFechaCobroComision.MaxLength = 0
        Me.txtFechaCobroComision.Name = "txtFechaCobroComision"
        Me.txtFechaCobroComision.NombreCampo = "FechaCobroComision"
        Me.txtFechaCobroComision.Obligatorio = False
        Me.txtFechaCobroComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCobroComision.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaCobroComision.SoloLectura = False
        Me.txtFechaCobroComision.TabIndex = 5
        Me.txtFechaCobroComision.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCobroComision.Valor = Nothing
        '
        'txtValorComision
        '
        Me.txtValorComision.CampoBusqueda = True
        Me.txtValorComision.CampoEsLlave = False
        Me.txtValorComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorComision.ControlBackColor = System.Drawing.Color.White
        Me.txtValorComision.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorComision.FechaActual = False
        Me.txtValorComision.Formato = "#,###0.00"
        Me.txtValorComision.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorComision.LabelText = "Valor Comisión"
        Me.txtValorComision.LabelWidth = 125
        Me.txtValorComision.Location = New System.Drawing.Point(26, 196)
        Me.txtValorComision.MaxLength = 0
        Me.txtValorComision.Name = "txtValorComision"
        Me.txtValorComision.NombreCampo = "ValorComision"
        Me.txtValorComision.Obligatorio = True
        Me.txtValorComision.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorComision.Size = New System.Drawing.Size(300, 20)
        Me.txtValorComision.SoloLectura = False
        Me.txtValorComision.TabIndex = 3
        Me.txtValorComision.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorComision.Valor = 0
        '
        'MovimientosComiMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 606
        Me.ClientSize = New System.Drawing.Size(560, 316)
        Me.Controls.Add(Me.txtValorComision)
        Me.Controls.Add(Me.txtFechaCobroComision)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cboIdOperacion)
        Me.Controls.Add(Me.txtIdMovimientoComi)
        Me.Controls.Add(Me.cboIdAseguradora)
        Me.Controls.Add(Me.txtFechaComision)
        Me.Name = "MovimientosComiMan"
        Me.Text = "Comisiones"
        Me.Controls.SetChildIndex(Me.txtFechaComision, 0)
        Me.Controls.SetChildIndex(Me.cboIdAseguradora, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdMovimientoComi, 0)
        Me.Controls.SetChildIndex(Me.cboIdOperacion, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCobroComision, 0)
        Me.Controls.SetChildIndex(Me.txtValorComision, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaComision As STIControles.stiTextBox
    Friend WithEvents cboIdAseguradora As STIControles.stiComboBox
    Friend WithEvents txtIdMovimientoComi As STIControles.stiTextBox
    Friend WithEvents cboIdOperacion As STIControles.stiComboBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtFechaCobroComision As STIControles.stiTextBox
    Friend WithEvents txtValorComision As STIControles.stiTextBox

End Class
