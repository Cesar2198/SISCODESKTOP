Imports Utilerias.Genericas

Public Class PagosMan

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            'determinaremos el movimiento para asignarse
            Dim id As Integer = ObtenerIDMovimiento()
            Me.AgregarFilaGrid(Me.VistaMovimientos)
            Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "IdMovimiento", id)
            Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "UsuarioGrabacion", StiGlobalConn.User)

            If VistaMovimientos.RowCount = 1 Then
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "TipoMovimiento", "EMISION")
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "FechaMovimiento", Date.Today)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "PrimaNeta", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "GastosEmision", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "GastosFracciona", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "GastosBomberos", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "Gastos", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "Impuestos", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "Total", 0)
                Me.VistaMovimientos.SetRowCellValue(Me.VistaMovimientos.FocusedRowHandle, "Comision", 0)
                Me.VistaMovimientos.UpdateCurrentRow()
            End If




        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDMovimiento() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaMovimientos.DataRowCount - 1
            Try
                If CInt(VistaMovimientos.GetRowCellValue(I, "IdMovimiento")) > Id Then
                    Id = CInt(VistaMovimientos.GetRowCellValue(I, "IdMovimiento"))
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

    Private Sub PagosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RepositoryItemComboBox1.Items.Clear()
        Me.RepositoryItemComboBox1.Items.Add("EMISION")
        Me.RepositoryItemComboBox1.Items.Add("ANULACION")
        Me.RepositoryItemComboBox1.Items.Add("PAGO")

        If Me.Permiso = "L" Then
            Me.btnAgregar.Enabled = False
            Me.btnQuitar.Enabled = False
        End If


        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("Descripcion", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "E" : Fila("Descripcion") = "Efectivo" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "C" : Fila("Descripcion") = "Cheque" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "D" : Fila("Descripcion") = "Depósito Bancario" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "T" : Fila("Descripcion") = "Tarjeta" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "N" : Fila("Descripcion") = "Nota Crédito" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "A" : Fila("Descripcion") = "Depósito en Aseguradora" : FP.Rows.Add(Fila)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = FP
        RepositoryItemLookUpEdit1.PopulateColumns()

        Call ProcesarPermisosComision()
        txtIdAC.SoloLectura = True
        txtIdAC.Valor = ObtenerAC()

        Select Case GlobalCodCliente
            Case "2120000"
                Me.GridMovimientos.ContextMenuStrip = Nothing
        End Select
    End Sub

    Private Function ObtenerAC() As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select IdAvisoCobro from AvisosCobroFacturas where IdPoliza = " & dbStr(txtIdPoliza.Valor) & " and IdProducto = " & dbStr(cboIdProducto.Valor) & " and NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and IdRamo = " & dbStr(txtIdRamo.Valor)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Private Sub lblIdAC_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblIdAC.LinkClicked
        'cargaremos el IdAC
        Try
            If txtIdAC.Valor <> "" Then
                Dim frmAC As New Facturacion
                frmAC.dbTabla = "AvisosCobro"
                frmAC.Permiso = Me.Permiso
                frmAC.dbCondicion = "IdAvisoCobro = " & dbStr(Me.txtIdAC.Valor)
                frmAC.STIConn = StiGlobalConn
                frmAC.ShowDialog(Me)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                txtPorceComision.Visible = False
                GridColumn11.Visible = False
                GridColumn11.OptionsColumn.AllowShowHide = False

                GridColumn12.Visible = False
                GridColumn12.OptionsColumn.AllowShowHide = False
                GridColumn13.Visible = False
                GridColumn13.OptionsColumn.AllowShowHide = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Me.EliminarFilaGrid(Me.VistaMovimientos)
        Catch ex As Exception
            MsgBox("Error al eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub NuevaEmision()
        Try
            If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                If txtNumeroFactura.Text <> "" And txtIdPoliza.Text <> "" And cboIdProducto.Text <> "" Then
                    If Me.VistaMovimientos.RowCount = 0 Then
                        Call btnAgregar_Click(Nothing, Nothing)
                    Else
                        ''Actualizaremos las claves
                        For I As Integer = 0 To Me.VistaMovimientos.DataRowCount - 1
                            VistaMovimientos.SetRowCellValue(I, "NumeroFactura", txtNumeroFactura.Valor)
                            VistaMovimientos.SetRowCellValue(I, "IdProducto", cboIdProducto.Valor)
                            VistaMovimientos.SetRowCellValue(I, "IdPoliza", txtIdPoliza.Valor)
                            VistaMovimientos.SetRowCellValue(I, "IdRamo", txtIdRamo.Valor)
                        Next
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNumeroFactura_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtNumeroFactura.ValueChangeOnExit
        Call NuevaEmision()
    End Sub

    Private Sub txtIdPoliza_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdPoliza.ValueChangeOnExit
        Call NuevaEmision()
    End Sub

    Private Sub cboIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboIdProducto.ValueChangeOnExit
        Call NuevaEmision()
    End Sub

    Private Sub txtIdRamo_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdRamo.ValueChangeOnExit
        Call NuevaEmision()
    End Sub

    Private Sub txtPorceComision_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtPorceComision.ValueChangeOnExit
        ''con esto permitiremos cambiar la comision a una factura y sus movimientos
        Dim Comi As Double = Me.txtPorceComision.Valor
        Dim Prima As Double = 0
        Dim Res As Double = 0
        For NF As Integer = 0 To Me.VistaMovimientos.DataRowCount - 1
            Try
                Prima = Me.VistaMovimientos.GetRowCellValue(NF, "PrimaNeta")
                Res = Math.Round(Prima * (Comi / 100), 2)
                Me.VistaMovimientos.SetRowCellValue(NF, "Comision", Res)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ImprimirCartaDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirCartaDocumentoToolStripMenuItem.Click
        Try
            Dim fila As Integer = Me.VistaMovimientos.FocusedRowHandle
            If fila >= 0 Then
                Dim Factura As String = Me.txtNumeroFactura.Valor
                Dim IdProducto As String = Me.cboIdProducto.Valor
                Dim IdPoliza As String = Me.txtIdPoliza.Valor
                Dim IdRamo As String = txtIdRamo.Valor
                Dim IdMovimiento As Integer = Me.VistaMovimientos.GetRowCellValue(fila, "IdMovimiento")
                Dim TipoMov As String = Me.VistaMovimientos.GetRowCellValue(fila, "TipoMovimiento")

                Dim IncluirEnEvioSimple As String = CStr(clSeguros.ObtenerDBParametros("Flujo.Simple.AC")).Trim.ToUpper
                Dim IdFlujoDefault As String = "", IdImpresion As String = ""
                If IncluirEnEvioSimple = "S" Then
                    Try
                        IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                    Catch ex As Exception
                        IdFlujoDefault = ""
                    End Try
                    If IdFlujoDefault <> "" Then
                        Call clFlujos.RegistrarDocumento(IdFlujoDefault, "Carta Envio de Comprobantes Pagados", txtIdCliente.Valor, txtNumeroFactura.Valor, "SALIDA", IdImpresion, "", Date.Today, txtNombreCliente.Valor, EsDocumentoDeCobro:=True, CodigoImpresionDocumento:="CP")

                        Dim Direccion As String = ""
                        Try
                            Direccion = StiGlobalConn.ObtenerDataset("select top 1 isnull(Direccion,'') from ClientesContactos where idcliente = " & dbStr(txtIdCliente.Valor) & " and Direccion is not null order by UsoCorrespondencia desc").Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            Direccion = ""
                        End Try

                        Dim strSQL As String = "  update FlujosDocumentosImpresiones set "
                        strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
                        strSQL &= " ,DireccionDocumento = " & dbStr(Direccion, 250)
                        strSQL &= " ,NombreDestinatario = " & dbStr(txtNombreCliente.Valor, 150)
                        strSQL &= " ,IdOrigen = " & dbStr(txtNombreCliente.Valor, 250)
                        strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdImpresion)
                        StiGlobalConn.SQLExecute(strSQL)

                    End If
                End If

                Select Case TipoMov
                    Case "PAGO"
                        Me.Cursor = Cursors.WaitCursor
                        ImprimirPago(Factura, IdProducto, IdPoliza, IdRamo, IdMovimiento, IdImpresion)

                        Dim msgflujo As String = clFlujos.IniciarFlujoPagos(Factura, IdPoliza, IdProducto, IdRamo)
                        If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")
                        Me.Cursor = Cursors.Default

                    Case "EMISION"
                        Me.Cursor = Cursors.WaitCursor

                        ImprimirEmision(Factura, IdProducto, IdPoliza, IdRamo, IdMovimiento, IdImpresion)
                        Dim msgflujo As String = clFlujos.IniciarFlujoCobros(Factura, IdPoliza, IdProducto, IdRamo)
                        If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")
                        Me.Cursor = Cursors.Default
                End Select
            Else
                MsgBox("Debe seleccionar la factura a la que desea ingresarle una gestión.", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
