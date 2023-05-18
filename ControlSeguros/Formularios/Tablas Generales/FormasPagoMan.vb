Public Class FormasPagoMan

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.AgregarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub FormasPagoMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarCombosGrid()
    End Sub

    Private Sub LlenarCombosGrid()
        Dim Aseguradora As DataTable = StiGlobalConn.ObtenerDataset("select IdAseguradora as Id, Nombre as Aseguradora from Aseguradoras order by Nombre").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Aseguradora"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = Aseguradora
        RepositoryItemLookUpEdit1.PopulateColumns()

    End Sub

    Private Sub txtIdFormaPago_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdFormaPago.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdFormaPago.NombreCampo, txtIdFormaPago.Valor)
    End Sub

End Class
