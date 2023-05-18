
Imports Utilerias.Genericas

Public Class CertificadosCambiarNumero

    Private Sub CertificadosCambiarNumero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboEstadoCertificado.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboEstadoCertificado.Llenar_Combo()
        cboIdVendedor.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdVendedor.Llenar_Combo()
        cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboIdProducto.Llenar_Combo()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCertificado.Click
        If Me.txtbusPoliza.Text = "" And Me.txtBusCliente.Text = "" Then
            MsgBox("Debe especificar algún criterio de búsqueda.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Try
            Dim sql As String = ""
            sql = "    select p.IdProducto, a.Nombre as Aseguradora"
            sql &= ", d.Descripcion as Producto"
            sql &= ", p.IdPoliza as IdPoliza"
            sql &= ", c.IdCertificado as IdCertificado"
            sql &= ", c.VigenciaDesde as FechaVigenciaDesde"
            sql &= ", c.VigenciaHasta as FechaVigenciaHasta"
            sql &= ", p.NombreCliente as Contratante"
            sql &= ", c.NombreCliente as Asegurado"
            sql &= ", c.FechaExclusion as FechaExclusion"
            sql &= " from Polizas as p"
            sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza"
            sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora "
            sql &= " where p.idpoliza is not null"
            If Me.txtbusPoliza.Text <> "" Then
                sql &= " and p.idpoliza like " & dbStr("%" & txtbusPoliza.Valor & "%")
            End If
            If Me.txtBusCliente.Text <> "" Then
                sql &= " and ( ( "
                For np As Integer = 0 To CuentaCar(txtBusCliente.Valor, " ")
                    If np = 0 Then
                        sql &= " p.NombreCliente like " & dbStr("%" & stiSplit(txtBusCliente.Valor, "G" & np.ToString.Trim & " 1") & "%")
                    Else
                        sql &= " and p.NombreCliente like " & dbStr("%" & stiSplit(txtBusCliente.Valor, "G" & np.ToString.Trim & " 1") & "%")
                    End If
                Next

                sql &= " ) or ( "
                For np As Integer = 0 To CuentaCar(txtBusCliente.Valor, " ")
                    If np = 0 Then
                        sql &= " c.NombreCliente like " & dbStr("%" & stiSplit(txtBusCliente.Valor, "G" & np.ToString.Trim & " 1") & "%")
                    Else
                        sql &= " and c.NombreCliente like " & dbStr("%" & stiSplit(txtBusCliente.Valor, "G" & np.ToString.Trim & " 1") & "%")
                    End If
                Next

                sql &= " ) "
                sql &= " ) "
            End If

            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            gridCertificados.DataSource = dtDatos
            gridCertificados.Refresh()
            If dtDatos.Rows.Count = 0 Then
                MsgBox("No se encuentran certificados para los parámetros especificados.", MsgBoxStyle.Information, "AVISO...")
            Else
                Call vistaCertificados_RowClick(Nothing, Nothing)
            End If


        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub vistaCertificados_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles vistaCertificados.RowClick
        Try
            Dim IdProducto As String = Me.vistaCertificados.GetRowCellValue(vistaCertificados.FocusedRowHandle, "IdProducto")
            Dim IdPoliza As String = Me.vistaCertificados.GetRowCellValue(vistaCertificados.FocusedRowHandle, "IdPoliza")
            Dim IdCertificado As String = Me.vistaCertificados.GetRowCellValue(vistaCertificados.FocusedRowHandle, "IdCertificado")

            Call CargarDatosCertificado(IdProducto, IdPoliza, IdCertificado)
            txtIdCertificadoActual.Valor = IdCertificado
            txtIdCertificadoNuevo.Valor = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDatosCertificado(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdCertificado As String)
        Try
            Call CargarGeneralidades(IdProducto, IdPoliza, IdCertificado)
            Call CargarBienes(IdProducto, IdPoliza, IdCertificado)
            Call CargarReclamos(IdProducto, IdPoliza, IdCertificado)
            Call CargarBeneficiarios(IdProducto, IdPoliza, IdCertificado)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarGeneralidades(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdCertificado As String)
        Try
            Dim sql As String = ""
            sql = "    select * "
            sql &= " from PolizasCertificados"
            sql &= " where idproducto = " & dbStr(IdProducto)
            sql &= " and idpoliza = " & dbStr(IdPoliza)
            sql &= " and idcertificado = " & dbStr(IdCertificado)
            Dim filDato As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
            Call LlenarCampos(Me, filDato)
            txtIdCliente.Focus()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub LlenarCampos(ByRef Control As System.Windows.Forms.Control, ByRef Fila As DataRow)
        'recibimos la fila con los datos que se desean cargar
        For Each ControlL In Control.Controls
            Try
                If TypeOf ControlL Is STIControles.stiTextBox Or TypeOf ControlL Is STIControles.stiMemo Or TypeOf ControlL Is STIControles.stiComboBox Then
                    If ControlL.NombreCampo <> "" Then
                        ControlL.Valor = dbData(Fila, ControlL.NombreCampo)
                    End If
                Else
                    If ControlL.Controls.Count > 0 Then
                        LlenarCampos(ControlL, Fila)
                    End If
                End If
            Catch ex As Exception
                'no produciremos error
            End Try
        Next
    End Sub

    Private Sub CargarBienes(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdCertificado As String)
        Try
            Dim sql As String = ""
            sql = "    select "
            sql &= "   a.IdBien"
            sql &= " , a.NombreBien"
            sql &= " , a.DescripcionBien"
            sql &= " , a.SumaAsegurada"
            sql &= " , a.Prima"
            sql &= " from PolizasBienes as a "
            sql &= " where a.idproducto = " & dbStr(IdProducto)
            sql &= " and a.idpoliza = " & dbStr(IdPoliza)
            sql &= " and a.idcertificado = " & dbStr(IdCertificado)

            Dim dtBien As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridBienes.DataSource = dtBien
            GridBienes.Refresh()

            VistaBienes.OptionsBehavior.Editable = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarReclamos(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdCertificado As String)
        Try
            Dim sql As String = ""
            sql = "  select "
            sql &= " s.IdProducto"
            sql &= " ,o.Descripcion as Producto"
            sql &= " ,s.IdPoliza"
            sql &= " ,s.IdSiniestro"
            sql &= " ,s.FechaOcurrido as FechaOcurre"
            sql &= " ,s.EstadoSiniestro as Estado"
            sql &= " ,s.IdCertificado"
            sql &= " , isnull((select sum(d.ValorPresentado) from SiniestrosDetalle as d where d.idpoliza = s.idpoliza and d.idproducto = s.idproducto and d.idsiniestro = s.idsiniestro and d.idcertificado = s.idcertificado),0) as ValorPresenta"
            sql &= " , isnull((select sum(d.ValorReembolso) from SiniestrosPagos as d where d.idpoliza = s.idpoliza and d.idproducto = s.idproducto and d.idsiniestro = s.idsiniestro and d.idcertificado = s.idcertificado),0) as ValorPagado"
            sql &= " from Siniestros as s"
            sql &= " inner join PolizasCertificados as c on c.idproducto = s.idproducto and c.idpoliza = s.idpoliza and c.idcertificado = s.idcertificado"
            sql &= " inner join Productos as o on o.idproducto = c.idproducto"
            sql &= " where c.idproducto = " & dbStr(IdProducto)
            sql &= " and c.idpoliza = " & dbStr(IdPoliza)
            sql &= " and c.idcertificado = " & dbStr(IdCertificado)

            Dim dtSin As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridSiniestros.DataSource = dtSin
            GridSiniestros.Refresh()

            VistaSiniestros.OptionsBehavior.Editable = False


        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarBeneficiarios(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdCertificado As String)
        Try
            Dim sql As String = ""
            sql = "    select "
            sql &= "   a.IdCertificado"
            sql &= " , a.IdBeneficiario"
            sql &= " , a.NombreBeneficiario"
            sql &= " , a.Parentesco"
            sql &= " , a.FechaNacimiento"
            sql &= " , a.Porcentaje"
            sql &= " from PolizasBeneficiarios as a "
            sql &= " where a.idproducto = " & dbStr(IdProducto)
            sql &= " and a.idpoliza = " & dbStr(IdPoliza)
            sql &= " and a.idcertificado = " & dbStr(IdCertificado)

            Dim dtBene As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridBeneficiarios.DataSource = dtBene
            GridBeneficiarios.Refresh()

            VistaBeneficiarios.OptionsBehavior.Editable = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCambiarCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarCert.Click
        Try
            If Me.txtIdPoliza.Text = "" Or Me.cboIdProducto.Text = "" Or Me.txtIdCertificadoNuevo.Text = "" Or Me.txtIdCertificadoActual.Text = "" Then
                MsgBox("Debe especificar la póliza y el nuevo certificado a cambiar.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim intExiste As Integer = StiGlobalConn.ObtenerDataset("select count(*) from PolizasCertificados where IdProducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idcertificado = " & dbStr(txtIdCertificadoNuevo.Valor)).Tables(0).Rows(0).Item(0)
            If intExiste > 0 Then
                MsgBox("El nuevo certificado ya existe en el sistema, la operación no puede ser realizada.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If MsgBox("¿Esta seguro de cambiar el número de certificado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                Exit Sub
            End If

            'Lo que haremos es hacer una copia del certificado y luego borrarlo
            Me.Cursor = Cursors.WaitCursor : Application.DoEvents()
            Dim IdPoliza As String = txtIdPoliza.Valor
            Dim IdProducto As String = cboIdProducto.Valor
            Dim IdCertificadoAnterior As String = txtIdCertificadoActual.Valor
            Dim IdcertificadoNuevo As String = txtIdCertificadoNuevo.Valor

            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            Dim sql As String = ""

            '1) Hacemos una copia del certificado

            sql = " insert into PolizasCertificados "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, Deducible, Participacion, IdVendedor, UsuarioModifica, FechaModifica, PorceDescuento, ValorDescuento, PrimaBruta, IdPlan, PorceDepreciacion, IdCertificadoAseguradora, PrimaExenta, PrimaMinima) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, Deducible, Participacion, IdVendedor, UsuarioModifica, FechaModifica, PorceDescuento, ValorDescuento, PrimaBruta, IdPlan, PorceDepreciacion, IdCertificadoAseguradora, PrimaExenta, PrimaMinima"
            sql &= " from PolizasCertificados where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasBeneficiarios "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje"
            sql &= " from PolizasBeneficiarios where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasBienes "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima"
            sql &= " from PolizasBienes where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasCertificadosAnexos "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdAnexo, FechaAnexo, UsuarioAnexo, VigenciaDesde, VigenciaHasta, FechaIngreso, FechaExclusion, SumaAseguradaAnterior, SumaAseguradaNueva, PrimaAnexo) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdAnexo, FechaAnexo, UsuarioAnexo, VigenciaDesde, VigenciaHasta, FechaIngreso, FechaExclusion, SumaAseguradaAnterior, SumaAseguradaNueva, PrimaAnexo"
            sql &= " from PolizasCertificadosAnexos where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasCesiones "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones, Propietario) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones, Propietario"
            sql &= " from PolizasCesiones where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasCoberturas "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma, AplicarDescuento, Participacion, CoberturaAdicional, AplicarIva, PrimaMinima, PrimaMaxima, DeducibleMinimo, DeducibleMaximo, PorceDeducible, PrimaAnual) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma, AplicarDescuento, Participacion, CoberturaAdicional, AplicarIva, PrimaMinima, PrimaMaxima, DeducibleMinimo, DeducibleMaximo, PorceDeducible, PrimaAnual"
            sql &= " from PolizasCoberturas where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasCoberturasAdicional "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdCobertura, Descripcion"
            sql &= " from PolizasCoberturasAdicional where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into PolizasCoberturasAdicional "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdCobertura, Descripcion"
            sql &= " from PolizasCoberturasAdicional where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = " insert into Siniestros "
            sql &= "( IdPoliza, IdProducto, IdCertificado, IdSiniestro, FechaOcurrido, FechaPresentado, EstadoSiniestro, NombrePresentaReclamo, LugarSiniestros, DescripcionSiniestro, DescripcionReserva, TotalPresentado, TotalNoCubierto, TotalCubierto, TotalDeducible, TotalCoaseguro, TotalDeudores, TotalReembolso, TotalPendiente, IdSiniestroAseguradora, VigenciaDesde, VigenciaHasta, NombreBeneficiario, IdBien, IdEnvio, DeducibleLimite, DeducibleAcumulado, CoaseguroLimite, CoaseguroAcumulado, FechaActualizacion, EstadoUsuario, EjecutivoCta, EstadoSiniestroInterno, TipoSiniestro, AmbitoSiniestro, DescripcionLiquidacion, Diagnostico, UsuarioGrabacion, FechaAvisoCliente, FechaAvisoAseguradora, FechaSolicitaInspeccion, FechaInspeccion, FechaAjustadorReqDocs, FechaCienteEntregaDocs, FechaEnvioDocAseg, FechaRecibeConvAjuste, FechaEnvioClientreConvAju, FechaFirmaConvAjuste, FechaEnvioConvAseg, FechaAsegEntregaCheque, FechaEntregaCheque, FechaEntregaFiniquito, FechaEnvioFiniquitoAseg, FechaFinalReclamo, NombreTaller, NombreConductor, NombreCobAfecta) "
            sql &= " select IdPoliza, IdProducto, " & dbInt(IdcertificadoNuevo) & ", IdSiniestro, FechaOcurrido, FechaPresentado, EstadoSiniestro, NombrePresentaReclamo, LugarSiniestros, DescripcionSiniestro, DescripcionReserva, TotalPresentado, TotalNoCubierto, TotalCubierto, TotalDeducible, TotalCoaseguro, TotalDeudores, TotalReembolso, TotalPendiente, IdSiniestroAseguradora, VigenciaDesde, VigenciaHasta, NombreBeneficiario, IdBien, IdEnvio, DeducibleLimite, DeducibleAcumulado, CoaseguroLimite, CoaseguroAcumulado, FechaActualizacion, EstadoUsuario, EjecutivoCta, EstadoSiniestroInterno, TipoSiniestro, AmbitoSiniestro, DescripcionLiquidacion, Diagnostico, UsuarioGrabacion, FechaAvisoCliente, FechaAvisoAseguradora, FechaSolicitaInspeccion, FechaInspeccion, FechaAjustadorReqDocs, FechaCienteEntregaDocs, FechaEnvioDocAseg, FechaRecibeConvAjuste, FechaEnvioClientreConvAju, FechaFirmaConvAjuste, FechaEnvioConvAseg, FechaAsegEntregaCheque, FechaEntregaCheque, FechaEntregaFiniquito, FechaEnvioFiniquitoAseg, FechaFinalReclamo, NombreTaller, NombreConductor, NombreCobAfecta"
            sql &= " from Siniestros where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            '2) Tablas relacioandas las cambiamos al nuevo certificado

            sql = "update EnviosSiniestrosDetalle set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update Gestiones set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update PreAutorizaciones set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosDetalle set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosDeudores set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosDocumentos set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosInformacion set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosPagos set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosRequisitos set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "update SiniestrosReservas set idcertificado = " & dbStr(IdcertificadoNuevo) & " where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)


            '3) Borramos el certificado actual

            sql = "delete from Siniestros where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasBeneficiarios where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasBienes where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasCertificadosAnexos where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasCesiones where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasCoberturas where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasCoberturasAdicional where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasCoberturasAdicional where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            sql = "delete from PolizasCertificados where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza) & " and idcertificado = " & dbStr(IdCertificadoAnterior)
            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")

            MsgBox("La operación se ha realizado con éxito.", MsgBoxStyle.Information, "AVISO...")

            Call btnBuscarCertificado_Click(Nothing, Nothing)

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
            MsgBox("La operación ha sido cancelada por el error reportado.", MsgBoxStyle.Information, "ERROR...")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

End Class
