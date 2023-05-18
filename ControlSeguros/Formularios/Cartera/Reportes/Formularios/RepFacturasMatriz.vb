Imports Utilerias.Genericas

Public Class RepFacturasMatriz

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                txtIdPoliza.Valor = stiSplit(busCodigo, "G0|1")
                cboIdProducto.Valor = stiSplit(busCodigo, "G1|1")
                Dim filpol As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde from polizas where idproducto = " & dbStr(cboIdProducto.Valor) & " and idpoliza = " & dbStr(txtIdPoliza.Valor)).Tables(0).Rows(0)
                Me.txtFecha.Valor = dbData(filpol, "VigenciaDesde")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepFacturasMatriz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim Obligatorios As String = Me.ValidarCamposObligatorios(Me)
            If Obligatorios <> "" Then
                MsgBox("Debe completar los campos obligatorios: " & Obligatorios, MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            Dim sql As String = ""

            sql &= "  select "
            sql &= " f.IdPoliza as Poliza"
            sql &= ", f.NombreCliente"
            sql &= ", f.NumCuota as DiasVence"
            sql &= ", f.FechaPago"
            sql &= ", (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo and m.TipoMovimiento in ('EMISION', 'ANULACION') ) as Total"
            sql &= ", f.NumeroFactura"
            sql &= ", (select top 1 FechaMovimiento from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo and m.TipoMovimiento = 'PAGO' ) as FechaVence"
            sql &= ", (select sum(Total * -1) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.IdRamo = f.IdRamo and m.TipoMovimiento = 'PAGO' ) as PrimaNeta"
            sql &= " from Facturas as f with (nolock)"
            sql &= " where f.idproducto = " & dbStr(cboIdProducto.Valor)
            sql &= " and f.FechaPago >= " & dbFec(Me.txtFecha.Valor)
            sql &= " and f.idpoliza like " & dbStr(Me.txtIdPoliza.Valor & "%")
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            sql &= " order by f.idpoliza, f.NumCuota"
            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            dtDatos.TableName = "Primas"

            If dtDatos.Rows.Count = 0 Then
                MsgBox("No se han encontrado facturas con las condiciones especificadas.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim DsRep As New DataSet
            DsRep.Tables.Add(dtDatos.Copy)
            DsRep.Tables.Add(tblLogo.Copy)

            Dim rep As New frmReportes
            Dim Reporte As New repEstadoCuentaMatriz
            Reporte.SetDataSource(DsRep)
            ''Definiremos algunos datos del reporte
            SetRepFormulaString(Reporte, "Titulo1", "ESTADO DE CUENTA")
            SetRepFormulaString(Reporte, "UserLog", ObtenerLogUser())

            rep.CRViewer.ReportSource = Reporte
            rep.MdiParent = Me.MdiParent
            rep.Show()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub
End Class
