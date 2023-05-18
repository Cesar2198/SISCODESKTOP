
Imports Utilerias.Genericas

Public Class EnviosPagoMan

    Private Sub EnviosPagoMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EstadoEntradas(False, Me)
        If Me.txtMotivoAnulacion.Text <> "" Then
            Me.btnAnular.Enabled = False
            Me.btnImprimir.Enabled = False
        End If

        'Me.cboIdAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        'Me.cboIdAseguradora.Llenar_Combo()

        ''cargaremos los recibos
        Dim sql As String = ""
        sql = "  select IdRecibo, NombreCliente as Nombre, TotalRecibo as Total "
        sql &= " from Recibos where idrecibo in (select idrecibo from EnviosPagoRecibos where IdEnvio = " & dbStr(txtIdEnvio.Valor) & ")"

        Dim Recibos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        Me.GridRecibos.DataSource = Recibos
        Me.GridRecibos.Refresh()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'ahora como el envio ha sido almacenado procedemos a la impresión
        Dim msgError As String = ImprimirEnvioCaja(dbStr(txtIdEnvio.Valor), "", "", "", "", "")
        If msgError.Trim <> "" Then
            MsgBox(msgError, MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If MsgBox("¿Realmente desea anular el Envío?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            Dim Motivo As String = InputBox("Especifique el motivo de la anulación", "MOTIVO...", "")
            If Motivo.Trim = "" Then
                MsgBox("Debe especificar el motivo de la anulación", MsgBoxStyle.Exclamation, "AVISO..")
                Exit Sub
            End If

            Try
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                ''actualizamos el envio
                StiGlobalConn.SQLExecute("update EnviosPago set MotivoAnulacion = " & dbStr(Motivo, 500) & " , FechaAnulacion = " & dbFec(Date.Today) & " where IdEnvio = " & dbStr(txtIdEnvio.Valor))

                ''desmarcaremos los recibos como enviados
                Dim sql As String = ""
                sql = " update Recibos set EnviadoAseguradoras = 'P'"
                sql &= " where IdRecibo in (select IdRecibo from EnviosPagoRecibos where IdEnvio = " & dbStr(txtIdEnvio.Valor) & ")"
                StiGlobalConn.SQLExecute(sql)

                StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

                MsgBox("El envío ha sido anulado con éxito", MsgBoxStyle.Information, "AVISO...")
                Me.Close()

            Catch ex As Exception
                StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                msgError(ex)
            End Try
        End If
    End Sub
End Class
