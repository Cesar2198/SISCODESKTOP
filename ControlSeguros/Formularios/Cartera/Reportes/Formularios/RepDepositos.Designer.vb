﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepDepositos
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
        Me.txtFechaHasta = New STIControles.stiTextBox
        Me.txtFechaDesde = New STIControles.stiTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAyuda.Appearance.Options.UseFont = True
        Me.btnAyuda.Location = New System.Drawing.Point(240, 170)
        Me.btnAyuda.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(137, 170)
        Me.btnImprimir.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(343, 170)
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
        Me.LabelControl1.Size = New System.Drawing.Size(309, 74)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Reporte Depósitos de Clientes"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CampoBusqueda = False
        Me.txtFechaHasta.CampoEsLlave = False
        Me.txtFechaHasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFechaHasta.ControlBackColor = System.Drawing.Color.White
        Me.txtFechaHasta.ControlForeColor = System.Drawing.Color.Black
        Me.txtFechaHasta.FechaActual = True
        Me.txtFechaHasta.Formato = "Long Date"
        Me.txtFechaHasta.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaHasta.LabelText = "Fecha Hasta"
        Me.txtFechaHasta.LabelWidth = 100
        Me.txtFechaHasta.Location = New System.Drawing.Point(37, 125)
        Me.txtFechaHasta.MaxLength = 0
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.NombreCampo = ""
        Me.txtFechaHasta.Obligatorio = True
        Me.txtFechaHasta.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaHasta.Size = New System.Drawing.Size(356, 20)
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
        Me.txtFechaDesde.FechaActual = True
        Me.txtFechaDesde.Formato = "Long Date"
        Me.txtFechaDesde.LabelOrietation = STIControles.stiTextBox.LOrientacion.Izquierda
        Me.txtFechaDesde.LabelText = "Fecha Desde"
        Me.txtFechaDesde.LabelWidth = 100
        Me.txtFechaDesde.Location = New System.Drawing.Point(37, 89)
        Me.txtFechaDesde.MaxLength = 0
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.NombreCampo = ""
        Me.txtFechaDesde.Obligatorio = True
        Me.txtFechaDesde.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFechaDesde.Size = New System.Drawing.Size(356, 20)
        Me.txtFechaDesde.SoloLectura = False
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.txtFechaDesde.Valor = Nothing
        '
        'RepDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AyudaId = 308
        Me.ClientSize = New System.Drawing.Size(446, 208)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Name = "RepDepositos"
        Me.Text = "Reporte Depósitos"
        Me.Controls.SetChildIndex(Me.btnSalir, 0)
        Me.Controls.SetChildIndex(Me.btnImprimir, 0)
        Me.Controls.SetChildIndex(Me.btnAyuda, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.txtFechaDesde, 0)
        Me.Controls.SetChildIndex(Me.txtFechaHasta, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaHasta As STIControles.stiTextBox
    Friend WithEvents txtFechaDesde As STIControles.stiTextBox

End Class
