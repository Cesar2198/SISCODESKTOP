Imports Utilerias.Genericas

Public Class CambiarNumeroPoliza

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                Dim sql As String = ""

                sql = "  select p.IdPoliza, p.IdProducto, p.IdCliente, p.NombreCliente"
                sql &= " from Polizas as p "
                sql &= " where p.IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and p.IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))

                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtIdPoliza.Valor = dbData(FilPol, "IdPoliza")
                cboIdProducto.Valor = dbData(FilPol, "IdProducto")
                txtNombreCliente.Valor = dbData(FilPol, "NombreCliente")

                txtIdPolizaNuevo.Valor = dbData(FilPol, "IdPoliza")
                cboIdProductoNuevo.Valor = dbData(FilPol, "IdProducto")


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CambiarNumeroPoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Me.cboIdProductoNuevo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProductoNuevo.Llenar_Combo()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ''validaciones
        If Me.txtIdPoliza.Text = "" Or Me.txtIdPolizaNuevo.Text = "" Then
            MsgBox("Debe especificar los números de póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.cboIdProducto.Valor = "" Or Me.cboIdProductoNuevo.Valor = "" Then
            MsgBox("Debe especificar los productos.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtIdPoliza.Valor = Me.txtIdPolizaNuevo.Valor And Me.cboIdProducto.Valor = Me.cboIdProductoNuevo.Valor Then
            MsgBox("No se han especificado cambios a realizar.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        ''VERIFICAMOS SI LA NUEVA PÓLIZA YA EXISTE
        Dim existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas where idproducto = " & dbStr(Me.cboIdProductoNuevo.Valor) & " and idpoliza = " & dbStr(Me.txtIdPolizaNuevo.Valor)).Tables(0).Rows(0).Item(0)
        If existe > 0 Then
            MsgBox("El nuevo número de póliza especificado ya existe en el sistema.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim IdPoliza As String = Me.txtIdPoliza.Valor, IdPolizaNew As String = Me.txtIdPolizaNuevo.Valor
        Dim IdProducto As String = Me.cboIdProducto.Valor, IdProductoNew As String = Me.cboIdProductoNuevo.Valor

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            ''deshabilitaremos los constraint
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobroFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobro NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FacturasMovimientos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Facturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasAbono NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasCredito NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE RecibosFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaComisionesFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaVendedoresFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Planes NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasBeneficiarios NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasBienes NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCesiones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasClausulas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCoberturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCoberturasAdicional NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCertificados NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasBeneficiarios NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasBienes NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCesiones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasClausulas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCoberturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCoberturasAdicional NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCertificados NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasVendedores NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBeneficiarios NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBienes NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCesiones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasClausulas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturasAdicional NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCertificados NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasVendedores NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Polizas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PreAutorizaciones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EnviosSiniestrosDetalle NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestroPlanes NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Siniestros NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDetalle NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDeudores NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosInformacion NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosPagos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosRequisitos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosReservas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FlujosDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Gestiones NOCHECK CONSTRAINT ALL")


            ''polizas
            StiGlobalConn.SQLExecute("update HPolizasBeneficiarios set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasBienes set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasCesiones set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasClausulas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasCoberturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasCoberturasAdicional set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasDocumentos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasCertificados set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizasVendedores set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update HPolizas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasBeneficiarios set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasBienes set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasCesiones set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasClausulas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasCoberturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasCoberturasAdicional set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasDocumentos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasCertificados set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update PolizasVendedores set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update Polizas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))


            'cartera
            StiGlobalConn.SQLExecute("update AvisosCobroFacturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update AvisosCobro set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update FacturasMovimientos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update Facturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update NotasAbono set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update NotasCredito set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update RecibosFacturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))

            ''comisiones
            StiGlobalConn.SQLExecute("update EstadosCuentaComisionesFacturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update EstadosCuentaVendedoresFacturas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))


            ''cambiaremos los reclamos
            StiGlobalConn.SQLExecute("update PreAutorizaciones set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update EnviosSiniestrosDetalle set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestroPlanes set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update Siniestros set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosDetalle set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosDeudores set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosDocumentos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosInformacion set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosPagos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosRequisitos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update SiniestrosReservas set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))

            'flujos
            StiGlobalConn.SQLExecute("update FlujosDocumentos set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))
            StiGlobalConn.SQLExecute("update Gestiones set idproducto = " & dbStr(IdProductoNew) & ", idpoliza = " & dbStr(IdPolizaNew) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza))


            'reactivamos el constraint
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobroFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobro CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FacturasMovimientos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Facturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasAbono CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasCredito CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE RecibosFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaComisionesFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaVendedoresFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Planes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasBeneficiarios CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasBienes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCesiones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasClausulas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCoberturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCoberturasAdicional CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizasCertificados CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE CPolizas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasBeneficiarios CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasBienes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCesiones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasClausulas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCoberturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCoberturasAdicional CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasCertificados CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizasVendedores CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBeneficiarios CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBienes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCesiones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasClausulas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturasAdicional CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCertificados CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasVendedores CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Polizas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PreAutorizaciones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EnviosSiniestrosDetalle CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestroPlanes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Siniestros CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDetalle CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDeudores CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosInformacion CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosPagos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosRequisitos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE SiniestrosReservas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FlujosDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Gestiones CHECK CONSTRAINT ALL")

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            Me.txtIdPoliza.Valor = ""
            Me.txtIdPolizaNuevo.Valor = ""
            Me.txtNombreCliente.Valor = ""
            Me.cboIdProducto.Valor = ""
            Me.cboIdProductoNuevo.Valor = ""

            MsgBox("La operacaión ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try

    End Sub

End Class
