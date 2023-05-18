Imports Utilerias.Genericas

Public Class Gestiones

    Public TipoGestion As String = ""
    Public NumeroFactura As String = ""
    Public IdPoliza As String = ""
    Public IdProducto As String = ""
    Public IdSiniestro As String = ""
    Public IdCliente As String = ""
    Public IdCertificado As String = ""
    Public IncluirCliente As Boolean = False

    Private Sub Gestiones_DespuesDeGuardar() Handles Me.DespuesDeGuardar
        'agregamos una cita.
        If chkCita.Checked = True Then
            Call PrepararCitaOutlook()
        End If

        'si la gestion es realizar un correo preparamos el correo
        If Me.chkCorreo.Checked = True Then
            Call PrepararCorreo()
        End If

    End Sub

    Private Sub PrepararCitaOutlook()
        Select Case cboTipoGestion.Valor
            Case "C"
                Dim Fecha As DateTime = txtFechaProximaGestion.Valor
                Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, CDate(txtHora.EditValue).Hour, CDate(txtHora.EditValue).Minute, 0)

                'buscaremos nombre, telefono del cliente de la factura
                Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = "", Cuota As String = ""
                Try
                    sql = "  select "
                    sql &= " f.NombreCliente "
                    sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                    sql &= " ,c.EMail"
                    sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) + ' - $' + cast((select TOP 1 Total from FacturasMovimientos as m where m.idpoliza = f.idpoliza and m.idproducto = f.idproducto and m.idramo = f.idramo and m.NumeroFactura = f.NumeroFactura and m.IdMovimiento = 1) as varchar) as Cuota"
                    sql &= " from Facturas as f "
                    sql &= " left join Clientes as c on c.idcliente = f.idcliente"
                    sql &= " where f.NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and f.IdProducto = " & dbStr(txtIdProducto.Valor) & " and f.IdPoliza = " & dbStr(txtIdPoliza.Valor)
                    Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Cliente = dbData(fila, "NombreCliente")
                    Telefono = dbData(fila, "Telefono")
                    Correo = dbData(fila, "EMail")
                    Cuota = dbData(fila, "Cuota")
                Catch ex As Exception

                End Try

                Dim Mensaje As String = ""
                Mensaje &= "Cliente: " & Cliente & vbCrLf
                Mensaje &= "Póliza: " & txtIdPoliza.Valor & vbCrLf
                Mensaje &= "Cuota: " & Cuota & vbCrLf
                Mensaje &= "Teléfono: " & Telefono & vbCrLf
                Mensaje &= "Correo: " & Correo & vbCrLf
                Mensaje &= "Notas: " & txtComentarios.Valor & vbCrLf

                Dim res As String = AgregarCitaOutlook("Gestión Cartera ", cboIdAccionTomar.Descripcion, Mensaje, Inicio, Inicio.AddHours(1))
                If res <> "" Then
                    MsgBox("No es posible agregar al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                End If

            Case "S"
                Dim Fecha As DateTime = txtFechaProximaGestion.Valor
                Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)

                'buscaremos nombre, telefono del cliente del siniestro y de la aseguradora
                Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                Dim Aseguradora As String = "", TelAse As String = "", Reclamo As String = "", Poliza As String = ""
                Try
                    sql = "  select "
                    sql &= " s.NombrePresentaReclamo  "
                    sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                    sql &= " ,c.EMail"
                    sql &= " ,a.Nombre as Aseguradora"
                    sql &= " ,a.Telefono as TelefonoAseg, s.IdSiniestroAseguradora, s.IdPoliza"
                    sql &= " from Siniestros as s"
                    sql &= " inner join Productos as p on p.idproducto = s.idproducto"
                    sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                    sql &= " left join PolizasCertificados as ce on ce.idpoliza = s.idpoliza and ce.idproducto = s.idproducto and ce.idcertificado = s.idcertificado"
                    sql &= " left join Clientes as c on c.idcliente = ce.idcliente"
                    sql &= " where s.idsiniestro = " & dbStr(IdSiniestro) & " and s.IdProducto = " & dbStr(IdProducto) & " and s.IdPoliza = " & dbStr(IdPoliza) & " and s.idcertificado = " & dbStr(IdCertificado)
                    Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Cliente = dbData(fila, "NombrePresentaReclamo")
                    Telefono = dbData(fila, "Telefono")
                    Correo = dbData(fila, "EMail")
                    Aseguradora = dbData(fila, "Aseguradora")
                    TelAse = dbData(fila, "TelefonoAseg")
                    Reclamo = dbData(fila, "IdSiniestroAseguradora")
                    Poliza = dbData(fila, "IdPoliza")

                Catch ex As Exception

                End Try
                Dim res As String = AgregarCitaOutlook("Gestión - Reclamo /" & cboIdAccionTomar.Text, "", txtComentarios.Valor & vbCrLf & "Aseguradora: " & TelAse & " / " & Aseguradora & vbCrLf & "Póliza: " & Poliza & vbCrLf & "Reclamo: " & Reclamo & vbCrLf & "Asegurado:" & Cliente & vbCrLf & Telefono & vbCrLf & Correo, Inicio, Inicio.AddHours(1))
                If res <> "" Then
                    MsgBox("No es posible agregar al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                End If

            Case "P"
                Dim Fecha As DateTime = txtFechaProximaGestion.Valor
                Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)

                'buscaremos nombre, telefono del cliente de la póliza
                Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                Try
                    sql = "  select "
                    sql &= " p.NombreCliente "
                    sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                    sql &= " ,c.EMail"
                    sql &= " from Polizas as p "
                    sql &= " left join Clientes as c on c.idcliente = p.idcliente"
                    sql &= " where p.IdProducto = " & dbStr(txtIdProducto.Valor) & " and p.IdPoliza = " & dbStr(txtIdPoliza.Valor)
                    Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Cliente = dbData(fila, "NombreCliente")
                    Telefono = dbData(fila, "Telefono")
                    Correo = dbData(fila, "EMail")
                Catch ex As Exception

                End Try

                Dim Mensaje As String = ""
                Mensaje &= "Cliente: " & Cliente & vbCrLf
                Mensaje &= "Póliza: " & txtIdPoliza.Valor & vbCrLf
                Mensaje &= "Teléfono: " & Telefono & vbCrLf
                Mensaje &= "Correo: " & Correo & vbCrLf
                Mensaje &= "Notas: " & txtComentarios.Valor & vbCrLf

                Dim res As String = AgregarCitaOutlook("Gestión Póliza ", cboIdAccionTomar.Descripcion, Mensaje, Inicio, Inicio.AddHours(1))
                If res <> "" Then
                    MsgBox("No es posible agregar al calendario de Microsoft Outlook.", MsgBoxStyle.Information, "AVISO...")
                End If
        End Select
    End Sub

    Private Sub PrepararCorreo()
        Dim Mensaje As String = ""
        Select Case cboTipoGestion.Valor
            Case "C"
                Dim Fecha As DateTime = txtFechaProximaGestion.Valor
                Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)

                'buscaremos nombre, telefono del cliente de la factura
                Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = "", Cuota As String = ""
                Try
                    sql = "  select "
                    sql &= " f.NombreCliente "
                    sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                    sql &= " ,c.EMail"
                    sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) + ' - $' + cast((select TOP 1 Total from FacturasMovimientos as m where m.idpoliza = f.idpoliza and m.idproducto = f.idproducto and m.idramo = f.idramo and m.NumeroFactura = f.NumeroFactura and m.IdMovimiento = 1) as varchar) as Cuota"
                    sql &= " from Facturas as f "
                    sql &= " left join Clientes as c on c.idcliente = f.idcliente"
                    sql &= " where f.NumeroFactura = " & dbInt(txtNumeroFactura.Valor) & " and f.IdProducto = " & dbStr(txtIdProducto.Valor) & " and f.IdPoliza = " & dbStr(txtIdPoliza.Valor)
                    Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Cliente = dbData(fila, "NombreCliente")
                    Telefono = dbData(fila, "Telefono")
                    Correo = dbData(fila, "EMail")
                    Cuota = dbData(fila, "Cuota")
                Catch ex As Exception

                End Try


                Mensaje &= "Cliente: " & Cliente & vbCrLf
                Mensaje &= "Póliza: " & txtIdPoliza.Valor & vbCrLf
                Mensaje &= "Cuota: " & Cuota & vbCrLf
                Mensaje &= "Teléfono: " & Telefono & vbCrLf
                Mensaje &= "Notas: " & txtComentarios.Valor & vbCrLf

                'Preparamos el correo
                PrepararCorreoOutlook(Correo, "Gestión de Cartera", Mensaje, "")

            Case "S"
                Dim Fecha As DateTime = txtFechaProximaGestion.Valor
                Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)

                'buscaremos nombre, telefono del cliente del siniestro y de la aseguradora
                Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                Dim Aseguradora As String = "", TelAse As String = "", Reclamo As String = "", Poliza As String = ""
                Try
                    sql = "  select "
                    sql &= " s.NombrePresentaReclamo  "
                    sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                    sql &= " ,c.EMail"
                    sql &= " ,a.Nombre as Aseguradora"
                    sql &= " ,a.Telefono as TelefonoAseg, s.IdSiniestroAseguradora, s.IdPoliza"
                    sql &= " from Siniestros as s"
                    sql &= " inner join Productos as p on p.idproducto = s.idproducto"
                    sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
                    sql &= " left join PolizasCertificados as ce on ce.idpoliza = s.idpoliza and ce.idproducto = s.idproducto and ce.idcertificado = s.idcertificado"
                    sql &= " left join Clientes as c on c.idcliente = ce.idcliente"
                    sql &= " where s.idsiniestro = " & dbStr(IdSiniestro) & " and s.IdProducto = " & dbStr(IdProducto) & " and s.IdPoliza = " & dbStr(IdPoliza) & " and s.idcertificado = " & dbStr(IdCertificado)
                    Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Cliente = dbData(fila, "NombrePresentaReclamo")
                    Telefono = dbData(fila, "Telefono")
                    Correo = dbData(fila, "EMail")
                    Aseguradora = dbData(fila, "Aseguradora")
                    TelAse = dbData(fila, "TelefonoAseg")
                    Reclamo = dbData(fila, "IdSiniestroAseguradora")
                    Poliza = dbData(fila, "IdPoliza")

                Catch ex As Exception

                End Try

                Mensaje = txtComentarios.Valor & vbCrLf
                Mensaje &= "Aseguradora: " & TelAse & " / " & Aseguradora & vbCrLf
                Mensaje &= "Póliza: " & Poliza & vbCrLf
                Mensaje &= "Reclamo: " & Reclamo & vbCrLf
                Mensaje &= "Asegurado:" & Cliente & vbCrLf & Telefono & vbCrLf & Correo
                PrepararCorreoOutlook(Correo, "Gestión de Reclamo", Mensaje, "")

            Case "P"
                Dim Fecha As DateTime = txtFechaProximaGestion.Valor
                Dim Inicio As New DateTime(Fecha.Year, Fecha.Month, Fecha.Day, 8, 0, 0)

                'buscaremos nombre, telefono del cliente de la factura
                Dim sql As String = "", Cliente As String = "", Telefono As String = "", Correo As String = ""
                Try
                    sql = "  select "
                    sql &= " p.NombreCliente "
                    sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
                    sql &= " ,c.EMail"
                    sql &= " from Polizas as p "
                    sql &= " left join Clientes as c on c.idcliente = p.idcliente"
                    sql &= " where p.IdProducto = " & dbStr(txtIdProducto.Valor) & " and p.IdPoliza = " & dbStr(txtIdPoliza.Valor)
                    Dim fila As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                    Cliente = dbData(fila, "NombreCliente")
                    Telefono = dbData(fila, "Telefono")
                    Correo = dbData(fila, "EMail")
                Catch ex As Exception

                End Try

                Mensaje &= "Cliente: " & Cliente & vbCrLf
                Mensaje &= "Póliza: " & txtIdPoliza.Valor & vbCrLf
                Mensaje &= "Teléfono: " & Telefono & vbCrLf
                Mensaje &= "Notas: " & txtComentarios.Valor & vbCrLf

                'Preparamos el correo
                PrepararCorreoOutlook(Correo, "Gestión de Pólizas", Mensaje, "")

        End Select
    End Sub

    Private Sub Gestiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dtTipos As DataTable = StiGlobalConn.ObtenerDataset("select IdTipoGestion as [Id], NombreGestion as [Descripción] from TipoGestion").Tables(0)
            RepositoryItemLookUpEdit1.ValueMember = "Id"
            RepositoryItemLookUpEdit1.DisplayMember = "Descripción"
            RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
            RepositoryItemLookUpEdit1.DataSource = dtTipos
            RepositoryItemLookUpEdit1.PopulateColumns()
        Catch ex As Exception

        End Try

        Me.txtHora.EditValue = New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day, 8, 0, 0)
        
        Try
            If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
                If TipoGestion <> "" Then
                    ''cboTipoGestion.Llenar_Combo()
                    cboTipoGestion.Valor = TipoGestion
                    cboTipoGestion.SoloLectura = True
                End If
                txtIdPoliza.SoloLectura = True
                If IdPoliza <> "" Then
                    txtIdPoliza.Valor = IdPoliza
                End If
                txtIdProducto.SoloLectura = True
                If IdProducto <> "" Then
                    txtIdProducto.Valor = IdProducto
                End If
                txtIdSiniestro.SoloLectura = True
                If IdSiniestro <> "" Then
                    txtIdSiniestro.Valor = IdSiniestro
                End If

                txtIdCertificado.SoloLectura = True
                If IdCertificado <> "" Then
                    txtIdCertificado.Valor = IdCertificado
                End If

                txtNumeroFactura.SoloLectura = True
                If NumeroFactura <> "" Then
                    txtNumeroFactura.Valor = NumeroFactura
                End If
                txtIdGestion.SoloLectura = True
                txtIdGestion.Valor = clSeguros.ObtenerID("Gestion.Id")

                txtFechaGestion.Valor = Date.Today
                Me.txtIdUsuario.Valor = StiGlobalConn.User

                Me.txtFechaGrabacion.Valor = Date.Now.ToString("yyyyMMdd HH:mm:ss")
            End If
            If Me.EstadoRegistro = enEstadoRegistro.Modificando Then
                IdProducto = txtIdProducto.Valor
                IdPoliza = txtIdPoliza.Valor
            End If

            Call ObtenerGestiones()
            Call ObtenerRegistros()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ObtenerGestiones()
        Dim sql As String = ""
        Select Case cboTipoGestion.Valor
            Case "C"         'gestiones de cartera
                If IdProducto <> "" And IdPoliza <> "" Then
                    sql = "  select IdGestion, FechaGestion, FechaProximaGestion, IdTipoGestion, Comentarios, FechaGrabacion"
                    sql &= " from Gestiones"
                    sql &= " where TipoGestion  = 'C' "
                    sql &= " and IdPoliza = " & dbStr(IdPoliza)
                    sql &= " and IdProducto = " & dbStr(IdProducto)
                    sql &= " order by FechaGestion desc"
                    Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridGestiones.DataSource = dtDatos
                    GridGestiones.Refresh()
                End If

            Case "S"
                Me.btnIncluirCliente.Visible = False
                If IdProducto <> "" And IdPoliza <> "" And IdSiniestro <> "" Then
                    sql = "  select IdGestion, FechaGestion, FechaProximaGestion, IdTipoGestion, Comentarios, FechaGrabacion"
                    sql &= " from Gestiones"
                    sql &= " where IdProducto = " & dbStr(IdProducto)
                    sql &= " and IdPoliza = " & dbStr(IdPoliza)
                    sql &= " and IdSiniestro = " & dbStr(IdSiniestro)
                    sql &= " and TipoGestion  = 'S' "
                    sql &= " order by FechaGestion desc"
                    Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridGestiones.DataSource = dtDatos
                    GridGestiones.Refresh()
                End If

            Case "P"  'gestion de pólizas
                Me.btnIncluirCliente.Visible = False
                If IdProducto <> "" And IdPoliza <> "" Then
                    sql = "  select IdGestion, FechaGestion, FechaProximaGestion, IdTipoGestion, Comentarios, FechaGrabacion"
                    sql &= " from Gestiones"
                    sql &= " where IdProducto = " & dbStr(IdProducto)
                    sql &= " and IdPoliza = " & dbStr(IdPoliza)
                    sql &= " and TipoGestion  = 'P' "
                    sql &= " order by FechaGestion desc"
                    Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridGestiones.DataSource = dtDatos
                    GridGestiones.Refresh()
                End If
        End Select
    End Sub

    Private Sub CargarGestion(ByVal IdGestion As Integer)
        Try
            Dim FilGestion As DataRow = StiGlobalConn.ObtenerDataset("select * from Gestiones where IdGestion = " & dbInt(IdGestion)).Tables(0).Rows(0)
            txtIdGestion.Valor = dbData(FilGestion, "IdGestion")
            txtFechaGestion.Valor = dbData(FilGestion, "FechaGestion")
            txtComentarios.Valor = dbData(FilGestion, "Comentarios")
            cboIdTipoGestion.Valor = dbData(FilGestion, "IdTipoGestion")
            txtFechaProximaGestion.Valor = dbData(FilGestion, "FechaProximaGestion")
            cboIdAccionTomar.Valor = dbData(FilGestion, "IdAccionTomar")
            cboTipoGestion.Valor = dbData(FilGestion, "TipoGestion")
            txtIdPoliza.Valor = dbData(FilGestion, "IdPoliza")
            txtNumeroFactura.Valor = dbData(FilGestion, "NumeroFactura")
            txtIdProducto.Valor = dbData(FilGestion, "IdProducto")
            txtIdSiniestro.Valor = dbData(FilGestion, "IdSiniestro")
            txtIdCertificado.Valor = dbData(FilGestion, "IdCertificado")
            txtIdUsuario.Valor = dbData(FilGestion, "IdUsuario")
            txtFechaGrabacion.Valor = dbData(FilGestion, "FechaGrabacion")
            txtFechaInicia.Valor = dbData(FilGestion, "FechaInicia")
            Me.EstadoRegistro = enEstadoRegistro.Modificando

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ObtenerRegistros()
        'obtendremos los registros relacionados con la gestion
        Dim sql As String = ""
        Select Case cboTipoGestion.Valor
            Case "C"
                'gestiones de cartera buscaremos las primas pendientes a la fecha de los registros relacionados
                If IdProducto <> "" And IdPoliza <> "" Then

                    'para las gestiones lo ideal es mostrar las primas de todos los productos del cliente.
                    Dim IdCliente As String = ""
                    IdCliente = StiGlobalConn.ObtenerDataset("select idcliente from facturas where idproducto = " & dbStr(IdProducto) & " and idpoliza = " & dbStr(IdPoliza)).Tables(0).Rows(0).Item(0)

                    sql = "  select f.NumeroFactura as NumeroFactura"
                    sql &= " , p.Descripcion as Producto"
                    sql &= " , r.NombreRamo as Ramo"
                    sql &= " , f.IdPoliza as Poliza"
                    sql &= " , f.NombreCliente as NombreCliente"
                    sql &= " , f.FechaPago as FechaPago"
                    sql &= " , f.VencimientoTardio as Venc_Tardio"
                    sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
                    sql &= " , DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as DiasMora"
                    sql &= " , (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as TotalCuota"
                    sql &= " from facturas as f "
                    sql &= " left join Productos as p on f.idproducto = p.idproducto"
                    sql &= " left join RamoSeguros as r on r.IdRamo = f.IdRamo"
                    sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
                    sql &= " where "
                    'que la fecha de pago sea menor a la fecha de corte
                    sql &= " f.FechaPago <= " & dbFec(Date.Today)
                    'que tengan saldo positivo
                    sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
                    'sql &= " and 
                    'sql &= " 

                    If Me.IncluirCliente = True Then
                        sql &= " and ( (f.idcliente = " & dbStr(IdCliente) & " ) or (f.IdProducto = " & dbStr(IdProducto) & " and f.IdPoliza = " & dbStr(IdPoliza) & ") )"
                    Else
                        sql &= " and f.IdProducto = " & dbStr(IdProducto) & " and f.IdPoliza = " & dbStr(IdPoliza)
                    End If

                    sql &= " order by p.Descripcion, f.IdPoliza, f.FechaPago"
                    Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridRegistro.DataSource = dtDatos
                    GridRegistro.Refresh()

                    'totalizaremos la prime
                    Me.VistaRegistro.Columns("TotalCuota").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    Me.VistaRegistro.Columns("TotalCuota").DisplayFormat.FormatString = "c"
                    Me.VistaRegistro.Columns("TotalCuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Me.VistaRegistro.Columns("TotalCuota").SummaryItem.FieldName = "TotalCuota"
                    Me.VistaRegistro.Columns("TotalCuota").SummaryItem.DisplayFormat = "{0:c}"

                    Me.VistaRegistro.Columns("DiasMora").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Me.VistaRegistro.Columns("DiasMora").SummaryItem.FieldName = "TotalCuota"
                    Me.VistaRegistro.Columns("DiasMora").SummaryItem.DisplayFormat = "TOTAL MORA"
                End If

            Case "S"
                'gestiones de cartera buscaremos las primas pendientes a la fecha de los registros relacionados
                If IdProducto <> "" And IdPoliza <> "" And IdSiniestro <> "" Then

                    'para las gestiones lo ideal es mostrar todos los siniestros del certificado

                    sql = "  select "
                    sql &= " s.IdPoliza as [Póliza]"
                    sql &= " , p.Descripcion as Producto"
                    sql &= " , s.IdCertificado as Certificado"
                    sql &= " , s.IdSiniestro as Reclamo"
                    sql &= " , s.FechaOcurrido as [Fec.Ocurre]"
                    sql &= " , s.FechaPresentado as [Fec. Presenta]"
                    sql &= " , s.TotalPresentado as Presentado"
                    sql &= " , s.TotalReembolso as Pagado"
                    sql &= " from siniestros as s"
                    sql &= " inner join Productos as p on s.idproducto = p.idproducto"
                    sql &= " where s.idpoliza = " & dbStr(IdPoliza)
                    sql &= " and s.idproducto = " & dbStr(IdProducto)
                    sql &= " and s.IdCertificado = " & dbStr(IdCertificado)
                    sql &= " "
                    sql &= " order by s.FechaPresentado desc"
                    
                    Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridRegistro.DataSource = dtDatos
                    GridRegistro.Refresh()

                End If

            Case "P"
                'gestiones de pólizas mostraremos las pólizas vigentes del cliente 
                If IdProducto <> "" And IdPoliza <> "" Then

                    'para las gestiones lo ideal es mostrar todos los siniestros del certificado

                    sql = "  select "
                    sql &= " p.idpoliza as IdPoliza"
                    sql &= " ,pr.Descripcion as Producto"
                    sql &= " ,a.Nombre as Aseguradora"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,p.VigenciaDesde as VigenciaDesde"
                    sql &= " ,p.VigenciaHasta as VigenciaHasta"
                    sql &= " from Polizas as p"
                    sql &= " inner join Productos as pr on pr.idproducto = p.idproducto"
                    sql &= " inner join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
                    sql &= " left join Vendedores as v on v.idvendedor = p.idvendedor"
                    sql &= " where p.idcliente in (select idcliente from polizas where idpoliza = " & dbStr(IdPoliza) & " and idproducto = " & dbStr(IdProducto) & ") "
                    Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                    GridRegistro.DataSource = dtDatos
                    GridRegistro.Refresh()

                End If


        End Select
    End Sub

    Private Sub VistaRegistro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaRegistro.Click
        If Me.EstadoRegistro = enEstadoRegistro.Adicionando Then
            Dim Factura As String = "", Poliza As String = "", Producto As String = "", Siniestro As String = ""
            Dim Fila As Integer = VistaRegistro.FocusedRowHandle
            If Fila >= 0 Then
                Try
                    Factura = CStr(VistaRegistro.GetRowCellValue(Fila, "NumeroFactura")).Trim
                Catch ex As Exception
                    Factura = ""
                End Try
                Try
                    Poliza = CStr(VistaRegistro.GetRowCellValue(Fila, "Poliza")).Trim
                Catch ex As Exception
                    Poliza = ""
                End Try
                Try
                    Producto = CStr(VistaRegistro.GetRowCellValue(Fila, "Producto")).Trim
                Catch ex As Exception
                    Producto = ""
                End Try
                Try
                    Siniestro = CStr(VistaRegistro.GetRowCellValue(Fila, "Siniestro")).Trim
                Catch ex As Exception
                    Siniestro = ""
                End Try

                Me.txtIdPoliza.Valor = Poliza
                Me.txtIdSiniestro.Valor = Siniestro
                Me.txtIdProducto.Valor = Producto
                Me.txtNumeroFactura.Valor = Factura
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ''automaticamnete se almacenaran los registros, solo salimos
        
        Me.Close()
    End Sub

    Private Sub btnIncluirCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirCliente.CheckedChanged
        If btnIncluirCliente.Checked = True Then
            IncluirCliente = True
        Else
            IncluirCliente = False
        End If
        Call ObtenerGestiones()
        Call ObtenerRegistros()
    End Sub

    Private Sub VistaGestiones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaGestiones.Click
        Try
            Dim Fila As Integer = Me.VistaGestiones.FocusedRowHandle
            CargarGestion(VistaGestiones.GetRowCellValue(Fila, "IdGestion"))
        Catch ex As Exception

        End Try
    End Sub

End Class
