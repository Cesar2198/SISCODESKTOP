Imports Utilerias.Genericas

Public Class BusquedaFacturasMovimientos

    Public dbFiltro As String = ""



#Region "Ajustar Cambos de Filtro"

    Private Sub Busqueda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PosisionarControles()
    End Sub

    Private Sub Vista_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles VistaFacturas.ColumnWidthChanged
        Call PosisionarControles()
    End Sub

    Private Sub Grid_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridFacturas.SizeChanged
        Call PosisionarControles()
    End Sub

    Private Sub PosisionarControles()
        Try
            'tenemos que cambiar todas las posiciones
            Me.GridFacturas.Refresh()
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaFacturas.VisibleColumns
                Me.Controls("txt" & Col.FieldName).Width = Col.VisibleWidth - 2
                Me.Controls("txt" & Col.FieldName).Left = getColumnLeft(Col.VisibleIndex) + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function getColumnLeft(ByVal Index As Integer) As Integer
        Dim Left As Double = 0
        For NC As Integer = 0 To Me.VistaFacturas.Columns.Count - 1
            If VistaFacturas.Columns(NC).VisibleIndex < Index And VistaFacturas.Columns(NC).VisibleIndex >= 0 Then
                Left += VistaFacturas.Columns(NC).VisibleWidth
            End If
        Next
        Return Me.GridFacturas.Left + 17 + Left
    End Function

#End Region


    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        busCodigo = ""
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FilFactura As Integer = Me.VistaFacturas.FocusedRowHandle
        busCodigo = ""
        If FilFactura >= 0 Then
            busCodigo = VistaFacturas.GetRowCellValue(FilFactura, "Factura") & "|" & VistaFacturas.GetRowCellValue(FilFactura, "Producto") & "|" & VistaFacturas.GetRowCellValue(FilFactura, "Poliza") & "|" & VistaFacturas.GetRowCellValue(FilFactura, "IdRamo") & "|" & VistaFacturas.GetRowCellValue(FilFactura, "IdMovimiento")
            Me.Close()
        Else
            MsgBox("Debe seleccionar una factura", MsgBoxStyle.Information, "AVISO...")
        End If

    End Sub

    Private Sub GridFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridFacturas.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Function ObtenerFacturas(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtIdCliente.Text <> "" Or txtNombre.Text <> "" Or txtFactura.Text <> "" Or txtPoliza.Text <> "" Or txtProducto.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select f.IdCliente, f.NombreCliente as Nombre, f.NumeroFactura as Factura, f.IdPoliza as Poliza, f.IdProducto as Producto, f.IdRamo, m.IdMovimiento, m.FechaMovimiento as Fecha, m.TipoMovimiento as TipoMov, m.Total as Valor"
                sql &= " from Facturas as f"
                sql &= " inner join FacturasMovimientos as m on f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo"
                sql &= " left join Clientes as cl on cl.idcliente = f.idcliente"
                sql &= " where f.numerofactura is not null "

                If dbFiltro <> "" Then
                    sql &= dbFiltro
                End If

                If txtIdCliente.Text.Trim <> "" Then
                    sql &= " and f.IdCliente like " & dbStr("%" & txtIdCliente.Text.Trim & "%")
                End If
                If txtNombre.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtNombre.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtNombre.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (f.NombreCliente like " & dbStr("%" & Palabra & "%") & " or cl.conocidopor like " & dbStr("%" & Palabra & "%") & ") "
                        End If
                    Next
                End If

                If txtFactura.Text.Trim <> "" Then
                    sql &= " and f.NumeroFactura =" & dbInt(txtFactura.Text.Trim)
                End If
                If txtPoliza.Text.Trim <> "" Then
                    sql &= " and f.IdPoliza = " & dbStr(txtPoliza.Text.Trim)
                End If
                If txtProducto.Text.Trim <> "" Then
                    sql &= " and f.IdProducto =" & dbStr(txtProducto.Text.Trim)
                End If
                If txtFecha.Text <> "" Then
                    sql &= " and m.FechaMovimiento = " & dbFec(txtFecha.Text)
                End If
                If txtTipoMov.Text <> "" Then
                    sql &= " and m.TipoMovimiento like " & dbStr("%" & txtTipoMov.Text & "%")
                End If
                If txtValor.Text <> "" Then
                    sql &= " and m.Total = " & dbNum(txtValor.Text)
                End If

                If VisibilidadUsuario() = "D" Then
                    sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                End If

                Dim dtFacturas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridFacturas.DataSource = dtFacturas
                GridFacturas.Refresh()
                If dtFacturas.Rows.Count = 0 Then
                    If MostrarMensaje = True Then
                        Me.lblStatus.Text = "No se encontraron Facturas/Movimientos"
                    End If
                Else
                    Me.lblStatus.Text = ""
                    Me.VistaFacturas.Focus()
                End If
                res = dtFacturas.Rows.Count
            Catch ex As Exception
                msgError(ex)
            End Try
        End If
        Return res
    End Function

    Private Sub txtIdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                Me.txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCliente.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                txtFactura.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub txtFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                txtPoliza.Focus()
            End If
        End If
    End Sub

    Private Sub txtFactura_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFactura.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub txtPoliza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPoliza.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                Me.txtProducto.Focus()
            End If
        End If
    End Sub

    Private Sub txtPoliza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoliza.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub txtProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                Me.txtFecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtProducto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProducto.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub BusquedaFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ObtenerFacturas(False)
    End Sub

    Private Sub VistaFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaFacturas.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Sub VistaFacturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaFacturas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                Me.txtTipoMov.Focus()
            End If
        End If
    End Sub

    Private Sub txtFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub txtTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMov.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                Me.txtValor.Focus()
            End If
        End If
    End Sub

    Private Sub txtTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMov.LostFocus
        Call ObtenerFacturas()
    End Sub

    Private Sub txtValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerFacturas() = 0 Then
                Me.VistaFacturas.Focus()
            End If
        End If
    End Sub

    Private Sub txtValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.LostFocus
        Call ObtenerFacturas()
    End Sub

End Class