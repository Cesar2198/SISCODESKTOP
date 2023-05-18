<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repRegistroAsegurados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repRegistroAsegurados))
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboClase = New STIControles.stiComboBox
        Me.chkSimilares = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(322, 176)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(219, 176)
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(425, 176)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
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
        Me.LabelControl1.Size = New System.Drawing.Size(391, 74)
        Me.LabelControl1.Text = "Registro de Asegurados y Dependientes"
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(362, 85)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(102, 27)
        Me.btnBuscaPoliza.TabIndex = 31
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.FilasVisibles = 11
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 75
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(12, 115)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(485, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 30
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Póliza"
        Me.txtIdPoliza.LabelWidth = 75
        Me.txtIdPoliza.Location = New System.Drawing.Point(12, 92)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(244, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 29
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboClase
        '
        Me.cboClase.CampoAutoCompletar = 0
        Me.cboClase.CampoBusqueda = True
        Me.cboClase.CampoDisplay = 1
        Me.cboClase.CampoEsLlave = True
        Me.cboClase.CampoValor = 0
        Me.cboClase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboClase.ControlBackColor = System.Drawing.Color.White
        Me.cboClase.ControlForeColor = System.Drawing.Color.Black
        Me.cboClase.FilasVisibles = 11
        Me.cboClase.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboClase.LabelText = "Clase"
        Me.cboClase.LabelWidth = 75
        Me.cboClase.Lista = ""
        Me.cboClase.Location = New System.Drawing.Point(12, 141)
        Me.cboClase.MostrarBusquedaColumnas = False
        Me.cboClase.Name = "cboClase"
        Me.cboClase.NombreCampo = ""
        Me.cboClase.Obligatorio = False
        Me.cboClase.Query = ""
        Me.cboClase.SelectIndex = 0
        Me.cboClase.Size = New System.Drawing.Size(485, 20)
        Me.cboClase.SoloLectura = False
        Me.cboClase.StringConection = ""
        Me.cboClase.TabIndex = 32
        Me.cboClase.TextoNuevoItem = ""
        Me.cboClase.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboClase.Valor = ""
        '
        'chkSimilares
        '
        Me.chkSimilares.AutoSize = True
        Me.chkSimilares.Location = New System.Drawing.Point(12, 177)
        Me.chkSimilares.Name = "chkSimilares"
        Me.chkSimilares.Size = New System.Drawing.Size(187, 17)
        Me.chkSimilares.TabIndex = 33
        Me.chkSimilares.Text = "Incluir número de pólizas similares"
        Me.chkSimilares.UseVisualStyleBackColor = True
        '
        'repRegistroAsegurados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 812
        Me.ClientSize = New System.Drawing.Size(528, 214)
        Me.Controls.Add(Me.chkSimilares)
        Me.Controls.Add(Me.cboClase)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Name = "repRegistroAsegurados"
        Me.Text = "Reporte Asegurados"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboClase, 0)
        Me.Controls.SetChildIndex(Me.chkSimilares, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboClase As STIControles.stiComboBox
    Friend WithEvents chkSimilares As System.Windows.Forms.CheckBox

End Class
