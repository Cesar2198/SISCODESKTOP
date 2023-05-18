Imports Utilerias.Genericas

Public Class FacturacionNR
    Dim dtFacturas As DataTable
    Dim ActualizandoCuotas As Boolean = False
    Dim CambiosHechos As Boolean = False

    Private Sub PrepararTabla()
        dtFacturas = New DataTable
        dtFacturas.TableName = "Facturas"
        dtFacturas.Columns.Add("NumFactura", System.Type.GetType("System.Int32"))
        dtFacturas.Columns.Add("FechaPago", System.Type.GetType("System.DateTime"))
        dtFacturas.Columns.Add("Prima", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("PrimaExenta", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("GastosEmision", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("GastosFracciona", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("GastosBomberos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Gastos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Impuestos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("RetencionImpuestos", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Total", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("Comision", System.Type.GetType("System.Double"))
        dtFacturas.Columns.Add("VencimientoTardio", System.Type.GetType("System.DateTime"))
    End Sub

    Private Sub Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PrepararTabla()
        Me.cboFormaPago.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboFormaPago.Llenar_Combo()

        Me.cboTipoFactura.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboTipoFactura.Llenar_Combo()

        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Me.cboIdRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdRamo.Llenar_Combo()

        Me.cboAvisoInterno.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboAvisoInterno.Llenar_Combo()

        Me.cboAplicarRetencionIva.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboAplicarRetencionIva.Llenar_Combo()

        Me.cboIdBanco.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdBanco.Llenar_Combo()

        Me.cboFlujo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboFlujo.Llenar_Combo()
        Try
            Dim Version As String = clSeguros.ObtenerVersion()
            Select Case Version
                Case "ESTANDAR", "DEMOPOL", "DEMOPOLCAR", "EMPCAJA"
                    Me.cboFlujo.Visible = False
            End Select
        Catch ex As Exception

        End Try


        Dim TG As DataTable
        TG = StiGlobalConn.ObtenerDataset("select IdGasto as Id, NombreGasto from TipoGastos").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "NombreGasto"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TG
        RepositoryItemLookUpEdit1.PopulateColumns()

        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("FormaPago", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "P" : Fila("FormaPago") = "Primera Cuota" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "F" : Fila("FormaPago") = "Fraccionado" : FP.Rows.Add(Fila)

        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "FormaPago"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = FP
        RepositoryItemLookUpEdit2.PopulateColumns()

        btnImprimir.Enabled = False
        btnEliminar.Enabled = False
        btnReactivar.Enabled = False

        txtIdAvisoCobro.SoloLectura = True
        Me.txtMotivoAnulacion.SoloLectura = True

        Me.EstadoRegistro = enEstadoRegistro.Adicionando

        If Me.dbCondicion <> "" Then
            'consultamos el aviso de cobro
            Try
                Me.blnCargandoRegistro = True
                Dim FilAC As DataRow = StiGlobalConn.ObtenerDataset("select * from AvisosCobro where " & Me.dbCondicion).Tables(0).Rows(0)
                'cargamos los datos en pantalla
                Me.txtIdAvisoCobro.Valor = dbData(FilAC, "IdAvisoCobro")
                Me.txtIdPoliza.Valor = dbData(FilAC, "IdPoliza")
                Me.cboIdProducto.Valor = dbData(FilAC, "IdProducto")
                Me.txtIdCliente.Valor = dbData(FilAC, "IdCliente")
                Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                Me.cboFlujo.Llenar_Combo()
                Me.txtPorceComision.Valor = dbData(FilAC, "PorceComision")
                Me.txtNombreCliente.Valor = dbData(FilAC, "NombreCliente")
                Me.txtVigenciaDesde.Valor = dbData(FilAC, "VigenciaDesde")
                Me.txtVigenciaHasta.Valor = dbData(FilAC, "VigenciaHasta")
                Me.cboTipoFactura.Valor = dbData(FilAC, "TipoDocumento")
                Me.txtIdAnexo.Valor = dbData(FilAC, "IdAnexo")
                Me.cboFormaPago.Valor = dbData(FilAC, "IdFormaPago")
                Me.txtPrima.Valor = dbData(FilAC, "PrimaTotal")
                Me.txtReferencia.Valor = dbData(FilAC, "Referencia")
                Me.txtObservaciones.Valor = dbData(FilAC, "Observaciones")
                Me.txtNumTarjeta.Valor = dbData(FilAC, "NumeroTarjeta")
                Me.txtNombreTarjeta.Valor = dbData(FilAC, "TarjetaHabiente")
                Me.txtVenceTarjeta.Valor = dbData(FilAC, "VencimientoTarjeta")
                Me.txtNumFacturaInicial.Valor = dbData(FilAC, "NumFacturaInicial")
                Me.cboIdRamo.Valor = dbData(FilAC, "IdRamo")
                Me.txtMotivoAnulacion.Valor = dbData(FilAC, "MotivoAnulacion")
                Me.cboAvisoInterno.Valor = dbData(FilAC, "AvisoInterno")
                Me.txtFechaInicialPago.Valor = dbData(FilAC, "FechaInicialPago")
                Me.cboAplicarRetencionIva.Valor = dbData(FilAC, "AplicarRetencionIva")
                Me.txtFechaNotificacion.Valor = dbData(FilAC, "FechaNotificacion")
                Me.txtUsuarioGrabacion.Valor = dbData(FilAC, "UsuarioGrabacion")
                Me.txtCuentaBancaria.Valor = dbData(FilAC, "CuentaBancaria")
                Me.txtNombreCuentaHabiente.Valor = dbData(FilAC, "NombreCuentaHabiente")
                Me.cboIdBanco.Valor = dbData(FilAC, "IdBanco")
                Me.cboFlujo.Valor = dbData(FilAC, "IdFlujoDoc")

                txtPSumaAsegurada.Valor = dbData(FilAC, "PSumaAsegurada") : txtPSumaAsegurada.SoloLectura = True
                txtPTarifa.Valor = dbData(FilAC, "PTarifa") : txtPTarifa.SoloLectura = True
                txtPPrima.Valor = dbData(FilAC, "PPrima") : txtPPrima.SoloLectura = True
                txtPPorceRent.Valor = dbData(FilAC, "PPorceRen") : txtPPorceRent.SoloLectura = True
                txtPDescuento.Valor = dbData(FilAC, "PDescuento") : txtPDescuento.SoloLectura = True
                txtPPrimaNeta.Valor = dbData(FilAC, "PPrimaNeta") : txtPPrimaNeta.SoloLectura = True
                txtComiCobranza.Valor = dbData(FilAC, "PComiCobranza") : txtComiCobranza.SoloLectura = True
                txtPPrimaPagar.Valor = dbData(FilAC, "PPrimaPagar") : txtPPrimaPagar.SoloLectura = True
                txtPPorceComi.Valor = dbData(FilAC, "PPorceComi") : txtPPorceComi.SoloLectura = True
                txtPComision.Valor = dbData(FilAC, "PComision") : txtPComision.SoloLectura = True
                txtPIva.Valor = dbData(FilAC, "PIva") : txtPIva.SoloLectura = True
                txtPSubTotal.Valor = dbData(FilAC, "PSubtotal") : txtPSubTotal.SoloLectura = True
                txtPRetIva.Valor = dbData(FilAC, "PRetIva") : txtPRetIva.SoloLectura = True
                txtPTotalCCF.Valor = dbData(FilAC, "PTotalCCF") : txtPTotalCCF.SoloLectura = True


                Call ActualizarContactos()
                Me.cboAtencionA.Valor = dbData(FilAC, "IdContacto")

                txtFechaInicialPago.Obligatorio = False

                'ahora completamos las facturas en el aviso de cobro
                Dim sql As String = ""
                sql = "  select "
                sql &= " f.NumeroFactura as NumFactura"
                sql &= " ,f.FechaPago as FechaPago"
                sql &= " ,f.VencimientoTardio as VencimientoTardio"
                sql &= " ,m.PrimaNeta as Prima"
                sql &= " ,m.GastosEmision"
                sql &= " ,m.GastosFracciona"
                sql &= " ,m.GastosBomberos"
                sql &= " ,m.Gastos as Gastos"
                sql &= " ,m.Impuestos as Impuestos"
                sql &= " ,m.Total as Total"
                sql &= " ,m.Comision as Comision"
                sql &= " ,m.RetencionImpuestos as RetencionImpuestos"
                sql &= " ,m.PrimaExenta as PrimaExenta"
                sql &= " from Facturas as f"
                sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and  f.IdPoliza = m.IdPoliza and f.idramo = m.idramo and m.IdMovimiento = 1"
                sql &= " inner join AvisosCobroFacturas as a on a.IdPoliza = f.IdPoliza and a.IdProducto = f.IdProducto and a.NumeroFactura = f.NumeroFactura and a.IdRamo = f.IdRamo "
                sql &= " where a.IdAvisoCobro = " & dbStr(dbData(FilAC, "IdAvisoCobro"))
                sql &= " order by f.NumCuota asc"
                Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridFacturas.DataSource = dtFacturas
                GridFacturas.Refresh()

                'ahora los gastos

                sql = "  select "
                sql &= " IdGasto"
                sql &= " ,ValorGasto as Valor"
                sql &= " ,FormaCobro as FormaPago"
                sql &= " from AvisosCobroGastos"
                sql &= " where IdAvisoCobro = " & dbStr(dbData(FilAC, "IdAvisoCobro"))
                Dim dtGastos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridGastos.DataSource = dtGastos
                GridGastos.Refresh()
                VistaGastos.OptionsBehavior.Editable = False

                btnGuardar.Enabled = False

                Me.txtIdAvisoCobro.SoloLectura = True
                Me.EstadoRegistro = enEstadoRegistro.Modificando
                btnImprimir.Enabled = True
                btnEliminar.Enabled = True

                'deshabilitamos las entradas y solo permitimos cambiar unas cuantas
                Me.EstadoEntradas(False, Me)

                If Me.txtMotivoAnulacion.Text = "" Then
                    txtVigenciaDesde.SoloLectura = False
                    txtVigenciaHasta.SoloLectura = False
                    cboTipoFactura.SoloLectura = False
                    txtIdAnexo.SoloLectura = False
                    txtReferencia.SoloLectura = False
                    txtObservaciones.SoloLectura = False
                    txtNumTarjeta.SoloLectura = False
                    txtNombreTarjeta.SoloLectura = False
                    txtVenceTarjeta.SoloLectura = False
                    cboAvisoInterno.SoloLectura = False
                    txtIdCliente.SoloLectura = False
                    txtNombreCliente.SoloLectura = False
                    txtFechaInicialPago.SoloLectura = False
                    txtFechaNotificacion.SoloLectura = False
                    cboAplicarRetencionIva.SoloLectura = False
                    txtCuentaBancaria.SoloLectura = False
                    txtNombreCuentaHabiente.SoloLectura = False
                    cboIdBanco.SoloLectura = False
                    Me.cboFlujo.SoloLectura = False

                    btnGuardar.Enabled = True

                    btnGuardar.Text = "&Modificar Aviso Cobro"
                Else
                    btnEliminar.Enabled = False
                    btnImprimir.Enabled = False
                    Me.btnReactivar.Enabled = True

                    MsgBox("El aviso de cobro se encuentra anulado.", MsgBoxStyle.Information, "AVISO...")
                End If

            Catch ex As Exception
                msgError(ex)
            Finally
                Me.blnCargandoRegistro = False
            End Try
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtUsuarioGrabacion.Valor = StiGlobalConn.User
        End If

        Call ProcesarPermisosComision()
        Select Case Me.Permiso
            Case "L"
                Me.btnEliminar.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.EstadoEntradas(False, Me)
                Me.btnReactivar.Enabled = False

            Case "I"
                Me.btnEliminar.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnImprimir.Enabled = False
                Me.EstadoEntradas(False, Me)
                Me.btnReactivar.Enabled = False
        End Select

    End Sub

    Private Sub ActualizarFacturacion(Optional ByVal ModificoPrimaNeta As Boolean = False, Optional ByVal PrimaCuotaUnoPropuesta As Double = 0)
        dtFacturas.Clear()
        ActualizandoCuotas = True
        Try
            Dim Prima As Double = Me.txtPrima.Valor, Gastos As Double = 0
            Dim PrimaExenta As Double = txtPrimaExenta.Valor

            Dim Fecha As DateTime = txtFechaInicialPago.Valor, FechaOriginal As DateTime = txtFechaInicialPago.Valor

            If txtFechaInicialPago.Text = "" Then
                Fecha = txtVigenciaDesde.Valor
                FechaOriginal = txtVigenciaDesde.Valor
            End If

            Dim Fact As Integer = Val(Me.txtNumFacturaInicial.Valor), Comi As Double = Val(txtPorceComision.Valor)
            Dim NumCuotas As Integer = 0, Frecuencia As Integer = 0
            Dim TipoProducto As String = ""
            Dim PorceIva As Double = clSeguros.ObtenerDBParametros("Porce.Iva")
            Dim PorceRetencionIva As Double = clSeguros.ObtenerDBParametros("Porce.Ret.Iva")
            Dim intDiasTardios As Integer = 0

            Dim TipoCliente As String = ""
            Try
                TipoCliente = StiGlobalConn.ObtenerDataset("select idtipocliente from clientes where idcliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoCliente = ""
            End Try

            If TipoCliente = "GU" Or TipoCliente = "JE" Or cboTipoFactura.Valor = "E" Then
                ''no se cobra iva al gobierno o empresas exentas
                ''tambien las facturas de exportación.
                PorceIva = 0
                PorceRetencionIva = 0
            End If

            Try
                Dim FilFP As DataRow = StiGlobalConn.ObtenerDataset("select NumeroCuotas, FrecuenciaPago from FormasPago where IdFormaPago = " & dbStr(cboFormaPago.Valor)).Tables(0).Rows(0)
                NumCuotas = dbData(FilFP, "NumeroCuotas")
                Frecuencia = dbData(FilFP, "FrecuenciaPago")
            Catch ex As Exception

            End Try
            Try
                TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
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

            If PrimaCuotaUnoPropuesta = 0 Or ModificoPrimaNeta = True Then
                PrimaN = Math.Round(Prima / NumCuotas, 2)
                Prima1 = Math.Round(Prima - (PrimaN * (NumCuotas - 1)), 2)

                PrimaExN = Math.Round(PrimaExenta / NumCuotas, 2)
                PrimaEx1 = Math.Round(PrimaExenta - (PrimaExN * (NumCuotas - 1)), 2)
            Else
                Prima1 = Math.Round(PrimaCuotaUnoPropuesta, 2)
                PrimaN = Math.Round(((Prima - Prima1) / (NumCuotas - 1)), 2)

                PrimaExN = Math.Round(PrimaExenta / NumCuotas, 2)
                PrimaEx1 = Math.Round(PrimaExenta - (PrimaExN * (NumCuotas - 1)), 2)
            End If

            Dim Gasto1 As Double = 0, GastoN As Double = 0
            Try
                intDiasTardios = DateDiff(DateInterval.Day, FechaOriginal, txtFechaNotificacion.Valor)
            Catch ex As Exception
                intDiasTardios = 0
            End Try
            If intDiasTardios < 0 Then intDiasTardios = 0

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
                    For NG As Integer = 0 To VistaGastos.DataRowCount - 1
                        Select Case VistaGastos.GetRowCellValue(NG, "FormaPago")
                            Case "P"
                                Select Case VistaGastos.GetRowCellValue(NG, "IdGasto")
                                    Case "EMI"
                                        FilCuota("GastosEmision") += Math.Round(VistaGastos.GetRowCellValue(NG, "Valor"), 2)
                                    Case "FRAC"
                                        FilCuota("GastosFracciona") += Math.Round(VistaGastos.GetRowCellValue(NG, "Valor"), 2)
                                    Case "BOMB"
                                        FilCuota("GastosBomberos") += Math.Round(VistaGastos.GetRowCellValue(NG, "Valor"), 2)
                                    Case Else
                                        FilCuota("Gastos") += Math.Round(VistaGastos.GetRowCellValue(NG, "Valor"), 2)
                                End Select

                            Case "F"
                                GastoN = Math.Round(VistaGastos.GetRowCellValue(NG, "Valor") / NumCuotas, 2)
                                Gasto1 = Math.Round(VistaGastos.GetRowCellValue(NG, "Valor") - (GastoN * (NumCuotas - 1)), 2)

                                Select Case VistaGastos.GetRowCellValue(NG, "IdGasto")
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
                    For NG As Integer = 0 To VistaGastos.DataRowCount - 1
                        Select Case VistaGastos.GetRowCellValue(NG, "FormaPago")
                            Case "F"
                                GastoN = Math.Round(VistaGastos.GetRowCellValue(NG, "Valor") / NumCuotas, 2)

                                Select Case VistaGastos.GetRowCellValue(NG, "IdGasto")
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
                If FilCuota("Impuestos") > 0 And Me.cboAplicarRetencionIva.Valor = "S" Then
                    If TipoProducto = "VIDA" Then
                        FilCuota("RetencionImpuestos") = Math.Round((Val(FilCuota("GastosEmision")) + Val(FilCuota("GastosFracciona")) + Val(FilCuota("GastosBomberos")) + Val(FilCuota("Gastos"))) * (PorceRetencionIva / 100), 2, MidpointRounding.AwayFromZero)
                    Else
                        FilCuota("RetencionImpuestos") = Math.Round((Val(FilCuota("Prima")) - Val(FilCuota("PrimaExenta")) + Val(FilCuota("GastosEmision")) + Val(FilCuota("GastosFracciona")) + Val(FilCuota("GastosBomberos")) + Val(FilCuota("Gastos"))) * (PorceRetencionIva / 100), 2, MidpointRounding.AwayFromZero)
                    End If
                End If
                FilCuota("Total") = Math.Round(FilCuota("Prima") + FilCuota("GastosEmision") + FilCuota("GastosFracciona") + FilCuota("GastosBomberos") + FilCuota("Gastos") + FilCuota("Impuestos") - FilCuota("RetencionImpuestos"), 2)
                dtFacturas.Rows.Add(FilCuota)
            Next
        Catch ex As Exception

        End Try

        ActualizandoCuotas = False
        GridFacturas.DataSource = dtFacturas
        GridFacturas.Refresh()
    End Sub

    Private Sub ActualizarFacturacionModificacion(Optional ByVal ModificoPrimaNeta As Boolean = False, Optional ByVal PrimaCuotaUnoPropuesta As Double = 0)
        'no todos los datos se recalculan en las modificiaciones, se respetan los valores que envían la aseguradoras

        ActualizandoCuotas = True
        Try
            Dim Prima As Double = Me.txtPrima.Valor, Gastos As Double = 0
            Dim Fecha As DateTime = txtFechaInicialPago.Valor, FechaOriginal As DateTime = txtFechaInicialPago.Valor
            Dim TipoProducto As String = ""
            If txtFechaInicialPago.Text = "" Then
                Fecha = txtVigenciaDesde.Valor
                FechaOriginal = txtVigenciaDesde.Valor
            End If
            Dim PorceRetencionIva As Double = clSeguros.ObtenerDBParametros("Porce.Ret.Iva")
            Dim intDiasTardios As Integer = 0

            Dim TipoCliente As String = ""
            Try
                TipoCliente = StiGlobalConn.ObtenerDataset("select idtipocliente from clientes where idcliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoCliente = ""
            End Try

            If TipoCliente = "GU" Or TipoCliente = "JE" Or cboTipoFactura.Valor = "E" Then
                ''no se cobra iva al gobierno o empresas exentas
                ''tambien las facturas de exportación.
                PorceRetencionIva = 0
            End If
            Try
                TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoProducto = ""
            End Try

            Try
                intDiasTardios = DateDiff(DateInterval.Day, FechaOriginal, txtFechaNotificacion.Valor)
            Catch ex As Exception
                intDiasTardios = 0
            End Try
            If intDiasTardios < 0 Then intDiasTardios = 0

            For NC As Integer = 0 To Me.VistaFacturas.RowCount - 1
                Fecha = CDate(VistaFacturas.GetRowCellValue(NC, "FechaPago"))
                VistaFacturas.SetRowCellValue(NC, "VencimientoTardio", Fecha.AddDays(intDiasTardios))

                VistaFacturas.SetRowCellValue(NC, "RetencionImpuestos", CDbl(0))
                If VistaFacturas.GetRowCellValue(NC, "Impuestos") > 0 And cboAplicarRetencionIva.Valor = "S" Then
                    If TipoProducto = "VIDA" Then
                        VistaFacturas.SetRowCellValue(NC, "RetencionImpuestos", Math.Round((Val(VistaFacturas.GetRowCellValue(NC, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(NC, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(NC, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(NC, "Gastos"))) * (PorceRetencionIva / 100), 2))
                    Else
                        VistaFacturas.SetRowCellValue(NC, "RetencionImpuestos", Math.Round((Val(VistaFacturas.GetRowCellValue(NC, "Prima")) + Val(VistaFacturas.GetRowCellValue(NC, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(NC, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(NC, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(NC, "Gastos"))) * (PorceRetencionIva / 100), 2))
                    End If
                End If
                VistaFacturas.SetRowCellValue(NC, "Total", Math.Round(VistaFacturas.GetRowCellValue(NC, "Prima") + VistaFacturas.GetRowCellValue(NC, "GastosEmision") + VistaFacturas.GetRowCellValue(NC, "GastosFracciona") + VistaFacturas.GetRowCellValue(NC, "GastosBomberos") + VistaFacturas.GetRowCellValue(NC, "Gastos") + VistaFacturas.GetRowCellValue(NC, "Impuestos") - VistaFacturas.GetRowCellValue(NC, "RetencionImpuestos"), 2))
            Next
        Catch ex As Exception

        End Try

        ActualizandoCuotas = False
    End Sub

    Private Sub txtPorceComision_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPorceComision.ValueChangeOnExit
        Call ActualizarFacturacion()
    End Sub

    Private Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        Try
            If txtVigenciaHasta.Text = "" And txtVigenciaDesde.Text <> "" Then
                txtVigenciaHasta.Valor = CDate(txtVigenciaDesde.Valor).AddYears(1)
            End If
            If txtVigenciaDesde.Text <> "" Then
                Me.txtFechaInicialPago.Valor = Me.txtVigenciaDesde.Valor
            End If
            Call ActualizarFacturacion()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFormaPago_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboFormaPago.ValueChangeOnExit
        Call ActualizarFacturacion(True)
    End Sub

    Private Sub txtNumFacturaInicial_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtNumFacturaInicial.ValueChangeOnExit
        Call ActualizarFacturacion()
    End Sub

    Private Sub txtPrima_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPrima.ValueChangeOnExit
        Call ActualizarFacturacion(True)
    End Sub

    Private Sub txtPrimaExenta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPrimaExenta.ValueChangeOnExit
        Call ActualizarFacturacion(True)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Call NuevoAvisoCobro()
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
            Call ModificarAvisoCobro()
        End If
    End Sub

    Private Sub NuevoAvisoCobro()
        Dim Res As String

        'validamos los campos obligatorios
        Dim obligatorios As String = Me.ValidarCamposObligatorios(Me)
        If obligatorios <> "" Then
            MsgBox("Debe completar los campos obligatorios." & vbCrLf & obligatorios, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Val(txtPrima.Valor) <= 0 Then
            MsgBox("Debe especificar una prima válida.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'validaremos que ninguna factura este ingresada ya en el sistema
        Dim Existe As Integer = 0

        For NF As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
            Try
                Existe = StiGlobalConn.ObtenerDataset("select count(*) from facturas where IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdProducto = " & dbStr(Me.cboIdProducto.Valor) & " and NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(NF, "NumFactura")) & "  and IdRamo = " & dbStr(Me.cboIdRamo.Valor)).Tables(0).Rows(0).Item(0)
                If Existe > 0 Then
                    MsgBox("La factura No." & VistaFacturas.GetRowCellValue(NF, "NumFactura") & " que intenta ingresar ya existe en el sistema, verifique el número de factura, el número de la póliza, el producto y el ramo de la factura.", MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
        Next

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                'grabanos el aviso de cobro
                Try
                    Me.txtIdAvisoCobro.Valor = clSeguros.ObtenerID("AvisoCobro.Numero." & Date.Today.Year) & "-" & Date.Today.Year
                    Dim sql As String = ""
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    sql = "  insert into AvisosCobro"
                    sql &= " (IdAvisoCobro, IdPoliza, IdProducto, IdCliente, PorceComision, "
                    sql &= " NombreCliente, VigenciaDesde, VigenciaHasta, TipoDocumento, IdAnexo,"
                    sql &= " IdFormaPago, PrimaTotal,  Referencia, Observaciones, NumeroTarjeta, TarjetaHabiente, VencimientoTarjeta, NumFacturaInicial, IdRamo, AvisoInterno, FechaGrabacion, FechaInicialPago, AplicarRetencionIva, FechaNotificacion, UsuarioGrabacion, PrimaExenta, IdContacto, CuentaBancaria, NombreCuentaHabiente, IdBanco, IdFlujoDoc,PSumaAsegurada, PTarifa,PPrima, PPorceRen, PDescuento, PPrimaNeta, PComiCobranza, PPrimaPagar, PPorceComi, PComision, PIva, PSubtotal, PRetIva, PTotalCCF) values("
                    sql &= dbStr(Me.txtIdAvisoCobro.Valor) & C & dbStr(Me.txtIdPoliza.Valor) & C & dbStr(Me.cboIdProducto.Valor) & C & dbStr(Me.txtIdCliente.Valor) & C & dbNum(Me.txtPorceComision.Valor) & C
                    sql &= dbStr(Me.txtNombreCliente.Valor) & C & dbFec(Me.txtVigenciaDesde.Valor) & C & dbFec(Me.txtVigenciaHasta.Valor) & C & dbStr(Me.cboTipoFactura.Valor) & C & dbStr(Me.txtIdAnexo.Valor) & C
                    sql &= dbStr(Me.cboFormaPago.Valor) & C & dbNum(Me.txtPrima.Valor) & C & dbStr(Me.txtReferencia.Valor) & C & dbStr(Me.txtObservaciones.Valor) & C & dbStr(Me.txtNumTarjeta.Valor) & C & dbStr(Me.txtNombreTarjeta.Valor) & C & dbStr(Me.txtVenceTarjeta.Valor) & C & dbInt(Me.txtNumFacturaInicial.Valor) & C & dbStr(cboIdRamo.Valor) & C & dbStr(cboAvisoInterno.Valor, 1) & C & dbFec(Date.Now, "1") & C & dbFec(txtFechaInicialPago.Valor) & C & dbStr(cboAplicarRetencionIva.Valor, 1) & C & dbFec(txtFechaNotificacion.Valor) & C & dbStr(StiGlobalConn.User, 25) & C & dbNum(txtPrimaExenta.Valor) & C & dbInt(cboAtencionA.Valor) & C & dbStr(txtCuentaBancaria.Valor) & C & dbStr(txtNombreCuentaHabiente.Valor) & C & dbStr(Me.cboIdBanco.Valor) & C & dbStr(Me.cboFlujo.Valor, 25) & C & dbNum(txtPSumaAsegurada.Valor) & C & dbNum(txtPTarifa.Valor) & C & dbNum(txtPPrima.Valor) & C & dbNum(txtPPorceRent.Valor) & C & dbNum(txtPDescuento.Valor) & C & dbNum(txtPPrimaNeta.Valor) & C & dbNum(txtComiCobranza.Valor) & C & dbNum(txtPPrimaPagar.Valor) & C & dbNum(txtPPorceComi.Valor) & C & dbNum(txtPComision.Valor) & C & dbNum(txtPIva.Valor) & C & dbNum(txtPSubTotal.Valor) & C & dbNum(txtPRetIva.Valor) & C & dbNum(txtPTotalCCF.Valor) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    ''ahora la referencia de las facturas que se generaran
                    For NF As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                        sql = "  insert into AvisosCobroFacturas"
                        sql &= " (IdAvisoCobro, IdPoliza, IdProducto, NumeroFactura, IdRamo) values("
                        sql &= dbStr(Me.txtIdAvisoCobro.Valor) & C & dbStr(Me.txtIdPoliza.Valor) & C & dbStr(Me.cboIdProducto.Valor) & C & dbInt(VistaFacturas.GetRowCellValue(NF, "NumFactura")) & C & dbStr(cboIdRamo.Valor) & ") "
                        StiGlobalConn.SQLExecute(sql)

                        Res = Cartera_AgregarFactura(VistaFacturas.GetRowCellValue(NF, "NumFactura"), Me.cboIdProducto.Valor, Me.txtIdPoliza.Valor, Me.cboTipoFactura.Valor, Me.txtIdAnexo.Valor, Me.txtIdCliente.Valor, Me.txtNombreCliente.Valor, Date.Today, VistaFacturas.GetRowCellValue(NF, "FechaPago"), Me.txtVigenciaDesde.Valor, Me.txtVigenciaHasta.Valor, NF + 1, VistaFacturas.RowCount, VistaFacturas.GetRowCellValue(NF, "Prima"), VistaFacturas.GetRowCellValue(NF, "GastosEmision"), VistaFacturas.GetRowCellValue(NF, "GastosFracciona"), VistaFacturas.GetRowCellValue(NF, "GastosBomberos"), VistaFacturas.GetRowCellValue(NF, "Gastos"), VistaFacturas.GetRowCellValue(NF, "Impuestos"), VistaFacturas.GetRowCellValue(NF, "Total"), VistaFacturas.GetRowCellValue(NF, "Comision"), Me.txtReferencia.Valor, Me.txtObservaciones.Valor, txtPorceComision.Valor, Me.cboIdRamo.Valor, VistaFacturas.GetRowCellValue(NF, "RetencionImpuestos"), cboAplicarRetencionIva.Valor, VistaFacturas.GetRowCellValue(NF, "VencimientoTardio"), VistaFacturas.GetRowCellValue(NF, "PrimaExenta"))
                    Next
                    'ahora guardamos los gastos
                    For NG As Integer = 0 To Me.VistaGastos.DataRowCount - 1
                        sql = "  insert into AvisosCobroGastos"
                        sql &= " (IdAvisoCobro, IdGasto, ValorGasto, FormaCobro) values("
                        sql &= dbStr(Me.txtIdAvisoCobro.Valor) & C & dbStr(VistaGastos.GetRowCellValue(NG, "IdGasto")) & C & dbNum(VistaGastos.GetRowCellValue(NG, "Valor")) & C & dbStr(VistaGastos.GetRowCellValue(NG, "FormaPago"), 1) & ") "
                        StiGlobalConn.SQLExecute(sql)
                    Next

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

                    Call btnImprimir_Click(Nothing, Nothing)

                    MsgBox("La Facturación ha finalizado.", MsgBoxStyle.Information, "AVISO...")

                    Call LimpiarCampos(Me)
                    Me.blnRegistroModificado = False
                    Me.blnCambiosRealizados = True
                    Me.EstadoRegistro = enEstadoRegistro.Adicionando
                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    msgError(ex)
                End Try

        End Select
    End Sub

    Private Sub ModificarAvisoCobro()
        Dim Res As String = ""

        'validamos los campos obligatorios
        Dim obligatorios As String = Me.ValidarCamposObligatorios(Me)
        If obligatorios <> "" Then
            MsgBox("Debe completar los campos obligatorios." & vbCrLf & obligatorios, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Modificando
                'Actualizamos el aviso de cobro
                Try
                    Dim sql As String = ""
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    sql = "  update AvisosCobro set "
                    sql &= " VigenciaDesde = " & dbFec(Me.txtVigenciaDesde.Valor)
                    sql &= " ,VigenciaHasta = " & dbFec(Me.txtVigenciaHasta.Valor)
                    sql &= " ,TipoDocumento = " & dbStr(Me.cboTipoFactura.Valor)
                    sql &= " ,IdAnexo = " & dbStr(Me.txtIdAnexo.Valor)
                    sql &= " ,Referencia = " & dbStr(Me.txtReferencia.Valor)
                    sql &= " ,Observaciones = " & dbStr(Me.txtObservaciones.Valor)
                    sql &= " ,NumeroTarjeta = " & dbStr(Me.txtNumTarjeta.Valor)
                    sql &= " ,TarjetaHabiente = " & dbStr(Me.txtNombreTarjeta.Valor)
                    sql &= " ,VencimientoTarjeta = " & dbStr(Me.txtVenceTarjeta.Valor)
                    sql &= " ,AvisoInterno = " & dbStr(cboAvisoInterno.Valor, 1)
                    sql &= " ,IdCliente = " & dbStr(Me.txtIdCliente.Valor, 25)
                    sql &= " ,AplicarRetencionIva = " & dbStr(Me.cboAplicarRetencionIva.Valor)
                    sql &= " ,NombreCliente = " & dbStr(Me.txtNombreCliente.Valor, 150)
                    sql &= ", FechaInicialPago = " & dbFec(Me.txtFechaInicialPago.Valor)
                    sql &= ", FechaNotificacion = " & dbFec(Me.txtFechaNotificacion.Valor)
                    sql &= ", UsuarioGrabacion = " & dbStr(StiGlobalConn.User, 25)
                    sql &= ", IdContacto = " & dbInt(Me.cboAtencionA.Valor)
                    sql &= ", CuentaBancaria = " & dbStr(Me.txtCuentaBancaria.Valor)
                    sql &= ", NombreCuentaHabiente = " & dbStr(Me.txtNombreCuentaHabiente.Valor)
                    sql &= ", IdFlujoDoc = " & dbStr(Me.cboFlujo.Valor, 25)
                    sql &= ", IdBanco = " & dbStr(Me.cboIdBanco.Valor)

                    If clSeguros.ObtenerDBParametros("AvisoCobro.ActualizaFecha") = "S" Then
                        sql &= ", FechaGrabacion = " & dbFec(Date.Now, "1")
                    End If

                    sql &= " where IdAvisoCobro = " & dbStr(Me.txtIdAvisoCobro.Valor)
                    StiGlobalConn.SQLExecute(sql)

                    ''ahora la referencia de las facturas que se generaran
                    For NF As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                        sql = "  update Facturas set "
                        sql &= " TipoFactura = " & dbStr(Me.cboTipoFactura.Valor, 1)
                        sql &= " ,IdAnexo = " & dbStr(Me.txtIdAnexo.Valor, 25)
                        sql &= " ,VigenciaDesde = " & dbFec(Me.txtVigenciaDesde.Valor)
                        sql &= " ,VigenciaHasta = " & dbFec(Me.txtVigenciaHasta.Valor)
                        sql &= " ,Referencia = " & dbStr(Me.txtReferencia.Valor)
                        sql &= " ,Observaciones = " & dbStr(Me.txtObservaciones.Valor)
                        sql &= " ,IdCliente = " & dbStr(Me.txtIdCliente.Valor, 25)
                        sql &= " ,NombreCliente = " & dbStr(Me.txtNombreCliente.Valor, 150)
                        sql &= " ,FechaPago = " & dbFec(VistaFacturas.GetRowCellValue(NF, "FechaPago"))
                        sql &= " ,VencimientoTardio = " & dbFec(VistaFacturas.GetRowCellValue(NF, "VencimientoTardio"))
                        sql &= " where NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(NF, "NumFactura")) & " and IdProducto = " & dbStr(Me.cboIdProducto.Valor) & " and IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdRamo = " & dbStr(Me.cboIdRamo.Valor)
                        StiGlobalConn.SQLExecute(sql)

                        'actualizaremos los valores de la factura, lo único que se puede modificar el 
                        'la retencion del iva y el total
                        sql = "  update FacturasMovimientos set "
                        sql &= " RetencionImpuestos = " & dbNum(VistaFacturas.GetRowCellValue(NF, "RetencionImpuestos"))
                        sql &= " ,Total = " & dbNum(VistaFacturas.GetRowCellValue(NF, "Total"))
                        sql &= " where NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(NF, "NumFactura")) & " and IdProducto = " & dbStr(Me.cboIdProducto.Valor) & " and IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdRamo = " & dbStr(Me.cboIdRamo.Valor) & " and IdMovimiento = 1"
                        StiGlobalConn.SQLExecute(sql)
                    Next

                    Try
                        sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
                        sql &= dbStr(STIConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr("M", 1) & C & dbStr("AvisosCobro", 25) & C & dbStr("Modificación IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor), 150) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    Catch ex As Exception
                        'no controlaremos este error
                    End Try

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                    MsgBox("El Aviso de cobro ha sido actualizado.", MsgBoxStyle.Information, "AVISO...")
                    CambiosHechos = True
                    Me.blnCambiosRealizados = True
                    Me.blnRegistroModificado = False
                    Me.EstadoRegistro = enEstadoRegistro.Modificando

                Catch ex As Exception
                    StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
                    msgError(ex)
                End Try

        End Select

    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdProducto.ValueChangeOnExit
        Call CargarGastosProducto(cboIdProducto.Valor)
        Call ActualizarFacturacion()
        'proponemos la comisión
        Try
            Dim Fila As DataRow = StiGlobalConn.ObtenerDataset("select p.IdRamo, isnull((select top 1 c.PorceComi from ProductosComisionesExternas as c where c.idproducto = p.idproducto order by c.IdComision asc),0) as Comision from Productos as p where p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0)
            Me.cboIdRamo.Valor = dbData(Fila, "IdRamo")

            'si la póliza está registrada obtenemos la comisión de la póliza
            Dim ExistePol As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor)).Tables(0).Rows(0).Item(0)
            If ExistePol > 0 Then
                Dim PorceComi As Double = 0
                Try
                    PorceComi = StiGlobalConn.ObtenerDataset("select PorceComision from Polizas where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    PorceComi = 0
                End Try
                Me.txtPorceComision.Valor = PorceComi
            Else
                Me.txtPorceComision.Valor = dbData(Fila, "Comision")
            End If
        Catch ex As Exception

        End Try
        Me.btnBuscarCliente.Focus()

    End Sub

    Private Sub CargarGastosProducto(ByVal IdProducto As String)
        Try
            Dim dtGastos As DataTable
            dtGastos = StiGlobalConn.ObtenerDataset("select g.IdGasto, 0.0 as Valor, T.FormaPago from Productos as p inner join ProductosGastos as g on p.idproducto = g.idproducto inner join TipoGastos as T on t.idgasto = g.idgasto where p.idproducto = " & dbStr(IdProducto)).Tables(0)
            GridGastos.DataSource = dtGastos
            GridGastos.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RepositoryItemTextEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.EditValueChanged
        Me.VistaGastos.PostEditor()
        Call ActualizarFacturacion()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset("select NombreCliente, isnull(RegistroFiscal,'') as RegistroFiscal, NumeroTarjeta,TarjetaHabiente,VencimientoTarjeta, CuentaBancaria, NombreCuentaHabiente, IdBanco from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")
                If dbData(FilClie, "RegistroFiscal") <> "" Then
                    cboTipoFactura.Valor = "C"
                Else
                    cboTipoFactura.Valor = "F"
                End If
                txtNumTarjeta.Valor = dbData(FilClie, "NumeroTarjeta")
                txtNombreTarjeta.Valor = dbData(FilClie, "TarjetaHabiente")
                txtVenceTarjeta.Valor = dbData(FilClie, "VencimientoTarjeta")

                Me.txtCuentaBancaria.Valor = dbData(FilClie, "CuentaBancaria")
                Me.txtNombreCuentaHabiente.Valor = dbData(FilClie, "NombreCuentaHabiente")
                Me.cboIdBanco.Valor = dbData(FilClie, "IdBanco")

                Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                Me.cboFlujo.Llenar_Combo()

                Call ActualizarContactos()
            Catch ex As Exception

            End Try
            Me.txtVigenciaDesde.Focus()
        End If
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.LimpiarCampos(Me)
        Me.EstadoEntradas(True, Me)
        Me.txtIdAvisoCobro.SoloLectura = True
        Me.txtMotivoAnulacion.SoloLectura = True
        btnEliminar.Enabled = False
        btnImprimir.Enabled = False
        Me.btnReactivar.Enabled = False
        btnGuardar.Enabled = True
        btnGuardar.Text = "&Generar Aviso Cobro"
        txtFechaInicialPago.Obligatorio = True

        txtPSumaAsegurada.SoloLectura = False
        txtPTarifa.SoloLectura = False
        txtPPorceRent.SoloLectura = False
        txtPPorceComi.SoloLectura = False

        Me.txtUsuarioGrabacion.Valor = StiGlobalConn.User

        Me.EstadoRegistro = enEstadoRegistro.Adicionando
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            'Generaremos la impresion del aviso de cobros
            If txtIdAvisoCobro.Text <> "" Then
                Dim Rutear As Boolean = False
                If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then Rutear = True
                If Me.EstadoRegistro = enEstadoRegistro.Modificando And CambiosHechos = True Then Rutear = True

                Dim idAtencion As String = cboAtencionA.Valor, NombreAtt As String = "", CargoAtt As String = ""
                If idAtencion <> "" Then
                    NombreAtt = cboAtencionA.ValorColumna("Nombre")
                    CargoAtt = cboAtencionA.ValorColumna("Cargo")
                End If

                Dim parFlujo As String = ""
                If Me.cboFlujo.Valor <> "" Then parFlujo = Me.cboFlujo.Valor

                Call ImprimirAvisoCobro(txtIdAvisoCobro.Text, chkImpPP.Checked, "", "", NombreAtt, CargoAtt, Rutear, parFlujo)
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaGastos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaGastos.CellValueChanged
        Me.VistaGastos.PostEditor()
        Me.VistaGastos.UpdateCurrentRow()
        Call ActualizarFacturacion()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtIdAvisoCobro.Text <> "" Then
            If MsgBox("¿Realmente desea Anular el Aviso de Cobro, se anularán las emisiones de las facturas relacionadas?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.Yes Then

                'pediremos el motivo de anulación.
                Dim Motivo As String = InputBox("Especifique el motivo de la anulación:", "MOTIVO...", "")
                If Trim(Motivo) = "" Then
                    MsgBox("Debe especificar un motivo para la anulación.", MsgBoxStyle.Exclamation, "AVISO...")
                    Exit Sub
                End If

                Dim sql As String = "", res As String = ""
                Try
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    '1) anularemos cada factura del aviso de cobro.

                    sql = "  select a.NumeroFactura,a.IdPoliza,a.IdProducto,a.IdRamo"
                    sql &= ",isnull((select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo),0) as Prima"
                    sql &= ",isnull((select sum(m.GastosEmision) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as GastosEmi"
                    sql &= ",isnull((select sum(m.GastosFracciona) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as GastosFin"
                    sql &= ",isnull((select sum(m.GastosBomberos) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as GastosBomb"
                    sql &= ",isnull((select sum(m.Gastos) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as GastosOtro"
                    sql &= ",isnull((select sum(m.Impuestos) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as Iva"
                    sql &= ",isnull((select sum(m.RetencionImpuestos) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as RetencionImpuestos"
                    sql &= ",isnull((select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as Total"
                    sql &= ",isnull((select sum(m.Comision) from FacturasMovimientos as m where m.NumeroFactura = a.NumeroFactura and m.IdProducto = a.IdProducto and m.IdPoliza = a.IdPoliza and m.idramo = a.idramo ),0) as Comision"
                    sql &= " from AvisosCobroFacturas as a where IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor)

                    Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    Dim FilaF As DataRow
                    For Each FilaF In dtFacturas.Rows
                        res = Cartera_AnularFactura(dbData(FilaF, "NumeroFactura"), dbData(FilaF, "IdPoliza"), dbData(FilaF, "IdProducto"), Date.Today, dbData(FilaF, "Prima"), dbData(FilaF, "GastosEmi"), dbData(FilaF, "GastosFin"), dbData(FilaF, "GastosBomb"), dbData(FilaF, "GastosOtro"), dbData(FilaF, "Iva"), dbData(FilaF, "Total"), dbData(FilaF, "Comision"), dbData(FilaF, "IdRamo"), Motivo, dbData(FilaF, "RetencionImpuestos"))
                    Next

                    '2) Anulamos el aviso de cobro
                    StiGlobalConn.SQLExecute("update AvisosCobro set MotivoAnulacion = " & dbStr(Motivo, 250) & " where IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor))

                    'ahora registramos en el log.
                    Try
                        sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
                        sql &= dbStr(STIConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr("E", 1) & C & dbStr("AvisosCobro", 25) & C & dbStr("Anulación IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor), 150) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    Catch ex As Exception
                        'no controlaremos este error
                    End Try

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                    Me.blnCambiosRealizados = True
                    Me.LimpiarCampos(Me)

                    MsgBox("El Aviso de cobro y sus facturas han sido anulados con éxito", MsgBoxStyle.Information, "AVISO...")

                    Me.Close()
                Catch ex As Exception
                    STIConn.SQLExecute("ROLLBACK TRANSACTION")
                    MsgBox("Error al anular el aviso de cobro, la operación ha sido cancelada." & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "ERROR...")
                End Try
            End If
        End If

    End Sub

    Private Sub cboTipoFactura_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboTipoFactura.ValueChangeOnExit
        Call ActualizarFacturacion()
    End Sub

    Private Sub VistaFacturas_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaFacturas.CellValueChanged
        If ActualizandoCuotas = True Then Exit Sub
        Me.VistaFacturas.PostEditor()
        Select Case e.Column.FieldName
            Case "Prima"
                If e.RowHandle = 0 Then
                    ActualizarFacturacion(PrimaCuotaUnoPropuesta:=e.Value)
                End If
                Call ActualizarComisionFilaFacturas(e.RowHandle)
                Call ActualizarIvaFilaFacturas(e.RowHandle)
            Case "PrimaExenta"
                Call ActualizarIvaFilaFacturas(e.RowHandle)
            Case "GastosEmision"
                Call ActualizarIvaFilaFacturas(e.RowHandle)
            Case "GastosFracciona"
                Call ActualizarIvaFilaFacturas(e.RowHandle)
            Case "GastosBomberos"
                Call ActualizarIvaFilaFacturas(e.RowHandle)
            Case "Gastos"
                Call ActualizarIvaFilaFacturas(e.RowHandle)
            Case "Impuestos", "RetencionImpuestos"
                Call ActualizarTotalFilaFacturas(e.RowHandle)
        End Select
        Me.VistaFacturas.UpdateCurrentRow()
    End Sub

    Private Sub ActualizarIvaFilaFacturas(ByVal Fila As Integer)
        Dim Iva As Double = 0, RetIva As Double = 0
        Try
            Dim TipoProducto As String = ""
            Try
                TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoProducto = ""
            End Try

            Dim PorceIva As Double = clSeguros.ObtenerDBParametros("Porce.Iva")
            Dim PorceRetencionIva As Double = clSeguros.ObtenerDBParametros("Porce.Ret.Iva")

            Dim TipoCliente As String = ""
            Try
                TipoCliente = StiGlobalConn.ObtenerDataset("select idtipocliente from clientes where idcliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                TipoCliente = ""
            End Try

            If TipoCliente = "GU" Or TipoCliente = "JE" Or cboTipoFactura.Valor = "E" Then
                ''no se cobra iva al gobierno o empresas exentas
                ''tambien las facturas de exportación.
                PorceIva = 0
                PorceRetencionIva = 0
            End If

            If TipoProducto = "VIDA" Then
                Iva = Math.Round((Val(VistaFacturas.GetRowCellValue(Fila, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(Fila, "Gastos"))) * (PorceIva / 100), 2, MidpointRounding.AwayFromZero)
            Else
                Iva = Math.Round((Val(VistaFacturas.GetRowCellValue(Fila, "Prima")) - Val(VistaFacturas.GetRowCellValue(Fila, "PrimaExenta")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(Fila, "Gastos"))) * (PorceIva / 100), 2, MidpointRounding.AwayFromZero)
            End If

            If Iva > 0 And Me.cboAplicarRetencionIva.Valor = "S" Then
                If TipoProducto = "VIDA" Then
                    RetIva = Math.Round((Val(VistaFacturas.GetRowCellValue(Fila, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(Fila, "Gastos"))) * (PorceRetencionIva / 100), 2, MidpointRounding.AwayFromZero)
                Else
                    RetIva = Math.Round((Val(VistaFacturas.GetRowCellValue(Fila, "Prima")) - Val(VistaFacturas.GetRowCellValue(Fila, "PrimaExenta")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(Fila, "Gastos"))) * (PorceRetencionIva / 100), 2, MidpointRounding.AwayFromZero)
                End If
            End If

            Me.VistaFacturas.SetRowCellValue(Fila, "Impuestos", Iva)
            Me.VistaFacturas.SetRowCellValue(Fila, "RetencionImpuestos", RetIva)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActualizarTotalFilaFacturas(ByVal Fila As Integer)
        Dim Total As Double = 0
        Try
            Total = Val(VistaFacturas.GetRowCellValue(Fila, "Prima")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(Fila, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(Fila, "Gastos")) + Val(VistaFacturas.GetRowCellValue(Fila, "Impuestos")) - Val(VistaFacturas.GetRowCellValue(Fila, "RetencionImpuestos"))
            Me.VistaFacturas.SetRowCellValue(Fila, "Total", Total)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ActualizarComisionFilaFacturas(ByVal Fila As Integer)
        Dim Total As Double = 0, Comi As Double = Val(txtPorceComision.Valor)
        Try
            Total = Math.Round(Val(VistaFacturas.GetRowCellValue(Fila, "Prima")) * (Comi / 100), 2)
            Me.VistaFacturas.SetRowCellValue(Fila, "Comision", Total)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = " and (p.MotivoCancelacion is null or p.EstadoPoliza = 'VIGENTE') "
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                Dim sql As String = ""

                sql = "  select p.IdPoliza, p.IdProducto, p.IdCliente, p.NombreCliente, p.VigenciaDesde, p.VigenciaHasta "
                sql &= " ,isnull(c.RegistroFiscal,'') as RegistroFiscal, isnull(p.NumeroTarjeta, c.NumeroTarjeta) as NumeroTarjeta"
                sql &= " ,isnull(p.TarjetaHabiente,c.TarjetaHabiente) as TarjetaHabiente, isnull(p.VencimientoTarjeta,c.VencimientoTarjeta) as VencimientoTarjeta"
                sql &= " ,p.IdFormaPago, isnull(p.CuentaBancaria, c.CuentaBancaria) as CuentaBancaria, isnull(p.NombreCuentaHabiente, c.NombreCuentaHabiente) as NombreCuentaHabiente"
                sql &= " , isnull(p.idbanco, c.idbanco) as idbanco"
                sql &= " from Polizas as p "
                sql &= " left join Clientes as c on c.idcliente = p.idcliente"
                sql &= " where p.IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and p.IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))

                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtIdPoliza.Valor = dbData(FilPol, "IdPoliza")
                cboIdProducto.Valor = dbData(FilPol, "IdProducto")
                txtIdCliente.Valor = dbData(FilPol, "IdCliente")
                txtNombreCliente.Valor = dbData(FilPol, "NombreCliente")
                txtVigenciaDesde.Valor = dbData(FilPol, "VigenciaDesde")
                txtVigenciaHasta.Valor = dbData(FilPol, "VigenciaHasta")
                txtFechaInicialPago.Valor = dbData(FilPol, "VigenciaDesde")
                If dbData(FilPol, "IdFormaPago") <> "" Then cboFormaPago.Valor = dbData(FilPol, "IdFormaPago")
                Call cboIdProducto_ValueChangeOnExit(Nothing, Nothing, "")
                If dbData(FilPol, "RegistroFiscal") <> "" Then
                    cboTipoFactura.Valor = "C"
                Else
                    cboTipoFactura.Valor = "F"
                End If

                txtNumTarjeta.Valor = dbData(FilPol, "NumeroTarjeta")
                txtNombreTarjeta.Valor = dbData(FilPol, "TarjetaHabiente")
                txtVenceTarjeta.Valor = dbData(FilPol, "VencimientoTarjeta")
                txtCuentaBancaria.Valor = dbData(FilPol, "CuentaBancaria")
                txtNombreCuentaHabiente.Valor = dbData(FilPol, "NombreCuentaHabiente")
                cboIdBanco.Valor = dbData(FilPol, "IdBanco")

                Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                Me.cboFlujo.Llenar_Combo()

                Call ActualizarContactos()

                'trataremos de proponer la prima y los gastos
                If MsgBox("¿Desea cargar las primas y gastos de la póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA") = MsgBoxResult.Yes Then
                    Try
                        sql = "  select "
                        sql &= " sum(isnull(PrimaNeta,0)) as Prima"
                        sql &= " ,sum(isnull(PrimaExenta,0)) as PrimaExenta"
                        sql &= " ,sum(isnull(GastosEmi,0)) as GastosE"
                        sql &= " ,sum(isnull(GastosFrac,0)) as GastosF"
                        sql &= " ,sum(isnull(GastosBomb,0)) as GastosB"
                        sql &= " ,sum(isnull(GastosOtros,0)) as GastosO"
                        sql &= " from PolizasCertificados "
                        sql &= " where IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))
                        sql &= " and EstadoCertificado = 'VIGENTE' and RazonExclusion is null"
                        Dim FilRes As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                        txtPrima.Valor = dbData(FilRes, "Prima")
                        txtPrimaExenta.Valor = dbData(FilRes, "PrimaExenta")
                        For I As Integer = 0 To Me.VistaGastos.DataRowCount - 1
                            Select Case VistaGastos.GetRowCellValue(I, "IdGasto")
                                Case "EMI"
                                    If Val(dbData(FilRes, "GastosE")) > 0 Then
                                        Me.VistaGastos.SetRowCellValue(I, "Valor", Val(dbData(FilRes, "GastosE")))
                                    End If
                                Case "FRAC"
                                    If Val(dbData(FilRes, "GastosF")) > 0 Then
                                        Me.VistaGastos.SetRowCellValue(I, "Valor", Val(dbData(FilRes, "GastosF")))
                                    End If
                                Case "BOMB"
                                    If Val(dbData(FilRes, "GastosB")) > 0 Then
                                        Me.VistaGastos.SetRowCellValue(I, "Valor", Val(dbData(FilRes, "GastosB")))
                                    End If
                                Case "OTRO"
                                    If Val(dbData(FilRes, "GastosO")) > 0 Then
                                        Me.VistaGastos.SetRowCellValue(I, "Valor", Val(dbData(FilRes, "GastosO")))
                                    End If
                            End Select
                        Next
                    Catch ex As Exception

                    End Try
                End If

                Me.txtVigenciaDesde.Focus()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                txtPorceComision.Visible = False
                FACol7.Visible = False
                FACol7.OptionsColumn.AllowShowHide = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtFechaInicialPago_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaInicialPago.ValueChangeOnExit
        Call ActualizarFacturacion()
    End Sub

    Private Sub cboAplicarRetencionIva_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboAplicarRetencionIva.ValueChangeOnExit
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Call ActualizarFacturacion(True)
        Else
            ActualizarFacturacionModificacion(True)
        End If
    End Sub

    Private Sub txtFechaNotificacion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaNotificacion.ValueChangeOnExit
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Call ActualizarFacturacion(True)
        Else
            ActualizarFacturacionModificacion(True)
        End If
    End Sub

    Private Sub VistaFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaFacturas.DoubleClick
        If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
            Dim FilFac As Integer = VistaFacturas.FocusedRowHandle
            If FilFac >= 0 Then
                Try
                    Dim NumeroFactura As Integer = Me.VistaFacturas.GetRowCellValue(FilFac, "NumFactura")
                    Dim IdProducto As String = Me.cboIdProducto.Valor
                    Dim IdPoliza As String = Me.txtIdPoliza.Valor
                    Dim IdRamo As String = Me.cboIdRamo.Valor
                    Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Facturas where NumeroFactura = " & dbInt(NumeroFactura) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(IdPoliza) & " and IdRamo = " & dbStr(IdRamo)).Tables(0).Rows(0).Item(0)
                    If Existe > 0 Then
                        Dim frmFactura As New PagosMan
                        frmFactura.dbTabla = "Facturas"
                        frmFactura.Permiso = Me.Permiso
                        frmFactura.dbCondicion = "NumeroFactura = " & dbInt(NumeroFactura) & " and IdProducto = " & dbStr(IdProducto) & " and IdPoliza = " & dbStr(IdPoliza) & " and IdRamo = " & dbStr(IdRamo)
                        frmFactura.STIConn = StiGlobalConn
                        If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
                            frmFactura.MdiParent = Me.MdiParent
                            frmFactura.Show()
                        Else
                            frmFactura.ShowDialog()
                        End If
                    Else
                        MsgBox("La factura seleccionada no existe.", MsgBoxStyle.Exclamation, "AVISO...")
                    End If
                Catch ex As Exception
                    msgError(ex)
                End Try
            End If
        End If

    End Sub

    Private Sub btnReactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReactivar.Click
        If txtIdAvisoCobro.Text <> "" Then
            If MsgBox("¿Realmente desea Reactivar el Aviso de Cobro Anulado?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.Yes Then
                Dim sql As String = "", res As String = ""
                Try
                    StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

                    '1) borraremos los movimientos de anulación de las facturas del AC
                    sql = "  select f.NumeroFactura, f.IdProducto, f.IdPoliza, f.IdRamo, f.IdMovimiento from AvisosCobroFacturas as a"
                    sql &= " inner join FacturasMovimientos as f on a.NumeroFactura = f.NumeroFactura and a.IdProducto = f.IdProducto and a.IdPoliza = f.IdPoliza and a.IdRamo = f.IdRamo"
                    sql &= " where a.IdAvisoCobro = " & dbStr(Me.txtIdAvisoCobro.Valor)
                    sql &= " and f.TipoMovimiento = 'ANULACION' "
                    Dim dtAnulaciones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    Dim filAnula As DataRow
                    For Each filAnula In dtAnulaciones.Rows
                        StiGlobalConn.SQLExecute("delete from FacturasMovimientos where NumeroFactura = " & dbInt(dbData(filAnula, "NumeroFactura")) & " and IdProducto = " & dbStr(dbData(filAnula, "IdProducto")) & " and IdPoliza = " & dbStr(dbData(filAnula, "IdPoliza")) & " and IdRamo = " & dbStr(dbData(filAnula, "IdRamo")) & " and IdMovimiento = " & dbInt(dbData(filAnula, "IdMovimiento")))

                        Try
                            sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
                            sql &= dbStr(STIConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr("E", 1) & C & dbStr("FacturasMovimientos", 25) & C & dbStr("Ractivación IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor) & ", Factura = " & dbInt(dbData(filAnula, "NumeroFactura")) & " , Mov. = " & dbInt(dbData(filAnula, "IdMovimiento")), 150) & ")"
                            StiGlobalConn.SQLExecute(sql)
                        Catch ex As Exception
                            'no controlaremos este error
                        End Try

                    Next

                    '2) Anulamos el aviso de cobro
                    StiGlobalConn.SQLExecute("update AvisosCobro set MotivoAnulacion = null where IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor))

                    'ahora registramos en el log.
                    Try
                        sql = "insert into Log (Usuario, Fecha, Accion, Tabla, Claves) values("
                        sql &= dbStr(STIConn.User, 25) & C & dbFec(Date.Now, "1") & C & dbStr("M", 1) & C & dbStr("AvisosCobro", 25) & C & dbStr("Reactivación IdAvisoCobro = " & dbStr(txtIdAvisoCobro.Valor), 150) & ")"
                        StiGlobalConn.SQLExecute(sql)
                    Catch ex As Exception
                        'no controlaremos este error
                    End Try

                    StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
                    Me.blnCambiosRealizados = True
                    Me.LimpiarCampos(Me)

                    MsgBox("El Aviso de cobro y sus facturas han Reactivados con éxito", MsgBoxStyle.Information, "AVISO...")

                    Me.Close()
                Catch ex As Exception
                    STIConn.SQLExecute("ROLLBACK TRANSACTION")
                    MsgBox("Error al reactivar el aviso de cobro, la operación ha sido cancelada." & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "ERROR...")
                End Try
            End If
        End If
    End Sub

    Private Sub ActualizarContactos()
        cboAtencionA.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Dim IdCliente As String = Me.txtIdCliente.Valor
        cboAtencionA.Query = "select c.idcontacto as Id, c.Nombre as Nombre, c.Cargo as Cargo from Clientes as l inner join ClientesContactos as c on c.idcliente = l.idcliente where l.IdTipoCliente <> 'NA' and l.idcliente = " & dbStr(IdCliente)
        cboAtencionA.Llenar_Combo()
    End Sub

    Private Sub CalcularValoresPrima()

        Dim Suma As Double = Me.txtPSumaAsegurada.Valor
        Dim Tasa As Double = Me.txtPTarifa.Valor
        txtPPrima.Valor = Suma * Tasa
        Dim Prima As Double = txtPPrima.Valor
        Dim PorceRen As Double = Me.txtPPorceRent.Valor
        txtPDescuento.Valor = Prima * (PorceRen / 100)
        txtPPrimaNeta.Valor = Me.txtPPrima.Valor - Me.txtPDescuento.Valor

        'como se está descontando la comisión de la prima 
        txtPComision.Valor = txtPPrimaNeta.Valor * (txtPPorceComi.Valor / 100)
        txtPIva.Valor = txtPComision.Valor * (Val(clSeguros.ObtenerDBParametros("Porce.Iva")) / 100)
        txtPSubTotal.Valor = txtPComision.Valor + txtPIva.Valor
        if cboAplicarRetencionIva.Valor = "N" then
            txtPRetIva.Valor = 0
        else
            txtPRetIva.Valor = txtPComision.Valor * (Val(clSeguros.ObtenerDBParametros("Porce.Ret.Iva")) / 100)
        End If
        
        txtPTotalCCF.Valor = txtPSubTotal.Valor - txtPRetIva.Valor
        txtComiCobranza.Valor = txtPTotalCCF.Valor
        txtPPrimaPagar.Valor = txtPPrimaNeta.Valor - txtComiCobranza.Valor

        If txtPPrimaPagar.Valor > 0 Then
            txtPrima.Valor = txtPPrimaPagar.Valor
            Call ActualizarFacturacion(True)
        End If
    End Sub

    Private Sub ControlesPrima_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPSumaAsegurada.ValueChangeOnExit, txtPTarifa.ValueChangeOnExit, txtPPorceRent.ValueChangeOnExit, txtPPorceComi.ValueChangeOnExit
        Call CalcularValoresPrima()
    End Sub

End Class
