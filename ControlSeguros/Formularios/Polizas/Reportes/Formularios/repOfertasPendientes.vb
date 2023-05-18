Imports Utilerias.Genericas

Public Class repOfertasPendientes

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Ofertas " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaOfertas.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte Ofertas Pendientes", "Ofertas Pendientes al " & txtFechaFinal.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub repOfertasPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaInicial.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaFinal.Valor = Date.Today

        Dim IdCliente As String = clSeguros.ObtenerIdCliente()
        Select Case IdCliente
            Case "2120000"
                GridColumn8.OptionsColumn.AllowShowHide = True
                GridColumn10.OptionsColumn.AllowShowHide = True
                GridColumn14.OptionsColumn.AllowShowHide = True
                GridColumn15.OptionsColumn.AllowShowHide = True
                GridColumn16.OptionsColumn.AllowShowHide = True

        End Select
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarOfertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOfertas.Click
        Try
            If txtFechaFinal.Text = "" Then
                MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            sql = "  select "
            sql &= " cast(o.IdComparativo as varchar) as Oferta"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,'' as Producto"
            sql &= " ,'' as IdProducto"
            sql &= " ,o.NombreCliente as Cliente"
            sql &= " ,u.NombreUsuario as Ejecutivo"
            sql &= " ,o.FechaOferta as FechaOferta"

            sql &= " , '' as Vendedor"
            sql &= " , 0.0 as SumaAsegurada"
            sql &= " , 0.0 as PrimaAnual"
            sql &= " , '' as Aseguradora"
            sql &= " , '' as Estado"

            sql &= " , '' as ClienteNuevo"
            sql &= " , '' as FormaPago"
            sql &= " , 0 as NumeroCuotas"
            sql &= " , '' as FechaEnvio"
            sql &= " , '' as Seguimiento"
            sql &= " , '' as EjecutivoSolicita"
            sql &= " , '' as ObservacionesRenovacion"
            sql &= " , '' as UltimaGestion"

            sql &= " from OfertasComparativo as o"
            sql &= " inner join RamoSeguros as r on r.IdRamo = o.IdRamo"
            sql &= " left join usuarios as u on u.IdUsuario = o.EjecutivoCta"
            sql &= " where FechaOferta between " & dbFec(txtFechaInicial.Valor) & " and " & dbFec(txtFechaFinal.Valor)
            'sql &= " and o.EstadoOferta = 'PENDIENTE' "

            sql &= " union "

            sql &= "  select "
            sql &= " o.IdPoliza as Oferta"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,p.Descripcion as Producto"
            sql &= " ,p.idproducto as IdProducto"
            sql &= " ,o.NombreCliente as Cliente"
            sql &= " ,u.NombreUsuario as Ejecutivo"
            sql &= " ,o.VigenciaDesde as FechaOferta"

            sql &= " , isnull((select v.NombreVendedor from Vendedores as v where v.IdVendedor = o.IdVendedor),'') as Vendedor"
            sql &= " , isnull((select sum(t.ValorAsegurado) from CPolizasCertificados as t where t.IdPoliza = o.IdPoliza and t.IdProducto = o.IdProducto),isnull(o.ResumenSumaAsegurada,0)) as SumaAsegurada"
            sql &= " , isnull((select sum(t.PrimaNeta) from CPolizasCertificados as t where t.IdPoliza = o.IdPoliza and t.IdProducto = o.IdProducto),isnull(o.ResumenPrimaAnual,0)) as PrimaAnual"
            sql &= " , (select Nombre from Aseguradoras as a where a.idaseguradora = p.idaseguradora) as Aseguradora"
            sql &= " , o.EstadoPoliza as Estado"

            sql &= " , case when ((select count(*) from Polizas as p2 where p2.idcliente = o.idcliente) + (select count(*) from PolizasCertificados as c2 where c2.idcliente = o.idcliente) )  > 0  then 'NO' else 'SI' end as ClienteNuevo"
            sql &= " , o.ResumenFormaPago as FormaPago"
            sql &= " , o.ResumenNumeroCuotas as NumeroCuotas"
            sql &= " , o.ResumenFechaEnvio as FechaEnvio"
            sql &= " , cast(o.ResumenSeguimiento as varchar(max)) as Seguimiento"
            sql &= " , (select top 1 x.NombreUsuario from usuarios as x where x.IdUsuario = o.EjecutivoCta) as EjecutivoSolicita "
            sql &= " , o.ObservacionesRenovacion"
            sql &= " , (select top 1 isnull(comentarios,'') from gestiones left join TipoGestion on gestiones.IdTipoGestion = TipoGestion.IdTipoGestion  where gestiones.idpoliza = o.idpoliza and gestiones.idproducto = o.idproducto and gestiones.TipoGestion = 'P' order by gestiones.FechaGestion desc, gestiones.IdGestion desc) as UltimaGestion "

            sql &= " from CPolizas as o"
            sql &= " inner join Productos as p on p.idproducto = o.idproducto "
            sql &= " inner join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " left join Clientes as c on c.idcliente = o.idcliente"
            sql &= " left join usuarios as u on u.IdUsuario = c.EjecutivoCta"
            sql &= " where o.VigenciaDesde between " & dbFec(txtFechaInicial.Valor) & " and " & dbFec(txtFechaFinal.Valor)
            'sql &= " and o.EstadoPoliza = 'PENDIENTE' "
            If VisibilidadUsuario() = "D" Then
                sql &= " and o.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            Dim dtOfertas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtOfertas.Rows.Count = 0 Then
                MsgBox("No se encontraron ofertas pendientes a la fecha especificada.", MsgBoxStyle.Information, "AVISO...")
            End If

            GridOfertas.DataSource = dtOfertas
            GridOfertas.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaOfertas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaOfertas.DoubleClick
        'lanzaremos la oferta que desean revisar

        Dim fila As Integer = Me.VistaOfertas.FocusedRowHandle
        If fila >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            Dim Oferta As String = Me.VistaOfertas.GetRowCellValue(fila, "Oferta")
            Dim Producto As String = Me.VistaOfertas.GetRowCellValue(fila, "Producto")
            If Producto = "" Then
                'es un comparativo
                Dim fcomp As New OfertasComparativo
                fcomp.dbCondicion = "IdComparativo = " & dbInt(Oferta)
                fcomp.dbTabla = "OfertasComparativo"
                fcomp.Permiso = Me.Permiso
                fcomp.STIConn = StiGlobalConn
                fcomp.Show()
            Else
                'es una oferta normal
                Dim frmOferta As New CPolizasMan
                frmOferta.dbCondicion = "IdPoliza = " & dbStr(Oferta) & " and idproducto = " & dbStr(VistaOfertas.GetRowCellValue(fila, "IdProducto"))
                frmOferta.dbTabla = "CPolizas"
                frmOferta.Permiso = Me.Permiso
                frmOferta.STIConn = StiGlobalConn
                frmOferta.Show()
            End If

            Me.Cursor = Cursors.Default
        End If
    End Sub

End Class
