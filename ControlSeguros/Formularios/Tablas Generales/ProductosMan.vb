Public Class ProductosMan

    Private Sub ProductosMan_DespuesDeCargarCombos() Handles Me.DespuesDeCargarCombos
        'llenaremos la lista del combo
        Dim strLista As String = clSeguros.ObtenerDBParametros("Lista.Tipo.Bienes")
        Dim strItem As String = ""
        Dim TB As New DataTable
        TB.Columns.Add("Id", System.Type.GetType("System.String"))
        TB.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTB As DataRow

        If strLista.Trim <> "" Then
            For I As Integer = 0 To Utilerias.Genericas.CuentaCar(strLista, ",")
                strItem = Utilerias.Genericas.stiSplit(strLista, "G" & I & ",1").Trim
                FilaTB = TB.NewRow : FilaTB("Id") = strItem : FilaTB("Tipo") = strItem : TB.Rows.Add(FilaTB)
            Next
        End If
        Me.cboTipoBien.Llenar_Combo(TB)
    End Sub

    Private Sub ProductosMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarCombosGrid()
        Call ProcesarPermisosComision()
    End Sub

    Private Sub LlenarCombosGrid()
        'las formas de pago se llenan manual
        Dim FP As New DataTable
        FP.Columns.Add("Id", System.Type.GetType("System.String"))
        FP.Columns.Add("FormaPago", System.Type.GetType("System.String"))
        Dim Fila As DataRow
        Fila = FP.NewRow : Fila("Id") = "PERIODICA" : Fila("FormaPago") = "Pago con cada Factura" : FP.Rows.Add(Fila)
        Fila = FP.NewRow : Fila("Id") = "ANTICIPADA" : Fila("FormaPago") = "Un sólo pago" : FP.Rows.Add(Fila)

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "FormaPago"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = FP
        RepositoryItemLookUpEdit1.PopulateColumns()

        'las formas de pago se llenan manual
        Dim FPV As New DataTable
        FPV.Columns.Add("Id", System.Type.GetType("System.String"))
        FPV.Columns.Add("FormaPago", System.Type.GetType("System.String"))
        Fila = FPV.NewRow : Fila("Id") = "PERIODICA" : Fila("FormaPago") = "Pago con cada Factura" : FPV.Rows.Add(Fila)
        Fila = FPV.NewRow : Fila("Id") = "ANTICIPADA" : Fila("FormaPago") = "Un sólo pago" : FPV.Rows.Add(Fila)
        Fila = FPV.NewRow : Fila("Id") = "PERIODICAT" : Fila("FormaPago") = "Pago con cada Factura sobre la prima" : FPV.Rows.Add(Fila)

        RepositoryItemLookUpEdit3.ValueMember = "Id"
        RepositoryItemLookUpEdit3.DisplayMember = "FormaPago"
        RepositoryItemLookUpEdit3.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit3.DataSource = FPV
        RepositoryItemLookUpEdit3.PopulateColumns()

        Dim TV As DataTable
        TV = StiGlobalConn.ObtenerDataset("select IdTipoVendedor as Id, NombreTipoVendedor as TipoVendedor from TipoVendedor").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "TipoVendedor"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = TV
        RepositoryItemLookUpEdit2.PopulateColumns()


        Dim TG As DataTable
        TG = StiGlobalConn.ObtenerDataset("select IdGasto as Id, NombreGasto as NombreGasto from TipoGastos").Tables(0)
        RepositoryItemLookUpEdit4.ValueMember = "Id"
        RepositoryItemLookUpEdit4.DisplayMember = "NombreGasto"
        RepositoryItemLookUpEdit4.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit4.DataSource = TG
        RepositoryItemLookUpEdit4.PopulateColumns()


        Dim TR As New DataTable
        TR.Columns.Add("Id", System.Type.GetType("System.Int32"))
        TR.Columns.Add("Tarifa", System.Type.GetType("System.String"))
        Dim FilaTR As DataRow
        FilaTR = TR.NewRow : FilaTR("Id") = 100 : FilaTR("Tarifa") = "%" : TR.Rows.Add(FilaTR)
        FilaTR = TR.NewRow : FilaTR("Id") = 1000 : FilaTR("Tarifa") = "%0" : TR.Rows.Add(FilaTR)

        RepositoryItemLookUpEdit5.ValueMember = "Id"
        RepositoryItemLookUpEdit5.DisplayMember = "Tarifa"
        RepositoryItemLookUpEdit5.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit5.DataSource = TR
        RepositoryItemLookUpEdit5.PopulateColumns()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Descuento", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow
        FilaTD = TD.NewRow : FilaTD("Id") = "S" : FilaTD("Descuento") = "SI" : TD.Rows.Add(FilaTD)
        FilaTD = TD.NewRow : FilaTD("Id") = "N" : FilaTD("Descuento") = "NO" : TD.Rows.Add(FilaTD)

        RepositoryItemLookUpEdit6.ValueMember = "Id"
        RepositoryItemLookUpEdit6.DisplayMember = "Descuento"
        RepositoryItemLookUpEdit6.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit6.DataSource = TD
        RepositoryItemLookUpEdit6.PopulateColumns()
        RepositoryItemLookUpEdit6.Columns("Id").Visible = False

        Dim TC As New DataTable
        TC.Columns.Add("Id", System.Type.GetType("System.String"))
        TC.Columns.Add("Calculo", System.Type.GetType("System.String"))
        Dim FilaTC As DataRow
        FilaTC = TC.NewRow : FilaTC("Id") = "P" : FilaTC("Calculo") = "Por Prima" : TC.Rows.Add(FilaTC)
        FilaTC = TC.NewRow : FilaTC("Id") = "S" : FilaTC("Calculo") = "Por Suma" : TC.Rows.Add(FilaTC)

        RepositoryItemLookUpEdit7.ValueMember = "Id"
        RepositoryItemLookUpEdit7.DisplayMember = "Calculo"
        RepositoryItemLookUpEdit7.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit7.DataSource = TC
        RepositoryItemLookUpEdit7.PopulateColumns()
        RepositoryItemLookUpEdit7.Columns("Id").Visible = False

        Me.cboTipoBien.OcultarColumna(0)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Me.AgregarFilaGrid(GridView1)
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IdCobertura", ObtenerIDCobertura())
            GridView1.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDCobertura() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView1.DataRowCount - 1
            Try
                If CInt(GridView1.GetRowCellValue(I, "IdCobertura")) > Id Then
                    Id = CInt(GridView1.GetRowCellValue(I, "IdCobertura"))
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

    Private Sub btnQutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQutar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            Me.AgregarFilaGrid(GridView2)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "IdComision", ObtenerIDComiExt())
            GridView2.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDComiExt() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView2.DataRowCount - 1
            Try
                If CInt(GridView2.GetRowCellValue(I, "IdComision")) > Id Then
                    Id = CInt(GridView2.GetRowCellValue(I, "IdComision"))
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Me.EliminarFilaGrid(GridView2)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            Me.AgregarFilaGrid(GridView3)
            GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "IdComision", ObtenerIDComiInt())
            GridView3.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDComiInt() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView3.DataRowCount - 1
            Try
                If CInt(GridView3.GetRowCellValue(I, "IdComision")) > Id Then
                    Id = CInt(GridView3.GetRowCellValue(I, "IdComision"))
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

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            Me.EliminarFilaGrid(GridView3)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Try
            Me.AgregarFilaGrid(GridView4)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Try
            Me.EliminarFilaGrid(GridView4)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub txtIdProducto_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdProducto.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdProducto.NombreCampo, txtIdProducto.Valor)
    End Sub

    Private Sub ProcesarPermisosComision()
        Try
            Dim PremisoComi As Boolean = UsuarioPerteneceAGrupo("COMISIONES")
            If PremisoComi = False Then
                'PROCEDEMOS A OCULTAR LOS DATOS DE COMISIONES
                StiGrid2.Visible = False
                StiGrid3.Visible = False
                SimpleButton2.Visible = False
                SimpleButton1.Visible = False
                SimpleButton4.Visible = False
                SimpleButton3.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregarBien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarBien.Click
        Try
            Dim IdBien As Integer = ObtenerIDBien()
            Me.AgregarFilaGrid(VistaBienes)
            Dim Fila As Integer = VistaBienes.FocusedRowHandle
            VistaBienes.SetRowCellValue(Fila, "IdBien", IdBien)
            VistaBienes.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDBien() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaBienes.DataRowCount - 1
            Try
                If CInt(VistaBienes.GetRowCellValue(I, "IdBien")) > Id Then
                    Id = CInt(VistaBienes.GetRowCellValue(I, "IdBien"))
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

    Private Sub btnQuitarBien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarBien.Click
        Try
            Me.EliminarFilaGrid(VistaBienes)
        Catch ex As Exception
            MsgBox("Error al Eliminar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgreagrSinReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgreagrSinReq.Click
        Try
            Me.AgregarFilaGrid(GridView5)
            Me.GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "IdRequisito", ObtenerIDRequisito())
            GridView5.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDRequisito() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView5.DataRowCount - 1
            Try
                If CInt(GridView5.GetRowCellValue(I, "IdRequisito")) > Id Then
                    Id = CInt(GridView5.GetRowCellValue(I, "IdRequisito"))
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

    Private Sub btnAgregarSinComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSinComp.Click
        Try
            Me.AgregarFilaGrid(GridView6)
            GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "IdComplemento", ObtenerIDComplemento())
            GridView6.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDComplemento() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView6.DataRowCount - 1
            Try
                If CInt(GridView6.GetRowCellValue(I, "IdComplemento")) > Id Then
                    Id = CInt(GridView6.GetRowCellValue(I, "IdComplemento"))
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

    Private Sub btnQuitarSinReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSinReq.Click
        Try
            Me.EliminarFilaGrid(GridView5)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarSinComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSinComp.Click
        Try
            Me.EliminarFilaGrid(GridView6)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.GridView1.FocusedColumn.FieldName
            Case "Descripcion" : Me.RepositoryItemTextEdit1.MaxLength = 0
            Case "CodigoCia" : Me.RepositoryItemTextEdit1.MaxLength = 25
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit2.Enter
        Select Case Me.GridView4.FocusedColumn.FieldName
            Case "CodigoAseguradora" : Me.RepositoryItemTextEdit2.MaxLength = 25
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit3.Enter
        Select Case Me.VistaBienes.FocusedColumn.FieldName
            Case "NombreBien" : Me.RepositoryItemTextEdit3.MaxLength = 250
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit4.Enter
        Select Case Me.GridView5.FocusedColumn.FieldName
            Case "DescripcionRequisito" : Me.RepositoryItemTextEdit4.MaxLength = 250
        End Select
    End Sub

    Private Sub RepositoryItemTextEdit5_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit5.Enter
        Select Case Me.GridView6.FocusedColumn.FieldName
            Case "DescripcionComplemento", "Categoria" : Me.RepositoryItemTextEdit5.MaxLength = 250
        End Select
    End Sub

    Private Sub btnAgregarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGasto.Click
        Try
            Me.AgregarFilaGrid(VistaSinGastos)
            Me.VistaSinGastos.SetRowCellValue(VistaSinGastos.FocusedRowHandle, "IdGasto", ObtenerIDGasto())
            VistaSinGastos.UpdateCurrentRow()
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDGasto() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.VistaSinGastos.DataRowCount - 1
            Try
                If CInt(VistaSinGastos.GetRowCellValue(I, "IdGasto")) > Id Then
                    Id = CInt(VistaSinGastos.GetRowCellValue(I, "IdGasto"))
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

    Private Sub btnQuitarGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGasto.Click
        Try
            Me.EliminarFilaGrid(VistaSinGastos)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemTextEdit6_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit6.Enter
        Select Case Me.VistaSinGastos.FocusedColumn.FieldName
            Case "Descripcion" : Me.RepositoryItemTextEdit6.MaxLength = 150
            Case "CodAseguradora" : Me.RepositoryItemTextEdit6.MaxLength = 25
        End Select
    End Sub

End Class
