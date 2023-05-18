Imports Utilerias.Genericas

Public Class ImportarFacturas

    Dim dtArchivo As DataTable
    Dim dtAnalisis As DataTable

    'la fila del encabezado.
    Dim FilEncabezado As Integer = 1
    Dim ColMensaje As Integer = -1

    Dim TasaBarra As Double = 0
    Dim ValorBarra As Double = 0
    Dim DeterAnalisis As Boolean = False

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
        Try
            Dim MiExcel As Object
            Dim Hoja As Object

            MiExcel = CreateObject("Excel.Application")
            MiExcel.Workbooks.Open(Archivo)
            Hoja = MiExcel.Worksheets(1)
            dtArchivo.Rows.Clear()

            Dim ColNombre As String = ""
            Dim ColNumero As Integer = 1
            Dim FilArchivo As DataRow
            Dim DetalleCol As String = ""

            ColNombre = Hoja.Cells(FilEncabezado, ColNumero).Value
            While ColNombre <> ""
                FilArchivo = dtArchivo.NewRow
                FilArchivo("Columna") = ColNumero
                FilArchivo("Colarchivo") = ColNombre

                DetalleCol = DeterminarColumna(ColNombre)

                FilArchivo("Tipo") = stiSplit(DetalleCol, "G0|1")
                FilArchivo("Campo") = stiSplit(DetalleCol, "G1|1")
                FilArchivo("Observacion") = stiSplit(DetalleCol, "G2|1")
                dtArchivo.Rows.Add(FilArchivo)

                ColNumero += 1
                ColNombre = Hoja.Cells(FilEncabezado, ColNumero).Value
            End While

            ColMensaje = ColNumero + 1

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
            lblMensaje.Text = "Número de Facturas Encontradas: " & Format(NumRegistros, "#,###0")

            GridImportar.DataSource = dtArchivo
            GridImportar.Refresh()

            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing

        Catch ex As Exception
            res = "Error al analizar el archivos:" & vbCrLf & ex.Message
        End Try
        Return res
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ImportarFacturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call IniciarTabla()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "F" : FilaTD("Tipo") = "Factura" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "E" : FilaTD("Tipo") = "Emisión" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "P" : FilaTD("Tipo") = "Pago" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "A" : FilaTD("Tipo") = "Anulación" : TD.Rows.Add(FilaTD)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Tipo"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TD
        RepositoryItemLookUpEdit1.PopulateColumns()
        RepositoryItemLookUpEdit1.Columns("Id").Visible = False

        btnGuardar.Enabled = True
        btnNuevo.Enabled = True
        btnEliminar.Enabled = True

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
        dtArchivo.Columns.Add("Columna", System.Type.GetType("System.Int32"))
        dtArchivo.Columns.Add("Colarchivo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Tipo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Observacion", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Campo", System.Type.GetType("System.String"))
        dtArchivo.TableName = "Archivo"

        dtAnalisis = New DataTable
        dtAnalisis.Columns.Add("Fila", System.Type.GetType("System.Int32"))
        dtAnalisis.Columns.Add("Mensaje", System.Type.GetType("System.String"))
        dtAnalisis.Columns.Add("Fallo", System.Type.GetType("System.Int32"))
        dtArchivo.TableName = "Analisis"

    End Sub

    Public Function DeterminarColumna(ByVal NombreColumna As String) As String
        ''retornamos Tipo|ColBaseDatos|Comentario
        Dim Res As String = ""
        Try
            NombreColumna = Replace(NombreColumna.Trim.ToUpper, " ", "")
            'basados en el nombre de la columna determinaremos el tipo
            Select Case NombreColumna
                '********SECCION GENERALES

                Case "ASEGURADORA"
                    Res = "F|IdAseguradora|"
                Case "PRODUCTO"
                    Res = "F|IdProducto|"
                Case "RAMO"
                    Res = "F|IdRamo|"
                Case "POLIZA"
                    Res = "F|IdPoliza|"
                Case "NUMERO_FACTURA", "FACTURA"
                    Res = "F|NumeroFactura|"
                Case "TIPO_FACTURA", "TIPO"
                    Res = "F|TipoFactura|"
                Case "ANEXO", "TIPO_ANEXO", "TIPOANEXO"
                    Res = "F|IdAnexo|"
                Case "CODIGO_CLIENTE", "NIT"
                    Res = "F|IdCliente|"
                Case "NOMBRE_CLIENTE", "NOMBRE", "ASEGURADO"
                    Res = "F|NombreCliente|"
                Case "FECHA_EMISION", "FECHA_FACTURACION"
                    Res = "F|FechaEmision|"
                Case "FECHA_VENCIMIENTO", "VENCIMIENTO"
                    Res = "F|FechaPago|"
                Case "VIGENCIA_DESDE", "FECHA_DESDE", "DESDE", "FECHADESDE"
                    Res = "F|VigenciaDesde|"
                Case "VIGENCIA_HASTA", "FECHA_HASTA", "HASTA", "FECHAHASTA"
                    Res = "F|VigenciaHasta|"
                Case "NUMERO_CUOTA", "NUMEROCUOTA", "CUOTA"
                    Res = "F|NumCuota|"
                Case "TOTAL_CUOTAS", "CUOTAS"
                    Res = "F|TotalCuotas|"
                Case "REFERENCIA", "REF", "REF."
                    Res = "F|Referencia|"
                Case "OBSERVACIONES", "COMENTARIOS"
                    Res = "F|Observaciones|"
                Case "PORCE_COMISION", "PORCE_COMISIÓN", "PORCECOMISION", "PORCECOMISIÓN"
                    Res = "F|PorceComision|"
                Case "COMISION", "COMI.", "COMISIÓN"
                    Res = "E|Comision|"
                Case "DOCUMENTO_FISCAL"
                    Res = "F|DocumentoFiscal|"
                Case "PRIMA_NETA", "PRIMA", "PRIMANETA"
                    Res = "E|PrimaNeta|"
                Case "PRIMA_EXENTA"
                    Res = "E|PrimaExenta|"
                Case "GASTOS_EMISION", "GASTOSEMISION", "GASTOS_EMISIÓN", "GASTOSEMISIÓN"
                    Res = "E|GastosEmision|"
                Case "GASTOS_FRACCIONAMIENTO", "GASTOSFRACCIONAMIENTO"
                    Res = "E|GastosFracciona|"
                Case "GASTOS_BOMBEROS", "GASTOSBOMBEROS"
                    Res = "E|GastosBomberos|"
                Case "OTROS_GASTOS", "GASTOS"
                    Res = "E|Gastos|"
                Case "IMPUESTOS", "IVA"
                    Res = "E|Impuestos|"
                Case "RETENCIONIVA", "RETIVA", "RETENCION_IVA"
                    Res = "E|RetencionImpuestos|"
                Case "TOTAL_FACTURA", "TOTAL"
                    Res = "E|Total|"
                Case "FECHA_PAGADO", "FECHA_PAGO", "FECHAPAGADO", "FECHAPAGO"
                    Res = "P|FechaPagado|"
                Case "FECHA_ANULADO", "FECHAANULADO", "FECHA_ANULA", "FECHAANULA"
                    Res = "A|FechaAnulado|"
            End Select

            If Res = "" Then
                Res = "||Columna se Omitirá"
            End If

        Catch ex As Exception
            Res = "||Columna se Omitirá"
        End Try
        Return Res

    End Function

    Private Function ExisteCampo(ByVal Campo As String) As Boolean
        Dim res As Boolean = False
        Try
            For NF As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If CStr(VistaImportar.GetRowCellValue(NF, "Campo")).Trim.ToUpper = Campo.Trim.ToUpper Then
                    res = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function

    Private Function ExisteColumna(ByVal Campo As String) As Integer
        Dim res As Integer = -1
        Try
            For NF As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If Replace(CStr(VistaImportar.GetRowCellValue(NF, "Colarchivo")).Trim.ToUpper, " ", "") = Replace(Campo.Trim.ToUpper, " ", "") Then
                    res = VistaImportar.GetRowCellValue(NF, "Columna")
                    Exit For
                End If
            Next
        Catch ex As Exception
            res = -1
        End Try
        Return res
    End Function

    Private Function ObtenerColCampo(ByVal Campo As String) As Integer
        Dim res As Integer = -1
        Try
            For NF As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If CStr(VistaImportar.GetRowCellValue(NF, "Campo")).Trim.ToUpper = Campo.Trim.ToUpper Then
                    res = CInt(VistaImportar.GetRowCellValue(NF, "Columna"))
                    Exit For
                End If
            Next
        Catch ex As Exception
            res = -1
        End Try
        Return res
    End Function

    Private Function ObtenerDatoArchivo(ByRef Hoja As Object, ByVal Fila As Integer, ByVal Campo As String) As String
        Dim res As String = ""
        Try
            Dim Columna As Integer = ObtenerColCampo(Campo)
            If Columna > 0 Then
                res = CStr(Hoja.Cells(Fila, Columna).Value)
            End If
        Catch ex As Exception
            res = ""
        End Try
        If res Is Nothing Then res = ""
        Return res
    End Function

    Private Function ObtenerDatoArchivo(ByRef Hoja As Object, ByVal Fila As Integer, ByVal Columna As Integer) As String
        Dim res As String = ""
        Try
            If Columna > 0 And Fila > 0 Then
                res = CStr(Hoja.Cells(Fila, Columna).Value)
            End If
        Catch ex As Exception
            res = ""
        End Try
        If res Is Nothing Then res = ""
        Return res
    End Function

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
            Hoja.Cells(Fila, 1).Value = "ASEGURADORA"
            Hoja.Cells(Fila, 2).Value = "PRODUCTO"
            Hoja.Cells(Fila, 3).Value = "RAMO"
            Hoja.Cells(Fila, 4).Value = "POLIZA"
            Hoja.Cells(Fila, 5).Value = "NUMERO_FACTURA"
            Hoja.Cells(Fila, 6).Value = "TIPO_FACTURA"
            Hoja.Cells(Fila, 7).Value = "ANEXO"
            Hoja.Cells(Fila, 8).Value = "CODIGO_CLIENTE"
            Hoja.Cells(Fila, 9).Value = "NOMBRE_CLIENTE"
            Hoja.Cells(Fila, 10).Value = "FECHA_EMISION"
            Hoja.Cells(Fila, 11).Value = "FECHA_VENCIMIENTO"
            Hoja.Cells(Fila, 12).Value = "VIGENCIA_DESDE"
            Hoja.Cells(Fila, 13).Value = "VIGENCIA_HASTA"
            Hoja.Cells(Fila, 14).Value = "NUMERO_CUOTA"
            Hoja.Cells(Fila, 15).Value = "TOTAL_CUOTAS"
            Hoja.Cells(Fila, 16).Value = "REFERENCIA"
            Hoja.Cells(Fila, 17).Value = "OBSERVACIONES"
            Hoja.Cells(Fila, 18).Value = "PORCE_COMISION"
            Hoja.Cells(Fila, 19).Value = "COMISION"
            Hoja.Cells(Fila, 20).Value = "DOCUMENTO_FISCAL"

            'Información de valores
            Hoja.Cells(Fila, 21).Value = "PRIMA_NETA"
            Hoja.Cells(Fila, 22).Value = "GASTOS_EMISION"
            Hoja.Cells(Fila, 23).Value = "GASTOS_FRACCIONAMIENTO"
            Hoja.Cells(Fila, 24).Value = "GASTOS_BOMBEROS"
            Hoja.Cells(Fila, 25).Value = "OTROS_GASTOS"
            Hoja.Cells(Fila, 26).Value = "IMPUESTOS"
            Hoja.Cells(Fila, 27).Value = "RETENCION_IVA"
            Hoja.Cells(Fila, 28).Value = "TOTAL_FACTURA"
            Hoja.Cells(Fila, 29).Value = "FECHA_PAGADO"
            Hoja.Cells(Fila, 30).Value = "FECHA_ANULADO"
            Hoja.Cells(Fila, 30).Value = "PRIMA_EXENTA"

            Col = 31

            'FORMATEAMOS
            Try
                Hoja.Rows("1:1").Font.Bold = True
                Hoja.Columns("A:" & ObtenerLiteralAlfabetico(Col)).EntireColumn.AutoFit()
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'campos obligatorios
        If Me.txtArchivo.Text = "" Then
            MsgBox("Debe especificar el Archivo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        btnGuardar.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Dim Existe As Integer = 0
        Dim FilNombre As String = ""
        Dim Fila As Integer = FilEncabezado + 1
        'recorremos el archivo.
        Dim MiExcel As Object = Nothing
        Dim Hoja As Object

        Dim ResultadoFactura As String = "", HayErrores As Boolean = False
        Try
            Try
                ValorBarra = 0
                Barra.Value = ValorBarra
                Barra.Visible = True
            Catch ex As Exception

            End Try

            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            MiExcel = CreateObject("Excel.Application")
            MiExcel.Workbooks.Open(txtArchivo.Valor)
            Hoja = MiExcel.Worksheets(1)

            FilNombre = Hoja.Cells(Fila, 1).Value
            While FilNombre <> ""

                ResultadoFactura = ProcesarFactura(Hoja, Fila, False)
                If ResultadoFactura <> "" Then
                    'marcamos el archivo
                    Hoja.Cells(Fila, ColMensaje).Value = ResultadoFactura
                    HayErrores = True
                End If

                Fila += 1
                FilNombre = Hoja.Cells(Fila, 1).Value
                Try
                    ValorBarra += TasaBarra
                    Barra.Value = ValorBarra
                    Application.DoEvents()
                Catch ex As Exception

                End Try
            End While

            MiExcel.ActiveWorkbook.Save()
            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            Try
                ValorBarra = 0
                Barra.Value = ValorBarra
                Barra.Visible = False
            Catch ex As Exception

            End Try
            Me.LimpiarCampos(Me)
            Me.lblMensaje.Text = ""

            btnGuardar.Enabled = True
            Me.Cursor = Cursors.Default

            If HayErrores = False Then
                MsgBox("La operación ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")
            Else
                MsgBox("No Todas las facturas se procesaron, los errores los encontrará en el archivo que especificó.", MsgBoxStyle.Exclamation, "ERROR...")
            End If

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            ValorBarra = 0
            Barra.Value = ValorBarra
            Barra.Visible = False
            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing
            btnGuardar.Enabled = True
            Me.Cursor = Cursors.Default
            MsgBox("Error al realizar la operación, el proceso se ha cancelado. Error en la fila: " & Fila & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Function ProcesarFactura(ByRef Hoja As Object, ByVal Fila As Integer, ByVal Analizar As Boolean) As String
        Dim res As String = ""

        'DECLARAMOS LOS CAMPO
        Dim NumeroFactura As Integer = 0, IdProducto As String = "", Poliza As String = "", TipoFactura As String = "", Anexo As String = "", IdCliente As String = ""
        Dim NombreCliente As String = "", FechaEmision As DateTime = Nothing, FechaPago As DateTime = Nothing, VigenciaDesde As DateTime = Nothing, VigenciaHasta As DateTime = Nothing
        Dim NumCuota As Integer = 0, TotalCuotas As Integer = 0, Prima As Double = 0, PrimaExenta As Double = 0, GastosEmi As Double = 0, GastosFin As Double = 0, GastosBomb As Double = 0
        Dim GastosOtros As Double = 0, Iva As Double = 0, Total As Double = 0, Comision As Double = 0, Referencia As String = "", Observaciones As String = ""
        Dim PorceComision As Double = 0, IdRamo As String = "", RetIva As Double = 0, AplicarRetencion As String = ""
        Dim IdAseguradora As String = ""
        Dim FechaPagado As DateTime = Nothing
        Dim FechaAnulado As DateTime = Nothing

        'COMPLETAREMOS LA INFORMACION
        If ExisteCampo("NumeroFactura") = True Then
            NumeroFactura = ObtenerDatoArchivo(Hoja, Fila, "NumeroFactura")
        Else
            res &= "Falta Número Factura;"
        End If

        If ExisteCampo("IdPoliza") = True Then
            Poliza = ObtenerDatoArchivo(Hoja, Fila, "IdPoliza")
        Else
            res &= "Falta Número de Póliza;"
        End If

        If ExisteCampo("IdAseguradora") = True Then
            IdAseguradora = DeterminarAseguradora(ObtenerDatoArchivo(Hoja, Fila, "IdAseguradora"))
            If IdAseguradora = "" Then
                res &= "No se encuentra Aseguradora;"
            Else
                If ExisteCampo("IdProducto") = True Or ExisteCampo("IdRamo") = True Then
                    IdProducto = DeterminarProducto(IdAseguradora, ObtenerDatoArchivo(Hoja, Fila, "IdProducto"), ObtenerDatoArchivo(Hoja, Fila, "IdRamo"), Poliza)
                    If IdProducto = "" Then
                        res &= "No se encuentra el Producto;"
                    End If
                End If
            End If
        Else
            res &= "Falta Aseguradora;"
        End If


        If ExisteCampo("TipoFactura") = True Then
            TipoFactura = ObtenerDatoArchivo(Hoja, Fila, "TipoFactura")
            Select Case TipoFactura.Trim.ToUpper
                Case "F", "FACTURA"
                    TipoFactura = "F"
                Case "C", "CREDITO", "CREDITO FISCAL"
                    TipoFactura = "C"
                Case Else
                    TipoFactura = "F"
            End Select
        Else
            TipoFactura = "F"  'Pro defecto Factura
        End If

        If ExisteCampo("IdAnexo") = True Then
            Anexo = ObtenerDatoArchivo(Hoja, Fila, "IdAnexo")
        End If

        If ExisteCampo("IdCliente") = True Then
            IdCliente = ObtenerDatoArchivo(Hoja, Fila, "IdCliente")
        End If

        If ExisteCampo("NombreCliente") = True Then
            NombreCliente = ObtenerDatoArchivo(Hoja, Fila, "NombreCliente")
            If NombreCliente <> "" And IdCliente = "" Then
                'verificaremos si existe el cliente
                Try
                    IdCliente = StiGlobalConn.ObtenerDataset("select idcliente from clientes where NombreCliente = " & dbStr(NombreCliente)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdCliente = ""
                End Try
            End If
        Else
            res &= "Falta Nombre Cliente;"
        End If

        If ExisteCampo("FechaEmision") = True Then
            Try
                FechaEmision = CDate(ConvertirFecha(ObtenerDatoArchivo(Hoja, Fila, "FechaEmision"), FormatoFecha.FechaCorta))
            Catch ex As Exception
                FechaEmision = Date.Today
            End Try
        Else
            FechaEmision = Date.Today
        End If

        If ExisteCampo("FechaPago") = True Then
            Try
                FechaPago = CDate(ConvertirFecha(ObtenerDatoArchivo(Hoja, Fila, "FechaPago"), FormatoFecha.FechaCorta))
            Catch ex As Exception
                res &= "Falta Fecha Vencimiento;"
            End Try
        Else
            res &= "Falta Fecha Vencimiento;"
        End If

        If ExisteCampo("VigenciaDesde") = True Then
            Try
                VigenciaDesde = CDate(ConvertirFecha(ObtenerDatoArchivo(Hoja, Fila, "VigenciaDesde"), FormatoFecha.FechaCorta))
            Catch ex As Exception
                VigenciaDesde = Nothing
            End Try
        End If

        If ExisteCampo("VigenciaHasta") = True Then
            Try
                VigenciaHasta = CDate(ConvertirFecha(ObtenerDatoArchivo(Hoja, Fila, "VigenciaHasta"), FormatoFecha.FechaCorta))
            Catch ex As Exception
                VigenciaHasta = Nothing
            End Try

        End If

        If ExisteCampo("NumCuota") = True Then
            Try
                NumCuota = ObtenerDatoArchivo(Hoja, Fila, "NumCuota")
            Catch ex As Exception
                NumCuota = 1
            End Try
        Else
            NumCuota = 1
        End If

        If ExisteCampo("TotalCuotas") = True Then
            Try
                TotalCuotas = ObtenerDatoArchivo(Hoja, Fila, "TotalCuotas")
            Catch ex As Exception
                TotalCuotas = 1
            End Try
        Else
            TotalCuotas = 1
        End If

        If ExisteCampo("PrimaNeta") = True Then
            Try
                Prima = Val(ObtenerDatoArchivo(Hoja, Fila, "PrimaNeta"))
            Catch ex As Exception
                res &= "Falta la Prima Neta;"
            End Try
        Else
            res &= "Falta la Prima Neta;"
        End If

        If ExisteCampo("PrimaExenta") = True Then
            Try
                PrimaExenta = Val(ObtenerDatoArchivo(Hoja, Fila, "PrimaExenta"))
            Catch ex As Exception
                PrimaExenta = 0
            End Try
        Else
            PrimaExenta = 0
        End If

        If ExisteCampo("GastosEmision") = True Then
            Try
                GastosEmi = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosEmision"))
            Catch ex As Exception
                GastosEmi = 0
            End Try
        Else
            GastosEmi = 0
        End If

        If ExisteCampo("GastosFracciona") = True Then
            Try
                GastosFin = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosFracciona"))
            Catch ex As Exception
                GastosFin = 0
            End Try
        Else
            GastosFin = 0
        End If

        If ExisteCampo("GastosBomberos") = True Then
            Try
                GastosBomb = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosBomberos"))
            Catch ex As Exception
                GastosBomb = 0
            End Try
        Else
            GastosBomb = 0
        End If

        If ExisteCampo("Gastos") = True Then
            Try
                GastosOtros = Val(ObtenerDatoArchivo(Hoja, Fila, "Gastos"))
            Catch ex As Exception
                GastosOtros = 0
            End Try
        Else
            GastosOtros = 0
        End If

        If ExisteCampo("Impuestos") = True Then
            Try
                Iva = Val(ObtenerDatoArchivo(Hoja, Fila, "Impuestos"))
            Catch ex As Exception
                Iva = 0
            End Try
        Else
            Iva = 0
        End If

        If ExisteCampo("RetencionImpuestos") = True Then
            Try
                RetIva = Val(ObtenerDatoArchivo(Hoja, Fila, "RetencionImpuestos"))
            Catch ex As Exception
                RetIva = 0
            End Try
        Else
            RetIva = 0
        End If
        If RetIva <> 0 Then
            AplicarRetencion = "S"
        End If

        If ExisteCampo("Total") = True Then
            Try
                Total = Val(ObtenerDatoArchivo(Hoja, Fila, "Total"))
                If Total = 0 Then
                    res &= "El Total no puede ser cero;"
                End If
            Catch ex As Exception
                res &= "Falta el Total de Factura;"
            End Try
        Else
            res &= "Falta el Total de Factura;"
        End If

        If ExisteCampo("Comision") = True Then
            Try
                Comision = Val(ObtenerDatoArchivo(Hoja, Fila, "Comision"))
            Catch ex As Exception
                Comision = 0
            End Try
        Else
            Comision = 0
        End If

        If ExisteCampo("PorceComision") = True Then
            Try
                PorceComision = Val(ObtenerDatoArchivo(Hoja, Fila, "PorceComision"))
            Catch ex As Exception
                PorceComision = 0
            End Try
            If PorceComision > 0 And Comision = 0 Then
                'calculamos la comisión
                Comision = Math.Round((Prima * PorceComision) / 100, 2)
            End If
        Else
            PorceComision = 0
        End If

        If ExisteCampo("Referencia") = True Then
            Referencia = ObtenerDatoArchivo(Hoja, Fila, "Referencia")
        Else
            Referencia = ""
        End If

        If ExisteCampo("Observaciones") = True Then
            Observaciones = ObtenerDatoArchivo(Hoja, Fila, "Observaciones")
        Else
            Observaciones = ""
        End If

        If ExisteCampo("IdRamo") = True Then
            IdRamo = DeterminarRamo(ObtenerDatoArchivo(Hoja, Fila, "IdRamo"), IdProducto)
        Else
            'el ramo principal del producto
            IdRamo = DeterminarRamo("", IdProducto)
        End If
        If IdRamo = "" Then
            res &= "Falta el Ramo del Seguro;"
        End If

        If ExisteCampo("FechaPagado") = True Then
            Try
                If ObtenerDatoArchivo(Hoja, Fila, "FechaPagado") <> "" Then
                    FechaPagado = CDate(ConvertirFecha(ObtenerDatoArchivo(Hoja, Fila, "FechaPagado"), FormatoFecha.FechaCorta))
                Else
                    FechaPagado = Nothing
                End If
            Catch ex As Exception
                FechaPagado = Nothing
            End Try
        Else
            res &= "No hay Columna de fecha de pago;"
        End If

        If ExisteCampo("FechaAnulado") = True Then
            Try
                If ObtenerDatoArchivo(Hoja, Fila, "FechaAnulado") <> "" Then
                    FechaAnulado = CDate(ConvertirFecha(ObtenerDatoArchivo(Hoja, Fila, "FechaAnulado"), FormatoFecha.FechaCorta))
                Else
                    FechaAnulado = Nothing
                End If
            Catch ex As Exception
                FechaAnulado = Nothing
            End Try
        Else
            res &= "No hay Columna de fecha de anulación;"
        End If

        'verificaremos que la factura no exista ya.

        Dim Existe As Integer = 0
        Dim sql As String = ""
        Try
            sql = " select count(*) from Facturas "
            sql &= " where NumeroFactura = " & dbInt(NumeroFactura)
            sql &= " and IdPoliza = " & dbStr(Poliza)
            sql &= " and IdProducto = " & dbStr(IdProducto)
            sql &= " and IdRamo = " & dbStr(IdRamo)
            Existe = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Existe = 0
        End Try

        If Existe > 0 Then
            If res = "" Then
                'actualizamos la facturas
                res &= Cartera_ActualizarFactura(NumeroFactura, IdProducto, Poliza, TipoFactura, Anexo, IdCliente, NombreCliente, FechaEmision, FechaPago, VigenciaDesde, VigenciaHasta, NumCuota, TotalCuotas, Prima, GastosEmi, GastosFin, GastosBomb, GastosOtros, Iva, Total, Comision, Referencia, Observaciones, PorceComision, IdRamo, RetIva, AplicarRetencion, Nothing, PrimaExenta)

                'si existe pago
                Try
                    sql = " select count(*) from FacturasMovimientos "
                    sql &= " where NumeroFactura = " & dbInt(NumeroFactura)
                    sql &= " and IdPoliza = " & dbStr(Poliza)
                    sql &= " and IdProducto = " & dbStr(IdProducto)
                    sql &= " and IdRamo = " & dbStr(IdRamo)
                    sql &= " and TipoMovimiento = 'PAGO'"
                    Existe = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Existe = 0
                End Try
                If Existe = 0 And res = "" Then
                    If Not FechaPagado = Nothing Then
                        res &= Cartera_AgregarPago(NumeroFactura, Poliza, IdProducto, FechaPagado, Prima, GastosEmi, GastosFin, GastosBomb, GastosOtros, Iva, Total, Comision, IdRamo, RetIva, "")
                    End If
                End If
                'si existe anulacion
                Try
                    sql = " select count(*) from FacturasMovimientos "
                    sql &= " where NumeroFactura = " & dbInt(NumeroFactura)
                    sql &= " and IdPoliza = " & dbStr(Poliza)
                    sql &= " and IdProducto = " & dbStr(IdProducto)
                    sql &= " and IdRamo = " & dbStr(IdRamo)
                    sql &= " and TipoMovimiento = 'ANULACION'"
                    Existe = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Existe = 0
                End Try
                If Existe = 0 And res = "" Then
                    If Not FechaAnulado = Nothing Then
                        res &= Cartera_AnularFactura(NumeroFactura, Poliza, IdProducto, FechaAnulado, Prima, GastosEmi, GastosFin, GastosBomb, GastosOtros, Iva, Total, Comision, IdRamo, "ANULACIÓN", RetIva)
                    End If
                End If
            End If
            'res &= "La Factura ya existe;"
        Else
            If Analizar = False Then
                If res = "" Then
                    res &= Cartera_AgregarFactura(NumeroFactura, IdProducto, Poliza, TipoFactura, Anexo, IdCliente, NombreCliente, FechaEmision, FechaPago, VigenciaDesde, VigenciaHasta, NumCuota, TotalCuotas, Prima, GastosEmi, GastosFin, GastosBomb, GastosOtros, Iva, Total, Comision, Referencia, Observaciones, PorceComision, IdRamo, RetIva, AplicarRetencion, Nothing, PrimaExenta)

                    'como es migracion actualizamos la fecha de emitida de las facturas
                    sql = " update FacturasMovimientos set fechamovimiento = " & dbFec(FechaEmision)
                    sql &= " where NumeroFactura = " & dbInt(NumeroFactura)
                    sql &= " and IdPoliza = " & dbStr(Poliza)
                    sql &= " and IdProducto = " & dbStr(IdProducto)
                    sql &= " and IdRamo = " & dbStr(IdRamo)
                    sql &= " and TipoMovimiento = 'EMISION' "
                    StiGlobalConn.SQLExecute(sql)


                    If res = "" Then
                        If Not FechaPagado = Nothing Then
                            res &= Cartera_AgregarPago(NumeroFactura, Poliza, IdProducto, FechaPagado, Prima, GastosEmi, GastosFin, GastosBomb, GastosOtros, Iva, Total, Comision, IdRamo, RetIva, "")
                        End If
                        If Not FechaAnulado = Nothing Then
                            res &= Cartera_AnularFactura(NumeroFactura, Poliza, IdProducto, FechaAnulado, Prima, GastosEmi, GastosFin, GastosBomb, GastosOtros, Iva, Total, Comision, IdRamo, "ANULACIÓN", RetIva)
                        End If
                    End If
                End If
            End If
        End If

        Return res

    End Function

    Private Function DeterminarAseguradora(ByVal Valor As String) As String
        Dim res As String = ""
        If Valor.Trim <> "" Then
            Valor = Trim(Valor)
            'ententamos si nos han mandado el código de Aseg.
            Try
                res = StiGlobalConn.ObtenerDataset("select idaseguradora from aseguradoras where idaseguradora = " & dbStr(Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                res = ""
            End Try
            'intentaremos por nombre completo
            If res = "" Then
                Try
                    res = StiGlobalConn.ObtenerDataset("select idaseguradora from aseguradoras where Nombre = " & dbStr(Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
            End If
            'intentaremos por nombre similar
            If res = "" Then
                Try
                    res = StiGlobalConn.ObtenerDataset("select idaseguradora from aseguradoras where Nombre like " & dbStr("%" & Valor & "%")).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
            End If
            'intentaremos por sigla de la aseg
            If res = "" Then
                Try
                    res = StiGlobalConn.ObtenerDataset("select idaseguradora from aseguradoras where Siglas = " & dbStr(Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
            End If

            'hay aseguradoras que comienzan por el mismo nombre no conviene validarlo asi.
            ''finalmente por nombres parciales
            'If res = "" Then
            '    Dim NumP As Integer = CuentaCar(Valor, " ") + 1
            '    For NP As Integer = NumP - 1 To 1 Step -1
            '        res = stiSplit(Valor, "G0 " & NP)
            '        Try
            '            res = StiGlobalConn.ObtenerDataset("select idaseguradora from aseguradoras where Nombre like " & dbStr("%" & res & "%")).Tables(0).Rows(0).Item(0)
            '            Exit For
            '        Catch ex As Exception
            '            res = ""
            '        End Try
            '    Next
            'End If
        End If
        Return res
    End Function

    Private Function DeterminarRamo(ByVal Ramo As String, ByVal IdProducto As String) As String
        Dim res As String = ""
        If Ramo.Trim <> "" Then
            Ramo = Trim(Ramo)
            'intentamos si nos han mandado el código
            Try
                res = StiGlobalConn.ObtenerDataset("select idramo from RamoSeguros where idramo = " & dbStr(Ramo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                res = ""
            End Try
            'intentaremos por nombre completo
            If res = "" Then
                Try
                    res = StiGlobalConn.ObtenerDataset("select idramo from RamoSeguros where NombreRamo = " & dbStr(Ramo)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
            End If
            'intentaremos por nombre similar
            If res = "" Then
                Try
                    res = StiGlobalConn.ObtenerDataset("select idramo from RamoSeguros where NombreRamo like " & dbStr("%" & Ramo & "%")).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
            End If
            'finalmente por nombres parciales
            If res = "" Then
                Dim NumP As Integer = CuentaCar(Ramo.Trim, " ") + 1
                For NP As Integer = NumP - 1 To 1 Step -1
                    res = stiSplit(Ramo, "G0 " & NP)
                    Try
                        res = StiGlobalConn.ObtenerDataset("select idramo from RamoSeguros where NombreRamo like " & dbStr("%" & res & "%")).Tables(0).Rows(0).Item(0)
                        Exit For
                    Catch ex As Exception
                        res = ""
                    End Try
                Next
            End If
        End If

        If IdProducto <> "" And res = "" Then
            'nos dan el producto, devolvemos el ramo de ese producto
            Try
                res = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                res = ""
            End Try
        End If


        Return res
    End Function

    Private Function DeterminarProducto(ByVal IdAseguradora As String, ByVal Producto As String, ByVal Ramo As String, ByVal IdPoliza As String) As String
        Dim res As String = ""
        If IdAseguradora <> "" Then
            Producto = Trim(Producto)
            Ramo = Trim(Ramo)

            If Producto <> "" Then
                'intentamos si nos han mandado el código
                Try
                    res = StiGlobalConn.ObtenerDataset("select IdProducto from Productos where idaseguradora = " & dbStr(IdAseguradora) & " and IdProducto = " & dbStr(Producto)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
                'intentaremos por nombre completo
                If res = "" Then
                    Try
                        res = StiGlobalConn.ObtenerDataset("select IdProducto from Productos where idaseguradora = " & dbStr(IdAseguradora) & " and Descripcion = " & dbStr(Producto)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        res = ""
                    End Try
                End If
                'intentaremos por nombre similar
                If res = "" Then
                    Try
                        res = StiGlobalConn.ObtenerDataset("select IdProducto from Productos where idaseguradora = " & dbStr(IdAseguradora) & " and Descripcion like " & dbStr("%" & Producto & "%")).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        res = ""
                    End Try
                End If
                'finalmente por nombres parciales
                If res = "" Then
                    Dim NumP As Integer = CuentaCar(Producto.Trim, " ") + 1
                    For NP As Integer = NumP - 1 To 1 Step -1
                        res = stiSplit(Producto, "G0 " & NP)
                        Try
                            res = StiGlobalConn.ObtenerDataset("select IdProducto from Productos where idaseguradora = " & dbStr(IdAseguradora) & " and Descripcion like " & dbStr("%" & res & "%")).Tables(0).Rows(0).Item(0)
                            Exit For
                        Catch ex As Exception
                            res = ""
                        End Try
                    Next
                End If
            End If

            'buscaremos el producto de ese ramo de la aseguradora.
            If Ramo <> "" And res = "" Then
                Dim strRamoTemp As String = DeterminarRamo(Ramo, "")
                If strRamoTemp <> "" Then
                    'buscaremos el primer producto de la aseguradora de ese ramo
                    Try
                        res = StiGlobalConn.ObtenerDataset("select idproducto from productos where idaseguradora = " & dbStr(IdAseguradora) & " and idramo = " & dbStr(strRamoTemp)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        res = ""
                    End Try

                End If
            End If
        End If

        'probamos si la póliza existe, validamos la primera póliza 
        If res = "" And IdPoliza <> "" Then
            Try
                Dim NumPolizas As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Polizas where idpoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0).Item(0)
                If NumPolizas = 1 Then
                    res = StiGlobalConn.ObtenerDataset("select idproducto from Polizas where idpoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0).Item(0)
                End If
            Catch ex As Exception
                res = ""
            End Try
        End If

        Return res
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'campos obligatorios
        If Me.txtArchivo.Text = "" Then
            MsgBox("Debe especificar el Archivo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        btnBuscar.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        DeterAnalisis = False
        Me.btnGuardarComo.Visible = True
        Me.btnGuardarComo.Enabled = True

        Dim Existe As Integer = 0
        Dim FilNombre As String = ""
        Dim Fila As Integer = FilEncabezado + 1
        'recorremos el archivo.
        Dim MiExcel As Object = Nothing
        Dim Hoja As Object
        Dim FilArchivo As DataRow
        Dim Fallo As Integer
        Dim Mensaje As String

        dtAnalisis.Rows.Clear()

        Me.GridAnalizar.DataSource = Nothing
        Me.GridAnalizar.Refresh()

        Dim ResultadoFactura As String = "", HayErrores As Boolean = False
        Try
            Try
                ValorBarra = 0
                Barra.Value = ValorBarra
                Barra.Visible = True
            Catch ex As Exception

            End Try



            MiExcel = CreateObject("Excel.Application")
            MiExcel.Workbooks.Open(txtArchivo.Valor)
            Hoja = MiExcel.Worksheets(1)

            FilNombre = Hoja.Cells(Fila, 1).Value
            While FilNombre <> ""
                If DeterAnalisis = True Then
                    GoTo Detener
                End If
                ResultadoFactura = ProcesarFactura(Hoja, Fila, True)
                If ResultadoFactura = "" Then
                    Fallo = 0
                    Mensaje = "OK"
                Else
                    Fallo = 1
                    Mensaje = ResultadoFactura
                    HayErrores = True
                    Hoja.Cells(Fila, ColMensaje).Value = Mensaje
                End If

                FilArchivo = dtAnalisis.NewRow
                FilArchivo("Fila") = Fila
                FilArchivo("Fallo") = Fallo
                FilArchivo("Mensaje") = Mensaje
                dtAnalisis.Rows.Add(FilArchivo)

                Fila += 1
                FilNombre = Hoja.Cells(Fila, 1).Value
                Try
                    ValorBarra += TasaBarra
                    Barra.Value = ValorBarra
                    Application.DoEvents()
                Catch ex As Exception

                End Try
                If Fila Mod 10 = True Then Application.DoEvents()
            End While

Detener:
            DeterAnalisis = False
            Me.btnGuardarComo.Visible = False
            MiExcel.ActiveWorkbook.Save()
            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing

            Me.GridAnalizar.DataSource = dtAnalisis
            Me.GridAnalizar.Refresh()

            Try
                ValorBarra = 0
                Barra.Value = ValorBarra
                Barra.Visible = False
            Catch ex As Exception

            End Try

            btnBuscar.Enabled = True
            Me.Cursor = Cursors.Default

            If HayErrores = False Then
                MsgBox("El archivo es correcto y se subirán todas las facturas.", MsgBoxStyle.Information, "AVISO...")
            Else
                MsgBox("El archivo contiene facturas que no pueden ser procesadas. Se actualizó el archivo con las observaciones.", MsgBoxStyle.Exclamation, "ERROR...")
            End If

        Catch ex As Exception
            ValorBarra = 0
            Barra.Value = ValorBarra
            Barra.Visible = False
            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing
            btnGuardar.Enabled = True
            Me.Cursor = Cursors.Default
            MsgBox("Error al realizar el analisis " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
            Dim Archivo As String = SubKey.GetValue("Personal") & "\ValidaFacturas" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridAnalizar.ExportToXls(Archivo, Opciones)
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnGuardarComo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarComo.Click
        DeterAnalisis = True
    End Sub

End Class
