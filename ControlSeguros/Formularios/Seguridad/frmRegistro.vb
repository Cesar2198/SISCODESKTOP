Imports Utilerias.Genericas

Public NotInheritable Class frmRegistro

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'validamos la secuencia de instalacion
        Try
            Dim contador As Integer = 0, Hash As String = ""
            For I As Integer = 0 To 30
                ''veremos cual es el dia de demo que va
                Hash = HashEncrypt(I, ObtenerParametro("Clave"))
                If Hash = ObtenerParametro("Secuencia") Then
                    contador = I
                    Exit For
                End If
            Next
            If contador <= 0 Then
                MsgBox("La versión demo del producto ha expirado.", MsgBoxStyle.Information, "AVISO...")
                End
            Else
                ActualizarParametro("Secuencia", HashEncrypt(contador - 1, ObtenerParametro("Clave")))
                GuardarParametros()
                MENSAJE_DEMO = "Versión Demo << " & contador - 1 & " usos restantes >>"
                MODALIDAD_DEMO = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error para entrar en modalidad DEMO." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
    End Sub

    Private Sub frmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos los valores
        txtCliente.Valor = ""
        txtProductId.Valor = ObtenerParametro("Clave")
        txtSerial.Valor = ""
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'primero verificamos si la clave es correcta
        If txtCliente.Text = "" Then
            MsgBox("El nombre del cliente es Obligatorio.", vbExclamation, "AVISO...")
            Exit Sub
        End If
        If txtSerial.Text = "" Then
            MsgBox("El Serial del Producto es Obligatorio.", vbExclamation, "AVISO...")
            Exit Sub
        End If

        If Not ComparaLicencia(txtCliente.Text, txtSerial.Text, txtProductId.Text, ID_LICENCIA) Then
            MsgBox("El código de activación no es válido.", vbExclamation, "AVISO...")
            Exit Sub
        End If

        MODALIDAD_DEMO = False
        ActualizarParametro("Serial", txtSerial.Text)
        ActualizarParametro("Cliente", txtCliente.Text)
        GuardarParametros()
        MENSAJE_DEMO = ""
        Me.Close()

    End Sub

    Private Sub txtSerial_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtSerial.ValueChangeOnExit
        If txtSerial.Text = "SISCO" & Format(Date.Today, "MMyydd") & "$" Then
            Dim CLAVE As String = txtProductId.Text
            CLAVE = Replace(CLAVE, "-", "")
            CLAVE = CLAVE & txtCliente.Text
            txtSerial.Text = GeneraLicencia(CLAVE, ID_LICENCIA)
        End If
    End Sub

End Class
