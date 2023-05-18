Imports Utilerias.Genericas

Public Class LstAnalisisPolizas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarDatos()
        Try
            Dim sql As String = ""
            sql = "  select  (select Nombre from aseguradoras inner join productos on aseguradoras.idaseguradora = productos.idaseguradora where productos.idproducto = polizas.idproducto ) as Aseguradora"
            sql &= " , IdPoliza"
            sql &= " , IdProducto"
            sql &= " , (select Descripcion from Productos where productos.IdProducto = Polizas.Idproducto ) as Producto"
            sql &= " , IdCliente"
            sql &= " , NombreCliente"
            sql &= " , VigenciaDesde, VigenciaDesde as VigenciaDesdeM, VigenciaDesde as VigenciaDesdeA"
            sql &= " , VigenciaHasta, VigenciaHasta as VigenciaHastaM, VigenciaHasta as VigenciaHastaA"
            sql &= " , EstadoPoliza"
            sql &= " , MotivoCancelacion"
            sql &= " , FechaCancelacion"
            sql &= " , (select isnull(NombreVendedor,'') from PolizasVendedores inner join Vendedores on PolizasVendedores.IdVendedor = Vendedores.IdVendedor where PolizasVendedores.IdProducto = Polizas.IdProducto and PolizasVendedores.IdPoliza = Polizas.IdPoliza and PolizasVendedores.Orden = 1) as Vendedor"
            sql &= " , (select count(*) from PolizasCertificados where polizascertificados.idpoliza = polizas.idpoliza and polizascertificados.idproducto = polizas.idproducto) as Certificados"
            sql &= " , (select count(*) from PolizasDocumentos where polizasdocumentos.idpoliza = polizas.idpoliza and polizasdocumentos.idproducto = polizas.idproducto) as Documentos"
            sql &= " , (select count(*) from PolizasClausulas where PolizasClausulas.idpoliza = polizas.idpoliza and PolizasClausulas.idproducto = polizas.idproducto ) as Clausulas"
            sql &= " , NumVigencia"
            sql &= " , (select RamoSeguros.NombreRamo from RamoSeguros inner join Productos on productos.IdRamo = RamoSeguros.idramo where   productos.idproducto = polizas.idproducto ) as Ramo"
            sql &= " , (isnull((select NombreUsuario from usuarios where idusuario = polizas.EjecutivoCta ),isnull((select top 1 u.NombreUsuario from ClientesEjecutivos as ce inner join usuarios as u on u.idusuario = ce.IdEjecutivo where ce.idcliente = polizas.idcliente and ( IdRamo = (select top 1 idramo from productos where idproducto = polizas.idproducto ) or TipoProducto = (select top 1 TipoProducto from productos where idproducto = polizas.idproducto) or IdArea = 'POLIZAS')  order by orden), isnull((select u.nombreusuario from usuarios as u inner join clientes as c on c.EjecutivoCta =u.idusuario where c.idcliente = polizas.idcliente),'')))) as EjecutivoCta "
            sql &= " , isnull((select sum(PrimaNeta) from PolizasCertificados where fechaexclusion is null and razonexclusion is null and PolizasCertificados.IdPoliza = Polizas.IdPoliza and PolizasCertificados.IdProducto = Polizas.IdProducto),0) as PrimaNeta"
            sql &= " , (select isnull(GrupoCliente,'') from Clientes where Clientes.idcliente = Polizas.IdCliente) as GrupoCliente "
            sql &= " , (select case when polizas.MotivoCancelacion is not null or polizas.EstadoPoliza = 'CANCELADA' then 'CANCELADA' else case WHEN polizas.NumVigencia > 1 THEN 'RENOVADA' else case when (select top 1 FechaVinculacion from Clientes where Clientes.IdCliente = Polizas.IdCliente) >= Polizas.VigenciaDesde  then 'CLIENTE NUEVO' else case when polizas.origen = 'TRASLADO' then 'POLIZA NUEVA TRASLADO' else 'POLIZA NUEVA' end end end end) as Situacion"
            sql &= " , CAST(isnull((select count(*) from polizascertificados where Polizas.IdPoliza = polizascertificados.IdPoliza and Polizas.IdProducto = polizascertificados.IdProducto and polizascertificados.RazonExclusion is null and polizascertificados.FechaExclusion is null and polizascertificados.EstadoCertificado <> 'CANCELADO' ),0) AS VARCHAR) +  ' ' + isnull((select top 1 TipoBien from productos where productos.idproducto = Polizas.idproducto),'') as Bienes"
            sql &= " , IdPolizaSustituida"
            sql &= " , (select isnull(sum(ValorAsegurado),0) from PolizasCertificados where PolizasCertificados.RazonExclusion is null and PolizasCertificados.FechaExclusion is null and PolizasCertificados.EstadoCertificado = 'VIGENTE' and PolizasCertificados.IdPoliza = Polizas.IdPoliza and PolizasCertificados.IdProducto = Polizas.IdProducto) as SumaAsegurada"
            sql &= " , TipoDeducible"
            sql &= " , (select nombrevendedor from vendedores where idvendedor = polizas.NegocioPor) as NegocioPor"
            sql &= " , replace(TipoPoliza,'_',' ') as TipoPoliza"
            sql &= " from Polizas"
            If VisibilidadUsuario() = "D" Then
                sql &= " where polizas.departamento = " & dbStr(DepartamentoUsuario())
            End If
            Dim dtPol As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            PivotPolizas.DataSource = dtPol
            PivotPolizas.Refresh()


        Catch ex As Exception
            msgError(ex)
        End Try


    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Pólizas " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotPolizas.ExportToXls(Archivo, True)
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub LstAnalisisPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
    End Sub

End Class
