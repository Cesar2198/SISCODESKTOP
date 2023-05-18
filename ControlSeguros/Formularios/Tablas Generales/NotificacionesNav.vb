Imports Utilerias.Genericas

Public Class NotificacionesNav

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim Res As String = clSeguros.ProcesarNotificaciones(Date.Today)
            MsgBox("La operación ha finalizado. Resultado: " & Res, MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub
End Class
