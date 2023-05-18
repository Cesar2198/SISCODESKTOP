Public Class FormulariosNav

    Private Sub btnVerFormulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFormulario.Click
        Try
            Dim Fila As Integer = Me.VistaNav.FocusedRowHandle
            If Fila >= 0 Then
                Dim Ruta As String = Me.VistaNav.GetRowCellValue(Fila, "RutaFormulario")
                If System.IO.File.Exists(Ruta) = True Then
                    System.Diagnostics.Process.Start(Ruta)
                Else
                    MsgBox("La ruta especificada del archivo no existe, el archivo pudo haber sido eliminado.", MsgBoxStyle.Information, "AVISO...")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
