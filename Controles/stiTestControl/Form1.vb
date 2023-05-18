Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        StiComboBox1.Llenar_Combo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StiComboBox1.Text = "302"
    End Sub

    Private Sub StiComboBox1_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles StiComboBox1.ValueChangeOnExit
        'MsgBox(ValorAnterior)
    End Sub

    Private Sub StiTextBox4_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles StiTextBox4.ValueChangeOnExit
        'MsgBox(ValorAnterior)
    End Sub

End Class
