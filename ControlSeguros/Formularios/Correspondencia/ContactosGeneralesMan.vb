Imports Utilerias.Genericas

Public Class ContactosGeneralesMan

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim Id As Integer = ObtenerIDcontacto()
            Me.AgregarFilaGrid(GridView1)
            'ademos agregaremos el Id de contacto
            Me.GridView1.SetRowCellValue(Me.GridView1.FocusedRowHandle, "IdSubContacto", Id)
            Me.GridView1.UpdateCurrentRow()

        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDcontacto() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView1.DataRowCount - 1
            Try
                If CInt(GridView1.GetRowCellValue(I, "IdSubContacto")) > Id Then
                    Id = CInt(GridView1.GetRowCellValue(I, "IdSubContacto"))
                End If
            Catch ex As Exception

            End Try

        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.GridView1.FocusedColumn.FieldName
            Case "Nombre", "Funciones" : Me.RepositoryItemTextEdit1.MaxLength = 250
            Case "Cargo" : Me.RepositoryItemTextEdit1.MaxLength = 50
            Case "Telefono", "EMail" : Me.RepositoryItemTextEdit1.MaxLength = 100

        End Select
    End Sub

    Private Sub txtIdContacto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdContacto.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdContacto.NombreCampo, txtIdContacto.Valor)
    End Sub

    Private Sub AseguradorasMan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cboIdContactoCategoria.OcultarColumna(0)
        Me.cboEstadoContacto.OcultarColumna(0)
    End Sub

End Class

