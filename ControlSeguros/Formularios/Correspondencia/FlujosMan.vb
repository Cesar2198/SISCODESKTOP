Public Class FlujosMan

    Private Sub FlujosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFechaCreacion.Valor = Date.Today
        End If

        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "S" : Fila("Descripcion") = "SI" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "N" : Fila("Descripcion") = "NO" : FP.Rows.Add(Fila)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = FP
        RepositoryItemLookUpEdit1.PopulateColumns()
        RepositoryItemLookUpEdit1.Columns("Id").Visible = False


        Dim RE As New DataTable
        RE.Columns.Add("Id", System.Type.GetType("System.String"))
        RE.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        Dim FilaRE As DataRow
        FilaRE = RE.NewRow : FilaRE("Id") = "ENTRADA" : FilaRE("Descripcion") = "Entrada" : RE.Rows.Add(FilaRE)
        FilaRE = RE.NewRow : FilaRE("Id") = "SALIDA" : FilaRE("Descripcion") = "Salida" : RE.Rows.Add(FilaRE)

        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = RE
        RepositoryItemLookUpEdit2.PopulateColumns()
        RepositoryItemLookUpEdit2.Columns("Id").Visible = False

    End Sub

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.VistaPasos.FocusedColumn.FieldName
            Case "DescripcionPaso" : Me.RepositoryItemTextEdit1.MaxLength = 250
        End Select
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.AgregarFilaGrid(VistaPasos)
            VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "IdPaso", ObtenerIDPaso)
            VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "EsPasoFinal", "N")
            VistaPasos.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDPaso() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaPasos.DataRowCount - 1
            Try
                If CInt(VistaPasos.GetRowCellValue(I, "IdPaso")) > Id Then
                    Id = CInt(VistaPasos.GetRowCellValue(I, "IdPaso"))
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

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        Try
            Dim Fila As Integer = Me.VistaPasos.FocusedRowHandle
            Dim IdPaso As Integer, IdSiguientePaso As Integer
            IdPaso = Me.VistaPasos.GetRowCellValue(Fila, "IdPaso")
            IdSiguientePaso = Me.VistaPasos.GetRowCellValue(Fila, "IdSiguientePaso")
            For NF As Integer = 0 To VistaPasos.DataRowCount - 1
                If VistaPasos.GetRowCellValue(NF, "IdPaso") > IdPaso Then
                    VistaPasos.SetRowCellValue(NF, "IdPaso", CInt(VistaPasos.GetRowCellValue(NF, "IdPaso") - 1))
                    If Not VistaPasos.GetRowCellValue(NF, "IdSiguientePaso") Is System.DBNull.Value Then
                        VistaPasos.SetRowCellValue(NF, "IdSiguientePaso", CInt(VistaPasos.GetRowCellValue(NF, "IdSiguientePaso") - 1))
                    End If
                End If
            Next
            Me.EliminarFilaGrid(VistaPasos)
        Catch ex As Exception
            MsgBox("Error al eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        Try
            Dim Fila As Integer = Me.VistaPasos.FocusedRowHandle
            Dim IdPaso As Integer = 0, IdSiguientePaso As Integer = 0
            If Fila >= 0 Then
                IdPaso = Me.VistaPasos.GetRowCellValue(Fila, "IdPaso")
                IdSiguientePaso = Me.VistaPasos.GetRowCellValue(Fila, "IdSiguientePaso")
                For NF As Integer = 0 To VistaPasos.DataRowCount - 1
                    If VistaPasos.GetRowCellValue(NF, "IdPaso") >= IdPaso Then
                        VistaPasos.SetRowCellValue(NF, "IdPaso", CInt(VistaPasos.GetRowCellValue(NF, "IdPaso") + 1))
                        If Not VistaPasos.GetRowCellValue(NF, "IdSiguientePaso") Is System.DBNull.Value Then
                            VistaPasos.SetRowCellValue(NF, "IdSiguientePaso", CInt(VistaPasos.GetRowCellValue(NF, "IdSiguientePaso") + 1))
                        End If
                    End If
                Next
                Me.AgregarFilaGrid(VistaPasos)
                VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "IdPaso", IdPaso)
                VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "IdSiguientePaso", IdSiguientePaso)
                VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "EsPasoFinal", "N")
                VistaPasos.UpdateCurrentRow()
            Else
                MsgBox("Debe especificar la fila donde se desea insertar")
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtIdFlujo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdFlujo.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdFlujo.NombreCampo, txtIdFlujo.Valor)
    End Sub

End Class
