
Imports Utilerias.Genericas

Public Class stiFlujos

    Private StiGlobalConn As Conectividad.Funciones
    Private clSeguros As stiSISCO.stiSeguros

    Public Sub New(ByRef Conn As Conectividad.Funciones)
        StiGlobalConn = Conn
        clSeguros = New stiSISCO.stiSeguros(Conn)
    End Sub

#Region "Gestión de Flujos"

    Public Function IniciarFlujo(ByVal IdUsuarioSolicita As String, ByVal IdUsuarioDestino As String, ByVal IdFlujo As String, ByVal Comentario As String, ByVal IdPoliza As String, ByVal IdProducto As String, ByVal NumeroFactura As String, ByVal IdRamo As String, ByVal IdSiniestro As String, ByVal IdCliente As String, ByVal NombreCliente As String, ByVal IdAseguradora As String, ByVal IdAvisoCobro As String, ByVal IdUbicacion As String, ByVal Direccion As String, ByVal IdCiudad As String, ByVal IdZona As String, Optional ByRef IdNuevoFlujo As String = "", Optional ByRef MensajeError As String = "") As String
        Dim res As String = ""
        Dim sql As String = ""

        If IdFlujo <> "" Then
            Try
                ''iniciaremos un flujo dentro del sistema con las especificaciones proporcionadas
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
                '25/05/2011 pueden haber No. de Flujos por clientes
                '21/06/2011 no es un flujo por cliente son los documentos de los clientes
                Dim FlujoCliente As String = "", PostFlujoCliente As String = "", PreFlujoCliente As String = ""
                'Try
                '    FlujoCliente = dbData(StiGlobalConn.ObtenerDataset("select InicialesFlujo from Clientes where IdCliente = " & dbStr(IdCliente)).Tables(0).Rows(0), "InicialesFlujo").Trim
                '    If FlujoCliente <> "" Then
                '        PostFlujoCliente = "." & FlujoCliente
                '        PreFlujoCliente = FlujoCliente & "-"
                '    End If
                'Catch ex As Exception
                '    FlujoCliente = ""
                '    PostFlujoCliente = ""
                '    PreFlujoCliente = ""
                'End Try

                Dim IdFlujoDoc As String = PreFlujoCliente & clSeguros.ObtenerID("Num.Flujo." & Date.Today.Year.ToString & PostFlujoCliente) & "-" & Date.Today.Year.ToString
                Dim FecInicio As DateTime = clSeguros.ObtenerFechaServidor()

                sql = "  insert into FlujosDocumentos "
                sql &= " (IdFlujoDoc, IdFlujo, Comentario, EstadoFlujo, FechaInicia, FechaFinaliza, "
                sql &= " IdPoliza, IdProducto, NumeroFactura, IdSiniestro, IdCliente, NombreCliente, IdAseguradora, "
                sql &= " IdUbicacion, IdAvisoCobro, IdRamo, IdUsuarioSolicita, IdUsuarioDestino, Direccion, IdCiudad, IdZona) values("
                sql &= dbStr(IdFlujoDoc, 25) & C & dbStr(IdFlujo, 25) & C & dbStr(Comentario) & C & dbStr("PENDIENTE") & C & dbFec(FecInicio, "1") & C & dbFec("") & C
                sql &= dbStr(IdPoliza, 25) & C & dbStr(IdProducto, 25) & C & dbInt(NumeroFactura) & C & dbStr(IdSiniestro, 25) & C & dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 150) & C & dbStr(IdAseguradora, 25) & C
                sql &= dbStr(IdUbicacion) & C & dbStr(IdAvisoCobro, 25) & C & dbStr(IdRamo, 25) & C & dbStr(IdUsuarioSolicita, 25) & C & dbStr(IdUsuarioDestino, 25) & C & dbStr(Direccion, 250) & C & dbStr(IdCiudad, 25) & C & dbStr(IdZona, 25) & ")"
                StiGlobalConn.SQLExecute(sql)

                'ahora incluiremos el paso uno del flujo
                Dim Orden As Integer
                Dim IdPaso As Integer, FilPaso As DataRow = Nothing
                Try
                    Orden = clSeguros.ObtenerIDTabla("FlujosDocumentosPasos", "Orden", "IdFlujoDoc = " & dbStr(IdFlujoDoc, 25) & " and IdFlujo = " & dbStr(IdFlujo, 25))
                Catch ex As Exception
                    Orden = 1
                End Try
                Try
                    IdPaso = StiGlobalConn.ObtenerDataset("select min(IdPaso) from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25)).Tables(0).Rows(0).Item(0)
                    FilPaso = StiGlobalConn.ObtenerDataset("select EsPasoFinal from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso = " & dbInt(IdPaso)).Tables(0).Rows(0)
                Catch ex As Exception
                    IdPaso = -1000
                End Try
                If IdPaso = -1000 Then Throw New Exception("No hay paso inicial para el flujo especificado.")

                sql = "  insert into FlujosDocumentosPasos "
                sql &= " (IdFlujoDoc, IdFlujo, IdPaso, Orden, FechaPaso, ObservacionPaso, UsuarioPaso) values("
                sql &= dbStr(IdFlujoDoc, 25) & C & dbStr(IdFlujo, 25) & C & dbInt(IdPaso) & C & dbInt(Orden) & C & dbFec(FecInicio, "1") & C & dbStr("INICIO") & C & dbStr(StiGlobalConn.User, 25) & ")"
                StiGlobalConn.SQLExecute(sql)

                If dbData(FilPaso, "EsPasoFinal").Trim.ToUpper = "S" Then
                    sql = " update FlujosDocumentos "
                    sql &= " set EstadoFlujo = 'FINALIZADO' "
                    sql &= " , FechaFinaliza = " & dbFec(FecInicio)
                    sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)
                    StiGlobalConn.SQLExecute(sql)
                End If

                StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

                res = "Se ha creado el flujo de trabajo: " & IdFlujoDoc
                IdNuevoFlujo = IdFlujoDoc
            Catch ex As Exception
                StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                res = ex.Message
                MensajeError = res
            End Try
            'Else
            '    res = "No ha especificado el flujo de correspondencia."
        End If
        Return res
    End Function

    Public Function RegistrarDocumento(ByVal IdFlujoDoc As String, ByVal Descripcion As String, ByVal IdCliente As String, ByVal Claves As String, ByVal TipoFlujo As String, ByRef CodCorrespondencia As String, ByVal UsuarioDestino As String, ByVal FechaEnDocumento As DateTime, Optional ByVal Destinatario As String = "", Optional ByVal EstaEnTransaccion As Boolean = False, Optional ByVal NombreAtt As String = "", Optional ByVal EsDocumentoDeCobro As Boolean = False, Optional ByVal DireccionDocumento As String = "", Optional ByVal DocCobroReutilizaCorrelativo As Boolean = False, Optional ByVal ObservacionDocumento As String = "", Optional ByVal CodigoImpresionDocumento As String = "", Optional ByVal NombreAlternoCliente As String = "", Optional ByVal TipoDeDocumento As String = "", Optional ByVal NumeroDeDocumentos As String = "") As String
        Dim res As String = "", sql As String = ""
        Try
            'verificaremos que no estén reimprimiendo el documento
            'Desean que los documentos de cobro no se reutilice el correlativo.
            If EsDocumentoDeCobro = False Or DocCobroReutilizaCorrelativo = True Then


                Dim dtExiste As DataTable = Nothing
                Try
                    dtExiste = StiGlobalConn.ObtenerDataset("select IdFlujoDoc, IdImpresion from FlujosDocumentosImpresiones where IdFlujoDoc = " & dbStr(IdFlujoDoc) & " and cast(claves as varchar(max)) like " & dbStr("%" & Claves & "%", 100) & " and cast(Descripcion as varchar(max)) = " & dbStr(Descripcion & ObservacionDocumento)).Tables(0)
                Catch ex As Exception

                End Try
                If dtExiste.Rows.Count > 0 Then
                    CodCorrespondencia = dbData(dtExiste.Rows(0), "IdImpresion")
                    Call ValidaRuteoAutomatico(dbData(dtExiste.Rows(0), "IdFlujoDoc"), dbData(dtExiste.Rows(0), "IdImpresion"), IdCliente)

                    Return ""
                End If
            End If
        Catch ex As Exception

        End Try
        If CodCorrespondencia Is Nothing Then CodCorrespondencia = ""

        If EsDocumentoDeCobro = True Then
            Dim PrefijoSec As String = clSeguros.ObtenerDBParametros("Prefijo.Cartas")
            If PrefijoSec <> "" Then CodCorrespondencia = PrefijoSec & clSeguros.ObtenerID("Coor.Cartas." & Date.Today.Year) & "-" & Date.Today.Year
        End If

        Try

            If EstaEnTransaccion = False Then StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Dim FlujoCliente As String = "", PostFlujoCliente As String = "", PreFlujoCliente As String = ""
            Dim PrefijoCodigoDocumento As String = ""
            Try
                FlujoCliente = dbData(StiGlobalConn.ObtenerDataset("select InicialesFlujo from Clientes where IdCliente = " & dbStr(IdCliente)).Tables(0).Rows(0), "InicialesFlujo").Trim
                If FlujoCliente <> "" Then
                    PostFlujoCliente = "." & FlujoCliente
                    PreFlujoCliente = FlujoCliente & "-"
                End If
            Catch ex As Exception
                FlujoCliente = ""
                PostFlujoCliente = ""
                PreFlujoCliente = ""
            End Try

            Try
                'una validacion por si se quiere un correlativo por el tipo de documento debe llevar un correlativo.
                If CodigoImpresionDocumento <> "" Then
                    PrefijoCodigoDocumento = CStr(clSeguros.ObtenerDBParametros("Corr.Prefijo." & CodigoImpresionDocumento)).Trim
                End If
            Catch ex As Exception
                PrefijoCodigoDocumento = ""
            End Try

            Dim IdImpresion As String = ""

            If PreFlujoCliente <> "" And CodigoImpresionDocumento <> "SR" And CodigoImpresionDocumento <> "ER" Then PrefijoCodigoDocumento = ""

            If CodCorrespondencia = "" Then
                If TipoFlujo = "ENTRADA" Then
                    IdImpresion = clSeguros.ObtenerID("Num.Flujo.Entrada." & Date.Today.Year.ToString) & "-" & Date.Today.Year.ToString & "-E"
                Else
                    If PrefijoCodigoDocumento <> "" Then
                        IdImpresion = PrefijoCodigoDocumento & clSeguros.ObtenerID("Corr.Id." & Date.Today.Year.ToString & "." & CodigoImpresionDocumento) & "-" & Date.Today.Year.ToString
                    Else
                        IdImpresion = PreFlujoCliente & clSeguros.ObtenerID("Num.Flujo.Imp." & Date.Today.Year.ToString & PostFlujoCliente) & "-" & Date.Today.Year.ToString
                    End If
                End If
                CodCorrespondencia = IdImpresion
            Else
                IdImpresion = CodCorrespondencia
            End If

            Dim FecImp As DateTime = clSeguros.ObtenerFechaServidor()
            If ObservacionDocumento <> "" Then ObservacionDocumento = ", " & ObservacionDocumento

            If CodigoImpresionDocumento = "NCRED" Or CodigoImpresionDocumento = "NABON" Then
                'estos códigos de notas se cambian a varios por que son especiales para generar id pero no se muestran en la lista de documentos a generar.
                CodigoImpresionDocumento = "VA"
            End If

            sql = "  insert into FlujosDocumentosImpresiones "
            sql &= " (IdFlujoDoc, IdImpresion, Descripcion, FechaImpresion, UsuarioImprime, Claves, TipoFlujo, IdDestinatario, FechaEnDocumento, FechaMovimiento, NombreDestinatario, NombreAttDoc, DireccionDocumento, IdOrigen, CodImpresion, TipoDocumento, CantidadDocumentos) values( "
            sql &= dbStr(IdFlujoDoc, 25) & C & dbStr(IdImpresion, 25) & C & dbStr(Descripcion & ObservacionDocumento) & C & dbFec(FecImp, "1") & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(Claves, 100) & C & dbStr(TipoFlujo, 10) & C & dbStr(UsuarioDestino, 50) & C & dbFec(FechaEnDocumento) & C & dbFec(Date.Now, "1") & C & dbStr(Destinatario, 150) & C & dbStr(NombreAtt, 150) & C & dbStr(DireccionDocumento, 250) & C & dbStr(NombreAlternoCliente, 250) & C & dbStr(CodigoImpresionDocumento, 25) & C & dbStr(TipoDeDocumento, 100) & C & dbInt(NumeroDeDocumentos) & ")"
            StiGlobalConn.SQLExecute(sql)

            Call ValidaRuteoAutomatico(IdFlujoDoc, IdImpresion, IdCliente)

            If EstaEnTransaccion = False Then StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
        Catch ex As Exception
            If EstaEnTransaccion = False Then StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Sub ValidaRuteoAutomatico(ByVal IdFlujoDoc As String, ByVal IdImpresion As String, ByVal IdCliente As String)
        'se validará si con el registro del documento se ruteará de forma automática
        Dim sql As String = ""
        Dim UsuarioRuteoAuto As String = clSeguros.ObtenerDBParametros("Usuarios.Ruteo.Automatico")
        If ExisteItemEnLista(StiGlobalConn.User, UsuarioRuteoAuto) = True Then
            Dim ClienteRuteoAuto As String = clSeguros.ObtenerDBParametros("Clientes.Ruteo.Automatico")
            If ExisteItemEnLista(IdCliente, ClienteRuteoAuto) = True Then
                Dim FechaEnvio As DateTime = ObtenerProximaFechaEnvio()
                'ruteamos automático al siguiente turno
                sql = " update FlujosDocumentosImpresiones set "
                sql &= " FechaEnvio = " & dbFec(FechaEnvio)
                If FechaEnvio.Hour < 12 Then
                    sql &= " , IdZona = '1' "
                Else
                    sql &= " , IdZona = '2' "
                End If
                sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25) & " and IdImpresion = " & dbStr(IdImpresion, 25)
                StiGlobalConn.SQLExecute(sql)
            End If
        End If
    End Sub

    Public Function ExisteRuteoAutomatico(ByVal IdCliente As String) As Boolean
        Dim res As Boolean = False
        Dim UsuarioRuteoAuto As String = clSeguros.ObtenerDBParametros("Usuarios.Ruteo.Automatico")
        If ExisteItemEnLista(StiGlobalConn.User, UsuarioRuteoAuto) = True Then
            Dim ClienteRuteoAuto As String = clSeguros.ObtenerDBParametros("Clientes.Ruteo.Automatico")
            If ExisteItemEnLista(IdCliente, ClienteRuteoAuto) = True Then
                res = True
            End If
        End If
        Return res
    End Function

    Public Function ObtenerProximaFechaEnvio() As DateTime
        Dim res As DateTime = Date.Now
        Try
            If res.Hour < 12 Then
                res = New DateTime(res.Year, res.Month, res.Day, 15, 0, 0)
            Else
                res = res.AddDays(1)
                If res.DayOfWeek = DayOfWeek.Saturday Then res.AddDays(2)
                If res.DayOfWeek = DayOfWeek.Sunday Then res.AddDays(1)
                res = New DateTime(res.Year, res.Month, res.Day, 9, 0, 0)
            End If
        Catch ex As Exception

        End Try
        Return res
    End Function


    Public Function ContinuarFlujo(ByVal IdFlujoDoc As String, Optional ByVal IdPaso As Integer = -1, Optional ByVal ObservacionPaso As String = "") As String
        Dim res As String = ""
        Dim sql As String = ""
        Dim IdFlujo As String = ""
        Dim Orden As Integer = -1
        Dim FilPaso As DataRow = Nothing
        Try
            If IdFlujoDoc.Trim <> "" Then
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
                Try
                    IdFlujo = StiGlobalConn.ObtenerDataset("select IdFlujo from FlujosDocumentos where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdFlujo = ""
                End Try
                If IdFlujo.Trim <> "" Then
                    Try
                        Orden = clSeguros.ObtenerIDTabla("FlujosDocumentosPasos", "Orden", "IdFlujoDoc = " & dbStr(IdFlujoDoc, 25) & " and IdFlujo = " & dbStr(IdFlujo, 25))
                    Catch ex As Exception
                        Orden = -1
                    End Try

                    If IdPaso = -1 Then
                        Try
                            'para buscar el siguiente paso, primero verificamos el último paso del flujo actual
                            'y obtenermos el siguiente paso marcado, sino existe paso definido manualmente lo buscamos en orden consecutivo
                            Dim PasoActual As Integer = StiGlobalConn.ObtenerDataset("select top 1 IdPaso from FlujosDocumentosPasos where IdFlujoDoc = " & dbStr(IdFlujoDoc) & " order by Orden desc").Tables(0).Rows(0).Item(0)
                            FilPaso = StiGlobalConn.ObtenerDataset("select IdSiguientePaso from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso = " & dbInt(PasoActual)).Tables(0).Rows(0)
                            If dbData(FilPaso, "IdSiguientePaso") <> "" Then IdPaso = CInt(dbData(FilPaso, "IdSiguientePaso"))
                            If IdPaso = -1 Then
                                FilPaso = StiGlobalConn.ObtenerDataset("select top 1 IdPaso from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso > " & dbInt(PasoActual) & " order by IdPaso asc").Tables(0).Rows(0)
                                IdPaso = CInt(dbData(FilPaso, "IdPaso"))
                            End If
                        Catch ex As Exception
                            IdPaso = -1
                        End Try
                    End If
                    If IdPaso = -1 Then Throw New Exception("No hay paso siguiente para el flujo especificado.")

                    sql = "  insert into FlujosDocumentosPasos "
                    sql &= " (IdFlujoDoc, IdFlujo, IdPaso, Orden, FechaPaso, ObservacionPaso, UsuarioPaso) values("
                    sql &= dbStr(IdFlujoDoc, 25) & C & dbStr(IdFlujo, 25) & C & dbInt(IdPaso) & C & dbInt(Orden) & C & dbFec(Date.Now, "1") & C & dbStr(ObservacionPaso) & C & dbStr(StiGlobalConn.User, 25) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    FilPaso = StiGlobalConn.ObtenerDataset("select EsPasoFinal from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso = " & dbInt(IdPaso)).Tables(0).Rows(0)

                    If dbData(FilPaso, "EsPasoFinal").Trim.ToUpper = "S" Then
                        sql = " update FlujosDocumentos "
                        sql &= " set EstadoFlujo = 'FINALIZADO' "
                        sql &= " ,FechaFinaliza = " & dbFec(Date.Today)
                        sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)
                        StiGlobalConn.SQLExecute(sql)
                    End If
                Else
                    res &= "No se ha especificado el flujo"
                End If
            Else
                res &= "No se ha especificado el flujo del documento."
            End If
            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoAC(ByVal IdAC As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdAC.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.AvisosCobro")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        'si hay un Flujo existente vigente del documento no duplicamos.-
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdAvisoCobro = " & dbStr(IdAC)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select ac.IdPoliza, ac.IdProducto, ac.NombreCliente, ac.IdRamo, ac.IdCliente"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from AvisosCobro as ac"
                            sql &= " left join Productos as p on ac.idproducto = p.idproducto"
                            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = ac.idcliente"
                            sql &= " where ac.IdAvisoCobro = " & dbStr(IdAC)
                            Dim FilAC As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "FLUJO AUTOMATICO AC", dbData(FilAC, "IdPoliza"), dbData(FilAC, "IdProducto"), "", dbData(FilAC, "IdRamo"), "", dbData(FilAC, "IdCliente"), dbData(FilAC, "NombreCliente"), dbData(FilAC, "Aseguradora"), IdAC, "", dbData(FilAC, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilAC, "Ciudad")), "")
                        End If
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido el AC"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoPoliza(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdPoliza.Trim <> "" And IdProducto.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Polizas")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        'si hay un Flujo existente vigente del documento no duplicamos.-
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select pol.IdPoliza, pol.IdProducto, pol.NombreCliente, pol.IdCliente"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Polizas as pol"
                            sql &= " inner join Productos as p on pol.idproducto = p.idproducto"
                            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = pol.idcliente"
                            sql &= " where pol.IdPoliza = " & dbStr(IdPoliza)
                            sql &= " and pol.idproducto = " & dbStr(IdProducto)
                            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "FLUJO AUTOMATICO NUEVAS POLIZAS", dbData(FilPol, "IdPoliza"), dbData(FilPol, "IdProducto"), "", "", "", dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), dbData(FilPol, "Aseguradora"), "", "", dbData(FilPol, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad")), "")
                        End If
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido el Póliza y Producto"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoRenovacionPoliza(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdPoliza.Trim <> "" And IdProducto.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Renovacion.Poliza")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        'si hay un Flujo existente vigente del documento no duplicamos.-
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select pol.IdPoliza, pol.IdProducto, pol.NombreCliente, pol.IdCliente"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Polizas as pol"
                            sql &= " inner join Productos as p on pol.idproducto = p.idproducto"
                            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = pol.idcliente"
                            sql &= " where pol.IdPoliza = " & dbStr(IdPoliza)
                            sql &= " and pol.idproducto = " & dbStr(IdProducto)
                            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "FLUJO AUTOMATICO RENOVACION", dbData(FilPol, "IdPoliza"), dbData(FilPol, "IdProducto"), "", "", "", dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), dbData(FilPol, "Aseguradora"), "", "", dbData(FilPol, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad")), "")
                        End If                        
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido la Póliza y Producto"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoCancelacionPoliza(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdPoliza.Trim <> "" And IdProducto.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Cancelacion.Poliza")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        'si hay un Flujo existente vigente del documento no duplicamos.-
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select pol.IdPoliza, pol.IdProducto, pol.NombreCliente, pol.IdCliente"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Polizas as pol"
                            sql &= " inner join Productos as p on pol.idproducto = p.idproducto"
                            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = pol.idcliente"
                            sql &= " where pol.IdPoliza = " & dbStr(IdPoliza)
                            sql &= " and pol.idproducto = " & dbStr(IdProducto)
                            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "FLUJO AUTOMATICO CANCELACION", dbData(FilPol, "IdPoliza"), dbData(FilPol, "IdProducto"), "", "", "", dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), dbData(FilPol, "Aseguradora"), "", "", dbData(FilPol, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad")), "")
                        End If                        
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido Póliza y Producto"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoCotizaciones(ByVal IdOferta As String, Optional ByRef IdNuevoFlujo As String = "") As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdOferta.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Cotizaciones")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdOferta)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select ofe.IdCliente, ofe.NombreCliente, ofe.EjecutivoCta"
                            sql &= " ,(select top 1 isnull(cc.Direccion,'') from ClientesContactos as cc where cc.IdCliente = ofe.IdCliente order by cc.usocorrespondencia desc, cc.IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(cc.Ciudad,'') from ClientesContactos as cc where cc.IdCliente = ofe.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from CGPolizas as ofe"

                            sql &= " where ofe.IdOferta = " & dbStr(IdOferta)
                            Dim FilOfe As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, dbData(FilOfe, "EjecutivoCta"), IdFlujo, "Oferta: " & IdOferta, IdOferta, "", "", "", "", dbData(FilOfe, "IdCliente"), dbData(FilOfe, "NombreCliente"), "", "", "", dbData(FilOfe, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilOfe, "Ciudad")), "", IdNuevoFlujo)

                            'inicamos un nuevo documento
                            Dim IdImpresion As String = IdOferta
                            Call RegistrarDocumento(IdNuevoFlujo, "Nueva Oferta " & IdOferta, dbData(FilOfe, "IdCliente"), IdOferta, "SALIDA", IdImpresion, "", Date.Today, dbData(FilOfe, "NombreCliente"), DireccionDocumento:=dbData(FilOfe, "Direccion"), ObservacionDocumento:="", CodigoImpresionDocumento:="OF", NombreAlternoCliente:=dbData(FilOfe, "NombreCliente"))
                        End If
                    Else
                        res &= "No existe el flujo especificado."
                    End If

                End If
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res

    End Function

    Public Function IniciarFlujoSiniestro(ByVal IdSiniestro As String, ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdEjecutivoCuenta As String, Optional ByVal DescripcionSiniestro As String = "FLUJO AUTOMATICO SINIESTRO", Optional ByRef IdNuevoFlujo As String = "") As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdSiniestro.Trim <> "" And IdPoliza.Trim <> "" And IdProducto.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Siniestros")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and IdSiniestro = " & dbStr(IdSiniestro)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select sin.IdPoliza, sin.IdProducto, pol.NombreCliente, pol.IdCliente, sin.IdSiniestro"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Siniestros as sin"
                            sql &= " left join Polizas as pol on pol.idpoliza = sin.idpoliza and pol.idproducto = sin.idproducto"
                            sql &= " left join Productos as p on pol.idproducto = p.idproducto"
                            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = pol.idcliente"
                            sql &= " where sin.IdPoliza = " & dbStr(IdPoliza)
                            sql &= " and sin.idproducto = " & dbStr(IdProducto)
                            sql &= " and sin.idsiniestro = " & dbStr(IdSiniestro)
                            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, IdEjecutivoCuenta, IdFlujo, DescripcionSiniestro, dbData(FilPol, "IdPoliza"), dbData(FilPol, "IdProducto"), "", "", dbData(FilPol, "IdSiniestro"), dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), dbData(FilPol, "Aseguradora"), "", "", dbData(FilPol, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad")), "", IdNuevoFlujo)
                        End If
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido siniestro"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoPagos(ByVal NumeroFactura As String, ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdRamo As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If NumeroFactura.Trim <> "" And IdPoliza.Trim <> "" And IdProducto.Trim <> "" And IdRamo.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Cartera.Pagos")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and NumeroFactura = " & dbInt(NumeroFactura) & " and IdRamo = " & dbStr(IdRamo)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select f.IdPoliza, f.IdProducto, f.NombreCliente, f.IdCliente, f.NumeroFactura"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Facturas as f"
                            sql &= " left join Polizas as pol on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto"
                            sql &= " left join Productos as p on pol.idproducto = p.idproducto"
                            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = pol.idcliente"
                            sql &= " where f.IdPoliza = " & dbStr(IdPoliza.Trim)
                            sql &= " and f.idproducto = " & dbStr(IdProducto.Trim)
                            sql &= " and f.idramo = " & dbStr(IdRamo.Trim)
                            sql &= " and f.numerofactura = " & dbInt(NumeroFactura.Trim)
                            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "FLUJO AUTOMATICO PAGOS", IdPoliza, IdProducto, dbData(FilPol, "NumeroFactura"), IdRamo, "", dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), dbData(FilPol, "Aseguradora"), "", "", dbData(FilPol, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad")), "")
                        End If
                        
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido datos de la factura"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoCobros(ByVal NumeroFactura As String, ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdRamo As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If NumeroFactura.Trim <> "" And IdPoliza.Trim <> "" And IdProducto.Trim <> "" And IdRamo.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Cartera.Cobro")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and NumeroFactura = " & dbInt(NumeroFactura) & " and IdRamo = " & dbStr(IdRamo)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select f.IdPoliza, f.IdProducto, f.NombreCliente, f.IdCliente, f.NumeroFactura"
                            sql &= " ,a.Nombre as Aseguradora"
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Facturas as f"
                            sql &= " left join Polizas as pol on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto"
                            sql &= " left join Productos as p on pol.idproducto = p.idproducto"
                            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                            sql &= " left join Clientes as c on c.idcliente = pol.idcliente"
                            sql &= " where f.IdPoliza = " & dbStr(IdPoliza.Trim)
                            sql &= " and f.idproducto = " & dbStr(IdProducto.Trim)
                            sql &= " and f.idramo = " & dbStr(IdRamo.Trim)
                            sql &= " and f.numerofactura = " & dbInt(NumeroFactura.Trim)
                            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "FLUJO AUTOMATICO COBROS", IdPoliza, IdProducto, dbData(FilPol, "NumeroFactura"), IdRamo, "", dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), dbData(FilPol, "Aseguradora"), "", "", dbData(FilPol, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad")), "")
                        End If
                        
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido datos de la factura"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoEstadoCuenta(ByVal IdCliente As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdCliente.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.EstadoCuenta")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdFlujo = " & dbStr(IdFlujo) & " and EstadoFlujo = 'PENDIENTE' and IdCliente = " & dbStr(IdCliente)).Tables(0).Rows(0).Item(0)
                        If Existe = 0 Then
                            sql = "  select c.IdCliente, c.NombreCliente "
                            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                            sql &= " from Clientes as c "
                            sql &= " where c.IdCliente = " & dbStr(IdCliente)
                            Dim FilCli As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                            res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, "ENTREGA ESTADO DE CUENTA A CLIENTE", "", "", "", "", "", dbData(FilCli, "IdCliente"), dbData(FilCli, "NombreCliente"), "", "", "", dbData(FilCli, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilCli, "Ciudad")), "")
                        End If
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido el Póliza y Producto"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function IniciarFlujoDocumentoCliente(ByVal IdCliente As String, ByVal Comentario As String, ByRef IdNuevoFlujo As String) As String
        Dim res As String = ""
        Dim sql As String = ""
        Try
            If IdCliente.Trim <> "" Then
                Dim IdFlujo As String = clSeguros.ObtenerDBParametros("Flujo.Doc.Salida")
                If IdFlujo <> "" Then
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from FlujosTrabajo where IdFlujo = " & dbStr(IdFlujo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        sql = "  select c.IdCliente, c.NombreCliente "
                        sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                        sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                        sql &= " from Clientes as c "
                        sql &= " where c.IdCliente = " & dbStr(IdCliente)
                        Dim FilCli As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                        res &= IniciarFlujo(StiGlobalConn.User, "", IdFlujo, Comentario, "", "", "", "", "", dbData(FilCli, "IdCliente"), dbData(FilCli, "NombreCliente"), "", "", "", dbData(FilCli, "Direccion"), clSeguros.ObtenerIdCiudad(dbData(FilCli, "Ciudad")), "", IdNuevoFlujo)
                    Else
                        res &= "No existe el flujo especificado."
                    End If
                    'Else
                    '    res &= "No se ha definido flujo."
                End If
                'Else
                '    res &= "No se ha definido el Póliza y Producto"
            End If
        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function CerrarFlujoSiniestro(ByVal IdSiniestro As String, ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = "", sql As String = ""
        Try
            Dim filFlujo As DataRow, dtFlujos As DataTable = StiGlobalConn.ObtenerDataset("select IdFlujoDoc from FlujosDocumentos where IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0)
            For Each filFlujo In dtFlujos.Rows
                Sql = " update FlujosDocumentos "
                Sql &= " set EstadoFlujo = 'FINALIZADO' "
                Sql &= " ,FechaFinaliza = " & dbFec(Date.Today)
                sql &= " where IdFlujoDoc = " & dbStr(dbData(filFlujo, "IdFlujoDoc"), 25)
                StiGlobalConn.SQLExecute(Sql)
            Next
        Catch ex As Exception
            res = ex.Message
        End Try
        Return res
    End Function

    Public Function CerrarFlujosPoliza(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = "", sql As String = ""
        Try
            Dim filFlujo As DataRow, dtFlujos As DataTable = StiGlobalConn.ObtenerDataset("select IdFlujoDoc from FlujosDocumentos where IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and EstadoFlujo = 'PENDIENTE' ").Tables(0)
            For Each filFlujo In dtFlujos.Rows
                sql = " update FlujosDocumentos "
                sql &= " set EstadoFlujo = 'FINALIZADO' "
                sql &= " ,FechaFinaliza = " & dbFec(Date.Today)
                sql &= " where IdFlujoDoc = " & dbStr(dbData(filFlujo, "IdFlujoDoc"), 25)
                StiGlobalConn.SQLExecute(sql)
            Next
        Catch ex As Exception
            res = ex.Message
        End Try
        Return res
    End Function

    Public Function ReactivarFlujoSiniestro(ByVal IdSiniestro As String, ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = "", sql As String = ""
        Try
            Dim Existe As Integer = 0
            'verificamos si el siniestro tienen algún flujo
            Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            If Existe > 0 Then
                'si hay hay alguno abierto no hacemos nada
                Existe = StiGlobalConn.ObtenerDataset("select count(*) from FlujosDocumentos where EstadoFlujo <> 'FINALIZADO' and IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
                If Existe = 0 Then
                    'reactivamos el primero flujo encontrado.
                    Dim IdFlujoDoc As String = ""
                    Try
                        IdFlujoDoc = StiGlobalConn.ObtenerDataset("select top 1 IdFlujoDoc from FlujosDocumentos where EstadoFlujo = 'FINALIZADO' and IdSiniestro = " & dbStr(IdSiniestro) & " and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " order by FechaInicia desc").Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        IdFlujoDoc = ""
                    End Try
                    If IdFlujoDoc <> "" Then
                        sql = " update FlujosDocumentos "
                        sql &= " set EstadoFlujo = 'PENDIENTE' "
                        sql &= " ,FechaFinaliza = NULL "
                        sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)
                        StiGlobalConn.SQLExecute(sql)
                    End If
                End If
            End If
        Catch ex As Exception
            res = ex.Message
        End Try
        Return res
    End Function

#End Region



End Class
