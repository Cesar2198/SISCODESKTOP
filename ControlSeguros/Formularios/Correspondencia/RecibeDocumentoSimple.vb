Imports Utilerias.Genericas

Public Class RecibeDocumentoSimple

    Dim IdFlujoDefault As String = ""

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RecibeDocumentoSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
        Catch ex As Exception
            IdFlujoDefault = ""
        End Try

        If IdFlujoDefault = "" Then
            MsgBox("Debe especificar en parámetros el flujo por default, en el parámetro: Id.Flujo.Default", MsgBoxStyle.Information, "AVISO...")
            Me.btnImprimir.Enabled = False
        End If

        Me.cboUsuarios.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboUsuarios.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim Obligatorios As String = Me.ValidarCamposObligatorios(Me)
        If Obligatorios <> "" Then
            MsgBox("Debe completar los datos obligatorios:" & vbCrLf & Obligatorios, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Dim IdCorrespondencia As String = ""
        clFlujos.RegistrarDocumento(IdFlujoDefault, Me.txtDetalle.Valor, "", "", "ENTRADA", IdCorrespondencia, Me.txtDestinatario.Valor, Me.txtFecha.Valor, CodigoImpresionDocumento:="VA")

        'ruteamos el documento
        Dim strSQL As String = ""
        strSQL = "  update FlujosDocumentosImpresiones set "
        strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
        strSQL &= " ,FechaEnvio = " & dbFec(txtFecha.Valor)
        strSQL &= " ,IdOrigen = " & dbStr(Me.txtRemitente.Valor, 250)
        strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
        StiGlobalConn.SQLExecute(strSQL)

        MsgBox("Documento registrado con éxito.", MsgBoxStyle.Information, "AVISO...")
        Me.txtDetalle.Valor = ""
        Me.txtRemitente.Valor = ""
        Me.txtDestinatario.Valor = ""
        Me.cboUsuarios.Valor = ""
        Me.txtFecha.Focus()
    End Sub

    Private Sub cboUsuarios_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboUsuarios.ValueChangeOnExit
        txtDestinatario.Valor = cboUsuarios.Descripcion
    End Sub

End Class
