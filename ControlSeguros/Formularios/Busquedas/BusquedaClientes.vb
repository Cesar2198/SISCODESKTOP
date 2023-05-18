Imports Utilerias.Genericas

Public Class BusquedaClientes

    Public IdClienteDefault As String = ""

#Region "Ajustar Cambos de Filtro"

    Private Sub Busqueda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PosisionarControles()
    End Sub

    Private Sub Vista_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles VistaClientes.ColumnWidthChanged
        Call PosisionarControles()
    End Sub

    Private Sub Grid_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridClientes.SizeChanged
        Call PosisionarControles()
    End Sub

    Private Sub PosisionarControles()
        Try
            'tenemos que cambiar todas las posiciones
            Me.GridClientes.Refresh()
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaClientes.VisibleColumns
                Me.Controls("txt" & Col.FieldName).Width = Col.VisibleWidth - 2
                Me.Controls("txt" & Col.FieldName).Left = getColumnLeft(Col.VisibleIndex) + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function getColumnLeft(ByVal Index As Integer) As Integer
        Dim Left As Double = 0
        For NC As Integer = 0 To Me.VistaClientes.Columns.Count - 1
            If VistaClientes.Columns(NC).VisibleIndex < Index And VistaClientes.Columns(NC).VisibleIndex >= 0 Then
                Left += VistaClientes.Columns(NC).VisibleWidth
            End If
        Next
        Return Me.GridClientes.Left + 17 + Left
    End Function

#End Region



    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        busCodigo = ""
        Me.Close()
    End Sub

    Private Function ObtenerClientes() As Integer
        Dim res As Integer = 0
        If txtIdCliente.Text <> "" Or txtNombre.Text <> "" Or txtDUI.Text <> "" Or txtDUI.Text <> "" Or txtRegistro.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select IdCliente,NombreCliente as Nombre, DUI,NIT, RegistroFiscal as Registro "
                sql &= " from Clientes "
                sql &= " where idcliente is not null "
                If txtIdCliente.Text.Trim <> "" Then
                    sql &= " and IdCliente like " & dbStr("%" & txtIdCliente.Text.Trim & "%")
                End If
                If txtNombre.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtNombre.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtNombre.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (NombreCliente like " & dbStr("%" & Palabra & "%") & " or conocidopor like " & dbStr("%" & Palabra & "%") & " )"
                        End If
                    Next
                End If
                If txtDUI.Text.Trim <> "" Then
                    sql &= " and Dui like " & dbStr("%" & txtDUI.Text.Trim & "%")
                End If
                If txtNIT.Text.Trim <> "" Then
                    sql &= " and Nit like " & dbStr("%" & txtNIT.Text.Trim & "%")
                End If
                If txtRegistro.Text.Trim <> "" Then
                    sql &= " and RegistroFiscal like " & dbStr("%" & txtRegistro.Text.Trim & "%")
                End If
                Dim dtClientes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridClientes.DataSource = dtClientes
                GridClientes.Refresh()
                If dtClientes.Rows.Count = 0 Then
                    Me.lblStatus.Text = "No se encontraron Clientes"
                Else
                    Me.lblStatus.Text = ""
                    Me.VistaClientes.Focus()
                End If
                res = dtClientes.Rows.Count
            Catch ex As Exception

            End Try
        End If
        Return res
    End Function

    Private Sub txtIdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerClientes() = 0 Then
                Me.txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCliente.LostFocus
        Call ObtenerClientes()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerClientes() = 0 Then
                Me.txtDUI.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Call ObtenerClientes()
    End Sub

    Private Sub txtNit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerClientes() = 0 Then
                Me.txtRegistro.Focus()
            End If
        End If
    End Sub

    Private Sub txtNit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNIT.LostFocus
        Call ObtenerClientes()
    End Sub

    Private Sub txtDui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDUI.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerClientes() = 0 Then
                Me.txtNIT.Focus()
            End If
        End If
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDUI.LostFocus
        Call ObtenerClientes()
    End Sub

    Private Sub txtRegistroFical_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRegistro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerClientes() = 0 Then
                Me.VistaClientes.Focus()
            End If
        End If
    End Sub

    Private Sub txtRegistroFical_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegistro.LostFocus
        Call ObtenerClientes()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FilCliente As Integer = Me.VistaClientes.FocusedRowHandle
        If FilCliente >= 0 Then
            busCodigo = Me.VistaClientes.GetRowCellValue(FilCliente, "IdCliente")
            Me.Close()
        Else
            MsgBox("Debe seleccionar un cliente.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub GridClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridClientes.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Sub bntNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntNuevo.Click
        Try
            Dim frmCli As New ClientesMan
            frmCli.STIConn = StiGlobalConn
            frmCli.dbTabla = "Clientes"
            frmCli.Permiso = ObtenerPermiso(StiGlobalConn.User, "btnClientes")
            frmCli.ShowDialog(Me)
        Catch ex As Exception
            MsgBox("Error al crear nuevo cliente." & ex.Message)
        End Try
    End Sub

    Private Sub VistaClientes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaClientes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub BusquedaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IdClienteDefault <> "" Then
            txtIdCliente.EditValue = IdClienteDefault
            txtIdCliente.Properties.ReadOnly = True
        End If
    End Sub

End Class