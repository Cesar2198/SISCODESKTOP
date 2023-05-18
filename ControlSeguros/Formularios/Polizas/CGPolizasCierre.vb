Imports Utilerias.Genericas

Public Class CGPolizasCierre

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CGPolizasCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FechaCaja As DateTime = clSeguros.ObtenerDBParametros("Fecha.Ofertas")
        If FechaCaja.Year > 1 Then
            Me.txtFecha.Valor = FechaCaja
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtFecha.Text = "" Then
            MsgBox("Debe especificar la fecha de corte.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        try
            Dim sql As String = ""
            sql &= " select "
            sql &= " p.IdOferta"
            sql &= " , p.NombreCliente"
            sql &= " , p.ReferidoPor"
            sql &= " , r.NombreRamo as Producto"
            sql &= " , isnull(( select top 1 c.SumaAsegurada from CGPolizasOfertas as c where c.IdOferta = p.IdOferta order by IdCotizacion), 0.0) as SumaAsegurada "
            sql &= " , isnull(( select top 1 c.Total from CGPolizasOfertas as c where c.IdOferta = p.IdOferta order by IdCotizacion),0.0) as Prima"
            sql &= " , p.Bienes"
            sql &= " from CGPolizas as p"
            'sql &= " inner join CGPolizasOfertas as c on c.IdOferta = p.IdOferta"
            sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
            sql &= " where convert(varchar,p.FechaGraba,112) = " & dbFec(txtFecha.Valor)

            Dim dtOfertas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.gridOfertas.DataSource = dtOfertas
            Me.gridOfertas.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
        
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'cerramos el día de ofertas
        Dim dtDia As DataTable = StiGlobalConn.ObtenerDataset("select IdDiaOferta from DiasOfertas where FechaOfertas = " & dbFec(txtFecha.Valor) & " and UsuarioCierra is null").Tables(0)
        For Each filDia As DataRow In dtDia.Rows
            StiGlobalConn.SQLExecute("update DiasOfertas set UsuarioCierra = " & dbStr(StiGlobalConn.User) & " , FechaCierra = " & dbFec(Date.Now, "1") & " where IdDiaOferta = " & dbInt(dbData(filDia, "IdDiaOferta")))
        Next

        'generamos el reporte del día.
        Dim Reporte As New RepCierreOferta
        Dim Rep As New frmReportes
        Dim sql As String = ""

        sql &= " select "
        sql &= " p.IdOferta"
        sql &= " , p.NombreCliente"
        sql &= " , p.ReferidoPor"
        sql &= " , r.NombreRamo as Producto"
        sql &= " , isnull(( select top 1 c.SumaAsegurada from CGPolizasOfertas as c where c.IdOferta = p.IdOferta order by IdCotizacion), 0.0) as SumaAsegurada "
        sql &= " , isnull(( select top 1 c.Total from CGPolizasOfertas as c where c.IdOferta = p.IdOferta order by IdCotizacion),0.0) as Total"
        sql &= " , p.Bienes"
        sql &= " from CGPolizas as p"
        sql &= " left join RamoSeguros as r on r.IdRamo = p.IdRamo"
        sql &= " where convert(varchar,p.FechaGraba,112) = " & dbFec(txtFecha.Valor)

        Dim dtOfertas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
        dtOfertas.TableName = "Ofertas"

        If dtOfertas.Rows.Count = 0 Then
            Dim filOf As DataRow = dtOfertas.NewRow
            filOf("NombreCliente") = "No se registraron nuevas ofertas"
            dtOfertas.Rows.Add(filOf)
        End If


        Dim dsRep As New DataSet
        dsRep.Tables.Add(dtOfertas.Copy)
        dsRep.Tables.Add(tblLogo.Copy)

        Reporte.SetDataSource(dsRep)

        SetRepFormulaString(Reporte, "NombreEmpresa", ObtenerParametro("Cliente"))
        SetRepFormulaString(Reporte, "Titulo1", "Reporte de Cierre de Ofertas")
        SetRepFormulaString(Reporte, "Titulo2", "Fecha de corte: " & txtFecha.Text)
        SetRepFormulaString(Reporte, "Titulo3", "Reporte generado el " & Date.Now.ToString("dddd dd/MM/yyyy hh:mm tt"))

        SetRepFormulaString(Reporte, "Gerente", clSeguros.ObtenerDBParametros("Ofertas.Gerente.Nombre"))
        SetRepFormulaString(Reporte, "CargoGerente", clSeguros.ObtenerDBParametros("Ofertas.Gerente.Cargo"))
        SetRepFormulaString(Reporte, "Ejecutiva", clSeguros.ObtenerDBParametros("Ofertas.Ejecutiva.Nombre"))
        SetRepFormulaString(Reporte, "CargoEjecutivo", clSeguros.ObtenerDBParametros("Ofertas.Ejecutiva.Cargo"))

        Rep.CRViewer.ReportSource = Reporte
        Rep.MdiParent = frmPrincipal
        Rep.Show()

        MsgBox("La operación ha finalizado con éxito.", MsgBoxStyle.Information, "AVISO...")

    End Sub

End Class

