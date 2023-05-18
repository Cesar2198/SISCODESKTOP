Imports Utilerias.Genericas

Public Class ImportarReclamos
    Dim dtArchivo As DataTable
    'la fila del encabezado.
    Dim FilEncabezado As Integer = 1
    Dim ColMensaje As Integer = -1

    Dim TasaBarra As Double = 0
    Dim ValorBarra As Double = 0

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub IniciarTabla()
        dtArchivo = New DataTable
        dtArchivo.Columns.Add("Columna", System.Type.GetType("System.Int32"))
        dtArchivo.Columns.Add("Colarchivo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Tipo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Observacion", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Campo", System.Type.GetType("System.String"))
        dtArchivo.TableName = "Archivo"
    End Sub

    Private Sub ImportarReclamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IniciarTabla()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "G" : FilaTD("Tipo") = "Datos Generales" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "C" : FilaTD("Tipo") = "Coberturas" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "B" : FilaTD("Tipo") = "Bienes" : TD.Rows.Add(FilaTD)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Tipo"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TD
        RepositoryItemLookUpEdit1.PopulateColumns()
        RepositoryItemLookUpEdit1.Columns("Id").Visible = False

        btnGuardar.Enabled = True
        btnBuscar.Enabled = True

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
            lblMensaje.Text = "Número de Registros Encontrados: " & Format(NumRegistros, "#,###0")

            If NumRegistros = 0 Then
                MsgBox("No se encontraron registros para importar.", MsgBoxStyle.Information, "AVISO...")
                Me.btnNuevo.Enabled = False
                Me.btnGuardar.Enabled = False
            Else
                Me.btnNuevo.Enabled = True
                Me.btnGuardar.Enabled = True
            End If

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

    Public Function DeterminarColumna(ByVal NombreColumna As String) As String
        ''retornamos Tipo|ColBaseDatos|Comentario
        Dim Res As String = ""
        Try
            NombreColumna = Replace(NombreColumna.Trim.ToUpper, " ", "")
            'basados en el nombre de la columna determinaremos el tipo
            Select Case NombreColumna
                '********SECCION GENERALES

                Case "NO.RECLAMO", "RECLAMO"
                    Res = "G|IdSiniestro|"
                Case "ASEGURADORA"
                    Res = "G|IdAseguradora|"
                Case "CERTIFICADO"
                    Res = "G|IdCertificado|"
                Case "RAMO", "IDRAMO"
                    Res = "G|IdRamo|"
                Case "PRODUCTO"
                    Res = "G|IdProducto|"
                Case "POLIZA", "IDPOLIZA"
                    Res = "G|IdPoliza|"
                Case "IDCLIENTE", "COD.CLIENTE", "COD_CLIENTE"
                    Res = "G|IdCliente|"
                Case "CLIENTE", "NOMBRECLIENTE", "NOMBREASEGURADO", "NOM.ASEGURADO", "ASEGURADO"
                    Res = "G|NombreCliente|"
                Case "NOMBREBENEFICIARIO", "BENEFICIARIO"
                    Res = "G|NombreBeneficiario|"
                Case "FECHAOCURRIDO", "OCURRIDO"
                    Res = "G|FechaOcurrido|"
                Case "FECHAPRESENTADO", "PRESENTADO"
                    Res = "G|FechaPresentado|"
                Case "VIGENCIADESDE", "VIGENCIA.DESDE", "VIGENCIA_DESDE", "VIG.DESDE"
                    Res = "G|VigenciaDesde|"
                Case "VIGENCIAHASTA", "VIGENCIA.HASTA", "VIGENCIA_HASTA", "VIG.HASTA"
                    Res = "G|VigenciaHasta|"
                Case "LUGARSINIESTRO"
                    Res = "G|LugarSiniestros|"
                Case "DESCRIPCIONSINIESTRO"
                    Res = "G|DescripcionSiniestro|"
                Case "COMENTARIOS"
                    Res = "G|DescripcionReserva|"
                Case "VALORPRESENTADO", "PRESENTADO"
                    Res = "G|TotalPresentado|"
                Case "VALORNOCUBIERTO", "NOCUBIERTO"
                    Res = "G|TotalNoCubierto|"
                Case "VALORCUBIERTO", "CUBIERTO"
                    Res = "G|TotalCubierto|"
                Case "TOTALPAGADO", "PAGADO"
                    Res = "G|TotalReembolso|"
                Case "VALORDEDUCIBLE", "DEDUCIBLE"
                    Res = "G|TotalDeducible|"
                Case "VALORCOASEGURO", "COASEGURO"
                    Res = "G|TotalCoaseguro|"
                Case "VALORDEUDORES", "DEUDORES"
                    Res = "G|TotalDeudores|"
                Case "SALDODEUDORES"
                    Res = "G|SaldoDeudores|"
                Case "FECHARECHAZADO", "RECHAZADO"
                    Res = "G|FechaRechazado|"
                Case "FECHAPAGO", "PAGO"
                    Res = "G|FechaPago|"
                Case "FECHAABONODEDUCIBLE", "ABONODEDUCIBLE"
                    Res = "G|FechaAbonoDeducible|"
            End Select

            If Res = "" Then
                Res = "||Columna se Omitirá"
            End If

        Catch ex As Exception
            Res = "||Columna se Omitirá"
        End Try
        Return Res
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
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

            Hoja.Cells(Fila, 1).Value = "NO. RECLAMO"
            Hoja.Cells(Fila, 2).Value = "POLIZA"
            Hoja.Cells(Fila, 3).Value = "CERTIFICADO"
            Hoja.Cells(Fila, 4).Value = "ASEGURADORA"
            Hoja.Cells(Fila, 5).Value = "RAMO"
            Hoja.Cells(Fila, 6).Value = "PRODUCTO"
            Hoja.Cells(Fila, 7).Value = "FECHA OCURRIDO"
            Hoja.Cells(Fila, 8).Value = "FECHA PRESENTADO"
            Hoja.Cells(Fila, 9).Value = "VIGENCIA DESDE"
            Hoja.Cells(Fila, 10).Value = "VIGENCIA HASTA"
            Hoja.Cells(Fila, 11).Value = "COD.CLIENTE"
            Hoja.Cells(Fila, 12).Value = "NOMBRE ASEGURADO"
            Hoja.Cells(Fila, 13).Value = "NOMBRE BENEFICIARIO"
            Hoja.Cells(Fila, 14).Value = "LUGAR SINIESTRO"
            Hoja.Cells(Fila, 15).Value = "DESCRIPCION SINIESTRO"
            Hoja.Cells(Fila, 16).Value = "COMENTARIOS"
            Hoja.Cells(Fila, 17).Value = "VALOR PRESENTADO"
            Hoja.Cells(Fila, 18).Value = "VALOR NO CUBIERTO"
            Hoja.Cells(Fila, 19).Value = "VALOR CUBIERTO"
            Hoja.Cells(Fila, 20).Value = "TOTAL PAGADO"
            Hoja.Cells(Fila, 21).Value = "VALOR DEDUCIBLE"
            Hoja.Cells(Fila, 22).Value = "VALOR COASEGURO"
            Hoja.Cells(Fila, 23).Value = "VALOR DEUDORES"
            Hoja.Cells(Fila, 24).Value = "SALDO DEUDORES"
            Hoja.Cells(Fila, 25).Value = "FECHA RECHAZADO"
            Hoja.Cells(Fila, 26).Value = "FECHA PAGO"
            Hoja.Cells(Fila, 27).Value = "FECHA ABONO DEDUCIBLE"

            Col = 27

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

            'hay aseguradoras que comienzan por el mismo nombre, esto no es conveniente validarlos asi
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

    Private Function DeterminarProducto(ByVal IdAseguradora As String, ByVal Producto As String, ByVal Ramo As String) As String
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
        Return res
    End Function

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'campos obligatorios
        If Me.txtArchivo.Text = "" Then
            MsgBox("Debe especificar el Archivo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        btnNuevo.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Dim Existe As Integer = 0
        Dim FilNombre As String = ""
        Dim Fila As Integer = FilEncabezado + 1
        'recorremos el archivo.
        Dim MiExcel As Object = Nothing
        Dim Hoja As Object
        Dim IdCerttificado As String = ""
        Dim res As String = ""
        Dim HayErrores As Boolean = False
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
                'CREAMOS LA PÓLIZA
                res = CrearReclamo(Hoja, Fila, True)
                If res <> "" Then
                    'marcamos el archivo
                    Hoja.Cells(Fila, ColMensaje).Value = res
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

            Try
                ValorBarra = 0
                Barra.Value = ValorBarra
                Barra.Visible = False
            Catch ex As Exception

            End Try
            Me.LimpiarCampos(Me)
            Me.lblMensaje.Text = ""

            btnNuevo.Enabled = True
            Me.Cursor = Cursors.Default

            If HayErrores = True Then
                MsgBox("El archivo presenta error en los datos no todas los reclamos se cargarían, los errores los encontrará en el archivo que especificó.", MsgBoxStyle.Exclamation, "ERROR...")
            Else
                MsgBox("El archivo no presenta errores se puede importar con éxito.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            ValorBarra = 0
            Barra.Value = ValorBarra
            Barra.Visible = False
            Hoja = Nothing
            MiExcel.Quit()
            MiExcel = Nothing
            btnNuevo.Enabled = True
            Me.Cursor = Cursors.Default
            MsgBox("Error al realizar la operación, el proceso se ha cancelado. Error en la fila: " & Fila & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function CrearReclamo(ByRef Hoja As Object, ByVal Fila As Integer, ByVal Revision As Boolean) As String
        'basados en información general creamos el encabezado de la póliza
        Dim Res As String = ""
        Dim sql As String = ""
        
        'primero buscaremos los campos llave para la póliza
        Dim IdPoliza As String = ""
        If ExisteCampo("IdPoliza") = True Then
            IdPoliza = ObtenerDatoArchivo(Hoja, Fila, "IdPoliza").Trim
            If IdPoliza = "" Then
                Res &= "Falta Número Póliza;"
            End If
        Else
            Res &= "Falta Número Póliza;"
        End If

        Dim IdCertificado As String = ""
        If ExisteCampo("IdCertificado") = True Then
            IdCertificado = ObtenerDatoArchivo(Hoja, Fila, "IdCertificado").Trim
            If IdCertificado = "" Then
                Res &= "Falta el Certificado;"
            End If
        Else
            Res &= "Falta el Certificado;"
        End If

        Dim IdSiniestro As String = ""
        If ExisteCampo("IdSiniestro") = True Then
            IdSiniestro = ObtenerDatoArchivo(Hoja, Fila, "IdSiniestro").Trim
            If IdSiniestro = "" Then
                Res &= "Falta No. de Reclamo;"
            End If
        Else
            Res &= "Falta No. de Reclamo;"
        End If

        Dim IdAseguradora As String = ""
        Dim IdProducto As String = ""
        If ExisteCampo("IdAseguradora") = True Then
            IdAseguradora = DeterminarAseguradora(ObtenerDatoArchivo(Hoja, Fila, "IdAseguradora"))
            If IdAseguradora = "" Then
                Res &= "No se encuentra Aseguradora;"
            Else
                If ExisteCampo("IdProducto") = True Or ExisteCampo("IdRamo") = True Then
                    IdProducto = DeterminarProducto(IdAseguradora, ObtenerDatoArchivo(Hoja, Fila, "IdProducto"), ObtenerDatoArchivo(Hoja, Fila, "IdRamo"))
                    If IdProducto = "" Then
                        Res &= "No se encuentra el Producto;"
                    End If
                End If
            End If
        Else
            Res &= "Falta Aseguradora;"
        End If

        Dim IdCliente As String = ""
        If ExisteCampo("IdCliente") = True Then
            IdCliente = ObtenerDatoArchivo(Hoja, Fila, "IdCliente").Trim
        End If

        Dim NombreCliente As String = ""
        If ExisteCampo("NombreCliente") = True Then
            NombreCliente = ObtenerDatoArchivo(Hoja, Fila, "NombreCliente").Trim
            If NombreCliente = "" Then
                Res &= "Falta Nombre Cliente;"
            End If
        Else
            Res &= "Falta Nombre Cliente;"
        End If

        Dim NombreBeneficiario As String = ""
        If ExisteCampo("NombreBeneficiario") = True Then
            NombreBeneficiario = ObtenerDatoArchivo(Hoja, Fila, "NombreBeneficiario").Trim
            If NombreBeneficiario = "" Then
                Res &= "Falta Beneficiario;"
            End If
        Else
            Res &= "Falta Beneficiario;"
        End If

        Dim VigenciaDesde As String = ""
        If ExisteCampo("VigenciaDesde") = True Then
            VigenciaDesde = ObtenerDatoArchivo(Hoja, Fila, "VigenciaDesde").Trim
        End If

        Dim VigenciaHasta As String = ""
        If ExisteCampo("VigenciaHasta") = True Then
            VigenciaHasta = ObtenerDatoArchivo(Hoja, Fila, "VigenciaHasta").Trim
        End If

        Dim FechaOcurrido As String = ""
        If ExisteCampo("FechaOcurrido") = True Then
            FechaOcurrido = ObtenerDatoArchivo(Hoja, Fila, "FechaOcurrido").Trim
            If FechaOcurrido = "" Then
                Res &= "Falta Fec. Ocurrido;"
            End If
        Else
            Res &= "Falta Fec. Ocurrido;"
        End If

        Dim FechaPresentado As String = ""
        If ExisteCampo("FechaPresentado") = True Then
            FechaPresentado = ObtenerDatoArchivo(Hoja, Fila, "FechaPresentado").Trim
            If FechaPresentado = "" Then
                Res &= "Falta Fec. Presentado;"
            End If
        Else
            Res &= "Falta Fec. Presentado;"
        End If

        Dim LugarSiniestros As String = ""
        If ExisteCampo("LugarSiniestros") = True Then
            LugarSiniestros = ObtenerDatoArchivo(Hoja, Fila, "LugarSiniestros").Trim
        End If

        Dim DescripcionSiniestro As String = ""
        If ExisteCampo("DescripcionSiniestro") = True Then
            DescripcionSiniestro = ObtenerDatoArchivo(Hoja, Fila, "DescripcionSiniestro").Trim
            If DescripcionSiniestro = "" Then
                Res &= "Falta Descripción del Sisniestro;"
            End If
        Else
            Res &= "Falta Descripción del Sisniestro;"
        End If

        Dim DescripcionReserva As String = ""
        If ExisteCampo("DescripcionReserva") = True Then
            DescripcionReserva = ObtenerDatoArchivo(Hoja, Fila, "DescripcionReserva").Trim
        End If

        Dim TotalPresentado As Double = 0
        If ExisteCampo("TotalPresentado") = True Then
            TotalPresentado = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalPresentado"))
            If TotalPresentado = 0 Then
                Res &= "Falta Valor Presentado;"
            End If
        Else
            Res &= "Falta Valor Presentado;"
        End If

        Dim TotalNoCubierto As Double = 0
        If ExisteCampo("TotalNoCubierto") = True Then
            TotalNoCubierto = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalNoCubierto").Trim)
        End If

        Dim TotalCubierto As Double = 0
        If ExisteCampo("TotalCubierto") = True Then
            TotalCubierto = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalCubierto"))
            If TotalCubierto = 0 Then
                Res &= "Falta Valor Cubierto;"
            End If
        Else
            Res &= "Falta Valor Cubierto;"
        End If

        Dim TotalReembolso As Double = 0
        If ExisteCampo("TotalReembolso") = True Then
            TotalReembolso = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalReembolso"))
        End If

        Dim TotalDeducible As Double = 0
        If ExisteCampo("TotalDeducible") = True Then
            TotalDeducible = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalDeducible").Trim)
        End If

        Dim TotalCoaseguro As Double = 0
        If ExisteCampo("TotalCoaseguro") = True Then
            TotalCoaseguro = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalCoaseguro").Trim)
        End If

        Dim TotalDeudores As Double = 0
        If ExisteCampo("TotalDeudores") = True Then
            TotalDeudores = Val(ObtenerDatoArchivo(Hoja, Fila, "TotalDeudores").Trim)
        End If

        Dim SaldoDeudores As Double = 0
        If ExisteCampo("SaldoDeudores") = True Then
            SaldoDeudores = Val(ObtenerDatoArchivo(Hoja, Fila, "SaldoDeudores").Trim)
        End If

        Dim FechaRechazado As String = ""
        If ExisteCampo("FechaRechazado") = True Then
            FechaRechazado = ObtenerDatoArchivo(Hoja, Fila, "FechaRechazado").Trim
        End If

        Dim FechaPago As String = ""
        If ExisteCampo("FechaPago") = True Then
            FechaPago = ObtenerDatoArchivo(Hoja, Fila, "FechaPago").Trim
        End If

        Dim FechaAbonoDeducible As String = ""
        If ExisteCampo("FechaAbonoDeducible") = True Then
            FechaAbonoDeducible = ObtenerDatoArchivo(Hoja, Fila, "FechaAbonoDeducible").Trim
        End If

        Dim EstadoSiniestro As String = "PENDIENTE"
        If FechaRechazado <> "" Then EstadoSiniestro = "RECHAZADO"
        If FechaAbonoDeducible <> "" Then EstadoSiniestro = "ABDEDU"
        If FechaPago <> "" Then EstadoSiniestro = "PAGADO"


        Dim TotalPendiente As Double = 0
        TotalPendiente = TotalCubierto - TotalReembolso - TotalDeducible - TotalCoaseguro
        If TotalPendiente <= 0 Then TotalPendiente = 0

        If IdSiniestro <> "" And IdProducto <> "" And IdPoliza <> "" Then
            'verificamos si el reclamo ya existe
            Dim ExisteRec As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Siniestros where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & " and IdSiniestroAseguradora = " & dbStr(IdSiniestro)).Tables(0).Rows(0).Item(0)
            If ExisteRec = 0 Then
                Try
                    If Res = "" And Revision = False Then

                        StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                        Dim NumReclamo As String = clSeguros.ObtenerID("Reclamos.Num." & Date.Today.Year) & "-" & Date.Today.Year

                        sql = "  insert into Siniestros "
                        sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, FechaOcurrido, "
                        sql &= " FechaPresentado, EstadoSiniestro, NombrePresentaReclamo, LugarSiniestros, DescripcionSiniestro, "
                        sql &= " DescripcionReserva, TotalPresentado, TotalNoCubierto, TotalCubierto, TotalDeducible, "
                        sql &= " TotalCoaseguro, TotalDeudores, TotalReembolso, TotalPendiente, IdSiniestroAseguradora, "
                        sql &= " VigenciaDesde, VigenciaHasta, NombreBeneficiario, IdBien, IdEnvio) values("
                        sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbFec(FechaOcurrido) & C
                        sql &= dbFec(FechaPresentado) & C & dbStr(EstadoSiniestro, 25) & C & dbStr(NombreCliente, 150) & C & dbStr(LugarSiniestros) & C & dbStr(DescripcionSiniestro) & C
                        sql &= dbStr(DescripcionReserva) & C & dbNum(TotalPresentado) & C & dbNum(TotalNoCubierto) & C & dbNum(TotalCubierto) & C & dbNum(TotalDeducible) & C
                        sql &= dbNum(TotalCoaseguro) & C & dbNum(TotalDeudores) & C & dbNum(TotalReembolso) & C & dbNum(TotalPendiente) & C & dbStr(IdSiniestro, 25) & C
                        sql &= dbFec(VigenciaDesde) & C & dbFec(VigenciaHasta) & C & dbStr(NombreBeneficiario, 150) & C & dbInt("") & C & dbStr("", 25) & ")"
                        StiGlobalConn.SQLExecute(sql)

                        RegistrarLog("A", "Siniestros", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdSiniestroAseguradora = " & dbStr(IdSiniestro, 25))

                        'ahora la información relacionadas

                        'detalle
                        If TotalCubierto > 0 Then
                            sql = "  insert into SiniestrosDetalle "
                            sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDetalle, "
                            sql &= " DescripcionGastos, ValorPresentado, ValorNoCubierto, ValorCubierto, IdGasto) values("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbStr("INDEMNIZACION") & C & dbNum(TotalPresentado) & C & dbNum(TotalNoCubierto) & C & dbNum(TotalCubierto) & C & dbInt("") & ")"
                            StiGlobalConn.SQLExecute(sql)
                        End If

                        'Deudores
                        If TotalDeudores > 0 Then
                            sql = "  insert into SiniestrosDeudores "
                            sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDeudor"
                            sql &= " , FechaDeudor, Descripcion, ValorDeudor) values("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbFec(FechaPresentado) & C & dbStr("INGRESO DEUDORES VARIOS", 150) & C & dbNum(TotalDeudores) & ")"
                            StiGlobalConn.SQLExecute(sql)

                            Dim ValPagoDed As Double = TotalDeudores - SaldoDeudores
                            If ValPagoDed <= 0 Then ValPagoDed = 0
                            If ValPagoDed > 0 Then
                                sql = "  insert into SiniestrosDeudores "
                                sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDeudor"
                                sql &= " , FechaDeudor, Descripcion, ValorDeudor) values("
                                sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(2) & C
                                sql &= dbFec(FechaPresentado) & C & dbStr("PAGO DEUDORES VARIOS", 150) & C & dbNum(ValPagoDed * -1) & ")"
                                StiGlobalConn.SQLExecute(sql)
                            End If
                        End If

                        'pagos
                        If TotalReembolso > 0 Then
                            sql = "  insert into SiniestrosPagos "
                            sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdPago, "
                            sql &= " FechaPago, NombreCheque, NumeroCheque, ValorGasto, ValorDescuento, "
                            sql &= " ValorRenta, ValorIva, ValorRetencionIva, ValorReembolso) Values( "

                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbFec(FechaPago) & C & dbStr(NombreCliente, 150) & C & dbStr("PAGO", 25) & C & dbNum(TotalReembolso) & C & dbNum(0) & C
                            sql &= dbNum(0) & C & dbNum(0) & C & dbNum(0) & C & dbNum(TotalReembolso) & ")"
                            StiGlobalConn.SQLExecute(sql)
                        End If


                        'reservas
                        If TotalCubierto > 0 Then
                            sql = "  insert into SiniestrosReservas "
                            sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva, "
                            sql &= " FechaReserva, ValorAsegurado, ValorReserva) values ("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbFec(FechaPresentado) & C & dbNum(0) & C & dbNum(TotalCubierto) & ")"
                            StiGlobalConn.SQLExecute(sql)

                            If TotalReembolso > 0 Then
                                sql = "  insert into SiniestrosReservas "
                                sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva, "
                                sql &= " FechaReserva, ValorAsegurado, ValorReserva) values ("
                                sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(2) & C
                                sql &= dbFec(FechaPago) & C & dbNum(0) & C & dbNum(TotalReembolso * -1) & ")"
                                StiGlobalConn.SQLExecute(sql)
                            End If

                            If EstadoSiniestro = "PAGADO" Then
                                'saldamos el reclamo por la diferencia
                                Dim SaldoRes As Double = (TotalCubierto - TotalReembolso) * -1
                                If SaldoRes <> 0 Then
                                    sql = "  insert into SiniestrosReservas "
                                    sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva, "
                                    sql &= " FechaReserva, ValorAsegurado, ValorReserva) values ("
                                    sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(3) & C
                                    sql &= dbFec(FechaPago) & C & dbNum(0) & C & dbNum(SaldoRes) & ")"
                                    StiGlobalConn.SQLExecute(sql)
                                End If
                            End If
                        End If


                        StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

                    End If
                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    Res &= ex.Message
                End Try
            Else
                Try
                    If Res = "" And Revision = False Then

                        StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                        Dim NumReclamo As String = StiGlobalConn.ObtenerDataset("select IdSiniestro from Siniestros where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & " and IdSiniestroAseguradora = " & dbStr(IdSiniestro)).Tables(0).Rows(0).Item(0)

                        sql = "  update Siniestros set "
                        sql &= "  FechaOcurrido =  " & dbFec(FechaOcurrido)
                        sql &= " , FechaPresentado = " & dbFec(FechaPresentado)
                        sql &= " , EstadoSiniestro = " & dbStr(EstadoSiniestro, 25)
                        sql &= " , NombrePresentaReclamo = " & dbStr(NombreCliente, 150)
                        sql &= " , LugarSiniestros = " & dbStr(LugarSiniestros)
                        sql &= " , DescripcionSiniestro = " & dbStr(DescripcionSiniestro)
                        sql &= " , DescripcionReserva = " & dbStr(DescripcionReserva)
                        sql &= " , TotalPresentado = " & dbNum(TotalPresentado)
                        sql &= " , TotalNoCubierto = " & dbNum(TotalNoCubierto)
                        sql &= " , TotalCubierto = " & dbNum(TotalCubierto)
                        sql &= " , TotalDeducible = " & dbNum(TotalDeducible)
                        sql &= " , TotalCoaseguro = " & dbNum(TotalCoaseguro)
                        sql &= " , TotalDeudores = " & dbNum(TotalDeudores)
                        sql &= " , TotalReembolso = " & dbNum(TotalReembolso)
                        sql &= " , TotalPendiente = " & dbNum(TotalPendiente)
                        sql &= " , IdSiniestroAseguradora = " & dbStr(IdSiniestro, 25)
                        sql &= " , VigenciaDesde = " & dbFec(VigenciaDesde)
                        sql &= " , VigenciaHasta = " & dbFec(VigenciaHasta)
                        sql &= " , NombreBeneficiario = " & dbStr(NombreBeneficiario, 150)
                        sql &= " where IdPoliza = " & dbStr(IdPoliza, 25)
                        sql &= " and IdProducto = " & dbStr(IdProducto, 25)
                        sql &= " and IdCertificado = " & dbStr(IdCertificado, 25)
                        sql &= " and IdSiniestro = " & dbStr(NumReclamo, 25)
                        
                        StiGlobalConn.SQLExecute(sql)

                        RegistrarLog("M", "Siniestros", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdSiniestroAseguradora = " & dbStr(IdSiniestro, 25))

                        'ahora la información relacionadas

                        'detalle
                        If TotalCubierto > 0 Then
                            StiGlobalConn.SQLExecute("delete from SiniestrosDetalle where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdDetalle = " & dbInt(1))
                            sql = "  insert into SiniestrosDetalle "
                            sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDetalle, "
                            sql &= " DescripcionGastos, ValorPresentado, ValorNoCubierto, ValorCubierto, IdGasto) values("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbStr("INDEMNIZACION") & C & dbNum(TotalPresentado) & C & dbNum(TotalNoCubierto) & C & dbNum(TotalCubierto) & C & dbInt("") & ")"
                            StiGlobalConn.SQLExecute(sql)
                        End If

                        'Deudores
                        If TotalDeudores > 0 Then
                            StiGlobalConn.SQLExecute("delete from SiniestrosDeudores where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdDeudor = " & dbInt(1))
                            sql = "  insert into SiniestrosDeudores "
                            sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDeudor"
                            sql &= " , FechaDeudor, Descripcion, ValorDeudor) values("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbFec(FechaPresentado) & C & dbStr("INGRESO DEUDORES VARIOS", 150) & C & dbNum(TotalDeudores) & ")"
                            StiGlobalConn.SQLExecute(sql)

                            Dim ValPagoDed As Double = TotalDeudores - SaldoDeudores
                            If ValPagoDed <= 0 Then ValPagoDed = 0
                            If ValPagoDed > 0 Then
                                StiGlobalConn.SQLExecute("delete from SiniestrosDeudores where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdDeudor = " & dbInt(2))
                                sql = "  insert into SiniestrosDeudores "
                                sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdDeudor"
                                sql &= " , FechaDeudor, Descripcion, ValorDeudor) values("
                                sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(2) & C
                                sql &= dbFec(FechaPresentado) & C & dbStr("PAGO DEUDORES VARIOS", 150) & C & dbNum(ValPagoDed * -1) & ")"
                                StiGlobalConn.SQLExecute(sql)
                            End If
                        End If

                        'pagos
                        If TotalReembolso > 0 Then
                            StiGlobalConn.SQLExecute("delete from SiniestrosPagos where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdPago = " & dbInt(1))

                            sql = "  insert into SiniestrosPagos "
                            sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdPago, "
                            sql &= " FechaPago, NombreCheque, NumeroCheque, ValorGasto, ValorDescuento, "
                            sql &= " ValorRenta, ValorIva, ValorRetencionIva, ValorReembolso) Values( "
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbFec(FechaPago) & C & dbStr(NombreCliente, 150) & C & dbStr("PAGO", 25) & C & dbNum(TotalReembolso) & C & dbNum(0) & C
                            sql &= dbNum(0) & C & dbNum(0) & C & dbNum(0) & C & dbNum(TotalReembolso) & ")"
                            StiGlobalConn.SQLExecute(sql)
                        End If

                        'reservas
                        If TotalCubierto > 0 Then
                            StiGlobalConn.SQLExecute("delete from SiniestrosReservas where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdReserva = " & dbInt(1))
                            sql = "  insert into SiniestrosReservas "
                            sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva, "
                            sql &= " FechaReserva, ValorAsegurado, ValorReserva) values ("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(1) & C
                            sql &= dbFec(FechaPresentado) & C & dbNum(0) & C & dbNum(TotalCubierto) & ")"
                            StiGlobalConn.SQLExecute(sql)

                            If TotalReembolso > 0 Then
                                StiGlobalConn.SQLExecute("delete from SiniestrosReservas where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdReserva = " & dbInt(2))
                                sql = "  insert into SiniestrosReservas "
                                sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva, "
                                sql &= " FechaReserva, ValorAsegurado, ValorReserva) values ("
                                sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(2) & C
                                sql &= dbFec(FechaPago) & C & dbNum(0) & C & dbNum(TotalReembolso * -1) & ")"
                                StiGlobalConn.SQLExecute(sql)
                            End If

                            If EstadoSiniestro = "PAGADO" Then
                                'saldamos el reclamo por la diferencia
                                Dim SaldoRes As Double = (TotalCubierto - TotalReembolso) * -1
                                If SaldoRes <> 0 Then
                                    StiGlobalConn.SQLExecute("delete from SiniestrosReservas where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25) & " and IdSiniestro = " & dbStr(NumReclamo, 25) & " and IdReserva = " & dbInt(3))
                                    sql = "  insert into SiniestrosReservas "
                                    sql &= " ( IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva, "
                                    sql &= " FechaReserva, ValorAsegurado, ValorReserva) values ("
                                    sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCertificado, 25) & C & dbStr(NumReclamo, 25) & C & dbInt(3) & C
                                    sql &= dbFec(FechaPago) & C & dbNum(0) & C & dbNum(SaldoRes) & ")"
                                    StiGlobalConn.SQLExecute(sql)
                                End If
                            End If
                        End If


                        StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

                    End If
                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    Res &= ex.Message
                End Try

            End If
        End If
        Return Res
    End Function

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
        Dim IdCerttificado As String = ""
        Dim res As String = ""
        Dim HayErrores As Boolean = False
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
                'CREAMOS LA PÓLIZA
                res = CrearReclamo(Hoja, Fila, False)
                If res <> "" Then
                    'marcamos el archivo
                    Hoja.Cells(Fila, ColMensaje).Value = res
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

            If HayErrores = True Then
                MsgBox("No Todas las pólizas se procesaron, los errores los encontrará en el archivo que especificó.", MsgBoxStyle.Exclamation, "ERROR...")
            Else
                MsgBox("La operación ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")
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
            MsgBox("Error al realizar la operación, el proceso se ha cancelado. Error en la fila: " & Fila & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
