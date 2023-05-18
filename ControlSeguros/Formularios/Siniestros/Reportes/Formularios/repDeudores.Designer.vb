<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repDeudores
    Inherits stiFomularios.stiReportes

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
        Me.txtFechaCorte = New STIControles.stiTextBox
        Me.cboAseguradora = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(297, 172)
        Me.btnAyuda.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(194, 172)
        Me.btnImprimir.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(400, 172)
        Me.btnSalir.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Reporte de Saldos Deudores Varios"
        '
        'txtFechaCorte
        '
        Me.txtFechaCorte.CampoBusqueda = False
        Me.txtFechaCorte.CampoEsLlave = False
        Me.txtFechaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaCorte.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaCorte.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaCorte.FechaActual = True
        Me.txtFechaCorte.Formato = "dd/MMM/yyyy"
        Me.txtFechaCorte.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaCorte.LabelText = "Fecha de Corte"
        Me.txtFechaCorte.LabelWidth = 100
        Me.txtFechaCorte.Location = New System.Drawing.Point(34, 92)
        Me.txtFechaCorte.MaxLength = 0
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.NombreCampo = ""
        Me.txtFechaCorte.Obligatorio = True
        Me.txtFechaCorte.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaCorte.Size = New System.Drawing.Size(300, 20)
        Me.txtFechaCorte.SoloLectura = False
        Me.txtFechaCorte.TabIndex = 0
        Me.txtFechaCorte.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaCorte.Valor = Nothing
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = False
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = False
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 7
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 100
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(34, 118)
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = ""
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select idaseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nomb" & _
            "re"
        Me.cboAseguradora.SelectIndex = -1
        Me.cboAseguradora.Size = New System.Drawing.Size(457, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 1
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'repDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 816
        Me.ClientSize = New System.Drawing.Size(503, 210)
        Me.Controls.Add(Me.txtFechaCorte)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Name = "repDeudores"
        Me.Text = "Deudores Varios"
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.txtFechaCorte, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaCorte As STIControles.stiTextBox
    Friend WithEvents cboAseguradora As STIControles.stiComboBox

End Class
