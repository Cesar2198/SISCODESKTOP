
Imports Utilerias.Genericas

Public Class BusquedaPolizas

    Public dbFiltro As String = ""
    Public IdClienteDefault As String = ""


#Region "Ajustar Cambos de Filtro"

    Private Sub Busqueda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PosisionarControles()
    End Sub

    Private Sub Vista_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles VistaPolizas.ColumnWidthChanged
        Call PosisionarControles()
    End Sub

    Private Sub Grid_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPolizas.SizeChanged
        Call PosisionarControles()
    End Sub

    Private Sub PosisionarControles()
        Try
            'tenemos que cambiar todas las posiciones
            Me.GridPolizas.Refresh()
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaPolizas.VisibleColumns
                Try
                    Me.Controls("txt" & Col.FieldName).Width = Col.VisibleWidth - 2
                    Me.Controls("txt" & Col.FieldName).Left = getColumnLeft(Col.VisibleIndex) + 1
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function getColumnLeft(ByVal Index As Integer) As Integer
        Dim Left As Double = 0
        For NC As Integer = 0 To Me.VistaPolizas.Columns.Count - 1
            If VistaPolizas.Columns(NC).VisibleIndex < Index And VistaPolizas.Columns(NC).VisibleIndex >= 0 Then
                Left += VistaPolizas.Columns(NC).VisibleWidth
            End If
        Next
        Return Me.GridPolizas.Left + 17 + Left
    End Function

#End Region

#Region "Ajustes para recardar vistas"

    Public Sub AlmacenarVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Or TypeOf ControlL1 Is DevExpress.XtraGrid.GridControl Then
                    Dim VistaAlmacenada As String = ObtenerVista(ControlL1.Views(0))
                    If VistaAlmacenada <> "" Then
                        Dim Existe As Integer = StiGlobalConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                        If Existe > 0 Then
                            StiGlobalConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(VistaAlmacenada) & " where IdUsuario = " & dbStr(StiGlobalConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name))
                        Else
                            StiGlobalConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(StiGlobalConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name) & C & dbStr(VistaAlmacenada) & ")")
                        End If
                        Dim RecordarFiltro As String = ""
                        Try
                            RecordarFiltro = StiGlobalConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Filtros'").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception

                        End Try

                        If RecordarFiltro.Trim.ToUpper = "S" Then
                            'guaradmos el filtro
                            Existe = StiGlobalConn.ObtenerDataset("select count(*) from VistasUsuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro")).Tables(0).Rows(0).Item(0)
                            If Existe > 0 Then
                                StiGlobalConn.SQLExecute("update VistasUsuarios set ModeloVista = " & dbStr(ControlL1.Views(0).ActiveFilterString) & " where IdUsuario = " & dbStr(StiGlobalConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro"))
                            Else
                                StiGlobalConn.SQLExecute("insert into VistasUsuarios (IdUsuario, IdVista, ModeloVista) values(" & dbStr(StiGlobalConn.User) & C & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro") & C & dbStr(ControlL1.Views(0).ActiveFilterString) & ")")
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
            If ControlL1.Controls.Count > 0 Then
                AlmacenarVistas(ControlL1)
            End If
        Next
    End Sub

    Public Function ObtenerVista(ByRef Vista As DevExpress.XtraGrid.Views.Grid.GridView) As String
        Dim res As String = ""
        Try
            For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.VisibleColumns
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                End If
            Next

            'las agrupadas
            For Each ColVista As DevExpress.XtraGrid.Columns.GridColumn In Vista.GroupedColumns
                If res = "" Then
                    res = ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                Else
                    res &= "," & ColVista.FieldName & "|" & ColVista.Width & "|" & ObtenetOrdenGrid(ColVista.SortOrder) & "|" & ColVista.GroupIndex
                End If
            Next
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Public Function ObtenetOrdenGrid(ByVal Orden As DevExpress.Data.ColumnSortOrder) As String
        Dim res As String = ""
        Select Case Orden
            Case DevExpress.Data.ColumnSortOrder.None
                res = ""
            Case DevExpress.Data.ColumnSortOrder.Ascending
                res = "A"
            Case DevExpress.Data.ColumnSortOrder.Descending
                res = "D"
        End Select
        Return res
    End Function

    Public Sub PrepararVistas(ByRef ControlL As System.Windows.Forms.Control)
        For Each ControlL1 As Object In ControlL.Controls
            Try
                If TypeOf ControlL1 Is STIControles.stiGrid Or TypeOf ControlL1 Is DevExpress.XtraGrid.GridControl Then
                    Dim VistaAlmacenada As String = "", FiltroAlmacenado As String = ""
                    Try
                        VistaAlmacenada = StiGlobalConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        VistaAlmacenada = ""
                    End Try
                    Dim RecordarFiltro As String = ""
                    Try
                        RecordarFiltro = StiGlobalConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Filtros'").Tables(0).Rows(0).Item(0)
                    Catch ex As Exception

                    End Try

                    If RecordarFiltro.Trim.ToUpper = "S" Then
                        Try
                            FiltroAlmacenado = StiGlobalConn.ObtenerDataset("select ModeloVista from VistasUsuarios where IdUsuario = " & dbStr(StiGlobalConn.User) & " and IdVista = " & dbStr(Me.Name & "." & ControlL1.Name & ".Filtro")).Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            FiltroAlmacenado = ""
                        End Try
                    End If
                    If VistaAlmacenada <> "" Then
                        Call PrepararGrid(ControlL1.Views(0), VistaAlmacenada, FiltroAlmacenado)
                    End If
                End If
            Catch ex As Exception

            End Try
            If ControlL1.Controls.Count > 0 Then
                PrepararVistas(ControlL1)
            End If
        Next
    End Sub

    Public Sub PrepararGrid(ByRef Vista As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Columnas As String, ByVal FiltroVista As String)
        'lo que se hará es mostrar las columna solicitadas y en el orden solicitado
        Try
            'primero las ocultamos
            If Columnas.Trim.Length = 0 Then Exit Sub
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In Vista.Columns
                If InStr(Columnas, Col.FieldName) > 0 Then
                    Col.Visible = True
                Else
                    Col.Visible = False
                End If
            Next
            'ahora las ordenamos
            Vista.BeginSort()
            Vista.ClearGrouping()
            Dim NumCampos As Integer = CuentaCar(Columnas, ",")
            Dim busColumna As String = "", AnchoCol As Double = 0, OrdenCol As DevExpress.Data.ColumnSortOrder = DevExpress.Data.ColumnSortOrder.None, GroupIndexCol As Integer = 0
            For I As Integer = 0 To NumCampos
                busColumna = stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G0|1").Trim
                AnchoCol = Val(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G1|1").Trim)
                OrdenCol = ObtenerColumnSortOrder(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G2|1").Trim)
                GroupIndexCol = CInt(stiSplit(stiSplit(Columnas, "G" & I & ",1").Trim, "G3|1").Trim)

                Try
                    Vista.Columns(busColumna).VisibleIndex = I
                    Vista.Columns(busColumna).Width = AnchoCol
                    Vista.Columns(busColumna).SortOrder = OrdenCol
                    If GroupIndexCol >= 0 Then
                        Vista.Columns(busColumna).GroupIndex = GroupIndexCol
                    End If

                Catch ex As Exception

                End Try
            Next
            Vista.EndSort()
            Vista.ActiveFilterString = FiltroVista
            'autoajustamos las columans
            'Vista.BestFitColumns()
        Catch ex As Exception

        End Try
    End Sub

    Public Function ObtenerColumnSortOrder(ByVal Orden As String) As DevExpress.Data.ColumnSortOrder
        Dim res As DevExpress.Data.ColumnSortOrder
        Select Case Orden.Trim.ToUpper
            Case "A"
                res = DevExpress.Data.ColumnSortOrder.Ascending
            Case "D"
                res = DevExpress.Data.ColumnSortOrder.Descending
            Case Else
                res = DevExpress.Data.ColumnSortOrder.None
        End Select
        Return res
    End Function


#End Region

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        busCodigo = ""
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FilFactura As Integer = Me.VistaPolizas.FocusedRowHandle
        busCodigo = ""
        If FilFactura >= 0 Then
            busCodigo = VistaPolizas.GetRowCellValue(FilFactura, "Poliza") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Producto")
            Me.Close()
        Else
            MsgBox("Debe seleccionar una Póliza.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Function ObtenerPolizas(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtIdCliente.Text <> "" Or txtNombre.Text <> "" Or txtEstado.Text <> "" Or txtPoliza.Text <> "" Or txtProducto.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select p.IdCliente, p.NombreCliente as Nombre, p.EstadoPoliza as Estado, p.IdPoliza as Poliza, p.IdProducto as Producto, p.VigenciaDesde, p.VigenciaHasta"
                sql &= " , (select top 1 r.NombreRamo from RamoSeguros as r inner join Productos as pr on pr.idramo = r.idramo where pr.idproducto =p.idproducto ) as Ramo"
                sql &= " , (select top 1 a.Nombre from Aseguradoras as a inner join productos as pr on pr.idaseguradora = a.idaseguradora where pr.idproducto = p.idproducto) as Aseguradora"
                sql &= " from Polizas as p"
                sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
                sql &= " where p.IdPoliza is not null "

                If dbFiltro <> "" Then
                    sql &= dbFiltro
                End If

                If txtIdCliente.Text.Trim <> "" Then
                    sql &= " and p.IdCliente like " & dbStr("%" & txtIdCliente.Text.Trim & "%")
                End If

                If txtNombre.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtNombre.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtNombre.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (p.NombreCliente like " & dbStr("%" & Palabra & "%") & " or cl.conocidopor like " & dbStr("%" & Palabra & "%") & ") "
                        End If
                    Next
                End If

                If txtEstado.Text.Trim <> "" Then
                    sql &= " and p.EstadoPoliza like " & dbStr("%" & txtEstado.Text.Trim & "%")
                End If

                If txtPoliza.Text.Trim <> "" Then
                    sql &= " and p.IdPoliza like " & dbStr("%" & txtPoliza.Text.Trim & "%")
                End If

                If txtProducto.Text.Trim <> "" Then
                    sql &= " and p.IdProducto like " & dbStr("%" & txtProducto.Text.Trim & "%")
                End If

                If VisibilidadUsuario() = "D" Then
                    sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                End If

                Dim dtPolizas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridPolizas.DataSource = dtPolizas
                GridPolizas.Refresh()
                If dtPolizas.Rows.Count = 0 Then
                    If MostrarMensaje = True Then
                        Me.lblStatus.Text = "No se encontraron Pólizas"
                    End If
                Else
                    Me.lblStatus.Text = ""
                    Me.VistaPolizas.Focus()
                End If
                res = dtPolizas.Rows.Count
            Catch ex As Exception
                msgError(ex)
            End Try
        End If
        Return res

    End Function

    Private Sub txtIdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCliente.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                txtEstado.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub BusquedaPolizas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim RecordarVista As String = StiGlobalConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
            If RecordarVista.Trim.ToUpper = "S" Then
                AlmacenarVistas(Me)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BusquedaPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IdClienteDefault <> "" Then
            Me.txtIdCliente.EditValue = IdClienteDefault
            Me.txtIdCliente.Properties.ReadOnly = True
        End If
        Call ObtenerPolizas(False)
        Try
            Dim RecordarVista As String = StiGlobalConn.ObtenerDataset("select Cadena from Parametros where IdParametro = 'Recordar.Vistas'").Tables(0).Rows(0).Item(0)
            If RecordarVista.Trim.ToUpper = "S" Then
                PrepararVistas(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPoliza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPoliza.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtProducto.Focus()
            End If
        End If
    End Sub

    Private Sub txtPoliza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoliza.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtIdCliente.Focus()
            End If
        End If
    End Sub

    Private Sub txtProducto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProducto.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEstado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.VistaPolizas.Focus()
            End If
        End If
    End Sub

    Private Sub txtEstado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEstado.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub VistaPolizas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPolizas.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Sub VistaPolizas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaPolizas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If
    End Sub

End Class