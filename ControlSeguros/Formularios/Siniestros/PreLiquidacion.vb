Imports Utilerias.Genericas

Public Class PreLiquidacion
    Dim dtDatos As DataTable
    Dim Calculando As Boolean = False

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim fbus As New BusquedaCertReclamo
            fbus.dbFiltro = ""
            fbus.ShowDialog()

            If busCodigo <> "" Then
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
                txtNombreContratante.Valor = stiSplit(busCodigo, "G4|1")
                txtAsegurado.Valor = stiSplit(busCodigo, "G5|1")

                'buscaremos la vigencia del certificado
                Try
                    Dim FilCert As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta from PolizasCertificados where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0).Rows(0)
                    Me.txtVigenciaDesde.Valor = dbData(FilCert, "VigenciaDesde")
                    Me.txtVigenciaHasta.Valor = dbData(FilCert, "VigenciaHasta")
                Catch ex As Exception

                End Try
                Me.txtFechaSiniestro.Valor = Date.Today
                Me.cboTipoReclamo.Valor = "P"

                Call PrepararLiquidacion()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PreLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()

        Me.cboTipoReclamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboTipoReclamo.Llenar_Combo()

        dtDatos = New DataTable
        dtDatos.Columns.Add("Orden", System.Type.GetType("System.Int32"))
        dtDatos.Columns.Add("Tipo", System.Type.GetType("System.String"))
        dtDatos.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        dtDatos.Columns.Add("Valor", System.Type.GetType("System.Double"))
        dtDatos.TableName = "PreLiquidaciones"

        Me.gridLiquidacion.DataSource = dtDatos

    End Sub

    Private Sub PrepararLiquidacion()
        Try
            gridLiquidacion.DataSource = Nothing

            dtDatos.Rows.Clear()
            Dim Fila As DataRow

            Dim FilaCertificado As DataRow = Nothing
            Try
                FilaCertificado = StiGlobalConn.ObtenerDataset("select ValorAsegurado, Deducible, Participacion, PorceDepreciacion from PolizasCertificados where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0).Rows(0)
            Catch ex As Exception

            End Try
            Dim Orden As Integer = 0, Valor As Double = 0, Saldo As Double = 0

            Me.txtDeducible.Valor = dbData(FilaCertificado, "Deducible")
            Me.txtParticipacion.Valor = dbData(FilaCertificado, "Participacion")
            Me.txtDepreciacion.Valor = dbData(FilaCertificado, "PorceDepreciacion")

            '1 - suma asegurada
            Fila = dtDatos.NewRow : Orden += 1
            Fila("Orden") = Orden : Fila("Tipo") = "+" : Fila("Descripcion") = "Suma Asegurada" : Fila("Valor") = Val(FilaCertificado("ValorAsegurado"))
            dtDatos.Rows.Add(Fila)
            Saldo = Val(FilaCertificado("ValorAsegurado"))

            '2 - Si es automoviles se deprecia
            Dim Ramo As String = ""
            Try
                Ramo = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Ramo = ""
            End Try
            If Ramo = "501" Then
                Fila = dtDatos.NewRow : Orden += 1
                Fila("Orden") = Orden : Fila("Tipo") = "-" : Fila("Descripcion") = "(-) Depreciación" : Fila("Valor") = 0
                dtDatos.Rows.Add(Fila)
                Saldo -= Valor
            End If

            '3 - Deducible 
            If IsNumeric(dbData(FilaCertificado, "Deducible")) = True Then
                Double.TryParse(dbData(FilaCertificado, "Deducible"), Valor)
            Else
                Valor = 0
            End If
            Fila = dtDatos.NewRow : Orden += 1
            Fila("Orden") = Orden : Fila("Tipo") = "-" : Fila("Descripcion") = "(-) Deducible" : Fila("Valor") = Valor
            dtDatos.Rows.Add(Fila)
            Saldo -= Valor

            '4 - Participación
            If IsNumeric(dbData(FilaCertificado, "Participacion")) = True Then
                Double.TryParse(dbData(FilaCertificado, "Participacion"), Valor)
                Valor = Saldo * (Valor / 100)
            Else
                Valor = 0
            End If

            Fila = dtDatos.NewRow : Orden += 1
            Fila("Orden") = Orden : Fila("Tipo") = "-" : Fila("Descripcion") = "(-) Participación" : Fila("Valor") = Valor
            dtDatos.Rows.Add(Fila)
            Saldo -= Valor

            '5- subtotal
            Fila = dtDatos.NewRow : Orden += 1
            Fila("Orden") = Orden : Fila("Tipo") = "T" : Fila("Descripcion") = "Valor Indemnización" : Fila("Valor") = Saldo
            dtDatos.Rows.Add(Fila)

            '6 - Primas Pendientes del certificado
            Dim sql As String = ""

            sql = "  select isnull(sum(m.Total),0)"
            sql &= " from Facturas as f"
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo "
            sql &= " inner join Polizas as p on p.idpoliza = f.idpoliza and p.idproducto = f.idproducto"
            sql &= " where f.IdProducto = " & dbStr(cboIdProducto.Valor) & " and f.IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and m.tipomovimiento in ('EMISION', 'ANULACION') "
            sql &= " and f.FechaPago >= p.VigenciaDesde  and f.FechaPago < p.VigenciaHasta"
            Dim TotalPrima As Double = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

            sql = "  select isnull(sum(m.Total),0)"
            sql &= " from Facturas as f"
            sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo "
            sql &= " inner join Polizas as p on p.idpoliza = f.idpoliza and p.idproducto = f.idproducto"
            sql &= " where f.IdProducto = " & dbStr(cboIdProducto.Valor) & " and f.IdPoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and f.FechaPago >= p.VigenciaDesde  and f.FechaPago < p.VigenciaHasta"
            Dim PrimaPendiente As Double = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

            sql = "  select Total"
            sql &= " from PolizasCertificados"
            sql &= " where IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim PrimaCert As Double = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0).Item(0)

            'aplicamos una regla de 3
            Try
                If TotalPrima = 0 Then
                    Valor = 0
                Else
                    Valor = PrimaCert * (PrimaPendiente / TotalPrima)
                End If

            Catch ex As Exception
                Valor = 0
            End Try

            Fila = dtDatos.NewRow : Orden += 1
            Fila("Orden") = Orden : Fila("Tipo") = "-" : Fila("Descripcion") = "(-) Primas Pendientes" : Fila("Valor") = Valor
            dtDatos.Rows.Add(Fila)

            Saldo -= Valor
            If Ramo = "501" Then
                Fila = dtDatos.NewRow : Orden += 1
                dim Traspaso as double = stiglobalconn.obtenerdataset("select isnull(a.CostoTraspaso,0) from Aseguradoras as a inner join productos as p on a.idaseguradora = p.idaseguradora and p.idproducto = " & dbstr(me.cboidproducto.valor)).Tables(0).rows(0).item(0)
                Fila("Orden") = Orden : Fila("Tipo") = "-" : Fila("Descripcion") = "(-) Gastos de traspaso" : Fila("Valor") = Traspaso
                dtDatos.Rows.Add(Fila)
                Saldo -= Traspaso
            End If

            '5- Pago Neto
            Fila = dtDatos.NewRow : Orden += 1
            Fila("Orden") = Orden : Fila("Tipo") = "T" : Fila("Descripcion") = "Pago Neto" : Fila("Valor") = Saldo
            dtDatos.Rows.Add(Fila)


            gridLiquidacion.DataSource = dtDatos
            gridLiquidacion.Refresh()

            Call CalcularDepreciacion()
            Call Me.RecalcularLiquidacion()

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub RecalcularLiquidacion()
        Try
            Calculando = True
            Dim Saldo As Double = 0, Valor As Double = 0, Tipo As String = ""
            For NF As Integer = 0 To Me.VistaLiquidacion.DataRowCount - 1
                Tipo = VistaLiquidacion.GetRowCellValue(NF, "Tipo")
                Valor = VistaLiquidacion.GetRowCellValue(NF, "Valor")
                Select Case Tipo
                    Case "+"
                        Saldo += Valor
                    Case "-"
                        Saldo -= Valor
                    Case "T"
                        VistaLiquidacion.SetRowCellValue(NF, "Valor", Saldo)
                End Select
            Next
        Catch ex As Exception

        Finally
            Calculando = False
        End Try
    End Sub

    Private Sub VistaLiquidacion_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaLiquidacion.CellValueChanged
        If Calculando = False Then
            Me.VistaLiquidacion.PostEditor()
            Call RecalcularLiquidacion()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnQuitarGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGastos.Click
        Try
            VistaLiquidacion.DeleteRow(VistaLiquidacion.FocusedRowHandle)
            're-enumeramos
            For NF As Integer = 0 To Me.VistaLiquidacion.DataRowCount - 1
                Me.VistaLiquidacion.SetRowCellValue(NF, "Orden", NF + 1)
            Next

            VistaLiquidacion.GridControl.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGasto.Click
        Try
            dtDatos = gridLiquidacion.DataSource
            gridLiquidacion.DataSource = Nothing

            Dim Fila As DataRow = dtDatos.NewRow
            dtDatos.Rows(dtDatos.Rows.Count - 1).Item("Orden") = dtDatos.Rows.Count + 1
            Fila("Orden") = dtDatos.Rows.Count : Fila("Tipo") = "-" : Fila("Descripcion") = "(-) " : Fila("Valor") = 0
            dtDatos.Rows.Add(Fila)

            gridLiquidacion.DataSource = dtDatos
            gridLiquidacion.Refresh()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCertificado.Click
        Try
            
            Dim Poliza As String = Me.txtIdPoliza.Valor
            Dim Producto As String = Me.cboIdProducto.Valor
            Dim Certificado As String = Me.txtIdCertificado.Valor

            Dim FCERTIF As New PolizasCertificadosMan
            FCERTIF.Permiso = Me.Permiso
            FCERTIF.STIConn = StiGlobalConn
            FCERTIF.dbTabla = "PolizasCertificados"
            FCERTIF.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto) & " and IdCertificado = " & dbStr(Certificado)
            FCERTIF.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            'generamos el reporte de la pre-liquidación
            Dim sql As String = ""

            sql = "  select "
            sql &= " " & dbStr(txtIdPoliza.Valor) & " as IdPoliza"
            sql &= ", " & dbStr(cboIdProducto.Valor) & " as IdProducto"
            sql &= ", " & dbStr(txtIdCertificado.Valor) & " as IdCertificado"
            sql &= ", '1' as IdSiniestro"
            sql &= ", " & dbStr(cboIdProducto.Descripcion) & " as Producto"
            sql &= ", " & dbStr(txtNombreContratante.Valor) & " as Contratante"
            sql &= ", " & dbStr(txtAsegurado.Valor) & " as Asegurado"
            sql &= ", cast(" & dbFec(txtVigenciaDesde.Valor) & " as datetime) as VigenciaDesde"
            sql &= ", cast(" & dbFec(txtVigenciaHasta.Valor) & " as datetime) as VigenciaHasta"
            sql &= ", cast(" & dbFec(txtFechaSiniestro.Valor) & " as datetime) as FechaOcurrido"
            sql &= ", " & dbStr(cboTipoReclamo.Descripcion) & " as DescripcionSiniestro"
            Dim dtSiniestro As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestro.TableName = "Siniestros"


            sql = " select"
            sql &= " IdPoliza, IdProducto, IdCertificado, IdBien as Orden"
            sql &= " ,NombreBien as Descripcion, DescripcionBien as Detalle"
            sql &= " from PolizasBienes "
            sql &= " where idpoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and NombreBien is not null and DescripcionBien is not null and len(cast(DescripcionBien as varchar(3000))) > 0"
            Dim DtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            DtBienes.TableName = "BienesAsegurados"


            Dim DtGastos As New DataTable
            DtGastos.Columns.Add("IdPoliza", System.Type.GetType("System.String"))
            DtGastos.Columns.Add("IdProducto", System.Type.GetType("System.String"))
            DtGastos.Columns.Add("IdCertificado", System.Type.GetType("System.String"))
            DtGastos.Columns.Add("IdSiniestro", System.Type.GetType("System.String"))
            DtGastos.Columns.Add("Orden", System.Type.GetType("System.Int32"))
            DtGastos.Columns.Add("Gasto", System.Type.GetType("System.String"))
            DtGastos.Columns.Add("Presentado", System.Type.GetType("System.Double"))
            DtGastos.TableName = "Gastos"
            Dim Fila As DataRow = Nothing

            For NF As Integer = 0 To VistaLiquidacion.DataRowCount - 1
                Fila = DtGastos.NewRow
                Fila("IdPoliza") = txtIdPoliza.Valor
                Fila("IdProducto") = cboIdProducto.Valor
                Fila("IdCertificado") = txtIdCertificado.Valor
                Fila("IdSiniestro") = "1"
                Fila("Orden") = VistaLiquidacion.GetRowCellValue(NF, "Orden")
                Fila("Gasto") = VistaLiquidacion.GetRowCellValue(NF, "Descripcion")
                Fila("Presentado") = VistaLiquidacion.GetRowCellValue(NF, "Valor")

                DtGastos.Rows.Add(Fila)
            Next

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestro.Copy)
            DsRep.Tables.Add(DtBienes.Copy)
            DsRep.Tables.Add(DtGastos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repCRPreLiquidacion
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Detalle de Pre-Liquidación de Reclamos")
            SetRepFormulaString(Reporte, "Titulo2", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "Titulo3", "")

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub CalcularDepreciacion()
        If Me.txtDepreciacion.Text <> "" And Me.txtFechaSiniestro.Text <> "" And Me.txtVigenciaDesde.Text <> "" Then
            Try
                Dim valDepreciacion As Double = 0
                Dim Porce As Double = Val(txtDepreciacion.Valor)
                Dim Suma As Double = ObtenerValorGrid("Suma Asegurada")
                Dim Meses As Integer = Math.Ceiling(Math.Abs(DateDiff(DateInterval.Day, Me.txtFechaSiniestro.Valor, Me.txtVigenciaDesde.Valor)) / 30)

                valDepreciacion = Suma * (Porce / 100) * Meses
                EstablecerValorGrid("(-) Depreciación", valDepreciacion)

                Call RecalcularLiquidacion()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Function ObtenerValorGrid(ByVal Clave As String) As Double
        Dim res As Double = 0
        Try
            For NF As Integer = 0 To Me.VistaLiquidacion.DataRowCount - 1
                If CStr(VistaLiquidacion.GetRowCellValue(NF, "Descripcion")).Trim.ToUpper = Clave.Trim.ToUpper Then
                    res = VistaLiquidacion.GetRowCellValue(NF, "Valor")
                    Exit For
                End If
            Next
        Catch ex As Exception
            res = 0
        End Try
        Return res
    End Function

    Private Sub EstablecerValorGrid(ByVal Clave As String, ByVal Valor As Double)
        Try
            For NF As Integer = 0 To Me.VistaLiquidacion.DataRowCount - 1
                If CStr(VistaLiquidacion.GetRowCellValue(NF, "Descripcion")).Trim.ToUpper = Clave.Trim.ToUpper Then
                    VistaLiquidacion.SetRowCellValue(NF, "Valor", Valor)
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDepreciacion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtDepreciacion.ValueChangeOnExit
        Call CalcularDepreciacion()
    End Sub

    Private Sub txtFechaSiniestro_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaSiniestro.ValueChangeOnExit
        Call CalcularDepreciacion()
    End Sub

    Private Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        Call CalcularDepreciacion()
    End Sub

    Private Sub txtDeducible_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtDeducible.ValueChangeOnExit
        Try
            'propondremos el valor en el cálculo
            Dim Deducible As Double = Val(txtDeducible.Valor)
            EstablecerValorGrid("(-) Deducible", Deducible)
            Call RecalcularLiquidacion()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtParticipacion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtParticipacion.ValueChangeOnExit
        Try
            Dim Porce As Double = Val(txtParticipacion.Valor)
            Dim Suma As Double = ObtenerValorGrid("Suma Asegurada")
            Dim Participacion As Double = 0

            Participacion = Math.Round(Suma * (Porce / 100), 2)
            EstablecerValorGrid("(-) Participación", Participacion)
            Call RecalcularLiquidacion()
        Catch ex As Exception

        End Try
    End Sub

End Class
