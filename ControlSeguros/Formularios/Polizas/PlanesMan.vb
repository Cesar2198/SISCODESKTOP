Imports Utilerias.Genericas

Public Class PlanesMan

    Private Sub cboIdRamo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdRamo.ValueChangeOnExit
        'cargaremos las coberturas del primer producto del ramo.-
        If cboIdRamo.Text <> "" Then
            Me.cboIdProducto.Query = "select idproducto as Id, Descripcion as Producto from Productos where idramo = " & dbStr(cboIdRamo.Valor) & " order by Descripcion"
            Me.cboIdProducto.Llenar_Combo()
            Me.cboIdProducto.Valor = ""
            Call CargarCoberturas()
        End If
        
    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String) Handles cboIdProducto.ValueChangeOnExit
        Call CargarCoberturas()
    End Sub

    Private Sub CargarCoberturas()
        Try
            If cboIdRamo.Text <> "" Then
                Dim IdProducto As String = ""
                If Me.cboIdProducto.Text = "" Then
                    Try
                        IdProducto = StiGlobalConn.ObtenerDataset("select idproducto from productos where idramo = " & dbStr(cboIdRamo.Valor) & " order by IdAseguradora").Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        IdProducto = ""
                    End Try
                Else
                    IdProducto = Me.cboIdProducto.Valor
                End If
                
                If IdProducto <> "" Then
                    Dim TC As Integer = Me.VistaCoberturas.DataRowCount - 1
                    For BC As Integer = TC To 0 Step -1
                        VistaCoberturas.DeleteRow(BC)
                    Next

                    Dim dtCob As DataTable, FilCob As DataRow
                    dtCob = StiGlobalConn.ObtenerDataset("select IdCobertura,Descripcion  from ProductosCoberturas where idproducto = " & dbStr(IdProducto) & " order by idcobertura").Tables(0)
                    For Each FilCob In dtCob.Rows
                        Try
                            Me.AgregarFilaGrid(VistaCoberturas)
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdPlan", txtIdPlan.Valor)
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdCobertura", dbData(FilCob, "IdCobertura"))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Descripcion", dbData(FilCob, "Descripcion"))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Suma", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Tasa", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PorceSuma", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Prima", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Deducible", "")
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PorceSumaR1", CDbl(0))

                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PrimaMinima", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PrimaMaxima", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "DeducibleMinimo", CDbl(0))
                            Me.VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "DeducibleMaximo", CDbl(0))

                            Me.VistaCoberturas.UpdateCurrentRow()
                        Catch ex As Exception

                        End Try
                    Next
                    Me.VistaCoberturas.FocusedRowHandle = 0
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtIdPlan_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdPlan.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdPlan.NombreCampo, txtIdPlan.Valor)
    End Sub

End Class
