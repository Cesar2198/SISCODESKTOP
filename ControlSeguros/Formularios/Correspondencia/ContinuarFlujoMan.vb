
Imports Utilerias.Genericas

Public Class ContinuarFlujoMan

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtIdFlujoDoc.Text = "" Then
            MsgBox("No se ha especificado el flujo del documento.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If cboSiguientePaso.Text = "" Then
            MsgBox("Debe especificar el siguiente paso del flujo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If txtObservaciones.Text = "" Then
            MsgBox("Debe especificar la observación del siguiente paso.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If cboDocFinal.Visible = True And cboDocFinal.Obligatorio = True And Me.cboDocFinal.Valor = "" Then
            MsgBox("Debe especificar el documento final.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim res As String = ""

        res = clFlujos.ContinuarFlujo(txtIdFlujoDoc.Valor, cboSiguientePaso.Valor, txtObservaciones.Valor)

        Try
            Dim sql As String = ""
            sql = " update FlujosDocumentos "
            sql &= " set EstadoUsuario = " & dbStr(txtObservaciones.Valor)
            sql &= " , PendientePor = " & dbStr(cboPendientePor.Valor, 100)
            sql &= " , IdImpresionFinal = " & dbStr(cboDocFinal.Valor, 25)
            sql &= " where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor, 25)
            StiGlobalConn.SQLExecute(sql)
        Catch ex As Exception

        End Try

        If res <> "" Then
            MsgBox("El flujo no ha podido actualizarse: " & vbCrLf & res, MsgBoxStyle.Critical, "ERROR...")
        Else
            Me.blnCambiosRealizados = True
            MsgBox("EL flujo ha sido actualizado con éxito", MsgBoxStyle.Information, "AVISO...")
            'para evitar las validaciones de cerrado
            Me.blnRegistroModificado = False
            Me.Close()
        End If
    End Sub

    Private Sub ContinuarFlujoMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim IdFlujo As String = ""
        Dim IdPaso As Integer = -1, FilPaso As DataRow
        If Me.dbCondicion <> "" Then
            txtIdFlujoDoc.Valor = Replace(stiSplit(Me.dbCondicion, "G1=1").Trim, "'", "")
            txtIdFlujoDoc.SoloLectura = True

            Try
                IdFlujo = StiGlobalConn.ObtenerDataset("select IdFlujo from FlujosDocumentos where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor, 25)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception
                IdFlujo = ""
            End Try

            ''llenaremos el combo con los pasos del flujo
            Me.cboSiguientePaso.Query = "select IdPaso as ID, DescripcionPaso as PASO, EsPasoFinal as [PASO FINAL] from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25)
            Me.cboSiguientePaso.StringConection = StiGlobalConn.ObtenerOledbConnectionString
            Me.cboSiguientePaso.Llenar_Combo()


            Dim PendientesPor As String = clSeguros.ObtenerDBParametros("Siniestro.PendientePor")
            Dim lstPendPor As String = "", PendPor As String = ""
            For I As Integer = 0 To CuentaCar(PendientesPor, ",")
                PendPor = stiSplit(PendientesPor, "G" & I & ",1").Trim
                If PendPor <> "" Then
                    If lstPendPor = "" Then
                        lstPendPor &= PendPor & " " & PendPor
                    Else
                        lstPendPor &= "|" & PendPor & " " & PendPor
                    End If
                End If
            Next
            Me.cboPendientePor.Lista = lstPendPor
            Me.cboPendientePor.Llenar_Combo()
            Me.cboPendientePor.OcultarColumna(1)

            Me.cboDocFinal.Query = "select IdImpresion, convert(varchar,FechaImpresion,103) + ' ' + cast(Descripcion as varchar(max)) as Descripcion from FlujosDocumentosImpresiones where TipoFlujo = 'SALIDA' and IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor)
            Me.cboDocFinal.StringConection = StiGlobalConn.ObtenerOledbConnectionString
            Me.cboDocFinal.Llenar_Combo()

            Select Case GlobalCodCliente
                Case "2120000"
                    Me.cboDocFinal.Visible = True
                Case Else
                    Me.cboDocFinal.Visible = False
            End Select

            Try
                cboPendientePor.Valor = StiGlobalConn.ObtenerDataset("select PendientePor from FlujosDocumentos where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor, 25)).Tables(0).Rows(0).Item(0)
            Catch ex As Exception

            End Try

            ''propondremos el siguiente paso a seguir en el flujo.
            Try
                'para buscar el siguiente paso, primero verificamos el último paso del flujo actual
                'y obtenermos el siguiente paso marcado, sino existe paso definido manualmente lo buscamos en orden consecutivo
                Dim PasoActual As Integer = StiGlobalConn.ObtenerDataset("select top 1 IdPaso from FlujosDocumentosPasos where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor, 25) & " order by Orden desc").Tables(0).Rows(0).Item(0)
                dim OpcionFlujo as string = clSeguros.ObtenerDBParametros("Flujos.Modo.Actualiza")
                If OpcionFlujo.trim.toupper = "A" then
                    IdPaso = PasoActual
                else
                    FilPaso = StiGlobalConn.ObtenerDataset("select IdSiguientePaso from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso = " & dbInt(PasoActual)).Tables(0).Rows(0)
                    If dbData(FilPaso, "IdSiguientePaso") <> "" Then IdPaso = CInt(dbData(FilPaso, "IdSiguientePaso"))
                    If IdPaso = -1 Then
                        FilPaso = StiGlobalConn.ObtenerDataset("select top 1 IdPaso from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso > " & dbInt(PasoActual) & " order by IdPaso asc").Tables(0).Rows(0)
                        IdPaso = CInt(dbData(FilPaso, "IdPaso"))
                    End If
                End If

            Catch ex As Exception
                IdPaso = -1
            End Try
            If IdPaso <> -1 Then Me.cboSiguientePaso.Valor = IdPaso
        End If
    End Sub

    Private Sub cboSiguientePaso_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSiguientePaso.EditValueChanged
        Try
            cboDocFinal.Obligatorio = False
            Select Case GlobalCodCliente
                Case "2120000"
                    Dim LstCliente As String = clSeguros.ObtenerDBParametros("Flujos.Lista.CliObligaDoc")
                    If LstCliente <> "" Then
                        'determinamos el cliente del flujo
                        Dim IdCliente As String = StiGlobalConn.ObtenerDataset("select IdCliente from FlujosDocumentos where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Text)).Tables(0).Rows(0).Item(0)

                        If ExisteItemEnLista(IdCliente, LstCliente) = True Or LstCliente = "T" Then
                            'validamos que si es el último paso que el campos cboDocFinal sea obligatorio
                            Dim IdFlujo As String = StiGlobalConn.ObtenerDataset("select IdFlujo from FlujosDocumentos where IdFlujoDoc = " & dbStr(txtIdFlujoDoc.Valor, 25)).Tables(0).Rows(0).Item(0)
                            Dim EsFinal As Integer = StiGlobalConn.ObtenerDataset("select count(IdPaso) from FlujosTrabajoPasos where IdFlujo = " & dbStr(IdFlujo, 25) & " and IdPaso = " & dbInt(cboSiguientePaso.Valor) & " and EsPasoFinal = 'S' ").Tables(0).Rows(0).Item(0)
                            If EsFinal > 0 Then
                                cboDocFinal.Obligatorio = True
                            End If
                        End If
                    End If
            End Select

        Catch ex As Exception

        End Try
    End Sub

End Class
