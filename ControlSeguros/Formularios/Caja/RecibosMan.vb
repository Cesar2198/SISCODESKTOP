Imports Utilerias.Genericas

Public Class RecibosMan

    Private Sub RecibosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''cargamos los combos

        Select Case GlobalCodCliente
            Case "2120000"
                chkPagoDirecto.Visible = True
                chkEnviarRuteo.Visible = True
                chkEnviarRuteo.Enabled = False
                chkPagoDirecto.Checked = False
                chkEnviarRuteo.Checked = False
            Case Else
                chkPagoDirecto.Visible = False
                chkEnviarRuteo.Visible = False
                chkPagoDirecto.Checked = False
                chkEnviarRuteo.Checked = False
        End Select

        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "E" : Fila("Descripcion") = "Efectivo" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "C" : Fila("Descripcion") = "Cheque" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "D" : Fila("Descripcion") = "Depósito Bancario" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "T" : Fila("Descripcion") = "Tarjeta" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "N" : Fila("Descripcion") = "Nota Crédito" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "A" : Fila("Descripcion") = "Depósito en Aseguradora" : FP.Rows.Add(Fila)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = FP
        RepositoryItemLookUpEdit1.PopulateColumns()

        Dim TB As DataTable
        TB = StiGlobalConn.ObtenerDataset("select IdBanco as Id, NombreBanco as [Descripción] from Bancos").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = TB
        RepositoryItemLookUpEdit2.PopulateColumns()

        Dim TP As DataTable
        TP = StiGlobalConn.ObtenerDataset("select IdProducto as Id, Descripcion as [Descripción] from Productos").Tables(0)
        RepositoryItemLookUpEdit3.ValueMember = "Id"
        RepositoryItemLookUpEdit3.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit3.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit3.DataSource = TP
        RepositoryItemLookUpEdit3.PopulateColumns()

        Dim TR As DataTable
        TR = StiGlobalConn.ObtenerDataset("select IdRamo as Id, NombreRamo as [Descripción] from RamoSeguros").Tables(0)
        RepositoryItemLookUpEdit4.ValueMember = "Id"
        RepositoryItemLookUpEdit4.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit4.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit4.DataSource = TR
        RepositoryItemLookUpEdit4.PopulateColumns()

        Dim TA As DataTable
        TA = StiGlobalConn.ObtenerDataset("select IdAseguradora as Id, Nombre as [Descripción] from Aseguradoras").Tables(0)
        RepositoryItemLookUpEdit5.ValueMember = "Id"
        RepositoryItemLookUpEdit5.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit5.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit5.DataSource = TA
        RepositoryItemLookUpEdit5.PopulateColumns()

        RepositoryItemLookUpEdit6.ValueMember = "Id"
        RepositoryItemLookUpEdit6.DisplayMember = "Descripción"
        RepositoryItemLookUpEdit6.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit6.DataSource = TA
        RepositoryItemLookUpEdit6.PopulateColumns()

        Me.txtIdCliente.SoloLectura = True
        Me.txtNombreCliente.SoloLectura = True
        Me.txtDeposito.SoloLectura = True

        Me.txtFechaRecibo.SoloLectura = True

        Dim CerrarSinRecibos As String = clSeguros.ObtenerDBParametros("Caja.Cerrar.Recibo")
        If CerrarSinRecibos Is Nothing Then CerrarSinRecibos = ""
        Dim PermiteRecibos As String = clSeguros.ObtenerDBParametros("Caja.Recibos.SinCerrar")
        Dim HoraCierreCaja As String = clSeguros.ObtenerDBParametros("Coor.Hora.MaximaCierreCaja")
        Dim PermitirPorHora As Boolean = False
        If HoraCierreCaja <> "" Then
            Try
                If (Now.Hour + (Now.Minute / 60)) > (Val(stiSplit(HoraCierreCaja, "G0:1")) + (Val(stiSplit(HoraCierreCaja, "G1:1")) / 60)) Then
                    PermitirPorHora = False
                Else
                    PermitirPorHora = True
                End If
            Catch ex As Exception
                PermitirPorHora = False
            End Try
        End If

        Dim ValidacionCli As Boolean = True

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Dim FechaCaja As DateTime = clSeguros.ObtenerDBParametros("Fecha.Caja")
            Dim AjusteFinSemana As Integer = 0
            If CDate(clSeguros.ObtenerFechaServidor().ToShortDateString).DayOfWeek = DayOfWeek.Monday Then AjusteFinSemana = 1
            Select Case GlobalCodCliente
                Case "2120000"

                    Dim dtRecibosPen As Integer = StiGlobalConn.ObtenerDataset("select count(*) from DiasCaja where FechaCaja <= " & dbFec(DateAdd(DateInterval.Day, -1 * (2 + AjusteFinSemana), CDate(clSeguros.ObtenerFechaServidor().ToShortDateString))) & " and FechaCierre is null").Tables(0).Rows(0).Item(0)
                    If PermiteRecibos.Trim.ToUpper = "N" And dtRecibosPen > 0 Then
                        'no permitir si ya cortes de más de dos días
                        MsgBox("Existen cierres de caja pendientes de más de dos días.", MsgBoxStyle.Information, "AVISO...")
                        btnGuardar.Enabled = False : ValidacionCli = False
                    Else
                        dtRecibosPen = StiGlobalConn.ObtenerDataset("select count(*) from DiasCaja where FechaCaja <= " & dbFec(DateAdd(DateInterval.Day, -1 * (1 + AjusteFinSemana), CDate(clSeguros.ObtenerFechaServidor().ToShortDateString))) & " and FechaCierre is null").Tables(0).Rows(0).Item(0)
                        If dtRecibosPen = 0 Then
                            'puede hacer recibos ya cerró ayer
                        Else
                            'si esta pendiente el día previo, se verifica la hora
                            If PermitirPorHora = False Then
                                MsgBox("Debe cerrarse el día previo, ya ha pasado la hora permitida sin cerrar el día previo", MsgBoxStyle.Information, "AVISO...")
                                btnGuardar.Enabled = False : ValidacionCli = False
                            End If
                        End If
                    End If
            End Select

            If ValidacionCli = True Then
                If FechaCaja.Year <= 1 Then
                    'se abrirá la caja con la fecha del día.
                    FechaCaja = clSeguros.ObtenerFechaServidor()
                    RegistrarAperturaCaja(FechaCaja)
                    Dim ResFecha As String = clSeguros.ActualizarDBParametros("Fecha.Caja", FechaCaja)
                    If ResFecha <> "" Then
                        MsgBox("Error al actualizar la fecha de caja: " & ResFecha)
                    End If
                    Me.txtNumRecibo.Valor = "0"
                    Me.txtFechaRecibo.Valor = FechaCaja
                    Me.cboEstadoRecibo.Valor = "P"
                    Me.cboEnviadoAseguradoras.Valor = "P"
                    Call btnAgregarPago_Click(Nothing, Nothing)
                Else
                    'si la fecha de caja es diferente a la fecha actual. obligaremos a cerrar la caja
                    If CDate(FechaCaja.ToShortDateString) <> CDate(clSeguros.ObtenerFechaServidor().ToShortDateString) Then
                        If CerrarSinRecibos.Trim.ToUpper = "N" Or PermiteRecibos.Trim.ToUpper = "S" Then
                            'con esta opción se pueden abrir las cajas sin cerrar la anterior
                            'se abrirá la caja con la fecha del día.
                            FechaCaja = clSeguros.ObtenerFechaServidor()
                            RegistrarAperturaCaja(FechaCaja)
                            Dim ResFecha As String = clSeguros.ActualizarDBParametros("Fecha.Caja", FechaCaja)
                            If ResFecha <> "" Then
                                MsgBox("Error al actualizar la fecha de caja: " & ResFecha)
                            End If
                            Me.txtNumRecibo.Valor = "0"
                            Me.txtFechaRecibo.Valor = FechaCaja
                            Me.cboEstadoRecibo.Valor = "P"
                            Me.cboEnviadoAseguradoras.Valor = "P"
                            Call btnAgregarPago_Click(Nothing, Nothing)
                        Else
                            MsgBox("La caja no ha sido cerrada, no puede ingresar nuevos recibos hasta no cerrar la caja del día:" & FechaCaja.ToShortDateString, MsgBoxStyle.Information, "AVISO...")
                            btnGuardar.Enabled = False
                        End If
                    Else
                        Me.txtNumRecibo.Valor = "0"
                        Me.txtFechaRecibo.Valor = FechaCaja
                        Me.cboEstadoRecibo.Valor = "P"
                        Me.cboEnviadoAseguradoras.Valor = "P"
                        Call btnAgregarPago_Click(Nothing, Nothing)

                    End If
                End If
            End If
        Else
            Me.txtIdCliente.SoloLectura = True
            Me.txtNombreCliente.SoloLectura = True
            Me.btnBuscarCliente.Enabled = False
            Me.txtFechaRecibo.SoloLectura = True

            'btnGuardar.Enabled = False
            btnAgregarFac.Enabled = False
            btnAgregarOT.Enabled = False
            btnAgregarPago.Enabled = False
            btnQuitarFac.Enabled = False
            btnQuitarOT.Enabled = False
            btnQuitarPago.Enabled = False
            'grid de solo lectura
            Me.VistaFacturas.OptionsBehavior.Editable = False
            Me.VistaOtros.OptionsBehavior.Editable = False
            Me.VistaPago.OptionsBehavior.Editable = False
            Call ObtenerDepositoCliente()

            If cboEstadoRecibo.Valor <> "N" Then
                'permitimos modificar algunos conceptos no delicados de la forma de pago
                Me.VistaPago.OptionsBehavior.Editable = True
                'deshabilitamos las columna que no queremos sean nunca modificadas
                colTotalPag.OptionsColumn.AllowEdit = False
                'colIdAseguradoraPag.OptionsColumn.AllowEdit = False
            End If
        End If
        Me.txtNumRecibo.SoloLectura = True
        Me.txtTotalRecibo.SoloLectura = True
        Me.cboEstadoRecibo.SoloLectura = True
        'Me.cboEnviadoAseguradoras.SoloLectura = True

        Me.VistaFacturas.OptionsBehavior.Editable = False

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            btnImprimir.Enabled = False
            Me.txtUsuarioGrabacion.Valor = StiGlobalConn.User
        End If

        Me.txtUsuarioAnulacion.SoloLectura = True
        Me.txtUsuarioGrabacion.SoloLectura = True
        Me.txtFechaAnulacion.SoloLectura = True
        Me.txtMotivoAnulacion.SoloLectura = True

        If cboEstadoRecibo.Valor = "N" Then
            btnGuardar.Enabled = False
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.EstadoRegistro = enEstadoRegistro.Adicionando
        Me.txtIdCliente.SoloLectura = True
        Me.txtNombreCliente.SoloLectura = True
        Me.btnBuscarCliente.Enabled = True
        Me.cboEstadoRecibo.Valor = "P"

        btnGuardar.Enabled = True
        btnAgregarFac.Enabled = True
        btnAgregarOT.Enabled = True
        btnAgregarPago.Enabled = True
        btnQuitarFac.Enabled = True
        btnQuitarOT.Enabled = True
        btnQuitarPago.Enabled = True
        Me.VistaFacturas.OptionsBehavior.Editable = False
        Me.VistaOtros.OptionsBehavior.Editable = True
        Me.VistaPago.OptionsBehavior.Editable = True
        Me.txtNumRecibo.SoloLectura = True
        Me.cboEstadoRecibo.SoloLectura = True
        Me.txtTotalRecibo.SoloLectura = True

        Me.txtFechaRecibo.SoloLectura = True
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtUsuarioGrabacion.Valor = StiGlobalConn.User
            Dim FechaCaja As DateTime = clSeguros.ObtenerDBParametros("Fecha.Caja")
            If FechaCaja.Year <= 1 Then
                'se abrirá la caja con la fecha del día.
                FechaCaja = clSeguros.ObtenerFechaServidor()
                RegistrarAperturaCaja(FechaCaja)
                Dim ResFecha As String = clSeguros.ActualizarDBParametros("Fecha.Caja", FechaCaja)
                If ResFecha <> "" Then
                    MsgBox("Error al actualizar la fecha de caja: " & ResFecha)
                End If
                Me.txtNumRecibo.Valor = "0"
                Me.txtFechaRecibo.Valor = FechaCaja
                Me.cboEstadoRecibo.Valor = "P"
                Me.cboEnviadoAseguradoras.Valor = "P"
                Me.txtObservaciones.Valor = ""
                Call btnAgregarPago_Click(Nothing, Nothing)
            Else
                'si la fecha de caja es diferente a la fecha actual. obligaremos a cerrar la caja
                If FechaCaja <> clSeguros.ObtenerFechaServidor() Then
                    MsgBox("La caja no ha sido cerrada, no puede ingresar nuevos recibos hasta no cerrar la caja del día:" & FechaCaja.ToShortDateString, MsgBoxStyle.Information, "AVISO...")
                    btnGuardar.Enabled = False
                Else
                    Me.txtNumRecibo.Valor = "0"
                    Me.txtFechaRecibo.Valor = FechaCaja
                    Me.cboEstadoRecibo.Valor = "P"
                    Me.cboEnviadoAseguradoras.Valor = "P"
                    Me.txtObservaciones.Valor = ""
                    Call btnAgregarPago_Click(Nothing, Nothing)
                End If
            End If
        End If

        Me.txtNumRecibo.SoloLectura = True
        Me.txtTotalRecibo.SoloLectura = True
        Me.cboEstadoRecibo.SoloLectura = True
        Me.cboEnviadoAseguradoras.SoloLectura = True

        Me.txtUsuarioAnulacion.SoloLectura = True
        Me.txtUsuarioGrabacion.SoloLectura = True
        Me.txtFechaAnulacion.SoloLectura = True
        Me.txtMotivoAnulacion.SoloLectura = True

        Me.chkEnviarRuteo.Checked = False
        Me.chkPagoDirecto.Checked = False

    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click

        If Me.VistaFacturas.DataRowCount > 0 Then
            MsgBox("El recibo presenta facturas cargadas, no puede cambiar el cliente.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If


        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
            Call ObtenerDepositoCliente()
        End If
    End Sub

    Private Sub ActualizarTotal()

        'Calculamos el total de Facturas y Otros
        Dim Total As Double = 0
        For NF As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
            Try
                Total += Val(VistaFacturas.GetRowCellValue(NF, "Total"))
            Catch ex As Exception

            End Try

        Next
        For NI As Integer = 0 To Me.VistaOtros.DataRowCount - 1
            Try
                Total += Val(VistaOtros.GetRowCellValue(NI, "Total"))
            Catch ex As Exception

            End Try

        Next

        Me.txtTotalRecibo.Valor = Total

    End Sub

    Private Sub btnAgregarFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarFac.Click
        Dim fbus As New BusquedaFacturas
        Dim sql As String = ""
        'Buscamos solo facturas pendientes de pago
        fbus.dbFiltro = " and (select sum(m.total) from facturasmovimientos as m where f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo) > 0 "
        fbus.txtIdCliente.Text = Me.txtIdCliente.Valor
        fbus.txtIdCliente.Properties.ReadOnly = True
        fbus.PermitirMultiplesSelecciones = True
        busCodigo = ""
        fbus.ShowDialog()
        If busCodigo <> "" Then
            Dim busCodigoTodos As String = busCodigo
            Dim Incluir As Boolean = True
            Dim NumFacturas As Integer = CuentaCar(busCodigoTodos, "^")
            Dim LstCancela As String = clSeguros.ObtenerDBParametros("Cod.Cancela.Restringe")
            For NF As Integer = 0 To NumFacturas
                busCodigo = stiSplit(busCodigoTodos, "G" & NF & "^1")

                Dim Factura As String = stiSplit(busCodigo, "G0|1")
                Dim Producto As String = stiSplit(busCodigo, "G1|1")
                Dim Poliza As String = stiSplit(busCodigo, "G2|1")
                Dim Ramo As String = stiSplit(busCodigo, "G3|1")
                Dim Nombre As String = ""
                Dim Valor As Double = 0
                Incluir = True

                If ExisteFactura(Factura, Producto, Poliza, Ramo) = True Then
                    MsgBox("La factura " & Factura & " ya está incluida en el recibo.", MsgBoxStyle.Information, "AVISO...")
                    Incluir = False
                End If

                'verificaremos que la factura no esté en otro recibo pendiente de aplicarse (no anulados)
                Dim NumreciboExiste As String = "-1"
                Try
                    sql = "  select top 1 f.IdRecibo from recibos as r "
                    sql &= " inner join RecibosFacturas as f on r.idrecibo = f.idrecibo "
                    sql &= " where f.NumeroFactura = " & dbInt(Factura) & " and f.IdProducto = " & dbStr(Producto)
                    sql &= " and f.IdPoliza = " & dbStr(Poliza) & " and f.IdRamo = " & dbStr(Ramo)
                    sql &= " and r.EstadoRecibo <> 'N' "
                    NumreciboExiste = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    NumreciboExiste = "-1"
                End Try

                If NumreciboExiste <> "-1" Then
                    MsgBox("La factura " & Factura & " que intenta agregar ya está ingresada en el recibo: " & NumreciboExiste, MsgBoxStyle.Information, "AVISO...")
                    Incluir = False
                End If

                'como validación verificaremos que la factura tenga Saldo.
                Try
                    sql = " select f.NombreCliente , sum(m.Total) as Total"
                    sql &= " from Facturas as f inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo"
                    sql &= " where f.NumeroFactura = " & dbInt(Factura)
                    sql &= " and f.IdProducto = " & dbStr(Producto)
                    sql &= " and f.IdPoliza = " & dbStr(Poliza)
                    sql &= " and f.IdRamo = " & dbStr(Ramo)
                    sql &= " group by f.NombreCliente"
                    Dim FilPago As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Nombre = dbData(FilPago, "NombreCliente")
                    Valor = Val(dbData(FilPago, "Total"))
                Catch ex As Exception
                    Nombre = ""
                    Valor = 0
                End Try

                If Valor <= 0 Then
                    Incluir = False
                End If

                If LstCancela <> "" Then
                    Try
                        Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select p.IdCancelacion, t.NombreCancelacion from Polizas as p left join TipoCancelacion as t on p.IdCancelacion = t.IdCancelacion where p.idpoliza = " & dbStr(Poliza) & " and p.idproducto = " & dbStr(Producto)).Tables(0).Rows(0)
                        If ExisteItemEnLista(dbData(FilPol, "IdCancelacion"), LstCancela) = True Then
                            MsgBox("La póliza " & Poliza & " está cancelada y el tipo de cancelación restringe esta operación: " & dbData(FilPol, "NombreCancelacion") & ", no se puede incluir en el recibo la Factura: " & Factura, MsgBoxStyle.Information, "AVISO...")
                            Incluir = False
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If Incluir = True Then
                    Try
                        Me.AgregarFilaGrid(Me.VistaFacturas)
                        VistaFacturas.SetRowCellValue(VistaFacturas.FocusedRowHandle, "NumeroFactura", CInt(Factura))
                        VistaFacturas.SetRowCellValue(VistaFacturas.FocusedRowHandle, "IdProducto", Producto)
                        VistaFacturas.SetRowCellValue(VistaFacturas.FocusedRowHandle, "IdPoliza", Poliza)
                        VistaFacturas.SetRowCellValue(VistaFacturas.FocusedRowHandle, "IdRamo", Ramo)
                        VistaFacturas.SetRowCellValue(VistaFacturas.FocusedRowHandle, "NombreCliente", Nombre)
                        VistaFacturas.SetRowCellValue(VistaFacturas.FocusedRowHandle, "Total", CDbl(Valor))
                        VistaFacturas.UpdateCurrentRow()
                        VistaFacturas.PostEditor()
                        Call ActualizarTotal()

                        'ahora obtenemos la aseguradora para proponerla en el concepto de pago.
                        Try
                            Dim ExisteAseg As Boolean = False
                            Dim IdAseguradora As String = StiGlobalConn.ObtenerDataset("select idaseguradora from productos where idproducto = " & dbStr(Producto)).Tables(0).Rows(0).Item(0)
                            'verificamos si ya está incluida
                            For NCP As Integer = 0 To Me.VistaPago.DataRowCount - 1
                                If CastToString(VistaPago.GetRowCellValue(NCP, "IdAseguradora")) = IdAseguradora Then
                                    ExisteAseg = True
                                End If
                            Next
                            If ExisteAseg = False Then
                                If CastToString(VistaPago.GetRowCellValue(0, "IdAseguradora")) = "" Then
                                    VistaPago.SetRowCellValue(0, "IdAseguradora", IdAseguradora)
                                Else
                                    Dim id As Integer = ObtenerIDPago()
                                    VistaPago.AddNewRow()
                                    VistaPago.SetRowCellValue(VistaPago.FocusedRowHandle, "IdAseguradora", IdAseguradora)
                                    VistaPago.SetRowCellValue(VistaPago.FocusedRowHandle, "IdPago", id)
                                    VistaPago.UpdateCurrentRow()
                                    VistaPago.RefreshData()
                                End If
                            End If

                        Catch ex As Exception

                        End Try
                    Catch ex As Exception
                        MsgBox("Error al adicionar la Factura " & Factura & "." & vbCrLf & ex.Message)
                    End Try
                End If
            Next

            Dim strValida As String = ValidarFacturaAdelantada()
            If strValida <> "" Then MsgBox("Se han encontrado facturas en el recibo que tienen facturas previas no pagadas: " & strValida, MsgBoxStyle.Exclamation, "AVISO...")

        End If
    End Sub

    Private Function ExisteFactura(ByVal Factura As String, ByVal Producto As String, ByVal Poliza As String, ByVal Ramo As String) As Boolean
        Dim res As Boolean = False
        For NF As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
            If CStr(VistaFacturas.GetRowCellValue(NF, "NumeroFactura")).Trim = Trim(Factura) And CStr(VistaFacturas.GetRowCellValue(NF, "IdProducto")).Trim = Trim(Producto) And CStr(VistaFacturas.GetRowCellValue(NF, "IdPoliza")).Trim = Trim(Poliza) And CStr(VistaFacturas.GetRowCellValue(NF, "IdRamo")).Trim = Trim(Ramo) Then
                res = True
                Exit For
            End If
        Next
        Return res
    End Function

    Private Function ValidarFacturaAdelantada() As String
        Dim res As String = "", sql As String = "", NumFactPend As Integer = 0, lstFact As String = ""

        Dim Factura As String = "", Producto As String = "", Poliza As String = "", Ramo As String = "", NumCuota As Integer = 0
        Try
            For I As Integer = 0 To Me.VistaFacturas.RowCount - 1
                Factura = VistaFacturas.GetRowCellValue(I, "NumeroFactura")
                Producto = VistaFacturas.GetRowCellValue(I, "IdProducto")
                Poliza = VistaFacturas.GetRowCellValue(I, "IdPoliza")
                Ramo = VistaFacturas.GetRowCellValue(I, "IdRamo")
                NumCuota = StiGlobalConn.ObtenerDataset("select NumCuota from Facturas as tmp where tmp.IdPoliza = " & dbStr(Poliza) & " and tmp.IdProducto = " & dbStr(Producto) & " and tmp.NumeroFactura = " & dbInt(Factura) & " and tmp.IdRamo = " & dbStr(Ramo)).Tables(0).Rows(0).Item(0)

                sql = "  select count(*) "
                sql &= " from Facturas as f  "
                sql &= " inner join AvisosCobroFacturas as acf on acf.IdPoliza = f.IdPoliza and acf.IdProducto = f.IdProducto and acf.NumeroFactura = f.NumeroFactura and acf.IdRamo = f.IdRamo "
                'del aviso de cobro
                sql &= " where acf.IdAvisoCobro in (select tmp.IdAvisoCobro from AvisosCobroFacturas as tmp where tmp.IdPoliza = " & dbStr(Poliza) & " and tmp.IdProducto = " & dbStr(Producto) & " and tmp.NumeroFactura = " & dbInt(Factura) & " and tmp.IdRamo = " & dbStr(Ramo) & " ) "
                'facturas previas
                sql &= " and f.NumCuota < " & dbInt(NumCuota)
                'que no este pagada
                sql &= " and (select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo ) > 0 "
                'que no este en un recibo grabado
                sql &= " and (select count(*) from RecibosFacturas as r where r.NumeroFactura = f.NumeroFactura and r.IdProducto = f.IdProducto and r.IdPoliza = f.IdPoliza and r.IdRamo = f.IdRamo) = 0 "
                'que no este en el recibo actual, hacemos una lista de facturas del mismo producto
                lstFact = ""
                For J As Integer = 0 To Me.VistaFacturas.RowCount - 1
                    If VistaFacturas.GetRowCellValue(J, "IdProducto") = Producto And VistaFacturas.GetRowCellValue(J, "IdPoliza") = Poliza And VistaFacturas.GetRowCellValue(J, "IdRamo") = Ramo And CStr(VistaFacturas.GetRowCellValue(J, "NumeroFactura")).Trim <> Factura Then
                        If lstFact = "" Then
                            lstFact &= CStr(VistaFacturas.GetRowCellValue(J, "NumeroFactura")).Trim
                        Else
                            lstFact &= ", " & CStr(VistaFacturas.GetRowCellValue(J, "NumeroFactura")).Trim
                        End If
                    End If
                Next
                If lstFact <> "" Then
                    sql &= " and f.NumeroFactura not in (" & lstFact & ")"
                End If

                NumFactPend = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

                If NumFactPend > 0 Then res &= ", " & Factura
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function


    Private Sub btnQuitarFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarFac.Click
        Try
            Me.EliminarFilaGrid(Me.VistaFacturas)
            VistaFacturas.PostEditor()
        Catch ex As Exception
            MsgBox("Error al eliminar la factura." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarOT.Click
        Try
            Dim id As Integer = ObtenerIDOT()
            Me.AgregarFilaGrid(Me.VistaOtros)
            Me.VistaOtros.SetRowCellValue(VistaOtros.FocusedRowHandle, "IdOtroIngreso", id)
            Me.VistaOtros.UpdateCurrentRow()

            VistaOtros.PostEditor()
            Call ActualizarTotal()
        Catch ex As Exception
            MsgBox("Error al adicionar el ingreso." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDOT() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaOtros.DataRowCount - 1
            Try
                If CInt(VistaOtros.GetRowCellValue(I, "IdOtroIngreso")) > Id Then
                    Id = CInt(VistaOtros.GetRowCellValue(I, "IdOtroIngreso"))
                End If
            Catch ex As Exception

            End Try

        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnQuitarOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarOT.Click
        Try
            Me.EliminarFilaGrid(Me.VistaOtros)
            VistaOtros.PostEditor()
        Catch ex As Exception
            MsgBox("Error al eliminar el ingreso." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click
        Try
            Dim id As Integer = ObtenerIDPago()
            Me.AgregarFilaGrid(Me.VistaPago)
            Me.VistaPago.SetRowCellValue(VistaPago.FocusedRowHandle, "IdPago", id)
            Me.VistaPago.UpdateCurrentRow()

            VistaPago.PostEditor()
        Catch ex As Exception
            MsgBox("Error al adicionar el ingreso." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDPago() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaPago.DataRowCount - 1
            Try
                If CInt(VistaPago.GetRowCellValue(I, "IdPago")) > Id Then
                    Id = CInt(VistaPago.GetRowCellValue(I, "IdPago"))
                End If
            Catch ex As Exception

            End Try
        Next
        If Id = 0 Then
            Id = 1
        Else
            Id += 1
        End If
        Return Id
    End Function

    Private Sub btnQuitarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarPago.Click
        Try
            Me.EliminarFilaGrid(Me.VistaPago)
            VistaPago.PostEditor()
        Catch ex As Exception
            MsgBox("Error al eliminar el ingreso." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub VistaOtros_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaOtros.CellValueChanged
        Try
            VistaOtros.PostEditor()
            Call ActualizarTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RecibosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        'implementaremos algunas validaciones antes de guardar
        Dim Errores As Boolean = False
        Call ActualizarTotal()

        'Validaremos que los otros ingresos sean mayor a cero y con descripcion
        Dim ErrorOT As Boolean = False
        For OT As Integer = 0 To Me.VistaOtros.DataRowCount - 1
            Try
                If CStr(VistaOtros.GetRowCellValue(OT, "IdAseguradora")).Trim = "" Or CStr(VistaOtros.GetRowCellValue(OT, "Descripcion")).Trim = "" Or Val(VistaOtros.GetRowCellValue(OT, "Total")) <= 0 Then
                    ErrorOT = True
                End If
            Catch ex As Exception
                ErrorOT = True
            End Try
        Next
        If ErrorOT = True Then
            MsgBox("Debe completar todos los datos de los otros ingresos: Aseguradora, Descripción y Valor", MsgBoxStyle.Information, "AVISO...")
            Errores = True
        End If

        'Ahora Validaremos los pagos: Valor y Tipo podemos validar
        Dim TotalPag As Double = 0
        Dim ErrorPago As Boolean = False
        For PA As Integer = 0 To Me.VistaPago.DataRowCount - 1
            Try
                TotalPag += (Val(VistaPago.GetRowCellValue(PA, "Total")) - Val(VistaPago.GetRowCellValue(PA, "Cambio")))
            Catch ex As Exception

            End Try
            Try
                If CStr(VistaPago.GetRowCellValue(PA, "IdTipoIngreso")).Trim = "" Or Val(VistaPago.GetRowCellValue(PA, "Total")) <= 0 Then
                    MsgBox("Los conceptos de ingreso deben tener el tipo y el monto del ingreso.", MsgBoxStyle.Information, "AVISO...")
                    ErrorPago = True
                End If
                Select Case CStr(VistaPago.GetRowCellValue(PA, "IdTipoIngreso")).Trim
                    Case "C", "T", "D"
                        If CStr(VistaPago.GetRowCellValue(PA, "IdBanco")).Trim = "" Or CStr(VistaPago.GetRowCellValue(PA, "Documento")).Trim = "" Then
                            MsgBox("Los conceptos de ingreso: Cheques, Tarjeta o Depósito requieren el ingreso del Banco y del documento presentado.", MsgBoxStyle.Information, "AVISO...")
                            ErrorPago = True
                        End If
                End Select
            Catch ex As Exception
                MsgBox("Existen errores en los conceptos de ingreso verifiquelos.", MsgBoxStyle.Information, "AVISO...")
                ErrorPago = True
            End Try
        Next
        If ErrorPago = True Then
            Errores = True
        End If

        'validaremos que el Total de Pago sea el total del documento
        Dim TotalDoc As Double = Me.txtTotalRecibo.Valor
        If Math.Round(Val(TotalDoc), 2) <> Math.Round(Val(TotalPag), 2) Then
            MsgBox("El total del recibo debe ser el mismo que el total de los conceptos de ingreso.", MsgBoxStyle.Information, "AVISO...")
            Errores = True
        End If

        If TotalDoc <= 0 Then
            MsgBox("El recibo no presenta conceptos de ingreso, no puede guardar un recibo en cero.", MsgBoxStyle.Information, "AVISO...")
            Errores = True
        End If

        If Errores = True Then
            Cancel = True
        Else
            'como todo está bien generamos el número del recibo
            If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                If chkPagoDirecto.Visible = True And Me.chkPagoDirecto.Checked = True Then
                    Me.txtNumRecibo.Valor = "PD-" & clSeguros.ObtenerID("Recibos.Num.PD." & Date.Today.Year) & "-" & Date.Today.Year
                Else
                    Me.txtNumRecibo.Valor = clSeguros.ObtenerID("Recibos.Num." & Date.Today.Year) & "-" & Date.Today.Year
                End If
                Call txtNumRecibo_ValueChangeOnExit(Nothing, Nothing, "")
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If chkEnviarRuteo.Visible = True Then
            Call ImprimirRecibo(txtNumRecibo.Text, chkEnviarRuteo.Checked)
        Else
            Call ImprimirRecibo(txtNumRecibo.Text, True)
        End If
    End Sub

    Private Sub ObtenerDepositoCliente()
        Dim Total As Double = 0
        Try
            Total = StiGlobalConn.ObtenerDataset("select isnull(sum(ValorDeposito),0) from DepositosMovimientos where IdCliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Total = 0
        End Try
        txtDeposito.Valor = Total
    End Sub

    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        'limpiaremos informacion innecesarios si hay cheque
        VistaPago.PostEditor()
        'Try
        '    For NF As Integer = 0 To Me.VistaPago.DataRowCount - 1
        '        If Me.VistaPago.GetRowCellValue(NF, "IdTipoIngreso") = "E" Then
        '            Me.VistaPago.SetRowCellValue(NF, "IdBanco", "")
        '            Me.VistaPago.SetRowCellValue(NF, "Documento", "")
        '            Me.VistaPago.SetRowCellValue(NF, "NumConfirmacion", "")
        '            Me.VistaPago.SetRowCellValue(NF, "IdAseguradora", "")
        '        End If
        '    Next
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub VistaPago_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaPago.CellValueChanged
        VistaPago.RefreshRow(e.RowHandle)
        VistaPago.PostEditor()
        VistaPago.UpdateCurrentRow()
        If e.Column.FieldName = "Total" Then Call ProcesarCambio()
    End Sub

    Private Sub txtNumRecibo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtNumRecibo.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtNumRecibo.NombreCampo, txtNumRecibo.Valor)
    End Sub

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.VistaPago.FocusedColumn.FieldName
            Case "Documento" : Me.RepositoryItemTextEdit1.MaxLength = 50
            Case "NumConfirmacion" : Me.RepositoryItemTextEdit1.MaxLength = 25
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit2.Enter
        Select Case Me.VistaPago.FocusedColumn.FieldName
            Case "Descripcion" : Me.RepositoryItemTextEdit2.MaxLength = 250
        End Select
    End Sub

    Private Sub RecibosMan_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        'mandamos a imprimir el recibo
        Try
            'Call btnImprimir_Click(Nothing, Nothing)
            If chkPagoDirecto.Visible = True Then
                If Me.chkPagoDirecto.Checked = True Then
                    Call btnImprimir_Click(Nothing, Nothing)
                End If
            Else
                Call btnImprimir_Click(Nothing, Nothing)
            End If

        Catch ex As Exception

        End Try

        'Call btnNuevo_Click(Nothing, Nothing)
        ''mejor salir por que sino le dará un núevo numero de recibo.
        'Me.Close()
    End Sub

    Private Sub chkPagoDirecto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPagoDirecto.CheckedChanged
        If Me.chkPagoDirecto.Checked = True Then
            chkEnviarRuteo.Enabled = True
        Else
            chkEnviarRuteo.Checked = False
            chkEnviarRuteo.Enabled = False
        End If
    End Sub

    Private Sub ProcesarCambio()
        Try
            Dim MontoRecibo As Double = txtTotalRecibo.Valor
            Dim TotalIng As Double = 0
            For I As Integer = 0 To Me.VistaPago.RowCount - 1
                TotalIng += Val(VistaPago.GetRowCellValue(I, "Total"))
                'If VistaPago.GetRowCellValue(I, "IdTipoIngreso") = "E" Then
                Me.VistaPago.SetRowCellValue(I, "Cambio", CDbl(0))
                'End If
            Next

            If TotalIng - MontoRecibo > 0 Then
                For I As Integer = 0 To Me.VistaPago.RowCount - 1
                    If VistaPago.GetRowCellValue(I, "IdTipoIngreso") = "E" Then
                        Me.VistaPago.SetRowCellValue(I, "Cambio", CDbl(TotalIng - MontoRecibo))
                        Exit Sub
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class
