Imports Utilerias.Genericas

Public Class LstActividadesOfertas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Ofertas " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            vistaOfertas.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte Diario de Ofertas", "Desde: " & Me.txtDesde.Text & " Hasta: " & Me.txtHasta.Text & " Reporte al: " & Date.Now.ToString("dd/MMM/yyyy hh:mm:ss tt"), "", "")
            'AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtDesde.Text = "" Or Me.txtHasta.Text = "" Then
            MsgBox("Debe especificar las fechas de consulta.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If
        Try
            Dim sql As String = ""

            sql = " select "
            sql &= "a.IdOferta"
            sql &= ",a.IdCotizacion"
            sql &= ",a.IdGestion"
            sql &= ",isnull((select u.NombreUsuario from usuarios as u where u.idusuario = a.usuario ),'') as Usuario"
            sql &= ",a.Fecha"
            sql &= ",a.Accion"
            sql &= ",isnull(b.nombreCliente, a.NombreCliente) as NombreCliente"
            sql &= ", isnull((select distinct Nombre + ', ' from CGPolizasOfertas as cot inner join aseguradoras as ase on ase.idaseguradora = cot.idaseguradora  where cot.IdOferta = b.IdOferta for xml path('') ),'') as Aseguradora"
            sql &= ", a.IdProducto, b.Bienes"
            sql &= " from CGPolizasLog as a"
            sql &= " left join CGPolizas as b on b.IdOferta = a.IdOferta"
            sql &= " where cast(convert(varchar,a.Fecha,112) as DateTime) between " & dbFec(txtDesde.Text) & " and " & dbFec(txtHasta.Text)
            sql &= " order by a.Accion, a.Fecha"

            Dim dtOfer As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            gridOfertas.DataSource = dtOfer
            gridOfertas.Refresh()

            If dtOfer.Rows.Count = 0 Then
                MsgBox("No hay datos que mostrar", MsgBoxStyle.Information, "AVISO...")
            End If
        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub LstActividadesOfertas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        try
            Me.txtDesde.Valor = Date.Today
            Me.txtHasta.Valor = Date.Today

            Dim dtProd As DataTable = StiGlobalConn.ObtenerDataset("select IdProducto as Id, Descripcion as Producto from Productos").Tables(0)

            cboIdProducto.ValueMember = "Id"
            cboIdProducto.DisplayMember = "Producto"
            cboIdProducto.DataSource = dtProd
            cboIdProducto.Columns(0).Visible = False
        Catch ex As Exception

        End Try

    End Sub

End Class
