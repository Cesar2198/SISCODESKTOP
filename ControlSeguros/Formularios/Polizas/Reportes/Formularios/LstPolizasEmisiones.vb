Imports Utilerias.Genericas

Public Class LstPolizasEmisiones

    Dim dtPolizas As New DataTable

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Emisiones " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)

            If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                Me.VistaVencimientos.ExportToXls(Archivo, Opciones)
            Else
                Me.PivotVencimientos.ExportToXls(Archivo, Opciones)
            End If

            PrepararArchivoExcel(Archivo, "Reporte de Emisiones de Pólizas", "Emisiones entre el " & txtFechaDesde.Text & " y el " & txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPolizas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPolizas.Click
        Try
            If txtFechaDesde.Text = "" Then
                MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If txtFechaHasta.Text = "" Then
                MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            ''listamos vencimientos y cancelaciones 
            'sql = "  select "
            'sql &= " p.NombreCliente as Cliente"
            'sql &= " ,r.NombreRamo as Ramo"
            'sql &= " ,d.Descripcion as Producto"
            'sql &= " ,p.IdPoliza as Poliza"
            'sql &= " ,p.VigenciaDesde as VigenciaDesde"
            'sql &= " ,p.VigenciaHasta as VigenciaHasta"
            'sql &= " , case "
            'sql &= "  when p.MotivoCancelacion is not null then 'CANCELADA'"
            'sql &= "  else 'NO RENOVADA' "
            'sql &= " end as Estado"
            'sql &= " ,(select sum(ValorAsegurado) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as SumaAsegurada"
            'sql &= " ,(select sum(PrimaNeta) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as PrimaNeta"
            'sql &= " , '' as NumeroAC "  '(select top 1 IdAvisoCobro from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto and b.VigenciaDesde >= p.VigenciaDesde order by VigenciaDesde desc) as NumeroAC"
            'sql &= " ,(select top 1 IdFormaPago from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto order by VigenciaDesde desc) as NumeroPagos"
            'sql &= " , a.Nombre as Aseguradora"
            'sql &= ", ISNULL(p.ObservacionesRenovacion,'') as Observaciones, p.FechaSolicitudRenovacion as FechaSolicitud, p.IdProducto"
            'sql &= " from Polizas as p"
            'sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            'sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            'sql &= " inner join RamoSeguros as r on r.idramo = d.idramo "
            'sql &= " where "
            'sql &= " p.VigenciaHasta between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)

            ' ''y nuevos negocios

            'sql &= "  union "

            sql &= "  select "
            sql &= " p.NombreCliente as Cliente"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,d.Descripcion as Producto"
            sql &= " ,p.IdPoliza as Poliza"
            sql &= " ,p.VigenciaDesde as VigenciaDesde"
            sql &= " ,p.VigenciaHasta as VigenciaHasta"
            sql &= " , case "
            sql &= "  when p.MotivoCancelacion is not null then 'CANCELADA'"
            sql &= "  else "
            sql &= "     case "
            sql &= "        WHEN P.NumVigencia > 1 THEN 'RENOVADA'"
            sql &= "        else "
            sql &= "             case "
            sql &= "                 when l.FechaVinculacion >= " & dbFec(txtFechaDesde.Valor) & " then 'CLIENTE NUEVO'"
            sql &= "                 else "
            sql &= "                    case "
            sql &= "                        when p.origen = 'TRASLADO' then 'POLIZA NUEVA TRASLADO'"
            sql &= "                        else 'POLIZA NUEVA'"
            sql &= "                    end  "
            sql &= "              end"
            sql &= "      end "
            sql &= " end as Estado"
            sql &= " ,(select sum(ValorAsegurado) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= " ,(select sum(PrimaNeta) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as PrimaNeta"
            sql &= " , case when p.MotivoCancelacion is not null then ''"
            sql &= "  else (select top 1 IdAvisoCobro from AvisosCobro as b where rtrim(ltrim(b.IdPoliza)) = p.IdPoliza and b.IdProducto = p.IdProducto and b.VigenciaDesde >= p.VigenciaDesde order by VigenciaDesde desc) "
            sql &= "  end as NumeroAC"
            sql &= " ,(select top 1 IdFormaPago from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto order by VigenciaDesde desc) as NumeroPagos"
            sql &= " , a.Nombre as Aseguradora"
            sql &= ", ISNULL(p.ObservacionesRenovacion,'') as Observaciones, p.FechaSolicitudRenovacion as FechaSolicitud, p.IdProducto"
            sql &= ", isnull(l.GrupoCliente,'') as GrupoCliente"
            sql &= ", (select isnull(NombreVendedor,'') from PolizasVendedores inner join Vendedores on PolizasVendedores.IdVendedor = Vendedores.IdVendedor where PolizasVendedores.IdProducto = p.IdProducto And PolizasVendedores.IdPoliza = p.IdPoliza and PolizasVendedores.Orden = 1) as Vendedor"
            sql &= ", p.ObservacionSiniestro as ObservacionSiniestro"
            sql &= ", case d.IdRamo when '702' then isnull((select top 1 cast(DescripcionBien as varchar(max)) from PolizasBienes as b1 where b1.IdPoliza = p.IdPoliza and b1.IdProducto = p.IdProducto and b1.NombreBien = 'BENEFICIARIO'),(select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null )) else (select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null ) end as Cesionario"
            sql &= ", (select nombrevendedor from vendedores where idvendedor = p.NegocioPor) as NegocioPor ,replace(p.TipoPoliza,'_',' ') as TipoPoliza"

            sql &= " from Polizas as p"
            sql &= " inner join Clientes as l on p.idcliente = l.idcliente"
            sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = d.idramo "
            sql &= " where p.idpoliza is not null and P.NumVigencia = 1 "
            sql &= " and ( (p.VigenciaDesde between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & ")"
            sql &= "        or (p.FechaVinculacion between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & "))"
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If


            ''ofertas aceptadas

            sql &= "  union "

            sql &= "  select "
            sql &= " p.NombreCliente as Cliente"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,d.Descripcion as Producto"
            sql &= " ,p.IdPoliza as Poliza"
            sql &= " ,p.VigenciaDesde as VigenciaDesde"
            sql &= " ,p.VigenciaHasta as VigenciaHasta"
            sql &= " , case "
            sql &= "  when p.MotivoCancelacion is not null then 'CANCELADA'"
            sql &= "  else "
            sql &= "     case "
            sql &= "        WHEN P.NumVigencia > 1 THEN 'RENOVADA'"
            sql &= "        else "
            sql &= "             case "
            sql &= "                 when l.FechaVinculacion >= " & dbFec(txtFechaDesde.Valor) & " then 'CLIENTE NUEVO'"
            sql &= "                 else 'POLIZA NUEVA'"
            sql &= "              end"
            sql &= "      end "
            sql &= " end as Estado"
            sql &= " ,(select sum(ValorAsegurado) from cPolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as SumaAsegurada"
            sql &= " ,(select sum(PrimaNeta) from cPolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as PrimaNeta"
            sql &= " , case when p.MotivoCancelacion is not null then ''"
            sql &= "  else (select top 1 IdAvisoCobro from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto and b.VigenciaDesde >= p.VigenciaDesde order by VigenciaDesde desc) "
            sql &= "  end as NumeroAC"
            sql &= " ,(select top 1 IdFormaPago from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto order by VigenciaDesde desc) as NumeroPagos"
            sql &= " , a.Nombre as Aseguradora"
            sql &= ", ISNULL(p.ObservacionesRenovacion,'') as Observaciones, p.FechaSolicitudRenovacion as FechaSolicitud, p.IdProducto"
            sql &= ", isnull(l.GrupoCliente,'') as GrupoCliente"
            sql &= ", (select isnull(NombreVendedor,'') from Vendedores as v where v.idvendedor = p.idvendedor) as Vendedor"
            sql &= ", '' as ObservacionSiniestro"
            sql &= ", (select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null ) as Cesionario"
            sql &= ", (select nombrevendedor from vendedores where idvendedor = p.NegocioPor) as NegocioPor ,replace(p.TipoPoliza,'_',' ') as TipoPoliza"
            sql &= " from cPolizas as p"
            sql &= " left join Clientes as l on p.idcliente = l.idcliente"
            sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = d.idramo "
            sql &= " where p.idpoliza is not null"
            sql &= " and p.EstadoPoliza = 'ACEPTADA' "
            sql &= " and ( (p.VigenciaDesde between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & ")"
            sql &= "        or (p.FechaVinculacion between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & "))"
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If


            dtPolizas = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtPolizas.Rows.Count = 0 Then
                MsgBox("No se encontraron póliza.", MsgBoxStyle.Information, "AVISO...")
            End If

            'detalle
            GridVencimientos.DataSource = dtPolizas
            GridVencimientos.Refresh()

            'resumen
            PivotVencimientos.DataSource = dtPolizas
            PivotVencimientos.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaVencimientos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaVencimientos.CellValueChanged
        Me.VistaVencimientos.PostEditor()
        Me.VistaVencimientos.UpdateCurrentRow()

        If e.Column.FieldName = "Observaciones" Or e.Column.FieldName = "FechaSolicitud" Then
            ''actualizamos la póliza
            Try
                Dim sql As String = ""
                sql = " update Polizas "
                sql &= " set ObservacionesRenovacion = " & dbStr(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "Observaciones"), 250)
                sql &= " , FechaSolicitudRenovacion = " & dbFec(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "FechaSolicitud"))
                sql &= " where IdPoliza = " & dbStr(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "Poliza"), 25)
                sql &= " and IdProducto = " & dbStr(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "IdProducto"), 25)
                StiGlobalConn.SQLExecute(sql)

            Catch ex As Exception

            End Try
        End If

        Me.PivotVencimientos.DataSource = Nothing
        Me.PivotVencimientos.DataSource = Me.GridVencimientos.DataSource
        Me.PivotVencimientos.Refresh()

    End Sub

    Private Sub VistaVencimientos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaVencimientos.DoubleClick
        Dim Fila As Integer = Me.VistaVencimientos.FocusedRowHandle
        If Fila >= 0 Then
            Try
                Dim Poliza As String = Me.VistaVencimientos.GetRowCellValue(Fila, "Poliza")
                Dim Producto As String = Me.VistaVencimientos.GetRowCellValue(Fila, "IdProducto")

                Dim fpol As New PolizasMan
                fpol.Permiso = Me.Permiso
                fpol.dbTabla = "Polizas"
                fpol.dbCondicion = "IdPoliza = " & dbStr(Poliza) & " and IdProducto = " & dbStr(Producto)
                fpol.STIConn = StiGlobalConn
                fpol.ShowDialog()

            Catch ex As Exception

            End Try

        End If
    End Sub

End Class
