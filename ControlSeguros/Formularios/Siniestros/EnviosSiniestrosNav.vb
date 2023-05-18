
Imports Utilerias.Genericas

Public Class EnviosSiniestrosNav

    Private Sub EnviosSiniestrosNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as p inner join EnviosSiniestrosDetalle as e on p.idpoliza = e.idpoliza and p.idproducto = e.idproducto where e.IdEnvio = EnviosSiniestros.IdEnvio and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If
    End Sub
End Class
