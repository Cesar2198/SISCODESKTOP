Imports Utilerias.Genericas

Public Class CGPolizasNav

    Private Sub CGPolizasNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If optAnioAct.Checked = True Then
            Me.Filtro = " year(CGPolizas.VigenciaDesde) = year(getdate())"
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " and CGPolizas.Departamento = " & dbStr(DepartamentoUsuario())
            End If
        End If

        If optAnioAnt.Checked = True Then
            Me.Filtro = " year(CGPolizas.VigenciaDesde) = (year(getdate()) -1 )"
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " and CGPolizas.Departamento = " & dbStr(DepartamentoUsuario())
            End If
        End If

        If optTodos.Checked = True Then
            Me.Filtro = ""
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " and CGPolizas.Departamento = " & dbStr(DepartamentoUsuario())
            End If
        End If

    End Sub

    Private Sub CGPolizasNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CGPolizasNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 135
            Me.GridNav.Height = Me.Height - 105
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optAnioAct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAnioAct.Click
        Try
            Me.CargarRegistros()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optAnioAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAnioAnt.Click
        Try
            Me.CargarRegistros()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optTodos.Click
        Try
            Me.CargarRegistros()
        Catch ex As Exception

        End Try
    End Sub


End Class
