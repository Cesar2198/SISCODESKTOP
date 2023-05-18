<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepClienteTarjetas
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
        Me.cboEjecutivo = New STIControles.stiComboBox
        Me.chkPago = New DevExpress.XtraEditors.CheckEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(315, 170)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(212, 170)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(418, 170)
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
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.Size = New System.Drawing.Size(384, 74)
        Me.LabelControl1.Text = "Reporte de Clientes de Pagos con Tarjetas"
        '
        'cboEjecutivo
        '
        Me.cboEjecutivo.CampoAutoCompletar = 0
        Me.cboEjecutivo.CampoBusqueda = False
        Me.cboEjecutivo.CampoDisplay = 1
        Me.cboEjecutivo.CampoEsLlave = False
        Me.cboEjecutivo.CampoValor = 0
        Me.cboEjecutivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjecutivo.ControlBackColor = System.Drawing.Color.White
        Me.cboEjecutivo.ControlForeColor = System.Drawing.Color.Black
        Me.cboEjecutivo.FilasVisibles = 7
        Me.cboEjecutivo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivo.LabelText = "Ejecutivo"
        Me.cboEjecutivo.LabelWidth = 100
        Me.cboEjecutivo.Lista = ""
        Me.cboEjecutivo.Location = New System.Drawing.Point(21, 102)
        Me.cboEjecutivo.Name = "cboEjecutivo"
        Me.cboEjecutivo.NombreCampo = ""
        Me.cboEjecutivo.Obligatorio = False
        Me.cboEjecutivo.Query = "select IdUsuario as Id, NombreUsuario as Ejecutivo from Usuarios where EsEjecutiv" & _
            "o = 'S' order by NombreUsuario"
        Me.cboEjecutivo.SelectIndex = -1
        Me.cboEjecutivo.Size = New System.Drawing.Size(479, 20)
        Me.cboEjecutivo.SoloLectura = False
        Me.cboEjecutivo.StringConection = ""
        Me.cboEjecutivo.TabIndex = 17
        Me.cboEjecutivo.TextoNuevoItem = ""
        Me.cboEjecutivo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivo.Valor = ""
        '
        'chkPago
        '
        Me.chkPago.EditValue = True
        Me.chkPago.Location = New System.Drawing.Point(121, 128)
        Me.chkPago.Name = "chkPago"
        Me.chkPago.Properties.Caption = "Con Facturas Pendientes de Pago"
        Me.chkPago.Size = New System.Drawing.Size(194, 19)
        Me.chkPago.TabIndex = 18
        '
        'RepClienteTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 514
        Me.ClientSize = New System.Drawing.Size(521, 208)
        Me.Controls.Add(Me.chkPago)
        Me.Controls.Add(Me.cboEjecutivo)
        Me.Name = "RepClienteTarjetas"
        Me.Text = "Reporte Clientes"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivo, 0)
        Me.Controls.SetChildIndex(Me.chkPago, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboEjecutivo As STIControles.stiComboBox
    Friend WithEvents chkPago As DevExpress.XtraEditors.CheckEdit

End Class
