Imports Utilerias.Genericas

Public Class RecibirDocumentos

    Dim dtCheques As DataTable

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        Dim sql As String = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                sql = "  select c.NombreCliente "
                sql &= " from Clientes as c"
                sql &= " where idcliente = " & dbStr(busCodigo)
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")
                Me.cboFlujo.Focus()
            Catch ex As Exception

            End Try
            Me.txtDescripcion.Focus()
        End If
        Call CargarFlujos()
    End Sub

    Private Sub CargarFlujos()
        Try
            If Me.chkDocSiniestro.Checked = False Then
                If txtIdCliente.Text <> "" Then
                    'flitraremos los flujos pendientes del cliente
                    Me.cboFlujo.Query = "select d.IdFlujoDoc as IdFlujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                Else
                    Me.cboFlujo.Query = "select d.IdFlujoDoc as IdFlujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE' "
                End If
            Else
                If txtIdCliente.Text <> "" Then
                    'flitraremos los flujos pendientes del cliente
                    Me.cboFlujo.Query = "select d.IdFlujoDoc as IdFlujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente, s.IdSiniestro as [Num. Siniestro], s.NombrePresentaReclamo as Dependiente, s.TotalPresentado as [Monto Reclamado], s.IdEnvio as [Número Envío], c.FechaEnvio as [Fecha Envío], s.NoFolioReferencia as [NO.OFICIO/CARTA REF.] from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo left join Siniestros as s on s.IdPoliza = d.IdPoliza and s.IdProducto = d.IdProducto and s.IdSiniestro = d.IdSiniestro left join EnviosSiniestros as c on c.IdEnvio = s.IdEnvio where d.estadoflujo = 'PENDIENTE' and d.IdSiniestro is not null and d.IdCliente = " & dbStr(txtIdCliente.Valor)
                Else
                    Me.cboFlujo.Query = "select d.IdFlujoDoc as IdFlujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente, s.IdSiniestro as [Num. Siniestro], s.NombrePresentaReclamo as Dependiente, s.TotalPresentado as [Monto Reclamado], s.IdEnvio as [Número Envío], c.FechaEnvio as [Fecha Envío], s.NoFolioReferencia as [NO.OFICIO/CARTA REF.] from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo left join Siniestros as s on s.IdPoliza = d.IdPoliza and s.IdProducto = d.IdProducto and s.IdSiniestro = d.IdSiniestro left join EnviosSiniestros as c on c.IdEnvio = s.IdEnvio where d.estadoflujo = 'PENDIENTE' and d.IdSiniestro is not null"
                End If
            End If
            Me.cboFlujo.Llenar_Combo()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFlujo_NewItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFlujo.NewItem
        Try
            Dim frmNF As New NuevoFlujo
            frmNF.STIConn = StiGlobalConn
            frmNF.Permiso = Me.Permiso
            frmNF.IdClienteDefault = Me.txtIdCliente.Valor
            frmNF.ObservacionDefault = Me.txtDescripcion.Valor
            frmNF.ShowDialog()

            'actualizamos la lista de flujos
            Me.cboFlujo.Llenar_Combo()

            'PROPONEMOS EL PRIMER FLUJO
            cboFlujo.Valor = ""
            If cboFlujo.ItemCount = 1 Then Me.cboFlujo.SelectIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFlujo_ValueChangeOnExit(ByVal sender As Object, ByVal e As System.EventArgs, ByVal ValorAnterior As String) Handles cboFlujo.ValueChangeOnExit
        'buscaremos si el nombre del flujo existe en la lista de documentos
        Try
            Dim NombreFlujo As String = StiGlobalConn.ObtenerDataset("select b.Descripcion from FlujosDocumentos as a inner join FlujosTrabajo as b on a.idflujo = b.idflujo where a.IdFlujoDoc = " & dbStr(cboFlujo.Valor)).Tables(0).Rows(0).Item(0)
            Me.cboTipoDocumento.Valor = NombreFlujo

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ''If cboFlujo.Text = "" Then
        ''    MsgBox("Debe especificar el flujo para el documento recibido.", MsgBoxStyle.Information, "AVISO...")
        ''    Exit Sub
        ''End If

        ''If txtDescripcion.Text = "" Then
        ''    MsgBox("Debe especificar la descripción del documento recibido.", MsgBoxStyle.Information, "AVISO...")
        ''    Exit Sub
        ''End If

        ''If Me.cboEjecutivoCta.Text = "" Then
        ''    MsgBox("Debe especificar el destinatario del documento.", MsgBoxStyle.Information, "AVISO...")
        ''    Exit Sub
        ''End If
        Dim Validacion As String = Me.ValidarCamposObligatorios(Me)
        If Validacion <> "" Then
            MsgBox("Debe especificar los datos de los campos obligatorios." & vbCrLf & Validacion, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim IdFlujoDoc As String = Me.cboFlujo.Valor
            Dim IdImpresion As String = ""

            Dim res As String = clFlujos.RegistrarDocumento(IdFlujoDoc, txtDescripcion.Valor, txtIdCliente.Valor, "", "ENTRADA", IdImpresion, cboEjecutivoCta.Valor, Me.txtFechaEnDocumento.Valor, CodigoImpresionDocumento:="VA", TipoDeDocumento:=cboTipoDocumento.Valor, NumeroDeDocumentos:=txtCantidadDocumento.Valor)

            If res <> "" Then
                MsgBox("Error al registrar el documento." & vbCrLf & res, MsgBoxStyle.Exclamation, "ERROR...")
            Else
                'registramos los cheques si existen
                Dim sql As String = ""
                Try
                    For Each filCh As DataRow In Me.dtCheques.Rows
                        sql = "insert into FlujosDocumentosImpresionesCheques"
                        sql &= "(IdFlujoDoc, IdImpresion, IdCheque, IdBanco, Beneficiario, NumCheque, Valor, Concepto, Anexo) values ("
                        sql &= dbStr(IdFlujoDoc, 25) & ", " & dbStr(IdImpresion, 25) & ", " & dbStr(dbData(filCh, "Id"), 25) & ", " & dbStr(dbData(filCh, "IdBanco"), 25) & ", " & dbStr(dbData(filCh, "Beneficiario"), 500) & ", " & dbStr(dbData(filCh, "NumCheque"), 50) & ", " & dbNum(dbData(filCh, "Valor")) & ", " & dbStr(dbData(filCh, "Concepto"), 250) & ", " & dbStr(dbData(filCh, "Anexo"), 250) & ") "
                        StiGlobalConn.SQLExecute(sql)
                    Next
                Catch ex As Exception

                End Try

                Me.txtIdCliente.Valor = ""
                Me.txtDescripcion.Valor = ""
                Me.txtNombreCliente.Valor = ""
                Me.cboFlujo.Query = "select d.IdFlujoDoc as Flujo ,f.Descripcion as Flujo, d.Comentario, d.FechaInicia as Fecha, d.IdPoliza as [Póliza], d.NombreCliente as Cliente from FlujosDocumentos as d inner join FlujosTrabajo as f on d.IdFlujo = f.IdFlujo where d.estadoflujo = 'PENDIENTE'  "
                Me.cboFlujo.Llenar_Combo()
                Me.cboFlujo.Valor = ""
                Me.btnBuscarCliente.Focus()
                cboEjecutivoCta.Valor = ""
                Me.txtFechaEnDocumento.Valor = Date.Today
                Me.txtCantidadDocumento.Valor = clSeguros.ObtenerDBParametros("Coor.NumDoc.Ingreso")

                Call IniciarTabla()

                MsgBox("El documento ha sido registrado con éxito.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub RecibirDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboFlujo.StringConection = StiGlobalConn.ObtenerOledbConnectionString

        Me.cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivoCta.Llenar_Combo()
        Me.cboEjecutivoCta.OcultarColumna(0)
        Me.txtFechaEnDocumento.Valor = Date.Today

        Call IniciarTabla()

        Dim TD As New DataTable
        TD.Columns.Add("Id", System.Type.GetType("System.String"))
        TD.Columns.Add("Tipo", System.Type.GetType("System.String"))
        Dim FilaTD As DataRow

        'llenaremos la lista de tipos de documentos
        Dim strLista As String = clSeguros.ObtenerDBParametros("Lista.Tipos.Documentos")
        Dim strItem As String = ""
        Dim strListaTipo As String = ""
        If strLista.Trim <> "" Then
            For I As Integer = 0 To Utilerias.Genericas.CuentaCar(strLista, ",")
                strItem = Strings.Left(Utilerias.Genericas.stiSplit(strLista, "G" & I & ",1").Trim, 50)
                FilaTD = TD.NewRow : FilaTD("Id") = strItem : FilaTD("Tipo") = strItem : TD.Rows.Add(FilaTD)
            Next
        End If
        cboTipoDocumento.Llenar_Combo(TD)
        cboTipoDocumento.OcultarColumna(0)
        Me.txtCantidadDocumento.Valor = clSeguros.ObtenerDBParametros("Coor.NumDoc.Ingreso")

        chkDocSiniestro.Checked = False
        Select Case GlobalCodCliente
            Case "2120000"
                chkDocSiniestro.Visible = True
                btnCheques.Visible = True
            Case Else
                chkDocSiniestro.Visible = False
                btnCheques.Visible = False
        End Select

        Call CargarFlujos()

    End Sub

    Private Sub chkDocSiniestro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDocSiniestro.CheckedChanged
        Call CargarFlujos()
    End Sub

    Private Sub IniciarTabla()
        dtCheques = New DataTable
        dtCheques.Columns.Add("Id", System.Type.GetType("System.Int32"))
        dtCheques.Columns.Add("IdBanco", System.Type.GetType("System.String"))
        dtCheques.Columns.Add("Beneficiario", System.Type.GetType("System.String"))
        dtCheques.Columns.Add("NumCheque", System.Type.GetType("System.String"))
        dtCheques.Columns.Add("Valor", System.Type.GetType("System.Double"))
        dtCheques.Columns.Add("Concepto", System.Type.GetType("System.String"))
        dtCheques.Columns.Add("Anexo", System.Type.GetType("System.String"))

    End Sub

    Private Sub btnCheques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheques.Click
        Dim frmCheque As New RecibirDocumentosCheques
        frmCheque.Permiso = Me.Permiso
        frmCheque.dtCheques = Me.dtCheques.Copy()
        frmCheque.ShowDialog(Me)
        Me.dtCheques = frmCheque.dtCheques.Copy()

        'pintamos los cheques
        txtDescripcion.Text = ""
        For Each filCheque As DataRow In dtCheques.Rows
            txtDescripcion.Text &= "#" & dbData(filCheque, "Id") & " " & getNomBanco(dbData(filCheque, "IdBanco")) & " BENEFICIARIO: " & dbData(filCheque, "Beneficiario") & " CHEQUE No.: " & dbData(filCheque, "NumCheque") & " MONTO: " & Val(dbData(filCheque, "Valor")).ToString("$#,###0.00") & " CONCEPTO: " & dbData(filCheque, "Concepto") & " ANEXOS: " & dbData(filCheque, "Anexo") & ", "
        Next
    End Sub

    Private Function getNomBanco(ByVal IdBanco As String) As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select NombreBanco from Bancos where idbanco = " & dbStr(IdBanco)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try

        Return res
    End Function

End Class
