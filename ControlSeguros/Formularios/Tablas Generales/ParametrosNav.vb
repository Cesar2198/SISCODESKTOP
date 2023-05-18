Public Class ParametrosNav

    Private Sub VistaNav_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles VistaNav.CustomColumnDisplayText
        Try
            If e.Column.FieldName = "Cadena" And VistaNav.GetRowCellValue(e.RowHandle, "Tipo").ToString.Trim.ToUpper = "P" Then
                e.DisplayText = "******"
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
