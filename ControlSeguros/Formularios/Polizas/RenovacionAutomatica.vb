Imports Utilerias.Genericas

Public Class RenovacionAutomatica

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RenovacionAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Dim Td As DataTable = StiGlobalConn.ObtenerDataset("select IdProducto as Id, Descripcion as Producto from Productos order by Descripcion asc").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Producto"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TD
        RepositoryItemLookUpEdit1.PopulateColumns()


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtDesde.Text = "" And Me.txtHasta.Text = "" And Me.cboIdProducto.Text = "" Then
            MsgBox("Debe Especificar algún parámetro de búsqueda.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim sql As String = ""
        sql &= " select "
        sql &= " p.IdPoliza"
        sql &= " , p.IdProducto"
        sql &= " , p.NombreCliente as Asegurado"
        sql &= " , p.VigenciaDesde"
        sql &= " , p.VigenciaHasta"
        sql &= " , isnull((select sum(c.ValorAsegurado) from PolizasCertificados as c where c.RazonExclusion is null and c.idproducto = p.idproducto and c.idpoliza = p.idpoliza),0) as SumaAsegurada"
        sql &= " , isnull((select sum(c.Total) from PolizasCertificados as c where c.RazonExclusion is null and c.idproducto = p.idproducto and c.idpoliza = p.idpoliza),0) as TotalPrima"
        sql &= " , cast(0 as bit) as Incluir"

        sql &= " from Polizas as p "
        sql &= " where p.idpoliza is not null and p.MotivoCancelacion is null and p.FechaCancelacion is null"
        If cboIdProducto.Text <> "" Then
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
        End If
        If Me.txtDesde.Text <> "" Then
            sql &= " and p.VigenciaHasta >= " & dbFec(txtDesde.Valor)
        End If
        If Me.txtHasta.Text <> "" Then
            sql &= " and p.VigenciaHasta <= " & dbFec(txtHasta.Valor)
        End If
        Dim Datos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        If Datos.Rows.Count = 0 Then MsgBox("No se encontraron pólizas con los parámetros de búsqueda.", MsgBoxStyle.Information, "AVISO...")
        GridDatos.DataSource = Datos
        GridDatos.Refresh()

    End Sub

    Private Sub VistaPolizas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPolizas.Click
        Try
            Dim p As Point = VistaPolizas.GridControl.PointToClient(MousePosition)
            Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = VistaPolizas.CalcHitInfo(p)
            If info.Column.FieldName = "Incluir" Then
                Me.Cursor = Cursors.WaitCursor
                Dim Valor1 As Boolean = VistaPolizas.GetRowCellValue(0, "Incluir")
                Valor1 = Not Valor1
                For NF As Integer = 0 To Me.VistaPolizas.RowCount - 1
                    If NF Mod 25 = 0 Then Application.DoEvents()
                    VistaPolizas.SetRowCellValue(NF, "Incluir", Valor1)
                Next
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim NumPolizas As Integer = 0
        For I As Integer = 0 To Me.VistaPolizas.RowCount - 1
            If Me.VistaPolizas.GetRowCellValue(I, "Incluir") = True Then
                NumPolizas += 1
            End If
        Next

        If NumPolizas = 0 Then
            MsgBox("Debe marcar las pólizas que desea renovar y facturar automáticamente.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Confirma la renovación de las Pólizas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim Res As String = "", sql As String = ""
        Dim IdPoliza As String = ""
        Dim IdProducto As String = ""
        Try
            Me.Cursor = Cursors.WaitCursor
            btnGuardar.Enabled = False
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
            For I As Integer = 0 To Me.VistaPolizas.RowCount - 1
                Application.DoEvents()
                If Me.VistaPolizas.GetRowCellValue(I, "Incluir") = True Then
                    IdPoliza = Me.VistaPolizas.GetRowCellValue(I, "IdPoliza")
                    IdProducto = Me.VistaPolizas.GetRowCellValue(I, "IdProducto")

                    'primero haremos una copia de la poliza actual al historico
                    Dim msgHistocio As String = clSeguros.RegistrarHistorioPoliza(IdPoliza, IdProducto)
                    If msgHistocio <> "" Then Throw New Exception(" Error al registrar historico Póliza " & IdPoliza & ": " & msgHistocio)

                    'primero Actualizamos la póliza
                    StiGlobalConn.SQLExecute("update polizas set VigenciaDesde = VigenciaHasta, VigenciaHasta = dateadd(yy,1,VigenciaHasta) , NumVigencia = NumVigencia + 1, ObservacionSiniestro = null where IdPoliza =  " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto))

                    'ahora los certificados
                    StiGlobalConn.SQLExecute("update PolizasCertificados set VigenciaDesde = VigenciaHasta, VigenciaHasta =  dateadd(yy,1,VigenciaHasta)  where IdPoliza =  " & dbStr(IdPoliza) & " and IdProducto = " & dbStr(IdProducto) & " and RazonExclusion is null")

                    Dim msgflujo As String = clFlujos.IniciarFlujoRenovacionPoliza(IdPoliza, IdProducto)
                    'If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")

                    'RECALCULAMOS LAS PRIMAS
                    Res = RecalcularPrimasPoliza(IdPoliza, IdProducto, "")
                    If Res <> "" Then Throw New Exception(Res)

                    'Ahora Facturamos la renovacion
                    'determinaremos la forma de pago y la prima y emitiremos un aviso de cobro
                    Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select IdCliente,NombreCliente, VigenciaDesde,VigenciaHasta, isnull(PorceComision, isnull((select top 1 PorceComi from ProductosComisionesExternas where ProductosComisionesExternas.idproducto = Polizas.idproducto order by IdComision asc),0) ) as PorceComision from Polizas where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0)
                    Dim IdAvisoCobro As String = clSeguros.ObtenerID("AvisoCobro.Numero." & Date.Today.Year) & "-" & Date.Today.Year
                    Dim FilProducto As DataRow = StiGlobalConn.ObtenerDataset("select IdRamo from Productos where idproducto = " & dbStr(IdProducto)).Tables(0).Rows(0)
                    Dim NumFactIni As Integer = StiGlobalConn.ObtenerDataset("select isnull(max(NumeroFactura) + 1 ,1) from Facturas where IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)

                    Dim NumAvisos As Integer = StiGlobalConn.ObtenerDataset("select count(*) from AvisosCobro where IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0).Item(0)
                    Dim FilAC As DataRow
                    If NumAvisos = 0 Then
                        FilAC = StiGlobalConn.ObtenerDataset("select 'F' as TipoDocumento, isnull( (select IdFormaPago from Polizas where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " ) ,'1') as IdFormaPago, '' as NumeroTarjeta, '' as TarjetaHabiente, '' as VencimientoTarjeta, '' as CuentaBancaria, '' as NombreCuentaHabiente, '' as IdBanco, '' as AplicarRetencionIva, isnull((select sum(PrimaNeta) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as PrimaTotal, isnull((select sum(GastosEmi) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosEmi, isnull((select sum(GastosFrac) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosFin, isnull((select sum(GastosBomb) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosBomb, isnull((select sum(GastosOtros) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosOtros  ").Tables(0).Rows(0)
                    Else
                        FilAC = StiGlobalConn.ObtenerDataset("select top 1 TipoDocumento, IdFormaPago, NumeroTarjeta, TarjetaHabiente, VencimientoTarjeta, CuentaBancaria, NombreCuentaHabiente, IdBanco, AplicarRetencionIva, isnull((select sum(PrimaNeta) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as PrimaTotal, isnull((select sum(GastosEmi) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosEmi, isnull((select sum(GastosFrac) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosFin, isnull((select sum(GastosBomb) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosBomb, isnull((select sum(GastosOtros) from PolizasCertificados where EstadoCertificado = 'VIGENTE' and RazonExclusion is null and idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & "),0) as GastosOtros  from AvisosCobro where IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(IdPoliza) & " order by VigenciaDesde desc").Tables(0).Rows(0)
                    End If

                    sql = "  insert into AvisosCobro"
                    sql &= " (IdAvisoCobro, IdPoliza, IdProducto, IdCliente, PorceComision, "
                    sql &= " NombreCliente, VigenciaDesde, VigenciaHasta, TipoDocumento, IdAnexo,"
                    sql &= " IdFormaPago, PrimaTotal,  Referencia, Observaciones, NumeroTarjeta, TarjetaHabiente, VencimientoTarjeta, NumFacturaInicial, IdRamo, AvisoInterno, FechaGrabacion, FechaInicialPago, AplicarRetencionIva, FechaNotificacion, UsuarioGrabacion, PrimaExenta, IdContacto, CuentaBancaria, NombreCuentaHabiente, IdBanco) values("
                    sql &= dbStr(IdAvisoCobro) & C & dbStr(IdPoliza) & C & dbStr(IdProducto) & C & dbStr(dbData(FilPol, "IdCliente")) & C & dbNum(dbData(FilPol, "PorceComision")) & C
                    sql &= dbStr(dbData(FilPol, "NombreCliente")) & C & dbFec(dbData(FilPol, "VigenciaDesde")) & C & dbFec(dbData(FilPol, "VigenciaHasta")) & C & dbStr(dbData(FilAC, "TipoDocumento")) & C & dbStr("RENOVACION") & C
                    sql &= dbStr(dbData(FilAC, "IdFormaPago")) & C & dbNum(dbData(FilAC, "PrimaTotal")) & C & dbStr("RE") & C & dbStr("") & C & dbStr(dbData(FilAC, "NumeroTarjeta")) & C & dbStr(dbData(FilAC, "TarjetaHabiente")) & C & dbStr(dbData(FilAC, "VencimientoTarjeta")) & C & dbInt(NumFactIni) & C & dbStr(dbData(FilProducto, "IdRamo")) & C & dbStr("") & C & dbFec(Date.Now, "1") & C & dbFec(dbData(FilPol, "VigenciaDesde")) & C & dbStr(dbData(FilAC, "AplicarRetencionIva"), 1) & C & dbFec("") & C & dbStr(StiGlobalConn.User, 25) & C & dbNum(0) & C & dbInt("") & C & dbStr(dbData(FilAC, "CuentaBancaria")) & C & dbStr(dbData(FilAC, "NombreCuentaHabiente")) & C & dbStr(dbData(FilAC, "IdBanco")) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    Dim DtFacturas As DataSet = ActualizarFacturacion(dbData(FilAC, "PrimaTotal"), dbData(FilPol, "VigenciaDesde"), NumFactIni, dbData(FilPol, "PorceComision"), dbData(FilPol, "IdCliente"), dbData(FilAC, "TipoDocumento"), dbData(FilAC, "IdFormaPago"), IdProducto, dbData(FilAC, "AplicarRetencionIva"), dbData(FilAC, "GastosEmi"), dbData(FilAC, "GastosFin"), dbData(FilAC, "GastosBomb"), dbData(FilAC, "GastosOtros"))

                    ''ahora la referencia de las facturas que se generaran
                    For NF As Integer = 0 To DtFacturas.Tables("Cuotas").Rows.Count - 1
                        sql = "  insert into AvisosCobroFacturas"
                        sql &= " (IdAvisoCobro, IdPoliza, IdProducto, NumeroFactura, IdRamo) values("
                        sql &= dbStr(IdAvisoCobro) & C & dbStr(IdPoliza) & C & dbStr(IdProducto) & C & dbInt(DtFacturas.Tables("Cuotas").Rows(NF).Item("NumFactura")) & C & dbStr(dbData(FilProducto, "IdRamo")) & ") "
                        StiGlobalConn.SQLExecute(sql)

                        Res = Cartera_AgregarFactura(DtFacturas.Tables("Cuotas").Rows(NF).Item("NumFactura"), IdProducto, IdPoliza, dbData(FilAC, "TipoDocumento"), "RENOVACION", dbData(FilPol, "IdCliente"), dbData(FilPol, "NombreCliente"), Date.Today, DtFacturas.Tables("Cuotas").Rows(NF).Item("FechaPago"), dbData(FilPol, "VigenciaDesde"), dbData(FilPol, "VigenciaHasta"), NF + 1, DtFacturas.Tables("Cuotas").Rows.Count, DtFacturas.Tables("Cuotas").Rows(NF).Item("Prima"), DtFacturas.Tables("Cuotas").Rows(NF).Item("GastosEmision"), DtFacturas.Tables("Cuotas").Rows(NF).Item("GastosFracciona"), DtFacturas.Tables("Cuotas").Rows(NF).Item("GastosBomberos"), DtFacturas.Tables("Cuotas").Rows(NF).Item("Gastos"), DtFacturas.Tables("Cuotas").Rows(NF).Item("Impuestos"), DtFacturas.Tables("Cuotas").Rows(NF).Item("Total"), DtFacturas.Tables("Cuotas").Rows(NF).Item("Comision"), "RE", "", dbData(FilPol, "PorceComision"), dbData(FilProducto, "IdRamo"), DtFacturas.Tables("Cuotas").Rows(NF).Item("RetencionImpuestos"), dbData(FilAC, "AplicarRetencionIva"), DtFacturas.Tables("Cuotas").Rows(NF).Item("VencimientoTardio"), DtFacturas.Tables("Cuotas").Rows(NF).Item("PrimaExenta"))

                    Next
                    'ahora guardamos los gastos
                    For NG As Integer = 0 To DtFacturas.Tables("Gastos").Rows.Count - 1
                        sql = "  insert into AvisosCobroGastos"
                        sql &= " (IdAvisoCobro, IdGasto, ValorGasto, FormaCobro) values("
                        sql &= dbStr(IdAvisoCobro) & C & dbStr(DtFacturas.Tables("Gastos").Rows(NG).Item("IdGasto")) & C & dbNum(DtFacturas.Tables("Gastos").Rows(NG).Item("Valor")) & C & dbStr(DtFacturas.Tables("Gastos").Rows(NG).Item("FormaPago"), 1) & ") "
                        StiGlobalConn.SQLExecute(sql)
                    Next

                End If
            Next


            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("Las pólizas, Certificado(s) han sido renovados con éxito.", MsgBoxStyle.Information, "AVISO...")
            Me.LimpiarCampos(Me)
            Me.GridDatos.DataSource = Nothing
            Me.GridDatos.Refresh()

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
            btnGuardar.Enabled = True
        End Try
    End Sub

    Private Function ActualizarFacturacion(ByVal Prima As Double, ByVal VigenciaDesde As DateTime, ByVal FactInicial As Integer, ByVal PoceComi As Double, ByVal IdCliente As String, ByVal TipoFactura As String, ByVal FormaPago As String, ByVal IdProducto As String, ByVal RetencionIva As String, ByVal GastoEmi As Double, ByVal GastoFin As Double, ByVal GastoBomb As Double, ByVal GastoOtros As Double) As DataSet
        Dim Res As New DataSet

        Dim dtFacturas As New DataTable
        dtFacturas.TableName = "Cuotas"
        dtFacturas.Columns.Add("NumFactura", System.Type.GetType("System.Int32"))
        dtFacturas.Columns.Add("FechaPago", System.Type.GetType("System.DateTime"))
        dtFacturas.Columns.Add("VencimientoTardio", System.Type.GetType("System.DateTime"))
        dtFacturas.Columns.Add("Prima", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("PrimaExenta", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("GastosEmision", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("GastosFracciona", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("GastosBomberos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Gastos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Comision", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Impuestos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("RetencionImpuestos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Total", System.Type.GetType("System.Double"))

        Dim DtGastos As DataTable = StiGlobalConn.ObtenerDataset("select p.IdGasto, g.FormaPago, 0.0 as Valor from productosgastos as p inner join TipoGastos as g on g.idGasto = p.IdGasto where p.idproducto = " & dbStr(IdProducto)).Tables(0)
        DtGastos.TableName = "Gastos"
        For I As Integer = 0 To DtGastos.Rows.Count - 1
            Select Case DtGastos.Rows(I).Item("IdGasto")
                Case "EMI"
                    If GastoEmi > 0 Then DtGastos.Rows(I).Item("Valor") = GastoEmi
                Case "FRAC"
                    If GastoFin > 0 Then DtGastos.Rows(I).Item("Valor") = GastoFin
                Case "BOMB"
                    If GastoBomb > 0 Then DtGastos.Rows(I).Item("Valor") = GastoBomb
                Case Else
                    If GastoOtros > 0 Then DtGastos.Rows(I).Item("Valor") = GastoOtros
            End Select
        Next
        DtGastos.AcceptChanges()

        Try
            Dim Gastos As Double = 0
            Dim PrimaExenta As Double = 0
            Dim Fecha As DateTime = VigenciaDesde, FechaOriginal As DateTime = VigenciaDesde


            Dim Fact As Integer = FactInicial, Comi As Double = PoceComi
            Dim NumCuotas As Integer = 0, Frecuencia As Integer = 0
            Dim TipoProducto As String = ""
            Dim PorceIva As Double = clSeguros.ObtenerDBParametros("Porce.Iva")
            Dim PorceRetencionIva As Double = clSeguros.ObtenerDBParametros("Porce.Ret.Iva")
            Dim intDiasTardios As Integer = 0

            Dim TipoCliente As String = ""
            Try
                TipoCliente = StiGlobalConn.ObtenerDataset("select idtipocliente from clientes where idcliente = " & dbStr(IdCliente)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoCliente = ""
            End Try

            If TipoCliente = "GU" Or TipoCliente = "JE" Or TipoFactura = "E" Then
                ''no se cobra iva al gobierno o empresas exentas
                ''tambien las facturas de exportación.
                PorceIva = 0
                PorceRetencionIva = 0
            End If

            Try
                Dim FilFP As DataRow = StiGlobalConn.ObtenerDataset("select NumeroCuotas, FrecuenciaPago from FormasPago where IdFormaPago = " & dbStr(FormaPago)).Tables(0).Rows(0)
                NumCuotas = dbData(FilFP, "NumeroCuotas")
                Frecuencia = dbData(FilFP, "FrecuenciaPago")
            Catch ex As Exception

            End Try
            Try
                TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(IdProducto)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoProducto = ""
            End Try

            Dim FilCuota As DataRow
            Dim PrimaN As Double = 0
            Dim Prima1 As Double = 0
            Dim PrimaExN As Double = 0
            Dim PrimaEx1 As Double = 0
            'si ya existe prime en la primera cuota que se propuso se calcula diferente
            'hay que respetar la prima de la primera cuota, las demas son iguales

            PrimaN = Math.Round(Prima / NumCuotas, 2)
            Prima1 = Math.Round(Prima - (PrimaN * (NumCuotas - 1)), 2)

            PrimaExN = Math.Round(PrimaExenta / NumCuotas, 2)
            PrimaEx1 = Math.Round(PrimaExenta - (PrimaExN * (NumCuotas - 1)), 2)


            Dim Gasto1 As Double = 0, GastoN As Double = 0
            intDiasTardios = 0

            For NC As Integer = 1 To NumCuotas
                FilCuota = dtFacturas.NewRow
                If NC = 1 Then
                    FilCuota("NumFactura") = Fact
                    FilCuota("FechaPago") = Fecha
                    FilCuota("VencimientoTardio") = Fecha.AddDays(intDiasTardios)
                    FilCuota("Prima") = Math.Round(Prima1, 2)
                    FilCuota("PrimaExenta") = Math.Round(PrimaEx1, 2)
                    FilCuota("GastosEmision") = 0 : FilCuota("GastosFracciona") = 0 : FilCuota("GastosBomberos") = 0 : FilCuota("Gastos") = 0
                    'buscaremos los gastos que aplique a la cuota 1 y fraccionados
                    For NG As Integer = 0 To DtGastos.Rows.Count - 1
                        Select Case DtGastos.Rows(NG).Item("FormaPago")
                            Case "P"
                                Select Case DtGastos.Rows(NG).Item("IdGasto")
                                    Case "EMI"
                                        FilCuota("GastosEmision") += Math.Round(DtGastos.Rows(NG).Item("Valor"), 2)
                                    Case "FRAC"
                                        FilCuota("GastosFracciona") += Math.Round(DtGastos.Rows(NG).Item("Valor"), 2)
                                    Case "BOMB"
                                        FilCuota("GastosBomberos") += Math.Round(DtGastos.Rows(NG).Item("Valor"), 2)
                                    Case Else
                                        FilCuota("Gastos") += Math.Round(DtGastos.Rows(NG).Item("Valor"), 2)
                                End Select

                            Case "F"
                                GastoN = Math.Round(DtGastos.Rows(NG).Item("Valor") / NumCuotas, 2)
                                Gasto1 = Math.Round(DtGastos.Rows(NG).Item("Valor") - (GastoN * (NumCuotas - 1)), 2)

                                Select Case DtGastos.Rows(NG).Item("IdGasto")
                                    Case "EMI"
                                        FilCuota("GastosEmision") += Gasto1
                                    Case "FRAC"
                                        FilCuota("GastosFracciona") += Gasto1
                                    Case "BOMB"
                                        FilCuota("GastosBomberos") += Gasto1
                                    Case Else
                                        FilCuota("Gastos") += Gasto1
                                End Select
                        End Select
                    Next
                Else
                    Fact += 1
                    FilCuota("NumFactura") = Fact
                    Fecha = FechaOriginal.AddMonths(Frecuencia * (NC - 1))
                    FilCuota("FechaPago") = Fecha
                    FilCuota("VencimientoTardio") = Fecha.AddDays(intDiasTardios)
                    FilCuota("Prima") = Math.Round(PrimaN, 2)
                    FilCuota("PrimaExenta") = Math.Round(PrimaExN, 2)
                    FilCuota("GastosEmision") = 0 : FilCuota("GastosFracciona") = 0 : FilCuota("GastosBomberos") = 0 : FilCuota("Gastos") = 0
                    'buscaremos los gastos que aplique a las cuotas fraccionados
                    For NG As Integer = 0 To DtGastos.Rows.Count - 1
                        Select Case DtGastos.Rows(NG).Item("FormaPago")
                            Case "F"
                                GastoN = Math.Round(DtGastos.Rows(NG).Item("Valor") / NumCuotas, 2)

                                Select Case DtGastos.Rows(NG).Item("IdGasto")
                                    Case "EMI"
                                        FilCuota("GastosEmision") += GastoN
                                    Case "FRAC"
                                        FilCuota("GastosFracciona") += GastoN
                                    Case "BOMB"
                                        FilCuota("GastosBomberos") += GastoN
                                    Case Else
                                        FilCuota("Gastos") += GastoN
                                End Select
                        End Select
                    Next
                End If
                FilCuota("Comision") = Math.Round(Val(FilCuota("Prima")) * (Comi / 100), 2)
                If TipoProducto = "VIDA" Then
                    FilCuota("Impuestos") = Math.Round((Val(FilCuota("GastosEmision")) + Val(FilCuota("GastosFracciona")) + Val(FilCuota("GastosBomberos")) + Val(FilCuota("Gastos"))) * (PorceIva / 100), 2, MidpointRounding.AwayFromZero)
                Else
                    FilCuota("Impuestos") = Math.Round((Val(FilCuota("Prima")) - Val(FilCuota("PrimaExenta")) + Val(FilCuota("GastosEmision")) + Val(FilCuota("GastosFracciona")) + Val(FilCuota("GastosBomberos")) + Val(FilCuota("Gastos"))) * (PorceIva / 100), 2, MidpointRounding.AwayFromZero)
                End If
                FilCuota("RetencionImpuestos") = 0.0
                If FilCuota("Impuestos") > 0 And RetencionIva.Trim.ToUpper = "S" Then
                    If TipoProducto = "VIDA" Then
                        FilCuota("RetencionImpuestos") = Math.Round((Val(FilCuota("GastosEmision")) + Val(FilCuota("GastosFracciona")) + Val(FilCuota("GastosBomberos")) + Val(FilCuota("Gastos"))) * (PorceRetencionIva / 100), 2, MidpointRounding.AwayFromZero)
                    Else
                        FilCuota("RetencionImpuestos") = Math.Round((Val(FilCuota("Prima")) - Val(FilCuota("PrimaExenta")) + Val(FilCuota("GastosEmision")) + Val(FilCuota("GastosFracciona")) + Val(FilCuota("GastosBomberos")) + Val(FilCuota("Gastos"))) * (PorceRetencionIva / 100), 2, MidpointRounding.AwayFromZero)
                    End If
                End If
                FilCuota("Total") = Math.Round(FilCuota("Prima") + FilCuota("GastosEmision") + FilCuota("GastosFracciona") + FilCuota("GastosBomberos") + FilCuota("Gastos") + FilCuota("Impuestos") - FilCuota("RetencionImpuestos"), 2)


                dtFacturas.Rows.Add(FilCuota)
                dtFacturas.AcceptChanges()
            Next

            Res.Tables.Add(dtFacturas.Copy)
            Res.Tables.Add(DtGastos.Copy)
            Res.AcceptChanges()


        Catch ex As Exception

        End Try

        Return Res
    End Function

End Class
