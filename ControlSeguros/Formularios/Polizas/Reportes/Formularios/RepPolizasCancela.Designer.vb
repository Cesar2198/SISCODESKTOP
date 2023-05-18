﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPolizasCancela
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepPolizasCancela))
        Me.cboEjecutivo = New STIControles.stiComboBox
        Me.cboProducto = New STIControles.stiComboBox
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.txtFechaDesde = New STIControles.stiTextBox
        Me.cboRamo = New STIControles.stiComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(296, 218)
        Me.btnAyuda.TabIndex = 6
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(193, 218)
        Me.btnImprimir.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(399, 218)
        Me.btnSalir.TabIndex = 7
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
        Me.LabelControl1.Size = New System.Drawing.Size(365, 74)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Reporte de Pólizas Canceladas"
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
        Me.cboEjecutivo.Location = New System.Drawing.Point(12, 184)
        Me.cboEjecutivo.Name = "cboEjecutivo"
        Me.cboEjecutivo.NombreCampo = ""
        Me.cboEjecutivo.Obligatorio = False
        Me.cboEjecutivo.Query = "select IdUsuario as Id, NombreUsuario as Ejecutivo from Usuarios where EsEjecutiv" & _
            "o = 'S' order by NombreUsuario"
        Me.cboEjecutivo.SelectIndex = -1
        Me.cboEjecutivo.Size = New System.Drawing.Size(479, 20)
        Me.cboEjecutivo.SoloLectura = False
        Me.cboEjecutivo.StringConection = ""
        Me.cboEjecutivo.TabIndex = 4
        Me.cboEjecutivo.TextoNuevoItem = ""
        Me.cboEjecutivo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboEjecutivo.Valor = ""
        '
        'cboProducto
        '
        Me.cboProducto.CampoAutoCompletar = 0
        Me.cboProducto.CampoBusqueda = False
        Me.cboProducto.CampoDisplay = 1
        Me.cboProducto.CampoEsLlave = False
        Me.cboProducto.CampoValor = 0
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.ControlBackColor = System.Drawing.Color.White
        Me.cboProducto.ControlForeColor = System.Drawing.Color.Black
        Me.cboProducto.FilasVisibles = 7
        Me.cboProducto.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboProducto.LabelText = "Producto"
        Me.cboProducto.LabelWidth = 100
        Me.cboProducto.Lista = ""
        Me.cboProducto.Location = New System.Drawing.Point(12, 158)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.NombreCampo = ""
        Me.cboProducto.Obligatorio = False
        Me.cboProducto.Query = "select IdProducto as Id, Descripcion as Producto from Productos order by Descripc" & _
            "ion"
        Me.cboProducto.SelectIndex = -1
        Me.cboProducto.Size = New System.Drawing.Size(479, 20)
        Me.cboProducto.SoloLectura = False
        Me.cboProducto.StringConection = ""
        Me.cboProducto.TabIndex = 3
        Me.cboProducto.TextoNuevoItem = ""
        Me.cboProducto.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboProducto.Valor = ""
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = False
        Me.txtFechaHasta.Formato = "Long Date"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(12, 106)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(479, 20)
        Me.txtFechaHasta.SoloLectura = False
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaHasta.Valor = Nothing
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CampoBusqueda = False
        Me.txtFechaDesde.CampoEsLlave = False
        Me.txtFechaDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaDesde.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaDesde.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaDesde.FechaActual = False
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(12, 80)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(479, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'cboRamo
        '
        Me.cboRamo.CampoAutoCompletar = 0
        Me.cboRamo.CampoBusqueda = False
        Me.cboRamo.CampoDisplay = 1
        Me.cboRamo.CampoEsLlave = False
        Me.cboRamo.CampoValor = 0
        Me.cboRamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboRamo.ControlBackColor = System.Drawing.Color.White
        Me.cboRamo.ControlForeColor = System.Drawing.Color.Black
        Me.cboRamo.FilasVisibles = 7
        Me.cboRamo.LabelOrietation = STIControles.stiComboBox.LOrientacion.Izquierda
        Me.cboRamo.LabelText = "Ramo"
        Me.cboRamo.LabelWidth = 100
        Me.cboRamo.Lista = ""
        Me.cboRamo.Location = New System.Drawing.Point(12, 132)
        Me.cboRamo.Name = "cboRamo"
        Me.cboRamo.NombreCampo = ""
        Me.cboRamo.Obligatorio = False
        Me.cboRamo.Query = "select IdRamo as Id, NombreRamo as Ramo from RamoSeguros order by NombreRamo"
        Me.cboRamo.SelectIndex = -1
        Me.cboRamo.Size = New System.Drawing.Size(479, 20)
        Me.cboRamo.SoloLectura = False
        Me.cboRamo.StringConection = ""
        Me.cboRamo.TabIndex = 2
        Me.cboRamo.TextoNuevoItem = ""
        Me.cboRamo.TipoDato = STIControles.stiComboBox.TipoContenido.Texto
        Me.cboRamo.Valor = ""
        '
        'RepPolizasCancela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 518
        Me.ClientSize = New System.Drawing.Size(502, 261)
        Me.Controls.Add(Me.cboEjecutivo)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.cboRamo)
        Me.Name = "RepPolizasCancela"
        Me.Text = "Reporte de Pólizas"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.cboRamo, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.cboEjecutivo, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboEjecutivo As STIControles.stiComboBox
    Friend WithEvents cboProducto As STIControles.stiComboBox
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox
    Friend WithEvents cboRamo As STIControles.stiComboBox

End Class
