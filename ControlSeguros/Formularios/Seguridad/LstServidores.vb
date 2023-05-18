Imports Utilerias.Genericas

Public Class LstServidores

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LstServidores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ahora cargaremos la lista de servidores disponibles
        Dim dtServer As New DataTable, fila As DataRow
        dtServer.Columns.Add("Nombre", System.Type.GetType("System.String"))
        Try
            Dim servidores As DataRow() = ObtenerParametrosSimilares("SERVER")
            If Not servidores Is Nothing Then
                For Each filsvr In servidores
                    fila = dtServer.NewRow
                    fila("Nombre") = filsvr("valor")
                    dtServer.Rows.Add(fila)
                Next
            End If

            Me.GridServidores.DataSource = dtServer
            Me.GridServidores.Refresh()

            'cargamos el parametro de actualización

            If ExisteParametro("UPDATE") = False Then
                InsertarParametro("UPDATE", "", "[OPCIONES]")
                Call GuardarParametros()
            End If
            Me.txtUpdate.Valor = ObtenerParametro("UPDATE")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.VistaServidores.AddNewRow()
        Catch ex As Exception
            MsgBox("Error al adicionar el servidor." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        Dim Fila As Integer = VistaServidores.FocusedRowHandle
        If Fila >= 0 Then
            If MsgBox("¿Desea Eliminar el Servidor Seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                Try
                    VistaServidores.DeleteRow(Fila)
                    VistaServidores.GridControl.Focus()
                Catch ex As Exception
                    MsgBox("Error al borrar el servidor." & vbCrLf & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Para guardar los servidores primero los borramos
        Dim servidores As DataRow() = ObtenerParametrosSimilares("SERVER")
        If Not servidores Is Nothing Then
            For Each filsvr In servidores
                BorrarParametro(filsvr("nombre"))
            Next
        End If
        '' ahora ingresaremos los servidores 
        For NF As Integer = Me.VistaServidores.DataRowCount - 1 To 0 Step -1
            InsertarParametro("SERVER" & NF + 1, VistaServidores.GetRowCellValue(NF, "Nombre"), "[SERVIDORES]")
        Next

        ActualizarParametro("UPDATE", txtUpdate.Valor)

        Call GuardarParametros()
        MsgBox("Los servidores han sido actualizados.", MsgBoxStyle.Information, "AVISO...")
        Me.Close()
    End Sub

End Class