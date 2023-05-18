Imports Utilerias.Genericas

Public Class UsuariosMan

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtUsuarioCreacion.Valor = StiGlobalConn.User
        Me.txtFechaCreacion.Valor = Date.Today()

        Me.txtUsuarioCreacion.SoloLectura = True
        Me.txtFechaCreacion.SoloLectura = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.ErrorGuardar = False Then
            Me.txtUsuarioCreacion.SoloLectura = True
            Me.txtFechaCreacion.SoloLectura = True
            If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                Me.txtUsuarioCreacion.Valor = StiGlobalConn.User
                Me.txtFechaCreacion.Valor = Date.Today()
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.txtUsuarioCreacion.SoloLectura = True
        Me.txtFechaCreacion.SoloLectura = True
    End Sub

    Private Sub UsuariosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        'verificaremos que los nombre de los usuarios no tengan espacios
        If InStr(txtIdUsuario.Text, " ") > 0 Then
            MsgBox("El campo " & txtIdUsuario.LabelText & " no puede contener espacios.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If
    End Sub

    Private Sub UsuariosMan_DespuesDeEliminar() Handles Me.DespuesDeEliminar
        Try
            ''eliminaremos el usuario de la base de datos
            StiGlobalConn.SQLExecute("USE " & StiGlobalConn.DB)
            StiGlobalConn.SQLExecute("EXEC sp_revokedbaccess " & dbStr(txtIdUsuario.Valor))
            StiGlobalConn.SQLExecute("EXEC sp_droplogin " & dbStr(txtIdUsuario.Valor))
        Catch ex As Exception
            MsgBox("Error al remover los permisos del usuario." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub

    Private Sub UsuariosMan_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        Try
            ''este evento se lanza una vez guardado el registro, confirmado sin errores y no se han limpiado los campos
            ''crearemos el usuario en la base de datos
            If txtIdUsuario.Text.Trim.ToLower <> "sa" Then
                If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                    StiGlobalConn.SQLExecute("USE " & StiGlobalConn.DB)
                    'StiGlobalConn.SQLExecute("EXEC sp_addlogin " & dbStr(txtIdUsuario.Valor) & ", " & dbStr(txtPassword.Valor) & "," & dbStr(StiGlobalConn.DB) & "," & dbStr("SPANISH"))
                    'cambiamos la forma de crear usuarios para omitir los permisos de seguridad en sql servder 2008
                    StiGlobalConn.SQLExecute("CREATE LOGIN [" & txtIdUsuario.Valor & "] WITH PASSWORD = " & dbStr(txtPassword.Valor) & ", CHECK_POLICY = OFF, CHECK_EXPIRATION = OFF")


                    StiGlobalConn.SQLExecute("EXEC sp_grantdbaccess " & dbStr(txtIdUsuario.Valor))
                    StiGlobalConn.SQLExecute("EXEC sp_addrolemember " & dbStr("db_owner") & "," & dbStr(txtIdUsuario.Valor))
                    StiGlobalConn.SQLExecute("EXEC sp_addsrvrolemember " & dbStr(txtIdUsuario.Valor) & "," & dbStr("sysadmin"))
                End If
                If Me.EstadoRegistro = enEstadoRegistro.Modificando And txtPassword.Text <> "" Then
                    StiGlobalConn.SQLExecute("USE " & StiGlobalConn.DB)
                    StiGlobalConn.SQLExecute("EXEC sp_password NULL, " & dbStr(txtPassword.Valor) & "," & dbStr(txtIdUsuario.Valor))
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al Definir o actualizar los permisos del usuario." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub

    Private Sub UsuariosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUsuarioCreacion.SoloLectura = True
        Me.txtFechaCreacion.SoloLectura = True

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtUsuarioCreacion.Valor = StiGlobalConn.User
            Me.txtFechaCreacion.Valor = Date.Today()
            Me.txtPassword.Obligatorio = True
        End If

        Call LlenarCombosGrid()
    End Sub

    Private Sub LlenarCombosGrid()
        Dim Grupos As DataTable = STIConn.ObtenerDataset("select IdGrupo, Descripcion from Grupos").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "IdGrupo"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = Grupos
        RepositoryItemLookUpEdit1.PopulateColumns()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.AgregarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtIdUsuario_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdUsuario.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdUsuario.NombreCampo, txtIdUsuario.Valor)
    End Sub

End Class
