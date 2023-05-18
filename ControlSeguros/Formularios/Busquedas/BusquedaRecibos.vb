Imports Utilerias.Genericas

Public Class BusquedaRecibos

    Public dbFiltro As String = ""

#Region "Ajustar Cambos de Filtro"

    Private Sub BusquedaRecibos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PosisionarControles()
    End Sub

    Private Sub VistaRecibos_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles VistaRecibos.ColumnWidthChanged
        Call PosisionarControles()
    End Sub

    Private Sub GridRecibos_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRecibos.SizeChanged
        Call PosisionarControles()
    End Sub

    Private Sub PosisionarControles()
        Try
            'tenemos que cambiar todas las posiciones
            Me.GridRecibos.Refresh()
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaRecibos.VisibleColumns
                Me.Controls("txt" & Col.FieldName).Width = Col.VisibleWidth - 2
                Me.Controls("txt" & Col.FieldName).Left = getColumnLeft(Col.VisibleIndex) + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function getColumnLeft(ByVal Index As Integer) As Integer
        Dim Left As Double = 0
        For NC As Integer = 0 To Me.VistaRecibos.Columns.Count - 1
            If VistaRecibos.Columns(NC).VisibleIndex < Index And VistaRecibos.Columns(NC).VisibleIndex >= 0 Then
                Left += VistaRecibos.Columns(NC).VisibleWidth
            End If
        Next
        Return Me.GridRecibos.Left + 17 + Left
    End Function

#End Region

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        busCodigo = ""
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FilRecibo As Integer = Me.VistaRecibos.FocusedRowHandle
        busCodigo = ""
        If FilRecibo >= 0 Then
            busCodigo = VistaRecibos.GetRowCellValue(FilRecibo, "Recibo")
            Me.Close()
        Else
            MsgBox("Debe seleccionar un recibo.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub GridRecibos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRecibos.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Function ObtenerRecibos(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtIdCliente.Text <> "" Or txtNombre.Text <> "" Or txtRecibo.Text <> "" Or txtFecha.Text <> "" Or txtTotal.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select r.IdCliente as IdCliente, r.NombreCliente as Nombre, r.IdRecibo as Recibo, r.FechaRecibo as Fecha, r.TotalRecibo as Total"
                sql &= " from Recibos as r"
                sql &= " left join Clientes as cl on cl.idcliente = r.idcliente"
                sql &= " where r.IdRecibo is not null "

                If dbFiltro <> "" Then
                    sql &= dbFiltro
                End If

                If txtIdCliente.Text.Trim <> "" Then
                    sql &= " and r.IdCliente like " & dbStr("%" & txtIdCliente.Text.Trim & "%")
                End If

                If txtNombre.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtNombre.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtNombre.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (r.NombreCliente like " & dbStr("%" & Palabra & "%") & " or cl.conocidopor like " & dbStr("%" & Palabra & "%") & ") "
                        End If
                    Next
                End If

                If txtRecibo.Text.Trim <> "" Then
                    sql &= " and r.IdRecibo = " & dbStr(txtRecibo.Text.Trim)
                End If

                If txtFecha.Text.Trim <> "" Then
                    sql &= " and r.FechaRecibo = " & dbFec(txtFecha.Text.Trim)
                End If

                If txtTotal.Text.Trim <> "" Then
                    sql &= " and r.TotalRecibo = " & dbNum(txtTotal.Text.Trim)
                End If

                Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridRecibos.DataSource = dtRecibos
                GridRecibos.Refresh()
                If dtRecibos.Rows.Count = 0 Then
                    If MostrarMensaje = True Then
                        Me.lblStatus.Text = "No se encontraron Recibos"
                    End If
                Else
                    Me.lblStatus.Text = ""
                    Me.VistaRecibos.Focus()
                End If
                res = dtRecibos.Rows.Count
            Catch ex As Exception
                msgError(ex)
            End Try
        End If
        Return res
    End Function

    Private Sub txtIdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerRecibos() = 0 Then
                txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCliente.LostFocus
        Call ObtenerRecibos()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerRecibos() = 0 Then
                txtRecibo.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Call ObtenerRecibos()
    End Sub

    Private Sub txtRecibo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRecibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerRecibos() = 0 Then
                txtFecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtRecibo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRecibo.LostFocus
        Call ObtenerRecibos()
    End Sub

    Private Sub txtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerRecibos() = 0 Then
                txtTotal.Focus()
            End If
        End If
    End Sub

    Private Sub txtFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFecha.LostFocus
        Call ObtenerRecibos()
    End Sub

    Private Sub txtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerRecibos() = 0 Then
                Me.VistaRecibos.Focus()
            End If
        End If
    End Sub

    Private Sub txtTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.LostFocus
        Call ObtenerRecibos()
    End Sub

    Private Sub BusquedaFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ObtenerRecibos(False)
    End Sub

    Private Sub VistaRecibos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaRecibos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If
    End Sub

End Class