Imports Utilerias.Genericas
Imports System.Text
Imports System.Runtime.InteropServices


Module ModSisco

    'Public StiGlobalConn As New Conectividad.Funciones("SISEOSEGUEDA\SQLEX2005", "seguros", "sa", "sti2010", True)
    Public StiGlobalConn As Conectividad.Funciones
    Public tblMenu As Data.DataTable
    Public tblLogo As Data.DataTable
    Public busCodigo As String = ""
    Public IdNuevoFlujo As String = ""
    Public UltimoMovimientoFactura As Integer = 0
    Public frmPrincipal As Principal
    Public AnioAnalisis As Integer = 0
    Public RutaLogo As String = ""
    Public RutaSello As String = ""
    Public ControlNotificacion As DevExpress.XtraBars.BarStaticItem
    Public GlobalCodCliente As String = ""


#Region "Menús"

    Public Function ObtenerPermiso(ByVal IdUsuario As String, ByVal IdMenu As String) As String
        Dim res As String = ""
        ''obtendremos el permiso establecido para la aplicacion especificadas
        ''permisos I=Lectura sin Impresión, L=Lectura, M=Modificacion y T = Control Total 
        Dim sql As String = ""
        sql = "select max(GP.IdPermiso) from UsuariosGrupos as UG inner join GruposPermisos as GP on GP.IdGrupo = UG.IdGrupo where UG.IdUsuario = " & dbStr(IdUsuario) & " and GP.IdMenu = " & dbStr(IdMenu)
        Try
            res = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            'por defecto Lectura
            res = "L"
        End Try
        Return res
    End Function

    Public Function ObtenerVisibilidadMenu(ByVal IdUsuario As String, ByVal IdMenu As String) As String
        Dim res As String = ""
        ''Verificaremos si un usuario tiene permiso de usar una opcion
        Dim sql As String = ""
        sql = "select top 1 GP.IdMenu from UsuariosGrupos as UG inner join GruposPermisos as GP on GP.IdGrupo = UG.IdGrupo where UG.IdUsuario = " & dbStr(IdUsuario) & " and GP.IdMenu = " & dbStr(IdMenu)
        Try
            res = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            'por defecto Lectura
            res = ""
        End Try
        Return res
    End Function

    Public Function UsuarioPerteneceAGrupo(ByVal IdGrupo As String) As Boolean
        Dim res As Boolean = False
        Dim parUsuario = StiGlobalConn.User
        Dim Existe As Integer = 0
        Try
            Existe = StiGlobalConn.ObtenerDataset("select count(*) from UsuariosGrupos where IdUsuario = " & dbStr(parUsuario) & " and IdGrupo = " & dbStr(IdGrupo)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Existe = 0
        End Try
        If Existe = 0 Then
            res = False
        Else
            res = True
        End If
        Return res
    End Function

#End Region

#Region "Licencia"

    Public ID_LICENCIA As Integer = 20103   ''proyecto 2010 de marzo
    Public CLAVE_PRODUCTO As String = "SISCO"
    Public MODALIDAD_DEMO As Boolean = False
    Public MENSAJE_DEMO As String = ""

    Public Function Validar_Licencia() As Boolean
        Dim res As Boolean = False
        Call Inicializar_Licencia()
        MODALIDAD_DEMO = False
        If ObtenerParametro("Clave") = "" Then  'mostramos la ventana de activación
            Dim FR As New frmRegistro
            FR.ShowDialog()
        Else
            'validamos que sea valida la clave ACTUAL
            If Not ComparaLicencia(ObtenerParametro("Cliente"), ObtenerParametro("Serial"), ObtenerParametro("Clave"), ID_LICENCIA) Then
                'lo que hacemos el borar el id especificado
                ActualizarParametro("Serial", "")
                GuardarParametros()
                Dim FR2 As New frmRegistro
                FR2.ShowDialog()
            End If
        End If

        If MODALIDAD_DEMO Then
            res = True
        Else
            If ObtenerParametro("Serial") = "" Then
                res = False
            Else
                res = True
            End If
        End If
        Return res
    End Function

    Public Function ComparaLicencia(ByVal CLIENTE As String, ByVal Serial As String, ByVal CLAVE As String, ByVal IDLIC As Integer) As Boolean
        Dim res As Boolean = True
        Dim GenLic$
        ComparaLicencia = True
        CLAVE = Replace(CLAVE, "-", "")
        CLAVE = CLAVE & CLIENTE
        GenLic = GeneraLicencia(CLAVE, IDLIC)
        If GenLic <> Serial Then res = False
        Return res
    End Function

    Public Function GeneraLicencia(ByVal CLAVE As String, ByVal IDLIC As Integer) As String
        On Error Resume Next
        Dim Lic As String, LICN As Long
        Lic = ""
        LICN = 0
        CLAVE = UCase(Replace(CLAVE, "-", ""))
        For I = 1 To Len(CLAVE)
            LICN = LICN + (Asc(Mid(CLAVE, I, 1)) * (I * IDLIC))
        Next I
        Lic = PE(Trim(Str(LICN)), 10, "5", TipoRelleno.RellenarIzquierda)
        Lic = Mid(Lic, 1, 5) & "-" & Mid(Lic, 6, 5)
        'MsgBox LIC
        GeneraLicencia = Lic
    End Function

    Public Sub Inicializar_Licencia()
        Dim CLAVEID As String = ObtenerParametro("Clave")
        Dim SECUENCIAID As String = ""
        If CLAVEID = "" Then
            If ObtenerParametro("CompanyName") = "" Then
                'El nombre de la compañía
                ActualizarParametro("CompanyName", "STI - Sistemas Técnicos Informáticos")
                'la Clave de Autorización
                ActualizarParametro("Serial", "")
                ActualizarParametro("Cliente", "")
                Dim Fecha As String = Date.Today.ToShortDateString
                ''SECUENCIAID = DESEncrypt(Fecha & "-0", CLAVE_PRODUCTO)
                SECUENCIAID = HashEncrypt("15", ObtenerClavePC())
                ActualizarParametro("Secuencia", SECUENCIAID)
            End If
        End If
        'Obtenemos el serial de la computadora
        '******************************************************************
        ' Initialize string buffers.
        CLAVEID = ObtenerClavePC()
        ActualizarParametro("Clave", CLAVEID)
        GuardarParametros()
    End Sub

    <DllImport("kernel32.dll")> _
    Private Function GetVolumeInformation(ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As StringBuilder, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As StringBuilder, ByVal nFileSystemNameSize As Integer) As Boolean
    End Function

    Public Function ObtenerClavePC() As String
        Dim snstr As String = ""
        Try
            Dim sbVolumeName As StringBuilder = New StringBuilder(256)
            Dim sbFileSystemName As StringBuilder = New StringBuilder(256)
            Dim nVolSerial As Integer = 0
            Dim nMaxCompLength As Integer = 0
            Dim nFSFlags As Integer = 0
            Dim bResult As Boolean = GetVolumeInformation("C:\", sbVolumeName, 256, nVolSerial, nMaxCompLength, nFSFlags, sbFileSystemName, 256)
            If bResult Then
                'Return sbVolumeName.ToString
                'formateamos el serial apropiadamente
                snstr = Trim(Hex(nVolSerial))
                snstr = Replace(Space(8 - Len(snstr)), " ", "0") & snstr
                snstr = Left(snstr, 4) & "-" & Right(snstr, 4)
            Else
                snstr = "00000000"
            End If
        Catch ex As Exception
            snstr = "00000000"
        End Try
        Return snstr
    End Function

#End Region

#Region "Gestión Cartera"

    Public Function Cartera_AgregarFactura(ByVal NumeroFactura As Integer, ByVal IdProducto As String, ByVal Poliza As String, ByVal TipoFactura As String, ByVal Anexo As String, ByVal IdCliente As String _
                                           , ByVal NombreCliente As String, ByVal FechaEmision As DateTime, ByVal FechaPago As DateTime, ByVal VigenciaDesde As DateTime, ByVal VigenciaHasta As DateTime _
                                           , ByVal NumCuota As Integer, ByVal TotalCuotas As Integer, ByVal Prima As Double, ByVal GastosEmi As Double, ByVal GastosFin As Double, ByVal GastosBomb As Double _
                                           , ByVal GastosOtros As Double, ByVal Iva As Double, ByVal Total As Double, ByVal Comision As Double, ByVal Referencia As String, ByVal Observaciones As String _
                                           , ByVal PorceComision As Double, ByVal IdRamo As String, ByVal RetencionIva As Double, ByVal AplicarRetencionIva As String, ByVal VencimientoTardio As DateTime, ByVal PrimaExenta As Double) As String
        Dim res As String = ""
        Try
            'Primero se haran algunas validaciones
            If Poliza.Trim = "" Then res &= "Debe especificar una póliza; "
            If IdProducto.Trim = "" Then res &= "Debe especificar el producto de seguros;"
            If IdProducto.Trim <> "" And StiGlobalConn.ObtenerDataset("select count(*) from Productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0) = 0 Then res &= "no existe el producto de seguros;"
            If NombreCliente.Trim = "" Then res &= "Debe especificar el nombre del cliente; "
            If FechaPago.Year = 0 Then res &= "Debe especificar la fecha de pago de la factura; "

            If res = "" Then
                'Ingresamos el encabezado
                Dim sql As String
                sql = "  insert into Facturas (NumeroFactura, IdProducto, IdPoliza, TipoFactura, IdAnexo, "
                sql &= " IdCliente, NombreCliente, FechaEmision, FechaPago, VigenciaDesde,"
                sql &= " VigenciaHasta, NumCuota, TotalCuotas, IdRamo, Referencia, Observaciones, PorceComision, AplicarRetencionIva, VencimientoTardio) values(  "
                sql &= dbInt(NumeroFactura) & C & dbStr(IdProducto, 25) & C & dbStr(Poliza, 25) & C & dbStr(TipoFactura, 1) & C & dbStr(Anexo, 25) & C
                sql &= dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 500) & C & dbFec(FechaEmision) & C & dbFec(FechaPago) & C & dbFec(VigenciaDesde) & C
                sql &= dbFec(VigenciaHasta) & C & dbInt(NumCuota) & C & dbInt(TotalCuotas) & C & dbStr(IdRamo, 25) & C & dbStr(Referencia, 500) & C & dbStr(Observaciones, 1000) & C & dbNum(PorceComision) & C & dbStr(AplicarRetencionIva, 1) & C & dbFec(VencimientoTardio) & ") "
                StiGlobalConn.SQLExecute(sql)

                ''ahora el registro de emision

                sql = "  insert into FacturasMovimientos (NumeroFactura, IdProducto, IdPoliza, IdMovimiento, FechaMovimiento, "
                sql &= " TipoMovimiento, PrimaNeta, GastosEmision, GastosFracciona, GastosBomberos, Gastos, Impuestos, Total, Comision, IdRamo, RetencionImpuestos, UsuarioGrabacion,FechaGrabacion, PrimaExenta) values("
                sql &= dbInt(NumeroFactura) & C & dbStr(IdProducto, 25) & C & dbStr(Poliza, 25) & C & dbInt("1") & C & dbFec(Date.Today) & C
                sql &= dbStr("EMISION") & C & dbNum(Prima) & C & dbNum(GastosEmi) & C & dbNum(GastosFin) & C & dbNum(GastosBomb) & C & dbNum(GastosOtros) & C & dbNum(Iva) & C & dbNum(Total) & C & dbNum(Comision) & C & dbStr(IdRamo, 25) & C & dbNum(RetencionIva) & C & dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbNum(PrimaExenta) & ")"
                StiGlobalConn.SQLExecute(sql)

                UltimoMovimientoFactura = 1

                RegistrarLog("A", "FacturasMovimientos", "Emisión: NumeroFactura=" & dbInt(NumeroFactura) & " and IdProducto=" & dbStr(IdProducto, 25) & " and IdPoliza=" & dbStr(Poliza, 25) & " and IdRamo=" & dbStr(IdRamo, 25))
            End If
        Catch ex As Exception
            res = ex.Message
            msgError(ex)
        End Try
        Return res
    End Function

    Public Function Cartera_ActualizarFactura(ByVal NumeroFactura As Integer, ByVal IdProducto As String, ByVal Poliza As String, ByVal TipoFactura As String, ByVal Anexo As String, ByVal IdCliente As String _
                                           , ByVal NombreCliente As String, ByVal FechaEmision As DateTime, ByVal FechaPago As DateTime, ByVal VigenciaDesde As DateTime, ByVal VigenciaHasta As DateTime _
                                           , ByVal NumCuota As Integer, ByVal TotalCuotas As Integer, ByVal Prima As Double, ByVal GastosEmi As Double, ByVal GastosFin As Double, ByVal GastosBomb As Double _
                                           , ByVal GastosOtros As Double, ByVal Iva As Double, ByVal Total As Double, ByVal Comision As Double, ByVal Referencia As String, ByVal Observaciones As String _
                                           , ByVal PorceComision As Double, ByVal IdRamo As String, ByVal RetencionIva As Double, ByVal AplicarRetencionIva As String, ByVal VencimientoTardio As DateTime, ByVal PrimaExenta As Double) As String
        Dim res As String = ""
        Try
            'Primero se haran algunas validaciones
            If Poliza.Trim = "" Then res &= "Debe especificar una póliza; "
            If IdProducto.Trim = "" Then res &= "Debe especificar el producto de seguros;"
            If IdProducto.Trim <> "" And StiGlobalConn.ObtenerDataset("select count(*) from Productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0) = 0 Then res &= "no existe el producto de seguros;"
            If NombreCliente.Trim = "" Then res &= "Debe especificar el nombre del cliente; "
            If FechaPago.Year = 0 Then res &= "Debe especificar la fecha de pago de la factura; "

            If res = "" Then
                'Ingresamos el encabezado
                Dim sql As String
                sql = "  update Facturas  set "
                sql &= " TipoFactura = " & dbStr(TipoFactura, 1)
                sql &= ", IdAnexo = " & dbStr(Anexo, 25)
                sql &= ", IdCliente = " & dbStr(IdCliente, 25)
                sql &= ", NombreCliente = " & dbStr(NombreCliente, 500)
                sql &= ", FechaEmision = " & dbFec(FechaEmision)
                sql &= ", FechaPago = " & dbFec(FechaPago)
                sql &= ", VigenciaDesde = " & dbFec(VigenciaDesde)
                sql &= ", VigenciaHasta = " & dbFec(VigenciaHasta)
                sql &= ", NumCuota = " & dbInt(NumCuota)
                sql &= ", TotalCuotas = " & dbInt(TotalCuotas)
                sql &= ", Referencia = " & dbStr(Referencia, 250)
                sql &= ", Observaciones = " & dbStr(Observaciones, 500)
                sql &= ", PorceComision = " & dbNum(PorceComision)
                sql &= ", AplicarRetencionIva = " & dbStr(AplicarRetencionIva, 1)
                sql &= ", VencimientoTardio = " & dbFec(VencimientoTardio)
                sql &= " where NumeroFactura = " & dbInt(NumeroFactura)
                sql &= " and IdProducto = " & dbStr(IdProducto, 25)
                sql &= " and IdPoliza = " & dbStr(Poliza, 25)
                sql &= " and IdRamo = " & dbStr(IdRamo, 25)
                StiGlobalConn.SQLExecute(sql)

                ''ahora el registro de emision

                sql = "  update FacturasMovimientos set "
                sql &= "  FechaMovimiento = " & dbFec(Date.Today)
                sql &= ", TipoMovimiento = " & dbStr("EMISION")
                sql &= ", PrimaNeta = " & dbNum(Prima)
                sql &= ", PrimaExenta = " & dbNum(PrimaExenta)
                sql &= ", GastosEmision = " & dbNum(GastosEmi)
                sql &= ", GastosFracciona = " & dbNum(GastosFin)
                sql &= ", GastosBomberos = " & dbNum(GastosBomb)
                sql &= ", Gastos = " & dbNum(GastosOtros)
                sql &= ", Impuestos = " & dbNum(Iva)
                sql &= ", Total = " & dbNum(Total)
                sql &= ", Comision = " & dbNum(Comision)
                sql &= ", RetencionImpuestos = " & dbNum(RetencionIva)
                sql &= ", UsuarioGrabacion = " & dbStr(StiGlobalConn.User, 25)
                sql &= " where NumeroFactura = " & dbInt(NumeroFactura)
                sql &= " and IdProducto = " & dbStr(IdProducto, 25)
                sql &= " and IdPoliza = " & dbStr(Poliza, 25)
                sql &= " and IdRamo = " & dbStr(IdRamo, 25)
                sql &= " and IdMovimiento = " & dbInt("1")
                StiGlobalConn.SQLExecute(sql)

                RegistrarLog("M", "FacturasMovimientos", "Emisión: NumeroFactura=" & dbInt(NumeroFactura) & " and IdProducto=" & dbStr(IdProducto, 25) & " and IdPoliza=" & dbStr(Poliza, 25) & " and IdRamo=" & dbStr(IdRamo, 25))
            End If
        Catch ex As Exception
            res = ex.Message
            msgError(ex)
        End Try
        Return res
    End Function

    Public Function Cartera_AgregarPago(ByVal NumeroFactura As Integer, ByVal Poliza As String, ByVal IdProducto As String, ByVal FechaPago As DateTime, ByVal Prima As Double, ByVal GastosEmi As Double _
                                        , ByVal GastosFin As Double, ByVal GastosBomb As Double, ByVal GastosOtros As Double, ByVal Iva As Double, ByVal Total As Double, ByVal Comision As Double _
                                        , ByVal IdRamo As String, ByVal RetencionIva As Double, ByVal IdFormaPago As String) As String
        Dim res As String = ""
        Try
            'Primero se haran algunas validaciones
            If Poliza.Trim = "" Then res &= "Debe especificar una póliza; "
            If IdProducto.Trim = "" Then res &= "Debe especificar el producto de seguros;"
            If IdProducto.Trim <> "" And StiGlobalConn.ObtenerDataset("select count(*) from Productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0) = 0 Then res &= "no existe el producto de seguros;"
            If StiGlobalConn.ObtenerDataset("select count(*) from Facturas where NumeroFactura = " & dbInt(NumeroFactura) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(Poliza)).Tables(0).Rows(0).Item(0) = 0 Then res &= "La factura a la que desea aplicar el pago no existe, verificar: Número Factura, Póliza y Producto;"

            'ahora ingresamos el pago
            If res = "" Then

                'sol. por mym si el pago es con valores no genera comisión
                If IdFormaPago = "V" Then Comision = 0

                Dim IdMov As Integer = CInt(StiGlobalConn.ObtenerDataset("select isnull(max(IdMovimiento),0) + 1 from FacturasMovimientos where numerofactura = " & dbInt(NumeroFactura) & " and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(Poliza)).Tables(0).Rows(0).Item(0))
                Dim sql As String
                sql = "  insert into FacturasMovimientos (NumeroFactura, IdProducto, IdPoliza, IdMovimiento, FechaMovimiento, "
                sql &= " TipoMovimiento, PrimaNeta, GastosEmision, GastosFracciona, GastosBomberos, Gastos, Impuestos, Total, Comision, IdRamo, RetencionImpuestos, UsuarioGrabacion, IdFormaPago, FechaGrabacion) values("
                sql &= dbInt(NumeroFactura) & C & dbStr(IdProducto, 25) & C & dbStr(Poliza, 25) & C & dbInt(IdMov) & C & dbFec(FechaPago) & C
                sql &= dbStr("PAGO") & C & dbNum(Prima * -1) & C & dbNum(GastosEmi * -1) & C & dbNum(GastosFin * -1) & C & dbNum(GastosBomb * -1) & C & dbNum(GastosOtros * -1) & C & dbNum(Iva * -1) & C & dbNum(Total * -1) & C & dbNum(Comision * -1) & C & dbStr(IdRamo, 25) & C & dbNum(RetencionIva * -1) & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(IdFormaPago, 25) & C & dbFec(Date.Now, "1") & ")"
                StiGlobalConn.SQLExecute(sql)

                UltimoMovimientoFactura = IdMov

                RegistrarLog("A", "FacturasMovimientos", "Pago: NumeroFactura=" & dbInt(NumeroFactura) & " and IdProducto=" & dbStr(IdProducto, 25) & " and IdPoliza=" & dbStr(Poliza, 25) & " and IdRamo=" & dbStr(IdRamo, 25))
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return res
    End Function

    Public Function Cartera_AnularPago(ByVal NumeroFactura As Integer, ByVal Poliza As String, ByVal IdProducto As String, ByVal FechaAnulacion As DateTime, ByVal Prima As Double, ByVal GastosEmi As Double _
                                       , ByVal GastosFin As Double, ByVal GastosBomb As Double, ByVal GastosOtros As Double, ByVal Iva As Double, ByVal Total As Double, ByVal Comision As Double _
                                       , ByVal IdRamo As String, ByVal RetencionIva As Double, ByVal MotivoAnulacion As String) As String
        Dim res As String = ""
        Try
            'Primero se haran algunas validaciones
            If Poliza.Trim = "" Then res &= "Debe especificar una póliza; "
            If IdProducto.Trim = "" Then res &= "Debe especificar el producto de seguros;"
            If IdProducto.Trim <> "" And StiGlobalConn.ObtenerDataset("select count(*) from Productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0) = 0 Then res &= "no existe el producto de seguros;"
            If StiGlobalConn.ObtenerDataset("select count(*) from Facturas where NumeroFactura = " & dbInt(NumeroFactura) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(Poliza)).Tables(0).Rows(0).Item(0) = 0 Then res &= "La factura a la que desea aplicar la anulación de pago no existe, verificar: Número Factura, Póliza y Producto;"

            'ahora ingresamos el pago
            If res = "" Then
                Dim IdMov As Integer = CInt(StiGlobalConn.ObtenerDataset("select isnull(max(IdMovimiento),0) + 1 from FacturasMovimientos where numerofactura = " & dbInt(NumeroFactura) & " and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(Poliza)).Tables(0).Rows(0).Item(0))
                Dim sql As String
                sql = "  insert into FacturasMovimientos (NumeroFactura, IdProducto, IdPoliza, IdMovimiento, FechaMovimiento, "
                sql &= " TipoMovimiento, PrimaNeta, GastosEmision, GastosFracciona, GastosBomberos, Gastos, Impuestos, Total, Comision, IdRamo, RetencionImpuestos, UsuarioGrabacion, MotivoAnulacion, FechaGrabacion) values("
                sql &= dbInt(NumeroFactura) & C & dbStr(IdProducto, 25) & C & dbStr(Poliza, 25) & C & dbInt(IdMov) & C & dbFec(FechaAnulacion) & C
                sql &= dbStr("PAGO") & C & dbNum(Prima) & C & dbNum(GastosEmi) & C & dbNum(GastosFin) & C & dbNum(GastosBomb) & C & dbNum(GastosOtros) & C & dbNum(Iva) & C & dbNum(Total) & C & dbNum(Comision) & C & dbStr(IdRamo, 25) & C & dbNum(RetencionIva) & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(MotivoAnulacion, 50) & C & dbFec(Date.Now, "1") & ")"
                StiGlobalConn.SQLExecute(sql)

                UltimoMovimientoFactura = IdMov

                RegistrarLog("A", "FacturasMovimientos", "Anula Pago: NumeroFactura=" & dbInt(NumeroFactura) & " and IdProducto=" & dbStr(IdProducto, 25) & " and IdPoliza=" & dbStr(Poliza, 25) & " and IdRamo=" & dbStr(IdRamo, 25))
            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return res
    End Function

    Public Function Cartera_AnularFactura(ByVal NumeroFactura As Integer, ByVal Poliza As String, ByVal IdProducto As String, ByVal FechaAnulacion As DateTime, ByVal Prima As Double, ByVal GastosEmi As Double _
                                          , ByVal GastosFin As Double, ByVal GastosBomb As Double, ByVal GastosOtros As Double, ByVal Iva As Double, ByVal Total As Double, ByVal Comision As Double _
                                          , ByVal IdRamo As String, ByVal MotivoAnulacion As String, ByVal RetencionIva As Double) As String
        Dim res As String = ""
        Try
            'Primero se haran algunas validaciones
            If Poliza.Trim = "" Then res &= "Debe especificar una póliza; "
            If IdProducto.Trim = "" Then res &= "Debe especificar el producto de seguros;"
            If IdProducto.Trim <> "" And StiGlobalConn.ObtenerDataset("select count(*) from Productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0) = 0 Then res &= "no existe el producto de seguros;"
            If StiGlobalConn.ObtenerDataset("select count(*) from Facturas where NumeroFactura = " & dbInt(NumeroFactura) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(Poliza)).Tables(0).Rows(0).Item(0) = 0 Then res &= "La factura que desea anular no existe, verificar: Número Factura, Póliza y Producto;"

            'ahora ingresamos la anulación
            If res = "" Then
                Dim IdMov As Integer = CInt(StiGlobalConn.ObtenerDataset("select isnull(max(IdMovimiento),0) + 1 from FacturasMovimientos where numerofactura = " & dbInt(NumeroFactura) & " and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(Poliza)).Tables(0).Rows(0).Item(0))
                Dim sql As String
                sql = "  insert into FacturasMovimientos (NumeroFactura, IdProducto, IdPoliza, IdMovimiento, FechaMovimiento, "
                sql &= " TipoMovimiento, PrimaNeta, GastosEmision, GastosFracciona, GastosBomberos, Gastos, Impuestos, Total, Comision, IdRamo, MotivoAnulacion, RetencionImpuestos, UsuarioGrabacion, FechaGrabacion) values("
                sql &= dbInt(NumeroFactura) & C & dbStr(IdProducto, 25) & C & dbStr(Poliza, 25) & C & dbInt(IdMov) & C & dbFec(FechaAnulacion) & C
                sql &= dbStr("ANULACION") & C & dbNum(Prima * -1) & C & dbNum(GastosEmi * -1) & C & dbNum(GastosFin * -1) & C & dbNum(GastosBomb * -1) & C & dbNum(GastosOtros * -1) & C & dbNum(Iva * -1) & C & dbNum(Total * -1) & C & dbNum(Comision * -1) & C & dbStr(IdRamo, 25) & C & dbStr(MotivoAnulacion, 250) & C & dbNum(RetencionIva * -1) & C & dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & ")"
                StiGlobalConn.SQLExecute(sql)

                UltimoMovimientoFactura = IdMov

                RegistrarLog("A", "FacturasMovimientos", "Anulación: NumeroFactura=" & dbInt(NumeroFactura) & " and IdProducto=" & dbStr(IdProducto, 25) & " and IdPoliza=" & dbStr(Poliza, 25) & " and IdRamo=" & dbStr(IdRamo, 25))
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return res
    End Function

    Public Function Cartera_AgregarDeposito(ByVal IdCliente As String, ByVal NombreCliente As String, ByVal Observaciones As String, ByVal FechaDeposito As DateTime, ByVal ValorDeposito As Double, ByVal DescripcionDeposito As String, ByVal IdAseguradora As String) As String
        Dim res As String = "", sql As String = ""
        Try
            Dim IdMovimiento As Integer = 0
            'Primero ingresamos el encabezado del depósito
            'se crea un sólo deposito por cliente, verificamos si existe

            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Depositos where IdCliente = " & dbStr(IdCliente)).Tables(0).Rows(0).Item(0)
            If Existe = 0 Then
                sql = " insert into Depositos"
                sql &= " (IdCliente, NombreCliente, Observaciones) values("
                sql &= dbStr(IdCliente, 25) & C & dbStr(NombreCliente, 150) & C & dbStr(Observaciones, 250) & ")"
                StiGlobalConn.SQLExecute(sql)
            End If
            'ahora vamos a ver que movimiento
            IdMovimiento = clSeguros.ObtenerIDTabla("DepositosMovimientos", "IdMovimiento", " IdCliente = " & dbStr(IdCliente))

            'Ahora el ingreso
            sql = " insert into DepositosMovimientos"
            sql &= " (IdCliente, IdMovimiento, IdTipo, FechaMovimiento, Descripcion, ValorDeposito, Usuario, IdAseguradora) values("
            sql &= dbStr(IdCliente, 25) & C & dbInt(IdMovimiento) & C & dbStr("DEPOSITO") & C & dbFec(FechaDeposito) & C & dbStr(DescripcionDeposito, 250) & C & dbNum(ValorDeposito) & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(IdAseguradora, 25) & ")"
            StiGlobalConn.SQLExecute(sql)

            RegistrarLog("A", "DepositosMovimientos", "Agregar Depósito: IdCliente=" & dbStr(IdCliente, 25) & " and IdAseguradora=" & dbStr(IdAseguradora, 25))
        Catch ex As Exception
            res = ex.Message
            msgError(ex)
        End Try
        Return res
    End Function

    Public Function Cartera_DescontarDeposito(ByVal IdCliente As String, ByVal FechaDescuento As DateTime, ByVal ValorDescuento As Double, ByVal DescripcionDescuento As String, ByVal IdAseguradora As String) As String
        Dim res As String = "", sql As String = ""
        Try
            Dim IdMovimiento As Integer = 0
            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Depositos where IdCliente = " & dbStr(IdCliente)).Tables(0).Rows(0).Item(0)
            If Existe = 0 Then
                res = "No existe cliente al que descontar el depósito."
            Else
                'tenemos que verificar que tenga suficiente saldo para la aseguradora que envía
                Dim SaldoDeposito As Double
                Try
                    SaldoDeposito = StiGlobalConn.ObtenerDataset("select sum(ValorDeposito) from DepositosMovimientos where IdCliente = " & dbStr(IdCliente) & " and IdAseguradora = " & dbStr(IdAseguradora)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    SaldoDeposito = 0
                End Try
                If Math.Round(SaldoDeposito, 2) < Math.Round(Math.Abs(ValorDescuento), 2) Then
                    res = "El saldo de deposito para la aseguradora y cliente no es suficiente."
                Else
                    'ahora vamos a ver que movimiento
                    IdMovimiento = clSeguros.ObtenerIDTabla("DepositosMovimientos", "IdMovimiento", " IdCliente = " & dbStr(IdCliente))

                    'Ahora el ingreso
                    sql = " insert into DepositosMovimientos"
                    sql &= " (IdCliente, IdMovimiento, IdTipo, FechaMovimiento, Descripcion, ValorDeposito, Usuario, IdAseguradora) values("
                    sql &= dbStr(IdCliente, 25) & C & dbInt(IdMovimiento) & C & dbStr("RETIRO") & C & dbFec(FechaDescuento) & C & dbStr(DescripcionDescuento, 250) & C & dbNum(Math.Abs(ValorDescuento) * -1) & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(IdAseguradora, 25) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    RegistrarLog("A", "DepositosMovimientos", "Descontar Depósito: IdCliente=" & dbStr(IdCliente, 25) & " and IdAseguradora=" & dbStr(IdAseguradora, 25))
                End If
            End If
        Catch ex As Exception
            res = ex.Message
            msgError(ex)
        End Try
        Return res

    End Function

    Public Function AnularFacturasPendientes(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal FechaAnulacion As DateTime, ByVal MotivoAnula As String) As String
        Dim res As String = ""
        Try
            'primero obtenemos las facturas pendientes
            Dim sql As String = ""
            sql = "  select f.NumeroFactura, f.IdPoliza, f.IdProducto, f.IdRamo"
            sql &= " ,(select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as Prima "
            sql &= " ,(select sum(m.GastosEmision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as GastosE"
            sql &= " ,(select sum(m.GastosFracciona) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as GastosF"
            sql &= " ,(select sum(m.GastosBomberos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as GastosB"
            sql &= " ,(select sum(m.Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as GastosO"
            sql &= " ,(select sum(m.Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as Iva"
            sql &= " ,isnull((select sum(m.RetencionImpuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo),0) as RetencionImpuestos"
            sql &= " ,(select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as Total"
            sql &= " ,(select sum(m.Comision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) as Comision"
            sql &= " from Facturas as f"
            sql &= " where f.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and f.idproducto = " & dbStr(IdProducto)
            sql &= " and (select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo) > 0 "

            Dim Facturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Dim FilFac As DataRow
            For Each FilFac In Facturas.Rows
                res &= Cartera_AnularFactura(dbData(FilFac, "NumeroFactura"), dbData(FilFac, "IdPoliza"), dbData(FilFac, "IdProducto"), FechaAnulacion, dbData(FilFac, "Prima"), dbData(FilFac, "GastosE"), dbData(FilFac, "GastosF"), dbData(FilFac, "GastosB"), dbData(FilFac, "GastosO"), dbData(FilFac, "Iva"), dbData(FilFac, "Total"), dbData(FilFac, "Comision"), dbData(FilFac, "IdRamo"), MotivoAnula, dbData(FilFac, "RetencionImpuestos"))

                'vamos a anular el aviso de cobro relacionado con la factura
                sql = "  update AvisosCobro set MotivoAnulacion = " & dbStr(MotivoAnula)
                sql &= " from AvisosCobro inner join AvisosCobroFacturas on AvisosCobro.IdAvisoCobro = AvisosCobroFacturas.IdAvisoCobro"
                sql &= " where AvisosCobroFacturas.NumeroFactura = " & dbInt(dbData(FilFac, "NumeroFactura")) & " and AvisosCobroFacturas.IdPoliza = " & dbStr(dbData(FilFac, "IdPoliza")) & " and AvisosCobroFacturas.IdProducto = " & dbStr(dbData(FilFac, "IdProducto")) & " and AvisosCobroFacturas.IdRamo = " & dbStr(dbData(FilFac, "IdRamo"))
                StiGlobalConn.SQLExecute(sql)
            Next

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Sub ImprimirAvisoCobro(ByVal IdAC As String, ByVal ImprimirSoloPendientesPago As Boolean, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String, Optional ByVal RutearDocumento As Boolean = True, Optional ByVal parIdFlujoDoc As String = "")
        Try
            Dim Reporte As Object
            Reporte = New repAvisoCobro
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.AvisoCobro")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim Rep As New frmReportes
            Dim sql As String = ""
            Dim FilAC As DataRow = Nothing

            Try
                FilAC = StiGlobalConn.ObtenerDataset("select UsuarioGrabacion, FechaNotificacion, FechaInicialPago,FechaGrabacion, IdCliente from AvisosCobro where IdAvisoCobro = " & dbStr(IdAC)).Tables(0).Rows(0)
            Catch ex As Exception

            End Try

            'primero cargamos el registro de Aviso de cobro
            sql = " select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",c.NombreCliente as NombreCliente"
            sql &= ",ac.NombreCliente as NombreFactura"
            sql &= ",ac.IdCliente as NIT"
            If parAtteNombre <> "" Then
                sql &= ", isnull((select top 1 cc1.Direccion from ClientesContactos as cc1 where cc1.idcliente = c.idcliente and Nombre = " & dbStr(parAtteNombre) & " and Cargo = " & dbStr(parAtteCargo) & " order by cc1.IdContacto asc), isnull((select top 1 Direccion from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'')) as Direccion"
            Else
                sql &= ",isnull((select top 1 Direccion from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Direccion"
            End If
            sql &= ",isnull((select top 1 Ciudad from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Ciudad"
            sql &= ",isnull((select top 1 Telefono from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Telefono"
            sql &= ",isnull((select top 1 Nombre from ClientesContactos as cc where cc.idcliente = c.idcliente order by IdContacto asc),'') as Contacto"
            sql &= ", isnull(a.Nombre,'') as Aseguradora"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as ContactoACTardio"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoACTardio"
            sql &= ", isnull(p.Descripcion,'') as Producto"
            sql &= ",ac.IdPoliza as Poliza"
            sql &= ",ac.VigenciaDesde as VigenciaDesde"
            sql &= ",ac.VigenciaHasta as VigenciaHasta"
            sql &= ",isnull(ac.Referencia,'') as Referencia"
            sql &= ",'' as NombreFactura"
            sql &= ",isnull(ac.NumeroTarjeta,'') as Tarjeta"
            sql &= ",isnull(ac.TarjetaHabiente,'') as NombreTarjeta"
            sql &= ",isnull(ac.VencimientoTarjeta,'') as VenceTarjeta"
            sql &= ",ac.IdAnexo as Anexo"
            sql &= ",isnull((select NombreUsuario from usuarios as u inner join Clientes as c on u.idusuario = c.EjecutivoCta where c.idcliente = ac.idcliente),'') as Ejecutivo"
            sql &= ",isnull((select NombreUsuario from usuarios as u inner join Polizas as c on u.idusuario = c.EjecutivoCta where c.idpoliza = ac.IdPoliza and c.idproducto = ac.IdProducto),'') as EjecutivoPoliza"
            sql &= ",isnull((select u.nombreusuario + CHAR(10) from usuarios as u inner join ClientesEjecutivos as c on u.idusuario = c.IdEjecutivo where c.IdCliente = ac.idcliente order by c.orden for xml path('')),'') as EjecutivoCliente"
            sql &= "," & dbStr("Usuario: " & StiGlobalConn.User & Chr(13) & "Fecha: " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss")) & " as Log"
            sql &= ",ac.Observaciones as Observaciones"
            sql &= ", ac.AvisoInterno as ACInterno"
            sql &= ", ac.FechaGrabacion"
            sql &= ", ac.FechaNotificacion "
            sql &= ", isnull((select top 1 NombreUsuario from usuarios as u where u.idusuario = ac.UsuarioGrabacion),isnull((select top 1 NombreUsuario from usuarios as u where u.idusuario = " & dbStr(StiGlobalConn.User) & "),'')) As NombreUsuarioGraba"
            sql &= ", isnull((select top 1 Cargo from usuarios as u where u.idusuario = ac.UsuarioGrabacion),isnull((select top 1 Cargo from usuarios as u where u.idusuario = " & dbStr(StiGlobalConn.User) & "),'')) As CargoUsuarioGraba"
            sql &= ", isnull((select sum(d.ValorDescuento) from AvisosCobroDescuentos as d where d.IdAvisoCobro = ac.IdAvisoCobro),0) as TotalDescuento"
            sql &= ", isnull((select sum(m.PrimaNeta) from AvisosCobroFacturas as d inner join FacturasMovimientos as m on m.NumeroFactura = d.NumeroFactura and m.IdProducto = d.IdProducto and m.IdPoliza = d.IdPoliza and m.IdRamo = d.IdRamo and m.IdMovimiento = 1 where d.IdAvisoCobro = ac.IdAvisoCobro),0) as PrimaNeta"
            sql &= ", isnull(ac.PSumaAsegurada,0.0) as PSumaAsegurada, isnull(ac.PTarifa,0.0) as PTarifa, isnull(ac.PPrima,0.0) as PPrima, isnull(ac.PPorceRen,0.0) as PPorceRen, isnull(ac.PDescuento,0.0) as PDescuento, isnull(ac.PPrimaNeta,0.0) as PPrimaNeta, isnull(ac.PComiCobranza,0.0) as PComiCobranza, isnull(ac.PPrimaPagar,0.0) as PPrimaPagar, isnull(ac.PPorceComi,0.0) as PPorceComi, isnull(ac.PComision,0.0) as PComision, isnull(ac.PIva,0.0) as PIva, isnull(ac.PSubtotal,0.0) as PSubtotal, isnull(ac.PRetIva,0.0) as PRetIva, isnull(ac.PTotalCCF,0.0) as PTotalCCF "
            sql &= " from AvisosCobro as ac "
            sql &= " left join Productos as p on p.idproducto = ac.idproducto"
            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join Clientes as c on c.idcliente = ac.idcliente"
            sql &= " where IdAvisoCobro = " & dbStr(IdAC)

            Dim dtAC As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtAC.TableName = "AvisoCobro"


            'se mostraran los saldos de las facturas
            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= " ,f.NumeroFactura as NumeroFactura"
            sql &= ",f.FechaPago as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ", cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ", f.VencimientoTardio as PagoTardio"
            sql &= ",isnull(sum(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(sum(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(sum(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(sum(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(sum(m.Gastos),0) as Gastos"
            sql &= ",isnull(sum(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(sum(m.RetencionImpuestos),0) as RetIva"
            sql &= ",isnull(sum(m.Total),0) as Total"
            sql &= ",isnull(sum(isnull(m.PrimaExenta,0)),0) as PrimaExcenta"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.TipoMovimiento in ('EMISION','ANULACION')"
            sql &= " inner join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " where ac.IdAvisoCobro = " & dbStr(IdAC)
            If ImprimirSoloPendientesPago = True Then
                sql &= " and (select sum(Total) from FacturasMovimientos as m1 where m1.NumeroFactura = f.NumeroFactura and m1.IdProducto = f.IdProducto and m1.IdPoliza = f.IdPoliza and m1.idramo = f.idramo) > 0 "
            End If
            sql &= " group by ac.IdAvisoCobro,f.NumeroFactura,f.FechaPago,f.NumCuota,f.TotalCuotas, f.VencimientoTardio "

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"



            sql = " select "
            sql &= " d.IdAvisoCobro"
            sql &= " , d.IdDescuento"
            sql &= " , d.DescripcionDescuento"
            sql &= " , d.PorceDescuento"
            sql &= " , d.ValorDescuento"
            sql &= " , d.PorceImp"
            sql &= " , d.PorceRet"
            sql &= " , d.ValorImp"
            sql &= " , d.ValorRet"
            sql &= " from AvisosCobroDescuentos as d"
            sql &= " where d.IdAvisoCobro = " & dbStr(IdAC)
            Dim dtDE As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDE.TableName = "Descuento"

            If dtFA.Rows.Count = 0 Then
                MsgBox("No hay facturas que imprimir en el Aviso de Cobro.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtAC.Copy)
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(dtDE.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "ResponsableAC", clSeguros.ObtenerDBParametros("Responsable.Gestion.AC"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.AvisoCobro"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.AvisoCobro"))
            'If dbData(dtAC.Rows(0), "Contacto") <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & dbData(dtAC.Rows(0), "Contacto"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser(dbData(FilAC, "UsuarioGrabacion"), dbData(FilAC, "FechaGrabacion")))

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo)

            Rep.CRViewer.ReportSource = Reporte
            Rep.Show()

            'si hay un parametro activo que indique que esta impresion se incluya en los envios simples
            Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.AC")).Trim.ToUpper
            Dim IdFlujoDefault As String = ""
            If RutearDocumento = True Then
                If IncluirEnEvioSimple = "S" Then
                    Try
                        IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                    Catch ex As Exception
                        IdFlujoDefault = ""
                    End Try
                    If parIdFlujoDoc <> "" Then IdFlujoDefault = parIdFlujoDoc

                    If IdFlujoDefault <> "" Then
                        Dim IdCorrespondencia As String = "AC-" & IdAC
                        clFlujos.RegistrarDocumento(IdFlujoDefault, "Aviso de Cobro: " & IdAC, dbData(FilAC, "IdCliente"), IdAC, "SALIDA", IdCorrespondencia, "", Date.Today, NombreAtt:=parAtteNombre, CodigoImpresionDocumento:="AC")

                        StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set usuarioimprime = (select top 1 IdUsuarioDestino from FlujosDocumentos where IdFlujoDoc = " & dbstr(IdFlujoDefault) & ") where IdFlujoDoc = " & dbstr(IdFlujoDefault) & " and IdImpresion = " & dbstr(IdCorrespondencia))

                        Dim Direccion As String = ""
                        Try
                            Direccion = StiGlobalConn.ObtenerDataset("select top 1 isnull(Direccion,'') from ClientesContactos where idcliente = " & dbStr(dbData(FilAC, "IdCliente")) & " and Direccion is not null order by UsoCorrespondencia desc").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            Direccion = ""
                        End Try
                        Dim strSQL As String = ""

                        ''ruteamos el documento
                        'strSQL = "  insert into FlujosDocumentosImpresiones "
                        'strSQL &= " (IdFlujoDoc, IdImpresion, Descripcion, FechaImpresion, UsuarioImprime, Claves, TipoFlujo, IdDestinatario, FechaEnDocumento, FechaMovimiento, NombreDestinatario, DireccionDocumento, IdOrigen) values( "
                        'strSQL &= dbStr(IdFlujoDefault, 25) & C & dbStr("AC:" & IdAC, 25) & C & dbStr("Aviso de Cobro: " & IdAC, 100) & C & dbFec(clSeguros.ObtenerFechaServidor(), "1") & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(IdAC, 100) & C & dbStr("SALIDA", 10) & C & dbStr("", 50) & C & dbFec(Date.Today) & C & dbFec(Date.Now, "1") & C & dbStr(dbData(dtAC.Rows(0), "NombreCliente")) & C & dbStr(Direccion, 250) & C & dbStr(dbData(dtAC.Rows(0), "NombreCliente")) & ")"
                        'StiGlobalConn.SQLExecute(strSQL)

                        'ruteamos el documento

                        strSQL = "  update FlujosDocumentosImpresiones set "
                        strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                        strSQL &= " ,DireccionDocumento = " & dbStr(Direccion, 250)
                        strSQL &= " ,NombreDestinatario = " & dbStr(dbData(dtAC.Rows(0), "NombreCliente"), 150)
                        strSQL &= " ,IdOrigen = " & dbStr(dbData(dtAC.Rows(0), "NombreCliente"), 250)
                        strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
                        StiGlobalConn.SQLExecute(strSQL)
                    End If
                Else
                    Dim msgflujo As String = clFlujos.IniciarFlujoAC(IdAC)
                    If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")
                End If
            End If

            'si la fecha de recepción es mayor a la fecha de facturación, emitimos un documento para la aseguradora
            Try
                If CDate(dbData(FilAC, "FechaNotificacion")) > CDate(dbData(FilAC, "FechaInicialPago")) And CStr(clSeguros.ObtenerDBParametros("Generar.CartaTardia")).Trim.ToUpper = "SI" Then
                    Dim RepC As New repCartaACTardio
                    Dim RepCR As New frmReportes

                    RepC.SetDataSource(dsRep)

                    SetRepFormulaString(RepC, "ResponsableAC", clSeguros.ObtenerDBParametros("Responsable.Gestion.AC"))
                    SetRepFormulaString(RepC, "Gerente", ObtenerFirma("Firma.Nombre.CartaTardia"))
                    SetRepFormulaString(RepC, "CargoGerente", ObtenerFirma("Firma.Cargo.CartaTardia"))
                    SetRepFormulaString(RepC, "UserLog", ObtenerLogUser(dbData(FilAC, "UsuarioGrabacion")))

                    SetRepFormulaString(RepC, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
                    SetRepFormulaString(RepC, "NombreEmpresa", ObtenerParametro("Cliente"))
                    SetRepFormulaString(RepC, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
                    SetRepFormulaString(RepC, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
                    SetRepFormulaString(RepC, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

                    If parFirmaNombre.Trim <> "" Then SetRepFormulaString(RepC, "Gerente", parFirmaNombre.Trim)
                    If parFirmaCargo.Trim <> "" Then SetRepFormulaString(RepC, "CargoGerente", parFirmaCargo)
                    If parAtteNombre.Trim <> "" Then SetRepFormulaString(RepC, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
                    If parAtteCargo.Trim <> "" Then SetRepFormulaString(RepC, "AtencionCargo", parAtteCargo)

                    'si hay un parametro activo que indique que esta impresion se incluya en los envios simples
                    IncluirEnEvioSimple = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.ACTardio")).Trim.ToUpper
                    If RutearDocumento = True Then
                        If IncluirEnEvioSimple = "S" Then
                            Try
                                IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                            Catch ex As Exception
                                IdFlujoDefault = ""
                            End Try
                            If parIdFlujoDoc <> "" Then IdFlujoDefault = parIdFlujoDoc
                            If IdFlujoDefault <> "" Then
                                Dim IdCorrespondencia As String = "" '"AC-" & IdAC
                                clFlujos.RegistrarDocumento(IdFlujoDefault, "Carta Aviso de Cobro Tardio: " & IdAC, "", IdAC, "SALIDA", IdCorrespondencia, "", Date.Today, NombreAtt:=parAtteNombre, EsDocumentoDeCobro:=True, DocCobroReutilizaCorrelativo:=True, CodigoImpresionDocumento:="AC")
                                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set usuarioimprime = (select top 1 IdUsuarioDestino from FlujosDocumentos where IdFlujoDoc = " & dbstr(IdFlujoDefault) & ") where IdFlujoDoc = " & dbstr(IdFlujoDefault) & " and IdImpresion = " & dbstr(IdCorrespondencia))

                                SetRepFormulaString(RepC, "NumeroSecuencia", IdCorrespondencia)

                                Dim Direccion As String = "", NombreDestinatario As String = ""
                                Try
                                    Direccion = StiGlobalConn.ObtenerDataset("select top 1 isnull(ase.Direccion,'') from Aseguradoras as ase inner join Productos as pr on pr.idaseguradora = ase.idaseguradora inner join AvisosCobro as ac on ac.idproducto = pr.idproducto where ac.IdAvisoCobro = " & dbStr(IdAC)).Tables(0).Rows(0).Item(0)
                                    Dim srtParAsegNombreCorto As String = CStr(clSeguros.ObtenerDBParametros("Coor.Aseguradora.Sigla")).Trim.ToUpper
                                    If srtParAsegNombreCorto = "S" Then
                                        NombreDestinatario = StiGlobalConn.ObtenerDataset("select top 1 isnull(ase.Siglas,'') from Aseguradoras as ase inner join Productos as pr on pr.idaseguradora = ase.idaseguradora inner join AvisosCobro as ac on ac.idproducto = pr.idproducto where ac.IdAvisoCobro = " & dbStr(IdAC)).Tables(0).Rows(0).Item(0)
                                    Else
                                        NombreDestinatario = StiGlobalConn.ObtenerDataset("select top 1 isnull(ase.Nombre,'') from Aseguradoras as ase inner join Productos as pr on pr.idaseguradora = ase.idaseguradora inner join AvisosCobro as ac on ac.idproducto = pr.idproducto where ac.IdAvisoCobro = " & dbStr(IdAC)).Tables(0).Rows(0).Item(0)
                                    End If

                                Catch ex As Exception
                                    Direccion = ""
                                End Try

                                Dim strSQL As String = ""
                                'ruteamos el documento
                                ''strSQL = "  insert into FlujosDocumentosImpresiones "
                                ''strSQL &= " (IdFlujoDoc, IdImpresion, Descripcion, FechaImpresion, UsuarioImprime, Claves, TipoFlujo, IdDestinatario, FechaEnDocumento, FechaMovimiento, NombreDestinatario, DireccionDocumento, IdOrigen) values( "
                                ''strSQL &= dbStr(IdFlujoDefault, 25) & C & dbStr(IdCorrespondencia, 25) & C & dbStr("Carta Aviso de Cobro Tardio: " & IdAC, 100) & C & dbFec(clSeguros.ObtenerFechaServidor(), "1") & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(IdAC, 100) & C & dbStr("SALIDA", 10) & C & dbStr("", 50) & C & dbFec(Date.Today) & C & dbFec(Date.Now, "1") & C & dbStr(NombreDestinatario, 150) & C & dbStr(Direccion, 250) & C & dbStr(dbData(dtAC.Rows(0), "NombreCliente"), 250) & ")"
                                ''StiGlobalConn.SQLExecute(strSQL)

                                strSQL = "  update FlujosDocumentosImpresiones set "
                                strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                                strSQL &= " ,DireccionDocumento = " & dbStr(Direccion, 250)
                                strSQL &= " ,NombreDestinatario = " & dbStr(NombreDestinatario, 150)
                                strSQL &= " ,IdOrigen = " & dbStr(dbData(dtAC.Rows(0), "NombreCliente"), 250)
                                strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
                                StiGlobalConn.SQLExecute(strSQL)
                            Else
                                SetRepFormulaString(RepC, "NumeroSecuencia", "COB-" & IdAC)
                            End If
                        End If

                    End If


                    RepCR.CRViewer.ReportSource = RepC
                    RepCR.Show()

                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Public Sub ImprimirPago(ByVal NumeroFactura As String, ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdRamo As String, ByVal IdMovimiento As Integer, ByVal CodigoCorrespondencia As String)
        Try
            'Generaremos la impresion del aviso de cobros

            Dim Reporte As Object
            Reporte = New repPagos
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Cartera.Pagos")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)
            Dim Rep As New frmReportes

            Dim sql As String = ""
            Dim Nota As String = "", Saldo As Double = 0

            'Try
            '    'si el cliente sigue con primas pendientes según estado de cuenta reportamos una nota.
            '    sql = "  select sum(Total)"
            '    sql &= " from Facturas as f"
            '    sql &= " inner join  facturasMovimientos as m on m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo"
            '    sql &= " where f.FechaPago <= " & dbFec(Date.Today.AddDays(30))
            '    sql &= " and f.IdCliente in (select idcliente from Facturas where NumeroFactura = " & dbInt(NumeroFactura) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(IdPoliza) & " and idramo = " & dbStr(IdRamo) & ") "
            '    sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
            '    Saldo = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
            'Catch ex As Exception
            '    Saldo = 0
            'End Try
            'If Saldo > 0 Then Nota = "Se adjunta Estado de Cuenta después del cargo realizado para su información."


            'si hay recibo para la factura con cambio recibido damos por entregado el cambio
            Dim Efectivo As Double, Cambio As Double = 0
            Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset("select distinct f.idrecibo from Recibos as r inner join RecibosFacturas as f on f.idrecibo = r.idrecibo where r.CambioRecibio = 'S' and f.NumeroFactura = " & dbInt(NumeroFactura) & " and f.IdProducto = " & dbStr(IdProducto) & " and f.IdPoliza = " & dbStr(IdPoliza) & " and f.IdRamo = " & dbStr(IdRamo)).Tables(0)
            For Each FilRe As DataRow In dtRecibos.Rows
                StiGlobalConn.SQLExecute("update recibos set CambioEntregado = 'S' where idrecibo = " & dbStr(dbData(FilRe, "idrecibo")))
                Try
                    Dim dtPag As DataTable = StiGlobalConn.ObtenerDataset("select sum(Total) as Total, sum(Cambio) as Cambio from RecibosPagos where IdTipoIngreso = 'E' and idrecibo = " & dbStr(dbData(FilRe, "idrecibo"))).Tables(0)
                    Efectivo += Val(dbData(dtPag.Rows(0), "Total"))
                    Cambio += Val(dbData(dtPag.Rows(0), "Cambio"))
                Catch ex As Exception

                End Try
            Next
            If Cambio > 0 Or Efectivo > 0 Then
                Nota &= "Se recibió $" & Format(Efectivo, "#,###0.00") & " en efectivo, por lo que se anexa $" & Format(Cambio, "#,###0.00") & " como cambio. "
            End If


            'veremos si hay depósitos
            Try
                Dim dtdep As DataTable = StiGlobalConn.ObtenerDataset("select isnull(sum(f.Total),0) as Depo from Recibos as r inner join RecibosFacturas as f on f.idrecibo = r.idrecibo where f.EnDeposito = 'S' and f.NumeroFactura = " & dbInt(NumeroFactura) & " and f.IdProducto = " & dbStr(IdProducto) & " and f.IdPoliza = " & dbStr(IdPoliza) & " and f.IdRamo = " & dbStr(IdRamo)).Tables(0)
                If Val(dbData(dtdep.Rows(0), "Depo")) > 0 Then
                    Nota &= "Se recibio pago de lo cual se remitió $" & Format(Val(dbData(dtdep.Rows(0), "Depo")), "#,###0.00") & " a depósito."
                End If
            Catch ex As Exception

            End Try


            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",m.FechaMovimiento as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",isnull(abs(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(abs(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(abs(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(abs(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(abs(m.Gastos),0) as Gastos"
            sql &= ",isnull(abs(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(abs(m.Total),0) as Total"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.TipoFactura"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.NombreCliente"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",f.Referencia"
            sql &= ",isnull(f.DocumentoFiscal,'') as DocumentoFiscal"
            sql &= ", '" & Nota & "' as Nota"
            sql &= ", isnull(f.IdCliente,'') as IdCliente"
            sql &= ", isnull((select top 1 re.Observaciones from Recibos as re inner join RecibosFacturas as rf on re.IdRecibo = rf.IdRecibo where rf.NumeroFactura = f.NumeroFactura and rf.IdProducto = f.IdProducto and rf.IdPoliza = f.IdPoliza and rf.IdRamo = f.IdRamo and re.EstadoRecibo <> 'N' ),'') as ObservacionRecibo"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.IdMovimiento = " & dbInt(IdMovimiento)
            sql &= " left join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " inner join Productos as p on p.idproducto = f.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where f.NumeroFactura = " & dbInt(NumeroFactura)
            sql &= " and f.IdProducto = " & dbStr(IdProducto)
            sql &= " and f.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and f.idramo = " & dbStr(IdRamo)


            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If

            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Public Sub ImprimirPago(ByVal IdCliente As String, ByVal ListaFacturas As String, ByVal FiltroFacturas As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String)
        Try
            'Generaremos la impresion del aviso de cobros

            Dim Reporte As Object
            Reporte = New repPagos
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Cartera.Pagos")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)



            Dim Rep As New frmReportes
            Dim sql As String = ""
            Dim Nota As String = "", Saldo As Double = 0

            'Try
            '    'si el cliente sigue con primas pendientes según estado de cuenta reportamos una nota.
            '    sql = "  select sum(Total)"
            '    sql &= " from Facturas as f"
            '    sql &= " inner join  facturasMovimientos as m on m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo"
            '    sql &= " where f.FechaPago <= " & dbFec(Date.Today.AddDays(30))
            '    sql &= " and f.IdCliente = " & dbStr(IdCliente)
            '    sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
            '    Saldo = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
            'Catch ex As Exception
            '    Saldo = 0
            'End Try
            'If Saldo > 0 Then Nota = "Se adjunta Estado de Cuenta después del cargo realizado para su información."

            'si hay recibo para la factura con cambio recibido damos por entregado el cambio

            If FiltroFacturas <> "" Then
                Dim Efectivo As Double, Cambio As Double = 0
                Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset("select distinct f.idrecibo from Recibos as r inner join RecibosFacturas as f on f.idrecibo = r.idrecibo where r.CambioRecibio = 'S' " & FiltroFacturas).Tables(0)
                For Each FilRe As DataRow In dtRecibos.Rows
                    StiGlobalConn.SQLExecute("update recibos set CambioEntregado = 'S' where idrecibo = " & dbStr(dbData(FilRe, "idrecibo")))
                    Try
                        Dim dtPag As DataTable = StiGlobalConn.ObtenerDataset("select sum(Total) as Total, sum(Cambio) as Cambio from RecibosPagos where IdTipoIngreso = 'E' and idrecibo = " & dbStr(dbData(FilRe, "idrecibo"))).Tables(0)
                        Efectivo += Val(dbData(dtPag.Rows(0), "Total"))
                        Cambio += Val(dbData(dtPag.Rows(0), "Cambio"))
                    Catch ex As Exception

                    End Try
                Next
                If Cambio > 0 Or Efectivo > 0 Then Nota &= "Se recibió $" & Format(Efectivo, "#,###0.00") & " en efectivo, por lo que se anexa $" & Format(Cambio, "#,###0.00") & " como cambio. "

                'veremos si hay depósitos
                Try
                    Dim dtdep As DataTable = StiGlobalConn.ObtenerDataset("select isnull(sum(f.Total),0) as Depo from Recibos as r inner join RecibosFacturas as f on f.idrecibo = r.idrecibo where f.EnDeposito = 'S' " & FiltroFacturas).Tables(0)
                    If Val(dbData(dtdep.Rows(0), "Depo")) > 0 Then
                        Nota &= "Se recibio pago de lo cual se remitió $" & Format(Val(dbData(dtdep.Rows(0), "Depo")), "#,###0.00") & " a depósito."
                    End If
                Catch ex As Exception

                End Try

            End If


            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",m.FechaMovimiento as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",isnull(abs(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(abs(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(abs(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(abs(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(abs(m.Gastos),0) as Gastos"
            sql &= ",isnull(abs(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(abs(m.Total),0) as Total"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.TipoFactura"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.NombreCliente"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",f.Referencia"
            sql &= ", isnull((select top 1 re.Observaciones from Recibos as re inner join RecibosFacturas as rf on re.IdRecibo = rf.IdRecibo where rf.NumeroFactura = f.NumeroFactura and rf.IdProducto = f.IdProducto and rf.IdPoliza = f.IdPoliza and rf.IdRamo = f.IdRamo and re.EstadoRecibo <> 'N' ),'') as ObservacionRecibo"
            sql &= ",isnull(f.DocumentoFiscal,'') as DocumentoFiscal"
            sql &= ", '" & Nota & "' as Nota"
            sql &= ", isnull(f.IdCliente,'') as IdCliente"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and M.TipoMovimiento = 'PAGO' "
            sql &= " left join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " inner join Productos as p on p.idproducto = f.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where f.IdCliente = " & dbStr(IdCliente)

            If ListaFacturas <> "" Then
                Dim lstFac As String = ObtenerListaNumericaPatron(ListaFacturas)
                If lstFac <> "" Then
                    sql &= " and f.NumeroFactura in (" & lstFac & ") "
                End If
            End If

            If FiltroFacturas <> "" Then
                sql &= " " & FiltroFacturas
            End If

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            'Try
            '    SetRepFormulaString(Reporte,"NombreAtencion", StiGlobalConn.ObtenerDataset("select 'Atn.:' + Nombre from ClientesContactos where IdCliente = " & dbStr(IdCliente) & " and Funciones like '%PAGOS%'").Tables(0).Rows(0).Item(0))
            'Catch ex As Exception

            'End Try

            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Public Sub ImprimirEmision(ByVal NumeroFactura As String, ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdRamo As String, ByVal IdMovimiento As Integer, ByVal CodigoCorrespondencia As String)
        Try
            'Generaremos la impresion del aviso de cobros

            Dim Reporte As New RepEmisiones
            Dim Rep As New frmReportes
            Dim sql As String = ""

            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",getdate() as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",isnull(abs(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(abs(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(abs(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(abs(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(abs(m.Gastos),0) as Gastos"
            sql &= ",isnull(abs(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(abs(m.Total),0) as Total"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.TipoFactura"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.NombreCliente"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ", f.Referencia"
            sql &= ",isnull(f.DocumentoFiscal,'') as DocumentoFiscal"
            sql &= ", isnull(f.IdCliente,'') as IdCliente"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.IdMovimiento = " & dbInt(IdMovimiento)
            sql &= " left join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " inner join Productos as p on p.idproducto = f.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where f.NumeroFactura = " & dbInt(NumeroFactura)
            sql &= " and f.IdProducto = " & dbStr(IdProducto)
            sql &= " and f.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and f.idramo = " & dbStr(IdRamo)


            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            SetRepFormulaString(Reporte, "NumeroSecuencia", "")
            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If

            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Public Sub ImprimirEmision(ByVal IdCliente As String, ByVal ListaFacturas As String, ByVal FiltroFacturas As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String)
        Try
            'Generaremos la impresion las cartas de cobro a los clientes
            Dim Reporte As Object
            Reporte = New RepEmisiones
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.CartaCobroAnticipado")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim Rep As New frmReportes
            Dim sql As String = ""

            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",getdate() as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",isnull(abs(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(abs(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(abs(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(abs(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(abs(m.Gastos),0) as Gastos"
            sql &= ",isnull(abs(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(abs(m.Total),0) as Total"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.TipoFactura"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.NombreCliente"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ", f.Referencia"
            sql &= ",isnull(f.DocumentoFiscal,'') as DocumentoFiscal"
            sql &= ", isnull(f.IdCliente,'') as IdCliente"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.IdMovimiento = 1"
            sql &= " left join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " inner join Productos as p on p.idproducto = f.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where f.IdCliente = " & dbStr(IdCliente)

            If ListaFacturas <> "" Then
                Dim lstFac As String = ObtenerListaNumericaPatron(ListaFacturas)
                If lstFac <> "" Then
                    sql &= " and f.NumeroFactura in (" & lstFac & ") "
                End If
            End If

            If FiltroFacturas <> "" Then
                sql &= " " & FiltroFacturas
            End If

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)

            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If

            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Public Sub ImprimirEstadoCuenta(ByVal IdCliente As String, ByVal FiltroClientes As String, ByVal ListaFacturas As String, ByVal FiltroFacturas As String, ByVal RutaExportarReporte As String, ByVal FormatoExportar As CrystalDecisions.Shared.ExportFormatType, ByVal IncluirTodasFacturas As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String, Optional ByRef MensajeError As String = "")
        Try
            Dim Reporte As Object
            Reporte = New repEstadoCuenta
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.EstadoCuenta")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim Rep As New frmReportes
            Dim sql As String = ""

            'primero cargamos el registro del cliente
            sql = " select c.idcliente "
            sql &= " ,c.NombreCliente"
            sql &= " ,isnull(e.NombreUsuario,'') as Ejecutivo"
            sql &= " ,isnull(e.Telefono,'') as TelefonoEjecutivo"
            sql &= "," & dbStr("Usuario: " & StiGlobalConn.User & Chr(13) & "Fecha: " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss")) & " as Log"
            sql &= " ,'" & Format(Date.Today, "Long Date") & "' as FechaCorte"
            sql &= " ,(select top 1 cc.Direccion from ClientesContactos as cc where cc.IdCliente = c.idcliente order by UsoCorrespondencia desc, IdContacto asc) as Direccion"
            sql &= " ,(select top 1 cc.Ciudad from ClientesContactos as cc where cc.IdCliente = c.idcliente order by UsoCorrespondencia desc, IdContacto asc) as Ciudad"
            sql &= " ,(select top 1 cc.Telefono from ClientesContactos as cc where cc.IdCliente = c.idcliente order by UsoCorrespondencia desc, IdContacto asc) as Telefono"
            sql &= " ,case c.IdTipoCliente when 'NA' then '' else (select top 1 'Atención: ' + cc.Nombre from ClientesContactos as cc where cc.IdCliente = c.idcliente order by UsoCorrespondencia desc, IdContacto asc) end as Contacto"
            sql &= " , (select sum(m.Total) from Facturas as f inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo where f.IdCliente = c.idcliente and (select sum(m1.Total) from FacturasMovimientos as m1 where m1.NumeroFactura = m.NumeroFactura and m1.IdProducto = m.IdProducto and m1.IdPoliza = m.IdPoliza and m1.idramo = m.idramo and m1.fechamovimiento <= " & dbFec(Date.Today) & " ) > 0 and f.FechaPago <= " & dbFec(Date.Today.AddDays(-30)) & " ) as TotalMora"
            sql &= " from Clientes as c "
            sql &= " left join usuarios as e on c.EjecutivoCta = e.IdUsuario"
            sql &= " where c.idcliente is not null "
            If IdCliente <> "" Then
                sql &= " and c.idcliente = " & dbStr(IdCliente)
            End If
            If FiltroClientes <> "" Then
                sql &= " " & FiltroClientes
            End If
            Dim dtAC As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtAC.TableName = "Clientes"

            sql = "  select f.IdCliente"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",f.FechaPago as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",m.IdProducto, m.IdPoliza as Poliza, m.idramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.Descripcion as Producto"
            sql &= ",DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as Dias"
            sql &= ",f.DocumentoFiscal"
            'sql &= ", case  when (select count(*) from FlujosDocumentos as fl where fl.IdFlujo = " & dbStr(clSeguros.ObtenerDBParametros("Flujo.Cartera.Cobro")) & " and fl.IdPoliza = m.IdPoliza and fl.IdProducto = m.IdProducto and fl.NumeroFactura = f.NumeroFactura and fl.IdRamo = m.IdRamo) > 0 then 'SI: ' + isnull(f.DocumentoFiscal,'') else '' end as DocFiscalEnv"
            sql &= ", case  when (select count(*) from FlujosDocumentos as fl inner join FlujosDocumentosImpresiones as d1 on fl.IdFlujoDoc = d1.IdFlujoDoc where fl.Idcliente = f.idcliente and d1.claves like '%' + cast(f.NumeroFactura as varchar(50)) + '%' and d1.Descripcion like '%Carta de Cobro%') > 0 then 'SI: ' + isnull(f.DocumentoFiscal,'') else '' end as DocFiscalEnv"
            sql &= ",cast(a.FormasPago as varchar(8000)) as FormaPago"
            sql &= ", f.VencimientoTardio as PagoTardio"
            sql &= ", isnull(f.Referencia,'') as Referencia"
            sql &= ",isnull(sum(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(sum(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(sum(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(sum(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(sum(m.Gastos),0) as Gastos"
            sql &= ",isnull(sum(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(sum(m.Total),0) as Total"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo"
            sql &= " left join Productos as p on p.idproducto = f.idproducto"
            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join Clientes as c on c.idcliente = f.idcliente"
            sql &= " where f.NumeroFactura is not null "
            'con saldo al corte
            sql &= " and (select sum(m1.Total) from FacturasMovimientos as m1 where m1.NumeroFactura = m.NumeroFactura and m1.IdProducto = m.IdProducto and m1.IdPoliza = m.IdPoliza and m1.idramo = m.idramo and m1.fechamovimiento <= " & dbFec(Date.Today) & " ) > 0"

            'atrasadas y hasta 30 días
            If IncluirTodasFacturas.Trim.ToUpper <> "S" Then
                sql &= " and f.FechaPago <= " & dbFec(Date.Today.AddDays(30))
            End If

            'del cliente
            If IdCliente <> "" Then
                sql &= " and f.IdCliente = " & dbStr(IdCliente)
            End If

            If FiltroClientes <> "" Then
                sql &= " " & FiltroClientes
            End If

            If ListaFacturas <> "" Then
                Dim lstFac As String = ObtenerListaNumericaPatron(ListaFacturas)
                If lstFac <> "" Then
                    sql &= " and f.NumeroFactura in (" & lstFac & ") "
                End If
            End If

            If FiltroFacturas <> "" Then
                sql &= " " & FiltroFacturas
            End If

            sql &= " group by f.IdCliente, f.NumeroFactura,f.FechaPago, f.NumCuota, f.TotalCuotas, cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar), m.IdProducto, m.IdPoliza, m.idramo,a.Nombre, p.Descripcion, cast(a.FormasPago as varchar(8000)),f.DocumentoFiscal, f.VencimientoTardio, f.Referencia "

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            If dtFA.Rows.Count = 0 Then
                MensajeError = "No se encuentran facturas pendientes"
                Exit Sub
            End If

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtAC.Copy)
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)
            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "NumEstadoCuenta", clSeguros.ObtenerID("NumEstadoCuenta"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "ResponsableAC", clSeguros.ObtenerDBParametros("Responsable.Gestion.AC"))

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Rep.CRViewer.ReportSource = Reporte

            If RutaExportarReporte <> "" Then
                Reporte.ExportToDisk(FormatoExportar, RutaExportarReporte)
            Else
                Rep.Show()
            End If
        Catch ex As Exception
            MensajeError = ex.Message
        End Try
    End Sub

    Public Sub RegistrarAperturaCaja(ByVal Fecha As DateTime)
        Try
            Dim sql As String = ""
            'verificamos si el día ya se abrió, puede abrirse varias veces en el día pero hay un resumen por día
            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from DiasCaja where FechaCaja = " & dbFec(Fecha)).Tables(0).Rows(0).Item(0)
            If Existe = 0 Then

                Dim IdDia As Integer = clSeguros.ObtenerID("Num.Dia.Caja")

                sql = " insert into DiasCaja "
                sql &= " (IdDiaCaja, FechaCaja, UsuarioApertura, FechaApertura) "
                sql &= " values (" & dbInt(IdDia) & C & dbFec(Fecha) & C & dbStr(StiGlobalConn.User) & C & dbFec(Date.Now, "1") & ") "
                StiGlobalConn.SQLExecute(sql)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RegistrarAperturaOfertas(ByVal Fecha As DateTime)
        Try
            Dim sql As String = ""
            'verificamos si el día ya se abrió, puede abrirse varias veces en el día pero hay un resumen por día
            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from DiasOfertas where FechaOfertas = " & dbFec(Fecha)).Tables(0).Rows(0).Item(0)
            If Existe = 0 Then

                Dim IdDia As Integer = clSeguros.ObtenerID("Num.Dia.Oferta")

                sql = " insert into DiasOfertas "
                sql &= " (IdDiaOferta, FechaOfertas, UsuarioAbre, FechaAbre) "
                sql &= " values (" & dbInt(IdDia) & C & dbFec(Fecha) & C & dbStr(StiGlobalConn.User) & C & dbFec(Date.Now, "1") & ") "
                StiGlobalConn.SQLExecute(sql)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RegistrarCierreCaja(ByVal Fecha As DateTime)
        Try
            Dim sql As String = ""
            'verificamos si el día ya se abrió, puede abrirse varias veces en el día pero hay un resumen por día
            Dim IdDia As Integer = StiGlobalConn.ObtenerDataset("select IdDiaCaja from DiasCaja where FechaCaja = " & dbFec(Fecha)).Tables(0).Rows(0).Item(0)
            If IdDia > 0 Then
                sql = "  update DiasCaja set "
                sql &= " UsuarioCierre = " & dbStr(StiGlobalConn.User)
                sql &= " , FechaCierre = " & dbFec(Date.Now, "1")
                sql &= " where IdDiaCaja = " & dbInt(IdDia)
                StiGlobalConn.SQLExecute(sql)

                'ahora registramos los recibos que se mandan
                StiGlobalConn.SQLExecute("delete from DiasCajaRecibos where IdDiaCaja = " & dbInt(IdDia))
                Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset("select IdRecibo from Recibos where FechaRecibo = " & dbFec(Fecha)).Tables(0)
                Dim FilRec As DataRow
                For Each FilRec In dtRecibos.Rows
                    sql = "  insert into  DiasCajaRecibos"
                    sql &= " (IdDiaCaja, IdRecibo) values ("
                    sql &= dbInt(IdDia) & C & dbInt(dbData(FilRec, "IdRecibo")) & ")"
                    StiGlobalConn.SQLExecute(sql)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Gestión Caja"

    Public Sub ImprimirRecibo(ByVal NumRecibo As String, ByVal RutearDocumento As Boolean)
        If NumRecibo <> "" Then
            Try
                Dim dtRecibo As New DataTable, sql As String = ""

                sql = "  select IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo, EstadoRecibo"
                sql &= " ,'' as MontoLetras, isnull((select NombreUsuario from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " ),'') as UsuarioEmite "
                sql &= ", rtrim(isnull((select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = Recibos.IdCliente and cc.usocorrespondencia = 'S' order by IdContacto asc),'') + ' ' + isnull((select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = Recibos.IdCliente order by IdContacto asc),'')) as Direccion"
                sql &= ", Observaciones "
                sql &= ", isnull((select sum(isnull(Cambio,0)) from RecibosPagos where RecibosPagos.IdRecibo = Recibos.IdRecibo ),0) as Cambio"
                sql &= " from Recibos where IdRecibo = " & dbStr(NumRecibo)

                dtRecibo = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                Dim NumLet As New Utilerias.Num2Letras
                dtRecibo.Rows(0).Item("MontoLetras") = NumLet.Numero2Letra(Format(Val(dtRecibo.Rows(0).Item("TotalRecibo")), "###0.00"), , 2, "Dolar", "Centavo", Utilerias.Num2Letras.eSexo.Masculino, Utilerias.Num2Letras.eSexo.Masculino).ToUpper

                dtRecibo.TableName = "Recibos"

                Dim dtRecibosFacturas As New DataTable
                sql = "  select r.IdRecibo, r.NumeroFactura, r.IdProducto, r.IdPoliza, r.IdRamo, r.NombreCliente"
                sql &= " , r.Total, a.Nombre as Aseguradora, isnull((select top 1 c.IdAvisoCobro from AvisosCobroFacturas c where c.IdPoliza = r.IdPoliza and c.IdProducto = r.IdProducto and c.NumeroFactura = r.NumeroFactura and c.IdRamo = r.IdRamo),'') as AvisoCobro"
                sql &= " ,'Cuota:' + cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) + ' - Ref. ' + isnull(f.Referencia,'') as Notas"
                sql &= " , f.FechaPago as FechaVencimiento"

                sql &= " from RecibosFacturas as r"
                sql &= " inner join Facturas as f on f.NumeroFactura = r.NumeroFactura and f.IdProducto = r.IdProducto and f.IdPoliza = r.IdPoliza and f.IdRamo = r.IdRamo "
                sql &= " inner join Productos as p on r.idproducto = p.idproducto"
                sql &= " inner join Aseguradoras as a on  a.idaseguradora = p.idaseguradora"
                sql &= " where r.IdRecibo = " & dbStr(NumRecibo)

                dtRecibosFacturas = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                dtRecibosFacturas.TableName = "RecibosFacturas"

                Dim dtRecibosOtrosIngresos As New DataTable

                sql = "  select o.IdRecibo, o.IdOtroIngreso, o.IdAseguradora, o.Descripcion, o.Total, a.nombre as Aseguradora "
                sql &= " from RecibosOtrosIngresos as o"
                sql &= " inner join aseguradoras as a on a.idaseguradora = o.idaseguradora"
                sql &= " where o.IdRecibo = " & dbStr(NumRecibo)
                dtRecibosOtrosIngresos = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                dtRecibosOtrosIngresos.TableName = "RecibosOtrosIngresos"

                Dim dtRecibosPagos As New DataTable
                sql = " select IdRecibo, IdPago"
                sql &= " , case IdTipoIngreso wheN 'E' then 'EFECTIVO' when 'C' then 'CHEQUE' when 'T' then 'TARJETA' when 'N' then 'NOTA DE CREDITO' when 'A' then 'DEPOSITO EN ASEGURADORA' else 'DEPOSITO' end as IdTipoIngreso"
                sql &= " , IdBanco, Documento, NumConfirmacion, Total "
                sql &= " from RecibosPagos"
                sql &= " where IdRecibo = " & dbStr(NumRecibo)
                dtRecibosPagos = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                dtRecibosPagos.TableName = "RecibosPagos"


                'si hay un parametro activo que indique que esta impresion se incluya en los envios simples
                Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.Recibos")).Trim.ToUpper
                Dim IdFlujoDefault As String = ""
                If IncluirEnEvioSimple = "S" And RutearDocumento = True Then
                    Try
                        IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                    Catch ex As Exception
                        IdFlujoDefault = ""
                    End Try
                    If IdFlujoDefault <> "" Then
                        Dim IdCorrespondencia As String = "RC-" & NumRecibo
                        clFlujos.RegistrarDocumento(IdFlujoDefault, "Recibo de Caja: " & NumRecibo, dbData(dtRecibo.Rows(0), "IdCliente"), NumRecibo, "SALIDA", IdCorrespondencia, "", Date.Today, CodigoImpresionDocumento:="VA")
                        Dim Direccion As String = ""
                        Try
                            Direccion = StiGlobalConn.ObtenerDataset("select top 1 isnull(Direccion,'') from ClientesContactos where idcliente = " & dbStr(dbData(dtRecibo.Rows(0), "IdCliente")) & " and Direccion is not null order by UsoCorrespondencia desc").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            Direccion = ""
                        End Try

                        'ruteamos el documento
                        Dim strSQL As String = ""
                        strSQL = "  update FlujosDocumentosImpresiones set "
                        strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                        strSQL &= " ,DireccionDocumento = " & dbStr(Direccion, 250)
                        strSQL &= " ,NombreDestinatario = " & dbStr(dbData(dtRecibo.Rows(0), "NombreCliente"), 150)
                        strSQL &= " ,IdOrigen = " & dbStr(dbData(dtRecibo.Rows(0), "NombreCliente"), 250)
                        strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
                        StiGlobalConn.SQLExecute(strSQL)
                    End If
                End If

                Dim dsRecibo As New DataSet
                dsRecibo.Tables.Add(dtRecibo.Copy)
                dsRecibo.Tables.Add(dtRecibosFacturas.Copy)
                dsRecibo.Tables.Add(dtRecibosOtrosIngresos.Copy)
                dsRecibo.Tables.Add(dtRecibosPagos.Copy)
                dsRecibo.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes
                'Dim Reporte As New RepRecibos
                Dim Reporte As Object
                Reporte = New RepRecibos
                Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.RecibosCaja")
                If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)
                Reporte.SetDataSource(dsRecibo)

                SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.GerCierreCaja"))
                SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.GerCierreCaja"))

                rep.CRViewer.ReportSource = Reporte
                rep.ShowDialog()
            Catch ex As Exception
                msgError(ex)
            End Try
        End If
    End Sub

    Public Function GenerarEnvioCaja(ByVal FechaCorte As DateTime, ByRef lstEnvios As String) As String
        Dim res As String = ""
        Try
            Dim NumRecibos As Integer = 0
            Try
                NumRecibos = StiGlobalConn.ObtenerDataset("select count(*) from Recibos where EnviadoAseguradoras = 'P' and FechaRecibo <= " & dbFec(FechaCorte)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                NumRecibos = 0
            End Try

            If NumRecibos = 0 Then
                res = "No se encontraron recibos pendientes por enviar a las aseguradoras."
                Return res
            End If

            Dim sql As String = ""
            Dim IdEnvio As String = ""
            lstEnvios = ""

            Try
                StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                'primer paso vamos a obtener una lista de los recibos y las aseguradoras
                'esta es la lista completa de recibos, hacemos la lista para reservarlos en la transacción
                Dim Recibos As DataTable = StiGlobalConn.ObtenerDataset("select idrecibo from recibos where EnviadoAseguradoras = 'P' and EstadoRecibo <> 'N' and FechaRecibo <= " & dbFec(FechaCorte)).Tables(0)
                Dim FilRec As DataRow
                Dim RecibosAseg As DataTable


                'SE HARÁ UN NÚMERO DE ENVIO POR ASEGURADORA
                sql = "  select distinct p.idaseguradora"
                sql &= " from RecibosFacturas as r"
                sql &= " inner join Productos as p on r.idproducto = p.idproducto"
                sql &= " where IdRecibo in (select idrecibo from recibos where EnviadoAseguradoras = 'P' and EstadoRecibo <> 'N' and FechaRecibo <= " & dbFec(FechaCorte) & ")"
                sql &= " union"
                sql &= " select distinct idaseguradora from "
                sql &= " RecibosOtrosIngresos "
                sql &= " where IdRecibo in (select idrecibo from recibos where EnviadoAseguradoras = 'P' and EstadoRecibo <> 'N' and FechaRecibo <= " & dbFec(FechaCorte) & ")"
                Dim tblAseguradoras As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)

                Dim FilAseg As DataRow
                For Each FilAseg In tblAseguradoras.Rows
                    'SEGUNDO PASO, VAMOS A GUARDAR EL ENVIO Y RECIBOS RELACIONADOS
                    IdEnvio = clSeguros.ObtenerID("Num.EnvioPago." & Date.Today.Year, EstaEnTransaccion:=True) & "-" & Date.Today.Year

                    If lstEnvios = "" Then
                        lstEnvios = dbStr(IdEnvio)
                    Else
                        lstEnvios &= ", " & dbStr(IdEnvio)
                    End If

                    sql = "  insert into EnviosPago "
                    sql &= " (IdEnvio, FechaCorte, FechaEnvio, IdUsuario, IdAseguradora ) values ("
                    sql &= dbStr(IdEnvio) & C & dbFec(FechaCorte) & C & dbFec(Date.Now, "1") & C & dbStr(StiGlobalConn.User) & C & dbStr(dbData(FilAseg, "idaseguradora")) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    'la lista de los recibos pero solo de la aseguradora 
                    sql = "  select distinct r.idrecibo"
                    sql &= " from RecibosFacturas as r"
                    sql &= " inner join Productos as p on r.idproducto = p.idproducto"
                    sql &= " where IdRecibo in (select idrecibo from recibos where EnviadoAseguradoras = 'P' and EstadoRecibo <> 'N' and FechaRecibo <= " & dbFec(FechaCorte) & ")"
                    sql &= " and p.idaseguradora = " & dbStr(dbData(FilAseg, "idaseguradora"))
                    sql &= " union"
                    sql &= " select distinct idrecibo from "
                    sql &= " RecibosOtrosIngresos "
                    sql &= " where IdRecibo in (select idrecibo from recibos where EnviadoAseguradoras = 'P' and EstadoRecibo <> 'N' and FechaRecibo <= " & dbFec(FechaCorte) & ")"
                    sql &= " and idaseguradora = " & dbStr(dbData(FilAseg, "idaseguradora"))
                    RecibosAseg = StiGlobalConn.ObtenerDataset(sql).Tables(0)

                    For Each FilRec In RecibosAseg.Rows
                        sql = "  insert into EnviosPagoRecibos "
                        sql &= " (IdEnvio, IdRecibo) values ("
                        sql &= dbStr(IdEnvio) & C & dbStr(dbData(FilRec, "idrecibo")) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    Next

                    'si hay un parametro activo que indique que esta impresion se incluya en los envios simples
                    Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.PlanillaCaja")).Trim.ToUpper
                    Dim IdFlujoDefault As String = ""
                    If IncluirEnEvioSimple = "S" Then
                        Try
                            IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                        Catch ex As Exception
                            IdFlujoDefault = ""
                        End Try
                        If IdFlujoDefault <> "" Then
                            Dim IdCorrespondencia As String = "EP-" & IdEnvio
                            clFlujos.RegistrarDocumento(IdFlujoDefault, "Envío Planilla: " & IdEnvio, "", IdEnvio, "SALIDA", IdCorrespondencia, "", Date.Today, EstaEnTransaccion:=True, CodigoImpresionDocumento:="EP")
                            Dim Direccion As String = "", NombreDestinatario As String = "", ClientesPlanilla As String = ""
                            Try
                                Dim srtParAsegNombreCorto As String = CStr(clSeguros.ObtenerDBParametros("Coor.Aseguradora.Sigla")).Trim.ToUpper
                                If srtParAsegNombreCorto = "S" Then
                                    NombreDestinatario = StiGlobalConn.ObtenerDataset("select isnull(Siglas,'') from Aseguradoras  where idaseguradora =  " & dbStr(dbData(FilAseg, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                                Else
                                    NombreDestinatario = StiGlobalConn.ObtenerDataset("select isnull(Nombre,'') from Aseguradoras  where idaseguradora =  " & dbStr(dbData(FilAseg, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                                End If
                                Direccion = StiGlobalConn.ObtenerDataset("select isnull(Direccion,'') from Aseguradoras  where idaseguradora =  " & dbStr(dbData(FilAseg, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                                ClientesPlanilla = StiGlobalConn.ObtenerDataset("select distinct r.NombreCliente + ',' from EnviosPagoRecibos as er inner join Recibos as r on r.idrecibo = er.idrecibo where er.idenvio = " & dbStr(IdEnvio) & " FOR XML PATH('')").Tables(0).Rows(0).Item(0)
                            Catch ex As Exception
                                Direccion = ""
                            End Try

                            'ruteamos el documento
                            Dim strSQL As String = ""
                            strSQL = "  update FlujosDocumentosImpresiones set "
                            strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                            strSQL &= " ,DireccionDocumento = " & dbStr(Direccion, 250)
                            strSQL &= " ,NombreDestinatario = " & dbStr(NombreDestinatario, 150)
                            strSQL &= " ,IdOrigen = " & dbStr(ClientesPlanilla, 250)
                            strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
                            StiGlobalConn.SQLExecute(strSQL)
                        End If
                    End If


                Next

                'Marcamos los recibos como enviados a las aseguradoras.
                StiGlobalConn.SQLExecute("update Recibos set EnviadoAseguradoras = 'E' where idrecibo in (select idrecibo from recibos where EnviadoAseguradoras = 'P' and FechaRecibo <= " & dbFec(FechaCorte) & ")")

                StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            Catch ex As Exception
                StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                res &= "Error al generar envío: " & ex.Message
            End Try
        Catch ex As Exception
            res &= "Error al generar envío: " & ex.Message
        End Try
        Return res

    End Function

    Public Function ImprimirEnvioCaja(ByVal lstEnvios As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim Reporte As Object
            Reporte = New repEnviosPago
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Envio.Caja")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim sql As String = ""

            Dim dtEnvio As New DataTable
            sql = "  select IdEnvio, FechaEnvio, idusuario as Operador, '' as Hora, IdAseguradora"
            sql &= " from EnviosPago "
            sql &= " where idenvio in (" & lstEnvios & ")"

            dtEnvio = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtEnvio.TableName = "Envios"

            Dim dtRecibo As New DataTable

            sql = "  select IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo, EstadoRecibo, '' as MontoLetras "
            sql &= " ,isnull((select NombreUsuario from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " ),'') as UsuarioEmite "
            sql &= " , isnull(Observaciones,'') as Observaciones"
            sql &= " , isnull((select sum(isnull(cambio,0)) from RecibosPagos where RecibosPagos.IdRecibo = Recibos.IdRecibo ),0) as Cambio"
            sql &= " , (select count(*) from RecibosPagos where RecibosPagos.IdRecibo = Recibos.IdRecibo and RecibosPagos.IdTipoIngreso = 'E') as NumPagEfectivo"
            sql &= " , (select top 1 IdTipoIngreso from RecibosPagos where RecibosPagos.IdRecibo = Recibos.IdRecibo order by IdPago ) as TipoPagoRecibo"
            sql &= " from Recibos where IdRecibo in (select idrecibo from EnviosPagoRecibos where IdEnvio in (" & lstEnvios & ") )"
            dtRecibo = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibo.TableName = "Recibos"

            Dim dtRecibosFacturas As New DataTable
            sql = "  select cast(r.IdRecibo as varchar) + '*' + cast(r.NumeroFactura as varchar) + '*' + r.IdProducto + '*' + r.IdRamo as Id, r.IdRecibo, r.NumeroFactura, r.IdProducto, r.IdPoliza, r.IdRamo, r.NombreCliente, r.Total"
            sql &= " ,a.IdAseguradora ,a.Nombre as Aseguradora, isnull((select top 1 c.IdAvisoCobro from AvisosCobroFacturas c where c.IdPoliza = r.IdPoliza and c.IdProducto = r.IdProducto and c.NumeroFactura = r.NumeroFactura and c.IdRamo = r.IdRamo),'') as AvisoCobro "
            sql &= " , p.Descripcion as Producto, 'Cuota:' + cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar)  + ' - Ref. ' + isnull(f.Referencia,'') as Notas"
            sql &= " , '' as Banco, '' as Cheque, '' as Confirmacion, '' as TipoPago"
            sql &= " , f.fechapago as FechaVencimiento"
            sql &= " from RecibosFacturas as r inner join Productos as p on r.idproducto = p.idproducto "
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora "
            sql &= " left join Facturas as f on f.NumeroFactura = r.NumeroFactura and f.IdProducto = r.IdProducto and f.IdPoliza = r.IdPoliza and f.IdRamo = r.IdRamo"
            sql &= " where r.IdRecibo in (select idrecibo from EnviosPagoRecibos where IdEnvio in (" & lstEnvios & ") )"

            sql &= " union "

            sql &= "  select cast(r.IdRecibo as varchar) + '*' + cast(r.IdOtroIngreso as varchar) as Id, r.IdRecibo, null as NumeroFactura, '' as IdProducto, '' as IdPoliza, '' as IdRamo, '' as NombreCliente, r.Total"
            sql &= " ,a.IdAseguradora ,a.Nombre as Aseguradora, null as AvisoCobro "
            sql &= " , 'Depositos' as Producto, r.Descripcion as Notas"
            sql &= " , '' as Banco, '' as Cheque, '' as Confirmacion, '' as TipoPago"
            sql &= " , null as FechaVencimiento"
            sql &= " from RecibosOtrosIngresos as r "
            sql &= " inner join Aseguradoras as a on a.idaseguradora = r.idaseguradora "
            sql &= " where r.IdRecibo in (select idrecibo from EnviosPagoRecibos where IdEnvio in (" & lstEnvios & ") )"

            dtRecibosFacturas = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibosFacturas.TableName = "RecibosFacturas"

            ''ahora los mov. que tienen polizas son los provenientes de facturas 
            ''trataremos de proponer la nota: tipo de pago, banco, documento y confirmación
            Dim FilaF As DataRow, dtPago As DataTable, Nota As String = ""
            For Each FilaF In dtRecibosFacturas.Rows
                'no importa si no hay póliza proponemos el tipo de pago
                'If dbData(FilaF, "IdPoliza") <> "" Then
                Nota = ""
                Try
                    dtPago = StiGlobalConn.ObtenerDataset("select * from RecibosPagos as r left join Bancos as b on b.idbanco = r.idbanco where r.IdRecibo = " & dbStr(dbData(FilaF, "IdRecibo")) & " and r.IdAseguradora = " & dbStr(dbData(FilaF, "IdAseguradora"))).Tables(0)
                    For Each FilaP As DataRow In dtPago.Rows
                        Select Case dbData(FilaP, "IdTipoIngreso")
                            Case "E"
                                Nota &= ", Pago: Efectivo"
                                FilaF("TipoPago") = "Efectivo"
                                
                            Case "C"
                                Nota &= ", Cheque: " & dbData(FilaP, "Documento") & " " & dbData(FilaP, "IdBanco")
                                FilaF("Banco") = dbData(FilaP, "NombreBanco")
                                FilaF("Cheque") = dbData(FilaP, "Documento")
                                FilaF("TipoPago") = "Cheque"
                                If dbData(FilaP, "NumConfirmacion") <> "" Then
                                    Nota &= " #Conf." & dbData(FilaP, "NumConfirmacion")
                                    FilaF("NumConfirmacion") = dbData(FilaP, "NumConfirmacion")
                                End If
                            Case "T"
                                Nota &= ", Tarjeta: " & dbData(FilaP, "Documento") & " " & dbData(FilaP, "IdBanco")
                                FilaF("Banco") = dbData(FilaP, "NombreBanco")
                                FilaF("TipoPago") = "Tarjeta"
                                If dbData(FilaP, "NumConfirmacion") <> "" Then
                                    Nota &= " #Conf." & dbData(FilaP, "NumConfirmacion")
                                    FilaF("NumConfirmacion") = dbData(FilaP, "NumConfirmacion")
                                End If
                            Case "D"
                                Nota &= ", Depósito Bancario: " & dbData(FilaP, "Documento") & " " & dbData(FilaP, "IdBanco")
                                FilaF("TipoPago") = "Depósito Bancario"
                                FilaF("Banco") = dbData(FilaP, "NombreBanco")
                                If dbData(FilaP, "NumConfirmacion") <> "" Then
                                    Nota &= " #Conf." & dbData(FilaP, "NumConfirmacion")
                                    FilaF("NumConfirmacion") = dbData(FilaP, "NumConfirmacion")
                                End If
                            Case "N"
                                Nota &= ", Nota Crédito: " & dbData(FilaP, "Documento") & " " & dbData(FilaP, "IdBanco")
                                FilaF("TipoPago") = "Nota de Crédito"
                                FilaF("Banco") = dbData(FilaP, "NombreBanco")
                                If dbData(FilaP, "NumConfirmacion") <> "" Then
                                    Nota &= " #Conf." & dbData(FilaP, "NumConfirmacion")
                                    FilaF("NumConfirmacion") = dbData(FilaP, "NumConfirmacion")
                                End If
                            Case "A"
                                Nota &= ", Depósito en Aseguradora."
                                FilaF("TipoPago") = "Depósito en Aseguradora."
                        End Select
                    Next
                    If Nota <> "" Then
                        Nota = Nota.Substring(2).Trim
                    End If
                    FilaF("Notas") &= " " & Nota

                Catch ex As Exception

                End Try
                'End If
            Next

            Dim dsEnvio As New DataSet
            dsEnvio.Tables.Add(dtEnvio.Copy)
            dsEnvio.Tables.Add(dtRecibo.Copy)
            dsEnvio.Tables.Add(dtRecibosFacturas.Copy)
            dsEnvio.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(dsEnvio)

            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res = "Error al imprimir los envíos de caja."
        End Try

        Return res

    End Function

    Public Function ImprimirCierreCaja(ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim dtRecibo As New DataTable

            sql = "  select IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo"
            sql &= " , EstadoRecibo, '' as MontoLetras "
            sql &= " , isnull((select NombreUsuario from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " ),'') as UsuarioEmite "
            sql &= " , isnull((select top 1 EnviosPagoRecibos.IdEnvio from EnviosPagoRecibos where EnviosPagoRecibos.IdRecibo = recibos.IdRecibo),'') as Planilla"
            sql &= " from Recibos where FechaRecibo between " & dbFec(FechaInicial) & " and " & dbFec(FechaFinal) & " and EstadoRecibo <> 'N' "
            dtRecibo = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibo.TableName = "Recibos"

            Dim dtRecibosPagos As New DataTable
            sql = "  select p.IdRecibo, p.IdPago, p.IdTipoIngreso , p.IdBanco, p.Documento"
            sql &= " ,p.NumConfirmacion, p.Total, p.idaseguradora, a.Nombre as Aseguradora"
            sql &= " , isnull((select distinct af.IdAvisoCobro + ', ' from RecibosFacturas as rf inner join AvisosCobroFacturas as af on rf.IdPoliza = af.IdPoliza and rf.IdProducto = af.IdProducto and rf.NumeroFactura = af.NumeroFactura and rf.IdRamo = af.IdRamo where rf.IdRecibo = p.IdRecibo FOR XML PATH('')),'') as NoAC"
            sql &= " , isnull((select distinct er.IdEnvio + ', ' from EnviosPago as ep inner join EnviosPagoRecibos as er on ep.IdEnvio = er.IdEnvio where er.IdRecibo = p.idrecibo and ep.IdAseguradora = p.idaseguradora FOR XML PATH('')),'') as NoEnvioPlanilla"
            sql &= " from RecibosPagos as p "
            sql &= " left join aseguradoras as a on p.idaseguradora = a.idaseguradora "
            sql &= " where IdRecibo in (select idrecibo from Recibos where FechaRecibo between " & dbFec(FechaInicial) & " and " & dbFec(FechaFinal) & " and EstadoRecibo <> 'N')"

            dtRecibosPagos = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRecibosPagos.TableName = "RecibosPagos"

            Dim dtReciboAN As New DataTable
            sql = "  select IdRecibo, FechaRecibo, IdCliente, NombreCliente, TotalRecibo, EstadoRecibo, '' as MontoLetras"
            sql &= " , isnull((select NombreUsuario from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " ),'') as UsuarioEmite"
            sql &= " , FechaAnulacion, UsuarioAnulacion, MotivoAnulacion "
            sql &= " from Recibos where FechaRecibo between " & dbFec(FechaInicial) & " and " & dbFec(FechaFinal) & " and EstadoRecibo = 'N' "

            dtReciboAN = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtReciboAN.TableName = "RecibosAnula"

            Dim dsRecibo As New DataSet
            dsRecibo.Tables.Add(dtRecibo.Copy)
            dsRecibo.Tables.Add(dtRecibosPagos.Copy)
            dsRecibo.Tables.Add(dtReciboAN.Copy)
            dsRecibo.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As Object
            Reporte = New repCorteCaja
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.CierreCaja")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Reporte.SetDataSource(dsRecibo)


            SetRepFormulaString(Reporte, "Gerente", clSeguros.ObtenerDBParametros("Firma.Nombre.GerCierreCaja"))
            SetRepFormulaString(Reporte, "CargoGerente", clSeguros.ObtenerDBParametros("Firma.Cargo.GerCierreCaja"))
            SetRepFormulaString(Reporte, "AtencionNombre", clSeguros.ObtenerDBParametros("Firma.Nombre.RespCierreCaja"))
            SetRepFormulaString(Reporte, "AtencionCargo", clSeguros.ObtenerDBParametros("Firma.Cargo.RespCierreCaja"))

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Reporte de Cierre de Caja")
            If FechaInicial = FechaFinal Then
                SetRepFormulaString(Reporte, "Titulo2", "Fecha de corte: " & Format(FechaInicial, "dd/MMM/yyyy"))
            Else
                SetRepFormulaString(Reporte, "Titulo2", "Cierres entre el: " & Format(FechaInicial, "dd/MMM/yyyy") & " y " & Format(FechaFinal, "dd/MMM/yyyy"))
            End If
            SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res = ex.ToString
        End Try
        Return res
    End Function

#End Region

#Region "Gestión Pólizas"

    Public Function Polizas_CalcularGasto(ByVal IdProducto As String, ByVal SumaAsegurada As Double, ByVal Prima As Double, ByVal IdGasto As String) As Double
        Dim res As Double = 0
        Dim ValorRef As Double = 0
        Try
            Dim FilGasto As DataRow = StiGlobalConn.ObtenerDataset("select TipoCalculo, PorceGasto, ValorGasto, ValorMinimo, ValorMaximo from ProductosGastos where idproducto = " & dbStr(IdProducto) & " and idgasto = " & dbStr(IdGasto)).Tables(0).Rows(0)
            Select Case dbData(FilGasto, "TipoCalculo")
                Case "P"
                    ValorRef = Prima
                Case "S"
                    ValorRef = SumaAsegurada
            End Select

            If Val(dbData(FilGasto, "PorceGasto")) > 0 Then
                res += Math.Round(ValorRef * (Val(dbData(FilGasto, "PorceGasto")) / 100), 2)
            End If
            If Val(dbData(FilGasto, "ValorGasto")) > 0 Then
                res += Val(dbData(FilGasto, "ValorGasto"))
            End If
            If Val(dbData(FilGasto, "ValorMinimo")) > 0 Then
                If res < Val(dbData(FilGasto, "ValorMinimo")) Then
                    res = Val(dbData(FilGasto, "ValorMinimo"))
                End If
            End If
            If Val(dbData(FilGasto, "ValorMaximo")) > 0 Then
                If res > Val(dbData(FilGasto, "ValorMaximo")) Then
                    res = Val(dbData(FilGasto, "ValorMaximo"))
                End If
            End If

        Catch ex As Exception
            res = 0
        End Try
        Return res
    End Function

    Public Function ImprimirPoliza(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim Res As String = ""
        Try
            Dim sql As String = ""
            Dim SimboloMoneda As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol

            Dim Reporte As Object
            Reporte = New RepDetPoliza
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Poliza")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",isnull((select NombreUsuario from Usuarios where IdUsuario = isnull(p.EjecutivoCta,cl.EjecutivoCta)),'') as Ejecutivo"
            'sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " ,p.Categoria"
            sql &= " ,p.SumaAsegurada as SumaAsegurada"
            sql &= " ,p.Deducible as Deducible"
            sql &= " ,p.Participacion as Participacion"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"


            Dim FiltroExclusionCertificados As String = ""
            'los colectivos de autos y gastos medicos no se imprimen todos los cert.
            'Dim NumCert As Integer = StiGlobalConn.ObtenerDataset("select count(*) from PolizasCertificados as c where c.idpoliza = " & dbStr(IdPoliza) & " and c.idproducto = " & dbStr(IdProducto) & "and (c.RazonExclusion is null or c.RazonExclusion = '') ").Tables(0).Rows(0).Item(0)
            'Dim Ramo As String = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            'If NumCert > 1 And Not (Ramo = "401" Or Ramo = "402") Then
            'FiltroExclusionCertificados = "1"
            'End If
            If MsgBox("¿Desea Imprimir el detalle de la póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                FiltroExclusionCertificados = "1"
            End If

            'incluimos los certificados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.NombreCliente as Cliente"
            sql &= " ,p.ValorAsegurado as SumaAsegurada"
            sql &= " ,p.PrimaNeta as PrimaNeta"
            sql &= " ,p.GastosEmi"
            sql &= " ,p.GastosFrac as GastosFin"
            sql &= " ,p.GastosBomb"
            sql &= " ,p.GastosOtros"
            sql &= " ,p.Iva as Impuestos"
            sql &= " ,p.Total"
            sql &= " , isnull((select top 1 Tasa from PolizasCoberturas as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and p.IdCertificado = c.IdCertificado and c.IdCobertura = 1),0.0) as TasaPrincipal"
            sql &= " from PolizasCertificados as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            ''solo vigentes
            sql &= " and (p.RazonExclusion is null or p.RazonExclusion = '') and p.estadoCertificado = 'VIGENTE'"
            sql &= " order by p.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,isnull(c.Descripcion, ca.Descripcion) as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " ,p.Prima"
            sql &= " ,p.Participacion"
            sql &= " ,isnull(p.PorceSuma,100) as PorceSuma"
            sql &= " ,isnull((select top 1 r.PorceSuma from PolizasCoberturas as r where r.IdPoliza = p.IdPoliza and r.IdProducto = p.IdProducto and r.IdCertificado = p.IdCertificado and PorceSuma is not null),100) as PorceSumaCert"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " left join PolizasCoberturasAdicional as ca on ca.IdPoliza = p.IdPoliza and ca.IdProducto = p.IdProducto and ca.IdCertificado = p.IdCertificado and ca.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and (p.SumaAsegurada > 0 or p.CoberturaAdicional = 1) "
            sql &= " order by p.IdCertificado, p.IdCobertura "

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"

            sql &= " ,case "
            sql &= "   when charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 then"
            sql &= "      replace(substring(p.descripcionbien,1, charindex(', hasta por $', cast(p.descripcionbien as varchar(max)))-1),'hasta la suma de','')"
            sql &= "   else descripcionbien"
            sql &= " end as DescripcionBien"
            'sql &= " ,p.DescripcionBien"

            sql &= " ,case when p.SumaAsegurada is not null then " & dbStr(SimboloMoneda) & " + CONVERT(varchar, CAST(p.SumaAsegurada AS money), 1) else case "
            sql &= "  when charindex(', hasta por $', cast(descripcionbien as varchar(max))) > 0 then"
            sql &= "       substring(descripcionbien,charindex(', hasta por $', cast(descripcionbien as varchar(max))),100)"
            sql &= "   else ''"
            sql &= " end end as SumaAsegurada"
            sql &= ", p.SumaAsegurada as ValorSumaAsegurada"
            sql &= ", p.Prima as ValorPrima"

            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " ,pa.Descripcion as Parentesco"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " ,p.Propietario"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            If FiltroExclusionCertificados <> "" Then
                'en los colectivos ocultaremos algunas secciones de certificados
                Try
                    Reporte.GroupHeaderSection1.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection2.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection3.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection4.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection5.SectionFormat.EnableSuppress = True
                Catch ex As Exception

                End Try
            End If

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            Res &= ex.Message
        End Try
        Return Res
    End Function

    Public Function ImprimirPolizaDanos(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim Res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New RepDetPolizaIncendio
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Poliza.Danos")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " ,p.Categoria"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.NombreCliente as Cliente"
            sql &= " ,p.ValorAsegurado as SumaAsegurada"
            sql &= " ,p.PrimaNeta as PrimaNeta"
            sql &= " ,p.GastosEmi"
            sql &= " ,p.GastosFrac as GastosFin"
            sql &= " ,p.GastosBomb"
            sql &= " ,p.GastosOtros"
            sql &= " ,p.Iva as Impuestos"
            sql &= " ,p.Total"
            sql &= " from PolizasCertificados as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            ''solo vigentes
            sql &= " and (p.RazonExclusion is null or p.RazonExclusion = '') and p.estadoCertificado = 'VIGENTE'"
            sql &= " order by p.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and (p.SumaAsegurada > 0 or p.CoberturaAdicional = 1 )"
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"

            sql &= " ,case "
            sql &= "   when charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 then"
            sql &= "      replace(substring(p.descripcionbien,1, charindex(', hasta por $', cast(p.descripcionbien as varchar(max)))-1),'hasta la suma de','')"
            sql &= "   else descripcionbien"
            sql &= " end as DescripcionBien"
            'sql &= " ,p.DescripcionBien"

            sql &= " ,case "
            sql &= "  when charindex(', hasta por $', cast(descripcionbien as varchar(max))) > 0 then"
            sql &= "       substring(descripcionbien,charindex(', hasta por $', cast(descripcionbien as varchar(max))),100)"
            sql &= "   else ''"
            sql &= " end as SumaAsegurada"
            sql &= ", p.SumaAsegurada as ValorSumaAsegurada"
            sql &= ", p.Prima as ValorPrima"

            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " ,pa.Descripcion as Parentesco"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " ,p.Propietario"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            Res &= ex.Message
        End Try
        Return Res
    End Function

    Public Function RecalcularPrimasPoliza(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdFormaPago As String) As String
        Dim res As String = "", sql As String = ""
        Try
            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta From polizas where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0)
            'primer paso calcular las coberturas, según las tasas y vigencia para prorratear
            'Dim DiasVigencia As Integer = 0, DiasFormaPago As Integer = 365
            'DiasVigencia = ObtenerDiasCobertura(CDate(dbData(FilPol, "VigenciaDesde")), CDate(dbData(FilPol, "VigenciaHasta")))
            'Dim Prorrateo As Double = DiasVigencia / DiasFormaPago

            Dim DiasCobro As String = "365.00", DiasAnio As String = "365.00"
            If IdFormaPago <> "" Then
                Try
                    DiasCobro = StiGlobalConn.ObtenerDataset("select DiasFacturacion from FormasPago where idformapago = " & dbStr(IdFormaPago)).Tables(0).Rows(0).Item(0)
                    DiasCobro = DiasCobro.Trim & ".00"
                    Select Case Val(DiasCobro)
                        Case 30, 60, 90
                            'cuando son cobros declarativos calcularmos con anio calendario comerciañ
                            DiasAnio = "360.00"
                        Case Else
                            DiasAnio = "365.00"
                    End Select

                Catch ex As Exception
                    DiasCobro = "365.00"
                End Try
            End If


            ''actualizamos las coberturas 
            sql = " update PolizasCoberturas set PolizasCoberturas.Prima = Round(PolizasCoberturas.SumaAsegurada * (PolizasCoberturas.Tasa/ "
            'la tarifa de la cobertura
            sql &= "(case when (select Tarificacion from ProductosCoberturas where IdProducto = " & dbStr(IdProducto) & " and IdCobertura = PolizasCoberturas.IdCobertura) is null then (select Tarificacion from ProductosCoberturas where IdProducto = " & dbStr(IdProducto) & " and IdCobertura = 1)  else (select Tarificacion from ProductosCoberturas where IdProducto = " & dbStr(IdProducto) & " and IdCobertura = PolizasCoberturas.IdCobertura ) end) "
            sql &= ") * (case PorceSuma when 0 then 100 else isnull(PorceSuma,100) end / 100) * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) > " & DiasCobro & " then " & DiasCobro & " else  datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end end / " & DiasAnio & "), 2) "
            sql &= " from PolizasCoberturas "
            sql &= " inner join PolizasCertificados on PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado "
            sql &= " where PolizasCoberturas.idproducto = " & dbStr(IdProducto)
            sql &= " and PolizasCoberturas.idpoliza = " & dbStr(IdPoliza)
            sql &= " and PolizasCoberturas.Tasa is not null and PolizasCoberturas.Tasa > 0 "
            sql &= " and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null "
            StiGlobalConn.SQLExecute(sql)

            ''actualizamos las coberturas sin tasa (valores fijos anuales)
            sql = " update PolizasCoberturas set PolizasCoberturas.Prima = Round(PolizasCoberturas.PrimaAnual * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) > " & DiasCobro & " then " & DiasCobro & " else  datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end  end / " & DiasAnio & "), 2) "
            sql &= " from PolizasCoberturas "
            sql &= " inner join PolizasCertificados on PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado "
            sql &= " where PolizasCoberturas.idproducto = " & dbStr(IdProducto)
            sql &= " and PolizasCoberturas.idpoliza = " & dbStr(IdPoliza)
            sql &= " and (PolizasCoberturas.Tasa is null or PolizasCoberturas.Tasa = 0 )"
            sql &= " and PolizasCoberturas.PrimaAnual > 0 "
            sql &= " and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null "
            StiGlobalConn.SQLExecute(sql)


            'calculamos el deducible
            sql = " update PolizasCoberturas set Deducible = cast(cast(round(SumaAsegurada * (PorceDeducible / 100) ,2) as money) as varchar) "
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and SumaAsegurada is not null and SumaAsegurada > 0 and PorceDeducible is not null and PorceDeducible > 0"
            sql &= " and (select count(*) from PolizasCertificados where PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null ) > 0"
            StiGlobalConn.SQLExecute(sql)

            'calculamos el mínimo deducible
            sql = " update PolizasCoberturas set Deducible = "
            sql &= " case when cast(cast(Deducible as varchar) as numeric(10,2)) < DeducibleMinimo then cast(DeducibleMinimo as varchar)"
            sql &= " else Deducible end "
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and SumaAsegurada is not null and SumaAsegurada > 0 and PorceDeducible is not null and PorceDeducible > 0 and DeducibleMinimo is not null and DeducibleMinimo > 0"
            sql &= " and (select count(*) from PolizasCertificados where PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null ) > 0"
            StiGlobalConn.SQLExecute(sql)

            'calculamos el máximo deducible
            sql = " update PolizasCoberturas set Deducible = "
            sql &= " case when cast(cast(Deducible as varchar) as numeric(10,2)) > DeducibleMaximo then cast(DeducibleMaximo as varchar)"
            sql &= " else Deducible end "
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and SumaAsegurada is not null and SumaAsegurada > 0 and PorceDeducible is not null and PorceDeducible > 0 and DeducibleMaximo is not null and DeducibleMaximo > 0"
            sql &= " and (select count(*) from PolizasCertificados where PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null ) > 0"
            StiGlobalConn.SQLExecute(sql)

            ''verificamos si hay primas minimas por coberturas
            sql = " update PolizasCoberturas set PolizasCoberturas.Prima = "
            sql &= " case when PolizasCoberturas.Prima < round(PolizasCoberturas.PrimaMinima * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) > " & DiasCobro & " then " & DiasCobro & " else  datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end end / " & DiasAnio & "),2) then round(PolizasCoberturas.PrimaMinima * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) > " & DiasCobro & " then " & DiasCobro & " else datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end end / " & DiasAnio & "),2)"
            sql &= " else PolizasCoberturas.Prima end "
            sql &= " from PolizasCoberturas "
            sql &= " inner join PolizasCertificados on PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado"
            sql &= " where PolizasCoberturas.idproducto = " & dbStr(IdProducto)
            sql &= " and PolizasCoberturas.idpoliza = " & dbStr(IdPoliza)
            sql &= " and PolizasCoberturas.SumaAsegurada is not null and PolizasCoberturas.SumaAsegurada > 0 and PolizasCoberturas.Prima > 0 and PolizasCoberturas.PrimaMinima is not null and PolizasCoberturas.PrimaMinima > 0"
            sql &= " and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null "
            StiGlobalConn.SQLExecute(sql)

            ''verificamos si hay primas maximas por coberturas
            sql = " update PolizasCoberturas set PolizasCoberturas.Prima = "
            sql &= " case when PolizasCoberturas.Prima > round(PolizasCoberturas.PrimaMaxima * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else  case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) > " & DiasCobro & " then " & DiasCobro & " else datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end end / " & DiasAnio & "),2) then round(PolizasCoberturas.PrimaMaxima * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) > " & DiasCobro & " then " & DiasCobro & " else datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end end / " & DiasAnio & "),2)"
            sql &= " else PolizasCoberturas.Prima end "
            sql &= " from PolizasCoberturas"
            sql &= " inner join PolizasCertificados on PolizasCertificados.IdProducto = PolizasCoberturas.IdProducto and PolizasCertificados.IdPoliza = PolizasCoberturas.IdPoliza and PolizasCertificados.IdCertificado = PolizasCoberturas.IdCertificado"
            sql &= " where PolizasCoberturas.idproducto = " & dbStr(IdProducto)
            sql &= " and PolizasCoberturas.idpoliza = " & dbStr(IdPoliza)
            sql &= " and PolizasCoberturas.SumaAsegurada is not null and PolizasCoberturas.SumaAsegurada > 0 and PolizasCoberturas.Prima > 0 and PolizasCoberturas.PrimaMaxima is not null and PolizasCoberturas.PrimaMaxima > 0"
            sql &= " and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.FechaExclusion is null and PolizasCertificados.RazonExclusion is null "
            StiGlobalConn.SQLExecute(sql)

            'actualizasmo los certificados

            sql = " update PolizasCertificados set "
            sql &= " PrimaBruta = (select sum(PolizasCoberturas.Prima) from PolizasCoberturas where PolizasCoberturas.IdProducto =  PolizasCertificados.IdProducto and PolizasCoberturas.IdPoliza =  PolizasCertificados.IdPoliza and PolizasCoberturas.IdCertificado =  PolizasCertificados.IdCertificado) "
            sql &= ", ValorDescuento = (case when (isnull(PorceDescuento,0)) > 0 then (( select isnull(sum(PolizasCoberturas.prima),0) from PolizasCoberturas inner join ProductosCoberturas on PolizasCoberturas.idproducto = ProductosCoberturas.idproducto and PolizasCoberturas.IdCobertura = ProductosCoberturas.IdCobertura  where PolizasCoberturas.IdProducto =  PolizasCertificados.IdProducto and PolizasCoberturas.IdPoliza =  PolizasCertificados.IdPoliza and PolizasCoberturas.IdCertificado =  PolizasCertificados.IdCertificado and (ProductosCoberturas.AplicarDescuento is null or ProductosCoberturas.AplicarDescuento <> 'N')      ) * (PorceDescuento / 100)) else (PolizasCertificados.ValorDescuento)  end) "
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null"
            StiGlobalConn.SQLExecute(sql)

            'calculamos la prima neta 
            sql = " update PolizasCertificados set "
            sql &= " PrimaNeta =  round(PrimaBruta - ValorDescuento,2)"
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null"
            StiGlobalConn.SQLExecute(sql)

            'verificamos si hay mínimo de prima neta
            sql = " update PolizasCertificados set "
            sql &= " PrimaNeta =  "
            sql &= " case when PrimaNeta < round(PrimaMinima * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else  datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end / " & DiasCobro & ") ,2) then round(PrimaMinima * (case when datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) < 0 or datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) = 366 then 365 else  datediff(d,PolizasCertificados.VigenciaDesde,PolizasCertificados.VigenciaHasta) end / " & DiasAnio & "),2) "
            sql &= " else PrimaNeta end "
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null and PrimaMinima is not null and PrimaMinima > 0"
            StiGlobalConn.SQLExecute(sql)

            'calculamos los gastos
            sql = " update PolizasCertificados set "
            sql &= " GastosEmi = "
            sql &= " round( case "
            sql &= " when (select TipoCalculo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI') = 'P' then"
            sql &= " case "
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0)"
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0)				"
            sql &= " else"
            sql &= "    (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0)"
            sql &= " End"
            sql &= " else"
            sql &= " case "
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0)				"
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0)"
            sql &= " else"
            sql &= "    (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'EMI'),0)"
            sql &= " End"
            sql &= " end ,2)"

            sql &= ", GastosFrac = "
            sql &= " round( case "
            sql &= " when (select TipoCalculo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC') = 'P' then"
            sql &= " case "
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0)"
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0)				"
            sql &= " else"
            sql &= "    (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0)"
            sql &= " End"
            sql &= " else"
            sql &= " case "
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0)				"
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0)"
            sql &= " else"
            sql &= "    (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'FRAC'),0)"
            sql &= " End"
            sql &= " end ,2)"

            sql &= ", GastosBomb = "
            sql &= " round( case "
            sql &= " when (select TipoCalculo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB') = 'P' then"
            sql &= " case "
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0)"
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0)				"
            sql &= " else"
            sql &= "    (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0)"
            sql &= " End"
            sql &= " else"
            sql &= " case "
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0)				"
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0)"
            sql &= " else"
            sql &= "    (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'BOMB'),0)"
            sql &= " End"
            sql &= " end ,2)"

            sql &= ", GastosOtros = "
            sql &= " round( case "
            sql &= " when (select TipoCalculo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO') = 'P' then"
            sql &= " case "
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0)"
            sql &= " when (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0)				"
            sql &= " else"
            sql &= "    (PrimaNeta * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0)"
            sql &= " End"
            sql &= " else"
            sql &= " case "
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) < isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) and isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) > 0 then"
            sql &= " 	isnull((select ValorMinimo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0)				"
            sql &= " when (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) > isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) and isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0) > 0 then"
            sql &= " 	isnull((select ValorMaximo from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0)"
            sql &= " else"
            sql &= "    (ValorAsegurado * (isnull(( select PorceGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO' ),0) / 100)) + isnull((select ValorGasto from ProductosGastos where idproducto = PolizasCertificados.idproducto and idgasto = 'OTRO'),0)"
            sql &= " End"
            sql &= " end ,2)"

            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null"
            StiGlobalConn.SQLExecute(sql)

            'calculamos el IVA
            Dim PorceIva As Double = Val(clSeguros.ObtenerDBParametros("Porce.Iva")) / 100
            Dim TipoProducto As String = ""
            Try
                TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoProducto = ""
            End Try
            sql = " update PolizasCertificados set "
            sql &= " Iva = round("
            If TipoProducto = "VIDA" Then
                sql &= "(GastosEmi + GastosFrac + GastosBomb + GastosOtros) * "
            Else
                sql &= "(PrimaNeta + GastosEmi + GastosFrac + GastosBomb + GastosOtros) * "
            End If
            'calculamos el porcentaje de iva
            sql &= "( case when (select count(*) from clientes where clientes.idcliente = PolizasCertificados.idcliente and idtipocliente in ('GU','JE')) > 0 then (0.00) else " & PorceIva & " end )"
            sql &= ",2)"
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null"
            StiGlobalConn.SQLExecute(sql)

            'calculamos el total
            sql = " update PolizasCertificados set "
            sql &= " Total = round((PrimaNeta + GastosEmi + GastosFrac + GastosBomb + GastosOtros + Iva),2)"
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null"
            StiGlobalConn.SQLExecute(sql)


            'registramos un log
            Try
                Dim DtCambios As DataTable = StiGlobalConn.ObtenerDataset("select idpoliza, idproducto, idcertificado from PolizasCertificados where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and EstadoCertificado = 'VIGENTE' and FechaExclusion is null and RazonExclusion is null ").Tables(0)
                For Each FilCertL As DataRow In DtCambios.Rows
                    RegistrarLog("M", "PolizasCertificados", "IdPoliza = " & dbStr(dbData(FilCertL, "idpoliza"), 25) & " and IdProducto = " & dbStr(dbData(FilCertL, "idproducto"), 25) & " and IdCertificado = " & dbStr(dbData(FilCertL, "idcertificado"), 25))
                Next
            Catch ex As Exception

            End Try

        Catch ex As Exception
            res = ex.Message
        End Try
        Return res
    End Function

    Public Function DepartamentoUsuario() As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select Departamento from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function VisibilidadUsuario() As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select Visibilidad from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = "T"
        End Try
        Return res
    End Function

    Public Function CancelarPoliza(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal FechaCancelacion As DateTime, ByVal IdCancelacion As String, ByVal MotivoCancela As String, ByVal IdPolizaSustituye As String) As String
        Dim res As String = ""
        Try

            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'primero cancelamos la póliza
            StiGlobalConn.SQLExecute("update polizas set EstadoPoliza = 'CANCELADA', MotivoCancelacion = " & dbStr(MotivoCancela) & ", FechaCancelacion = " & dbFec(FechaCancelacion) & ", IdCancelacion = " & dbStr(IdCancelacion) & ", IdPolizaSustituida = " & dbStr(IdPolizaSustituye, 25) & " where IdPoliza =  " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto))

            'ahora cancelamos los certificados
            StiGlobalConn.SQLExecute("update PolizasCertificados set EstadoCertificado = 'CANCELADO', RazonExclusion = " & dbStr(MotivoCancela) & ", FechaExclusion = " & dbFec(FechaCancelacion) & " where IdPoliza =  " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and RazonExclusion is null")

            If IdCancelacion <> "" Then
                Dim filTipoCancela As DataRow = StiGlobalConn.ObtenerDataset("select * from TipoCancelacion where IdCancelacion = " & dbStr(IdCancelacion)).Tables(0).Rows(0)
                If dbData(filTipoCancela, "CancelaFacturas").Trim.ToUpper = "S" Then
                    Call AnularFacturasPendientes(IdPoliza, IdProducto, FechaCancelacion, MotivoCancela)
                    res &= ", Factura(s)"
                End If

                If dbData(filTipoCancela, "CancelaFlujos").Trim.ToUpper = "S" Then
                    Call clFlujos.CerrarFlujosPoliza(IdPoliza, IdProducto)
                    res &= ", Flujo(s)"
                End If

                If dbData(filTipoCancela, "CancelaSiniestros").Trim.ToUpper = "S" Then
                    Dim dtSiniestro As DataTable = StiGlobalConn.ObtenerDataset("select IdPoliza, IdProducto, IdCertificado, IdSiniestro from Siniestros where EstadoSiniestro in ('DECLARADO','PENDIENTE') and IdPoliza = " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto)).Tables(0)
                    Dim FilSiniestro As DataRow
                    For Each FilSiniestro In dtSiniestro.Rows
                        Call AnularReclamo(dbData(FilSiniestro, "IdPoliza"), dbData(FilSiniestro, "IdProducto"), dbData(FilSiniestro, "IdCertificado"), dbData(FilSiniestro, "IdSiniestro"), "CANCELACION DE POLIZA")
                    Next
                    res &= ", Reclamos(s)"
                End If
            Else
                'ahora vamos a anular las facturas pendientes
                Call AnularFacturasPendientes(IdPoliza, IdProducto, FechaCancelacion, MotivoCancela)
                res &= ", Factura(s)"
            End If

            'haremos una copia de la poliza actual al historico
            Dim msgHistorico As String = clSeguros.RegistrarHistorioPoliza(IdPoliza, IdProducto)
            If msgHistorico <> "" Then Throw New Exception(" Error al registrar histórico: " & msgHistorico)

            Dim msgflujo As String = clFlujos.IniciarFlujoCancelacionPoliza(IdPoliza, IdProducto)
            If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")

            res = "La póliza, Certificado(s) " & res & " han sido cancelados con éxito."

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            res = "Error al Cancelar la póliza, la operación no se ha completado: " & ex.Message
        End Try
        Return res
    End Function

    Public Function ObtenerDiasCobertura(ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime) As Integer
        Dim res As Integer = 0
        Try
            res = DateDiff(DateInterval.Day, FechaDesde, FechaHasta)
            'para validar fechas correctas o viciestos
            If res < 0 Or res = 366 Then res = 365
        Catch ex As Exception

        End Try
        Return res
    End Function

    Public Function funEstadoCliente(ByVal IdCliente As String) As String
        Dim res As String = "INACTIVO"
        Try
            Dim NumPolizas As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas where fechacancelacion is null and estadopoliza = 'VIGENTE' and idcliente = " & dbStr(IdCliente)).Tables(0).Rows(0).Item(0)
            If NumPolizas > 0 Then res = "ACTIVO"

        Catch ex As Exception
            res = "INACTIVO"
        End Try
        Return res
    End Function

    Public Function funEstadoPoliza(ByVal IdPoliza As String, ByVal IdProducto As String) As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select case when polizas.MotivoCancelacion is not null or polizas.EstadoPoliza = 'CANCELADA' then 'CANCELADA' else case WHEN polizas.NumVigencia > 1 THEN 'RENOVADA' else case when (select top 1 FechaVinculacion from Clientes where Clientes.IdCliente = Polizas.IdCliente) >= Polizas.VigenciaDesde  then 'CLIENTE NUEVO' else case when polizas.origen = 'TRASLADO' then 'POLIZA NUEVA TRASLADO' else 'POLIZA NUEVA' end end end end as Estado  from polizas where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function



    Public Function funEstadoAseguradora(ByVal IdAseguradora As String) As String
        Dim res As String = "INACTIVO"
        Try
            Dim NumPolizas As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas inner join productos on polizas.idproducto = productos.idproducto where fechacancelacion is null and estadopoliza = 'VIGENTE' and productos.idaseguradora = " & dbStr(IdAseguradora)).Tables(0).Rows(0).Item(0)
            If NumPolizas > 0 Then res = "ACTIVO"
        Catch ex As Exception
            res = "INACTIVO"
        End Try
        Return res
    End Function

#End Region

#Region "Gestión Correspondencia"

    Public Function ObtenerFirma(ByVal Paramero As String) As String
        Dim Firma As String = ""
        Try
            Firma = clSeguros.ObtenerDBParametros(Paramero)
            Dim ParamDepto As String = ""
            ParamDepto = Left(Paramero & "." & DepartamentoUsuario(), 50)
            If clSeguros.ObtenerDBParametros(ParamDepto) <> "" Then
                Firma = clSeguros.ObtenerDBParametros(ParamDepto)
            End If
        Catch ex As Exception

        End Try
        Return Firma
    End Function

    public function ObtenerConvenioPagoAC(byval IdAvisoCobro as string) as string 
        dim res as string = ""
        try
            dim Cuota1 as string = "", CuotaN as string = "", sql as string = ""

            sql = "select "
            sql &= " isnull((select '$' + cast(m.Total as varchar) + ' (1) Cuota'"
            sql &= " from  AvisosCobro as a"
            sql &= " inner join AvisosCobroFacturas as af on af.idavisocobro = a.idavisocobro"
            sql &= " inner join Facturas as f on f.NumeroFactura = af.NumeroFactura and f.IdProducto = af.IdProducto and f.IdPoliza = af.IdPoliza and f.IdRamo = af.IdRamo "    
            sql &= " inner join FacturasMovimientos as m on m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo  and m.idMovimiento = 1"
            sql &= " where a.IdAvisoCobro = " & dbstr(IdAvisoCobro) & " and f.numCuota = 1"
            sql &= " ),'')

            Cuota1 =stiglobalconn.ObtenerDataset(sql).tables(0).rows(0).Item(0)

            sql = "select "
            sql &= " isnull(("
            sql &= " select char(13) + char(10)+ '$' + cast(m.Total as varchar) + ' (' + cast(f.totalcuotas - 1 as varchar)  + ') Cuotas'"
            sql &= " from  AvisosCobro as a"
            sql &= " inner join AvisosCobroFacturas as af on af.idavisocobro = a.idavisocobro"
            sql &= " inner join Facturas as f on f.NumeroFactura = af.NumeroFactura and f.IdProducto = af.IdProducto and f.IdPoliza = af.IdPoliza and f.IdRamo = af.IdRamo "
            sql &= " inner join FacturasMovimientos as m on m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo  and m.idMovimiento = 1"
            sql &= " where a.IdAvisoCobro = " & dbstr(IdAvisoCobro) & " and f.numCuota = f.TotalCuotas and F.TotalCuotas > 1"
            sql &= " ),'')"

            CuotaN =stiglobalconn.ObtenerDataset(sql).tables(0).rows(0).Item(0)

            res = cuota1
            if CuotaN <> "" then res &= vbcrlf & cuotan

        Catch ex As Exception
            res = ""
        End Try
        return res
    End Function

    Public Function ImprimirCartaRemitePolizaAuto(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String, byval Notas as String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaRemisionPolizaAuto
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Remite.PolAuto")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", p.IdOferta "
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            
            'del primer certificado
            dim strIdCert as string = StiGlobalConn.ObtenerDataset("select top 1 IdCertificado from PolizasCertificados as c where c.IdPoliza = " & dbStr(IdPoliza) & " and c.IdProducto = " & dbStr(IdProducto) & " order by IdCertificado asc").Tables(0).Rows(0).Item(0)
            dim strIdAC as string =  "", ConvenioPago as string = ""
            try
                strIdAC = StiGlobalConn.ObtenerDataset("select top 1 IdAvisoCobro from AvisosCobro where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & " order by VigenciaDesde desc, FechaGrabacion desc ").Tables(0).Rows(0).Item(0)
                ConvenioPago  = ObtenerConvenioPagoAC(strIdAC)
            Catch ex As Exception
                ConvenioPago  = ""
            End Try

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " , isnull((select cast(isnull(DescripcionBien,'') as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'MARCA' ),'') + '/' + isnull((select cast(isnull(DescripcionBien,'') as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'MODELO' ),'') as NombreBien"   'MARCA/MODELO
            sql &= " , " & dbstr(ConvenioPago) & " as DescripcionBien"  'cuota
            sql &= " , isnull((select cast(isnull(DescripcionBien,'') as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'AÑO' ),0.0)  as ValorPrima" 'año
            sql &= " , c.ValorAsegurado as ValorSumaAsegurada" ' suma
            sql &= " from Polizas as p"
            sql &= " left join PolizasCertificados as c on c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and c.IdCertificado = " & dbstr(strIdCert)
            
            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"
            
            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "Beneficios", notas)

            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)

            
            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

        Return res

    End Function

    Public Function ImprimirCartaRemitePolizaGM(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String, byval Notas as String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaRemisionPolizaGM
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Remite.PolGM")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", p.IdOferta "
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            
            'del primer certificado
            dim strIdCert as string = StiGlobalConn.ObtenerDataset("select top 1 IdCertificado from PolizasCertificados as c where c.IdPoliza = " & dbStr(IdPoliza) & " and c.IdProducto = " & dbStr(IdProducto) & " order by IdCertificado asc").Tables(0).Rows(0).Item(0)
            dim strIdAC as string =  "", ConvenioPago as string = ""
            try
                strIdAC = StiGlobalConn.ObtenerDataset("select top 1 IdAvisoCobro from AvisosCobro where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & " order by VigenciaDesde desc, FechaGrabacion desc ").Tables(0).Rows(0).Item(0)
                ConvenioPago  = ObtenerConvenioPagoAC(strIdAC)
            Catch ex As Exception
                ConvenioPago  = ""
            End Try

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " , isnull((select cast(isnull(DescripcionBien,'') as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'MARCA' ),'') + '/' + isnull((select cast(isnull(DescripcionBien,'') as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'MODELO' ),'') as NombreBien"   'MARCA/MODELO
            sql &= " , " & dbstr(ConvenioPago) & " as DescripcionBien"  'cuota
            sql &= " , isnull((select cast(isnull(DescripcionBien,'') as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'AÑO' ),0.0)  as ValorPrima" 'año
            sql &= " , isnull((  select cast(DescripcionBien as varchar) from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien = 'maximo vitalicio'   ),c.ValorAsegurado) as ValorSumaAsegurada" ' suma
            sql &= " from Polizas as p"
            sql &= " left join PolizasCertificados as c on c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and c.IdCertificado = " & dbstr(strIdCert)
            
            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"
            
            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "Beneficios", notas)

            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)

            
            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

        Return res

    End Function

    Public Function ImprimirSolicitudProrrogaCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaProrrogaCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Prorroga.Cliente")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,c.IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(IdPoliza)
            sql &= " and c.idproducto = " & dbStr(IdProducto)
            ''solo vigentes
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            'sql &= " ,p.DescripcionBien"
            sql &= " ,case "
            sql &= "   when charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 then"
            sql &= "      replace(substring(p.descripcionbien,1, charindex(', hasta por $', cast(p.descripcionbien as varchar(max)))-1),'hasta la suma de','')"
            sql &= "   else descripcionbien"
            sql &= " end as DescripcionBien"
            'sql &= " ,p.DescripcionBien"

            sql &= " ,case "
            sql &= "  when charindex(', hasta por $', cast(descripcionbien as varchar(max))) > 0 then"
            sql &= "       substring(descripcionbien,charindex(', hasta por $', cast(descripcionbien as varchar(max))),100)"
            sql &= "   else ''"
            sql &= " end as SumaAsegurada"

            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "BIENESGENERAL", "S")

                sql = "  select count(*) "
                sql &= " from PolizasBienes as p"
                sql &= " where p.idpoliza = " & dbStr(IdPoliza)
                sql &= " and p.idproducto = " & dbStr(IdProducto)
                sql &= " and charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 "
                Dim ExisteDanos As Integer = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                If ExisteDanos > 0 Then
                    SetRepFormulaString(Reporte, "BIENESGENERAL", "N")
                End If
            Catch ex As Exception

            End Try


            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirCartaSolicitudProrrogaCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaSolicitudProrrogaCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Sol.Prorroga.Cliente")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,c.IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(IdPoliza)
            sql &= " and c.idproducto = " & dbStr(IdProducto)
            ''solo vigentes
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            'sql &= " ,p.DescripcionBien"
            sql &= " ,case "
            sql &= "   when charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 then"
            sql &= "      replace(substring(p.descripcionbien,1, charindex(', hasta por $', cast(p.descripcionbien as varchar(max)))-1),'hasta la suma de','')"
            sql &= "   else descripcionbien"
            sql &= " end as DescripcionBien"
            'sql &= " ,p.DescripcionBien"

            sql &= " ,case "
            sql &= "  when charindex(', hasta por $', cast(descripcionbien as varchar(max))) > 0 then"
            sql &= "       substring(descripcionbien,charindex(', hasta por $', cast(descripcionbien as varchar(max))),100)"
            sql &= "   else ''"
            sql &= " end as SumaAsegurada"

            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "BIENESGENERAL", "S")

                sql = "  select count(*) "
                sql &= " from PolizasBienes as p"
                sql &= " where p.idpoliza = " & dbStr(IdPoliza)
                sql &= " and p.idproducto = " & dbStr(IdProducto)
                sql &= " and charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 "
                Dim ExisteDanos As Integer = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                If ExisteDanos > 0 Then
                    SetRepFormulaString(Reporte, "BIENESGENERAL", "N")
                End If
            Catch ex As Exception

            End Try


            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirCartaAnexoPolizaCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal Descripcion As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaAnexoPolizaCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.AnexoPol.Cliente")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,c.IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(IdPoliza)
            sql &= " and c.idproducto = " & dbStr(IdProducto)
            ''solo vigentes
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            'sql &= " ,p.DescripcionBien"
            sql &= " ,case "
            sql &= "   when charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 then"
            sql &= "      replace(substring(p.descripcionbien,1, charindex(', hasta por $', cast(p.descripcionbien as varchar(max)))-1),'hasta la suma de','')"
            sql &= "   else descripcionbien"
            sql &= " end as DescripcionBien"
            'sql &= " ,p.DescripcionBien"

            sql &= " ,case "
            sql &= "  when charindex(', hasta por $', cast(descripcionbien as varchar(max))) > 0 then"
            sql &= "       substring(descripcionbien,charindex(', hasta por $', cast(descripcionbien as varchar(max))),100)"
            sql &= "   else ''"
            sql &= " end as SumaAsegurada"

            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "BIENESGENERAL", "S")

                sql = "  select count(*) "
                sql &= " from PolizasBienes as p"
                sql &= " where p.idpoliza = " & dbStr(IdPoliza)
                sql &= " and p.idproducto = " & dbStr(IdProducto)
                sql &= " and charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 "
                Dim ExisteDanos As Integer = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                If ExisteDanos > 0 Then
                    SetRepFormulaString(Reporte, "BIENESGENERAL", "N")
                End If
            Catch ex As Exception

            End Try

            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            SetRepFormulaString(Reporte, "Descripcion", Descripcion)

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirRenovacionCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaRenovacionCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Renovacion.Cliente")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,c.IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(IdPoliza)
            sql &= " and c.idproducto = " & dbStr(IdProducto)
            ''solo vigentes
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            sql &= " ,p.DescripcionBien"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Prima"
            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "ResponsableAC", clSeguros.ObtenerDBParametros("Responsable.Gestion.AC"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try


            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirEmisionPolizaCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaEmisionPoliza
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Emision.Inicial")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as Atencion"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoAtencion"
            sql &= " from CPolizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision.Inicial"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision.Inicial"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirPolizaDeclaracionMensual(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal DescripcionDeclaracion As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrDeclaracionMensual
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Declaracion.Mensual")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as Atencion"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoAtencion"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision.Inicial"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision.Inicial"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            SetRepFormulaString(Reporte, "DetalleDeclaracion", DescripcionDeclaracion)


            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirRehabilitacionPoliza(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrRehabilitarPoliza
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Rehabilitar.Poliza")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as Atencion"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoAtencion"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision.Inicial"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision.Inicial"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)


            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirEmisionPolizaEmpresa(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaEmisionPolizaEmpresa
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Emision.Inicial.Emp")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as Atencion"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoAtencion"
            sql &= " from CPolizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision.Inicial"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision.Inicial"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))


            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirEnvioCertificadosCliente(ByVal FiltroPoliza As String, ByVal FiltroCertificados As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrEnvioCertificados
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Inclusion.Certificado")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,isnull(c.IdCertificadoAseguradora,c.IdCertificado) as IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,isnull(c.IdCertificadoAseguradora,c.IdCertificado) as IdCertificado"
            sql &= " ,co.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as co on co.IdProducto = p.IdProducto and co.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,isnull(c.IdCertificadoAseguradora,c.IdCertificado) as IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            sql &= " ,p.DescripcionBien"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Prima"
            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,isnull(c.IdCertificadoAseguradora,c.IdCertificado) as IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,isnull(c.IdCertificadoAseguradora,c.IdCertificado) as IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirResumenPolizasCliente(ByVal FiltroPoliza As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New RepCoorResumenPolizas
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Resumen.Polizas")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza


            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"


            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " ,p.Categoria"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"


            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,c.IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " ,c.VigenciaDesde"
            sql &= " ,c.VigenciaHasta"
            sql &= " ,c.FechaInclusion as FechaIngreso"
            sql &= " ,c.FechaExclusion as FechaExclusion"
            sql &= " ,c.Participacion"
            sql &= " ,c.Deducible"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " inner join Polizas as p on p.idpoliza = c.idpoliza and p.idproducto = c.idproducto"
            sql &= " where p.idpoliza is not null"
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
            sql &= " " & FiltroPoliza


            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select co.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,co.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,co.SumaAsegurada"
            sql &= " ,co.Deducible"
            sql &= " ,co.Tasa"
            sql &= " from PolizasCoberturas as co"
            sql &= " inner join Productos as pr on pr.idproducto = co.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = co.IdProducto and c.IdCobertura = co.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on co.idproducto = ce.idproducto and co.idpoliza = ce.idpoliza and co.idcertificado = ce.idcertificado"
            sql &= " inner join Polizas as p on p.idpoliza = ce.idpoliza and p.idproducto = ce.idproducto"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and co.SumaAsegurada > 0 "
            sql &= " order by co.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            sql &= " ,p.DescripcionBien"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Prima"
            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirInclusionVehiculo(ByVal FiltroPoliza As String, ByVal FiltroCertificados As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrInclusionCertificado
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Inclusion.Vehiculo")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza is not null"
            sql &= " " & FiltroPoliza

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

            'incluimos los certificados
            sql = "  select c.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,c.IdCertificado"
            sql &= " ,c.NombreCliente as Cliente"
            sql &= " ,c.ValorAsegurado as SumaAsegurada"
            sql &= " ,c.PrimaNeta as PrimaNeta"
            sql &= " ,c.GastosEmi"
            sql &= " ,c.GastosFrac as GastosFin"
            sql &= " ,c.GastosBomb"
            sql &= " ,c.GastosOtros"
            sql &= " ,c.Iva as Impuestos"
            sql &= " ,c.Total"
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,co.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as co on co.IdProducto = p.IdProducto and co.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            sql &= " ,p.DescripcionBien"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Prima"
            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " from PolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from PolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza and p.idcertificado = c.idcertificado"
            sql &= " where c.idpoliza is not null "
            sql &= " " & FiltroCertificados
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Sol.Prorroga"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)


            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirSolicitudDocumentoReclamoCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdSiniestro As String, ByVal IdCertificado As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCarteDocumentosReclamo
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Documento.Reclamo")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " ,s.NombrePresentaReclamo as Contratante"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdDetalle as Orden"
            sql &= " ,g.Descripcion as Gasto"
            sql &= " ,s.ValorPresentado as Presentado"
            sql &= " ,s.ValorNoCubierto as NoCubierto"
            sql &= " ,s.ValorCubierto as Cubierto"
            sql &= " from SiniestrosDetalle as s"
            sql &= " inner join ProductosSinGastos as g on g.idproducto = s.idproducto and s.idgasto = g.idgasto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtGastos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtGastos.TableName = "Gastos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdInformacion as Orden"
            sql &= " ,s.Descripcion"
            sql &= " ,s.Detalle"
            sql &= " ,c.Categoria"
            sql &= " from SiniestrosInformacion as s"
            sql &= " left join ProductosSinComplementos as c on s.Descripcion = c.DescripcionComplemento and s.idproducto = c.idproducto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtDetalle As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDetalle.TableName = "Detalle"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,b.IdBien as Orden"
            sql &= " ,b.NombreBien as Descripcion"
            sql &= " ,b.DescripcionBien as Detalle"
            sql &= " from Siniestros as s"
            sql &= " inner join PolizasBienes as b on s.IdPoliza = b.IdPoliza and s.IdProducto = b.IdProducto and s.IdCertificado = b.IdCertificado"
            sql &= " where s.idsiniestro is not null and b.DescripcionBien is not null "
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtBien As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBien.TableName = "BienesAsegurados"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdRequisito, s.Descripcion, s.FechaPresentado, s.Comentarios"
            sql &= " from SiniestrosRequisitos as s"
            sql &= " where s.idsiniestro is not null "
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtRequisitos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRequisitos.TableName = "Requisitos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtGastos.Copy)
            DsRep.Tables.Add(dtDetalle.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(dtBien.Copy)
            DsRep.Tables.Add(dtRequisitos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Reclamos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Reclamos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function ImprimirSolicitudAseguradoraGastosFunerario(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdSiniestro As String, ByVal IdCertificado As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrSolAsegGastosFunerarios
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.SolAseg.GasFun")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " ,s.NombrePresentaReclamo as Contratante"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdDetalle as Orden"
            sql &= " ,g.Descripcion as Gasto"
            sql &= " ,s.ValorPresentado as Presentado"
            sql &= " ,s.ValorNoCubierto as NoCubierto"
            sql &= " ,s.ValorCubierto as Cubierto"
            sql &= " from SiniestrosDetalle as s"
            sql &= " inner join ProductosSinGastos as g on g.idproducto = s.idproducto and s.idgasto = g.idgasto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtGastos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtGastos.TableName = "Gastos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdInformacion as Orden"
            sql &= " ,s.Descripcion"
            sql &= " ,s.Detalle"
            sql &= " ,c.Categoria"
            sql &= " from SiniestrosInformacion as s"
            sql &= " left join ProductosSinComplementos as c on s.Descripcion = c.DescripcionComplemento and s.idproducto = c.idproducto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtDetalle As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDetalle.TableName = "Detalle"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,b.IdBien as Orden"
            sql &= " ,b.NombreBien as Descripcion"
            sql &= " ,b.DescripcionBien as Detalle"
            sql &= " from Siniestros as s"
            sql &= " inner join PolizasBienes as b on s.IdPoliza = b.IdPoliza and s.IdProducto = b.IdProducto and s.IdCertificado = b.IdCertificado"
            sql &= " where s.idsiniestro is not null and b.DescripcionBien is not null "
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtBien As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBien.TableName = "BienesAsegurados"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdRequisito, s.Descripcion, s.FechaPresentado, s.Comentarios"
            sql &= " from SiniestrosRequisitos as s"
            sql &= " where s.idsiniestro is not null "
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtRequisitos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRequisitos.TableName = "Requisitos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtGastos.Copy)
            DsRep.Tables.Add(dtDetalle.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(dtBien.Copy)
            DsRep.Tables.Add(dtRequisitos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Reclamos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Reclamos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function ImprimirPagoGastosFunerarioCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdSiniestro As String, ByVal IdCertificado As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrPagoGastosFunerariosClie
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Pago.GasFun")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " ,s.NombrePresentaReclamo as Contratante"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdDetalle as Orden"
            sql &= " ,g.Descripcion as Gasto"
            sql &= " ,s.ValorPresentado as Presentado"
            sql &= " ,s.ValorNoCubierto as NoCubierto"
            sql &= " ,s.ValorCubierto as Cubierto"
            sql &= " from SiniestrosDetalle as s"
            sql &= " inner join ProductosSinGastos as g on g.idproducto = s.idproducto and s.idgasto = g.idgasto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtGastos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtGastos.TableName = "Gastos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdInformacion as Orden"
            sql &= " ,s.Descripcion"
            sql &= " ,s.Detalle"
            sql &= " ,c.Categoria"
            sql &= " from SiniestrosInformacion as s"
            sql &= " left join ProductosSinComplementos as c on s.Descripcion = c.DescripcionComplemento and s.idproducto = c.idproducto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtDetalle As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDetalle.TableName = "Detalle"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,b.IdBien as Orden"
            sql &= " ,b.NombreBien as Descripcion"
            sql &= " ,b.DescripcionBien as Detalle"
            sql &= " from Siniestros as s"
            sql &= " inner join PolizasBienes as b on s.IdPoliza = b.IdPoliza and s.IdProducto = b.IdProducto and s.IdCertificado = b.IdCertificado"
            sql &= " where s.idsiniestro is not null and b.DescripcionBien is not null "
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtBien As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBien.TableName = "BienesAsegurados"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdRequisito, s.Descripcion, s.FechaPresentado, s.Comentarios"
            sql &= " from SiniestrosRequisitos as s"
            sql &= " where s.idsiniestro is not null "
            sql &= " and s.IdPoliza = " & dbStr(IdPoliza)
            sql &= " and s.IdProducto = " & dbStr(IdProducto)
            sql &= " and s.idsiniestro = " & dbStr(IdSiniestro)
            sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
            Dim dtRequisitos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRequisitos.TableName = "Requisitos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtGastos.Copy)
            DsRep.Tables.Add(dtDetalle.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(dtBien.Copy)
            DsRep.Tables.Add(dtRequisitos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Reclamos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Reclamos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Sub MarcarFlujosChequeDoc(ByVal FiltroReclamos As String, ByVal IdImpresion As String)
        Try
            Dim sql As String = ""
            sql = "  select f.IdFlujoDoc "
            sql &= " from Siniestros as s"
            sql &= " inner join FlujosDocumentos as f on f.IdPoliza = s.IdPoliza and f.IdProducto = s.IdProducto and f.IdSiniestro = s.IdSiniestro "
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroReclamos
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            For Each FilSin As DataRow In dtSiniestros.Rows
                StiGlobalConn.SQLExecute("update FlujosDocumentos set IdImpresionFinal = " & dbStr(IdImpresion, 25) & " where IdFlujoDoc = " & dbStr(dbData(FilSin, "IdFlujoDoc")))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Function ImprimirCartaReclamosChequesCliente(ByVal FiltroReclamos As String, ByVal FiltroPagos As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String, Optional ByVal Observaciones As String = "") As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaChequeReclamosCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Carta.Cheques.Rec")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " , isnull((select top 1 bi.DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and NombreBien = 'CARNET'),s.IdCertificado) as IdCertificado"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " ,po.Nombrecliente as Contratante"
            sql &= " ,ce.nombrecliente as Asegurado"
            sql &= " ,po.IdCliente"
            sql &= " ,s.DescripcionLiquidacion"
            sql &= " from Siniestros as s"
            sql &= " inner join Polizas as po on po.idpoliza = s.idpoliza and po.idproducto = s.idproducto"
            sql &= " inner join PolizasCertificados as ce on ce.idproducto = s.idproducto and ce.idpoliza = s.idpoliza and ce.idcertificado = s.idcertificado "
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroReclamos
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto,s.IdSiniestro"
            sql &= ", isnull((select top 1 bi.DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and NombreBien = 'CARNET'),s.IdCertificado) as IdCertificado"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroPagos
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Reclamos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Reclamos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            Try
                SetRepFormulaString(Reporte, "AtencionNombre", StiGlobalConn.ObtenerDataset("select Nombre from ClientesContactos where IdCliente = " & dbStr(dbData(dtSiniestros.Rows(0), "IdCliente")) & " and Funciones like '%CHEQUES RECLAMOS%'").Tables(0).Rows(0).Item(0))
            Catch ex As Exception

            End Try
            Try
                SetRepFormulaString(Reporte, "AtencionCargo", StiGlobalConn.ObtenerDataset("select Cargo from ClientesContactos where IdCliente = " & dbStr(dbData(dtSiniestros.Rows(0), "IdCliente")) & " and Funciones like '%CHEQUES RECLAMOS%'").Tables(0).Rows(0).Item(0))
            Catch ex As Exception

            End Try
            SetRepFormulaString(Reporte, "Observaciones", Observaciones)

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))



            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function ImprimirCartaReclamosChequesClienteDanos(ByVal FiltroReclamos As String, ByVal FiltroPagos As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaChequeReclamosClienteDanos
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Carta.Cheques.RecDn")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " , isnull((select top 1 bi.DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and NombreBien = 'CARNET'),s.IdCertificado) as IdCertificado"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " ,po.Nombrecliente as Contratante"
            sql &= " ,ce.nombrecliente as Asegurado"
            sql &= " ,po.IdCliente"
            sql &= " ,s.DescripcionLiquidacion"
            sql &= " from Siniestros as s"
            sql &= " inner join Polizas as po on po.idpoliza = s.idpoliza and po.idproducto = s.idproducto"
            sql &= " inner join PolizasCertificados as ce on ce.idproducto = s.idproducto and ce.idpoliza = s.idpoliza and ce.idcertificado = s.idcertificado "
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroReclamos
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto,s.IdSiniestro"
            sql &= ", isnull((select top 1 bi.DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and NombreBien = 'CARNET'),s.IdCertificado) as IdCertificado"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroPagos
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Reclamos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Reclamos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            Try
                SetRepFormulaString(Reporte, "AtencionNombre", StiGlobalConn.ObtenerDataset("select Nombre from ClientesContactos where IdCliente = " & dbStr(dbData(dtSiniestros.Rows(0), "IdCliente")) & " and Funciones like '%CHEQUES RECLAMOS%'").Tables(0).Rows(0).Item(0))
            Catch ex As Exception

            End Try
            Try
                SetRepFormulaString(Reporte, "AtencionCargo", StiGlobalConn.ObtenerDataset("select Cargo from ClientesContactos where IdCliente = " & dbStr(dbData(dtSiniestros.Rows(0), "IdCliente")) & " and Funciones like '%CHEQUES RECLAMOS%'").Tables(0).Rows(0).Item(0))
            Catch ex As Exception

            End Try
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function ImprimirCartaReclamosAjusteCliente(ByVal FiltroReclamos As String, ByVal FiltroPagos As String, ByVal CodigoCorrespondencia As String, ByVal Ajustador As String, ByVal MontoAjustado As Double, ByVal Notas As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaAjusteReclamosCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Carta.Ajuste.Rec")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " , isnull((select top 1 bi.DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and NombreBien = 'CARNET'),s.IdCertificado) as IdCertificado"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " ,po.Nombrecliente as Contratante"
            sql &= " ,ce.nombrecliente as Asegurado"
            sql &= " ,po.IdCliente"
            sql &= " from Siniestros as s"
            sql &= " inner join Polizas as po on po.idpoliza = s.idpoliza and po.idproducto = s.idproducto"
            sql &= " inner join PolizasCertificados as ce on ce.idproducto = s.idproducto and ce.idpoliza = s.idpoliza and ce.idcertificado = s.idcertificado "
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroReclamos
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto,s.IdSiniestro"
            sql &= ", isnull((select top 1 bi.DescripcionBien from PolizasBienes as bi where bi.IdPoliza = s.IdPoliza and bi.IdProducto = s.IdProducto and bi.IdCertificado = s.IdCertificado and NombreBien = 'CARNET'),s.IdCertificado) as IdCertificado"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " " & FiltroPagos
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Reclamos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Reclamos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            Try
                SetRepFormulaString(Reporte, "AtencionNombre", StiGlobalConn.ObtenerDataset("select Nombre from ClientesContactos where IdCliente = " & dbStr(dbData(dtSiniestros.Rows(0), "IdCliente")) & " and Funciones like '%CHEQUES RECLAMOS%'").Tables(0).Rows(0).Item(0))
            Catch ex As Exception

            End Try
            Try
                SetRepFormulaString(Reporte, "AtencionCargo", StiGlobalConn.ObtenerDataset("select Cargo from ClientesContactos where IdCliente = " & dbStr(dbData(dtSiniestros.Rows(0), "IdCliente")) & " and Funciones like '%CHEQUES RECLAMOS%'").Tables(0).Rows(0).Item(0))
            Catch ex As Exception

            End Try
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            SetRepFormulaString(Reporte, "Ajustador", Ajustador)
            SetRepFormulaString(Reporte, "MontoAjustado", Format(MontoAjustado, "c2"))
            SetRepFormulaString(Reporte, "Notas", Notas)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function ImprimirCartaDocumentosEmisionCliente(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaEmisionDocumentosCliente
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Emision.Doc.Cli")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as Atencion"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoAtencion"
            sql &= " from CPolizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            sql &= " ,p.DescripcionBien"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Prima"
            sql &= " from CPolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join CPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " order by p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision.Inicial"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision.Inicial"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirCartaDocumentosEmisionEmpresa(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaEmisionDocumentosEmpresa
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Emision.Doc.Emp")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", isnull(( select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as Atencion"
            sql &= ", isnull(( select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = a.IdAseguradora and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto ),'') as CargoAtencion"
            sql &= " from CPolizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"
            sql &= " ,p.DescripcionBien"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Prima"
            sql &= " from CPolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join CPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)
            sql &= " order by p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Emision.Inicial"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Emision.Inicial"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                SetRepFormulaString(Reporte, "CodigoCorrespondencia", CodigoCorrespondencia)
            Catch ex As Exception

            End Try

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)


            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Sub GenerarReporteControl(ByVal Tipo As String, ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal IdZona As String, ByVal MinutosAntes As Double, ByVal IdUsuarioEntrega As String, ByVal ParametroReporte As String, Optional ByVal ListaDocumentos As String = "")
        Dim sql As String = ""

        Try
            Dim Reporte As Object = Nothing

            sql = "  select "
            sql &= " d.IdFlujoDoc"
            sql &= ", f.Descripcion as Flujo"
            sql &= ", d.Comentario "
            sql &= ", d.EstadoFlujo"
            sql &= ", d.FechaInicia"
            sql &= ", d.FechaFinaliza"
            sql &= ", isnull(i.IdOrigen, isnull(d.NombreCliente,'') + ' ' + isnull((select nombre from aseguradoras as a where a.idaseguradora = d.idaseguradora),'')) as NombreCliente"
            sql &= ", isnull((select NombreUsuario from usuarios where IdUsuario = d.IdUsuarioSolicita),'') as IdUsuarioSolicita"
            sql &= ", isnull((select NombreUsuario from usuarios where IdUsuario = d.IdUsuarioDestino),'') as IdUsuarioDestino"
            'sql &= ", isnull((select NombreUsuario from usuarios where IdUsuario = i.IdDestinatario),'') as IdDestinatario"
            sql &= ", isnull(i.DireccionDocumento, d.Direccion) as Direccion"
            sql &= ", isnull(c.NombreCiudad,'') as Ciudad"
            sql &= ", isnull(z.DescripcionZona,'') as Zona"
            sql &= ", f.CategoriaFlujo"
            sql &= ", f.TipoFlujo"
            sql &= ", i.IdImpresion"
            sql &= ", i.FechaImpresion"
            sql &= ", i.FechaEnvio"
            sql &= ", i.IdDestinatario"
            sql &= ", isnull(i.Descripcion,'') as DescripcionImpresion"
            sql &= ", i.Courier"
            sql &= ", isnull((select u.NombreUsuario from usuarios as u where u.idusuario = i.IdUsuarioEntrega),'') as IdUsuarioEntrega"
            'sql &= ",(select top 1 p.DescripcionPaso from FlujosTrabajoPasos as p where p.IdFlujo = d.IdFlujo and p.IdPaso = (select p1.IdPaso from FlujosDocumentosPasos p1 where p1.IdFlujoDoc = d.IdFlujoDoc and p1.Orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc))) as PasoActual"
            'sql &= ",(select top 1 p.DescripcionPaso from FlujosTrabajoPasos as p where p.IdFlujo = d.IdFlujo and p.IdPaso = (select ftp.IdSiguientePaso from  FlujosTrabajoPasos as ftp where ftp.IdFlujo = d.IdFlujo and ftp.IdPaso = (select p1.IdPaso from FlujosDocumentosPasos p1 where p1.IdFlujoDoc = d.IdFlujoDoc and p1.Orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc)))) as SiguientePaso"
            'sql &= ",(select top 1 p.FechaPaso from FlujosDocumentosPasos as p where p.IdFlujoDoc = d.IdFlujoDoc and p.orden = 1) as FechaPrimerPaso"
            'sql &= ",(select p.FechaPaso from FlujosDocumentosPasos as p where p.IdFlujoDoc = d.IdFlujoDoc and p.orden = (select max(p2.orden) from FlujosDocumentosPasos as p2 where p2.IdFlujoDoc = d.IdFlujoDoc)) as FechaUltimoPaso"
            sql &= ", isnull(i.NombreAttDoc,'') as NombreAttDoc"
            sql &= ", i.RecibeCorrespondencia"
            sql &= ", isnull((select nombre from aseguradoras as a where a.idaseguradora = d.idaseguradora),'') as NombreAseguradora"
            sql &= ", isnull(i.IdOrigen, isnull(d.NombreCliente,'')) as NombreClienteFlujo "

            sql &= ", isnull(i.TipoDocumento,'') as TipoDocumento"
            sql &= ", isnull(i.CantidadDocumentos,0) as CantidadDocumentos"
            sql &= ", isnull(i.NombreDestinatario,d.NombreCliente) as NombreDestinatario"

            sql &= " from FlujosDocumentos as d"
            sql &= " inner join FlujosTrabajo as f on f.idflujo = d.idflujo"
            sql &= " inner join FlujosDocumentosImpresiones as i on i.IdFlujoDoc = d.IdFlujoDoc"
            sql &= " left join zonas as z on z.idzona = i.idzona"
            sql &= " left join ciudades as c on c.idciudad = d.idciudad"

            'sql &= " inner join FlujosDocumentosPasos as pa on pa.IdFlujoDoc = d.IdFlujoDoc and pa.IdFlujo = d.IdFlujo"
            'sql &= " inner join FlujosTrabajoPasos as tp on tp.idflujo = pa.idflujo and tp.idpaso = pa.idpaso"

            sql &= " where i.TipoFlujo = " & dbStr(Tipo)
            sql &= " and i.FechaAnulacion is null "
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = d.idpoliza and pol.idproducto = d.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            Select Case Tipo
                Case "ENTRADA"
                    If ListaDocumentos = "" Then
                        sql &= " and cast(convert(char(8),i.FechaImpresion,112) as datetime) between " & dbFec(FechaDesde) & " and " & dbFec(FechaHasta)
                        If MinutosAntes > 0 Then
                            sql &= " and i.FechaMovimiento >= " & dbFec(Date.Now.AddMinutes(MinutosAntes * -1), "1")
                        End If

                        If IdZona <> "" Then
                            sql &= " and i.IdDestinatario = " & dbStr(IdZona)
                        End If
                        If clSeguros.ObtenerDBParametros("Corr.Reimprimir.DocEnt") = "N" Then
                            sql &= " and i.doc_impreso is null "
                        End If
                    Else
                        sql &= " and i.IdFlujoDoc + '*' + i.IdImpresion in (" & ListaDocumentos & ") "

                    End If

                    Reporte = New repCRCorrespondenciaRecibida
                    If ParametroReporte = "" Then ParametroReporte = "Reporte.Corr.Recibe"
                    Dim ReportePersonal As String = clSeguros.ObtenerDBParametros(ParametroReporte)
                    If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

                Case "SALIDA"
                    sql &= " and cast(convert(char(8),i.FechaEnvio,112) as datetime) between " & dbFec(FechaDesde) & " and " & dbFec(FechaHasta)
                    If MinutosAntes > 0 Then
                        sql &= " and i.FechaMovimiento >= " & dbFec(Date.Now.AddMinutes(MinutosAntes * -1), "1")
                    End If

                    If IdZona <> "" Then
                        sql &= " and i.IdZona = " & dbStr(IdZona)
                    End If

                    If IdUsuarioEntrega <> "" Then
                        sql &= " and i.IdUsuarioEntrega = " & dbStr(IdUsuarioEntrega)
                    End If

                    Reporte = New repCRCorrespondenciaEnviada
                    If ParametroReporte = "" Then ParametroReporte = "Reporte.Corr.Envia"
                    Dim ReportePersonal As String = clSeguros.ObtenerDBParametros(ParametroReporte)
                    If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            End Select

            Dim dtFlujos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFlujos.TableName = "Correspondencia"

            If dtFlujos.Rows.Count = 0 Then
                MsgBox("No se encontró mensajería.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If clSeguros.ObtenerDBParametros("Corr.Reimprimir.DocEnt") = "N" And Tipo = "ENTRADA" Then
                Dim IdIngreso As Integer = clSeguros.ObtenerID("Num.DocIngreso." & Date.Today.Year.ToString & "." & Date.Today.Month.ToString)
                SetRepFormulaString(Reporte, "NumIngreso", IdIngreso.ToString)
                For Each FilDocE As DataRow In dtFlujos.Rows
                    StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set doc_impreso = 'S', NumCorrIngreso = " & dbInt(IdIngreso) & " where IdFlujoDoc = " & dbStr(dbData(FilDocE, "IdFlujoDoc")) & " and IdImpresion = " & dbStr(dbData(FilDocE, "IdImpresion")))
                Next
            End If

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtFlujos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ' ''Definiremos algunos datos del reporte
            Dim strLFecha As String = ""

            If FechaDesde = FechaHasta Then
                strLFecha = "PARA EL " & Format(CDate(FechaDesde), "dd/MMM/yyyy").ToUpper
            Else
                strLFecha = "ENTRE EL " & Format(CDate(FechaDesde), "dd/MMM/yyyy").ToUpper & " y el " & Format(CDate(FechaHasta), "dd/MMM/yyyy").ToUpper
            End If

            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "RECEPCION: " & Tipo & " DE DOCUMENTOS, " & strLFecha)
            'SetRepFormulaString(Reporte,"Titulo2", "Ingresos entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
            'SetRepFormulaString(Reporte,"Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.Show()
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Public Sub ImprimirCartaCobro(ByVal IdCliente As String, ByVal ListaFacturas As String, ByVal FiltroFacturas As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String)
        Try
            'Generaremos la impresion las cartas de cobro a los clientes
            Dim Reporte As Object
            Reporte = New RepCartaCobro
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Carta.Cobro")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim Rep As New frmReportes
            Dim sql As String = ""

            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",getdate() as FechaPago"
            sql &= ", f.FechaPago as FechaVence"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",isnull(abs(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(abs(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(abs(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(abs(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(abs(m.Gastos),0) as Gastos"
            sql &= ",isnull(abs(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(abs(m.Total),0) as Total"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.TipoFactura"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.NombreCliente"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ", f.Referencia"
            sql &= ",isnull(f.DocumentoFiscal,'') as DocumentoFiscal"
            sql &= ", isnull(f.IdCliente,'') as IdCliente"
            sql &= ", f.FechaPago as FechaVence"
            sql &= ", abs(datediff(d,f.FechaPago,getdate())) as DiasVence "
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.IdMovimiento = 1"
            sql &= " left join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " inner join Productos as p on p.idproducto = f.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where f.IdCliente = " & dbStr(IdCliente)

            If ListaFacturas <> "" Then
                Dim lstFac As String = ObtenerListaNumericaPatron(ListaFacturas)
                If lstFac <> "" Then
                    sql &= " and f.NumeroFactura in (" & lstFac & ") "
                End If
            End If

            If FiltroFacturas <> "" Then
                sql &= " " & FiltroFacturas
            End If

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))


            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo)

            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If

            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Public Function ImprimirCartaCancelacionTarjeta(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaCancelaTarjeta
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Cancela.Tarjeta")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", a.IdAseguradora"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Dim AtencionNombre As String = "", AtencionCargo As String = ""
            Try
                AtencionNombre = StiGlobalConn.ObtenerDataset("select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = " & dbStr(dtPoliza.Rows(0).Item("IdAseguradora")) & " and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto").Tables(0).Rows(0).Item(0)
                SetRepFormulaString(Reporte, "AtencionNombre", AtencionNombre)
            Catch ex As Exception
                AtencionNombre = ""
            End Try
            Try
                AtencionCargo = StiGlobalConn.ObtenerDataset("select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = " & dbStr(dtPoliza.Rows(0).Item("IdAseguradora")) & " and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto").Tables(0).Rows(0).Item(0)
                SetRepFormulaString(Reporte, "AtencionCargo", AtencionCargo)
            Catch ex As Exception
                AtencionCargo = ""
            End Try



            SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Function ImprimirCartaAutorizacionTarjeta(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal CodigoCorrespondencia As String, ByVal parBanco As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String) As String
        Dim res As String = ""
        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New repCorrCartaAutorizaTarjeta
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Autoriza.Tarjeta")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= ", a.IdAseguradora"
            sql &= " from Polizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(IdPoliza)
            sql &= " and p.idproducto = " & dbStr(IdProducto)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))

            Try
                If parBanco <> "" Then SetRepFormulaString(Reporte, "Banco", "del Banco: " & parBanco)
            Catch ex As Exception

            End Try

            Dim AtencionNombre As String = "", AtencionCargo As String = ""
            Try
                AtencionNombre = StiGlobalConn.ObtenerDataset("select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = " & dbStr(dtPoliza.Rows(0).Item("IdAseguradora")) & " and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto").Tables(0).Rows(0).Item(0)
                SetRepFormulaString(Reporte, "AtencionNombre", AtencionNombre)
            Catch ex As Exception
                AtencionNombre = ""
            End Try
            Try
                AtencionCargo = StiGlobalConn.ObtenerDataset("select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = " & dbStr(dtPoliza.Rows(0).Item("IdAseguradora")) & " and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto").Tables(0).Rows(0).Item(0)
                SetRepFormulaString(Reporte, "AtencionCargo", AtencionCargo)
            Catch ex As Exception
                AtencionCargo = ""
            End Try

            SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)

            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            Dim UltimaCuota As String = ""
            Try
                sql = "  select min(f.NumeroFactura)"
                sql &= " from Facturas as f"
                sql &= " where f.IdProducto = " & dbStr(IdProducto)
                sql &= " and f.IdPoliza = " & dbStr(IdPoliza)
                sql &= " and (select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo ) > 0 "

                UltimaCuota = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

                sql = " select cast(NumCuota as varchar) + '/' + cast(TotalCuotas as varchar) "
                sql &= " from Facturas as f"
                sql &= " where f.IdProducto = " & dbStr(IdProducto)
                sql &= " and f.IdPoliza = " & dbStr(IdPoliza)
                sql &= " and f.NumeroFactura = " & dbInt(UltimaCuota)
                UltimaCuota = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)


                SetRepFormulaString(Reporte, "UltimaCuota", UltimaCuota)
            Catch ex As Exception
                UltimaCuota = ""
            End Try

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            res &= ex.Message
        End Try

        Return res
    End Function

    Public Sub ImprimirQuedanFactura(ByVal IdCliente As String, ByVal FiltroFacturas As String, ByVal NumeroQuedan As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String)
        Try
            'Generaremos la impresion del aviso de cobros

            Dim Reporte As New repCorrQuedanFactura
            Dim Rep As New frmReportes
            Dim sql As String = ""
            Dim Nota As String = "", Saldo As Double = 0

            sql = "  select "
            sql &= " ac.IdAvisoCobro as IdAvisoCobro"
            sql &= ",f.NumeroFactura as NumeroFactura"
            sql &= ",m.FechaMovimiento as FechaPago"
            sql &= ",f.NumCuota as NumCuota"
            sql &= ",f.TotalCuotas as TotalCuotas"
            sql &= ",cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumeroCuota"
            sql &= ",isnull(abs(m.PrimaNeta),0) as PrimaNeta"
            sql &= ",isnull(abs(m.GastosEmision),0) as GastosEmision"
            sql &= ",isnull(abs(m.GastosFracciona),0) as GastosFracciona"
            sql &= ",isnull(abs(m.GastosBomberos),0) GastosBomberos"
            sql &= ",isnull(abs(m.Gastos),0) as Gastos"
            sql &= ",isnull(abs(m.Impuestos),0) as Impuestos"
            sql &= ",isnull(abs(m.Total),0) as Total"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",f.TipoFactura"
            sql &= ",f.IdPoliza as Poliza"
            sql &= ",f.NombreCliente"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",f.Referencia"
            sql &= ",isnull(f.DocumentoFiscal,'') as DocumentoFiscal"
            sql &= ", " & dbStr(Nota) & " as Nota"
            sql &= ", isnull(f.IdCliente,'') as IdCliente"
            sql &= ", a.IdAseguradora"
            sql &= " from facturas as f "
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.IdMovimiento = 1"
            sql &= " left join AvisosCobroFacturas as ac on f.IdPoliza = ac.IdPoliza and f.IdProducto = ac.IdProducto and f.NumeroFactura = ac.NumeroFactura and f.IdRamo = ac.IdRamo"
            sql &= " inner join Productos as p on p.idproducto = f.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where f.IdCliente = " & dbStr(IdCliente)

            If FiltroFacturas <> "" Then
                sql &= " " & FiltroFacturas
            End If

            Dim dtFA As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtFA.TableName = "Primas"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtFA.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))
            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))

            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))

            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "NoQuedan", NumeroQuedan)
            Dim AtencionNombre As String = "", AtencionCargo As String = ""
            Try
                AtencionNombre = StiGlobalConn.ObtenerDataset("select top 1 ct.Nombre from AseguradorasContactos as ct where ct.IdAseguradora = " & dbStr(dtFA.Rows(0).Item("IdAseguradora")) & " and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto").Tables(0).Rows(0).Item(0)
                SetRepFormulaString(Reporte, "AtencionNombre", AtencionNombre)
            Catch ex As Exception
                AtencionNombre = ""
            End Try
            Try
                AtencionCargo = StiGlobalConn.ObtenerDataset("select top 1 ct.Cargo from AseguradorasContactos as ct where ct.IdAseguradora = " & dbStr(dtFA.Rows(0).Item("IdAseguradora")) & " and ct.Funciones like '%COBRO TARDIO%' order by ct.IdContacto").Tables(0).Rows(0).Item(0)
                SetRepFormulaString(Reporte, "AtencionCargo", AtencionCargo)
            Catch ex As Exception
                AtencionCargo = ""
            End Try

            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If
            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre.Trim)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo.Trim)
            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", "Atención: " & parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)


            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Public Sub ImprimirNotaGestion(ByVal Asunto As String, ByVal Referencia As String, ByVal Poliza As String, ByVal NombreCliente As String, ByVal Tipo As String, ByVal Forma As String, ByVal CodigoCorrespondencia As String, ByVal parFirmaNombre As String, ByVal parFirmaCargo As String, ByVal parAtteNombre As String, ByVal parAtteCargo As String)
        Try
            'Generaremos la impresion las cartas de cobro a los clientes
            Dim Reporte As Object
            Reporte = New repCorrNotaGestionConsultores
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Carta.NotaGestion")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Dim Rep As New frmReportes
            Dim sql As String = ""

            Dim UsuarioImprime As String = StiGlobalConn.ObtenerDataset("select NombreUsuario from usuarios where idusuario = " & dbStr(StiGlobalConn.User)).Tables(0).Rows(0).Item(0)

            sql = "  select "
            sql &= " " & dbStr(NombreCliente) & " as NombreCliente "
            sql &= ", " & dbStr(Poliza) & " as Aseguradora"
            sql &= ", " & dbStr(UsuarioImprime) & " as IdUsuarioImprime"
            sql &= ", " & dbStr(Tipo) & " as TipoFlujo"
            sql &= ", " & dbStr(Forma) & " as Courier"
            sql &= ", " & dbStr(Referencia) & " as Comentario"
            sql &= ", " & dbStr(Asunto) & " as DescripcionImpresion"



            Dim dtNG As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtNG.TableName = "Correspondencia"

            Dim dsRep As New DataSet
            dsRep.Tables.Add(dtNG.Copy)
            dsRep.Tables.Add(tblLogo.Copy)

            Reporte.SetDataSource(dsRep)

            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Pagos"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Pagos"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            SetRepFormulaString(Reporte, "DireccionEmpresa", clSeguros.ObtenerDBParametros("Direccion.Correduria"))
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "NumeroPBX", clSeguros.ObtenerDBParametros("PBX.Correduria"))
            SetRepFormulaString(Reporte, "NumeroFax", clSeguros.ObtenerDBParametros("FAX.Correduria"))
            SetRepFormulaString(Reporte, "EmailCorreduria", clSeguros.ObtenerDBParametros("EMail.Correduria"))


            If parFirmaNombre.Trim <> "" Then SetRepFormulaString(Reporte, "Gerente", parFirmaNombre)
            If parFirmaCargo.Trim <> "" Then SetRepFormulaString(Reporte, "CargoGerente", parFirmaCargo)

            If parAtteNombre.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionNombre", parAtteNombre.Trim)
            If parAtteCargo.Trim <> "" Then SetRepFormulaString(Reporte, "AtencionCargo", parAtteCargo.Trim)

            SetRepFormulaString(Reporte, "NumeroSecuencia", "")

            If CodigoCorrespondencia = "" Then
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", "")
            Else
                SetRepFormulaString(Reporte, "NumeroCorrespondencia", CodigoCorrespondencia)
            End If

            Rep.CRViewer.ReportSource = Reporte
            Rep.MdiParent = frmPrincipal
            Rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Public Sub SetRepFormulaString(ByRef Reporte As Object, ByVal NombreFormula As String, ByVal ValorFormula As String)
        Try
            Reporte.DataDefinition.FormulaFields(NombreFormula).Text = DobleComilla(ValorFormula)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AgregarLogRuteo(ByVal IdFlujoDoc As String, ByVal IdImpresion As String, ByVal EsRuteo As Boolean)
        Try
            Dim sql As String = ""
            Dim FechaRuteo As String
            Dim FechaDesRuteo As String
            If EsRuteo = True Then
                FechaRuteo = dbFec(Date.Now, "1")
                FechaDesRuteo = "NULL"
            Else
                FechaRuteo = "NULL"
                FechaDesRuteo = dbFec(Date.Now, "1")
            End If
            sql &= " insert into FlujosDocumentosImpresionesRuteos "
            sql &= " (IdFlujoDoc, IdImpresion, FechaRuteo, FechaDesRuteo, UsuarioRuteo) values ("
            sql &= dbStr(IdFlujoDoc, 25) & C & dbStr(IdImpresion, 25) & C & FechaRuteo & C & FechaDesRuteo & C & dbStr(StiGlobalConn.User, 25) & ") "
            StiGlobalConn.SQLExecute(sql)
        Catch ex As Exception

        End Try
    End Sub

    Public function ObtenerListaDocumentosPendientes() as String
        dim res as string = ""
        try
            Dim sql As String = ""
            Dim opcHora As String = clSeguros.ObtenerDBParametros("Coor.Hora.CierreDoc")
            If opcHora = "" Then opcHora = "17:00"

            sql = " select a.IdImpresion, b.IdFlujoDoc, a.FechaImpresion, a.NumCorrIngreso "
            sql &= " from FlujosDocumentosImpresiones as a "
            sql &= " inner join FlujosDocumentos as b on a.IdFlujoDoc = b.IdFlujoDoc "
            sql &= " where a.FechaImpresion <= " & dbStr(DateAdd(DateInterval.Day, -1, Date.Today).ToString("yyyyMMdd") & " " & opcHora & ":00")
            sql &= " and a.FechaImpresion >= '20180315' "
            sql &= " and isnull(a.NumCorrIngreso,0) > 0 and isnull(a.doc_impreso,'') = 'S' "
            sql &= " and isnull(b.idusuariodestino,'') = '' "

            dim dtFlujos as datatable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            for each FilFlu as Datarow in dtFlujos.rows
                res &= dbData(FilFlu, "IdImpresion") & " - Flujo: " & dbData(FilFlu, "IdFlujoDoc") & " " & CDate(dbData(FilFlu, "FechaImpresion")).ToString("dd/MMM/yyyy") & " Hoja: " & dbData(FilFlu, "NumCorrIngreso") & ", "
            Next

        Catch ex As Exception
            res = ""
        End Try
        return res
    End Function

#End Region

#Region "Gestión Comisiones"

    Public Structure ComisionVendedor
        Dim Porce As Double
        Dim Valor As Double
        Dim FormaPago As String
    End Structure

    Public Function ObtenerComisionVendedor(ByVal IdVendedor As String, ByVal IdProducto As String, ByVal IdPoliza As String) As ComisionVendedor
        Dim res As New ComisionVendedor
        Dim sql As String = ""

        'Se involucra la póliza para determinar en que vigencia está
        'las comisiones están en el producto
        'El tipo de agente determina que comisión se dará al tipo de agente

        Try
            ''sql = "  select ci.PorceComi, ci.ValorComi, ci.FormaPago "
            ''sql &= " from ProductosComisionesInternas as ci "
            ''sql &= " inner join TipoVendedor as tv on tv.IdTipoVendedor = ci.IdTipoVendedor "
            ''sql &= " inner join Vendedores as v on v.IdTipoVendedor = tv.IdTipoVendedor "
            ''sql &= " inner join Polizas as p on p.IdProducto = ci.IdProducto and p.idpoliza = " & dbStr(IdPoliza)
            ''sql &= " where ci.IdProducto = " & dbStr(IdProducto) & " and v.IdVendedor = " & dbStr(IdVendedor)
            ''sql &= " and ci.Anio <= isnull(p.NumVigencia,1) "
            ''sql &= " order by ci.Anio desc "
            Dim NumVendedores As Integer = 0
            NumVendedores = StiGlobalConn.ObtenerDataset("select count(*) from PolizasVendedores where IdProducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0).Item(0)

            sql = "  select ci.PorceComi, ci.ValorComi, ci.FormaPago, v.Orden "
            sql &= " from Polizas as p "
            sql &= " inner join PolizasVendedores as v on p.IdProducto = v.IdProducto and p.idpoliza = v.idpoliza and v.idvendedor = " & dbStr(IdVendedor)
            sql &= " inner join ProductosComisionesInternas as ci on ci.idproducto = p.idproducto and ci.IdTipoVendedor = v.IdTipoVendedor and ci.Anio <= isnull(p.NumVigencia,1) "
            sql &= " where p.IdProducto = " & dbStr(IdProducto) & " and p.idpoliza = " & dbStr(IdPoliza)
            sql &= " order by ci.Anio desc "

            Dim FilComi As DataRow
            FilComi = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
            If NumVendedores = 1 Then
                res.Porce = Val(dbData(FilComi, "PorceComi"))
                res.Valor = Val(dbData(FilComi, "ValorComi"))
                res.FormaPago = dbData(FilComi, "FormaPago")
            Else
                If Val(dbData(FilComi, "Orden")) > 1 Then
                    res.Porce = Val(dbData(FilComi, "PorceComi"))
                    res.Valor = Val(dbData(FilComi, "ValorComi"))
                    res.FormaPago = dbData(FilComi, "FormaPago")
                Else
                    res.Porce = Val(dbData(FilComi, "PorceComi"))
                    res.Valor = Val(dbData(FilComi, "ValorComi"))
                    res.FormaPago = dbData(FilComi, "FormaPago")
                    ''cuando hay mas de un vendedor al principal se le descuenta la comision de los demas
                    sql = "  select sum(ci.PorceComi) as PorceComi, sum(ci.ValorComi) as ValorComi "
                    sql &= " from Polizas as p "
                    sql &= " inner join PolizasVendedores as v on p.IdProducto = v.IdProducto and p.idpoliza = v.idpoliza and v.orden > 1 "
                    sql &= " inner join ProductosComisionesInternas as ci on ci.idproducto = p.idproducto and ci.IdTipoVendedor = v.IdTipoVendedor and ci.Anio <= isnull(p.NumVigencia,1) "
                    sql &= " where p.IdProducto = " & dbStr(IdProducto) & " and p.idpoliza = " & dbStr(IdPoliza)
                    FilComi = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    res.Porce -= Val(dbData(FilComi, "PorceComi"))
                    res.Valor -= Val(dbData(FilComi, "ValorComi"))

                End If
            End If
        Catch ex As Exception
            res.Porce = 0
            res.Valor = 0
            res.FormaPago = ""
        End Try
        Return res

    End Function

#End Region

#Region "Gestión Siniestros"

    Public Function ObtenerSaldoDeducible(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal IdBien As Integer, ByVal IdSiniestro As String, ByVal FechaReclamo As DateTime, ByVal AmbitoReclamo As String) As Double
        ''Obtendremos el deducible que actualmente lleva acumulado el asegurado
        Dim res As Double = 0
        Dim FechaDesde As String = "", FechaHasta As String = ""
        Dim sql As String = ""
        Dim filPoliza As DataRow
        Try
            ''Obtendremos la vigencia coincidente del certificado
            Try
                sql = " select top 1 VigenciaDesde, VigenciaHasta "
                sql &= " from HPolizasCertificados"
                sql &= " where idpoliza = " & dbStr(IdPoliza)
                sql &= " And IdProducto = " & dbStr(IdProducto)
                sql &= " And IdCertificado = " & dbStr(IdCertificado)
                sql &= " and VigenciaDesde <= " & dbFec(FechaReclamo)
                sql &= " and VigenciaHasta >= " & dbFec(FechaReclamo)
                sql &= " order by IdHistorico desc"
                filPoliza = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                FechaDesde = dbData(filPoliza, "VigenciaDesde")
                FechaHasta = dbData(filPoliza, "VigenciaHasta")
            Catch ex As Exception
                filPoliza = Nothing
            End Try
            If filPoliza Is Nothing Then
                Try
                    sql = " select top 1 VigenciaDesde, VigenciaHasta "
                    sql &= " from PolizasCertificados"
                    sql &= " where idpoliza = " & dbStr(IdPoliza)
                    sql &= " And IdProducto = " & dbStr(IdProducto)
                    sql &= " And IdCertificado = " & dbStr(IdCertificado)
                    filPoliza = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    FechaDesde = dbData(filPoliza, "VigenciaDesde")
                    FechaHasta = dbData(filPoliza, "VigenciaHasta")
                Catch ex As Exception

                End Try
            End If

            Dim ModoDeducible As String = ""
            Try
                ModoDeducible = StiGlobalConn.ObtenerDataset("select TipoDeducible from Polizas where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                ModoDeducible = "V"
            End Try

            sql = "  select isnull(sum(TotalDeducible),0) "
            sql &= " from Siniestros "
            sql &= " where idpoliza = " & dbStr(IdPoliza)
            sql &= " and idproducto = " & dbStr(IdProducto)
            sql &= " and IdCertificado = " & dbStr(IdCertificado)
            sql &= " and IdBien = " & dbInt(IdBien)
            Select Case ModoDeducible.ToUpper
                Case "V"
                    sql &= " and FechaOcurrido between " & dbFec(FechaDesde) & " and " & dbFec(FechaHasta)
                Case "A"
                    sql &= " and FechaOcurrido between " & dbFec(DateSerial(FechaReclamo.Year, 1, 1)) & " and " & dbFec(DateSerial(FechaReclamo.Year, 12, 31))
            End Select

            If IdSiniestro <> "" Then
                sql &= " and idsiniestro <> " & dbStr(IdSiniestro)
            End If

            If AmbitoReclamo <> "" Then
                Select Case AmbitoReclamo.ToUpper
                    Case "L", ""
                        sql &= " and (AmbitoSiniestro is null or AmbitoSiniestro = 'L') "
                    Case Else
                        sql &= " and AmbitoSiniestro = " & dbStr(AmbitoReclamo)
                End Select
            End If

            res = CDbl(StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0))

        Catch ex As Exception
            res = 0
        End Try

        Return res
    End Function

    Public Function ObtenerSaldoCoaseguro(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal IdBien As Integer, ByVal IdSiniestro As String, ByVal FechaReclamo As DateTime) As Double
        ''Obtendremos el deducible que actualmente lleva acumulado el asegurado
        Dim res As Double = 0
        Dim FechaDesde As String = "", FechaHasta As String = ""
        Dim sql As String = ""
        Dim filPoliza As DataRow
        Try
            ''Obtendremos la vigencia coincidente del certificado
            Try
                sql = " select top 1 VigenciaDesde, VigenciaHasta "
                sql &= " from HPolizasCertificados"
                sql &= " where idpoliza = " & dbStr(IdPoliza)
                sql &= " And IdProducto = " & dbStr(IdProducto)
                sql &= " And IdCertificado = " & dbStr(IdCertificado)
                sql &= " and VigenciaDesde <= " & dbFec(FechaReclamo)
                sql &= " and VigenciaHasta >= " & dbFec(FechaReclamo)
                sql &= " order by IdHistorico desc"
                filPoliza = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                FechaDesde = dbData(filPoliza, "VigenciaDesde")
                FechaHasta = dbData(filPoliza, "VigenciaHasta")
            Catch ex As Exception
                filPoliza = Nothing
            End Try
            If filPoliza Is Nothing Then
                Try
                    sql = " select top 1 VigenciaDesde, VigenciaHasta "
                    sql &= " from PolizasCertificados"
                    sql &= " where idpoliza = " & dbStr(IdPoliza)
                    sql &= " And IdProducto = " & dbStr(IdProducto)
                    sql &= " And IdCertificado = " & dbStr(IdCertificado)
                    filPoliza = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    FechaDesde = dbData(filPoliza, "VigenciaDesde")
                    FechaHasta = dbData(filPoliza, "VigenciaHasta")
                Catch ex As Exception

                End Try
            End If

            If FechaDesde <> "" And FechaHasta <> "" Then
                sql = "  select isnull(sum(TotalCoaseguro),0) "
                sql &= " from Siniestros "
                sql &= " where idpoliza = " & dbStr(IdPoliza)
                sql &= " and idproducto = " & dbStr(IdProducto)
                sql &= " and IdCertificado = " & dbStr(IdCertificado)
                sql &= " and IdBien = " & dbInt(IdBien)
                sql &= " and FechaOcurrido between " & dbFec(FechaDesde) & " and " & dbFec(FechaHasta)
                If IdSiniestro <> "" Then
                    sql &= " and idsiniestro <> " & dbStr(IdSiniestro)
                End If
                res = CDbl(StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0))
            End If
        Catch ex As Exception
            res = 0
        End Try

        Return res
    End Function

    Public Function ObtenerLimiteDeducible(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal IdBien As Integer, ByVal FechaReclamo As DateTime, ByVal AmbitoReclamo As String) As Double
        Dim res As Double = 0
        Dim sql As String = ""
        Dim strBien As String = ""

        Try

            'primero intentamos los nuevos campos deducibles por ámbito
            Select Case AmbitoReclamo.Trim.ToUpper
                Case "L", ""
                    ''Obtendremos la vigencia coincidente del certificado
                    Try
                        sql = " select top 1 b.DescripcionBien "
                        sql &= " from HPolizas as p "
                        sql &= " inner join HPolizasBienes as b on p.idpoliza = b.idpoliza and p.IdProducto = b.IdProducto and p.IdHistorico = b.IdHistorico "
                        sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                        sql &= " And b.IdProducto = " & dbStr(IdProducto)
                        sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                        sql &= " and b.NombreBien = 'DEDUCIBLE CA' "
                        sql &= " and p.VigenciaDesde <= " & dbFec(FechaReclamo)
                        sql &= " and p.VigenciaHasta >= " & dbFec(FechaReclamo)
                        sql &= " order by b.IdHistorico desc"
                        strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        strBien = ""
                    End Try

                    If strBien = "" Then
                        Try
                            sql = " select top 1 b.DescripcionBien "
                            sql &= " from PolizasBienes as b "
                            sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                            sql &= " And b.IdProducto = " & dbStr(IdProducto)
                            sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                            sql &= " and b.NombreBien = 'DEDUCIBLE CA' "
                            strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            strBien = ""
                        End Try
                        
                    End If
                    If strBien <> "" Then
                        If Val(strBien) > 0 Then Return Val(strBien)
                    End If

                Case "M"
                    ''Obtendremos la vigencia coincidente del certificado
                    Try
                        sql = " select top 1 b.DescripcionBien "
                        sql &= " from HPolizas as p "
                        sql &= " inner join HPolizasBienes as b on p.idpoliza = b.idpoliza and p.IdProducto = b.IdProducto and p.IdHistorico = b.IdHistorico "
                        sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                        sql &= " And b.IdProducto = " & dbStr(IdProducto)
                        sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                        sql &= " and b.NombreBien = 'DEDUCIBLE FUERA CA' "
                        sql &= " and p.VigenciaDesde <= " & dbFec(FechaReclamo)
                        sql &= " and p.VigenciaHasta >= " & dbFec(FechaReclamo)
                        sql &= " order by b.IdHistorico desc"
                        strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        strBien = ""
                    End Try

                    If strBien = "" Then
                        Try
                            sql = " select top 1 b.DescripcionBien "
                            sql &= " from PolizasBienes as b "
                            sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                            sql &= " And b.IdProducto = " & dbStr(IdProducto)
                            sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                            sql &= " and b.NombreBien = 'DEDUCIBLE FUERA CA' "
                            strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            strBien = ""
                        End Try
                        
                    End If
                    If strBien <> "" Then
                        If Val(strBien) > 0 Then Return Val(strBien)
                    End If

                Case "D"
                    ''Obtendremos la vigencia coincidente del certificado
                    Try
                        sql = " select top 1 b.DescripcionBien "
                        sql &= " from HPolizas as p "
                        sql &= " inner join HPolizasBienes as b on p.idpoliza = b.idpoliza and p.IdProducto = b.IdProducto and p.IdHistorico = b.IdHistorico "
                        sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                        sql &= " And b.IdProducto = " & dbStr(IdProducto)
                        sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                        sql &= " and b.NombreBien = 'DEDUCIBLE DENTAL' "
                        sql &= " and p.VigenciaDesde <= " & dbFec(FechaReclamo)
                        sql &= " and p.VigenciaHasta >= " & dbFec(FechaReclamo)
                        sql &= " order by b.IdHistorico desc"
                        strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        strBien = ""
                    End Try

                    If strBien = "" Then
                        Try
                            sql = " select top 1 b.DescripcionBien "
                            sql &= " from PolizasBienes as b "
                            sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                            sql &= " And b.IdProducto = " & dbStr(IdProducto)
                            sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                            sql &= " and b.NombreBien = 'DEDUCIBLE DENTAL' "
                            strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            strBien = ""
                        End Try
                        
                    End If
                    If strBien <> "" Then
                        If Val(strBien) > 0 Then Return Val(strBien)
                    End If

            End Select


            ''Obtendremos la vigencia coincidente del certificado con el modelo de vida

            Try
                sql = " select top 1 b.DescripcionBien "
                sql &= " from HPolizas as p "
                sql &= " inner join HPolizasBienes as b on p.idpoliza = b.idpoliza and p.IdProducto = b.IdProducto and p.IdHistorico = b.IdHistorico "
                sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                sql &= " And b.IdProducto = " & dbStr(IdProducto)
                sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                sql &= " and b.NombreBien = 'DEDUCIBLE' "
                sql &= " and p.VigenciaDesde <= " & dbFec(FechaReclamo)
                sql &= " and p.VigenciaHasta >= " & dbFec(FechaReclamo)
                sql &= " order by b.IdHistorico desc"
                strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                strBien = ""
            End Try

            If strBien = "" Then
                Try
                    sql = " select top 1 b.DescripcionBien "
                    sql &= " from PolizasBienes as b "
                    sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                    sql &= " And b.IdProducto = " & dbStr(IdProducto)
                    sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                    sql &= " and b.NombreBien = 'DEDUCIBLE' "
                    strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    strBien = ""
                End Try
                
            End If

            If strBien <> "" Then
                Try
                    Select Case AmbitoReclamo
                        Case "", "L"
                            strBien = stiSplit(stiSplit(strBien, "G0/1").Trim, "G1:1").Trim
                        Case "M"
                            strBien = stiSplit(stiSplit(strBien, "G1/1").Trim, "G1:1").Trim
                    End Select
                    If strBien <> "" Then
                        If Val(strBien) > 0 Then Return Val(strBien)
                    End If
                Catch ex As Exception

                End Try
            End If

            'los metodos anteriores se validan en vida, intentaremos recuperarlo del certificado
            If strBien = "" Then
                Try
                    sql = " select top 1 Deducible "
                    sql &= " from HPolizasCertificados as p "
                    sql &= " where p.idpoliza = " & dbStr(IdPoliza)
                    sql &= " And p.IdProducto = " & dbStr(IdProducto)
                    sql &= " And p.IdCertificado = " & dbStr(IdCertificado)
                    sql &= " and p.VigenciaDesde <= " & dbFec(FechaReclamo)
                    sql &= " and p.VigenciaHasta >= " & dbFec(FechaReclamo)
                    sql &= " order by p.IdHistorico desc"
                    strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    strBien = ""
                End Try
            End If

            If strBien = "" Then
                Try
                    sql = " select Deducible "
                    sql &= " from PolizasCertificados as p "
                    sql &= " where p.idpoliza = " & dbStr(IdPoliza)
                    sql &= " And p.IdProducto = " & dbStr(IdProducto)
                    sql &= " And p.IdCertificado = " & dbStr(IdCertificado)
                    strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    strBien = ""
                End Try
            End If

            If strBien <> "" Then
                Return Val(strBien)
            End If

        Catch ex As Exception

        End Try

        Return res
    End Function

    Public Function ObtenerLimiteCoaseguro(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal IdBien As Integer, ByVal FechaReclamo As DateTime, ByVal AmbitoReclamo As String) As Double
        Dim res As Double = 0
        Dim sql As String = ""
        Dim strBien As String = ""

        Try
            Try
                sql = " select top 1 b.DescripcionBien "
                sql &= " from HPolizas as p "
                sql &= " inner join HPolizasBienes as b on p.idpoliza = b.idpoliza and p.IdProducto = b.IdProducto and p.IdHistorico = b.IdHistorico "
                sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                sql &= " And b.IdProducto = " & dbStr(IdProducto)
                sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                sql &= " and b.NombreBien = 'LIMITE COASEGURO' "
                sql &= " and p.VigenciaDesde <= " & dbFec(FechaReclamo)
                sql &= " and p.VigenciaHasta >= " & dbFec(FechaReclamo)
                sql &= " order by b.IdHistorico desc"
                strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                strBien = ""
            End Try

            If strBien = "" Then
                sql = " select top 1 b.DescripcionBien "
                sql &= " from PolizasBienes as b "
                sql &= " where b.idpoliza = " & dbStr(IdPoliza)
                sql &= " And b.IdProducto = " & dbStr(IdProducto)
                sql &= " And b.IdCertificado = " & dbStr(IdCertificado)
                sql &= " and b.NombreBien = 'LIMITE COASEGURO' "
                strBien = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
            End If

            If strBien <> "" Then
                ''Obtendremos la vigencia coincidente del certificado
                Select Case AmbitoReclamo.Trim.ToUpper
                    Case "M"
                        'obtenermos el lim. coaseg. mundial
                        Try
                            strBien = stiSplit(stiSplit(strBien, "G1/1").Trim, "G1:1").Trim
                            res = CDbl(dbNum(strBien))
                        Catch ex As Exception

                        End Try
                    Case Else
                        'obtenermos el lim. coaseg. C.A.
                        Try
                            strBien = stiSplit(stiSplit(strBien, "G0/1").Trim, "G1:1").Trim
                            res = CDbl(dbNum(strBien))
                        Catch ex As Exception

                        End Try
                End Select
            End If
        Catch ex As Exception

        End Try

        Return res
    End Function

    Public Sub ActualizarSaldosSiniestros(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal IdSiniestro As String)
        Dim sql As String = ""
        Try
            sql = "  update siniestros set "
            sql &= " TotalPresentado = isnull((select sum(ValorPresentado) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalNoCubierto = isnull((select sum(ValorNoCubierto) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalCubierto = isnull((select sum(ValorCubierto) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalReembolso = isnull((select sum(ValorReembolso) from SiniestrosPagos where SiniestrosPagos.IdPoliza = siniestros.IdPoliza and SiniestrosPagos.IdProducto = siniestros.IdProducto and SiniestrosPagos.IdCertificado = siniestros.IdCertificado and SiniestrosPagos.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " ,TotalPendiente = isnull((select sum(ValorReserva) from SiniestrosReservas where SiniestrosReservas.IdPoliza = siniestros.IdPoliza and SiniestrosReservas.IdProducto = siniestros.IdProducto and SiniestrosReservas.IdCertificado = siniestros.IdCertificado and SiniestrosReservas.IdSiniestro = siniestros.IdSiniestro),0)"
            sql &= " where IdPoliza = " & dbStr(IdPoliza)
            sql &= " and IdProducto = " & dbStr(IdProducto)
            sql &= " and IdCertificado = " & dbStr(IdCertificado)
            sql &= " and IdSiniestro = " & dbStr(IdSiniestro)
            StiGlobalConn.SQLExecute(sql)

        Catch ex As Exception

        End Try
    End Sub

    Public Function AnularReclamo(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal IdSiniestro As String, ByVal DescripcionReserva As String, Optional ByVal TipoAnulacion As String = "RETIRADO") As String
        Dim res As String = ""
        Try
            Dim Sql As String = ""
            ''Saldaremos el valor de reserva
            Dim Reserva As Double = 0, IdReserva As Integer = 0
            Sql = "  select isnull(sum(ValorReserva),0) "
            Sql &= " from SiniestrosReservas"
            Sql &= " where idsiniestro = " & dbStr(IdSiniestro)
            Sql &= " and idproducto = " & dbStr(IdProducto)
            Sql &= " and idpoliza = " & dbStr(IdPoliza)
            Sql &= " and idcertificado = " & dbStr(IdCertificado)
            Reserva = StiGlobalConn.ObtenerDataset(Sql).Tables(0).Rows(0).Item(0)

            If Reserva <> 0 Then
                Reserva = Reserva * -1
                Sql = "  select isnull(max(IdReserva),0) + 1 "
                Sql &= " from SiniestrosReservas"
                Sql &= " where idsiniestro = " & dbStr(IdSiniestro)
                Sql &= " and idproducto = " & dbStr(IdProducto)
                Sql &= " and idpoliza = " & dbStr(IdPoliza)
                Sql &= " and idcertificado = " & dbStr(IdCertificado)
                IdReserva = StiGlobalConn.ObtenerDataset(Sql).Tables(0).Rows(0).Item(0)

                Sql = "  insert into SiniestrosReservas "
                Sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva,"
                Sql &= " FechaReserva, ValorReserva) values ("
                Sql &= dbStr(IdPoliza) & C & dbStr(IdProducto) & C & dbStr(IdCertificado) & C & dbStr(IdSiniestro) & C & dbInt(IdReserva) & C
                Sql &= dbFec(Date.Today) & C & dbNum(Reserva) & ")"
                StiGlobalConn.SQLExecute(Sql)
            End If

            'cambiamos el estado del reclamo
            Sql = "  update siniestros "
            Sql &= " set EstadoSiniestro = " & dbStr(TipoAnulacion)
            Sql &= " , TotalPendiente = 0.0 "
            Sql &= " , DescripcionReserva = " & dbStr(DescripcionReserva)
            Sql &= " where idsiniestro = " & dbStr(IdSiniestro)
            Sql &= " and idproducto = " & dbStr(IdProducto)
            Sql &= " and idpoliza = " & dbStr(IdPoliza)
            Sql &= " and idcertificado = " & dbStr(IdCertificado)
            StiGlobalConn.SQLExecute(Sql)

        Catch ex As Exception
            res &= ex.Message
        End Try
        Return res
    End Function

    Public Function ObtenerIdBienBeneficiarioVida(ByVal IdPoliza As String, ByVal IdProducto As String, ByVal IdCertificado As String, ByVal Nombre As String) As Integer
        Dim res As Integer = 1
        Try
            Dim sql As String = ""
            sql = "  select isnull(b.DescripcionBien, isnull(c.NombreCliente,'')) as Asegurado"
            sql &= " , row_number() OVER(PARTITION BY c.idproducto, c.idpoliza, c.idcertificado order BY c.idproducto, c.idpoliza, c.idcertificado,b.IdBien) as IdBien"
            sql &= " from PolizasCertificados as c"
            sql &= " left join PolizasBienes as b on b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien in ('DEPENDIENTES','BENEFICIARIOS', 'DEPENDIENTE', 'BENEFICIARIO')"
            sql &= " where c.idpoliza = " & dbStr(IdPoliza) & " and c.idproducto = " & dbStr(IdProducto) & " and c.idcertificado = " & dbStr(IdCertificado)
            Dim dtAsegurados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            res = dtAsegurados.Select("Asegurado = " & dbStr(Nombre))(0)("IdBien")
        Catch ex As Exception
            res = 1
        End Try
        Return res
    End Function

    Public Sub ImprimirEnvioSiniestro(ByVal IdEnvio As String, Optional ByVal IdSiniestro As String = "", Optional ByVal PedirDestinatario As Boolean = False)
        Try
            Dim NomFiltro As String = ""

            Dim FilEnvio As DataRow = StiGlobalConn.ObtenerDataset("select a.*, b.Nombre from EnviosSiniestros as a left join aseguradoras as b on a.idaseguradora = b.idaseguradora where IdEnvio = " & dbStr(IdEnvio)).Tables(0).Rows(0)

            Dim sql As String = ""
            sql = "  select e.IdPoliza "
            sql &= " , e.IdCertificado"
            sql &= " , e.IdSiniestro"
            sql &= " , e.IdProducto"
            sql &= " , s.NombrePresentaReclamo"
            sql &= " , a.nombre as Aseguradora"
            sql &= " ,isnull((select nombrecliente from Polizas as c where c.idpoliza = s.idpoliza and c.idproducto = s.idproducto ),'') as Contratante"
            sql &= " ,isnull((select nombrecliente from PolizasCertificados as c where c.idpoliza = s.idpoliza and c.idproducto = s.idproducto and c.idcertificado = s.idcertificado),'') as Asegurado"
            sql &= " ,(select sum(ValorPresentado) from SiniestrosDetalle as d where d.IdPoliza = e.IdPoliza and d.IdProducto = e.IdProducto and d.IdCertificado = e.IdCertificado and d.IdSiniestro = e.IdSiniestro ) as TotalPresentado"
            sql &= " , s.FechaOcurrido, s.IdSiniestroAseguradora"
            sql &= " ,case p.IdRamo when '501' then 'Lugar Siniestro: ' + cast(s.LugarSiniestros as varchar(max)) else '' end as LugarSiniestros"
            'sql &= " ,case p.IdRamo when '501' then 'Descripción: ' + cast(s.DescripcionSiniestro as varchar(max)) else '' end as DescripcionSiniestro"
            sql &= " ,'Descripción: ' + cast(s.DescripcionSiniestro as varchar(max)) as DescripcionSiniestro"
            sql &= " ,case p.IdRamo when '501' then (select top 1 isnull(b.DescripcionBien,'') from PolizasBienes as b where b.IdPoliza = s.IdPoliza and b.IdProducto = s.IdProducto and b.IdCertificado = s.IdCertificado and b.NombreBien = 'PLACA') else '' end as DescripcionReserva"
            sql &= " , po.IdCliente"
            sql &= " from EnviosSiniestrosDetalle as e "
            sql &= " left join Siniestros as s on s.IdPoliza = e.IdPoliza and s.IdProducto = e.IdProducto and s.IdCertificado = e.IdCertificado and s.IdSiniestro = e.IdSiniestro"
            sql &= " left join Productos as p on p.idproducto = s.idproducto"
            sql &= " left join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " left join Polizas as po on po.IdProducto = s.IdProducto and po.IdPoliza = s.IdPoliza"
            sql &= " where e.IdEnvio = " & dbStr(IdEnvio)
            If IdSiniestro <> "" Then
                sql &= " and e.idsiniestro = " & dbStr(IdSiniestro)
            End If
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            sql = "  update SiniestrosDetalle set SiniestrosDetalle.IdEnvio = " & dbStr(IdEnvio) & ", SiniestrosDetalle.FechaEnvio = " & dbFec(dbData(FilEnvio, "FechaEnvio"))
            sql &= " from SiniestrosDetalle "
            sql &= " inner join EnviosSiniestrosDetalle on EnviosSiniestrosDetalle.IdPoliza = SiniestrosDetalle.IdPoliza and EnviosSiniestrosDetalle.IdProducto = SiniestrosDetalle.IdProducto and EnviosSiniestrosDetalle.IdCertificado = SiniestrosDetalle.IdCertificado and EnviosSiniestrosDetalle.IdSiniestro = SiniestrosDetalle.IdSiniestro"
            sql &= " where SiniestrosDetalle.IdEnvio is null and EnviosSiniestrosDetalle .IdEnvio = " & dbStr(IdEnvio)
            StiGlobalConn.SQLExecute(sql)

            sql = "  select e.IdPoliza "
            sql &= " , e.IdCertificado"
            sql &= " , e.IdSiniestro"
            sql &= " , e.IdProducto"
            sql &= ", s.Descripcion"
            sql &= ", case "
            sql &= "  when s.FechaPresentado is not null then 'DOCUMENTOS PRESENTADOS'"
            sql &= "  else 'DOCUMENTOS PENDIENTES'"
            sql &= " end as Estado"
            sql &= " from EnviosSiniestrosDetalle as e "
            sql &= " inner join SiniestrosRequisitos as s on s.IdPoliza = e.IdPoliza and s.IdProducto = e.IdProducto and s.IdCertificado = e.IdCertificado and s.IdSiniestro = e.IdSiniestro"
            sql &= " where e.IdEnvio = " & dbStr(IdEnvio)
            sql &= " and (s.FechaPresentado is null or s.FechaPresentado >= " & dbFec(Date.Today) & ")"
            If IdSiniestro <> "" Then
                sql &= " and e.idsiniestro = " & dbStr(IdSiniestro)
            End If
            Dim dtReq As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtReq.TableName = "Requisitos"


            sql = "  select d.idpoliza"
            sql &= " ,d.idproducto"
            sql &= " ,d.idcertificado "
            sql &= " ,d.idsiniestro"
            sql &= " ,d.iddetalle as Orden"
            sql &= " ,isnull(g.Descripcion,'') as Gasto"
            sql &= " ,d.ValorPresentado as Presentado"
            sql &= " ,d.ValorNoCubierto as NoCubierto"
            sql &= " ,d.ValorCubierto as Cubierto"
            sql &= " ,isnull(d.Observaciones,'') as Observaciones"
            sql &= " ,d.FechaPresentado"
            sql &= " from SiniestrosDetalle as d"
            sql &= " inner join EnviosSiniestrosDetalle as e on e.IdPoliza = d.IdPoliza and e.IdProducto = d.IdProducto and e.IdCertificado = d.IdCertificado and e.IdSiniestro = d.IdSiniestro"
            sql &= " left join ProductosSinGastos as g on g.idproducto = e.idproducto and g.idgasto = d.idgasto"
            sql &= " where e.IdEnvio = " & dbStr(IdEnvio)
            sql &= " and (d.FechaPresentado is null or d.FechaPresentado >= " & dbFec(Date.Today) & ")"
            If IdSiniestro <> "" Then
                sql &= " and e.idsiniestro = " & dbStr(IdSiniestro)
            End If

            Dim dtGas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtGas.TableName = "Gastos"


            If dtSiniestros.Rows.Count > 0 Then
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtSiniestros.Copy)
                DsRep.Tables.Add(dtReq.Copy)
                DsRep.Tables.Add(dtGas.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes


                Dim Reporte As Object
                Reporte = New repCREnvio
                Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Envio.Reclamos")
                If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

                Reporte.SetDataSource(DsRep)

                ''Definiremos algunos datos del reporte
                SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
                SetRepFormulaString(Reporte, "Titulo1", "Reporte de Envío de Reclamo")
                SetRepFormulaString(Reporte, "Titulo2", "Envío No." & IdEnvio & " del " & Format(CDate(dbData(FilEnvio, "FechaEnvio")), "dd/MMM/yyyy"))
                SetRepFormulaString(Reporte, "Titulo3", "Reclamos entre el " & CDate(dbData(FilEnvio, "FechaDesde")).ToString("dd/MMM/yyyy") & " y el " & CDate(dbData(FilEnvio, "FechaHasta")).ToString("dd/MMM/yyyy"))
                SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

                SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.Env.Reclamo"))
                SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.Env.Reclamo"))
                SetRepFormulaString(Reporte, "Destinatario", "")


                'si hay un parametro activo que indique que esta impresion se incluya en los envios simples
                Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.EnvioSin")).Trim.ToUpper
                Dim IdFlujoDefault As String = "", NombreDestinatario As String = "", ClientesPlanilla As String = ""
                If IncluirEnEvioSimple = "S" Then
                    Try
                        IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                    Catch ex As Exception
                        IdFlujoDefault = ""
                    End Try
                    If IdFlujoDefault <> "" Then
                        Dim IdCorrespondencia As String = "ES-" & IdEnvio
                        clFlujos.RegistrarDocumento(IdFlujoDefault, "Envío de Reclamos :" & dbData(FilEnvio, "Nombre"), dbData(dtSiniestros.Rows(0), "IdCliente"), IdEnvio, "SALIDA", IdCorrespondencia, "", CDate(dbData(FilEnvio, "FechaEnvio")), CodigoImpresionDocumento:="VA")
                        Dim Direccion As String = ""
                        Try
                            Direccion = StiGlobalConn.ObtenerDataset("select isnull(Direccion,'') from aseguradoras where idaseguradora = " & dbStr(dbData(FilEnvio, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                            Dim srtParAsegNombreCorto As String = CStr(clSeguros.ObtenerDBParametros("Coor.Aseguradora.Sigla")).Trim.ToUpper
                            If srtParAsegNombreCorto = "S" Then
                                NombreDestinatario = StiGlobalConn.ObtenerDataset("select isnull(Siglas,'') from aseguradoras where idaseguradora = " & dbStr(dbData(FilEnvio, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                            Else
                                NombreDestinatario = StiGlobalConn.ObtenerDataset("select isnull(Nombre,'') from aseguradoras where idaseguradora = " & dbStr(dbData(FilEnvio, "IdAseguradora"))).Tables(0).Rows(0).Item(0)
                            End If
                            ClientesPlanilla = StiGlobalConn.ObtenerDataset("select distinct NombrePresentaReclamo + ',' from EnviosSiniestrosDetalle as es inner join Siniestros as s on s.IdPoliza = es.IdPoliza and s.IdProducto = es.IdProducto and s.IdCertificado = es.IdCertificado and s.IdSiniestro = es.IdSiniestro where es.IdEnvio = " & dbStr(IdEnvio) & " FOR XML PATH('')").Tables(0).Rows(0).Item(0)

                        Catch ex As Exception
                            Direccion = ""
                        End Try

                        If PedirDestinatario = True Then
                            Select Case GlobalCodCliente
                                Case "2120000"
                                    If MsgBox("El destinatario de este envío es la compañía aseguradora. ¿Desea cambiar destinatario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Pregunta...") = MsgBoxResult.Yes Then
                                        NombreDestinatario = InputBox("Ingrese el nombre del nuevo Destinatario:", "Correspondencia.")
                                        While Len(NombreDestinatario.Trim) < 3
                                            NombreDestinatario = InputBox("Ingrese el nombre del nuevo Destinatario (al menos 3 caracteres):", "Correspondencia.")
                                        End While
                                        SetRepFormulaString(Reporte, "Destinatario", "Destinatario: " & NombreDestinatario)
                                    End If
                            End Select
                        End If

                        'ruteamos el documento
                        Dim strSQL As String = ""
                        strSQL = "  update FlujosDocumentosImpresiones set "
                        strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                        strSQL &= " ,FechaImpresion = " & dbFec(Date.Now, "1")
                        strSQL &= " ,DireccionDocumento = " & dbStr(Direccion, 250)
                        strSQL &= " ,NombreDestinatario = " & dbStr(NombreDestinatario, 150)
                        strSQL &= " ,IdOrigen = " & dbStr(ClientesPlanilla, 250)
                        strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
                        StiGlobalConn.SQLExecute(strSQL)

                        Try
                            'desruteamos si ya ha sido enviado en ruta
                            If StiGlobalConn.ObtenerDataset("select count(*) from  FlujosDocumentosImpresiones where FechaEnvio is not null and IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)).Tables(0).Rows(0).Item(0) > 0 And clFlujos.ExisteRuteoAutomatico(dbData(dtSiniestros.Rows(0), "IdCliente")) = False Then
                                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set FechaEnvio = null, IdZona = null, Courier = null, NumEntrega = null, FechaDocMarcadoEntregado = null, usuarioimprime = " & dbStr(StiGlobalConn.User) & " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia))
                                StiGlobalConn.SQLExecute("insert into FlujosDocumentosImpresionesDes (IdFlujoDoc, IdImpresion, FechaDesruteo, UsuarioDesruteo, Motivo) values (" & dbStr(IdFlujoDefault, 25) & C & dbStr(IdCorrespondencia, 25) & C & dbFec(Date.Now, "1") & C & dbStr(StiGlobalConn.User, 25) & C & dbStr("DESRUTEADO POR ENVIO DE DOCUMENTACIÓN ADICIONAL", 250) & ")")
                            End If
                        Catch ex As Exception

                        End Try

                    End If
                End If

                rep.CRViewer.ReportSource = Reporte
                'rep.MdiParent = Me.MdiParent
                rep.Show()

            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub


#End Region

#Region "General"

    ''declaracion de clases 
    Public clFlujos As stiSISCO.stiFlujos
    Public clSeguros As stiSISCO.stiSeguros

    Public Sub IniciarClases()
        clFlujos = New stiSISCO.stiFlujos(StiGlobalConn)
        clSeguros = New stiSISCO.stiSeguros(StiGlobalConn)
    End Sub

    Public Function ObtenerLogUser(Optional ByVal Usuario As String = "", Optional ByVal parFecha As String = "") As String
        Dim res As String = ""
        Dim Fecha As DateTime
        If Usuario.Trim = "" Then Usuario = StiGlobalConn.User
        If parFecha = "" Then
            Fecha = Date.Now
        Else
            Try
                Fecha = CDate(parFecha)
                If Fecha.Year + Fecha.Month + Fecha.Day = 3 Then Fecha = Date.Now
            Catch ex As Exception
                Fecha = Date.Now
            End Try
        End If

        res = "Elaborado por: " & Usuario & """" & " & chr(13) & " & """" & "Fecha: " & Format(Fecha, "dd/MMM/yyyy hh:mm:ss")
        Return res
    End Function

    Public Sub EnviarCorreo(ByVal CorreoDestino As String, ByVal CorreoCopia As String, ByVal CorreoCopiaOculta As String, ByVal Asunto As String, ByVal Mensaje As String, ByVal ParamArray Attachment() As String)

        Try
            'del usuario en curso obtenemos el nombre y el correo.
            Dim CorreoUsuario As String = "", NombreUsuario As String = ""
            Try
                Dim FilaUsu As DataRow = StiGlobalConn.ObtenerDataset("select NombreUsuario, Email from Usuarios where IdUsuario = " & dbStr(StiGlobalConn.User)).Tables(0).Rows(0)
                CorreoUsuario = dbData(FilaUsu, "Email")
                NombreUsuario = dbData(FilaUsu, "NombreUsuario")
            Catch ex As Exception
                CorreoUsuario = ""
                NombreUsuario = ""
            End Try

            If CorreoUsuario = "" Then
                MsgBox("No se ha configurado correo en el usuario del sistema.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim NumCorreos As Integer = 0
            Dim Correo As String = ""
            Dim msg As New System.Net.Mail.MailMessage
            Dim Destino As New System.Net.Mail.MailAddress(CorreoUsuario, NombreUsuario)
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

            'ahora veremos si hay copias ocultas
            If CorreoCopiaOculta.Trim <> "" Then
                CorreoCopiaOculta = Replace(CorreoCopiaOculta, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoCopiaOculta, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoCopiaOculta, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.Bcc.Add(Correo)
                    End If
                Next
            End If

            'ahora haremos el tratamiento de los atachment
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
            msg.IsBodyHtml = False
            msg.Body = Mensaje
            msg.Priority = Net.Mail.MailPriority.High
            Dim SMTPServer As String = clSeguros.ObtenerDBParametros("Servidor.Correo")
            If SMTPServer.Trim = "" Then
                MsgBox("No se ha definido el servidor de correo en el sistema. Verifique los parámetros.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            Dim EmailServer As New System.Net.Mail.SmtpClient(SMTPServer)
            EmailServer.Send(msg)

        Catch ex As Exception
            MsgBox("Error al enviar correo: " & ex.Message)
        End Try
    End Sub

    Public Sub RegistrarLog(ByVal Accion As String, ByVal Tabla As String, ByVal Claves As String)
        Try
            Dim sql As String = ""
            sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
            sql &= dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr(Accion, 1) & C & dbStr(Tabla, 25) & C & dbStr(Claves, 150) & ")"
            StiGlobalConn.SQLExecute(sql)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RegistrarLogOferta(ByVal IdOferta As String, ByVal IdCotizacion As String, ByVal IdGestion As String, ByVal Accion As String, ByVal NombreCliente As String, ByVal IdProducto As String)
        Try
            Dim sql As String = ""
            sql = "insert into CGPolizasLog (IdOferta, IdCotizacion, IdGestion, Usuario, Fecha, Accion, NombreCliente, IdProducto) values("
            sql &= dbStr(IdOferta, 25) & C & dbStr(IdCotizacion, 25) & C & dbInt(IdGestion) & C & dbStr(StiGlobalConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr(Accion, 100) & C & dbStr(NombreCliente, 500) & C & dbStr(IdProducto, 25) & ")"
            StiGlobalConn.SQLExecute(sql)
        Catch ex As Exception

        End Try
    End Sub

    Public Function CrearNuevoObjeto(ByVal NombreObjeto As String) As Object
        Dim objGeneral As Object
        Try
            Dim CAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim NombreAssembly As String = stiSplit(CAssembly.FullName, "G0,1").Trim & "."
            objGeneral = CAssembly.CreateInstance(NombreAssembly & NombreObjeto)
        Catch ex As Exception
            objGeneral = Nothing
        End Try
        Return objGeneral
    End Function

    Public Function GenerarListaCombo(ByVal Lista As String) As String
        Dim res As String = ""
        Try
            Dim NumElementos As Integer = CuentaCar(Lista, ","), Elemento As String = ""
            For NE As Integer = 0 To NumElementos
                Elemento = stiSplit(Lista, "G" & NE & ",1").Trim
                If res = "" Then
                    res = Replace(Elemento, " ", "_") & " " & Elemento
                Else
                    res &= "|" & Replace(Elemento, " ", "_") & " " & Elemento
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

#End Region

End Module
