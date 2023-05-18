
Module Utilerias

    Public MostrandoCalendario As Boolean = False

    Public Structure Fecha
        Dim Dia As Integer
        Dim Mes As Integer
        Dim Año As Integer
    End Structure

    Public Function CambiaMes(ByVal MES As String) As String
        'Convierte los posibles meses del año a un número
        'PARAMETROS:
        '            MES: nombre del mes deseado a convertir en entero
        'SALIDA:
        '           Mes representado en dos dígitos
        '******************************************************************
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

    Public Sub BuscaFechaParcial(ByRef Fecbp As Fecha, ByVal Busqueda As String)
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

    Public Function ConvertirFecha(ByVal Fecha As String, Optional ByVal Formato As String = "Long Date") As String
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
                Else
                    'formato DD/MM/YY o DD/MM/YYYY
                    If A Like "##?##?##" Or A Like "##?##?####" Then
                        'no hacer nada pues el formato es bueno
                        'pero aseguramos que sea caracter /
                        A = Left(A, 2) & s & Mid(A, 4, 2) & s & Mid(A, 7)
                    Else
                        'INTENTAMOS FORMATO DD/MMM/YYYY
                        If A Like "##???##" Or A Like "##?????##" Or A Like "##?????####" Or A Like "##???####" Then
                            If A Like "##???##" Or A Like "##???####" Then A = Left(A, 2) & s & CambiaMes(Mid(A, 3, 3)) & s & Mid(A, 6)
                            If A Like "##?????##" Or A Like "##?????####" Then A = Left(A, 2) & s & CambiaMes(Mid(A, 4, 3)) & s & Mid(A, 8)
                        Else
                            If A Like "##?##?#### ##?##?##*" Then
                                'nos envian la fecha con la hora
                                A = Left(A, 2) & s & Mid(A, 4, 2) & s & Mid(A, 7, 4)
                            Else
                                If A Like "##?????#### ##?##?##*" Then
                                    ''formato con hora
                                    A = Left(A, 2) & s & CambiaMes(Mid(A, 4, 3)) & s & Mid(A, 8, 4) & " " & Mid(A, 13)
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
                                    If FECL.Año = 0 Or FECL.Mes = 0 Or FECL.Dia = 0 Then
                                        'fechas ilejitimas no propondremos
                                        A = ""
                                    Else
                                        A = CStr(DateSerial(FECL.Año, FECL.Mes, FECL.Dia))
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                dummy = Date.Parse(A)
                Return Format(dummy, Formato)
            Else
                Return ""
            End If
        Catch EX As Exception
            Return ""
        End Try
    End Function

    Public Function CuentaCar(ByVal Cadena As String, ByVal CAR As String) As Integer
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

    Public Function stiSplit(ByVal ID As String, ByVal Param As String) As String
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


End Module
