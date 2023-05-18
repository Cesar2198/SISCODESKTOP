<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanSiniestrosMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanSiniestrosMan))
        Me.txtIdPlan = New STIControles.stiTextBox
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtDescripcion = New STIControles.stiTextBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.txtNumeroReclamo = New STIControles.stiTextBox
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(464, 261)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(280, 261)
        Me.btnBuscar.TabIndex = 8
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(3, 261)
        Me.btnNuevo.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(95, 261)
        Me.btnGuardar.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(556, 261)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(372, 261)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(511, 74)
        Me.lblNombreFormulario.TabIndex = 12
        Me.lblNombreFormulario.Text = "Plan de Reclamos"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(188, 261)
        Me.btnGuardarComo.TabIndex = 7
        '
        'txtIdPlan
        '
        Me.txtIdPlan.CampoBusqueda = True
        Me.txtIdPlan.CampoEsLlave = True
        Me.txtIdPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPlan.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPlan.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPlan.FechaActual = False
        Me.txtIdPlan.Formato = ""
        Me.txtIdPlan.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPlan.LabelText = "Cod. Plan"
        Me.txtIdPlan.LabelWidth = 150
        Me.txtIdPlan.Location = New System.Drawing.Point(47, 81)
        Me.txtIdPlan.MaxLength = 25
        Me.txtIdPlan.Name = "txtIdPlan"
        Me.txtIdPlan.NombreCampo = "IdPlan"
        Me.txtIdPlan.Obligatorio = True
        Me.txtIdPlan.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPlan.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPlan.SoloLectura = False
        Me.txtIdPlan.TabIndex = 0
        Me.txtIdPlan.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPlan.Valor = ""
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = False
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = False
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 7
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 150
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(47, 159)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = -1
        Me.cboIdProducto.Size = New System.Drawing.Size(591, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 3
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
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
        Me.txtDescripcion.LabelWidth = 150
        Me.txtDescripcion.Location = New System.Drawing.Point(47, 107)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NombreCampo = "Descripcion"
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(591, 20)
        Me.txtDescripcion.SoloLectura = False
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtDescripcion.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = False
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 150
        Me.txtIdPoliza.Location = New System.Drawing.Point(47, 133)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 2
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'txtNumeroReclamo
        '
        Me.txtNumeroReclamo.CampoBusqueda = False
        Me.txtNumeroReclamo.CampoEsLlave = False
        Me.txtNumeroReclamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroReclamo.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroReclamo.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroReclamo.FechaActual = False
        Me.txtNumeroReclamo.Formato = ""
        Me.txtNumeroReclamo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroReclamo.LabelText = "Patrón Número Reclamo"
        Me.txtNumeroReclamo.LabelWidth = 150
        Me.txtNumeroReclamo.Location = New System.Drawing.Point(47, 185)
        Me.txtNumeroReclamo.MaxLength = 0
        Me.txtNumeroReclamo.Name = "txtNumeroReclamo"
        Me.txtNumeroReclamo.NombreCampo = "NumeroReclamo"
        Me.txtNumeroReclamo.Obligatorio = False
        Me.txtNumeroReclamo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroReclamo.Size = New System.Drawing.Size(364, 20)
        Me.txtNumeroReclamo.SoloLectura = False
        Me.txtNumeroReclamo.TabIndex = 4
        Me.txtNumeroReclamo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroReclamo.Valor = ""
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(367, 129)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscaPoliza.TabIndex = 28
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(198, 212)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(343, 13)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "Patrones a Validar = #: Correlativo por plan, yy#: Correlativo Año Plan"
        '
        'PlanSiniestrosMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 810
        Me.ClientSize = New System.Drawing.Size(650, 297)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.txtNumeroReclamo)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdPlan)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Name = "PlanSiniestrosMan"
        Me.Text = "Plan de Reclamos"
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.txtIdPlan, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroReclamo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdPlan As STIControles.stiTextBox
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtDescripcion As STIControles.stiTextBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents txtNumeroReclamo As STIControles.stiTextBox
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl

End Class
