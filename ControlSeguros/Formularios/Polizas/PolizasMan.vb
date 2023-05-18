
imports Utilerias.Genericas

Public Class PolizasMan

    Private blnVendedorModificado As Boolean = False

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                Dim filCliente As DataRow = StiGlobalConn.ObtenerDataset("select NombreCliente, TarjetaHabiente, NumeroTarjeta, VencimientoTarjeta, EmisorTarjeta, IdTipoPago, EnvioFactura, IdBanco, NombreCuentaHabiente, CuentaBancaria from Clientes where idcliente = " & dbStr(busCodigo)).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(filCliente, "NombreCliente")
                txtTarjetaHabiente.Valor = dbData(filCliente, "TarjetaHabiente")
                txtNumeroTarjeta.Valor = dbData(filCliente, "NumeroTarjeta")
                txtVencimientoTarjeta.Valor = dbData(filCliente, "VencimientoTarjeta")
                txtEmisorTarjeta.Valor = dbData(filCliente, "EmisorTarjeta")
                cboIdTipoPago.Valor = dbData(filCliente, "IdTipoPago")
                txtEnvioFactura.Valor = dbData(filCliente, "EnvioFactura")
                cboIdBanco.Valor = dbData(filCliente, "IdBanco")
                txtNombreCuentaHabiente.Valor = dbData(filCliente, "NombreCuentaHabiente")
                txtCuentaBancaria.Valor = dbData(filCliente, "CuentaBancaria")

            Catch ex As Exception

            End Try
            Me.txtNombreCliente.Focus()
            If Me.cboEjecutivoCta.Valor = "" Then
                Me.cboEjecutivoCta.Valor = clSeguros.ObtenerEjecutivoCuenta(Me.txtIdCliente.Valor, Me.cboIdProducto.Valor, "POLIZAS")
            End If
            Call MostrarGrupo()
        End If
    End Sub

    Private Sub PolizasMan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
            Call CargarCertificados()
        End If
    End Sub

    Private Sub PolizasMan_AntesDeCargarFormulario() Handles Me.AntesDeCargarFormulario
        Dim strLista As String = clSeguros.ObtenerDBParametros("Lista.Tipos.Polizas")
        Dim strListaTipo As String = ""
        Dim strItem As String = ""

        If strLista.Trim <> "" Then
            For I As Integer = 0 To Utilerias.Genericas.CuentaCar(strLista, ",")
                strItem = Strings.Left(Utilerias.Genericas.stiSplit(strLista, "G" & I & ",1").Trim, 150).Trim
                If strItem <> "" Then
                    If strListaTipo = "" Then
                        strListaTipo = Replace(strItem, " ", "_") & " " & strItem
                    Else
                        strListaTipo &= "|" & Replace(strItem, " ", "_") & " " & strItem
                    End If
                End If
            Next
        End If
        cboTipoPoliza.Lista = strListaTipo

    End Sub

    Private Sub PolizasMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If Me.txtNumVigencia.Valor <= 0 Then
            MsgBox("El número de vigencia no es válido, debe ser mayor o igual a uno.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If

        If clSeguros.ObtenerDBParametros("Polizas.Vendedor.Obliga").ToString.Trim.ToUpper = "S" And VistaVendedores.DataRowCount = 0 Then
            'lo validamos si la póliza no existe en el sistema
            Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            If Existe > 0 Then
                MsgBox("Debe especificar un vendedor para la póliza.", MsgBoxStyle.Exclamation, "AVISO...")
                Cancel = True
            End If
        End If


        ''si hay vendedores debe existir un vendedor orden = 1
        If Me.VistaVendedores.DataRowCount > 0 Then
            Dim Existe As Boolean = False
            For NV As Integer = 0 To Me.VistaVendedores.DataRowCount - 1
                If Me.VistaVendedores.GetRowCellValue(NV, "Orden") = 1 Then
                    Existe = True
                    Exit For
                End If
            Next
            If Existe = False Then
                MsgBox("Debe existir un vendedor con el Id: 1.", MsgBoxStyle.Information, "AVISO...")
                Cancel = True
            End If
        End If

        Call ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
        Call ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)

    End Sub

    Private Sub PolizasMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Me.TabPoliza.Enabled = True
        VerificarBotonesImprimir()
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Dim msgflujo As String = clFlujos.IniciarFlujoPoliza(txtIdPoliza.Valor, cboIdProducto.Valor)
            If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")
        End If

        If blnVendedorModificado = True Then
            Try
                StiGlobalConn.SQLExecute("update Polizas set UsuarioModificaVendedores = " & dbStr(StiGlobalConn.User, 25) & ", FechaModificaVendedores = " & dbFec(Date.Now, "1") & " where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor))
                blnVendedorModificado = False
            Catch ex As Exception

            End Try
        End If

        Try
            If Me.ModoGuardarComo = True Then

                'ahora trasladamos los datos de los certificados
                Dim sql As String = ""

                sql = "  insert into PolizasCertificados (IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, IdVendedor, UsuarioModifica, FechaModifica, Deducible, Participacion, PorceDescuento, ValorDescuento, PrimaBruta,IdPlan) "
                sql &= " select " & dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & ", IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, IdVendedor, UsuarioModifica, FechaModifica, Deducible, Participacion, PorceDescuento, ValorDescuento, PrimaBruta, IdPlan "
                sql &= " from PolizasCertificados"
                sql &= " where " & Me.dbCondicion
                StiGlobalConn.SQLExecute(sql)

                sql = "  insert into PolizasBeneficiarios (IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje) "
                sql &= " select " & dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & ", IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje "
                sql &= " from PolizasBeneficiarios"
                sql &= " where " & Me.dbCondicion
                StiGlobalConn.SQLExecute(sql)

                sql = "  insert into PolizasBienes (IdPoliza, IdProducto, IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima)"
                sql &= " select  " & dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & ", IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima"
                sql &= " from PolizasBienes"
                sql &= " where " & Me.dbCondicion
                StiGlobalConn.SQLExecute(sql)

                sql = "  insert into PolizasCesiones (IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones)"
                sql &= " select " & dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & ", IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones"
                sql &= " from PolizasCesiones"
                sql &= " where " & Me.dbCondicion
                StiGlobalConn.SQLExecute(sql)

                sql = "  insert into PolizasCoberturas (IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma) "
                sql &= " select  " & dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & ", IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma"
                sql &= " from PolizasCoberturas"
                sql &= " where " & Me.dbCondicion
                StiGlobalConn.SQLExecute(sql)

                sql = "  insert into PolizasCoberturasAdicional (IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion) "
                sql &= " select  " & dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & ", IdCertificado, IdCobertura, Descripcion"
                sql &= " from PolizasCoberturasAdicional"
                sql &= " where " & Me.dbCondicion
                StiGlobalConn.SQLExecute(sql)

                'al terminar de guardar desactivamos la modalidad para que no existan errores
                Me.ModoGuardarComo = False

                Call CargarCertificados()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PolizasMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VistaDoc.OptionsBehavior.Editable = False
        cboDepartamento.OcultarColumna(1)

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.cboEstadoPoliza.Valor = "VIGENTE"
                Me.cboTipoDeducible.Valor = "V"
                VistaCertificados.OptionsBehavior.Editable = False
                Me.txtNumVigencia.Valor = 1
                Me.TabPoliza.Enabled = False

                If CStr(clSeguros.ObtenerDBParametros("Poliza.Vendedor.Default")) <> "" Then
                    Dim dtVen As DataTable = StiGlobalConn.ObtenerDataset("select IdVendedor, IdTipoVendedor from Vendedores where IdVendedor = " & dbStr(clSeguros.ObtenerDBParametros("Poliza.Vendedor.Default"))).Tables(0)
                    If dtVen.Rows.Count > 0 Then
                        Dim IdVen As Integer = ObtenerIDVen()
                        VistaVendedores.AddNewRow()
                        Dim Fila As Integer = VistaVendedores.FocusedRowHandle
                        VistaVendedores.SetRowCellValue(Fila, "Orden", IdVen)
                        VistaVendedores.SetRowCellValue(Fila, "IdVendedor", dbData(dtVen.Rows(0), "IdVendedor"))
                        VistaVendedores.SetRowCellValue(Fila, "IdTipoVendedor", dbData(dtVen.Rows(0), "IdTipoVendedor"))
                        VistaVendedores.UpdateCurrentRow()
                        blnVendedorModificado = False
                    End If
                End If

            Case enEstadoRegistro.Modificando
                Call CargarCertificados()
                Call VerificarBotonesImprimir()


                VistaCertificados.OptionsBehavior.Editable = False

                If cboEstadoPoliza.Valor = "CANCELADA" Then
                    Me.EstadoEntradas(False, Me)
                    Me.VistaDoc.OptionsBehavior.Editable = False
                    Me.btnAgregarCert.Enabled = False
                    Me.btnAgregarClausula.Enabled = False
                    Me.btnQuitarClausula.Enabled = False
                    Me.btnBuscarCliente.Enabled = False
                    Me.btnGuardar.Enabled = False
                    btnAgregarVendedor.Enabled = False
                    btnQuitarVendedor.Enabled = False
                    btnAgregarDoc.Enabled = False
                    btnAgregarCarpeta.Enabled = False
                    btnQuitarDoc.Enabled = False

                    MsgBox("La póliza se encuentra cancelada no podrá realizar ningun cambio." & vbCrLf & "Cod.:" & cboIdCancelacion.Descripcion & vbCrLf & "Motivo: " & txtMotivoCancelacion.Valor, MsgBoxStyle.Information, "AVISO...")
                End If

                If cboEjecutivoCta.Valor = "" Then
                    cboEjecutivoCta.Valor = clSeguros.ObtenerEjecutivoCuenta(Me.txtIdCliente.Valor, Me.cboIdProducto.Valor, "POLIZAS")
                End If

        End Select

        Call ProcesarPermisosComision()
        Call MostrarGrupo()


        Dim TD As New DataTable
        TD.Columns.Add("Categoria", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        Try
            Dim lstClausulas As String = clSeguros.ObtenerDBParametros("Tipos.Clausulas")
            Dim NumClausulas As Integer = CuentaCar(lstClausulas, ","), TipoClausula As String = ""
            For NC As Integer = 0 To NumClausulas
                TipoClausula = stiSplit(lstClausulas, "G" & NC & ",1").Trim
                FilaTD = TD.NewRow : FilaTD("Categoria") = TipoClausula : TD.Rows.Add(FilaTD)
            Next
        Catch ex As Exception

        End Try

        'FilaTD = TD.NewRow : FilaTD("Categoria") = "Especificaciones del Seguro" : TD.Rows.Add(FilaTD)
        'FilaTD = TD.NewRow : FilaTD("Categoria") = "Coberturas"  :TD.Rows.Add(FilaTD)
        'FilaTD = TD.NewRow : FilaTD("Categoria") = "Condiciones Especiales"  :TD.Rows.Add(FilaTD)
        'FilaTD = TD.NewRow : FilaTD("Categoria") = "Beneficios Adicionales"  :TD.Rows.Add(FilaTD)

        RepositoryItemLookUpEdit1.ValueMember = "Categoria"
        RepositoryItemLookUpEdit1.DisplayMember = "Categoria"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TD
        RepositoryItemLookUpEdit1.PopulateColumns()

        Dim dtVendedores As DataTable
        dtVendedores = StiGlobalConn.ObtenerDataset("select IdVendedor as Id, NombreVendedor as Vendedor from Vendedores").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Vendedor"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = dtVendedores
        RepositoryItemLookUpEdit2.PopulateColumns()

        Dim dtTiposComi As DataTable
        dtTiposComi = StiGlobalConn.ObtenerDataset("select IdTipoVendedor as Id, NombreTipoVendedor as TipoComision from TipoVendedor").Tables(0)
        RepositoryItemLookUpEdit3.ValueMember = "Id"
        RepositoryItemLookUpEdit3.DisplayMember = "TipoComision"
        RepositoryItemLookUpEdit3.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit3.DataSource = dtTiposComi
        RepositoryItemLookUpEdit3.PopulateColumns()

        'La lista de las opciones del origen se almacenan en una parámetro
        Dim OrigenesPol As String = CStr(clSeguros.ObtenerDBParametros("Cod.Origen.Poliza")).Trim
        If OrigenesPol <> "" Then
            cboOrigen.Lista = OrigenesPol
            cboOrigen.Llenar_Combo()
        End If
        ColDirectorio.Group()
        Call CalcularDiasCobertura()

        Select Case GlobalCodCliente
            Case "2120000"
                cboNegocioPor.Visible = True
                cboNegocioPor.Obligatorio = True
                cboTipoPoliza.Visible = True
                cboTipoPoliza.Obligatorio = True
                cboTipoPoliza.OcultarColumna(0)

            Case Else
                cboNegocioPor.Visible = False
                cboNegocioPor.Obligatorio = False
                cboTipoPoliza.Visible = False
                cboTipoPoliza.Obligatorio = False
        End Select

        Dim UsuariosVend As String = CStr(clSeguros.ObtenerDBParametros("Poliza.Vendedores.Usuarios")).Trim
        If UsuariosVend <> "" Then
            If Not (UsuariosVend Like "*" & StiGlobalConn.User & "*") Then
                btnAgregarVendedor.Enabled = False
                Me.btnQuitarVendedor.Enabled = False
                VistaVendedores.OptionsBehavior.Editable = True
                For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In VistaVendedores.Columns
                    ColVista.OptionsColumn.ReadOnly = True
                Next
            End If
        End If

        Dim opcCliente As String = clSeguros.ObtenerDBParametros("Clientes.ActEjecutivo")
        If opcCliente <> "" Then
            Me.cboEjecutivoCta.SoloLectura = True
        End If

    End Sub

    Private Sub MostrarGrupo()
        Dim Grupo As String = ""
        Try
            Grupo = StiGlobalConn.ObtenerDataset("select isnull(grupoCliente,'') as Grupo from clientes where idcliente = " & dbStr(txtIdCliente.Valor)).Tables(0).Rows(0).Item(0)
            Me.txtGrupoCliente.Valor = Grupo
            Me.txtGrupoCliente.SoloLectura = True
        Catch ex As Exception
            Grupo = ""
        End Try

    End Sub

    Private Sub VerificarBotonesImprimir()
        Try
            Dim Ramo As String = ""
            Ramo = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Select Case Ramo
                Case "501"
                    Me.btnImprimirAutos.Visible = True
                    Me.btnImprimirAutosExcluidos.Visible = True
                Case Else
                    Me.btnImprimirAutos.Visible = False
                    Me.btnImprimirAutosExcluidos.Visible = False
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                txtPorceComision.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.cboEstadoPoliza.Valor = "VIGENTE"
        Me.txtNumVigencia.Valor = 1
        Me.txtIdPoliza.Focus()
        Me.TabPoliza.Enabled = False
        Call VerificarBotonesImprimir()
    End Sub

    Private Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        Try
            Me.txtVigenciaHasta.Valor = CDate(Me.txtVigenciaDesde.Valor).AddYears(1)
            Call CalcularDiasCobertura()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.InitialDirectory = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                'si existe un parametro que indique la ruta global de los documentos validamos
                Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza")
                Dim resRuta As String = ""
                If RutaBase <> "" And txtIdPoliza.Text <> "" Then
                    RutaBase = RutaBase & "\" & txtIdPoliza.Text & "\"
                    'creamos la carpeta si no existe
                    resRuta = CreaRuta(RutaBase)
                    If resRuta = "" Then
                        'movemos el archivo a la nueva carpeta
                        RutaBase &= System.IO.Path.GetFileName(Documento)
                        If System.IO.File.Exists(RutaBase) = False Then
                            System.IO.File.Copy(Documento, RutaBase)
                        Else
                            MsgBox("Ya existe un archivo con el mismo nombre en el repositorio de documentos de pólizas.", MsgBoxStyle.Information, "AVISO...")
                            Exit Sub
                        End If
                        Documento = RutaBase
                    End If
                End If

                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Documento)
                Me.VistaDoc.SetRowCellValue(Fila, "Archivo", System.IO.Path.GetFileName(Documento))
                Me.VistaDoc.SetRowCellValue(Fila, "Directorio", Replace(System.IO.Path.GetDirectoryName(Documento), clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza"), ""))
                Me.VistaDoc.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDoc() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                If CInt(VistaDoc.GetRowCellValue(I, "IdDocumento")) > Id Then
                    Id = CInt(VistaDoc.GetRowCellValue(I, "IdDocumento"))
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

    Private Sub txtIdPoliza_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdPoliza.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdPoliza.NombreCampo, txtIdPoliza.Valor)
    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdProducto.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, cboIdProducto.NombreCampo, cboIdProducto.Valor)
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando And Me.txtPorceComision.Text = "" Then
            'buscamos la comisión del producto
            Dim Comi As Double = 0
            Try
                Comi = StiGlobalConn.ObtenerDataset("select PorceComi from ProductosComisionesExternas where idproducto = " & dbStr(Me.cboIdProducto.Valor) & " and IdComision = 1").Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Comi = 0
            End Try
            Me.txtPorceComision.Valor = Comi

        End If
        If cboEjecutivoCta.Valor = "" Then
            Me.cboEjecutivoCta.Valor = clSeguros.ObtenerEjecutivoCuenta(Me.txtIdCliente.Valor, Me.cboIdProducto.Valor, "POLIZAS")
        End If


    End Sub

    Private Sub VistaDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaDoc.DoubleClick
        Try
            Dim fila As Integer = VistaDoc.FocusedRowHandle
            If fila >= 0 Then
                Dim Doc As String = Me.VistaDoc.GetRowCellValue(fila, "Documento")
                If Doc <> "" Then
                    Dim esCarpeta As String = ""
                    Try
                        esCarpeta = System.IO.Path.GetExtension(Doc)
                    Catch ex As Exception
                        esCarpeta = ""
                    End Try
                    If esCarpeta = "" Then
                        System.Diagnostics.Process.Start(Doc)
                    Else
                        If System.IO.File.Exists(Doc) = True Then
                            ''Shell(Doc, AppWinStyle.NormalFocus)
                            System.Diagnostics.Process.Start(Doc)
                        Else
                            MsgBox("El documentos no se encuentra en la ruta especificada.", MsgBoxStyle.Information, "AVISO...")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDoc.Click
        Try
            Me.EliminarFilaGrid(VistaDoc)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCert.Click
        Dim frmCert As New PolizasCertificadosMan
        frmCert.dbTabla = "PolizasCertificados"
        frmCert.Permiso = Me.Permiso
        Dim Vendedor As String = ""
        Try
            Vendedor = Me.VistaVendedores.GetRowCellValue(0, "IdVendedor")
        Catch ex As Exception
            Vendedor = ""
        End Try
        frmCert.ClavesNuevo = Me.txtIdPoliza.Valor & "|" & Me.cboIdProducto.Valor & "|" & Me.txtIdCliente.Valor & "|" & CDate(Me.txtVigenciaDesde.Valor).ToShortDateString & "|" & CDate(Me.txtVigenciaHasta.Valor).ToShortDateString & "|" & Vendedor
        frmCert.EstadoRegistro = enEstadoRegistro.Adicionando
        frmCert.STIConn = StiGlobalConn
        If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
            frmCert.MdiParent = Me.MdiParent
            frmCert.Show()
        Else
            frmCert.ShowDialog(Me)
        End If


        Call CargarCertificados()
    End Sub

    Private Sub CargarCertificados()
        GridCertificados.DataSource = Nothing
        GridCertificados.Refresh()
        Dim sql As String = ""
        Try
            sql = "  select IdCertificado, IdCertificadoAseguradora, NombreCliente, VigenciaDesde, VigenciaHasta, isnull(primaneta,0) as Prima, ValorAsegurado"
            sql &= " , (isnull(GastosEmi,0)+isnull(GastosFrac,0)+isnull(GastosBomb,0)+isnull(GastosOtros,0)) as Gastos, isnull(iva,0) as Iva, isnull(total,0) as Total, isnull(estadocertificado,'') as Estado "
            sql &= " , isnull(( select top 1 descripcionbien from PolizasBienes where Polizasbienes.idpoliza = PolizasCertificados.idpoliza and Polizasbienes.idproducto = PolizasCertificados.idproducto and Polizasbienes.idcertificado = PolizasCertificados.idcertificado and nombrebien = 'placa'  ),'') as Placa"
            sql &= " from PolizasCertificados"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            Dim Certificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If Certificados.Rows.Count > 0 Then
                GridCertificados.DataSource = Certificados
                GridCertificados.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaCertificados_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs) Handles VistaCertificados.CustomColumnSort
        Try
            'el campo es alfanumerico pero se trata de ordenar numérico
            If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
                Return
            End If
            e.Handled = True

            Dim s1 As Double = 0, s2 As Double = 0
            If e.Column.FieldName = "IdCertificado" Then
                s1 = ConvertirANumero(e.Value1.ToString())
                s2 = ConvertirANumero(e.Value2.ToString())
            End If

            If s1 > s2 Then
                e.Result = 1
            Else
                If s1 = s2 Then
                    e.Result = Comparer(Of Double).Default.Compare(s1, s2)
                Else
                    e.Result = -1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaCertificados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaCertificados.DoubleClick
        Try
            Dim fila As Integer
            fila = VistaCertificados.FocusedRowHandle
            If fila >= 0 Then
                Dim frmCert As New PolizasCertificadosMan
                frmCert.dbTabla = "PolizasCertificados"
                frmCert.STIConn = StiGlobalConn
                frmCert.Permiso = Me.Permiso
                Dim Vendedor As String = ""
                Try
                    Vendedor = VistaVendedores.GetRowCellValue(0, "IdVendedor")
                Catch ex As Exception
                    Vendedor = ""
                End Try
                frmCert.dbCondicion = "IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(Me.VistaCertificados.GetRowCellValue(fila, "IdCertificado"))
                frmCert.ClavesNuevo = Me.txtIdPoliza.Valor & "|" & Me.cboIdProducto.Valor & "|" & Me.txtIdCliente.Valor & "|" & CDate(Me.txtVigenciaDesde.Valor).ToShortDateString & "|" & CDate(Me.txtVigenciaHasta.Valor).ToShortDateString & "|" & Vendedor
                If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
                    frmCert.MdiParent = Me.MdiParent
                    frmCert.Show()
                Else
                    frmCert.ShowDialog(Me)
                    Call CargarCertificados()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregarClausula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarClausula.Click
        Try
            Dim IdCla As Integer
            Dim Fila As Integer
            'propondremos una clausula
            Try
                Dim IdRamo As String = ""
                busCodigo = ""
                Dim Fbus As New BusquedaCondiciones
                IdRamo = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                Fbus.dbFiltro = " and c.idramo = " & dbStr(IdRamo)
                Fbus.ShowDialog()
                If busCodigo <> "" Then
                    Dim dtCla As DataTable = StiGlobalConn.ObtenerDataset("select IdCondicion, Descripcion from CondicionesEspeciales where IdCondicion in (" & busCodigo & ") ").Tables(0)
                    For Each FilCla As DataRow In dtCla.Rows
                        IdCla = ObtenerIDCla()
                        Me.AgregarFilaGrid(VistaClausulas)
                        Fila = VistaClausulas.FocusedRowHandle
                        VistaClausulas.SetRowCellValue(Fila, "IdClausula", IdCla)
                        VistaClausulas.SetRowCellValue(Fila, "Clausula", dbData(FilCla, "Descripcion"))
                        VistaClausulas.SetRowCellValue(Fila, "CodigoInterno", dbData(FilCla, "IdCondicion"))
                        VistaClausulas.UpdateCurrentRow()
                        Fila = VistaClausulas.FocusedRowHandle
                    Next
                Else
                    IdCla = ObtenerIDCla()
                    Me.AgregarFilaGrid(VistaClausulas)
                    Fila = VistaClausulas.FocusedRowHandle
                    VistaClausulas.SetRowCellValue(Fila, "IdClausula", IdCla)
                    VistaClausulas.UpdateCurrentRow()
                    Fila = VistaClausulas.FocusedRowHandle
                End If
            Catch ex As Exception

            End Try

        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDCla() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaClausulas.DataRowCount - 1
            Try
                If CInt(VistaClausulas.GetRowCellValue(I, "IdClausula")) > Id Then
                    Id = CInt(VistaClausulas.GetRowCellValue(I, "IdClausula"))
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

    Private Sub btnQuitarClausula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarClausula.Click
        Try
            Me.EliminarFilaGrid(VistaClausulas)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Call CargarCertificados()
        Call Me.VerificarBotonesImprimir()

        VistaCertificados.OptionsBehavior.Editable = False
        Me.EstadoEntradas(True, Me)
        Me.VistaDoc.OptionsBehavior.Editable = True
        Me.btnAgregarCert.Enabled = True
        Me.btnAgregarClausula.Enabled = True
        Me.btnQuitarClausula.Enabled = True
        Me.btnBuscarCliente.Enabled = True

        If cboEstadoPoliza.Valor = "CANCELADA" Then
            Me.EstadoEntradas(False, Me)
            Me.VistaDoc.OptionsBehavior.Editable = True
            Me.btnAgregarCert.Enabled = False
            Me.btnAgregarClausula.Enabled = False
            Me.btnQuitarClausula.Enabled = False
            Me.btnBuscarCliente.Enabled = False
            MsgBox("La póliza se encuentra cancelada no podrá realizar ningun cambio.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim res As String = ImprimirPoliza(Me.txtIdPoliza.Valor, Me.cboIdProducto.Valor)
        If res <> "" Then msgError(New Exception(res))
    End Sub

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            Dim Carpeta As String = ""
            FolderBrowserDialog1.SelectedPath = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            FolderBrowserDialog1.ShowDialog()
            Carpeta = FolderBrowserDialog1.SelectedPath
            If Carpeta <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Carpeta)
                Me.VistaDoc.SetRowCellValue(Fila, "Archivo", System.IO.Path.GetFileName(Carpeta))
                Me.VistaDoc.SetRowCellValue(Fila, "Directorio", System.IO.Path.GetDirectoryName(Carpeta))
                Me.VistaDoc.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnImprimirCertificados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirCertificados.Click
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
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and (p.SumaAsegurada > 0 or p.CoberturaAdicional = 1)"
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
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
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
            MsgBox("Existen problemas para imprimir los certificados." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AVISO...")
        End Try

    End Sub

    Private Sub IncluirDocumentosAutomaticos()
        'rutina que incluye los documentos automaticos de una ruta.
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza")
        Dim existe As Boolean
        If txtIdPoliza.Text <> "" And RutaBase <> "" Then
            If System.IO.Directory.Exists(RutaBase & "\" & txtIdPoliza.Text) = True Then
                ControlNotificacion.Caption = "Buscando Archivos Nuevos en Carpeta" : Application.DoEvents()
                Dim Archivos As DataTable = ObtenerArchivosCarpeta(RutaBase & "\" & txtIdPoliza.Text)
                Dim FilArchivo As DataRow
                For Each FilArchivo In Archivos.Rows
                    'verificamos si ya existe
                    existe = False
                    For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If Trim(UCase(VistaDoc.GetRowCellValue(NA, "Documento"))) = Trim(UCase(dbData(FilArchivo, "Archivo"))) Then
                            existe = True
                        End If
                    Next
                    If existe = False Then
                        Dim Id As Integer = ObtenerIDDoc()
                        Me.AgregarFilaGrid(VistaDoc, True, False)
                        Dim Fila As Integer = VistaDoc.FocusedRowHandle
                        Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                        Me.VistaDoc.SetRowCellValue(Fila, "Documento", dbData(FilArchivo, "Archivo"))
                        Me.VistaDoc.SetRowCellValue(Fila, "Directorio", dbData(FilArchivo, "Carpeta"))
                        Me.VistaDoc.UpdateCurrentRow()
                    End If
                Next
            End If

            '17/01/2012
            'los documentos que ya no existen los removemos
            ControlNotificacion.Caption = "Borramos Archivos que ya no existen en Carpeta" : Application.DoEvents()
            Try
                Dim RutaArchivo As String = "", Atributos As System.IO.FileAttributes
INICIO_VALIDA:
                For NDO As Integer = 0 To VistaDoc.DataRowCount - 1
                    Try
                        RutaArchivo = VistaDoc.GetRowCellValue(NDO, "Documento")
                        If System.IO.Path.GetExtension(RutaArchivo) = "" Then
                            If System.IO.Directory.Exists(RutaArchivo) = False Then
                                VistaDoc.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            End If
                        Else
                            If System.IO.File.Exists(RutaArchivo) = False Then
                                VistaDoc.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            Else
                                ''verificamos que no sea un archivo oculto o del sistema
                                Atributos = System.IO.File.GetAttributes(RutaArchivo)
                                If (Atributos And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Or (Atributos And IO.FileAttributes.System) = IO.FileAttributes.System Then
                                    VistaDoc.DeleteRow(NDO)
                                    GoTo INICIO_VALIDA
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                Next

            Catch ex As Exception

            End Try
            ControlNotificacion.Caption = "" : Application.DoEvents()
        End If
    End Sub

    Private Sub CompletarNombreArchivos()
        Dim dtDoc As DataTable
        Me.blnCargandoRegistro = True
        ControlNotificacion.Caption = "Completando Nombres de Archivos" : Application.DoEvents()
        Try
            dtDoc = GridDoc.DataSource
            dtDoc.Columns.Add("Archivo", System.Type.GetType("System.String"))
            dtDoc.Columns.Add("Directorio", System.Type.GetType("System.String"))
            GridDoc.DataSource = dtDoc
        Catch ex As Exception

        End Try
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza")

        For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                Me.VistaDoc.SetRowCellValue(NA, "Archivo", System.IO.Path.GetFileName(VistaDoc.GetRowCellValue(NA, "Documento")))
                Me.VistaDoc.SetRowCellValue(NA, "Directorio", Replace(System.IO.Path.GetDirectoryName(VistaDoc.GetRowCellValue(NA, "Documento")), RutaBase, ""))
            Catch ex As Exception

            End Try
        Next
        Me.blnCargandoRegistro = False
        ControlNotificacion.Caption = "" : Application.DoEvents()
    End Sub

    Private Sub btnImprimirAutos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirAutos.Click
        Try
            'imprimiremos un modelo de autos.-

            Dim sql As String = ""
            Dim Inclusiones As String = ""

            If MsgBox("¿Desea generar todos los certificados o únicamente las inclusiones de la vigencia?" & vbCrLf & " Si = Todos, No = Inclusiones", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
                Inclusiones = "S"
            End If


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


            sql = "  select "
            sql &= " p.idpoliza as IdPoliza"
            sql &= " ,r.Descripcion as Producto"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%MARCA%'),'') as Marca"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%MODELO%'),'') as Modelo"
            sql &= " ,'' as Clase"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%AÑO%'),'') as Anio"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%PLACA%'),'') as Placa"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Daños al vehículo%'),0) as SumaDPropios"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Daños al vehículo%'),0) as PrimaDPropios"
            sql &= " ,isnull((SELECT TOP 1 o.Deducible from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Daños al vehículo%'),'') as Deducible"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Responsabilidad civil a bienes%' or o1.Descripcion like '%Responsabilidad civil por Daños a Terceros en sus Bienes%')),0) as SumaDBienes"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Responsabilidad civil a bienes%' or o1.Descripcion like '%Responsabilidad civil por Daños a Terceros en sus Bienes%')),0) as PrimaDBienes"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Responsabilidad civil a varias personas%' or o1.Descripcion like '%Responsabilidad Civil por Daños a Terceros en sus personas. Por varias%')),0) as SumaDPersonas"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Responsabilidad civil a una persona%' or o1.Descripcion like '%Responsabilidad Civil por Daños a Terceros en sus personas. Una persona%')),0) as SumaDPersona"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Responsabilidad civil a varias personas%' or o1.Descripcion like '%Responsabilidad Civil por Daños a Terceros en sus personas. Por varias%')),0) as PrimaDPersonas"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Gastos médicos varios ocupantes%' or o1.Descripcion like '%Gastos Medicos para los ocupantes del vehiculo. Para varias%')),0) as SumaGM"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Gastos médicos un ocupante%' or o1.Descripcion like '%Gastos Medicos para los ocupantes del vehiculo. Una Persona%')),0) as SumaGMUnaPersona"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and (o1.Descripcion like '%Gastos médicos varios ocupantes%' or o1.Descripcion like '%Gastos Medicos para los ocupantes del vehiculo. Para varias%')),0) as PrimaGM"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Accidentes personales%'),0) as SumaAP"
            sql &= " ,isnull(c.PrimaBruta,0) as PrimaBruta"
            sql &= " ,isnull(c.ValorDescuento,0) as Descuentos"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Riesgo catastrofico%'),0) as PrimaCatastro"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil en exceso%'),0) as PrimaRCExceso"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil en exceso%'),0) as SumaRCExceso"
            sql &= " ,c.PrimaNeta as Prima"
            sql &= " , c.PrimaExenta as PrimaExenta"
            sql &= " ,isnull(c.GastosEmi,0) + isnull(c.GastosFrac,0) + isnull(c.GastosBomb,0) + isnull(c.GastosOtros,0) as Gastos"
            sql &= " ,c.Iva"
            sql &= " ,c.Total"
            sql &= " , cast(c.idcertificado as Int) as Orden"
            sql &= " ,isnull(c.IdCertificadoAseguradora, c.idcertificado) as IdCertificado"
            sql &= " , c.FechaInclusion as FechaIngreso, c.FechaExclusion"
            sql &= " from Polizas as p"
            sql &= " inner join PolizasCertificados as c on p.idpoliza = c.idpoliza and p.idproducto = c.idproducto"
            sql &= " inner join Productos as r on r.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '')"
            If Inclusiones <> "" Then
                sql &= " and c.FechaInclusion between p.VigenciaDesde and p.VigenciaHasta "
            End If

            Dim DtAutos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            DtAutos.TableName = "DatosAutos"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(DtAutos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As Object
            Reporte = New repCRAutos
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Autos")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)


            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            Dim Aseguradora As String = ""
            Try
                Aseguradora = StiGlobalConn.ObtenerDataset("select a.nombre from aseguradoras as a inner join productos as p on a.idaseguradora = p.idaseguradora where p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Aseguradora = ""
            End Try

            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Pólizas de Automotores: " & Me.txtIdPoliza.Valor & ", Aseguradora: " & Aseguradora)
            SetRepFormulaString(Reporte, "Titulo2", "Contratante: " & txtNombreCliente.Valor)
            SetRepFormulaString(Reporte, "Titulo3", "Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaClausulas_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs) Handles VistaClausulas.CustomColumnSort
        Try
            'el campo es alfanumerico pero se trata de ordenar numérico
            If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
                Return
            End If
            e.Handled = True

            Dim s1 As Double = 0, s2 As Double = 0
            If e.Column.FieldName = "IdClausula" Then
                s1 = ConvertirANumero(e.Value1.ToString())
                s2 = ConvertirANumero(e.Value2.ToString())
            End If

            If s1 > s2 Then
                e.Result = 1
            Else
                If s1 = s2 Then
                    e.Result = Comparer(Of Double).Default.Compare(s1, s2)
                Else
                    e.Result = -1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnResumenCertificados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumenCertificados.Click
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
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from PolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as GastosOtros"
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
            sql &= " ,c.IdCertificadoAseguradora"
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
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,c.Descripcion as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " from PolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and (p.SumaAsegurada > 0 or p.CoberturaAdicional = 1) "
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
            sql &= " from PolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join PolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
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

            Dim Reporte As Object
            Reporte = New RepResCertificados
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Res.Certificado")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            MsgBox("Existen problemas para imprimir los certificados." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AVISO...")
        End Try

    End Sub

    Private Sub btnAgregarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarVendedor.Click
        Try
            Dim IdVen As Integer = ObtenerIDVen()
            Me.AgregarFilaGrid(VistaVendedores)
            Dim Fila As Integer = VistaVendedores.FocusedRowHandle
            VistaVendedores.SetRowCellValue(Fila, "Orden", IdVen)
            VistaVendedores.UpdateCurrentRow()
            Fila = VistaVendedores.FocusedRowHandle
            blnVendedorModificado = True
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarVendedor.Click
        Try
            Me.EliminarFilaGrid(VistaVendedores)
            blnVendedorModificado = True
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit2.EditValueChanged
        ''proponemos el tipo de comision
        Try
            VistaVendedores.PostEditor()
            VistaVendedores.RefreshData()
            Dim Fila As Integer = VistaVendedores.FocusedRowHandle
            If Fila >= 0 Then

                Dim Tipo As String = ""
                Try
                    Tipo = VistaVendedores.GetRowCellValue(Fila, "IdTipoVendedor")
                Catch ex As Exception
                    Tipo = ""
                End Try
                If Tipo = "" Then
                    Dim IdVendedor As String = Me.VistaVendedores.GetRowCellValue(Fila, "IdVendedor")
                    Tipo = StiGlobalConn.ObtenerDataset("select IdTipoVendedor from Vendedores where idvendedor = " & dbStr(IdVendedor)).Tables(0).Rows(0).Item(0)
                    Me.VistaVendedores.SetRowCellValue(Fila, "IdTipoVendedor", Tipo)
                    Me.VistaVendedores.SetRowCellValue(Fila, "FechaEfectiva", CDate(txtVigenciaDesde.Valor))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerIDVen() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaVendedores.DataRowCount - 1
            Try
                If CInt(VistaVendedores.GetRowCellValue(I, "Orden")) > Id Then
                    Id = CInt(VistaVendedores.GetRowCellValue(I, "Orden"))
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

    Private Sub TabPoliza_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabPoliza.SelectedPageChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            If e.Page.Name.Trim.ToUpper = "PAGDOCUMENTOS" Then
                If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
                    'cargamos documentos nuevos
                    Call IncluirDocumentosAutomaticos()
                End If
                Call CompletarNombreArchivos()
            End If
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CalcularDiasCobertura()
        Try
            txtDiasCob.Valor = ObtenerDiasCobertura(txtVigenciaDesde.Valor, txtVigenciaHasta.Valor)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtVigenciaHasta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaHasta.ValueChangeOnExit
        Call CalcularDiasCobertura()
    End Sub

    Private Sub btnImpresionDanos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresionDanos.Click
        Dim res As String = ImprimirPolizaDanos(Me.txtIdPoliza.Valor, Me.cboIdProducto.Valor)
        If res <> "" Then msgError(New Exception(res))
    End Sub

    Private Sub VistaVendedores_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaVendedores.CellValueChanged
        Select Case e.Column.FieldName
            Case "IdVendedor", "IdTipoVendedor", "Orden"
                blnVendedorModificado = True
        End Select
    End Sub

    Private Sub btnImprimirAutosExcluidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirAutosExcluidos.Click
        Try
            'imprimiremos un modelo de autos.-

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


            sql = "  select "
            sql &= " p.idpoliza as IdPoliza"
            sql &= " ,r.Descripcion as Producto"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%MARCA%'),'') as Marca"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%MODELO%'),'') as Modelo"
            sql &= " ,'' as Clase"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%AÑO%'),'') as Anio"
            sql &= " ,isnull((select top 1 b.DescripcionBien from PolizasBienes as b where b.idpoliza = c.idpoliza and b.idproducto = c.idproducto and b.idcertificado = c.idcertificado and b.NombreBien like '%PLACA%'),'') as Placa"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Daños al vehículo%'),0) as SumaDPropios"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from hPolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o.Prima > 0 and o1.Descripcion like '%Daños al vehículo%' order by o.IdHistorico desc), isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Daños al vehículo%'),0)) as PrimaDPropios"
            sql &= " ,isnull((SELECT TOP 1 o.Deducible from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Daños al vehículo%'),'') as Deducible"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil a bienes%'),0) as SumaDBienes"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from hPolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o.Prima > 0 and o1.Descripcion like '%Responsabilidad civil a bienes%' order by o.IdHistorico desc), isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil a bienes%'),0)) as PrimaDBienes"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil a varias personas%'),0) as SumaDPersonas"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from hPolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o.Prima > 0 and o1.Descripcion like '%Responsabilidad civil a varias personas%' order by o.IdHistorico desc), isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil a varias personas%'),0)) as PrimaDPersonas"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Gastos médicos varios ocupantes%'),0) as SumaGM"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from hPolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o.Prima > 0 and o1.Descripcion like '%Gastos médicos varios ocupantes%' order by o.IdHistorico desc), isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Gastos médicos varios ocupantes%'),0)) as PrimaGM"
            sql &= " ,isnull((SELECT TOP 1 o.SumaAsegurada from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Accidentes personales%'),0) as SumaAP"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from hPolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o.Prima > 0 and o1.Descripcion like '%Riesgo catastrofico%' order by o.IdHistorico desc), isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Riesgo catastrofico%'),0)) as PrimaCatastro"
            sql &= " ,isnull((SELECT TOP 1 o.Prima from hPolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o.Prima > 0 and o1.Descripcion like '%Responsabilidad civil en exceso%' order by o.IdHistorico desc), isnull((SELECT TOP 1 o.Prima from PolizasCoberturas as o inner join ProductosCoberturas as o1 on o1.IdProducto = o.IdProducto and o.IdCobertura = o1.IdCobertura where o.idpoliza = c.idpoliza and o.idproducto = c.idproducto and o.idcertificado = c.idcertificado and o1.Descripcion like '%Responsabilidad civil en exceso%'),0)) as PrimaRCExceso"

            sql &= " ,isnull(( select top 1 hc.PrimaNeta from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), c.PrimaNeta) as Prima"
            sql &= " ,isnull(( select top 1 hc.PrimaExenta from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), c.PrimaExenta) as PrimaExenta"
            sql &= " ,isnull(( select top 1 isnull(hc.GastosEmi,0) + isnull(hc.GastosFrac,0) + isnull(hc.GastosBomb,0) + isnull(hc.GastosOtros,0) from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), isnull(c.GastosEmi,0) + isnull(c.GastosFrac,0) + isnull(c.GastosBomb,0) + isnull(c.GastosOtros,0)) as Gastos "
            sql &= " ,isnull(( select top 1 isnull(hc.PrimaBruta,0) from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), isnull(c.PrimaBruta,0)) as PrimaBruta"
            sql &= " ,isnull(( select top 1 isnull(hc.ValorDescuento,0) from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), isnull(c.ValorDescuento,0)) as Descuentos "
            sql &= " ,isnull(( select top 1 hc.Iva from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), c.Iva) as Iva"
            sql &= " ,isnull(( select top 1 hc.Total from hPolizasCertificados as hc where hc.idpoliza = c.idpoliza and hc.idproducto = c.idproducto and hc.idcertificado = c.idcertificado and hc.PrimaNeta > 0 order by hc.IdHistorico desc), c.Total) as Total"

            sql &= " , cast(c.idcertificado as Int) as Orden"
            sql &= " ,isnull(c.IdCertificadoAseguradora, c.idcertificado) as IdCertificado"
            sql &= " , c.FechaInclusion as FechaIngreso, c.FechaExclusion"
            sql &= " from Polizas as p"
            sql &= " inner join PolizasCertificados as c on p.idpoliza = c.idpoliza and p.idproducto = c.idproducto"
            sql &= " inner join Productos as r on r.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and c.FechaExclusion is not null "

            Dim DtAutos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            DtAutos.TableName = "DatosAutos"

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(DtAutos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repCRAutosExcluidos
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            Dim Aseguradora As String = ""
            Try
                Aseguradora = StiGlobalConn.ObtenerDataset("select a.nombre from aseguradoras as a inner join productos as p on a.idaseguradora = p.idaseguradora where p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                Aseguradora = ""
            End Try

            SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte, "Titulo1", "Pólizas de Automotores: " & Me.txtIdPoliza.Valor & ", Aseguradora: " & Aseguradora)
            SetRepFormulaString(Reporte, "Titulo2", "Contratante: " & txtNombreCliente.Valor)
            SetRepFormulaString(Reporte, "Titulo3", "Vehículos Excluidos. Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub
End Class
