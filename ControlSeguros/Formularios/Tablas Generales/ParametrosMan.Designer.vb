<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametrosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParametrosMan))
        Me.txtIdParametro = New STIControles.stiTextBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtCadena = New STIControles.stiTextBox
        Me.txtEntero = New STIControles.stiTextBox
        Me.txtValor = New STIControles.stiTextBox
        Me.txtFecha = New STIControles.stiTextBox
        Me.cboTipo = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(464, 268)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(280, 268)
        Me.btnBuscar.TabIndex = 9
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(3, 268)
        Me.btnNuevo.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(95, 268)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(556, 268)
        Me.btnSalir.TabIndex = 12
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 268)
        Me.btnEliminar.TabIndex = 10
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(617, 74)
        Me.lblNombreFormulario.Text = "Administración de Parámetros"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(187, 268)
        '
        'txtIdParametro
        '
        Me.txtIdParametro.CampoBusqueda = True
        Me.txtIdParametro.CampoEsLlave = True
        Me.txtIdParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdParametro.ControlBackColor = System.Drawing.Color.White
        Me.txtIdParametro.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdParametro.FechaActual = False
        Me.txtIdParametro.Formato = ""
        Me.txtIdParametro.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdParametro.LabelText = "Cod. Parámetro"
        Me.txtIdParametro.LabelWidth = 100
        Me.txtIdParametro.Location = New System.Drawing.Point(30, 81)
        Me.txtIdParametro.MaxLength = 50
        Me.txtIdParametro.Name = "txtIdParametro"
        Me.txtIdParametro.NombreCampo = "IdParametro"
        Me.txtIdParametro.Obligatorio = True
        Me.txtIdParametro.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdParametro.Size = New System.Drawing.Size(374, 20)
        Me.txtIdParametro.SoloLectura = False
        Me.txtIdParametro.TabIndex = 0
        Me.txtIdParametro.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdParametro.Valor = ""
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CampoBusqueda = True
        Me.txtDescripcion.CampoEsLlave = False
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescripcion.ControlBackColor = System.Drawing.Color.White
        Me.txtDescripcion.ControlForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.FechaActual = False
        Me.txtDescripcion.Formato = ""
        Me.txtDescripcion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtDescripcion.LabelText = "Descripción"
        Me.txtDescripcion.LabelWidth = 100
        Me.txtDescripcion.Location = New System.Drawing.Point(30, 107)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(608, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtCadena
        '
        Me.txtCadena.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCadena.CampoBusqueda = False
        Me.txtCadena.CampoEsLlave = False
        Me.txtCadena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCadena.ControlBackColor = System.Drawing.Color.White
        Me.txtCadena.ControlForeColor = System.Drawing.Color.Black
        Me.txtCadena.FechaActual = False
        Me.txtCadena.Formato = ""
        Me.txtCadena.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtCadena.LabelText = "Texto"
        Me.txtCadena.LabelWidth = 100
        Me.txtCadena.Location = New System.Drawing.Point(30, 159)
        Me.txtCadena.MaxLength = 1500
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.NombreCampo = "Cadena"
        Me.txtCadena.Obligatorio = False
        Me.txtCadena.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCadena.Size = New System.Drawing.Size(608, 20)
        Me.txtCadena.SoloLectura = False
        Me.txtCadena.TabIndex = 3
        Me.txtCadena.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtCadena.Valor = ""
        '
        'txtEntero
        '
        Me.txtEntero.CampoBusqueda = False
        Me.txtEntero.CampoEsLlave = False
        Me.txtEntero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEntero.ControlBackColor = System.Drawing.Color.White
        Me.txtEntero.ControlForeColor = System.Drawing.Color.Black
        Me.txtEntero.FechaActual = False
        Me.txtEntero.Formato = "###0"
        Me.txtEntero.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtEntero.LabelText = "Num. Entero"
        Me.txtEntero.LabelWidth = 100
        Me.txtEntero.Location = New System.Drawing.Point(30, 185)
        Me.txtEntero.MaxLength = 0
        Me.txtEntero.Name = "txtEntero"
        Me.txtEntero.NombreCampo = "Entero"
        Me.txtEntero.Obligatorio = False
        Me.txtEntero.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEntero.Size = New System.Drawing.Size(374, 20)
        Me.txtEntero.SoloLectura = False
        Me.txtEntero.TabIndex = 4
        Me.txtEntero.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtEntero.Valor = 0
        '
        'txtValor
        '
        Me.txtValor.CampoBusqueda = False
        Me.txtValor.CampoEsLlave = False
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValor.ControlBackColor = System.Drawing.Color.White
        Me.txtValor.ControlForeColor = System.Drawing.Color.Black
        Me.txtValor.FechaActual = False
        Me.txtValor.Formato = "###,###0.0000"
        Me.txtValor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValor.LabelText = "Número"
        Me.txtValor.LabelWidth = 100
        Me.txtValor.Location = New System.Drawing.Point(30, 211)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.NombreCampo = "Valor"
        Me.txtValor.Obligatorio = False
        Me.txtValor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValor.Size = New System.Drawing.Size(374, 20)
        Me.txtValor.SoloLectura = False
        Me.txtValor.TabIndex = 5
        Me.txtValor.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValor.Valor = 0
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = False
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.White
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = False
        Me.txtFecha.Formato = "Short Date"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(30, 237)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = "Fecha"
        Me.txtFecha.Obligatorio = False
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(374, 20)
        Me.txtFecha.SoloLectura = False
        Me.txtFecha.TabIndex = 6
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'cboTipo
        '
        Me.cboTipo.CampoAutoCompletar = 0
        Me.cboTipo.CampoBusqueda = False
        Me.cboTipo.CampoDisplay = 1
        Me.cboTipo.CampoEsLlave = False
        Me.cboTipo.CampoValor = 0
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipo.ControlBackColor = System.Drawing.Color.White
        Me.cboTipo.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipo.FilasVisibles = 7
        Me.cboTipo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipo.LabelText = "Tipo"
        Me.cboTipo.LabelWidth = 100
        Me.cboTipo.Lista = "T Texto|E entero|F Fecha|N Número|P Texto Protegido"
        Me.cboTipo.Location = New System.Drawing.Point(30, 133)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.NombreCampo = "Tipo"
        Me.cboTipo.Obligatorio = True
        Me.cboTipo.Query = ""
        Me.cboTipo.SelectIndex = -1
        Me.cboTipo.Size = New System.Drawing.Size(374, 20)
        Me.cboTipo.SoloLectura = False
        Me.cboTipo.StringConection = ""
        Me.cboTipo.TabIndex = 2
        Me.cboTipo.TextoNuevoItem = ""
        Me.cboTipo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipo.Valor = ""
        '
        'ParametrosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 114
        Me.ClientSize = New System.Drawing.Size(650, 304)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtEntero)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdParametro)
        Me.Name = "ParametrosMan"
        Me.Text = "Parámetros"
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdParametro, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCadena, 0)
        Me.Controls.SetChildIndex(Me.txtEntero, 0)
        Me.Controls.SetChildIndex(Me.txtValor, 0)
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.cboTipo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdParametro As STIControles.stiTextBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtCadena As STIControles.stiTextBox
    Friend WithEvents txtEntero As STIControles.stiTextBox
    Friend WithEvents txtValor As STIControles.stiTextBox
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents cboTipo As STIControles.stiComboBox

End Class
