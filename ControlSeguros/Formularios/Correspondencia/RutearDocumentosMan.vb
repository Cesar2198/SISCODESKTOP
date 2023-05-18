Imports Utilerias.Genericas

Public Class RutearDocumentosMan

    Private Sub RutearDocumentosMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Try
            StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set FechaEnvio = " & dbFec(txtFechaEnvio.Valor) & ", FechaMovimiento = " & dbFec(Date.Now, "1") & " where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor) & " and IdImpresion = " & dbStr(txtIdImpresion.Valor))
        Catch ex As Exception

        End Try
        AgregarLogRuteo(Me.txtIdFlujoDoc.Valor, Me.txtIdImpresion.Valor, True)
    End Sub

    Private Sub RutearDocumentosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDescripcion.SoloLectura = True
        Dim UsuarioObligatorio As String = clSeguros.ObtenerDBParametros("Usuario.Ruta.Obligatorio")
        If UsuarioObligatorio = "S" Then
            Me.cboIdUsuario.Obligatorio = True
        Else
            Me.cboIdUsuario.Obligatorio = False
        End If
    End Sub

End Class
