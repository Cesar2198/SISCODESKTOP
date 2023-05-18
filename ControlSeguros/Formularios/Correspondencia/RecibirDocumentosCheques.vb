Public Class RecibirDocumentosCheques

    Public dtCheques As DataTable


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'validamos que no hay datos en blanco 
        Dim hayBlancos As Boolean = False
        For NF As Integer = 0 To Me.vistaCheques.DataRowCount - 1
            Try
                If CStr(vistaCheques.GetRowCellValue(NF, "IdBanco")) = "" Then hayBlancos = True
                If CStr(vistaCheques.GetRowCellValue(NF, "Beneficiario")) = "" Then hayBlancos = True
                If CStr(vistaCheques.GetRowCellValue(NF, "NumCheque")) = "" Then hayBlancos = True
                If CStr(vistaCheques.GetRowCellValue(NF, "Valor")) = "" Then hayBlancos = True
                If CStr(vistaCheques.GetRowCellValue(NF, "Concepto")) = "" Then hayBlancos = True
                If CStr(vistaCheques.GetRowCellValue(NF, "Anexo")) = "" Then hayBlancos = True
            Catch ex As Exception
                hayBlancos = True
            End Try

        Next
        If hayBlancos = True Then
            MsgBox("Debe completar los datos de los cheques.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RecibirDocumentosCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dtBancos As DataTable = StiGlobalConn.ObtenerDataset("select IdBanco, NombreBanco as Banco from Bancos").Tables(0)
        cboBanco.ValueMember = "IdBanco"
        cboBanco.DisplayMember = "Banco"
        cboBanco.AutoSearchColumnIndex = 1
        cboBanco.DataSource = dtBancos
        cboBanco.PopulateColumns()
        cboBanco.Columns(0).Visible = False

        'cargamos los cheque previos
        gridCheques.DataSource = dtCheques
        gridCheques.Refresh()

    End Sub

    Private Sub btnEliminarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCheque.Click
        Try
            Me.EliminarFilaGrid(vistaCheques)
        Catch ex As Exception
            MsgBox("Error al eliminar el cheque." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try
            Me.AgregarFilaGrid(vistaCheques)
            vistaCheques.SetRowCellValue(vistaCheques.FocusedRowHandle, "Id", vistaCheques.RowCount)
            vistaCheques.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
