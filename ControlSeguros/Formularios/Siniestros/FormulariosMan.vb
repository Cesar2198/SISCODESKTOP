Public Class FormulariosMan

    Private Sub FormulariosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If txtIdFormulario.Text = "" And Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtIdFormulario.Valor = clSeguros.ObtenerID("Formularios.Num")
        End If
    End Sub

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            OpenFileDialog1.FileName = ""
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                Me.txtRutaFormulario.Valor = Documento
            End If
        Catch ex As Exception
            MsgBox("Error al ubicar el archivo." & vbCrLf & ex.Message)
        End Try
    End Sub
End Class
