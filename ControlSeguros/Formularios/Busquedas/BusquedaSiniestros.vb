
Imports Utilerias.Genericas

Public Class BusquedaSiniestros

    Public dbFiltro As String = ""
    Public IdClienteDefault As String = ""

    Private Sub BusquedaPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.IdClienteDefault <> "" Then
            Me.txtIdCliente.EditValue = Me.IdClienteDefault
            Me.txtIdCliente.Properties.ReadOnly = True
        End If
        Call ObtenerSiniestros(False)
    End Sub


#Region "Ajustar Cambos de Filtro"

    Private Sub BusquedaSiniestros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PosisionarControles()
    End Sub

    Private Sub VistaSiniestros_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles VistaSiniestros.ColumnWidthChanged
        Call PosisionarControles()
    End Sub

    Private Sub GridSiniestros_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSiniestros.SizeChanged
        Call PosisionarControles()
    End Sub

    Private Sub PosisionarControles()
        Try
            'tenemos que cambiar todas las posiciones
            Me.GridSiniestros.Refresh()
            For Each Col As DevExpress.XtraGrid.Columns.GridColumn In VistaSiniestros.VisibleColumns
                Me.Controls("txt" & Col.FieldName).Width = Col.VisibleWidth - 2
                Me.Controls("txt" & Col.FieldName).Left = getColumnLeft(Col.VisibleIndex) + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Function getColumnLeft(ByVal Index As Integer) As Integer
        Dim Left As Double = 0
        For NC As Integer = 0 To Me.VistaSiniestros.Columns.Count - 1
            If VistaSiniestros.Columns(NC).VisibleIndex < Index And VistaSiniestros.Columns(NC).VisibleIndex >= 0 Then
                Left += VistaSiniestros.Columns(NC).VisibleWidth
            End If
        Next
        Return Me.GridSiniestros.Left + 17 + Left
    End Function

#End Region


    Private Sub VistaPolizas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaSiniestros.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Sub VistaPolizas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaSiniestros.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        busCodigo = ""
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim FilFactura As Integer = Me.VistaSiniestros.FocusedRowHandle
        busCodigo = ""
        If FilFactura >= 0 Then
            busCodigo = VistaSiniestros.GetRowCellValue(FilFactura, "Poliza") & "|" & VistaSiniestros.GetRowCellValue(FilFactura, "Producto") & "|" & VistaSiniestros.GetRowCellValue(FilFactura, "Certificado") & "|" & VistaSiniestros.GetRowCellValue(FilFactura, "Siniestro")
            Me.Close()
        Else
            MsgBox("Debe seleccionar un siniestro.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Function ObtenerSiniestros(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtIdCliente.Text <> "" Or txtNombre.Text <> "" Or txtEstado.Text <> "" Or txtPoliza.Text <> "" Or txtProducto.Text <> "" Or txtSiniestro.Text <> "" Or txtSiniestroAseg.Text <> "" Or txtFechaOcurrido.Text <> "" Or txtAsegurado.Text <> "" Or txtBeneficiario.Text <> "" Then
            Try
                Dim sql As String = ""
                sql = "  select s.idpoliza as Poliza, s.idproducto as Producto, p.IdCliente, p.NombreCliente as Nombre, s.EstadoSiniestro as Estado, s.IdSiniestro as Siniestro, s.FechaOcurrido, s.IdCertificado as Certificado, s.IdSiniestroAseguradora as SiniestroAseg"
                sql &= " ,isnull((select sum(isnull(pa.ValorReembolso,0)) from SiniestrosPagos as pa where pa.idpoliza = s.idpoliza and pa.idproducto = s.idproducto and pa.idsiniestro = s.idsiniestro and pa.idcertificado = s.idcertificado),0) as Pagado"
                sql &= " , c.NombreCliente as Asegurado"
                sql &= " , s.NombrePresentaReclamo as Beneficiario"
                sql &= " from siniestros as s"
                sql &= " left join polizas as p on p.idpoliza = s.idpoliza and s.idproducto = p.idproducto"
                sql &= " left join PolizasCertificados as c on c.idproducto = s.idproducto and c.idpoliza = s.idpoliza and c.idcertificado = s.idcertificado"
                sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
                sql &= " left join Clientes as clc on clc.idcliente = c.idcliente "
                sql &= " where s.IdSiniestro is not null "

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

                If txtAsegurado.Text <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtAsegurado.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtAsegurado.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (c.NombreCliente like " & dbStr("%" & Palabra & "%") & " or clc.conocidopor like " & dbStr("%" & Palabra & "%") & ") "
                        End If
                    Next
                End If

                If txtBeneficiario.Text <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtBeneficiario.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtBeneficiario.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and s.NombrePresentaReclamo like " & dbStr("%" & Palabra & "%")
                        End If
                    Next
                End If


                If txtEstado.Text.Trim <> "" Then
                    sql &= " and s.EstadoSiniestro like " & dbStr("%" & txtEstado.Text.Trim & "%")
                End If

                If txtPoliza.Text.Trim <> "" Then
                    sql &= " and p.IdPoliza like " & dbStr("%" & txtPoliza.Text.Trim & "%")
                End If

                If txtProducto.Text.Trim <> "" Then
                    sql &= " and p.IdProducto like " & dbStr("%" & txtProducto.Text.Trim & "%")
                End If

                If txtSiniestro.Text <> "" Then
                    sql &= " and s.IdSiniestro like " & dbStr("%" & txtSiniestro.Text.Trim & "%")
                End If

                If txtSiniestroAseg.Text <> "" Then
                    sql &= " and s.IdSiniestroAseguradora like " & dbStr("%" & txtSiniestroAseg.Text.Trim & "%")
                End If

                If txtFechaOcurrido.Text <> "" Then
                    sql &= " and s.FechaOcurrido = " & dbFec(Me.txtFechaOcurrido.Text)
                End If

                If txtPagado.Text <> "" Then
                    sql &= " and (isnull((select sum(isnull(pa.ValorReembolso,0)) from SiniestrosPagos as pa where pa.idpoliza = s.idpoliza and pa.idproducto = s.idproducto and pa.idsiniestro = s.idsiniestro and pa.idcertificado = s.idcertificado),0)) = " & dbNum(txtPagado.Text)
                End If

                If VisibilidadUsuario() = "D" Then
                    sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                End If

                Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridSiniestros.DataSource = dtSiniestros
                GridSiniestros.Refresh()
                If dtSiniestros.Rows.Count = 0 Then
                    If MostrarMensaje = True Then
                        Me.lblStatus.Text = "No se encontraron Siniestros"
                    End If
                Else
                    Me.lblStatus.Text = ""
                    Me.VistaSiniestros.Focus()
                End If
                res = dtSiniestros.Rows.Count
            Catch ex As Exception
                msgError(ex)
            End Try
        End If
        Return res

    End Function

    Private Sub txtSiniestro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSiniestro.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.txtSiniestroAseg.Focus()
            End If
        End If
    End Sub

    Private Sub txtSiniestro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSiniestro.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtSiniestroAseg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSiniestroAseg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.txtPoliza.Focus()
            End If
        End If
    End Sub

    Private Sub txtSiniestroAseg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSiniestroAseg.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtPoliza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPoliza.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.txtProducto.Focus()
            End If
        End If
    End Sub

    Private Sub txtPoliza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoliza.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.txtIdCliente.Focus()
            End If
        End If
    End Sub

    Private Sub txtProducto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProducto.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtIdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCliente.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                txtAsegurado.Focus()
            End If
        End If
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtAsegurado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAsegurado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                txtBeneficiario.Focus()
            End If
        End If
    End Sub

    Private Sub txtAsegurado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAsegurado.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtBeneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBeneficiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                txtEstado.Focus()
            End If
        End If
    End Sub

    Private Sub txtBeneficiario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBeneficiario.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEstado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                txtFechaOcurrido.Focus()
            End If
        End If
    End Sub

    Private Sub txtEstado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEstado.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtFechaOcurre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaOcurrido.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.txtPagado.Focus()
            End If
        End If
    End Sub

    Private Sub txtFechaOcurre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaOcurrido.LostFocus
        Call ObtenerSiniestros()
    End Sub

    Private Sub txtValorPagado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPagado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerSiniestros() = 0 Then
                Me.VistaSiniestros.Focus()
            End If
        End If
    End Sub

    Private Sub txtValorPagado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPagado.LostFocus
        Call ObtenerSiniestros()
    End Sub

    

End Class