Imports Utilerias.Genericas

Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim ServidorLogin As String = stiSplit(Me.ServerComboBox.Text.Replace("<", ""), "G0,1").Trim
            Dim DBLogin As String = stiSplit(Me.ServerComboBox.Text.Replace(">", ""), "G1,1").Trim

            StiGlobalConn = New Conectividad.Funciones(ServidorLogin, DBLogin, Me.UsernameTextBox.Text, Me.PasswordTextBox.Text, True)
            If StiGlobalConn.Conn.State = ConnectionState.Open Then
                Call IniciarClases()
                Dim MultiSesiones As String = clSeguros.ObtenerDBParametros("Multiples.Sesiones")
                If MultiSesiones = Nothing Then MultiSesiones = ""

                If MultiSesiones.Trim.ToUpper = "N" Then
                    'verificaremos si ya hay otro usuarios logeado.
                    Try
                        Dim Sesiones As DataTable = StiGlobalConn.ObtenerDataset("exec sp_who " & dbStr(Me.UsernameTextBox.Text)).Tables(0)
                        If Sesiones.Rows.Count >= 2 Then
                            'ya hay otro usuario.
                            MsgBox("Ya existe un usuario utilizando el sistema con el usuario especificado.", MsgBoxStyle.Information, "AVISO...")
                            StiGlobalConn.Desconectarse()
                            Exit Sub
                        End If
                    Catch ex As Exception

                    End Try
                End If



                'almacenamos la última configuración usada
                ActualizarParametro("NOMBRE", Me.UsernameTextBox.Text)
                ActualizarParametro("ULTSER", Me.ServerComboBox.Text)
                GuardarParametros()

                frmPrincipal = New Principal
                Me.Hide()
                frmPrincipal.ShowDialog()
                Me.Close()
            End If

        Catch Exsql As SqlClient.SqlException
            Dim Mensaje As String = Exsql.Message
            If Exsql.Message Like "*Cannot open database*" Then
                Mensaje = "No se ha encontrado la base de datos."
            ElseIf Exsql.Message Like "*no se encontró el servidor*" Or Exsql.Message Like "*server not found*" Then
                Mensaje = "No se ha encontrado el servidor."
            ElseIf Exsql.ErrorCode = -2146232060 Or Exsql.Message Like "Login failed*" Then
                Mensaje = "Usuario o Contaseña Incorrectas."
            End If

            MsgBox(Mensaje, MsgBoxStyle.Critical, "ALERTA")
        Catch ex As Exception
            MsgBox("No es posible ingresar al sistema." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "AVISO...")
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

        ''MsgBox(ObtenerClavePC())

        'Dim Original As String = ""
        'Dim Encriptado As String = ""
        'Dim Desencriptado As String = ""
        ' ''Dim RES() As Byte

        'Original = InputBox("Texto a Encriptar")

        'Encriptado = DESEncrypt(Original, "fifi")
        'MsgBox(Encriptado)

        'Desencriptado = DESDecrypt(Encriptado, "fifi")
        'MsgBox(Desencriptado)

        ''UNICOD NO ES EXACTO EN LA ENCRIPTACION


        'Dim H1 As String = HashEncrypt(InputBox("Contraseña"), "Key")
        'Dim H2 As String = HashEncrypt(InputBox("Contraseña 2"), "Key")
        'If H1 = H2 Then
        '    MsgBox("Iguales")
        'Else
        '    MsgBox("Incorrectas")
        'End If

        'Dim b() As Byte
        'Dim utf As New System.Text.UTF7Encoding()
        'b = utf.GetBytes("Σ")
        'Dim s As String = utf.GetString(b)

    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Res As String = ""
        Res = CargarParametros()
        If Res <> "" Then
            MsgBox("Error al cargar el archivo de configuración." & vbCrLf & Res, MsgBoxStyle.Exclamation, "AVISO...")
        End If

        'cargamos el último usuario loggeado
        Me.UsernameTextBox.Text = ObtenerParametro("NOMBRE")

        'ahora cargaremos la lista de servidores disponibles
        Me.ServerComboBox.Items.Clear()
        Try
            Dim servidores As DataRow() = ObtenerParametrosSimilares("SERVER")
            If Not servidores Is Nothing Then
                For Each filsvr In servidores
                    Me.ServerComboBox.Items.Add(filsvr("valor"))
                Next
            End If
        Catch ex As Exception

        End Try
        Me.ServerComboBox.SelectedItem = ObtenerParametro("ULTSER")

        'ahora cargaremos la imagen por defecto.
        Try
            Res = Application.StartupPath & "\" & ObtenerParametro("IMAGEN")
            If System.IO.File.Exists(Res) = True Then
                Me.LogoPictureBox.Image = System.Drawing.Image.FromFile(Res)
            End If
        Catch ex As Exception

        End Try

        ''si no hay licencia y expiro el demo  se acaba
        'Cesar Guerrero cambio para quitar lo de la molesta licencia
        Dim Falso As Boolean = True
        If Falso = False Then End

        'Quitamos lo de la licencia estorbosa'
        'Try
        '    Dim LineaComandos() As String = Environment.GetCommandLineArgs
        '    If LineaComandos.Length > 1 Then
        '        If LineaComandos(1) = "admin" Then
        '            Me.UsernameTextBox.Text = "sa"
        '            Me.PasswordTextBox.Text = "admin"
        '            Call OK_Click(Nothing, Nothing)
        '        End If
        '    Else
        '        If MODALIDAD_DEMO = True Then
        '            Me.UsernameTextBox.Text = "sa"
        '            Me.PasswordTextBox.Text = "admin"
        '            Call OK_Click(Nothing, Nothing)
        '        End If
        '    End If


        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub UsernameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.LostFocus
        Me.PasswordTextBox.Focus()
    End Sub

    Private Sub btnlstServidores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlstServidores.Click
        Dim Fsrv As New LstServidores
        Fsrv.ShowDialog()

        ''actualizamos la lista de los servidores
        Me.ServerComboBox.Items.Clear()
        Try
            Dim servidores As DataRow() = ObtenerParametrosSimilares("SERVER")
            If Not servidores Is Nothing Then
                For Each filsvr In servidores
                    Me.ServerComboBox.Items.Add(filsvr("valor"))
                Next
            End If
        Catch ex As Exception

        End Try
        Me.ServerComboBox.SelectedItem = ObtenerParametro("ULTSER")
    End Sub

End Class
