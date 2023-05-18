Imports Utilerias.Genericas

Public Class AsignarFlujoInd

    Public IdFlujoDoc As String = ""

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub AsignarFlujoInd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboEjecutivoCta.StringConection = STIConn.ObtenerOledbConnectionString
            cboEjecutivoCta.Llenar_Combo()

            Me.cboFlujo.StringConection = STIConn.ObtenerOledbConnectionString
            Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.IdFlujoDoc = " & dbStr(IdFlujoDoc)
            Me.cboFlujo.Llenar_Combo()
            Me.cboFlujo.Valor = IdFlujoDoc

            cboEjecutivoCta.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If CStr(cboFlujo.Valor) = "" Then
            MsgBox("Debe estar seleccionado el flujo que se asignará.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If CStr(cboEjecutivoCta.Valor) = "" Then
            MsgBox("Debe seleccionar el ejecutivo al que se le asignará el flujo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'asignamos el flujo

        StiGlobalConn.SQLExecute("update FlujosDocumentos set IdUsuarioDestino = " & dbStr(cboEjecutivoCta.Valor, 25) & ", UsuarioAsignacion = " & dbStr(StiGlobalConn.User, 25) & ", FechaAsignacion = " & dbFec(Date.Now, "1") & " where IdFlujoDoc = " & dbStr(cboFlujo.Valor))
        StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set UsuarioImprime = " & dbStr(cboEjecutivoCta.Valor, 25) & " where IdFlujoDoc = " & dbStr(cboFlujo.Valor))

        'salimos

        Me.Close()

    End Sub

End Class
