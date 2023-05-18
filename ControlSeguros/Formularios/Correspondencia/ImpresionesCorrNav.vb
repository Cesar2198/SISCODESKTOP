Imports Utilerias.Genericas

Public Class ImpresionesCorrNav

    Private Sub ImpresionesCorrNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Dim Fecha As String = ""
        If Me.txtFecha.Text = "" Then
            Fecha = Date.Today.ToShortDateString
        Else
            Fecha = Me.txtFecha.Valor
        End If

        Me.Filtro = "cast(convert(char(8),FechaImpresion,112) as datetime) = " & dbFec(Fecha)
        If VisibilidadUsuario() = "D" Then
            Me.Filtro &= " and (select count(*) from polizas as pol inner join FlujosDocumentos as f on f.idpoliza = pol.idpoliza and f.idproducto = pol.idproducto where f.IdFlujoDoc = FlujosDocumentosImpresiones.IdFlujoDoc and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub

    Private Sub ImpresionesCorrNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Valor = Date.Today
    End Sub

    Private Sub txtFecha_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFecha.ValueChangeOnExit
        Me.CargarRegistros()
    End Sub

End Class
