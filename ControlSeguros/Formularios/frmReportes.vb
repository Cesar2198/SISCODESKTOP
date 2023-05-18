Public Class frmReportes

    Public Sub New()
        InitializeComponent()

        'establecemos la contraseña de los documentos
        Me.PassWordDoc = clSeguros.ObtenerDBParametros("Password.Documentos")


    End Sub

End Class
