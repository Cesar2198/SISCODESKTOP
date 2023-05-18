Imports Utilerias.Genericas

Public Class PreCertificacionesNav

    Private Sub PreCertificacionesNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as p where p.idpoliza = PreAutorizaciones.idpoliza and p.idproducto = PreAutorizaciones.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If
    End Sub
End Class
