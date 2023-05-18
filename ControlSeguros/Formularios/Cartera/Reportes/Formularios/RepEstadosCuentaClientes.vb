Imports Utilerias.Genericas

Public Class RepEstadosCuentaClientes

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepEstadosCuentaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaCorte.Valor = Date.Today
        Me.cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivoCta.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If txtFechaCorte.Text = "" Then
            MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'generamos los datos para el estado de cuenta.
        Try
            Dim FiltroCliente As String = ""
            If cboEjecutivoCta.Valor <> "" Then
                FiltroCliente = " and c.EjecutivoCta = " & dbStr(cboEjecutivoCta.Valor)
            End If
            If VisibilidadUsuario() = "D" Then
                FiltroCliente &= " and (select count(*) from polizas as p where p.idcliente = c.idcliente and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Call ImprimirEstadoCuenta("", FiltroCliente, "", "", "", Nothing, "", "", "", "", "")

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub
End Class
