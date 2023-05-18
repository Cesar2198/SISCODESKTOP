Imports Utilerias.Genericas

Public Class ImportarPolizas
    Dim dtArchivo As DataTable
    'la fila del encabezado.
    Dim FilEncabezado As Integer = 1
    Dim ColMensaje As Integer = -1
    Dim TasaBarra As Double = 0
    Dim ValorBarra As Double = 0
    Dim IdPolizaActual As String = ""
    Dim IdProductoActual As String = ""

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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

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

            Hoja.Cells(Fila, 1).Value = "POLIZA"
            Hoja.Cells(Fila, 2).Value = "ASEGURADORA"
            Hoja.Cells(Fila, 3).Value = "RAMO"
            Hoja.Cells(Fila, 4).Value = "PRODUCTO"
            Hoja.Cells(Fila, 5).Value = "COD.CLIENTE"
            Hoja.Cells(Fila, 6).Value = "NOMBRE CLIENTE"
            Hoja.Cells(Fila, 7).Value = "VIGENCIA.DESDE"
            Hoja.Cells(Fila, 8).Value = "VIGENCIA.HASTA"
            Hoja.Cells(Fila, 9).Value = "SUMA ASEGURADA"
            Hoja.Cells(Fila, 10).Value = "PRIMA BRUTA"
            Hoja.Cells(Fila, 11).Value = "DESCUENTOS"
            Hoja.Cells(Fila, 12).Value = "PRIMA NETA"
            Hoja.Cells(Fila, 13).Value = "GASTOS EMISION"
            Hoja.Cells(Fila, 14).Value = "GASTOS FRACCIONAMIENTO"
            Hoja.Cells(Fila, 15).Value = "GASTOS BOMBEROS"
            Hoja.Cells(Fila, 16).Value = "OTROS GASTOS"
            Hoja.Cells(Fila, 17).Value = "IMPUESTOS"
            Hoja.Cells(Fila, 18).Value = "PRIMA TOTAL"
            Hoja.Cells(Fila, 19).Value = "FECHA CANCELACION"

            Col = 19

            'Beneficiarios
            Col += 1 : Hoja.Cells(Fila, Col).Value = "NOMBRE BENEFICIARIO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "PARENTESCO BENEFICIARIO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "FECHA NACIMIENTO BENEFICIARIO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "PORCENTAJE BENEFICIARIO"

            'Cesiones
            Col += 1 : Hoja.Cells(Fila, Col).Value = "NOMBRE CESIONARIO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "FECHA CESION"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "SUMA CESION"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "NOTAS CESION"

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

    Private Sub ImportarPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call IniciarTabla()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "G" : FilaTD("Tipo") = "Datos Generales" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "C" : FilaTD("Tipo") = "Coberturas" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "B" : FilaTD("Tipo") = "Bienes" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "N" : FilaTD("Tipo") = "Beneficiarios" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "S" : FilaTD("Tipo") = "Cesiones" : TD.Rows.Add(FilaTD)

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

    Private Sub IniciarTabla()
        dtArchivo = New DataTable
        dtArchivo.Columns.Add("Columna", System.Type.GetType("System.Int32"))
        dtArchivo.Columns.Add("Colarchivo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Tipo", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Observacion", System.Type.GetType("System.String"))
        dtArchivo.Columns.Add("Campo", System.Type.GetType("System.String"))
        dtArchivo.TableName = "Archivo"
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
                    Res = "G|IdAseguradora|"
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
                Case "VIGENCIADESDE", "VIGENCIA.DESDE", "VIGENCIA_DESDE", "VIG.DESDE"
                    Res = "G|VigenciaDesde|"
                Case "VIGENCIAHASTA", "VIGENCIA.HASTA", "VIGENCIA_HASTA", "VIG.HASTA"
                    Res = "G|VigenciaHasta|"
                Case "SUMAASEGURADA", "SUMA_ASEGURADA", "SUMA", "VALORASEGURADO", "VALOR_ASEGURADO"
                    Res = "G|ValorAsegurado|"
                Case "PRIMA", "PRIMA.NETA", "PRIMANETA"
                    Res = "G|PrimaNeta|"
                Case "GASTOSEMISION", "GASTOSEMI", "GASTOS.EMI"
                    Res = "G|GastosEmi|"
                Case "GASTOSFRACCIONAMIENTO", "GASTOSFRAC", "GASTOS.FRAC"
                    Res = "G|GastosFrac|"
                Case "GASTOSBOMBEROS", "GASTOSBOMB", "GASTOS.BOMB"
                    Res = "G|GastosBomb|"
                Case "OTROSGASTOS", "GASTOSOTROS", "GASTOS.OTROS"
                    Res = "G|GastosOtros|"
                Case "IVA", "IMPUESTOS"
                    Res = "G|Iva|"
                Case "TOTAL", "PRIMATOTAL", "PRIMA.TOTAL", "PRIMA_TOTAL"
                    Res = "G|Total|"
                Case "PRIMA_BRUTA", "PRIMA.BRUTA", "PRIMABRUTA"
                    Res = "G|PrimaBruta|"
                Case "DESCUENTOS", "DESCUENTO", "VALOR.DESCUENTO"
                    Res = "G|ValorDescuento|"
                Case "FECHACANCELACION", "FECHA.CANCELACION", "FECHA_CANCELACION", "FECHACANCELA", "FECHA.CANCELA", "FECHA_CANCELA"
                    Res = "G|FechaCancelacion|"
            End Select

            'verificaremos beneficiarios
            If Res = "" Then
                If NombreColumna Like "NOMBREBENEFICIARIO*" Then Res = "N|NombreBeneficiario|"
                If NombreColumna Like "PARENTESCOBENEFICIARIO*" Then Res = "N|Parentesco|"
                If NombreColumna Like "FECHANACIMIENTOBENEFICIARIO*" Then Res = "N|FechaNacimiento|"
                If NombreColumna Like "PORCENTAJEBENEFICIARIO*" Then Res = "N|Porcentaje|"
            End If

            'verificaremos CESIONES
            If Res = "" Then
                If NombreColumna Like "NOMBRECESIONARIO*" Then Res = "S|Beneficiario|"
                If NombreColumna Like "FECHACESION*" Then Res = "S|FechaVigente|"
                If NombreColumna Like "SUMACESION*" Then Res = "S|SumaCedida|"
                If NombreColumna Like "NOTASCESION*" Then Res = "S|Observaciones|"
            End If

            If Res = "" Then
                Res = "||Columna se Omitirá"
            End If

        Catch ex As Exception
            Res = "||Columna se Omitirá"
        End Try
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
                res = CrearPoliza(Hoja, Fila, False)

                Call CrearBeneficiarios(Hoja, Fila, "0")
                Call CrearCesiones(Hoja, Fila, "0")

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

    Private Function CrearPoliza(ByRef Hoja As Object, ByVal Fila As Integer, ByVal Revision As Boolean) As String
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

        Dim VigenciaDesde As String = ""
        If ExisteCampo("VigenciaDesde") = True Then
            VigenciaDesde = ObtenerDatoArchivo(Hoja, Fila, "VigenciaDesde").Trim
            If VigenciaDesde = "" Then
                Res &= "Falta Vigencia Desde;"
            End If
        Else
            Res &= "Falta Vigencia Desde;"
        End If

        Dim VigenciaHasta As String = ""
        If ExisteCampo("VigenciaHasta") = True Then
            VigenciaHasta = ObtenerDatoArchivo(Hoja, Fila, "VigenciaHasta").Trim
            If VigenciaHasta = "" Then
                Res &= "Falta Vigencia Hasta;"
            End If
        Else
            Res &= "Falta Vigencia Hasta;"
        End If

        Dim ValorAsegurado As Double = 0
        If ExisteCampo("ValorAsegurado") = True Then
            ValorAsegurado = Val(ObtenerDatoArchivo(Hoja, Fila, "ValorAsegurado").Trim)
        End If
        Dim PrimaNeta As Double = 0
        If ExisteCampo("PrimaNeta") = True Then
            PrimaNeta = Val(ObtenerDatoArchivo(Hoja, Fila, "PrimaNeta").Trim)
        End If
        Dim GastosEmi As Double = 0
        If ExisteCampo("GastosEmi") = True Then
            GastosEmi = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosEmi").Trim)
        End If
        Dim GastosFrac As Double = 0
        If ExisteCampo("GastosFrac") = True Then
            GastosFrac = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosFrac").Trim)
        End If
        Dim GastosBomb As Double = 0
        If ExisteCampo("GastosBomb") = True Then
            GastosBomb = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosBomb").Trim)
        End If
        Dim GastosOtros As Double = 0
        If ExisteCampo("GastosOtros") = True Then
            GastosOtros = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosOtros").Trim)
        End If
        Dim Iva As Double = 0
        If ExisteCampo("Iva") = True Then
            Iva = Val(ObtenerDatoArchivo(Hoja, Fila, "Iva").Trim)
        End If
        Dim Total As Double = 0
        If ExisteCampo("Total") = True Then
            Total = Val(ObtenerDatoArchivo(Hoja, Fila, "Total").Trim)
        End If
        Dim ValorDescuento As Double = 0
        If ExisteCampo("ValorDescuento") = True Then
            ValorDescuento = Val(ObtenerDatoArchivo(Hoja, Fila, "ValorDescuento").Trim)
        End If
        Dim PrimaBruta As Double = 0
        If ExisteCampo("PrimaBruta") = True Then
            PrimaBruta = Val(ObtenerDatoArchivo(Hoja, Fila, "PrimaBruta").Trim)
        End If

        Dim FechaCancelacion As String = "", MotivoCancelacion As String = "", EstadoPoliza As String = "VIGENTE", EstadoCertificado As String = "VIGENTE"
        If ExisteCampo("FechaCancelacion") = True Then
            Try
                FechaCancelacion = ObtenerDatoArchivo(Hoja, Fila, "FechaCancelacion").Trim
                If FechaCancelacion <> "" Then
                    FechaCancelacion = CDate(FechaCancelacion).ToShortDateString
                End If
            Catch ex As Exception
                FechaCancelacion = ""
            End Try
            If FechaCancelacion <> "" Then
                MotivoCancelacion = "CANCELACION"
                EstadoPoliza = "CANCELADA"
                EstadoCertificado = "CANCELADO"
            End If
        End If

        If IdPoliza <> "" And IdProducto <> "" Then
            'verificamos si la poliza ya existe
            Dim ExistePol As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            IdPolizaActual = IdPoliza
            IdProductoActual = IdProducto
            If ExistePol > 0 Then
                Try

                    If Res = "" And Revision = False Then

                        StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                        sql = " update Polizas set "
                        sql &= " IdCliente = " & dbStr(IdCliente, 25)
                        sql &= ", NombreCliente = " & dbStr(NombreCliente, 150)
                        sql &= ", VigenciaDesde = " & dbFec(VigenciaDesde)
                        sql &= ", VigenciaHasta = " & dbFec(VigenciaHasta)
                        sql &= ", EstadoPoliza = " & dbStr(EstadoPoliza)
                        'sql &= ", NumVigencia = " & dbInt("1")
                        sql &= ", FechaCancelacion = " & dbFec(FechaCancelacion)
                        sql &= ", MotivoCancelacion = " & dbStr(MotivoCancelacion, 50)
                        sql &= " where IdPoliza = " & dbStr(IdPoliza, 25)
                        sql &= " and IdProducto = " & dbStr(IdProducto, 25)
                        StiGlobalConn.SQLExecute(sql)
                        RegistrarLog("M", "Polizas", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25))


                        'AHORA EL CERTIFICADO POR DEFAUL

                        Dim Certificado As String = "0"
                        'algunos datos obligatorios que se proponen si no se han especificado en el archivo

                        sql = "  update PolizasCertificados set "
                        sql &= " IdCliente = " & dbStr(IdCliente, 25)
                        sql &= ", NombreCliente = " & dbStr(NombreCliente, 150)
                        sql &= ", FechaInclusion = " & dbFec(VigenciaDesde)
                        sql &= ", VigenciaDesde = " & dbFec(VigenciaDesde)
                        sql &= ", VigenciaHasta = " & dbFec(VigenciaHasta)
                        sql &= ", ValorAsegurado = " & dbNum(ValorAsegurado)
                        sql &= ", PrimaNeta = " & dbNum(PrimaNeta)
                        sql &= ", GastosEmi = " & dbNum(GastosEmi)
                        sql &= ", GastosFrac = " & dbNum(GastosFrac)
                        sql &= ", GastosBomb = " & dbNum(GastosBomb)
                        sql &= ", GastosOtros = " & dbNum(GastosOtros)
                        sql &= ", Iva = " & dbNum(Iva)
                        sql &= ", Total = " & dbNum(Total)
                        sql &= ", EstadoCertificado = " & dbStr(EstadoCertificado)
                        sql &= ", FechaExclusion = " & dbFec(FechaCancelacion)
                        sql &= ", RazonExclusion = " & dbStr(MotivoCancelacion)
                        sql &= ", Deducible = " & dbStr("")
                        sql &= ", Participacion = " & dbStr("")
                        sql &= ", IdVendedor = " & dbStr("")
                        sql &= ", UsuarioModifica = " & dbStr(StiGlobalConn.User, 25)
                        sql &= ", FechaModifica = " & dbFec(Date.Now, "1")
                        sql &= ", PorceDescuento = " & dbNum("")
                        sql &= ", ValorDescuento = " & dbNum(ValorDescuento)
                        sql &= ", PrimaBruta = " & dbNum(PrimaBruta)
                        sql &= ", IdPlan = " & dbStr("")
                        sql &= " where IdPoliza = " & dbStr(IdPoliza, 25)
                        sql &= " and IdProducto = " & dbStr(IdProducto, 25)
                        sql &= " and IdCertificado = " & dbStr(Certificado, 25)
                        StiGlobalConn.SQLExecute(sql)

                        'grabaremos las coberturas en blanco
                        StiGlobalConn.SQLExecute("delete from PolizasCoberturas where IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(Certificado, 25))
                        Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset("select IdCobertura, AplicarDescuento from ProductosCoberturas where IdProducto = " & dbStr(IdProducto) & " order by IdCobertura").Tables(0)
                        Dim Filcob As DataRow
                        Dim SumaCob As Double = 0, PrimaCob As Double = 0
                        For Each Filcob In Coberturas.Rows
                            SumaCob = 0
                            If Val(dbData(Filcob, "IdCobertura")) = 1 Then
                                SumaCob = ValorAsegurado
                                PrimaCob = PrimaBruta
                            End If

                            sql = " insert into PolizasCoberturas"
                            sql &= " (IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, "
                            sql &= " Tasa, Deducible, Prima, PorceSuma, AplicarDescuento) values ("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(Certificado, 25) & C & dbInt(dbData(Filcob, "IdCobertura")) & C & dbNum(SumaCob) & C
                            sql &= dbNum("0") & C & dbStr("") & C & dbNum(PrimaCob) & C & dbNum("0") & C & dbStr(dbData(Filcob, "AplicarDescuento")) & ") "

                            StiGlobalConn.SQLExecute(sql)
                        Next

                        'los datos básico del producto
                        'Dim Bienes As DataTable = StiGlobalConn.ObtenerDataset("select IdBien, NombreBien from ProductosBienes where IdProducto = " & dbStr(IdProducto) & " order by IdBien").Tables(0)
                        'Dim FilBienes As DataRow
                        'For Each FilBienes In Bienes.Rows
                        '    sql = "  insert into PolizasBienes"
                        '    sql &= " (IdPoliza, IdProducto, IdCertificado,"
                        '    sql &= " IdBien, NombreBien, DescripcionBien) values("
                        '    sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(Certificado, 25) & C
                        '    sql &= dbInt(dbData(FilBienes, "IdBien")) & C & dbStr(dbData(FilBienes, "NombreBien"), 250) & C & dbStr("") & ")"
                        '    StiGlobalConn.SQLExecute(sql)
                        'Next

                        RegistrarLog("M", "PolizasCertificados", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(Certificado, 25))

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

                        sql = " insert into Polizas"
                        sql &= " (IdPoliza, IdProducto, IdCliente, NombreCliente, VigenciaDesde,"
                        sql &= " VigenciaHasta, EstadoPoliza, NumVigencia, FechaCancelacion, MotivoCancelacion) values("
                        sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 150) & C & dbFec(VigenciaDesde) & C
                        sql &= dbFec(VigenciaHasta) & C & dbStr(EstadoPoliza) & C & dbInt("1") & C & dbFec(FechaCancelacion) & C & dbStr(MotivoCancelacion, 50) & ")"
                        StiGlobalConn.SQLExecute(sql)

                        RegistrarLog("A", "Polizas", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25))


                        'AHORA EL CERTIFICADO POR DEFAUL

                        Dim Certificado As String = "0"


                        'algunos datos obligatorios que se proponen si no se han especificado en el archivo

                        sql = "  insert into PolizasCertificados "
                        sql &= " (IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion,"
                        sql &= " VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac,"
                        sql &= " GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion,"
                        sql &= " RazonExclusion, Deducible, Participacion, IdVendedor, UsuarioModifica, FechaModifica,"
                        sql &= " PorceDescuento, ValorDescuento, PrimaBruta, IdPlan) values ("

                        sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(Certificado, 25) & C & dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 150) & C & dbFec(VigenciaDesde) & C
                        sql &= dbFec(VigenciaDesde) & C & dbFec(VigenciaHasta) & C & dbNum(ValorAsegurado) & C & dbNum(PrimaNeta) & C & dbNum(GastosEmi) & C & dbNum(GastosFrac) & C
                        sql &= dbNum(GastosBomb) & C & dbNum(GastosOtros) & C & dbNum(Iva) & C & dbNum(Total) & C & dbStr(EstadoCertificado) & C & dbFec(FechaCancelacion) & C
                        sql &= dbStr(MotivoCancelacion) & C & dbStr("") & C & dbStr("") & C & dbStr("") & C & dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & C
                        sql &= dbNum("") & C & dbNum(ValorDescuento) & C & dbNum(PrimaBruta) & C & dbStr("") & ")"

                        StiGlobalConn.SQLExecute(sql)

                        'grabaremos las coberturas en blanco

                        Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset("select IdCobertura, AplicarDescuento from ProductosCoberturas where IdProducto = " & dbStr(IdProducto) & " order by IdCobertura").Tables(0)
                        Dim Filcob As DataRow
                        Dim SumaCob As Double = 0, PrimaCob As Double = 0
                        For Each Filcob In Coberturas.Rows
                            SumaCob = 0
                            If Val(dbData(Filcob, "IdCobertura")) = 1 Then
                                SumaCob = ValorAsegurado
                                PrimaCob = PrimaBruta
                            End If

                            sql = " insert into PolizasCoberturas"
                            sql &= " (IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, "
                            sql &= " Tasa, Deducible, Prima, PorceSuma, AplicarDescuento) values ("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(Certificado, 25) & C & dbInt(dbData(Filcob, "IdCobertura")) & C & dbNum(SumaCob) & C
                            sql &= dbNum("0") & C & dbStr("") & C & dbNum(PrimaCob) & C & dbNum("0") & C & dbStr(dbData(Filcob, "AplicarDescuento")) & ") "

                            StiGlobalConn.SQLExecute(sql)
                        Next

                        'los datos básico del producto
                        Dim Bienes As DataTable = StiGlobalConn.ObtenerDataset("select IdBien, NombreBien from ProductosBienes where IdProducto = " & dbStr(IdProducto) & " order by IdBien").Tables(0)
                        Dim FilBienes As DataRow
                        For Each FilBienes In Bienes.Rows
                            sql = "  insert into PolizasBienes"
                            sql &= " (IdPoliza, IdProducto, IdCertificado,"
                            sql &= " IdBien, NombreBien, DescripcionBien) values("
                            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(Certificado, 25) & C
                            sql &= dbInt(dbData(FilBienes, "IdBien")) & C & dbStr(dbData(FilBienes, "NombreBien"), 250) & C & dbStr("") & ")"
                            StiGlobalConn.SQLExecute(sql)
                        Next

                        RegistrarLog("A", "PolizasCertificados", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25) & " and IdCertificado = " & dbStr(Certificado, 25))

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

    Private Sub CrearBeneficiarios(ByRef Hoja As Object, ByVal Fila As Integer, ByVal IdCertificado As String)
        Try
            Dim sql As String = ""
            Dim IdBeneficiario As Integer = 0
            Dim NombreBeneficiario As String = "", Parentesco As String = "", FechaNacimiento As String = "", Porcentaje As String = ""
            StiGlobalConn.SQLExecute("delete from PolizasBeneficiarios where IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25))

            For NC As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If VistaImportar.GetRowCellValue(NC, "Tipo") = "N" And VistaImportar.GetRowCellValue(NC, "Campo") <> "" Then
                    If VistaImportar.GetRowCellValue(NC, "Campo") = "NombreBeneficiario" Then
                        If NombreBeneficiario <> "" Then
                            IdBeneficiario += 1
                            sql = "  insert into PolizasBeneficiarios"
                            sql &= " (IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario"
                            sql &= " ,Parentesco, FechaNacimiento, Porcentaje) values("
                            sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(IdCertificado, 25) & C & dbInt(IdBeneficiario) & C & dbStr(NombreBeneficiario, 250) & C
                            sql &= dbStr(Parentesco, 25) & C & dbFec(FechaNacimiento) & C & dbNum(Porcentaje) & ")"
                            StiGlobalConn.SQLExecute(sql)
                        End If
                        NombreBeneficiario = "" : Parentesco = "" : FechaNacimiento = "" : Porcentaje = ""
                    End If

                    Select Case VistaImportar.GetRowCellValue(NC, "Campo")
                        Case "NombreBeneficiario" : NombreBeneficiario = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "Parentesco"
                            Parentesco = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                            If Parentesco <> "" Then
                                Try
                                    Parentesco = StiGlobalConn.ObtenerDataset("select IdParentesco from Parentescos where Descripcion = " & dbStr(Parentesco)).Tables(0).Rows(0).Item(0)
                                Catch ex As Exception
                                    Parentesco = ""
                                End Try
                            End If

                        Case "FechaNacimiento" : FechaNacimiento = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "Porcentaje" : Porcentaje = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                    End Select
                End If
            Next

            If NombreBeneficiario <> "" Then
                IdBeneficiario += 1
                sql = "  insert into PolizasBeneficiarios"
                sql &= " (IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario"
                sql &= " ,Parentesco, FechaNacimiento, Porcentaje) values("
                sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(IdCertificado, 25) & C & dbInt(IdBeneficiario) & C & dbStr(NombreBeneficiario, 250) & C
                sql &= dbStr(Parentesco, 25) & C & dbFec(FechaNacimiento) & C & dbNum(Porcentaje) & ")"
                StiGlobalConn.SQLExecute(sql)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrearCesiones(ByRef Hoja As Object, ByVal Fila As Integer, ByVal IdCertificado As String)
        Try
            Dim sql As String = ""
            Dim IdCesion As Integer = 0
            Dim NombreCesion As String = "", FechaCesion As String = "", SumaCesion As Double = 0, NotasCesion As String = ""
            StiGlobalConn.SQLExecute("delete from PolizasCesiones where IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25))

            For NC As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If VistaImportar.GetRowCellValue(NC, "Tipo") = "S" And VistaImportar.GetRowCellValue(NC, "Campo") <> "" Then
                    If VistaImportar.GetRowCellValue(NC, "Campo") = "Beneficiario" Then
                        If NombreCesion <> "" Then
                            IdCesion += 1
                            sql = "  insert into PolizasCesiones"
                            sql &= " (IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario"
                            sql &= " ,FechaVigente, SumaCedida, Observaciones) values("
                            sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(IdCertificado, 25) & C & dbInt(IdCesion) & C & dbStr(NombreCesion, 250) & C
                            sql &= dbFec(FechaCesion) & C & dbNum(SumaCesion) & C & dbStr(NotasCesion, 250) & ")"
                            StiGlobalConn.SQLExecute(sql)
                        End If
                        NombreCesion = "" : FechaCesion = "" : SumaCesion = 0 : NotasCesion = ""
                    End If

                    Select Case VistaImportar.GetRowCellValue(NC, "Campo")
                        Case "Beneficiario" : NombreCesion = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "FechaVigente" : FechaCesion = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "SumaCedida" : SumaCesion = Val(Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna"))))
                        Case "Observaciones" : NotasCesion = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                    End Select
                End If
            Next

            If NombreCesion <> "" Then
                IdCesion += 1
                sql = "  insert into PolizasCesiones"
                sql &= " (IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario"
                sql &= " ,FechaVigente, SumaCedida, Observaciones) values("
                sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(IdCertificado, 25) & C & dbInt(IdCesion) & C & dbStr(NombreCesion, 250) & C
                sql &= dbFec(FechaCesion) & C & dbNum(SumaCesion) & C & dbStr(NotasCesion, 250) & ")"
                StiGlobalConn.SQLExecute(sql)
            End If

        Catch ex As Exception

        End Try
    End Sub

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
                res = CrearPoliza(Hoja, Fila, True)
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
                MsgBox("El archivo presenta error en los datos no todas las pólizas se cargarían, los errores los encontrará en el archivo que especificó.", MsgBoxStyle.Exclamation, "ERROR...")
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

End Class
