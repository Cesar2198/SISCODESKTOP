imports Utilerias.Genericas

Public Class LstChequesIngreso

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        me.Close()
    End Sub

    Private Sub LstChequesIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        me.txtFechaDesde.Valor = date.Today()
        me.txtFechaHasta.Valor = date.Today()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Control Cheques " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.Vistacheques.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte de Cheques de Ingreso entre el " & Me.txtFechaDesde.Text.Trim.ToUpper & " al " & Me.txtFechaHasta.Text.Trim.ToUpper, "", "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"), clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        if me.txtFechaDesde.text = "" or me.txtFechaHasta.text = "" then
            msgbox("Debe Especificar las fecha de búsqueda.")
            exit sub
        End If

        try
            dim sql as string = "

            sql &= " Select "
            sql &= " i.FechaImpresion"
            sql &= " ,f.NombreCliente"
            sql &= " ,c.IdFlujoDoc"
            sql &= " ,c.IdImpresion"
            sql &= " ,c.IdCheque"
            sql &= " ,b.NombreBanco as Banco"
            sql &= " ,c.Beneficiario"
            sql &= " ,c.NumCheque"
            sql &= " ,c.Valor"
            sql &= " ,c.Concepto"
            sql &= " ,c.Anexo"
            sql &= " , i.NumCorrIngreso"
            sql &= " from FlujosDocumentosImpresionesCheques as c"
            sql &= " inner join FlujosDocumentosImpresiones as i on i.IdFlujoDoc = c.IdFlujoDoc and i.IdImpresion = c.IdImpresion"
            sql &= " inner join FlujosDocumentos as f on f.IdFlujoDoc = i.IdFlujoDoc"
            sql &= " left join Bancos as b on b.IdBanco = c.IdBanco"
            sql &= " where convert(datetime,convert(varchar,i.FechaImpresion,112)) between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            
            dim dtCheques as DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            gridCheques.DataSource = dtCheques
            gridCheques.Refresh()

            if dtCheques.Rows.Count = 0 then
                msgbox("No se encontraron cheques para las fechas especificadas.")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub gridCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridCheques.DoubleClick
        Try
            If Me.vistaCheques.FocusedRowHandle < 0 Or Me.Permiso.Trim.ToUpper <> "T" Then
                'no se ha selecionado registro, o no tiene permisos
                Exit Sub
            End If

            Dim FilaSel As Integer = Me.vistaCheques.FocusedRowHandle
            Dim tempAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly()
            Dim frmMod As New ChequesMan
            frmMod.dbTabla = "FlujosDocumentosImpresionesCheques"
            frmMod.STIConn = Me.STIConn
            frmMod.Permiso = Me.Permiso
            frmMod.dbCondicion = "IdFlujoDoc = " & dbStr(vistaCheques.GetRowCellValue(FilaSel, "IdFlujoDoc")) & " and IdImpresion = " & dbStr(vistaCheques.GetRowCellValue(FilaSel, "IdImpresion")) & " and IdCheque = " & dbStr(vistaCheques.GetRowCellValue(FilaSel, "IdCheque"))
            
            If clSeguros.ObtenerDBParametros("Multiples.Ventanas").ToString.Trim.ToUpper = "S" Then
                frmMod.MdiParent = Me.MdiParent
                frmMod.Show()
            Else
                frmMod.ShowDialog()
                'actualizamos los registros
                Try
                    If frmMod.blnCambiosRealizados = True Then
                        Call btnBuscar_Click(Nothing, Nothing)
                    End If
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            'no controlaremos el error
            msgError(ex)
        End Try
    End Sub

End Class
