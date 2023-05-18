Imports Utilerias.Genericas

Public Class LstLlamadas

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Reporte Llamadas " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.PivotLlamadas.ExportToXls(Archivo, Opciones)
            'PrepararArchivoExcel(Archivo, "Reporte " & Me.Text, "Generación del Reporte: " & System.Environment.UserName & " " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss").ToUpper, "")
            AbrirArchivo(Archivo)
        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub LstLlamadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDesde.Valor = DateSerial(Now.Year, Now.Month, 1)
        Me.txtHasta.Valor = Date.Today
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If Me.txtDesde.Text = "" Or Me.txtHasta.Text = "" Then
                MsgBox("Debe especificar las fechas.", MsgBoxStyle.Information, "AVISO..")
                Exit Sub
            End If

            Dim sql As String = ""

            sql = "  select a.Fecha, a.Hora, b.NombreUsuario as UsuarioGraba"
            sql &= " , c.NombreUsuario as UsuarioPara"
            sql &= " ,a.PersonaLlama, a.Lugar, a.Telefono, a.EMail"
            sql &= " ,d.NombreCliente as Cliente"
            sql &= " ,a.Observaciones, 1 as NumLlamadas"
            sql &= " , case a.SePasoLlamada when 'S' then 'Si' else 'No' end as SePasoLlamada"
            sql &= " from RegistroLlamadas as a"
            sql &= " left join Usuarios as b on b.idusuario = a.UsuarioGraba"
            sql &= " left join Usuarios as c on c.idusuario = a.UsuarioPara"
            sql &= " left join Clientes as d on d.idcliente = a.idcliente"
            sql &= " where a.Fecha between " & dbFec(txtDesde.Valor) & " and " & dbFec(txtHasta.Valor)
            Dim dtLlamadas As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.PivotLlamadas.DataSource = dtLlamadas
            Me.PivotLlamadas.Refresh()

            If dtLlamadas.Rows.Count = 0 Then
                MsgBox("No se encontraron llamadas.", MsgBoxStyle.Information, "AVISO...")
            End If


        Catch ex As Exception
            msgError(ex)
        End Try
    End Sub

End Class
