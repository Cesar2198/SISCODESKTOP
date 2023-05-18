Imports Utilerias.Genericas

Public Class RepEstadoCuentaPol

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
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Try

            'Generaremos la impresion del estado de cuenta
            Dim FiltroClientes As String = " and c.idcliente in (select p1.idcliente from polizas as p1 where p1.idpoliza = " & dbStr(txtPoliza.Valor) & " and p1.idproducto = " & dbStr(cboProducto.Valor) & " )"
            Dim FiltroFacturas As String = " and f.idpoliza = " & dbStr(txtPoliza.Valor) & " and f.idproducto = " & dbStr(cboProducto.Valor)

            Dim strError As String = ""
            Call ImprimirEstadoCuenta("", FiltroClientes, "", FiltroFacturas, "", Nothing, "", "", "", "", strError)
            If strError <> "" Then
                MsgBox("Error al generar el estado de cuenta: " & strError, MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub RepEstadoCuentaPol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
    End Sub

End Class
