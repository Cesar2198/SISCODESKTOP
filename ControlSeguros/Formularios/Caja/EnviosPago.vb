Imports Utilerias.Genericas

Public Class EnviosPago

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub EnviosPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaCorte.Valor = Date.Today
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'verificamos si existen recibos pendientes

        If txtFechaCorte.Text = "" Then
            MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Dim lstEnvios As String = ""
        Dim msgError As String = ""

        msgError = GenerarEnvioCaja(Me.txtFechaCorte.Valor, lstEnvios)
        If msgError.Trim <> "" Then
            MsgBox(msgError, MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If
        

        'ahora como el envio ha sido almacenado procedemos a la impresión
        msgError = ImprimirEnvioCaja(lstEnvios, "", "", "", "", "")
        If msgError.Trim <> "" Then
            MsgBox(msgError, MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        MsgBox("Se ha completado la operación con éxito y se ha generado el Envío.", MsgBoxStyle.Information, "AVISO...")

    End Sub

End Class
