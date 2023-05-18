Imports Utilerias.Genericas

Public Class RepClienteTarjetas

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String = ""

            Me.Cursor = Cursors.WaitCursor

            sql = "select * from Clientes"
            If cboEjecutivo.Valor <> "" Then
                sql &= " where EjecutivoCta = " & dbStr(cboEjecutivo.Valor)
            End If
            Dim dtCliente As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtCliente.TableName = "Clientes"

            sql = "  select a.IdCliente"
            sql &= " , ase.Nombre as Aseguradora"
            sql &= " , a.IdPoliza as Poliza"
            sql &= " , 'AC-' + cast(a.IdAvisoCobro as varchar) as AvisoCobro"
            sql &= " , isnull(replicate('*',DATALENGTH(a.NumeroTarjeta)-4),'') + isnull(right(a.NumeroTarjeta,4),'') as Tarjeta"
            sql &= " , a.VencimientoTarjeta as VenceTarjeta"
            sql &= " , P.Descripcion as Producto"
            sql &= " from AvisosCobro as a "
            sql &= " inner join Productos as P on a.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as ase on ase.idaseguradora = p.idaseguradora "
            sql &= " where a.NumeroTarjeta is not null and a.NumeroTarjeta <> '' "
            sql &= " and a.MotivoAnulacion is null"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = a.idpoliza and p.idproducto = a.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            'nota: las facturas del AC deben tener saldo
            If chkPago.Checked = True Then
                sql &= " and (select sum(fm.Total) from FacturasMovimientos as fm inner join AvisosCobroFacturas af on fm.IdPoliza = af.IdPoliza and fm.IdProducto = af.IdProducto and fm.NumeroFactura = af.NumeroFactura and fm.IdRamo = af.IdRamo where af.IdAvisoCobro = a.IdAvisoCobro) > 0 "
            End If


            Dim dtPolizas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtPolizas.TableName = "ClientesPolizas"

            If dtCliente.Rows.Count = 0 Or dtPolizas.Rows.Count = 0 Then
                MsgBox("No se encontraron clientes con cargo a tarjetas.", MsgBoxStyle.Information, "AVISO...")
            Else
                Dim DsRep As New DataSet
                DsRep.Tables.Add(dtCliente.Copy)
                DsRep.Tables.Add(dtPolizas.Copy)
                DsRep.Tables.Add(tblLogo.Copy)

                Dim rep As New frmReportes
                Dim Reporte As New RepClientesTarjeta
                Reporte.SetDataSource(DsRep)

                ''Definiremos algunos datos del reporte
                SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
                SetRepFormulaString(Reporte, "Titulo1", "Reporte de Clientes con Cargo a Tarjeta")
                SetRepFormulaString(Reporte, "Titulo2", "Reporte al " & Format(Date.Today, "Long Date"))
                SetRepFormulaString(Reporte, "Titulo3", "")
                SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepClienteTarjetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboEjecutivo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboEjecutivo.Llenar_Combo()
    End Sub
End Class
