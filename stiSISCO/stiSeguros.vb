Imports Utilerias.Genericas

Public Class stiSeguros
    Private StiGlobalConn As Conectividad.Funciones

    Public Sub New(ByRef Conn As Conectividad.Funciones)
        StiGlobalConn = Conn
    End Sub

    Public Function ObtenerIdCliente() As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select codcliente from Actualizacion where sistema = 'SISCO'").Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenerDBParametros(ByVal IdParametro As String) As Object
        Dim Res As Object = Nothing
        Try
            Dim FilPar As DataRow = StiGlobalConn.ObtenerDataset("select * from Parametros where idparametro = " & dbStr(IdParametro)).Tables(0).Rows(0)
            Select Case dbData(FilPar, "Tipo").Trim.ToUpper
                Case "N"
                    Res = CDbl(dbData(FilPar, "Valor"))
                Case "T", "P"
                    Res = CStr(dbData(FilPar, "Cadena"))
                Case "E"
                    Res = CInt(dbData(FilPar, "Entero"))
                Case "F"
                    Res = CDate(dbData(FilPar, "Fecha"))
            End Select
        Catch ex As Exception
            Res = Nothing
        End Try
        Return Res
    End Function

    Public Function ActualizarDBParametros(ByVal IdParametro As String, ByVal Valor As Object) As String
        Dim Res As String = ""
        Try
            Dim FilPar As DataRow = StiGlobalConn.ObtenerDataset("select * from Parametros where idparametro = " & dbStr(IdParametro)).Tables(0).Rows(0)
            Select Case dbData(FilPar, "Tipo").Trim.ToUpper
                Case "N"
                    StiGlobalConn.SQLExecute("update Parametros set Valor = " & dbNum(Valor) & " where idparametro = " & dbStr(IdParametro))
                Case "T"
                    StiGlobalConn.SQLExecute("update Parametros set Cadena = " & dbStr(Valor) & " where idparametro = " & dbStr(IdParametro))
                Case "E"
                    StiGlobalConn.SQLExecute("update Parametros set Entero = " & dbInt(Valor) & " where idparametro = " & dbStr(IdParametro))
                Case "F"
                    StiGlobalConn.SQLExecute("update Parametros set Fecha = " & dbFec(Valor) & " where idparametro = " & dbStr(IdParametro))
            End Select
        Catch ex As Exception
            Res = "No es posible actualizar el parámetro:" & ex.Message
        End Try
        Return Res
    End Function

    Public Function ObtenerID(ByVal Clave As String, Optional ByVal EstaEnTransaccion As Boolean = False) As Integer
        'lo primero que hacemos es verificar si la clave existe, sino la creamos con valor cero
        Dim Datos As Data.DataSet, ID As Integer = -1
        Try
            If EstaEnTransaccion = False Then
                StiGlobalConn.SQLExecute("SET TRANSACTION ISOLATION LEVEL SERIALIZABLE")
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
            End If
            
            'BLOQUEREMOS TEMPORALMENTE LA TABLA DE PARAMETROS
            Datos = StiGlobalConn.ObtenerDataset("Select * from Parametros WITH (XLOCK) where idparametro = " & dbStr(Clave))
            If Datos.Tables(0).Rows.Count > 0 Then
                ID = CInt(Datos.Tables(0).Rows(0).Item("Entero"))
            Else
                'no exite lo creamos
                ID = 0
                StiGlobalConn.SQLExecute("insert into Parametros (idparametro,Entero,Tipo) values(" & dbStr(Clave) & C & dbInt(ID) & C & dbStr("E") & ")")
            End If
            ID += 1
            StiGlobalConn.SQLExecute("update Parametros set Entero = " & dbInt(ID) & " where idparametro = " & dbStr(Clave))
            If EstaEnTransaccion = False Then StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            Return ID
        Catch ex As Exception
            'en caso de error se retorna -1
            If EstaEnTransaccion = False Then StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            Return -1
        End Try
    End Function

    Public Function ObtenerIDTabla(ByVal Tabla As String, ByVal Campo As String, Optional ByVal Condicion As String = "") As Integer
        'obtendremos el siguiente id de una tabla.
        Dim ID As Integer = -1
        If Condicion <> "" Then Condicion = " where " & Condicion
        Try
            ID = StiGlobalConn.ObtenerDataset("select isnull(max(" & Campo & "),0) from " & Tabla & Condicion).Tables(0).Rows(0).Item(0)
            ID += 1
        Catch ex As Exception
            ID = -1
        End Try
        Return ID
    End Function

    Public Function ObtenerFechaServidor() As DateTime
        'esta funcion retornará la fecha que tiene el servidor en el momento de ejecución
        Dim TMP As Data.DataSet = StiGlobalConn.ObtenerDataset("select getdate() as Now "), Res As DateTime
        Try
            Res = CDate(dbData(TMP.Tables(0).Rows(0), "Now"))
        Catch ex As Exception
            'si existe algun error retornará la fecha del equipo en uso
            Res = Date.Now
        End Try
        Return Res
    End Function

    Public Function ObtenerIdCiudad(ByVal Ciudad As String) As String
        Dim res As String = ""
        If Ciudad.Trim <> "" Then
            Try
                Ciudad = Trim(Ciudad)
                'intentamos si nos han mandado el código
                Try
                    res = StiGlobalConn.ObtenerDataset("select idciudad from ciudades where idciudad = " & dbStr(Ciudad)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    res = ""
                End Try
                'intentaremos por nombre completo
                If res = "" Then
                    Try
                        res = StiGlobalConn.ObtenerDataset("select idciudad from ciudades where NombreCiudad = " & dbStr(Ciudad)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        res = ""
                    End Try
                End If
                'intentaremos por nombre similar
                If res = "" Then
                    Try
                        res = StiGlobalConn.ObtenerDataset("select idaseguradora from idciudad where NombreCiudad like " & dbStr("%" & Ciudad & "%")).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        res = ""
                    End Try
                End If

                'finalmente por nombres parciales
                If res = "" Then
                    Dim NumP As Integer = CuentaCar(Ciudad, " ") + 1
                    For NP As Integer = NumP - 1 To 1 Step -1
                        res = stiSplit(Ciudad, "G0 " & NP)
                        Try
                            res = StiGlobalConn.ObtenerDataset("select idciudad from ciudades where NombreCiudad like " & dbStr("%" & res & "%")).Tables(0).Rows(0).Item(0)
                            Exit For
                        Catch ex As Exception
                            res = ""
                        End Try
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
        Return res
    End Function

    Public Function ObtenerHorasTrascurridas(ByVal Inicio As DateTime, ByVal Final As DateTime) As Double
        Dim res As Double = 0
        If Final > Inicio Then
            res = (DateDiff(DateInterval.Minute, Inicio, Final) / 60)
        End If
        Return res
    End Function

    Public Function ObtenerHorasLaborales(ByVal Inicio As DateTime, ByVal Final As DateTime) As Double
        'la funcion retorna las horas entre dos fechas, sin contar domingos, sábados de 8-12
        'solo de 8-5 sin contar una hora del almuerzo
        Dim res As Double = 0, Acumular As Boolean
        'lo que haremos es contar minutos y los dividimos con 60
        While Inicio < Final
            Acumular = True
            ''descartamos algunos feriados conocidos
            Select Case Inicio.Month
                Case 1
                    If Inicio.Day = 1 Then Acumular = False
                Case 5
                    If Inicio.Day = 1 Then Acumular = False
                Case 8
                    If Inicio.Day = 5 Or Inicio.Day = 6 Then Acumular = False
                Case 9
                    If Inicio.Day = 15 Then Acumular = False
                Case 11
                    If Inicio.Day = 2 Then Acumular = False
                Case 12
                    If Inicio.Day = 25 Then Acumular = False
            End Select

            Select Case Inicio.DayOfWeek
                Case DayOfWeek.Sunday
                    Acumular = False
                Case DayOfWeek.Saturday
                    If Not (Inicio.Hour >= 8 And Inicio.Hour <= 11) Then Acumular = False
                Case Else
                    If Not ((Inicio.Hour >= 8 And Inicio.Hour <= 11) Or (Inicio.Hour >= 13 And Inicio.Hour <= 16)) Then Acumular = False
            End Select
            If Acumular = True Then res += 1
            Inicio = Inicio.AddMinutes(1)
        End While
        Return (res / 60)
    End Function

    Public Function ProcesarNotificaciones(ByVal FechaCorte As DateTime) As String
        Dim res As String = ""
        Try
            Dim Notificaciones As DataTable = StiGlobalConn.ObtenerDataset("select * from Notificaciones where Estado = 'A' ").Tables(0)
            Dim Datos As DataTable, resCorreo As String = "", resQuery As String = "", Archivo As String = ""
            Dim FilNoti As DataRow, FechaUltNoti As DateTime, Dias As Integer = 0, DiaOk As String = ""
            Dim NumCorreos As Integer = 0
            For Each FilNoti In Notificaciones.Rows
                Try
                    Try
                        FechaUltNoti = CDate(dbData(StiGlobalConn.ObtenerDataset("select max(Fecha) as Fecha from NotificacionesLog where IdNotificacion = " & dbStr(dbData(FilNoti, "IdNotificacion"))).Tables(0).Rows(0), "Fecha"))
                    Catch ex As Exception
                        FechaUltNoti = Date.Today.AddDays(-30)
                    End Try
                    If FechaUltNoti = Nothing Then FechaUltNoti = Date.Today.AddDays(-30)
                    Dias = Math.Abs(DateDiff(DateInterval.Day, FechaUltNoti, FechaCorte))
                    DiaOk = ""
                    resQuery = ""
                    Archivo = ""
                    'validamos la frecuencias
                    If Dias >= CInt(dbData(FilNoti, "FrecuenciaNotificacion")) Then
                        'validamos que el día sea el correcto
                        Select Case FechaCorte.DayOfWeek
                            Case DayOfWeek.Monday : If dbData(FilNoti, "NotificarLunes").Trim.ToUpper = "S" Then DiaOk = "S"
                            Case DayOfWeek.Tuesday : If dbData(FilNoti, "NotificarMartes").Trim.ToUpper = "S" Then DiaOk = "S"
                            Case DayOfWeek.Wednesday : If dbData(FilNoti, "NotificarMiercoles").Trim.ToUpper = "S" Then DiaOk = "S"
                            Case DayOfWeek.Thursday : If dbData(FilNoti, "NotificarJueves").Trim.ToUpper = "S" Then DiaOk = "S"
                            Case DayOfWeek.Friday : If dbData(FilNoti, "NotificarViernes").Trim.ToUpper = "S" Then DiaOk = "S"
                            Case DayOfWeek.Saturday : If dbData(FilNoti, "NotificarSabado").Trim.ToUpper = "S" Then DiaOk = "S"
                            Case DayOfWeek.Sunday : If dbData(FilNoti, "NotificarDomingo").Trim.ToUpper = "S" Then DiaOk = "S"
                        End Select
                        If DiaOk <> "" Then
                            If dbData(FilNoti, "CorreoDestinatarios") <> "" Then
                                'la notificación se procesa en excel y se manda al destinatario.
                                'preparamos los datos
                                Datos = StiGlobalConn.ObtenerDataset(dbData(FilNoti, "FormulaNotificacion")).Tables(0)
                                resQuery = "Resultado de la notificación: "
                                If Datos.Rows.Count = 0 Then
                                    resQuery &= "No se encontraron registros."
                                Else
                                    resQuery &= "Los registros de la notificación los encontrará en el documento adjunto."
                                    Archivo = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Notificacion" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
                                    DataTableAExcel(Datos, Archivo)
                                End If
                                resCorreo = EnviarCorreoNotificaciones(dbData(FilNoti, "CorreoDestinatarios"), "", "", "Notificación Automática SISCO", "Este es un correo de notificación automática de SISCO referente a:" & vbCrLf & vbCrLf & dbData(FilNoti, "Descripcion") & vbCrLf & vbCrLf & resQuery, False, Archivo)
                                If resCorreo <> "" Then res &= resCorreo & vbCrLf

                                'registraremos un log de notificacion
                                StiGlobalConn.SQLExecute("insert into NotificacionesLog (IdNotificacion, Fecha, Resultado) values (" & dbStr(dbData(FilNoti, "IdNotificacion"), 25) & C & dbFec(Date.Now, "1") & C & dbStr(dbData(FilNoti, "Descripcion") & vbCrLf & "Destinatarios: " & dbData(FilNoti, "CorreoDestinatarios") & vbCrLf & resQuery & vbCrLf & res) & ")")
                            Else
                                'la formula del sql dará los parámetros del correo
                                Datos = StiGlobalConn.ObtenerDataset(dbData(FilNoti, "FormulaNotificacion")).Tables(0)
                                resQuery = "Resultado de la notificación: "
                                If Datos.Rows.Count = 0 Then
                                    resQuery &= "No se encontraron registros."
                                Else
                                    'cada fila de resultados es un correo
                                    Dim FilCorreo As DataRow, strAsunto As String = ""
                                    NumCorreos = 0
                                    For Each FilCorreo In Datos.Rows
                                        res = ""
                                        If dbData(FilCorreo, "Destinatario") <> "" Then
                                            strAsunto = dbData(FilNoti, "Descripcion")
                                            If dbData(FilCorreo, "Asunto") <> "" Then strAsunto = dbData(FilCorreo, "Asunto")

                                            resCorreo = EnviarCorreoNotificaciones(dbData(FilCorreo, "Destinatario"), "", "", strAsunto, dbData(FilCorreo, "Mensaje"), True)
                                            If resCorreo <> "" Then res &= resCorreo & vbCrLf

                                            'registraremos un log de notificacion
                                            StiGlobalConn.SQLExecute("insert into NotificacionesLog (IdNotificacion, Fecha, Resultado) values (" & dbStr(dbData(FilNoti, "IdNotificacion"), 25) & C & dbFec(Date.Now, "1") & C & dbStr(dbData(FilNoti, "Descripcion") & vbCrLf & "Destinatarios: " & dbData(FilCorreo, "Destinatario") & vbCrLf & res) & ")")
                                        End If
                                        NumCorreos += 1
                                        If Val(dbData(FilNoti, "MaxCorreos")) > 0 And Val(dbData(FilNoti, "MaxHoras")) > 0 Then
                                            If NumCorreos >= Val(dbData(FilNoti, "MaxCorreos")) Then
                                                NumCorreos = 0
                                                Call System.Threading.Thread.Sleep(3600 * Val(dbData(FilNoti, "MaxHoras")) * 1000)
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    res &= "Notificación: " & dbData(FilNoti, "IdNotificacion") & " " & ex.ToString & vbCrLf
                End Try
            Next
        Catch ex As Exception
            res &= ex.ToString & vbCrLf
        End Try
        Return res
    End Function

    Public Function EnviarCorreoNotificaciones(ByVal Destinatarios As String, ByVal DestinatariosCopia As String, ByVal DestinatariosOculto As String, ByVal Asunto As String, ByVal Mensaje As String, ByVal EsHTML As Boolean, ByVal ParamArray Attachment() As String) As String
        Dim res As String = ""
        Try
            'del usuario en curso obtenemos el nombre y el correo.
            Dim CorreoUsuario As String = ""
            CorreoUsuario = ObtenerDBParametros("Correo.Cuenta")
            Dim CorreoDestino As String = Destinatarios
            Dim CorreoCopia As String = DestinatariosCopia
            Dim CorreoOculto As String = DestinatariosOculto

            If CorreoDestino.Trim = "" And CorreoCopia.Trim = "" Then
                'sin correos destino no se hace nada
                Return "No hay destinatarios de correo"
            End If

            Dim NumCorreos As Integer = 0
            Dim Correo As String = ""
            Dim msg As New System.Net.Mail.MailMessage
            Dim Destino As New System.Net.Mail.MailAddress(CorreoUsuario)
            msg.From = Destino

            'tenemos que armar una lista con los correos
            If CorreoDestino.Trim <> "" Then
                CorreoDestino = Replace(CorreoDestino, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoDestino, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoDestino, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.To.Add(Correo)
                    End If
                Next
            End If

            'ahora veremos si hay copia a alguien
            If CorreoCopia.Trim <> "" Then
                CorreoCopia = Replace(CorreoCopia, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoCopia, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoCopia, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.CC.Add(Correo)
                    End If
                Next
            End If

            'veremos si hay copia oculta
            If CorreoOculto.Trim <> "" Then
                CorreoOculto = Replace(CorreoOculto, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoOculto, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoOculto, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.Bcc.Add(Correo)
                    End If
                Next
            End If


            For I As Integer = 0 To Attachment.GetLength(0) - 1
                If Not Attachment(I) Is Nothing Then
                    If Attachment(I) <> "" And Dir(Attachment(I)) <> "" Then
                        'si hay error en el archivo se pasa por alto
                        Try
                            msg.Attachments.Add(New System.Net.Mail.Attachment(Attachment(I)))
                        Catch ex As Exception

                        End Try
                    End If
                End If
            Next
            msg.Subject = Asunto
            msg.IsBodyHtml = EsHTML
            msg.Body = Mensaje
            msg.Priority = Net.Mail.MailPriority.Normal
            Dim SMTPServer As String = ObtenerDBParametros("Correo.Servidor")
            If SMTPServer.Trim = "" Then
                'MsgBox("No se ha definido el servidor de correo en el sistema. Verifique los parámetros.", MsgBoxStyle.Information, "AVISO...")
                Return "No se ha definido servidor de correo"
            End If
            Dim EmailServer As New System.Net.Mail.SmtpClient(SMTPServer)

            EmailServer.Credentials = New System.Net.NetworkCredential(ObtenerDBParametros("Correo.Cuenta"), ObtenerDBParametros("Correo.Password"))


            If ObtenerDBParametros("Correo.SSL").ToString.Trim.ToUpper = "S" Then
                EmailServer.EnableSsl = True
            End If

            If ObtenerDBParametros("Correo.Puerto").ToString.Trim.ToUpper <> "" Then
                EmailServer.Port = CInt(ObtenerDBParametros("Correo.Puerto").ToString.Trim.ToUpper)
            End If

            EmailServer.Send(msg)
        Catch ex As Exception
            res = ex.ToString
        End Try
        Return res
    End Function

    Public Function ObtenerVersion() As String
        Dim res As String = ""
        Try
            Dim FilVersion As DataRow = StiGlobalConn.ObtenerDataset("select Autorizacion, CodCliente from Actualizacion where Sistema = 'SISCO'").Tables(0).Rows(0)
            Dim ClaveActual As String = DESDecrypt2(dbData(FilVersion, "Autorizacion"), "S$10" & dbData(FilVersion, "CodCliente").Trim.ToUpper)
            res = ClaveActual.Trim.ToUpper
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenerEjecutivoCuenta(ByVal IdCliente As String, ByVal IdProducto As String, ByVal IdArea As String) As String
        Dim res As String = ""
        Try
            'tratamos de determinar quien atiende al cliente
            Dim sql As String = ""

            sql &= " select "
            sql &= " isnull((select top 1 IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = c.idcliente and IdRamo = (select top 1 idramo from productos where idproducto = " & dbStr(IdProducto) & " ) and  TipoProducto = (select top 1 TipoProducto from productos where idproducto = " & dbStr(IdProducto) & ") and IdArea = " & dbStr(IdArea) & " order by orden)"
            sql &= " , isnull((select top 1 IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = c.idcliente and (IdRamo is null or  IdRamo = (select top 1 idramo from productos where idproducto = " & dbStr(IdProducto) & ")) and  TipoProducto = (select top 1 TipoProducto from productos where idproducto = " & dbStr(IdProducto) & ") and IdArea =  " & dbStr(IdArea) & "  order by orden)"
            sql &= " ,isnull((select top 1 IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = c.idcliente and (IdRamo is null or IdRamo = (select top 1 idramo from productos where idproducto = " & dbStr(IdProducto) & " )) and (TipoProducto is null or TipoProducto = (select top 1 TipoProducto from productos where idproducto = " & dbStr(IdProducto) & ")) and IdArea =  " & dbStr(IdArea) & "  order by orden)"
            sql &= " ,isnull((select top 1 IdEjecutivo from ClientesEjecutivos as ce where ce.idcliente = c.idcliente and (IdRamo is null or IdRamo = (select top 1 idramo from productos where idproducto = " & dbStr(IdProducto) & " )) and (TipoProducto is null or TipoProducto = (select top 1 TipoProducto from productos where idproducto = " & dbStr(IdProducto) & ")) and (IdArea is null or IdArea =  " & dbStr(IdArea) & ") order by orden)"
            sql &= " ,isnull(c.EjecutivoCta,''))))) "
            sql &= " as Ejecutivo"
            sql &= " from Clientes as c "
            sql &= " where c.IdCliente = " & dbStr(IdCliente)



            ''sql = "  select "
            ''sql &= " isnull("
            ''sql &= " ( "
            ''sql &= " select top 1 IdEjecutivo from ClientesEjecutivos as ce"
            ''sql &= " where ce.idcliente = c.idcliente"
            ''sql &= " and ("
            ''sql &= " IdRamo = (select top 1 idramo from productos where idproducto = " & dbStr(IdProducto) & ")"
            ''sql &= " or TipoProducto = (select top 1 TipoProducto from productos where idproducto = " & dbStr(IdProducto) & ")"
            ''sql &= " or IdArea = " & dbStr(IdArea)
            ''sql &= " )"
            ''sql &= " order by orden "
            ''sql &= " )"
            ''sql &= " , isnull(c.EjecutivoCta,'')) as Ejecutivo"
            ''sql &= " from Clientes as c"
            ''sql &= " where c.IdCliente = " & dbStr(IdCliente)

            res = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function EliminarPoliza(ByVal IdProducto As String, ByVal IdPoliza As String) As String
        Dim res As String = ""
        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Dim filtro As String = " where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto)

            StiGlobalConn.SQLExecute("delete from PolizasBeneficiarios " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasBienes " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasCesiones" & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasCoberturas " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasCoberturasAdicional " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasCertificados " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasClausulas " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasDocumentos " & filtro)
            StiGlobalConn.SQLExecute("delete from PolizasVendedores " & filtro)
            StiGlobalConn.SQLExecute("delete from Polizas " & filtro)

            StiGlobalConn.SQLExecute("delete from HPolizasBeneficiarios " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasBienes " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasCesiones" & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasCoberturas " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasCoberturasAdicional " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasCertificados " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasClausulas " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasDocumentos " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizasVendedores " & filtro)
            StiGlobalConn.SQLExecute("delete from HPolizas " & filtro)

            RegistrarLog("E", "Polizas", filtro)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            res = ex.Message
        End Try
        Return res
    End Function

    Public Function EliminarFactura(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal NumeroFactura As Integer, ByVal IdRamo As String) As String
        Dim res As String = ""
        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Dim filtro As String = " where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & " and numerofactura = " & dbInt(NumeroFactura) & " and idramo = " & dbStr(IdRamo)

            StiGlobalConn.SQLExecute("delete from FacturasMovimientos " & filtro)
            StiGlobalConn.SQLExecute("delete from Facturas " & filtro)

            RegistrarLog("E", "Facturas", filtro)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            res = ex.Message
        End Try
        Return res
    End Function

    Public Function EliminarSiniestro(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdSiniestro As String, ByVal IdCertificado As String) As String
        Dim res As String = ""
        Try

            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Dim filtro As String = " where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & " and IdSiniestro = " & dbStr(IdSiniestro) & " and IdCertificado = " & dbStr(IdCertificado)
            StiGlobalConn.SQLExecute("delete from SiniestrosReservas " & filtro)
            StiGlobalConn.SQLExecute("delete from SiniestrosRequisitos " & filtro)
            StiGlobalConn.SQLExecute("delete from SiniestrosPagos " & filtro)
            StiGlobalConn.SQLExecute("delete from SiniestrosInformacion " & filtro)
            StiGlobalConn.SQLExecute("delete from SiniestrosDocumentos " & filtro)
            StiGlobalConn.SQLExecute("delete from SiniestrosDeudores " & filtro)
            StiGlobalConn.SQLExecute("delete from SiniestrosDetalle " & filtro)
            StiGlobalConn.SQLExecute("delete from Siniestros " & filtro)

            RegistrarLog("E", "Siniestros", filtro)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            res = ex.Message
        End Try
        Return res
    End Function

    Private Sub RegistrarLog(ByVal Accion As String, ByVal Tabla As String, ByVal Claves As String)
        Try
            Dim sql As String = ""
            sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
            sql &= dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr(Accion, 1) & C & dbStr(Tabla, 25) & C & dbStr(Claves, 150) & ")"
            StiGlobalConn.SQLExecute(sql)
        Catch ex As Exception

        End Try
    End Sub

    Public Function RegistrarHistorioPoliza(ByVal Idpoliza As String, ByVal IdProducto As String) As String
        Dim res As String = ""
        Dim IdHistorico As Integer = 0
        Dim sql As String = ""
        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION HIS")

            IdHistorico = StiGlobalConn.ObtenerDataset("select isnull(max(idhistorico),0) from HPolizas where IdPoliza = " & dbStr(Idpoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            IdHistorico += 1

            'registraremos la póliza
            sql = "  insert into HPolizas (IdHistorico, IdPoliza, IdProducto, IdCliente, NombreCliente, VigenciaDesde, VigenciaHasta, EstadoPoliza, MotivoCancelacion, FechaCancelacion, IdVendedor, PorceComision, NumVigencia, Origen, FechaVinculacion, Departamento, idcancelacion, FechaEnvioAnexo, EjecutivoCta, IdPolizaSustituida, ObservacionSiniestro, TipoDeducible, NegocioPor, TipoPoliza, UsuarioModificaVendedores, FechaModificaVendedores, IdFormaPago, IdOferta, TarjetaHabiente, NumeroTarjeta, VencimientoTarjeta, EmisorTarjeta, IdTipoPago, EnvioFactura, IdBanco, NombreCuentaHabiente, CuentaBancaria, FechaRecepcion)"
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCliente, NombreCliente, VigenciaDesde, VigenciaHasta, EstadoPoliza, MotivoCancelacion, FechaCancelacion, IdVendedor, PorceComision, NumVigencia, Origen, FechaVinculacion, Departamento, idcancelacion, FechaEnvioAnexo, EjecutivoCta, IdPolizaSustituida, ObservacionSiniestro, TipoDeducible, NegocioPor, TipoPoliza, UsuarioModificaVendedores, FechaModificaVendedores, IdFormaPago, IdOferta, TarjetaHabiente, NumeroTarjeta, VencimientoTarjeta, EmisorTarjeta, IdTipoPago, EnvioFactura, IdBanco, NombreCuentaHabiente, CuentaBancaria, FechaRecepcion"
            sql &= " from Polizas "
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasClausulas (IdHistorico, IdPoliza, IdProducto, IdClausula, Clausula, Categoria, CodigoInterno, SumaAsegurada, Deducible, Participacion)"
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdClausula, Clausula, Categoria, CodigoInterno, SumaAsegurada, Deducible, Participacion "
            sql &= " from PolizasClausulas"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasDocumentos (IdHistorico, IdPoliza, IdProducto, IdDocumento, Documento) "
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdDocumento, Documento "
            sql &= " from PolizasDocumentos"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasVendedores (IdHistorico, IdPoliza, IdProducto, Orden, IdVendedor, IdTipoVendedor, FechaEfectiva) "
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, Orden, IdVendedor, IdTipoVendedor, FechaEfectiva "
            sql &= " from PolizasVendedores"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            'ahora el certificado

            sql = "  insert into HPolizasCertificados (IdHistorico, IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, IdVendedor, UsuarioModifica, FechaModifica, Deducible, Participacion, PorceDescuento, ValorDescuento, PrimaBruta,IdPlan, PorceDepreciacion, IdCertificadoAseguradora, PrimaExenta, PrimaMinima) "
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, IdVendedor, UsuarioModifica, FechaModifica, Deducible, Participacion, PorceDescuento, ValorDescuento, PrimaBruta, IdPlan,PorceDepreciacion, IdCertificadoAseguradora, PrimaExenta, PrimaMinima "
            sql &= " from PolizasCertificados"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasBeneficiarios (IdHistorico, IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje) "
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje "
            sql &= " from PolizasBeneficiarios"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasBienes (IdHistorico, IdPoliza, IdProducto, IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima)"
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima"
            sql &= " from PolizasBienes"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasCesiones (IdHistorico, IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones, Propietario)"
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones, Propietario"
            sql &= " from PolizasCesiones"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasCoberturas (IdHistorico, IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma, Participacion, CoberturaAdicional, AplicarIva,PrimaMinima,PrimaMaxima,DeducibleMinimo,DeducibleMaximo,PorceDeducible,PrimaAnual) "
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma, Participacion, CoberturaAdicional, AplicarIva,PrimaMinima,PrimaMaxima,DeducibleMinimo,DeducibleMaximo,PorceDeducible,PrimaAnual"
            sql &= " from PolizasCoberturas"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            sql = "  insert into HPolizasCoberturasAdicional (IdHistorico, IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion) "
            sql &= " select " & dbInt(IdHistorico) & ", IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion"
            sql &= " from PolizasCoberturasAdicional"
            sql &= " where idpoliza = " & dbStr(Idpoliza) & " and idproducto = " & dbStr(IdProducto)
            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION HIS")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION HIS")
            res &= ex.Message
        End Try
        Return res
    End Function

End Class
