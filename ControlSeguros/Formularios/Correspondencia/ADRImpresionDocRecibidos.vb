imports Utilerias.Genericas

Public Class ADRImpresionDocRecibidos

    Private WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

    Private Sub ADRImpresionDocRecibidos_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Dim Fecha As String = "", FechaHasta As String = ""
        If Me.txtFecha.Text = "" Then
            Fecha = Date.Today.ToShortDateString
            FechaHasta = Date.Today.ToShortDateString
        Else
            Fecha = Me.txtFecha.Valor
            FechaHasta = Me.txtFechaHasta.Valor
        End If

        Me.Filtro = "FlujosDocumentosImpresiones.TipoFlujo = 'ENTRADA' and FlujosDocumentosImpresiones.FechaAnulacion is null and FlujosDocumentosImpresiones.doc_impreso is null and cast(convert(char(8),FlujosDocumentosImpresiones.FechaImpresion,112) as datetime) between " & dbFec(Fecha) & " and " & dbFec(FechaHasta)
        Dim paramvis As String = clSeguros.ObtenerDBParametros("Coor.Imp.DocRec")
        If paramvis.Trim.ToUpper = "U" Then
            'se mostrarán los flujos creados por el usuario
            'Me.Filtro &= " and (select count(*) from FlujosDocumentos where FlujosDocumentos.IdFlujoDoc = FlujosDocumentosImpresiones.IdFlujoDoc and FlujosDocumentos.IdUsuarioDestino = " & dbStr(StiGlobalConn.User, 25) & ") > 0"
            Me.Filtro &= " and FlujosDocumentosImpresiones.UsuarioImprime = " & dbStr(StiGlobalConn.User, 25)
        End If

        If VisibilidadUsuario() = "D" Then
            Me.Filtro &= " and (select count(*) from polizas as pol inner join FlujosDocumentos as f on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto where f.IdFlujoDoc = FlujosDocumentosImpresiones.IdFlujoDoc and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub

    Private Sub ADRImpresionDocRecibidos_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        'marcarmos columnas que no se editaran
        VistaNav.OptionsBehavior.Editable = True

        Call PrepararEditores()
    End Sub

    Private Sub ADRImpresionDocRecibidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try

        Me.txtFecha.Valor = Date.Today
        Me.txtFechaHasta.Valor = Date.Today

        Me.cboIdUsuario.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdUsuario.Llenar_Combo()
        Me.cboIdUsuario.OcultarColumna(0)

    End Sub

    Private Sub PrepararEditores()

        Me.GridNav.RepositoryItems.Clear()
        RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridNav.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})

        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = ""
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VistaNav.Columns("RecibeCorrespondencia").ColumnEdit = Me.RepositoryItemTextEdit1

        Me.VistaNav.OptionsBehavior.Editable = True
        For I As Integer = 0 To Me.VistaNav.Columns.Count - 1
            Select Case VistaNav.Columns(I).FieldName
                Case "Marcar"
                    VistaNav.Columns(I).OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                    VistaNav.Columns(I).OptionsFilter.AllowFilter = False
                    VistaNav.Columns(I).OptionsFilter.AllowAutoFilter = False
                    VistaNav.Columns(I).OptionsColumn.AllowEdit = True
                Case "RecibeCorrespondencia"
                    VistaNav.Columns(I).OptionsColumn.AllowEdit = True
                Case Else
                    VistaNav.Columns(I).OptionsColumn.AllowEdit = False

            End Select
        Next
    End Sub

    Private Sub txtFecha_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFecha.ValueChangeOnExit
        Me.CargarRegistros()
    End Sub

    Private Sub txtFechaHasta_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaHasta.ValueChangeOnExit
        Me.CargarRegistros()
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 20
            Me.GridNav.Height = Me.Height - 135
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ADRImpresionDocRecibidos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RepositoryItemTextEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemTextEdit1.EditValueChanged
        'actualimos el campos
        Try
            VistaNav.PostEditor()
            Dim Fila As Integer = Me.VistaNav.FocusedRowHandle
            Dim IdFlujoDoc As String = CStr(VistaNav.GetRowCellValue(Fila, "IdFlujoDoc"))
            Dim IdImpresion As String = CStr(VistaNav.GetRowCellValue(Fila, "IdImpresion"))
            Dim Recibe As String = CStr(VistaNav.GetRowCellValue(Fila, "RecibeCorrespondencia"))

            If IdFlujoDoc <> "" And IdImpresion <> "" Then
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set RecibeCorrespondencia = " & dbStr(Recibe, 100) & " where IdFlujoDoc = " & dbStr(IdFlujoDoc) & " and IdImpresion = " & dbStr(IdImpresion))
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'haremos una lista de los documentos que se marcaron
        Dim Fecha As String = "", FechaHasta As String = ""
        If Me.txtFecha.Text = "" Then
            Fecha = Date.Today.ToShortDateString
            FechaHasta = Date.Today.ToShortDateString
        Else
            Fecha = Me.txtFecha.Valor
            FechaHasta = Me.txtFechaHasta.Valor
        End If
        Dim lstDoc As String = ""
        For I As Integer = 0 To Me.VistaNav.RowCount - 1
            If Me.VistaNav.GetRowCellValue(I, "Marcar") = True Then
                If lstDoc = "" Then
                    lstDoc &= dbStr(VistaNav.GetRowCellValue(I, "IdFlujoDoc") & "*" & VistaNav.GetRowCellValue(I, "IdImpresion"))
                Else
                    lstDoc &= "," & dbStr(VistaNav.GetRowCellValue(I, "IdFlujoDoc") & "*" & VistaNav.GetRowCellValue(I, "IdImpresion"))
                End If
            End If
        Next
        If lstDoc <> "" Then
            Call GenerarReporteControl("ENTRADA", Fecha, FechaHasta, "", 0, "", "", lstDoc)
            Me.CargarRegistros()
        Else
            MsgBox("Debe marcar al menos un documento para imprimir.", MsgBoxStyle.Information, "AVISO...")
        End If

    End Sub

End Class
