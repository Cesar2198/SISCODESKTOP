Imports Utilerias.Genericas

Public Class ActualizarNumFacturas

    Dim dtArchivo As DataTable
    Dim dtAnalisis As DataTable

    'la fila del encabezado.
    Dim FilEncabezado As Integer = 1
    Dim ColMensaje As Integer = -1

    Dim TasaBarra As Double = 0
    Dim ValorBarra As Double = 0
    Dim DeterAnalisis As Boolean = False


    dim ColPoliza as integer = -1 
    dim ColCodigo as integer = -1 
    dim ColPagador as integer = -1 
    dim ColCuota as integer = -1 
    dim ColVencimiento as integer = -1 
    dim ColPrima as integer = -1 
    dim ColRecibo as integer = -1 
    dim ColFec_Cobro as integer = -1 
    dim ColAplicado as integer = -1 

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            'lo que haremos es generar un archivo modelo en blanco para el producto.
            Dim MiExcel As Object
            Dim Hoja As Object

            MiExcel = CreateObject("Excel.Application")
            MiExcel.SheetsInNewWorkbook = 1
            MiExcel.Workbooks.Add()
            Hoja = MiExcel.Worksheets(1)
            Dim Fila As Integer = 1
            Dim Col As Integer = 1

            'Información básica
            Hoja.Cells(Fila, 1).Value = "POLIZA"
            Hoja.Cells(Fila, 2).Value = "CODIGO"
            Hoja.Cells(Fila, 3).Value = "PAGADOR"
            Hoja.Cells(Fila, 4).Value = "CUOTA"
            Hoja.Cells(Fila, 5).Value = "VENCIMIENTO"
            Hoja.Cells(Fila, 6).Value = "PRIMA"
            Hoja.Cells(Fila, 7).Value = "RECIBO"
            Hoja.Cells(Fila, 8).Value = "FEC.COBRO"
            Hoja.Cells(Fila, 9).Value = "APLICADO"
            

            'FORMATEAMOS
            Try
                Hoja.Rows("1:1").Font.Bold = True
                Hoja.Columns("A:" & ObtenerLiteralAlfabetico(9)).EntireColumn.AutoFit()
            Catch ex As Exception

            End Try

            'mostramos el archivo.
            MiExcel.Visible = True
            Hoja = Nothing
            MiExcel = Nothing

        Catch ex As Exception
            msgError(ex)
            'MsgBox("Error al generar el archivo modelo." & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        me.Close()
    End Sub

    Private Sub btnBuscarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarArchivo.Click
        Try
            OpenFileDialog1.Filter = "Archivos de Excel|*.xls;*.xlsx"
            OpenFileDialog1.ShowDialog()
            txtArchivo.Valor = OpenFileDialog1.FileName

            If txtArchivo.Text <> "" Then
                Call AnalizarArchivo(txtArchivo.Text)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function AnalizarArchivo(ByVal Archivo As String) As String
        Dim res As String = ""
        Dim MiExcel As Object = nothing
        Dim Hoja As Object = nothing

        Try
        
            MiExcel = CreateObject("Excel.Application")
            MiExcel.Workbooks.Open(Archivo)
            Hoja = MiExcel.Worksheets(1)
            dtArchivo.Rows.Clear()

            Dim ColNombre As String = ""
            Dim ColNumero As Integer = 1
            Dim DetalleCol As String = ""

            Gridfacturas.DataSource = Nothing
            Gridfacturas.Refresh()

            ColPoliza = -1 : ColCodigo = -1 : ColPagador = -1 : ColCuota = -1 : ColVencimiento = -1 : ColPrima = -1 : ColRecibo = -1 : ColFec_Cobro = -1 : ColAplicado = -1 

            ColNombre = Hoja.Cells(FilEncabezado, ColNumero).Value
            While ColNombre <> ""
                DeterminarColumna(ColNombre, ColNumero)
                ColNumero += 1
                ColNombre = Hoja.Cells(FilEncabezado, ColNumero).Value
            End While

            if colpoliza = -1 then  throw new Exception("No se determinó la columna de la poliza")
            if ColCodigo = -1 then  throw new Exception("No se determinó la columna del código")
            if ColCuota = -1 then  throw new Exception("No se determinó la columna de la cuota")
            if colprima = -1 then  throw new Exception("No se determinó la columna de la prima")
            if ColRecibo = -1 then  throw new Exception("No se determinó la columna del recibo")
            if Colaplicado = -1 then  throw new Exception("No se determinó la columna del valor de prima aplicado")

            'estimaremos el número de registros
            Dim NumRegistros As Integer = 0
            ColNombre = Hoja.Cells(FilEncabezado + 1, 1).Value
            While ColNombre <> ""
                NumRegistros += 1
                ColNombre = Hoja.Cells(FilEncabezado + NumRegistros + 1, 1).Value
            End While
            Try
                TasaBarra = 99 / NumRegistros
            Catch ex As Exception
                TasaBarra = 0
            End Try

            barra.visible = true
            valorbarra = 0
            barra.value = valorbarra


            dim FilArchivo as datarow
            dim FilDatos  as integer = 2
            dim mensaje as string = ""
            dim dtFact as datatable
            ColNombre = Hoja.Cells(FilDatos, 1).Value
            While ColNombre <> ""
                FilArchivo = dtarchivo.NewRow()
                If Not Hoja.Cells(FilDatos, ColPoliza).Value Is Nothing Then FilArchivo("Poliza") = CStr(Hoja.Cells(FilDatos, ColPoliza).Value).Trim
                If Not Hoja.Cells(FilDatos, ColCodigo).Value Is Nothing Then FilArchivo("Codigo") = CStr(Hoja.Cells(FilDatos, ColCodigo).Value).Trim
                If Not Hoja.Cells(FilDatos, ColPagador).Value Is Nothing Then FilArchivo("Pagador") = Hoja.Cells(FilDatos, ColPagador).Value
                If Not Hoja.Cells(FilDatos, ColCuota).Value Is Nothing Then FilArchivo("Cuota") = CStr(Hoja.Cells(FilDatos, ColCuota).Value).Trim
                If Not Hoja.Cells(FilDatos, ColVencimiento).Value Is Nothing Then FilArchivo("Vencimiento") = Hoja.Cells(FilDatos, ColVencimiento).Value
                If Not Hoja.Cells(FilDatos, ColPrima).Value Is Nothing Then FilArchivo("Prima") = Val(Hoja.Cells(FilDatos, ColPrima).Value)
                If Not Hoja.Cells(FilDatos, ColRecibo).Value Is Nothing Then FilArchivo("Recibo") = CStr(Hoja.Cells(FilDatos, ColRecibo).Value).Trim
                If Not Hoja.Cells(FilDatos, ColFec_Cobro).Value Is Nothing Then FilArchivo("Fec_Cobro") = Hoja.Cells(FilDatos, ColFec_Cobro).Value
                If Not Hoja.Cells(FilDatos, ColAplicado).Value Is Nothing Then FilArchivo("Aplicado") = Val(Hoja.Cells(FilDatos, ColAplicado).Value)

                mensaje = ""
                If Not Hoja.Cells(FilDatos, ColPrima).Value Is Nothing And Not Hoja.Cells(FilDatos, ColAplicado).Value Is Nothing And Not Hoja.Cells(FilDatos, ColRecibo).Value Is Nothing Then

                    If Val(FilArchivo("Prima")) = Val(FilArchivo("Aplicado")) And CStr(FilArchivo("Recibo")) <> "" Then
                        '1) VERIFICAMOS SI EXISTE LA FACTURA
                        dtFact = StiGlobalConn.ObtenerDataset("select * from Facturas where NumeroFactura = " & dbStr(FilArchivo("Recibo")) & " and IdPoliza = " & dbStr(FilArchivo("Poliza"))).Tables(0)
                        If dtFact.Rows.Count > 0 Then
                            mensaje = "FACTURA YA EXISTE"
                        Else
                            dtFact = StiGlobalConn.ObtenerDataset("select * from Facturas where NumeroFactura = " & dbStr(FilArchivo("Codigo") & FilArchivo("Cuota")) & " and IdPoliza = " & dbStr(FilArchivo("Poliza"))).Tables(0)
                            If dtFact.Rows.Count = 0 Then
                                If CStr(FilArchivo("Cuota")).Length = 1 Then
                                    FilArchivo("Cuota") = "0" & CStr(FilArchivo("Cuota"))
                                End If
                                dtFact = StiGlobalConn.ObtenerDataset("select * from Facturas where NumeroFactura = " & dbStr(FilArchivo("Codigo") & FilArchivo("Cuota")) & " and IdPoliza = " & dbStr(FilArchivo("Poliza"))).Tables(0)
                            End If
                            If dtFact.Rows.Count = 0 Then
                                mensaje = "NO SE PUEDE DETERMINAR LA FACTURA"
                            Else
                                If dtFact.Rows.Count > 1 Then
                                    mensaje = "SE HA ENCONTRADO MAS DE UNA FACTURA"
                                Else
                                    mensaje = "SE ACTUALIZARA LA FACTURA"
                                End If
                            End If
                        End If
                    End If
                End If
                If Not Hoja.Cells(FilDatos, ColRecibo).Value Is Nothing Then
                    If IsNumeric(FilArchivo("Recibo")) = False Then mensaje = "EL RECIBO NO ES UN NUMERO"
                End If


                FilArchivo("Mensaje") = mensaje
                dtArchivo.Rows.Add(FilArchivo)

                FilDatos += 1
                ColNombre = Hoja.Cells(FilDatos, 1).Value
            End While
            
            Gridfacturas.DataSource = dtArchivo
            Gridfacturas.Refresh()

        Catch ex As Exception
            msgError(ex)
            res = "Error al analizar el archivos:" & vbCrLf & ex.Message
        finally
            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing
            barra.visible = false
        End Try

        Return res
    End Function

    Private Sub ActualizarNumFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IniciarTabla()

        
        btnGuardar.Enabled = True
        btnNuevo.Enabled = True

        'verificación si tiene excel
        Dim TestExcel As Object
        Try
            TestExcel = CreateObject("Excel.Application")
        Catch ex As Exception
            TestExcel = Nothing
        End Try
        If TestExcel Is Nothing Then
            MsgBox("Las aplicaciones de importación requieren que esté instalado Microsoft Excel, no se ha encontrado en su computadora.", MsgBoxStyle.Exclamation, "AVISO...")
        Else
            TestExcel.Quit()
            TestExcel = Nothing
        End If
    End Sub

    Private Sub IniciarTabla()
        dtArchivo = New DataTable
        dtArchivo.Columns.Add("Poliza", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Codigo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Pagador", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Cuota", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Vencimiento", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Prima", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Recibo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Fec_Cobro", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Aplicado", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Mensaje", System.Type.GetType("System.String"))
        dtArchivo.TableName = "Archivo"

    End Sub

    Public sub DeterminarColumna(ByVal NombreColumna As String, byval ColNumero as integer) 
        Try
            NombreColumna = Replace(NombreColumna.Trim.ToUpper, " ", "")    

            Select Case NombreColumna
                
                Case "POLIZA", "NUMPOLIZA"
                    colpoliza = colnumero
                Case "CODIGO"
                    colcodigo = colnumero
                Case "PAGADOR", "CLIENTE", "ASEGURADO"
                    colpagador = colnumero
                Case "CUOTA"
                    colcuota = colnumero
                Case "VENCIMIENTO"
                    colvencimiento = colnumero
                Case "PRIMA"
                    colprima = colnumero
                Case "RECIBO"
                    colrecibo = colnumero
                Case "FEC.COBRO", "FECCOBRO", "FEC_COBRO"
                    colfec_cobro = colnumero
                Case "APLICADO"
                    colaplicado = colnumero

            End Select

        Catch ex As Exception
            
        End Try
        
    End sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        
        If vistaFacturas.RowCount = 0 Then
            MsgBox("No hay información para procesar", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim dtFact As DataTable
        Dim numFacAct As Integer = 0
        Try

            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobroFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobro NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FacturasMovimientos NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Facturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasAbono NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasCredito NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE RecibosFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaComisionesFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaVendedoresFacturas NOCHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Gestiones NOCHECK CONSTRAINT ALL")

            For I As Integer = 0 To vistaFacturas.RowCount - 1
                If vistaFacturas.GetRowCellValue(I, "Mensaje") = "SE ACTUALIZARA LA FACTURA" Then
                    dtFact = StiGlobalConn.ObtenerDataset("select * from Facturas where NumeroFactura = " & dbStr(vistaFacturas.GetRowCellValue(I, "Codigo") & vistaFacturas.GetRowCellValue(I, "Cuota")) & " and IdPoliza = " & dbStr(vistaFacturas.GetRowCellValue(I, "Poliza"))).Tables(0)
                    If dtFact.Rows.Count > 0 Then
                        
                        StiGlobalConn.SQLExecute("update Facturas set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update FacturasMovimientos set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update AvisosCobroFacturas set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update NotasAbono set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update NotasCredito set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update RecibosFacturas set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update EstadosCuentaComisionesFacturas set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update EstadosCuentaVendedoresFacturas set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")) & " and IdRamo = " & dbStr(dbData(dtFact.Rows(0), "IdRamo")))
                        StiGlobalConn.SQLExecute("update Gestiones set NumeroFactura = " & dbInt(vistaFacturas.GetRowCellValue(I, "Recibo")) & " where NumeroFactura = " & dbInt(dbData(dtFact.Rows(0), "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(dtFact.Rows(0), "IdProducto")) & " and IdPoliza = " & dbStr(dbData(dtFact.Rows(0), "IdPoliza")))
                        numFacAct += 1
                    End If
                End If
            Next
        Catch ex As Exception

        Finally
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobroFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE AvisosCobro CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE FacturasMovimientos CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Facturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasAbono CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE NotasCredito CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE RecibosFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaComisionesFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE EstadosCuentaVendedoresFacturas CHECK CONSTRAINT ALL")
            StiGlobalConn.SQLExecute("ALTER TABLE Gestiones CHECK CONSTRAINT ALL")
            txtArchivo.Text = ""
            gridFacturas.DataSource = Nothing
            gridFacturas.Refresh()
        End Try

        MsgBox("Se actualizaron " & numFacAct & " Facturas", MsgBoxStyle.Information, "AVISO...")

    End Sub

End Class
