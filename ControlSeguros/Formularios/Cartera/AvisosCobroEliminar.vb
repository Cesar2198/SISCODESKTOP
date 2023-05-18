
Imports Utilerias.Genericas

Public Class AvisosCobroEliminar

    Private Sub btnBuscarAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAC.Click
        Dim fbus As New BusquedaAC
        Dim sql As String = ""
        'Buscamos solo facturas pendientes de pago
        fbus.dbFiltro = ""
        busCodigo = ""
        fbus.ShowDialog()
        If busCodigo <> "" Then
            Dim IdAC As String = stiSplit(busCodigo, "G0|1")
            Try
                Me.txtIdAC.Valor = IdAC
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If txtIdAC.Text = "" And txtIdCliente.Text = "" And txtIdPoliza.Text = "" Then
            MsgBox("Debe especificar un parámetro para borrar los avisos de cobro y sus facturas.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Realmente desea borrar los Avisos Especificados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.Yes Then

            If txtIdAC.Text <> "" Then
                Try
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset("select * from AvisosCobroFacturas where IdAvisoCobro = " & dbStr(txtIdAC.Valor)).Tables(0)
                    Dim filFact As DataRow
                    For Each filFact In dtFacturas.Rows
                        StiGlobalConn.SQLExecute("DELETE FROM EstadosCuentaComisionesFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM EstadosCuentaVendedoresFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM RecibosFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM FacturasMovimientos where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM Facturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                    Next
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroGastos WHERE IdAvisoCobro = " & dbStr(txtIdAC.Valor))
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroDescuentos WHERE IdAvisoCobro = " & dbStr(txtIdAC.Valor))
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroFacturas WHERE IdAvisoCobro = " & dbStr(txtIdAC.Valor))
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobro WHERE IdAvisoCobro = " & dbStr(txtIdAC.Valor))

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                    MsgBox("El aviso de cobro: " & Me.txtIdAC.Text & " se ha eliminado con éxito.", MsgBoxStyle.Information, "AVISO...")
                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    msgError(ex)
                End Try
            End If

            If txtIdPoliza.Text <> "" Then
                Try
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset("select * from AvisosCobroFacturas where idproducto = " & dbStr(stiSplit(txtIdPoliza.Text, "G0|1")) & " and idpoliza = " & dbStr(stiSplit(txtIdPoliza.Text, "G1|1"))).Tables(0)
                    Dim filFact As DataRow
                    For Each filFact In dtFacturas.Rows
                        StiGlobalConn.SQLExecute("DELETE FROM EstadosCuentaComisionesFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM EstadosCuentaVendedoresFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM RecibosFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM FacturasMovimientos where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM Facturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                    Next
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroGastos WHERE IdAvisoCobro in (select IdAvisoCobro from AvisosCobro where idproducto = " & dbStr(stiSplit(txtIdPoliza.Text, "G0|1")) & " and idpoliza = " & dbStr(stiSplit(txtIdPoliza.Text, "G1|1")) & " )")
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroDescuentos WHERE IdAvisoCobro in (select IdAvisoCobro from AvisosCobro where idproducto = " & dbStr(stiSplit(txtIdPoliza.Text, "G0|1")) & " and idpoliza = " & dbStr(stiSplit(txtIdPoliza.Text, "G1|1")) & " )")
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroFacturas WHERE IdAvisoCobro in (select IdAvisoCobro from AvisosCobro where idproducto = " & dbStr(stiSplit(txtIdPoliza.Text, "G0|1")) & " and idpoliza = " & dbStr(stiSplit(txtIdPoliza.Text, "G1|1")) & " )")
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobro WHERE idproducto = " & dbStr(stiSplit(txtIdPoliza.Text, "G0|1")) & " and idpoliza = " & dbStr(stiSplit(txtIdPoliza.Text, "G1|1")))

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                    MsgBox("Los Avisos de cobro para la póliza:" & Me.txtIdPoliza.Text & " se han eliminado con éxito.", MsgBoxStyle.Information, "AVISO...")
                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    msgError(ex)
                End Try
            End If

            If txtIdCliente.Text <> "" Then
                Try
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset("select a.idpoliza, a.idproducto, a.numerofactura, a.idramo from  AvisosCobroFacturas as a inner join AvisosCobro as b on a.IdAvisoCobro = b.IdAvisoCobro where b.IdCliente = " & dbStr(txtIdCliente.Valor)).Tables(0)
                    Dim filFact As DataRow
                    For Each filFact In dtFacturas.Rows
                        StiGlobalConn.SQLExecute("DELETE FROM EstadosCuentaComisionesFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM EstadosCuentaVendedoresFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM RecibosFacturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM FacturasMovimientos where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                        StiGlobalConn.SQLExecute("DELETE FROM Facturas where IdPoliza = " & dbStr(dbData(filFact, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(filFact, "IdProducto")) & " and NumeroFactura =  " & dbInt(dbData(filFact, "NumeroFactura")) & " and IdRamo = " & dbStr(dbData(filFact, "IdRamo")))
                    Next
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroGastos WHERE IdAvisoCobro in (select IdAvisoCobro from AvisosCobro where idcliente = " & dbStr(txtIdCliente.Valor) & " )")
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroDescuentos WHERE IdAvisoCobro in (select IdAvisoCobro from AvisosCobro where idcliente = " & dbStr(txtIdCliente.Valor) & " )")
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobroFacturas WHERE IdAvisoCobro in (select IdAvisoCobro from AvisosCobro where idcliente = " & dbStr(txtIdCliente.Valor) & " )")
                    StiGlobalConn.SQLExecute("DELETE FROM AvisosCobro WHERE idcliente = " & dbStr(txtIdCliente.Valor))

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                    MsgBox("Los Avisos de cobro para el cliente:" & Me.txtIdCliente.Text & " se han eliminado con éxito.", MsgBoxStyle.Information, "AVISO...")
                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    msgError(ex)
                End Try
            End If

        End If
    End Sub

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdPoliza.Valor = stiSplit(busCodigo, "G1|1") & "|" & stiSplit(busCodigo, "G0|1")
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        Dim sql As String = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
        End If
    End Sub

End Class
