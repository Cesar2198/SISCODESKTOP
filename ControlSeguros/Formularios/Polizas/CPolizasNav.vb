Imports Utilerias.Genericas

Public Class CPolizasNav
    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition
    Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition

    Private Sub CPolizasNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If optAnioAct.Checked = True Then
            Me.Filtro = " year(cpolizas.VigenciaDesde) = year(getdate())"
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " and cpolizas.Departamento = " & dbStr(DepartamentoUsuario())
            End If
        End If

        If optAnioAnt.Checked = True Then
            Me.Filtro = " year(cpolizas.VigenciaDesde) = (year(getdate()) -1 )"
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " and cpolizas.Departamento = " & dbStr(DepartamentoUsuario())
            End If
        End If

        If optTodos.Checked = True Then
            Me.Filtro = ""
            If VisibilidadUsuario() = "D" Then
                Me.Filtro = " and cpolizas.Departamento = " & dbStr(DepartamentoUsuario())
            End If
        End If
    End Sub

    Private Sub CPolizasNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        Dim TipoIdOferta As String = clSeguros.ObtenerDBParametros("Oferta.IdAutomatico")
        Me.VistaNav.FormatConditions.Clear()
        If TipoIdOferta = "A" Then

            'adrisa desea colorear las ofertas 
            StyleFormatCondition1 = New DevExpress.XtraGrid.StyleFormatCondition
            StyleFormatCondition1.Appearance.ForeColor = Color.Orange ' System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            StyleFormatCondition1.Appearance.Options.UseForeColor = True
            StyleFormatCondition1.Appearance.Options.UseFont = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.VistaNav.Columns("DiasTramite")
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between
            StyleFormatCondition1.Value1 = 3
            StyleFormatCondition1.Value2 = 10

            StyleFormatCondition2 = New DevExpress.XtraGrid.StyleFormatCondition
            StyleFormatCondition2.Appearance.ForeColor = Color.Red ' System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
            StyleFormatCondition2.Appearance.Options.UseForeColor = True
            StyleFormatCondition2.Appearance.Options.UseFont = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.VistaNav.Columns("DiasTramite")
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
            StyleFormatCondition2.Value1 = 10


            Me.VistaNav.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        End If

        If GlobalCodCliente = "2120000" Then
            Try
                Me.VistaNav.Columns("IdPoliza").Caption = "No. Oferta ADRISA"
                Me.VistaNav.Columns("DiasTramite").Caption = "Días hábiles en Trámite"
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CPolizasNav_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim TipoIdOferta As String = clSeguros.ObtenerDBParametros("Oferta.IdAutomatico")
        If TipoIdOferta.Trim.ToUpper = "S" Then
            Me.VistaNav.Columns("IdPoliza").SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
        End If
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CPolizasNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 135
            Me.GridNav.Height = Me.Height - 105
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optAnioAct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAnioAct.Click
        Try
            Me.CargarRegistros()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optAnioAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAnioAnt.Click
        Try
            Me.CargarRegistros()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub optTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optTodos.Click
        Try
            Me.CargarRegistros()
        Catch ex As Exception

        End Try
    End Sub

End Class
