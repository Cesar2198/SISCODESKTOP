
Imports System.Xml
Imports Utilerias.Genericas
Imports System.Text.RegularExpressions

Public Class Pagos

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'determinaremos las facturas que desean pagarse
        Try
            If txtCliente.Text = "" And Me.txtPoliza.Text = "" And Me.cboProducto.Text = "" And Me.txtDocumento.Text = "" And Me.txtFactura.Text = "" And Me.txtFechaPagoLim.Text = "" Then
                MsgBox("Debe definir al menos un parámetro de búsqueda.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String
            sql = "  select f.NumeroFactura as NumFactura, p.Descripcion as Producto, f.IdPoliza as Polizas, cast(0 as bit) as Pagar, f.IdProducto, f.IdRamo"
            sql &= " , f.NombreCliente as Asegurado, f.FechaPago as FechaPago, cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as NumCuota, f.IdCliente as IdCliente"
            sql &= " , isnull((select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Prima"
            sql &= " , isnull((select sum(m.GastosEmision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as GastosEmision"
            sql &= " , isnull((select sum(m.GastosFracciona) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as GastosFracciona"
            sql &= " , isnull((select sum(m.GastosBomberos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as GastosBomberos"
            sql &= " , isnull((select sum(m.Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Gastos"
            sql &= " , isnull((select sum(m.Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Iva"
            sql &= " , isnull((select sum(m.RetencionImpuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as RetencionImpuestos"
            sql &= " , isnull((select sum(m.Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Total"
            sql &= " , isnull((select sum(m.Comision) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ),0) as Comision"
            sql &= " from facturas as f"
            sql &= " left join Clientes as c on c.IdCliente = f.IdCliente"
            sql &= " left join Productos as p on p.IdProducto = f.IdProducto"
            sql &= " where NumeroFactura is not null "
            sql &= " and (select sum(m.PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo ) > 0"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If txtCliente.Text.Trim <> "" Then
                Dim numNombres As Integer = CuentaCar(txtCliente.Text.Trim, " "), Nombre As String = ""
                For NM As Integer = 0 To numNombres
                    Nombre = stiSplit(txtCliente.Text.Trim, "G" & NM & " 1").Trim
                    If Nombre <> "" Then
                        sql &= " and f.NombreCliente like " & dbStr("%" & Nombre & "%")
                    End If
                Next
            End If
            If txtPoliza.Text.Trim <> "" Then
                sql &= " and f.idpoliza like " & dbStr("%" & txtPoliza.Text.Trim & "%")
            End If
            If cboProducto.Text <> "" Then
                sql &= " and f.idproducto = " & dbStr(cboProducto.Valor)
            End If
            If txtDocumento.Text.Trim <> "" Then
                sql &= " and (c.Nit = " & dbStr(txtDocumento.Text.Trim) & " or c.Dui = " & dbStr(txtDocumento.Text.Trim) & " or c.RegistroFiscal = " & dbStr(txtDocumento.Text.Trim) & ")"
            End If
            If Me.txtFactura.Text <> "" Then
                sql &= " and f.NumeroFactura = " & dbInt(txtFactura.Valor)
            End If
            If txtFechaPagoLim.Text <> "" Then
                sql &= " and f.FechaPago <= " & dbFec(txtFechaPagoLim.Valor)
            End If

            Dim Facturas As DataSet = StiGlobalConn.ObtenerDataset(sql)
            Me.GridFacturas.DataSource = Facturas.Tables(0)
            Me.GridFacturas.Refresh()
            Call ActualizarTotales()
            If Facturas.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron facturas pendientes de pago para la búsqueda seleccionada.", MsgBoxStyle.Information, "AVISO...")
            End If
            Call ActualizarListaFlujos()
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub ActualizarTotales()
        Try
            Dim Prima As Double = 0, Gastos As Double = 0, Iva As Double = 0, Total As Double = 0
            For I As Integer = 0 To VistaFacturas.DataRowCount - 1
                If Me.VistaFacturas.GetRowCellValue(I, "Pagar") = True Then
                    Prima += Val(VistaFacturas.GetRowCellValue(I, "Prima"))
                    Gastos += Val(VistaFacturas.GetRowCellValue(I, "GastosEmision")) + Val(VistaFacturas.GetRowCellValue(I, "GastosFracciona")) + Val(VistaFacturas.GetRowCellValue(I, "GastosBomberos")) + Val(VistaFacturas.GetRowCellValue(I, "Gastos"))
                    Iva += Val(VistaFacturas.GetRowCellValue(I, "Iva"))
                    Total += Val(VistaFacturas.GetRowCellValue(I, "Total"))
                End If
            Next
            Me.txtTotalPrimaNeta.Valor = Prima
            Me.txtTotalGastos.Valor = Gastos
            Me.txtTotalImpuestos.Valor = Iva
            Me.txtTotal.Valor = Total

        Catch ex As Exception

        End Try        
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        Me.VistaFacturas.PostEditor()
        Call ActualizarTotales()
        Call ActualizarListaFlujos()
    End Sub

    Private Sub Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString()
        Me.cboProducto.Llenar_Combo()
        Me.cboIdFormaPago.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdFormaPago.Llenar_Combo()
        Me.txtFechaPago.Valor = Date.Today
        Me.txtFactura.Valor = ""
        Me.VistaFacturas.FocusedColumn = FACol11
        Call ProcesarPermisosComision()

        cboFlujo.StringConection = StiGlobalConn.ObtenerOledbConnectionString

        Select Case GlobalCodCliente
            Case "2120000"
                cboFlujo.Visible = True
                cboFlujo.Obligatorio = True
            Case Else
                cboFlujo.Obligatorio = False
                Me.cboFlujo.Visible = False
        End Select
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                FACol13.Visible = False
                FACol13.OptionsColumn.AllowShowHide = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'vamos a recorrer el los pagos marcados y a ingresar el pago.
        If Me.txtFechaPago.Text = "" Then
            MsgBox("Debe especificar la fecha efectiva de pago.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        If cboFlujo.Obligatorio = True And CStr(cboFlujo.Valor) = "" Then
            MsgBox("Debe especificar el flujo de los documentos que se generarán.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        Dim strValida As String = ValidarFacturaAdelantada()
        If strValida <> "" Then 
            if MsgBox("Se han encontrado facturas marcadas para pago que poseen facturas previas no pagadas: " & strValida & vbcrlf & "¿Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 , "AVISO...") = msgboxresult.No then
                exit sub 
            End If
        End If
            
        Dim IdClienteImp As String = "", lstFacturas As String = "", Claves As String = "", AseguradoImp As String = ""

        Try
            Dim Res As String = ""
            For I As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                If VistaFacturas.GetRowCellValue(I, "Pagar") = True Then
                    Dim CuentaRecibo As Integer = StiGlobalConn.ObtenerDataset("select count(*) from Recibos as a inner join  RecibosFacturas as b on a.IdRecibo = b.IdRecibo where a.EstadoRecibo <> 'N' and b.NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and b.IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and b.IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and b.IdRamo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo"))).Tables(0).Rows(0).Item(0)

                    If CuentaRecibo > 0 Then
                        Dim IdRecibo As String = StiGlobalConn.ObtenerDataset("select a.idrecibo from Recibos as a inner join RecibosFacturas as b on a.IdRecibo = b.IdRecibo where a.EstadoRecibo <> 'N' and b.NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and b.IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and b.IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and b.IdRamo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo"))).Tables(0).Rows(0).Item(0)
                        MsgBox("La factura " & VistaFacturas.GetRowCellValue(I, "NumFactura") & " no puede pagarse por este medio, esté pendiente de aplicarse en el recibo de caja No." & IdRecibo, MsgBoxStyle.Information, "AVISO...")
                    Else
                        Res = Cartera_AgregarPago(VistaFacturas.GetRowCellValue(I, "NumFactura"), VistaFacturas.GetRowCellValue(I, "Polizas"), VistaFacturas.GetRowCellValue(I, "IdProducto"), txtFechaPago.Valor, VistaFacturas.GetRowCellValue(I, "Prima"), VistaFacturas.GetRowCellValue(I, "GastosEmision"), VistaFacturas.GetRowCellValue(I, "GastosFracciona"), VistaFacturas.GetRowCellValue(I, "GastosBomberos"), VistaFacturas.GetRowCellValue(I, "Gastos"), VistaFacturas.GetRowCellValue(I, "Iva"), VistaFacturas.GetRowCellValue(I, "Total"), VistaFacturas.GetRowCellValue(I, "Comision"), VistaFacturas.GetRowCellValue(I, "IdRamo"), VistaFacturas.GetRowCellValue(I, "RetencionImpuestos"), cboIdFormaPago.Valor)
                        If Res <> "" Then
                            MsgBox("No es posible realizar el pago de la factura:" & VistaFacturas.GetRowCellValue(I, "NumFactura") & vbCrLf & Res, MsgBoxStyle.Information, "AVISO...")
                        End If

                        ''actualizaremos la factura con el número de documento fiscal emitido por aseguradora
                        If Me.txtDocumentoFiscal.Text <> "" Then
                            Try
                                StiGlobalConn.SQLExecute("update facturas set DocumentoFiscal = " & dbStr(txtDocumentoFiscal.Text) & " where NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and IdProducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and IdPoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and IdRamo =  " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")))
                            Catch ex As Exception

                            End Try
                        End If

                        Dim msgflujo As String = clFlujos.IniciarFlujoPagos(VistaFacturas.GetRowCellValue(I, "NumFactura"), VistaFacturas.GetRowCellValue(I, "Polizas"), VistaFacturas.GetRowCellValue(I, "IdProducto"), VistaFacturas.GetRowCellValue(I, "IdRamo"))
                        If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")

                        If chkImprimirCartas.Checked = True Then

                            IdClienteImp = VistaFacturas.GetRowCellValue(I, "IdCliente")
                            AseguradoImp = VistaFacturas.GetRowCellValue(I, "Asegurado")
                            Claves &= VistaFacturas.GetRowCellValue(I, "NumFactura") & ","
                            
                            'Call ImprimirPago(VistaFacturas.GetRowCellValue(I, "NumFactura"), VistaFacturas.GetRowCellValue(I, "IdProducto"), VistaFacturas.GetRowCellValue(I, "Polizas"), VistaFacturas.GetRowCellValue(I, "IdRamo"), UltimoMovimientoFactura, IdImpresion)
                            If lstFacturas = "" Then
                                lstFacturas &= " and ( (f.NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and f.idproducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and f.idramo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")) & ")"
                            Else
                                lstFacturas &= " or (f.NumeroFactura = " & dbInt(VistaFacturas.GetRowCellValue(I, "NumFactura")) & " and f.idproducto = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaFacturas.GetRowCellValue(I, "Polizas")) & " and f.idramo = " & dbStr(VistaFacturas.GetRowCellValue(I, "IdRamo")) & ")"
                            End If

                            msgflujo = clFlujos.IniciarFlujoPagos(VistaFacturas.GetRowCellValue(I, "NumFactura"), VistaFacturas.GetRowCellValue(I, "Polizas"), VistaFacturas.GetRowCellValue(I, "IdProducto"), VistaFacturas.GetRowCellValue(I, "IdRamo"))
                            If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")
                        End If
                    End If
                End If
            Next

            If IdClienteImp <> "" And lstFacturas <> "" And chkImprimirCartas.Checked = True Then
                lstFacturas &= ") "

                Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.AC")).Trim.ToUpper
                Dim IdFlujoDefault As String = "", IdImpresion As String = ""
                If IncluirEnEvioSimple = "S" Then
                    Try
                        IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                    Catch ex As Exception
                        IdFlujoDefault = ""
                    End Try
                    Select Case GlobalCodCliente
                        Case "2120000"
                            IdFlujoDefault = cboFlujo.Valor
                    End Select

                    If IdFlujoDefault <> "" Then
                        Call clFlujos.RegistrarDocumento(IdFlujoDefault, "Carta Envio de Comprobantes Pagados", IdClienteImp, Claves, "SALIDA", IdImpresion, "", Date.Today, AseguradoImp, EsDocumentoDeCobro:=True, CodigoImpresionDocumento:="CP")

                        Try
                            Dim FilDatosCliente As DataRow = StiGlobalConn.ObtenerDataset("select top 1 f.NombreCliente, isnull(c.Direccion,'') as Direccion  from Clientes as f left join ClientesContactos as c on c.IdCliente = f.IdCliente where f.IdCliente = " & dbStr(IdClienteImp) & " order by c.UsoCorrespondencia desc").Tables(0).Rows(0)
                            Dim strSQL As String = "  update FlujosDocumentosImpresiones set "
                            strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                            strSQL &= " ,DireccionDocumento = " & dbStr(dbData(FilDatosCliente, "Direccion"), 250)
                            strSQL &= " ,NombreDestinatario = " & dbStr(dbData(FilDatosCliente, "NombreCliente"), 150)
                            strSQL &= " ,IdOrigen = " & dbStr(dbData(FilDatosCliente, "NombreCliente"), 250)
                            strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdImpresion)
                            StiGlobalConn.SQLExecute(strSQL)
                        Catch ex As Exception

                        End Try
                    End If
                End If

                Call ImprimirPago(IdClienteImp, "", lstFacturas, IdImpresion, "", "", "", "")
            End If

            Call LimpiarEntradas()
            MsgBox("La operación ha finalizado.", MsgBoxStyle.Information, "AVISO...")
            txtPoliza.Focus()
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Function ValidarFacturaAdelantada() As String
        Dim res As String = "", sql As String = "", NumFactPend As Integer = 0, lstFact As String = ""

        Dim Factura As String = "", Producto As String = "", Poliza As String = "", Ramo As String = "", NumCuota As Integer = 0
        Try
            For I As Integer = 0 To Me.VistaFacturas.RowCount - 1
                If VistaFacturas.GetRowCellValue(I, "Pagar") = True Then
                    Factura = VistaFacturas.GetRowCellValue(I, "NumFactura")
                    Producto = VistaFacturas.GetRowCellValue(I, "IdProducto")
                    Poliza = VistaFacturas.GetRowCellValue(I, "Polizas")
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
                        If VistaFacturas.GetRowCellValue(J, "IdProducto") = Producto And VistaFacturas.GetRowCellValue(J, "Polizas") = Poliza And VistaFacturas.GetRowCellValue(J, "IdRamo") = Ramo And CStr(VistaFacturas.GetRowCellValue(J, "NumFactura")).Trim <> Factura Then
                            If VistaFacturas.GetRowCellValue(J, "Pagar") = True Then
                                If lstFact = "" Then
                                    lstFact &= CStr(VistaFacturas.GetRowCellValue(J, "NumFactura")).Trim
                                Else
                                    lstFact &= ", " & CStr(VistaFacturas.GetRowCellValue(J, "NumFactura")).Trim
                                End If
                            End If
                        End If
                    Next
                    If lstFact <> "" Then
                        sql &= " and f.NumeroFactura not in (" & lstFact & ")"
                    End If

                    NumFactPend = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

                    If NumFactPend > 0 Then res &= ", " & Factura
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function


    Private Sub LimpiarEntradas()
        Me.txtCliente.Valor = ""
        Me.txtDocumento.Valor = ""
        Me.txtPoliza.Valor = ""
        Me.cboProducto.Valor = ""
        Me.txtTotal.Valor = 0
        Me.txtTotalGastos.Valor = 0
        Me.txtTotalImpuestos.Valor = 0
        Me.txtTotalPrimaNeta.Valor = 0
        Me.GridFacturas.DataSource = Nothing
        Me.GridFacturas.Refresh()
    End Sub

    Private Sub VistaFacturas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaFacturas.Click
        Try
            If VistaFacturas.FocusedColumn.FieldName = "Pagar" Then  'la columna incluir
                Me.Cursor = Cursors.WaitCursor
                Dim Valor1 As Boolean = VistaFacturas.GetRowCellValue(0, "Pagar")
                Valor1 = Not Valor1
                For NF As Integer = 0 To Me.VistaFacturas.RowCount - 1
                    If NF Mod 25 = 0 Then Application.DoEvents()
                    VistaFacturas.SetRowCellValue(NF, "Pagar", Valor1)
                Next
                Me.Cursor = Cursors.Default
            End If
            Call ActualizarTotales()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ActualizarListaFlujos()
        Try
            Dim strCliente As String = ""
            Dim IdCliente As String = ObtenerIdCliente()
            If IdCliente <> "" Then
                strCliente = " and IdCliente = " & dbStr(IdCliente)
            End If

            If strCliente = "" Then
                Me.cboFlujo.Query = ""
            Else
                Me.cboFlujo.Query = "select IdFlujoDoc as Flujo, Comentario, FechaInicia as Fecha, IdPoliza as [Póliza], NombreCliente as Cliente from FlujosDocumentos where (estadoflujo = 'PENDIENTE' " & strCliente & ") "
            End If
            Me.cboFlujo.Llenar_Combo()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFlujo_NewItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFlujo.NewItem
        Try
            Dim frmNF As New NuevoFlujo
            frmNF.STIConn = StiGlobalConn
            frmNF.Permiso = Me.Permiso
            frmNF.IdClienteDefault = ObtenerIdCliente()
            frmNF.ObservacionDefault = ""
            frmNF.ShowDialog()

            'actualizamos la lista de flujos
            Me.cboFlujo.Llenar_Combo()

            'PROPONEMOS EL PRIMER FLUJO
            cboFlujo.Valor = ""
            If IdNuevoFlujo <> "" Then
                cboFlujo.Valor = IdNuevoFlujo
            End If
            If cboFlujo.ItemCount = 1 And cboFlujo.Valor <> "" Then Me.cboFlujo.SelectIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerIdCliente() As String
        Dim res As String = ""
        Try
            For I As Integer = 0 To Me.VistaFacturas.DataRowCount - 1
                If VistaFacturas.GetRowCellValue(I, "Pagar") = True Then
                    res = VistaFacturas.GetRowCellValue(I, "IdCliente")
                    Exit For
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Private Sub chkImprimirCartas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImprimirCartas.CheckedChanged
        Select Case GlobalCodCliente
            Case "2120000"
                If chkImprimirCartas.Checked = True Then
                    cboFlujo.Obligatorio = True
                Else
                    cboFlujo.Obligatorio = False
                End If
        End Select
    End Sub

End Class
