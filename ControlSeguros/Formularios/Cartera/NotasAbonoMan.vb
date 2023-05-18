Imports Utilerias.Genericas

Public Class NotasAbonoMan

    Dim AplicarRetencionIva As String = ""

    Private Sub btnBuscarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim fbus As New BusquedaFacturas
        busCodigo = ""
        ''se pone menor que cero por que los pagos efectivos se almacenan en negativo para saldar la factura
        'que no tengan pago
        fbus.dbFiltro = " and (select isnull(sum(Total),0) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo and m.TipoMovimiento = 'PAGO' ) = 0"
        fbus.ShowDialog()
        If busCodigo <> "" Then
            txtNumeroFactura.Valor = stiSplit(busCodigo, "G0|1")
            cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            txtIdPoliza.Valor = stiSplit(busCodigo, "G2|1")
            cboIdRamo.Valor = stiSplit(busCodigo, "G3|1")

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


            'como validación verificaremos que la factura no tenga pago.
            Try
                Dim sql As String = ""
                sql = " select count(*) from FacturasMovimientos "
                sql &= " where NumeroFactura = " & dbInt(txtNumeroFactura.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
                sql &= " and TipoMovimiento = 'PAGO' "
                Dim NumPago As Integer = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)
                If NumPago > 0 Then
                    MsgBox("La factura a la que le aplicará la nota de abono ya presenta pagos en el sistema, verifique que sea la factura correcta.", MsgBoxStyle.Exclamation, "ADVERTENCIA...")
                End If
            Catch ex As Exception

            End Try

            Me.txtFechaNotaAbono.Focus()

            'ahora calcularemos el % de comision de la factura en base a la emisión
            Try
                Me.txtPorcentajeComiFact.Valor = StiGlobalConn.ObtenerDataset("select PorceComision from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Me.txtPorcentajeComiFact.Valor = 0
            End Try
        End If
    End Sub

    Private Sub NotasAbonoMan_DespuesDeEliminar() Handles Me.DespuesDeEliminar
        'si se elimina la nota de cobertura debemos borrar el registro de anulación que se hizo en la factura
        Dim IdMovimiento As Integer = -1
        Dim sql As String = ""
        Try
            sql = " select IdMovimiento from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            sql &= " and FechaMovimiento = " & dbFec(txtFechaNotaAbono.Valor)
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

                MsgBox("Se ha eliminado exitosamente la nota de abono y el movimiento asociado en la factura.", MsgBoxStyle.Exclamation, "AVISO...")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub NotasAbonoMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        'ahora que ya se ha registrado la nota de cobertura, vamos a modificar el registro de pago
        Dim res As String = ""
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            res = Cartera_AnularFactura(txtNumeroFactura.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, txtFechaNotaAbono.Valor, txtPrimaNetaNota.Valor, txtGastosEmiNota.Valor, txtGastosFinNota.Valor, txtGastosBombNota.Valor, txtGastosNota.Valor, txtImpuestosNota.Valor, txtTotalNota.Valor, txtComisionNota.Valor, cboIdRamo.Valor, Me.txtObservaciones.Valor, txtRetIva.Valor)
            If res <> "" Then
                MsgBox("No es posible realizar la anulación de la factura: " & txtNumeroFactura.Text & vbCrLf & res, MsgBoxStyle.Exclamation, "AVISO...")
            End If
        End If
    End Sub

    Private Sub NotasAbonoMan_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        'finalmente imprimimos
        Call btnImprimir_Click(Nothing, Nothing)
    End Sub

    Private Sub NotasAbonoMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                Me.txtRetIva.Valor = 0
                Me.txtTotalNota.Valor = 0
                Me.txtComisionNota.Valor = 0
                Me.txtPorcentajeComiFact.Valor = 0
                Me.btnImprimir.Enabled = False

                Me.txtFechaAnula.SoloLectura = True
                Me.btnAnular.Enabled = False


            Case Else
                Me.EstadoEntradas(False, Me)
                Me.btnGuardar.Enabled = False
                Me.cboFlujo.SoloLectura = False
                Me.cboAtencionA.SoloLectura = False

                Try
                    Dim filCliente As DataRow = StiGlobalConn.ObtenerDataset("select IdCliente, NombreCliente, AplicarRetencionIva from Facturas where NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)).Tables(0).Rows(0)
                    Me.txtIdCliente.Valor = dbData(filCliente, "IdCliente")
                    Me.txtNombreCliente.Valor = dbData(filCliente, "NombreCliente")
                    AplicarRetencionIva = dbData(filCliente, "AplicarRetencionIva")
                    Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                    Me.cboFlujo.Llenar_Combo()
                Catch ex As Exception

                End Try

                If Me.txtFechaAnula.Text <> "" Then
                    'si ya esta anulado no se puede hacer ninguna operación
                    Me.EstadoEntradas(False, Me)
                    Me.btnNuevo.Enabled = False
                    Me.btnEliminar.Enabled = False
                    Me.btnGuardar.Enabled = False
                    Me.btnAnular.Enabled = False
                Else
                    Me.txtFechaAnula.SoloLectura = False
                    Me.txtNotas.SoloLectura = False
                    Me.txtObservaciones.SoloLectura = False
                    Me.btnGuardar.Enabled = True
                End If

                Call ActualizarContactos()

                'cargamos el valor previamente guardado pues se pierde por que el combo se actualiza.
                Try
                    Dim IdContacto As String = StiGlobalConn.ObtenerDataset("select isnull(cast(idcontacto as varchar),'') from NotasAbono where IdNotaAbono = " & dbStr(Me.txtIdNotaAbono.Valor) & " and NumeroFactura = " & dbInt(Me.txtNumeroFactura.Valor)).Tables(0).Rows(0).Item(0)
                    Me.cboAtencionA.Valor = IdContacto
                Catch ex As Exception

                End Try

        End Select

        Try
            Dim Version As String = clSeguros.ObtenerVersion()
            Select Case Version
                Case "ESTANDAR", "DEMOPOL", "DEMOPOLCAR", "EMPCAJA"
                    Me.cboFlujo.Visible = False
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
        End If
        If Me.txtImpuestosNota.Valor <> 0 And AplicarRetencionIva = "S" Then
            If TipoProducto = "VIDA" Then
                txtRetIva.Valor = Math.Round((Val(txtGastosEmiNota.Valor) + Val(txtGastosFinNota.Valor) + Val(txtGastosBombNota.Valor) + Val(txtGastosNota.Valor)) * (PorceRetencionIva / 100), 2)
            Else
                txtRetIva.Valor = Math.Round((Val(txtPrimaNetaNota.Valor) + Val(txtGastosEmiNota.Valor) + Val(txtGastosFinNota.Valor) + Val(txtGastosBombNota.Valor) + Val(txtGastosNota.Valor)) * (PorceRetencionIva / 100), 2)
            End If
        Else
            Me.txtRetIva.Valor = 0
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

            sql = "  select n.IdNotaAbono as IdNotaCredito"
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
            sql &= " , n.FechaNotaAbono as FechaNotaCredito"
            sql &= " , n.ComisionNota"
            sql &= " , n.PorcentajeComiFact"
            sql &= " , f.IdCliente "
            sql &= " , f.NombreCliente"
            sql &= " , f.Referencia"
            sql &= " , n.Notas"
            sql &= " from NotasAbono as n"
            sql &= " inner join Productos as p on n.idproducto = p.idproducto "
            sql &= " inner join Facturas as f on f.NumeroFactura = n.NumeroFactura and f.IdProducto = n.IdProducto and f.IdPoliza = n.IdPoliza and f.IdRamo = n.IdRamo"
            sql &= " where IdNotaAbono = " & dbStr(Me.txtIdNotaAbono.Valor)
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
            Dim DireccionCli As String = ""
            Dim IdFlujoDoc = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
            If Me.cboFlujo.Valor <> "" Then IdFlujoDoc = Me.cboFlujo.Valor
            Dim Claves As String = txtIdNotaAbono.Text & ", " & txtIdPoliza.Text
            If IdFlujoDoc <> "" Then
                Try
                    DireccionCli = StiGlobalConn.ObtenerDataset("select top 1 Direccion from ClientesContactos where idcliente = " & dbStr(dbData(dtNota.Rows(0), "IdCliente")) & " order by idcontacto asc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    DireccionCli = ""
                End Try
                Call clFlujos.RegistrarDocumento(IdFlujoDoc, "Nota de Abono", dbData(dtNota.Rows(0), "IdCliente"), Claves, "SALIDA", IdImpresion, "", txtFechaNotaAbono.Valor, "", DireccionDocumento:=DireccionCli, CodigoImpresionDocumento:="NABON", NombreAtt:=NombreAtt)
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set usuarioimprime = (select top 1 IdUsuarioDestino from FlujosDocumentos where IdFlujoDoc = " & dbstr(IdFlujoDoc) & ") where IdFlujoDoc = " & dbstr(IdFlujoDoc) & " and IdImpresion = " & dbstr(IdImpresion))

                'marcamos para rutear
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set FechaEnvio = null, IdZona = null, Courier = null, NombreDestinatario = " & dbStr(txtNombreCliente.Text, 150) & ", IdOrigen = " & dbStr(txtNombreCliente.Text, 150) & " where IdFlujoDoc = " & dbStr(IdFlujoDoc) & " and IdImpresion = " & dbStr(IdImpresion))

            End If
            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtNota.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repNotaAbono
            Reporte.SetDataSource(DsRep)
            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Gerente", ObtenerFirma("Firma.Nombre.NotaAbono"))
            SetRepFormulaString(Reporte, "CargoGerente", ObtenerFirma("Firma.Cargo.NotaAbono"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())
            SetRepFormulaString(Reporte, "CodCorrespondencia", IdImpresion)
            SetRepFormulaString(Reporte, "AtencionTitulo", TitAtt)
            SetRepFormulaString(Reporte, "AtencionNombre", NombreAtt)
            SetRepFormulaString(Reporte, "AtencionCargo", CargoAtt)



            rep.CRViewer.ReportSource = Reporte
            ''rep.MdiParent = Me
            rep.ShowDialog()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If txtFechaAnula.Text = "" Then
            MsgBox("Debe especificar la fecha de anulación.", MsgBoxStyle.Exclamation, "AVISO...")
            Exit Sub
        End If

        If MsgBox("¿Esta seguro que desea anular la nota de abono?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        'si se elimina la nota de cobertura debemos borrar el registro de anulación que se hizo en la factura
        Dim IdMovimiento As Integer = -1
        Dim sql As String = ""

        sql = " update NotasAbono set FechaAnula = " & dbFec(txtFechaAnula.Valor) & " where IdNotaAbono = " & dbStr(Me.txtIdNotaAbono.Valor) & " and NumeroFactura = " & dbInt(Me.txtNumeroFactura.Valor) & " and IdProducto = " & dbStr(Me.cboIdProducto.Valor) & " and IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdRamo = " & dbStr(cboIdRamo.Valor)
        StiGlobalConn.SQLExecute(sql)

        Try
            sql = " select IdMovimiento from FacturasMovimientos"
            sql &= " where NumeroFactura = " & dbNum(txtNumeroFactura.Valor)
            sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and IdRamo = " & dbStr(cboIdRamo.Valor)
            sql &= " and FechaMovimiento = " & dbFec(txtFechaNotaAbono.Valor)
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

                Me.blnRegistroModificado = False ' para que no avise 
                MsgBox("Se ha Anulado exitosamente la nota de abono y el movimiento asociado en la factura.", MsgBoxStyle.Exclamation, "AVISO...")
                Me.Close()

            Catch ex As Exception

            End Try
        End If


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
