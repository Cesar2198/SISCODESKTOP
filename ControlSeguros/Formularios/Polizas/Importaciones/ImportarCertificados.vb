Imports Utilerias.Genericas

Public Class ImportarCertificados
    Dim dtArchivo As DataTable
    'la fila del encabezado.
    Dim FilEncabezado As Integer = 1
    Dim ColNota As Integer = 99

    Dim TasaBarra As Double = 0
    Dim ValorBarra As Double = 0

    Dim IdPolizaActual As String = ""
    Dim IdProductoActual As String = ""

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = " and p.MotivoCancelacion is null"
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select IdPoliza, IdProducto,IdCliente, NombreCliente, VigenciaDesde, VigenciaHasta "
                sql &= " from Polizas "
                sql &= " where IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))

                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtIdPoliza.Valor = dbData(FilPol, "IdPoliza")
                cboIdProducto.Valor = dbData(FilPol, "IdProducto")
                txtIdCliente.Valor = dbData(FilPol, "IdCliente")
                txtNombreCliente.Valor = dbData(FilPol, "NombreCliente")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
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

    Private Sub ImportarCertificados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()
        Call IniciarTabla()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "P" : FilaTD("Tipo") = "Póliza" : TD.Rows.Add(FilaTD)
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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

                DetalleCol = DeterminarColumna(ColNombre, cboIdProducto.Valor)

                FilArchivo("Tipo") = stiSplit(DetalleCol, "G0|1")
                FilArchivo("Campo") = stiSplit(DetalleCol, "G1|1")
                FilArchivo("Observacion") = stiSplit(DetalleCol, "G2|1")
                dtArchivo.Rows.Add(FilArchivo)

                ColNumero += 1
                ColNombre = Hoja.Cells(FilEncabezado, ColNumero).Value
            End While

            ColNota = ColNumero + 1

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

    Public Function DeterminarColumna(ByVal NombreColumna As String, ByVal IdProducto As String) As String
        ''retornamos Tipo|ColBaseDatos|Comentario
        Dim Res As String = ""
        Dim NombreColumnaOrig As String = NombreColumna
        Try
            NombreColumna = Replace(NombreColumna.Trim.ToUpper, " ", "")
            'basados en el nombre de la columna determinaremos el tipo
            Select Case NombreColumna
                '********SECCION GENERALES
                Case "POLIZA"
                    Res = "P|IdPoliza|"
                Case "ASEGURADORA"
                    Res = "P|IdAseguradora|"
                Case "PRODUCTO"
                    Res = "P|IdProducto|"
                Case "RAMO"
                    Res = "P|IdRamo|"
                Case "VIGENCIA.DESDE.POLIZA"
                    Res = "P|VigenciaDesdePol|"
                Case "VIGENCIA.HASTA.POLIZA"
                    Res = "P|VigenciaHastaPol|"
                Case "NIT.CONTRATANTE"
                    Res = "P|IdClientePol|"
                Case "NOMBRE.CONTRATANTE"
                    Res = "P|NombreClientePol|"
                
                Case "CERTIFICADO", "CERT."
                    Res = "G|IdCertificado|"
                Case "IDCLIENTE", "COD.CLIENTE", "COD_CLIENTE"
                    Res = "G|IdCliente|"
                Case "CLIENTE", "NOMBRECLIENTE", "NOMBREASEGURADO", "NOM.ASEGURADO", "ASEGURADO"
                    Res = "G|NombreCliente|"
                Case "FECHAINCLUSION", "FECHA.INCLUSION", "FECHAINGRESO", "FECHA.INGRESO"
                    Res = "G|FechaInclusion|"
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
                Case "DESCUENTOS", "DESCUENTO"
                    Res = "G|ValorDescuento|"
                Case "PORCE.DESCUENTO", "PORCE_DESCUENTO", "PORCEDESCUENTO"
                    Res = "G|PorceDescuento|"
                Case "PRIMABRUTA", "PRIMA.BRUTA", "PRIMA_BRUTA"
                    Res = "G|PrimaBruta|"
                Case "DEDUCIBLE"
                    Res = "G|Deducible|"
                Case "PARTICIPACION"
                    Res = "G|Participacion|"

            End Select

            'si no se ha determinado columna se verificará si no son coberturas
            If Res = "" Then
                If NombreColumna Like "SUMAR*" Or NombreColumna Like "SUMA.R*" Then
                    Res = "C|SumaAsegurada|"
                End If
                If NombreColumna Like "TASAR*" Or NombreColumna Like "TASA.R*" Then
                    Res = "C|Tasa|"
                End If
                If NombreColumna Like "DEDUCIBLER*" Or NombreColumna Like "DED.R*" Or NombreColumna Like "DEDUCIBLE.R*" Or NombreColumna = "DEDUCIBLE" Then
                    Res = "C|Deducible|"
                End If
                If NombreColumna Like "PRIMAR*" Or NombreColumna Like "PRIMA.R*" Then
                    Res = "C|Prima|"
                End If
                If NombreColumna Like "PRIMAANUALR*" Or NombreColumna Like "PRIMA.ANUAL.R*" Then
                    Res = "C|PrimaAnual|"
                End If
                If NombreColumna Like "PORCER*" Or NombreColumna Like "PORCE.R*" Or NombreColumna Like "PORCENTAJER*" Or NombreColumna Like "PORCENTAJE.R*" Then
                    Res = "C|PorceSuma|"
                End If
            End If

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

            'si no se ha determinado columna se verificará si no son bienes
            Dim Campo As String = ""
            If Res = "" Then
                ''buscamos en la descripcion del producto
                If IdProducto <> "" Then
                    Campo = ""
                    Try
                        Campo = StiGlobalConn.ObtenerDataset("select NombreBien from ProductosBienes where idproducto = " & dbStr(IdProducto) & " and NombreBien = " & dbStr(NombreColumna)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        Campo = ""
                    End Try
                    If Campo = "" Then
                        'buscamos por similar
                        Try
                            Campo = StiGlobalConn.ObtenerDataset("select NombreBien from ProductosBienes where idproducto = " & dbStr(IdProducto) & " and NombreBien like " & dbStr("%" & NombreColumna & "%")).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            Campo = ""
                        End Try
                    End If
                    If Campo = "" Then
                        'buscamos por original
                        Try
                            Campo = StiGlobalConn.ObtenerDataset("select NombreBien from ProductosBienes where idproducto = " & dbStr(IdProducto) & " and NombreBien = " & dbStr(NombreColumnaOrig)).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            Campo = ""
                        End Try
                    End If

                    If Campo <> "" Then
                        Res = "B|" & Campo & "|"
                    End If
                End If
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
        If txtIdPoliza.Text = "" And ExisteCampo("IdPoliza") = False Then
            MsgBox("Debe especificar la Póliza, ya sea en la pantalla o en el archivo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If cboIdProducto.Text = "" And ExisteCampo("IdProducto") = False Then
            MsgBox("Debe especificar el Producto, ya sea en la pantalla o en el archvio.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If txtNombreCliente.Text = "" And ExisteCampo("NombreClientePol") = False Then
            MsgBox("Debe especificar el Nombre del cliente, en pantalla o en el archivo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
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
        Dim msgReg As String = ""

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

            'si la póliza no existe la creamos
            If txtIdPoliza.Valor <> "" And cboIdProducto.Valor <> "" And txtIdCliente.Valor <> "" And Me.txtNombreCliente.Valor <> "" Then
                IdPolizaActual = txtIdPoliza.Valor
                IdProductoActual = cboIdProducto.Valor
                Existe = StiGlobalConn.ObtenerDataset("select count(*) from Polizas where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                If Existe = 0 Then
                    Call CrearPoliza()
                End If
            End If

            Dim IdCerttificado As String = ""
            FilNombre = Hoja.Cells(Fila, 1).Value
            While FilNombre <> ""
                msgReg = ""
                If Not (txtIdPoliza.Valor <> "" And cboIdProducto.Valor <> "" And txtIdCliente.Valor <> "" And Me.txtNombreCliente.Valor <> "") And ExisteCampo("IdPoliza") = True Then
                    msgReg &= CrearPolizaArchivo(Hoja, Fila)
                End If

                IdCerttificado = CrearCertificado(Hoja, Fila)
                Call CrearCoberturas(Hoja, Fila, IdCerttificado)
                Call CrearBienes(Hoja, Fila, IdCerttificado)
                Call CrearBeneficiarios(Hoja, Fila, IdCerttificado)
                Call CrearCesiones(Hoja, Fila, IdCerttificado)

                If msgReg <> "" Then Hoja.Cells(Fila, ColNota).Value = msgReg

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
            
            MsgBox("La operación ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")

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

    Private Sub CrearPoliza()
        'basados en información general creamos el encabezado de la póliza
        Dim sql As String = ""

        sql = " insert into Polizas"
        sql &= " (IdPoliza, IdProducto, IdCliente, NombreCliente, VigenciaDesde,"
        sql &= " VigenciaHasta, EstadoPoliza, NumVigencia) values("
        sql &= dbStr(txtIdPoliza.Valor, 25) & C & dbStr(cboIdProducto.Valor, 25) & C & dbStr(txtIdCliente.Valor, 25) & C & dbStr(txtNombreCliente.Valor, 150) & C & dbFec(Date.Today) & C
        sql &= dbFec(Date.Today.AddYears(1)) & C & dbStr("VIGENTE") & C & dbInt("1") & ")"
        StiGlobalConn.SQLExecute(sql)

        RegistrarLog("A", "Polizas", "IdPoliza = " & dbStr(txtIdPoliza.Valor, 25) & " and IdProducto = " & dbStr(cboIdProducto.Valor, 25))

    End Sub

    Private Function CrearPolizaArchivo(ByRef Hoja As Object, ByVal Fila As Integer) As String
        'basados en información general creamos el encabezado de la póliza
        Dim sql As String = "", res As String = ""

        Dim IdPoliza As String = ""
        Dim IdAseguradora As String = ""
        Dim IdProducto As String = ""
        Dim IdRamo As String = ""
        Dim IdCliente As String = ""
        Dim NombreCliente As String = ""
        Dim VigenciaDesde As String = ""
        Dim VigenciaHasta As String = ""
        Dim Estado As String = "VIGENTE"

        If ExisteCampo("IdPoliza") = True Then
            IdPoliza = ObtenerDatoArchivo(Hoja, Fila, "IdPoliza").Trim
            If IdPoliza = "" Then
                res &= "Falta Número Póliza;"
            End If
        Else
            res &= "Falta Número Póliza;"
        End If

        If ExisteCampo("IdAseguradora") = True Then
            IdAseguradora = DeterminarAseguradora(ObtenerDatoArchivo(Hoja, Fila, "IdAseguradora"))
            If IdAseguradora = "" Then
                res &= "No se encuentra Aseguradora;"
            Else
                If ExisteCampo("IdProducto") = True Or ExisteCampo("IdRamo") = True Then
                    IdProducto = DeterminarProducto(IdAseguradora, ObtenerDatoArchivo(Hoja, Fila, "IdProducto"), ObtenerDatoArchivo(Hoja, Fila, "IdRamo"))
                    If IdProducto = "" Then
                        res &= "No se encuentra el Producto;"
                    End If
                End If
            End If
        Else
            res &= "Falta Aseguradora;"
        End If

        If ExisteCampo("IdClientePol") = True Then
            IdCliente = ObtenerDatoArchivo(Hoja, Fila, "IdClientePol").Trim
        End If

        If ExisteCampo("NombreClientePol") = True Then
            NombreCliente = ObtenerDatoArchivo(Hoja, Fila, "NombreClientePol").Trim
            If NombreCliente = "" Then
                res &= "Falta Nombre Cliente;"
            End If
        Else
            res &= "Falta Nombre Cliente;"
        End If

        If ExisteCampo("VigenciaDesdePol") = True Then
            VigenciaDesde = ObtenerDatoArchivo(Hoja, Fila, "VigenciaDesdePol").Trim
            If VigenciaDesde = "" Then
                res &= "Falta Vigencia Desde;"
            End If
        Else
            res &= "Falta Vigencia Desde;"
        End If

        If ExisteCampo("VigenciaHastaPol") = True Then
            VigenciaHasta = ObtenerDatoArchivo(Hoja, Fila, "VigenciaHastaPol").Trim
            If VigenciaHasta = "" Then
                res &= "Falta Vigencia Hasta;"
            End If
        Else
            res &= "Falta Vigencia Hasta;"
        End If

        IdPolizaActual = IdPoliza
        IdProductoActual = IdProducto

        Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Polizas where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
        If Existe = 0 Then
            sql = " insert into Polizas"
            sql &= " (IdPoliza, IdProducto, IdCliente, NombreCliente, VigenciaDesde,"
            sql &= " VigenciaHasta, EstadoPoliza, NumVigencia) values("
            sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 150) & C & dbFec(VigenciaDesde) & C
            sql &= dbFec(VigenciaHasta) & C & dbStr(Estado) & C & dbInt("1") & ")"
            StiGlobalConn.SQLExecute(sql)

            RegistrarLog("A", "Polizas", "IdPoliza = " & dbStr(IdPoliza, 25) & " and IdProducto = " & dbStr(IdProducto, 25))
        End If

        Return res
    End Function

    Private Function CrearCertificado(ByRef Hoja As Object, ByVal Fila As Integer) As String
        Dim sql As String = ""
        Dim Certificado As String = ""
        Dim VigenciaDesde As String = "", VigenciaHasta As String = ""

        'algunos datos obligatorios que se proponen si no se han especificado en el archivo
        If ExisteCampo("IdCertificado") = False Then
            'obtendremos un nuevo número de certificado
            Certificado = ObtenerIDCertificado()
        Else
            Certificado = ObtenerDatoArchivo(Hoja, Fila, "IdCertificado")
        End If
        If ExisteCampo("VigenciaDesde") = False Then
            VigenciaDesde = StiGlobalConn.ObtenerDataset("select VigenciaDesde from Polizas where IdPoliza = " & dbStr(IdPolizaActual) & " and IdProducto = " & dbStr(IdProductoActual)).Tables(0).Rows(0).Item(0)
        Else
            VigenciaDesde = ObtenerDatoArchivo(Hoja, Fila, "VigenciaDesde")
        End If
        If ExisteCampo("VigenciaHasta") = False Then
            VigenciaHasta = StiGlobalConn.ObtenerDataset("select VigenciaHasta from Polizas where IdPoliza = " & dbStr(IdPolizaActual) & " and IdProducto = " & dbStr(IdProductoActual)).Tables(0).Rows(0).Item(0)
        Else
            VigenciaHasta = ObtenerDatoArchivo(Hoja, Fila, "VigenciaHasta")
        End If

        Dim PorceIva As Double = clSeguros.ObtenerDBParametros("Porce.Iva")
        Dim TipoCliente As String = ""
        Dim TipoProducto As String = ""
        Try
            TipoCliente = StiGlobalConn.ObtenerDataset("select idtipocliente from clientes where idcliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            TipoCliente = ""
        End Try
        If TipoCliente = "GU" Or TipoCliente = "JE" Then
            ''no se cobra iva al gobierno o empresas exentas
            ''tambien las facturas de exportación.
            PorceIva = 0
        End If
        Try
            TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(IdProductoActual)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            TipoProducto = ""
        End Try

        ''trataremos de calcular las primas si no nos la proporcionan
        Dim PrimaBruta As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "PrimaBruta"))
        Dim PorceDescuento As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "PorceDescuento"))
        Dim ValorDescuento As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "ValorDescuento"))
        'calcularemos el valor del descuento
        If ValorDescuento = 0 And PorceDescuento > 0 Then
            ValorDescuento = Math.Round(PrimaBruta * (PorceDescuento / 100), 2)
        End If
        Dim PrimaNeta As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "PrimaNeta"))
        If PrimaNeta = 0 Then
            PrimaNeta = PrimaBruta - ValorDescuento
        End If
        Dim GastosE As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosEmi"))
        Dim GastosF As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosFrac"))
        Dim GastosB As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosBomb"))
        Dim GastosO As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "GastosOtros"))
        Dim Iva As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "Iva"))
        If Iva = 0 Then
            If TipoProducto = "VIDA" Then
                Iva = Math.Round((GastosE + GastosF + GastosB + GastosO) * (PorceIva / 100), 2)
            Else
                Iva = Math.Round((PrimaNeta + GastosE + GastosF + GastosB + GastosO) * (PorceIva / 100), 2)
            End If
        End If
        Dim Total As Double = Val(ObtenerDatoArchivo(Hoja, Fila, "Total"))
        If Total = 0 Then
            Total = PrimaNeta + GastosE + GastosF + GastosB + GastosO + Iva
        End If

        Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from PolizasCertificados where IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(Certificado, 25)).Tables(0).Rows(0).Item(0)

        If Existe = 0 Then
            sql = "  insert into PolizasCertificados "
            sql &= " (IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion,"
            sql &= " VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac,"
            sql &= " GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion,"
            sql &= " RazonExclusion, Deducible, Participacion, IdVendedor, UsuarioModifica, FechaModifica,"
            sql &= " PorceDescuento, ValorDescuento, PrimaBruta, IdPlan) values ("

            sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(Certificado, 25) & C & dbStr(ObtenerDatoArchivo(Hoja, Fila, "IdCliente"), 25) & C & dbStr(ObtenerDatoArchivo(Hoja, Fila, "NombreCliente"), 150) & C & dbFec(ObtenerDatoArchivo(Hoja, Fila, "FechaInclusion")) & C
            sql &= dbFec(VigenciaDesde) & C & dbFec(VigenciaHasta) & C & dbNum(ObtenerDatoArchivo(Hoja, Fila, "ValorAsegurado")) & C & dbNum(PrimaNeta) & C & dbNum(GastosE) & C & dbNum(GastosF) & C
            sql &= dbNum(GastosB) & C & dbNum(GastosO) & C & dbNum(Iva) & C & dbNum(Total) & C & dbStr("VIGENTE") & C & dbFec(ObtenerDatoArchivo(Hoja, Fila, "FechaExclusion")) & C
            sql &= dbStr(ObtenerDatoArchivo(Hoja, Fila, "RazonExclusion"), 50) & C & dbStr(ObtenerDatoArchivo(Hoja, Fila, "Deducible"), 50) & C & dbStr(ObtenerDatoArchivo(Hoja, Fila, "Participacion"), 50) & C & dbStr(ObtenerDatoArchivo(Hoja, Fila, "IdVendedor"), 25) & C & dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & C
            sql &= dbNum(PorceDescuento) & C & dbNum(ValorDescuento) & C & dbNum(PrimaBruta) & C & dbStr(ObtenerDatoArchivo(Hoja, Fila, "IdPlan"), 25) & ")"

            RegistrarLog("A", "PolizasCertificados", "IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(Certificado, 25))

            StiGlobalConn.SQLExecute(sql)
        Else
            sql = "  update PolizasCertificados set "
            sql &= "  IdCliente = " & dbStr(ObtenerDatoArchivo(Hoja, Fila, "IdCliente"), 25)
            sql &= " , NombreCliente = " & dbStr(ObtenerDatoArchivo(Hoja, Fila, "NombreCliente"), 150)
            sql &= " , FechaInclusion = " & dbFec(ObtenerDatoArchivo(Hoja, Fila, "FechaInclusion"))
            sql &= " , VigenciaDesde = " & dbFec(VigenciaDesde)
            sql &= " , VigenciaHasta = " & dbFec(VigenciaHasta)
            sql &= " , ValorAsegurado = " & dbNum(ObtenerDatoArchivo(Hoja, Fila, "ValorAsegurado"))
            sql &= " , PrimaNeta = " & dbNum(PrimaNeta)
            sql &= " , GastosEmi = " & dbNum(GastosE)
            sql &= " , GastosFrac = " & dbNum(GastosF)
            sql &= " , GastosBomb = " & dbNum(GastosB)
            sql &= " , GastosOtros = " & dbNum(GastosO)
            sql &= " , Iva = " & dbNum(Iva)
            sql &= " , Total = " & dbNum(Total)
            sql &= " , EstadoCertificado = " & dbStr("VIGENTE")
            sql &= " , FechaExclusion = " & dbFec(ObtenerDatoArchivo(Hoja, Fila, "FechaExclusion"))
            sql &= " , RazonExclusion = " & dbStr(ObtenerDatoArchivo(Hoja, Fila, "RazonExclusion"), 50)
            sql &= " , Deducible = " & dbStr(ObtenerDatoArchivo(Hoja, Fila, "Deducible"), 50)
            sql &= " , Participacion = " & dbStr(ObtenerDatoArchivo(Hoja, Fila, "Participacion"), 50)
            sql &= " , UsuarioModifica = " & dbStr(StiGlobalConn.User, 25)
            sql &= " , FechaModifica = " & dbFec(Date.Now, "1")
            sql &= " , PorceDescuento = " & dbNum(PorceDescuento)
            sql &= " , ValorDescuento = " & dbNum(ValorDescuento)
            sql &= " , PrimaBruta = " & dbNum(PrimaBruta)
            sql &= " where IdPoliza = " & dbStr(IdPolizaActual, 25)
            sql &= " and IdProducto = " & dbStr(IdProductoActual, 25)
            sql &= " and IdCertificado = " & dbStr(Certificado, 25)

            RegistrarLog("M", "PolizasCertificados", "IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(Certificado, 25))

            StiGlobalConn.SQLExecute(sql)
        End If

        Return Certificado
    End Function

    Private Function ObtenerIDCertificado() As Integer
        Dim IdCert As Integer = -1
        'Para la póliza y producto obtenermos el siguiente certificado
        Dim Certificados As DataTable = StiGlobalConn.ObtenerDataset("select IdCertificado from PolizasCertificados where IdPoliza = " & dbStr(IdPolizaActual) & " and IdProducto = " & dbStr(IdProductoActual) & " order by IdCertificado").Tables(0)
        Dim FilCert As DataRow
        For Each FilCert In Certificados.Rows
            Try
                If IsNumeric(dbData(FilCert, "IdCertificado")) = True Then
                    If Val(dbData(FilCert, "IdCertificado")) > IdCert Then
                        IdCert = CInt(dbData(FilCert, "IdCertificado"))
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
        IdCert += 1
        Return IdCert
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
        Return res
    End Function

    Private Sub CrearCoberturas(ByRef Hoja As Object, ByVal Fila As Integer, ByVal IdCertificado As String)
        'lo que haremos aqui es ingresar las coberturas del producto, pero si hay datos en el archivo se incluyen
        Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset("select IdCobertura, AplicarDescuento from ProductosCoberturas where IdProducto = " & dbStr(IdProductoActual) & " order by IdCobertura").Tables(0)
        Dim Filcob As DataRow
        Dim sql As String = ""

        Dim Suma As String = ""
        Dim Tasa As String = ""
        Dim Deducible As String = ""
        Dim Prima As String = ""
        Dim Porce As String = ""
        Dim ColDato As Integer
        Dim PrimaAnual As String = ""

        StiGlobalConn.SQLExecute("delete from PolizasCoberturas where IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25))

        For Each Filcob In Coberturas.Rows

            'buscaremos datos de coberturas en archivo de excel
            'Suma
            ColDato = ExisteColumna("SUMAR" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("SUMA.R" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 And Val(dbData(Filcob, "IdCobertura")) = 1 Then ColDato = ObtenerColCampo("SumaAsegurada")
            If ColDato > 0 Then
                Suma = ObtenerDatoArchivo(Hoja, Fila, ColDato)
            Else
                Suma = "0"
            End If

            'Tasa
            ColDato = ExisteColumna("TASAR" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("TASA.R" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 And Val(dbData(Filcob, "IdCobertura")) = 1 Then ColDato = ObtenerColCampo("Tasa")
            If ColDato > 0 Then
                Tasa = ObtenerDatoArchivo(Hoja, Fila, ColDato)
            Else
                Tasa = "0"
            End If

            'Deducible
            ' Like "*" Or NombreColumna = "" Then
            ColDato = ExisteColumna("DEDUCIBLER" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("DED.R" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("DEDUCIBLE.R" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 And Val(dbData(Filcob, "IdCobertura")) = 1 Then ColDato = ObtenerColCampo("DEDUCIBLE")
            If ColDato > 0 Then
                Deducible = ObtenerDatoArchivo(Hoja, Fila, ColDato)
            Else
                Deducible = ""
            End If

            'Prima
            ColDato = ExisteColumna("PRIMAR" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("PRIMA.R" & dbData(Filcob, "IdCobertura"))
            If ColDato > 0 Then
                Prima = ObtenerDatoArchivo(Hoja, Fila, ColDato)
            Else
                Prima = "0"
            End If

            'prima anual
            ColDato = ExisteColumna("PRIMAANUALR" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("PRIMA.ANUAL.R" & dbData(Filcob, "IdCobertura"))
            If ColDato > 0 Then
                PrimaAnual = ObtenerDatoArchivo(Hoja, Fila, ColDato)
            Else
                PrimaAnual = "0"
            End If

            'Porce
            ColDato = ExisteColumna("PORCER" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("PORCE.R" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("PORCENTAJER" & dbData(Filcob, "IdCobertura"))
            If ColDato = -1 Then ColDato = ExisteColumna("PORCENTAJE.R" & dbData(Filcob, "IdCobertura"))
            If ColDato > 0 Then
                Porce = ObtenerDatoArchivo(Hoja, Fila, ColDato)
            Else
                Porce = "0"
            End If

            sql = " insert into PolizasCoberturas"
            sql &= " (IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, "
            sql &= " Tasa, Deducible, Prima, PorceSuma, AplicarDescuento, PrimaAnual) values ("
            sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(IdCertificado, 25) & C & dbInt(dbData(Filcob, "IdCobertura")) & C & dbNum(Suma) & C
            sql &= dbNum(Tasa) & C & dbStr(Deducible) & C & dbNum(Prima) & C & dbNum(Porce) & C & dbStr(dbData(Filcob, "AplicarDescuento")) & C & dbNum(PrimaAnual) & ") "

            StiGlobalConn.SQLExecute(sql)
        Next
    End Sub

    Private Sub CrearBienes(ByRef Hoja As Object, ByVal Fila As Integer, ByVal IdCertificado As String)
        'Para los bienes se ingresarán en el orden de aparición de las columnas del archivos
        Dim sql As String = ""
        Dim IdBien As Integer = 0
        Dim Valor As String = ""
        StiGlobalConn.SQLExecute("delete from PolizasBienes where IdPoliza = " & dbStr(IdPolizaActual, 25) & " and IdProducto = " & dbStr(IdProductoActual, 25) & " and IdCertificado = " & dbStr(IdCertificado, 25))
        For NC As Integer = 0 To Me.VistaImportar.DataRowCount - 1
            If VistaImportar.GetRowCellValue(NC, "Tipo") = "B" And VistaImportar.GetRowCellValue(NC, "Campo") <> "" Then
                Try
                    Valor = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna"))).Trim
                    If Valor <> "" Then
                        IdBien += 1
                        sql = "  insert into PolizasBienes"
                        sql &= " (IdPoliza, IdProducto, IdCertificado,"
                        sql &= " IdBien, NombreBien, DescripcionBien) values("
                        sql &= dbStr(IdPolizaActual, 25) & C & dbStr(IdProductoActual, 25) & C & dbStr(IdCertificado, 25) & C
                        sql &= dbInt(IdBien) & C & dbStr(VistaImportar.GetRowCellValue(NC, "Campo"), 250) & C & dbStr(Valor) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    End If
                Catch ex As Exception

                End Try
            End If
        Next
    End Sub

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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Me.cboIdProducto.Valor = "" Then
            MsgBox("Debe especificar el producto sobre el que desea generar el modelo de archivo de carga.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

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
            Hoja.Cells(Fila, 3).Value = "PRODUCTO"
            Hoja.Cells(Fila, 4).Value = "RAMO"
            Hoja.Cells(Fila, 5).Value = "VIGENCIA.DESDE.POLIZA"
            Hoja.Cells(Fila, 6).Value = "VIGENCIA.HASTA.POLIZA"
            Hoja.Cells(Fila, 7).Value = "NIT.CONTRATANTE"
            Hoja.Cells(Fila, 8).Value = "NOMBRE.CONTRATANTE"

            Hoja.Cells(Fila, 9).Value = "CERTIFICADO"
            Hoja.Cells(Fila, 10).Value = "COD.CLIENTE"
            Hoja.Cells(Fila, 11).Value = "NOMBRE CLIENTE"
            Hoja.Cells(Fila, 12).Value = "FECHA.INCLUSION"
            Hoja.Cells(Fila, 13).Value = "VIGENCIA.DESDE"
            Hoja.Cells(Fila, 14).Value = "VIGENCIA.HASTA"
            Hoja.Cells(Fila, 15).Value = "SUMA ASEGURADA"
            Hoja.Cells(Fila, 16).Value = "PRIMA BRUTA"
            Hoja.Cells(Fila, 17).Value = "PORCE.DESCUENTO"
            Hoja.Cells(Fila, 18).Value = "DESCUENTOS"
            Hoja.Cells(Fila, 19).Value = "PRIMA NETA"
            Hoja.Cells(Fila, 20).Value = "GASTOS EMISION"
            Hoja.Cells(Fila, 21).Value = "GASTOS FRACCIONAMIENTO"
            Hoja.Cells(Fila, 22).Value = "GASTOS BOMBEROS"
            Hoja.Cells(Fila, 23).Value = "OTROS GASTOS"
            Hoja.Cells(Fila, 24).Value = "IMPUESTOS"
            Hoja.Cells(Fila, 25).Value = "PRIMA TOTAL"
            Hoja.Cells(Fila, 26).Value = "DEDUCIBLE"
            Hoja.Cells(Fila, 27).Value = "PARTICIPACION"

            Col = 27

            'Coberturas
            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset("select * from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdCobertura").Tables(0)
            Dim FilCob As DataRow
            For Each FilCob In dtCoberturas.Rows
                Col += 1 : Hoja.Cells(Fila, Col).Value = "SUMA R" & dbData(FilCob, "IdCobertura")
                Col += 1 : Hoja.Cells(Fila, Col).Value = "TASA R" & dbData(FilCob, "IdCobertura")
                Col += 1 : Hoja.Cells(Fila, Col).Value = "DEDUCIBLE R" & dbData(FilCob, "IdCobertura")
                Col += 1 : Hoja.Cells(Fila, Col).Value = "PRIMA R" & dbData(FilCob, "IdCobertura")
                Col += 1 : Hoja.Cells(Fila, Col).Value = "PORCE R" & dbData(FilCob, "IdCobertura")
                Col += 1 : Hoja.Cells(Fila, Col).Value = "PRIMA ANUAL R" & dbData(FilCob, "IdCobertura")
            Next

            'Bienes
            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset("select * from ProductosBienes where IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdBien").Tables(0)
            Dim FilBien As DataRow
            For Each FilBien In dtBienes.Rows
                Col += 1 : Hoja.Cells(Fila, Col).Value = dbData(FilBien, "NombreBien")
            Next

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

End Class

