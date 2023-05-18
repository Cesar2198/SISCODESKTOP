Imports Utilerias.Genericas

Public Class RepPolizasArchivosDigitales

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza")
            Dim RutaPol As String = ""
            If RutaBase <> "" Then
                If System.IO.Directory.Exists(RutaBase) = True Then

                    Dim sql As String = ""

                    sql = " select p.IdPoliza"
                    sql &= ", a.Nombre as Aseguradora "
                    sql &= ", b.Descripcion as Producto"
                    sql &= ", p.NombreCliente as Cliente"
                    sql &= ", p.EstadoPoliza as Estado"
                    sql &= ", '' as Ruta "
                    sql &= " from Polizas as p"
                    sql &= " inner join Productos as b on p.idproducto = b.idproducto"
                    sql &= " inner join Aseguradoras as a on a.idaseguradora = b.idaseguradora"
                    If VisibilidadUsuario() = "D" Then
                        sql &= " where p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If

                    Dim Polizas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    Dim FilPol As DataRow
                    For Each FilPol In Polizas.Rows
                        RutaPol = RutaBase & "\" & dbData(FilPol, "IdPoliza")
                        If System.IO.Directory.Exists(RutaPol) = False Then
                            RutaPol = ""
                        End If
                        FilPol("Ruta") = RutaPol
                        FilPol.AcceptChanges()
                    Next
                    Polizas.AcceptChanges()

                    Me.GridPolizas.DataSource = Polizas
                    Me.GridPolizas.Refresh()

                    If Polizas.Rows.Count = 0 Then
                        MsgBox("No se encontraron pólizas.", MsgBoxStyle.Information, "AVISO..")
                    End If
                Else
                    MsgBox("La ruta base de docuementos no existe o no se tiene acceso: " & RutaBase, MsgBoxStyle.Information, "AVISO...")
                End If
            Else
                MsgBox("No se ha especificado la ruta base de los documentos digitales.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception
            MsgBox("Error al buscar archivos digitales." & ex.ToString, MsgBoxStyle.Exclamation, "ERROR...")
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Archivos Digitales " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)

            Me.VistaPoliza.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Pólizas con rutas digitales", "", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub VistaPoliza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPoliza.DoubleClick
        Try
            Dim fila As Integer = VistaPoliza.FocusedRowHandle
            If fila >= 0 Then
                Dim Doc As String = Me.VistaPoliza.GetRowCellValue(fila, "Ruta")
                If Doc <> "" Then
                    Dim esCarpeta As String = ""
                    Try
                        esCarpeta = System.IO.Path.GetExtension(Doc)
                    Catch ex As Exception
                        esCarpeta = ""
                    End Try
                    If esCarpeta = "" Then
                        System.Diagnostics.Process.Start(Doc)
                    Else
                        If System.IO.File.Exists(Doc) = True Then
                            System.Diagnostics.Process.Start(Doc)
                        Else
                            MsgBox("El documentos no se encuentra en la ruta especificada.", MsgBoxStyle.Information, "AVISO...")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
