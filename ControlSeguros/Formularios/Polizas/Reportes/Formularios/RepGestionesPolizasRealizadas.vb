﻿imports Utilerias.Genericas

Public Class RepGestionesPolizasRealizadas

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim sql As String = ""
            sql = "  select "
            sql &= " g.FechaGestion"
            sql &= " ,g.FechaProximaGestion"
            sql &= " ,g.Comentarios"
            sql &= " ,gor.NombreGestion as GestionHecha"
            sql &= " ,gfi.NombreGestion as GestionARealizar"
            sql &= " ,p.NombreCliente "
            sql &= " ,(select top 1 isnull(Telefono,'') from ClientesContactos as cc where cc.IdCliente = c.IdCliente order by IdContacto asc) as Telefono"
            sql &= " ,c.EMail"
            sql &= " ,p.IdPoliza"
            sql &= " , pr.Descripcion as Producto"
            sql &= " , a.Nombre as Aseguradora"
            sql &= " ,u.NombreUsuario as Usuario, g.FechaGrabacion"
            sql &= " from Gestiones as g"
            sql &= " left join TipoGestion as gor on gor.IdTipoGestion = g.IdTipoGestion"
            sql &= " left join TipoGestion as gfi on gfi.IdTipoGestion = g.IdAccionTomar"
            sql &= " left join Usuarios as u on u.IdUsuario = g.IdUsuario"
            sql &= " left join Polizas as p on p.IdProducto = g.IdProducto and p.IdPoliza = g.IdPoliza"
            If VisibilidadUsuario() = "D" Then
                sql &= " and p.Departamento = " & dbStr(DepartamentoUsuario())
            End If
            sql &= " left join Productos as pr on pr.idproducto = p.idproducto"
            sql &= " left join Aseguradoras as a on a.idaseguradora = pr.idaseguradora"
            sql &= " left join Clientes as c on c.idcliente = p.idcliente"
            sql &= " where g.TipoGestion = 'P'"
            sql &= " and g.FechaGestion between " & dbFec(txtFechaDesde.Valor) & " and " & dbfec(txtFechaHasta.Valor)
            sql &= " Order by g.FechaGestion desc"
            Dim dsGestion As DataSet = StiGlobalConn.ObtenerDataset(sql)
            Me.GridGestion.DataSource = dsGestion.Tables(0)
            Me.GridGestion.Refresh()

            If dsGestion.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron gestiones.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Gestiones" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridGestion.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Gestiones de Pólizas Realizadas", "Gestiones entre el " & Me.txtFechaDesde.Text & " y el " & Me.txtFechaHasta.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
            'AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepGestionesPolizasRealizadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
            Me.txtFechaHasta.Valor = Date.Today
        Catch ex As Exception

        End Try
    End Sub
End Class
