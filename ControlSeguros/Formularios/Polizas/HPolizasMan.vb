
imports Utilerias.Genericas

Public Class HPolizasMan

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

    Private Sub HPolizasMan_AntesDeGuardar(ByRef Cancel As Boolean) Handles Me.AntesDeGuardar
        If Me.txtNumVigencia.Valor <= 0 Then
            MsgBox("El número de vigencia no es válido, debe ser mayor o igual a uno.", MsgBoxStyle.Information, "AVISO...")
            Cancel = True
        End If
    End Sub

    Private Sub HPolizasMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VistaDoc.OptionsBehavior.Editable = False
        Me.cboDepartamento.OcultarColumna(1)
        Select Case Me.EstadoRegistro
            Case enEstadoRegistro.Adicionando
                Me.cboEstadoPoliza.Valor = "VIGENTE"
                Me.txtNumVigencia.Valor = 1
                Me.TabPoliza.Enabled = False

            Case enEstadoRegistro.Modificando
                Call CargarCertificados()
                VistaCertificados.OptionsBehavior.Editable = False

                If cboEstadoPoliza.Valor = "CANCELADA" Then
                    Me.EstadoEntradas(False, Me)
                    Me.VistaDoc.OptionsBehavior.Editable = True
                    Me.btnAgregarCert.Enabled = False
                    Me.btnAgregarClausula.Enabled = False
                    Me.btnQuitarClausula.Enabled = False
                    Me.btnBuscarCliente.Enabled = False
                    MsgBox("La póliza se encuentra cancelada no podrá realizar ningun cambio.", MsgBoxStyle.Information, "AVISO...")
                End If
        End Select

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

        Select Case GlobalCodCliente
            Case "2120000"
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
        Me.cboEstadoPoliza.Valor = "VIGENTE"
        Me.txtNumVigencia.Valor = 1
        Me.txtIdPoliza.Focus()
        Me.TabPoliza.Enabled = False
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
            Dim Documento As String = ""
            OpenFileDialog1.ShowDialog()
            Documento = OpenFileDialog1.FileName
            If Documento <> "" Then
                Dim Id As Integer = ObtenerIDDoc()
                Me.AgregarFilaGrid(VistaDoc)
                Dim Fila As Integer = VistaDoc.FocusedRowHandle
                Me.VistaDoc.SetRowCellValue(Fila, "IdDocumento", Id)
                Me.VistaDoc.SetRowCellValue(Fila, "Documento", Documento)
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
        frmCert.ClavesNuevo = Me.txtIdPoliza.Valor & "|" & Me.cboIdProducto.Valor & "|" & Me.txtIdCliente.Valor & "|" & CDate(Me.txtVigenciaDesde.Valor).ToShortDateString & "|" & CDate(Me.txtVigenciaHasta.Valor).ToShortDateString & "|" & ""
        frmCert.EstadoRegistro = enEstadoRegistro.Adicionando
        frmCert.STIConn = StiGlobalConn
        frmCert.ShowDialog(Me)

        Call CargarCertificados()
    End Sub

    Private Sub CargarCertificados()
        GridCertificados.DataSource = Nothing
        GridCertificados.Refresh()
        Dim sql As String = ""
        Try
            sql = "  select IdCertificado, IdCertificadoAseguradora, NombreCliente, VigenciaDesde, VigenciaHasta, isnull(primaneta,0) as Prima, ValorAsegurado"
            sql &= " , (isnull(GastosEmi,0)+isnull(GastosFrac,0)+isnull(GastosBomb,0)+isnull(GastosOtros,0)) as Gastos, isnull(iva,0) as Iva, isnull(total,0) as Total, isnull(estadocertificado,'') as Estado "
            sql &= " from HPolizasCertificados"
            sql &= " where idpoliza = " & dbStr(txtIdPoliza.Valor) & " and idproducto = " & dbStr(cboIdProducto.Valor) & " and IdHistorico = " & dbInt(txtIdHistorico.Valor)
            Dim Certificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If Certificados.Rows.Count > 0 Then
                GridCertificados.DataSource = Certificados
                GridCertificados.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaCertificados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaCertificados.DoubleClick
        Try
            Dim fila As Integer
            fila = VistaCertificados.FocusedRowHandle
            If fila >= 0 Then
                Dim frmCert As New HPolizasCertificadosMan
                frmCert.dbTabla = "HPolizasCertificados"
                frmCert.STIConn = StiGlobalConn
                frmCert.Permiso = "L"  'toda consulta historica es solo lectura
                frmCert.dbCondicion = "IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and IdCertificado = " & dbStr(Me.VistaCertificados.GetRowCellValue(fila, "IdCertificado")) & " and IdHistorico = " & dbInt(txtIdHistorico.Valor)
                frmCert.ClavesNuevo = Me.txtIdPoliza.Valor & "|" & Me.cboIdProducto.Valor & "|" & Me.txtIdCliente.Valor & "|" & CDate(Me.txtVigenciaDesde.Valor).ToShortDateString & "|" & CDate(Me.txtVigenciaHasta.Valor).ToShortDateString & "|" & ""
                frmCert.ShowDialog(Me)
                Call CargarCertificados()
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Me.TabPoliza.Enabled = True

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

            'incluimos las clausulas
            sql = "  select p.IdPoliza"
            sql &= " ,pr.Descripcion as Producto"
            sql &= " ,p.Clausula as Condicion"
            sql &= " from HPolizasClausulas as p"
            sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " where p.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and p.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and p.idhistorico = " & dbInt(txtIdHistorico.Valor)

            Dim dtClausulas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClausulas.TableName = "Condiciones"

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
            sql &= " from HPolizasCertificados as c"
            sql &= " inner join Productos as pr on pr.idproducto = c.idproducto"
            sql &= " where c.idpoliza = " & dbStr(txtIdPoliza.Valor)
            sql &= " and c.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and c.idhistorico = " & dbInt(txtIdHistorico.Valor)
            ''solo vigentes
            sql &= " and (c.RazonExclusion is null or c.RazonExclusion = '') "
            sql &= " order by c.IdCertificado"

            Dim dtCertificados As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCertificados.TableName = "Certificados"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtPoliza.Copy)
            DsRep.Tables.Add(dtCertificados.Copy)
            DsRep.Tables.Add(dtClausulas.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New RepDetPoliza
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

    Private Sub btnAgregarCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarpeta.Click
        Try
            FolderBrowserDialog1.SelectedPath = ""
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

End Class
