Public Class msgError 

    Public exPar As Exception

    Public Sub New(ByVal ex As Exception)
        InitializeComponent()
        exPar = ex
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub stiMsgError_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtMensaje.Text = exPar.Message
            Me.txtDetalle.Text = exPar.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class