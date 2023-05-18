Imports Utilerias.Genericas

Public Class AvisosCobrosNav

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

    Private Sub AvisosCobrosNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Me.Filtro = ""
        If VisibilidadUsuario() = "D" Then
            Me.Filtro = " (select count(*) from polizas as p where p.idpoliza = AvisosCobro.idpoliza and p.idproducto = AvisosCobro.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

        If optAnioAct.Checked = True Then
            If Me.Filtro.Trim <> "" Then Me.Filtro &= " and "
            Me.Filtro &= " year(VigenciaDesde) = year(getdate())"
        End If

        If optAnioAnt.Checked = True Then
            If Me.Filtro.Trim <> "" Then Me.Filtro &= " and "
            Me.Filtro &= " year(VigenciaDesde) = (year(getdate()) -1 )"
        End If

        Select Case GlobalCodCliente
            Case "2120000"
                If InStr(Me.ListaAliasCampos, ", Pendiente") = 0 Then
                    'agregamos una columna de control
                    Me.ListaCampos &= ", case when (len(IdAnexo) <= 2 and datediff(d,FechaGrabacion,getdate()) > 7) then 'SI' else 'NO' end as Pendiente"
                    Me.ListaCamposOcultos &= ", Pendiente"
                    Me.ListaAliasCampos &= ", Pendiente"
                    Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
                    StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
                    StyleFormatCondition1.Appearance.ForeColor = Color.Red
                    StyleFormatCondition1.Appearance.Options.UseForeColor = True
                    StyleFormatCondition1.Appearance.Options.UseFont = True
                    StyleFormatCondition1.ApplyToRow = True
                    StyleFormatCondition1.Column = Me.VistaNav.Columns("Pendiente")
                    StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
                    StyleFormatCondition1.Value1 = "SI"
                    Me.VistaNav.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})


                End If
        End Select

    End Sub

    Private Sub AvisosCobrosNav_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case GlobalCodCliente
            Case "1990000"
                Me.FormularioEdicion = "FacturacionNR"
        End Select
    End Sub

    Private Sub AvisosCobrosNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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

End Class
