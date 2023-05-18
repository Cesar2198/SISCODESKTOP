Imports Utilerias.Genericas

Public Class ContactosGeneralesNav

    Public Overrides Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If Me.VistaNav.FocusedRowHandle < 0 Then
                'no se ha selecionado registro, puede ser un grupo, no hacemos nada
                Exit Sub
            End If

            Dim FilaSel As Integer = Me.VistaNav.FocusedRowHandle
            Dim Tipo As String = Me.VistaNav.GetRowCellValue(FilaSel, "Tipo")
            Dim Codigo As String = Me.VistaNav.GetRowCellValue(FilaSel, "Codigo")



            Select Case Tipo
                Case "CONTACTO"
                    Dim frmCon As New ContactosGeneralesMan
                    frmCon.dbTabla = "ContactosGenerales"
                    frmCon.STIConn = Me.STIConn
                    frmCon.Permiso = Me.Permiso
                    frmCon.dbCondicion = "IdContacto=" & dbStr(Codigo)
                    If sender Is btnEliminar Then
                        frmCon.AbrirEnEstadoEliminacion = True
                    End If
                    frmCon.ShowDialog()

                Case "ASEGURADORA"
                    Dim frmCon As New AseguradorasMan
                    frmCon.dbTabla = "Aseguradoras"
                    frmCon.STIConn = Me.STIConn
                    frmCon.Permiso = "L"
                    frmCon.dbCondicion = "IdAseguradora=" & dbStr(Codigo)
                    If sender Is btnEliminar Then
                        frmCon.AbrirEnEstadoEliminacion = True
                    End If
                    frmCon.ShowDialog()

                Case "CLIENTE"
                    Dim frmCon As New ClientesMan
                    frmCon.dbTabla = "Clientes"
                    frmCon.STIConn = Me.STIConn
                    frmCon.Permiso = "L"
                    frmCon.dbCondicion = "IdCliente=" & dbStr(Codigo)
                    If sender Is btnEliminar Then
                        frmCon.AbrirEnEstadoEliminacion = True
                    End If
                    frmCon.ShowDialog()

            End Select

            'actualizamos los registros
            Call CargarRegistros()

            'tratamos de marcar la misma fila que se selecionó al principio
            Me.VistaNav.FocusedRowHandle = FilaSel

        Catch ex As Exception
            'no controlaremos el error
            msgError(ex)
        End Try

    End Sub

    Private Sub ContactosGeneralesNav_AntesDeCargarRegistros() Handles Me.AntesDeCargarRegistros
        If Me.optSoloContactos.Checked Then
            Me.SQlManual = "select 'CONTACTO' as Tipo, c.IdContacto  as Codigo, g.Descripcion as Categoria,  c.Nombre  as Nombre,  c.Nombre  as Contacto, '' as Cargo,c.Direccion  as Direccion,c.Telefono  as Telefono,c.Fax as Fax,c.EMail as Email,c.PaginaWeb,c.Nit as Nit, c.RegistroFiscal as RegistroFiscal, c.estado as Estado, '' as Ejecutivos, '' as Vendedores ,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente from ContactosGenerales as c left join ContactosCategorias as g on  g.IdContactoCategoria = c.IdContactoCategoria union select 'CONTACTO' as Tipo, c.IdContacto  as Codigo, g.Descripcion as Categoria, c.Nombre as Nombre,  s.Nombre  as Contacto, isnull(s.Cargo,'') as Cargo , '' as Direccion, s.Telefono as Telefono, '' as Fax, s.EMail as Email, '' PaginaWeb, '' as Nit, '' as RegistroFiscal, c.estado as Estado, '' as Ejecutivos, '' as Vendedores ,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente from ContactosGenerales as c inner join ContactosGeneralesSubContactos as s on c.IdContacto = s.IdContacto left join ContactosCategorias as g on  g.IdContactoCategoria = c.IdContactoCategoria union select 'ASEGURADORA' as Tipo, c.IdAseguradora  as Codigo, 'ASEGURADORA' as Categoria,  c.Nombre  as Nombre,  c.Nombre  as Contacto,  '' as Cargo ,c.Direccion  as Direccion,c.Telefono  as Telefono,c.Fax as Fax,c.EMail as Email,c.PaginaWeb,c.Nit as Nit, c.RegistroFiscal as RegistroFiscal, case when (select count(*) from polizas inner join productos on polizas.idproducto = productos.idproducto where fechacancelacion is null and estadopoliza = 'VIGENTE' and productos.idaseguradora = c.idaseguradora) = 0 then 'INACTIVO' else 'ACTIVO' end as Estado, '' as Ejecutivos, '' as Vendedores ,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente from Aseguradoras as c union select 'ASEGURADORA' as Tipo, c.IdAseguradora  as Codigo, 'ASEGURADORA' as Categoria, a.Nombre as Nombre,  c.Nombre  as Contacto, isnull(c.Cargo,'') as Cargo, '' as Direccion, c.Telefono  as Telefono, '' as Fax, c.EMail as Email,'' as PaginaWeb ,'' as Nit, '' as RegistroFiscal, case when (select count(*) from polizas inner join productos on polizas.idproducto = productos.idproducto where fechacancelacion is null and estadopoliza = 'VIGENTE' and productos.idaseguradora = a.idaseguradora) = 0 then 'INACTIVO' else 'ACTIVO' end as Estado, '' as Ejecutivos, '' as Vendedores ,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente from Aseguradoras as a inner join AseguradorasContactos as c on a.idaseguradora = c.idaseguradora union select 'CLIENTE' AS Tipo, c.IdCliente as Codigo, 'CLIENTE' AS Categoria, c.NombreCliente as Nombre, isnull((select top 1 co.Nombre from ClientesContactos as co where co.idcliente = c.idcliente and co.UsoCorrespondencia = 'S' order by IdContacto),'')  as Contacto, isnull((select top 1 co.Cargo from ClientesContactos as co where co.idcliente = c.idcliente and co.UsoCorrespondencia = 'S' order by IdContacto),'') as Cargo , isnull((select top 1 co.Direccion from ClientesContactos as co where co.idcliente = c.idcliente and co.UsoCorrespondencia = 'S' order by IdContacto),'') as Direccion, isnull((select top 1 co.Telefono from ClientesContactos as co where co.idcliente = c.idcliente and co.UsoCorrespondencia = 'S' order by IdContacto),'') as Telefono, ISNULL(c.Fax,'') as Fax, isnull((select top 1 co.EMail from ClientesContactos as co where co.idcliente = c.idcliente and co.UsoCorrespondencia = 'S' order by IdContacto),'') as Email, '' as PaginaWeb, isnull(c.Nit,'') as Nit, isnull(c.RegistroFiscal,'') as RegistroFiscal, case when (select count(*) from polizas where fechacancelacion is null and estadopoliza = 'VIGENTE' and idcliente = c.idcliente ) = 0 then 'INACTIVO' else 'ACTIVO' end as Estado , case when (select count(*) from ClientesEjecutivos as e where e.idcliente = c.idcliente) = 0 then isnull((select  u.nombreusuario from usuarios as u where u.idusuario = c.ejecutivocta),'') else (select distinct u.nombreusuario + ', ' from dbo.ClientesEjecutivos as e inner join usuarios as u on u.idusuario = e.IdEjecutivo where e.idcliente = c.idcliente for xml path('')) end as Ejecutivos, isnull((select distinct p.idpoliza + ' = ' + v.NombreVendedor + ', ' from Polizas as p inner join PolizasVendedores as pv on p.idpoliza = pv.idpoliza and p.idproducto = pv.idproducto inner join Vendedores as v on v.idvendedor = pv.idvendedor where p.MotivoCancelacion is null and p.FechaCancelacion is null and p.EstadoPoliza = 'VIGENTE' and p.idcliente = c.idcliente for xml path('') ),'') as Vendedores , c.FechaNacimiento, c.NombreRepLegal, c.FnacRepLegal, case c.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' end as TipoCliente from Clientes as c"
        Else
            Me.SQlManual = "select 'CONTACTO' as Tipo, c.IdContacto  as Codigo, g.Descripcion as Categoria,  c.Nombre  as Nombre,  c.Nombre  as Contacto, '' as Cargo,c.Direccion  as Direccion,c.Telefono  as Telefono,c.Fax as Fax,c.EMail as Email,c.PaginaWeb,c.Nit as Nit, c.RegistroFiscal as RegistroFiscal, c.estado as Estado, '' as Ejecutivos, '' as Vendedores,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente from ContactosGenerales as c left join ContactosCategorias as g on  g.IdContactoCategoria = c.IdContactoCategoria union select 'CONTACTO' as Tipo, c.IdContacto  as Codigo, g.Descripcion as Categoria, c.Nombre as Nombre,  s.Nombre  as Contacto, isnull(s.Cargo,'') as Cargo, '' as Direccion, s.Telefono as Telefono, '' as Fax, s.EMail as Email, '' PaginaWeb, '' as Nit, '' as RegistroFiscal, c.estado as Estado, '' as Ejecutivos, '' as Vendedores,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente from ContactosGenerales as c inner join ContactosGeneralesSubContactos as s on c.IdContacto = s.IdContacto left join ContactosCategorias as g on  g.IdContactoCategoria = c.IdContactoCategoria union select 'ASEGURADORA' as Tipo, c.IdAseguradora  as Codigo, 'ASEGURADORA' as Categoria,  c.Nombre  as Nombre,  c.Nombre  as Contacto,  '' as Cargo,c.Direccion  as Direccion,c.Telefono  as Telefono,c.Fax as Fax,c.EMail as Email,c.PaginaWeb,c.Nit as Nit, c.RegistroFiscal as RegistroFiscal, case when (select count(*) from polizas inner join productos on polizas.idproducto = productos.idproducto where fechacancelacion is null and estadopoliza = 'VIGENTE' and productos.idaseguradora = c.idaseguradora) = 0 then 'INACTIVO' else 'ACTIVO' end as Estado, '' as Ejecutivos, '' as Vendedores,null as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente  from Aseguradoras as c union select 'ASEGURADORA' as Tipo, c.IdAseguradora  as Codigo, 'ASEGURADORA' as Categoria, a.Nombre as Nombre,  c.Nombre  as Contacto, isnull(c.Cargo,'') as Cargo, '' as Direccion, c.Telefono  as Telefono, '' as Fax, c.EMail as Email,'' as PaginaWeb ,'' as Nit, '' as RegistroFiscal, case when (select count(*) from polizas inner join productos on polizas.idproducto = productos.idproducto where fechacancelacion is null and estadopoliza = 'VIGENTE' and productos.idaseguradora = a.idaseguradora) = 0 then 'INACTIVO' else 'ACTIVO' end as Estado, '' as Ejecutivos, '' as Vendedores, FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, null as TipoCliente  from Aseguradoras as a inner join AseguradorasContactos as c on a.idaseguradora = c.idaseguradora union select 'CLIENTE' AS Tipo, c.IdCliente as Codigo, 'CLIENTE' AS Categoria, c.NombreCliente as Nombre, c.NombreCliente as Contacto, '' as Cargo, '' as Direccion, '' as Telefono, c.Fax as Fax, c.Email as Email, '' as PaginaWeb, c.Nit as Nit, c.RegistroFiscal as RegistroFiscal, case when (select count(*) from polizas where fechacancelacion is null and estadopoliza = 'VIGENTE' and idcliente = c.idcliente ) = 0 then 'INCATIVO' else 'ACTIVO' end as Estado , case when (select count(*) from ClientesEjecutivos as e where e.idcliente = c.idcliente) = 0 then isnull((select  u.nombreusuario from usuarios as u where u.idusuario = c.ejecutivocta),'') else (select distinct u.nombreusuario + ', ' from dbo.ClientesEjecutivos as e inner join usuarios as u on u.idusuario = e.IdEjecutivo where e.idcliente = c.idcliente for xml path('')) end as Ejecutivos, isnull((select distinct p.idpoliza + ' = ' + v.NombreVendedor + ', ' from Polizas as p inner join PolizasVendedores as pv on p.idpoliza = pv.idpoliza and p.idproducto = pv.idproducto inner join Vendedores as v on v.idvendedor = pv.idvendedor where p.MotivoCancelacion is null and p.FechaCancelacion is null and p.EstadoPoliza = 'VIGENTE' and p.idcliente = c.idcliente for xml path('') ),'') as Vendedores, c.FechaNacimiento, c.NombreRepLegal, c.FnacRepLegal, case c.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' end as TipoCliente from Clientes as c union select 'CLIENTE' AS Tipo, c.IdCliente as Codigo, 'CLIENTE' AS Categoria, t.NombreCliente as Nombre, c.Nombre as Contacto, isnull(c.Cargo,'') as Cargo, c.Direccion as Direccion, c.Telefono as Telefono, '' as Fax, c.Email as Email, '' as PaginaWeb, '' as Nit, '' as RegistroFiscal, case when (select count(*) from polizas where fechacancelacion is null and estadopoliza = 'VIGENTE' and idcliente = c.idcliente ) = 0 then 'INCATIVO' else 'ACTIVO' end as Estado , case when (select count(*) from ClientesEjecutivos as e where e.idcliente = t.idcliente) = 0 then isnull((select  u.nombreusuario from usuarios as u where u.idusuario = t.ejecutivocta),'') else (select distinct u.nombreusuario + ', ' from dbo.ClientesEjecutivos as e inner join usuarios as u on u.idusuario = e.IdEjecutivo where e.idcliente = t.idcliente for xml path('')) end as Ejecutivos, isnull((select distinct p.idpoliza + ' = ' + v.NombreVendedor + ', ' from Polizas as p inner join PolizasVendedores as pv on p.idpoliza = pv.idpoliza and p.idproducto = pv.idproducto inner join Vendedores as v on v.idvendedor = pv.idvendedor where p.MotivoCancelacion is null and p.FechaCancelacion is null and p.EstadoPoliza = 'VIGENTE' and p.idcliente = t.idcliente for xml path('') ),'') as Vendedores,c.FechaNacimiento as FechaNacimiento, null as NombreRepLegal, null as FnacRepLegal, case t.IdTipoCliente when 'NA' then 'Natural' when 'JU' then 'Persona Jurídica' when 'GU' then 'Gubernamental' when 'GA' then 'Gubernamental Autónoma' when 'JE' then 'Persona Jurídica Exenta' end as TipoCliente  from Clientes as t inner join ClientesContactos as c on t.idcliente = c.idcliente"
        End If
    End Sub

    Private Sub ContactosGeneralesNav_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call FixGridSize()
    End Sub

    Private Sub optSoloContactos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSoloContactos.CheckedChanged
        If Me.Visible = True Then Call Me.CargarRegistros()
    End Sub

    Private Sub optTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTodos.CheckedChanged
        If Me.Visible = True Then Call Me.CargarRegistros()
    End Sub


    Private Sub FixGridSize()
        Try
            Me.GridNav.Width = Me.Width - 20
            Me.GridNav.Height = Me.Height - 105
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContactosGeneralesNav_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        FixGridSize()
    End Sub

End Class
