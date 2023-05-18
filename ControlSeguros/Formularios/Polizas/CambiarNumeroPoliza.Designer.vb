<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarNumeroPoliza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarNumeroPoliza))
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtIdPolizaNuevo = New STIControles.stiTextBox
        Me.cboIdProductoNuevo = New STIControles.stiComboBox
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreCliente = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(408, 305)
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(305, 305)
        Me.btnImprimir.Text = "&Cambiar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(511, 305)
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
        Me.LabelControl1.Size = New System.Drawing.Size(477, 74)
        Me.LabelControl1.Text = "Cambios de Número de Póliza o Producto"
        '
        'cboIdProducto
        '
        Me.cboIdProducto.CampoAutoCompletar = 0
        Me.cboIdProducto.CampoBusqueda = True
        Me.cboIdProducto.CampoDisplay = 1
        Me.cboIdProducto.CampoEsLlave = True
        Me.cboIdProducto.CampoValor = 0
        Me.cboIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProducto.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.cboIdProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 100
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(10, 54)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = True
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.Size = New System.Drawing.Size(590, 20)
        Me.cboIdProducto.SoloLectura = True
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 18
        Me.cboIdProducto.TextoNuevoItem = ""
        Me.cboIdProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProducto.Valor = ""
        '
        'txtIdPoliza
        '
        Me.txtIdPoliza.CampoBusqueda = True
        Me.txtIdPoliza.CampoEsLlave = True
        Me.txtIdPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPoliza.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtIdPoliza.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPoliza.FechaActual = False
        Me.txtIdPoliza.Formato = ""
        Me.txtIdPoliza.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPoliza.LabelText = "Número Póliza"
        Me.txtIdPoliza.LabelWidth = 100
        Me.txtIdPoliza.Location = New System.Drawing.Point(10, 28)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = True
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPoliza.SoloLectura = True
        Me.txtIdPoliza.TabIndex = 17
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.txtNombreCliente)
        Me.GroupControl1.Controls.Add(Me.btnBuscaPoliza)
        Me.GroupControl1.Controls.Add(Me.txtIdPoliza)
        Me.GroupControl1.Controls.Add(Me.cboIdProducto)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 80)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(607, 115)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Póliza Actual"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.txtIdPolizaNuevo)
        Me.GroupControl2.Controls.Add(Me.cboIdProductoNuevo)
        Me.GroupControl2.Location = New System.Drawing.Point(4, 206)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(607, 87)
        Me.GroupControl2.TabIndex = 20
        Me.GroupControl2.Text = "Nueva Póliza"
        '
        'txtIdPolizaNuevo
        '
        Me.txtIdPolizaNuevo.CampoBusqueda = True
        Me.txtIdPolizaNuevo.CampoEsLlave = True
        Me.txtIdPolizaNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdPolizaNuevo.ControlBackColor = System.Drawing.Color.White
        Me.txtIdPolizaNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.txtIdPolizaNuevo.FechaActual = False
        Me.txtIdPolizaNuevo.Formato = ""
        Me.txtIdPolizaNuevo.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtIdPolizaNuevo.LabelText = "Número Póliza"
        Me.txtIdPolizaNuevo.LabelWidth = 100
        Me.txtIdPolizaNuevo.Location = New System.Drawing.Point(10, 28)
        Me.txtIdPolizaNuevo.MaxLength = 25
        Me.txtIdPolizaNuevo.Name = "txtIdPolizaNuevo"
        Me.txtIdPolizaNuevo.NombreCampo = "IdPoliza"
        Me.txtIdPolizaNuevo.Obligatorio = True
        Me.txtIdPolizaNuevo.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPolizaNuevo.Size = New System.Drawing.Size(300, 20)
        Me.txtIdPolizaNuevo.SoloLectura = False
        Me.txtIdPolizaNuevo.TabIndex = 17
        Me.txtIdPolizaNuevo.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPolizaNuevo.Valor = ""
        '
        'cboIdProductoNuevo
        '
        Me.cboIdProductoNuevo.CampoAutoCompletar = 0
        Me.cboIdProductoNuevo.CampoBusqueda = True
        Me.cboIdProductoNuevo.CampoDisplay = 1
        Me.cboIdProductoNuevo.CampoEsLlave = True
        Me.cboIdProductoNuevo.CampoValor = 0
        Me.cboIdProductoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboIdProductoNuevo.ControlBackColor = System.Drawing.Color.White
        Me.cboIdProductoNuevo.ControlForeColor = System.Drawing.Color.Black
        Me.cboIdProductoNuevo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProductoNuevo.LabelText = "Producto"
        Me.cboIdProductoNuevo.LabelWidth = 100
        Me.cboIdProductoNuevo.Lista = ""
        Me.cboIdProductoNuevo.Location = New System.Drawing.Point(10, 54)
        Me.cboIdProductoNuevo.Name = "cboIdProductoNuevo"
        Me.cboIdProductoNuevo.NombreCampo = "IdProducto"
        Me.cboIdProductoNuevo.Obligatorio = True
        Me.cboIdProductoNuevo.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProductoNuevo.Size = New System.Drawing.Size(590, 20)
        Me.cboIdProductoNuevo.SoloLectura = False
        Me.cboIdProductoNuevo.StringConection = ""
        Me.cboIdProductoNuevo.TabIndex = 18
        Me.cboIdProductoNuevo.TextoNuevoItem = ""
        Me.cboIdProductoNuevo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboIdProductoNuevo.Valor = ""
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(332, 23)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(107, 27)
        Me.btnBuscaPoliza.TabIndex = 29
        Me.btnBuscaPoliza.Text = "Buscar Póliza"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CampoBusqueda = True
        Me.txtNombreCliente.CampoEsLlave = False
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.ControlBackColor = System.Drawing.Color.Gainsboro
        Me.txtNombreCliente.ControlForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.FechaActual = False
        Me.txtNombreCliente.Formato = ""
        Me.txtNombreCliente.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtNombreCliente.LabelText = "Nombre Cliente"
        Me.txtNombreCliente.LabelWidth = 100
        Me.txtNombreCliente.Location = New System.Drawing.Point(10, 80)
        Me.txtNombreCliente.MaxLength = 150
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.NombreCampo = "NombreCliente"
        Me.txtNombreCliente.Obligatorio = True
        Me.txtNombreCliente.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.Size = New System.Drawing.Size(590, 20)
        Me.txtNombreCliente.SoloLectura = True
        Me.txtNombreCliente.TabIndex = 30
        Me.txtNombreCliente.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtNombreCliente.Valor = ""
        '
        'CambiarNumeroPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(614, 343)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "CambiarNumeroPoliza"
        Me.Text = "Cambios en Pólizas"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtIdPolizaNuevo As STIControles.stiTextBox
    Friend WithEvents cboIdProductoNuevo As STIControles.stiComboBox
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCliente As STIControles.stiTextBox

End Class
