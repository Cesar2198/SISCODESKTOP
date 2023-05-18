Imports Utilerias.Genericas

Public Class CancelaPoliza

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = " and p.MotivoCancelacion is null"
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
            Me.txtRazonCancela.Focus()
        End If
    End Sub

    Private Sub CancelaPoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()

        Me.cboIdCancelacion.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdCancelacion.Llenar_Combo()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtRazonCancela.Text.Trim = "" Then
            MsgBox("Debe especificar el motivo de la cancelación.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtFechaCancelacion.Text = "" Then
            MsgBox("Debe especificar la fecha de cancelación.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Realmente desea Cancelar la Póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim ElementosCancelados As String = ""
        Try
            Me.Cursor = Cursors.WaitCursor
            btnGuardar.Enabled = False

            ElementosCancelados = CancelarPoliza(Me.txtPoliza.Valor, Me.cboProducto.Valor, Me.txtFechaCancelacion.Valor, Me.cboIdCancelacion.Valor, Me.txtRazonCancela.Valor, Me.txtIdPolizaSustituida.Valor)
            MsgBox(ElementosCancelados, MsgBoxStyle.Information, "AVISO...")
            Me.LimpiarCampos(Me)

        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
            btnGuardar.Enabled = True
        End Try

    End Sub

    Private Sub btnBuscaPolizaSustituye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPolizaSustituye.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtIdPolizaSustituida.Valor = stiSplit(busCodigo, "G0|1")
        End If
    End Sub

End Class
