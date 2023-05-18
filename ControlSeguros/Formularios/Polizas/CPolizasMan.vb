
imports Utilerias.Genericas

Public Class CPolizasMan

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

    Private Sub CPolizasMan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
            Call CargarCertificados()
        End If
    End Sub

    Private Sub CPolizasMan_AntesDeEliminar(ByRef Cancel As Boolean) Handles Me.AntesDeEliminar
        Try
            'eliminaremos los registros relacionados de certificados
            StiGlobalConn.SQLExecute("delete from CPolizasCoberturasAdicional where idpoliza = " & dbStr(txtIdPoliza.Valor) & "  and idproducto = " & dbStr(cboIdProducto.Valor))
            StiGlobalConn.SQLExecute("delete from CPolizasCoberturas where idpoliza = " & dbStr(txtIdPoliza.Valor) & "  and idproducto = " & dbStr(cboIdProducto.Valor))
            StiGlobalConn.SQLExecute("delete from CPolizasCesiones where idpoliza = " & dbStr(txtIdPoliza.Valor) & "  and idproducto = " & dbStr(cboIdProducto.Valor))
            StiGlobalConn.SQLExecute("delete from CPolizasBienes where idpoliza = " & dbStr(txtIdPoliza.Valor) & "  and idproducto = " & dbStr(cboIdProducto.Valor))
            StiGlobalConn.SQLExecute("delete from CPolizasBeneficiarios where idpoliza = " & dbStr(txtIdPoliza.Valor) & "  and idproducto = " & dbStr(cboIdProducto.Valor))
            StiGlobalConn.SQLExecute("delete from CPolizasCertificados where idpoliza = " & dbStr(txtIdPoliza.Valor) & "  and idproducto = " & dbStr(cboIdProducto.Valor))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CPolizasMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        Dim TipoIdOferta As String = clSeguros.ObtenerDBParametros("Oferta.IdAutomatico")
        If TipoIdOferta.Trim.ToUpper = "S" And txtIdPoliza.Valor.ToString.Trim = "" Then
            Me.txtIdPoliza.Valor = clSeguros.ObtenerIDTabla("CPolizas", "cast(IdPoliza as int)")
        End If

        If TipoIdOferta.Trim.ToUpper = "A" And txtIdPoliza.Valor.ToString.Trim = "" Then
            'formato especial de adrisa
            Dim NumOferta As String = clSeguros.ObtenerID("Oferta.Id." & Date.Today.Year.ToString.Trim)
            NumOferta = PE(NumOferta, 4, "0", TipoRelleno.RellenarIzquierda) & "-" & Date.Today.Year.ToString.Trim
            Me.txtIdPoliza.Valor = NumOferta
        End If

        If txtResumenFechaEnvio.Text = "" And cboResumenFormaEnvio.Text <> "" Then
            MsgBox("A la oferta no se le ha especificado la fecha de envío.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If

        If txtResumenFechaEnvio.Text <> "" And cboResumenFormaEnvio.Text = "" Then
            MsgBox("A la oferta no se le ha especificado el tipo de envío de la oferta", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If

        If cboResumenFormaEnvio.Valor = "C" And txtResumenNumeroCartaEnvio.Text = "" Then
            MsgBox("Se debe especificar el número de la carta de envío.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If

    End Sub

    Private Sub CPolizasMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VistaDoc.OptionsBehavior.Editable = False
        Me.cboDepartamento.OcultarColumna(1)
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.cboEstadoPoliza.Valor = "PENDIENTE"
                Me.cboTipoDeducible.Valor = "V"
                VistaCertificados.OptionsBehavior.Editable = False
                Me.txtNumVigencia.Valor = 1
                Me.TabPoliza.Enabled = False

                Dim TipoIdOferta As String = clSeguros.ObtenerDBParametros("Oferta.IdAutomatico")
                If TipoIdOferta.Trim.ToUpper <> "" Then
                    Me.txtIdPoliza.SoloLectura = True
                End If
                Me.txtFechaGrabacion.Valor = Date.Now
                Me.txtFechaCambioEstado.Valor = Date.Now


            Case enEstadoRegistro.Modificando
                Call CargarCertificados()
                VistaCertificados.OptionsBehavior.Editable = False

                'cargamos documentos nuevos
                'Call IncluirDocumentosAutomaticos()

                'If cboEstadoPoliza.Valor = "CANCELADA" Then
                '    Me.EstadoEntradas(False, Me)
                '    Me.VistaDoc.OptionsBehavior.Editable = False
                '    Me.btnAgregarCert.Enabled = False
                '    Me.btnAgregarClausula.Enabled = False
                '    Me.btnQuitarClausula.Enabled = False
                '    Me.btnBuscarCliente.Enabled = False
                '    MsgBox("La póliza se encuentra cancelada no podrá realizar ningun cambio.", MsgBoxStyle.Information, "AVISO...")
                'End If
        End Select
        Call CompletarNombreArchivos()
        Call ProcesarPermisosComision()

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

        Dim IdCliente As String = clSeguros.ObtenerIdCliente()
        Select Case IdCliente
            Case "2120000"
                pag21200000.PageVisible = True
                cboNegocioPor.Visible = True
                cboNegocioPor.Obligatorio = True

            Case Else
                cboNegocioPor.Visible = False
                cboNegocioPor.Obligatorio = False
        End Select

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
        Me.cboEstadoPoliza.Valor = "PENDIENTE"
        Me.txtNumVigencia.Valor = 1
        Me.txtIdPoliza.Focus()
        Me.TabPoliza.Enabled = False
        Me.txtFechaGrabacion.Valor = Date.Now
        Me.txtFechaCambioEstado.Valor = Date.Now
        Me.cboEstadoPoliza.Valor = "PENDIENTE"
    End Sub

    Private Sub txtVigenciaDesde_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtVigenciaDesde.ValueChangeOnExit
        Try
            Me.txtVigenciaHasta.Valor = CDate(Me.txtVigenciaDesde.Valor).AddYears(1)
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
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Documento)
                Me.VistaDoc.SetRowCellValue(Fila, "Archivo", System.IO.Path.GetFileName(Documento))
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
        'Call IncluirDocumentosAutomaticos()
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
        Dim frmCert As New CPolizasCertificadosMan
        frmCert.dbTabla = "CPolizasCertificados"
        frmCert.Permiso = Me.Permiso
        frmCert.ClavesNuevo = Me.txtIdPoliza.Valor & "|" & Me.cboIdProducto.Valor & "|" & Me.txtIdCliente.Valor & "|" & CDate(Me.txtVigenciaDesde.Valor).ToShortDateString & "|" & CDate(Me.txtVigenciaHasta.Valor).ToShortDateString & "|" & cboVendedor.Valor
        frmCert.EstadoRegistro = enEstadoRegistro.Adicionando
        frmCert.STIConn = StiGlobalConn
        If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
            frmCert.MdiParent = Me.MdiParent
            frmCert.Show()
        Else
            frmCert.ShowDialog(Me)
            Call CargarCertificados()
        End If
        
    End Sub

    Private Sub CargarCertificados()
        GridCertificados.DataSource = Nothing
        GridCertificados.Refresh()
        Dim sql As String = ""
        Try
            sql = "  select IdCertificado, NombreCliente, VigenciaDesde, VigenciaHasta, isnull(primaneta,0) as Prima, ValorAsegurado"
            sql &= " , (isnull(GastosEmi,0)+isnull(GastosFrac,0)+isnull(GastosBomb,0)+isnull(GastosOtros,0)) as Gastos, isnull(iva,0) as Iva, isnull(total,0) as Total, isnull(estadocertificado,'') as Estado "
            sql &= " from CPolizasCertificados"
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

            If s1 > S2 Then
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
                Dim frmCert As New CPolizasCertificadosMan
                frmCert.dbTabla = "CPolizasCertificados"
                frmCert.STIConn = StiGlobalConn
                frmCert.Permiso = Me.Permiso
                frmCert.dbCondicion = "IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(Me.VistaCertificados.GetRowCellValue(fila, "IdCertificado"))
                frmCert.ClavesNuevo = Me.txtIdPoliza.Valor & "|" & Me.cboIdProducto.Valor & "|" & Me.txtIdCliente.Valor & "|" & CDate(Me.txtVigenciaDesde.Valor).ToShortDateString & "|" & CDate(Me.txtVigenciaHasta.Valor).ToShortDateString & "|" & cboVendedor.Valor
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
            Dim IdCla As Integer = ObtenerIDCla()
            Me.AgregarFilaGrid(VistaClausulas)
            Dim Fila As Integer = VistaClausulas.FocusedRowHandle
            VistaClausulas.SetRowCellValue(Fila, "IdClausula", IdCla)
            VistaClausulas.UpdateCurrentRow()
            Fila = VistaClausulas.FocusedRowHandle

            'propondremos una clausula
            Try
                Dim IdRamo As String = ""
                busCodigo = ""
                Dim Fbus As New BusquedaCondiciones
                IdRamo = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
                Fbus.dbFiltro = " and c.idramo = " & dbStr(IdRamo)
                Fbus.ShowDialog()
                If busCodigo <> "" Then
                    Try
                        VistaClausulas.SetRowCellValue(Fila, "Clausula", StiGlobalConn.ObtenerDataset("select Descripcion from CondicionesEspeciales where IdCondicion = " & dbStr(busCodigo)).Tables(0).Rows(0).Item(0))
                        VistaClausulas.SetRowCellValue(Fila, "CodigoInterno", busCodigo)
                    Catch ex As Exception

                    End Try
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
        VistaCertificados.OptionsBehavior.Editable = False
        Me.EstadoEntradas(True, Me)
        Me.VistaDoc.OptionsBehavior.Editable = True
        Me.btnAgregarCert.Enabled = True
        Me.btnAgregarClausula.Enabled = True
        Me.btnQuitarClausula.Enabled = True
        Me.btnBuscarCliente.Enabled = True

        'If cboEstadoPoliza.Valor = "CANCELADA" Then
        '    Me.EstadoEntradas(False, Me)
        '    Me.VistaDoc.OptionsBehavior.Editable = True
        '    Me.btnAgregarCert.Enabled = False
        '    Me.btnAgregarClausula.Enabled = False
        '    Me.btnQuitarClausula.Enabled = False
        '    Me.btnBuscarCliente.Enabled = False
        '    MsgBox("La póliza se encuentra cancelada no podrá realizar ningun cambio.", MsgBoxStyle.Information, "AVISO...")
        'End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.TabPoliza.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Try
        '    Dim sql As String = ""


        '    sql = "  select p.IdPoliza as IdPoliza"
        '    sql &= ",pr.Descripcion as Producto"
        '    sql &= ",r.NombreRamo as Ramo"
        '    sql &= ",a.Nombre as Aseguradora"
        '    sql &= ",p.IdCliente as IdCliente"
        '    sql &= ",p.NombreCliente as Cliente"
        '    sql &= ",p.VigenciaDesde as VigenciaDesde"
        '    sql &= ",p.VigenciaHasta as VigenciaHasta"
        '    sql &= ",(select sum(c.ValorAsegurado) from CPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
        '    sql &= ",(select sum(c.PrimaNeta) from CPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
        '    sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from CPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
        '    sql &= ",(select sum(c.Iva) from CPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
        '    sql &= ",(select sum(c.Total) from CPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
        '    sql &= ", p.FechaCancelacion as FechaCancela"
        '    sql &= ", p.MotivoCancelacion as MotivoCancela"
        '    sql &= ",cl.EjecutivoCta as Ejecutivo"
        '    sql &= " from CPolizas as p"
        '    sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
        '    sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
        '    sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
        '    sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
        '    sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
        '    sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)

        '    Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        '    dtPoliza.TableName = "Polizas"

        '    'incluimos las clausulas
        '    sql = "  select p.IdPoliza"
        '    sql &= " ,p.IdClausula"
        '    sql &= " ,pr.Descripcion as Producto"
        '    sql &= " ,p.Clausula as Condicion"
        '    sql &= " from CPolizasClausulas as p"
        '    sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
        '    sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
        '    sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)

        '    Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        '    dtClausulas.TableName = "Condiciones"

        '    'incluimos los certificados
        '    sql = "  select c.IdPoliza"
        '    sql &= " ,pr.Descripcion as Producto"
        '    sql &= " ,c.IdCertificado"
        '    sql &= " ,c.NombreCliente as Cliente"
        '    sql &= " ,c.ValorAsegurado as SumaAsegurada"
        '    sql &= " ,c.PrimaNeta as PrimaNeta"
        '    sql &= " ,c.GastosEmi"
        '    sql &= " ,c.GastosFrac as GastosFin"
        '    sql &= " ,c.GastosBomb"
        '    sql &= " ,c.GastosOtros"
        '    sql &= " ,c.Iva as Impuestos"
        '    sql &= " ,c.Total"
        '    sql &= " from CPolizasCertificados as c"
        '    sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
        '    sql &= " where c.idpoliza = " & dbStr(txtIdPoliza.Valor)
        '    sql &= " and c.idproducto = " & dbStr(cboIdProducto.Valor)
        '    ''solo vigentes
        '    sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
        '    sql &= " order by c.IdCertificado"

        '    Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        '    dtCertificados.TableName = "Certificados"


        '    Dim DsRep As New DataSet
        '    DsRep.Tables.Add(dtPoliza.Copy)
        '    DsRep.Tables.Add(dtCertificados.Copy)
        '    DsRep.Tables.Add(dtClausulas.Copy)
        '    DsRep.Tables.Add(tblLogo.Copy)

        '    Dim rep As New frmReportes
        '    Dim Reporte As New RepDetPoliza
        '    Reporte.SetDataSource(DsRep)

        '    ''Definiremos algunos datos del reporte
        '    SetRepFormulaString(Reporte,"UserLog",ObtenerLogUser())

        '    rep.CRViewer.ReportSource = Reporte
        '    rep.MdiParent = Me.MdiParent
        '    rep.Show()

        'Catch ex As Exception
        '    MsgBox("Existen problemas para imprimir la Oferta." & vbCrLf & ex.Message, MsgBoxStyle.Information, "AVISO...")
        'End Try

        Try
            Dim sql As String = ""

            Dim Reporte As Object
            Reporte = New RepDetPoliza
            Dim ReportePersonal As String = clSeguros.ObtenerDBParametros("Reporte.Poliza")
            If ReportePersonal <> "" Then Reporte = CrearNuevoObjeto(ReportePersonal)

            sql = "  select p.IdPoliza as IdPoliza"
            sql &= ",pr.Descripcion as Producto"
            sql &= ",r.NombreRamo as Ramo"
            sql &= ",a.Nombre as Aseguradora"
            sql &= ",p.IdCliente as IdCliente"
            sql &= ",p.NombreCliente as Cliente"
            sql &= ",p.VigenciaDesde as VigenciaDesde"
            sql &= ",p.VigenciaHasta as VigenciaHasta"
            sql &= ",(select sum(c.ValorAsegurado) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from cPolizas as p"
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join RamoSeguros as r on r.idramo = pr.idramo"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)

            Dim dtPoliza As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPoliza.TableName = "Polizas"

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " ,p.IdClausula as IdClausula"
            sql &= " ,p.Categoria"
            sql &= " from cPolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"


            Dim FiltroExclusionCertificados As String = ""
            'los colectivos de autos y gastos medicos no se imprimen todos los cert.
            'Dim NumCert As Integer = StiGlobalConn.ObtenerDataset("select count(*) from PolizasCertificados as c where c.idpoliza = " & dbstr(txtIdPoliza.Valor) & " and c.idproducto = " & dbStr(cboIdProducto.Valor) & "and (c.RazonExclusion is null or c.RazonExclusion = '') ").Tables(0).Rows(0).Item(0)
            'Dim Ramo As String = StiGlobalConn.ObtenerDataset("select idramo from productos where idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0).Item(0)
            'If NumCert > 1 And Not (Ramo = "401" Or Ramo = "402") Then
            'FiltroExclusionCertificados = "1"
            'End If
            If MsgBox("¿Desea Imprimir el detalle de la Oferta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
                FiltroExclusionCertificados = "1"
            End If

            'incluimos los certificados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.NombreCliente as Cliente"
            sql &= " ,p.ValorAsegurado as SumaAsegurada"
            sql &= " ,p.PrimaNeta as PrimaNeta"
            sql &= " ,p.GastosEmi"
            sql &= " ,p.GastosFrac as GastosFin"
            sql &= " ,p.GastosBomb"
            sql &= " ,p.GastosOtros"
            sql &= " ,p.Iva as Impuestos"
            sql &= " ,p.Total"
            sql &= " from cPolizasCertificados as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            ''solo vigentes
            'sql &= " and (p.RazonExclusion is null or p.RazonExclusion = '') and p.estadoCertificado = 'VIGENTE'"
            sql &= " order by p.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtCertificados.Rows.Count = 0 Then
                'verificamos si tiene campos especiales para completar
                Dim filOfertaEsp As DataRow = StiGlobalConn.ObtenerDataset("select * from cPolizas where  idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0)

                Dim filCert As DataRow = dtCertificados.NewRow
                filCert("IdPoliza") = dtPoliza.Rows(0).Item("IdPoliza")
                filCert("Producto") = dtPoliza.Rows(0).Item("Producto")
                filCert("IdCertificado") = "0"
                filCert("Cliente") = dtPoliza.Rows(0).Item("Cliente")
                filCert("SumaAsegurada") = Val(dbData(filOfertaEsp, "ResumenSumaAsegurada"))
                filCert("PrimaNeta") = Val(dbData(filOfertaEsp, "ResumenPrimaAnual"))
                filCert("GastosEmi") = 0
                filCert("GastosFin") = 0
                filCert("GastosBomb") = 0
                filCert("GastosOtros") = 0
                filCert("Impuestos") = 0
                filCert("Total") = Val(dbData(filOfertaEsp, "ResumenPrimaAnual"))
                dtCertificados.Rows.Add(filCert)
            End If
            dtCertificados.TableName = "Certificados"

            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,isnull(c.Descripcion, ca.Descripcion) as Cobertura"
            sql &= " ,p.SumaAsegurada"
            sql &= " ,p.Deducible"
            sql &= " ,p.Tasa"
            sql &= " ,p.IdCobertura"
            sql &= " from cPolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " left join cPolizasCoberturasAdicional as ca on ca.IdPoliza = p.IdPoliza and ca.IdProducto = p.IdProducto and ca.IdCertificado = p.IdCertificado and ca.IdCobertura = p.IdCobertura "
            sql &= " inner join cPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            'sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " and p.SumaAsegurada > 0 "
            sql &= " order by p.IdCertificado, p.IdCobertura"

            Dim dtCoberturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCoberturas.TableName = "Coberturas"

            ''la descripcion de los bienes asegurados
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBien"
            sql &= " ,p.NombreBien"

            sql &= " ,case "
            sql &= "   when charindex(', hasta por $', cast(p.descripcionbien as varchar(max))) > 0 then"
            sql &= "      replace(substring(p.descripcionbien,1, charindex(', hasta por $', cast(p.descripcionbien as varchar(max)))-1),'hasta la suma de','')"
            sql &= "   else descripcionbien"
            sql &= " end as DescripcionBien"
            'sql &= " ,p.DescripcionBien"

            sql &= " ,case "
            sql &= "  when charindex(', hasta por $', cast(descripcionbien as varchar(max))) > 0 then"
            sql &= "       substring(descripcionbien,charindex(', hasta por $', cast(descripcionbien as varchar(max))),100)"
            sql &= "   else ''"
            sql &= " end as SumaAsegurada"

            sql &= " from cPolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join cPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            'sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBien"

            Dim dtBienes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBienes.TableName = "Bienes"

            ''Los beneficiarios 
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdBeneficiario"
            sql &= " ,p.NombreBeneficiario"
            sql &= " ,pa.Descripcion"
            sql &= " ,p.FechaNacimiento"
            sql &= " ,p.Porcentaje"
            sql &= " ,pa.Descripcion as Parentesco"
            sql &= " from cPolizasBeneficiarios as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join cPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " left join Parentescos as pa on pa.IdParentesco = p.Parentesco"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            'sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdBeneficiario"

            Dim dtBenef As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtBenef.TableName = "Beneficiarios"

            ''Las cesiones
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.IdCertificado"
            sql &= " ,p.IdCesion"
            sql &= " ,p.Beneficiario"
            sql &= " ,p.FechaVigente"
            sql &= " ,p.FechaCancela"
            sql &= " ,p.SumaCedida"
            sql &= " ,p.Observaciones"
            sql &= " from cPolizasCesiones as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join cPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            'sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
            sql &= " order by p.IdCertificado, p.IdCesion"

            Dim dtCesiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCesiones.TableName = "Cesiones"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(dtCoberturas.Copy)
            DsRep.Tables.Add(dtBienes.Copy)
            DsRep.Tables.Add(dtCesiones.Copy)
            DsRep.Tables.Add(dtBenef.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Reporte.SetDataSource(DsRep)

            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            If FiltroExclusionCertificados <> "" Then
                'en los colectivos ocultaremos algunas secciones de certificados
                Try
                    Reporte.GroupHeaderSection1.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection2.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection3.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection4.SectionFormat.EnableSuppress = True
                    Reporte.GroupHeaderSection5.SectionFormat.EnableSuppress = True
                Catch ex As Exception

                End Try
            End If

            rep.CRViewer.ReportSource = Reporte
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            FolderBrowserDialog1.SelectedPath = clSeguros.ObtenerDBParametros("Ruta.Archivos.Digitales")
            Dim Carpeta As String = ""
            FolderBrowserDialog1.ShowDialog()
            Carpeta = FolderBrowserDialog1.SelectedPath
            If Carpeta <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Carpeta)
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
            sql &= ",(select sum(c.ValorAsegurado) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= ",(select sum(c.PrimaNeta) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as PrimaNeta"
            sql &= ",(select sum(c.GastosEmi + GastosFrac + GastosBomb + GastosOtros) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null) as Gastos"
            sql &= ",(select sum(c.Iva) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Iva"
            sql &= ",(select sum(c.Total) from cPolizasCertificados as c where c.IdPoliza = p.IdPoliza and c.IdProducto = p.IdProducto and c.RazonExclusion is null ) as Total"
            sql &= ", p.FechaCancelacion as FechaCancela"
            sql &= ", p.MotivoCancelacion as MotivoCancela"
            sql &= ",cl.EjecutivoCta as Ejecutivo"
            sql &= " from CPolizas as p"
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
            sql &= " from CPolizasCertificados as c"
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
            sql &= " from CPolizasCoberturas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join ProductosCoberturas as c on c.IdProducto = p.IdProducto and c.IdCobertura = p.IdCobertura"
            sql &= " inner join CPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and (ce.RazonExclusion is null or ce.RazonExclusion = '') "
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
            sql &= " from CPolizasBienes as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " inner join CPolizasCertificados as ce on p.idproducto = ce.idproducto and p.idpoliza = ce.idpoliza and p.idcertificado = ce.idcertificado"
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

    'Private Sub IncluirDocumentosAutomaticos()
    '    'rutina que incluye los documentos automaticos de una ruta.
    '    Dim RutaBase As String = clSeguros.ObtenerDBParametros("Ruta.Documentos.Poliza")
    '    Dim existe As Boolean
    '    If txtIdPoliza.Text <> "" And RutaBase <> "" Then
    '        Dim Archivos As DataTable = ObtenerArchivosCarpeta(RutaBase & "\" & txtIdPoliza.Text)
    '        Dim FilArchivo As DataRow
    '        For Each FilArchivo In Archivos.Rows
    '            'verificamos si ya existe
    '            existe = False
    '            For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
    '                If Trim(UCase(VistaDoc.GetRowCellValue(NA, "Documento"))) = Trim(UCase(dbData(FilArchivo, "Archivo"))) Then
    '                    existe = True
    '                End If
    '            Next
    '            If existe = False Then
    '                Dim Id As Integer = clSeguros.ObtenerIDDoc()
    '                Me.AgregarFilaGrid(VistaDoc, True)
    '                Dim Fila As Integer = VistaDoc.FocusedRowHandle
    '                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
    '                Me.VistaDoc.SetRowCellValue(Fila, "Documento", dbData(FilArchivo, "Archivo"))
    '                Me.VistaDoc.UpdateCurrentRow()
    '            End If
    '        Next
    '    End If
    'End Sub

    Private Sub CompletarNombreArchivos()
        Dim dtDoc As DataTable
        Try
            dtDoc = GridDoc.DataSource
            dtDoc.Columns.Add("Archivo", System.Type.GetType("System.String"))
            GridDoc.DataSource = dtDoc
        Catch ex As Exception

        End Try

        For NA As Integer = 0 To Me.VistaDoc.DataRowCount - 1
            Try
                Me.VistaDoc.SetRowCellValue(NA, "Archivo", System.IO.Path.GetFileName(VistaDoc.GetRowCellValue(NA, "Documento")))
            Catch ex As Exception

            End Try
        Next

    End Sub

    Private Sub btnAceptarOferta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarOferta.Click
        If MsgBox("¿Realmente desea convertir la oferta en póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If

        ''pedimos la póliza
        Dim IdPoliza As String = InputBox("Especifique la póliza a ser creada:", "Número de Póliza")
        If IdPoliza.Trim = "" Then
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If IdPoliza.Length > 25 Then
            MsgBox("El número de la póliza no puede ser mayor a 25 caracteres.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'verificamos que no exista en pólizas
        Dim existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from polizas where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0).Item(0)
        If existe > 0 Then
            MsgBox("El número de póliza que ha especificado ya existe en el sistema.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim sql As String = ""
        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")
            'trasladamos la póliza

            'registraremos la póliza
            sql = "  insert into Polizas (IdPoliza, IdProducto, IdCliente, NombreCliente, VigenciaDesde, VigenciaHasta, EstadoPoliza, MotivoCancelacion, FechaCancelacion, PorceComision, NumVigencia, FechaVinculacion, TipoDeducible, IdOferta)"
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCliente, NombreCliente, VigenciaDesde, VigenciaHasta, EstadoPoliza, MotivoCancelacion, FechaCancelacion, PorceComision, NumVigencia, FechaVinculacion, TipoDeducible, IdPoliza"
            sql &= " from cPolizas "
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            sql = "  insert into PolizasClausulas ( IdPoliza, IdProducto, IdClausula, Clausula)"
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdClausula, Clausula "
            sql &= " from cPolizasClausulas"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            sql = "  insert into PolizasDocumentos ( IdPoliza, IdProducto, IdDocumento, Documento) "
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdDocumento, Documento "
            sql &= " from cPolizasDocumentos"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            'si la oferta tiene un vendedor lo pasamos a la nueva estructura de varios vendedores
            Dim FilCot As DataRow = StiGlobalConn.ObtenerDataset("Select a.IdVendedor, a.VigenciaDesde, b.IdTipoVendedor from cPolizas as a left join Vendedores as b on a.IdVendedor = b.IdVendedor where a.idpoliza = " & dbStr(txtIdPoliza.Valor) & " and a.idproducto = " & dbStr(Me.cboIdProducto.Valor)).Tables(0).Rows(0)
            If dbData(FilCot, "IdVendedor") <> "" Then
                sql = " insert into PolizasVendedores (IdPoliza, IdProducto, Orden, IdVendedor, IdTipoVendedor, FechaEfectiva) values("
                sql &= dbStr(IdPoliza, 25) & ", " & dbStr(cboIdProducto.Valor) & ", 1, " & dbStr(dbData(FilCot, "IdVendedor")) & ", " & dbStr(dbData(FilCot, "IdTipoVendedor")) & ", " & dbFec(dbData(FilCot, "VigenciaDesde")) & ")"
                StiGlobalConn.SQLExecute(sql)
            End If

            'ahora el certificado

            sql = "  insert into PolizasCertificados ( IdPoliza, IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, IdVendedor, UsuarioModifica, FechaModifica, Deducible, Participacion, PorceDescuento, ValorDescuento, PrimaBruta,IdPlan) "
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCertificado, IdCliente, NombreCliente, FechaInclusion, VigenciaDesde, VigenciaHasta, ValorAsegurado, PrimaNeta, GastosEmi, GastosFrac, GastosBomb, GastosOtros, Iva, Total, EstadoCertificado, FechaExclusion, RazonExclusion, IdVendedor, UsuarioModifica, FechaModifica, Deducible, Participacion, PorceDescuento, ValorDescuento, PrimaBruta, IdPlan "
            sql &= " from cPolizasCertificados"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            sql = "  insert into PolizasBeneficiarios ( IdPoliza, IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje) "
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCertificado, IdBeneficiario, NombreBeneficiario, Parentesco, FechaNacimiento, Porcentaje "
            sql &= " from cPolizasBeneficiarios"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            sql = "  insert into PolizasBienes ( IdPoliza, IdProducto, IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima)"
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCertificado, IdBien, NombreBien, DescripcionBien, SumaAsegurada, Prima"
            sql &= " from cPolizasBienes"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            sql = "  insert into PolizasCesiones ( IdPoliza, IdProducto, IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones)"
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCertificado, IdCesion, Beneficiario, FechaVigente, FechaCancela, SumaCedida, Observaciones"
            sql &= " from cPolizasCesiones"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)

            sql = "  insert into PolizasCoberturas ( IdPoliza, IdProducto, IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma) "
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCertificado, IdCobertura, SumaAsegurada, Tasa, Deducible, Prima, PorceSuma"
            sql &= " from cPolizasCoberturas"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)


            sql = "  insert into PolizasCoberturasAdicional ( IdPoliza, IdProducto, IdCertificado, IdCobertura, Descripcion) "
            sql &= " select " & dbStr(IdPoliza, 25) & ", IdProducto, IdCertificado, IdCobertura, Descripcion"
            sql &= " from cPolizasCoberturasAdicional"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor)
            StiGlobalConn.SQLExecute(Sql)


            ''ahora realzamos unos cambios en la oferta

            StiGlobalConn.SQLExecute("update cpolizas set estadopoliza = 'ESPOLIZA', FechaCambioEstado = " & dbFec(Date.Now, "1") & " where idproducto = " & dbStr(Me.cboIdProducto.Valor) & " and idpoliza = " & dbStr(Me.txtIdPoliza.Valor))
            Me.cboEstadoPoliza.Valor = "ESPOLIZA"

            StiGlobalConn.SQLExecute("update cpolizas set FechaAceptada = " & dbFec(Date.Today) & " where idproducto = " & dbStr(Me.cboIdProducto.Valor) & " and idpoliza = " & dbStr(Me.txtIdPoliza.Valor) & " and FechaAceptada is null")


            ''ahora unos cambios en la póliza
            StiGlobalConn.SQLExecute("update polizas set estadopoliza = 'VIGENTE' where idproducto = " & dbStr(Me.cboIdProducto.Valor) & " and idpoliza = " & dbStr(IdPoliza))

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("La Póliza ha sido creada.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try
    End Sub

    Private Sub cboEstadoPoliza_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboEstadoPoliza.ValueChangeOnExit
        Me.txtFechaCambioEstado.Valor = Date.Now

        txtMotivoCancelacion.Obligatorio = False
        txtFechaCancelacion.Obligatorio = False
        txtFechaAceptada.Obligatorio = False

        Select Case cboEstadoPoliza.Valor
            Case "RECHAZADA"
                txtMotivoCancelacion.Obligatorio = True
                txtFechaCancelacion.Obligatorio = True

            Case "ACEPTADA", "ESPOLIZA"
                txtFechaAceptada.Obligatorio = True

        End Select
    End Sub

    Private Sub btnAgregarGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGestion.Click
        Try
            Dim Id As Integer = clSeguros.ObtenerID("Gestion.Id")
            Me.AgregarFilaGrid(VistaGestiones)
            Dim Fila As Integer = VistaGestiones.FocusedRowHandle
            Me.VistaGestiones.SetRowCellValue(Fila, "IdGestion", Id)
            Me.VistaGestiones.SetRowCellValue(Fila, "TipoGestion", "P")
            Me.VistaGestiones.SetRowCellValue(Fila, "FechaGestion", Date.Today)
            Me.VistaGestiones.SetRowCellValue(Fila, "IdUsuario", StiGlobalConn.User)

            Me.VistaGestiones.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGestion.Click
        Try
            Me.EliminarFilaGrid(VistaGestiones)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
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

                    'buscaremos nombre, telefono del cliente 
                    Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                    Dim Aseguradora As String = "", TelAse As String = "", ReclamoAseg As String = "", Poliza As String = "", Reclamo As String = "", FechaOcurrido As String = "", FechaPresentado As String = ""
                    Try
                        sql = "  select "
                        sql &= " (select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                        sql &= " ,c.EMail"
                        sql &= " ,a.Nombre as Aseguradora"
                        sql &= " ,a.Telefono as TelefonoAseg, cp.IdPoliza "
                        sql &= " from cPolizas as cp"
                        sql &= " inner join Productos as p on p.idproducto = cp.idproducto"
                        sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                        sql &= " left join Clientes as c on c.idcliente = cp.idcliente"
                        sql &= " where cp.idproducto = " & dbStr(Me.cboIdProducto.Valor) & " and cp.IdPoliza = " & dbStr(txtIdPoliza.Valor)
                        Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)

                        Cliente = txtNombreCliente.Valor
                        Telefono = dbData(fila, "Telefono")
                        Correo = dbData(fila, "EMail")
                        Aseguradora = dbData(fila, "Aseguradora")
                        TelAse = dbData(fila, "TelefonoAseg")
                        Poliza = dbData(fila, "IdPoliza")
                    Catch ex As Exception

                    End Try

                    Dim res As String = AgregarCitaOutlook("Gestión - Oferta ", "", VistaGestiones.GetRowCellValue(FilaGes, "Comentarios") & vbCrLf _
                                                           & "Aseguradora: " & TelAse & " / " & Aseguradora & vbCrLf _
                                                           & "#Oferta: " & Poliza & vbCrLf _
                                                           & "Cliente :" & Cliente & vbCrLf & Telefono & vbCrLf _
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

End Class
