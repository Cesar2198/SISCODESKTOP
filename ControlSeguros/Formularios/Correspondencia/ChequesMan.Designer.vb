<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChequesMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChequesMan))
        Me.txtIdFlujoDoc = New STIControles.stiTextBox
        Me.txtIdImpresion = New STIControles.stiTextBox
        Me.txtIdCheque = New STIControles.stiTextBox
        Me.cboIdBanco = New STIControles.stiComboBox
        Me.txtBeneficiario = New STIControles.stiTextBox
        Me.txtNumCheque = New STIControles.stiTextBox
        Me.txtConcepto = New STIControles.stiTextBox
        Me.txtAnexo = New STIControles.stiTextBox
        Me.txtValor = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(489, 258)
        Me.btnAyuda.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(309, 284)
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Location = New System.Drawing.Point(32, 284)
        Me.btnNuevo.Size = New System.Drawing.Size(10, 10)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(393, 258)
        Me.btnGuardar.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(585, 258)
        Me.btnSalir.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(401, 284)
        Me.btnEliminar.Size = New System.Drawing.Size(10, 10)
        Me.btnEliminar.TabIndex = 7
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
        Me.lblNombreFormulario.Size = New System.Drawing.Size(540, 74)
        Me.lblNombreFormulario.TabIndex = 16
        Me.lblNombreFormulario.Text = "Actualización de Cheques de Ingreso"
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
        Me.btnGuardarComo.Location = New System.Drawing.Point(217, 284)
        Me.btnGuardarComo.Size = New System.Drawing.Size(10, 10)
        Me.btnGuardarComo.TabIndex = 14
        Me.btnGuardarComo.Visible = False
        '
        'txtIdFlujoDoc
        '
        Me.txtIdFlujoDoc.CampoBusqueda = True
        Me.txtIdFlujoDoc.CampoEsLlave = True
        Me.txtIdFlujoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdFlujoDoc.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdFlujoDoc.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdFlujoDoc.FechaActual = False
        Me.txtIdFlujoDoc.Formato = ""
        Me.txtIdFlujoDoc.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdFlujoDoc.LabelText = "Cod. Flujo"
        Me.txtIdFlujoDoc.LabelWidth = 150
        Me.txtIdFlujoDoc.Location = New System.Drawing.Point(15, 81)
        Me.txtIdFlujoDoc.MaxLength = 25
        Me.txtIdFlujoDoc.Name = "txtIdFlujoDoc"
        Me.txtIdFlujoDoc.NombreCampo = "IdFlujoDoc"
        Me.txtIdFlujoDoc.Obligatorio = True
        Me.txtIdFlujoDoc.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdFlujoDoc.Size = New System.Drawing.Size(326, 20)
        Me.txtIdFlujoDoc.SoloLectura = True
        Me.txtIdFlujoDoc.TabIndex = 10
        Me.txtIdFlujoDoc.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdFlujoDoc.Valor = ""
        '
        'txtIdImpresion
        '
        Me.txtIdImpresion.CampoBusqueda = True
        Me.txtIdImpresion.CampoEsLlave = True
        Me.txtIdImpresion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdImpresion.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdImpresion.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdImpresion.FechaActual = False
        Me.txtIdImpresion.Formato = ""
        Me.txtIdImpresion.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdImpresion.LabelText = "Cod. Correspondencia"
        Me.txtIdImpresion.LabelWidth = 150
        Me.txtIdImpresion.Location = New System.Drawing.Point(347, 81)
        Me.txtIdImpresion.MaxLength = 25
        Me.txtIdImpresion.Name = "txtIdImpresion"
        Me.txtIdImpresion.NombreCampo = "IdImpresion"
        Me.txtIdImpresion.Obligatorio = True
        Me.txtIdImpresion.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdImpresion.Size = New System.Drawing.Size(326, 20)
        Me.txtIdImpresion.SoloLectura = True
        Me.txtIdImpresion.TabIndex = 11
        Me.txtIdImpresion.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdImpresion.Valor = ""
        '
        'txtIdCheque
        '
        Me.txtIdCheque.CampoBusqueda = False
        Me.txtIdCheque.CampoEsLlave = True
        Me.txtIdCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdCheque.ControlBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtIdCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdCheque.FechaActual = False
        Me.txtIdCheque.Formato = ""
        Me.txtIdCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdCheque.LabelText = "Cod. Cheque"
        Me.txtIdCheque.LabelWidth = 150
        Me.txtIdCheque.Location = New System.Drawing.Point(15, 104)
        Me.txtIdCheque.MaxLength = 25
        Me.txtIdCheque.Name = "txtIdCheque"
        Me.txtIdCheque.NombreCampo = "IdCheque"
        Me.txtIdCheque.Obligatorio = True
        Me.txtIdCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCheque.Size = New System.Drawing.Size(326, 20)
        Me.txtIdCheque.SoloLectura = True
        Me.txtIdCheque.TabIndex = 12
        Me.txtIdCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdCheque.Valor = ""
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
        Me.cboIdBanco.FilasVisibles = 0
        Me.cboIdBanco.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdBanco.LabelText = "Banco"
        Me.cboIdBanco.LabelWidth = 150
        Me.cboIdBanco.Lista = ""
        Me.cboIdBanco.Location = New System.Drawing.Point(15, 127)
        Me.cboIdBanco.MostrarBusquedaColumnas = False
        Me.cboIdBanco.Name = "cboIdBanco"
        Me.cboIdBanco.NombreCampo = "IdBanco"
        Me.cboIdBanco.Obligatorio = False
        Me.cboIdBanco.Query = "select IdBanco as Id, NombreBanco as Banco from Bancos"
        Me.cboIdBanco.SelectIndex = 0
        Me.cboIdBanco.Size = New System.Drawing.Size(658, 20)
        Me.cboIdBanco.SoloLectura = False
        Me.cboIdBanco.StringConection = ""
        Me.cboIdBanco.TabIndex = 0
        Me.cboIdBanco.TextoNuevoItem = ""
        Me.cboIdBanco.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdBanco.Valor = ""
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.CampoBusqueda = True
        Me.txtBeneficiario.CampoEsLlave = False
        Me.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBeneficiario.ControlBackColor = System.Drawing.Color.White
        Me.txtBeneficiario.ControlForeColor = System.Drawing.Color.Black
        Me.txtBeneficiario.FechaActual = False
        Me.txtBeneficiario.Formato = ""
        Me.txtBeneficiario.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtBeneficiario.LabelText = "Beneficiario"
        Me.txtBeneficiario.LabelWidth = 150
        Me.txtBeneficiario.Location = New System.Drawing.Point(15, 150)
        Me.txtBeneficiario.MaxLength = 500
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.NombreCampo = "Beneficiario"
        Me.txtBeneficiario.Obligatorio = False
        Me.txtBeneficiario.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBeneficiario.Size = New System.Drawing.Size(658, 20)
        Me.txtBeneficiario.SoloLectura = False
        Me.txtBeneficiario.TabIndex = 1
        Me.txtBeneficiario.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtBeneficiario.Valor = ""
        '
        'txtNumCheque
        '
        Me.txtNumCheque.CampoBusqueda = False
        Me.txtNumCheque.CampoEsLlave = False
        Me.txtNumCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNumCheque.ControlBackColor = System.Drawing.Color.White
        Me.txtNumCheque.ControlForeColor = System.Drawing.Color.Black
        Me.txtNumCheque.FechaActual = False
        Me.txtNumCheque.Formato = ""
        Me.txtNumCheque.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNumCheque.LabelText = "No. Cheque"
        Me.txtNumCheque.LabelWidth = 150
        Me.txtNumCheque.Location = New System.Drawing.Point(15, 219)
        Me.txtNumCheque.MaxLength = 50
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.NombreCampo = "NumCheque"
        Me.txtNumCheque.Obligatorio = False
        Me.txtNumCheque.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCheque.Size = New System.Drawing.Size(326, 20)
        Me.txtNumCheque.SoloLectura = False
        Me.txtNumCheque.TabIndex = 4
        Me.txtNumCheque.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNumCheque.Valor = ""
        '
        'txtConcepto
        '
        Me.txtConcepto.CampoBusqueda = False
        Me.txtConcepto.CampoEsLlave = False
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtConcepto.ControlBackColor = System.Drawing.Color.White
        Me.txtConcepto.ControlForeColor = System.Drawing.Color.Black
        Me.txtConcepto.FechaActual = False
        Me.txtConcepto.Formato = ""
        Me.txtConcepto.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtConcepto.LabelText = "Concepto"
        Me.txtConcepto.LabelWidth = 150
        Me.txtConcepto.Location = New System.Drawing.Point(15, 173)
        Me.txtConcepto.MaxLength = 250
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.NombreCampo = "Concepto"
        Me.txtConcepto.Obligatorio = False
        Me.txtConcepto.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConcepto.Size = New System.Drawing.Size(658, 20)
        Me.txtConcepto.SoloLectura = False
        Me.txtConcepto.TabIndex = 2
        Me.txtConcepto.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtConcepto.Valor = ""
        '
        'txtAnexo
        '
        Me.txtAnexo.CampoBusqueda = False
        Me.txtAnexo.CampoEsLlave = False
        Me.txtAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAnexo.ControlBackColor = System.Drawing.Color.White
        Me.txtAnexo.ControlForeColor = System.Drawing.Color.Black
        Me.txtAnexo.FechaActual = False
        Me.txtAnexo.Formato = ""
        Me.txtAnexo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtAnexo.LabelText = "Anexos"
        Me.txtAnexo.LabelWidth = 150
        Me.txtAnexo.Location = New System.Drawing.Point(15, 196)
        Me.txtAnexo.MaxLength = 250
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.NombreCampo = "Anexo"
        Me.txtAnexo.Obligatorio = False
        Me.txtAnexo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAnexo.Size = New System.Drawing.Size(658, 20)
        Me.txtAnexo.SoloLectura = False
        Me.txtAnexo.TabIndex = 3
        Me.txtAnexo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtAnexo.Valor = ""
        '
        'txtValor
        '
        Me.txtValor.CampoBusqueda = False
        Me.txtValor.CampoEsLlave = False
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtValor.ControlBackColor = System.Drawing.Color.White
        Me.txtValor.ControlForeColor = System.Drawing.Color.Black
        Me.txtValor.FechaActual = False
        Me.txtValor.Formato = "#,###0.00"
        Me.txtValor.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtValor.LabelText = "Monto del Cheque"
        Me.txtValor.LabelWidth = 150
        Me.txtValor.Location = New System.Drawing.Point(347, 219)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.NombreCampo = "Valor"
        Me.txtValor.Obligatorio = False
        Me.txtValor.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValor.Size = New System.Drawing.Size(326, 20)
        Me.txtValor.SoloLectura = False
        Me.txtValor.TabIndex = 5
        Me.txtValor.TipoDato = STIControles.stiTextBox.TipoContenido.Numero
        Me.txtValor.Valor = 0
        '
        'ChequesMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(679, 294)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtAnexo)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtNumCheque)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.cboIdBanco)
        Me.Controls.Add(Me.txtIdCheque)
        Me.Controls.Add(Me.txtIdImpresion)
        Me.Controls.Add(Me.txtIdFlujoDoc)
        Me.Name = "ChequesMan"
        Me.Text = "Cheques de Ingreso"
        Me.Controls.SetChildIndex(Me.txtIdFlujoDoc, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnGuardar, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.btnEliminar, 0)
        Me.Controls.SetChildIndex(Me.lblNombreFormulario, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.btnGuardarComo, 0)
        Me.Controls.SetChildIndex(Me.txtIdImpresion, 0)
        Me.Controls.SetChildIndex(Me.txtIdCheque, 0)
        Me.Controls.SetChildIndex(Me.cboIdBanco, 0)
        Me.Controls.SetChildIndex(Me.txtBeneficiario, 0)
        Me.Controls.SetChildIndex(Me.txtNumCheque, 0)
        Me.Controls.SetChildIndex(Me.txtConcepto, 0)
        Me.Controls.SetChildIndex(Me.txtAnexo, 0)
        Me.Controls.SetChildIndex(Me.txtValor, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdFlujoDoc As STIControles.stiTextBox
    Friend WithEvents txtIdImpresion As STIControles.stiTextBox
    Friend WithEvents txtIdCheque As STIControles.stiTextBox
    Friend WithEvents cboIdBanco As STIControles.stiComboBox
    Friend WithEvents txtBeneficiario As STIControles.stiTextBox
    Friend WithEvents txtNumCheque As STIControles.stiTextBox
    Friend WithEvents txtConcepto As STIControles.stiTextBox
    Friend WithEvents txtAnexo As STIControles.stiTextBox
    Friend WithEvents txtValor As STIControles.stiTextBox

End Class
