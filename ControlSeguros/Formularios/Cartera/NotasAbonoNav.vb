Imports Utilerias.Genericas

Public Class NotasAbonoNav

    Private Sub NotasAbonoNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as p where p.idpoliza = NotasAbono.idpoliza and p.idproducto = NotasAbono.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If
    End Sub
End Class
