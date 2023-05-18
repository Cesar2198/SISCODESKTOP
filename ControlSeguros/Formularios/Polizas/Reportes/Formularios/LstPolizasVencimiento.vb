Imports Utilerias.Genericas

Public Class LstPolizasVencimiento

    Dim dtPolizas As New DataTable
    Dim dtPolizasNew As New DataTable
    Dim dtPolizasRen As New DataTable

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Vencimientos " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim ArchivoTmp As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\RepVenc" & Format(Date.Now, "ddMMyyyyhhmmss")
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)

            If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                Me.VistaVencimientos.ExportToXls(Archivo, Opciones)
                PrepararArchivoExcel(Archivo, "Reporte de Vencimiento de Pólizas", "Vencimientos entre el " & txtFechaDesde.Text & " y el " & txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
            Else
                'generamos los cuadros resumenes en un solo archivo
                Me.PivotVencimientos.ExportToXls(ArchivoTmp & "1.xls", Opciones)
                Me.PivotNuevos.ExportToXls(ArchivoTmp & "2.xls", Opciones)
                Me.PivotRamo.ExportToXls(ArchivoTmp & "3.xls", Opciones)
                Me.PivotTipoCliente.ExportToXls(ArchivoTmp & "4.xls", Opciones)
                Me.PivotClientes.ExportToXls(ArchivoTmp & "5.xls", Opciones)
                PrepararArchivoResumen(ArchivoTmp)
            End If

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub PrepararArchivoResumen(ByVal ArchivoBase As String)
        Try
            Dim Miexcel As Object
            Try
                Miexcel = CreateObject("Excel.Application")
            Catch ex As Exception
                Miexcel = Nothing
            End Try
            If Miexcel Is Nothing Then
                'no está instalado office. solo lanzamos el archivo sin ningún cambio
                AbrirArchivo(ArchivoBase & "1.xls")
                AbrirArchivo(ArchivoBase & "2.xls")
                AbrirArchivo(ArchivoBase & "3.xls")
                AbrirArchivo(ArchivoBase & "4.xls")
                AbrirArchivo(ArchivoBase & "5.xls")
            Else
                'abriremos un nuevo archivo
                Miexcel.Workbooks.Open(ArchivoBase & "1.xls")
                Miexcel.Workbooks.Open(ArchivoBase & "2.xls")
                Miexcel.Workbooks.Open(ArchivoBase & "3.xls")
                Miexcel.Workbooks.Open(ArchivoBase & "4.xls")
                Miexcel.Workbooks.Open(ArchivoBase & "5.xls")
                Miexcel.Workbooks(5).Worksheets(1).Copy(After:=Miexcel.Workbooks(1).Sheets(1))
                Miexcel.Workbooks(4).Worksheets(1).Copy(After:=Miexcel.Workbooks(1).Sheets(1))
                Miexcel.Workbooks(3).Worksheets(1).Copy(After:=Miexcel.Workbooks(1).Sheets(1))
                Miexcel.Workbooks(2).Worksheets(1).Copy(After:=Miexcel.Workbooks(1).Sheets(1))

                Miexcel.Workbooks(5).Close(SaveChanges:=False)
                Miexcel.Workbooks(4).Close(SaveChanges:=False)
                Miexcel.Workbooks(3).Close(SaveChanges:=False)
                Miexcel.Workbooks(2).Close(SaveChanges:=False)

                Miexcel.Workbooks(1).Sheets(1).Name = "Resumen Estado"
                Miexcel.Workbooks(1).Sheets(2).Name = "Resumen Nuevo"
                Miexcel.Workbooks(1).Sheets(3).Name = "Resumen Ramo"
                Miexcel.Workbooks(1).Sheets(4).Name = "Resumen Tipo Cliente"
                Miexcel.Workbooks(1).Sheets(5).Name = "Resumen Cliente"


                Dim Password As String = clSeguros.ObtenerDBParametros("Password.Documentos")

                'aplicaremos algunos cambios a los resumenes
                For NP As Integer = 1 To 5

                    'insertamos 5 filas al inicio
                    Try
                        Miexcel.Workbooks(1).Sheets(NP).Select()
                        Miexcel.Workbooks(1).Sheets(NP).Range("A1").Select()
                        Miexcel.Selection.EntireRow.Insert()
                        Miexcel.Workbooks(1).Sheets(NP).Range("A1").Select()
                        Miexcel.Selection.EntireRow.Insert()
                        Miexcel.Workbooks(1).Sheets(NP).Range("A1").Select()
                        Miexcel.Selection.EntireRow.Insert()
                        Miexcel.Workbooks(1).Sheets(NP).Range("A1").Select()
                        Miexcel.Selection.EntireRow.Insert()
                        Miexcel.Workbooks(1).Sheets(NP).Range("A1").Select()
                        Miexcel.Selection.EntireRow.Insert()


                        Miexcel.Workbooks(1).Sheets(NP).Cells(1, 1).Value = ""
                        Miexcel.Workbooks(1).Sheets(NP).Cells(2, 1).Value = "Reporte Resumen de Vencimientos de Pólizas"
                        Miexcel.Workbooks(1).Sheets(NP).Cells(3, 1).Value = "Vencimientos entre el " & txtFechaDesde.Text & " y el " & txtFechaHasta.Text
                        Miexcel.Workbooks(1).Sheets(NP).Cells(4, 1).Value = "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper

                        Miexcel.Workbooks(1).Sheets(NP).Rows("1:4").Select()
                        Miexcel.Selection.Font.Bold = True
                        Miexcel.Workbooks(1).Sheets(NP).Range("A1").Select()
                    Catch ex As Exception

                    End Try
                    
                    If Password.Trim <> "" Then
                        'le aplicaremos una contraseña al documento
                        Try
                            Miexcel.Workbooks(1).Sheets(NP).Protect(Password, True, True, True)
                        Catch ex As Exception

                        End Try
                    End If
                Next

                Miexcel.Workbooks(1).Sheets(1).Select()
                Miexcel.Workbooks(1).Save()

                System.IO.File.Delete(ArchivoBase & "2.xls")
                System.IO.File.Delete(ArchivoBase & "3.xls")
                System.IO.File.Delete(ArchivoBase & "4.xls")
                System.IO.File.Delete(ArchivoBase & "5.xls")

                Miexcel.visible = True
            End If
        Catch ex As Exception
            MsgBox("Error al Generar el reporte resumen", MsgBoxStyle.Information, "AVISO...")
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

            'listamos vencimientos y cancelaciones 

            sql = "  select "
            sql &= " p.NombreCliente as Cliente"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,d.Descripcion as Producto"
            sql &= " ,p.IdPoliza as Poliza"
            sql &= " ,p.VigenciaDesde as VigenciaDesde"
            sql &= " ,p.VigenciaHasta as VigenciaHasta"
            sql &= " , case "
            sql &= "  when p.MotivoCancelacion is not null or p.EstadoPoliza = 'CANCELADA' then 'CANCELADA'"
            sql &= "  else 'NO RENOVADA' "
            sql &= " end as Estado"
            sql &= " ,isnull((select sum(ValorAsegurado) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null),0) as SumaAsegurada"
            sql &= " ,isnull((select sum(PrimaNeta) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null),0) as PrimaNeta"
            sql &= " , '' as NumeroAC "  '(select top 1 IdAvisoCobro from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto and b.VigenciaDesde >= p.VigenciaDesde order by VigenciaDesde desc) as NumeroAC"
            sql &= " ,(select top 1 IdFormaPago from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto order by VigenciaDesde desc) as NumeroPagos"
            sql &= " , a.Nombre as Aseguradora"
            sql &= ", ISNULL(p.ObservacionesRenovacion,'') as Observaciones, p.FechaSolicitudRenovacion as FechaSolicitud, p.FechaEnvioAnexo, p.IdProducto"
            sql &= ", isnull((select case idtipocliente when 'NA' then 'Individual' when 'JU' then 'Empresas' when 'GU' then 'Instituciones' when 'GA' then 'Instituciones' when 'JE' then 'Empresas' else '' end  from Clientes as cl where cl.idcliente = p.idcliente),'') as TipoCliente"
            sql &= ", 0.0 as Porcentaje"
            'si el cliente tiene todas las polizas vencidas o canceladas, Cliente Perdido, sino Cliente Actual
            sql &= ", case when (select count(*) from Polizas as po left join Clientes as cl on cl.idcliente = po.idcliente where (po.idcliente = p.idcliente or cl.GrupoCliente = c.GrupoCliente) and po.MotivoCancelacion is null and po.EstadoPoliza <> 'CANCELADA' and po.VigenciaHasta > " & dbFec(txtFechaHasta.Valor) & ") = 0 then 'Cliente Perdido' else 'Cliente Actual' end as EstadoCliente"
            sql &= ", P.NumVigencia"
            sql &= ", isnull(c.GrupoCliente,'') as GrupoCliente"
            sql &= ", (select isnull(NombreVendedor,'') from PolizasVendedores inner join Vendedores on PolizasVendedores.IdVendedor = Vendedores.IdVendedor where PolizasVendedores.IdProducto = p.IdProducto And PolizasVendedores.IdPoliza = p.IdPoliza and PolizasVendedores.Orden = 1) as Vendedor"
            sql &= ", p.ObservacionSiniestro as ObservacionSiniestro"
            sql &= ", (select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null ) as Cesionario"
            sql &= ", (select nombrevendedor from vendedores where idvendedor = p.NegocioPor) as NegocioPor ,replace(p.TipoPoliza,'_',' ') as TipoPoliza"
            sql &= ", (isnull((select u.NombreUsuario from usuarios as u where u.idusuario = p.EjecutivoCta ),isnull((select top 1 u.NombreUsuario from ClientesEjecutivos as ce inner join usuarios as u on u.idusuario = ce.IdEjecutivo where ce.idcliente = p.idcliente and ( IdRamo = (select top 1 idramo from productos where idproducto = p.idproducto ) or TipoProducto = (select top 1 TipoProducto from productos where idproducto = p.idproducto) or IdArea = 'POLIZAS')  order by orden), isnull((select u.nombreusuario from usuarios as u inner join clientes as c on c.EjecutivoCta =u.idusuario where c.idcliente = p.idcliente),'')))) as EjecutivoCta"
            sql &= ", case when p.VigenciaHasta < getdate() then 1 else 0 end as Vencida "
            sql &= ", isnull(tc.NombreCancelacion,'') as IdCancelacion"
            sql &= ", 1 as NumPol"

            sql &= " from Polizas as p"
            sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = d.idramo "
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"
            sql &= " left join TipoCancelacion as tc on tc.IdCancelacion = p.IdCancelacion"
            sql &= " where "
            sql &= " p.VigenciaHasta between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            ' Emisiones

            sql &= "  union "

            sql &= "  select "
            sql &= " p.NombreCliente as Cliente"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,d.Descripcion as Producto"
            sql &= " ,p.IdPoliza as Poliza"
            sql &= " ,p.VigenciaDesde as VigenciaDesde"
            sql &= " ,p.VigenciaHasta as VigenciaHasta"
            sql &= " , case "
            sql &= "  when p.MotivoCancelacion is not null or p.EstadoPoliza = 'CANCELADA' then 'CANCELADA'"
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
            sql &= " ,isnull((select sum(ValorAsegurado) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null),0) as SumaAsegurada"
            sql &= " ,isnull((select sum(PrimaNeta) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null),0) as PrimaNeta"
            sql &= " , case when p.MotivoCancelacion is not null then ''"
            sql &= "  else (select top 1 IdAvisoCobro from AvisosCobro as b where rtrim(ltrim(b.IdPoliza)) = p.IdPoliza and b.IdProducto = p.IdProducto and b.VigenciaDesde >= p.VigenciaDesde order by VigenciaDesde desc) "
            sql &= "  end as NumeroAC"
            sql &= " ,(select top 1 IdFormaPago from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto order by VigenciaDesde desc) as NumeroPagos"
            sql &= " , a.Nombre as Aseguradora"
            sql &= ", ISNULL(p.ObservacionesRenovacion,'') as Observaciones, p.FechaSolicitudRenovacion as FechaSolicitud, p.FechaEnvioAnexo, p.IdProducto"
            sql &= ", isnull((select case idtipocliente when 'NA' then 'Individual' when 'JU' then 'Empresas' when 'GU' then 'Instituciones' when 'GA' then 'Instituciones' when 'JE' then 'Empresas' else '' end  from Clientes as cl where cl.idcliente = p.idcliente),'') as TipoCliente"
            sql &= ", 0.0 as Porcentaje"
            'si el cliente tiene todas las polizas vencidas o canceladas, Cliente Perdido, sino Cliente Actual
            sql &= ", case when (select count(*) from Polizas as po left join Clientes as cl on cl.idcliente = po.idcliente where (po.idcliente = p.idcliente or cl.GrupoCliente = c.GrupoCliente) and po.MotivoCancelacion is null and po.EstadoPoliza <> 'CANCELADA' and po.VigenciaHasta > " & dbFec(txtFechaHasta.Valor) & ") = 0 then 'Cliente Perdido' else 'Cliente Actual' end as EstadoCliente"
            sql &= ", P.NumVigencia"
            sql &= ", isnull(c.GrupoCliente,'') as GrupoCliente"
            sql &= ", (select isnull(NombreVendedor,'') from PolizasVendedores inner join Vendedores on PolizasVendedores.IdVendedor = Vendedores.IdVendedor where PolizasVendedores.IdProducto = p.IdProducto And PolizasVendedores.IdPoliza = p.IdPoliza and PolizasVendedores.Orden = 1) as Vendedor"
            sql &= ", p.ObservacionSiniestro as ObservacionSiniestro"
            sql &= ", (select top 1 Beneficiario from PolizasCesiones as e where e.IdPoliza = p.IdPoliza and e.IdProducto = p.IdProducto and e.FechaCancela is null ) as Cesionario"
            sql &= ", (select nombrevendedor from vendedores where idvendedor = p.NegocioPor) as NegocioPor ,replace(p.TipoPoliza,'_',' ') as TipoPoliza"
            sql &= ", (isnull((select u.NombreUsuario from usuarios as u where u.idusuario = p.EjecutivoCta ),isnull((select top 1 u.NombreUsuario from ClientesEjecutivos as ce inner join usuarios as u on u.idusuario = ce.IdEjecutivo where ce.idcliente = p.idcliente and ( IdRamo = (select top 1 idramo from productos where idproducto = p.idproducto ) or TipoProducto = (select top 1 TipoProducto from productos where idproducto = p.idproducto) or IdArea = 'POLIZAS')  order by orden), isnull((select u.nombreusuario from usuarios as u inner join clientes as c on c.EjecutivoCta =u.idusuario where c.idcliente = p.idcliente),'')))) as EjecutivoCta"
            sql &= ", case when p.VigenciaHasta < getdate() then 1 else 0 end as Vencida "
            sql &= ", isnull(tc.NombreCancelacion,'') as IdCancelacion"
            sql &= ", 1 as NumPol"

            sql &= " from Polizas as p"
            sql &= " inner join Clientes as l on p.idcliente = l.idcliente"
            sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = d.idramo "
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"
            sql &= " left join TipoCancelacion as tc on tc.IdCancelacion = p.IdCancelacion"
            sql &= " where p.idpoliza is not null"
            sql &= " and ( p.VigenciaDesde between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)
            ''solo renovaciones
            'sql &= " and P.NumVigencia > 1 "

            sql &= "        or (p.FechaVinculacion between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & "))"
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If

            ' ''ofertas aceptadas

            'sql &= "  union "

            'sql &= "  select "
            'sql &= " p.NombreCliente as Cliente"
            'sql &= " ,r.NombreRamo as Ramo"
            'sql &= " ,d.Descripcion as Producto"
            'sql &= " ,p.IdPoliza as Poliza"
            'sql &= " ,p.VigenciaDesde as VigenciaDesde"
            'sql &= " ,p.VigenciaHasta as VigenciaHasta"
            'sql &= " , case "
            'sql &= "  when p.MotivoCancelacion is not null then 'CANCELADA'"
            'sql &= "  else "
            'sql &= "     case "
            'sql &= "        WHEN P.NumVigencia > 1 THEN 'RENOVADA'"
            'sql &= "        else "
            'sql &= "             case "
            'sql &= "                 when l.FechaVinculacion >= " & dbFec(txtFechaDesde.Valor) & " then 'CLIENTE NUEVO'"
            'sql &= "                 else 'POLIZA NUEVA'"
            'sql &= "              end"
            'sql &= "      end "
            'sql &= " end as Estado"
            'sql &= " ,(select sum(ValorAsegurado) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as SumaAsegurada"
            'sql &= " ,(select sum(PrimaNeta) from PolizasCertificados as c where c.idpoliza = p.idpoliza and c.idproducto = p.idproducto and c.RazonExclusion is null) as PrimaNeta"
            'sql &= " , case when p.MotivoCancelacion is not null then ''"
            'sql &= "  else (select top 1 IdAvisoCobro from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto and b.VigenciaDesde >= p.VigenciaDesde order by VigenciaDesde desc) "
            'sql &= "  end as NumeroAC"
            'sql &= " ,(select top 1 IdFormaPago from AvisosCobro as b where b.IdPoliza = p.IdPoliza and b.IdProducto = p.IdProducto order by VigenciaDesde desc) as NumeroPagos"
            'sql &= " , a.Nombre as Aseguradora"
            'sql &= ", ISNULL(p.ObservacionesRenovacion,'') as Observaciones, p.FechaSolicitudRenovacion as FechaSolicitud, p.IdProducto"
            'sql &= " from cPolizas as p"
            'sql &= " inner join Clientes as l on p.idcliente = l.idcliente"
            'sql &= " inner join Productos as d on d.idproducto = p.idproducto"
            'sql &= " inner join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            'sql &= " inner join RamoSeguros as r on r.idramo = d.idramo "
            'sql &= " where p.idpoliza is not null"
            'sql &= " and p.EstadoPoliza = 'ACEPTADA' "
            'sql &= " and ( (p.VigenciaDesde between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & ")"
            'sql &= "        or (p.FechaVinculacion between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor) & "))"



            dtPolizas = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtPolizas.Rows.Count = 0 Then
                MsgBox("No se encontraron póliza.", MsgBoxStyle.Information, "AVISO...")
            End If

            'detalle
            GridVencimientos.DataSource = dtPolizas
            GridVencimientos.Refresh()

            dtPolizasRen = dtPolizas.Copy
            'borramos las que el estado no sea nuevo
            For Each FilPol As DataRow In dtPolizasRen.Rows
                If (CStr(FilPol("Estado")) Like "*NUEV*") Then
                    FilPol.Delete()
                End If
            Next
            dtPolizasRen.AcceptChanges()

            'resumen estado
            PivotVencimientos.DataSource = dtPolizasRen
            PivotVencimientos.Refresh()

            'resumen nuevos
            dtPolizasNew = dtPolizas.Copy
            'borramos las que el estado no sea nuevo
            For Each FilPol As DataRow In dtPolizasNew.Rows
                If Not (CStr(FilPol("Estado")) Like "*NUEV*") Then
                    FilPol.Delete()
                End If
            Next
            dtPolizasNew.AcceptChanges()

            PivotNuevos.DataSource = dtPolizasNew
            PivotNuevos.Refresh()

            'resumen ramo
            PivotRamo.DataSource = dtPolizas
            PivotRamo.Refresh()

            'resumen tipo cliente
            PivotTipoCliente.DataSource = dtPolizas
            PivotTipoCliente.Refresh()

            'resumen cliente
            PivotClientes.DataSource = dtPolizas
            PivotClientes.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub VistaVencimientos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaVencimientos.CellValueChanged
        Me.VistaVencimientos.PostEditor()
        Me.VistaVencimientos.UpdateCurrentRow()

        If e.Column.FieldName = "Observaciones" Or e.Column.FieldName = "FechaSolicitud" Or e.Column.FieldName = "FechaEnvioAnexo" Then
            ''actualizamos la póliza
            Try
                Dim sql As String = ""
                sql = " update Polizas "
                sql &= " set ObservacionesRenovacion = " & dbStr(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "Observaciones"), 250)
                sql &= " , FechaSolicitudRenovacion = " & dbFec(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "FechaSolicitud"))
                sql &= " , FechaEnvioAnexo = " & dbFec(Me.VistaVencimientos.GetRowCellValue(e.RowHandle, "FechaEnvioAnexo"))
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

    Private Sub Pivot_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs)
        'calcularemos la participación
        Try
            If e.FieldName = "Porcentaje" Then
                Dim ds As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim Total As Double = 0
                Dim Num As Integer = 0
                Dim i As Integer = 0
                'siempre se agrupa por anio

                For i = 0 To ds.RowCount - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = ds(i)
                    Num += 1
                Next
                Select Case sender.Name
                    Case "PivotNuevos"
                        Total = dtPolizasNew.Rows.Count
                    Case "PivotVencimientos"
                        Total = dtPolizasRen.Rows.Count
                    Case Else
                        Total = dtPolizas.Rows.Count
                End Select

                If Total = 0 Then
                    e.CustomValue = 0
                Else
                    e.CustomValue = Num / Total
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LstPolizasVencimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler PivotVencimientos.CustomSummary, AddressOf Pivot_CustomSummary
        AddHandler PivotNuevos.CustomSummary, AddressOf Pivot_CustomSummary
        AddHandler PivotRamo.CustomSummary, AddressOf Pivot_CustomSummary
        AddHandler PivotTipoCliente.CustomSummary, AddressOf Pivot_CustomSummary
        AddHandler PivotClientes.CustomSummary, AddressOf Pivot_CustomSummary
    End Sub

End Class
