Public Class PagosAsegNav

    Private Sub PagosAsegNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'formatearemos una columna
        Try
            Me.VistaNav.Columns("ValorCheque").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.VistaNav.Columns("ValorCheque").DisplayFormat.FormatString = "c"
        Catch ex As Exception

        End Try
    End Sub
End Class
