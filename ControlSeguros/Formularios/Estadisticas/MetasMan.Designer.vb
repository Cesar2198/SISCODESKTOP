<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetasMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetasMan))
        Me.txtAnio = New STIControles.stiTextBox
        Me.cboMes = New STIControles.stiComboBox
        Me.txtPrimas = New STIControles.stiTextBox
        Me.txtComisiones = New STIControles.stiTextBox
        Me.cboIdRamo = New STIControles.stiComboBox
        Me.cboEjecutivoCta = New STIControles.stiComboBox
        Me.txtIdMeta = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(376, 274)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(192, 274)
        Me.btnBuscar.TabIndex = 8
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(6, 274)
        Me.btnNuevo.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(98, 274)
        Me.btnGuardar.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(468, 274)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(284, 274)
        Me.btnEliminar.TabIndex = 9
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(423, 74)
        Me.lblNombreFormulario.TabIndex = 10
        Me.lblNombreFormulario.Text = "Registro de Metas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(-9, 300)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 11
        Me.btnGuardarComo.Visible = False
        '
        'txtAnio
        '
        Me.txtAnio.CampoBusqueda = True
        Me.txtAnio.CampoEsLlave = False
        Me.txtAnio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAnio.ControlBackColor = System.Drawing.Color.White
        Me.txtAnio.ControlForeColor = System.Drawing.Color.Black
        Me.txtAnio.FechaActual = False
        Me.txtAnio.Formato = "###0"
        Me.txtAnio.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAnio.LabelText = "Año"
        Me.txtAnio.LabelWidth = 100
        Me.txtAnio.Location = New System.Drawing.Point(52, 115)
        Me.txtAnio.MaxLength = 0
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.NombreCampo = "Anio"
        Me.txtAnio.Obligatorio = True
        Me.txtAnio.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAnio.Size = New System.Drawing.Size(300, 20)
        Me.txtAnio.SoloLectura = False
        Me.txtAnio.TabIndex = 0
        Me.txtAnio.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtAnio.Valor = 0
        '
        'cboMes
        '
        Me.cboMes.CampoAutoCompletar = 0
        Me.cboMes.CampoBusqueda = True
        Me.cboMes.CampoDisplay = 1
        Me.cboMes.CampoEsLlave = False
        Me.cboMes.CampoValor = 0
        Me.cboMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMes.ControlBackColor = System.Drawing.Color.White
        Me.cboMes.ControlForeColor = System.Drawing.Color.Black
        Me.cboMes.FilasVisibles = 7
        Me.cboMes.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboMes.LabelText = "Mes"
        Me.cboMes.LabelWidth = 100
        Me.cboMes.Lista = "1 ENERO|2 FEBRERO|3 MARZO|4 ABRIL|5 MAYO|6 JUNIO|7 JULIO|8 AGOSTO|9 SEPTIEMBRE|10" & _
            " OCTUBRE|11 NOVIEMBRE|12 DICIEMBRE"
        Me.cboMes.Location = New System.Drawing.Point(52, 141)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.NombreCampo = "Mes"
        Me.cboMes.Obligatorio = True
        Me.cboMes.Query = ""
        Me.cboMes.SelectIndex = -1
        Me.cboMes.Size = New System.Drawing.Size(300, 20)
        Me.cboMes.SoloLectura = False
        Me.cboMes.StringConection = ""
        Me.cboMes.TabIndex = 1
        Me.cboMes.TextoNuevoItem = ""
        Me.cboMes.TipoDato = STIControles.stiComboBox.TipoContenido.Numero
        Me.cboMes.Valor = 0
        '
        'txtPrimas
        '
        Me.txtPrimas.CampoBusqueda = False
        Me.txtPrimas.CampoEsLlave = False
        Me.txtPrimas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrimas.ControlBackColor = System.Drawing.Color.White
        Me.txtPrimas.ControlForeColor = System.Drawing.Color.Black
        Me.txtPrimas.FechaActual = False
        Me.txtPrimas.Formato = "#,###0.00"
        Me.txtPrimas.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtPrimas.LabelText = "Prima Meta"
        Me.txtPrimas.LabelWidth = 100
        Me.txtPrimas.Location = New System.Drawing.Point(52, 219)
        Me.txtPrimas.MaxLength = 0
        Me.txtPrimas.Name = "txtPrimas"
        Me.txtPrimas.NombreCampo = "Primas"
        Me.txtPrimas.Obligatorio = False
        Me.txtPrimas.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimas.Size = New System.Drawing.Size(300, 20)
        Me.txtPrimas.SoloLectura = False
        Me.txtPrimas.TabIndex = 4
        Me.txtPrimas.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtPrimas.Valor = 0
        '
        'txtComisiones
        '
        Me.txtComisiones.CampoBusqueda = False
        Me.txtComisiones.CampoEsLlave = False
        Me.txtComisiones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtComisiones.ControlBackColor = System.Drawing.Color.White
        Me.txtComisiones.ControlForeColor = System.Drawing.Color.Black
        Me.txtComisiones.FechaActual = False
        Me.txtComisiones.Formato = "#,###0.00"
        Me.txtComisiones.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtComisiones.LabelText = "Comisión Meta"
        Me.txtComisiones.LabelWidth = 100
        Me.txtComisiones.Location = New System.Drawing.Point(52, 245)
        Me.txtComisiones.MaxLength = 0
        Me.txtComisiones.Name = "txtComisiones"
        Me.txtComisiones.NombreCampo = "Comisiones"
        Me.txtComisiones.Obligatorio = False
        Me.txtComisiones.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComisiones.Size = New System.Drawing.Size(300, 20)
        Me.txtComisiones.SoloLectura = False
        Me.txtComisiones.TabIndex = 5
        Me.txtComisiones.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtComisiones.Valor = 0
        '
        'cboIdRamo
        '
        Me.cboIdRamo.CampoAutoCompletar = 0
        Me.cboIdRamo.CampoBusqueda = True
        Me.cboIdRamo.CampoDisplay = 1
        Me.cboIdRamo.CampoEsLlave = False
        Me.cboIdRamo.CampoValor = 0
        Me.cboIdRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdRamo.FilasVisibles = 7
        Me.cboIdRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdRamo.LabelText = "Ramo"
        Me.cboIdRamo.LabelWidth = 100
        Me.cboIdRamo.Lista = ""
        Me.cboIdRamo.Location = New System.Drawing.Point(52, 167)
        Me.cboIdRamo.Name = "cboIdRamo"
        Me.cboIdRamo.NombreCampo = "IdRamo"
        Me.cboIdRamo.Obligatorio = True
        Me.cboIdRamo.Query = "select idramo as Id, NombreRamo as Ramo from RamoSeguros order by NombreRamo"
        Me.cboIdRamo.SelectIndex = -1
        Me.cboIdRamo.Size = New System.Drawing.Size(498, 20)
        Me.cboIdRamo.SoloLectura = False
        Me.cboIdRamo.StringConection = ""
        Me.cboIdRamo.TabIndex = 2
        Me.cboIdRamo.TextoNuevoItem = ""
        Me.cboIdRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdRamo.Valor = ""
        '
        'cboEjecutivoCta
        '
        Me.cboEjecutivoCta.CampoAutoCompletar = 0
        Me.cboEjecutivoCta.CampoBusqueda = True
        Me.cboEjecutivoCta.CampoDisplay = 1
        Me.cboEjecutivoCta.CampoEsLlave = False
        Me.cboEjecutivoCta.CampoValor = 0
        Me.cboEjecutivoCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjecutivoCta.ControlBackColor = System.Drawing.Color.White
        Me.cboEjecutivoCta.ControlForeColor = System.Drawing.Color.Black
        Me.cboEjecutivoCta.FilasVisibles = 7
        Me.cboEjecutivoCta.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivoCta.LabelText = "Ejecutivo Cuenta"
        Me.cboEjecutivoCta.LabelWidth = 100
        Me.cboEjecutivoCta.Lista = ""
        Me.cboEjecutivoCta.Location = New System.Drawing.Point(52, 193)
        Me.cboEjecutivoCta.Name = "cboEjecutivoCta"
        Me.cboEjecutivoCta.NombreCampo = "EjecutivoCta"
        Me.cboEjecutivoCta.Obligatorio = False
        Me.cboEjecutivoCta.Query = "select idusuario as Id, NombreUsuario as Usuario from Usuarios where EsEjecutivo " & _
            "= 'S' order by NombreUsuario"
        Me.cboEjecutivoCta.SelectIndex = -1
        Me.cboEjecutivoCta.Size = New System.Drawing.Size(498, 20)
        Me.cboEjecutivoCta.SoloLectura = False
        Me.cboEjecutivoCta.StringConection = ""
        Me.cboEjecutivoCta.TabIndex = 3
        Me.cboEjecutivoCta.TextoNuevoItem = ""
        Me.cboEjecutivoCta.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivoCta.Valor = ""
        '
        'txtIdMeta
        '
        Me.txtIdMeta.CampoBusqueda = True
        Me.txtIdMeta.CampoEsLlave = True
        Me.txtIdMeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdMeta.ControlBackColor = System.Drawing.Color.White
        Me.txtIdMeta.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdMeta.FechaActual = False
        Me.txtIdMeta.Formato = "###0"
        Me.txtIdMeta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdMeta.LabelText = "ID"
        Me.txtIdMeta.LabelWidth = 100
        Me.txtIdMeta.Location = New System.Drawing.Point(52, 89)
        Me.txtIdMeta.MaxLength = 0
        Me.txtIdMeta.Name = "txtIdMeta"
        Me.txtIdMeta.NombreCampo = "IdMeta"
        Me.txtIdMeta.Obligatorio = False
        Me.txtIdMeta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdMeta.Size = New System.Drawing.Size(300, 20)
        Me.txtIdMeta.SoloLectura = False
        Me.txtIdMeta.TabIndex = 15
        Me.txtIdMeta.Tag = ""
        Me.txtIdMeta.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdMeta.Valor = 0
        '
        'MetasMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 701
        Me.ClientSize = New System.Drawing.Size(562, 310)
        Me.Controls.Add(Me.txtIdMeta)
        Me.Controls.Add(Me.cboEjecutivoCta)
        Me.Controls.Add(Me.cboIdRamo)
        Me.Controls.Add(Me.txtComisiones)
        Me.Controls.Add(Me.txtPrimas)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.cboMes)
        Me.Name = "MetasMan"
        Me.Text = "Metas Corporativas"
        Me.Controls.SetChildIndex(Me.cboMes, 0)
        Me.Controls.SetChildIndex(Me.txtAnio, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtPrimas, 0)
        Me.Controls.SetChildIndex(Me.txtComisiones, 0)
        Me.Controls.SetChildIndex(Me.cboIdRamo, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivoCta, 0)
        Me.Controls.SetChildIndex(Me.txtIdMeta, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAnio As STIControles.stiTextBox
    Friend WithEvents cboMes As STIControles.stiComboBox
    Friend WithEvents txtPrimas As STIControles.stiTextBox
    Friend WithEvents txtComisiones As STIControles.stiTextBox
    Friend WithEvents cboIdRamo As STIControles.stiComboBox
    Friend WithEvents cboEjecutivoCta As STIControles.stiComboBox
    Friend WithEvents txtIdMeta As STIControles.stiTextBox

End Class
