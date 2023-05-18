Imports Utilerias.Genericas

Public Class EnvioDocumentoSimple

    Dim IdFlujoDefault As String = ""

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub EnvioDocumentoSimple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboRuta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboRuta.Llenar_Combo()

        Me.cboIdUsuario.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdUsuario.Llenar_Combo()

        Try
            IdFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
        Catch ex As Exception
            IdFlujoDefault = ""
        End Try

        If IdFlujoDefault = "" Then
            MsgBox("Debe especificar en parámetros el flujo por default, en el parámetro: Id.Flujo.Default", MsgBoxStyle.Information, "AVISO...")
            Me.btnImprimir.Enabled = False
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim Obligatorios As String = Me.ValidarCamposObligatorios(Me)
        If Obligatorios <> "" Then
            MsgBox("Debe completar los datos obligatorios:" & vbCrLf & Obligatorios, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Dim IdCorrespondencia As String = ""
        clFlujos.RegistrarDocumento(IdFlujoDefault, txtDetalle.Valor, "", "", "SALIDA", IdCorrespondencia, "", txtFecha.Valor, NombreAtt:=txtConfirmacion.Text, CodigoImpresionDocumento:="VA")

        'ruteamos el documento
        Dim strSQL As String = ""
        strSQL = "  update FlujosDocumentosImpresiones set "
        strSQL &= " FechaMovimiento = " & dbFec(Date.Now, "1")
        strSQL &= " ,FechaEnvio = " & dbFec(txtFecha.Valor)
        strSQL &= " ,IdZona = " & dbStr(cboRuta.Valor, 25)
        strSQL &= " ,IdUsuarioEntrega = " & dbStr(cboIdUsuario.Valor, 25)
        strSQL &= " ,DireccionDocumento = " & dbStr(txtLugar.Valor, 250)
        'nombre del cliente
        strSQL &= " ,IdOrigen = " & dbStr(txtCliente.Valor, 250)
        strSQL &= " where IdFlujoDoc = " & dbStr(IdFlujoDefault) & " and IdImpresion = " & dbStr(IdCorrespondencia)
        StiGlobalConn.SQLExecute(strSQL)

        MsgBox("Documento registrado con éxito.", MsgBoxStyle.Information, "AVISO...")
        Me.txtDetalle.Valor = ""
        Me.txtLugar.Valor = ""
        Me.txtConfirmacion.Valor = ""
        Me.txtFecha.Focus()
    End Sub

End Class
