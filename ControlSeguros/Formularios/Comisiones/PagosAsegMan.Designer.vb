<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosAsegMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosAsegMan))
        Me.cboIdAseguradora = New STIControles.stiComboBox
        Me.txtNumeroCheque = New STIControles.stiTextBox
        Me.cboIdBanco = New STIControles.stiComboBox
        Me.txtFechaCheque = New STIControles.stiTextBox
        Me.txtValorCheque = New STIControles.stiTextBox
        Me.txtComentario = New STIControles.stiTextBox
        Me.txtIdPago = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(371, 257)
        Me.btnAyuda.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(187, 257)
        Me.btnBuscar.TabIndex = 8
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(3, 257)
        Me.btnNuevo.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(95, 257)
        Me.btnGuardar.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(463, 257)
        Me.btnSalir.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(279, 257)
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(418, 74)
        Me.lblNombreFormulario.TabIndex = 14
        Me.lblNombreFormulario.Text = "Pagos de Aseguradora"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(-13, 283)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 13
        Me.btnGuardarComo.Visible = False
        '
        'cboIdAseguradora
        '
        Me.cboIdAseguradora.CampoAutoCompletar = 0
        Me.cboIdAseguradora.CampoBusqueda = False
        Me.cboIdAseguradora.CampoDisplay = 1
        Me.cboIdAseguradora.CampoEsLlave = False
        Me.cboIdAseguradora.CampoValor = 0
        Me.cboIdAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboIdAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdAseguradora.FilasVisibles = 7
        Me.cboIdAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdAseguradora.LabelText = "Aseguradora"
        Me.cboIdAseguradora.LabelWidth = 100
        Me.cboIdAseguradora.Lista = ""
        Me.cboIdAseguradora.Location = New System.Drawing.Point(12, 118)
        Me.cboIdAseguradora.Name = "cboIdAseguradora"
        Me.cboIdAseguradora.NombreCampo = "IdAseguradora"
        Me.cboIdAseguradora.Obligatorio = True
        Me.cboIdAseguradora.Query = "select idaseguradora as Id, Nombre from aseguradoras"
        Me.cboIdAseguradora.SelectIndex = -1
        Me.cboIdAseguradora.Size = New System.Drawing.Size(533, 20)
        Me.cboIdAseguradora.SoloLectura = False
        Me.cboIdAseguradora.StringConection = ""
        Me.cboIdAseguradora.TabIndex = 0
        Me.cboIdAseguradora.TextoNuevoItem = ""
        Me.cboIdAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdAseguradora.Valor = ""
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.CampoBusqueda = True
        Me.txtNumeroCheque.CampoEsLlave = False
        Me.txtNumeroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumeroCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtNumeroCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumeroCheque.FechaActual = False
        Me.txtNumeroCheque.Formato = ""
        Me.txtNumeroCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumeroCheque.LabelText = "Número Cheque"
        Me.txtNumeroCheque.LabelWidth = 100
        Me.txtNumeroCheque.Location = New System.Drawing.Point(12, 170)
        Me.txtNumeroCheque.MaxLength = 25
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.NombreCampo = "NumeroCheque"
        Me.txtNumeroCheque.Obligatorio = True
        Me.txtNumeroCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroCheque.Size = New System.Drawing.Size(253, 20)
        Me.txtNumeroCheque.SoloLectura = False
        Me.txtNumeroCheque.TabIndex = 2
        Me.txtNumeroCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumeroCheque.Valor = ""
        '
        'cboIdBanco
        '
        Me.cboIdBanco.CampoAutoCompletar = 0
        Me.cboIdBanco.CampoBusqueda = False
        Me.cboIdBanco.CampoDisplay = 1
        Me.cboIdBanco.CampoEsLlave = False
        Me.cboIdBanco.CampoValor = 0
        Me.cboIdBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdBanco.ControlBackColor = System.Drawing.Color.White
        Me.cboIdBanco.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdBanco.FilasVisibles = 7
        Me.cboIdBanco.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdBanco.LabelText = "Banco"
        Me.cboIdBanco.LabelWidth = 100
        Me.cboIdBanco.Lista = ""
        Me.cboIdBanco.Location = New System.Drawing.Point(12, 144)
        Me.cboIdBanco.Name = "cboIdBanco"
        Me.cboIdBanco.NombreCampo = "IdBanco"
        Me.cboIdBanco.Obligatorio = True
        Me.cboIdBanco.Query = "select idbanco as Id, NombreBanco as Nombre from Bancos"
        Me.cboIdBanco.SelectIndex = -1
        Me.cboIdBanco.Size = New System.Drawing.Size(533, 20)
        Me.cboIdBanco.SoloLectura = False
        Me.cboIdBanco.StringConection = ""
        Me.cboIdBanco.TabIndex = 1
        Me.cboIdBanco.TextoNuevoItem = ""
        Me.cboIdBanco.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdBanco.Valor = ""
        '
        'txtFechaCheque
        '
        Me.txtFechaCheque.CampoBusqueda = True
        Me.txtFechaCheque.CampoEsLlave = False
        Me.txtFechaCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCheque.FechaActual = False
        Me.txtFechaCheque.Formato = "dd/MMM/yyyy"
        Me.txtFechaCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCheque.LabelText = "Fecha de Cheque"
        Me.txtFechaCheque.LabelWidth = 100
        Me.txtFechaCheque.Location = New System.Drawing.Point(292, 170)
        Me.txtFechaCheque.MaxLength = 0
        Me.txtFechaCheque.Name = "txtFechaCheque"
        Me.txtFechaCheque.NombreCampo = "FechaCheque"
        Me.txtFechaCheque.Obligatorio = True
        Me.txtFechaCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCheque.Size = New System.Drawing.Size(253, 20)
        Me.txtFechaCheque.SoloLectura = False
        Me.txtFechaCheque.TabIndex = 3
        Me.txtFechaCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCheque.Valor = Nothing
        '
        'txtValorCheque
        '
        Me.txtValorCheque.CampoBusqueda = True
        Me.txtValorCheque.CampoEsLlave = False
        Me.txtValorCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValorCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtValorCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtValorCheque.FechaActual = False
        Me.txtValorCheque.Formato = "$#,###,###0.00"
        Me.txtValorCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValorCheque.LabelText = "Valor Cheque"
        Me.txtValorCheque.LabelWidth = 100
        Me.txtValorCheque.Location = New System.Drawing.Point(12, 196)
        Me.txtValorCheque.MaxLength = 0
        Me.txtValorCheque.Name = "txtValorCheque"
        Me.txtValorCheque.NombreCampo = "ValorCheque"
        Me.txtValorCheque.Obligatorio = True
        Me.txtValorCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValorCheque.Size = New System.Drawing.Size(253, 20)
        Me.txtValorCheque.SoloLectura = False
        Me.txtValorCheque.TabIndex = 4
        Me.txtValorCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValorCheque.Valor = 0
        '
        'txtComentario
        '
        Me.txtComentario.CampoBusqueda = False
        Me.txtComentario.CampoEsLlave = False
        Me.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtComentario.ControlBackColor = System.Drawing.Color.White
        Me.txtComentario.ControlForeColor = System.Drawing.Color.Black
        Me.txtComentario.FechaActual = False
        Me.txtComentario.Formato = ""
        Me.txtComentario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtComentario.LabelText = "Comentarios"
        Me.txtComentario.LabelWidth = 100
        Me.txtComentario.Location = New System.Drawing.Point(12, 222)
        Me.txtComentario.MaxLength = 250
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.NombreCampo = "Comentario"
        Me.txtComentario.Obligatorio = False
        Me.txtComentario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentario.Size = New System.Drawing.Size(533, 20)
        Me.txtComentario.SoloLectura = False
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtComentario.Valor = ""
        '
        'txtIdPago
        '
        Me.txtIdPago.CampoBusqueda = True
        Me.txtIdPago.CampoEsLlave = True
        Me.txtIdPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPago.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPago.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPago.FechaActual = False
        Me.txtIdPago.Formato = "####0"
        Me.txtIdPago.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPago.LabelText = "Cod. Pago"
        Me.txtIdPago.LabelWidth = 100
        Me.txtIdPago.Location = New System.Drawing.Point(12, 92)
        Me.txtIdPago.MaxLength = 0
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.NombreCampo = "IdPago"
        Me.txtIdPago.Obligatorio = True
        Me.txtIdPago.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPago.Size = New System.Drawing.Size(253, 20)
        Me.txtIdPago.SoloLectura = False
        Me.txtIdPago.TabIndex = 12
        Me.txtIdPago.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtIdPago.Valor = 0
        '
        'PagosAsegMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 608
        Me.ClientSize = New System.Drawing.Size(557, 293)
        Me.Controls.Add(Me.txtIdPago)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.txtValorCheque)
        Me.Controls.Add(Me.txtFechaCheque)
        Me.Controls.Add(Me.cboIdBanco)
        Me.Controls.Add(Me.txtNumeroCheque)
        Me.Controls.Add(Me.cboIdAseguradora)
        Me.Name = "PagosAsegMan"
        Me.Text = "Pagos Aseguradoras"
        Me.Controls.SetChildIndex(Me.cboIdAseguradora, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroCheque, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.cboIdBanco, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCheque, 0)
        Me.Controls.SetChildIndex(Me.txtValorCheque, 0)
        Me.Controls.SetChildIndex(Me.txtComentario, 0)
        Me.Controls.SetChildIndex(Me.txtIdPago, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIdAseguradora As STIControles.stiComboBox
    Friend WithEvents txtNumeroCheque As STIControles.stiTextBox
    Friend WithEvents cboIdBanco As STIControles.stiComboBox
    Friend WithEvents txtFechaCheque As STIControles.stiTextBox
    Friend WithEvents txtValorCheque As STIControles.stiTextBox
    Friend WithEvents txtComentario As STIControles.stiTextBox
    Friend WithEvents txtIdPago As STIControles.stiTextBox

End Class
