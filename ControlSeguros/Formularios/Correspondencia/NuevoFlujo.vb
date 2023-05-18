Imports Utilerias.Genericas

Public Class NuevoFlujo

    Public IdClienteDefault As String = ""
    Public ObservacionDefault As String = ""

    Private Sub NuevoFlujo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtObservacion.Focus()
    End Sub

    Private Sub NuevoFlujo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdNuevoFlujo = ""
        Me.cboIdFlujo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdFlujo.Llenar_Combo()

        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Me.cboIdRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdRamo.Llenar_Combo()

        Me.cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboAseguradora.Llenar_Combo()

        Me.cboUbicaciones.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboUbicaciones.Llenar_Combo()

        Me.cboIdUsuarioSolicita.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdUsuarioSolicita.Llenar_Combo()
        Me.cboIdUsuarioSolicita.Valor = StiGlobalConn.User

        Me.cboUsuarioDestinatario.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboUsuarioDestinatario.Llenar_Combo()

        Me.cboIdCiudad.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdCiudad.Llenar_Combo()

        Me.cboZona.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboZona.Llenar_Combo()


        If IdClienteDefault <> "" Then
            Call LimpiarDatosRelacionados()
            Dim sql As String = ""
            txtIdCliente.Valor = IdClienteDefault
            txtIdCliente.SoloLectura = True
            Me.txtNombreCliente.SoloLectura = True
            Try
                sql = "  select c.NombreCliente "
                sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                sql &= " from Clientes as c"
                sql &= " where idcliente = " & dbStr(IdClienteDefault)
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")
                txtDireccion.Valor = dbData(FilClie, "Direccion")
                cboIdCiudad.Valor = clSeguros.ObtenerIdCiudad(dbData(FilClie, "Ciudad"))

                Call AsignarEjecutivo()
            Catch ex As Exception

            End Try
        End If

        If ObservacionDefault <> "" Then
            Me.txtObservacion.Valor = ObservacionDefault
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        Dim sql As String = ""
        busCodigo = ""
        Fbus.IdClienteDefault = Me.IdClienteDefault
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Call LimpiarDatosRelacionados()

            txtIdCliente.Valor = busCodigo
            Try
                sql = "  select c.NombreCliente "
                sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                sql &= " from Clientes as c"
                sql &= " where idcliente = " & dbStr(busCodigo)
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")
                txtDireccion.Valor = dbData(FilClie, "Direccion")
                cboIdCiudad.Valor = clSeguros.ObtenerIDCiudad(dbData(FilClie, "Ciudad"))

                Call AsignarEjecutivo()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.IdClienteDefault = Me.IdClienteDefault
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Call LimpiarDatosRelacionados()
            Dim sql As String = ""

            sql = "  select p.IdPoliza, p.IdProducto, p.IdCliente, p.NombreCliente, p.VigenciaDesde, p.VigenciaHasta, r.idaseguradora"
            sql &= " ,isnull(c.RegistroFiscal,'') as RegistroFiscal"
            sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
            sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
            sql &= " from Polizas as p "
            sql &= " left join Productos as r on r.idproducto = p.idproducto "
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"

            sql &= " where p.IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and p.IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))

            Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
            txtIdPoliza.Valor = dbData(FilPol, "IdPoliza")
            cboIdProducto.Valor = dbData(FilPol, "IdProducto")
            txtIdCliente.Valor = dbData(FilPol, "IdCliente")
            txtNombreCliente.Valor = dbData(FilPol, "NombreCliente")
            txtDireccion.Valor = dbData(FilPol, "Direccion")
            cboIdCiudad.Valor = clSeguros.ObtenerIdCiudad(dbData(FilPol, "Ciudad"))
            cboAseguradora.Valor = dbData(FilPol, "IdAseguradora")
            Call AsignarEjecutivo()
        End If
    End Sub

    Private Sub btnBuscarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFactura.Click
        Dim fbus As New BusquedaFacturas
        Dim sql As String = ""
        'Buscamos solo facturas pendientes de pago
        fbus.dbFiltro = ""
        busCodigo = ""
        fbus.IdClienteDefault = Me.IdClienteDefault
        fbus.ShowDialog()
        If busCodigo <> "" Then
            Call LimpiarDatosRelacionados()
            Dim Factura As String = stiSplit(busCodigo, "G0|1")
            Dim Producto As String = stiSplit(busCodigo, "G1|1")
            Dim Poliza As String = stiSplit(busCodigo, "G2|1")
            Dim Ramo As String = stiSplit(busCodigo, "G3|1")
            Try
                Me.txtNumeroFactura.Valor = Factura
                Me.cboIdProducto.Valor = Producto
                Me.txtIdPoliza.Valor = Poliza
                Me.cboIdRamo.Valor = Ramo

                sql = "  select f.idcliente, f.nombrecliente, r.IdAseguradora "
                sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                sql &= " from facturas as f"
                sql &= " inner join Clientes as c on c.idcliente = f.idcliente"
                sql &= " left join Productos as r on r.idproducto = f.idproducto "
                sql &= " where f.idpoliza = " & dbStr(Poliza) & " and f.idproducto = " & dbStr(Producto) & " and f.numerofactura = " & dbInt(Factura) & " and f.idramo = " & dbStr(Ramo)

                Dim filFactura As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtIdCliente.Valor = dbData(filFactura, "idcliente")
                txtNombreCliente.Valor = dbData(filFactura, "nombrecliente")
                txtDireccion.Valor = dbData(filFactura, "Direccion")
                cboIdCiudad.Valor = clSeguros.ObtenerIdCiudad(dbData(filFactura, "Ciudad"))
                cboAseguradora.Valor = dbData(filFactura, "IdAseguradora")
                Call AsignarEjecutivo()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBuscarSiniestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSiniestro.Click
        ''busCodigo = VistaSiniestros.GetRowCellValue(FilFactura, "Poliza") & "|" & VistaSiniestros.GetRowCellValue(FilFactura, "Producto") & "|" & VistaSiniestros.GetRowCellValue(FilFactura, "Certificado") & "|" & VistaSiniestros.GetRowCellValue(FilFactura, "Siniestro")

        Dim fbus As New BusquedaSiniestros
        Dim sql As String = ""
        'Buscamos solo facturas pendientes de pago
        fbus.dbFiltro = ""
        busCodigo = ""
        fbus.IdClienteDefault = Me.IdClienteDefault
        fbus.ShowDialog()
        If busCodigo <> "" Then
            Call LimpiarDatosRelacionados()
            Dim Poliza As String = stiSplit(busCodigo, "G0|1")
            Dim Producto As String = stiSplit(busCodigo, "G1|1")
            Dim Certificado As String = stiSplit(busCodigo, "G2|1")
            Dim Siniestro As String = stiSplit(busCodigo, "G3|1")
            Try
                Me.txtIdSiniestro.Valor = Siniestro
                Me.cboIdProducto.Valor = Producto
                Me.txtIdPoliza.Valor = Poliza

                sql = "  select p.nombrecliente, p.idcliente, r.IdAseguradora "
                sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                sql &= " from Siniestros as s "
                sql &= " inner join Polizas as p on s.idproducto = p.idproducto and p.idpoliza = s.idpoliza"
                sql &= " inner join Clientes as c on c.idcliente = p.idcliente"
                sql &= " left join Productos as r on r.idproducto = s.idproducto "
                sql &= " where s.idpoliza = " & dbStr(Poliza) & " and s.idproducto = " & dbStr(Producto) & " and s.IdCertificado = " & dbStr(Certificado) & " and s.IdSiniestro = " & dbStr(Siniestro)
                Dim filFactura As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                Me.txtIdCliente.Valor = dbData(filFactura, "idcliente")
                txtNombreCliente.Valor = dbData(filFactura, "nombrecliente")
                txtDireccion.Valor = dbData(filFactura, "Direccion")
                cboIdCiudad.Valor = clSeguros.ObtenerIdCiudad(dbData(filFactura, "Ciudad"))
                cboAseguradora.Valor = dbData(filFactura, "IdAseguradora")
                Call AsignarEjecutivo()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnBuscarAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAC.Click
        Dim fbus As New BusquedaAC
        Dim sql As String = ""
        'Buscamos solo facturas pendientes de pago
        fbus.dbFiltro = ""
        busCodigo = ""
        fbus.IdClienteDefault = Me.IdClienteDefault
        fbus.ShowDialog()
        If busCodigo <> "" Then
            Call LimpiarDatosRelacionados()
            Dim IdAC As String = stiSplit(busCodigo, "G0|1")
            Try
                Me.txtIdAC.Valor = IdAC

                sql = "  select v.idcliente, v.nombrecliente, v.idpoliza, v.idproducto, v.idramo, r.IdAseguradora "
                sql &= " ,(select top 1 isnull(Direccion,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Direccion"
                sql &= " ,(select top 1 isnull(Ciudad,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by cc.usocorrespondencia desc, IdContacto asc) as Ciudad"
                sql &= " from avisoscobro as v"
                sql &= " inner join clientes as c on c.idcliente = v.idcliente"
                sql &= " left join Productos as r on r.idproducto = v.idproducto "
                sql &= " where v.idavisocobro = " & dbStr(IdAC)


                Dim filAC As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtIdCliente.Valor = dbData(filAC, "idcliente")
                txtNombreCliente.Valor = dbData(filAC, "nombrecliente")
                txtIdPoliza.Valor = dbData(filAC, "idpoliza")
                cboIdProducto.Valor = dbData(filAC, "idproducto")
                cboIdRamo.Valor = dbData(filAC, "idramo")
                txtDireccion.Valor = dbData(filAC, "Direccion")
                cboIdCiudad.Valor = clSeguros.ObtenerIdCiudad(dbData(filAC, "Ciudad"))
                Me.cboAseguradora.Valor = dbData(filAC, "IdAseguradora")
                Call AsignarEjecutivo()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim res As String = ""

        Try
            'primero validamos si no hay campos obligatorios vacios
            Dim ErrObligatorios As String = Me.ValidarCamposObligatorios(Me)
            If ErrObligatorios <> "" Then
                MsgBox("Existen campos obligatorios que deben ser completados: " & ErrObligatorios, MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        If txtObservacion.Text = "" Then
            MsgBox("Debe especificar la descripción del documento.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If cboIdUsuarioSolicita.Text = "" Then
            MsgBox("Debe especificar el usuario que solicita el flujo.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If cboIdFlujo.Valor = "" Then
            MsgBox("Debe especificar le flujo que iniciará", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtIdCliente.Text = "" And Me.txtNombreCliente.Text = "" And Me.txtIdPoliza.Text = "" And Me.cboIdProducto.Text = "" And Me.txtNumeroFactura.Text = "" And cboIdRamo.Text = "" And Me.txtIdAC.Text = "" And Me.txtIdSiniestro.Text = "" And Me.cboAseguradora.Text = "" Then
            MsgBox("Debe especificar la información del paso 2, información sobre el documento.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        'una validación para no hacer flujos sobre pólizas con ciertos tipos de cancelación
        Dim LstCancela As String = clSeguros.ObtenerDBParametros("Cod.Cancela.Restringe")
        If LstCancela <> "" Then
            Try
                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset("select p.IdCancelacion, t.NombreCancelacion from Polizas as p left join TipoCancelacion as t on p.IdCancelacion = t.IdCancelacion where p.idpoliza = " & dbStr(txtIdPoliza.Valor) & " and p.idproducto = " & dbStr(cboIdProducto.Valor)).Tables(0).Rows(0)
                If ExisteItemEnLista(dbData(FilPol, "IdCancelacion"), LstCancela) = True Then
                    MsgBox("La póliza especificada está cancelada y el tipo de cancelación restringe esta operación: " & dbData(FilPol, "NombreCancelacion"), MsgBoxStyle.Information, "AVISO...")
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
        End If

        clFlujos.IniciarFlujo(cboIdUsuarioSolicita.Valor, cboUsuarioDestinatario.Valor, cboIdFlujo.Valor, txtObservacion.Valor, txtIdPoliza.Valor, cboIdProducto.Valor, txtNumeroFactura.Valor, cboIdRamo.Valor, txtIdSiniestro.Valor, txtIdCliente.Valor, txtNombreCliente.Valor, cboAseguradora.Valor, txtIdAC.Valor, cboUbicaciones.Valor, txtDireccion.Valor, cboIdCiudad.Valor, cboZona.Valor, IdNuevoFlujo, res)
        If res <> "" Then
            MsgBox("Aviso flujo de correspondencia:" & vbCrLf & res, MsgBoxStyle.Critical, "Error...")
        Else
            'MsgBox("El flujo ha sido iniciado con éxito.", MsgBoxStyle.Information, "AVISO...")
            MsgBox("Aviso flujo de correspondencia:" & vbCrLf & "Se ha creado el flujo: " & IdNuevoFlujo, MsgBoxStyle.Information, "AVISO...")
            Me.Close()
            'Me.LimpiarCampos(Me)
            'Me.txtObservacion.Focus()
        End If

    End Sub

    Private Sub LimpiarDatosRelacionados()
        Me.txtIdPoliza.Valor = ""
        Me.cboIdProducto.Valor = ""
        Me.cboIdRamo.Valor = ""
        Me.txtIdCliente.Valor = ""
        Me.txtNombreCliente.Valor = ""
        Me.txtIdAC.Valor = ""
        Me.cboAseguradora.Valor = ""
        Me.txtNumeroFactura.Valor = ""
        Me.txtIdSiniestro.Valor = ""

        Me.cboUbicaciones.Valor = ""
        Me.txtDireccion.Valor = ""
        Me.cboIdCiudad.Valor = ""
        Me.cboZona.Valor = ""

    End Sub

    Private Sub cboAseguradora_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboAseguradora.ValueChangeOnExit
        If cboAseguradora.Valor <> "" Then
            Try
                Dim FilAseg As DataRow
                Dim sql As String = ""

                sql = "  select Direccion from Aseguradoras where idaseguradora = " & dbStr(cboAseguradora.Valor)
                FilAseg = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtDireccion.Valor = dbData(FilAseg, "Direccion")

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cboUbicaciones_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboUbicaciones.ValueChangeOnExit
        If cboUbicaciones.Valor <> "" Then
            Try
                Dim FilUbi As DataRow
                Dim sql As String = ""

                sql = "  select Direccion, IdCiudad, IdZona"
                sql &= " from Ubicaciones "
                sql &= " where IdUbicacion = " & dbStr(cboUbicaciones.Valor)
                FilUbi = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtDireccion.Valor = dbData(FilUbi, "Direccion")
                cboIdCiudad.Valor = dbData(FilUbi, "IdCiudad")
                cboZona.Valor = dbData(FilUbi, "IdZona")

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtNombreCliente_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtNombreCliente.ValueChangeOnExit

    End Sub

    Private Sub txtIdCliente_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtIdCliente.ValueChangeOnExit

    End Sub

    Private Sub AsignarEjecutivo()
        Try
            If clSeguros.ObtenerDBParametros("Flujos.Asignar.Ejecutivo") = "S" Then
                Dim AREA As String = "POLIZAS"
                If Me.txtIdSiniestro.Text <> "" Then AREA = "RECLAMOS"
                cboUsuarioDestinatario.Valor = clSeguros.ObtenerEjecutivoCuenta(Me.txtIdCliente.Valor, Me.cboIdProducto.Valor, AREA)
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
