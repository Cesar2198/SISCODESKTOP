<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TalonariosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TalonariosMan))
        Me.txtFecha = New STIControles.stiTextBox
        Me.txtReciboInicial = New STIControles.stiTextBox
        Me.txtReciboFinal = New STIControles.stiTextBox
        Me.txtFechaAsignado = New STIControles.stiTextBox
        Me.txtResponsable = New STIControles.stiComboBox
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(392, 216)
        Me.btnAyuda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(196, 216)
        Me.btnBuscar.TabIndex = 6
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(12, 216)
        Me.btnNuevo.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(104, 216)
        Me.btnGuardar.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(484, 216)
        Me.btnSalir.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(8, 226)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(439, 74)
        Me.lblNombreFormulario.Text = "Talonarios de Cobro"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(8, 242)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.CampoBusqueda = False
        Me.txtFecha.CampoEsLlave = True
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFecha.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFecha.ControlForeColor = System.Drawing.Color.Black
        Me.txtFecha.FechaActual = False
        Me.txtFecha.Formato = "dd/MMM/yyyy"
        Me.txtFecha.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFecha.LabelText = "Fecha Creado"
        Me.txtFecha.LabelWidth = 100
        Me.txtFecha.Location = New System.Drawing.Point(12, 81)
        Me.txtFecha.MaxLength = 0
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NombreCampo = "Fecha"
        Me.txtFecha.Obligatorio = True
        Me.txtFecha.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.Size = New System.Drawing.Size(268, 20)
        Me.txtFecha.SoloLectura = True
        Me.txtFecha.TabIndex = 9
        Me.txtFecha.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFecha.Valor = Nothing
        '
        'txtReciboInicial
        '
        Me.txtReciboInicial.CampoBusqueda = False
        Me.txtReciboInicial.CampoEsLlave = True
        Me.txtReciboInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtReciboInicial.ControlBackColor = System.Drawing.Color.White
        Me.txtReciboInicial.ControlForeColor = System.Drawing.Color.Black
        Me.txtReciboInicial.FechaActual = False
        Me.txtReciboInicial.Formato = "#,###0"
        Me.txtReciboInicial.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtReciboInicial.LabelText = "Recibo Inicial"
        Me.txtReciboInicial.LabelWidth = 100
        Me.txtReciboInicial.Location = New System.Drawing.Point(12, 107)
        Me.txtReciboInicial.MaxLength = 0
        Me.txtReciboInicial.Name = "txtReciboInicial"
        Me.txtReciboInicial.NombreCampo = "ReciboInicial"
        Me.txtReciboInicial.Obligatorio = True
        Me.txtReciboInicial.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReciboInicial.Size = New System.Drawing.Size(268, 20)
        Me.txtReciboInicial.SoloLectura = False
        Me.txtReciboInicial.TabIndex = 0
        Me.txtReciboInicial.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtReciboInicial.Valor = 0
        '
        'txtReciboFinal
        '
        Me.txtReciboFinal.CampoBusqueda = False
        Me.txtReciboFinal.CampoEsLlave = True
        Me.txtReciboFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtReciboFinal.ControlBackColor = System.Drawing.Color.White
        Me.txtReciboFinal.ControlForeColor = System.Drawing.Color.Black
        Me.txtReciboFinal.FechaActual = False
        Me.txtReciboFinal.Formato = "#,###0"
        Me.txtReciboFinal.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtReciboFinal.LabelText = "Recibo Final"
        Me.txtReciboFinal.LabelWidth = 100
        Me.txtReciboFinal.Location = New System.Drawing.Point(298, 107)
        Me.txtReciboFinal.MaxLength = 0
        Me.txtReciboFinal.Name = "txtReciboFinal"
        Me.txtReciboFinal.NombreCampo = "ReciboFinal"
        Me.txtReciboFinal.Obligatorio = True
        Me.txtReciboFinal.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReciboFinal.Size = New System.Drawing.Size(268, 20)
        Me.txtReciboFinal.SoloLectura = False
        Me.txtReciboFinal.TabIndex = 1
        Me.txtReciboFinal.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtReciboFinal.Valor = 0
        '
        'txtFechaAsignado
        '
        Me.txtFechaAsignado.CampoBusqueda = False
        Me.txtFechaAsignado.CampoEsLlave = False
        Me.txtFechaAsignado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaAsignado.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaAsignado.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaAsignado.FechaActual = False
        Me.txtFechaAsignado.Formato = "dd/MMM/yyyy"
        Me.txtFechaAsignado.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaAsignado.LabelText = "Fecha Asignado"
        Me.txtFechaAsignado.LabelWidth = 100
        Me.txtFechaAsignado.Location = New System.Drawing.Point(12, 149)
        Me.txtFechaAsignado.MaxLength = 0
        Me.txtFechaAsignado.Name = "txtFechaAsignado"
        Me.txtFechaAsignado.NombreCampo = "FechaAsignado"
        Me.txtFechaAsignado.Obligatorio = False
        Me.txtFechaAsignado.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaAsignado.Size = New System.Drawing.Size(268, 20)
        Me.txtFechaAsignado.SoloLectura = False
        Me.txtFechaAsignado.TabIndex = 2
        Me.txtFechaAsignado.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaAsignado.Valor = Nothing
        '
        'txtResponsable
        '
        Me.txtResponsable.CampoAutoCompletar = 0
        Me.txtResponsable.CampoBusqueda = False
        Me.txtResponsable.CampoDisplay = 1
        Me.txtResponsable.CampoEsLlave = False
        Me.txtResponsable.CampoValor = 0
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResponsable.ControlBackColor = System.Drawing.Color.White
        Me.txtResponsable.ControlForeColor = System.Drawing.Color.Black
        Me.txtResponsable.FilasVisibles = 0
        Me.txtResponsable.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.txtResponsable.LabelText = "Responsable"
        Me.txtResponsable.LabelWidth = 100
        Me.txtResponsable.Lista = ""
        Me.txtResponsable.Location = New System.Drawing.Point(12, 175)
        Me.txtResponsable.MostrarBusquedaColumnas = False
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.NombreCampo = "Responsable"
        Me.txtResponsable.Obligatorio = False
        Me.txtResponsable.Query = "select idusuario as Id, NombreUsuario as Usuario from Usuarios"
        Me.txtResponsable.SelectIndex = 0
        Me.txtResponsable.Size = New System.Drawing.Size(441, 20)
        Me.txtResponsable.SoloLectura = False
        Me.txtResponsable.StringConection = ""
        Me.txtResponsable.TabIndex = 3
        Me.txtResponsable.TextoNuevoItem = ""
        Me.txtResponsable.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.txtResponsable.Valor = ""
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(289, 216)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 36)
        Me.btnImprimir.TabIndex = 17
        Me.btnImprimir.Text = "&Imprimir"
        '
        'TalonariosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(578, 252)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.txtFechaAsignado)
        Me.Controls.Add(Me.txtReciboFinal)
        Me.Controls.Add(Me.txtReciboInicial)
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "TalonariosMan"
        Me.Text = "Talonarios"
        Me.Controls.SetChildIndex(Me.txtFecha, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtReciboInicial, 0)
        Me.Controls.SetChildIndex(Me.txtReciboFinal, 0)
        Me.Controls.SetChildIndex(Me.txtFechaAsignado, 0)
        Me.Controls.SetChildIndex(Me.txtResponsable, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As STIControles.stiTextBox
    Friend WithEvents txtReciboInicial As STIControles.stiTextBox
    Friend WithEvents txtReciboFinal As STIControles.stiTextBox
    Friend WithEvents txtFechaAsignado As STIControles.stiTextBox
    Friend WithEvents txtResponsable As STIControles.stiComboBox
    Public WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton

End Class
