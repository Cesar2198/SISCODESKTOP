Imports Utilerias.Genericas

Public Class AseguradorasMan

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Me.EliminarFilaGrid(GridView1)
        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim Id As Integer = ObtenerIDcontacto()
            Me.AgregarFilaGrid(GridView1)
            'ademos agregaremos el Id de contacto
            Me.GridView1.SetRowCellValue(Me.GridView1.FocusedRowHandle, "IdContacto", Id)
            Me.GridView1.UpdateCurrentRow()

        Catch ex As Exception
            MsgBox("Error al adicionar registro." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function ObtenerIDcontacto() As Integer
        Dim Id As Integer = 0
        For I As Integer = 0 To Me.GridView1.DataRowCount - 1
            Try
                If CInt(GridView1.GetRowCellValue(I, "IdContacto")) > Id Then
                    Id = CInt(GridView1.GetRowCellValue(I, "IdContacto"))
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

    Private Sub RepositoryItemTextEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.Enter
        Select Case Me.GridView1.FocusedColumn.FieldName
            Case "Nombre", "Funciones" : Me.RepositoryItemTextEdit1.MaxLength = 250
            Case "Cargo" : Me.RepositoryItemTextEdit1.MaxLength = 50
            Case "Telefono", "EMail" : Me.RepositoryItemTextEdit1.MaxLength = 100

        End Select
    End Sub

    Private Sub txtIdAseguradora_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdAseguradora.ValueChangeOnExit
        Call ActualizarLlavesGrid(Me, txtIdAseguradora.NombreCampo, txtIdAseguradora.Valor)
    End Sub

    Private Sub AseguradorasMan_DespuesDeCargarRegistro() Handles Me.DespuesDeCargarRegistro
        If txtIdAseguradora.Valor <> "" Then lblEstado.Text = "Estado Aseguradora: " & funEstadoAseguradora(txtIdAseguradora.Valor)
    End Sub

    Private Sub AseguradorasMan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If StiGlobalConn.UsuarioPerteneceAGrupo(STIConn.User, "ADMINISTRADORES") = False Or Me.EstadoRegistro <> enEstadoRegistro.Modificando Then
            Me.btnCrearProductos.Visible = False
        End If
    End Sub

    Private Sub btnCrearProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearProductos.Click
        'crearemos los productos basados en los existentes de ACSA
        Dim sql As String = ""
        If txtSiglas.Text = "" Then
            MsgBox("Debe primero especificar la sigla o abreviatura de la aseguradora.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Dim Cia As String = InputBox("¿Desea únicamente producto de Vida= 1, únicamente productos de Daños = 2, Todos los productos = 3?", "Pregunta...", "3")
        Dim FiltroTipo As String = ""
        Select Case Cia.Trim.ToUpper
            Case "1"
                FiltroTipo = " and TipoProducto = 'VIDA'"
            Case "2"
                FiltroTipo = " and TipoProducto = 'DAÑOS'"
        End Select

        Try
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'creamos los productos
            sql = "  insert into Productos ( IdProducto, Descripcion, IdAseguradora, TipoProducto, CodigoCia, IdRamo)"
            sql &= " select replace(IdProducto,'ACSA','" & txtSiglas.Valor & "'), replace(Descripcion,'ACSA','" & txtSiglas.Valor & "'), '" & txtIdAseguradora.Valor & "' AS IdAseguradora, TipoProducto, NULL AS CodigoCia, IdRamo"
            sql &= " from productos "
            sql &= " where idaseguradora = '1' " & FiltroTipo
            StiGlobalConn.SQLExecute(sql)

            'creamos los bienes
            sql = "  insert into ProductosBienes ( IdProducto, IdBien, NombreBien)"
            sql &= " select replace(IdProducto,'ACSA','" & txtSiglas.Valor & "'), IdBien, NombreBien "
            sql &= " from ProductosBienes "
            sql &= " where idproducto in (select idproducto from productos where idaseguradora = '1' " & FiltroTipo & ")"
            StiGlobalConn.SQLExecute(sql)

            'creamos las coberturas
            sql = "  insert into ProductosCoberturas (  IdProducto, IdCobertura, Descripcion, CodigoCia, Tarificacion, AplicarDescuento)"
            sql &= " select replace(IdProducto,'ACSA','" & txtSiglas.Valor & "'), IdCobertura, Descripcion, CodigoCia, Tarificacion, AplicarDescuento"
            sql &= " from ProductosCoberturas "
            sql &= " where idproducto in (select idproducto from productos where idaseguradora = '1' " & FiltroTipo & ")"
            StiGlobalConn.SQLExecute(sql)

            'creamos los complementos de siniestros
            sql = "  insert into ProductosSinComplementos (  IdProducto, IdComplemento, DescripcionComplemento, Categoria)"
            sql &= " select replace(IdProducto,'ACSA','" & txtSiglas.Valor & "'), IdComplemento, DescripcionComplemento, Categoria"
            sql &= " from ProductosSinComplementos "
            sql &= " where idproducto in (select idproducto from productos where idaseguradora = '1' " & FiltroTipo & ")"
            StiGlobalConn.SQLExecute(sql)

            'Gastos de siniestros
            sql = "  insert into ProductosSinGastos (  IdProducto, IdGasto, Descripcion, CoberturaAfecta, CodAseguradora)"
            sql &= " select replace(IdProducto,'ACSA','" & txtSiglas.Valor & "'), IdGasto, Descripcion, CoberturaAfecta, CodAseguradora"
            sql &= " from ProductosSinGastos "
            sql &= " where idproducto in (select idproducto from productos where idaseguradora = '1' " & FiltroTipo & ")"
            StiGlobalConn.SQLExecute(sql)

            'requisitos siniestros
            sql = "  insert into ProductosSinRequisitos (  IdProducto, IdRequisito, DescripcionRequisito)"
            sql &= " select replace(IdProducto,'ACSA','" & txtSiglas.Valor & "'), IdRequisito, DescripcionRequisito"
            sql &= " from ProductosSinRequisitos "
            sql &= " where idproducto in (select idproducto from productos where idaseguradora = '1' " & FiltroTipo & ")"
            StiGlobalConn.SQLExecute(sql)


            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("Operación completada con éxito")

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        End Try
    End Sub

End Class

