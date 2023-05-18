
Imports Utilerias.Genericas

Public Class PagoDeudores

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
            txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
            cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
            txtIdSiniestro.Valor = stiSplit(busCodigo, "G3|1")

            'verificaremos si el reclamo tiene saldo deudores
            Dim Saldo As Double = 0
            Try
                Saldo = StiGlobalConn.ObtenerDataset("select isnull(sum(ValorDeudor),0) from SiniestrosDeudores where IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdProducto = " & dbStr(Me.cboIdProducto.Valor) & " and IdCertificado = " & dbStr(Me.txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(Me.txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Saldo = 0
            End Try
            If Saldo <= 0 Then
                MsgBox("El reclamo no presenta saldo para deudor vario que aplicar.", MsgBoxStyle.Information, "AVISO...")
                Me.btnGuardar.Enabled = False
            Else
                Me.btnGuardar.Enabled = True
                Me.txtDescripcionPago.Focus()
            End If
        End If
    End Sub

    Private Sub PagoDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnGuardar.Enabled = False
        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()
        Me.txtFechaPago.Valor = Date.Today

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'VERIFICAMOS LOS CAMPOS OBLIGATORIOS

        If txtIdSiniestro.Text = "" Then
            MsgBox("Debe especificar el reclamo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtDescripcionPago.Text = "" Then
            MsgBox("Debe especificar el concepto de pago.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtFechaPago.Text = "" Then
            MsgBox("Debe especificar la fecha de pago.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtValorPago.Valor <= 0 Then
            MsgBox("Debe especificar un valor de pago.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'verificaremos que el valor de pago no exeda el saldo
        Dim Saldo As Double = 0
        Try
            Saldo = StiGlobalConn.ObtenerDataset("select isnull(sum(ValorDeudor),0) from SiniestrosDeudores where IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdProducto = " & dbStr(Me.cboIdProducto.Valor) & " and IdCertificado = " & dbStr(Me.txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(Me.txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Saldo = 0
        End Try
        If Val(Me.txtValorPago.Valor) > Val(Saldo) Then
            MsgBox("El valor de pago no puede ser aplicado, el saldo actual del deudor es por la cantidad de: " & Format(Saldo, "#,###0.00"))
            Exit Sub
        End If

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Dim IdPago As Integer = Val(StiGlobalConn.ObtenerDataset("select isnull(max(IdDeudor),0) + 1 from SiniestrosDeudores where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0))
            Dim sql As String = ""

            sql = "  insert into SiniestrosDeudores "
            sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDeudor, FechaDeudor, Descripcion, ValorDeudor) values("
            sql &= dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & C & dbStr(txtIdCertificado.Valor) & C & dbStr(txtIdSiniestro.Valor) & C & dbInt(IdPago) & C & dbFec(txtFechaPago.Valor) & C & dbStr(Me.txtDescripcionPago.Valor, 150) & C & dbNum(txtValorPago.Valor * -1) & ")"
            StiGlobalConn.SQLExecute(sql)

            'actualizamos los totales del siniestro

            sql = "  update siniestros set "
            sql &= " TotalDeudores = isnull((select sum(ValorDeudor) from SiniestrosDeudores where SiniestrosDeudores.IdPoliza = siniestros.IdPoliza and SiniestrosDeudores.IdProducto = siniestros.IdProducto and SiniestrosDeudores.IdCertificado = siniestros.IdCertificado and SiniestrosDeudores.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " where IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdCertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)
            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("El pago deudor vario ha sido aplicado con éxito.", MsgBoxStyle.Information, "AVISO...")

            Me.LimpiarCampos(Me)

            Me.txtFechaPago.Valor = Date.Today
            Me.btnBuscaSiniestro.Focus()

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            MsgBox("Error al aplicar el pago del deudor vario." & vbCrLf & ex.Message)
        End Try

    End Sub

End Class
