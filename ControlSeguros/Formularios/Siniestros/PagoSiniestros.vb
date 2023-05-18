Imports Utilerias.Genericas

Public Class PagoSiniestros

    Private Sub PagoSiniestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()

        cboEstado.Llenar_Combo()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscaSiniestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaSiniestro.Click
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

            'buscaremos el beneficiario del cheuqe.
            Try
                Dim sql As String = ""
                sql = "  select NombrePresentaReclamo, TotalCubierto, TotalDeducible, TotalCoaseguro, TotalDeudores, TotalReembolso, DescripcionReserva "
                sql &= " from siniestros "
                sql &= " where idpoliza = " & dbStr(Me.txtIdPoliza.Valor)
                sql &= " and idproducto = " & dbStr(Me.cboIdProducto.Valor)
                sql &= " and idcertificado = " & dbStr(Me.txtIdCertificado.Valor)
                sql &= " and idsiniestro = " & dbStr(Me.txtIdSiniestro.Valor)
                Dim FilaSin As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtDescripcionReserva.Valor = dbData(FilaSin, "DescripcionReserva")
                txtNombreCheque.Valor = dbData(FilaSin, "NombrePresentaReclamo")
                txtValorGasto.Valor = Val(dbData(FilaSin, "TotalCubierto")) - Val(dbData(FilaSin, "TotalDeducible")) - Val(dbData(FilaSin, "TotalCoaseguro")) - Val(dbData(FilaSin, "TotalDeudores")) - Val(dbData(FilaSin, "TotalReembolso"))
                Call txtValorGasto_ValueChangeOnExit(Nothing, Nothing, "")

            Catch ex As Exception

            End Try

            Me.txtNombreCheque.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'revisamos los campos obligatorios
        Dim Validaciones As String = Me.ValidarCamposObligatorios(Me)
        If Validaciones <> "" Then
            MsgBox("Deben ser completados los siguientes datos: " & Validaciones, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'el total del pago debe ser positivo
        If txtValorReembolso.Valor <= 0 Then
            MsgBox("El valor del reembolso debe ser mayor a cero.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        'Validación: que no se meta dos veces el mismo número de cheque
        Dim ExistePago As Integer = 0
        Try
            ExistePago = StiGlobalConn.ObtenerDataset("select count(*) from SiniestrosPagos where NumeroCheque = " & dbStr(txtNumeroCheque.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            ExistePago = 0
        End Try
        If ExistePago > 0 Then
            MsgBox("El pago con el número de cheque especificado ya ha sido ingresado en el reclamo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'lo que se hará será ingresar el pago, actualizar los totales del siestro y el estado.


            Dim IdPago As Integer = Val(StiGlobalConn.ObtenerDataset("select isnull(max(IdPago),0) + 1 from SiniestrosPagos where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0))
            Dim sql As String = ""

            sql = "  insert into SiniestrosPagos "
            sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdPago, FechaPago, NombreCheque"
            sql &= " , NumeroCheque, ValorGasto, ValorDescuento, ValorRenta, ValorIva,ValorRetencionIva, ValorReembolso) values("
            sql &= dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & C & dbStr(txtIdCertificado.Valor) & C & dbStr(txtIdSiniestro.Valor) & C & dbInt(IdPago) & C & dbFec(txtFechaPago.Valor) & C & dbStr(txtNombreCheque.Valor, 150) & C
            sql &= dbStr(txtNumeroCheque.Valor) & C & dbNum(txtValorGasto.Valor) & C & dbNum(txtValorDescuento.Valor) & C & dbNum(txtValorRenta.Valor) & C & dbNum(txtValorIva.Valor) & C & dbNum(txtValorRetencionIva.Valor) & C & dbNum(txtValorReembolso.Valor) & ")"
            StiGlobalConn.SQLExecute(sql)

            'con el pago ingresado disminuimos la reserva.
            Dim IdReserva As Integer = clSeguros.ObtenerIDTabla("SiniestrosReservas", "IdReserva", "IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor))
            sql = "  insert into SiniestrosReservas "
            sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva,"
            sql &= " FechaReserva, ValorAsegurado, ValorReserva) values("
            sql &= dbStr(txtIdPoliza.Valor, 25) & C & dbStr(cboIdProducto.Valor, 25) & C & dbStr(txtIdCertificado.Valor, 25) & C & dbStr(txtIdSiniestro.Valor, 25) & C & dbInt(IdReserva) & C
            sql &= dbFec(txtFechaPago.Valor) & C & dbNum(0) & C & dbNum(txtValorReembolso.Valor * -1) & ")"
            StiGlobalConn.SQLExecute(sql)


            If Me.cboEstado.Valor = "PAGADO" Then
                'saldamos la reserva
                Dim TotReserva As Double = StiGlobalConn.ObtenerDataset("select isnull(sum(ValorReserva),0) from SiniestrosReservas where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0)
                Dim ReservaReportada As Double = 0
                Select Case TotReserva
                    Case 0.0
                        ReservaReportada = 0
                    Case Else
                        ReservaReportada = TotReserva * -1
                End Select

                IdReserva = clSeguros.ObtenerIDTabla("SiniestrosReservas", "IdReserva", "IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor))
                sql = "  insert into SiniestrosReservas "
                sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva,"
                sql &= " FechaReserva, ValorAsegurado, ValorReserva) values("
                sql &= dbStr(txtIdPoliza.Valor, 25) & C & dbStr(cboIdProducto.Valor, 25) & C & dbStr(txtIdCertificado.Valor, 25) & C & dbStr(txtIdSiniestro.Valor, 25) & C & dbInt(IdReserva) & C
                sql &= dbFec(txtFechaPago.Valor) & C & dbNum(0) & C & dbNum(ReservaReportada) & ")"
                StiGlobalConn.SQLExecute(sql)

                'si existen flujos relacionados los cerramos, pues el reclamo ya está pagado.
                clFlujos.CerrarFlujoSiniestro(txtIdSiniestro.Valor, txtIdPoliza.Valor, cboIdProducto.Valor)

            End If

            'actualizamos los totales del siniestro

            sql = "  update siniestros set "
            sql &= " EstadoSiniestro = " & dbStr(cboEstado.Valor)
            sql &= " ,DescripcionReserva = " & dbStr(txtDescripcionReserva.Valor)
            sql &= " ,TotalPresentado = isnull((select sum(ValorPresentado) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalNoCubierto = isnull((select sum(ValorNoCubierto) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalCubierto = isnull((select sum(ValorCubierto) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalReembolso = isnull((select sum(ValorReembolso) from SiniestrosPagos where SiniestrosPagos.IdPoliza = siniestros.IdPoliza and SiniestrosPagos.IdProducto = siniestros.IdProducto and SiniestrosPagos.IdCertificado = siniestros.IdCertificado and SiniestrosPagos.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalPendiente = isnull((select sum(ValorReserva) from SiniestrosReservas where SiniestrosReservas.IdPoliza = siniestros.IdPoliza and SiniestrosReservas.IdProducto = siniestros.IdProducto and SiniestrosReservas.IdCertificado = siniestros.IdCertificado and SiniestrosReservas.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " where IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdCertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)
            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            MsgBox("El pago se ha ingresado con éxito.", MsgBoxStyle.Information, "AVISO...")
            LimpiarCampos(Me)
            btnBuscaSiniestro.Focus()

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try
    End Sub

    Private Sub ActualizarIva()
        Try
            Dim PorceIva As Double = Val(clSeguros.ObtenerDBParametros("Porce.Iva")) / 100
            txtValorIva.Valor = (txtValorGasto.Valor - txtValorDescuento.Valor) * PorceIva
            Call ActualizaTotales()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActualizaTotales()
        Try
            txtValorReembolso.Valor = txtValorGasto.Valor - txtValorDescuento.Valor - txtValorRenta.Valor + txtValorIva.Valor - txtValorRetencionIva.Valor
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtValorGasto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtValorGasto.ValueChangeOnExit
        Call ActualizarIva()
    End Sub

    Private Sub txtValorDescuento_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtValorDescuento.ValueChangeOnExit
        Call ActualizarIva()
    End Sub

    Private Sub txtValorRenta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtValorRenta.ValueChangeOnExit
        Call ActualizaTotales()
    End Sub

    Private Sub txtValorIva_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtValorIva.ValueChangeOnExit
        Call ActualizaTotales()
    End Sub

    Private Sub txtValorRetencionIva_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtValorRetencionIva.ValueChangeOnExit
        Call ActualizaTotales()
    End Sub

End Class
