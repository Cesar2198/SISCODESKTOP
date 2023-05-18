Imports Utilerias.Genericas

Public Class RepAnexosPoliza

    Private Sub btnBuscarPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPoliza.Click
        Dim Fbus As New BusquedaPolizas
        Fbus.Text = "Búsqueda de Pólizas"
        Fbus.dbFiltro = ""
        busCodigo = ""
        Fbus.ShowDialog()
        If busCodigo <> "" Then
            Me.txtPoliza.Valor = stiSplit(busCodigo, "G0|1")
            Me.cboProducto.Valor = stiSplit(busCodigo, "G1|1")
            'obtenemos el nombre del cliente
            Try
                Dim filPol As DataRow = StiGlobalConn.ObtenerDataset("select VigenciaDesde, VigenciaHasta, NombreCliente from Polizas where IdPoliza =  " & dbStr(txtPoliza.Valor) & " and IdProducto = " & dbStr(cboProducto.Valor)).Tables(0).Rows(0)
                Me.txtCliente.Valor = dbData(filPol, "NombreCliente")
                Me.txtDesde.Valor = dbData(filPol, "VigenciaDesde")
                Me.txtHasta.Valor = dbData(filPol, "VigenciaHasta")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Anexos" & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.GridAnexos.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Anexos para la póliza " & txtPoliza.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "", clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscarAnexos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAnexos.Click
        Try
            If Me.txtPoliza.Text = "" Or Me.cboProducto.Text = "" Then
                MsgBox("Debe especificar la pólizas.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            If txtDesde.Text = "" Or txtHasta.Text = "" Then
                MsgBox("Debe especificar el rango de fechas para buscar anexos.", MsgBoxStyle.Information, "AVISO...")
                Exit Sub
            End If

            Dim sql As String = ""

            'buscamos las inclusiones primero 
            sql = " select "
            sql &= " 'INCLUSION' as TipoAnexo"
            sql &= " ,a.IdCertificado as IdCertificado"
            sql &= " ,c.IdCertificadoAseguradora as IdCertificadoAseguradora"
            sql &= " ,c.NombreCliente as Asegurado"
            sql &= " ,a.FechaAnexo as FechaAnexo"
            sql &= " ,a.VigenciaDesde as VigenciaDesde"
            sql &= " ,a.VigenciaHasta as VigenciaHasta"
            sql &= " ,a.FechaIngreso as FechaIngreso"
            sql &= " ,null as FechaExclusion"
            sql &= " ,a.SumaAseguradaNueva as SumaAseguradaNueva"
            sql &= " ,a.PrimaAnexo as PrimaAnexo"
            sql &= " from PolizasCertificadosAnexos as a "
            sql &= " inner join PolizasCertificados as c on c.idpoliza = a.idpoliza and c.idproducto = a.idproducto and c.idcertificado = a.idcertificado"
            sql &= " where a.IdPoliza = " & dbStr(txtPoliza.Valor)
            sql &= " and a.idproducto = " & dbStr(cboProducto.Valor)
            sql &= " and a.IdCertificado + '*' + cast(a.idanexo as varchar) in "
            sql &= " ( select b.IdCertificado + '*' + cast(min(b.idanexo) as varchar) from  PolizasCertificadosAnexos as b where b.idpoliza = a.idpoliza and b.idproducto = a.idproducto and b.FechaIngreso between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor) & " group by b.IdCertificado ) "

            sql &= " union select "
            sql &= " 'EXCLUSION' as TipoAnexo"
            sql &= " ,a.IdCertificado as IdCertificado"
            sql &= " ,c.IdCertificadoAseguradora as IdCertificadoAseguradora"
            sql &= " ,c.NombreCliente as Asegurado"
            sql &= " ,a.FechaAnexo as FechaAnexo"
            sql &= " ,a.VigenciaDesde as VigenciaDesde"
            sql &= " ,a.VigenciaHasta as VigenciaHasta"
            sql &= " ,null as FechaIngreso"
            sql &= " ,a.FechaExclusion as FechaExclusion"
            sql &= " ,a.SumaAseguradaNueva as SumaAseguradaNueva"
            sql &= " ,a.PrimaAnexo as PrimaAnexo"
            sql &= " from PolizasCertificadosAnexos as a "
            sql &= " inner join PolizasCertificados as c on c.idpoliza = a.idpoliza and c.idproducto = a.idproducto and c.idcertificado = a.idcertificado"
            sql &= " where a.IdPoliza = " & dbStr(txtPoliza.Valor)
            sql &= " and a.idproducto = " & dbStr(cboProducto.Valor)
            sql &= " and a.IdCertificado + '*' + cast(a.idanexo as varchar) in "
            sql &= " ( select b.IdCertificado + '*' + cast(min(b.idanexo) as varchar) from  PolizasCertificadosAnexos as b where b.idpoliza = a.idpoliza and b.idproducto = a.idproducto and b.FechaExclusion between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor) & " group by b.IdCertificado ) "


            sql &= " union select "
            sql &= " 'MODIFICACION' as TipoAnexo"
            sql &= " ,a.IdCertificado as IdCertificado"
            sql &= " ,c.IdCertificadoAseguradora as IdCertificadoAseguradora"
            sql &= " ,c.NombreCliente as Asegurado"
            sql &= " ,a.FechaAnexo as FechaAnexo"
            sql &= " ,a.VigenciaDesde as VigenciaDesde"
            sql &= " ,a.VigenciaHasta as VigenciaHasta"
            sql &= " ,null as FechaIngreso"
            sql &= " ,null as FechaExclusion"
            sql &= " ,a.SumaAseguradaNueva as SumaAseguradaNueva"
            sql &= " ,a.PrimaAnexo as PrimaAnexo"
            sql &= " from PolizasCertificadosAnexos as a "
            sql &= " inner join PolizasCertificados as c on c.idpoliza = a.idpoliza and c.idproducto = a.idproducto and c.idcertificado = a.idcertificado"
            sql &= " where a.IdPoliza = " & dbStr(txtPoliza.Valor)
            sql &= " and a.idproducto = " & dbStr(cboProducto.Valor)
            sql &= " and a.VigenciaDesde between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor)
            sql &= " and a.IdCertificado + '*' + cast(a.idanexo as varchar) not in "
            sql &= " ( select b.IdCertificado + '*' + cast(min(b.idanexo) as varchar) from  PolizasCertificadosAnexos as b where b.idpoliza = a.idpoliza and b.idproducto = a.idproducto and b.FechaIngreso between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor) & " group by b.IdCertificado ) "
            sql &= " and a.IdCertificado + '*' + cast(a.idanexo as varchar) not in "
            sql &= " ( select b.IdCertificado + '*' + cast(min(b.idanexo) as varchar) from  PolizasCertificadosAnexos as b where b.idpoliza = a.idpoliza and b.idproducto = a.idproducto and b.FechaExclusion between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor) & " group by b.IdCertificado ) "



            Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            If dtDatos.Rows.Count = 0 Then MsgBox("No se encontraron anexos para la póliza y fecha especificada.", MsgBoxStyle.Information, "AVISO...")
            GridAnexos.DataSource = dtDatos
            GridAnexos.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub RepAnexosPoliza_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboProducto.Llenar_Combo()
    End Sub

End Class
