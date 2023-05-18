
Imports Utilerias.Genericas

Public Class BusquedaCertReclamo

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
            busCodigo = VistaPolizas.GetRowCellValue(FilFactura, "Poliza") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Producto") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Certificado") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "IdBien") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Contratante") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Asegurado") & "|" & VistaPolizas.GetRowCellValue(FilFactura, "Beneficiario") & "|" & Me.cboPlan.Valor
            Me.Close()
        Else
            MsgBox("Debe seleccionar una Póliza y Certificado.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Function ObtenerPolizas(Optional ByVal MostrarMensaje As Boolean = True) As Integer
        Dim res As Integer = 0
        If txtContratante.Text <> "" Or txtAsegurado.Text <> "" Or txtCertificado.Text <> "" Or txtPoliza.Text <> "" Or txtProducto.Text <> "" Or txtBeneficiario.Text <> "" Or Me.txtPlaca.Text <> "" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim sql As String = ""
                sql = "  select p.idpoliza as Poliza"
                sql &= " , p.idproducto as Producto"
                sql &= " , c.idcertificado as Certificado"
                sql &= " , p.NombreCliente as Contratante"
                sql &= " , c.NombreCliente as Asegurado "
                sql &= " , isnull(b.DescripcionBien, isnull(c.NombreCliente,'')) as Beneficiario"
                sql &= " , isnull(v.DescripcionBien ,'') as Placa"
                'sql &= " , row_number() OVER(PARTITION BY p.idproducto, p.idpoliza, c.idcertificado order BY p.idproducto, p.idpoliza, c.idcertificado,b.IdBien) as IdBien"
                sql &= " , 0 as IdBien"
                sql &= " from Polizas as p"
                sql &= " inner join PolizasCertificados as c on p.idpoliza = c.idpoliza and p.idproducto = c.idproducto"
                sql &= " left join Clientes as cl on cl.idcliente = p.idcliente"
                sql &= " left join Clientes as clc on clc.idcliente = c.idcliente"
                'para obtener los asegurados de GM
                sql &= " left join PolizasBienes as b on b.IdPoliza = c.IdPoliza and b.IdProducto = c.IdProducto and b.IdCertificado = c.IdCertificado and b.NombreBien in ('DEPENDIENTES','BENEFICIARIOS', 'DEPENDIENTE', 'BENEFICIARIO')"
                'para autos
                sql &= " left join PolizasBienes as v on v.IdPoliza = c.IdPoliza and v.IdProducto = c.IdProducto and v.IdCertificado = c.IdCertificado and v.NombreBien = 'PLACA' "
                sql &= " where p.IdPoliza is not null "

                If dbFiltro <> "" Then
                    sql &= dbFiltro
                End If

                If txtPoliza.Text.Trim <> "" Then
                    'si hay plan la póliza es igual
                    If cboPlan.Valor = "" Then
                        sql &= " and p.IdPoliza like " & dbStr("%" & txtPoliza.Text.Trim & "%")
                    Else
                        sql &= " and p.IdPoliza = " & dbStr(txtPoliza.Text.Trim)
                    End If
                End If

                If txtProducto.Text.Trim <> "" Then
                    If cboPlan.Valor = "" Then
                        sql &= " and p.IdProducto like " & dbStr("%" & txtProducto.Text.Trim & "%")
                    Else
                        sql &= " and p.IdProducto = " & dbStr(txtProducto.Text.Trim)
                    End If
                End If

                If txtCertificado.Text.Trim <> "" Then
                    sql &= " and c.idcertificado = " & dbStr(txtCertificado.Text.Trim)
                End If

                If txtIdBien.Text <> "" Then
                    sql &= " and b.idbien = " & dbNum(txtIdBien.Text.Trim)
                End If

                If VisibilidadUsuario() = "D" Then
                    sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                End If

                If txtContratante.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtContratante.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtContratante.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (p.NombreCliente like " & dbStr("%" & Palabra & "%") & " or cl.conocidopor like " & dbStr("%" & Palabra & "%") & " )"
                        End If
                    Next
                End If

                If txtAsegurado.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtAsegurado.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtAsegurado.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and (c.NombreCliente like " & dbStr("%" & Palabra & "%") & " or clc.conocidopor like " & dbStr("%" & Palabra & "%") & ") "
                        End If
                    Next
                End If

                If txtBeneficiario.Text.Trim <> "" Then
                    Dim NumPalabras As Integer = CuentaCar(txtBeneficiario.Text.Trim, " "), Palabra As String
                    For NP As Integer = 0 To NumPalabras
                        Palabra = stiSplit(txtBeneficiario.Text.Trim, "G" & NP & " 1").Trim
                        If Palabra <> "" Then
                            sql &= " and  isnull(b.DescripcionBien, isnull(c.NombreCliente,'')) like " & dbStr("%" & Palabra & "%")
                        End If
                    Next
                End If

                If txtPlaca.Text.Trim <> "" Then
                    sql &= " and cast(v.DescripcionBien as varchar(max)) like " & dbStr("%" & txtPlaca.Text.Trim & "%")
                End If

                sql &= " order by p.idproducto, p.idpoliza, c.idcertificado, b.IdBien"

                Dim dtPolizas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                GridPolizas.DataSource = dtPolizas
                GridPolizas.Refresh()
                If dtPolizas.Rows.Count = 0 Then
                    If MostrarMensaje = True Then
                        Me.lblStatus.Text = "No se encontraron Pólizas"
                    End If
                Else
                    'campletaremos el idBien
                    Dim intBien As Integer = 0
                    For Each FilBus As DataRow In dtPolizas.Rows
                        intBien = ObtenerIdBienBeneficiarioVida(FilBus("Poliza"), FilBus("Producto"), FilBus("Certificado"), FilBus("Beneficiario"))
                        FilBus("IdBien") = intBien
                    Next
                    Me.lblStatus.Text = ""
                    ''Me.VistaPolizas.Focus()
                End If
                res = dtPolizas.Rows.Count

            Catch ex As Exception
                msgError(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
        Return res

    End Function

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
                Me.txtCertificado.Focus()
            End If
        End If
    End Sub

    Private Sub txtProducto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProducto.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtCertificado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCertificado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtIdBien.Focus()
            End If
        End If
    End Sub

    Private Sub txtcertificado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCertificado.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtIdBien_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdBien.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtContratante.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdBien_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdBien.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtContratante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContratante.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.txtAsegurado.Focus()
            End If
        End If
    End Sub

    Private Sub txtContratante_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContratante.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtAsegurado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAsegurado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                txtBeneficiario.Focus()
            End If
        End If
    End Sub

    Private Sub txtAsegurado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAsegurado.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub txtBeneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBeneficiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.VistaPolizas.Focus()
            End If
        End If
    End Sub

    Private Sub txtBeneficiario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBeneficiario.LostFocus
        Call ObtenerPolizas()
    End Sub

    Private Sub BusquedaCertificados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboPlan.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboPlan.Llenar_Combo()

        Call ObtenerPolizas(False)
    End Sub

    Private Sub VistaPolizas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaPolizas.DoubleClick
        Call btnAgregar_Click(Nothing, Nothing)
    End Sub

    Private Sub VistaPolizas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VistaPolizas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAgregar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cboPlan_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboPlan.ValueChangeOnExit
        If cboPlan.Text <> "" Then
            Try
                Dim Fila As DataRow = StiGlobalConn.ObtenerDataset("select * from SiniestroPlanes where IdPlan = " & dbStr(cboPlan.Valor)).Tables(0).Rows(0)
                Me.txtPoliza.Text = dbData(Fila, "idpoliza")
                Me.txtProducto.Text = dbData(Fila, "idproducto")
                Call ObtenerPolizas(False)
                Me.txtCertificado.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtPlaca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlaca.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ObtenerPolizas() = 0 Then
                Me.VistaPolizas.Focus()
            End If
        End If
    End Sub

    Private Sub txtPlaca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlaca.LostFocus
        Call ObtenerPolizas()
    End Sub

End Class