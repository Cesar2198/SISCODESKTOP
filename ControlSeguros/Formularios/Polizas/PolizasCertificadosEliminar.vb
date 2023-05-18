
Imports Utilerias.Genericas

Public Class PolizasCertificadosEliminar

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub PolizasCertificadosEliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()
    End Sub

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaCertificados
        Fbus.Text = "Búsqueda de Certificado"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            Me.txtCertificado.Valor = stiSplit(busCodigo, "G2|1")
            Me.txtCliente.Valor = stiSplit(busCodigo, "G3|1")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If txtPoliza.Text = "" Then
            MsgBox("Debe especificar la póliza del certificado que desea eliminar", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If txtCertificado.Text = "" Then
            MsgBox("Debe especificar el certificado que desea eliminar", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Realmente desea borrar el certificado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.Yes Then
            Try
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                Dim filtro As String = " where idpoliza = " & dbStr(txtPoliza.Valor) & " and idproducto = " & dbStr(cboProducto.Valor)
                If Me.txtLista.Text <> "" Then
                    Dim strLista As String = ObtenerListaStringPatron(txtLista.Text)
                    If strLista <> "" Then
                        filtro &= " and idcertificado in (" & strLista & ")"
                    End If
                Else
                    filtro &= " and idcertificado = " & dbStr(txtCertificado.Valor)
                End If

                StiGlobalConn.SQLExecute("delete from PolizasBeneficiarios " & filtro)
                StiGlobalConn.SQLExecute("delete from PolizasBienes " & filtro)
                StiGlobalConn.SQLExecute("delete from PolizasCesiones" & filtro)
                StiGlobalConn.SQLExecute("delete from PolizasCoberturas " & filtro)
                StiGlobalConn.SQLExecute("delete from PolizasCoberturasAdicional " & filtro)
                StiGlobalConn.SQLExecute("delete from PolizasCertificados " & filtro)
                
                StiGlobalConn.SQLExecute("delete from HPolizasBeneficiarios " & filtro)
                StiGlobalConn.SQLExecute("delete from HPolizasBienes " & filtro)
                StiGlobalConn.SQLExecute("delete from HPolizasCesiones" & filtro)
                StiGlobalConn.SQLExecute("delete from HPolizasCoberturas " & filtro)
                StiGlobalConn.SQLExecute("delete from HPolizasCoberturasAdicional " & filtro)
                StiGlobalConn.SQLExecute("delete from HPolizasCertificados " & filtro)
                
                RegistrarLog("E", "PolizasCertificados", Replace(filtro, " where ", ""))

                StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

                Me.txtCliente.Valor = ""
                Me.txtPoliza.Valor = ""
                Me.txtCertificado.Valor = ""
                Me.cboProducto.Valor = ""
                Me.txtLista.Valor = ""

                MsgBox("El certificado ha sido eliminado con éxito.", MsgBoxStyle.Exclamation, "AVISO..")

            Catch ex As Exception
                StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                MsgBox("No es posible eliminar el certificado ha ocurrido un error y se ha revertido el proceso:" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
End Class
