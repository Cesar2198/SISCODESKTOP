<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repFrmSiniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repFrmSiniestros))
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.optAnulados = New System.Windows.Forms.RadioButton
        Me.optSinTodos = New System.Windows.Forms.RadioButton
        Me.optPagados = New System.Windows.Forms.RadioButton
        Me.optPendientes = New System.Windows.Forms.RadioButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.optFecPresenta = New System.Windows.Forms.RadioButton
        Me.optFecIncurre = New System.Windows.Forms.RadioButton
        Me.btnBuscaPoliza = New DevExpress.XtraEditors.SimpleButton
        Me.cboIdProducto = New STIControles.stiComboBox
        Me.txtIdPoliza = New STIControles.stiTextBox
        Me.cboAseguradora = New STIControles.stiComboBox
        Me.cboRamo = New STIControles.stiComboBox
        Me.cboTipoSeguro = New STIControles.stiComboBox
        Me.cboEjecutivo = New STIControles.stiComboBox
        Me.chkResGrid = New DevExpress.XtraEditors.CheckEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chkResGrid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(256, 372)
        Me.btnAyuda.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(153, 372)
        Me.btnImprimir.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(359, 372)
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
        Me.LabelControl1.Size = New System.Drawing.Size(334, 74)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Reporte de Siniestros"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Inicial"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(10, 82)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(349, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = True
        Me.txtFechaHasta.Formato = ""
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Final"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(10, 104)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(349, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.optAnulados)
        Me.GroupControl1.Controls.Add(Me.optSinTodos)
        Me.GroupControl1.Controls.Add(Me.optPagados)
        Me.GroupControl1.Controls.Add(Me.optPendientes)
        Me.GroupControl1.Location = New System.Drawing.Point(7, 269)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(139, 102)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Opción de Siniestros"
        '
        'optAnulados
        '
        Me.optAnulados.AutoSize = True
        Me.optAnulados.Location = New System.Drawing.Point(5, 60)
        Me.optAnulados.Name = "optAnulados"
        Me.optAnulados.Size = New System.Drawing.Size(118, 17)
        Me.optAnulados.TabIndex = 3
        Me.optAnulados.TabStop = True
        Me.optAnulados.Text = "Siniestros Anulados"
        Me.optAnulados.UseVisualStyleBackColor = True
        '
        'optSinTodos
        '
        Me.optSinTodos.AutoSize = True
        Me.optSinTodos.Checked = True
        Me.optSinTodos.Location = New System.Drawing.Point(5, 79)
        Me.optSinTodos.Name = "optSinTodos"
        Me.optSinTodos.Size = New System.Drawing.Size(119, 17)
        Me.optSinTodos.TabIndex = 2
        Me.optSinTodos.TabStop = True
        Me.optSinTodos.Text = "Todos los Siniestros"
        Me.optSinTodos.UseVisualStyleBackColor = True
        '
        'optPagados
        '
        Me.optPagados.AutoSize = True
        Me.optPagados.Location = New System.Drawing.Point(5, 41)
        Me.optPagados.Name = "optPagados"
        Me.optPagados.Size = New System.Drawing.Size(115, 17)
        Me.optPagados.TabIndex = 1
        Me.optPagados.Text = "Siniestros Pagados"
        Me.optPagados.UseVisualStyleBackColor = True
        '
        'optPendientes
        '
        Me.optPendientes.AutoSize = True
        Me.optPendientes.Location = New System.Drawing.Point(5, 23)
        Me.optPendientes.Name = "optPendientes"
        Me.optPendientes.Size = New System.Drawing.Size(127, 17)
        Me.optPendientes.TabIndex = 0
        Me.optPendientes.Text = "Siniestros Pendientes"
        Me.optPendientes.UseVisualStyleBackColor = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.optFecPresenta)
        Me.GroupControl2.Controls.Add(Me.optFecIncurre)
        Me.GroupControl2.Location = New System.Drawing.Point(153, 269)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(135, 82)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Opción de Fechas"
        '
        'optFecPresenta
        '
        Me.optFecPresenta.AutoSize = True
        Me.optFecPresenta.Location = New System.Drawing.Point(7, 42)
        Me.optFecPresenta.Name = "optFecPresenta"
        Me.optFecPresenta.Size = New System.Drawing.Size(117, 17)
        Me.optFecPresenta.TabIndex = 1
        Me.optFecPresenta.Text = "Fecha Presentados"
        Me.optFecPresenta.UseVisualStyleBackColor = True
        '
        'optFecIncurre
        '
        Me.optFecIncurre.AutoSize = True
        Me.optFecIncurre.Checked = True
        Me.optFecIncurre.Location = New System.Drawing.Point(7, 23)
        Me.optFecIncurre.Name = "optFecIncurre"
        Me.optFecIncurre.Size = New System.Drawing.Size(98, 17)
        Me.optFecIncurre.TabIndex = 0
        Me.optFecIncurre.TabStop = True
        Me.optFecIncurre.Text = "Fecha Ocurrido"
        Me.optFecIncurre.UseVisualStyleBackColor = True
        '
        'btnBuscaPoliza
        '
        Me.btnBuscaPoliza.Image = CType(resources.GetObject("btnBuscaPoliza.Image"), System.Drawing.Image)
        Me.btnBuscaPoliza.Location = New System.Drawing.Point(362, 120)
        Me.btnBuscaPoliza.Name = "btnBuscaPoliza"
        Me.btnBuscaPoliza.Size = New System.Drawing.Size(102, 27)
        Me.btnBuscaPoliza.TabIndex = 34
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
        Me.cboIdProducto.FilasVisibles = 18
        Me.cboIdProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboIdProducto.LabelText = "Producto"
        Me.cboIdProducto.LabelWidth = 75
        Me.cboIdProducto.Lista = ""
        Me.cboIdProducto.Location = New System.Drawing.Point(10, 149)
        Me.cboIdProducto.MostrarBusquedaColumnas = False
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.NombreCampo = "IdProducto"
        Me.cboIdProducto.Obligatorio = False
        Me.cboIdProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboIdProducto.SelectIndex = 0
        Me.cboIdProducto.Size = New System.Drawing.Size(452, 20)
        Me.cboIdProducto.SoloLectura = False
        Me.cboIdProducto.StringConection = ""
        Me.cboIdProducto.TabIndex = 33
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
        Me.txtIdPoliza.Location = New System.Drawing.Point(10, 127)
        Me.txtIdPoliza.MaxLength = 25
        Me.txtIdPoliza.Name = "txtIdPoliza"
        Me.txtIdPoliza.NombreCampo = "IdPoliza"
        Me.txtIdPoliza.Obligatorio = False
        Me.txtIdPoliza.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdPoliza.Size = New System.Drawing.Size(244, 20)
        Me.txtIdPoliza.SoloLectura = False
        Me.txtIdPoliza.TabIndex = 32
        Me.txtIdPoliza.TipoDato = STIControles.stiTextBox.TipoContenido.Texto
        Me.txtIdPoliza.Valor = ""
        '
        'cboAseguradora
        '
        Me.cboAseguradora.CampoAutoCompletar = 0
        Me.cboAseguradora.CampoBusqueda = True
        Me.cboAseguradora.CampoDisplay = 1
        Me.cboAseguradora.CampoEsLlave = True
        Me.cboAseguradora.CampoValor = 0
        Me.cboAseguradora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboAseguradora.ControlBackColor = System.Drawing.Color.White
        Me.cboAseguradora.ControlForeColor = System.Drawing.Color.Black
        Me.cboAseguradora.FilasVisibles = 18
        Me.cboAseguradora.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboAseguradora.LabelText = "Aseguradora"
        Me.cboAseguradora.LabelWidth = 75
        Me.cboAseguradora.Lista = ""
        Me.cboAseguradora.Location = New System.Drawing.Point(10, 172)
        Me.cboAseguradora.MostrarBusquedaColumnas = False
        Me.cboAseguradora.Name = "cboAseguradora"
        Me.cboAseguradora.NombreCampo = "IdAseguradora"
        Me.cboAseguradora.Obligatorio = False
        Me.cboAseguradora.Query = "select IdAseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nomb" & _
            "re"
        Me.cboAseguradora.SelectIndex = 0
        Me.cboAseguradora.Size = New System.Drawing.Size(452, 20)
        Me.cboAseguradora.SoloLectura = False
        Me.cboAseguradora.StringConection = ""
        Me.cboAseguradora.TabIndex = 35
        Me.cboAseguradora.TextoNuevoItem = ""
        Me.cboAseguradora.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboAseguradora.Valor = ""
        '
        'cboRamo
        '
        Me.cboRamo.CampoAutoCompletar = 0
        Me.cboRamo.CampoBusqueda = True
        Me.cboRamo.CampoDisplay = 1
        Me.cboRamo.CampoEsLlave = True
        Me.cboRamo.CampoValor = 0
        Me.cboRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboRamo.FilasVisibles = 18
        Me.cboRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRamo.LabelText = "Ramo"
        Me.cboRamo.LabelWidth = 75
        Me.cboRamo.Lista = ""
        Me.cboRamo.Location = New System.Drawing.Point(10, 195)
        Me.cboRamo.MostrarBusquedaColumnas = False
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NombreCampo = "IdAseguradora"
        Me.cboRamo.Obligatorio = False
        Me.cboRamo.Query = "select IdRamo as Id, NombreRamo as Ramo from RamoSeguros order by NombreRamo"
        Me.cboRamo.SelectIndex = 0
        Me.cboRamo.Size = New System.Drawing.Size(452, 20)
        Me.cboRamo.SoloLectura = False
        Me.cboRamo.StringConection = ""
        Me.cboRamo.TabIndex = 36
        Me.cboRamo.TextoNuevoItem = ""
        Me.cboRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRamo.Valor = ""
        '
        'cboTipoSeguro
        '
        Me.cboTipoSeguro.CampoAutoCompletar = 0
        Me.cboTipoSeguro.CampoBusqueda = True
        Me.cboTipoSeguro.CampoDisplay = 1
        Me.cboTipoSeguro.CampoEsLlave = True
        Me.cboTipoSeguro.CampoValor = 0
        Me.cboTipoSeguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoSeguro.ControlBackColor = System.Drawing.Color.White
        Me.cboTipoSeguro.ControlForeColor = System.Drawing.Color.Black
        Me.cboTipoSeguro.FilasVisibles = 29
        Me.cboTipoSeguro.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboTipoSeguro.LabelText = "Tipo Producto"
        Me.cboTipoSeguro.LabelWidth = 75
        Me.cboTipoSeguro.Lista = "VIDA Seguro de Vida y Gastos Médicos|DAÑOS Seguro de Daños"
        Me.cboTipoSeguro.Location = New System.Drawing.Point(10, 218)
        Me.cboTipoSeguro.MostrarBusquedaColumnas = False
        Me.cboTipoSeguro.Name = "cboTipoSeguro"
        Me.cboTipoSeguro.NombreCampo = "IdAseguradora"
        Me.cboTipoSeguro.Obligatorio = False
        Me.cboTipoSeguro.Query = ""
        Me.cboTipoSeguro.SelectIndex = 0
        Me.cboTipoSeguro.Size = New System.Drawing.Size(452, 20)
        Me.cboTipoSeguro.SoloLectura = False
        Me.cboTipoSeguro.StringConection = ""
        Me.cboTipoSeguro.TabIndex = 37
        Me.cboTipoSeguro.TextoNuevoItem = ""
        Me.cboTipoSeguro.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboTipoSeguro.Valor = ""
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
        Me.cboEjecutivo.FilasVisibles = 29
        Me.cboEjecutivo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboEjecutivo.LabelText = "Ejecutivo"
        Me.cboEjecutivo.LabelWidth = 75
        Me.cboEjecutivo.Lista = ""
        Me.cboEjecutivo.Location = New System.Drawing.Point(10, 242)
        Me.cboEjecutivo.MostrarBusquedaColumnas = False
        Me.cboEjecutivo.Name = "cboEjecutivo"
        Me.cboEjecutivo.NombreCampo = ""
        Me.cboEjecutivo.Obligatorio = False
        Me.cboEjecutivo.Query = "select IdUsuario as Id, NombreUsuario as Ejecutivo from Usuarios where EsEjecutiv" & _
            "o = 'S' order by NombreUsuario"
        Me.cboEjecutivo.SelectIndex = 0
        Me.cboEjecutivo.Size = New System.Drawing.Size(452, 20)
        Me.cboEjecutivo.SoloLectura = False
        Me.cboEjecutivo.StringConection = ""
        Me.cboEjecutivo.TabIndex = 38
        Me.cboEjecutivo.TextoNuevoItem = ""
        Me.cboEjecutivo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivo.Valor = ""
        '
        'chkResGrid
        '
        Me.chkResGrid.Location = New System.Drawing.Point(305, 268)
        Me.chkResGrid.Name = "chkResGrid"
        Me.chkResGrid.Properties.Caption = "Resultados a Grid"
        Me.chkResGrid.Size = New System.Drawing.Size(154, 19)
        Me.chkResGrid.TabIndex = 39
        '
        'repFrmSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 818
        Me.ClientSize = New System.Drawing.Size(471, 414)
        Me.Controls.Add(Me.chkResGrid)
        Me.Controls.Add(Me.cboEjecutivo)
        Me.Controls.Add(Me.cboTipoSeguro)
        Me.Controls.Add(Me.cboRamo)
        Me.Controls.Add(Me.cboAseguradora)
        Me.Controls.Add(Me.btnBuscaPoliza)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.txtIdPoliza)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Name = "repFrmSiniestros"
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        Me.Controls.SetChildIndex(Me.txtIdPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboIdProducto, 0)
        Me.Controls.SetChildIndex(Me.btnBuscaPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboAseguradora, 0)
        Me.Controls.SetChildIndex(Me.cboRamo, 0)
        Me.Controls.SetChildIndex(Me.cboTipoSeguro, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivo, 0)
        Me.Controls.SetChildIndex(Me.chkResGrid, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.chkResGrid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents optSinTodos As System.Windows.Forms.RadioButton
    Friend WithEvents optPagados As System.Windows.Forms.RadioButton
    Friend WithEvents optPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents optFecPresenta As System.Windows.Forms.RadioButton
    Friend WithEvents optFecIncurre As System.Windows.Forms.RadioButton
    Friend WithEvents optAnulados As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscaPoliza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboIdProducto As STIControles.stiComboBox
    Friend WithEvents txtIdPoliza As STIControles.stiTextBox
    Friend WithEvents cboAseguradora As STIControles.stiComboBox
    Friend WithEvents cboRamo As STIControles.stiComboBox
    Friend WithEvents cboTipoSeguro As STIControles.stiComboBox
    Friend WithEvents cboEjecutivo As STIControles.stiComboBox
    Friend WithEvents chkResGrid As DevExpress.XtraEditors.CheckEdit

End Class
