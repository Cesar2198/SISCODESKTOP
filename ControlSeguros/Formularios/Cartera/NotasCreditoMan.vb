Imports Utilerias.Genericas

Public Class NotasCreditoMan

    Dim IdMovimiento As Integer = -1
    Dim AplicarRetencionIva As String = ""

    Private Sub btnBuscarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim fbus As New BusquedaFacturas
        busCodigo = ""
        ''se pone menor que cero por que los pagos efectivos se almacenan en negativo para saldar la factura
        'los pagos positivos son anulaciones por devoluciones efectivas
        fbus.dbFiltro = " and (select sum(m1.Total) from FacturasMovimientos as m1 where m1.NumeroFactura = f.NumeroFactura and m1.IdProducto = f.IdProducto and m1.IdPoliza = f.IdPoliza and m1.IdRamo = f.IdRamo and m1.TipoMovimiento = 'PAGO' ) < 0 "
        fbus.ShowDialog()
        If busCodigo <> "" Then
            txtNumeroFactura.Valor = stiSplit(busCodigo, "G0|1")
            cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            txtIdPoliza.Valor = stiSplit(busCodigo, "G2|1")
            cboIdRamo.Valor = stiSplit(busCodigo, "G3|1")
            IdMovimiento = -1

            Try
                Dim filCliente As DataRow = StiGlobalConn.ObtenerDataset("select IdCliente, NombreCliente,AplicarRetencionIva from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0)
                Me.txtIdCliente.Valor = dbData(filCliente, "IdCliente")
                Me.txtNombreCliente.Valor = dbData(filCliente, "NombreCliente")
                AplicarRetencionIva = dbData(filCliente, "AplicarRetencionIva")
                Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                Me.cboFlujo.Llenar_Combo()
            Catch ex As Exception

            End Try

            Call ActualizarContactos()


            'como validación verificaremos que la factura tenga pago.
            Try
                Dim sql As String = ""
                sql = " select count(*) from FacturasMovimientos "
                sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and TipoMovimiento = 'PAGO' "
                Dim NumPago As Integer = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                If NumPago = 0 Then
                    MsgBox("La factura a la que le aplicará la nota de crédito no presenta pagos en el sistema, verifique que sea la factura correcta.", MsgBoxStyle.Exclamation, "ADVERTENCIA...")
                End If
            Catch ex As Exception

            End Try

            Me.txtFechaNotaCredito.Focus()

            'ahora calcularemos el % de comision de la factura en base a la emisión
            Try
                Me.txtPorcentajeComiFact.Valor = StiGlobalConn.ObtenerDataset("select PorceComision from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Me.txtPorcentajeComiFact.Valor = 0
            End Try
        End If
    End Sub

    Private Sub NotasCreditoMan_DespuesDeEliminar() Handles Me.DespuesDeEliminar
        'si se elimina la nota de cobertura debemos borrar el registro de anulación que se hizo en la factura
        Dim IdMovimiento As Integer = -1
        Dim sql As String = ""
        Try
            sql = " select IdMovimiento from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            sql &= " and FechaMovimiento = " & dbFec(txtFechaNotaCredito.Valor)
            sql &= " and TipoMovimiento = 'PAGO'"
            sql &= " and PrimaNeta = " & dbNum(txtPrimaNetaNota.Valor)
            IdMovimiento = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            IdMovimiento = -1
        End Try
        If IdMovimiento = -1 Then
            MsgBox("No se ha encontrado la anulación en la factura para poder ser revertido.", MsgBoxStyle.Information, "AVISO...")
        Else
            Try
                sql = " delete from FacturasMovimientos"
                sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and IdMovimiento = " & dbInt(IdMovimiento)
                StiGlobalConn.SQLExecute(sql)

                MsgBox("Se ha eliminado exitosamente la nota de crédito y el movimiento asociado en la factura.", MsgBoxStyle.Exclamation, "AVISO...")
            Catch ex As Exception

            End Try
        End If

        'TAMBIEN LA ANULACION
        IdMovimiento = -1
        Try
            sql = " select IdMovimiento from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            sql &= " and FechaMovimiento = " & dbFec(txtFechaNotaCredito.Valor)
            sql &= " and TipoMovimiento = 'ANULACION'"
            sql &= " and PrimaNeta = " & dbNum(txtPrimaNetaNota.Valor * -1)
            IdMovimiento = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            IdMovimiento = -1
        End Try
        If IdMovimiento = -1 Then
            MsgBox("No se ha encontrado la anulación en la factura para poder ser revertido.", MsgBoxStyle.Information, "AVISO...")
        Else
            Try
                sql = " delete from FacturasMovimientos"
                sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and IdMovimiento = " & dbInt(IdMovimiento)
                StiGlobalConn.SQLExecute(sql)

                'MsgBox("Se ha eliminado exitosamente la nota de crédito y el movimiento asociado en la factura.", MsgBoxStyle.Exclamation, "AVISO...")
            Catch ex As Exception

            End Try
        End If

        'vamos a descontar depósito si existe
        If Me.cboIdTipoIngreso.Valor = "A" Then
            Dim IdAseguradora As String = ""
            Try
                IdAseguradora = StiGlobalConn.ObtenerDataset("select idaseguradora from Productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                IdAseguradora = ""
            End Try
            Call Cartera_DescontarDeposito(txtIdCliente.Valor, Date.Today, txtTotalNota.Valor, "Anulación Nota Crédito:" & txtIdNotaCredito.Valor, IdAseguradora)
        End If
        IdMovimiento = -1
    End Sub

    Private Sub NotasCreditoMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        'ahora que ya se ha registrado la nota de cobertura, vamos a modificar el registro de pago
        Dim res As String = ""

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            'estos movimientos no los haremos si proviene de una existente
            If IdMovimiento = -1 Then
                'Para que la factura quede saldada a cero debemos ingresar una anulación
                res = Cartera_AnularFactura(txtNumeroFactura.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, txtFechaNotaCredito.Valor, txtPrimaNetaNota.Valor, txtGastosEmiNota.Valor, txtGastosFinNota.Valor, txtGastosBombNota.Valor, txtGastosNota.Valor, txtImpuestosNota.Valor, txtTotalNota.Valor, txtComisionNota.Valor, cboIdRamo.Valor, "Nota Crédito:" & txtObservaciones.Valor, Me.txtRetIva.Valor)
                If res <> "" Then
                    MsgBox("No es posible realizar la anulación de pago de la factura: " & txtNumeroFactura.Text & vbCrLf & res, MsgBoxStyle.Exclamation, "AVISO...")
                End If

                res = Cartera_AnularPago(txtNumeroFactura.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, txtFechaNotaCredito.Valor, txtPrimaNetaNota.Valor, txtGastosEmiNota.Valor, txtGastosFinNota.Valor, txtGastosBombNota.Valor, txtGastosNota.Valor, txtImpuestosNota.Valor, txtTotalNota.Valor, txtComisionNota.Valor, cboIdRamo.Valor, txtRetIva.Valor, "ANULACION DEPOSITO")
                'res = Cartera_AgregarPago(txtNumeroFactura.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, txtFechaNotaCredito.Valor, txtPrimaNetaNota.Valor, txtGastosEmiNota.Valor, txtGastosFinNota.Valor, txtGastosBombNota.Valor, txtGastosNota.Valor, txtImpuestosNota.Valor, txtTotalNota.Valor, txtComisionNota.Valor, cboIdRamo.Valor)
                If res <> "" Then
                    MsgBox("No es posible realizar la anulación de pago de la factura: " & txtNumeroFactura.Text & vbCrLf & res, MsgBoxStyle.Exclamation, "AVISO...")
                End If
            End If

            'ahora además vamos a registrar si el movimiento va a depósito
            If Me.cboIdTipoIngreso.Valor = "A" Then
                Dim IdAseguradora As String = ""
                Try
                    IdAseguradora = StiGlobalConn.ObtenerDataset("select idaseguradora from Productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdAseguradora = ""
                End Try

                Call Cartera_AgregarDeposito(txtIdCliente.Valor, Me.txtNombreCliente.Valor, "", Me.txtFechaNotaCredito.Valor, Me.txtTotalNota.Valor, "Nota de Crédito: " & Me.txtIdNotaCredito.Valor, IdAseguradora)
            End If
            'finalmente imprimimos
            Call btnImprimir_Click(Nothing, Nothing)
            IdMovimiento = -1
        End If
    End Sub

    Private Sub NotasCreditoMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                txtNumeroFactura.SoloLectura = True
                cboIdProducto.SoloLectura = True
                txtIdPoliza.SoloLectura = True
                cboIdRamo.SoloLectura = True
                txtPorcentajeComiFact.SoloLectura = True
                Me.btnGuardar.Enabled = True


                Me.txtPrimaNetaNota.Valor = 0
                Me.txtGastosEmiNota.Valor = 0
                Me.txtGastosFinNota.Valor = 0
                Me.txtGastosBombNota.Valor = 0
                Me.txtGastosNota.Valor = 0
                Me.txtImpuestosNota.Valor = 0
                txtRetIva.Valor = 0
                Me.txtTotalNota.Valor = 0
                Me.txtComisionNota.Valor = 0
                Me.txtPorcentajeComiFact.Valor = 0
                Me.btnImprimir.Enabled = False
                Me.txtFechaAnula.SoloLectura = True
                Me.btnAnular.Enabled = False

            Case Else
                Me.EstadoEntradas(False, Me)
                txtObservaciones.SoloLectura = False
                txtDescripcionReintegro.SoloLectura = False
                Me.cboFlujo.SoloLectura = False
                me.cboAtencionA.SoloLectura = False
                Me.btnGuardar.Enabled = True

                Try
                    Dim filCliente As DataRow = StiGlobalConn.ObtenerDataset("select IdCliente, NombreCliente,AplicarRetencionIva from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0)
                    Me.txtIdCliente.Valor = dbData(filCliente, "IdCliente")
                    Me.txtNombreCliente.Valor = dbData(filCliente, "NombreCliente")
                    AplicarRetencionIva = dbData(filCliente, "AplicarRetencionIva")
                    Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                    Me.cboFlujo.Llenar_Combo()
                Catch ex As Exception

                End Try

                Call ActualizarContactos()
                'cargamos el valor previamente guardado pues se pierde por que el combo se actualiza.
                Try
                    Dim IdContacto As String = StiGlobalConn.ObtenerDataset("select isnull(cast(idcontacto as varchar),'') from NotasCredito where IdNotaCredito = " & dbStr(Me.txtIdNotaCredito.Valor) & " and NumeroFactura = " & dbInt(Me.txtNumeroFactura.Valor)).Tables(0).Rows(0).Item(0)
                    Me.cboAtencionA.Valor = IdContacto
                Catch ex As Exception

                End Try


                if me.txtFechaAnula.Text <> "" then
                    'si ya esta anulado no se puede hacer ninguna operación
                    Me.EstadoEntradas(False, Me)
                    Me.btnNuevo.Enabled = False
                    Me.btnEliminar.Enabled = False
                    Me.btnGuardar.Enabled = False
                    Me.btnAnular.Enabled = False
                Else
                    Me.txtFechaAnula.SoloLectura = False
                    Me.cboIdTipoIngreso.SoloLectura = False
                End If



        End Select
        IdMovimiento = -1

        Try
            Dim Version As String = clSeguros.ObtenerVersion()
            Select Case Version
                Case "ESTANDAR", "DEMOPOL", "DEMOPOLCAR", "EMPCAJA"
                    Me.cboFlujo.Visible = False
                    me.cboAtencionA.Visible = False
            End Select
        Catch ex As Exception

        End Try

        Call ProcesarPermisosComision()
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                txtPorcentajeComiFact.Visible = False
                txtComisionNota.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtPrimaNetaNota_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPrimaNetaNota.ValueChangeOnExit
        Try
            Me.txtComisionNota.Valor = Math.Round(Me.txtPrimaNetaNota.Valor * (Me.txtPorcentajeComiFact.Valor / 100), 2)
        Catch ex As Exception

        End Try
        Call CalcularIva()
        Call CalcularTotal()
    End Sub

    Private Sub CalcularIva()
        Dim PorceIva As Double = clSeguros.ObtenerDBParametros("Porce.Iva")
        Dim PorceRetencionIva As Double = clSeguros.ObtenerDBParametros("Porce.Ret.Iva")
        Dim TipoProducto As String = ""
        Try
            TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            TipoProducto = ""
        End Try
        If TipoProducto <> "" Then
            If TipoProducto = "VIDA" Then
                txtImpuestosNota.Valor = Math.Round((Val(txtGastosEmiNota.Valor) + Val(txtGastosFinNota.Valor) + Val(txtGastosBombNota.Valor) + Val(txtGastosNota.Valor)) * (PorceIva / 100), 2)
            Else
                txtImpuestosNota.Valor = Math.Round((Val(txtPrimaNetaNota.Valor) + Val(txtGastosEmiNota.Valor) + Val(txtGastosFinNota.Valor) + Val(txtGastosBombNota.Valor) + Val(txtGastosNota.Valor)) * (PorceIva / 100), 2)
            End If

            If txtImpuestosNota.Valor <> 0 And AplicarRetencionIva = "S" Then
                If TipoProducto = "VIDA" Then
                    txtRetIva.Valor = Math.Round((Val(txtGastosEmiNota.Valor) + Val(txtGastosFinNota.Valor) + Val(txtGastosBombNota.Valor) + Val(txtGastosNota.Valor)) * (PorceRetencionIva / 100), 2)
                Else
                    txtRetIva.Valor = Math.Round((Val(txtPrimaNetaNota.Valor) + Val(txtGastosEmiNota.Valor) + Val(txtGastosFinNota.Valor) + Val(txtGastosBombNota.Valor) + Val(txtGastosNota.Valor)) * (PorceRetencionIva / 100), 2)
                End If
            End If
        End If
    End Sub

    Private Sub CalcularTotal()
        Me.txtTotalNota.Valor = txtPrimaNetaNota.Valor + Me.txtGastosEmiNota.Valor + Me.txtGastosFinNota.Valor + Me.txtGastosBombNota.Valor + Me.txtGastosNota.Valor + Me.txtImpuestosNota.Valor - Me.txtRetIva.Valor
    End Sub

    Private Sub txtGastosEmiNota_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosEmiNota.ValueChangeOnExit
        Call CalcularIva()
        Call CalcularTotal()
    End Sub

    Private Sub txtGastosFinNota_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosFinNota.ValueChangeOnExit
        Call CalcularIva()
        Call CalcularTotal()
    End Sub

    Private Sub txtGastosBombNota_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosBombNota.ValueChangeOnExit
        Call CalcularIva()
        Call CalcularTotal()
    End Sub

    Private Sub txtGastosNota_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosNota.ValueChangeOnExit
        Call CalcularIva()
        Call CalcularTotal()
    End Sub

    Private Sub txtImpuestosNota_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtImpuestosNota.ValueChangeOnExit
        Call CalcularTotal()
    End Sub

    Private Sub txtRetIva_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtRetIva.ValueChangeOnExit
        Call CalcularTotal()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            'imprimiremos la nota de cobertura como un recibo
            Dim sql As String = ""

            sql = "  select n.IdNotaCredito"
            sql &= " , n.NumeroFactura"
            sql &= " , p.Descripcion as IdProducto"
            sql &= " , n.IdPoliza"
            sql &= " , n.IdRamo"
            sql &= " , n.PrimaNetaNota"
            sql &= " , n.GastosEmiNota"
            sql &= " , n.GastosFinNota"
            sql &= " , n.GastosBombNota"
            sql &= " , n.GastosNota"
            sql &= " , n.ImpuestosNota"
            sql &= " , n.TotalNota"
            sql &= " , n.Observaciones"
            sql &= " , n.FechaNotaCredito"
            sql &= " , n.ComisionNota"
            sql &= " , n.PorcentajeComiFact"
            sql &= " , n.IdTipoIngreso"
            sql &= " , n.DescripcionReintegro"
            sql &= " , f.IdCliente "
            sql &= " , f.NombreCliente"
            sql &= " , f.Referencia"
            sql &= " from NotasCredito as n"
            sql &= " inner join Productos as p on n.idproducto = p.idproducto "
            sql &= " inner join Facturas as f on f.NumeroFactura = n.NumeroFactura and f.IdProducto = n.IdProducto and f.IdPoliza = n.IdPoliza and f.IdRamo = n.IdRamo"
            sql &= " where IdNotaCredito = " & dbStr(Me.txtIdNotaCredito.Valor)
            sql &= " and n.NumeroFactura = " & dbInt(Me.txtNumeroFactura.Valor)
            sql &= " and n.IdProducto = " & dbStr(Me.cboIdProducto.Valor)
            sql &= " and n.IdPoliza = " & dbStr(Me.txtIdPoliza.Valor)
            sql &= " and n.IdRamo = " & dbStr(Me.cboIdRamo.Valor)

            Dim dtNota As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtNota.TableName = "NotasCredito"

            Dim idAtencion As String = cboAtencionA.Valor, NombreAtt As String = "", CargoAtt As String = "", TitAtt As String = ""
            If idAtencion <> "" Then
                TitAtt = "Atención: "
                NombreAtt = cboAtencionA.ValorColumna("Nombre")
                CargoAtt = cboAtencionA.ValorColumna("Cargo")
            End If


            Dim IdImpresion As String = ""
            Dim IdFlujoDoc = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
            If Me.cboFlujo.Valor <> "" Then IdFlujoDoc = Me.cboFlujo.Valor
            Dim Claves As String = txtIdNotaCredito.Text & ", " & txtIdPoliza.Text
            Dim DireccionCli As String = ""
            If IdFlujoDoc <> "" Then
                Try
                    DireccionCli = StiGlobalConn.ObtenerDataset("select top 1 Direccion from ClientesContactos where idcliente = " & dbStr(dbData(dtNota.Rows(0), "IdCliente")) & " order by idcontacto asc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    DireccionCli = ""
                End Try
                Call clFlujos.RegistrarDocumento(IdFlujoDoc, "Nota de Crédito", dbData(dtNota.Rows(0), "IdCliente"), Claves, "SALIDA", IdImpresion, "", txtFechaNotaCredito.Valor, "", DireccionDocumento:=DireccionCli, CodigoImpresionDocumento:="NCRED", NombreAtt:=NombreAtt)
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set usuarioimprime = (select top 1 IdUsuarioDestino from FlujosDocumentos where IdFlujoDoc = " & dbstr(IdFlujoDoc) & ") where IdFlujoDoc = " & dbstr(IdFlujoDoc) & " and IdImpresion = " & dbstr(IdImpresion))

                'marcamos para rutear
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set FechaEnvio = null, IdZona = null, Courier = null, NombreDestinatario = " & dbStr(txtNombreCliente.Text, 150) & ", IdOrigen = " & dbStr(txtNombreCliente.Text, 150) & " where IdFlujoDoc = " & dbStr(IdFlujoDoc) & " and IdImpresion = " & dbStr(IdImpresion))

            End If
            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtNota.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repNotaCredito
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.NotaCredito"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.NotaCredito"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "CodCorrespondencia", IdImpresion)
            SetRepFormulaString(Reporte, "AtencionTitulo", TitAtt)
            SetRepFormulaString(Reporte, "AtencionNombre", NombreAtt)
            SetRepFormulaString(Reporte, "AtencionCargo", CargoAtt)


            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnAnulacionExiste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnulacionExiste.Click
        Dim fbus As New BusquedaFacturasMovimientos
        busCodigo = ""
        ''se pone menor que cero por que los pagos efectivos se almacenan en negativo para saldar la factura
        'los pagos positivos son anulaciones por devoluciones efectivas
        'fbus.dbFiltro = " and (select sum(Total) from FacturasMovimientos as m1 where m1.NumeroFactura = f.NumeroFactura and m1.IdProducto = f.IdProducto and m1.IdPoliza = f.IdPoliza and m1.IdRamo = f.IdRamo and m1.TipoMovimiento = 'PAGO' ) < 0 and m.TipoMovimiento = 'PAGO' and m.Total > 0 "
        'el query anterior no permite hacer la notta de crédito cuando ya ACSA aplica una devoluvion total de una factura.

        fbus.dbFiltro = " and m.TipoMovimiento = 'PAGO' and m.Total > 0 "


        fbus.ShowDialog()
        If busCodigo <> "" Then
            txtNumeroFactura.Valor = stiSplit(busCodigo, "G0|1")
            cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            txtIdPoliza.Valor = stiSplit(busCodigo, "G2|1")
            cboIdRamo.Valor = stiSplit(busCodigo, "G3|1")
            IdMovimiento = CInt(stiSplit(busCodigo, "G4|1"))

            Try
                Dim filCliente As DataRow = StiGlobalConn.ObtenerDataset("select IdCliente, NombreCliente from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0)
                Me.txtIdCliente.Valor = dbData(filCliente, "IdCliente")
                Me.txtNombreCliente.Valor = dbData(filCliente, "NombreCliente")
            Catch ex As Exception

            End Try

            Call ActualizarContactos()


            'como validación verificaremos que la factura tenga pago.
            Try
                Dim sql As String = ""
                sql = " select count(*) from FacturasMovimientos "
                sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and TipoMovimiento = 'PAGO' "
                Dim NumPago As Integer = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                If NumPago = 0 Then
                    MsgBox("La factura a la que le aplicará la nota de crédito no presenta pagos en el sistema, verifique que sea la factura correcta.", MsgBoxStyle.Exclamation, "ADVERTENCIA...")
                End If
            Catch ex As Exception

            End Try

            'obtendremos los valores de los movimientos.
            Try
                Dim filMov As DataRow = StiGlobalConn.ObtenerDataset("select * from FacturasMovimientos where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor) & " and IdMovimiento = " & dbInt(IdMovimiento)).Tables(0).Rows(0)
                txtFechaNotaCredito.Valor = dbData(filMov, "FechaMovimiento")
                txtPrimaNetaNota.Valor = dbData(filMov, "PrimaNeta")
                txtGastosEmiNota.Valor = dbData(filMov, "GastosEmision")
                txtGastosFinNota.Valor = dbData(filMov, "GastosFracciona")
                txtGastosBombNota.Valor = dbData(filMov, "GastosBomberos")
                txtGastosNota.Valor = dbData(filMov, "Gastos")
                txtImpuestosNota.Valor = dbData(filMov, "Impuestos")
                txtRetIva.Valor = dbData(filMov, "RetencionImpuestos")
                txtTotalNota.Valor = dbData(filMov, "Total")
                txtComisionNota.Valor = dbData(filMov, "Comision")
            Catch ex As Exception

            End Try

            Me.txtObservaciones.Focus()

            'ahora calcularemos el % de comision de la factura en base a la emisión
            Try
                Me.txtPorcentajeComiFact.Valor = StiGlobalConn.ObtenerDataset("select PorceComision from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Me.txtPorcentajeComiFact.Valor = 0
            End Try
        End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        if txtFechaAnula.Text = "" then
            MsgBox("Debe especificar la fecha de anulación.", MsgBoxStyle.Exclamation, "AVISO...")
            exit sub
        End If

        If MsgBox("¿Esta seguro que desea anular la nota de crédito?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        'si se elimina la nota de cobertura debemos borrar el registro de anulación que se hizo en la factura
        Dim IdMovimiento As Integer = -1
        Dim sql As String = ""

        sql = " update NotasCredito set FechaAnula = " & dbfec(txtFechaAnula.Valor) & " where IdNotaCredito = " & dbstr(me.txtIdNotaCredito.Valor) & " and NumeroFactura = " & dbint(me.txtNumeroFactura.Valor) & " and IdProducto = " & dbstr(me.cboIdProducto.Valor) & " and IdPoliza = " & dbstr(me.txtIdPoliza.Valor) & " and IdRamo = " & dbstr(cboIdRamo.Valor)
        StiGlobalConn.sqlexecute(sql)

        Try
            sql = " select IdMovimiento from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            sql &= " and FechaMovimiento = " & dbFec(txtFechaNotaCredito.Valor)
            sql &= " and TipoMovimiento = 'PAGO'"
            sql &= " and PrimaNeta = " & dbNum(txtPrimaNetaNota.Valor)
            IdMovimiento = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            IdMovimiento = -1
        End Try
        If IdMovimiento = -1 Then
            MsgBox("No se ha encontrado la anulación en la factura para poder ser anulado.", MsgBoxStyle.Information, "AVISO...")
        Else
            Try
                sql = " update FacturasMovimientos"
                sql &= " set PrimaNeta = 0"
                sql &= " , GastosEmision = 0"
                sql &= " , GastosFracciona = 0"
                sql &= " , GastosBomberos = 0"
                sql &= " , Gastos = 0"
                sql &= " , Impuestos = 0"
                sql &= " , Total = 0"
                sql &= " , Comision = 0"
                sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and IdMovimiento = " & dbInt(IdMovimiento)
                StiGlobalConn.SQLExecute(sql)
            Catch ex As Exception

            End Try
        End If

        'TAMBIEN LA ANULACION
        IdMovimiento = -1
        Try
            sql = " select IdMovimiento from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            sql &= " and FechaMovimiento = " & dbFec(txtFechaNotaCredito.Valor)
            sql &= " and TipoMovimiento = 'ANULACION'"
            sql &= " and PrimaNeta = " & dbNum(txtPrimaNetaNota.Valor * -1)
            IdMovimiento = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            IdMovimiento = -1
        End Try
        If IdMovimiento = -1 Then
            MsgBox("No se ha encontrado la anulación en la factura para poder ser revertido.", MsgBoxStyle.Information, "AVISO...")
        Else
            Try
                sql = " update FacturasMovimientos"
                sql &= " set PrimaNeta = 0"
                sql &= " , GastosEmision = 0"
                sql &= " , GastosFracciona = 0"
                sql &= " , GastosBomberos = 0"
                sql &= " , Gastos = 0"
                sql &= " , Impuestos = 0"
                sql &= " , Total = 0"
                sql &= " , Comision = 0"
                sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and IdMovimiento = " & dbInt(IdMovimiento)
                StiGlobalConn.SQLExecute(sql)
            Catch ex As Exception

            End Try
        End If

        'vamos a descontar depósito si existe
        If Me.cboIdTipoIngreso.Valor = "A" Then
            Dim IdAseguradora As String = ""
            Try
                IdAseguradora = StiGlobalConn.ObtenerDataset("select idaseguradora from Productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                IdAseguradora = ""
            End Try
            Call Cartera_DescontarDeposito(txtIdCliente.Valor, Date.Today, txtTotalNota.Valor, "Anulación Nota Crédito:" & txtIdNotaCredito.Valor, IdAseguradora)
        End If
        IdMovimiento = -1
        Me.blnRegistroModificado = False ' para que no avise 
        MsgBox("Se ha anulado exitosamente la nota de crédito y el movimiento asociado en la factura.", MsgBoxStyle.Exclamation, "AVISO...")

        me.Close()
    End Sub

    Private Sub ActualizarContactos()
        cboAtencionA.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Dim IdCliente As String = Me.txtIdCliente.Valor
        cboAtencionA.Query = "select c.idcontacto as Id, c.Nombre as Nombre, c.Cargo as Cargo from Clientes as l inner join ClientesContactos as c on c.idcliente = l.idcliente where l.IdTipoCliente <> 'NA' and l.idcliente = " & dbStr(IdCliente)
        cboAtencionA.Llenar_Combo()
    End Sub

    Private Sub cboFlujo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboFlujo.ValueChangeOnExit
        Select Case GlobalCodCliente
            Case "2120000"
                Try
                    If CStr(cboFlujo.Valor) <> "" Then
                        'verificamos si el flujo ya está asignado
                        Dim Asignado As String = StiGlobalConn.ObtenerDataset("select isnull(IdUsuarioDestino,'') from FlujosDocumentos where IdFlujoDoc = " & dbStr(cboFlujo.Valor)).Tables(0).Rows(0).Item(0)
                        If Asignado = "" Then
                            If MsgBox("El flujo seleccionado aún no ha sido asignado, ¿desea asignarlo en este momento? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "PREGUNTA...") = MsgBoxResult.Yes Then
                                Dim frmAsigna As New AsignarFlujoInd
                                frmAsigna.Permiso = Me.Permiso
                                frmAsigna.STIConn = Me.STIConn
                                frmAsigna.IdFlujoDoc = cboFlujo.Valor
                                frmAsigna.ShowDialog()
                            End If
                        End If

                        'volvemos a validar
                        Asignado = StiGlobalConn.ObtenerDataset("select isnull(IdUsuarioDestino,'') from FlujosDocumentos where IdFlujoDoc = " & dbStr(cboFlujo.Valor)).Tables(0).Rows(0).Item(0)
                        If Asignado = "" Then cboFlujo.Valor = ""
                    End If
                Catch ex As Exception

                End Try
        End Select
        
    End Sub


End Class
