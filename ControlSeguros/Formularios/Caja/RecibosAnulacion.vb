Imports Utilerias.Genericas

Public Class RecibosAnulacion

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.LimpiarCampos(Me)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim fbus As New BusquedaRecibos
        'solo recibos pendientes
        fbus.dbFiltro = " and r.EstadoRecibo = 'P' " ''and r.FechaRecibo = " & dbFec(Date.Today)
        busCodigo = ""
        fbus.ShowDialog()

        If busCodigo <> "" Then
            Dim Fila As DataRow = StiGlobalConn.ObtenerDataset("select * from Recibos where idrecibo = " & dbStr(busCodigo)).Tables(0).Rows(0)
            Me.txtFechaRecibo.Valor = dbData(Fila, "FechaRecibo")
            Me.txtIdCliente.Valor = dbData(Fila, "IdCliente")
            Me.txtNombreCliente.Valor = dbData(Fila, "NombreCliente")
            Me.txtNumRecibo.Valor = dbData(Fila, "IdRecibo")
            Me.txtTotalRecibo.Valor = dbData(Fila, "TotalRecibo")
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtNumRecibo.Text = "" Then
            MsgBox("Debe búscar el recibo pendiente que desea anular.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If
        If txtMotivoAnulacion.Text = "" Then
            MsgBox("Debe especificar el motivo de la anulación.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        'para anular un recibo únicamente le cambiamos el estado
        Dim sql As String = ""
        sql = "  update Recibos set EstadoRecibo = 'N' "
        sql &= " , MotivoAnulacion = " & dbStr(txtMotivoAnulacion.Valor, 500)
        sql &= " , UsuarioAnulacion = " & dbStr(StiGlobalConn.User)
        sql &= " , FechaAnulacion = " & dbFec(Date.Now, "1")
        sql &= " where idrecibo = " & dbStr(txtNumRecibo.Valor)

        StiGlobalConn.SQLExecute(sql)
        Me.LimpiarCampos(Me)
        Me.btnEliminar.Enabled = False
        MsgBox("El recibo ha sido anulado con éxito.")
    End Sub

    Private Sub RecibosAnulacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LimpiarCampos(Me)
    End Sub

End Class
