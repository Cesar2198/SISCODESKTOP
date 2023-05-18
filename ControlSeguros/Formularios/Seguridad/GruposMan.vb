Public Class GruposMan

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.AgregarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub GruposMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarCombosGrid()

        If CStr(txtIdGrupo.Valor).Trim.ToUpper <> "ADMINISTRADORES" Then
            ColNombre.Visible = False
        End If

    End Sub

    Private Sub LlenarCombosGrid()
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "DescripcionFull"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = tblMenu
        RepositoryItemLookUpEdit1.PopulateColumns()

        'los permisos se llenan de forma manual
        Dim Permisos As New DataTable
        Permisos.Columns.Add("Id", System.Type.GetType("System.String"))
        Permisos.Columns.Add("Permiso", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = Permisos.NewRow : Fila("Id") = "I" : Fila("Permiso") = "Lectura Sin Impresión" : Permisos.Rows.Add(Fila)
        Fila = Permisos.NewRow : Fila("Id") = "L" : Fila("Permiso") = "Lectura" : Permisos.Rows.Add(Fila)
        Fila = Permisos.NewRow : Fila("Id") = "E" : Fila("Permiso") = "Escritura" : Permisos.Rows.Add(Fila)
        Fila = Permisos.NewRow : Fila("Id") = "W" : Fila("Permiso") = "Escritura sin Eliminar" : Permisos.Rows.Add(Fila)
        Fila = Permisos.NewRow : Fila("Id") = "T" : Fila("Permiso") = "Control Total" : Permisos.Rows.Add(Fila)

        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Permiso"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = Permisos
        RepositoryItemLookUpEdit2.PopulateColumns()

    End Sub

    Private Sub txtIdGrupo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdGrupo.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdGrupo.NombreCampo, txtIdGrupo.Valor)
    End Sub

    Private Sub CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarTodosLosPermisosALecturaSinImpresiónToolStripMenuItem.Click
        Call CambiarPermiso("I")
    End Sub

    Private Sub CambiarTodosLosPermisosALecturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarTodosLosPermisosALecturaToolStripMenuItem.Click
        Call CambiarPermiso("L")
    End Sub

    Private Sub CambiarTodosLosPermisosAEscrituraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarTodosLosPermisosAEscrituraToolStripMenuItem.Click
        Call CambiarPermiso("E")
    End Sub

    Private Sub CambiarTodosLosPermisosAControlTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarTodosLosPermisosAControlTotalToolStripMenuItem.Click
        Call CambiarPermiso("T")
    End Sub

    Private Sub CambiarPermiso(ByVal Permiso As String)
        Try
            For NP As Integer = 0 To Me.GridView1.DataRowCount - 1
                Me.GridView1.SetRowCellValue(NP, "IdPermiso", Permiso)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
