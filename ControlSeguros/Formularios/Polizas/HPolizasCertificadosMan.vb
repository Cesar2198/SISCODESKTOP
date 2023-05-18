
Imports Utilerias.Genericas

Public Class HPolizasCertificadosMan

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
            Me.txtNombreCliente.Focus()
        End If
    End Sub

    Private Sub HPolizasCertificadosMan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtValorAsegurado.Focus()
    End Sub

    Private Sub HPolizasCertificadosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        Dim VDatosTec As String = ValidarDatosTecnicos()
        If VDatosTec <> "" Then
            MsgBox("Debe completar los datos de los bienes" & vbCrLf & VDatosTec, MsgBoxStyle.Information, "AVISO...")
            Cancel = True
            Exit Sub
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And Me.txtIdCertificado.Text = "" Then
            Me.txtIdCertificado.Valor = ObtenerIDCertificado()
            Call Me.ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
            Call Me.ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
            Call Me.ActualizarLlavesGrid(Me, txtIdCertificado.NombreCampo, txtIdCertificado.Valor)
        End If

    End Sub

    Private Sub HPolizasCertificadosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.txtIdPoliza.Valor = stiSplit(Me.ClavesNuevo, "G0|1")
                Me.cboIdProducto.Valor = stiSplit(Me.ClavesNuevo, "G1|1")
                'Proponemos al contratante como cliente
                Me.txtIdCliente.Valor = stiSplit(Me.ClavesNuevo, "G2|1")
                Try
                    Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(Me.txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception

                End Try
                Me.txtNombreCliente.Focus()
                Me.txtVigenciaDesde.Valor = stiSplit(Me.ClavesNuevo, "G3|1")
                Me.txtVigenciaHasta.Valor = stiSplit(Me.ClavesNuevo, "G4|1")
                Me.txtFechaInclusion.Valor = Me.txtVigenciaDesde.Valor
                Me.cboIdVendedor.Valor = stiSplit(Me.ClavesNuevo, "G5|1")
                Me.txtIdPoliza.SoloLectura = True
                Me.cboIdProducto.SoloLectura = True
                Me.cboEstadoCertificado.Valor = "VIGENTE"

                Me.txtValorAsegurado.Valor = 0
                Me.txtPrimaNeta.Valor = 0
                Me.txtGastosEmi.Valor = 0
                Me.txtGastosFrac.Valor = 0
                Me.txtGastosBomb.Valor = 0
                Me.txtGastosOtros.Valor = 0
                Me.txtIva.Valor = 0
                Me.txtTotal.Valor = 0

                If cboIdProducto.Valor <> "" Then
                    Call CargarCoberturas()
                    Call CargarDatosTecnicos()
                End If

                Me.txtIdCliente.Focus()
            Case enEstadoRegistro.Modificando
                Call CompletarCoberturas()

                If txtRazonExclusion.Text <> "" Then
                    Me.EstadoEntradas(False, Me)
                    Me.btnGuardar.Enabled = False
                    Me.btnGuardarComo.Enabled = False
                    Me.btnEliminar.Enabled = False
                    btnBuscarCliente.Enabled = False
                    btnAgregarCesion.Enabled = False
                    btnQuitarCesion.Enabled = False
                End If
                If Me.VistaBienes.RowCount = 0 Then
                    Call CargarDatosTecnicos()
                End If

                Me.txtValorAsegurado.Focus()


        End Select
        txtUsuarioModifica.Valor = StiGlobalConn.User
        txtFechaModifica.Valor = Date.Today
        txtUsuarioModifica.SoloLectura = True
        txtFechaModifica.SoloLectura = True

        If Me.Permiso = "L" Then
            btnBuscarCliente.Enabled = False
            btnAgregarCesion.Enabled = False
            btnQuitarCesion.Enabled = False
        End If

        Try
            Dim Ramo As String = StiGlobalConn.ObtenerDataset("select r.nombreramo from productos as p inner join RamoSeguros as r on r.idramo = p.idramo where p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            If Ramo.ToLower.Trim Like "*incendio*" Or Ramo.ToLower.Trim Like "*lineas aliadas*" Then
                txtIdCertificado.LabelText = "Ubicación"
                lblNombreFormulario.Text = "Ubicación"
            End If
        Catch ex As Exception

        End Try

        'completamos el combo con los tipos de bienes

        Dim TB As DataTable
        TB = StiGlobalConn.ObtenerDataset("select NombreBien from ProductosBienes where idproducto = " & dbStr(cboIdProducto.Valor) & " order by IdBien").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "NombreBien"
        RepositoryItemLookUpEdit1.DisplayMember = "NombreBien"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TB
        RepositoryItemLookUpEdit1.PopulateColumns()

        Dim PA As DataTable
        PA = StiGlobalConn.ObtenerDataset("select IdParentesco as Id, Descripcion as Parentesco from Parentescos order by Descripcion").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Parentesco"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = PA
        RepositoryItemLookUpEdit2.PopulateColumns()

        Try
            Dim Ramo As String = StiGlobalConn.ObtenerDataset("select TipoProducto from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            If Ramo = "VIDA" Then
                Me.pagCobertura.Text = "Sumas Aseguradas"
                Me.pagDatosTec.Text = "Detalle del Asegurado"
            End If

        Catch ex As Exception

        End Try

        Try
            Dim VerSumasBienes As String = dbData(StiGlobalConn.ObtenerDataset("select BienesSumas from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0), "BienesSumas")
            If VerSumasBienes.Trim.ToUpper = "S" Then
                Me.colBienSuma.Visible = True
                Me.ColBienPrima.Visible = True
            Else
                Me.colBienSuma.Visible = False
                Me.ColBienPrima.Visible = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Function ObtenerIDCertificado() As Integer
        Dim IdCert As Integer = -1
        'Para la póliza y producto obtenermos el siguiente certificado
        Dim Certificados As DataTable = StiGlobalConn.ObtenerDataset("select IdCertificado from PolizasCertificados where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdCertificado").Tables(0)
        Dim FilCert As DataRow
        For Each FilCert In Certificados.Rows
            Try
                If IsNumeric(dbData(FilCert, "IdCertificado")) = True Then
                    If Val(dbData(FilCert, "IdCertificado")) > IdCert Then
                        IdCert = CInt(dbData(FilCert, "IdCertificado"))
                    End If
                End If
            Catch ex As Exception

            End Try

        Next
        IdCert += 1

        Return IdCert
    End Function

    Private Sub CalcularIva()
        Dim prima As Double = Me.txtPrimaNeta.Valor
        Dim gastos As Double = Me.txtGastosEmi.Valor + Me.txtGastosFrac.Valor + Me.txtGastosBomb.Valor + Me.txtGastosOtros.Valor
        Dim PorceIva As Double = clSeguros.ObtenerDBParametros("Porce.Iva")
        Dim TipoCliente As String = ""
        Dim TipoProducto As String = ""
        Try
            TipoCliente = StiGlobalConn.ObtenerDataset("select idtipocliente from clientes where idcliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            TipoCliente = ""
        End Try

        If TipoCliente = "GU" Or TipoCliente = "JE" Then
            ''no se cobra iva al gobierno o empresas exentas
            ''tambien las facturas de exportación.
            PorceIva = 0
        End If
        Try
            TipoProducto = StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            TipoProducto = ""
        End Try

        If TipoProducto = "VIDA" Then
            Me.txtIva.Valor = Math.Round((gastos) * (PorceIva / 100), 2)
        Else
            Me.txtIva.Valor = Math.Round((prima + gastos) * (PorceIva / 100), 2)
        End If

        Call CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Me.txtTotal.Valor = Math.Round(Me.txtPrimaNeta.Valor + Me.txtGastosEmi.Valor + Me.txtGastosFrac.Valor + Me.txtGastosBomb.Valor + Me.txtGastosOtros.Valor + Me.txtIva.Valor, 2)
    End Sub

    Private Sub CargarCoberturas()

        Dim sql As String = ""

        sql = "  select '" & Me.txtIdPoliza.Valor & "' as IdPoliza, IdProducto, 0 as IdCertificado"
        sql &= " ,IdCobertura, Descripcion , 0.0 as SumaAsegurada, 0.0 as Tasa, '' as Deducible, 0.0 as Prima, 0.0 as PorceSuma"
        sql &= " from HProductosCoberturas"
        sql &= " where IdProducto = " & dbStr(cboIdProducto.Valor)
        Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        Me.GridCoberturas.DataSource = Coberturas
        Me.GridCoberturas.Refresh()
        colCobertura.OptionsColumn.AllowEdit = False
        colDescripcion.OptionsColumn.AllowEdit = False

    End Sub

    Private Sub CargarDatosTecnicos()
        'para certificados nuevos cargaremos los datostecnicos por default.
        'como esta tabla es administrada por el formulario ingresaremos las filas manualmente

        Try
            Dim DatosTec As DataTable, Fila As DataRow
            Dim FilaG As Integer
            DatosTec = StiGlobalConn.ObtenerDataset("select IdBien, NombreBien from ProductosBienes where idproducto = " & dbStr(cboIdProducto.Valor) & " order by IdBien").Tables(0)
            For Each Fila In DatosTec.Rows
                Me.VistaBienes.AddNewRow()
                FilaG = VistaBienes.FocusedRowHandle
                VistaBienes.SetRowCellValue(FilaG, "IdBien", dbData(Fila, "IdBien"))
                VistaBienes.SetRowCellValue(FilaG, "NombreBien", dbData(Fila, "NombreBien"))
                Me.VistaBienes.UpdateCurrentRow()
            Next
            Me.ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
            Me.ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
            Me.ActualizarLlavesGrid(Me, txtIdCertificado.NombreCampo, txtIdCertificado.Valor)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CompletarCoberturas()
        Try
            Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset("select IdCobertura, Descripcion from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0)
            Dim dtCob As DataTable = GridCoberturas.DataSource
            Try
                dtCob.Columns.Add("Descripcion", System.Type.GetType("System.String"))
            Catch ex As Exception

            End Try
            GridCoberturas.DataSource = dtCob
            Dim Cob As String = ""
            For I As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                Try
                    Cob = Coberturas.Select("IdCobertura = " & dbInt(Me.VistaCoberturas.GetRowCellValue(I, "IdCobertura")))(0).Item("Descripcion")
                    Me.VistaCoberturas.SetRowCellValue(I, "Descripcion", Cob)
                Catch ex As Exception

                End Try
            Next

            'si existen coberturas adicionales las completamos
            Coberturas = StiGlobalConn.ObtenerDataset("select IdCobertura, Descripcion from HPolizasCoberturasAdicional where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor) & " and IdHistorico = " & dbInt(txtIdHistorico.Valor)).Tables(0)
            Dim FCE As DataRow, IdCobertura As Integer = 0
            For Each FCE In Coberturas.Rows
                Try
                    IdCobertura = Me.ObtenerFilaCob(Val(dbData(FCE, "IdCobertura")))
                    Me.VistaCoberturas.SetRowCellValue(IdCobertura, "Descripcion", dbData(FCE, "Descripcion"))
                Catch ex As Exception

                End Try
            Next

            GridCoberturas.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerFilaCob(ByVal IdCob As Integer) As Integer
        Dim Fila As Integer = -1
        Try
            For NC As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                If Val(IdCob) = Val(VistaCoberturas.GetRowCellValue(NC, "IdCobertura")) Then
                    Fila = NC
                    Exit For
                End If
            Next
        Catch ex As Exception
            Fila = -1
        End Try
        Return Fila
    End Function

    Private Sub txtIdPoliza_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdPoliza.ValueChangeOnExit
        Me.ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdProducto.ValueChangeOnExit
        Me.ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
    End Sub

    Private Sub txtIdCertificado_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdCertificado.ValueChangeOnExit
        Me.ActualizarLlavesGrid(Me, txtIdCertificado.NombreCampo, txtIdCertificado.Valor)
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Me.EstadoEntradas(True, Me)
            Me.txtIdPoliza.Valor = stiSplit(Me.ClavesNuevo, "G0|1")
            Me.cboIdProducto.Valor = stiSplit(Me.ClavesNuevo, "G1|1")
            'Proponemos al contratante como cliente
            Me.txtIdCliente.Valor = stiSplit(Me.ClavesNuevo, "G2|1")
            Try
                Me.txtNombreCliente.Valor = StiGlobalConn.ObtenerDataset("select NombreCliente from Clientes where idcliente = " & dbStr(Me.txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try
            Me.txtNombreCliente.Focus()
            Me.txtVigenciaDesde.Valor = stiSplit(Me.ClavesNuevo, "G3|1")
            Me.txtVigenciaHasta.Valor = stiSplit(Me.ClavesNuevo, "G4|1")
            Me.txtFechaInclusion.Valor = Me.txtVigenciaDesde.Valor
            Me.cboIdVendedor.Valor = stiSplit(Me.ClavesNuevo, "G5|1")

            Me.txtIdPoliza.SoloLectura = True
            Me.cboIdProducto.SoloLectura = True
            Me.cboEstadoCertificado.Valor = "VIGENTE"

            Me.txtValorAsegurado.Valor = 0
            Me.txtPrimaNeta.Valor = 0
            Me.txtGastosEmi.Valor = 0
            Me.txtGastosFrac.Valor = 0
            Me.txtGastosBomb.Valor = 0
            Me.txtGastosOtros.Valor = 0
            Me.txtIva.Valor = 0
            Me.txtTotal.Valor = 0

            If cboIdProducto.Valor <> "" Then
                Call CargarCoberturas()
                Call Me.CargarDatosTecnicos()
            End If
            txtUsuarioModifica.Valor = StiGlobalConn.User
            txtFechaModifica.Valor = Date.Today
            txtUsuarioModifica.SoloLectura = True
            txtFechaModifica.SoloLectura = True

            Me.txtIdCliente.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call CompletarCoberturas()
        txtUsuarioModifica.Valor = StiGlobalConn.User
        txtFechaModifica.Valor = Date.Today
        txtUsuarioModifica.SoloLectura = True
        txtFechaModifica.SoloLectura = True
    End Sub

    Private Sub btnAgregarCesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCesion.Click
        Try
            Dim IdCes As Integer = ObtenerIDCes()
            Me.AgregarFilaGrid(VistaCesiones)
            Dim Fila As Integer = VistaCesiones.FocusedRowHandle
            VistaCesiones.SetRowCellValue(Fila, "IdCesion", IdCes)
            VistaCesiones.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDCes() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaCesiones.DataRowCount - 1
            Try
                If CInt(VistaCesiones.GetRowCellValue(I, "IdCesion")) > Id Then
                    Id = CInt(VistaCesiones.GetRowCellValue(I, "IdCesion"))
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

    Private Sub btnQuitarCesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCesion.Click
        Try
            Me.EliminarFilaGrid(VistaCesiones)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtPrimaNeta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPrimaNeta.ValueChangeOnExit
        Call CalcularIva()
    End Sub

    Private Sub txtGastosEmi_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosEmi.ValueChangeOnExit
        Call CalcularIva()
    End Sub

    Private Sub txtGastosFrac_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosFrac.ValueChangeOnExit
        Call CalcularIva()
    End Sub

    Private Sub txtGastosBomb_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosBomb.ValueChangeOnExit
        Call CalcularIva()
    End Sub

    Private Sub txtGastosOtros_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtGastosOtros.ValueChangeOnExit
        Call CalcularIva()
    End Sub

    Private Sub txtIva_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIva.ValueChangeOnExit
        Call CalcularTotal()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Call btnNuevo_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.LostFocus
        Me.TabCertificados.SelectedTabPageIndex = 1
        Me.VistaCoberturas.Focus()
    End Sub

    Private Sub txtRazonExclusion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtRazonExclusion.ValueChangeOnExit
        If Me.txtRazonExclusion.Text.Trim <> "" Then
            cboEstadoCertificado.Valor = "CANCELADO"
        Else
            cboEstadoCertificado.Valor = "VIGENTE"
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from HPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.idhistorico = p.idhistorico and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from HPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.idhistorico = p.idhistorico and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from HPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.idhistorico = p.idhistorico and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from HPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.idhistorico = p.idhistorico and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from HPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.idhistorico = p.idhistorico and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from HPolizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and p.idhistorico = " & dbInt(txtIdHistorico.Valor)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

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
            sql &= " from HPolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and c.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and c.idcertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and c.idhistorico = " & dbInt(txtIdHistorico.Valor)

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " from HPolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and p.idcertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and p.idhistorico = " & dbStr(txtIdHistorico.Valor)
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCobertura"

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
            sql &= " from HPolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and p.idcertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and p.idhistorico = " & dbInt(txtIdHistorico.Valor)
            sql &= " order by p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New RepDetCertificado
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            MsgBox("Existen problemas para imprimir la póliza." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AVISO...")
        End Try

    End Sub

    Private Sub btnQuitarBenef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarBenef.Click
        Try
            Me.EliminarFilaGrid(VistaBeneficiarios)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarBenef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarBenef.Click
        Try
            Dim IdBenef As Integer = ObtenerIDBenef()
            Me.AgregarFilaGrid(VistaBeneficiarios)
            Dim Fila As Integer = VistaBeneficiarios.FocusedRowHandle
            VistaBeneficiarios.SetRowCellValue(Fila, "IdBeneficiario", IdBenef)
            VistaBeneficiarios.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDBenef() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaBeneficiarios.DataRowCount - 1
            Try
                If CInt(VistaBeneficiarios.GetRowCellValue(I, "IdBeneficiario")) > Id Then
                    Id = CInt(VistaBeneficiarios.GetRowCellValue(I, "IdBeneficiario"))
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

    Private Sub btnQuitarBien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarBien.Click
        Try
            Me.EliminarFilaGrid(VistaBienes)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarBien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarBien.Click
        Try
            Dim IdBien As Integer = ObtenerIDBien()
            Me.AgregarFilaGrid(VistaBienes)
            Dim Fila As Integer = VistaBienes.FocusedRowHandle
            VistaBienes.SetRowCellValue(Fila, "IdBien", IdBien)
            VistaBienes.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDBien() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaBienes.DataRowCount - 1
            Try
                If CInt(VistaBienes.GetRowCellValue(I, "IdBien")) > Id Then
                    Id = CInt(VistaBienes.GetRowCellValue(I, "IdBien"))
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

    Private Function ValidarDatosTecnicos() As String
        Dim res As String = ""
        For NB As Integer = 0 To Me.VistaBienes.DataRowCount - 1
            If CStr(VistaBienes.GetRowCellValue(NB, "DescripcionBien")).Trim = "" Then
                res &= "El campo " & VistaBienes.GetRowCellValue(NB, "NombreBien") & " es obligatorio; "
            End If
        Next
        Return res
    End Function

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.VistaBeneficiarios.FocusedColumn.FieldName
            Case "NombreBeneficiario" : Me.RepositoryItemTextEdit1.MaxLength = 250
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit2.Enter
        Select Case Me.VistaCesiones.FocusedColumn.FieldName
            Case "Beneficiario", "Observaciones", "Propietario" : Me.RepositoryItemTextEdit2.MaxLength = 250
        End Select
    End Sub

End Class
