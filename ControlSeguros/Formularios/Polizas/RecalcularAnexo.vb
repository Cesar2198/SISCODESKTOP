Imports Utilerias.Genericas

Public Class RecalcularAnexo

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
                Dim filPol As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta, NombreCliente, IdFormaPago from Polizas where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0)
                Me.txtCliente.Valor = dbData(filPol, "NombreCliente")
                Me.txtDesde.Valor = dbData(filPol, "VigenciaDesde")
                Me.txtHasta.Valor = dbData(filPol, "VigenciaHasta")
                Me.cboFormaPago.Valor = dbData(filPol, "IdFormaPago")

                'ahora proponemos un año más
                Me.txtNuevaDesde.Valor = Me.txtDesde.Valor
                Me.txtNuevaHasta.Valor = Me.txtHasta.Valor
            Catch ex As Exception

            End Try
            Me.txtNuevaDesde.Focus()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
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

        If CDate(Me.txtNuevaDesde.Valor) < CDate(Me.txtDesde.Valor) Or CDate(txtNuevaDesde.Valor) > CDate(Me.txtHasta.Valor) Then
            MsgBox("La fecha del anexo debe estar entre la vigencia de la póliza.", MsgBoxStyle.Exclamation, "AVISO..")
            Exit Sub
        End If

        If CDate(Me.txtNuevaHasta.Valor) < CDate(Me.txtDesde.Valor) Or CDate(txtNuevaHasta.Valor) > CDate(Me.txtHasta.Valor) Then
            MsgBox("La fecha del anexo debe estar entre la vigencia de la póliza.", MsgBoxStyle.Exclamation, "AVISO..")
            Exit Sub
        End If

        If Me.cboFormaPago.Text = "" Then
            MsgBox("Debe especificar la forma de pago del cobro.", MsgBoxStyle.Exclamation, "AVISO..")
            Exit Sub
        End If

        If MsgBox("¿Confirma el anexo a la póliza?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "PREGUNTA...") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim Res As String = "", sql As String = ""
        Try
            Me.Cursor = Cursors.WaitCursor
            btnImprimir.Enabled = False
            StiGlobalConn.SQLExecute("BEGIN TRANSACTION")

            'ahora los certificados
            StiGlobalConn.SQLExecute("update PolizasCertificados set VigenciaDesde = " & dbFec(txtNuevaDesde.Valor) & ", VigenciaHasta = " & dbFec(txtNuevaHasta.Valor) & "  where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor) & " and RazonExclusion is null")

            'FINALMENTE RECALCULAMOS LAS PRIMAS
            Res = RecalcularPrimasPoliza(txtPoliza.Valor, cboProducto.Valor, cboFormaPago.Valor)
            If Res <> "" Then Throw New Exception(Res)

            'registramos el anexo
            sql = " insert into PolizasCertificadosAnexos (IdPoliza, IdProducto, IdCertificado, IdAnexo, FechaAnexo, UsuarioAnexo, VigenciaDesde, VigenciaHasta, FechaIngreso, FechaExclusion, SumaAseguradaAnterior, SumaAseguradaNueva, PrimaAnexo) "
            sql &= " select idpoliza, idproducto, idcertificado, (select isnull(max(PolizasCertificadosAnexos.IdAnexo),0) + 1 from PolizasCertificadosAnexos where PolizasCertificadosAnexos.idpoliza = PolizasCertificados.Idpoliza and PolizasCertificadosAnexos.idproducto = PolizasCertificados.idproducto and PolizasCertificadosAnexos.idcertificado = PolizasCertificados.idcertificado), getdate(), " & dbStr(StiGlobalConn.User) & ", VigenciaDesde, VigenciaHasta, FechaInclusion, FechaExclusion, ValorAsegurado, ValorAsegurado, PrimaNeta "
            sql &= " from PolizasCertificados "
            sql &= " where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor) & " and RazonExclusion is null"

            StiGlobalConn.SQLExecute(sql)

            StiGlobalConn.SQLExecute("COMMIT TRANSACTION")
            MsgBox("Se han creado los anexos con éxito.", MsgBoxStyle.Information, "AVISO...")
            Me.LimpiarCampos(Me)

        Catch ex As Exception
            StiGlobalConn.SQLExecute("ROLLBACK TRANSACTION")
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
            btnImprimir.Enabled = True
        End Try
    End Sub

    Private Sub RecalcularAnexo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboProducto.Llenar_Combo()

        Me.cboFormaPago.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboFormaPago.Llenar_Combo()

    End Sub

End Class
