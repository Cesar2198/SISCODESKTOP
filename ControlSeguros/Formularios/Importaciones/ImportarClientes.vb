Imports Utilerias.Genericas

Public Class ImportarClientes
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

    Private Sub ImportarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IniciarTabla()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "G" : FilaTD("Tipo") = "Datos Generales" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "C" : FilaTD("Tipo") = "Contactos" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "P" : FilaTD("Tipo") = "Personalizado" : TD.Rows.Add(FilaTD)

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
            res = "Error al analizar el archivo:" & vbCrLf & ex.Message
        End Try
        Return res
    End Function

    Public Function DeterminarColumna(ByVal NombreColumna As String) As String
        ''retornamos Tipo|ColBaseDatos|Comentario
        Dim Res As String = "", ColOrig As String = NombreColumna
        Try
            NombreColumna = Replace(NombreColumna.Trim.ToUpper, " ", "")
            'basados en el nombre de la columna determinaremos el tipo
            Select Case NombreColumna
                '********SECCION GENERALES
                Case "IDCLIENTE", "COD.CLIENTE", "COD_CLIENTE"
                    Res = "G|IdCliente|"
                Case "CLIENTE", "NOMBRECLIENTE", "NOMBREASEGURADO", "NOM.ASEGURADO", "ASEGURADO"
                    Res = "G|NombreCliente|"
                Case "DUI", "D.U.I."
                    Res = "G|Dui|"
                Case "REGISTROFISCAL", "REGISTRO.FISCAL"
                    Res = "G|RegistroFiscal|"
                Case "GIRO", "ACTIVIDADECONOMICA"
                    Res = "G|Giro|"
                Case "FECHANACIMIENTO", "FECHA.NACIMIENTO"
                    Res = "G|FechaNacimiento|"
                Case "EMAIL", "CORREOELECTRONICO"
                    Res = "G|Email|"
                Case "FAX"
                    Res = "G|Fax|"
                Case "TIPOCLIENTE"
                    Res = "G|IdTipoCliente|"
                Case "LUGARTRABAJO"
                    Res = "G|LugarTrabajo|"

                Case "FECHAVINCULACION"
                    Res = "G|FechaVinculacion|"
                Case "TARJETACREDITO"
                    Res = "G|NumeroTarjeta|"
                Case "VENCIMIENTOTARJETA"
                    Res = "G|VencimientoTarjeta|"
                Case "FORMADEPAGO", "FORMAPAGO"
                    Res = "G|IdTipoPago|"
                Case "BANCOCLIENTE", "BANCO"
                    Res = "G|IdBanco|"
                Case "EJECUTIVODECUENTA"
                    Res = "G|EjecutivoCta|"




                Case "NOMBRECONTACTO", "CONTACTO", "NOMBRE.CONTACTO"
                    Res = "C|Nombre|"
                Case "TELEFONOCONTACTO", "TELEFONO.CONTACTO"
                    Res = "C|Telefono|"
                Case "DIRECCIONCONTACTO", "DIRECCION.CONTACTO"
                    Res = "C|Direccion|"
                Case "CIUDADCONTACTO", "CIUDAD.CONTACTO"
                    Res = "C|Ciudad|"
                Case "CARGOCONTACTO", "CARGO.CONTACTO"
                    Res = "C|Cargo|"
                Case "EMAILCONTACTO", "EMAIL.CONTACTO"
                    Res = "C|EMail|"
                Case "FECHANACIMIENTOCONTACTO", "FECHA.NACIMIENTO.CONTACTO"
                    Res = "C|FechaNacimiento|"
            End Select

            If Res = "" Then
                Res = "P|" & ColOrig & "|"
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

            Hoja.Cells(Fila, 1).Value = "COD.CLIENTE"
            Hoja.Cells(Fila, 2).Value = "NOMBRE CLIENTE"
            Hoja.Cells(Fila, 3).Value = "DUI"
            Hoja.Cells(Fila, 4).Value = "REGISTRO.FISCAL"
            Hoja.Cells(Fila, 5).Value = "GIRO"
            Hoja.Cells(Fila, 6).Value = "FECHA NACIMIENTO"
            Hoja.Cells(Fila, 7).Value = "EMAIL"
            Hoja.Cells(Fila, 8).Value = "FAX"
            Hoja.Cells(Fila, 9).Value = "TIPO CLIENTE"
            Hoja.Cells(Fila, 10).Value = "LUGAR TRABAJO"

            Hoja.Cells(Fila, 11).Value = "FECHA VINCULACION"
            Hoja.Cells(Fila, 12).Value = "TARJETA CREDITO"
            Hoja.Cells(Fila, 13).Value = "VENCIMIENTO TARJETA"
            Hoja.Cells(Fila, 14).Value = "FORMA DE PAGO"
            Hoja.Cells(Fila, 15).Value = "BANCO CLIENTE"
            Hoja.Cells(Fila, 16).Value = "EJECUTIVO DE CUENTA"

            Col = 16

            Select Case GlobalCodCliente
                Case "CVD1509"
                    Col += 1 : Hoja.Cells(Fila, Col).Value = "NIT EMPLEADOR"
                    Col += 1 : Hoja.Cells(Fila, Col).Value = "IBC"
                    Col += 1 : Hoja.Cells(Fila, Col).Value = "AFP ORIGEN"
                    Col += 1 : Hoja.Cells(Fila, Col).Value = "NUP"
            End Select

            ' Pueden ser varios contactos en este orden
            Col += 1 : Hoja.Cells(Fila, Col).Value = "NOMBRE CONTACTO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "TELEFONO CONTACTO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "DIRECCION CONTACTO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "CIUDAD CONTACTO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "CARGO CONTACTO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "EMAIL CONTACTO"
            Col += 1 : Hoja.Cells(Fila, Col).Value = "FECHA NACIMIENTO CONTACTO"
            
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
                'CREAMOS AL CLIENTE
                res = CrearCliente(Hoja, Fila, True)
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
                MsgBox("El archivo presenta error en los datos no todas los clientes se cargarían, los errores los encontrará en el archivo que especificó.", MsgBoxStyle.Exclamation, "ERROR...")
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

    Private Function CrearCliente(ByRef Hoja As Object, ByVal Fila As Integer, ByVal Revision As Boolean) As String
        'basados en información general creamos el encabezado de la póliza
        Dim Res As String = ""
        Dim sql As String = ""


        Dim IdCliente As String = ""
        If ExisteCampo("IdCliente") = True Then
            IdCliente = ObtenerDatoArchivo(Hoja, Fila, "IdCliente").Trim
            If IdCliente = "" Then
                Res &= "Falta Código Cliente;"
            End If
        Else
            Res &= "Falta Código Cliente;"
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

        Dim Dui As String = ""
        If ExisteCampo("Dui") = True Then
            Dui = ObtenerDatoArchivo(Hoja, Fila, "Dui").Trim
        End If

        Dim RegistroFiscal As String = ""
        If ExisteCampo("RegistroFiscal") = True Then
            RegistroFiscal = ObtenerDatoArchivo(Hoja, Fila, "RegistroFiscal").Trim
        End If

        Dim Giro As String = ""
        If ExisteCampo("Giro") = True Then
            Giro = ObtenerDatoArchivo(Hoja, Fila, "Giro").Trim
        End If

        Dim FechaNacimiento As String = ""
        If ExisteCampo("FechaNacimiento") = True Then
            FechaNacimiento = ObtenerDatoArchivo(Hoja, Fila, "FechaNacimiento").Trim
        End If

        Dim Email As String = ""
        If ExisteCampo("Email") = True Then
            Email = ObtenerDatoArchivo(Hoja, Fila, "Email").Trim
        End If

        Dim Fax As String = ""
        If ExisteCampo("Fax") = True Then
            Fax = ObtenerDatoArchivo(Hoja, Fila, "Fax").Trim
        End If

        Dim IdTipoCliente As String = ""
        If ExisteCampo("IdTipoCliente") = True Then
            IdTipoCliente = ObtenerDatoArchivo(Hoja, Fila, "IdTipoCliente").Trim
            If IdTipoCliente.Length > 2 Then
                IdTipoCliente = Mid(IdTipoCliente, 1, 2).Trim.ToUpper
            End If
        End If

        Dim LugarTrabajo As String = ""
        If ExisteCampo("LugarTrabajo") = True Then
            LugarTrabajo = ObtenerDatoArchivo(Hoja, Fila, "LugarTrabajo").Trim
        End If

        Dim ExisteCliente As Integer
        Try
            ExisteCliente = StiGlobalConn.ObtenerDataset("select count(*) from Clientes where idcliente = " & dbStr(IdCliente, 25)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            ExisteCliente = 0
        End Try




        Dim FechaVinculacion As String = ""
        If ExisteCampo("FechaVinculacion") = True Then
            FechaVinculacion = ObtenerDatoArchivo(Hoja, Fila, "FechaVinculacion").Trim
        End If

        Dim NumeroTarjeta As String = ""
        If ExisteCampo("NumeroTarjeta") = True Then
            NumeroTarjeta = ObtenerDatoArchivo(Hoja, Fila, "NumeroTarjeta").Trim
        End If

        Dim VencimientoTarjeta As String = ""
        If ExisteCampo("VencimientoTarjeta") = True Then
            VencimientoTarjeta = ObtenerDatoArchivo(Hoja, Fila, "VencimientoTarjeta").Trim
        End If

        Dim IdTipoPago As String = ""
        If ExisteCampo("IdTipoPago") = True Then
            IdTipoPago = ObtenerDatoArchivo(Hoja, Fila, "IdTipoPago").Trim
        End If

        Dim IdBanco As String = ""
        If ExisteCampo("IdBanco") = True Then
            IdBanco = ObtenerDatoArchivo(Hoja, Fila, "IdBanco").Trim
        End If

        Dim EjecutivoCta As String = ""
        If ExisteCampo("EjecutivoCta") = True Then
            EjecutivoCta = ObtenerDatoArchivo(Hoja, Fila, "EjecutivoCta").Trim
        End If

        Try
            If Res = "" And Revision = False Then

                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
                If ExisteCliente = 0 Then
                    sql = " insert into Clientes"
                    sql &= " (IdCliente, NombreCliente, Dui, RegistroFiscal, Giro, "
                    sql &= " FechaNacimiento, Email, Fax, IdTipoCliente, LugarTrabajo, "
                    sql &= " FechaVinculacion, NumeroTarjeta, VencimientoTarjeta, IdTipoPago, IdBanco, EjecutivoCta ) values("
                    sql &= dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 150) & C & dbStr(Dui, 25) & C & dbStr(RegistroFiscal, 25) & C & dbStr(Giro, 150) & C
                    sql &= dbFec(FechaNacimiento) & C & dbStr(Email, 250) & C & dbStr(Fax, 25) & C & dbStr(IdTipoCliente, 25) & C & dbStr(LugarTrabajo, 50) & C
                    sql &= dbFec(FechaVinculacion) & C & dbStr(NumeroTarjeta, 25) & C & dbStr(VencimientoTarjeta, 50) & C & dbStr(IdTipoPago, 25) & C & dbStr(IdBanco, 25) & C & dbStr(EjecutivoCta, 25) & ")"
                    StiGlobalConn.SQLExecute(sql)
                Else
                    sql = " update Clientes set "
                    sql &= " IdBanco = " & dbStr(IdBanco, 25)
                    If NombreCliente <> "" Then sql &= " , NombreCliente = " & dbStr(NombreCliente, 150)
                    If Dui <> "" Then sql &= " , Dui = " & dbStr(Dui, 25)
                    If RegistroFiscal <> "" Then sql &= " , RegistroFiscal = " & dbStr(RegistroFiscal, 25)
                    If Giro <> "" Then sql &= " , Giro = " & dbStr(Giro, 150)
                    If FechaNacimiento <> "" Then sql &= " , FechaNacimiento = " & dbFec(FechaNacimiento)
                    If Email <> "" Then sql &= " , Email = " & dbStr(Email, 250)
                    If Fax <> "" Then sql &= " , Fax = " & dbStr(Fax, 25)
                    If IdTipoCliente <> "" Then sql &= " , IdTipoCliente = " & dbStr(IdTipoCliente, 25)
                    If LugarTrabajo <> "" Then sql &= " , LugarTrabajo = " & dbStr(LugarTrabajo, 50)
                    If FechaVinculacion <> "" Then sql &= " , FechaVinculacion = " & dbFec(FechaVinculacion)
                    If NumeroTarjeta <> "" Then sql &= " , NumeroTarjeta = " & dbStr(NumeroTarjeta, 25)
                    If VencimientoTarjeta <> "" Then sql &= " , VencimientoTarjeta = " & dbStr(VencimientoTarjeta, 50)
                    If IdTipoPago <> "" Then sql &= " , IdTipoPago = " & dbStr(IdTipoPago, 25)
                    If EjecutivoCta <> "" Then sql &= ", EjecutivoCta = " & dbStr(EjecutivoCta, 25)

                    sql &= " where IdCliente = " & dbStr(IdCliente, 25)
                    StiGlobalConn.SQLExecute(sql)
                End If

                StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            End If
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            Res &= ex.Message
        End Try

        Return Res
    End Function

    Private Sub CrearCamposPersonalizados(ByRef Hoja As Object, ByVal Fila As Integer, ByVal IdCliente As String)
        Dim sql As String = "", Id As Integer = 0
        Try
            For NC As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If VistaImportar.GetRowCellValue(NC, "Tipo") = "P" And VistaImportar.GetRowCellValue(NC, "Campo") <> "" Then
                    Try
                        Id += 1
                        sql = "  insert into ClientesCamposNatural"
                        sql &= " (IdCliente, IdCampo, Nombre, Descripcion) Values("
                        sql &= dbStr(IdCliente, 25) & C & dbInt(Id) & C & dbStr(VistaImportar.GetRowCellValue(NC, "Campo"), 25) & C & dbStr(Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna"))), 500) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    Catch ex As Exception

                    End Try
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrearContactos(ByRef Hoja As Object, ByVal Fila As Integer, ByVal IdCliente As String)

        Dim sql As String = ""
        Dim Nombre As String = "", Telefono As String = "", Direccion As String = "", Ciudad As String = "", Cargo As String = "", EMail As String = "", FechaNacimiento As String = ""
        Dim Idcontacto As Integer = 0, Existe As Integer = 0, Uso As String = "S"

        Dim CuentaContactos As Integer = StiGlobalConn.ObtenerDataset("select count(*) from ClientesContactos where IdCliente = " & dbStr(IdCliente, 25) & " and UsoCorrespondencia = 'S'").Tables(0).Rows(0).Item(0)
        If CuentaContactos > 0 Then Uso = "N"

        Try
            For NC As Integer = 0 To Me.VistaImportar.DataRowCount - 1
                If VistaImportar.GetRowCellValue(NC, "Tipo") = "C" And VistaImportar.GetRowCellValue(NC, "Campo") <> "" Then
                    If VistaImportar.GetRowCellValue(NC, "Campo") = "Nombre" Then
                        If Nombre <> "" Then
                            Try
                                Existe = StiGlobalConn.ObtenerDataset("select IdContacto from ClientesContactos where IdCliente = " & dbStr(IdCliente, 25) & " and Nombre = " & dbStr(Nombre, 250)).Tables(0).Rows(0).Item(0)
                            Catch ex As Exception
                                Existe = -1
                            End Try
                            If Existe = -1 Then
                                Idcontacto = StiGlobalConn.ObtenerDataset("select isnull(max(IdContacto),0) + 1 from ClientesContactos where IdCliente = " & dbStr(IdCliente, 25)).Tables(0).Rows(0).Item(0)
                                sql = "  insert into ClientesContactos"
                                sql &= " (IdCliente, IdContacto, Nombre, Telefono, Direccion, "
                                sql &= " Ciudad, Cargo, FechaNacimiento, EMail,UsoCorrespondencia) Values("
                                sql &= dbStr(IdCliente, 25) & C & dbInt(Idcontacto) & C & dbStr(Nombre, 250) & C & dbStr(Telefono, 100) & C & dbStr(Direccion, 250) & C
                                sql &= dbStr(Ciudad, 50) & C & dbStr(Cargo, 50) & C & dbFec(FechaNacimiento) & C & dbStr(EMail, 250) & C & dbStr(Uso) & ")"
                                StiGlobalConn.SQLExecute(sql)
                                Uso = "N"
                            Else
                                Idcontacto = Existe
                                sql = "  update ClientesContactos set "
                                sql &= " Nombre = " & dbStr(Nombre, 250)
                                sql &= " , Telefono = " & dbStr(Telefono, 100)
                                sql &= " , Direccion =  " & dbStr(Direccion, 250)
                                sql &= " ,Ciudad = " & dbStr(Ciudad, 50)
                                sql &= " , Cargo = " & dbStr(Cargo, 50)
                                sql &= " , FechaNacimiento = " & dbFec(FechaNacimiento)
                                sql &= " , EMail = " & dbStr(EMail, 250)
                                sql &= " where IdCliente = " & dbStr(IdCliente, 25)
                                sql &= " and IdContacto = " & dbInt(Idcontacto)
                                StiGlobalConn.SQLExecute(sql)
                            End If
                        End If
                        Nombre = "" : Telefono = "" : Direccion = "" : Ciudad = "" : Cargo = "" : EMail = "" : FechaNacimiento = ""
                    End If

                    Select Case VistaImportar.GetRowCellValue(NC, "Campo")
                        Case "Nombre" : Nombre = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "Telefono" : Telefono = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "Direccion" : Direccion = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "Ciudad" : Ciudad = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "Cargo" : Cargo = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "FechaNacimiento" : FechaNacimiento = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                        Case "EMail" : EMail = Me.ObtenerDatoArchivo(Hoja, Fila, CInt(VistaImportar.GetRowCellValue(NC, "Columna")))
                    End Select
                End If
            Next

            If Nombre <> "" Then
                Try
                    Existe = StiGlobalConn.ObtenerDataset("select IdContacto from ClientesContactos where IdCliente = " & dbStr(IdCliente, 25) & " and Nombre = " & dbStr(Nombre, 250)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Existe = -1
                End Try
                If Existe = -1 Then
                    Idcontacto = StiGlobalConn.ObtenerDataset("select isnull(max(IdContacto),0) + 1 from ClientesContactos where IdCliente = " & dbStr(IdCliente, 25)).Tables(0).Rows(0).Item(0)
                    sql = "  insert into ClientesContactos"
                    sql &= " (IdCliente, IdContacto, Nombre, Telefono, Direccion, "
                    sql &= " Ciudad, Cargo, FechaNacimiento, EMail,UsoCorrespondencia) Values("
                    sql &= dbStr(IdCliente, 25) & C & dbInt(Idcontacto) & C & dbStr(Nombre, 250) & C & dbStr(Telefono, 100) & C & dbStr(Direccion, 250) & C
                    sql &= dbStr(Ciudad, 50) & C & dbStr(Cargo, 50) & C & dbFec(FechaNacimiento) & C & dbStr(EMail, 250) & C & dbStr(Uso) & ")"
                    StiGlobalConn.SQLExecute(sql)
                Else
                    Idcontacto = Existe
                    sql = "  update ClientesContactos set "
                    sql &= " Nombre = " & dbStr(Nombre, 250)
                    sql &= " , Telefono = " & dbStr(Telefono, 100)
                    sql &= " , Direccion =  " & dbStr(Direccion, 250)
                    sql &= " ,Ciudad = " & dbStr(Ciudad, 50)
                    sql &= " , Cargo = " & dbStr(Cargo, 50)
                    sql &= " , FechaNacimiento = " & dbFec(FechaNacimiento)
                    sql &= " , EMail = " & dbStr(EMail, 250)
                    sql &= " where IdCliente = " & dbStr(IdCliente, 25)
                    sql &= " and IdContacto = " & dbInt(Idcontacto)
                    StiGlobalConn.SQLExecute(sql)
                    Uso = "N"
                End If
            End If

        Catch ex As Exception

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
                res = CrearCliente(Hoja, Fila, False)
                If res = "" Then
                    CrearContactos(Hoja, Fila, ObtenerDatoArchivo(Hoja, Fila, "IdCliente").Trim)
                    CrearCamposPersonalizados(Hoja, Fila, ObtenerDatoArchivo(Hoja, Fila, "IdCliente").Trim)
                End If


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
                MsgBox("No todos los clientes se procesaron, los errores los encontrará en el archivo que especificó.", MsgBoxStyle.Exclamation, "ERROR...")
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
