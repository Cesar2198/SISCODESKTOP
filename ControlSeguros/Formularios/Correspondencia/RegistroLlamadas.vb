
Imports Utilerias.Genericas


Public Class RegistroLlamadas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            btnImprimir.Enabled = True
            btnBuscar.Enabled = False
            Me.cboLlamadaPara.Valor = ""
            Me.cboUsuario.Valor = StiGlobalConn.User
            Me.txtEmail.Valor = ""
            Me.txtFecha.Valor = Date.Today
            Me.txtHora.Time = Now
            Me.txtIdCliente.Valor = ""
            Me.txtLugar.Valor = ""
            Me.txtNombreCliente.Valor = ""
            Me.txtObservaciones.Valor = ""
            Me.txtTelefono.Valor = ""
            Me.txtPersonaLlama.Valor = ""
            Me.cboLlamadaPara.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistroLlamadas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.cboLlamadaPara.Focus()
    End Sub

    Private Sub RegistroLlamadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboUsuario.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboLlamadaPara.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboUsuario.Llenar_Combo()
        cboLlamadaPara.Llenar_Combo()

        Call btnNuevo_Click(Nothing, Nothing)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'guardamos
        Try
            Dim mensaje As String = Me.ValidarCamposObligatorios(Me)
            If mensaje <> "" Then
                MsgBox("Debe completar los campos obligatorios: " & mensaje, MsgBoxStyle.Information, "AVISO..")
                Exit Sub
            End If

            Dim sql As String = ""
            Dim PasoLlamada As String = "S"
            If Me.optNo.Checked = True Then PasoLlamada = "N"

            sql = " insert into RegistroLlamadas "
            sql &= " (Fecha, Hora ,UsuarioGraba ,UsuarioPara, PersonaLlama, "
            sql &= " Lugar, Telefono ,EMail, IdCliente, Observaciones, SePasoLlamada) values ("
            sql &= dbFec(txtFecha.Valor) & C & dbFec(CDate(txtFecha.Valor).ToShortDateString, txtHora.Time.ToString("HH:mm:ss")) & C & dbStr(cboUsuario.Valor) & C & dbStr(cboLlamadaPara.Valor) & C & dbStr(txtPersonaLlama.Valor) & C
            sql &= dbStr(Me.txtLugar.Valor) & C & dbStr(txtTelefono.Valor) & C & dbStr(txtEmail.Valor) & C & dbStr(txtIdCliente.Valor) & C & dbStr(txtObservaciones.Valor) & C & dbStr(PasoLlamada) & ") "
            StiGlobalConn.SQLExecute(sql)

            btnImprimir.Enabled = False
            btnBuscar.Enabled = True

            MsgBox("Se registro la llamada con éxito.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'enviamos el recado al usuario
        Try
            If cboLlamadaPara.Text = "" Then
                MsgBox("No se ha definido el usuario a la que pertenece la llamada.", MsgBoxStyle.Information, "AVISO...")
            Else

                Dim correo As String = ""
                Try
                    correo = StiGlobalConn.ObtenerDataset("select Email from Usuarios where IdUsuario = " & dbStr(cboLlamadaPara.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception

                End Try

                If correo = "" Then
                    MsgBox("El usuario: " & cboLlamadaPara.Text & " no tiene correo definido.", MsgBoxStyle.Information, "AVISO...")
                Else
                    Dim Mensaje As String = ""
                    Dim pasollamada As String = "Si"
                    If optNo.Checked = True Then pasollamada = "No"
                    Mensaje = "Detalle de Recado de llamada telefónica: " & vbCrLf
                    Mensaje &= "Persona que llama: " & txtPersonaLlama.Valor & vbCrLf
                    Mensaje &= "Lugar de donde llama:" & txtLugar.Valor & vbCrLf
                    Mensaje &= "Fecha: " & txtFecha.Text & vbCrLf
                    Mensaje &= "Hora: " & txtHora.Text & vbCrLf
                    Mensaje &= "Teléfono: " & txtTelefono.Valor & vbCrLf
                    Mensaje &= "EMail: " & txtEmail.Valor & vbCrLf
                    Mensaje &= "Cliente: " & txtNombreCliente.Valor & vbCrLf
                    Mensaje &= "Observaciones: " & txtObservaciones.Valor & vbCrLf
                    Mensaje &= "Se paso la llamada: " & pasollamada & vbCrLf
                    Mensaje &= "" & vbCrLf
                    clSeguros.EnviarCorreoNotificaciones(correo, "", "", "Recado llamada telefónica", Mensaje, False)
                    MsgBox("Correo enviado con éxito.", MsgBoxStyle.Information, "AVISO...")
                End If
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

End Class
