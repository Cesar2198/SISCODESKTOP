
Imports Utilerias.Genericas

Public Class PolizasEliminar

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select MotivoCancelacion,FechaCancelacion, NombreCliente from Polizas where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0)
                Me.txtCliente.Valor = dbData(FilPol, "NombreCliente")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If Me.txtPoliza.Text = "" Then
            MsgBox("Debe especificar la póliza que desea eliminar", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Realmente desea borrar la póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.Yes Then
            Dim res As String = ""
            res = clSeguros.EliminarPoliza(Me.cboProducto.Valor, Me.txtPoliza.Valor)
            If res <> "" Then
                MsgBox("Error al eliminar la póliza, la operación ha sido cancelada: " & res, MsgBoxStyle.Information, "AVISO...")
            Else
                Me.txtPoliza.Valor = ""
                Me.cboProducto.Valor = ""
                Me.txtCliente.Valor = ""
                MsgBox("La póliza ha sido eliminada con éxito", MsgBoxStyle.Information, "AVISO...")
            End If
        End If
    End Sub

    Private Sub PolizasEliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
    End Sub
End Class
