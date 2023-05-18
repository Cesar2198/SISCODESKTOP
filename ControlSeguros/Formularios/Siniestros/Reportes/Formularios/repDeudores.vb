Imports Utilerias.Genericas

Public Class repDeudores

    Private Sub repDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaCorte.Valor = Date.Today
        Me.cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboAseguradora.Llenar_Combo()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            If txtFechaCorte.Text = "" Then
                MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim NomFiltro As String = ""

            sql = "  select "
            sql &= " a.Nombre as Aseguradora"
            sql &= " , s.IdPoliza"
            sql &= " , p.Descripcion as Producto"
            sql &= " , s.IdCertificado"
            sql &= " , s.IdSiniestro"
            sql &= " , s.NombrePresentaReclamo"
            sql &= " , isnull((select sum(ValorDeudor) from SiniestrosDeudores as d where d.IdPoliza = s.IdPoliza and d.IdProducto = s.IdProducto and d.IdCertificado = s.IdCertificado and d.IdSiniestro = s.IdSiniestro and d.FechaDeudor <= " & dbFec(txtFechaCorte.Valor) & "),0) as TotalDeudores"
            sql &= " from Siniestros as s"
            sql &= " inner join Productos as p on s.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " where s.idsiniestro is not null"
            sql &= " and isnull((select sum(ValorDeudor) from SiniestrosDeudores as d where d.IdPoliza = s.IdPoliza and d.IdProducto = s.IdProducto and d.IdCertificado = s.IdCertificado and d.IdSiniestro = s.IdSiniestro and d.FechaDeudor <= " & dbFec(txtFechaCorte.Valor) & "),0) > 0 "
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = s.idpoliza and pol.idproducto = s.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            If cboAseguradora.Valor <> "" Then
                sql &= " and a.idaseguradora = " & dbStr(cboAseguradora.Valor)
            End If

            Dim dtSiniestros As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtSiniestros.TableName = "Siniestros"

            If dtSiniestros.Rows.Count = 0 Then
                MsgBox("No se encontraron saldos deudores varios con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
            Else
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtSiniestros.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes
                Dim Reporte As New repCRDeudoresVarios
                Reporte.SetDataSource(DsRep)

                ''Definiremos algunos datos del reporte
                SetRepFormulaString(Reporte,"NombreEmpresa",ObtenerParametro("Cliente"))
                SetRepFormulaString(Reporte,"Titulo1","Reporte Saldos Deudores Varios")
                SetRepFormulaString(Reporte,"Titulo2","Deudores Varios al " & Format(txtFechaCorte.Valor, "dd/MMM/yyyy"))
                SetRepFormulaString(Reporte,"Titulo3","Reporte al " & Format(Date.Today, "Long Date") & " " & NomFiltro)
                SetRepFormulaString(Reporte,"UserLog",ObtenerLogUser())

                rep.CRViewer.ReportSource = Reporte
                rep.MdiParent = Me.MdiParent
                rep.Show()
            End If
        Catch ex As Exception
            msgError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class
