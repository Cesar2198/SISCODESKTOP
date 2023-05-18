Imports Utilerias.Genericas

Public Class LstVencimientosTarjetas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnBuscarTarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTarjetas.Click
        Try
            Dim sql As String = ""

            sql = "  select distinct a.IdCliente, a.NombreCliente"
            sql &= " , a.IdPoliza, a.NumeroTarjeta"
            sql &= " , a.VencimientoTarjeta, p.descripcion as Producto, a.IdAvisoCobro"
            sql &= " , ase.nombre as Aseguradora"
            sql &= " , isnull((select u.NombreUsuario from usuarios as u where u.idusuario = c.EjecutivoCta),'') as Ejecutivo"
            sql &= ", isnull((select top 1 v.NombreVendedor from PolizasVendedores as pv inner join Vendedores as v on pv.IdVendedor = v.IdVendedor where pv.IdPoliza = a.IdPoliza and pv.IdProducto = a.IdProducto order by pv.Orden asc),'') as Vendedor"
            sql &= " from avisoscobro as a"
            sql &= " left join Clientes as c on c.idcliente = a.idcliente"
            sql &= " inner join productos as p on p.idproducto = a.idproducto"
            sql &= " inner join Aseguradoras as ase on ase.idaseguradora  = p.idaseguradora"
            sql &= " where a.numerotarjeta Is Not null And a.vencimientotarjeta Is Not null "
            sql &= " and (select sum(m.Total) from FacturasMovimientos as m inner join AvisosCobroFacturas as f on "
            sql &= " m.IdPoliza = f.IdPoliza and m.IdProducto = f.IdProducto  and m.NumeroFactura = f.NumeroFactura and m.IdRamo = f.IdRamo and f.IdAvisoCobro = a.IdAvisoCobro ) > 0 "
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as p where p.idpoliza = a.idpoliza and p.idproducto = a.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim Tarjetas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)

            Dim Fecha As DateTime, strFecha As String = "", HayTarjetas As Boolean = False
            Dim FilAC As DataRow
            For Each FilAC In Tarjetas.Rows
                strFecha = Replace(Replace(Replace(dbData(FilAC, "VencimientoTarjeta"), " ", ""), "/", ""), "-", "")
                If Len(strFecha) = 6 Or Len(strFecha) = 4 Then strFecha = "01" & strFecha
                Try
                    Fecha = CDate(ConvertirFecha(strFecha, FormatoFecha.FechaCorta))
                Catch ex As Exception
                    Fecha = Nothing
                End Try
                If Fecha <> Nothing Then
                    If Fecha >= CDate(txtFechaDesde.Valor) And Fecha <= CDate(txtFechaHasta.Valor) Then
                        HayTarjetas = True
                        If CStr(FilAC("NumeroTarjeta")).Length >= 4 Then FilAC("NumeroTarjeta") = "******" & CStr(FilAC("NumeroTarjeta")).Substring(CStr(FilAC("NumeroTarjeta")).Length - 4, 4)
                    Else
                        FilAC.Delete()
                    End If
                Else
                    FilAC.Delete()
                End If
            Next
            Tarjetas.AcceptChanges()

            If Tarjetas.Rows.Count = 0 Or HayTarjetas = False Then
                MsgBox("No se encontraron registros de tarjetas por vencer para las fechas especificadas.", MsgBoxStyle.Information, "AVISO..")
                Exit Sub
            End If

            Me.GridTarjetas.DataSource = Tarjetas
            Me.GridTarjetas.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Tarjetas" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridTarjetas.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Vencimiento de Tarjetas de Crédito", "Vencimientos entre el " & Me.txtFechaDesde.Text & " y el " & Me.txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub
End Class
