<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReactivarPoliza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReactivarPoliza))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtPoliza = New STIControles.stiTextBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtCliente = New STIControles.stiTextBox
        Me.btnBuscarPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaCancelacion = New STIControles.stiTextBox
        Me.txtRazonCancela = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(426, 287)
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(213, 312)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 11)
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(181, 312)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 11)
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(278, 287)
        Me.btnGuardar.Size = New System.Drawing.Size(148, 36)
        Me.btnGuardar.Text = "&Reactivar Póliza"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(518, 287)
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(229, 312)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 11)
        Me.btnEliminar.Visible = False
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(473, 74)
        Me.lblNombreFormulario.Text = "Proceso de Reactivación de Póliza"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(197, 312)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 11)
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
        Me.LabelControl2.Location = New System.Drawing.Point(28, 89)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(530, 48)
        Me.LabelControl2.TabIndex = 30
        Me.LabelControl2.Text = "Este programa Reactiva una póliza que se encuentra cancelada y habilita los certi" & _
            "ficados que fueron cancelados junto con la póliza."
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
        Me.txtPoliza.LabelWidth = 125
        Me.txtPoliza.Location = New System.Drawing.Point(12, 147)
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
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 125
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(12, 173)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = True
        Me.cboProducto.Query = "select idproducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = -1
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
        Me.txtCliente.LabelWidth = 125
        Me.txtCliente.Location = New System.Drawing.Point(12, 199)
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
        Me.btnBuscarPoliza.Location = New System.Drawing.Point(322, 143)
        Me.btnBuscarPoliza.Name = "btnBuscarPoliza"
        Me.btnBuscarPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscarPoliza.TabIndex = 34
        Me.btnBuscarPoliza.Text = "Buscar Póliza"
        '
        'txtFechaCancelacion
        '
        Me.txtFechaCancelacion.CampoBusqueda = False
        Me.txtFechaCancelacion.CampoEsLlave = False
        Me.txtFechaCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCancelacion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFechaCancelacion.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCancelacion.FechaActual = True
        Me.txtFechaCancelacion.Formato = "Long Date"
        Me.txtFechaCancelacion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCancelacion.LabelText = "Fecha Cancelación"
        Me.txtFechaCancelacion.LabelWidth = 125
        Me.txtFechaCancelacion.Location = New System.Drawing.Point(12, 252)
        Me.txtFechaCancelacion.MaxLength = 50
        Me.txtFechaCancelacion.Name = "txtFechaCancelacion"
        Me.txtFechaCancelacion.NombreCampo = ""
        Me.txtFechaCancelacion.Obligatorio = True
        Me.txtFechaCancelacion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCancelacion.Size = New System.Drawing.Size(566, 20)
        Me.txtFechaCancelacion.SoloLectura = True
        Me.txtFechaCancelacion.TabIndex = 36
        Me.txtFechaCancelacion.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCancelacion.Valor = Nothing
        '
        'txtRazonCancela
        '
        Me.txtRazonCancela.CampoBusqueda = False
        Me.txtRazonCancela.CampoEsLlave = False
        Me.txtRazonCancela.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRazonCancela.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtRazonCancela.ControlForeColor = System.Drawing.Color.Black
        Me.txtRazonCancela.FechaActual = False
        Me.txtRazonCancela.Formato = ""
        Me.txtRazonCancela.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtRazonCancela.LabelText = "Motivo Cancelación"
        Me.txtRazonCancela.LabelWidth = 125
        Me.txtRazonCancela.Location = New System.Drawing.Point(12, 226)
        Me.txtRazonCancela.MaxLength = 50
        Me.txtRazonCancela.Name = "txtRazonCancela"
        Me.txtRazonCancela.NombreCampo = ""
        Me.txtRazonCancela.Obligatorio = True
        Me.txtRazonCancela.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazonCancela.Size = New System.Drawing.Size(566, 20)
        Me.txtRazonCancela.SoloLectura = True
        Me.txtRazonCancela.TabIndex = 35
        Me.txtRazonCancela.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtRazonCancela.Valor = ""
        '
        'ReactivarPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 533
        Me.ClientSize = New System.Drawing.Size(612, 323)
        Me.Controls.Add(Me.txtFechaCancelacion)
        Me.Controls.Add(Me.txtRazonCancela)
        Me.Controls.Add(Me.btnBuscarPoliza)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "ReactivarPoliza"
        Me.Text = "Reactivar Póliza"
        Me.UsarCodigoHeredado = False
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.txtCliente, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtRazonCancela, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCancelacion, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPoliza As STIControles.stiTextBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtCliente As STIControles.stiTextBox
    Friend WithEvents btnBuscarPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaCancelacion As STIControles.stiTextBox
    Friend WithEvents txtRazonCancela As STIControles.stiTextBox

End Class
