
Imports Utilerias.Genericas

Public Class BusquedaCertificados

    Public dbFiltro As String = ""


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
                Me.Controls("txt" & Col.FieldName).Width = Col.VisibleWidth - 2
                Me.Controls("txt" & Col.FieldName).Left = getColumnLeft(Col.VisibleIndex) + 1
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


    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        busCodigo = ""
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FilFactura As Integer = Me.VistaPolizas.FocusedRowHandle
        busCodigo = ""
        If FilFactura >= 0 Then
            busCodigo = VistaPolizas.GetRowCellValue(FilFactura, "Poliza") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Producto") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Certificado") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Nombre") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Bienes")
            Me.Close()
        Else
            MsgBox("Debe seleccionar una Póliza y Certificado.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Function ObtenerPolizas(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtIdCliente.Text <> "" Or txtNombre.Text <> "" Or txtCertificado.Text <> "" Or txtPoliza.Text <> "" Or txtProducto.Text <> "" Or txtCertificado.Text <> "" Or txtBienes.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select p.IdCliente, p.NombreCliente as Nombre, p.IdPoliza as Poliza, p.IdProducto as Producto"
                sql &= " , c.idcertificado as Certificado, '' as Bienes"
                sql &= " from Polizas as p"
                sql &= " inner join PolizasCertificados as c on p.idpoliza = c.idpoliza and p.idproducto = c.idproducto"
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
                            sql &= " and (p.NombreCliente like " & dbStr("%" & Palabra & "%") & " or cl.conocidopor like " & dbStr("%" & Palabra & "%") & ")"
                        End If
                    Next
                End If

                If txtCertificado.Text.Trim <> "" Then
                    sql &= " and c.idcertificado like " & dbStr("%" & txtCertificado.Text.Trim & "%")
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
                txtCertificado.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub BusquedaCertificados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ObtenerPolizas(False)
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

    Private Sub txtcertificado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCertificado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtBienes.Focus()
            End If
        End If
    End Sub

    Private Sub txtcertificado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCertificado.LostFocus
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

    Private Sub txtBienes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBienes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.VistaPolizas.Focus()
            End If
        End If
    End Sub

    Private Sub txtBienes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBienes.LostFocus
        Call ObtenerPolizas()
    End Sub

End Class