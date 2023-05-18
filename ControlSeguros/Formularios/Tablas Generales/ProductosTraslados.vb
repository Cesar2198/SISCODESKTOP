Imports Utilerias.Genericas

Public Class ProductosTraslados

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ProductosTraslados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboProductoPrincipal.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboProductoPrincipal.Llenar_Combo()

        cboProductoUnificado.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboProductoUnificado.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If cboProductoPrincipal.Text = "" Then
            MsgBox("Debe especificar el producto a permanecer.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If cboProductoUnificado.Text = "" Then
            MsgBox("Debe especificar el producto a ser unificado.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Está seguro de proceder con la unificación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim IdProducto As String = cboProductoPrincipal.Valor
        Dim IdProductoBorrar As String = cboProductoUnificado.Valor

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'deshabilitaremos los constraint y luego se activarán.
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
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBeneficiarios NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBienes NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCesiones NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasClausulas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturasAdicional NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasDocumentos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCertificados NOCHECK CONSTRAINT ALL")
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

            'cartera
            StiGlobalConn.SQLExecute("update AvisosCobroFacturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update AvisosCobro set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update FacturasMovimientos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update Facturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update NotasAbono set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update NotasCredito set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update RecibosFacturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))

            'comisiones
            StiGlobalConn.SQLExecute("update EstadosCuentaComisionesFacturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update EstadosCuentaVendedoresFacturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))

            'polizas
            StiGlobalConn.SQLExecute("update Planes set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasBeneficiarios set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasBienes set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasCesiones set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasClausulas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasCoberturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasCoberturasAdicional set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasDocumentos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizasCertificados set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update CPolizas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasBeneficiarios set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasBienes set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasCesiones set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasClausulas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasCoberturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasCoberturasAdicional set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasDocumentos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizasCertificados set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update HPolizas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasBeneficiarios set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasBienes set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasCesiones set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasClausulas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasCoberturas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasCoberturasAdicional set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasDocumentos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update PolizasCertificados set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update Polizas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))

            'reclamos
            StiGlobalConn.SQLExecute("update PreAutorizaciones set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update EnviosSiniestrosDetalle set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestroPlanes set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update Siniestros set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosDetalle set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosDeudores set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosDocumentos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosInformacion set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosPagos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosRequisitos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("update SiniestrosReservas set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))

            'flujos
            StiGlobalConn.SQLExecute("update FlujosDocumentos set idproducto = " & dbStr(IdProducto) & " where idproducto = " & dbStr(IdProductoBorrar))


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
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBeneficiarios CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBienes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCesiones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasClausulas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturasAdicional CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCertificados CHECK CONSTRAINT ALL")
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

            'borramos el producto
            StiGlobalConn.SQLExecute("delete from ProductosSinRequisitos where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosSinGastos where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosSinComplementos where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosGastos where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosComisionesInternas where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosComisionesExternas where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosCoberturas where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from ProductosBienes where idproducto = " & dbStr(IdProductoBorrar))
            StiGlobalConn.SQLExecute("delete from Productos where idproducto = " & dbStr(IdProductoBorrar))

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("La operación ha sido completada con éxito.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")

            'los errores posibles pueden darse por data que se duplica por unificar.
            'el rollback revirtió los cambio de update, nos aseguramos de rehabilitar los constraint

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
            StiGlobalConn.SQLExecute("ALTER TABLE HPolizas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBeneficiarios CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasBienes CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCesiones CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasClausulas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCoberturasAdicional CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasDocumentos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE PolizasCertificados CHECK CONSTRAINT ALL")
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

            MsgBox("Error al realizar la unificación, la operación ha sido cancelada" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

End Class
