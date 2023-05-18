Imports Utilerias.Genericas

Public Class RepGestionesCartera

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim sql As String = ""
            sql = "  select "
            sql &= " g.FechaGestion"
            sql &= " ,g.FechaProximaGestion"
            sql &= " ,g.Comentarios"
            sql &= " ,gor.NombreGestion as GestionHecha"
            sql &= " ,gfi.NombreGestion as GestionARealizar"
            sql &= " ,f.NombreCliente "
            sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
            sql &= " ,c.EMail"
            sql &= " ,f.NumeroFactura"
            sql &= " ,(select sum(m.Total) from FacturasMovimientos as m where f.NumeroFactura = m.NumeroFactura and f.IdProducto = m.IdProducto and f.IdPoliza = m.IdPoliza and f.IdRamo = m.IdRamo) as SaldoPendiente"
            sql &= ", case "
            sql &= " when (datediff(d,g.FechaProximaGestion," & dbFec(Me.txtFechaCorte.Valor) & ") = 0) then 'A - Fecha: Hoy' "
            sql &= " when (datediff(d,g.FechaProximaGestion," & dbFec(Me.txtFechaCorte.Valor) & ") between 1 and 7) then 'B - Fecha: Semana Pasada' "
            sql &= " else 'C- Fecha: Antiguo' "
            sql &= " end as PeriodoGestion"
            sql &= " ,u.NombreUsuario as Usuario, g.FechaGrabacion"

            sql &= " from Gestiones as g"
            sql &= " left join TipoGestion as gor on gor.IdTipoGestion = g.IdTipoGestion"
            sql &= " left join TipoGestion as gfi on gfi.IdTipoGestion = g.IdAccionTomar"
            sql &= " left join Facturas as f on f.NumeroFactura = g.NumeroFactura and f.IdProducto = g.IdProducto and f.IdPoliza = g.IdPoliza"
            sql &= " left join Clientes as c on c.idcliente = f.idcliente"
            sql &= " left join Usuarios as u on u.IdUsuario = g.IdUsuario"
            sql &= " where g.TipoGestion = 'C'"
            sql &= " and g.FechaProximaGestion <= " & dbFec(txtFechaCorte.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If
            sql &= " Order by g.FechaProximaGestion desc"
            Dim dsGestion As DataSet = StiGlobalConn.ObtenerDataset(sql)
            Me.GridGestion.DataSource = dsGestion.Tables(0)
            Me.GridGestion.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Gestiones" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridGestion.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Gestiones al " & Me.txtFechaCorte.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
            'AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub RepGestionesCartera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaCorte.Valor = Date.Today
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
