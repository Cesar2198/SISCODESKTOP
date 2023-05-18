Imports Utilerias.Genericas

Public Class BusquedaCondiciones

    Public dbFiltro As String = ""


#Region "Ajustar Cambos de Filtro"

    Private Sub Busqueda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PosisionarControles()
    End Sub

    Private Sub VistaRecibos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaRecibos.Click
        Try
            Dim p As Point = VistaRecibos.GridControl.PointToClient(MousePosition)
            Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = VistaRecibos.CalcHitInfo(p)
            If info.Column.FieldName = "Incluir" Then
                Me.Cursor = Cursors.WaitCursor
                Dim Valor1 As Boolean = VistaRecibos.GetRowCellValue(0, "Incluir")
                Valor1 = Not Valor1
                For NF As Integer = 0 To Me.VistaRecibos.RowCount - 1
                    If NF Mod 25 = 0 Then Application.DoEvents()
                    VistaRecibos.SetRowCellValue(NF, "Incluir", Valor1)
                Next
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Vista_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles VistaRecibos.ColumnWidthChanged
        Call PosisionarControles()
    End Sub

    Private Sub Grid_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRecibos.SizeChanged
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

        For I As Integer = 0 To Me.VistaRecibos.RowCount - 1
            If Me.VistaRecibos.GetRowCellValue(I, "Incluir") = True Then
                If busCodigo = "" Then
                    busCodigo &= dbStr(VistaRecibos.GetRowCellValue(I, "IdCondicion"))
                Else
                    busCodigo &= "," & dbStr(VistaRecibos.GetRowCellValue(I, "IdCondicion"))
                End If
            End If
        Next
        If FilRecibo >= 0 And busCodigo = "" Then
            If busCodigo = "" Then
                busCodigo &= dbStr(VistaRecibos.GetRowCellValue(FilRecibo, "IdCondicion"))
            Else
                busCodigo &= "," & dbStr(VistaRecibos.GetRowCellValue(FilRecibo, "IdCondicion"))
            End If
        End If

        If busCodigo <> "" Then
            Me.Close()
        Else
            MsgBox("Debe seleccionar una Condición Especial.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub GridRecibos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridRecibos.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Function ObtenerCondiciones(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtDescripcion.Text <> "" Or txtIdCondicion.Text <> "" Or txtRamo.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select c.Descripcion, c.IdCondicion, r.NombreRamo as Ramo, cast(0 as bit) as Incluir"
                sql &= " from CondicionesEspeciales as c inner join RamoSeguros as r on c.idramo = r.idramo "
                sql &= " where c.IdCondicion is not null "

                If dbFiltro <> "" Then
                    sql &= dbFiltro
                End If

                If txtIdCondicion.Text.Trim <> "" Then
                    sql &= " and c.IdCondicion like " & dbStr("%" & txtIdCondicion.Text.Trim & "%")
                End If

                If txtDescripcion.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtDescripcion.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtDescripcion.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and c.Descripcion like " & dbStr("%" & Palabra & "%")
                        End If
                    Next
                End If

                If txtRamo.Text.Trim <> "" Then
                    sql &= " and r.NombreRamo like " & dbStr("%" & txtRamo.Text.Trim & "%")
                End If

                Dim dtRecibos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridRecibos.DataSource = dtRecibos
                GridRecibos.Refresh()
                If dtRecibos.Rows.Count = 0 Then
                    If MostrarMensaje = True Then
                        Me.lblStatus.Text = "No se encontraron Condiciones Especiales"
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

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerCondiciones() = 0 Then
                txtIdCondicion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        Call ObtenerCondiciones()
    End Sub

    Private Sub txtIdCondicion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdCondicion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerCondiciones() = 0 Then
                txtRamo.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdCondicion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCondicion.LostFocus
        Call ObtenerCondiciones()
    End Sub

    Private Sub txtRamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRamo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerCondiciones() = 0 Then
                Me.VistaRecibos.Focus()
            End If
        End If
    End Sub

    Private Sub txtRamo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRamo.LostFocus
        Call ObtenerCondiciones()
    End Sub

    Private Sub BusquedaFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ObtenerCondiciones(False)
    End Sub

    Private Sub VistaRecibos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaRecibos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If
    End Sub

End Class