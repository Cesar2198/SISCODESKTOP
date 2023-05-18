Imports Utilerias.Genericas

Public Class FinalizarFlujosNav

    Private WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

    Private Sub ContinuarFlujoNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        'revalidamos el filtro de registros
        'validamos que el usuarios activo tenga permiso de ver el paso que siguiente en el flujo
        Dim sql As String = ""

        '1) flujos que esten pendientes
        sql = "EstadoFlujo = 'PENDIENTE'"

        '2) flujos de usuario asignado
        sql &= " and ("
        sql &= " (FlujosDocumentos.IdUsuarioDestino = " & dbStr(StiGlobalConn.User) & ") "

        'sql &= " (select top 1 Usuarios from FlujosTrabajoPasos "
        'sql &= " where FlujosTrabajoPasos.IdFlujo = FlujosDocumentos.IdFlujo"
        'sql &= " and IdPaso = "
        'sql &= " (select IdSiguientePaso "
        'sql &= " 		from  FlujosTrabajoPasos as ftp "
        'sql &= " 		where ftp.IdFlujo = FlujosDocumentos.IdFlujo "
        'sql &= " 		and ftp.IdPaso = "
        'sql &= " 			 (select IdPaso from FlujosDocumentosPasos "
        'sql &= " 				where FlujosDocumentosPasos.IdFlujoDoc = FlujosDocumentos.IdFlujoDoc"
        'sql &= " 				and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = FlujosDocumentos.IdFlujoDoc)"
        'sql &= " 				"
        'sql &= " 			 )"
        'sql &= " )"
        'sql &= " ) is null "

        '3) flujos que el siguiente paso le toquen al usuario designado en pasos
        sql &= " or (select top 1 Usuarios from FlujosTrabajoPasos "
        sql &= " where FlujosTrabajoPasos.IdFlujo = FlujosDocumentos.IdFlujo"
        sql &= " and IdPaso = "
        sql &= " (select IdSiguientePaso "
        sql &= " 		from  FlujosTrabajoPasos as ftp "
        sql &= " 		where ftp.IdFlujo = FlujosDocumentos.IdFlujo "
        sql &= " 		and ftp.IdPaso = "
        sql &= " 			 (select IdPaso from FlujosDocumentosPasos "
        sql &= " 				where FlujosDocumentosPasos.IdFlujoDoc = FlujosDocumentos.IdFlujoDoc"
        sql &= " 				and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = FlujosDocumentos.IdFlujoDoc)"
        sql &= " 			 )"
        sql &= " )"
        sql &= " ) like '%" & StiGlobalConn.User & "%'"


        'el coordinador ve la continuidas de los flujos
        sql &= " or ( "
        sql &= " (select top 1 FlujosCategorias.Coordinadores from FlujosCategorias inner join FlujosTrabajo on FlujosTrabajo.CategoriaFlujo = FlujosCategorias.IdCategoria where FlujosTrabajo.IdFlujo = FlujosDocumentos.IdFlujo) like '%" & StiGlobalConn.User & "%'"
        sql &= " )"

        sql &= " )"
        If VisibilidadUsuario() = "D" Then
            sql &= " and (select count(*) from polizas as pol where pol.idpoliza = FlujosDocumentos.idpoliza and pol.idproducto = FlujosDocumentos.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

        Me.Filtro = sql
    End Sub

    Private Sub ContinuarFlujoNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        'programaremos el format style condition
        Try
            Me.VistaNav.FormatConditions.Clear()

            Dim FormatoAstraso As New DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual, Me.VistaNav.Columns("Horas"), Nothing, Val(clSeguros.ObtenerDBParametros("Flujo.Horas.Atraso")), Nothing, True)
            FormatoAstraso.Appearance.BackColor = Color.White
            FormatoAstraso.Appearance.ForeColor = Color.Red
            Me.VistaNav.FormatConditions.Add(FormatoAstraso)

            Me.VistaNav.Columns("FechaInicia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.VistaNav.Columns("FechaInicia").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"

            Me.VistaNav.Columns("FechaFinaliza").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.VistaNav.Columns("FechaFinaliza").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"

            Me.VistaNav.Columns("Incluir").OptionsColumn.AllowEdit = True
            Me.VistaNav.Columns("Incluir").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Me.VistaNav.Columns("Incluir").OptionsFilter.AllowAutoFilter = False


            Me.GridNav.RepositoryItems.Clear()
            RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()

            Me.GridNav.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})

            Me.RepositoryItemCheckEdit1.AutoHeight = False
            Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
            CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()

            Me.VistaNav.OptionsBehavior.Editable = True
            For I As Integer = 0 To Me.VistaNav.Columns.Count - 1
                Select Case VistaNav.Columns(I).FieldName
                    Case "Incluir"
                        VistaNav.Columns(I).OptionsColumn.AllowEdit = True
                    Case Else
                        VistaNav.Columns(I).OptionsColumn.AllowEdit = False
                End Select
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        VistaNav.PostEditor()
    End Sub

    Private Sub ContinuarFlujoNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 20
            Me.GridNav.Height = Me.Height - 75
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'vamos a marcar todos los flujos marcados como finalizados.
        Dim NumFlujos As Integer = 0
        Dim Observaciones As String = "", IdFlujoDoc As String = "", IdFlujo As String = "", Paso As String = ""
        Dim res As String = ""
        For I As Integer = 0 To Me.VistaNav.RowCount - 1
            If Me.VistaNav.GetRowCellValue(I, "Incluir") = True Then
                NumFlujos += 1
                If Observaciones = "" Then
                    Observaciones = InputBox("Debe especificar la razón de finalización de los flujos:", "Observación", "")
                End If
                If Observaciones = "" Then
                    MsgBox("Debe especificar el motivo de finalización de los flujos.", MsgBoxStyle.Exclamation, "AVISO...")
                    Exit Sub
                End If

                'ahora al flujos marcarlo con el último paso y dejarle la observación.
                IdFlujoDoc = Me.VistaNav.GetRowCellValue(I, "IdFlujoDoc")
                Try
                    IdFlujo = StiGlobalConn.ObtenerDataset("select IdFlujo from FlujosDocumentos where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)).Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    IdFlujo = ""
                End Try
                Try
                    Paso = StiGlobalConn.ObtenerDataset("select top 1 IdPaso from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and EsPasoFinal = 'S' order by IdPaso desc").Tables(0).Rows(0).Item(0)
                Catch ex As Exception
                    Paso = ""
                End Try
                If Paso = "" Then
                    MsgBox("No se puede determinar el paso final para el flujo " & IdFlujoDoc & ", verifique la configuración en seguridad del flujo: " & IdFlujo, MsgBoxStyle.Critical, "ERROR...")
                Else
                    res = ""
                    res = clFlujos.ContinuarFlujo(IdFlujoDoc, Paso, Observaciones)

                    Try
                        Dim sql As String = ""
                        sql = " update FlujosDocumentos "
                        sql &= " set EstadoUsuario = " & dbStr(Observaciones)
                        sql &= " where IdFlujoDoc = " & dbStr(IdFlujoDoc, 25)
                        StiGlobalConn.SQLExecute(sql)
                    Catch ex As Exception

                    End Try

                    If res <> "" Then
                        MsgBox("El flujo " & IdFlujoDoc & " no ha podido actualizarse: " & vbCrLf & res, MsgBoxStyle.Critical, "ERROR...")
                    End If
                End If
            End If
        Next
        If NumFlujos > 0 Then
            Me.CargarRegistros()
            MsgBox("Se han Finalizado " & NumFlujos & " flujos exitosamente.", MsgBoxStyle.Information, "AVISO...")
        Else
            MsgBox("Debe marcar los flujos que desea finalizar.", MsgBoxStyle.Information, "AVISO...")
        End If
    End Sub

    Private Sub FinalizarFlujosNav_VistaNavClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VistaNavClick
        Try
            Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = VistaNav.CalcHitInfo(VistaNav.GridControl.PointToClient(MousePosition))
            If info.Column.FieldName = "Incluir" Then  'la columna incluir
                Me.Cursor = Cursors.WaitCursor
                Dim Valor1 As Boolean = VistaNav.GetRowCellValue(0, "Incluir")
                Valor1 = Not Valor1
                For NF As Integer = 0 To Me.VistaNav.RowCount - 1
                    If NF Mod 25 = 0 Then Application.DoEvents()
                    VistaNav.SetRowCellValue(NF, "Incluir", Valor1)
                Next
            End If
        Catch ex As Exception

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class
