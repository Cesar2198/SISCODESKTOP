Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class Genericas
    Public Shared C As String = ", "

#Region "Rutinas para base de datos"
    ''' <summary>
    ''' Rutina para formatear entradas de cadena a la base de datos
    ''' </summary>
    ''' <param name="Valor">Cadena que se desea ingresar a una base de datos</param>
    ''' <returns>Cadena formateada para ingresarse a una base de datos</returns>
    ''' <remarks></remarks>
    Public Shared Function dbStr(ByVal Valor As Object, Optional ByVal Longitud As Integer = -1) As String
        Dim res As String = ""
        Try
            If IsNothing(Valor) Then
                res = "NULL"
            Else
                'aqui controlamos la longitud del contenido
                res = CStr(Valor)
                If Longitud <> -1 Then If res.Length > Longitud Then res = Mid(res, 1, Longitud)
                res = Replace(res, "'", "''")     'para inset o updates de comilla se hace esto
                If res = "" Then
                    res = "NULL"
                Else
                    res = "'" & res & "'"
                End If
            End If
        Catch ex As Exception
            res = "NULL"
        End Try
        Return res
    End Function

    Public Shared Function dbNum(ByVal Valor As Object) As String
        Dim res As String = ""
        Try
            If IsNothing(Valor) Then
                res = "NULL"
            Else
                res = CStr(Valor)
                If res <> "" Then
                    res = res.Replace(",", "")
                    res = res.Replace(":", ".") 'PARA COMPATIBILIDAD CON CAMPOS HORAS
                    res = Format(CDbl(res), "###0.00000") 'CINDO DECIMALES POR DEFAULT
                Else
                    res = "NULL"
                End If
            End If
        Catch ex As Exception
            res = "NULL"
        End Try
        Return res
    End Function

    Public Shared Function dbInt(ByVal Valor As Object) As String
        Dim res As String = ""
        Try
            If IsNothing(Valor) Then
                res = "NULL"
            Else
                res = CStr(Valor)
                If res <> "" Then
                    res.Replace(",", "")
                    res = Format(Val(res), "###0")
                Else
                    res = "NULL"
                End If
            End If
        Catch ex As Exception
            res = "NULL"
        End Try
        Return res
    End Function

    Public Shared Function dbBool(ByVal Valor As Object) As String
        Dim res As String = ""
        Try
            If IsNothing(Valor) Then
                res = "NULL"
            Else
                res = CStr(Valor)
                Select Case res.Trim.ToLower
                    Case "true", "s", "1"
                        res = "1"
                    Case "false", "n", "0"
                        res = "0"
                    Case Else
                        res = "NULL"
                End Select
            End If
        Catch ex As Exception
            res = "NULL"
        End Try
        Return res
    End Function

    Public Shared Function dbFec(ByVal Valor As Object, Optional ByVal Hora As String = "") As String
        Dim res As String = ""
        Try
            If IsNothing(Valor) Then
                res = "NULL"
            Else
                res = CStr(Valor)
                If TypeOf Valor Is DateTime Then
                    If Valor.Year = 1 Then
                        res = "NULL"
                    Else
                        res = Format(Valor, "Short Date").ToString.Trim
                        'si almacenamos la hora tenemos problemas con consultas de fechas
                        'se pondrá la hora en los campos en que son necesarios
                        If Hora <> "" Then Hora = Format(Valor, "HH:mm:ss").ToString.Trim
                    End If
                Else
                    If res = "12:00:00 a.m." Then
                        'esta es lo que se manda como fecha vacia
                        res = "NULL"
                    End If
                    res = ConvertirFecha(res, FormatoFecha.FechaCorta)
                End If

                If res <> "" Then
                    If Hora <> "" Then
                        res = "'" & Format(CType(res, Date), "yyyyMMdd") & " " & Hora & "'"
                    Else
                        res = "'" & Format(CType(res, Date), "yyyyMMdd") & "'"
                    End If
                Else
                    res = "NULL"
                End If
            End If
        Catch ex As Exception
            res = "NULL"
        End Try
        Return res
    End Function

    Public Shared Function dbData(ByVal FILA As Data.DataRow, ByVal Campo As Object) As String
        'retornamos el valor en string del campo y la fila, si hay error devuelde string nulo
        Try
            Return FILA(Campo)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function ValidadbNull(ByVal Valor As Object, ByVal Reemplazo As Object) As Object
        Dim res As Object = Valor
        Try
            If Valor Is Nothing Then res = Reemplazo
            If Valor Is System.DBNull.Value Then res = Reemplazo
        Catch ex As Exception
            res = Reemplazo
        End Try
        Return res
    End Function

#End Region

#Region "Rutinas de Fechas"

    Public Enum FormatoFecha
        FechaLarga = 0
        FechaCorta = 1
        FechaDD_MM_YYYY = 2
        FechaMM_DD_YYYY = 3
        FechaDDMMYYYY = 4
        FechaYYYY_MM_DD = 5
    End Enum

    Public Structure Fecha
        Dim Dia As Integer
        Dim Mes As Integer
        Dim Año As Integer
    End Structure

    Public Shared Function CambiaMes(ByVal MES As String) As String
        MES = UCase(MES.Trim)
        MES = Replace(MES, ".", "")
        MES = Replace(MES, ",", "")
        MES = Replace(MES, ";", "")
        MES = Replace(MES, ":", "")
        Select Case MES
            Case "ENERO", "JANUARY", "ENE", "JAN" : Return "01"
            Case "FEBRERO", "FEBRUARY", "FEB" : Return "02"
            Case "MARZO", "MARCH", "MAR" : Return "03"
            Case "ABRIL", "APRIL", "ABR", "APR" : Return "04"
            Case "MAYO", "MAY" : Return "05"
            Case "JUNIO", "JUNE", "JUN" : Return "06"
            Case "JULIO", "JULY", "JUL" : Return "07"
            Case "AGOSTO", "AUGUST", "AGO", "AUG" : Return "08"
            Case "SEPTIEMBRE", "SEPTEMBER", "SEP" : Return "09"
            Case "OCTUBRE", "OCTOBER", "OCT" : Return "10"
            Case "NOVIEMBRE", "NOVEMBER", "NOV" : Return "11"
            Case "DICIEMBRE", "DECEMBER", "DIC", "DEC" : Return "12"
            Case Else : Return ""
        End Select
    End Function

    Public Shared Sub BuscaFechaParcial(ByRef Fecbp As Fecha, ByVal Busqueda As String)
        'Esta función complementa una estructura en base a lo que se manda como parametro
        'si se le manda el nombre del mes, almacenara en la estructura.mes el valor del mes
        'esta función se usa varias veces para completar una fecha en cualquier formato

        Dim Valor As Integer, str As String

        If IsNumeric(Busqueda) Then
            'verificamos si es 4 dig. es año, sino dia
            Valor = CInt(Busqueda)
            If Valor > 31 Then
                Fecbp.Año = Valor
            Else
                Fecbp.Dia = Valor
            End If
        Else
            'puede ser el mes
            str = CambiaMes(Busqueda)
            If str <> "" Then
                Fecbp.Mes = CInt(str)
            End If
        End If
    End Sub

    Public Shared Function ConvertirFecha(ByVal Fecha As String, Optional ByVal Formato As FormatoFecha = FormatoFecha.FechaLarga) As String
        'convierte una fecha en cualquier formato al formato especificado
        'real en el calendario
        Dim A As String, P As Integer, c As Integer, dummy As Date
        Dim FECL As Fecha
        Const s = "-"

        'existen formatos fecha y hora, cuando esta en blanco, nos manfa solo la hora, validamos
        If Fecha.Trim.ToUpper = "12:00:00 A.M." Then Return ""
        Try
            A = Fecha.Trim
            If Len(A) Then
                P = 1
                Do While P < Len(A)
                    If Mid(A, P, 1) = " " And Mid(A, P + 1, 1) = " " Then
                        A = Left(A, P - 1) + Mid(A, P + 1)
                    Else
                        P = P + 1
                    End If
                Loop

                If A Like "######" Or Fecha Like "########" Then
                    'Formato DDMMYY o DDMMYYYY
                    A = Left(A, 2) & s & Mid(A, 3, 2) & s & Mid(A, 5)
                ElseIf A Like "#?#?####" Then
                    '24/05/2016 formato raro reducido de windows 10 por defecto
                    A = "0" & Left(A, 1) & s & "0" & Mid(A, 3, 1) & s & Mid(A, 5)
                ElseIf A Like "##?#?####" Then
                    '24/05/2016 formato raro reducido de windows 10 por defecto
                    A = Left(A, 2) & s & "0" & Mid(A, 4, 1) & s & Mid(A, 6)
                ElseIf A Like "#?##?####" Then
                    '24/05/2016 formato raro reducido de windows 10 por defecto
                    A = "0" & Left(A, 1) & s & Mid(A, 3, 2) & s & Mid(A, 6)
                ElseIf A Like "##?##?##" Or A Like "##?##?####" Then
                    'formato DD/MM/YY o DD/MM/YYYY
                    'no hacer nada pues el formato es bueno
                    'pero aseguramos que sea caracter /
                    A = Left(A, 2) & s & Mid(A, 4, 2) & s & Mid(A, 7)
                ElseIf A Like "##???##" Or A Like "##?????##" Or A Like "##?????####" Or A Like "##???####" Then
                    'INTENTAMOS FORMATO DD/MMM/YYYY
                    If A Like "##???##" Or A Like "##???####" Then A = Left(A, 2) & s & CambiaMes(Mid(A, 3, 3)) & s & Mid(A, 6)
                    If A Like "##?????##" Or A Like "##?????####" Then A = Left(A, 2) & s & CambiaMes(Mid(A, 4, 3)) & s & Mid(A, 8)
                ElseIf A Like "##?##?#### ##?##?##*" Then
                    'nos envian la fecha con la hora
                    A = Left(A, 2) & s & Mid(A, 4, 2) & s & Mid(A, 7, 4)
                Else
                    'probable 'long date'
                    P = 1
                    c = 1
                    Do While P <= Len(A)
                        If Mid$(A, P, 1) = " " Then
                            BuscaFechaParcial(FECL, Mid(A, c, P - c))
                            c = P + 1
                        End If
                        P = P + 1
                    Loop
                    BuscaFechaParcial(FECL, Mid(A, c, P - c + 1))
                    A = CStr(DateSerial(FECL.Año, FECL.Mes, FECL.Dia))
                End If
                dummy = Date.Parse(A)
                Select Case Formato
                    Case FormatoFecha.FechaLarga : Return Format(dummy, "Long Date")
                    Case FormatoFecha.FechaCorta : Return Format(dummy, "Short Date")
                    Case FormatoFecha.FechaDD_MM_YYYY : Return Format(dummy, "DD-MM-YYYY")
                    Case FormatoFecha.FechaMM_DD_YYYY : Return Format(dummy, "MM-DD-YYYY")
                    Case FormatoFecha.FechaDDMMYYYY : Return Format(dummy, "DDMMYYYY")
                    Case FormatoFecha.FechaYYYY_MM_DD : Return Format(dummy, "YYYY-MM-DD")
                End Select
            Else
                Return ""
            End If
        Catch EX As Exception
            Return ""
        End Try

        Return ""
    End Function

    Public Shared Function PrimerDiaSemana(ByVal Fecha As Date) As Date
        Dim Res As Date = Fecha
        Do While Res.DayOfWeek <> DayOfWeek.Monday
            Res = Res.AddDays(-1)
        Loop
        Return Res
    End Function

    Public Shared Function CalcularEdad(ByVal FechaNacimiento As Date, ByVal FechaCorte As Date) As Integer
        Dim FECT As Date, EDAD As Integer
        FECT = FechaNacimiento
        EDAD = 0
        Do While 1
            FECT = FECT.AddYears(1)
            If FECT <= FechaCorte Then
                EDAD = EDAD + 1
            Else
                Exit Do
            End If
        Loop
        Return EDAD
    End Function


#End Region

#Region "Rutinas de Encryptación"

    '**** OJO ESTAS RUTINAS NO FUNCIONAN SI NO SE LES MANDA EXACTAMENTE LA MISMA LLAVE   ********
    Public Shared Function DESEncrypt(ByVal TextoOriginal As String, ByVal ClaveEncriptacion As String) As String
        Dim baseStream As New MemoryStream
        Dim secretStream As CryptoStream
        Dim streamOut As StreamWriter
        Dim encryptedText() As Byte
        Dim StringEncriptado As String = ""
        Dim key As New System.Security.Cryptography.DESCryptoServiceProvider

        ClaveEncriptacion = ClaveEncriptacion.ToUpper.Replace(" ", "")
        If Len(ClaveEncriptacion) > 8 Then ClaveEncriptacion = Left(ClaveEncriptacion, 8)
        If Len(ClaveEncriptacion) < 8 Then
            Dim Falta As New String("A", 8 - Len(ClaveEncriptacion))
            ClaveEncriptacion = ClaveEncriptacion & Falta
        End If
        key.Key = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)
        key.IV = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)

        secretStream = New CryptoStream(baseStream, key.CreateEncryptor(), CryptoStreamMode.Write)
        streamOut = New StreamWriter(secretStream)
        streamOut.WriteLine(TextoOriginal)
        streamOut.Close()
        secretStream.Close()
        encryptedText = baseStream.ToArray()
        StringEncriptado = ""
        For i As Integer = 0 To encryptedText.Length - 1
            StringEncriptado &= Chr(encryptedText(i))
        Next

        baseStream.Close()
        Return StringEncriptado
    End Function

    Public Shared Function DESEncrypt2(ByVal TextoOriginal As String, ByVal ClaveEncriptacion As String) As String
        Dim baseStream As New MemoryStream
        Dim secretStream As CryptoStream
        Dim streamOut As StreamWriter
        Dim encryptedText() As Byte
        Dim StringEncriptado As String = ""
        Dim key As New System.Security.Cryptography.DESCryptoServiceProvider

        ClaveEncriptacion = ClaveEncriptacion.ToUpper.Replace(" ", "")
        If Len(ClaveEncriptacion) > 8 Then ClaveEncriptacion = Left(ClaveEncriptacion, 8)
        If Len(ClaveEncriptacion) < 8 Then
            Dim Falta As New String("A", 8 - Len(ClaveEncriptacion))
            ClaveEncriptacion = ClaveEncriptacion & Falta
        End If
        key.Key = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)
        key.IV = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)

        secretStream = New CryptoStream(baseStream, key.CreateEncryptor(), CryptoStreamMode.Write)
        streamOut = New StreamWriter(secretStream)
        streamOut.WriteLine(TextoOriginal)
        streamOut.Close()
        secretStream.Close()
        encryptedText = baseStream.ToArray()
        StringEncriptado = System.Convert.ToBase64String(encryptedText, Base64FormattingOptions.None)
        baseStream.Close()
        Return StringEncriptado
    End Function

    Public Shared Function DESDecrypt(ByVal TextoEncriptado As String, ByVal ClaveEncriptacion As String) As String
        Dim baseStream As MemoryStream
        Dim secretStream As CryptoStream
        Dim streamIn As StreamReader
        Dim origText As String = ""
        If TextoEncriptado.Trim = "" Then Return ""
        Dim key As New System.Security.Cryptography.DESCryptoServiceProvider
        ClaveEncriptacion = ClaveEncriptacion.ToUpper.Replace(" ", "")
        If Len(ClaveEncriptacion) > 8 Then ClaveEncriptacion = Left(ClaveEncriptacion, 8)
        If Len(ClaveEncriptacion) < 8 Then
            Dim Falta As New String("A", 8 - Len(ClaveEncriptacion))
            ClaveEncriptacion = ClaveEncriptacion & Falta
        End If
        key.Key = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)
        key.IV = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)
        Try
            Dim byteEncriptado(Len(TextoEncriptado) - 1) As Byte
            For I As Integer = 0 To Len(TextoEncriptado) - 1
                byteEncriptado(I) = Asc(Mid(TextoEncriptado, I + 1, 1))
            Next
            baseStream = New MemoryStream(byteEncriptado)

            secretStream = New CryptoStream(baseStream, key.CreateDecryptor(), CryptoStreamMode.Read)
            streamIn = New StreamReader(secretStream)
            origText = streamIn.ReadLine()
            streamIn.Close()
            secretStream.Close()
            baseStream.Close()
        Catch ex As Exception
            origText = ""
        End Try
        Return origText
    End Function

    Public Shared Function DESDecrypt2(ByVal TextoEncriptado As String, ByVal ClaveEncriptacion As String) As String
        Dim baseStream As MemoryStream
        Dim secretStream As CryptoStream
        Dim streamIn As StreamReader
        Dim origText As String = ""
        If TextoEncriptado.Trim = "" Then Return ""
        Dim key As New System.Security.Cryptography.DESCryptoServiceProvider
        ClaveEncriptacion = ClaveEncriptacion.ToUpper.Replace(" ", "")
        If Len(ClaveEncriptacion) > 8 Then ClaveEncriptacion = Left(ClaveEncriptacion, 8)
        If Len(ClaveEncriptacion) < 8 Then
            Dim Falta As New String("A", 8 - Len(ClaveEncriptacion))
            ClaveEncriptacion = ClaveEncriptacion & Falta
        End If
        key.Key = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)
        key.IV = ASCIIEncoding.ASCII.GetBytes(ClaveEncriptacion)
        Try
            TextoEncriptado = TextoEncriptado.Replace(" ", "+")
            Dim byteEncriptado As Byte() = System.Convert.FromBase64String(TextoEncriptado)
            baseStream = New MemoryStream(byteEncriptado)
            secretStream = New CryptoStream(baseStream, key.CreateDecryptor(), CryptoStreamMode.Read)
            streamIn = New StreamReader(secretStream)
            origText = streamIn.ReadLine()
            streamIn.Close()
            secretStream.Close()
            baseStream.Close()
        Catch ex As Exception
            origText = ""
        End Try
        Return origText
    End Function

    '**** Encriptación de una vía
    Public Shared Function HashEncrypt(ByVal TextoAEncriptar As String, ByVal Key As String) As String
        Dim hashingFunction As System.Security.Cryptography.HMACSHA1
        Dim secretKey() As Byte
        Dim hashValue() As Byte
        Dim counter As Integer
        Dim result As String = ""
        Try
            secretKey = (New System.Text.UnicodeEncoding).GetBytes(UCase(Key))
            hashingFunction = New System.Security.Cryptography.HMACSHA1(secretKey, True)
            hashValue = hashingFunction.ComputeHash((New System.Text.UnicodeEncoding).GetBytes(TextoAEncriptar))
            'convertimos a texto los byte que se han hecho con la funcion Hash que son caracteres hexadecimales 0123456789ABCDEF
            For counter = 0 To hashValue.Length - 1
                result &= Hex(hashValue(counter))
            Next counter
            'si se desea limitar el ancho de la funcion hash, en las pruebas la longitud siempre es 38 o 39 con una clave de 6 letras
            'Return Left(result, 20)
        Catch ex As Exception
            result = ""
        End Try

        Return result
    End Function

#End Region

#Region "Rutinas Generales"

    Public Shared Function CuentaCar(ByVal Cadena As String, ByVal CAR As String) As Integer
        'esta funcion devuelve la cantidad de caracteres encontrados en
        'una cadena.

        Dim Cont As Long, ULT As Integer
        Cont = 0 : ULT = 1
        Do While 1
            ULT = InStr(ULT, Cadena, CAR)
            If ULT <> 0 Then
                ULT = ULT + 1 : Cont = Cont + 1
            Else
                Exit Do
            End If
        Loop
        Return Cont
    End Function

    Public Shared Function stiSplit(ByVal ID As String, ByVal Param As String) As String
        'EL PARAM ES G#?# es usado para calcular substring especiales, separados por 
        'un caracter especial.

        Dim Car As String = "", INICIO As Integer, ITEMS As Integer, I As Long
        Dim INI As Integer, FIN As Integer, ITEMT As Integer, ITEMC As Integer
        Dim TOTITEMS As Integer

        Select Case Param.ToUpper.Substring(0, 1)
            Case "G"
                For I = 1 To Param.Length - 1
                    If Not IsNumeric(Param.Substring(I, 1)) Then
                        INICIO = Val(Param.Substring(1, I - 1))
                        ITEMS = Val(Param.Substring(I + 1, Param.Length - (I + 1)))
                        Car = Param.Substring(I, 1)
                        Exit For
                    End If
                Next
                TOTITEMS = CuentaCar(ID, Car)
                ITEMT = 0 : INI = 0 : ITEMC = -1
                If TOTITEMS = 0 Then
                    'NO EXISTEN CARATERES ESPECIALES, SE REGRESA TODO EL TEXTO
                    Return ID
                Else
                    For I = 0 To ID.Length - 1
                        If ID.Substring(I, 1) = Car Or I = ID.Length Then
                            If ITEMT <> INICIO Then
                                If ITEMC = -1 Then INI = I + 1
                            Else
                                ITEMC = 0
                            End If
                            If ITEMC >= 0 Then ITEMC = ITEMC + 1
                            If ITEMC = ITEMS Then
                                FIN = I - 1
                                Exit For
                            End If
                            ITEMT = ITEMT + 1
                        End If
                    Next
                    If ITEMT = INICIO Then ITEMC = 0
                    If ITEMC = -1 Then
                        Return ""
                    Else
                        If FIN = 0 And I = ID.Length Then FIN = ID.Length - 1
                        Return ID.Substring(INI, (FIN - INI) + 1)
                    End If
                End If
        End Select

        'si llega hasta aqui el formato esta mal mandamos vacio
        Return ""
    End Function

    Public Enum TipoRelleno
        RellenarIzquierda = 1
        RellenarDerecha = 0
        RellenarCentrar = 2
    End Enum

    Public Shared Function PE(ByVal Cadena As String, ByVal Num As Long, Optional ByVal Caracter As String = "", Optional ByVal TIPO As TipoRelleno = TipoRelleno.RellenarDerecha) As String
        'PE = poner espacios o caracteres
        'coloca los espacios neCLAINEZios al final de la palabra
        'por defecto son espacios, de lo contario seran Caracter
        'num es la longitud total de la cadena
        Dim res As String = ""
        Try
            Dim Cade As String
            Cade = Trim(Cadena)
            If Len(Cade) >= Num Then ' RESTRINGE LA CADENA A LA LONGITUD DE NUM
                res = Mid(Cade, 1, Num)
            Else
                Select Case TIPO
                    Case TipoRelleno.RellenarCentrar
                        If Caracter = "" Then
                            res = Space((Num - Len(Cade)) / 2) & Cade & Space((Num - Len(Cade)) / 2)
                        Else
                            res = Replace(Space((Num - Len(Cade)) / 2), " ", Trim(Caracter)) & Cade & Replace(Space((Num - Len(Cade)) / 2), " ", Trim(Caracter))
                        End If
                    Case TipoRelleno.RellenarIzquierda
                        If Caracter = "" Then
                            res = Space(Num - Len(Cade)) & Cade
                        Else
                            res = Replace(Space(Num - Len(Cade)), " ", Trim(Caracter)) & Cade
                        End If
                    Case TipoRelleno.RellenarDerecha
                        If Caracter = "" Then
                            res = Cade & Space(Num - Len(Cade))
                        Else
                            res = Cade & Replace(Space(Num - Len(Cade)), " ", Trim(Caracter))
                        End If
                End Select
            End If
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Shared Sub msgError(ByVal ex As Exception)
        Dim frmError As New msgError(ex)
        frmError.ShowDialog()
    End Sub

    Public Enum TipoCarpetas
        MisDocumentos = 1
        Escritorio = 2
    End Enum

    Public Shared Function ObtenerCarpetasEspeciales(ByVal Carpeta As TipoCarpetas) As String
        Dim Res As String = ""
        Try
            Select Case Carpeta
                Case TipoCarpetas.MisDocumentos
                    Dim SubKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders")
                    Res = SubKey.GetValue("Personal")
                    'Res = Environment.SpecialFolder.MyDocuments
                Case TipoCarpetas.Escritorio
                    Res = Environment.SpecialFolder.Desktop
            End Select
        Catch ex As Exception
            Res = ""
        End Try
        Return Res
    End Function

    Public Shared Sub AbrirArchivo(ByVal fileName As String, Optional ByVal Verbo As String = "Open")
        Try
            If System.IO.File.Exists(fileName) = False Then
                MsgBox("No es posible abrir el archivo " & fileName, MsgBoxStyle.Information, "AVISO...")
            Else
                Dim process As System.Diagnostics.Process = New System.Diagnostics.Process
                process.StartInfo.FileName = fileName
                process.StartInfo.Verb = Verbo
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                process.Start()
            End If
        Catch
            MsgBox("No se puede abrir el archivo: " & fileName, MsgBoxStyle.Information, "AVISO...")
        End Try
    End Sub

    Public Shared Sub EstablecerPasswordExcelYAbrir(ByVal fileName As String, ByVal Password As String)
        Try
            Dim Miexcel As Object, Hoja As Object
            Try
                Miexcel = CreateObject("Excel.Application")
            Catch ex As Exception
                Miexcel = Nothing
            End Try

            If Miexcel Is Nothing Then
                AbrirArchivo(fileName)
            Else
                Miexcel.Workbooks.Open(fileName)
                Hoja = Miexcel.Worksheets(1)
                If Password.Trim <> "" Then
                    'le aplicaremos una contraseña al documento
                    Try
                        Hoja.Protect(Password, True, True, True)
                    Catch ex As Exception

                    End Try
                End If

                'Miexcel.Workbooks(1).Save()
                Miexcel.Visible = True
                Miexcel = Nothing
                Hoja = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub EstablecerPasswordWordYAbrir(ByVal fileName As String, ByVal Password As String)
        Try
            Dim Miword As Object, Doc As Object
            Try
                Miword = CreateObject("Word.Application")
            Catch ex As Exception
                Miword = Nothing
            End Try

            If Miword Is Nothing Then
                AbrirArchivo(fileName)
            Else
                Doc = Miword.Documents.Open(fileName)
                If Password.Trim <> "" Then
                    'le aplicaremos una contraseña al documento
                    Try
                        Doc.Protect(1, , Password)
                    Catch ex As Exception

                    End Try
                End If

                'Miexcel.Workbooks(1).Save()
                Miword.Visible = True
                Miword = Nothing
                Doc = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PrepararArchivoExcel(ByVal fileName As String, ByVal Titulo1 As String, ByVal Titulo2 As String, ByVal Titulo3 As String, ByVal Password As String)

        Try
            Dim Miexcel As Object, Hoja As Object
            Try
                Miexcel = CreateObject("Excel.Application")
            Catch ex As Exception
                Miexcel = Nothing
            End Try
            If Miexcel Is Nothing Then
                'no está instalado office. solo lanzamos el archivo sin ningún cambio
                AbrirArchivo(fileName)
            Else
                Miexcel.Workbooks.Open(fileName)
                Hoja = Miexcel.Worksheets(1)

                'insertamos 5 filas al inicio
                Hoja.Range("A1").Select()
                Miexcel.Selection.EntireRow.Insert()
                Hoja.Range("A1").Select()
                Miexcel.Selection.EntireRow.Insert()
                Hoja.Range("A1").Select()
                Miexcel.Selection.EntireRow.Insert()
                Hoja.Range("A1").Select()
                Miexcel.Selection.EntireRow.Insert()
                Hoja.Range("A1").Select()
                Miexcel.Selection.EntireRow.Insert()


                Hoja.Cells(1, 1).Value = ""
                Hoja.Cells(2, 1).Value = Titulo1
                Hoja.Cells(3, 1).Value = Titulo2
                Hoja.Cells(4, 1).Value = Titulo3

                Hoja.Rows("1:4").Select()
                Miexcel.Selection.Font.Bold = True
                Hoja.Range("A1").Select()

                If Password.Trim <> "" Then
                    'le aplicaremos una contraseña al documento
                    Try
                        Hoja.Protect(Password, True, True, True)
                    Catch ex As Exception

                    End Try
                End If

                Miexcel.Workbooks(1).Save()
                Miexcel.Visible = True
                Miexcel = Nothing
                Hoja = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al preparar el reporte en Excel.-" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Public Shared Function DobleComilla(ByVal Dato As String) As String
        Dim res As String = ""
        res = """" & Dato & """"
        Return res
    End Function

    Public Shared Function AgregarCitaOutlook(ByVal Asunto As String, ByVal Ubicacion As String, ByVal Mensaje As String, ByVal FechaInicio As DateTime, ByVal FechaFinal As DateTime) As String
        Dim res As String = ""
        Try
            Dim myOutLook As Object = CreateObject("Outlook.Application")
            Dim myAppoint As Object
            myAppoint = myOutLook.CreateItem(1)
            myAppoint.Subject = Asunto
            myAppoint.Location = Ubicacion
            myAppoint.Start = FechaInicio
            myAppoint.End = FechaFinal
            myAppoint.Body = Mensaje
            myAppoint.Save()
            myOutLook = Nothing
            res = ""
        Catch ex As Exception
            'no controlaremos ningún error..
            res = ex.ToString
        End Try
        Return res
    End Function

    Public Shared Sub PrepararCorreoOutlook(ByVal Correo As String, ByVal Asunto As String, ByVal Mensaje As String, ByVal Attachment As String)
        'Lo que haremos es preparar un correo en outlook con un adjunto listo
        Dim Outlook As Object
        Dim myMail As Object
        Try
            Outlook = GetObject(, "Outlook.Application")
            If Not Outlook Is Nothing Then
                myMail = Outlook.CreateItem(0)
                myMail.Subject = Asunto
                myMail.To = Correo
                If Mensaje.Trim <> "" Then
                    myMail.Body = Mensaje
                End If
                If Attachment.Trim <> "" Then
                    Try
                        myMail.Attachments.Add(Attachment)
                    Catch ex As Exception

                    End Try
                End If
                myMail.Display()
            End If
        Catch ex As Exception
            MsgBox("Error al preparar el correo:" & ex.Message, MsgBoxStyle.Information, "AVISO...")
        End Try
    End Sub

    Public Shared Function ObtenerLiteralRomano(ByVal Numero As Integer) As String
        Try
            Dim Romano As String = "", I As Integer = 0, Digito As Integer = 0, X As Integer = 0
            Dim Cadena As String = "", CadenaTmp As String = ""
            Dim Simbolo1 As String = "", Simbolo2 As String = "", Simbolo3 As String = ""

            Cadena = CStr(Numero)
            For X = 1 To Len(Cadena)
                If Len(Cadena) = 4 Then
                    Simbolo1 = "M"
                    Simbolo2 = "Q"
                    Simbolo3 = "H"
                    Digito = CInt(Left$(Cadena, 1))
                    Cadena = Right(Cadena, 3)
                ElseIf Len(Cadena) = 3 Then
                    Simbolo1 = "C"
                    Simbolo2 = "D"
                    Simbolo3 = "M"
                    Digito = CInt(Left(Cadena, 1))
                    Cadena = Right(Cadena, 2)
                ElseIf Len(Cadena) = 2 Then
                    Simbolo1 = "X"
                    Simbolo2 = "L"
                    Simbolo3 = "C"
                    Digito = CInt(Left(Cadena, 1))
                    Cadena = Right(Cadena, 1)
                ElseIf Len(Cadena) = 1 Then
                    Simbolo1 = "I"
                    Simbolo2 = "V"
                    Simbolo3 = "X"
                    Digito = CInt(Left(Cadena, 1))
                    Cadena = ""
                End If
                If Digito <= 3 Then
                    For I = 1 To Digito
                        CadenaTmp = CadenaTmp & Simbolo1
                    Next I
                ElseIf Digito < 5 Then
                    CadenaTmp = Simbolo1 & Simbolo2
                ElseIf Digito = 5 Then
                    CadenaTmp = Simbolo2
                ElseIf Digito <= 8 Then
                    CadenaTmp = Simbolo2
                    For I = 1 To Digito - 5
                        CadenaTmp = CadenaTmp & Simbolo1
                    Next I
                ElseIf Digito = 9 Then
                    CadenaTmp = Simbolo1 & Simbolo3
                End If
                Romano = Romano & CadenaTmp
                CadenaTmp = ""
            Next X
            Return Romano
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function ObtenerLiteralAlfabetico(ByVal Numero As Integer) As String
        Dim Letras(27) As String, Res As String = "", L1 As Integer = 0, L2 As Integer = 0
        Try
            Letras(1) = "A" : Letras(2) = "B" : Letras(3) = "C" : Letras(4) = "D" : Letras(5) = "E" : Letras(6) = "F"
            Letras(7) = "G" : Letras(8) = "H" : Letras(9) = "I" : Letras(10) = "J" : Letras(11) = "K" : Letras(12) = "L"
            Letras(13) = "M" : Letras(14) = "N" : Letras(15) = "O" : Letras(16) = "P" : Letras(17) = "Q" : Letras(18) = "R"
            Letras(19) = "S" : Letras(20) = "T" : Letras(21) = "U" : Letras(22) = "V" : Letras(23) = "W" : Letras(24) = "X"
            Letras(25) = "Y" : Letras(26) = "Z"
            If Numero > 26 Then
                L1 = Numero \ 26
                If Numero \ 26 = Numero / 26 Then L1 -= 1
                L2 = Numero Mod 26
                If L2 = 0 Then L2 = 26
                Res = Letras(L1) : Res &= Letras(L2)
            Else
                Res = Letras(Numero)
            End If
            Return Res
        Catch ex As Exception
            Return Res
        End Try
    End Function

    Public Shared Function ObtenerListaNumericaPatron(ByVal Patron As String) As String
        If Patron = "" Then Return "" 'si no hay lista se asume todos...
        'la lista es enviada con separador de comas
        'AHORA EL SEPARADOR PUEDE SER , O . PREVALECE LA ,
        Dim SeparadorRangos As String = ""
        If Strings.InStr(Patron, ",") <> 0 Then SeparadorRangos = ","
        If SeparadorRangos = "" And Strings.InStr(Patron, ".") <> 0 Then SeparadorRangos = "."
        If SeparadorRangos = "" Then SeparadorRangos = ","

        Dim NumRangos As Integer = CuentaCar(Patron, SeparadorRangos)
        Dim PatronI As String = "", Inicio As String, Fin As String, Lista As String = ""
        For NR As Integer = 0 To NumRangos
            PatronI = stiSplit(Patron, "G" & NR & SeparadorRangos & "1").Trim
            If CuentaCar(PatronI, "-") > 0 Then
                'se trata de un rango
                Inicio = stiSplit(PatronI, "G0-1").Trim
                Fin = stiSplit(PatronI, "G1-1").Trim
                'validamos si son numericos
                If IsNumeric(Inicio) And IsNumeric(Fin) Then
                    For NP As Integer = Val(Inicio) To Val(Fin)
                        If Lista = "" Then
                            Lista = NP.ToString.Trim
                        Else
                            Lista &= ", " & NP.ToString.Trim
                        End If
                    Next
                End If
            Else
                'es un valor escalar
                'validamos si por error escriber datos no numericos
                If IsNumeric(PatronI) Then
                    If Lista = "" Then
                        Lista = PatronI
                    Else
                        Lista &= ", " & PatronI
                    End If
                End If
            End If
        Next
        Return Lista
    End Function

    Public Shared Function ExisteItemEnLista(ByVal Item As String, ByVal Lista As String, Optional ByVal Separador As String = ",") As Boolean
        Try
            If Lista.Trim = "" Then Return False
            If Item.Trim = "" Then Return False

            Dim Items() As String = Lista.Split(Separador)
            For Each Val As String In Items
                If Val.Trim.ToUpper = Item.Trim.ToUpper Then Return True
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    public shared function ComillarLista(byval Lista as string, Optional ByVal Separador As String = "," ) as string
        dim res as string = ""
        If Lista.Trim <> "" Then 
            Dim Items() As String = Lista.Split(Separador)
            For Each Val As String In Items
                If Val.Trim <> "" then  
                    if res = "" then
                        res &= dbstr(val.trim)
                    else
                        res &= "," & dbstr(val.trim)
                    End If
                End If
            Next
        End If
        return res
    End Function

    Public Shared Function ObtenerListaStringPatron(ByVal Patron As String) As String
        If Patron = "" Then Return "" 'si no hay lista se asume todos...
        'la lista es enviada con separador de comas
        'AHORA EL SEPARADOR PUEDE SER , O . PREVALECE LA ,
        Dim SeparadorRangos As String = ""
        If Strings.InStr(Patron, ",") <> 0 Then SeparadorRangos = ","
        If SeparadorRangos = "" And Strings.InStr(Patron, ".") <> 0 Then SeparadorRangos = "."
        If SeparadorRangos = "" Then SeparadorRangos = ","

        Dim NumRangos As Integer = CuentaCar(Patron, SeparadorRangos)
        Dim PatronI As String = "", Inicio As String, Fin As String, Lista As String = ""

        'Modificacion para los carnet que tienen guienes
        If Strings.InStr(Patron, "'") <> 0 Then
            Patron = Strings.Replace(Patron, "'-'", "|")
            Patron = Strings.Replace(Patron, "','", ",")
            Patron = Strings.Replace(Patron, "'", "")
            Patron = Patron.ToString.Trim

            For NR As Integer = 0 To NumRangos
                PatronI = stiSplit(Patron, "G" & NR & SeparadorRangos & "1").Trim
                If CuentaCar(PatronI, "|") > 0 Then
                    'se trata de un rango
                    Inicio = stiSplit(PatronI, "G0|1").Trim
                    Fin = stiSplit(PatronI, "G1|1").Trim
                    'validamos si son numericos
                    If IsNumeric(Inicio) And IsNumeric(Fin) Then
                        For NP As Integer = Val(Inicio) To Val(Fin)
                            If Lista = "" Then
                                Lista = dbStr(NP.ToString.Trim)
                            Else
                                Lista &= ", " & dbStr(NP.ToString.Trim)
                            End If
                        Next
                    End If
                Else
                    'es un valor escalar
                    'NO validamos si por error escriber datos no numericos
                    If Lista = "" Then
                        Lista = dbStr(PatronI)
                    Else
                        Lista &= ", " & dbStr(PatronI)
                    End If
                End If
            Next
        Else
            For NR As Integer = 0 To NumRangos
                PatronI = stiSplit(Patron, "G" & NR & SeparadorRangos & "1").Trim
                If CuentaCar(PatronI, "-") > 0 Then
                    'se trata de un rango
                    Inicio = stiSplit(PatronI, "G0-1").Trim
                    Fin = stiSplit(PatronI, "G1-1").Trim
                    'validamos si son numericos
                    If IsNumeric(Inicio) And IsNumeric(Fin) Then
                        For NP As Integer = Val(Inicio) To Val(Fin)
                            If Lista = "" Then
                                Lista = dbStr(NP.ToString.Trim)
                            Else
                                Lista &= ", " & dbStr(NP.ToString.Trim)
                            End If
                        Next
                    End If
                Else
                    'es un valor escalar
                    'validamos si por error escriber datos no numericos
                    If IsNumeric(PatronI) Then
                        If Lista = "" Then
                            Lista = dbStr(PatronI)
                        Else
                            Lista &= ", " & dbStr(PatronI)
                        End If
                    End If
                End If
            Next
        End If

        Return Lista
    End Function

    Public Shared Function ConvertirANumero(ByVal Valor As String) As Double
        'funcion que devuelve valor numérico del valor pasado.
        Dim res As Double = 0
        Try
            Valor = Regex.Replace(Valor, "[^\d]", "")
            res = Val(Valor)
        Catch ex As Exception
            res = 0
        End Try
        Return res
    End Function

    Shared Archivos As New DataTable
    Shared RutaOriginal As String = ""

    Public Shared Function ObtenerArchivosCarpeta(ByVal RutaBase As String, Optional ByVal Recursivo As Boolean = False) As DataTable
        If Recursivo = False Then
            Archivos = New DataTable
            Archivos.TableName = "Archivos"
            Archivos.Columns.Add("Archivo", System.Type.GetType("System.String"))
            Archivos.Columns.Add("Carpeta", System.Type.GetType("System.String"))
            RutaOriginal = RutaBase
        End If
        Dim Archivo As String = "", FilArchivo As DataRow, Atributos As System.IO.FileAttributes
        If RutaBase <> "" Then
            If System.IO.Directory.Exists(RutaBase) = True Then
                '1) primero los archivos de la ruta base
                Dim strArchivos() As String = System.IO.Directory.GetFiles(RutaBase)

                For Each Archivo In strArchivos
                    Atributos = System.IO.File.GetAttributes(Archivo)
                    If (Atributos And FileAttributes.Hidden) = FileAttributes.Hidden Or (Atributos And FileAttributes.System) = FileAttributes.System Then
                        'archivos ocultos no deben ser incluidos
                    Else
                        FilArchivo = Archivos.NewRow
                        FilArchivo("Archivo") = Archivo
                        If Recursivo = False Then
                            FilArchivo("Carpeta") = ""
                        Else
                            FilArchivo("Carpeta") = Replace(RutaBase, RutaOriginal, "")
                        End If
                        Archivos.Rows.Add(FilArchivo)
                    End If
                Next

                '2) ahora las carpetas de la ruta base 
                For Each Archivo In System.IO.Directory.GetDirectories(RutaBase)
                    Call ObtenerArchivosCarpeta(Archivo, True)
                Next
            End If
        End If

        If Recursivo = False Then
            Return Archivos
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub funLanzarAyuda(ByVal Control As System.Windows.Forms.Control, ByVal TopicID As Integer)
        Try
            Dim Prog As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly
            Dim Modalidad As Integer = 0
            If TopicID = 0 Then
                Modalidad = Windows.Forms.HelpNavigator.TableOfContents
            Else
                Modalidad = Windows.Forms.HelpNavigator.TopicId
            End If
            System.Windows.Forms.Help.ShowHelp(Control, System.IO.Path.GetDirectoryName(Prog.Location) & "\" & System.IO.Path.GetFileNameWithoutExtension(Prog.Location) & ".chm", Modalidad, CStr(TopicID))
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Public Shared Sub DataTableAExcel(ByVal dtDatos As DataTable, ByVal fileName As String)
        Dim excelDoc As System.IO.StreamWriter
        excelDoc = New System.IO.StreamWriter(fileName)
        Const startExcelXML As String = "<xml version>" & _
        vbCrLf & "<Workbook " + "xmlns=""urn:schemas-microsoft-com:office:spreadsheet""" & _
        vbCrLf & "" + " xmlns:o=""urn:schemas-microsoft-com:office:office""" & _
        vbCrLf & " " + "xmlns:x=""urn:schemas- microsoft-com:office:" + "excel""" & _
        vbCrLf & " xmlns:ss=""urn:schemas-microsoft-com:" + "office:spreadsheet"">" & _
        vbCrLf & " <Styles>" & vbCrLf & " " + "<Style ss:ID=""Default"" ss:Name=""Normal"">" & _
        vbCrLf & " " + "<Alignment ss:Vertical=""Bottom""/>" & vbCrLf & " <Borders/>" + "" & _
        vbCrLf & " <Font/>" & vbCrLf & " <Interior/>" & vbCrLf & " <NumberFormat/>" + "" & _
        vbCrLf & " <Protection/>" & vbCrLf & " </Style>" & vbCrLf & " " + "<Style ss:ID=""BoldColumn"">" & _
        vbCrLf & " <Font " + "x:Family=""Swiss"" ss:Bold=""1""/>" & vbCrLf & " </Style>" & _
        vbCrLf & " " + "<Style ss:ID=""StringLiteral"">" & vbCrLf & " <NumberFormat" + " ss:Format=""@""/>" & _
        vbCrLf & " </Style>" & vbCrLf & " <Style " + "ss:ID=""Decimal"">" & _
        vbCrLf & " <NumberFormat " + "ss:Format=""0.0000""/>" & vbCrLf & " </Style>" & _
        vbCrLf & " " + "<Style ss:ID=""Integer"">" & vbCrLf & " <NumberFormat " + "ss:Format=""0""/>" & _
        vbCrLf & " </Style>" & vbCrLf & " <Style " + "ss:ID=""DateLiteral"">" & _
        vbCrLf & " <NumberFormat " + "ss:Format=""mm/dd/yyyy;@""/>" & vbCrLf & " </Style>" & _
        vbCrLf & " " + "</Styles>" & vbCrLf & " "
        Const endExcelXML As String = "</Workbook>"
        Dim rowCount As Integer = 0
        Dim sheetCount As Integer = 1
        excelDoc.Write(startExcelXML)
        excelDoc.Write("<Worksheet ss:Name=""Hoja" & sheetCount & """>")
        excelDoc.Write("<Table>")
        excelDoc.Write("<Row>")
        Dim intx As Integer = 0
        While intx < dtDatos.Columns.Count
            excelDoc.Write("<Cell ss:StyleID=""BoldColumn""><Data ss:Type=""String"">")
            excelDoc.Write(dtDatos.Columns(intx).ColumnName)
            excelDoc.Write("</Data></Cell>")
            System.Math.Min(System.Threading.Interlocked.Increment(intx), intx - 1)
        End While
        excelDoc.Write("</Row>")
        For Each x As DataRow In dtDatos.Rows
            System.Math.Min(System.Threading.Interlocked.Increment(rowCount), rowCount - 1)
            excelDoc.Write("<Row>")
            Dim y As Integer = 0
            While y < dtDatos.Columns.Count
                Dim rowType As System.Type
                rowType = x(y).GetType
                Select Case rowType.ToString
                    Case "System.String"
                        Dim XMLstring As String = x(y).ToString
                        XMLstring = XMLstring.Trim
                        XMLstring = XMLstring.Replace("&", "&")
                        XMLstring = XMLstring.Replace(">", ">")
                        XMLstring = XMLstring.Replace("<", "<")
                        excelDoc.Write("<Cell ss:StyleID=""StringLiteral"">" + "<Data ss:Type=""String"">")
                        excelDoc.Write(XMLstring)
                        excelDoc.Write("</Data></Cell>")
                    Case "System.DateTime"
                        Dim XMLDate As DateTime = CType(x(y), DateTime)
                        Dim XMLDatetoString As String = ""
                        XMLDatetoString = XMLDate.Year.ToString + "-" + (Microsoft.VisualBasic.IIf(XMLDate.Month < 10, "0" + XMLDate.Month.ToString, XMLDate.Month.ToString)) + "-" + (Microsoft.VisualBasic.IIf(XMLDate.Day < 10, "0" + XMLDate.Day.ToString, XMLDate.Day.ToString)) + "T" + (Microsoft.VisualBasic.IIf(XMLDate.Hour < 10, "0" + XMLDate.Hour.ToString, XMLDate.Hour.ToString)) + ":" + (Microsoft.VisualBasic.IIf(XMLDate.Minute < 10, "0" + XMLDate.Minute.ToString, XMLDate.Minute.ToString)) + ":" + (Microsoft.VisualBasic.IIf(XMLDate.Second < 10, "0" + XMLDate.Second.ToString, XMLDate.Second.ToString)) + ".000"
                        excelDoc.Write("<Cell ss:StyleID=""DateLiteral"">" + "<Data ss:Type=""DateTime"">")
                        excelDoc.Write(XMLDatetoString)
                        excelDoc.Write("</Data></Cell>")
                    Case "System.Boolean"
                        excelDoc.Write("<Cell ss:StyleID=""StringLiteral"">" + "<Data ss:Type=""String"">")
                        excelDoc.Write(x(y).ToString)
                        excelDoc.Write("</Data></Cell>")
                    Case "System.Int16", "System.Int32", "System.Int64", "System.Byte"
                        excelDoc.Write("<Cell ss:StyleID=""Integer"">" + "<Data ss:Type=""Number"">")
                        excelDoc.Write(x(y).ToString)
                        excelDoc.Write("</Data></Cell>")
                    Case "System.Decimal", "System.Double"
                        excelDoc.Write("<Cell ss:StyleID=""Decimal"">" + "<Data ss:Type=""Number"">")
                        excelDoc.Write(x(y).ToString)
                        excelDoc.Write("</Data></Cell>")
                    Case "System.DBNull"
                        excelDoc.Write("<Cell ss:StyleID=""StringLiteral"">" + "<Data ss:Type=""String"">")
                        excelDoc.Write("")
                        excelDoc.Write("</Data></Cell>")
                    Case Else
                        Throw (New Exception(rowType.ToString + " not handled."))
                End Select
                System.Math.Min(System.Threading.Interlocked.Increment(y), y - 1)
            End While
            excelDoc.Write("</Row>")
        Next
        excelDoc.Write("</Table>")
        excelDoc.Write(" </Worksheet>")
        excelDoc.Write(endExcelXML)
        excelDoc.Close()
    End Sub

    Public Shared Function CreaRuta(ByVal Ruta As String) As String
        'esta funcion crea una ruta especificada, los métodos normales
        'sólo crean el último nombre de carpeta pero si no existe la ruta
        'anterior esto falla, esta funcion creara toda la ruta que se le
        'especifique. hace uso de la función oconv, por lo que deberá estar
        'con el modulo utilitario.
        Dim res As String = ""
        Try
            Dim unidad As String, FolderL As String

            If Mid(Ruta, 1, 2) = "\\" Then 'es en red
                Ruta = Mid(Ruta, 3, Len(Ruta))
                unidad = "\\" & stiSplit(Ruta, "G0\1") & "\"
                Ruta = stiSplit(Ruta, "G1\100")
            Else 'es local
                If Mid(Ruta, 2, 2) <> ":\" Then Throw New Exception("Ruta inválida.")
                unidad = Mid(Ruta, 1, 3)
                Ruta = Mid(Ruta, 4, Len(Ruta))
            End If

            While Ruta <> ""
                FolderL = unidad & stiSplit(Ruta, "G0\1") & "\"
                If Not System.IO.Directory.Exists(FolderL) Then
                    'no existe la ruta y hay que hacerla
                    System.IO.Directory.CreateDirectory(FolderL)
                End If
                unidad = unidad & stiSplit(Ruta, "G0\1") & "\"
                Ruta = stiSplit(Ruta, "G1\100")
            End While

        Catch ex As Exception
            res = ex.Message
        End Try
        Return res
    End Function

    Public Shared Function CastToString(ByVal Elemento As Object) As String
        Dim res As String = ""
        Try
            res = CStr(Elemento)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

#End Region

#Region "Rutinar Ornedamiento DXGrid"

    Public Shared Function OrdenarMes(ByVal Mes As String) As Integer
        Dim Orden As Integer = 0
        Select Case Mes.Trim.ToUpper
            Case "ENERO", "ENE", "JANUARY", "JAN" : Orden = 1
            Case "FEBRERO", "FEB", "FEBRUARY", "FEB" : Orden = 2
            Case "MARZO", "MAR", "MARCH" : Orden = 3
            Case "ABRIL", "ABR", "APRIL", "APR" : Orden = 4
            Case "MAYO", "MAY" : Orden = 5
            Case "JUNIO", "JUN", "JUNE" : Orden = 6
            Case "JULIO", "JUL", "JULY" : Orden = 7
            Case "AGOSTO", "AGO", "AUGUST", "AUG" : Orden = 8
            Case "SEPTIEMBRE", "SEP", "SEPTEMBER" : Orden = 9
            Case "OCTUBRE", "OCT", "OCTOBER" : Orden = 10
            Case "NOVIEMBRE", "NOV", "NOVEMBER" : Orden = 11
            Case "DICIEMBRE", "DIC", "DECEMBER", "DEC" : Orden = 12
            Case Else : Orden = Mes.GetHashCode
        End Select
        Return Orden
    End Function

#End Region

#Region "Parámetros"
    Public Shared tblParametros As Data.DataTable

    Public Shared Function CargarParametros() As String
        Dim res As String = ""
        Try
            tblParametros = New DataTable
            tblParametros.Columns.Add("num", System.Type.GetType("System.Int32"))
            tblParametros.Columns.Add("nombre", System.Type.GetType("System.String"))
            tblParametros.Columns.Add("valor", System.Type.GetType("System.String"))
            tblParametros.Columns.Add("tipo", System.Type.GetType("System.String"))

            Dim Archivo As System.IO.StreamReader
            Dim FilaP As DataRow
            Dim Linea As String = "", num As Integer = 0, nombre As String = "", valor As String = "", tipo As String = ""

            Archivo = System.IO.File.OpenText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\sisco.ini")
            While Archivo.EndOfStream = False
                Linea = Archivo.ReadLine.Trim
                num += 1
                If Linea = "" Then
                    nombre = ""
                    valor = ""
                    tipo = "BLANK"
                Else
                    If InStr(Linea, "[") > 0 Then
                        nombre = Linea
                        valor = ""
                        tipo = "GRUPO"
                    Else
                        nombre = Utilerias.Genericas.stiSplit(Linea, "G0=1").Trim
                        valor = Mid(Utilerias.Genericas.stiSplit(Linea, "G1=999"), 2)
                        tipo = "PARAMETRO"
                    End If
                End If
                FilaP = tblParametros.NewRow
                FilaP("num") = num
                FilaP("nombre") = nombre
                FilaP("valor") = valor
                FilaP("tipo") = tipo
                tblParametros.Rows.Add(FilaP)
            End While
            Archivo.Close()
        Catch ex As Exception
            res = ex.Message
        End Try
        Return res
    End Function

    Public Shared Function GuardarParametros() As String
        Dim res As String = ""
        Try
            Dim Archivo As System.IO.StreamWriter
            Dim FilaP As DataRow
            Dim Linea As String = ""

            Archivo = System.IO.File.CreateText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\sisco.ini")
            ''para guardar los parametros en orden
            Dim Lineas As DataRow() = tblParametros.Select("num >= 0", "num")
            For Each FilaP In Lineas
                Select Case FilaP("tipo")
                    Case "BLANK"
                        Archivo.WriteLine("")
                    Case "GRUPO"
                        Archivo.WriteLine(FilaP("nombre"))
                    Case "PARAMETRO"
                        Archivo.WriteLine(FilaP("nombre") & " = " & FilaP("valor"))
                End Select
            Next
            Archivo.Close()
        Catch ex As Exception
            res = ex.Message
        End Try

        Return res
    End Function

    Public Shared Function ObtenerParametro(ByVal id As String) As String
        Dim res As String = ""
        Try
            res = tblParametros.Select("nombre=" & "'" & id & "'")(0).Item("valor")
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Shared Function ObtenerParametrosSimilares(ByVal id As String) As System.Data.DataRow()
        Dim res As System.Data.DataRow() = Nothing
        Try
            res = tblParametros.Select("nombre like " & "'%" & id & "%'")
        Catch ex As Exception
            res = Nothing
        End Try
        Return res
    End Function

    Public Shared Sub ActualizarParametro(ByVal Id As String, ByVal Valor As String)
        Try
            For Each Fila In tblParametros.Rows
                If CStr(Fila("nombre")).Trim.ToUpper = Id.Trim.ToUpper Then
                    Fila("valor") = Valor
                    Exit Sub
                End If
            Next

        Catch ex As Exception
            'nocontrolamos el error
        End Try
    End Sub

    Public Shared Sub BorrarParametro(ByVal Id As String)
        Try
            For Each Fila In tblParametros.Rows
                If CStr(Fila("nombre")).Trim.ToUpper = Id.Trim.ToUpper Then
                    tblParametros.Rows.Remove(Fila)
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            'nocontrolamos el error
        End Try
    End Sub

    Public Shared Sub InsertarParametro(ByVal Id As String, ByVal Valor As String, ByVal DespuesDelId As String)
        'primero buscamos el orden del Id
        Dim res As Integer
        Try
            res = tblParametros.Select("nombre=" & "'" & DespuesDelId & "'")(0).Item("num")
            ''insertamos si encontramos despues de cual
            If res > 0 Then
                'movemos en uno los parametros despues de cual deseamos
                Dim Lineas As DataRow() = tblParametros.Select("num > " & res, "num")
                For Each FilaP In Lineas
                    FilaP("num") = Val(FilaP("num")) + 1
                Next
                Dim NewFila As DataRow = tblParametros.NewRow
                NewFila("num") = res + 1
                NewFila("nombre") = Id
                NewFila("valor") = Valor
                NewFila("tipo") = "PARAMETRO"
                tblParametros.Rows.Add(NewFila)
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Public Shared Function ExisteParametro(ByVal id As String) As Boolean
        Dim res As Boolean = False, valor As String = ""
        Try
            valor = tblParametros.Select("nombre=" & "'" & id & "'")(0).Item("nombre")
            If valor = "" Then
                res = False
            Else
                res = True
            End If
        Catch ex As Exception
            res = False
        End Try

        Return res
    End Function

#End Region

#Region "Rutinas Administracion de Hojas de Calculo"



#End Region


End Class
