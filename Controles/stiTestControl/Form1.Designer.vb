<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.StiTextBox4 = New STIControles.stiTextBox
        Me.StiComboBox1 = New STIControles.stiComboBox
        Me.StiGrid1 = New STIControles.stiGrid
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StiTextBox4
        '
        Me.StiTextBox4.CampoBusqueda = False
        Me.StiTextBox4.CampoEsLlave = False
        Me.StiTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StiTextBox4.FechaActual = False
        Me.StiTextBox4.Formato = "dd/MMM/yyyy"
        Me.StiTextBox4.LabelOrietation = STIControles.stiTextBox.LOrientacion.Superior
        Me.StiTextBox4.LabelText = "Etiqueta"
        Me.StiTextBox4.LabelWidth = 100
        Me.StiTextBox4.Location = New System.Drawing.Point(99, 68)
        Me.StiTextBox4.MaxLength = 0
        Me.StiTextBox4.Name = "StiTextBox4"
        Me.StiTextBox4.NombreCampo = ""
        Me.StiTextBox4.Obligatorio = True
        Me.StiTextBox4.PassWordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StiTextBox4.Size = New System.Drawing.Size(216, 36)
        Me.StiTextBox4.SoloLectura = False
        Me.StiTextBox4.TabIndex = 1
        Me.StiTextBox4.TipoDato = STIControles.stiTextBox.TipoContenido.Fecha
        Me.StiTextBox4.Valor = Nothing
        '
        'StiComboBox1
        '
        Me.StiComboBox1.CampoAutoCompletar = 0
        Me.StiComboBox1.CampoBusqueda = False
        Me.StiComboBox1.CampoDisplay = 1
        Me.StiComboBox1.CampoEsLlave = False
        Me.StiComboBox1.CampoValor = 0
        Me.StiComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.StiComboBox1.LabelOrietation = STIControles.stiComboBox.LOrientacion.Superior
        Me.StiComboBox1.LabelText = "Etiqueta"
        Me.StiComboBox1.LabelWidth = 100
        Me.StiComboBox1.Lista = ""
        Me.StiComboBox1.Location = New System.Drawing.Point(99, 24)
        Me.StiComboBox1.Name = "StiComboBox1"
        Me.StiComboBox1.NombreCampo = ""
        Me.StiComboBox1.Obligatorio = True
        Me.StiComboBox1.Query = "select idramo as [Ramo], nomramo as [Nombre Ramo], ramocontable as [Codigo Contab" & _
            "le] from tab_ramos"
        Me.StiComboBox1.Size = New System.Drawing.Size(393, 38)
        Me.StiComboBox1.SoloLectura = False
        Me.StiComboBox1.StringConection = "Provider=SQLOLEDB;data source=srvproduccion;initial catalog=PISIS_NET;packet size" & _
            "=4096;integrated security=SSPI;persist security info=True;Pooling=False"
        Me.StiComboBox1.TabIndex = 0
        Me.StiComboBox1.TextoNuevoItem = ""
        Me.StiComboBox1.TipoDato = STIControles.stiComboBox.TipoContenido.Numero
        Me.StiComboBox1.Valor = Nothing
        '
        'StiGrid1
        '
        Me.StiGrid1.Location = New System.Drawing.Point(12, 228)
        Me.StiGrid1.MainView = Me.GridView1
        Me.StiGrid1.Name = "StiGrid1"
        Me.StiGrid1.NombreTabla = ""
        Me.StiGrid1.Size = New System.Drawing.Size(594, 266)
        Me.StiGrid1.TabIndex = 3
        Me.StiGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.StiGrid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 506)
        Me.Controls.Add(Me.StiGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StiTextBox4)
        Me.Controls.Add(Me.StiComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StiGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StiTextBox4 As STIControles.stiTextBox
    Friend WithEvents StiComboBox1 As STIControles.stiComboBox
    Friend WithEvents StiGrid1 As STIControles.stiGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView

End Class
