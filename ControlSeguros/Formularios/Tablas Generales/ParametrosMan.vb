Public Class ParametrosMan

    Private Sub ParametrosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call HabilitarParametros()
        If Me.EstadoRegistro <> enEstadoRegistro.Adicionando Then
            cboTipo.SoloLectura = True
        End If
    End Sub

    Private Sub HabilitarParametros()

        Me.txtCadena.SoloLectura = True
        Me.txtEntero.SoloLectura = True
        Me.txtFecha.SoloLectura = True
        Me.txtValor.SoloLectura = True

        Select Case Me.cboTipo.Valor
            Case "T"
                Me.txtCadena.SoloLectura = False
                Me.txtCadena.PassWordChar = ""
            Case "E"
                Me.txtEntero.SoloLectura = False
            Case "F"
                Me.txtFecha.SoloLectura = False
            Case "N"
                Me.txtValor.SoloLectura = False
            Case "P"
                Me.txtCadena.SoloLectura = False
                Me.txtCadena.PassWordChar = "*"
        End Select
    End Sub

    Private Sub cboTipo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboTipo.ValueChangeOnExit
        Call HabilitarParametros()
    End Sub

End Class
