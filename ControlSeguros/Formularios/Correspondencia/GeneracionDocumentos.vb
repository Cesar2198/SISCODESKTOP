Imports Utilerias.Genericas


Public Class GeneracionDocumentos
    Dim dtDatos As DataTable
    Dim srtParAsegNombreCorto As String = ""

    Private Sub GeneracionDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strLista As String = ""
        srtParAsegNombreCorto = CStr(clSeguros.ObtenerDBParametros("Coor.Aseguradora.Sigla")).Trim.ToUpper

        'dtDatos = New DataTable("Documentos")
        'dtDatos.Columns.Add("Id", System.Type.GetType("System.String"))
        'dtDatos.Columns.Add("Documento", System.Type.GetType("System.String"))
        'dtDatos.Columns.Add("Destinatario", System.Type.GetType("System.String"))
        'Dim FilDatos As DataRow

        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "AC" : FilDatos("Documento") = "Aviso de Cobro" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "EC" : FilDatos("Documento") = "Estado de Cuenta" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CC" : FilDatos("Documento") = "Carta Comprobantes Anticipados" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CV" : FilDatos("Documento") = "Carta de Cobro" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CP" : FilDatos("Documento") = "Carta Envio de Comprobantes Pagados" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "AT" : FilDatos("Documento") = "Carta Autorización Cargo Tarjeta de Credito" : FilDatos("Destinatario") = "ASEGURADORA" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CT" : FilDatos("Documento") = "Carta Anulacion Cargo Tarjeta de Credito" : FilDatos("Destinatario") = "ASEGURADORA" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CQ" : FilDatos("Documento") = "Carta de Envio de Quedan" : FilDatos("Destinatario") = "ASEGURADORA" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "SP" : FilDatos("Documento") = "Carta de Solicitud Prorroga Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "RE" : FilDatos("Documento") = "Carta de Renovación Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "EO" : FilDatos("Documento") = "Carta de Emisión Inicial Cliente para Aseguradora" : FilDatos("Destinatario") = "ASEGURADORA" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "EE" : FilDatos("Documento") = "Carta de Emisión Inicial Empresa para Aseguradora" : FilDatos("Destinatario") = "ASEGURADORA" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CE" : FilDatos("Documento") = "Carta de Envíos de Certificados Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "DR" : FilDatos("Documento") = "Carta Documentación Reclamos Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CR" : FilDatos("Documento") = "Carta de Entrega de Cheques Reclamos Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CD" : FilDatos("Documento") = "Carta de Entrega de Cheques Reclamos Cliente Daños" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "CA" : FilDatos("Documento") = "Carta Convenio Ajuste Reclamo Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "DO" : FilDatos("Documento") = "Carta Documentos Emisión Póliza Cliente" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "DE" : FilDatos("Documento") = "Carta Documentos Emisión Póliza Empresa" : FilDatos("Destinatario") = "CLIENTE" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "EP" : FilDatos("Documento") = "Envíos de Pagos de Caja" : FilDatos("Destinatario") = "ASEGURADORA" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "MA" : FilDatos("Documento") = "Correo Electrónico" : FilDatos("Destinatario") = "" : dtDatos.Rows.Add(FilDatos)
        'FilDatos = dtDatos.NewRow : FilDatos("Id") = "VA" : FilDatos("Documento") = "Documentos Varios" : FilDatos("Destinatario") = "" : dtDatos.Rows.Add(FilDatos)

        dtDatos = StiGlobalConn.ObtenerDataset("SELECT IdDocumento AS Id, NombreDocumento as Documento, Destinatario from DocumentosCorrespondencia order by Orden asc").Tables(0)
        cboTipoDocumento.Llenar_Combo(dtDatos)


        Me.cboFlujo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboFlujo.Llenar_Combo()

        Me.txtFechaEnDocumento.Valor = Date.Today
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cboTipoDocumento_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles cboTipoDocumento.ValueChangeOnExit
        Call ObtenerDocumentos(Me.txtIdCliente.Valor)
        Call ActualizarListaFlujos()
        Call CompletarDireccionEnvio()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Dim Fbus As New BusquedaClientes
        Dim sql As String = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            txtIdCliente.Valor = busCodigo
            Try
                sql = "  select c.NombreCliente "
                sql &= " from Clientes as c"
                sql &= " where idcliente = " & dbStr(busCodigo)
                Dim FilClie As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtNombreCliente.Valor = dbData(FilClie, "NombreCliente")
                Me.cboFlujo.Focus()
            Catch ex As Exception

            End Try
            Call ObtenerDocumentos(Me.txtIdCliente.Valor)

            Call ActualizarListaFlujos()

            Call CompletarDireccionEnvio()
        End If
    End Sub

    Private Sub ActualizarListaFlujos()
        Try
            'filtraremos los flujos pendientes del cliente
            Dim CodDestinatario As String = "", FiltroDefault As String = ""
            Try
                CodDestinatario = CStr(dtDatos.Select("id = " & dbStr(cboTipoDocumento.Valor))(0)("Destinatario"))
            Catch ex As Exception
                CodDestinatario = ""
            End Try

            If CodDestinatario = "" Then
                Dim IDFlujoDefault = clSeguros.ObtenerDBParametros("Id.Flujo.Default")
                If IDFlujoDefault <> "" Then
                    Select Case GlobalCodCliente
                        Case "2120000"
                            '11/06/2018 quiere que ciertos flujos no se les proponga el defaul
                            Select Case CStr(cboTipoDocumento.Valor).Trim.ToUpper
                                Case "CP", "CC", "MA", "VA", "CR"
                                    FiltroDefault = " and a.IdFlujoDoc <> " & dbStr(IDFlujoDefault)
                                Case Else
                                    FiltroDefault = " or a.IdFlujoDoc = " & dbStr(IDFlujoDefault)
                            End Select
                        Case Else
                            FiltroDefault = " or a.IdFlujoDoc = " & dbStr(IDFlujoDefault)
                    End Select
                End If
            End If

            Dim strCliente As String = ""
            If txtIdCliente.Valor <> "" Then
                strCliente = " and a.IdCliente = " & dbStr(txtIdCliente.Valor)
            End If

            Dim strFiltroDias As String = ""
            Dim strDiasFlujo As String = clSeguros.ObtenerDBParametros("Flujos.Dias.Vencimiento")

            If strDiasFlujo <> "" Then
                Dim strlista() As String = strDiasFlujo.Split(",")
                strFiltroDias &= " and case "

                For I As Integer = 0 To strlista.Length - 1
                    If strlista(I).Trim <> "" Then
                        If strlista(I).Split("=")(0).Trim = "*" Then
                            strFiltroDias &= " else case when a.FechaInicia >= " & dbFec(DateAdd(DateInterval.Day, Val(strlista(I).Split("=")(1).Trim) * -1, Date.Today())) & " then 1 else 0 end "
                        Else
                            strFiltroDias &= " when a.IdFlujo = " & dbStr(strlista(I).Split("=")(0).Trim) & " and a.FechaInicia >= " & dbFec(DateAdd(DateInterval.Day, Val(strlista(I).Split("=")(1).Trim) * -1, Date.Today())) & " then 1 "
                        End If
                    End If
                Next
                strFiltroDias &= " end > 0 "
            End If

            If chkDocSiniestro.Checked = True Then
                'Me.cboFlujo.Query = "select a.IdFlujoDoc as Flujo, a.Comentario, a.FechaInicia as Fecha, a.IdPoliza as [Póliza], a.NombreCliente as Cliente, s.IdSiniestro as [Num. Siniestro], s.NombrePresentaReclamo as Dependiente, s.TotalPresentado as [Monto Reclamado], s.IdEnvio as [Número Envío], c.FechaEnvio as [Fecha Envío] from FlujosDocumentos as a left join Siniestros as s on s.IdPoliza = a.IdPoliza and s.IdProducto = a.IdProducto and s.IdSiniestro = a.IdSiniestro left join EnviosSiniestros as c on c.IdEnvio = s.IdEnvio where a.IdSiniestro is not null and (a.estadoflujo = 'PENDIENTE' " & strCliente & ") " & FiltroDefault & strFiltroDias
                Me.cboFlujo.Query = "select a.IdFlujoDoc as IdFlujo ,f.Descripcion as Flujo, a.Comentario, a.FechaInicia as Fecha, a.IdPoliza as [Póliza], a.NombreCliente as Cliente, s.IdSiniestro as [Num. Siniestro], s.NombrePresentaReclamo as Dependiente, s.TotalPresentado as [Monto Reclamado], s.IdEnvio as [Número Envío], c.FechaEnvio as [Fecha Envío], s.NoFolioReferencia as [NO.OFICIO/CARTA REF.] from FlujosDocumentos as a inner join FlujosTrabajo as f on a.IdFlujo = f.IdFlujo left join Siniestros as s on s.IdPoliza = a.IdPoliza and s.IdProducto = a.IdProducto and s.IdSiniestro = a.IdSiniestro left join EnviosSiniestros as c on c.IdEnvio = s.IdEnvio where a.IdSiniestro is not null and (a.estadoflujo = 'PENDIENTE' " & strCliente & ") " & FiltroDefault & strFiltroDias
            Else
                Me.cboFlujo.Query = "select a.IdFlujoDoc as Flujo, a.Comentario, a.FechaInicia as Fecha, a.IdPoliza as [Póliza], a.NombreCliente as Cliente from FlujosDocumentos as a where (a.estadoflujo = 'PENDIENTE' " & strCliente & ") " & FiltroDefault & strFiltroDias
            End If

            Me.cboFlujo.Llenar_Combo()
            If CodDestinatario = "" Then
                If cboTipoDocumento.Valor = "MA" Or cboTipoDocumento.Valor = "VA" Then Exit Sub
                If cboFlujo.ItemCount = 1 Then cboFlujo.SelectIndex = 0
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ObtenerDocumentos(ByVal IdCliente As String)
        Dim sql As String = ""
        If cboTipoDocumento.Valor = "" Then Exit Sub
        Me.VistaDoc.OptionsView.RowAutoHeight = False
        Me.VistaDoc.RowHeight = -1
        Try
            GridDoc.DataSource = Nothing
            GridDoc.Refresh()
            Me.VistaDoc.Columns.Clear()
            Me.VistaDoc.OptionsView.ShowAutoFilterRow = True
            Me.VistaDoc.RowHeight = -1

            Dim NumPalabras As Integer = CuentaCar(txtNombreCliente.Text.Trim, " "), Palabra As String = ""
            Select Case cboTipoDocumento.Valor
                Case "AC" 'Avisos de Cobro
                    sql = "  select AC.IdAvisoCobro as NumeroAC, AC.NombreCliente as Cliente, AC.Referencia"
                    sql &= " ,AC.IdPoliza as Póliza, p.Descripcion as Producto, AC.VigenciaDesde as Vigencia"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir, cast(0 as bit) as SoloPend"
                    sql &= " from AvisosCobro as AC"
                    sql &= " inner join Productos as p on p.idproducto = ac.idproducto"
                    sql &= " where AC.IdAvisoCobro is not null"
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and ac.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and AC.idcliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as pol where pol.idpoliza = AC.idpoliza and pol.idproducto = AC.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                    End If

                    sql &= " order by AC.VigenciaDesde desc"

                Case "EC" 'estados de cuenta
                    sql = "  select f.NumeroFactura as NumeroFactura"
                    sql &= " , p.Descripcion as Producto"
                    sql &= " , r.NombreRamo as Ramo"
                    sql &= " , p.TipoProducto as TipoSeguro"
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " , a.Siglas as Aseguradora"
                    Else
                        sql &= " , a.Nombre as Aseguradora"
                    End If
                    sql &= " , f.IdPoliza as Poliza"
                    sql &= " , f.TipoFactura as TipoFactura"
                    sql &= " , f.NombreCliente as NombreCliente"
                    sql &= " , f.FechaPago as FechaPago"
                    sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
                    sql &= " , DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as Dias"
                    sql &= " , (select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as PrimaNeta"
                    sql &= " , (select sum(Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Gastos"
                    sql &= " , (select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Impuestos"
                    sql &= " , (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Total"
                    sql &= " , f.IdProducto, f.IdRamo"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(1 as bit) as Incluir"
                    sql &= " from facturas as f "
                    sql &= " left join Productos as p on f.idproducto = p.idproducto"
                    sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
                    sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
                    sql &= " where "
                    'que la fecha de pago sea menor a la fecha de corte
                    sql &= " f.FechaPago <= " & dbFec(Date.Today.AddDays(30))
                    'que tengan saldo positivo
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and f.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and f.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                    End If

                    sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
                    sql &= " order by f.IdPoliza, f.NumeroFactura, f.FechaPago"


                Case "CC", "CV", "CQ" 'Carta de Cobro
                    sql = "  select f.NumeroFactura as NumeroFactura"
                    sql &= " , p.Descripcion as Producto"
                    sql &= " , r.NombreRamo as Ramo"
                    sql &= " , p.TipoProducto as TipoSeguro"
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " , a.Siglas as Aseguradora"
                    Else
                        sql &= " , a.Nombre as Aseguradora"
                    End If
                    sql &= " , f.IdPoliza as Poliza"
                    sql &= " , f.TipoFactura as TipoFactura"
                    sql &= " , f.NombreCliente as NombreCliente"
                    sql &= " , f.FechaPago as FechaPago"
                    sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
                    sql &= " , DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as Dias"
                    sql &= " , (select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as PrimaNeta"
                    sql &= " , (select sum(Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Gastos"
                    sql &= " , (select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Impuestos"
                    sql &= " , (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Total"
                    sql &= " , f.IdProducto, f.IdRamo"
                    If cboTipoDocumento.Valor = "CQ" Then
                        sql &= ", '' as [No.Quedan]"
                    End If
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from facturas as f "
                    sql &= " left join Productos as p on f.idproducto = p.idproducto"
                    sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
                    sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
                    sql &= " where f.NumeroFactura is not null"

                    'que tengan saldo positivo
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and f.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If

                    Else
                        sql &= " and f.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                    End If

                    sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
                    sql &= " order by f.IdPoliza, f.NumeroFactura, f.FechaPago"


                Case "CP" 'Carta de Pago
                    sql = "  select f.NumeroFactura as NumeroFactura"
                    sql &= " , p.Descripcion as Producto"
                    sql &= " , r.NombreRamo as Ramo"
                    sql &= " , p.TipoProducto as TipoSeguro"
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " , a.Siglas as Aseguradora"
                    Else
                        sql &= " , a.Nombre as Aseguradora"
                    End If
                    sql &= " , f.IdPoliza as Poliza"
                    sql &= " , f.TipoFactura as TipoFactura"
                    sql &= " , f.NombreCliente as NombreCliente"
                    sql &= " , f.FechaPago as FechaPago"
                    sql &= " , cast(f.NumCuota as varchar) + '/' + cast(f.TotalCuotas as varchar) as Cuota"
                    sql &= " , DateDiff(d,f.FechaPago," & dbFec(Date.Today) & ") as Dias"
                    sql &= " , (select sum(PrimaNeta) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as PrimaNeta"
                    sql &= " , (select sum(Gastos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Gastos"
                    sql &= " , (select sum(Impuestos) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Impuestos"
                    sql &= " , (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") as Total"
                    sql &= " , f.IdProducto, f.IdRamo"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from facturas as f "
                    sql &= " left join Productos as p on f.idproducto = p.idproducto"
                    sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
                    sql &= " left join Aseguradoras as a on a.IdAseguradora = p.IdAseguradora"
                    sql &= " where f.NumeroFactura is not null"

                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and f.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and f.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and (select count(*) from polizas as pol where pol.idpoliza = f.idpoliza and pol.idproducto = f.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                    End If

                    'que tengan saldo positivo
                    sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and FechaMovimiento <= " & dbFec(Date.Today) & ") = 0 "
                    sql &= " and (select count(*) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.TipoMovimiento = 'PAGO' ) > 0 "
                    sql &= " order by f.IdPoliza, f.NumeroFactura, f.FechaPago"

                Case "SP", "RE", "CT", "AT", "DM", "CSR", "MPO", "RES", "EOA", "EOG"
                    'LISTAREMOS LAS POLIZAS VIGENTES
                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Poliza"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,p.VigenciaDesde"
                    sql &= " ,p.VigenciaHasta"
                    sql &= " ,p.IdProducto"
                    If cboTipoDocumento.Valor = "AT" Then
                        sql &= " ,'' as Banco"
                    End If
                    If cboTipoDocumento.Valor = "DM" Then
                        sql &= " ,'' as [Declaración]"
                    End If
                    If cboTipoDocumento.Valor = "MPO" Then
                        sql &= " ,'' as [Descripción]"
                    End If
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"


                    sql &= " from Polizas as p"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" And (Me.txtInicio.Text = "" Or Me.txtFin.Text = "") Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If

                    If (cboTipoDocumento.Valor = "RE" Or cboTipoDocumento.Valor = "SP") And txtInicio.Text <> "" And txtFin.Text <> "" Then
                        'renovaciones entre fechas
                        sql &= " and p.VigenciaHasta between " & dbFec(txtInicio.Valor) & " and " & dbFec(txtFin.Valor)
                    End If



                    'polizas vigentes
                    sql &= " and p.MotivoCancelacion is null and p.FechaCancelacion is null"
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    sql &= " order by p.idpoliza"

                Case "RP"
                    'LISTAREMOS TODAS LAS POLIZAS VIGENTES/CANCELADAS
                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Poliza"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,p.VigenciaDesde"
                    sql &= " ,p.VigenciaHasta"
                    sql &= " ,p.IdProducto"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from Polizas as p"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If
                    
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    sql &= " order by p.idpoliza"

                Case "EO", "DO", "DE", "EE"
                    'LISTAREMOS LAS OFERTAS DEL CLIENTE
                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Oferta"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,p.VigenciaDesde"
                    sql &= " ,p.VigenciaHasta"
                    sql &= " ,p.IdProducto"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from cPolizas as p"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    'polizas vigentes
                    sql &= " and p.EstadoPoliza = 'ACEPTADA'"
                    sql &= " order by p.idpoliza"

                Case "CE", "IV"
                    'listamos los certificados
                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Poliza"
                    sql &= " ,c.idcertificado as Certificado"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,c.VigenciaDesde"
                    sql &= " ,c.VigenciaHasta"
                    sql &= " ,p.IdProducto"
                    If cboTipoDocumento.Valor = "IV" Then
                        ''agregamos placa marca y modelo
                        sql &= " ,isnull((select top 1 DescripcionBien from PolizasBienes as bi where bi.IdPoliza = c.IdPoliza and bi.IdProducto = c.IdProducto and bi.IdCertificado = c.IdCertificado and NombreBien =  'PLACA'),'') as Placa"
                        sql &= " ,isnull((select top 1 DescripcionBien from PolizasBienes as bi where bi.IdPoliza = c.IdPoliza and bi.IdProducto = c.IdProducto and bi.IdCertificado = c.IdCertificado and NombreBien =  'MARCA'),'') as Marca"
                        sql &= " ,isnull((select top 1 DescripcionBien from PolizasBienes as bi where bi.IdPoliza = c.IdPoliza and bi.IdProducto = c.IdProducto and bi.IdCertificado = c.IdCertificado and NombreBien =  'MODELO'),'') as Modelo"
                    End If
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from Polizas as p"
                    sql &= " inner join PolizasCertificados as c on p.idproducto = c.idproducto and p.idpoliza = c.idpoliza"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If
                    If cboTipoDocumento.Valor = "IV" Then
                        ''solo polizas de autos
                        sql &= " and r.IdRamo = '501'"
                    End If


                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    'polizas vigentes
                    sql &= " and p.MotivoCancelacion is null and p.FechaCancelacion is null"

                    sql &= " order by p.idpoliza, c.idcertificado"


                Case "DR", "CSF", "CPF"
                    'listamos los reclamos pendientes del cliente

                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Poliza"
                    sql &= " ,s.IdCertificado as Certificado"
                    sql &= " ,s.IdSiniestro as Siniestro"
                    sql &= " ,s.IdSiniestroAseguradora as SiniestroAseguradora"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,s.FechaOcurrido"
                    sql &= " ,s.FechaPresentado"
                    sql &= " ,s.EstadoSiniestro"
                    sql &= " ,p.IdProducto"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from Siniestros as s"
                    sql &= " inner join Polizas as p on s.idpoliza = p.idpoliza and s.idproducto = p.idproducto"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    'siniestros pendientes
                    If cboTipoDocumento.Valor <> "CPF" Then
                        sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE', 'RECONSIDERACION')"
                    End If

                    sql &= " order by p.idpoliza, s.FechaPresentado desc "

                Case "CA"
                    'Carta de ajuste de reclamos

                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Poliza"
                    sql &= " ,s.IdCertificado as Certificado"
                    sql &= " ,s.IdSiniestro as Siniestro"
                    sql &= " ,s.IdSiniestroAseguradora as SiniestroAseguradora"
                    sql &= " ,p.NombreCliente as Cliente"
                    sql &= " ,s.FechaOcurrido"
                    sql &= " ,s.FechaPresentado"
                    sql &= " ,s.EstadoSiniestro"
                    sql &= " ,p.IdProducto"

                    sql &= " ,'' as Ajustador"
                    sql &= " , 0.00 as MontoAjustado"
                    sql &= " ,'' as Notas"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from Siniestros as s"
                    sql &= " inner join Polizas as p on s.idpoliza = p.idpoliza and s.idproducto = p.idproducto"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    'siniestros pendientes
                    sql &= " and s.EstadoSiniestro in ('DECLARADO','PENDIENTE', 'RECONSIDERACION')"
                    sql &= " order by p.idpoliza, s.FechaPresentado desc "

                Case "CR", "CD"
                    'SE LISTARÁN LOS CHEQUES DE RECLAMOS DEL CLIENTE ORDENADOS POR FECHA DEL CHEQUE
                    sql = "  SELECT "
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " a.Siglas as Aseguradora"
                    Else
                        sql &= " a.Nombre as Aseguradora"
                    End If
                    sql &= " ,r.Descripcion as Producto"
                    sql &= " ,p.idpoliza as Poliza"
                    sql &= " ,s.IdCertificado as Certificado"
                    sql &= " ,s.IdSiniestro as Siniestro"
                    sql &= " ,s.IdSiniestroAseguradora as SiniestroAseguradora"
                    sql &= " ,s.NombrePresentaReclamo as Beneficiario"
                    sql &= " ,sp.NumeroCheque as Cheque"
                    sql &= " ,sp.FechaPago"
                    sql &= " ,sp.ValorReembolso as ValorCheque"
                    sql &= " ,p.IdProducto"
                    sql &= " ,sp.IdPago"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from Siniestros as s"
                    sql &= " inner join SiniestrosPagos as sp on sp.IdPoliza = s.IdPoliza and sp.IdProducto = s.IdProducto and sp.IdCertificado = s.IdCertificado and sp.IdSiniestro = s.IdSiniestro"
                    sql &= " inner join Polizas as p on s.idpoliza = p.idpoliza and s.idproducto = p.idproducto"
                    sql &= " inner join productos as r on p.idproducto = r.idproducto"
                    sql &= " inner join aseguradoras as a on r.idaseguradora = a.idaseguradora"
                    sql &= " where p.idpoliza is not null"
                    If cboTipoDocumento.Valor = "CD" Then sql &= " and r.TipoProducto = 'DAÑOS'"
                    If cboTipoDocumento.Valor = "CR" Then sql &= " and r.TipoProducto = 'VIDA'"

                    'pólizas del cliente
                    If IdCliente.Trim = "" Then
                        If txtNombreCliente.Text.Trim = "" Then
                            sql &= " and 1=2 "
                        Else
                            For NP As Integer = 0 To NumPalabras
                                Palabra = stiSplit(txtNombreCliente.Text.Trim, "G" & NP & " 1").Trim
                                If Palabra <> "" Then
                                    sql &= " and p.NombreCliente like " & dbStr("%" & Palabra & "%")
                                End If
                            Next
                        End If
                    Else
                        sql &= " and p.IdCliente = " & dbStr(IdCliente)
                    End If
                    If VisibilidadUsuario() = "D" Then
                        sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
                    End If
                    'polizas vigentes
                    sql &= " order by p.idpoliza, sp.FechaPago desc "

                Case "EP"
                    ''Énvios de pago de caja / para Aseguradoras
                    sql = "  select "
                    sql &= " e.IdEnvio as NumEnvio"
                    If srtParAsegNombreCorto = "S" Then
                        sql &= " , a.Siglas as Aseguradora"
                    Else
                        sql &= " , a.Nombre as Aseguradora"
                    End If
                    sql &= " ,e.FechaCorte as FechaCorte"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(0 as bit) as Incluir"
                    sql &= " from EnviosPago as e"
                    sql &= " inner join Aseguradoras as a on a.idaseguradora = e.idaseguradora"
                    sql &= " where e.FechaCorte = " & dbFec(txtFechaEnDocumento.Valor)
                    sql &= " and e.FechaAnulacion is null"


                    'si en la fecha especificada hay documentos pendientes agregaremos una fila para generarlos
                    Dim NumRecibos As Integer = 0
                    Try
                        NumRecibos = StiGlobalConn.ObtenerDataset("select count(*) from Recibos where EnviadoAseguradoras = 'P' and FechaRecibo <= " & dbFec(txtFechaEnDocumento.Valor)).Tables(0).Rows(0).Item(0)
                    Catch ex As Exception
                        NumRecibos = 0
                    End Try

                    If NumRecibos > 0 Then
                        sql &= " union "
                        sql &= " Select "
                        sql &= " '' as NumEnvio"
                        sql &= " ,'' as Aseguradora"
                        sql &= " , " & dbFec(txtFechaEnDocumento.Valor) & " as FechaCorte"
                        sql &= " , cast(0 as bit) as Incluir"
                    End If


                Case "MA", "VA", "ER"
                    'ER: Documento de adrisa para envio de regalo
                    'MA: Correo
                    'VA: Docuemtnos varios
                    sql = " select '' as [Descripción]"
                    sql &= " ,'' as Direccion"
                    sql &= " , cast(1 as bit) as Incluir"

                    Me.VistaDoc.OptionsView.ShowAutoFilterRow = False
                    Me.VistaDoc.OptionsView.RowAutoHeight = True
                    Me.VistaDoc.RowHeight = 100

                Case "SR"
                    'SR: Retiro de correspondencia
                    sql = " select '' as [Descripción]"
                    sql &= " ,'' as [Dirección de Retiro]"
                    sql &= " ,getdate() as [Fecha Para Entrega]"
                    sql &= " ,'' as [Zona/Ruta]"
                    sql &= " , cast(1 as bit) as Incluir"

                    Me.VistaDoc.OptionsView.ShowAutoFilterRow = False
                    Me.VistaDoc.OptionsView.RowAutoHeight = True
                    Me.VistaDoc.RowHeight = 100

                Case "NG"
                    'Un documento especial de notas de gestion solicitadas por consltores
                    sql = " select "
                    sql &= " '' as [Póliza]"
                    sql &= ", '' as [Referencia]"
                    sql &= ", '' as [Descripción]"
                    sql &= ", '' as [Tipo]"
                    sql &= ", '' as [Forma]"
                    sql &= " , cast(1 as bit) as Incluir"

                    Me.VistaDoc.OptionsView.ShowAutoFilterRow = False
                    Me.VistaDoc.RowHeight = 100

            End Select


            Dim dtDoc As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            GridDoc.DataSource = dtDoc
            GridDoc.Refresh()

            If IdCliente.Trim <> "" And dtDoc.Rows.Count = 0 Then
                MsgBox("No se encontraron documentos para el cliente especificado.", MsgBoxStyle.Information, "AVISO...")
            End If

            Try
                VistaDoc.Columns("Incluir").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                VistaDoc.FocusedColumn = VistaDoc.Columns("Incluir")
            Catch ex As Exception

            End Try
            Try
                VistaDoc.Columns("IdProducto").Visible = False
            Catch ex As Exception

            End Try
            Try
                VistaDoc.Columns("IdRamo").Visible = False
            Catch ex As Exception

            End Try
            Try
                VistaDoc.Columns("IdPago").Visible = False
            Catch ex As Exception

            End Try

            For NC As Integer = 0 To Me.VistaDoc.Columns.Count - 1
                Select Case VistaDoc.Columns(NC).FieldName
                    Case "Incluir"
                        VistaDoc.Columns(NC).Width = 35
                    Case "Descripción", "Ajustador", "Notas", "Póliza", "Referencia", "Tipo", "Forma", "Direccion"
                        Dim EditorM As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
                        EditorM.MaxLength = 250
                        VistaDoc.Columns(NC).ColumnEdit = EditorM

                    Case "Declaración"
                        Dim EditorM As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
                        VistaDoc.Columns(NC).ColumnEdit = EditorM

                    Case "SoloPend", "No.Quedan", "MontoAjustado"

                    Case "Banco"
                        VistaDoc.Columns(NC).Caption = "Banco / Tarjeta"

                    Case "Fecha Para Entrega"
                        Dim EditorF As New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
                        VistaDoc.Columns(NC).ColumnEdit = EditorF

                    Case "Dirección de Retiro"
                        Dim EditorC As New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
                        EditorC.View.OptionsView.RowAutoHeight = True
                        VistaDoc.Columns(NC).ColumnEdit = EditorC

                        Try
                            ''ahora llemanos las direcciones del cliente 
                            Dim sqld As String = "select 1 as orden, 'Dir.Cliente #' + cast(row_number() over(order by UsoCorrespondencia) as varchar) as Id,  Direccion from ClientesContactos where idcliente = " & dbStr(txtIdCliente.Valor) & " union select 2 as orden,  siglas, Direccion from Aseguradoras where IdAseguradora in (select r.idaseguradora from polizas as p inner join productos as r on r.idproducto = p.idproducto and p.MotivoCancelacion is null and p.FechaCancelacion is null and p.idcliente = " & dbStr(txtIdCliente.Valor) & " ) order by 1"
                            Dim dtDir As DataTable = StiGlobalConn.ObtenerDataset(sqld).Tables(0)
                            EditorC.ValueMember = "Direccion"
                            EditorC.DisplayMember = "Direccion"
                            EditorC.DataSource = dtDir

                            EditorC.View.Columns(0).Visible = False
                            Dim EditorM1 As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
                            EditorC.View.Columns(2).ColumnEdit = EditorM1


                        Catch ex As Exception

                        End Try
                    Case "Zona/Ruta"
                        Dim EditorC2 As New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
                        VistaDoc.Columns(NC).ColumnEdit = EditorC2
                        Try
                            ''ahora llemanos las direcciones del cliente 
                            Dim sqld As String = "select IdZona as Id, DescripcionZona as Zona from Zonas"
                            Dim dtDir As DataTable = StiGlobalConn.ObtenerDataset(sqld).Tables(0)
                            EditorC2.ValueMember = "Id"
                            EditorC2.DisplayMember = "Zona"
                            EditorC2.DataSource = dtDir


                        Catch ex As Exception

                        End Try


                    Case Else
                        VistaDoc.Columns(NC).OptionsColumn.AllowEdit = False
                End Select

            Next

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub VistaDoc_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles VistaDoc.CellValueChanged
        Try
            Select Case e.Column.FieldName
                Case "Fecha Para Entrega"
                    Dim Fecha As Date = e.Value
                    If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                        MsgBox("No es posible seleccionar fechas de entrega en fines de semana.", MsgBoxStyle.Information, "AVISO...")
                        VistaDoc.SetRowCellValue(e.RowHandle, e.Column.FieldName, Date.Today)
                    End If

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaDoc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles VistaDoc.Click
        Try
            If VistaDoc.FocusedColumn.FieldName = "Incluir" Then  'la columna incluir
                Me.Cursor = Cursors.WaitCursor
                Dim Valor1 As Boolean = VistaDoc.GetRowCellValue(0, "Incluir")
                Valor1 = Not Valor1
                For NF As Integer = 0 To Me.VistaDoc.RowCount - 1
                    If NF Mod 25 = 0 Then Application.DoEvents()
                    VistaDoc.SetRowCellValue(NF, "Incluir", Valor1)
                Next
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Me.cboTipoDocumento.Text = "" Then
                MsgBox("Debe especificar el documento que desea imprimir,", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
            If Me.txtIdCliente.Text = "" And cboTipoDocumento.Text <> "EP" Then
                'MsgBox("Debe especificar el cliente.", MsgBoxStyle.Information, "AVISO...")
                'Exit Sub
            End If
            If Me.cboFlujo.Text = "" Or Me.cboFlujo.Text = Me.cboFlujo.TextoNuevoItem Then
                MsgBox("Debe especificar el flujo del documento.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim IdFlujoDoc As String = "", IdCliente As String = "", Claves As String = "", IdImpresion As String = "", LstIdImpresion As String = ""
            IdFlujoDoc = cboFlujo.Valor
            IdCliente = Me.txtIdCliente.Valor

            Dim Destinatario As String = "", CodDestinatario As String = ""
            Try
                CodDestinatario = CStr(dtDatos.Select("id = " & dbStr(cboTipoDocumento.Valor))(0)("Destinatario")).Trim.ToUpper
            Catch ex As Exception
                CodDestinatario = ""
            End Try

            Dim DireccionEnDocumento As String = ""

            Select Case cboTipoDocumento.Valor
                case "EOA" 'carta emision original auto sol. por BeSafe
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaRemitePolizaAuto(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text, txtNotasDocumento.Text)
                        End If
                    Next

                case "EOG"
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaRemitePolizaGM(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text, txtNotasDocumento.Text)
                        End If
                    Next

                Case "AC" 'Avisos de Cobro

                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Call ImprimirAvisoCobro(VistaDoc.GetRowCellValue(NF, "NumeroAC"), VistaDoc.GetRowCellValue(NF, "SoloPend"), txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                            'iniciamos un flujo de AC
                            'clFlujos.IniciarFlujoAC(VistaDoc.GetRowCellValue(NF, "NumeroAC"))
                            Claves &= VistaDoc.GetRowCellValue(NF, "NumeroAC") & ","
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next

                    If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                    Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                    If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        
                Case "EC" 'estados de cuenta

                    Dim lstFacturas As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            'If lstFacturas = "" Then
                            '    lstFacturas &= VistaDoc.GetRowCellValue(NF, "NumeroFactura")
                            'Else
                            '    lstFacturas &= ", " & VistaDoc.GetRowCellValue(NF, "NumeroFactura")
                            'End If
                            If lstFacturas = "" Then
                                lstFacturas &= " and ( (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            Else
                                lstFacturas &= " or (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            End If
                            Claves &= VistaDoc.GetRowCellValue(NF, "NumeroFactura") & ","
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                    If lstFacturas = "" Then
                        MsgBox("Debe especificar las facturas que desea incluir en el documento.", MsgBoxStyle.Information, "AVISO...")
                    Else
                        lstFacturas &= ") "

                        Dim strError As String = ""


                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text

                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirEstadoCuenta(txtIdCliente.Valor, "", "", lstFacturas, "", Nothing, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text, strError)

                        If strError <> "" Then
                            MsgBox("Error al generar el estado de cuenta: " & vbCrLf & strError, MsgBoxStyle.Information, "AVISO...")
                        Else
                            'Call clFlujos.IniciarFlujoEstadoCuenta(txtIdCliente.Valor)
                        End If
                    End If

                Case "CC" 'Carta de Cobro anticipado

                    Dim lstFacturas As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            If lstFacturas = "" Then
                                lstFacturas &= " and ( (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            Else
                                lstFacturas &= " or (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            End If

                            'Call clFlujos.IniciarFlujoCobros(VistaDoc.GetRowCellValue(NF, "NumeroFactura"), VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), VistaDoc.GetRowCellValue(NF, "IdRamo"))
                            Claves &= VistaDoc.GetRowCellValue(NF, "NumeroFactura") & ","
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next

                    If lstFacturas = "" Then
                        MsgBox("Debe especificar las facturas que desea incluir en el documento.", MsgBoxStyle.Information, "AVISO...")
                    Else
                        lstFacturas &= ") "

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, EsDocumentoDeCobro:=True, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirEmision(txtIdCliente.Valor, "", lstFacturas, IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        Claves = ""
                    End If

                Case "CV" 'Carta de Cobro

                    Dim lstFacturas As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            If lstFacturas = "" Then
                                lstFacturas &= " and ( (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            Else
                                lstFacturas &= " or (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            End If
                            Claves &= VistaDoc.GetRowCellValue(NF, "NumeroFactura") & ","
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next

                    If lstFacturas = "" Then
                        MsgBox("Debe especificar las facturas que desea incluir en el documento.", MsgBoxStyle.Information, "AVISO...")
                    Else
                        lstFacturas &= ") "

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, EsDocumentoDeCobro:=True, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirCartaCobro(txtIdCliente.Valor, "", lstFacturas, IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        Claves = ""
                    End If

                Case "CP" 'Carta de Pago

                    Dim lstFacturas As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            If lstFacturas = "" Then
                                lstFacturas &= " and ( (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            Else
                                lstFacturas &= " or (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")"
                            End If
                            'Call clFlujos.IniciarFlujoPagos(VistaDoc.GetRowCellValue(NF, "NumeroFactura"), VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), VistaDoc.GetRowCellValue(NF, "IdRamo"))
                            Claves &= VistaDoc.GetRowCellValue(NF, "NumeroFactura") & ","
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                    If lstFacturas = "" Then
                        MsgBox("Debe especificar las facturas que desea incluir en el documento.", MsgBoxStyle.Information, "AVISO...")
                    Else
                        lstFacturas &= ") "

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, EsDocumentoDeCobro:=True, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)

                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirPago(txtIdCliente.Valor, "", lstFacturas, IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                    End If

                Case "CQ" 'Carta de Quedan / Para Aseguradora

                    Dim lstFacturas As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            lstFacturas = " and ( (f.NumeroFactura = " & dbInt(VistaDoc.GetRowCellValue(NF, "NumeroFactura")) & " and f.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and f.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and f.idramo = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdRamo")) & ")) "
                            Claves = VistaDoc.GetRowCellValue(NF, "NumeroFactura") & ","
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, EsDocumentoDeCobro:=True, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirQuedanFactura(txtIdCliente.Valor, lstFacturas, VistaDoc.GetRowCellValue(NF, "No.Quedan"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "SP" 'solicitud de prorroga al cliente
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirSolicitudProrrogaCliente(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "CSR"
                    'Carta solicitud de prorroga al cliente
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaSolicitudProrrogaCliente(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "MPO"
                    'Carta de Anexo de Modificación
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaAnexoPolizaCliente(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, VistaDoc.GetRowCellValue(NF, "Descripción"), txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "CT" 'Cancelación cargo a tarjeta. / para Aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, EsDocumentoDeCobro:=True, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaCancelacionTarjeta(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "AT" 'Autorización carga a tarjeta. / para aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, EsDocumentoDeCobro:=True, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaAutorizacionTarjeta(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, VistaDoc.GetRowCellValue(NF, "Banco"), txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "RE"
                    'Carta de renovación de póliza
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirRenovacionCliente(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "EO"
                    'Carta de emisiones iniciales / para Aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Oferta")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirEmisionPolizaCliente(VistaDoc.GetRowCellValue(NF, "Oferta"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "DM"
                    'Carta declaraciones mensuales / para Aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "

                            Call ImprimirPolizaDeclaracionMensual(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, VistaDoc.GetRowCellValue(NF, "Declaración"), txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "RP"
                    'Carta rehabilitación de póliza / para Aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Poliza")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "

                            Call ImprimirRehabilitacionPoliza(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "EE"
                    'Carta de emisiones iniciales / para Aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Oferta")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirEmisionPolizaEmpresa(VistaDoc.GetRowCellValue(NF, "Oferta"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "CE"
                    'certificados
                    Dim FiltroPol As String = "", FiltroCert As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves &= VistaDoc.GetRowCellValue(NF, "Poliza") & "*" & VistaDoc.GetRowCellValue(NF, "Certificado") & ","
                            If FiltroPol = "" Then
                                FiltroPol &= " (p.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and p.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & ")"
                                FiltroCert &= " (c.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and c.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and c.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & ")"
                            Else
                                FiltroPol &= " or (p.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and p.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & ")"
                                FiltroCert &= " or (c.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and c.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and c.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & ")"
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try

                        End If
                    Next
                    If FiltroPol <> "" Then

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirEnvioCertificadosCliente(" and (" & FiltroPol & ")", " and (" & FiltroCert & ")", IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                    End If

                Case "RES"
                    'Resumen de Pólizas
                    Dim FiltroPol As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves &= VistaDoc.GetRowCellValue(NF, "Poliza") & "*" & VistaDoc.GetRowCellValue(NF, "IdProducto") & ","
                            If FiltroPol = "" Then
                                FiltroPol &= " (p.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and p.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & ")"
                            Else
                                FiltroPol &= " or (p.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and p.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & ")"
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                    If FiltroPol <> "" Then
                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirResumenPolizasCliente(" and (" & FiltroPol & ")", IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                    End If

                Case "IV"
                    'solicitud de inclusion de vehiculos / para aseguradora
                    Dim FiltroPol As String = "", FiltroCert As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves &= VistaDoc.GetRowCellValue(NF, "Poliza") & "*" & VistaDoc.GetRowCellValue(NF, "Certificado") & ","
                            If FiltroPol = "" Then
                                FiltroPol &= " (p.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and p.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & ")"
                                FiltroCert &= " (c.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and c.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and c.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & ")"
                            Else
                                FiltroPol &= " or (p.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and p.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & ")"
                                FiltroCert &= " or (c.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and c.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and c.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & ")"
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                    If FiltroPol <> "" Then

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirInclusionVehiculo(" and (" & FiltroPol & ")", " and (" & FiltroCert & ")", IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                    End If


                Case "DR"
                    'documentos de reclamo.
                    'Carta de emisiones iniciales
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Siniestro")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirSolicitudDocumentoReclamoCliente(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), VistaDoc.GetRowCellValue(NF, "Siniestro"), VistaDoc.GetRowCellValue(NF, "Certificado"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "CSF"
                    ''carta de solicitud de gastos funerarios / aseguradora
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Siniestro")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "

                            Call ImprimirSolicitudAseguradoraGastosFunerario(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), VistaDoc.GetRowCellValue(NF, "Siniestro"), VistaDoc.GetRowCellValue(NF, "Certificado"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "CPF"
                    ''carta de pago de gastos funerarios 
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Siniestro")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "

                            Call ImprimirPagoGastosFunerarioCliente(VistaDoc.GetRowCellValue(NF, "Poliza"), VistaDoc.GetRowCellValue(NF, "IdProducto"), VistaDoc.GetRowCellValue(NF, "Siniestro"), VistaDoc.GetRowCellValue(NF, "Certificado"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "CR"
                    'cheques de reclamos

                    Dim FiltroSin As String = "", FiltroPago As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves &= VistaDoc.GetRowCellValue(NF, "Poliza") & "*" & VistaDoc.GetRowCellValue(NF, "Cheque") & ","
                            If FiltroSin = "" Then
                                FiltroSin &= " (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & ")"
                                FiltroPago &= " (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & " and s.idPago = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdPago")) & ")"
                            Else
                                FiltroSin &= " or (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & ")"
                                FiltroPago &= " or (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & " and s.idPago = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdPago")) & ")"
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                    If FiltroSin <> "" Then

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirCartaReclamosChequesCliente(" and (" & FiltroSin & ")", " and (" & FiltroPago & ")", IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text, Observaciones:=Me.txtNotasDocumento.Text)

                        Select Case GlobalCodCliente
                            Case "2120000"
                                Call MarcarFlujosChequeDoc(" and (" & FiltroSin & ")", IdImpresion)
                        End Select
                    End If

                Case "CD"
                    'cheques de reclamos daños

                    Dim FiltroSin As String = "", FiltroPago As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves &= VistaDoc.GetRowCellValue(NF, "Poliza") & "*" & VistaDoc.GetRowCellValue(NF, "Cheque") & ","
                            If FiltroSin = "" Then
                                FiltroSin &= " (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & ")"
                                FiltroPago &= " (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & " and s.idPago = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdPago")) & ")"
                            Else
                                FiltroSin &= " or (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & ")"
                                FiltroPago &= " or (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & " and s.idPago = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdPago")) & ")"
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                    If FiltroSin <> "" Then
                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirCartaReclamosChequesClienteDanos(" and (" & FiltroSin & ")", " and (" & FiltroPago & ")", IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        Select Case GlobalCodCliente
                            Case "2120000"
                                Call MarcarFlujosChequeDoc(" and (" & FiltroSin & ")", IdImpresion)
                        End Select
                    End If

                Case "CA"
                    'Carta de ajuste de reclamos

                    Dim FiltroSin As String = "", FiltroPago As String = ""
                    Dim Ajustador As String = "", MontoAjustado As Double = 0, Notas As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves &= VistaDoc.GetRowCellValue(NF, "Poliza") & "*" & VistaDoc.GetRowCellValue(NF, "Cheque") & ","
                            If FiltroSin = "" Then
                                FiltroSin &= " (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & ")"
                                FiltroPago &= " (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & " and s.idPago = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdPago")) & ")"
                            Else
                                FiltroSin &= " or (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & ")"
                                FiltroPago &= " or (s.idpoliza = " & dbStr(VistaDoc.GetRowCellValue(NF, "Poliza")) & " and s.idproducto = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdProducto")) & " and s.idcertificado = " & dbStr(VistaDoc.GetRowCellValue(NF, "Certificado")) & " and s.idSiniestro = " & dbStr(VistaDoc.GetRowCellValue(NF, "Siniestro")) & " and s.idPago = " & dbStr(VistaDoc.GetRowCellValue(NF, "IdPago")) & ")"
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            Try
                                Ajustador = VistaDoc.GetRowCellValue(NF, "Ajustador")
                                MontoAjustado = VistaDoc.GetRowCellValue(NF, "MontoAjustado")
                                Notas = VistaDoc.GetRowCellValue(NF, "Notas")
                            Catch ex As Exception

                            End Try

                        End If
                    Next
                    If FiltroSin <> "" Then

                        If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                        Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                        If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                        Call ImprimirCartaReclamosAjusteCliente(" and (" & FiltroSin & ")", " and (" & FiltroPago & ")", IdImpresion, Ajustador, MontoAjustado, Notas, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                    End If

                Case "DO"
                    'Carta de documentos para emisiones
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Oferta")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaDocumentosEmisionCliente(VistaDoc.GetRowCellValue(NF, "Oferta"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "DE"
                    'Carta de documentos para emisiones
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "Oferta")
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                            Call ImprimirCartaDocumentosEmisionEmpresa(VistaDoc.GetRowCellValue(NF, "Oferta"), VistaDoc.GetRowCellValue(NF, "IdProducto"), IdImpresion, txtNombreFirma.Text, txtCargoFirma.Text, txtNombreAtt.Text, txtCargoAtt.Text)
                        End If
                    Next

                Case "EP"
                    'envios de pago a las aseguradoras
                    Dim msgError As String = ""
                    For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                        If VistaDoc.GetRowCellValue(NF, "Incluir") = True Then
                            Claves = VistaDoc.GetRowCellValue(NF, "NumEnvio")
                            If Claves = "" Then
                                'generamos el envio
                                msgError = GenerarEnvioCaja(txtFechaEnDocumento.Valor, Claves)
                                If msgError.Trim <> "" Then
                                    MsgBox(msgError, MsgBoxStyle.Exclamation, "AVISO...")
                                    Exit Sub
                                End If
                            Else
                                Claves = dbStr(Claves)
                            End If
                            Try
                                DireccionEnDocumento = VistaDoc.GetRowCellValue(NF, "Direccion")
                            Catch ex As Exception

                            End Try
                            If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text

                            Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                            If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "

                            msgError = ImprimirEnvioCaja(Claves, IdImpresion, txtNombreFirma.Valor, txtCargoFirma.Valor, txtNombreAtt.Valor, txtCargoAtt.Valor)
                            If msgError.Trim <> "" Then
                                MsgBox(msgError, MsgBoxStyle.Exclamation, "AVISO...")
                                Exit Sub
                            End If

                        End If
                    Next


                Case "MA", "VA", "ER"
                    'documentos varios
                    'por defecto en estos documentos varios el nombre del cliente lo tomaremos como destinatario.
                    If Me.txtNombreCliente.Text.Trim <> "" Then Destinatario = txtNombreCliente.Text
                    If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text

                    Try
                        DireccionEnDocumento = VistaDoc.GetRowCellValue(0, "Direccion")
                    Catch ex As Exception

                    End Try

                    Call clFlujos.RegistrarDocumento(IdFlujoDoc, VistaDoc.GetRowCellValue(0, "Descripción"), IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor, NombreAlternoCliente:=txtNombreCliente.Valor)
                    If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "
                    MsgBox("Documento registrado con éxito.", MsgBoxStyle.Information, "AVISO...")
                    VistaDoc.SetRowCellValue(0, "Descripción", "")

                Case "SR"
                    'documentos varios
                    'por defecto en estos documentos varios el nombre del cliente lo tomaremos como destinatario.
                    If Me.txtNombreCliente.Text.Trim <> "" Then Destinatario = txtNombreCliente.Text
                    If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text

                    Try
                        DireccionEnDocumento = VistaDoc.GetRowCellValue(0, "Dirección de Retiro")
                    Catch ex As Exception

                    End Try

                    If VistaDoc.GetRowCellValue(0, "Descripción") = "" Then
                        MsgBox("La Descripción es obligatoria.", MsgBoxStyle.Information, "AVISO...")
                        Exit Sub
                    End If

                    If DireccionEnDocumento = "" Then
                        MsgBox("La dirección es obligatoria.", MsgBoxStyle.Information, "AVISO...")
                        Exit Sub
                    End If


                    Call clFlujos.RegistrarDocumento(IdFlujoDoc, VistaDoc.GetRowCellValue(0, "Descripción"), IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor, NombreAlternoCliente:=txtNombreCliente.Valor)
                    If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "


                    Try
                        'ahora ruteamos el documento
                        Dim Fecha As DateTime = Me.VistaDoc.GetRowCellValue(0, "Fecha Para Entrega")
                        Dim Zona As String = Me.VistaDoc.GetRowCellValue(0, "Zona/Ruta")
                        Dim strSQL As String = ""
                        Dim CorreoUsu As String = ""
                        Try
                            CorreoUsu = dbData(StiGlobalConn.ObtenerDataset("select Email from usuarios where IdUsuario = " & dbStr(StiGlobalConn.User)).Tables(0).Rows(0), "Email")
                        Catch ex As Exception
                            CorreoUsu = ""
                        End Try

                        StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set IdZona = " & dbStr(Zona, 25) & ", FechaEnvio = " & dbFec(Fecha) & ", FechaMovimiento = " & dbFec(Date.Now, "1") & " where IdFlujoDoc = " & dbStr(IdFlujoDoc) & " and IdImpresion = " & dbStr(IdImpresion))

                        'mandamos un correo
                        Dim Remitente As String = clSeguros.ObtenerDBParametros("Correo.Remite.Ret.Corr")
                        Dim PassRemitente As String = clSeguros.ObtenerDBParametros("Correo.Pass.Ret.Corr")
                        Dim DestinatarioCorr As String = clSeguros.ObtenerDBParametros("Correo.Destinatario.Ret.Corr")
                        Dim DestinatarioCopia As String = clSeguros.ObtenerDBParametros("Correo.Copia.Ret.Corr")
                        If CorreoUsu <> "" Then DestinatarioCopia &= "," & CorreoUsu
                        Dim strMensaje As String = ""

                        Dim ClienteAsunto As String = txtNombreCliente.Valor
                        If txtDestinatario.Valor.ToString <> "" Then ClienteAsunto = txtDestinatario.Valor

                        strMensaje = " CORRELATIVO: " & IdImpresion
                        strMensaje &= vbCrLf & vbCrLf & "FECHA DE SOLICITUD: " & Date.Today.ToShortDateString
                        strMensaje &= vbCrLf & vbCrLf & "CLIENTE: " & txtNombreCliente.Valor
                        strMensaje &= vbCrLf & vbCrLf & "DESTINATARIO: " & txtDestinatario.Valor
                        strMensaje &= vbCrLf & vbCrLf & "DESCRIPCIÓN: " & VistaDoc.GetRowCellValue(0, "Descripción")
                        strMensaje &= vbCrLf & vbCrLf & "DIRECCIÓN: " & DireccionEnDocumento
                        strMensaje &= vbCrLf & vbCrLf & "FECHA DE ENTREGA: " & Fecha.ToShortDateString
                        strMensaje &= vbCrLf & vbCrLf & "ZONA/RUTA: " & dbData(StiGlobalConn.ObtenerDataset("select DescripcionZona from zonas where IdZona = " & dbStr(Zona)).Tables(0).Rows(0), "DescripcionZona")
                        strMensaje &= vbCrLf & vbCrLf & "USUARIO SOLICITA: " & dbData(StiGlobalConn.ObtenerDataset("select NombreUsuario from usuarios where IdUsuario = " & dbStr(StiGlobalConn.User)).Tables(0).Rows(0), "NombreUsuario")

                        EnviarCorreoRetiroCorrespondencia(Remitente, PassRemitente, DestinatarioCorr, DestinatarioCopia, "", IdImpresion & " - " & ClienteAsunto, strMensaje, False)

                    Catch ex As Exception

                    End Try

                   

                    MsgBox("Documento registrado con éxito.", MsgBoxStyle.Information, "AVISO...")
                    VistaDoc.SetRowCellValue(0, "Descripción", "")

                Case "NG"
                    DireccionEnDocumento = ObtenerDireccionCliente(txtIdCliente.Valor)
                    If txtDestinatario.Text.Trim <> "" Then Destinatario = txtDestinatario.Text
                    Call clFlujos.RegistrarDocumento(IdFlujoDoc, cboTipoDocumento.Descripcion, IdCliente, Claves, "SALIDA", IdImpresion, "", txtFechaEnDocumento.Valor, Destinatario, NombreAtt:=txtNombreAtt.Text, DireccionDocumento:=DireccionEnDocumento, ObservacionDocumento:=txtNotasDocumento.Text, CodigoImpresionDocumento:=cboTipoDocumento.Valor)
                    If IdImpresion.Trim <> "" Then LstIdImpresion &= IdImpresion & ", "

                    Call ImprimirNotaGestion(VistaDoc.GetRowCellValue(0, "Descripción"), VistaDoc.GetRowCellValue(0, "Referencia"), VistaDoc.GetRowCellValue(0, "Póliza"), txtNombreCliente.Valor, VistaDoc.GetRowCellValue(0, "Tipo"), VistaDoc.GetRowCellValue(0, "Forma"), IdImpresion, txtNombreFirma.Valor, txtCargoFirma.Valor, txtNombreAtt.Valor, txtCargoAtt.Valor)

            End Select

            If LstIdImpresion <> "" And CStr(clSeguros.ObtenerDBParametros("Notificar.NumDocumento")).Trim.ToUpper = "S" Then
                MsgBox("Se ha generado el No. de Documento: " & LstIdImpresion, MsgBoxStyle.Information, "AVISO DE CORRESPONDENCIA...")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFlujo_NewItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFlujo.NewItem
        Try
            Dim frmNF As New NuevoFlujo
            frmNF.STIConn = StiGlobalConn
            frmNF.Permiso = Me.Permiso
            frmNF.IdClienteDefault = Me.txtIdCliente.Valor
            frmNF.ObservacionDefault = Me.cboTipoDocumento.Descripcion
            frmNF.ShowDialog()

            'actualizamos la lista de flujos
            Me.cboFlujo.Llenar_Combo()

            'PROPONEMOS EL PRIMER FLUJO
            cboFlujo.Valor = ""
            If IdNuevoFlujo <> "" Then
                cboFlujo.Valor = IdNuevoFlujo
            End If
            If cboFlujo.ItemCount = 1 And cboFlujo.Valor <> "" Then Me.cboFlujo.SelectIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNombreCliente_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtNombreCliente.ValueChangeOnExit
        Call ObtenerDocumentos(Me.txtIdCliente.Valor)
    End Sub

    Private Function ObtenerDireccionCliente(ByVal IdCliente As String) As String
        Dim res As String = ""
        Try
            res = StiGlobalConn.ObtenerDataset("select Direccion from ClientesContactos where idcliente = " & dbStr(IdCliente) & " order by UsoCorrespondencia desc").Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Private Function ObtenerDireccionAseguradora(ByVal Aseguradora As String) As String
        Dim res As String = ""
        Try
            'me pueden mandar el id, nombre o sigla y validaresmo
            res = StiGlobalConn.ObtenerDataset("select Direccion from Aseguradoras where IdAseguradora = " & dbStr(Aseguradora) & " or Nombre = " & dbStr(Aseguradora) & " or Siglas = " & dbStr(Aseguradora)).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            res = ""
        End Try
        Return res
    End Function

    Private Sub CompletarDireccionEnvio()
        Try
            Dim CodDestinatario As String = "", DireccionEnDocumento As String = ""
            Try
                CodDestinatario = CStr(dtDatos.Select("id = " & dbStr(cboTipoDocumento.Valor))(0)("Destinatario")).Trim.ToUpper
            Catch ex As Exception
                CodDestinatario = ""
            End Try

            For NF As Integer = 0 To Me.VistaDoc.DataRowCount - 1
                Select Case CodDestinatario
                    Case "", "CLIENTE"
                        DireccionEnDocumento = ObtenerDireccionCliente(txtIdCliente.Valor)
                    Case "ASEGURADORA"
                        DireccionEnDocumento = ObtenerDireccionAseguradora(VistaDoc.GetRowCellValue(NF, "Aseguradora"))
                End Select
                Try
                    VistaDoc.SetRowCellValue(NF, "Direccion", DireccionEnDocumento)
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtInicio_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtInicio.ValueChangeOnExit
        Call ObtenerDocumentos(Me.txtIdCliente.Valor)
        Call ActualizarListaFlujos()
    End Sub

    Private Sub txtFin_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFin.ValueChangeOnExit
        Call ObtenerDocumentos(Me.txtIdCliente.Valor)
        Call ActualizarListaFlujos()
    End Sub

    Public Function EnviarCorreoRetiroCorrespondencia(ByVal CorreoRemitente As String, ByVal PassWordRemitente As String, ByVal Destinatarios As String, ByVal DestinatariosCopia As String, ByVal DestinatariosOculto As String, ByVal Asunto As String, ByVal Mensaje As String, ByVal EsHTML As Boolean, ByVal ParamArray Attachment() As String) As String
        Dim res As String = ""
        Try
            'del usuario en curso obtenemos el nombre y el correo.
            Dim CorreoUsuario As String = CorreoRemitente
            Dim CorreoDestino As String = Destinatarios
            Dim CorreoCopia As String = DestinatariosCopia
            Dim CorreoOculto As String = DestinatariosOculto

            If CorreoDestino.Trim = "" And CorreoCopia.Trim = "" Then
                'sin correos destino no se hace nada
                Return "No hay destinatarios de correo"
            End If

            Dim NumCorreos As Integer = 0
            Dim Correo As String = ""
            Dim msg As New System.Net.Mail.MailMessage
            Dim Destino As New System.Net.Mail.MailAddress(CorreoUsuario)
            msg.From = Destino

            'tenemos que armar una lista con los correos
            If CorreoDestino.Trim <> "" Then
                CorreoDestino = Replace(CorreoDestino, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoDestino, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoDestino, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.To.Add(Correo)
                    End If
                Next
            End If

            'ahora veremos si hay copia a alguien
            If CorreoCopia.Trim <> "" Then
                CorreoCopia = Replace(CorreoCopia, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoCopia, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoCopia, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.CC.Add(Correo)
                    End If
                Next
            End If

            'veremos si hay copia oculta
            If CorreoOculto.Trim <> "" Then
                CorreoOculto = Replace(CorreoOculto, ";", ",").Trim
                NumCorreos = CuentaCar(CorreoOculto, ",")
                For NC As Integer = 0 To NumCorreos
                    Correo = stiSplit(CorreoOculto, "G" & NC & ",1").Trim
                    If Correo <> "" Then
                        msg.Bcc.Add(Correo)
                    End If
                Next
            End If


            For I As Integer = 0 To Attachment.GetLength(0) - 1
                If Not Attachment(I) Is Nothing Then
                    If Attachment(I) <> "" And Dir(Attachment(I)) <> "" Then
                        'si hay error en el archivo se pasa por alto
                        Try
                            msg.Attachments.Add(New System.Net.Mail.Attachment(Attachment(I)))
                        Catch ex As Exception

                        End Try
                    End If
                End If
            Next
            msg.Subject = Asunto
            msg.IsBodyHtml = EsHTML
            msg.Body = Mensaje
            msg.Priority = Net.Mail.MailPriority.Normal
            Dim SMTPServer As String = clSeguros.ObtenerDBParametros("Correo.Servidor")
            If SMTPServer.Trim = "" Then
                'MsgBox("No se ha definido el servidor de correo en el sistema. Verifique los parámetros.", MsgBoxStyle.Information, "AVISO...")
                Return "No se ha definido servidor de correo"
            End If
            Dim EmailServer As New System.Net.Mail.SmtpClient(SMTPServer)

            EmailServer.Credentials = New System.Net.NetworkCredential(CorreoUsuario, PassWordRemitente)


            If clSeguros.ObtenerDBParametros("Correo.SSL").ToString.Trim.ToUpper = "S" Then
                EmailServer.EnableSsl = True
            End If

            If clSeguros.ObtenerDBParametros("Correo.Puerto").ToString.Trim.ToUpper <> "" Then
                EmailServer.Port = CInt(clSeguros.ObtenerDBParametros("Correo.Puerto").ToString.Trim.ToUpper)
            End If

            EmailServer.Send(msg)
        Catch ex As Exception
            res = ex.ToString
        End Try
        Return res
    End Function

    Private Sub chkDocSiniestro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDocSiniestro.CheckedChanged
        Call ActualizarListaFlujos()
    End Sub

End Class
