Public Class GestionesCarteraNav

    Private Sub GestionesCarteraNav_AntesLanzarFormularioNuevo(ByRef FormularioEdicion As Object) Handles Me.AntesLanzarFormularioNuevo
        Try
            FormularioEdicion.TipoGestion = "C"
        Catch ex As Exception

        End Try
    End Sub
End Class
