Imports Utilerias.Genericas

Public Class UbicacionesMan

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset("select NombreCliente, isnull(RegistroFiscal,'') as RegistroFiscal from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class
