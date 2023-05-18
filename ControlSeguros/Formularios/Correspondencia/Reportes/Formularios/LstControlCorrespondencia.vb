Imports Utilerias.Genericas

Public Class LstControlCorrespondencia

    Private Sub LstControlCorrespondencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaDesde.Valor = DateSerial(Date.Today.Year, 1, 1)
        Me.txtFechaHasta.Valor = Date.Today

        Dim Ejecutivos As New DataTable
        Ejecutivos = StiGlobalConn.ObtenerDataset("select IdUsuario as Id, NombreUsuario as Usuario from Usuarios").Tables(0)
        RepositoryItemLookUpEdit1.ValueMember = "Id"
        RepositoryItemLookUpEdit1.DisplayMember = "Usuario"
        RepositoryItemLookUpEdit1.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit1.DataSource = Ejecutivos
        RepositoryItemLookUpEdit1.PopulateColumns()
        RepositoryItemLookUpEdit1.Columns("Id").Visible = False

        cboEjecutivoCta.StringConection = StiGlobalConn.ObtenerOledbConnectionString
        cboEjecutivoCta.Llenar_Combo()

        Dim dtDatos As DataTable = StiGlobalConn.ObtenerDataset("SELECT IdDocumento AS Id, NombreDocumento as Documento, Destinatario from DocumentosCorrespondencia order by Orden asc").Tables(0)
        cboTipoDocumento.Llenar_Combo(dtDatos)

        dtDatos = StiGlobalConn.ObtenerDataset("SELECT IdDocumento AS Id, IdDocumento + ' - ' + NombreDocumento as Documento from DocumentosCorrespondencia order by Orden asc").Tables(0)
        RepositoryItemLookUpEdit2.ValueMember = "Id"
        RepositoryItemLookUpEdit2.DisplayMember = "Documento"
        RepositoryItemLookUpEdit2.AutoSearchColumnIndex = 1
        RepositoryItemLookUpEdit2.DataSource = dtDatos
        RepositoryItemLookUpEdit2.PopulateColumns()
        RepositoryItemLookUpEdit2.Columns("Id").Visible = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Me.txtFechaDesde.Text = "" Then
            MsgBox("Debe especificar la fecha inicial.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        If Me.txtFechaHasta.Text = "" Then
            MsgBox("Debe especificar la fecha final.", MsgBoxStyle.Information, "AVISO...")
            Exit Sub
        End If

        Try
            Dim sql As String = ""

            sql = "  select "
            sql &= "  d.IdFlujoDoc, i.IdImpresion as Correlativo"
            sql &= " , i.FechaImpresion as Fecha"
            sql &= " , rtrim(ltrim(isnull(d.NombreCliente,'') + ' ' + isnull(a.nombre,''))) as Para"
            sql &= " , isnull('Anulado: ' + i.MotivoAnulacion, isnull(cast(i.Descripcion as varchar(max)) + ' ' + isnull(i.Claves,'') ,'')) as Asunto"
            sql &= " , u.NombreUsuario as Responsable"
            sql &= " , isnull((select InicialesFlujo from Clientes as c where c.idcliente = d.idcliente), '') as Grupo"
            sql &= " , i.FechaEnDocumento, i.TipoFlujo, isnull(i.NombreDestinatario,d.NombreCliente) as IdDestinatario"
            sql &= ", isnull((select usu.NombreUsuario from usuarios as usu where usu.idusuario = i.UsuarioImprime),'') as UsuarioImprime "
            sql &= ", i.CodImpresion"
            sql &= ", i.TipoDocumento"
            sql &= ", i.CantidadDocumentos"
            sql &= ", i.IdOrigen"
            sql &= " from FlujosDocumentos as d"
            sql &= " inner join FlujosDocumentosImpresiones as i on d.IdFlujoDoc = i.IdFlujoDoc"
            sql &= " left join Aseguradoras as a on a.idaseguradora = d.idaseguradora"
            sql &= " left join Usuarios as u on u.IdUsuario = d.IdUsuarioDestino"
            sql &= " where i.IdImpresion is not null "
            ''la fecha en analisis guarda la hora asi que validamos
            sql &= " and i.FechaImpresion between " & dbFec(txtFechaDesde.Valor) & " and " & dbFec(CDate(txtFechaHasta.Valor).ToShortDateString, "23:59:59")
            'sql &= " and i.TipoFlujo = 'SALIDA' "
            If cboEjecutivoCta.Valor <> "" Then
                sql &= " and i.UsuarioImprime = " & dbStr(cboEjecutivoCta.Valor)
            End If

            If cboTipoDocumento.Valor <> "" Then
                sql &= " and i.CodImpresion = " & dbStr(cboTipoDocumento.Valor)
            End If

            If VisibilidadUsuario() = "D" Then
                sql &= " and (select count(*) from polizas as pol where pol.idpoliza = d.idpoliza and pol.idproducto = d.idproducto and pol.Departamento = " & dbStr(DepartamentoUsuario()) & ") > 0 "
            End If

            Dim dtCorrespondencia As DataTable = StiGlobalConn.ObtenerDataset(sql).Tables(0)
            Me.GridCorrespondencia.DataSource = dtCorrespondencia
            Me.GridCorrespondencia.Refresh()

            If dtCorrespondencia.Rows.Count = 0 Then
                MsgBox("No se ha encontrado correspondencia en las fechas especificadas.", MsgBoxStyle.Information, "AVISO...")
            End If

        Catch ex As Exception
            msgError(ex)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'generamos en excel la vista de datos actual.
        Try

            Dim Archivo As String = ObtenerCarpetasEspeciales(TipoCarpetas.MisDocumentos) & "\Control Correspondencia " & Format(Date.Now, "ddMMyyyyhhmmss") & ".xls"
            Dim Opciones As New DevExpress.XtraPrinting.XlsExportOptions(True, False)
            Me.VistaCorrespondencia.ExportToXls(Archivo, Opciones)
            PrepararArchivoExcel(Archivo, "Reporte de Correspondencia de entrada y Salida entre el " & Me.txtFechaDesde.Text.Trim.ToUpper & " al " & Me.txtFechaHasta.Text.Trim.ToUpper, "", "Reporte al " & Format(Date.Now, "dd/MMM/yyyy hh:mm:ss"), clSeguros.ObtenerDBParametros("Password.Documentos"))

        Catch ex As Exception
            MsgBox("Error al intentar generar el reporte:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR...")
        End Try
    End Sub

    Private Sub ActualizarEjecutivo(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        Try
            Me.VistaCorrespondencia.PostEditor()

            'actualizamos el ejecutivo
            Dim Fila As Integer = Me.VistaCorrespondencia.FocusedRowHandle
            If Fila >= 0 Then
                Dim Ejecutivo As String = Me.VistaCorrespondencia.GetRowCellValue(Fila, "IdDestinatario")
                Dim CodFlujo As String = Me.VistaCorrespondencia.GetRowCellValue(Fila, "IdFlujoDoc")
                Dim CodImp As String = Me.VistaCorrespondencia.GetRowCellValue(Fila, "Correlativo")
                StiGlobalConn.SQLExecute("update FlujosDocumentosImpresiones set IdDestinatario = " & dbStr(Ejecutivo, 250) & " where IdFlujoDoc = " & dbStr(CodFlujo) & " and IdImpresion = " & dbStr(CodImp))
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
