Imports Utilerias.Genericas

Public Class RutearDocumentosNav

    Private Sub RutearDocumentosNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Me.Filtro = "TipoFlujo = 'SALIDA' and FechaEnvio is null and FechaAnulacion is null"

        Dim NumDias As Integer = Val(clSeguros.ObtenerDBParametros("Corr.Rutear.NumDias"))
        If NumDias > 0 Then
            Me.Filtro &= " and FechaImpresion >= " & dbFec(Date.Today.AddDays(NumDias * -1))
        End If

        If VisibilidadUsuario() = "D" Then
            Me.Filtro &= " and (select count(*) from polizas as pol inner join FlujosDocumentos as f on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto where f.IdFlujoDoc = FlujosDocumentosImpresiones.IdFlujoDoc and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub
End Class
