Imports Utilerias.Genericas

Public Class SiniestrosNav

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

    Private Sub SiniestrosNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If optAnioAct.Checked = True Then
            Me.Filtro = " year(fechapresentado) = year(getdate())"
            If VisibilidadUsuario() = "D" Then
                Me.Filtro &= " and (select count(*) from polizas as p where p.idpoliza = Siniestros.idpoliza and p.idproducto = Siniestros.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
        End If

        If optAnioAnt.Checked = True Then
            Me.Filtro = " year(fechapresentado) = (year(getdate()) -1 )"
            If VisibilidadUsuario() = "D" Then
                Me.Filtro &= " and (select count(*) from polizas as p where p.idpoliza = Siniestros.idpoliza and p.idproducto = Siniestros.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
        End If

        If optTodos.Checked = True Then
            Me.Filtro = ""
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " (select count(*) from polizas as p where p.idpoliza = Siniestros.idpoliza and p.idproducto = Siniestros.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
        End If

        'verificaremos por un parámetro para indicar la preferencia de un cliente en reclamos
        Try
            Dim FiltroCliente As String = clSeguros.ObtenerDBParametros("Siniestros.Cli." & StiGlobalConn.User.Trim)
            If FiltroCliente <> "" Then
                FiltroCliente = Utilerias.Genericas.ComillarLista(FiltroCliente)
                If FiltroCliente <> "" Then
                    If Me.Filtro <> "" Then Me.Filtro &= " and "
                    Me.Filtro &= " (select count(*) from polizas as p where p.idpoliza = Siniestros.idpoliza and p.idproducto = Siniestros.idproducto and p.IdCliente in (" & FiltroCliente & ") ) > 0 "
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SiniestrosNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros

        Try
            Me.VistaNav.Columns("FechaUltimaGestion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.VistaNav.Columns("FechaUltimaGestion").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SiniestrosNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SiniestrosNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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

End Class
