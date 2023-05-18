Imports Utilerias.Genericas

Public Class NotasCreditoNav

    Private Sub NotasCreditoNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as p where p.idpoliza = NotasCredito.idpoliza and p.idproducto = NotasCredito.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If
    End Sub

End Class
