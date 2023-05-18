Imports Utilerias.Genericas

Public Class CambiarNumeroReclamo

    Private Sub btnBuscaReclamo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaReclamo.Click
        Try
            Dim Fbus As New BusquedaSiniestros
            Fbus.Text = "Búsqueda de Siniestros"
            Fbus.dbFiltro = ""
            busCodigo = ""
            Fbus.ShowDialog()
            If busCodigo <> "" Then
                Me.txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                Me.cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                Me.txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
                Me.txtIdSiniestro.Valor = stiSplit(busCodigo, "G3|1")

                Me.txtIdPolizaNuevo.Valor = stiSplit(busCodigo, "G0|1")
                Me.cboIdProductoNuevo.Valor = stiSplit(busCodigo, "G1|1")
                Me.txtIdCertificadoNuevo.Valor = stiSplit(busCodigo, "G2|1")
                Me.txtIdSiniestroNuevo.Valor = stiSplit(busCodigo, "G3|1")

            End If
        Catch ex As Exception
            msgError(ex)
        End Try
        
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CambiarNumeroReclamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProductoNuevo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
        Me.cboIdProductoNuevo.Llenar_Combo()
    End Sub

    Private Sub btnBuscaCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCertificado.Click
        Dim Fbus As New BusquedaCertReclamo
        Fbus.Text = "Búsqueda de Pólizas/Certificados/Bienes"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtIdPolizaNuevo.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboIdProductoNuevo.Valor = stiSplit(busCodigo, "G1|1")
            Me.txtIdCertificadoNuevo.Valor = stiSplit(busCodigo, "G2|1")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ''validaciones

        If Me.txtIdSiniestro.Text = "" Or Me.txtIdSiniestroNuevo.Text = "" Then
            MsgBox("Debe especificar los números de póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtIdPoliza.Text = "" Or Me.txtIdPolizaNuevo.Text = "" Then
            MsgBox("Debe especificar los números de póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtIdCertificado.Text = "" Or Me.txtIdCertificadoNuevo.Text = "" Then
            MsgBox("Debe especificar el certificado.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.cboIdProducto.Valor = "" Or Me.cboIdProductoNuevo.Valor = "" Then
            MsgBox("Debe especificar los productos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtIdPoliza.Valor = Me.txtIdPolizaNuevo.Valor And Me.cboIdProducto.Valor = Me.cboIdProductoNuevo.Valor And Me.txtIdCertificado.Valor = Me.txtIdCertificadoNuevo.Valor And Me.txtIdSiniestro.Valor = Me.txtIdSiniestroNuevo.Valor Then
            MsgBox("No se han especificado cambios a realizar.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        ''VERIFICAMOS SI EL NUEVO RECLAMO EXISTE
        Dim existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from siniestros where idproducto = " & dbStr(Me.cboIdProductoNuevo.Valor) & " and idpoliza = " & dbStr(Me.txtIdPolizaNuevo.Valor) & " and idcertificado = " & dbStr(Me.txtIdCertificadoNuevo.Valor) & " and idsiniestro = " & dbStr(Me.txtIdSiniestroNuevo.Valor)).Tables(0).Rows(0).Item(0)
        If existe > 0 Then
            MsgBox("El nuevo reclamo especificado ya existe en el sistema.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim IdPoliza As String = Me.txtIdPoliza.Valor, IdPolizaNew As String = Me.txtIdPolizaNuevo.Valor
        Dim IdProducto As String = Me.cboIdProducto.Valor, IdProductoNew As String = Me.cboIdProductoNuevo.Valor
        Dim IdSiniestro As String = Me.txtIdSiniestro.Valor, IdSiniestroNew As String = Me.txtIdSiniestroNuevo.Valor
        Dim IdCertificado As String = Me.txtIdCertificado.Valor, IdCertificadoNew As String = Me.txtIdCertificadoNuevo.Valor

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            ''deshabilitaremos los constraint
            StiGlobalConn.SQLExecute("ALTER TABLE Siniestros NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDetalle NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDeudores NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosInformacion NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosPagos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosRequisitos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosReservas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PreAutorizaciones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Gestiones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FlujosDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EnviosSiniestros NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EnviosSiniestrosDetalle NOCHECK CONSTRAINT ALL")


            ''cambiaremos los reclamos
            StiGlobalConn.SQLExecute("update Siniestros set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosDetalle set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosDeudores set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosDocumentos set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosInformacion set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosPagos set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosRequisitos set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update SiniestrosReservas set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))



            'cambios en gestiones/flujos/envios
            StiGlobalConn.SQLExecute("update PreAutorizaciones set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update Gestiones set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update FlujosDocumentos set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idsiniestro = " & dbStr(IdSiniestro))
            StiGlobalConn.SQLExecute("update EnviosSiniestrosDetalle set idsiniestro  = " & dbStr(IdSiniestroNew) & ", idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & ", idcertificado = " & dbStr(IdCertificadoNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificado) & " and idsiniestro = " & dbStr(IdSiniestro))


            'reactivamos los constraint

            StiGlobalConn.SQLExecute("ALTER TABLE Siniestros CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDetalle CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDeudores CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosInformacion CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosPagos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosRequisitos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosReservas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PreAutorizaciones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Gestiones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FlujosDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EnviosSiniestros CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EnviosSiniestrosDetalle CHECK CONSTRAINT ALL")


            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            Me.txtIdPoliza.Valor = ""
            Me.txtIdPolizaNuevo.Valor = ""
            Me.cboIdProducto.Valor = ""
            Me.cboIdProductoNuevo.Valor = ""
            Me.txtIdCertificado.Valor = ""
            Me.txtIdCertificadoNuevo.Valor = ""
            Me.txtIdSiniestro.Valor = ""
            Me.txtIdSiniestroNuevo.Valor = ""

            MsgBox("La operacaión ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try

    End Sub
End Class
