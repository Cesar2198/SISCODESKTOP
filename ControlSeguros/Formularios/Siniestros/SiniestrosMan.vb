Imports Utilerias.Genericas

Public Class SiniestrosMan

    Public SolicitarGestion As Boolean = False

    Private Sub btnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        Try
            OpenFileDialog1.FileName = ""
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                'si existe un parametro que indique la ruta global de los documentos validamos
                Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Siniestros")
                Dim resRuta As String = ""
                If RutaBase <> "" And txtIdSiniestro.Text <> "" Then
                    RutaBase = RutaBase & "\" & txtIdSiniestro.Text & "\"
                    'creamos la carpeta si no existe
                    resRuta = CreaRuta(RutaBase)
                    If resRuta = "" Then
                        'movemos el archivo a la nueva carpeta
                        RutaBase &= System.IO.Path.GetFileName(Documento)
                        If System.IO.File.Exists(RutaBase) = False Then
                            System.IO.File.Copy(Documento, RutaBase)
                        Else
                            MsgBox("Ya existe un archivo con el mismo nombre en el repositorio de documentos de Siniestros.", MsgBoxStyle.Information, "AVISO...")
                            Exit Sub
                        End If
                        Documento = RutaBase
                    End If
                End If

                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaArchivos)
                Dim Fila As Integer = VistaArchivos.FocusedRowHandle
                Me.VistaArchivos.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaArchivos.SetRowCellValue(Fila, "Documento", Documento)
                Me.VistaArchivos.UpdateCurrentRow()

            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            FolderBrowserDialog1.SelectedPath = ""
            Dim Carpeta As String = ""
            FolderBrowserDialog1.ShowDialog()
            Carpeta = FolderBrowserDialog1.SelectedPath
            If Carpeta <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaArchivos)
                Dim Fila As Integer = VistaArchivos.FocusedRowHandle
                Me.VistaArchivos.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaArchivos.SetRowCellValue(Fila, "Documento", Carpeta)
                Me.VistaArchivos.UpdateCurrentRow()
            End If
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDoc.Click
        Try
            Me.EliminarFilaGrid(VistaArchivos)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub VistaArchivos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaArchivos.DoubleClick
        Try
            Dim fila As Integer = VistaArchivos.FocusedRowHandle
            If fila >= 0 Then
                Dim Doc As String = Me.VistaArchivos.GetRowCellValue(fila, "Documento")
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

    Private Function ObtenerIDDoc() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaArchivos.DataRowCount - 1
            Try
                If CInt(VistaArchivos.GetRowCellValue(I, "IdDocumento")) > Id Then
                    Id = CInt(VistaArchivos.GetRowCellValue(I, "IdDocumento"))
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

    Private Sub btnQuitarRequisito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarRequisito.Click
        Try
            Me.EliminarFilaGrid(VistaRequisitos)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarRequisito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRequisito.Click
        Try
            Dim Id As Integer = ObtenerIDReq()
            Me.AgregarFilaGrid(VistaRequisitos)
            Dim Fila As Integer = VistaRequisitos.FocusedRowHandle
            Me.VistaArchivos.SetRowCellValue(Fila, "IdRequisito", Id)
            Me.VistaArchivos.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDReq() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaRequisitos.DataRowCount - 1
            Try
                If CInt(VistaRequisitos.GetRowCellValue(I, "IdRequisito")) > Id Then
                    Id = CInt(VistaRequisitos.GetRowCellValue(I, "IdRequisito"))
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

    Private Sub btnQuitarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarReserva.Click
        Try
            Me.EliminarFilaGrid(VistaReserva)
            Call ActualizarTotales()
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarReserva.Click
        Try
            Me.AgregarFilaGrid(VistaReserva)
            Dim IdRes As Integer = ObtenerIDReserva()
            VistaReserva.SetRowCellValue(VistaReserva.FocusedRowHandle, "IdReserva", IdRes)
            VistaReserva.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDReserva() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaReserva.DataRowCount - 1
            Try
                If CInt(VistaReserva.GetRowCellValue(I, "IdReserva")) > Id Then
                    Id = CInt(VistaReserva.GetRowCellValue(I, "IdReserva"))
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
            Me.EliminarFilaGrid(VistaPagos)
            Call ActualizarTotales()
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click
        Try
            Dim Id As Integer = ObtenerIDPago()
            Me.AgregarFilaGrid(VistaPagos)
            Dim Fila As Integer = VistaPagos.FocusedRowHandle
            Me.VistaPagos.SetRowCellValue(Fila, "IdPago", Id)
            Me.VistaPagos.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDPago() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaPagos.DataRowCount - 1
            Try
                If CInt(VistaPagos.GetRowCellValue(I, "IdPago")) > Id Then
                    Id = CInt(VistaPagos.GetRowCellValue(I, "IdPago"))
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

    Private Sub btnQuitarGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGastos.Click
        Try
            Me.EliminarFilaGrid(VistaDetalles)
            Call ActualizarTotales()
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGasto.Click
        Try
            Dim Id As Integer = ObtenerIDGasto()
            Me.AgregarFilaGrid(VistaDetalles)
            Dim Fila As Integer = VistaDetalles.FocusedRowHandle
            Me.VistaDetalles.SetRowCellValue(Fila, "IdDetalle", Id)
            Me.VistaDetalles.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDGasto() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDetalles.DataRowCount - 1
            Try
                If CInt(VistaDetalles.GetRowCellValue(I, "IdDetalle")) > Id Then
                    Id = CInt(VistaDetalles.GetRowCellValue(I, "IdDetalle"))
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

    Private Sub ActualizarTotales()

        'actualizaremos el total del reembolso
        Dim TotReembolso As Double = 0
        For NP As Integer = 0 To Me.VistaPagos.DataRowCount - 1
            Try
                TotReembolso += Val(Me.VistaPagos.GetRowCellValue(NP, "ValorReembolso"))
            Catch ex As Exception

            End Try
        Next
        Me.txtTotalReembolso.Valor = TotReembolso

        'total presentado y cubierto
        Dim Presentado As Double = 0, NoCubierto As Double = 0, Cubierto As Double = 0
        For ND As Integer = 0 To Me.VistaDetalles.DataRowCount - 1
            Try
                Presentado += Val(Me.VistaDetalles.GetRowCellValue(ND, "ValorPresentado"))
            Catch ex As Exception

            End Try
            Try
                NoCubierto += Val(Me.VistaDetalles.GetRowCellValue(ND, "ValorNoCubierto"))
            Catch ex As Exception

            End Try
            Try
                Cubierto += Val(Me.VistaDetalles.GetRowCellValue(ND, "ValorCubierto"))
            Catch ex As Exception

            End Try
        Next
        txtTotalPresentado.Valor = Presentado
        txtTotalNoCubierto.Valor = NoCubierto
        txtTotalCubierto.Valor = Cubierto

        'valor pendiente (Reserva)
        Dim Reserva As Double = 0
        For NR As Integer = 0 To Me.VistaReserva.DataRowCount - 1
            Try
                Reserva += Val(Me.VistaReserva.GetRowCellValue(NR, "ValorReserva"))
            Catch ex As Exception

            End Try
        Next
        'Reserva = Reserva - TotReembolso
        If Reserva < 0 Then Reserva = 0
        Me.txtTotalPendiente.Valor = Reserva

        'dedudores
        Dim Deudores As Double = 0
        For ND As Integer = 0 To Me.VistaDeudores.DataRowCount - 1
            Try
                Deudores += Val(Me.VistaDeudores.GetRowCellValue(ND, "ValorDeudor"))
            Catch ex As Exception

            End Try
        Next
        Me.txtTotalDeudores.Valor = Deudores

    End Sub

    Private Sub VistaDetalles_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaDetalles.CellValueChanged
        Me.VistaDetalles.PostEditor()
        If e.Column.FieldName <> "ValorCubierto" Then
            Call ActualizarValoresGasto()
        End If
        Call ActualizarTotales()
    End Sub

    Private Sub VistaPagos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaPagos.CellValueChanged
        Me.VistaDetalles.PostEditor()
        'hacemos algunos calculos en función del la columna modificada
        Select Case e.Column.FieldName
            Case "ValorGasto", "Deducible", "Coaseguro", "SaldoDeudor", "Descuento", "ValorRenta", "ValorIva", "ValorRetencionIva"
                Dim f As Integer = VistaPagos.FocusedRowHandle
                Dim ValorGasto As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "ValorGasto"), 0)
                Dim Deducible As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "Deducible"), 0)
                Dim Coaseguro As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "Coaseguro"), 0)
                Dim SaldoDeudor As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "SaldoDeudor"), 0)
                Dim Descuento As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "Descuento"), 0)
                Dim ValorRenta As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "ValorRenta"), 0)
                Dim ValorIva As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "ValorIva"), 0)
                Dim ValorRetencionIva As Double = ValidadbNull(VistaPagos.GetRowCellValue(f, "ValorRetencionIva"), 0)
                Dim ValorReembolso As Double = ValorGasto - Deducible - Coaseguro - SaldoDeudor - Descuento - ValorRenta + ValorIva - ValorRetencionIva
                VistaPagos.SetRowCellValue(f, "ValorReembolso", ValorReembolso)

            Case "ValorReembolso"

                Call ActualizarTotales()
        End Select
    End Sub

    Private Sub VistaReserva_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaReserva.CellValueChanged
        Me.VistaDetalles.PostEditor()
        Call ActualizarTotales()
    End Sub

    Private Sub btnBuscaCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCertificado.Click
        Dim Fbus As New BusquedaCertReclamo
        Fbus.Text = "Búsqueda de Pólizas/Certificados/Bienes"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
            Call CargarGastos()
            Call CargarGrupoCobertura()
            Me.txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
            Me.txtIdBien.Valor = stiSplit(busCodigo, "G3|1")
            Me.txtTitularCertificado.Valor = stiSplit(busCodigo, "G5|1")
            Me.txtTitularCertificado.SoloLectura = True
            Me.txtNombrePresentaReclamo.Valor = stiSplit(busCodigo, "G6|1")
            Try
                'obtenermos la vigencia del certificado
                Dim FilCertificado As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta from PolizasCertificados where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0).Rows(0)
                Me.txtVigenciaDesde.Valor = dbData(FilCertificado, "VigenciaDesde")
                Me.txtVigenciaHasta.Valor = dbData(FilCertificado, "VigenciaHasta")
            Catch ex As Exception

            End Try
            If Me.cboEstadoSiniestro.Text = "" Then Me.cboEstadoSiniestro.Valor = "PENDIENTE"
            Call CargarDatosCertificado(cboIdProducto.Valor, txtIdPoliza.Valor, txtIdCertificado.Valor)
            Call ObtenerLimitesPoliza()
            Call ValidaCampoDiagnostico()
        End If

    End Sub

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.VistaPagos.FocusedColumn.FieldName
            Case "NombreCheque" : Me.RepositoryItemTextEdit1.MaxLength = 150
            Case "NumeroCheque" : Me.RepositoryItemTextEdit1.MaxLength = 25
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit2.Enter
        Select Case Me.VistaDetalles.FocusedColumn.FieldName
            Case "DescripcionGastos" : Me.RepositoryItemTextEdit2.MaxLength = 250
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit3.Enter
        Select Case Me.VistaInfo.FocusedColumn.FieldName
            Case "Descripcion" : Me.RepositoryItemTextEdit3.MaxLength = 250
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit4.Enter
        Select Case Me.VistaDeudores.FocusedColumn.FieldName
            Case "Descripcion" : Me.RepositoryItemTextEdit4.MaxLength = 150
        End Select
    End Sub

    Private Sub btnAgregarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarInfo.Click
        Try
            Dim Id As Integer = ObtenerIDInfo()
            Me.AgregarFilaGrid(VistaInfo)
            Me.VistaInfo.SetRowCellValue(VistaInfo.FocusedRowHandle, "IdInformacion", Id)
            Me.VistaInfo.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDInfo() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaInfo.DataRowCount - 1
            Try
                If CInt(VistaInfo.GetRowCellValue(I, "IdInformacion")) > Id Then
                    Id = CInt(VistaInfo.GetRowCellValue(I, "IdInformacion"))
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

    Private Sub SiniestrosMan_AntesDeCargarFormulario() Handles Me.AntesDeCargarFormulario

        cboTipoSiniestro.Lista = GenerarListaCombo(clSeguros.ObtenerDBParametros("Siniestros.Tipos"))
        cboNombreTaller.Lista = GenerarListaCombo(clSeguros.ObtenerDBParametros("Siniestros.Lista.Talleres"))
        cboAmbitoSiniestro.Lista = clSeguros.ObtenerDBParametros("Siniestros.Ambitos")
        cboClaseSiniestro.Lista = GenerarListaCombo(clSeguros.ObtenerDBParametros("Siniestros.Clases"))

    End Sub

    Private Sub SiniestrosMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        Try
            If SolicitarGestion = True And txtIdSiniestro.Text <> "" And VistaGestiones.RowCount = 0 Then
                MsgBox("Antes de guardar el reclamo debe registrar una gestión.", MsgBoxStyle.Information, "AVISO...")
                Cancel = True
                Exit Sub
            End If

        Catch ex As Exception

        End Try

        If txtIdSiniestro.Text = "" And Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            txtIdSiniestro.Valor = clSeguros.ObtenerID("Reclamos.Num." & Date.Today.Year) & "-" & Date.Today.Year
            Select Case GlobalCodCliente
                Case "2120000"
                    '28/01/2019 solicitan que al continuar con el reclamo debe almacenar una gestion
                    SolicitarGestion = True
            End Select
        End If

    End Sub

    Private Sub SiniestrosMan_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Me.TabSiniestros.Enabled = True
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.TabSiniestros.Enabled = True

                'agregaremos unos registros por default:
                '1) Información Técnica
                Dim sql As String = "", DtInfo As DataTable, FilInfo As DataRow
                DtInfo = StiGlobalConn.ObtenerDataset("select IdComplemento, DescripcionComplemento from ProductosSinComplementos where IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdComplemento").Tables(0)
                For Each FilInfo In DtInfo.Rows
                    'la ingresamos al sistema
                    sql = "  insert into SiniestrosInformacion "
                    sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdInformacion, Descripcion) values("
                    sql &= dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & C & dbStr(txtIdCertificado.Valor) & C & dbStr(txtIdSiniestro.Valor) & C & dbInt(dbData(FilInfo, "IdComplemento")) & C & dbStr(dbData(FilInfo, "DescripcionComplemento"), 250) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    'la colocamos en pantalla
                    Me.AgregarFilaGrid(VistaInfo)
                    Me.VistaInfo.SetRowCellValue(VistaInfo.FocusedRowHandle, "IdInformacion", CInt(dbData(FilInfo, "IdComplemento")))
                    Me.VistaInfo.SetRowCellValue(VistaInfo.FocusedRowHandle, "Descripcion", dbData(FilInfo, "DescripcionComplemento"))
                    Me.VistaInfo.UpdateCurrentRow()
                Next

                '2) Requisitos
                Dim DtReq As DataTable, FilReq As DataRow
                DtReq = StiGlobalConn.ObtenerDataset("select IdRequisito, DescripcionRequisito from ProductosSinRequisitos where IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdRequisito").Tables(0)
                For Each FilReq In DtReq.Rows
                    'la ingresamos al sistema
                    sql = "  insert into SiniestrosRequisitos "
                    sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdRequisito, Descripcion) values("
                    sql &= dbStr(txtIdPoliza.Valor) & C & dbStr(cboIdProducto.Valor) & C & dbStr(txtIdCertificado.Valor) & C & dbStr(txtIdSiniestro.Valor) & C & dbInt(dbData(FilReq, "IdRequisito")) & C & dbStr(dbData(FilReq, "DescripcionRequisito"), 250) & ")"
                    StiGlobalConn.SQLExecute(sql)

                    'la colocamos en pantalla
                    Me.AgregarFilaGrid(VistaRequisitos)
                    Me.VistaRequisitos.SetRowCellValue(VistaRequisitos.FocusedRowHandle, "IdRequisito", CInt(dbData(FilReq, "IdRequisito")))
                    Me.VistaRequisitos.SetRowCellValue(VistaRequisitos.FocusedRowHandle, "Descripcion", dbData(FilReq, "DescripcionRequisito"))
                    Me.VistaRequisitos.UpdateCurrentRow()
                Next

                sql = "  update siniestros set "
                sql &= " usuariograbacion = " & dbStr(StiGlobalConn.User, 25)
                sql &= " where IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdCertificado = " & dbStr(txtIdCertificado.Valor)
                sql &= " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)
                StiGlobalConn.SQLExecute(sql)


                Dim msgflujo As String = clFlujos.IniciarFlujoSiniestro(txtIdSiniestro.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, Me.cboEjecutivoCta.Valor)
                If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")

                Me.btnImprimir.Enabled = True
                Me.btnGenerarEnvio.Enabled = True


        End Select

        'verificaremos el estado del siniestro para cerrar o reabrir los flujos
        Select Case Me.cboEstadoSiniestro.Valor
            Case "DECLARADO", "PENDIENTE"
                'verificamos que existe un flujo abierto sino abre uno.
                clFlujos.ReactivarFlujoSiniestro(txtIdSiniestro.Valor, txtIdPoliza.Valor, cboIdProducto.Valor)
            Case Else
                'si existen flujos relacionados los cerramos
                clFlujos.CerrarFlujoSiniestro(txtIdSiniestro.Valor, txtIdPoliza.Valor, cboIdProducto.Valor)
        End Select

        If cboTipoSiniestro.Valor <> "" Then
            'actualizamos la póliza
            StiGlobalConn.SQLExecute("Update Polizas set ObservacionSiniestro = " & dbStr(cboTipoSiniestro.Descripcion, 250) & " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor))
        End If

    End Sub

    Private Sub SiniestrosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDiagnostico.Visible = False
        btnBuscarDiagnostico.Visible = False

        Me.cboNombreTaller.Llenar_Combo()

        Select Case GlobalCodCliente
            Case "2120000"
                cboEstadoSiniestro.Lista = "DECLARADO Declarado|PENDIENTE Pendiente|RECHAZADO Rechazado|RETIRADO Retirado|PAGADO Pagado|ABDEDU Abonado a Deducible|BAJDED Bajo Deducible|RECONSIDERACION Reconsideración|ABDSDO Abonado a Saldo Deudor|ANULADO Anulado|CHEQUERECIBIDO Cheque de Pago Recibido por ADRISA"
                cboEstadoSiniestro.Llenar_Combo()
        End Select

        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.TabSiniestros.Enabled = False
                Me.btnImprimir.Enabled = False
                Me.btnGenerarEnvio.Enabled = False

            Case enEstadoRegistro.Modificando
                Me.TabSiniestros.Enabled = True
                Call CargarGastos()
                Call CargarGrupoCobertura()
                Call CargarDatosCertificado(cboIdProducto.Valor, txtIdPoliza.Valor, txtIdCertificado.Valor)

                btnBuscaCertificado.Enabled = False

                Call IncluirDocumentosAutomaticos()

                If Not (Me.cboEstadoSiniestro.Valor = "PENDIENTE" Or cboEstadoSiniestro.Valor = "DECLARADO" Or cboEstadoSiniestro.Valor = "RECONSIDERACION") Then
                    Me.EstadoEntradas(False, Me)
                    Call DeshabilitarBotonesExtra(Me)
                    MsgBox("El reclamo ya está cerrado no podrá realizar cambios.", MsgBoxStyle.Information, "AVISO...")
                    cboEstadoSiniestro.SoloLectura = False
                End If

                If cboEjecutivoCta.Valor = "" Then
                    Try
                        Dim IdCliente As String = StiGlobalConn.ObtenerDataset("select idcliente from polizas where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor)).Tables(0).Rows(0).Item(0)
                        cboEjecutivoCta.Valor = clSeguros.ObtenerEjecutivoCuenta(IdCliente, Me.cboIdProducto.Valor, "RECLAMOS")
                    Catch ex As Exception

                    End Try
                End If
                Try
                    Me.txtTitularCertificado.Valor = StiGlobalConn.ObtenerDataset("select nombrecliente from polizascertificados where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception

                End Try

                Me.btnImprimir.Enabled = True
                Me.btnGenerarEnvio.Enabled = True
                Dim coba As String = cboNombreCobAfecta.Valor

                Me.cboNombreCobAfecta.Query = "select replace(cast(Descripcion as varchar(max)),' ','_') as Id, Descripcion from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor)
                Me.cboNombreCobAfecta.Llenar_Combo()
                Me.cboNombreCobAfecta.Valor = coba
                If Me.txtLimiteDeducible.Text = "" Then Call ObtenerLimitesPoliza()
        End Select

        cboNombreTaller.OcultarColumna(0)
        Me.cboNombreCobAfecta.OcultarColumna(0)

        Me.txtIdEnvio.SoloLectura = True
        Me.txtLimiteCoaseguro.SoloLectura = True
        Me.txtLimiteDeducible.SoloLectura = True
        Me.txtAcumuladoCoaseguro.SoloLectura = True
        Me.txtAcumuladoDeducible.SoloLectura = True
        Me.txtTitularCertificado.SoloLectura = True

        If clSeguros.ObtenerDBParametros("Siniestros.Ocultar.Reserva").ToString.Trim.ToUpper = "S" Then Me.Reserva.PageVisible = False
        If clSeguros.ObtenerDBParametros("Siniestros.Ocultar.Archivos").ToString.Trim.ToUpper = "S" Then Me.Archivos.PageVisible = False
        If clSeguros.ObtenerDBParametros("Siniestros.Ocultar.Tecnica").ToString.Trim.ToUpper = "S" Then Me.Informacion.PageVisible = False
        If clSeguros.ObtenerDBParametros("Siniestros.Ocultar.Requisitos").ToString.Trim.ToUpper = "S" Then Me.Requisitos.PageVisible = False
        Call ValidaCampoDiagnostico()

        Dim PendientesPor As String = clSeguros.ObtenerDBParametros("Siniestro.PendientePor")
        Dim lstPendPor As String = "", PendPor As String = ""
        For I As Integer = 0 To CuentaCar(PendientesPor, ",")
            PendPor = stiSplit(PendientesPor, "G" & I & ",1").Trim
            If PendPor <> "" Then
                If lstPendPor = "" Then
                    lstPendPor &= PendPor & " " & PendPor
                Else
                    lstPendPor &= "|" & PendPor & " " & PendPor
                End If
            End If
        Next
        Me.cboPendientePor.Lista = lstPendPor
        Me.cboPendientePor.Llenar_Combo()
        Me.cboPendientePor.OcultarColumna(1)

        Try
            Me.txtFlujo.SoloLectura = True
            Me.txtFlujo.Valor = StiGlobalConn.ObtenerDataset("select top 1 idflujodoc from FlujosDocumentos where FlujosDocumentos.idpoliza = " & dbStr(txtIdPoliza.Valor) & " and FlujosDocumentos.idproducto = " & dbStr(cboIdProducto.Valor) & " and FlujosDocumentos.idsiniestro = " & dbStr(txtIdSiniestro.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception

        End Try

        Dim EstadosSin As String = CStr(clSeguros.ObtenerDBParametros("Cod.Estado.Siniestro")).Trim
        If EstadosSin <> "" Then
            cboEstadoSiniestroInterno.Lista = EstadosSin
            cboEstadoSiniestroInterno.Llenar_Combo()
        End If

        cboTipoSiniestro.OcultarColumna(0)
        cboClaseSiniestro.OcultarColumna(0)

        Select Case GlobalCodCliente
            Case "2120000"
                Me.txtNombreConductor.Visible = True
                Me.cboNombreCobAfecta.Visible = True
                Me.cboNombreTaller.Visible = True

                Me.txtNoFolioReferencia.Visible = True
                Me.cboEjecutivoCta.Width = 265


                Fechas.PageVisible = True
                If cboIdProducto.Text <> "" Then
                    Dim Tipo As String = StiGlobalConn.ObtenerDataset("select tipoproducto from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                    Dim EsAuto As Integer = StiGlobalConn.ObtenerDataset("select count(*) from productos where idproducto = " & dbStr(cboIdProducto.Valor) & " and idramo = '501' ").Tables(0).Rows(0).Item(0)
                    If EsAuto > 0 Then Tipo = "AUTO"

                    Select Case Tipo.Trim.ToUpper
                        Case "AUTO"
                            LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                        Case "DAÑOS"
                            LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

                            Me.txtNombreConductor.Visible = False
                            Me.cboNombreCobAfecta.Visible = False
                            Me.cboNombreTaller.Visible = False

                        Case "VIDA"
                            LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                            LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                    End Select
                End If

            Case Else
                Fechas.PageVisible = False
                Me.txtNombreConductor.Visible = True
                Me.cboNombreCobAfecta.Visible = True
                Me.cboNombreTaller.Visible = True

                Me.txtNoFolioReferencia.Visible = False
                Me.cboEjecutivoCta.Width = 516

        End Select

    End Sub

    Private Sub ValidaCampoDiagnostico()
        Try
            If GlobalCodCliente = "2120000" And StiGlobalConn.ObtenerDataset("select TipoProducto from Productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0) = "VIDA" Then
                Me.txtDiagnostico.Visible = True
                btnBuscarDiagnostico.Visible = True
            Else
                Me.txtDiagnostico.Visible = False
                btnBuscarDiagnostico.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarGastos()

        Dim TG As DataTable
        Dim sql As String = ""
        sql = "  select IdGasto as Id, Descripcion from ProductosSinGastos"
        sql &= " where idproducto = " & dbStr(cboIdProducto.Valor)
        sql &= " union "
        sql &= " select -100 as Id, '<Nuevo Concepto>' as Descripcion"
        sql &= " order by 2"
        TG = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = TG
        RepositoryItemLookUpEdit1.PopulateColumns()
        RepositoryItemLookUpEdit1.Columns(0).Visible = False

    End Sub

    Private Sub CargarGrupoCobertura()
        'dependiente del ramo del producto asi cargamos las diferentes coberturas
        Dim sql As String = ""

        sql = "  select distinct a.NombreCorto as Id, a.NombreCorto as Descripcion"
        sql &= " from ProductosCoberturas as a"
        sql &= " inner join Productos as b on a.idproducto = b.idproducto"
        sql &= " where a.NombreCorto is not null and b.IdRamo in (select c.IdRamo from Productos as c where c.IdProducto = " & dbStr(cboIdProducto.Valor) & ")"
        Dim dtCob As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        cboGrupoCobertura.ValueMember = "Id"
        cboGrupoCobertura.DisplayMember = "Descripcion"
        cboGrupoCobertura.AutoSearchColumnIndex = 1
        cboGrupoCobertura.DataSource = dtCob
        cboGrupoCobertura.PopulateColumns()
        cboGrupoCobertura.Columns(0).Visible = False

        cboGrupoCobPago.ValueMember = "Id"
        cboGrupoCobPago.DisplayMember = "Descripcion"
        cboGrupoCobPago.AutoSearchColumnIndex = 1
        cboGrupoCobPago.DataSource = dtCob
        cboGrupoCobPago.PopulateColumns()
        cboGrupoCobPago.Columns(0).Visible = False



    End Sub

    Private Function CargarGastosEnFila(ByVal FilaGridEdita As Integer) As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim TG As DataTable
        Dim sql As String = ""
        Dim RepositoryItemLookUpEditXX As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        'haremos una lista de los códigos que ya están en uso
        Dim lstCod As String = ""
        For I As Integer = 0 To Me.VistaDetalles.RowCount - 1
            If I <> FilaGridEdita Then
                Try
                    If CStr(VistaDetalles.GetRowCellDisplayText(I, "IdGasto")).Trim.ToUpper <> "DOC." Then
                        If dbStr(VistaDetalles.GetRowCellValue(I, "IdGasto")) <> "NULL" Then
                            If lstCod <> "" Then
                                lstCod &= ", " & dbStr(VistaDetalles.GetRowCellValue(I, "IdGasto"))
                            Else
                                lstCod &= dbStr(VistaDetalles.GetRowCellValue(I, "IdGasto"))
                            End If
                        End If
                    End If
                Catch ex As Exception

                End Try
            End If
        Next

        sql = "  select IdGasto as Id, Descripcion from ProductosSinGastos"
        sql &= " where idproducto = " & dbStr(cboIdProducto.Valor)
        If lstCod <> "" Then
            sql &= " and IdGasto not in (" & lstCod & ")"
        End If

        sql &= " union "
        sql &= " select -100 as Id, '<Nuevo Concepto>' as Descripcion"
        sql &= " order by 2"
        TG = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        RepositoryItemLookUpEditXX.ValueMember = "Id"
        RepositoryItemLookUpEditXX.DisplayMember = "Descripcion"
        RepositoryItemLookUpEditXX.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEditXX.DataSource = TG
        RepositoryItemLookUpEditXX.PopulateColumns()
        RepositoryItemLookUpEditXX.Columns(0).Visible = False
        RepositoryItemLookUpEditXX.NullText = ""

        Return RepositoryItemLookUpEditXX

    End Function

    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        Try
            Me.VistaDetalles.PostEditor()
            Dim Valor As String = CStr(VistaDetalles.GetRowCellValue(VistaDetalles.FocusedRowHandle, "IdGasto"))
            If Valor = "-100" And cboIdProducto.Valor <> "" Then
                Dim Fprod As New ProductosMan
                Fprod.dbTabla = "Productos"
                Fprod.STIConn = StiGlobalConn
                Fprod.dbCondicion = " IdProducto = " & dbStr(cboIdProducto.Valor)
                Fprod.TabProductos.SelectedTabPageIndex = 5
                Fprod.ShowDialog()
                Call CargarGastos()
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdProducto.ValueChangeOnExit
        Call CargarGastos()
        Call CargarGrupoCobertura()
        Me.cboNombreCobAfecta.Query = "select replace(cast(Descripcion as varchar(max)),' ','_') as Id, Descripcion from ProductosCoberturas where IdProducto = " & dbStr(cboIdProducto.Valor)
        Me.cboNombreCobAfecta.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado, s.EstadoSiniestro, s.NombrePresentaReclamo, s.LugarSiniestros, s.DescripcionSiniestro"
            sql &= " ,s.DescripcionReserva, isnull(s.TotalPresentado,0) as TotalPresentado, isnull(s.TotalNoCubierto,0) as TotalNoCubierto, isnull(s.TotalCubierto,0) as TotalCubierto, isnull(s.TotalDeducible,0) as TotalDeducible, isnull(s.TotalCoaseguro,0) as TotalCoaseguro, isnull(s.TotalDeudores,0) as TotalDeudores, isnull(s.TotalReembolso,0) as TotalReembolso, isnull(s.TotalPendiente,0) as TotalPendiente"
            sql &= " , p.Descripcion as Producto"
            sql &= " ,a.Nombre as Aseguradora"
            sql &= " ,s.IdSiniestroAseguradora, s.IdEnvio"
            sql &= " , isnull((select po.NombreCliente from Polizas as po where po.idpoliza = s.idpoliza and po.idproducto = s.idproducto),'') as Contratante"
            sql &= " , isnull((select ce.NombreCliente from PolizasCertificados as ce where ce.idpoliza = s.idpoliza and ce.idproducto = s.idproducto and ce.idcertificado = s.idcertificado),'') as Asegurado"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and s.idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdDetalle as Orden"
            sql &= " ,g.Descripcion as Gasto"
            sql &= " ,s.ValorPresentado as Presentado"
            sql &= " ,s.ValorNoCubierto as NoCubierto"
            sql &= " ,s.ValorCubierto as Cubierto"
            sql &= " from SiniestrosDetalle as s"
            sql &= " inner join ProductosSinGastos as g on g.idproducto = s.idproducto and s.idgasto = g.idgasto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and s.idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim dtGastos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtGastos.TableName = "Gastos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdInformacion as Orden"
            sql &= " ,s.Descripcion"
            sql &= " ,s.Detalle"
            sql &= " ,c.Categoria"
            sql &= " from SiniestrosInformacion as s"
            sql &= " left join ProductosSinComplementos as c on s.Descripcion = c.DescripcionComplemento and s.idproducto = c.idproducto"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and s.idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim dtDetalle As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDetalle.TableName = "Detalle"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdPago as Orden"
            sql &= " ,s.FechaPago  as Fecha"
            sql &= " ,s.NombreCheque"
            sql &= " ,s.NumeroCheque"
            sql &= " ,s.ValorReembolso"
            sql &= " from SiniestrosPagos as s"
            sql &= " where s.idsiniestro is not null"
            sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and s.idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim dtPagos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPagos.TableName = "Pagos"

            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,b.IdBien as Orden"
            sql &= " ,b.NombreBien as Descripcion"
            sql &= " ,b.DescripcionBien as Detalle"
            sql &= " from Siniestros as s"
            sql &= " inner join PolizasBienes as b on s.IdPoliza = b.IdPoliza and s.IdProducto = b.IdProducto and s.IdCertificado = b.IdCertificado"
            sql &= " where s.idsiniestro is not null and b.DescripcionBien is not null "
            sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and s.idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim dtBien As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBien.TableName = "BienesAsegurados"


            sql = "  select "
            sql &= " s.IdPoliza, s.IdProducto, s.IdCertificado, s.IdSiniestro"
            sql &= " ,s.IdRequisito, s.Descripcion, s.FechaPresentado, s.Comentarios"
            sql &= " from SiniestrosRequisitos as s"
            sql &= " where s.idsiniestro is not null "
            sql &= " and s.IdPoliza = " & dbStr(txtIdPoliza.Text)
            sql &= " and s.IdProducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and s.idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            sql &= " and s.IdCertificado = " & dbStr(txtIdCertificado.Valor)
            Dim dtRequisitos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtRequisitos.TableName = "Requisitos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtSiniestros.Copy)
            DsRep.Tables.Add(dtGastos.Copy)
            DsRep.Tables.Add(dtDetalle.Copy)
            DsRep.Tables.Add(dtPagos.Copy)
            DsRep.Tables.Add(dtBien.Copy)
            DsRep.Tables.Add(dtRequisitos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repReclamo
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            MsgBox("Existen problemas para imprimir el reclamo." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AVISO...")
        End Try
    End Sub

    Private Sub btnQuitarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarInfo.Click
        Try
            Me.EliminarFilaGrid(VistaInfo)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub CargarDatosCertificado(ByVal IdProducto As String, ByVal IdPoliza As String, ByVal IdCertificado As String)
        If IdProducto <> "" And IdPoliza <> "" And IdCertificado <> "" Then
            Try
                Dim TB As DataTable
                TB = StiGlobalConn.ObtenerDataset("select NombreBien from ProductosBienes where idproducto = " & dbStr(IdProducto) & " order by IdBien").Tables(0)
                RepositoryItemLookUpEdit2.ValueMember = "NombreBien"
                RepositoryItemLookUpEdit2.DisplayMember = "NombreBien"
                RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
                RepositoryItemLookUpEdit2.DataSource = TB
                RepositoryItemLookUpEdit2.PopulateColumns()

                Dim sql As String = ""

                Dim DtBienes As DataTable
                'datos de los bienes
                sql = ""
                For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaBienes.Columns
                    If sql = "" Then
                        sql = " " & Col.FieldName
                    Else
                        sql &= ", " & Col.FieldName
                    End If
                Next
                sql = "  select " & sql
                sql &= " from PolizasBienes "
                sql &= " where "
                sql &= " IdPoliza = " & dbStr(IdPoliza)
                sql &= " and IdProducto = " & dbStr(IdProducto)
                sql &= " and IdCertificado = " & dbStr(IdCertificado)
                sql &= " order by IdBien"

                DtBienes = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridBienes.DataSource = DtBienes
                GridBienes.Refresh()
                VistaBienes.OptionsBehavior.Editable = False


                Dim DtCoberturas As DataTable
                'datos de las coberturas
                sql = ""
                For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaCoberturas.Columns
                    If sql = "" Then
                        sql = " " & Col.FieldName
                    Else
                        sql &= ", " & Col.FieldName
                    End If
                Next
                sql = "  select "
                sql &= " p.IdPoliza, p.IdProducto, p.IdCertificado, p.IdCobertura "
                sql &= " , isnull(cast(ca.Descripcion as varchar(8000)), isnull(cast(c.Descripcion as varchar(8000)),'')) as Descripcion "
                sql &= ", p.SumaAsegurada, p.PorceSuma, p.Tasa, p.Prima, p.Deducible, p.AplicarDescuento"
                sql &= " from PolizasCoberturas as p"
                sql &= " left join ProductosCoberturas as c on p.idproducto = c.idproducto and p.idcobertura = c.idcobertura"
                sql &= " left join PolizasCoberturasAdicional as ca on ca.IdPoliza = p.IdPoliza and ca.IdProducto = p.IdProducto and ca.IdCertificado = p.IdCertificado and ca.IdCobertura = p.IdCobertura"
                sql &= " where "
                sql &= " p.IdPoliza = " & dbStr(IdPoliza)
                sql &= " and p.IdProducto = " & dbStr(IdProducto)
                sql &= " and p.IdCertificado = " & dbStr(IdCertificado)
                sql &= " order by p.IdCobertura"

                DtCoberturas = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridCoberturas.DataSource = DtCoberturas
                GridCoberturas.Refresh()
                VistaCoberturas.OptionsBehavior.Editable = False

            Catch ex As Exception
                msgError(ex)
            End Try
        End If
    End Sub

    Private Sub btnAgregarDeudor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDeudor.Click
        Try
            Dim Id As Integer = ObtenerIDDeudor()
            Me.AgregarFilaGrid(VistaDeudores)
            Dim Fila As Integer = VistaDeudores.FocusedRowHandle
            Me.VistaDeudores.SetRowCellValue(Fila, "IdDeudor", Id)
            Me.VistaDeudores.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDeudor() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaDeudores.DataRowCount - 1
            Try
                If CInt(VistaDeudores.GetRowCellValue(I, "IdDeudor")) > Id Then
                    Id = CInt(VistaDeudores.GetRowCellValue(I, "IdDeudor"))
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

    Private Sub btnQuitarDeudor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDeudor.Click
        Try
            Me.EliminarFilaGrid(VistaDeudores)
            Call ActualizarTotales()
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub VistaDeudores_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaDeudores.CellValueChanged
        Me.VistaDeudores.PostEditor()
        Call ActualizarTotales()
    End Sub

    Private Sub ActualizarValoresGasto()
        Try
            Me.VistaDetalles.PostEditor()

            Dim Presentado As Double = 0, NoCubierto As Double = 0, Cubierto As Double = 0
            Try
                Presentado = Val(VistaDetalles.GetRowCellValue(Me.VistaDetalles.FocusedRowHandle, "ValorPresentado"))
            Catch ex As Exception
                Presentado = 0
            End Try
            Try
                NoCubierto = Val(VistaDetalles.GetRowCellValue(Me.VistaDetalles.FocusedRowHandle, "ValorNoCubierto"))
            Catch ex As Exception
                NoCubierto = 0
            End Try

            Cubierto = Presentado - NoCubierto
            VistaDetalles.SetRowCellValue(VistaDetalles.FocusedRowHandle, "ValorCubierto", Cubierto)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ObtenerLimitesPoliza()
        Try
            'If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Dim Poliza As String = Me.txtIdPoliza.Valor
            Dim IdProducto As String = Me.cboIdProducto.Valor
            Dim IdCertificado As String = Me.txtIdCertificado.Valor
            Dim IdBien As Integer = Me.txtIdBien.Valor
            Dim IdSiniestro As String = Me.txtIdSiniestro.Valor
            Dim Fecha As DateTime = Me.txtFechaOcurrido.Valor

            Me.txtLimiteDeducible.Valor = ObtenerLimiteDeducible(Poliza, IdProducto, IdCertificado, IdBien, Fecha, cboAmbitoSiniestro.Valor)
            Me.txtLimiteCoaseguro.Valor = ObtenerLimiteCoaseguro(Poliza, IdProducto, IdCertificado, IdBien, Fecha, cboAmbitoSiniestro.Valor)
            Me.txtAcumuladoDeducible.Valor = ObtenerSaldoDeducible(Poliza, IdProducto, IdCertificado, IdBien, IdSiniestro, Fecha, cboAmbitoSiniestro.Valor)
            Me.txtAcumuladoCoaseguro.Valor = ObtenerSaldoCoaseguro(Poliza, IdProducto, IdCertificado, IdBien, IdSiniestro, Fecha)

            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTotalDeducible_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtTotalDeducible.ValueChangeOnExit
        'validamos el deducible, sólo notificación
        If txtTotalDeducible.Valor + Me.txtAcumuladoDeducible.Valor > Me.txtLimiteDeducible.Valor And Me.txtLimiteDeducible.Valor > 0 Then
            MsgBox("El valor del deducible especificado es mayor al límite establecido según período.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub txtTotalCoaseguro_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtTotalCoaseguro.ValueChangeOnExit
        'validamos el coaseguro, sólo notificación
        If txtTotalCoaseguro.Valor + Me.txtAcumuladoCoaseguro.Valor > Me.txtLimiteCoaseguro.Valor And Me.txtLimiteCoaseguro.Valor > 0 Then
            MsgBox("El valor del coaseguro especificado es mayor al límite establecido.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub cboEstadoSiniestro_ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String) Handles cboEstadoSiniestro.ValueChangeOnExit
        Select Case cboEstadoSiniestro.Valor
            Case "PENDIENTE", "DECLARADO", "RECONSIDERACION"
                Me.EstadoEntradas(True, Me)
                Me.BloquearCamposLLave(Me)
                Call HabilitarBotonesExtra(Me)
        End Select
    End Sub

    Private Sub btnCargarRequisitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarRequisitos.Click
        Try
            '2) Requisitos
            Dim DtReq As DataTable, FilReq As DataRow, Existe As Boolean = False
            DtReq = StiGlobalConn.ObtenerDataset("select IdRequisito, DescripcionRequisito from ProductosSinRequisitos where IdProducto = " & dbStr(cboIdProducto.Valor) & " order by IdRequisito").Tables(0)
            For Each FilReq In DtReq.Rows
                'si ya existe no se ingresa
                Existe = False
                For NR As Integer = 0 To Me.VistaRequisitos.DataRowCount - 1
                    If CStr(VistaRequisitos.GetRowCellValue(NR, "Descripcion")).Trim.ToUpper = dbData(FilReq, "DescripcionRequisito").Trim.ToUpper Then
                        Existe = True
                        Exit For
                    End If
                Next
                'la colocamos en pantalla
                If Existe = False Then
                    Me.AgregarFilaGrid(VistaRequisitos)
                    Me.VistaRequisitos.SetRowCellValue(VistaRequisitos.FocusedRowHandle, "IdRequisito", CInt(dbData(FilReq, "IdRequisito")))
                    Me.VistaRequisitos.SetRowCellValue(VistaRequisitos.FocusedRowHandle, "Descripcion", dbData(FilReq, "DescripcionRequisito"))
                    Me.VistaRequisitos.UpdateCurrentRow()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditarCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarCertificado.Click
        Dim Fcert As New PolizasCertificadosMan
        Fcert.dbTabla = "PolizasCertificados"
        Fcert.dbCondicion = "IdPoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor)
        Fcert.STIConn = StiGlobalConn
        Fcert.Permiso = Me.Permiso
        Fcert.ShowDialog()

        'recargamos los datos de bienes
        Call CargarDatosCertificado(Me.cboIdProducto.Valor, Me.txtIdPoliza.Valor, Me.txtIdCertificado.Valor)

    End Sub

    Private Sub IncluirDocumentosAutomaticos()
        'rutina que incluye los documentos automaticos de una ruta.
        Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Siniestros")
        Dim existe As Boolean
        If txtIdSiniestro.Text <> "" And RutaBase <> "" Then
            Dim Archivos As DataTable = ObtenerArchivosCarpeta(RutaBase & "\" & txtIdSiniestro.Text)
            Dim FilArchivo As DataRow
            For Each FilArchivo In Archivos.Rows
                'verificamos si ya existe
                existe = False
                For NA As Integer = 0 To Me.VistaArchivos.DataRowCount - 1
                    If Trim(UCase(VistaArchivos.GetRowCellValue(NA, "Documento"))) = Trim(UCase(dbData(FilArchivo, "Archivo"))) Then
                        existe = True
                    End If
                Next
                If existe = False Then
                    Dim Id As Integer = ObtenerIDDoc()
                    Me.AgregarFilaGrid(VistaArchivos, True, False)
                    Dim Fila As Integer = VistaArchivos.FocusedRowHandle
                    Me.VistaArchivos.SetRowCellValue(Fila, "IdDocumento", Id)
                    Me.VistaArchivos.SetRowCellValue(Fila, "Documento", dbData(FilArchivo, "Archivo"))
                    Me.VistaArchivos.UpdateCurrentRow()
                End If
            Next

            '17/01/2012
            'los documentos que ya no existen los removemos
            Try
                Dim RutaArchivo As String = "", Atributos As System.IO.FileAttributes
INICIO_VALIDA:
                For NDO As Integer = 0 To VistaArchivos.DataRowCount - 1
                    Try
                        RutaArchivo = VistaArchivos.GetRowCellValue(NDO, "Documento")
                        If System.IO.Path.GetExtension(RutaArchivo) = "" Then
                            If System.IO.Directory.Exists(RutaArchivo) = False Then
                                VistaArchivos.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            End If
                        Else
                            If System.IO.File.Exists(RutaArchivo) = False Then
                                VistaArchivos.DeleteRow(NDO)
                                GoTo INICIO_VALIDA
                            Else
                                ''verificamos que no sea un archivo oculto o del sistema
                                Atributos = System.IO.File.GetAttributes(RutaArchivo)
                                If (Atributos And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Or (Atributos And IO.FileAttributes.System) = IO.FileAttributes.System Then
                                    VistaArchivos.DeleteRow(NDO)
                                    GoTo INICIO_VALIDA
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnQuitarGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGestion.Click
        Try
            Me.EliminarFilaGrid(VistaGestiones)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGestion.Click
        Try
            Dim Id As Integer = clSeguros.ObtenerID("Gestion.Id")
            Me.AgregarFilaGrid(VistaGestiones)
            Dim Fila As Integer = VistaGestiones.FocusedRowHandle
            Me.VistaGestiones.SetRowCellValue(Fila, "IdGestion", Id)
            Me.VistaGestiones.SetRowCellValue(Fila, "TipoGestion", "S")
            Me.VistaGestiones.SetRowCellValue(Fila, "FechaGestion", Date.Today)
            Me.VistaGestiones.SetRowCellValue(Fila, "IdUsuario", StiGlobalConn.User)

            Me.VistaGestiones.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnGestionOutlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionOutlook.Click
        Try
            Dim FilaGes As Integer = VistaGestiones.FocusedRowHandle
            If FilaGes >= 0 Then

                Dim FechaGes As String
                Try
                    FechaGes = CDate(VistaGestiones.GetRowCellValue(FilaGes, "FechaProximaGestion")).ToShortDateString
                Catch ex As Exception
                    FechaGes = ""
                End Try
                If FechaGes = "" Then
                    MsgBox("Debe especificar la fecha de próxima gestión.", MsgBoxStyle.Information, "AVISO...")
                Else

                    Dim Fecha As DateTime = CDate(FechaGes)
                    Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)
                    If Fecha <= Date.Today Then
                        MsgBox("La fecha de próxima gestión es menor a la fecha actual. La cita no puede ser almacenada", MsgBoxStyle.Information, "AVISO...")
                        Exit Sub
                    End If

                    'buscaremos nombre, telefono del cliente del siniestro y de la aseguradora
                    Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                    Dim Aseguradora As String = "", TelAse As String = "", ReclamoAseg As String = "", Poliza As String = "", Reclamo As String = "", FechaOcurrido As String = "", FechaPresentado As String = ""
                    Try
                        sql = "  select "
                        sql &= " s.NombrePresentaReclamo  "
                        sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                        sql &= " ,c.EMail"
                        sql &= " ,a.Nombre as Aseguradora"
                        sql &= " ,a.Telefono as TelefonoAseg, s.IdSiniestroAseguradora, s.IdPoliza, s.IdSiniestro, s.FechaOcurrido, s.FechaPresentado"
                        sql &= " from Siniestros as s"
                        sql &= " inner join Productos as p on p.idproducto = s.idproducto"
                        sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                        sql &= " left join PolizasCertificados as ce on ce.idpoliza = s.idpoliza and ce.idproducto = s.idproducto and ce.idcertificado = s.idcertificado"
                        sql &= " left join Clientes as c on c.idcliente = ce.idcliente"
                        sql &= " where s.idsiniestro = " & dbStr(txtIdSiniestro.Valor) & " and s.IdProducto = " & dbStr(cboIdProducto.Valor) & " and s.IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and s.idcertificado = " & dbStr(txtIdCertificado.Valor)
                        Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                        Cliente = dbData(fila, "NombrePresentaReclamo")
                        Telefono = dbData(fila, "Telefono")
                        Correo = dbData(fila, "EMail")
                        Aseguradora = dbData(fila, "Aseguradora")
                        TelAse = dbData(fila, "TelefonoAseg")
                        Reclamo = dbData(fila, "IdSiniestro")
                        ReclamoAseg = dbData(fila, "IdSiniestroAseguradora")
                        FechaOcurrido = CDate(dbData(fila, "FechaOcurrido")).ToString("dd/MMM/yyyy")
                        FechaPresentado = CDate(dbData(fila, "FechaPresentado")).ToString("dd/MMM/yyyy")
                        Poliza = dbData(fila, "IdPoliza")
                    Catch ex As Exception

                    End Try
                    Dim res As String = AgregarCitaOutlook("Gestión - Reclamo ", "", VistaGestiones.GetRowCellValue(FilaGes, "Comentarios") & vbCrLf _
                                                           & "Aseguradora: " & TelAse & " / " & Aseguradora & vbCrLf _
                                                           & "Póliza: " & Poliza & vbCrLf _
                                                           & "Num.Reclamo: " & Reclamo & vbCrLf _
                                                           & "Reclamo Aseguradora: " & ReclamoAseg & vbCrLf _
                                                           & "Fecha del Siniestro: " & FechaOcurrido & vbCrLf _
                                                           & "Fecha Presenta Reclamo: " & FechaPresentado & vbCrLf _
                                                           & "Asegurado:" & Cliente & vbCrLf & Telefono & vbCrLf _
                                                           & Correo, Inicio, Inicio.AddHours(1))
                    If res <> "" Then
                        MsgBox("No es posible agregar al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                    Else
                        MsgBox("la cita ha sido agregada al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                    End If
                End If
            Else
                MsgBox("Debe Seleccionar la gestión a calendarizar.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarEnvio.Click
        'con este proceso crearemos un envío de reclamo para el reclamo abierto
        Dim Sql As String = ""
        If Me.txtIdSiniestro.Text = "" Or Me.txtIdPoliza.Text = "" Or Me.cboIdProducto.Text = "" Then
            MsgBox("Se debe cargar el reclamo a ser enviado.")
            Exit Sub
        End If
        If Me.txtIdEnvio.Text <> "" Then
            'se usara el mismo envio si es del mismo dia 
            Dim FechaEnvio As String = StiGlobalConn.ObtenerDataset("select FechaEnvio from EnviosSiniestros where IdEnvio = " & dbStr(txtIdEnvio.Text)).Tables(0).Rows(0).Item(0)
            If CDate(FechaEnvio) = Date.Today Then
                MsgBox("El reclamo ya fué enviado previamente este día con el número de envío: " & txtIdEnvio.Valor & ", se reimprimirá este envio.")
                Call ImprimirEnvioSiniestro(txtIdEnvio.Valor, Me.txtIdSiniestro.Valor, PedirDestinatario:=True)
                Exit Sub
            End If
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim IdEnvio As String = clSeguros.ObtenerID("Envios.Siniestros." & Date.Today.Year) & "-" & Date.Today.Year
            'guardamos el envio
            Sql = " insert into EnviosSiniestros (IdEnvio, FechaDesde, FechaHasta, FechaEnvio, IdPlanReclamo, IdAseguradora) values("
            Sql &= dbStr(IdEnvio) & ", " & dbFec(txtFechaPresentado.Valor) & "," & dbFec(txtFechaPresentado.Valor) & ", " & dbFec(Date.Today) & ", " & dbStr("") & ", " & dbStr(StiGlobalConn.ObtenerDataset("select idaseguradora from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)) & ")"
            StiGlobalConn.SQLExecute(Sql)

            Sql = " insert into EnviosSiniestrosDetalle (IdEnvio, IdPoliza, IdProducto, IdCertificado, IdSiniestro) values("
            Sql &= dbStr(IdEnvio) & "," & dbStr(txtIdPoliza.Valor) & "," & dbStr(cboIdProducto.Valor) & "," & dbStr(txtIdCertificado.Valor) & "," & dbStr(txtIdSiniestro.Valor) & ") "
            StiGlobalConn.SQLExecute(Sql)

            'el reclamo
            txtIdEnvio.Valor = IdEnvio
            Sql = " update siniestros "
            Sql &= " set IdEnvio = " & dbStr(IdEnvio)
            Sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor) & " and idsiniestro = " & dbStr(txtIdSiniestro.Valor)
            StiGlobalConn.SQLExecute(Sql)

            'preparamos la impresion
            Call ImprimirEnvioSiniestro(IdEnvio, PedirDestinatario:=True)
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnBuscarDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDiagnostico.Click
        Try
            Dim Fbus As New BusquedaDiagnostico
            Fbus.Tabla = "Diagnosticos"
            Fbus.Columnas = "NombreDiagnostico"
            Fbus.ColAlias = "Descripción Diagnostico"
            Fbus.STIConn = StiGlobalConn
            Fbus.ShowDialog()

            Dim Res As String = Fbus.Tag
            txtDiagnostico.Text = Res.Split("=")(1).Trim.Replace("'", "")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaDetalles_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles VistaDetalles.CustomRowCellEditForEditing
        Select Case GlobalCodCliente
            Case "2120000"
                If e.Column.FieldName = "IdGasto" Then
                    e.RepositoryItem = CargarGastosEnFila(e.RowHandle)
                End If
        End Select
    End Sub

End Class
