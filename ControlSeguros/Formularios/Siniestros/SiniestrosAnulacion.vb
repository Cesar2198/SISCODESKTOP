Imports Utilerias.Genericas

Public Class SiniestrosAnulacion

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaReclamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaReclamo.Click
        Try
            Dim frmBusSin As New BusquedaSiniestros
            frmBusSin.dbFiltro = " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE')"
            frmBusSin.Text = "Búsqueda de Reclamos Pendientes"
            busCodigo = ""
            frmBusSin.ShowDialog()
            If busCodigo <> "" Then
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
                txtIdSiniestro.Valor = stiSplit(busCodigo, "G3|1")
                ''buscaremos informacion adicional
                Dim sql As String = ""
                Try
                    sql = "  select "
                    sql &= " FechaOcurrido, FechaPresentado, DescripcionSiniestro"
                    sql &= " from siniestros "
                    sql &= " where idproducto = " & dbStr(Me.cboIdProducto.Valor)
                    sql &= " and idpoliza = " & dbStr(Me.txtIdPoliza.Valor)
                    sql &= " and idcertificado = " & dbStr(Me.txtIdCertificado.Valor)
                    sql &= " and idsiniestro = " & dbStr(Me.txtIdSiniestro.Valor)
                    Dim filSin As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Me.txtFechaOcurrido.Valor = dbData(filSin, "FechaOcurrido")
                    Me.txtFechaPresentado.Valor = dbData(filSin, "FechaPresentado")
                    Me.txtDescripcionSiniestro.Valor = dbData(filSin, "DescripcionSiniestro")
                    Me.txtDescripcionReserva.Focus()

                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub SiniestrosAnulacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Me.cboEstadoSiniestro.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEstadoSiniestro.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.txtIdSiniestro.Text = "" Then
            MsgBox("Debe especificar el reclamo que desea anula", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtDescripcionReserva.Text = "" Or Me.cboEstadoSiniestro.Text = "" Then
            MsgBox("Debe especificar el motivo y tipo de la anulación.", MsgBoxStyle.Information, "AVISO..")
            Exit Sub
        End If

        Dim sql As String = ""
        Try
            ''Anularemos el reclamo
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Call AnularReclamo(Me.txtIdPoliza.Valor, Me.cboIdProducto.Valor, Me.txtIdCertificado.Valor, Me.txtIdSiniestro.Valor, Me.txtDescripcionReserva.Valor, TipoAnulacion:=Me.cboEstadoSiniestro.Valor)

            'si existen flujos relacionados los cerramos
            clFlujos.CerrarFlujoSiniestro(txtIdSiniestro.Valor, txtIdPoliza.Valor, cboIdProducto.Valor)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("El reclamo ha sido anulado con éxito.", MsgBoxStyle.Information, "AVISO...")
            Call LimpiarEntradas()
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Error al intentar anular el recibo." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "ERROR...")
        End Try

    End Sub

    Private Sub LimpiarEntradas()
        Me.txtDescripcionSiniestro.Valor = ""
        Me.txtFechaOcurrido.Valor = ""
        Me.txtFechaPresentado.Valor = ""
        Me.txtIdCertificado.Valor = ""
        Me.txtIdPoliza.Valor = ""
        Me.txtIdSiniestro.Valor = ""
        Me.cboIdProducto.Valor = ""
    End Sub

End Class
