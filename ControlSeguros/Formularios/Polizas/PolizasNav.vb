Imports Utilerias.Genericas

Public Class PolizasNav

    Private Sub PolizasNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " polizas.departamento = " & dbStr(DepartamentoUsuario())
        End If
    End Sub

    Private Sub PolizasNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        Try
            Me.VistaNav.Columns("FechaModificaVendedores").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.VistaNav.Columns("FechaModificaVendedores").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"
        Catch ex As Exception

        End Try
    End Sub

End Class
