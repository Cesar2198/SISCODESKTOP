
Imports Utilerias.Genericas

Public Class ClientesTraslados

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdClienteDestino.Valor = busCodigo
            Try
                txtNombreClienteDestino.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If txtIdCliente.Text = "" Then
            MsgBox("Debe especificar el cliente al que se le quitará la cartera.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtIdClienteDestino.Text = "" Then
            MsgBox("Debe especificar el cliente al que se le asignará la cartera.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim sql As String = ""
        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'cambiaremos el nit de las tablas relacionadas
            StiGlobalConn.SQLExecute("update AvisosCobro set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update Facturas set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update OfertasComparativo set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update CPolizas set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update CPolizasCertificados set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update HPolizas set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update HPolizasCertificados set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update Polizas set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update PolizasCertificados set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update Recibos set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update FlujosDocumentos set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update Ubicaciones set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))
            StiGlobalConn.SQLExecute("update CGPolizas set IdCliente = " & dbStr(txtIdClienteDestino.Valor) & " where IdCliente = " & dbStr(txtIdCliente.Valor))

            'el traslado de los depótitos es muy particular puesto que el cliente es llave
            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Depositos where IdCliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
            If Existe > 0 Then
                Existe = StiGlobalConn.ObtenerDataset("select count(*) from Depositos where IdCliente = " & dbStr(txtIdClienteDestino.Valor)).Tables(0).Rows(0).Item(0)
                If Existe = 0 Then
                    sql = " insert into Depositos (IdCliente, NombreCliente, Observaciones) "
                    sql &= " select " & dbStr(txtIdClienteDestino.Valor) & ", " & dbStr(txtNombreClienteDestino.Valor) & ", Observaciones"
                    sql &= " from Depositos where IdCliente = " & dbStr(txtIdCliente.Valor)
                    StiGlobalConn.SQLExecute(sql)

                    sql = " insert into DepositosMovimientos (IdCliente, IdMovimiento, IdAseguradora, IdTipo, FechaMovimiento, Descripcion, ValorDeposito, Usuario) "
                    sql &= " select " & dbStr(txtIdClienteDestino.Valor) & ", IdMovimiento, IdAseguradora, IdTipo, FechaMovimiento, Descripcion, ValorDeposito, Usuario"
                    sql &= " from DepositosMovimientos where IdCliente = " & dbStr(txtIdCliente.Valor)
                    StiGlobalConn.SQLExecute(sql)
                Else
                    Dim DtDep As DataTable = StiGlobalConn.ObtenerDataset("select * from DepositosMovimientos where IdCliente = " & dbStr(txtIdCliente.Valor)).Tables(0)
                    Dim FilDep As DataRow, IdMov As Integer = 0
                    For Each FilDep In DtDep.Rows
                        IdMov = clSeguros.ObtenerIDTabla("DepositosMovimientos", "IdMovimiento", "IdCliente=" & dbStr(txtIdClienteDestino.Valor))

                        sql = " insert into DepositosMovimientos (IdCliente, IdMovimiento, IdAseguradora, IdTipo, FechaMovimiento, Descripcion, ValorDeposito, Usuario) values( "
                        sql &= dbStr(txtIdClienteDestino.Valor) & C & dbInt(IdMov) & C & dbStr(dbData(FilDep, "IdAseguradora")) & C & dbStr(dbData(FilDep, "IdTipo")) & C & dbFec(dbData(FilDep, "FechaMovimiento")) & C & dbStr(dbData(FilDep, "Descripcion")) & C & dbNum(dbData(FilDep, "ValorDeposito")) & C & dbStr(dbData(FilDep, "Usuario")) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    Next
                End If

                StiGlobalConn.SQLExecute("delete from DepositosMovimientos where IdCliente = " & dbStr(txtIdCliente.Valor))
                StiGlobalConn.SQLExecute("delete from Depositos where IdCliente = " & dbStr(txtIdCliente.Valor))

            End If

            RegistrarLog("M", "Clientes", "Traslado Cartera de Clientes: " & txtIdCliente.Valor & " a " & txtIdClienteDestino.Valor)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            Me.txtIdCliente.Valor = ""
            Me.txtIdClienteDestino.Valor = ""
            Me.txtNombreCliente.Valor = ""
            Me.txtNombreClienteDestino.Valor = ""

            MsgBox("La operación se ha completado con éxito.", MsgBoxStyle.Information, "AVISO...")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Ocurrió un error al transferir la cartera, la operación ha sido cancelada." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub
End Class
