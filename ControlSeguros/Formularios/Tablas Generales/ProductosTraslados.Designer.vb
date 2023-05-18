<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosTraslados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosTraslados))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cboProductoPrincipal = New STIControles.stiComboBox
        Me.cboProductoUnificado = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(294, 254)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(181, 254)
        Me.btnImprimir.Size = New System.Drawing.Size(113, 36)
        Me.btnImprimir.Text = "&Procesar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(397, 254)
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
        Me.LabelControl1.Text = "Unificación de Productos Duplicados"
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
        Me.LabelControl2.Location = New System.Drawing.Point(8, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(485, 60)
        Me.LabelControl2.TabIndex = 30
        Me.LabelControl2.Text = resources.GetString("LabelControl2.Text")
        '
        'cboProductoPrincipal
        '
        Me.cboProductoPrincipal.CampoAutoCompletar = 0
        Me.cboProductoPrincipal.CampoBusqueda = False
        Me.cboProductoPrincipal.CampoDisplay = 1
        Me.cboProductoPrincipal.CampoEsLlave = False
        Me.cboProductoPrincipal.CampoValor = 0
        Me.cboProductoPrincipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProductoPrincipal.ControlBackColor = System.Drawing.Color.White
        Me.cboProductoPrincipal.ControlForeColor = System.Drawing.Color.Black
        Me.cboProductoPrincipal.FilasVisibles = 7
        Me.cboProductoPrincipal.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboProductoPrincipal.LabelText = "Producto que permanecerá en el sistema"
        Me.cboProductoPrincipal.LabelWidth = 100
        Me.cboProductoPrincipal.Lista = ""
        Me.cboProductoPrincipal.Location = New System.Drawing.Point(8, 146)
        Me.cboProductoPrincipal.Name = "cboProductoPrincipal"
        Me.cboProductoPrincipal.NombreCampo = ""
        Me.cboProductoPrincipal.Obligatorio = True
        Me.cboProductoPrincipal.Query = resources.GetString("cboProductoPrincipal.Query")
        Me.cboProductoPrincipal.SelectIndex = -1
        Me.cboProductoPrincipal.Size = New System.Drawing.Size(485, 38)
        Me.cboProductoPrincipal.SoloLectura = False
        Me.cboProductoPrincipal.StringConection = ""
        Me.cboProductoPrincipal.TabIndex = 31
        Me.cboProductoPrincipal.TextoNuevoItem = ""
        Me.cboProductoPrincipal.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProductoPrincipal.Valor = ""
        '
        'cboProductoUnificado
        '
        Me.cboProductoUnificado.CampoAutoCompletar = 0
        Me.cboProductoUnificado.CampoBusqueda = False
        Me.cboProductoUnificado.CampoDisplay = 1
        Me.cboProductoUnificado.CampoEsLlave = False
        Me.cboProductoUnificado.CampoValor = 0
        Me.cboProductoUnificado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProductoUnificado.ControlBackColor = System.Drawing.Color.White
        Me.cboProductoUnificado.ControlForeColor = System.Drawing.Color.Black
        Me.cboProductoUnificado.FilasVisibles = 7
        Me.cboProductoUnificado.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.cboProductoUnificado.LabelText = "Producto que se unificará y desaparecerá del sistema"
        Me.cboProductoUnificado.LabelWidth = 100
        Me.cboProductoUnificado.Lista = ""
        Me.cboProductoUnificado.Location = New System.Drawing.Point(8, 197)
        Me.cboProductoUnificado.Name = "cboProductoUnificado"
        Me.cboProductoUnificado.NombreCampo = ""
        Me.cboProductoUnificado.Obligatorio = True
        Me.cboProductoUnificado.Query = resources.GetString("cboProductoUnificado.Query")
        Me.cboProductoUnificado.SelectIndex = -1
        Me.cboProductoUnificado.Size = New System.Drawing.Size(485, 38)
        Me.cboProductoUnificado.SoloLectura = False
        Me.cboProductoUnificado.StringConection = ""
        Me.cboProductoUnificado.TabIndex = 32
        Me.cboProductoUnificado.TextoNuevoItem = ""
        Me.cboProductoUnificado.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProductoUnificado.Valor = ""
        '
        'ProductosTraslados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 118
        Me.ClientSize = New System.Drawing.Size(503, 295)
        Me.Controls.Add(Me.cboProductoUnificado)
        Me.Controls.Add(Me.cboProductoPrincipal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "ProductosTraslados"
        Me.Text = "Unificación de Productos"
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.cboProductoPrincipal, 0)
        Me.Controls.SetChildIndex(Me.cboProductoUnificado, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboProductoPrincipal As STIControles.stiComboBox
    Friend WithEvents cboProductoUnificado As STIControles.stiComboBox

End Class
