Imports Utilerias.Genericas

Public Class ContinuarFlujoNav

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

        Catch ex As Exception

        End Try

        Try
            'formateamos los campos de fecha hora
            Me.VistaNav.Columns("FechaAsignacion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime : Me.VistaNav.Columns("FechaAsignacion").DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
            Me.VistaNav.Columns("FechaReAsignacion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime : Me.VistaNav.Columns("FechaReAsignacion").DisplayFormat.FormatString = "dd/MMM/yyyy HH:mm:ss"
        Catch ex As Exception

        End Try

        'ocultamos columnas
        Try
            VistaNav.Columns("Identificador").Visible = False : VistaNav.Columns("Identificador").OptionsColumn.AllowShowHide = False
        Catch ex As Exception

        End Try

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

    Private Sub ContinuarFlujoNav_VistaNavCustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles Me.VistaNavCustomColumnDisplayText
        Select Case GlobalCodCliente
            Case "2120000"
                If Me.VistaNav.GetRowCellValue(e.RowHandle, "Identificador") = 0 Then
                    Select Case e.Column.FieldName
                        Case "UsuarioAsignacion", "UsuarioReAsignacion", "FechaAsignacion", "FechaReAsignacion"
                            e.DisplayText = ""
                    End Select
                End If

        End Select

    End Sub

End Class
