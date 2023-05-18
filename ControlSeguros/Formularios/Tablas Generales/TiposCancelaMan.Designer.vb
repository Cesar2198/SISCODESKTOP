<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposCancelaMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TiposCancelaMan))
        Me.txtIdCancelacion = New STIControles.stiTextBox
        Me.txtNombreCancelacion = New STIControles.stiTextBox
        Me.cboCancelaFacturas = New STIControles.stiComboBox
        Me.cboCancelaSiniestros = New STIControles.stiComboBox
        Me.cboCancelaFlujos = New STIControles.stiComboBox
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(476, 255)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(292, 255)
        Me.btnBuscar.TabIndex = 8
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(15, 255)
        Me.btnNuevo.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(107, 255)
        Me.btnGuardar.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(568, 255)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(384, 255)
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
        Me.lblNombreFormulario.TabIndex = 12
        Me.lblNombreFormulario.Text = "Tipos de Cancelación de Pólizas"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(200, 255)
        Me.btnGuardarComo.TabIndex = 7
        '
        'txtIdCancelacion
        '
        Me.txtIdCancelacion.CampoBusqueda = True
        Me.txtIdCancelacion.CampoEsLlave = True
        Me.txtIdCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.txtIdCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCancelacion.FechaActual = False
        Me.txtIdCancelacion.Formato = ""
        Me.txtIdCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCancelacion.LabelText = "Cod. Anulacion"
        Me.txtIdCancelacion.LabelWidth = 125
        Me.txtIdCancelacion.Location = New System.Drawing.Point(24, 81)
        Me.txtIdCancelacion.MaxLength = 25
        Me.txtIdCancelacion.Name = "txtIdCancelacion"
        Me.txtIdCancelacion.NombreCampo = "IdCancelacion"
        Me.txtIdCancelacion.Obligatorio = True
        Me.txtIdCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCancelacion.Size = New System.Drawing.Size(300, 20)
        Me.txtIdCancelacion.SoloLectura = False
        Me.txtIdCancelacion.TabIndex = 0
        Me.txtIdCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCancelacion.Valor = ""
        '
        'txtNombreCancelacion
        '
        Me.txtNombreCancelacion.CampoBusqueda = True
        Me.txtNombreCancelacion.CampoEsLlave = False
        Me.txtNombreCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCancelacion.ControlBackColor = System.Drawing.Color.White
        Me.txtNombreCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCancelacion.FechaActual = False
        Me.txtNombreCancelacion.Formato = ""
        Me.txtNombreCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCancelacion.LabelText = "Nombre Cancelación"
        Me.txtNombreCancelacion.LabelWidth = 125
        Me.txtNombreCancelacion.Location = New System.Drawing.Point(24, 107)
        Me.txtNombreCancelacion.MaxLength = 150
        Me.txtNombreCancelacion.Name = "txtNombreCancelacion"
        Me.txtNombreCancelacion.NombreCampo = "NombreCancelacion"
        Me.txtNombreCancelacion.Obligatorio = True
        Me.txtNombreCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCancelacion.Size = New System.Drawing.Size(626, 20)
        Me.txtNombreCancelacion.SoloLectura = False
        Me.txtNombreCancelacion.TabIndex = 1
        Me.txtNombreCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCancelacion.Valor = ""
        '
        'cboCancelaFacturas
        '
        Me.cboCancelaFacturas.CampoAutoCompletar = 0
        Me.cboCancelaFacturas.CampoBusqueda = False
        Me.cboCancelaFacturas.CampoDisplay = 1
        Me.cboCancelaFacturas.CampoEsLlave = False
        Me.cboCancelaFacturas.CampoValor = 0
        Me.cboCancelaFacturas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCancelaFacturas.ControlBackColor = System.Drawing.Color.White
        Me.cboCancelaFacturas.ControlForeColor = System.Drawing.Color.Black
        Me.cboCancelaFacturas.FilasVisibles = 7
        Me.cboCancelaFacturas.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboCancelaFacturas.LabelText = "Cancelar Facturas Pendientes de Pago"
        Me.cboCancelaFacturas.LabelWidth = 200
        Me.cboCancelaFacturas.Lista = "S Si|N No"
        Me.cboCancelaFacturas.Location = New System.Drawing.Point(24, 163)
        Me.cboCancelaFacturas.Name = "cboCancelaFacturas"
        Me.cboCancelaFacturas.NombreCampo = "CancelaFacturas"
        Me.cboCancelaFacturas.Obligatorio = False
        Me.cboCancelaFacturas.Query = ""
        Me.cboCancelaFacturas.SelectIndex = -1
        Me.cboCancelaFacturas.Size = New System.Drawing.Size(300, 20)
        Me.cboCancelaFacturas.SoloLectura = False
        Me.cboCancelaFacturas.StringConection = ""
        Me.cboCancelaFacturas.TabIndex = 2
        Me.cboCancelaFacturas.TextoNuevoItem = ""
        Me.cboCancelaFacturas.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboCancelaFacturas.Valor = Nothing
        '
        'cboCancelaSiniestros
        '
        Me.cboCancelaSiniestros.CampoAutoCompletar = 0
        Me.cboCancelaSiniestros.CampoBusqueda = False
        Me.cboCancelaSiniestros.CampoDisplay = 1
        Me.cboCancelaSiniestros.CampoEsLlave = False
        Me.cboCancelaSiniestros.CampoValor = 0
        Me.cboCancelaSiniestros.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCancelaSiniestros.ControlBackColor = System.Drawing.Color.White
        Me.cboCancelaSiniestros.ControlForeColor = System.Drawing.Color.Black
        Me.cboCancelaSiniestros.FilasVisibles = 7
        Me.cboCancelaSiniestros.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboCancelaSiniestros.LabelText = "Anular Reclamos Pendientes"
        Me.cboCancelaSiniestros.LabelWidth = 200
        Me.cboCancelaSiniestros.Lista = "S Si|N No"
        Me.cboCancelaSiniestros.Location = New System.Drawing.Point(24, 189)
        Me.cboCancelaSiniestros.Name = "cboCancelaSiniestros"
        Me.cboCancelaSiniestros.NombreCampo = "CancelaSiniestros"
        Me.cboCancelaSiniestros.Obligatorio = False
        Me.cboCancelaSiniestros.Query = ""
        Me.cboCancelaSiniestros.SelectIndex = -1
        Me.cboCancelaSiniestros.Size = New System.Drawing.Size(300, 20)
        Me.cboCancelaSiniestros.SoloLectura = False
        Me.cboCancelaSiniestros.StringConection = ""
        Me.cboCancelaSiniestros.TabIndex = 3
        Me.cboCancelaSiniestros.TextoNuevoItem = ""
        Me.cboCancelaSiniestros.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboCancelaSiniestros.Valor = ""
        '
        'cboCancelaFlujos
        '
        Me.cboCancelaFlujos.CampoAutoCompletar = 0
        Me.cboCancelaFlujos.CampoBusqueda = False
        Me.cboCancelaFlujos.CampoDisplay = 1
        Me.cboCancelaFlujos.CampoEsLlave = False
        Me.cboCancelaFlujos.CampoValor = 0
        Me.cboCancelaFlujos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboCancelaFlujos.ControlBackColor = System.Drawing.Color.White
        Me.cboCancelaFlujos.ControlForeColor = System.Drawing.Color.Black
        Me.cboCancelaFlujos.FilasVisibles = 7
        Me.cboCancelaFlujos.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboCancelaFlujos.LabelText = "Finalizar Flujos Pendientes"
        Me.cboCancelaFlujos.LabelWidth = 200
        Me.cboCancelaFlujos.Lista = "S Si|N No"
        Me.cboCancelaFlujos.Location = New System.Drawing.Point(24, 215)
        Me.cboCancelaFlujos.Name = "cboCancelaFlujos"
        Me.cboCancelaFlujos.NombreCampo = "CancelaFlujos"
        Me.cboCancelaFlujos.Obligatorio = False
        Me.cboCancelaFlujos.Query = ""
        Me.cboCancelaFlujos.SelectIndex = -1
        Me.cboCancelaFlujos.Size = New System.Drawing.Size(300, 20)
        Me.cboCancelaFlujos.SoloLectura = False
        Me.cboCancelaFlujos.StringConection = ""
        Me.cboCancelaFlujos.TabIndex = 4
        Me.cboCancelaFlujos.TextoNuevoItem = ""
        Me.cboCancelaFlujos.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboCancelaFlujos.Valor = ""
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(24, 141)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(214, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Acciones a Tomar al Cancelar la Póliza"
        '
        'TiposCancelaMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(662, 291)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboCancelaFlujos)
        Me.Controls.Add(Me.cboCancelaSiniestros)
        Me.Controls.Add(Me.cboCancelaFacturas)
        Me.Controls.Add(Me.txtNombreCancelacion)
        Me.Controls.Add(Me.txtIdCancelacion)
        Me.Name = "TiposCancelaMan"
        Me.Text = "Tipos Cancelación"
        Me.Controls.SetChildIndex(Me.txtIdCancelacion, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCancelacion, 0)
        Me.Controls.SetChildIndex(Me.cboCancelaFacturas, 0)
        Me.Controls.SetChildIndex(Me.cboCancelaSiniestros, 0)
        Me.Controls.SetChildIndex(Me.cboCancelaFlujos, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCancelacion As STIControles.stiTextBox
    Friend WithEvents txtNombreCancelacion As STIControles.stiTextBox
    Friend WithEvents cboCancelaFacturas As STIControles.stiComboBox
    Friend WithEvents cboCancelaSiniestros As STIControles.stiComboBox
    Friend WithEvents cboCancelaFlujos As STIControles.stiComboBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl

End Class
