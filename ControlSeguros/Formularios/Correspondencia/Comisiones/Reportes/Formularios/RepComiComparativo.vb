Imports Utilerias.Genericas

Public Class RepComiComparativo

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RepComiComparativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAseguradora.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboAseguradora.Llenar_Combo()
        cboTipoProducto.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboTipoProducto.Llenar_Combo()
        cboRamo.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboRamo.Llenar_Combo()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        Try

            Dim sql As String = ""
            sql = " select "
            sql &= " a.nombre as Aseguradora"
            sql &= " ,p.descripcion as Producto"
            sql &= " ,r.NombreRamo as Ramo"
            sql &= " ,ISNULL(c.PorceComi,0) / 100 as Porcentaje"
            sql &= " ,c.IdComision as Anio"
            sql &= " ,p.TipoProducto as TipoProducto"
            sql &= " from Productos as p"
            sql &= " inner join ProductosComisionesExternas as c on c.idproducto = p.idproducto"
            sql &= " inner join Aseguradoras as a on a.idaseguradora = p.idaseguradora"
            sql &= " inner join RamoSeguros as r on r.idramo = p.idramo"
            sql &= " where p.idproducto is not null"
            If cboAseguradora.Valor <> "" Then
                sql &= " and p.idaseguradora = " & dbStr(cboAseguradora.Valor)
            End If
            If cboTipoProducto.Valor <> "" Then
                sql &= " and p.TipoProducto = " & dbStr(cboTipoProducto.Valor)
            End If
            If cboRamo.Valor <> "" Then
                sql &= " and p.idramo = " & dbStr(cboRamo.Valor)
            End If
            Dim Comisiones As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.pivotComisiones.DataSource = Comisiones
            Me.pivotComisiones.Refresh()

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Comisiones " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.pivotComisiones.ExportToXls(Archivo, Opciones)

            PrepararArchivoExcel(Archivo, "Reporte de Comisiones", "", "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, clSeguros.ObtenerDBParametros("Password.Documentos"))
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

End Class
