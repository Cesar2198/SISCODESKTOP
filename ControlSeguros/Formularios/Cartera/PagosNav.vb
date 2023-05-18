Imports Utilerias.Genericas

Public Class PagosNav

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

    Private Sub PagosNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Me.Filtro = ""
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as p where p.idpoliza = Facturas.idpoliza and p.idproducto = Facturas.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

        If optAnioAct.Checked = True Then
            If Me.Filtro.Trim <> "" Then Me.Filtro &= " and "
            Me.Filtro &= " year(FechaEmision) = year(getdate())"
        End If

        If optAnioAnt.Checked = True Then
            If Me.Filtro.Trim <> "" Then Me.Filtro &= " and "
            Me.Filtro &= " year(FechaEmision) = (year(getdate()) -1 )"
        End If


    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                VistaNav.Columns("Comision").Visible = False
                VistaNav.Columns("Comision").OptionsColumn.AllowShowHide = False

                VistaNav.Columns("PorceComision").Visible = False
                VistaNav.Columns("PorceComision").OptionsColumn.AllowShowHide = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PagosNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        Call ProcesarPermisosComision()
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 135
            Me.GridNav.Height = Me.Height - 105
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PagosNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

End Class
