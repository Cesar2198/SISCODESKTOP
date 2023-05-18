Public Class PagosAsegMan

    Private Sub PagosAsegMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtIdPago.Valor = ObtenerIDPago()
            txtIdPago.SoloLectura = True
        End If
    End Sub

    Private Function ObtenerIDPago() As Integer
        Dim res As Integer
        res = clSeguros.ObtenerID("Num.Pago.Aseg")
        Return res
    End Function

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtIdPago.Valor = ObtenerIDPago()
        txtIdPago.SoloLectura = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call btnNuevo_Click(Nothing, Nothing)
    End Sub

End Class
