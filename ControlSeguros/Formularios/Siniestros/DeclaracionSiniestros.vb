Imports Utilerias.Genericas

Public Class DeclaracionSiniestros

    Private Plan As String = ""
    Private EditandoGrid As Boolean = False

    Private Sub DeclaracionSiniestros_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If CDate(txtFechaOcurrido.Valor) < CDate(Me.txtVigenciaDesde.Valor) Or CDate(txtFechaOcurrido.Valor) > CDate(Me.txtVigenciaHasta.Valor) Then
            MsgBox("La fecha del siniestro está fuera de vigencia.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
            Exit Sub
        End If

        If CDate(txtFechaOcurrido.Valor) > CDate(txtFechaPresentado.Valor) Then
            MsgBox("La fecha de presentado del reclamo no puede ser menor a la fecha de ocurrencia.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
            Exit Sub
        End If

        'una validación para no hacer flujos sobre pólizas con ciertos tipos de cancelación
        Dim LstCancela As String = clSeguros.ObtenerDBParametros("Cod.Cancela.Restringe")
        If LstCancela <> "" Then
            Try
                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select p.IdCancelacion, t.NombreCancelacion from Polizas as p left join TipoCancelacion as t on p.IdCancelacion = t.IdCancelacion where p.idpoliza = " & dbStr(txtIdPoliza.Valor) & " and p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0)
                If ExisteItemEnLista(dbData(FilPol, "IdCancelacion"), LstCancela) = True Then
                    MsgBox("La póliza especificada está cancelada y el tipo de cancelación restringe esta operación: " & dbData(FilPol, "NombreCancelacion"), MsgBoxStyle.Information, "AVISO...")
                    Cancel = True
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
        End If

        'validamos que la fecha del reclamo esté dentro de la vigencia
        If txtIdSiniestro.Text = "-" And Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            If Plan <> "" Then
                'verificaremos si hay patron de reclamos
                Try
                    Dim Patron As String = StiGlobalConn.ObtenerDataset("select NumeroReclamo from SiniestroPlanes where idplan = " & dbStr(Plan)).Tables(0).Rows(0).Item(0)
                    If Patron <> "" Then
                        'buscaremos los patrones
                        If InStr(Patron, "yy#") > 0 Then
                            Patron = Replace(Patron, "yy#", clSeguros.ObtenerID("Reclamo." & Date.Today.Year & "." & Plan))
                        ElseIf InStr(Patron, "#") > 0 Then
                            Patron = Replace(Patron, "#", clSeguros.ObtenerID("Reclamo." & Plan))
                        End If
                        txtIdSiniestroAseguradora.Valor = Patron
                    End If
                Catch ex As Exception

                End Try
            End If

            txtIdSiniestro.Valor = clSeguros.ObtenerID("Reclamos.Num." & Date.Today.Year) & "-" & Date.Today.Year
            Call Me.ActualizarLlavesGrid(Me, txtIdSiniestro.NombreCampo, txtIdSiniestro.Valor)
        End If
    End Sub

    Private Sub DeclaracionSiniestros_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando

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
                Next

                'actualizamos los totales del reclamo original
                sql = "  update siniestros set "
                sql &= " EstadoSiniestro = 'PENDIENTE'"
                sql &= " ,TotalPresentado = isnull((select sum(ValorPresentado) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
                sql &= " ,TotalNoCubierto = isnull((select sum(ValorNoCubierto) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
                sql &= " ,TotalCubierto = isnull((select sum(ValorCubierto) from SiniestrosDetalle where SiniestrosDetalle.IdPoliza = siniestros.IdPoliza and SiniestrosDetalle.IdProducto = siniestros.IdProducto and SiniestrosDetalle.IdCertificado = siniestros.IdCertificado and SiniestrosDetalle.IdSiniestro = siniestros.IdSiniestro),0)"
                sql &= " ,TotalReembolso = isnull((select sum(ValorReembolso) from SiniestrosPagos where SiniestrosPagos.IdPoliza = siniestros.IdPoliza and SiniestrosPagos.IdProducto = siniestros.IdProducto and SiniestrosPagos.IdCertificado = siniestros.IdCertificado and SiniestrosPagos.IdSiniestro = siniestros.IdSiniestro),0)"
                sql &= " ,TotalPendiente = isnull((select sum(ValorReserva) from SiniestrosReservas where SiniestrosReservas.IdPoliza = siniestros.IdPoliza and SiniestrosReservas.IdProducto = siniestros.IdProducto and SiniestrosReservas.IdCertificado = siniestros.IdCertificado and SiniestrosReservas.IdSiniestro = siniestros.IdSiniestro),0)"
                sql &= " , usuariograbacion = " & dbStr(StiGlobalConn.User, 25)
                ''sql &= " , TotalDeducible = 0,TotalCoaseguro =0, TotalDeudores=0"
                sql &= " where IdPoliza = " & dbStr(txtIdPoliza.Valor)
                sql &= " and IdProducto = " & dbStr(cboIdProducto.Valor)
                sql &= " and IdCertificado = " & dbStr(txtIdCertificado.Valor)
                sql &= " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)
                StiGlobalConn.SQLExecute(sql)


                ''creamos la reserva
                Dim Presentado As Double = ObtenerTotalPresentado()
                sql = "  insert into SiniestrosReservas "
                sql &= " (IdPoliza, IdProducto, IdCertificado, IdSiniestro, IdReserva,"
                sql &= " FechaReserva, ValorAsegurado, ValorReserva) values("
                sql &= dbStr(txtIdPoliza.Valor, 25) & C & dbStr(cboIdProducto.Valor, 25) & C & dbStr(txtIdCertificado.Valor, 25) & C & dbStr(txtIdSiniestro.Valor, 25) & C & dbInt(1) & C
                sql &= dbFec(txtFechaPresentado.Valor) & C & dbNum(0) & C & dbNum(Presentado) & ")"
                StiGlobalConn.SQLExecute(sql)

                select case GlobalCodCliente
                    case "2120000"
                        Try
                            If Me.cboFlujo.Valor.ToString.Trim <> "" Then
                                StiGlobalConn.SQLExecute("update FlujosDocumentos set IdPoliza = " & dbStr(txtIdPoliza.Valor) & ", IdProducto = " & dbStr(Me.cboIdProducto.Valor) & ", IdSiniestro = " & dbStr(txtIdSiniestro.Valor) & " where IdFlujoDoc = " & dbStr(cboFlujo.Valor.ToString.Trim))
                            end if
                        Catch ex As Exception

                        End Try
                    case else
                        If Me.cboFlujo.Valor.ToString.Trim = "" Then
                            Dim idFlujoCreado As String = ""
                            Dim msgFlujo As String = clFlujos.IniciarFlujoSiniestro(txtIdSiniestro.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, cboEjecutivoCta.Valor, txtDescripcionSiniestro.Valor, idFlujoCreado)
                            'marcaremos el siniestros 
                            If msgFlujo <> "" Then MsgBox(msgFlujo, MsgBoxStyle.Information, "AVISO...")
                            If idFlujoCreado <> "" Then StiGlobalConn.SQLExecute("update FlujosDocumentos set FlujoAutomatico = 'S' where IdFlujoDoc = " & dbStr(idFlujoCreado))
                        Else
                            Try
                                StiGlobalConn.SQLExecute("update FlujosDocumentos set IdPoliza = " & dbStr(txtIdPoliza.Valor) & ", IdProducto = " & dbStr(Me.cboIdProducto.Valor) & ", IdSiniestro = " & dbStr(txtIdSiniestro.Valor) & " where IdFlujoDoc = " & dbStr(cboFlujo.Valor.ToString.Trim))
                            Catch ex As Exception
    
                            End Try
                        End If
                End Select
                
        End Select
    End Sub

    Private Function ObtenerTotalPresentado() As Double
        Dim res As Double = 0
        Try
            For NG As Integer = 0 To Me.VistaDetalles.DataRowCount - 1
                res += VistaDetalles.GetRowCellValue(NG, "ValorPresentado")
            Next
        Catch ex As Exception

        End Try
        Return res
    End Function

    Private Sub DeclaracionSiniestros_DespuesDeGuardarFinal() Handles Me.DespuesDeGuardarFinal
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtIdSiniestro.SoloLectura = True
            Me.txtIdSiniestro.Valor = "-"
            btnBuscarCliente.Focus()
        End If
    End Sub

    Private Sub DeclaracionSiniestros_DespuesDeGuardarSinTransaccion() Handles Me.DespuesDeGuardarSinTransaccion
        'Preguntaremos si desea completar el reclamo
        If MsgBox("Se ha creado el reclamo " & Me.txtIdSiniestro.Text & vbCrLf & " ¿Desea completar la información del reclamo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "PREGUNTA") = MsgBoxResult.Yes Then
            Dim frmSiniestro As New SiniestrosMan
            frmSiniestro.Permiso = Me.Permiso
            frmSiniestro.STIConn = StiGlobalConn
            frmSiniestro.dbTabla = "Siniestros"
            frmSiniestro.dbCondicion = "IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto =  " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(txtIdCertificado.Valor) & " and IdSiniestro = " & dbStr(txtIdSiniestro.Valor)
            frmSiniestro.MdiParent = Me.MdiParent
            Select Case GlobalCodCliente
                Case "2120000"
                    frmSiniestro.SolicitarGestion = True
            End Select

            frmSiniestro.Show()
        End If
    End Sub

    Private Sub DeclaracionSiniestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtIdSiniestro.SoloLectura = True
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Me.txtFechaOcurrido.Valor = Date.Today
            Me.txtFechaPresentado.Valor = Date.Today
            btnBuscarCliente.Focus()
            Me.txtIdSiniestro.Valor = "-"
            Me.cboAmbitoSiniestro.Valor = "L"
        End If

        Me.txtLimiteCoaseguro.SoloLectura = True
        Me.txtLimiteDeducible.SoloLectura = True
        Me.txtAcumuladoCoaseguro.SoloLectura = True
        Me.txtAcumuladoDeducible.SoloLectura = True
        If clSeguros.ObtenerDBParametros("Flujo.Siniestros") <> "" Then
            Me.cboFlujo.Visible = True
        Else
            Me.cboFlujo.Visible = False
        End If

        cboAmbitoSiniestro.Lista = clSeguros.ObtenerDBParametros("Siniestros.Ambitos")
        cboAmbitoSiniestro.Llenar_Combo()

        select case GlobalCodCliente
            case "2120000"
                cboFlujo.TextoNuevoItem = ""
                cboFlujo.Obligatorio = True

                txtNoFolioReferencia.Visible = True
                cboEjecutivoCta.Width = 315
            Case Else
                txtNoFolioReferencia.Visible = False
                cboEjecutivoCta.Width = 504
                cboFlujo.Obligatorio = False
        End Select

        Me.cboFlujo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboFlujo.Llenar_Combo()


    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String) Handles cboIdProducto.ValueChangeOnExit
        Call CargarGastos()
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

    Private Sub btnAgregarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGasto.Click
        Try
            Me.AgregarFilaGrid(VistaDetalles)
            Dim IdDet As Integer = ObtenerIDDet()
            VistaDetalles.SetRowCellValue(VistaDetalles.FocusedRowHandle, "IdDetalle", IdDet)
            VistaDetalles.FocusedColumn = VistaDetalles.Columns("IdGasto")
            VistaDetalles.UpdateCurrentRow()
            VistaDetalles.Focus()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGastos.Click
        Try
            Me.EliminarFilaGrid(VistaDetalles)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDDet() As Integer
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.txtFechaOcurrido.Valor = Date.Today
        Me.txtFechaPresentado.Valor = Date.Today
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim fbus As New BusquedaCertReclamo
            fbus.dbFiltro = ""
            fbus.ShowDialog()

            If busCodigo <> "" Then
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                Call CargarGastos()
                txtIdCertificado.Valor = stiSplit(busCodigo, "G2|1")
                txtIdBien.Valor = Val(stiSplit(busCodigo, "G3|1"))
                txtNombreContratante.Valor = stiSplit(busCodigo, "G4|1")
                txtAsegurado.Valor = stiSplit(busCodigo, "G5|1")
                txtBeneficiario.Valor = stiSplit(busCodigo, "G6|1")
                Try
                    'obtenermos la vigencia del certificado
                    Dim FilCertificado As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta from PolizasCertificados where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idcertificado = " & dbStr(txtIdCertificado.Valor)).Tables(0).Rows(0)
                    Me.txtVigenciaDesde.Valor = dbData(FilCertificado, "VigenciaDesde")
                    Me.txtVigenciaHasta.Valor = dbData(FilCertificado, "VigenciaHasta")
                Catch ex As Exception

                End Try

                'propondremos el ejecutivo de la cuenta
                Dim IdCliente As String = ""
                Try
                    IdCliente = StiGlobalConn.ObtenerDataset("select idcliente from polizas where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor)).Tables(0).Rows(0).Item(0)
                    cboEjecutivoCta.Valor = clSeguros.ObtenerEjecutivoCuenta(IdCliente, cboIdProducto.Valor, "RECLAMOS")
                    '    Dim ejecutivo As String = StiGlobalConn.ObtenerDataset("select c.EjecutivoCta from clientes as c inner join polizas as p on p.idcliente = c.idcliente where p.idpoliza = " & dbStr(txtIdPoliza.Valor) & " and p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                    '    If ejecutivo <> "" Then
                    '        cboEjecutivoCta.Valor = ejecutivo
                    '    End If
                Catch ex As Exception

                End Try

                Try
                    Me.cboFlujo.Query = "select IdFlujoDoc as Flujo, Comentario, FechaInicia as Fecha, IdPoliza as [Póliza], NombreCliente as Cliente from FlujosDocumentos where (estadoflujo = 'PENDIENTE' and IdCliente = " & dbStr(IdCliente) & ") "
                    Me.cboFlujo.Llenar_Combo()
                Catch ex As Exception

                End Try

                Dim strRamo As String = ""
                Try
                    strRamo = StiGlobalConn.ObtenerDataset("select IdRamo from Productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                    Me.cboAmbitoSiniestro.Valor = "L"
                    Select Case strRamo.ToUpper
                        Case "103", "103O", "301", "301D"
                            Me.txtAcumuladoDeducibleMundial.Visible = True
                            Me.txtAcumuladoDeducibleDental.Visible = True
                            Me.cboAmbitoSiniestro.SoloLectura = False

                        Case Else
                            Me.txtAcumuladoDeducibleMundial.Visible = False
                            Me.txtAcumuladoDeducibleDental.Visible = False
                            Me.cboAmbitoSiniestro.SoloLectura = True
                    End Select

                Catch ex As Exception

                End Try

                Plan = stiSplit(busCodigo, "G7|1")

                'generamos el correlativo
                If CDate(txtFechaOcurrido.Valor) < CDate(Me.txtVigenciaDesde.Valor) Or CDate(txtFechaOcurrido.Valor) > CDate(Me.txtVigenciaHasta.Valor) Then
                    MsgBox("La fecha del siniestro está fuera de vigencia.", MsgBoxStyle.Information, "AVISO...")
                End If

                If CDate(txtFechaOcurrido.Valor) > CDate(txtFechaPresentado.Valor) Then
                    MsgBox("La fecha de presentado del reclamo no puede ser menor a la fecha de ocurrencia.", MsgBoxStyle.Information, "AVISO...")
                End If
                'Call DeclaracionSiniestros_AntesDeGuardar(Nothing)

                Call ObtenerLimitesPoliza()

                txtFechaOcurrido.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaDetalles_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaDetalles.CellValueChanged
        Try
            Me.VistaDetalles.PostEditor()
            If EditandoGrid = True Then Exit Sub
            If e.Column.FieldName = "ValorPresentado" Then
                EditandoGrid = True
                Me.VistaDetalles.SetRowCellValue(e.RowHandle, "ValorCubierto", VistaDetalles.GetRowCellValue(e.RowHandle, "ValorPresentado"))
                Me.VistaDetalles.SetRowCellValue(e.RowHandle, "ValorNoCubierto", 0.0)
                EditandoGrid = False
            End If
            If e.Column.FieldName = "ValorCubierto" Then
                EditandoGrid = True
                Me.VistaDetalles.SetRowCellValue(e.RowHandle, "ValorNoCubierto", VistaDetalles.GetRowCellValue(e.RowHandle, "ValorPresentado") - VistaDetalles.GetRowCellValue(e.RowHandle, "ValorCubierto"))
                EditandoGrid = False
            End If
            If e.Column.FieldName = "ValorNoCubierto" Then
                EditandoGrid = True
                Me.VistaDetalles.SetRowCellValue(e.RowHandle, "ValorCubierto", VistaDetalles.GetRowCellValue(e.RowHandle, "ValorPresentado") - VistaDetalles.GetRowCellValue(e.RowHandle, "ValorNoCubierto"))
                EditandoGrid = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaDetalles_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaDetalles.LostFocus
        Me.btnAgregarGasto.Focus()
    End Sub

    Private Sub GridDetalle_ProcessGridKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDetalle.ProcessGridKey
        If e.KeyCode = Keys.Enter Then
            If (e.Modifiers = Keys.None And VistaDetalles.IsLastRow And VistaDetalles.FocusedColumn.VisibleIndex = VistaDetalles.VisibleColumns.Count - 1) Or (e.Modifiers = Keys.Shift And VistaDetalles.IsFirstRow And VistaDetalles.FocusedColumn.VisibleIndex = 0) Then
                If VistaDetalles.IsEditing Then VistaDetalles.CloseEditor()
                VistaDetalles.PostEditor()
                btnAgregarGasto.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFechaOcurrido_ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String) Handles txtFechaOcurrido.ValueChangeOnExit
        'validamos que la fecha del reclamo esté dentro de la vigencia
        If CDate(txtFechaOcurrido.Valor) < CDate(Me.txtVigenciaDesde.Valor) Or CDate(txtFechaOcurrido.Valor) > CDate(Me.txtVigenciaHasta.Valor) Then
            MsgBox("La fecha del siniestro está fuera de vigencia.", MsgBoxStyle.Information, "AVISO...")
        End If
        Call ObtenerLimitesPoliza()
    End Sub

    Private Sub ObtenerLimitesPoliza()
        Try
            If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                Dim Poliza As String = Me.txtIdPoliza.Valor
                Dim IdProducto As String = Me.cboIdProducto.Valor
                Dim IdCertificado As String = Me.txtIdCertificado.Valor
                Dim IdBien As Integer = Me.txtIdBien.Valor
                Dim IdSiniestro As String = Me.txtIdSiniestro.Valor
                Dim Fecha As DateTime = Me.txtFechaOcurrido.Valor

                Me.txtLimiteDeducible.Valor = ObtenerLimiteDeducible(Poliza, IdProducto, IdCertificado, IdBien, Fecha, cboAmbitoSiniestro.Valor)

                Me.txtLimiteCoaseguro.Valor = ObtenerLimiteCoaseguro(Poliza, IdProducto, IdCertificado, IdBien, Fecha, cboAmbitoSiniestro.Valor)

                Me.txtAcumuladoDeducible.Valor = ObtenerSaldoDeducible(Poliza, IdProducto, IdCertificado, IdBien, IdSiniestro, Fecha, "L")
                Me.txtAcumuladoDeducibleMundial.Valor = ObtenerSaldoDeducible(Poliza, IdProducto, IdCertificado, IdBien, IdSiniestro, Fecha, "M")
                Me.txtAcumuladoDeducibleDental.Valor = ObtenerSaldoDeducible(Poliza, IdProducto, IdCertificado, IdBien, IdSiniestro, Fecha, "D")
                Me.txtAcumuladoCoaseguro.Valor = ObtenerSaldoCoaseguro(Poliza, IdProducto, IdCertificado, IdBien, IdSiniestro, Fecha)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        Call ObtenerLimitesPoliza()
    End Sub

    Private Sub txtVigenciaHasta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaHasta.ValueChangeOnExit
        Call ObtenerLimitesPoliza()
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


    Private Sub cboFlujo_NewItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFlujo.NewItem
        Try
            if cboFlujo.TextoNuevoItem = "" then exit sub 
            Dim idcliente As String = ""
            Try
                idcliente = StiGlobalConn.ObtenerDataset("select idcliente from polizas where idpoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and idproducto = " & dbStr(Me.cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                idcliente = ""
            End Try

            Dim frmNF As New NuevoFlujo
            frmNF.STIConn = StiGlobalConn
            frmNF.Permiso = Me.Permiso
            frmNF.IdClienteDefault = idcliente
            frmNF.ObservacionDefault = Me.txtDescripcionSiniestro.Valor
            frmNF.ShowDialog()

            'actualizamos la lista de flujos
            Me.cboFlujo.Llenar_Combo()

            'PROPONEMOS EL PRIMER FLUJO
            cboFlujo.Valor = ""
            If IdNuevoFlujo <> "" Then
                cboFlujo.Valor = IdNuevoFlujo
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboAmbitoSiniestro_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboAmbitoSiniestro.ValueChangeOnExit
        Call ObtenerLimitesPoliza()
    End Sub

End Class
