Imports Utilerias.Genericas

Public Class CorrespondenciaNav

    Private Sub CorrespondenciaNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros

        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as pol where pol.idpoliza = FlujosDocumentos.idpoliza and pol.idproducto = FlujosDocumentos.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub

    Private Sub CorrespondenciaNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        Try
            'formateamos los campos de fecha hora
            Me.VistaNav.Columns("FechaAsignacion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime : Me.VistaNav.Columns("FechaAsignacion").DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
            Me.VistaNav.Columns("FechaReAsignacion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime : Me.VistaNav.Columns("FechaReAsignacion").DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
            Me.VistaNav.Columns("Identificador").Visible = False : VistaNav.Columns("Identificador").OptionsColumn.AllowShowHide = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CorrespondenciaNav_VistaNavCustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles Me.VistaNavCustomColumnDisplayText
        Select Case GlobalCodCliente
            Case "2120000"
                If Me.VistaNav.GetRowCellValue(e.RowHandle, "Identificador") = 0 Then
                    Select Case e.Column.FieldName
                        Case "UsuarioAsignacion", "UsuarioReAsignacion", "FechaAsignacion", "FechaReAsignacion"
                            e.DisplayText = ""
                    End Select
                End If

        End Select

    End Sub

End Class
