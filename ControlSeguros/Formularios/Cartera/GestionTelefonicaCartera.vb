Imports Utilerias.Genericas

Public Class GestionTelefonicaCartera

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'limpiamos los campos.
        txtFechaGestion.Valor = Date.Today
        Me.cboIdTipoGestion.Valor = "LT"
        Me.txtIdPoliza.Valor = ""
        Me.cboIdProducto.Valor = ""
        Me.txtNumeroFactura.Valor = ""
        Me.txtValorFactura.Valor = ""
        Me.txtComentario.Valor = ""
        Me.txtNombreCliente.Valor = ""
        Me.txtFechaVence.Valor = ""
        Me.txtFechaGestion.Focus()
    End Sub

    Private Sub btnBuscaPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Try
                Dim sql As String = ""

                sql = "  select p.IdPoliza, p.IdProducto, p.IdCliente, p.NombreCliente, p.VigenciaDesde, p.VigenciaHasta "
                sql &= " ,isnull(c.RegistroFiscal,'') as RegistroFiscal, c.NumeroTarjeta, c.TarjetaHabiente, c.VencimientoTarjeta"
                sql &= " from Polizas as p "
                sql &= " left join Clientes as c on c.idcliente = p.idcliente"
                sql &= " where p.IdPoliza =  " & dbStr(stiSplit(busCodigo, "G0|1")) & " and p.IdProducto = " & dbStr(stiSplit(busCodigo, "G1|1"))

                Dim FilPol As DataRow = StiGlobalConn.ObtenerDataset(sql).Tables(0).Rows(0)
                txtIdPoliza.Valor = dbData(FilPol, "IdPoliza")
                cboIdProducto.Valor = dbData(FilPol, "IdProducto")
                txtNombreCliente.Valor = dbData(FilPol, "NombreCliente")

                'ahora buscamos la factura más próxima
                txtNumeroFactura.Valor = ""
                txtValorFactura.Valor = ""
                txtFechaVence.Valor = ""

                sql = "  select top 1 f.NumeroFactura"
                sql &= " , isnull((select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and m.idramo = f.idramo and m.FechaMovimiento <= " & dbFec(txtFechaGestion.Valor) & "),0) as Total"
                sql &= " , f.FechaPago"

                sql &= " from facturas as f "
                sql &= " where "
                sql &= " f.idpoliza = " & dbStr(Me.txtIdPoliza.Valor)
                sql &= " and f.idproducto = " & dbStr(Me.cboIdProducto.Valor)

                'que la fecha de pago sea menor a la fecha de corte
                'sql &= " and f.FechaPago <= " & dbFec(txtFechaGestion.Valor)
                If VisibilidadUsuario() = "D" Then
                    sql &= " and (select count(*) from polizas as p where p.idpoliza = f.idpoliza and p.idproducto = f.idproducto and p.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
                End If
                'que tengan saldo positivo
                sql &= " and (select sum(Total) from FacturasMovimientos as m where m.NumeroFactura = f.NumeroFactura and m.IdProducto = f.IdProducto and m.IdPoliza = f.IdPoliza and FechaMovimiento <= " & dbFec(txtFechaGestion.Valor) & ") > " & Val(clSeguros.ObtenerDBParametros("Valor.Minimo.Primas.Pend"))
                sql &= " order by f.FechaPago asc"
                Dim dtFact As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
                If Not dtFact Is Nothing Then
                    For Each FilF As DataRow In dtFact.Rows
                        txtNumeroFactura.Valor = dbData(FilF, "NumeroFactura")
                        txtValorFactura.Valor = dbData(FilF, "Total")
                        txtFechaVence.Valor = dbData(FilF, "FechaPago")
                        Me.txtComentario.Focus()
                    Next
                End If
                If txtNumeroFactura.Text = "" Then
                    MsgBox("No se han encontrado facturas pendientes para la póliza.", MsgBoxStyle.Information, "AVISO...")
                End If

            Catch ex As Exception
                msgError(ex)
            End Try
        End If
    End Sub

    Private Sub GestionTelefonicaCartera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboIdProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdProducto.Llenar_Combo()

        Me.cboIdTipoGestion.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        Me.cboIdTipoGestion.Llenar_Combo()

        Call btnNuevo_Click(Nothing, Nothing)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim res As String = Me.ValidarCamposObligatorios(Me)
        If res <> "" Then
            MsgBox("Existen campos obligatorio que deben ser completados: " & res, MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Dim sql As String = ""
        Try
            sql = "  INSERT INTO Gestiones"
            sql &= " (IdGestion"
            sql &= " ,IdTipoGestion"
            sql &= " ,IdAccionTomar"
            sql &= " ,NumeroFactura"
            sql &= " ,IdProducto"
            sql &= " ,IdPoliza"
            sql &= " ,IdSiniestro"
            sql &= " ,FechaGestion"
            sql &= " ,FechaProximaGestion"
            sql &= " ,Comentarios"
            sql &= " ,TipoGestion"
            sql &= " ,IdUsuario"
            sql &= " ,IdCertificado"
            sql &= " ,FechaGrabacion)"
            sql &= " VALUES("
            sql &= " " & dbInt(clSeguros.ObtenerID("Gestion.Id"))
            sql &= " ," & dbStr(cboIdTipoGestion.Valor)
            sql &= " , null"
            sql &= " ," & dbStr(txtNumeroFactura.Valor)
            sql &= " ," & dbStr(cboIdProducto.Valor)
            sql &= " ," & dbStr(txtIdPoliza.Valor)
            sql &= " ,null"
            sql &= " ," & dbFec(txtFechaGestion.Valor)
            sql &= " ,null"
            sql &= " ," & dbStr(Me.txtComentario.Valor, 2000)
            sql &= " ,'C' "
            sql &= " ," & dbStr(StiGlobalConn.User, 25)
            sql &= " , null"
            sql &= " ," & dbFec(Date.Now, "1") & ")"

            StiGlobalConn.SQLExecute(sql)

            MsgBox("Gestión almacenada con éxito.", MsgBoxStyle.Information, "AVISO...")
            Call btnNuevo_Click(Nothing, Nothing)

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

End Class
