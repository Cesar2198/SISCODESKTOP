Imports Utilerias.Genericas

Public Class LstAnalisisOfertas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try
            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Ofertas " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.pivotOfertas.ExportToXls(Archivo, True)
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try

    End Sub

    Private Sub LstAnalisisOfertas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, Date.Today.Month, 1)
        Me.txtFechaHasta.Valor = DateSerial(Date.Today.Year, Date.Today.Month, Date.DaysInMonth(Date.Today.Year, Date.Today.Month))
    End Sub

    Private Sub CargarDatos()
        If Me.txtFechaDesde.Text = "" Or Me.txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar las fechas de consulta de ofertas.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= " IdOferta "
            sql &= ", Estado"
            sql &= ", FechaGraba"
            sql &= ", NombreCliente"
            sql &= ", VigenciaDesde"
            sql &= ", VigenciaHasta"
            sql &= ", MotivoRechazo"
            sql &= ", FechaRechazo"
            sql &= ", FechaAcepta"
            sql &= ", isnull((select usu.NombreUsuario from Usuarios as usu where usu.IdUsuario = ofe.EjecutivoCta),'') as EjecutivoCta"
            sql &= ", ReferidoPor"
            sql &= ", isnull((select usu.NombreUsuario from Usuarios as usu where usu.IdUsuario = ofe.UsuarioGrabacion),'') as UsuarioGrabacion"
            sql &= ", isnull((select usu.NombreUsuario from Usuarios as usu where usu.IdUsuario = ofe.UsuarioModificacion),'') as UsuarioModificacion"
            sql &= ", isnull((select ven.NombreVendedor from Vendedores as ven where ven.IdVendedor = ofe.NegocioPor),'') as NegocioPor"
            sql &= ", isnull((select distinct Nombre + ', ' from CGPolizasOfertas as cot inner join aseguradoras as ase on ase.idaseguradora = cot.idaseguradora  where cot.IdOferta = ofe.IdOferta for xml path('') ),'') as Aseguradora"
            sql &= ", Bienes"
            sql &= ", 1 as Contador"

            sql &= " from CGPolizas as ofe"
            sql &= " where ofe.FechaGraba between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(txtFechaHasta.Valor)

            Dim dtOfertas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            pivotOfertas.DataSource = dtOfertas
            pivotOfertas.Refresh()

            If dtOfertas.Rows.Count = 0 Then
                MsgBox("No se encontraron ofertas.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call CargarDatos()
    End Sub

End Class
