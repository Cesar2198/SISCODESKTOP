Imports Utilerias.Genericas

Public Class CambiosEnCertificados

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Me.txtCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Polizas where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try

            Call CargarCertificados()
        End If
    End Sub

    Private Sub CargarCertificados()
        'cargamos los certificados de la poliza
        Dim sql As String = ""
        sql = "  select IdCertificado, IdCertificadoAseguradora, NombreCliente, VigenciaDesde, VigenciaHasta, FechaExclusion, cast(0 as bit) as Incluir, EstadoCertificado"
        sql &= " from PolizasCertificados "
        sql &= " where idpoliza = " & dbStr(Me.txtPoliza.Valor) & " and idproducto = " & dbStr(Me.cboProducto.Valor)
        sql &= " order by IdCertificado"
        Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        Me.GridCertificados.DataSource = dtCertificados
        Me.GridCertificados.Refresh()
    End Sub

    Private Sub CambiosEnCertificados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtRazonCancela.Text.Trim = "" Then
            MsgBox("Debe especificar el motivo de la exclusión.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtFechaCancelacion.Text = "" Then
            MsgBox("Debe especificar la fecha de exclusión.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim lstCert As String = ""
        For I As Integer = 0 To Me.VistaCertificados.RowCount - 1
            If Me.VistaCertificados.GetRowCellValue(I, "Incluir") = True Then
                If lstCert = "" Then
                    lstCert = dbStr(Me.VistaCertificados.GetRowCellValue(I, "IdCertificado"))
                Else
                    lstCert &= "," & dbStr(Me.VistaCertificados.GetRowCellValue(I, "IdCertificado"))
                End If
            End If
        Next

        If lstCert = "" Then
            MsgBox("Debe marcar al menos un certificado para excluir.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Realmente desea excluir los certificados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'ahora cancelamos los certificados
            StiGlobalConn.SQLExecute("update PolizasCertificados set EstadoCertificado = 'CANCELADO', RazonExclusion = " & dbStr(txtRazonCancela.Text.Trim) & ", FechaExclusion = " & dbFec(Me.txtFechaCancelacion.Valor) & ", VigenciaDesde = " & dbFec(Me.txtFechaCancelacion.Valor) & " where IdPoliza =  " & dbStr(Me.txtPoliza.Valor) & " and IdProducto = " & dbStr(Me.cboProducto.Valor) & " and IdCertificado in (" & lstCert & ") ")

            'vamos a actualizar los certificados
            Dim dtCert As DataTable = StiGlobalConn.ObtenerDataset("select IdPoliza, IdCertificado, IdProducto from PolizasCertificados where IdPoliza =  " & dbStr(Me.txtPoliza.Valor) & " and IdProducto = " & dbStr(Me.cboProducto.Valor) & " and IdCertificado in (" & lstCert & ") ").Tables(0)
            For Each FilCert As DataRow In dtCert.Rows

                Dim frmCert As New PolizasCertificadosMan
                frmCert.dbTabla = "PolizasCertificados"
                frmCert.STIConn = StiGlobalConn
                frmCert.Permiso = Me.Permiso
                frmCert.dbCondicion = "IdPoliza = " & dbStr(dbData(FilCert, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(FilCert, "IdProducto")) & " and IdCertificado = " & dbStr(dbData(FilCert, "IdCertificado"))
                frmCert.WindowState = FormWindowState.Minimized
                frmCert.MostrarMensajes = False
                frmCert.Show()
                frmCert.txtVigenciaDesde_ValueChangeOnExit(Nothing, Nothing, Nothing)
                frmCert.btnGuardar.PerformClick()
                frmCert.Close()
            Next

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            MsgBox("Los certificados marcados han sido excluidos con éxito.", MsgBoxStyle.Information, "AVISO...")
            Call CargarCertificados()
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Error al excluir los certificados, la operación no se ha completado: " & ex.Message, MsgBoxStyle.Critical, "ERROR...")

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim lstCert As String = ""
        For I As Integer = 0 To Me.VistaCertificados.RowCount - 1
            If Me.VistaCertificados.GetRowCellValue(I, "Incluir") = True Then
                If lstCert = "" Then
                    lstCert = dbStr(Me.VistaCertificados.GetRowCellValue(I, "IdCertificado"))
                Else
                    lstCert &= "," & dbStr(Me.VistaCertificados.GetRowCellValue(I, "IdCertificado"))
                End If
            End If
        Next

        If lstCert = "" Then
            MsgBox("Debe marcar al menos un certificado para rehabilitar.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Realmente desea rehabilitar los certificados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'ahora cancelamos los certificados
            StiGlobalConn.SQLExecute("update PolizasCertificados set EstadoCertificado = 'VIGENTE', RazonExclusion = null, FechaExclusion = null where IdPoliza =  " & dbStr(Me.txtPoliza.Valor) & " and IdProducto = " & dbStr(Me.cboProducto.Valor) & " and IdCertificado in (" & lstCert & ") ")

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            MsgBox("Los certificados marcados han sido rehabilitados con éxito.", MsgBoxStyle.Information, "AVISO...")
            Call CargarCertificados()
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Error al rehabilitar los certificados, la operación no se ha completado: " & ex.Message, MsgBoxStyle.Critical, "ERROR...")

        End Try
    End Sub

End Class
