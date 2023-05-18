Imports Utilerias.Genericas

Public Class EstadosCuentaVendedoresNav

    Private Sub EstadosCuentaVendedoresNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as pol inner join EstadosCuentaVendedoresFacturas as e on pol.idpoliza = e.idpoliza and pol.idproducto = e.idproducto where e.IdEstadoCuenta = EstadosCuentaVendedores.IdEstadoCuenta and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub
End Class
