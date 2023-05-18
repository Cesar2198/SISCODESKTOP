
Imports Utilerias.Genericas

Public Class PolizasCertificadosMan

    Dim PrimaSinDescuento As Double = 0
    Dim PrimaSinIva As Double = 0
    Dim ActualizandoCoberturas As Boolean = False

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

    Private Sub PolizasCertificadosMan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtValorAsegurado.Focus()
    End Sub

    Private Sub PolizasCertificadosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        Dim VDatosTec As String = ValidarDatosTecnicos()
        If VDatosTec <> "" Then
            MsgBox("Debe completar los datos de los bienes:" & vbCrLf & VDatosTec, MsgBoxStyle.Information, "AVISO...")
            Cancel = True
            Exit Sub
        End If

        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And (Me.txtIdCertificado.Text.Trim = "" Or Me.txtIdCertificado.Text.Trim = "-1") Then
            Me.txtIdCertificado.Valor = ObtenerIDCertificado()
            Call Me.ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
            Call Me.ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
            Call Me.ActualizarLlavesGrid(Me, txtIdCertificado.NombreCampo, txtIdCertificado.Valor)
        End If

        'If Me.EstadoRegistro <> enEstadoRegistro.Adicionando Then
        'verificamos si se registrará un anexo
        Call RegistrarAnexo()
        'End If
    End Sub

    Private Sub RegistrarAnexo()
        Try
            Dim SumaAnterior As Double = 0
            Dim PrimaAnterior As Double = 0
            Dim VigAnteriorDesde As String = ""
            Dim VigAnteriorHasta As String = ""
            Dim InclusionAnterior As String = ""
            Dim ExclusionAnterior As String = ""
            Try
                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select ValorAsegurado, PrimaNeta, VigenciaDesde, VigenciaHasta, FechaInclusion, FechaExclusion from PolizasCertificados where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0).Rows(0)
                SumaAnterior = Val(dbData(FilPol, "ValorAsegurado"))
                PrimaAnterior = Val(dbData(FilPol, "PrimaNeta"))
                If dbData(FilPol, "VigenciaDesde") <> "" Then VigAnteriorDesde = CDate(dbData(FilPol, "VigenciaDesde")).ToShortDateString
                If dbData(FilPol, "VigenciaHasta") <> "" Then VigAnteriorHasta = CDate(dbData(FilPol, "VigenciaHasta")).ToShortDateString
                If dbData(FilPol, "FechaInclusion") <> "" Then InclusionAnterior = CDate(dbData(FilPol, "FechaInclusion")).ToShortDateString
                If dbData(FilPol, "FechaExclusion") <> "" Then ExclusionAnterior = CDate(dbData(FilPol, "FechaExclusion")).ToShortDateString

            Catch ex As Exception

            End Try


            Dim SumaNueva As Double = Me.txtValorAsegurado.Valor
            Dim PrimaNueva As Double = Me.txtPrimaNeta.Valor
            Dim VigNuevaDesde As String = ""
            If txtVigenciaDesde.Text <> "" Then VigNuevaDesde = CDate(txtVigenciaDesde.Valor).ToShortDateString
            Dim VigNuevaHasta As String = ""
            If txtVigenciaHasta.Text <> "" Then VigNuevaHasta = CDate(txtVigenciaHasta.Valor).ToShortDateString
            Dim InclusionNueva As String = ""
            If txtFechaInclusion.Text <> "" Then InclusionNueva = CDate(txtFechaInclusion.Valor).ToShortDateString
            Dim ExclusionNueva As String = ""
            If txtFechaExclusion.Text <> "" Then ExclusionNueva = CDate(txtFechaExclusion.Valor).ToShortDateString


            If SumaAnterior <> SumaNueva Or PrimaAnterior <> PrimaNueva Or VigAnteriorDesde <> VigNuevaDesde Or VigAnteriorHasta <> VigNuevaHasta Or InclusionNueva <> InclusionAnterior Or ExclusionNueva <> ExclusionAnterior Then
                Dim sql As String = ""
                Dim IdAnexo As Integer = ObtenerIDAnx()
                Me.AgregarFilaGrid(VistaAnexos)
                Dim Fila As Integer = VistaAnexos.FocusedRowHandle
                VistaAnexos.SetRowCellValue(Fila, "IdPoliza", txtIdPoliza.Valor)
                VistaAnexos.SetRowCellValue(Fila, "IdProducto", cboIdProducto.Valor)
                VistaAnexos.SetRowCellValue(Fila, "IdCertificado", txtIdCertificado.Valor)
                VistaAnexos.SetRowCellValue(Fila, "IdAnexo", IdAnexo)
                VistaAnexos.SetRowCellValue(Fila, "FechaAnexo", Date.Now)
                VistaAnexos.SetRowCellValue(Fila, "UsuarioAnexo", StiGlobalConn.User)
                VistaAnexos.SetRowCellValue(Fila, "VigenciaDesde", txtVigenciaDesde.Valor)
                VistaAnexos.SetRowCellValue(Fila, "VigenciaHasta", txtVigenciaHasta.Valor)

                VistaAnexos.SetRowCellValue(Fila, "FechaIngreso", txtFechaInclusion.Valor)
                VistaAnexos.SetRowCellValue(Fila, "FechaExclusion", txtFechaExclusion.Valor)

                VistaAnexos.SetRowCellValue(Fila, "SumaAseguradaAnterior", SumaAnterior)
                VistaAnexos.SetRowCellValue(Fila, "SumaAseguradaNueva", SumaNueva)
                VistaAnexos.SetRowCellValue(Fila, "PrimaAnexo", PrimaNueva)
                VistaAnexos.UpdateCurrentRow()

                'sql = "  insert into PolizasCertificadosAnexos "
                'sql &= " (IdPoliza, IdProducto, IdCertificado, IdAnexo, FechaAnexo "
                'sql &= " ,UsuarioAnexo, VigenciaDesde, VigenciaHasta, SumaAseguradaAnterior, SumaAseguradaNueva, PrimaAnexo) Values ("
                'sql &= dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & C & dbStr(txtIdCertificado.Valor) & C & dbInt(IdAnexo) & C & dbFec(Date.Now, "1") & C
                'sql &= dbStr(StiGlobalConn.User) & C & dbFec(VigNuevaDesde) & C & dbFec(VigNuevaHasta) & C & dbNum(SumaAnterior) & C & dbNum(SumaNueva) & C & dbNum(PrimaNueva) & ")"
                'StiGlobalConn.SQLExecute(sql)

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PolizasCertificadosMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Try
            'si existen coberturas adicionales que no pertenecen al producto se alamcenan en una tabla adicional
            'primero borramos
            StiGlobalConn.ObtenerDataset("delete from PolizasCoberturasAdicional where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor))
            'recorremos las coberturas y verificamos cual no existe en el producto
            Dim IdCobertura As Integer = 0, Existe As Integer = 0, sql As String = ""
            For NC As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                IdCobertura = VistaCoberturas.GetRowCellValue(NC, "IdCobertura")
                Existe = StiGlobalConn.ObtenerDataset("select count(*) from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCobertura = " & dbInt(IdCobertura)).Tables(0).Rows(0).Item(0)
                If Existe = 0 Then
                    sql = "  insert into PolizasCoberturasAdicional "
                    sql &= " (IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion) values("
                    sql &= dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & C & dbStr(txtIdCertificado.Valor) & C & dbInt(IdCobertura) & C & dbStr(VistaCoberturas.GetRowCellValue(NC, "Descripcion")) & ")"
                    StiGlobalConn.SQLExecute(sql)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error al almacenar la cobertura adicional." & vbCrLf & ex.Message, MsgBoxStyle.Information, "ERROR...")
        End Try
    End Sub

    Private Sub PolizasCertificadosMan_DespuesDeGuardarFinal() Handles Me.DespuesDeGuardarFinal
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And Me.SalirAlGrabar = False And Me.SeguirAlGrabarActualizar = False And Me.SeguirAlGrabarNuevo = False Then
            Call btnNuevo_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub PolizasCertificadosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ActualizandoCoberturas = True
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
                'Me.cboIdVendedor.Valor = stiSplit(Me.ClavesNuevo, "G5|1")
                Me.txtIdPoliza.SoloLectura = True
                Me.cboIdProducto.SoloLectura = True
                Me.cboEstadoCertificado.Valor = "VIGENTE"
                Me.txtIdCertificado.Valor = "-1"
                Me.ActualizarLlavesGrid(Me, "IdCertificado", txtIdCertificado.Valor)
                Me.ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
                Me.ActualizarLlavesGrid(Me, txtIdCertificado.NombreCampo, txtIdCertificado.Valor)

                Me.txtValorAsegurado.Valor = 0
                Me.txtPrimaNeta.Valor = 0
                Me.txtPrimaExenta.Valor = 0
                Me.txtPrimaBruta.Valor = 0
                Me.txtPorceDescuento.Valor = 0
                Me.txtValorDescuento.Valor = 0
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

                'mostramos únicamente los planes adecuados
                Dim Ramo As String = ""
                Try
                    Ramo = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(Me.cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Ramo = ""
                End Try
                If Ramo <> "" Then
                    cboPlan.Query = "select IdPlan as Id, Descripcion as Planes from Planes where idramo = " & dbStr(Ramo) & " order by Descripcion"
                    cboPlan.Llenar_Combo()
                End If

                Me.txtIdCliente.Focus()
            Case enEstadoRegistro.Modificando
                Call CompletarCoberturas()

                Dim EstadoPoliza As String = StiGlobalConn.ObtenerDataset("select EstadoPoliza from Polizas where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                Dim blnPolizaCancelada As Boolean = False
                If EstadoPoliza = "CANCELADA" Then blnPolizaCancelada = True

                If txtRazonExclusion.Text <> "" And blnPolizaCancelada = False Then
                    Me.EstadoEntradas(False, Me)
                    'Me.btnGuardar.Enabled = False
                    Me.btnGuardarComo.Enabled = False
                    Me.btnEliminar.Enabled = False
                    btnBuscarCliente.Enabled = False
                    btnAgregarCesion.Enabled = False
                    btnQuitarCesion.Enabled = False
                    btnAgregarBenef.Enabled = False
                    btnQuitarBenef.Enabled = False

                    btnObtenerDatosPC.Enabled = False
                    btnAgregarCob.Enabled = False
                    btnQuitarCob.Enabled = False
                    btnAgregarBien.Enabled = False
                    btnQuitarBien.Enabled = False

                    'para futuras rehabiltaciones activamos estos campos
                    cboEstadoCertificado.SoloLectura = False
                    txtRazonExclusion.SoloLectura = False
                    txtFechaExclusion.SoloLectura = False

                End If

                If txtRazonExclusion.Text <> "" And blnPolizaCancelada = True Then
                    Me.EstadoEntradas(False, Me)
                    Me.btnGuardar.Enabled = False
                    Me.btnGuardarComo.Enabled = False
                    Me.btnEliminar.Enabled = False
                    btnBuscarCliente.Enabled = False
                    btnAgregarCesion.Enabled = False
                    btnQuitarCesion.Enabled = False
                    btnAgregarBenef.Enabled = False
                    btnQuitarBenef.Enabled = False
                    btnObtenerDatosPC.Enabled = False
                    btnAgregarCob.Enabled = False
                    btnQuitarCob.Enabled = False
                    btnAgregarBien.Enabled = False
                    btnQuitarBien.Enabled = False
                    Me.btnNuevo.Enabled = False

                End If

                If txtPrimaBruta.Text = "" Then txtPrimaBruta.Valor = txtPrimaNeta.Valor
                If txtPorceDescuento.Text = "" Then txtPorceDescuento.Valor = 0
                If Me.txtValorDescuento.Text = "" Then Me.txtValorDescuento.Valor = 0
                If Me.VistaBienes.RowCount = 0 Then
                    Call CargarDatosTecnicos()
                End If
                Call ObtenerPrimaSinDencuento() 'cargamos una variable utilizada para recalcular la prima y descuentos
                Call ObtenerPrimaSinIva()


                Dim Ramo As String = ""
                Dim Plan As String = cboPlan.Valor
                Try
                    Ramo = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(Me.cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Ramo = ""
                End Try
                If Ramo <> "" Then
                    cboPlan.Query = "select IdPlan as Id, Descripcion as Plan from Planes where idramo = " & dbStr(Ramo) & " order by Descripcion"
                    cboPlan.Llenar_Combo()
                End If
                cboPlan.Valor = Plan


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

        Me.ActualizandoCoberturas = False

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

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Descuento", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "S" : FilaTD("Descuento") = "SI" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "N" : FilaTD("Descuento") = "NO" : TD.Rows.Add(FilaTD)

        RepositoryItemLookUpEdit3.ValueMember = "Id"
        RepositoryItemLookUpEdit3.DisplayMember = "Descuento"
        RepositoryItemLookUpEdit3.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit3.DataSource = TD
        RepositoryItemLookUpEdit3.PopulateColumns()
        RepositoryItemLookUpEdit3.Columns("Id").Visible = False
        Try
            Dim Ramo As String = StiGlobalConn.ObtenerDataset("select TipoProducto from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            If Ramo = "VIDA" Then
                Me.pagCobertura.Text = "Sumas Aseguradas"
                Me.pagDatosTec.Text = "Detalle del Asegurado"
            End If

        Catch ex As Exception

        End Try
        Call CalcularDiasCobertura()

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

        If CStr(clSeguros.ObtenerDBParametros("Certificados.Ver.Anexos")).Trim.ToUpper <> "S" Then
            Me.pagAnexos.PageVisible = False
        End If


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

    Private Sub VistaCoberturas_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaCoberturas.CellValueChanged
        If ActualizandoCoberturas = True Then Exit Sub

        Select Case e.Column.FieldName
            Case "SumaAsegurada", "PorceSuma", "Tasa", "PorceDeducible", "PrimaMinima", "PrimaMaxima", "PrimaAnual"
                Call CalcularPrimaCoberturaFila(e.Column.FieldName, VistaCoberturas.FocusedRowHandle)

            Case "Prima", "AplicarIva", "AplicarDescuento"

                Call CalcularPrimaCoberturas()

        End Select
    End Sub

    Private Sub ReCalcularPrimaCoberturas()
        Try
            ActualizandoCoberturas = True
            For nc As Integer = 0 To Me.VistaCoberturas.RowCount - 1
                Try
                    CalcularPrimaCoberturaFila("SumaAsegurada", nc)
                Catch ex As Exception

                End Try
            Next
            ActualizandoCoberturas = False
            Call CalcularPrimaCoberturas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularPrimaCoberturaFila(ByVal FieldName As String, ByVal Fila As Integer)
        'al cambiar cualquiera de estos datos calculamos la prima de la fila
        Dim Suma As Double = 0, Tasa As Double = 0, Porce As Double = 0, Prima As Double = 0
        Dim Tarifa As Integer = 100 'por defecto por ciento (%)
        Dim PrimaAnual As Double = 0
        Dim DiasVigencia As Integer = 0, DiasFormaPago As Integer = 365
        Dim PrimaMinima As Double = 0
        Dim PrimaMaxima As Double = 0
        Dim PorceDed As Double = 0
        Dim DeducibleMinimo As Double = 0
        Dim DeducibleMaximo As Double = 0
        Dim Deducible As Double = 0

        DiasVigencia = ObtenerDiasCobertura(txtVigenciaDesde.Valor, txtVigenciaHasta.Valor)
        Try
            'buscaremos la tarifa en el producto de la cobertura en curso
            Dim FilProCob As DataRow = StiGlobalConn.ObtenerDataset("select Tarificacion from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCobertura = " & dbInt(Me.VistaCoberturas.GetRowCellValue(Fila, "IdCobertura"))).Tables(0).Rows(0)
            If dbData(FilProCob, "Tarificacion") = "" Then
                'la cobertura no tiene tarifa especificada, buscaremos en la primera cobertura
                FilProCob = StiGlobalConn.ObtenerDataset("select Tarificacion from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCobertura = 1").Tables(0).Rows(0)
                If dbData(FilProCob, "Tarificacion") <> "" Then
                    Tarifa = Val(dbData(FilProCob, "Tarificacion"))
                End If
            Else
                Tarifa = Val(dbData(FilProCob, "Tarificacion"))
            End If
        Catch ex As Exception

        End Try

        Try
            Suma = Me.VistaCoberturas.GetRowCellValue(Fila, "SumaAsegurada")
        Catch ex As Exception
            Suma = 0
        End Try
        Try
            Tasa = Me.VistaCoberturas.GetRowCellValue(Fila, "Tasa")
        Catch ex As Exception
            Tasa = 0
        End Try
        Try
            Porce = Me.VistaCoberturas.GetRowCellValue(Fila, "PorceSuma")
            If Porce = 0 Then Porce = 100
        Catch ex As Exception
            Porce = 100
        End Try

        Try
            PrimaMinima = Me.VistaCoberturas.GetRowCellValue(Fila, "PrimaMinima") * (DiasVigencia / DiasFormaPago)
        Catch ex As Exception
            PrimaMinima = 0
        End Try

        Try
            PrimaMaxima = Me.VistaCoberturas.GetRowCellValue(Fila, "PrimaMaxima") * (DiasVigencia / DiasFormaPago)
        Catch ex As Exception
            PrimaMaxima = 0
        End Try
        Try
            PrimaAnual = Me.VistaCoberturas.GetRowCellValue(Fila, "PrimaAnual")
        Catch ex As Exception
            PrimaAnual = 0
        End Try

        If Tasa = 0 And PrimaAnual > 0 Then
            Prima = Math.Round(PrimaAnual * (DiasVigencia / DiasFormaPago), 2)

            'cambio para los cálculos según redaelli de las pólizas de vivir.
            Dim filPol As DataRow, IdFormaPago As String = "", fecDesde As DateTime, fecHasta As DateTime, PrimaPeriodo As Double = 0, PeriodosRestantes As Integer = 0
            Try
                filPol = StiGlobalConn.ObtenerDataset("select idformapago, VigenciaDesde, VigenciaHasta from Polizas where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0)
                IdFormaPago = dbData(filPol, "idformapago")
                fecDesde = CDate(dbData(filPol, "VigenciaDesde"))
                fecHasta = CDate(dbData(filPol, "VigenciaHasta"))
                If IdFormaPago <> "" Then
                    Dim filFP As DataRow = StiGlobalConn.ObtenerDataset("select numerocuotas, DiasFacturacion from formaspago where idformapago = " & dbStr(IdFormaPago)).Tables(0).Rows(0)
                    DiasFormaPago = DateDiff(DateInterval.Day, fecDesde, fecHasta)
                    DiasVigencia = DateDiff(DateInterval.Day, CDate(txtVigenciaDesde.Valor), fecHasta)
                    Prima = Math.Round(PrimaAnual * (DiasVigencia / DiasFormaPago), 2)
                    'ahora le restamos los restantes periodos que no se cobrará sino hasta el próximo cobro
                    PrimaPeriodo = PrimaAnual / Val(dbData(filFP, "numerocuotas"))
                    PeriodosRestantes = CInt(DateDiff(DateInterval.Day, txtVigenciaHasta.Valor, fecHasta) / Val(dbData(filFP, "DiasFacturacion")))
                    Prima = Prima - (PrimaPeriodo * PeriodosRestantes)
                    If Prima > PrimaPeriodo Then Prima = PrimaPeriodo
                End If
            Catch ex As Exception

            End Try

        Else
            Prima = Math.Round(Suma * (Tasa / Tarifa) * (Porce / 100) * (DiasVigencia / DiasFormaPago), 2)
        End If

        If PrimaMinima > 0 And Suma > 0 Then
            If Prima < PrimaMinima Then Prima = PrimaMinima
        End If
        If PrimaMaxima > 0 And Suma > 0 Then
            If Prima > PrimaMaxima Then Prima = PrimaMaxima
        End If

        If Me.txtFechaExclusion.Text <> "" Then Prima = Prima * -1

        Try
            PorceDed = Me.VistaCoberturas.GetRowCellValue(Fila, "PorceDeducible")
        Catch ex As Exception
            PorceDed = 0
        End Try

        Try
            DeducibleMinimo = Me.VistaCoberturas.GetRowCellValue(Fila, "DeducibleMinimo")
        Catch ex As Exception
            DeducibleMinimo = 0
        End Try

        Try
            DeducibleMaximo = Me.VistaCoberturas.GetRowCellValue(Fila, "DeducibleMaximo")
        Catch ex As Exception
            DeducibleMaximo = 0
        End Try

        If Suma > 0 And PorceDed > 0 Then
            Deducible = Math.Round(Suma * (PorceDed / 100), 2)
            If DeducibleMinimo > 0 Then
                If Deducible < DeducibleMinimo Then Deducible = DeducibleMinimo
            End If
            If DeducibleMaximo > 0 Then
                If Deducible > DeducibleMaximo Then Deducible = DeducibleMaximo
            End If
        End If


        If FieldName = "SumaAsegurada" And Fila = 0 Then
            txtValorAsegurado.Valor = Suma
            Call AplicarSumasPlanR1()
        End If

        If Prima <> 0 Then VistaCoberturas.SetRowCellValue(Fila, "Prima", Prima)

        If Deducible > 0 Then
            VistaCoberturas.SetRowCellValue(Fila, "Deducible", CStr(Deducible))
            txtDeducible.Valor = CStr(Deducible)
        End If
        ActualizandoCoberturas = True
        If DiasVigencia = 365 Then VistaCoberturas.SetRowCellValue(Fila, "PrimaAnual", VistaCoberturas.GetRowCellValue(Fila, "Prima"))
        VistaCoberturas.UpdateCurrentRow()
        ActualizandoCoberturas = False

    End Sub

    Private Sub CalcularPrimaCoberturas()
        Try
            Dim PrimaNeta As Double = 0, PrimaC As Double = 0
            Dim PrimaSD As Double = 0, Desc As String = "", Exento As String = "", PrimaSIva As Double = 0
            PrimaSinDescuento = 0 : PrimaSinIva = 0
            Dim DiasVigencia As Integer = ObtenerDiasCobertura(txtVigenciaDesde.Valor, txtVigenciaHasta.Valor)
            For NC As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                Try
                    PrimaC = VistaCoberturas.GetRowCellValue(NC, "Prima")
                    Try
                        Desc = VistaCoberturas.GetRowCellValue(NC, "AplicarDescuento")
                    Catch ex As Exception
                        Desc = ""
                    End Try
                    Try
                        Exento = VistaCoberturas.GetRowCellValue(NC, "AplicarIva")
                    Catch ex As Exception
                        Exento = ""
                    End Try
                    ActualizandoCoberturas = True
                    If DiasVigencia = 365 Then VistaCoberturas.SetRowCellValue(NC, "PrimaAnual", VistaCoberturas.GetRowCellValue(NC, "Prima"))
                    VistaCoberturas.UpdateCurrentRow()
                    ActualizandoCoberturas = False
                    PrimaNeta += PrimaC
                    If Desc = "N" Then PrimaSD += PrimaC
                    If Exento = "N" Then PrimaSIva += PrimaC

                Catch ex As Exception

                End Try
            Next
            txtPrimaBruta.Valor = PrimaNeta
            PrimaSinDescuento = PrimaSD
            PrimaSinIva = PrimaSIva
            Call CalcularPrimaNeta()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ObtenerPrimaSinDencuento()
        Try
            Dim PrimaC As Double = 0
            Dim PrimaSD As Double = 0, Desc As String = ""
            PrimaSinDescuento = 0
            For NC As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                Try
                    PrimaC = VistaCoberturas.GetRowCellValue(NC, "Prima")
                    Try
                        Desc = VistaCoberturas.GetRowCellValue(NC, "AplicarDescuento")
                    Catch ex As Exception
                        Desc = ""
                    End Try
                    If Desc = "N" Then PrimaSD += PrimaC
                Catch ex As Exception

                End Try
            Next
            PrimaSinDescuento = PrimaSD
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ObtenerPrimaSinIva()
        Try
            Dim PrimaC As Double = 0
            Dim PrimaSIva As Double = 0, Exento As String = ""
            PrimaSinIva = 0
            For NC As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                Try
                    PrimaC = VistaCoberturas.GetRowCellValue(NC, "Prima")
                    Try
                        Exento = VistaCoberturas.GetRowCellValue(NC, "AplicarIva")
                    Catch ex As Exception
                        Exento = ""
                    End Try
                    If Exento = "N" Then PrimaSIva += PrimaC
                Catch ex As Exception

                End Try
            Next
            PrimaSinIva = PrimaSIva
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularPrimaNeta()
        Try
            Dim PorceDesc As Double = txtPorceDescuento.Valor
            Dim Descuento As Double = txtValorDescuento.Valor
            Call ObtenerPrimaSinDencuento()
            Call ObtenerPrimaSinIva()
            If PorceDesc > 0 Then
                Descuento = Math.Round((txtPrimaBruta.Valor - PrimaSinDescuento) * (PorceDesc / 100), 2)
                txtValorDescuento.Valor = Descuento
            End If

            Dim dblPrimaNeta As Double = txtPrimaBruta.Valor - txtValorDescuento.Valor

            If txtPrimaMinima.Valor > 0 Then
                'prorrateamos la prima min.
                Dim DiasVigencia As Integer = 0, DiasFormaPago As Integer = 365
                DiasVigencia = ObtenerDiasCobertura(txtVigenciaDesde.Valor, txtVigenciaHasta.Valor)

                Dim dblPrimaMin As Double = Math.Round(txtPrimaMinima.Valor * (DiasVigencia / DiasFormaPago), 2)
                If dblPrimaNeta < dblPrimaMin Then dblPrimaNeta = dblPrimaMin
            End If


            txtPrimaNeta.Valor = dblPrimaNeta
            txtPrimaExenta.Valor = PrimaSinIva
            'calculamos los gastos
            Call CalcularGastos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularGastos()
        Try
            ''obtendremos los gastos del ramo.
            txtGastosEmi.Valor = Polizas_CalcularGasto(cboIdProducto.Valor, txtValorAsegurado.Valor, txtPrimaNeta.Valor, "EMI")
            txtGastosFrac.Valor = Polizas_CalcularGasto(cboIdProducto.Valor, txtValorAsegurado.Valor, txtPrimaNeta.Valor, "FRAC")
            txtGastosBomb.Valor = Polizas_CalcularGasto(cboIdProducto.Valor, txtValorAsegurado.Valor, txtPrimaNeta.Valor, "BOMB")
            txtGastosOtros.Valor = Polizas_CalcularGasto(cboIdProducto.Valor, txtValorAsegurado.Valor, txtPrimaNeta.Valor, "OTRO")
            'finalmente calculamos el IVA
            Call CalcularIva()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularIva()
        Dim prima As Double = Me.txtPrimaNeta.Valor
        Dim PrimaExenta As Double = Me.txtPrimaExenta.Valor
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
            Me.txtPrimaExenta.Valor = Me.txtPrimaNeta.Valor
            Me.txtIva.Valor = Math.Round((gastos) * (PorceIva / 100), 2)
        Else
            Me.txtIva.Valor = Math.Round((prima - PrimaExenta + gastos) * (PorceIva / 100), 2)
        End If

        Call CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Me.txtTotal.Valor = Math.Round(Me.txtPrimaNeta.Valor + Me.txtGastosEmi.Valor + Me.txtGastosFrac.Valor + Me.txtGastosBomb.Valor + Me.txtGastosOtros.Valor + Me.txtIva.Valor, 2)
    End Sub

    Private Sub CargarCoberturas()

        Dim sql As String = ""

        sql = "  select '" & Me.txtIdPoliza.Valor & "' as IdPoliza, IdProducto, 0 as IdCertificado"
        sql &= " ,IdCobertura, Descripcion , 0.0 as SumaAsegurada, 0.0 as Tasa, '' as Deducible, 0.0 as Prima, 0.0 as PorceSuma, AplicarDescuento, '' as Participacion, cast(0 as bit) as CoberturaAdicional, AplicarIva, 0.0 as PrimaMinima, 0.0 as PrimaMaxima, 0.0 as DeducibleMinimo, 0.0 as DeducibleMaximo, 0.0 as PorceDeducible, 0.0 as PrimaAnual "
        sql &= " from ProductosCoberturas"
        sql &= " where IdProducto = " & dbStr(cboIdProducto.Valor)
        Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        Me.GridCoberturas.DataSource = Coberturas
        Me.GridCoberturas.Refresh()
        'colCobertura.OptionsColumn.AllowEdit = False
        'colDescripcion.OptionsColumn.AllowEdit = False

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
            If txtIdPoliza.Text <> "" Then
                Me.ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
            End If
            If cboIdProducto.Text <> "" Then
                Me.ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
            End If
            If txtIdCertificado.Text <> "" Then
                Me.ActualizarLlavesGrid(Me, txtIdCertificado.NombreCampo, txtIdCertificado.Valor)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CompletarCoberturas()
        Try
            'si el producto tiene coberturas adicionales las agregamos
            Dim sql As String = ""
            sql &= " select  * "
            sql &= " from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (select count(*) from PolizasCoberturas where PolizasCoberturas.idproducto = ProductosCoberturas.idproducto and PolizasCoberturas.idcobertura = ProductosCoberturas.idcobertura and PolizasCoberturas.idpoliza = " & dbStr(txtIdPoliza.Valor) & " and PolizasCoberturas.IdCertificado = " & dbStr(txtIdCertificado.Valor) & " ) = 0 "
            Dim CoberturasNuevas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            For Each filCobN As DataRow In CoberturasNuevas.Rows
                VistaCoberturas.AddNewRow()
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdPoliza", CStr(txtIdPoliza.Valor))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdProducto", CStr(cboIdProducto.Valor))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdCertificado", CStr(txtIdCertificado.Valor))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdCobertura", CInt(dbData(filCobN, "IdCobertura")))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Descripcion", CStr(dbData(filCobN, "Descripcion")))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "SumaAsegurada", CDbl(0))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PorceSuma", CDbl(0))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Tasa", CDbl(0))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Prima", CDbl(0))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Deducible", CStr(""))

                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "AplicarDescuento", CStr(dbData(filCobN, "AplicarDescuento")))
                VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "AplicarIva", CStr(dbData(filCobN, "AplicarIva")))
                VistaCoberturas.UpdateCurrentRow()
            Next

            Dim Coberturas As DataTable = StiGlobalConn.ObtenerDataset("select IdCobertura, Descripcion, AplicarDescuento, AplicarIva from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor)).Tables(0)
            Dim dtCob As DataTable = GridCoberturas.DataSource
            Try
                dtCob.Columns.Add("Descripcion", System.Type.GetType("System.String"))
            Catch ex As Exception

            End Try
            GridCoberturas.DataSource = dtCob
            Dim Cob As String = "", Desc As String = "", Exento As String = ""
            For I As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
                Try
                    Cob = Coberturas.Select("IdCobertura = " & dbInt(Me.VistaCoberturas.GetRowCellValue(I, "IdCobertura")))(0).Item("Descripcion")
                    Me.VistaCoberturas.SetRowCellValue(I, "Descripcion", Cob)
                    'actualizamos el campo de descuento según el ramo
                    Desc = Coberturas.Select("IdCobertura = " & dbInt(Me.VistaCoberturas.GetRowCellValue(I, "IdCobertura")))(0).Item("AplicarDescuento")
                    Me.VistaCoberturas.SetRowCellValue(I, "AplicarDescuento", Desc)
                Catch ex As Exception

                End Try
                Try
                    Exento = Coberturas.Select("IdCobertura = " & dbInt(Me.VistaCoberturas.GetRowCellValue(I, "IdCobertura")))(0).Item("AplicarIva")
                    Me.VistaCoberturas.SetRowCellValue(I, "AplicarIva", Exento)
                Catch ex As Exception

                End Try
            Next

            'si existen coberturas adicionales las completamos
            Coberturas = StiGlobalConn.ObtenerDataset("select IdCobertura, Descripcion from PolizasCoberturasAdicional where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0)
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
            MsgBox("Error al cargar las coberturas:" & vbCrLf & ex.Message)
        End Try
    End Sub

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
            PrimaSinDescuento = 0
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
            Me.txtPrimaBruta.Valor = 0
            Me.txtPorceDescuento.Valor = 0
            Me.txtValorDescuento.Valor = 0
            Me.txtPrimaNeta.Valor = 0
            Me.txtPrimaExenta.Valor = 0
            Me.txtGastosEmi.Valor = 0
            Me.txtGastosFrac.Valor = 0
            Me.txtGastosBomb.Valor = 0
            Me.txtGastosOtros.Valor = 0
            Me.txtIva.Valor = 0
            Me.txtTotal.Valor = 0

            Me.TabCertificados.SelectedTabPageIndex = 0
            Me.txtValorAsegurado.Focus()

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
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)

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
            sql &= " from PolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and c.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and c.idcertificado = " & dbStr(txtIdCertificado.Valor)

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,isnull(c.Descripcion, ca.Descripcion) as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.Prima"
            sql &= " ,p.Participacion"
            sql &= " ,isnull(p.PorceSuma,100) as PorceSuma"
            sql &= " ,isnull((select top 1 r.PorceSuma from PolizasCoberturas as r where r.IdPoliza = p.IdPoliza and r.IdProducto = p.IdProducto and r.IdCertificado = p.IdCertificado and PorceSuma is not null),100) as PorceSumaCert"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " left join PolizasCoberturasAdicional as ca on ca.IdPoliza = p.IdPoliza and ca.IdProducto = p.IdProducto and ca.IdCertificado = p.IdCertificado and ca.IdCobertura = p.IdCobertura"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and p.idcertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " and (p.SumaAsegurada > 0 or p.CoberturaAdicional = 1 )"
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
            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and p.idcertificado = " & dbStr(txtIdCertificado.Valor)
            sql &= " order by p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"


            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " ,p.Categoria"
            sql &= " from PolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            If MsgBox("¿Desea incluir la condiciones especiales?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PREGUNTA...") = MsgBoxResult.No Then
                sql &= " and p.idproducto = '123XYZ' "
            End If

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(tblLogo.Copy)




            Dim rep As New frmReportes
            Dim Reporte As Object
            Reporte = New RepDetCertificado
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Certificado")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

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
        Dim Validar As String = ""
        Try
            Validar = clSeguros.ObtenerDBParametros("Datos.Tecnicos.Obliga")
            If Validar.Trim.ToUpper <> "N" Then
                For NB As Integer = 0 To Me.VistaBienes.DataRowCount - 1
                    If IsDBNull(VistaBienes.GetRowCellValue(NB, "DescripcionBien")) = True Then
                        res &= "El campo " & VistaBienes.GetRowCellValue(NB, "NombreBien") & " es obligatorio; "
                    Else
                        If CStr(VistaBienes.GetRowCellValue(NB, "DescripcionBien")).Trim = "" Then
                            res &= "El campo " & VistaBienes.GetRowCellValue(NB, "NombreBien") & " es obligatorio; "
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            'Debug.WriteLine(ex.Message)
        End Try

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

    Private Sub btnQuitarCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCob.Click
        Try
            'tenemos que verificar que la cobertura seleccionada no sea una cobertura básica
            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCobertura = " & dbInt(VistaCoberturas.GetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdCobertura"))).Tables(0).Rows(0).Item(0)
            If Existe > 0 Then
                MsgBox("Únicamente es posible eliminar coberturas adicionales, las coberturas básicas del producto no deben ser eliminadas.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Me.EliminarFilaGrid(VistaCoberturas)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCob.Click
        Try
            Dim IdCob As Integer = ObtenerIDCob()
            Me.AgregarFilaGrid(VistaCoberturas)
            VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdCobertura", IdCob)
            VistaCoberturas.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDCob() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaCoberturas.DataRowCount - 1
            Try
                If CInt(VistaCoberturas.GetRowCellValue(I, "IdCobertura")) > Id Then
                    Id = CInt(VistaCoberturas.GetRowCellValue(I, "IdCobertura"))
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

    Private Sub txtPorceDescuento_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPorceDescuento.ValueChangeOnExit
        Call CalcularPrimaNeta()
    End Sub

    Private Sub txtValorDescuento_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtValorDescuento.ValueChangeOnExit
        Call CalcularPrimaNeta()
    End Sub

    Private Sub txtPrimaBruta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPrimaBruta.ValueChangeOnExit
        Call CalcularPrimaNeta()
    End Sub

    Private Sub btnObtenerDatosPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObtenerDatosPC.Click
        If MsgBox("¿Realmente desea reemplazar los valores actuales de coberturas por los del primer certificado de la póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.Yes Then
            Try
                'verificamos si existe algún certificado
                Dim dtCert As DataTable
                dtCert = StiGlobalConn.ObtenerDataset("select IdCertificado, PrimaMinima from PolizasCertificados where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdCertificado").Tables(0)
                If dtCert.Rows.Count = 0 Then
                    MsgBox("No existen Certificados en la póliza.", MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
                ActualizandoCoberturas = True
                Dim IdCertificado As String = dtCert.Rows(0).Item(0)
                txtPrimaMinima.Valor = Val(dbData(dtCert.Rows(0), "PrimaMinima"))
                Dim dtCob As DataTable = StiGlobalConn.ObtenerDataset("select * from PolizasCoberturas where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(IdCertificado) & " order by IdCobertura").Tables(0)
                Dim FilCob As DataRow, Fila As Integer
                For Each FilCob In dtCob.Rows
                    Fila = ObtenerFilaCob(CInt(dbData(FilCob, "IdCobertura")))
                    If Fila >= 0 Then
                        'actualizamos la Suma, Tasa, prima, %suma y Deducible
                        VistaCoberturas.SetRowCellValue(Fila, "SumaAsegurada", Val(dbData(FilCob, "SumaAsegurada")))
                        VistaCoberturas.SetRowCellValue(Fila, "PorceSuma", Val(dbData(FilCob, "PorceSuma")))
                        VistaCoberturas.SetRowCellValue(Fila, "Tasa", Val(dbData(FilCob, "Tasa")))
                        VistaCoberturas.SetRowCellValue(Fila, "Prima", Val(dbData(FilCob, "Prima")))
                        VistaCoberturas.SetRowCellValue(Fila, "Deducible", dbData(FilCob, "Deducible"))


                        VistaCoberturas.SetRowCellValue(Fila, "AplicarDescuento", dbData(FilCob, "AplicarDescuento"))
                        VistaCoberturas.SetRowCellValue(Fila, "Participacion", dbData(FilCob, "Participacion"))
                        VistaCoberturas.SetRowCellValue(Fila, "AplicarIva", dbData(FilCob, "AplicarIva"))
                        VistaCoberturas.SetRowCellValue(Fila, "PrimaMinima", Val(dbData(FilCob, "PrimaMinima")))
                        VistaCoberturas.SetRowCellValue(Fila, "PrimaMaxima", Val(dbData(FilCob, "PrimaMaxima")))
                        VistaCoberturas.SetRowCellValue(Fila, "DeducibleMinimo", Val(dbData(FilCob, "DeducibleMinimo")))
                        VistaCoberturas.SetRowCellValue(Fila, "DeducibleMaximo", Val(dbData(FilCob, "DeducibleMaximo")))
                        VistaCoberturas.SetRowCellValue(Fila, "PrimaAnual", Val(dbData(FilCob, "PrimaAnual")))

                        If Val(dbData(FilCob, "PorceDeducible")) > 0 Then VistaCoberturas.SetRowCellValue(Fila, "PorceDeducible", Val(dbData(FilCob, "PorceDeducible")))

                    Else
                        'el certificado tiene una cobertura adicional que debe incluirse tambien.
                        Dim IdCob As Integer = ObtenerIDCob()
                        Me.AgregarFilaGrid(VistaCoberturas)
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "IdCobertura", IdCob)
                        Try
                            Dim NomCob As String = StiGlobalConn.ObtenerDataset("select Descripcion from PolizasCoberturasAdicional where IdPoliza = " & dbStr(dbData(FilCob, "IdPoliza")) & " and IdProducto = " & dbStr(dbData(FilCob, "IdProducto")) & " and IdCertificado = " & dbStr(dbData(FilCob, "IdCertificado")) & " and IdCobertura = " & dbInt(dbData(FilCob, "IdCobertura"))).Tables(0).Rows(0).Item(0)
                            VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Descripcion", NomCob)
                        Catch ex As Exception

                        End Try

                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "SumaAsegurada", Val(dbData(FilCob, "SumaAsegurada")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PorceSuma", Val(dbData(FilCob, "PorceSuma")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Tasa", Val(dbData(FilCob, "Tasa")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Prima", Val(dbData(FilCob, "Prima")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Deducible", dbData(FilCob, "Deducible"))

                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "AplicarDescuento", dbData(FilCob, "AplicarDescuento"))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "Participacion", dbData(FilCob, "Participacion"))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "AplicarIva", dbData(FilCob, "AplicarIva"))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PrimaMinima", Val(dbData(FilCob, "PrimaMinima")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PrimaMaxima", Val(dbData(FilCob, "PrimaMaxima")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "DeducibleMinimo", Val(dbData(FilCob, "DeducibleMinimo")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "DeducibleMaximo", Val(dbData(FilCob, "DeducibleMaximo")))
                        VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PrimaAnual", Val(dbData(FilCob, "PrimaAnual")))

                        If Val(dbData(FilCob, "PorceDeducible")) > 0 Then VistaCoberturas.SetRowCellValue(VistaCoberturas.FocusedRowHandle, "PorceDeducible", Val(dbData(FilCob, "PorceDeducible")))

                        VistaCoberturas.UpdateCurrentRow()
                    End If
                Next
                ActualizandoCoberturas = False
                Call ReCalcularPrimaCoberturas()
                'Call CalcularPrimaCoberturas()
                MsgBox("Se ha completado la copia de las coberturas.", MsgBoxStyle.Information, "AVISO...")
            Catch ex As Exception
                MsgBox("Error al importar coberturas." & vbCrLf & ex.ToString, MsgBoxStyle.Exclamation, "ERROR...")
            End Try
        End If
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

    Private Sub cboPlan_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboPlan.ValueChangeOnExit
        'cargaremos la configuracion del plan
        If Me.cboPlan.Valor <> "" Then
            Try
                ActualizandoCoberturas = True
                Dim dtPlanCob As DataTable, FilPlan As DataRow, Fila As Integer
                Dim filPlanes As DataRow = StiGlobalConn.ObtenerDataset("select * from Planes where idplan = " & dbStr(cboPlan.Valor)).Tables(0).Rows(0)
                If Val(dbData(filPlanes, "PrimaMinimaNeta")) > 0 Then txtPrimaMinima.Valor = Val(dbData(filPlanes, "PrimaMinimaNeta"))


                dtPlanCob = StiGlobalConn.ObtenerDataset("select * from PlanesCoberturas where idplan = " & dbStr(cboPlan.Valor)).Tables(0)
                For Each FilPlan In dtPlanCob.Rows
                    Try
                        Fila = ObtenerFilaCob(CInt(dbData(FilPlan, "IdCobertura")))
                        If Fila >= 0 Then
                            Me.VistaCoberturas.FocusedRowHandle = Fila

                            'suma
                            If Val(dbData(FilPlan, "Suma")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "SumaAsegurada", CDbl(dbData(FilPlan, "Suma")))
                            End If

                            '%suma
                            If Val(dbData(FilPlan, "PorceSuma")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "PorceSuma", CDbl(dbData(FilPlan, "PorceSuma")))
                            End If

                            'Tasa
                            If Val(dbData(FilPlan, "Tasa")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "Tasa", CDbl(dbData(FilPlan, "Tasa")))
                            End If

                            'Prima
                            If Val(dbData(FilPlan, "Prima")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "Prima", CDbl(dbData(FilPlan, "Prima")))
                            End If

                            'Deducible
                            If dbData(FilPlan, "Deducible") <> "" Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "Deducible", dbData(FilPlan, "Deducible"))
                            End If

                            'prima minima
                            If Val(dbData(FilPlan, "PrimaMinima")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "PrimaMinima", CDbl(dbData(FilPlan, "PrimaMinima")))
                            End If

                            'prima maxima
                            If Val(dbData(FilPlan, "PrimaMaxima")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "PrimaMaxima", CDbl(dbData(FilPlan, "PrimaMaxima")))
                            End If

                            'deducible minimo
                            If Val(dbData(FilPlan, "DeducibleMinimo")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "DeducibleMinimo", CDbl(dbData(FilPlan, "DeducibleMinimo")))
                            End If

                            'deducible maximo
                            If Val(dbData(FilPlan, "DeducibleMaximo")) > 0 Then
                                Me.VistaCoberturas.SetRowCellValue(Fila, "DeducibleMaximo", CDbl(dbData(FilPlan, "DeducibleMaximo")))
                            End If

                            If Val(dbData(FilPlan, "PorceDeducible")) > 0 Then
                                VistaCoberturas.SetRowCellValue(Fila, "PorceDeducible", Val(dbData(FilPlan, "PorceDeducible")))
                            End If

                            CalcularPrimaCoberturaFila("Tasa", Fila)
                        End If
                    Catch ex As Exception

                    End Try
                Next
                Me.VistaCoberturas.FocusedRowHandle = 0
                ActualizandoCoberturas = False
                Call ReCalcularPrimaCoberturas()
                'Call CalcularPrimaCoberturas()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub AplicarSumasPlanR1()
        'los planes tienen almacenados una condición que indica si una cobertura será un % del R1

        If Me.cboPlan.Text <> "" Then
            Try
                Dim SumaR1 As Double = Me.VistaCoberturas.GetRowCellValue(0, "SumaAsegurada")
                If SumaR1 > 0 Then
                    Dim dtPlanCob As DataTable, FilPlan As DataRow, Fila As Integer
                    dtPlanCob = StiGlobalConn.ObtenerDataset("select IdCobertura, PorceSumaR1 from PlanesCoberturas where idplan = " & dbStr(cboPlan.Valor) & " and PorceSumaR1 > 0").Tables(0)
                    For Each FilPlan In dtPlanCob.Rows
                        Try
                            Fila = ObtenerFilaCob(CInt(dbData(FilPlan, "IdCobertura")))
                            If Fila >= 0 Then
                                VistaCoberturas.FocusedRowHandle = Fila
                                Me.VistaCoberturas.SetRowCellValue(Fila, "SumaAsegurada", Math.Round(SumaR1 * (Val(dbData(FilPlan, "PorceSumaR1")) / 100), 2))
                            End If
                        Catch ex As Exception

                        End Try
                    Next
                    VistaCoberturas.FocusedRowHandle = 0
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CalcularDiasCobertura()
        Try
            txtDiasCob.Valor = ObtenerDiasCobertura(txtVigenciaDesde.Valor, txtVigenciaHasta.Valor)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            txtFechaInclusion.Valor = txtVigenciaDesde.Valor
        End If

        Call CalcularDiasCobertura()
        Call ReCalcularPrimaCoberturas()
    End Sub

    Private Sub txtVigenciaHasta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaHasta.ValueChangeOnExit
        Call CalcularDiasCobertura()
        Call ReCalcularPrimaCoberturas()
    End Sub

    Private Sub btnAgregarAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAnexo.Click
        Try
            Dim IdAnx As Integer = ObtenerIDAnx()
            Me.AgregarFilaGrid(VistaAnexos)
            Dim Fila As Integer = VistaAnexos.FocusedRowHandle
            VistaAnexos.SetRowCellValue(Fila, "IdAnexo", IdAnx)
            VistaAnexos.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDAnx() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaAnexos.DataRowCount - 1
            Try
                If CInt(VistaAnexos.GetRowCellValue(I, "IdAnexo")) > Id Then
                    Id = CInt(VistaAnexos.GetRowCellValue(I, "IdAnexo"))
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

    Private Sub btnQuitarAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarAnexo.Click
        Try
            Me.EliminarFilaGrid(VistaAnexos)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtPrimaMinima_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPrimaMinima.ValueChangeOnExit
        Call CalcularPrimaCoberturas()
    End Sub

    Private Sub txtFechaExclusion_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaExclusion.ValueChangeOnExit
        Try
            If txtFechaExclusion.Text <> "" Then Me.txtVigenciaDesde.Valor = Me.txtFechaExclusion.Valor
            Call txtVigenciaDesde_ValueChangeOnExit(Nothing, Nothing, "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtIdCliente_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdCliente.ValueChangeOnExit

    End Sub

End Class
