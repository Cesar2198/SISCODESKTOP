Imports Utilerias.Genericas

Public Class Correspondencia

    Private Sub Correspondencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CompletarComboPasos()
    End Sub

    Private Sub CompletarComboPasos()
        Dim TV As DataTable
        TV = StiGlobalConn.ObtenerDataset("select IdPaso as Id, DescripcionPaso as Paso from FlujosTrabajoPasos where IdFlujo = " & dbStr(cboIdFlujo.Valor)).Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Paso"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TV
        RepositoryItemLookUpEdit1.PopulateColumns()

        Dim TF As New DataTable
        TF.Columns.Add("Id", System.Type.GetType("System.String"))
        TF.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FF As DataRow
        FF = TF.NewRow : FF("Id") = "ENTRADA" : FF("Tipo") = "Entrada" : TF.Rows.Add(FF)
        FF = TF.NewRow : FF("Id") = "SALIDA" : FF("Tipo") = "Salida" : TF.Rows.Add(FF)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Tipo"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = TF
        RepositoryItemLookUpEdit2.PopulateColumns()
        RepositoryItemLookUpEdit2.Columns(0).Visible = False

        Dim TZ As DataTable
        TZ = StiGlobalConn.ObtenerDataset("select IdZona as Id, DescripcionZona as Descripcion from Zonas").Tables(0)
        RepositoryItemLookUpEdit3.ValueMember = "Id"
        RepositoryItemLookUpEdit3.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit3.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit3.DataSource = TZ
        RepositoryItemLookUpEdit3.PopulateColumns()
        RepositoryItemLookUpEdit3.Columns(0).Visible = False



        Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset("SELECT IdDocumento AS Id, IdDocumento + ' - ' + NombreDocumento as Documento from DocumentosCorrespondencia order by Orden asc").Tables(0)
        RepositoryItemLookUpEdit4.ValueMember = "Id"
        RepositoryItemLookUpEdit4.DisplayMember = "Documento"
        RepositoryItemLookUpEdit4.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit4.DataSource = dtDatos
        RepositoryItemLookUpEdit4.PopulateColumns()
        RepositoryItemLookUpEdit4.Columns("Id").Visible = False

    End Sub

    Private Sub cboIdFlujo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdFlujo.ValueChangeOnExit
        Call CompletarComboPasos()
        Me.ActualizarLlavesGrid(Me, "IdFlujo", cboIdFlujo.Valor)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.AgregarFilaGrid(VistaPasos)
            VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "Orden", ObtenerOrdenPaso())
            VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "IdFlujo", cboIdFlujo.Valor)
            VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "UsuarioPaso", StiGlobalConn.User)
            VistaPasos.SetRowCellValue(VistaPasos.FocusedRowHandle, "FechaPaso", Date.Now)
            VistaPasos.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerOrdenPaso() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaPasos.DataRowCount - 1
            Try
                If CInt(VistaPasos.GetRowCellValue(I, "Orden")) > Id Then
                    Id = CInt(VistaPasos.GetRowCellValue(I, "Orden"))
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
            Me.EliminarFilaGrid(VistaPasos)
        Catch ex As Exception
            MsgBox("Error al eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            Me.AgregarFilaGrid(VistaDoc)
            VistaDoc.SetRowCellValue(VistaPasos.FocusedRowHandle, "UsuarioImprime", StiGlobalConn.User)
            VistaDoc.SetRowCellValue(VistaPasos.FocusedRowHandle, "FechaImpresion", Date.Now)
            VistaDoc.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.VistaDoc.FocusedColumn.FieldName
            Case "IdImpresion", "UsuarioImprime", "UsuarioAnula" : Me.RepositoryItemTextEdit1.MaxLength = 25
            Case "IdDestinatario" : Me.RepositoryItemTextEdit1.MaxLength = 250
            Case "Claves", "MotivoAnulacion" : Me.RepositoryItemTextEdit1.MaxLength = 100
            Case "Courier" : Me.RepositoryItemTextEdit1.MaxLength = 150
            Case "Descripcion" : Me.RepositoryItemTextEdit1.MaxLength = 250
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit2.Enter
        Select Case Me.VistaPasos.FocusedColumn.FieldName
            Case "UsuarioPaso" : Me.RepositoryItemTextEdit2.MaxLength = 25
            Case "ObservacionPaso" : Me.RepositoryItemTextEdit2.MaxLength = 0
        End Select
    End Sub

    Private Sub btnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDoc.Click
        Try
            Me.EliminarFilaGrid(VistaDoc)
        Catch ex As Exception
            MsgBox("Error al eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
