Imports Utilerias.Genericas

Public Class EstadosCuentaComiNav

    Private Sub EstadosCuentaComiNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as pol inner join EstadosCuentaComisionesFacturas as e on pol.idpoliza = e.idpoliza and pol.idproducto = e.idproducto where e.IdEstadoCuenta = EstadosCuentaComisiones.IdEstadoCuenta and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If
    End Sub
End Class
