Imports Utilerias.Genericas

Public Class AsignarFlujoNav

    Private WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

    Private Sub AsignarFlujoNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        'revalidamos el filtro de registros
        'validamos que el usuarios activo tenga permiso de ver el paso que siguiente en el flujo
        Dim sql As String = ""

        sql = " FlujosDocumentos.EstadoFlujo = 'PENDIENTE' and (FlujosDocumentos.IdUsuarioDestino is null "
        'que el paso actual sea asignación.
        sql &= " or "
        sql &= " (select top 1 RequiereAsignacion from FlujosTrabajoPasos "
        sql &= " where FlujosTrabajoPasos.IdFlujo = FlujosDocumentos.IdFlujo"
        sql &= " and IdPaso = "
        sql &= " (select IdSiguientePaso "
        sql &= " 		from  FlujosTrabajoPasos as ftp "
        sql &= " 		where ftp.IdFlujo = FlujosDocumentos.IdFlujo "
        sql &= " 		and ftp.IdPaso = "
        sql &= " 			 (select IdPaso from FlujosDocumentosPasos "
        sql &= " 				where FlujosDocumentosPasos.IdFlujoDoc = FlujosDocumentos.IdFlujoDoc"
        sql &= " 				and Orden = (select max(orden) from FlujosDocumentosPasos where FlujosDocumentosPasos.IdFlujoDoc = FlujosDocumentos.IdFlujoDoc)"
        sql &= " 				"
        sql &= " 			 )"
        sql &= " )) = 'S' )"

        'el usuario debe ser coordinador del flujo
        sql &= " and ( (select FlujosCategorias.Coordinadores from FlujosCategorias inner join FlujosTrabajo on FlujosTrabajo.CategoriaFlujo = FlujosCategorias.IdCategoria where FlujosTrabajo.IdFlujo = FlujosDocumentos.IdFlujo) like " & dbStr("%" & StiGlobalConn.User & "%")
        sql &= " or (select FlujosCategorias.Coordinadores from FlujosCategorias inner join FlujosTrabajo on FlujosTrabajo.CategoriaFlujo = FlujosCategorias.IdCategoria where FlujosTrabajo.IdFlujo = FlujosDocumentos.IdFlujo) = '' "
        sql &= " or (select FlujosCategorias.Coordinadores from FlujosCategorias inner join FlujosTrabajo on FlujosTrabajo.CategoriaFlujo = FlujosCategorias.IdCategoria where FlujosTrabajo.IdFlujo = FlujosDocumentos.IdFlujo) is null) "
        If VisibilidadUsuario() = "D" Then
            sql &= " and (select count(*) from polizas as pol where pol.idpoliza = FlujosDocumentos.idpoliza and pol.idproducto = FlujosDocumentos.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

        Me.Filtro = sql
    End Sub

    Private Sub AsignarFlujoNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        'programaremos el format style condition
        Try
            Me.VistaNav.FormatConditions.Clear()

            Dim FormatoAstraso As New DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual, Me.VistaNav.Columns("Horas"), Nothing, Val(clSeguros.ObtenerDBParametros("Flujo.Horas.Atraso")), Nothing, True)
            FormatoAstraso.Appearance.BackColor = Color.White
            FormatoAstraso.Appearance.ForeColor = Color.Red
            Me.VistaNav.FormatConditions.Add(FormatoAstraso)

            ''FechaInicia, FechaFinaliza
            Try
                Me.VistaNav.Columns("FechaInicia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                Me.VistaNav.Columns("FechaInicia").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"

                Me.VistaNav.Columns("FechaFinaliza").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                Me.VistaNav.Columns("FechaFinaliza").DisplayFormat.FormatString = "dd/MMM/yyyy hh:mm:ss tt"

                Me.VistaNav.Columns("IdUsuarioDestino").OptionsFilter.AllowAutoFilter = False

                Me.VistaNav.Columns("Incluir").OptionsColumn.AllowEdit = True
                Me.VistaNav.Columns("Incluir").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                Me.VistaNav.Columns("Incluir").OptionsFilter.AllowAutoFilter = False

            Catch ex As Exception

            End Try

            Call ObtenerEjecutivos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ObtenerEjecutivos()
        Dim Ejecutivos As New DataTable
        Ejecutivos = StiGlobalConn.ObtenerDataset("select IdUsuario as Id, NombreUsuario as Ejecutivo from Usuarios where EsEjecutivo = 'S'").Tables(0)
        Me.GridNav.RepositoryItems.Clear()
        RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.GridNav.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCheckEdit1})

        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""

        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"

        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()

        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Ejecutivo"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = Ejecutivos
        RepositoryItemLookUpEdit1.PopulateColumns()
        RepositoryItemLookUpEdit1.Columns("Id").Visible = False
        Me.VistaNav.Columns("IdUsuarioDestino").ColumnEdit = Me.RepositoryItemLookUpEdit1

        Me.VistaNav.OptionsBehavior.Editable = True
        For I As Integer = 0 To Me.VistaNav.Columns.Count - 1
            Select Case VistaNav.Columns(I).FieldName
                Case "IdUsuarioDestino", "Incluir"
                    VistaNav.Columns(I).OptionsColumn.AllowEdit = True
                Case Else
                    VistaNav.Columns(I).OptionsColumn.AllowEdit = False
            End Select
        Next
    End Sub

    Private Sub ActualizarEjecutivo(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        VistaNav.PostEditor()

        'actualizamos el ejecutivo
        Dim Fila As Integer = Me.VistaNav.FocusedRowHandle
        If Fila >= 0 Then
            Dim Ejecutivo As String = Me.VistaNav.GetRowCellValue(Fila, "IdUsuarioDestino")
            Dim CodFlujo As String = Me.VistaNav.GetRowCellValue(Fila, "IdFlujoDoc")
            StiGlobalConn.SQLExecute("update FlujosDocumentos set IdUsuarioDestino = " & dbStr(Ejecutivo, 25) & ", UsuarioAsignacion = " & dbStr(StiGlobalConn.User, 25) & ", FechaAsignacion = " & dbFec(Date.Now, "1") & " where IdFlujoDoc = " & dbStr(CodFlujo))

            'refrescamos
            Me.CargarRegistros()
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        VistaNav.PostEditor()
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 20
            Me.GridNav.Height = Me.Height - 135
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClientesNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try

        cboEjecutivoCta.StringConection = STIConn.ObtenerOledbConnectionString
        cboEjecutivoCta.Llenar_Combo()

    End Sub

    Private Sub ClientesNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Overloads Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.cboEjecutivoCta.Valor = "" Then
            MsgBox("Debe seleccionar a un ejecutivo de cuenta.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Dim RegistrosModificados As Integer = 0

        For I As Integer = 0 To Me.VistaNav.RowCount - 1
            If Me.VistaNav.GetRowCellValue(I, "Incluir") = True Then
                Dim CodFlujo As String = Me.VistaNav.GetRowCellValue(I, "IdFlujoDoc")
                StiGlobalConn.SQLExecute("update FlujosDocumentos set IdUsuarioDestino = " & dbStr(cboEjecutivoCta.Valor, 25) & ", UsuarioAsignacion = " & dbStr(StiGlobalConn.User, 25) & ", FechaAsignacion = " & dbFec(Date.Now, "1") & " where IdFlujoDoc = " & dbStr(CodFlujo))
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set UsuarioImprime = " & dbStr(cboEjecutivoCta.Valor, 25) & " where IdFlujoDoc = " & dbStr(CodFlujo))
                RegistrosModificados += 1
            End If
        Next

        'refrescamos
        If RegistrosModificados > 0 Then
            Me.CargarRegistros()
            MsgBox("Los Flujos han sido asignados con éxito.", MsgBoxStyle.Information, "AVISO...")
        Else
            MsgBox("No se han marcado flujos para asignar ejecutivo.", MsgBoxStyle.Information, "AVISO...")
        End If



    End Sub

End Class
