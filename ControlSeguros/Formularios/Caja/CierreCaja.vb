Imports Utilerias.Genericas

Public Class CierreCaja

    Dim CerrarSinRecibos As String = ""

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'validaremos que el día sea válido
        If Me.txtFechaCorte.Text = "" Then
            MsgBox("No hay día de caja pendiente por cerrar.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        
        'determina si se cierra sin recibos aplicados.
        If CerrarSinRecibos.Trim.ToUpper = "N" Then
            Dim dtRecibosPen As DataTable = StiGlobalConn.ObtenerDataset("select count(*) as Recibos from Recibos where FechaRecibo = " & dbFec(txtFechaCorte.Valor) & " and EstadoRecibo = 'P' ").Tables(0)
            If Val(dbData(dtRecibosPen.Rows(0), "Recibos")) > 0 Then
                MsgBox("Existen recibos pendientes de aplicarse, debe aplicar los recibos antes de cerrar caja.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If
        End If

        Try
            'imprimieremos un comprobante de cierre.
            Dim ImpCierre As String = ImprimirCierreCaja(txtFechaCorte.Valor, txtFechaCorte.Valor)
            If ImpCierre <> "" Then
                MsgBox("Problema al generar el cierre: " & ImpCierre, MsgBoxStyle.Exclamation, "Error..")
                Exit Sub
            End If

            RegistrarCierreCaja(txtFechaCorte.Valor)

            'finalmente dejamos libre el parametro de caja
            clSeguros.ActualizarDBParametros("Fecha.Caja", "")

            Me.LimpiarCampos(Me)

            MsgBox("El día de Caja ha sido cerrado con éxito puede imprimir el comprobante de cierre.", MsgBoxStyle.Information, "AVISO...")
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtFechaCorte.Text <> "" Then
            'buscaemos los movimientos del día
            Dim sql As String = ""
            sql = " select case p.IdTipoIngreso when 'C' then 'CHEQUE' when 'D' then 'DEPOSITO' when 'E' then 'EFECTIVO' when 'T' then 'TARJETA' when 'N' then 'NOTA DE CREDITO' when 'A' then 'DEPOSITO EN ASEGURADORA' end as Ingreso, sum(p.Total) as Total"
            sql &= " from recibos as r"
            sql &= " inner join RecibosPagos as p on r.idrecibo = p.idrecibo"
            sql &= " where FechaRecibo = " & dbFec(Me.txtFechaCorte.Valor)
            sql &= " and r.EstadoRecibo <> 'N'"
            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol inner join RecibosFacturas as f on pol.idpoliza = f.idpoliza and f.idproducto = pol.idproducto where f.IdRecibo = p.IdRecibo and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            sql &= " group by p.IdTipoIngreso"

            Dim dtIngreso As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridCaja.DataSource = dtIngreso
            Me.GridCaja.Refresh()

        End If
    End Sub

    Private Sub CierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFechaCorte.SoloLectura = False
        Try
            Me.txtFechaCorte.Valor = StiGlobalConn.ObtenerDataset("select top 1 fechacaja from DiasCaja where Fechacierre is null order by fechacaja asc").Tables(0).Rows(0).item(0)
            'clSeguros.ObtenerDBParametros("Fecha.Caja")
        Catch ex As Exception
            Me.txtFechaCorte.Valor = ""
        End Try

        CerrarSinRecibos = clSeguros.ObtenerDBParametros("Caja.Cerrar.Recibo")
        If CerrarSinRecibos Is Nothing Then CerrarSinRecibos = ""

        'If CerrarSinRecibos.Trim.ToUpper = "N" Then
        '    'Me.txtFechaCorte.SoloLectura = False
        '    'ya no aplica
        'Else

        'End If
        If txtFechaCorte.Text = "" Then
            MsgBox("No hay día de caja pendiente por cerrar.", MsgBoxStyle.Information, "AVISO...")
        else
            call btnBuscar_Click(nothing,nothing)
        End If

    End Sub

    Private Sub txtFechaCorte_ValueChangeOnExit(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal ValorAnterior As System.String) Handles txtFechaCorte.ValueChangeOnExit
         call btnBuscar_Click(nothing,nothing)
    End Sub
End Class
