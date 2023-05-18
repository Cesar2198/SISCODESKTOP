imports Utilerias.Genericas

Public Class DesRutearDocumentoNav

    Private WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

    Private Sub DesRutearDocumentoNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        Dim Fecha As String = ""
        If Me.txtFecha.Text = "" Then
            Fecha = Date.Today.ToShortDateString
        Else
            Fecha = Me.txtFecha.Valor
        End If

        Me.Filtro = "TipoFlujo = 'SALIDA' and FechaEnvio is not null  and FechaAnulacion is null and cast(convert(char(8),FechaEnvio,112) as datetime) = " & dbFec(Fecha)
        If VisibilidadUsuario() = "D" Then
            Me.Filtro &= " and (select count(*) from polizas as pol inner join FlujosDocumentos as f on pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto where f.IdFlujoDoc = FlujosDocumentosImpresiones.IdFlujoDoc and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
        End If

    End Sub

    Private Sub DesRutearDocumentoNav_DespuesDeCargarRegistros() Handles Me.DespuesDeCargarRegistros
        'marcarmos columnas que no se editaran
        VistaNav.OptionsBehavior.Editable = True

        Call PrepararEditores()
    End Sub

    Private Sub DesRutearDocumentoNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FixGridSize()
        Catch ex As Exception

        End Try

        Me.txtFecha.Valor = Date.Today

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
        Me.Filtro = "TipoFlujo = 'SALIDA' and FechaEnvio is not null and FechaAnulacion is null and cast(convert(char(8),FechaEnvio,112) as datetime) = " & dbFec(Me.txtFecha.Valor)
        Me.CargarRegistros()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim IdFlujo As String = "", IdImpresion As String = ""
            Dim Motivo As String = InputBox("Motivo del DesRuteo de los documentos:", "Motivo...")
            If Motivo.Trim = "" Then
                MsgBox("Debe especificar el motivo.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            For NF As Integer = 0 To Me.VistaNav.DataRowCount - 1
                If Me.VistaNav.GetRowCellValue(NF, "Marcar") = True Then
                    IdFlujo = Me.VistaNav.GetRowCellValue(NF, "IdFlujoDoc")
                    IdImpresion = Me.VistaNav.GetRowCellValue(NF, "IdImpresion")
                    StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set FechaEnvio = null, IdZona = null, Courier = null where IdFlujoDoc = " & dbStr(IdFlujo) & " and IdImpresion = " & dbStr(IdImpresion))

                    StiGlobalConn.SQLExecute("insert into FlujosDocumentosImpresionesDes (IdFlujoDoc, IdImpresion, FechaDesruteo, UsuarioDesruteo, Motivo) values (" & dbStr(IdFlujo, 25) & C & dbStr(IdImpresion, 25) & C & dbFec(Date.Now, "1") & C & dbStr(StiGlobalConn.User, 25) & C & dbStr(Motivo, 250) & ")")

                    AgregarLogRuteo(IdFlujo, IdImpresion, False)
                End If
            Next
            Me.CargarRegistros()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            If cboIdUsuario.Valor = "" Then
                MsgBox("Debe especificar el nuevo usuario de entrega de la mensajería.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim IdFlujo As String = "", IdImpresion As String = ""
            Dim inteModificados As Integer = 0
            For NF As Integer = 0 To Me.VistaNav.DataRowCount - 1
                If Me.VistaNav.GetRowCellValue(NF, "Marcar") = True Then
                    IdFlujo = Me.VistaNav.GetRowCellValue(NF, "IdFlujoDoc")
                    IdImpresion = Me.VistaNav.GetRowCellValue(NF, "IdImpresion")
                    StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set IdUsuarioEntrega = " & dbStr(cboIdUsuario.Valor, 25) & " where IdFlujoDoc = " & dbStr(IdFlujo) & " and IdImpresion = " & dbStr(IdImpresion))
                    inteModificados += 1
                End If
            Next

            If inteModificados = 0 Then
                MsgBox("No ha seleccionado documentos para modificar usuario de entrega.", MsgBoxStyle.Information, "AVISO...")
            Else
                MsgBox("Se han modificado " & inteModificados.ToString & " documentos con el nuevo usuario de entrega.", MsgBoxStyle.Information, "AVISO...")
            End If
            Me.CargarRegistros()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 20
            Me.GridNav.Height = Me.Height - 135
            Me.GridNav.Anchor = AnchorStyles.Top + AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DesRutearDocumentoNav_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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

End Class
