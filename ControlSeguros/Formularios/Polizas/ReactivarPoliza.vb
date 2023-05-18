
Imports Utilerias.Genericas

Public Class ReactivarPoliza

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Canceladas"
        Fbus.dbFiltro = " and (p.MotivoCancelacion is not null or p.FechaCancelacion is not null or p.EstadoPoliza = 'CANCELADA')"
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select MotivoCancelacion,FechaCancelacion, NombreCliente from Polizas where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0)
                Me.txtCliente.Valor = dbData(FilPol, "NombreCliente")
                Me.txtFechaCancelacion.Valor = dbData(FilPol, "FechaCancelacion")
                Me.txtRazonCancela.Valor = dbData(FilPol, "MotivoCancelacion")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If MsgBox("¿Realmente desea Reactivar la Póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            btnGuardar.Enabled = False
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'primero cancelamos la póliza
            StiGlobalConn.SQLExecute("update polizas set EstadoPoliza = 'VIGENTE', MotivoCancelacion = NULL, FechaCancelacion = NULL where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor))

            'ahora cancelamos los certificados
            StiGlobalConn.SQLExecute("update PolizasCertificados set EstadoCertificado = 'VIGENTE', RazonExclusion = NULL, FechaExclusion = NULL where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor) & " and FechaExclusion = " & dbFec(txtFechaCancelacion.Valor))

            'primero haremos una copia de la poliza actual al historico
            clSeguros.RegistrarHistorioPoliza(txtPoliza.Valor, cboProducto.Valor)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("La póliza, Certificado(s) han sido Reactivados con éxito.", MsgBoxStyle.Information, "AVISO...")
            Me.LimpiarCampos(Me)

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
            btnGuardar.Enabled = True
        End Try
    End Sub

    Private Sub ReactivarPoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
    End Sub
End Class
