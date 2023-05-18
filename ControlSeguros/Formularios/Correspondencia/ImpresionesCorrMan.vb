Public Class ImpresionesCorrMan

    Private Sub ImpresionesCorrMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDescripcion.SoloLectura = True
        Me.txtUsuarioImprime.SoloLectura = True
        Me.txtFechaImpresion.SoloLectura = True
        Me.txtUsuarioAnula.SoloLectura = True
        Me.txtUsuarioAnula.Valor = StiGlobalConn.User
        Me.txtFechaAnulacion.Valor = Date.Today
    End Sub

End Class
