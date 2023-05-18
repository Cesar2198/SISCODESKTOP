
Imports Utilerias.Genericas

Public Class RenovarPoliza

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas Vigentes"
        Fbus.dbFiltro = " and p.MotivoCancelacion is null"
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim filPol As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta, NombreCliente, TipoPoliza from Polizas where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0)
                Me.txtCliente.Valor = dbData(filPol, "NombreCliente")
                Me.txtDesde.Valor = dbData(filPol, "VigenciaDesde")
                Me.txtHasta.Valor = dbData(filPol, "VigenciaHasta")
                Me.cboTipoPoliza.Valor = dbData(filPol, "TipoPoliza")

                'ahora proponemos un año más
                Me.txtNuevaDesde.Valor = Me.txtHasta.Valor
                Me.txtNuevaHasta.Valor = CDate(Me.txtNuevaDesde.Valor).AddYears(1)
            Catch ex As Exception

            End Try
            Me.txtNuevaDesde.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
            MsgBox("Debe especificar la póliza.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        If Me.txtNuevaDesde.Text.Trim = "" Or Me.txtNuevaHasta.Text.Trim = "" Then
            MsgBox("Debe especificar la nueva vigencia de renovación.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If CDate(Me.txtNuevaDesde.Valor) > CDate(Me.txtNuevaHasta.Valor) Then
            MsgBox("Error en la vigencia especificada, la vigencia desde no puede ser mayor a la vigencia hasta", MsgBoxStyle.Exclamation, "AVISO..")
            Exit Sub
        End If

        If CDate(Me.txtNuevaDesde.Valor) < CDate(Me.txtHasta.Valor) Then
            If MsgBox("Error en la vigencia especificada, la vigencia desde no puede ser menor a la vigencia hasta actual. ¿Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA..") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        If Me.cboTipoPoliza.Obligatorio = True And Me.cboTipoPoliza.Text = "" Then
            MsgBox("Debe especificar el tipo de póliza.", MsgBoxStyle.Exclamation, "AVISO..")
            Exit Sub
        End If


        If MsgBox("¿Confirma la renovación de la Póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Res As String = ""
        Try
            Me.Cursor = Cursors.WaitCursor
            btnGuardar.Enabled = False
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION REN")

            'primero haremos una copia de la poliza actual al historico
            Dim msgHistocio As String = clSeguros.RegistrarHistorioPoliza(txtPoliza.Valor, cboProducto.Valor)
            If msgHistocio <> "" Then Throw New Exception(" Error al registrar historico: " & msgHistocio)

            'primero Actualizamos la póliza
            StiGlobalConn.SQLExecute("update polizas set VigenciaDesde = " & dbFec(txtNuevaDesde.Valor) & ", VigenciaHasta = " & dbFec(txtNuevaHasta.Valor) & ", NumVigencia = NumVigencia + 1, ObservacionSiniestro = null, TipoPoliza = " & dbStr(cboTipoPoliza.Valor) & " where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor))

            'ahora los certificados
            StiGlobalConn.SQLExecute("update PolizasCertificados set VigenciaDesde = " & dbFec(txtNuevaDesde.Valor) & ", VigenciaHasta = " & dbFec(txtNuevaHasta.Valor) & "  where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor) & " and RazonExclusion is null")

            Dim msgflujo As String = clFlujos.IniciarFlujoRenovacionPoliza(txtPoliza.Valor, cboProducto.Valor)
            If msgflujo <> "" Then MsgBox(msgflujo, MsgBoxStyle.Information, "AVISO...")

            'FINALMENTE RECALCULAMOS LAS PRIMAS
            Res = RecalcularPrimasPoliza(txtPoliza.Valor, cboProducto.Valor, "")
            If Res <> "" Then Throw New Exception(Res)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION REN")
            MsgBox("La póliza, Certificado(s) han sido renovados con éxito.", MsgBoxStyle.Information, "AVISO...")
            Me.LimpiarCampos(Me)

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION REN")
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
            btnGuardar.Enabled = True
        End Try
    End Sub

    Private Sub RenovarPoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()

        Dim strLista As String = clSeguros.ObtenerDBParametros("Lista.Tipos.Polizas")
        Dim strListaTipo As String = ""
        Dim strItem As String = ""

        If strLista.Trim <> "" Then
            For I As Integer = 0 To Utilerias.Genericas.CuentaCar(strLista, ",")
                strItem = Strings.Left(Utilerias.Genericas.stiSplit(strLista, "G" & I & ",1").Trim, 150).Trim
                If strItem <> "" Then
                    If strListaTipo = "" Then
                        strListaTipo = Replace(strItem, " ", "_") & " " & strItem
                    Else
                        strListaTipo &= "|" & Replace(strItem, " ", "_") & " " & strItem
                    End If
                End If
            Next
        End If
        cboTipoPoliza.Lista = strListaTipo
        cboTipoPoliza.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboTipoPoliza.Llenar_Combo()

        Select Case GlobalCodCliente
            Case "2120000"
                cboTipoPoliza.Visible = True
                cboTipoPoliza.Obligatorio = True
                cboTipoPoliza.OcultarColumna(0)

            Case Else
                cboTipoPoliza.Visible = False
                cboTipoPoliza.Obligatorio = False
        End Select

    End Sub

End Class
