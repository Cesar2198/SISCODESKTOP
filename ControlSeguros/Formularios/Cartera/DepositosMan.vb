Imports Utilerias.Genericas

Public Class DepositosMan

    Private Sub DepositosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "DEPOSITO" : Fila("Descripcion") = "Depósito" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "RETIRO" : Fila("Descripcion") = "Retiro" : FP.Rows.Add(Fila)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = FP
        RepositoryItemLookUpEdit1.PopulateColumns()

        RepositoryItemLookUpEdit1.Columns("Id").Visible = False


        Dim TA As DataTable
        TA = StiGlobalConn.ObtenerDataset("select IdAseguradora as Id, Nombre as [Descripción] from Aseguradoras").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = TA
        RepositoryItemLookUpEdit2.PopulateColumns()

        Me.txtIdCliente.SoloLectura = True
        Me.txtNombreCliente.SoloLectura = True
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim id As Integer = ObtenerIDDep()

            Me.AgregarFilaGrid(VistaDepositos)
            'COMPLETAMOS INFORMACION
            Me.VistaDepositos.SetRowCellValue(VistaDepositos.FocusedRowHandle, "IdMovimiento", id)
            Me.VistaDepositos.SetRowCellValue(VistaDepositos.FocusedRowHandle, "Usuario", StiGlobalConn.User)
            Me.VistaDepositos.UpdateCurrentRow()

        Catch ex As Exception
            MsgBox("Error al adicionar el registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDep() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDepositos.DataRowCount - 1
            Try
                If CInt(VistaDepositos.GetRowCellValue(I, "IdMovimiento")) > Id Then
                    Id = CInt(VistaDepositos.GetRowCellValue(I, "IdMovimiento"))
                End If
            Catch ex As Exception

            End Try
        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Me.EliminarFilaGrid(VistaDepositos)
        Catch ex As Exception
            MsgBox("Error al elimiar el registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.VistaDepositos.FocusedColumn.FieldName
            Case "Descripcion" : Me.RepositoryItemTextEdit1.MaxLength = 250
        End Select
    End Sub

End Class
