Public Class MetasNav

    Private Sub btnGenMeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenMeta.Click
        Dim frmGM As New MetasGenerar
        frmGM.ShowDialog()
        Me.CargarRegistros()

    End Sub

End Class
