Imports Utilerias.Genericas

Public Class RepDepositos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            If txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha desde.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha hasta.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            sql = "  select IdCliente, NombreCliente"
            sql &= " from Depositos as d "
            sql &= " where exists (select IdCliente from DepositosMovimientos as m where m.IdCliente = d.IdCliente and m.FechaMovimiento between " & dbFec(Me.txtFechaDesde.Valor) & " and " & dbFec(Me.txtFechaHasta.Valor) & ")"
            Dim dtClientes As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtClientes.TableName = "Clientes"

            sql = "  select IdCliente "
            sql &= " , a.Nombre as Aseguradora"
            sql &= " ,m.IdTipo as Tipo"
            sql &= " ,m.FechaMovimiento"
            sql &= " ,m.Descripcion"
            sql &= " ,m.ValorDeposito as Valor"
            sql &= " from DepositosMovimientos as m"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = m.idaseguradora"
            sql &= " where m.FechaMovimiento between " & dbFec(Me.txtFechaDesde.Valor) & " and " & dbFec(Me.txtFechaHasta.Valor)

            Dim dtDepositos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDepositos.TableName = "Depositos"


            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtClientes.Copy)
            DsRep.Tables.Add(dtDepositos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repCRDepositos
            Reporte.SetDataSource(DsRep)
            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte,"NombreEmpresa",ObtenerParametro("Cliente"))
            SetRepFormulaString(Reporte,"Titulo1","Reporte Detallado Depòsitos de Clientes")
            SetRepFormulaString(Reporte,"Titulo2","Depósitos entre el " & Format(txtFechaDesde.Valor, "dd/MMM/yyyy") & " y el " & Format(txtFechaHasta.Valor, "dd/MMM/yyyy"))
            SetRepFormulaString(Reporte,"Titulo3","Reporte al " & Format(Date.Today, "Long Date"))
            SetRepFormulaString(Reporte,"UserLog",ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub RepDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
            txtFechaHasta.Valor = Date.Today

        Catch ex As Exception

        End Try
    End Sub

End Class
